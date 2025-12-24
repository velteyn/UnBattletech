package com.btech;

import javax.swing.*;
import java.awt.*;

public class Main {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("BattleTech: The Crescent Hawk's Inception (Recreation)");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(800, 600);
            
            // Direct to GeneralMapPanel for animation testing
            GeneralMapPanel generalMap = new GeneralMapPanel();
            frame.add(generalMap);
            
            frame.setVisible(true);
            generalMap.requestFocus();
        });
    }
}
