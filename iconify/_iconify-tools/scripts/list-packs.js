#!/usr/bin/env node

async function main() {
    console.log('Fetching all available icon packs from Iconify...');
    try {
        const response = await fetch('https://api.iconify.design/collections');
        if (!response.ok) throw new Error('Failed to fetch collections');
        
        const data = await response.json();
        const prefixes = Object.keys(data).sort();
        
        console.log('\nAvailable Icon Pack Prefixes:');
        console.log('========================================');
        
        // Print in columns
        const colWidth = 25;
        const numCols = 3;
        for (let i = 0; i < prefixes.length; i += numCols) {
            const row = prefixes.slice(i, i + numCols)
                .map(p => p.padEnd(colWidth))
                .join('');
            console.log(row);
        }
        
        console.log('========================================');
        console.log(`Total: ${prefixes.length} icon packs.`);
        console.log('\nUse "iconify-pack <prefix>" to download any of these.');
    } catch (err) {
        console.error('Error:', err.message);
    }
}

main();
