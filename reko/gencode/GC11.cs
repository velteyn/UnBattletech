namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_2F32_12F32(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2F32_12F32:
    CheckExternalEvents(cs7, 0x2F33);
    // PUSH BP (1000_2F32 / 0x12F32)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x2F35);
    // MOV BP,SP (1000_2F33 / 0x12F33)
    BP = SP;
    CheckExternalEvents(cs7, 0x2F38);
    // MOV AX,0x2 (1000_2F35 / 0x12F35)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x2F3D);
    // CALLF 0x1000:cecc (1000_2F38 / 0x12F38)
    FarCall(cs7, 0x2F3D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x2F3E);
    // PUSH SI (1000_2F3D / 0x12F3D)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x2F43);
    // MOV word ptr [BP + -0x2],0x0 (1000_2F3E / 0x12F3E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_1000_2F43_12F43:
    CheckExternalEvents(cs7, 0x2F46);
    // MOV SI,word ptr [BP + -0x2] (1000_2F43 / 0x12F43)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x2F49);
    // ADD SI,word ptr [BP + 0x6] (1000_2F46 / 0x12F46)
    // SI += UInt16[SS, (ushort)(BP + 0x6)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x2F4B);
    // MOV BX,SI (1000_2F49 / 0x12F49)
    BX = SI;
    CheckExternalEvents(cs7, 0x2F4D);
    // SHL BX,0x1 (1000_2F4B / 0x12F4B)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x2F51);
    // MOV ES,word ptr [0x55e0] (1000_2F4D / 0x12F4D)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs7, 0x2F57);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_2F51 / 0x12F51)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x2F59);
    // JZ 0x1000:2f65 (1000_2F57 / 0x12F57)
    if(ZeroFlag) {
      goto label_1000_2F65_12F65;
    }
    CheckExternalEvents(cs7, 0x2F5B);
    // SUB AX,AX (1000_2F59 / 0x12F59)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x2F5C);
    // PUSH AX (1000_2F5B / 0x12F5B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2F5D);
    // PUSH SI (1000_2F5C / 0x12F5C)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x2F62);
    // CALLF 0x0000:fdbb (1000_2F5D / 0x12F5D)
    throw FailAsUntested("Could not find a valid function at address 0FA1_03AB / 0xFDBB");
    CheckExternalEvents(cs7, 0x2F65);
    // ADD SP,0x4 (1000_2F62 / 0x12F62)
    SP += 0x4;
    label_1000_2F65_12F65:
    CheckExternalEvents(cs7, 0x2F68);
    // INC word ptr [BP + -0x2] (1000_2F65 / 0x12F65)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs7, 0x2F6C);
    // CMP word ptr [BP + -0x2],0xc (1000_2F68 / 0x12F68)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xC);
    CheckExternalEvents(cs7, 0x2F6E);
    // JL 0x1000:2f43 (1000_2F6C / 0x12F6C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_2F43_12F43;
    }
    CheckExternalEvents(cs7, 0x2F6F);
    // POP SI (1000_2F6E / 0x12F6E)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x2F71);
    // MOV SP,BP (1000_2F6F / 0x12F6F)
    SP = BP;
    CheckExternalEvents(cs7, 0x2F72);
    // POP BP (1000_2F71 / 0x12F71)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x2F73);
    // RETF  (1000_2F72 / 0x12F72)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_2F73_12F73(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_2F73_12F73:
    CheckExternalEvents(cs7, 0x2F74);
    // PUSH BP (1000_2F73 / 0x12F73)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x2F76);
    // MOV BP,SP (1000_2F74 / 0x12F74)
    BP = SP;
    CheckExternalEvents(cs7, 0x2F79);
    // MOV AX,0xc (1000_2F76 / 0x12F76)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x2F7E);
    // CALLF 0x1000:cecc (1000_2F79 / 0x12F79)
    FarCall(cs7, 0x2F7E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x2F7F);
    // PUSH SI (1000_2F7E / 0x12F7E)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x2F82);
    // MOV AX,0x1 (1000_2F7F / 0x12F7F)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x2F85);
    // MOV word ptr [BP + -0x4],AX (1000_2F82 / 0x12F82)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x2F88);
    // MOV word ptr [BP + -0xc],AX (1000_2F85 / 0x12F85)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x2F8D);
    // MOV word ptr [BP + -0xa],0x0 (1000_2F88 / 0x12F88)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs7, 0x2F8F);
    // JMP 0x1000:2f92 (1000_2F8D / 0x12F8D)
    goto label_1000_2F92_12F92;
    label_1000_2F8F_12F8F:
    CheckExternalEvents(cs7, 0x2F92);
    // INC word ptr [BP + -0xa] (1000_2F8F / 0x12F8F)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    label_1000_2F92_12F92:
    CheckExternalEvents(cs7, 0x2F96);
    // CMP word ptr [BP + -0xa],0xc (1000_2F92 / 0x12F92)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0xC);
    CheckExternalEvents(cs7, 0x2F98);
    // JGE 0x1000:2fa9 (1000_2F96 / 0x12F96)
    if(SignFlag == OverflowFlag) {
      goto label_1000_2FA9_12FA9;
    }
    CheckExternalEvents(cs7, 0x2F9B);
    // MOV BX,word ptr [BP + -0xa] (1000_2F98 / 0x12F98)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x2F9D);
    // SHL BX,0x1 (1000_2F9B / 0x12F9B)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x2FA1);
    // MOV ES,word ptr [0x55e0] (1000_2F9D / 0x12F9D)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs7, 0x2FA7);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_2FA1 / 0x12FA1)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x2FA9);
    // JZ 0x1000:2f8f (1000_2FA7 / 0x12FA7)
    if(ZeroFlag) {
      goto label_1000_2F8F_12F8F;
    }
    label_1000_2FA9_12FA9:
    CheckExternalEvents(cs7, 0x2FAB);
    // SUB AX,AX (1000_2FA9 / 0x12FA9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x2FAE);
    // MOV word ptr [BP + -0x2],AX (1000_2FAB / 0x12FAB)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x2FB1);
    // MOV word ptr [BP + -0x6],AX (1000_2FAE / 0x12FAE)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x2FB5);
    // MOV ES,word ptr [0x55f2] (1000_2FB1 / 0x12FB1)
    ES = UInt16[DS, 0x55F2];
    CheckExternalEvents(cs7, 0x2FBA);
    // CMP word ptr ES:[0x90],AX (1000_2FB5 / 0x12FB5)
    Alu16.Sub(UInt16[ES, 0x90], AX);
    CheckExternalEvents(cs7, 0x2FBC);
    // JNZ 0x1000:2fbf (1000_2FBA / 0x12FBA)
    if(!ZeroFlag) {
      goto label_1000_2FBF_12FBF;
    }
    CheckExternalEvents(cs7, 0x2FBF);
    // JMP 0x1000:3213 (1000_2FBC / 0x12FBC)
    goto label_1000_3213_13213;
    label_1000_2FBF_12FBF:
    CheckExternalEvents(cs7, 0x2FC2);
    // MOV BX,word ptr [BP + -0xa] (1000_2FBF / 0x12FBF)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x2FC6);
    // MOV ES,word ptr [0x55e6] (1000_2FC2 / 0x12FC2)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs7, 0x2FCC);
    // MOV byte ptr ES:[BX + 0x3994],0x0 (1000_2FC6 / 0x12FC6)
    UInt8[ES, (ushort)(BX + 0x3994)] = 0x0;
    CheckExternalEvents(cs7, 0x2FCF);
    // JMP 0x1000:3213 (1000_2FCC / 0x12FCC)
    goto label_1000_3213_13213;
    label_1000_2FCF_12FCF:
    CheckExternalEvents(cs7, 0x2FD2);
    // MOV AX,0x4 (1000_2FCF / 0x12FCF)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x2FD3);
    // PUSH AX (1000_2FD2 / 0x12FD2)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2FD8);
    // CALLF 0x1000:7ee1 (1000_2FD3 / 0x12FD3)
    FarCall(cs7, 0x2FD8, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x2FDB);
    // ADD SP,0x2 (1000_2FD8 / 0x12FD8)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x2FE0);
    // CALLF 0x1000:7fe8 (1000_2FDB / 0x12FDB)
    FarCall(cs7, 0x2FE0, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x2FE2);
    // SUB AX,AX (1000_2FE0 / 0x12FE0)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x2FE3);
    // PUSH AX (1000_2FE2 / 0x12FE2)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2FE4);
    // PUSH AX (1000_2FE3 / 0x12FE3)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x2FE7);
    // PUSH word ptr [BP + -0xa] (1000_2FE4 / 0x12FE4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x2FEC);
    // CALLF 0x0000:8a98 (1000_2FE7 / 0x12FE7)
    FarCall(cs7, 0x2FEC, ghidra_guess_0000_8A98_08A98);
    CheckExternalEvents(cs7, 0x2FEF);
    // ADD SP,0x6 (1000_2FEC / 0x12FEC)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs7, 0x2FF3);
    // MOV ES,word ptr [0x55ec] (1000_2FEF / 0x12FEF)
    ES = UInt16[DS, 0x55EC];
    CheckExternalEvents(cs7, 0x2FFA);
    // MOV word ptr ES:[0x37fe],0xf (1000_2FF3 / 0x12FF3)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs7, 0x2FFD);
    // MOV BX,word ptr [BP + -0xa] (1000_2FFA / 0x12FFA)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x3001);
    // MOV ES,word ptr [0x55e6] (1000_2FFD / 0x12FFD)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs7, 0x3007);
    // CMP byte ptr ES:[BX + 0x3994],0x0 (1000_3001 / 0x13001)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3994)], 0x0);
    CheckExternalEvents(cs7, 0x3009);
    // JZ 0x1000:3024 (1000_3007 / 0x13007)
    if(ZeroFlag) {
      goto label_1000_3024_13024;
    }
    CheckExternalEvents(cs7, 0x300C);
    // MOV AX,0x3a42 (1000_3009 / 0x13009)
    AX = 0x3A42;
    CheckExternalEvents(cs7, 0x300D);
    // PUSH DS (1000_300C / 0x1300C)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x300E);
    // PUSH AX (1000_300D / 0x1300D)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3013);
    // CALLF 0x1000:8055 (1000_300E / 0x1300E)
    FarCall(cs7, 0x3013, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3016);
    // ADD SP,0x4 (1000_3013 / 0x13013)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3019);
    // MOV AX,0x1 (1000_3016 / 0x13016)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x301A);
    // PUSH AX (1000_3019 / 0x13019)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x301D);
    // PUSH word ptr [BP + -0xa] (1000_301A / 0x1301A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x3022);
    // CALLF 0x0000:fdbb (1000_301D / 0x1301D)
    throw FailAsUntested("Could not find a valid function at address 0FA1_03AB / 0xFDBB");
    CheckExternalEvents(cs7, 0x3024);
    // JMP 0x1000:302f (1000_3022 / 0x13022)
    goto label_1000_302F_1302F;
    label_1000_3024_13024:
    CheckExternalEvents(cs7, 0x3027);
    // MOV AX,0x1 (1000_3024 / 0x13024)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x3028);
    // PUSH AX (1000_3027 / 0x13027)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x302B);
    // PUSH word ptr [BP + -0xa] (1000_3028 / 0x13028)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x302C);
    // PUSH CS (1000_302B / 0x1302B)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x302F);
    // CALL 0x1000:3224 (1000_302C / 0x1302C)
    NearCall(cs7, 0x302F, ghidra_guess_1000_3224_13224);
    label_1000_302F_1302F:
    CheckExternalEvents(cs7, 0x3032);
    // ADD SP,0x4 (1000_302F / 0x1302F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3035);
    // MOV AX,0x3 (1000_3032 / 0x13032)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x3036);
    // PUSH AX (1000_3035 / 0x13035)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x303B);
    // CALLF 0x1000:7ee1 (1000_3036 / 0x13036)
    FarCall(cs7, 0x303B, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x303E);
    // ADD SP,0x2 (1000_303B / 0x1303B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3043);
    // CALLF 0x1000:7fe8 (1000_303E / 0x1303E)
    FarCall(cs7, 0x3043, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x3047);
    // MOV ES,word ptr [0x55ec] (1000_3043 / 0x13043)
    ES = UInt16[DS, 0x55EC];
    CheckExternalEvents(cs7, 0x304E);
    // MOV word ptr ES:[0x37fe],0xf (1000_3047 / 0x13047)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs7, 0x3052);
    // CMP word ptr [BP + -0xa],0x4 (1000_304E / 0x1304E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x3054);
    // JGE 0x1000:306e (1000_3052 / 0x13052)
    if(SignFlag == OverflowFlag) {
      goto label_1000_306E_1306E;
    }
    CheckExternalEvents(cs7, 0x3057);
    // MOV AX,0x3a6f (1000_3054 / 0x13054)
    AX = 0x3A6F;
    CheckExternalEvents(cs7, 0x3058);
    // PUSH DS (1000_3057 / 0x13057)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3059);
    // PUSH AX (1000_3058 / 0x13058)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x305E);
    // CALLF 0x1000:8055 (1000_3059 / 0x13059)
    FarCall(cs7, 0x305E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3061);
    // ADD SP,0x4 (1000_305E / 0x1305E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3065);
    // MOV ES,word ptr [0x560c] (1000_3061 / 0x13061)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x306C);
    // MOV word ptr ES:[0xc6],0xa (1000_3065 / 0x13065)
    UInt16[ES, 0xC6] = 0xA;
    CheckExternalEvents(cs7, 0x306E);
    // JMP 0x1000:3086 (1000_306C / 0x1306C)
    goto label_1000_3086_13086;
    label_1000_306E_1306E:
    CheckExternalEvents(cs7, 0x3071);
    // MOV AX,0x3abc (1000_306E / 0x1306E)
    AX = 0x3ABC;
    CheckExternalEvents(cs7, 0x3072);
    // PUSH DS (1000_3071 / 0x13071)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3073);
    // PUSH AX (1000_3072 / 0x13072)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3078);
    // CALLF 0x1000:8055 (1000_3073 / 0x13073)
    FarCall(cs7, 0x3078, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x307B);
    // ADD SP,0x4 (1000_3078 / 0x13078)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x307F);
    // MOV ES,word ptr [0x560c] (1000_307B / 0x1307B)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x3086);
    // MOV word ptr ES:[0xc6],0x8 (1000_307F / 0x1307F)
    UInt16[ES, 0xC6] = 0x8;
    label_1000_3086_13086:
    CheckExternalEvents(cs7, 0x308A);
    // CMP word ptr [BP + -0x4],0x0 (1000_3086 / 0x13086)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs7, 0x308C);
    // JZ 0x1000:309a (1000_308A / 0x1308A)
    if(ZeroFlag) {
      goto label_1000_309A_1309A;
    }
    CheckExternalEvents(cs7, 0x3090);
    // MOV AX,ES:[0xc6] (1000_308C / 0x1308C)
    AX = UInt16[ES, 0xC6];
    CheckExternalEvents(cs7, 0x3091);
    // DEC AX (1000_3090 / 0x13090)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs7, 0x3095);
    // MOV ES:[0xc8],AX (1000_3091 / 0x13091)
    UInt16[ES, 0xC8] = AX;
    CheckExternalEvents(cs7, 0x309A);
    // MOV word ptr [BP + -0x4],0x0 (1000_3095 / 0x13095)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_1000_309A_1309A:
    CheckExternalEvents(cs7, 0x309F);
    // CALLF 0x0000:412b (1000_309A / 0x1309A)
    FarCall(cs7, 0x309F, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs7, 0x30A2);
    // MOV AX,0x3 (1000_309F / 0x1309F)
    AX = 0x3;
    CheckExternalEvents(cs7, 0x30A3);
    // PUSH AX (1000_30A2 / 0x130A2)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x30A8);
    // CALLF 0x1000:87be (1000_30A3 / 0x130A3)
    FarCall(cs7, 0x30A8, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs7, 0x30AB);
    // ADD SP,0x2 (1000_30A8 / 0x130A8)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x30AE);
    // MOV word ptr [BP + -0xc],AX (1000_30AB / 0x130AB)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x30B2);
    // MOV ES,word ptr [0x560c] (1000_30AE / 0x130AE)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x30B7);
    // MOV SI,word ptr ES:[0xc6] (1000_30B2 / 0x130B2)
    SI = UInt16[ES, 0xC6];
    CheckExternalEvents(cs7, 0x30BA);
    // SUB SI,0x2 (1000_30B7 / 0x130B7)
    SI -= 0x2;
    CheckExternalEvents(cs7, 0x30BC);
    // CMP AX,SI (1000_30BA / 0x130BA)
    Alu16.Sub(AX, SI);
    CheckExternalEvents(cs7, 0x30BE);
    // JL 0x1000:30ca (1000_30BC / 0x130BC)
    if(SignFlag != OverflowFlag) {
      goto label_1000_30CA_130CA;
    }
    CheckExternalEvents(cs7, 0x30C1);
    // INC word ptr [BP + -0x6] (1000_30BE / 0x130BE)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs7, 0x30C3);
    // CMP AX,SI (1000_30C1 / 0x130C1)
    Alu16.Sub(AX, SI);
    CheckExternalEvents(cs7, 0x30C5);
    // JNZ 0x1000:30ca (1000_30C3 / 0x130C3)
    if(!ZeroFlag) {
      goto label_1000_30CA_130CA;
    }
    CheckExternalEvents(cs7, 0x30CA);
    // MOV word ptr [BP + -0x2],0x1 (1000_30C5 / 0x130C5)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_1000_30CA_130CA:
    CheckExternalEvents(cs7, 0x30CE);
    // CMP word ptr [BP + -0xa],0x4 (1000_30CA / 0x130CA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x30D0);
    // JGE 0x1000:30d6 (1000_30CE / 0x130CE)
    if(SignFlag == OverflowFlag) {
      goto label_1000_30D6_130D6;
    }
    CheckExternalEvents(cs7, 0x30D4);
    // CMP word ptr [BP + -0xc],0x3 (1000_30D0 / 0x130D0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs7, 0x30D6);
    // JL 0x1000:30e2 (1000_30D4 / 0x130D4)
    if(SignFlag != OverflowFlag) {
      goto label_1000_30E2_130E2;
    }
    label_1000_30D6_130D6:
    CheckExternalEvents(cs7, 0x30DA);
    // CMP word ptr [BP + -0xa],0x4 (1000_30D6 / 0x130D6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x30DC);
    // JL 0x1000:30ef (1000_30DA / 0x130DA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_30EF_130EF;
    }
    CheckExternalEvents(cs7, 0x30E0);
    // CMP word ptr [BP + -0xc],0x0 (1000_30DC / 0x130DC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs7, 0x30E2);
    // JNZ 0x1000:30ef (1000_30E0 / 0x130E0)
    if(!ZeroFlag) {
      goto label_1000_30EF_130EF;
    }
    label_1000_30E2_130E2:
    CheckExternalEvents(cs7, 0x30E5);
    // PUSH word ptr [BP + -0xc] (1000_30E2 / 0x130E2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x30E8);
    // PUSH word ptr [BP + -0xa] (1000_30E5 / 0x130E5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x30E9);
    // PUSH CS (1000_30E8 / 0x130E8)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x30EC);
    // CALL 0x1000:36cf (1000_30E9 / 0x130E9)
    NearCall(cs7, 0x30EC, ghidra_guess_1000_36CF_136CF);
    CheckExternalEvents(cs7, 0x30EF);
    // ADD SP,0x4 (1000_30EC / 0x130EC)
    SP += 0x4;
    label_1000_30EF_130EF:
    CheckExternalEvents(cs7, 0x30F3);
    // CMP word ptr [BP + -0xa],0x4 (1000_30EF / 0x130EF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x30F5);
    // JL 0x1000:3138 (1000_30F3 / 0x130F3)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3138_13138;
    }
    CheckExternalEvents(cs7, 0x30F9);
    // CMP word ptr [BP + -0xc],0x1 (1000_30F5 / 0x130F5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x1);
    CheckExternalEvents(cs7, 0x30FB);
    // JNZ 0x1000:3138 (1000_30F9 / 0x130F9)
    if(!ZeroFlag) {
      goto label_1000_3138_13138;
    }
    CheckExternalEvents(cs7, 0x3100);
    // MOV word ptr [BP + -0x8],0x0 (1000_30FB / 0x130FB)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_1000_3100_13100:
    CheckExternalEvents(cs7, 0x3103);
    // MOV AX,0x30 (1000_3100 / 0x13100)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x3106);
    // IMUL word ptr [BP + -0xa] (1000_3103 / 0x13103)
    int resImul1000_3103 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul1000_3103);
    DX = (ushort)(resImul1000_3103 >> 16);
    CheckExternalEvents(cs7, 0x3108);
    // MOV BX,AX (1000_3106 / 0x13106)
    BX = AX;
    CheckExternalEvents(cs7, 0x310B);
    // ADD BX,word ptr [BP + -0x8] (1000_3108 / 0x13108)
    // BX += UInt16[SS, (ushort)(BP - 0x8)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0x310F);
    // MOV ES,word ptr [0x55dc] (1000_310B / 0x1310B)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x3115);
    // MOV byte ptr ES:[BX + 0x32c6],0xff (1000_310F / 0x1310F)
    UInt8[ES, (ushort)(BX + 0x32C6)] = 0xFF;
    CheckExternalEvents(cs7, 0x3118);
    // INC word ptr [BP + -0x8] (1000_3115 / 0x13115)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs7, 0x311C);
    // CMP word ptr [BP + -0x8],0x30 (1000_3118 / 0x13118)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x30);
    CheckExternalEvents(cs7, 0x311E);
    // JL 0x1000:3100 (1000_311C / 0x1311C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3100_13100;
    }
    CheckExternalEvents(cs7, 0x3121);
    // MOV BX,word ptr [BP + -0xa] (1000_311E / 0x1311E)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x3125);
    // MOV ES,word ptr [0x55e6] (1000_3121 / 0x13121)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs7, 0x312B);
    // MOV byte ptr ES:[BX + 0x3994],0x0 (1000_3125 / 0x13125)
    UInt8[ES, (ushort)(BX + 0x3994)] = 0x0;
    CheckExternalEvents(cs7, 0x312D);
    // SUB AX,AX (1000_312B / 0x1312B)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x312E);
    // PUSH AX (1000_312D / 0x1312D)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3131);
    // PUSH word ptr [BP + -0xa] (1000_312E / 0x1312E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x3132);
    // PUSH CS (1000_3131 / 0x13131)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x3135);
    // CALL 0x1000:3224 (1000_3132 / 0x13132)
    NearCall(cs7, 0x3135, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs7, 0x3138);
    // ADD SP,0x4 (1000_3135 / 0x13135)
    SP += 0x4;
    label_1000_3138_13138:
    CheckExternalEvents(cs7, 0x313C);
    // CMP word ptr [BP + -0xa],0x4 (1000_3138 / 0x13138)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x313E);
    // JGE 0x1000:314e (1000_313C / 0x1313C)
    if(SignFlag == OverflowFlag) {
      goto label_1000_314E_1314E;
    }
    CheckExternalEvents(cs7, 0x3142);
    // CMP word ptr [BP + -0xc],0x4 (1000_313E / 0x1313E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs7, 0x3144);
    // JNZ 0x1000:314e (1000_3142 / 0x13142)
    if(!ZeroFlag) {
      goto label_1000_314E_1314E;
    }
    CheckExternalEvents(cs7, 0x3147);
    // PUSH word ptr [BP + -0xa] (1000_3144 / 0x13144)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x3148);
    // PUSH CS (1000_3147 / 0x13147)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x314B);
    // CALL 0x1000:3ce1 (1000_3148 / 0x13148)
    NearCall(cs7, 0x314B, ghidra_guess_1000_3CE1_13CE1);
    CheckExternalEvents(cs7, 0x314E);
    // ADD SP,0x2 (1000_314B / 0x1314B)
    SP += 0x2;
    label_1000_314E_1314E:
    CheckExternalEvents(cs7, 0x3152);
    // CMP word ptr [BP + -0xa],0x4 (1000_314E / 0x1314E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x3154);
    // JGE 0x1000:315a (1000_3152 / 0x13152)
    if(SignFlag == OverflowFlag) {
      goto label_1000_315A_1315A;
    }
    CheckExternalEvents(cs7, 0x3158);
    // CMP word ptr [BP + -0xc],0x5 (1000_3154 / 0x13154)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x5);
    CheckExternalEvents(cs7, 0x315A);
    // JZ 0x1000:3166 (1000_3158 / 0x13158)
    if(ZeroFlag) {
      goto label_1000_3166_13166;
    }
    label_1000_315A_1315A:
    CheckExternalEvents(cs7, 0x315E);
    // CMP word ptr [BP + -0xa],0x4 (1000_315A / 0x1315A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x3160);
    // JL 0x1000:3181 (1000_315E / 0x1315E)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3181_13181;
    }
    CheckExternalEvents(cs7, 0x3164);
    // CMP word ptr [BP + -0xc],0x3 (1000_3160 / 0x13160)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs7, 0x3166);
    // JNZ 0x1000:3181 (1000_3164 / 0x13164)
    if(!ZeroFlag) {
      goto label_1000_3181_13181;
    }
    label_1000_3166_13166:
    CheckExternalEvents(cs7, 0x316A);
    // MOV ES,word ptr [0x55f2] (1000_3166 / 0x13166)
    ES = UInt16[DS, 0x55F2];
    CheckExternalEvents(cs7, 0x3170);
    // CMP word ptr ES:[0x90],0x0 (1000_316A / 0x1316A)
    Alu16.Sub(UInt16[ES, 0x90], 0x0);
    CheckExternalEvents(cs7, 0x3172);
    // JNZ 0x1000:3181 (1000_3170 / 0x13170)
    if(!ZeroFlag) {
      goto label_1000_3181_13181;
    }
    CheckExternalEvents(cs7, 0x3175);
    // MOV AX,0x1 (1000_3172 / 0x13172)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x3176);
    // PUSH AX (1000_3175 / 0x13175)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3179);
    // PUSH word ptr [BP + -0xa] (1000_3176 / 0x13176)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x317E);
    // CALLF 0x0000:fdbb (1000_3179 / 0x13179)
    throw FailAsUntested("Could not find a valid function at address 0FA1_03AB / 0xFDBB");
    CheckExternalEvents(cs7, 0x3181);
    // ADD SP,0x4 (1000_317E / 0x1317E)
    SP += 0x4;
    label_1000_3181_13181:
    CheckExternalEvents(cs7, 0x3185);
    // CMP word ptr [BP + -0xa],0x4 (1000_3181 / 0x13181)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x3187);
    // JGE 0x1000:318d (1000_3185 / 0x13185)
    if(SignFlag == OverflowFlag) {
      goto label_1000_318D_1318D;
    }
    CheckExternalEvents(cs7, 0x318B);
    // CMP word ptr [BP + -0xc],0x3 (1000_3187 / 0x13187)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x3);
    CheckExternalEvents(cs7, 0x318D);
    // JZ 0x1000:3199 (1000_318B / 0x1318B)
    if(ZeroFlag) {
      goto label_1000_3199_13199;
    }
    label_1000_318D_1318D:
    CheckExternalEvents(cs7, 0x3191);
    // CMP word ptr [BP + -0xa],0x4 (1000_318D / 0x1318D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x3193);
    // JL 0x1000:31a4 (1000_3191 / 0x13191)
    if(SignFlag != OverflowFlag) {
      goto label_1000_31A4_131A4;
    }
    CheckExternalEvents(cs7, 0x3197);
    // CMP word ptr [BP + -0xc],0x2 (1000_3193 / 0x13193)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x2);
    CheckExternalEvents(cs7, 0x3199);
    // JNZ 0x1000:31a4 (1000_3197 / 0x13197)
    if(!ZeroFlag) {
      goto label_1000_31A4_131A4;
    }
    label_1000_3199_13199:
    CheckExternalEvents(cs7, 0x319C);
    // PUSH word ptr [BP + -0xa] (1000_3199 / 0x13199)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x31A1);
    // CALLF 0x0000:eb34 (1000_319C / 0x1319C)
    FarCall(cs7, 0x31A1, ghidra_guess_0000_EB34_0EB34);
    CheckExternalEvents(cs7, 0x31A4);
    // ADD SP,0x2 (1000_31A1 / 0x131A1)
    SP += 0x2;
    label_1000_31A4_131A4:
    CheckExternalEvents(cs7, 0x31A8);
    // CMP word ptr [BP + -0xa],0x4 (1000_31A4 / 0x131A4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x31AA);
    // JGE 0x1000:31b0 (1000_31A8 / 0x131A8)
    if(SignFlag == OverflowFlag) {
      goto label_1000_31B0_131B0;
    }
    CheckExternalEvents(cs7, 0x31AE);
    // CMP word ptr [BP + -0xc],0x6 (1000_31AA / 0x131AA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x6);
    CheckExternalEvents(cs7, 0x31B0);
    // JZ 0x1000:31bc (1000_31AE / 0x131AE)
    if(ZeroFlag) {
      goto label_1000_31BC_131BC;
    }
    label_1000_31B0_131B0:
    CheckExternalEvents(cs7, 0x31B4);
    // CMP word ptr [BP + -0xa],0x4 (1000_31B0 / 0x131B0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x31B6);
    // JL 0x1000:31c6 (1000_31B4 / 0x131B4)
    if(SignFlag != OverflowFlag) {
      goto label_1000_31C6_131C6;
    }
    CheckExternalEvents(cs7, 0x31BA);
    // CMP word ptr [BP + -0xc],0x4 (1000_31B6 / 0x131B6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs7, 0x31BC);
    // JNZ 0x1000:31c6 (1000_31BA / 0x131BA)
    if(!ZeroFlag) {
      goto label_1000_31C6_131C6;
    }
    label_1000_31BC_131BC:
    CheckExternalEvents(cs7, 0x31BF);
    // PUSH word ptr [BP + -0xa] (1000_31BC / 0x131BC)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x31C0);
    // PUSH CS (1000_31BF / 0x131BF)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x31C3);
    // CALL 0x1000:4041 (1000_31C0 / 0x131C0)
    NearCall(cs7, 0x31C3, ghidra_guess_1000_4041_14041);
    CheckExternalEvents(cs7, 0x31C6);
    // ADD SP,0x2 (1000_31C3 / 0x131C3)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_31C6_131C6:
    CheckExternalEvents(cs7, 0x31CA);
    // MOV ES,word ptr [0x560c] (1000_31C6 / 0x131C6)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x31CE);
    // MOV AX,ES:[0xc6] (1000_31CA / 0x131CA)
    AX = UInt16[ES, 0xC6];
    CheckExternalEvents(cs7, 0x31D1);
    // SUB AX,0x3 (1000_31CE / 0x131CE)
    AX -= 0x3;
    CheckExternalEvents(cs7, 0x31D4);
    // CMP AX,word ptr [BP + -0xc] (1000_31D1 / 0x131D1)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x31D6);
    // JNZ 0x1000:3213 (1000_31D4 / 0x131D4)
    if(!ZeroFlag) {
      goto label_1000_3213_13213;
    }
    label_1000_31D6_131D6:
    CheckExternalEvents(cs7, 0x31D9);
    // INC word ptr [BP + -0xa] (1000_31D6 / 0x131D6)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    CheckExternalEvents(cs7, 0x31DD);
    // CMP word ptr [BP + -0xa],0xb (1000_31D9 / 0x131D9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0xB);
    CheckExternalEvents(cs7, 0x31DF);
    // JLE 0x1000:31e4 (1000_31DD / 0x131DD)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_31E4_131E4;
    }
    CheckExternalEvents(cs7, 0x31E4);
    // MOV word ptr [BP + -0xa],0x0 (1000_31DF / 0x131DF)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    label_1000_31E4_131E4:
    CheckExternalEvents(cs7, 0x31E7);
    // MOV BX,word ptr [BP + -0xa] (1000_31E4 / 0x131E4)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x31E9);
    // SHL BX,0x1 (1000_31E7 / 0x131E7)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x31ED);
    // MOV ES,word ptr [0x55e0] (1000_31E9 / 0x131E9)
    ES = UInt16[DS, 0x55E0];
    CheckExternalEvents(cs7, 0x31F3);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_31ED / 0x131ED)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x31F5);
    // JZ 0x1000:31d6 (1000_31F3 / 0x131F3)
    if(ZeroFlag) {
      goto label_1000_31D6_131D6;
    }
    CheckExternalEvents(cs7, 0x31F9);
    // CMP word ptr [BP + -0xa],0x4 (1000_31F5 / 0x131F5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs7, 0x31FB);
    // JL 0x1000:3208 (1000_31F9 / 0x131F9)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3208_13208;
    }
    CheckExternalEvents(cs7, 0x31FF);
    // MOV ES,word ptr [0x560c] (1000_31FB / 0x131FB)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x3206);
    // MOV word ptr ES:[0xc8],0x5 (1000_31FF / 0x131FF)
    UInt16[ES, 0xC8] = 0x5;
    CheckExternalEvents(cs7, 0x3208);
    // JMP 0x1000:3213 (1000_3206 / 0x13206)
    goto label_1000_3213_13213;
    label_1000_3208_13208:
    CheckExternalEvents(cs7, 0x320C);
    // MOV ES,word ptr [0x560c] (1000_3208 / 0x13208)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x3213);
    // MOV word ptr ES:[0xc8],0x7 (1000_320C / 0x1320C)
    UInt16[ES, 0xC8] = 0x7;
    label_1000_3213_13213:
    CheckExternalEvents(cs7, 0x3217);
    // CMP word ptr [BP + -0x6],0x0 (1000_3213 / 0x13213)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x3219);
    // JNZ 0x1000:321c (1000_3217 / 0x13217)
    if(!ZeroFlag) {
      goto label_1000_321C_1321C;
    }
    CheckExternalEvents(cs7, 0x321C);
    // JMP 0x1000:2fcf (1000_3219 / 0x13219)
    goto label_1000_2FCF_12FCF;
    label_1000_321C_1321C:
    CheckExternalEvents(cs7, 0x321F);
    // MOV AX,word ptr [BP + -0x2] (1000_321C / 0x1321C)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x3220);
    // POP SI (1000_321F / 0x1321F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3222);
    // MOV SP,BP (1000_3220 / 0x13220)
    SP = BP;
    CheckExternalEvents(cs7, 0x3223);
    // POP BP (1000_3222 / 0x13222)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3224);
    // RETF  (1000_3223 / 0x13223)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_3224_13224(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3224_13224:
    CheckExternalEvents(cs7, 0x3225);
    // PUSH BP (1000_3224 / 0x13224)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x3227);
    // MOV BP,SP (1000_3225 / 0x13225)
    BP = SP;
    CheckExternalEvents(cs7, 0x322A);
    // MOV AX,0x26 (1000_3227 / 0x13227)
    AX = 0x26;
    CheckExternalEvents(cs7, 0x322F);
    // CALLF 0x1000:cecc (1000_322A / 0x1322A)
    FarCall(cs7, 0x322F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x3230);
    // PUSH DI (1000_322F / 0x1322F)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x3231);
    // PUSH SI (1000_3230 / 0x13230)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x3234);
    // MOV SI,word ptr [BP + 0x6] (1000_3231 / 0x13231)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x3236);
    // SHL SI,0x1 (1000_3234 / 0x13234)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x323A);
    // MOV ES,word ptr [0x55d2] (1000_3236 / 0x13236)
    ES = UInt16[DS, 0x55D2];
    CheckExternalEvents(cs7, 0x323F);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_323A / 0x1323A)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x3242);
    // MOV word ptr [BP + -0x6],AX (1000_323F / 0x1323F)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x3246);
    // MOV ES,word ptr [0x55d6] (1000_3242 / 0x13242)
    ES = UInt16[DS, 0x55D6];
    CheckExternalEvents(cs7, 0x324B);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_3246 / 0x13246)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs7, 0x324E);
    // MOV word ptr [BP + -0xa],AX (1000_324B / 0x1324B)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x3252);
    // CMP word ptr [BP + 0x8],0x0 (1000_324E / 0x1324E)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs7, 0x3254);
    // JZ 0x1000:3284 (1000_3252 / 0x13252)
    if(ZeroFlag) {
      goto label_1000_3284_13284;
    }
    CheckExternalEvents(cs7, 0x3255);
    // PUSH AX (1000_3254 / 0x13254)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3258);
    // PUSH word ptr [BP + -0x6] (1000_3255 / 0x13255)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs7, 0x325D);
    // CALLF 0x0000:2ebb (1000_3258 / 0x13258)
    FarCall(cs7, 0x325D, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs7, 0x3260);
    // ADD SP,0x4 (1000_325D / 0x1325D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3264);
    // MOV ES,word ptr [0x55ce] (1000_3260 / 0x13260)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x3269);
    // PUSH word ptr ES:[0xa44d] (1000_3264 / 0x13264)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs7, 0x326D);
    // MOV ES,word ptr [0x55cc] (1000_3269 / 0x13269)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x3272);
    // PUSH word ptr ES:[0xa44b] (1000_326D / 0x1326D)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs7, 0x3277);
    // CALLF 0x1000:b204 (1000_3272 / 0x13272)
    FarCall(cs7, 0x3277, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs7, 0x327A);
    // ADD SP,0x4 (1000_3277 / 0x13277)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x327F);
    // CALLF 0x1000:b7df (1000_327A / 0x1327A)
    FarCall(cs7, 0x327F, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs7, 0x3284);
    // CALLF 0x0000:254b (1000_327F / 0x1327F)
    FarCall(cs7, 0x3284, ghidra_guess_0000_254B_0254B);
    label_1000_3284_13284:
    CheckExternalEvents(cs7, 0x3289);
    // MOV word ptr [BP + -0x6],0x1 (1000_3284 / 0x13284)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    CheckExternalEvents(cs7, 0x328B);
    // SUB AX,AX (1000_3289 / 0x13289)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x328E);
    // MOV word ptr [BP + -0x4],AX (1000_328B / 0x1328B)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x3291);
    // MOV word ptr [BP + -0x2],AX (1000_328E / 0x1328E)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x3295);
    // CMP word ptr [BP + 0x6],0x4 (1000_3291 / 0x13291)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x3297);
    // JL 0x1000:32a3 (1000_3295 / 0x13295)
    if(SignFlag != OverflowFlag) {
      goto label_1000_32A3_132A3;
    }
    CheckExternalEvents(cs7, 0x329B);
    // CMP word ptr [BP + 0x6],0xc (1000_3297 / 0x13297)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x329D);
    // JL 0x1000:32b2 (1000_329B / 0x1329B)
    if(SignFlag != OverflowFlag) {
      goto label_1000_32B2_132B2;
    }
    CheckExternalEvents(cs7, 0x32A1);
    // CMP word ptr [BP + 0x6],0xf (1000_329D / 0x1329D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xF);
    CheckExternalEvents(cs7, 0x32A3);
    // JG 0x1000:32b2 (1000_32A1 / 0x132A1)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_32B2_132B2;
    }
    label_1000_32A3_132A3:
    CheckExternalEvents(cs7, 0x32A8);
    // MOV word ptr [BP + -0x6],0x3 (1000_32A3 / 0x132A3)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x3;
    CheckExternalEvents(cs7, 0x32AD);
    // MOV word ptr [BP + -0x2],0xffff (1000_32A8 / 0x132A8)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xFFFF;
    CheckExternalEvents(cs7, 0x32B2);
    // MOV word ptr [BP + -0x4],0xfffe (1000_32AD / 0x132AD)
    UInt16[SS, (ushort)(BP - 0x4)] = 0xFFFE;
    label_1000_32B2_132B2:
    CheckExternalEvents(cs7, 0x32B7);
    // CALLF 0x1000:9193 (1000_32B2 / 0x132B2)
    FarCall(cs7, 0x32B7, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs7, 0x32BB);
    // MOV ES,word ptr [0x560e] (1000_32B7 / 0x132B7)
    ES = UInt16[DS, 0x560E];
    CheckExternalEvents(cs7, 0x32C2);
    // MOV word ptr ES:[0xb782],0x1 (1000_32BB / 0x132BB)
    UInt16[ES, 0xB782] = 0x1;
    CheckExternalEvents(cs7, 0x32C7);
    // MOV word ptr [BP + -0x8],0x0 (1000_32C2 / 0x132C2)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs7, 0x32C9);
    // JMP 0x1000:32ec (1000_32C7 / 0x132C7)
    goto label_1000_32EC_132EC;
    label_1000_32C9_132C9:
    CheckExternalEvents(cs7, 0x32CC);
    // MOV AX,0xf (1000_32C9 / 0x132C9)
    AX = 0xF;
    CheckExternalEvents(cs7, 0x32CD);
    // PUSH AX (1000_32CC / 0x132CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x32D0);
    // PUSH word ptr [BP + -0x6] (1000_32CD / 0x132CD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs7, 0x32D3);
    // MOV AX,word ptr [BP + -0x8] (1000_32D0 / 0x132D0)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x32D6);
    // ADD AX,word ptr [BP + -0x4] (1000_32D3 / 0x132D3)
    AX += UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x32D9);
    // ADD AX,0xc (1000_32D6 / 0x132D6)
    // AX += 0xC;
    AX = Alu16.Add(AX, 0xC);
    CheckExternalEvents(cs7, 0x32DA);
    // PUSH AX (1000_32D9 / 0x132D9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x32DD);
    // MOV AX,word ptr [BP + -0x2] (1000_32DA / 0x132DA)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x32E0);
    // ADD AX,0x1a (1000_32DD / 0x132DD)
    // AX += 0x1A;
    AX = Alu16.Add(AX, 0x1A);
    CheckExternalEvents(cs7, 0x32E1);
    // PUSH AX (1000_32E0 / 0x132E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x32E6);
    // CALLF 0x1000:ca77 (1000_32E1 / 0x132E1)
    FarCall(cs7, 0x32E6, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs7, 0x32E9);
    // ADD SP,0x8 (1000_32E6 / 0x132E6)
    SP += 0x8;
    CheckExternalEvents(cs7, 0x32EC);
    // INC word ptr [BP + -0x8] (1000_32E9 / 0x132E9)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    label_1000_32EC_132EC:
    CheckExternalEvents(cs7, 0x32EF);
    // MOV AX,word ptr [BP + -0x6] (1000_32EC / 0x132EC)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0x32F2);
    // CMP word ptr [BP + -0x8],AX (1000_32EF / 0x132EF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs7, 0x32F4);
    // JL 0x1000:32c9 (1000_32F2 / 0x132F2)
    if(SignFlag != OverflowFlag) {
      goto label_1000_32C9_132C9;
    }
    CheckExternalEvents(cs7, 0x32F8);
    // CMP word ptr [BP + 0x6],0xc (1000_32F4 / 0x132F4)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x32FA);
    // JL 0x1000:32fd (1000_32F8 / 0x132F8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_32FD_132FD;
    }
    CheckExternalEvents(cs7, 0x32FD);
    // JMP 0x1000:33e5 (1000_32FA / 0x132FA)
    goto label_1000_33E5_133E5;
    label_1000_32FD_132FD:
    CheckExternalEvents(cs7, 0x3301);
    // CMP word ptr [BP + 0x6],0x4 (1000_32FD / 0x132FD)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x3303);
    // JGE 0x1000:3322 (1000_3301 / 0x13301)
    if(SignFlag == OverflowFlag) {
      goto label_1000_3322_13322;
    }
    CheckExternalEvents(cs7, 0x3306);
    // MOV AX,0x30 (1000_3303 / 0x13303)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x3309);
    // IMUL word ptr [BP + 0x6] (1000_3306 / 0x13306)
    int resImul1000_3306 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3306);
    DX = (ushort)(resImul1000_3306 >> 16);
    CheckExternalEvents(cs7, 0x330B);
    // MOV BX,AX (1000_3309 / 0x13309)
    BX = AX;
    CheckExternalEvents(cs7, 0x330F);
    // MOV ES,word ptr [0x55dc] (1000_330B / 0x1330B)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x3314);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_330F / 0x1330F)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x3315);
    // CBW  (1000_3314 / 0x13314)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3316);
    // PUSH AX (1000_3315 / 0x13315)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3319);
    // PUSH word ptr [BP + 0x6] (1000_3316 / 0x13316)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x331A);
    // PUSH CS (1000_3319 / 0x13319)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x331D);
    // CALL 0x1000:3d6c (1000_331A / 0x1331A)
    NearCall(cs7, 0x331D, ghidra_guess_1000_3D6C_13D6C);
    CheckExternalEvents(cs7, 0x3320);
    // ADD SP,0x4 (1000_331D / 0x1331D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3322);
    // JMP 0x1000:332c (1000_3320 / 0x13320)
    goto label_1000_332C_1332C;
    label_1000_3322_13322:
    CheckExternalEvents(cs7, 0x3325);
    // PUSH word ptr [BP + 0x6] (1000_3322 / 0x13322)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x3326);
    // PUSH CS (1000_3325 / 0x13325)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x3329);
    // CALL 0x1000:3f24 (1000_3326 / 0x13326)
    NearCall(cs7, 0x3329, ghidra_guess_1000_3F24_13F24);
    CheckExternalEvents(cs7, 0x332C);
    // ADD SP,0x2 (1000_3329 / 0x13329)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_332C_1332C:
    CheckExternalEvents(cs7, 0x332F);
    // PUSH word ptr [BP + 0x6] (1000_332C / 0x1332C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x3330);
    // PUSH CS (1000_332F / 0x1332F)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x3333);
    // CALL 0x1000:33eb (1000_3330 / 0x13330)
    NearCall(cs7, 0x3333, ghidra_guess_1000_33EB_133EB);
    CheckExternalEvents(cs7, 0x3336);
    // ADD SP,0x2 (1000_3333 / 0x13333)
    SP += 0x2;
    CheckExternalEvents(cs7, 0x3338);
    // SUB AX,AX (1000_3336 / 0x13336)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x333B);
    // MOV word ptr [BP + -0x8],AX (1000_3338 / 0x13338)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x333E);
    // MOV byte ptr [BP + -0xd],AL (1000_333B / 0x1333B)
    UInt8[SS, (ushort)(BP - 0xD)] = AL;
    CheckExternalEvents(cs7, 0x3343);
    // MOV word ptr [BP + -0x6],0x1a (1000_333E / 0x1333E)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1A;
    CheckExternalEvents(cs7, 0x3348);
    // MOV word ptr [BP + -0xa],0xc (1000_3343 / 0x13343)
    UInt16[SS, (ushort)(BP - 0xA)] = 0xC;
    CheckExternalEvents(cs7, 0x334A);
    // JMP 0x1000:33b3 (1000_3348 / 0x13348)
    goto label_1000_33B3_133B3;
    label_1000_334A_1334A:
    CheckExternalEvents(cs7, 0x334E);
    // CMP word ptr [BP + -0x8],0x18 (1000_334A / 0x1334A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x18);
    CheckExternalEvents(cs7, 0x3350);
    // JGE 0x1000:33cf (1000_334E / 0x1334E)
    if(SignFlag == OverflowFlag) {
      goto label_1000_33CF_133CF;
    }
    CheckExternalEvents(cs7, 0x3353);
    // MOV BX,word ptr [BP + -0x8] (1000_3350 / 0x13350)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x3356);
    // INC word ptr [BP + -0x8] (1000_3353 / 0x13353)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs7, 0x3358);
    // ADD BX,SI (1000_3356 / 0x13356)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x335C);
    // MOV ES,word ptr [0x55d8] (1000_3358 / 0x13358)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs7, 0x3361);
    // MOV AL,byte ptr ES:[BX + 0x40b4] (1000_335C / 0x1335C)
    AL = UInt8[ES, (ushort)(BX + 0x40B4)];
    CheckExternalEvents(cs7, 0x3362);
    // CBW  (1000_3361 / 0x13361)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3365);
    // MOV word ptr [BP + -0x2],AX (1000_3362 / 0x13362)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x3368);
    // MOV BX,word ptr [BP + -0x8] (1000_3365 / 0x13365)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x336B);
    // INC word ptr [BP + -0x8] (1000_3368 / 0x13368)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs7, 0x336D);
    // ADD BX,SI (1000_336B / 0x1336B)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x3372);
    // MOV AL,byte ptr ES:[BX + 0x40b4] (1000_336D / 0x1336D)
    AL = UInt8[ES, (ushort)(BX + 0x40B4)];
    CheckExternalEvents(cs7, 0x3373);
    // CBW  (1000_3372 / 0x13372)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3376);
    // MOV word ptr [BP + -0x4],AX (1000_3373 / 0x13373)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x3379);
    // MOV AX,word ptr [BP + -0x2] (1000_3376 / 0x13376)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x337C);
    // ADD word ptr [BP + -0x6],AX (1000_3379 / 0x13379)
    // UInt16[SS, (ushort)(BP - 0x6)] += AX;
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x6)], AX);
    CheckExternalEvents(cs7, 0x337F);
    // MOV AX,word ptr [BP + -0x4] (1000_337C / 0x1337C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3382);
    // ADD word ptr [BP + -0xa],AX (1000_337F / 0x1337F)
    UInt16[SS, (ushort)(BP - 0xA)] += AX;
    CheckExternalEvents(cs7, 0x3385);
    // INC word ptr [BP + -0x4] (1000_3382 / 0x13382)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs7, 0x3388);
    // MOV DI,word ptr [BP + -0x4] (1000_3385 / 0x13385)
    DI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x338A);
    // SHL DI,0x1 (1000_3388 / 0x13388)
    DI <<= 0x1;
    CheckExternalEvents(cs7, 0x338C);
    // SHL DI,0x1 (1000_338A / 0x1338A)
    DI <<= 0x1;
    CheckExternalEvents(cs7, 0x338F);
    // INC word ptr [BP + -0x2] (1000_338C / 0x1338C)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x3392);
    // MOV BX,word ptr [BP + -0x2] (1000_338F / 0x1338F)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x3396);
    // MOV AL,byte ptr [BX + DI + 0x3b06] (1000_3392 / 0x13392)
    AL = UInt8[DS, (ushort)(BX + DI + 0x3B06)];
    CheckExternalEvents(cs7, 0x3399);
    // MOV byte ptr [BP + -0xe],AL (1000_3396 / 0x13396)
    UInt8[SS, (ushort)(BP - 0xE)] = AL;
    CheckExternalEvents(cs7, 0x339B);
    // SUB AX,AX (1000_3399 / 0x13399)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x339C);
    // PUSH AX (1000_339B / 0x1339B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x339F);
    // MOV AX,0xf (1000_339C / 0x1339C)
    AX = 0xF;
    CheckExternalEvents(cs7, 0x33A0);
    // PUSH AX (1000_339F / 0x1339F)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x33A3);
    // PUSH word ptr [BP + -0xa] (1000_33A0 / 0x133A0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x33A6);
    // PUSH word ptr [BP + -0x6] (1000_33A3 / 0x133A3)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs7, 0x33A9);
    // LEA AX,[BP + -0xe] (1000_33A6 / 0x133A6)
    AX = (ushort)(BP - 0xE);
    CheckExternalEvents(cs7, 0x33AA);
    // PUSH SS (1000_33A9 / 0x133A9)
    Stack.Push16(SS);
    CheckExternalEvents(cs7, 0x33AB);
    // PUSH AX (1000_33AA / 0x133AA)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x33B0);
    // CALLF 0x1000:8ba5 (1000_33AB / 0x133AB)
    FarCall(cs7, 0x33B0, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs7, 0x33B3);
    // ADD SP,0xc (1000_33B0 / 0x133B0)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    label_1000_33B3_133B3:
    CheckExternalEvents(cs7, 0x33B6);
    // MOV AX,0x18 (1000_33B3 / 0x133B3)
    AX = 0x18;
    CheckExternalEvents(cs7, 0x33B9);
    // IMUL word ptr [BP + 0x6] (1000_33B6 / 0x133B6)
    int resImul1000_33B6 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_33B6);
    DX = (ushort)(resImul1000_33B6 >> 16);
    CheckExternalEvents(cs7, 0x33BB);
    // MOV SI,AX (1000_33B9 / 0x133B9)
    SI = AX;
    CheckExternalEvents(cs7, 0x33BE);
    // MOV BX,word ptr [BP + -0x8] (1000_33BB / 0x133BB)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x33C0);
    // ADD BX,SI (1000_33BE / 0x133BE)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x33C4);
    // MOV ES,word ptr [0x55d8] (1000_33C0 / 0x133C0)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs7, 0x33CA);
    // CMP byte ptr ES:[BX + 0x40b4],0x2 (1000_33C4 / 0x133C4)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x40B4)], 0x2);
    CheckExternalEvents(cs7, 0x33CC);
    // JZ 0x1000:33cf (1000_33CA / 0x133CA)
    if(ZeroFlag) {
      goto label_1000_33CF_133CF;
    }
    CheckExternalEvents(cs7, 0x33CF);
    // JMP 0x1000:334a (1000_33CC / 0x133CC)
    goto label_1000_334A_1334A;
    label_1000_33CF_133CF:
    CheckExternalEvents(cs7, 0x33D3);
    // MOV ES,word ptr [0x5610] (1000_33CF / 0x133CF)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x33D6);
    // MOV AX,word ptr [BP + -0x6] (1000_33D3 / 0x133D3)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0x33DA);
    // MOV ES:[0x3778],AX (1000_33D6 / 0x133D6)
    UInt16[ES, 0x3778] = AX;
    CheckExternalEvents(cs7, 0x33DE);
    // MOV ES,word ptr [0x5612] (1000_33DA / 0x133DA)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x33E1);
    // MOV AX,word ptr [BP + -0xa] (1000_33DE / 0x133DE)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x33E5);
    // MOV ES:[0x377a],AX (1000_33E1 / 0x133E1)
    UInt16[ES, 0x377A] = AX;
    label_1000_33E5_133E5:
    CheckExternalEvents(cs7, 0x33E6);
    // POP SI (1000_33E5 / 0x133E5)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x33E7);
    // POP DI (1000_33E6 / 0x133E6)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x33E9);
    // MOV SP,BP (1000_33E7 / 0x133E7)
    SP = BP;
    CheckExternalEvents(cs7, 0x33EA);
    // POP BP (1000_33E9 / 0x133E9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x33EB);
    // RETF  (1000_33EA / 0x133EA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_33EB_133EB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_33EB_133EB:
    CheckExternalEvents(cs7, 0x33EC);
    // PUSH BP (1000_33EB / 0x133EB)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x33EE);
    // MOV BP,SP (1000_33EC / 0x133EC)
    BP = SP;
    CheckExternalEvents(cs7, 0x33F1);
    // MOV AX,0x2a (1000_33EE / 0x133EE)
    AX = 0x2A;
    CheckExternalEvents(cs7, 0x33F6);
    // CALLF 0x1000:cecc (1000_33F1 / 0x133F1)
    FarCall(cs7, 0x33F6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x33F7);
    // PUSH DI (1000_33F6 / 0x133F6)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x33F8);
    // PUSH SI (1000_33F7 / 0x133F7)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x33FD);
    // MOV word ptr [BP + -0x20],0x0 (1000_33F8 / 0x133F8)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x0;
    label_1000_33FD_133FD:
    CheckExternalEvents(cs7, 0x3400);
    // MOV AX,0x18 (1000_33FD / 0x133FD)
    AX = 0x18;
    CheckExternalEvents(cs7, 0x3403);
    // IMUL word ptr [BP + 0x6] (1000_3400 / 0x13400)
    int resImul1000_3400 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3400);
    DX = (ushort)(resImul1000_3400 >> 16);
    CheckExternalEvents(cs7, 0x3405);
    // MOV BX,AX (1000_3403 / 0x13403)
    BX = AX;
    CheckExternalEvents(cs7, 0x3408);
    // ADD BX,word ptr [BP + -0x20] (1000_3405 / 0x13405)
    // BX += UInt16[SS, (ushort)(BP - 0x20)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs7, 0x340C);
    // MOV ES,word ptr [0x55d8] (1000_3408 / 0x13408)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs7, 0x3412);
    // MOV byte ptr ES:[BX + 0x40b4],0x2 (1000_340C / 0x1340C)
    UInt8[ES, (ushort)(BX + 0x40B4)] = 0x2;
    CheckExternalEvents(cs7, 0x3415);
    // INC word ptr [BP + -0x20] (1000_3412 / 0x13412)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs7, 0x3419);
    // CMP word ptr [BP + -0x20],0x18 (1000_3415 / 0x13415)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x18);
    CheckExternalEvents(cs7, 0x341B);
    // JL 0x1000:33fd (1000_3419 / 0x13419)
    if(SignFlag != OverflowFlag) {
      goto label_1000_33FD_133FD;
    }
    CheckExternalEvents(cs7, 0x341D);
    // SUB AX,AX (1000_341B / 0x1341B)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3420);
    // MOV word ptr [BP + -0x26],AX (1000_341D / 0x1341D)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs7, 0x3423);
    // MOV word ptr [BP + -0x12],AX (1000_3420 / 0x13420)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs7, 0x3426);
    // MOV word ptr [BP + -0x20],AX (1000_3423 / 0x13423)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs7, 0x3429);
    // MOV word ptr [BP + -0xc],AX (1000_3426 / 0x13426)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x342D);
    // MOV ES,word ptr [0x55cc] (1000_3429 / 0x13429)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x3431);
    // MOV AX,ES:[0xa44b] (1000_342D / 0x1342D)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x3435);
    // MOV ES,word ptr [0x5614] (1000_3431 / 0x13431)
    ES = UInt16[DS, 0x5614];
    CheckExternalEvents(cs7, 0x3439);
    // MOV ES:[0xe486],AX (1000_3435 / 0x13435)
    UInt16[ES, 0xE486] = AX;
    CheckExternalEvents(cs7, 0x343D);
    // MOV ES,word ptr [0x55ce] (1000_3439 / 0x13439)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x3441);
    // MOV AX,ES:[0xa44d] (1000_343D / 0x1343D)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x3445);
    // MOV ES,word ptr [0x5616] (1000_3441 / 0x13441)
    ES = UInt16[DS, 0x5616];
    CheckExternalEvents(cs7, 0x3449);
    // MOV ES:[0xe488],AX (1000_3445 / 0x13445)
    UInt16[ES, 0xE488] = AX;
    CheckExternalEvents(cs7, 0x344E);
    // MOV word ptr [BP + -0x8],0x1a (1000_3449 / 0x13449)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1A;
    CheckExternalEvents(cs7, 0x3453);
    // MOV word ptr [BP + -0xe],0xc (1000_344E / 0x1344E)
    UInt16[SS, (ushort)(BP - 0xE)] = 0xC;
    CheckExternalEvents(cs7, 0x3456);
    // MOV BX,word ptr [BP + 0x6] (1000_3453 / 0x13453)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x345A);
    // MOV ES,word ptr [0x55e4] (1000_3456 / 0x13456)
    ES = UInt16[DS, 0x55E4];
    CheckExternalEvents(cs7, 0x345F);
    // MOV AL,byte ptr ES:[BX + 0x3920] (1000_345A / 0x1345A)
    AL = UInt8[ES, (ushort)(BX + 0x3920)];
    CheckExternalEvents(cs7, 0x3460);
    // CBW  (1000_345F / 0x1345F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3463);
    // MOV word ptr [BP + -0xa],AX (1000_3460 / 0x13460)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x3466);
    // JMP 0x1000:36b1 (1000_3463 / 0x13463)
    goto label_1000_36B1_136B1;
    label_1000_3466_13466:
    CheckExternalEvents(cs7, 0x3469);
    // MOV AX,0x30 (1000_3466 / 0x13466)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x346C);
    // IMUL word ptr [BP + 0x6] (1000_3469 / 0x13469)
    int resImul1000_3469 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3469);
    DX = (ushort)(resImul1000_3469 >> 16);
    CheckExternalEvents(cs7, 0x346E);
    // MOV BX,AX (1000_346C / 0x1346C)
    BX = AX;
    CheckExternalEvents(cs7, 0x3471);
    // MOV AX,word ptr [BP + -0x20] (1000_346E / 0x1346E)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs7, 0x3474);
    // INC word ptr [BP + -0x20] (1000_3471 / 0x13471)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs7, 0x3476);
    // ADD BX,AX (1000_3474 / 0x13474)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs7, 0x347A);
    // MOV ES,word ptr [0x55dc] (1000_3476 / 0x13476)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x347F);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_347A / 0x1347A)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x3480);
    // CBW  (1000_347F / 0x1347F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3483);
    // MOV word ptr [BP + -0x1a],AX (1000_3480 / 0x13480)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs7, 0x3484);
    // INC AX (1000_3483 / 0x13483)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0x3486);
    // JNZ 0x1000:348c (1000_3484 / 0x13484)
    if(!ZeroFlag) {
      goto label_1000_348C_1348C;
    }
    CheckExternalEvents(cs7, 0x3489);
    // INC word ptr [BP + -0xc] (1000_3486 / 0x13486)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x348C);
    // JMP 0x1000:36b1 (1000_3489 / 0x13489)
    goto label_1000_36B1_136B1;
    label_1000_348C_1348C:
    CheckExternalEvents(cs7, 0x348F);
    // MOV AX,0x30 (1000_348C / 0x1348C)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x3492);
    // IMUL word ptr [BP + 0x6] (1000_348F / 0x1348F)
    int resImul1000_348F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_348F);
    DX = (ushort)(resImul1000_348F >> 16);
    CheckExternalEvents(cs7, 0x3494);
    // MOV SI,AX (1000_3492 / 0x13492)
    SI = AX;
    CheckExternalEvents(cs7, 0x3497);
    // MOV BX,word ptr [BP + -0x20] (1000_3494 / 0x13494)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs7, 0x349A);
    // INC word ptr [BP + -0x20] (1000_3497 / 0x13497)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs7, 0x349C);
    // ADD BX,SI (1000_349A / 0x1349A)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x34A1);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_349C / 0x1349C)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x34A3);
    // SUB AH,AH (1000_34A1 / 0x134A1)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x34A5);
    // MOV CH,AL (1000_34A3 / 0x134A3)
    CH = AL;
    CheckExternalEvents(cs7, 0x34A7);
    // SUB CL,CL (1000_34A5 / 0x134A5)
    // CL -= CL;
    CL = Alu8.Sub(CL, CL);
    CheckExternalEvents(cs7, 0x34AA);
    // MOV word ptr [BP + -0x4],CX (1000_34A7 / 0x134A7)
    UInt16[SS, (ushort)(BP - 0x4)] = CX;
    CheckExternalEvents(cs7, 0x34AD);
    // MOV BX,word ptr [BP + -0x20] (1000_34AA / 0x134AA)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs7, 0x34B0);
    // INC word ptr [BP + -0x20] (1000_34AD / 0x134AD)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs7, 0x34B2);
    // ADD BX,SI (1000_34B0 / 0x134B0)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x34B7);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_34B2 / 0x134B2)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x34B8);
    // CBW  (1000_34B7 / 0x134B7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x34BC);
    // AND CX,0xf00 (1000_34B8 / 0x134B8)
    // CX &= 0xF00;
    CX = Alu16.And(CX, 0xF00);
    CheckExternalEvents(cs7, 0x34BE);
    // OR AX,CX (1000_34BC / 0x134BC)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x34C1);
    // MOV word ptr [BP + -0x14],AX (1000_34BE / 0x134BE)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs7, 0x34C4);
    // MOV BX,word ptr [BP + -0x20] (1000_34C1 / 0x134C1)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs7, 0x34C7);
    // INC word ptr [BP + -0x20] (1000_34C4 / 0x134C4)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs7, 0x34C9);
    // ADD BX,SI (1000_34C7 / 0x134C7)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x34CE);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_34C9 / 0x134C9)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x34CF);
    // CBW  (1000_34CE / 0x134CE)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x34D2);
    // MOV CX,word ptr [BP + -0x4] (1000_34CF / 0x134CF)
    CX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x34D6);
    // AND CX,0xf000 (1000_34D2 / 0x134D2)
    // CX &= 0xF000;
    CX = Alu16.And(CX, 0xF000);
    CheckExternalEvents(cs7, 0x34D8);
    // OR AX,CX (1000_34D6 / 0x134D6)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x34DB);
    // MOV word ptr [BP + -0x1c],AX (1000_34D8 / 0x134D8)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs7, 0x34E0);
    // MOV word ptr [BP + -0x24],0x0 (1000_34DB / 0x134DB)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x0;
    CheckExternalEvents(cs7, 0x34E4);
    // CMP word ptr [BP + 0x6],0xc (1000_34E0 / 0x134E0)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x34E6);
    // JGE 0x1000:34fa (1000_34E4 / 0x134E4)
    if(SignFlag == OverflowFlag) {
      goto label_1000_34FA_134FA;
    }
    CheckExternalEvents(cs7, 0x34E9);
    // MOV BX,word ptr [BP + 0x6] (1000_34E6 / 0x134E6)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x34ED);
    // MOV ES,word ptr [0x55e6] (1000_34E9 / 0x134E9)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs7, 0x34F3);
    // CMP byte ptr ES:[BX + 0x3994],0x0 (1000_34ED / 0x134ED)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3994)], 0x0);
    CheckExternalEvents(cs7, 0x34F5);
    // JNZ 0x1000:34fa (1000_34F3 / 0x134F3)
    if(!ZeroFlag) {
      goto label_1000_34FA_134FA;
    }
    CheckExternalEvents(cs7, 0x34FA);
    // MOV word ptr [BP + -0x24],0x1 (1000_34F5 / 0x134F5)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x1;
    label_1000_34FA_134FA:
    CheckExternalEvents(cs7, 0x34FE);
    // CMP word ptr [BP + -0xa],-0x1 (1000_34FA / 0x134FA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0xFFFF);
    CheckExternalEvents(cs7, 0x3500);
    // JNZ 0x1000:3505 (1000_34FE / 0x134FE)
    if(!ZeroFlag) {
      goto label_1000_3505_13505;
    }
    CheckExternalEvents(cs7, 0x3505);
    // MOV word ptr [BP + -0x24],0x1 (1000_3500 / 0x13500)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x1;
    label_1000_3505_13505:
    CheckExternalEvents(cs7, 0x3509);
    // CMP word ptr [BP + -0x24],0x0 (1000_3505 / 0x13505)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x0);
    CheckExternalEvents(cs7, 0x350B);
    // JZ 0x1000:3537 (1000_3509 / 0x13509)
    if(ZeroFlag) {
      goto label_1000_3537_13537;
    }
    CheckExternalEvents(cs7, 0x350E);
    // PUSH word ptr [BP + -0x1c] (1000_350B / 0x1350B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs7, 0x3511);
    // PUSH word ptr [BP + -0x14] (1000_350E / 0x1350E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs7, 0x3515);
    // MOV ES,word ptr [0x5616] (1000_3511 / 0x13511)
    ES = UInt16[DS, 0x5616];
    CheckExternalEvents(cs7, 0x351A);
    // PUSH word ptr ES:[0xe488] (1000_3515 / 0x13515)
    Stack.Push16(UInt16[ES, 0xE488]);
    CheckExternalEvents(cs7, 0x351E);
    // MOV ES,word ptr [0x5614] (1000_351A / 0x1351A)
    ES = UInt16[DS, 0x5614];
    CheckExternalEvents(cs7, 0x3523);
    // PUSH word ptr ES:[0xe486] (1000_351E / 0x1351E)
    Stack.Push16(UInt16[ES, 0xE486]);
    CheckExternalEvents(cs7, 0x3528);
    // CALLF 0x1000:a861 (1000_3523 / 0x13523)
    FarCall(cs7, 0x3528, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs7, 0x352B);
    // ADD SP,0x8 (1000_3528 / 0x13528)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x352E);
    // MOV BX,word ptr [BP + 0x6] (1000_352B / 0x1352B)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x3532);
    // MOV ES,word ptr [0x55e4] (1000_352E / 0x1352E)
    ES = UInt16[DS, 0x55E4];
    CheckExternalEvents(cs7, 0x3537);
    // MOV byte ptr ES:[BX + 0x3920],AL (1000_3532 / 0x13532)
    UInt8[ES, (ushort)(BX + 0x3920)] = AL;
    label_1000_3537_13537:
    CheckExternalEvents(cs7, 0x353B);
    // MOV ES,word ptr [0x5618] (1000_3537 / 0x13537)
    ES = UInt16[DS, 0x5618];
    CheckExternalEvents(cs7, 0x3542);
    // MOV word ptr ES:[0xd57e],0x0 (1000_353B / 0x1353B)
    UInt16[ES, 0xD57E] = 0x0;
    CheckExternalEvents(cs7, 0x3545);
    // JMP 0x1000:36a2 (1000_3542 / 0x13542)
    goto label_1000_36A2_136A2;
    label_1000_3545_13545:
    CheckExternalEvents(cs7, 0x3549);
    // MOV ES,word ptr [0x5614] (1000_3545 / 0x13545)
    ES = UInt16[DS, 0x5614];
    CheckExternalEvents(cs7, 0x354C);
    // MOV AX,word ptr [BP + -0x14] (1000_3549 / 0x13549)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs7, 0x3551);
    // CMP word ptr ES:[0xe486],AX (1000_354C / 0x1354C)
    Alu16.Sub(UInt16[ES, 0xE486], AX);
    CheckExternalEvents(cs7, 0x3553);
    // JNZ 0x1000:3564 (1000_3551 / 0x13551)
    if(!ZeroFlag) {
      goto label_1000_3564_13564;
    }
    CheckExternalEvents(cs7, 0x3557);
    // MOV ES,word ptr [0x5616] (1000_3553 / 0x13553)
    ES = UInt16[DS, 0x5616];
    CheckExternalEvents(cs7, 0x355A);
    // MOV AX,word ptr [BP + -0x1c] (1000_3557 / 0x13557)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs7, 0x355F);
    // CMP word ptr ES:[0xe488],AX (1000_355A / 0x1355A)
    Alu16.Sub(UInt16[ES, 0xE488], AX);
    CheckExternalEvents(cs7, 0x3561);
    // JNZ 0x1000:3564 (1000_355F / 0x1355F)
    if(!ZeroFlag) {
      goto label_1000_3564_13564;
    }
    CheckExternalEvents(cs7, 0x3564);
    // JMP 0x1000:36b1 (1000_3561 / 0x13561)
    goto label_1000_36B1_136B1;
    label_1000_3564_13564:
    CheckExternalEvents(cs7, 0x3568);
    // MOV ES,word ptr [0x5618] (1000_3564 / 0x13564)
    ES = UInt16[DS, 0x5618];
    CheckExternalEvents(cs7, 0x356E);
    // CMP word ptr ES:[0xd57e],0x0 (1000_3568 / 0x13568)
    Alu16.Sub(UInt16[ES, 0xD57E], 0x0);
    CheckExternalEvents(cs7, 0x3570);
    // JZ 0x1000:3573 (1000_356E / 0x1356E)
    if(ZeroFlag) {
      goto label_1000_3573_13573;
    }
    CheckExternalEvents(cs7, 0x3573);
    // JMP 0x1000:36b1 (1000_3570 / 0x13570)
    goto label_1000_36B1_136B1;
    label_1000_3573_13573:
    CheckExternalEvents(cs7, 0x3575);
    // SUB AX,AX (1000_3573 / 0x13573)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3576);
    // PUSH AX (1000_3575 / 0x13575)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3579);
    // PUSH word ptr [BP + -0xe] (1000_3576 / 0x13576)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs7, 0x357C);
    // PUSH word ptr [BP + -0x8] (1000_3579 / 0x13579)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0x357F);
    // PUSH word ptr [BP + -0x1c] (1000_357C / 0x1357C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs7, 0x3582);
    // PUSH word ptr [BP + -0x14] (1000_357F / 0x1357F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs7, 0x3585);
    // PUSH word ptr [BP + 0x6] (1000_3582 / 0x13582)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x358A);
    // CALLF 0x0000:fa16 (1000_3585 / 0x13585)
    FarCall(cs7, 0x358A, unknown_0FA1_0006_0FA16);
    CheckExternalEvents(cs7, 0x358D);
    // ADD SP,0xc (1000_358A / 0x1358A)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs7, 0x3591);
    // MOV ES,word ptr [0x561c] (1000_358D / 0x1358D)
    ES = UInt16[DS, 0x561C];
    CheckExternalEvents(cs7, 0x3595);
    // MOV AX,ES:[0x458e] (1000_3591 / 0x13591)
    AX = UInt16[ES, 0x458E];
    CheckExternalEvents(cs7, 0x3598);
    // ADD word ptr [BP + -0x8],AX (1000_3595 / 0x13595)
    // UInt16[SS, (ushort)(BP - 0x8)] += AX;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs7, 0x359C);
    // MOV ES,word ptr [0x561e] (1000_3598 / 0x13598)
    ES = UInt16[DS, 0x561E];
    CheckExternalEvents(cs7, 0x35A0);
    // MOV AX,ES:[0x4590] (1000_359C / 0x1359C)
    AX = UInt16[ES, 0x4590];
    CheckExternalEvents(cs7, 0x35A3);
    // ADD word ptr [BP + -0xe],AX (1000_35A0 / 0x135A0)
    // UInt16[SS, (ushort)(BP - 0xE)] += AX;
    UInt16[SS, (ushort)(BP - 0xE)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xE)], AX);
    CheckExternalEvents(cs7, 0x35A6);
    // MOV AX,0x18 (1000_35A3 / 0x135A3)
    AX = 0x18;
    CheckExternalEvents(cs7, 0x35A9);
    // IMUL word ptr [BP + 0x6] (1000_35A6 / 0x135A6)
    int resImul1000_35A6 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_35A6);
    DX = (ushort)(resImul1000_35A6 >> 16);
    CheckExternalEvents(cs7, 0x35AB);
    // MOV SI,AX (1000_35A9 / 0x135A9)
    SI = AX;
    CheckExternalEvents(cs7, 0x35AF);
    // MOV ES,word ptr [0x561c] (1000_35AB / 0x135AB)
    ES = UInt16[DS, 0x561C];
    CheckExternalEvents(cs7, 0x35B3);
    // MOV AL,ES:[0x458e] (1000_35AF / 0x135AF)
    AL = UInt8[ES, 0x458E];
    CheckExternalEvents(cs7, 0x35B6);
    // MOV BX,word ptr [BP + -0x12] (1000_35B3 / 0x135B3)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs7, 0x35B9);
    // INC word ptr [BP + -0x12] (1000_35B6 / 0x135B6)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    CheckExternalEvents(cs7, 0x35BB);
    // ADD BX,SI (1000_35B9 / 0x135B9)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x35BF);
    // MOV ES,word ptr [0x55d8] (1000_35BB / 0x135BB)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs7, 0x35C4);
    // MOV byte ptr ES:[BX + 0x40b4],AL (1000_35BF / 0x135BF)
    UInt8[ES, (ushort)(BX + 0x40B4)] = AL;
    CheckExternalEvents(cs7, 0x35C8);
    // MOV ES,word ptr [0x561e] (1000_35C4 / 0x135C4)
    ES = UInt16[DS, 0x561E];
    CheckExternalEvents(cs7, 0x35CC);
    // MOV AL,ES:[0x4590] (1000_35C8 / 0x135C8)
    AL = UInt8[ES, 0x4590];
    CheckExternalEvents(cs7, 0x35CF);
    // MOV BX,word ptr [BP + -0x12] (1000_35CC / 0x135CC)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs7, 0x35D2);
    // INC word ptr [BP + -0x12] (1000_35CF / 0x135CF)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    CheckExternalEvents(cs7, 0x35D4);
    // ADD BX,SI (1000_35D2 / 0x135D2)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x35D8);
    // MOV ES,word ptr [0x55d8] (1000_35D4 / 0x135D4)
    ES = UInt16[DS, 0x55D8];
    CheckExternalEvents(cs7, 0x35DD);
    // MOV byte ptr ES:[BX + 0x40b4],AL (1000_35D8 / 0x135D8)
    UInt8[ES, (ushort)(BX + 0x40B4)] = AL;
    CheckExternalEvents(cs7, 0x35E0);
    // MOV AX,word ptr [BP + -0xe] (1000_35DD / 0x135DD)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0x35E2);
    // SAR AX,0x1 (1000_35E0 / 0x135E0)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x35E5);
    // MOV CX,0x18 (1000_35E2 / 0x135E2)
    CX = 0x18;
    CheckExternalEvents(cs7, 0x35E7);
    // IMUL CX (1000_35E5 / 0x135E5)
    int resImul1000_35E5 = Alu16.Imul((short)AX, (short)CX);
    AX = (ushort)(resImul1000_35E5);
    DX = (ushort)(resImul1000_35E5 >> 16);
    CheckExternalEvents(cs7, 0x35EA);
    // MOV CX,word ptr [BP + -0x8] (1000_35E7 / 0x135E7)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x35ED);
    // SUB CX,0xd (1000_35EA / 0x135EA)
    CX -= 0xD;
    CheckExternalEvents(cs7, 0x35EF);
    // SAR CX,0x1 (1000_35ED / 0x135ED)
    CX = Alu16.Sar(CX, 0x1);
    CheckExternalEvents(cs7, 0x35F1);
    // ADD AX,CX (1000_35EF / 0x135EF)
    // AX += CX;
    AX = Alu16.Add(AX, CX);
    CheckExternalEvents(cs7, 0x35F4);
    // MOV word ptr [BP + -0x10],AX (1000_35F1 / 0x135F1)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs7, 0x35F7);
    // MOV DI,word ptr [BP + -0xe] (1000_35F4 / 0x135F4)
    DI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0x35FA);
    // AND DI,0x1 (1000_35F7 / 0x135F7)
    DI &= 0x1;
    CheckExternalEvents(cs7, 0x35FC);
    // SHL DI,0x1 (1000_35FA / 0x135FA)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs7, 0x35FF);
    // MOV BX,word ptr [BP + -0x8] (1000_35FC / 0x135FC)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x3602);
    // AND BX,0x1 (1000_35FF / 0x135FF)
    // BX &= 0x1;
    BX = Alu16.And(BX, 0x1);
    CheckExternalEvents(cs7, 0x3606);
    // MOV AL,byte ptr [BX + DI + 0x3b12] (1000_3602 / 0x13602)
    AL = UInt8[DS, (ushort)(BX + DI + 0x3B12)];
    CheckExternalEvents(cs7, 0x3607);
    // CBW  (1000_3606 / 0x13606)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x360A);
    // MOV word ptr [BP + -0x28],AX (1000_3607 / 0x13607)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs7, 0x360E);
    // TEST byte ptr [BP + -0x8],0x1 (1000_360A / 0x1360A)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs7, 0x3610);
    // JZ 0x1000:3623 (1000_360E / 0x1360E)
    if(ZeroFlag) {
      goto label_1000_3623_13623;
    }
    CheckExternalEvents(cs7, 0x3614);
    // MOV ES,word ptr [0x55cc] (1000_3610 / 0x13610)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x361A);
    // TEST byte ptr ES:[0xa44b],0x1 (1000_3614 / 0x13614)
    Alu8.And(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs7, 0x361C);
    // JZ 0x1000:3623 (1000_361A / 0x1361A)
    if(ZeroFlag) {
      goto label_1000_3623_13623;
    }
    CheckExternalEvents(cs7, 0x361F);
    // INC word ptr [BP + -0x10] (1000_361C / 0x1361C)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    CheckExternalEvents(cs7, 0x3623);
    // XOR byte ptr [BP + -0x28],0xa (1000_361F / 0x1361F)
    UInt8[SS, (ushort)(BP - 0x28)] ^= 0xA;
    label_1000_3623_13623:
    CheckExternalEvents(cs7, 0x3627);
    // TEST byte ptr [BP + -0xe],0x1 (1000_3623 / 0x13623)
    Alu8.And(UInt8[SS, (ushort)(BP - 0xE)], 0x1);
    CheckExternalEvents(cs7, 0x3629);
    // JZ 0x1000:363d (1000_3627 / 0x13627)
    if(ZeroFlag) {
      goto label_1000_363D_1363D;
    }
    CheckExternalEvents(cs7, 0x362D);
    // MOV ES,word ptr [0x55ce] (1000_3629 / 0x13629)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x3633);
    // TEST byte ptr ES:[0xa44d],0x1 (1000_362D / 0x1362D)
    Alu8.And(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs7, 0x3635);
    // JZ 0x1000:363d (1000_3633 / 0x13633)
    if(ZeroFlag) {
      goto label_1000_363D_1363D;
    }
    CheckExternalEvents(cs7, 0x3639);
    // ADD word ptr [BP + -0x10],0x18 (1000_3635 / 0x13635)
    UInt16[SS, (ushort)(BP - 0x10)] += 0x18;
    CheckExternalEvents(cs7, 0x363D);
    // XOR byte ptr [BP + -0x28],0x5 (1000_3639 / 0x13639)
    // UInt8[SS, (ushort)(BP - 0x28)] ^= 0x5;
    UInt8[SS, (ushort)(BP - 0x28)] = Alu8.Xor(UInt8[SS, (ushort)(BP - 0x28)], 0x5);
    label_1000_363D_1363D:
    CheckExternalEvents(cs7, 0x3641);
    // MOV ES,word ptr [0x5620] (1000_363D / 0x1363D)
    ES = UInt16[DS, 0x5620];
    CheckExternalEvents(cs7, 0x3646);
    // MOV BX,word ptr ES:[0x9ed] (1000_3641 / 0x13641)
    BX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs7, 0x3649);
    // ADD BX,word ptr [BP + -0x10] (1000_3646 / 0x13646)
    // BX += UInt16[SS, (ushort)(BP - 0x10)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs7, 0x364D);
    // MOV ES,word ptr [0x5622] (1000_3649 / 0x13649)
    ES = UInt16[DS, 0x5622];
    CheckExternalEvents(cs7, 0x3652);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (1000_364D / 0x1364D)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs7, 0x3654);
    // SUB AH,AH (1000_3652 / 0x13652)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x3657);
    // MOV word ptr [BP + -0x18],AX (1000_3654 / 0x13654)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x365C);
    // MOV word ptr [BP + -0x2],0x1 (1000_3657 / 0x13657)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs7, 0x3660);
    // CMP word ptr [BP + -0x1a],0x2 (1000_365C / 0x1365C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1A)], 0x2);
    CheckExternalEvents(cs7, 0x3662);
    // JZ 0x1000:368d (1000_3660 / 0x13660)
    if(ZeroFlag) {
      goto label_1000_368D_1368D;
    }
    CheckExternalEvents(cs7, 0x3665);
    // CMP AX,0x40 (1000_3662 / 0x13662)
    Alu16.Sub(AX, 0x40);
    CheckExternalEvents(cs7, 0x3667);
    // JGE 0x1000:368d (1000_3665 / 0x13665)
    if(SignFlag == OverflowFlag) {
      goto label_1000_368D_1368D;
    }
    CheckExternalEvents(cs7, 0x366A);
    // AND AX,0xf0 (1000_3667 / 0x13667)
    // AX &= 0xF0;
    AX = Alu16.And(AX, 0xF0);
    CheckExternalEvents(cs7, 0x366D);
    // MOV word ptr [BP + -0x6],AX (1000_366A / 0x1366A)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x3670);
    // MOV AX,word ptr [BP + -0x28] (1000_366D / 0x1366D)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x3673);
    // TEST word ptr [BP + -0x18],AX (1000_3670 / 0x13670)
    Alu16.And(UInt16[SS, (ushort)(BP - 0x18)], AX);
    CheckExternalEvents(cs7, 0x3675);
    // JZ 0x1000:367a (1000_3673 / 0x13673)
    if(ZeroFlag) {
      goto label_1000_367A_1367A;
    }
    CheckExternalEvents(cs7, 0x367A);
    // MOV word ptr [BP + -0x2],0x2 (1000_3675 / 0x13675)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2;
    label_1000_367A_1367A:
    CheckExternalEvents(cs7, 0x367E);
    // CMP word ptr [BP + -0x6],0x20 (1000_367A / 0x1367A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x20);
    CheckExternalEvents(cs7, 0x3680);
    // JNZ 0x1000:368d (1000_367E / 0x1367E)
    if(!ZeroFlag) {
      goto label_1000_368D_1368D;
    }
    CheckExternalEvents(cs7, 0x3683);
    // MOV AX,word ptr [BP + -0x28] (1000_3680 / 0x13680)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs7, 0x3686);
    // TEST word ptr [BP + -0x18],AX (1000_3683 / 0x13683)
    Alu16.And(UInt16[SS, (ushort)(BP - 0x18)], AX);
    CheckExternalEvents(cs7, 0x3688);
    // JZ 0x1000:368d (1000_3686 / 0x13686)
    if(ZeroFlag) {
      goto label_1000_368D_1368D;
    }
    CheckExternalEvents(cs7, 0x368D);
    // MOV word ptr [BP + -0x2],0x3 (1000_3688 / 0x13688)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x3;
    label_1000_368D_1368D:
    CheckExternalEvents(cs7, 0x3691);
    // MOV ES,word ptr [0x561a] (1000_368D / 0x1368D)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3694);
    // MOV AX,word ptr [BP + -0x2] (1000_3691 / 0x13691)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x3699);
    // SUB word ptr ES:[0x3770],AX (1000_3694 / 0x13694)
    // UInt16[ES, 0x3770] -= AX;
    UInt16[ES, 0x3770] = Alu16.Sub(UInt16[ES, 0x3770], AX);
    CheckExternalEvents(cs7, 0x369B);
    // JNS 0x1000:36a2 (1000_3699 / 0x13699)
    if(!SignFlag) {
      goto label_1000_36A2_136A2;
    }
    CheckExternalEvents(cs7, 0x36A2);
    // MOV word ptr ES:[0x3770],0x0 (1000_369B / 0x1369B)
    UInt16[ES, 0x3770] = 0x0;
    label_1000_36A2_136A2:
    CheckExternalEvents(cs7, 0x36A6);
    // MOV ES,word ptr [0x561a] (1000_36A2 / 0x136A2)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x36AC);
    // CMP word ptr ES:[0x3770],0x0 (1000_36A6 / 0x136A6)
    Alu16.Sub(UInt16[ES, 0x3770], 0x0);
    CheckExternalEvents(cs7, 0x36AE);
    // JLE 0x1000:36b1 (1000_36AC / 0x136AC)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_36B1_136B1;
    }
    CheckExternalEvents(cs7, 0x36B1);
    // JMP 0x1000:3545 (1000_36AE / 0x136AE)
    goto label_1000_3545_13545;
    label_1000_36B1_136B1:
    CheckExternalEvents(cs7, 0x36B5);
    // CMP word ptr [BP + -0xc],0x0 (1000_36B1 / 0x136B1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs7, 0x36B7);
    // JNZ 0x1000:36ba (1000_36B5 / 0x136B5)
    if(!ZeroFlag) {
      goto label_1000_36BA_136BA;
    }
    CheckExternalEvents(cs7, 0x36BA);
    // JMP 0x1000:3466 (1000_36B7 / 0x136B7)
    goto label_1000_3466_13466;
    label_1000_36BA_136BA:
    CheckExternalEvents(cs7, 0x36BD);
    // MOV AL,byte ptr [BP + -0xa] (1000_36BA / 0x136BA)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x36C0);
    // MOV BX,word ptr [BP + 0x6] (1000_36BD / 0x136BD)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x36C4);
    // MOV ES,word ptr [0x55e4] (1000_36C0 / 0x136C0)
    ES = UInt16[DS, 0x55E4];
    CheckExternalEvents(cs7, 0x36C9);
    // MOV byte ptr ES:[BX + 0x3920],AL (1000_36C4 / 0x136C4)
    UInt8[ES, (ushort)(BX + 0x3920)] = AL;
    CheckExternalEvents(cs7, 0x36CA);
    // POP SI (1000_36C9 / 0x136C9)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x36CB);
    // POP DI (1000_36CA / 0x136CA)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x36CD);
    // MOV SP,BP (1000_36CB / 0x136CB)
    SP = BP;
    CheckExternalEvents(cs7, 0x36CE);
    // POP BP (1000_36CD / 0x136CD)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x36CF);
    // RETF  (1000_36CE / 0x136CE)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_36CF_136CF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_36CF_136CF:
    CheckExternalEvents(cs7, 0x36D0);
    // PUSH BP (1000_36CF / 0x136CF)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x36D2);
    // MOV BP,SP (1000_36D0 / 0x136D0)
    BP = SP;
    CheckExternalEvents(cs7, 0x36D5);
    // MOV AX,0x36 (1000_36D2 / 0x136D2)
    AX = 0x36;
    CheckExternalEvents(cs7, 0x36DA);
    // CALLF 0x1000:cecc (1000_36D5 / 0x136D5)
    FarCall(cs7, 0x36DA, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x36DB);
    // PUSH DI (1000_36DA / 0x136DA)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0x36DC);
    // PUSH SI (1000_36DB / 0x136DB)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x36E0);
    // CMP word ptr [BP + 0x6],0xc (1000_36DC / 0x136DC)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x36E2);
    // JGE 0x1000:372f (1000_36E0 / 0x136E0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_372F_1372F;
    }
    CheckExternalEvents(cs7, 0x36E5);
    // MOV BX,word ptr [BP + 0x6] (1000_36E2 / 0x136E2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x36E9);
    // MOV ES,word ptr [0x55e6] (1000_36E5 / 0x136E5)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs7, 0x36EF);
    // CMP byte ptr ES:[BX + 0x3994],0x0 (1000_36E9 / 0x136E9)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3994)], 0x0);
    CheckExternalEvents(cs7, 0x36F1);
    // JZ 0x1000:3722 (1000_36EF / 0x136EF)
    if(ZeroFlag) {
      goto label_1000_3722_13722;
    }
    CheckExternalEvents(cs7, 0x36F6);
    // MOV word ptr [BP + -0x1c],0x0 (1000_36F1 / 0x136F1)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x0;
    label_1000_36F6_136F6:
    CheckExternalEvents(cs7, 0x36F9);
    // MOV AX,0x30 (1000_36F6 / 0x136F6)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x36FC);
    // IMUL word ptr [BP + 0x6] (1000_36F9 / 0x136F9)
    int resImul1000_36F9 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_36F9);
    DX = (ushort)(resImul1000_36F9 >> 16);
    CheckExternalEvents(cs7, 0x36FE);
    // MOV BX,AX (1000_36FC / 0x136FC)
    BX = AX;
    CheckExternalEvents(cs7, 0x3701);
    // ADD BX,word ptr [BP + -0x1c] (1000_36FE / 0x136FE)
    // BX += UInt16[SS, (ushort)(BP - 0x1C)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs7, 0x3705);
    // MOV ES,word ptr [0x55dc] (1000_3701 / 0x13701)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x370B);
    // MOV byte ptr ES:[BX + 0x32c6],0xff (1000_3705 / 0x13705)
    UInt8[ES, (ushort)(BX + 0x32C6)] = 0xFF;
    CheckExternalEvents(cs7, 0x370E);
    // INC word ptr [BP + -0x1c] (1000_370B / 0x1370B)
    UInt16[SS, (ushort)(BP - 0x1C)]++;
    CheckExternalEvents(cs7, 0x3712);
    // CMP word ptr [BP + -0x1c],0x30 (1000_370E / 0x1370E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1C)], 0x30);
    CheckExternalEvents(cs7, 0x3714);
    // JL 0x1000:36f6 (1000_3712 / 0x13712)
    if(SignFlag != OverflowFlag) {
      goto label_1000_36F6_136F6;
    }
    CheckExternalEvents(cs7, 0x3717);
    // MOV AX,0x1 (1000_3714 / 0x13714)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x3718);
    // PUSH AX (1000_3717 / 0x13717)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x371B);
    // PUSH word ptr [BP + 0x6] (1000_3718 / 0x13718)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x371C);
    // PUSH CS (1000_371B / 0x1371B)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x371F);
    // CALL 0x1000:3224 (1000_371C / 0x1371C)
    NearCall(cs7, 0x371F, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs7, 0x3722);
    // ADD SP,0x4 (1000_371F / 0x1371F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_3722_13722:
    CheckExternalEvents(cs7, 0x3725);
    // MOV BX,word ptr [BP + 0x6] (1000_3722 / 0x13722)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x3729);
    // MOV ES,word ptr [0x55e6] (1000_3725 / 0x13725)
    ES = UInt16[DS, 0x55E6];
    CheckExternalEvents(cs7, 0x372F);
    // MOV byte ptr ES:[BX + 0x3994],0x0 (1000_3729 / 0x13729)
    UInt8[ES, (ushort)(BX + 0x3994)] = 0x0;
    label_1000_372F_1372F:
    CheckExternalEvents(cs7, 0x3734);
    // MOV word ptr [BP + -0xc],0x1 (1000_372F / 0x1372F)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x1;
    CheckExternalEvents(cs7, 0x3737);
    // MOV AX,0x30 (1000_3734 / 0x13734)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x373A);
    // IMUL word ptr [BP + 0x6] (1000_3737 / 0x13737)
    int resImul1000_3737 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3737);
    DX = (ushort)(resImul1000_3737 >> 16);
    CheckExternalEvents(cs7, 0x373C);
    // MOV BX,AX (1000_373A / 0x1373A)
    BX = AX;
    CheckExternalEvents(cs7, 0x3740);
    // MOV ES,word ptr [0x55dc] (1000_373C / 0x1373C)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x3745);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_3740 / 0x13740)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x3746);
    // CBW  (1000_3745 / 0x13745)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3749);
    // MOV word ptr [BP + -0xe],AX (1000_3746 / 0x13746)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs7, 0x374D);
    // CMP word ptr [BP + 0x6],0x4 (1000_3749 / 0x13749)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x374F);
    // JL 0x1000:3752 (1000_374D / 0x1374D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3752_13752;
    }
    CheckExternalEvents(cs7, 0x3752);
    // JMP 0x1000:389a (1000_374F / 0x1374F)
    goto label_1000_389A_1389A;
    label_1000_3752_13752:
    CheckExternalEvents(cs7, 0x3755);
    // CMP AX,0xffff (1000_3752 / 0x13752)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs7, 0x3757);
    // JNZ 0x1000:375a (1000_3755 / 0x13755)
    if(!ZeroFlag) {
      goto label_1000_375A_1375A;
    }
    CheckExternalEvents(cs7, 0x375A);
    // JMP 0x1000:389a (1000_3757 / 0x13757)
    goto label_1000_389A_1389A;
    label_1000_375A_1375A:
    CheckExternalEvents(cs7, 0x375E);
    // CMP word ptr [BP + 0x8],0x2 (1000_375A / 0x1375A)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x2);
    CheckExternalEvents(cs7, 0x3760);
    // JNZ 0x1000:3777 (1000_375E / 0x1375E)
    if(!ZeroFlag) {
      goto label_1000_3777_13777;
    }
    CheckExternalEvents(cs7, 0x3763);
    // MOV AX,0x7d (1000_3760 / 0x13760)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3766);
    // IMUL word ptr [BP + 0x6] (1000_3763 / 0x13763)
    int resImul1000_3763 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3763);
    DX = (ushort)(resImul1000_3763 >> 16);
    CheckExternalEvents(cs7, 0x3768);
    // MOV BX,AX (1000_3766 / 0x13766)
    BX = AX;
    CheckExternalEvents(cs7, 0x376C);
    // MOV ES,word ptr [0x55d4] (1000_3768 / 0x13768)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3772);
    // CMP byte ptr ES:[BX + 0xc756],0x0 (1000_376C / 0x1376C)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC756)], 0x0);
    CheckExternalEvents(cs7, 0x3774);
    // JNZ 0x1000:3777 (1000_3772 / 0x13772)
    if(!ZeroFlag) {
      goto label_1000_3777_13777;
    }
    CheckExternalEvents(cs7, 0x3777);
    // JMP 0x1000:389a (1000_3774 / 0x13774)
    goto label_1000_389A_1389A;
    label_1000_3777_13777:
    CheckExternalEvents(cs7, 0x377A);
    // MOV AX,word ptr [BP + 0x8] (1000_3777 / 0x13777)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x377D);
    // CMP word ptr [BP + -0xe],AX (1000_377A / 0x1377A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], AX);
    CheckExternalEvents(cs7, 0x377F);
    // JNZ 0x1000:3782 (1000_377D / 0x1377D)
    if(!ZeroFlag) {
      goto label_1000_3782_13782;
    }
    CheckExternalEvents(cs7, 0x3782);
    // JMP 0x1000:389a (1000_377F / 0x1377F)
    goto label_1000_389A_1389A;
    label_1000_3782_13782:
    CheckExternalEvents(cs7, 0x3785);
    // DEC word ptr [BP + -0xc] (1000_3782 / 0x13782)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x3788);
    // MOV AX,0x4 (1000_3785 / 0x13785)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x3789);
    // PUSH AX (1000_3788 / 0x13788)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x378E);
    // CALLF 0x1000:7ee1 (1000_3789 / 0x13789)
    FarCall(cs7, 0x378E, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x3791);
    // ADD SP,0x2 (1000_378E / 0x1378E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3796);
    // CALLF 0x1000:7fe8 (1000_3791 / 0x13791)
    FarCall(cs7, 0x3796, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x3799);
    // MOV AX,0x3b24 (1000_3796 / 0x13796)
    AX = 0x3B24;
    CheckExternalEvents(cs7, 0x379A);
    // PUSH DS (1000_3799 / 0x13799)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x379B);
    // PUSH AX (1000_379A / 0x1379A)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37A0);
    // CALLF 0x1000:8055 (1000_379B / 0x1379B)
    FarCall(cs7, 0x37A0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x37A3);
    // ADD SP,0x4 (1000_37A0 / 0x137A0)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x37A6);
    // MOV BX,word ptr [BP + -0xe] (1000_37A3 / 0x137A3)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0x37A8);
    // SHL BX,0x1 (1000_37A6 / 0x137A6)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x37AA);
    // SHL BX,0x1 (1000_37A8 / 0x137A8)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x37AE);
    // PUSH word ptr [BX + 0x3cd6] (1000_37AA / 0x137AA)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3CD6)]);
    CheckExternalEvents(cs7, 0x37B2);
    // PUSH word ptr [BX + 0x3cd4] (1000_37AE / 0x137AE)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3CD4)]);
    CheckExternalEvents(cs7, 0x37B5);
    // MOV AX,0x12 (1000_37B2 / 0x137B2)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x37B8);
    // MOV DX,0x2a02 (1000_37B5 / 0x137B5)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x37B9);
    // PUSH DX (1000_37B8 / 0x137B8)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x37BA);
    // PUSH AX (1000_37B9 / 0x137B9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37BF);
    // CALLF 0x1000:da58 (1000_37BA / 0x137BA)
    FarCall(cs7, 0x37BF, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs7, 0x37C2);
    // ADD SP,0x8 (1000_37BF / 0x137BF)
    SP += 0x8;
    CheckExternalEvents(cs7, 0x37C6);
    // CMP word ptr [BP + -0xe],0x1 (1000_37C2 / 0x137C2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x1);
    CheckExternalEvents(cs7, 0x37C8);
    // JNZ 0x1000:37dd (1000_37C6 / 0x137C6)
    if(!ZeroFlag) {
      goto label_1000_37DD_137DD;
    }
    CheckExternalEvents(cs7, 0x37CB);
    // MOV AX,0x3b36 (1000_37C8 / 0x137C8)
    AX = 0x3B36;
    CheckExternalEvents(cs7, 0x37CC);
    // PUSH DS (1000_37CB / 0x137CB)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x37CD);
    // PUSH AX (1000_37CC / 0x137CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37D0);
    // MOV AX,0x12 (1000_37CD / 0x137CD)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x37D3);
    // MOV DX,0x2a02 (1000_37D0 / 0x137D0)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x37D4);
    // PUSH DX (1000_37D3 / 0x137D3)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x37D5);
    // PUSH AX (1000_37D4 / 0x137D4)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37DA);
    // CALLF 0x1000:da12 (1000_37D5 / 0x137D5)
    FarCall(cs7, 0x37DA, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs7, 0x37DD);
    // ADD SP,0x8 (1000_37DA / 0x137DA)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_1000_37DD_137DD:
    CheckExternalEvents(cs7, 0x37E0);
    // MOV AX,0x3b38 (1000_37DD / 0x137DD)
    AX = 0x3B38;
    CheckExternalEvents(cs7, 0x37E1);
    // PUSH DS (1000_37E0 / 0x137E0)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x37E2);
    // PUSH AX (1000_37E1 / 0x137E1)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37E5);
    // MOV AX,0x12 (1000_37E2 / 0x137E2)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x37E8);
    // MOV DX,0x2a02 (1000_37E5 / 0x137E5)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x37E9);
    // PUSH DX (1000_37E8 / 0x137E8)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x37EA);
    // PUSH AX (1000_37E9 / 0x137E9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37EF);
    // CALLF 0x1000:da12 (1000_37EA / 0x137EA)
    FarCall(cs7, 0x37EF, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs7, 0x37F2);
    // ADD SP,0x8 (1000_37EF / 0x137EF)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x37F5);
    // MOV AX,0x12 (1000_37F2 / 0x137F2)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x37F8);
    // MOV DX,0x2a02 (1000_37F5 / 0x137F5)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x37F9);
    // PUSH DX (1000_37F8 / 0x137F8)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x37FA);
    // PUSH AX (1000_37F9 / 0x137F9)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x37FF);
    // CALLF 0x1000:8055 (1000_37FA / 0x137FA)
    FarCall(cs7, 0x37FF, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3802);
    // ADD SP,0x4 (1000_37FF / 0x137FF)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3805);
    // MOV AX,0x3b3d (1000_3802 / 0x13802)
    AX = 0x3B3D;
    CheckExternalEvents(cs7, 0x3806);
    // PUSH DS (1000_3805 / 0x13805)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3807);
    // PUSH AX (1000_3806 / 0x13806)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x380C);
    // CALLF 0x1000:8055 (1000_3807 / 0x13807)
    FarCall(cs7, 0x380C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x380F);
    // ADD SP,0x4 (1000_380C / 0x1380C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3812);
    // MOV BX,word ptr [BP + 0x8] (1000_380F / 0x1380F)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x3814);
    // SHL BX,0x1 (1000_3812 / 0x13812)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x3816);
    // SHL BX,0x1 (1000_3814 / 0x13814)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x381A);
    // PUSH word ptr [BX + 0x3cd6] (1000_3816 / 0x13816)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3CD6)]);
    CheckExternalEvents(cs7, 0x381E);
    // PUSH word ptr [BX + 0x3cd4] (1000_381A / 0x1381A)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3CD4)]);
    CheckExternalEvents(cs7, 0x3823);
    // CALLF 0x1000:8055 (1000_381E / 0x1381E)
    FarCall(cs7, 0x3823, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3826);
    // ADD SP,0x4 (1000_3823 / 0x13823)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3829);
    // MOV AX,0x3b4e (1000_3826 / 0x13826)
    AX = 0x3B4E;
    CheckExternalEvents(cs7, 0x382A);
    // PUSH DS (1000_3829 / 0x13829)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x382B);
    // PUSH AX (1000_382A / 0x1382A)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3830);
    // CALLF 0x1000:8055 (1000_382B / 0x1382B)
    FarCall(cs7, 0x3830, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3833);
    // ADD SP,0x4 (1000_3830 / 0x13830)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3836);
    // MOV AX,0x1 (1000_3833 / 0x13833)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x3837);
    // PUSH AX (1000_3836 / 0x13836)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x383C);
    // CALLF 0x0000:3113 (1000_3837 / 0x13837)
    FarCall(cs7, 0x383C, unknown_0170_1A13_03113);
    CheckExternalEvents(cs7, 0x383F);
    // ADD SP,0x2 (1000_383C / 0x1383C)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3841);
    // OR AX,AX (1000_383F / 0x1383F)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x3843);
    // JZ 0x1000:389a (1000_3841 / 0x13841)
    if(ZeroFlag) {
      goto label_1000_389A_1389A;
    }
    CheckExternalEvents(cs7, 0x3846);
    // INC word ptr [BP + -0xc] (1000_3843 / 0x13843)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x384B);
    // CALLF 0x1000:7fe8 (1000_3846 / 0x13846)
    FarCall(cs7, 0x384B, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x384E);
    // MOV AX,0x3b58 (1000_384B / 0x1384B)
    AX = 0x3B58;
    CheckExternalEvents(cs7, 0x384F);
    // PUSH DS (1000_384E / 0x1384E)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3850);
    // PUSH AX (1000_384F / 0x1384F)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3855);
    // CALLF 0x1000:8055 (1000_3850 / 0x13850)
    FarCall(cs7, 0x3855, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3858);
    // ADD SP,0x4 (1000_3855 / 0x13855)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x385B);
    // MOV AX,0x3b8c (1000_3858 / 0x13858)
    AX = 0x3B8C;
    CheckExternalEvents(cs7, 0x385C);
    // PUSH DS (1000_385B / 0x1385B)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x385D);
    // PUSH AX (1000_385C / 0x1385C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3862);
    // CALLF 0x1000:8055 (1000_385D / 0x1385D)
    FarCall(cs7, 0x3862, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3865);
    // ADD SP,0x4 (1000_3862 / 0x13862)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x386A);
    // MOV word ptr [BP + -0xa],0x0 (1000_3865 / 0x13865)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    label_1000_386A_1386A:
    CheckExternalEvents(cs7, 0x386D);
    // MOV AX,0x30 (1000_386A / 0x1386A)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x3870);
    // IMUL word ptr [BP + 0x6] (1000_386D / 0x1386D)
    int resImul1000_386D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_386D);
    DX = (ushort)(resImul1000_386D >> 16);
    CheckExternalEvents(cs7, 0x3872);
    // MOV BX,AX (1000_3870 / 0x13870)
    BX = AX;
    CheckExternalEvents(cs7, 0x3875);
    // ADD BX,word ptr [BP + -0xa] (1000_3872 / 0x13872)
    // BX += UInt16[SS, (ushort)(BP - 0xA)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x3879);
    // MOV ES,word ptr [0x55dc] (1000_3875 / 0x13875)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x387F);
    // MOV byte ptr ES:[BX + 0x32c6],0xff (1000_3879 / 0x13879)
    UInt8[ES, (ushort)(BX + 0x32C6)] = 0xFF;
    CheckExternalEvents(cs7, 0x3882);
    // INC word ptr [BP + -0xa] (1000_387F / 0x1387F)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    CheckExternalEvents(cs7, 0x3886);
    // CMP word ptr [BP + -0xa],0x30 (1000_3882 / 0x13882)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x30);
    CheckExternalEvents(cs7, 0x3888);
    // JL 0x1000:386a (1000_3886 / 0x13886)
    if(SignFlag != OverflowFlag) {
      goto label_1000_386A_1386A;
    }
    CheckExternalEvents(cs7, 0x388A);
    // SUB AX,AX (1000_3888 / 0x13888)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x388B);
    // PUSH AX (1000_388A / 0x1388A)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x388E);
    // PUSH word ptr [BP + 0x6] (1000_388B / 0x1388B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x388F);
    // PUSH CS (1000_388E / 0x1388E)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x3892);
    // CALL 0x1000:3224 (1000_388F / 0x1388F)
    NearCall(cs7, 0x3892, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs7, 0x3895);
    // ADD SP,0x4 (1000_3892 / 0x13892)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x389A);
    // CALLF 0x1000:8d29 (1000_3895 / 0x13895)
    FarCall(cs7, 0x389A, unknown_18AD_0259_18D29);
    label_1000_389A_1389A:
    CheckExternalEvents(cs7, 0x389E);
    // CMP word ptr [BP + -0xc],0x0 (1000_389A / 0x1389A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs7, 0x38A0);
    // JNZ 0x1000:38a3 (1000_389E / 0x1389E)
    if(!ZeroFlag) {
      goto label_1000_38A3_138A3;
    }
    CheckExternalEvents(cs7, 0x38A3);
    // JMP 0x1000:3cd6 (1000_38A0 / 0x138A0)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_3CD6_13CD6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_38A3_138A3:
    CheckExternalEvents(cs7, 0x38A8);
    // MOV word ptr [BP + -0xa],0x0 (1000_38A3 / 0x138A3)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs7, 0x38AA);
    // JMP 0x1000:38ae (1000_38A8 / 0x138A8)
    goto label_1000_38AE_138AE;
    label_1000_38AA_138AA:
    CheckExternalEvents(cs7, 0x38AE);
    // ADD word ptr [BP + -0xa],0x4 (1000_38AA / 0x138AA)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x4;
    label_1000_38AE_138AE:
    CheckExternalEvents(cs7, 0x38B2);
    // CMP word ptr [BP + -0xa],0x30 (1000_38AE / 0x138AE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x30);
    CheckExternalEvents(cs7, 0x38B4);
    // JGE 0x1000:38cb (1000_38B2 / 0x138B2)
    if(SignFlag == OverflowFlag) {
      goto label_1000_38CB_138CB;
    }
    CheckExternalEvents(cs7, 0x38B7);
    // MOV AX,0x30 (1000_38B4 / 0x138B4)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x38BA);
    // IMUL word ptr [BP + 0x6] (1000_38B7 / 0x138B7)
    int resImul1000_38B7 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_38B7);
    DX = (ushort)(resImul1000_38B7 >> 16);
    CheckExternalEvents(cs7, 0x38BC);
    // MOV BX,AX (1000_38BA / 0x138BA)
    BX = AX;
    CheckExternalEvents(cs7, 0x38BF);
    // ADD BX,word ptr [BP + -0xa] (1000_38BC / 0x138BC)
    // BX += UInt16[SS, (ushort)(BP - 0xA)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x38C3);
    // MOV ES,word ptr [0x55dc] (1000_38BF / 0x138BF)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x38C9);
    // CMP byte ptr ES:[BX + 0x32c6],0xff (1000_38C3 / 0x138C3)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x32C6)], 0xFF);
    CheckExternalEvents(cs7, 0x38CB);
    // JNZ 0x1000:38aa (1000_38C9 / 0x138C9)
    if(!ZeroFlag) {
      goto label_1000_38AA_138AA;
    }
    label_1000_38CB_138CB:
    CheckExternalEvents(cs7, 0x38CF);
    // CMP word ptr [BP + 0x6],0x4 (1000_38CB / 0x138CB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x38D1);
    // JGE 0x1000:38e0 (1000_38CF / 0x138CF)
    if(SignFlag == OverflowFlag) {
      goto label_1000_38E0_138E0;
    }
    CheckExternalEvents(cs7, 0x38D4);
    // PUSH word ptr [BP + 0x8] (1000_38D1 / 0x138D1)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs7, 0x38D7);
    // PUSH word ptr [BP + 0x6] (1000_38D4 / 0x138D4)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x38D8);
    // PUSH CS (1000_38D7 / 0x138D7)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x38DB);
    // CALL 0x1000:3d6c (1000_38D8 / 0x138D8)
    NearCall(cs7, 0x38DB, ghidra_guess_1000_3D6C_13D6C);
    CheckExternalEvents(cs7, 0x38DE);
    // ADD SP,0x4 (1000_38DB / 0x138DB)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x38E0);
    // JMP 0x1000:38ea (1000_38DE / 0x138DE)
    goto label_1000_38EA_138EA;
    label_1000_38E0_138E0:
    CheckExternalEvents(cs7, 0x38E3);
    // PUSH word ptr [BP + 0x6] (1000_38E0 / 0x138E0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x38E4);
    // PUSH CS (1000_38E3 / 0x138E3)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x38E7);
    // CALL 0x1000:3f24 (1000_38E4 / 0x138E4)
    NearCall(cs7, 0x38E7, ghidra_guess_1000_3F24_13F24);
    CheckExternalEvents(cs7, 0x38EA);
    // ADD SP,0x2 (1000_38E7 / 0x138E7)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_38EA_138EA:
    CheckExternalEvents(cs7, 0x38ED);
    // PUSH word ptr [BP + 0x6] (1000_38EA / 0x138EA)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x38EE);
    // PUSH CS (1000_38ED / 0x138ED)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x38F1);
    // CALL 0x1000:33eb (1000_38EE / 0x138EE)
    NearCall(cs7, 0x38F1, ghidra_guess_1000_33EB_133EB);
    CheckExternalEvents(cs7, 0x38F4);
    // ADD SP,0x2 (1000_38F1 / 0x138F1)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x38F8);
    // MOV ES,word ptr [0x5610] (1000_38F4 / 0x138F4)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x38FC);
    // MOV AX,ES:[0x3778] (1000_38F8 / 0x138F8)
    AX = UInt16[ES, 0x3778];
    CheckExternalEvents(cs7, 0x38FF);
    // MOV word ptr [BP + -0x16],AX (1000_38FC / 0x138FC)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs7, 0x3903);
    // MOV ES,word ptr [0x5612] (1000_38FF / 0x138FF)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x3907);
    // MOV AX,ES:[0x377a] (1000_3903 / 0x13903)
    AX = UInt16[ES, 0x377A];
    CheckExternalEvents(cs7, 0x390A);
    // MOV word ptr [BP + -0x1a],AX (1000_3907 / 0x13907)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs7, 0x390D);
    // MOV AX,0x4 (1000_390A / 0x1390A)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x390E);
    // PUSH AX (1000_390D / 0x1390D)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3913);
    // CALLF 0x1000:7ee1 (1000_390E / 0x1390E)
    FarCall(cs7, 0x3913, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x3916);
    // ADD SP,0x2 (1000_3913 / 0x13913)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x391B);
    // CALLF 0x1000:7fe8 (1000_3916 / 0x13916)
    FarCall(cs7, 0x391B, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x391F);
    // MOV ES,word ptr [0x561a] (1000_391B / 0x1391B)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3925);
    // CMP word ptr ES:[0x3770],0x0 (1000_391F / 0x1391F)
    Alu16.Sub(UInt16[ES, 0x3770], 0x0);
    CheckExternalEvents(cs7, 0x3927);
    // JZ 0x1000:392a (1000_3925 / 0x13925)
    if(ZeroFlag) {
      goto label_1000_392A_1392A;
    }
    CheckExternalEvents(cs7, 0x392A);
    // JMP 0x1000:3a44 (1000_3927 / 0x13927)
    goto label_1000_3A44_13A44;
    label_1000_392A_1392A:
    CheckExternalEvents(cs7, 0x392E);
    // CMP word ptr [BP + 0x8],0x2 (1000_392A / 0x1392A)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x2);
    CheckExternalEvents(cs7, 0x3930);
    // JNZ 0x1000:3954 (1000_392E / 0x1392E)
    if(!ZeroFlag) {
      goto label_1000_3954_13954;
    }
    CheckExternalEvents(cs7, 0x3933);
    // MOV AX,0x7d (1000_3930 / 0x13930)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3936);
    // IMUL word ptr [BP + 0x6] (1000_3933 / 0x13933)
    int resImul1000_3933 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3933);
    DX = (ushort)(resImul1000_3933 >> 16);
    CheckExternalEvents(cs7, 0x3938);
    // MOV BX,AX (1000_3936 / 0x13936)
    BX = AX;
    CheckExternalEvents(cs7, 0x393C);
    // MOV ES,word ptr [0x55d4] (1000_3938 / 0x13938)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3942);
    // CMP byte ptr ES:[BX + 0xc756],0x0 (1000_393C / 0x1393C)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC756)], 0x0);
    CheckExternalEvents(cs7, 0x3944);
    // JNZ 0x1000:3954 (1000_3942 / 0x13942)
    if(!ZeroFlag) {
      goto label_1000_3954_13954;
    }
    CheckExternalEvents(cs7, 0x3947);
    // MOV AX,0x3bad (1000_3944 / 0x13944)
    AX = 0x3BAD;
    label_1000_3947_13947:
    CheckExternalEvents(cs7, 0x3948);
    // PUSH DS (1000_3947 / 0x13947)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3949);
    // PUSH AX (1000_3948 / 0x13948)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x394E);
    // CALLF 0x1000:8055 (1000_3949 / 0x13949)
    FarCall(cs7, 0x394E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3951);
    // ADD SP,0x4 (1000_394E / 0x1394E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3954);
    // JMP 0x1000:3a3c (1000_3951 / 0x13951)
    goto label_1000_3A3C_13A3C;
    label_1000_3954_13954:
    CheckExternalEvents(cs7, 0x3958);
    // CMP word ptr [BP + 0x6],0x4 (1000_3954 / 0x13954)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x395A);
    // JGE 0x1000:396e (1000_3958 / 0x13958)
    if(SignFlag == OverflowFlag) {
      goto label_1000_396E_1396E;
    }
    CheckExternalEvents(cs7, 0x395D);
    // MOV BX,word ptr [BP + 0x6] (1000_395A / 0x1395A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x3961);
    // MOV ES,word ptr [0x55ea] (1000_395D / 0x1395D)
    ES = UInt16[DS, 0x55EA];
    CheckExternalEvents(cs7, 0x3967);
    // CMP byte ptr ES:[BX + 0x6e],0x1e (1000_3961 / 0x13961)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x1E);
    CheckExternalEvents(cs7, 0x3969);
    // JNZ 0x1000:396e (1000_3967 / 0x13967)
    if(!ZeroFlag) {
      goto label_1000_396E_1396E;
    }
    CheckExternalEvents(cs7, 0x396C);
    // MOV AX,0x3bca (1000_3969 / 0x13969)
    AX = 0x3BCA;
    CheckExternalEvents(cs7, 0x396E);
    // JMP 0x1000:3947 (1000_396C / 0x1396C)
    goto label_1000_3947_13947;
    label_1000_396E_1396E:
    CheckExternalEvents(cs7, 0x3972);
    // CMP word ptr [BP + 0x6],0x4 (1000_396E / 0x1396E)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x3974);
    // JL 0x1000:398c (1000_3972 / 0x13972)
    if(SignFlag != OverflowFlag) {
      goto label_1000_398C_1398C;
    }
    CheckExternalEvents(cs7, 0x3978);
    // CMP word ptr [BP + 0x6],0xc (1000_3974 / 0x13974)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x397A);
    // JGE 0x1000:398c (1000_3978 / 0x13978)
    if(SignFlag == OverflowFlag) {
      goto label_1000_398C_1398C;
    }
    CheckExternalEvents(cs7, 0x397E);
    // MOV ES,word ptr [0x5624] (1000_397A / 0x1397A)
    ES = UInt16[DS, 0x5624];
    CheckExternalEvents(cs7, 0x3980);
    // SUB AX,AX (1000_397E / 0x1397E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3984);
    // MOV ES:[0x4592],AX (1000_3980 / 0x13980)
    UInt16[ES, 0x4592] = AX;
    CheckExternalEvents(cs7, 0x3988);
    // MOV ES,word ptr [0x5626] (1000_3984 / 0x13984)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x398C);
    // MOV ES:[0x377c],AX (1000_3988 / 0x13988)
    UInt16[ES, 0x377C] = AX;
    label_1000_398C_1398C:
    CheckExternalEvents(cs7, 0x3990);
    // MOV ES,word ptr [0x5626] (1000_398C / 0x1398C)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3996);
    // CMP word ptr ES:[0x377c],0x0 (1000_3990 / 0x13990)
    Alu16.Sub(UInt16[ES, 0x377C], 0x0);
    CheckExternalEvents(cs7, 0x3998);
    // JNZ 0x1000:39a4 (1000_3996 / 0x13996)
    if(!ZeroFlag) {
      goto label_1000_39A4_139A4;
    }
    CheckExternalEvents(cs7, 0x399C);
    // MOV ES,word ptr [0x5624] (1000_3998 / 0x13998)
    ES = UInt16[DS, 0x5624];
    CheckExternalEvents(cs7, 0x39A2);
    // CMP word ptr ES:[0x4592],0x0 (1000_399C / 0x1399C)
    Alu16.Sub(UInt16[ES, 0x4592], 0x0);
    CheckExternalEvents(cs7, 0x39A4);
    // JZ 0x1000:39d3 (1000_39A2 / 0x139A2)
    if(ZeroFlag) {
      goto label_1000_39D3_139D3;
    }
    label_1000_39A4_139A4:
    CheckExternalEvents(cs7, 0x39A7);
    // MOV AX,0x3bf3 (1000_39A4 / 0x139A4)
    AX = 0x3BF3;
    CheckExternalEvents(cs7, 0x39A8);
    // PUSH DS (1000_39A7 / 0x139A7)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x39A9);
    // PUSH AX (1000_39A8 / 0x139A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x39AE);
    // CALLF 0x1000:8055 (1000_39A9 / 0x139A9)
    FarCall(cs7, 0x39AE, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x39B1);
    // ADD SP,0x4 (1000_39AE / 0x139AE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x39B5);
    // MOV ES,word ptr [0x5626] (1000_39B1 / 0x139B1)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x39BB);
    // CMP word ptr ES:[0x377c],0x0 (1000_39B5 / 0x139B5)
    Alu16.Sub(UInt16[ES, 0x377C], 0x0);
    CheckExternalEvents(cs7, 0x39BD);
    // JZ 0x1000:39c2 (1000_39BB / 0x139BB)
    if(ZeroFlag) {
      goto label_1000_39C2_139C2;
    }
    CheckExternalEvents(cs7, 0x39C0);
    // MOV AX,0x3c0d (1000_39BD / 0x139BD)
    AX = 0x3C0D;
    CheckExternalEvents(cs7, 0x39C2);
    // JMP 0x1000:3a20 (1000_39C0 / 0x139C0)
    goto label_1000_3A20_13A20;
    label_1000_39C2_139C2:
    CheckExternalEvents(cs7, 0x39C6);
    // MOV ES,word ptr [0x5624] (1000_39C2 / 0x139C2)
    ES = UInt16[DS, 0x5624];
    CheckExternalEvents(cs7, 0x39CC);
    // CMP word ptr ES:[0x4592],0x0 (1000_39C6 / 0x139C6)
    Alu16.Sub(UInt16[ES, 0x4592], 0x0);
    CheckExternalEvents(cs7, 0x39CE);
    // JZ 0x1000:3a2a (1000_39CC / 0x139CC)
    if(ZeroFlag) {
      goto label_1000_3A2A_13A2A;
    }
    CheckExternalEvents(cs7, 0x39D1);
    // MOV AX,0x3c1a (1000_39CE / 0x139CE)
    AX = 0x3C1A;
    CheckExternalEvents(cs7, 0x39D3);
    // JMP 0x1000:3a20 (1000_39D1 / 0x139D1)
    goto label_1000_3A20_13A20;
    label_1000_39D3_139D3:
    CheckExternalEvents(cs7, 0x39D6);
    // MOV AX,0x3c33 (1000_39D3 / 0x139D3)
    AX = 0x3C33;
    CheckExternalEvents(cs7, 0x39D7);
    // PUSH DS (1000_39D6 / 0x139D6)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x39D8);
    // PUSH AX (1000_39D7 / 0x139D7)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x39DD);
    // CALLF 0x1000:8055 (1000_39D8 / 0x139D8)
    FarCall(cs7, 0x39DD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x39E0);
    // ADD SP,0x4 (1000_39DD / 0x139DD)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x39E4);
    // CMP word ptr [BP + 0x6],0x4 (1000_39E0 / 0x139E0)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x39E6);
    // JGE 0x1000:39f7 (1000_39E4 / 0x139E4)
    if(SignFlag == OverflowFlag) {
      goto label_1000_39F7_139F7;
    }
    CheckExternalEvents(cs7, 0x39E9);
    // MOV BX,word ptr [BP + 0x8] (1000_39E6 / 0x139E6)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x39EB);
    // SHL BX,0x1 (1000_39E9 / 0x139E9)
    BX <<= 0x1;
    CheckExternalEvents(cs7, 0x39ED);
    // SHL BX,0x1 (1000_39EB / 0x139EB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x39F1);
    // PUSH word ptr [BX + 0x3cd6] (1000_39ED / 0x139ED)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3CD6)]);
    CheckExternalEvents(cs7, 0x39F5);
    // PUSH word ptr [BX + 0x3cd4] (1000_39F1 / 0x139F1)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x3CD4)]);
    CheckExternalEvents(cs7, 0x39F7);
    // JMP 0x1000:39fc (1000_39F5 / 0x139F5)
    goto label_1000_39FC_139FC;
    label_1000_39F7_139F7:
    CheckExternalEvents(cs7, 0x39FA);
    // MOV AX,0x3c3e (1000_39F7 / 0x139F7)
    AX = 0x3C3E;
    CheckExternalEvents(cs7, 0x39FB);
    // PUSH DS (1000_39FA / 0x139FA)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x39FC);
    // PUSH AX (1000_39FB / 0x139FB)
    Stack.Push16(AX);
    label_1000_39FC_139FC:
    CheckExternalEvents(cs7, 0x3A01);
    // CALLF 0x1000:8055 (1000_39FC / 0x139FC)
    FarCall(cs7, 0x3A01, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3A04);
    // ADD SP,0x4 (1000_3A01 / 0x13A01)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3A07);
    // MOV AX,0x3c43 (1000_3A04 / 0x13A04)
    AX = 0x3C43;
    CheckExternalEvents(cs7, 0x3A08);
    // PUSH DS (1000_3A07 / 0x13A07)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3A09);
    // PUSH AX (1000_3A08 / 0x13A08)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A0E);
    // CALLF 0x1000:8055 (1000_3A09 / 0x13A09)
    FarCall(cs7, 0x3A0E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3A11);
    // ADD SP,0x4 (1000_3A0E / 0x13A0E)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x3A15);
    // CMP word ptr [BP + 0x6],0x4 (1000_3A11 / 0x13A11)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x3A17);
    // JGE 0x1000:3a2a (1000_3A15 / 0x13A15)
    if(SignFlag == OverflowFlag) {
      goto label_1000_3A2A_13A2A;
    }
    CheckExternalEvents(cs7, 0x3A1B);
    // CMP word ptr [BP + 0x8],0x1 (1000_3A17 / 0x13A17)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x1);
    CheckExternalEvents(cs7, 0x3A1D);
    // JZ 0x1000:3a2a (1000_3A1B / 0x13A1B)
    if(ZeroFlag) {
      goto label_1000_3A2A_13A2A;
    }
    CheckExternalEvents(cs7, 0x3A20);
    // MOV AX,0x3c5b (1000_3A1D / 0x13A1D)
    AX = 0x3C5B;
    label_1000_3A20_13A20:
    CheckExternalEvents(cs7, 0x3A21);
    // PUSH DS (1000_3A20 / 0x13A20)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3A22);
    // PUSH AX (1000_3A21 / 0x13A21)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A27);
    // CALLF 0x1000:8055 (1000_3A22 / 0x13A22)
    FarCall(cs7, 0x3A27, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3A2A);
    // ADD SP,0x4 (1000_3A27 / 0x13A27)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1000_3A2A_13A2A:
    CheckExternalEvents(cs7, 0x3A2E);
    // MOV ES,word ptr [0x5624] (1000_3A2A / 0x13A2A)
    ES = UInt16[DS, 0x5624];
    CheckExternalEvents(cs7, 0x3A30);
    // SUB AX,AX (1000_3A2E / 0x13A2E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3A34);
    // MOV ES:[0x4592],AX (1000_3A30 / 0x13A30)
    UInt16[ES, 0x4592] = AX;
    CheckExternalEvents(cs7, 0x3A38);
    // MOV ES,word ptr [0x5626] (1000_3A34 / 0x13A34)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3A3C);
    // MOV ES:[0x377c],AX (1000_3A38 / 0x13A38)
    UInt16[ES, 0x377C] = AX;
    label_1000_3A3C_13A3C:
    CheckExternalEvents(cs7, 0x3A41);
    // CALLF 0x0000:414f (1000_3A3C / 0x13A3C)
    FarCall(cs7, 0x3A41, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs7, 0x3A44);
    // JMP 0x1000:3cd6 (1000_3A41 / 0x13A41)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_3CD6_13CD6, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_3A44_13A44:
    CheckExternalEvents(cs7, 0x3A47);
    // MOV AX,0x3c89 (1000_3A44 / 0x13A44)
    AX = 0x3C89;
    CheckExternalEvents(cs7, 0x3A48);
    // PUSH DS (1000_3A47 / 0x13A47)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3A49);
    // PUSH AX (1000_3A48 / 0x13A48)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A4E);
    // CALLF 0x1000:8055 (1000_3A49 / 0x13A49)
    FarCall(cs7, 0x3A4E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3A51);
    // ADD SP,0x4 (1000_3A4E / 0x13A4E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3A55);
    // MOV ES,word ptr [0x561a] (1000_3A51 / 0x13A51)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3A5A);
    // PUSH word ptr ES:[0x3770] (1000_3A55 / 0x13A55)
    Stack.Push16(UInt16[ES, 0x3770]);
    CheckExternalEvents(cs7, 0x3A5F);
    // CALLF 0x1000:8b23 (1000_3A5A / 0x13A5A)
    FarCall(cs7, 0x3A5F, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs7, 0x3A62);
    // ADD SP,0x2 (1000_3A5F / 0x13A5F)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3A65);
    // MOV AX,0x3c93 (1000_3A62 / 0x13A62)
    AX = 0x3C93;
    CheckExternalEvents(cs7, 0x3A66);
    // PUSH DS (1000_3A65 / 0x13A65)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3A67);
    // PUSH AX (1000_3A66 / 0x13A66)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A6C);
    // CALLF 0x1000:8055 (1000_3A67 / 0x13A67)
    FarCall(cs7, 0x3A6C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3A6F);
    // ADD SP,0x4 (1000_3A6C / 0x13A6C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3A72);
    // MOV AX,0xe (1000_3A6F / 0x13A6F)
    AX = 0xE;
    CheckExternalEvents(cs7, 0x3A73);
    // PUSH AX (1000_3A72 / 0x13A72)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A76);
    // MOV AX,0x1 (1000_3A73 / 0x13A73)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x3A77);
    // PUSH AX (1000_3A76 / 0x13A76)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A7B);
    // MOV ES,word ptr [0x5612] (1000_3A77 / 0x13A77)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x3A80);
    // PUSH word ptr ES:[0x377a] (1000_3A7B / 0x13A7B)
    Stack.Push16(UInt16[ES, 0x377A]);
    CheckExternalEvents(cs7, 0x3A84);
    // MOV ES,word ptr [0x5610] (1000_3A80 / 0x13A80)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x3A89);
    // PUSH word ptr ES:[0x3778] (1000_3A84 / 0x13A84)
    Stack.Push16(UInt16[ES, 0x3778]);
    CheckExternalEvents(cs7, 0x3A8E);
    // CALLF 0x1000:ca77 (1000_3A89 / 0x13A89)
    FarCall(cs7, 0x3A8E, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs7, 0x3A91);
    // ADD SP,0x8 (1000_3A8E / 0x13A8E)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_1000_3A91_13A91:
    CheckExternalEvents(cs7, 0x3A96);
    // CALLF 0x1000:8d29 (1000_3A91 / 0x13A91)
    FarCall(cs7, 0x3A96, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs7, 0x3A97);
    // PUSH AX (1000_3A96 / 0x13A96)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3A9C);
    // CALLF 0x1000:897d (1000_3A97 / 0x13A97)
    FarCall(cs7, 0x3A9C, unknown_17C6_0D1D_1897D);
    CheckExternalEvents(cs7, 0x3A9F);
    // ADD SP,0x2 (1000_3A9C / 0x13A9C)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3AA2);
    // MOV word ptr [BP + -0x12],AX (1000_3A9F / 0x13A9F)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs7, 0x3AA4);
    // SUB AX,AX (1000_3AA2 / 0x13AA2)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3AA7);
    // MOV word ptr [BP + -0x8],AX (1000_3AA4 / 0x13AA4)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x3AAA);
    // MOV word ptr [BP + -0x4],AX (1000_3AA7 / 0x13AA7)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x3AAD);
    // MOV AX,word ptr [BP + -0x12] (1000_3AAA / 0x13AAA)
    AX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs7, 0x3AB0);
    // SUB AX,0xffaf (1000_3AAD / 0x13AAD)
    AX -= 0xFFAF;
    CheckExternalEvents(cs7, 0x3AB3);
    // CMP AX,0xa (1000_3AB0 / 0x13AB0)
    Alu16.Sub(AX, 0xA);
    CheckExternalEvents(cs7, 0x3AB5);
    // JA 0x1000:3b0f (1000_3AB3 / 0x13AB3)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_3B0F_13B0F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0x3AB7);
    // ADD AX,AX (1000_3AB5 / 0x13AB5)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs7, 0x3AB8);
    // XCHG AX,BX (1000_3AB7 / 0x13AB7)
    (BX, AX) = (AX, BX);
    label_1000_3AB8_13AB8:
    CheckExternalEvents(cs7, 0x3ABD);
    // JMP word ptr CS:[BX + 0x2049] (1000_3AB8 / 0x13AB8)
    // Indirect jump to word ptr CS:[BX + 0x2049], generating possible targets from emulator records
    uint targetAddress_1000_3AB8 = (uint)(cs7 * 0x10 + UInt16[cs7, (ushort)(BX + 0x2049)] - cs1 * 0x10);
    switch(targetAddress_1000_3AB8) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_3AB8));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_1000_3B0F_13B0F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3B0F_13B0F:
    CheckExternalEvents(cs7, 0x3B13);
    // MOV ES,word ptr [0x5610] (1000_3B0F / 0x13B0F)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x3B16);
    // MOV AX,word ptr [BP + -0x4] (1000_3B13 / 0x13B13)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3B1B);
    // ADD word ptr ES:[0x3778],AX (1000_3B16 / 0x13B16)
    UInt16[ES, 0x3778] += AX;
    CheckExternalEvents(cs7, 0x3B21);
    // CMP word ptr ES:[0x3778],0xd (1000_3B1B / 0x13B1B)
    Alu16.Sub(UInt16[ES, 0x3778], 0xD);
    CheckExternalEvents(cs7, 0x3B23);
    // JL 0x1000:3b2b (1000_3B21 / 0x13B21)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3B2B_13B2B;
    }
    CheckExternalEvents(cs7, 0x3B29);
    // CMP word ptr ES:[0x3778],0x27 (1000_3B23 / 0x13B23)
    Alu16.Sub(UInt16[ES, 0x3778], 0x27);
    CheckExternalEvents(cs7, 0x3B2B);
    // JLE 0x1000:3b33 (1000_3B29 / 0x13B29)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_3B33_13B33;
    }
    label_1000_3B2B_13B2B:
    CheckExternalEvents(cs7, 0x3B2E);
    // MOV AX,word ptr [BP + -0x4] (1000_3B2B / 0x13B2B)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3B33);
    // SUB word ptr ES:[0x3778],AX (1000_3B2E / 0x13B2E)
    // UInt16[ES, 0x3778] -= AX;
    UInt16[ES, 0x3778] = Alu16.Sub(UInt16[ES, 0x3778], AX);
    label_1000_3B33_13B33:
    CheckExternalEvents(cs7, 0x3B37);
    // MOV ES,word ptr [0x5612] (1000_3B33 / 0x13B33)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x3B3A);
    // MOV AX,word ptr [BP + -0x8] (1000_3B37 / 0x13B37)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x3B3F);
    // ADD word ptr ES:[0x377a],AX (1000_3B3A / 0x13B3A)
    // UInt16[ES, 0x377A] += AX;
    UInt16[ES, 0x377A] = Alu16.Add(UInt16[ES, 0x377A], AX);
    CheckExternalEvents(cs7, 0x3B41);
    // JS 0x1000:3b49 (1000_3B3F / 0x13B3F)
    if(SignFlag) {
      goto label_1000_3B49_13B49;
    }
    CheckExternalEvents(cs7, 0x3B47);
    // CMP word ptr ES:[0x377a],0x18 (1000_3B41 / 0x13B41)
    Alu16.Sub(UInt16[ES, 0x377A], 0x18);
    CheckExternalEvents(cs7, 0x3B49);
    // JLE 0x1000:3b51 (1000_3B47 / 0x13B47)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_3B51_13B51;
    }
    label_1000_3B49_13B49:
    CheckExternalEvents(cs7, 0x3B4C);
    // MOV AX,word ptr [BP + -0x8] (1000_3B49 / 0x13B49)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x3B51);
    // SUB word ptr ES:[0x377a],AX (1000_3B4C / 0x13B4C)
    // UInt16[ES, 0x377A] -= AX;
    UInt16[ES, 0x377A] = Alu16.Sub(UInt16[ES, 0x377A], AX);
    label_1000_3B51_13B51:
    CheckExternalEvents(cs7, 0x3B54);
    // MOV AX,word ptr [BP + -0x4] (1000_3B51 / 0x13B51)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3B57);
    // OR AX,word ptr [BP + -0x8] (1000_3B54 / 0x13B54)
    // AX |= UInt16[SS, (ushort)(BP - 0x8)];
    AX = Alu16.Or(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0x3B59);
    // JNZ 0x1000:3b5c (1000_3B57 / 0x13B57)
    if(!ZeroFlag) {
      goto label_1000_3B5C_13B5C;
    }
    CheckExternalEvents(cs7, 0x3B5C);
    // JMP 0x1000:3cc7 (1000_3B59 / 0x13B59)
    goto label_1000_3CC7_13CC7;
    label_1000_3B5C_13B5C:
    CheckExternalEvents(cs7, 0x3B60);
    // MOV ES,word ptr [0x55cc] (1000_3B5C / 0x13B5C)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x3B64);
    // MOV AX,ES:[0xa44b] (1000_3B60 / 0x13B60)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x3B67);
    // MOV word ptr [BP + -0x10],AX (1000_3B64 / 0x13B64)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs7, 0x3B6B);
    // MOV ES,word ptr [0x55ce] (1000_3B67 / 0x13B67)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x3B6F);
    // MOV AX,ES:[0xa44d] (1000_3B6B / 0x13B6B)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x3B72);
    // MOV word ptr [BP + -0x14],AX (1000_3B6F / 0x13B6F)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs7, 0x3B76);
    // MOV ES,word ptr [0x5612] (1000_3B72 / 0x13B72)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x3B7A);
    // MOV AX,ES:[0x377a] (1000_3B76 / 0x13B76)
    AX = UInt16[ES, 0x377A];
    CheckExternalEvents(cs7, 0x3B7D);
    // SUB AX,0xc (1000_3B7A / 0x13B7A)
    // AX -= 0xC;
    AX = Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs7, 0x3B7E);
    // PUSH AX (1000_3B7D / 0x13B7D)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3B82);
    // MOV ES,word ptr [0x5610] (1000_3B7E / 0x13B7E)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x3B86);
    // MOV AX,ES:[0x3778] (1000_3B82 / 0x13B82)
    AX = UInt16[ES, 0x3778];
    CheckExternalEvents(cs7, 0x3B89);
    // SUB AX,0x1a (1000_3B86 / 0x13B86)
    // AX -= 0x1A;
    AX = Alu16.Sub(AX, 0x1A);
    CheckExternalEvents(cs7, 0x3B8A);
    // PUSH AX (1000_3B89 / 0x13B89)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3B8F);
    // CALLF 0x0000:301b (1000_3B8A / 0x13B8A)
    FarCall(cs7, 0x3B8F, unknown_0170_191B_0301B);
    CheckExternalEvents(cs7, 0x3B92);
    // ADD SP,0x4 (1000_3B8F / 0x13B8F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3B96);
    // MOV ES,word ptr [0x55cc] (1000_3B92 / 0x13B92)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x3B9A);
    // MOV AX,ES:[0xa44b] (1000_3B96 / 0x13B96)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x3B9D);
    // AND AX,0x7f (1000_3B9A / 0x13B9A)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs7, 0x3BA0);
    // MOV word ptr [BP + -0x2],AX (1000_3B9D / 0x13B9D)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x3BA4);
    // MOV ES,word ptr [0x55ce] (1000_3BA0 / 0x13BA0)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x3BA8);
    // MOV AX,ES:[0xa44d] (1000_3BA4 / 0x13BA4)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x3BAB);
    // AND AX,0x7f (1000_3BA8 / 0x13BA8)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs7, 0x3BAE);
    // MOV word ptr [BP + -0x6],AX (1000_3BAB / 0x13BAB)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x3BB2);
    // MOV AX,ES:[0xa44d] (1000_3BAE / 0x13BAE)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x3BB5);
    // AND AX,0xf000 (1000_3BB2 / 0x13BB2)
    // AX &= 0xF000;
    AX = Alu16.And(AX, 0xF000);
    CheckExternalEvents(cs7, 0x3BB9);
    // MOV ES,word ptr [0x55cc] (1000_3BB5 / 0x13BB5)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x3BBE);
    // MOV CX,word ptr ES:[0xa44b] (1000_3BB9 / 0x13BB9)
    CX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x3BC2);
    // AND CX,0xf00 (1000_3BBE / 0x13BBE)
    // CX &= 0xF00;
    CX = Alu16.And(CX, 0xF00);
    CheckExternalEvents(cs7, 0x3BC4);
    // OR AX,CX (1000_3BC2 / 0x13BC2)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x3BC6);
    // MOV AL,AH (1000_3BC4 / 0x13BC4)
    AL = AH;
    CheckExternalEvents(cs7, 0x3BC8);
    // SUB AH,AH (1000_3BC6 / 0x13BC6)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x3BCB);
    // MOV word ptr [BP + -0x18],AX (1000_3BC8 / 0x13BC8)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs7, 0x3BD0);
    // MOV word ptr [BP + -0x8],0x1 (1000_3BCB / 0x13BCB)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs7, 0x3BD5);
    // MOV word ptr [BP + -0x4],0x0 (1000_3BD0 / 0x13BD0)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x3BD7);
    // JMP 0x1000:3c1d (1000_3BD5 / 0x13BD5)
    goto label_1000_3C1D_13C1D;
    label_1000_3BD7_13BD7:
    CheckExternalEvents(cs7, 0x3BDA);
    // MOV AX,0x30 (1000_3BD7 / 0x13BD7)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x3BDD);
    // IMUL word ptr [BP + 0x6] (1000_3BDA / 0x13BDA)
    int resImul1000_3BDA = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3BDA);
    DX = (ushort)(resImul1000_3BDA >> 16);
    CheckExternalEvents(cs7, 0x3BDF);
    // MOV SI,AX (1000_3BDD / 0x13BDD)
    SI = AX;
    CheckExternalEvents(cs7, 0x3BE2);
    // MOV DI,word ptr [BP + -0x4] (1000_3BDF / 0x13BDF)
    DI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3BE4);
    // ADD DI,SI (1000_3BE2 / 0x13BE2)
    // DI += SI;
    DI = Alu16.Add(DI, SI);
    CheckExternalEvents(cs7, 0x3BE8);
    // MOV ES,word ptr [0x55dc] (1000_3BE4 / 0x13BE4)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x3BED);
    // MOV AL,byte ptr ES:[DI + 0x32c7] (1000_3BE8 / 0x13BE8)
    AL = UInt8[ES, (ushort)(DI + 0x32C7)];
    CheckExternalEvents(cs7, 0x3BEE);
    // CBW  (1000_3BED / 0x13BED)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3BF1);
    // CMP AX,word ptr [BP + -0x18] (1000_3BEE / 0x13BEE)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x18)]);
    CheckExternalEvents(cs7, 0x3BF3);
    // JNZ 0x1000:3c19 (1000_3BF1 / 0x13BF1)
    if(!ZeroFlag) {
      goto label_1000_3C19_13C19;
    }
    CheckExternalEvents(cs7, 0x3BF8);
    // MOV AL,byte ptr ES:[DI + 0x32c8] (1000_3BF3 / 0x13BF3)
    AL = UInt8[ES, (ushort)(DI + 0x32C8)];
    CheckExternalEvents(cs7, 0x3BF9);
    // CBW  (1000_3BF8 / 0x13BF8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3BFC);
    // CMP AX,word ptr [BP + -0x2] (1000_3BF9 / 0x13BF9)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x3BFE);
    // JNZ 0x1000:3c19 (1000_3BFC / 0x13BFC)
    if(!ZeroFlag) {
      goto label_1000_3C19_13C19;
    }
    CheckExternalEvents(cs7, 0x3C03);
    // MOV AL,byte ptr ES:[DI + 0x32c9] (1000_3BFE / 0x13BFE)
    AL = UInt8[ES, (ushort)(DI + 0x32C9)];
    CheckExternalEvents(cs7, 0x3C04);
    // CBW  (1000_3C03 / 0x13C03)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3C07);
    // CMP AX,word ptr [BP + -0x6] (1000_3C04 / 0x13C04)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs7, 0x3C09);
    // JNZ 0x1000:3c19 (1000_3C07 / 0x13C07)
    if(!ZeroFlag) {
      goto label_1000_3C19_13C19;
    }
    CheckExternalEvents(cs7, 0x3C0E);
    // MOV word ptr [BP + -0x8],0x0 (1000_3C09 / 0x13C09)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs7, 0x3C11);
    // MOV BX,word ptr [BP + -0xa] (1000_3C0E / 0x13C0E)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x3C13);
    // ADD BX,SI (1000_3C11 / 0x13C11)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0x3C19);
    // MOV byte ptr ES:[BX + 0x32c6],0xff (1000_3C13 / 0x13C13)
    UInt8[ES, (ushort)(BX + 0x32C6)] = 0xFF;
    label_1000_3C19_13C19:
    CheckExternalEvents(cs7, 0x3C1D);
    // ADD word ptr [BP + -0x4],0x4 (1000_3C19 / 0x13C19)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x4;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    label_1000_3C1D_13C1D:
    CheckExternalEvents(cs7, 0x3C20);
    // MOV AX,word ptr [BP + -0xa] (1000_3C1D / 0x13C1D)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x3C23);
    // CMP word ptr [BP + -0x4],AX (1000_3C20 / 0x13C20)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x3C25);
    // JL 0x1000:3bd7 (1000_3C23 / 0x13C23)
    if(SignFlag != OverflowFlag) {
      goto label_1000_3BD7_13BD7;
    }
    CheckExternalEvents(cs7, 0x3C29);
    // CMP word ptr [BP + -0x8],0x0 (1000_3C25 / 0x13C25)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs7, 0x3C2B);
    // JZ 0x1000:3c5a (1000_3C29 / 0x13C29)
    if(ZeroFlag) {
      goto label_1000_3C5A_13C5A;
    }
    CheckExternalEvents(cs7, 0x3C2E);
    // MOV AX,0x30 (1000_3C2B / 0x13C2B)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x3C31);
    // IMUL word ptr [BP + 0x6] (1000_3C2E / 0x13C2E)
    int resImul1000_3C2E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3C2E);
    DX = (ushort)(resImul1000_3C2E >> 16);
    CheckExternalEvents(cs7, 0x3C33);
    // MOV SI,AX (1000_3C31 / 0x13C31)
    SI = AX;
    CheckExternalEvents(cs7, 0x3C36);
    // ADD SI,word ptr [BP + -0xa] (1000_3C33 / 0x13C33)
    // SI += UInt16[SS, (ushort)(BP - 0xA)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x3C39);
    // MOV AL,byte ptr [BP + 0x8] (1000_3C36 / 0x13C36)
    AL = UInt8[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x3C3D);
    // MOV ES,word ptr [0x55dc] (1000_3C39 / 0x13C39)
    ES = UInt16[DS, 0x55DC];
    CheckExternalEvents(cs7, 0x3C42);
    // MOV byte ptr ES:[SI + 0x32c6],AL (1000_3C3D / 0x13C3D)
    UInt8[ES, (ushort)(SI + 0x32C6)] = AL;
    CheckExternalEvents(cs7, 0x3C45);
    // MOV AL,byte ptr [BP + -0x18] (1000_3C42 / 0x13C42)
    AL = UInt8[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs7, 0x3C4A);
    // MOV byte ptr ES:[SI + 0x32c7],AL (1000_3C45 / 0x13C45)
    UInt8[ES, (ushort)(SI + 0x32C7)] = AL;
    CheckExternalEvents(cs7, 0x3C4D);
    // MOV AL,byte ptr [BP + -0x2] (1000_3C4A / 0x13C4A)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x3C52);
    // MOV byte ptr ES:[SI + 0x32c8],AL (1000_3C4D / 0x13C4D)
    UInt8[ES, (ushort)(SI + 0x32C8)] = AL;
    CheckExternalEvents(cs7, 0x3C55);
    // MOV AL,byte ptr [BP + -0x6] (1000_3C52 / 0x13C52)
    AL = UInt8[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0x3C5A);
    // MOV byte ptr ES:[SI + 0x32c9],AL (1000_3C55 / 0x13C55)
    UInt8[ES, (ushort)(SI + 0x32C9)] = AL;
    label_1000_3C5A_13C5A:
    CheckExternalEvents(cs7, 0x3C5E);
    // MOV ES,word ptr [0x55cc] (1000_3C5A / 0x13C5A)
    ES = UInt16[DS, 0x55CC];
    CheckExternalEvents(cs7, 0x3C61);
    // MOV AX,word ptr [BP + -0x10] (1000_3C5E / 0x13C5E)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs7, 0x3C65);
    // MOV ES:[0xa44b],AX (1000_3C61 / 0x13C61)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs7, 0x3C69);
    // MOV ES,word ptr [0x55ce] (1000_3C65 / 0x13C65)
    ES = UInt16[DS, 0x55CE];
    CheckExternalEvents(cs7, 0x3C6C);
    // MOV AX,word ptr [BP + -0x14] (1000_3C69 / 0x13C69)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs7, 0x3C70);
    // MOV ES:[0xa44d],AX (1000_3C6C / 0x13C6C)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs7, 0x3C74);
    // MOV ES,word ptr [0x5610] (1000_3C70 / 0x13C70)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x3C78);
    // MOV AX,ES:[0x3778] (1000_3C74 / 0x13C74)
    AX = UInt16[ES, 0x3778];
    CheckExternalEvents(cs7, 0x3C7B);
    // MOV word ptr [BP + -0x1c],AX (1000_3C78 / 0x13C78)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs7, 0x3C7F);
    // MOV ES,word ptr [0x5612] (1000_3C7B / 0x13C7B)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x3C83);
    // MOV AX,ES:[0x377a] (1000_3C7F / 0x13C7F)
    AX = UInt16[ES, 0x377A];
    CheckExternalEvents(cs7, 0x3C86);
    // MOV word ptr [BP + -0x36],AX (1000_3C83 / 0x13C83)
    UInt16[SS, (ushort)(BP - 0x36)] = AX;
    CheckExternalEvents(cs7, 0x3C88);
    // SUB AX,AX (1000_3C86 / 0x13C86)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3C89);
    // PUSH AX (1000_3C88 / 0x13C88)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3C8C);
    // PUSH word ptr [BP + 0x6] (1000_3C89 / 0x13C89)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x3C8D);
    // PUSH CS (1000_3C8C / 0x13C8C)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x3C90);
    // CALL 0x1000:3224 (1000_3C8D / 0x13C8D)
    NearCall(cs7, 0x3C90, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs7, 0x3C93);
    // ADD SP,0x4 (1000_3C90 / 0x13C90)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3C97);
    // MOV ES,word ptr [0x5610] (1000_3C93 / 0x13C93)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x3C9A);
    // MOV AX,word ptr [BP + -0x1c] (1000_3C97 / 0x13C97)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs7, 0x3C9E);
    // MOV ES:[0x3778],AX (1000_3C9A / 0x13C9A)
    UInt16[ES, 0x3778] = AX;
    CheckExternalEvents(cs7, 0x3CA2);
    // MOV ES,word ptr [0x5612] (1000_3C9E / 0x13C9E)
    ES = UInt16[DS, 0x5612];
    CheckExternalEvents(cs7, 0x3CA5);
    // MOV AX,word ptr [BP + -0x36] (1000_3CA2 / 0x13CA2)
    AX = UInt16[SS, (ushort)(BP - 0x36)];
    CheckExternalEvents(cs7, 0x3CA9);
    // MOV ES:[0x377a],AX (1000_3CA5 / 0x13CA5)
    UInt16[ES, 0x377A] = AX;
    CheckExternalEvents(cs7, 0x3CAC);
    // MOV AX,0xe (1000_3CA9 / 0x13CA9)
    AX = 0xE;
    CheckExternalEvents(cs7, 0x3CAD);
    // PUSH AX (1000_3CAC / 0x13CAC)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3CB0);
    // MOV AX,0x1 (1000_3CAD / 0x13CAD)
    AX = 0x1;
    CheckExternalEvents(cs7, 0x3CB1);
    // PUSH AX (1000_3CB0 / 0x13CB0)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3CB6);
    // PUSH word ptr ES:[0x377a] (1000_3CB1 / 0x13CB1)
    Stack.Push16(UInt16[ES, 0x377A]);
    CheckExternalEvents(cs7, 0x3CBA);
    // MOV ES,word ptr [0x5610] (1000_3CB6 / 0x13CB6)
    ES = UInt16[DS, 0x5610];
    CheckExternalEvents(cs7, 0x3CBF);
    // PUSH word ptr ES:[0x3778] (1000_3CBA / 0x13CBA)
    Stack.Push16(UInt16[ES, 0x3778]);
    CheckExternalEvents(cs7, 0x3CC4);
    // CALLF 0x1000:ca77 (1000_3CBF / 0x13CBF)
    FarCall(cs7, 0x3CC4, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs7, 0x3CC7);
    // ADD SP,0x8 (1000_3CC4 / 0x13CC4)
    SP += 0x8;
    label_1000_3CC7_13CC7:
    CheckExternalEvents(cs7, 0x3CCB);
    // CMP word ptr [BP + -0x12],0x20 (1000_3CC7 / 0x13CC7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x20);
    CheckExternalEvents(cs7, 0x3CCD);
    // JZ 0x1000:3cd6 (1000_3CCB / 0x13CCB)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_3CD6_13CD6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0x3CD1);
    // CMP word ptr [BP + -0x12],0xd (1000_3CCD / 0x13CCD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0xD);
    CheckExternalEvents(cs7, 0x3CD3);
    // JZ 0x1000:3cd6 (1000_3CD1 / 0x13CD1)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(ghidra_guess_1000_3CD6_13CD6, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0x3CD6);
    // JMP 0x1000:3a91 (1000_3CD3 / 0x13CD3)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_1000_36CF_136CF, 0x13A91 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action ghidra_guess_1000_3CD6_13CD6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3CD6_13CD6:
    CheckExternalEvents(cs7, 0x3CDB);
    // CALLF 0x1000:7fe8 (1000_3CD6 / 0x13CD6)
    FarCall(cs7, 0x3CDB, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x3CDC);
    // POP SI (1000_3CDB / 0x13CDB)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3CDD);
    // POP DI (1000_3CDC / 0x13CDC)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3CDF);
    // MOV SP,BP (1000_3CDD / 0x13CDD)
    SP = BP;
    CheckExternalEvents(cs7, 0x3CE0);
    // POP BP (1000_3CDF / 0x13CDF)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3CE1);
    // RETF  (1000_3CE0 / 0x13CE0)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_3CE1_13CE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3CE1_13CE1:
    CheckExternalEvents(cs7, 0x3CE2);
    // PUSH BP (1000_3CE1 / 0x13CE1)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x3CE4);
    // MOV BP,SP (1000_3CE2 / 0x13CE2)
    BP = SP;
    CheckExternalEvents(cs7, 0x3CE7);
    // MOV AX,0x4 (1000_3CE4 / 0x13CE4)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x3CEC);
    // CALLF 0x1000:cecc (1000_3CE7 / 0x13CE7)
    FarCall(cs7, 0x3CEC, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x3CED);
    // PUSH SI (1000_3CEC / 0x13CEC)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x3CF0);
    // MOV AX,0x4 (1000_3CED / 0x13CED)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x3CF1);
    // PUSH AX (1000_3CF0 / 0x13CF0)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3CF6);
    // CALLF 0x1000:7ee1 (1000_3CF1 / 0x13CF1)
    FarCall(cs7, 0x3CF6, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0x3CF9);
    // ADD SP,0x2 (1000_3CF6 / 0x13CF6)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x3CFE);
    // CALLF 0x1000:7fe8 (1000_3CF9 / 0x13CF9)
    FarCall(cs7, 0x3CFE, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0x3D01);
    // MOV AX,0x7d (1000_3CFE / 0x13CFE)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3D04);
    // IMUL word ptr [BP + 0x6] (1000_3D01 / 0x13D01)
    int resImul1000_3D01 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3D01);
    DX = (ushort)(resImul1000_3D01 >> 16);
    CheckExternalEvents(cs7, 0x3D06);
    // MOV SI,AX (1000_3D04 / 0x13D04)
    SI = AX;
    CheckExternalEvents(cs7, 0x3D0A);
    // MOV ES,word ptr [0x55d4] (1000_3D06 / 0x13D06)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3D0F);
    // MOV AL,byte ptr ES:[SI + 0xc748] (1000_3D0A / 0x13D0A)
    AL = UInt8[ES, (ushort)(SI + 0xC748)];
    CheckExternalEvents(cs7, 0x3D11);
    // SUB AH,AH (1000_3D0F / 0x13D0F)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x3D14);
    // MOV word ptr [BP + -0x2],AX (1000_3D11 / 0x13D11)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x3D19);
    // MOV AL,byte ptr ES:[SI + 0xc749] (1000_3D14 / 0x13D14)
    AL = UInt8[ES, (ushort)(SI + 0xC749)];
    CheckExternalEvents(cs7, 0x3D1C);
    // MOV word ptr [BP + -0x4],AX (1000_3D19 / 0x13D19)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x3D20);
    // TEST byte ptr [BP + -0x2],0x8 (1000_3D1C / 0x13D1C)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0x8);
    CheckExternalEvents(cs7, 0x3D22);
    // JZ 0x1000:3d4a (1000_3D20 / 0x13D20)
    if(ZeroFlag) {
      goto label_1000_3D4A_13D4A;
    }
    CheckExternalEvents(cs7, 0x3D26);
    // TEST byte ptr [BP + -0x4],0x8 (1000_3D22 / 0x13D22)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x8);
    CheckExternalEvents(cs7, 0x3D28);
    // JZ 0x1000:3d4a (1000_3D26 / 0x13D26)
    if(ZeroFlag) {
      goto label_1000_3D4A_13D4A;
    }
    CheckExternalEvents(cs7, 0x3D2B);
    // MOV AX,0x3ce0 (1000_3D28 / 0x13D28)
    AX = 0x3CE0;
    CheckExternalEvents(cs7, 0x3D2C);
    // PUSH DS (1000_3D2B / 0x13D2B)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3D2D);
    // PUSH AX (1000_3D2C / 0x13D2C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3D32);
    // CALLF 0x1000:8055 (1000_3D2D / 0x13D2D)
    FarCall(cs7, 0x3D32, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3D35);
    // ADD SP,0x4 (1000_3D32 / 0x13D32)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3D38);
    // MOV AX,0xb (1000_3D35 / 0x13D35)
    AX = 0xB;
    CheckExternalEvents(cs7, 0x3D39);
    // PUSH AX (1000_3D38 / 0x13D38)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3D3C);
    // MOV AX,0x20 (1000_3D39 / 0x13D39)
    AX = 0x20;
    CheckExternalEvents(cs7, 0x3D3D);
    // PUSH AX (1000_3D3C / 0x13D3C)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3D40);
    // PUSH word ptr [BP + 0x6] (1000_3D3D / 0x13D3D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x3D45);
    // CALLF 0x0000:f2fb (1000_3D40 / 0x13D40)
    FarCall(cs7, 0x3D45, ghidra_guess_0000_F2FB_0F2FB);
    CheckExternalEvents(cs7, 0x3D48);
    // ADD SP,0x6 (1000_3D45 / 0x13D45)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs7, 0x3D4A);
    // JMP 0x1000:3d5c (1000_3D48 / 0x13D48)
    goto label_1000_3D5C_13D5C;
    label_1000_3D4A_13D4A:
    CheckExternalEvents(cs7, 0x3D4D);
    // MOV AX,0x3cfa (1000_3D4A / 0x13D4A)
    AX = 0x3CFA;
    CheckExternalEvents(cs7, 0x3D4E);
    // PUSH DS (1000_3D4D / 0x13D4D)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0x3D4F);
    // PUSH AX (1000_3D4E / 0x13D4E)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x3D54);
    // CALLF 0x1000:8055 (1000_3D4F / 0x13D4F)
    FarCall(cs7, 0x3D54, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x3D57);
    // ADD SP,0x4 (1000_3D54 / 0x13D54)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x3D5C);
    // CALLF 0x1000:8d29 (1000_3D57 / 0x13D57)
    FarCall(cs7, 0x3D5C, unknown_18AD_0259_18D29);
    label_1000_3D5C_13D5C:
    CheckExternalEvents(cs7, 0x3D60);
    // MOV ES,word ptr [0x560c] (1000_3D5C / 0x13D5C)
    ES = UInt16[DS, 0x560C];
    CheckExternalEvents(cs7, 0x3D67);
    // MOV word ptr ES:[0xc8],0x4 (1000_3D60 / 0x13D60)
    UInt16[ES, 0xC8] = 0x4;
    CheckExternalEvents(cs7, 0x3D68);
    // POP SI (1000_3D67 / 0x13D67)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3D6A);
    // MOV SP,BP (1000_3D68 / 0x13D68)
    SP = BP;
    CheckExternalEvents(cs7, 0x3D6B);
    // POP BP (1000_3D6A / 0x13D6A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3D6C);
    // RETF  (1000_3D6B / 0x13D6B)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_3D6C_13D6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_3D6C_13D6C:
    CheckExternalEvents(cs7, 0x3D6D);
    // PUSH BP (1000_3D6C / 0x13D6C)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x3D6F);
    // MOV BP,SP (1000_3D6D / 0x13D6D)
    BP = SP;
    CheckExternalEvents(cs7, 0x3D72);
    // MOV AX,0x6 (1000_3D6F / 0x13D6F)
    AX = 0x6;
    CheckExternalEvents(cs7, 0x3D77);
    // CALLF 0x1000:cecc (1000_3D72 / 0x13D72)
    FarCall(cs7, 0x3D77, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x3D78);
    // PUSH SI (1000_3D77 / 0x13D77)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x3D7C);
    // MOV ES,word ptr [0x5624] (1000_3D78 / 0x13D78)
    ES = UInt16[DS, 0x5624];
    CheckExternalEvents(cs7, 0x3D7E);
    // SUB AX,AX (1000_3D7C / 0x13D7C)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs7, 0x3D82);
    // MOV ES:[0x4592],AX (1000_3D7E / 0x13D7E)
    UInt16[ES, 0x4592] = AX;
    CheckExternalEvents(cs7, 0x3D86);
    // MOV ES,word ptr [0x5626] (1000_3D82 / 0x13D82)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3D8A);
    // MOV ES:[0x377c],AX (1000_3D86 / 0x13D86)
    UInt16[ES, 0x377C] = AX;
    CheckExternalEvents(cs7, 0x3D8D);
    // MOV AX,0x7d (1000_3D8A / 0x13D8A)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3D90);
    // IMUL word ptr [BP + 0x6] (1000_3D8D / 0x13D8D)
    int resImul1000_3D8D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3D8D);
    DX = (ushort)(resImul1000_3D8D >> 16);
    CheckExternalEvents(cs7, 0x3D92);
    // MOV SI,AX (1000_3D90 / 0x13D90)
    SI = AX;
    CheckExternalEvents(cs7, 0x3D96);
    // MOV ES,word ptr [0x55d4] (1000_3D92 / 0x13D92)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3D9B);
    // MOV AL,byte ptr ES:[SI + 0xc755] (1000_3D96 / 0x13D96)
    AL = UInt8[ES, (ushort)(SI + 0xC755)];
    CheckExternalEvents(cs7, 0x3D9D);
    // SUB AH,AH (1000_3D9B / 0x13D9B)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x3DA1);
    // MOV ES,word ptr [0x561a] (1000_3D9D / 0x13D9D)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3DA5);
    // MOV ES:[0x3770],AX (1000_3DA1 / 0x13DA1)
    UInt16[ES, 0x3770] = AX;
    CheckExternalEvents(cs7, 0x3DA9);
    // CMP word ptr [BP + 0x8],0x2 (1000_3DA5 / 0x13DA5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x2);
    CheckExternalEvents(cs7, 0x3DAB);
    // JNZ 0x1000:3dbf (1000_3DA9 / 0x13DA9)
    if(!ZeroFlag) {
      goto label_1000_3DBF_13DBF;
    }
    CheckExternalEvents(cs7, 0x3DAF);
    // MOV ES,word ptr [0x55d4] (1000_3DAB / 0x13DAB)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3DB4);
    // MOV AL,byte ptr ES:[SI + 0xc756] (1000_3DAF / 0x13DAF)
    AL = UInt8[ES, (ushort)(SI + 0xC756)];
    CheckExternalEvents(cs7, 0x3DB8);
    // MOV ES,word ptr [0x561a] (1000_3DB4 / 0x13DB4)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3DBC);
    // MOV ES:[0x3770],AX (1000_3DB8 / 0x13DB8)
    UInt16[ES, 0x3770] = AX;
    CheckExternalEvents(cs7, 0x3DBF);
    // JMP 0x1000:3ef2 (1000_3DBC / 0x13DBC)
    goto label_1000_3EF2_13EF2;
    label_1000_3DBF_13DBF:
    CheckExternalEvents(cs7, 0x3DC2);
    // MOV AX,0x7d (1000_3DBF / 0x13DBF)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3DC5);
    // IMUL word ptr [BP + 0x6] (1000_3DC2 / 0x13DC2)
    int resImul1000_3DC2 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3DC2);
    DX = (ushort)(resImul1000_3DC2 >> 16);
    CheckExternalEvents(cs7, 0x3DC7);
    // MOV SI,AX (1000_3DC5 / 0x13DC5)
    SI = AX;
    CheckExternalEvents(cs7, 0x3DCB);
    // MOV ES,word ptr [0x55d4] (1000_3DC7 / 0x13DC7)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3DD0);
    // MOV AL,byte ptr ES:[SI + 0xc748] (1000_3DCB / 0x13DCB)
    AL = UInt8[ES, (ushort)(SI + 0xC748)];
    CheckExternalEvents(cs7, 0x3DD2);
    // SUB AH,AH (1000_3DD0 / 0x13DD0)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x3DD5);
    // MOV word ptr [BP + -0x2],AX (1000_3DD2 / 0x13DD2)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x3DDA);
    // MOV AL,byte ptr ES:[SI + 0xc749] (1000_3DD5 / 0x13DD5)
    AL = UInt8[ES, (ushort)(SI + 0xC749)];
    CheckExternalEvents(cs7, 0x3DDD);
    // MOV word ptr [BP + -0x6],AX (1000_3DDA / 0x13DDA)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x3DE0);
    // MOV AL,byte ptr [BP + -0x2] (1000_3DDD / 0x13DDD)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x3DE3);
    // OR AL,byte ptr [BP + -0x6] (1000_3DE0 / 0x13DE0)
    AL |= UInt8[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0x3DE5);
    // TEST AL,0x8 (1000_3DE3 / 0x13DE3)
    Alu8.And(AL, 0x8);
    CheckExternalEvents(cs7, 0x3DE7);
    // JNZ 0x1000:3e00 (1000_3DE5 / 0x13DE5)
    if(!ZeroFlag) {
      goto label_1000_3E00_13E00;
    }
    CheckExternalEvents(cs7, 0x3DEB);
    // MOV ES,word ptr [0x561a] (1000_3DE7 / 0x13DE7)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3DF2);
    // MOV word ptr ES:[0x3770],0x1 (1000_3DEB / 0x13DEB)
    UInt16[ES, 0x3770] = 0x1;
    CheckExternalEvents(cs7, 0x3DF6);
    // MOV ES,word ptr [0x5626] (1000_3DF2 / 0x13DF2)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3DFD);
    // MOV word ptr ES:[0x377c],0x1 (1000_3DF6 / 0x13DF6)
    UInt16[ES, 0x377C] = 0x1;
    CheckExternalEvents(cs7, 0x3E00);
    // JMP 0x1000:3ea2 (1000_3DFD / 0x13DFD)
    goto label_1000_3EA2_13EA2;
    label_1000_3E00_13E00:
    CheckExternalEvents(cs7, 0x3E04);
    // TEST byte ptr [BP + -0x2],0x8 (1000_3E00 / 0x13E00)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0x8);
    CheckExternalEvents(cs7, 0x3E06);
    // JZ 0x1000:3e0c (1000_3E04 / 0x13E04)
    if(ZeroFlag) {
      goto label_1000_3E0C_13E0C;
    }
    CheckExternalEvents(cs7, 0x3E0A);
    // TEST byte ptr [BP + -0x6],0x8 (1000_3E06 / 0x13E06)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x6)], 0x8);
    CheckExternalEvents(cs7, 0x3E0C);
    // JNZ 0x1000:3e3d (1000_3E0A / 0x13E0A)
    if(!ZeroFlag) {
      goto label_1000_3E3D_13E3D;
    }
    label_1000_3E0C_13E0C:
    CheckExternalEvents(cs7, 0x3E10);
    // MOV ES,word ptr [0x561a] (1000_3E0C / 0x13E0C)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3E15);
    // SAR word ptr ES:[0x3770],0x1 (1000_3E10 / 0x13E10)
    UInt16[ES, 0x3770] = Alu16.Sar(UInt16[ES, 0x3770], 0x1);
    CheckExternalEvents(cs7, 0x3E18);
    // MOV AX,0x7d (1000_3E15 / 0x13E15)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3E1B);
    // IMUL word ptr [BP + 0x6] (1000_3E18 / 0x13E18)
    int resImul1000_3E18 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_3E18);
    DX = (ushort)(resImul1000_3E18 >> 16);
    CheckExternalEvents(cs7, 0x3E1D);
    // MOV BX,AX (1000_3E1B / 0x13E1B)
    BX = AX;
    CheckExternalEvents(cs7, 0x3E21);
    // MOV ES,word ptr [0x55d4] (1000_3E1D / 0x13E1D)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3E27);
    // TEST byte ptr ES:[BX + 0xc755],0x1 (1000_3E21 / 0x13E21)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC755)], 0x1);
    CheckExternalEvents(cs7, 0x3E29);
    // JZ 0x1000:3e32 (1000_3E27 / 0x13E27)
    if(ZeroFlag) {
      goto label_1000_3E32_13E32;
    }
    CheckExternalEvents(cs7, 0x3E2D);
    // MOV ES,word ptr [0x561a] (1000_3E29 / 0x13E29)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3E32);
    // INC word ptr ES:[0x3770] (1000_3E2D / 0x13E2D)
    UInt16[ES, 0x3770] = Alu16.Inc(UInt16[ES, 0x3770]);
    label_1000_3E32_13E32:
    CheckExternalEvents(cs7, 0x3E36);
    // MOV ES,word ptr [0x5626] (1000_3E32 / 0x13E32)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3E3D);
    // MOV word ptr ES:[0x377c],0x1 (1000_3E36 / 0x13E36)
    UInt16[ES, 0x377C] = 0x1;
    label_1000_3E3D_13E3D:
    CheckExternalEvents(cs7, 0x3E42);
    // MOV word ptr [BP + -0x4],0x4 (1000_3E3D / 0x13E3D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x4;
    label_1000_3E42_13E42:
    CheckExternalEvents(cs7, 0x3E45);
    // MOV AX,word ptr [BP + -0x4] (1000_3E42 / 0x13E42)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3E48);
    // TEST word ptr [BP + -0x2],AX (1000_3E45 / 0x13E45)
    Alu16.And(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs7, 0x3E4A);
    // JNZ 0x1000:3e5e (1000_3E48 / 0x13E48)
    if(!ZeroFlag) {
      goto label_1000_3E5E_13E5E;
    }
    CheckExternalEvents(cs7, 0x3E4E);
    // MOV ES,word ptr [0x561a] (1000_3E4A / 0x13E4A)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3E53);
    // DEC word ptr ES:[0x3770] (1000_3E4E / 0x13E4E)
    UInt16[ES, 0x3770] = Alu16.Dec(UInt16[ES, 0x3770]);
    CheckExternalEvents(cs7, 0x3E57);
    // MOV ES,word ptr [0x5626] (1000_3E53 / 0x13E53)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3E5E);
    // MOV word ptr ES:[0x377c],0x1 (1000_3E57 / 0x13E57)
    UInt16[ES, 0x377C] = 0x1;
    label_1000_3E5E_13E5E:
    CheckExternalEvents(cs7, 0x3E61);
    // MOV AX,word ptr [BP + -0x4] (1000_3E5E / 0x13E5E)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x3E64);
    // TEST word ptr [BP + -0x6],AX (1000_3E61 / 0x13E61)
    Alu16.And(UInt16[SS, (ushort)(BP - 0x6)], AX);
    CheckExternalEvents(cs7, 0x3E66);
    // JNZ 0x1000:3e7a (1000_3E64 / 0x13E64)
    if(!ZeroFlag) {
      goto label_1000_3E7A_13E7A;
    }
    CheckExternalEvents(cs7, 0x3E6A);
    // MOV ES,word ptr [0x561a] (1000_3E66 / 0x13E66)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3E6F);
    // DEC word ptr ES:[0x3770] (1000_3E6A / 0x13E6A)
    UInt16[ES, 0x3770] = Alu16.Dec(UInt16[ES, 0x3770]);
    CheckExternalEvents(cs7, 0x3E73);
    // MOV ES,word ptr [0x5626] (1000_3E6F / 0x13E6F)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3E7A);
    // MOV word ptr ES:[0x377c],0x1 (1000_3E73 / 0x13E73)
    UInt16[ES, 0x377C] = 0x1;
    label_1000_3E7A_13E7A:
    CheckExternalEvents(cs7, 0x3E7E);
    // MOV ES,word ptr [0x5626] (1000_3E7A / 0x13E7A)
    ES = UInt16[DS, 0x5626];
    CheckExternalEvents(cs7, 0x3E84);
    // CMP word ptr ES:[0x377c],0x0 (1000_3E7E / 0x13E7E)
    Alu16.Sub(UInt16[ES, 0x377C], 0x0);
    CheckExternalEvents(cs7, 0x3E86);
    // JZ 0x1000:3e99 (1000_3E84 / 0x13E84)
    if(ZeroFlag) {
      goto label_1000_3E99_13E99;
    }
    CheckExternalEvents(cs7, 0x3E8A);
    // MOV ES,word ptr [0x561a] (1000_3E86 / 0x13E86)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3E90);
    // CMP word ptr ES:[0x3770],0x0 (1000_3E8A / 0x13E8A)
    Alu16.Sub(UInt16[ES, 0x3770], 0x0);
    CheckExternalEvents(cs7, 0x3E92);
    // JNZ 0x1000:3e99 (1000_3E90 / 0x13E90)
    if(!ZeroFlag) {
      goto label_1000_3E99_13E99;
    }
    CheckExternalEvents(cs7, 0x3E99);
    // MOV word ptr ES:[0x3770],0x1 (1000_3E92 / 0x13E92)
    UInt16[ES, 0x3770] = 0x1;
    label_1000_3E99_13E99:
    CheckExternalEvents(cs7, 0x3E9C);
    // SAR word ptr [BP + -0x4],0x1 (1000_3E99 / 0x13E99)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Sar(UInt16[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs7, 0x3EA0);
    // CMP word ptr [BP + -0x4],0x0 (1000_3E9C / 0x13E9C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs7, 0x3EA2);
    // JG 0x1000:3e42 (1000_3EA0 / 0x13EA0)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_3E42_13E42;
    }
    label_1000_3EA2_13EA2:
    CheckExternalEvents(cs7, 0x3EA5);
    // MOV BX,word ptr [BP + 0x6] (1000_3EA2 / 0x13EA2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x3EA9);
    // MOV ES,word ptr [0x55ea] (1000_3EA5 / 0x13EA5)
    ES = UInt16[DS, 0x55EA];
    CheckExternalEvents(cs7, 0x3EAE);
    // MOV AL,byte ptr ES:[BX + 0x6e] (1000_3EA9 / 0x13EA9)
    AL = UInt8[ES, (ushort)(BX + 0x6E)];
    CheckExternalEvents(cs7, 0x3EAF);
    // CBW  (1000_3EAE / 0x13EAE)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3EB1);
    // MOV CL,0x5 (1000_3EAF / 0x13EAF)
    CL = 0x5;
    CheckExternalEvents(cs7, 0x3EB3);
    // IDIV CL (1000_3EB1 / 0x13EB1)
    short op1IDiv1000_3EB1 = (short)AX;
    sbyte op2IDiv1000_3EB1 = (sbyte)CL;
    sbyte? resIDiv1000_3EB1 = Alu8.Idiv(op1IDiv1000_3EB1, op2IDiv1000_3EB1);
    if(resIDiv1000_3EB1 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AL = (byte)resIDiv1000_3EB1.Value;
    AH = (byte)(op1IDiv1000_3EB1 % op2IDiv1000_3EB1);
    CheckExternalEvents(cs7, 0x3EB4);
    // CBW  (1000_3EB3 / 0x13EB3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x3EB8);
    // MOV ES,word ptr [0x5624] (1000_3EB4 / 0x13EB4)
    ES = UInt16[DS, 0x5624];
    CheckExternalEvents(cs7, 0x3EBC);
    // MOV ES:[0x4592],AX (1000_3EB8 / 0x13EB8)
    UInt16[ES, 0x4592] = AX;
    CheckExternalEvents(cs7, 0x3EC0);
    // MOV ES,word ptr [0x561a] (1000_3EBC / 0x13EBC)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3EC5);
    // SUB word ptr ES:[0x3770],AX (1000_3EC0 / 0x13EC0)
    UInt16[ES, 0x3770] -= AX;
    CheckExternalEvents(cs7, 0x3EC9);
    // CMP word ptr [BP + 0x8],0x1 (1000_3EC5 / 0x13EC5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x1);
    CheckExternalEvents(cs7, 0x3ECB);
    // JNZ 0x1000:3ef2 (1000_3EC9 / 0x13EC9)
    if(!ZeroFlag) {
      goto label_1000_3EF2_13EF2;
    }
    CheckExternalEvents(cs7, 0x3ECF);
    // MOV AX,ES:[0x3770] (1000_3ECB / 0x13ECB)
    AX = UInt16[ES, 0x3770];
    CheckExternalEvents(cs7, 0x3ED1);
    // SAR AX,0x1 (1000_3ECF / 0x13ECF)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x3ED6);
    // ADD word ptr ES:[0x3770],AX (1000_3ED1 / 0x13ED1)
    // UInt16[ES, 0x3770] += AX;
    UInt16[ES, 0x3770] = Alu16.Add(UInt16[ES, 0x3770], AX);
    CheckExternalEvents(cs7, 0x3ED9);
    // MOV AX,0x7d (1000_3ED6 / 0x13ED6)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0x3EDB);
    // IMUL BX (1000_3ED9 / 0x13ED9)
    int resImul1000_3ED9 = Alu16.Imul((short)AX, (short)BX);
    AX = (ushort)(resImul1000_3ED9);
    DX = (ushort)(resImul1000_3ED9 >> 16);
    CheckExternalEvents(cs7, 0x3EDD);
    // MOV BX,AX (1000_3EDB / 0x13EDB)
    BX = AX;
    CheckExternalEvents(cs7, 0x3EE1);
    // MOV ES,word ptr [0x55d4] (1000_3EDD / 0x13EDD)
    ES = UInt16[DS, 0x55D4];
    CheckExternalEvents(cs7, 0x3EE7);
    // TEST byte ptr ES:[BX + 0xc755],0x1 (1000_3EE1 / 0x13EE1)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC755)], 0x1);
    CheckExternalEvents(cs7, 0x3EE9);
    // JZ 0x1000:3ef2 (1000_3EE7 / 0x13EE7)
    if(ZeroFlag) {
      goto label_1000_3EF2_13EF2;
    }
    CheckExternalEvents(cs7, 0x3EED);
    // MOV ES,word ptr [0x561a] (1000_3EE9 / 0x13EE9)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3EF2);
    // INC word ptr ES:[0x3770] (1000_3EED / 0x13EED)
    UInt16[ES, 0x3770] = Alu16.Inc(UInt16[ES, 0x3770]);
    label_1000_3EF2_13EF2:
    CheckExternalEvents(cs7, 0x3EF5);
    // MOV BX,word ptr [BP + 0x6] (1000_3EF2 / 0x13EF2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x3EF9);
    // MOV ES,word ptr [0x55ea] (1000_3EF5 / 0x13EF5)
    ES = UInt16[DS, 0x55EA];
    CheckExternalEvents(cs7, 0x3EFF);
    // CMP byte ptr ES:[BX + 0x6e],0x1e (1000_3EF9 / 0x13EF9)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x1E);
    CheckExternalEvents(cs7, 0x3F01);
    // JNZ 0x1000:3f0c (1000_3EFF / 0x13EFF)
    if(!ZeroFlag) {
      goto label_1000_3F0C_13F0C;
    }
    CheckExternalEvents(cs7, 0x3F05);
    // MOV ES,word ptr [0x561a] (1000_3F01 / 0x13F01)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3F0C);
    // MOV word ptr ES:[0x3770],0x0 (1000_3F05 / 0x13F05)
    UInt16[ES, 0x3770] = 0x0;
    label_1000_3F0C_13F0C:
    CheckExternalEvents(cs7, 0x3F10);
    // MOV ES,word ptr [0x561a] (1000_3F0C / 0x13F0C)
    ES = UInt16[DS, 0x561A];
    CheckExternalEvents(cs7, 0x3F16);
    // CMP word ptr ES:[0x3770],0x0 (1000_3F10 / 0x13F10)
    Alu16.Sub(UInt16[ES, 0x3770], 0x0);
    CheckExternalEvents(cs7, 0x3F18);
    // JGE 0x1000:3f1f (1000_3F16 / 0x13F16)
    if(SignFlag == OverflowFlag) {
      goto label_1000_3F1F_13F1F;
    }
    CheckExternalEvents(cs7, 0x3F1F);
    // MOV word ptr ES:[0x3770],0x0 (1000_3F18 / 0x13F18)
    UInt16[ES, 0x3770] = 0x0;
    label_1000_3F1F_13F1F:
    CheckExternalEvents(cs7, 0x3F20);
    // POP SI (1000_3F1F / 0x13F1F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3F22);
    // MOV SP,BP (1000_3F20 / 0x13F20)
    SP = BP;
    CheckExternalEvents(cs7, 0x3F23);
    // POP BP (1000_3F22 / 0x13F22)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x3F24);
    // RETF  (1000_3F23 / 0x13F23)
    return FarRet();
  }
  
}
