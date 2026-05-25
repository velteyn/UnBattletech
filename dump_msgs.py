
import sys

print("Script starting...", flush=True)

def dump_msgs(filename):
    print(f"Opening {filename}...", flush=True)
    try:
        with open(filename, 'rb') as f:
            data = f.read()
    except Exception as e:
        print(f"Error opening file: {e}", flush=True)
        return
    
    print(f"File read. Size: {len(data)}", flush=True)

    # Assumed DS = 0x36D0
    def get_str(offset):
        linear = 0x36D00 + offset
        end = data.find(b'\x00', linear)
        if end == -1: end = linear + 50
        return data[linear:end].decode('latin-1', errors='replace')

    # Segment 2000
    def get_str_2000(offset):
        linear = 0x20000 + offset
        end = data.find(b'\x00', linear)
        if end == -1: end = linear + 50
        return data[linear:end].decode('latin-1', errors='replace')

    print(f"--- Story Strings (DS=36D0) ---", flush=True)
    print(f"0x3a42: {get_str(0x3a42)}", flush=True)
    print(f"0x3a6f: {get_str(0x3a6f)}", flush=True)
    print(f"0x3abc: {get_str(0x3abc)}", flush=True)
    
    print(f"\n--- Shop Strings (DS=2000) ---", flush=True)
    # Weapons Shop
    print(f"Weapons Shop Header: {get_str_2000(0x8351)}", flush=True)
    print(f"Shop Menu: {get_str_2000(0xA2E1)}", flush=True)
    # print(f"Shopkeeper: {get_str_2000(0xA46F)}", flush=True) # Long string
    print(f"Buy Prompt: {get_str_2000(0xB451)}", flush=True)

    # Search for Armor and Mechit-Lube
    armor_off = data.find(b'Armor Shop')
    if armor_off != -1:
         print(f"Armor Shop String found at linear {armor_off:X}", flush=True)
         # If it's in 2000 segment, offset is linear - 0x20000
         if 0x20000 <= armor_off < 0x30000:
             print(f"  Offset in 2000: {armor_off - 0x20000:X}", flush=True)

    lube_off = data.find(b'Mechit-Lube')
    if lube_off != -1:
         print(f"Mechit-Lube String found at linear {lube_off:X}", flush=True)
         if 0x20000 <= lube_off < 0x30000:
             print(f"  Offset in 2000: {lube_off - 0x20000:X}", flush=True)

if __name__ == "__main__":
    dump_msgs("c:\\Reversing\\AIATTEMPT\\spice86\\spice86dumpMemoryDump.bin")
