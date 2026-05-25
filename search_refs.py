
import sys

def search_hex(filename, hex_pattern):
    with open(filename, 'rb') as f:
        data = f.read()
    
    pattern = bytes.fromhex(hex_pattern)
    offset = 0
    found = False
    while True:
        index = data.find(pattern, offset)
        if index == -1:
            break
        print(f"Found {hex_pattern} at offset 0x{index:x}")
        # Check if it's in a code segment (approximate)
        # Segment 1000 starts at 0x10000. Segment 0170 at 0x1700.
        segment = index >> 4
        print(f"  Approx Segment:Selector -> {segment:04x}:{index & 0xF}")
        offset = index + 1
        found = True
    return found

filename = r"C:\Reversing\AIATTEMPT\spice86\spice86dumpMemoryDump.bin"

# 88E0 (Will you enter the)
print("Searching for 88E0 references...")
patterns = [
    "B8E088", # MOV AX
    "BBE088", # MOV BX
    "B9E088", # MOV CX
    "BAE088", # MOV DX
    "BEE088", # MOV SI
    "BFE088", # MOV DI
    "68E088", # PUSH
]

for p in patterns:
    search_hex(filename, p)

# 8960 (Put the BattleTech)
print("\nSearching for 8960 references...")
patterns_2 = [
    "B86089", "BB6089", "B96089", "BA6089", "BE6089", "BF6089", "686089"
]
for p in patterns_2:
    search_hex(filename, p)
