#!/bin/bash

# Icon Renaming Script v2
# Numbered prefix convention (category word dropped, number IS the category):
#
# 00- ← misc/catchall
# 01- ← ai
# 02- ← apps
# 03- ← apple/appstore
# 04- ← browsers
# 05- ← cloud
# 06- ← dev
# 07- ← extensions
# 08- ← files
# 09- ← fun
# 10- ← media
# 11- ← music
# 12- ← os (linux + microsoft)
# 13- ← sys (includes wallpapers)

cd "/Volumes/Apfspace/Icons/macos/folders/misc/icns"

# Dry run by default - change to 'mv' to actually rename
CMD="mv"  # Change to CMD="mv" to execute

echo "=== DRY RUN - Preview of renames ==="
echo ""

for file in *.icns; do
    newname=""
    
    case "$file" in
        # AI - strip ai-
        ai-*)
            newname="01-${file#ai-}"
            ;;
        # Apps - strip app-
        app-*)
            newname="02-${file#app-}"
            ;;
        # Apple - strip apple-
        apple-*)
            newname="03-${file#apple-}"
            ;;
        # Appstore - keep appstore for clarity
        appstore-*)
            newname="03-${file}"
            ;;
        # Browsers - strip browser-
        browser-*)
            newname="04-${file#browser-}"
            ;;
        # Cloud - strip cloud-
        cloud-*)
            newname="05-${file#cloud-}"
            ;;
        # Dev - strip dev-
        dev-*)
            newname="06-${file#dev-}"
            ;;
        devv.icns)
            newname="06-v.icns"
            ;;
        # Extensions - strip ext-
        ext-*)
            newname="07-${file#ext-}"
            ;;
        # Files - strip file-
        file-*)
            newname="08-${file#file-}"
            ;;
        # Fun - strip fun-
        fun-*)
            newname="09-${file#fun-}"
            ;;
        # z- goes to fun, strip z-
        z-*)
            newname="09-${file#z-}"
            ;;
        # Media - strip media-
        media-*)
            newname="10-${file#media-}"
            ;;
        # Music - strip music-
        music-*)
            newname="11-${file#music-}"
            ;;
        # OS - linux keeps linux, microsoft keeps microsoft
        linux-*)
            newname="12-${file}"
            ;;
        microsoft-*)
            newname="12-${file}"
            ;;
        # Sys - strip sys-
        sys-*)
            newname="13-${file#sys-}"
            ;;
        # wp- keeps wp for clarity (wallpapers)
        wp-*)
            newname="13-${file}"
            ;;
        # Misc → 00- (strip misc-)
        misc-*)
            newname="00-${file#misc-}"
            ;;
        # Outliers → 00-
        pink-*)
            newname="00-${file}"
            ;;
        redd.icns)
            newname="00-redd.icns"
            ;;
        *)
            continue
            ;;
    esac
    
    if [ -n "$newname" ] && [ "$file" != "$newname" ]; then
        echo "$file → $newname"
        $CMD "$file" "$newname"
    fi
done

echo ""
echo "=== To execute, edit script and change CMD=\"echo\" to CMD=\"mv\" ==="
