package com.btech;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;

public class StockMarket {
    private Map<String, Double> stocks = new HashMap<>();
    private Map<String, Integer> portfolio = new HashMap<>();
    private double cBills = 1000.0;
    private Random random = new Random();
    
    public StockMarket() {
        stocks.put("DefHes", 100.0); // Defiance Industries
        stocks.put("NasDiv", 50.0);  // Nashan Diversified
        stocks.put("BakPhar", 25.0); // Baker Pharmaceuticals
    }
    
    public void update() {
        for (String symbol : stocks.keySet()) {
            double change = (random.nextDouble() - 0.5) * 5.0; // +/- 2.5 change
            double newVal = Math.max(1.0, stocks.get(symbol) + change);
            stocks.put(symbol, newVal);
        }
    }
    
    public String getMarketStatus() {
        StringBuilder sb = new StringBuilder("Stock Market:\n");
        for (Map.Entry<String, Double> entry : stocks.entrySet()) {
            sb.append(String.format("%s: %.2f C-Bills\n", entry.getKey(), entry.getValue()));
        }
        sb.append(String.format("Cash: %.2f C-Bills", cBills));
        return sb.toString();
    }
    
    public void buy(String symbol, int amount) {
        if (!stocks.containsKey(symbol)) return;
        double cost = stocks.get(symbol) * amount;
        if (cBills >= cost) {
            cBills -= cost;
            portfolio.put(symbol, portfolio.getOrDefault(symbol, 0) + amount);
        }
    }
}
