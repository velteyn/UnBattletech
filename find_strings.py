
import sys

def find_string_offset(filename, search_strings):
    try:
        with open(filename, 'rb') as f:
            data = f.read()
            
        found_offsets = {}
            
        for s in search_strings:
            # Encode as ASCII (or latin-1)
            b_s = s.encode('latin-1')
            offset = data.find(b_s)
            if offset != -1:
                print(f"Found '{s}' at linear offset: 0x{offset:X}")
                found_offsets[s] = offset
                
                # Hex dump around
                start = max(0, offset - 16)
                end = min(len(data), offset + len(b_s) + 16)
                print(f"Hex dump around '{s}':")
                print(data[start:end].hex())
                print("---")
            else:
                print(f"'{s}' not found.")
                # Try case insensitive
                offset = data.lower().find(s.lower().encode('latin-1'))
                if offset != -1:
                     print(f"Found '{s}' (case-insensitive) at linear offset: 0x{offset:X}")
                     found_offsets[s] = offset
        
        # Search for references to 0x3a42 (Katrina?)
        needle = b'\xB8\x42\x3A' # MOV AX, 3a42
        print(f"Searching for {needle.hex()} (MOV AX, 3a42)...")
        offset = data.find(needle)
        while offset != -1:
            if 0x10000 <= offset <= 0x20000:
                print(f"Found MOV AX, 3a42 at Code Linear 0x{offset:X} (1000:{offset-0x10000:04X})")
            offset = data.find(needle, offset + 1)
            
        # Search for Training Center references
        # If Training Center is at 0x28321.
        # Check for immediate values that might point to it.
        # e.g. if DS=0x2000 -> 0x8321.
        needle = b'\xB8\x21\x83' # MOV AX, 8321
        print(f"Searching for {needle.hex()} (MOV AX, 8321)...")
        offset = data.find(needle)
        while offset != -1:
            if 0x10000 <= offset <= 0x20000:
                print(f"Found MOV AX, 8321 at Code Linear 0x{offset:X} (1000:{offset-0x10000:04X})")
            offset = data.find(needle, offset + 1)

    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    find_string_offset("c:/Reversing/AIATTEMPT/spice86/spice86dumpMemoryDump.bin", ["Training Center", "Katrina", "Cadet", "Story"])
