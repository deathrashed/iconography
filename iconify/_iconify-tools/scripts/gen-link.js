#!/usr/bin/env node

async function main() {
    const args = process.argv.slice(2);
    if (args.length < 1) {
        console.log('Usage: iconify-link <icon-name>');
        console.log('Example: iconify-link mdi:home');
        process.exit(1);
    }

    const icon = args[0];
    const parts = icon.split(':');
    if (parts.length !== 2) {
        console.error('Invalid icon name. Format: prefix:name (e.g., mdi:home)');
        process.exit(1);
    }
    const [prefix, name] = parts;
    const url = `https://api.iconify.design/${prefix}/${name}.svg`;

    console.log(`\nIcon: ${icon}`);
    console.log(`----------------------------------------`);
    console.log(`Markdown:\n![${icon}](${url})`);
    console.log(`----------------------------------------`);
    console.log(`HTML:\n<img src="${url}" alt="${icon}" width="24" height="24" />`);
    console.log(`----------------------------------------`);
    console.log(`SVG URL:\n${url}`);
    console.log(`----------------------------------------\n`);
}

main();
