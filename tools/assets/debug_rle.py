import sys
import os

def decode_packbits_std(data):
    result = bytearray()
    i = 0
    while i < len(data):
        val = data[i]
        i += 1
        if val < 128: # Literal
            count = val + 1
            if i + count > len(data): break
            result.extend(data[i:i+count])
            i += count
        elif val > 128: # Repeat
            count = 257 - val
            if i < len(data):
                byte = data[i]
                i += 1
                result.extend([byte] * count)
        else: # 128
            pass # No-op
    return result

def decode_packbits_inv(data):
    result = bytearray()
    i = 0
    while i < len(data):
        val = data[i]
        i += 1
        if val > 128: # Literal (Inverted)
            count = (val - 128) + 1
            if i + count > len(data): break
            result.extend(data[i:i+count])
            i += count
        elif val < 128: # Repeat (Inverted)
            count = val + 1 # Or some other formula
            if i < len(data):
                byte = data[i]
                i += 1
                result.extend([byte] * count)
        else: # 128
            pass
    return result

def analyze_file(filename):
    with open(filename, 'rb') as f:
        content = f.read()
    
    size = content[0] + (content[1] << 8)
    fmt = content[2]
    data = content[3:]
    
    print(f"--- {filename} ---")
    print(f"Header Size: {size}, Format: {fmt:02X}")
    print(f"Data Len: {len(data)}")
    
    res_std = decode_packbits_std(data)
    print(f"Std PackBits: {len(res_std)} bytes")
    
    res_inv = decode_packbits_inv(data)
    print(f"Inv PackBits: {len(res_inv)} bytes")
    
    # Try Format 01 logic?
    # If Format 01 is raw copy
    if fmt == 1:
        print(f"Raw Copy: {len(data)} bytes")

if __name__ == "__main__":
    repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
    cmp_dir = os.path.join(repo_root, "original", "cmp")
    for f in ["BTTITLE.CMP", "INFOCOM.CMP", "BTBORDER.CMP", "MECHSHAP.CMP"]:
        analyze_file(os.path.join(cmp_dir, f))
