using System.Collections.Generic;

namespace BattleTechCHI.Data;

/// <summary>
/// Registry that maps BLD script names to their IShopInventory strategy.
/// The BLD interpreter resolves the strategy by BLD name and passes it
/// to the dispatcher for BuyItem/SellItem operations.
/// </summary>
public static class ShopRegistry
{
    private static readonly Dictionary<string, IShopInventory> _shops = new()
    {
        ["WEAPON"] = new WeaponShopInventory(),
        ["WEAPON2"] = new Weapon2ShopInventory(),
        ["ARMOR"] = new ArmorShopInventory(),
        ["COMSTAR"] = new ComStarShopInventory(),
        ["BARRACKS"] = new BarracksShopInventory(),
        ["LOUNGE"] = new LoungeShopInventory(),
        ["CITADEL"] = new CitadelShopInventory(),
        ["TRAINING"] = new TrainingShopInventory(),
        ["GARAGE"] = new GarageShopInventory(),
    };

    /// <summary>
    /// Returns the shop strategy for a given BLD name, or null if none.
    /// </summary>
    public static IShopInventory? Get(string bldName)
    {
        return _shops.GetValueOrDefault(bldName);
    }

    /// <summary>
    /// Returns true if the BLD name has a registered shop strategy.
    /// </summary>
    public static bool HasShop(string bldName) => _shops.ContainsKey(bldName);
}
