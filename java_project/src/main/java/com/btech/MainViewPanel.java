package com.btech;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.List;

public class MainViewPanel extends JPanel {
    private Mech playerMech;
    private Mech enemyMech;
    private List<Point> trees;
    private List<Point> rocks;

    public MainViewPanel(Mech player, Mech enemy) {
        this.playerMech = player;
        this.enemyMech = enemy;
        this.setBackground(new Color(34, 139, 34)); // Forest Green
        
        // Generate some random terrain
        trees = new ArrayList<>();
        rocks = new ArrayList<>();
        for (int i = 0; i < 20; i++) {
            trees.add(new Point((int)(Math.random() * 600), (int)(Math.random() * 600)));
            rocks.add(new Point((int)(Math.random() * 600), (int)(Math.random() * 600)));
        }
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        
        // Draw Terrain
        g.setColor(new Color(0, 100, 0)); // Dark Green for trees
        for (Point p : trees) {
            g.fillOval(p.x, p.y, 30, 30);
        }
        
        g.setColor(Color.GRAY);
        for (Point p : rocks) {
            g.fillRect(p.x, p.y, 20, 20);
        }
        
        // Draw Player Mech (Blue)
        g.setColor(Color.BLUE);
        // Simple shape for Mech: Body + Arms + Legs
        int px = playerMech.getX() * 10 + 300; // Center offset
        int py = playerMech.getY() * 10 + 300;
        
        // Draw Mech Sprite (Placeholder)
        g.fillRect(px, py, 20, 30); // Torso
        g.fillRect(px - 10, py + 5, 10, 20); // Left Arm
        g.fillRect(px + 20, py + 5, 10, 20); // Right Arm
        g.fillRect(px, py + 30, 8, 20); // Left Leg
        g.fillRect(px + 12, py + 30, 8, 20); // Right Leg
        
        g.setColor(Color.WHITE);
        g.drawString(playerMech.getName(), px - 10, py - 5);

        // Draw Enemy Mech (Red)
        g.setColor(Color.RED);
        int ex = enemyMech.getX() * 10 + 300;
        int ey = enemyMech.getY() * 10 + 300;
        g.fillRect(ex, ey, 20, 30);
        g.drawString(enemyMech.getName(), ex - 10, ey - 5);
        
        // Draw Grid Overlay (optional, subtle)
        g.setColor(new Color(0, 0, 0, 50));
        for (int i = 0; i < getWidth(); i+=40) {
            g.drawLine(i, 0, i, getHeight());
        }
        for (int i = 0; i < getHeight(); i+=40) {
            g.drawLine(0, i, getWidth(), i);
        }
    }
}
