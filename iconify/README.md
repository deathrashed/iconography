<p align="center">
  <img src=".assets/icon/logo-iconify.svg" width="500" alt="Iconify Logo">
</p>

<h1 align="center">Iconify Icon Library</h1>

<p align="center">

[![Icons](https://img.shields.io/badge/Icons-224%20packs-8B5CF6?style=for-the-badge&labelColor=1a1a2e)](https://icon-sets.iconify.design)
[![Total SVGs](https://img.shields.io/badge/Total%20SVGs-100K%2B-06B6D4?style=for-the-badge&labelColor=1a1a2e)](https://github.com/iconify/icon-sets)
[![Offline](https://img.shields.io/badge/Offline-Ready-F97316?style=for-the-badge&labelColor=1a1a2e)](#local-referencing)
[![CLI](https://img.shields.io/badge/CLI-Tools-4EAA25?style=for-the-badge&labelColor=1a1a2e)](#cli-commands)

</p>

## <img src="https://api.iconify.design/lucide:list.svg?color=%2388C0D0" width="24" height="24" alt="Index"> Index

- [Overview](#overview)
- [CLI Commands](#cli-commands)
- [Icon Pack Categories](#icon-pack-categories)
- [All Icon Packs Reference](#all-icon-packs-reference)
- [Usage](#usage)
- [Repository Reference](#repository-reference)

---

## <img src="https://api.iconify.design/lucide:boxes.svg?color=%2388C0D0" width="24" height="24" alt="Overview"> Overview

<div align="center">

<img src="https://api.iconify.design/lucide:box.svg?color=%2388C0D0" width="18" height="18" alt="Box">
<img src="https://api.iconify.design/lucide:layers.svg?color=%2388C0D0" width="18" height="18" alt="Layers">
<img src="https://api.iconify.design/lucide:palette.svg?color=%2388C0D0" width="18" height="18" alt="Palette">
<img src="https://api.iconify.design/lucide:folder-tree.svg?color=%2388C0D0" width="18" height="18" alt="Folder">

</div>

A comprehensive collection of **224 open-source icon packs** containing **100,000+ vector icons** downloaded locally for offline use, quick lookups, and bulk processing.

**Features:**
- <img src="https://api.iconify.design/lucide:download.svg?color=%2388C0D0" width="14" height="14" alt="Download"> All icons downloaded as individual SVG files
- <img src="https://api.iconify.design/lucide:terminal.svg?color=%2388C0D0" width="14" height="14" alt="Terminal"> CLI tools for downloading packs and generating links
- <img src="https://api.iconify.design/lucide:wifi-off.svg?color=%2388C0D0" width="14" height="14" alt="Offline"> Works completely offline
- <img src="https://api.iconify.design/lucide:file-text.svg?color=%2388C0D0" width="14" height="14" alt="Docs"> Perfect for documentation and READMEs

---

## <img src="https://api.iconify.design/lucide:terminal-square.svg?color=%2388C0D0" width="24" height="24" alt="Terminal"> CLI Commands

<div align="center">

<img src="https://api.iconify.design/lucide:command.svg?color=%2388C0D0" width="24" height="24" alt="Command">

</div>

Custom CLI tools built around `@iconify/tools` for managing icons.

| Command | Description |
|---------|-------------|
| `iconify-list` | List all available icon pack prefixes |
| `iconify-pack <prefix> [dir]` | Download an entire icon set as SVGs |
| `iconify-link <prefix:name>` | Generate Markdown and HTML links for an icon |
| `iconify-add <icon> <file> [mode]` | Append icon link/code to a file |

### <img src="https://api.iconify.design/lucide:download-cloud.svg?color=%2388C0D0" width="18" height="18" alt="Download"> Downloading Icon Packs

```bash
iconify-pack mdi ./mdi
iconify-pack ph ./ph
iconify-pack lucide ./lucide
```

### <img src="https://api.iconify.design/lucide:link.svg?color=%2388C0D0" width="18" height="18" alt="Link"> Generating Links

```bash
iconify-link mdi:home
# Output:
# Markdown: ![mdi:home](https://api.iconify.design/mdi:home.svg)
# HTML: <img src="https://api.iconify.design/mdi:home.svg" alt="mdi:home" />
```

### <img src="https://api.iconify.design/lucide:file-plus.svg?color=%2388C0D0" width="18" height="18" alt="Add"> Adding Icons to Files

```bash
iconify-add mdi:github README.md md
iconify-add ph:user index.html html
iconify-add lucide:code file.svg svg
```

### <img src="https://api.iconify.design/lucide:palette.svg?color=%2388C0D0" width="18" height="18" alt="Color"> Coloring Icons

By default, monotone icons use `currentColor` (black in Markdown). Use the `color` parameter:

```bash
# White icon
iconify-link mdi:home?color=white

# Hex color (encode # as %23)
iconify-link mdi:home?color=%23FF5733
```

---

## <img src="https://api.iconify.design/lucide:layout-dashboard.svg?color=%2388C0D0" width="24" height="24" alt="Categories"> Icon Pack Categories

### <img src="https://api.iconify.design/lucide:layout-grid.svg?color=%2388C0D0" width="18" height="18" alt="UI"> <img src="https://api.iconify.design/lucide:mouse-pointer-2.svg?color=%2388C0D0" width="18" height="18" alt="Pointer"> <img src="https://api.iconify.design/lucide:panel-top.svg?color=%2388C0D0" width="18" height="18" alt="Panel"> UI & Interface Icons

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Material Design Icons | `mdi` | ~7,000 | <img src="https://api.iconify.design/mdi:home.svg" width="24" height="24" alt="mdi"> |
| Phosphor Icons | `ph` | ~1,500 | <img src="https://api.iconify.design/ph:house.svg" width="24" height="24" alt="ph"> |
| Lucide Icons | `lucide` | ~1,500 | <img src="https://api.iconify.design/lucide:home.svg" width="24" height="24" alt="lucide"> |
| Tabler Icons | `tabler` | ~4,500 | <img src="https://api.iconify.design/tabler:home.svg" width="24" height="24" alt="tabler"> |
| Bootstrap Icons | `bi` | ~1,300 | <img src="https://api.iconify.design/bi:house.svg" width="24" height="24" alt="bi"> |
| Remix Icon | `ri` | ~2,000 | <img src="https://api.iconify.design/ri:home-2-line.svg" width="24" height="24" alt="ri"> |
| Feather Icons | `fe` | ~280 | <img src="https://api.iconify.design/fe:home.svg" width="24" height="24" alt="fe"> |
| Heroicons | `heroicons` | ~600 | <img src="https://api.iconify.design/heroicons:home.svg" width="24" height="24" alt="heroicons"> |
| Carbon Icons | `carbon` | ~1,000 | <img src="https://api.iconify.design/carbon:home.svg" width="24" height="24" alt="carbon"> |
| Radix Icons | `radix-icons` | ~150 | <img src="https://api.iconify.design/radix-icons:home.svg" width="24" height="24" alt="radix-icons"> |
| Clarity Icons | `clarity` | ~500 | <img src="https://api.iconify.design/clarity:home-solid.svg" width="24" height="24" alt="clarity"> |
| Ant Design | `ant-design` | ~800 | <img src="https://api.iconify.design/ant-design:home-outlined.svg" width="24" height="24" alt="ant-design"> |
| Boxicons | `bx` | ~800 | <img src="https://api.iconify.design/bx:home.svg" width="24" height="24" alt="bx"> |
| Ionicons | `ion` | ~1,500 | <img src="https://api.iconify.design/ion:home.svg" width="24" height="24" alt="ion"> |
| Line Awesome | `la` | ~2,000 | <img src="https://api.iconify.design/la:home.svg" width="24" height="24" alt="la"> |
| Typicons | `typcn` | ~400 | <img src="https://api.iconify.design/typcn:home.svg" width="24" height="24" alt="typcn"> |
| Foundation | `foundation` | ~300 | <img src="https://api.iconify.design/foundation:home.svg" width="24" height="24" alt="foundation"> |
| Open Iconic | `oi` | ~400 | <img src="https://api.iconify.design/oi:home.svg" width="24" height="24" alt="oi"> |

</div>

### <img src="https://api.iconify.design/lucide:brackets.svg?color=%2388C0D0" width="18" height="18" alt="Dev"> <img src="https://api.iconify.design/lucide:terminal.svg?color=%2388C0D0" width="18" height="18" alt="Terminal"> <img src="https://api.iconify.design/lucide:file-code-2.svg?color=%2388C0D0" width="18" height="18" alt="Code File"> Developer & Code

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| VS Code Icons | `vscode-icons` | ~500 | <img src="https://api.iconify.design/vscode-icons:file-type-js.svg" width="24" height="24" alt="vscode-icons"> |
| Codicons | `codicon` | ~400 | <img src="https://api.iconify.design/codicon:file-code.svg" width="24" height="24" alt="codicon"> |
| Octicons | `octicon` | ~200 | <img src="https://api.iconify.design/octicon:file-code.svg" width="24" height="24" alt="octicon"> |
| Devicon | `devicon` | ~400 | <img src="https://api.iconify.design/devicon:vscode.svg" width="24" height="24" alt="devicon"> |
| File Icons | `file-icons` | ~800 | <img src="https://api.iconify.design/file-icons:vscode.svg" width="24" height="24" alt="file-icons"> |
| Boxicons Solid | `bxs` | ~500 | <img src="https://api.iconify.design/bxs:home.svg" width="24" height="24" alt="bxs"> |
| Boxicons Logotypes | `bxl` | ~200 | <img src="https://api.iconify.design/bxl:visual-studio.svg" width="24" height="24" alt="bxl"> |
| VS Icons | `vs` | ~200 | <img src="https://api.iconify.design/vs:sun.svg" width="24" height="24" alt="vs"> |

</div>

### <img src="https://api.iconify.design/lucide:megaphone.svg?color=%2388C0D0" width="18" height="18" alt="Brand"> <img src="https://api.iconify.design/lucide:badge-check.svg?color=%2388C0D0" width="18" height="18" alt="Badge"> <img src="https://api.iconify.design/lucide:shapes.svg?color=%2388C0D0" width="18" height="18" alt="Shapes"> Brand & Logo Icons

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Simple Icons | `simple-icons` | ~3,000 | <img src="https://api.iconify.design/simple-icons:github.svg" width="24" height="24" alt="simple-icons"> |
| Skill Icons | `skill-icons` | ~300 | <img src="https://api.iconify.design/skill-icons:github-dark.svg" width="24" height="24" alt="skill-icons"> |
| Logos | `logos` | ~500 | <img src="https://api.iconify.design/logos:github-icon.svg" width="24" height="24" alt="logos"> |
| Font Awesome Brands | `fa-brands` | ~500 | <img src="https://api.iconify.design/fa-brands:github.svg" width="24" height="24" alt="fa-brands"> |
| Font Awesome 6 Brands | `fa6-brands` | ~600 | <img src="https://api.iconify.design/fa6-brands:github.svg" width="24" height="24" alt="fa6-brands"> |
| Font Awesome 7 Brands | `fa7-brands` | ~700 | <img src="https://api.iconify.design/fa7-brands:github.svg" width="24" height="24" alt="fa7-brands"> |
| Devicon Plain | `devicon-plain` | ~400 | <img src="https://api.iconify.design/devicon-plain:githubactions.svg" width="24" height="24" alt="devicon-plain"> |

</div>

### <img src="https://api.iconify.design/lucide:smile.svg?color=%2388C0D0" width="18" height="18" alt="Emoji"> <img src="https://api.iconify.design/lucide:sparkles.svg?color=%2388C0D0" width="18" height="18" alt="Sparkles"> <img src="https://api.iconify.design/lucide:party-popper.svg?color=%2388C0D0" width="18" height="18" alt="Party"> Emoji & Emotion

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Emoji One | `emojione` | ~2,000 | <img src="https://api.iconify.design/emojione:smiling-face.svg" width="24" height="24" alt="emojione"> |
| Emoji One v1 | `emojione-v1` | ~2,000 | <img src="https://api.iconify.design/emojione-v1:smiling-face.svg" width="24" height="24" alt="emojione-v1"> |
| Emoji One Monotone | `emojione-monotone` | ~2,000 | <img src="https://api.iconify.design/emojione-monotone:smiling-face.svg" width="24" height="24" alt="emojione-monotone"> |
| Twitter Emoji | `twemoji` | ~2,000 | <img src="https://api.iconify.design/twemoji:smiling-face.svg" width="24" height="24" alt="twemoji"> |
| OpenMoji | `openmoji` | ~4,000 | <img src="https://api.iconify.design/openmoji:smiling-face.svg" width="24" height="24" alt="openmoji"> |
| Noto Emoji | `noto` | ~2,000 | <img src="https://api.iconify.design/noto:smiling-face.svg" width="24" height="24" alt="noto"> |
| Noto Emoji v1 | `noto-v1` | ~2,000 | <img src="https://api.iconify.design/noto-v1:smiling-face.svg" width="24" height="24" alt="noto-v1"> |
| Fluent Emoji | `fluent-emoji` | ~200 | <img src="https://api.iconify.design/fluent-emoji:smiling-face.svg" width="24" height="24" alt="fluent-emoji"> |
| Fluent Emoji Flat | `fluent-emoji-flat` | ~200 | <img src="https://api.iconify.design/fluent-emoji-flat:smiling-face.svg" width="24" height="24" alt="fluent-emoji-flat"> |
| Fluent Emoji High Contrast | `fluent-emoji-high-contrast` | ~200 | <img src="https://api.iconify.design/fluent-emoji-high-contrast:smiling-face.svg" width="24" height="24" alt="fluent-emoji-high-contrast"> |
| Streamline Emojis | `streamline-emojis` | ~500 | <img src="https://api.iconify.design/streamline-emojis:grinning-face.svg" width="24" height="24" alt="streamline-emojis"> |

</div>

### <img src="https://api.iconify.design/lucide:flag.svg?color=%2388C0D0" width="18" height="18" alt="Flag"> <img src="https://api.iconify.design/lucide:map.svg?color=%2388C0D0" width="18" height="18" alt="Map"> <img src="https://api.iconify.design/lucide:globe-2.svg?color=%2388C0D0" width="18" height="18" alt="Globe"> Flags

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Circle Flags | `circle-flags` | ~300 | <img src="https://api.iconify.design/circle-flags:us.svg" width="24" height="24" alt="circle-flags"> |
| Flag Icons | `flag` | ~250 | <img src="https://api.iconify.design/flag:us-4x3.svg" width="24" height="24" alt="flag"> |
| Flagpack | `flagpack` | ~300 | <img src="https://api.iconify.design/flagpack:us.svg" width="24" height="24" alt="flagpack"> |
| CIF Flags | `cif` | ~250 | <img src="https://api.iconify.design/cif:us.svg" width="24" height="24" alt="cif"> |

</div>

### <img src="https://api.iconify.design/lucide:bitcoin.svg?color=%2388C0D0" width="18" height="18" alt="Crypto"> <img src="https://api.iconify.design/lucide:wallet.svg?color=%2388C0D0" width="18" height="18" alt="Wallet"> <img src="https://api.iconify.design/lucide:coins.svg?color=%2388C0D0" width="18" height="18" alt="Coins"> Cryptocurrency

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Cryptocurrency | `cryptocurrency` | ~500 | <img src="https://api.iconify.design/cryptocurrency:btc.svg" width="24" height="24" alt="cryptocurrency"> |
| Cryptocurrency Color | `cryptocurrency-color` | ~500 | <img src="https://api.iconify.design/cryptocurrency-color:btc.svg" width="24" height="24" alt="cryptocurrency-color"> |
| Bitcoin Icons | `bitcoin-icons` | ~200 | <img src="https://api.iconify.design/bitcoin-icons:wallet-outline.svg" width="24" height="24" alt="bitcoin-icons"> |

</div>

### <img src="https://api.iconify.design/lucide:sun.svg?color=%2388C0D0" width="18" height="18" alt="Weather"> <img src="https://api.iconify.design/lucide:cloud-sun.svg?color=%2388C0D0" width="18" height="18" alt="Cloud Sun"> <img src="https://api.iconify.design/lucide:cloud-rain.svg?color=%2388C0D0" width="18" height="18" alt="Rain"> Weather

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Meteocons | `meteocons` | ~200 | <img src="https://api.iconify.design/meteocons:clear-day.svg" width="24" height="24" alt="meteocons"> |
| Weather Icons | `wi` | ~200 | <img src="https://api.iconify.design/wi:day-sunny.svg" width="24" height="24" alt="wi"> |

</div>

### <img src="https://api.iconify.design/lucide:map-pin.svg?color=%2388C0D0" width="18" height="18" alt="Map"> <img src="https://api.iconify.design/lucide:route.svg?color=%2388C0D0" width="18" height="18" alt="Route"> <img src="https://api.iconify.design/lucide:navigation.svg?color=%2388C0D0" width="18" height="18" alt="Navigation"> Maps & GIS

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Geo Icons | `geo` | ~100 | <img src="https://api.iconify.design/geo:ui-earth-east.svg" width="24" height="24" alt="geo"> |
| GIS Icons | `gis` | ~100 | <img src="https://api.iconify.design/gis:map.svg" width="24" height="24" alt="gis"> |
| Map Icons | `map` | ~100 | <img src="https://api.iconify.design/map:airport.svg" width="24" height="24" alt="map"> |

</div>

### <img src="https://api.iconify.design/lucide:building.svg?color=%2388C0D0" width="18" height="18" alt="Business"> <img src="https://api.iconify.design/lucide:briefcase-business.svg?color=%2388C0D0" width="18" height="18" alt="Briefcase"> <img src="https://api.iconify.design/lucide:chart-no-axes-combined.svg?color=%2388C0D0" width="18" height="18" alt="Chart"> Business & Finance

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| BPMN Icons | `bpmn` | ~200 | <img src="https://api.iconify.design/bpmn:task.svg" width="24" height="24" alt="bpmn"> |
| Medical Icon | `medical-icon` | ~300 | <img src="https://api.iconify.design/medical-icon:laboratory.svg" width="24" height="24" alt="medical-icon"> |
| Healthicons | `healthicons` | ~200 | <img src="https://api.iconify.design/healthicons:heart.svg" width="24" height="24" alt="healthicons"> |
| Vaadin Icons | `vaadin` | ~600 | <img src="https://api.iconify.design/vaadin:home.svg" width="24" height="24" alt="vaadin"> |

</div>

### <img src="https://api.iconify.design/lucide:gamepad-2.svg?color=%2388C0D0" width="18" height="18" alt="Game"> <img src="https://api.iconify.design/lucide:dices.svg?color=%2388C0D0" width="18" height="18" alt="Dice"> <img src="https://api.iconify.design/lucide:swords.svg?color=%2388C0D0" width="18" height="18" alt="Swords"> Gaming & Entertainment

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| Game Icons | `game-icons` | ~4,000 | <img src="https://api.iconify.design/game-icons:dice-six-faces-one.svg" width="24" height="24" alt="game-icons"> |
| RPG Awesome | `raphael` | ~500 | <img src="https://api.iconify.design/raphael:lab.svg" width="24" height="24" alt="raphael"> |
| Subway Icons | `subway` | ~200 | <img src="https://api.iconify.design/subway:search.svg" width="24" height="24" alt="subway"> |
| Game Glyphs | `gg` | ~300 | <img src="https://api.iconify.design/gg:games.svg" width="24" height="24" alt="gg"> |

</div>

### <img src="https://api.iconify.design/lucide:flask-conical.svg?color=%2388C0D0" width="18" height="18" alt="Science"> <img src="https://api.iconify.design/lucide:microscope.svg?color=%2388C0D0" width="18" height="18" alt="Microscope"> <img src="https://api.iconify.design/lucide:atom.svg?color=%2388C0D0" width="18" height="18" alt="Atom"> Science & Laboratory

<div align="center">

| Pack | Prefix | Icons | Preview |
|------|--------|-------|---------|
| EOS Icons | `eos-icons` | ~500 | <img src="https://api.iconify.design/eos-icons:code-deploy.svg" width="24" height="24" alt="eos-icons"> |
| Academia Icons | `academicons` | ~100 | <img src="https://api.iconify.design/academicons:arxiv.svg" width="24" height="24" alt="academicons"> |

</div>

---

## <img src="https://api.iconify.design/lucide:library-big.svg?color=%2388C0D0" width="24" height="24" alt="Library"> All Icon Packs Reference

<details>
<summary><strong><img src="https://api.iconify.design/lucide:table-properties.svg?color=%2388C0D0" width="16" height="16" alt="Table"> Click to expand all 224 icon packs</strong></summary>

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> A

| Prefix | Folder | Description |
|--------|---------|-------------|
| `academicons` | academicons | Academic/Research icons |
| `akar` | akar | Akar icons |
| `ant-design` | ant-design | Ant Design official icons |
| `arcticons` | arcticons | Arcticons icon pack |
| `basil` | basil | Basil icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> B

| Prefix | Folder | Description |
|--------|---------|-------------|
| `bi` | bi | Bootstrap Icons |
| `bitcoin-icons` | bitcoin-icons | Bitcoin-specific icons |
| `bpmn` | bpmn | Business Process icons |
| `boxicons` | boxicons | Boxicons icons |
| `brandico` | brandico | Brandico icons |
| `bx` | bx | Boxicons line icons |
| `bxl` | bxl | Boxicons logos |
| `bxs` | bxs | Boxicons solid icons |
| `bytesize` | bytesize | Tiny icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> C

| Prefix | Folder | Description |
|--------|---------|-------------|
| `carbon` | carbon | IBM Carbon Design icons |
| `catppuccin` | catppuccin | Catppuccin icons |
| `cbi` | cbi | Core Icons Bold |
| `charm` | charm | Charm icons |
| `ci` | ci | Core Icons |
| `cib` | cib | Core Icons Bold |
| `cif` | cif | CIF Flags |
| `cil` | cil | Core Line Icons |
| `circle-flags` | circle-flags | Circle country flags |
| `circum` | circum | Circum icons |
| `clarity` | clarity | VMware Clarity icons |
| `codex` | codex | Codex icons |
| `codicon` | codicon | VS Code codicons |
| `covid` | covid | COVID-19 icons |
| `cryptocurrency` | cryptocurrency | Cryptocurrency icons |
| `cryptocurrency-color` | cryptocurrency-color | Colored crypto icons |
| `cuida` | cuida | Cuida icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> D

| Prefix | Folder | Description |
|--------|---------|-------------|
| `dashicons` | dashicons | WordPress Dashicons |
| `devicon` | devicon | Devicon icons |
| `devicon-plain` | devicon-plain | Devicon plain |
| `dinkie` | dinkie | Dinkie icons |
| `duo` | duo | Duo icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> E

| Prefix | Folder | Description |
|--------|---------|-------------|
| `ei` | ei | Education Icons |
| `el` | el | Elegant icons |
| `emojione` | emojione | Emoji One |
| `emojione-monotone` | emojione-monotone | Emoji One Monotone |
| `emojione-v1` | emojione-v1 | Emoji One v1 |
| `entypo` | entypo | Entypo icons |
| `entypo-social` | entypo-social | Entypo Social |
| `eos-icons` | eos-icons | EOS icons |
| `ep` | ep | Essential icons |
| `et` | et | ET line icons |
| `eva` | eva | Eva icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> F

| Prefix | Folder | Description |
|--------|---------|-------------|
| `f7` | f7 | Framework7 icons |
| `fa` | fa | Font Awesome |
| `fa-brands` | fa-brands | Font Awesome Brands |
| `fa-regular` | fa-regular | Font Awesome Regular |
| `fa-solid` | fa-solid | Font Awesome Solid |
| `fa6-brands` | fa6-brands | Font Awesome 6 Brands |
| `fa6-regular` | fa6-regular | Font Awesome 6 Regular |
| `fa6-solid` | fa6-solid | Font Awesome 6 Solid |
| `fa7-brands` | fa7-brands | Font Awesome 7 Brands |
| `fa7-regular` | fa7-regular | Font Awesome 7 Regular |
| `fa7-solid` | fa7-solid | Font Awesome 7 Solid |
| `fad` | fad | Font Awesome Duotone |
| `famicons` | famicons | Famicons |
| `fe` | fe | Feather icons |
| `feather` | feather | Feather icons |
| `file` | file | File icons |
| `flat-color` | flat-color | Flat Color icons |
| `flat-ui` | flat-ui | Flat UI icons |
| `flag` | flag | Flag icons |
| `flagpack` | flagpack | Flagpack |
| `flowbite` | flowbite | Flowbite icons |
| `fluent` | fluent | Fluent UI System |
| `fluent-color` | fluent-color | Fluent UI Color |
| `fluent-emoji` | fluent-emoji | Fluent Emoji |
| `fluent-emoji-flat` | fluent-emoji-flat | Fluent Emoji Flat |
| `fluent-emoji-high-contrast` | fluent-emoji-high-contrast | Fluent Emoji High Contrast |
| `fluent-mdl2` | fluent-mdl2 | Fluent MDL2 |
| `fontelico` | fontelico | Fontelico icons |
| `fontisto` | fontisto | Fontisto icons |
| `formkit` | formkit | Formkit icons |
| `foundation` | foundation | Foundation icons |
| `fxemoji` | fxemoji | Firefox emojis |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> G

| Prefix | Folder | Description |
|--------|---------|-------------|
| `gala` | gala | Gala icons |
| `game-icons` | game-icons | Game icons |
| `garden` | garden | Garden icons |
| `gcp` | gcp | GCP icons |
| `geo` | geo | Geo icons |
| `gg` | gg | Game Glyphs |
| `gis` | gis | GIS icons |
| `glyphs` | glyphs | Glyphs icons |
| `glyphs-poly` | glyphs-poly | Glyphs Poly |
| `gravity-ui` | gravity-ui | Gravity UI |
| `gridicons` | gridicons | Gridicons |
| `grommet` | grommet | Grommet icons |
| `guidance` | guidance | Guidance icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> H

| Prefix | Folder | Description |
|--------|---------|-------------|
| `healthicons` | healthicons | Health icons |
| `heroicons` | heroicons | Heroicons |
| `heroicons-outline` | heroicons-outline | Heroicons Outline |
| `heroicons-solid` | heroicons-solid | Heroicons Solid |
| `hugeicons` | hugeicons | Hugeicons |
| `humbleicons` | humbleicons | Humbleicons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> I

| Prefix | Folder | Description |
|--------|---------|-------------|
| `ic` | ic | Iconify Collection |
| `icomoon-free` | icomoon-free | IcoMoon Free |
| `icon-park` | icon-park | Icon Park |
| `icon-park-outline` | icon-park-outline | Icon Park Outline |
| `icon-park-solid` | icon-park-solid | Icon Park Solid |
| `icon-park-twotone` | icon-park-twotone | Icon Park Twotone |
| `iconamoon` | iconamoon | Iconamoon |
| `iconoir` | iconoir | Iconoir icons |
| `icons8` | icons8 | Icons8 |
| `il` | il | In-Line icons |
| `ion` | ion | Ionicons |
| `iwwa` | iwwa | Iwwa icons |
| `ix` | ix | IX icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> J

| Prefix | Folder | Description |
|--------|---------|-------------|
| `jam` | jam | Jam icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> L

| Prefix | Folder | Description |
|--------|---------|-------------|
| `la` | la | Line Awesome |
| `lets` | lets | Lets icons |
| `line-md` | line-md | Line icons |
| `lineicons` | lineicons | Lineicons |
| `logos` | logos | Brand logos |
| `ls` | ls | LS line style |
| `lsicon` | lsicon | LS icon |
| `lucide` | lucide | Lucide icons |
| `lucide-lab` | lucide-lab | Lucide Lab |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> M

| Prefix | Folder | Description |
|--------|---------|-------------|
| `mage` | mage | Mage icons |
| `majesticons` | majesticons | Majesticons |
| `maki` | maki | Maki map icons |
| `map` | map | Map icons |
| `marketeq` | marketeq | Marketeq |
| `material-icon-theme` | material-icon-theme | Material Theme |
| `material-symbols` | material-symbols | Material Symbols |
| `material-symbols-light` | material-symbols-light | Material Symbols Light |
| `mdi` | mdi | Material Design Icons |
| `mdi-light` | mdi-light | Material Design Light |
| `medical-icon` | medical-icon | Medical icons |
| `memory` | memory | Memory icons |
| `meteocons` | meteocons | Meteocons |
| `meteor` | meteor | Meteor icons |
| `mi` | mi | Music icons |
| `mingcute` | mingcute | MingCute |
| `mono` | mono | Mono icons |
| `mynaui` | mynaui | Myna UI |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> N

| Prefix | Folder | Description |
|--------|---------|-------------|
| `nimbus` | nimbus | Nimbus icons |
| `nonicons` | nonicons | Nonicons |
| `noto` | noto | Noto Emoji |
| `noto-v1` | noto-v1 | Noto Emoji v1 |
| `nrk` | nrk | NRK icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> O

| Prefix | Folder | Description |
|--------|---------|-------------|
| `octicon` | octicon | GitHub Octicons |
| `oi` | oi | Open Iconic |
| `ooui` | ooui | OOUI icons |
| `openmoji` | openmoji | OpenMoji |
| `oui` | oui | OU Icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> P

| Prefix | Folder | Description |
|--------|---------|-------------|
| `pajamas` | pajamas | Pajamas icons |
| `pepicons` | pepicons | Pepicons |
| `pepicons-pencil` | pepicons-pencil | Pepicons Pencil |
| `pepicons-pop` | pepicons-pop | Pepicons Pop |
| `pepicons-print` | pepicons-print | Pepicons Print |
| `ph` | phosphor | Phosphor icons |
| `picon` | picon | Picon icons |
| `pixel` | pixel | Pixel icons |
| `pixelarticons` | pixelarticons | Pixelart icons |
| `prime` | prime | Prime icons |
| `proicons` | proicons | Pro icons |
| `ps` | ps | Phosphor Simple |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> Q

| Prefix | Folder | Description |
|--------|---------|-------------|
| `qlementine` | qlementine | Qlementine icons |
| `quill` | quill | Quill icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> R

| Prefix | Folder | Description |
|--------|---------|-------------|
| `radix-icons` | radix-icons | Radix icons |
| `raphael` | raphael | RPG Awesome |
| `ri` | ri | Remix Icon |
| `rivet` | rivet | Rivet icons |
| `roentgen` | roentgen | Roentgen icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> S

| Prefix | Folder | Description |
|--------|---------|-------------|
| `si` | si | Simple icons |
| `si-glyph` | si-glyph | Simple Glyph |
| `sidekickicons` | sidekickicons | Sidekick icons |
| `simple-icons` | simple-icons | Simple Icons |
| `simple-line` | simple-line | Simple Line Icons |
| `skill-icons` | skill-icons | Skill Icons |
| `solar` | solar | Solar icons |
| `stash` | stash | Stash icons |
| `streamline` | streamline | Streamline |
| `streamline-block` | streamline-block | Streamline Block |
| `streamline-color` | streamline-color | Streamline Color |
| `streamline-cyber` | streamline-cyber | Streamline Cyber |
| `streamline-cyber-color` | streamline-cyber-color | Streamline Cyber Color |
| `streamline-emojis` | streamline-emojis | Streamline Emojis |
| `streamline-flex` | streamline-flex | Streamline Flex |
| `streamline-flex-color` | streamline-flex-color | Streamline Flex Color |
| `streamline-freehand` | streamline-freehand | Streamline Freehand |
| `streamline-freehand-color` | streamline-freehand-color | Streamline Freehand Color |
| `streamline-kameleon-color` | streamline-kameleon-color | Streamline Kameleon Color |
| `streamline-logos` | streamline-logos | Streamline Logos |
| `streamline-pixel` | streamline-pixel | Streamline Pixel |
| `streamline-plump` | streamline-plump | Streamline Plump |
| `streamline-plump-color` | streamline-plump-color | Streamline Plump Color |
| `streamline-sharp` | streamline-sharp | Streamline Sharp |
| `streamline-sharp-color` | streamline-sharp-color | Streamline Sharp Color |
| `streamline-stickies-color` | streamline-stickies-color | Streamline Stickies Color |
| `streamline-ultimate` | streamline-ultimate | Streamline Ultimate |
| `streamline-ultimate-color` | streamline-ultimate-color | Streamline Ultimate Color |
| `subway` | subway | Subway icons |
| `svg-spinners` | svg-spinners | SVG Spinners |
| `system-uicons` | system-uicons | System UI icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> T

| Prefix | Folder | Description |
|--------|---------|-------------|
| `tabler` | tabler | Tabler Icons |
| `tdesign` | tdesign | TDesign icons |
| `teenyicons` | teenyicons | Teenyicons |
| `temaki` | temaki | Temaki icons |
| `token` | token | Token icons |
| `token-branded` | token-branded | Token Branded |
| `topcoat` | topcoat | Topcoat icons |
| `twemoji` | twemoji | Twitter Emoji |
| `typcn` | typcn | Typicons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> U

| Prefix | Folder | Description |
|--------|---------|-------------|
| `uil` | uil | UIL icons |
| `uim` | uim | UIM icons |
| `uis` | uis | UIS icons |
| `uit` | uit | UIT icons |
| `uiw` | uiw | UIW icons |
| `unjs` | unjs | UnJS icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> V

| Prefix | Folder | Description |
|--------|---------|-------------|
| `vaadin` | vaadin | Vaadin icons |
| `vs` | vs | VS icons |
| `vscode` | vscode | VS Code icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> W

| Prefix | Folder | Description |
|--------|---------|-------------|
| `websymbol` | websymbol | Web Symbols |
| `weui` | weui | WeUI icons |
| `whh` | whh | WHH icons |
| `wi` | wi | Weather Icons |
| `wordpress` | wordpress | WordPress icons |
| `wpf` | wpf | WPF icons |

### <img src="https://api.iconify.design/lucide:letter-text.svg?color=%2388C0D0" width="18" height="18" alt="Letter"> Z

| Prefix | Folder | Description |
|--------|---------|-------------|
| `zmdi` | zmdi | Material Design Z |
| `zondicons` | zondicons | Zondicons |

</details>

---

## <img src="https://api.iconify.design/lucide:book-open-check.svg?color=%2388C0D0" width="24" height="24" alt="Usage"> Usage

Iconify icons can be used either as remote SVG images from the public API or as local files from this downloaded folder. The examples below use the `https://api.iconify.design/<prefix>:<name>.svg` form because it matches the CLI output and is easy to paste into Markdown, but the official API also supports `https://api.iconify.design/<prefix>/<name>.svg` for the same SVG-rendering endpoint.

Always verify the icon set prefix and icon name before adding a new preview. Most broken icons in READMEs come from mixing a display label with the real Iconify prefix, such as writing `bitcoin:btc` when the set prefix is `bitcoin-icons`, or using `vscode-icon` instead of `vscode-icons`.

Use the normal/API examples when you want copy-pasteable links for README files, web pages, documentation, issue templates, and quick previews that can depend on the public Iconify API. This is the fastest path and supports URL parameters for size, color, flip, rotation, download behavior, and design-tool bounding boxes.

<details open>
<summary><strong><img src="https://api.iconify.design/lucide:cloud.svg?color=%2388C0D0" width="16" height="16" alt="Cloud"> Normal / remote API usage</strong></summary>

### <img src="https://api.iconify.design/lucide:file-text.svg?color=%2388C0D0" width="20" height="20" alt="Markdown"> Usage in Markdown

#### <img src="https://api.iconify.design/lucide:file-text.svg?color=%2388C0D0" width="18" height="18" alt="Markdown"> Basic Syntax

```markdown
![Icon Name](https://api.iconify.design/PREFIX:NAME.svg)
```

**Example:**
```markdown
![Home](https://api.iconify.design/mdi:home.svg)
![User](https://api.iconify.design/ph:user.svg)
![Settings](https://api.iconify.design/lucide:settings.svg)
```

---

#### <img src="https://api.iconify.design/lucide:ruler.svg?color=%2388C0D0" width="18" height="18" alt="Size"> Size Options

You can control the icon size in multiple ways:

#### Option 1: URL Parameter (Recommended)
```markdown
![Small](https://api.iconify.design/mdi:home.svg?width=16)
![Medium](https://api.iconify.design/mdi:home.svg?width=24)
![Large](https://api.iconify.design/mdi:home.svg?width=48)
![XLarge](https://api.iconify.design/mdi:home.svg?width=96)
```

#### Option 2: HTML img Tag with Width/Height
```markdown
<img src="https://api.iconify.design/mdi:home.svg" width="24" height="24" alt="Home">
<img src="https://api.iconify.design/ph:user.svg" width="32" height="32" alt="User">
<img src="https://api.iconify.design/lucide:settings.svg" width="48" height="48" alt="Settings">
```

#### Option 3: Height Only
```markdown
![Icon](https://api.iconify.design/mdi:home.svg?height=32)
```

#### Option 4: Both Width and Height
```markdown
![Icon](https://api.iconify.design/mdi:home.svg?width=24&height=24)
```

---

#### <img src="https://api.iconify.design/lucide:palette.svg?color=%2388C0D0" width="18" height="18" alt="Color"> Color Options

#### Named Colors
```markdown
![White Icon](https://api.iconify.design/mdi:home.svg?color=white)
![Red Icon](https://api.iconify.design/mdi:home.svg?color=red)
![Blue Icon](https://api.iconify.design/mdi:home.svg?color=blue)
![Green Icon](https://api.iconify.design/mdi:home.svg?color=green)
![Yellow Icon](https://api.iconify.design/mdi:home.svg?color=yellow)
![Purple Icon](https://api.iconify.design/mdi:home.svg?color=purple)
```

#### Hex Colors (Must encode # as %23)
```markdown
![Orange](https://api.iconify.design/mdi:home.svg?color=%23FF5733)
![Purple](https://api.iconify.design/mdi:home.svg?color=%238B5CF6)
![Cyan](https://api.iconify.design/mdi:home.svg?color=%2306B6D4)
![Pink](https://api.iconify.design/mdi:home.svg?color=%23EC4899)
![Dark](https://api.iconify.design/mdi:home.svg?color=%231a1a2e)
```

#### RGB Colors
```markdown
![RGB](https://api.iconify.design/mdi:home.svg?color=rgb(255,87,51))
```

#### HSL Colors
```markdown
![HSL](https://api.iconify.design/mdi:home.svg?color=hsl(10,100%,50%))
```

---

#### <img src="https://api.iconify.design/lucide:flip-horizontal.svg?color=%2388C0D0" width="18" height="18" alt="Flip"> Flip & Rotate

```markdown
![Flipped Horizontal](https://api.iconify.design/mdi:home.svg?flip=horizontal)
![Flipped Vertical](https://api.iconify.design/mdi:home.svg?flip=vertical)
![Rotated 90](https://api.iconify.design/mdi:home.svg?rotate=90)
![Rotated 180](https://api.iconify.design/mdi:home.svg?rotate=180)
![Rotated 270](https://api.iconify.design/mdi:home.svg?rotate=270)
```

---

#### <img src="https://api.iconify.design/lucide:align-center.svg?color=%2388C0D0" width="18" height="18" alt="Position"> Position & Alignment

#### Centered Icons
```markdown
<div align="center">

![Icon](https://api.iconify.design/mdi:star.svg)

</div>
```

#### Inline with Text
```markdown
Click here <img src="https://api.iconify.design/mdi:arrow-right.svg?width=14" width="14" alt="arrow"> to continue
```

#### Icon as Link
```markdown
[![Home](https://api.iconify.design/mdi:home.svg)](https://example.com)
```

#### Floating Icons (Left)
```markdown
<p float="left">
  <img src="https://api.iconify.design/mdi:home.svg" width="24" />
  <img src="https://api.iconify.design/mdi:settings.svg" width="24" />
  <img src="https://api.iconify.design/mdi:user.svg" width="24" />
</p>
```

#### Vertical Stack
```markdown
<img src="https://api.iconify.design/mdi:arrow-down.svg" width="24" alt="down">
<img src="https://api.iconify.design/mdi:circle.svg" width="24" alt="circle">
<img src="https://api.iconify.design/mdi:arrow-up.svg" width="24" alt="up">
```

---

#### <img src="https://api.iconify.design/lucide:list.svg?color=%2388C0D0" width="18" height="18" alt="List"> Use Cases

#### Feature Lists
```markdown
- <img src="https://api.iconify.design/lucide:check-circle.svg?color=%2322C55E" width="16" height="16" alt="check"> Fully offline capable
- <img src="https://api.iconify.design/lucide:download.svg?color=%2388C0D0" width="16" height="16" alt="download"> Bulk download support
- <img src="https://api.iconify.design/lucide:palette.svg?color=%2388C0D0" width="16" height="16" alt="palette"> Color customization via API
- <img src="https://api.iconify.design/lucide:database.svg?color=%2388C0D0" width="16" height="16" alt="database"> 224 icon packs included
```

#### Tables with Previews
```markdown
| Icon | Name | Pack |
|------|------|------|
| ![Home](https://api.iconify.design/mdi:home.svg) | Home | mdi |
| ![User](https://api.iconify.design/ph:user.svg) | User | ph |
| ![Zap](https://api.iconify.design/lucide:zap.svg) | Zap | lucide |
| ![Star](https://api.iconify.design/tabler:star.svg) | Star | tabler |
```

#### Status Indicators
```markdown
- <img src="https://api.iconify.design/lucide:check.svg?color=%2322C55E" width="16" height="16" alt="success"> Ready
- <img src="https://api.iconify.design/lucide:loader-2.svg?color=%23F59E0B" width="16" height="16" alt="pending"> Processing
- <img src="https://api.iconify.design/lucide:x.svg?color=%23EF4444" width="16" height="16" alt="error"> Failed
- <img src="https://api.iconify.design/lucide:clock.svg?color=%236B7280" width="16" height="16" alt="waiting"> Pending
```

#### Navigation Links
```markdown
[Home](https://example.com) <img src="https://api.iconify.design/lucide:arrow-right.svg?width=14" width="14" alt="arrow">
[Documentation](https://docs.example.com) <img src="https://api.iconify.design/lucide:book-open.svg?width=14" width="14" alt="docs">
[Settings](https://settings.example.com) <img src="https://api.iconify.design/lucide:settings.svg?width=14" width="14" alt="settings">
```

#### Badges with Icons
```markdown
[![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=white)](https://developer.mozilla.org)
[![TypeScript](https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=typescript&logoColor=white)](https://www.typescriptlang.org)
[![Node.js](https://img.shields.io/badge/Node.js-339933?style=for-the-badge&logo=node.js&logoColor=white)](https://nodejs.org)
```

#### Callout Boxes (GitHub Alerts)
```markdown
> [!TIP]
> Use `iconify-link mdi:icon-name` to get the exact URL for any icon.

> [!NOTE]
> All icons support the `?color=`, `?width=`, and `?flip=` parameters.

> [!IMPORTANT]
> When using hex colors, encode # as %23 (e.g., %23FF5733)
```

#### Animated Spinners
```markdown
![Loading](https://api.iconify.design/svg-spinners:270-ring.svg?width=24)
![Dots](https://api.iconify.design/svg-spinners:3-dots-fade.svg?width=24)
```

---

### <img src="https://api.iconify.design/lucide:code-xml.svg?color=%2388C0D0" width="20" height="20" alt="HTML"> Usage in HTML

#### <img src="https://api.iconify.design/lucide:code.svg?color=%2388C0D0" width="18" height="18" alt="HTML"> Basic HTML Usage

```html
<img src="https://api.iconify.design/mdi:home.svg" alt="Home Icon">
```

---

#### <img src="https://api.iconify.design/lucide:ruler.svg?color=%2388C0D0" width="18" height="18" alt="Size"> Size in HTML

```html
<!-- Using width/height attributes -->
<img src="https://api.iconify.design/mdi:home.svg" width="16" height="16" alt="Small">
<img src="https://api.iconify.design/mdi:home.svg" width="24" height="24" alt="Medium">
<img src="https://api.iconify.design/mdi:home.svg" width="48" height="48" alt="Large">

<!-- Using style -->
<img src="https://api.iconify.design/mdi:home.svg" style="width: 32px; height: 32px;" alt="Custom">

<!-- Using CSS class -->
<style>
.icon { width: 24px; height: 24px; }
.icon-lg { width: 48px; height: 48px; }
.icon-sm { width: 16px; height: 16px; }
</style>
<img src="https://api.iconify.design/mdi:home.svg" class="icon" alt="Class">
```

---

#### <img src="https://api.iconify.design/lucide:palette.svg?color=%2388C0D0" width="18" height="18" alt="Color"> Color in HTML

```html
<!-- URL parameter (most reliable) -->
<img src="https://api.iconify.design/mdi:home.svg?color=white" alt="White">
<img src="https://api.iconify.design/mdi:home.svg?color=%23FF5733" alt="Orange">
<img src="https://api.iconify.design/mdi:home.svg?color=%238B5CF6" alt="Purple">

<!-- External SVG images cannot inherit currentColor from the parent element.
     Use the URL color parameter, inline SVG, or CSS masks when color must follow CSS. -->
```

---

#### <img src="https://api.iconify.design/lucide:wrap-text.svg?color=%2388C0D0" width="18" height="18" alt="Wrap"> Positioning in HTML

```html
<!-- Flexbox row with gap -->
<div style="display: flex; gap: 8px; align-items: center;">
  <img src="https://api.iconify.design/mdi:home.svg" width="24" alt="Home">
  <img src="https://api.iconify.design/mdi:settings.svg" width="24" alt="Settings">
  <img src="https://api.iconify.design/mdi:user.svg" width="24" alt="User">
</div>

<!-- Centered -->
<div style="text-align: center;">
  <img src="https://api.iconify.design/mdi:star.svg" width="48" alt="Star">
</div>

<!-- Inline with text -->
<p>Click <img src="https://api.iconify.design/mdi:arrow-right.svg" width="16" alt="arrow"> to continue</p>

<!-- Vertical stack -->
<div style="display: flex; flex-direction: column; gap: 4px;">
  <img src="https://api.iconify.design/mdi:chevron-up.svg" width="24" alt="up">
  <img src="https://api.iconify.design/mdi:circle.svg" width="24" alt="circle">
  <img src="https://api.iconify.design/mdi:chevron-down.svg" width="24" alt="down">
</div>

<!-- Grid layout -->
<div style="display: grid; grid-template-columns: repeat(4, 1fr); gap: 8px;">
  <img src="https://api.iconify.design/mdi:home.svg" width="24">
  <img src="https://api.iconify.design/mdi:search.svg" width="24">
  <img src="https://api.iconify.design/mdi:settings.svg" width="24">
  <img src="https://api.iconify.design/mdi:user.svg" width="24">
</div>
```

---

#### <img src="https://api.iconify.design/lucide:link.svg?color=%2388C0D0" width="18" height="18" alt="Link"> Icon as Link

```html
<!-- Simple link -->
<a href="https://example.com">
  <img src="https://api.iconify.design/mdi:home.svg" width="24" alt="Home">
</a>

<!-- Link with hover effect -->
<a href="https://example.com">
  <img src="https://api.iconify.design/mdi:home.svg" width="24" alt="Home"
       style="transition: transform 0.2s;"
       onmouseover="this.style.transform='scale(1.1)'"
       onmouseout="this.style.transform='scale(1)'">
</a>
```

---

### <img src="https://api.iconify.design/lucide:sliders-horizontal.svg?color=%2388C0D0" width="20" height="20" alt="Parameters"> Icon URL Parameters

#### <img src="https://api.iconify.design/lucide:settings-2.svg?color=%2388C0D0" width="18" height="18" alt="Params"> Complete Parameter Reference

| Parameter | Values | Description | Example |
|-----------|--------|-------------|---------|
| `width` | `16`, `24`, `32`, `48`, `64`, etc. | Icon width in pixels | `?width=24` |
| `height` | `16`, `24`, `32`, `48`, `64`, etc. | Icon height in pixels | `?height=32` |
| `color` | `white`, `black`, `red`, `%23FF5733`, `rgb()`, `hsl()` | Icon color | `?color=white` |
| `flip` | `horizontal`, `vertical` | Flip the icon | `?flip=horizontal` |
| `rotate` | `90`, `180`, `270` | Rotate the icon (degrees) | `?rotate=90` |
| `download` | `1`, `true` | Force browser download instead of inline rendering | `?download=1` |
| `box` | `1`, `true` | Add an empty viewBox-sized rectangle for design tools that crop empty space | `?box=1` |

Notes from the Iconify SVG API:

- If only `width` or `height` is set, the missing dimension is calculated from the icon's aspect ratio.
- Hex colors must encode `#` as `%23`, for example `%23FF5733`.
- `color` affects monotone icons that use `currentColor`; palette icons already contain fixed colors.
- `rotate` can also be expressed as quarter-turn numbers: `1`, `2`, and `3`.

#### <img src="https://api.iconify.design/lucide:combine.svg?color=%2388C0D0" width="18" height="18" alt="Combine"> Combined Examples

```markdown
<!-- Large white rotated icon -->
![Icon](https://api.iconify.design/mdi:home.svg?width=48&color=white&rotate=180)

<!-- Small blue flipped icon -->
![Icon](https://api.iconify.design/lucide:arrow-right.svg?width=16&color=%2306B6D4&flip=horizontal)

<!-- Medium green icon -->
![Icon](https://api.iconify.design/tabler:settings.svg?width=24&color=%2322C55E)

<!-- Large purple rotated icon -->
![Icon](https://api.iconify.design/ph:user.svg?width=32&color=%238B5CF6&rotate=90)

<!-- Extra large centered icon -->
![Icon](https://api.iconify.design/mdi:star.svg?width=96&color=%23FBBF24&align=center)
```

---

</details>

Use the local examples when you want the downloaded SVG files in this repository to be the source of truth. Local references work offline, avoid public API availability, and are better for projects that vendor icons, but recoloring behaves differently because SVG files loaded through `<img>` cannot inherit CSS `currentColor` from the parent page.

<details>
<summary><strong><img src="https://api.iconify.design/lucide:hard-drive.svg?color=%2388C0D0" width="16" height="16" alt="Drive"> Local / offline file usage</strong></summary>

### <img src="https://api.iconify.design/lucide:folder-open.svg?color=%2388C0D0" width="20" height="20" alt="Folder"> Local File Referencing

#### <img src="https://api.iconify.design/lucide:hard-drive.svg?color=%2388C0D0" width="18" height="18" alt="Local"> Referencing Downloaded Icons

Since you've downloaded all icon packs locally, you can reference them directly:

#### Basic Local Reference
```markdown
![Local Icon](./mdi/home.svg)
![Phosphor Icon](./ph/user.svg)
![Lucide Icon](./lucide/settings.svg)
```

#### With Size (HTML)
```markdown
<img src="./mdi/home.svg" width="24" height="24" alt="Home">
<img src="./ph/user.svg" width="32" height="32" alt="User">
<img src="./lucide/settings.svg" width="48" height="48" alt="Settings">
```

#### With Size (Markdown - Limited)
```markdown
<img src="./mdi/home.svg" width="24" alt="Home">
<img src="./ph/user.svg" width="32" alt="User">
```

#### With Color

When an SVG is loaded through `<img>`, its internal `currentColor` does not inherit from the surrounding page. To recolor a local monotone icon, use one of these approaches:

- Edit a copy of the SVG and replace `currentColor` with a fixed color.
- Inline the SVG markup directly in HTML so CSS can reach it.
- Use the SVG as a CSS mask and set `background-color: currentColor`.
- Generate a colored SVG through Iconify Tools or the API `color` parameter.

```xml
<!-- Original SVG (currentColor = inherits from CSS or black) -->
<path stroke="currentColor" ... />

<!-- Edit to specific color -->
<path stroke="white" ... />
```

#### Finding Local Icons

```bash
# List contents of a pack
ls /Volumes/Apfspace/Icons/iconify/mdi/

# Find specific icon
find /Volumes/Apfspace/Icons/iconify -name "home.svg"

# Count icons in a pack
ls /Volumes/Apfspace/Icons/iconify/mdi/ | wc -l
```

#### Using Iconify Tools to Export Colored Icons

You can use the Iconify Tools library to programmatically color icons:

```javascript
import { IconSet } from '@iconify/tools';

// Load local icon set
const iconSet = new IconSet(JSON.parse(fs.readFileSync('./mdi.json')));

// Export with custom color
const svg = iconSet.toString('home', { color: '#FF5733' });
```

---

</details>

## <img src="https://api.iconify.design/lucide:archive.svg?color=%2388C0D0" width="24" height="24" alt="Archive"> Repository Reference

<div align="center">

<img src="https://api.iconify.design/lucide:lightbulb.svg?color=%2388C0D0" width="18" height="18" alt="Tip">

</div>

## <img src="https://api.iconify.design/lucide:wrench.svg?color=%2388C0D0" width="24" height="24" alt="Tools"> Local Tools & Documentation

This repository includes the downloaded icon packs, a local Iconify tooling workspace, and an offline documentation snapshot. Use these paths when you need to inspect or adjust the helper scripts instead of only browsing the SVG folders.

<details open>
<summary><strong><img src="https://api.iconify.design/lucide:terminal.svg?color=%2388C0D0" width="16" height="16" alt="Terminal"> Iconify tools workspace</strong></summary>

| Path | Purpose |
|------|---------|
| `_iconify-tools/README.md` | Local README for the custom CLI helper commands. |
| `_iconify-tools/package.json` | Node package manifest, command bindings, and `@iconify/tools` dependency. |
| `_iconify-tools/package-lock.json` | Locked dependency versions for repeatable installs. |
| `_iconify-tools/scripts/` | Source scripts for `iconify-list`, `iconify-pack`, `iconify-link`, `iconify-add`, and related download helpers. |
| `_iconify-tools/my-icons/` | Local Iconify icon-set workspace and generated/custom icon data. |
| `_iconify-tools/node_modules/` | Installed dependencies; regenerate with `npm install` inside `_iconify-tools/` when needed. |

The important hand-editable files are the package metadata, the scripts, and the tool README. `node_modules` is dependency output and should not be committed.

</details>

<details>
<summary><strong><img src="https://api.iconify.design/lucide:file-text.svg?color=%2388C0D0" width="16" height="16" alt="Docs"> Documentation snapshot</strong></summary>

| Path | Purpose |
|------|---------|
| `ICONIFY-DOCS.md` | Local documentation snapshot for Iconify API, icon sets, components, and usage reference. |
| `Iconify Documentation.md` | Larger source/reference document used while expanding this README. |

Use `ICONIFY-DOCS.md`, `_iconify-tools/README.md`, and the official Iconify documentation together when checking syntax, endpoint behavior, or command details.

</details>

## <img src="https://api.iconify.design/lucide:folder-tree.svg?color=%2388C0D0" width="24" height="24" alt="Folder Tree"> Folder Structure

<details open>
<summary><strong><img src="https://api.iconify.design/lucide:star.svg?color=%2388C0D0" width="16" height="16" alt="Star"> Popular Packs</strong></summary>

```text
iconify/
├── .assets/icon/           # Logo and local asset files
├── _iconify-tools/          # Local CLI scripts, package metadata, and helper workspace
├── ICONIFY-DOCS.md          # Offline Iconify documentation snapshot
├── mdi/                    # Material Design Icons
├── ph/                     # Phosphor
├── lucide/                 # Lucide
├── bi/                     # Bootstrap Icons
├── ri/                     # Remix Icon
├── tabler/                 # Tabler Icons
├── heroicons/              # Heroicons
├── skill-icons/            # Skill Icons
├── simple-icons/           # Simple Icons / brand icons
└── logos/                  # SVG Logos / brand logos
```

</details>

<details>
<summary><strong><img src="https://api.iconify.design/lucide:git-fork.svg?color=%2388C0D0" width="16" height="16" alt="Tree"> Full Tree</strong></summary>

```text
iconify/
├── .assets/icon/                 # Logo and local asset files
├── _iconify-tools/                # Local Iconify CLI/tools workspace
│   ├── README.md                  # Tooling README
│   ├── package.json               # Tooling package manifest and bin commands
│   ├── package-lock.json          # Locked Node dependencies
│   ├── scripts/                   # CLI helper scripts
│   ├── my-icons/                  # Local/custom Iconify icon-set workspace
│   └── node_modules/              # Installed dependencies, ignored by git
├── ICONIFY-DOCS.md                # Offline Iconify documentation snapshot
├── academicons/                  # Academic and research service icons
├── akar-icons/                   # Akar Icons
├── ant-design/                   # Ant Design Icons
├── arcticons/                    # Arcticons
├── basil/                        # Basil
├── bi/                           # Bootstrap Icons
├── bitcoin-icons/                # Bitcoin Icons
├── boxicons/                     # Boxicons
├── bpmn/                         # BPMN
├── brandico/                     # Brandico
├── bubbles/                      # Bubbles
├── bx/                           # BoxIcons v2
├── bxl/                          # Boxicons Brands
├── bxs/                          # BoxIcons v2 Solid
├── carbon/                       # Carbon
├── catppuccin/                   # Catppuccin
├── circle-flags/                 # Circle Flags
├── clarity/                      # Clarity
├── codicon/                      # Codicons
├── cryptocurrency/               # Cryptocurrency icons
├── cryptocurrency-color/         # Cryptocurrency color icons
├── dashicons/                    # Dashicons / WordPress admin icons
├── devicon/                      # Devicon
├── devicon-plain/                # Devicon plain variant
├── entypo/                       # Entypo+
├── eos-icons/                    # EOS Icons
├── eva/                          # Eva Icons
├── fa/                           # Font Awesome 4
├── fa-brands/                    # Font Awesome 5 Brands
├── fa-regular/                   # Font Awesome 5 Regular
├── fa-solid/                     # Font Awesome 5 Solid
├── fa6-brands/                   # Font Awesome 6 Brands
├── fa6-regular/                  # Font Awesome 6 Regular
├── fa6-solid/                    # Font Awesome 6 Solid
├── fa7-brands/                   # Font Awesome 7 Brands
├── fa7-regular/                  # Font Awesome 7 Regular
├── fa7-solid/                    # Font Awesome 7 Solid
├── feather/                      # Feather Icons
├── fe/                           # Feather Icon
├── file-icons/                   # File Icons
├── flag/                         # Flag icons
├── flagpack/                     # Flagpack
├── flat-color-icons/             # Flat Color Icons
├── flowbite/                     # Flowbite Icons
├── fluent/                       # Fluent UI System Icons
├── fluent-color/                 # Fluent UI System Color Icons
├── fluent-emoji/                 # Fluent Emoji
├── fluent-emoji-flat/            # Fluent Emoji Flat
├── fluent-emoji-high-contrast/   # Fluent Emoji High Contrast
├── fontisto/                     # Fontisto
├── foundation/                   # Foundation
├── game-icons/                   # Game Icons
├── grommet-icons/                # Grommet Icons
├── heroicons/                    # Heroicons
├── heroicons-outline/            # HeroIcons v1 Outline
├── heroicons-solid/              # HeroIcons v1 Solid
├── hugeicons/                    # Huge Icons
├── ic/                           # Google Material Icons
├── icon-park-outline/            # IconPark Outline
├── icon-park-solid/              # IconPark Solid
├── icon-park-twotone/            # IconPark TwoTone
├── iconamoon/                    # IconaMoon
├── iconoir/                      # Iconoir
├── icons8/                       # Icons8 Windows 10 Icons
├── ion/                          # Ionicons
├── line-md/                      # Material Line Icons
├── logos/                        # SVG Logos
├── lucide/                       # Lucide
├── lucide-lab/                   # Lucide Lab
├── material-symbols/             # Material Symbols
├── material-symbols-light/       # Material Symbols Light
├── mdi/                          # Material Design Icons
├── mdi-light/                    # Material Design Light
├── mingcute/                     # MingCute Icon
├── mi/                           # Mono Icons
├── octicon/                      # Octicons
├── openmoji/                     # OpenMoji
├── ph/                           # Phosphor
├── pixelarticons/                # Pixelarticons
├── radix-icons/                  # Radix Icons
├── ri/                           # Remix Icon
├── si/                           # Sargam Icons
├── simple-icons/                 # Simple Icons
├── skill-icons/                  # Skill Icons
├── solar/                        # Solar
├── streamline/                   # Streamline
├── svg-spinners/                 # SVG Spinners
├── tabler/                       # Tabler Icons
├── tdesign/                      # TDesign Icons
├── teenyicons/                   # Teenyicons
├── twemoji/                      # Twemoji
├── uil/                          # Unicons
├── vscode-icons/                 # VS Code Icons
├── wi/                           # Weather Icons
├── zmdi/                         # Material Design Iconic Font
└── zondicons/                    # Zondicons
```

</details>

<details>
<summary><strong><img src="https://api.iconify.design/lucide:table-2.svg?color=%2388C0D0" width="16" height="16" alt="Table"> Prefix Table</strong></summary>

| Pack                         |                       Prefix | Example                                    | Comment                                    |
| ---------------------------- | ---------------------------: | ------------------------------------------ | ------------------------------------------ |
| Material Design Icons        |                        `mdi` | `mdi:home`                                 | General-purpose Material-style UI icons    |
| Material Design Light        |                  `mdi-light` | `mdi-light:home`                           | Lightweight Pictogrammers Material variant |
| Material Symbols             |           `material-symbols` | `material-symbols:home`                    | Google Material Symbols                    |
| Material Symbols Light       |     `material-symbols-light` | `material-symbols-light:home`              | Light-weight Google Material Symbols       |
| Google Material Icons        |                         `ic` | `ic:baseline-home`                         | Legacy Google Material Icons prefix        |
| Phosphor                     |                         `ph` | `ph:house`                                 | Large flexible UI icon family              |
| Lucide                       |                     `lucide` | `lucide:home`                              | Clean Feather-style outline icons          |
| Lucide Lab                   |                 `lucide-lab` | `lucide-lab:beaker`                        | Experimental Lucide icons                  |
| Bootstrap Icons              |                         `bi` | `bi:house`                                 | Bootstrap’s official icon set              |
| Remix Icon                   |                         `ri` | `ri:home-2-line`                           | Broad UI and product icon set              |
| Tabler Icons                 |                     `tabler` | `tabler:home`                              | Large outline UI icon set                  |
| Heroicons                    |                  `heroicons` | `heroicons:home`                           | Current Heroicons collection               |
| HeroIcons v1 Outline         |          `heroicons-outline` | `heroicons-outline:home`                   | Legacy Heroicons outline set               |
| HeroIcons v1 Solid           |            `heroicons-solid` | `heroicons-solid:home`                     | Legacy Heroicons solid set                 |
| Feather Icons                |                    `feather` | `feather:home`                             | Original Feather Icons                     |
| Feather Icon                 |                         `fe` | `fe:home`                                  | Separate Feather Icon set                  |
| Font Awesome 4               |                         `fa` | `fa:home`                                  | Legacy Font Awesome 4                      |
| Font Awesome 5 Brands        |                  `fa-brands` | `fa-brands:github`                         | Font Awesome 5 brand icons                 |
| Font Awesome 5 Regular       |                 `fa-regular` | `fa-regular:circle`                        | Font Awesome 5 regular style               |
| Font Awesome 5 Solid         |                   `fa-solid` | `fa-solid:home`                            | Font Awesome 5 solid style                 |
| Font Awesome 6 Brands        |                 `fa6-brands` | `fa6-brands:github`                        | Font Awesome 6 brand icons                 |
| Font Awesome 6 Regular       |                `fa6-regular` | `fa6-regular:circle`                       | Font Awesome 6 regular style               |
| Font Awesome 6 Solid         |                  `fa6-solid` | `fa6-solid:house`                          | Font Awesome 6 solid style                 |
| Font Awesome 7 Brands        |                 `fa7-brands` | `fa7-brands:github`                        | Font Awesome 7 brand icons                 |
| Font Awesome 7 Regular       |                `fa7-regular` | `fa7-regular:circle`                       | Font Awesome 7 regular style               |
| Font Awesome 7 Solid         |                  `fa7-solid` | `fa7-solid:house`                          | Font Awesome 7 solid style                 |
| Ionicons                     |                        `ion` | `ion:home`                                 | Ionic framework icon set                   |
| Simple Icons                 |               `simple-icons` | `simple-icons:github`                      | Brand and product icons                    |
| SVG Logos                    |                      `logos` | `logos:github-icon`                        | Colorful brand logos                       |
| Skill Icons                  |                `skill-icons` | `skill-icons:javascript`                   | Developer skill and stack icons            |
| Devicon                      |                    `devicon` | `devicon:git`                              | Developer technology icons                 |
| Devicon Plain                |              `devicon-plain` | `devicon-plain:git`                        | Plain Devicon variant                      |
| File Icons                   |                 `file-icons` | `file-icons:folder`                        | Filetype and editor icons                  |
| Flat Color Icons             |           `flat-color-icons` | `flat-color-icons:home`                    | Colorful Google-style icons                |
| SVG Spinners                 |               `svg-spinners` | `svg-spinners:270-ring`                    | Animated loading spinners                  |
| VS Code Icons                |               `vscode-icons` | `vscode-icons:file-type-json`              | VS Code-style file icons                   |
| Academicons                  |                `academicons` | `academicons:google-scholar`               | Academic and research icons                |
| Akar Icons                   |                 `akar-icons` | `akar-icons:home`                          | Minimal outline icons                      |
| Ant Design Icons             |                 `ant-design` | `ant-design:home-outlined`                 | Ant Design system icons                    |
| Arcticons                    |                  `arcticons` | `arcticons:home-assistant`                 | Monochrome app icons                       |
| Basil                        |                      `basil` | `basil:home-outline`                       | Rounded UI icons                           |
| Bitcoin Icons                |              `bitcoin-icons` | `bitcoin-icons:wallet-outline`             | Bitcoin-specific icons                     |
| Boxicons                     |                   `boxicons` | `boxicons:home`                            | Boxicons core collection                   |
| BoxIcons v2                  |                         `bx` | `bx:home`                                  | BoxIcons v2 regular icons                  |
| Boxicons Brands              |                        `bxl` | `bxl:github`                               | Boxicons brand icons                       |
| BoxIcons v2 Solid            |                        `bxs` | `bxs:home`                                 | BoxIcons v2 solid icons                    |
| BPMN                         |                       `bpmn` | `bpmn:start-event`                         | Business process diagram icons             |
| Brandico                     |                   `brandico` | `brandico:github`                          | Legacy brand icons                         |
| Carbon                       |                     `carbon` | `carbon:home`                              | IBM Carbon icons                           |
| Catppuccin                   |                 `catppuccin` | `catppuccin:folder`                        | Catppuccin-themed icons                    |
| Circle Flags                 |               `circle-flags` | `circle-flags:us`                          | Circular country flags                     |
| Clarity                      |                    `clarity` | `clarity:home-line`                        | VMware Clarity icons                       |
| Codicons                     |                    `codicon` | `codicon:home`                             | VS Code product icons                      |
| Cryptocurrency Icons         |             `cryptocurrency` | `cryptocurrency:btc`                       | Monochrome crypto icons                    |
| Cryptocurrency Color Icons   |       `cryptocurrency-color` | `cryptocurrency-color:btc`                 | Color crypto icons                         |
| Dashicons                    |                  `dashicons` | `dashicons:admin-home`                     | WordPress admin icons                      |
| Entypo+                      |                     `entypo` | `entypo:home`                              | Entypo icon set                            |
| EOS Icons                    |                  `eos-icons` | `eos-icons:home`                           | Enterprise/open-source UI icons            |
| Eva Icons                    |                        `eva` | `eva:home-outline`                         | Eva Design icons                           |
| Flag Icons                   |                       `flag` | `flag:us-4x3`                              | Country flags                              |
| Flagpack                     |                   `flagpack` | `flagpack:us`                              | Flagpack country flags                     |
| Flowbite Icons               |                   `flowbite` | `flowbite:home-outline`                    | Flowbite UI icons                          |
| Fluent UI System Icons       |                     `fluent` | `fluent:home-24-regular`                   | Microsoft Fluent UI icons                  |
| Fluent UI System Color Icons |               `fluent-color` | `fluent-color:home-24`                     | Color Fluent icons                         |
| Fluent Emoji                 |               `fluent-emoji` | `fluent-emoji:grinning-face`               | Microsoft Fluent emoji                     |
| Fluent Emoji Flat            |          `fluent-emoji-flat` | `fluent-emoji-flat:grinning-face`          | Flat Fluent emoji                          |
| Fluent Emoji High Contrast   | `fluent-emoji-high-contrast` | `fluent-emoji-high-contrast:grinning-face` | High-contrast Fluent emoji                 |
| Fontisto                     |                   `fontisto` | `fontisto:home`                            | General UI and brand icons                 |
| Foundation                   |                 `foundation` | `foundation:home`                          | Zurb Foundation icon font                  |
| Game Icons                   |                 `game-icons` | `game-icons:castle`                        | Fantasy/game object icons                  |
| Grommet Icons                |              `grommet-icons` | `grommet-icons:home`                       | Grommet UI icons                           |
| Huge Icons                   |                  `hugeicons` | `hugeicons:home-01`                        | Large modern UI icon set                   |
| IconPark Outline             |          `icon-park-outline` | `icon-park-outline:home`                   | IconPark outline style                     |
| IconPark Solid               |            `icon-park-solid` | `icon-park-solid:home`                     | IconPark solid style                       |
| IconPark TwoTone             |          `icon-park-twotone` | `icon-park-twotone:home`                   | IconPark two-tone style                    |
| IconaMoon                    |                  `iconamoon` | `iconamoon:home`                           | Rounded UI icons                           |
| Iconoir                      |                    `iconoir` | `iconoir:home`                             | Modern outline icons                       |
| Icons8 Windows 10 Icons      |                     `icons8` | `icons8:home`                              | Icons8 Windows-style icons                 |
| Material Line Icons          |                    `line-md` | `line-md:home`                             | Animated/material line icons               |
| MingCute Icon                |                   `mingcute` | `mingcute:home-1-line`                     | MingCute UI icons                          |
| Mono Icons                   |                         `mi` | `mi:home`                                  | Mono icon set                              |
| Octicons                     |                    `octicon` | `octicon:home-24`                          | GitHub Octicons                            |
| OpenMoji                     |                   `openmoji` | `openmoji:grinning-face`                   | Open-source emoji set                      |
| Pixelarticons                |              `pixelarticons` | `pixelarticons:home`                       | Pixel-style UI icons                       |
| Radix Icons                  |                `radix-icons` | `radix-icons:home`                         | Radix UI icons                             |
| Sargam Icons                 |                         `si` | `si:home`                                  | Sargam UI icons                            |
| Solar                        |                      `solar` | `solar:home-linear`                        | Large Solar icon family                    |
| Streamline                   |                 `streamline` | `streamline:home-1`                        | Streamline icon family                     |
| TDesign Icons                |                    `tdesign` | `tdesign:home`                             | Tencent TDesign icons                      |
| Teenyicons                   |                 `teenyicons` | `teenyicons:home-outline`                  | Small minimal icons                        |
| Twemoji                      |                    `twemoji` | `twemoji:grinning-face`                    | Twitter emoji set                          |
| Unicons                      |                        `uil` | `uil:home`                                 | Iconscout Unicons line icons               |
| Weather Icons                |                         `wi` | `wi:day-sunny`                             | Weather condition icons                    |
| Material Design Iconic Font  |                       `zmdi` | `zmdi:home`                                | Material Design Iconic Font                |
| Zondicons                    |                  `zondicons` | `zondicons:home`                           | Steve Schoger’s Zondicons                  |

</details>

### <img src="https://api.iconify.design/lucide:search.svg?color=%2388C0D0" width="20" height="20" alt="Search"> Finding Icons

1. **Online Browser**: [icon-sets.iconify.design](https://icon-sets.iconify.design)
2. **CLI Command**: `iconify-link <prefix:name>`
3. **Local Search**: Browse the folder for each pack

---

<div align="center">

<img src="https://api.iconify.design/lucide:heart.svg?color=%2388C0D0" width="18" height="18" alt="Heart">

*224 icon packs ready for use*



</div>
