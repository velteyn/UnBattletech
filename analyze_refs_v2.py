
import sys
import os

def analyze_strings_and_refs(filename):
    print(f"Analyzing {filename}")
    if not os.path.exists(filename):
        print("File not found!")
        return

    try:
        with open(filename, 'rb') as f:
            data = f.read()
        
        print(f"Data length: {len(data)}")
            
        def hex_dump(start, length, label):
            print(f"--- {label} (Linear 0x{start:X}) ---")
            if start < 0 or start + length > len(data):
                print("Address out of bounds")
                return
            slice_data = data[start:start+length]
            print(slice_data)
            # print("Hex:", slice_data.hex())
            print("---")

        # 1. Inspect "Katrina" area
        hex_dump(0x3A740, 64, "Around Katrina (0x3A740)")
        
        # 2. Inspect "Training Center" area
        hex_dump(0x28320, 64, "Around Training Center (0x28320)")

        # 3. Search for references to offsets
        def find_opcode_val(opcode_byte, val, name):
            needle = bytes([opcode_byte]) + val.to_bytes(2, byteorder='little')
            print(f"Searching for {name} ({needle.hex()})...")
            offset = data.find(needle)
            found_count = 0
            while offset != -1:
                if 0x10000 <= offset <= 0x20000:
                    print(f"Found {name} at Code Linear 0x{offset:X} (1000:{offset-0x10000:04X})")
                    found_count += 1
                offset = data.find(needle, offset + 1)
            print(f"Total found in code segment: {found_count}")

        print("\nSearching for code references to 0x3a42 (Katrina?):")
        find_opcode_val(0xB8, 0x3a42, "MOV AX, 3a42")
        find_opcode_val(0x68, 0x3a42, "PUSH 3a42")
        
        print("\nSearching for code references to Training Center offsets:")
        find_opcode_val(0xB8, 0x8321, "MOV AX, 8321")
        find_opcode_val(0xB8, 0x0321, "MOV AX, 0321")
        
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    analyze_strings_and_refs("c:/Reversing/AIATTEMPT/spice86/spice86dumpMemoryDump.bin")
