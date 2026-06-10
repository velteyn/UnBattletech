
import sys
import os

repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

def dump_location_strings(filename):
    if not os.path.exists(filename):
        print(f"File not found: {filename}")
        return

    try:
        with open(filename, 'rb') as f:
            data = f.read()
            
        start_offset = 0x28321
        length = 200 
        
        raw_bytes = data[start_offset:start_offset+length]
        strings = raw_bytes.split(b'\x00')
        
        print("Extracted Strings:")
        for s in strings:
            if len(s) > 1:
                print(s.decode('latin-1'))
                    
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    dump_location_strings(os.path.join(repo_root, "spice86", "spice86dumpMemoryDump.bin"))
