using Godot;
using BattleTechCHI.Data;
using BattleTechCHI.Core;

namespace BattleTechCHI.BLD;

/// <summary>
/// Dispatcher per fn1CD3_0004: 47 casi (0x01-0x2F) che gestiscono
/// tutte le interazioni con edifici e personaggi.
/// Chiamato dall'opcode BLD 0xF5 (SHOP_DISPATCH).
/// </summary>
public static partial class Fn1CD3Dispatcher
{
    private static GameState _state = null!;
    public static void Init(GameState state) => _state = state;

    public static void Dispatch(byte caseVal)
    {
        GD.Print($"  fn1CD3 case 0x{caseVal:X2}");
        switch (caseVal)
        {
            case 0x01: EnterBuilding(); break;
            case 0x02: ShowGreeting(); break;
            case 0x03: ExitBuilding(); break;
            case 0x04: OpenMenu(); break;
            case 0x05: C618Increment(); break;
            case 0x06: C618Decrement(); break;
            case 0x07: BuyItem(); break;
            case 0x08: SellItem(); break;
            case 0x09: HealPlayer(); break;
            case 0x0A: RepairMech(); break;
            case 0x0B: GarageService(); break;
            case 0x0C: CloseAction(); break;
            case 0x0D: CombatEncounter(); break;
            case 0x0E: EquipSlot1(); break;
            case 0x0F: EquipSlot2(); break;
            case 0x10: EquipSlot3(); break;
            case 0x11: EquipSlot4(); break;
            case 0x12: EquipSlot5(); break;
            case 0x13: EquipSlot6(); break;
            case 0x14: UnequipSlot(); break;
            case 0x15: EquipSlotAlt5(); break;
            case 0x16: EquipSlotAlt6(); break;
            case 0x17: RefreshDisplay(); break;
            case 0x18: UpdateEquipment(); break;
            case 0x19: SetFlagD450(); break;
            case 0x1A: SetFlagD451(); break;
            case 0x1B: PartyAdd(); break;
            case 0x1C: PartyRemove(); break;
            case 0x1D: OpenChest(); break;
            case 0x1E: TakeItem(); break;
            case 0x1F: GiveItem(); break;
            case 0x20: CheckParty(); break;
            case 0x21: CheckTraining(); break;
            case 0x22: CheckState(); break;
            case 0x23: SetMood(); break;
            case 0x24: PlayAnimation(); break;
            case 0x25: SoundEffect(); break;
            case 0x26: Acknowledge(); break;
            case 0x27: Decline(); break;
            case 0x28: Trade(); break;
            case 0x29: Barter(); break;
            case 0x2A: Information(); break;
            case 0x2B: SpecialAction(); break;
            case 0x2C: QuestProgress(); break;
            case 0x2D: CheckItem(); break;
            case 0x2E: RemoveItem(); break;
            case 0x2F: EndInteraction(); break;
            default: GD.Print($"    unknown case 0x{caseVal:X2}"); break;
        }
    }

    static void EnterBuilding() => GD.Print("    ENTER_BUILDING: load BLD, init viewport");
    static void ShowGreeting() => GD.Print("    SHOW_GREETING");
    static void ExitBuilding() { GD.Print("    EXIT_BUILDING"); _state.Mode = GameMode.WorldMap; }
    static void OpenMenu() => GD.Print("    OPEN_MENU: party/tech/star/stock/stat");

    static void C618Increment()
    {
        GD.Print("    C618++ (next shop slot)");
        _state.StateArray[0x14] = (byte)((_state.StateArray[0x14] + 1) % 3);
    }
    static void C618Decrement()
    {
        GD.Print("    C618-- (prev shop slot)");
        int v = _state.StateArray[0x14] - 1;
        _state.StateArray[0x14] = (byte)(v < 0 ? 2 : v);
    }

    static void BuyItem()
    {
        GD.Print("    BUY_ITEM");
        int slot = _state.StateArray[0x14];
        int item = _state.StateArray[0x18 + slot];
        if (item == 0) return;
        int price = item * 125 + 75;
        if (_state.Credits >= price)
        {
            _state.Credits -= price;
            if (item < _state.InventoryQuantities.Length)
                _state.InventoryQuantities[item]++;
            GD.Print($"    bought type {item} for {price}, credits={_state.Credits}");
        }
    }

    static void SellItem()
    {
        GD.Print("    SELL_ITEM");
        int slot = _state.StateArray[0x14];
        int item = _state.StateArray[0x18 + slot];
        if (item > 0 && _state.InventoryQuantities[item] > 0)
        {
            _state.InventoryQuantities[item]--;
            _state.Credits += item * 125 + 75;
        }
    }

    static void HealPlayer()
    {
        GD.Print("    HEAL_PLAYER (cost 50)");
        if (_state.Credits >= 50)
        {
            _state.Credits -= 50;
            for (int i = 0; i < 4; i++) _state.UnitStatus[i] = 1;
        }
    }

    static void RepairMech() => GD.Print("    REPAIR_MECH (Tech Screen)");
    static void GarageService() { GD.Print("    GARAGE_SERVICE"); if (_state.Credits >= 100) _state.Credits -= 100; }
    static void CloseAction() => GD.Print("    CLOSE_ACTION");
    static void CombatEncounter() { GD.Print("    COMBAT_ENCOUNTER!"); _state.Mode = GameMode.Combat; }

    static void EquipSlot1() => EquipGeneric(0);
    static void EquipSlot2() => EquipGeneric(1);
    static void EquipSlot3() => EquipGeneric(2);
    static void EquipSlot4() => EquipGeneric(3);
    static void EquipSlot5() => EquipGeneric(4);
    static void EquipSlot6() => EquipGeneric(5);
    static void UnequipSlot() => GD.Print("    UNEQUIP");
    static void EquipSlotAlt5() => EquipGeneric(4);
    static void EquipSlotAlt6() => EquipGeneric(5);

    static void EquipGeneric(int slot)
    {
        if (slot >= 4) { if (_state.Credits < 500) return; _state.Credits -= 500; }
        GD.Print($"    equip slot {slot}");
    }

    static void RefreshDisplay() => GD.Print("    REFRESH");
    static void UpdateEquipment() => GD.Print("    UPDATE_EQUIP");

    static void SetFlagD450() { GD.Print("    TRAINING COMPLETE!"); _state.TrainingComplete = true; _state.StateArray[0x50] = 1; }
    static void SetFlagD451() { GD.Print("    MILESTONE!"); _state.Milestone = true; _state.StateArray[0x51] = 1; }

    static void PartyAdd() => GD.Print("    PARTY_ADD");
    static void PartyRemove() => GD.Print("    PARTY_REMOVE");
    static void OpenChest() => GD.Print("    OPEN_CHEST");
    static void TakeItem() => GD.Print("    TAKE_ITEM");
    static void GiveItem() => GD.Print("    GIVE_ITEM");
    static void CheckParty() => GD.Print("    CHECK_PARTY");
    static void CheckTraining() => GD.Print($"    CHECK_TRAINING: {_state.TrainingComplete}");
    static void CheckState() => GD.Print("    CHECK_STATE");
    static void SetMood() => GD.Print("    SET_MOOD");
    static void PlayAnimation() => GD.Print("    PLAY_ANIMATION");
    static void SoundEffect() => GD.Print("    SOUND_EFFECT");
    static void Acknowledge() => GD.Print("    ACK");
    static void Decline() => GD.Print("    DECLINE");
    static void Trade() => GD.Print("    TRADE");
    static void Barter() => GD.Print("    BARTER");
    static void Information() => GD.Print("    INFO");
    static void SpecialAction() => GD.Print("    SPECIAL_ACTION");

    static void QuestProgress()
    {
        GD.Print("    QUEST_PROGRESS");
        _state.StateArray[0x2C]++;
    }

    static void CheckItem()
    {
        GD.Print("    CHECK_ITEM");
        // Reads aD374[itemType], skips if zero
    }

    static void RemoveItem()
    {
        GD.Print("    REMOVE_ITEM");
        if (_state.InventoryQuantities.Length > 0)
            _state.InventoryQuantities[0] = 0;
    }

    static void EndInteraction() => GD.Print("    END_INTERACTION");
}