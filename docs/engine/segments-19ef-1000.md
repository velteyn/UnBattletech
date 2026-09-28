# Runtime Segments 0x1000 & 0x19EF — function map

> Reko did **not** decompile the combat / movement segments. Their decompilation comes from the
> **Spice86 code generator** (CFG → C#), executed during a prior playthrough that included combat.
> Recovered to [`../../reko/gencode/`](../../reko/gencode/) (2026-09-28) — see *Provenance* below.

`Reko` covers segments `0x0800, 0D27, 0DAB, 0FDC, 11B8, 135D, 1431, 1467, 1543, 1631, 183B, 1AE8, 1CD3,
1E56, 1F3D, 1FC5, 204B, 207F, 246C, 2FE8, 3056, 3058, 305B, 3092, 3EDB`. The **combat/movement** code
lives in the *runtime* segments below, which Reko skipped.

## Segment aliases (Spice86 codegen `csN`)

| csN | runtime segment | role |
|-----|-----------------|------|
| cs1 | `0x0000` | main code (Reko covers) |
| cs7 | **`0x1000`** | **combat code** (163 functions) |
| cs12 | **`0x19EF`** | **render / movement / animation** (91 functions) |
| cs2..cs6, cs8..cs11, cs13..cs16 | `0x170, 0x697, 0x71B, 0x94C, 0xFA1, 0x1643, 0x17C6, 0x18AD, 0x19BB, 0x2000, 0x24D7, 0xF000, 0xF100` | other runtime aliases |

`0x1000:off` and `0x19EF:off'` can address the **same physical code** (e.g. `1000:B42A` == `19EF:153A`
== linear `0x1B42A`), so the same routine appears under both naming schemes; the docs use
`ghidra_guess_1000_*` and `unknown_19EF_*` interchangeably.

## How to read

The recovered code is a Spice86 C# override class (`GeneratedOverrides`): each CFG partition is a
method; jumps are `goto label_SEG_OFF_LINEAR:`; `CALL`s are `return Method(...)`. Register/memory
access is typed (`_memory.UInt16[...]` etc.). Look up a function by its offset here, then grep the
recovered files for its label (`label_1000_<OFF>_<LIN>` / `label_19EF_...`).

## Key combat/movement routines (cited by the docs)

| Function | Role |
|----------|------|
| `1000:458C` `ghidra_guess_1000_458C_1458C` | **Main combat handler loop** (unit loop, AI, movement, targeting, to-hit, fire) — `docs/combat-system.md` §1 |
| `1000:0934` `ghidra_guess_1000_0934_10934` | action-code / "can this unit act" + range/ammo check (§1, §5) |
| `1000:0AB2` `ghidra_guess_1000_0AB2_10AB2` | **AI target selection** from story-state preference table (§3) |
| `1000:160E` `ghidra_guess_1000_160E_1160E` | **LoS validation** (8-direction ray-cast) (§5) |
| `1000:0B32` `ghidra_guess_1000_0B32_10B32` | **damage slot-advance** (overflow to next body part) (§7.11) |
| `1000:0673` `ghidra_guess_1000_0673_10673` | end-of-round heat transfer/clear (§6.4) |
| `1000:05C5` `ghidra_guess_1000_05C5_105C5` | (§1) |
| `1000:1554` `ghidra_guess_1000_1554_11554` | (§1) |
| `1000:3224` `ghidra_guess_1000_3224_13224` | (§1) |
| `1000:0BBB` `ghidra_guess_1000_0BBB_10BBB` | (§1) |
| `1000:A8C6` `split_1000_A8C6_1A8C6` | movement helper (§2) |
| `1000:5847` `ghidra_guess_1000_5847_15847` | combat entry/init (§1) |
| `19EF:0971` `unknown_19EF_0971_1A861` | **movement direction calc** (§2) |
| `19EF:0BC0` `unknown_19EF_0BC0_1AAB0` | **RNG** (24-bit LFSR) (§16) |
| `19EF:0BFB` `unknown_19EF_0BFB_1AAEB` | fired per body-part pair (§7.9) |
| `19EF:1886` `unknown_19EF_1886_1B776` | **fire phase / crit-adjacency propagator** (§7.9) |
| `19EF:18EF` `unknown_19EF_18EF_1B7DF` | **impact VFX** (VGA `0x3CE`) — [`viewport.md`](viewport.md) |
| `19EF:1DF8` `unknown_19EF_1DF8_1BCE8` | combat stage / sparkle buffer (§7.12) |
| `19EF:163B`/`16E3`/`17C5` | buffer counters (up/down/left/right variants) |
| `19EF:11BB`/`12BA`/`12D9`/`12F2` | slot scroll/rotate variants (§7.11) |
| `19EF:2FDC` `unknown_19EF_2FDC_1CECC` | segment-context save (`fn207F_2FDC` callers) |
| `19EF:2D82` | EXE **entry point** (`0x1CC72`) |

## Full function map

### Segment `0x1000` (combat) — 163 functions

| offset | function | cited |
|--------|----------|:-----:|
| `0x5C5` | `ghidra_guess_1000_05C5_105C5` | ✓ |
| `0x673` | `ghidra_guess_1000_0673_10673` | ✓ |
| `0x934` | `ghidra_guess_1000_0934_10934` | ✓ |
| `0xA67` | `ghidra_guess_1000_0A67_10A67` |  |
| `0xAB2` | `ghidra_guess_1000_0AB2_10AB2` | ✓ |
| `0xB32` | `ghidra_guess_1000_0B32_10B32` | ✓ |
| `0xBB4` | `split_1000_0BB4_10BB4` |  |
| `0xBBB` | `ghidra_guess_1000_0BBB_10BBB` | ✓ |
| `0x1005` | `split_1000_1005_11005` |  |
| `0x1554` | `ghidra_guess_1000_1554_11554` | ✓ |
| `0x159F` | `ghidra_guess_1000_159F_1159F` |  |
| `0x160E` | `ghidra_guess_1000_160E_1160E` | ✓ |
| `0x17BB` | `ghidra_guess_1000_17BB_117BB` |  |
| `0x17DC` | `ghidra_guess_1000_17DC_117DC` |  |
| `0x1808` | `ghidra_guess_1000_1808_11808` |  |
| `0x18B2` | `ghidra_guess_1000_18B2_118B2` |  |
| `0x1919` | `ghidra_guess_1000_1919_11919` |  |
| `0x1983` | `ghidra_guess_1000_1983_11983` |  |
| `0x1ABA` | `ghidra_guess_1000_1ABA_11ABA` |  |
| `0x2F32` | `ghidra_guess_1000_2F32_12F32` |  |
| `0x2F73` | `ghidra_guess_1000_2F73_12F73` |  |
| `0x3224` | `ghidra_guess_1000_3224_13224` | ✓ |
| `0x33EB` | `ghidra_guess_1000_33EB_133EB` |  |
| `0x36CF` | `ghidra_guess_1000_36CF_136CF` |  |
| `0x3B0F` | `split_1000_3B0F_13B0F` |  |
| `0x3CD6` | `ghidra_guess_1000_3CD6_13CD6` |  |
| `0x3CE1` | `ghidra_guess_1000_3CE1_13CE1` |  |
| `0x3D6C` | `ghidra_guess_1000_3D6C_13D6C` |  |
| `0x3F24` | `ghidra_guess_1000_3F24_13F24` |  |
| `0x3FA0` | `ghidra_guess_1000_3FA0_13FA0` |  |
| `0x4006` | `ghidra_guess_1000_4006_14006` |  |
| `0x4041` | `ghidra_guess_1000_4041_14041` |  |
| `0x41ED` | `ghidra_guess_1000_41ED_141ED` |  |
| `0x4279` | `ghidra_guess_1000_4279_14279` |  |
| `0x42E5` | `ghidra_guess_1000_42E5_142E5` |  |
| `0x438B` | `ghidra_guess_1000_438B_1438B` |  |
| `0x4553` | `ghidra_guess_1000_4553_14553` |  |
| `0x458C` | `ghidra_guess_1000_458C_1458C` | ✓ |
| `0x5847` | `ghidra_guess_1000_5847_15847` |  |
| `0x63C6` | `ghidra_guess_1000_63C6_163C6` |  |
| `0x65E5` | `split_1000_65E5_165E5` |  |
| `0x6ABC` | `split_1000_6ABC_16ABC` |  |
| `0x6D87` | `split_1000_6D87_16D87` |  |
| `0x7400` | `split_1000_7400_17400` |  |
| `0x7BF0` | `split_1000_7BF0_17BF0` |  |
| `0x7C1A` | `ghidra_guess_1000_7C1A_17C1A` |  |
| `0x7C39` | `ghidra_guess_1000_7C39_17C39` |  |
| `0x7C4E` | `ghidra_guess_1000_7C4E_17C4E` |  |
| `0x8AD1` | `split_1000_8AD1_18AD1` |  |
| `0x8B23` | `ghidra_guess_1000_8B23_18B23` |  |
| `0x933A` | `ghidra_guess_1000_933A_1933A` |  |
| `0x9352` | `ghidra_guess_1000_9352_19352` |  |
| `0x95F3` | `ghidra_guess_1000_95F3_195F3` |  |
| `0x963B` | `ghidra_guess_1000_963B_1963B` |  |
| `0x9695` | `ghidra_guess_1000_9695_19695` |  |
| `0x96F8` | `ghidra_guess_1000_96F8_196F8` |  |
| `0x975B` | `ghidra_guess_1000_975B_1975B` |  |
| `0x97BE` | `ghidra_guess_1000_97BE_197BE` |  |
| `0x97CB` | `ghidra_guess_1000_97CB_197CB` |  |
| `0x9834` | `ghidra_guess_1000_9834_19834` |  |
| `0x9841` | `ghidra_guess_1000_9841_19841` |  |
| `0x98EA` | `ghidra_guess_1000_98EA_198EA` |  |
| `0x9993` | `ghidra_guess_1000_9993_19993` |  |
| `0x9A46` | `ghidra_guess_1000_9A46_19A46` |  |
| `0x9A97` | `ghidra_guess_1000_9A97_19A97` |  |
| `0x9B2A` | `ghidra_guess_1000_9B2A_19B2A` |  |
| `0x9E94` | `ghidra_guess_1000_9E94_19E94` |  |
| `0x9F0C` | `ghidra_guess_1000_9F0C_19F0C` |  |
| `0x9F20` | `ghidra_guess_1000_9F20_19F20` |  |
| `0x9F41` | `ghidra_guess_1000_9F41_19F41` |  |
| `0x9F57` | `ghidra_guess_1000_9F57_19F57` |  |
| `0x9F6D` | `ghidra_guess_1000_9F6D_19F6D` |  |
| `0x9F99` | `ghidra_guess_1000_9F99_19F99` |  |
| `0xA03C` | `ghidra_guess_1000_A03C_1A03C` |  |
| `0xA053` | `ghidra_guess_1000_A053_1A053` |  |
| `0xA0B6` | `split_1000_A0B6_1A0B6` |  |
| `0xA0C0` | `ghidra_guess_1000_A0C0_1A0C0` |  |
| `0xA0C7` | `ghidra_guess_1000_A0C7_1A0C7` |  |
| `0xA11A` | `ghidra_guess_1000_A11A_1A11A` |  |
| `0xA150` | `ghidra_guess_1000_A150_1A150` |  |
| `0xA203` | `ghidra_guess_1000_A203_1A203` |  |
| `0xA267` | `ghidra_guess_1000_A267_1A267` |  |
| `0xA337` | `split_1000_A337_1A337` |  |
| `0xA33A` | `ghidra_guess_1000_A33A_1A33A` |  |
| `0xA458` | `ghidra_guess_1000_A458_1A458` |  |
| `0xA462` | `ghidra_guess_1000_A462_1A462` |  |
| `0xA4AF` | `ghidra_guess_1000_A4AF_1A4AF` |  |
| `0xA56F` | `split_1000_A56F_1A56F` |  |
| `0xA5E1` | `split_1000_A5E1_1A5E1` |  |
| `0xA5ED` | `ghidra_guess_1000_A5ED_1A5ED` |  |
| `0xA6C8` | `split_1000_A6C8_1A6C8` |  |
| `0xA6FE` | `split_1000_A6FE_1A6FE` |  |
| `0xA744` | `ghidra_guess_1000_A744_1A744` |  |
| `0xA791` | `ghidra_guess_1000_A791_1A791` |  |
| `0xA8C6` | `split_1000_A8C6_1A8C6` | ✓ |
| `0xA916` | `ghidra_guess_1000_A916_1A916` |  |
| `0xA98F` | `ghidra_guess_1000_A98F_1A98F` |  |
| `0xAA97` | `ghidra_guess_1000_AA97_1AA97` |  |
| `0xB122` | `split_1000_B122_1B122` |  |
| `0xB3E0` | `split_1000_B3E0_1B3E0` |  |
| `0xB455` | `split_1000_B455_1B455` |  |
| `0xB47C` | `ghidra_guess_1000_B47C_1B47C` |  |
| `0xB7C8` | `ghidra_guess_1000_B7C8_1B7C8` |  |
| `0xBA61` | `ghidra_guess_1000_BA61_1BA61` |  |
| `0xBACF` | `ghidra_guess_1000_BACF_1BACF` |  |
| `0xBB73` | `ghidra_guess_1000_BB73_1BB73` |  |
| `0xBBA8` | `ghidra_guess_1000_BBA8_1BBA8` |  |
| `0xBC00` | `split_1000_BC00_1BC00` |  |
| `0xBDBE` | `ghidra_guess_1000_BDBE_1BDBE` |  |
| `0xBDF4` | `ghidra_guess_1000_BDF4_1BDF4` |  |
| `0xBE41` | `ghidra_guess_1000_BE41_1BE41` |  |
| `0xBEE6` | `split_1000_BEE6_1BEE6` |  |
| `0xBFC5` | `split_1000_BFC5_1BFC5` |  |
| `0xC098` | `ghidra_guess_1000_C098_1C098` |  |
| `0xC0F9` | `ghidra_guess_1000_C0F9_1C0F9` |  |
| `0xC141` | `ghidra_guess_1000_C141_1C141` |  |
| `0xC1D3` | `split_1000_C1D3_1C1D3` |  |
| `0xC21F` | `split_1000_C21F_1C21F` |  |
| `0xC226` | `split_1000_C226_1C226` |  |
| `0xC28F` | `split_1000_C28F_1C28F` |  |
| `0xC296` | `split_1000_C296_1C296` |  |
| `0xC309` | `split_1000_C309_1C309` |  |
| `0xC312` | `split_1000_C312_1C312` |  |
| `0xC6CE` | `split_1000_C6CE_1C6CE` |  |
| `0xC710` | `ghidra_guess_1000_C710_1C710` |  |
| `0xC73D` | `ghidra_guess_1000_C73D_1C73D` |  |
| `0xC8AD` | `split_1000_C8AD_1C8AD` |  |
| `0xC8B0` | `split_1000_C8B0_1C8B0` |  |
| `0xC90E` | `ghidra_guess_1000_C90E_1C90E` |  |
| `0xC9D9` | `split_1000_C9D9_1C9D9` |  |
| `0xC9DC` | `ghidra_guess_1000_C9DC_1C9DC` |  |
| `0xCA35` | `ghidra_guess_1000_CA35_1CA35` |  |
| `0xCB38` | `split_1000_CB38_1CB38` |  |
| `0xCBA0` | `ghidra_guess_1000_CBA0_1CBA0` |  |
| `0xCC29` | `split_1000_CC29_1CC29` |  |
| `0xCC54` | `ghidra_guess_1000_CC54_1CC54` |  |
| `0xCE04` | `ghidra_guess_1000_CE04_1CE04` |  |
| `0xCE1E` | `split_1000_CE1E_1CE1E` |  |
| `0xCE62` | `ghidra_guess_1000_CE62_1CE62` |  |
| `0xCEA2` | `ghidra_guess_1000_CEA2_1CEA2` |  |
| `0xCEC6` | `ghidra_guess_1000_CEC6_1CEC6` |  |
| `0xCEF0` | `ghidra_guess_1000_CEF0_1CEF0` |  |
| `0xD031` | `split_1000_D031_1D031` |  |
| `0xD13A` | `ghidra_guess_1000_D13A_1D13A` |  |
| `0xD165` | `ghidra_guess_1000_D165_1D165` |  |
| `0xD1D2` | `split_1000_D1D2_1D1D2` |  |
| `0xD1F8` | `ghidra_guess_1000_D1F8_1D1F8` |  |
| `0xD213` | `split_1000_D213_1D213` |  |
| `0xD360` | `split_1000_D360_1D360` |  |
| `0xD3A9` | `split_1000_D3A9_1D3A9` |  |
| `0xD45F` | `ghidra_guess_1000_D45F_1D45F` |  |
| `0xD55A` | `ghidra_guess_1000_D55A_1D55A` |  |
| `0xD60E` | `ghidra_guess_1000_D60E_1D60E` |  |
| `0xD659` | `ghidra_guess_1000_D659_1D659` |  |
| `0xD66A` | `ghidra_guess_1000_D66A_1D66A` |  |
| `0xD6A4` | `ghidra_guess_1000_D6A4_1D6A4` |  |
| `0xD6CA` | `ghidra_guess_1000_D6CA_1D6CA` |  |
| `0xDB5C` | `ghidra_guess_1000_DB5C_1DB5C` |  |
| `0xDC5C` | `ghidra_guess_1000_DC5C_1DC5C` |  |
| `0xDDB4` | `ghidra_guess_1000_DDB4_1DDB4` |  |
| `0xE6D1` | `split_1000_E6D1_1E6D1` |  |
| `0xE903` | `split_1000_E903_1E903` |  |
| `0xFA7E` | `ghidra_guess_1000_FA7E_1FA7E` |  |

### Segment `0x19EF` (render/movement) — 91 functions

| offset | function | cited |
|--------|----------|:-----:|
| `0xD1` | `unknown_19EF_00D1_19FC1` |  |
| `0x213` | `unknown_19EF_0213_1A103` |  |
| `0x5D0` | `unknown_19EF_05D0_1A4C0` |  |
| `0x780` | `unknown_19EF_0780_1A670` |  |
| `0x931` | `unknown_19EF_0931_1A821` |  |
| `0x971` | `unknown_19EF_0971_1A861` | ✓ |
| `0xA76` | `unknown_19EF_0A76_1A966` |  |
| `0xB26` | `unknown_19EF_0B26_1AA16` |  |
| `0xB40` | `unknown_19EF_0B40_1AA30` |  |
| `0xB73` | `unknown_19EF_0B73_1AA63` |  |
| `0xB8A` | `unknown_19EF_0B8A_1AA7A` |  |
| `0xBC0` | `unknown_19EF_0BC0_1AAB0` | ✓ |
| `0xBFB` | `unknown_19EF_0BFB_1AAEB` | ✓ |
| `0xD07` | `unknown_19EF_0D07_1ABF7` |  |
| `0xD79` | `unknown_19EF_0D79_1AC69` |  |
| `0xDF8` | `unknown_19EF_0DF8_1ACE8` |  |
| `0xFEE` | `unknown_19EF_0FEE_1AEDE` |  |
| `0x104E` | `unknown_19EF_104E_1AF3E` |  |
| `0x11BB` | `unknown_19EF_11BB_1B0AB` | ✓ |
| `0x12BA` | `unknown_19EF_12BA_1B1AA` | ✓ |
| `0x12D9` | `unknown_19EF_12D9_1B1C9` | ✓ |
| `0x12F2` | `unknown_19EF_12F2_1B1E2` | ✓ |
| `0x1303` | `unknown_19EF_1303_1B1F3` |  |
| `0x1314` | `unknown_19EF_1314_1B204` |  |
| `0x13D9` | `unknown_19EF_13D9_1B2C9` |  |
| `0x163B` | `unknown_19EF_163B_1B52B` | ✓ |
| `0x16E3` | `unknown_19EF_16E3_1B5D3` | ✓ |
| `0x17C5` | `unknown_19EF_17C5_1B6B5` | ✓ |
| `0x1886` | `unknown_19EF_1886_1B776` | ✓ |
| `0x18EF` | `unknown_19EF_18EF_1B7DF` | ✓ |
| `0x1AA8` | `unknown_19EF_1AA8_1B998` |  |
| `0x1ACE` | `unknown_19EF_1ACE_1B9BE` |  |
| `0x1AF4` | `unknown_19EF_1AF4_1B9E4` |  |
| `0x1B1A` | `unknown_19EF_1B1A_1BA0A` |  |
| `0x1B94` | `unknown_19EF_1B94_1BA84` |  |
| `0x1BFC` | `unknown_19EF_1BFC_1BAEC` |  |
| `0x1D3A` | `unknown_19EF_1D3A_1BC2A` |  |
| `0x1D8C` | `unknown_19EF_1D8C_1BC7C` |  |
| `0x1DA8` | `unknown_19EF_1DA8_1BC98` |  |
| `0x1DF8` | `unknown_19EF_1DF8_1BCE8` | ✓ |
| `0x1E37` | `unknown_19EF_1E37_1BD27` |  |
| `0x1F9C` | `unknown_19EF_1F9C_1BE8C` |  |
| `0x1FAD` | `unknown_19EF_1FAD_1BE9D` |  |
| `0x1FBE` | `unknown_19EF_1FBE_1BEAE` |  |
| `0x200E` | `unknown_19EF_200E_1BEFE` |  |
| `0x2127` | `unknown_19EF_2127_1C017` |  |
| `0x22A5` | `unknown_19EF_22A5_1C195` |  |
| `0x22F8` | `unknown_19EF_22F8_1C1E8` |  |
| `0x2368` | `unknown_19EF_2368_1C258` |  |
| `0x23EC` | `unknown_19EF_23EC_1C2DC` |  |
| `0x245C` | `unknown_19EF_245C_1C34C` |  |
| `0x24D7` | `unknown_19EF_24D7_1C3C7` |  |
| `0x275C` | `unknown_19EF_275C_1C64C` |  |
| `0x28A8` | `unknown_19EF_28A8_1C798` |  |
| `0x28EB` | `unknown_19EF_28EB_1C7DB` |  |
| `0x2B87` | `unknown_19EF_2B87_1CA77` |  |
| `0x2CE1` | `unknown_19EF_2CE1_1CBD1` |  |
| `0x2CF7` | `unknown_19EF_2CF7_1CBE7` |  |
| `0x2D82` | `spice86_imported_label_jump_target_19EF_2D82_1CC72` |  |
| `0x2F9F` | `unknown_19EF_2F9F_1CE8F` |  |
| `0x2FDC` | `unknown_19EF_2FDC_1CECC` | ✓ |
| `0x3026` | `unknown_19EF_3026_1CF16` |  |
| `0x31CE` | `unknown_19EF_31CE_1D0BE` |  |
| `0x32A0` | `unknown_19EF_32A0_1D190` |  |
| `0x32F5` | `spice86_imported_label_jump_target_19EF_32F5_1D1E5` |  |
| `0x3336` | `unknown_19EF_3336_1D226` |  |
| `0x3356` | `unknown_19EF_3356_1D246` |  |
| `0x33D0` | `unknown_19EF_33D0_1D2C0` |  |
| `0x3580` | `unknown_19EF_3580_1D470` |  |
| `0x3835` | `unknown_19EF_3835_1D725` |  |
| `0x3874` | `unknown_19EF_3874_1D764` |  |
| `0x38E2` | `unknown_19EF_38E2_1D7D2` |  |
| `0x38FD` | `unknown_19EF_38FD_1D7ED` |  |
| `0x39E0` | `unknown_19EF_39E0_1D8D0` |  |
| `0x3A1A` | `unknown_19EF_3A1A_1D90A` |  |
| `0x3A3C` | `unknown_19EF_3A3C_1D92C` |  |
| `0x3A5E` | `unknown_19EF_3A5E_1D94E` |  |
| `0x3ACC` | `unknown_19EF_3ACC_1D9BC` |  |
| `0x3B22` | `unknown_19EF_3B22_1DA12` |  |
| `0x3B68` | `unknown_19EF_3B68_1DA58` |  |
| `0x3B9E` | `unknown_19EF_3B9E_1DA8E` |  |
| `0x3BB6` | `unknown_19EF_3BB6_1DAA6` |  |
| `0x3BD2` | `unknown_19EF_3BD2_1DAC2` |  |
| `0x3BDC` | `unknown_19EF_3BDC_1DACC` |  |
| `0x3C08` | `spice86_imported_label_jump_target_19EF_3C08_1DAF8` |  |
| `0x3C82` | `unknown_19EF_3C82_1DB72` |  |
| `0x3D1C` | `unknown_19EF_3D1C_1DC0C` |  |
| `0x3D44` | `unknown_19EF_3D44_1DC34` |  |
| `0x3D92` | `unknown_19EF_3D92_1DC82` |  |
| `0x3E2E` | `unknown_19EF_3E2E_1DD1E` |  |
| `0x3E62` | `unknown_19EF_3E62_1DD52` |  |

## Provenance / regeneration

- **Recovered** from git history: `git show f0037ea^:spice86/GeneratedCode/GeneratedCodeN.cs`
  (the `spice86/` tree was removed as stale on 2026-09-28; the decompilation itself is still valid).
- **Regenerate** with a current Spice86 (it runs the program, keeps the CFG of executed code, and
  `CfgCSharpDumper` emits the override class + project — `../Spice86/doc/codeGeneratorReadme.md`):

  1. Run with the **GDB debugger** + a recording dir:
     `--GdbPort <port> -r <dir>` (`-r` = `RecordedDataDirectory`/state-serialization folder).
  2. **Exercise combat** so the CFG covers `0x1000`/`0x19EF` — load the `GAME5` save (puts you on the
     map with your party), then **walk until a random encounter fires** (`Attacking force: … / Engage
     in combat?`) and fight a round or two.
  3. Attach GDB and issue the custom command **`dumpall`** (`GdbCustomCommandsHandler` →
     `EmulationStateDataWriter.Write()`), which writes the generated C# override + a buildable project
     into `<dir>`.
  4. Diff the fresh `0x1000`/`0x19EF` output against `reko/gencode/` in this repo.

## Remaining

- This map is a **navigational** artifact; the combat formulas in `docs/combat-system.md` still need
  to be **re-verified against the recovered code** (feeds roadmap B2 — combat differential validation).
