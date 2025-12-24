
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
    # Offsets from code: 0x3a42, 0x3a6f, 0x3abc
    
    def get_str(offset):
        linear = 0x36D00 + offset
        end = data.find(b'\x00', linear)
        if end == -1: end = linear + 50
        return data[linear:end].decode('latin-1', errors='replace')

    print(f"0x3a42: {get_str(0x3a42)}", flush=True)
    print(f"0x3a6f: {get_str(0x3a6f)}", flush=True)
    print(f"0x3abc: {get_str(0x3abc)}", flush=True)
    
    # Also dump around Training Center again to see the list order
    # 0x28321
    tc_linear = 0x28321
    # Go back a bit to see if there are others before
    start = tc_linear - 32
    end = tc_linear + 100
    print(f"\nAround Training Center (0x{tc_linear:X}):", flush=True)
    print(data[start:end].replace(b'\x00', b'|').decode('latin-1', errors='replace'), flush=True)

if __name__ == "__main__":
    dump_msgs("c:\\Reversing\\AIATTEMPT\\spice86\\spice86dumpMemoryDump.bin")
