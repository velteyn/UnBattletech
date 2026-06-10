
import sys
import os

repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

def analyze_strings_and_refs(filename):
    try:
        with open(filename, 'rb') as f:
            data = f.read()
            
        def hex_dump(start, length, label):
            print(f"--- {label} (Linear 0x{start:X}) ---")
            if start < 0 or start + length > len(data):
                print("Address out of bounds")
                return
            slice_data = data[start:start+length]
            print(slice_data)
            print("Hex:", slice_data.hex())
            print("---")

        # 1. Inspect "Katrina" area
        # Python found "Katrina" at 0x3A74D.
        # Check if 0x3A742 corresponds to the start of the string or related text.
        hex_dump(0x3A740, 64, "Around Katrina (0x3A740)")
        
        # 2. Inspect "Training Center" area
        # Python found "Training Center" at 0x28321.
        hex_dump(0x28320, 64, "Around Training Center (0x28320)")

        # 3. Search for references to offsets
        # We saw `MOV AX, 0x3a42` in the code (machine code B8 42 3A).
        # Let's find where `B8 42 3A` occurs.
        # And `68 42 3A` (PUSH 0x3a42).
        
        def find_opcode_val(opcode_byte, val, name):
            needle = bytes([opcode_byte]) + val.to_bytes(2, byteorder='little')
            offset = data.find(needle)
            while offset != -1:
                # Filter for code segment range (roughly 0x10000 - 0x20000)
                if 0x10000 <= offset <= 0x20000:
                    print(f"Found {name} at Code Linear 0x{offset:X} (1000:{offset-0x10000:04X})")
                offset = data.find(needle, offset + 1)

        print("\nSearching for code references to 0x3a42 (Katrina?):")
        find_opcode_val(0xB8, 0x3a42, "MOV AX, 3a42")
        find_opcode_val(0x68, 0x3a42, "PUSH 3a42")
        
        # Search for references to Training Center
        # If Training Center is at 0x28321.
        # If segment is same as Katrina (e.g. 0x36D0), offset would be...
        # 0x28321 - 0x36D00 = Negative.
        # If segment is 0x2000, offset 0x8321.
        # If segment is 0x2800, offset 0x0321.
        
        print("\nSearching for code references to Training Center offsets:")
        find_opcode_val(0xB8, 0x8321, "MOV AX, 8321")
        find_opcode_val(0xB8, 0x0321, "MOV AX, 0321")
        
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    analyze_strings_and_refs(os.path.join(repo_root, "spice86", "spice86dumpMemoryDump.bin"))
