import sys
import glob
import os

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
        repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
        files = [
            os.path.join(repo_root, "original", "bld", "TRAINING.BLD"),
            os.path.join(repo_root, "original", "icn", "STARLEAG.ICN"),
            os.path.join(repo_root, "original", "anm", "O0.ANM"),
            os.path.join(repo_root, "original", "cmp", "BTBORDER.CMP")
        ]
        for f in files:
            hexdump(f)
