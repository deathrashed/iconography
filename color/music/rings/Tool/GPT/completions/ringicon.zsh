#compdef ringicon

_ringicon() {
  local -a subcommands presets opts
  subcommands=(make batch)
  presets=(single-orange black-green-black black-yellow-red-black black-red-orange thick-black-outline thin-inner-ring custom-layered fymffyp 808)
  opts=(
    '--tui[open the production TUI]'
    '--help[show help]'
    '--list-presets[list built-in and saved presets]'
    '--out[output file or folder]:path:_files'
    '--output[output file or folder]:path:_files'
    '--size[output PNG size]:pixels:'
    '--padding[transparent padding outside outer ring]:pixels:'
    '--zoom[crop zoom]:zoom:'
    '--x[crop x offset]:pixels:'
    '--y[crop y offset]:pixels:'
    '--offset-x[crop x offset]:pixels:'
    '--offset-y[crop y offset]:pixels:'
    '--fill[fill circle by cropping source]'
    '--fit[fit whole source image inside circle]'
    '--rings[inner-to-outer rings color:width:gap:opacity]:rings:'
    '--ring[ring layer]:ring:'
    '--preset[ring preset]:preset:($presets)'
    '--separator[insert black separator rings]'
    '--overwrite[replace existing output]'
    '--skip-existing[skip existing output]'
    '--rename-existing[write output-2.png when destination exists]'
    '--dry-run[show planned work without writing]'
    '--json[print JSON summary]'
    '--recursive[batch folders recursively]'
    '--suffix[auto output filename suffix]:suffix:'
    '--url-file[text file with image URLs]:path:_files'
    '--clipboard-url[read URL from macOS clipboard]'
    '--config[render settings JSON]:path:_files'
  )

  _arguments \
    '1:command:(make batch)' \
    '2:input:_files' \
    '*::arg:->args' \
    $opts
}

_ringicon "$@"
