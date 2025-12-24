import struct
import os

def analyze_mz(filename):
    with open(filename, 'rb') as f:
        data = f.read()

    if len(data) < 0x20:
        print("File too small for MZ header")
        return

    if data[0:2] != b'MZ':
        print("Not an MZ executable")
        return

    # MZ Header format
    # Offset Size Description
    # 00     2    Signature 'MZ'
    # 02     2    Bytes on last page of file
    # 04     2    Pages in file
    # 06     2    Relocations
    # 08     2    Size of header in paragraphs
    # 0A     2    Minimum extra paragraphs needed
    # 0C     2    Maximum extra paragraphs needed
    # 0E     2    Initial (relative) SS value
    # 10     2    Initial SP value
    # 12     2    Checksum
    # 14     2    Initial IP value
    # 16     2    Initial (relative) CS value
    # 18     2    File address of relocation table
    # 1A     2    Overlay number

    header = struct.unpack('<HHHHHHHHHHHHH', data[2:28])
    
    last_page_bytes = header[0]
    pages = header[1]
    relocations = header[2]
    header_size_para = header[3]
    min_alloc = header[4]
    max_alloc = header[5]
    ss = header[6]
    sp = header[7]
    checksum = header[8]
    ip = header[9]
    cs = header[10]
    reloc_table_offset = header[11]
    overlay = header[12]

    header_size_bytes = header_size_para * 16
    
    print(f"File: {filename}")
    print(f"Header Size: {header_size_bytes} bytes")
    print(f"Code Segment (CS): {hex(cs)}")
    print(f"Instruction Pointer (IP): {hex(ip)}")
    print(f"Stack Segment (SS): {hex(ss)}")
    print(f"Stack Pointer (SP): {hex(sp)}")
    print(f"Relocations: {relocations}")
    print(f"Relocation Table Offset: {hex(reloc_table_offset)}")
    
    entry_point_file_offset = header_size_bytes + (cs * 16) + ip
    print(f"Calculated Entry Point File Offset: {hex(entry_point_file_offset)}")
    
    # Calculate file size from header
    file_size_header = (pages - 1) * 512 + last_page_bytes
    print(f"File Size from Header: {file_size_header} bytes")
    print(f"Actual File Size: {len(data)} bytes")
    
    if len(data) > file_size_header:
        print(f"Overlay/Extra Data detected: {len(data) - file_size_header} bytes")
        
    # Read Relocation Table
    if relocations > 0:
        print("Relocation Table Entries:")
        f.seek(reloc_table_offset)
        # for i in range(min(relocations, 10)): # Print first 10
        #    reloc = f.read(4)
        #    if len(reloc) == 4:
        #        offset, segment = struct.unpack('<HH', reloc)
        #        print(f"  {hex(segment)}:{hex(offset)}")

if __name__ == '__main__':
    analyze_mz('UNBTECH.exe')
