#!/bin/bash

# Organize SF Symbols into category folders
# This script categorizes symbols based on their naming patterns

organize_directory() {
    local SOURCE_DIR="$1"
    
    if [ ! -d "$SOURCE_DIR" ]; then
        echo "❌ Directory not found: $SOURCE_DIR"
        return 1
    fi
    
    echo "📁 Organizing symbols in: $SOURCE_DIR"
    echo ""
    
    # Create category directories
    mkdir -p "$SOURCE_DIR/numbers"
    mkdir -p "$SOURCE_DIR/arrows"
    mkdir -p "$SOURCE_DIR/shapes"
    mkdir -p "$SOURCE_DIR/media"
    mkdir -p "$SOURCE_DIR/communication"
    mkdir -p "$SOURCE_DIR/files-folders"
    mkdir -p "$SOURCE_DIR/weather"
    mkdir -p "$SOURCE_DIR/currency"
    mkdir -p "$SOURCE_DIR/text-typography"
    mkdir -p "$SOURCE_DIR/system"
    mkdir -p "$SOURCE_DIR/people"
    mkdir -p "$SOURCE_DIR/navigation"
    mkdir -p "$SOURCE_DIR/symbols-math"
    mkdir -p "$SOURCE_DIR/devices"
    mkdir -p "$SOURCE_DIR/nature"
    mkdir -p "$SOURCE_DIR/sports"
    mkdir -p "$SOURCE_DIR/transportation"
    mkdir -p "$SOURCE_DIR/time"
    mkdir -p "$SOURCE_DIR/shopping"
    mkdir -p "$SOURCE_DIR/health"
    mkdir -p "$SOURCE_DIR/security"
    mkdir -p "$SOURCE_DIR/other"
    
    cd "$SOURCE_DIR" || return 1
    
    # Count totals
    local total=0
    local moved=0
    
    # Move files based on patterns
    for file in *.png; do
        [ -f "$file" ] || continue
        ((total++))
        
        # Numbers (0-50, 00-50 with circle/square variants)
        if [[ "$file" =~ ^[0-9]+\. ]]; then
            mv "$file" numbers/ 2>/dev/null && ((moved++))
        
        # Arrows
        elif [[ "$file" =~ ^arrow\. ]] || [[ "$file" =~ ^arrowshape\. ]] || [[ "$file" =~ ^arrowtriangle\. ]]; then
            mv "$file" arrows/ 2>/dev/null && ((moved++))
        
        # Shapes
        elif [[ "$file" =~ ^(circle|square|triangle|diamond|hexagon|pentagon|octagon|seal|rectangle|capsule)\. ]]; then
            mv "$file" shapes/ 2>/dev/null && ((moved++))
        
        # Media & Playback
        elif [[ "$file" =~ ^(play|pause|stop|forward|backward|music|video|film|camera|mic|speaker|headphones|tv|radio|photo|livephoto|slowmo|timelapse|burst|playpause|eject|airplay|repeat|shuffle|volume|waveform|metronome|guitars|recordingtape)\. ]]; then
            mv "$file" media/ 2>/dev/null && ((moved++))
        
        # Communication
        elif [[ "$file" =~ ^(phone|message|envelope|mail|bubble|ellipsis|quote|chat|facetime|text\.bubble|captions)\. ]]; then
            mv "$file" communication/ 2>/dev/null && ((moved++))
        
        # Files & Folders
        elif [[ "$file" =~ ^(folder|doc|archivebox|tray|bin|paperclip|link|clipboard|scissors|bookmark)\. ]]; then
            mv "$file" files-folders/ 2>/dev/null && ((moved++))
        
        # Weather
        elif [[ "$file" =~ ^(cloud|sun|moon|snow|wind|rain|bolt|hurricane|tornado|tropicalstorm|thermometer|sunset|sunrise|haze|smoke|fog|dust|sleet|hail|drizzle)\. ]]; then
            mv "$file" weather/ 2>/dev/null && ((moved++))
        
        # Currency
        elif [[ "$file" =~ sign\.(circle|square) ]] && [[ "$file" =~ (dollar|euro|pound|yen|won|ruble|peso|franc|rupee|lira|sheqel|baht|cruzeiro|florin|guarani|hryvnia|kip|lari|manat|naira|austral|bitcoin|cedi|colon|dong|indian|millesign|pesetasign|sterling|tengesign|tugriksign|turkishlira)\. ]]; then
            mv "$file" currency/ 2>/dev/null && ((moved++))
        
        # Text & Typography
        elif [[ "$file" =~ ^(textformat|bold|italic|underline|strikethrough|paragraph|textbox|character|signature|scribble|pencil|lasso|highlighter|paintbrush|eyedropper)\. ]]; then
            mv "$file" text-typography/ 2>/dev/null && ((moved++))
        
        # System & Settings
        elif [[ "$file" =~ ^(gear|slider|switch|gauge|speedometer|power|restart|sleep|wake|cpu|memory|internaldrive|externaldrive|opticaldrive|wifi|antenna|personalhotspot|network|servers|lock|unlock|key|shield|faceid|touchid|keyboard|command|option|control|shift|delete|escape|eject|capslock)\. ]]; then
            mv "$file" system/ 2>/dev/null && ((moved++))
        
        # People & Users
        elif [[ "$file" =~ ^(person|people|figure)\. ]]; then
            mv "$file" people/ 2>/dev/null && ((moved++))
        
        # Navigation & Location
        elif [[ "$file" =~ ^(chevron|location|mappin|map|compass|safari|globe|bookmark|sidebar|arrow\.turn|goforward|gobackward|viewfinder|scope)\. ]]; then
            mv "$file" navigation/ 2>/dev/null && ((moved++))
        
        # Math & Symbols
        elif [[ "$file" =~ ^(plus|minus|multiply|divide|equal|percent|number|sum|function|fx|infinity|greaterthan|lessthan|plusminus|xmark|checkmark|exclamationmark|questionmark|at|hashtag|ampersand|asterisk)\. ]]; then
            mv "$file" symbols-math/ 2>/dev/null && ((moved++))
        
        # Devices
        elif [[ "$file" =~ ^(iphone|ipad|applewatch|appletv|homepod|macbook|imac|mac|airpods|phone|tablet|laptop|desktopcomputer|display|printer|scanner|projector|hifispeaker|tv|gamecontroller|joystick|cpu|gpu)\. ]]; then
            mv "$file" devices/ 2>/dev/null && ((moved++))
        
        # Nature & Animals
        elif [[ "$file" =~ ^(leaf|flame|drop|water|snowflake|sparkles|star|moon\.stars|hare|tortoise|ant)\. ]]; then
            mv "$file" nature/ 2>/dev/null && ((moved++))
        
        # Sports & Recreation
        elif [[ "$file" =~ ^(sportscourt|flag|trophy|medal|sportscore|figure\.(walk|run|swim))\. ]]; then
            mv "$file" sports/ 2>/dev/null && ((moved++))
        
        # Transportation
        elif [[ "$file" =~ ^(car|bus|tram|train|airplane|ferry|bicycle|scooter|parkingsign|fuelpump)\. ]]; then
            mv "$file" transportation/ 2>/dev/null && ((moved++))
        
        # Time & Calendar
        elif [[ "$file" =~ ^(clock|timer|stopwatch|hourglass|calendar|alarm|bell)\. ]]; then
            mv "$file" time/ 2>/dev/null && ((moved++))
        
        # Shopping & Commerce
        elif [[ "$file" =~ ^(cart|bag|creditcard|giftcard|purchased|tag|barcode|qrcode|ticket)\. ]]; then
            mv "$file" shopping/ 2>/dev/null && ((moved++))
        
        # Health & Medical
        elif [[ "$file" =~ ^(heart|lungs|bandage|cross|medical|pill|syringe|stethoscope|thermometer|bed|staroflife|allergens)\. ]]; then
            mv "$file" health/ 2>/dev/null && ((moved++))
        
        # Security & Privacy
        elif [[ "$file" =~ ^(lock|unlock|key|shield|eye|nosign|hand\.(raised|thumbsup|thumbsdown))\. ]]; then
            mv "$file" security/ 2>/dev/null && ((moved++))
        
        # Everything else
        else
            mv "$file" other/ 2>/dev/null && ((moved++))
        fi
    done
    
    echo "✅ Organized $moved of $total files"
    echo ""
    
    # Show category counts
    echo "📊 Category breakdown:"
    for dir in */; do
        count=$(find "$dir" -maxdepth 1 -type f -name "*.png" | wc -l | tr -d ' ')
        if [ "$count" -gt 0 ]; then
            printf "   %-20s %4d files\n" "${dir%/}" "$count"
        fi
    done
}

# Main execution
SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"

echo "🎨 SF Symbols Organizer"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo ""

# Organize light mode symbols
echo "☀️  Organizing Light Mode Symbols..."
organize_directory "$SCRIPT_DIR/sf-symbols-light"

echo ""
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo ""

# Organize dark mode symbols
echo "🌙 Organizing Dark Mode Symbols..."
organize_directory "$SCRIPT_DIR/sf-symbols-dark"

echo ""
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo "✨ Organization complete!"

