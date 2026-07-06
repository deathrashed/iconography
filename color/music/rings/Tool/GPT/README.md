# RingIcon

Fast C# production tool for the album-art ring-icon workflow:

```text
source image -> crop / zoom / position -> ring layers -> transparent PNG
```

This is intentionally not a general image editor. It is built to replace the repeated Canva flow of cropping album artwork into a circle, stacking coloured ring layers, and exporting a transparent PNG.

## Run The Production TUI

```bash
cd /Volumes/Apfspace/Icons/color/music/rings/Tool/GPT
./ringicon
```

The TUI is a focused workbench:

- left: input queue and output path
- center: crop gauges, ring-stack visualization, command syntax, and preview/export state
- right: current controls, colour chips, ring details, and preset chips
- bottom: shortcut bar and status

The TUI does not pretend the terminal is a real image editor canvas. Press `V` to render and open a real PNG preview, then continue adjusting crop and rings from the keyboard.

Keyboard controls:

```text
Arrow keys       move crop
Shift+Arrows     move crop faster
+ / -            zoom in / out
0                reset crop to center
F                toggle fill / fit crop
I                choose input file, folder, URL, URL file, or clipboard URL
O                set output path
P                choose preset
R                edit rings
C                edit a ring colour
S                save current rings as a preset
B                batch export queue
V                render/open real PNG preview
Enter            export current image
Q / Esc          quit
```

Presets are stored at:

```text
~/.config/ringicon/presets.json
```

Recent paths are stored at:

```text
~/.config/ringicon/recent.json
```

## CLI Mode

Single image:

```bash
./ringicon make input.jpg --preset black-green-black --zoom 1.25 --x -40 --y 20 --out output.png
```

Custom ring stack, inner to outer:

```bash
./ringicon make input.jpg --rings "black:8,green:24,black:8" --size 1000 --out output.png
```

Transparent gap and opacity:

```bash
./ringicon make input.jpg --rings "#111111:10,#f7931e:32:4:0.95" --out output.png
```

Batch folder:

```bash
./ringicon batch ./covers --preset single-orange --out ./rings --rename-existing
```

HTTP image URL:

```bash
./ringicon make "https://example.com/cover.jpg" --preset black-green-black --out output.png
```

URL text file:

```bash
./ringicon make --url-file urls.txt --preset single-orange --out ./rings --overwrite
```

JSON output for automation:

```bash
./ringicon make input.jpg --preset single-orange --out output.png --json
```

## Ring Syntax

Rings are specified inner to outer:

```text
color:width[:gap[:opacity[:enabled]]]
```

Examples:

```text
orange:32
black:8,green:24,black:8
black:12,yellow:18,red:18,black:12
black:10,purple:14,red:18
#111111:10,#f7931e:32:4:0.95
```

Each ring supports:

- colour
- width
- transparent gap before that ring
- opacity
- enabled / disabled
- reordering in the TUI

Supported typed colour names:

```text
red green blue orange yellow black white purple pink grey gray
```

Hex colours are also supported:

```text
#ff0000 #00ff00 #f7931e #111111 #ffffff #rrggbbaa
```

## Built-In Presets

```text
single-orange
black-green-black
black-yellow-red-black
black-red-orange
thick-black-outline
thin-inner-ring
custom-layered
fymffyp
808
```

List presets:

```bash
./ringicon --list-presets
```

Save new presets from the TUI with `S`.

## Output Handling

The tool always exports transparent PNG.

Output collision modes:

```text
default           fail if output exists
--overwrite       replace existing output
--skip-existing   keep existing output
--rename-existing create output-2.png, output-3.png, ...
```

Batch jobs print a summary and continue past per-image decode failures.

## Build

```bash
cd /Volumes/Apfspace/Icons/color/music/rings/Tool/GPT
dotnet build src/RingIcon/RingIcon.csproj -c Release
```

## Tests

```bash
./tests/run-smoke-tests.sh
```

The smoke tests cover:

- valid PNG input
- valid JPG input
- square images
- rectangular images
- small images
- large images
- missing input file
- invalid image file
- HTTP image URL
- bad image URL
- URL text file
- batch folder input
- existing output file
- filenames with spaces
- custom named colours
- custom hex colours
- multiple ring configurations
- transparent gaps
- opacity
- crop zoom and crop offset
- fit and fill crop modes
- JSON output mode

Sample outputs are written under:

```text
samples/
tests/output/
```

## Shell Completion

For zsh:

```bash
mkdir -p ~/.zsh/completions
cp completions/ringicon.zsh ~/.zsh/completions/_ringicon
```

Then ensure your `.zshrc` has:

```bash
fpath=(~/.zsh/completions $fpath)
autoload -Uz compinit
compinit
```

## Finder Helper

`scripts/finder-ringicon.sh` can be used from Automator or Shortcuts with Finder items passed as arguments. It writes `*-ring.png` beside each selected image.

## Troubleshooting

- If the TUI panels wrap, make the terminal wider. The production layout is intended for a wide terminal and falls back as much as practical in narrow terminals.
- If you need to inspect the actual icon, press `V` in the TUI to render/open a real PNG preview.
- If a URL fails, rerun with the same URL in CLI mode to see the network error.
- If output exists, choose `--overwrite`, `--skip-existing`, or `--rename-existing`.
- If the crop is not on the right part of the artwork, use arrow keys in the TUI or `--x`, `--y`, and `--zoom` in CLI mode.
- If rings disappear, reduce ring widths, gaps, or padding, or increase output size.

## Limitations

- The TUI is a production dashboard, not a native macOS canvas. Real visual inspection is done with the generated PNG preview/export.
- Clipboard support currently reads clipboard URLs via `pbpaste`; clipboard image decoding is not implemented.
- Remote URLs are downloaded to a temporary local file before processing.
- Output format is PNG only.
