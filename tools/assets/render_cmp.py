import sys
import struct

def decode_packbits(data):
    result = bytearray()
    i = 0
    while i < len(data):
        code = data[i]
        i += 1
        
        if code < 128:
            # Literal run
            count = code
            # Some variants use n+1
            # Based on MECHSHAP analysis: 02 -> 2 bytes. So count = code.
            # But standard PackBits is n+1.
            # Let's try count = code first.
            # If code is 0, literal 0 bytes? That would be a no-op.
            if count == 0:
                pass # No-op? Or maybe count is n+1?
                # In MECHSHAP, we saw '06' followed by 6 bytes.
                # If it was n+1, it would be 7 bytes.
                # Let's assume count = code.
            else:
                chunk = data[i:i+count]
                result.extend(chunk)
                i += count
        else:
            # Repeat run
            # code is signed negative.
            # count = 256 - code
            count = 256 - code
            if i < len(data):
                val = data[i]
                i += 1
                result.extend([val] * count)
    return result

def render_ascii(data, width):
    chars = " .:-=+*#%@"
    for y in range(0, len(data), width):
        row = data[y:y+width]
        line = ""
        for b in row:
            # map b (0-255) to char index
            idx = int(b / 25.6)
            if idx >= len(chars): idx = len(chars) - 1
            line += chars[idx]
        print(f"{y//width:03d}: {line}")

def analyze_cmp(filename):
    print(f"Analyzing {filename}...")
    with open(filename, 'rb') as f:
        content = f.read()
    
    # Header: First 2 bytes Width, next 2 bytes Height?
    # MECHSHAP: 14 42 (20, 66)
    # BTBORDER: 1d 01 (29, 1)?
    
    w = content[0]
    h = content[1]
    
    # Try alternate endianness or 16-bit
    w16 = content[0] + (content[1] << 8)
    h16 = content[2] + (content[3] << 8) # If header is 4 bytes?
    
    print(f"Header bytes: {content[:4].hex()}")
    print(f"Assume 8-bit W, H: {w} x {h}")
    
    # Data starts at offset 2?
    data = content[2:]
    
    decoded = decode_packbits(data)
    print(f"Decoded length: {len(decoded)}")
    
    if len(decoded) > 0:
        # Save decoded data
        out_bin = filename + ".bin"
        with open(out_bin, 'wb') as f:
            f.write(decoded)
        print(f"Saved decoded data to {out_bin}")

        if w > 0:
            print("Render with W={}:".format(w))
            render_ascii(decoded, w)
            
            # Check if length matches w*h
            expected = w * h
            print(f"Expected {expected} pixels, got {len(decoded)}")
            
        # Try custom width for BTBORDER
        if "BTBORDER" in filename:
            w_custom = 285
            print(f"Trying custom width {w_custom} for BTBORDER:")
            render_ascii(decoded, w_custom)

        # Try to infer width for MECHSHAP
        if "MECHSHAP" in filename:
             print("MECHSHAP likely multiple frames of 20x66.")
             num_frames = len(decoded) / (20*66)
             print(f"Estimated frames: {num_frames}")
             # Render first frame
             print("First frame:")
             render_ascii(decoded[:20*66], 20)

if __name__ == "__main__":
    import os
    repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
    cmp_dir = os.path.join(repo_root, "original", "cmp")
    files = ["MECHSHAP.CMP", "BTBORDER.CMP", "INFOCOM.CMP", "BTTITLE.CMP"]
    
    for f in files:
        fpath = os.path.join(cmp_dir, f)
        try:
            analyze_cmp(fpath)
        except Exception as e:
            print(f"Error processing {f}: {e}")
