import os
import struct
import sys

# Define standard EGA Palette (16 colors)
EGA_PALETTE = [
    (0x00, 0x00, 0x00), # 0: Black
    (0x00, 0x00, 0xAA), # 1: Blue
    (0x00, 0xAA, 0x00), # 2: Green
    (0x00, 0xAA, 0xAA), # 3: Cyan
    (0xAA, 0x00, 0x00), # 4: Red
    (0xAA, 0x00, 0xAA), # 5: Magenta
    (0xAA, 0x55, 0x00), # 6: Brown
    (0xAA, 0xAA, 0xAA), # 7: Light Gray
    (0x55, 0x55, 0x55), # 8: Dark Gray
    (0x55, 0x55, 0xFF), # 9: Light Blue
    (0x55, 0xFF, 0x55), # 10: Light Green
    (0x55, 0xFF, 0xFF), # 11: Light Cyan
    (0xFF, 0x55, 0x55), # 12: Light Red
    (0xFF, 0x55, 0xFF), # 13: Light Magenta
    (0xFF, 0xFF, 0x55), # 14: Yellow
    (0xFF, 0xFF, 0xFF)  # 15: White
]

class InceptionExtractor:
    def __init__(self):
        pass

    def get_palette(self, filename):
        palette = list(EGA_PALETTE) # Copy standard palette
        
        # Apply swaps based on CrescentHawksTools documentation and C# code
        if "BTTITLE" in filename:
            palette[1] = (0x00, 0x00, 0x00) # Swap Color 1 to Black
        elif "INFOCOM" in filename:
            palette[9] = (0x00, 0x00, 0xAA) # Swap Color 9 to Dark Blue
            palette[5] = (0x55, 0x55, 0xFF) # Swap Color 5 to Light Blue
        elif "ENDMECH" in filename:
            palette[1] = (0x00, 0x00, 0x00) # Swap Color 1 to Black
            palette[13] = (0x55, 0x55, 0xFF) # Swap Color 13 to Light Blue
            palette[9] = (0x00, 0x00, 0xAA) # Swap Color 9 to Dark Blue
            
        return palette

    def decompress_format_01(self, compressed, start_index):
        max_buffer = 0x7D00 # 32000 bytes
        decoded = bytearray(max_buffer)
        decoded_idx = 0
        comp_idx = start_index
        
        while decoded_idx < max_buffer and comp_idx < len(compressed):
            current_byte = compressed[comp_idx]
            # Convert to signed byte
            if current_byte > 127: signed_byte = current_byte - 256
            else: signed_byte = current_byte
            
            is_zero_byte = False
            run_length = 0
            
            if current_byte != 0:
                # If byte is non-zero, it's a literal run count
                # Positive or negative, take absolute value
                run_length = abs(signed_byte)
            else:
                # If byte is zero, next 2 bytes are run length
                comp_idx += 1
                if comp_idx + 1 >= len(compressed): break
                run_length = struct.unpack_from('<H', compressed, comp_idx)[0]
                comp_idx += 1 # Advance past first byte of short (second byte handled by loop increment)
                is_zero_byte = True
            
            # Move to next byte (the data or start of data)
            comp_idx += 1
            if comp_idx >= len(compressed): break
            output_byte = compressed[comp_idx]
            
            while run_length > 0:
                if decoded_idx < max_buffer:
                    decoded[decoded_idx] = output_byte
                    decoded_idx += 1
                else:
                    break # Buffer full
                
                run_length -= 1
                if run_length == 0: break
                
                if not is_zero_byte:
                    # Literal run: read next byte for next iteration
                    comp_idx += 1
                    if comp_idx >= len(compressed): break
                    output_byte = compressed[comp_idx]
            
            comp_idx += 1
            
        return decoded

    def decompress_format_02(self, compressed, start_index):
        max_buffer = 0x7D00 # 32000 bytes
        decoded = bytearray(max_buffer)
        decoded_idx = 0
        comp_idx = start_index
        
        y_axis_size = 200
        x_axis_object_next_offset = 31999
        y_axis_remaining = y_axis_size
        x_axis_object_byte_size = 160
        
        while comp_idx < len(compressed):
            # Check if we have filled the buffer (approximate check)
            # Since decoded_idx jumps, strict check is hard, but max_buffer limits it.
            # We'll rely on loop termination via buffer filling or input exhaustion.
            pass
            
            current_byte = compressed[comp_idx]
            if current_byte > 127: signed_byte = current_byte - 256
            else: signed_byte = current_byte
            
            is_zero_byte = False
            run_length = 0
            
            if current_byte != 0:
                run_length = abs(signed_byte)
            else:
                comp_idx += 1
                if comp_idx + 1 >= len(compressed): break
                run_length = struct.unpack_from('<H', compressed, comp_idx)[0]
                comp_idx += 1
                is_zero_byte = True
            
            comp_idx += 1
            if comp_idx >= len(compressed): break
            output_byte = compressed[comp_idx]
            
            while run_length > 0:
                if decoded_idx < max_buffer:
                    decoded[decoded_idx] = output_byte
                    
                    # Vertical / Column-major logic
                    decoded_idx += x_axis_object_byte_size
                    y_axis_remaining -= 1
                    
                    if y_axis_remaining == 0:
                        y_axis_remaining = y_axis_size
                        # Move back to beginning but next byte
                        decoded_idx -= x_axis_object_next_offset
                else:
                    # Buffer full or out of bounds
                    pass
                
                # Check for completion based on filled buffer?
                # The C# code decrements MaxBufferRemaining.
                # Let's count bytes written?
                # Actually, if decoded_idx wraps around, we might overwrite?
                # No, decoded_idx increases by 160, then resets back -31999 (which is -32000 + 1).
                # So it effectively increments by 1 after a full column.
                # So it fills 0, 160, 320... then 1, 161, 321...
                
                run_length -= 1
                if run_length == 0: break
                
                if not is_zero_byte:
                    comp_idx += 1
                    if comp_idx >= len(compressed): break
                    output_byte = compressed[comp_idx]
            
            comp_idx += 1
            
            # Termination check (heuristic based on input or filled buffer)
            # The C# code uses a counter 'MaxBufferRemaining' initialized to 0x7D00.
            # I should do the same.
            
        return decoded

    def decompress_format_02_robust(self, compressed, start_index):
        # Robust implementation tracking remaining bytes
        max_buffer_remaining = 0x7D00
        decoded = bytearray(0x7D00)
        decoded_idx = 0
        comp_idx = start_index
        
        y_axis_remaining = 200
        x_axis_obj_size = 160
        x_axis_next_offset = 31999
        
        while max_buffer_remaining > 0 and comp_idx < len(compressed):
            current_byte = compressed[comp_idx]
            if current_byte > 127: signed_byte = current_byte - 256
            else: signed_byte = current_byte
            
            is_zero_byte = False
            run_length = 0
            
            if current_byte != 0:
                run_length = abs(signed_byte)
            else:
                comp_idx += 1
                if comp_idx + 1 >= len(compressed): break
                run_length = struct.unpack_from('<H', compressed, comp_idx)[0]
                comp_idx += 1
                is_zero_byte = True
            
            comp_idx += 1
            if comp_idx >= len(compressed): break
            output_byte = compressed[comp_idx]
            
            while run_length > 0:
                if decoded_idx < len(decoded):
                    decoded[decoded_idx] = output_byte
                    decoded_idx += x_axis_obj_size
                    y_axis_remaining -= 1
                    
                    if y_axis_remaining == 0:
                        y_axis_remaining = 200
                        decoded_idx -= x_axis_next_offset
                
                max_buffer_remaining -= 1
                if max_buffer_remaining == 0: return decoded
                
                run_length -= 1
                if run_length == 0: break
                
                if not is_zero_byte:
                    comp_idx += 1
                    if comp_idx >= len(compressed): break
                    output_byte = compressed[comp_idx]
            
            comp_idx += 1
            
        return decoded

    def write2mode_converter(self, graphics_array):
        # Unpacks 4-bit pixels (2 pixels per byte) to 8-bit pixels (1 pixel per byte)
        width = 320
        height = 200
        vga_memory = bytearray(width * height)
        vga_offset = 0
        
        for b in graphics_array:
            if vga_offset >= len(vga_memory): break
            high = (b >> 4) & 0xF
            low = b & 0x0F
            
            vga_memory[vga_offset] = high
            vga_offset += 1
            if vga_offset >= len(vga_memory): break
            vga_memory[vga_offset] = low
            vga_offset += 1
            
        return vga_memory

    def save_ppm(self, pixels, width, height, palette, output_filename):
        with open(output_filename, 'wb') as f:
            f.write(f"P6\n{width} {height}\n255\n".encode())
            for p in pixels:
                if p < len(palette):
                    r, g, b = palette[p]
                else:
                    r, g, b = 0, 0, 0
                f.write(bytes([r, g, b]))
        print(f"Saved {output_filename}")

    def extract_file(self, file_path):
        filename = os.path.basename(file_path).upper()
        if not os.path.exists(file_path):
            print(f"File not found: {file_path}")
            return

        with open(file_path, 'rb') as f:
            content = f.read()

        # Header parsing
        # Size = Short at 0
        # Format = Byte at 2
        # Start = 3
        
        if len(content) < 3:
            print(f"File too short: {filename}")
            return

        compression_format = content[2]
        start_pos = 3
        
        print(f"Extracting {filename}: Format {compression_format:02X}")
        
        decoded_packed = b''
        if compression_format == 0x01:
            decoded_packed = self.decompress_format_01(content, start_pos)
        elif compression_format == 0x02:
            decoded_packed = self.decompress_format_02_robust(content, start_pos)
        else:
            print(f"Unknown format {compression_format} for {filename}")
            return

        # Convert packed nibbles to pixels
        pixels = self.write2mode_converter(decoded_packed)
        
        # Save output
        output_dir = "extracted_assets"
        os.makedirs(output_dir, exist_ok=True)
        
        palette = self.get_palette(filename)
        
        if filename.endswith(".CMP"):
            self.save_ppm(pixels, 320, 200, palette, os.path.join(output_dir, filename.replace(".CMP", ".ppm")))
        elif filename.endswith(".ICN"):
            # TileSet handling (save as sheet or individual tiles)
            # For now, save as a generic sheet 320 wide
            # Or assume 16x16 tiles
            # Let's save as 320xN sheet for easy viewing
            height = len(pixels) // 320
            self.save_ppm(pixels, 320, height, palette, os.path.join(output_dir, filename.replace(".ICN", ".ppm")))

def main():
    repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
    extractor = InceptionExtractor()
    files = [
        ("CMP", "BTTITLE.CMP"), ("CMP", "INFOCOM.CMP"), ("CMP", "MECHSHAP.CMP"),
        ("CMP", "BTBORDER.CMP"), ("CMP", "TINYLAND.CMP"), ("CMP", "BTSTATS.CMP"),
        ("CMP", "ENDMECH.CMP"),
        ("ICN", "BTTLTECH.ICN"), ("ICN", "ANIMATE.ICN"), ("ICN", "STARLEAG.ICN"),
        ("ICN", "DESTRUCT.ICN"), ("ICN", "MAP.ICN")
    ]
    
    for ext, fname in files:
        fpath = os.path.join(repo_root, "original", ext.lower(), fname)
        if os.path.exists(fpath):
            extractor.extract_file(fpath)
        else:
            print(f"Skipping missing file: {fpath}")

if __name__ == "__main__":
    main()
