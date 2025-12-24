import sys
import glob

def hexdump(filename, length=64):
    try:
        with open(filename, 'rb') as f:
            data = f.read(length)
            print(f"--- {filename} ---")
            for i in range(0, len(data), 16):
                chunk = data[i:i+16]
                hex_str = ' '.join(f'{b:02x}' for b in chunk)
                ascii_str = ''.join(chr(b) if 32 <= b < 127 else '.' for b in chunk)
                print(f"{i:04x}  {hex_str:<48}  {ascii_str}")
            print()
    except Exception as e:
        print(f"Error reading {filename}: {e}")

if __name__ == "__main__":
    if len(sys.argv) > 1:
        for arg in sys.argv[1:]:
            # Handle globs if passed as string
            for f in glob.glob(arg):
                hexdump(f)
    else:
        files = [
            r"c:\Reversing\AIATTEMPT\TRAINING.BLD",
            r"c:\Reversing\AIATTEMPT\STARLEAG.ICN",
            r"c:\Reversing\AIATTEMPT\O0.ANM",
            r"c:\Reversing\AIATTEMPT\BTBORDER.CMP"
        ]
        for f in files:
            hexdump(f)
