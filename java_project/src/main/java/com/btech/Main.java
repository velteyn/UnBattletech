package com.btech;

import javax.swing.*;
import java.awt.*;

public class Main {
    public static void main(String[] args) {
        // Safety Watchdog: Exit after 5 minutes to prevent "process going on forever"
        Thread watchdog = new Thread(() -> {
            try {
                Thread.sleep(5 * 60 * 1000); // 5 minutes
                System.out.println("Watchdog: Time limit reached. Exiting.");
                System.exit(0);
            } catch (InterruptedException e) {
                // Ignore
            }
        });
        watchdog.setDaemon(true);
        watchdog.start();

        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("BattleTech: The Crescent Hawk's Inception (Recreation)");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(800, 600);
            
            // Start with Startup Sequence
            StartupSequence startup = new StartupSequence(() -> {
                // When startup is done, switch to Game Panel
                frame.remove(0); // Remove startup panel
                
                GeneralMapPanel gamePanel = new GeneralMapPanel();
                frame.add(gamePanel);
                frame.revalidate();
                gamePanel.requestFocus();
            });
            
            frame.add(startup);
            
            frame.setVisible(true);
        });
    }
}
