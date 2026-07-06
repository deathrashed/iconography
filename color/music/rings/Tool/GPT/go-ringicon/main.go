package main

import (
	"errors"
	"flag"
	"fmt"
	"image"
	"image/color"
	"image/draw"
	"image/png"
	"io"
	"math"
	"net/http"
	"os"
	"os/exec"
	"path/filepath"
	"strconv"
	"strings"
	"time"

	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
	"github.com/disintegration/imaging"
)

type ring struct {
	Color   string
	Width   int
	Gap     int
	Opacity float64
	Enabled bool
}

type settings struct {
	Size      int
	Padding   int
	Zoom      float64
	X         int
	Y         int
	Fit       bool
	Rings     []ring
	Overwrite bool
}

var named = map[string]color.NRGBA{
	"black":    {0, 0, 0, 255},
	"white":    {255, 255, 255, 255},
	"red":      {255, 0, 0, 255},
	"green":    {0, 170, 68, 255},
	"blue":     {0, 70, 255, 255},
	"orange":   {247, 147, 30, 255},
	"yellow":   {255, 221, 55, 255},
	"purple":   {134, 72, 255, 255},
	"violet":   {134, 72, 255, 255},
	"pink":     {255, 84, 173, 255},
	"rose":     {255, 84, 173, 255},
	"grey":     {128, 128, 128, 255},
	"gray":     {128, 128, 128, 255},
	"cyan":     {27, 188, 205, 255},
	"mint":     {27, 188, 205, 255},
	"teal":     {0, 173, 181, 255},
	"charcoal": {17, 17, 17, 255},
}

var presets = map[string]string{
	"single-orange":          "orange:32",
	"black-green-black":      "black:8,green:24,black:8",
	"black-yellow-red-black": "black:12,yellow:18,red:18,black:12",
	"black-red-orange":       "black:10,red:22,orange:18",
	"thick-black-outline":    "black:48",
	"thin-inner-ring":        "black:8,white:10",
	"custom-layered":         "black:8,violet:14,red:18,black:8",
}

const (
	rose   = lipgloss.Color("#ff7d9d")
	violet = lipgloss.Color("#b99cff")
	mint   = lipgloss.Color("#6ee7c8")
	amber  = lipgloss.Color("#f4c95d")
	muted  = lipgloss.Color("#8b9098")
	text   = lipgloss.Color("#e8e6df")
	border = lipgloss.Color("#4b4f58")
	ok     = lipgloss.Color("#79d87d")
	errc   = lipgloss.Color("#ff6b6b")
)

func main() {
	if len(os.Args) == 1 || os.Args[1] == "tui" || os.Args[1] == "--tui" {
		input := ""
		if len(os.Args) > 2 {
			input = os.Args[2]
		}
		if err := runTUI(input); err != nil {
			fmt.Fprintln(os.Stderr, "tui:", err)
			os.Exit(1)
		}
		return
	}
	switch os.Args[1] {
	case "make":
		if err := runMake(os.Args[2:]); err != nil {
			fmt.Fprintln(os.Stderr, "error:", err)
			os.Exit(1)
		}
	case "batch":
		if err := runBatch(os.Args[2:]); err != nil {
			fmt.Fprintln(os.Stderr, "error:", err)
			os.Exit(1)
		}
	case "presets":
		for name, spec := range presets {
			fmt.Printf("%s: %s\n", name, spec)
		}
	default:
		usage()
		os.Exit(2)
	}
}

func usage() {
	fmt.Println(`ringicon-go

Usage:
  ringicon-go tui
  ringicon-go make input.jpg --preset black-green-black --zoom 1.25 --x -40 --y 20 --out output.png
  ringicon-go make input.jpg --rings "black:8,green:24,black:8" --size 1000 --out output.png
  ringicon-go batch ./covers --preset single-orange --out ./rings

Flags:
  --rings color:width[:gap[:opacity]],...
  --preset name
  --out path
  --size px
  --padding px
  --zoom factor
  --x px
  --y px
  --fit
  --overwrite`)
}

func defaultSettings() settings {
	rs, _ := parseRings(presets["black-green-black"])
	return settings{Size: 1000, Padding: 40, Zoom: 1, Rings: rs}
}

func flagSettings(args []string) (settings, string, []string, error) {
	s := defaultSettings()
	fs := flag.NewFlagSet("ringicon-go", flag.ContinueOnError)
	out := fs.String("out", "", "output path")
	rings := fs.String("rings", "", "rings")
	preset := fs.String("preset", "", "preset")
	fs.IntVar(&s.Size, "size", s.Size, "output size")
	fs.IntVar(&s.Padding, "padding", s.Padding, "padding")
	fs.Float64Var(&s.Zoom, "zoom", s.Zoom, "crop zoom")
	fs.IntVar(&s.X, "x", 0, "crop x")
	fs.IntVar(&s.Y, "y", 0, "crop y")
	fs.BoolVar(&s.Fit, "fit", false, "fit instead of fill")
	fs.BoolVar(&s.Overwrite, "overwrite", false, "overwrite")
	normalized := normalizeArgs(args)
	if err := fs.Parse(normalized); err != nil {
		return s, "", nil, err
	}
	if *preset != "" {
		spec, ok := presets[*preset]
		if !ok {
			return s, "", nil, fmt.Errorf("unknown preset %q", *preset)
		}
		*rings = spec
	}
	if *rings != "" {
		rs, err := parseRings(*rings)
		if err != nil {
			return s, "", nil, err
		}
		s.Rings = rs
	}
	if s.Size < 64 {
		return s, "", nil, errors.New("--size must be at least 64")
	}
	return s, *out, fs.Args(), nil
}

func normalizeArgs(args []string) []string {
	valueFlags := map[string]bool{
		"--out": true, "--rings": true, "--preset": true, "--size": true,
		"--padding": true, "--zoom": true, "--x": true, "--y": true,
	}
	boolFlags := map[string]bool{"--fit": true, "--overwrite": true}
	var flagsPart []string
	var positional []string
	for i := 0; i < len(args); i++ {
		arg := args[i]
		if strings.HasPrefix(arg, "--") {
			if strings.Contains(arg, "=") {
				flagsPart = append(flagsPart, arg)
				continue
			}
			if boolFlags[arg] {
				flagsPart = append(flagsPart, arg)
				continue
			}
			if valueFlags[arg] && i+1 < len(args) {
				flagsPart = append(flagsPart, arg, args[i+1])
				i++
				continue
			}
		}
		positional = append(positional, arg)
	}
	return append(flagsPart, positional...)
}

func runMake(args []string) error {
	s, out, rest, err := flagSettings(args)
	if err != nil {
		return err
	}
	if len(rest) == 0 {
		return errors.New("missing input image")
	}
	input, cleanup, err := resolveInput(rest[0])
	if cleanup != nil {
		defer cleanup()
	}
	if err != nil {
		return err
	}
	if out == "" {
		out = strings.TrimSuffix(input, filepath.Ext(input)) + "-ring.png"
	}
	if err := renderFile(input, out, s); err != nil {
		return err
	}
	fmt.Printf("success: %s -> %s\n", rest[0], out)
	return nil
}

func runBatch(args []string) error {
	s, out, rest, err := flagSettings(args)
	if err != nil {
		return err
	}
	if len(rest) == 0 {
		return errors.New("missing input folder")
	}
	folder := rest[0]
	if out == "" {
		out = folder
	}
	entries, err := os.ReadDir(folder)
	if err != nil {
		return err
	}
	if err := os.MkdirAll(out, 0755); err != nil {
		return err
	}
	written, failed := 0, 0
	for _, ent := range entries {
		if ent.IsDir() || !isImage(ent.Name()) {
			continue
		}
		input := filepath.Join(folder, ent.Name())
		output := filepath.Join(out, strings.TrimSuffix(ent.Name(), filepath.Ext(ent.Name()))+"-ring.png")
		if err := renderFile(input, output, s); err != nil {
			failed++
			fmt.Printf("failed: %s (%v)\n", input, err)
			continue
		}
		written++
		fmt.Printf("success: %s -> %s\n", input, output)
	}
	fmt.Printf("summary: %d written, %d failed\n", written, failed)
	if failed > 0 {
		return fmt.Errorf("%d input(s) failed", failed)
	}
	return nil
}

func resolveInput(input string) (string, func(), error) {
	if strings.HasPrefix(input, "http://") || strings.HasPrefix(input, "https://") {
		resp, err := http.Get(input)
		if err != nil {
			return "", nil, err
		}
		defer resp.Body.Close()
		if resp.StatusCode < 200 || resp.StatusCode > 299 {
			return "", nil, fmt.Errorf("download failed: %s", resp.Status)
		}
		tmp, err := os.CreateTemp("", "ringicon-go-*"+guessExt(resp.Header.Get("Content-Type")))
		if err != nil {
			return "", nil, err
		}
		if _, err := io.Copy(tmp, resp.Body); err != nil {
			tmp.Close()
			return "", nil, err
		}
		tmp.Close()
		return tmp.Name(), func() { _ = os.Remove(tmp.Name()) }, nil
	}
	if _, err := os.Stat(input); err != nil {
		return "", nil, err
	}
	return input, nil, nil
}

func guessExt(ct string) string {
	if strings.Contains(ct, "jpeg") {
		return ".jpg"
	}
	if strings.Contains(ct, "png") {
		return ".png"
	}
	return ".img"
}

func parseRings(spec string) ([]ring, error) {
	var rs []ring
	for _, part := range strings.Split(spec, ",") {
		part = strings.TrimSpace(part)
		if part == "" {
			continue
		}
		fields := strings.Split(part, ":")
		if len(fields) < 2 {
			return nil, fmt.Errorf("bad ring %q, expected color:width[:gap[:opacity]]", part)
		}
		width, err := strconv.Atoi(fields[1])
		if err != nil || width < 0 {
			return nil, fmt.Errorf("bad ring width in %q", part)
		}
		gap := 0
		if len(fields) > 2 && fields[2] != "" {
			gap, err = strconv.Atoi(fields[2])
			if err != nil || gap < 0 {
				return nil, fmt.Errorf("bad ring gap in %q", part)
			}
		}
		opacity := 1.0
		if len(fields) > 3 && fields[3] != "" {
			opacity, err = strconv.ParseFloat(fields[3], 64)
			if err != nil || opacity < 0 || opacity > 1 {
				return nil, fmt.Errorf("bad ring opacity in %q", part)
			}
		}
		if _, err := parseColor(fields[0], opacity); err != nil {
			return nil, err
		}
		rs = append(rs, ring{Color: fields[0], Width: width, Gap: gap, Opacity: opacity, Enabled: true})
	}
	if len(rs) == 0 {
		return nil, errors.New("at least one ring is required")
	}
	return rs, nil
}

func parseColor(v string, opacity float64) (color.NRGBA, error) {
	v = strings.TrimSpace(strings.ToLower(v))
	if c, ok := named[v]; ok {
		c.A = uint8(math.Round(float64(c.A) * opacity))
		return c, nil
	}
	if strings.HasPrefix(v, "#") {
		hex := strings.TrimPrefix(v, "#")
		if len(hex) != 6 {
			return color.NRGBA{}, fmt.Errorf("bad hex color %q", v)
		}
		n, err := strconv.ParseUint(hex, 16, 32)
		if err != nil {
			return color.NRGBA{}, fmt.Errorf("bad hex color %q", v)
		}
		return color.NRGBA{uint8(n >> 16), uint8(n >> 8), uint8(n), uint8(math.Round(255 * opacity))}, nil
	}
	return color.NRGBA{}, fmt.Errorf("unknown color %q", v)
}

func renderFile(input, output string, s settings) error {
	if !s.Overwrite {
		if _, err := os.Stat(output); err == nil {
			return fmt.Errorf("output exists: %s (use --overwrite)", output)
		}
	}
	src, err := imaging.Open(input)
	if err != nil {
		return err
	}
	img, err := render(src, s)
	if err != nil {
		return err
	}
	if err := os.MkdirAll(filepath.Dir(output), 0755); err != nil {
		return err
	}
	f, err := os.Create(output)
	if err != nil {
		return err
	}
	defer f.Close()
	return png.Encode(f, img)
}

func render(src image.Image, s settings) (*image.NRGBA, error) {
	scale := 3
	size := s.Size * scale
	padding := s.Padding * scale
	totalRing := 0
	for _, r := range s.Rings {
		if r.Enabled {
			totalRing += (r.Width + r.Gap) * scale
		}
	}
	content := size - padding*2 - totalRing*2
	if content <= 8 {
		return nil, errors.New("rings and padding leave no room for artwork")
	}
	canvas := image.NewNRGBA(image.Rect(0, 0, size, size))
	cx, cy := float64(size)/2, float64(size)/2
	radius := float64(content) / 2
	for _, r := range s.Rings {
		if !r.Enabled {
			continue
		}
		radius += float64(r.Gap * scale)
		outer := radius + float64(r.Width*scale)
		c, err := parseColor(r.Color, r.Opacity)
		if err != nil {
			return nil, err
		}
		drawAnnulus(canvas, cx, cy, radius, outer, c)
		radius = outer
	}

	crop := cropSource(src, s)
	resized := imaging.Resize(crop, content, content, imaging.Lanczos)
	pasteX := (size - content) / 2
	pasteY := pasteX
	drawCircleImage(canvas, resized, pasteX, pasteY, float64(content)/2)
	return imaging.Resize(canvas, s.Size, s.Size, imaging.Lanczos), nil
}

func cropSource(src image.Image, s settings) image.Image {
	b := src.Bounds()
	w, h := b.Dx(), b.Dy()
	if s.Fit {
		side := max(w, h)
		bg := image.NewNRGBA(image.Rect(0, 0, side, side))
		draw.Draw(bg, bg.Bounds(), image.Transparent, image.Point{}, draw.Src)
		draw.Draw(bg, image.Rect((side-w)/2, (side-h)/2, (side-w)/2+w, (side-h)/2+h), src, b.Min, draw.Over)
		return bg
	}
	zoom := math.Max(0.1, s.Zoom)
	side := int(float64(min(w, h)) / zoom)
	side = max(1, min(side, min(w, h)))
	cx := w/2 + s.X
	cy := h/2 + s.Y
	x0 := clamp(cx-side/2, 0, w-side)
	y0 := clamp(cy-side/2, 0, h-side)
	return imaging.Crop(src, image.Rect(b.Min.X+x0, b.Min.Y+y0, b.Min.X+x0+side, b.Min.Y+y0+side))
}

func drawAnnulus(img *image.NRGBA, cx, cy, inner, outer float64, c color.NRGBA) {
	minX := clamp(int(cx-outer-2), 0, img.Bounds().Dx())
	maxX := clamp(int(cx+outer+2), 0, img.Bounds().Dx())
	minY := clamp(int(cy-outer-2), 0, img.Bounds().Dy())
	maxY := clamp(int(cy+outer+2), 0, img.Bounds().Dy())
	for y := minY; y < maxY; y++ {
		for x := minX; x < maxX; x++ {
			d := math.Hypot(float64(x)+0.5-cx, float64(y)+0.5-cy)
			if d >= inner && d <= outer {
				img.SetNRGBA(x, y, c)
			}
		}
	}
}

func drawCircleImage(dst *image.NRGBA, src image.Image, ox, oy int, radius float64) {
	cx, cy := float64(ox)+radius, float64(oy)+radius
	for y := 0; y < src.Bounds().Dy(); y++ {
		for x := 0; x < src.Bounds().Dx(); x++ {
			if math.Hypot(float64(ox+x)+0.5-cx, float64(oy+y)+0.5-cy) <= radius {
				dst.Set(ox+x, oy+y, src.At(src.Bounds().Min.X+x, src.Bounds().Min.Y+y))
			}
		}
	}
}

func isImage(name string) bool {
	switch strings.ToLower(filepath.Ext(name)) {
	case ".png", ".jpg", ".jpeg", ".webp", ".bmp", ".gif":
		return true
	default:
		return false
	}
}

func min(a, b int) int {
	if a < b {
		return a
	}
	return b
}
func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}
func clamp(v, lo, hi int) int {
	if v < lo {
		return lo
	}
	if v > hi {
		return hi
	}
	return v
}

type model struct {
	input  string
	output string
	s      settings
	status string
	width  int
	height int
}

func runTUI(input string) error {
	if input == "" {
		input = "/Users/rd/Downloads/cover.jpg"
	}
	m := model{
		input:  input,
		output: "/Volumes/Apfspace/Icons/color/music/rings/Tool/GPT/samples/go-tui-export.png",
		s:      defaultSettings(),
		status: "ready",
		width:  160,
		height: 44,
	}
	_, err := tea.NewProgram(m, tea.WithAltScreen()).Run()
	return err
}

func (m model) Init() tea.Cmd { return nil }

func (m model) Update(msg tea.Msg) (tea.Model, tea.Cmd) {
	switch msg := msg.(type) {
	case tea.WindowSizeMsg:
		m.width, m.height = msg.Width, msg.Height
	case tea.KeyMsg:
		switch msg.String() {
		case "q", "esc", "ctrl+c":
			return m, tea.Quit
		case "left":
			m.s.X -= 8
		case "right":
			m.s.X += 8
		case "up":
			m.s.Y -= 8
		case "down":
			m.s.Y += 8
		case "shift+left":
			m.s.X -= 25
		case "shift+right":
			m.s.X += 25
		case "shift+up":
			m.s.Y -= 25
		case "shift+down":
			m.s.Y += 25
		case "+", "=":
			m.s.Zoom = math.Round((m.s.Zoom+0.05)*100) / 100
		case "-", "_":
			m.s.Zoom = math.Max(0.1, math.Round((m.s.Zoom-0.05)*100)/100)
		case "0":
			m.s.X, m.s.Y, m.s.Zoom = 0, 0, 1
		case "f":
			m.s.Fit = !m.s.Fit
		case "p":
			m.cyclePreset()
		case "enter":
			m.status = m.export(false)
		case "v":
			m.status = m.export(true)
		}
	}
	return m, nil
}

func (m *model) cyclePreset() {
	order := []string{"single-orange", "black-green-black", "black-yellow-red-black", "black-red-orange", "thick-black-outline", "thin-inner-ring", "custom-layered"}
	current := ringsSpec(m.s.Rings)
	next := order[0]
	for i, name := range order {
		if presets[name] == current {
			next = order[(i+1)%len(order)]
			break
		}
	}
	rs, _ := parseRings(presets[next])
	m.s.Rings = rs
	m.status = "preset " + next
}

func (m model) export(open bool) string {
	s := m.s
	s.Overwrite = true
	if err := renderFile(m.input, m.output, s); err != nil {
		return "error: " + err.Error()
	}
	if open {
		_ = exec.Command("open", m.output).Start()
		return "preview opened " + m.output
	}
	return "exported " + m.output
}

func (m model) View() string {
	w := max(m.width, 110)
	box := lipgloss.NewStyle().Border(lipgloss.RoundedBorder()).BorderForeground(border).Padding(0, 1)
	title := lipgloss.NewStyle().Foreground(rose).Bold(true)
	head := box.Width(min(w-4, 128)).Render(
		title.Render("RingIcon Go") + " " + dim("album-art ring icon production bench") + "\n" +
			dim("source") + " " + val(filepath.Base(m.input)) + "   " + dim("crop") + " " + accent(cropMode(m.s), mint) + "   " + dim("rings") + " " + accent(strconv.Itoa(len(m.s.Rings)), violet) + "   " + dim("zoom") + " " + bar((m.s.Zoom-0.5)/2.5, 22, violet) + " " + val(fmt.Sprintf("%.2fx", m.s.Zoom)) + "   " + dim("phase") + " " + accent(m.statusPhase(), violet),
	)
	leftW, rightW := 34, 30
	midW := max(54, min(w-leftW-rightW-10, 92))
	left := box.Width(leftW).Render(m.artworkPane())
	mid := box.Width(midW).Render(m.makePane(midW - 4))
	right := box.Width(rightW).Render(m.actionPane())
	footer := box.Width(min(w-4, 128)).Render(key("←↑↓→") + " move  " + key("+/-") + " zoom  " + key("0") + " reset  " + key("f") + " fit/fill  " + key("p") + " preset  " + key("v") + " preview  " + key("enter") + " export  " + key("q") + " quit\n" + m.statusStyled())
	return lipgloss.JoinVertical(lipgloss.Left, head, lipgloss.JoinHorizontal(lipgloss.Top, left, "  ", mid, "  ", right), footer)
}

func (m model) artworkPane() string {
	lines := []string{
		section("1  ARTWORK"),
		row("source", filepath.Base(m.input)),
		row("path", shorten(m.input, 28)),
		"",
		section("4  EXPORT TARGET"),
		row("out", shorten(m.output, 28)),
		"",
		section("INPUT QUEUE"),
		accent("▸", mint) + "  " + val(filepath.Base(m.input)),
	}
	return strings.Join(lines, "\n")
}

func (m model) makePane(width int) string {
	lines := []string{
		section("1 Artwork") + " " + dim(shorten(filepath.Base(m.input), 16)) + " " + dim("->") + " " + section("2 Crop") + " " + dim(cropMode(m.s)) + " " + dim("->") + " " + section("3 Rings") + " " + dim(fmt.Sprintf("%d rings", len(m.s.Rings))) + " " + dim("->") + " " + section("4 Export"),
		"",
		section("2  CROP"),
		fmt.Sprintf("%-11s %s %s", accent("zoom", mint), bar((m.s.Zoom-0.5)/2.5, 28, mint), val(fmt.Sprintf("%.2fx", m.s.Zoom))),
		fmt.Sprintf("%-11s %s %s", accent("x", violet), signedBar(m.s.X, 28, violet), pos(m.s.X)),
		fmt.Sprintf("%-11s %s %s", accent("y", rose), signedBar(m.s.Y, 28, rose), pos(m.s.Y)),
		row("mode", cropMode(m.s)),
		"",
		section("3  RING STACK") + " " + dim("inner -> outer"),
	}
	for i, r := range m.s.Rings {
		lines = append(lines, fmt.Sprintf("%s  %-22s %s", dim(fmt.Sprintf("#%d", i+1)), ringBar(r), ringText(r)))
	}
	lines = append(lines, "", section("4  EXPORT"), shorten(m.output, width-2))
	return strings.Join(lines, "\n")
}

func (m model) actionPane() string {
	lines := []string{
		section("CROP"),
		action("arrows", "move crop"),
		action("shift", "move faster"),
		action("+ / -", "zoom in/out"),
		action("0", "reset crop"),
		action("f", "fit/fill"),
		"",
		section("RINGS"),
		action("p", "cycle preset"),
		"",
		section("OUTPUT"),
		action("v", "preview PNG"),
		action("enter", "export"),
		"",
		section("PRESETS"),
	}
	for _, p := range []string{"single-orange", "black-green-black", "black-yellow-red-black", "black-red-orange", "thick-black-outline", "thin-inner-ring"} {
		lines = append(lines, accent("›", violet)+" "+val(p))
	}
	return strings.Join(lines, "\n")
}

func ringsSpec(rs []ring) string {
	parts := make([]string, 0, len(rs))
	for _, r := range rs {
		parts = append(parts, r.Color+":"+strconv.Itoa(r.Width))
	}
	return strings.Join(parts, ",")
}

func cropMode(s settings) string {
	if s.Fit {
		return "Fit"
	}
	return "Fill"
}
func (m model) statusPhase() string {
	if strings.HasPrefix(m.status, "error") {
		return "error"
	}
	return "ready"
}
func (m model) statusStyled() string {
	if strings.HasPrefix(m.status, "error") {
		return lipgloss.NewStyle().Foreground(errc).Render(m.status)
	}
	return lipgloss.NewStyle().Foreground(ok).Render(m.status)
}

func section(s string) string { return lipgloss.NewStyle().Foreground(rose).Bold(true).Render(s) }
func dim(s string) string     { return lipgloss.NewStyle().Foreground(muted).Render(s) }
func val(s string) string     { return lipgloss.NewStyle().Foreground(text).Render(s) }
func accent(s string, c lipgloss.Color) string {
	return lipgloss.NewStyle().Foreground(c).Bold(true).Render(s)
}
func key(s string) string { return lipgloss.NewStyle().Foreground(mint).Bold(true).Render(s) }
func row(k, v string) string {
	return lipgloss.NewStyle().Foreground(rose).Render(fmt.Sprintf("%-8s", k)) + val(v)
}
func action(k, v string) string { return "  " + key(fmt.Sprintf("%-7s", k)) + dim(v) }
func pos(v int) string {
	if v > 0 {
		return accent("+"+strconv.Itoa(v), mint)
	}
	if v < 0 {
		return accent(strconv.Itoa(v), rose)
	}
	return dim("0")
}

func bar(t float64, width int, c lipgloss.Color) string {
	t = math.Max(0, math.Min(1, t))
	n := int(math.Round(t * float64(width)))
	return lipgloss.NewStyle().Foreground(c).Render(strings.Repeat("█", n)) + lipgloss.NewStyle().Foreground(lipgloss.Color("236")).Render(strings.Repeat("░", width-n))
}

func signedBar(v, width int, c lipgloss.Color) string {
	half := width / 2
	n := int(math.Round(math.Min(1, math.Abs(float64(v))/160) * float64(half)))
	left, right := strings.Repeat("░", half), strings.Repeat("░", half)
	if v < 0 {
		left = strings.Repeat("█", n) + strings.Repeat("░", half-n)
	}
	if v > 0 {
		right = strings.Repeat("█", n) + strings.Repeat("░", half-n)
	}
	return lipgloss.NewStyle().Foreground(c).Render(left) + val("│") + lipgloss.NewStyle().Foreground(c).Render(right)
}

func ringBar(r ring) string {
	c := lipgloss.Color("245")
	if col, err := parseColor(r.Color, 1); err == nil {
		c = lipgloss.Color(fmt.Sprintf("#%02x%02x%02x", col.R, col.G, col.B))
	}
	return lipgloss.NewStyle().Foreground(c).Render(strings.Repeat("█", max(1, min(18, r.Width/2))))
}

func ringText(r ring) string {
	return accent(r.Color, lipgloss.Color(colorHex(r.Color))) + dim(":") + val(strconv.Itoa(r.Width)) + dim(" gap ") + val(strconv.Itoa(r.Gap)) + dim(" op ") + val(fmt.Sprintf("%.2g", r.Opacity))
}

func colorHex(v string) string {
	c, err := parseColor(v, 1)
	if err != nil {
		return "#d7d7d7"
	}
	return fmt.Sprintf("#%02x%02x%02x", c.R, c.G, c.B)
}

func shorten(s string, n int) string {
	if n <= 0 || len(s) <= n {
		return s
	}
	if n < 6 {
		return s[:n]
	}
	return "..." + s[len(s)-n+3:]
}

func init() {
	http.DefaultClient.Timeout = 30 * time.Second
}
