#!/usr/bin/env node
import fs from 'fs/promises';

async function main() {
    const args = process.argv.slice(2);
    if (args.length < 2) {
        console.log('Usage: iconify-add <icon-name> <file-path> [mode]');
        console.log('Modes: md (markdown), html, svg');
        process.exit(1);
    }

    const [icon, filePath, mode = 'md'] = args;

    // Icon name is like "mdi:home"
    const parts = icon.split(':');
    if (parts.length !== 2) {
        console.error('Invalid icon name. Format should be prefix:name (e.g., mdi:home)');
        process.exit(1);
    }
    const [prefix, name] = parts;
    
    let content = '';
    if (mode === 'md') {
        content = `![${icon}](https://api.iconify.design/${prefix}/${name}.svg)`;
    } else if (mode === 'html') {
        content = `<img src="https://api.iconify.design/${prefix}/${name}.svg" alt="${icon}" width="24" height="24" />`;
    } else if (mode === 'svg') {
        try {
            const url = `https://api.iconify.design/${prefix}/${name}.svg`;
            const response = await fetch(url);
            if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
            content = await response.text();
        } catch (err) {
            console.error('Failed to fetch SVG:', err);
            process.exit(1);
        }
    }

    try {
        await fs.appendFile(filePath, `\n${content}\n`);
        console.log(`Added icon ${icon} to ${filePath} (mode: ${mode})`);
    } catch (err) {
        console.error('Failed to write to file:', err);
        process.exit(1);
    }
}

main();
