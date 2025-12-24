package com.btech;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;

public class VillagePanel extends JPanel implements ActionListener {
    private int playerX = 512; // Start in middle of map
    private int playerY = 512;
    private final int SPEED = 4;
    private Timer timer;
    private boolean up, down, left, right;
    
    // Viewport size
    private final int VIEW_WIDTH = 320; // Original resolution
    private final int VIEW_HEIGHT = 200;
    
    // Scaling for display
    private float displayScale = 2.0f;

    private Runnable onExit;

    public VillagePanel(Runnable onExit) {
        this.onExit = onExit;
        setFocusable(true);
        setBackground(Color.BLACK);
        
        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                switch (e.getKeyCode()) {
                    case KeyEvent.VK_UP -> up = true;
                    case KeyEvent.VK_DOWN -> down = true;
                    case KeyEvent.VK_LEFT -> left = true;
                    case KeyEvent.VK_RIGHT -> right = true;
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
                switch (e.getKeyCode()) {
                    case KeyEvent.VK_UP -> up = false;
                    case KeyEvent.VK_DOWN -> down = false;
                    case KeyEvent.VK_LEFT -> left = false;
                    case KeyEvent.VK_RIGHT -> right = false;
                }
            }
        });

        timer = new Timer(16, this); // ~60 FPS
        timer.start();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (up) playerY -= SPEED;
        if (down) playerY += SPEED;
        if (left) playerX -= SPEED;
        if (right) playerX += SPEED;
        
        // Bounds checking
        if (GameGraphics.VILLAGE_MAP != null) {
            int mapW = GameGraphics.VILLAGE_MAP.getWidth();
            int mapH = GameGraphics.VILLAGE_MAP.getHeight();
            
            // Trigger exit if walking off map
            if (playerX < 0 || playerY < 0 || playerX > mapW || playerY > mapH) {
                if (onExit != null) {
                    timer.stop();
                    onExit.run();
                }
                return;
            }
        }

        repaint();
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g;
        
        // Adjust scale to fit window if needed, or fixed scale
        int w = getWidth();
        int h = getHeight();
        
        // Keep aspect ratio 320x200
        float scaleX = (float)w / VIEW_WIDTH;
        float scaleY = (float)h / VIEW_HEIGHT;
        displayScale = Math.min(scaleX, scaleY);
        
        g2d.scale(displayScale, displayScale);
        
        if (GameGraphics.VILLAGE_MAP != null) {
            // Calculate viewport top-left
            int viewX = playerX - (VIEW_WIDTH / 2);
            int viewY = playerY - (VIEW_HEIGHT / 2);
            
            // Clamp viewport
            int mapW = GameGraphics.VILLAGE_MAP.getWidth();
            int mapH = GameGraphics.VILLAGE_MAP.getHeight();
            
            // Ensure viewport doesn't go out of bounds
            if (viewX < 0) viewX = 0;
            if (viewY < 0) viewY = 0;
            if (viewX + VIEW_WIDTH > mapW) viewX = mapW - VIEW_WIDTH;
            if (viewY + VIEW_HEIGHT > mapH) viewY = mapH - VIEW_HEIGHT;
            
            // Handle case where map is smaller than viewport
            if (mapW < VIEW_WIDTH) viewX = -(VIEW_WIDTH - mapW) / 2;
            if (mapH < VIEW_HEIGHT) viewY = -(VIEW_HEIGHT - mapH) / 2;

            // Draw map section
            // Use drawImage with source coordinates to avoid getSubimage exceptions
            int dx1 = 0;
            int dy1 = 0;
            int dx2 = VIEW_WIDTH;
            int dy2 = VIEW_HEIGHT;
            
            int sx1 = viewX;
            int sy1 = viewY;
            int sx2 = viewX + VIEW_WIDTH;
            int sy2 = viewY + VIEW_HEIGHT;
            
            g2d.drawImage(GameGraphics.VILLAGE_MAP, dx1, dy1, dx2, dy2, sx1, sy1, sx2, sy2, null);
            
            // Draw player relative to viewport
            if (GameGraphics.PLAYER_SPRITE != null) {
                int pW = GameGraphics.PLAYER_SPRITE.getWidth();
                int pH = GameGraphics.PLAYER_SPRITE.getHeight();
                int drawX = playerX - viewX - (pW / 2);
                int drawY = playerY - viewY - (pH / 2);
                g2d.drawImage(GameGraphics.PLAYER_SPRITE, drawX, drawY, null);
            }
        } else {
            g2d.setColor(Color.WHITE);
            g2d.drawString("Loading Map...", 10, 20);
        }
        
        // Reset scale for UI
        g2d.scale(1/displayScale, 1/displayScale);
        g2d.setColor(Color.GREEN);
        g2d.drawString("Pos: " + playerX + "," + playerY, 10, 20);
    }
}
