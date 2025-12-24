package com.btech;

import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.util.List;

public class TechScreen extends JPanel {
    private Mech mech;
    private JList<MechComponent> partList;
    private JPanel schematicPanel;

    public TechScreen(Mech mech) {
        this.mech = mech;
        this.setLayout(new BorderLayout());
        this.setBackground(Color.BLACK);

        // Left: Component List
        partList = new JList<>(mech.getComponents().toArray(new MechComponent[0]));
        partList.setFont(new Font("Monospaced", Font.PLAIN, 14));
        partList.setForeground(Color.WHITE);
        partList.setBackground(Color.BLACK);
        partList.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        
        JScrollPane listScroller = new JScrollPane(partList);
        listScroller.setPreferredSize(new Dimension(250, 600));
        add(listScroller, BorderLayout.WEST);

        // Right: Schematic View
        schematicPanel = new JPanel() {
            @Override
            protected void paintComponent(Graphics g) {
                super.paintComponent(g);
                drawSchematic(g);
            }
        };
        schematicPanel.setBackground(Color.BLACK);
        add(schematicPanel, BorderLayout.CENTER);
        
        // Status Panel (Top Right overlay simulation)
        JPanel statusPanel = new JPanel();
        statusPanel.setLayout(new BoxLayout(statusPanel, BoxLayout.Y_AXIS));
        statusPanel.setOpaque(false);
        // Add Engine/Gyro/Sensor status indicators here
        
        // Listen for selection
        partList.addListSelectionListener(e -> {
            if (!e.getValueIsAdjusting()) {
                schematicPanel.repaint(); // Redraw to highlight selected part
                MechComponent selected = partList.getSelectedValue();
                if (selected != null && selected.isDamaged()) {
                     showRepairDialog(selected);
                }
            }
        });
    }

    private void showRepairDialog(MechComponent component) {
        String message = "";
        if (component.name.contains("Structure") || component.name.contains("Armor")) {
             message += "This 'Mech has had some of its internal structure damaged.\n";
             message += "If you want to fix any weapons or heat sinks, you have to have structure to mount them on.\n\n";
        }
         
         int cost = component.maxHealth * 100; // Mock cost calculation
         int playerCash = 100000; // Mock player cash
        
        message += "If you want the structure fixed, it's going to cost " + cost + " C-bills.\n";
        message += "You've got " + playerCash + " C-bills.\n";
        message += "Want it fixed?";

        int choice = JOptionPane.showConfirmDialog(this, message, "Tech/Repair", JOptionPane.YES_NO_OPTION);
        if (choice == JOptionPane.YES_OPTION) {
            if (playerCash >= cost) {
                component.repair();
                JOptionPane.showMessageDialog(this, "Repair successful!");
                partList.repaint();
            } else {
                 JOptionPane.showMessageDialog(this, "We fixed as much as you could afford,\nbut you ran out of cash before the job was done.");
            }
        }
    }

    private void drawSchematic(Graphics g) {
        // Draw Grid Background
        g.setColor(new Color(0, 0, 139)); // Dark Blue
        for (int i = 0; i < getWidth(); i+=20) g.drawLine(i, 0, i, getHeight());
        for (int i = 0; i < getHeight(); i+=20) g.drawLine(0, i, getWidth(), i);

        int cx = getWidth() / 2;
        int cy = getHeight() / 2;

        // Draw Mech Sprite (if available)
        if (!GameGraphics.MECH_SPRITES.isEmpty()) {
            // Use first sprite for demo, or cycle them if we implement animation
            BufferedImage sprite = GameGraphics.MECH_SPRITES.get(0);
            int scale = 4;
            int sx = cx - (sprite.getWidth() * scale) / 2;
            int sy = cy - (sprite.getHeight() * scale) / 2;
            
            g.drawImage(sprite, sx, sy, sprite.getWidth() * scale, sprite.getHeight() * scale, null);
        } else {
            // Draw Mech Wireframe (Simplified)
            g.setColor(Color.LIGHT_GRAY);
            
            // Torso
            g.drawRect(cx - 40, cy - 60, 80, 100);
            // Head
            g.drawRect(cx - 15, cy - 90, 30, 30);
            // Arms
            g.drawRect(cx - 70, cy - 60, 30, 80); // Left
            g.drawRect(cx + 40, cy - 60, 30, 80); // Right
            // Legs
            g.drawRect(cx - 40, cy + 40, 35, 100); // Left
            g.drawRect(cx + 5, cy + 40, 35, 100); // Right
        }
        
        // Draw Border (if available)
        if (GameGraphics.BORDER_IMAGE != null) {
            // Top Border
            g.drawImage(GameGraphics.BORDER_IMAGE, 0, 0, getWidth(), GameGraphics.BORDER_IMAGE.getHeight() * 2, null);
            // Bottom Border
            g.drawImage(GameGraphics.BORDER_IMAGE, 0, getHeight() - GameGraphics.BORDER_IMAGE.getHeight() * 2, getWidth(), GameGraphics.BORDER_IMAGE.getHeight() * 2, null);
        }

        // Highlight Selected Part (Logic would map parts to coordinates)
        MechComponent selected = partList.getSelectedValue();
        if (selected != null) {
            g.setColor(Color.YELLOW);
            g.drawString("Selected: " + selected.name, 20, 20);
            
            // Highlight a generic box for now to show interaction
            if (selected.name.contains("Leg")) {
                g.fillRect(cx - 40, cy + 80, 80, 10); // Highlight leg area
            } else if (selected.name.contains("Engine")) {
                g.fillRect(cx - 20, cy - 40, 40, 40); // Center torso
            }
        }
        
        // Draw Status Blocks (Top Right)
        drawStatusBlock(g, "ENGINE", mech.getEngine(), getWidth() - 150, 20);
        drawStatusBlock(g, "GYRO", mech.getGyro(), getWidth() - 150, 50);
        drawStatusBlock(g, "SENSORS", mech.getSensors(), getWidth() - 150, 80);
    }
    
    private void drawStatusBlock(Graphics g, String label, MechComponent comp, int x, int y) {
        g.setColor(Color.YELLOW);
        g.drawString(label, x, y);
        g.setColor(comp.isDestroyed() ? Color.RED : Color.GREEN);
        g.fillRect(x + 80, y - 10, 20, 10);
    }
}
