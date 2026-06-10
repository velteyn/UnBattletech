import sys
import os

EGA_PALETTE = [
    (0x00, 0x00, 0x00), (0x00, 0x00, 0xAA), (0x00, 0xAA, 0x00), (0x00, 0xAA, 0xAA),
    (0xAA, 0x00, 0x00), (0xAA, 0x00, 0xAA), (0xAA, 0x55, 0x00), (0xAA, 0xAA, 0xAA),
    (0x55, 0x55, 0x55), (0x55, 0x55, 0xFF), (0x55, 0xFF, 0x55), (0x55, 0xFF, 0xFF),
    (0xFF, 0x55, 0x55), (0xFF, 0x55, 0xFF), (0xFF, 0xFF, 0x55), (0xFF, 0xFF, 0xFF)
]

def save_ppm(filename, width, height, pixels):
    with open(filename, 'wb') as f:
        f.write(f"P6\n{width} {height}\n255\n".encode('ascii'))
        for p in pixels:
            r, g, b = EGA_PALETTE[p & 0x0F]
            f.write(bytes([r, g, b]))

def planar_to_chunky(data, width, height, mode='scanline'):
    # EGA Planar: 4 planes (B, G, R, I)
    # 8 pixels per byte per plane.
    
    # Stride per plane = width / 8
    stride = width // 8
    total_bytes = stride * height * 4
    
    if len(data) < total_bytes:
        print(f"Warning: Data too short for {width}x{height} planar ({len(data)} < {total_bytes})")
        # return []
    
    pixels = bytearray(width * height)
    
    if mode == 'scanline':
        # Line 0: P0(40b) P1(40b) P2(40b) P3(40b)
        offset = 0
        for y in range(height):
            for p in range(4): # 4 planes
                # Plane p data for this line
                plane_data = data[offset : offset + stride]
                offset += stride
                
                # Process 8 pixels at a time
                for x_byte in range(stride):
                    if x_byte < len(plane_data):
                        byte = plane_data[x_byte]
                        for bit in range(8):
                            # Bit 7 is leftmost pixel
                            val = (byte >> (7 - bit)) & 1
                            if val:
                                px_idx = y * width + (x_byte * 8 + bit)
                                # Plane 0=B(1), 1=G(2), 2=R(4), 3=I(8)
                                pixels[px_idx] |= (1 << p)
    elif mode == 'full':
        # Plane 0 (all lines), Plane 1 (all lines)...
        plane_size = stride * height
        for p in range(4):
            plane_start = p * plane_size
            for y in range(height):
                line_start = plane_start + y * stride
                plane_data = data[line_start : line_start + stride]
                for x_byte in range(stride):
                    if x_byte < len(plane_data):
                        byte = plane_data[x_byte]
                        for bit in range(8):
                            val = (byte >> (7 - bit)) & 1
                            if val:
                                px_idx = y * width + (x_byte * 8 + bit)
                                pixels[px_idx] |= (1 << p)
                                
    return pixels

def main():
    # INFOCOM
    with open("extracted_assets/INFOCOM.raw", "rb") as f: # This is currently nibble-unpacked, wait.
        # My extract_assets.py saved UNPACKED pixels to .raw
        # I need the DECODED RLE bytes (PACKED) to test planar decoding.
        # I don't have them saved. I should re-run extract_assets modified or read the .CMP and decode RLE here.
        pass

    # Re-read CMP and decode RLE
    import extract_assets
    
    repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
    cmp_dir = os.path.join(repo_root, "original", "cmp")
    files = [("INFOCOM.CMP", 320, 90), ("BTTITLE.CMP", 320, 200)]
    
    for fname, w, h in files:
        fpath = os.path.join(cmp_dir, fname)
        if not os.path.exists(fpath): continue
        
        with open(fpath, "rb") as f:
            content = f.read()
        
        # Skip header 3 bytes
        rle_data = content[3:]
        # Decode
        packed = extract_assets.decode_rle(rle_data)
        
        print(f"{fname}: {len(packed)} bytes unpacked.")
        
        # Try Scanline Planar
        # Guess height from size
        # 4 planes * (width/8) * height = size
        # height = size / (width/2)
        calc_h = len(packed) // (w // 2)
        print(f"  Calc Height: {calc_h}")
        
        # Scanline
        pixels_scan = planar_to_chunky(packed, w, calc_h, 'scanline')
        save_ppm(f"test_{fname}_scan.ppm", w, calc_h, pixels_scan)
        print(f"  Saved test_{fname}_scan.ppm")
        
        # Full
        pixels_full = planar_to_chunky(packed, w, calc_h, 'full')
        save_ppm(f"test_{fname}_full.ppm", w, calc_h, pixels_full)
        print(f"  Saved test_{fname}_full.ppm")

if __name__ == "__main__":
    main()
