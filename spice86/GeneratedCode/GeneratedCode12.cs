namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_3F24_13F24(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3F24_13F24:
    CheckExternalEvents(cs7, 0x3F25);
    // PUSH BP (1000_3F24 / 0x13F24)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x3F27);
    // MOV BP,SP (1000_3F25 / 0x13F25)
    BP = SP;
    CheckExternalEvents(cs7, 0x3F29);
    // XOR AX,AX (1000_3F27 / 0x13F27)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0x3F2E);
    // CALLF 0x1000:cecc (1000_3F29 / 0x13F29)
    FarCall(cs7, 0x3F2E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x3F32);
    // MOV ES,word ptr [0x561a] (1000_3F2E / 0x13F2E)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3F39);
    // MOV word ptr ES:[0x3770],0x6 (1000_3F32 / 0x13F32)
    UInt16[ES, 0x3770] = 0x6;
    CheckExternalEvents(cs7, 0x3F3D);
    // CMP word ptr [BP + 0x6],0xc (1000_3F39 / 0x13F39)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x3F3F);
    // JGE 0x1000:3f8b (1000_3F3D / 0x13F3D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_3F8B_13F8B;
    }
    CheckExternalEvents(cs7, 0x3F43);
    // SUB word ptr [BP + 0x6],0x4 (1000_3F3F / 0x13F3F)
    // UInt16[SS, (ushort)(BP + 0x6)] -= 0x4;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x3F46);
    // MOV AX,0x11 (1000_3F43 / 0x13F43)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x3F49);
    // IMUL word ptr [BP + 0x6] (1000_3F46 / 0x13F46)
    int resImul1000_3F46 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3F46);
    DX = (ushort)(resImul1000_3F46 >> 16);
    CheckExternalEvents(cs7, 0x3F4B);
    // MOV BX,AX (1000_3F49 / 0x13F49)
    BX = AX;
    CheckExternalEvents(cs7, 0x3F4F);
    // MOV ES,word ptr [0x55d4] (1000_3F4B / 0x13F4B)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3F51);
    // MOV AL,0x3 (1000_3F4F / 0x13F4F)
    AL = 0x3;
    CheckExternalEvents(cs7, 0x3F56);
    // IMUL byte ptr ES:[BX + 0xc616] (1000_3F51 / 0x13F51)
    short resImul1000_3F51 = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC616)]);
    AL = (byte)(resImul1000_3F51);
    AH = (byte)(resImul1000_3F51 >> 8);
    CheckExternalEvents(cs7, 0x3F58);
    // SAR AX,0x1 (1000_3F56 / 0x13F56)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x3F5A);
    // SAR AX,0x1 (1000_3F58 / 0x13F58)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x3F5E);
    // MOV ES,word ptr [0x561a] (1000_3F5A / 0x13F5A)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3F62);
    // MOV ES:[0x3770],AX (1000_3F5E / 0x13F5E)
    UInt16[ES, 0x3770] = AX;
    CheckExternalEvents(cs7, 0x3F65);
    // CMP AX,0x3 (1000_3F62 / 0x13F62)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs7, 0x3F67);
    // JGE 0x1000:3f6e (1000_3F65 / 0x13F65)
    if(SignFlag == OverflowFlag) {
      goto label_1000_3F6E_13F6E;
    }
    CheckExternalEvents(cs7, 0x3F6E);
    // MOV word ptr ES:[0x3770],0x3 (1000_3F67 / 0x13F67)
    UInt16[ES, 0x3770] = 0x3;
    label_1000_3F6E_13F6E:
    CheckExternalEvents(cs7, 0x3F71);
    // MOV AX,0x11 (1000_3F6E / 0x13F6E)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x3F74);
    // IMUL word ptr [BP + 0x6] (1000_3F71 / 0x13F71)
    int resImul1000_3F71 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3F71);
    DX = (ushort)(resImul1000_3F71 >> 16);
    CheckExternalEvents(cs7, 0x3F76);
    // MOV BX,AX (1000_3F74 / 0x13F74)
    BX = AX;
    CheckExternalEvents(cs7, 0x3F7A);
    // MOV ES,word ptr [0x55d4] (1000_3F76 / 0x13F76)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3F80);
    // CMP byte ptr ES:[BX + 0xc621],0x1 (1000_3F7A / 0x13F7A)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC621)], 0x1);
    CheckExternalEvents(cs7, 0x3F82);
    // JLE 0x1000:3f8b (1000_3F80 / 0x13F80)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_3F8B_13F8B;
    }
    CheckExternalEvents(cs7, 0x3F86);
    // MOV ES,word ptr [0x561a] (1000_3F82 / 0x13F82)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3F8B);
    // SAR word ptr ES:[0x3770],0x1 (1000_3F86 / 0x13F86)
    UInt16[ES, 0x3770] = Alu16.Sar(UInt16[ES, 0x3770], 0x1);
    label_1000_3F8B_13F8B:
    CheckExternalEvents(cs7, 0x3F8F);
    // MOV ES,word ptr [0x561a] (1000_3F8B / 0x13F8B)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3F95);
    // CMP word ptr ES:[0x3770],0x8 (1000_3F8F / 0x13F8F)
    Alu16.Sub(UInt16[ES, 0x3770], 0x8);
    CheckExternalEvents(cs7, 0x3F97);
    // JLE 0x1000:3f9e (1000_3F95 / 0x13F95)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_3F9E_13F9E;
    }
    CheckExternalEvents(cs7, 0x3F9E);
    // MOV word ptr ES:[0x3770],0x8 (1000_3F97 / 0x13F97)
    UInt16[ES, 0x3770] = 0x8;
    label_1000_3F9E_13F9E:
    CheckExternalEvents(cs7, 0x3F9F);
    // POP BP (1000_3F9E / 0x13F9E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3FA0);
    // RETF  (1000_3F9F / 0x13F9F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_3FA0_13FA0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3FA0_13FA0:
    CheckExternalEvents(cs7, 0x3FA1);
    // PUSH BP (1000_3FA0 / 0x13FA0)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x3FA3);
    // MOV BP,SP (1000_3FA1 / 0x13FA1)
    BP = SP;
    CheckExternalEvents(cs7, 0x3FA6);
    // MOV AX,0x2 (1000_3FA3 / 0x13FA3)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x3FAB);
    // CALLF 0x1000:cecc (1000_3FA6 / 0x13FA6)
    FarCall(cs7, 0x3FAB, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x3FAE);
    // MOV AX,0x3 (1000_3FAB / 0x13FAB)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x3FAF);
    // PUSH AX (1000_3FAE / 0x13FAE)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3FB4);
    // CALLF 0x1000:7ee1 (1000_3FAF / 0x13FAF)
    FarCall(cs7, 0x3FB4, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x3FB7);
    // ADD SP,0x2 (1000_3FB4 / 0x13FB4)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3FBC);
    // CALLF 0x1000:7fe8 (1000_3FB7 / 0x13FB7)
    FarCall(cs7, 0x3FBC, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x3FBF);
    // MOV AX,0x3d3a (1000_3FBC / 0x13FBC)
    AX = 0x3D3A;
    CheckExternalEvents(cs7, 0x3FC0);
    // PUSH DS (1000_3FBF / 0x13FBF)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3FC1);
    // PUSH AX (1000_3FC0 / 0x13FC0)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3FC6);
    // CALLF 0x1000:8055 (1000_3FC1 / 0x13FC1)
    FarCall(cs7, 0x3FC6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3FC9);
    // ADD SP,0x4 (1000_3FC6 / 0x13FC6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3FCD);
    // MOV ES,word ptr [0x560c] (1000_3FC9 / 0x13FC9)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x3FD4);
    // MOV word ptr ES:[0xc2],0x2 (1000_3FCD / 0x13FCD)
    UInt16[ES, 0xC2] = 0x2;
    CheckExternalEvents(cs7, 0x3FDB);
    // MOV word ptr ES:[0xc6],0x3 (1000_3FD4 / 0x13FD4)
    UInt16[ES, 0xC6] = 0x3;
    CheckExternalEvents(cs7, 0x3FDF);
    // MOV ES,word ptr [0x55f4] (1000_3FDB / 0x13FDB)
    ES = UInt16[DS, 0x55F4];
    CheckExternalEvents(cs7, 0x3FE3);
    // MOV AX,ES:[0x2e38] (1000_3FDF / 0x13FDF)
    AX = UInt16[ES, 0x2E38];
    CheckExternalEvents(cs7, 0x3FE7);
    // MOV ES,word ptr [0x560c] (1000_3FE3 / 0x13FE3)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x3FEB);
    // MOV ES:[0xc8],AX (1000_3FE7 / 0x13FE7)
    UInt16[ES, 0xC8] = AX;
    CheckExternalEvents(cs7, 0x3FEE);
    // MOV AX,0x3 (1000_3FEB / 0x13FEB)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x3FEF);
    // PUSH AX (1000_3FEE / 0x13FEE)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3FF4);
    // CALLF 0x1000:87be (1000_3FEF / 0x13FEF)
    FarCall(cs7, 0x3FF4, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs7, 0x3FF7);
    // MOV word ptr [BP + -0x2],AX (1000_3FF4 / 0x13FF4)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x3FFB);
    // MOV ES,word ptr [0x560c] (1000_3FF7 / 0x13FF7)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x4002);
    // MOV word ptr ES:[0xc2],0x0 (1000_3FFB / 0x13FFB)
    UInt16[ES, 0xC2] = 0x0;
    CheckExternalEvents(cs7, 0x4004);
    // MOV SP,BP (1000_4002 / 0x14002)
    SP = BP;
    CheckExternalEvents(cs7, 0x4005);
    // POP BP (1000_4004 / 0x14004)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4006);
    // RETF  (1000_4005 / 0x14005)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_4006_14006(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4006_14006:
    CheckExternalEvents(cs7, 0x4007);
    // PUSH BP (1000_4006 / 0x14006)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x4009);
    // MOV BP,SP (1000_4007 / 0x14007)
    BP = SP;
    CheckExternalEvents(cs7, 0x400C);
    // MOV AX,0x2 (1000_4009 / 0x14009)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x4011);
    // CALLF 0x1000:cecc (1000_400C / 0x1400C)
    FarCall(cs7, 0x4011, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x4014);
    // MOV AX,0x3 (1000_4011 / 0x14011)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x4015);
    // PUSH AX (1000_4014 / 0x14014)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x401A);
    // CALLF 0x1000:7ee1 (1000_4015 / 0x14015)
    FarCall(cs7, 0x401A, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x401D);
    // ADD SP,0x2 (1000_401A / 0x1401A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x4022);
    // CALLF 0x1000:7fe8 (1000_401D / 0x1401D)
    FarCall(cs7, 0x4022, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x4025);
    // MOV AX,0x3d5e (1000_4022 / 0x14022)
    AX = 0x3D5E;
    CheckExternalEvents(cs7, 0x4026);
    // PUSH DS (1000_4025 / 0x14025)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4027);
    // PUSH AX (1000_4026 / 0x14026)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x402C);
    // CALLF 0x1000:8055 (1000_4027 / 0x14027)
    FarCall(cs7, 0x402C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x402F);
    // ADD SP,0x4 (1000_402C / 0x1402C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4033);
    // MOV ES,word ptr [0x55f6] (1000_402F / 0x1402F)
    ES = UInt16[DS, 0x55F6];
    CheckExternalEvents(cs7, 0x4038);
    // PUSH word ptr ES:[0x2e3a] (1000_4033 / 0x14033)
    Stack.Push16(UInt16[ES, 0x2E3A]);
    CheckExternalEvents(cs7, 0x403D);
    // CALLF 0x0000:3113 (1000_4038 / 0x14038)
    FarCall(cs7, 0x403D, unknown_0170_1A13_03113);
    CheckExternalEvents(cs7, 0x403F);
    // MOV SP,BP (1000_403D / 0x1403D)
    SP = BP;
    CheckExternalEvents(cs7, 0x4040);
    // POP BP (1000_403F / 0x1403F)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4041);
    // RETF  (1000_4040 / 0x14040)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_4041_14041(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4041_14041:
    CheckExternalEvents(cs7, 0x4042);
    // PUSH BP (1000_4041 / 0x14041)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x4044);
    // MOV BP,SP (1000_4042 / 0x14042)
    BP = SP;
    CheckExternalEvents(cs7, 0x4047);
    // MOV AX,0xc (1000_4044 / 0x14044)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x404C);
    // CALLF 0x1000:cecc (1000_4047 / 0x14047)
    FarCall(cs7, 0x404C, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x404D);
    // PUSH SI (1000_404C / 0x1404C)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x4052);
    // MOV word ptr [BP + -0x4],0x1 (1000_404D / 0x1404D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    CheckExternalEvents(cs7, 0x4055);
    // MOV AX,0x3 (1000_4052 / 0x14052)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x4056);
    // PUSH AX (1000_4055 / 0x14055)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x405B);
    // CALLF 0x1000:7ee1 (1000_4056 / 0x14056)
    FarCall(cs7, 0x405B, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x405E);
    // ADD SP,0x2 (1000_405B / 0x1405B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x4063);
    // CALLF 0x1000:7fe8 (1000_405E / 0x1405E)
    FarCall(cs7, 0x4063, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x4066);
    // MOV AX,0x3d73 (1000_4063 / 0x14063)
    AX = 0x3D73;
    CheckExternalEvents(cs7, 0x4067);
    // PUSH DS (1000_4066 / 0x14066)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4068);
    // PUSH AX (1000_4067 / 0x14067)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x406D);
    // CALLF 0x1000:8055 (1000_4068 / 0x14068)
    FarCall(cs7, 0x406D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x4070);
    // ADD SP,0x4 (1000_406D / 0x1406D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4074);
    // MOV ES,word ptr [0x560c] (1000_4070 / 0x14070)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x407B);
    // MOV word ptr ES:[0xc2],0x1 (1000_4074 / 0x14074)
    UInt16[ES, 0xC2] = 0x1;
    CheckExternalEvents(cs7, 0x4082);
    // MOV word ptr ES:[0xc6],0x3 (1000_407B / 0x1407B)
    UInt16[ES, 0xC6] = 0x3;
    CheckExternalEvents(cs7, 0x4089);
    // MOV word ptr ES:[0xc8],0x0 (1000_4082 / 0x14082)
    UInt16[ES, 0xC8] = 0x0;
    CheckExternalEvents(cs7, 0x408C);
    // MOV AX,0x3 (1000_4089 / 0x14089)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x408D);
    // PUSH AX (1000_408C / 0x1408C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4092);
    // CALLF 0x1000:87be (1000_408D / 0x1408D)
    FarCall(cs7, 0x4092, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs7, 0x4095);
    // ADD SP,0x2 (1000_4092 / 0x14092)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x4098);
    // MOV word ptr [BP + -0x8],AX (1000_4095 / 0x14095)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x409D);
    // MOV word ptr [BP + -0x2],0x1 (1000_4098 / 0x14098)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs7, 0x40A0);
    // CMP AX,0x1 (1000_409D / 0x1409D)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs7, 0x40A2);
    // JZ 0x1000:40a5 (1000_40A0 / 0x140A0)
    if(ZeroFlag) {
      goto label_1000_40A5_140A5;
    }
    CheckExternalEvents(cs7, 0x40A5);
    // JMP 0x1000:4137 (1000_40A2 / 0x140A2)
    goto label_1000_4137_14137;
    label_1000_40A5_140A5:
    CheckExternalEvents(cs7, 0x40A8);
    // MOV AX,0x4 (1000_40A5 / 0x140A5)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x40A9);
    // PUSH AX (1000_40A8 / 0x140A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x40AE);
    // CALLF 0x1000:7ee1 (1000_40A9 / 0x140A9)
    FarCall(cs7, 0x40AE, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x40B1);
    // ADD SP,0x2 (1000_40AE / 0x140AE)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x40B6);
    // CALLF 0x1000:7fe8 (1000_40B1 / 0x140B1)
    FarCall(cs7, 0x40B6, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x40BA);
    // CMP word ptr [BP + 0x6],0x4 (1000_40B6 / 0x140B6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x40BC);
    // JL 0x1000:4107 (1000_40BA / 0x140BA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4107_14107;
    }
    CheckExternalEvents(cs7, 0x40BE);
    // SUB AX,AX (1000_40BC / 0x140BC)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x40C1);
    // MOV word ptr [BP + -0x6],AX (1000_40BE / 0x140BE)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x40C4);
    // MOV word ptr [BP + -0xa],AX (1000_40C1 / 0x140C1)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x40C6);
    // JMP 0x1000:40df (1000_40C4 / 0x140C4)
    goto label_1000_40DF_140DF;
    label_1000_40C6_140C6:
    CheckExternalEvents(cs7, 0x40C9);
    // MOV BX,word ptr [BP + -0xa] (1000_40C6 / 0x140C6)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x40CB);
    // SHL BX,0x1 (1000_40C9 / 0x140C9)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x40CF);
    // MOV ES,word ptr [0x55e0] (1000_40CB / 0x140CB)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs7, 0x40D5);
    // CMP word ptr ES:[BX + 0x4082],0x0 (1000_40CF / 0x140CF)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x4082)], 0x0);
    CheckExternalEvents(cs7, 0x40D7);
    // JZ 0x1000:40dc (1000_40D5 / 0x140D5)
    if(ZeroFlag) {
      goto label_1000_40DC_140DC;
    }
    CheckExternalEvents(cs7, 0x40DC);
    // MOV word ptr [BP + -0x6],0x1 (1000_40D7 / 0x140D7)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_1000_40DC_140DC:
    CheckExternalEvents(cs7, 0x40DF);
    // INC word ptr [BP + -0xa] (1000_40DC / 0x140DC)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    label_1000_40DF_140DF:
    CheckExternalEvents(cs7, 0x40E3);
    // CMP word ptr [BP + -0xa],0x4 (1000_40DF / 0x140DF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x40E5);
    // JL 0x1000:40c6 (1000_40E3 / 0x140E3)
    if(SignFlag != OverflowFlag) {
      goto label_1000_40C6_140C6;
    }
    CheckExternalEvents(cs7, 0x40E9);
    // CMP word ptr [BP + -0x6],0x0 (1000_40E5 / 0x140E5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x40EB);
    // JZ 0x1000:40fd (1000_40E9 / 0x140E9)
    if(ZeroFlag) {
      goto label_1000_40FD_140FD;
    }
    CheckExternalEvents(cs7, 0x40EE);
    // MOV AX,0x3d94 (1000_40EB / 0x140EB)
    AX = 0x3D94;
    CheckExternalEvents(cs7, 0x40EF);
    // PUSH DS (1000_40EE / 0x140EE)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x40F0);
    // PUSH AX (1000_40EF / 0x140EF)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x40F5);
    // CALLF 0x1000:8055 (1000_40F0 / 0x140F0)
    FarCall(cs7, 0x40F5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x40F8);
    // ADD SP,0x4 (1000_40F5 / 0x140F5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x40FD);
    // CALLF 0x1000:8d29 (1000_40F8 / 0x140F8)
    FarCall(cs7, 0x40FD, unknown_18AD_0259_18D29);
    label_1000_40FD_140FD:
    CheckExternalEvents(cs7, 0x40FF);
    // SUB AX,AX (1000_40FD / 0x140FD)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x4102);
    // MOV word ptr [BP + -0x2],AX (1000_40FF / 0x140FF)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x4105);
    // MOV word ptr [BP + -0x4],AX (1000_4102 / 0x14102)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x4107);
    // JMP 0x1000:4137 (1000_4105 / 0x14105)
    goto label_1000_4137_14137;
    label_1000_4107_14107:
    CheckExternalEvents(cs7, 0x410A);
    // MOV AX,0x7d (1000_4107 / 0x14107)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x410D);
    // IMUL word ptr [BP + 0x6] (1000_410A / 0x1410A)
    int resImul1000_410A = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_410A);
    DX = (ushort)(resImul1000_410A >> 16);
    CheckExternalEvents(cs7, 0x410F);
    // MOV BX,AX (1000_410D / 0x1410D)
    BX = AX;
    CheckExternalEvents(cs7, 0x4113);
    // MOV ES,word ptr [0x55d4] (1000_410F / 0x1410F)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x4119);
    // CMP byte ptr ES:[BX + 0xc79b],0x2 (1000_4113 / 0x14113)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC79B)], 0x2);
    CheckExternalEvents(cs7, 0x411B);
    // JNZ 0x1000:4137 (1000_4119 / 0x14119)
    if(!ZeroFlag) {
      goto label_1000_4137_14137;
    }
    CheckExternalEvents(cs7, 0x411E);
    // MOV AX,0x3dcd (1000_411B / 0x1411B)
    AX = 0x3DCD;
    CheckExternalEvents(cs7, 0x411F);
    // PUSH DS (1000_411E / 0x1411E)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4120);
    // PUSH AX (1000_411F / 0x1411F)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4125);
    // CALLF 0x1000:8055 (1000_4120 / 0x14120)
    FarCall(cs7, 0x4125, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x4128);
    // ADD SP,0x4 (1000_4125 / 0x14125)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x412D);
    // MOV word ptr [BP + -0x4],0x0 (1000_4128 / 0x14128)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x4132);
    // CALLF 0x1000:8d29 (1000_412D / 0x1412D)
    FarCall(cs7, 0x4132, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs7, 0x4137);
    // CALLF 0x1000:7fe8 (1000_4132 / 0x14132)
    FarCall(cs7, 0x4137, unknown_17C6_0388_17FE8);
    label_1000_4137_14137:
    CheckExternalEvents(cs7, 0x413C);
    // MOV word ptr [BP + -0xc],0x10 (1000_4137 / 0x14137)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x10;
    label_1000_413C_1413C:
    CheckExternalEvents(cs7, 0x413F);
    // MOV SI,word ptr [BP + -0xc] (1000_413C / 0x1413C)
    SI = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs7, 0x4141);
    // SHL SI,0x1 (1000_413F / 0x1413F)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x4145);
    // MOV ES,word ptr [0x55e0] (1000_4141 / 0x14141)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs7, 0x414B);
    // CMP word ptr ES:[SI + 0x406a],0x0 (1000_4145 / 0x14145)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x414D);
    // JZ 0x1000:415e (1000_414B / 0x1414B)
    if(ZeroFlag) {
      goto label_1000_415E_1415E;
    }
    CheckExternalEvents(cs7, 0x4151);
    // MOV ES,word ptr [0x55d2] (1000_414D / 0x1414D)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs7, 0x4157);
    // CMP word ptr ES:[SI + 0x4004],-0x1 (1000_4151 / 0x14151)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4004)], 0xFFFF);
    CheckExternalEvents(cs7, 0x4159);
    // JZ 0x1000:415e (1000_4157 / 0x14157)
    if(ZeroFlag) {
      goto label_1000_415E_1415E;
    }
    CheckExternalEvents(cs7, 0x415E);
    // MOV word ptr [BP + -0x2],0x1 (1000_4159 / 0x14159)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_1000_415E_1415E:
    CheckExternalEvents(cs7, 0x4161);
    // INC word ptr [BP + -0xc] (1000_415E / 0x1415E)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs7, 0x4165);
    // CMP word ptr [BP + -0xc],0x18 (1000_4161 / 0x14161)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x18);
    CheckExternalEvents(cs7, 0x4167);
    // JL 0x1000:413c (1000_4165 / 0x14165)
    if(SignFlag != OverflowFlag) {
      goto label_1000_413C_1413C;
    }
    CheckExternalEvents(cs7, 0x416A);
    // MOV AX,word ptr [BP + -0x4] (1000_4167 / 0x14167)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x416D);
    // ADD word ptr [BP + -0x2],AX (1000_416A / 0x1416A)
    // UInt16[SS, (ushort)(BP - 0x2)] += AX;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs7, 0x416F);
    // JNZ 0x1000:4198 (1000_416D / 0x1416D)
    if(!ZeroFlag) {
      goto label_1000_4198_14198;
    }
    CheckExternalEvents(cs7, 0x4173);
    // CMP word ptr [BP + -0x8],0x1 (1000_416F / 0x1416F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs7, 0x4175);
    // JNZ 0x1000:4198 (1000_4173 / 0x14173)
    if(!ZeroFlag) {
      goto label_1000_4198_14198;
    }
    CheckExternalEvents(cs7, 0x4178);
    // MOV AX,0x4 (1000_4175 / 0x14175)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x4179);
    // PUSH AX (1000_4178 / 0x14178)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x417E);
    // CALLF 0x1000:7ee1 (1000_4179 / 0x14179)
    FarCall(cs7, 0x417E, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x4181);
    // ADD SP,0x2 (1000_417E / 0x1417E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x4186);
    // CALLF 0x1000:7fe8 (1000_4181 / 0x14181)
    FarCall(cs7, 0x4186, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x4189);
    // MOV AX,0x3e19 (1000_4186 / 0x14186)
    AX = 0x3E19;
    CheckExternalEvents(cs7, 0x418A);
    // PUSH DS (1000_4189 / 0x14189)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x418B);
    // PUSH AX (1000_418A / 0x1418A)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4190);
    // CALLF 0x1000:8055 (1000_418B / 0x1418B)
    FarCall(cs7, 0x4190, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x4193);
    // ADD SP,0x4 (1000_4190 / 0x14190)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4198);
    // CALLF 0x0000:414f (1000_4193 / 0x14193)
    FarCall(cs7, 0x4198, ghidra_guess_0000_414F_0414F);
    label_1000_4198_14198:
    CheckExternalEvents(cs7, 0x419D);
    // CALLF 0x1000:7fe8 (1000_4198 / 0x14198)
    FarCall(cs7, 0x419D, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x41A1);
    // CMP word ptr [BP + -0x8],0x0 (1000_419D / 0x1419D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs7, 0x41A3);
    // JGE 0x1000:41a8 (1000_41A1 / 0x141A1)
    if(SignFlag == OverflowFlag) {
      goto label_1000_41A8_141A8;
    }
    CheckExternalEvents(cs7, 0x41A8);
    // MOV word ptr [BP + -0x8],0x0 (1000_41A3 / 0x141A3)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_1000_41A8_141A8:
    CheckExternalEvents(cs7, 0x41AC);
    // CMP word ptr [BP + -0x8],0x2 (1000_41A8 / 0x141A8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x2);
    CheckExternalEvents(cs7, 0x41AE);
    // JGE 0x1000:41c9 (1000_41AC / 0x141AC)
    if(SignFlag == OverflowFlag) {
      goto label_1000_41C9_141C9;
    }
    CheckExternalEvents(cs7, 0x41B2);
    // CMP word ptr [BP + -0x2],0x0 (1000_41AE / 0x141AE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs7, 0x41B4);
    // JZ 0x1000:41c9 (1000_41B2 / 0x141B2)
    if(ZeroFlag) {
      goto label_1000_41C9_141C9;
    }
    CheckExternalEvents(cs7, 0x41B7);
    // PUSH word ptr [BP + -0x4] (1000_41B4 / 0x141B4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs7, 0x41BA);
    // MOV AX,0xc (1000_41B7 / 0x141B7)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x41BD);
    // IMUL word ptr [BP + -0x8] (1000_41BA / 0x141BA)
    int resImul1000_41BA = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x8)]);
    AX = (ushort)(resImul1000_41BA);
    DX = (ushort)(resImul1000_41BA >> 16);
    CheckExternalEvents(cs7, 0x41BE);
    // PUSH AX (1000_41BD / 0x141BD)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x41C1);
    // PUSH word ptr [BP + 0x6] (1000_41BE / 0x141BE)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x41C6);
    // CALLF 0x0000:8617 (1000_41C1 / 0x141C1)
    FarCall(cs7, 0x41C6, ghidra_guess_0000_8617_08617);
    CheckExternalEvents(cs7, 0x41C9);
    // ADD SP,0x6 (1000_41C6 / 0x141C6)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_1000_41C9_141C9:
    CheckExternalEvents(cs7, 0x41CD);
    // MOV ES,word ptr [0x560c] (1000_41C9 / 0x141C9)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x41D4);
    // MOV word ptr ES:[0xc2],0x0 (1000_41CD / 0x141CD)
    UInt16[ES, 0xC2] = 0x0;
    CheckExternalEvents(cs7, 0x41DB);
    // MOV word ptr ES:[0xc8],0x4 (1000_41D4 / 0x141D4)
    UInt16[ES, 0xC8] = 0x4;
    CheckExternalEvents(cs7, 0x41DF);
    // CMP word ptr [BP + 0x6],0x4 (1000_41DB / 0x141DB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x41E1);
    // JGE 0x1000:41e8 (1000_41DF / 0x141DF)
    if(SignFlag == OverflowFlag) {
      goto label_1000_41E8_141E8;
    }
    CheckExternalEvents(cs7, 0x41E8);
    // MOV word ptr ES:[0xc8],0x6 (1000_41E1 / 0x141E1)
    UInt16[ES, 0xC8] = 0x6;
    label_1000_41E8_141E8:
    CheckExternalEvents(cs7, 0x41E9);
    // POP SI (1000_41E8 / 0x141E8)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x41EB);
    // MOV SP,BP (1000_41E9 / 0x141E9)
    SP = BP;
    CheckExternalEvents(cs7, 0x41EC);
    // POP BP (1000_41EB / 0x141EB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x41ED);
    // RETF  (1000_41EC / 0x141EC)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_41ED_141ED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_41ED_141ED:
    CheckExternalEvents(cs7, 0x41EE);
    // PUSH BP (1000_41ED / 0x141ED)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x41F0);
    // MOV BP,SP (1000_41EE / 0x141EE)
    BP = SP;
    CheckExternalEvents(cs7, 0x41F3);
    // MOV AX,0x2 (1000_41F0 / 0x141F0)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x41F8);
    // CALLF 0x1000:cecc (1000_41F3 / 0x141F3)
    FarCall(cs7, 0x41F8, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x41FD);
    // MOV word ptr [BP + -0x2],0x1c (1000_41F8 / 0x141F8)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1C;
    CheckExternalEvents(cs7, 0x4201);
    // CMP word ptr [BP + 0x8],0x3a (1000_41FD / 0x141FD)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x3A);
    CheckExternalEvents(cs7, 0x4203);
    // JL 0x1000:4208 (1000_4201 / 0x14201)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4208_14208;
    }
    CheckExternalEvents(cs7, 0x4208);
    // MOV word ptr [BP + -0x2],0x1d (1000_4203 / 0x14203)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1D;
    label_1000_4208_14208:
    CheckExternalEvents(cs7, 0x420C);
    // CMP word ptr [BP + 0x8],0x41 (1000_4208 / 0x14208)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x41);
    CheckExternalEvents(cs7, 0x420E);
    // JL 0x1000:4213 (1000_420C / 0x1420C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4213_14213;
    }
    CheckExternalEvents(cs7, 0x4213);
    // MOV word ptr [BP + -0x2],0x21 (1000_420E / 0x1420E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x21;
    label_1000_4213_14213:
    CheckExternalEvents(cs7, 0x4217);
    // CMP word ptr [BP + 0x8],0x48 (1000_4213 / 0x14213)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x48);
    CheckExternalEvents(cs7, 0x4219);
    // JL 0x1000:421e (1000_4217 / 0x14217)
    if(SignFlag != OverflowFlag) {
      goto label_1000_421E_1421E;
    }
    CheckExternalEvents(cs7, 0x421E);
    // MOV word ptr [BP + -0x2],0x22 (1000_4219 / 0x14219)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x22;
    label_1000_421E_1421E:
    CheckExternalEvents(cs7, 0x4222);
    // CMP word ptr [BP + 0x8],0x4f (1000_421E / 0x1421E)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x4F);
    CheckExternalEvents(cs7, 0x4224);
    // JL 0x1000:4229 (1000_4222 / 0x14222)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4229_14229;
    }
    CheckExternalEvents(cs7, 0x4229);
    // MOV word ptr [BP + -0x2],0x1e (1000_4224 / 0x14224)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1E;
    label_1000_4229_14229:
    CheckExternalEvents(cs7, 0x422D);
    // CMP word ptr [BP + 0x8],0x51 (1000_4229 / 0x14229)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x51);
    CheckExternalEvents(cs7, 0x422F);
    // JL 0x1000:4234 (1000_422D / 0x1422D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4234_14234;
    }
    CheckExternalEvents(cs7, 0x4234);
    // MOV word ptr [BP + -0x2],0x23 (1000_422F / 0x1422F)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x23;
    label_1000_4234_14234:
    CheckExternalEvents(cs7, 0x4238);
    // CMP word ptr [BP + 0x8],0x53 (1000_4234 / 0x14234)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x53);
    CheckExternalEvents(cs7, 0x423A);
    // JL 0x1000:423f (1000_4238 / 0x14238)
    if(SignFlag != OverflowFlag) {
      goto label_1000_423F_1423F;
    }
    CheckExternalEvents(cs7, 0x423F);
    // MOV word ptr [BP + -0x2],0x20 (1000_423A / 0x1423A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x20;
    label_1000_423F_1423F:
    CheckExternalEvents(cs7, 0x4243);
    // CMP word ptr [BP + 0x8],0x55 (1000_423F / 0x1423F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x55);
    CheckExternalEvents(cs7, 0x4245);
    // JL 0x1000:424a (1000_4243 / 0x14243)
    if(SignFlag != OverflowFlag) {
      goto label_1000_424A_1424A;
    }
    CheckExternalEvents(cs7, 0x424A);
    // MOV word ptr [BP + -0x2],0x1f (1000_4245 / 0x14245)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1F;
    label_1000_424A_1424A:
    CheckExternalEvents(cs7, 0x424D);
    // MOV AX,0x7d (1000_424A / 0x1424A)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x4250);
    // IMUL word ptr [BP + 0x6] (1000_424D / 0x1424D)
    int resImul1000_424D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_424D);
    DX = (ushort)(resImul1000_424D >> 16);
    CheckExternalEvents(cs7, 0x4252);
    // MOV BX,AX (1000_4250 / 0x14250)
    BX = AX;
    CheckExternalEvents(cs7, 0x4256);
    // MOV ES,word ptr [0x55d4] (1000_4252 / 0x14252)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x425C);
    // CMP byte ptr ES:[BX + 0xc79f],0xc8 (1000_4256 / 0x14256)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC79F)], 0xC8);
    CheckExternalEvents(cs7, 0x425E);
    // JNZ 0x1000:4263 (1000_425C / 0x1425C)
    if(!ZeroFlag) {
      goto label_1000_4263_14263;
    }
    CheckExternalEvents(cs7, 0x4261);
    // MOV AX,0x1 (1000_425E / 0x1425E)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x4263);
    // JMP 0x1000:4275 (1000_4261 / 0x14261)
    goto label_1000_4275_14275;
    label_1000_4263_14263:
    CheckExternalEvents(cs7, 0x4266);
    // MOV AX,0x7d (1000_4263 / 0x14263)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x4269);
    // IMUL word ptr [BP + 0x6] (1000_4266 / 0x14266)
    int resImul1000_4266 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_4266);
    DX = (ushort)(resImul1000_4266 >> 16);
    CheckExternalEvents(cs7, 0x426B);
    // MOV BX,AX (1000_4269 / 0x14269)
    BX = AX;
    CheckExternalEvents(cs7, 0x426E);
    // ADD BX,word ptr [BP + -0x2] (1000_426B / 0x1426B)
    // BX += UInt16[SS, (ushort)(BP - 0x2)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x4273);
    // MOV AL,byte ptr ES:[BX + 0xc724] (1000_426E / 0x1426E)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs7, 0x4275);
    // SUB AH,AH (1000_4273 / 0x14273)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    label_1000_4275_14275:
    CheckExternalEvents(cs7, 0x4277);
    // MOV SP,BP (1000_4275 / 0x14275)
    SP = BP;
    CheckExternalEvents(cs7, 0x4278);
    // POP BP (1000_4277 / 0x14277)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4279);
    // RETF  (1000_4278 / 0x14278)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_4279_14279(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4279_14279:
    CheckExternalEvents(cs7, 0x427A);
    // PUSH BP (1000_4279 / 0x14279)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x427C);
    // MOV BP,SP (1000_427A / 0x1427A)
    BP = SP;
    CheckExternalEvents(cs7, 0x427F);
    // MOV AX,0x2 (1000_427C / 0x1427C)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x4284);
    // CALLF 0x1000:cecc (1000_427F / 0x1427F)
    FarCall(cs7, 0x4284, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x4287);
    // MOV AL,byte ptr [BP + 0x6] (1000_4284 / 0x14284)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x428B);
    // MOV ES,word ptr [0x55d4] (1000_4287 / 0x14287)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x4290);
    // MOV BL,byte ptr ES:[0xd557] (1000_428B / 0x1428B)
    BL = UInt8[ES, 0xD557];
    CheckExternalEvents(cs7, 0x4292);
    // SUB BH,BH (1000_4290 / 0x14290)
    // BH -= BH;
    BH = Alu8.Sub(BH, BH);
    CheckExternalEvents(cs7, 0x4297);
    // MOV byte ptr ES:[BX + 0xd457],AL (1000_4292 / 0x14292)
    UInt8[ES, (ushort)(BX + 0xD457)] = AL;
    CheckExternalEvents(cs7, 0x429A);
    // MOV AX,word ptr [BP + 0x8] (1000_4297 / 0x14297)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x429D);
    // OR AX,word ptr [BP + 0xa] (1000_429A / 0x1429A)
    // AX |= UInt16[SS, (ushort)(BP + 0xA)];
    AX = Alu16.Or(AX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs7, 0x429F);
    // MOV AL,AH (1000_429D / 0x1429D)
    AL = AH;
    CheckExternalEvents(cs7, 0x42A1);
    // SUB AH,AH (1000_429F / 0x1429F)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x42A4);
    // MOV word ptr [BP + -0x2],AX (1000_42A1 / 0x142A1)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x42A7);
    // MOV AL,byte ptr [BP + -0x2] (1000_42A4 / 0x142A4)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x42AC);
    // MOV BL,byte ptr ES:[0xd557] (1000_42A7 / 0x142A7)
    BL = UInt8[ES, 0xD557];
    CheckExternalEvents(cs7, 0x42B1);
    // MOV byte ptr ES:[BX + 0xd497],AL (1000_42AC / 0x142AC)
    UInt8[ES, (ushort)(BX + 0xD497)] = AL;
    CheckExternalEvents(cs7, 0x42B4);
    // MOV AL,byte ptr [BP + 0x8] (1000_42B1 / 0x142B1)
    AL = UInt8[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x42B6);
    // AND AL,0x7f (1000_42B4 / 0x142B4)
    // AL &= 0x7F;
    AL = Alu8.And(AL, 0x7F);
    CheckExternalEvents(cs7, 0x42BB);
    // MOV BL,byte ptr ES:[0xd557] (1000_42B6 / 0x142B6)
    BL = UInt8[ES, 0xD557];
    CheckExternalEvents(cs7, 0x42C0);
    // MOV byte ptr ES:[BX + 0xd4d7],AL (1000_42BB / 0x142BB)
    UInt8[ES, (ushort)(BX + 0xD4D7)] = AL;
    CheckExternalEvents(cs7, 0x42C3);
    // MOV AL,byte ptr [BP + 0xa] (1000_42C0 / 0x142C0)
    AL = UInt8[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0x42C5);
    // AND AL,0x7f (1000_42C3 / 0x142C3)
    // AL &= 0x7F;
    AL = Alu8.And(AL, 0x7F);
    CheckExternalEvents(cs7, 0x42CA);
    // MOV BL,byte ptr ES:[0xd557] (1000_42C5 / 0x142C5)
    BL = UInt8[ES, 0xD557];
    CheckExternalEvents(cs7, 0x42CF);
    // INC word ptr ES:[0xd557] (1000_42CA / 0x142CA)
    UInt16[ES, 0xD557] = Alu16.Inc(UInt16[ES, 0xD557]);
    CheckExternalEvents(cs7, 0x42D4);
    // MOV byte ptr ES:[BX + 0xd517],AL (1000_42CF / 0x142CF)
    UInt8[ES, (ushort)(BX + 0xD517)] = AL;
    CheckExternalEvents(cs7, 0x42DA);
    // CMP byte ptr ES:[0xd557],0x3f (1000_42D4 / 0x142D4)
    Alu8.Sub(UInt8[ES, 0xD557], 0x3F);
    CheckExternalEvents(cs7, 0x42DC);
    // JBE 0x1000:42e1 (1000_42DA / 0x142DA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_42E1_142E1;
    }
    CheckExternalEvents(cs7, 0x42E1);
    // MOV byte ptr ES:[0xd557],AH (1000_42DC / 0x142DC)
    UInt8[ES, 0xD557] = AH;
    label_1000_42E1_142E1:
    CheckExternalEvents(cs7, 0x42E3);
    // MOV SP,BP (1000_42E1 / 0x142E1)
    SP = BP;
    CheckExternalEvents(cs7, 0x42E4);
    // POP BP (1000_42E3 / 0x142E3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x42E5);
    // RETF  (1000_42E4 / 0x142E4)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_42E5_142E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_42E5_142E5:
    CheckExternalEvents(cs7, 0x42E6);
    // PUSH BP (1000_42E5 / 0x142E5)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x42E8);
    // MOV BP,SP (1000_42E6 / 0x142E6)
    BP = SP;
    CheckExternalEvents(cs7, 0x42EB);
    // MOV AX,0x6 (1000_42E8 / 0x142E8)
    AX = 0x6;
    CheckExternalEvents(cs7, 0x42F0);
    // CALLF 0x1000:cecc (1000_42EB / 0x142EB)
    FarCall(cs7, 0x42F0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x42F1);
    // PUSH DI (1000_42F0 / 0x142F0)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x42F2);
    // PUSH SI (1000_42F1 / 0x142F1)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x42F6);
    // MOV ES,word ptr [0x55cc] (1000_42F2 / 0x142F2)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x42FA);
    // MOV AX,ES:[0xa44b] (1000_42F6 / 0x142F6)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x42FE);
    // MOV ES,word ptr [0x55ce] (1000_42FA / 0x142FA)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x4303);
    // OR AX,word ptr ES:[0xa44d] (1000_42FE / 0x142FE)
    // AX |= UInt16[ES, 0xA44D];
    AX = Alu16.Or(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs7, 0x4305);
    // MOV CL,0x8 (1000_4303 / 0x14303)
    CL = 0x8;
    CheckExternalEvents(cs7, 0x4307);
    // SHR AX,CL (1000_4305 / 0x14305)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs7, 0x430A);
    // MOV word ptr [BP + -0x2],AX (1000_4307 / 0x14307)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x430E);
    // MOV byte ptr [BP + -0x1],0x0 (1000_430A / 0x1430A)
    UInt8[SS, (ushort)(BP - 0x1)] = 0x0;
    CheckExternalEvents(cs7, 0x4312);
    // SUB word ptr [BP + -0x2],0x11 (1000_430E / 0x1430E)
    // UInt16[SS, (ushort)(BP - 0x2)] -= 0x11;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x11);
    CheckExternalEvents(cs7, 0x4317);
    // MOV word ptr [BP + -0x6],0x0 (1000_4312 / 0x14312)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_1000_4317_14317:
    CheckExternalEvents(cs7, 0x431C);
    // MOV word ptr [BP + -0x4],0x0 (1000_4317 / 0x14317)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_1000_431C_1431C:
    CheckExternalEvents(cs7, 0x431F);
    // MOV SI,word ptr [BP + -0x2] (1000_431C / 0x1431C)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x4322);
    // ADD SI,word ptr [BP + -0x4] (1000_431F / 0x1431F)
    // SI += UInt16[SS, (ushort)(BP - 0x4)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs7, 0x4324);
    // JS 0x1000:436a (1000_4322 / 0x14322)
    if(SignFlag) {
      goto label_1000_436A_1436A;
    }
    CheckExternalEvents(cs7, 0x4328);
    // CMP SI,0x100 (1000_4324 / 0x14324)
    Alu16.Sub(SI, 0x100);
    CheckExternalEvents(cs7, 0x432A);
    // JGE 0x1000:436a (1000_4328 / 0x14328)
    if(SignFlag == OverflowFlag) {
      goto label_1000_436A_1436A;
    }
    CheckExternalEvents(cs7, 0x432E);
    // MOV ES,word ptr [0x5604] (1000_432A / 0x1432A)
    ES = UInt16[DS, 0x5604];
    CheckExternalEvents(cs7, 0x4334);
    // CMP byte ptr ES:[SI + 0x30],0x0 (1000_432E / 0x1432E)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0x30)], 0x0);
    CheckExternalEvents(cs7, 0x4336);
    // JZ 0x1000:436a (1000_4334 / 0x14334)
    if(ZeroFlag) {
      goto label_1000_436A_1436A;
    }
    CheckExternalEvents(cs7, 0x4339);
    // MOV AX,0x3 (1000_4336 / 0x14336)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x433C);
    // IMUL word ptr [BP + -0x6] (1000_4339 / 0x14339)
    int resImul1000_4339 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul1000_4339);
    DX = (ushort)(resImul1000_4339 >> 16);
    CheckExternalEvents(cs7, 0x433E);
    // MOV DI,AX (1000_433C / 0x1433C)
    DI = AX;
    CheckExternalEvents(cs7, 0x4341);
    // ADD DI,word ptr [BP + -0x4] (1000_433E / 0x1433E)
    // DI += UInt16[SS, (ushort)(BP - 0x4)];
    DI = Alu16.Add(DI, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs7, 0x4343);
    // MOV BX,DI (1000_4341 / 0x14341)
    BX = DI;
    CheckExternalEvents(cs7, 0x4345);
    // SHL BX,0x1 (1000_4343 / 0x14343)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x4347);
    // SHL BX,0x1 (1000_4345 / 0x14345)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x434B);
    // MOV ES,word ptr [0x5628] (1000_4347 / 0x14347)
    ES = UInt16[DS, 0x5628];
    CheckExternalEvents(cs7, 0x4350);
    // LES BX,ES:[BX + 0x170] (1000_434B / 0x1434B)
    BX = UInt16[ES, (ushort)(BX + 0x170)];
    ES = UInt16[ES, (ushort)(BX + 0x170 + 2)];
    CheckExternalEvents(cs7, 0x4354);
    // CMP byte ptr ES:[BX],0x90 (1000_4350 / 0x14350)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x90);
    CheckExternalEvents(cs7, 0x4356);
    // JZ 0x1000:436a (1000_4354 / 0x14354)
    if(ZeroFlag) {
      goto label_1000_436A_1436A;
    }
    CheckExternalEvents(cs7, 0x435A);
    // MOV ES,word ptr [0x5604] (1000_4356 / 0x14356)
    ES = UInt16[DS, 0x5604];
    CheckExternalEvents(cs7, 0x435F);
    // MOV AL,byte ptr ES:[SI + 0x30] (1000_435A / 0x1435A)
    AL = UInt8[ES, (ushort)(SI + 0x30)];
    CheckExternalEvents(cs7, 0x4360);
    // CBW  (1000_435F / 0x1435F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4361);
    // PUSH AX (1000_4360 / 0x14360)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4362);
    // PUSH DI (1000_4361 / 0x14361)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x4367);
    // CALLF 0x0000:44a8 (1000_4362 / 0x14362)
    FarCall(cs7, 0x4367, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs7, 0x436A);
    // ADD SP,0x4 (1000_4367 / 0x14367)
    SP += 0x4;
    label_1000_436A_1436A:
    CheckExternalEvents(cs7, 0x436D);
    // INC word ptr [BP + -0x4] (1000_436A / 0x1436A)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x4371);
    // CMP word ptr [BP + -0x4],0x3 (1000_436D / 0x1436D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs7, 0x4373);
    // JL 0x1000:431c (1000_4371 / 0x14371)
    if(SignFlag != OverflowFlag) {
      goto label_1000_431C_1431C;
    }
    CheckExternalEvents(cs7, 0x4377);
    // ADD word ptr [BP + -0x2],0x10 (1000_4373 / 0x14373)
    UInt16[SS, (ushort)(BP - 0x2)] += 0x10;
    CheckExternalEvents(cs7, 0x437A);
    // INC word ptr [BP + -0x6] (1000_4377 / 0x14377)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs7, 0x437E);
    // CMP word ptr [BP + -0x6],0x3 (1000_437A / 0x1437A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs7, 0x4380);
    // JL 0x1000:4317 (1000_437E / 0x1437E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4317_14317;
    }
    CheckExternalEvents(cs7, 0x4385);
    // CALLF 0x1000:bc98 (1000_4380 / 0x14380)
    FarCall(cs7, 0x4385, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs7, 0x4386);
    // POP SI (1000_4385 / 0x14385)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4387);
    // POP DI (1000_4386 / 0x14386)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4389);
    // MOV SP,BP (1000_4387 / 0x14387)
    SP = BP;
    CheckExternalEvents(cs7, 0x438A);
    // POP BP (1000_4389 / 0x14389)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x438B);
    // RETF  (1000_438A / 0x1438A)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_438B_1438B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_438B_1438B:
    CheckExternalEvents(cs7, 0x438C);
    // PUSH BP (1000_438B / 0x1438B)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x438E);
    // MOV BP,SP (1000_438C / 0x1438C)
    BP = SP;
    CheckExternalEvents(cs7, 0x4391);
    // MOV AX,0x14 (1000_438E / 0x1438E)
    AX = 0x14;
    CheckExternalEvents(cs7, 0x4396);
    // CALLF 0x1000:cecc (1000_4391 / 0x14391)
    FarCall(cs7, 0x4396, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x4397);
    // PUSH SI (1000_4396 / 0x14396)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x439B);
    // MOV ES,word ptr [0x55cc] (1000_4397 / 0x14397)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x439F);
    // MOV AX,ES:[0xa44b] (1000_439B / 0x1439B)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x43A2);
    // MOV word ptr [BP + -0x12],AX (1000_439F / 0x1439F)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs7, 0x43A6);
    // MOV ES,word ptr [0x55ce] (1000_43A2 / 0x143A2)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x43AA);
    // MOV AX,ES:[0xa44d] (1000_43A6 / 0x143A6)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x43AD);
    // MOV word ptr [BP + -0x14],AX (1000_43AA / 0x143AA)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs7, 0x43B1);
    // MOV ES,word ptr [0x55d2] (1000_43AD / 0x143AD)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs7, 0x43B5);
    // MOV AX,ES:[0x400c] (1000_43B1 / 0x143B1)
    AX = UInt16[ES, 0x400C];
    CheckExternalEvents(cs7, 0x43B8);
    // MOV word ptr [BP + -0x4],AX (1000_43B5 / 0x143B5)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x43BC);
    // MOV ES,word ptr [0x55d6] (1000_43B8 / 0x143B8)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs7, 0x43C0);
    // MOV AX,ES:[0x403e] (1000_43BC / 0x143BC)
    AX = UInt16[ES, 0x403E];
    CheckExternalEvents(cs7, 0x43C3);
    // MOV word ptr [BP + -0x6],AX (1000_43C0 / 0x143C0)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x43C7);
    // MOV ES,word ptr [0x55d4] (1000_43C3 / 0x143C3)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x43CD);
    // CMP byte ptr ES:[0xc620],0x8 (1000_43C7 / 0x143C7)
    Alu8.Sub(UInt8[ES, 0xC620], 0x8);
    CheckExternalEvents(cs7, 0x43CF);
    // JZ 0x1000:43f3 (1000_43CD / 0x143CD)
    if(ZeroFlag) {
      goto label_1000_43F3_143F3;
    }
    CheckExternalEvents(cs7, 0x43D3);
    // MOV AL,ES:[0xc620] (1000_43CF / 0x143CF)
    AL = UInt8[ES, 0xC620];
    CheckExternalEvents(cs7, 0x43D4);
    // CBW  (1000_43D3 / 0x143D3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x43D7);
    // MOV word ptr [BP + -0x6],AX (1000_43D4 / 0x143D4)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x43D9);
    // MOV SI,AX (1000_43D7 / 0x143D7)
    SI = AX;
    CheckExternalEvents(cs7, 0x43DB);
    // SHL SI,0x1 (1000_43D9 / 0x143D9)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x43DF);
    // MOV ES,word ptr [0x55d2] (1000_43DB / 0x143DB)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs7, 0x43E4);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_43DF / 0x143DF)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x43E7);
    // MOV word ptr [BP + -0x4],AX (1000_43E4 / 0x143E4)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x43EB);
    // MOV ES,word ptr [0x55d6] (1000_43E7 / 0x143E7)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs7, 0x43F0);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_43EB / 0x143EB)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs7, 0x43F3);
    // MOV word ptr [BP + -0x6],AX (1000_43F0 / 0x143F0)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    label_1000_43F3_143F3:
    CheckExternalEvents(cs7, 0x43F6);
    // PUSH word ptr [BP + -0x6] (1000_43F3 / 0x143F3)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs7, 0x43F9);
    // PUSH word ptr [BP + -0x4] (1000_43F6 / 0x143F6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs7, 0x43FE);
    // CALLF 0x0000:2ebb (1000_43F9 / 0x143F9)
    FarCall(cs7, 0x43FE, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x4401);
    // ADD SP,0x4 (1000_43FE / 0x143FE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4405);
    // MOV ES,word ptr [0x55ce] (1000_4401 / 0x14401)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x440A);
    // PUSH word ptr ES:[0xa44d] (1000_4405 / 0x14405)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs7, 0x440E);
    // MOV ES,word ptr [0x55cc] (1000_440A / 0x1440A)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x4413);
    // PUSH word ptr ES:[0xa44b] (1000_440E / 0x1440E)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs7, 0x4418);
    // CALLF 0x1000:b204 (1000_4413 / 0x14413)
    FarCall(cs7, 0x4418, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs7, 0x441B);
    // ADD SP,0x4 (1000_4418 / 0x14418)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4420);
    // CALLF 0x1000:bce8 (1000_441B / 0x1441B)
    FarCall(cs7, 0x4420, unknown_19EF_1DF8_1BCE8);
    CheckExternalEvents(cs7, 0x4424);
    // MOV ES,word ptr [0x55cc] (1000_4420 / 0x14420)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x4428);
    // MOV AX,ES:[0xa44b] (1000_4424 / 0x14424)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x442C);
    // MOV ES,word ptr [0x5614] (1000_4428 / 0x14428)
    ES = UInt16[DS, 0x5614];
    CheckExternalEvents(cs7, 0x4430);
    // MOV ES:[0xe486],AX (1000_442C / 0x1442C)
    UInt16[ES, 0xE486] = AX;
    CheckExternalEvents(cs7, 0x4434);
    // MOV ES,word ptr [0x55ce] (1000_4430 / 0x14430)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x4438);
    // MOV AX,ES:[0xa44d] (1000_4434 / 0x14434)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x443C);
    // MOV ES,word ptr [0x5616] (1000_4438 / 0x14438)
    ES = UInt16[DS, 0x5616];
    CheckExternalEvents(cs7, 0x4440);
    // MOV ES:[0xe488],AX (1000_443C / 0x1443C)
    UInt16[ES, 0xE488] = AX;
    CheckExternalEvents(cs7, 0x4445);
    // MOV word ptr [BP + -0x2],0x0 (1000_4440 / 0x14440)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x444A);
    // MOV word ptr [BP + -0x8],0x1a (1000_4445 / 0x14445)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1A;
    CheckExternalEvents(cs7, 0x444F);
    // MOV word ptr [BP + -0xa],0xc (1000_444A / 0x1444A)
    UInt16[SS, (ushort)(BP - 0xA)] = 0xC;
    CheckExternalEvents(cs7, 0x4454);
    // MOV word ptr [BP + -0x10],0xc (1000_444F / 0x1444F)
    UInt16[SS, (ushort)(BP - 0x10)] = 0xC;
    label_1000_4454_14454:
    CheckExternalEvents(cs7, 0x4458);
    // CMP word ptr [BP + -0x2],0x0 (1000_4454 / 0x14454)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs7, 0x445A);
    // JNZ 0x1000:4488 (1000_4458 / 0x14458)
    if(!ZeroFlag) {
      goto label_1000_4488_14488;
    }
    CheckExternalEvents(cs7, 0x445D);
    // MOV SI,word ptr [BP + -0x10] (1000_445A / 0x1445A)
    SI = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x445F);
    // SHL SI,0x1 (1000_445D / 0x1445D)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x4463);
    // MOV ES,word ptr [0x55e0] (1000_445F / 0x1445F)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs7, 0x4469);
    // CMP word ptr ES:[SI + 0x406a],0x0 (1000_4463 / 0x14463)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x446B);
    // JZ 0x1000:4488 (1000_4469 / 0x14469)
    if(ZeroFlag) {
      goto label_1000_4488_14488;
    }
    CheckExternalEvents(cs7, 0x446F);
    // MOV ES,word ptr [0x55d2] (1000_446B / 0x1446B)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs7, 0x4474);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_446F / 0x1446F)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x4477);
    // MOV word ptr [BP + -0xc],AX (1000_4474 / 0x14474)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x447B);
    // MOV ES,word ptr [0x55d6] (1000_4477 / 0x14477)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs7, 0x4480);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_447B / 0x1447B)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs7, 0x4483);
    // MOV word ptr [BP + -0xe],AX (1000_4480 / 0x14480)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs7, 0x4488);
    // MOV word ptr [BP + -0x2],0x1 (1000_4483 / 0x14483)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_1000_4488_14488:
    CheckExternalEvents(cs7, 0x448B);
    // INC word ptr [BP + -0x10] (1000_4488 / 0x14488)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    CheckExternalEvents(cs7, 0x448F);
    // CMP word ptr [BP + -0x10],0x18 (1000_448B / 0x1448B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0x18);
    CheckExternalEvents(cs7, 0x4491);
    // JL 0x1000:4454 (1000_448F / 0x1448F)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4454_14454;
    }
    CheckExternalEvents(cs7, 0x4495);
    // MOV ES,word ptr [0x561a] (1000_4491 / 0x14491)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x449C);
    // MOV word ptr ES:[0x3770],0x1e (1000_4495 / 0x14495)
    UInt16[ES, 0x3770] = 0x1E;
    CheckExternalEvents(cs7, 0x44A0);
    // CMP word ptr [BP + -0x2],0x0 (1000_449C / 0x1449C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs7, 0x44A2);
    // JNZ 0x1000:44a5 (1000_44A0 / 0x144A0)
    if(!ZeroFlag) {
      goto label_1000_44A5_144A5;
    }
    CheckExternalEvents(cs7, 0x44A5);
    // JMP 0x1000:453e (1000_44A2 / 0x144A2)
    goto label_1000_453E_1453E;
    label_1000_44A5_144A5:
    CheckExternalEvents(cs7, 0x44AA);
    // MOV word ptr [BP + -0x2],0x0 (1000_44A5 / 0x144A5)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x44AD);
    // JMP 0x1000:452f (1000_44AA / 0x144AA)
    goto label_1000_452F_1452F;
    label_1000_44AD_144AD:
    CheckExternalEvents(cs7, 0x44B1);
    // MOV ES,word ptr [0x5614] (1000_44AD / 0x144AD)
    ES = UInt16[DS, 0x5614];
    CheckExternalEvents(cs7, 0x44B4);
    // MOV AX,word ptr [BP + -0xc] (1000_44B1 / 0x144B1)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs7, 0x44B9);
    // CMP word ptr ES:[0xe486],AX (1000_44B4 / 0x144B4)
    Alu16.Sub(UInt16[ES, 0xE486], AX);
    CheckExternalEvents(cs7, 0x44BB);
    // JNZ 0x1000:44c9 (1000_44B9 / 0x144B9)
    if(!ZeroFlag) {
      goto label_1000_44C9_144C9;
    }
    CheckExternalEvents(cs7, 0x44BF);
    // MOV ES,word ptr [0x5616] (1000_44BB / 0x144BB)
    ES = UInt16[DS, 0x5616];
    CheckExternalEvents(cs7, 0x44C2);
    // MOV AX,word ptr [BP + -0xe] (1000_44BF / 0x144BF)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0x44C7);
    // CMP word ptr ES:[0xe488],AX (1000_44C2 / 0x144C2)
    Alu16.Sub(UInt16[ES, 0xE488], AX);
    CheckExternalEvents(cs7, 0x44C9);
    // JZ 0x1000:453e (1000_44C7 / 0x144C7)
    if(ZeroFlag) {
      goto label_1000_453E_1453E;
    }
    label_1000_44C9_144C9:
    CheckExternalEvents(cs7, 0x44CB);
    // SUB AX,AX (1000_44C9 / 0x144C9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x44CC);
    // PUSH AX (1000_44CB / 0x144CB)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x44CF);
    // PUSH word ptr [BP + -0xa] (1000_44CC / 0x144CC)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x44D2);
    // PUSH word ptr [BP + -0x8] (1000_44CF / 0x144CF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0x44D5);
    // PUSH word ptr [BP + -0xe] (1000_44D2 / 0x144D2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs7, 0x44D8);
    // PUSH word ptr [BP + -0xc] (1000_44D5 / 0x144D5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x44DB);
    // MOV AX,0x80 (1000_44D8 / 0x144D8)
    AX = 0x80;
    CheckExternalEvents(cs7, 0x44DC);
    // PUSH AX (1000_44DB / 0x144DB)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x44E1);
    // CALLF 0x0000:fa16 (1000_44DC / 0x144DC)
    FarCall(cs7, 0x44E1, unknown_0FA1_0006_0FA16);
    CheckExternalEvents(cs7, 0x44E4);
    // ADD SP,0xc (1000_44E1 / 0x144E1)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs7, 0x44E8);
    // MOV ES,word ptr [0x561c] (1000_44E4 / 0x144E4)
    ES = UInt16[DS, 0x561C];
    CheckExternalEvents(cs7, 0x44EC);
    // MOV AX,ES:[0x458e] (1000_44E8 / 0x144E8)
    AX = UInt16[ES, 0x458E];
    CheckExternalEvents(cs7, 0x44EF);
    // ADD word ptr [BP + -0x8],AX (1000_44EC / 0x144EC)
    // UInt16[SS, (ushort)(BP - 0x8)] += AX;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs7, 0x44F3);
    // MOV ES,word ptr [0x561e] (1000_44EF / 0x144EF)
    ES = UInt16[DS, 0x561E];
    CheckExternalEvents(cs7, 0x44F7);
    // MOV AX,ES:[0x4590] (1000_44F3 / 0x144F3)
    AX = UInt16[ES, 0x4590];
    CheckExternalEvents(cs7, 0x44FA);
    // ADD word ptr [BP + -0xa],AX (1000_44F7 / 0x144F7)
    // UInt16[SS, (ushort)(BP - 0xA)] += AX;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xA)], AX);
    CheckExternalEvents(cs7, 0x44FE);
    // MOV ES,word ptr [0x561a] (1000_44FA / 0x144FA)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x4503);
    // DEC word ptr ES:[0x3770] (1000_44FE / 0x144FE)
    UInt16[ES, 0x3770] = Alu16.Dec(UInt16[ES, 0x3770]);
    CheckExternalEvents(cs7, 0x4507);
    // MOV ES,word ptr [0x5614] (1000_4503 / 0x14503)
    ES = UInt16[DS, 0x5614];
    CheckExternalEvents(cs7, 0x450A);
    // MOV AX,word ptr [BP + -0xc] (1000_4507 / 0x14507)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs7, 0x450F);
    // CMP word ptr ES:[0xe486],AX (1000_450A / 0x1450A)
    Alu16.Sub(UInt16[ES, 0xE486], AX);
    CheckExternalEvents(cs7, 0x4511);
    // JNZ 0x1000:452f (1000_450F / 0x1450F)
    if(!ZeroFlag) {
      goto label_1000_452F_1452F;
    }
    CheckExternalEvents(cs7, 0x4515);
    // MOV ES,word ptr [0x5616] (1000_4511 / 0x14511)
    ES = UInt16[DS, 0x5616];
    CheckExternalEvents(cs7, 0x4518);
    // MOV AX,word ptr [BP + -0xe] (1000_4515 / 0x14515)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0x451D);
    // CMP word ptr ES:[0xe488],AX (1000_4518 / 0x14518)
    Alu16.Sub(UInt16[ES, 0xE488], AX);
    CheckExternalEvents(cs7, 0x451F);
    // JNZ 0x1000:452f (1000_451D / 0x1451D)
    if(!ZeroFlag) {
      goto label_1000_452F_1452F;
    }
    CheckExternalEvents(cs7, 0x4523);
    // MOV ES,word ptr [0x561a] (1000_451F / 0x1451F)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x452A);
    // MOV word ptr ES:[0x3770],0x0 (1000_4523 / 0x14523)
    UInt16[ES, 0x3770] = 0x0;
    CheckExternalEvents(cs7, 0x452F);
    // MOV word ptr [BP + -0x2],0x1 (1000_452A / 0x1452A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_1000_452F_1452F:
    CheckExternalEvents(cs7, 0x4533);
    // MOV ES,word ptr [0x561a] (1000_452F / 0x1452F)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x4539);
    // CMP word ptr ES:[0x3770],0x0 (1000_4533 / 0x14533)
    Alu16.Sub(UInt16[ES, 0x3770], 0x0);
    CheckExternalEvents(cs7, 0x453B);
    // JLE 0x1000:453e (1000_4539 / 0x14539)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_453E_1453E;
    }
    CheckExternalEvents(cs7, 0x453E);
    // JMP 0x1000:44ad (1000_453B / 0x1453B)
    goto label_1000_44AD_144AD;
    label_1000_453E_1453E:
    CheckExternalEvents(cs7, 0x4541);
    // PUSH word ptr [BP + -0x14] (1000_453E / 0x1453E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs7, 0x4544);
    // PUSH word ptr [BP + -0x12] (1000_4541 / 0x14541)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs7, 0x4545);
    // PUSH CS (1000_4544 / 0x14544)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x4548);
    // CALL 0x1000:4553 (1000_4545 / 0x14545)
    NearCall(cs7, 0x4548, ghidra_guess_1000_4553_14553);
    CheckExternalEvents(cs7, 0x454B);
    // ADD SP,0x4 (1000_4548 / 0x14548)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x454E);
    // MOV AX,word ptr [BP + -0x2] (1000_454B / 0x1454B)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x454F);
    // POP SI (1000_454E / 0x1454E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4551);
    // MOV SP,BP (1000_454F / 0x1454F)
    SP = BP;
    CheckExternalEvents(cs7, 0x4552);
    // POP BP (1000_4551 / 0x14551)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x4553);
    // RETF  (1000_4552 / 0x14552)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_4553_14553(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_4553_14553:
    CheckExternalEvents(cs7, 0x4554);
    // PUSH BP (1000_4553 / 0x14553)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x4556);
    // MOV BP,SP (1000_4554 / 0x14554)
    BP = SP;
    CheckExternalEvents(cs7, 0x4558);
    // XOR AX,AX (1000_4556 / 0x14556)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0x455D);
    // CALLF 0x1000:cecc (1000_4558 / 0x14558)
    FarCall(cs7, 0x455D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x4560);
    // PUSH word ptr [BP + 0x8] (1000_455D / 0x1455D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs7, 0x4563);
    // PUSH word ptr [BP + 0x6] (1000_4560 / 0x14560)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x4568);
    // CALLF 0x0000:2ebb (1000_4563 / 0x14563)
    FarCall(cs7, 0x4568, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x456B);
    // ADD SP,0x4 (1000_4568 / 0x14568)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x456F);
    // MOV ES,word ptr [0x55ce] (1000_456B / 0x1456B)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x4574);
    // PUSH word ptr ES:[0xa44d] (1000_456F / 0x1456F)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs7, 0x4578);
    // MOV ES,word ptr [0x55cc] (1000_4574 / 0x14574)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x457D);
    // PUSH word ptr ES:[0xa44b] (1000_4578 / 0x14578)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs7, 0x4582);
    // CALLF 0x1000:b204 (1000_457D / 0x1457D)
    FarCall(cs7, 0x4582, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs7, 0x4585);
    // ADD SP,0x4 (1000_4582 / 0x14582)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x458A);
    // CALLF 0x1000:bce8 (1000_4585 / 0x14585)
    FarCall(cs7, 0x458A, unknown_19EF_1DF8_1BCE8);
    CheckExternalEvents(cs7, 0x458B);
    // POP BP (1000_458A / 0x1458A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x458C);
    // RETF  (1000_458B / 0x1458B)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_458C_1458C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_458C_1458C:
    CheckExternalEvents(cs7, 0x458D);
    // PUSH BP (1000_458C / 0x1458C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x458F);
    // MOV BP,SP (1000_458D / 0x1458D)
    BP = SP;
    CheckExternalEvents(cs7, 0x4592);
    // MOV AX,0x80 (1000_458F / 0x1458F)
    AX = 0x80;
    CheckExternalEvents(cs7, 0x4597);
    // CALLF 0x1000:cecc (1000_4592 / 0x14592)
    FarCall(cs7, 0x4597, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x4598);
    // PUSH DI (1000_4597 / 0x14597)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x4599);
    // PUSH SI (1000_4598 / 0x14598)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x459D);
    // MOV ES,word ptr [0x562a] (1000_4599 / 0x14599)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x45A1);
    // MOV AX,ES:[0xa44b] (1000_459D / 0x1459D)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x45A4);
    // MOV word ptr [BP + -0x3e],AX (1000_45A1 / 0x145A1)
    UInt16[SS, (ushort)(BP - 0x3E)] = AX;
    CheckExternalEvents(cs7, 0x45A8);
    // MOV ES,word ptr [0x562c] (1000_45A4 / 0x145A4)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x45AC);
    // MOV AX,ES:[0xa44d] (1000_45A8 / 0x145A8)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x45AF);
    // MOV word ptr [BP + -0x4a],AX (1000_45AC / 0x145AC)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs7, 0x45B4);
    // MOV word ptr [BP + -0x2],0x0 (1000_45AF / 0x145AF)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_1000_45B4_145B4:
    CheckExternalEvents(cs7, 0x45B7);
    // MOV SI,word ptr [BP + -0x2] (1000_45B4 / 0x145B4)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x45B9);
    // SUB AL,AL (1000_45B7 / 0x145B7)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs7, 0x45BC);
    // MOV byte ptr [BP + SI + -0x78],AL (1000_45B9 / 0x145B9)
    UInt8[SS, (ushort)(BP + SI - 0x78)] = AL;
    CheckExternalEvents(cs7, 0x45BF);
    // MOV BX,word ptr [BP + -0x2] (1000_45BC / 0x145BC)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x45C3);
    // MOV ES,word ptr [0x562e] (1000_45BF / 0x145BF)
    ES = UInt16[DS, 0x562E];
    CheckExternalEvents(cs7, 0x45C8);
    // MOV byte ptr ES:[BX + 0x78],AL (1000_45C3 / 0x145C3)
    UInt8[ES, (ushort)(BX + 0x78)] = AL;
    CheckExternalEvents(cs7, 0x45CB);
    // INC word ptr [BP + -0x2] (1000_45C8 / 0x145C8)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs7, 0x45CF);
    // CMP word ptr [BP + -0x2],0x18 (1000_45CB / 0x145CB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs7, 0x45D1);
    // JL 0x1000:45b4 (1000_45CF / 0x145CF)
    if(SignFlag != OverflowFlag) {
      goto label_1000_45B4_145B4;
    }
    CheckExternalEvents(cs7, 0x45D6);
    // MOV word ptr [BP + -0x4],0x0 (1000_45D1 / 0x145D1)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x45D9);
    // JMP 0x1000:5579 (1000_45D6 / 0x145D6)
    goto label_1000_5579_15579;
    label_1000_45D9_145D9:
    CheckExternalEvents(cs7, 0x45DD);
    // CMP word ptr [BP + -0x42],0xb (1000_45D9 / 0x145D9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x42)], 0xB);
    CheckExternalEvents(cs7, 0x45DF);
    // JNZ 0x1000:462c (1000_45DD / 0x145DD)
    if(!ZeroFlag) {
      goto label_1000_462C_1462C;
    }
    CheckExternalEvents(cs7, 0x45E2);
    // MOV AX,word ptr [BP + -0x2] (1000_45DF / 0x145DF)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x45E5);
    // MOV word ptr [BP + -0x48],AX (1000_45E2 / 0x145E2)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    CheckExternalEvents(cs7, 0x45E8);
    // CMP AX,0xc (1000_45E5 / 0x145E5)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs7, 0x45EA);
    // JL 0x1000:45f0 (1000_45E8 / 0x145E8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_45F0_145F0;
    }
    CheckExternalEvents(cs7, 0x45ED);
    // SUB AX,0x8 (1000_45EA / 0x145EA)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs7, 0x45F0);
    // MOV word ptr [BP + -0x48],AX (1000_45ED / 0x145ED)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    label_1000_45F0_145F0:
    CheckExternalEvents(cs7, 0x45F3);
    // MOV AX,0x7d (1000_45F0 / 0x145F0)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x45F6);
    // IMUL word ptr [BP + -0x48] (1000_45F3 / 0x145F3)
    int resImul1000_45F3 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_45F3);
    DX = (ushort)(resImul1000_45F3 >> 16);
    CheckExternalEvents(cs7, 0x45F8);
    // MOV SI,AX (1000_45F6 / 0x145F6)
    SI = AX;
    CheckExternalEvents(cs7, 0x45FC);
    // MOV ES,word ptr [0x5648] (1000_45F8 / 0x145F8)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4602);
    // TEST byte ptr ES:[SI + 0xc748],0x8 (1000_45FC / 0x145FC)
    Alu8.And(UInt8[ES, (ushort)(SI + 0xC748)], 0x8);
    CheckExternalEvents(cs7, 0x4604);
    // JZ 0x1000:4613 (1000_4602 / 0x14602)
    if(ZeroFlag) {
      goto label_1000_4613_14613;
    }
    CheckExternalEvents(cs7, 0x460A);
    // TEST byte ptr ES:[SI + 0xc749],0x8 (1000_4604 / 0x14604)
    Alu8.And(UInt8[ES, (ushort)(SI + 0xC749)], 0x8);
    CheckExternalEvents(cs7, 0x460C);
    // JZ 0x1000:4613 (1000_460A / 0x1460A)
    if(ZeroFlag) {
      goto label_1000_4613_14613;
    }
    CheckExternalEvents(cs7, 0x4611);
    // MOV word ptr [BP + -0x48],0x20 (1000_460C / 0x1460C)
    UInt16[SS, (ushort)(BP - 0x48)] = 0x20;
    CheckExternalEvents(cs7, 0x4613);
    // JMP 0x1000:4669 (1000_4611 / 0x14611)
    goto label_1000_4669_14669;
    label_1000_4613_14613:
    CheckExternalEvents(cs7, 0x4618);
    // MOV word ptr [BP + -0x48],0x80 (1000_4613 / 0x14613)
    UInt16[SS, (ushort)(BP - 0x48)] = 0x80;
    CheckExternalEvents(cs7, 0x461B);
    // MOV AX,0xc (1000_4618 / 0x14618)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x461E);
    // IMUL word ptr [BP + -0x2] (1000_461B / 0x1461B)
    int resImul1000_461B = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_461B);
    DX = (ushort)(resImul1000_461B >> 16);
    CheckExternalEvents(cs7, 0x4620);
    // MOV BX,AX (1000_461E / 0x1461E)
    BX = AX;
    CheckExternalEvents(cs7, 0x4624);
    // MOV ES,word ptr [0x564e] (1000_4620 / 0x14620)
    ES = UInt16[DS, 0x564E];
    CheckExternalEvents(cs7, 0x462A);
    // MOV byte ptr ES:[BX + 0x380b],0xff (1000_4624 / 0x14624)
    UInt8[ES, (ushort)(BX + 0x380B)] = 0xFF;
    CheckExternalEvents(cs7, 0x462C);
    // JMP 0x1000:4669 (1000_462A / 0x1462A)
    goto label_1000_4669_14669;
    label_1000_462C_1462C:
    CheckExternalEvents(cs7, 0x4630);
    // CMP word ptr [BP + -0x2],0x4 (1000_462C / 0x1462C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x4632);
    // JGE 0x1000:463a (1000_4630 / 0x14630)
    if(SignFlag == OverflowFlag) {
      goto label_1000_463A_1463A;
    }
    CheckExternalEvents(cs7, 0x4635);
    // PUSH word ptr [BP + -0x42] (1000_4632 / 0x14632)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs7, 0x4638);
    // PUSH word ptr [BP + -0x2] (1000_4635 / 0x14635)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x463A);
    // JMP 0x1000:4644 (1000_4638 / 0x14638)
    goto label_1000_4644_14644;
    label_1000_463A_1463A:
    CheckExternalEvents(cs7, 0x463D);
    // PUSH word ptr [BP + -0x42] (1000_463A / 0x1463A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs7, 0x4640);
    // MOV AX,word ptr [BP + -0x2] (1000_463D / 0x1463D)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x4643);
    // SUB AX,0x8 (1000_4640 / 0x14640)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs7, 0x4644);
    // PUSH AX (1000_4643 / 0x14643)
    Stack.Push16(AX);
    label_1000_4644_14644:
    CheckExternalEvents(cs7, 0x4649);
    // CALLF 0x1000:0ab2 (1000_4644 / 0x14644)
    FarCall(cs7, 0x4649, ghidra_guess_1000_0AB2_10AB2);
    CheckExternalEvents(cs7, 0x464C);
    // ADD SP,0x4 (1000_4649 / 0x14649)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x464F);
    // MOV word ptr [BP + -0x48],AX (1000_464C / 0x1464C)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    CheckExternalEvents(cs7, 0x4652);
    // CMP AX,0xff (1000_464F / 0x1464F)
    Alu16.Sub(AX, 0xFF);
    CheckExternalEvents(cs7, 0x4654);
    // JNZ 0x1000:4669 (1000_4652 / 0x14652)
    if(!ZeroFlag) {
      goto label_1000_4669_14669;
    }
    CheckExternalEvents(cs7, 0x4657);
    // MOV AX,0xc (1000_4654 / 0x14654)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x465A);
    // IMUL word ptr [BP + -0x2] (1000_4657 / 0x14657)
    int resImul1000_4657 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_4657);
    DX = (ushort)(resImul1000_4657 >> 16);
    CheckExternalEvents(cs7, 0x465C);
    // MOV BX,AX (1000_465A / 0x1465A)
    BX = AX;
    CheckExternalEvents(cs7, 0x465F);
    // ADD BX,word ptr [BP + -0x42] (1000_465C / 0x1465C)
    // BX += UInt16[SS, (ushort)(BP - 0x42)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs7, 0x4663);
    // MOV ES,word ptr [0x564e] (1000_465F / 0x1465F)
    ES = UInt16[DS, 0x564E];
    CheckExternalEvents(cs7, 0x4669);
    // MOV byte ptr ES:[BX + 0x3800],0xff (1000_4663 / 0x14663)
    UInt8[ES, (ushort)(BX + 0x3800)] = 0xFF;
    label_1000_4669_14669:
    CheckExternalEvents(cs7, 0x466D);
    // TEST byte ptr [BP + -0x48],0x80 (1000_4669 / 0x14669)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x48)], 0x80);
    CheckExternalEvents(cs7, 0x466F);
    // JZ 0x1000:4672 (1000_466D / 0x1466D)
    if(ZeroFlag) {
      goto label_1000_4672_14672;
    }
    CheckExternalEvents(cs7, 0x4672);
    // JMP 0x1000:5344 (1000_466F / 0x1466F)
    goto label_1000_5344_15344;
    label_1000_4672_14672:
    CheckExternalEvents(cs7, 0x4675);
    // MOV BX,word ptr [BP + -0x28] (1000_4672 / 0x14672)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x4677);
    // SHL BX,0x1 (1000_4675 / 0x14675)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x467B);
    // MOV ES,word ptr [0x5632] (1000_4677 / 0x14677)
    ES = UInt16[DS, 0x5632];
    CheckExternalEvents(cs7, 0x4681);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_467B / 0x1467B)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x4683);
    // JNZ 0x1000:4686 (1000_4681 / 0x14681)
    if(!ZeroFlag) {
      goto label_1000_4686_14686;
    }
    CheckExternalEvents(cs7, 0x4686);
    // JMP 0x1000:532f (1000_4683 / 0x14683)
    goto label_1000_532F_1532F;
    label_1000_4686_14686:
    CheckExternalEvents(cs7, 0x4689);
    // PUSH word ptr [BP + -0x48] (1000_4686 / 0x14686)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x48)]);
    label_1000_4689_14689:
    CheckExternalEvents(cs7, 0x468C);
    // PUSH word ptr [BP + -0x28] (1000_4689 / 0x14689)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs7, 0x4691);
    // CALLF 0x1000:0934 (1000_468C / 0x1468C)
    FarCall(cs7, 0x4691, ghidra_guess_1000_0934_10934);
    CheckExternalEvents(cs7, 0x4694);
    // ADD SP,0x4 (1000_4691 / 0x14691)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4697);
    // MOV word ptr [BP + -0x5c],AX (1000_4694 / 0x14694)
    UInt16[SS, (ushort)(BP - 0x5C)] = AX;
    CheckExternalEvents(cs7, 0x469A);
    // CMP AX,0x3 (1000_4697 / 0x14697)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs7, 0x469C);
    // JL 0x1000:469f (1000_469A / 0x1469A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_469F_1469F;
    }
    CheckExternalEvents(cs7, 0x469F);
    // JMP 0x1000:5344 (1000_469C / 0x1469C)
    goto label_1000_5344_15344;
    label_1000_469F_1469F:
    CheckExternalEvents(cs7, 0x46A2);
    // MOV SI,word ptr [BP + -0x28] (1000_469F / 0x1469F)
    SI = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x46A4);
    // SHL SI,0x1 (1000_46A2 / 0x146A2)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x46A8);
    // MOV ES,word ptr [0x5636] (1000_46A4 / 0x146A4)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x46AD);
    // PUSH word ptr ES:[SI + 0x4036] (1000_46A8 / 0x146A8)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs7, 0x46B1);
    // MOV ES,word ptr [0x5638] (1000_46AD / 0x146AD)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x46B6);
    // PUSH word ptr ES:[SI + 0x4004] (1000_46B1 / 0x146B1)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs7, 0x46BA);
    // MOV ES,word ptr [0x562c] (1000_46B6 / 0x146B6)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x46BF);
    // PUSH word ptr ES:[0xa44d] (1000_46BA / 0x146BA)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs7, 0x46C3);
    // MOV ES,word ptr [0x562a] (1000_46BF / 0x146BF)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x46C8);
    // PUSH word ptr ES:[0xa44b] (1000_46C3 / 0x146C3)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs7, 0x46CD);
    // CALLF 0x1000:a861 (1000_46C8 / 0x146C8)
    FarCall(cs7, 0x46CD, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs7, 0x46D0);
    // ADD SP,0x8 (1000_46CD / 0x146CD)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x46D3);
    // MOV word ptr [BP + -0x60],AX (1000_46D0 / 0x146D0)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs7, 0x46D6);
    // CMP AX,0xffff (1000_46D3 / 0x146D3)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs7, 0x46D8);
    // JNZ 0x1000:46dd (1000_46D6 / 0x146D6)
    if(!ZeroFlag) {
      goto label_1000_46DD_146DD;
    }
    CheckExternalEvents(cs7, 0x46DD);
    // MOV word ptr [BP + -0x60],0x0 (1000_46D8 / 0x146D8)
    UInt16[SS, (ushort)(BP - 0x60)] = 0x0;
    label_1000_46DD_146DD:
    CheckExternalEvents(cs7, 0x46E0);
    // MOV AX,word ptr [BP + -0x60] (1000_46DD / 0x146DD)
    AX = UInt16[SS, (ushort)(BP - 0x60)];
    CheckExternalEvents(cs7, 0x46E3);
    // MOV word ptr [BP + -0x58],AX (1000_46E0 / 0x146E0)
    UInt16[SS, (ushort)(BP - 0x58)] = AX;
    CheckExternalEvents(cs7, 0x46E7);
    // MOV ES,word ptr [0x562a] (1000_46E3 / 0x146E3)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x46EA);
    // MOV AX,word ptr [BP + -0x2a] (1000_46E7 / 0x146E7)
    AX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs7, 0x46EE);
    // MOV ES:[0xa44b],AX (1000_46EA / 0x146EA)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x46F2);
    // MOV ES,word ptr [0x562c] (1000_46EE / 0x146EE)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x46F5);
    // MOV AX,word ptr [BP + -0x36] (1000_46F2 / 0x146F2)
    AX = UInt16[SS, (ushort)(BP - 0x36)];
    CheckExternalEvents(cs7, 0x46F9);
    // MOV ES:[0xa44d],AX (1000_46F5 / 0x146F5)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs7, 0x46FC);
    // MOV SI,word ptr [BP + -0x2] (1000_46F9 / 0x146F9)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x46FE);
    // SHL SI,0x1 (1000_46FC / 0x146FC)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x4702);
    // MOV ES,word ptr [0x5636] (1000_46FE / 0x146FE)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x4707);
    // PUSH word ptr ES:[SI + 0x4036] (1000_4702 / 0x14702)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs7, 0x470B);
    // MOV ES,word ptr [0x5638] (1000_4707 / 0x14707)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x4710);
    // PUSH word ptr ES:[SI + 0x4004] (1000_470B / 0x1470B)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs7, 0x4715);
    // CALLF 0x0000:2ebb (1000_4710 / 0x14710)
    FarCall(cs7, 0x4715, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x4718);
    // ADD SP,0x4 (1000_4715 / 0x14715)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x471B);
    // MOV SI,word ptr [BP + -0x28] (1000_4718 / 0x14718)
    SI = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x471D);
    // SHL SI,0x1 (1000_471B / 0x1471B)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x4721);
    // MOV ES,word ptr [0x5636] (1000_471D / 0x1471D)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x4726);
    // PUSH word ptr ES:[SI + 0x4036] (1000_4721 / 0x14721)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs7, 0x472A);
    // MOV ES,word ptr [0x5638] (1000_4726 / 0x14726)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x472F);
    // PUSH word ptr ES:[SI + 0x4004] (1000_472A / 0x1472A)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs7, 0x4732);
    // PUSH word ptr [BP + -0x28] (1000_472F / 0x1472F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs7, 0x4735);
    // PUSH word ptr [BP + -0x2] (1000_4732 / 0x14732)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x473A);
    // CALLF 0x1000:160e (1000_4735 / 0x14735)
    FarCall(cs7, 0x473A, ghidra_guess_1000_160E_1160E);
    CheckExternalEvents(cs7, 0x473D);
    // ADD SP,0x8 (1000_473A / 0x1473A)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x473F);
    // OR AX,AX (1000_473D / 0x1473D)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x4741);
    // JNZ 0x1000:4744 (1000_473F / 0x1473F)
    if(!ZeroFlag) {
      goto label_1000_4744_14744;
    }
    CheckExternalEvents(cs7, 0x4744);
    // JMP 0x1000:531f (1000_4741 / 0x14741)
    goto label_1000_531F_1531F;
    label_1000_4744_14744:
    CheckExternalEvents(cs7, 0x4748);
    // CMP word ptr [BP + -0x2],0x4 (1000_4744 / 0x14744)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x474A);
    // JL 0x1000:47b9 (1000_4748 / 0x14748)
    if(SignFlag != OverflowFlag) {
      goto label_1000_47B9_147B9;
    }
    CheckExternalEvents(cs7, 0x474E);
    // CMP word ptr [BP + -0x2],0xc (1000_474A / 0x1474A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x4750);
    // JGE 0x1000:47b9 (1000_474E / 0x1474E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_47B9_147B9;
    }
    CheckExternalEvents(cs7, 0x4753);
    // MOV AX,0x11 (1000_4750 / 0x14750)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4756);
    // IMUL word ptr [BP + -0x48] (1000_4753 / 0x14753)
    int resImul1000_4753 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_4753);
    DX = (ushort)(resImul1000_4753 >> 16);
    CheckExternalEvents(cs7, 0x4758);
    // MOV BX,AX (1000_4756 / 0x14756)
    BX = AX;
    CheckExternalEvents(cs7, 0x475C);
    // MOV ES,word ptr [0x5652] (1000_4758 / 0x14758)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4761);
    // MOV AL,byte ptr ES:[BX + 0x2ee8] (1000_475C / 0x1475C)
    AL = UInt8[ES, (ushort)(BX + 0x2EE8)];
    CheckExternalEvents(cs7, 0x4763);
    // SUB AH,AH (1000_4761 / 0x14761)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x4766);
    // MOV word ptr [BP + -0x22],AX (1000_4763 / 0x14763)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs7, 0x4769);
    // MOV BX,word ptr [BP + -0x2] (1000_4766 / 0x14766)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x476D);
    // MOV ES,word ptr [0x5648] (1000_4769 / 0x14769)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4772);
    // MOV AL,byte ptr ES:[BX + 0xd360] (1000_476D / 0x1476D)
    AL = UInt8[ES, (ushort)(BX + 0xD360)];
    CheckExternalEvents(cs7, 0x4773);
    // CBW  (1000_4772 / 0x14772)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4776);
    // CMP AX,word ptr [BP + -0x22] (1000_4773 / 0x14773)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs7, 0x4778);
    // JNZ 0x1000:47a1 (1000_4776 / 0x14776)
    if(!ZeroFlag) {
      goto label_1000_47A1_147A1;
    }
    CheckExternalEvents(cs7, 0x477D);
    // INC byte ptr ES:[BX + 0xd358] (1000_4778 / 0x14778)
    UInt8[ES, (ushort)(BX + 0xD358)] = Alu8.Inc(UInt8[ES, (ushort)(BX + 0xD358)]);
    CheckExternalEvents(cs7, 0x477F);
    // JNZ 0x1000:47b9 (1000_477D / 0x1477D)
    if(!ZeroFlag) {
      goto label_1000_47B9_147B9;
    }
    CheckExternalEvents(cs7, 0x4782);
    // MOV AX,0x11 (1000_477F / 0x1477F)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4785);
    // IMUL word ptr [BP + -0x2] (1000_4782 / 0x14782)
    int resImul1000_4782 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_4782);
    DX = (ushort)(resImul1000_4782 >> 16);
    CheckExternalEvents(cs7, 0x4788);
    // ADD AX,word ptr [BP + -0x22] (1000_4785 / 0x14785)
    AX += UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs7, 0x478B);
    // ADD AX,0xc5d4 (1000_4788 / 0x14788)
    // AX += 0xC5D4;
    AX = Alu16.Add(AX, 0xC5D4);
    CheckExternalEvents(cs7, 0x478E);
    // MOV word ptr [BP + -0x80],AX (1000_478B / 0x1478B)
    UInt16[SS, (ushort)(BP - 0x80)] = AX;
    CheckExternalEvents(cs7, 0x4793);
    // MOV word ptr [BP + -0x7e],0x2a02 (1000_478E / 0x1478E)
    UInt16[SS, (ushort)(BP - 0x7E)] = 0x2A02;
    CheckExternalEvents(cs7, 0x4796);
    // LES BX,[BP + -0x80] (1000_4793 / 0x14793)
    BX = UInt16[SS, (ushort)(BP - 0x80)];
    ES = UInt16[SS, (ushort)(BP - 0x80 + 2)];
    CheckExternalEvents(cs7, 0x479A);
    // CMP byte ptr ES:[BX],0x4 (1000_4796 / 0x14796)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x4);
    CheckExternalEvents(cs7, 0x479C);
    // JGE 0x1000:47b9 (1000_479A / 0x1479A)
    if(SignFlag == OverflowFlag) {
      goto label_1000_47B9_147B9;
    }
    CheckExternalEvents(cs7, 0x479F);
    // INC byte ptr ES:[BX] (1000_479C / 0x1479C)
    UInt8[ES, (ushort)(BX)] = Alu8.Inc(UInt8[ES, (ushort)(BX)]);
    CheckExternalEvents(cs7, 0x47A1);
    // JMP 0x1000:47b9 (1000_479F / 0x1479F)
    goto label_1000_47B9_147B9;
    label_1000_47A1_147A1:
    CheckExternalEvents(cs7, 0x47A4);
    // MOV AL,byte ptr [BP + -0x22] (1000_47A1 / 0x147A1)
    AL = UInt8[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs7, 0x47A7);
    // MOV BX,word ptr [BP + -0x2] (1000_47A4 / 0x147A4)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x47AB);
    // MOV ES,word ptr [0x5648] (1000_47A7 / 0x147A7)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x47B0);
    // MOV byte ptr ES:[BX + 0xd360],AL (1000_47AB / 0x147AB)
    UInt8[ES, (ushort)(BX + 0xD360)] = AL;
    CheckExternalEvents(cs7, 0x47B3);
    // MOV BX,word ptr [BP + -0x2] (1000_47B0 / 0x147B0)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x47B9);
    // MOV byte ptr ES:[BX + 0xd358],0x0 (1000_47B3 / 0x147B3)
    UInt8[ES, (ushort)(BX + 0xD358)] = 0x0;
    label_1000_47B9_147B9:
    CheckExternalEvents(cs7, 0x47BD);
    // CMP word ptr [BP + -0x2],0x4 (1000_47B9 / 0x147B9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x47BF);
    // JGE 0x1000:47e5 (1000_47BD / 0x147BD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_47E5_147E5;
    }
    CheckExternalEvents(cs7, 0x47C3);
    // CMP word ptr [BP + -0x42],0xb (1000_47BF / 0x147BF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x42)], 0xB);
    CheckExternalEvents(cs7, 0x47C5);
    // JGE 0x1000:47e5 (1000_47C3 / 0x147C3)
    if(SignFlag == OverflowFlag) {
      goto label_1000_47E5_147E5;
    }
    CheckExternalEvents(cs7, 0x47C8);
    // MOV AX,0x7d (1000_47C5 / 0x147C5)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x47CB);
    // IMUL word ptr [BP + -0x2] (1000_47C8 / 0x147C8)
    int resImul1000_47C8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_47C8);
    DX = (ushort)(resImul1000_47C8 >> 16);
    CheckExternalEvents(cs7, 0x47CE);
    // ADD AX,word ptr [BP + -0x42] (1000_47CB / 0x147CB)
    AX += UInt16[SS, (ushort)(BP - 0x42)];
    CheckExternalEvents(cs7, 0x47D1);
    // ADD AX,0xc74b (1000_47CE / 0x147CE)
    // AX += 0xC74B;
    AX = Alu16.Add(AX, 0xC74B);
    CheckExternalEvents(cs7, 0x47D4);
    // MOV word ptr [BP + -0x80],AX (1000_47D1 / 0x147D1)
    UInt16[SS, (ushort)(BP - 0x80)] = AX;
    CheckExternalEvents(cs7, 0x47D9);
    // MOV word ptr [BP + -0x7e],0x2a02 (1000_47D4 / 0x147D4)
    UInt16[SS, (ushort)(BP - 0x7E)] = 0x2A02;
    CheckExternalEvents(cs7, 0x47DC);
    // LES BX,[BP + -0x80] (1000_47D9 / 0x147D9)
    BX = UInt16[SS, (ushort)(BP - 0x80)];
    ES = UInt16[SS, (ushort)(BP - 0x80 + 2)];
    CheckExternalEvents(cs7, 0x47E0);
    // CMP byte ptr ES:[BX],0xff (1000_47DC / 0x147DC)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0xFF);
    CheckExternalEvents(cs7, 0x47E2);
    // JZ 0x1000:47e5 (1000_47E0 / 0x147E0)
    if(ZeroFlag) {
      goto label_1000_47E5_147E5;
    }
    CheckExternalEvents(cs7, 0x47E5);
    // DEC byte ptr ES:[BX] (1000_47E2 / 0x147E2)
    UInt8[ES, (ushort)(BX)]--;
    label_1000_47E5_147E5:
    CheckExternalEvents(cs7, 0x47E9);
    // CMP word ptr [BP + -0x2],0xc (1000_47E5 / 0x147E5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x47EB);
    // JL 0x1000:4817 (1000_47E9 / 0x147E9)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4817_14817;
    }
    CheckExternalEvents(cs7, 0x47EF);
    // CMP word ptr [BP + -0x2],0x10 (1000_47EB / 0x147EB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x47F1);
    // JGE 0x1000:4817 (1000_47EF / 0x147EF)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4817_14817;
    }
    CheckExternalEvents(cs7, 0x47F5);
    // CMP word ptr [BP + -0x42],0xb (1000_47F1 / 0x147F1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x42)], 0xB);
    CheckExternalEvents(cs7, 0x47F7);
    // JGE 0x1000:4817 (1000_47F5 / 0x147F5)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4817_14817;
    }
    CheckExternalEvents(cs7, 0x47FA);
    // MOV AX,0x7d (1000_47F7 / 0x147F7)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x47FD);
    // IMUL word ptr [BP + -0x2] (1000_47FA / 0x147FA)
    int resImul1000_47FA = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_47FA);
    DX = (ushort)(resImul1000_47FA >> 16);
    CheckExternalEvents(cs7, 0x4800);
    // ADD AX,word ptr [BP + -0x42] (1000_47FD / 0x147FD)
    AX += UInt16[SS, (ushort)(BP - 0x42)];
    CheckExternalEvents(cs7, 0x4803);
    // ADD AX,0xc363 (1000_4800 / 0x14800)
    // AX += 0xC363;
    AX = Alu16.Add(AX, 0xC363);
    CheckExternalEvents(cs7, 0x4806);
    // MOV word ptr [BP + -0x80],AX (1000_4803 / 0x14803)
    UInt16[SS, (ushort)(BP - 0x80)] = AX;
    CheckExternalEvents(cs7, 0x480B);
    // MOV word ptr [BP + -0x7e],0x2a02 (1000_4806 / 0x14806)
    UInt16[SS, (ushort)(BP - 0x7E)] = 0x2A02;
    CheckExternalEvents(cs7, 0x480E);
    // LES BX,[BP + -0x80] (1000_480B / 0x1480B)
    BX = UInt16[SS, (ushort)(BP - 0x80)];
    ES = UInt16[SS, (ushort)(BP - 0x80 + 2)];
    CheckExternalEvents(cs7, 0x4812);
    // CMP byte ptr ES:[BX],0xff (1000_480E / 0x1480E)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0xFF);
    CheckExternalEvents(cs7, 0x4814);
    // JZ 0x1000:4817 (1000_4812 / 0x14812)
    if(ZeroFlag) {
      goto label_1000_4817_14817;
    }
    CheckExternalEvents(cs7, 0x4817);
    // DEC byte ptr ES:[BX] (1000_4814 / 0x14814)
    UInt8[ES, (ushort)(BX)] = Alu8.Dec(UInt8[ES, (ushort)(BX)]);
    label_1000_4817_14817:
    CheckExternalEvents(cs7, 0x481A);
    // MOV AX,word ptr [BP + -0x5c] (1000_4817 / 0x14817)
    AX = UInt16[SS, (ushort)(BP - 0x5C)];
    CheckExternalEvents(cs7, 0x481C);
    // SHL AX,0x1 (1000_481A / 0x1481A)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0x481F);
    // ADD AX,0x4 (1000_481C / 0x1481C)
    // AX += 0x4;
    AX = Alu16.Add(AX, 0x4);
    CheckExternalEvents(cs7, 0x4822);
    // MOV word ptr [BP + -0x30],AX (1000_481F / 0x1481F)
    UInt16[SS, (ushort)(BP - 0x30)] = AX;
    CheckExternalEvents(cs7, 0x4826);
    // CMP word ptr [BP + -0x48],0x20 (1000_4822 / 0x14822)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x20);
    CheckExternalEvents(cs7, 0x4828);
    // JNZ 0x1000:4860 (1000_4826 / 0x14826)
    if(!ZeroFlag) {
      goto label_1000_4860_14860;
    }
    CheckExternalEvents(cs7, 0x482D);
    // MOV word ptr [BP + -0x30],0x3 (1000_4828 / 0x14828)
    UInt16[SS, (ushort)(BP - 0x30)] = 0x3;
    CheckExternalEvents(cs7, 0x4830);
    // MOV AX,word ptr [BP + -0x2] (1000_482D / 0x1482D)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x4833);
    // MOV word ptr [BP + -0x7a],AX (1000_4830 / 0x14830)
    UInt16[SS, (ushort)(BP - 0x7A)] = AX;
    CheckExternalEvents(cs7, 0x4836);
    // CMP AX,0xc (1000_4833 / 0x14833)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs7, 0x4838);
    // JL 0x1000:483c (1000_4836 / 0x14836)
    if(SignFlag != OverflowFlag) {
      goto label_1000_483C_1483C;
    }
    CheckExternalEvents(cs7, 0x483C);
    // SUB word ptr [BP + -0x7a],0x8 (1000_4838 / 0x14838)
    // UInt16[SS, (ushort)(BP - 0x7A)] -= 0x8;
    UInt16[SS, (ushort)(BP - 0x7A)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x7A)], 0x8);
    label_1000_483C_1483C:
    CheckExternalEvents(cs7, 0x483F);
    // MOV AX,0x24 (1000_483C / 0x1483C)
    AX = 0x24;
    CheckExternalEvents(cs7, 0x4840);
    // PUSH AX (1000_483F / 0x1483F)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4843);
    // PUSH word ptr [BP + -0x2] (1000_4840 / 0x14840)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x4848);
    // CALLF 0x1000:1554 (1000_4843 / 0x14843)
    FarCall(cs7, 0x4848, ghidra_guess_1000_1554_11554);
    CheckExternalEvents(cs7, 0x484B);
    // ADD SP,0x4 (1000_4848 / 0x14848)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x484E);
    // ADD word ptr [BP + -0x30],AX (1000_484B / 0x1484B)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], AX);
    CheckExternalEvents(cs7, 0x4851);
    // MOV AX,0x25 (1000_484E / 0x1484E)
    AX = 0x25;
    CheckExternalEvents(cs7, 0x4852);
    // PUSH AX (1000_4851 / 0x14851)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4855);
    // PUSH word ptr [BP + -0x2] (1000_4852 / 0x14852)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x485A);
    // CALLF 0x1000:1554 (1000_4855 / 0x14855)
    FarCall(cs7, 0x485A, ghidra_guess_1000_1554_11554);
    CheckExternalEvents(cs7, 0x485D);
    // ADD SP,0x4 (1000_485A / 0x1485A)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x4860);
    // ADD word ptr [BP + -0x30],AX (1000_485D / 0x1485D)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], AX);
    label_1000_4860_14860:
    CheckExternalEvents(cs7, 0x4863);
    // MOV AX,0x30 (1000_4860 / 0x14860)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x4866);
    // IMUL word ptr [BP + -0x2] (1000_4863 / 0x14863)
    int resImul1000_4863 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_4863);
    DX = (ushort)(resImul1000_4863 >> 16);
    CheckExternalEvents(cs7, 0x4868);
    // MOV BX,AX (1000_4866 / 0x14866)
    BX = AX;
    CheckExternalEvents(cs7, 0x486C);
    // MOV ES,word ptr [0x5654] (1000_4868 / 0x14868)
    ES = UInt16[DS, 0x5654];
    CheckExternalEvents(cs7, 0x4871);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_486C / 0x1486C)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x4872);
    // CBW  (1000_4871 / 0x14871)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4873);
    // INC AX (1000_4872 / 0x14872)
    AX++;
    CheckExternalEvents(cs7, 0x4876);
    // ADD word ptr [BP + -0x30],AX (1000_4873 / 0x14873)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], AX);
    CheckExternalEvents(cs7, 0x4879);
    // MOV SI,word ptr [BP + -0x28] (1000_4876 / 0x14876)
    SI = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x487C);
    // MOV AL,byte ptr [BP + SI + -0x78] (1000_4879 / 0x14879)
    AL = UInt8[SS, (ushort)(BP + SI - 0x78)];
    CheckExternalEvents(cs7, 0x487D);
    // CBW  (1000_487C / 0x1487C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x487F);
    // MOV BX,AX (1000_487D / 0x1487D)
    BX = AX;
    CheckExternalEvents(cs7, 0x4883);
    // MOV ES,word ptr [0x5656] (1000_487F / 0x1487F)
    ES = UInt16[DS, 0x5656];
    CheckExternalEvents(cs7, 0x4888);
    // MOV AL,byte ptr ES:[BX + 0x2d1a] (1000_4883 / 0x14883)
    AL = UInt8[ES, (ushort)(BX + 0x2D1A)];
    CheckExternalEvents(cs7, 0x4889);
    // CBW  (1000_4888 / 0x14888)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x488C);
    // ADD word ptr [BP + -0x30],AX (1000_4889 / 0x14889)
    UInt16[SS, (ushort)(BP - 0x30)] += AX;
    CheckExternalEvents(cs7, 0x4890);
    // CMP word ptr [BP + -0x2],0x4 (1000_488C / 0x1488C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x4892);
    // JL 0x1000:48a1 (1000_4890 / 0x14890)
    if(SignFlag != OverflowFlag) {
      goto label_1000_48A1_148A1;
    }
    CheckExternalEvents(cs7, 0x4896);
    // CMP word ptr [BP + -0x2],0xc (1000_4892 / 0x14892)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x4898);
    // JGE 0x1000:48a1 (1000_4896 / 0x14896)
    if(SignFlag == OverflowFlag) {
      goto label_1000_48A1_148A1;
    }
    CheckExternalEvents(cs7, 0x489B);
    // MOV AX,word ptr [BP + -0x2] (1000_4898 / 0x14898)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x489E);
    // SUB AX,0x4 (1000_489B / 0x1489B)
    // AX -= 0x4;
    AX = Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs7, 0x48A1);
    // MOV word ptr [BP + -0x26],AX (1000_489E / 0x1489E)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    label_1000_48A1_148A1:
    CheckExternalEvents(cs7, 0x48A5);
    // CMP word ptr [BP + -0x2],0x10 (1000_48A1 / 0x148A1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x48A7);
    // JL 0x1000:48b0 (1000_48A5 / 0x148A5)
    if(SignFlag != OverflowFlag) {
      goto label_1000_48B0_148B0;
    }
    CheckExternalEvents(cs7, 0x48AA);
    // MOV AX,word ptr [BP + -0x2] (1000_48A7 / 0x148A7)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x48AD);
    // SUB AX,0x8 (1000_48AA / 0x148AA)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs7, 0x48B0);
    // MOV word ptr [BP + -0x26],AX (1000_48AD / 0x148AD)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    label_1000_48B0_148B0:
    CheckExternalEvents(cs7, 0x48B4);
    // CMP word ptr [BP + -0x2],0x4 (1000_48B0 / 0x148B0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x48B6);
    // JGE 0x1000:4929 (1000_48B4 / 0x148B4)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4929_14929;
    }
    CheckExternalEvents(cs7, 0x48B9);
    // MOV AX,0x7d (1000_48B6 / 0x148B6)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x48BC);
    // IMUL word ptr [BP + -0x2] (1000_48B9 / 0x148B9)
    int resImul1000_48B9 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_48B9);
    DX = (ushort)(resImul1000_48B9 >> 16);
    CheckExternalEvents(cs7, 0x48BE);
    // MOV SI,AX (1000_48BC / 0x148BC)
    SI = AX;
    CheckExternalEvents(cs7, 0x48C2);
    // MOV ES,word ptr [0x5648] (1000_48BE / 0x148BE)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x48C7);
    // MOV AL,byte ptr ES:[SI + 0xc79d] (1000_48C2 / 0x148C2)
    AL = UInt8[ES, (ushort)(SI + 0xC79D)];
    CheckExternalEvents(cs7, 0x48C9);
    // SUB AH,AH (1000_48C7 / 0x148C7)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x48CC);
    // MOV word ptr [BP + -0x26],AX (1000_48C9 / 0x148C9)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs7, 0x48D1);
    // CMP byte ptr ES:[SI + 0xc79b],AH (1000_48CC / 0x148CC)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC79B)], AH);
    CheckExternalEvents(cs7, 0x48D3);
    // JZ 0x1000:48d7 (1000_48D1 / 0x148D1)
    if(ZeroFlag) {
      goto label_1000_48D7_148D7;
    }
    CheckExternalEvents(cs7, 0x48D7);
    // ADD word ptr [BP + -0x30],0x2 (1000_48D3 / 0x148D3)
    // UInt16[SS, (ushort)(BP - 0x30)] += 0x2;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], 0x2);
    label_1000_48D7_148D7:
    CheckExternalEvents(cs7, 0x48DA);
    // MOV AX,0x11 (1000_48D7 / 0x148D7)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x48DD);
    // IMUL word ptr [BP + -0x48] (1000_48DA / 0x148DA)
    int resImul1000_48DA = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_48DA);
    DX = (ushort)(resImul1000_48DA >> 16);
    CheckExternalEvents(cs7, 0x48DF);
    // MOV BX,AX (1000_48DD / 0x148DD)
    BX = AX;
    CheckExternalEvents(cs7, 0x48E3);
    // MOV ES,word ptr [0x5652] (1000_48DF / 0x148DF)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x48E8);
    // MOV AL,byte ptr ES:[BX + 0x2ee5] (1000_48E3 / 0x148E3)
    AL = UInt8[ES, (ushort)(BX + 0x2EE5)];
    CheckExternalEvents(cs7, 0x48EA);
    // AND AL,0xf (1000_48E8 / 0x148E8)
    // AL &= 0xF;
    AL = Alu8.And(AL, 0xF);
    CheckExternalEvents(cs7, 0x48ED);
    // MOV BX,word ptr [BP + -0x2] (1000_48EA / 0x148EA)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x48F1);
    // MOV ES,word ptr [0x5658] (1000_48ED / 0x148ED)
    ES = UInt16[DS, 0x5658];
    CheckExternalEvents(cs7, 0x48F6);
    // ADD byte ptr ES:[BX + 0x92],AL (1000_48F1 / 0x148F1)
    // UInt8[ES, (ushort)(BX + 0x92)] += AL;
    UInt8[ES, (ushort)(BX + 0x92)] = Alu8.Add(UInt8[ES, (ushort)(BX + 0x92)], AL);
    CheckExternalEvents(cs7, 0x48F9);
    // MOV BX,word ptr [BP + -0x2] (1000_48F6 / 0x148F6)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x48FD);
    // MOV ES,word ptr [0x5650] (1000_48F9 / 0x148F9)
    ES = UInt16[DS, 0x5650];
    CheckExternalEvents(cs7, 0x4903);
    // CMP byte ptr ES:[BX + 0x6e],0x8 (1000_48FD / 0x148FD)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x8);
    CheckExternalEvents(cs7, 0x4905);
    // JL 0x1000:4929 (1000_4903 / 0x14903)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4929_14929;
    }
    CheckExternalEvents(cs7, 0x4908);
    // INC word ptr [BP + -0x30] (1000_4905 / 0x14905)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    CheckExternalEvents(cs7, 0x490E);
    // CMP byte ptr ES:[BX + 0x6e],0xd (1000_4908 / 0x14908)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0xD);
    CheckExternalEvents(cs7, 0x4910);
    // JL 0x1000:4913 (1000_490E / 0x1490E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4913_14913;
    }
    CheckExternalEvents(cs7, 0x4913);
    // INC word ptr [BP + -0x30] (1000_4910 / 0x14910)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    label_1000_4913_14913:
    CheckExternalEvents(cs7, 0x4919);
    // CMP byte ptr ES:[BX + 0x6e],0x11 (1000_4913 / 0x14913)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x11);
    CheckExternalEvents(cs7, 0x491B);
    // JL 0x1000:491e (1000_4919 / 0x14919)
    if(SignFlag != OverflowFlag) {
      goto label_1000_491E_1491E;
    }
    CheckExternalEvents(cs7, 0x491E);
    // INC word ptr [BP + -0x30] (1000_491B / 0x1491B)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    label_1000_491E_1491E:
    CheckExternalEvents(cs7, 0x4924);
    // CMP byte ptr ES:[BX + 0x6e],0x18 (1000_491E / 0x1491E)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x18);
    CheckExternalEvents(cs7, 0x4926);
    // JL 0x1000:4929 (1000_4924 / 0x14924)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4929_14929;
    }
    CheckExternalEvents(cs7, 0x4929);
    // INC word ptr [BP + -0x30] (1000_4926 / 0x14926)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    label_1000_4929_14929:
    CheckExternalEvents(cs7, 0x492D);
    // CMP word ptr [BP + -0x2],0xc (1000_4929 / 0x14929)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x492F);
    // JL 0x1000:49a8 (1000_492D / 0x1492D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_49A8_149A8;
    }
    CheckExternalEvents(cs7, 0x4933);
    // CMP word ptr [BP + -0x2],0x10 (1000_492F / 0x1492F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x4935);
    // JGE 0x1000:49a8 (1000_4933 / 0x14933)
    if(SignFlag == OverflowFlag) {
      goto label_1000_49A8_149A8;
    }
    CheckExternalEvents(cs7, 0x4938);
    // MOV AX,0x7d (1000_4935 / 0x14935)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x493B);
    // IMUL word ptr [BP + -0x2] (1000_4938 / 0x14938)
    int resImul1000_4938 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_4938);
    DX = (ushort)(resImul1000_4938 >> 16);
    CheckExternalEvents(cs7, 0x493D);
    // MOV SI,AX (1000_493B / 0x1493B)
    SI = AX;
    CheckExternalEvents(cs7, 0x4941);
    // MOV ES,word ptr [0x5648] (1000_493D / 0x1493D)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4946);
    // MOV AL,byte ptr ES:[SI + 0xc3b5] (1000_4941 / 0x14941)
    AL = UInt8[ES, (ushort)(SI + 0xC3B5)];
    CheckExternalEvents(cs7, 0x4948);
    // SUB AH,AH (1000_4946 / 0x14946)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x494B);
    // MOV word ptr [BP + -0x26],AX (1000_4948 / 0x14948)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs7, 0x4950);
    // CMP byte ptr ES:[SI + 0xc3b3],AH (1000_494B / 0x1494B)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xC3B3)], AH);
    CheckExternalEvents(cs7, 0x4952);
    // JZ 0x1000:4956 (1000_4950 / 0x14950)
    if(ZeroFlag) {
      goto label_1000_4956_14956;
    }
    CheckExternalEvents(cs7, 0x4956);
    // ADD word ptr [BP + -0x30],0x2 (1000_4952 / 0x14952)
    // UInt16[SS, (ushort)(BP - 0x30)] += 0x2;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], 0x2);
    label_1000_4956_14956:
    CheckExternalEvents(cs7, 0x4959);
    // MOV AX,0x11 (1000_4956 / 0x14956)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x495C);
    // IMUL word ptr [BP + -0x48] (1000_4959 / 0x14959)
    int resImul1000_4959 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_4959);
    DX = (ushort)(resImul1000_4959 >> 16);
    CheckExternalEvents(cs7, 0x495E);
    // MOV BX,AX (1000_495C / 0x1495C)
    BX = AX;
    CheckExternalEvents(cs7, 0x4962);
    // MOV ES,word ptr [0x5652] (1000_495E / 0x1495E)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4967);
    // MOV AL,byte ptr ES:[BX + 0x2ee5] (1000_4962 / 0x14962)
    AL = UInt8[ES, (ushort)(BX + 0x2EE5)];
    CheckExternalEvents(cs7, 0x4969);
    // AND AL,0xf (1000_4967 / 0x14967)
    // AL &= 0xF;
    AL = Alu8.And(AL, 0xF);
    CheckExternalEvents(cs7, 0x496C);
    // MOV BX,word ptr [BP + -0x2] (1000_4969 / 0x14969)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x4970);
    // MOV ES,word ptr [0x5658] (1000_496C / 0x1496C)
    ES = UInt16[DS, 0x5658];
    CheckExternalEvents(cs7, 0x4975);
    // ADD byte ptr ES:[BX + 0x8a],AL (1000_4970 / 0x14970)
    // UInt8[ES, (ushort)(BX + 0x8A)] += AL;
    UInt8[ES, (ushort)(BX + 0x8A)] = Alu8.Add(UInt8[ES, (ushort)(BX + 0x8A)], AL);
    CheckExternalEvents(cs7, 0x4978);
    // MOV BX,word ptr [BP + -0x2] (1000_4975 / 0x14975)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x497C);
    // MOV ES,word ptr [0x5650] (1000_4978 / 0x14978)
    ES = UInt16[DS, 0x5650];
    CheckExternalEvents(cs7, 0x4982);
    // CMP byte ptr ES:[BX + 0x66],0x8 (1000_497C / 0x1497C)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x66)], 0x8);
    CheckExternalEvents(cs7, 0x4984);
    // JL 0x1000:49a8 (1000_4982 / 0x14982)
    if(SignFlag != OverflowFlag) {
      goto label_1000_49A8_149A8;
    }
    CheckExternalEvents(cs7, 0x4987);
    // INC word ptr [BP + -0x30] (1000_4984 / 0x14984)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    CheckExternalEvents(cs7, 0x498D);
    // CMP byte ptr ES:[BX + 0x66],0xd (1000_4987 / 0x14987)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x66)], 0xD);
    CheckExternalEvents(cs7, 0x498F);
    // JL 0x1000:4992 (1000_498D / 0x1498D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4992_14992;
    }
    CheckExternalEvents(cs7, 0x4992);
    // INC word ptr [BP + -0x30] (1000_498F / 0x1498F)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    label_1000_4992_14992:
    CheckExternalEvents(cs7, 0x4998);
    // CMP byte ptr ES:[BX + 0x66],0x11 (1000_4992 / 0x14992)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x66)], 0x11);
    CheckExternalEvents(cs7, 0x499A);
    // JL 0x1000:499d (1000_4998 / 0x14998)
    if(SignFlag != OverflowFlag) {
      goto label_1000_499D_1499D;
    }
    CheckExternalEvents(cs7, 0x499D);
    // INC word ptr [BP + -0x30] (1000_499A / 0x1499A)
    UInt16[SS, (ushort)(BP - 0x30)]++;
    label_1000_499D_1499D:
    CheckExternalEvents(cs7, 0x49A3);
    // CMP byte ptr ES:[BX + 0x66],0x18 (1000_499D / 0x1499D)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x66)], 0x18);
    CheckExternalEvents(cs7, 0x49A5);
    // JL 0x1000:49a8 (1000_49A3 / 0x149A3)
    if(SignFlag != OverflowFlag) {
      goto label_1000_49A8_149A8;
    }
    CheckExternalEvents(cs7, 0x49A8);
    // INC word ptr [BP + -0x30] (1000_49A5 / 0x149A5)
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x30)]);
    label_1000_49A8_149A8:
    CheckExternalEvents(cs7, 0x49AC);
    // MOV ES,word ptr [0x565a] (1000_49A8 / 0x149A8)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x49B2);
    // CMP word ptr ES:[0x2e38],0x0 (1000_49AC / 0x149AC)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x0);
    CheckExternalEvents(cs7, 0x49B4);
    // JZ 0x1000:49c5 (1000_49B2 / 0x149B2)
    if(ZeroFlag) {
      goto label_1000_49C5_149C5;
    }
    CheckExternalEvents(cs7, 0x49B7);
    // MOV AX,0x4 (1000_49B4 / 0x149B4)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x49B8);
    // PUSH AX (1000_49B7 / 0x149B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x49BD);
    // CALLF 0x1000:7ee1 (1000_49B8 / 0x149B8)
    FarCall(cs7, 0x49BD, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x49C0);
    // ADD SP,0x2 (1000_49BD / 0x149BD)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x49C5);
    // CALLF 0x1000:7fe8 (1000_49C0 / 0x149C0)
    FarCall(cs7, 0x49C5, unknown_17C6_0388_17FE8);
    label_1000_49C5_149C5:
    CheckExternalEvents(cs7, 0x49C9);
    // MOV ES,word ptr [0x565c] (1000_49C5 / 0x149C5)
    ES = UInt16[DS, 0x565C];
    CheckExternalEvents(cs7, 0x49D0);
    // MOV word ptr ES:[0x37fe],0xf (1000_49C9 / 0x149C9)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs7, 0x49D4);
    // CMP word ptr [BP + -0x2],0xc (1000_49D0 / 0x149D0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x49D6);
    // JL 0x1000:49dd (1000_49D4 / 0x149D4)
    if(SignFlag != OverflowFlag) {
      goto label_1000_49DD_149DD;
    }
    CheckExternalEvents(cs7, 0x49DD);
    // MOV word ptr ES:[0x37fe],0xe (1000_49D6 / 0x149D6)
    UInt16[ES, 0x37FE] = 0xE;
    label_1000_49DD_149DD:
    CheckExternalEvents(cs7, 0x49E1);
    // CMP word ptr [BP + -0x2],0xc (1000_49DD / 0x149DD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x49E3);
    // JL 0x1000:49e6 (1000_49E1 / 0x149E1)
    if(SignFlag != OverflowFlag) {
      goto label_1000_49E6_149E6;
    }
    CheckExternalEvents(cs7, 0x49E6);
    // JMP 0x1000:4a99 (1000_49E3 / 0x149E3)
    goto label_1000_4A99_14A99;
    label_1000_49E6_149E6:
    CheckExternalEvents(cs7, 0x49EA);
    // MOV ES,word ptr [0x565a] (1000_49E6 / 0x149E6)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x49F0);
    // CMP word ptr ES:[0x2e38],0x2 (1000_49EA / 0x149EA)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x49F2);
    // JNZ 0x1000:4a20 (1000_49F0 / 0x149F0)
    if(!ZeroFlag) {
      goto label_1000_4A20_14A20;
    }
    CheckExternalEvents(cs7, 0x49F5);
    // MOV AX,0x11 (1000_49F2 / 0x149F2)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x49F8);
    // IMUL word ptr [BP + -0x26] (1000_49F5 / 0x149F5)
    int resImul1000_49F5 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_49F5);
    DX = (ushort)(resImul1000_49F5 >> 16);
    CheckExternalEvents(cs7, 0x49FA);
    // MOV BX,AX (1000_49F8 / 0x149F8)
    BX = AX;
    CheckExternalEvents(cs7, 0x49FE);
    // MOV ES,word ptr [0x5648] (1000_49FA / 0x149FA)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4A03);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_49FE / 0x149FE)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs7, 0x4A04);
    // CBW  (1000_4A03 / 0x14A03)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4A06);
    // MOV BX,AX (1000_4A04 / 0x14A04)
    BX = AX;
    CheckExternalEvents(cs7, 0x4A08);
    // SHL BX,0x1 (1000_4A06 / 0x14A06)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x4A0A);
    // SHL BX,0x1 (1000_4A08 / 0x14A08)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x4A0E);
    // MOV ES,word ptr [0x565e] (1000_4A0A / 0x14A0A)
    ES = UInt16[DS, 0x565E];
    CheckExternalEvents(cs7, 0x4A13);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_4A0E / 0x14A0E)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs7, 0x4A18);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_4A13 / 0x14A13)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs7, 0x4A1D);
    // CALLF 0x1000:17bb (1000_4A18 / 0x14A18)
    FarCall(cs7, 0x4A1D, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4A20);
    // ADD SP,0x4 (1000_4A1D / 0x14A1D)
    SP += 0x4;
    label_1000_4A20_14A20:
    CheckExternalEvents(cs7, 0x4A24);
    // CMP word ptr [BP + -0x2],0x4 (1000_4A20 / 0x14A20)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x4A26);
    // JGE 0x1000:4a85 (1000_4A24 / 0x14A24)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4A85_14A85;
    }
    CheckExternalEvents(cs7, 0x4A2A);
    // MOV ES,word ptr [0x565a] (1000_4A26 / 0x14A26)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4A30);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4A2A / 0x14A2A)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4A32);
    // JNZ 0x1000:4a3f (1000_4A30 / 0x14A30)
    if(!ZeroFlag) {
      goto label_1000_4A3F_14A3F;
    }
    CheckExternalEvents(cs7, 0x4A35);
    // MOV AX,0x3e44 (1000_4A32 / 0x14A32)
    AX = 0x3E44;
    CheckExternalEvents(cs7, 0x4A36);
    // PUSH DS (1000_4A35 / 0x14A35)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4A37);
    // PUSH AX (1000_4A36 / 0x14A36)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4A3C);
    // CALLF 0x1000:17bb (1000_4A37 / 0x14A37)
    FarCall(cs7, 0x4A3C, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4A3F);
    // ADD SP,0x4 (1000_4A3C / 0x14A3C)
    SP += 0x4;
    label_1000_4A3F_14A3F:
    CheckExternalEvents(cs7, 0x4A43);
    // CMP word ptr [BP + -0x48],0x20 (1000_4A3F / 0x14A3F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x20);
    CheckExternalEvents(cs7, 0x4A45);
    // JNZ 0x1000:4a6f (1000_4A43 / 0x14A43)
    if(!ZeroFlag) {
      goto label_1000_4A6F_14A6F;
    }
    CheckExternalEvents(cs7, 0x4A48);
    // MOV AX,0x3e4d (1000_4A45 / 0x14A45)
    AX = 0x3E4D;
    CheckExternalEvents(cs7, 0x4A49);
    // PUSH DS (1000_4A48 / 0x14A48)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4A4A);
    // PUSH AX (1000_4A49 / 0x14A49)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4A4D);
    // MOV AX,0x12 (1000_4A4A / 0x14A4A)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4A50);
    // MOV DX,0x2a02 (1000_4A4D / 0x14A4D)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4A51);
    // PUSH DX (1000_4A50 / 0x14A50)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4A52);
    // PUSH AX (1000_4A51 / 0x14A51)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4A57);
    // CALLF 0x1000:da58 (1000_4A52 / 0x14A52)
    FarCall(cs7, 0x4A57, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs7, 0x4A5A);
    // ADD SP,0x8 (1000_4A57 / 0x14A57)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x4A5E);
    // MOV ES,word ptr [0x565a] (1000_4A5A / 0x14A5A)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4A64);
    // CMP word ptr ES:[0x2e38],0x1 (1000_4A5E / 0x14A5E)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x1);
    CheckExternalEvents(cs7, 0x4A66);
    // JZ 0x1000:4a69 (1000_4A64 / 0x14A64)
    if(ZeroFlag) {
      goto label_1000_4A69_14A69;
    }
    CheckExternalEvents(cs7, 0x4A69);
    // JMP 0x1000:4b2f (1000_4A66 / 0x14A66)
    goto label_1000_4B2F_14B2F;
    label_1000_4A69_14A69:
    CheckExternalEvents(cs7, 0x4A6C);
    // MOV AX,0x3e53 (1000_4A69 / 0x14A69)
    AX = 0x3E53;
    CheckExternalEvents(cs7, 0x4A6F);
    // JMP 0x1000:4b1d (1000_4A6C / 0x14A6C)
    goto label_1000_4B1D_14B1D;
    label_1000_4A6F_14A6F:
    CheckExternalEvents(cs7, 0x4A73);
    // MOV ES,word ptr [0x565a] (1000_4A6F / 0x14A6F)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4A79);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4A73 / 0x14A73)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4A7B);
    // JZ 0x1000:4a7e (1000_4A79 / 0x14A79)
    if(ZeroFlag) {
      goto label_1000_4A7E_14A7E;
    }
    CheckExternalEvents(cs7, 0x4A7E);
    // JMP 0x1000:4b3f (1000_4A7B / 0x14A7B)
    goto label_1000_4B3F_14B3F;
    label_1000_4A7E_14A7E:
    CheckExternalEvents(cs7, 0x4A81);
    // MOV AX,0x3e58 (1000_4A7E / 0x14A7E)
    AX = 0x3E58;
    label_1000_4A81_14A81:
    CheckExternalEvents(cs7, 0x4A82);
    // PUSH DS (1000_4A81 / 0x14A81)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4A85);
    // JMP 0x1000:4b36 (1000_4A82 / 0x14A82)
    goto label_1000_4B36_14B36;
    label_1000_4A85_14A85:
    CheckExternalEvents(cs7, 0x4A89);
    // MOV ES,word ptr [0x565a] (1000_4A85 / 0x14A85)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4A8F);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4A89 / 0x14A89)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4A91);
    // JZ 0x1000:4a94 (1000_4A8F / 0x14A8F)
    if(ZeroFlag) {
      goto label_1000_4A94_14A94;
    }
    CheckExternalEvents(cs7, 0x4A94);
    // JMP 0x1000:4b3f (1000_4A91 / 0x14A91)
    goto label_1000_4B3F_14B3F;
    label_1000_4A94_14A94:
    CheckExternalEvents(cs7, 0x4A97);
    // MOV AX,0x3e60 (1000_4A94 / 0x14A94)
    AX = 0x3E60;
    CheckExternalEvents(cs7, 0x4A99);
    // JMP 0x1000:4a81 (1000_4A97 / 0x14A97)
    goto label_1000_4A81_14A81;
    label_1000_4A99_14A99:
    CheckExternalEvents(cs7, 0x4A9D);
    // MOV ES,word ptr [0x565a] (1000_4A99 / 0x14A99)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4AA3);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4A9D / 0x14A9D)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4AA5);
    // JNZ 0x1000:4ab2 (1000_4AA3 / 0x14AA3)
    if(!ZeroFlag) {
      goto label_1000_4AB2_14AB2;
    }
    CheckExternalEvents(cs7, 0x4AA8);
    // MOV AX,0x3e69 (1000_4AA5 / 0x14AA5)
    AX = 0x3E69;
    CheckExternalEvents(cs7, 0x4AA9);
    // PUSH DS (1000_4AA8 / 0x14AA8)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4AAA);
    // PUSH AX (1000_4AA9 / 0x14AA9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4AAF);
    // CALLF 0x1000:17bb (1000_4AAA / 0x14AAA)
    FarCall(cs7, 0x4AAF, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4AB2);
    // ADD SP,0x4 (1000_4AAF / 0x14AAF)
    SP += 0x4;
    label_1000_4AB2_14AB2:
    CheckExternalEvents(cs7, 0x4AB6);
    // CMP word ptr [BP + -0x2],0x10 (1000_4AB2 / 0x14AB2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x4AB8);
    // JL 0x1000:4ac9 (1000_4AB6 / 0x14AB6)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4AC9_14AC9;
    }
    CheckExternalEvents(cs7, 0x4ABC);
    // MOV ES,word ptr [0x565a] (1000_4AB8 / 0x14AB8)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4AC2);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4ABC / 0x14ABC)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4AC4);
    // JNZ 0x1000:4b3f (1000_4AC2 / 0x14AC2)
    if(!ZeroFlag) {
      goto label_1000_4B3F_14B3F;
    }
    CheckExternalEvents(cs7, 0x4AC7);
    // MOV AX,0x3e73 (1000_4AC4 / 0x14AC4)
    AX = 0x3E73;
    CheckExternalEvents(cs7, 0x4AC9);
    // JMP 0x1000:4a81 (1000_4AC7 / 0x14AC7)
    goto label_1000_4A81_14A81;
    label_1000_4AC9_14AC9:
    CheckExternalEvents(cs7, 0x4ACD);
    // MOV ES,word ptr [0x565a] (1000_4AC9 / 0x14AC9)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4AD3);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4ACD / 0x14ACD)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4AD5);
    // JNZ 0x1000:4ae2 (1000_4AD3 / 0x14AD3)
    if(!ZeroFlag) {
      goto label_1000_4AE2_14AE2;
    }
    CheckExternalEvents(cs7, 0x4AD8);
    // MOV AX,0x3e81 (1000_4AD5 / 0x14AD5)
    AX = 0x3E81;
    CheckExternalEvents(cs7, 0x4AD9);
    // PUSH DS (1000_4AD8 / 0x14AD8)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4ADA);
    // PUSH AX (1000_4AD9 / 0x14AD9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4ADF);
    // CALLF 0x1000:17bb (1000_4ADA / 0x14ADA)
    FarCall(cs7, 0x4ADF, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4AE2);
    // ADD SP,0x4 (1000_4ADF / 0x14ADF)
    SP += 0x4;
    label_1000_4AE2_14AE2:
    CheckExternalEvents(cs7, 0x4AE6);
    // CMP word ptr [BP + -0x48],0x20 (1000_4AE2 / 0x14AE2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x20);
    CheckExternalEvents(cs7, 0x4AE8);
    // JZ 0x1000:4af9 (1000_4AE6 / 0x14AE6)
    if(ZeroFlag) {
      goto label_1000_4AF9_14AF9;
    }
    CheckExternalEvents(cs7, 0x4AEC);
    // MOV ES,word ptr [0x565a] (1000_4AE8 / 0x14AE8)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4AF2);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4AEC / 0x14AEC)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4AF4);
    // JNZ 0x1000:4b3f (1000_4AF2 / 0x14AF2)
    if(!ZeroFlag) {
      goto label_1000_4B3F_14B3F;
    }
    CheckExternalEvents(cs7, 0x4AF7);
    // MOV AX,0x3e87 (1000_4AF4 / 0x14AF4)
    AX = 0x3E87;
    CheckExternalEvents(cs7, 0x4AF9);
    // JMP 0x1000:4a81 (1000_4AF7 / 0x14AF7)
    goto label_1000_4A81_14A81;
    label_1000_4AF9_14AF9:
    CheckExternalEvents(cs7, 0x4AFC);
    // MOV AX,0x3e8f (1000_4AF9 / 0x14AF9)
    AX = 0x3E8F;
    CheckExternalEvents(cs7, 0x4AFD);
    // PUSH DS (1000_4AFC / 0x14AFC)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4AFE);
    // PUSH AX (1000_4AFD / 0x14AFD)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B01);
    // MOV AX,0x12 (1000_4AFE / 0x14AFE)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4B04);
    // MOV DX,0x2a02 (1000_4B01 / 0x14B01)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4B05);
    // PUSH DX (1000_4B04 / 0x14B04)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4B06);
    // PUSH AX (1000_4B05 / 0x14B05)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B0B);
    // CALLF 0x1000:da58 (1000_4B06 / 0x14B06)
    FarCall(cs7, 0x4B0B, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs7, 0x4B0E);
    // ADD SP,0x8 (1000_4B0B / 0x14B0B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x4B12);
    // MOV ES,word ptr [0x565a] (1000_4B0E / 0x14B0E)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4B18);
    // CMP word ptr ES:[0x2e38],0x1 (1000_4B12 / 0x14B12)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x1);
    CheckExternalEvents(cs7, 0x4B1A);
    // JNZ 0x1000:4b2f (1000_4B18 / 0x14B18)
    if(!ZeroFlag) {
      goto label_1000_4B2F_14B2F;
    }
    CheckExternalEvents(cs7, 0x4B1D);
    // MOV AX,0x3e95 (1000_4B1A / 0x14B1A)
    AX = 0x3E95;
    label_1000_4B1D_14B1D:
    CheckExternalEvents(cs7, 0x4B1E);
    // PUSH DS (1000_4B1D / 0x14B1D)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4B1F);
    // PUSH AX (1000_4B1E / 0x14B1E)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B22);
    // MOV AX,0x12 (1000_4B1F / 0x14B1F)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4B25);
    // MOV DX,0x2a02 (1000_4B22 / 0x14B22)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4B26);
    // PUSH DX (1000_4B25 / 0x14B25)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4B27);
    // PUSH AX (1000_4B26 / 0x14B26)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B2C);
    // CALLF 0x1000:da58 (1000_4B27 / 0x14B27)
    FarCall(cs7, 0x4B2C, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs7, 0x4B2F);
    // ADD SP,0x8 (1000_4B2C / 0x14B2C)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_1000_4B2F_14B2F:
    CheckExternalEvents(cs7, 0x4B32);
    // MOV AX,0x12 (1000_4B2F / 0x14B2F)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4B35);
    // MOV DX,0x2a02 (1000_4B32 / 0x14B32)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4B36);
    // PUSH DX (1000_4B35 / 0x14B35)
    Stack.Push16(DX);
    label_1000_4B36_14B36:
    CheckExternalEvents(cs7, 0x4B37);
    // PUSH AX (1000_4B36 / 0x14B36)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B3C);
    // CALLF 0x1000:17bb (1000_4B37 / 0x14B37)
    FarCall(cs7, 0x4B3C, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4B3F);
    // ADD SP,0x4 (1000_4B3C / 0x14B3C)
    SP += 0x4;
    label_1000_4B3F_14B3F:
    CheckExternalEvents(cs7, 0x4B43);
    // CMP word ptr [BP + -0x48],0x20 (1000_4B3F / 0x14B3F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x20);
    CheckExternalEvents(cs7, 0x4B45);
    // JZ 0x1000:4b5e (1000_4B43 / 0x14B43)
    if(ZeroFlag) {
      goto label_1000_4B5E_14B5E;
    }
    CheckExternalEvents(cs7, 0x4B48);
    // MOV AX,0x11 (1000_4B45 / 0x14B45)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4B4B);
    // IMUL word ptr [BP + -0x48] (1000_4B48 / 0x14B48)
    int resImul1000_4B48 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_4B48);
    DX = (ushort)(resImul1000_4B48 >> 16);
    CheckExternalEvents(cs7, 0x4B4D);
    // MOV BX,AX (1000_4B4B / 0x14B4B)
    BX = AX;
    CheckExternalEvents(cs7, 0x4B51);
    // LEA AX,[BX + 0x2ed8] (1000_4B4D / 0x14B4D)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs7, 0x4B54);
    // MOV DX,0x384b (1000_4B51 / 0x14B51)
    DX = 0x384B;
    CheckExternalEvents(cs7, 0x4B55);
    // PUSH DX (1000_4B54 / 0x14B54)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4B56);
    // PUSH AX (1000_4B55 / 0x14B55)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B5B);
    // CALLF 0x1000:17bb (1000_4B56 / 0x14B56)
    FarCall(cs7, 0x4B5B, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4B5E);
    // ADD SP,0x4 (1000_4B5B / 0x14B5B)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_4B5E_14B5E:
    CheckExternalEvents(cs7, 0x4B62);
    // MOV ES,word ptr [0x565a] (1000_4B5E / 0x14B5E)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4B68);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4B62 / 0x14B62)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4B6A);
    // JNZ 0x1000:4b77 (1000_4B68 / 0x14B68)
    if(!ZeroFlag) {
      goto label_1000_4B77_14B77;
    }
    CheckExternalEvents(cs7, 0x4B6D);
    // MOV AX,0x3e9a (1000_4B6A / 0x14B6A)
    AX = 0x3E9A;
    CheckExternalEvents(cs7, 0x4B6E);
    // PUSH DS (1000_4B6D / 0x14B6D)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4B6F);
    // PUSH AX (1000_4B6E / 0x14B6E)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4B74);
    // CALLF 0x1000:17bb (1000_4B6F / 0x14B6F)
    FarCall(cs7, 0x4B74, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4B77);
    // ADD SP,0x4 (1000_4B74 / 0x14B74)
    SP += 0x4;
    label_1000_4B77_14B77:
    CheckExternalEvents(cs7, 0x4B7B);
    // CMP word ptr [BP + -0x28],0xc (1000_4B77 / 0x14B77)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0xC);
    CheckExternalEvents(cs7, 0x4B7D);
    // JL 0x1000:4b80 (1000_4B7B / 0x14B7B)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4B80_14B80;
    }
    CheckExternalEvents(cs7, 0x4B80);
    // JMP 0x1000:4c39 (1000_4B7D / 0x14B7D)
    goto label_1000_4C39_14C39;
    label_1000_4B80_14B80:
    CheckExternalEvents(cs7, 0x4B84);
    // CMP word ptr [BP + -0x28],0x4 (1000_4B80 / 0x14B80)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x4);
    CheckExternalEvents(cs7, 0x4B86);
    // JL 0x1000:4bbb (1000_4B84 / 0x14B84)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4BBB_14BBB;
    }
    CheckExternalEvents(cs7, 0x4B89);
    // MOV AX,0x11 (1000_4B86 / 0x14B86)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4B8C);
    // IMUL word ptr [BP + -0x28] (1000_4B89 / 0x14B89)
    int resImul1000_4B89 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x28)]);
    AX = (ushort)(resImul1000_4B89);
    DX = (ushort)(resImul1000_4B89 >> 16);
    CheckExternalEvents(cs7, 0x4B8E);
    // MOV BX,AX (1000_4B8C / 0x14B8C)
    BX = AX;
    CheckExternalEvents(cs7, 0x4B92);
    // MOV ES,word ptr [0x5648] (1000_4B8E / 0x14B8E)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4B97);
    // MOV AL,byte ptr ES:[BX + 0xc5d0] (1000_4B92 / 0x14B92)
    AL = UInt8[ES, (ushort)(BX + 0xC5D0)];
    CheckExternalEvents(cs7, 0x4B98);
    // CBW  (1000_4B97 / 0x14B97)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4B9A);
    // MOV BX,AX (1000_4B98 / 0x14B98)
    BX = AX;
    CheckExternalEvents(cs7, 0x4B9C);
    // SHL BX,0x1 (1000_4B9A / 0x14B9A)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x4B9E);
    // SHL BX,0x1 (1000_4B9C / 0x14B9C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x4BA2);
    // MOV ES,word ptr [0x565e] (1000_4B9E / 0x14B9E)
    ES = UInt16[DS, 0x565E];
    CheckExternalEvents(cs7, 0x4BA7);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_4BA2 / 0x14BA2)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs7, 0x4BAC);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_4BA7 / 0x14BA7)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs7, 0x4BAF);
    // MOV AX,0x12 (1000_4BAC / 0x14BAC)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4BB2);
    // MOV DX,0x2a02 (1000_4BAF / 0x14BAF)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4BB3);
    // PUSH DX (1000_4BB2 / 0x14BB2)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4BB4);
    // PUSH AX (1000_4BB3 / 0x14BB3)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4BB9);
    // CALLF 0x1000:da58 (1000_4BB4 / 0x14BB4)
    FarCall(cs7, 0x4BB9, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs7, 0x4BBB);
    // JMP 0x1000:4c0c (1000_4BB9 / 0x14BB9)
    goto label_1000_4C0C_14C0C;
    label_1000_4BBB_14BBB:
    CheckExternalEvents(cs7, 0x4BBE);
    // MOV AX,0x7d (1000_4BBB / 0x14BBB)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x4BC1);
    // IMUL word ptr [BP + -0x28] (1000_4BBE / 0x14BBE)
    int resImul1000_4BBE = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x28)]);
    AX = (ushort)(resImul1000_4BBE);
    DX = (ushort)(resImul1000_4BBE >> 16);
    CheckExternalEvents(cs7, 0x4BC3);
    // MOV BX,AX (1000_4BC1 / 0x14BC1)
    BX = AX;
    CheckExternalEvents(cs7, 0x4BC7);
    // MOV ES,word ptr [0x5648] (1000_4BC3 / 0x14BC3)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4BC9);
    // MOV AL,0x11 (1000_4BC7 / 0x14BC7)
    AL = 0x11;
    CheckExternalEvents(cs7, 0x4BCE);
    // MUL byte ptr ES:[BX + 0xc79d] (1000_4BC9 / 0x14BC9)
    ushort resMul1000_4BC9 = Alu8.Mul(AL, UInt8[ES, (ushort)(BX + 0xC79D)]);
    AL = (byte)(resMul1000_4BC9);
    AH = (byte)(resMul1000_4BC9 >> 8);
    CheckExternalEvents(cs7, 0x4BD0);
    // MOV BX,AX (1000_4BCE / 0x14BCE)
    BX = AX;
    CheckExternalEvents(cs7, 0x4BD5);
    // MOV AL,byte ptr ES:[BX + 0xc614] (1000_4BD0 / 0x14BD0)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs7, 0x4BD6);
    // CBW  (1000_4BD5 / 0x14BD5)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4BD8);
    // MOV BX,AX (1000_4BD6 / 0x14BD6)
    BX = AX;
    CheckExternalEvents(cs7, 0x4BDA);
    // SHL BX,0x1 (1000_4BD8 / 0x14BD8)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x4BDC);
    // SHL BX,0x1 (1000_4BDA / 0x14BDA)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x4BE0);
    // MOV ES,word ptr [0x565e] (1000_4BDC / 0x14BDC)
    ES = UInt16[DS, 0x565E];
    CheckExternalEvents(cs7, 0x4BE5);
    // PUSH word ptr ES:[BX + 0x1cc] (1000_4BE0 / 0x14BE0)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs7, 0x4BEA);
    // PUSH word ptr ES:[BX + 0x1ca] (1000_4BE5 / 0x14BE5)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs7, 0x4BED);
    // MOV AX,0x12 (1000_4BEA / 0x14BEA)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4BF0);
    // MOV DX,0x2a02 (1000_4BED / 0x14BED)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4BF1);
    // PUSH DX (1000_4BF0 / 0x14BF0)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4BF2);
    // PUSH AX (1000_4BF1 / 0x14BF1)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4BF7);
    // CALLF 0x1000:da58 (1000_4BF2 / 0x14BF2)
    FarCall(cs7, 0x4BF7, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs7, 0x4BFA);
    // ADD SP,0x8 (1000_4BF7 / 0x14BF7)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x4BFD);
    // MOV AX,0x3e9f (1000_4BFA / 0x14BFA)
    AX = 0x3E9F;
    CheckExternalEvents(cs7, 0x4BFE);
    // PUSH DS (1000_4BFD / 0x14BFD)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4BFF);
    // PUSH AX (1000_4BFE / 0x14BFE)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C02);
    // MOV AX,0x12 (1000_4BFF / 0x14BFF)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4C05);
    // MOV DX,0x2a02 (1000_4C02 / 0x14C02)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4C06);
    // PUSH DX (1000_4C05 / 0x14C05)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4C07);
    // PUSH AX (1000_4C06 / 0x14C06)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C0C);
    // CALLF 0x1000:da12 (1000_4C07 / 0x14C07)
    FarCall(cs7, 0x4C0C, unknown_19EF_3B22_1DA12);
    label_1000_4C0C_14C0C:
    CheckExternalEvents(cs7, 0x4C0F);
    // ADD SP,0x8 (1000_4C0C / 0x14C0C)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x4C12);
    // MOV AX,0x3ea7 (1000_4C0F / 0x14C0F)
    AX = 0x3EA7;
    CheckExternalEvents(cs7, 0x4C13);
    // PUSH DS (1000_4C12 / 0x14C12)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4C14);
    // PUSH AX (1000_4C13 / 0x14C13)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C17);
    // MOV AX,0x12 (1000_4C14 / 0x14C14)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4C1A);
    // MOV DX,0x2a02 (1000_4C17 / 0x14C17)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4C1B);
    // PUSH DX (1000_4C1A / 0x14C1A)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4C1C);
    // PUSH AX (1000_4C1B / 0x14C1B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C21);
    // CALLF 0x1000:da12 (1000_4C1C / 0x14C1C)
    FarCall(cs7, 0x4C21, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs7, 0x4C24);
    // ADD SP,0x8 (1000_4C21 / 0x14C21)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x4C28);
    // MOV ES,word ptr [0x565a] (1000_4C24 / 0x14C24)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4C2E);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4C28 / 0x14C28)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4C30);
    // JNZ 0x1000:4c9b (1000_4C2E / 0x14C2E)
    if(!ZeroFlag) {
      goto label_1000_4C9B_14C9B;
    }
    CheckExternalEvents(cs7, 0x4C33);
    // MOV AX,0x12 (1000_4C30 / 0x14C30)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x4C36);
    // MOV DX,0x2a02 (1000_4C33 / 0x14C33)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x4C37);
    // PUSH DX (1000_4C36 / 0x14C36)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x4C39);
    // JMP 0x1000:4c92 (1000_4C37 / 0x14C37)
    goto label_1000_4C92_14C92;
    label_1000_4C39_14C39:
    CheckExternalEvents(cs7, 0x4C3D);
    // MOV ES,word ptr [0x565a] (1000_4C39 / 0x14C39)
    ES = UInt16[DS, 0x565A];
    CheckExternalEvents(cs7, 0x4C43);
    // CMP word ptr ES:[0x2e38],0x2 (1000_4C3D / 0x14C3D)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x2);
    CheckExternalEvents(cs7, 0x4C45);
    // JNZ 0x1000:4c9b (1000_4C43 / 0x14C43)
    if(!ZeroFlag) {
      goto label_1000_4C9B_14C9B;
    }
    CheckExternalEvents(cs7, 0x4C49);
    // MOV ES,word ptr [0x5660] (1000_4C45 / 0x14C45)
    ES = UInt16[DS, 0x5660];
    CheckExternalEvents(cs7, 0x4C4F);
    // CMP word ptr ES:[0xe48e],0x0 (1000_4C49 / 0x14C49)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs7, 0x4C51);
    // JZ 0x1000:4c57 (1000_4C4F / 0x14C4F)
    if(ZeroFlag) {
      goto label_1000_4C57_14C57;
    }
    CheckExternalEvents(cs7, 0x4C55);
    // CMP word ptr [BP + -0x28],0xd (1000_4C51 / 0x14C51)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0xD);
    CheckExternalEvents(cs7, 0x4C57);
    // JZ 0x1000:4c7c (1000_4C55 / 0x14C55)
    if(ZeroFlag) {
      goto label_1000_4C7C_14C7C;
    }
    label_1000_4C57_14C57:
    CheckExternalEvents(cs7, 0x4C5A);
    // MOV AX,0x3ea9 (1000_4C57 / 0x14C57)
    AX = 0x3EA9;
    CheckExternalEvents(cs7, 0x4C5B);
    // PUSH DS (1000_4C5A / 0x14C5A)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4C5C);
    // PUSH AX (1000_4C5B / 0x14C5B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C61);
    // CALLF 0x1000:17bb (1000_4C5C / 0x14C5C)
    FarCall(cs7, 0x4C61, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4C64);
    // ADD SP,0x4 (1000_4C61 / 0x14C61)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x4C68);
    // CMP word ptr [BP + -0x28],0x10 (1000_4C64 / 0x14C64)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x10);
    CheckExternalEvents(cs7, 0x4C6A);
    // JGE 0x1000:4c6f (1000_4C68 / 0x14C68)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4C6F_14C6F;
    }
    CheckExternalEvents(cs7, 0x4C6D);
    // MOV AX,0x3eb3 (1000_4C6A / 0x14C6A)
    AX = 0x3EB3;
    CheckExternalEvents(cs7, 0x4C6F);
    // JMP 0x1000:4c72 (1000_4C6D / 0x14C6D)
    goto label_1000_4C72_14C72;
    label_1000_4C6F_14C6F:
    CheckExternalEvents(cs7, 0x4C72);
    // MOV AX,0x3eb9 (1000_4C6F / 0x14C6F)
    AX = 0x3EB9;
    label_1000_4C72_14C72:
    CheckExternalEvents(cs7, 0x4C73);
    // PUSH DS (1000_4C72 / 0x14C72)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4C74);
    // PUSH AX (1000_4C73 / 0x14C73)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C79);
    // CALLF 0x1000:17bb (1000_4C74 / 0x14C74)
    FarCall(cs7, 0x4C79, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4C7C);
    // ADD SP,0x4 (1000_4C79 / 0x14C79)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_4C7C_14C7C:
    CheckExternalEvents(cs7, 0x4C80);
    // MOV ES,word ptr [0x5660] (1000_4C7C / 0x14C7C)
    ES = UInt16[DS, 0x5660];
    CheckExternalEvents(cs7, 0x4C86);
    // CMP word ptr ES:[0xe48e],0x0 (1000_4C80 / 0x14C80)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs7, 0x4C88);
    // JZ 0x1000:4c9b (1000_4C86 / 0x14C86)
    if(ZeroFlag) {
      goto label_1000_4C9B_14C9B;
    }
    CheckExternalEvents(cs7, 0x4C8C);
    // CMP word ptr [BP + -0x28],0xd (1000_4C88 / 0x14C88)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0xD);
    CheckExternalEvents(cs7, 0x4C8E);
    // JNZ 0x1000:4c9b (1000_4C8C / 0x14C8C)
    if(!ZeroFlag) {
      goto label_1000_4C9B_14C9B;
    }
    CheckExternalEvents(cs7, 0x4C91);
    // MOV AX,0x3ec0 (1000_4C8E / 0x14C8E)
    AX = 0x3EC0;
    CheckExternalEvents(cs7, 0x4C92);
    // PUSH DS (1000_4C91 / 0x14C91)
    Stack.Push16(DS);
    label_1000_4C92_14C92:
    CheckExternalEvents(cs7, 0x4C93);
    // PUSH AX (1000_4C92 / 0x14C92)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4C98);
    // CALLF 0x1000:17bb (1000_4C93 / 0x14C93)
    FarCall(cs7, 0x4C98, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4C9B);
    // ADD SP,0x4 (1000_4C98 / 0x14C98)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_4C9B_14C9B:
    CheckExternalEvents(cs7, 0x4C9E);
    // MOV AX,0x11 (1000_4C9B / 0x14C9B)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4CA1);
    // IMUL word ptr [BP + -0x48] (1000_4C9E / 0x14C9E)
    int resImul1000_4C9E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_4C9E);
    DX = (ushort)(resImul1000_4C9E >> 16);
    CheckExternalEvents(cs7, 0x4CA3);
    // MOV BX,AX (1000_4CA1 / 0x14CA1)
    BX = AX;
    CheckExternalEvents(cs7, 0x4CA7);
    // MOV ES,word ptr [0x5652] (1000_4CA3 / 0x14CA3)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4CAC);
    // MOV BL,byte ptr ES:[BX + 0x2ee8] (1000_4CA7 / 0x14CA7)
    BL = UInt8[ES, (ushort)(BX + 0x2EE8)];
    CheckExternalEvents(cs7, 0x4CAE);
    // SUB BH,BH (1000_4CAC / 0x14CAC)
    // BH -= BH;
    BH = Alu8.Sub(BH, BH);
    CheckExternalEvents(cs7, 0x4CB1);
    // MOV AX,0x11 (1000_4CAE / 0x14CAE)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4CB4);
    // IMUL word ptr [BP + -0x26] (1000_4CB1 / 0x14CB1)
    int resImul1000_4CB1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x26)]);
    AX = (ushort)(resImul1000_4CB1);
    DX = (ushort)(resImul1000_4CB1 >> 16);
    CheckExternalEvents(cs7, 0x4CB6);
    // ADD BX,AX (1000_4CB4 / 0x14CB4)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs7, 0x4CBA);
    // MOV ES,word ptr [0x5648] (1000_4CB6 / 0x14CB6)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4CBF);
    // MOV AL,byte ptr ES:[BX + 0xc618] (1000_4CBA / 0x14CBA)
    AL = UInt8[ES, (ushort)(BX + 0xC618)];
    CheckExternalEvents(cs7, 0x4CC0);
    // CBW  (1000_4CBF / 0x14CBF)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4CC3);
    // SUB word ptr [BP + -0x30],AX (1000_4CC0 / 0x14CC0)
    UInt16[SS, (ushort)(BP - 0x30)] -= AX;
    CheckExternalEvents(cs7, 0x4CC7);
    // CMP word ptr [BP + -0x28],0x4 (1000_4CC3 / 0x14CC3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x4);
    CheckExternalEvents(cs7, 0x4CC9);
    // JL 0x1000:4ccf (1000_4CC7 / 0x14CC7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4CCF_14CCF;
    }
    CheckExternalEvents(cs7, 0x4CCD);
    // CMP word ptr [BP + -0x28],0xc (1000_4CC9 / 0x14CC9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0xC);
    CheckExternalEvents(cs7, 0x4CCF);
    // JL 0x1000:4cd8 (1000_4CCD / 0x14CCD)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4CD8_14CD8;
    }
    label_1000_4CCF_14CCF:
    CheckExternalEvents(cs7, 0x4CD3);
    // CMP word ptr [BP + -0x28],0x10 (1000_4CCF / 0x14CCF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x10);
    CheckExternalEvents(cs7, 0x4CD5);
    // JGE 0x1000:4cd8 (1000_4CD3 / 0x14CD3)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4CD8_14CD8;
    }
    CheckExternalEvents(cs7, 0x4CD8);
    // JMP 0x1000:4e9d (1000_4CD5 / 0x14CD5)
    goto label_1000_4E9D_14E9D;
    label_1000_4CD8_14CD8:
    CheckExternalEvents(cs7, 0x4CDB);
    // MOV AX,word ptr [BP + -0x28] (1000_4CD8 / 0x14CD8)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x4CDE);
    // SUB AX,0x4 (1000_4CDB / 0x14CDB)
    // AX -= 0x4;
    AX = Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs7, 0x4CE1);
    // MOV word ptr [BP + -0xc],AX (1000_4CDE / 0x14CDE)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x4CE4);
    // CMP AX,0xc (1000_4CE1 / 0x14CE1)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs7, 0x4CE6);
    // JL 0x1000:4cea (1000_4CE4 / 0x14CE4)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4CEA_14CEA;
    }
    CheckExternalEvents(cs7, 0x4CEA);
    // SUB word ptr [BP + -0xc],0x4 (1000_4CE6 / 0x14CE6)
    // UInt16[SS, (ushort)(BP - 0xC)] -= 0x4;
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    label_1000_4CEA_14CEA:
    CheckExternalEvents(cs7, 0x4CED);
    // MOV BX,word ptr [BP + -0x28] (1000_4CEA / 0x14CEA)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x4CF1);
    // MOV ES,word ptr [0x5662] (1000_4CED / 0x14CED)
    ES = UInt16[DS, 0x5662];
    CheckExternalEvents(cs7, 0x4CF6);
    // MOV AL,byte ptr ES:[BX + 0x32ae] (1000_4CF1 / 0x14CF1)
    AL = UInt8[ES, (ushort)(BX + 0x32AE)];
    CheckExternalEvents(cs7, 0x4CF7);
    // CBW  (1000_4CF6 / 0x14CF6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4CF9);
    // SAR AX,0x1 (1000_4CF7 / 0x14CF7)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x4CFC);
    // ADD word ptr [BP + -0x30],AX (1000_4CF9 / 0x14CF9)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], AX);
    CheckExternalEvents(cs7, 0x4D01);
    // MOV word ptr [BP + -0x7c],0x7f (1000_4CFC / 0x14CFC)
    UInt16[SS, (ushort)(BP - 0x7C)] = 0x7F;
    CheckExternalEvents(cs7, 0x4D04);
    // MOV AX,0x11 (1000_4D01 / 0x14D01)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4D07);
    // IMUL word ptr [BP + -0x48] (1000_4D04 / 0x14D04)
    int resImul1000_4D04 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_4D04);
    DX = (ushort)(resImul1000_4D04 >> 16);
    CheckExternalEvents(cs7, 0x4D09);
    // MOV SI,AX (1000_4D07 / 0x14D07)
    SI = AX;
    CheckExternalEvents(cs7, 0x4D0D);
    // MOV ES,word ptr [0x5652] (1000_4D09 / 0x14D09)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4D12);
    // MOV AL,byte ptr ES:[SI + 0x2ee4] (1000_4D0D / 0x14D0D)
    AL = UInt8[ES, (ushort)(SI + 0x2EE4)];
    CheckExternalEvents(cs7, 0x4D14);
    // SUB AH,AH (1000_4D12 / 0x14D12)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x4D17);
    // MOV word ptr [BP + -0x34],AX (1000_4D14 / 0x14D14)
    UInt16[SS, (ushort)(BP - 0x34)] = AX;
    CheckExternalEvents(cs7, 0x4D1B);
    // TEST byte ptr [BP + -0x34],0x80 (1000_4D17 / 0x14D17)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x34)], 0x80);
    CheckExternalEvents(cs7, 0x4D1D);
    // JZ 0x1000:4d4c (1000_4D1B / 0x14D1B)
    if(ZeroFlag) {
      goto label_1000_4D4C_14D4C;
    }
    CheckExternalEvents(cs7, 0x4D22);
    // MOV AL,byte ptr ES:[SI + 0x2ee3] (1000_4D1D / 0x14D1D)
    AL = UInt8[ES, (ushort)(SI + 0x2EE3)];
    CheckExternalEvents(cs7, 0x4D25);
    // MOV word ptr [BP + -0x32],AX (1000_4D22 / 0x14D22)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs7, 0x4D28);
    // AND AX,0xf (1000_4D25 / 0x14D25)
    // AX &= 0xF;
    AX = Alu16.And(AX, 0xF);
    CheckExternalEvents(cs7, 0x4D2B);
    // MOV word ptr [BP + -0x7c],AX (1000_4D28 / 0x14D28)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    CheckExternalEvents(cs7, 0x4D2E);
    // MOV AX,word ptr [BP + -0x32] (1000_4D2B / 0x14D2B)
    AX = UInt16[SS, (ushort)(BP - 0x32)];
    CheckExternalEvents(cs7, 0x4D30);
    // MOV CL,0x4 (1000_4D2E / 0x14D2E)
    CL = 0x4;
    CheckExternalEvents(cs7, 0x4D32);
    // SAR AX,CL (1000_4D30 / 0x14D30)
    AX = Alu16.Sar(AX, CL);
    CheckExternalEvents(cs7, 0x4D35);
    // AND AX,0xf (1000_4D32 / 0x14D32)
    // AX &= 0xF;
    AX = Alu16.And(AX, 0xF);
    CheckExternalEvents(cs7, 0x4D38);
    // MOV word ptr [BP + -0x32],AX (1000_4D35 / 0x14D35)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs7, 0x4D3A);
    // JMP 0x1000:4d42 (1000_4D38 / 0x14D38)
    goto label_1000_4D42_14D42;
    label_1000_4D3A_14D3A:
    CheckExternalEvents(cs7, 0x4D3F);
    // CALLF 0x0000:30f3 (1000_4D3A / 0x14D3A)
    FarCall(cs7, 0x4D3F, ghidra_guess_0000_30F3_030F3);
    CheckExternalEvents(cs7, 0x4D42);
    // ADD word ptr [BP + -0x7c],AX (1000_4D3F / 0x14D3F)
    // UInt16[SS, (ushort)(BP - 0x7C)] += AX;
    UInt16[SS, (ushort)(BP - 0x7C)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x7C)], AX);
    label_1000_4D42_14D42:
    CheckExternalEvents(cs7, 0x4D45);
    // MOV AX,word ptr [BP + -0x32] (1000_4D42 / 0x14D42)
    AX = UInt16[SS, (ushort)(BP - 0x32)];
    CheckExternalEvents(cs7, 0x4D48);
    // DEC word ptr [BP + -0x32] (1000_4D45 / 0x14D45)
    UInt16[SS, (ushort)(BP - 0x32)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x32)]);
    CheckExternalEvents(cs7, 0x4D4A);
    // OR AX,AX (1000_4D48 / 0x14D48)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x4D4C);
    // JNZ 0x1000:4d3a (1000_4D4A / 0x14D4A)
    if(!ZeroFlag) {
      goto label_1000_4D3A_14D3A;
    }
    label_1000_4D4C_14D4C:
    CheckExternalEvents(cs7, 0x4D50);
    // AND word ptr [BP + -0x34],0x7f (1000_4D4C / 0x14D4C)
    UInt16[SS, (ushort)(BP - 0x34)] &= 0x7F;
    CheckExternalEvents(cs7, 0x4D54);
    // CMP word ptr [BP + -0x7c],0x0 (1000_4D50 / 0x14D50)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x7C)], 0x0);
    CheckExternalEvents(cs7, 0x4D56);
    // JNZ 0x1000:4d59 (1000_4D54 / 0x14D54)
    if(!ZeroFlag) {
      goto label_1000_4D59_14D59;
    }
    CheckExternalEvents(cs7, 0x4D59);
    // INC word ptr [BP + -0x7c] (1000_4D56 / 0x14D56)
    UInt16[SS, (ushort)(BP - 0x7C)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x7C)]);
    label_1000_4D59_14D59:
    CheckExternalEvents(cs7, 0x4D5E);
    // CALLF 0x0000:30dd (1000_4D59 / 0x14D59)
    FarCall(cs7, 0x4D5E, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs7, 0x4D61);
    // CMP AX,word ptr [BP + -0x30] (1000_4D5E / 0x14D5E)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs7, 0x4D63);
    // JGE 0x1000:4dcb (1000_4D61 / 0x14D61)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4DCB_14DCB;
    }
    CheckExternalEvents(cs7, 0x4D66);
    // MOV AX,0x3ecd (1000_4D63 / 0x14D63)
    AX = 0x3ECD;
    CheckExternalEvents(cs7, 0x4D67);
    // PUSH DS (1000_4D66 / 0x14D66)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4D68);
    // PUSH AX (1000_4D67 / 0x14D67)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4D6D);
    // CALLF 0x1000:17bb (1000_4D68 / 0x14D68)
    FarCall(cs7, 0x4D6D, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4D70);
    // ADD SP,0x4 (1000_4D6D / 0x14D6D)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x4D72);
    // SUB AX,AX (1000_4D70 / 0x14D70)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x4D75);
    // MOV word ptr [BP + -0x56],AX (1000_4D72 / 0x14D72)
    UInt16[SS, (ushort)(BP - 0x56)] = AX;
    CheckExternalEvents(cs7, 0x4D78);
    // MOV word ptr [BP + -0x34],AX (1000_4D75 / 0x14D75)
    UInt16[SS, (ushort)(BP - 0x34)] = AX;
    CheckExternalEvents(cs7, 0x4D7B);
    // MOV BX,word ptr [BP + -0x28] (1000_4D78 / 0x14D78)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x4D7F);
    // MOV ES,word ptr [0x5662] (1000_4D7B / 0x14D7B)
    ES = UInt16[DS, 0x5662];
    CheckExternalEvents(cs7, 0x4D85);
    // CMP byte ptr ES:[BX + 0x32ae],0x0 (1000_4D7F / 0x14D7F)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x32AE)], 0x0);
    CheckExternalEvents(cs7, 0x4D87);
    // JNZ 0x1000:4d8a (1000_4D85 / 0x14D85)
    if(!ZeroFlag) {
      goto label_1000_4D8A_14D8A;
    }
    CheckExternalEvents(cs7, 0x4D8A);
    // JMP 0x1000:4e71 (1000_4D87 / 0x14D87)
    goto label_1000_4E71_14E71;
    label_1000_4D8A_14D8A:
    CheckExternalEvents(cs7, 0x4D8E);
    // CMP word ptr [BP + -0x48],0x10 (1000_4D8A / 0x14D8A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x10);
    CheckExternalEvents(cs7, 0x4D90);
    // JL 0x1000:4d96 (1000_4D8E / 0x14D8E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4D96_14D96;
    }
    CheckExternalEvents(cs7, 0x4D94);
    // CMP word ptr [BP + -0x48],0x12 (1000_4D90 / 0x14D90)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x12);
    CheckExternalEvents(cs7, 0x4D96);
    // JLE 0x1000:4d9f (1000_4D94 / 0x14D94)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_4D9F_14D9F;
    }
    label_1000_4D96_14D96:
    CheckExternalEvents(cs7, 0x4D9A);
    // CMP word ptr [BP + -0x48],0xb (1000_4D96 / 0x14D96)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0xB);
    CheckExternalEvents(cs7, 0x4D9C);
    // JZ 0x1000:4d9f (1000_4D9A / 0x14D9A)
    if(ZeroFlag) {
      goto label_1000_4D9F_14D9F;
    }
    CheckExternalEvents(cs7, 0x4D9F);
    // JMP 0x1000:4e71 (1000_4D9C / 0x14D9C)
    goto label_1000_4E71_14E71;
    label_1000_4D9F_14D9F:
    CheckExternalEvents(cs7, 0x4DA3);
    // MOV ES,word ptr [0x5664] (1000_4D9F / 0x14D9F)
    ES = UInt16[DS, 0x5664];
    CheckExternalEvents(cs7, 0x4DA9);
    // CMP byte ptr ES:[BX + 0x3750],0x10 (1000_4DA3 / 0x14DA3)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3750)], 0x10);
    CheckExternalEvents(cs7, 0x4DAB);
    // JNC 0x1000:4dae (1000_4DA9 / 0x14DA9)
    if(!CarryFlag) {
      goto label_1000_4DAE_14DAE;
    }
    CheckExternalEvents(cs7, 0x4DAE);
    // JMP 0x1000:4e71 (1000_4DAB / 0x14DAB)
    goto label_1000_4E71_14E71;
    label_1000_4DAE_14DAE:
    CheckExternalEvents(cs7, 0x4DB4);
    // CMP byte ptr ES:[BX + 0x3750],0x3f (1000_4DAE / 0x14DAE)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3750)], 0x3F);
    CheckExternalEvents(cs7, 0x4DB6);
    // JBE 0x1000:4db9 (1000_4DB4 / 0x14DB4)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4DB9_14DB9;
    }
    CheckExternalEvents(cs7, 0x4DB9);
    // JMP 0x1000:4e71 (1000_4DB6 / 0x14DB6)
    goto label_1000_4E71_14E71;
    label_1000_4DB9_14DB9:
    CheckExternalEvents(cs7, 0x4DBB);
    // SUB AX,AX (1000_4DB9 / 0x14DB9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x4DBC);
    // PUSH AX (1000_4DBB / 0x14DBB)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4DBF);
    // MOV AX,0xffff (1000_4DBC / 0x14DBC)
    AX = 0xFFFF;
    CheckExternalEvents(cs7, 0x4DC0);
    // PUSH AX (1000_4DBF / 0x14DBF)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4DC1);
    // PUSH BX (1000_4DC0 / 0x14DC0)
    Stack.Push16(BX);
    CheckExternalEvents(cs7, 0x4DC2);
    // PUSH CS (1000_4DC1 / 0x14DC1)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x4DC5);
    // CALL 0x1000:63c6 (1000_4DC2 / 0x14DC2)
    NearCall(cs7, 0x4DC5, ghidra_guess_1000_63C6_163C6);
    CheckExternalEvents(cs7, 0x4DC8);
    // ADD SP,0x6 (1000_4DC5 / 0x14DC5)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs7, 0x4DCB);
    // JMP 0x1000:4e71 (1000_4DC8 / 0x14DC8)
    goto label_1000_4E71_14E71;
    label_1000_4DCB_14DCB:
    CheckExternalEvents(cs7, 0x4DCE);
    // MOV AX,0x3ed6 (1000_4DCB / 0x14DCB)
    AX = 0x3ED6;
    CheckExternalEvents(cs7, 0x4DCF);
    // PUSH DS (1000_4DCE / 0x14DCE)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4DD0);
    // PUSH AX (1000_4DCF / 0x14DCF)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4DD5);
    // CALLF 0x1000:17bb (1000_4DD0 / 0x14DD0)
    FarCall(cs7, 0x4DD5, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4DD8);
    // ADD SP,0x4 (1000_4DD5 / 0x14DD5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x4DDB);
    // JMP 0x1000:4e71 (1000_4DD8 / 0x14DD8)
    goto label_1000_4E71_14E71;
    label_1000_4DDB_14DDB:
    CheckExternalEvents(cs7, 0x4DDE);
    // MOV AX,0x1 (1000_4DDB / 0x14DDB)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x4DE1);
    // MOV word ptr [BP + -0x56],AX (1000_4DDE / 0x14DDE)
    UInt16[SS, (ushort)(BP - 0x56)] = AX;
    CheckExternalEvents(cs7, 0x4DE4);
    // MOV word ptr [BP + -0x6],AX (1000_4DE1 / 0x14DE1)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x4DE7);
    // MOV AX,0x11 (1000_4DE4 / 0x14DE4)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4DEA);
    // IMUL word ptr [BP + -0xc] (1000_4DE7 / 0x14DE7)
    int resImul1000_4DE7 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4DE7);
    DX = (ushort)(resImul1000_4DE7 >> 16);
    CheckExternalEvents(cs7, 0x4DEC);
    // MOV BX,AX (1000_4DEA / 0x14DEA)
    BX = AX;
    CheckExternalEvents(cs7, 0x4DF0);
    // MOV ES,word ptr [0x5648] (1000_4DEC / 0x14DEC)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4DF5);
    // MOV AL,byte ptr ES:[BX + 0xc622] (1000_4DF0 / 0x14DF0)
    AL = UInt8[ES, (ushort)(BX + 0xC622)];
    CheckExternalEvents(cs7, 0x4DF8);
    // MOV byte ptr [BP + -0x80],AL (1000_4DF5 / 0x14DF5)
    UInt8[SS, (ushort)(BP - 0x80)] = AL;
    CheckExternalEvents(cs7, 0x4DFA);
    // OR AL,AL (1000_4DF8 / 0x14DF8)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs7, 0x4DFC);
    // JZ 0x1000:4e3c (1000_4DFA / 0x14DFA)
    if(ZeroFlag) {
      goto label_1000_4E3C_14E3C;
    }
    CheckExternalEvents(cs7, 0x4DFD);
    // CBW  (1000_4DFC / 0x14DFC)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4E00);
    // MOV CX,word ptr [BP + -0x7c] (1000_4DFD / 0x14DFD)
    CX = UInt16[SS, (ushort)(BP - 0x7C)];
    CheckExternalEvents(cs7, 0x4E02);
    // SAR CX,0x1 (1000_4E00 / 0x14E00)
    CX = Alu16.Sar(CX, 0x1);
    CheckExternalEvents(cs7, 0x4E04);
    // CMP AX,CX (1000_4E02 / 0x14E02)
    Alu16.Sub(AX, CX);
    CheckExternalEvents(cs7, 0x4E06);
    // JL 0x1000:4e1d (1000_4E04 / 0x14E04)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4E1D_14E1D;
    }
    CheckExternalEvents(cs7, 0x4E09);
    // SAR word ptr [BP + -0x7c],0x1 (1000_4E06 / 0x14E06)
    UInt16[SS, (ushort)(BP - 0x7C)] = Alu16.Sar(UInt16[SS, (ushort)(BP - 0x7C)], 0x1);
    CheckExternalEvents(cs7, 0x4E0C);
    // MOV AL,byte ptr [BP + -0x7c] (1000_4E09 / 0x14E09)
    AL = UInt8[SS, (ushort)(BP - 0x7C)];
    CheckExternalEvents(cs7, 0x4E0E);
    // MOV CX,AX (1000_4E0C / 0x14E0C)
    CX = AX;
    CheckExternalEvents(cs7, 0x4E11);
    // MOV AX,0x11 (1000_4E0E / 0x14E0E)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E14);
    // IMUL word ptr [BP + -0xc] (1000_4E11 / 0x14E11)
    int resImul1000_4E11 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E11);
    DX = (ushort)(resImul1000_4E11 >> 16);
    CheckExternalEvents(cs7, 0x4E16);
    // MOV BX,AX (1000_4E14 / 0x14E14)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E1B);
    // SUB byte ptr ES:[BX + 0xc622],CL (1000_4E16 / 0x14E16)
    // UInt8[ES, (ushort)(BX + 0xC622)] -= CL;
    UInt8[ES, (ushort)(BX + 0xC622)] = Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC622)], CL);
    CheckExternalEvents(cs7, 0x4E1D);
    // JMP 0x1000:4e3c (1000_4E1B / 0x14E1B)
    goto label_1000_4E3C_14E3C;
    label_1000_4E1D_14E1D:
    CheckExternalEvents(cs7, 0x4E20);
    // MOV AX,0x11 (1000_4E1D / 0x14E1D)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E23);
    // IMUL word ptr [BP + -0xc] (1000_4E20 / 0x14E20)
    int resImul1000_4E20 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E20);
    DX = (ushort)(resImul1000_4E20 >> 16);
    CheckExternalEvents(cs7, 0x4E25);
    // MOV BX,AX (1000_4E23 / 0x14E23)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E2A);
    // MOV AL,byte ptr ES:[BX + 0xc622] (1000_4E25 / 0x14E25)
    AL = UInt8[ES, (ushort)(BX + 0xC622)];
    CheckExternalEvents(cs7, 0x4E2B);
    // CBW  (1000_4E2A / 0x14E2A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4E2E);
    // SUB word ptr [BP + -0x7c],AX (1000_4E2B / 0x14E2B)
    // UInt16[SS, (ushort)(BP - 0x7C)] -= AX;
    UInt16[SS, (ushort)(BP - 0x7C)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x7C)], AX);
    CheckExternalEvents(cs7, 0x4E31);
    // MOV AX,0x11 (1000_4E2E / 0x14E2E)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E34);
    // IMUL word ptr [BP + -0xc] (1000_4E31 / 0x14E31)
    int resImul1000_4E31 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E31);
    DX = (ushort)(resImul1000_4E31 >> 16);
    CheckExternalEvents(cs7, 0x4E36);
    // MOV BX,AX (1000_4E34 / 0x14E34)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E3C);
    // MOV byte ptr ES:[BX + 0xc622],0x0 (1000_4E36 / 0x14E36)
    UInt8[ES, (ushort)(BX + 0xC622)] = 0x0;
    label_1000_4E3C_14E3C:
    CheckExternalEvents(cs7, 0x4E3F);
    // MOV AX,0x11 (1000_4E3C / 0x14E3C)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E42);
    // IMUL word ptr [BP + -0xc] (1000_4E3F / 0x14E3F)
    int resImul1000_4E3F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E3F);
    DX = (ushort)(resImul1000_4E3F >> 16);
    CheckExternalEvents(cs7, 0x4E44);
    // MOV BX,AX (1000_4E42 / 0x14E42)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E49);
    // MOV AL,byte ptr ES:[BX + 0xc623] (1000_4E44 / 0x14E44)
    AL = UInt8[ES, (ushort)(BX + 0xC623)];
    CheckExternalEvents(cs7, 0x4E4A);
    // CBW  (1000_4E49 / 0x14E49)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4E4D);
    // CMP AX,word ptr [BP + -0x7c] (1000_4E4A / 0x14E4A)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x7C)]);
    CheckExternalEvents(cs7, 0x4E4F);
    // JG 0x1000:4e5f (1000_4E4D / 0x14E4D)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_4E5F_14E5F;
    }
    CheckExternalEvents(cs7, 0x4E52);
    // MOV AX,0x11 (1000_4E4F / 0x14E4F)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E55);
    // IMUL word ptr [BP + -0xc] (1000_4E52 / 0x14E52)
    int resImul1000_4E52 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E52);
    DX = (ushort)(resImul1000_4E52 >> 16);
    CheckExternalEvents(cs7, 0x4E57);
    // MOV BX,AX (1000_4E55 / 0x14E55)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E5D);
    // MOV byte ptr ES:[BX + 0xc623],0x0 (1000_4E57 / 0x14E57)
    UInt8[ES, (ushort)(BX + 0xC623)] = 0x0;
    CheckExternalEvents(cs7, 0x4E5F);
    // JMP 0x1000:4e71 (1000_4E5D / 0x14E5D)
    goto label_1000_4E71_14E71;
    label_1000_4E5F_14E5F:
    CheckExternalEvents(cs7, 0x4E62);
    // MOV AL,byte ptr [BP + -0x7c] (1000_4E5F / 0x14E5F)
    AL = UInt8[SS, (ushort)(BP - 0x7C)];
    CheckExternalEvents(cs7, 0x4E64);
    // MOV CX,AX (1000_4E62 / 0x14E62)
    CX = AX;
    CheckExternalEvents(cs7, 0x4E67);
    // MOV AX,0x11 (1000_4E64 / 0x14E64)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E6A);
    // IMUL word ptr [BP + -0xc] (1000_4E67 / 0x14E67)
    int resImul1000_4E67 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E67);
    DX = (ushort)(resImul1000_4E67 >> 16);
    CheckExternalEvents(cs7, 0x4E6C);
    // MOV BX,AX (1000_4E6A / 0x14E6A)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E71);
    // SUB byte ptr ES:[BX + 0xc623],CL (1000_4E6C / 0x14E6C)
    // UInt8[ES, (ushort)(BX + 0xC623)] -= CL;
    UInt8[ES, (ushort)(BX + 0xC623)] = Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC623)], CL);
    label_1000_4E71_14E71:
    CheckExternalEvents(cs7, 0x4E74);
    // MOV AX,word ptr [BP + -0x34] (1000_4E71 / 0x14E71)
    AX = UInt16[SS, (ushort)(BP - 0x34)];
    CheckExternalEvents(cs7, 0x4E77);
    // DEC word ptr [BP + -0x34] (1000_4E74 / 0x14E74)
    UInt16[SS, (ushort)(BP - 0x34)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x34)]);
    CheckExternalEvents(cs7, 0x4E79);
    // OR AX,AX (1000_4E77 / 0x14E77)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x4E7B);
    // JZ 0x1000:4e7e (1000_4E79 / 0x14E79)
    if(ZeroFlag) {
      goto label_1000_4E7E_14E7E;
    }
    CheckExternalEvents(cs7, 0x4E7E);
    // JMP 0x1000:4ddb (1000_4E7B / 0x14E7B)
    goto label_1000_4DDB_14DDB;
    label_1000_4E7E_14E7E:
    CheckExternalEvents(cs7, 0x4E81);
    // MOV AX,0x11 (1000_4E7E / 0x14E7E)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4E84);
    // IMUL word ptr [BP + -0xc] (1000_4E81 / 0x14E81)
    int resImul1000_4E81 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_4E81);
    DX = (ushort)(resImul1000_4E81 >> 16);
    CheckExternalEvents(cs7, 0x4E86);
    // MOV BX,AX (1000_4E84 / 0x14E84)
    BX = AX;
    CheckExternalEvents(cs7, 0x4E8A);
    // MOV ES,word ptr [0x5648] (1000_4E86 / 0x14E86)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4E90);
    // CMP byte ptr ES:[BX + 0xc623],0x0 (1000_4E8A / 0x14E8A)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC623)], 0x0);
    CheckExternalEvents(cs7, 0x4E92);
    // JZ 0x1000:4e95 (1000_4E90 / 0x14E90)
    if(ZeroFlag) {
      goto label_1000_4E95_14E95;
    }
    CheckExternalEvents(cs7, 0x4E95);
    // JMP 0x1000:5253 (1000_4E92 / 0x14E92)
    goto label_1000_5253_15253;
    label_1000_4E95_14E95:
    CheckExternalEvents(cs7, 0x4E9A);
    // MOV word ptr [BP + -0x2c],0x1 (1000_4E95 / 0x14E95)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x1;
    CheckExternalEvents(cs7, 0x4E9D);
    // JMP 0x1000:5253 (1000_4E9A / 0x14E9A)
    goto label_1000_5253_15253;
    label_1000_4E9D_14E9D:
    CheckExternalEvents(cs7, 0x4EA0);
    // MOV BX,word ptr [BP + -0x28] (1000_4E9D / 0x14E9D)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x4EA4);
    // MOV ES,word ptr [0x5662] (1000_4EA0 / 0x14EA0)
    ES = UInt16[DS, 0x5662];
    CheckExternalEvents(cs7, 0x4EA9);
    // MOV AL,byte ptr ES:[BX + 0x32ae] (1000_4EA4 / 0x14EA4)
    AL = UInt8[ES, (ushort)(BX + 0x32AE)];
    CheckExternalEvents(cs7, 0x4EAA);
    // CBW  (1000_4EA9 / 0x14EA9)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4EAC);
    // MOV CL,0x3 (1000_4EAA / 0x14EAA)
    CL = 0x3;
    CheckExternalEvents(cs7, 0x4EAE);
    // SAR AX,CL (1000_4EAC / 0x14EAC)
    AX = Alu16.Sar(AX, CL);
    CheckExternalEvents(cs7, 0x4EB1);
    // ADD word ptr [BP + -0x30],AX (1000_4EAE / 0x14EAE)
    // UInt16[SS, (ushort)(BP - 0x30)] += AX;
    UInt16[SS, (ushort)(BP - 0x30)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x30)], AX);
    CheckExternalEvents(cs7, 0x4EB3);
    // MOV AX,BX (1000_4EB1 / 0x14EB1)
    AX = BX;
    CheckExternalEvents(cs7, 0x4EB6);
    // MOV word ptr [BP + -0xc],AX (1000_4EB3 / 0x14EB3)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x4EB9);
    // CMP AX,0xc (1000_4EB6 / 0x14EB6)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs7, 0x4EBB);
    // JL 0x1000:4ebf (1000_4EB9 / 0x14EB9)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4EBF_14EBF;
    }
    CheckExternalEvents(cs7, 0x4EBF);
    // SUB word ptr [BP + -0xc],0x8 (1000_4EBB / 0x14EBB)
    // UInt16[SS, (ushort)(BP - 0xC)] -= 0x8;
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x8);
    label_1000_4EBF_14EBF:
    CheckExternalEvents(cs7, 0x4EC3);
    // MOV ES,word ptr [0x563c] (1000_4EBF / 0x14EBF)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs7, 0x4EC8);
    // MOV AL,byte ptr ES:[BX + 0x396c] (1000_4EC3 / 0x14EC3)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs7, 0x4EC9);
    // CBW  (1000_4EC8 / 0x14EC8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4ECC);
    // MOV word ptr [BP + -0x46],AX (1000_4EC9 / 0x14EC9)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs7, 0x4ECF);
    // CMP AX,0xffff (1000_4ECC / 0x14ECC)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs7, 0x4ED1);
    // JNZ 0x1000:4ede (1000_4ECF / 0x14ECF)
    if(!ZeroFlag) {
      goto label_1000_4EDE_14EDE;
    }
    CheckExternalEvents(cs7, 0x4ED5);
    // MOV ES,word ptr [0x5666] (1000_4ED1 / 0x14ED1)
    ES = UInt16[DS, 0x5666];
    CheckExternalEvents(cs7, 0x4EDA);
    // MOV AL,byte ptr ES:[BX + 0x45b6] (1000_4ED5 / 0x14ED5)
    AL = UInt8[ES, (ushort)(BX + 0x45B6)];
    CheckExternalEvents(cs7, 0x4EDB);
    // CBW  (1000_4EDA / 0x14EDA)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4EDE);
    // MOV word ptr [BP + -0x46],AX (1000_4EDB / 0x14EDB)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    label_1000_4EDE_14EDE:
    CheckExternalEvents(cs7, 0x4EE1);
    // MOV BX,word ptr [BP + -0x46] (1000_4EDE / 0x14EDE)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs7, 0x4EE4);
    // SUB BX,word ptr [BP + -0x60] (1000_4EE1 / 0x14EE1)
    // BX -= UInt16[SS, (ushort)(BP - 0x60)];
    BX = Alu16.Sub(BX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x4EE8);
    // MOV ES,word ptr [0x5668] (1000_4EE4 / 0x14EE4)
    ES = UInt16[DS, 0x5668];
    CheckExternalEvents(cs7, 0x4EED);
    // MOV AL,byte ptr ES:[BX + 0x2d11] (1000_4EE8 / 0x14EE8)
    AL = UInt8[ES, (ushort)(BX + 0x2D11)];
    CheckExternalEvents(cs7, 0x4EEE);
    // CBW  (1000_4EED / 0x14EED)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x4EF1);
    // MOV word ptr [BP + -0x54],AX (1000_4EEE / 0x14EEE)
    UInt16[SS, (ushort)(BP - 0x54)] = AX;
    CheckExternalEvents(cs7, 0x4EF6);
    // CALLF 0x0000:30dd (1000_4EF1 / 0x14EF1)
    FarCall(cs7, 0x4EF6, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs7, 0x4EF8);
    // MOV CX,AX (1000_4EF6 / 0x14EF6)
    CX = AX;
    CheckExternalEvents(cs7, 0x4EFB);
    // MOV AX,0xb (1000_4EF8 / 0x14EF8)
    AX = 0xB;
    CheckExternalEvents(cs7, 0x4EFE);
    // IMUL word ptr [BP + -0x54] (1000_4EFB / 0x14EFB)
    int resImul1000_4EFB = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x54)]);
    AX = (ushort)(resImul1000_4EFB);
    DX = (ushort)(resImul1000_4EFB >> 16);
    CheckExternalEvents(cs7, 0x4F00);
    // MOV BX,AX (1000_4EFE / 0x14EFE)
    BX = AX;
    CheckExternalEvents(cs7, 0x4F02);
    // ADD BX,CX (1000_4F00 / 0x14F00)
    // BX += CX;
    BX = Alu16.Add(BX, CX);
    CheckExternalEvents(cs7, 0x4F06);
    // MOV ES,word ptr [0x566a] (1000_4F02 / 0x14F02)
    ES = UInt16[DS, 0x566A];
    CheckExternalEvents(cs7, 0x4F0B);
    // MOV AL,byte ptr ES:[BX + 0x2e40] (1000_4F06 / 0x14F06)
    AL = UInt8[ES, (ushort)(BX + 0x2E40)];
    CheckExternalEvents(cs7, 0x4F0D);
    // SUB AH,AH (1000_4F0B / 0x14F0B)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x4F10);
    // MOV word ptr [BP + -0x60],AX (1000_4F0D / 0x14F0D)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs7, 0x4F14);
    // CMP word ptr [BP + -0x48],0x20 (1000_4F10 / 0x14F10)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x20);
    CheckExternalEvents(cs7, 0x4F16);
    // JNZ 0x1000:4f71 (1000_4F14 / 0x14F14)
    if(!ZeroFlag) {
      goto label_1000_4F71_14F71;
    }
    CheckExternalEvents(cs7, 0x4F1A);
    // CMP word ptr [BP + -0x2],0x4 (1000_4F16 / 0x14F16)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x4F1C);
    // JGE 0x1000:4f2f (1000_4F1A / 0x14F1A)
    if(SignFlag == OverflowFlag) {
      goto label_1000_4F2F_14F2F;
    }
    CheckExternalEvents(cs7, 0x4F1F);
    // MOV AX,0x7d (1000_4F1C / 0x14F1C)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x4F22);
    // IMUL word ptr [BP + -0x2] (1000_4F1F / 0x14F1F)
    int resImul1000_4F1F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_4F1F);
    DX = (ushort)(resImul1000_4F1F >> 16);
    CheckExternalEvents(cs7, 0x4F24);
    // MOV BX,AX (1000_4F22 / 0x14F22)
    BX = AX;
    CheckExternalEvents(cs7, 0x4F28);
    // MOV ES,word ptr [0x5648] (1000_4F24 / 0x14F24)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4F2D);
    // MOV AL,byte ptr ES:[BX + 0xc734] (1000_4F28 / 0x14F28)
    AL = UInt8[ES, (ushort)(BX + 0xC734)];
    CheckExternalEvents(cs7, 0x4F2F);
    // JMP 0x1000:4f40 (1000_4F2D / 0x14F2D)
    goto label_1000_4F40_14F40;
    label_1000_4F2F_14F2F:
    CheckExternalEvents(cs7, 0x4F32);
    // MOV AX,0x7d (1000_4F2F / 0x14F2F)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x4F35);
    // IMUL word ptr [BP + -0x2] (1000_4F32 / 0x14F32)
    int resImul1000_4F32 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_4F32);
    DX = (ushort)(resImul1000_4F32 >> 16);
    CheckExternalEvents(cs7, 0x4F37);
    // MOV BX,AX (1000_4F35 / 0x14F35)
    BX = AX;
    CheckExternalEvents(cs7, 0x4F3B);
    // MOV ES,word ptr [0x5648] (1000_4F37 / 0x14F37)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x4F40);
    // MOV AL,byte ptr ES:[BX + 0xc34c] (1000_4F3B / 0x14F3B)
    AL = UInt8[ES, (ushort)(BX + 0xC34C)];
    label_1000_4F40_14F40:
    CheckExternalEvents(cs7, 0x4F42);
    // SUB AH,AH (1000_4F40 / 0x14F40)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x4F45);
    // MOV word ptr [BP + -0x7c],AX (1000_4F42 / 0x14F42)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    CheckExternalEvents(cs7, 0x4F48);
    // MOV CX,0x5 (1000_4F45 / 0x14F45)
    CX = 0x5;
    CheckExternalEvents(cs7, 0x4F49);
    // CWD  (1000_4F48 / 0x14F48)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs7, 0x4F4B);
    // IDIV CX (1000_4F49 / 0x14F49)
    int op1IDiv1000_4F49 = (int)(DX << 16 | AX);
    short op2IDiv1000_4F49 = (short)CX;
    short? resIDiv1000_4F49 = Alu16.Idiv(op1IDiv1000_4F49, op2IDiv1000_4F49);
    if(resIDiv1000_4F49 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIDiv1000_4F49.Value;
    DX = (ushort)(op1IDiv1000_4F49 % op2IDiv1000_4F49);
    CheckExternalEvents(cs7, 0x4F4E);
    // MOV word ptr [BP + -0x7c],AX (1000_4F4B / 0x14F4B)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    CheckExternalEvents(cs7, 0x4F52);
    // MOV ES,word ptr [0x5652] (1000_4F4E / 0x14F4E)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4F55);
    // MOV AL,byte ptr [BP + -0x7c] (1000_4F52 / 0x14F52)
    AL = UInt8[SS, (ushort)(BP - 0x7C)];
    CheckExternalEvents(cs7, 0x4F59);
    // MOV ES:[0x3103],AL (1000_4F55 / 0x14F55)
    UInt8[ES, 0x3103] = AL;
    CheckExternalEvents(cs7, 0x4F5E);
    // CALLF 0x1000:aab0 (1000_4F59 / 0x14F59)
    FarCall(cs7, 0x4F5E, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs7, 0x4F60);
    // MOV BX,AX (1000_4F5E / 0x14F5E)
    BX = AX;
    CheckExternalEvents(cs7, 0x4F63);
    // AND BX,0x8 (1000_4F60 / 0x14F60)
    // BX &= 0x8;
    BX = Alu16.And(BX, 0x8);
    CheckExternalEvents(cs7, 0x4F67);
    // MOV ES,word ptr [0x566a] (1000_4F63 / 0x14F63)
    ES = UInt16[DS, 0x566A];
    CheckExternalEvents(cs7, 0x4F6C);
    // MOV AL,byte ptr ES:[BX + 0x2e43] (1000_4F67 / 0x14F67)
    AL = UInt8[ES, (ushort)(BX + 0x2E43)];
    CheckExternalEvents(cs7, 0x4F6E);
    // SUB AH,AH (1000_4F6C / 0x14F6C)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x4F71);
    // MOV word ptr [BP + -0x60],AX (1000_4F6E / 0x14F6E)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    label_1000_4F71_14F71:
    CheckExternalEvents(cs7, 0x4F74);
    // MOV AX,0x11 (1000_4F71 / 0x14F71)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x4F77);
    // IMUL word ptr [BP + -0x48] (1000_4F74 / 0x14F74)
    int resImul1000_4F74 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x48)]);
    AX = (ushort)(resImul1000_4F74);
    DX = (ushort)(resImul1000_4F74 >> 16);
    CheckExternalEvents(cs7, 0x4F79);
    // MOV SI,AX (1000_4F77 / 0x14F77)
    SI = AX;
    CheckExternalEvents(cs7, 0x4F7D);
    // MOV ES,word ptr [0x5652] (1000_4F79 / 0x14F79)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4F83);
    // TEST byte ptr ES:[SI + 0x2ee4],0x80 (1000_4F7D / 0x14F7D)
    Alu8.And(UInt8[ES, (ushort)(SI + 0x2EE4)], 0x80);
    CheckExternalEvents(cs7, 0x4F85);
    // JZ 0x1000:4f88 (1000_4F83 / 0x14F83)
    if(ZeroFlag) {
      goto label_1000_4F88_14F88;
    }
    CheckExternalEvents(cs7, 0x4F88);
    // JMP 0x1000:5253 (1000_4F85 / 0x14F85)
    goto label_1000_5253_15253;
    label_1000_4F88_14F88:
    CheckExternalEvents(cs7, 0x4F8D);
    // MOV AL,byte ptr ES:[SI + 0x2ee3] (1000_4F88 / 0x14F88)
    AL = UInt8[ES, (ushort)(SI + 0x2EE3)];
    CheckExternalEvents(cs7, 0x4F8F);
    // SUB AH,AH (1000_4F8D / 0x14F8D)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x4F92);
    // MOV word ptr [BP + -0x7c],AX (1000_4F8F / 0x14F8F)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    CheckExternalEvents(cs7, 0x4F98);
    // CMP byte ptr ES:[SI + 0x2ee4],0x1 (1000_4F92 / 0x14F92)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0x2EE4)], 0x1);
    CheckExternalEvents(cs7, 0x4F9A);
    // JBE 0x1000:4fc2 (1000_4F98 / 0x14F98)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_4FC2_14FC2;
    }
    CheckExternalEvents(cs7, 0x4F9F);
    // CALLF 0x0000:30dd (1000_4F9A / 0x14F9A)
    FarCall(cs7, 0x4F9F, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs7, 0x4FA2);
    // MOV CX,0x7 (1000_4F9F / 0x14F9F)
    CX = 0x7;
    CheckExternalEvents(cs7, 0x4FA4);
    // IMUL CX (1000_4FA2 / 0x14FA2)
    int resImul1000_4FA2 = Alu16.Imul((short)AX, (short)CX);
    AX = (ushort)(resImul1000_4FA2);
    DX = (ushort)(resImul1000_4FA2 >> 16);
    CheckExternalEvents(cs7, 0x4FA8);
    // MOV ES,word ptr [0x5652] (1000_4FA4 / 0x14FA4)
    ES = UInt16[DS, 0x5652];
    CheckExternalEvents(cs7, 0x4FAD);
    // MOV BL,byte ptr ES:[SI + 0x2ee4] (1000_4FA8 / 0x14FA8)
    BL = UInt8[ES, (ushort)(SI + 0x2EE4)];
    CheckExternalEvents(cs7, 0x4FAF);
    // SUB BH,BH (1000_4FAD / 0x14FAD)
    BH -= BH;
    CheckExternalEvents(cs7, 0x4FB1);
    // ADD BX,AX (1000_4FAF / 0x14FAF)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs7, 0x4FB5);
    // MOV ES,word ptr [0x566c] (1000_4FB1 / 0x14FB1)
    ES = UInt16[DS, 0x566C];
    CheckExternalEvents(cs7, 0x4FBA);
    // MOV AL,byte ptr ES:[BX + 0x2e5e] (1000_4FB5 / 0x14FB5)
    AL = UInt8[ES, (ushort)(BX + 0x2E5E)];
    CheckExternalEvents(cs7, 0x4FBC);
    // SUB AH,AH (1000_4FBA / 0x14FBA)
    AH -= AH;
    CheckExternalEvents(cs7, 0x4FBF);
    // IMUL word ptr [BP + -0x7c] (1000_4FBC / 0x14FBC)
    int resImul1000_4FBC = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x7C)]);
    AX = (ushort)(resImul1000_4FBC);
    DX = (ushort)(resImul1000_4FBC >> 16);
    CheckExternalEvents(cs7, 0x4FC2);
    // MOV word ptr [BP + -0x7c],AX (1000_4FBF / 0x14FBF)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    label_1000_4FC2_14FC2:
    CheckExternalEvents(cs7, 0x4FC7);
    // CALLF 0x0000:30dd (1000_4FC2 / 0x14FC2)
    FarCall(cs7, 0x4FC7, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs7, 0x4FCA);
    // CMP AX,word ptr [BP + -0x30] (1000_4FC7 / 0x14FC7)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs7, 0x4FCC);
    // JL 0x1000:4fcf (1000_4FCA / 0x14FCA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4FCF_14FCF;
    }
    CheckExternalEvents(cs7, 0x4FCF);
    // JMP 0x1000:50a3 (1000_4FCC / 0x14FCC)
    goto label_1000_50A3_150A3;
    label_1000_4FCF_14FCF:
    CheckExternalEvents(cs7, 0x4FD2);
    // MOV AX,0x3ede (1000_4FCF / 0x14FCF)
    AX = 0x3EDE;
    CheckExternalEvents(cs7, 0x4FD3);
    // PUSH DS (1000_4FD2 / 0x14FD2)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x4FD4);
    // PUSH AX (1000_4FD3 / 0x14FD3)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x4FD9);
    // CALLF 0x1000:17bb (1000_4FD4 / 0x14FD4)
    FarCall(cs7, 0x4FD9, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x4FDC);
    // ADD SP,0x4 (1000_4FD9 / 0x14FD9)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x4FDE);
    // SUB AX,AX (1000_4FDC / 0x14FDC)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x4FE1);
    // MOV word ptr [BP + -0x56],AX (1000_4FDE / 0x14FDE)
    UInt16[SS, (ushort)(BP - 0x56)] = AX;
    CheckExternalEvents(cs7, 0x4FE4);
    // MOV word ptr [BP + -0x7c],AX (1000_4FE1 / 0x14FE1)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    CheckExternalEvents(cs7, 0x4FE7);
    // MOV BX,word ptr [BP + -0x28] (1000_4FE4 / 0x14FE4)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x4FEB);
    // MOV ES,word ptr [0x5662] (1000_4FE7 / 0x14FE7)
    ES = UInt16[DS, 0x5662];
    CheckExternalEvents(cs7, 0x4FF1);
    // CMP byte ptr ES:[BX + 0x32ae],0x0 (1000_4FEB / 0x14FEB)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x32AE)], 0x0);
    CheckExternalEvents(cs7, 0x4FF3);
    // JZ 0x1000:5028 (1000_4FF1 / 0x14FF1)
    if(ZeroFlag) {
      goto label_1000_5028_15028;
    }
    CheckExternalEvents(cs7, 0x4FF7);
    // CMP word ptr [BP + -0x48],0x10 (1000_4FF3 / 0x14FF3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x10);
    CheckExternalEvents(cs7, 0x4FF9);
    // JL 0x1000:4fff (1000_4FF7 / 0x14FF7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_4FFF_14FFF;
    }
    CheckExternalEvents(cs7, 0x4FFD);
    // CMP word ptr [BP + -0x48],0x12 (1000_4FF9 / 0x14FF9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0x12);
    CheckExternalEvents(cs7, 0x4FFF);
    // JLE 0x1000:5005 (1000_4FFD / 0x14FFD)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_5005_15005;
    }
    label_1000_4FFF_14FFF:
    CheckExternalEvents(cs7, 0x5003);
    // CMP word ptr [BP + -0x48],0xb (1000_4FFF / 0x14FFF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0xB);
    CheckExternalEvents(cs7, 0x5005);
    // JNZ 0x1000:5028 (1000_5003 / 0x15003)
    if(!ZeroFlag) {
      goto label_1000_5028_15028;
    }
    label_1000_5005_15005:
    CheckExternalEvents(cs7, 0x5009);
    // MOV ES,word ptr [0x5664] (1000_5005 / 0x15005)
    ES = UInt16[DS, 0x5664];
    CheckExternalEvents(cs7, 0x500F);
    // CMP byte ptr ES:[BX + 0x3750],0x10 (1000_5009 / 0x15009)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3750)], 0x10);
    CheckExternalEvents(cs7, 0x5011);
    // JC 0x1000:5028 (1000_500F / 0x1500F)
    if(CarryFlag) {
      goto label_1000_5028_15028;
    }
    CheckExternalEvents(cs7, 0x5017);
    // CMP byte ptr ES:[BX + 0x3750],0x3f (1000_5011 / 0x15011)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3750)], 0x3F);
    CheckExternalEvents(cs7, 0x5019);
    // JA 0x1000:5028 (1000_5017 / 0x15017)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_5028_15028;
    }
    CheckExternalEvents(cs7, 0x501C);
    // MOV AX,0xffff (1000_5019 / 0x15019)
    AX = 0xFFFF;
    CheckExternalEvents(cs7, 0x501D);
    // PUSH AX (1000_501C / 0x1501C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x501F);
    // SUB AX,AX (1000_501D / 0x1501D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x5020);
    // PUSH AX (1000_501F / 0x1501F)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x5021);
    // PUSH BX (1000_5020 / 0x15020)
    Stack.Push16(BX);
    CheckExternalEvents(cs7, 0x5022);
    // PUSH CS (1000_5021 / 0x15021)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x5025);
    // CALL 0x1000:63c6 (1000_5022 / 0x15022)
    NearCall(cs7, 0x5025, ghidra_guess_1000_63C6_163C6);
    CheckExternalEvents(cs7, 0x5028);
    // ADD SP,0x6 (1000_5025 / 0x15025)
    SP += 0x6;
    label_1000_5028_15028:
    CheckExternalEvents(cs7, 0x502C);
    // CMP word ptr [BP + -0x28],0x4 (1000_5028 / 0x15028)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x4);
    CheckExternalEvents(cs7, 0x502E);
    // JL 0x1000:5040 (1000_502C / 0x1502C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5040_15040;
    }
    CheckExternalEvents(cs7, 0x5032);
    // CMP word ptr [BP + -0x28],0xc (1000_502E / 0x1502E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0xC);
    CheckExternalEvents(cs7, 0x5034);
    // JGE 0x1000:5037 (1000_5032 / 0x15032)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5037_15037;
    }
    CheckExternalEvents(cs7, 0x5037);
    // JMP 0x1000:524a (1000_5034 / 0x15034)
    goto label_1000_524A_1524A;
    label_1000_5037_15037:
    CheckExternalEvents(cs7, 0x503B);
    // CMP word ptr [BP + -0x28],0x10 (1000_5037 / 0x15037)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x10);
    CheckExternalEvents(cs7, 0x503D);
    // JL 0x1000:5040 (1000_503B / 0x1503B)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5040_15040;
    }
    CheckExternalEvents(cs7, 0x5040);
    // JMP 0x1000:524a (1000_503D / 0x1503D)
    goto label_1000_524A_1524A;
    label_1000_5040_15040:
    CheckExternalEvents(cs7, 0x5043);
    // MOV BX,word ptr [BP + -0x28] (1000_5040 / 0x15040)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x5047);
    // MOV ES,word ptr [0x566e] (1000_5043 / 0x15043)
    ES = UInt16[DS, 0x566E];
    CheckExternalEvents(cs7, 0x504C);
    // MOV AL,byte ptr ES:[BX + 0x45ce] (1000_5047 / 0x15047)
    AL = UInt8[ES, (ushort)(BX + 0x45CE)];
    CheckExternalEvents(cs7, 0x504E);
    // SUB AH,AH (1000_504C / 0x1504C)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x5052);
    // MOV ES,word ptr [0x5670] (1000_504E / 0x1504E)
    ES = UInt16[DS, 0x5670];
    CheckExternalEvents(cs7, 0x5057);
    // CMP AX,word ptr ES:[0x150] (1000_5052 / 0x15052)
    Alu16.Sub(AX, UInt16[ES, 0x150]);
    CheckExternalEvents(cs7, 0x5059);
    // JNC 0x1000:505c (1000_5057 / 0x15057)
    if(!CarryFlag) {
      goto label_1000_505C_1505C;
    }
    CheckExternalEvents(cs7, 0x505C);
    // JMP 0x1000:524a (1000_5059 / 0x15059)
    goto label_1000_524A_1524A;
    label_1000_505C_1505C:
    CheckExternalEvents(cs7, 0x505E);
    // SHL BX,0x1 (1000_505C / 0x1505C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x5062);
    // MOV ES,word ptr [0x5636] (1000_505E / 0x1505E)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x5067);
    // MOV AX,word ptr ES:[BX + 0x4036] (1000_5062 / 0x15062)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs7, 0x506A);
    // MOV BX,word ptr [BP + -0x28] (1000_5067 / 0x15067)
    BX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x506E);
    // MOV ES,word ptr [0x5672] (1000_506A / 0x1506A)
    ES = UInt16[DS, 0x5672];
    CheckExternalEvents(cs7, 0x5073);
    // MOV CL,byte ptr ES:[BX + 0x4554] (1000_506E / 0x1506E)
    CL = UInt8[ES, (ushort)(BX + 0x4554)];
    CheckExternalEvents(cs7, 0x5075);
    // SUB CH,CH (1000_5073 / 0x15073)
    CH -= CH;
    CheckExternalEvents(cs7, 0x5077);
    // SUB AX,CX (1000_5075 / 0x15075)
    AX -= CX;
    CheckExternalEvents(cs7, 0x5078);
    // DEC AX (1000_5077 / 0x15077)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs7, 0x507B);
    // MOV word ptr [BP + -0x18],AX (1000_5078 / 0x15078)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x507F);
    // TEST byte ptr [BP + -0x18],0x80 (1000_507B / 0x1507B)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x18)], 0x80);
    CheckExternalEvents(cs7, 0x5081);
    // JZ 0x1000:5086 (1000_507F / 0x1507F)
    if(ZeroFlag) {
      goto label_1000_5086_15086;
    }
    CheckExternalEvents(cs7, 0x5086);
    // AND word ptr [BP + -0x18],0xf07f (1000_5081 / 0x15081)
    // UInt16[SS, (ushort)(BP - 0x18)] &= 0xF07F;
    UInt16[SS, (ushort)(BP - 0x18)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x18)], 0xF07F);
    label_1000_5086_15086:
    CheckExternalEvents(cs7, 0x5089);
    // PUSH word ptr [BP + -0x18] (1000_5086 / 0x15086)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs7, 0x508B);
    // SHL BX,0x1 (1000_5089 / 0x15089)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x508F);
    // MOV ES,word ptr [0x5638] (1000_508B / 0x1508B)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x5094);
    // PUSH word ptr ES:[BX + 0x4004] (1000_508F / 0x1508F)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4004)]);
    CheckExternalEvents(cs7, 0x5097);
    // MOV AX,0x7f (1000_5094 / 0x15094)
    AX = 0x7F;
    CheckExternalEvents(cs7, 0x5098);
    // PUSH AX (1000_5097 / 0x15097)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x509D);
    // CALLF 0x1000:4279 (1000_5098 / 0x15098)
    FarCall(cs7, 0x509D, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs7, 0x50A0);
    // ADD SP,0x6 (1000_509D / 0x1509D)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs7, 0x50A3);
    // JMP 0x1000:524a (1000_50A0 / 0x150A0)
    goto label_1000_524A_1524A;
    label_1000_50A3_150A3:
    CheckExternalEvents(cs7, 0x50A8);
    // MOV word ptr [BP + -0x56],0x1 (1000_50A3 / 0x150A3)
    UInt16[SS, (ushort)(BP - 0x56)] = 0x1;
    CheckExternalEvents(cs7, 0x50AB);
    // MOV AX,0x3ee7 (1000_50A8 / 0x150A8)
    AX = 0x3EE7;
    CheckExternalEvents(cs7, 0x50AC);
    // PUSH DS (1000_50AB / 0x150AB)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x50AD);
    // PUSH AX (1000_50AC / 0x150AC)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x50B2);
    // CALLF 0x1000:17bb (1000_50AD / 0x150AD)
    FarCall(cs7, 0x50B2, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0x50B5);
    // ADD SP,0x4 (1000_50B2 / 0x150B2)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x50B8);
    // PUSH word ptr [BP + -0x60] (1000_50B5 / 0x150B5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x50BD);
    // CALLF 0x1000:159f (1000_50B8 / 0x150B8)
    FarCall(cs7, 0x50BD, ghidra_guess_1000_159F_1159F);
    CheckExternalEvents(cs7, 0x50C0);
    // ADD SP,0x2 (1000_50BD / 0x150BD)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x50C3);
    // JMP 0x1000:524a (1000_50C0 / 0x150C0)
    goto label_1000_524A_1524A;
    label_1000_50C3_150C3:
    CheckExternalEvents(cs7, 0x50C6);
    // MOV AX,0x7d (1000_50C3 / 0x150C3)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x50C9);
    // IMUL word ptr [BP + -0xc] (1000_50C6 / 0x150C6)
    int resImul1000_50C6 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_50C6);
    DX = (ushort)(resImul1000_50C6 >> 16);
    CheckExternalEvents(cs7, 0x50CB);
    // MOV BX,AX (1000_50C9 / 0x150C9)
    BX = AX;
    CheckExternalEvents(cs7, 0x50CF);
    // MOV ES,word ptr [0x5648] (1000_50CB / 0x150CB)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x50D5);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_50CF / 0x150CF)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs7, 0x50D7);
    // JNZ 0x1000:50da (1000_50D5 / 0x150D5)
    if(!ZeroFlag) {
      goto label_1000_50DA_150DA;
    }
    CheckExternalEvents(cs7, 0x50DA);
    // JMP 0x1000:5253 (1000_50D7 / 0x150D7)
    goto label_1000_5253_15253;
    label_1000_50DA_150DA:
    CheckExternalEvents(cs7, 0x50DE);
    // CMP word ptr [BP + -0x48],0xb (1000_50DA / 0x150DA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x48)], 0xB);
    CheckExternalEvents(cs7, 0x50E0);
    // JNZ 0x1000:50f5 (1000_50DE / 0x150DE)
    if(!ZeroFlag) {
      goto label_1000_50F5_150F5;
    }
    CheckExternalEvents(cs7, 0x50E3);
    // MOV BX,word ptr [BP + -0xc] (1000_50E0 / 0x150E0)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs7, 0x50E7);
    // MOV ES,word ptr [0x5674] (1000_50E3 / 0x150E3)
    ES = UInt16[DS, 0x5674];
    CheckExternalEvents(cs7, 0x50ED);
    // MOV byte ptr ES:[BX + 0xd576],0x3 (1000_50E7 / 0x150E7)
    UInt8[ES, (ushort)(BX + 0xD576)] = 0x3;
    CheckExternalEvents(cs7, 0x50EF);
    // SUB AX,AX (1000_50ED / 0x150ED)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x50F2);
    // MOV word ptr [BP + -0x34],AX (1000_50EF / 0x150EF)
    UInt16[SS, (ushort)(BP - 0x34)] = AX;
    CheckExternalEvents(cs7, 0x50F5);
    // MOV word ptr [BP + -0x7c],AX (1000_50F2 / 0x150F2)
    UInt16[SS, (ushort)(BP - 0x7C)] = AX;
    label_1000_50F5_150F5:
    CheckExternalEvents(cs7, 0x50F8);
    // MOV AX,0x7d (1000_50F5 / 0x150F5)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x50FB);
    // IMUL word ptr [BP + -0xc] (1000_50F8 / 0x150F8)
    int resImul1000_50F8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_50F8);
    DX = (ushort)(resImul1000_50F8 >> 16);
    CheckExternalEvents(cs7, 0x50FD);
    // MOV BX,AX (1000_50FB / 0x150FB)
    BX = AX;
    CheckExternalEvents(cs7, 0x5100);
    // ADD BX,word ptr [BP + -0x60] (1000_50FD / 0x150FD)
    // BX += UInt16[SS, (ushort)(BP - 0x60)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x5104);
    // MOV ES,word ptr [0x5648] (1000_5100 / 0x15100)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x5109);
    // MOV AL,byte ptr ES:[BX + 0xc724] (1000_5104 / 0x15104)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs7, 0x510B);
    // SUB AH,AH (1000_5109 / 0x15109)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x510E);
    // MOV word ptr [BP + -0x52],AX (1000_510B / 0x1510B)
    UInt16[SS, (ushort)(BP - 0x52)] = AX;
    CheckExternalEvents(cs7, 0x5111);
    // CMP word ptr [BP + -0x7c],AX (1000_510E / 0x1510E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x7C)], AX);
    CheckExternalEvents(cs7, 0x5113);
    // JLE 0x1000:5116 (1000_5111 / 0x15111)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_5116_15116;
    }
    CheckExternalEvents(cs7, 0x5116);
    // JMP 0x1000:51c4 (1000_5113 / 0x15113)
    goto label_1000_51C4_151C4;
    label_1000_5116_15116:
    CheckExternalEvents(cs7, 0x5118);
    // JNZ 0x1000:512e (1000_5116 / 0x15116)
    if(!ZeroFlag) {
      goto label_1000_512E_1512E;
    }
    CheckExternalEvents(cs7, 0x511C);
    // CMP word ptr [BP + -0x60],0x1c (1000_5118 / 0x15118)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x1C);
    CheckExternalEvents(cs7, 0x511E);
    // JZ 0x1000:5124 (1000_511C / 0x1511C)
    if(ZeroFlag) {
      goto label_1000_5124_15124;
    }
    CheckExternalEvents(cs7, 0x5122);
    // CMP word ptr [BP + -0x60],0x21 (1000_511E / 0x1511E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x21);
    CheckExternalEvents(cs7, 0x5124);
    // JNZ 0x1000:512e (1000_5122 / 0x15122)
    if(!ZeroFlag) {
      goto label_1000_512E_1512E;
    }
    label_1000_5124_15124:
    CheckExternalEvents(cs7, 0x5128);
    // MOV ES,word ptr [0x5676] (1000_5124 / 0x15124)
    ES = UInt16[DS, 0x5676];
    CheckExternalEvents(cs7, 0x512E);
    // MOV byte ptr ES:[0x3986],0x1 (1000_5128 / 0x15128)
    UInt8[ES, 0x3986] = 0x1;
    label_1000_512E_1512E:
    CheckExternalEvents(cs7, 0x5131);
    // MOV AL,byte ptr [BP + -0x7c] (1000_512E / 0x1512E)
    AL = UInt8[SS, (ushort)(BP - 0x7C)];
    CheckExternalEvents(cs7, 0x5133);
    // MOV CX,AX (1000_5131 / 0x15131)
    CX = AX;
    CheckExternalEvents(cs7, 0x5136);
    // MOV AX,0x7d (1000_5133 / 0x15133)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x5139);
    // IMUL word ptr [BP + -0xc] (1000_5136 / 0x15136)
    int resImul1000_5136 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_5136);
    DX = (ushort)(resImul1000_5136 >> 16);
    CheckExternalEvents(cs7, 0x513B);
    // MOV BX,AX (1000_5139 / 0x15139)
    BX = AX;
    CheckExternalEvents(cs7, 0x513E);
    // ADD BX,word ptr [BP + -0x60] (1000_513B / 0x1513B)
    // BX += UInt16[SS, (ushort)(BP - 0x60)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x5142);
    // MOV ES,word ptr [0x5648] (1000_513E / 0x1513E)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x5147);
    // SUB byte ptr ES:[BX + 0xc724],CL (1000_5142 / 0x15142)
    // UInt8[ES, (ushort)(BX + 0xC724)] -= CL;
    UInt8[ES, (ushort)(BX + 0xC724)] = Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], CL);
    CheckExternalEvents(cs7, 0x514C);
    // MOV word ptr [BP + -0x7c],0x0 (1000_5147 / 0x15147)
    UInt16[SS, (ushort)(BP - 0x7C)] = 0x0;
    CheckExternalEvents(cs7, 0x5150);
    // CMP word ptr [BP + -0x60],0x1c (1000_514C / 0x1514C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x1C);
    CheckExternalEvents(cs7, 0x5152);
    // JL 0x1000:5166 (1000_5150 / 0x15150)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5166_15166;
    }
    CheckExternalEvents(cs7, 0x5156);
    // CMP word ptr [BP + -0x60],0x23 (1000_5152 / 0x15152)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x23);
    CheckExternalEvents(cs7, 0x5158);
    // JG 0x1000:5166 (1000_5156 / 0x15156)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5166_15166;
    }
    CheckExternalEvents(cs7, 0x515B);
    // PUSH word ptr [BP + -0x60] (1000_5158 / 0x15158)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x515E);
    // PUSH word ptr [BP + -0xc] (1000_515B / 0x1515B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x5163);
    // CALLF 0x1000:0bbb (1000_515E / 0x1515E)
    FarCall(cs7, 0x5163, ghidra_guess_1000_0BBB_10BBB);
    CheckExternalEvents(cs7, 0x5166);
    // ADD SP,0x4 (1000_5163 / 0x15163)
    SP += 0x4;
    label_1000_5166_15166:
    CheckExternalEvents(cs7, 0x516A);
    // CMP word ptr [BP + -0x60],0x1f (1000_5166 / 0x15166)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x1F);
    CheckExternalEvents(cs7, 0x516C);
    // JZ 0x1000:5175 (1000_516A / 0x1516A)
    if(ZeroFlag) {
      goto label_1000_5175_15175;
    }
    CheckExternalEvents(cs7, 0x5170);
    // CMP word ptr [BP + -0x60],0x20 (1000_516C / 0x1516C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x20);
    CheckExternalEvents(cs7, 0x5172);
    // JZ 0x1000:5175 (1000_5170 / 0x15170)
    if(ZeroFlag) {
      goto label_1000_5175_15175;
    }
    CheckExternalEvents(cs7, 0x5175);
    // JMP 0x1000:524a (1000_5172 / 0x15172)
    goto label_1000_524A_1524A;
    label_1000_5175_15175:
    CheckExternalEvents(cs7, 0x5178);
    // MOV AX,0x7d (1000_5175 / 0x15175)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x517B);
    // IMUL word ptr [BP + -0xc] (1000_5178 / 0x15178)
    int resImul1000_5178 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_5178);
    DX = (ushort)(resImul1000_5178 >> 16);
    CheckExternalEvents(cs7, 0x517D);
    // MOV BX,AX (1000_517B / 0x1517B)
    BX = AX;
    CheckExternalEvents(cs7, 0x5180);
    // ADD BX,word ptr [BP + -0x60] (1000_517D / 0x1517D)
    // BX += UInt16[SS, (ushort)(BP - 0x60)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x5184);
    // MOV ES,word ptr [0x5648] (1000_5180 / 0x15180)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x518A);
    // CMP byte ptr ES:[BX + 0xc724],0x0 (1000_5184 / 0x15184)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0x0);
    CheckExternalEvents(cs7, 0x518C);
    // JZ 0x1000:518f (1000_518A / 0x1518A)
    if(ZeroFlag) {
      goto label_1000_518F_1518F;
    }
    CheckExternalEvents(cs7, 0x518F);
    // JMP 0x1000:524a (1000_518C / 0x1518C)
    goto label_1000_524A_1524A;
    label_1000_518F_1518F:
    CheckExternalEvents(cs7, 0x5192);
    // PUSH word ptr [BP + -0x28] (1000_518F / 0x1518F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs7, 0x5197);
    // CALLF 0x0000:f565 (1000_5192 / 0x15192)
    FarCall(cs7, 0x5197, ghidra_guess_0000_F565_0F565);
    CheckExternalEvents(cs7, 0x519A);
    // ADD SP,0x2 (1000_5197 / 0x15197)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x519F);
    // MOV word ptr [BP + -0x3a],0x1 (1000_519A / 0x1519A)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    CheckExternalEvents(cs7, 0x51A3);
    // MOV ES,word ptr [0x564c] (1000_519F / 0x1519F)
    ES = UInt16[DS, 0x564C];
    CheckExternalEvents(cs7, 0x51AA);
    // MOV word ptr ES:[0x4586],0x0 (1000_51A3 / 0x151A3)
    UInt16[ES, 0x4586] = 0x0;
    CheckExternalEvents(cs7, 0x51AE);
    // CMP word ptr [BP + -0x28],0x0 (1000_51AA / 0x151AA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0x0);
    CheckExternalEvents(cs7, 0x51B0);
    // JZ 0x1000:51b3 (1000_51AE / 0x151AE)
    if(ZeroFlag) {
      goto label_1000_51B3_151B3;
    }
    CheckExternalEvents(cs7, 0x51B3);
    // JMP 0x1000:524a (1000_51B0 / 0x151B0)
    goto label_1000_524A_1524A;
    label_1000_51B3_151B3:
    CheckExternalEvents(cs7, 0x51B7);
    // CMP word ptr [BP + 0x6],0x0 (1000_51B3 / 0x151B3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x51B9);
    // JNZ 0x1000:51bc (1000_51B7 / 0x151B7)
    if(!ZeroFlag) {
      goto label_1000_51BC_151BC;
    }
    CheckExternalEvents(cs7, 0x51BC);
    // JMP 0x1000:524a (1000_51B9 / 0x151B9)
    goto label_1000_524A_1524A;
    label_1000_51BC_151BC:
    CheckExternalEvents(cs7, 0x51C1);
    // CALLF 0x0000:eaee (1000_51BC / 0x151BC)
    FarCall(cs7, 0x51C1, ghidra_guess_0000_EAEE_0EAEE);
    CheckExternalEvents(cs7, 0x51C4);
    // JMP 0x1000:524a (1000_51C1 / 0x151C1)
    goto label_1000_524A_1524A;
    label_1000_51C4_151C4:
    CheckExternalEvents(cs7, 0x51C7);
    // MOV AX,word ptr [BP + -0x52] (1000_51C4 / 0x151C4)
    AX = UInt16[SS, (ushort)(BP - 0x52)];
    CheckExternalEvents(cs7, 0x51CA);
    // SUB word ptr [BP + -0x7c],AX (1000_51C7 / 0x151C7)
    // UInt16[SS, (ushort)(BP - 0x7C)] -= AX;
    UInt16[SS, (ushort)(BP - 0x7C)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x7C)], AX);
    CheckExternalEvents(cs7, 0x51CD);
    // MOV AX,0x7d (1000_51CA / 0x151CA)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x51D0);
    // IMUL word ptr [BP + -0xc] (1000_51CD / 0x151CD)
    int resImul1000_51CD = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul1000_51CD);
    DX = (ushort)(resImul1000_51CD >> 16);
    CheckExternalEvents(cs7, 0x51D2);
    // MOV BX,AX (1000_51D0 / 0x151D0)
    BX = AX;
    CheckExternalEvents(cs7, 0x51D5);
    // ADD BX,word ptr [BP + -0x60] (1000_51D2 / 0x151D2)
    // BX += UInt16[SS, (ushort)(BP - 0x60)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x51D9);
    // MOV ES,word ptr [0x5648] (1000_51D5 / 0x151D5)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x51DF);
    // MOV byte ptr ES:[BX + 0xc724],0x0 (1000_51D9 / 0x151D9)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0x0;
    CheckExternalEvents(cs7, 0x51E3);
    // CMP word ptr [BP + -0x52],0x0 (1000_51DF / 0x151DF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x52)], 0x0);
    CheckExternalEvents(cs7, 0x51E5);
    // JZ 0x1000:51fb (1000_51E3 / 0x151E3)
    if(ZeroFlag) {
      goto label_1000_51FB_151FB;
    }
    CheckExternalEvents(cs7, 0x51E9);
    // CMP word ptr [BP + -0x60],0x1c (1000_51E5 / 0x151E5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x1C);
    CheckExternalEvents(cs7, 0x51EB);
    // JZ 0x1000:51f1 (1000_51E9 / 0x151E9)
    if(ZeroFlag) {
      goto label_1000_51F1_151F1;
    }
    CheckExternalEvents(cs7, 0x51EF);
    // CMP word ptr [BP + -0x60],0x21 (1000_51EB / 0x151EB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x21);
    CheckExternalEvents(cs7, 0x51F1);
    // JNZ 0x1000:51fb (1000_51EF / 0x151EF)
    if(!ZeroFlag) {
      goto label_1000_51FB_151FB;
    }
    label_1000_51F1_151F1:
    CheckExternalEvents(cs7, 0x51F5);
    // MOV ES,word ptr [0x5676] (1000_51F1 / 0x151F1)
    ES = UInt16[DS, 0x5676];
    CheckExternalEvents(cs7, 0x51FB);
    // MOV byte ptr ES:[0x3986],0x1 (1000_51F5 / 0x151F5)
    UInt8[ES, 0x3986] = 0x1;
    label_1000_51FB_151FB:
    CheckExternalEvents(cs7, 0x51FF);
    // CMP word ptr [BP + -0x60],0x1c (1000_51FB / 0x151FB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x1C);
    CheckExternalEvents(cs7, 0x5201);
    // JL 0x1000:5215 (1000_51FF / 0x151FF)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5215_15215;
    }
    CheckExternalEvents(cs7, 0x5205);
    // CMP word ptr [BP + -0x60],0x23 (1000_5201 / 0x15201)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x60)], 0x23);
    CheckExternalEvents(cs7, 0x5207);
    // JG 0x1000:5215 (1000_5205 / 0x15205)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5215_15215;
    }
    CheckExternalEvents(cs7, 0x520A);
    // PUSH word ptr [BP + -0x60] (1000_5207 / 0x15207)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x520D);
    // PUSH word ptr [BP + -0xc] (1000_520A / 0x1520A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x5212);
    // CALLF 0x1000:0bbb (1000_520D / 0x1520D)
    FarCall(cs7, 0x5212, ghidra_guess_1000_0BBB_10BBB);
    CheckExternalEvents(cs7, 0x5215);
    // ADD SP,0x4 (1000_5212 / 0x15212)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_5215_15215:
    CheckExternalEvents(cs7, 0x5218);
    // PUSH word ptr [BP + -0x60] (1000_5215 / 0x15215)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs7, 0x521D);
    // CALLF 0x1000:0b32 (1000_5218 / 0x15218)
    FarCall(cs7, 0x521D, ghidra_guess_1000_0B32_10B32);
    CheckExternalEvents(cs7, 0x5220);
    // ADD SP,0x2 (1000_521D / 0x1521D)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x5223);
    // MOV word ptr [BP + -0x60],AX (1000_5220 / 0x15220)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs7, 0x5227);
    // MOV ES,word ptr [0x564a] (1000_5223 / 0x15223)
    ES = UInt16[DS, 0x564A];
    CheckExternalEvents(cs7, 0x522D);
    // CMP word ptr ES:[0xe484],0x0 (1000_5227 / 0x15227)
    Alu16.Sub(UInt16[ES, 0xE484], 0x0);
    CheckExternalEvents(cs7, 0x522F);
    // JZ 0x1000:524a (1000_522D / 0x1522D)
    if(ZeroFlag) {
      goto label_1000_524A_1524A;
    }
    CheckExternalEvents(cs7, 0x5232);
    // PUSH word ptr [BP + -0x28] (1000_522F / 0x1522F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs7, 0x5237);
    // CALLF 0x0000:f565 (1000_5232 / 0x15232)
    FarCall(cs7, 0x5237, ghidra_guess_0000_F565_0F565);
    CheckExternalEvents(cs7, 0x523A);
    // ADD SP,0x2 (1000_5237 / 0x15237)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x523F);
    // MOV word ptr [BP + -0x3a],0x1 (1000_523A / 0x1523A)
    UInt16[SS, (ushort)(BP - 0x3A)] = 0x1;
    CheckExternalEvents(cs7, 0x5243);
    // MOV ES,word ptr [0x564c] (1000_523F / 0x1523F)
    ES = UInt16[DS, 0x564C];
    CheckExternalEvents(cs7, 0x524A);
    // MOV word ptr ES:[0x4586],0x0 (1000_5243 / 0x15243)
    UInt16[ES, 0x4586] = 0x0;
    label_1000_524A_1524A:
    CheckExternalEvents(cs7, 0x524E);
    // CMP word ptr [BP + -0x7c],0x0 (1000_524A / 0x1524A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x7C)], 0x0);
    CheckExternalEvents(cs7, 0x5250);
    // JZ 0x1000:5253 (1000_524E / 0x1524E)
    if(ZeroFlag) {
      goto label_1000_5253_15253;
    }
    CheckExternalEvents(cs7, 0x5253);
    // JMP 0x1000:50c3 (1000_5250 / 0x15250)
    goto label_1000_50C3_150C3;
    label_1000_5253_15253:
    CheckExternalEvents(cs7, 0x5256);
    // MOV AX,0x4314 (1000_5253 / 0x15253)
    AX = 0x4314;
    CheckExternalEvents(cs7, 0x5259);
    // MOV DX,0x2a02 (1000_5256 / 0x15256)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x525A);
    // PUSH DX (1000_5259 / 0x15259)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x525B);
    // PUSH AX (1000_525A / 0x1525A)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x525E);
    // PUSH word ptr [BP + -0x56] (1000_525B / 0x1525B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x56)]);
    CheckExternalEvents(cs7, 0x5261);
    // PUSH word ptr [BP + -0xc] (1000_525E / 0x1525E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x5264);
    // PUSH word ptr [BP + -0x3a] (1000_5261 / 0x15261)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x3A)]);
    CheckExternalEvents(cs7, 0x5267);
    // PUSH word ptr [BP + -0x2c] (1000_5264 / 0x15264)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs7, 0x526A);
    // PUSH word ptr [BP + -0x6] (1000_5267 / 0x15267)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs7, 0x526D);
    // PUSH word ptr [BP + -0x58] (1000_526A / 0x1526A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x58)]);
    CheckExternalEvents(cs7, 0x5270);
    // PUSH word ptr [BP + -0x48] (1000_526D / 0x1526D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x48)]);
    CheckExternalEvents(cs7, 0x5273);
    // PUSH word ptr [BP + -0x28] (1000_5270 / 0x15270)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs7, 0x5276);
    // PUSH word ptr [BP + -0x2] (1000_5273 / 0x15273)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x5277);
    // PUSH CS (1000_5276 / 0x15276)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x527A);
    // CALL 0x1000:5847 (1000_5277 / 0x15277)
    NearCall(cs7, 0x527A, ghidra_guess_1000_5847_15847);
    CheckExternalEvents(cs7, 0x527D);
    // ADD SP,0x16 (1000_527A / 0x1527A)
    // SP += 0x16;
    SP = Alu16.Add(SP, 0x16);
    CheckExternalEvents(cs7, 0x5281);
    // MOV ES,word ptr [0x5676] (1000_527D / 0x1527D)
    ES = UInt16[DS, 0x5676];
    CheckExternalEvents(cs7, 0x5287);
    // CMP byte ptr ES:[0x3986],0x0 (1000_5281 / 0x15281)
    Alu8.Sub(UInt8[ES, 0x3986], 0x0);
    CheckExternalEvents(cs7, 0x5289);
    // JZ 0x1000:52c1 (1000_5287 / 0x15287)
    if(ZeroFlag) {
      goto label_1000_52C1_152C1;
    }
    CheckExternalEvents(cs7, 0x528D);
    // MOV ES,word ptr [0x564c] (1000_5289 / 0x15289)
    ES = UInt16[DS, 0x564C];
    CheckExternalEvents(cs7, 0x5294);
    // MOV word ptr ES:[0x4586],0x0 (1000_528D / 0x1528D)
    UInt16[ES, 0x4586] = 0x0;
    CheckExternalEvents(cs7, 0x5298);
    // MOV ES,word ptr [0x5646] (1000_5294 / 0x15294)
    ES = UInt16[DS, 0x5646];
    CheckExternalEvents(cs7, 0x529E);
    // CMP word ptr ES:[0x2e3a],0x0 (1000_5298 / 0x15298)
    Alu16.Sub(UInt16[ES, 0x2E3A], 0x0);
    CheckExternalEvents(cs7, 0x52A0);
    // JZ 0x1000:52c1 (1000_529E / 0x1529E)
    if(ZeroFlag) {
      goto label_1000_52C1_152C1;
    }
    CheckExternalEvents(cs7, 0x52A4);
    // CMP word ptr [BP + -0x28],0xd (1000_52A0 / 0x152A0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x28)], 0xD);
    CheckExternalEvents(cs7, 0x52A6);
    // JNZ 0x1000:52b2 (1000_52A4 / 0x152A4)
    if(!ZeroFlag) {
      goto label_1000_52B2_152B2;
    }
    CheckExternalEvents(cs7, 0x52AA);
    // MOV ES,word ptr [0x5660] (1000_52A6 / 0x152A6)
    ES = UInt16[DS, 0x5660];
    CheckExternalEvents(cs7, 0x52B0);
    // CMP word ptr ES:[0xe48e],0x0 (1000_52AA / 0x152AA)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs7, 0x52B2);
    // JNZ 0x1000:52c1 (1000_52B0 / 0x152B0)
    if(!ZeroFlag) {
      goto label_1000_52C1_152C1;
    }
    label_1000_52B2_152B2:
    CheckExternalEvents(cs7, 0x52B4);
    // SUB AX,AX (1000_52B2 / 0x152B2)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x52B5);
    // PUSH AX (1000_52B4 / 0x152B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x52B8);
    // MOV AX,0x10 (1000_52B5 / 0x152B5)
    AX = 0x10;
    CheckExternalEvents(cs7, 0x52B9);
    // PUSH AX (1000_52B8 / 0x152B8)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x52BE);
    // CALLF 0x0000:5fb7 (1000_52B9 / 0x152B9)
    FarCall(cs7, 0x52BE, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs7, 0x52C1);
    // ADD SP,0x4 (1000_52BE / 0x152BE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_52C1_152C1:
    CheckExternalEvents(cs7, 0x52C5);
    // MOV ES,word ptr [0x564c] (1000_52C1 / 0x152C1)
    ES = UInt16[DS, 0x564C];
    CheckExternalEvents(cs7, 0x52CB);
    // CMP word ptr ES:[0x4586],0x0 (1000_52C5 / 0x152C5)
    Alu16.Sub(UInt16[ES, 0x4586], 0x0);
    CheckExternalEvents(cs7, 0x52CD);
    // JZ 0x1000:52f6 (1000_52CB / 0x152CB)
    if(ZeroFlag) {
      goto label_1000_52F6_152F6;
    }
    CheckExternalEvents(cs7, 0x52D1);
    // MOV ES,word ptr [0x5648] (1000_52CD / 0x152CD)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x52D5);
    // MOV AL,ES:[0xc620] (1000_52D1 / 0x152D1)
    AL = UInt8[ES, 0xC620];
    CheckExternalEvents(cs7, 0x52D6);
    // CBW  (1000_52D5 / 0x152D5)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x52D9);
    // CMP AX,word ptr [BP + -0xc] (1000_52D6 / 0x152D6)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x52DB);
    // JNZ 0x1000:52f6 (1000_52D9 / 0x152D9)
    if(!ZeroFlag) {
      goto label_1000_52F6_152F6;
    }
    CheckExternalEvents(cs7, 0x52DF);
    // MOV ES,word ptr [0x5646] (1000_52DB / 0x152DB)
    ES = UInt16[DS, 0x5646];
    CheckExternalEvents(cs7, 0x52E5);
    // CMP word ptr ES:[0x2e3a],0x0 (1000_52DF / 0x152DF)
    Alu16.Sub(UInt16[ES, 0x2E3A], 0x0);
    CheckExternalEvents(cs7, 0x52E7);
    // JZ 0x1000:52f6 (1000_52E5 / 0x152E5)
    if(ZeroFlag) {
      goto label_1000_52F6_152F6;
    }
    CheckExternalEvents(cs7, 0x52E9);
    // SUB AX,AX (1000_52E7 / 0x152E7)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x52EA);
    // PUSH AX (1000_52E9 / 0x152E9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x52ED);
    // MOV AX,0x5 (1000_52EA / 0x152EA)
    AX = 0x5;
    CheckExternalEvents(cs7, 0x52EE);
    // PUSH AX (1000_52ED / 0x152ED)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x52F3);
    // CALLF 0x0000:5fb7 (1000_52EE / 0x152EE)
    FarCall(cs7, 0x52F3, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs7, 0x52F6);
    // ADD SP,0x4 (1000_52F3 / 0x152F3)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_52F6_152F6:
    CheckExternalEvents(cs7, 0x52FB);
    // CALLF 0x1000:17dc (1000_52F6 / 0x152F6)
    FarCall(cs7, 0x52FB, ghidra_guess_1000_17DC_117DC);
    CheckExternalEvents(cs7, 0x52FE);
    // MOV AX,0xc (1000_52FB / 0x152FB)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x5301);
    // IMUL word ptr [BP + -0x2] (1000_52FE / 0x152FE)
    int resImul1000_52FE = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_52FE);
    DX = (ushort)(resImul1000_52FE >> 16);
    CheckExternalEvents(cs7, 0x5303);
    // MOV BX,AX (1000_5301 / 0x15301)
    BX = AX;
    CheckExternalEvents(cs7, 0x5306);
    // ADD BX,word ptr [BP + -0x42] (1000_5303 / 0x15303)
    // BX += UInt16[SS, (ushort)(BP - 0x42)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs7, 0x530A);
    // MOV ES,word ptr [0x564e] (1000_5306 / 0x15306)
    ES = UInt16[DS, 0x564E];
    CheckExternalEvents(cs7, 0x5310);
    // OR byte ptr ES:[BX + 0x3800],0x80 (1000_530A / 0x1530A)
    // UInt8[ES, (ushort)(BX + 0x3800)] |= 0x80;
    UInt8[ES, (ushort)(BX + 0x3800)] = Alu8.Or(UInt8[ES, (ushort)(BX + 0x3800)], 0x80);
    CheckExternalEvents(cs7, 0x5315);
    // MOV word ptr [BP + -0x42],0xc (1000_5310 / 0x15310)
    UInt16[SS, (ushort)(BP - 0x42)] = 0xC;
    CheckExternalEvents(cs7, 0x5319);
    // MOV ES,word ptr [0x5676] (1000_5315 / 0x15315)
    ES = UInt16[DS, 0x5676];
    CheckExternalEvents(cs7, 0x531F);
    // MOV byte ptr ES:[0x3986],0x0 (1000_5319 / 0x15319)
    UInt8[ES, 0x3986] = 0x0;
    label_1000_531F_1531F:
    CheckExternalEvents(cs7, 0x5322);
    // PUSH word ptr [BP + -0x36] (1000_531F / 0x1531F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs7, 0x5325);
    // PUSH word ptr [BP + -0x2a] (1000_5322 / 0x15322)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2A)]);
    CheckExternalEvents(cs7, 0x532A);
    // CALLF 0x0000:2ebb (1000_5325 / 0x15325)
    FarCall(cs7, 0x532A, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x532D);
    // ADD SP,0x4 (1000_532A / 0x1532A)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x532F);
    // JMP 0x1000:5344 (1000_532D / 0x1532D)
    goto label_1000_5344_15344;
    label_1000_532F_1532F:
    CheckExternalEvents(cs7, 0x5332);
    // MOV AX,0xc (1000_532F / 0x1532F)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x5335);
    // IMUL word ptr [BP + -0x2] (1000_5332 / 0x15332)
    int resImul1000_5332 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_5332);
    DX = (ushort)(resImul1000_5332 >> 16);
    CheckExternalEvents(cs7, 0x5337);
    // MOV BX,AX (1000_5335 / 0x15335)
    BX = AX;
    CheckExternalEvents(cs7, 0x533A);
    // ADD BX,word ptr [BP + -0x42] (1000_5337 / 0x15337)
    // BX += UInt16[SS, (ushort)(BP - 0x42)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs7, 0x533E);
    // MOV ES,word ptr [0x564e] (1000_533A / 0x1533A)
    ES = UInt16[DS, 0x564E];
    CheckExternalEvents(cs7, 0x5344);
    // MOV byte ptr ES:[BX + 0x3800],0xff (1000_533E / 0x1533E)
    UInt8[ES, (ushort)(BX + 0x3800)] = 0xFF;
    label_1000_5344_15344:
    CheckExternalEvents(cs7, 0x5348);
    // MOV ES,word ptr [0x562a] (1000_5344 / 0x15344)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x534B);
    // MOV AX,word ptr [BP + -0x2a] (1000_5348 / 0x15348)
    AX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs7, 0x534F);
    // MOV ES:[0xa44b],AX (1000_534B / 0x1534B)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x5353);
    // MOV ES,word ptr [0x562c] (1000_534F / 0x1534F)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x5356);
    // MOV AX,word ptr [BP + -0x36] (1000_5353 / 0x15353)
    AX = UInt16[SS, (ushort)(BP - 0x36)];
    CheckExternalEvents(cs7, 0x535A);
    // MOV ES:[0xa44d],AX (1000_5356 / 0x15356)
    UInt16[ES, 0xA44D] = AX;
    label_1000_535A_1535A:
    CheckExternalEvents(cs7, 0x535D);
    // INC word ptr [BP + -0x42] (1000_535A / 0x1535A)
    UInt16[SS, (ushort)(BP - 0x42)]++;
    label_1000_535D_1535D:
    CheckExternalEvents(cs7, 0x5361);
    // CMP word ptr [BP + -0x42],0xc (1000_535D / 0x1535D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x42)], 0xC);
    CheckExternalEvents(cs7, 0x5363);
    // JL 0x1000:5366 (1000_5361 / 0x15361)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5366_15366;
    }
    CheckExternalEvents(cs7, 0x5366);
    // JMP 0x1000:5455 (1000_5363 / 0x15363)
    goto label_1000_5455_15455;
    label_1000_5366_15366:
    CheckExternalEvents(cs7, 0x536A);
    // MOV ES,word ptr [0x564a] (1000_5366 / 0x15366)
    ES = UInt16[DS, 0x564A];
    CheckExternalEvents(cs7, 0x536C);
    // SUB AX,AX (1000_536A / 0x1536A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x536F);
    // MOV word ptr [BP + -0x3a],AX (1000_536C / 0x1536C)
    UInt16[SS, (ushort)(BP - 0x3A)] = AX;
    CheckExternalEvents(cs7, 0x5372);
    // MOV word ptr [BP + -0x2c],AX (1000_536F / 0x1536F)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs7, 0x5375);
    // MOV word ptr [BP + -0x6],AX (1000_5372 / 0x15372)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x5379);
    // MOV ES:[0xe484],AX (1000_5375 / 0x15375)
    UInt16[ES, 0xE484] = AX;
    CheckExternalEvents(cs7, 0x537D);
    // MOV ES,word ptr [0x564c] (1000_5379 / 0x15379)
    ES = UInt16[DS, 0x564C];
    CheckExternalEvents(cs7, 0x5381);
    // MOV ES:[0x4586],AX (1000_537D / 0x1537D)
    UInt16[ES, 0x4586] = AX;
    CheckExternalEvents(cs7, 0x5384);
    // MOV AX,0xc (1000_5381 / 0x15381)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x5387);
    // IMUL word ptr [BP + -0x2] (1000_5384 / 0x15384)
    int resImul1000_5384 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_5384);
    DX = (ushort)(resImul1000_5384 >> 16);
    CheckExternalEvents(cs7, 0x5389);
    // MOV BX,AX (1000_5387 / 0x15387)
    BX = AX;
    CheckExternalEvents(cs7, 0x538C);
    // ADD BX,word ptr [BP + -0x42] (1000_5389 / 0x15389)
    // BX += UInt16[SS, (ushort)(BP - 0x42)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs7, 0x5390);
    // MOV ES,word ptr [0x564e] (1000_538C / 0x1538C)
    ES = UInt16[DS, 0x564E];
    CheckExternalEvents(cs7, 0x5395);
    // MOV AL,byte ptr ES:[BX + 0x3800] (1000_5390 / 0x15390)
    AL = UInt8[ES, (ushort)(BX + 0x3800)];
    CheckExternalEvents(cs7, 0x5396);
    // CBW  (1000_5395 / 0x15395)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x5399);
    // MOV word ptr [BP + -0x28],AX (1000_5396 / 0x15396)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs7, 0x539D);
    // CMP word ptr [BP + -0x2],0x4 (1000_5399 / 0x15399)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x539F);
    // JGE 0x1000:53b3 (1000_539D / 0x1539D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_53B3_153B3;
    }
    CheckExternalEvents(cs7, 0x53A2);
    // MOV BX,word ptr [BP + -0x2] (1000_539F / 0x1539F)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x53A6);
    // MOV ES,word ptr [0x5650] (1000_53A2 / 0x153A2)
    ES = UInt16[DS, 0x5650];
    CheckExternalEvents(cs7, 0x53AC);
    // CMP byte ptr ES:[BX + 0x6e],0x1e (1000_53A6 / 0x153A6)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x1E);
    CheckExternalEvents(cs7, 0x53AE);
    // JL 0x1000:53b3 (1000_53AC / 0x153AC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_53B3_153B3;
    }
    CheckExternalEvents(cs7, 0x53B3);
    // MOV word ptr [BP + -0x28],0xffff (1000_53AE / 0x153AE)
    UInt16[SS, (ushort)(BP - 0x28)] = 0xFFFF;
    label_1000_53B3_153B3:
    CheckExternalEvents(cs7, 0x53B7);
    // CMP word ptr [BP + -0x2],0xc (1000_53B3 / 0x153B3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x53B9);
    // JL 0x1000:53d3 (1000_53B7 / 0x153B7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_53D3_153D3;
    }
    CheckExternalEvents(cs7, 0x53BD);
    // CMP word ptr [BP + -0x2],0x10 (1000_53B9 / 0x153B9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x53BF);
    // JGE 0x1000:53d3 (1000_53BD / 0x153BD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_53D3_153D3;
    }
    CheckExternalEvents(cs7, 0x53C2);
    // MOV BX,word ptr [BP + -0x2] (1000_53BF / 0x153BF)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x53C6);
    // MOV ES,word ptr [0x5650] (1000_53C2 / 0x153C2)
    ES = UInt16[DS, 0x5650];
    CheckExternalEvents(cs7, 0x53CC);
    // CMP byte ptr ES:[BX + 0x66],0x1e (1000_53C6 / 0x153C6)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x66)], 0x1E);
    CheckExternalEvents(cs7, 0x53CE);
    // JL 0x1000:53d3 (1000_53CC / 0x153CC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_53D3_153D3;
    }
    CheckExternalEvents(cs7, 0x53D3);
    // MOV word ptr [BP + -0x28],0xffff (1000_53CE / 0x153CE)
    UInt16[SS, (ushort)(BP - 0x28)] = 0xFFFF;
    label_1000_53D3_153D3:
    CheckExternalEvents(cs7, 0x53D7);
    // TEST byte ptr [BP + -0x28],0x80 (1000_53D3 / 0x153D3)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x28)], 0x80);
    CheckExternalEvents(cs7, 0x53D9);
    // JNZ 0x1000:535a (1000_53D7 / 0x153D7)
    if(!ZeroFlag) {
      goto label_1000_535A_1535A;
    }
    CheckExternalEvents(cs7, 0x53DD);
    // MOV ES,word ptr [0x562a] (1000_53D9 / 0x153D9)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x53E1);
    // MOV AX,ES:[0xa44b] (1000_53DD / 0x153DD)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x53E4);
    // MOV word ptr [BP + -0x2a],AX (1000_53E1 / 0x153E1)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs7, 0x53E8);
    // MOV ES,word ptr [0x562c] (1000_53E4 / 0x153E4)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x53EC);
    // MOV AX,ES:[0xa44d] (1000_53E8 / 0x153E8)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x53EF);
    // MOV word ptr [BP + -0x36],AX (1000_53EC / 0x153EC)
    UInt16[SS, (ushort)(BP - 0x36)] = AX;
    CheckExternalEvents(cs7, 0x53F2);
    // MOV SI,word ptr [BP + -0x2] (1000_53EF / 0x153EF)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x53F4);
    // SHL SI,0x1 (1000_53F2 / 0x153F2)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x53F8);
    // MOV ES,word ptr [0x5638] (1000_53F4 / 0x153F4)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x53FD);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_53F8 / 0x153F8)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x5401);
    // MOV ES,word ptr [0x562a] (1000_53FD / 0x153FD)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x5405);
    // MOV ES:[0xa44b],AX (1000_5401 / 0x15401)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x5409);
    // MOV ES,word ptr [0x5636] (1000_5405 / 0x15405)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x540E);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_5409 / 0x15409)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs7, 0x5412);
    // MOV ES,word ptr [0x562c] (1000_540E / 0x1540E)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x5416);
    // MOV ES:[0xa44d],AX (1000_5412 / 0x15412)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs7, 0x541A);
    // CMP word ptr [BP + -0x2],0x4 (1000_5416 / 0x15416)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x541C);
    // JL 0x1000:5422 (1000_541A / 0x1541A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5422_15422;
    }
    CheckExternalEvents(cs7, 0x5420);
    // CMP word ptr [BP + -0x2],0xc (1000_541C / 0x1541C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x5422);
    // JL 0x1000:542b (1000_5420 / 0x15420)
    if(SignFlag != OverflowFlag) {
      goto label_1000_542B_1542B;
    }
    label_1000_5422_15422:
    CheckExternalEvents(cs7, 0x5426);
    // CMP word ptr [BP + -0x2],0x10 (1000_5422 / 0x15422)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x5428);
    // JGE 0x1000:542b (1000_5426 / 0x15426)
    if(SignFlag == OverflowFlag) {
      goto label_1000_542B_1542B;
    }
    CheckExternalEvents(cs7, 0x542B);
    // JMP 0x1000:45d9 (1000_5428 / 0x15428)
    goto label_1000_45D9_145D9;
    label_1000_542B_1542B:
    CheckExternalEvents(cs7, 0x542E);
    // MOV AX,0x11 (1000_542B / 0x1542B)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x5431);
    // IMUL word ptr [BP + -0x2] (1000_542E / 0x1542E)
    int resImul1000_542E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_542E);
    DX = (ushort)(resImul1000_542E >> 16);
    CheckExternalEvents(cs7, 0x5433);
    // MOV SI,AX (1000_5431 / 0x15431)
    SI = AX;
    CheckExternalEvents(cs7, 0x5437);
    // MOV ES,word ptr [0x5648] (1000_5433 / 0x15433)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x543C);
    // MOV AL,byte ptr ES:[SI + 0xc5db] (1000_5437 / 0x15437)
    AL = UInt8[ES, (ushort)(SI + 0xC5DB)];
    CheckExternalEvents(cs7, 0x543D);
    // CBW  (1000_543C / 0x1543C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x5440);
    // MOV word ptr [BP + -0x48],AX (1000_543D / 0x1543D)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    CheckExternalEvents(cs7, 0x5444);
    // CMP word ptr [BP + -0x2],0x10 (1000_5440 / 0x15440)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x5446);
    // JGE 0x1000:5449 (1000_5444 / 0x15444)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5449_15449;
    }
    CheckExternalEvents(cs7, 0x5449);
    // JMP 0x1000:4669 (1000_5446 / 0x15446)
    goto label_1000_4669_14669;
    label_1000_5449_15449:
    CheckExternalEvents(cs7, 0x544E);
    // MOV AL,byte ptr ES:[SI + 0xc597] (1000_5449 / 0x15449)
    AL = UInt8[ES, (ushort)(SI + 0xC597)];
    CheckExternalEvents(cs7, 0x544F);
    // CBW  (1000_544E / 0x1544E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x5452);
    // MOV word ptr [BP + -0x48],AX (1000_544F / 0x1544F)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    CheckExternalEvents(cs7, 0x5455);
    // JMP 0x1000:4669 (1000_5452 / 0x15452)
    goto label_1000_4669_14669;
    label_1000_5455_15455:
    CheckExternalEvents(cs7, 0x5458);
    // INC word ptr [BP + -0x2] (1000_5455 / 0x15455)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_1000_5458_15458:
    CheckExternalEvents(cs7, 0x545C);
    // CMP word ptr [BP + -0x2],0x18 (1000_5458 / 0x15458)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs7, 0x545E);
    // JGE 0x1000:5483 (1000_545C / 0x1545C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5483_15483;
    }
    CheckExternalEvents(cs7, 0x5462);
    // MOV ES,word ptr [0x5630] (1000_545E / 0x1545E)
    ES = UInt16[DS, 0x5630];
    CheckExternalEvents(cs7, 0x5468);
    // CMP word ptr ES:[0x14a],0x0 (1000_5462 / 0x15462)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs7, 0x546A);
    // JZ 0x1000:5455 (1000_5468 / 0x15468)
    if(ZeroFlag) {
      goto label_1000_5455_15455;
    }
    CheckExternalEvents(cs7, 0x546D);
    // MOV BX,word ptr [BP + -0x2] (1000_546A / 0x1546A)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x546F);
    // SHL BX,0x1 (1000_546D / 0x1546D)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x5473);
    // MOV ES,word ptr [0x5632] (1000_546F / 0x1546F)
    ES = UInt16[DS, 0x5632];
    CheckExternalEvents(cs7, 0x5479);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_5473 / 0x15473)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x547B);
    // JZ 0x1000:5455 (1000_5479 / 0x15479)
    if(ZeroFlag) {
      goto label_1000_5455_15455;
    }
    CheckExternalEvents(cs7, 0x5480);
    // MOV word ptr [BP + -0x42],0x0 (1000_547B / 0x1547B)
    UInt16[SS, (ushort)(BP - 0x42)] = 0x0;
    CheckExternalEvents(cs7, 0x5483);
    // JMP 0x1000:535d (1000_5480 / 0x15480)
    goto label_1000_535D_1535D;
    label_1000_5483_15483:
    CheckExternalEvents(cs7, 0x5488);
    // MOV word ptr [BP + -0x5a],0x0 (1000_5483 / 0x15483)
    UInt16[SS, (ushort)(BP - 0x5A)] = 0x0;
    label_1000_5488_15488:
    CheckExternalEvents(cs7, 0x548B);
    // MOV AX,0x30 (1000_5488 / 0x15488)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x548E);
    // IMUL word ptr [BP + -0x5a] (1000_548B / 0x1548B)
    int resImul1000_548B = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x5A)]);
    AX = (ushort)(resImul1000_548B);
    DX = (ushort)(resImul1000_548B >> 16);
    CheckExternalEvents(cs7, 0x5490);
    // MOV SI,AX (1000_548E / 0x1548E)
    SI = AX;
    CheckExternalEvents(cs7, 0x5494);
    // MOV ES,word ptr [0x5654] (1000_5490 / 0x15490)
    ES = UInt16[DS, 0x5654];
    CheckExternalEvents(cs7, 0x549A);
    // CMP byte ptr ES:[SI + 0x32c6],0xff (1000_5494 / 0x15494)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0x32C6)], 0xFF);
    CheckExternalEvents(cs7, 0x549C);
    // JNZ 0x1000:549f (1000_549A / 0x1549A)
    if(!ZeroFlag) {
      goto label_1000_549F_1549F;
    }
    CheckExternalEvents(cs7, 0x549F);
    // JMP 0x1000:556a (1000_549C / 0x1549C)
    goto label_1000_556A_1556A;
    label_1000_549F_1549F:
    CheckExternalEvents(cs7, 0x54A2);
    // MOV DI,word ptr [BP + -0x5a] (1000_549F / 0x1549F)
    DI = UInt16[SS, (ushort)(BP - 0x5A)];
    CheckExternalEvents(cs7, 0x54A4);
    // SHL DI,0x1 (1000_54A2 / 0x154A2)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs7, 0x54A8);
    // MOV ES,word ptr [0x5638] (1000_54A4 / 0x154A4)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x54AD);
    // MOV AX,word ptr ES:[DI + 0x4004] (1000_54A8 / 0x154A8)
    AX = UInt16[ES, (ushort)(DI + 0x4004)];
    CheckExternalEvents(cs7, 0x54B1);
    // MOV ES,word ptr [0x5636] (1000_54AD / 0x154AD)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x54B6);
    // OR AX,word ptr ES:[DI + 0x4036] (1000_54B1 / 0x154B1)
    // AX |= UInt16[ES, (ushort)(DI + 0x4036)];
    AX = Alu16.Or(AX, UInt16[ES, (ushort)(DI + 0x4036)]);
    CheckExternalEvents(cs7, 0x54B8);
    // MOV AL,AH (1000_54B6 / 0x154B6)
    AL = AH;
    CheckExternalEvents(cs7, 0x54BA);
    // SUB AH,AH (1000_54B8 / 0x154B8)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x54BD);
    // MOV word ptr [BP + -0x50],AX (1000_54BA / 0x154BA)
    UInt16[SS, (ushort)(BP - 0x50)] = AX;
    CheckExternalEvents(cs7, 0x54C1);
    // MOV ES,word ptr [0x5638] (1000_54BD / 0x154BD)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x54C6);
    // MOV AX,word ptr ES:[DI + 0x4004] (1000_54C1 / 0x154C1)
    AX = UInt16[ES, (ushort)(DI + 0x4004)];
    CheckExternalEvents(cs7, 0x54C9);
    // AND AX,0x7f (1000_54C6 / 0x154C6)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs7, 0x54CC);
    // MOV word ptr [BP + -0xa],AX (1000_54C9 / 0x154C9)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x54D0);
    // MOV ES,word ptr [0x5636] (1000_54CC / 0x154CC)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x54D5);
    // MOV AX,word ptr ES:[DI + 0x4036] (1000_54D0 / 0x154D0)
    AX = UInt16[ES, (ushort)(DI + 0x4036)];
    CheckExternalEvents(cs7, 0x54D8);
    // AND AX,0x7f (1000_54D5 / 0x154D5)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs7, 0x54DB);
    // MOV word ptr [BP + -0x12],AX (1000_54D8 / 0x154D8)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs7, 0x54DF);
    // MOV ES,word ptr [0x5654] (1000_54DB / 0x154DB)
    ES = UInt16[DS, 0x5654];
    CheckExternalEvents(cs7, 0x54E4);
    // MOV AL,byte ptr ES:[SI + 0x32c7] (1000_54DF / 0x154DF)
    AL = UInt8[ES, (ushort)(SI + 0x32C7)];
    CheckExternalEvents(cs7, 0x54E6);
    // SUB AH,AH (1000_54E4 / 0x154E4)
    AH -= AH;
    CheckExternalEvents(cs7, 0x54E9);
    // CMP AX,word ptr [BP + -0x50] (1000_54E6 / 0x154E6)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x50)]);
    CheckExternalEvents(cs7, 0x54EB);
    // JNZ 0x1000:556a (1000_54E9 / 0x154E9)
    if(!ZeroFlag) {
      goto label_1000_556A_1556A;
    }
    CheckExternalEvents(cs7, 0x54F0);
    // MOV AL,byte ptr ES:[SI + 0x32c8] (1000_54EB / 0x154EB)
    AL = UInt8[ES, (ushort)(SI + 0x32C8)];
    CheckExternalEvents(cs7, 0x54F1);
    // CBW  (1000_54F0 / 0x154F0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x54F4);
    // CMP AX,word ptr [BP + -0xa] (1000_54F1 / 0x154F1)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x54F6);
    // JNZ 0x1000:556a (1000_54F4 / 0x154F4)
    if(!ZeroFlag) {
      goto label_1000_556A_1556A;
    }
    CheckExternalEvents(cs7, 0x54FB);
    // MOV AL,byte ptr ES:[SI + 0x32c9] (1000_54F6 / 0x154F6)
    AL = UInt8[ES, (ushort)(SI + 0x32C9)];
    CheckExternalEvents(cs7, 0x54FC);
    // CBW  (1000_54FB / 0x154FB)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x54FF);
    // CMP AX,word ptr [BP + -0x12] (1000_54FC / 0x154FC)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs7, 0x5501);
    // JNZ 0x1000:556a (1000_54FF / 0x154FF)
    if(!ZeroFlag) {
      goto label_1000_556A_1556A;
    }
    CheckExternalEvents(cs7, 0x5506);
    // MOV word ptr [BP + -0x5e],0x0 (1000_5501 / 0x15501)
    UInt16[SS, (ushort)(BP - 0x5E)] = 0x0;
    label_1000_5506_15506:
    CheckExternalEvents(cs7, 0x5509);
    // MOV AX,0x30 (1000_5506 / 0x15506)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x550C);
    // IMUL word ptr [BP + -0x5a] (1000_5509 / 0x15509)
    int resImul1000_5509 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x5A)]);
    AX = (ushort)(resImul1000_5509);
    DX = (ushort)(resImul1000_5509 >> 16);
    CheckExternalEvents(cs7, 0x550E);
    // MOV SI,AX (1000_550C / 0x1550C)
    SI = AX;
    CheckExternalEvents(cs7, 0x5511);
    // MOV DI,word ptr [BP + -0x5e] (1000_550E / 0x1550E)
    DI = UInt16[SS, (ushort)(BP - 0x5E)];
    CheckExternalEvents(cs7, 0x5513);
    // ADD DI,SI (1000_5511 / 0x15511)
    // DI += SI;
    DI = Alu16.Add(DI, SI);
    CheckExternalEvents(cs7, 0x5518);
    // MOV AL,byte ptr ES:[DI + 0x32ca] (1000_5513 / 0x15513)
    AL = UInt8[ES, (ushort)(DI + 0x32CA)];
    CheckExternalEvents(cs7, 0x551D);
    // MOV byte ptr ES:[DI + 0x32c6],AL (1000_5518 / 0x15518)
    UInt8[ES, (ushort)(DI + 0x32C6)] = AL;
    CheckExternalEvents(cs7, 0x5520);
    // INC word ptr [BP + -0x5e] (1000_551D / 0x1551D)
    UInt16[SS, (ushort)(BP - 0x5E)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x5E)]);
    CheckExternalEvents(cs7, 0x5523);
    // MOV DI,word ptr [BP + -0x5e] (1000_5520 / 0x15520)
    DI = UInt16[SS, (ushort)(BP - 0x5E)];
    CheckExternalEvents(cs7, 0x5525);
    // ADD DI,SI (1000_5523 / 0x15523)
    // DI += SI;
    DI = Alu16.Add(DI, SI);
    CheckExternalEvents(cs7, 0x552A);
    // MOV AL,byte ptr ES:[DI + 0x32ca] (1000_5525 / 0x15525)
    AL = UInt8[ES, (ushort)(DI + 0x32CA)];
    CheckExternalEvents(cs7, 0x552F);
    // MOV byte ptr ES:[DI + 0x32c6],AL (1000_552A / 0x1552A)
    UInt8[ES, (ushort)(DI + 0x32C6)] = AL;
    CheckExternalEvents(cs7, 0x5532);
    // INC word ptr [BP + -0x5e] (1000_552F / 0x1552F)
    UInt16[SS, (ushort)(BP - 0x5E)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x5E)]);
    CheckExternalEvents(cs7, 0x5535);
    // MOV DI,word ptr [BP + -0x5e] (1000_5532 / 0x15532)
    DI = UInt16[SS, (ushort)(BP - 0x5E)];
    CheckExternalEvents(cs7, 0x5537);
    // ADD DI,SI (1000_5535 / 0x15535)
    // DI += SI;
    DI = Alu16.Add(DI, SI);
    CheckExternalEvents(cs7, 0x553C);
    // MOV AL,byte ptr ES:[DI + 0x32ca] (1000_5537 / 0x15537)
    AL = UInt8[ES, (ushort)(DI + 0x32CA)];
    CheckExternalEvents(cs7, 0x5541);
    // MOV byte ptr ES:[DI + 0x32c6],AL (1000_553C / 0x1553C)
    UInt8[ES, (ushort)(DI + 0x32C6)] = AL;
    CheckExternalEvents(cs7, 0x5544);
    // INC word ptr [BP + -0x5e] (1000_5541 / 0x15541)
    UInt16[SS, (ushort)(BP - 0x5E)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x5E)]);
    CheckExternalEvents(cs7, 0x5547);
    // MOV DI,word ptr [BP + -0x5e] (1000_5544 / 0x15544)
    DI = UInt16[SS, (ushort)(BP - 0x5E)];
    CheckExternalEvents(cs7, 0x5549);
    // ADD DI,SI (1000_5547 / 0x15547)
    // DI += SI;
    DI = Alu16.Add(DI, SI);
    CheckExternalEvents(cs7, 0x554E);
    // MOV AL,byte ptr ES:[DI + 0x32ca] (1000_5549 / 0x15549)
    AL = UInt8[ES, (ushort)(DI + 0x32CA)];
    CheckExternalEvents(cs7, 0x5553);
    // MOV byte ptr ES:[DI + 0x32c6],AL (1000_554E / 0x1554E)
    UInt8[ES, (ushort)(DI + 0x32C6)] = AL;
    CheckExternalEvents(cs7, 0x5556);
    // INC word ptr [BP + -0x5e] (1000_5553 / 0x15553)
    UInt16[SS, (ushort)(BP - 0x5E)]++;
    CheckExternalEvents(cs7, 0x555A);
    // CMP word ptr [BP + -0x5e],0x2c (1000_5556 / 0x15556)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x5E)], 0x2C);
    CheckExternalEvents(cs7, 0x555C);
    // JL 0x1000:5506 (1000_555A / 0x1555A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5506_15506;
    }
    CheckExternalEvents(cs7, 0x555F);
    // MOV AX,0x30 (1000_555C / 0x1555C)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x5562);
    // IMUL word ptr [BP + -0x5a] (1000_555F / 0x1555F)
    int resImul1000_555F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x5A)]);
    AX = (ushort)(resImul1000_555F);
    DX = (ushort)(resImul1000_555F >> 16);
    CheckExternalEvents(cs7, 0x5564);
    // MOV BX,AX (1000_5562 / 0x15562)
    BX = AX;
    CheckExternalEvents(cs7, 0x556A);
    // MOV byte ptr ES:[BX + 0x32f2],0xff (1000_5564 / 0x15564)
    UInt8[ES, (ushort)(BX + 0x32F2)] = 0xFF;
    label_1000_556A_1556A:
    CheckExternalEvents(cs7, 0x556D);
    // INC word ptr [BP + -0x5a] (1000_556A / 0x1556A)
    UInt16[SS, (ushort)(BP - 0x5A)]++;
    CheckExternalEvents(cs7, 0x5571);
    // CMP word ptr [BP + -0x5a],0xc (1000_556D / 0x1556D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x5A)], 0xC);
    CheckExternalEvents(cs7, 0x5573);
    // JGE 0x1000:5576 (1000_5571 / 0x15571)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5576_15576;
    }
    CheckExternalEvents(cs7, 0x5576);
    // JMP 0x1000:5488 (1000_5573 / 0x15573)
    goto label_1000_5488_15488;
    label_1000_5576_15576:
    CheckExternalEvents(cs7, 0x5579);
    // INC word ptr [BP + -0x4] (1000_5576 / 0x15576)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_1000_5579_15579:
    CheckExternalEvents(cs7, 0x557D);
    // CMP word ptr [BP + -0x4],0xc (1000_5579 / 0x15579)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0xC);
    CheckExternalEvents(cs7, 0x557F);
    // JL 0x1000:5582 (1000_557D / 0x1557D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5582_15582;
    }
    CheckExternalEvents(cs7, 0x5582);
    // JMP 0x1000:580e (1000_557F / 0x1557F)
    goto label_1000_580E_1580E;
    label_1000_5582_15582:
    CheckExternalEvents(cs7, 0x5586);
    // MOV ES,word ptr [0x5630] (1000_5582 / 0x15582)
    ES = UInt16[DS, 0x5630];
    CheckExternalEvents(cs7, 0x558C);
    // CMP word ptr ES:[0x14a],0x0 (1000_5586 / 0x15586)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs7, 0x558E);
    // JZ 0x1000:5576 (1000_558C / 0x1558C)
    if(ZeroFlag) {
      goto label_1000_5576_15576;
    }
    CheckExternalEvents(cs7, 0x5593);
    // MOV word ptr [BP + -0x44],0x0 (1000_558E / 0x1558E)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x0;
    CheckExternalEvents(cs7, 0x5597);
    // CMP word ptr [BP + -0x4],0x0 (1000_5593 / 0x15593)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs7, 0x5599);
    // JNZ 0x1000:559e (1000_5597 / 0x15597)
    if(!ZeroFlag) {
      goto label_1000_559E_1559E;
    }
    CheckExternalEvents(cs7, 0x559E);
    // MOV word ptr [BP + -0x44],0x1 (1000_5599 / 0x15599)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x1;
    label_1000_559E_1559E:
    CheckExternalEvents(cs7, 0x55A3);
    // MOV word ptr [BP + -0x2],0x0 (1000_559E / 0x1559E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_1000_55A3_155A3:
    CheckExternalEvents(cs7, 0x55A6);
    // MOV SI,word ptr [BP + -0x2] (1000_55A3 / 0x155A3)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x55A8);
    // SHL SI,0x1 (1000_55A6 / 0x155A6)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x55AC);
    // MOV ES,word ptr [0x5632] (1000_55A8 / 0x155A8)
    ES = UInt16[DS, 0x5632];
    CheckExternalEvents(cs7, 0x55B2);
    // CMP word ptr ES:[SI + 0x406a],0x0 (1000_55AC / 0x155AC)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x55B4);
    // JNZ 0x1000:55b7 (1000_55B2 / 0x155B2)
    if(!ZeroFlag) {
      goto label_1000_55B7_155B7;
    }
    CheckExternalEvents(cs7, 0x55B7);
    // JMP 0x1000:5753 (1000_55B4 / 0x155B4)
    goto label_1000_5753_15753;
    label_1000_55B7_155B7:
    CheckExternalEvents(cs7, 0x55BA);
    // MOV BX,word ptr [BP + -0x2] (1000_55B7 / 0x155B7)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x55BE);
    // MOV ES,word ptr [0x562e] (1000_55BA / 0x155BA)
    ES = UInt16[DS, 0x562E];
    CheckExternalEvents(cs7, 0x55C3);
    // MOV AL,byte ptr ES:[BX + 0x78] (1000_55BE / 0x155BE)
    AL = UInt8[ES, (ushort)(BX + 0x78)];
    CheckExternalEvents(cs7, 0x55C4);
    // CBW  (1000_55C3 / 0x155C3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x55C7);
    // MOV word ptr [BP + -0x20],AX (1000_55C4 / 0x155C4)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs7, 0x55C9);
    // MOV DI,AX (1000_55C7 / 0x155C7)
    DI = AX;
    CheckExternalEvents(cs7, 0x55CB);
    // SHL DI,0x1 (1000_55C9 / 0x155C9)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs7, 0x55CE);
    // MOV AX,0x18 (1000_55CB / 0x155CB)
    AX = 0x18;
    CheckExternalEvents(cs7, 0x55D0);
    // IMUL BX (1000_55CE / 0x155CE)
    int resImul1000_55CE = Alu16.Imul((short)AX, (short)BX);
    AX = (ushort)(resImul1000_55CE);
    DX = (ushort)(resImul1000_55CE >> 16);
    CheckExternalEvents(cs7, 0x55D2);
    // ADD DI,AX (1000_55D0 / 0x155D0)
    // DI += AX;
    DI = Alu16.Add(DI, AX);
    CheckExternalEvents(cs7, 0x55D6);
    // MOV ES,word ptr [0x5634] (1000_55D2 / 0x155D2)
    ES = UInt16[DS, 0x5634];
    CheckExternalEvents(cs7, 0x55DB);
    // MOV AL,byte ptr ES:[DI + 0x40b4] (1000_55D6 / 0x155D6)
    AL = UInt8[ES, (ushort)(DI + 0x40B4)];
    CheckExternalEvents(cs7, 0x55DC);
    // CBW  (1000_55DB / 0x155DB)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x55DF);
    // MOV word ptr [BP + -0xe],AX (1000_55DC / 0x155DC)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs7, 0x55E4);
    // MOV AL,byte ptr ES:[DI + 0x40b5] (1000_55DF / 0x155DF)
    AL = UInt8[ES, (ushort)(DI + 0x40B5)];
    CheckExternalEvents(cs7, 0x55E5);
    // CBW  (1000_55E4 / 0x155E4)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x55E8);
    // MOV word ptr [BP + -0x14],AX (1000_55E5 / 0x155E5)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs7, 0x55EC);
    // CMP word ptr [BP + -0xe],0x2 (1000_55E8 / 0x155E8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x2);
    CheckExternalEvents(cs7, 0x55EE);
    // JNZ 0x1000:55f1 (1000_55EC / 0x155EC)
    if(!ZeroFlag) {
      goto label_1000_55F1_155F1;
    }
    CheckExternalEvents(cs7, 0x55F1);
    // JMP 0x1000:5753 (1000_55EE / 0x155EE)
    goto label_1000_5753_15753;
    label_1000_55F1_155F1:
    CheckExternalEvents(cs7, 0x55F4);
    // CMP AX,0x2 (1000_55F1 / 0x155F1)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs7, 0x55F6);
    // JNZ 0x1000:55f9 (1000_55F4 / 0x155F4)
    if(!ZeroFlag) {
      goto label_1000_55F9_155F9;
    }
    CheckExternalEvents(cs7, 0x55F9);
    // JMP 0x1000:5753 (1000_55F6 / 0x155F6)
    goto label_1000_5753_15753;
    label_1000_55F9_155F9:
    CheckExternalEvents(cs7, 0x55FC);
    // MOV AX,word ptr [BP + -0xe] (1000_55F9 / 0x155F9)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0x55FF);
    // OR AX,word ptr [BP + -0x14] (1000_55FC / 0x155FC)
    // AX |= UInt16[SS, (ushort)(BP - 0x14)];
    AX = Alu16.Or(AX, UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs7, 0x5601);
    // JNZ 0x1000:5604 (1000_55FF / 0x155FF)
    if(!ZeroFlag) {
      goto label_1000_5604_15604;
    }
    CheckExternalEvents(cs7, 0x5604);
    // JMP 0x1000:5753 (1000_5601 / 0x15601)
    goto label_1000_5753_15753;
    label_1000_5604_15604:
    CheckExternalEvents(cs7, 0x5608);
    // MOV ES,word ptr [0x562a] (1000_5604 / 0x15604)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x560C);
    // MOV AX,ES:[0xa44b] (1000_5608 / 0x15608)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x560F);
    // MOV word ptr [BP + -0x24],AX (1000_560C / 0x1560C)
    UInt16[SS, (ushort)(BP - 0x24)] = AX;
    CheckExternalEvents(cs7, 0x5613);
    // MOV ES,word ptr [0x562c] (1000_560F / 0x1560F)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x5617);
    // MOV AX,ES:[0xa44d] (1000_5613 / 0x15613)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x561A);
    // MOV word ptr [BP + -0x2e],AX (1000_5617 / 0x15617)
    UInt16[SS, (ushort)(BP - 0x2E)] = AX;
    CheckExternalEvents(cs7, 0x561E);
    // MOV ES,word ptr [0x5636] (1000_561A / 0x1561A)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x5623);
    // PUSH word ptr ES:[SI + 0x4036] (1000_561E / 0x1561E)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs7, 0x5627);
    // MOV ES,word ptr [0x5638] (1000_5623 / 0x15623)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x562C);
    // PUSH word ptr ES:[SI + 0x4004] (1000_5627 / 0x15627)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs7, 0x5631);
    // CALLF 0x0000:2f6f (1000_562C / 0x1562C)
    FarCall(cs7, 0x5631, ghidra_guess_0000_2F6F_02F6F);
    CheckExternalEvents(cs7, 0x5634);
    // ADD SP,0x4 (1000_5631 / 0x15631)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x5637);
    // PUSH word ptr [BP + -0x14] (1000_5634 / 0x15634)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs7, 0x563A);
    // PUSH word ptr [BP + -0xe] (1000_5637 / 0x15637)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs7, 0x563F);
    // CALLF 0x0000:301b (1000_563A / 0x1563A)
    FarCall(cs7, 0x563F, unknown_0170_191B_0301B);
    CheckExternalEvents(cs7, 0x5642);
    // ADD SP,0x4 (1000_563F / 0x1563F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x5645);
    // MOV AX,0x1 (1000_5642 / 0x15642)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x5646);
    // PUSH AX (1000_5645 / 0x15645)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x5649);
    // PUSH word ptr [BP + -0x14] (1000_5646 / 0x15646)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs7, 0x564C);
    // PUSH word ptr [BP + -0xe] (1000_5649 / 0x15649)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs7, 0x564F);
    // PUSH word ptr [BP + -0x2] (1000_564C / 0x1564C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x5654);
    // CALLF 0x1000:10bb (1000_564F / 0x1564F)
    FarCall(cs7, 0x5654, unknown_0FA1_16AB_110BB);
    CheckExternalEvents(cs7, 0x5657);
    // ADD SP,0x8 (1000_5654 / 0x15654)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x5659);
    // OR AX,AX (1000_5657 / 0x15657)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x565B);
    // JZ 0x1000:565e (1000_5659 / 0x15659)
    if(ZeroFlag) {
      goto label_1000_565E_1565E;
    }
    CheckExternalEvents(cs7, 0x565E);
    // JMP 0x1000:573d (1000_565B / 0x1565B)
    goto label_1000_573D_1573D;
    label_1000_565E_1565E:
    CheckExternalEvents(cs7, 0x5663);
    // MOV word ptr [BP + -0x44],0x1 (1000_565E / 0x1565E)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x1;
    CheckExternalEvents(cs7, 0x5666);
    // MOV BX,word ptr [BP + -0x2] (1000_5663 / 0x15663)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x566A);
    // MOV ES,word ptr [0x562e] (1000_5666 / 0x15666)
    ES = UInt16[DS, 0x562E];
    CheckExternalEvents(cs7, 0x566F);
    // INC byte ptr ES:[BX + 0x78] (1000_566A / 0x1566A)
    UInt8[ES, (ushort)(BX + 0x78)] = Alu8.Inc(UInt8[ES, (ushort)(BX + 0x78)]);
    CheckExternalEvents(cs7, 0x5672);
    // MOV SI,word ptr [BP + -0x2] (1000_566F / 0x1566F)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x5674);
    // SHL SI,0x1 (1000_5672 / 0x15672)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x5678);
    // MOV ES,word ptr [0x562a] (1000_5674 / 0x15674)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x567C);
    // MOV AX,ES:[0xa44b] (1000_5678 / 0x15678)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x5680);
    // MOV ES,word ptr [0x5638] (1000_567C / 0x1567C)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x5685);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_5680 / 0x15680)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs7, 0x5689);
    // MOV ES,word ptr [0x562c] (1000_5685 / 0x15685)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x568D);
    // MOV AX,ES:[0xa44d] (1000_5689 / 0x15689)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x5691);
    // MOV ES,word ptr [0x5636] (1000_568D / 0x1568D)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x5696);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_5691 / 0x15691)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs7, 0x5699);
    // MOV BX,word ptr [BP + -0x14] (1000_5696 / 0x15696)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs7, 0x569B);
    // SHL BX,0x1 (1000_5699 / 0x15699)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x569D);
    // SHL BX,0x1 (1000_569B / 0x1569B)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x56A0);
    // ADD BX,word ptr [BP + -0xe] (1000_569D / 0x1569D)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs7, 0x56A4);
    // MOV ES,word ptr [0x563a] (1000_56A0 / 0x156A0)
    ES = UInt16[DS, 0x563A];
    CheckExternalEvents(cs7, 0x56A9);
    // MOV AL,byte ptr ES:[BX + 0x2ed1] (1000_56A4 / 0x156A4)
    AL = UInt8[ES, (ushort)(BX + 0x2ED1)];
    CheckExternalEvents(cs7, 0x56AA);
    // CBW  (1000_56A9 / 0x156A9)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x56AD);
    // MOV word ptr [BP + -0x40],AX (1000_56AA / 0x156AA)
    UInt16[SS, (ushort)(BP - 0x40)] = AX;
    CheckExternalEvents(cs7, 0x56B1);
    // CMP word ptr [BP + -0xe],0x0 (1000_56AD / 0x156AD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs7, 0x56B3);
    // JNZ 0x1000:56bc (1000_56B1 / 0x156B1)
    if(!ZeroFlag) {
      goto label_1000_56BC_156BC;
    }
    CheckExternalEvents(cs7, 0x56B7);
    // CMP word ptr [BP + -0x14],0x0 (1000_56B3 / 0x156B3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x14)], 0x0);
    CheckExternalEvents(cs7, 0x56B9);
    // JNZ 0x1000:56bc (1000_56B7 / 0x156B7)
    if(!ZeroFlag) {
      goto label_1000_56BC_156BC;
    }
    CheckExternalEvents(cs7, 0x56BC);
    // JMP 0x1000:573d (1000_56B9 / 0x156B9)
    goto label_1000_573D_1573D;
    label_1000_56BC_156BC:
    CheckExternalEvents(cs7, 0x56BF);
    // MOV SI,word ptr [BP + -0x2] (1000_56BC / 0x156BC)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x56C2);
    // INC byte ptr [BP + SI + -0x78] (1000_56BF / 0x156BF)
    UInt8[SS, (ushort)(BP + SI - 0x78)] = Alu8.Inc(UInt8[SS, (ushort)(BP + SI - 0x78)]);
    CheckExternalEvents(cs7, 0x56C5);
    // MOV BX,word ptr [BP + -0x2] (1000_56C2 / 0x156C2)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x56C9);
    // MOV ES,word ptr [0x563c] (1000_56C5 / 0x156C5)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs7, 0x56CE);
    // MOV AL,byte ptr ES:[BX + 0x396c] (1000_56C9 / 0x156C9)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs7, 0x56CF);
    // CBW  (1000_56CE / 0x156CE)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x56D2);
    // CMP AX,word ptr [BP + -0x40] (1000_56CF / 0x156CF)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x40)]);
    CheckExternalEvents(cs7, 0x56D4);
    // JZ 0x1000:5711 (1000_56D2 / 0x156D2)
    if(ZeroFlag) {
      goto label_1000_5711_15711;
    }
    CheckExternalEvents(cs7, 0x56D7);
    // CMP BX,0x4 (1000_56D4 / 0x156D4)
    Alu16.Sub(BX, 0x4);
    CheckExternalEvents(cs7, 0x56D9);
    // JL 0x1000:56de (1000_56D7 / 0x156D7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_56DE_156DE;
    }
    CheckExternalEvents(cs7, 0x56DC);
    // CMP BX,0xc (1000_56D9 / 0x156D9)
    Alu16.Sub(BX, 0xC);
    CheckExternalEvents(cs7, 0x56DE);
    // JL 0x1000:56e3 (1000_56DC / 0x156DC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_56E3_156E3;
    }
    label_1000_56DE_156DE:
    CheckExternalEvents(cs7, 0x56E1);
    // CMP BX,0x10 (1000_56DE / 0x156DE)
    Alu16.Sub(BX, 0x10);
    CheckExternalEvents(cs7, 0x56E3);
    // JL 0x1000:56e7 (1000_56E1 / 0x156E1)
    if(SignFlag != OverflowFlag) {
      goto label_1000_56E7_156E7;
    }
    label_1000_56E3_156E3:
    CheckExternalEvents(cs7, 0x56E7);
    // ADD word ptr [BP + -0x40],0x8 (1000_56E3 / 0x156E3)
    // UInt16[SS, (ushort)(BP - 0x40)] += 0x8;
    UInt16[SS, (ushort)(BP - 0x40)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x40)], 0x8);
    label_1000_56E7_156E7:
    CheckExternalEvents(cs7, 0x56EA);
    // MOV BX,word ptr [BP + -0x40] (1000_56E7 / 0x156E7)
    BX = UInt16[SS, (ushort)(BP - 0x40)];
    CheckExternalEvents(cs7, 0x56EC);
    // SHL BX,0x1 (1000_56EA / 0x156EA)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x56EE);
    // SHL BX,0x1 (1000_56EC / 0x156EC)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x56F2);
    // MOV ES,word ptr [0x563e] (1000_56EE / 0x156EE)
    ES = UInt16[DS, 0x563E];
    CheckExternalEvents(cs7, 0x56F7);
    // MOV AX,word ptr ES:[BX + 0x25a] (1000_56F2 / 0x156F2)
    AX = UInt16[ES, (ushort)(BX + 0x25A)];
    CheckExternalEvents(cs7, 0x56FC);
    // MOV DX,word ptr ES:[BX + 0x25c] (1000_56F7 / 0x156F7)
    DX = UInt16[ES, (ushort)(BX + 0x25C)];
    CheckExternalEvents(cs7, 0x56FF);
    // MOV BX,word ptr [BP + -0x2] (1000_56FC / 0x156FC)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x5701);
    // SHL BX,0x1 (1000_56FF / 0x156FF)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x5703);
    // SHL BX,0x1 (1000_5701 / 0x15701)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x5707);
    // MOV ES,word ptr [0x5640] (1000_5703 / 0x15703)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs7, 0x570C);
    // MOV word ptr ES:[BX + 0x1f6],AX (1000_5707 / 0x15707)
    UInt16[ES, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs7, 0x5711);
    // MOV word ptr ES:[BX + 0x1f8],DX (1000_570C / 0x1570C)
    UInt16[ES, (ushort)(BX + 0x1F8)] = DX;
    label_1000_5711_15711:
    CheckExternalEvents(cs7, 0x5714);
    // PUSH word ptr [BP + -0x2] (1000_5711 / 0x15711)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x5719);
    // CALLF 0x0000:2e32 (1000_5714 / 0x15714)
    FarCall(cs7, 0x5719, unknown_0170_1732_02E32);
    CheckExternalEvents(cs7, 0x571C);
    // ADD SP,0x2 (1000_5719 / 0x15719)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x571F);
    // MOV BX,word ptr [BP + -0x2] (1000_571C / 0x1571C)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x5723);
    // MOV ES,word ptr [0x5642] (1000_571F / 0x1571F)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs7, 0x5728);
    // MOV byte ptr ES:[BX + 0x409a],AL (1000_5723 / 0x15723)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    CheckExternalEvents(cs7, 0x572B);
    // MOV BX,word ptr [BP + -0x2] (1000_5728 / 0x15728)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x572F);
    // MOV ES,word ptr [0x563c] (1000_572B / 0x1572B)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs7, 0x5734);
    // MOV AL,byte ptr ES:[BX + 0x396c] (1000_572F / 0x1572F)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs7, 0x5738);
    // MOV ES,word ptr [0x5644] (1000_5734 / 0x15734)
    ES = UInt16[DS, 0x5644];
    CheckExternalEvents(cs7, 0x573D);
    // MOV byte ptr ES:[BX + 0x3920],AL (1000_5738 / 0x15738)
    UInt8[ES, (ushort)(BX + 0x3920)] = AL;
    label_1000_573D_1573D:
    CheckExternalEvents(cs7, 0x5741);
    // MOV ES,word ptr [0x562a] (1000_573D / 0x1573D)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x5744);
    // MOV AX,word ptr [BP + -0x24] (1000_5741 / 0x15741)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs7, 0x5748);
    // MOV ES:[0xa44b],AX (1000_5744 / 0x15744)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x574C);
    // MOV ES,word ptr [0x562c] (1000_5748 / 0x15748)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x574F);
    // MOV AX,word ptr [BP + -0x2e] (1000_574C / 0x1574C)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs7, 0x5753);
    // MOV ES:[0xa44d],AX (1000_574F / 0x1574F)
    UInt16[ES, 0xA44D] = AX;
    label_1000_5753_15753:
    CheckExternalEvents(cs7, 0x5756);
    // INC word ptr [BP + -0x2] (1000_5753 / 0x15753)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs7, 0x575A);
    // CMP word ptr [BP + -0x2],0x18 (1000_5756 / 0x15756)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs7, 0x575C);
    // JGE 0x1000:575f (1000_575A / 0x1575A)
    if(SignFlag == OverflowFlag) {
      goto label_1000_575F_1575F;
    }
    CheckExternalEvents(cs7, 0x575F);
    // JMP 0x1000:55a3 (1000_575C / 0x1575C)
    goto label_1000_55A3_155A3;
    label_1000_575F_1575F:
    CheckExternalEvents(cs7, 0x5763);
    // CMP word ptr [BP + -0x44],0x0 (1000_575F / 0x1575F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x44)], 0x0);
    CheckExternalEvents(cs7, 0x5765);
    // JNZ 0x1000:5768 (1000_5763 / 0x15763)
    if(!ZeroFlag) {
      goto label_1000_5768_15768;
    }
    CheckExternalEvents(cs7, 0x5768);
    // JMP 0x1000:5806 (1000_5765 / 0x15765)
    goto label_1000_5806_15806;
    label_1000_5768_15768:
    CheckExternalEvents(cs7, 0x576C);
    // MOV ES,word ptr [0x5646] (1000_5768 / 0x15768)
    ES = UInt16[DS, 0x5646];
    CheckExternalEvents(cs7, 0x5772);
    // CMP word ptr ES:[0x2e3a],0x0 (1000_576C / 0x1576C)
    Alu16.Sub(UInt16[ES, 0x2E3A], 0x0);
    CheckExternalEvents(cs7, 0x5774);
    // JNZ 0x1000:5777 (1000_5772 / 0x15772)
    if(!ZeroFlag) {
      goto label_1000_5777_15777;
    }
    CheckExternalEvents(cs7, 0x5777);
    // JMP 0x1000:5806 (1000_5774 / 0x15774)
    goto label_1000_5806_15806;
    label_1000_5777_15777:
    CheckExternalEvents(cs7, 0x577C);
    // MOV word ptr [BP + -0x4c],0x4 (1000_5777 / 0x15777)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x4;
    CheckExternalEvents(cs7, 0x5780);
    // MOV ES,word ptr [0x5648] (1000_577C / 0x1577C)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs7, 0x5786);
    // CMP byte ptr ES:[0xc620],0x8 (1000_5780 / 0x15780)
    Alu8.Sub(UInt8[ES, 0xC620], 0x8);
    CheckExternalEvents(cs7, 0x5788);
    // JGE 0x1000:5790 (1000_5786 / 0x15786)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5790_15790;
    }
    CheckExternalEvents(cs7, 0x578C);
    // MOV AL,ES:[0xc620] (1000_5788 / 0x15788)
    AL = UInt8[ES, 0xC620];
    CheckExternalEvents(cs7, 0x578D);
    // CBW  (1000_578C / 0x1578C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x5790);
    // MOV word ptr [BP + -0x4c],AX (1000_578D / 0x1578D)
    UInt16[SS, (ushort)(BP - 0x4C)] = AX;
    label_1000_5790_15790:
    CheckExternalEvents(cs7, 0x5793);
    // MOV SI,word ptr [BP + -0x4c] (1000_5790 / 0x15790)
    SI = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs7, 0x5795);
    // SHL SI,0x1 (1000_5793 / 0x15793)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x5799);
    // MOV ES,word ptr [0x5636] (1000_5795 / 0x15795)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs7, 0x579E);
    // PUSH word ptr ES:[SI + 0x4036] (1000_5799 / 0x15799)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs7, 0x57A2);
    // MOV ES,word ptr [0x5638] (1000_579E / 0x1579E)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs7, 0x57A7);
    // PUSH word ptr ES:[SI + 0x4004] (1000_57A2 / 0x157A2)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs7, 0x57AC);
    // CALLF 0x0000:2ebb (1000_57A7 / 0x157A7)
    FarCall(cs7, 0x57AC, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x57AF);
    // ADD SP,0x4 (1000_57AC / 0x157AC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x57B3);
    // MOV ES,word ptr [0x562c] (1000_57AF / 0x157AF)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x57B8);
    // PUSH word ptr ES:[0xa44d] (1000_57B3 / 0x157B3)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs7, 0x57BC);
    // MOV ES,word ptr [0x562a] (1000_57B8 / 0x157B8)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x57C1);
    // PUSH word ptr ES:[0xa44b] (1000_57BC / 0x157BC)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs7, 0x57C6);
    // CALLF 0x1000:b204 (1000_57C1 / 0x157C1)
    FarCall(cs7, 0x57C6, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs7, 0x57C9);
    // ADD SP,0x4 (1000_57C6 / 0x157C6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x57CD);
    // MOV ES,word ptr [0x562a] (1000_57C9 / 0x157C9)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs7, 0x57D1);
    // MOV AX,ES:[0xa44b] (1000_57CD / 0x157CD)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x57D4);
    // MOV word ptr [BP + -0x10],AX (1000_57D1 / 0x157D1)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs7, 0x57D8);
    // MOV ES,word ptr [0x562c] (1000_57D4 / 0x157D4)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs7, 0x57DC);
    // MOV AX,ES:[0xa44d] (1000_57D8 / 0x157D8)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x57DF);
    // MOV word ptr [BP + -0x1a],AX (1000_57DC / 0x157DC)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs7, 0x57E1);
    // SUB AX,AX (1000_57DF / 0x157DF)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x57E2);
    // PUSH AX (1000_57E1 / 0x157E1)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x57E5);
    // MOV AX,0x4314 (1000_57E2 / 0x157E2)
    AX = 0x4314;
    CheckExternalEvents(cs7, 0x57E8);
    // MOV DX,0x2a02 (1000_57E5 / 0x157E5)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x57E9);
    // PUSH DX (1000_57E8 / 0x157E8)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x57EA);
    // PUSH AX (1000_57E9 / 0x157E9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x57EF);
    // CALLF 0x1000:bdbe (1000_57EA / 0x157EA)
    FarCall(cs7, 0x57EF, ghidra_guess_1000_BDBE_1BDBE);
    CheckExternalEvents(cs7, 0x57F2);
    // ADD SP,0x6 (1000_57EF / 0x157EF)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs7, 0x57F7);
    // CALLF 0x0000:3b0b (1000_57F2 / 0x157F2)
    FarCall(cs7, 0x57F7, unknown_0170_240B_03B0B);
    CheckExternalEvents(cs7, 0x57FC);
    // CALLF 0x1000:b7df (1000_57F7 / 0x157F7)
    FarCall(cs7, 0x57FC, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs7, 0x5801);
    // CALLF 0x0000:254b (1000_57FC / 0x157FC)
    FarCall(cs7, 0x5801, ghidra_guess_0000_254B_0254B);
    CheckExternalEvents(cs7, 0x5806);
    // CALLF 0x1000:9193 (1000_5801 / 0x15801)
    FarCall(cs7, 0x5806, unknown_18AD_06C3_19193);
    label_1000_5806_15806:
    CheckExternalEvents(cs7, 0x580B);
    // MOV word ptr [BP + -0x2],0x0 (1000_5806 / 0x15806)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x580E);
    // JMP 0x1000:5458 (1000_580B / 0x1580B)
    goto label_1000_5458_15458;
    label_1000_580E_1580E:
    CheckExternalEvents(cs7, 0x5812);
    // MOV ES,word ptr [0x5630] (1000_580E / 0x1580E)
    ES = UInt16[DS, 0x5630];
    CheckExternalEvents(cs7, 0x5818);
    // CMP word ptr ES:[0x14a],0x0 (1000_5812 / 0x15812)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs7, 0x581A);
    // JZ 0x1000:5828 (1000_5818 / 0x15818)
    if(ZeroFlag) {
      goto label_1000_5828_15828;
    }
    CheckExternalEvents(cs7, 0x581D);
    // PUSH word ptr [BP + -0x4a] (1000_581A / 0x1581A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4A)]);
    CheckExternalEvents(cs7, 0x5820);
    // PUSH word ptr [BP + -0x3e] (1000_581D / 0x1581D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x3E)]);
    CheckExternalEvents(cs7, 0x5825);
    // CALLF 0x0000:2ebb (1000_5820 / 0x15820)
    FarCall(cs7, 0x5825, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x5828);
    // ADD SP,0x4 (1000_5825 / 0x15825)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_5828_15828:
    CheckExternalEvents(cs7, 0x582C);
    // MOV ES,word ptr [0x5630] (1000_5828 / 0x15828)
    ES = UInt16[DS, 0x5630];
    CheckExternalEvents(cs7, 0x5832);
    // CMP word ptr ES:[0x14a],0x0 (1000_582C / 0x1582C)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs7, 0x5834);
    // JZ 0x1000:5841 (1000_5832 / 0x15832)
    if(ZeroFlag) {
      goto label_1000_5841_15841;
    }
    CheckExternalEvents(cs7, 0x5837);
    // LEA AX,[BP + -0x78] (1000_5834 / 0x15834)
    AX = (ushort)(BP - 0x78);
    CheckExternalEvents(cs7, 0x5838);
    // PUSH SS (1000_5837 / 0x15837)
    Stack.Push16(SS);
    CheckExternalEvents(cs7, 0x5839);
    // PUSH AX (1000_5838 / 0x15838)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x583E);
    // CALLF 0x1000:0673 (1000_5839 / 0x15839)
    FarCall(cs7, 0x583E, ghidra_guess_1000_0673_10673);
    CheckExternalEvents(cs7, 0x5841);
    // ADD SP,0x4 (1000_583E / 0x1583E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_5841_15841:
    CheckExternalEvents(cs7, 0x5842);
    // POP SI (1000_5841 / 0x15841)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x5843);
    // POP DI (1000_5842 / 0x15842)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x5845);
    // MOV SP,BP (1000_5843 / 0x15843)
    SP = BP;
    CheckExternalEvents(cs7, 0x5846);
    // POP BP (1000_5845 / 0x15845)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x5847);
    // RETF  (1000_5846 / 0x15846)
    return FarRet();
  }
  
}
