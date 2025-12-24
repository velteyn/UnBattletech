package com.btech;

public class MechComponent {
    public String name;
    public int health;
    public int maxHealth;
    public boolean isCritical;

    public MechComponent(String name, int maxHealth) {
        this.name = name;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.isCritical = false;
    }

    public boolean isDestroyed() {
        return health <= 0;
    }

    public boolean isDamaged() {
        return health < maxHealth;
    }

    public void repair() {
        this.health = this.maxHealth;
        this.isCritical = false;
    }

    public void takeDamage(int amount) {
        this.health -= amount;
        if (this.health < 0) this.health = 0;
    }
    
    @Override
    public String toString() {
        return name + (isDestroyed() ? " (DESTROYED)" : "");
    }
}
