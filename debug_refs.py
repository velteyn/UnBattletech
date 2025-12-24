
print("Script starting...")
import sys
import os

filename = r"c:\Reversing\AIATTEMPT\spice86\spice86dumpMemoryDump.bin"

if not os.path.exists(filename):
    print(f"File not found: {filename}")
    sys.exit(1)

print(f"Reading {filename}...")
with open(filename, 'rb') as f:
    data = f.read()
print(f"Read {len(data)} bytes.")

# Inspect Katrina (0x3A74D)
start = 0x3A740
length = 64
print(f"--- Around Katrina (0x{start:X}) ---")
print(data[start:start+length])
print("---")

# Inspect Training Center (0x28321)
start = 0x28320
length = 64
print(f"--- Around Training Center (0x{start:X}) ---")
print(data[start:start+length])
print("---")

# Search for B8 42 3A (MOV AX, 3a42)
needle = b'\xB8\x42\x3A'
print(f"Searching for {needle.hex()}...")
offset = data.find(needle)
while offset != -1:
    if 0x10000 <= offset <= 0x20000:
        print(f"Found at 0x{offset:X} (1000:{offset-0x10000:04X})")
    offset = data.find(needle, offset + 1)
