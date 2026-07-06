# RingIcon Go

Fast Go rewrite of the RingIcon production tool using Bubble Tea, Lip Gloss, and Go image rendering.

This version is intentionally not a general image editor. It is focused on:

1. Load album art or artwork
2. Adjust crop zoom and position
3. Apply a ring stack
4. Export a transparent PNG

## Run

From the GPT tool folder:

```bash
./ringicon-go tui
```

Or run commands directly:

```bash
./ringicon-go make input.jpg --preset black-green-black --zoom 1.25 --x -40 --y 20 --out output.png --overwrite
./ringicon-go make input.jpg --rings "black:8,green:24,black:8" --size 1000 --out output.png --overwrite
./ringicon-go batch ./covers --preset single-orange --out ./rings --overwrite
```

## TUI Keys

- Arrow keys: move crop
- Shift + arrows: move faster
- `+` / `-`: zoom
- `0`: reset crop
- `f`: fit/fill
- `p`: cycle presets
- `v`: render and open preview PNG
- Enter: export current image
- `q`: quit

## Notes

- The TUI uses its own graphite, rose, violet, mint, and amber color scheme.
- Typed ring colors still support `red`, `green`, `blue`, `orange`, `yellow`, `black`, `white`, `purple`, `pink`, `grey`, `gray`, `cyan`, `teal`, `rose`, `violet`, `mint`, and `#rrggbb`.
- The renderer supersamples internally for smoother circles and exports PNG with transparency.
- This is a quick rewrite; the C# version remains in `src/RingIcon`.
