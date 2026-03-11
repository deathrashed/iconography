# 🎨 Your Complete Symbol Collection

## ✅ What You Have

### 1. **Apple SF Symbols** (1,672 symbols × 2 themes)

**Downloaded from:** [andrewtavis/sf-symbols-online](https://github.com/andrewtavis/sf-symbols-online)

- **Light Mode:** `sf-symbols-light/` - 1,672 PNG files
- **Dark Mode:** `sf-symbols-dark/` - 1,672 PNG files

**Format:** PNG (ready to use in Raycast scripts)

**Examples:**

- `star.png`, `star.fill.png`
- `folder.png`, `folder.fill.png`
- `pencil.png`, `trash.png`
- `arrow.up.png`, `chevron.down.png`
- Numbers: `0.circle.png` - `50.circle.png`
- And 1,600+ more!

### 2. **Lucide Icons** (22 SVG icons)

**Source:** [lucide.dev](https://lucide.dev/icons)

Located in: `collections/`

Available icons: star, folder, file, music, download, upload, search, settings, terminal, code, clipboard, play, pause, video, image, archive, trash, globe, github, check, x, info

**Format:** SVG (scalable vector graphics)

---

## 🚀 How to Use in Raycast Scripts

### Method 1: SF Symbols (PNG)

```bash
#!/bin/bash

# Required parameters:
# @raycast.schemaVersion 1
# @raycast.title My Script
# @raycast.mode compact

# Optional parameters:
# @raycast.icon /Users/rd/.config/raycast/script-commands/active commands/symbols/sf-symbols-light/star.fill.png

echo "Script content here"
```

### Method 2: Lucide Icons (SVG)

```bash
# @raycast.icon /Users/rd/.config/raycast/script-commands/active commands/symbols/collections/folder.svg
```

### Method 3: Emoji (Simplest)

```bash
# @raycast.icon ⭐
# @raycast.icon 📁
# @raycast.icon 🎵
```

---

## 📁 Directory Structure

```
symbols/
├── SYMBOLS-GUIDE.md          # This file
├── README.md                 # SF Symbols download instructions
├── download-icons.sh         # Script to download more Lucide icons
├── export-symbol.sh          # Helper for SF Symbols app
│
├── sf-symbols-light/         # 1,672 Apple SF Symbols (light theme)
│   ├── star.png
│   ├── folder.png
│   ├── pencil.png
│   └── ... (1,669 more)
│
├── sf-symbols-dark/          # 1,672 Apple SF Symbols (dark theme)
│   ├── star.png
│   ├── folder.png
│   └── ... (1,669 more)
│
├── collections/              # 22 Lucide SVG icons
│   ├── star.svg
│   ├── folder.svg
│   └── ... (20 more)
│
├── common/                   # For your frequently used symbols
└── custom/                   # For custom exports
```

---

## 🔍 Finding Symbols

### Browse SF Symbols

```bash
# List all available symbols
ls symbols/sf-symbols-light/

# Search for specific symbols
ls symbols/sf-symbols-light/ | grep star
ls symbols/sf-symbols-light/ | grep arrow
ls symbols/sf-symbols-light/ | grep music
```

### Online References

- **SF Symbols Browser:** [GitHub Repository](https://github.com/andrewtavis/sf-symbols-online)
- **Lucide Icons:** https://lucide.dev/icons
- **Apple SF Symbols App:** https://developer.apple.com/sf-symbols/

---

## 📥 Download More Icons

### Get More Lucide Icons

```bash
cd symbols
./download-icons.sh
```

Browse all icons at: https://lucide.dev/icons

Then download specific ones:

```bash
curl -L https://raw.githubusercontent.com/lucide-icons/lucide/main/icons/ICON_NAME.svg \
  -o symbols/collections/ICON_NAME.svg
```

---

## 💡 Pro Tips

### 1. **Use Absolute Paths**

Always use full paths in `@raycast.icon` for reliability:

```bash
# Good ✅
# @raycast.icon /Users/rd/.config/raycast/script-commands/active commands/symbols/sf-symbols-light/star.png

# May fail ❌
# @raycast.icon ../symbols/star.png
```

### 2. **Light vs Dark Symbols**

- Use `sf-symbols-light/` for scripts with light backgrounds
- Use `sf-symbols-dark/` for scripts with dark backgrounds (white icons)
- Raycast will automatically adapt based on system theme

### 3. **Filled vs Outline**

Many SF Symbols come in pairs:

- `star.png` - outline version
- `star.fill.png` - filled version

### 4. **Quick Preview**

```bash
# Preview an icon in Finder
open symbols/sf-symbols-light/star.png

# Open folder to browse
open symbols/sf-symbols-light/
```

---

## 📋 Popular SF Symbols for Scripts

### File Operations

- `folder.png`, `folder.fill.png`
- `doc.png`, `doc.fill.png`
- `archivebox.png`, `archivebox.fill.png`
- `trash.png`, `trash.fill.png`

### Media

- `music.note.png`
- `play.fill.png`, `pause.fill.png`
- `video.png`, `video.fill.png`
- `photo.png`, `photo.fill.png`

### System

- `gear.png` - settings
- `terminal.png`
- `command.png`
- `keyboard.png`

### Arrows & Navigation

- `arrow.up.png`, `arrow.down.png`
- `chevron.left.png`, `chevron.right.png`
- `arrow.clockwise.png` - refresh

### Common Actions

- `plus.png`, `minus.png`
- `checkmark.png`
- `xmark.png` - close/cancel
- `pencil.png` - edit
- `magnifyingglass.png` - search

### Numbers

- `0.circle.png` through `50.circle.png`
- `0.square.png` through `50.square.png`

---

## 🎯 Quick Reference

**Total Symbols Available:** 1,694 unique symbols

- 1,672 SF Symbols (PNG, light & dark)
- 22 Lucide Icons (SVG)

**Storage Location:** `/Users/rd/.config/raycast/script-commands/active commands/symbols/`

**License:**

- SF Symbols: Apple (use in apps targeting Apple platforms)
- Lucide Icons: ISC License (free for any use)

---

**Enjoy your complete symbol library! 🎨**
