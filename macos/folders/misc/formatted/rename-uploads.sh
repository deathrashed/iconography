#!/bin/zsh
setopt NULL_GLOB  # Don't error on no matches

# Icon Renamer - converts "Folder - Name (Variant).png" to "category-name-variant.png"
# Usage: ./rename-uploads.sh [directory] [execute]

DIR="${1:-.}"
EXECUTE="${2:-preview}"
cd "$DIR" || exit 1

get_category() {
    local name="$1"
    local first="${name%%-*}"
    
    # Specific multi-word matches first
    case "$name" in
        demolition-hammer*|power-trip*|cannibal-corpse*|bolt-thrower*|morbid-angel*|napalm-death*|from-beyond*|cause-of-death*|consuming-impulse*|tortured-existence*|nightmare-logic*|severed-survival*|cruel-bomb*) 
            echo "music"; return ;;
        color-wheel*|colorwheel*|color-spectrum*) 
            echo "media"; return ;;
        dev-code*|code-terminal*|code-gradient*) 
            echo "dev"; return ;;
        apple-tv*|keyboard-maestro*|nicotine-plus*|script-kit*|final-cut*) 
            echo "app"; return ;;
    esac
    
    # Check first word
    case "$first" in
        arc|brave|chrome|edge|firefox|opera|tor|vivaldi|safari) 
            echo "browser"; return ;;
        amaya|dahmer|death|massacre|obituary|pestilence|portal|stanger|doomsday|nwotm|rattlehead|leprosy) 
            echo "music"; return ;;
        mp3tag|vlc|obsidian|raycast|ghostty|cursor|vscode|xcode|finder|automator|transmission|swinsian|deemix|scriptkit|bandcamp|spotify|lastfm|github|musicbrainz|affinity|finalcut|downie|espanso|radicle|rsync|specstory|typinator|monitor|powershell) 
            echo "app"; return ;;
        git|code|python|js|ts|rust|go|ruby|swift|bash|shell|lua|npm|node|react|redis|postgres|mongodb|graphql|css|html|sass|jupyter|latex|applescript|dotfiles|express|console|userscript) 
            echo "dev"; return ;;
        appstore*|siri|settings|dmg|package|glow|formal|retro|real) 
            echo "apple"; return ;;
        monterey|sequoia|sonoma|ventura|catalina|mojave|sierra|yosemite|mavericks|wallpapers|cliffs) 
            echo "sys-wp"; return ;;
        documents|downloads|movies|pictures|profile|smart|symlink|brain|icon|resolver|search) 
            echo "sys"; return ;;
        pcloud|onedrive|syncthing|gdrive|dropbox|icloud) 
            echo "cloud"; return ;;
        media|images|videos|floppy|fender|lp|vinyl|record) 
            echo "media"; return ;;
        chatgpt|claude|gemini|copilot) 
            echo "ai"; return ;;
        linux*|windows|microsoft*) 
            echo "os"; return ;;
        db|icns|png|svg|jpg|pdf|zip) 
            echo "ext"; return ;;
        mario*|chippy|troll|meme|bup|star) 
            echo "fun"; return ;;
    esac
    
    # Fallback - no category (misc)
    echo ""
}

echo "=== Rename Preview ==="
echo ""

for file in Folder\ -\ *.png Folder\ -\ *.icns; do
    [[ -f "$file" ]] || continue
    
    # Strip "Folder - " prefix and extension
    name="${file#Folder - }"
    ext="${name##*.}"
    name="${name%.*}"
    
    # Convert to lowercase, spaces/parens to hyphens
    clean=$(echo "$name" | tr '[:upper:]' '[:lower:]' | sed 's/ (/-/g; s/)//g; s/ /-/g; s/--/-/g')
    
    # Get category
    category=$(get_category "$clean")
    
    # Build new name
    if [[ -n "$category" ]]; then
        newname="${category}-${clean}.${ext}"
    else
        newname="-${clean}.${ext}"
    fi
    
    # Fix double prefixes like media-media or dev-dev-code
    newname=$(echo "$newname" | sed 's/^dev-dev-code/dev-code/; s/^\([a-z-]*\)-\1\./\1./')
    
    echo "$file → $newname"
    
    if [[ "$EXECUTE" == "execute" ]]; then
        mv "$file" "$newname"
    fi
done

echo ""
if [[ "$EXECUTE" != "execute" ]]; then
    echo "--- Preview only. Run: $0 . execute"
else
    echo "Done!"
fi
