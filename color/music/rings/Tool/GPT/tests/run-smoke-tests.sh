#!/usr/bin/env bash
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
OUT="$ROOT/tests/output"
FIXTURES="$ROOT/tests/fixtures"

rm -rf "$OUT"
mkdir -p "$OUT/batch" "$OUT/url"

run_ok() {
  echo "+ $*"
  "$@"
}

run_fail() {
  echo "+ expect-fail: $*"
  if "$@"; then
    echo "expected command to fail, but it succeeded" >&2
    exit 1
  fi
}

run_ok dotnet build "$ROOT/src/RingIcon/RingIcon.csproj" -c Release

run_ok "$ROOT/ringicon" make "$FIXTURES/square-png.png" --preset single-orange --out "$OUT/square-png.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/square-jpg.jpg" --preset black-green-black --out "$OUT/square-jpg.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/rectangular-wide.jpg" --rings "black:8,green:24,black:8" --zoom 1.25 --x -40 --y 20 --out "$OUT/rectangular-cropped.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/small-64.png" --rings "orange:32" --size 256 --padding 16 --out "$OUT/small-64.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/large-1800.jpg" --preset black-yellow-red-black --size 1200 --out "$OUT/large-1800.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/unusual filename [spaces] & symbols.jpg" --rings "grey:8,#ffffff:12,gray:8" --out "$OUT/unusual filename [spaces] & symbols.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/square-jpg.jpg" --rings "#111111:10,#f7931e:32:4:0.95" --out "$OUT/hex-gap-opacity.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/square-jpg.jpg" --preset black-red-orange --fit --out "$OUT/fit-mode.png" --overwrite
run_ok "$ROOT/ringicon" make "$FIXTURES/square-jpg.jpg" --preset single-orange --out "$OUT/json-output.png" --overwrite --json
run_ok "$ROOT/ringicon" make "$FIXTURES/square-jpg.jpg" --preset single-orange --out "$OUT/dry-run.png" --dry-run

run_ok "$ROOT/ringicon" make https://httpbin.org/image/png --preset single-orange --out "$OUT/url/httpbin.png" --overwrite

printf '%s\n' "https://httpbin.org/image/jpeg" > "$OUT/urls.txt"
run_ok "$ROOT/ringicon" make --url-file "$OUT/urls.txt" --preset black-green-black --out "$OUT/url" --overwrite

run_ok "$ROOT/ringicon" batch "$FIXTURES" --preset black-red-orange --out "$OUT/batch" --rename-existing || true
test -f "$OUT/batch/square-png-ring.png"
test -f "$OUT/batch/square-jpg-ring.png"

run_ok "$ROOT/ringicon" make "$FIXTURES/square-png.png" --preset single-orange --out "$OUT/existing.png" --overwrite
run_fail "$ROOT/ringicon" make "$FIXTURES/square-png.png" --preset single-orange --out "$OUT/existing.png"
run_ok "$ROOT/ringicon" make "$FIXTURES/square-png.png" --preset single-orange --out "$OUT/existing.png" --skip-existing
run_ok "$ROOT/ringicon" make "$FIXTURES/square-png.png" --preset single-orange --out "$OUT/existing.png" --rename-existing
test -f "$OUT/existing-2.png"

run_fail "$ROOT/ringicon" make "$FIXTURES/does-not-exist.jpg" --preset single-orange --out "$OUT/missing.png"
run_fail "$ROOT/ringicon" make "$FIXTURES/invalid-image.png" --preset single-orange --out "$OUT/invalid.png" --overwrite
run_fail "$ROOT/ringicon" make https://example.invalid/not-an-image.jpg --preset single-orange --out "$OUT/bad-url.png" --overwrite

file "$OUT"/*.png "$OUT/url"/*.png "$OUT/batch"/*.png | sort
echo
echo "Smoke tests complete."
