package com.btech;

import java.awt.Color;
import java.awt.Graphics2D;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import javax.imageio.ImageIO;

public class GameGraphics {
    public static List<BufferedImage> MECH_SPRITES = new ArrayList<>();
    public static java.util.Map<Integer, BufferedImage> SPRITE_MAP = new java.util.HashMap<>();
    public static BufferedImage BORDER_IMAGE;
    public static BufferedImage VILLAGE_MAP;
    public static BufferedImage PLAYER_SPRITE;
    
    // Path to assets (assuming running from project root)
    private static final String ASSETS_DIR = "Assets/";
    private static final String SPRITES_DIR = "Assets/Sprites/";
    private static final String MAPS_DIR = "Assets/Maps/";
    
    static {
        // Load resources
        try {
            loadMechSprites();
            loadBorder();
            loadVillageMap();
            loadPlayerSprite();
        } catch (Exception e) {
            System.err.println("Error loading graphics: " + e.getMessage());
            e.printStackTrace();
        }
    }

    private static void loadMechSprites() {
        File spritesDir = new File(SPRITES_DIR);
        if (!spritesDir.exists() || !spritesDir.isDirectory()) {
            System.err.println("Sprites directory not found: " + spritesDir.getAbsolutePath());
            return;
        }

        File[] files = spritesDir.listFiles((dir, name) -> name.startsWith("MECHSHAP_") && name.endsWith(".bmp"));
        if (files == null) return;

        // Sort files by number to ensure correct order
        List<File> fileList = new ArrayList<>();
        Collections.addAll(fileList, files);
        
        fileList.sort(Comparator.comparingInt(f -> {
            String name = f.getName();
            String numStr = name.substring("MECHSHAP_".length(), name.lastIndexOf('.'));
            try {
                return Integer.parseInt(numStr);
            } catch (NumberFormatException e) {
                return 0;
            }
        }));

        for (File f : fileList) {
            try {
                BufferedImage img = ImageIO.read(f);
                if (img != null) {
                    MECH_SPRITES.add(img);
                    
                    String name = f.getName();
                    String numStr = name.substring("MECHSHAP_".length(), name.lastIndexOf('.'));
                    try {
                        int id = Integer.parseInt(numStr);
                        SPRITE_MAP.put(id, img);
                    } catch (NumberFormatException e) {
                        // Ignore
                    }
                }
            } catch (IOException e) {
                System.err.println("Failed to load sprite: " + f.getName());
            }
        }
        
        System.out.println("Loaded " + MECH_SPRITES.size() + " mech sprites from " + SPRITES_DIR);
    }

    public static BufferedImage getPlayerSprite(int direction, int frameStep) {
        // User said sprites 166-195 (30 sprites)
        // Order: Right, Up, Left, Down
        // 30 sprites / 4 directions = 7.5. Let's assume 7 frames per direction.
        
        int baseId = 166;
        int framesPerDir = 7;
        
        // Map standard direction (0=Up, 1=Right, 2=Down, 3=Left) to file order
        int dirIndex = 0;
        switch (direction) {
            case 1: dirIndex = 0; break; // Right (First in file)
            case 0: dirIndex = 1; break; // Up
            case 3: dirIndex = 2; break; // Left
            case 2: dirIndex = 3; break; // Down
            default: dirIndex = 3; break; // Default Down
        }
        
        int spriteId = baseId + (dirIndex * framesPerDir) + (frameStep % framesPerDir);
        
        // Safety check bounds (166 to 195)
        if (spriteId > 195) spriteId = 195;
        
        if (SPRITE_MAP.containsKey(spriteId)) {
            return SPRITE_MAP.get(spriteId);
        }
        return PLAYER_SPRITE; // Fallback
    }

    private static void loadBorder() {
        File borderFile = new File(ASSETS_DIR + "BTBORDER.bmp");
        if (borderFile.exists()) {
            try {
                BORDER_IMAGE = ImageIO.read(borderFile);
                System.out.println("Loaded Border: " + BORDER_IMAGE.getWidth() + "x" + BORDER_IMAGE.getHeight());
            } catch (IOException e) {
                System.err.println("Failed to load BTBORDER.bmp");
            }
        } else {
            System.err.println("BTBORDER.bmp not found at " + borderFile.getAbsolutePath());
        }
    }

    private static void loadVillageMap() {
        File mapFile = new File(MAPS_DIR + "MAP1.bmp");
        if (mapFile.exists()) {
            try {
                VILLAGE_MAP = ImageIO.read(mapFile);
                System.out.println("Loaded Village Map: " + VILLAGE_MAP.getWidth() + "x" + VILLAGE_MAP.getHeight());
            } catch (IOException e) {
                System.err.println("Failed to load MAP1.bmp");
            }
        } else {
            System.err.println("MAP1.bmp not found at " + mapFile.getAbsolutePath());
        }
    }

    private static void loadPlayerSprite() {
        File spriteFile = new File(SPRITES_DIR + "MECHSHAP_166.bmp");
        if (spriteFile.exists()) {
            try {
                PLAYER_SPRITE = ImageIO.read(spriteFile);
                System.out.println("Loaded Player Sprite (166)");
            } catch (IOException e) {
                System.err.println("Failed to load player sprite");
            }
        } else {
            System.err.println("Player sprite 166 not found, using fallback");
            PLAYER_SPRITE = new BufferedImage(16, 16, BufferedImage.TYPE_INT_ARGB);
            Graphics2D g = PLAYER_SPRITE.createGraphics();
            g.setColor(Color.CYAN);
            g.fillOval(0, 0, 16, 16);
            g.dispose();
        }
    }
}
