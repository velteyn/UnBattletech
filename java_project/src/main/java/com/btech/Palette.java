package com.btech;

import java.awt.Color;

public class Palette {
    public static final Color[] EGA = {
        new Color(0x00, 0x00, 0x00), // 0: Black
        new Color(0x00, 0x00, 0xAA), // 1: Blue
        new Color(0x00, 0xAA, 0x00), // 2: Green
        new Color(0x00, 0xAA, 0xAA), // 3: Cyan
        new Color(0xAA, 0x00, 0x00), // 4: Red
        new Color(0xAA, 0x00, 0xAA), // 5: Magenta
        new Color(0xAA, 0x55, 0x00), // 6: Brown
        new Color(0xAA, 0xAA, 0xAA), // 7: Light Gray
        new Color(0x55, 0x55, 0x55), // 8: Dark Gray
        new Color(0x55, 0x55, 0xFF), // 9: Light Blue
        new Color(0x55, 0xFF, 0x55), // 10: Light Green
        new Color(0x55, 0xFF, 0xFF), // 11: Light Cyan
        new Color(0xFF, 0x55, 0x55), // 12: Light Red
        new Color(0xFF, 0x55, 0xFF), // 13: Light Magenta
        new Color(0xFF, 0xFF, 0x55), // 14: Yellow
        new Color(0xFF, 0xFF, 0xFF)  // 15: White
    };

    public static Color[] getPalette(String name) {
        Color[] p = EGA.clone();
        if ("BTTITLE".equals(name)) {
            p[1] = new Color(0x00, 0x00, 0x00);
        } else if ("INFOCOM".equals(name)) {
            p[5] = new Color(0x55, 0x55, 0xFF);
            p[9] = new Color(0x00, 0x00, 0xAA);
        }
        return p;
    }
}
