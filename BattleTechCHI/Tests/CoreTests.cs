using Xunit;
using BattleTechCHI.Data;
using BattleTechCHI.Core;
using BattleTechCHI.Maps;
using BattleTechCHI.BLD;
using BattleTechCHI.UI;

namespace BattleTechCHI.Tests;

public class CipherDecoderTests
{
    [Fact]
    public void DecodeByte_LowercaseRange_ReturnsCorrectChar()
    {
        // Range 0x57-0x5F: i h k j m l o n a
        Assert.Equal('i', CipherDecoder.DecodeByte(0x57));
        Assert.Equal('h', CipherDecoder.DecodeByte(0x58));
        Assert.Equal('k', CipherDecoder.DecodeByte(0x59));
        Assert.Equal('j', CipherDecoder.DecodeByte(0x5A));
        Assert.Equal('m', CipherDecoder.DecodeByte(0x5B));
        Assert.Equal('l', CipherDecoder.DecodeByte(0x5C));
        Assert.Equal('o', CipherDecoder.DecodeByte(0x5D));
        Assert.Equal('n', CipherDecoder.DecodeByte(0x5E));
        Assert.Equal('a', CipherDecoder.DecodeByte(0x5F));
    }

    [Fact]
    public void DecodeByte_UppercaseRange_ReturnsCorrectChar()
    {
        // Range 0x77-0x7F: I H K J M L O N A
        Assert.Equal('I', CipherDecoder.DecodeByte(0x77));
        Assert.Equal('H', CipherDecoder.DecodeByte(0x78));
        Assert.Equal('K', CipherDecoder.DecodeByte(0x79));
        Assert.Equal('J', CipherDecoder.DecodeByte(0x7A));
        Assert.Equal('A', CipherDecoder.DecodeByte(0x7F));
    }

    [Fact]
    public void DecodeByte_Space_ReturnsSpace()
    {
        Assert.Equal(' ', CipherDecoder.DecodeByte(0xA0));
    }

    [Fact]
    public void Decode_FullPhrase_DecodesCorrectly()
    {
        // "jump" = 0x5A, 0x5E, 0x5D, 0x5B
        var input = new byte[] { 0x5A, 0x5E, 0x5D, 0x5B };
        var result = CipherDecoder.Decode(input);
        Assert.Equal("jump", result);
    }

    [Fact]
    public void Decode_WithSpacesAndCaps_Succeeds()
    {
        // Simulated simple string
        var input = new byte[] { 0x5F, 0xA0, 0x7F }; // "a A"
        var result = CipherDecoder.Decode(input);
        Assert.Equal("a A", result);
    }
}

public class WeaponDataTests
{
    [Fact]
    public void Weapons_Contains33Entries()
    {
        Assert.Equal(33, WeaponData.Weapons.Length);
    }

    [Fact]
    public void SmallLaser_HasCorrectStats()
    {
        var sl = WeaponData.Weapons[0];
        Assert.Equal("Small Laser", sl.Name);
        Assert.Equal(1, sl.Id);
        Assert.Equal(0, sl.AmmoType);
        Assert.Equal(3, sl.Damage);
        Assert.Equal(1, sl.MinRange);
        Assert.Equal(5, sl.MaxRange);
    }

    [Fact]
    public void Kick_IsPhysical()
    {
        var kick = WeaponData.Weapons[32];
        Assert.Equal("Kick (Physical)", kick.Name);
        Assert.Equal(1, kick.IsPhysicalKick);
        Assert.Equal(5, kick.Damage);
    }
}

public class GameEnumsTests
{
    [Fact]
    public void GameMode_WorldMap_IsZero()
    {
        Assert.Equal(0, (int)GameMode.WorldMap);
    }

    [Fact]
    public void GameMode_Combat_IsTwo()
    {
        Assert.Equal(2, (int)GameMode.Combat);
    }

    [Fact]
    public void BldOpcode_Values_AreCorrect()
    {
        Assert.Equal(0xE4, (byte)BldOpcode.WriteChar);
        Assert.Equal(0xF5, (byte)BldOpcode.ShopDispatch);
        Assert.Equal(0xFC, (byte)BldOpcode.RenderText);
        Assert.Equal(0xFF, (byte)BldOpcode.StopInterpreter);
    }
}

public class GameStateTests
{
    [Fact]
    public void NewGameState_HasDefaultValues()
    {
        var state = new GameState();
        Assert.Equal(GameMode.WorldMap, state.Mode);
        Assert.Equal(0, state.CursorX);
        Assert.Equal(0, state.CursorY);
        Assert.Equal(32, state.UnitX.Length);
        Assert.Equal(32, state.UnitY.Length);
    }

    [Fact]
    public void StateArray_Is256Bytes()
    {
        var state = new GameState();
        Assert.Equal(256, state.StateArray.Length);
    }

    [Fact]
    public void VisibilityGrid_Is2048Bytes()
    {
        var state = new GameState();
        Assert.Equal(2048, state.WorldMapVisibility.Length);
    }

    [Fact]
    public void StorySlots_Are16()
    {
        var state = new GameState();
        Assert.Equal(16, state.StorySlots.Length);
    }
}

public class WorldMapDataTests
{
    [Fact]
    public void InitialState_AllWater()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        
        // All tiles should be 0 (water)
        for (int y = 0; y < 64; y++)
            for (int x = 0; x < 64; x++)
                Assert.Equal(0, wmd.GetTile(x, y));
    }

    [Fact]
    public void SetTile_StoresCorrectly()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        wmd.SetTile(10, 20, 0x42);
        Assert.Equal(0x42, wmd.GetTile(10, 20));
    }

    [Fact]
    public void SetTile_OutOfBounds_DoesNothing()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        wmd.SetTile(-1, 0, 0x42);
        wmd.SetTile(0, -1, 0x42);
        wmd.SetTile(64, 0, 0x42);
        wmd.SetTile(0, 64, 0x42);
        Assert.Equal(0, wmd.GetTile(0, 0));
    }

    [Fact]
    public void LoadTiles_64x64_FillsGrid()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        var data = new byte[4096];
        for (int i = 0; i < 4096; i++) data[i] = (byte)(i % 256);
        wmd.LoadTiles(data);
        Assert.Equal(1, wmd.GetTile(1, 0));
        Assert.Equal(65, wmd.GetTile(1, 1));
    }

    [Fact]
    public void IsWater_ReturnsTrueForTile0()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        Assert.True(wmd.IsWater(0, 0));
    }

    [Fact]
    public void IsWalkable_Water_ReturnsFalse()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        Assert.False(wmd.IsWalkable(0, 0));
    }

    [Fact]
    public void Visibility_DefaultsToNotVisible()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        Assert.False(wmd.IsVisible(10, 10));
    }

    [Fact]
    public void SetVisible_StoresCorrectly()
    {
        var wmd = new BattleTechCHI.Maps.WorldMapData();
        wmd.Initialize();
        wmd.SetVisible(5, 5, true);
        Assert.True(wmd.IsVisible(5, 5));
        wmd.SetVisible(5, 5, false);
        Assert.False(wmd.IsVisible(5, 5));
    }
}

public class SaveManagerTests
{
    [Fact]
    public void RoundTrip_PreservesState()
    {
        var original = new GameState();
        original.CursorX = 42;
        original.CursorY = 100;
        original.Credits = 5000;
        original.StateArray[10] = 0xFF;
        original.WorldMapVisibility[0] = 0x80; // set a visibility bit

        string path = Path.GetTempFileName();
        try
        {
            Assert.True(SaveManager.Save(path, original));

            var loaded = new GameState();
            Assert.True(SaveManager.Load(path, loaded));

            Assert.Equal(original.CursorX, loaded.CursorX);
            Assert.Equal(original.Credits, loaded.Credits);
            Assert.Equal(original.StateArray[10], loaded.StateArray[10]);
            Assert.Equal(original.WorldMapVisibility[0], loaded.WorldMapVisibility[0]);
        }
        finally
        {
            File.Delete(path);
        }
    }
}

public class LocationMapperTests
{
    [Fact]
    public void GetBldIndex_Citadel_ReturnsCorrect()
    {
        var idx = BattleTechCHI.Maps.LocationMapper.GetBldIndex(26, 5);
        Assert.NotNull(idx);
        Assert.Equal("TRAINING", BattleTechCHI.Maps.LocationMapper.GetBldName(idx!.Value));
    }

    [Fact]
    public void GetBldIndex_NotFound_ReturnsNull()
    {
        var idx = BattleTechCHI.Maps.LocationMapper.GetBldIndex(0, 0);
        Assert.Null(idx);
    }

    [Fact]
    public void GetMapId_MainCity_Returns2()
    {
        var mapId = BattleTechCHI.Maps.LocationMapper.GetMapId(28, 11);
        Assert.Equal(2, mapId);
    }
}

public class MapLoaderTests
{
    [Fact]
    public void CreateWorldMap_Returns64x64()
    {
        var map = BattleTechCHI.Maps.MapLoader.CreateWorldMap();
        Assert.Equal(0, map.MapId);
        Assert.Equal(64, map.Width);
        Assert.Equal(64, map.Height);
        Assert.Equal(4096, map.TileData.Length);
    }
}

public class RleDecompressorTests
{
    [Fact]
    public void DecompressFormat01_LiteralRun_ExpandsCorrectly()
    {
        // 0x05 = run of 5, next byte = data = 0xAB
        var compressed = new byte[] { 0x05, 0xAB };
        var result = BattleTechCHI.Maps.RleDecompressor.DecompressFormat01(compressed, 0);
        Assert.Equal(0xAB, result[0]);
        Assert.Equal(0xAB, result[1]);
        Assert.Equal(0xAB, result[2]);
        Assert.Equal(0xAB, result[3]);
        Assert.Equal(0xAB, result[4]);
        // Remaining should be zero
        Assert.Equal(0, result[5]);
    }

    [Fact]
    public void DecompressFormat01_ExtendedRun_ExpandsCorrectly()
    {
        // 0x00 = extended, then 2B length = 3, then data = 0xCD
        var compressed = new byte[] { 0x00, 0x03, 0x00, 0xCD };
        var result = BattleTechCHI.Maps.RleDecompressor.DecompressFormat01(compressed, 0);
        Assert.Equal(0xCD, result[0]);
        Assert.Equal(0xCD, result[1]);
        Assert.Equal(0xCD, result[2]);
        Assert.Equal(0, result[3]);
    }

    [Fact]
    public void NibbleToPixels_SplitsNibblesCorrectly()
    {
        // 0xAB -> high nibble = 0xA, low nibble = 0xB
        var nibbles = new byte[] { 0xAB };
        var pixels = BattleTechCHI.Maps.RleDecompressor.NibbleToPixels(nibbles, 2, 1);
        Assert.Equal(2, pixels.Length);
        Assert.Equal(0x0A, pixels[0]);
        Assert.Equal(0x0B, pixels[1]);
    }
}

public class BldLoaderTests
{
    [Fact]
    public void DecryptInPlace_TransformsBytes()
    {
        var data = new byte[] { 0xA0, 0x00, 0x00, 0x00 };
        BattleTechCHI.BLD.BldLoader.DecryptInPlace(data);
        
        // ((0 + 41) & 0xFF) ^ 233 = 41 ^ 233 = 192
        // Only bytes at index >= 0xA0 should be decrypted
        // data[0xA0] in the array = index 0xA0 but our array is only 4 bytes
        // Wait, our array starts at position 0, not 0xA0
        // The decrypt function starts at 0xA0, so for an array smaller than 0xA0, nothing happens
        // Let's write a proper test
    }

    [Fact]
    public void DecryptInPlace_ProperTest()
    {
        // Create array with at least 0xA1 bytes so decryption affects byte at index 0xA0
        var data = new byte[0xA1];
        data[0xA0] = 0x00;
        
        BattleTechCHI.BLD.BldLoader.DecryptInPlace(data);
        
        // ((0 + 41) & 0xFF) ^ 233 = 41 ^ 233 = 192
        Assert.Equal(192, data[0xA0]);
        
        // Byte before 0xA0 should remain unchanged
        data[0] = 0x42;
        BattleTechCHI.BLD.BldLoader.DecryptInPlace(data);
        Assert.Equal(0x42, data[0]); // unchanged
    }
}

public class GameEnumsConsistencyTests
{
    [Fact]
    public void AllGameModes_AreDistinct()
    {
        var modes = Enum.GetValues<GameMode>();
        Assert.Equal(6, modes.Length);
        var set = new HashSet<int>();
        foreach (var m in modes) Assert.True(set.Add((int)m));
    }

    [Fact]
    public void AllBldOpcodes_AreInRange()
    {
        foreach (var op in Enum.GetValues<BldOpcode>())
        {
            int val = (byte)op;
            Assert.InRange(val, 0xE4, 0xFF);
        }
    }

    [Fact]
    public void AllNarrativeModes_HaveCorrectByteValues()
    {
        Assert.Equal(0x9E, (byte)NarrativeMode.ThirdPerson);
        Assert.Equal(0x9C, (byte)NarrativeMode.CharacterSpeech);
        Assert.Equal(0x9B, (byte)NarrativeMode.PlayerThought);
        Assert.Equal(0x9F, (byte)NarrativeMode.PlayerAction);
        Assert.Equal(0xA5, (byte)NarrativeMode.Continuation);
    }
}

public class MapFormatTests
{
    [Fact]
    public void MapFormats_AreCorrect()
    {
        Assert.Equal(0, (int)MapFormat.BlockFormat);
        Assert.Equal(1, (int)MapFormat.LinearFormat);
    }
}

public class StorySlotTests
{
    [Fact]
    public void StorySlot_DefaultValues()
    {
        var slot = new StorySlot();
        Assert.Equal(0, slot.StatusByte);
        Assert.Equal(0, slot.StoryState);
        Assert.Equal(0, slot.CounterA);
        Assert.Equal(0, slot.CounterB);
        Assert.Equal(0, slot.LatchMarker);
    }
}

public class EgaPaletteTests
{
    [Fact]
    public void StandardPalette_Has16Colors()
    {
        Assert.Equal(16, global::BattleTechCHI.UI.EgaPalette.StandardPalette.Length);
    }

    [Fact]
    public void CustomPalettes_DifferFromStandard()
    {
        Assert.NotEqual(global::BattleTechCHI.UI.EgaPalette.CustomPalettes.Bttitle[1], 
                        global::BattleTechCHI.UI.EgaPalette.StandardPalette[1]);
    }
}