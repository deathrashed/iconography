# ◈ Icons

<div align="center">

![Total Icons](https://img.shields.io/badge/Icons-60,000+-8B5CF6?style=for-the-badge&labelColor=1a1a2e)
![Formats](https://img.shields.io/badge/Formats-PNG%20%7C%20SVG%20%7C%20ICNS-06B6D4?style=for-the-badge&labelColor=1a1a2e)
![macOS](https://img.shields.io/badge/macOS-Ready-F97316?style=for-the-badge&logo=apple&logoColor=white&labelColor=1a1a2e)

**A curated collection of 60,000+ icons for developers, designers, and power users**

*Icons for apps, folders, services, programming languages, and beyond*

---

</div>

## 📂 Structure

```
Icons/
├── color/              # Full-color icons
│   ├── library/        # 7,000+ categorized icons (AI, dev, design, social...)
│   ├── self-hosted/    # 1,000+ self-hosted service icons
│   ├── web/            # Web service icons (PNG + SVG)
│   ├── km/             # Keyboard Maestro icons
│   ├── metabrainz/     # MusicBrainz ecosystem
│   └── misc/           # Miscellaneous color icons
│
├── plain/              # Monochrome & line icons
│   ├── tabler/         # 5,200+ Tabler icons
│   ├── simple/         # 3,000+ Simple Icons (brand logos)
│   ├── font-awesome/   # Font Awesome (brands, regular, solid)
│   ├── lucide/         # 1,400+ Lucide icons
│   ├── octicons/       # GitHub Octicons
│   ├── remix/          # 2,800+ Remix icons
│   ├── feather/        # Feather icons
│   ├── coolicons/      # Coolicons set
│   ├── boxicons/       # Boxicons collection
│   ├── logos/          # 6,000+ brand logos
│   └── rpg-awesome/    # RPG & gaming icons
│
├── macos/              # macOS-specific assets
│   ├── apps/           # 2,500+ app icons (ICNS + PNG)
│   ├── folders/        # 4,000+ folder icons
│   │   ├── branded/    # Branded folder variations
│   │   ├── colors/     # Color-coded folders
│   │   ├── default/    # Default macOS style
│   │   └── misc/       # Miscellaneous folder icons
│   └── misc/           # System & utility icons
│
├── music/              # Music & audio
│   ├── band-logos/     # 320+ band/artist logos (SVG)
│   ├── rings/          # Circular badge icons
│   └── misc/           # Music-related assets
│
└── utilities/          # Tools & scripts
    ├── keyboard-maestro-actions/
    └── scripts/
```

---

## 🎨 Collections

### Color Icons

| Category | Count | Description |
|----------|-------|-------------|
| **Developer** | 1,800+ | Languages, frameworks, tools, IDEs |
| **Software** | 1,100+ | Desktop applications & utilities |
| **AI** | 40+ | ChatGPT, Claude, Copilot, Midjourney... |
| **Social** | 70+ | Twitter, Discord, Reddit, LinkedIn... |
| **Browser** | 20+ | Chrome, Firefox, Arc, Brave, Safari... |
| **Database** | 70+ | PostgreSQL, MongoDB, Redis, MySQL... |
| **Design** | 40+ | Figma, Adobe suite, Sketch, Canva... |
| **Crypto** | 40+ | Bitcoin, Ethereum, Solana, wallets... |

### Plain Icons

| Set | Icons | Format | Style |
|-----|-------|--------|-------|
| **Tabler** | 5,219 | PNG + SVG | Outline & filled |
| **Simple Icons** | 3,097 | SVG | Brand logos |
| **Logos** | 6,197 | PNG + SVG | Developer brands |
| **Remix** | 2,860 | PNG + SVG | Line & fill |
| **Font Awesome** | 2,037 | PNG + SVG | Brands, regular, solid |
| **Lucide** | 1,447 | SVG | Clean line icons |
| **Octicons** | 604 | PNG + SVG | GitHub style |
| **Feather** | 287 | PNG + SVG | Minimal strokes |

### macOS Assets

| Category | Count | Formats |
|----------|-------|---------|
| **App Icons** | 2,500+ | `.icns` `.png` |
| **Branded Folders** | 3,500+ | `.icns` `.png` |
| **Color Folders** | 270+ | `.icns` |
| **Default Folders** | 90+ | `.icns` `.png` |

---

## 🔧 Usage

### Applying macOS Folder Icons

```bash
# Using fileicon (brew install fileicon)
fileicon set ~/Projects/MyApp ./macos/folders/branded/github.icns

# Or via Finder
# 1. Get Info on icon file (⌘ + I)
# 2. Click icon preview → Copy (⌘ + C)
# 3. Get Info on target folder
# 4. Click folder icon → Paste (⌘ + V)
```

### Applying App Icons

```bash
# Replace app icon
fileicon set /Applications/MyApp.app ./macos/apps/icns/custom-icon.icns

# Refresh icon cache
sudo killall Finder && sudo killall Dock
```

### Using in Web Projects

```html
<!-- SVG inline -->
<img src="plain/simple/github.svg" alt="GitHub" width="24">

<!-- As favicon -->
<link rel="icon" href="color/library/png/browser/chrome.png">
```

---

## 📦 Icon Sets Included

<details>
<summary><strong>Open Source Icon Libraries</strong></summary>

| Library | License | Link |
|---------|---------|------|
| Tabler Icons | MIT | [tabler.io/icons](https://tabler.io/icons) |
| Simple Icons | CC0 1.0 | [simpleicons.org](https://simpleicons.org) |
| Lucide | ISC | [lucide.dev](https://lucide.dev) |
| Feather Icons | MIT | [feathericons.com](https://feathericons.com) |
| Font Awesome | Various | [fontawesome.com](https://fontawesome.com) |
| Octicons | MIT | [primer.style/octicons](https://primer.style/octicons) |
| Remix Icons | Apache 2.0 | [remixicon.com](https://remixicon.com) |
| Boxicons | MIT | [boxicons.com](https://boxicons.com) |
| Coolicons | CC BY 4.0 | [coolicons.cool](https://coolicons.cool) |
| RPG Awesome | BSD | [nagoshiashumern.github.io/Rpg-Awesome](https://nagoshiashumern.github.io/Rpg-Awesome) |

</details>

---

## 🏷️ Quick Reference

```
60,000+ total icons
├── PNG:   40,000+
├── SVG:   18,000+
├── ICNS:   2,000+
└── EPS:      142
```

**Categories covered:**
`development` `programming` `frameworks` `databases` `cloud` `ai` `design` `browsers` `social` `crypto` `music` `gaming` `self-hosted` `macos` `folders` `apps`

---

## 💡 Tips

- **High-resolution PNGs** are in `color/library/png/` — great for presentations
- **macOS folder icons** work best in `.icns` format from `macos/folders/`
- **Brand logos** in SVG format are in `plain/simple/` for perfect scaling
- **Dark mode variants** are available in `*/dark/` subdirectories where applicable

---

<div align="center">

*Collected and organized for quick access*

**◈**

</div>
