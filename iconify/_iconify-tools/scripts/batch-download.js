#!/usr/bin/env node
import { IconSet, exportToDirectory } from '@iconify/tools';
import fs from 'fs/promises';
import path from 'path';

async function downloadPack(prefix, targetDir) {
    const url = `https://raw.githubusercontent.com/iconify/icon-sets/master/json/${prefix}.json`;
    try {
        const response = await fetch(url);
        if (!response.ok) return false;
        const data = await response.json();
        const iconSet = new IconSet(data);
        await exportToDirectory(iconSet, {
            target: targetDir,
            log: false
        });
        return true;
    } catch (err) {
        return false;
    }
}

async function main() {
    const baseDir = '/Volumes/Apfspace/Icons/iconify';
    
    console.log('Fetching collection list...');
    const response = await fetch('https://api.iconify.design/collections');
    const collections = await response.json();
    const prefixes = Object.keys(collections).sort();

    console.log(`Found ${prefixes.length} packs. Starting batch download to ${baseDir}...`);

    for (const prefix of prefixes) {
        // Skip mdi and ph as requested
        if (prefix === 'mdi' || prefix === 'ph') {
            console.log(`[-] Skipping ${prefix} (already exists)`);
            continue;
        }

        const targetDir = path.join(baseDir, `${prefix}-icons`);
        
        // Check if directory already exists to avoid re-downloading
        try {
            await fs.access(targetDir);
            console.log(`[-] Skipping ${prefix} (folder exists)`);
            continue;
        } catch (e) {
            // Folder doesn't exist, proceed
        }

        process.stdout.write(`[+] Downloading ${prefix}... `);
        const success = await downloadPack(prefix, targetDir);
        if (success) {
            process.stdout.write('Done.\n');
        } else {
            process.stdout.write('Failed.\n');
        }
    }

    console.log('\nBatch download complete!');
}

main();
