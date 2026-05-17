# Iconify Tools CLI Reference

This is a custom set of CLI tools built around `@iconify/tools` to help you manage icons, download full packs, and generate links for your projects.

## 🚀 Quick Start Commands

| Command | Description |
| :--- | :--- |
| `iconify-list` | Lists all available icon pack prefixes (200+ packs). |
| `iconify-pack <prefix> [dir]` | Downloads an entire icon set as SVGs. |
| `iconify-link <prefix:name>` | Generates Markdown and HTML links for an icon. |
| `iconify-add <icon> <file> [mode]` | Directly appends an icon link/code to a file. |

---

## 📦 1. Downloading Full Icon Packs
Downloads every icon in a collection as an individual `.svg` file.

**Usage:**
```bash
iconify-pack <prefix> [target-directory]
```

**Examples:**
- `iconify-pack mdi ./icons/material` (Downloads Material Design Icons)
- `iconify-pack ph ./icons/phosphor` (Downloads Phosphor Icons)
- `iconify-pack lucide ./icons/lucide` (Downloads Lucide Icons)

---

## 🔗 2. Generating Reference Links
Get the exact code you need for your README or HTML files.

**Usage:**
```bash
iconify-link <prefix:name>
```

**Example:**
```bash
iconify-link mdi:account-circle
```
**Output:**
- **Markdown:** `![mdi:account-circle](https://api.iconify.design/mdi/account-circle.svg)`
- **HTML:** `<img src="..." alt="..." />`

---

## 📝 3. Adding Icons to Files
Directly insert icons into your documents.

**Usage:**
```bash
iconify-add <prefix:name> <file-path> [md|html|svg]
```

**Example:**
```bash
iconify-add mdi:github README.md md
```

---

## 📂 Popular Icon Pack Prefixes (Codes)
Use these prefixes with `iconify-pack` or `iconify-link`. Run `iconify-list` for the full list.

| Prefix | Name |
| :--- | :--- |
| `mdi` | Material Design Icons |
| `ph` | Phosphor Icons |
| `lucide` | Lucide Icons |
| `bi` | Bootstrap Icons |
| `ri` | Remix Icon |
| `tabler` | Tabler Icons |
| `fe` | Feather Icons |
| `ion` | Ionicons |
| `fa6-solid` | Font Awesome 6 Solid |
| `fa6-brands` | Font Awesome 6 Brands |
| `logos` | SVG Logos (Brands) |
| `skill-icons` | Skill Icons |
| `flat-color-icons` | Flat Color Icons |
| `heroicons` | Heroicons |
| `carbon` | IBM Carbon Icons |
| `ant-design` | Ant Design Icons |

---

## 🛠 Maintenance
To update or view the scripts:
- **Location:** `/Users/rd/.config/iconify-tools`
- **Scripts:** `./scripts/*.js`
