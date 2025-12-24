
import sys

def find_references(filename):
    try:
        with open(filename, 'rb') as f:
            data = f.read()
            
        # Define Code Segment Range (Linear)
        # Assuming CS starts at 0x10000 and is ~64KB
        cs_start = 0x10000
        cs_end = 0x20000
        code_data = data[cs_start:cs_end]
        
        # Target Linear Addresses
        target_training = 0x28321
        target_katrina = 0x3A74D
        
        # Potential Segments to check
        # We'll check standard segment boundaries (0x1000, 0x2000, etc.)
        # and see if the offset matches.
        
        # Helper to search for 16-bit value in code
        def search_val(val, name, segment_assumed):
            val_bytes = val.to_bytes(2, byteorder='little')
            offset = code_data.find(val_bytes)
            while offset != -1:
                # Calculate absolute address of the instruction/reference
                ref_addr = cs_start + offset
                print(f"Found reference to {name} (Offset 0x{val:04X}, assumed Seg 0x{segment_assumed:04X}) at Code Address: 0x{ref_addr:X} (1000:{ref_addr-0x10000:04X})")
                
                # Check surrounding bytes for context (e.g., MOV opcode)
                # BA = MOV DX, imm16
                # B8 = MOV AX, imm16
                # BF = MOV DI, imm16
                # BE = MOV SI, imm16
                # 68 = PUSH imm16
                prefix = code_data[offset-1] if offset > 0 else 0
                print(f"  Opcode before: {prefix:02X}")
                
                offset = code_data.find(val_bytes, offset + 1)

        # Hypothesis 1: Training Center at 0x28321
        # If DS=0x2000 -> Offset 0x8321
        search_val(0x8321, "Training Center (DS=2000)", 0x2000)
        # If DS=0x2800 -> Offset 0x0321
        search_val(0x0321, "Training Center (DS=2800)", 0x2800)
        
        # Hypothesis 2: Katrina at 0x3A74D
        # If DS=0x3000 -> Offset 0xA74D
        search_val(0xA74D, "Katrina (DS=3000)", 0x3000)
        # If DS=0x3A00 -> Offset 0x074D
        search_val(0x074D, "Katrina (DS=3A00)", 0x3A00)
            
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    find_references("c:/Reversing/AIATTEMPT/spice86/spice86dumpMemoryDump.bin")
