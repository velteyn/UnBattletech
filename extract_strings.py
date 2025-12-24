import re

def extract_strings(filename):
    data = bytearray()
    
    with open(filename, 'r') as f:
        for line in f:
            # Match lines like "3EDB:3E60 20 75 ...  uses a .An enem"
            # We want the hex part.
            # Regex: Address (Hex) HexBytes... ASCII
            # But simpler: find the hex bytes between the address and the ASCII.
            
            # Typical line:
            # 3EDB:3E60 20 75 73 65 73 20 61 20 00 41 6E 20 65 6E 65 6D  uses a .An enem
            
            # Split by spaces?
            parts = line.strip().split()
            if not parts or not parts[0].startswith('3EDB:'):
                continue
                
            # Hex bytes are usually parts[1:17] (16 bytes)
            # But the ASCII part might contain spaces.
            # The ASCII part starts after a double space or fixed column?
            # Let's rely on the hex bytes being 2 characters.
            
            # Alternative: Reko usually aligns columns.
            # 3EDB:3E60 is 9 chars.
            # Hex bytes start at col 10?
            
            # Let's just regex for 2-digit hex sequences.
            hex_part = line[10:58] # Approximate columns for 16 bytes
            hex_bytes = hex_part.split()
            
            for b in hex_bytes:
                if len(b) == 2 and all(c in '0123456789ABCDEFabcdef' for c in b):
                    try:
                        data.append(int(b, 16))
                    except:
                        pass

    # Now split by null bytes (0x00)
    strings = []
    current_string = bytearray()
    
    for b in data:
        if b == 0:
            if len(current_string) > 0:
                try:
                    s = current_string.decode('ascii')
                    # Filter for readable strings (mostly alphanumeric/punctuation)
                    if len(s) > 3 and any(c.isalpha() for c in s):
                         # clean up newlines/tabs
                        s = s.replace('\r', '').replace('\n', '')
                        strings.append(s)
                except:
                    pass
                current_string = bytearray()
        else:
            if 32 <= b <= 126: # Printable ASCII
                current_string.append(b)
            else:
                # If non-printable (except maybe tab/newline), reset
                # But sometimes strings contain control codes.
                # For now, treat non-printable as terminator or invalid
                if len(current_string) > 0:
                     # Treat as end of string? Or just ignore?
                     # Let's treat as terminator if we have a good string
                     pass
                current_string = bytearray() # Reset on garbage

    return strings

def generate_java_class(strings, output_file):
    with open(output_file, 'w') as f:
        f.write("package com.btech;\n\n")
        f.write("import java.util.ArrayList;\n")
        f.write("import java.util.List;\n\n")
        f.write("public class GameStrings {\n")
        f.write("    public static final List<String> STRINGS = new ArrayList<>();\n\n")
        f.write("    static {\n")
        
        count = 0
        for s in strings:
            # Escape quotes
            s_escaped = s.replace('"', '\\"')
            f.write(f'        STRINGS.add("{s_escaped}");\n')
            count += 1
            
        f.write("    }\n")
        
        # Also try to categorize specific lists
        f.write("\n    // Categorized lists (heuristically detected)\n")
        f.write("    public static final String[] MECH_PARTS = {\n")
        parts = [s for s in strings if any(k in s for k in ["Actuator", "Joint", "Mount", "Sink", "Gyro", "Housing", "Plating", "Bundle", "Strut"])]
        for p in parts:
             f.write(f'        "{p}",\n')
        f.write("    };\n")

        f.write("}\n")

if __name__ == "__main__":
    input_file = r"c:\Reversing\AIATTEMPT\UNBTECH.reko\UNBTECH_3EDB_0000.asm"
    output_file = r"c:\Reversing\AIATTEMPT\java_project\src\main\java\com\btech\GameStrings.java"
    
    print(f"Extracting strings from {input_file}...")
    strings = extract_strings(input_file)
    print(f"Found {len(strings)} strings.")
    
    generate_java_class(strings, output_file)
    print(f"Generated {output_file}")
