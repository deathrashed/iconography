#!/usr/bin/env node
import { downloadGitRepo } from '@iconify/tools';

async function main() {
	const args = process.argv.slice(2);
	if (args.length < 2) {
		console.log('Usage: iconify-download <remote> <target> [branch]');
		process.exit(1);
	}

	const [remote, target, branch = 'master'] = args;

	console.log(`Downloading ${remote}#${branch} to ${target}...`);
	try {
		const result = await downloadGitRepo({
			remote,
			target,
			branch,
			log: true
		});
		console.log('Download complete:', result);
	} catch (err) {
		console.error('Download failed:', err);
		process.exit(1);
	}
}

main();
