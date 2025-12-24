import os
import re

def extract_strings_from_file(filepath):
    with open(filepath, 'rb') as f:
        data = f.read()
    
    # Simple heuristic: sequence of printable chars length >= 4
    # Filter out common garbage
    strings = []
    current_string = ""
    for byte in data:
        if 32 <= byte <= 126: # Printable ASCII
            current_string += chr(byte)
        else:
            if len(current_string) >= 4:
                strings.append(current_string)
            current_string = ""
    if len(current_string) >= 4:
        strings.append(current_string)
        
    return strings

def main():
    directory = r"c:\Reversing\AIATTEMPT"
    output_file = r"c:\Reversing\AIATTEMPT\java_project\src\main\resources\bld_strings.txt"
    
    all_strings = {}
    
    for filename in os.listdir(directory):
        if filename.endswith(".BLD"):
            path = os.path.join(directory, filename)
            strs = extract_strings_from_file(path)
            if strs:
                all_strings[filename] = strs

    # Write to resource file
    with open(output_file, 'w', encoding='utf-8') as f:
        for filename, strs in all_strings.items():
            f.write(f"=== {filename} ===\n")
            for s in strs:
                f.write(f"{s}\n")
            f.write("\n")
            
    print(f"Extracted strings to {output_file}")

if __name__ == "__main__":
    main()
