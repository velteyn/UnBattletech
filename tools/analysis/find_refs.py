
import sys
import os

repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

def find_references(filename):
    try:
        with open(filename, 'rb') as f:
            data = f.read()
            
        # Define Code Segment Range (Linear)
        cs_start = 0x10000
        cs_end = 0x20000
        code_data = data[cs_start:cs_end]
        
        def search_val(val, name, segment_assumed):
            val_bytes = val.to_bytes(2, byteorder='little')
            offset = code_data.find(val_bytes)
            found = False
            while offset != -1:
                ref_addr = cs_start + offset
                prefix = code_data[offset-1] if offset > 0 else 0
                print(f"Found reference to {name} (Offset 0x{val:04X}) at 1000:{ref_addr-0x10000:04X} (Opcode: {prefix:02X})")
                offset = code_data.find(val_bytes, offset + 1)
                found = True
            if not found:
                print(f"No references found for {name} (Offset 0x{val:04X})")

        print("Searching for Shop references (Assuming DS=2000)...")
        
        # Strings in Segment 2000
        search_val(0xA31F, "C-bills: ", 0x2000)
        search_val(0xA2C9, "Focus attention to:", 0x2000)
        search_val(0xA0CA, "A mountain of flesh...", 0x2000)
        search_val(0x8351, "Weapons Shop (List)", 0x2000)
        search_val(0x8321, "Training Center (List Start)", 0x2000)
        
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    find_references(os.path.join(repo_root, "spice86", "spice86dumpMemoryDump.bin"))
