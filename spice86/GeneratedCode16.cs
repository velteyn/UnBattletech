namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action split_1000_8AD1_18AD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8AD1_18AD1:
    CheckExternalEvents(cs8, 0x8AD4);
    // MOV AX,word ptr [BP + 0x6] (1000_8AD1 / 0x18AD1)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x8AD5);
    // POP BP (1000_8AD4 / 0x18AD4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x8AD6);
    // RETF  (1000_8AD5 / 0x18AD5)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0006_18AD6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0006_18AD6:
    CheckExternalEvents(cs11, 0x7);
    // PUSH BP (18AD_0006 / 0x18AD6)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x9);
    // MOV BP,SP (18AD_0007 / 0x18AD7)
    BP = SP;
    CheckExternalEvents(cs11, 0xB);
    // XOR AX,AX (18AD_0009 / 0x18AD9)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x10);
    // CALLF 0x1000:cecc (18AD_000B / 0x18ADB)
    FarCall(cs11, 0x10, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x12);
    // JMP 0x1000:8af3 (18AD_0010 / 0x18AE0)
    goto label_18AD_0023_18AF3;
    label_18AD_0012_18AE2:
    CheckExternalEvents(cs11, 0x16);
    // MOV ES,word ptr [0x56ee] (18AD_0012 / 0x18AE2)
    ES = UInt16[DS, 0x56EE];
    CheckExternalEvents(cs11, 0x1B);
    // PUSH word ptr ES:[0x32ac] (18AD_0016 / 0x18AE6)
    Stack.Push16(UInt16[ES, 0x32AC]);
    CheckExternalEvents(cs11, 0x20);
    // CALLF 0x1000:aa30 (18AD_001B / 0x18AEB)
    FarCall(cs11, 0x20, unknown_19EF_0B40_1AA30);
    CheckExternalEvents(cs11, 0x23);
    // ADD SP,0x2 (18AD_0020 / 0x18AF0)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_18AD_0023_18AF3:
    CheckExternalEvents(cs11, 0x26);
    // MOV AX,word ptr [BP + 0x6] (18AD_0023 / 0x18AF3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0x29);
    // DEC word ptr [BP + 0x6] (18AD_0026 / 0x18AF6)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x2B);
    // OR AX,AX (18AD_0029 / 0x18AF9)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs11, 0x2D);
    // JNZ 0x1000:8ae2 (18AD_002B / 0x18AFB)
    if(!ZeroFlag) {
      goto label_18AD_0012_18AE2;
    }
    CheckExternalEvents(cs11, 0x2E);
    // POP BP (18AD_002D / 0x18AFD)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x2F);
    // RETF  (18AD_002E / 0x18AFE)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_002F_18AFF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_002F_18AFF:
    CheckExternalEvents(cs11, 0x31);
    // XOR AX,AX (18AD_002F / 0x18AFF)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x36);
    // CALLF 0x1000:cecc (18AD_0031 / 0x18B01)
    FarCall(cs11, 0x36, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x3B);
    // CALLF 0x1000:dacc (18AD_0036 / 0x18B06)
    FarCall(cs11, 0x3B, unknown_19EF_3BDC_1DACC);
    CheckExternalEvents(cs11, 0x3D);
    // OR AX,AX (18AD_003B / 0x18B0B)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs11, 0x3F);
    // JNZ 0x1000:8b1b (18AD_003D / 0x18B0D)
    if(!ZeroFlag) {
      goto label_18AD_004B_18B1B;
    }
    CheckExternalEvents(cs11, 0x43);
    // MOV ES,word ptr [0x56f0] (18AD_003F / 0x18B0F)
    ES = UInt16[DS, 0x56F0];
    CheckExternalEvents(cs11, 0x49);
    // CMP word ptr ES:[0x3938],0x0 (18AD_0043 / 0x18B13)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs11, 0x4B);
    // JZ 0x1000:8b20 (18AD_0049 / 0x18B19)
    if(ZeroFlag) {
      goto label_18AD_0050_18B20;
    }
    label_18AD_004B_18B1B:
    CheckExternalEvents(cs11, 0x4E);
    // MOV AX,0x1 (18AD_004B / 0x18B1B)
    AX = 0x1;
    CheckExternalEvents(cs11, 0x50);
    // JMP 0x1000:8b22 (18AD_004E / 0x18B1E)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs11, 0x53);
    // RETF  (18AD_0052 / 0x18B22)
    return FarRet();
    label_18AD_0050_18B20:
    CheckExternalEvents(cs11, 0x52);
    // SUB AX,AX (18AD_0050 / 0x18B20)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    label_18AD_0052_18B22:
    CheckExternalEvents(cs11, 0x53);
    // RETF  (18AD_0052 / 0x18B22)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_8B23_18B23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8B23_18B23:
    CheckExternalEvents(cs8, 0x8B24);
    // PUSH BP (1000_8B23 / 0x18B23)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x8B26);
    // MOV BP,SP (1000_8B24 / 0x18B24)
    BP = SP;
    CheckExternalEvents(cs8, 0x8B28);
    // XOR AX,AX (1000_8B26 / 0x18B26)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs8, 0x8B2D);
    // CALLF 0x1000:cecc (1000_8B28 / 0x18B28)
    FarCall(cs8, 0x8B2D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x8B30);
    // MOV AX,0xa (1000_8B2D / 0x18B2D)
    AX = 0xA;
    CheckExternalEvents(cs8, 0x8B31);
    // PUSH AX (1000_8B30 / 0x18B30)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x8B34);
    // MOV AX,0x12 (1000_8B31 / 0x18B31)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x8B37);
    // MOV DX,0x2a02 (1000_8B34 / 0x18B34)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x8B38);
    // PUSH DX (1000_8B37 / 0x18B37)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x8B39);
    // PUSH AX (1000_8B38 / 0x18B38)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x8B3C);
    // PUSH word ptr [BP + 0x6] (1000_8B39 / 0x18B39)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x8B41);
    // CALLF 0x1000:daa6 (1000_8B3C / 0x18B3C)
    FarCall(cs8, 0x8B41, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs8, 0x8B44);
    // ADD SP,0x8 (1000_8B41 / 0x18B41)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x8B47);
    // MOV AX,0x12 (1000_8B44 / 0x18B44)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x8B4A);
    // MOV DX,0x2a02 (1000_8B47 / 0x18B47)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x8B4B);
    // PUSH DX (1000_8B4A / 0x18B4A)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x8B4C);
    // PUSH AX (1000_8B4B / 0x18B4B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x8B51);
    // CALLF 0x1000:8055 (1000_8B4C / 0x18B4C)
    FarCall(cs8, 0x8B51, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x8B54);
    // ADD SP,0x4 (1000_8B51 / 0x18B51)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x8B55);
    // POP BP (1000_8B54 / 0x18B54)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x8B56);
    // RETF  (1000_8B55 / 0x18B55)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0086_18B56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0086_18B56:
    CheckExternalEvents(cs11, 0x87);
    // PUSH BP (18AD_0086 / 0x18B56)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x89);
    // MOV BP,SP (18AD_0087 / 0x18B57)
    BP = SP;
    CheckExternalEvents(cs11, 0x8B);
    // XOR AX,AX (18AD_0089 / 0x18B59)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x90);
    // CALLF 0x1000:cecc (18AD_008B / 0x18B5B)
    FarCall(cs11, 0x90, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x95);
    // CMP word ptr [0x4fba],0x2 (18AD_0090 / 0x18B60)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs11, 0x97);
    // JZ 0x1000:8b83 (18AD_0095 / 0x18B65)
    if(ZeroFlag) {
      goto label_18AD_00B3_18B83;
    }
    CheckExternalEvents(cs11, 0x9A);
    // PUSH word ptr [BP + 0x10] (18AD_0097 / 0x18B67)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs11, 0x9D);
    // PUSH word ptr [BP + 0xe] (18AD_009A / 0x18B6A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0xA0);
    // PUSH word ptr [BP + 0xc] (18AD_009D / 0x18B6D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0xA3);
    // PUSH word ptr [BP + 0xa] (18AD_00A0 / 0x18B70)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0xA6);
    // PUSH word ptr [BP + 0x8] (18AD_00A3 / 0x18B73)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0xA9);
    // PUSH word ptr [BP + 0x6] (18AD_00A6 / 0x18B76)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0xAE);
    // CALLF 0x1000:befe (18AD_00A9 / 0x18B79)
    FarCall(cs11, 0xAE, unknown_19EF_200E_1BEFE);
    CheckExternalEvents(cs11, 0xB1);
    // ADD SP,0xc (18AD_00AE / 0x18B7E)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs11, 0xB3);
    // JMP 0x1000:8ba3 (18AD_00B1 / 0x18B81)
    goto label_18AD_00D3_18BA3;
    label_18AD_00B3_18B83:
    CheckExternalEvents(cs11, 0xB6);
    // PUSH word ptr [BP + 0x10] (18AD_00B3 / 0x18B83)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs11, 0xB9);
    // PUSH word ptr [BP + 0xe] (18AD_00B6 / 0x18B86)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0xBC);
    // PUSH word ptr [BP + 0xc] (18AD_00B9 / 0x18B89)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0xBF);
    // PUSH word ptr [BP + 0xa] (18AD_00BC / 0x18B8C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0xC1);
    // SUB AX,AX (18AD_00BF / 0x18B8F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0xC4);
    // MOV DX,0xa000 (18AD_00C1 / 0x18B91)
    DX = 0xA000;
    CheckExternalEvents(cs11, 0xC5);
    // PUSH DX (18AD_00C4 / 0x18B94)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0xC6);
    // PUSH AX (18AD_00C5 / 0x18B95)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0xC9);
    // MOV DX,0xa800 (18AD_00C6 / 0x18B96)
    DX = 0xA800;
    CheckExternalEvents(cs11, 0xCA);
    // PUSH DX (18AD_00C9 / 0x18B99)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0xCB);
    // PUSH AX (18AD_00CA / 0x18B9A)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0xD0);
    // CALLF 0x1000:c34c (18AD_00CB / 0x18B9B)
    FarCall(cs11, 0xD0, unknown_19EF_245C_1C34C);
    CheckExternalEvents(cs11, 0xD3);
    // ADD SP,0x10 (18AD_00D0 / 0x18BA0)
    // SP += 0x10;
    SP = Alu16.Add(SP, 0x10);
    label_18AD_00D3_18BA3:
    CheckExternalEvents(cs11, 0xD4);
    // POP BP (18AD_00D3 / 0x18BA3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0xD5);
    // RETF  (18AD_00D4 / 0x18BA4)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_00D5_18BA5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_00D5_18BA5:
    CheckExternalEvents(cs11, 0xD6);
    // PUSH BP (18AD_00D5 / 0x18BA5)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0xD8);
    // MOV BP,SP (18AD_00D6 / 0x18BA6)
    BP = SP;
    CheckExternalEvents(cs11, 0xDB);
    // MOV AX,0xe (18AD_00D8 / 0x18BA8)
    AX = 0xE;
    CheckExternalEvents(cs11, 0xE0);
    // CALLF 0x1000:cecc (18AD_00DB / 0x18BAB)
    FarCall(cs11, 0xE0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0xE3);
    // PUSH word ptr [BP + 0x10] (18AD_00E0 / 0x18BB0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs11, 0xE6);
    // PUSH word ptr [BP + 0xe] (18AD_00E3 / 0x18BB3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0xEB);
    // CALLF 0x1000:c017 (18AD_00E6 / 0x18BB6)
    FarCall(cs11, 0xEB, unknown_19EF_2127_1C017);
    CheckExternalEvents(cs11, 0xEE);
    // ADD SP,0x4 (18AD_00EB / 0x18BBB)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs11, 0xF1);
    // MOV AX,word ptr [BP + 0x6] (18AD_00EE / 0x18BBE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0xF4);
    // MOV DX,word ptr [BP + 0x8] (18AD_00F1 / 0x18BC1)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs11, 0xF7);
    // MOV word ptr [BP + -0x4],AX (18AD_00F4 / 0x18BC4)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs11, 0xFA);
    // MOV word ptr [BP + -0x2],DX (18AD_00F7 / 0x18BC7)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs11, 0xFD);
    // MOV AX,0x140 (18AD_00FA / 0x18BCA)
    AX = 0x140;
    CheckExternalEvents(cs11, 0x100);
    // IMUL word ptr [BP + 0xc] (18AD_00FD / 0x18BCD)
    int resImul18AD_00FD = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resImul18AD_00FD);
    DX = (ushort)(resImul18AD_00FD >> 16);
    CheckExternalEvents(cs11, 0x103);
    // MOV word ptr [BP + -0xa],AX (18AD_0100 / 0x18BD0)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs11, 0x108);
    // CMP word ptr [0x4fba],0x3 (18AD_0103 / 0x18BD3)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs11, 0x10A);
    // JNZ 0x1000:8be3 (18AD_0108 / 0x18BD8)
    if(!ZeroFlag) {
      goto label_18AD_0113_18BE3;
    }
    CheckExternalEvents(cs11, 0x10D);
    // MOV AX,0xa00 (18AD_010A / 0x18BDA)
    AX = 0xA00;
    CheckExternalEvents(cs11, 0x110);
    // IMUL word ptr [BP + 0xc] (18AD_010D / 0x18BDD)
    int resImul18AD_010D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resImul18AD_010D);
    DX = (ushort)(resImul18AD_010D >> 16);
    CheckExternalEvents(cs11, 0x113);
    // MOV word ptr [BP + -0xa],AX (18AD_0110 / 0x18BE0)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_18AD_0113_18BE3:
    CheckExternalEvents(cs11, 0x116);
    // MOV AX,word ptr [BP + 0xa] (18AD_0113 / 0x18BE3)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x119);
    // MOV word ptr [BP + -0x6],AX (18AD_0116 / 0x18BE6)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs11, 0x11C);
    // JMP 0x1000:8cb7 (18AD_0119 / 0x18BE9)
    goto label_18AD_01E7_18CB7;
    label_18AD_011C_18BEC:
    CheckExternalEvents(cs11, 0x120);
    // CMP byte ptr [BP + -0xe],0xd (18AD_011C / 0x18BEC)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0xE)], 0xD);
    CheckExternalEvents(cs11, 0x122);
    // JNZ 0x1000:8c0f (18AD_0120 / 0x18BF0)
    if(!ZeroFlag) {
      goto label_18AD_013F_18C0F;
    }
    CheckExternalEvents(cs11, 0x125);
    // MOV AX,word ptr [BP + -0x6] (18AD_0122 / 0x18BF2)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs11, 0x128);
    // MOV word ptr [BP + 0xa],AX (18AD_0125 / 0x18BF5)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs11, 0x12D);
    // ADD word ptr [BP + -0xa],0x140 (18AD_0128 / 0x18BF8)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x140;
    CheckExternalEvents(cs11, 0x132);
    // CMP word ptr [0x4fba],0x3 (18AD_012D / 0x18BFD)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs11, 0x134);
    // JNZ 0x1000:8c09 (18AD_0132 / 0x18C02)
    if(!ZeroFlag) {
      goto label_18AD_0139_18C09;
    }
    CheckExternalEvents(cs11, 0x139);
    // ADD word ptr [BP + -0xa],0x8c0 (18AD_0134 / 0x18C04)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x8C0;
    label_18AD_0139_18C09:
    CheckExternalEvents(cs11, 0x13C);
    // INC word ptr [BP + -0x4] (18AD_0139 / 0x18C09)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs11, 0x13F);
    // JMP 0x1000:8cb7 (18AD_013C / 0x18C0C)
    goto label_18AD_01E7_18CB7;
    label_18AD_013F_18C0F:
    CheckExternalEvents(cs11, 0x142);
    // LES BX,[BP + -0x4] (18AD_013F / 0x18C0F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs11, 0x145);
    // INC word ptr [BP + -0x4] (18AD_0142 / 0x18C12)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs11, 0x148);
    // MOV AL,byte ptr ES:[BX] (18AD_0145 / 0x18C15)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs11, 0x14B);
    // AND AX,0x7f (18AD_0148 / 0x18C18)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs11, 0x14D);
    // MOV CL,0x3 (18AD_014B / 0x18C1B)
    CL = 0x3;
    CheckExternalEvents(cs11, 0x14F);
    // SHL AX,CL (18AD_014D / 0x18C1D)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs11, 0x152);
    // MOV word ptr [BP + -0xc],AX (18AD_014F / 0x18C1F)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs11, 0x155);
    // MOV AX,[0x4fb8] (18AD_0152 / 0x18C22)
    AX = UInt16[DS, 0x4FB8];
    CheckExternalEvents(cs11, 0x156);
    // DEC AX (18AD_0155 / 0x18C25)
    AX--;
    CheckExternalEvents(cs11, 0x159);
    // CMP word ptr [BP + 0xa],AX (18AD_0156 / 0x18C26)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], AX);
    CheckExternalEvents(cs11, 0x15B);
    // JLE 0x1000:8c46 (18AD_0159 / 0x18C29)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_0176_18C46;
    }
    CheckExternalEvents(cs11, 0x15E);
    // MOV AX,word ptr [BP + -0x6] (18AD_015B / 0x18C2B)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs11, 0x161);
    // MOV word ptr [BP + 0xa],AX (18AD_015E / 0x18C2E)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs11, 0x165);
    // INC word ptr [0x4fbe] (18AD_0161 / 0x18C31)
    UInt16[DS, 0x4FBE]++;
    CheckExternalEvents(cs11, 0x16A);
    // ADD word ptr [BP + -0xa],0x140 (18AD_0165 / 0x18C35)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x140;
    CheckExternalEvents(cs11, 0x16F);
    // CMP word ptr [0x4fba],0x3 (18AD_016A / 0x18C3A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs11, 0x171);
    // JNZ 0x1000:8c46 (18AD_016F / 0x18C3F)
    if(!ZeroFlag) {
      goto label_18AD_0176_18C46;
    }
    CheckExternalEvents(cs11, 0x176);
    // ADD word ptr [BP + -0xa],0x8c0 (18AD_0171 / 0x18C41)
    // UInt16[SS, (ushort)(BP - 0xA)] += 0x8C0;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xA)], 0x8C0);
    label_18AD_0176_18C46:
    CheckExternalEvents(cs11, 0x179);
    // MOV AX,word ptr [BP + 0xa] (18AD_0176 / 0x18C46)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x17C);
    // INC word ptr [BP + 0xa] (18AD_0179 / 0x18C49)
    UInt16[SS, (ushort)(BP + 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x17F);
    // MOV word ptr [BP + -0x8],AX (18AD_017C / 0x18C4C)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs11, 0x184);
    // CMP word ptr [0x4fba],0x0 (18AD_017F / 0x18C4F)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs11, 0x186);
    // JNZ 0x1000:8c69 (18AD_0184 / 0x18C54)
    if(!ZeroFlag) {
      goto label_18AD_0199_18C69;
    }
    CheckExternalEvents(cs11, 0x188);
    // SHL AX,0x1 (18AD_0186 / 0x18C56)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs11, 0x189);
    // PUSH AX (18AD_0188 / 0x18C58)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x18C);
    // PUSH word ptr [BP + -0xa] (18AD_0189 / 0x18C59)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs11, 0x18F);
    // MOV AX,word ptr [BP + -0xc] (18AD_018C / 0x18C5C)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs11, 0x191);
    // SHL AX,0x1 (18AD_018F / 0x18C5F)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs11, 0x192);
    // PUSH AX (18AD_0191 / 0x18C61)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x197);
    // CALLF 0x1000:c0f9 (18AD_0192 / 0x18C62)
    FarCall(cs11, 0x197, ghidra_guess_1000_C0F9_1C0F9);
    CheckExternalEvents(cs11, 0x199);
    // JMP 0x1000:8cb4 (18AD_0197 / 0x18C67)
    goto label_18AD_01E4_18CB4;
    label_18AD_0199_18C69:
    CheckExternalEvents(cs11, 0x19E);
    // CMP word ptr [0x4fba],0x1 (18AD_0199 / 0x18C69)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x1);
    CheckExternalEvents(cs11, 0x1A0);
    // JNZ 0x1000:8c8a (18AD_019E / 0x18C6E)
    if(!ZeroFlag) {
      goto label_18AD_01BA_18C8A;
    }
    CheckExternalEvents(cs11, 0x1A3);
    // MOV AX,word ptr [BP + -0x8] (18AD_01A0 / 0x18C70)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs11, 0x1A5);
    // SHL AX,0x1 (18AD_01A3 / 0x18C73)
    AX <<= 0x1;
    CheckExternalEvents(cs11, 0x1A7);
    // SHL AX,0x1 (18AD_01A5 / 0x18C75)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs11, 0x1A8);
    // PUSH AX (18AD_01A7 / 0x18C77)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x1AB);
    // PUSH word ptr [BP + -0xa] (18AD_01A8 / 0x18C78)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs11, 0x1AE);
    // MOV AX,word ptr [BP + -0xc] (18AD_01AB / 0x18C7B)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs11, 0x1B0);
    // SHL AX,0x1 (18AD_01AE / 0x18C7E)
    AX <<= 0x1;
    CheckExternalEvents(cs11, 0x1B2);
    // SHL AX,0x1 (18AD_01B0 / 0x18C80)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs11, 0x1B3);
    // PUSH AX (18AD_01B2 / 0x18C82)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x1B8);
    // CALLF 0x1000:c098 (18AD_01B3 / 0x18C83)
    FarCall(cs11, 0x1B8, ghidra_guess_1000_C098_1C098);
    CheckExternalEvents(cs11, 0x1BA);
    // JMP 0x1000:8cb4 (18AD_01B8 / 0x18C88)
    goto label_18AD_01E4_18CB4;
    label_18AD_01BA_18C8A:
    CheckExternalEvents(cs11, 0x1BF);
    // CMP word ptr [0x4fba],0x2 (18AD_01BA / 0x18C8A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs11, 0x1C1);
    // JNZ 0x1000:8ca1 (18AD_01BF / 0x18C8F)
    if(!ZeroFlag) {
      goto label_18AD_01D1_18CA1;
    }
    CheckExternalEvents(cs11, 0x1C4);
    // PUSH word ptr [BP + -0x8] (18AD_01C1 / 0x18C91)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs11, 0x1C7);
    // PUSH word ptr [BP + -0xa] (18AD_01C4 / 0x18C94)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs11, 0x1CA);
    // PUSH word ptr [BP + -0xc] (18AD_01C7 / 0x18C97)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs11, 0x1CF);
    // CALLF 0x1000:c141 (18AD_01CA / 0x18C9A)
    FarCall(cs11, 0x1CF, unknown_19EF_2251_1C141);
    CheckExternalEvents(cs11, 0x1D1);
    // JMP 0x1000:8cb4 (18AD_01CF / 0x18C9F)
    goto label_18AD_01E4_18CB4;
    label_18AD_01D1_18CA1:
    CheckExternalEvents(cs11, 0x1D4);
    // MOV AX,word ptr [BP + -0x8] (18AD_01D1 / 0x18CA1)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs11, 0x1D6);
    // MOV CL,0x3 (18AD_01D4 / 0x18CA4)
    CL = 0x3;
    CheckExternalEvents(cs11, 0x1D8);
    // SHL AX,CL (18AD_01D6 / 0x18CA6)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs11, 0x1D9);
    // PUSH AX (18AD_01D8 / 0x18CA8)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x1DC);
    // PUSH word ptr [BP + -0xa] (18AD_01D9 / 0x18CA9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs11, 0x1DF);
    // PUSH word ptr [BP + -0xc] (18AD_01DC / 0x18CAC)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs11, 0x1E4);
    // CALLF 0x1000:c195 (18AD_01DF / 0x18CAF)
    FarCall(cs11, 0x1E4, unknown_19EF_22A5_1C195);
    label_18AD_01E4_18CB4:
    CheckExternalEvents(cs11, 0x1E7);
    // ADD SP,0x6 (18AD_01E4 / 0x18CB4)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_18AD_01E7_18CB7:
    CheckExternalEvents(cs11, 0x1EA);
    // LES BX,[BP + -0x4] (18AD_01E7 / 0x18CB7)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs11, 0x1ED);
    // MOV AL,byte ptr ES:[BX] (18AD_01EA / 0x18CBA)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs11, 0x1F0);
    // MOV byte ptr [BP + -0xe],AL (18AD_01ED / 0x18CBD)
    UInt8[SS, (ushort)(BP - 0xE)] = AL;
    CheckExternalEvents(cs11, 0x1F2);
    // OR AL,AL (18AD_01F0 / 0x18CC0)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs11, 0x1F4);
    // JZ 0x1000:8cc7 (18AD_01F2 / 0x18CC2)
    if(ZeroFlag) {
      goto label_18AD_01F7_18CC7;
    }
    CheckExternalEvents(cs11, 0x1F7);
    // JMP 0x1000:8bec (18AD_01F4 / 0x18CC4)
    goto label_18AD_011C_18BEC;
    label_18AD_01F7_18CC7:
    CheckExternalEvents(cs11, 0x1F9);
    // MOV SP,BP (18AD_01F7 / 0x18CC7)
    SP = BP;
    CheckExternalEvents(cs11, 0x1FA);
    // POP BP (18AD_01F9 / 0x18CC9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x1FB);
    // RETF  (18AD_01FA / 0x18CCA)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_01FB_18CCB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_01FB_18CCB:
    CheckExternalEvents(cs11, 0x1FC);
    // PUSH BP (18AD_01FB / 0x18CCB)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x1FE);
    // MOV BP,SP (18AD_01FC / 0x18CCC)
    BP = SP;
    CheckExternalEvents(cs11, 0x200);
    // XOR AX,AX (18AD_01FE / 0x18CCE)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x205);
    // CALLF 0x1000:cecc (18AD_0200 / 0x18CD0)
    FarCall(cs11, 0x205, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x209);
    // TEST byte ptr [BP + 0x6],0x1 (18AD_0205 / 0x18CD5)
    Alu8.And(UInt8[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs11, 0x20B);
    // JNZ 0x1000:8ce8 (18AD_0209 / 0x18CD9)
    if(!ZeroFlag) {
      goto label_18AD_0218_18CE8;
    }
    CheckExternalEvents(cs11, 0x20F);
    // TEST byte ptr [BP + 0xa],0x1 (18AD_020B / 0x18CDB)
    Alu8.And(UInt8[SS, (ushort)(BP + 0xA)], 0x1);
    CheckExternalEvents(cs11, 0x211);
    // JZ 0x1000:8ce8 (18AD_020F / 0x18CDF)
    if(ZeroFlag) {
      goto label_18AD_0218_18CE8;
    }
    CheckExternalEvents(cs11, 0x216);
    // CMP word ptr [0x4fba],0x1 (18AD_0211 / 0x18CE1)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x1);
    CheckExternalEvents(cs11, 0x218);
    // JZ 0x1000:8d06 (18AD_0216 / 0x18CE6)
    if(ZeroFlag) {
      goto label_18AD_0236_18D06;
    }
    label_18AD_0218_18CE8:
    CheckExternalEvents(cs11, 0x21B);
    // MOV AX,word ptr [BP + 0x8] (18AD_0218 / 0x18CE8)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs11, 0x21E);
    // CMP word ptr [BP + 0xc],AX (18AD_021B / 0x18CEB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], AX);
    CheckExternalEvents(cs11, 0x220);
    // JL 0x1000:8d27 (18AD_021E / 0x18CEE)
    if(SignFlag != OverflowFlag) {
      goto label_18AD_0257_18D27;
    }
    CheckExternalEvents(cs11, 0x223);
    // PUSH word ptr [BP + 0xe] (18AD_0220 / 0x18CF0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x226);
    // PUSH word ptr [BP + 0xa] (18AD_0223 / 0x18CF3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x229);
    // PUSH word ptr [BP + 0x6] (18AD_0226 / 0x18CF6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x22A);
    // PUSH AX (18AD_0229 / 0x18CF9)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x22D);
    // INC word ptr [BP + 0x8] (18AD_022A / 0x18CFA)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x22E);
    // PUSH CS (18AD_022D / 0x18CFD)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x231);
    // CALL 0x1000:8ebb (18AD_022E / 0x18CFE)
    NearCall(cs11, 0x231, unknown_18AD_03EB_18EBB);
    CheckExternalEvents(cs11, 0x234);
    // ADD SP,0x8 (18AD_0231 / 0x18D01)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs11, 0x236);
    // JMP 0x1000:8ce8 (18AD_0234 / 0x18D04)
    goto label_18AD_0218_18CE8;
    label_18AD_0236_18D06:
    CheckExternalEvents(cs11, 0x239);
    // PUSH word ptr [BP + 0xe] (18AD_0236 / 0x18D06)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x23C);
    // MOV AX,word ptr [BP + 0xc] (18AD_0239 / 0x18D09)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x23F);
    // SUB AX,word ptr [BP + 0x8] (18AD_023C / 0x18D0C)
    // AX -= UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x240);
    // PUSH AX (18AD_023F / 0x18D0F)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x243);
    // MOV AX,word ptr [BP + 0xa] (18AD_0240 / 0x18D10)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x246);
    // SUB AX,word ptr [BP + 0x6] (18AD_0243 / 0x18D13)
    AX -= UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0x248);
    // SAR AX,0x1 (18AD_0246 / 0x18D16)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs11, 0x249);
    // PUSH AX (18AD_0248 / 0x18D18)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x24C);
    // PUSH word ptr [BP + 0x8] (18AD_0249 / 0x18D19)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x24F);
    // PUSH word ptr [BP + 0x6] (18AD_024C / 0x18D1C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x254);
    // CALLF 0x1000:a791 (18AD_024F / 0x18D1F)
    FarCall(cs11, 0x254, ghidra_guess_1000_A791_1A791);
    CheckExternalEvents(cs11, 0x257);
    // ADD SP,0xa (18AD_0254 / 0x18D24)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_18AD_0257_18D27:
    CheckExternalEvents(cs11, 0x258);
    // POP BP (18AD_0257 / 0x18D27)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x259);
    // RETF  (18AD_0258 / 0x18D28)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0259_18D29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0259_18D29:
    CheckExternalEvents(cs11, 0x25A);
    // PUSH BP (18AD_0259 / 0x18D29)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x25C);
    // MOV BP,SP (18AD_025A / 0x18D2A)
    BP = SP;
    CheckExternalEvents(cs11, 0x25F);
    // MOV AX,0x4 (18AD_025C / 0x18D2C)
    AX = 0x4;
    CheckExternalEvents(cs11, 0x264);
    // CALLF 0x1000:cecc (18AD_025F / 0x18D2F)
    FarCall(cs11, 0x264, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x268);
    // MOV ES,word ptr [0x56f0] (18AD_0264 / 0x18D34)
    ES = UInt16[DS, 0x56F0];
    CheckExternalEvents(cs11, 0x26E);
    // CMP word ptr ES:[0x3938],0x0 (18AD_0268 / 0x18D38)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs11, 0x270);
    // JNZ 0x1000:8d91 (18AD_026E / 0x18D3E)
    if(!ZeroFlag) {
      goto label_18AD_02C1_18D91;
    }
    label_18AD_0270_18D40:
    CheckExternalEvents(cs11, 0x275);
    // CALLF 0x1000:aa7a (18AD_0270 / 0x18D40)
    FarCall(cs11, 0x275, unknown_19EF_0B8A_1AA7A);
    CheckExternalEvents(cs11, 0x278);
    // MOV word ptr [BP + -0x4],AX (18AD_0275 / 0x18D45)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs11, 0x27C);
    // MOV ES,word ptr [0x56f2] (18AD_0278 / 0x18D48)
    ES = UInt16[DS, 0x56F2];
    CheckExternalEvents(cs11, 0x282);
    // CMP word ptr ES:[0x458c],0x0 (18AD_027C / 0x18D4C)
    Alu16.Sub(UInt16[ES, 0x458C], 0x0);
    CheckExternalEvents(cs11, 0x284);
    // JNZ 0x1000:8d57 (18AD_0282 / 0x18D52)
    if(!ZeroFlag) {
      goto label_18AD_0287_18D57;
    }
    CheckExternalEvents(cs11, 0x287);
    // JMP 0x1000:8de8 (18AD_0284 / 0x18D54)
    goto label_18AD_0318_18DE8;
    label_18AD_0287_18D57:
    CheckExternalEvents(cs11, 0x28A);
    // CMP AX,0x68 (18AD_0287 / 0x18D57)
    Alu16.Sub(AX, 0x68);
    CheckExternalEvents(cs11, 0x28C);
    // JNZ 0x1000:8d61 (18AD_028A / 0x18D5A)
    if(!ZeroFlag) {
      goto label_18AD_0291_18D61;
    }
    CheckExternalEvents(cs11, 0x291);
    // MOV word ptr [BP + -0x4],0x48 (18AD_028C / 0x18D5C)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x48;
    label_18AD_0291_18D61:
    CheckExternalEvents(cs11, 0x294);
    // MOV AL,byte ptr [BP + -0x4] (18AD_0291 / 0x18D61)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs11, 0x298);
    // MOV ES,word ptr [0x56f4] (18AD_0294 / 0x18D64)
    ES = UInt16[DS, 0x56F4];
    CheckExternalEvents(cs11, 0x29D);
    // MOV BX,word ptr ES:[0x39f8] (18AD_0298 / 0x18D68)
    BX = UInt16[ES, 0x39F8];
    CheckExternalEvents(cs11, 0x2A2);
    // INC word ptr ES:[0x39f8] (18AD_029D / 0x18D6D)
    UInt16[ES, 0x39F8] = Alu16.Inc(UInt16[ES, 0x39F8]);
    CheckExternalEvents(cs11, 0x2A6);
    // MOV ES,word ptr [0x56f6] (18AD_02A2 / 0x18D72)
    ES = UInt16[DS, 0x56F6];
    CheckExternalEvents(cs11, 0x2AB);
    // MOV byte ptr ES:[BX + 0xa0],AL (18AD_02A6 / 0x18D76)
    UInt8[ES, (ushort)(BX + 0xA0)] = AL;
    CheckExternalEvents(cs11, 0x2AF);
    // CMP word ptr [BP + -0x4],0x48 (18AD_02AB / 0x18D7B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x48);
    CheckExternalEvents(cs11, 0x2B1);
    // JZ 0x1000:8d40 (18AD_02AF / 0x18D7F)
    if(ZeroFlag) {
      goto label_18AD_0270_18D40;
    }
    label_18AD_02B1_18D81:
    CheckExternalEvents(cs11, 0x2B4);
    // MOV AX,word ptr [BP + -0x4] (18AD_02B1 / 0x18D81)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs11, 0x2B6);
    // JMP 0x1000:8de8 (18AD_02B4 / 0x18D84)
    goto label_18AD_0318_18DE8;
    label_18AD_02B6_18D86:
    CheckExternalEvents(cs11, 0x2B9);
    // MOV AX,0x1e (18AD_02B6 / 0x18D86)
    AX = 0x1E;
    CheckExternalEvents(cs11, 0x2BA);
    // PUSH AX (18AD_02B9 / 0x18D89)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x2BB);
    // PUSH CS (18AD_02BA / 0x18D8A)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x2BE);
    // CALL 0x1000:8ad6 (18AD_02BB / 0x18D8B)
    NearCall(cs11, 0x2BE, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs11, 0x2C1);
    // ADD SP,0x2 (18AD_02BE / 0x18D8E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_18AD_02C1_18D91:
    CheckExternalEvents(cs11, 0x2C5);
    // MOV ES,word ptr [0x56f4] (18AD_02C1 / 0x18D91)
    ES = UInt16[DS, 0x56F4];
    CheckExternalEvents(cs11, 0x2CA);
    // MOV BX,word ptr ES:[0x39f8] (18AD_02C5 / 0x18D95)
    BX = UInt16[ES, 0x39F8];
    CheckExternalEvents(cs11, 0x2CF);
    // INC word ptr ES:[0x39f8] (18AD_02CA / 0x18D9A)
    UInt16[ES, 0x39F8] = Alu16.Inc(UInt16[ES, 0x39F8]);
    CheckExternalEvents(cs11, 0x2D3);
    // MOV ES,word ptr [0x56f6] (18AD_02CF / 0x18D9F)
    ES = UInt16[DS, 0x56F6];
    CheckExternalEvents(cs11, 0x2D8);
    // MOV AL,byte ptr ES:[BX + 0xa0] (18AD_02D3 / 0x18DA3)
    AL = UInt8[ES, (ushort)(BX + 0xA0)];
    CheckExternalEvents(cs11, 0x2D9);
    // CBW  (18AD_02D8 / 0x18DA8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs11, 0x2DC);
    // MOV word ptr [BP + -0x4],AX (18AD_02D9 / 0x18DA9)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs11, 0x2DF);
    // CMP AX,0x48 (18AD_02DC / 0x18DAC)
    Alu16.Sub(AX, 0x48);
    CheckExternalEvents(cs11, 0x2E1);
    // JZ 0x1000:8d86 (18AD_02DF / 0x18DAF)
    if(ZeroFlag) {
      goto label_18AD_02B6_18D86;
    }
    CheckExternalEvents(cs11, 0x2E6);
    // CALLF 0x1000:dacc (18AD_02E1 / 0x18DB1)
    FarCall(cs11, 0x2E6, unknown_19EF_3BDC_1DACC);
    CheckExternalEvents(cs11, 0x2E8);
    // OR AX,AX (18AD_02E6 / 0x18DB6)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs11, 0x2EA);
    // JZ 0x1000:8dca (18AD_02E8 / 0x18DB8)
    if(ZeroFlag) {
      goto label_18AD_02FA_18DCA;
    }
    CheckExternalEvents(cs11, 0x2EE);
    // MOV ES,word ptr [0x56f8] (18AD_02EA / 0x18DBA)
    ES = UInt16[DS, 0x56F8];
    CheckExternalEvents(cs11, 0x2F5);
    // MOV word ptr ES:[0x152],0x1 (18AD_02EE / 0x18DBE)
    UInt16[ES, 0x152] = 0x1;
    CheckExternalEvents(cs11, 0x2FA);
    // CALLF 0x1000:aa7a (18AD_02F5 / 0x18DC5)
    FarCall(cs11, 0x2FA, unknown_19EF_0B8A_1AA7A);
    label_18AD_02FA_18DCA:
    CheckExternalEvents(cs11, 0x2FD);
    // MOV AX,0x1 (18AD_02FA / 0x18DCA)
    AX = 0x1;
    CheckExternalEvents(cs11, 0x2FE);
    // PUSH AX (18AD_02FD / 0x18DCD)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x2FF);
    // PUSH CS (18AD_02FE / 0x18DCE)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x302);
    // CALL 0x1000:8ad6 (18AD_02FF / 0x18DCF)
    NearCall(cs11, 0x302, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs11, 0x305);
    // ADD SP,0x2 (18AD_0302 / 0x18DD2)
    SP += 0x2;
    CheckExternalEvents(cs11, 0x309);
    // CMP word ptr [BP + -0x4],0x50 (18AD_0305 / 0x18DD5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x50);
    CheckExternalEvents(cs11, 0x30B);
    // JNZ 0x1000:8d81 (18AD_0309 / 0x18DD9)
    if(!ZeroFlag) {
      goto label_18AD_02B1_18D81;
    }
    CheckExternalEvents(cs11, 0x30F);
    // MOV ES,word ptr [0x56f8] (18AD_030B / 0x18DDB)
    ES = UInt16[DS, 0x56F8];
    CheckExternalEvents(cs11, 0x316);
    // MOV word ptr ES:[0x152],0x1 (18AD_030F / 0x18DDF)
    UInt16[ES, 0x152] = 0x1;
    CheckExternalEvents(cs11, 0x318);
    // JMP 0x1000:8d81 (18AD_0316 / 0x18DE6)
    goto label_18AD_02B1_18D81;
    label_18AD_0318_18DE8:
    CheckExternalEvents(cs11, 0x31A);
    // MOV SP,BP (18AD_0318 / 0x18DE8)
    SP = BP;
    CheckExternalEvents(cs11, 0x31B);
    // POP BP (18AD_031A / 0x18DEA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x31C);
    // RETF  (18AD_031B / 0x18DEB)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_031C_18DEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_031C_18DEC:
    CheckExternalEvents(cs11, 0x31D);
    // PUSH BP (18AD_031C / 0x18DEC)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x31F);
    // MOV BP,SP (18AD_031D / 0x18DED)
    BP = SP;
    CheckExternalEvents(cs11, 0x322);
    // MOV AX,0x2 (18AD_031F / 0x18DEF)
    AX = 0x2;
    CheckExternalEvents(cs11, 0x327);
    // CALLF 0x1000:cecc (18AD_0322 / 0x18DF2)
    FarCall(cs11, 0x327, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x32A);
    // MOV AX,word ptr [BP + 0x6] (18AD_0327 / 0x18DF7)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0x32D);
    // CMP word ptr [BP + 0xa],AX (18AD_032A / 0x18DFA)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], AX);
    CheckExternalEvents(cs11, 0x32F);
    // JGE 0x1000:8e0e (18AD_032D / 0x18DFD)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_033E_18E0E;
    }
    CheckExternalEvents(cs11, 0x332);
    // MOV word ptr [BP + -0x2],AX (18AD_032F / 0x18DFF)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs11, 0x335);
    // MOV AX,word ptr [BP + 0xa] (18AD_0332 / 0x18E02)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x338);
    // MOV word ptr [BP + 0x6],AX (18AD_0335 / 0x18E05)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs11, 0x33B);
    // MOV AX,word ptr [BP + -0x2] (18AD_0338 / 0x18E08)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs11, 0x33E);
    // MOV word ptr [BP + 0xa],AX (18AD_033B / 0x18E0B)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    label_18AD_033E_18E0E:
    CheckExternalEvents(cs11, 0x341);
    // MOV AX,word ptr [BP + 0x8] (18AD_033E / 0x18E0E)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs11, 0x344);
    // CMP word ptr [BP + 0xc],AX (18AD_0341 / 0x18E11)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], AX);
    CheckExternalEvents(cs11, 0x346);
    // JGE 0x1000:8e25 (18AD_0344 / 0x18E14)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0355_18E25;
    }
    CheckExternalEvents(cs11, 0x349);
    // MOV word ptr [BP + -0x2],AX (18AD_0346 / 0x18E16)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs11, 0x34C);
    // MOV AX,word ptr [BP + 0xc] (18AD_0349 / 0x18E19)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x34F);
    // MOV word ptr [BP + 0x8],AX (18AD_034C / 0x18E1C)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs11, 0x352);
    // MOV AX,word ptr [BP + -0x2] (18AD_034F / 0x18E1F)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs11, 0x355);
    // MOV word ptr [BP + 0xc],AX (18AD_0352 / 0x18E22)
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    label_18AD_0355_18E25:
    CheckExternalEvents(cs11, 0x359);
    // CMP word ptr [BP + 0x6],0x0 (18AD_0355 / 0x18E25)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs11, 0x35B);
    // JGE 0x1000:8e30 (18AD_0359 / 0x18E29)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0360_18E30;
    }
    CheckExternalEvents(cs11, 0x360);
    // MOV word ptr [BP + 0x6],0x0 (18AD_035B / 0x18E2B)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x0;
    label_18AD_0360_18E30:
    CheckExternalEvents(cs11, 0x364);
    // CMP word ptr [BP + 0x8],0x0 (18AD_0360 / 0x18E30)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs11, 0x366);
    // JGE 0x1000:8e3b (18AD_0364 / 0x18E34)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_036B_18E3B;
    }
    CheckExternalEvents(cs11, 0x36B);
    // MOV word ptr [BP + 0x8],0x0 (18AD_0366 / 0x18E36)
    UInt16[SS, (ushort)(BP + 0x8)] = 0x0;
    label_18AD_036B_18E3B:
    CheckExternalEvents(cs11, 0x36F);
    // CMP word ptr [BP + 0xa],0x0 (18AD_036B / 0x18E3B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs11, 0x371);
    // JGE 0x1000:8e46 (18AD_036F / 0x18E3F)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0376_18E46;
    }
    CheckExternalEvents(cs11, 0x376);
    // MOV word ptr [BP + 0xa],0x0 (18AD_0371 / 0x18E41)
    UInt16[SS, (ushort)(BP + 0xA)] = 0x0;
    label_18AD_0376_18E46:
    CheckExternalEvents(cs11, 0x37A);
    // CMP word ptr [BP + 0xc],0x0 (18AD_0376 / 0x18E46)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0x0);
    CheckExternalEvents(cs11, 0x37C);
    // JGE 0x1000:8e51 (18AD_037A / 0x18E4A)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0381_18E51;
    }
    CheckExternalEvents(cs11, 0x381);
    // MOV word ptr [BP + 0xc],0x0 (18AD_037C / 0x18E4C)
    UInt16[SS, (ushort)(BP + 0xC)] = 0x0;
    label_18AD_0381_18E51:
    CheckExternalEvents(cs11, 0x386);
    // CMP word ptr [BP + 0x6],0x13f (18AD_0381 / 0x18E51)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x13F);
    CheckExternalEvents(cs11, 0x388);
    // JLE 0x1000:8e5d (18AD_0386 / 0x18E56)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_038D_18E5D;
    }
    CheckExternalEvents(cs11, 0x38D);
    // MOV word ptr [BP + 0x6],0x13f (18AD_0388 / 0x18E58)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x13F;
    label_18AD_038D_18E5D:
    CheckExternalEvents(cs11, 0x392);
    // CMP word ptr [BP + 0xa],0x13f (18AD_038D / 0x18E5D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x13F);
    CheckExternalEvents(cs11, 0x394);
    // JLE 0x1000:8e69 (18AD_0392 / 0x18E62)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_0399_18E69;
    }
    CheckExternalEvents(cs11, 0x399);
    // MOV word ptr [BP + 0xa],0x13f (18AD_0394 / 0x18E64)
    UInt16[SS, (ushort)(BP + 0xA)] = 0x13F;
    label_18AD_0399_18E69:
    CheckExternalEvents(cs11, 0x39E);
    // CMP word ptr [BP + 0x8],0xc7 (18AD_0399 / 0x18E69)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xC7);
    CheckExternalEvents(cs11, 0x3A0);
    // JLE 0x1000:8e75 (18AD_039E / 0x18E6E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_03A5_18E75;
    }
    CheckExternalEvents(cs11, 0x3A5);
    // MOV word ptr [BP + 0x8],0xc7 (18AD_03A0 / 0x18E70)
    UInt16[SS, (ushort)(BP + 0x8)] = 0xC7;
    label_18AD_03A5_18E75:
    CheckExternalEvents(cs11, 0x3AA);
    // CMP word ptr [BP + 0xc],0xc7 (18AD_03A5 / 0x18E75)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0xC7);
    CheckExternalEvents(cs11, 0x3AC);
    // JLE 0x1000:8e81 (18AD_03AA / 0x18E7A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_03B1_18E81;
    }
    CheckExternalEvents(cs11, 0x3B1);
    // MOV word ptr [BP + 0xc],0xc7 (18AD_03AC / 0x18E7C)
    UInt16[SS, (ushort)(BP + 0xC)] = 0xC7;
    label_18AD_03B1_18E81:
    CheckExternalEvents(cs11, 0x3B4);
    // MOV AX,word ptr [BP + 0xa] (18AD_03B1 / 0x18E81)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x3B7);
    // CMP word ptr [BP + 0x6],AX (18AD_03B4 / 0x18E84)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs11, 0x3B9);
    // JNZ 0x1000:8e9c (18AD_03B7 / 0x18E87)
    if(!ZeroFlag) {
      goto label_18AD_03CC_18E9C;
    }
    CheckExternalEvents(cs11, 0x3BC);
    // PUSH word ptr [BP + 0xe] (18AD_03B9 / 0x18E89)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x3BF);
    // PUSH word ptr [BP + 0xc] (18AD_03BC / 0x18E8C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x3C2);
    // PUSH word ptr [BP + 0x8] (18AD_03BF / 0x18E8F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x3C5);
    // PUSH word ptr [BP + 0x6] (18AD_03C2 / 0x18E92)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x3CA);
    // CALLF 0x1000:a4c0 (18AD_03C5 / 0x18E95)
    FarCall(cs11, 0x3CA, unknown_19EF_05D0_1A4C0);
    CheckExternalEvents(cs11, 0x3CC);
    // JMP 0x1000:8eb4 (18AD_03CA / 0x18E9A)
    goto label_18AD_03E4_18EB4;
    label_18AD_03CC_18E9C:
    CheckExternalEvents(cs11, 0x3CF);
    // MOV AX,word ptr [BP + 0xc] (18AD_03CC / 0x18E9C)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x3D2);
    // CMP word ptr [BP + 0x8],AX (18AD_03CF / 0x18E9F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs11, 0x3D4);
    // JNZ 0x1000:8eb7 (18AD_03D2 / 0x18EA2)
    if(!ZeroFlag) {
      goto label_18AD_03E7_18EB7;
    }
    CheckExternalEvents(cs11, 0x3D7);
    // PUSH word ptr [BP + 0xe] (18AD_03D4 / 0x18EA4)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x3DA);
    // PUSH word ptr [BP + 0xa] (18AD_03D7 / 0x18EA7)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x3DD);
    // PUSH word ptr [BP + 0x6] (18AD_03DA / 0x18EAA)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x3E0);
    // PUSH word ptr [BP + 0x8] (18AD_03DD / 0x18EAD)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x3E1);
    // PUSH CS (18AD_03E0 / 0x18EB0)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x3E4);
    // CALL 0x1000:8ebb (18AD_03E1 / 0x18EB1)
    NearCall(cs11, 0x3E4, unknown_18AD_03EB_18EBB);
    label_18AD_03E4_18EB4:
    CheckExternalEvents(cs11, 0x3E7);
    // ADD SP,0x8 (18AD_03E4 / 0x18EB4)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_03E7_18EB7:
    CheckExternalEvents(cs11, 0x3E9);
    // MOV SP,BP (18AD_03E7 / 0x18EB7)
    SP = BP;
    CheckExternalEvents(cs11, 0x3EA);
    // POP BP (18AD_03E9 / 0x18EB9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x3EB);
    // RETF  (18AD_03EA / 0x18EBA)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_03EB_18EBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_03EB_18EBB:
    CheckExternalEvents(cs11, 0x3EC);
    // PUSH BP (18AD_03EB / 0x18EBB)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x3EE);
    // MOV BP,SP (18AD_03EC / 0x18EBC)
    BP = SP;
    CheckExternalEvents(cs11, 0x3F1);
    // MOV AX,0x4 (18AD_03EE / 0x18EBE)
    AX = 0x4;
    CheckExternalEvents(cs11, 0x3F6);
    // CALLF 0x1000:cecc (18AD_03F1 / 0x18EC1)
    FarCall(cs11, 0x3F6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x3FA);
    // MOV BX,word ptr [0x4fba] (18AD_03F6 / 0x18EC6)
    BX = UInt16[DS, 0x4FBA];
    CheckExternalEvents(cs11, 0x3FC);
    // SHL BX,0x1 (18AD_03FA / 0x18ECA)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs11, 0x400);
    // MOV AX,word ptr [BX + 0x4fc4] (18AD_03FC / 0x18ECC)
    AX = UInt16[DS, (ushort)(BX + 0x4FC4)];
    CheckExternalEvents(cs11, 0x403);
    // MOV word ptr [BP + -0x4],AX (18AD_0400 / 0x18ED0)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs11, 0x405);
    // JMP 0x1000:8ef4 (18AD_0403 / 0x18ED3)
    goto label_18AD_0424_18EF4;
    label_18AD_0405_18ED5:
    CheckExternalEvents(cs11, 0x408);
    // MOV AX,word ptr [BP + 0xa] (18AD_0405 / 0x18ED5)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x40B);
    // CMP word ptr [BP + 0x8],AX (18AD_0408 / 0x18ED8)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs11, 0x40D);
    // JG 0x1000:8efc (18AD_040B / 0x18EDB)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_18AD_042C_18EFC;
    }
    CheckExternalEvents(cs11, 0x410);
    // PUSH word ptr [BP + 0xc] (18AD_040D / 0x18EDD)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x413);
    // PUSH word ptr [BP + 0x6] (18AD_0410 / 0x18EE0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x416);
    // PUSH word ptr [BP + 0x6] (18AD_0413 / 0x18EE3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x419);
    // PUSH word ptr [BP + 0x8] (18AD_0416 / 0x18EE6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x41C);
    // INC word ptr [BP + 0x8] (18AD_0419 / 0x18EE9)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x421);
    // CALLF 0x1000:a4c0 (18AD_041C / 0x18EEC)
    FarCall(cs11, 0x421, unknown_19EF_05D0_1A4C0);
    CheckExternalEvents(cs11, 0x424);
    // ADD SP,0x8 (18AD_0421 / 0x18EF1)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_0424_18EF4:
    CheckExternalEvents(cs11, 0x427);
    // MOV AX,word ptr [BP + -0x4] (18AD_0424 / 0x18EF4)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs11, 0x42A);
    // TEST word ptr [BP + 0x8],AX (18AD_0427 / 0x18EF7)
    Alu16.And(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs11, 0x42C);
    // JNZ 0x1000:8ed5 (18AD_042A / 0x18EFA)
    if(!ZeroFlag) {
      goto label_18AD_0405_18ED5;
    }
    label_18AD_042C_18EFC:
    CheckExternalEvents(cs11, 0x42F);
    // MOV AX,word ptr [BP + 0xa] (18AD_042C / 0x18EFC)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x432);
    // CMP word ptr [BP + 0x8],AX (18AD_042F / 0x18EFF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs11, 0x434);
    // JGE 0x1000:8f61 (18AD_0432 / 0x18F02)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0491_18F61;
    }
    CheckExternalEvents(cs11, 0x437);
    // SUB AX,word ptr [BP + 0x8] (18AD_0434 / 0x18F04)
    // AX -= UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x43A);
    // MOV word ptr [BP + -0x2],AX (18AD_0437 / 0x18F07)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs11, 0x43F);
    // CMP word ptr [0x4fba],0x3 (18AD_043A / 0x18F0A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs11, 0x441);
    // JZ 0x1000:8f1e (18AD_043F / 0x18F0F)
    if(ZeroFlag) {
      goto label_18AD_044E_18F1E;
    }
    CheckExternalEvents(cs11, 0x445);
    // MOV BX,word ptr [0x4fba] (18AD_0441 / 0x18F11)
    BX = UInt16[DS, 0x4FBA];
    CheckExternalEvents(cs11, 0x447);
    // SHL BX,0x1 (18AD_0445 / 0x18F15)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs11, 0x44B);
    // MOV CL,byte ptr [BX + 0x4fd4] (18AD_0447 / 0x18F17)
    CL = UInt8[DS, (ushort)(BX + 0x4FD4)];
    CheckExternalEvents(cs11, 0x44E);
    // SAR word ptr [BP + -0x2],CL (18AD_044B / 0x18F1B)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Sar(UInt16[SS, (ushort)(BP - 0x2)], CL);
    label_18AD_044E_18F1E:
    CheckExternalEvents(cs11, 0x452);
    // CMP word ptr [BP + -0x2],0x0 (18AD_044E / 0x18F1E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs11, 0x454);
    // JZ 0x1000:8f38 (18AD_0452 / 0x18F22)
    if(ZeroFlag) {
      goto label_18AD_0468_18F38;
    }
    CheckExternalEvents(cs11, 0x457);
    // PUSH word ptr [BP + 0xc] (18AD_0454 / 0x18F24)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x45A);
    // PUSH word ptr [BP + -0x2] (18AD_0457 / 0x18F27)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs11, 0x45D);
    // PUSH word ptr [BP + 0x6] (18AD_045A / 0x18F2A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x460);
    // PUSH word ptr [BP + 0x8] (18AD_045D / 0x18F2D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x465);
    // CALLF 0x1000:a670 (18AD_0460 / 0x18F30)
    FarCall(cs11, 0x465, unknown_19EF_0780_1A670);
    CheckExternalEvents(cs11, 0x468);
    // ADD SP,0x8 (18AD_0465 / 0x18F35)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_0468_18F38:
    CheckExternalEvents(cs11, 0x46C);
    // MOV BX,word ptr [0x4fba] (18AD_0468 / 0x18F38)
    BX = UInt16[DS, 0x4FBA];
    CheckExternalEvents(cs11, 0x46E);
    // SHL BX,0x1 (18AD_046C / 0x18F3C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs11, 0x472);
    // MOV AX,word ptr [BX + 0x4fcc] (18AD_046E / 0x18F3E)
    AX = UInt16[DS, (ushort)(BX + 0x4FCC)];
    CheckExternalEvents(cs11, 0x475);
    // AND AX,word ptr [BP + 0xa] (18AD_0472 / 0x18F42)
    // AX &= UInt16[SS, (ushort)(BP + 0xA)];
    AX = Alu16.And(AX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x478);
    // MOV word ptr [BP + 0x8],AX (18AD_0475 / 0x18F45)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs11, 0x47A);
    // JMP 0x1000:8f61 (18AD_0478 / 0x18F48)
    goto label_18AD_0491_18F61;
    label_18AD_047A_18F4A:
    CheckExternalEvents(cs11, 0x47D);
    // PUSH word ptr [BP + 0xc] (18AD_047A / 0x18F4A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x480);
    // PUSH word ptr [BP + 0x6] (18AD_047D / 0x18F4D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x483);
    // PUSH word ptr [BP + 0x6] (18AD_0480 / 0x18F50)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x486);
    // PUSH word ptr [BP + 0x8] (18AD_0483 / 0x18F53)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x489);
    // INC word ptr [BP + 0x8] (18AD_0486 / 0x18F56)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x48E);
    // CALLF 0x1000:a4c0 (18AD_0489 / 0x18F59)
    FarCall(cs11, 0x48E, unknown_19EF_05D0_1A4C0);
    CheckExternalEvents(cs11, 0x491);
    // ADD SP,0x8 (18AD_048E / 0x18F5E)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_0491_18F61:
    CheckExternalEvents(cs11, 0x494);
    // MOV AX,word ptr [BP + 0xa] (18AD_0491 / 0x18F61)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x497);
    // CMP word ptr [BP + 0x8],AX (18AD_0494 / 0x18F64)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs11, 0x499);
    // JLE 0x1000:8f4a (18AD_0497 / 0x18F67)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_047A_18F4A;
    }
    CheckExternalEvents(cs11, 0x49B);
    // MOV SP,BP (18AD_0499 / 0x18F69)
    SP = BP;
    CheckExternalEvents(cs11, 0x49C);
    // POP BP (18AD_049B / 0x18F6B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x49D);
    // RETF  (18AD_049C / 0x18F6C)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_049D_18F6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_049D_18F6D:
    CheckExternalEvents(cs11, 0x49E);
    // PUSH BP (18AD_049D / 0x18F6D)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x4A0);
    // MOV BP,SP (18AD_049E / 0x18F6E)
    BP = SP;
    CheckExternalEvents(cs11, 0x4A3);
    // MOV AX,0x4 (18AD_04A0 / 0x18F70)
    AX = 0x4;
    CheckExternalEvents(cs11, 0x4A8);
    // CALLF 0x1000:cecc (18AD_04A3 / 0x18F73)
    FarCall(cs11, 0x4A8, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x4AB);
    // LES BX,[BP + 0x6] (18AD_04A8 / 0x18F78)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs11, 0x4AE);
    // INC word ptr [BP + 0x6] (18AD_04AB / 0x18F7B)
    UInt16[SS, (ushort)(BP + 0x6)]++;
    CheckExternalEvents(cs11, 0x4B2);
    // CMP byte ptr ES:[BX],0x1 (18AD_04AE / 0x18F7E)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x1);
    CheckExternalEvents(cs11, 0x4B4);
    // JNZ 0x1000:8f95 (18AD_04B2 / 0x18F82)
    if(!ZeroFlag) {
      goto label_18AD_04C5_18F95;
    }
    CheckExternalEvents(cs11, 0x4B7);
    // PUSH word ptr [BP + 0xc] (18AD_04B4 / 0x18F84)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x4BA);
    // PUSH word ptr [BP + 0xa] (18AD_04B7 / 0x18F87)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x4BB);
    // PUSH ES (18AD_04BA / 0x18F8A)
    Stack.Push16(ES);
    CheckExternalEvents(cs11, 0x4BE);
    // PUSH word ptr [BP + 0x6] (18AD_04BB / 0x18F8B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x4C3);
    // CALLF 0x1000:c1e8 (18AD_04BE / 0x18F8E)
    FarCall(cs11, 0x4C3, unknown_19EF_22F8_1C1E8);
    CheckExternalEvents(cs11, 0x4C5);
    // JMP 0x1000:8fa6 (18AD_04C3 / 0x18F93)
    goto label_18AD_04D6_18FA6;
    label_18AD_04C5_18F95:
    CheckExternalEvents(cs11, 0x4C8);
    // PUSH word ptr [BP + 0xc] (18AD_04C5 / 0x18F95)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x4CB);
    // PUSH word ptr [BP + 0xa] (18AD_04C8 / 0x18F98)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x4CE);
    // PUSH word ptr [BP + 0x8] (18AD_04CB / 0x18F9B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x4D1);
    // PUSH word ptr [BP + 0x6] (18AD_04CE / 0x18F9E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x4D6);
    // CALLF 0x1000:c258 (18AD_04D1 / 0x18FA1)
    FarCall(cs11, 0x4D6, unknown_19EF_2368_1C258);
    label_18AD_04D6_18FA6:
    CheckExternalEvents(cs11, 0x4D9);
    // ADD SP,0x8 (18AD_04D6 / 0x18FA6)
    SP += 0x8;
    CheckExternalEvents(cs11, 0x4DE);
    // CMP word ptr [0x4fba],0x0 (18AD_04D9 / 0x18FA9)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs11, 0x4E0);
    // JNZ 0x1000:8ff1 (18AD_04DE / 0x18FAE)
    if(!ZeroFlag) {
      goto label_18AD_0521_18FF1;
    }
    CheckExternalEvents(cs11, 0x4E5);
    // MOV word ptr [BP + -0x4],0x50 (18AD_04E0 / 0x18FB0)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x50;
    CheckExternalEvents(cs11, 0x4EA);
    // CMP word ptr [0x4fbc],0x0 (18AD_04E5 / 0x18FB5)
    Alu16.Sub(UInt16[DS, 0x4FBC], 0x0);
    CheckExternalEvents(cs11, 0x4EC);
    // JZ 0x1000:8fc1 (18AD_04EA / 0x18FBA)
    if(ZeroFlag) {
      goto label_18AD_04F1_18FC1;
    }
    CheckExternalEvents(cs11, 0x4F1);
    // MOV word ptr [BP + -0x4],0x4 (18AD_04EC / 0x18FBC)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x4;
    label_18AD_04F1_18FC1:
    CheckExternalEvents(cs11, 0x4F4);
    // MOV AX,0x3e80 (18AD_04F1 / 0x18FC1)
    AX = 0x3E80;
    CheckExternalEvents(cs11, 0x4F5);
    // PUSH AX (18AD_04F4 / 0x18FC4)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x4F8);
    // PUSH word ptr [BP + -0x4] (18AD_04F5 / 0x18FC5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs11, 0x4FB);
    // PUSH word ptr [BP + 0xc] (18AD_04F8 / 0x18FC8)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x4FE);
    // PUSH word ptr [BP + 0xa] (18AD_04FB / 0x18FCB)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x501);
    // PUSH word ptr [BP + 0xc] (18AD_04FE / 0x18FCE)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x504);
    // PUSH word ptr [BP + 0xa] (18AD_0501 / 0x18FD1)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x509);
    // CALLF 0x1000:a053 (18AD_0504 / 0x18FD4)
    FarCall(cs11, 0x509, ghidra_guess_1000_A053_1A053);
    CheckExternalEvents(cs11, 0x50C);
    // ADD SP,0xc (18AD_0509 / 0x18FD9)
    SP += 0xC;
    CheckExternalEvents(cs11, 0x511);
    // CMP word ptr [0x4fbc],0x0 (18AD_050C / 0x18FDC)
    Alu16.Sub(UInt16[DS, 0x4FBC], 0x0);
    CheckExternalEvents(cs11, 0x513);
    // JZ 0x1000:8ff1 (18AD_0511 / 0x18FE1)
    if(ZeroFlag) {
      goto label_18AD_0521_18FF1;
    }
    CheckExternalEvents(cs11, 0x516);
    // PUSH word ptr [BP + 0xc] (18AD_0513 / 0x18FE3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x519);
    // PUSH word ptr [BP + 0xa] (18AD_0516 / 0x18FE6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x51E);
    // CALLF 0x1000:a0c7 (18AD_0519 / 0x18FE9)
    FarCall(cs11, 0x51E, ghidra_guess_1000_A0C7_1A0C7);
    CheckExternalEvents(cs11, 0x521);
    // ADD SP,0x4 (18AD_051E / 0x18FEE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_18AD_0521_18FF1:
    CheckExternalEvents(cs11, 0x523);
    // MOV SP,BP (18AD_0521 / 0x18FF1)
    SP = BP;
    CheckExternalEvents(cs11, 0x524);
    // POP BP (18AD_0523 / 0x18FF3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x525);
    // RETF  (18AD_0524 / 0x18FF4)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0525_18FF5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0525_18FF5:
    CheckExternalEvents(cs11, 0x526);
    // PUSH BP (18AD_0525 / 0x18FF5)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x528);
    // MOV BP,SP (18AD_0526 / 0x18FF6)
    BP = SP;
    CheckExternalEvents(cs11, 0x52B);
    // MOV AX,0x4 (18AD_0528 / 0x18FF8)
    AX = 0x4;
    CheckExternalEvents(cs11, 0x530);
    // CALLF 0x1000:cecc (18AD_052B / 0x18FFB)
    FarCall(cs11, 0x530, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x531);
    // PUSH SI (18AD_0530 / 0x19000)
    Stack.Push16(SI);
    CheckExternalEvents(cs11, 0x536);
    // CMP word ptr [0x4fba],0x1 (18AD_0531 / 0x19001)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x1);
    CheckExternalEvents(cs11, 0x538);
    // JNZ 0x1000:9026 (18AD_0536 / 0x19006)
    if(!ZeroFlag) {
      goto label_18AD_0556_19026;
    }
    CheckExternalEvents(cs11, 0x53C);
    // MOV ES,word ptr [0x56ee] (18AD_0538 / 0x19008)
    ES = UInt16[DS, 0x56EE];
    CheckExternalEvents(cs11, 0x541);
    // PUSH word ptr ES:[0x32ac] (18AD_053C / 0x1900C)
    Stack.Push16(UInt16[ES, 0x32AC]);
    CheckExternalEvents(cs11, 0x546);
    // CALLF 0x1000:aa30 (18AD_0541 / 0x19011)
    FarCall(cs11, 0x546, unknown_19EF_0B40_1AA30);
    CheckExternalEvents(cs11, 0x549);
    // ADD SP,0x2 (18AD_0546 / 0x19016)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs11, 0x54C);
    // PUSH word ptr [BP + 0x8] (18AD_0549 / 0x19019)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x54F);
    // PUSH word ptr [BP + 0x6] (18AD_054C / 0x1901C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x554);
    // CALLF 0x1000:ca35 (18AD_054F / 0x1901F)
    FarCall(cs11, 0x554, ghidra_guess_1000_CA35_1CA35);
    CheckExternalEvents(cs11, 0x556);
    // JMP 0x1000:9084 (18AD_0554 / 0x19024)
    goto label_18AD_05B4_19084;
    label_18AD_0556_19026:
    CheckExternalEvents(cs11, 0x55B);
    // CMP word ptr [0x4fba],0x2 (18AD_0556 / 0x19026)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs11, 0x55D);
    // JNZ 0x1000:9072 (18AD_055B / 0x1902B)
    if(!ZeroFlag) {
      goto label_18AD_05A2_19072;
    }
    CheckExternalEvents(cs11, 0x561);
    // MOV ES,word ptr [0x56ee] (18AD_055D / 0x1902D)
    ES = UInt16[DS, 0x56EE];
    CheckExternalEvents(cs11, 0x566);
    // PUSH word ptr ES:[0x32ac] (18AD_0561 / 0x19031)
    Stack.Push16(UInt16[ES, 0x32AC]);
    CheckExternalEvents(cs11, 0x56B);
    // CALLF 0x1000:aa30 (18AD_0566 / 0x19036)
    FarCall(cs11, 0x56B, unknown_19EF_0B40_1AA30);
    CheckExternalEvents(cs11, 0x56E);
    // ADD SP,0x2 (18AD_056B / 0x1903B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs11, 0x573);
    // MOV word ptr [BP + -0x2],0x0 (18AD_056E / 0x1903E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs11, 0x575);
    // JMP 0x1000:9048 (18AD_0573 / 0x19043)
    goto label_18AD_0578_19048;
    label_18AD_0575_19045:
    CheckExternalEvents(cs11, 0x578);
    // INC word ptr [BP + -0x2] (18AD_0575 / 0x19045)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_18AD_0578_19048:
    CheckExternalEvents(cs11, 0x57C);
    // CMP word ptr [BP + -0x2],0x10 (18AD_0578 / 0x19048)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs11, 0x57E);
    // JGE 0x1000:9087 (18AD_057C / 0x1904C)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_05B7_19087;
    }
    CheckExternalEvents(cs11, 0x581);
    // MOV BX,word ptr [BP + -0x2] (18AD_057E / 0x1904E)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs11, 0x584);
    // LES SI,[BP + 0x6] (18AD_0581 / 0x19051)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs11, 0x587);
    // MOV AL,byte ptr ES:[BX + SI] (18AD_0584 / 0x19054)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs11, 0x588);
    // CBW  (18AD_0587 / 0x19057)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs11, 0x58B);
    // MOV word ptr [BP + -0x4],AX (18AD_0588 / 0x19058)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs11, 0x58E);
    // CMP AX,0x7 (18AD_058B / 0x1905B)
    Alu16.Sub(AX, 0x7);
    CheckExternalEvents(cs11, 0x590);
    // JLE 0x1000:9064 (18AD_058E / 0x1905E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_0594_19064;
    }
    CheckExternalEvents(cs11, 0x594);
    // ADD word ptr [BP + -0x4],0x8 (18AD_0590 / 0x19060)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x8;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x8);
    label_18AD_0594_19064:
    CheckExternalEvents(cs11, 0x597);
    // PUSH word ptr [BP + -0x4] (18AD_0594 / 0x19064)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs11, 0x598);
    // PUSH BX (18AD_0597 / 0x19067)
    Stack.Push16(BX);
    CheckExternalEvents(cs11, 0x59D);
    // CALLF 0x1000:a11a (18AD_0598 / 0x19068)
    FarCall(cs11, 0x59D, unknown_19EF_022A_1A11A);
    CheckExternalEvents(cs11, 0x5A0);
    // ADD SP,0x4 (18AD_059D / 0x1906D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs11, 0x5A2);
    // JMP 0x1000:9045 (18AD_05A0 / 0x19070)
    goto label_18AD_0575_19045;
    label_18AD_05A2_19072:
    CheckExternalEvents(cs11, 0x5A7);
    // CMP word ptr [0x4fba],0x3 (18AD_05A2 / 0x19072)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs11, 0x5A9);
    // JNZ 0x1000:9087 (18AD_05A7 / 0x19077)
    if(!ZeroFlag) {
      goto label_18AD_05B7_19087;
    }
    CheckExternalEvents(cs11, 0x5AC);
    // PUSH word ptr [BP + 0x8] (18AD_05A9 / 0x19079)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x5AF);
    // PUSH word ptr [BP + 0x6] (18AD_05AC / 0x1907C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x5B4);
    // CALLF 0x1000:aede (18AD_05AF / 0x1907F)
    FarCall(cs11, 0x5B4, unknown_19EF_0FEE_1AEDE);
    label_18AD_05B4_19084:
    CheckExternalEvents(cs11, 0x5B7);
    // ADD SP,0x4 (18AD_05B4 / 0x19084)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_18AD_05B7_19087:
    CheckExternalEvents(cs11, 0x5B8);
    // POP SI (18AD_05B7 / 0x19087)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x5BA);
    // MOV SP,BP (18AD_05B8 / 0x19088)
    SP = BP;
    CheckExternalEvents(cs11, 0x5BB);
    // POP BP (18AD_05BA / 0x1908A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x5BC);
    // RETF  (18AD_05BB / 0x1908B)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_05BC_1908C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_05BC_1908C:
    CheckExternalEvents(cs11, 0x5BD);
    // PUSH BP (18AD_05BC / 0x1908C)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x5BF);
    // MOV BP,SP (18AD_05BD / 0x1908D)
    BP = SP;
    CheckExternalEvents(cs11, 0x5C2);
    // MOV AX,0x6 (18AD_05BF / 0x1908F)
    AX = 0x6;
    CheckExternalEvents(cs11, 0x5C7);
    // CALLF 0x1000:cecc (18AD_05C2 / 0x19092)
    FarCall(cs11, 0x5C7, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x5CA);
    // MOV AX,word ptr [BP + 0x6] (18AD_05C7 / 0x19097)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0x5CD);
    // MOV word ptr [BP + -0x2],AX (18AD_05CA / 0x1909A)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs11, 0x5D1);
    // CMP word ptr [BP + 0x8],0x0 (18AD_05CD / 0x1909D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs11, 0x5D3);
    // JL 0x1000:90ca (18AD_05D1 / 0x190A1)
    if(SignFlag != OverflowFlag) {
      goto label_18AD_05FA_190CA;
    }
    CheckExternalEvents(cs11, 0x5D5);
    // JG 0x1000:90aa (18AD_05D3 / 0x190A3)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_18AD_05DA_190AA;
    }
    CheckExternalEvents(cs11, 0x5D8);
    // CMP AX,0xffff (18AD_05D5 / 0x190A5)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs11, 0x5DA);
    // JBE 0x1000:90ca (18AD_05D8 / 0x190A8)
    if(CarryFlag || ZeroFlag) {
      goto label_18AD_05FA_190CA;
    }
    label_18AD_05DA_190AA:
    CheckExternalEvents(cs11, 0x5DC);
    // SUB AX,AX (18AD_05DA / 0x190AA)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0x5DD);
    // PUSH AX (18AD_05DC / 0x190AC)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x5E0);
    // MOV AX,0xf (18AD_05DD / 0x190AD)
    AX = 0xF;
    CheckExternalEvents(cs11, 0x5E1);
    // PUSH AX (18AD_05E0 / 0x190B0)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x5E4);
    // MOV AX,0xa (18AD_05E1 / 0x190B1)
    AX = 0xA;
    CheckExternalEvents(cs11, 0x5E5);
    // PUSH AX (18AD_05E4 / 0x190B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x5E7);
    // SUB AX,AX (18AD_05E5 / 0x190B5)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0x5E8);
    // PUSH AX (18AD_05E7 / 0x190B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x5EB);
    // MOV AX,0x4fda (18AD_05E8 / 0x190B8)
    AX = 0x4FDA;
    CheckExternalEvents(cs11, 0x5EC);
    // PUSH DS (18AD_05EB / 0x190BB)
    Stack.Push16(DS);
    CheckExternalEvents(cs11, 0x5ED);
    // PUSH AX (18AD_05EC / 0x190BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x5EE);
    // PUSH CS (18AD_05ED / 0x190BD)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x5F1);
    // CALL 0x1000:8ba5 (18AD_05EE / 0x190BE)
    NearCall(cs11, 0x5F1, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs11, 0x5F4);
    // ADD SP,0xc (18AD_05F1 / 0x190C1)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs11, 0x5F5);
    // PUSH CS (18AD_05F4 / 0x190C4)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x5F8);
    // CALL 0x1000:8d29 (18AD_05F5 / 0x190C5)
    NearCall(cs11, 0x5F8, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs11, 0x5FA);
    // JMP 0x1000:90db (18AD_05F8 / 0x190C8)
    goto label_18AD_060B_190DB;
    label_18AD_05FA_190CA:
    CheckExternalEvents(cs11, 0x5FD);
    // PUSH word ptr [BP + -0x2] (18AD_05FA / 0x190CA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs11, 0x602);
    // CALLF 0x1000:d725 (18AD_05FD / 0x190CD)
    FarCall(cs11, 0x602, unknown_19EF_3835_1D725);
    CheckExternalEvents(cs11, 0x605);
    // ADD SP,0x2 (18AD_0602 / 0x190D2)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs11, 0x608);
    // MOV word ptr [BP + -0x6],AX (18AD_0605 / 0x190D5)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs11, 0x60B);
    // MOV word ptr [BP + -0x4],DX (18AD_0608 / 0x190D8)
    UInt16[SS, (ushort)(BP - 0x4)] = DX;
    label_18AD_060B_190DB:
    CheckExternalEvents(cs11, 0x60E);
    // MOV AX,word ptr [BP + -0x6] (18AD_060B / 0x190DB)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs11, 0x611);
    // OR AX,word ptr [BP + -0x4] (18AD_060E / 0x190DE)
    // AX |= UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Or(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs11, 0x613);
    // JNZ 0x1000:9101 (18AD_0611 / 0x190E1)
    if(!ZeroFlag) {
      goto label_18AD_0631_19101;
    }
    CheckExternalEvents(cs11, 0x615);
    // SUB AX,AX (18AD_0613 / 0x190E3)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0x616);
    // PUSH AX (18AD_0615 / 0x190E5)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x619);
    // MOV AX,0xf (18AD_0616 / 0x190E6)
    AX = 0xF;
    CheckExternalEvents(cs11, 0x61A);
    // PUSH AX (18AD_0619 / 0x190E9)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x61D);
    // MOV AX,0xa (18AD_061A / 0x190EA)
    AX = 0xA;
    CheckExternalEvents(cs11, 0x61E);
    // PUSH AX (18AD_061D / 0x190ED)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x620);
    // SUB AX,AX (18AD_061E / 0x190EE)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0x621);
    // PUSH AX (18AD_0620 / 0x190F0)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x624);
    // MOV AX,0x4fe9 (18AD_0621 / 0x190F1)
    AX = 0x4FE9;
    CheckExternalEvents(cs11, 0x625);
    // PUSH DS (18AD_0624 / 0x190F4)
    Stack.Push16(DS);
    CheckExternalEvents(cs11, 0x626);
    // PUSH AX (18AD_0625 / 0x190F5)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x627);
    // PUSH CS (18AD_0626 / 0x190F6)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x62A);
    // CALL 0x1000:8ba5 (18AD_0627 / 0x190F7)
    NearCall(cs11, 0x62A, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs11, 0x62D);
    // ADD SP,0xc (18AD_062A / 0x190FA)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs11, 0x62E);
    // PUSH CS (18AD_062D / 0x190FD)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x631);
    // CALL 0x1000:8d29 (18AD_062E / 0x190FE)
    NearCall(cs11, 0x631, unknown_18AD_0259_18D29);
    label_18AD_0631_19101:
    CheckExternalEvents(cs11, 0x634);
    // MOV AX,word ptr [BP + -0x6] (18AD_0631 / 0x19101)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs11, 0x637);
    // MOV DX,word ptr [BP + -0x4] (18AD_0634 / 0x19104)
    DX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs11, 0x639);
    // MOV SP,BP (18AD_0637 / 0x19107)
    SP = BP;
    CheckExternalEvents(cs11, 0x63A);
    // POP BP (18AD_0639 / 0x19109)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x63B);
    // RETF  (18AD_063A / 0x1910A)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_063B_1910B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_063B_1910B:
    CheckExternalEvents(cs11, 0x63C);
    // PUSH BP (18AD_063B / 0x1910B)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x63E);
    // MOV BP,SP (18AD_063C / 0x1910C)
    BP = SP;
    CheckExternalEvents(cs11, 0x641);
    // MOV AX,0x6 (18AD_063E / 0x1910E)
    AX = 0x6;
    CheckExternalEvents(cs11, 0x646);
    // CALLF 0x1000:cecc (18AD_0641 / 0x19111)
    FarCall(cs11, 0x646, unknown_19EF_2FDC_1CECC);
    label_18AD_0646_19116:
    CheckExternalEvents(cs11, 0x64B);
    // MOV word ptr [BP + -0x4],0x0 (18AD_0646 / 0x19116)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs11, 0x64E);
    // MOV AX,0x8000 (18AD_064B / 0x1911B)
    AX = 0x8000;
    CheckExternalEvents(cs11, 0x64F);
    // PUSH AX (18AD_064E / 0x1911E)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x652);
    // PUSH word ptr [BP + 0x8] (18AD_064F / 0x1911F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x655);
    // PUSH word ptr [BP + 0x6] (18AD_0652 / 0x19122)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x65A);
    // CALLF 0x1000:d2c0 (18AD_0655 / 0x19125)
    FarCall(cs11, 0x65A, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs11, 0x65D);
    // ADD SP,0x6 (18AD_065A / 0x1912A)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs11, 0x660);
    // MOV word ptr [BP + -0x6],AX (18AD_065D / 0x1912D)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs11, 0x663);
    // CMP AX,0xffff (18AD_0660 / 0x19130)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs11, 0x665);
    // JZ 0x1000:916a (18AD_0663 / 0x19133)
    if(ZeroFlag) {
      goto label_18AD_069A_1916A;
    }
    CheckExternalEvents(cs11, 0x668);
    // MOV AX,0x2 (18AD_0665 / 0x19135)
    AX = 0x2;
    CheckExternalEvents(cs11, 0x669);
    // PUSH AX (18AD_0668 / 0x19138)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x66C);
    // LEA AX,[BP + -0x2] (18AD_0669 / 0x19139)
    AX = (ushort)(BP - 0x2);
    CheckExternalEvents(cs11, 0x66D);
    // PUSH SS (18AD_066C / 0x1913C)
    Stack.Push16(SS);
    CheckExternalEvents(cs11, 0x66E);
    // PUSH AX (18AD_066D / 0x1913D)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x671);
    // PUSH word ptr [BP + -0x6] (18AD_066E / 0x1913E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs11, 0x676);
    // CALLF 0x1000:d470 (18AD_0671 / 0x19141)
    FarCall(cs11, 0x676, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs11, 0x679);
    // ADD SP,0x8 (18AD_0676 / 0x19146)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs11, 0x67C);
    // PUSH word ptr [BP + -0x2] (18AD_0679 / 0x19149)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs11, 0x67F);
    // PUSH word ptr [BP + 0xc] (18AD_067C / 0x1914C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x682);
    // PUSH word ptr [BP + 0xa] (18AD_067F / 0x1914F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x685);
    // PUSH word ptr [BP + -0x6] (18AD_0682 / 0x19152)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs11, 0x68A);
    // CALLF 0x1000:d470 (18AD_0685 / 0x19155)
    FarCall(cs11, 0x68A, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs11, 0x68D);
    // ADD SP,0x8 (18AD_068A / 0x1915A)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs11, 0x690);
    // PUSH word ptr [BP + -0x6] (18AD_068D / 0x1915D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs11, 0x695);
    // CALLF 0x1000:d226 (18AD_0690 / 0x19160)
    FarCall(cs11, 0x695, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs11, 0x698);
    // ADD SP,0x2 (18AD_0695 / 0x19165)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs11, 0x69A);
    // JMP 0x1000:916f (18AD_0698 / 0x19168)
    goto label_18AD_069F_1916F;
    label_18AD_069A_1916A:
    CheckExternalEvents(cs11, 0x69F);
    // MOV word ptr [BP + -0x4],0x1 (18AD_069A / 0x1916A)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_18AD_069F_1916F:
    CheckExternalEvents(cs11, 0x6A3);
    // CMP word ptr [BP + -0x4],0x0 (18AD_069F / 0x1916F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs11, 0x6A5);
    // JZ 0x1000:9186 (18AD_06A3 / 0x19173)
    if(ZeroFlag) {
      goto label_18AD_06B6_19186;
    }
    CheckExternalEvents(cs11, 0x6A9);
    // MOV ES,word ptr [0x56fa] (18AD_06A5 / 0x19175)
    ES = UInt16[DS, 0x56FA];
    CheckExternalEvents(cs11, 0x6AE);
    // PUSH word ptr ES:[0x14e] (18AD_06A9 / 0x19179)
    Stack.Push16(UInt16[ES, 0x14E]);
    CheckExternalEvents(cs11, 0x6B3);
    // CALLF 0x0000:4013 (18AD_06AE / 0x1917E)
    FarCall(cs11, 0x6B3, unknown_0170_2913_04013);
    CheckExternalEvents(cs11, 0x6B6);
    // ADD SP,0x2 (18AD_06B3 / 0x19183)
    SP += 0x2;
    label_18AD_06B6_19186:
    CheckExternalEvents(cs11, 0x6BA);
    // CMP word ptr [BP + -0x4],0x0 (18AD_06B6 / 0x19186)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs11, 0x6BC);
    // JNZ 0x1000:9116 (18AD_06BA / 0x1918A)
    if(!ZeroFlag) {
      goto label_18AD_0646_19116;
    }
    CheckExternalEvents(cs11, 0x6BF);
    // MOV AX,0x1 (18AD_06BC / 0x1918C)
    AX = 0x1;
    CheckExternalEvents(cs11, 0x6C1);
    // MOV SP,BP (18AD_06BF / 0x1918F)
    SP = BP;
    CheckExternalEvents(cs11, 0x6C2);
    // POP BP (18AD_06C1 / 0x19191)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x6C3);
    // RETF  (18AD_06C2 / 0x19192)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_06C3_19193(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_06C3_19193:
    CheckExternalEvents(cs11, 0x6C5);
    // XOR AX,AX (18AD_06C3 / 0x19193)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x6CA);
    // CALLF 0x1000:cecc (18AD_06C5 / 0x19195)
    FarCall(cs11, 0x6CA, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x6CF);
    // CMP word ptr [0x4fba],0x2 (18AD_06CA / 0x1919A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs11, 0x6D1);
    // JNZ 0x1000:91c6 (18AD_06CF / 0x1919F)
    if(!ZeroFlag) {
      goto label_18AD_06F6_191C6;
    }
    CheckExternalEvents(cs11, 0x6D4);
    // MOV AX,0xc8 (18AD_06D1 / 0x191A1)
    AX = 0xC8;
    CheckExternalEvents(cs11, 0x6D5);
    // PUSH AX (18AD_06D4 / 0x191A4)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x6D8);
    // MOV AX,0x1b (18AD_06D5 / 0x191A5)
    AX = 0x1B;
    CheckExternalEvents(cs11, 0x6D9);
    // PUSH AX (18AD_06D8 / 0x191A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x6DB);
    // SUB AX,AX (18AD_06D9 / 0x191A9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0x6DC);
    // PUSH AX (18AD_06DB / 0x191AB)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x6DF);
    // MOV AX,0xd (18AD_06DC / 0x191AC)
    AX = 0xD;
    CheckExternalEvents(cs11, 0x6E0);
    // PUSH AX (18AD_06DF / 0x191AF)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x6E2);
    // SUB AX,AX (18AD_06E0 / 0x191B0)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs11, 0x6E5);
    // MOV DX,0xa000 (18AD_06E2 / 0x191B2)
    DX = 0xA000;
    CheckExternalEvents(cs11, 0x6E6);
    // PUSH DX (18AD_06E5 / 0x191B5)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x6E7);
    // PUSH AX (18AD_06E6 / 0x191B6)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x6EA);
    // MOV DX,0xac00 (18AD_06E7 / 0x191B7)
    DX = 0xAC00;
    CheckExternalEvents(cs11, 0x6EB);
    // PUSH DX (18AD_06EA / 0x191BA)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x6EC);
    // PUSH AX (18AD_06EB / 0x191BB)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x6F1);
    // CALLF 0x1000:c34c (18AD_06EC / 0x191BC)
    FarCall(cs11, 0x6F1, unknown_19EF_245C_1C34C);
    CheckExternalEvents(cs11, 0x6F4);
    // ADD SP,0x10 (18AD_06F1 / 0x191C1)
    // SP += 0x10;
    SP = Alu16.Add(SP, 0x10);
    CheckExternalEvents(cs11, 0x6F6);
    // JMP 0x1000:91d9 (18AD_06F4 / 0x191C4)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs11, 0x70A);
    // RETF  (18AD_0709 / 0x191D9)
    return FarRet();
    label_18AD_06F6_191C6:
    CheckExternalEvents(cs11, 0x6FB);
    // CMP word ptr [0x4fba],0x3 (18AD_06F6 / 0x191C6)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs11, 0x6FD);
    // JNZ 0x1000:91d4 (18AD_06FB / 0x191CB)
    if(!ZeroFlag) {
      goto label_18AD_0704_191D4;
    }
    CheckExternalEvents(cs11, 0x702);
    // CALLF 0x1000:bc2a (18AD_06FD / 0x191CD)
    FarCall(cs11, 0x702, unknown_19EF_1D3A_1BC2A);
    CheckExternalEvents(cs11, 0x704);
    // JMP 0x1000:91d9 (18AD_0702 / 0x191D2)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs11, 0x70A);
    // RETF  (18AD_0709 / 0x191D9)
    return FarRet();
    label_18AD_0704_191D4:
    CheckExternalEvents(cs11, 0x709);
    // CALLF 0x1000:bba8 (18AD_0704 / 0x191D4)
    FarCall(cs11, 0x709, ghidra_guess_1000_BBA8_1BBA8);
    label_18AD_0709_191D9:
    CheckExternalEvents(cs11, 0x70A);
    // RETF  (18AD_0709 / 0x191D9)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_070A_191DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_070A_191DA:
    CheckExternalEvents(cs11, 0x70B);
    // PUSH BP (18AD_070A / 0x191DA)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x70D);
    // MOV BP,SP (18AD_070B / 0x191DB)
    BP = SP;
    CheckExternalEvents(cs11, 0x710);
    // MOV AX,0x8 (18AD_070D / 0x191DD)
    AX = 0x8;
    CheckExternalEvents(cs11, 0x715);
    // CALLF 0x1000:cecc (18AD_0710 / 0x191E0)
    FarCall(cs11, 0x715, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x716);
    // PUSH SI (18AD_0715 / 0x191E5)
    Stack.Push16(SI);
    CheckExternalEvents(cs11, 0x71B);
    // MOV word ptr [BP + -0x6],0x4 (18AD_0716 / 0x191E6)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x4;
    CheckExternalEvents(cs11, 0x71E);
    // MOV AX,word ptr [BP + 0xc] (18AD_071B / 0x191EB)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x721);
    // IMUL word ptr [BP + 0xe] (18AD_071E / 0x191EE)
    int resImul18AD_071E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xE)]);
    AX = (ushort)(resImul18AD_071E);
    DX = (ushort)(resImul18AD_071E >> 16);
    CheckExternalEvents(cs11, 0x724);
    // MUL word ptr [BP + -0x6] (18AD_0721 / 0x191F1)
    uint resMul18AD_0721 = Alu16.Mul(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resMul18AD_0721);
    DX = (ushort)(resMul18AD_0721 >> 16);
    CheckExternalEvents(cs11, 0x727);
    // MOV word ptr [BP + -0x6],AX (18AD_0724 / 0x191F4)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs11, 0x72A);
    // ADD AX,0x4 (18AD_0727 / 0x191F7)
    AX += 0x4;
    CheckExternalEvents(cs11, 0x72C);
    // SUB CX,CX (18AD_072A / 0x191FA)
    // CX -= CX;
    CX = Alu16.Sub(CX, CX);
    CheckExternalEvents(cs11, 0x72D);
    // PUSH CX (18AD_072C / 0x191FC)
    Stack.Push16(CX);
    CheckExternalEvents(cs11, 0x72E);
    // PUSH AX (18AD_072D / 0x191FD)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x72F);
    // PUSH CS (18AD_072E / 0x191FE)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x732);
    // CALL 0x1000:908c (18AD_072F / 0x191FF)
    NearCall(cs11, 0x732, unknown_18AD_05BC_1908C);
    CheckExternalEvents(cs11, 0x735);
    // ADD SP,0x4 (18AD_0732 / 0x19202)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs11, 0x738);
    // MOV BX,word ptr [BP + 0x6] (18AD_0735 / 0x19205)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs11, 0x73A);
    // SHL BX,0x1 (18AD_0738 / 0x19208)
    BX <<= 0x1;
    CheckExternalEvents(cs11, 0x73C);
    // SHL BX,0x1 (18AD_073A / 0x1920A)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs11, 0x740);
    // MOV ES,word ptr [0x56fc] (18AD_073C / 0x1920C)
    ES = UInt16[DS, 0x56FC];
    CheckExternalEvents(cs11, 0x745);
    // MOV word ptr ES:[BX + 0x39fa],AX (18AD_0740 / 0x19210)
    UInt16[ES, (ushort)(BX + 0x39FA)] = AX;
    CheckExternalEvents(cs11, 0x74A);
    // MOV word ptr ES:[BX + 0x39fc],DX (18AD_0745 / 0x19215)
    UInt16[ES, (ushort)(BX + 0x39FC)] = DX;
    CheckExternalEvents(cs11, 0x74D);
    // MOV word ptr [BP + -0x4],AX (18AD_074A / 0x1921A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs11, 0x750);
    // MOV word ptr [BP + -0x2],DX (18AD_074D / 0x1921D)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs11, 0x752);
    // OR AX,DX (18AD_0750 / 0x19220)
    // AX |= DX;
    AX = Alu16.Or(AX, DX);
    CheckExternalEvents(cs11, 0x754);
    // JNZ 0x1000:9227 (18AD_0752 / 0x19222)
    if(!ZeroFlag) {
      goto label_18AD_0757_19227;
    }
    CheckExternalEvents(cs11, 0x757);
    // JMP 0x1000:92df (18AD_0754 / 0x19224)
    goto label_18AD_080F_192DF;
    label_18AD_0757_19227:
    CheckExternalEvents(cs11, 0x75A);
    // LES BX,[BP + -0x4] (18AD_0757 / 0x19227)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs11, 0x75D);
    // MOV AL,byte ptr [BP + 0xe] (18AD_075A / 0x1922A)
    AL = UInt8[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs11, 0x75F);
    // DEC AL (18AD_075D / 0x1922D)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs11, 0x763);
    // MOV byte ptr ES:[BX + 0x1],AL (18AD_075F / 0x1922F)
    UInt8[ES, (ushort)(BX + 0x1)] = AL;
    CheckExternalEvents(cs11, 0x766);
    // LES BX,[BP + -0x4] (18AD_0763 / 0x19233)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs11, 0x769);
    // MOV AL,byte ptr [BP + 0xc] (18AD_0766 / 0x19236)
    AL = UInt8[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x76D);
    // MOV byte ptr ES:[BX + 0x2],AL (18AD_0769 / 0x19239)
    UInt8[ES, (ushort)(BX + 0x2)] = AL;
    CheckExternalEvents(cs11, 0x772);
    // CMP word ptr [0x4fba],0x0 (18AD_076D / 0x1923D)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs11, 0x774);
    // JNZ 0x1000:9257 (18AD_0772 / 0x19242)
    if(!ZeroFlag) {
      goto label_18AD_0787_19257;
    }
    CheckExternalEvents(cs11, 0x777);
    // SHL word ptr [BP + 0x8],0x1 (18AD_0774 / 0x19244)
    // UInt16[SS, (ushort)(BP + 0x8)] <<= 0x1;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Shl(UInt16[SS, (ushort)(BP + 0x8)], 0x1);
    CheckExternalEvents(cs11, 0x77A);
    // MOV AX,0x50 (18AD_0777 / 0x19247)
    AX = 0x50;
    CheckExternalEvents(cs11, 0x77D);
    // IMUL word ptr [BP + 0xa] (18AD_077A / 0x1924A)
    int resImul18AD_077A = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xA)]);
    AX = (ushort)(resImul18AD_077A);
    DX = (ushort)(resImul18AD_077A >> 16);
    CheckExternalEvents(cs11, 0x780);
    // MOV word ptr [BP + 0xa],AX (18AD_077D / 0x1924D)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs11, 0x785);
    // MOV word ptr [BP + -0x8],0x50 (18AD_0780 / 0x19250)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x50;
    CheckExternalEvents(cs11, 0x787);
    // JMP 0x1000:926d (18AD_0785 / 0x19255)
    goto label_18AD_079D_1926D;
    label_18AD_0787_19257:
    CheckExternalEvents(cs11, 0x789);
    // MOV CL,0x2 (18AD_0787 / 0x19257)
    CL = 0x2;
    CheckExternalEvents(cs11, 0x78C);
    // SHL word ptr [BP + 0x8],CL (18AD_0789 / 0x19259)
    // UInt16[SS, (ushort)(BP + 0x8)] <<= CL;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Shl(UInt16[SS, (ushort)(BP + 0x8)], CL);
    CheckExternalEvents(cs11, 0x78F);
    // MOV AX,0xa0 (18AD_078C / 0x1925C)
    AX = 0xA0;
    CheckExternalEvents(cs11, 0x792);
    // IMUL word ptr [BP + 0xa] (18AD_078F / 0x1925F)
    int resImul18AD_078F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xA)]);
    AX = (ushort)(resImul18AD_078F);
    DX = (ushort)(resImul18AD_078F >> 16);
    CheckExternalEvents(cs11, 0x795);
    // MOV word ptr [BP + 0xa],AX (18AD_0792 / 0x19262)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs11, 0x798);
    // SHL word ptr [BP + 0xc],0x1 (18AD_0795 / 0x19265)
    // UInt16[SS, (ushort)(BP + 0xC)] <<= 0x1;
    UInt16[SS, (ushort)(BP + 0xC)] = Alu16.Shl(UInt16[SS, (ushort)(BP + 0xC)], 0x1);
    CheckExternalEvents(cs11, 0x79D);
    // MOV word ptr [BP + -0x8],0xa0 (18AD_0798 / 0x19268)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xA0;
    label_18AD_079D_1926D:
    CheckExternalEvents(cs11, 0x7A0);
    // MOV AX,word ptr [BP + -0x8] (18AD_079D / 0x1926D)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs11, 0x7A3);
    // MOV CX,word ptr [BP + 0xc] (18AD_07A0 / 0x19270)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x7A5);
    // SHL CX,0x1 (18AD_07A3 / 0x19273)
    CX <<= 0x1;
    CheckExternalEvents(cs11, 0x7A7);
    // SUB AX,CX (18AD_07A5 / 0x19275)
    // AX -= CX;
    AX = Alu16.Sub(AX, CX);
    CheckExternalEvents(cs11, 0x7A8);
    // PUSH AX (18AD_07A7 / 0x19277)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x7AB);
    // PUSH word ptr [BP + 0xe] (18AD_07A8 / 0x19278)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x7AE);
    // PUSH word ptr [BP + 0xc] (18AD_07AB / 0x1927B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x7B1);
    // MOV AX,word ptr [BP + -0x4] (18AD_07AE / 0x1927E)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs11, 0x7B4);
    // MOV DX,word ptr [BP + -0x2] (18AD_07B1 / 0x19281)
    DX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs11, 0x7B7);
    // ADD AX,0x4 (18AD_07B4 / 0x19284)
    // AX += 0x4;
    AX = Alu16.Add(AX, 0x4);
    CheckExternalEvents(cs11, 0x7B8);
    // PUSH DX (18AD_07B7 / 0x19287)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x7B9);
    // PUSH AX (18AD_07B8 / 0x19288)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x7BC);
    // MOV SI,word ptr [BP + 0xa] (18AD_07B9 / 0x19289)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x7BF);
    // MOV BX,word ptr [BP + 0x8] (18AD_07BC / 0x1928C)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs11, 0x7C3);
    // LEA AX,[BX + SI + 0x244b] (18AD_07BF / 0x1928F)
    AX = (ushort)(BX + SI + 0x244B);
    CheckExternalEvents(cs11, 0x7C6);
    // MOV DX,0x1ddc (18AD_07C3 / 0x19293)
    DX = 0x1DDC;
    CheckExternalEvents(cs11, 0x7C7);
    // PUSH DX (18AD_07C6 / 0x19296)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x7C8);
    // PUSH AX (18AD_07C7 / 0x19297)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x7CD);
    // CALLF 0x1000:a821 (18AD_07C8 / 0x19298)
    FarCall(cs11, 0x7CD, unknown_19EF_0931_1A821);
    CheckExternalEvents(cs11, 0x7D0);
    // ADD SP,0xe (18AD_07CD / 0x1929D)
    SP += 0xE;
    CheckExternalEvents(cs11, 0x7D5);
    // CMP word ptr [0x4fba],0x0 (18AD_07D0 / 0x192A0)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs11, 0x7D7);
    // JNZ 0x1000:92df (18AD_07D5 / 0x192A5)
    if(!ZeroFlag) {
      goto label_18AD_080F_192DF;
    }
    CheckExternalEvents(cs11, 0x7DA);
    // MOV AX,word ptr [BP + -0x8] (18AD_07D7 / 0x192A7)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs11, 0x7DD);
    // MOV CX,word ptr [BP + 0xc] (18AD_07DA / 0x192AA)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs11, 0x7DF);
    // SHL CX,0x1 (18AD_07DD / 0x192AD)
    CX <<= 0x1;
    CheckExternalEvents(cs11, 0x7E1);
    // SUB AX,CX (18AD_07DF / 0x192AF)
    // AX -= CX;
    AX = Alu16.Sub(AX, CX);
    CheckExternalEvents(cs11, 0x7E2);
    // PUSH AX (18AD_07E1 / 0x192B1)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x7E5);
    // PUSH word ptr [BP + 0xe] (18AD_07E2 / 0x192B2)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x7E8);
    // PUSH word ptr [BP + 0xc] (18AD_07E5 / 0x192B5)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x7EB);
    // MOV AX,word ptr [BP + -0x6] (18AD_07E8 / 0x192B8)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs11, 0x7ED);
    // SHR AX,0x1 (18AD_07EB / 0x192BB)
    AX >>= 0x1;
    CheckExternalEvents(cs11, 0x7F0);
    // ADD AX,word ptr [BP + -0x4] (18AD_07ED / 0x192BD)
    // AX += UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs11, 0x7F3);
    // MOV DX,word ptr [BP + -0x2] (18AD_07F0 / 0x192C0)
    DX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs11, 0x7F6);
    // ADD AX,0x4 (18AD_07F3 / 0x192C3)
    // AX += 0x4;
    AX = Alu16.Add(AX, 0x4);
    CheckExternalEvents(cs11, 0x7F7);
    // PUSH DX (18AD_07F6 / 0x192C6)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x7F8);
    // PUSH AX (18AD_07F7 / 0x192C7)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x7FB);
    // MOV SI,word ptr [BP + 0xa] (18AD_07F8 / 0x192C8)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs11, 0x7FE);
    // MOV BX,word ptr [BP + 0x8] (18AD_07FB / 0x192CB)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs11, 0x802);
    // LEA AX,[BX + SI + 0x4614] (18AD_07FE / 0x192CE)
    AX = (ushort)(BX + SI + 0x4614);
    CheckExternalEvents(cs11, 0x805);
    // MOV DX,0x2a02 (18AD_0802 / 0x192D2)
    DX = 0x2A02;
    CheckExternalEvents(cs11, 0x806);
    // PUSH DX (18AD_0805 / 0x192D5)
    Stack.Push16(DX);
    CheckExternalEvents(cs11, 0x807);
    // PUSH AX (18AD_0806 / 0x192D6)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x80C);
    // CALLF 0x1000:a821 (18AD_0807 / 0x192D7)
    FarCall(cs11, 0x80C, unknown_19EF_0931_1A821);
    CheckExternalEvents(cs11, 0x80F);
    // ADD SP,0xe (18AD_080C / 0x192DC)
    // SP += 0xE;
    SP = Alu16.Add(SP, 0xE);
    label_18AD_080F_192DF:
    CheckExternalEvents(cs11, 0x810);
    // POP SI (18AD_080F / 0x192DF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x812);
    // MOV SP,BP (18AD_0810 / 0x192E0)
    SP = BP;
    CheckExternalEvents(cs11, 0x813);
    // POP BP (18AD_0812 / 0x192E2)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x814);
    // RETF  (18AD_0813 / 0x192E3)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0814_192E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0814_192E4:
    CheckExternalEvents(cs11, 0x815);
    // PUSH BP (18AD_0814 / 0x192E4)
    Stack.Push16(BP);
    CheckExternalEvents(cs11, 0x817);
    // MOV BP,SP (18AD_0815 / 0x192E5)
    BP = SP;
    CheckExternalEvents(cs11, 0x81A);
    // MOV AX,0x2 (18AD_0817 / 0x192E7)
    AX = 0x2;
    CheckExternalEvents(cs11, 0x81F);
    // CALLF 0x1000:cecc (18AD_081A / 0x192EA)
    FarCall(cs11, 0x81F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x821);
    // JMP 0x1000:9302 (18AD_081F / 0x192EF)
    goto label_18AD_0832_19302;
    label_18AD_0821_192F1:
    CheckExternalEvents(cs11, 0x825);
    // MOV ES,word ptr [0x56fa] (18AD_0821 / 0x192F1)
    ES = UInt16[DS, 0x56FA];
    CheckExternalEvents(cs11, 0x82A);
    // PUSH word ptr ES:[0x14e] (18AD_0825 / 0x192F5)
    Stack.Push16(UInt16[ES, 0x14E]);
    CheckExternalEvents(cs11, 0x82F);
    // CALLF 0x0000:4013 (18AD_082A / 0x192FA)
    FarCall(cs11, 0x82F, unknown_0170_2913_04013);
    CheckExternalEvents(cs11, 0x832);
    // ADD SP,0x2 (18AD_082F / 0x192FF)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_18AD_0832_19302:
    CheckExternalEvents(cs11, 0x835);
    // MOV AX,0x8000 (18AD_0832 / 0x19302)
    AX = 0x8000;
    CheckExternalEvents(cs11, 0x836);
    // PUSH AX (18AD_0835 / 0x19305)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x839);
    // PUSH word ptr [BP + 0x8] (18AD_0836 / 0x19306)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs11, 0x83C);
    // PUSH word ptr [BP + 0x6] (18AD_0839 / 0x19309)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs11, 0x841);
    // CALLF 0x1000:d2c0 (18AD_083C / 0x1930C)
    FarCall(cs11, 0x841, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs11, 0x844);
    // ADD SP,0x6 (18AD_0841 / 0x19311)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs11, 0x847);
    // MOV word ptr [BP + -0x2],AX (18AD_0844 / 0x19314)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs11, 0x848);
    // INC AX (18AD_0847 / 0x19317)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs11, 0x84A);
    // JZ 0x1000:92f1 (18AD_0848 / 0x19318)
    if(ZeroFlag) {
      goto label_18AD_0821_192F1;
    }
    CheckExternalEvents(cs11, 0x84D);
    // PUSH word ptr [BP + 0xe] (18AD_084A / 0x1931A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs11, 0x850);
    // PUSH word ptr [BP + 0xc] (18AD_084D / 0x1931D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs11, 0x853);
    // PUSH word ptr [BP + 0xa] (18AD_0850 / 0x19320)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs11, 0x856);
    // PUSH word ptr [BP + -0x2] (18AD_0853 / 0x19323)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs11, 0x85B);
    // CALLF 0x1000:d470 (18AD_0856 / 0x19326)
    FarCall(cs11, 0x85B, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs11, 0x85E);
    // ADD SP,0x8 (18AD_085B / 0x1932B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs11, 0x861);
    // PUSH word ptr [BP + -0x2] (18AD_085E / 0x1932E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs11, 0x866);
    // CALLF 0x1000:d226 (18AD_0861 / 0x19331)
    FarCall(cs11, 0x866, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs11, 0x868);
    // MOV SP,BP (18AD_0866 / 0x19336)
    SP = BP;
    CheckExternalEvents(cs11, 0x869);
    // POP BP (18AD_0868 / 0x19338)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs11, 0x86A);
    // RETF  (18AD_0869 / 0x19339)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_086A_1933A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_086A_1933A:
    CheckExternalEvents(cs11, 0x86C);
    // XOR AX,AX (18AD_086A / 0x1933A)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs11, 0x871);
    // CALLF 0x1000:cecc (18AD_086C / 0x1933C)
    FarCall(cs11, 0x871, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs11, 0x874);
    // MOV AX,0x32 (18AD_0871 / 0x19341)
    AX = 0x32;
    CheckExternalEvents(cs11, 0x875);
    // PUSH AX (18AD_0874 / 0x19344)
    Stack.Push16(AX);
    CheckExternalEvents(cs11, 0x876);
    // PUSH CS (18AD_0875 / 0x19345)
    Stack.Push16(cs11);
    CheckExternalEvents(cs11, 0x879);
    // CALL 0x1000:8ad6 (18AD_0876 / 0x19346)
    NearCall(cs11, 0x879, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs11, 0x87C);
    // ADD SP,0x2 (18AD_0879 / 0x19349)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs11, 0x881);
    // CALLF 0x0000:412b (18AD_087C / 0x1934C)
    FarCall(cs11, 0x881, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs11, 0x882);
    // RETF  (18AD_0881 / 0x19351)
    return FarRet();
  }
  
  public virtual Action unknown_1935_0002_19352(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_0002_19352:
    CheckExternalEvents(cs12, 0x3);
    // PUSH BP (1935_0002 / 0x19352)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x5);
    // MOV BP,SP (1935_0003 / 0x19353)
    BP = SP;
    CheckExternalEvents(cs12, 0x8);
    // MOV AX,0x4 (1935_0005 / 0x19355)
    AX = 0x4;
    CheckExternalEvents(cs12, 0xD);
    // CALLF 0x1000:cecc (1935_0008 / 0x19358)
    FarCall(cs12, 0xD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0xE);
    // PUSH SI (1935_000D / 0x1935D)
    Stack.Push16(SI);
    CheckExternalEvents(cs12, 0x11);
    // DEC word ptr [BP + 0x6] (1935_000E / 0x1935E)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs12, 0x16);
    // MOV word ptr [BP + -0x4],0x0 (1935_0011 / 0x19361)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs12, 0x18);
    // JMP 0x1000:93c2 (1935_0016 / 0x19366)
    goto label_1935_0072_193C2;
    label_1935_0018_19368:
    CheckExternalEvents(cs12, 0x1C);
    // CMP word ptr [BP + 0x6],0x0 (1935_0018 / 0x19368)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs12, 0x1E);
    // JZ 0x1000:93ce (1935_001C / 0x1936C)
    if(ZeroFlag) {
      goto label_1935_007E_193CE;
    }
    CheckExternalEvents(cs12, 0x23);
    // CMP word ptr [SI + 0x500a],0x0 (1935_001E / 0x1936E)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500A)], 0x0);
    CheckExternalEvents(cs12, 0x25);
    // JNZ 0x1000:937f (1935_0023 / 0x19373)
    if(!ZeroFlag) {
      goto label_1935_002F_1937F;
    }
    CheckExternalEvents(cs12, 0x2A);
    // CMP word ptr [SI + 0x500c],0x0 (1935_0025 / 0x19375)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500C)], 0x0);
    CheckExternalEvents(cs12, 0x2C);
    // JNZ 0x1000:937f (1935_002A / 0x1937A)
    if(!ZeroFlag) {
      goto label_1935_002F_1937F;
    }
    CheckExternalEvents(cs12, 0x2F);
    // DEC word ptr [BP + 0x6] (1935_002C / 0x1937C)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    label_1935_002F_1937F:
    CheckExternalEvents(cs12, 0x32);
    // MOV BX,word ptr [BP + -0x4] (1935_002F / 0x1937F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x34);
    // SHL BX,0x1 (1935_0032 / 0x19382)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x38);
    // MOV AX,word ptr [BX + 0x5008] (1935_0034 / 0x19384)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x3B);
    // MOV word ptr [BP + -0x2],AX (1935_0038 / 0x19388)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs12, 0x3E);
    // CMP AX,0x3e8 (1935_003B / 0x1938B)
    Alu16.Sub(AX, 0x3E8);
    CheckExternalEvents(cs12, 0x40);
    // JG 0x1000:9396 (1935_003E / 0x1938E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1935_0046_19396;
    }
    CheckExternalEvents(cs12, 0x44);
    // ADD word ptr [BP + -0x4],0x3 (1935_0040 / 0x19390)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x3;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs12, 0x46);
    // JMP 0x1000:93c2 (1935_0044 / 0x19394)
    goto label_1935_0072_193C2;
    label_1935_0046_19396:
    CheckExternalEvents(cs12, 0x4B);
    // SUB word ptr [BP + -0x2],0x3e8 (1935_0046 / 0x19396)
    UInt16[SS, (ushort)(BP - 0x2)] -= 0x3E8;
    CheckExternalEvents(cs12, 0x4F);
    // CMP word ptr [BP + -0x2],0x1 (1935_004B / 0x1939B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x1);
    CheckExternalEvents(cs12, 0x51);
    // JNZ 0x1000:93a7 (1935_004F / 0x1939F)
    if(!ZeroFlag) {
      goto label_1935_0057_193A7;
    }
    CheckExternalEvents(cs12, 0x55);
    // ADD word ptr [BP + -0x4],0x6 (1935_0051 / 0x193A1)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x6;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x6);
    CheckExternalEvents(cs12, 0x57);
    // JMP 0x1000:93c2 (1935_0055 / 0x193A5)
    goto label_1935_0072_193C2;
    label_1935_0057_193A7:
    CheckExternalEvents(cs12, 0x5B);
    // CMP word ptr [BP + -0x2],0x2 (1935_0057 / 0x193A7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x2);
    CheckExternalEvents(cs12, 0x5D);
    // JNZ 0x1000:93b3 (1935_005B / 0x193AB)
    if(!ZeroFlag) {
      goto label_1935_0063_193B3;
    }
    label_1935_005D_193AD:
    CheckExternalEvents(cs12, 0x61);
    // ADD word ptr [BP + -0x4],0x7 (1935_005D / 0x193AD)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x7;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x7);
    CheckExternalEvents(cs12, 0x63);
    // JMP 0x1000:93c2 (1935_0061 / 0x193B1)
    goto label_1935_0072_193C2;
    label_1935_0063_193B3:
    CheckExternalEvents(cs12, 0x67);
    // CMP word ptr [BP + -0x2],0x3 (1935_0063 / 0x193B3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x3);
    CheckExternalEvents(cs12, 0x69);
    // JZ 0x1000:93ad (1935_0067 / 0x193B7)
    if(ZeroFlag) {
      goto label_1935_005D_193AD;
    }
    CheckExternalEvents(cs12, 0x6D);
    // CMP word ptr [BP + -0x2],0x4 (1935_0069 / 0x193B9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs12, 0x6F);
    // JZ 0x1000:93ad (1935_006D / 0x193BD)
    if(ZeroFlag) {
      goto label_1935_005D_193AD;
    }
    CheckExternalEvents(cs12, 0x72);
    // INC word ptr [BP + -0x4] (1935_006F / 0x193BF)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1935_0072_193C2:
    CheckExternalEvents(cs12, 0x75);
    // MOV SI,word ptr [BP + -0x4] (1935_0072 / 0x193C2)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x77);
    // SHL SI,0x1 (1935_0075 / 0x193C5)
    SI <<= 0x1;
    CheckExternalEvents(cs12, 0x7C);
    // CMP word ptr [SI + 0x5008],0x0 (1935_0077 / 0x193C7)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x5008)], 0x0);
    CheckExternalEvents(cs12, 0x7E);
    // JNZ 0x1000:9368 (1935_007C / 0x193CC)
    if(!ZeroFlag) {
      goto label_1935_0018_19368;
    }
    label_1935_007E_193CE:
    CheckExternalEvents(cs12, 0x82);
    // CMP word ptr [BP + 0x6],0x0 (1935_007E / 0x193CE)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs12, 0x84);
    // JZ 0x1000:93d7 (1935_0082 / 0x193D2)
    if(ZeroFlag) {
      goto label_1935_0087_193D7;
    }
    CheckExternalEvents(cs12, 0x87);
    // JMP 0x1000:95ee (1935_0084 / 0x193D4)
    goto label_1935_029E_195EE;
    label_1935_0087_193D7:
    CheckExternalEvents(cs12, 0x8A);
    // MOV AX,word ptr [BP + -0x4] (1935_0087 / 0x193D7)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    label_1935_008A_193DA:
    CheckExternalEvents(cs12, 0x8D);
    // MOV SI,word ptr [BP + -0x4] (1935_008A / 0x193DA)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x8F);
    // SHL SI,0x1 (1935_008D / 0x193DD)
    SI <<= 0x1;
    CheckExternalEvents(cs12, 0x94);
    // CMP word ptr [SI + 0x500a],0x0 (1935_008F / 0x193DF)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500A)], 0x0);
    CheckExternalEvents(cs12, 0x96);
    // JNZ 0x1000:93f0 (1935_0094 / 0x193E4)
    if(!ZeroFlag) {
      goto label_1935_00A0_193F0;
    }
    CheckExternalEvents(cs12, 0x9B);
    // CMP word ptr [SI + 0x500c],0x0 (1935_0096 / 0x193E6)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500C)], 0x0);
    CheckExternalEvents(cs12, 0x9D);
    // JNZ 0x1000:93f0 (1935_009B / 0x193EB)
    if(!ZeroFlag) {
      goto label_1935_00A0_193F0;
    }
    CheckExternalEvents(cs12, 0xA0);
    // JMP 0x1000:95ee (1935_009D / 0x193ED)
    goto label_1935_029E_195EE;
    label_1935_00A0_193F0:
    CheckExternalEvents(cs12, 0xA4);
    // MOV ES,word ptr [0x56fe] (1935_00A0 / 0x193F0)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0xA7);
    // MOV BX,word ptr [BP + -0x4] (1935_00A4 / 0x193F4)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0xAA);
    // INC word ptr [BP + -0x4] (1935_00A7 / 0x193F7)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0xAC);
    // SHL BX,0x1 (1935_00AA / 0x193FA)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0xB0);
    // MOV AX,word ptr [BX + 0x5008] (1935_00AC / 0x193FC)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0xB4);
    // MOV ES:[0x4612],AX (1935_00B0 / 0x19400)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs12, 0xB7);
    // CMP AX,0x3e8 (1935_00B4 / 0x19404)
    Alu16.Sub(AX, 0x3E8);
    CheckExternalEvents(cs12, 0xB9);
    // JG 0x1000:9437 (1935_00B7 / 0x19407)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1935_00E7_19437;
    }
    CheckExternalEvents(cs12, 0xBD);
    // MOV ES,word ptr [0x5700] (1935_00B9 / 0x19409)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs12, 0xC0);
    // MOV BX,word ptr [BP + -0x4] (1935_00BD / 0x1940D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0xC3);
    // INC word ptr [BP + -0x4] (1935_00C0 / 0x19410)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0xC5);
    // SHL BX,0x1 (1935_00C3 / 0x19413)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0xC9);
    // MOV AX,word ptr [BX + 0x5008] (1935_00C5 / 0x19415)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0xCD);
    // MOV ES:[0x3984],AX (1935_00C9 / 0x19419)
    UInt16[ES, 0x3984] = AX;
    CheckExternalEvents(cs12, 0xD1);
    // MOV ES,word ptr [0x5702] (1935_00CD / 0x1941D)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs12, 0xD4);
    // MOV BX,word ptr [BP + -0x4] (1935_00D1 / 0x19421)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0xD7);
    // INC word ptr [BP + -0x4] (1935_00D4 / 0x19424)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0xD9);
    // SHL BX,0x1 (1935_00D7 / 0x19427)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0xDD);
    // MOV AX,word ptr [BX + 0x5008] (1935_00D9 / 0x19429)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0xE1);
    // MOV ES:[0xe48c],AX (1935_00DD / 0x1942D)
    UInt16[ES, 0xE48C] = AX;
    CheckExternalEvents(cs12, 0xE2);
    // PUSH CS (1935_00E1 / 0x19431)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0xE5);
    // CALL 0x1000:95f3 (1935_00E2 / 0x19432)
    NearCall(cs12, 0xE5, ghidra_guess_1000_95F3_195F3);
    CheckExternalEvents(cs12, 0xE7);
    // JMP 0x1000:93da (1935_00E5 / 0x19435)
    goto label_1935_008A_193DA;
    label_1935_00E7_19437:
    CheckExternalEvents(cs12, 0xEB);
    // MOV ES,word ptr [0x56fe] (1935_00E7 / 0x19437)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0xF2);
    // SUB word ptr ES:[0x4612],0x3e8 (1935_00EB / 0x1943B)
    UInt16[ES, 0x4612] -= 0x3E8;
    CheckExternalEvents(cs12, 0xF8);
    // CMP word ptr ES:[0x4612],0x1 (1935_00F2 / 0x19442)
    Alu16.Sub(UInt16[ES, 0x4612], 0x1);
    CheckExternalEvents(cs12, 0xFA);
    // JNZ 0x1000:94b1 (1935_00F8 / 0x19448)
    if(!ZeroFlag) {
      goto label_1935_0161_194B1;
    }
    CheckExternalEvents(cs12, 0xFD);
    // MOV BX,word ptr [BP + -0x4] (1935_00FA / 0x1944A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x100);
    // INC word ptr [BP + -0x4] (1935_00FD / 0x1944D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x102);
    // SHL BX,0x1 (1935_0100 / 0x19450)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x106);
    // MOV AX,word ptr [BX + 0x5008] (1935_0102 / 0x19452)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x10A);
    // MOV ES:[0x4612],AX (1935_0106 / 0x19456)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs12, 0x10E);
    // MOV ES,word ptr [0x5704] (1935_010A / 0x1945A)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs12, 0x111);
    // MOV BX,word ptr [BP + -0x4] (1935_010E / 0x1945E)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x114);
    // INC word ptr [BP + -0x4] (1935_0111 / 0x19461)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x116);
    // SHL BX,0x1 (1935_0114 / 0x19464)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x11A);
    // MOV AX,word ptr [BX + 0x5008] (1935_0116 / 0x19466)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x11E);
    // MOV ES:[0x6c],AX (1935_011A / 0x1946A)
    UInt16[ES, 0x6C] = AX;
    CheckExternalEvents(cs12, 0x122);
    // MOV ES,word ptr [0x5706] (1935_011E / 0x1946E)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs12, 0x125);
    // MOV BX,word ptr [BP + -0x4] (1935_0122 / 0x19472)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x128);
    // INC word ptr [BP + -0x4] (1935_0125 / 0x19475)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x12A);
    // SHL BX,0x1 (1935_0128 / 0x19478)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x12E);
    // MOV AX,word ptr [BX + 0x5008] (1935_012A / 0x1947A)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x132);
    // MOV ES:[0x3776],AX (1935_012E / 0x1947E)
    UInt16[ES, 0x3776] = AX;
    CheckExternalEvents(cs12, 0x136);
    // MOV ES,word ptr [0x5708] (1935_0132 / 0x19482)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs12, 0x139);
    // MOV BX,word ptr [BP + -0x4] (1935_0136 / 0x19486)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x13C);
    // INC word ptr [BP + -0x4] (1935_0139 / 0x19489)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x13E);
    // SHL BX,0x1 (1935_013C / 0x1948C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x142);
    // MOV AX,word ptr [BX + 0x5008] (1935_013E / 0x1948E)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x146);
    // MOV ES:[0x4312],AX (1935_0142 / 0x19492)
    UInt16[ES, 0x4312] = AX;
    CheckExternalEvents(cs12, 0x14A);
    // MOV ES,word ptr [0x570a] (1935_0146 / 0x19496)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs12, 0x14D);
    // MOV BX,word ptr [BP + -0x4] (1935_014A / 0x1949A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x150);
    // INC word ptr [BP + -0x4] (1935_014D / 0x1949D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x152);
    // SHL BX,0x1 (1935_0150 / 0x194A0)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x156);
    // MOV AX,word ptr [BX + 0x5008] (1935_0152 / 0x194A2)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x15A);
    // MOV ES:[0x398a],AX (1935_0156 / 0x194A6)
    UInt16[ES, 0x398A] = AX;
    CheckExternalEvents(cs12, 0x15B);
    // PUSH CS (1935_015A / 0x194AA)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x15E);
    // CALL 0x1000:963b (1935_015B / 0x194AB)
    NearCall(cs12, 0x15E, ghidra_guess_1000_963B_1963B);
    CheckExternalEvents(cs12, 0x161);
    // JMP 0x1000:93da (1935_015E / 0x194AE)
    goto label_1935_008A_193DA;
    label_1935_0161_194B1:
    CheckExternalEvents(cs12, 0x165);
    // MOV ES,word ptr [0x56fe] (1935_0161 / 0x194B1)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0x16B);
    // CMP word ptr ES:[0x4612],0x2 (1935_0165 / 0x194B5)
    Alu16.Sub(UInt16[ES, 0x4612], 0x2);
    CheckExternalEvents(cs12, 0x16D);
    // JNZ 0x1000:9538 (1935_016B / 0x194BB)
    if(!ZeroFlag) {
      goto label_1935_01E8_19538;
    }
    CheckExternalEvents(cs12, 0x170);
    // MOV BX,word ptr [BP + -0x4] (1935_016D / 0x194BD)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x173);
    // INC word ptr [BP + -0x4] (1935_0170 / 0x194C0)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x175);
    // SHL BX,0x1 (1935_0173 / 0x194C3)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x179);
    // MOV AX,word ptr [BX + 0x5008] (1935_0175 / 0x194C5)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x17D);
    // MOV ES:[0x4612],AX (1935_0179 / 0x194C9)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs12, 0x181);
    // MOV ES,word ptr [0x570c] (1935_017D / 0x194CD)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs12, 0x184);
    // MOV BX,word ptr [BP + -0x4] (1935_0181 / 0x194D1)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x187);
    // INC word ptr [BP + -0x4] (1935_0184 / 0x194D4)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x189);
    // SHL BX,0x1 (1935_0187 / 0x194D7)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x18D);
    // MOV AX,word ptr [BX + 0x5008] (1935_0189 / 0x194D9)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x191);
    // MOV ES:[0x0],AX (1935_018D / 0x194DD)
    UInt16[ES, 0x0] = AX;
    CheckExternalEvents(cs12, 0x195);
    // MOV ES,word ptr [0x570e] (1935_0191 / 0x194E1)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs12, 0x198);
    // MOV BX,word ptr [BP + -0x4] (1935_0195 / 0x194E5)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x19B);
    // INC word ptr [BP + -0x4] (1935_0198 / 0x194E8)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x19D);
    // SHL BX,0x1 (1935_019B / 0x194EB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x1A1);
    // MOV AX,word ptr [BX + 0x5008] (1935_019D / 0x194ED)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x1A5);
    // MOV ES:[0x39f4],AX (1935_01A1 / 0x194F1)
    UInt16[ES, 0x39F4] = AX;
    CheckExternalEvents(cs12, 0x1A9);
    // MOV ES,word ptr [0x5710] (1935_01A5 / 0x194F5)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs12, 0x1AC);
    // MOV BX,word ptr [BP + -0x4] (1935_01A9 / 0x194F9)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x1AF);
    // INC word ptr [BP + -0x4] (1935_01AC / 0x194FC)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x1B1);
    // SHL BX,0x1 (1935_01AF / 0x194FF)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x1B5);
    // MOV AX,word ptr [BX + 0x5008] (1935_01B1 / 0x19501)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x1B9);
    // MOV ES:[0x4000],AX (1935_01B5 / 0x19505)
    UInt16[ES, 0x4000] = AX;
    CheckExternalEvents(cs12, 0x1BD);
    // MOV ES,word ptr [0x5712] (1935_01B9 / 0x19509)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs12, 0x1C0);
    // MOV BX,word ptr [BP + -0x4] (1935_01BD / 0x1950D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x1C3);
    // INC word ptr [BP + -0x4] (1935_01C0 / 0x19510)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x1C5);
    // SHL BX,0x1 (1935_01C3 / 0x19513)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x1C9);
    // MOV AX,word ptr [BX + 0x5008] (1935_01C5 / 0x19515)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x1CD);
    // MOV ES:[0x4034],AX (1935_01C9 / 0x19519)
    UInt16[ES, 0x4034] = AX;
    CheckExternalEvents(cs12, 0x1D1);
    // MOV ES,word ptr [0x5714] (1935_01CD / 0x1951D)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs12, 0x1D4);
    // MOV BX,word ptr [BP + -0x4] (1935_01D1 / 0x19521)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x1D7);
    // INC word ptr [BP + -0x4] (1935_01D4 / 0x19524)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x1D9);
    // SHL BX,0x1 (1935_01D7 / 0x19527)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x1DD);
    // MOV AX,word ptr [BX + 0x5008] (1935_01D9 / 0x19529)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x1E1);
    // MOV ES:[0x62],AX (1935_01DD / 0x1952D)
    UInt16[ES, 0x62] = AX;
    CheckExternalEvents(cs12, 0x1E2);
    // PUSH CS (1935_01E1 / 0x19531)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x1E5);
    // CALL 0x1000:9695 (1935_01E2 / 0x19532)
    NearCall(cs12, 0x1E5, ghidra_guess_1000_9695_19695);
    CheckExternalEvents(cs12, 0x1E8);
    // JMP 0x1000:93da (1935_01E5 / 0x19535)
    goto label_1935_008A_193DA;
    label_1935_01E8_19538:
    CheckExternalEvents(cs12, 0x1EC);
    // MOV ES,word ptr [0x56fe] (1935_01E8 / 0x19538)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0x1F2);
    // CMP word ptr ES:[0x4612],0x3 (1935_01EC / 0x1953C)
    Alu16.Sub(UInt16[ES, 0x4612], 0x3);
    CheckExternalEvents(cs12, 0x1F4);
    // JZ 0x1000:954f (1935_01F2 / 0x19542)
    if(ZeroFlag) {
      goto label_1935_01FF_1954F;
    }
    CheckExternalEvents(cs12, 0x1FA);
    // CMP word ptr ES:[0x4612],0x4 (1935_01F4 / 0x19544)
    Alu16.Sub(UInt16[ES, 0x4612], 0x4);
    CheckExternalEvents(cs12, 0x1FC);
    // JZ 0x1000:954f (1935_01FA / 0x1954A)
    if(ZeroFlag) {
      goto label_1935_01FF_1954F;
    }
    CheckExternalEvents(cs12, 0x1FF);
    // JMP 0x1000:93da (1935_01FC / 0x1954C)
    goto label_1935_008A_193DA;
    label_1935_01FF_1954F:
    CheckExternalEvents(cs12, 0x202);
    // MOV BX,word ptr [BP + -0x4] (1935_01FF / 0x1954F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x205);
    // INC word ptr [BP + -0x4] (1935_0202 / 0x19552)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x207);
    // SHL BX,0x1 (1935_0205 / 0x19555)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x20B);
    // MOV AX,word ptr [BX + 0x5008] (1935_0207 / 0x19557)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x20E);
    // MOV word ptr [BP + -0x2],AX (1935_020B / 0x1955B)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs12, 0x212);
    // MOV ES,word ptr [0x5716] (1935_020E / 0x1955E)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x215);
    // MOV BX,word ptr [BP + -0x4] (1935_0212 / 0x19562)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x218);
    // INC word ptr [BP + -0x4] (1935_0215 / 0x19565)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x21A);
    // SHL BX,0x1 (1935_0218 / 0x19568)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x21E);
    // MOV AX,word ptr [BX + 0x5008] (1935_021A / 0x1956A)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x222);
    // MOV ES:[0x398c],AX (1935_021E / 0x1956E)
    UInt16[ES, 0x398C] = AX;
    CheckExternalEvents(cs12, 0x226);
    // MOV ES,word ptr [0x5718] (1935_0222 / 0x19572)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x229);
    // MOV BX,word ptr [BP + -0x4] (1935_0226 / 0x19576)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x22C);
    // INC word ptr [BP + -0x4] (1935_0229 / 0x19579)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x22E);
    // SHL BX,0x1 (1935_022C / 0x1957C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x232);
    // MOV AX,word ptr [BX + 0x5008] (1935_022E / 0x1957E)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x236);
    // MOV ES:[0x39a2],AX (1935_0232 / 0x19582)
    UInt16[ES, 0x39A2] = AX;
    CheckExternalEvents(cs12, 0x23A);
    // MOV ES,word ptr [0x571a] (1935_0236 / 0x19586)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x23D);
    // MOV BX,word ptr [BP + -0x4] (1935_023A / 0x1958A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x240);
    // INC word ptr [BP + -0x4] (1935_023D / 0x1958D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x242);
    // SHL BX,0x1 (1935_0240 / 0x19590)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x246);
    // MOV AX,word ptr [BX + 0x5008] (1935_0242 / 0x19592)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x24A);
    // MOV ES:[0x39f6],AX (1935_0246 / 0x19596)
    UInt16[ES, 0x39F6] = AX;
    CheckExternalEvents(cs12, 0x24E);
    // MOV ES,word ptr [0x571c] (1935_024A / 0x1959A)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x251);
    // MOV BX,word ptr [BP + -0x4] (1935_024E / 0x1959E)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x254);
    // INC word ptr [BP + -0x4] (1935_0251 / 0x195A1)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x256);
    // SHL BX,0x1 (1935_0254 / 0x195A4)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x25A);
    // MOV AX,word ptr [BX + 0x5008] (1935_0256 / 0x195A6)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x25E);
    // MOV ES:[0x3ff2],AX (1935_025A / 0x195AA)
    UInt16[ES, 0x3FF2] = AX;
    CheckExternalEvents(cs12, 0x262);
    // MOV ES,word ptr [0x571e] (1935_025E / 0x195AE)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x265);
    // MOV BX,word ptr [BP + -0x4] (1935_0262 / 0x195B2)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs12, 0x268);
    // INC word ptr [BP + -0x4] (1935_0265 / 0x195B5)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs12, 0x26A);
    // SHL BX,0x1 (1935_0268 / 0x195B8)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs12, 0x26E);
    // MOV AX,word ptr [BX + 0x5008] (1935_026A / 0x195BA)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs12, 0x272);
    // MOV ES:[0x9c],AX (1935_026E / 0x195BE)
    UInt16[ES, 0x9C] = AX;
    CheckExternalEvents(cs12, 0x276);
    // MOV ES,word ptr [0x56fe] (1935_0272 / 0x195C2)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0x27C);
    // CMP word ptr ES:[0x4612],0x3 (1935_0276 / 0x195C6)
    Alu16.Sub(UInt16[ES, 0x4612], 0x3);
    CheckExternalEvents(cs12, 0x27E);
    // JNZ 0x1000:95dc (1935_027C / 0x195CC)
    if(!ZeroFlag) {
      goto label_1935_028C_195DC;
    }
    CheckExternalEvents(cs12, 0x281);
    // MOV AX,word ptr [BP + -0x2] (1935_027E / 0x195CE)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs12, 0x285);
    // MOV ES:[0x4612],AX (1935_0281 / 0x195D1)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs12, 0x286);
    // PUSH CS (1935_0285 / 0x195D5)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x289);
    // CALL 0x1000:96f8 (1935_0286 / 0x195D6)
    NearCall(cs12, 0x289, unknown_1935_03A8_196F8);
    CheckExternalEvents(cs12, 0x28C);
    // JMP 0x1000:93da (1935_0289 / 0x195D9)
    goto label_1935_008A_193DA;
    label_1935_028C_195DC:
    CheckExternalEvents(cs12, 0x290);
    // MOV ES,word ptr [0x56fe] (1935_028C / 0x195DC)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0x293);
    // MOV AX,word ptr [BP + -0x2] (1935_0290 / 0x195E0)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs12, 0x297);
    // MOV ES:[0x4612],AX (1935_0293 / 0x195E3)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs12, 0x298);
    // PUSH CS (1935_0297 / 0x195E7)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x29B);
    // CALL 0x1000:975b (1935_0298 / 0x195E8)
    NearCall(cs12, 0x29B, unknown_1935_040B_1975B);
    CheckExternalEvents(cs12, 0x29E);
    // JMP 0x1000:93da (1935_029B / 0x195EB)
    goto label_1935_008A_193DA;
    label_1935_029E_195EE:
    CheckExternalEvents(cs12, 0x29F);
    // POP SI (1935_029E / 0x195EE)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x2A1);
    // MOV SP,BP (1935_029F / 0x195EF)
    SP = BP;
    CheckExternalEvents(cs12, 0x2A2);
    // POP BP (1935_02A1 / 0x195F1)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x2A3);
    // RETF  (1935_02A2 / 0x195F2)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_95F3_195F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95F3_195F3:
    CheckExternalEvents(cs8, 0x95F4);
    // PUSH BP (1000_95F3 / 0x195F3)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x95F6);
    // MOV BP,SP (1000_95F4 / 0x195F4)
    BP = SP;
    CheckExternalEvents(cs8, 0x95F9);
    // MOV AX,0x2 (1000_95F6 / 0x195F6)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x95FE);
    // CALLF 0x1000:cecc (1000_95F9 / 0x195F9)
    FarCall(cs8, 0x95FE, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x95FF);
    // PUSH CS (1000_95FE / 0x195FE)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x9602);
    // CALL 0x1000:97be (1000_95FF / 0x195FF)
    NearCall(cs8, 0x9602, unknown_1935_046E_197BE);
    CheckExternalEvents(cs8, 0x9607);
    // MOV word ptr [BP + -0x2],0x0 (1000_9602 / 0x19602)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x9609);
    // JMP 0x1000:9625 (1000_9607 / 0x19607)
    goto label_1000_9625_19625;
    label_1000_9609_19609:
    CheckExternalEvents(cs8, 0x960D);
    // MOV ES,word ptr [0x5702] (1000_9609 / 0x19609)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs8, 0x9612);
    // PUSH word ptr ES:[0xe48c] (1000_960D / 0x1960D)
    Stack.Push16(UInt16[ES, 0xE48C]);
    CheckExternalEvents(cs8, 0x9616);
    // MOV ES,word ptr [0x5700] (1000_9612 / 0x19612)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs8, 0x961B);
    // PUSH word ptr ES:[0x3984] (1000_9616 / 0x19616)
    Stack.Push16(UInt16[ES, 0x3984]);
    CheckExternalEvents(cs8, 0x961C);
    // PUSH CS (1000_961B / 0x1961B)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x961F);
    // CALL 0x1000:97cb (1000_961C / 0x1961C)
    NearCall(cs8, 0x961F, ghidra_guess_1000_97CB_197CB);
    CheckExternalEvents(cs8, 0x9622);
    // ADD SP,0x4 (1000_961F / 0x1961F)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x9625);
    // INC word ptr [BP + -0x2] (1000_9622 / 0x19622)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9625_19625:
    CheckExternalEvents(cs8, 0x9629);
    // MOV ES,word ptr [0x56fe] (1000_9625 / 0x19625)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs8, 0x962C);
    // MOV AX,word ptr [BP + -0x2] (1000_9629 / 0x19629)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x9631);
    // CMP word ptr ES:[0x4612],AX (1000_962C / 0x1962C)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs8, 0x9633);
    // JG 0x1000:9609 (1000_9631 / 0x19631)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9609_19609;
    }
    CheckExternalEvents(cs8, 0x9634);
    // PUSH CS (1000_9633 / 0x19633)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x9637);
    // CALL 0x1000:9834 (1000_9634 / 0x19634)
    NearCall(cs8, 0x9637, unknown_1935_04E4_19834);
    CheckExternalEvents(cs8, 0x9639);
    // MOV SP,BP (1000_9637 / 0x19637)
    SP = BP;
    CheckExternalEvents(cs8, 0x963A);
    // POP BP (1000_9639 / 0x19639)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x963B);
    // RETF  (1000_963A / 0x1963A)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_963B_1963B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_963B_1963B:
    CheckExternalEvents(cs8, 0x963C);
    // PUSH BP (1000_963B / 0x1963B)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x963E);
    // MOV BP,SP (1000_963C / 0x1963C)
    BP = SP;
    CheckExternalEvents(cs8, 0x9641);
    // MOV AX,0x2 (1000_963E / 0x1963E)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x9646);
    // CALLF 0x1000:cecc (1000_9641 / 0x19641)
    FarCall(cs8, 0x9646, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x9647);
    // PUSH CS (1000_9646 / 0x19646)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x964A);
    // CALL 0x1000:97be (1000_9647 / 0x19647)
    NearCall(cs8, 0x964A, unknown_1935_046E_197BE);
    CheckExternalEvents(cs8, 0x964F);
    // MOV word ptr [BP + -0x2],0x0 (1000_964A / 0x1964A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x9651);
    // JMP 0x1000:967f (1000_964F / 0x1964F)
    goto label_1000_967F_1967F;
    label_1000_9651_19651:
    CheckExternalEvents(cs8, 0x9655);
    // MOV ES,word ptr [0x570a] (1000_9651 / 0x19651)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs8, 0x965A);
    // PUSH word ptr ES:[0x398a] (1000_9655 / 0x19655)
    Stack.Push16(UInt16[ES, 0x398A]);
    CheckExternalEvents(cs8, 0x965E);
    // MOV ES,word ptr [0x5708] (1000_965A / 0x1965A)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs8, 0x9663);
    // PUSH word ptr ES:[0x4312] (1000_965E / 0x1965E)
    Stack.Push16(UInt16[ES, 0x4312]);
    CheckExternalEvents(cs8, 0x9667);
    // MOV ES,word ptr [0x5706] (1000_9663 / 0x19663)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs8, 0x966C);
    // PUSH word ptr ES:[0x3776] (1000_9667 / 0x19667)
    Stack.Push16(UInt16[ES, 0x3776]);
    CheckExternalEvents(cs8, 0x9670);
    // MOV ES,word ptr [0x5704] (1000_966C / 0x1966C)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs8, 0x9675);
    // PUSH word ptr ES:[0x6c] (1000_9670 / 0x19670)
    Stack.Push16(UInt16[ES, 0x6C]);
    CheckExternalEvents(cs8, 0x9676);
    // PUSH CS (1000_9675 / 0x19675)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x9679);
    // CALL 0x1000:98ea (1000_9676 / 0x19676)
    NearCall(cs8, 0x9679, ghidra_guess_1000_98EA_198EA);
    CheckExternalEvents(cs8, 0x967C);
    // ADD SP,0x8 (1000_9679 / 0x19679)
    SP += 0x8;
    CheckExternalEvents(cs8, 0x967F);
    // INC word ptr [BP + -0x2] (1000_967C / 0x1967C)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_967F_1967F:
    CheckExternalEvents(cs8, 0x9683);
    // MOV ES,word ptr [0x56fe] (1000_967F / 0x1967F)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs8, 0x9686);
    // MOV AX,word ptr [BP + -0x2] (1000_9683 / 0x19683)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x968B);
    // CMP word ptr ES:[0x4612],AX (1000_9686 / 0x19686)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs8, 0x968D);
    // JG 0x1000:9651 (1000_968B / 0x1968B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9651_19651;
    }
    CheckExternalEvents(cs8, 0x968E);
    // PUSH CS (1000_968D / 0x1968D)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x9691);
    // CALL 0x1000:9834 (1000_968E / 0x1968E)
    NearCall(cs8, 0x9691, unknown_1935_04E4_19834);
    CheckExternalEvents(cs8, 0x9693);
    // MOV SP,BP (1000_9691 / 0x19691)
    SP = BP;
    CheckExternalEvents(cs8, 0x9694);
    // POP BP (1000_9693 / 0x19693)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9695);
    // RETF  (1000_9694 / 0x19694)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9695_19695(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9695_19695:
    CheckExternalEvents(cs8, 0x9696);
    // PUSH BP (1000_9695 / 0x19695)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x9698);
    // MOV BP,SP (1000_9696 / 0x19696)
    BP = SP;
    CheckExternalEvents(cs8, 0x969B);
    // MOV AX,0x2 (1000_9698 / 0x19698)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x96A0);
    // CALLF 0x1000:cecc (1000_969B / 0x1969B)
    FarCall(cs8, 0x96A0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x96A1);
    // PUSH CS (1000_96A0 / 0x196A0)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x96A4);
    // CALL 0x1000:97be (1000_96A1 / 0x196A1)
    NearCall(cs8, 0x96A4, unknown_1935_046E_197BE);
    CheckExternalEvents(cs8, 0x96A9);
    // MOV word ptr [BP + -0x2],0x0 (1000_96A4 / 0x196A4)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x96AB);
    // JMP 0x1000:96e2 (1000_96A9 / 0x196A9)
    goto label_1000_96E2_196E2;
    label_1000_96AB_196AB:
    CheckExternalEvents(cs8, 0x96AF);
    // MOV ES,word ptr [0x5714] (1000_96AB / 0x196AB)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs8, 0x96B4);
    // PUSH word ptr ES:[0x62] (1000_96AF / 0x196AF)
    Stack.Push16(UInt16[ES, 0x62]);
    CheckExternalEvents(cs8, 0x96B8);
    // MOV ES,word ptr [0x5712] (1000_96B4 / 0x196B4)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs8, 0x96BD);
    // PUSH word ptr ES:[0x4034] (1000_96B8 / 0x196B8)
    Stack.Push16(UInt16[ES, 0x4034]);
    CheckExternalEvents(cs8, 0x96C1);
    // MOV ES,word ptr [0x5710] (1000_96BD / 0x196BD)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs8, 0x96C6);
    // PUSH word ptr ES:[0x4000] (1000_96C1 / 0x196C1)
    Stack.Push16(UInt16[ES, 0x4000]);
    CheckExternalEvents(cs8, 0x96CA);
    // MOV ES,word ptr [0x570e] (1000_96C6 / 0x196C6)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs8, 0x96CF);
    // PUSH word ptr ES:[0x39f4] (1000_96CA / 0x196CA)
    Stack.Push16(UInt16[ES, 0x39F4]);
    CheckExternalEvents(cs8, 0x96D3);
    // MOV ES,word ptr [0x570c] (1000_96CF / 0x196CF)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs8, 0x96D8);
    // PUSH word ptr ES:[0x0] (1000_96D3 / 0x196D3)
    Stack.Push16(UInt16[ES, 0x0]);
    CheckExternalEvents(cs8, 0x96D9);
    // PUSH CS (1000_96D8 / 0x196D8)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x96DC);
    // CALL 0x1000:9993 (1000_96D9 / 0x196D9)
    NearCall(cs8, 0x96DC, ghidra_guess_1000_9993_19993);
    CheckExternalEvents(cs8, 0x96DF);
    // ADD SP,0xa (1000_96DC / 0x196DC)
    SP += 0xA;
    CheckExternalEvents(cs8, 0x96E2);
    // INC word ptr [BP + -0x2] (1000_96DF / 0x196DF)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_96E2_196E2:
    CheckExternalEvents(cs8, 0x96E6);
    // MOV ES,word ptr [0x56fe] (1000_96E2 / 0x196E2)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs8, 0x96E9);
    // MOV AX,word ptr [BP + -0x2] (1000_96E6 / 0x196E6)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x96EE);
    // CMP word ptr ES:[0x4612],AX (1000_96E9 / 0x196E9)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs8, 0x96F0);
    // JG 0x1000:96ab (1000_96EE / 0x196EE)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_96AB_196AB;
    }
    CheckExternalEvents(cs8, 0x96F1);
    // PUSH CS (1000_96F0 / 0x196F0)
    Stack.Push16(cs8);
    CheckExternalEvents(cs8, 0x96F4);
    // CALL 0x1000:9834 (1000_96F1 / 0x196F1)
    NearCall(cs8, 0x96F4, unknown_1935_04E4_19834);
    CheckExternalEvents(cs8, 0x96F6);
    // MOV SP,BP (1000_96F4 / 0x196F4)
    SP = BP;
    CheckExternalEvents(cs8, 0x96F7);
    // POP BP (1000_96F6 / 0x196F6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x96F8);
    // RETF  (1000_96F7 / 0x196F7)
    return FarRet();
  }
  
  public virtual Action unknown_1935_03A8_196F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_03A8_196F8:
    CheckExternalEvents(cs12, 0x3A9);
    // PUSH BP (1935_03A8 / 0x196F8)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x3AB);
    // MOV BP,SP (1935_03A9 / 0x196F9)
    BP = SP;
    CheckExternalEvents(cs12, 0x3AE);
    // MOV AX,0x2 (1935_03AB / 0x196FB)
    AX = 0x2;
    CheckExternalEvents(cs12, 0x3B3);
    // CALLF 0x1000:cecc (1935_03AE / 0x196FE)
    FarCall(cs12, 0x3B3, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x3B4);
    // PUSH CS (1935_03B3 / 0x19703)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x3B7);
    // CALL 0x1000:97be (1935_03B4 / 0x19704)
    NearCall(cs12, 0x3B7, unknown_1935_046E_197BE);
    CheckExternalEvents(cs12, 0x3BC);
    // MOV word ptr [BP + -0x2],0x0 (1935_03B7 / 0x19707)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs12, 0x3BE);
    // JMP 0x1000:9745 (1935_03BC / 0x1970C)
    goto label_1935_03F5_19745;
    label_1935_03BE_1970E:
    CheckExternalEvents(cs12, 0x3C2);
    // MOV ES,word ptr [0x571e] (1935_03BE / 0x1970E)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x3C7);
    // PUSH word ptr ES:[0x9c] (1935_03C2 / 0x19712)
    Stack.Push16(UInt16[ES, 0x9C]);
    CheckExternalEvents(cs12, 0x3CB);
    // MOV ES,word ptr [0x571c] (1935_03C7 / 0x19717)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x3D0);
    // PUSH word ptr ES:[0x3ff2] (1935_03CB / 0x1971B)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs12, 0x3D4);
    // MOV ES,word ptr [0x571a] (1935_03D0 / 0x19720)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x3D9);
    // PUSH word ptr ES:[0x39f6] (1935_03D4 / 0x19724)
    Stack.Push16(UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs12, 0x3DD);
    // MOV ES,word ptr [0x5718] (1935_03D9 / 0x19729)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x3E2);
    // PUSH word ptr ES:[0x39a2] (1935_03DD / 0x1972D)
    Stack.Push16(UInt16[ES, 0x39A2]);
    CheckExternalEvents(cs12, 0x3E6);
    // MOV ES,word ptr [0x5716] (1935_03E2 / 0x19732)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x3EB);
    // PUSH word ptr ES:[0x398c] (1935_03E6 / 0x19736)
    Stack.Push16(UInt16[ES, 0x398C]);
    CheckExternalEvents(cs12, 0x3EC);
    // PUSH CS (1935_03EB / 0x1973B)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x3EF);
    // CALL 0x1000:9a97 (1935_03EC / 0x1973C)
    NearCall(cs12, 0x3EF, unknown_1935_0747_19A97);
    CheckExternalEvents(cs12, 0x3F2);
    // ADD SP,0xa (1935_03EF / 0x1973F)
    SP += 0xA;
    CheckExternalEvents(cs12, 0x3F5);
    // INC word ptr [BP + -0x2] (1935_03F2 / 0x19742)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1935_03F5_19745:
    CheckExternalEvents(cs12, 0x3F9);
    // MOV ES,word ptr [0x56fe] (1935_03F5 / 0x19745)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0x3FC);
    // MOV AX,word ptr [BP + -0x2] (1935_03F9 / 0x19749)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs12, 0x401);
    // CMP word ptr ES:[0x4612],AX (1935_03FC / 0x1974C)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs12, 0x403);
    // JG 0x1000:970e (1935_0401 / 0x19751)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1935_03BE_1970E;
    }
    CheckExternalEvents(cs12, 0x404);
    // PUSH CS (1935_0403 / 0x19753)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x407);
    // CALL 0x1000:9834 (1935_0404 / 0x19754)
    NearCall(cs12, 0x407, unknown_1935_04E4_19834);
    CheckExternalEvents(cs12, 0x409);
    // MOV SP,BP (1935_0407 / 0x19757)
    SP = BP;
    CheckExternalEvents(cs12, 0x40A);
    // POP BP (1935_0409 / 0x19759)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x40B);
    // RETF  (1935_040A / 0x1975A)
    return FarRet();
  }
  
  public virtual Action unknown_1935_040B_1975B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_040B_1975B:
    CheckExternalEvents(cs12, 0x40C);
    // PUSH BP (1935_040B / 0x1975B)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x40E);
    // MOV BP,SP (1935_040C / 0x1975C)
    BP = SP;
    CheckExternalEvents(cs12, 0x411);
    // MOV AX,0x2 (1935_040E / 0x1975E)
    AX = 0x2;
    CheckExternalEvents(cs12, 0x416);
    // CALLF 0x1000:cecc (1935_0411 / 0x19761)
    FarCall(cs12, 0x416, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x417);
    // PUSH CS (1935_0416 / 0x19766)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x41A);
    // CALL 0x1000:97be (1935_0417 / 0x19767)
    NearCall(cs12, 0x41A, unknown_1935_046E_197BE);
    CheckExternalEvents(cs12, 0x41F);
    // MOV word ptr [BP + -0x2],0x0 (1935_041A / 0x1976A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs12, 0x421);
    // JMP 0x1000:97a8 (1935_041F / 0x1976F)
    goto label_1935_0458_197A8;
    label_1935_0421_19771:
    CheckExternalEvents(cs12, 0x425);
    // MOV ES,word ptr [0x571e] (1935_0421 / 0x19771)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs12, 0x42A);
    // PUSH word ptr ES:[0x9c] (1935_0425 / 0x19775)
    Stack.Push16(UInt16[ES, 0x9C]);
    CheckExternalEvents(cs12, 0x42E);
    // MOV ES,word ptr [0x571c] (1935_042A / 0x1977A)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs12, 0x433);
    // PUSH word ptr ES:[0x3ff2] (1935_042E / 0x1977E)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs12, 0x437);
    // MOV ES,word ptr [0x571a] (1935_0433 / 0x19783)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs12, 0x43C);
    // PUSH word ptr ES:[0x39f6] (1935_0437 / 0x19787)
    Stack.Push16(UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs12, 0x440);
    // MOV ES,word ptr [0x5718] (1935_043C / 0x1978C)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs12, 0x445);
    // PUSH word ptr ES:[0x39a2] (1935_0440 / 0x19790)
    Stack.Push16(UInt16[ES, 0x39A2]);
    CheckExternalEvents(cs12, 0x449);
    // MOV ES,word ptr [0x5716] (1935_0445 / 0x19795)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs12, 0x44E);
    // PUSH word ptr ES:[0x398c] (1935_0449 / 0x19799)
    Stack.Push16(UInt16[ES, 0x398C]);
    CheckExternalEvents(cs12, 0x44F);
    // PUSH CS (1935_044E / 0x1979E)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x452);
    // CALL 0x1000:9b2a (1935_044F / 0x1979F)
    NearCall(cs12, 0x452, unknown_1935_07DA_19B2A);
    CheckExternalEvents(cs12, 0x455);
    // ADD SP,0xa (1935_0452 / 0x197A2)
    SP += 0xA;
    CheckExternalEvents(cs12, 0x458);
    // INC word ptr [BP + -0x2] (1935_0455 / 0x197A5)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1935_0458_197A8:
    CheckExternalEvents(cs12, 0x45C);
    // MOV ES,word ptr [0x56fe] (1935_0458 / 0x197A8)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs12, 0x45F);
    // MOV AX,word ptr [BP + -0x2] (1935_045C / 0x197AC)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs12, 0x464);
    // CMP word ptr ES:[0x4612],AX (1935_045F / 0x197AF)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs12, 0x466);
    // JG 0x1000:9771 (1935_0464 / 0x197B4)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1935_0421_19771;
    }
    CheckExternalEvents(cs12, 0x467);
    // PUSH CS (1935_0466 / 0x197B6)
    Stack.Push16(cs12);
    CheckExternalEvents(cs12, 0x46A);
    // CALL 0x1000:9834 (1935_0467 / 0x197B7)
    NearCall(cs12, 0x46A, unknown_1935_04E4_19834);
    CheckExternalEvents(cs12, 0x46C);
    // MOV SP,BP (1935_046A / 0x197BA)
    SP = BP;
    CheckExternalEvents(cs12, 0x46D);
    // POP BP (1935_046C / 0x197BC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x46E);
    // RETF  (1935_046D / 0x197BD)
    return FarRet();
  }
  
  public virtual Action unknown_1935_046E_197BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_046E_197BE:
    CheckExternalEvents(cs12, 0x470);
    // XOR AX,AX (1935_046E / 0x197BE)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x475);
    // CALLF 0x1000:cecc (1935_0470 / 0x197C0)
    FarCall(cs12, 0x475, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x47A);
    // CALLF 0x1000:9f0c (1935_0475 / 0x197C5)
    FarCall(cs12, 0x47A, unknown_19EF_001C_19F0C);
    CheckExternalEvents(cs12, 0x47B);
    // RETF  (1935_047A / 0x197CA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_97CB_197CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97CB_197CB:
    CheckExternalEvents(cs8, 0x97CC);
    // PUSH BP (1000_97CB / 0x197CB)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x97CE);
    // MOV BP,SP (1000_97CC / 0x197CC)
    BP = SP;
    CheckExternalEvents(cs8, 0x97D1);
    // MOV AX,0x4 (1000_97CE / 0x197CE)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x97D6);
    // CALLF 0x1000:cecc (1000_97D1 / 0x197D1)
    FarCall(cs8, 0x97D6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x97DA);
    // MOV ES,word ptr [0x5700] (1000_97D6 / 0x197D6)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs8, 0x97DD);
    // MOV AX,word ptr [BP + 0x6] (1000_97DA / 0x197DA)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x97E1);
    // MOV ES:[0x3984],AX (1000_97DD / 0x197DD)
    UInt16[ES, 0x3984] = AX;
    CheckExternalEvents(cs8, 0x97E5);
    // MOV ES,word ptr [0x5702] (1000_97E1 / 0x197E1)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs8, 0x97E8);
    // MOV AX,word ptr [BP + 0x8] (1000_97E5 / 0x197E5)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x97EC);
    // MOV ES:[0xe48c],AX (1000_97E8 / 0x197E8)
    UInt16[ES, 0xE48C] = AX;
    CheckExternalEvents(cs8, 0x97F0);
    // MOV ES,word ptr [0x5700] (1000_97EC / 0x197EC)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs8, 0x97F6);
    // CMP word ptr ES:[0x3984],0x0 (1000_97F0 / 0x197F0)
    Alu16.Sub(UInt16[ES, 0x3984], 0x0);
    CheckExternalEvents(cs8, 0x97F8);
    // JZ 0x1000:9805 (1000_97F6 / 0x197F6)
    if(ZeroFlag) {
      goto label_1000_9805_19805;
    }
    CheckExternalEvents(cs8, 0x97FD);
    // PUSH word ptr ES:[0x3984] (1000_97F8 / 0x197F8)
    Stack.Push16(UInt16[ES, 0x3984]);
    CheckExternalEvents(cs8, 0x9802);
    // CALLF 0x1000:9f20 (1000_97FD / 0x197FD)
    FarCall(cs8, 0x9802, ghidra_guess_1000_9F20_19F20);
    CheckExternalEvents(cs8, 0x9805);
    // ADD SP,0x2 (1000_9802 / 0x19802)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_9805_19805:
    CheckExternalEvents(cs8, 0x980A);
    // MOV word ptr [BP + -0x4],0x0 (1000_9805 / 0x19805)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs8, 0x980C);
    // JMP 0x1000:9823 (1000_980A / 0x1980A)
    goto label_1000_9823_19823;
    label_1000_980C_1980C:
    CheckExternalEvents(cs8, 0x980F);
    // INC word ptr [BP + -0x2] (1000_980C / 0x1980C)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_980F_1980F:
    CheckExternalEvents(cs8, 0x9813);
    // MOV ES,word ptr [0x5702] (1000_980F / 0x1980F)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs8, 0x9817);
    // MOV AX,ES:[0xe48c] (1000_9813 / 0x19813)
    AX = UInt16[ES, 0xE48C];
    CheckExternalEvents(cs8, 0x981B);
    // IMUL word ptr [0x5006] (1000_9817 / 0x19817)
    int resImul1000_9817 = Alu16.Imul((short)AX, (short)UInt16[DS, 0x5006]);
    AX = (ushort)(resImul1000_9817);
    DX = (ushort)(resImul1000_9817 >> 16);
    CheckExternalEvents(cs8, 0x981E);
    // CMP AX,word ptr [BP + -0x2] (1000_981B / 0x1981B)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs8, 0x9820);
    // JG 0x1000:980c (1000_981E / 0x1981E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_980C_1980C;
    }
    CheckExternalEvents(cs8, 0x9823);
    // INC word ptr [BP + -0x4] (1000_9820 / 0x19820)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_1000_9823_19823:
    CheckExternalEvents(cs8, 0x9827);
    // CMP word ptr [BP + -0x4],0x32 (1000_9823 / 0x19823)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x32);
    CheckExternalEvents(cs8, 0x9829);
    // JGE 0x1000:9830 (1000_9827 / 0x19827)
    if(SignFlag == OverflowFlag) {
      goto label_1000_9830_19830;
    }
    CheckExternalEvents(cs8, 0x982E);
    // MOV word ptr [BP + -0x2],0x0 (1000_9829 / 0x19829)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs8, 0x9830);
    // JMP 0x1000:980f (1000_982E / 0x1982E)
    goto label_1000_980F_1980F;
    label_1000_9830_19830:
    CheckExternalEvents(cs8, 0x9832);
    // MOV SP,BP (1000_9830 / 0x19830)
    SP = BP;
    CheckExternalEvents(cs8, 0x9833);
    // POP BP (1000_9832 / 0x19832)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x9834);
    // RETF  (1000_9833 / 0x19833)
    return FarRet();
  }
  
  public virtual Action unknown_1935_04E4_19834(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_04E4_19834:
    CheckExternalEvents(cs12, 0x4E6);
    // XOR AX,AX (1935_04E4 / 0x19834)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs12, 0x4EB);
    // CALLF 0x1000:cecc (1935_04E6 / 0x19836)
    FarCall(cs12, 0x4EB, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x4F0);
    // CALLF 0x1000:9f41 (1935_04EB / 0x1983B)
    FarCall(cs12, 0x4F0, unknown_19EF_0051_19F41);
    CheckExternalEvents(cs12, 0x4F1);
    // RETF  (1935_04F0 / 0x19840)
    return FarRet();
  }
  
  public virtual Action unknown_1935_04F1_19841(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1935_04F1_19841:
    CheckExternalEvents(cs12, 0x4F2);
    // PUSH BP (1935_04F1 / 0x19841)
    Stack.Push16(BP);
    CheckExternalEvents(cs12, 0x4F4);
    // MOV BP,SP (1935_04F2 / 0x19842)
    BP = SP;
    CheckExternalEvents(cs12, 0x4F7);
    // MOV AX,0x4 (1935_04F4 / 0x19844)
    AX = 0x4;
    CheckExternalEvents(cs12, 0x4FC);
    // CALLF 0x1000:cecc (1935_04F7 / 0x19847)
    FarCall(cs12, 0x4FC, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs12, 0x500);
    // MOV ES,word ptr [0x5704] (1935_04FC / 0x1984C)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs12, 0x503);
    // MOV AX,word ptr [BP + 0x6] (1935_0500 / 0x19850)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs12, 0x507);
    // MOV ES:[0x6c],AX (1935_0503 / 0x19853)
    UInt16[ES, 0x6C] = AX;
    CheckExternalEvents(cs12, 0x50B);
    // MOV ES,word ptr [0x5706] (1935_0507 / 0x19857)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs12, 0x50E);
    // MOV AX,word ptr [BP + 0x8] (1935_050B / 0x1985B)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs12, 0x512);
    // MOV ES:[0x3776],AX (1935_050E / 0x1985E)
    UInt16[ES, 0x3776] = AX;
    CheckExternalEvents(cs12, 0x516);
    // MOV ES,word ptr [0x5708] (1935_0512 / 0x19862)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs12, 0x519);
    // MOV AX,word ptr [BP + 0xa] (1935_0516 / 0x19866)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs12, 0x51D);
    // MOV ES:[0x4312],AX (1935_0519 / 0x19869)
    UInt16[ES, 0x4312] = AX;
    CheckExternalEvents(cs12, 0x521);
    // MOV ES,word ptr [0x570a] (1935_051D / 0x1986D)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs12, 0x528);
    // MOV word ptr ES:[0x398a],0x3e8 (1935_0521 / 0x19871)
    UInt16[ES, 0x398A] = 0x3E8;
    CheckExternalEvents(cs12, 0x52D);
    // CALLF 0x1000:9f57 (1935_0528 / 0x19878)
    FarCall(cs12, 0x52D, unknown_19EF_0067_19F57);
    CheckExternalEvents(cs12, 0x532);
    // MOV word ptr [BP + -0x2],0x1 (1935_052D / 0x1987D)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs12, 0x534);
    // JMP 0x1000:9887 (1935_0532 / 0x19882)
    goto label_1935_0537_19887;
    label_1935_0534_19884:
    CheckExternalEvents(cs12, 0x537);
    // INC word ptr [BP + -0x2] (1935_0534 / 0x19884)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1935_0537_19887:
    CheckExternalEvents(cs12, 0x53A);
    // MOV AX,[0x5006] (1935_0537 / 0x19887)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs12, 0x53D);
    // CMP word ptr [BP + -0x2],AX (1935_053A / 0x1988A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs12, 0x53F);
    // JL 0x1000:9884 (1935_053D / 0x1988D)
    if(SignFlag != OverflowFlag) {
      goto label_1935_0534_19884;
    }
    CheckExternalEvents(cs12, 0x544);
    // MOV word ptr [BP + -0x2],0x0 (1935_053F / 0x1988F)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs12, 0x546);
    // JMP 0x1000:98c0 (1935_0544 / 0x19894)
    goto label_1935_0570_198C0;
    label_1935_0546_19896:
    CheckExternalEvents(cs12, 0x549);
    // INC word ptr [BP + -0x4] (1935_0546 / 0x19896)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1935_0549_19899:
    CheckExternalEvents(cs12, 0x54C);
    // MOV AX,[0x5006] (1935_0549 / 0x19899)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs12, 0x54F);
    // CMP word ptr [BP + -0x4],AX (1935_054C / 0x1989C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs12, 0x551);
    // JGE 0x1000:98bd (1935_054F / 0x1989F)
    if(SignFlag == OverflowFlag) {
      goto label_1935_056D_198BD;
    }
    CheckExternalEvents(cs12, 0x555);
    // MOV ES,word ptr [0x5706] (1935_0551 / 0x198A1)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs12, 0x55A);
    // PUSH word ptr ES:[0x3776] (1935_0555 / 0x198A5)
    Stack.Push16(UInt16[ES, 0x3776]);
    CheckExternalEvents(cs12, 0x55E);
    // MOV ES,word ptr [0x5704] (1935_055A / 0x198AA)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs12, 0x563);
    // PUSH word ptr ES:[0x6c] (1935_055E / 0x198AE)
    Stack.Push16(UInt16[ES, 0x6C]);
    CheckExternalEvents(cs12, 0x568);
    // CALLF 0x1000:9f99 (1935_0563 / 0x198B3)
    FarCall(cs12, 0x568, unknown_19EF_00A9_19F99);
    CheckExternalEvents(cs12, 0x56B);
    // ADD SP,0x4 (1935_0568 / 0x198B8)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs12, 0x56D);
    // JMP 0x1000:9896 (1935_056B / 0x198BB)
    goto label_1935_0546_19896;
    label_1935_056D_198BD:
    CheckExternalEvents(cs12, 0x570);
    // INC word ptr [BP + -0x2] (1935_056D / 0x198BD)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1935_0570_198C0:
    CheckExternalEvents(cs12, 0x574);
    // MOV ES,word ptr [0x5708] (1935_0570 / 0x198C0)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs12, 0x577);
    // MOV AX,word ptr [BP + -0x2] (1935_0574 / 0x198C4)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs12, 0x57C);
    // CMP word ptr ES:[0x4312],AX (1935_0577 / 0x198C7)
    Alu16.Sub(UInt16[ES, 0x4312], AX);
    CheckExternalEvents(cs12, 0x57E);
    // JLE 0x1000:98e6 (1935_057C / 0x198CC)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1935_0596_198E6;
    }
    CheckExternalEvents(cs12, 0x582);
    // MOV ES,word ptr [0x570a] (1935_057E / 0x198CE)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs12, 0x587);
    // PUSH word ptr ES:[0x398a] (1935_0582 / 0x198D2)
    Stack.Push16(UInt16[ES, 0x398A]);
    CheckExternalEvents(cs12, 0x58C);
    // CALLF 0x1000:9f6d (1935_0587 / 0x198D7)
    FarCall(cs12, 0x58C, unknown_19EF_007D_19F6D);
    CheckExternalEvents(cs12, 0x58F);
    // ADD SP,0x2 (1935_058C / 0x198DC)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs12, 0x594);
    // MOV word ptr [BP + -0x4],0x0 (1935_058F / 0x198DF)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs12, 0x596);
    // JMP 0x1000:9899 (1935_0594 / 0x198E4)
    goto label_1935_0549_19899;
    label_1935_0596_198E6:
    CheckExternalEvents(cs12, 0x598);
    // MOV SP,BP (1935_0596 / 0x198E6)
    SP = BP;
    CheckExternalEvents(cs12, 0x599);
    // POP BP (1935_0598 / 0x198E8)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs12, 0x59A);
    // RETF  (1935_0599 / 0x198E9)
    return FarRet();
  }
  
}
