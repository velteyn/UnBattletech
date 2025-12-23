using Spice86.Shared.Emulator.Memory;

namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  protected ushort cs1; // 0x0
  protected ushort cs10; // 0x18AD
  protected ushort cs11; // 0x19BB
  protected ushort cs12; // 0x19EF
  protected ushort cs13; // 0x2000
  protected ushort cs14; // 0x24D7
  protected ushort cs15; // 0xF000
  protected ushort cs16; // 0xF100
  protected ushort cs2; // 0x170
  protected ushort cs3; // 0x697
  protected ushort cs4; // 0x71B
  protected ushort cs5; // 0x94C
  protected ushort cs6; // 0xFA1
  protected ushort cs7; // 0x1000
  protected ushort cs8; // 0x1643
  protected ushort cs9; // 0x17C6
  
  public GeneratedOverrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, Machine machine, ushort entrySegment = 0x0) : base(functionInformations, machine) {
    // Observed cs1 address at generation time is 0x0. Do not set entrySegment to something else if the program is not relocatable.
    this.cs1 = (ushort)(entrySegment + 0x0);
    this.cs10 = (ushort)(entrySegment + 0x18AD);
    this.cs11 = (ushort)(entrySegment + 0x19BB);
    this.cs12 = (ushort)(entrySegment + 0x19EF);
    this.cs13 = (ushort)(entrySegment + 0x2000);
    this.cs14 = (ushort)(entrySegment + 0x24D7);
    this.cs15 = (ushort)(entrySegment + 0xF000);
    this.cs16 = (ushort)(entrySegment + 0xF100);
    this.cs2 = (ushort)(entrySegment + 0x170);
    this.cs3 = (ushort)(entrySegment + 0x697);
    this.cs4 = (ushort)(entrySegment + 0x71B);
    this.cs5 = (ushort)(entrySegment + 0x94C);
    this.cs6 = (ushort)(entrySegment + 0xFA1);
    this.cs7 = (ushort)(entrySegment + 0x1000);
    this.cs8 = (ushort)(entrySegment + 0x1643);
    this.cs9 = (ushort)(entrySegment + 0x17C6);
    
    DefineGeneratedCodeOverrides();
    SetProvidedInterruptHandlersAsOverridden();
  }
  
    public void DefineGeneratedCodeOverrides() {
    DefineFunction(cs1, 0xC, ghidra_guess_0000_000C_0000C, false);
    DefineFunction(cs1, 0x5C5, ghidra_guess_0000_05C5_005C5, false);
    DefineFunction(cs1, 0x10BB, ghidra_guess_0000_10BB_010BB, false);
    // 0x170
    DefineFunction(cs2, 0x0, unknown_0170_0000_01700, false);
    DefineFunction(cs2, 0x51B, unknown_0170_051B_01C1B, false);
    // 0x0
    DefineFunction(cs1, 0x254B, ghidra_guess_0000_254B_0254B, false);
    // 0x170
    DefineFunction(cs2, 0x1732, unknown_0170_1732_02E32, false);
    // 0x0
    DefineFunction(cs1, 0x2EBB, ghidra_guess_0000_2EBB_02EBB, false);
    DefineFunction(cs1, 0x2F6F, ghidra_guess_0000_2F6F_02F6F, false);
    // 0x170
    DefineFunction(cs2, 0x191B, unknown_0170_191B_0301B, false);
    // 0x0
    DefineFunction(cs1, 0x30BF, ghidra_guess_0000_30BF_030BF, false);
    DefineFunction(cs1, 0x30DD, ghidra_guess_0000_30DD_030DD, false);
    DefineFunction(cs1, 0x30F3, ghidra_guess_0000_30F3_030F3, false);
    // 0x170
    DefineFunction(cs2, 0x1A13, unknown_0170_1A13_03113, false);
    DefineFunction(cs2, 0x1AFD, unknown_0170_1AFD_031FD, false);
    DefineFunction(cs2, 0x1C12, unknown_0170_1C12_03312, false);
    DefineFunction(cs2, 0x218F, unknown_0170_218F_0388F, false);
    DefineFunction(cs2, 0x231D, unknown_0170_231D_03A1D, false);
    DefineFunction(cs2, 0x240B, unknown_0170_240B_03B0B, false);
    DefineFunction(cs2, 0x24C2, unknown_0170_24C2_03BC2, false);
    // 0x0
    DefineFunction(cs1, 0x3F67, ghidra_guess_0000_3F67_03F67, false);
    // 0x170
    DefineFunction(cs2, 0x28A2, unknown_0170_28A2_03FA2, false);
    DefineFunction(cs2, 0x28CC, unknown_0170_28CC_03FCC, false);
    // 0x0
    DefineFunction(cs1, 0x4013, ghidra_guess_0000_4013_04013, false);
    // 0x170
    DefineFunction(cs2, 0x29F5, unknown_0170_29F5_040F5, false);
    DefineFunction(cs2, 0x2A2B, unknown_0170_2A2B_0412B, false);
    // 0x0
    DefineFunction(cs1, 0x414F, ghidra_guess_0000_414F_0414F, false);
    DefineFunction(cs1, 0x4169, ghidra_guess_0000_4169_04169, false);
    DefineFunction(cs1, 0x417E, ghidra_guess_0000_417E_0417E, false);
    // 0x170
    DefineFunction(cs2, 0x2A93, unknown_0170_2A93_04193, false);
    // 0x0
    DefineFunction(cs1, 0x4350, ghidra_guess_0000_4350_04350, false);
    DefineFunction(cs1, 0x446C, split_0000_446C_0446C, false);
    DefineFunction(cs1, 0x449F, split_0000_449F_0449F, false);
    // 0x170
    DefineFunction(cs2, 0x2DA8, unknown_0170_2DA8_044A8, false);
    DefineFunction(cs2, 0x320B, unknown_0170_320B_0490B, false);
    // 0x0
    DefineFunction(cs1, 0x49B3, ghidra_guess_0000_49B3_049B3, false);
    DefineFunction(cs1, 0x4CD3, ghidra_guess_0000_4CD3_04CD3, false);
    DefineFunction(cs1, 0x4E8D, ghidra_guess_0000_4E8D_04E8D, false);
    DefineFunction(cs1, 0x52D0, ghidra_guess_0000_52D0_052D0, false);
    DefineFunction(cs1, 0x5440, ghidra_guess_0000_5440_05440, false);
    DefineFunction(cs1, 0x56AE, ghidra_guess_0000_56AE_056AE, false);
    DefineFunction(cs1, 0x5CC2, ghidra_guess_0000_5CC2_05CC2, false);
    // 0x170
    DefineFunction(cs2, 0x4621, unknown_0170_4621_05D21, false);
    DefineFunction(cs2, 0x46A7, unknown_0170_46A7_05DA7, false);
    DefineFunction(cs2, 0x476D, unknown_0170_476D_05E6D, false);
    DefineFunction(cs2, 0x48B7, unknown_0170_48B7_05FB7, false);
    DefineFunction(cs2, 0x4AA6, unknown_0170_4AA6_061A6, false);
    DefineFunction(cs2, 0x4BC1, unknown_0170_4BC1_062C1, false);
    DefineFunction(cs2, 0x4CAC, unknown_0170_4CAC_063AC, false);
    DefineFunction(cs2, 0x4DC7, unknown_0170_4DC7_064C7, false);
    DefineFunction(cs2, 0x50C8, unknown_0170_50C8_067C8, false);
    // 0x697
    DefineFunction(cs3, 0xA, unknown_0697_000A_0697A, false);
    DefineFunction(cs3, 0x44, unknown_0697_0044_069B4, false);
    // 0x0
    DefineFunction(cs1, 0x71B2, ghidra_guess_0000_71B2_071B2, false);
    DefineFunction(cs1, 0x76A9, ghidra_guess_0000_76A9_076A9, false);
    DefineFunction(cs1, 0x7AFB, ghidra_guess_0000_7AFB_07AFB, false);
    DefineFunction(cs1, 0x7D0E, ghidra_guess_0000_7D0E_07D0E, false);
    // 0x71B
    DefineFunction(cs4, 0xB95, unknown_071B_0B95_07D45, false);
    DefineFunction(cs4, 0xC8F, unknown_071B_0C8F_07E3F, false);
    // 0x0
    DefineFunction(cs1, 0x7EC2, ghidra_guess_0000_7EC2_07EC2, false);
    DefineFunction(cs1, 0x7EED, ghidra_guess_0000_7EED_07EED, false);
    DefineFunction(cs1, 0x8617, ghidra_guess_0000_8617_08617, false);
    DefineFunction(cs1, 0x8809, split_0000_8809_08809, false);
    DefineFunction(cs1, 0x88FC, ghidra_guess_0000_88FC_088FC, false);
    DefineFunction(cs1, 0x8A08, ghidra_guess_0000_8A08_08A08, false);
    DefineFunction(cs1, 0x8A98, ghidra_guess_0000_8A98_08A98, false);
    DefineFunction(cs1, 0x8CAE, ghidra_guess_0000_8CAE_08CAE, false);
    // 0x94C
    DefineFunction(cs5, 0x8, unknown_094C_0008_094C8, false);
    DefineFunction(cs5, 0x1C0, unknown_094C_01C0_09680, false);
    // 0x0
    DefineFunction(cs1, 0x9AA9, split_0000_9AA9_09AA9, false);
    // 0x94C
    DefineFunction(cs5, 0x5F7, unknown_094C_05F7_09AB7, false);
    // 0x0
    DefineFunction(cs1, 0xAAA6, ghidra_guess_0000_AAA6_0AAA6, false);
    DefineFunction(cs1, 0xB046, split_0000_B046_0B046, false);
    // 0x94C
    DefineFunction(cs5, 0x1D30, unknown_094C_1D30_0B1F0, false);
    // 0x0
    DefineFunction(cs1, 0xCCD4, ghidra_guess_0000_CCD4_0CCD4, false);
    DefineFunction(cs1, 0xCEB9, ghidra_guess_0000_CEB9_0CEB9, false);
    DefineFunction(cs1, 0xCF58, ghidra_guess_0000_CF58_0CF58, false);
    DefineFunction(cs1, 0xCF78, ghidra_guess_0000_CF78_0CF78, false);
    DefineFunction(cs1, 0xCFA2, ghidra_guess_0000_CFA2_0CFA2, false);
    DefineFunction(cs1, 0xCFF7, ghidra_guess_0000_CFF7_0CFF7, false);
    DefineFunction(cs1, 0xD07A, ghidra_guess_0000_D07A_0D07A, false);
    DefineFunction(cs1, 0xD17B, ghidra_guess_0000_D17B_0D17B, false);
    DefineFunction(cs1, 0xD22A, ghidra_guess_0000_D22A_0D22A, false);
    DefineFunction(cs1, 0xD46C, ghidra_guess_0000_D46C_0D46C, false);
    DefineFunction(cs1, 0xD5E3, ghidra_guess_0000_D5E3_0D5E3, false);
    DefineFunction(cs1, 0xD650, ghidra_guess_0000_D650_0D650, false);
    DefineFunction(cs1, 0xD786, ghidra_guess_0000_D786_0D786, false);
    DefineFunction(cs1, 0xDA1A, ghidra_guess_0000_DA1A_0DA1A, false);
    DefineFunction(cs1, 0xE618, ghidra_guess_0000_E618_0E618, false);
    DefineFunction(cs1, 0xE7E5, split_0000_E7E5_0E7E5, false);
    DefineFunction(cs1, 0xE908, ghidra_guess_0000_E908_0E908, false);
    DefineFunction(cs1, 0xEAEE, ghidra_guess_0000_EAEE_0EAEE, false);
    DefineFunction(cs1, 0xEB34, ghidra_guess_0000_EB34_0EB34, false);
    DefineFunction(cs1, 0xF2FB, ghidra_guess_0000_F2FB_0F2FB, false);
    DefineFunction(cs1, 0xF565, ghidra_guess_0000_F565_0F565, false);
    DefineFunction(cs1, 0xF7A2, ghidra_guess_0000_F7A2_0F7A2, false);
    // 0xFA1
    DefineFunction(cs6, 0x6, unknown_0FA1_0006_0FA16, false);
    // 0x0
    DefineFunction(cs1, 0xFCF4, ghidra_guess_0000_FCF4_0FCF4, false);
    DefineFunction(cs1, 0xFD3F, ghidra_guess_0000_FD3F_0FD3F, false);
    // 0x1000
    DefineFunction(cs7, 0x5C5, ghidra_guess_1000_05C5_105C5, false);
    DefineFunction(cs7, 0x673, ghidra_guess_1000_0673_10673, false);
    DefineFunction(cs7, 0x934, ghidra_guess_1000_0934_10934, false);
    DefineFunction(cs7, 0xA67, ghidra_guess_1000_0A67_10A67, false);
    DefineFunction(cs7, 0xAB2, ghidra_guess_1000_0AB2_10AB2, false);
    DefineFunction(cs7, 0xB32, ghidra_guess_1000_0B32_10B32, false);
    DefineFunction(cs7, 0xBB4, split_1000_0BB4_10BB4, false);
    DefineFunction(cs7, 0xBBB, ghidra_guess_1000_0BBB_10BBB, false);
    DefineFunction(cs7, 0x1005, split_1000_1005_11005, false);
    // 0xFA1
    DefineFunction(cs6, 0x16AB, unknown_0FA1_16AB_110BB, false);
    // 0x1000
    DefineFunction(cs7, 0x1554, ghidra_guess_1000_1554_11554, false);
    DefineFunction(cs7, 0x159F, ghidra_guess_1000_159F_1159F, false);
    DefineFunction(cs7, 0x160E, ghidra_guess_1000_160E_1160E, false);
    DefineFunction(cs7, 0x17BB, ghidra_guess_1000_17BB_117BB, false);
    DefineFunction(cs7, 0x17DC, ghidra_guess_1000_17DC_117DC, false);
    DefineFunction(cs7, 0x1808, ghidra_guess_1000_1808_11808, false);
    DefineFunction(cs7, 0x18B2, ghidra_guess_1000_18B2_118B2, false);
    DefineFunction(cs7, 0x1919, ghidra_guess_1000_1919_11919, false);
    DefineFunction(cs7, 0x1983, ghidra_guess_1000_1983_11983, false);
    // 0xFA1
    DefineFunction(cs6, 0x1FDF, unknown_0FA1_1FDF_119EF, false);
    // 0x1000
    DefineFunction(cs7, 0x1ABA, ghidra_guess_1000_1ABA_11ABA, false);
    DefineFunction(cs7, 0x2F32, ghidra_guess_1000_2F32_12F32, false);
    DefineFunction(cs7, 0x2F73, ghidra_guess_1000_2F73_12F73, false);
    DefineFunction(cs7, 0x3224, ghidra_guess_1000_3224_13224, false);
    DefineFunction(cs7, 0x33EB, ghidra_guess_1000_33EB_133EB, false);
    DefineFunction(cs7, 0x36CF, ghidra_guess_1000_36CF_136CF, false);
    DefineFunction(cs7, 0x3B0F, split_1000_3B0F_13B0F, false);
    DefineFunction(cs7, 0x3CD6, ghidra_guess_1000_3CD6_13CD6, false);
    DefineFunction(cs7, 0x3CE1, ghidra_guess_1000_3CE1_13CE1, false);
    DefineFunction(cs7, 0x3D6C, ghidra_guess_1000_3D6C_13D6C, false);
    DefineFunction(cs7, 0x3F24, ghidra_guess_1000_3F24_13F24, false);
    DefineFunction(cs7, 0x3FA0, ghidra_guess_1000_3FA0_13FA0, false);
    DefineFunction(cs7, 0x4006, ghidra_guess_1000_4006_14006, false);
    DefineFunction(cs7, 0x4041, ghidra_guess_1000_4041_14041, false);
    DefineFunction(cs7, 0x41ED, ghidra_guess_1000_41ED_141ED, false);
    DefineFunction(cs7, 0x4279, ghidra_guess_1000_4279_14279, false);
    DefineFunction(cs7, 0x42E5, ghidra_guess_1000_42E5_142E5, false);
    DefineFunction(cs7, 0x438B, ghidra_guess_1000_438B_1438B, false);
    DefineFunction(cs7, 0x4553, ghidra_guess_1000_4553_14553, false);
    DefineFunction(cs7, 0x458C, ghidra_guess_1000_458C_1458C, false);
    DefineFunction(cs7, 0x5847, ghidra_guess_1000_5847_15847, false);
    DefineFunction(cs7, 0x63C6, ghidra_guess_1000_63C6_163C6, false);
    // 0x1643
    DefineFunction(cs8, 0x4, unknown_1643_0004_16434, false);
    // 0x1000
    DefineFunction(cs7, 0x65E5, split_1000_65E5_165E5, false);
    DefineFunction(cs7, 0x6ABC, split_1000_6ABC_16ABC, false);
    DefineFunction(cs7, 0x6D87, split_1000_6D87_16D87, false);
    // 0x1643
    DefineFunction(cs8, 0x96F, spice86_imported_label_jump_target_1643_096F_16D9F, false);
    // 0x1000
    DefineFunction(cs7, 0x7400, split_1000_7400_17400, false);
    DefineFunction(cs7, 0x7BF0, split_1000_7BF0_17BF0, false);
    // 0x1643
    DefineFunction(cs8, 0x17C6, unknown_1643_17C6_17BF6, false);
    // 0x1000
    DefineFunction(cs7, 0x7C1A, ghidra_guess_1000_7C1A_17C1A, false);
    DefineFunction(cs7, 0x7C39, ghidra_guess_1000_7C39_17C39, false);
    DefineFunction(cs7, 0x7C4E, ghidra_guess_1000_7C4E_17C4E, false);
    // 0x17C6
    DefineFunction(cs9, 0x4, unknown_17C6_0004_17C64, false);
    DefineFunction(cs9, 0x1E7, unknown_17C6_01E7_17E47, false);
    DefineFunction(cs9, 0x281, unknown_17C6_0281_17EE1, false);
    DefineFunction(cs9, 0x388, unknown_17C6_0388_17FE8, false);
    DefineFunction(cs9, 0x3F5, unknown_17C6_03F5_18055, false);
    DefineFunction(cs9, 0x7CB, unknown_17C6_07CB_1842B, false);
    DefineFunction(cs9, 0xA3B, unknown_17C6_0A3B_1869B, false);
    DefineFunction(cs9, 0xAE5, unknown_17C6_0AE5_18745, false);
    DefineFunction(cs9, 0xB5E, unknown_17C6_0B5E_187BE, false);
    DefineFunction(cs9, 0xD1D, unknown_17C6_0D1D_1897D, false);
    // 0x1000
    DefineFunction(cs7, 0x8AD1, split_1000_8AD1_18AD1, false);
    // 0x18AD
    DefineFunction(cs10, 0x6, unknown_18AD_0006_18AD6, false);
    DefineFunction(cs10, 0x2F, unknown_18AD_002F_18AFF, false);
    // 0x1000
    DefineFunction(cs7, 0x8B23, ghidra_guess_1000_8B23_18B23, false);
    // 0x18AD
    DefineFunction(cs10, 0x86, unknown_18AD_0086_18B56, false);
    DefineFunction(cs10, 0xD5, unknown_18AD_00D5_18BA5, false);
    DefineFunction(cs10, 0x1FB, unknown_18AD_01FB_18CCB, false);
    DefineFunction(cs10, 0x259, unknown_18AD_0259_18D29, false);
    DefineFunction(cs10, 0x31C, unknown_18AD_031C_18DEC, false);
    DefineFunction(cs10, 0x3EB, unknown_18AD_03EB_18EBB, false);
    DefineFunction(cs10, 0x49D, unknown_18AD_049D_18F6D, false);
    DefineFunction(cs10, 0x525, unknown_18AD_0525_18FF5, false);
    DefineFunction(cs10, 0x5BC, unknown_18AD_05BC_1908C, false);
    DefineFunction(cs10, 0x63B, unknown_18AD_063B_1910B, false);
    DefineFunction(cs10, 0x6C3, unknown_18AD_06C3_19193, false);
    DefineFunction(cs10, 0x70A, unknown_18AD_070A_191DA, false);
    DefineFunction(cs10, 0x814, unknown_18AD_0814_192E4, false);
    // 0x1000
    DefineFunction(cs7, 0x933A, ghidra_guess_1000_933A_1933A, false);
    DefineFunction(cs7, 0x9352, ghidra_guess_1000_9352_19352, false);
    DefineFunction(cs7, 0x95F3, ghidra_guess_1000_95F3_195F3, false);
    DefineFunction(cs7, 0x963B, ghidra_guess_1000_963B_1963B, false);
    DefineFunction(cs7, 0x9695, ghidra_guess_1000_9695_19695, false);
    DefineFunction(cs7, 0x96F8, ghidra_guess_1000_96F8_196F8, false);
    DefineFunction(cs7, 0x975B, ghidra_guess_1000_975B_1975B, false);
    DefineFunction(cs7, 0x97BE, ghidra_guess_1000_97BE_197BE, false);
    DefineFunction(cs7, 0x97CB, ghidra_guess_1000_97CB_197CB, false);
    DefineFunction(cs7, 0x9834, ghidra_guess_1000_9834_19834, false);
    DefineFunction(cs7, 0x9841, ghidra_guess_1000_9841_19841, false);
    DefineFunction(cs7, 0x98EA, ghidra_guess_1000_98EA_198EA, false);
    DefineFunction(cs7, 0x9993, ghidra_guess_1000_9993_19993, false);
    DefineFunction(cs7, 0x9A46, ghidra_guess_1000_9A46_19A46, false);
    DefineFunction(cs7, 0x9A97, ghidra_guess_1000_9A97_19A97, false);
    DefineFunction(cs7, 0x9B2A, ghidra_guess_1000_9B2A_19B2A, false);
    // 0x19BB
    DefineFunction(cs11, 0x20, interrupt_handler_0x8_19BB_0020_19BD0, false);
    DefineFunction(cs11, 0x48, unknown_19BB_0048_19BF8, false);
    DefineFunction(cs11, 0x91, unknown_19BB_0091_19C41, false);
    DefineFunction(cs11, 0xB2, unknown_19BB_00B2_19C62, false);
    DefineFunction(cs11, 0xBD, unknown_19BB_00BD_19C6D, false);
    DefineFunction(cs11, 0xC6, unknown_19BB_00C6_19C76, false);
    DefineFunction(cs11, 0xCF, unknown_19BB_00CF_19C7F, false);
    DefineFunction(cs11, 0x139, unknown_19BB_0139_19CE9, false);
    DefineFunction(cs11, 0x179, unknown_19BB_0179_19D29, false);
    DefineFunction(cs11, 0x186, unknown_19BB_0186_19D36, false);
    DefineFunction(cs11, 0x233, unknown_19BB_0233_19DE3, false);
    DefineFunction(cs11, 0x298, unknown_19BB_0298_19E48, false);
    // 0x1000
    DefineFunction(cs7, 0x9E94, ghidra_guess_1000_9E94_19E94, false);
    // 0x19BB
    DefineFunction(cs11, 0x306, unknown_19BB_0306_19EB6, false);
    DefineFunction(cs11, 0x33C, unknown_19BB_033C_19EEC, false);
    // 0x1000
    DefineFunction(cs7, 0x9F0C, ghidra_guess_1000_9F0C_19F0C, false);
    DefineFunction(cs7, 0x9F20, ghidra_guess_1000_9F20_19F20, false);
    DefineFunction(cs7, 0x9F41, ghidra_guess_1000_9F41_19F41, false);
    DefineFunction(cs7, 0x9F57, ghidra_guess_1000_9F57_19F57, false);
    DefineFunction(cs7, 0x9F6D, ghidra_guess_1000_9F6D_19F6D, false);
    DefineFunction(cs7, 0x9F99, ghidra_guess_1000_9F99_19F99, false);
    // 0x19EF
    DefineFunction(cs12, 0xD1, unknown_19EF_00D1_19FC1, false);
    // 0x1000
    DefineFunction(cs7, 0xA03C, ghidra_guess_1000_A03C_1A03C, false);
    DefineFunction(cs7, 0xA053, ghidra_guess_1000_A053_1A053, false);
    DefineFunction(cs7, 0xA0B6, split_1000_A0B6_1A0B6, false);
    DefineFunction(cs7, 0xA0C0, ghidra_guess_1000_A0C0_1A0C0, false);
    DefineFunction(cs7, 0xA0C7, ghidra_guess_1000_A0C7_1A0C7, false);
    // 0x19EF
    DefineFunction(cs12, 0x213, unknown_19EF_0213_1A103, false);
    // 0x1000
    DefineFunction(cs7, 0xA11A, ghidra_guess_1000_A11A_1A11A, false);
    DefineFunction(cs7, 0xA150, ghidra_guess_1000_A150_1A150, false);
    DefineFunction(cs7, 0xA203, ghidra_guess_1000_A203_1A203, false);
    DefineFunction(cs7, 0xA267, ghidra_guess_1000_A267_1A267, false);
    DefineFunction(cs7, 0xA337, split_1000_A337_1A337, false);
    DefineFunction(cs7, 0xA33A, ghidra_guess_1000_A33A_1A33A, false);
    DefineFunction(cs7, 0xA458, ghidra_guess_1000_A458_1A458, false);
    DefineFunction(cs7, 0xA462, ghidra_guess_1000_A462_1A462, false);
    DefineFunction(cs7, 0xA4AF, ghidra_guess_1000_A4AF_1A4AF, false);
    // 0x19EF
    DefineFunction(cs12, 0x5D0, unknown_19EF_05D0_1A4C0, false);
    // 0x1000
    DefineFunction(cs7, 0xA56F, split_1000_A56F_1A56F, false);
    DefineFunction(cs7, 0xA5E1, split_1000_A5E1_1A5E1, false);
    DefineFunction(cs7, 0xA5ED, ghidra_guess_1000_A5ED_1A5ED, false);
    // 0x19EF
    DefineFunction(cs12, 0x780, unknown_19EF_0780_1A670, false);
    // 0x1000
    DefineFunction(cs7, 0xA6C8, split_1000_A6C8_1A6C8, false);
    DefineFunction(cs7, 0xA6FE, split_1000_A6FE_1A6FE, false);
    DefineFunction(cs7, 0xA744, ghidra_guess_1000_A744_1A744, false);
    DefineFunction(cs7, 0xA791, ghidra_guess_1000_A791_1A791, false);
    // 0x19EF
    DefineFunction(cs12, 0x931, unknown_19EF_0931_1A821, false);
    DefineFunction(cs12, 0x971, unknown_19EF_0971_1A861, false);
    // 0x1000
    DefineFunction(cs7, 0xA8C6, split_1000_A8C6_1A8C6, false);
    DefineFunction(cs7, 0xA916, ghidra_guess_1000_A916_1A916, false);
    // 0x19EF
    DefineFunction(cs12, 0xA76, unknown_19EF_0A76_1A966, false);
    // 0x1000
    DefineFunction(cs7, 0xA98F, ghidra_guess_1000_A98F_1A98F, false);
    // 0x19EF
    DefineFunction(cs12, 0xB26, unknown_19EF_0B26_1AA16, false);
    DefineFunction(cs12, 0xB40, unknown_19EF_0B40_1AA30, false);
    DefineFunction(cs12, 0xB73, unknown_19EF_0B73_1AA63, false);
    DefineFunction(cs12, 0xB8A, unknown_19EF_0B8A_1AA7A, false);
    // 0x1000
    DefineFunction(cs7, 0xAA97, ghidra_guess_1000_AA97_1AA97, false);
    // 0x19EF
    DefineFunction(cs12, 0xBC0, unknown_19EF_0BC0_1AAB0, false);
    DefineFunction(cs12, 0xBFB, unknown_19EF_0BFB_1AAEB, false);
    DefineFunction(cs12, 0xD07, unknown_19EF_0D07_1ABF7, false);
    DefineFunction(cs12, 0xD79, unknown_19EF_0D79_1AC69, false);
    DefineFunction(cs12, 0xDF8, unknown_19EF_0DF8_1ACE8, false);
    DefineFunction(cs12, 0xFEE, unknown_19EF_0FEE_1AEDE, false);
    DefineFunction(cs12, 0x104E, unknown_19EF_104E_1AF3E, false);
    DefineFunction(cs12, 0x11BB, unknown_19EF_11BB_1B0AB, false);
    // 0x1000
    DefineFunction(cs7, 0xB122, split_1000_B122_1B122, false);
    // 0x19EF
    DefineFunction(cs12, 0x12BA, unknown_19EF_12BA_1B1AA, false);
    DefineFunction(cs12, 0x12D9, unknown_19EF_12D9_1B1C9, false);
    DefineFunction(cs12, 0x12F2, unknown_19EF_12F2_1B1E2, false);
    DefineFunction(cs12, 0x1303, unknown_19EF_1303_1B1F3, false);
    DefineFunction(cs12, 0x1314, unknown_19EF_1314_1B204, false);
    DefineFunction(cs12, 0x13D9, unknown_19EF_13D9_1B2C9, false);
    // 0x1000
    DefineFunction(cs7, 0xB3E0, split_1000_B3E0_1B3E0, false);
    DefineFunction(cs7, 0xB455, split_1000_B455_1B455, false);
    DefineFunction(cs7, 0xB47C, ghidra_guess_1000_B47C_1B47C, false);
    // 0x19EF
    DefineFunction(cs12, 0x163B, unknown_19EF_163B_1B52B, false);
    DefineFunction(cs12, 0x16E3, unknown_19EF_16E3_1B5D3, false);
    DefineFunction(cs12, 0x17C5, unknown_19EF_17C5_1B6B5, false);
    DefineFunction(cs12, 0x1886, unknown_19EF_1886_1B776, false);
    // 0x1000
    DefineFunction(cs7, 0xB7C8, ghidra_guess_1000_B7C8_1B7C8, false);
    // 0x19EF
    DefineFunction(cs12, 0x18EF, unknown_19EF_18EF_1B7DF, false);
    DefineFunction(cs12, 0x1AA8, unknown_19EF_1AA8_1B998, false);
    DefineFunction(cs12, 0x1ACE, unknown_19EF_1ACE_1B9BE, false);
    DefineFunction(cs12, 0x1AF4, unknown_19EF_1AF4_1B9E4, false);
    DefineFunction(cs12, 0x1B1A, unknown_19EF_1B1A_1BA0A, false);
    // 0x1000
    DefineFunction(cs7, 0xBA61, ghidra_guess_1000_BA61_1BA61, false);
    // 0x19EF
    DefineFunction(cs12, 0x1B94, unknown_19EF_1B94_1BA84, false);
    // 0x1000
    DefineFunction(cs7, 0xBACF, ghidra_guess_1000_BACF_1BACF, false);
    // 0x19EF
    DefineFunction(cs12, 0x1BFC, unknown_19EF_1BFC_1BAEC, false);
    // 0x1000
    DefineFunction(cs7, 0xBB73, ghidra_guess_1000_BB73_1BB73, false);
    DefineFunction(cs7, 0xBBA8, ghidra_guess_1000_BBA8_1BBA8, false);
    DefineFunction(cs7, 0xBC00, split_1000_BC00_1BC00, false);
    // 0x19EF
    DefineFunction(cs12, 0x1D3A, unknown_19EF_1D3A_1BC2A, false);
    DefineFunction(cs12, 0x1D8C, unknown_19EF_1D8C_1BC7C, false);
    DefineFunction(cs12, 0x1DA8, unknown_19EF_1DA8_1BC98, false);
    DefineFunction(cs12, 0x1DF8, unknown_19EF_1DF8_1BCE8, false);
    DefineFunction(cs12, 0x1E37, unknown_19EF_1E37_1BD27, false);
    // 0x1000
    DefineFunction(cs7, 0xBDBE, ghidra_guess_1000_BDBE_1BDBE, false);
    DefineFunction(cs7, 0xBDF4, ghidra_guess_1000_BDF4_1BDF4, false);
    DefineFunction(cs7, 0xBE41, ghidra_guess_1000_BE41_1BE41, false);
    // 0x19EF
    DefineFunction(cs12, 0x1F9C, unknown_19EF_1F9C_1BE8C, false);
    DefineFunction(cs12, 0x1FAD, unknown_19EF_1FAD_1BE9D, false);
    DefineFunction(cs12, 0x1FBE, unknown_19EF_1FBE_1BEAE, false);
    // 0x1000
    DefineFunction(cs7, 0xBEE6, split_1000_BEE6_1BEE6, false);
    // 0x19EF
    DefineFunction(cs12, 0x200E, unknown_19EF_200E_1BEFE, false);
    // 0x1000
    DefineFunction(cs7, 0xBFC5, split_1000_BFC5_1BFC5, false);
    // 0x19EF
    DefineFunction(cs12, 0x2127, unknown_19EF_2127_1C017, false);
    // 0x1000
    DefineFunction(cs7, 0xC098, ghidra_guess_1000_C098_1C098, false);
    DefineFunction(cs7, 0xC0F9, ghidra_guess_1000_C0F9_1C0F9, false);
    DefineFunction(cs7, 0xC141, ghidra_guess_1000_C141_1C141, false);
    // 0x19EF
    DefineFunction(cs12, 0x22A5, unknown_19EF_22A5_1C195, false);
    // 0x1000
    DefineFunction(cs7, 0xC1D3, split_1000_C1D3_1C1D3, false);
    // 0x19EF
    DefineFunction(cs12, 0x22F8, unknown_19EF_22F8_1C1E8, false);
    // 0x1000
    DefineFunction(cs7, 0xC21F, split_1000_C21F_1C21F, false);
    DefineFunction(cs7, 0xC226, split_1000_C226_1C226, false);
    // 0x19EF
    DefineFunction(cs12, 0x2368, unknown_19EF_2368_1C258, false);
    // 0x1000
    DefineFunction(cs7, 0xC28F, split_1000_C28F_1C28F, false);
    DefineFunction(cs7, 0xC296, split_1000_C296_1C296, false);
    // 0x19EF
    DefineFunction(cs12, 0x23EC, unknown_19EF_23EC_1C2DC, false);
    // 0x1000
    DefineFunction(cs7, 0xC309, split_1000_C309_1C309, false);
    DefineFunction(cs7, 0xC312, split_1000_C312_1C312, false);
    // 0x19EF
    DefineFunction(cs12, 0x245C, unknown_19EF_245C_1C34C, false);
    DefineFunction(cs12, 0x24D7, unknown_19EF_24D7_1C3C7, false);
    DefineFunction(cs12, 0x275C, unknown_19EF_275C_1C64C, false);
    // 0x1000
    DefineFunction(cs7, 0xC6CE, split_1000_C6CE_1C6CE, false);
    DefineFunction(cs7, 0xC710, ghidra_guess_1000_C710_1C710, false);
    DefineFunction(cs7, 0xC73D, ghidra_guess_1000_C73D_1C73D, false);
    // 0x19EF
    DefineFunction(cs12, 0x28A8, unknown_19EF_28A8_1C798, false);
    DefineFunction(cs12, 0x28EB, unknown_19EF_28EB_1C7DB, false);
    // 0x1000
    DefineFunction(cs7, 0xC8AD, split_1000_C8AD_1C8AD, false);
    DefineFunction(cs7, 0xC8B0, split_1000_C8B0_1C8B0, false);
    DefineFunction(cs7, 0xC90E, ghidra_guess_1000_C90E_1C90E, false);
    DefineFunction(cs7, 0xC9D9, split_1000_C9D9_1C9D9, false);
    DefineFunction(cs7, 0xC9DC, ghidra_guess_1000_C9DC_1C9DC, false);
    DefineFunction(cs7, 0xCA35, ghidra_guess_1000_CA35_1CA35, false);
    // 0x19EF
    DefineFunction(cs12, 0x2B87, unknown_19EF_2B87_1CA77, false);
    // 0x1000
    DefineFunction(cs7, 0xCB38, split_1000_CB38_1CB38, false);
    DefineFunction(cs7, 0xCBA0, ghidra_guess_1000_CBA0_1CBA0, false);
    // 0x19EF
    DefineFunction(cs12, 0x2CE1, unknown_19EF_2CE1_1CBD1, false);
    DefineFunction(cs12, 0x2CF7, unknown_19EF_2CF7_1CBE7, false);
    // 0x1000
    DefineFunction(cs7, 0xCC29, split_1000_CC29_1CC29, false);
    DefineFunction(cs7, 0xCC54, ghidra_guess_1000_CC54_1CC54, false);
    // 0x19EF
    DefineFunction(cs12, 0x2D82, spice86_imported_label_jump_target_19EF_2D82_1CC72, false);
    // 0x1000
    DefineFunction(cs7, 0xCE04, ghidra_guess_1000_CE04_1CE04, false);
    DefineFunction(cs7, 0xCE1E, split_1000_CE1E_1CE1E, false);
    DefineFunction(cs7, 0xCE62, ghidra_guess_1000_CE62_1CE62, false);
    // 0x19EF
    DefineFunction(cs12, 0x2F9F, unknown_19EF_2F9F_1CE8F, false);
    // 0x1000
    DefineFunction(cs7, 0xCEA2, ghidra_guess_1000_CEA2_1CEA2, false);
    DefineFunction(cs7, 0xCEC6, ghidra_guess_1000_CEC6_1CEC6, false);
    // 0x19EF
    DefineFunction(cs12, 0x2FDC, unknown_19EF_2FDC_1CECC, false);
    // 0x1000
    DefineFunction(cs7, 0xCEF0, ghidra_guess_1000_CEF0_1CEF0, false);
    // 0x19EF
    DefineFunction(cs12, 0x3026, unknown_19EF_3026_1CF16, false);
    // 0x1000
    DefineFunction(cs7, 0xD031, split_1000_D031_1D031, false);
    // 0x19EF
    DefineFunction(cs12, 0x31CE, unknown_19EF_31CE_1D0BE, false);
    // 0x1000
    DefineFunction(cs7, 0xD13A, ghidra_guess_1000_D13A_1D13A, false);
    DefineFunction(cs7, 0xD165, ghidra_guess_1000_D165_1D165, false);
    // 0x19EF
    DefineFunction(cs12, 0x32A0, unknown_19EF_32A0_1D190, false);
    // 0x1000
    DefineFunction(cs7, 0xD1D2, split_1000_D1D2_1D1D2, false);
    // 0x19EF
    DefineFunction(cs12, 0x32F5, spice86_imported_label_jump_target_19EF_32F5_1D1E5, false);
    // 0x1000
    DefineFunction(cs7, 0xD1F8, ghidra_guess_1000_D1F8_1D1F8, false);
    DefineFunction(cs7, 0xD213, split_1000_D213_1D213, false);
    // 0x19EF
    DefineFunction(cs12, 0x3336, unknown_19EF_3336_1D226, false);
    DefineFunction(cs12, 0x3356, unknown_19EF_3356_1D246, false);
    DefineFunction(cs12, 0x33D0, unknown_19EF_33D0_1D2C0, false);
    // 0x1000
    DefineFunction(cs7, 0xD360, split_1000_D360_1D360, false);
    DefineFunction(cs7, 0xD3A9, split_1000_D3A9_1D3A9, false);
    DefineFunction(cs7, 0xD45F, ghidra_guess_1000_D45F_1D45F, false);
    // 0x19EF
    DefineFunction(cs12, 0x3580, unknown_19EF_3580_1D470, false);
    // 0x1000
    DefineFunction(cs7, 0xD55A, ghidra_guess_1000_D55A_1D55A, false);
    DefineFunction(cs7, 0xD60E, ghidra_guess_1000_D60E_1D60E, false);
    DefineFunction(cs7, 0xD659, ghidra_guess_1000_D659_1D659, false);
    DefineFunction(cs7, 0xD66A, ghidra_guess_1000_D66A_1D66A, false);
    DefineFunction(cs7, 0xD6A4, ghidra_guess_1000_D6A4_1D6A4, false);
    DefineFunction(cs7, 0xD6CA, ghidra_guess_1000_D6CA_1D6CA, false);
    // 0x19EF
    DefineFunction(cs12, 0x3835, unknown_19EF_3835_1D725, false);
    DefineFunction(cs12, 0x3874, unknown_19EF_3874_1D764, false);
    DefineFunction(cs12, 0x38E2, unknown_19EF_38E2_1D7D2, false);
    DefineFunction(cs12, 0x38FD, unknown_19EF_38FD_1D7ED, false);
    DefineFunction(cs12, 0x39E0, unknown_19EF_39E0_1D8D0, false);
    DefineFunction(cs12, 0x3A1A, unknown_19EF_3A1A_1D90A, false);
    DefineFunction(cs12, 0x3A3C, unknown_19EF_3A3C_1D92C, false);
    DefineFunction(cs12, 0x3A5E, unknown_19EF_3A5E_1D94E, false);
    DefineFunction(cs12, 0x3ACC, unknown_19EF_3ACC_1D9BC, false);
    DefineFunction(cs12, 0x3B22, unknown_19EF_3B22_1DA12, false);
    DefineFunction(cs12, 0x3B68, unknown_19EF_3B68_1DA58, false);
    DefineFunction(cs12, 0x3B9E, unknown_19EF_3B9E_1DA8E, false);
    DefineFunction(cs12, 0x3BB6, unknown_19EF_3BB6_1DAA6, false);
    DefineFunction(cs12, 0x3BD2, unknown_19EF_3BD2_1DAC2, false);
    DefineFunction(cs12, 0x3BDC, unknown_19EF_3BDC_1DACC, false);
    DefineFunction(cs12, 0x3C08, spice86_imported_label_jump_target_19EF_3C08_1DAF8, false);
    // 0x1000
    DefineFunction(cs7, 0xDB5C, ghidra_guess_1000_DB5C_1DB5C, false);
    // 0x19EF
    DefineFunction(cs12, 0x3C82, unknown_19EF_3C82_1DB72, false);
    DefineFunction(cs12, 0x3D1C, unknown_19EF_3D1C_1DC0C, false);
    DefineFunction(cs12, 0x3D44, unknown_19EF_3D44_1DC34, false);
    // 0x1000
    DefineFunction(cs7, 0xDC5C, ghidra_guess_1000_DC5C_1DC5C, false);
    // 0x19EF
    DefineFunction(cs12, 0x3D92, unknown_19EF_3D92_1DC82, false);
    DefineFunction(cs12, 0x3E2E, unknown_19EF_3E2E_1DD1E, false);
    DefineFunction(cs12, 0x3E62, unknown_19EF_3E62_1DD52, false);
    // 0x1000
    DefineFunction(cs7, 0xDDB4, ghidra_guess_1000_DDB4_1DDB4, false);
    DefineFunction(cs7, 0xE6D1, split_1000_E6D1_1E6D1, false);
    DefineFunction(cs7, 0xE903, split_1000_E903_1E903, false);
    DefineFunction(cs7, 0xFA7E, ghidra_guess_1000_FA7E_1FA7E, false);
    // 0x24D7
    DefineFunction(cs14, 0x10, entry_24D7_0010_24D80, false);
    // 0x2000
    DefineFunction(cs13, 0x4E82, split_2000_4E82_24E82, false);
    DefineFunction(cs13, 0x4F21, split_2000_4F21_24F21, false);
    DefineFunction(cs13, 0x504B, split_2000_504B_2504B, false);
    DefineFunction(cs13, 0x58BE, ghidra_guess_2000_58BE_258BE, false);
    DefineFunction(cs13, 0xBD61, ghidra_guess_2000_BD61_2BD61, false);
    DefineFunction(cs13, 0xD00E, ghidra_guess_2000_D00E_2D00E, false);
    DefineFunction(cs13, 0xD026, ghidra_guess_2000_D026_2D026, false);
    // 0xF000
    DefineFunction(cs15, 0x0, provided_interrupt_handler_10_F000_0000_F0000, false);
    DefineFunction(cs15, 0x5, provided_interrupt_handler_1C_F000_0005_F0005, false);
    DefineFunction(cs15, 0x6, provided_interrupt_handler_8_F000_0006_F0006, false);
    DefineFunction(cs15, 0x11, provided_interrupt_handler_9_F000_0011_F0011, false);
    DefineFunction(cs15, 0x16, provided_interrupt_handler_11_F000_0016_F0016, false);
    DefineFunction(cs15, 0x1B, provided_interrupt_handler_12_F000_001B_F001B, false);
    DefineFunction(cs15, 0x20, provided_interrupt_handler_15_F000_0020_F0020, false);
    DefineFunction(cs15, 0x25, provided_interrupt_handler_16_F000_0025_F0025, false);
    DefineFunction(cs15, 0x3E, provided_interrupt_handler_1A_F000_003E_F003E, false);
    DefineFunction(cs15, 0x43, provided_interrupt_handler_13_F000_0043_F0043, false);
    DefineFunction(cs15, 0x49, provided_interrupt_handler_74_F000_0049_F0049, false);
    DefineFunction(cs15, 0x53, provided_interrupt_handler_B_F000_0053_F0053, false);
    DefineFunction(cs15, 0x58, provided_interrupt_handler_C_F000_0058_F0058, false);
    DefineFunction(cs15, 0x5D, provided_interrupt_handler_D_F000_005D_F005D, false);
    DefineFunction(cs15, 0x62, provided_interrupt_handler_F_F000_0062_F0062, false);
    DefineFunction(cs15, 0x67, provided_interrupt_handler_72_F000_0067_F0067, false);
    DefineFunction(cs15, 0x6C, provided_interrupt_handler_73_F000_006C_F006C, false);
    DefineFunction(cs15, 0x71, provided_interrupt_handler_20_F000_0071_F0071, false);
    DefineFunction(cs15, 0x76, provided_interrupt_handler_21_F000_0076_F0076, false);
    DefineFunction(cs15, 0x7B, provided_interrupt_handler_2F_F000_007B_F007B, false);
    DefineFunction(cs15, 0x80, provided_interrupt_handler_25_F000_0080_F0080, false);
    DefineFunction(cs15, 0x85, provided_interrupt_handler_26_F000_0085_F0085, false);
    DefineFunction(cs15, 0x8A, provided_interrupt_handler_28_F000_008A_F008A, false);
    DefineFunction(cs15, 0x8F, provided_interrupt_handler_33_F000_008F_F008F, false);
    DefineFunction(cs15, 0x94, unknown_F000_0094_F0094, false);
    DefineFunction(cs15, 0x95, provided_mouse_driver_F000_0095_F0095, false);
    // 0xF100
    DefineFunction(cs16, 0x0, provided_interrupt_handler_67_F100_0000_F1000, false);
  }
  
  
  
  public virtual Action ghidra_guess_0000_000C_0000C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_000C_0000C:
    CheckExternalEvents(cs1, 0xE);
    // ADD byte ptr [BX + SI],AL (0000_000C / 0xC)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10);
    // ADD byte ptr [BX + SI],AL (0000_000E / 0xE)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x12);
    // ADD byte ptr [BX + SI],AL (0000_0010 / 0x10)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x14);
    // ADD byte ptr [BX + SI],AL (0000_0012 / 0x12)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x16);
    // ADD byte ptr [BX + SI],AL (0000_0014 / 0x14)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x18);
    // ADD byte ptr [BX + SI],AL (0000_0016 / 0x16)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x1A);
    // ADD byte ptr [BX + SI],AL (0000_0018 / 0x18)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x1C);
    // ADD byte ptr [BX + SI],AL (0000_001A / 0x1A)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x1E);
    // ADD byte ptr [BX + SI],AL (0000_001C / 0x1C)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x20);
    // ADD byte ptr [BX + SI],AL (0000_001E / 0x1E)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    CheckExternalEvents(cs1, 0x21);
    // PUSH ES (0000_0020 / 0x20)
    Stack.Push16(ES);
    CheckExternalEvents(cs1, 0x23);
    // ADD byte ptr [BX + SI],AL (0000_0021 / 0x21)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    CheckExternalEvents(cs1, 0x26);
    // LOCK
    while (CX != 0) {
      CX--;
      // ADC word ptr [BX + SI],AX (0000_0023 / 0x23)
      UInt16[DS, (ushort)(BX + SI)] = Alu.Adc16(UInt16[DS, (ushort)(BX + SI)], AX);
    }
    CheckExternalEvents(cs1, 0x28);
    // ADD AL,DH (0000_0026 / 0x26)
    AL += DH;
    CheckExternalEvents(cs1, 0x2A);
    // ADD byte ptr [BX + SI],AL (0000_0028 / 0x28)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x2C);
    // ADD byte ptr [BX + SI],AL (0000_002A / 0x2A)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    CheckExternalEvents(cs1, 0x2D);
    // PUSH BX (0000_002C / 0x2C)
    Stack.Push16(BX);
    CheckExternalEvents(cs1, 0x2F);
    // ADD byte ptr [BX + SI],AL (0000_002D / 0x2D)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_0000_05C5_005C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_05C5_005C5:
    CheckExternalEvents(cs1, 0x5C7);
    // ADD byte ptr [BX + SI],AL (0000_05C5 / 0x5C5)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5C9);
    // ADD byte ptr [BX + SI],AL (0000_05C7 / 0x5C7)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5CB);
    // ADD byte ptr [BX + SI],AL (0000_05C9 / 0x5C9)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5CD);
    // ADD byte ptr [BX + SI],AL (0000_05CB / 0x5CB)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5CF);
    // ADD byte ptr [BX + SI],AL (0000_05CD / 0x5CD)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5D1);
    // ADD byte ptr [BX + SI],AL (0000_05CF / 0x5CF)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5D3);
    // ADD byte ptr [BX + SI],AL (0000_05D1 / 0x5D1)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5D5);
    // ADD byte ptr [BX + SI],AL (0000_05D3 / 0x5D3)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5D7);
    // ADD byte ptr [BX + SI],AL (0000_05D5 / 0x5D5)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5D9);
    // ADD byte ptr [BX + SI],AL (0000_05D7 / 0x5D7)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5DB);
    // ADD byte ptr [BX + SI],AL (0000_05D9 / 0x5D9)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5DD);
    // ADD byte ptr [BX + SI],AL (0000_05DB / 0x5DB)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5DF);
    // ADD byte ptr [BX + SI],AL (0000_05DD / 0x5DD)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5E1);
    // ADD byte ptr [BX + SI],AL (0000_05DF / 0x5DF)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5E3);
    // ADD byte ptr [BX + SI],AL (0000_05E1 / 0x5E1)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5E5);
    // ADD byte ptr [BX + SI],AL (0000_05E3 / 0x5E3)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x5E7);
    // ADD byte ptr [BX + SI],AL (0000_05E5 / 0x5E5)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action ghidra_guess_0000_10BB_010BB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_10BB_010BB:
    CheckExternalEvents(cs1, 0x10BD);
    // ADD byte ptr [BX + SI],AL (0000_10BB / 0x10BB)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10BF);
    // ADD byte ptr [BX + SI],AL (0000_10BD / 0x10BD)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10C1);
    // ADD byte ptr [BX + SI],AL (0000_10BF / 0x10BF)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10C3);
    // ADD byte ptr [BX + SI],AL (0000_10C1 / 0x10C1)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10C5);
    // ADD byte ptr [BX + SI],AL (0000_10C3 / 0x10C3)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10C7);
    // ADD byte ptr [BX + SI],AL (0000_10C5 / 0x10C5)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10C9);
    // ADD byte ptr [BX + SI],AL (0000_10C7 / 0x10C7)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10CB);
    // ADD byte ptr [BX + SI],AL (0000_10C9 / 0x10C9)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10CD);
    // ADD byte ptr [BX + SI],AL (0000_10CB / 0x10CB)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10CF);
    // ADD byte ptr [BX + SI],AL (0000_10CD / 0x10CD)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10D1);
    // ADD byte ptr [BX + SI],AL (0000_10CF / 0x10CF)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10D3);
    // ADD byte ptr [BX + SI],AL (0000_10D1 / 0x10D1)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10D5);
    // ADD byte ptr [BX + SI],AL (0000_10D3 / 0x10D3)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10D7);
    // ADD byte ptr [BX + SI],AL (0000_10D5 / 0x10D5)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10D9);
    // ADD byte ptr [BX + SI],AL (0000_10D7 / 0x10D7)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10DB);
    // ADD byte ptr [BX + SI],AL (0000_10D9 / 0x10D9)
    UInt8[DS, (ushort)(BX + SI)] += AL;
    CheckExternalEvents(cs1, 0x10DD);
    // ADD byte ptr [BX + SI],AL (0000_10DB / 0x10DB)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action unknown_0170_0000_01700(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_0000_01700:
    CheckExternalEvents(cs2, 0x1);
    // PUSH BP (0170_0000 / 0x1700)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x3);
    // MOV BP,SP (0170_0001 / 0x1701)
    BP = SP;
    CheckExternalEvents(cs2, 0x6);
    // MOV AX,0x30 (0170_0003 / 0x1703)
    AX = 0x30;
    CheckExternalEvents(cs2, 0xB);
    // CALLF 0x1000:cecc (0170_0006 / 0x1706)
    FarCall(cs2, 0xB, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0xF);
    // MOV ES,word ptr [0x5384] (0170_000B / 0x170B)
    ES = UInt16[DS, 0x5384];
    CheckExternalEvents(cs2, 0x12);
    // MOV AX,word ptr [BP + 0x6] (0170_000F / 0x170F)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x16);
    // MOV ES:[0x3938],AX (0170_0012 / 0x1712)
    UInt16[ES, 0x3938] = AX;
    CheckExternalEvents(cs2, 0x18);
    // SUB AX,AX (0170_0016 / 0x1716)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x1B);
    // MOV word ptr [BP + -0x1a],AX (0170_0018 / 0x1718)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs2, 0x1E);
    // MOV [0x152],AX (0170_001B / 0x171B)
    UInt16[DS, 0x152] = AX;
    CheckExternalEvents(cs2, 0x1F);
    // PUSH AX (0170_001E / 0x171E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x22);
    // MOV AX,0xf (0170_001F / 0x171F)
    AX = 0xF;
    CheckExternalEvents(cs2, 0x23);
    // PUSH AX (0170_0022 / 0x1722)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x24);
    // PUSH CS (0170_0023 / 0x1723)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x27);
    // CALL 0x0000:5fb7 (0170_0024 / 0x1724)
    NearCall(cs2, 0x27, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs2, 0x2A);
    // ADD SP,0x4 (0170_0027 / 0x1727)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x2D);
    // JMP 0x0000:1c0d (0170_002A / 0x172A)
    goto label_0170_050D_01C0D;
    label_0170_002D_0172D:
    CheckExternalEvents(cs2, 0x32);
    // MOV word ptr [BP + -0x12],0x0 (0170_002D / 0x172D)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs2, 0x37);
    // CALLF 0x1000:8aff (0170_0032 / 0x1732)
    FarCall(cs2, 0x37, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs2, 0x39);
    // OR AX,AX (0170_0037 / 0x1737)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x3B);
    // JNZ 0x0000:173e (0170_0039 / 0x1739)
    if(!ZeroFlag) {
      goto label_0170_003E_0173E;
    }
    CheckExternalEvents(cs2, 0x3E);
    // JMP 0x0000:18f4 (0170_003B / 0x173B)
    goto label_0170_01F4_018F4;
    label_0170_003E_0173E:
    CheckExternalEvents(cs2, 0x43);
    // MOV word ptr [BP + -0x12],0x1 (0170_003E / 0x173E)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs2, 0x48);
    // CALLF 0x1000:8d29 (0170_0043 / 0x1743)
    FarCall(cs2, 0x48, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs2, 0x4B);
    // MOV word ptr [BP + -0x1c],AX (0170_0048 / 0x1748)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs2, 0x4C);
    // PUSH CS (0170_004B / 0x174B)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4F);
    // CALL 0x0000:412b (0170_004C / 0x174C)
    NearCall(cs2, 0x4F, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs2, 0x52);
    // PUSH word ptr [BP + -0x1c] (0170_004F / 0x174F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs2, 0x57);
    // CALLF 0x1000:897d (0170_0052 / 0x1752)
    FarCall(cs2, 0x57, unknown_17C6_0D1D_1897D);
    CheckExternalEvents(cs2, 0x5A);
    // ADD SP,0x2 (0170_0057 / 0x1757)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x5D);
    // MOV word ptr [BP + -0x1c],AX (0170_005A / 0x175A)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs2, 0x60);
    // MOV AX,0x4 (0170_005D / 0x175D)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x61);
    // PUSH AX (0170_0060 / 0x1760)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x66);
    // CALLF 0x1000:7ee1 (0170_0061 / 0x1761)
    FarCall(cs2, 0x66, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs2, 0x69);
    // ADD SP,0x2 (0170_0066 / 0x1766)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x6E);
    // MOV word ptr [BP + -0x20],0x0 (0170_0069 / 0x1769)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    CheckExternalEvents(cs2, 0x70);
    // JMP 0x0000:179a (0170_006E / 0x176E)
    goto label_0170_009A_0179A;
    label_0170_0070_01770:
    CheckExternalEvents(cs2, 0x74);
    // CMP word ptr [BP + -0x1c],0x20 (0170_0070 / 0x1770)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1C)], 0x20);
    CheckExternalEvents(cs2, 0x76);
    // JZ 0x0000:1780 (0170_0074 / 0x1774)
    if(ZeroFlag) {
      goto label_0170_0080_01780;
    }
    CheckExternalEvents(cs2, 0x79);
    // PUSH word ptr [BP + -0x1c] (0170_0076 / 0x1776)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs2, 0x7A);
    // PUSH CS (0170_0079 / 0x1779)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x7D);
    // CALL 0x0000:388f (0170_007A / 0x177A)
    NearCall(cs2, 0x7D, unknown_0170_218F_0388F);
    CheckExternalEvents(cs2, 0x80);
    // ADD SP,0x2 (0170_007D / 0x177D)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0170_0080_01780:
    CheckExternalEvents(cs2, 0x81);
    // PUSH CS (0170_0080 / 0x1780)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x84);
    // CALL 0x0000:1c1b (0170_0081 / 0x1781)
    NearCall(cs2, 0x84, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs2, 0x88);
    // MOV ES,word ptr [0x5386] (0170_0084 / 0x1784)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0x8E);
    // CMP word ptr ES:[0xd55c],0x0 (0170_0088 / 0x1788)
    Alu.Sub16(UInt16[ES, 0xD55C], 0x0);
    CheckExternalEvents(cs2, 0x90);
    // JZ 0x0000:1797 (0170_008E / 0x178E)
    if(ZeroFlag) {
      goto label_0170_0097_01797;
    }
    CheckExternalEvents(cs2, 0x93);
    // MOV AX,[0x15a] (0170_0090 / 0x1790)
    AX = UInt16[DS, 0x15A];
    CheckExternalEvents(cs2, 0x94);
    // INC AX (0170_0093 / 0x1793)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs2, 0x97);
    // MOV word ptr [BP + -0x20],AX (0170_0094 / 0x1794)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    label_0170_0097_01797:
    CheckExternalEvents(cs2, 0x9A);
    // INC word ptr [BP + -0x20] (0170_0097 / 0x1797)
    UInt16[SS, (ushort)(BP - 0x20)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x20)]);
    label_0170_009A_0179A:
    CheckExternalEvents(cs2, 0x9D);
    // MOV AX,[0x15a] (0170_009A / 0x179A)
    AX = UInt16[DS, 0x15A];
    CheckExternalEvents(cs2, 0xA0);
    // CMP word ptr [BP + -0x20],AX (0170_009D / 0x179D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], AX);
    CheckExternalEvents(cs2, 0xA2);
    // JL 0x0000:1770 (0170_00A0 / 0x17A0)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0070_01770;
    }
    CheckExternalEvents(cs2, 0xA6);
    // MOV ES,word ptr [0x5386] (0170_00A2 / 0x17A2)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0xAC);
    // CMP word ptr ES:[0xd55c],0x0 (0170_00A6 / 0x17A6)
    Alu.Sub16(UInt16[ES, 0xD55C], 0x0);
    CheckExternalEvents(cs2, 0xAE);
    // JNZ 0x0000:17ec (0170_00AC / 0x17AC)
    if(!ZeroFlag) {
      goto label_0170_00EC_017EC;
    }
    CheckExternalEvents(cs2, 0xB3);
    // MOV word ptr [BP + -0x16],0x0 (0170_00AE / 0x17AE)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    label_0170_00B3_017B3:
    CheckExternalEvents(cs2, 0xB6);
    // MOV BX,word ptr [BP + -0x16] (0170_00B3 / 0x17B3)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0xB8);
    // SHL BX,0x1 (0170_00B6 / 0x17B6)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0xBB);
    // MOV AX,word ptr [BP + -0x1c] (0170_00B8 / 0x17B8)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs2, 0xBF);
    // CMP word ptr [BX + 0x160],AX (0170_00BB / 0x17BB)
    Alu.Sub16(UInt16[DS, (ushort)(BX + 0x160)], AX);
    CheckExternalEvents(cs2, 0xC1);
    // JNZ 0x0000:17e3 (0170_00BF / 0x17BF)
    if(!ZeroFlag) {
      goto label_0170_00E3_017E3;
    }
    CheckExternalEvents(cs2, 0xC5);
    // MOV ES,word ptr [0x5388] (0170_00C1 / 0x17C1)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs2, 0xCC);
    // MOV word ptr ES:[0x37fe],0xf (0170_00C5 / 0x17C5)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs2, 0xCF);
    // MOV BX,word ptr [BP + -0x16] (0170_00CC / 0x17CC)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0xD1);
    // SHL BX,0x1 (0170_00CF / 0x17CF)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0xD3);
    // SHL BX,0x1 (0170_00D1 / 0x17D1)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0xD7);
    // PUSH word ptr [BX + 0x1ac] (0170_00D3 / 0x17D3)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1AC)]);
    CheckExternalEvents(cs2, 0xDB);
    // PUSH word ptr [BX + 0x1aa] (0170_00D7 / 0x17D7)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1AA)]);
    CheckExternalEvents(cs2, 0xE0);
    // CALLF 0x1000:8055 (0170_00DB / 0x17DB)
    FarCall(cs2, 0xE0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0xE3);
    // ADD SP,0x4 (0170_00E0 / 0x17E0)
    SP += 0x4;
    label_0170_00E3_017E3:
    CheckExternalEvents(cs2, 0xE6);
    // INC word ptr [BP + -0x16] (0170_00E3 / 0x17E3)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    CheckExternalEvents(cs2, 0xEA);
    // CMP word ptr [BP + -0x16],0x8 (0170_00E6 / 0x17E6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x8);
    CheckExternalEvents(cs2, 0xEC);
    // JL 0x0000:17b3 (0170_00EA / 0x17EA)
    if(SignFlag != OverflowFlag) {
      goto label_0170_00B3_017B3;
    }
    label_0170_00EC_017EC:
    CheckExternalEvents(cs2, 0xF0);
    // MOV ES,word ptr [0x5386] (0170_00EC / 0x17EC)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0xF7);
    // MOV word ptr ES:[0xd55c],0x0 (0170_00F0 / 0x17F0)
    UInt16[ES, 0xD55C] = 0x0;
    CheckExternalEvents(cs2, 0xFA);
    // PUSH word ptr [BP + -0x1c] (0170_00F7 / 0x17F7)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs2, 0xFB);
    // PUSH CS (0170_00FA / 0x17FA)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0xFE);
    // CALL 0x0000:3a1d (0170_00FB / 0x17FB)
    NearCall(cs2, 0xFE, unknown_0170_231D_03A1D);
    CheckExternalEvents(cs2, 0x101);
    // ADD SP,0x2 (0170_00FE / 0x17FE)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x105);
    // CMP word ptr [BP + -0x1c],0x20 (0170_0101 / 0x1801)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1C)], 0x20);
    CheckExternalEvents(cs2, 0x107);
    // JNZ 0x0000:180b (0170_0105 / 0x1805)
    if(!ZeroFlag) {
      goto label_0170_010B_0180B;
    }
    CheckExternalEvents(cs2, 0x108);
    // PUSH CS (0170_0107 / 0x1807)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x10B);
    // CALL 0x0000:4350 (0170_0108 / 0x1808)
    NearCall(cs2, 0x10B, ghidra_guess_0000_4350_04350);
    label_0170_010B_0180B:
    CheckExternalEvents(cs2, 0x10F);
    // MOV ES,word ptr [0x538a] (0170_010B / 0x180B)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x115);
    // CMP byte ptr ES:[0xd33d],0x0 (0170_010F / 0x180F)
    Alu.Sub8(UInt8[ES, 0xD33D], 0x0);
    CheckExternalEvents(cs2, 0x117);
    // JZ 0x0000:1822 (0170_0115 / 0x1815)
    if(ZeroFlag) {
      goto label_0170_0122_01822;
    }
    CheckExternalEvents(cs2, 0x11D);
    // CMP byte ptr ES:[0xd346],0x0 (0170_0117 / 0x1817)
    Alu.Sub8(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs2, 0x11F);
    // JNZ 0x0000:1822 (0170_011D / 0x181D)
    if(!ZeroFlag) {
      goto label_0170_0122_01822;
    }
    CheckExternalEvents(cs2, 0x122);
    // JMP 0x0000:18b1 (0170_011F / 0x181F)
    goto label_0170_01B1_018B1;
    label_0170_0122_01822:
    CheckExternalEvents(cs2, 0x126);
    // MOV ES,word ptr [0x538c] (0170_0122 / 0x1822)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x12A);
    // MOV AX,ES:[0xa44b] (0170_0126 / 0x1826)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x12D);
    // AND AX,0x70 (0170_012A / 0x182A)
    // AX &= 0x70;
    AX = Alu.And16(AX, 0x70);
    CheckExternalEvents(cs2, 0x12F);
    // MOV CL,0x4 (0170_012D / 0x182D)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x131);
    // SHR AX,CL (0170_012F / 0x182F)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    CheckExternalEvents(cs2, 0x134);
    // MOV word ptr [BP + -0x2c],AX (0170_0131 / 0x1831)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs2, 0x136);
    // MOV BX,AX (0170_0134 / 0x1834)
    BX = AX;
    CheckExternalEvents(cs2, 0x13A);
    // MOV AL,byte ptr [BX + 0x29a] (0170_0136 / 0x1836)
    AL = UInt8[DS, (ushort)(BX + 0x29A)];
    CheckExternalEvents(cs2, 0x13B);
    // CBW  (0170_013A / 0x183A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x13E);
    // MOV word ptr [BP + -0x2c],AX (0170_013B / 0x183B)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs2, 0x142);
    // MOV ES,word ptr [0x538e] (0170_013E / 0x183E)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x146);
    // MOV AX,ES:[0xa44d] (0170_0142 / 0x1842)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x149);
    // AND AX,0xf000 (0170_0146 / 0x1846)
    // AX &= 0xF000;
    AX = Alu.And16(AX, 0xF000);
    CheckExternalEvents(cs2, 0x14B);
    // MOV CL,0x5 (0170_0149 / 0x1849)
    CL = 0x5;
    CheckExternalEvents(cs2, 0x14D);
    // SHR AX,CL (0170_014B / 0x184B)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    CheckExternalEvents(cs2, 0x152);
    // MOV CX,word ptr ES:[0xa44d] (0170_014D / 0x184D)
    CX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x155);
    // AND CX,0x70 (0170_0152 / 0x1852)
    // CX &= 0x70;
    CX = Alu.And16(CX, 0x70);
    CheckExternalEvents(cs2, 0x157);
    // OR AX,CX (0170_0155 / 0x1855)
    // AX |= CX;
    AX = Alu.Or16(AX, CX);
    CheckExternalEvents(cs2, 0x15A);
    // MOV word ptr [BP + -0x30],AX (0170_0157 / 0x1857)
    UInt16[SS, (ushort)(BP - 0x30)] = AX;
    CheckExternalEvents(cs2, 0x15E);
    // MOV ES,word ptr [0x538c] (0170_015A / 0x185A)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x162);
    // MOV AX,ES:[0xa44b] (0170_015E / 0x185E)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x164);
    // MOV CL,0x8 (0170_0162 / 0x1862)
    CL = 0x8;
    CheckExternalEvents(cs2, 0x166);
    // SHR AX,CL (0170_0164 / 0x1864)
    AX >>= CL;
    CheckExternalEvents(cs2, 0x169);
    // ADD word ptr [BP + -0x30],AX (0170_0166 / 0x1866)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x30)], AX);
    CheckExternalEvents(cs2, 0x16C);
    // MOV AL,byte ptr [BP + -0x2c] (0170_0169 / 0x1869)
    AL = UInt8[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs2, 0x16F);
    // MOV BX,word ptr [BP + -0x30] (0170_016C / 0x186C)
    BX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs2, 0x173);
    // MOV ES,word ptr [0x538a] (0170_016F / 0x186F)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x178);
    // OR byte ptr ES:[BX + 0xcb0c],AL (0170_0173 / 0x1873)
    // UInt8[ES, (ushort)(BX + 0xCB0C)] |= AL;
    UInt8[ES, (ushort)(BX + 0xCB0C)] = Alu.Or8(UInt8[ES, (ushort)(BX + 0xCB0C)], AL);
    CheckExternalEvents(cs2, 0x17C);
    // MOV ES,word ptr [0x538e] (0170_0178 / 0x1878)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x182);
    // CMP word ptr ES:[0xa44d],0x0 (0170_017C / 0x187C)
    Alu.Sub16(UInt16[ES, 0xA44D], 0x0);
    CheckExternalEvents(cs2, 0x184);
    // JZ 0x0000:1893 (0170_0182 / 0x1882)
    if(ZeroFlag) {
      goto label_0170_0193_01893;
    }
    CheckExternalEvents(cs2, 0x187);
    // MOV AL,byte ptr [BP + -0x2c] (0170_0184 / 0x1884)
    AL = UInt8[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs2, 0x18A);
    // MOV BX,word ptr [BP + -0x30] (0170_0187 / 0x1887)
    BX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs2, 0x18E);
    // MOV ES,word ptr [0x538a] (0170_018A / 0x188A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x193);
    // OR byte ptr ES:[BX + 0xcafc],AL (0170_018E / 0x188E)
    // UInt8[ES, (ushort)(BX + 0xCAFC)] |= AL;
    UInt8[ES, (ushort)(BX + 0xCAFC)] = Alu.Or8(UInt8[ES, (ushort)(BX + 0xCAFC)], AL);
    label_0170_0193_01893:
    CheckExternalEvents(cs2, 0x197);
    // MOV ES,word ptr [0x538e] (0170_0193 / 0x1893)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x19E);
    // CMP word ptr ES:[0xa44d],0xf07f (0170_0197 / 0x1897)
    Alu.Sub16(UInt16[ES, 0xA44D], 0xF07F);
    CheckExternalEvents(cs2, 0x1A0);
    // JNC 0x0000:190a (0170_019E / 0x189E)
    if(!CarryFlag) {
      goto label_0170_020A_0190A;
    }
    CheckExternalEvents(cs2, 0x1A3);
    // MOV AL,byte ptr [BP + -0x2c] (0170_01A0 / 0x18A0)
    AL = UInt8[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs2, 0x1A6);
    // MOV BX,word ptr [BP + -0x30] (0170_01A3 / 0x18A3)
    BX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs2, 0x1AA);
    // MOV ES,word ptr [0x538a] (0170_01A6 / 0x18A6)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x1AF);
    // OR byte ptr ES:[BX + 0xcb1c],AL (0170_01AA / 0x18AA)
    // UInt8[ES, (ushort)(BX + 0xCB1C)] |= AL;
    UInt8[ES, (ushort)(BX + 0xCB1C)] = Alu.Or8(UInt8[ES, (ushort)(BX + 0xCB1C)], AL);
    CheckExternalEvents(cs2, 0x1B1);
    // JMP 0x0000:190a (0170_01AF / 0x18AF)
    goto label_0170_020A_0190A;
    label_0170_01B1_018B1:
    CheckExternalEvents(cs2, 0x1B5);
    // MOV ES,word ptr [0x538e] (0170_01B1 / 0x18B1)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x1B9);
    // MOV AX,ES:[0xa44d] (0170_01B5 / 0x18B5)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x1BC);
    // AND AX,0xf000 (0170_01B9 / 0x18B9)
    // AX &= 0xF000;
    AX = Alu.And16(AX, 0xF000);
    CheckExternalEvents(cs2, 0x1BE);
    // MOV CL,0x5 (0170_01BC / 0x18BC)
    CL = 0x5;
    CheckExternalEvents(cs2, 0x1C0);
    // SHR AX,CL (0170_01BE / 0x18BE)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    CheckExternalEvents(cs2, 0x1C3);
    // MOV word ptr [BP + -0x30],AX (0170_01C0 / 0x18C0)
    UInt16[SS, (ushort)(BP - 0x30)] = AX;
    CheckExternalEvents(cs2, 0x1C7);
    // MOV ES,word ptr [0x538c] (0170_01C3 / 0x18C3)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x1CB);
    // MOV AX,ES:[0xa44b] (0170_01C7 / 0x18C7)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x1CD);
    // MOV CL,0x8 (0170_01CB / 0x18CB)
    CL = 0x8;
    CheckExternalEvents(cs2, 0x1CF);
    // SHR AX,CL (0170_01CD / 0x18CD)
    AX >>= CL;
    CheckExternalEvents(cs2, 0x1D2);
    // ADD word ptr [BP + -0x30],AX (0170_01CF / 0x18CF)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x30)], AX);
    CheckExternalEvents(cs2, 0x1D7);
    // MOV word ptr [BP + -0x2c],0x0 (0170_01D2 / 0x18D2)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    label_0170_01D7_018D7:
    CheckExternalEvents(cs2, 0x1DA);
    // MOV BX,word ptr [BP + -0x30] (0170_01D7 / 0x18D7)
    BX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs2, 0x1DD);
    // ADD BX,word ptr [BP + -0x2c] (0170_01DA / 0x18DA)
    // BX += UInt16[SS, (ushort)(BP - 0x2C)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs2, 0x1E1);
    // MOV ES,word ptr [0x538a] (0170_01DD / 0x18DD)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x1E7);
    // MOV byte ptr ES:[BX + 0xcb0c],0xff (0170_01E1 / 0x18E1)
    UInt8[ES, (ushort)(BX + 0xCB0C)] = 0xFF;
    CheckExternalEvents(cs2, 0x1EB);
    // ADD word ptr [BP + -0x2c],0x10 (0170_01E7 / 0x18E7)
    UInt16[SS, (ushort)(BP - 0x2C)] += 0x10;
    CheckExternalEvents(cs2, 0x1F0);
    // CMP word ptr [BP + -0x2c],0x80 (0170_01EB / 0x18EB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2C)], 0x80);
    CheckExternalEvents(cs2, 0x1F2);
    // JL 0x0000:18d7 (0170_01F0 / 0x18F0)
    if(SignFlag != OverflowFlag) {
      goto label_0170_01D7_018D7;
    }
    CheckExternalEvents(cs2, 0x1F4);
    // JMP 0x0000:190a (0170_01F2 / 0x18F2)
    goto label_0170_020A_0190A;
    label_0170_01F4_018F4:
    CheckExternalEvents(cs2, 0x1F7);
    // MOV AX,0x1 (0170_01F4 / 0x18F4)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x1F8);
    // PUSH AX (0170_01F7 / 0x18F7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1FD);
    // CALLF 0x1000:8ad6 (0170_01F8 / 0x18F8)
    FarCall(cs2, 0x1FD, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs2, 0x200);
    // ADD SP,0x2 (0170_01FD / 0x18FD)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x203);
    // DEC word ptr [BP + -0x1a] (0170_0200 / 0x1900)
    UInt16[SS, (ushort)(BP - 0x1A)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs2, 0x205);
    // JNS 0x0000:190a (0170_0203 / 0x1903)
    if(!SignFlag) {
      goto label_0170_020A_0190A;
    }
    CheckExternalEvents(cs2, 0x20A);
    // MOV word ptr [BP + -0x12],0x1 (0170_0205 / 0x1905)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_0170_020A_0190A:
    CheckExternalEvents(cs2, 0x20E);
    // CMP word ptr [BP + -0x12],0x0 (0170_020A / 0x190A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs2, 0x210);
    // JNZ 0x0000:1913 (0170_020E / 0x190E)
    if(!ZeroFlag) {
      goto label_0170_0213_01913;
    }
    CheckExternalEvents(cs2, 0x213);
    // JMP 0x0000:1c0d (0170_0210 / 0x1910)
    goto label_0170_050D_01C0D;
    label_0170_0213_01913:
    CheckExternalEvents(cs2, 0x217);
    // MOV ES,word ptr [0x538a] (0170_0213 / 0x1913)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x21D);
    // CMP byte ptr ES:[0xd335],0x0 (0170_0217 / 0x1917)
    Alu.Sub8(UInt8[ES, 0xD335], 0x0);
    CheckExternalEvents(cs2, 0x21F);
    // JZ 0x0000:1924 (0170_021D / 0x191D)
    if(ZeroFlag) {
      goto label_0170_0224_01924;
    }
    CheckExternalEvents(cs2, 0x224);
    // DEC byte ptr ES:[0xd335] (0170_021F / 0x191F)
    UInt8[ES, 0xD335]--;
    label_0170_0224_01924:
    CheckExternalEvents(cs2, 0x22A);
    // CMP byte ptr ES:[0xd343],0x0 (0170_0224 / 0x1924)
    Alu.Sub8(UInt8[ES, 0xD343], 0x0);
    CheckExternalEvents(cs2, 0x22C);
    // JZ 0x0000:1987 (0170_022A / 0x192A)
    if(ZeroFlag) {
      goto label_0170_0287_01987;
    }
    CheckExternalEvents(cs2, 0x230);
    // MOV AL,ES:[0xd344] (0170_022C / 0x192C)
    AL = UInt8[ES, 0xD344];
    CheckExternalEvents(cs2, 0x235);
    // DEC byte ptr ES:[0xd344] (0170_0230 / 0x1930)
    UInt8[ES, 0xD344] = Alu.Dec8(UInt8[ES, 0xD344]);
    CheckExternalEvents(cs2, 0x237);
    // OR AL,AL (0170_0235 / 0x1935)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    CheckExternalEvents(cs2, 0x239);
    // JNZ 0x0000:193e (0170_0237 / 0x1937)
    if(!ZeroFlag) {
      goto label_0170_023E_0193E;
    }
    CheckExternalEvents(cs2, 0x23E);
    // DEC byte ptr ES:[0xd345] (0170_0239 / 0x1939)
    UInt8[ES, 0xD345] = Alu.Dec8(UInt8[ES, 0xD345]);
    label_0170_023E_0193E:
    CheckExternalEvents(cs2, 0x242);
    // MOV AL,ES:[0xd344] (0170_023E / 0x193E)
    AL = UInt8[ES, 0xD344];
    CheckExternalEvents(cs2, 0x247);
    // OR AL,byte ptr ES:[0xd345] (0170_0242 / 0x1942)
    // AL |= UInt8[ES, 0xD345];
    AL = Alu.Or8(AL, UInt8[ES, 0xD345]);
    CheckExternalEvents(cs2, 0x24B);
    // MOV ES:[0xd343],AL (0170_0247 / 0x1947)
    UInt8[ES, 0xD343] = AL;
    CheckExternalEvents(cs2, 0x24D);
    // OR AL,AL (0170_024B / 0x194B)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    CheckExternalEvents(cs2, 0x24F);
    // JNZ 0x0000:1987 (0170_024D / 0x194D)
    if(!ZeroFlag) {
      goto label_0170_0287_01987;
    }
    CheckExternalEvents(cs2, 0x253);
    // MOV ES,word ptr [0x538c] (0170_024F / 0x194F)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x25A);
    // CMP word ptr ES:[0xa44b],0x800 (0170_0253 / 0x1953)
    Alu.Sub16(UInt16[ES, 0xA44B], 0x800);
    CheckExternalEvents(cs2, 0x25C);
    // JC 0x0000:1987 (0170_025A / 0x195A)
    if(CarryFlag) {
      goto label_0170_0287_01987;
    }
    CheckExternalEvents(cs2, 0x263);
    // CMP word ptr ES:[0xa44b],0xd00 (0170_025C / 0x195C)
    Alu.Sub16(UInt16[ES, 0xA44B], 0xD00);
    CheckExternalEvents(cs2, 0x265);
    // JNC 0x0000:1987 (0170_0263 / 0x1963)
    if(!CarryFlag) {
      goto label_0170_0287_01987;
    }
    CheckExternalEvents(cs2, 0x269);
    // MOV ES,word ptr [0x538e] (0170_0265 / 0x1965)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x270);
    // CMP word ptr ES:[0xa44d],0x6000 (0170_0269 / 0x1969)
    Alu.Sub16(UInt16[ES, 0xA44D], 0x6000);
    CheckExternalEvents(cs2, 0x272);
    // JC 0x0000:1987 (0170_0270 / 0x1970)
    if(CarryFlag) {
      goto label_0170_0287_01987;
    }
    CheckExternalEvents(cs2, 0x279);
    // CMP word ptr ES:[0xa44d],0xb000 (0170_0272 / 0x1972)
    Alu.Sub16(UInt16[ES, 0xA44D], 0xB000);
    CheckExternalEvents(cs2, 0x27B);
    // JNC 0x0000:1987 (0170_0279 / 0x1979)
    if(!CarryFlag) {
      goto label_0170_0287_01987;
    }
    CheckExternalEvents(cs2, 0x27E);
    // MOV AX,0x1 (0170_027B / 0x197B)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x27F);
    // PUSH AX (0170_027E / 0x197E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x284);
    // CALLF 0x0000:f7a2 (0170_027F / 0x197F)
    FarCall(cs2, 0x284, ghidra_guess_0000_F7A2_0F7A2);
    CheckExternalEvents(cs2, 0x287);
    // ADD SP,0x2 (0170_0284 / 0x1984)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0170_0287_01987:
    CheckExternalEvents(cs2, 0x28C);
    // CALLF 0x1000:aab0 (0170_0287 / 0x1987)
    FarCall(cs2, 0x28C, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x290);
    // MOV ES,word ptr [0x538a] (0170_028C / 0x198C)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x292);
    // MOV CX,AX (0170_0290 / 0x1990)
    CX = AX;
    CheckExternalEvents(cs2, 0x296);
    // MOV AL,ES:[0xd330] (0170_0292 / 0x1992)
    AL = UInt8[ES, 0xD330];
    CheckExternalEvents(cs2, 0x297);
    // CBW  (0170_0296 / 0x1996)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x299);
    // TEST CX,AX (0170_0297 / 0x1997)
    Alu.And16(CX, AX);
    CheckExternalEvents(cs2, 0x29B);
    // JNZ 0x0000:19b6 (0170_0299 / 0x1999)
    if(!ZeroFlag) {
      goto label_0170_02B6_019B6;
    }
    CheckExternalEvents(cs2, 0x2A1);
    // CMP byte ptr ES:[0xd310],0x0 (0170_029B / 0x199B)
    Alu.Sub8(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs2, 0x2A3);
    // JZ 0x0000:19b6 (0170_02A1 / 0x19A1)
    if(ZeroFlag) {
      goto label_0170_02B6_019B6;
    }
    CheckExternalEvents(cs2, 0x2A9);
    // CMP byte ptr ES:[0xd346],0x0 (0170_02A3 / 0x19A3)
    Alu.Sub8(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs2, 0x2AB);
    // JNZ 0x0000:19b6 (0170_02A9 / 0x19A9)
    if(!ZeroFlag) {
      goto label_0170_02B6_019B6;
    }
    CheckExternalEvents(cs2, 0x2AD);
    // SUB AX,AX (0170_02AB / 0x19AB)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x2AE);
    // PUSH AX (0170_02AD / 0x19AD)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2B3);
    // CALLF 0x1000:1aba (0170_02AE / 0x19AE)
    FarCall(cs2, 0x2B3, ghidra_guess_1000_1ABA_11ABA);
    CheckExternalEvents(cs2, 0x2B6);
    // ADD SP,0x2 (0170_02B3 / 0x19B3)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0170_02B6_019B6:
    CheckExternalEvents(cs2, 0x2BA);
    // MOV ES,word ptr [0x538a] (0170_02B6 / 0x19B6)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2C0);
    // CMP byte ptr ES:[0xd329],0x0 (0170_02BA / 0x19BA)
    Alu.Sub8(UInt8[ES, 0xD329], 0x0);
    CheckExternalEvents(cs2, 0x2C2);
    // JZ 0x0000:19c7 (0170_02C0 / 0x19C0)
    if(ZeroFlag) {
      goto label_0170_02C7_019C7;
    }
    CheckExternalEvents(cs2, 0x2C7);
    // DEC byte ptr ES:[0xd329] (0170_02C2 / 0x19C2)
    UInt8[ES, 0xD329]--;
    label_0170_02C7_019C7:
    CheckExternalEvents(cs2, 0x2CD);
    // CMP byte ptr ES:[0xd320],0x0 (0170_02C7 / 0x19C7)
    Alu.Sub8(UInt8[ES, 0xD320], 0x0);
    CheckExternalEvents(cs2, 0x2CF);
    // JZ 0x0000:19d4 (0170_02CD / 0x19CD)
    if(ZeroFlag) {
      goto label_0170_02D4_019D4;
    }
    CheckExternalEvents(cs2, 0x2D4);
    // DEC byte ptr ES:[0xd320] (0170_02CF / 0x19CF)
    UInt8[ES, 0xD320]--;
    label_0170_02D4_019D4:
    CheckExternalEvents(cs2, 0x2DA);
    // CMP byte ptr ES:[0xd321],0x0 (0170_02D4 / 0x19D4)
    Alu.Sub8(UInt8[ES, 0xD321], 0x0);
    CheckExternalEvents(cs2, 0x2DC);
    // JZ 0x0000:19e1 (0170_02DA / 0x19DA)
    if(ZeroFlag) {
      goto label_0170_02E1_019E1;
    }
    CheckExternalEvents(cs2, 0x2E1);
    // DEC byte ptr ES:[0xd321] (0170_02DC / 0x19DC)
    UInt8[ES, 0xD321]--;
    label_0170_02E1_019E1:
    CheckExternalEvents(cs2, 0x2E7);
    // CMP byte ptr ES:[0xd322],0x0 (0170_02E1 / 0x19E1)
    Alu.Sub8(UInt8[ES, 0xD322], 0x0);
    CheckExternalEvents(cs2, 0x2E9);
    // JZ 0x0000:19ee (0170_02E7 / 0x19E7)
    if(ZeroFlag) {
      goto label_0170_02EE_019EE;
    }
    CheckExternalEvents(cs2, 0x2EE);
    // DEC byte ptr ES:[0xd322] (0170_02E9 / 0x19E9)
    UInt8[ES, 0xD322] = Alu.Dec8(UInt8[ES, 0xD322]);
    label_0170_02EE_019EE:
    CheckExternalEvents(cs2, 0x2F2);
    // MOV AL,ES:[0xd323] (0170_02EE / 0x19EE)
    AL = UInt8[ES, 0xD323];
    CheckExternalEvents(cs2, 0x2F7);
    // DEC byte ptr ES:[0xd323] (0170_02F2 / 0x19F2)
    UInt8[ES, 0xD323] = Alu.Dec8(UInt8[ES, 0xD323]);
    CheckExternalEvents(cs2, 0x2F9);
    // OR AL,AL (0170_02F7 / 0x19F7)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    CheckExternalEvents(cs2, 0x2FB);
    // JZ 0x0000:19fe (0170_02F9 / 0x19F9)
    if(ZeroFlag) {
      goto label_0170_02FE_019FE;
    }
    CheckExternalEvents(cs2, 0x2FE);
    // JMP 0x0000:1b4a (0170_02FB / 0x19FB)
    goto label_0170_044A_01B4A;
    label_0170_02FE_019FE:
    CheckExternalEvents(cs2, 0x302);
    // MOV AX,ES:[0xd374] (0170_02FE / 0x19FE)
    AX = UInt16[ES, 0xD374];
    CheckExternalEvents(cs2, 0x307);
    // MOV DX,word ptr ES:[0xd376] (0170_0302 / 0x1A02)
    DX = UInt16[ES, 0xD376];
    CheckExternalEvents(cs2, 0x30C);
    // ADD AX,word ptr ES:[0xd378] (0170_0307 / 0x1A07)
    // AX += UInt16[ES, 0xD378];
    AX = Alu.Add16(AX, UInt16[ES, 0xD378]);
    CheckExternalEvents(cs2, 0x311);
    // ADC DX,word ptr ES:[0xd37a] (0170_030C / 0x1A0C)
    DX = Alu.Adc16(DX, UInt16[ES, 0xD37A]);
    CheckExternalEvents(cs2, 0x316);
    // ADD AX,word ptr ES:[0xd37c] (0170_0311 / 0x1A11)
    // AX += UInt16[ES, 0xD37C];
    AX = Alu.Add16(AX, UInt16[ES, 0xD37C]);
    CheckExternalEvents(cs2, 0x31B);
    // ADC DX,word ptr ES:[0xd37e] (0170_0316 / 0x1A16)
    DX = Alu.Adc16(DX, UInt16[ES, 0xD37E]);
    CheckExternalEvents(cs2, 0x320);
    // ADD AX,word ptr ES:[0xd370] (0170_031B / 0x1A1B)
    // AX += UInt16[ES, 0xD370];
    AX = Alu.Add16(AX, UInt16[ES, 0xD370]);
    CheckExternalEvents(cs2, 0x325);
    // ADC DX,word ptr ES:[0xd372] (0170_0320 / 0x1A20)
    DX = Alu.Adc16(DX, UInt16[ES, 0xD372]);
    CheckExternalEvents(cs2, 0x328);
    // MOV word ptr [BP + -0x2a],AX (0170_0325 / 0x1A25)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs2, 0x32B);
    // MOV word ptr [BP + -0x28],DX (0170_0328 / 0x1A28)
    UInt16[SS, (ushort)(BP - 0x28)] = DX;
    CheckExternalEvents(cs2, 0x331);
    // CMP byte ptr ES:[0xd310],0x0 (0170_032B / 0x1A2B)
    Alu.Sub8(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs2, 0x333);
    // JNZ 0x0000:1a58 (0170_0331 / 0x1A31)
    if(!ZeroFlag) {
      goto label_0170_0358_01A58;
    }
    CheckExternalEvents(cs2, 0x334);
    // PUSH CS (0170_0333 / 0x1A33)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x337);
    // CALL 0x0000:40f5 (0170_0334 / 0x1A34)
    NearCall(cs2, 0x337, unknown_0170_29F5_040F5);
    CheckExternalEvents(cs2, 0x33A);
    // CMP DX,word ptr [BP + -0x28] (0170_0337 / 0x1A37)
    Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs2, 0x33C);
    // JL 0x0000:1a53 (0170_033A / 0x1A3A)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0353_01A53;
    }
    CheckExternalEvents(cs2, 0x33E);
    // JG 0x0000:1a43 (0170_033C / 0x1A3C)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_0343_01A43;
    }
    CheckExternalEvents(cs2, 0x341);
    // CMP AX,word ptr [BP + -0x2a] (0170_033E / 0x1A3E)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs2, 0x343);
    // JBE 0x0000:1a53 (0170_0341 / 0x1A41)
    if(CarryFlag || ZeroFlag) {
      goto label_0170_0353_01A53;
    }
    label_0170_0343_01A43:
    CheckExternalEvents(cs2, 0x347);
    // MOV ES,word ptr [0x538a] (0170_0343 / 0x1A43)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x34D);
    // ADD word ptr ES:[0xd370],0xf (0170_0347 / 0x1A47)
    // UInt16[ES, 0xD370] += 0xF;
    UInt16[ES, 0xD370] = Alu.Add16(UInt16[ES, 0xD370], 0xF);
    CheckExternalEvents(cs2, 0x353);
    // ADC word ptr ES:[0xd372],0x0 (0170_034D / 0x1A4D)
    UInt16[ES, 0xD372] = Alu.Adc16(UInt16[ES, 0xD372], 0x0);
    label_0170_0353_01A53:
    CheckExternalEvents(cs2, 0x358);
    // CALLF 0x1000:19ef (0170_0353 / 0x1A53)
    FarCall(cs2, 0x358, unknown_0FA1_1FDF_119EF);
    label_0170_0358_01A58:
    CheckExternalEvents(cs2, 0x35C);
    // MOV ES,word ptr [0x538a] (0170_0358 / 0x1A58)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x362);
    // CMP byte ptr ES:[0xd310],0x0 (0170_035C / 0x1A5C)
    Alu.Sub8(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs2, 0x364);
    // JNZ 0x0000:1a7a (0170_0362 / 0x1A62)
    if(!ZeroFlag) {
      goto label_0170_037A_01A7A;
    }
    CheckExternalEvents(cs2, 0x365);
    // PUSH CS (0170_0364 / 0x1A64)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x368);
    // CALL 0x0000:40f5 (0170_0365 / 0x1A65)
    NearCall(cs2, 0x368, unknown_0170_29F5_040F5);
    CheckExternalEvents(cs2, 0x36B);
    // CMP DX,word ptr [BP + -0x28] (0170_0368 / 0x1A68)
    Alu.Sub16(DX, UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs2, 0x36D);
    // JGE 0x0000:1a70 (0170_036B / 0x1A6B)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0370_01A70;
    }
    CheckExternalEvents(cs2, 0x370);
    // JMP 0x0000:1b4a (0170_036D / 0x1A6D)
    goto label_0170_044A_01B4A;
    label_0170_0370_01A70:
    CheckExternalEvents(cs2, 0x372);
    // JG 0x0000:1a7a (0170_0370 / 0x1A70)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_037A_01A7A;
    }
    CheckExternalEvents(cs2, 0x375);
    // CMP AX,word ptr [BP + -0x2a] (0170_0372 / 0x1A72)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs2, 0x377);
    // JA 0x0000:1a7a (0170_0375 / 0x1A75)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0170_037A_01A7A;
    }
    CheckExternalEvents(cs2, 0x37A);
    // JMP 0x0000:1b4a (0170_0377 / 0x1A77)
    goto label_0170_044A_01B4A;
    label_0170_037A_01A7A:
    CheckExternalEvents(cs2, 0x37F);
    // MOV word ptr [BP + -0x1a],0x0 (0170_037A / 0x1A7A)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x0;
    CheckExternalEvents(cs2, 0x381);
    // JMP 0x0000:1ac0 (0170_037F / 0x1A7F)
    goto label_0170_03C0_01AC0;
    label_0170_0381_01A81:
    CheckExternalEvents(cs2, 0x384);
    // MOV BX,word ptr [BP + -0x1a] (0170_0381 / 0x1A81)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x386);
    // SHL BX,0x1 (0170_0384 / 0x1A84)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x38A);
    // MOV AX,word ptr [BX + 0x2a8] (0170_0386 / 0x1A86)
    AX = UInt16[DS, (ushort)(BX + 0x2A8)];
    CheckExternalEvents(cs2, 0x38B);
    // CWD  (0170_038A / 0x1A8A)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs2, 0x38C);
    // PUSH DX (0170_038B / 0x1A8B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x38D);
    // PUSH AX (0170_038C / 0x1A8C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x390);
    // MOV BX,word ptr [BP + -0x1a] (0170_038D / 0x1A8D)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x392);
    // SHL BX,0x1 (0170_0390 / 0x1A90)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x394);
    // SHL BX,0x1 (0170_0392 / 0x1A92)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x398);
    // LEA AX,[BX + 0xd374] (0170_0394 / 0x1A94)
    AX = (ushort)(BX + 0xD374);
    CheckExternalEvents(cs2, 0x39B);
    // MOV DX,0x2a02 (0170_0398 / 0x1A98)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x39C);
    // PUSH DX (0170_039B / 0x1A9B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x39D);
    // PUSH AX (0170_039C / 0x1A9C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3A2);
    // CALLF 0x1000:dc0c (0170_039D / 0x1A9D)
    FarCall(cs2, 0x3A2, unknown_19EF_3D1C_1DC0C);
    CheckExternalEvents(cs2, 0x3A5);
    // MOV AX,0x6e (0170_03A2 / 0x1AA2)
    AX = 0x6E;
    CheckExternalEvents(cs2, 0x3A6);
    // CWD  (0170_03A5 / 0x1AA5)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs2, 0x3A7);
    // PUSH DX (0170_03A6 / 0x1AA6)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3A8);
    // PUSH AX (0170_03A7 / 0x1AA7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3AB);
    // MOV BX,word ptr [BP + -0x1a] (0170_03A8 / 0x1AA8)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x3AD);
    // SHL BX,0x1 (0170_03AB / 0x1AAB)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x3AF);
    // SHL BX,0x1 (0170_03AD / 0x1AAD)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x3B3);
    // LEA AX,[BX + 0xd374] (0170_03AF / 0x1AAF)
    AX = (ushort)(BX + 0xD374);
    CheckExternalEvents(cs2, 0x3B6);
    // MOV DX,0x2a02 (0170_03B3 / 0x1AB3)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x3B7);
    // PUSH DX (0170_03B6 / 0x1AB6)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3B8);
    // PUSH AX (0170_03B7 / 0x1AB7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3BD);
    // CALLF 0x1000:dc34 (0170_03B8 / 0x1AB8)
    FarCall(cs2, 0x3BD, unknown_19EF_3D44_1DC34);
    label_0170_03BD_01ABD:
    CheckExternalEvents(cs2, 0x3C0);
    // INC word ptr [BP + -0x1a] (0170_03BD / 0x1ABD)
    UInt16[SS, (ushort)(BP - 0x1A)]++;
    label_0170_03C0_01AC0:
    CheckExternalEvents(cs2, 0x3C4);
    // CMP word ptr [BP + -0x1a],0x3 (0170_03C0 / 0x1AC0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1A)], 0x3);
    CheckExternalEvents(cs2, 0x3C6);
    // JL 0x0000:1ac9 (0170_03C4 / 0x1AC4)
    if(SignFlag != OverflowFlag) {
      goto label_0170_03C9_01AC9;
    }
    CheckExternalEvents(cs2, 0x3C9);
    // JMP 0x0000:1b4a (0170_03C6 / 0x1AC6)
    goto label_0170_044A_01B4A;
    label_0170_03C9_01AC9:
    CheckExternalEvents(cs2, 0x3CE);
    // CALLF 0x1000:aab0 (0170_03C9 / 0x1AC9)
    FarCall(cs2, 0x3CE, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x3D1);
    // MOV BX,word ptr [BP + -0x1a] (0170_03CE / 0x1ACE)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x3D3);
    // SHL BX,0x1 (0170_03D1 / 0x1AD1)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x3D7);
    // MOV CX,word ptr [BX + 0x2a2] (0170_03D3 / 0x1AD3)
    CX = UInt16[DS, (ushort)(BX + 0x2A2)];
    CheckExternalEvents(cs2, 0x3D9);
    // AND CX,AX (0170_03D7 / 0x1AD7)
    // CX &= AX;
    CX = Alu.And16(CX, AX);
    CheckExternalEvents(cs2, 0x3DC);
    // MOV word ptr [BP + -0x18],CX (0170_03D9 / 0x1AD9)
    UInt16[SS, (ushort)(BP - 0x18)] = CX;
    CheckExternalEvents(cs2, 0x3DE);
    // OR CX,CX (0170_03DC / 0x1ADC)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    CheckExternalEvents(cs2, 0x3E0);
    // JZ 0x0000:1a81 (0170_03DE / 0x1ADE)
    if(ZeroFlag) {
      goto label_0170_0381_01A81;
    }
    CheckExternalEvents(cs2, 0x3E3);
    // MOV AX,0x64 (0170_03E0 / 0x1AE0)
    AX = 0x64;
    CheckExternalEvents(cs2, 0x3E4);
    // CWD  (0170_03E3 / 0x1AE3)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs2, 0x3E5);
    // PUSH DX (0170_03E4 / 0x1AE4)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3E6);
    // PUSH AX (0170_03E5 / 0x1AE5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3E9);
    // MOV BX,word ptr [BP + -0x1a] (0170_03E6 / 0x1AE6)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x3EB);
    // SHL BX,0x1 (0170_03E9 / 0x1AE9)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x3ED);
    // SHL BX,0x1 (0170_03EB / 0x1AEB)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x3F1);
    // LEA AX,[BX + 0xd374] (0170_03ED / 0x1AED)
    AX = (ushort)(BX + 0xD374);
    CheckExternalEvents(cs2, 0x3F4);
    // MOV DX,0x2a02 (0170_03F1 / 0x1AF1)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x3F5);
    // PUSH DX (0170_03F4 / 0x1AF4)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3F6);
    // PUSH AX (0170_03F5 / 0x1AF5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3FB);
    // CALLF 0x1000:dc0c (0170_03F6 / 0x1AF6)
    FarCall(cs2, 0x3FB, unknown_19EF_3D1C_1DC0C);
    CheckExternalEvents(cs2, 0x3FE);
    // MOV BX,word ptr [BP + -0x1a] (0170_03FB / 0x1AFB)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x400);
    // SHL BX,0x1 (0170_03FE / 0x1AFE)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x404);
    // MOV AX,word ptr [BX + 0x2a8] (0170_0400 / 0x1B00)
    AX = UInt16[DS, (ushort)(BX + 0x2A8)];
    CheckExternalEvents(cs2, 0x405);
    // CWD  (0170_0404 / 0x1B04)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs2, 0x406);
    // PUSH DX (0170_0405 / 0x1B05)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x407);
    // PUSH AX (0170_0406 / 0x1B06)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x40A);
    // MOV BX,word ptr [BP + -0x1a] (0170_0407 / 0x1B07)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x40C);
    // SHL BX,0x1 (0170_040A / 0x1B0A)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x40E);
    // SHL BX,0x1 (0170_040C / 0x1B0C)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x412);
    // LEA AX,[BX + 0xd374] (0170_040E / 0x1B0E)
    AX = (ushort)(BX + 0xD374);
    CheckExternalEvents(cs2, 0x415);
    // MOV DX,0x2a02 (0170_0412 / 0x1B12)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x416);
    // PUSH DX (0170_0415 / 0x1B15)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x417);
    // PUSH AX (0170_0416 / 0x1B16)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x41C);
    // CALLF 0x1000:dc34 (0170_0417 / 0x1B17)
    FarCall(cs2, 0x41C, unknown_19EF_3D44_1DC34);
    CheckExternalEvents(cs2, 0x420);
    // CMP word ptr [BP + -0x1a],0x2 (0170_041C / 0x1B1C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1A)], 0x2);
    CheckExternalEvents(cs2, 0x422);
    // JNZ 0x0000:1abd (0170_0420 / 0x1B20)
    if(!ZeroFlag) {
      goto label_0170_03BD_01ABD;
    }
    CheckExternalEvents(cs2, 0x426);
    // MOV ES,word ptr [0x538a] (0170_0422 / 0x1B22)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x42C);
    // CMP word ptr ES:[0xd37e],0x0 (0170_0426 / 0x1B26)
    Alu.Sub16(UInt16[ES, 0xD37E], 0x0);
    CheckExternalEvents(cs2, 0x42E);
    // JNZ 0x0000:1b37 (0170_042C / 0x1B2C)
    if(!ZeroFlag) {
      goto label_0170_0437_01B37;
    }
    CheckExternalEvents(cs2, 0x435);
    // CMP word ptr ES:[0xd37c],0x4650 (0170_042E / 0x1B2E)
    Alu.Sub16(UInt16[ES, 0xD37C], 0x4650);
    CheckExternalEvents(cs2, 0x437);
    // JBE 0x0000:1abd (0170_0435 / 0x1B35)
    if(CarryFlag || ZeroFlag) {
      goto label_0170_03BD_01ABD;
    }
    label_0170_0437_01B37:
    CheckExternalEvents(cs2, 0x439);
    // MOV AL,0x2 (0170_0437 / 0x1B37)
    AL = 0x2;
    CheckExternalEvents(cs2, 0x43A);
    // PUSH AX (0170_0439 / 0x1B39)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x43D);
    // MOV AX,0xd37c (0170_043A / 0x1B3A)
    AX = 0xD37C;
    CheckExternalEvents(cs2, 0x440);
    // MOV DX,0x2a02 (0170_043D / 0x1B3D)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x441);
    // PUSH DX (0170_0440 / 0x1B40)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x442);
    // PUSH AX (0170_0441 / 0x1B41)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x447);
    // CALLF 0x1000:dc5c (0170_0442 / 0x1B42)
    FarCall(cs2, 0x447, ghidra_guess_1000_DC5C_1DC5C);
    CheckExternalEvents(cs2, 0x44A);
    // JMP 0x0000:1abd (0170_0447 / 0x1B47)
    goto label_0170_03BD_01ABD;
    label_0170_044A_01B4A:
    CheckExternalEvents(cs2, 0x44F);
    // MOV word ptr [BP + -0x1a],0xa (0170_044A / 0x1B4A)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0xA;
    CheckExternalEvents(cs2, 0x450);
    // PUSH CS (0170_044F / 0x1B4F)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x453);
    // CALL 0x0000:3b0b (0170_0450 / 0x1B50)
    NearCall(cs2, 0x453, unknown_0170_240B_03B0B);
    CheckExternalEvents(cs2, 0x456);
    // MOV AL,[0x57fe] (0170_0453 / 0x1B53)
    AL = UInt8[DS, 0x57FE];
    CheckExternalEvents(cs2, 0x45A);
    // INC byte ptr [0x57fe] (0170_0456 / 0x1B56)
    UInt8[DS, 0x57FE]++;
    CheckExternalEvents(cs2, 0x45C);
    // CMP AL,0x2 (0170_045A / 0x1B5A)
    Alu.Sub8(AL, 0x2);
    CheckExternalEvents(cs2, 0x45E);
    // JNZ 0x0000:1b67 (0170_045C / 0x1B5C)
    if(!ZeroFlag) {
      goto label_0170_0467_01B67;
    }
    CheckExternalEvents(cs2, 0x45F);
    // PUSH CS (0170_045E / 0x1B5E)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x462);
    // CALL 0x0000:3bc2 (0170_045F / 0x1B5F)
    NearCall(cs2, 0x462, unknown_0170_24C2_03BC2);
    CheckExternalEvents(cs2, 0x467);
    // MOV byte ptr [0x57fe],0x0 (0170_0462 / 0x1B62)
    UInt8[DS, 0x57FE] = 0x0;
    label_0170_0467_01B67:
    CheckExternalEvents(cs2, 0x46C);
    // CMP word ptr [0x14a],0x0 (0170_0467 / 0x1B67)
    Alu.Sub16(UInt16[DS, 0x14A], 0x0);
    CheckExternalEvents(cs2, 0x46E);
    // JZ 0x0000:1b96 (0170_046C / 0x1B6C)
    if(ZeroFlag) {
      goto label_0170_0496_01B96;
    }
    CheckExternalEvents(cs2, 0x472);
    // MOV ES,word ptr [0x538e] (0170_046E / 0x1B6E)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x477);
    // PUSH word ptr ES:[0xa44d] (0170_0472 / 0x1B72)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x47B);
    // MOV ES,word ptr [0x538c] (0170_0477 / 0x1B77)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x480);
    // PUSH word ptr ES:[0xa44b] (0170_047B / 0x1B7B)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x485);
    // CALLF 0x1000:b204 (0170_0480 / 0x1B80)
    FarCall(cs2, 0x485, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs2, 0x488);
    // ADD SP,0x4 (0170_0485 / 0x1B85)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x48D);
    // CALLF 0x1000:b7df (0170_0488 / 0x1B88)
    FarCall(cs2, 0x48D, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs2, 0x48E);
    // PUSH CS (0170_048D / 0x1B8D)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x491);
    // CALL 0x0000:1c1b (0170_048E / 0x1B8E)
    NearCall(cs2, 0x491, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs2, 0x496);
    // CALLF 0x1000:9193 (0170_0491 / 0x1B91)
    FarCall(cs2, 0x496, unknown_18AD_06C3_19193);
    label_0170_0496_01B96:
    CheckExternalEvents(cs2, 0x49B);
    // CMP word ptr [0x14a],0x0 (0170_0496 / 0x1B96)
    Alu.Sub16(UInt16[DS, 0x14A], 0x0);
    CheckExternalEvents(cs2, 0x49D);
    // JZ 0x0000:1ba4 (0170_049B / 0x1B9B)
    if(ZeroFlag) {
      goto label_0170_04A4_01BA4;
    }
    CheckExternalEvents(cs2, 0x4A2);
    // CMP word ptr [0x1a8],0x0 (0170_049D / 0x1B9D)
    Alu.Sub16(UInt16[DS, 0x1A8], 0x0);
    CheckExternalEvents(cs2, 0x4A4);
    // JZ 0x0000:1c0d (0170_04A2 / 0x1BA2)
    if(ZeroFlag) {
      goto label_0170_050D_01C0D;
    }
    label_0170_04A4_01BA4:
    CheckExternalEvents(cs2, 0x4A9);
    // CALLF 0x1000:7bf6 (0170_04A4 / 0x1BA4)
    FarCall(cs2, 0x4A9, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs2, 0x4AE);
    // CMP word ptr [0x14a],0x0 (0170_04A9 / 0x1BA9)
    Alu.Sub16(UInt16[DS, 0x14A], 0x0);
    CheckExternalEvents(cs2, 0x4B0);
    // JNZ 0x0000:1be5 (0170_04AE / 0x1BAE)
    if(!ZeroFlag) {
      goto label_0170_04E5_01BE5;
    }
    CheckExternalEvents(cs2, 0x4B4);
    // MOV ES,word ptr [0x538a] (0170_04B0 / 0x1BB0)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x4BA);
    // CMP byte ptr ES:[0xc614],0xff (0170_04B4 / 0x1BB4)
    Alu.Sub8(UInt8[ES, 0xC614], 0xFF);
    CheckExternalEvents(cs2, 0x4BC);
    // JNZ 0x0000:1bc1 (0170_04BA / 0x1BBA)
    if(!ZeroFlag) {
      goto label_0170_04C1_01BC1;
    }
    CheckExternalEvents(cs2, 0x4BF);
    // MOV AX,0xf1 (0170_04BC / 0x1BBC)
    AX = 0xF1;
    CheckExternalEvents(cs2, 0x4C1);
    // JMP 0x0000:1bc4 (0170_04BF / 0x1BBF)
    goto label_0170_04C4_01BC4;
    label_0170_04C1_01BC1:
    CheckExternalEvents(cs2, 0x4C4);
    // MOV AX,0xf7 (0170_04C1 / 0x1BC1)
    AX = 0xF7;
    label_0170_04C4_01BC4:
    CheckExternalEvents(cs2, 0x4C5);
    // PUSH DS (0170_04C4 / 0x1BC4)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x4C6);
    // PUSH AX (0170_04C5 / 0x1BC5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4CB);
    // CALLF 0x1000:8055 (0170_04C6 / 0x1BC6)
    FarCall(cs2, 0x4CB, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x4CE);
    // ADD SP,0x4 (0170_04CB / 0x1BCB)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x4D1);
    // MOV AX,0xfb (0170_04CE / 0x1BCE)
    AX = 0xFB;
    CheckExternalEvents(cs2, 0x4D2);
    // PUSH DS (0170_04D1 / 0x1BD1)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x4D3);
    // PUSH AX (0170_04D2 / 0x1BD2)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4D8);
    // CALLF 0x1000:7c1a (0170_04D3 / 0x1BD3)
    FarCall(cs2, 0x4D8, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs2, 0x4DB);
    // ADD SP,0x4 (0170_04D8 / 0x1BD8)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x4E0);
    // CALLF 0x1000:8d29 (0170_04DB / 0x1BDB)
    FarCall(cs2, 0x4E0, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs2, 0x4E5);
    // CALLF 0x1000:7fe8 (0170_04E0 / 0x1BE0)
    FarCall(cs2, 0x4E5, unknown_17C6_0388_17FE8);
    label_0170_04E5_01BE5:
    CheckExternalEvents(cs2, 0x4E8);
    // MOV AX,0x12f (0170_04E5 / 0x1BE5)
    AX = 0x12F;
    CheckExternalEvents(cs2, 0x4E9);
    // PUSH DS (0170_04E8 / 0x1BE8)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x4EA);
    // PUSH AX (0170_04E9 / 0x1BE9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4EF);
    // CALLF 0x1000:8055 (0170_04EA / 0x1BEA)
    FarCall(cs2, 0x4EF, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x4F2);
    // ADD SP,0x4 (0170_04EF / 0x1BEF)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x4F5);
    // MOV AX,0x1 (0170_04F2 / 0x1BF2)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x4F6);
    // PUSH AX (0170_04F5 / 0x1BF5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x4F7);
    // PUSH CS (0170_04F6 / 0x1BF6)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x4FA);
    // CALL 0x0000:3113 (0170_04F7 / 0x1BF7)
    NearCall(cs2, 0x4FA, unknown_0170_1A13_03113);
    CheckExternalEvents(cs2, 0x4FD);
    // ADD SP,0x2 (0170_04FA / 0x1BFA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x4FF);
    // OR AX,AX (0170_04FD / 0x1BFD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x501);
    // JZ 0x0000:1c07 (0170_04FF / 0x1BFF)
    if(ZeroFlag) {
      goto label_0170_0507_01C07;
    }
    CheckExternalEvents(cs2, 0x502);
    // PUSH CS (0170_0501 / 0x1C01)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x505);
    // CALL 0x0000:64c7 (0170_0502 / 0x1C02)
    NearCall(cs2, 0x505, unknown_0170_4DC7_064C7);
    CheckExternalEvents(cs2, 0x507);
    // JMP 0x0000:1c0d (0170_0505 / 0x1C05)
    goto label_0170_050D_01C0D;
    label_0170_0507_01C07:
    CheckExternalEvents(cs2, 0x50D);
    // MOV word ptr [0x152],0x1 (0170_0507 / 0x1C07)
    UInt16[DS, 0x152] = 0x1;
    label_0170_050D_01C0D:
    CheckExternalEvents(cs2, 0x512);
    // CMP word ptr [0x152],0x0 (0170_050D / 0x1C0D)
    Alu.Sub16(UInt16[DS, 0x152], 0x0);
    CheckExternalEvents(cs2, 0x514);
    // JNZ 0x0000:1c17 (0170_0512 / 0x1C12)
    if(!ZeroFlag) {
      goto label_0170_0517_01C17;
    }
    CheckExternalEvents(cs2, 0x517);
    // JMP 0x0000:172d (0170_0514 / 0x1C14)
    goto label_0170_002D_0172D;
    label_0170_0517_01C17:
    CheckExternalEvents(cs2, 0x519);
    // MOV SP,BP (0170_0517 / 0x1C17)
    SP = BP;
    CheckExternalEvents(cs2, 0x51A);
    // POP BP (0170_0519 / 0x1C19)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x51B);
    // RETF  (0170_051A / 0x1C1A)
    return FarRet();
  }
  
  public virtual Action unknown_0170_051B_01C1B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_051B_01C1B:
    CheckExternalEvents(cs2, 0x51C);
    // PUSH BP (0170_051B / 0x1C1B)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x51E);
    // MOV BP,SP (0170_051C / 0x1C1C)
    BP = SP;
    CheckExternalEvents(cs2, 0x521);
    // MOV AX,0x32 (0170_051E / 0x1C1E)
    AX = 0x32;
    CheckExternalEvents(cs2, 0x526);
    // CALLF 0x1000:cecc (0170_0521 / 0x1C21)
    FarCall(cs2, 0x526, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x527);
    // PUSH SI (0170_0526 / 0x1C26)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x52B);
    // MOV ES,word ptr [0x538a] (0170_0527 / 0x1C27)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x531);
    // CMP byte ptr ES:[0xd346],0x0 (0170_052B / 0x1C2B)
    Alu.Sub8(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs2, 0x533);
    // JNZ 0x0000:1c37 (0170_0531 / 0x1C31)
    if(!ZeroFlag) {
      goto label_0170_0537_01C37;
    }
    CheckExternalEvents(cs2, 0x534);
    // PUSH CS (0170_0533 / 0x1C33)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x537);
    // CALL 0x0000:4193 (0170_0534 / 0x1C34)
    NearCall(cs2, 0x537, unknown_0170_2A93_04193);
    label_0170_0537_01C37:
    CheckExternalEvents(cs2, 0x53B);
    // MOV ES,word ptr [0x5390] (0170_0537 / 0x1C37)
    ES = UInt16[DS, 0x5390];
    CheckExternalEvents(cs2, 0x53D);
    // SUB AX,AX (0170_053B / 0x1C3B)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x541);
    // MOV ES:[0x6a],AX (0170_053D / 0x1C3D)
    UInt16[ES, 0x6A] = AX;
    CheckExternalEvents(cs2, 0x544);
    // MOV word ptr [BP + -0x12],AX (0170_0541 / 0x1C41)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs2, 0x547);
    // MOV word ptr [BP + -0xe],AX (0170_0544 / 0x1C44)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs2, 0x54A);
    // MOV word ptr [BP + -0x20],AX (0170_0547 / 0x1C47)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    label_0170_054A_01C4A:
    CheckExternalEvents(cs2, 0x54D);
    // MOV BX,word ptr [BP + -0x20] (0170_054A / 0x1C4A)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x54F);
    // SHL BX,0x1 (0170_054D / 0x1C4D)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x553);
    // MOV ES,word ptr [0x5392] (0170_054F / 0x1C4F)
    ES = UInt16[DS, 0x5392];
    CheckExternalEvents(cs2, 0x55A);
    // MOV word ptr ES:[BX + 0x406a],0x0 (0170_0553 / 0x1C53)
    UInt16[ES, (ushort)(BX + 0x406A)] = 0x0;
    CheckExternalEvents(cs2, 0x55D);
    // INC word ptr [BP + -0x20] (0170_055A / 0x1C5A)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs2, 0x561);
    // CMP word ptr [BP + -0x20],0xc (0170_055D / 0x1C5D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0xC);
    CheckExternalEvents(cs2, 0x563);
    // JL 0x0000:1c4a (0170_0561 / 0x1C61)
    if(SignFlag != OverflowFlag) {
      goto label_0170_054A_01C4A;
    }
    CheckExternalEvents(cs2, 0x568);
    // MOV word ptr [BP + -0x20],0x0 (0170_0563 / 0x1C63)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    CheckExternalEvents(cs2, 0x56A);
    // JMP 0x0000:1ca1 (0170_0568 / 0x1C68)
    goto label_0170_05A1_01CA1;
    label_0170_056A_01C6A:
    CheckExternalEvents(cs2, 0x56D);
    // PUSH word ptr [BP + -0x1e] (0170_056A / 0x1C6A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs2, 0x570);
    // PUSH word ptr [BP + -0x18] (0170_056D / 0x1C6D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0x573);
    // PUSH word ptr [BP + -0x2] (0170_0570 / 0x1C70)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x576);
    // PUSH word ptr [BP + -0x4] (0170_0573 / 0x1C73)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x578);
    // SUB AX,AX (0170_0576 / 0x1C76)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x57B);
    // MOV DX,0xac00 (0170_0578 / 0x1C78)
    DX = 0xAC00;
    CheckExternalEvents(cs2, 0x57C);
    // PUSH DX (0170_057B / 0x1C7B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x57D);
    // PUSH AX (0170_057C / 0x1C7C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x582);
    // CALLF 0x1000:a267 (0170_057D / 0x1C7D)
    FarCall(cs2, 0x582, ghidra_guess_1000_A267_1A267);
    CheckExternalEvents(cs2, 0x585);
    // ADD SP,0xc (0170_0582 / 0x1C82)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    label_0170_0585_01C85:
    CheckExternalEvents(cs2, 0x589);
    // MOV ES,word ptr [0x53a0] (0170_0585 / 0x1C85)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x58F);
    // CMP word ptr ES:[0x4fba],0x0 (0170_0589 / 0x1C89)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x591);
    // JZ 0x0000:1c9b (0170_058F / 0x1C8F)
    if(ZeroFlag) {
      goto label_0170_059B_01C9B;
    }
    CheckExternalEvents(cs2, 0x594);
    // LES BX,[BP + -0x4] (0170_0591 / 0x1C91)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs2, 0x597);
    // MOV AL,byte ptr [BP + -0x16] (0170_0594 / 0x1C94)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x59B);
    // ADD byte ptr ES:[BX + 0x1],AL (0170_0597 / 0x1C97)
    UInt8[ES, (ushort)(BX + 0x1)] += AL;
    label_0170_059B_01C9B:
    CheckExternalEvents(cs2, 0x59E);
    // INC word ptr [BP + -0xe] (0170_059B / 0x1C9B)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0170_059E_01C9E:
    CheckExternalEvents(cs2, 0x5A1);
    // INC word ptr [BP + -0x20] (0170_059E / 0x1C9E)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    label_0170_05A1_01CA1:
    CheckExternalEvents(cs2, 0x5A5);
    // CMP word ptr [BP + -0x20],0x8 (0170_05A1 / 0x1CA1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x8);
    CheckExternalEvents(cs2, 0x5A7);
    // JL 0x0000:1caa (0170_05A5 / 0x1CA5)
    if(SignFlag != OverflowFlag) {
      goto label_0170_05AA_01CAA;
    }
    CheckExternalEvents(cs2, 0x5AA);
    // JMP 0x0000:1e4e (0170_05A7 / 0x1CA7)
    goto label_0170_074E_01E4E;
    label_0170_05AA_01CAA:
    CheckExternalEvents(cs2, 0x5AD);
    // MOV AX,0x11 (0170_05AA / 0x1CAA)
    AX = 0x11;
    CheckExternalEvents(cs2, 0x5B0);
    // IMUL word ptr [BP + -0x20] (0170_05AD / 0x1CAD)
    int resImul0170_05AD = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0170_05AD);
    DX = (ushort)(resImul0170_05AD >> 16);
    CheckExternalEvents(cs2, 0x5B2);
    // MOV SI,AX (0170_05B0 / 0x1CB0)
    SI = AX;
    CheckExternalEvents(cs2, 0x5B6);
    // MOV ES,word ptr [0x538a] (0170_05B2 / 0x1CB2)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x5BC);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0170_05B6 / 0x1CB6)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs2, 0x5BE);
    // JZ 0x0000:1c9e (0170_05BC / 0x1CBC)
    if(ZeroFlag) {
      goto label_0170_059E_01C9E;
    }
    CheckExternalEvents(cs2, 0x5C4);
    // CMP byte ptr ES:[SI + 0xc620],0x8 (0170_05BE / 0x1CBE)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC620)], 0x8);
    CheckExternalEvents(cs2, 0x5C6);
    // JL 0x0000:1c9e (0170_05C4 / 0x1CC4)
    if(SignFlag != OverflowFlag) {
      goto label_0170_059E_01C9E;
    }
    CheckExternalEvents(cs2, 0x5CA);
    // MOV ES,word ptr [0x5390] (0170_05C6 / 0x1CC6)
    ES = UInt16[DS, 0x5390];
    CheckExternalEvents(cs2, 0x5CF);
    // INC word ptr ES:[0x6a] (0170_05CA / 0x1CCA)
    UInt16[ES, 0x6A] = Alu.Inc16(UInt16[ES, 0x6A]);
    CheckExternalEvents(cs2, 0x5D2);
    // MOV SI,word ptr [BP + -0xe] (0170_05CF / 0x1CCF)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs2, 0x5D4);
    // SHL SI,0x1 (0170_05D2 / 0x1CD2)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x5D8);
    // MOV AX,word ptr [SI + 0x2ae] (0170_05D4 / 0x1CD4)
    AX = UInt16[DS, (ushort)(SI + 0x2AE)];
    CheckExternalEvents(cs2, 0x5DB);
    // MOV word ptr [BP + -0x18],AX (0170_05D8 / 0x1CD8)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0x5DF);
    // MOV AX,word ptr [SI + 0x2be] (0170_05DB / 0x1CDB)
    AX = UInt16[DS, (ushort)(SI + 0x2BE)];
    CheckExternalEvents(cs2, 0x5E2);
    // MOV word ptr [BP + -0x1e],AX (0170_05DF / 0x1CDF)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs2, 0x5E6);
    // MOV AX,word ptr [SI + 0x2fe] (0170_05E2 / 0x1CE2)
    AX = UInt16[DS, (ushort)(SI + 0x2FE)];
    CheckExternalEvents(cs2, 0x5EA);
    // MOV ES,word ptr [0x5394] (0170_05E6 / 0x1CE6)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs2, 0x5EF);
    // ADD AX,word ptr ES:[0x9ed] (0170_05EA / 0x1CEA)
    // AX += UInt16[ES, 0x9ED];
    AX = Alu.Add16(AX, UInt16[ES, 0x9ED]);
    CheckExternalEvents(cs2, 0x5F2);
    // MOV word ptr [BP + -0x2c],AX (0170_05EF / 0x1CEF)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs2, 0x5F6);
    // MOV ES,word ptr [0x538c] (0170_05F2 / 0x1CF2)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x5FC);
    // TEST byte ptr ES:[0xa44b],0x1 (0170_05F6 / 0x1CF6)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs2, 0x5FE);
    // JZ 0x0000:1d05 (0170_05FC / 0x1CFC)
    if(ZeroFlag) {
      goto label_0170_0605_01D05;
    }
    CheckExternalEvents(cs2, 0x602);
    // MOV AX,word ptr [SI + 0x30e] (0170_05FE / 0x1CFE)
    AX = UInt16[DS, (ushort)(SI + 0x30E)];
    CheckExternalEvents(cs2, 0x605);
    // ADD word ptr [BP + -0x2c],AX (0170_0602 / 0x1D02)
    // UInt16[SS, (ushort)(BP - 0x2C)] += AX;
    UInt16[SS, (ushort)(BP - 0x2C)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x2C)], AX);
    label_0170_0605_01D05:
    CheckExternalEvents(cs2, 0x609);
    // MOV ES,word ptr [0x538e] (0170_0605 / 0x1D05)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x60F);
    // TEST byte ptr ES:[0xa44d],0x1 (0170_0609 / 0x1D09)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs2, 0x611);
    // JZ 0x0000:1d1d (0170_060F / 0x1D0F)
    if(ZeroFlag) {
      goto label_0170_061D_01D1D;
    }
    CheckExternalEvents(cs2, 0x614);
    // MOV BX,word ptr [BP + -0xe] (0170_0611 / 0x1D11)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs2, 0x616);
    // SHL BX,0x1 (0170_0614 / 0x1D14)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x61A);
    // MOV AX,word ptr [BX + 0x31e] (0170_0616 / 0x1D16)
    AX = UInt16[DS, (ushort)(BX + 0x31E)];
    CheckExternalEvents(cs2, 0x61D);
    // ADD word ptr [BP + -0x2c],AX (0170_061A / 0x1D1A)
    // UInt16[SS, (ushort)(BP - 0x2C)] += AX;
    UInt16[SS, (ushort)(BP - 0x2C)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x2C)], AX);
    label_0170_061D_01D1D:
    CheckExternalEvents(cs2, 0x622);
    // MOV SI,word ptr ES:[0xa44d] (0170_061D / 0x1D1D)
    SI = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x625);
    // AND SI,0x1 (0170_0622 / 0x1D22)
    SI &= 0x1;
    CheckExternalEvents(cs2, 0x627);
    // SHL SI,0x1 (0170_0625 / 0x1D25)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x62B);
    // MOV ES,word ptr [0x538c] (0170_0627 / 0x1D27)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x62F);
    // MOV AX,ES:[0xa44b] (0170_062B / 0x1D2B)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x632);
    // AND AX,0x1 (0170_062F / 0x1D2F)
    AX &= 0x1;
    CheckExternalEvents(cs2, 0x634);
    // ADD SI,AX (0170_0632 / 0x1D32)
    SI += AX;
    CheckExternalEvents(cs2, 0x636);
    // SHL SI,0x1 (0170_0634 / 0x1D34)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x639);
    // MOV BX,word ptr [BP + -0xe] (0170_0636 / 0x1D36)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs2, 0x63B);
    // MOV CL,0x3 (0170_0639 / 0x1D39)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x63D);
    // SHL BX,CL (0170_063B / 0x1D3B)
    // BX <<= CL;
    BX = Alu.Shl16(BX, CL);
    CheckExternalEvents(cs2, 0x641);
    // MOV AX,word ptr [BX + SI + 0x332] (0170_063D / 0x1D3D)
    AX = UInt16[DS, (ushort)(BX + SI + 0x332)];
    CheckExternalEvents(cs2, 0x644);
    // MOV word ptr [BP + -0x32],AX (0170_0641 / 0x1D41)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs2, 0x647);
    // MOV BX,word ptr [BP + -0x2c] (0170_0644 / 0x1D44)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs2, 0x64B);
    // MOV ES,word ptr [0x5396] (0170_0647 / 0x1D47)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs2, 0x650);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0170_064B / 0x1D4B)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs2, 0x652);
    // SUB AH,AH (0170_0650 / 0x1D50)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs2, 0x655);
    // MOV word ptr [BP + -0x28],AX (0170_0652 / 0x1D52)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs2, 0x65A);
    // MOV word ptr [BP + -0x16],0x0 (0170_0655 / 0x1D55)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs2, 0x65E);
    // MOV ES,word ptr [0x538a] (0170_065A / 0x1D5A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x663);
    // CMP byte ptr ES:[0xd346],AH (0170_065E / 0x1D5E)
    Alu.Sub8(UInt8[ES, 0xD346], AH);
    CheckExternalEvents(cs2, 0x665);
    // JNZ 0x0000:1d8f (0170_0663 / 0x1D63)
    if(!ZeroFlag) {
      goto label_0170_068F_01D8F;
    }
    CheckExternalEvents(cs2, 0x668);
    // CMP AX,0xf6 (0170_0665 / 0x1D65)
    Alu.Sub16(AX, 0xF6);
    CheckExternalEvents(cs2, 0x66A);
    // JGE 0x0000:1d8f (0170_0668 / 0x1D68)
    if(SignFlag == OverflowFlag) {
      goto label_0170_068F_01D8F;
    }
    CheckExternalEvents(cs2, 0x66D);
    // MOV AX,word ptr [BP + -0x32] (0170_066A / 0x1D6A)
    AX = UInt16[SS, (ushort)(BP - 0x32)];
    CheckExternalEvents(cs2, 0x670);
    // TEST word ptr [BP + -0x28],AX (0170_066D / 0x1D6D)
    Alu.And16(UInt16[SS, (ushort)(BP - 0x28)], AX);
    CheckExternalEvents(cs2, 0x672);
    // JZ 0x0000:1d8f (0170_0670 / 0x1D70)
    if(ZeroFlag) {
      goto label_0170_068F_01D8F;
    }
    CheckExternalEvents(cs2, 0x675);
    // MOV AX,word ptr [BP + -0x28] (0170_0672 / 0x1D72)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs2, 0x678);
    // AND AX,0xf0 (0170_0675 / 0x1D75)
    // AX &= 0xF0;
    AX = Alu.And16(AX, 0xF0);
    CheckExternalEvents(cs2, 0x67B);
    // MOV word ptr [BP + -0xa],AX (0170_0678 / 0x1D78)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs2, 0x67E);
    // CMP AX,0x30 (0170_067B / 0x1D7B)
    Alu.Sub16(AX, 0x30);
    CheckExternalEvents(cs2, 0x680);
    // JGE 0x0000:1d8f (0170_067E / 0x1D7E)
    if(SignFlag == OverflowFlag) {
      goto label_0170_068F_01D8F;
    }
    CheckExternalEvents(cs2, 0x685);
    // MOV word ptr [BP + -0x16],0x2 (0170_0680 / 0x1D80)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x2;
    CheckExternalEvents(cs2, 0x688);
    // CMP AX,0x20 (0170_0685 / 0x1D85)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs2, 0x68A);
    // JNZ 0x0000:1d8f (0170_0688 / 0x1D88)
    if(!ZeroFlag) {
      goto label_0170_068F_01D8F;
    }
    CheckExternalEvents(cs2, 0x68F);
    // MOV word ptr [BP + -0x16],0x4 (0170_068A / 0x1D8A)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x4;
    label_0170_068F_01D8F:
    CheckExternalEvents(cs2, 0x692);
    // MOV AL,byte ptr [BP + -0x16] (0170_068F / 0x1D8F)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x695);
    // MOV BX,word ptr [BP + -0x20] (0170_0692 / 0x1D92)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x699);
    // MOV ES,word ptr [0x5398] (0170_0695 / 0x1D95)
    ES = UInt16[DS, 0x5398];
    CheckExternalEvents(cs2, 0x69E);
    // MOV byte ptr ES:[BX + 0x32b2],AL (0170_0699 / 0x1D99)
    UInt8[ES, (ushort)(BX + 0x32B2)] = AL;
    CheckExternalEvents(cs2, 0x6A1);
    // MOV BX,word ptr [BP + -0x20] (0170_069E / 0x1D9E)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x6A5);
    // MOV ES,word ptr [0x539a] (0170_06A1 / 0x1DA1)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x6AA);
    // MOV BL,byte ptr ES:[BX + 0x409e] (0170_06A5 / 0x1DA5)
    BL = UInt8[ES, (ushort)(BX + 0x409E)];
    CheckExternalEvents(cs2, 0x6AC);
    // SUB BH,BH (0170_06AA / 0x1DAA)
    // BH -= BH;
    BH = Alu.Sub8(BH, BH);
    CheckExternalEvents(cs2, 0x6AF);
    // MOV SI,word ptr [BP + -0x20] (0170_06AC / 0x1DAC)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x6B3);
    // MOV ES,word ptr [0x539c] (0170_06AF / 0x1DAF)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs2, 0x6B8);
    // MOV AL,byte ptr ES:[SI + 0xd562] (0170_06B3 / 0x1DB3)
    AL = UInt8[ES, (ushort)(SI + 0xD562)];
    CheckExternalEvents(cs2, 0x6BA);
    // SUB AH,AH (0170_06B8 / 0x1DB8)
    AH -= AH;
    CheckExternalEvents(cs2, 0x6BC);
    // ADD BX,AX (0170_06BA / 0x1DBA)
    BX += AX;
    CheckExternalEvents(cs2, 0x6BE);
    // SHL BX,0x1 (0170_06BC / 0x1DBC)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x6C0);
    // SHL BX,0x1 (0170_06BE / 0x1DBE)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x6C4);
    // MOV ES,word ptr [0x539e] (0170_06C0 / 0x1DC0)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0x6C9);
    // MOV AX,word ptr ES:[BX + 0x39fa] (0170_06C4 / 0x1DC4)
    AX = UInt16[ES, (ushort)(BX + 0x39FA)];
    CheckExternalEvents(cs2, 0x6CE);
    // MOV DX,word ptr ES:[BX + 0x39fc] (0170_06C9 / 0x1DC9)
    DX = UInt16[ES, (ushort)(BX + 0x39FC)];
    CheckExternalEvents(cs2, 0x6D1);
    // MOV word ptr [BP + -0x4],AX (0170_06CE / 0x1DCE)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x6D4);
    // MOV word ptr [BP + -0x2],DX (0170_06D1 / 0x1DD1)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs2, 0x6D8);
    // MOV ES,word ptr [0x53a0] (0170_06D4 / 0x1DD4)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x6DE);
    // CMP word ptr ES:[0x4fba],0x0 (0170_06D8 / 0x1DD8)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x6E0);
    // JZ 0x0000:1dea (0170_06DE / 0x1DDE)
    if(ZeroFlag) {
      goto label_0170_06EA_01DEA;
    }
    CheckExternalEvents(cs2, 0x6E3);
    // LES BX,[BP + -0x4] (0170_06E0 / 0x1DE0)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs2, 0x6E6);
    // MOV AL,byte ptr [BP + -0x16] (0170_06E3 / 0x1DE3)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x6EA);
    // SUB byte ptr ES:[BX + 0x1],AL (0170_06E6 / 0x1DE6)
    // UInt8[ES, (ushort)(BX + 0x1)] -= AL;
    UInt8[ES, (ushort)(BX + 0x1)] = Alu.Sub8(UInt8[ES, (ushort)(BX + 0x1)], AL);
    label_0170_06EA_01DEA:
    CheckExternalEvents(cs2, 0x6EE);
    // MOV ES,word ptr [0x53a0] (0170_06EA / 0x1DEA)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x6F4);
    // CMP word ptr ES:[0x4fba],0x2 (0170_06EE / 0x1DEE)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x6F6);
    // JNZ 0x0000:1df9 (0170_06F4 / 0x1DF4)
    if(!ZeroFlag) {
      goto label_0170_06F9_01DF9;
    }
    CheckExternalEvents(cs2, 0x6F9);
    // JMP 0x0000:1c6a (0170_06F6 / 0x1DF6)
    goto label_0170_056A_01C6A;
    label_0170_06F9_01DF9:
    CheckExternalEvents(cs2, 0x6FF);
    // CMP word ptr ES:[0x4fba],0x0 (0170_06F9 / 0x1DF9)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x701);
    // JNZ 0x0000:1e24 (0170_06FF / 0x1DFF)
    if(!ZeroFlag) {
      goto label_0170_0724_01E24;
    }
    CheckExternalEvents(cs2, 0x705);
    // CMP word ptr [BP + -0x16],0x0 (0170_0701 / 0x1E01)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x0);
    CheckExternalEvents(cs2, 0x707);
    // JZ 0x0000:1e24 (0170_0705 / 0x1E05)
    if(ZeroFlag) {
      goto label_0170_0724_01E24;
    }
    CheckExternalEvents(cs2, 0x70B);
    // MOV ES,word ptr [0x53a2] (0170_0707 / 0x1E07)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs2, 0x70E);
    // MOV AX,word ptr [BP + -0x1e] (0170_070B / 0x1E0B)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0x711);
    // SUB AX,word ptr [BP + -0x16] (0170_070E / 0x1E0E)
    AX -= UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x714);
    // ADD AX,0x8 (0170_0711 / 0x1E11)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs2, 0x718);
    // MOV ES:[0xb780],AX (0170_0714 / 0x1E14)
    UInt16[ES, 0xB780] = AX;
    CheckExternalEvents(cs2, 0x71B);
    // CMP AX,0xc8 (0170_0718 / 0x1E18)
    Alu.Sub16(AX, 0xC8);
    CheckExternalEvents(cs2, 0x71D);
    // JLE 0x0000:1e24 (0170_071B / 0x1E1B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_0724_01E24;
    }
    CheckExternalEvents(cs2, 0x724);
    // MOV word ptr ES:[0xb780],0xc8 (0170_071D / 0x1E1D)
    UInt16[ES, 0xB780] = 0xC8;
    label_0170_0724_01E24:
    CheckExternalEvents(cs2, 0x727);
    // PUSH word ptr [BP + -0x1e] (0170_0724 / 0x1E24)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs2, 0x72A);
    // PUSH word ptr [BP + -0x18] (0170_0727 / 0x1E27)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0x72D);
    // PUSH word ptr [BP + -0x2] (0170_072A / 0x1E2A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x730);
    // PUSH word ptr [BP + -0x4] (0170_072D / 0x1E2D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x733);
    // MOV AX,0x244b (0170_0730 / 0x1E30)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x736);
    // MOV DX,0x1ddc (0170_0733 / 0x1E33)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x737);
    // PUSH DX (0170_0736 / 0x1E36)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x738);
    // PUSH AX (0170_0737 / 0x1E37)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x73D);
    // CALLF 0x1000:c7db (0170_0738 / 0x1E38)
    FarCall(cs2, 0x73D, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs2, 0x740);
    // ADD SP,0xc (0170_073D / 0x1E3D)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0x744);
    // MOV ES,word ptr [0x53a2] (0170_0740 / 0x1E40)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs2, 0x74B);
    // MOV word ptr ES:[0xb780],0xc8 (0170_0744 / 0x1E44)
    UInt16[ES, 0xB780] = 0xC8;
    CheckExternalEvents(cs2, 0x74E);
    // JMP 0x0000:1c85 (0170_074B / 0x1E4B)
    goto label_0170_0585_01C85;
    label_0170_074E_01E4E:
    CheckExternalEvents(cs2, 0x752);
    // MOV ES,word ptr [0x538c] (0170_074E / 0x1E4E)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x756);
    // MOV AX,ES:[0xa44b] (0170_0752 / 0x1E52)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x759);
    // MOV word ptr [BP + -0x8],AX (0170_0756 / 0x1E56)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x75D);
    // MOV ES,word ptr [0x538e] (0170_0759 / 0x1E59)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x761);
    // MOV AX,ES:[0xa44d] (0170_075D / 0x1E5D)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x764);
    // MOV word ptr [BP + -0xc],AX (0170_0761 / 0x1E61)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs2, 0x769);
    // MOV word ptr [BP + -0x20],0x10 (0170_0764 / 0x1E64)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x10;
    CheckExternalEvents(cs2, 0x76B);
    // JMP 0x0000:1e9f (0170_0769 / 0x1E69)
    goto label_0170_079F_01E9F;
    label_0170_076B_01E6B:
    CheckExternalEvents(cs2, 0x76E);
    // PUSH word ptr [BP + -0x1e] (0170_076B / 0x1E6B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs2, 0x771);
    // PUSH word ptr [BP + -0x18] (0170_076E / 0x1E6E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0x774);
    // PUSH word ptr [BP + -0x2] (0170_0771 / 0x1E71)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x777);
    // PUSH word ptr [BP + -0x4] (0170_0774 / 0x1E74)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x779);
    // SUB AX,AX (0170_0777 / 0x1E77)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x77C);
    // MOV DX,0xac00 (0170_0779 / 0x1E79)
    DX = 0xAC00;
    CheckExternalEvents(cs2, 0x77D);
    // PUSH DX (0170_077C / 0x1E7C)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x77E);
    // PUSH AX (0170_077D / 0x1E7D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x783);
    // CALLF 0x1000:a267 (0170_077E / 0x1E7E)
    FarCall(cs2, 0x783, ghidra_guess_1000_A267_1A267);
    CheckExternalEvents(cs2, 0x786);
    // ADD SP,0xc (0170_0783 / 0x1E83)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    label_0170_0786_01E86:
    CheckExternalEvents(cs2, 0x78A);
    // MOV ES,word ptr [0x53a0] (0170_0786 / 0x1E86)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x790);
    // CMP word ptr ES:[0x4fba],0x0 (0170_078A / 0x1E8A)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x792);
    // JZ 0x0000:1e9c (0170_0790 / 0x1E90)
    if(ZeroFlag) {
      goto label_0170_079C_01E9C;
    }
    CheckExternalEvents(cs2, 0x795);
    // LES BX,[BP + -0x4] (0170_0792 / 0x1E92)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs2, 0x798);
    // MOV AL,byte ptr [BP + -0x16] (0170_0795 / 0x1E95)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x79C);
    // ADD byte ptr ES:[BX + 0x1],AL (0170_0798 / 0x1E98)
    UInt8[ES, (ushort)(BX + 0x1)] += AL;
    label_0170_079C_01E9C:
    CheckExternalEvents(cs2, 0x79F);
    // INC word ptr [BP + -0x20] (0170_079C / 0x1E9C)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    label_0170_079F_01E9F:
    CheckExternalEvents(cs2, 0x7A3);
    // CMP word ptr [BP + -0x20],0x18 (0170_079F / 0x1E9F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x18);
    CheckExternalEvents(cs2, 0x7A5);
    // JL 0x0000:1ea8 (0170_07A3 / 0x1EA3)
    if(SignFlag != OverflowFlag) {
      goto label_0170_07A8_01EA8;
    }
    CheckExternalEvents(cs2, 0x7A8);
    // JMP 0x0000:20fe (0170_07A5 / 0x1EA5)
    goto label_0170_09FE_020FE;
    label_0170_07A8_01EA8:
    CheckExternalEvents(cs2, 0x7AB);
    // MOV AX,0x1a (0170_07A8 / 0x1EA8)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x7AE);
    // IMUL word ptr [BP + -0x20] (0170_07AB / 0x1EAB)
    int resImul0170_07AB = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0170_07AB);
    DX = (ushort)(resImul0170_07AB >> 16);
    CheckExternalEvents(cs2, 0x7B0);
    // MOV BX,AX (0170_07AE / 0x1EAE)
    BX = AX;
    CheckExternalEvents(cs2, 0x7B4);
    // MOV ES,word ptr [0x538a] (0170_07B0 / 0x1EB0)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x7BA);
    // CMP byte ptr ES:[BX + 0xd1f9],0x0 (0170_07B4 / 0x1EB4)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xD1F9)], 0x0);
    CheckExternalEvents(cs2, 0x7BC);
    // JNZ 0x0000:1e9c (0170_07BA / 0x1EBA)
    if(!ZeroFlag) {
      goto label_0170_079C_01E9C;
    }
    CheckExternalEvents(cs2, 0x7BF);
    // MOV SI,word ptr [BP + -0x20] (0170_07BC / 0x1EBC)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x7C1);
    // SHL SI,0x1 (0170_07BF / 0x1EBF)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x7C5);
    // MOV ES,word ptr [0x53a4] (0170_07C1 / 0x1EC1)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x7CA);
    // MOV AX,word ptr ES:[SI + 0x4004] (0170_07C5 / 0x1EC5)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs2, 0x7CD);
    // MOV word ptr [BP + -0x18],AX (0170_07CA / 0x1ECA)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0x7D1);
    // MOV ES,word ptr [0x53a6] (0170_07CD / 0x1ECD)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x7D6);
    // MOV AX,word ptr ES:[SI + 0x4036] (0170_07D1 / 0x1ED1)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs2, 0x7D9);
    // MOV word ptr [BP + -0x1e],AX (0170_07D6 / 0x1ED6)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs2, 0x7DB);
    // SUB AX,AX (0170_07D9 / 0x1ED9)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x7DE);
    // MOV word ptr [BP + -0x26],AX (0170_07DB / 0x1EDB)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs2, 0x7E1);
    // MOV word ptr [BP + -0x22],AX (0170_07DE / 0x1EDE)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs2, 0x7E4);
    // MOV AX,word ptr [BP + -0x18] (0170_07E1 / 0x1EE1)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs2, 0x7E7);
    // SUB AX,word ptr [BP + -0x8] (0170_07E4 / 0x1EE4)
    AX -= UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x7EA);
    // ADD AX,0x1a (0170_07E7 / 0x1EE7)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs2, 0x7ED);
    // MOV word ptr [BP + -0x18],AX (0170_07EA / 0x1EEA)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0x7F0);
    // MOV AX,word ptr [BP + -0x1e] (0170_07ED / 0x1EED)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0x7F3);
    // SUB AX,word ptr [BP + -0xc] (0170_07F0 / 0x1EF0)
    AX -= UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x7F6);
    // ADD AX,0xc (0170_07F3 / 0x1EF3)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs2, 0x7F9);
    // MOV word ptr [BP + -0x1e],AX (0170_07F6 / 0x1EF6)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs2, 0x7FD);
    // MOV ES,word ptr [0x53a4] (0170_07F9 / 0x1EF9)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x802);
    // MOV AX,word ptr ES:[SI + 0x4004] (0170_07FD / 0x1EFD)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs2, 0x804);
    // SUB AL,AL (0170_0802 / 0x1F02)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x807);
    // MOV CX,word ptr [BP + -0x8] (0170_0804 / 0x1F04)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x809);
    // SUB CL,CL (0170_0807 / 0x1F07)
    CL -= CL;
    CheckExternalEvents(cs2, 0x80B);
    // CMP AX,CX (0170_0809 / 0x1F09)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs2, 0x80D);
    // JNZ 0x0000:1f1e (0170_080B / 0x1F0B)
    if(!ZeroFlag) {
      goto label_0170_081E_01F1E;
    }
    CheckExternalEvents(cs2, 0x811);
    // CMP word ptr [BP + -0x18],0xd (0170_080D / 0x1F0D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xD);
    CheckExternalEvents(cs2, 0x813);
    // JL 0x0000:1f19 (0170_0811 / 0x1F11)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0819_01F19;
    }
    CheckExternalEvents(cs2, 0x817);
    // CMP word ptr [BP + -0x18],0x27 (0170_0813 / 0x1F13)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0x27);
    CheckExternalEvents(cs2, 0x819);
    // JLE 0x0000:1f1e (0170_0817 / 0x1F17)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_081E_01F1E;
    }
    label_0170_0819_01F19:
    CheckExternalEvents(cs2, 0x81E);
    // MOV word ptr [BP + -0x22],0x1 (0170_0819 / 0x1F19)
    UInt16[SS, (ushort)(BP - 0x22)] = 0x1;
    label_0170_081E_01F1E:
    CheckExternalEvents(cs2, 0x821);
    // MOV BX,word ptr [BP + -0x20] (0170_081E / 0x1F1E)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x823);
    // SHL BX,0x1 (0170_0821 / 0x1F21)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x827);
    // MOV ES,word ptr [0x53a6] (0170_0823 / 0x1F23)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x82C);
    // MOV AX,word ptr ES:[BX + 0x4036] (0170_0827 / 0x1F27)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs2, 0x82E);
    // SUB AL,AL (0170_082C / 0x1F2C)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs2, 0x831);
    // MOV CX,word ptr [BP + -0xc] (0170_082E / 0x1F2E)
    CX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x833);
    // SUB CL,CL (0170_0831 / 0x1F31)
    CL -= CL;
    CheckExternalEvents(cs2, 0x835);
    // CMP AX,CX (0170_0833 / 0x1F33)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs2, 0x837);
    // JNZ 0x0000:1f48 (0170_0835 / 0x1F35)
    if(!ZeroFlag) {
      goto label_0170_0848_01F48;
    }
    CheckExternalEvents(cs2, 0x83B);
    // CMP word ptr [BP + -0x1e],0x0 (0170_0837 / 0x1F37)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0x0);
    CheckExternalEvents(cs2, 0x83D);
    // JL 0x0000:1f43 (0170_083B / 0x1F3B)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0843_01F43;
    }
    CheckExternalEvents(cs2, 0x841);
    // CMP word ptr [BP + -0x1e],0x18 (0170_083D / 0x1F3D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0x18);
    CheckExternalEvents(cs2, 0x843);
    // JLE 0x0000:1f48 (0170_0841 / 0x1F41)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_0848_01F48;
    }
    label_0170_0843_01F43:
    CheckExternalEvents(cs2, 0x848);
    // MOV word ptr [BP + -0x26],0x1 (0170_0843 / 0x1F43)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x1;
    label_0170_0848_01F48:
    CheckExternalEvents(cs2, 0x84C);
    // CMP word ptr [BP + -0x18],-0x73 (0170_0848 / 0x1F48)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xFF8D);
    CheckExternalEvents(cs2, 0x84E);
    // JGE 0x0000:1f51 (0170_084C / 0x1F4C)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0851_01F51;
    }
    CheckExternalEvents(cs2, 0x851);
    // JMP 0x0000:1e9c (0170_084E / 0x1F4E)
    goto label_0170_079C_01E9C;
    label_0170_0851_01F51:
    CheckExternalEvents(cs2, 0x856);
    // CMP word ptr [BP + -0x18],0xa7 (0170_0851 / 0x1F51)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xA7);
    CheckExternalEvents(cs2, 0x858);
    // JLE 0x0000:1f5b (0170_0856 / 0x1F56)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_085B_01F5B;
    }
    CheckExternalEvents(cs2, 0x85B);
    // JMP 0x0000:1e9c (0170_0858 / 0x1F58)
    goto label_0170_079C_01E9C;
    label_0170_085B_01F5B:
    CheckExternalEvents(cs2, 0x860);
    // CMP word ptr [BP + -0x1e],0xf080 (0170_085B / 0x1F5B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0xF080);
    CheckExternalEvents(cs2, 0x862);
    // JGE 0x0000:1f65 (0170_0860 / 0x1F60)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0865_01F65;
    }
    CheckExternalEvents(cs2, 0x865);
    // JMP 0x0000:1e9c (0170_0862 / 0x1F62)
    goto label_0170_079C_01E9C;
    label_0170_0865_01F65:
    CheckExternalEvents(cs2, 0x86A);
    // CMP word ptr [BP + -0x1e],0xf98 (0170_0865 / 0x1F65)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0xF98);
    CheckExternalEvents(cs2, 0x86C);
    // JLE 0x0000:1f6f (0170_086A / 0x1F6A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_086F_01F6F;
    }
    CheckExternalEvents(cs2, 0x86F);
    // JMP 0x0000:1e9c (0170_086C / 0x1F6C)
    goto label_0170_079C_01E9C;
    label_0170_086F_01F6F:
    CheckExternalEvents(cs2, 0x872);
    // MOV AX,word ptr [BP + -0x22] (0170_086F / 0x1F6F)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs2, 0x875);
    // ADD AX,word ptr [BP + -0x26] (0170_0872 / 0x1F72)
    // AX += UInt16[SS, (ushort)(BP - 0x26)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs2, 0x877);
    // JZ 0x0000:1f7a (0170_0875 / 0x1F75)
    if(ZeroFlag) {
      goto label_0170_087A_01F7A;
    }
    CheckExternalEvents(cs2, 0x87A);
    // JMP 0x0000:1e9c (0170_0877 / 0x1F77)
    goto label_0170_079C_01E9C;
    label_0170_087A_01F7A:
    CheckExternalEvents(cs2, 0x87E);
    // AND word ptr [BP + -0x18],0x7f (0170_087A / 0x1F7A)
    UInt16[SS, (ushort)(BP - 0x18)] &= 0x7F;
    CheckExternalEvents(cs2, 0x882);
    // AND word ptr [BP + -0x1e],0x7f (0170_087E / 0x1F7E)
    // UInt16[SS, (ushort)(BP - 0x1E)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x1E)], 0x7F);
    CheckExternalEvents(cs2, 0x885);
    // MOV AX,word ptr [BP + -0x18] (0170_0882 / 0x1F82)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs2, 0x888);
    // SUB AX,0xd (0170_0885 / 0x1F85)
    // AX -= 0xD;
    AX = Alu.Sub16(AX, 0xD);
    CheckExternalEvents(cs2, 0x88B);
    // MOV word ptr [BP + -0x2a],AX (0170_0888 / 0x1F88)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs2, 0x88E);
    // MOV AX,word ptr [BP + -0x1e] (0170_088B / 0x1F8B)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0x890);
    // SAR AX,0x1 (0170_088E / 0x1F8E)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs2, 0x893);
    // MOV CX,0x18 (0170_0890 / 0x1F90)
    CX = 0x18;
    CheckExternalEvents(cs2, 0x895);
    // IMUL CX (0170_0893 / 0x1F93)
    int resImul0170_0893 = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0170_0893);
    DX = (ushort)(resImul0170_0893 >> 16);
    CheckExternalEvents(cs2, 0x898);
    // MOV CX,word ptr [BP + -0x2a] (0170_0895 / 0x1F95)
    CX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs2, 0x89A);
    // SAR CX,0x1 (0170_0898 / 0x1F98)
    CX = Alu.Sar16(CX, 0x1);
    CheckExternalEvents(cs2, 0x89C);
    // ADD AX,CX (0170_089A / 0x1F9A)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs2, 0x8A0);
    // MOV ES,word ptr [0x5394] (0170_089C / 0x1F9C)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs2, 0x8A5);
    // ADD AX,word ptr ES:[0x9ed] (0170_08A0 / 0x1FA0)
    // AX += UInt16[ES, 0x9ED];
    AX = Alu.Add16(AX, UInt16[ES, 0x9ED]);
    CheckExternalEvents(cs2, 0x8A8);
    // MOV word ptr [BP + -0x14],AX (0170_08A5 / 0x1FA5)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs2, 0x8AC);
    // TEST byte ptr [BP + -0x2a],0x1 (0170_08A8 / 0x1FA8)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x2A)], 0x1);
    CheckExternalEvents(cs2, 0x8AE);
    // JZ 0x0000:1fbd (0170_08AC / 0x1FAC)
    if(ZeroFlag) {
      goto label_0170_08BD_01FBD;
    }
    CheckExternalEvents(cs2, 0x8B2);
    // MOV ES,word ptr [0x538c] (0170_08AE / 0x1FAE)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x8B8);
    // TEST byte ptr ES:[0xa44b],0x1 (0170_08B2 / 0x1FB2)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs2, 0x8BA);
    // JZ 0x0000:1fbd (0170_08B8 / 0x1FB8)
    if(ZeroFlag) {
      goto label_0170_08BD_01FBD;
    }
    CheckExternalEvents(cs2, 0x8BD);
    // INC word ptr [BP + -0x14] (0170_08BA / 0x1FBA)
    UInt16[SS, (ushort)(BP - 0x14)]++;
    label_0170_08BD_01FBD:
    CheckExternalEvents(cs2, 0x8C1);
    // TEST byte ptr [BP + -0x1e],0x1 (0170_08BD / 0x1FBD)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x1E)], 0x1);
    CheckExternalEvents(cs2, 0x8C3);
    // JZ 0x0000:1fd3 (0170_08C1 / 0x1FC1)
    if(ZeroFlag) {
      goto label_0170_08D3_01FD3;
    }
    CheckExternalEvents(cs2, 0x8C7);
    // MOV ES,word ptr [0x538e] (0170_08C3 / 0x1FC3)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x8CD);
    // TEST byte ptr ES:[0xa44d],0x1 (0170_08C7 / 0x1FC7)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs2, 0x8CF);
    // JZ 0x0000:1fd3 (0170_08CD / 0x1FCD)
    if(ZeroFlag) {
      goto label_0170_08D3_01FD3;
    }
    CheckExternalEvents(cs2, 0x8D3);
    // ADD word ptr [BP + -0x14],0x18 (0170_08CF / 0x1FCF)
    // UInt16[SS, (ushort)(BP - 0x14)] += 0x18;
    UInt16[SS, (ushort)(BP - 0x14)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x14)], 0x18);
    label_0170_08D3_01FD3:
    CheckExternalEvents(cs2, 0x8D6);
    // MOV SI,word ptr [BP + -0x1e] (0170_08D3 / 0x1FD3)
    SI = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0x8DA);
    // MOV ES,word ptr [0x538e] (0170_08D6 / 0x1FD6)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x8DF);
    // XOR SI,word ptr ES:[0xa44d] (0170_08DA / 0x1FDA)
    SI ^= UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x8E2);
    // AND SI,0x1 (0170_08DF / 0x1FDF)
    SI &= 0x1;
    CheckExternalEvents(cs2, 0x8E4);
    // SHL SI,0x1 (0170_08E2 / 0x1FE2)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x8E7);
    // MOV BX,word ptr [BP + -0x2a] (0170_08E4 / 0x1FE4)
    BX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs2, 0x8EB);
    // MOV ES,word ptr [0x538c] (0170_08E7 / 0x1FE7)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x8F0);
    // XOR BX,word ptr ES:[0xa44b] (0170_08EB / 0x1FEB)
    BX ^= UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x8F3);
    // AND BX,0x1 (0170_08F0 / 0x1FF0)
    // BX &= 0x1;
    BX = Alu.And16(BX, 0x1);
    CheckExternalEvents(cs2, 0x8F7);
    // MOV AL,byte ptr [BX + SI + 0x32e] (0170_08F3 / 0x1FF3)
    AL = UInt8[DS, (ushort)(BX + SI + 0x32E)];
    CheckExternalEvents(cs2, 0x8F8);
    // CBW  (0170_08F7 / 0x1FF7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x8FB);
    // MOV word ptr [BP + -0x32],AX (0170_08F8 / 0x1FF8)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs2, 0x8FE);
    // MOV BX,word ptr [BP + -0x14] (0170_08FB / 0x1FFB)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x902);
    // MOV ES,word ptr [0x5396] (0170_08FE / 0x1FFE)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs2, 0x907);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0170_0902 / 0x2002)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs2, 0x909);
    // SUB AH,AH (0170_0907 / 0x2007)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs2, 0x90C);
    // MOV word ptr [BP + -0x1a],AX (0170_0909 / 0x2009)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs2, 0x911);
    // MOV word ptr [BP + -0x16],0x0 (0170_090C / 0x200C)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs2, 0x915);
    // MOV ES,word ptr [0x538a] (0170_0911 / 0x2011)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x91A);
    // CMP byte ptr ES:[0xd346],AH (0170_0915 / 0x2015)
    Alu.Sub8(UInt8[ES, 0xD346], AH);
    CheckExternalEvents(cs2, 0x91C);
    // JNZ 0x0000:2046 (0170_091A / 0x201A)
    if(!ZeroFlag) {
      goto label_0170_0946_02046;
    }
    CheckExternalEvents(cs2, 0x91F);
    // CMP AX,0xf6 (0170_091C / 0x201C)
    Alu.Sub16(AX, 0xF6);
    CheckExternalEvents(cs2, 0x921);
    // JGE 0x0000:2046 (0170_091F / 0x201F)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0946_02046;
    }
    CheckExternalEvents(cs2, 0x924);
    // MOV AX,word ptr [BP + -0x32] (0170_0921 / 0x2021)
    AX = UInt16[SS, (ushort)(BP - 0x32)];
    CheckExternalEvents(cs2, 0x927);
    // TEST word ptr [BP + -0x1a],AX (0170_0924 / 0x2024)
    Alu.And16(UInt16[SS, (ushort)(BP - 0x1A)], AX);
    CheckExternalEvents(cs2, 0x929);
    // JZ 0x0000:2046 (0170_0927 / 0x2027)
    if(ZeroFlag) {
      goto label_0170_0946_02046;
    }
    CheckExternalEvents(cs2, 0x92C);
    // MOV AX,word ptr [BP + -0x1a] (0170_0929 / 0x2029)
    AX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs2, 0x92F);
    // AND AX,0xf0 (0170_092C / 0x202C)
    // AX &= 0xF0;
    AX = Alu.And16(AX, 0xF0);
    CheckExternalEvents(cs2, 0x932);
    // MOV word ptr [BP + -0xa],AX (0170_092F / 0x202F)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs2, 0x935);
    // CMP AX,0x30 (0170_0932 / 0x2032)
    Alu.Sub16(AX, 0x30);
    CheckExternalEvents(cs2, 0x937);
    // JGE 0x0000:2046 (0170_0935 / 0x2035)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0946_02046;
    }
    CheckExternalEvents(cs2, 0x93C);
    // MOV word ptr [BP + -0x16],0x2 (0170_0937 / 0x2037)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x2;
    CheckExternalEvents(cs2, 0x93F);
    // CMP AX,0x20 (0170_093C / 0x203C)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs2, 0x941);
    // JNZ 0x0000:2046 (0170_093F / 0x203F)
    if(!ZeroFlag) {
      goto label_0170_0946_02046;
    }
    CheckExternalEvents(cs2, 0x946);
    // MOV word ptr [BP + -0x16],0x4 (0170_0941 / 0x2041)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x4;
    label_0170_0946_02046:
    CheckExternalEvents(cs2, 0x948);
    // MOV CL,0x3 (0170_0946 / 0x2046)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x94B);
    // SHL word ptr [BP + -0x18],CL (0170_0948 / 0x2048)
    UInt16[SS, (ushort)(BP - 0x18)] <<= CL;
    CheckExternalEvents(cs2, 0x94E);
    // SHL word ptr [BP + -0x1e],CL (0170_094B / 0x204B)
    // UInt16[SS, (ushort)(BP - 0x1E)] <<= CL;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu.Shl16(UInt16[SS, (ushort)(BP - 0x1E)], CL);
    CheckExternalEvents(cs2, 0x951);
    // MOV BX,word ptr [BP + -0x20] (0170_094E / 0x204E)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x955);
    // MOV ES,word ptr [0x539a] (0170_0951 / 0x2051)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x95A);
    // MOV BL,byte ptr ES:[BX + 0x409a] (0170_0955 / 0x2055)
    BL = UInt8[ES, (ushort)(BX + 0x409A)];
    CheckExternalEvents(cs2, 0x95C);
    // SUB BH,BH (0170_095A / 0x205A)
    // BH -= BH;
    BH = Alu.Sub8(BH, BH);
    CheckExternalEvents(cs2, 0x95F);
    // MOV SI,word ptr [BP + -0x20] (0170_095C / 0x205C)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0x963);
    // MOV ES,word ptr [0x539c] (0170_095F / 0x205F)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs2, 0x968);
    // MOV AL,byte ptr ES:[SI + 0xd55e] (0170_0963 / 0x2063)
    AL = UInt8[ES, (ushort)(SI + 0xD55E)];
    CheckExternalEvents(cs2, 0x96A);
    // SUB AH,AH (0170_0968 / 0x2068)
    AH -= AH;
    CheckExternalEvents(cs2, 0x96C);
    // ADD BX,AX (0170_096A / 0x206A)
    BX += AX;
    CheckExternalEvents(cs2, 0x96E);
    // SHL BX,0x1 (0170_096C / 0x206C)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x970);
    // SHL BX,0x1 (0170_096E / 0x206E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x974);
    // MOV ES,word ptr [0x539e] (0170_0970 / 0x2070)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0x979);
    // MOV AX,word ptr ES:[BX + 0x39fa] (0170_0974 / 0x2074)
    AX = UInt16[ES, (ushort)(BX + 0x39FA)];
    CheckExternalEvents(cs2, 0x97E);
    // MOV DX,word ptr ES:[BX + 0x39fc] (0170_0979 / 0x2079)
    DX = UInt16[ES, (ushort)(BX + 0x39FC)];
    CheckExternalEvents(cs2, 0x981);
    // MOV word ptr [BP + -0x4],AX (0170_097E / 0x207E)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x984);
    // MOV word ptr [BP + -0x2],DX (0170_0981 / 0x2081)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs2, 0x988);
    // MOV ES,word ptr [0x53a0] (0170_0984 / 0x2084)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x98E);
    // CMP word ptr ES:[0x4fba],0x0 (0170_0988 / 0x2088)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x990);
    // JZ 0x0000:209a (0170_098E / 0x208E)
    if(ZeroFlag) {
      goto label_0170_099A_0209A;
    }
    CheckExternalEvents(cs2, 0x993);
    // LES BX,[BP + -0x4] (0170_0990 / 0x2090)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs2, 0x996);
    // MOV AL,byte ptr [BP + -0x16] (0170_0993 / 0x2093)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x99A);
    // SUB byte ptr ES:[BX + 0x1],AL (0170_0996 / 0x2096)
    // UInt8[ES, (ushort)(BX + 0x1)] -= AL;
    UInt8[ES, (ushort)(BX + 0x1)] = Alu.Sub8(UInt8[ES, (ushort)(BX + 0x1)], AL);
    label_0170_099A_0209A:
    CheckExternalEvents(cs2, 0x99E);
    // MOV ES,word ptr [0x53a0] (0170_099A / 0x209A)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x9A4);
    // CMP word ptr ES:[0x4fba],0x2 (0170_099E / 0x209E)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x9A6);
    // JNZ 0x0000:20a9 (0170_09A4 / 0x20A4)
    if(!ZeroFlag) {
      goto label_0170_09A9_020A9;
    }
    CheckExternalEvents(cs2, 0x9A9);
    // JMP 0x0000:1e6b (0170_09A6 / 0x20A6)
    goto label_0170_076B_01E6B;
    label_0170_09A9_020A9:
    CheckExternalEvents(cs2, 0x9AF);
    // CMP word ptr ES:[0x4fba],0x0 (0170_09A9 / 0x20A9)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x9B1);
    // JNZ 0x0000:20d4 (0170_09AF / 0x20AF)
    if(!ZeroFlag) {
      goto label_0170_09D4_020D4;
    }
    CheckExternalEvents(cs2, 0x9B5);
    // CMP word ptr [BP + -0x16],0x0 (0170_09B1 / 0x20B1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x0);
    CheckExternalEvents(cs2, 0x9B7);
    // JZ 0x0000:20d4 (0170_09B5 / 0x20B5)
    if(ZeroFlag) {
      goto label_0170_09D4_020D4;
    }
    CheckExternalEvents(cs2, 0x9BB);
    // MOV ES,word ptr [0x53a2] (0170_09B7 / 0x20B7)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs2, 0x9BE);
    // MOV AX,word ptr [BP + -0x1e] (0170_09BB / 0x20BB)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0x9C1);
    // SUB AX,word ptr [BP + -0x16] (0170_09BE / 0x20BE)
    AX -= UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x9C4);
    // ADD AX,0x8 (0170_09C1 / 0x20C1)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs2, 0x9C8);
    // MOV ES:[0xb780],AX (0170_09C4 / 0x20C4)
    UInt16[ES, 0xB780] = AX;
    CheckExternalEvents(cs2, 0x9CB);
    // CMP AX,0xc8 (0170_09C8 / 0x20C8)
    Alu.Sub16(AX, 0xC8);
    CheckExternalEvents(cs2, 0x9CD);
    // JLE 0x0000:20d4 (0170_09CB / 0x20CB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_09D4_020D4;
    }
    CheckExternalEvents(cs2, 0x9D4);
    // MOV word ptr ES:[0xb780],0xc8 (0170_09CD / 0x20CD)
    UInt16[ES, 0xB780] = 0xC8;
    label_0170_09D4_020D4:
    CheckExternalEvents(cs2, 0x9D7);
    // PUSH word ptr [BP + -0x1e] (0170_09D4 / 0x20D4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs2, 0x9DA);
    // PUSH word ptr [BP + -0x18] (0170_09D7 / 0x20D7)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0x9DD);
    // PUSH word ptr [BP + -0x2] (0170_09DA / 0x20DA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x9E0);
    // PUSH word ptr [BP + -0x4] (0170_09DD / 0x20DD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x9E3);
    // MOV AX,0x244b (0170_09E0 / 0x20E0)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x9E6);
    // MOV DX,0x1ddc (0170_09E3 / 0x20E3)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x9E7);
    // PUSH DX (0170_09E6 / 0x20E6)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x9E8);
    // PUSH AX (0170_09E7 / 0x20E7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x9ED);
    // CALLF 0x1000:c7db (0170_09E8 / 0x20E8)
    FarCall(cs2, 0x9ED, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs2, 0x9F0);
    // ADD SP,0xc (0170_09ED / 0x20ED)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0x9F4);
    // MOV ES,word ptr [0x53a2] (0170_09F0 / 0x20F0)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs2, 0x9FB);
    // MOV word ptr ES:[0xb780],0xc8 (0170_09F4 / 0x20F4)
    UInt16[ES, 0xB780] = 0xC8;
    CheckExternalEvents(cs2, 0x9FE);
    // JMP 0x0000:1e86 (0170_09FB / 0x20FB)
    goto label_0170_0786_01E86;
    label_0170_09FE_020FE:
    CheckExternalEvents(cs2, 0xA03);
    // MOV word ptr [BP + -0x20],0x0 (0170_09FE / 0x20FE)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    CheckExternalEvents(cs2, 0xA05);
    // JMP 0x0000:2139 (0170_0A03 / 0x2103)
    goto label_0170_0A39_02139;
    label_0170_0A05_02105:
    CheckExternalEvents(cs2, 0xA08);
    // PUSH word ptr [BP + -0x1e] (0170_0A05 / 0x2105)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs2, 0xA0B);
    // PUSH word ptr [BP + -0x18] (0170_0A08 / 0x2108)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0xA0E);
    // PUSH word ptr [BP + -0x2] (0170_0A0B / 0x210B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0xA11);
    // PUSH word ptr [BP + -0x4] (0170_0A0E / 0x210E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0xA13);
    // SUB AX,AX (0170_0A11 / 0x2111)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0xA16);
    // MOV DX,0xac00 (0170_0A13 / 0x2113)
    DX = 0xAC00;
    CheckExternalEvents(cs2, 0xA17);
    // PUSH DX (0170_0A16 / 0x2116)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0xA18);
    // PUSH AX (0170_0A17 / 0x2117)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xA1D);
    // CALLF 0x1000:a267 (0170_0A18 / 0x2118)
    FarCall(cs2, 0xA1D, ghidra_guess_1000_A267_1A267);
    CheckExternalEvents(cs2, 0xA20);
    // ADD SP,0xc (0170_0A1D / 0x211D)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    label_0170_0A20_02120:
    CheckExternalEvents(cs2, 0xA24);
    // MOV ES,word ptr [0x53a0] (0170_0A20 / 0x2120)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0xA2A);
    // CMP word ptr ES:[0x4fba],0x0 (0170_0A24 / 0x2124)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0xA2C);
    // JZ 0x0000:2136 (0170_0A2A / 0x212A)
    if(ZeroFlag) {
      goto label_0170_0A36_02136;
    }
    CheckExternalEvents(cs2, 0xA2F);
    // LES BX,[BP + -0x4] (0170_0A2C / 0x212C)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs2, 0xA32);
    // MOV AL,byte ptr [BP + -0x16] (0170_0A2F / 0x212F)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0xA36);
    // ADD byte ptr ES:[BX + 0x1],AL (0170_0A32 / 0x2132)
    UInt8[ES, (ushort)(BX + 0x1)] += AL;
    label_0170_0A36_02136:
    CheckExternalEvents(cs2, 0xA39);
    // INC word ptr [BP + -0x20] (0170_0A36 / 0x2136)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    label_0170_0A39_02139:
    CheckExternalEvents(cs2, 0xA3D);
    // CMP word ptr [BP + -0x20],0x4 (0170_0A39 / 0x2139)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x4);
    CheckExternalEvents(cs2, 0xA3F);
    // JL 0x0000:2142 (0170_0A3D / 0x213D)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0A42_02142;
    }
    CheckExternalEvents(cs2, 0xA42);
    // JMP 0x0000:22c9 (0170_0A3F / 0x213F)
    goto label_0170_0BC9_022C9;
    label_0170_0A42_02142:
    CheckExternalEvents(cs2, 0xA45);
    // MOV AX,0x7d (0170_0A42 / 0x2142)
    AX = 0x7D;
    CheckExternalEvents(cs2, 0xA48);
    // IMUL word ptr [BP + -0x20] (0170_0A45 / 0x2145)
    int resImul0170_0A45 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0170_0A45);
    DX = (ushort)(resImul0170_0A45 >> 16);
    CheckExternalEvents(cs2, 0xA4A);
    // MOV BX,AX (0170_0A48 / 0x2148)
    BX = AX;
    CheckExternalEvents(cs2, 0xA4E);
    // MOV ES,word ptr [0x538a] (0170_0A4A / 0x214A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0xA54);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0170_0A4E / 0x214E)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs2, 0xA56);
    // JZ 0x0000:2136 (0170_0A54 / 0x2154)
    if(ZeroFlag) {
      goto label_0170_0A36_02136;
    }
    CheckExternalEvents(cs2, 0xA59);
    // MOV SI,word ptr [BP + -0x12] (0170_0A56 / 0x2156)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0xA5B);
    // SHL SI,0x1 (0170_0A59 / 0x2159)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0xA5F);
    // MOV AX,word ptr [SI + 0x2ce] (0170_0A5B / 0x215B)
    AX = UInt16[DS, (ushort)(SI + 0x2CE)];
    CheckExternalEvents(cs2, 0xA62);
    // MOV word ptr [BP + -0x18],AX (0170_0A5F / 0x215F)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0xA66);
    // MOV AX,word ptr [SI + 0x2d6] (0170_0A62 / 0x2162)
    AX = UInt16[DS, (ushort)(SI + 0x2D6)];
    CheckExternalEvents(cs2, 0xA69);
    // MOV word ptr [BP + -0x1e],AX (0170_0A66 / 0x2166)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs2, 0xA6D);
    // MOV AX,word ptr [SI + 0x2de] (0170_0A69 / 0x2169)
    AX = UInt16[DS, (ushort)(SI + 0x2DE)];
    CheckExternalEvents(cs2, 0xA71);
    // MOV ES,word ptr [0x5394] (0170_0A6D / 0x216D)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs2, 0xA76);
    // ADD AX,word ptr ES:[0x9ed] (0170_0A71 / 0x2171)
    // AX += UInt16[ES, 0x9ED];
    AX = Alu.Add16(AX, UInt16[ES, 0x9ED]);
    CheckExternalEvents(cs2, 0xA79);
    // MOV word ptr [BP + -0x2c],AX (0170_0A76 / 0x2176)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs2, 0xA7D);
    // MOV ES,word ptr [0x538c] (0170_0A79 / 0x2179)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xA83);
    // TEST byte ptr ES:[0xa44b],0x1 (0170_0A7D / 0x217D)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs2, 0xA85);
    // JZ 0x0000:218c (0170_0A83 / 0x2183)
    if(ZeroFlag) {
      goto label_0170_0A8C_0218C;
    }
    CheckExternalEvents(cs2, 0xA89);
    // MOV AX,word ptr [SI + 0x2ee] (0170_0A85 / 0x2185)
    AX = UInt16[DS, (ushort)(SI + 0x2EE)];
    CheckExternalEvents(cs2, 0xA8C);
    // ADD word ptr [BP + -0x2c],AX (0170_0A89 / 0x2189)
    // UInt16[SS, (ushort)(BP - 0x2C)] += AX;
    UInt16[SS, (ushort)(BP - 0x2C)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x2C)], AX);
    label_0170_0A8C_0218C:
    CheckExternalEvents(cs2, 0xA8F);
    // MOV SI,word ptr [BP + -0x12] (0170_0A8C / 0x218C)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0xA91);
    // SHL SI,0x1 (0170_0A8F / 0x218F)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0xA95);
    // MOV AX,word ptr [SI + 0x2e6] (0170_0A91 / 0x2191)
    AX = UInt16[DS, (ushort)(SI + 0x2E6)];
    CheckExternalEvents(cs2, 0xA98);
    // MOV word ptr [BP + -0x32],AX (0170_0A95 / 0x2195)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs2, 0xA9C);
    // MOV ES,word ptr [0x538e] (0170_0A98 / 0x2198)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xAA2);
    // TEST byte ptr ES:[0xa44d],0x1 (0170_0A9C / 0x219C)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs2, 0xAA4);
    // JZ 0x0000:21af (0170_0AA2 / 0x21A2)
    if(ZeroFlag) {
      goto label_0170_0AAF_021AF;
    }
    CheckExternalEvents(cs2, 0xAA8);
    // MOV AX,word ptr [SI + 0x2f6] (0170_0AA4 / 0x21A4)
    AX = UInt16[DS, (ushort)(SI + 0x2F6)];
    CheckExternalEvents(cs2, 0xAAB);
    // ADD word ptr [BP + -0x2c],AX (0170_0AA8 / 0x21A8)
    UInt16[SS, (ushort)(BP - 0x2C)] += AX;
    CheckExternalEvents(cs2, 0xAAF);
    // XOR byte ptr [BP + -0x32],0x5 (0170_0AAB / 0x21AB)
    UInt8[SS, (ushort)(BP - 0x32)] ^= 0x5;
    label_0170_0AAF_021AF:
    CheckExternalEvents(cs2, 0xAB2);
    // INC word ptr [BP + -0x12] (0170_0AAF / 0x21AF)
    UInt16[SS, (ushort)(BP - 0x12)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs2, 0xAB5);
    // MOV BX,word ptr [BP + -0x20] (0170_0AB2 / 0x21B2)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0xAB9);
    // MOV ES,word ptr [0x539a] (0170_0AB5 / 0x21B5)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0xABE);
    // MOV BL,byte ptr ES:[BX + 0x409a] (0170_0AB9 / 0x21B9)
    BL = UInt8[ES, (ushort)(BX + 0x409A)];
    CheckExternalEvents(cs2, 0xAC0);
    // SUB BH,BH (0170_0ABE / 0x21BE)
    // BH -= BH;
    BH = Alu.Sub8(BH, BH);
    CheckExternalEvents(cs2, 0xAC3);
    // MOV SI,word ptr [BP + -0x20] (0170_0AC0 / 0x21C0)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0xAC7);
    // MOV ES,word ptr [0x539c] (0170_0AC3 / 0x21C3)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs2, 0xACC);
    // MOV AL,byte ptr ES:[SI + 0xd55e] (0170_0AC7 / 0x21C7)
    AL = UInt8[ES, (ushort)(SI + 0xD55E)];
    CheckExternalEvents(cs2, 0xACE);
    // SUB AH,AH (0170_0ACC / 0x21CC)
    AH -= AH;
    CheckExternalEvents(cs2, 0xAD0);
    // ADD BX,AX (0170_0ACE / 0x21CE)
    BX += AX;
    CheckExternalEvents(cs2, 0xAD2);
    // SHL BX,0x1 (0170_0AD0 / 0x21D0)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0xAD4);
    // SHL BX,0x1 (0170_0AD2 / 0x21D2)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0xAD8);
    // MOV ES,word ptr [0x539e] (0170_0AD4 / 0x21D4)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0xADD);
    // MOV AX,word ptr ES:[BX + 0x39fa] (0170_0AD8 / 0x21D8)
    AX = UInt16[ES, (ushort)(BX + 0x39FA)];
    CheckExternalEvents(cs2, 0xAE2);
    // MOV DX,word ptr ES:[BX + 0x39fc] (0170_0ADD / 0x21DD)
    DX = UInt16[ES, (ushort)(BX + 0x39FC)];
    CheckExternalEvents(cs2, 0xAE5);
    // MOV word ptr [BP + -0x4],AX (0170_0AE2 / 0x21E2)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0xAE8);
    // MOV word ptr [BP + -0x2],DX (0170_0AE5 / 0x21E5)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs2, 0xAED);
    // MOV word ptr [BP + -0x16],0x0 (0170_0AE8 / 0x21E8)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs2, 0xAF0);
    // MOV BX,word ptr [BP + -0x2c] (0170_0AED / 0x21ED)
    BX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs2, 0xAF4);
    // MOV ES,word ptr [0x5396] (0170_0AF0 / 0x21F0)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs2, 0xAF9);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0170_0AF4 / 0x21F4)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs2, 0xAFB);
    // SUB AH,AH (0170_0AF9 / 0x21F9)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs2, 0xAFE);
    // MOV word ptr [BP + -0x28],AX (0170_0AFB / 0x21FB)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs2, 0xB02);
    // MOV ES,word ptr [0x538a] (0170_0AFE / 0x21FE)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0xB07);
    // CMP byte ptr ES:[0xd346],AH (0170_0B02 / 0x2202)
    Alu.Sub8(UInt8[ES, 0xD346], AH);
    CheckExternalEvents(cs2, 0xB09);
    // JNZ 0x0000:2240 (0170_0B07 / 0x2207)
    if(!ZeroFlag) {
      goto label_0170_0B40_02240;
    }
    CheckExternalEvents(cs2, 0xB0C);
    // CMP AX,0xf6 (0170_0B09 / 0x2209)
    Alu.Sub16(AX, 0xF6);
    CheckExternalEvents(cs2, 0xB0E);
    // JGE 0x0000:2240 (0170_0B0C / 0x220C)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0B40_02240;
    }
    CheckExternalEvents(cs2, 0xB11);
    // MOV AX,word ptr [BP + -0x32] (0170_0B0E / 0x220E)
    AX = UInt16[SS, (ushort)(BP - 0x32)];
    CheckExternalEvents(cs2, 0xB14);
    // TEST word ptr [BP + -0x28],AX (0170_0B11 / 0x2211)
    Alu.And16(UInt16[SS, (ushort)(BP - 0x28)], AX);
    CheckExternalEvents(cs2, 0xB16);
    // JZ 0x0000:2240 (0170_0B14 / 0x2214)
    if(ZeroFlag) {
      goto label_0170_0B40_02240;
    }
    CheckExternalEvents(cs2, 0xB19);
    // MOV AX,word ptr [BP + -0x28] (0170_0B16 / 0x2216)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs2, 0xB1C);
    // AND AX,0xf0 (0170_0B19 / 0x2219)
    // AX &= 0xF0;
    AX = Alu.And16(AX, 0xF0);
    CheckExternalEvents(cs2, 0xB1F);
    // MOV word ptr [BP + -0xa],AX (0170_0B1C / 0x221C)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs2, 0xB22);
    // CMP AX,0x30 (0170_0B1F / 0x221F)
    Alu.Sub16(AX, 0x30);
    CheckExternalEvents(cs2, 0xB24);
    // JGE 0x0000:2240 (0170_0B22 / 0x2222)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0B40_02240;
    }
    CheckExternalEvents(cs2, 0xB29);
    // MOV word ptr [BP + -0x16],0x8 (0170_0B24 / 0x2224)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x8;
    CheckExternalEvents(cs2, 0xB2C);
    // CMP AX,0x20 (0170_0B29 / 0x2229)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs2, 0xB2E);
    // JZ 0x0000:2232 (0170_0B2C / 0x222C)
    if(ZeroFlag) {
      goto label_0170_0B32_02232;
    }
    CheckExternalEvents(cs2, 0xB30);
    // OR AX,AX (0170_0B2E / 0x222E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0xB32);
    // JNZ 0x0000:2240 (0170_0B30 / 0x2230)
    if(!ZeroFlag) {
      goto label_0170_0B40_02240;
    }
    label_0170_0B32_02232:
    CheckExternalEvents(cs2, 0xB35);
    // MOV AL,byte ptr [BP + -0x28] (0170_0B32 / 0x2232)
    AL = UInt8[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs2, 0xB37);
    // AND AL,0xf (0170_0B35 / 0x2235)
    AL &= 0xF;
    CheckExternalEvents(cs2, 0xB39);
    // CMP AL,0xf (0170_0B37 / 0x2237)
    Alu.Sub8(AL, 0xF);
    CheckExternalEvents(cs2, 0xB3B);
    // JNZ 0x0000:2240 (0170_0B39 / 0x2239)
    if(!ZeroFlag) {
      goto label_0170_0B40_02240;
    }
    CheckExternalEvents(cs2, 0xB40);
    // MOV word ptr [BP + -0x16],0x10 (0170_0B3B / 0x223B)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x10;
    label_0170_0B40_02240:
    CheckExternalEvents(cs2, 0xB43);
    // MOV AL,byte ptr [BP + -0x16] (0170_0B40 / 0x2240)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0xB46);
    // MOV BX,word ptr [BP + -0x20] (0170_0B43 / 0x2243)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0xB4A);
    // MOV ES,word ptr [0x5398] (0170_0B46 / 0x2246)
    ES = UInt16[DS, 0x5398];
    CheckExternalEvents(cs2, 0xB4F);
    // MOV byte ptr ES:[BX + 0x32ae],AL (0170_0B4A / 0x224A)
    UInt8[ES, (ushort)(BX + 0x32AE)] = AL;
    CheckExternalEvents(cs2, 0xB53);
    // MOV ES,word ptr [0x53a0] (0170_0B4F / 0x224F)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0xB59);
    // CMP word ptr ES:[0x4fba],0x0 (0170_0B53 / 0x2253)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0xB5B);
    // JZ 0x0000:2265 (0170_0B59 / 0x2259)
    if(ZeroFlag) {
      goto label_0170_0B65_02265;
    }
    CheckExternalEvents(cs2, 0xB5E);
    // LES BX,[BP + -0x4] (0170_0B5B / 0x225B)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs2, 0xB61);
    // MOV AL,byte ptr [BP + -0x16] (0170_0B5E / 0x225E)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0xB65);
    // SUB byte ptr ES:[BX + 0x1],AL (0170_0B61 / 0x2261)
    // UInt8[ES, (ushort)(BX + 0x1)] -= AL;
    UInt8[ES, (ushort)(BX + 0x1)] = Alu.Sub8(UInt8[ES, (ushort)(BX + 0x1)], AL);
    label_0170_0B65_02265:
    CheckExternalEvents(cs2, 0xB69);
    // MOV ES,word ptr [0x53a0] (0170_0B65 / 0x2265)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0xB6F);
    // CMP word ptr ES:[0x4fba],0x2 (0170_0B69 / 0x2269)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0xB71);
    // JNZ 0x0000:2274 (0170_0B6F / 0x226F)
    if(!ZeroFlag) {
      goto label_0170_0B74_02274;
    }
    CheckExternalEvents(cs2, 0xB74);
    // JMP 0x0000:2105 (0170_0B71 / 0x2271)
    goto label_0170_0A05_02105;
    label_0170_0B74_02274:
    CheckExternalEvents(cs2, 0xB7A);
    // CMP word ptr ES:[0x4fba],0x0 (0170_0B74 / 0x2274)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0xB7C);
    // JNZ 0x0000:229f (0170_0B7A / 0x227A)
    if(!ZeroFlag) {
      goto label_0170_0B9F_0229F;
    }
    CheckExternalEvents(cs2, 0xB80);
    // CMP word ptr [BP + -0x16],0x0 (0170_0B7C / 0x227C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x0);
    CheckExternalEvents(cs2, 0xB82);
    // JZ 0x0000:229f (0170_0B80 / 0x2280)
    if(ZeroFlag) {
      goto label_0170_0B9F_0229F;
    }
    CheckExternalEvents(cs2, 0xB86);
    // MOV ES,word ptr [0x53a2] (0170_0B82 / 0x2282)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs2, 0xB89);
    // MOV AX,word ptr [BP + -0x1e] (0170_0B86 / 0x2286)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0xB8C);
    // SUB AX,word ptr [BP + -0x16] (0170_0B89 / 0x2289)
    AX -= UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0xB8F);
    // ADD AX,0x18 (0170_0B8C / 0x228C)
    // AX += 0x18;
    AX = Alu.Add16(AX, 0x18);
    CheckExternalEvents(cs2, 0xB93);
    // MOV ES:[0xb780],AX (0170_0B8F / 0x228F)
    UInt16[ES, 0xB780] = AX;
    CheckExternalEvents(cs2, 0xB96);
    // CMP AX,0xc8 (0170_0B93 / 0x2293)
    Alu.Sub16(AX, 0xC8);
    CheckExternalEvents(cs2, 0xB98);
    // JLE 0x0000:229f (0170_0B96 / 0x2296)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_0B9F_0229F;
    }
    CheckExternalEvents(cs2, 0xB9F);
    // MOV word ptr ES:[0xb780],0xc8 (0170_0B98 / 0x2298)
    UInt16[ES, 0xB780] = 0xC8;
    label_0170_0B9F_0229F:
    CheckExternalEvents(cs2, 0xBA2);
    // PUSH word ptr [BP + -0x1e] (0170_0B9F / 0x229F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs2, 0xBA5);
    // PUSH word ptr [BP + -0x18] (0170_0BA2 / 0x22A2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0xBA8);
    // PUSH word ptr [BP + -0x2] (0170_0BA5 / 0x22A5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0xBAB);
    // PUSH word ptr [BP + -0x4] (0170_0BA8 / 0x22A8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0xBAE);
    // MOV AX,0x244b (0170_0BAB / 0x22AB)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0xBB1);
    // MOV DX,0x1ddc (0170_0BAE / 0x22AE)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0xBB2);
    // PUSH DX (0170_0BB1 / 0x22B1)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0xBB3);
    // PUSH AX (0170_0BB2 / 0x22B2)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xBB8);
    // CALLF 0x1000:c7db (0170_0BB3 / 0x22B3)
    FarCall(cs2, 0xBB8, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs2, 0xBBB);
    // ADD SP,0xc (0170_0BB8 / 0x22B8)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0xBBF);
    // MOV ES,word ptr [0x53a2] (0170_0BBB / 0x22BB)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs2, 0xBC6);
    // MOV word ptr ES:[0xb780],0xc8 (0170_0BBF / 0x22BF)
    UInt16[ES, 0xB780] = 0xC8;
    CheckExternalEvents(cs2, 0xBC9);
    // JMP 0x0000:2120 (0170_0BC6 / 0x22C6)
    goto label_0170_0A20_02120;
    label_0170_0BC9_022C9:
    CheckExternalEvents(cs2, 0xBCD);
    // MOV ES,word ptr [0x538c] (0170_0BC9 / 0x22C9)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xBD1);
    // MOV AX,ES:[0xa44b] (0170_0BCD / 0x22CD)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0xBD4);
    // MOV word ptr [BP + -0x1c],AX (0170_0BD1 / 0x22D1)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs2, 0xBD8);
    // MOV ES,word ptr [0x538e] (0170_0BD4 / 0x22D4)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xBDC);
    // MOV AX,ES:[0xa44d] (0170_0BD8 / 0x22D8)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0xBDF);
    // MOV word ptr [BP + -0x24],AX (0170_0BDC / 0x22DC)
    UInt16[SS, (ushort)(BP - 0x24)] = AX;
    CheckExternalEvents(cs2, 0xBE1);
    // SUB AX,AX (0170_0BDF / 0x22DF)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0xBE4);
    // MOV word ptr [BP + -0x12],AX (0170_0BE1 / 0x22E1)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs2, 0xBE7);
    // MOV word ptr [BP + -0xe],AX (0170_0BE4 / 0x22E4)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs2, 0xBEA);
    // MOV word ptr [BP + -0x20],AX (0170_0BE7 / 0x22E7)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    label_0170_0BEA_022EA:
    CheckExternalEvents(cs2, 0xBED);
    // MOV AX,0x11 (0170_0BEA / 0x22EA)
    AX = 0x11;
    CheckExternalEvents(cs2, 0xBF0);
    // IMUL word ptr [BP + -0x20] (0170_0BED / 0x22ED)
    int resImul0170_0BED = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0170_0BED);
    DX = (ushort)(resImul0170_0BED >> 16);
    CheckExternalEvents(cs2, 0xBF2);
    // MOV SI,AX (0170_0BF0 / 0x22F0)
    SI = AX;
    CheckExternalEvents(cs2, 0xBF6);
    // MOV ES,word ptr [0x538a] (0170_0BF2 / 0x22F2)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0xBFC);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0170_0BF6 / 0x22F6)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs2, 0xBFE);
    // JZ 0x0000:2371 (0170_0BFC / 0x22FC)
    if(ZeroFlag) {
      goto label_0170_0C71_02371;
    }
    CheckExternalEvents(cs2, 0xC04);
    // CMP byte ptr ES:[SI + 0xc620],0x8 (0170_0BFE / 0x22FE)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC620)], 0x8);
    CheckExternalEvents(cs2, 0xC06);
    // JL 0x0000:2371 (0170_0C04 / 0x2304)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0C71_02371;
    }
    CheckExternalEvents(cs2, 0xC09);
    // MOV BX,word ptr [BP + -0xe] (0170_0C06 / 0x2306)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs2, 0xC0D);
    // MOV ES,word ptr [0x53a8] (0170_0C09 / 0x2309)
    ES = UInt16[DS, 0x53A8];
    CheckExternalEvents(cs2, 0xC12);
    // MOV AL,byte ptr ES:[BX + 0x3a1e] (0170_0C0D / 0x230D)
    AL = UInt8[ES, (ushort)(BX + 0x3A1E)];
    CheckExternalEvents(cs2, 0xC13);
    // CBW  (0170_0C12 / 0x2312)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0xC14);
    // PUSH AX (0170_0C13 / 0x2313)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xC18);
    // MOV ES,word ptr [0x53aa] (0170_0C14 / 0x2314)
    ES = UInt16[DS, 0x53AA];
    CheckExternalEvents(cs2, 0xC1D);
    // MOV AL,byte ptr ES:[BX + 0x3a16] (0170_0C18 / 0x2318)
    AL = UInt8[ES, (ushort)(BX + 0x3A16)];
    CheckExternalEvents(cs2, 0xC1E);
    // CBW  (0170_0C1D / 0x231D)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0xC1F);
    // PUSH AX (0170_0C1E / 0x231E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xC20);
    // PUSH CS (0170_0C1F / 0x231F)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0xC23);
    // CALL 0x0000:301b (0170_0C20 / 0x2320)
    NearCall(cs2, 0xC23, unknown_0170_191B_0301B);
    CheckExternalEvents(cs2, 0xC26);
    // ADD SP,0x4 (0170_0C23 / 0x2323)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0xC29);
    // MOV SI,word ptr [BP + -0xe] (0170_0C26 / 0x2326)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs2, 0xC2B);
    // SHL SI,0x1 (0170_0C29 / 0x2329)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0xC2F);
    // MOV ES,word ptr [0x538c] (0170_0C2B / 0x232B)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xC33);
    // MOV AX,ES:[0xa44b] (0170_0C2F / 0x232F)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0xC37);
    // MOV ES,word ptr [0x53a4] (0170_0C33 / 0x2333)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0xC3C);
    // MOV word ptr ES:[SI + 0x400c],AX (0170_0C37 / 0x2337)
    UInt16[ES, (ushort)(SI + 0x400C)] = AX;
    CheckExternalEvents(cs2, 0xC40);
    // MOV ES,word ptr [0x538e] (0170_0C3C / 0x233C)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xC44);
    // MOV AX,ES:[0xa44d] (0170_0C40 / 0x2340)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0xC48);
    // MOV ES,word ptr [0x53a6] (0170_0C44 / 0x2344)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0xC4D);
    // MOV word ptr ES:[SI + 0x403e],AX (0170_0C48 / 0x2348)
    UInt16[ES, (ushort)(SI + 0x403E)] = AX;
    CheckExternalEvents(cs2, 0xC51);
    // MOV ES,word ptr [0x5392] (0170_0C4D / 0x234D)
    ES = UInt16[DS, 0x5392];
    CheckExternalEvents(cs2, 0xC58);
    // MOV word ptr ES:[SI + 0x4072],0x1 (0170_0C51 / 0x2351)
    UInt16[ES, (ushort)(SI + 0x4072)] = 0x1;
    CheckExternalEvents(cs2, 0xC5C);
    // MOV ES,word ptr [0x538c] (0170_0C58 / 0x2358)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xC5F);
    // MOV AX,word ptr [BP + -0x1c] (0170_0C5C / 0x235C)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs2, 0xC63);
    // MOV ES:[0xa44b],AX (0170_0C5F / 0x235F)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0xC67);
    // MOV ES,word ptr [0x538e] (0170_0C63 / 0x2363)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xC6A);
    // MOV AX,word ptr [BP + -0x24] (0170_0C67 / 0x2367)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs2, 0xC6E);
    // MOV ES:[0xa44d],AX (0170_0C6A / 0x236A)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs2, 0xC71);
    // INC word ptr [BP + -0xe] (0170_0C6E / 0x236E)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0170_0C71_02371:
    CheckExternalEvents(cs2, 0xC74);
    // INC word ptr [BP + -0x20] (0170_0C71 / 0x2371)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs2, 0xC78);
    // CMP word ptr [BP + -0x20],0x8 (0170_0C74 / 0x2374)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x8);
    CheckExternalEvents(cs2, 0xC7A);
    // JGE 0x0000:237d (0170_0C78 / 0x2378)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0C7D_0237D;
    }
    CheckExternalEvents(cs2, 0xC7D);
    // JMP 0x0000:22ea (0170_0C7A / 0x237A)
    goto label_0170_0BEA_022EA;
    label_0170_0C7D_0237D:
    CheckExternalEvents(cs2, 0xC81);
    // MOV ES,word ptr [0x538c] (0170_0C7D / 0x237D)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xC84);
    // MOV AX,word ptr [BP + -0x1c] (0170_0C81 / 0x2381)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs2, 0xC88);
    // MOV ES:[0xa44b],AX (0170_0C84 / 0x2384)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0xC8C);
    // MOV ES,word ptr [0x538e] (0170_0C88 / 0x2388)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xC8F);
    // MOV AX,word ptr [BP + -0x24] (0170_0C8C / 0x238C)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs2, 0xC93);
    // MOV ES:[0xa44d],AX (0170_0C8F / 0x238F)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs2, 0xC98);
    // MOV word ptr [BP + -0x20],0x0 (0170_0C93 / 0x2393)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    label_0170_0C98_02398:
    CheckExternalEvents(cs2, 0xC9B);
    // MOV AX,0x7d (0170_0C98 / 0x2398)
    AX = 0x7D;
    CheckExternalEvents(cs2, 0xC9E);
    // IMUL word ptr [BP + -0x20] (0170_0C9B / 0x239B)
    int resImul0170_0C9B = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0170_0C9B);
    DX = (ushort)(resImul0170_0C9B >> 16);
    CheckExternalEvents(cs2, 0xCA0);
    // MOV BX,AX (0170_0C9E / 0x239E)
    BX = AX;
    CheckExternalEvents(cs2, 0xCA4);
    // MOV ES,word ptr [0x538a] (0170_0CA0 / 0x23A0)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0xCAA);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0170_0CA4 / 0x23A4)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs2, 0xCAC);
    // JZ 0x0000:2424 (0170_0CAA / 0x23AA)
    if(ZeroFlag) {
      goto label_0170_0D24_02424;
    }
    CheckExternalEvents(cs2, 0xCAF);
    // MOV BX,word ptr [BP + -0x12] (0170_0CAC / 0x23AC)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0xCB3);
    // MOV ES,word ptr [0x53ac] (0170_0CAF / 0x23AF)
    ES = UInt16[DS, 0x53AC];
    CheckExternalEvents(cs2, 0xCB8);
    // MOV AL,byte ptr ES:[BX + 0x3a26] (0170_0CB3 / 0x23B3)
    AL = UInt8[ES, (ushort)(BX + 0x3A26)];
    CheckExternalEvents(cs2, 0xCB9);
    // CBW  (0170_0CB8 / 0x23B8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0xCBC);
    // MOV word ptr [BP + -0x18],AX (0170_0CB9 / 0x23B9)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0xCC0);
    // MOV ES,word ptr [0x53ae] (0170_0CBC / 0x23BC)
    ES = UInt16[DS, 0x53AE];
    CheckExternalEvents(cs2, 0xCC5);
    // MOV AL,byte ptr ES:[BX + 0x3a2a] (0170_0CC0 / 0x23C0)
    AL = UInt8[ES, (ushort)(BX + 0x3A2A)];
    CheckExternalEvents(cs2, 0xCC6);
    // CBW  (0170_0CC5 / 0x23C5)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0xCC9);
    // MOV word ptr [BP + -0x1e],AX (0170_0CC6 / 0x23C6)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs2, 0xCCA);
    // PUSH AX (0170_0CC9 / 0x23C9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xCCD);
    // PUSH word ptr [BP + -0x18] (0170_0CCA / 0x23CA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs2, 0xCCE);
    // PUSH CS (0170_0CCD / 0x23CD)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0xCD1);
    // CALL 0x0000:301b (0170_0CCE / 0x23CE)
    NearCall(cs2, 0xCD1, unknown_0170_191B_0301B);
    CheckExternalEvents(cs2, 0xCD4);
    // ADD SP,0x4 (0170_0CD1 / 0x23D1)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0xCD7);
    // MOV SI,word ptr [BP + -0x12] (0170_0CD4 / 0x23D4)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0xCD9);
    // SHL SI,0x1 (0170_0CD7 / 0x23D7)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0xCDD);
    // MOV ES,word ptr [0x538c] (0170_0CD9 / 0x23D9)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xCE1);
    // MOV AX,ES:[0xa44b] (0170_0CDD / 0x23DD)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0xCE5);
    // MOV ES,word ptr [0x53a4] (0170_0CE1 / 0x23E1)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0xCEA);
    // MOV word ptr ES:[SI + 0x4004],AX (0170_0CE5 / 0x23E5)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs2, 0xCEE);
    // MOV ES,word ptr [0x538e] (0170_0CEA / 0x23EA)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xCF2);
    // MOV AX,ES:[0xa44d] (0170_0CEE / 0x23EE)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0xCF6);
    // MOV ES,word ptr [0x53a6] (0170_0CF2 / 0x23F2)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0xCFB);
    // MOV word ptr ES:[SI + 0x4036],AX (0170_0CF6 / 0x23F6)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs2, 0xCFE);
    // MOV BX,word ptr [BP + -0x12] (0170_0CFB / 0x23FB)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0xD01);
    // INC word ptr [BP + -0x12] (0170_0CFE / 0x23FE)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    CheckExternalEvents(cs2, 0xD03);
    // SHL BX,0x1 (0170_0D01 / 0x2401)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0xD07);
    // MOV ES,word ptr [0x5392] (0170_0D03 / 0x2403)
    ES = UInt16[DS, 0x5392];
    CheckExternalEvents(cs2, 0xD0E);
    // MOV word ptr ES:[BX + 0x406a],0x1 (0170_0D07 / 0x2407)
    UInt16[ES, (ushort)(BX + 0x406A)] = 0x1;
    CheckExternalEvents(cs2, 0xD12);
    // MOV ES,word ptr [0x538c] (0170_0D0E / 0x240E)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xD15);
    // MOV AX,word ptr [BP + -0x1c] (0170_0D12 / 0x2412)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs2, 0xD19);
    // MOV ES:[0xa44b],AX (0170_0D15 / 0x2415)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0xD1D);
    // MOV ES,word ptr [0x538e] (0170_0D19 / 0x2419)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xD20);
    // MOV AX,word ptr [BP + -0x24] (0170_0D1D / 0x241D)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs2, 0xD24);
    // MOV ES:[0xa44d],AX (0170_0D20 / 0x2420)
    UInt16[ES, 0xA44D] = AX;
    label_0170_0D24_02424:
    CheckExternalEvents(cs2, 0xD27);
    // INC word ptr [BP + -0x20] (0170_0D24 / 0x2424)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs2, 0xD2B);
    // CMP word ptr [BP + -0x20],0x4 (0170_0D27 / 0x2427)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x4);
    CheckExternalEvents(cs2, 0xD2D);
    // JGE 0x0000:2430 (0170_0D2B / 0x242B)
    if(SignFlag == OverflowFlag) {
      goto label_0170_0D30_02430;
    }
    CheckExternalEvents(cs2, 0xD30);
    // JMP 0x0000:2398 (0170_0D2D / 0x242D)
    goto label_0170_0C98_02398;
    label_0170_0D30_02430:
    CheckExternalEvents(cs2, 0xD34);
    // MOV ES,word ptr [0x53b0] (0170_0D30 / 0x2430)
    ES = UInt16[DS, 0x53B0];
    CheckExternalEvents(cs2, 0xD3A);
    // CMP word ptr ES:[0x398e],0x0 (0170_0D34 / 0x2434)
    Alu.Sub16(UInt16[ES, 0x398E], 0x0);
    CheckExternalEvents(cs2, 0xD3C);
    // JNZ 0x0000:243f (0170_0D3A / 0x243A)
    if(!ZeroFlag) {
      goto label_0170_0D3F_0243F;
    }
    CheckExternalEvents(cs2, 0xD3F);
    // JMP 0x0000:2546 (0170_0D3C / 0x243C)
    goto label_0170_0E46_02546;
    label_0170_0D3F_0243F:
    CheckExternalEvents(cs2, 0xD44);
    // MOV word ptr [BP + -0x20],0x0 (0170_0D3F / 0x243F)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    CheckExternalEvents(cs2, 0xD46);
    // JMP 0x0000:2474 (0170_0D44 / 0x2444)
    goto label_0170_0D74_02474;
    label_0170_0D46_02446:
    CheckExternalEvents(cs2, 0xD49);
    // MOV AX,word ptr [BP + -0x1e] (0170_0D46 / 0x2446)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0xD4B);
    // MOV CL,0x3 (0170_0D49 / 0x2449)
    CL = 0x3;
    CheckExternalEvents(cs2, 0xD4D);
    // SHL AX,CL (0170_0D4B / 0x244B)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs2, 0xD4E);
    // PUSH AX (0170_0D4D / 0x244D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xD51);
    // MOV AX,word ptr [BP + -0x18] (0170_0D4E / 0x244E)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs2, 0xD53);
    // SHL AX,CL (0170_0D51 / 0x2451)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs2, 0xD54);
    // PUSH AX (0170_0D53 / 0x2453)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xD58);
    // MOV ES,word ptr [0x539e] (0170_0D54 / 0x2454)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0xD5D);
    // PUSH word ptr ES:[0x3c44] (0170_0D58 / 0x2458)
    Stack.Push16(UInt16[ES, 0x3C44]);
    CheckExternalEvents(cs2, 0xD62);
    // PUSH word ptr ES:[0x3c42] (0170_0D5D / 0x245D)
    Stack.Push16(UInt16[ES, 0x3C42]);
    CheckExternalEvents(cs2, 0xD64);
    // SUB AX,AX (0170_0D62 / 0x2462)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0xD67);
    // MOV DX,0xac00 (0170_0D64 / 0x2464)
    DX = 0xAC00;
    CheckExternalEvents(cs2, 0xD68);
    // PUSH DX (0170_0D67 / 0x2467)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0xD69);
    // PUSH AX (0170_0D68 / 0x2468)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xD6E);
    // CALLF 0x1000:a267 (0170_0D69 / 0x2469)
    FarCall(cs2, 0xD6E, ghidra_guess_1000_A267_1A267);
    label_0170_0D6E_0246E:
    CheckExternalEvents(cs2, 0xD71);
    // ADD SP,0xc (0170_0D6E / 0x246E)
    SP += 0xC;
    label_0170_0D71_02471:
    CheckExternalEvents(cs2, 0xD74);
    // INC word ptr [BP + -0x20] (0170_0D71 / 0x2471)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    label_0170_0D74_02474:
    CheckExternalEvents(cs2, 0xD78);
    // CMP word ptr [BP + -0x20],0x4 (0170_0D74 / 0x2474)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x4);
    CheckExternalEvents(cs2, 0xD7A);
    // JL 0x0000:247d (0170_0D78 / 0x2478)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0D7D_0247D;
    }
    CheckExternalEvents(cs2, 0xD7D);
    // JMP 0x0000:2546 (0170_0D7A / 0x247A)
    goto label_0170_0E46_02546;
    label_0170_0D7D_0247D:
    CheckExternalEvents(cs2, 0xD80);
    // MOV AX,word ptr [BP + -0x20] (0170_0D7D / 0x247D)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs2, 0xD82);
    // SHL AX,0x1 (0170_0D80 / 0x2480)
    AX <<= 0x1;
    CheckExternalEvents(cs2, 0xD84);
    // SHL AX,0x1 (0170_0D82 / 0x2482)
    AX <<= 0x1;
    CheckExternalEvents(cs2, 0xD87);
    // ADD AX,0xd13 (0170_0D84 / 0x2484)
    // AX += 0xD13;
    AX = Alu.Add16(AX, 0xD13);
    CheckExternalEvents(cs2, 0xD8A);
    // MOV word ptr [BP + -0x18],AX (0170_0D87 / 0x2487)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0xD8F);
    // MOV word ptr [BP + -0x1e],0x702c (0170_0D8A / 0x248A)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x702C;
    CheckExternalEvents(cs2, 0xD93);
    // MOV ES,word ptr [0x538c] (0170_0D8F / 0x248F)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0xD98);
    // SUB AX,word ptr ES:[0xa44b] (0170_0D93 / 0x2493)
    AX -= UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0xD9B);
    // ADD AX,0x1a (0170_0D98 / 0x2498)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs2, 0xD9E);
    // MOV word ptr [BP + -0x18],AX (0170_0D9B / 0x249B)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0xDA1);
    // MOV AX,0x702c (0170_0D9E / 0x249E)
    AX = 0x702C;
    CheckExternalEvents(cs2, 0xDA5);
    // MOV ES,word ptr [0x538e] (0170_0DA1 / 0x24A1)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0xDAA);
    // SUB AX,word ptr ES:[0xa44d] (0170_0DA5 / 0x24A5)
    AX -= UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0xDAD);
    // ADD AX,0xc (0170_0DAA / 0x24AA)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs2, 0xDB0);
    // MOV word ptr [BP + -0x1e],AX (0170_0DAD / 0x24AD)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs2, 0xDB2);
    // SUB AX,AX (0170_0DB0 / 0x24B0)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0xDB5);
    // MOV word ptr [BP + -0x26],AX (0170_0DB2 / 0x24B2)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs2, 0xDB8);
    // MOV word ptr [BP + -0x22],AX (0170_0DB5 / 0x24B5)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs2, 0xDBC);
    // CMP word ptr [BP + -0x18],0xd (0170_0DB8 / 0x24B8)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xD);
    CheckExternalEvents(cs2, 0xDBE);
    // JL 0x0000:24c4 (0170_0DBC / 0x24BC)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0DC4_024C4;
    }
    CheckExternalEvents(cs2, 0xDC2);
    // CMP word ptr [BP + -0x18],0x27 (0170_0DBE / 0x24BE)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0x27);
    CheckExternalEvents(cs2, 0xDC4);
    // JLE 0x0000:24c9 (0170_0DC2 / 0x24C2)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_0DC9_024C9;
    }
    label_0170_0DC4_024C4:
    CheckExternalEvents(cs2, 0xDC9);
    // MOV word ptr [BP + -0x22],0x1 (0170_0DC4 / 0x24C4)
    UInt16[SS, (ushort)(BP - 0x22)] = 0x1;
    label_0170_0DC9_024C9:
    CheckExternalEvents(cs2, 0xDCD);
    // CMP word ptr [BP + -0x1e],0x0 (0170_0DC9 / 0x24C9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0x0);
    CheckExternalEvents(cs2, 0xDCF);
    // JL 0x0000:24d5 (0170_0DCD / 0x24CD)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0DD5_024D5;
    }
    CheckExternalEvents(cs2, 0xDD3);
    // CMP word ptr [BP + -0x1e],0x18 (0170_0DCF / 0x24CF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0x18);
    CheckExternalEvents(cs2, 0xDD5);
    // JLE 0x0000:24da (0170_0DD3 / 0x24D3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_0DDA_024DA;
    }
    label_0170_0DD5_024D5:
    CheckExternalEvents(cs2, 0xDDA);
    // MOV word ptr [BP + -0x26],0x1 (0170_0DD5 / 0x24D5)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x1;
    label_0170_0DDA_024DA:
    CheckExternalEvents(cs2, 0xDDE);
    // CMP word ptr [BP + -0x18],-0x73 (0170_0DDA / 0x24DA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xFF8D);
    CheckExternalEvents(cs2, 0xDE0);
    // JL 0x0000:2471 (0170_0DDE / 0x24DE)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0D71_02471;
    }
    CheckExternalEvents(cs2, 0xDE5);
    // CMP word ptr [BP + -0x18],0xa7 (0170_0DE0 / 0x24E0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xA7);
    CheckExternalEvents(cs2, 0xDE7);
    // JG 0x0000:2471 (0170_0DE5 / 0x24E5)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_0D71_02471;
    }
    CheckExternalEvents(cs2, 0xDEC);
    // CMP word ptr [BP + -0x1e],0xf080 (0170_0DE7 / 0x24E7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0xF080);
    CheckExternalEvents(cs2, 0xDEE);
    // JL 0x0000:2471 (0170_0DEC / 0x24EC)
    if(SignFlag != OverflowFlag) {
      goto label_0170_0D71_02471;
    }
    CheckExternalEvents(cs2, 0xDF3);
    // CMP word ptr [BP + -0x1e],0xf98 (0170_0DEE / 0x24EE)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1E)], 0xF98);
    CheckExternalEvents(cs2, 0xDF5);
    // JLE 0x0000:24f8 (0170_0DF3 / 0x24F3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_0DF8_024F8;
    }
    CheckExternalEvents(cs2, 0xDF8);
    // JMP 0x0000:2471 (0170_0DF5 / 0x24F5)
    goto label_0170_0D71_02471;
    label_0170_0DF8_024F8:
    CheckExternalEvents(cs2, 0xDFB);
    // MOV AX,word ptr [BP + -0x22] (0170_0DF8 / 0x24F8)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs2, 0xDFE);
    // ADD AX,word ptr [BP + -0x26] (0170_0DFB / 0x24FB)
    // AX += UInt16[SS, (ushort)(BP - 0x26)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs2, 0xE00);
    // JZ 0x0000:2503 (0170_0DFE / 0x24FE)
    if(ZeroFlag) {
      goto label_0170_0E03_02503;
    }
    CheckExternalEvents(cs2, 0xE03);
    // JMP 0x0000:2471 (0170_0E00 / 0x2500)
    goto label_0170_0D71_02471;
    label_0170_0E03_02503:
    CheckExternalEvents(cs2, 0xE07);
    // AND word ptr [BP + -0x18],0x7f (0170_0E03 / 0x2503)
    UInt16[SS, (ushort)(BP - 0x18)] &= 0x7F;
    CheckExternalEvents(cs2, 0xE0B);
    // AND word ptr [BP + -0x1e],0x7f (0170_0E07 / 0x2507)
    // UInt16[SS, (ushort)(BP - 0x1E)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x1E)], 0x7F);
    CheckExternalEvents(cs2, 0xE0F);
    // MOV ES,word ptr [0x53a0] (0170_0E0B / 0x250B)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0xE15);
    // CMP word ptr ES:[0x4fba],0x2 (0170_0E0F / 0x250F)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0xE17);
    // JNZ 0x0000:251a (0170_0E15 / 0x2515)
    if(!ZeroFlag) {
      goto label_0170_0E1A_0251A;
    }
    CheckExternalEvents(cs2, 0xE1A);
    // JMP 0x0000:2446 (0170_0E17 / 0x2517)
    goto label_0170_0D46_02446;
    label_0170_0E1A_0251A:
    CheckExternalEvents(cs2, 0xE1D);
    // MOV AX,word ptr [BP + -0x1e] (0170_0E1A / 0x251A)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs2, 0xE1F);
    // MOV CL,0x3 (0170_0E1D / 0x251D)
    CL = 0x3;
    CheckExternalEvents(cs2, 0xE21);
    // SHL AX,CL (0170_0E1F / 0x251F)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs2, 0xE22);
    // PUSH AX (0170_0E21 / 0x2521)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xE25);
    // MOV AX,word ptr [BP + -0x18] (0170_0E22 / 0x2522)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs2, 0xE27);
    // SHL AX,CL (0170_0E25 / 0x2525)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs2, 0xE28);
    // PUSH AX (0170_0E27 / 0x2527)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xE2C);
    // MOV ES,word ptr [0x539e] (0170_0E28 / 0x2528)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0xE31);
    // PUSH word ptr ES:[0x3c44] (0170_0E2C / 0x252C)
    Stack.Push16(UInt16[ES, 0x3C44]);
    CheckExternalEvents(cs2, 0xE36);
    // PUSH word ptr ES:[0x3c42] (0170_0E31 / 0x2531)
    Stack.Push16(UInt16[ES, 0x3C42]);
    CheckExternalEvents(cs2, 0xE39);
    // MOV AX,0x244b (0170_0E36 / 0x2536)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0xE3C);
    // MOV DX,0x1ddc (0170_0E39 / 0x2539)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0xE3D);
    // PUSH DX (0170_0E3C / 0x253C)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0xE3E);
    // PUSH AX (0170_0E3D / 0x253D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0xE43);
    // CALLF 0x1000:c7db (0170_0E3E / 0x253E)
    FarCall(cs2, 0xE43, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs2, 0xE46);
    // JMP 0x0000:246e (0170_0E43 / 0x2543)
    goto label_0170_0D6E_0246E;
    label_0170_0E46_02546:
    CheckExternalEvents(cs2, 0xE47);
    // POP SI (0170_0E46 / 0x2546)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0xE49);
    // MOV SP,BP (0170_0E47 / 0x2547)
    SP = BP;
    CheckExternalEvents(cs2, 0xE4A);
    // POP BP (0170_0E49 / 0x2549)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0xE4B);
    // RETF  (0170_0E4A / 0x254A)
    return FarRet();
  }
  
}
