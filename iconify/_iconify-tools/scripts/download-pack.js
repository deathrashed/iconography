#!/usr/bin/env node
import { IconSet, exportToDirectory } from '@iconify/tools';
import fs from 'fs/promises';
import path from 'path';

async function main() {
    const args = process.argv.slice(2);
    if (args.length < 1) {
        console.log('Usage: iconify-pack <prefix> [target-dir]');
        process.exit(1);
    }

    const prefix = args[0];
    const targetDir = args[1] || `./icons-${prefix}`;

    console.log(`Fetching icon set "${prefix}"...`);
    
    const url = `https://raw.githubusercontent.com/iconify/icon-sets/master/json/${prefix}.json`;
    
    try {
        const response = await fetch(url);
        if (!response.ok) {
            throw new Error(`Failed to fetch icon set "${prefix}". Status: ${response.status}`);
        }
        
        const data = await response.json();
        const iconSet = new IconSet(data);
        
        console.log(`Loaded ${iconSet.count()} icons. Exporting to ${targetDir}...`);
        
        await exportToDirectory(iconSet, {
            target: targetDir,
            log: true
        });
        
        console.log(`\nSuccess! All SVGs exported to: ${path.resolve(targetDir)}`);
    } catch (err) {
        console.error('Error:', err.message);
        process.exit(1);
    }
}

main();
