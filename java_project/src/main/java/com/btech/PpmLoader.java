package com.btech;

import java.awt.image.BufferedImage;
import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;

public class PpmLoader {

    public static BufferedImage loadPpm(String filePath) throws IOException {
        try (InputStream is = new BufferedInputStream(new FileInputStream(filePath))) {
            // Read header
            // P6
            // width height
            // maxval
            
            if (readByte(is) != 'P' || readByte(is) != '6') {
                throw new IOException("Not a P6 PPM file");
            }
            skipWhitespace(is);
            
            int width = readInt(is);
            skipWhitespace(is);
            int height = readInt(is);
            skipWhitespace(is);
            int maxVal = readInt(is);
            
            if (maxVal > 255) {
                throw new IOException("Only 8-bit per channel PPM supported");
            }
            
            // Single whitespace after maxVal usually
            int b = is.read();
            if (!Character.isWhitespace(b)) {
                // If strictly following spec, a single whitespace char separates header from data.
                // We consumed it. If it wasn't whitespace, push back? 
                // Usually it's a newline (0x0A).
            }

            BufferedImage image = new BufferedImage(width, height, BufferedImage.TYPE_INT_RGB);
            
            byte[] rowData = new byte[width * 3];
            for (int y = 0; y < height; y++) {
                int bytesRead = 0;
                while (bytesRead < rowData.length) {
                    int count = is.read(rowData, bytesRead, rowData.length - bytesRead);
                    if (count == -1) break;
                    bytesRead += count;
                }
                
                for (int x = 0; x < width; x++) {
                    int r = rowData[x * 3] & 0xFF;
                    int g = rowData[x * 3 + 1] & 0xFF;
                    int bVal = rowData[x * 3 + 2] & 0xFF; // b is reserved
                    int rgb = (r << 16) | (g << 8) | bVal;
                    image.setRGB(x, y, rgb);
                }
            }
            
            return image;
        }
    }
    
    private static int readByte(InputStream is) throws IOException {
        int b = is.read();
        if (b == -1) throw new IOException("Unexpected end of file");
        return b;
    }
    
    private static void skipWhitespace(InputStream is) throws IOException {
        int b;
        while (true) {
            is.mark(1);
            b = is.read();
            if (b == -1) return;
            if (!Character.isWhitespace(b)) {
                is.reset();
                return;
            }
        }
    }
    
    private static int readInt(InputStream is) throws IOException {
        StringBuilder sb = new StringBuilder();
        int b;
        while (true) {
            is.mark(1);
            b = is.read();
            if (b == -1) break;
            if (Character.isDigit(b)) {
                sb.append((char)b);
            } else {
                is.reset();
                break;
            }
        }
        if (sb.length() == 0) throw new IOException("Expected integer");
        return Integer.parseInt(sb.toString());
    }
}
