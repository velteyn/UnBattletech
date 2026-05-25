package com.btech;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import java.util.Random;

public class GeneralMapPanel extends JPanel implements ActionListener {
    private static final int TILE_SIZE = 16;
    private static final int VIEW_WIDTH = 320;
    private static final int VIEW_HEIGHT = 200;
    
    private BufferedImage[] tiles;
    // World coordinates (pixel based, consistent with reverse engineering x >> 4)
    private int playerX = 1000; 
    private int playerY = 1000;
    
    private Timer timer;
    private boolean up, down, left, right;
    
    // Animation State
    private int direction = 2; // 0=Up, 1=Right, 2=Down, 3=Left
    private boolean isMoving = false;
    private int animationStep = 0;

    private long lastTime;
    private int frameCount;
    private String fpsText = "";

    // Movement Tables (Derived from Reverse Engineering 1000:160e)
    // 0=N, 1=NE, 2=E, 3=SE, 4=S, 5=SW, 6=W, 7=NW
    private static final int[] DELTA_X = {0, 1, 1, 1, 0, -1, -1, -1};
    private static final int[] DELTA_Y = {-1, -1, 0, 1, 1, 1, 0, -1};
    
    // Collision Threshold (Wiki: "If tile value is too high... stop")
    // We'll assume tiles > 200 are "walls/borders" based on typical map data
    private static final int COLLISION_THRESHOLD = 200;

    // Story Flags & UI
    private boolean hasFoundCache = false;
    private String currentMessage = "";
    private long messageTimer = 0;
    private static final int MESSAGE_DURATION = 180; // frames (~3 seconds)
    
    // Village Menu
    private boolean showVillageMenu = false;
    private final String[] VILLAGE_LOCATIONS = {
        "Training Center", "Citadel", "ComStar Station", 
        "Weapons Shop", "Armor Shop", "Mechit-Lube", 
        "Barracks", "Lounge"
    };

    // Shop Logic
    private enum ShopType { NONE, WEAPONS, ARMOR, LUBE }
    private ShopType currentShop = ShopType.NONE;
    private int shopSelection = 0;
    // Strings from Memory Dump (Offset 0xA2E1)
    private final String[] WEAPONS_OPTIONS = {"Bows and blades", "Slug-throwers", "Anti-'Mech weaponry", "Exit"};
    // Mocked options for others as strings weren't explicitly found in menu format yet
    private final String[] ARMOR_OPTIONS = {"Light Armor", "Medium Armor", "Heavy Armor", "Exit"}; 
    private final String[] LUBE_OPTIONS = {"Repair 'Mech", "Reload Ammo", "Exit"};

    public GeneralMapPanel() {
        setFocusable(true);
        setBackground(Color.BLACK);
        loadTiles();
        
        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                if (currentShop != ShopType.NONE) {
                    handleShopInput(e);
                    return;
                }
                
                if (showVillageMenu) {
                    handleMenuInput(e);
                    return;
                }
                
                switch (e.getKeyCode()) {
                    case KeyEvent.VK_UP -> { up = true; isMoving = true; }
                    case KeyEvent.VK_DOWN -> { down = true; isMoving = true; }
                    case KeyEvent.VK_LEFT -> { left = true; isMoving = true; }
                    case KeyEvent.VK_RIGHT -> { right = true; isMoving = true; }
                    
                    // Story Triggers
                    case KeyEvent.VK_K -> handleKatrinaRadio(); // Radio Katrina
                    case KeyEvent.VK_T -> handleTrainingCenter(); // Enter Training Center
                    case KeyEvent.VK_C -> toggleCache(); // Debug: Find Cache
                    case KeyEvent.VK_V -> toggleVillageMenu(); // Village Menu
                    case KeyEvent.VK_P -> saveScreenshot(); // Screenshot
                    case KeyEvent.VK_Q -> System.exit(0); // Quit
                }
                updateDirection();
            }

            @Override
            public void keyReleased(KeyEvent e) {
                switch (e.getKeyCode()) {
                    case KeyEvent.VK_UP -> up = false;
                    case KeyEvent.VK_DOWN -> down = false;
                    case KeyEvent.VK_LEFT -> left = false;
                    case KeyEvent.VK_RIGHT -> right = false;
                }
                if (!up && !down && !left && !right) {
                    isMoving = false;
                } else {
                    updateDirection();
                }
            }
        });
        
        // Game Loop Timer (approx 60 FPS)
        timer = new Timer(16, this);
        timer.start();
    }
    
    private void toggleVillageMenu() {
        showVillageMenu = !showVillageMenu;
        repaint();
    }

    private void handleShopInput(KeyEvent e) {
        int key = e.getKeyCode();
        String[] options = getShopOptions(currentShop);
        
        if (key == KeyEvent.VK_UP) {
            shopSelection--;
            if (shopSelection < 0) shopSelection = options.length - 1;
        } else if (key == KeyEvent.VK_DOWN) {
            shopSelection++;
            if (shopSelection >= options.length) shopSelection = 0;
        } else if (key == KeyEvent.VK_ENTER || key == KeyEvent.VK_SPACE) {
            String selected = options[shopSelection];
            if (selected.equals("Exit")) {
                currentShop = ShopType.NONE;
                showMessage("Leaving shop...");
            } else {
                // Buy Logic (Mocked)
                // Dump string 0xB451: "Will you buy it?"
                showMessage("Shopkeeper: Will you buy " + selected + "? (Not implemented)");
            }
        } else if (key == KeyEvent.VK_ESCAPE) {
            currentShop = ShopType.NONE;
        }
        repaint();
    }
    
    private String[] getShopOptions(ShopType type) {
        return switch (type) {
            case WEAPONS -> WEAPONS_OPTIONS;
            case ARMOR -> ARMOR_OPTIONS;
            case LUBE -> LUBE_OPTIONS;
            default -> new String[]{};
        };
    }

    private void handleMenuInput(KeyEvent e) {
        int key = e.getKeyCode();
        if (key == KeyEvent.VK_V || key == KeyEvent.VK_ESCAPE) {
            showVillageMenu = false;
        } else if (key >= KeyEvent.VK_1 && key <= KeyEvent.VK_8) {
            int index = key - KeyEvent.VK_1;
            if (index < VILLAGE_LOCATIONS.length) {
                enterLocation(VILLAGE_LOCATIONS[index]);
                showVillageMenu = false;
            }
        }
        repaint();
    }

    private void enterLocation(String location) {
        if (location.equals("Training Center")) {
            handleTrainingCenter();
        } else if (location.equals("Weapons Shop")) {
            currentShop = ShopType.WEAPONS;
            shopSelection = 0;
            // 0x8351 "Weapons Shop"
        } else if (location.equals("Armor Shop")) {
            currentShop = ShopType.ARMOR;
            shopSelection = 0;
        } else if (location.equals("Mechit-Lube")) {
            currentShop = ShopType.LUBE;
            shopSelection = 0;
        } else {
            showMessage("Visited: " + location);
        }
    }

    private void handleKatrinaRadio() {
        // Logic from 1000:2F73 (ghidra_guess_1000_2F73_12F73)
        // Checks flag at 0x515a (Cache Found?)
        // If 0 (Not Found? or Found? Logic implies Found=Success)
        // If not found, prints string at 0x3a42: "You want to radio Katrina, but you haven't found the cache."
        
        if (hasFoundCache) {
            // Success path (call 1000:3224)
            showMessage("Katrina: Excellent work, Cadet! Report to the Training Center.");
        } else {
            // Failure path (call 1000:8055 with 0x3a42)
            showMessage("You want to radio Katrina, but you haven't found the cache.");
        }
    }

    private void handleTrainingCenter() {
        // Logic for Training Center (String at 0x28321)
        showMessage("Entering Training Center... Career started.");
    }

    private void toggleCache() {
        hasFoundCache = !hasFoundCache;
        showMessage(hasFoundCache ? "Cache Found!" : "Cache Lost.");
    }

    private void showMessage(String msg) {
        currentMessage = msg;
        messageTimer = MESSAGE_DURATION;
        repaint();
    }

    private void updateDirection() {
        if (up && right) direction = 1;
        else if (down && right) direction = 3;
        else if (down && left) direction = 5;
        else if (up && left) direction = 7;
        else if (up) direction = 0;
        else if (right) direction = 2;
        else if (down) direction = 4;
        else if (left) direction = 6;
        // else keep previous direction
    }

    private void loadTiles() {
        if (GameGraphics.VILLAGE_MAP != null) {
            // MAP1.bmp is the source. 
            // Reverse engineering suggests 16x16 tiles (shift >> 4).
            // User states tiles are vertically aligned, but image is 1024x1024.
            // We will load all tiles from the image treating it as a tilesheet.
            int imgW = GameGraphics.VILLAGE_MAP.getWidth();
            int imgH = GameGraphics.VILLAGE_MAP.getHeight();
            
            int cols = imgW / TILE_SIZE;
            int rows = imgH / TILE_SIZE;
            tiles = new BufferedImage[cols * rows];
            
            for (int y = 0; y < rows; y++) {
                for (int x = 0; x < cols; x++) {
                    tiles[y * cols + x] = GameGraphics.VILLAGE_MAP.getSubimage(x * TILE_SIZE, y * TILE_SIZE, TILE_SIZE, TILE_SIZE);
                }
            }
            System.out.println("Loaded " + tiles.length + " tiles from MAP1.bmp (16x16 grid)");
        } else {
            tiles = new BufferedImage[0];
        }
    }

    // Mocking the memory lookup from unknown_19EF_13D9_1B2C9
    private int getTileAt(int tileX, int tileY) {
        if (tiles.length == 0) return 0;
        
        // Use a pseudo-random deterministic pattern based on coordinates
        // This simulates a map data file without having the actual file
        int seed = (tileX * 73856093) ^ (tileY * 19349663);
        int index = Math.abs(seed % tiles.length);
        return index;
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        // Movement speed in pixels
        int speed = 2;
        
        if (isMoving) {
            int dx = DELTA_X[direction] * speed;
            int dy = DELTA_Y[direction] * speed;
            
            // Calculate Target Position
            int targetX = playerX + dx;
            int targetY = playerY + dy;
            
            // Collision Logic ("House Border" Check)
            // 1000:16a6: Read Tile Value
            // 1000:16b4: Compare vs Limit (ES:[0x150] vs AX)
            // If Limit <= Tile -> Blocked (Exit)
            // So Tile < Limit -> Safe
            
            // Convert target to Tile Coordinates (assuming >> 4 for 16x16 tiles)
            int tileX = targetX / TILE_SIZE;
            int tileY = targetY / TILE_SIZE;
            
            // Get Tile Value (Simulating memory read ES:[BX + 0x7ad])
            int tileValue = getTileAt(tileX, tileY);
            
            // Check Threshold
            // Wiki: "If tile value is too high... stop"
            if (tileValue < COLLISION_THRESHOLD) {
                // Safe
                playerX = targetX;
                playerY = targetY;
            } else {
                // Blocked
                // System.out.println("Blocked by tile value: " + tileValue);
            }
            
            animationStep++;
        } else {
            animationStep = 0;
        }

        if (messageTimer > 0) {
            messageTimer--;
        }

        repaint();
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g;
        
        // Handle Aspect Ratio and Scaling
        float scaleX = (float) getWidth() / VIEW_WIDTH;
        float scaleY = (float) getHeight() / VIEW_HEIGHT;
        float scale = Math.min(scaleX, scaleY);
        
        int drawW = (int)(VIEW_WIDTH * scale);
        int drawH = (int)(VIEW_HEIGHT * scale);
        int offX = (getWidth() - drawW) / 2;
        int offY = (getHeight() - drawH) / 2;
        
        // Clip to viewport
        g2d.setClip(offX, offY, drawW, drawH);
        g2d.translate(offX, offY);
        g2d.scale(scale, scale);
        
        // Calculate visible tile range
        // Camera is centered on player
        int camX = playerX - VIEW_WIDTH / 2;
        int camY = playerY - VIEW_HEIGHT / 2;
        
        int startCol = camX / TILE_SIZE;
        int endCol = (camX + VIEW_WIDTH) / TILE_SIZE + 1;
        int startRow = camY / TILE_SIZE;
        int endRow = (camY + VIEW_HEIGHT) / TILE_SIZE + 1;
        
        // Draw visible tiles
        for (int c = startCol; c <= endCol; c++) {
            for (int r = startRow; r <= endRow; r++) {
                int tileIndex = getTileAt(c, r);
                if (tileIndex < tiles.length) {
                    int drawX = c * TILE_SIZE - camX;
                    int drawY = r * TILE_SIZE - camY;
                    g2d.drawImage(tiles[tileIndex], drawX, drawY, null);
                }
            }
        }
        
        // Draw Player Sprite (Center of screen)
        int pScreenX = VIEW_WIDTH / 2 - TILE_SIZE / 2;
        int pScreenY = VIEW_HEIGHT / 2 - TILE_SIZE / 2;
        
        // Use Animation
        BufferedImage playerImg = GameGraphics.getPlayerSprite(direction, animationStep / 5);
        if (playerImg != null) {
             g2d.drawImage(playerImg, pScreenX, pScreenY, TILE_SIZE, TILE_SIZE, null);
        } else {
            g2d.setColor(Color.RED);
            g2d.fillRect(pScreenX, pScreenY, TILE_SIZE, TILE_SIZE);
        }
        
        // Draw Debug Overlay (Matches Screenshot style)
        drawDebugOverlay(g2d);
        drawStoryOverlay(g2d);
        
        if (showVillageMenu) {
            drawVillageMenu(g2d);
        }
        
        if (currentShop != ShopType.NONE) {
            drawShopOverlay(g2d);
        }
        
        g2d.dispose();
    }
    
    private void drawVillageMenu(Graphics2D g) {
        // ... (Logic from before? No, I need to add this method too if it's not there)
        // Wait, I never implemented drawVillageMenu in previous turns?
        // Ah, I added toggleVillageMenu and handleMenuInput, but did I add drawing logic?
        // Let's check the file content I read earlier.
        // It had toggleVillageMenu, handleMenuInput, but NO drawVillageMenu in paintComponent or method def.
        // So the menu was invisible! I need to add it.
        
        int w = 150;
        int h = VILLAGE_LOCATIONS.length * 12 + 20;
        int x = (VIEW_WIDTH - w) / 2;
        int y = (VIEW_HEIGHT - h) / 2;
        
        g.setColor(Color.BLACK);
        g.fillRect(x, y, w, h);
        g.setColor(Color.WHITE);
        g.drawRect(x, y, w, h);
        
        g.setFont(new Font("Monospaced", Font.PLAIN, 10));
        for (int i = 0; i < VILLAGE_LOCATIONS.length; i++) {
            g.drawString((i+1) + ". " + VILLAGE_LOCATIONS[i], x + 10, y + 15 + i * 12);
        }
    }

    private void drawShopOverlay(Graphics2D g) {
        int w = 200;
        int h = 100;
        int x = (VIEW_WIDTH - w) / 2;
        int y = (VIEW_HEIGHT - h) / 2;
        
        g.setColor(new Color(0, 0, 50));
        g.fillRect(x, y, w, h);
        g.setColor(Color.GREEN);
        g.drawRect(x, y, w, h);
        
        String title = switch(currentShop) {
            case WEAPONS -> "WEAPONS SHOP";
            case ARMOR -> "ARMOR SHOP";
            case LUBE -> "MECHIT-LUBE";
            default -> "SHOP";
        };
        
        g.setFont(new Font("Monospaced", Font.BOLD, 12));
        g.drawString(title, x + 10, y + 15);
        
        String[] options = getShopOptions(currentShop);
        g.setFont(new Font("Monospaced", Font.PLAIN, 10));
        for (int i = 0; i < options.length; i++) {
            if (i == shopSelection) {
                g.setColor(Color.YELLOW);
                g.drawString("> " + options[i], x + 10, y + 30 + i * 12);
            } else {
                g.setColor(Color.GREEN);
                g.drawString("  " + options[i], x + 10, y + 30 + i * 12);
            }
        }
    }
    
    private void drawStoryOverlay(Graphics2D g) {
        if (messageTimer > 0 && !currentMessage.isEmpty()) {
            g.setColor(new Color(0, 0, 100, 200)); // Dark Blue Box
            g.fillRect(10, 150, VIEW_WIDTH - 20, 40);
            
            g.setColor(Color.WHITE);
            g.drawRect(10, 150, VIEW_WIDTH - 20, 40);
            
            g.setFont(new Font("Monospaced", Font.PLAIN, 9));
            g.drawString(currentMessage, 15, 175);
        }
    }

    private void drawDebugOverlay(Graphics2D g) {
        g.setColor(Color.WHITE);
        g.setFont(new Font("Monospaced", Font.BOLD, 10));
        
        // Top bar background
        g.setColor(new Color(0, 0, 0, 180));
        g.fillRect(0, 0, VIEW_WIDTH, 20);
        
        g.setColor(Color.GREEN);
        String debugInfo = String.format("X: %04X  Y: %04X  C-Bills: 1,500,000  Date: 3028", playerX, playerY);
        g.drawString(debugInfo, 5, 12);
        
        // Map Logic Debug
        g.setColor(Color.YELLOW);
        int tileVal = getTileAt(playerX >> 4, playerY >> 4);
        g.drawString(String.format("Tile: %d,%d Val: %d %s", 
            playerX >> 4, playerY >> 4, tileVal, 
            tileVal >= COLLISION_THRESHOLD ? "(BLOCKED)" : ""), 
            200, 12);

        // Story Flags Debug
        g.setColor(Color.CYAN);
        g.drawString(String.format("Cache: %s", hasFoundCache ? "YES" : "NO"), 200, 22);
        g.drawString("[V]illage Menu [K]atrina [C]ache", 5, 22);
    }

    // 1000:05c5 CalculateDistance
    // Returns an approximate distance between two points (x1,y1) and (x2,y2)
    // Uses the formula: approx = Max/2 + Min (Octagonal approximation)
    // Wiki: "The game also constantly calculates the distance between entities using a custom Manhattan-like distance function"
    public int calculateDistance(int x1, int y1, int x2, int y2) {
        int dx = Math.abs(x1 - x2);
        int dy = Math.abs(y1 - y2);
        
        int min = Math.min(dx, dy);
        int max = Math.max(dx, dy);
        
        // Assembly 1000:065a: MOV AX, Max; SAR AX, 1; ADD AX, Min
        return (max / 2) + min;
    }
    
    private void saveScreenshot() {
        BufferedImage image = new BufferedImage(getWidth(), getHeight(), BufferedImage.TYPE_INT_RGB);
        Graphics2D g2d = image.createGraphics();
        paint(g2d);
        g2d.dispose();
        try {
            ImageIO.write(image, "png", new File("screenshot.png"));
            System.out.println("Screenshot saved to screenshot.png");
            showMessage("Screenshot saved!");
        } catch (IOException ex) {
            ex.printStackTrace();
            showMessage("Screenshot failed!");
        }
    }
}
