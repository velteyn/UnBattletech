package com.btech;

import javax.swing.*;
import java.awt.*;

public class Game extends JPanel {
    private Mech playerMech;
    private Mech enemyMech;
    private StockMarket market;
    private JTextArea logArea;
    
    // UI Components
    private SideBarPanel sideBar;
    private MainViewPanel mainView;
    private JPanel centerContainer;
    private TechScreen techScreen;
    private boolean inTechScreen = false;

    public Game() {
        setLayout(new BorderLayout());
        
        // Initialize Game Objects
        playerMech = new Mech("Chameleon", 50, 100);
        enemyMech = new Mech("Locust", 20, 40);
        market = new StockMarket();
        
        // Setup Panels
        sideBar = new SideBarPanel(playerMech);
        mainView = new MainViewPanel(playerMech, enemyMech);
        techScreen = new TechScreen(playerMech);
        
        // Center Container (Swaps between Map and Tech Screen)
        centerContainer = new JPanel(new CardLayout());
        centerContainer.add(mainView, "MAP");
        centerContainer.add(techScreen, "TECH");
        
        // Layout: Sidebar Left, View Center
        add(sideBar, BorderLayout.WEST);
        add(centerContainer, BorderLayout.CENTER);
        
        // Bottom Control Panel & Log
        JPanel bottomPanel = new JPanel(new BorderLayout());
        
        // Log Area (Combat Feedback)
        logArea = new JTextArea(6, 40);
        logArea.setEditable(false);
        logArea.setBackground(Color.BLACK);
        logArea.setForeground(Color.YELLOW);
        logArea.setFont(new Font("Monospaced", Font.PLAIN, 12));
        JScrollPane logScroll = new JScrollPane(logArea);
        bottomPanel.add(logScroll, BorderLayout.CENTER);
        
        // Buttons
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new GridLayout(2, 3));
        
        JButton moveBtn = new JButton("Move");
        JButton fireBtn = new JButton("Fire");
        JButton marketBtn = new JButton("Market");
        JButton scanBtn = new JButton("Scan");
        JButton techBtn = new JButton("Tech/Repair");
        
        moveBtn.addActionListener(e -> {
            playerMech.move(1, 1);
            log("Player moves to (" + playerMech.getX() + "," + playerMech.getY() + ")");
            mainView.repaint();
            enemyTurn();
        });
        
        fireBtn.addActionListener(e -> {
            playerMech.fireWeapon();
            log("Player fires weapons! Heat rises to " + playerMech.getStatus());
            enemyTurn();
        });
        
        marketBtn.addActionListener(e -> {
            market.update();
            log(market.getMarketStatus());
            sideBar.updateCash(1000 + Math.random() * 500); // Simulate cash change
        });
        
        techBtn.addActionListener(e -> {
            CardLayout cl = (CardLayout)(centerContainer.getLayout());
            if (inTechScreen) {
                cl.show(centerContainer, "MAP");
                inTechScreen = false;
                techBtn.setText("Tech/Repair");
            } else {
                cl.show(centerContainer, "TECH");
                inTechScreen = true;
                techBtn.setText("Back to Map");
            }
        });

        scanBtn.addActionListener(e -> {
             log("Scanning Target: " + enemyMech.getName());
             log(enemyMech.getArmorStatus());
             salvage(); // For testing
        });
        
        buttonPanel.add(moveBtn);
        buttonPanel.add(fireBtn);
        buttonPanel.add(scanBtn);
        buttonPanel.add(marketBtn);
        buttonPanel.add(techBtn);
        
        bottomPanel.add(buttonPanel, BorderLayout.EAST);
        add(bottomPanel, BorderLayout.SOUTH);
        
        log("Welcome to BattleTech: The Crescent Hawk's Inception.");
        log("Mission: Training Ground initialized.");
    }
    
    public void start() {
        // Game loop could go here
    }
    
    private void enemyTurn() {
        // Simple AI
        if (Math.random() > 0.5) {
            enemyMech.move((int)(Math.random() * 3) - 1, (int)(Math.random() * 3) - 1);
            log("Enemy moves.");
        } else {
            enemyMech.fireWeapon();
            // 30% chance to hit player
            if (Math.random() < 0.3) {
                 int damage = (int)(Math.random() * 5) + 1;
                 // Pick a random component to damage
                 java.util.List<MechComponent> parts = playerMech.getComponents();
                 if (!parts.isEmpty()) {
                     MechComponent target = parts.get((int)(Math.random() * parts.size()));
                     target.takeDamage(damage);
                     log("WARNING: Enemy hit your " + target.name + " for " + damage + " damage!");
                 }
                 sideBar.repaint();
            } else {
                log("Enemy fires and misses.");
            }
        }
        mainView.repaint();
    }
    
    private void salvage() {
        log("Salvage scan complete. No recoverable parts found.");
    }
    
    private void log(String msg) {
        logArea.append(msg + "\n");
        logArea.setCaretPosition(logArea.getDocument().getLength());
    }
}
