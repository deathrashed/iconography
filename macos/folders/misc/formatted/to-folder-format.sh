#!/bin/zsh
setopt NULL_GLOB

# Converts prefixed names → Folder - Name (Variant).icns
# Usage: ./to-folder-format.sh [directory] [execute]

DIR="${1:-.}"
EXECUTE="${2:-preview}"
cd "$DIR" || exit 1

titlecase() {
    echo "$1" | sed 's/-/ /g' | awk '{for(i=1;i<=NF;i++) $i=toupper(substr($i,1,1)) tolower(substr($i,2))}1'
}

fixcase() {
    echo "$1" | sed \
        -e 's/Cannibalcorpse/Cannibal Corpse/g' \
        -e 's/Amylandthesniffers/Amyl and the Sniffers/g' \
        -e 's/Demolitionhammer/Demolition Hammer/g' \
        -e 's/Powertrip/Power Trip/g' \
        -e 's/Severedsurvival/Severed Survival/g' \
        -e 's/Causeofdeath/Cause of Death/g' \
        -e 's/Frombeyond/From Beyond/g' \
        -e 's/Deathmetal/Death Metal/g' \
        -e 's/Thrashmetal/Thrash Metal/g' \
        -e 's/Inutero/In Utero/g' \
        -e 's/Cruelbomb/Cruel Bomb/g' \
        -e 's/Operatingsystems/Operating Systems/g' \
        -e 's/Nwotm/NWOTM/g' \
        -e 's/Chatgpt/ChatGPT/g' \
        -e 's/Github/GitHub/g' \
        -e 's/Vlc/VLC/g' \
        -e 's/Vscode/VS Code/g' \
        -e 's/Gnupg/GnuPG/g' \
        -e 's/Lastfm/Last.fm/g' \
        -e 's/Pcloud/pCloud/g' \
        -e 's/Onedrive/OneDrive/g' \
        -e 's/Gdrive/Google Drive/g' \
        -e 's/Icloud/iCloud/g' \
        -e 's/Finalcutpro/Final Cut Pro/g' \
        -e 's/Finalcut/Final Cut/g' \
        -e 's/Mongodb/MongoDB/g' \
        -e 's/Graphql/GraphQL/g' \
        -e 's/Applescript/AppleScript/g' \
        -e 's/Musicbrainz/MusicBrainz/g' \
        -e 's/Scriptkit/Script Kit/g' \
        -e 's/Appstore/App Store/g' \
        -e 's/Dod/DoD/g' \
        -e 's/Kfc/KFC/g' \
        -e 's/Ssh/SSH/g' \
        -e 's/Defcon/DEFCON/g' \
        -e 's/Dmg/DMG/g' \
        -e 's/Rsync/rsync/g' \
        -e 's/ Tv/ TV/g' \
        -e 's/^Tv /TV /g'
}

echo "=== Rename Preview ==="
echo ""

for file in *.icns; do
    [[ -f "$file" ]] || continue
    [[ "$file" == "Icon" ]] && continue
    
    name="${file%.icns}"
    
    # Strip category prefix
    case "$name" in
        -*)           core="${name#-}" ;;
        ai-*)         core="${name#ai-}" ;;
        app-*)        core="${name#app-}" ;;
        apple-*)      core="${name#apple-}" ;;
        browser-*)    core="${name#browser-}" ;;
        cloud-*)      core="${name#cloud-}" ;;
        dev-*)        core="${name#dev-}" ;;
        ext-*)        core="${name#ext-}" ;;
        file-*)       core="${name#file-}" ;;
        fun-*)        core="${name#fun-}" ;;
        media-*)      core="${name#media-}" ;;
        music-*)      core="${name#music-}" ;;
        os-linux-*)   core="${name#os-linux-}"; core="Linux $core" ;;
        os-microsoft-*) core="${name#os-microsoft-}"; core="Microsoft $core" ;;
        os-*)         core="${name#os-}" ;;
        sys-wp-*)     core="${name#sys-wp-}" ;;
        sys-*)        core="${name#sys-}" ;;
        *)            core="$name" ;;
    esac
    
    # Detect variant pattern: name-variant where variant is a known suffix
    variant=""
    base="$core"
    
    # Check for color/style variants at the end
    case "$core" in
        *-alt)       variant="Alt"; base="${core%-alt}" ;;
        *-fill)      variant="Fill"; base="${core%-fill}" ;;
        *-dark)      variant="Dark"; base="${core%-dark}" ;;
        *-light)     variant="Light"; base="${core%-light}" ;;
        *-gradient)  variant="Gradient"; base="${core%-gradient}" ;;
        *-fade)      variant="Fade"; base="${core%-fade}" ;;
        *-black)     variant="Black"; base="${core%-black}" ;;
        *-white)     variant="White"; base="${core%-white}" ;;
        *-orange)    variant="Orange"; base="${core%-orange}" ;;
        *-blue)      variant="Blue"; base="${core%-blue}" ;;
        *-green)     variant="Green"; base="${core%-green}" ;;
        *-pink)      variant="Pink"; base="${core%-pink}" ;;
        *-yellow)    variant="Yellow"; base="${core%-yellow}" ;;
        *-purple)    variant="Purple"; base="${core%-purple}" ;;
        *-red)       variant="Red"; base="${core%-red}" ;;
        *-honey)     variant="Honey"; base="${core%-honey}" ;;
        *-mint)      variant="Mint"; base="${core%-mint}" ;;
        *-full-blue) variant="Full Blue"; base="${core%-full-blue}" ;;
        *-full-orange) variant="Full Orange"; base="${core%-full-orange}" ;;
        # Music album variants
        *-leprosy)   variant="Leprosy"; base="${core%-leprosy}" ;;
        *-logo)      variant="Logo"; base="${core%-logo}" ;;
        *-cause-of-death) variant="Cause of Death"; base="${core%-cause-of-death}" ;;
        *-consuming-impulse) variant="Consuming Impulse"; base="${core%-consuming-impulse}" ;;
        *-tortured-existence) variant="Tortured Existence"; base="${core%-tortured-existence}" ;;
        *-from-beyond) variant="From Beyond"; base="${core%-from-beyond}" ;;
        *-nightmare-logic) variant="Nightmare Logic"; base="${core%-nightmare-logic}" ;;
        *-severed-survival) variant="Severed Survival"; base="${core%-severed-survival}" ;;
        *-eaten-back-to-life) variant="Eaten Back to Life"; base="${core%-eaten-back-to-life}" ;;
        *-in-utero)  variant="In Utero"; base="${core%-in-utero}" ;;
    esac
    
    # Title case and fix
    pretty=$(titlecase "$base")
    pretty=$(fixcase "$pretty")
    
    # Build new name
    if [[ -n "$variant" ]]; then
        newname="Folder - ${pretty} (${variant}).icns"
    else
        newname="Folder - ${pretty}.icns"
    fi
    
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
