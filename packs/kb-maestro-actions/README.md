# Keyboard Maestro Action Icons

Curated action icons from the icon archive, organized for use in Keyboard Maestro macros.

## Structure

- **text/** - Text transformation and language icons
- **visibility/** - Show/hide and communication icons
- **files/** - File, folder, and development tool icons
- **system/** - Terminal, editor, and system action icons

## Included Icons

### Text Actions (`text/`) - 40 icons
- **Programming Languages**: JavaScript, TypeScript, Python, Go, Rust, Bash, HTML, CSS, JSON, YAML, XML, Markdown, Swift, Java, C++, C#, PHP, Ruby, Perl, Lua, Shell, Ada, AppleScript
- **Development Tools**: Code editors (Atom, Cursor, Visual Studio, PyCharm, Helix, Komodo, TexStudio), IDEs (IntelliJ IDEA, Unity, Delphi, Roblox Studio), Database tools (DBeaver)
- **Text Processing**: Code icons, bug icons, development icons, QR code, Git-related files
- Language-specific icons for text processing macros

### Visibility Actions (`visibility/`) - 24 icons
- **Communication Tools**: Slack, Discord, Telegram, Notion, Raindrop
- **Services**: Google Drive, Creative Cloud, GitHub, GitLab, Chrome, Amazon, Yahoo, PayPal, Mastercard, Apple, Linux, Windows, PlayStation
- **Social Media**: Various social platform icons
- Show/hide action icons and service-related icons

### File Actions (`files/`) - 70 icons
- **Development Tools**: Git, GitHub, GitLab, Docker, Kubernetes, Nginx, Cloudflare, DigitalOcean, Heroku, AWS, Azure
- **Code Platforms**: CodeSandbox, StackBlitz, Postman, Hoppscotch, CodePen
- **Note-Taking**: Obsidian, Ulysses, Markdown, Notion, Raindrop
- **Music Tools**: Spotify, Last.fm, MusicBrainz, Deezer, Apple Music
- **Browsers**: Chrome, Firefox, Safari, Edge, Brave, DuckDuckGo, Google, Opera, WhatsApp, LinkedIn, YouTube, Facebook, Tumblr, Amazon, Apple, Microsoft
- **Web Services**: Various web platform icons
- **Miscellaneous**: Action-related icons (cut, clipboard, globe, symbols, etc.)
- File management and development workflow icons

### System Actions (`system/`) - 51 icons
- **Terminal Emulators**: Terminal, Ghostty, Alacritty, Tabby, Warp
- **Text Editors**: Vim, Neovim, Emacs, VSCode, VSCodium, Sublime Text, Atom, Cursor, Helix Editor, Script Editor, various editor apps
- **Automation Tools**: Raycast, Flow Launcher
- **Note Apps**: Obsidian, Ulysses
- **Music Apps**: Spotify, Last.fm, MusicBrainz
- **macOS Apps**: Various macOS application icons (editors, tools, utilities)
- **Development Tools**: Git, GitHub, GitLab
- System and command execution icons

## Usage

1. Open Keyboard Maestro
2. Edit your macro
3. Click on the icon area
4. Choose "Choose File"
5. Navigate to this folder and select the appropriate PNG

## Adding More Icons

Icons are copied from multiple sources in the icon archive. To add more:

1. Find relevant icons in:
   - `library/png/` - Main library collection
   - `brands/macos-folders/` - macOS folder icons
   - `brands/png/` - Brand icons
   - `macos/apps/` - macOS application icons
   - `packs/plain/` - Various icon packs (programming, services, web, misc)
   - `packs/dev/` - Development tool icons
   - `packs/color/` - Colored icon packs
2. Copy to appropriate subfolder (text/, visibility/, files/, or system/)
3. Icons don't need to match exactly - they just need to visually represent the action
4. PNG format recommended (various sizes work)

## Recommended Sources

For action-specific icons, see `keyboard-maestro-actions-guide.md` for:
- SF Symbols (built into macOS) - Best for native look
- Lucide Icons - Clean, modern icons
- Heroicons - Comprehensive set
