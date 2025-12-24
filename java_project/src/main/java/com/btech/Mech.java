package com.btech;

import java.util.ArrayList;
import java.util.List;

public class Mech {
    private String name;
    private int tonnage;
    private int heat;
    private int maxHeat;
    private int armor;
    private int maxArmor;
    private int x, y;
    
    // Detailed Components
    private List<MechComponent> components;
    private MechComponent engine;
    private MechComponent gyro;
    private MechComponent sensors;
    private List<MechComponent> heatSinks;

    public Mech(String name, int tonnage, int maxArmor) {
        this.name = name;
        this.tonnage = tonnage;
        this.maxArmor = maxArmor;
        this.armor = maxArmor;
        this.maxHeat = 30;
        this.heat = 0;
        
        this.components = new ArrayList<>();
        initializeComponents();
    }
    
    private void initializeComponents() {
        // Critical Systems
        engine = new MechComponent("Engine", 3);
        gyro = new MechComponent("Gyro", 2);
        sensors = new MechComponent("Sensors", 2);
        
        // Add to general list
        components.add(engine);
        components.add(gyro);
        components.add(sensors);
        
        // Standard Parts (based on screenshot)
        String[] parts = {
            "Intercooler", "Hip Unit", "Foot Unit", "Weather Seal", 
            "Foot Casting", "Foot Actuator", "Shoulder Joint", 
            "Leg Mainshaft", "Balance Strut", "Armor Plating", 
            "Elbow Actuator", "Myomer Bundle", "Antennae Mount", 
            "Collective Strut", "Stabilizer", "Torso Mainframe", 
            "Jump Jet Intake", "Gyro Housing", "Venting"
        };
        
        for (String part : parts) {
            components.add(new MechComponent(part, 1));
        }
        
        // Heat Sinks
        heatSinks = new ArrayList<>();
        for (int i = 0; i < 10; i++) {
            MechComponent hs = new MechComponent("Heat Sink", 1);
            heatSinks.add(hs);
            components.add(hs);
        }
    }
    
    public List<MechComponent> getComponents() {
        return components;
    }
    
    public MechComponent getEngine() { return engine; }
    public MechComponent getGyro() { return gyro; }
    public MechComponent getSensors() { return sensors; }
    public List<MechComponent> getHeatSinks() { return heatSinks; }
    
    public void move(int dx, int dy) {
        this.x += dx;
        this.y += dy;
        // Simple heat generation for movement
        this.heat += 1;
    }
    
    public void fireWeapon() {
        this.heat += 5;
        // Logic to damage target would go here
    }
    
    public void coolDown(int amount) {
        this.heat = Math.max(0, this.heat - amount);
    }
    
    public String getStatus() {
        return String.format("%s [Armor: %d/%d] [Heat: %d/%d] at (%d,%d)", 
            name, armor, maxArmor, heat, maxHeat, x, y);
    }

    public String getArmorStatus() {
        if (armor == maxArmor) return "Armor has not been injured.";
        if (armor <= 0) return "has lost all of its protective points.";
        double ratio = (double)armor / maxArmor;
        if (ratio > 0.75) return "Armor is in good condition.";
        if (ratio > 0.50) return "Armor is damaged.";
        if (ratio > 0.25) return "Armor is critically damaged!";
        return "Armor is failing!";
    }

    public int getX() { return x; }
    public int getY() { return y; }
    public String getName() { return name; }
    public int getArmor() { return armor; }
    public int getMaxArmor() { return maxArmor; }
}
