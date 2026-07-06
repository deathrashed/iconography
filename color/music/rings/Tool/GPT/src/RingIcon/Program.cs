using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace RingIcon;

internal static class Program
{
    private const int DefaultSize = 1000;
    private const int DefaultPadding = 40;
    private const int DefaultSupersample = 3;
    private const int PreviewSize = 420;
    private static readonly string AppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config", "ringicon");
    private static readonly string PresetPath = Path.Combine(AppDir, "presets.json");
    private static readonly string RecentPath = Path.Combine(AppDir, "recent.json");
    private static readonly string[] SupportedExtensions = [".png", ".jpg", ".jpeg", ".webp", ".bmp", ".gif"];
    private static readonly HttpClient Http = new() { Timeout = TimeSpan.FromSeconds(30) };
    private const string UiPink = "#ff7ac6";
    private const string UiPurple = "#af87ff";
    private const string UiCyan = "#5fd7ff";
    private const string UiMuted = "#8a8a8a";
    private const string UiDim = "#5f5f5f";
    private const string UiText = "#d7d7d7";
    private const string UiGreen = "#00d787";
    private const string UiYellow = "#ffd75f";
    private const string UiRed = "#ff5f5f";

    private static readonly Dictionary<string, Rgba32> NamedColors = new(StringComparer.OrdinalIgnoreCase)
    {
        ["black"] = new(0, 0, 0),
        ["white"] = new(255, 255, 255),
        ["red"] = new(255, 0, 0),
        ["green"] = new(0, 170, 68),
        ["blue"] = new(0, 70, 255),
        ["orange"] = new(247, 147, 30),
        ["yellow"] = new(255, 221, 55),
        ["purple"] = new(134, 72, 255),
        ["pink"] = new(255, 84, 173),
        ["grey"] = new(128, 128, 128),
        ["gray"] = new(128, 128, 128),
        ["teal"] = new(0, 173, 181),
        ["cyan"] = new(27, 188, 205),
        ["gold"] = new(228, 184, 73),
        ["charcoal"] = new(17, 17, 17),
    };

    private static readonly Dictionary<string, RingPreset> BuiltInPresets = new(StringComparer.OrdinalIgnoreCase)
    {
        ["single-orange"] = new("single-orange", [new("orange", 32)]),
        ["black-green-black"] = new("black-green-black", [new("black", 8), new("green", 24), new("black", 8)]),
        ["black-yellow-red-black"] = new("black-yellow-red-black", [new("black", 12), new("yellow", 18), new("red", 18), new("black", 12)]),
        ["black-red-orange"] = new("black-red-orange", [new("black", 10), new("red", 22), new("orange", 18)]),
        ["thick-black-outline"] = new("thick-black-outline", [new("black", 48)]),
        ["thin-inner-ring"] = new("thin-inner-ring", [new("black", 8), new("white", 10)]),
        ["custom-layered"] = new("custom-layered", [new("black", 8), new("purple", 14), new("red", 18), new("black", 8)]),
        ["fymffyp"] = new("fymffyp", [new("#111111", 12), new("#f7f7f2", 38)]),
        ["808"] = new("808", [new("#1b1b1b", 8), new("#ffffff", 28)]),
    };

    public static int Main(string[] args)
    {
        try
        {
            if (args.Length == 0 || Has(args, "--tui"))
            {
                return Tui.Run();
            }

            if (Has(args, "--help") || Has(args, "-h"))
            {
                PrintHelp();
                return 0;
            }

            if (Has(args, "--list-presets"))
            {
                PresetStore store = PresetStore.Load(PresetPath);
                foreach (RingPreset preset in store.AllPresets().Values)
                {
                    Console.WriteLine($"{preset.Name}: {string.Join(",", preset.Rings.Where(r => r.Enabled).Select(r => r.ToConfigString()))}");
                }

                return 0;
            }

            Command command = Command.Parse(args);
            return new Runner(command).Run();
        }
        catch (ArgumentException ex)
        {
            Console.Error.WriteLine($"error: {ex.Message}");
            Console.Error.WriteLine("Run with --help for usage.");
            return 2;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"error: {ex.Message}");
            return 1;
        }
    }

    private static bool Has(string[] args, string name) => args.Any(a => string.Equals(a, name, StringComparison.OrdinalIgnoreCase));

    private static void PrintHelp()
    {
        Console.WriteLine("""
        RingIcon - fast album-art ring icon production tool

        Usage:
          ringicon                         Open production TUI
          ringicon --tui                   Open production TUI
          ringicon make <input> [options]  Make one transparent PNG
          ringicon batch <folder> [options] Make icons from a folder
          ringicon <input> [output] [options] Legacy shorthand for make

        Examples:
          ringicon
          ringicon make input.jpg --preset black-green-black --zoom 1.25 --x -40 --y 20 --out output.png
          ringicon make input.jpg --rings "black:8,green:24,black:8" --size 1000 --out output.png
          ringicon make "https://example.com/cover.jpg" --preset single-orange --out output.png
          ringicon batch ./covers --preset black-yellow-red-black --out ./rings --rename-existing

        Core options:
          --out <path>              Output file or folder.
          --size <px>               Output PNG size. Default: 1000.
          --padding <px>            Transparent padding outside outer ring. Default: 40.
          --zoom <factor>           Crop zoom. Default: 1.
          --x <px>                  Crop X offset. Negative moves left, positive moves right.
          --y <px>                  Crop Y offset. Negative moves up, positive moves down.
          --fill                    Fill circle by cropping source. Default.
          --fit                     Fit whole source image inside circle.
          --rings <spec>            Inner-to-outer rings: color:width[:gap[:opacity[:enabled]]].
          --preset <name>           Ring preset.
          --separator               Insert black 6px separators between colored rings.
          --overwrite               Replace existing output.
          --skip-existing           Skip existing output.
          --rename-existing         Auto-name output when destination exists.
          --dry-run                 Print planned jobs without writing.
          --json                    Print machine-readable JSON summary.
          --recursive               Batch folders recursively.
          --suffix <text>           Output suffix for auto names. Default: -ring.
          --url-file <path>         Text file containing one image URL per line.
          --clipboard-url           Read URL(s) from macOS clipboard, if available.
          --config <path>           Load render settings from JSON.

        Color input:
          Names: red, green, blue, orange, yellow, black, white, purple, pink, grey, gray.
          Hex: #ff0000, #00ff00, #f7931e, #111111, #ffffff, #rrggbbaa.
        """);
    }

    private sealed class Runner(Command command)
    {
        public int Run()
        {
            PresetStore store = PresetStore.Load(PresetPath);
            RenderSettings settings = command.Settings.ResolvePreset(store);
            IReadOnlyList<InputItem> inputs = InputResolver.Resolve(command);
            if (inputs.Count == 0)
            {
                throw new ArgumentException("no input images were found");
            }

            List<JobResult> results = [];
            foreach (InputItem input in inputs)
            {
                try
                {
                    string output = ResolveOutput(input, inputs.Count, command);
                    if (File.Exists(output))
                    {
                        if (command.OutputMode == OutputMode.Skip)
                        {
                            results.Add(JobResult.Skipped(input.Display, output, "output exists"));
                            continue;
                        }

                        if (command.OutputMode == OutputMode.Fail)
                        {
                            throw new IOException("output exists; use --overwrite, --skip-existing, or --rename-existing");
                        }

                        if (command.OutputMode == OutputMode.Rename)
                        {
                            output = NextAvailablePath(output);
                        }
                    }

                    if (command.DryRun)
                    {
                        results.Add(JobResult.DryRun(input.Display, output));
                        continue;
                    }

                    Directory.CreateDirectory(Path.GetDirectoryName(output) ?? ".");
                    using Image<Rgba32> source = Image.Load<Rgba32>(input.LocalPath);
                    using Image<Rgba32> icon = Renderer.Render(source, settings);
                    icon.SaveAsPng(output, PngOptions());
                    results.Add(JobResult.Success(input.Display, output));
                }
                catch (Exception ex)
                {
                    results.Add(JobResult.Failed(input.Display, null, ex.Message));
                }
                finally
                {
                    input.Cleanup();
                }
            }

            PrintSummary(results, command.Json);
            return results.Any(r => r.Status == "failed") ? 1 : 0;
        }

        private static string ResolveOutput(InputItem input, int inputCount, Command command)
        {
            string? output = command.OutputPath;
            if (inputCount == 1 && !string.IsNullOrWhiteSpace(output) && !Directory.Exists(output) && Path.HasExtension(output))
            {
                return Path.GetFullPath(output);
            }

            string outputFolder = string.IsNullOrWhiteSpace(output)
                ? Path.GetDirectoryName(input.LocalPath) ?? Environment.CurrentDirectory
                : Path.GetFullPath(output);
            string stem = SafeStem(input.SuggestedName);
            return Path.Combine(outputFolder, stem + command.Suffix + ".png");
        }

        private static string SafeStem(string name)
        {
            string stem = Path.GetFileNameWithoutExtension(name);
            foreach (char invalid in Path.GetInvalidFileNameChars())
            {
                stem = stem.Replace(invalid, '-');
            }

            return string.IsNullOrWhiteSpace(stem) ? "ring-icon" : stem;
        }

        private static string NextAvailablePath(string path)
        {
            string directory = Path.GetDirectoryName(path) ?? ".";
            string stem = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            for (int i = 2; i < 10000; i++)
            {
                string candidate = Path.Combine(directory, $"{stem}-{i}{extension}");
                if (!File.Exists(candidate))
                {
                    return candidate;
                }
            }

            throw new IOException("could not find an available output filename");
        }

        private static void PrintSummary(IReadOnlyList<JobResult> results, bool json)
        {
            if (json)
            {
                Console.WriteLine(JsonSerializer.Serialize(results, Json.Options));
                return;
            }

            foreach (JobResult result in results)
            {
                string target = result.Output is null ? "" : $" -> {result.Output}";
                Console.WriteLine($"{result.Status}: {result.Input}{target}{(result.Message is null ? "" : $" ({result.Message})")}");
            }

            int ok = results.Count(r => r.Status == "success");
            int skipped = results.Count(r => r.Status == "skipped" || r.Status == "dry-run");
            int failed = results.Count(r => r.Status == "failed");
            Console.WriteLine($"summary: {ok} written, {skipped} skipped/dry-run, {failed} failed");
        }
    }

    private static class Renderer
    {
        public static Image<Rgba32> Render(Image<Rgba32> source, RenderSettings settings)
        {
            settings.Validate();
            int scale = settings.Supersample;
            int size = settings.Size * scale;
            int padding = settings.Padding * scale;
            List<RingLayer> rings = settings.Rings
                .Where(r => r.Enabled)
                .Select(r => r.Scale(scale))
                .ToList();

            int ringFootprint = rings.Sum(r => r.Width + r.Gap);
            int outerDiameter = size - padding * 2;
            int imageDiameter = outerDiameter - ringFootprint * 2;
            if (imageDiameter < 8 * scale)
            {
                throw new ArgumentException("rings, gaps, and padding leave no usable image area");
            }

            using Image<Rgba32> render = new(size, size, SixLabors.ImageSharp.Color.Transparent);
            float center = size / 2f;
            float imageRadius = imageDiameter / 2f;
            using Image<Rgba32> crop = CropSource(source, imageDiameter, settings);
            PasteCircle(render, crop, (size - imageDiameter) / 2, (size - imageDiameter) / 2, center, center, imageRadius);

            float radius = imageRadius;
            foreach (RingLayer ring in rings)
            {
                radius += ring.Gap;
                FillRing(render, center, center, radius, radius + ring.Width, WithOpacity(ParseColor(ring.Color), ring.Opacity));
                radius += ring.Width;
            }

            if (scale == 1)
            {
                return render.Clone();
            }

            return render.Clone(ctx => ctx.Resize(new ResizeOptions
            {
                Size = new SixLabors.ImageSharp.Size(settings.Size, settings.Size),
                Mode = ResizeMode.Stretch,
                Sampler = KnownResamplers.Lanczos3,
                Compand = true
            }));
        }

        public static Image<Rgba32> CropPreview(Image<Rgba32> source, RenderSettings settings, int size)
        {
            RenderSettings preview = settings with { Size = size, Padding = 0, Supersample = 1, Rings = [] };
            int diameter = size;
            return CropSource(source, diameter, preview);
        }

        private static Image<Rgba32> CropSource(Image<Rgba32> source, int targetSize, RenderSettings settings)
        {
            if (settings.CropMode == CropMode.Fit)
            {
                Image<Rgba32> fitted = new(targetSize, targetSize, SixLabors.ImageSharp.Color.Transparent);
                using Image<Rgba32> resized = source.Clone(ctx => ctx.Resize(new ResizeOptions
                {
                    Size = new SixLabors.ImageSharp.Size(targetSize, targetSize),
                    Mode = ResizeMode.Max,
                    Sampler = KnownResamplers.Lanczos3,
                    Compand = true
                }));
                int fitX = (targetSize - resized.Width) / 2 + settings.CropX;
                int fitY = (targetSize - resized.Height) / 2 + settings.CropY;
                fitted.Mutate(ctx => ctx.DrawImage(resized, new Point(fitX, fitY), 1f));
                return fitted;
            }

            int shortest = Math.Min(source.Width, source.Height);
            int cropSize = Math.Max(1, (int)Math.Round(shortest / settings.Zoom));
            double sourcePerOutput = cropSize / (double)targetSize;
            int sourceOffsetX = (int)Math.Round(settings.CropX * sourcePerOutput);
            int sourceOffsetY = (int)Math.Round(settings.CropY * sourcePerOutput);
            int centerX = source.Width / 2 + sourceOffsetX;
            int centerY = source.Height / 2 + sourceOffsetY;
            int cropX = Math.Clamp(centerX - cropSize / 2, 0, Math.Max(0, source.Width - cropSize));
            int cropY = Math.Clamp(centerY - cropSize / 2, 0, Math.Max(0, source.Height - cropSize));

            return source.Clone(ctx => ctx
                .Crop(new Rectangle(cropX, cropY, cropSize, cropSize))
                .Resize(new ResizeOptions
                {
                    Size = new SixLabors.ImageSharp.Size(targetSize, targetSize),
                    Mode = ResizeMode.Stretch,
                    Sampler = KnownResamplers.Lanczos3,
                    Compand = true
                }));
        }

        private static void FillRing(Image<Rgba32> image, float centerX, float centerY, float innerRadius, float outerRadius, Rgba32 color)
        {
            float innerSquared = innerRadius * innerRadius;
            float outerSquared = outerRadius * outerRadius;
            int min = Math.Max(0, (int)Math.Floor(centerX - outerRadius));
            int max = Math.Min(image.Width - 1, (int)Math.Ceiling(centerX + outerRadius));

            image.ProcessPixelRows(accessor =>
            {
                for (int y = min; y <= max; y++)
                {
                    Span<Rgba32> row = accessor.GetRowSpan(y);
                    float dy = y + 0.5f - centerY;
                    for (int x = min; x <= max; x++)
                    {
                        float dx = x + 0.5f - centerX;
                        float distance = dx * dx + dy * dy;
                        if (distance >= innerSquared && distance <= outerSquared)
                        {
                            row[x] = color;
                        }
                    }
                }
            });
        }

        private static void PasteCircle(Image<Rgba32> destination, Image<Rgba32> source, int destinationX, int destinationY, float centerX, float centerY, float radius)
        {
            float radiusSquared = radius * radius;
            destination.ProcessPixelRows(source, (destinationAccessor, sourceAccessor) =>
            {
                for (int y = 0; y < source.Height; y++)
                {
                    int targetY = destinationY + y;
                    if (targetY < 0 || targetY >= destination.Height)
                    {
                        continue;
                    }

                    Span<Rgba32> destinationRow = destinationAccessor.GetRowSpan(targetY);
                    Span<Rgba32> sourceRow = sourceAccessor.GetRowSpan(y);
                    float dy = targetY + 0.5f - centerY;
                    for (int x = 0; x < source.Width; x++)
                    {
                        int targetX = destinationX + x;
                        if (targetX < 0 || targetX >= destination.Width)
                        {
                            continue;
                        }

                        float dx = targetX + 0.5f - centerX;
                        if (dx * dx + dy * dy <= radiusSquared)
                        {
                            destinationRow[targetX] = sourceRow[x];
                        }
                    }
                }
            });
        }
    }

    private static class Tui
    {
        public static int Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Directory.CreateDirectory(AppDir);
            PresetStore presets = PresetStore.Load(PresetPath);
            RecentState recent = RecentState.Load(RecentPath);
            Workbench state = new()
            {
                OutputPath = recent.LastOutput ?? "/Volumes/Apfspace/Icons/color/music/rings/Tool/GPT/samples/tui-export.png",
                Settings = new RenderSettings { Rings = presets.AllPresets()["black-green-black"].Rings.Select(r => r.Copy()).ToList() },
            };
            if (!string.IsNullOrWhiteSpace(recent.LastInput))
            {
                state.LoadInput(recent.LastInput);
            }
            else if (File.Exists("/Users/rd/Downloads/cover.jpg"))
            {
                state.LoadInput("/Users/rd/Downloads/cover.jpg");
            }

            bool running = true;
            while (running)
            {
                DrawWorkbench(state, presets);
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                try
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            state.Settings = state.Settings with { CropX = state.Settings.CropX - MoveStep(key) };
                            break;
                        case ConsoleKey.RightArrow:
                            state.Settings = state.Settings with { CropX = state.Settings.CropX + MoveStep(key) };
                            break;
                        case ConsoleKey.UpArrow:
                            state.Settings = state.Settings with { CropY = state.Settings.CropY - MoveStep(key) };
                            break;
                        case ConsoleKey.DownArrow:
                            state.Settings = state.Settings with { CropY = state.Settings.CropY + MoveStep(key) };
                            break;
                        case ConsoleKey.Add:
                        case ConsoleKey.OemPlus:
                            state.Settings = state.Settings with { Zoom = Math.Round(state.Settings.Zoom + 0.05, 2) };
                            break;
                        case ConsoleKey.Subtract:
                        case ConsoleKey.OemMinus:
                            state.Settings = state.Settings with { Zoom = Math.Max(0.1, Math.Round(state.Settings.Zoom - 0.05, 2)) };
                            break;
                        case ConsoleKey.D0:
                        case ConsoleKey.NumPad0:
                            state.Settings = state.Settings with { CropX = 0, CropY = 0, Zoom = 1, CropMode = CropMode.Fill };
                            break;
                        case ConsoleKey.Enter:
                            ExportCurrent(state, recent);
                            break;
                        case ConsoleKey.V:
                            WritePreviewFile(state, open: true);
                            break;
                        case ConsoleKey.I:
                            PickInput(state, recent);
                            break;
                        case ConsoleKey.O:
                            state.OutputPath = AskPath("Output file/folder", state.OutputPath);
                            recent.RememberOutput(state.OutputPath);
                            break;
                        case ConsoleKey.P:
                            ApplyPreset(state, presets);
                            break;
                        case ConsoleKey.R:
                            EditRings(state);
                            break;
                        case ConsoleKey.C:
                            EditRingColor(state);
                            break;
                        case ConsoleKey.S:
                            SavePreset(state, presets);
                            break;
                        case ConsoleKey.B:
                            BatchExport(state, recent);
                            break;
                        case ConsoleKey.F:
                            state.Settings = state.Settings with { CropMode = state.Settings.CropMode == CropMode.Fill ? CropMode.Fit : CropMode.Fill };
                            break;
                        case ConsoleKey.Tab:
                            state.NextInput();
                            break;
                        case ConsoleKey.Q:
                        case ConsoleKey.Escape:
                            running = false;
                            break;
                    }

                    state.InvalidatePreview();
                    recent.Save(RecentPath);
                }
                catch (Exception ex)
                {
                    state.Status = "Error: " + ex.Message;
                }
            }

            return 0;
        }

        private static int MoveStep(ConsoleKeyInfo key) => key.Modifiers.HasFlag(ConsoleModifiers.Shift) ? 25 : 8;

        private static void DrawWorkbench(Workbench state, PresetStore presets)
        {
            Console.Clear();
            AnsiConsole.Write(HeaderPanel(state));
            int width = SafeConsoleWidth();
            if (width < 104)
            {
                AnsiConsole.Write(ProductionPanel(state, width - 4, compact: true));
                AnsiConsole.Write(InputPanel(state, width - 4, compact: true));
            }
            else if (width < 150)
            {
                int inputWidth = Math.Clamp(width / 3, 32, 42);
                int productionWidth = Math.Max(58, width - inputWidth - 6);
                Grid grid = new();
                grid.AddColumn(new GridColumn().Width(inputWidth));
                grid.AddColumn(new GridColumn().Width(productionWidth));
                grid.AddRow(InputPanel(state, inputWidth, compact: true), ProductionPanel(state, productionWidth, compact: false));
                AnsiConsole.Write(grid);
            }
            else
            {
                int inputWidth = Math.Clamp(width / 5, 32, 40);
                int controlWidth = Math.Clamp(width / 4, 34, 44);
                int productionWidth = Math.Max(56, width - inputWidth - controlWidth - 8);
                Grid grid = new();
                grid.AddColumn(new GridColumn().Width(inputWidth));
                grid.AddColumn(new GridColumn().Width(productionWidth));
                grid.AddColumn(new GridColumn().Width(controlWidth));
                grid.AddRow(InputPanel(state, inputWidth, compact: false), ProductionPanel(state, productionWidth, compact: false), ControlPanel(state, presets, controlWidth));
                AnsiConsole.Write(grid);
            }

            AnsiConsole.Write(StatusPanel(state));
        }

        private static int SafeConsoleWidth()
        {
            try
            {
                return Console.WindowWidth > 0 ? Console.WindowWidth : 160;
            }
            catch
            {
                return 160;
            }
        }

        private static Panel HeaderPanel(Workbench state)
        {
            int enabled = state.Settings.Rings.Count(r => r.Enabled);
            string file = state.Current is null ? "[grey]no input[/]" : Markup.Escape(Path.GetFileName(state.Current.SuggestedName));
            string queue = state.Inputs.Count > 1 ? $"{state.Inputs.Count} queued" : "single";
            string phase = state.Status.StartsWith("Error:", StringComparison.Ordinal) ? $"[{UiRed}]error[/]" : $"[{UiPurple}]ready[/]";
            string bar = ProgressBar(Math.Clamp((state.Settings.Zoom - 0.5) / 2.5, 0, 1), 22, UiPurple);
            string line1 = $"[bold {UiPink}]RingIcon[/] [{UiMuted}]album-art ring icon production bench[/]";
            string line2 = string.Join("   ",
                $"[{UiMuted}]source[/] [{UiText}]{file}[/]",
                $"[{UiMuted}]queue[/] [{UiPurple}]{Markup.Escape(queue)}[/]",
                $"[{UiMuted}]crop[/] [{UiCyan}]{state.Settings.CropMode}[/]",
                $"[{UiMuted}]rings[/] [{UiPurple}]{enabled}[/]",
                $"[{UiMuted}]zoom[/] {bar} [{UiText}]{state.Settings.Zoom:0.00}x[/]",
                $"[{UiMuted}]phase[/] {phase}");
            return new Panel($"{line1}\n{line2}")
                .RoundedBorder()
                .BorderColor(Spectre.Console.Color.Grey35)
                .Padding(1, 0, 1, 0);
        }

        private static Panel InputPanel(Workbench state, int width, bool compact)
        {
            int textWidth = Math.Clamp(width - 16, 18, compact ? 26 : 34);
            List<string> lines =
            [
                $"[bold {UiPurple}]1  ARTWORK[/]",
                SidebarLine("source", state.Current is null ? Muted("none loaded") : Value(Path.GetFileName(state.Current.SuggestedName))),
                SidebarLine("path", state.Current is null ? Muted("press I") : Value(Shorten(state.Current.Display, textWidth))),
                SidebarLine("queue", Accent($"{state.Inputs.Count} image{(state.Inputs.Count == 1 ? "" : "s")}", UiPurple)),
                "",
                $"[bold {UiPink}]INPUT QUEUE[/]"
            ];

            if (state.Inputs.Count == 0)
            {
                lines.Add($"  {Muted("press I to add artwork")}");
            }
            else
            {
                for (int i = 0; i < Math.Min(12, state.Inputs.Count); i++)
                {
                    string marker = i == state.CurrentIndex ? $"[{UiCyan}]▸[/]" : $"[{UiDim}]·[/]";
                    string name = Markup.Escape(Path.GetFileName(state.Inputs[i].SuggestedName));
                    lines.Add($"{marker}  {(i == state.CurrentIndex ? $"[bold {UiText}]{name}[/]" : $"[{UiMuted}]{name}[/]")}");
                }
            }

            lines.Add("");
            lines.Add($"[bold {UiPurple}]4  EXPORT TARGET[/]");
            lines.Add(SidebarLine("out", Value(Shorten(state.OutputPath, textWidth))));
            lines.Add("");
            lines.Add($"[bold {UiPink}]QUEUE[/]");
            lines.Add(ActionLine("i", compact ? "load artwork" : "load file/folder/url"));
            lines.Add(ActionLine("tab", "next image"));
            lines.Add(ActionLine("o", "set output"));

            return new Panel(new Markup(string.Join('\n', lines)))
                .Header($"[bold {UiPink}] Artwork [/]")
                .RoundedBorder()
                .BorderColor(Spectre.Console.Color.Grey35);
        }

        private static Panel ProductionPanel(Workbench state, int width, bool compact)
        {
            Grid grid = new();
            grid.AddColumn();
            grid.AddRow(new Markup(WorkflowRail(state, width, compact)));
            grid.AddRow(new Markup(""));
            grid.AddRow(new Rule($"[{UiPink}]2  Crop[/]").RuleStyle(UiDim).LeftJustified());
            grid.AddRow(CropBoard(state, width, compact));
            grid.AddRow(new Markup(""));
            grid.AddRow(new Rule($"[{UiPink}]3  Ring Stack[/] [{UiMuted}]inner -> outer[/]").RuleStyle(UiDim).LeftJustified());
            grid.AddRow(RingRecipe(state.Settings.Rings, width, compact));
            grid.AddRow(new Markup(""));
            grid.AddRow(ExportBoard(state, width, compact));

            return new Panel(grid)
                .Header($"[bold {UiPink}] Make Icon [/]")
                .RoundedBorder()
                .BorderColor(Spectre.Console.Color.Grey54);
        }

        private static Panel ControlPanel(Workbench state, PresetStore presets, int width)
        {
            bool compact = width < 38;
            List<string> lines =
            [
                $"[bold {UiPurple}]CROP[/]",
                ActionLine("arrows", "move crop"),
                ActionLine("shift", "move faster"),
                ActionLine("+ / -", "zoom in/out"),
                ActionLine("0", "reset crop"),
                ActionLine("f", "toggle fit/fill"),
                "",
                $"[bold {UiPurple}]RINGS[/]",
                ActionLine("r", "edit stack"),
                ActionLine("c", "edit colour"),
                ActionLine("p", "apply preset"),
                ActionLine("s", "save preset"),
                "",
                $"[bold {UiPurple}]OUTPUT[/]",
                ActionLine("v", "real PNG preview"),
                ActionLine("enter", "export current"),
                ActionLine("b", "batch export"),
                "",
                $"[bold {UiPink}]PRESETS[/]"
            ];
            foreach (string preset in presets.AllPresets().Keys.Take(compact ? 5 : 7))
            {
                lines.Add($"[{UiPurple}]›[/]  [{UiText}]{Markup.Escape(Shorten(preset, compact ? 22 : 30))}[/]");
            }

            return new Panel(new Markup(string.Join('\n', lines)))
                .Header($"[bold {UiPink}] Actions [/]")
                .RoundedBorder()
                .BorderColor(Spectre.Console.Color.Grey35);
        }

        private static string WorkflowRail(Workbench state, int width, bool compact)
        {
            string artwork = state.Current is null ? "missing" : Path.GetFileName(state.Current.SuggestedName);
            string crop = $"{state.Settings.CropMode} {state.Settings.Zoom:0.00}x";
            string rings = $"{state.Settings.Rings.Count(r => r.Enabled)} rings";
            string export = Path.HasExtension(state.OutputPath) ? Path.GetFileName(state.OutputPath) : Shorten(state.OutputPath, 24);
            if (compact)
            {
                return string.Join("  ",
                    StepBadge("1 Art", artwork, state.Current is not null, 12),
                    StepBadge("2 Crop", crop, true, 12),
                    StepBadge("3 Rings", rings, state.Settings.Rings.Any(r => r.Enabled), 10),
                    StepBadge("4 Out", export, !string.IsNullOrWhiteSpace(state.OutputPath), 12));
            }

            return string.Join($" [{UiDim}]->[/] ",
                StepBadge("1 Artwork", artwork, state.Current is not null, width < 74 ? 12 : 18),
                StepBadge("2 Crop", crop, true, 18),
                StepBadge("3 Rings", rings, state.Settings.Rings.Any(r => r.Enabled), 18),
                StepBadge("4 Export", export, !string.IsNullOrWhiteSpace(state.OutputPath), width < 74 ? 14 : 20));
        }

        private static string StepBadge(string label, string value, bool ready, int valueWidth)
        {
            string color = ready ? UiPurple : UiDim;
            return $"[bold {color}]{Markup.Escape(label)}[/] [{UiMuted}]{Markup.Escape(Shorten(value, valueWidth))}[/]";
        }

        private static IRenderable CropBoard(Workbench state, int width, bool compact)
        {
            Table table = new Table().NoBorder().HideHeaders();
            int labelWidth = compact ? 7 : 11;
            int gaugeWidth = Math.Clamp(width - (compact ? 34 : 42), 14, compact ? 22 : 30);
            table.AddColumn(new TableColumn("control").Width(labelWidth));
            table.AddColumn(new TableColumn("value").Width(gaugeWidth + 9));
            if (!compact)
            {
                table.AddColumn("keys");
            }

            if (compact)
            {
                table.AddRow($"[bold {UiCyan}]zoom[/]", Gauge(state.Settings.Zoom, 0.5, 3, gaugeWidth, UiCyan) + $" [bold {UiText}]{state.Settings.Zoom:0.00}x[/]");
                table.AddRow($"[bold {UiPurple}]x[/]", SignedGauge(state.Settings.CropX, 160, gaugeWidth, UiPurple) + " " + PositionMarkup(state.Settings.CropX));
                table.AddRow($"[bold {UiPink}]y[/]", SignedGauge(state.Settings.CropY, 160, gaugeWidth, UiPink) + " " + PositionMarkup(state.Settings.CropY));
                table.AddRow(Muted("mode"), state.Settings.CropMode == CropMode.Fill ? Accent("fill circle", UiCyan) : Accent("fit whole image", UiYellow));
            }
            else
            {
                table.AddRow($"[bold {UiCyan}]zoom[/]", Gauge(state.Settings.Zoom, 0.5, 3, gaugeWidth, UiCyan) + $" [bold {UiText}]{state.Settings.Zoom:0.00}x[/]", HintText("+ / -"));
                table.AddRow($"[bold {UiPurple}]horizontal[/]", SignedGauge(state.Settings.CropX, 160, gaugeWidth, UiPurple) + " " + PositionMarkup(state.Settings.CropX), HintText("left / right"));
                table.AddRow($"[bold {UiPink}]vertical[/]", SignedGauge(state.Settings.CropY, 160, gaugeWidth, UiPink) + " " + PositionMarkup(state.Settings.CropY), HintText("up / down"));
                table.AddRow(Muted("mode"), state.Settings.CropMode == CropMode.Fill ? Accent("fill circle", UiCyan) : Accent("fit whole image", UiYellow), HintText("f"));
            }

            return table;
        }

        private static IRenderable RingRecipe(IReadOnlyList<RingLayer> rings, int width, bool compact)
        {
            Table table = new Table()
                .NoBorder()
                .HideHeaders()
                .Expand();
            table.AddColumn(new TableColumn("ring").Width(compact ? 4 : 6));
            table.AddColumn(new TableColumn("width").Width(compact ? 16 : Math.Clamp(width / 4, 18, 24)));
            table.AddColumn(new TableColumn("settings").Width(compact ? Math.Clamp(width - 28, 20, 42) : Math.Clamp(width / 2, 30, 48)));
            if (!compact)
            {
                table.AddColumn("edit");
            }

            for (int i = 0; i < rings.Count; i++)
            {
                RingLayer ring = rings[i];
                string muted = ring.Enabled ? "" : $" [{UiDim}]off[/]";
                string details = compact
                    ? $"{ColorChip(ring.Color)} {ColorName(ring.Color)} [bold {UiText}]{ring.Width}px[/]{muted}"
                    : $"{ColorChip(ring.Color)} {ColorName(ring.Color)} [bold {UiText}]{ring.Width}px[/] [{UiMuted}]gap {ring.Gap}px op {ring.Opacity:0.##}[/]{muted}";
                if (compact)
                {
                    table.AddRow($"[{UiMuted}]#{i + 1}[/]", RingBar(ring), details);
                }
                else
                {
                    table.AddRow($"[{UiMuted}]#{i + 1}[/]", RingBar(ring), details, i == 0 ? HintText("r edit stack") : "");
                }
            }

            if (rings.Count == 0)
            {
                if (compact)
                {
                    table.AddRow("", Muted("no rings configured"), "");
                }
                else
                {
                    table.AddRow("", Muted("no rings configured"), "", HintText("r add"));
                }
            }

            return table;
        }

        private static IRenderable ExportBoard(Workbench state, int width, bool compact)
        {
            Table table = new Table().NoBorder().HideHeaders();
            table.AddColumn(new TableColumn("label").Width(compact ? 8 : 10));
            table.AddColumn("value");
            string output = state.Current is null ? state.OutputPath : state.ResolveOutput(state.Current);
            int pathWidth = Math.Clamp(width - 18, 24, compact ? 54 : 82);
            string preview = state.LastPreviewPath is null ? "not rendered this session" : Shorten(state.LastPreviewPath, pathWidth);
            table.AddRow($"[bold {UiPink}]EXPORT[/]", $"[{UiText}]{Markup.Escape(Shorten(output, pathWidth))}[/]");
            table.AddRow(Muted("preview"), state.LastPreviewPath is null ? Muted(preview) : $"[{UiGreen}]{Markup.Escape(preview)}[/]");
            if (!compact)
            {
                table.AddRow(Muted("keys"), $"{KeyLite("enter")} {Muted("export current")}   {KeyLite("v")} {Muted("preview PNG")}   {KeyLite("b")} {Muted("batch queue")}");
            }
            return table;
        }

        private static string HintText(string value) => $"[{UiMuted}]{Markup.Escape(value)}[/]";

        private static Panel StatusPanel(Workbench state)
        {
            string shortcuts = string.Join(" ",
                Key("←↑↓→", "move"),
                Key("⇧ arrows", "fast"),
                Key("+/-", "zoom"),
                Key("0", "reset"),
                Key("F", "fit/fill"),
                Key("I", "input"),
                Key("O", "output"),
                Key("R", "rings"),
                Key("C", "colour"),
                Key("P", "preset"),
                Key("V", "png preview"),
                Key("⏎", "export"),
                Key("Q", "quit"));
            string status = state.Status.StartsWith("Error:", StringComparison.Ordinal)
                ? $"[{UiRed}]{Markup.Escape(state.Status)}[/]"
                : state.Status.StartsWith("Exported", StringComparison.Ordinal) || state.Status.StartsWith("Batch exported", StringComparison.Ordinal)
                    ? $"[{UiGreen}]{Markup.Escape(state.Status)}[/]"
                    : $"[{UiPurple}]{Markup.Escape(state.Status)}[/]";
            return new Panel($"{shortcuts}\n{status}")
                .RoundedBorder()
                .BorderColor(Spectre.Console.Color.Grey35);
        }

        private static Table CropTable(Workbench state)
        {
            Table table = new Table().NoBorder().HideHeaders();
            table.AddColumn(new TableColumn("label").Width(8));
            table.AddColumn("bar");
            int gaugeWidth = SafeConsoleWidth() < 132 ? 20 : 28;
            table.AddRow(Muted("zoom"), Gauge(state.Settings.Zoom, 0.5, 3, gaugeWidth, UiCyan) + $" [bold {UiText}]{state.Settings.Zoom:0.00}x[/]");
            table.AddRow(Muted("x"), SignedGauge(state.Settings.CropX, 160, gaugeWidth, UiPurple) + " " + PositionMarkup(state.Settings.CropX));
            table.AddRow(Muted("y"), SignedGauge(state.Settings.CropY, 160, gaugeWidth, UiPink) + " " + PositionMarkup(state.Settings.CropY));
            return table;
        }

        private static Table RingStackTable(IReadOnlyList<RingLayer> rings)
        {
            Table table = new Table().NoBorder().HideHeaders();
            table.AddColumn(new TableColumn("ring").Width(6));
            table.AddColumn(new TableColumn("layer").Width(32));
            table.AddColumn("syntax");
            for (int i = 0; i < rings.Count; i++)
            {
                RingLayer ring = rings[i];
                string bar = RingBar(ring);
                string syntax = HighlightRingSyntax(ring);
                table.AddRow($"[grey]#{i + 1}[/]", bar, syntax);
            }

            return table;
        }

        private static string RingBar(RingLayer ring)
        {
            int width = Math.Clamp(ring.Width / 2, 1, 18);
            int gap = Math.Clamp(ring.Gap / 2, 0, 8);
            string color = ring.Enabled ? SafeMarkupColor(ring.Color) : "#666666";
            string gapText = gap == 0 ? "" : $"[grey]{new string('·', gap)}[/]";
            return $"{gapText}[{color}]{new string('█', width)}[/]";
        }

        private static string HighlightRingSyntax(RingLayer ring)
        {
            string color = ring.Enabled ? SafeMarkupColor(ring.Color) : "#777777";
            return $"[{color}]{Markup.Escape(ring.Color)}[/][{UiDim}]:[/][{UiText}]{ring.Width}[/][{UiDim}]:[/][{UiCyan}]{ring.Gap}[/][{UiDim}]:[/][{UiPurple}]{ring.Opacity:0.##}[/]";
        }

        private static string Gauge(double value, double min, double max, int width, string color)
        {
            double t = Math.Clamp((value - min) / (max - min), 0, 1);
            int filled = (int)Math.Round(t * width);
            return $"[{color}]{new string('█', filled)}[/][{UiDim}]{new string('░', Math.Max(0, width - filled))}[/]";
        }

        private static string SignedGauge(int value, int maxAbs, int width, string color)
        {
            int half = width / 2;
            double t = Math.Clamp(Math.Abs(value) / (double)maxAbs, 0, 1);
            int fill = (int)Math.Round(t * half);
            string left = value < 0 ? $"[{color}]{new string('█', fill)}[/][{UiDim}]{new string('░', half - fill)}[/]" : $"[{UiDim}]{new string('░', half)}[/]";
            string right = value > 0 ? $"[{color}]{new string('█', fill)}[/][{UiDim}]{new string('░', half - fill)}[/]" : $"[{UiDim}]{new string('░', half)}[/]";
            return left + $"[{UiText}]│[/]" + right;
        }

        private static string PositionMarkup(int value) => value switch
        {
            < 0 => $"[{UiPink}]{value}[/]",
            > 0 => $"[{UiCyan}]+{value}[/]",
            _ => $"[{UiMuted}]0[/]"
        };

        private static string Key(string key, string label) => $"[{UiCyan}]{Markup.Escape(key)}[/] [{UiMuted}]{Markup.Escape(label)}[/]";

        private static string KeyLite(string key) => $"[{UiCyan}]{Markup.Escape(key)}[/]";

        private static string ColorChip(string color)
        {
            string markupColor = SafeMarkupColor(color);
            return $"[{markupColor}]●[/]";
        }

        private static string ColorName(string color) => $"[{SafeMarkupColor(color)}]{Markup.Escape(color)}[/]";

        private static string WorkflowLabel(string label) => $"[{UiPink}]{Markup.Escape(label)}[/]";

        private static string SidebarLine(string label, string value) => $"{WorkflowLabel(label)}{new string(' ', Math.Max(1, 10 - label.Length))}{value}";

        private static string ActionLine(string key, string label) => $"  {KeyLite(key)}{new string(' ', Math.Max(1, 8 - key.Length))}{Muted(label)}";

        private static string Value(string value) => $"[{UiText}]{Markup.Escape(value)}[/]";

        private static string Muted(string value) => $"[{UiMuted}]{Markup.Escape(value)}[/]";

        private static string Accent(string value, string color) => $"[{color}]{Markup.Escape(value)}[/]";

        private static string ProgressBar(double value, int width, string color)
        {
            int filled = (int)Math.Round(Math.Clamp(value, 0, 1) * width);
            return $"[{color}]{new string('█', filled)}[/][{UiDim}]{new string('░', Math.Max(0, width - filled))}[/]";
        }

        private static string SafeMarkupColor(string color)
        {
            try
            {
                Rgba32 parsed = ParseColor(color);
                return ToHex(parsed);
            }
            catch
            {
                return "#999999";
            }
        }

        private static string CurrentCommandHint(Workbench state)
        {
            string input = state.Current?.SuggestedName ?? "cover.jpg";
            string output = Path.HasExtension(state.OutputPath) ? state.OutputPath : "./rings";
            string rings = string.Join(",", state.Settings.Rings.Where(r => r.Enabled).Select(r => r.ToConfigString()));
            return $"ringicon make {input} --rings \"{rings}\" --zoom {state.Settings.Zoom:0.##} --x {state.Settings.CropX} --y {state.Settings.CropY} --out {output}";
        }

        private static void PickInput(Workbench state, RecentState recent)
        {
            Console.Clear();
            string mode = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("[bold]Input source[/]")
                .AddChoices("Local image file", "Local folder", "HTTP/HTTPS image URL", "Multiple URLs", "Text file containing URLs", "Clipboard URL"));

            List<InputItem> inputs = mode switch
            {
                "Local image file" => [InputItem.Local(AskPath("Image file", recent.LastInput ?? "/Users/rd/Downloads/cover.jpg"))],
                "Local folder" => InputResolver.FromFolder(AskPath("Folder", recent.LastInput ?? "/Users/rd/Downloads"), recursive: false),
                "HTTP/HTTPS image URL" => [InputResolver.FromUrl(AnsiConsole.Ask<string>("Image URL:"))],
                "Multiple URLs" => InputResolver.FromUrls(AnsiConsole.Ask<string>("URLs separated by spaces:").Split(' ', StringSplitOptions.RemoveEmptyEntries)),
                "Text file containing URLs" => InputResolver.FromUrlFile(AskPath("URL text file", Environment.CurrentDirectory)),
                "Clipboard URL" => InputResolver.FromClipboardUrl(),
                _ => []
            };

            foreach (InputItem input in state.Inputs)
            {
                input.Cleanup();
            }

            state.Inputs = inputs;
            state.CurrentIndex = 0;
            if (inputs.Count > 0)
            {
                recent.RememberInput(inputs[0].Display);
                state.Status = $"Loaded {inputs.Count} input(s)";
            }
        }

        private static void ApplyPreset(Workbench state, PresetStore presets)
        {
            Console.Clear();
            string name = AnsiConsole.Prompt(new SelectionPrompt<string>().Title("[bold]Ring preset[/]").PageSize(12).AddChoices(presets.AllPresets().Keys));
            state.Settings.Rings = presets.AllPresets()[name].Rings.Select(r => r.Copy()).ToList();
            state.Status = "Preset applied: " + name;
        }

        private static void EditRingColor(Workbench state)
        {
            if (state.Settings.Rings.Count == 0)
            {
                state.Settings.Rings.Add(new RingLayer("orange", 32));
            }

            Console.Clear();
            int index = AnsiConsole.Prompt(new SelectionPrompt<int>().Title("[bold]Edit colour for ring[/]").AddChoices(Enumerable.Range(1, state.Settings.Rings.Count))) - 1;
            string color = AnsiConsole.Ask("Colour name or hex:", state.Settings.Rings[index].Color);
            _ = ParseColor(color);
            state.Settings.Rings[index] = state.Settings.Rings[index] with { Color = color };
            state.Status = $"Ring {index + 1} colour set to {color}";
        }

        private static void EditRings(Workbench state)
        {
            bool editing = true;
            while (editing)
            {
                Console.Clear();
                AnsiConsole.Write(ControlPanel(state, new PresetStore(), Math.Min(SafeConsoleWidth() - 4, 44)));
                string action = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("[bold]Rings are inner to outer[/]")
                    .AddChoices("Set full ring config", "Add ring", "Edit ring", "Remove ring", "Move ring", "Toggle ring", "Add black separators", "Done"));

                switch (action)
                {
                    case "Set full ring config":
                        string spec = AnsiConsole.Ask("Rings color:width[:gap[:opacity]], inner-to-outer:", string.Join(",", state.Settings.Rings.Select(r => r.ToConfigString())));
                        state.Settings.Rings = ParseRings(spec);
                        break;
                    case "Add ring":
                        state.Settings.Rings.Add(AskRing(new RingLayer("orange", 32)));
                        break;
                    case "Edit ring":
                        int edit = AskRingIndex(state);
                        state.Settings.Rings[edit] = AskRing(state.Settings.Rings[edit]);
                        break;
                    case "Remove ring":
                        state.Settings.Rings.RemoveAt(AskRingIndex(state));
                        break;
                    case "Move ring":
                        int from = AskRingIndex(state);
                        int to = AnsiConsole.Ask("New position:", from + 1) - 1;
                        to = Math.Clamp(to, 0, state.Settings.Rings.Count - 1);
                        RingLayer ring = state.Settings.Rings[from];
                        state.Settings.Rings.RemoveAt(from);
                        state.Settings.Rings.Insert(to, ring);
                        break;
                    case "Toggle ring":
                        int toggle = AskRingIndex(state);
                        state.Settings.Rings[toggle] = state.Settings.Rings[toggle] with { Enabled = !state.Settings.Rings[toggle].Enabled };
                        break;
                    case "Add black separators":
                        state.Settings.Rings = AddBlackSeparators(state.Settings.Rings);
                        break;
                    case "Done":
                        editing = false;
                        break;
                }
            }
        }

        private static RingLayer AskRing(RingLayer current)
        {
            string color = AnsiConsole.Ask("Colour name or hex:", current.Color);
            _ = ParseColor(color);
            int width = AnsiConsole.Ask("Width px:", current.Width);
            int gap = AnsiConsole.Ask("Transparent gap before this ring px:", current.Gap);
            double opacity = AnsiConsole.Ask("Opacity 0-1:", current.Opacity);
            bool enabled = AnsiConsole.Confirm("Enabled?", current.Enabled);
            return new RingLayer(color, width, gap, opacity, enabled);
        }

        private static int AskRingIndex(Workbench state)
        {
            if (state.Settings.Rings.Count == 0)
            {
                throw new ArgumentException("there are no rings to edit");
            }

            return AnsiConsole.Prompt(new SelectionPrompt<int>().Title("[bold]Ring[/]").AddChoices(Enumerable.Range(1, state.Settings.Rings.Count))) - 1;
        }

        public static List<RingLayer> AddBlackSeparators(IReadOnlyList<RingLayer> rings)
        {
            List<RingLayer> output = [];
            foreach (RingLayer ring in rings)
            {
                if (!ring.Color.Equals("black", StringComparison.OrdinalIgnoreCase) && !ring.Color.Equals("#000000", StringComparison.OrdinalIgnoreCase))
                {
                    output.Add(new RingLayer("black", 6, ring.Gap));
                    output.Add(ring with { Gap = 0 });
                    output.Add(new RingLayer("black", 6));
                }
                else
                {
                    output.Add(ring);
                }
            }

            return output;
        }

        private static void SavePreset(Workbench state, PresetStore presets)
        {
            Console.Clear();
            string name = AnsiConsole.Ask<string>("Preset name:", "custom-layered");
            presets.Custom[name] = new RingPreset(name, state.Settings.Rings.Select(r => r.Copy()).ToList());
            presets.Save(PresetPath);
            state.Status = "Saved preset: " + name;
        }

        private static void ExportCurrent(Workbench state, RecentState recent)
        {
            if (state.Current is null)
            {
                state.Status = "No input loaded";
                return;
            }

            string output = state.ResolveOutput(state.Current);
            Directory.CreateDirectory(Path.GetDirectoryName(output) ?? ".");
            using Image<Rgba32> source = Image.Load<Rgba32>(state.Current.LocalPath);
            using Image<Rgba32> icon = Renderer.Render(source, state.Settings);
            icon.SaveAsPng(output, PngOptions());
            recent.RememberOutput(output);
            recent.Save(RecentPath);
            state.Status = "Exported " + output;
        }

        private static void WritePreviewFile(Workbench state, bool open)
        {
            if (state.Current is null)
            {
                state.Status = "No input loaded";
                return;
            }

            string previewDir = Path.Combine(AppDir, "previews");
            Directory.CreateDirectory(previewDir);
            string previewPath = Path.Combine(previewDir, Path.GetFileNameWithoutExtension(state.Current.SuggestedName) + "-preview.png");
            using Image<Rgba32> source = Image.Load<Rgba32>(state.Current.LocalPath);
            using Image<Rgba32> icon = Renderer.Render(source, state.Settings);
            icon.SaveAsPng(previewPath, PngOptions());
            state.LastPreviewPath = previewPath;
            state.Status = "Preview written " + previewPath;

            if (open)
            {
                OpenPath(previewPath);
            }
        }

        private static void BatchExport(Workbench state, RecentState recent)
        {
            int total = state.Inputs.Count;
            if (total == 0)
            {
                state.Status = "No input queue for batch";
                return;
            }

            int written = 0;
            AnsiConsole.Progress()
                .Start(ctx =>
                {
                    ProgressTask task = ctx.AddTask("Batch export", maxValue: total);
                    foreach (InputItem input in state.Inputs)
                    {
                        string output = state.ResolveOutput(input);
                        Directory.CreateDirectory(Path.GetDirectoryName(output) ?? ".");
                        using Image<Rgba32> source = Image.Load<Rgba32>(input.LocalPath);
                        using Image<Rgba32> icon = Renderer.Render(source, state.Settings);
                        icon.SaveAsPng(output, PngOptions());
                        written++;
                        task.Increment(1);
                    }
                });
            recent.RememberOutput(state.OutputPath);
            state.Status = $"Batch exported {written}/{total}";
        }

        private static string AskPath(string label, string fallback)
        {
            string value = AnsiConsole.Ask(label + ":", fallback);
            return ExpandPath(value);
        }

        private static void OpenPath(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "open",
                    ArgumentList = { path },
                    UseShellExecute = false,
                });
            }
            catch
            {
                // Non-macOS or restricted shell: preview file is still written.
            }
        }
    }

    private sealed class Workbench
    {
        private string? previewMarkup;
        private string? previewKey;

        public List<InputItem> Inputs { get; set; } = [];
        public int CurrentIndex { get; set; }
        public InputItem? Current => Inputs.Count == 0 ? null : Inputs[Math.Clamp(CurrentIndex, 0, Inputs.Count - 1)];
        public string OutputPath { get; set; } = "";
        public RenderSettings Settings { get; set; } = new();
        public string Status { get; set; } = "Ready";
        public string? LastPreviewPath { get; set; }

        public void LoadInput(string path)
        {
            Inputs = File.Exists(path) ? [InputItem.Local(path)] : Directory.Exists(path) ? InputResolver.FromFolder(path, false) : [];
            CurrentIndex = 0;
        }

        public void NextInput()
        {
            if (Inputs.Count > 0)
            {
                CurrentIndex = (CurrentIndex + 1) % Inputs.Count;
            }
        }

        public string ResolveOutput(InputItem input)
        {
            if (Path.HasExtension(OutputPath) && Inputs.Count == 1)
            {
                return Path.GetFullPath(OutputPath);
            }

            string folder = string.IsNullOrWhiteSpace(OutputPath)
                ? Path.GetDirectoryName(input.LocalPath) ?? Environment.CurrentDirectory
                : OutputPath;
            return Path.Combine(folder, Path.GetFileNameWithoutExtension(input.SuggestedName) + "-ring.png");
        }

        public void InvalidatePreview() => previewKey = null;

        public string GetPreviewMarkup()
        {
            if (Current is null)
            {
                return "\n\n[grey]Press I to load album artwork[/]\n\n";
            }

            string key = Current.LocalPath + JsonSerializer.Serialize(Settings, Json.Options);
            if (previewKey == key && previewMarkup is not null)
            {
                return previewMarkup;
            }

            using Image<Rgba32> source = Image.Load<Rgba32>(Current.LocalPath);
            using Image<Rgba32> icon = Renderer.Render(source, Settings with { Size = PreviewSize, Supersample = 1 });
            using Image<Rgba32> preview = icon.Clone(ctx => ctx.Resize(new ResizeOptions
            {
                Size = new SixLabors.ImageSharp.Size(32, 32),
                Mode = ResizeMode.Max,
                Sampler = KnownResamplers.NearestNeighbor
            }));

            previewMarkup = ToMarkupPreview(preview);
            previewKey = key;
            return previewMarkup;
        }
    }

    private sealed class Command
    {
        public string Mode { get; init; } = "make";
        public List<string> Inputs { get; init; } = [];
        public string? OutputPath { get; init; }
        public string? UrlFile { get; init; }
        public bool ClipboardUrl { get; init; }
        public bool Recursive { get; init; }
        public bool DryRun { get; init; }
        public bool Json { get; init; }
        public string Suffix { get; init; } = "-ring";
        public OutputMode OutputMode { get; init; } = OutputMode.Fail;
        public RenderSettings Settings { get; init; } = new();

        public static Command Parse(string[] args)
        {
            string mode = args[0] is "make" or "batch" ? args[0] : "make";
            int start = mode == args[0] ? 1 : 0;
            Dictionary<string, List<string>> options = new(StringComparer.OrdinalIgnoreCase);
            List<string> positionals = [];

            for (int i = start; i < args.Length; i++)
            {
                string arg = args[i];
                if (!arg.StartsWith("-", StringComparison.Ordinal))
                {
                    positionals.Add(arg);
                    continue;
                }

                string name = arg;
                string? value = null;
                int equals = arg.IndexOf('=');
                if (equals > 0)
                {
                    name = arg[..equals];
                    value = arg[(equals + 1)..];
                }

                if (IsFlag(name))
                {
                    options[name] = ["true"];
                    continue;
                }

                value ??= i + 1 < args.Length ? args[++i] : throw new ArgumentException($"missing value for {name}");
                if (!options.TryGetValue(name, out List<string>? values))
                {
                    values = [];
                    options[name] = values;
                }

                values.Add(value);
            }

            RenderSettings settings = options.TryGetValue("--config", out List<string>? config)
                ? LoadSettings(config.Last())
                : new RenderSettings();

            settings = settings with
            {
                Size = GetInt(options, "--size", settings.Size),
                Padding = GetInt(options, "--padding", settings.Padding),
                Zoom = GetDouble(options, "--zoom", settings.Zoom),
                CropX = GetInt(options, "--x", GetInt(options, "--offset-x", settings.CropX)),
                CropY = GetInt(options, "--y", GetInt(options, "--offset-y", settings.CropY)),
                CropMode = GetBool(options, "--fit", false) ? CropMode.Fit : CropMode.Fill,
                Supersample = GetInt(options, "--supersample", settings.Supersample),
                Preset = Last(options, "--preset") ?? settings.Preset,
            };

            if (options.TryGetValue("--rings", out List<string>? rings))
            {
                settings.Rings = ParseRings(rings.Last());
            }
            else if (options.TryGetValue("--ring", out List<string>? ringValues))
            {
                settings.Rings = ringValues.SelectMany(ParseRings).ToList();
            }

            if (GetBool(options, "--separator", false))
            {
                settings.Rings = Tui.AddBlackSeparators(settings.Rings);
            }

            List<string> inputs = [];
            if (mode == "batch" && positionals.Count > 0)
            {
                inputs.Add(positionals[0]);
            }
            else
            {
                inputs.AddRange(positionals.Take(1));
            }

            string? output = Last(options, "--out") ?? Last(options, "--output") ?? (mode == "make" && positionals.Count > 1 ? positionals[1] : null);
            OutputMode outputMode = GetBool(options, "--overwrite", false) ? OutputMode.Overwrite :
                GetBool(options, "--skip-existing", false) ? OutputMode.Skip :
                GetBool(options, "--rename-existing", false) ? OutputMode.Rename :
                OutputMode.Fail;

            Command command = new()
            {
                Mode = mode,
                Inputs = inputs,
                OutputPath = output,
                UrlFile = Last(options, "--url-file"),
                ClipboardUrl = GetBool(options, "--clipboard-url", false),
                Recursive = GetBool(options, "--recursive", false),
                DryRun = GetBool(options, "--dry-run", false),
                Json = GetBool(options, "--json", false),
                Suffix = Last(options, "--suffix") ?? "-ring",
                OutputMode = outputMode,
                Settings = settings,
            };

            command.Settings.Validate();
            return command;
        }

        private static bool IsFlag(string name) => name is "--overwrite" or "--skip-existing" or "--rename-existing" or "--dry-run" or "--json" or "--recursive" or "--fill" or "--fit" or "--separator" or "--clipboard-url";
    }

    private static class InputResolver
    {
        public static IReadOnlyList<InputItem> Resolve(Command command)
        {
            List<InputItem> inputs = [];
            if (command.Mode == "batch")
            {
                string folder = command.Inputs.FirstOrDefault() ?? throw new ArgumentException("batch input folder is required");
                inputs.AddRange(FromFolder(ExpandPath(folder), command.Recursive));
            }
            else
            {
                foreach (string input in command.Inputs)
                {
                    inputs.Add(IsUrl(input) ? FromUrl(input) : InputItem.Local(ExpandPath(input)));
                }
            }

            if (!string.IsNullOrWhiteSpace(command.UrlFile))
            {
                inputs.AddRange(FromUrlFile(command.UrlFile));
            }

            if (command.ClipboardUrl)
            {
                inputs.AddRange(FromClipboardUrl());
            }

            return inputs;
        }

        public static List<InputItem> FromFolder(string folder, bool recursive)
        {
            if (!Directory.Exists(folder))
            {
                throw new ArgumentException($"input folder does not exist: {folder}");
            }

            return Directory.EnumerateFiles(folder, "*", recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                .Where(IsSupported)
                .Select(InputItem.Local)
                .ToList();
        }

        public static List<InputItem> FromUrls(IEnumerable<string> urls) => urls.Where(u => !string.IsNullOrWhiteSpace(u)).Select(FromUrl).ToList();

        public static List<InputItem> FromUrlFile(string path)
        {
            string fullPath = ExpandPath(path);
            if (!File.Exists(fullPath))
            {
                throw new ArgumentException($"URL file does not exist: {fullPath}");
            }

            return FromUrls(File.ReadLines(fullPath).Select(l => l.Trim()).Where(l => l.Length > 0 && !l.StartsWith('#')));
        }

        public static List<InputItem> FromClipboardUrl()
        {
            try
            {
                using System.Diagnostics.Process process = System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "pbpaste",
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                }) ?? throw new InvalidOperationException("pbpaste did not start");
                string text = process.StandardOutput.ReadToEnd();
                process.WaitForExit(2000);
                return FromUrls(text.Split(new[] { '\n', '\r', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Where(IsUrl));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("could not read clipboard URL: " + ex.Message);
            }
        }

        public static InputItem FromUrl(string url)
        {
            if (!IsUrl(url))
            {
                throw new ArgumentException($"not an HTTP/HTTPS URL: {url}");
            }

            Directory.CreateDirectory(Path.Combine(AppDir, "downloads"));
            Uri uri = new(url);
            string extension = Path.GetExtension(uri.AbsolutePath);
            if (string.IsNullOrWhiteSpace(extension))
            {
                extension = ".img";
            }

            string file = Path.Combine(AppDir, "downloads", Guid.NewGuid().ToString("N") + extension);
            byte[] bytes = Http.GetByteArrayAsync(uri).GetAwaiter().GetResult();
            File.WriteAllBytes(file, bytes);
            return new InputItem(file, url, Path.GetFileName(uri.AbsolutePath), Temporary: true);
        }
    }

    private sealed record InputItem(string LocalPath, string Display, string SuggestedName, bool Temporary)
    {
        public static InputItem Local(string path)
        {
            string fullPath = ExpandPath(path);
            if (!File.Exists(fullPath))
            {
                throw new ArgumentException($"input file does not exist: {fullPath}");
            }

            if (!IsSupported(fullPath))
            {
                throw new ArgumentException($"unsupported input extension: {Path.GetExtension(fullPath)}");
            }

            return new InputItem(fullPath, fullPath, Path.GetFileName(fullPath), Temporary: false);
        }

        public void Cleanup()
        {
            if (Temporary)
            {
                try { File.Delete(LocalPath); } catch { }
            }
        }
    }

    private sealed record RenderSettings
    {
        public int Size { get; init; } = DefaultSize;
        public int Padding { get; init; } = DefaultPadding;
        public double Zoom { get; init; } = 1;
        public int CropX { get; init; }
        public int CropY { get; init; }
        public CropMode CropMode { get; init; } = CropMode.Fill;
        public int Supersample { get; init; } = DefaultSupersample;
        public string? Preset { get; init; }
        public List<RingLayer> Rings { get; set; } = [new("orange", 32)];

        public RenderSettings ResolvePreset(PresetStore store)
        {
            if (string.IsNullOrWhiteSpace(Preset))
            {
                return this;
            }

            Dictionary<string, RingPreset> all = store.AllPresets();
            if (!all.TryGetValue(Preset, out RingPreset? preset))
            {
                throw new ArgumentException($"unknown preset '{Preset}'. Run --list-presets.");
            }

            return this with { Rings = preset.Rings.Select(r => r.Copy()).ToList() };
        }

        public void Validate()
        {
            if (Size is < 64 or > 8192)
            {
                throw new ArgumentException("--size must be between 64 and 8192");
            }

            if (Padding < 0 || Padding >= Size / 2)
            {
                throw new ArgumentException("--padding must be >= 0 and less than half of --size");
            }

            if (Zoom <= 0 || Zoom > 20)
            {
                throw new ArgumentException("--zoom must be greater than 0 and no more than 20");
            }

            if (Supersample is < 1 or > 4)
            {
                throw new ArgumentException("--supersample must be between 1 and 4");
            }

            if (Rings.Count == 0 || Rings.All(r => !r.Enabled))
            {
                throw new ArgumentException("at least one enabled ring is required");
            }

            foreach (RingLayer ring in Rings)
            {
                ring.Validate();
            }

            int footprint = Rings.Where(r => r.Enabled).Sum(r => r.Width + r.Gap);
            if (footprint * 2 + Padding * 2 >= Size)
            {
                throw new ArgumentException("ring widths, gaps, and padding are too large for the output size");
            }
        }
    }

    private sealed record RingLayer(string Color, int Width, int Gap = 0, double Opacity = 1, bool Enabled = true)
    {
        public RingLayer Copy() => this with { };
        public RingLayer Scale(int scale) => this with { Width = Width * scale, Gap = Gap * scale };
        public string ToConfigString() => Gap == 0 && Opacity >= 0.999 && Enabled
            ? $"{Color}:{Width}"
            : $"{Color}:{Width}:{Gap}:{Opacity.ToString("0.##", CultureInfo.InvariantCulture)}:{Enabled}";

        public void Validate()
        {
            _ = ParseColor(Color);
            if (Width <= 0)
            {
                throw new ArgumentException("ring width must be positive");
            }

            if (Gap < 0)
            {
                throw new ArgumentException("ring gap must be zero or positive");
            }

            if (Opacity is < 0 or > 1)
            {
                throw new ArgumentException("ring opacity must be between 0 and 1");
            }
        }
    }

    private sealed record RingPreset(string Name, List<RingLayer> Rings);

    private sealed record PresetStore
    {
        public Dictionary<string, RingPreset> Custom { get; set; } = new(StringComparer.OrdinalIgnoreCase);

        public Dictionary<string, RingPreset> AllPresets()
        {
            Dictionary<string, RingPreset> all = new(BuiltInPresets, StringComparer.OrdinalIgnoreCase);
            foreach ((string key, RingPreset value) in Custom)
            {
                all[key] = value;
            }

            return all;
        }

        public void Save(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");
            File.WriteAllText(path, JsonSerializer.Serialize(this, Json.Options));
        }

        public static PresetStore Load(string path)
        {
            if (!File.Exists(path))
            {
                PresetStore store = new();
                store.Save(path);
                return store;
            }

            try
            {
                return JsonSerializer.Deserialize<PresetStore>(File.ReadAllText(path), Json.Options) ?? new PresetStore();
            }
            catch
            {
                return new PresetStore();
            }
        }
    }

    private sealed record RecentState
    {
        public string? LastInput { get; set; }
        public string? LastOutput { get; set; }
        public List<string> Inputs { get; set; } = [];
        public List<string> Outputs { get; set; } = [];

        public void RememberInput(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            LastInput = path;
            Inputs.RemoveAll(p => string.Equals(p, path, StringComparison.Ordinal));
            Inputs.Insert(0, path);
            if (Inputs.Count > 20)
            {
                Inputs.RemoveRange(20, Inputs.Count - 20);
            }
        }

        public void RememberOutput(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            LastOutput = path;
            Outputs.RemoveAll(p => string.Equals(p, path, StringComparison.Ordinal));
            Outputs.Insert(0, path);
            if (Outputs.Count > 20)
            {
                Outputs.RemoveRange(20, Outputs.Count - 20);
            }
        }

        public void Save(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");
            File.WriteAllText(path, JsonSerializer.Serialize(this, Json.Options));
        }

        public static RecentState Load(string path)
        {
            if (!File.Exists(path))
            {
                return new RecentState();
            }

            try
            {
                return JsonSerializer.Deserialize<RecentState>(File.ReadAllText(path), Json.Options) ?? new RecentState();
            }
            catch
            {
                return new RecentState();
            }
        }
    }

    private sealed record JobResult(string Status, string Input, string? Output, string? Message)
    {
        public static JobResult Success(string input, string output) => new("success", input, output, null);
        public static JobResult Skipped(string input, string output, string message) => new("skipped", input, output, message);
        public static JobResult DryRun(string input, string output) => new("dry-run", input, output, null);
        public static JobResult Failed(string input, string? output, string message) => new("failed", input, output, message);
    }

    private enum CropMode { Fill, Fit }
    private enum OutputMode { Fail, Overwrite, Skip, Rename }

    private static List<RingLayer> ParseRings(string spec)
    {
        List<RingLayer> rings = [];
        foreach (string item in spec.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
        {
            string[] parts = item.Split(':', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length is < 2 or > 5)
            {
                throw new ArgumentException($"invalid ring '{item}', expected color:width[:gap[:opacity[:enabled]]]");
            }

            string color = parts[0];
            _ = ParseColor(color);
            int width = int.Parse(parts[1], CultureInfo.InvariantCulture);
            int gap = parts.Length >= 3 ? int.Parse(parts[2], CultureInfo.InvariantCulture) : 0;
            double opacity = parts.Length >= 4 ? double.Parse(parts[3], CultureInfo.InvariantCulture) : 1;
            bool enabled = parts.Length >= 5 ? bool.Parse(parts[4]) : true;
            rings.Add(new RingLayer(color, width, gap, opacity, enabled));
        }

        return rings;
    }

    private static RenderSettings LoadSettings(string path)
    {
        string fullPath = ExpandPath(path);
        if (!File.Exists(fullPath))
        {
            throw new ArgumentException($"config file does not exist: {fullPath}");
        }

        return JsonSerializer.Deserialize<RenderSettings>(File.ReadAllText(fullPath), Json.Options) ?? new RenderSettings();
    }

    private static Rgba32 ParseColor(string input)
    {
        string color = input.Trim();
        if (NamedColors.TryGetValue(color, out Rgba32 named))
        {
            return named;
        }

        if (color.StartsWith('#'))
        {
            string hex = color[1..];
            if (hex.Length == 3)
            {
                return new Rgba32(
                    Convert.ToByte(new string(hex[0], 2), 16),
                    Convert.ToByte(new string(hex[1], 2), 16),
                    Convert.ToByte(new string(hex[2], 2), 16));
            }

            if (hex.Length == 6 || hex.Length == 8)
            {
                return new Rgba32(
                    Convert.ToByte(hex[..2], 16),
                    Convert.ToByte(hex[2..4], 16),
                    Convert.ToByte(hex[4..6], 16),
                    hex.Length == 8 ? Convert.ToByte(hex[6..8], 16) : (byte)255);
            }
        }

        throw new ArgumentException($"unsupported color '{input}'");
    }

    private static Rgba32 WithOpacity(Rgba32 color, double opacity)
    {
        color.A = (byte)Math.Round(color.A * opacity);
        return color;
    }

    private static string ToMarkupPreview(Image<Rgba32> image)
    {
        using Image<Rgba32> flattened = new(image.Width, image.Height, new Rgba32(44, 44, 44));
        flattened.Mutate(ctx => ctx.DrawImage(image, new Point(0, 0), 1f));
        List<string> lines = [];
        flattened.ProcessPixelRows(accessor =>
        {
            for (int y = 0; y < flattened.Height; y += 2)
            {
                string line = "";
                Span<Rgba32> upper = accessor.GetRowSpan(y);
                Span<Rgba32> lower = y + 1 < flattened.Height ? accessor.GetRowSpan(y + 1) : upper;
                for (int x = 0; x < flattened.Width; x++)
                {
                    Rgba32 fg = upper[x];
                    Rgba32 bg = lower[x];
                    line += $"[{ToHex(fg)} on {ToHex(bg)}]▀[/]";
                }
                lines.Add(line);
            }
        });
        return string.Join('\n', lines);
    }

    private static string ToHex(Rgba32 color) => $"#{color.R:X2}{color.G:X2}{color.B:X2}";

    private static bool IsSupported(string path)
    {
        string extension = Path.GetExtension(path);
        return SupportedExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
    }

    private static bool IsUrl(string value) => Uri.TryCreate(value, UriKind.Absolute, out Uri? uri) && uri.Scheme is "http" or "https";

    private static string ExpandPath(string path)
    {
        if (path.StartsWith("~/", StringComparison.Ordinal))
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), path[2..]);
        }

        return Path.GetFullPath(path);
    }

    private static string Shorten(string value, int length)
    {
        if (value.Length <= length)
        {
            return value;
        }

        return "..." + value[^Math.Max(0, length - 3)..];
    }

    private static PngEncoder PngOptions() => new()
    {
        ColorType = PngColorType.RgbWithAlpha,
        CompressionLevel = PngCompressionLevel.BestCompression
    };

    private static string? Last(Dictionary<string, List<string>> values, string name) => values.TryGetValue(name, out List<string>? list) ? list.LastOrDefault() : null;
    private static bool GetBool(Dictionary<string, List<string>> values, string name, bool fallback) => values.TryGetValue(name, out List<string>? list) ? bool.Parse(list.Last()) : fallback;
    private static int GetInt(Dictionary<string, List<string>> values, string name, int fallback) => values.TryGetValue(name, out List<string>? list) ? int.Parse(list.Last(), CultureInfo.InvariantCulture) : fallback;
    private static double GetDouble(Dictionary<string, List<string>> values, string name, double fallback) => values.TryGetValue(name, out List<string>? list) ? double.Parse(list.Last(), CultureInfo.InvariantCulture) : fallback;

    private static class Json
    {
        public static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };
    }
}
