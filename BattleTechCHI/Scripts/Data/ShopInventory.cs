namespace BattleTechCHI.Data;

public interface IShopInventory
{
    string ShopName { get; }
    int SlotCount { get; }
    int GetItemType(int slot);
    int GetBuyPrice(int slot);
    int GetSellPrice(int slot);
    string GetItemName(int slot);
}

/// <summary>
/// Armour shop (ARMOR.BLD): sells infantry body armour.
/// Actual item types from original game — InfantryArmour enum.
/// Pricing uses original formula: item_type × 125 + 75.
/// </summary>
public class ArmorShopInventory : IShopInventory
{
    public string ShopName => "Armor Shop";
    public int SlotCount => 5;

    private static readonly (int type, string name, int ap)[] Items = {
        (1, "Flak Vest",      25),
        (2, "Flak Suit",      40),
        (3, "Light Env Suit", 30),
        (4, "Heavy Env Suit", 50),
        (5, "Ablative",       50),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type * 125 + 75 : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Weapon shop (WEAPON.BLD / WEAPON2.BLD): sells mech-grade weapons.
/// MechComponent IDs 16-34 from original game.
/// </summary>
public class WeaponShopInventory : IShopInventory
{
    public string ShopName => "Weapons Shop";
    public int SlotCount => 6;

    private static readonly (int type, string name)[] Items = {
        (16, "Small Laser"),
        (17, "Medium Laser"),
        (18, "Large Laser"),
        (19, "PPC"),
        (24, "Machine Gun"),
        (25, "Flamer"),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type * 125 + 75 : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Weapon shop 2 (WEAPON2.BLD): missile and ballistic weapons.
/// </summary>
public class Weapon2ShopInventory : IShopInventory
{
    public string ShopName => "Weapons Shop";
    public int SlotCount => 6;

    private static readonly (int type, string name)[] Items = {
        (20, "AC/2"),
        (21, "AC/5"),
        (22, "AC/10"),
        (26, "LRM 5"),
        (30, "SRM 2"),
        (31, "SRM 4"),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type * 125 + 75 : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// ComStar station (COMSTAR.BLD): electronics and information.
/// </summary>
public class ComStarShopInventory : IShopInventory
{
    public string ShopName => "ComStar Station";
    public int SlotCount => 3;

    private static readonly (int type, string name, int price)[] Items = {
        (37, "Com Scanner",       2000),
        (38, "Targeting Computer", 10000),
        (39, "ECM Suite",         18000),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].price : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Barracks (BARRACKS.BLD): personal equipment and medical supplies.
/// </summary>
public class BarracksShopInventory : IShopInventory
{
    public string ShopName => "Barracks";
    public int SlotCount => 3;

    private static readonly (int type, string name, int price)[] Items = {
        (40, "Medipac",       150),
        (41, "Field Rations", 50),
        (42, "Survival Kit",  500),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].price : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Lounge (LOUNGE.BLD): information and recreation.
/// </summary>
public class LoungeShopInventory : IShopInventory
{
    public string ShopName => "Lounge";
    public int SlotCount => 3;

    private static readonly (int type, string name, int price)[] Items = {
        (43, "Drink",    10),
        (44, "News Disk", 100),
        (45, "Local Map", 250),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].price : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Citadel (CITADEL.BLD): story hub — no commerce.
/// </summary>
public class CitadelShopInventory : IShopInventory
{
    public string ShopName => "Citadel";
    public int SlotCount => 3;
    public int GetItemType(int slot) => 0;
    public int GetBuyPrice(int slot) => 0;
    public int GetSellPrice(int slot) => 0;
    public string GetItemName(int slot) => "---";
}

/// <summary>
/// Training Center (TRAINING.BLD): tutorial — no commerce.
/// </summary>
public class TrainingShopInventory : IShopInventory
{
    public string ShopName => "Training Center";
    public int SlotCount => 3;
    public int GetItemType(int slot) => 0;
    public int GetBuyPrice(int slot) => 0;
    public int GetSellPrice(int slot) => 0;
    public string GetItemName(int slot) => "---";
}

/// <summary>
/// Garage / Mechit-Lube (GARAGE.BLD): repair parts and service.
/// </summary>
public class GarageShopInventory : IShopInventory
{
    public string ShopName => "Mechit-Lube";
    public int SlotCount => 3;

    private static readonly (int type, string name, int price)[] Items = {
        (46, "Oil Can",      25),
        (47, "Filter Pack",  75),
        (48, "Actuator Kit", 500),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].price : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Clothing store (CLOTHES.BLD): civilian clothes.
/// </summary>
public class ClothesShopInventory : IShopInventory
{
    public string ShopName => "Clothing Store";
    public int SlotCount => 3;

    private static readonly (int type, string name, int price)[] Items = {
        (49, "Civilian Clothes", 300),
        (50, "Formal Wear",      800),
        (51, "Work Uniform",     150),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].price : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}

/// <summary>
/// Hospital (HOSPITAL.BLD): medical services, sells medipacs.
/// </summary>
public class HospitalShopInventory : IShopInventory
{
    public string ShopName => "Hospital";
    public int SlotCount => 3;

    private static readonly (int type, string name, int price)[] Items = {
        (52, "Medipac",      150),
        (53, "Antidote Kit", 500),
        (54, "Surgical Kit", 2000),
    };

    public int GetItemType(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].type : 0;
    public int GetBuyPrice(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].price : 0;
    public int GetSellPrice(int slot) => GetBuyPrice(slot) / 2;
    public string GetItemName(int slot) => slot >= 0 && slot < Items.Length ? Items[slot].name : "---";
}
