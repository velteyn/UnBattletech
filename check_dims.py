import struct
import os

files = [
    r"Assets/Maps/MAP1.bmp",
    r"Assets/Sprites/MECHSHAP_0.bmp"
]

for f in files:
    if os.path.exists(f):
        try:
            with open(f, 'rb') as file:
                header = file.read(24)
                if header[:4] == b'\x89PNG':
                    width = struct.unpack('>i', header[16:20])[0]
                    height = struct.unpack('>i', header[20:24])[0]
                    print(f"{f}: {width}x{height} (PNG)")
                elif header[:2] == b'BM':
                    width = struct.unpack('<i', header[18:22])[0]
                    height = struct.unpack('<i', header[22:26])[0]
                    print(f"{f}: {width}x{height} (BMP)")
                else:
                    print(f"{f}: Unknown format {header[:4]}")
        except Exception as e:
            print(f"{f}: Error {e}")
    else:
        print(f"{f}: Not found")
