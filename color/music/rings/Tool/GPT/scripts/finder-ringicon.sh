#!/usr/bin/env bash
set -euo pipefail

# Use this from an Automator Quick Action / Shortcuts action that passes Finder
# items as arguments. Each selected image is written beside the original.

TOOL="/Volumes/Apfspace/Icons/color/music/rings/Tool/GPT/ringicon"

if [[ $# -eq 0 ]]; then
  osascript -e 'display alert "RingIcon" message "No Finder items were passed to the RingIcon helper."'
  exit 1
fi

for item in "$@"; do
  if [[ -f "$item" ]]; then
    dir="$(dirname "$item")"
    stem="$(basename "$item")"
    stem="${stem%.*}"
    "$TOOL" "$item" "$dir/$stem-ring.png" --preset fymffyp --skip-existing
  fi
done

osascript -e 'display notification "RingIcon finished processing selected images." with title "RingIcon"'
