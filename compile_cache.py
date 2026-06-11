#!/usr/bin/env python3
import os
import sqlite3
import sys

DB_NAME = "IconCache.sqlite"
TARGET_FORMATS = {
    '.png': 0,
    '.svg': 1,
    '.icns': 2
}

def compile_icon_vault(vault_path):
    if not os.path.isdir(vault_path):
        print(f"Error: Invalid directory target path -> {vault_path}")
        sys.exit(1)
        
    db_path = os.path.join(vault_path, DB_NAME)
    print(f"[*] Initializing clean production cache layer at: {db_path}")
    
    # Remove older operational allocations if existing to prevent fragmentation bloat
    if os.path.exists(db_path):
        os.remove(db_path)
        
    conn = sqlite3.connect(db_path)
    cursor = conn.cursor()
    
    # Performance overrides for massive injection operations
    cursor.execute("PRAGMA journal_mode = OFF;")
    cursor.execute("PRAGMA synchronous = OFF;")
    cursor.execute("PRAGMA cache_size = -100000;") # Allocate ~100MB memory buffer
    
    # Build schema matches exactly what the Swift wrapper expects
    cursor.execute("""
    CREATE TABLE IF NOT EXISTS icons (
        id TEXT PRIMARY KEY,
        format INTEGER,
        payload BLOB
    );
    """)
    
    insert_buffer = []
    buffer_limit = 5000
    total_indexed = 0
    
    print("[*] Traversing local directory blocks... Parsing files...")
    
    for root, _, files in os.walk(vault_path):
        # Ignore operational and configuration path indicators
        if ".git" in root or ".agents" in root or ".antigravitycli" in root:
            continue
            
        for file in files:
            name, ext = os.path.splitext(file)
            ext_lower = ext.lower()
            
            if ext_lower in TARGET_FORMATS:
                full_path = os.path.join(root, file)
                
                # Derive unique primary identifier string using structured relative tracking paths
                # e.g., "packs/lucide/wrench" instead of absolute paths
                relative_path = os.path.relpath(full_path, vault_path)
                icon_id, _ = os.path.splitext(relative_path)
                
                try:
                    with open(full_path, 'rb') as f:
                        binary_payload = f.read()
                        
                    format_enum = TARGET_FORMATS[ext_lower]
                    insert_buffer.append((icon_id, format_enum, binary_payload))
                    total_indexed += 1
                    
                    if len(insert_buffer) >= buffer_limit:
                        cursor.executemany("INSERT OR REPLACE INTO icons (id, format, payload) VALUES (?, ?, ?);", insert_buffer)
                        conn.commit()
                        print(f"    -> Compiled {total_indexed} assets...")
                        insert_buffer = []
                        
                except Exception as e:
                    print(f"[!] Warning: Failed to parse asset reference {full_path}: {e}")
                    
    # Clean structural residual elements left inside memory arrays
    if insert_buffer:
        cursor.executemany("INSERT OR REPLACE INTO icons (id, format, payload) VALUES (?, ?, ?);", insert_buffer)
        conn.commit()
        
    print("[*] Injection complete. Generating database indices and optimizing...")
    cursor.execute("VACUUM;")
    conn.close()
    print(f"[+] Operational compilation finalized. Total elements packed: {total_indexed}")

if __name__ == "__main__":
    target = os.getcwd()
    compile_icon_vault(target)
