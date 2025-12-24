package com.btech;

import javax.swing.*;
import java.awt.*;

public class SideBarPanel extends JPanel {
    private Mech playerMech;
    private JLabel nameLabel;
    private JLabel cashLabel;
    private JPanel bdcPanel;

    public SideBarPanel(Mech playerMech) {
        this.playerMech = playerMech;
        this.setPreferredSize(new Dimension(200, 600));
        this.setBackground(Color.BLACK);
        this.setLayout(new BoxLayout(this, BoxLayout.Y_AXIS));
        this.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY, 4));

        // Spacer
        add(Box.createVerticalStrut(20));

        // Minimap Placeholder (Black Box)
        JPanel minimap = new JPanel();
        minimap.setBackground(Color.BLACK);
        minimap.setBorder(BorderFactory.createLineBorder(Color.WHITE));
        minimap.setMaximumSize(new Dimension(180, 150));
        add(minimap);
        
        add(Box.createVerticalStrut(20));

        // Pilot Info
        JPanel statusPanel = new JPanel();
        statusPanel.setLayout(new BoxLayout(statusPanel, BoxLayout.Y_AXIS));
        statusPanel.setBackground(Color.BLACK);
        statusPanel.setAlignmentX(Component.CENTER_ALIGNMENT);

        nameLabel = new JLabel("Jason");
        nameLabel.setForeground(Color.WHITE);
        nameLabel.setFont(new Font("Monospaced", Font.BOLD, 20));
        statusPanel.add(nameLabel);
        
        // BDC Bars (Damage Indicators)
        bdcPanel = new JPanel() {
            @Override
            protected void paintComponent(Graphics g) {
                super.paintComponent(g);
                drawArmorBar(g, 10, playerMech.getArmor(), playerMech.getMaxArmor(), "L.Arm");
                drawArmorBar(g, 35, playerMech.getArmor(), playerMech.getMaxArmor(), "Torso");
                drawArmorBar(g, 60, playerMech.getArmor(), playerMech.getMaxArmor(), "R.Arm");
                drawArmorBar(g, 85, playerMech.getArmor(), playerMech.getMaxArmor(), "Legs");
            }
        };
        bdcPanel.setBackground(Color.BLACK);
        bdcPanel.setMaximumSize(new Dimension(150, 100));
        statusPanel.add(bdcPanel);

        add(statusPanel);
        
        add(Box.createVerticalGlue());

        // C-Bills
        cashLabel = new JLabel("C-Bills: 100000");
        cashLabel.setForeground(Color.GREEN); // Classic terminal green
        cashLabel.setFont(new Font("Monospaced", Font.BOLD, 16));
        cashLabel.setAlignmentX(Component.CENTER_ALIGNMENT);
        add(cashLabel);
        
        add(Box.createVerticalStrut(20));
    }
    
    private void drawArmorBar(Graphics g, int x, int current, int max, String label) {
        int height = 80;
        int width = 15;
        
        // Background
        g.setColor(Color.DARK_GRAY);
        g.fillRect(x, 0, width, height);
        
        // Fill
        float ratio = (float)current / max;
        int fillHeight = (int)(height * ratio);
        
        if (ratio > 0.5) g.setColor(Color.GREEN);
        else if (ratio > 0.25) g.setColor(Color.YELLOW);
        else g.setColor(Color.RED);
        
        g.fillRect(x, height - fillHeight, width, fillHeight);
        
        // Label
        g.setColor(Color.WHITE);
        g.setFont(new Font("Arial", Font.PLAIN, 9));
        g.drawString(label.substring(0, 1), x + 4, height + 10);
    }

    public void updateCash(double amount) {
        cashLabel.setText(String.format("C-Bills: %.0f", amount));
    }
}
