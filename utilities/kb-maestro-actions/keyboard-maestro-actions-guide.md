# Keyboard Maestro Action Icons Guide

## Quick Start: Using SF Symbols (Recommended) ⭐

**SF Symbols** is built into macOS and perfect for Keyboard Maestro:

1. **Open SF Symbols app**:
   - Press `Cmd + Space` → Search "SF Symbols"
   - Or: `/System/Library/CoreServices/Applications/SF Symbols.app`

2. **Search for action icons**:
   - `textformat` - Text transformation icons
   - `eye` - Show/hide icons
   - `folder` - Folder icons
   - `arrow` - Move/navigation icons
   - `play` - Execute/run icons
   - `trash` - Delete icons
   - `doc` - Document/file icons
   - `terminal` - Terminal/command icons

3. **Export icons**:
   - Right-click icon → Export → PNG
   - Choose size: 512x512px or larger
   - Save to your Keyboard Maestro actions folder

## Recommended Action Icons

### Text Transformation
- **Uppercase**: `textformat.abc` or `textformat.123`
- **Lowercase**: `textformat.abc` (same, use context)
- **Capitalize**: `textformat` with capital A
- **Title Case**: `textformat.size`

### Visibility Actions
- **Show**: `eye` or `eye.fill`
- **Hide**: `eye.slash` or `eye.slash.fill`
- **Toggle**: `eye.trianglebadge.exclamationmark`

### File & Folder Actions
- **Open**: `folder` or `folder.fill`
- **Folder**: `folder.badge.plus` (new folder)
- **Move**: `arrow.up.arrow.down` or `arrow.right.arrow.left`
- **Copy**: `doc.on.doc` or `square.on.square`
- **Delete**: `trash` or `trash.fill`
- **Execute**: `play` or `play.fill`
- **Run**: `play.circle` or `play.circle.fill`
- **Save**: `square.and.arrow.down` or `tray.and.arrow.down`
- **New**: `plus` or `plus.circle`

### System Actions
- **Terminal**: `terminal` or `terminal.fill`
- **Script**: `doc.text` or `doc.text.fill`
- **Automation**: `gearshape` or `gearshape.fill`
- **Command**: `command` (⌘ symbol)

## Alternative Icon Sources

### 1. Lucide Icons (Web)
- **URL**: https://lucide.dev/icons
- **Format**: SVG (free, open source)
- **Search for**: `type`, `eye`, `folder`, `move`, `play`, `trash`
- **Download**: Click icon → Download SVG → Convert to PNG

### 2. Heroicons
- **URL**: https://heroicons.com
- **Format**: SVG (free, open source)
- **Best for**: Clean, modern icons

### 3. Iconify
- **URL**: https://iconify.design
- **Format**: SVG (multiple icon sets)
- **Best for**: Search across multiple libraries

### 4. The Noun Project
- **URL**: https://thenounproject.com
- **Format**: SVG/PNG (some free, some paid)
- **Search**: "uppercase", "lowercase", "hide", "show", "folder", "execute"

## Keyboard Maestro Integration Steps

1. **Prepare icons**:
   - Size: 512x512px PNG (or larger)
   - Format: PNG with transparent background
   - Location: Create folder `keyboard-maestro-actions/`

2. **Assign in Keyboard Maestro**:
   - Edit macro → Click icon area
   - Choose "Choose File"
   - Select your PNG icon
   - Icon will appear in macro list

3. **Organize icons**:
   ```
   keyboard-maestro-actions/
   ├── text/
   │   ├── uppercase.png
   │   ├── lowercase.png
   │   └── capitalize.png
   ├── visibility/
   │   ├── show.png
   │   └── hide.png
   ├── files/
   │   ├── folder.png
   │   ├── open.png
   │   └── move.png
   └── system/
       ├── execute.png
       └── terminal.png
   ```

## Quick Reference: SF Symbols Names

| Action | SF Symbol Name |
|--------|---------------|
| Uppercase | `textformat.abc` |
| Lowercase | `textformat.abc` (context) |
| Show | `eye.fill` |
| Hide | `eye.slash.fill` |
| Folder | `folder.fill` |
| Open | `folder.badge.questionmark` |
| Move | `arrow.up.arrow.down` |
| Copy | `doc.on.doc.fill` |
| Delete | `trash.fill` |
| Execute | `play.fill` |
| Run | `play.circle.fill` |
| Save | `square.and.arrow.down.fill` |
| Terminal | `terminal.fill` |
| Script | `doc.text.fill` |
| New | `plus.circle.fill` |

## Tips

- **Consistency**: Use the same icon set (SF Symbols recommended) for visual consistency
- **Size**: 512x512px is ideal, Keyboard Maestro will scale as needed
- **Color**: Monochrome icons work best, or match your system theme
- **Naming**: Use clear, descriptive names for easy identification
