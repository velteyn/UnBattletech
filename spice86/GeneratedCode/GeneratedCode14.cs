namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action unknown_17C6_01E7_17E47(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_01E7_17E47:
    CheckExternalEvents(cs9, 0x1E8);
    // PUSH BP (17C6_01E7 / 0x17E47)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0x1EA);
    // MOV BP,SP (17C6_01E8 / 0x17E48)
    BP = SP;
    CheckExternalEvents(cs9, 0x1ED);
    // MOV AX,0x8 (17C6_01EA / 0x17E4A)
    AX = 0x8;
    CheckExternalEvents(cs9, 0x1F2);
    // CALLF 0x1000:cecc (17C6_01ED / 0x17E4D)
    FarCall(cs9, 0x1F2, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x1F3);
    // PUSH SI (17C6_01F2 / 0x17E52)
    Stack.Push16(SI);
    CheckExternalEvents(cs9, 0x1F6);
    // MOV AX,word ptr [BP + 0xa] (17C6_01F3 / 0x17E53)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs9, 0x1F9);
    // MOV word ptr [BP + -0x8],AX (17C6_01F6 / 0x17E56)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs9, 0x1FE);
    // MOV word ptr [BP + -0x2],0x0 (17C6_01F9 / 0x17E59)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs9, 0x200);
    // JMP 0x1000:7e7e (17C6_01FE / 0x17E5E)
    goto label_17C6_021E_17E7E;
    label_17C6_0200_17E60:
    CheckExternalEvents(cs9, 0x203);
    // INC word ptr [BP + 0xe] (17C6_0200 / 0x17E60)
    UInt16[SS, (ushort)(BP + 0xE)]++;
    label_17C6_0203_17E63:
    CheckExternalEvents(cs9, 0x206);
    // INC word ptr [BP + -0x8] (17C6_0203 / 0x17E63)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x209);
    // MOV BX,word ptr [BP + -0x8] (17C6_0206 / 0x17E66)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x20B);
    // SHL BX,0x1 (17C6_0209 / 0x17E69)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs9, 0x20E);
    // LES SI,[BP + 0x6] (17C6_020B / 0x17E6B)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x213);
    // CMP word ptr ES:[BX + SI],0xff (17C6_020E / 0x17E6E)
    Alu16.Sub(UInt16[ES, (ushort)(BX + SI)], 0xFF);
    CheckExternalEvents(cs9, 0x215);
    // JNZ 0x1000:7e7b (17C6_0213 / 0x17E73)
    if(!ZeroFlag) {
      goto label_17C6_021B_17E7B;
    }
    CheckExternalEvents(cs9, 0x218);
    // MOV AX,word ptr [BP + 0xa] (17C6_0215 / 0x17E75)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs9, 0x21B);
    // MOV word ptr [BP + -0x8],AX (17C6_0218 / 0x17E78)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    label_17C6_021B_17E7B:
    CheckExternalEvents(cs9, 0x21E);
    // INC word ptr [BP + -0x2] (17C6_021B / 0x17E7B)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_17C6_021E_17E7E:
    CheckExternalEvents(cs9, 0x221);
    // MOV AX,word ptr [BP + 0x10] (17C6_021E / 0x17E7E)
    AX = UInt16[SS, (ushort)(BP + 0x10)];
    CheckExternalEvents(cs9, 0x224);
    // CMP word ptr [BP + -0x2],AX (17C6_0221 / 0x17E81)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs9, 0x226);
    // JGE 0x1000:7ec7 (17C6_0224 / 0x17E84)
    if(SignFlag == OverflowFlag) {
      goto label_17C6_0267_17EC7;
    }
    CheckExternalEvents(cs9, 0x229);
    // MOV BX,word ptr [BP + -0x8] (17C6_0226 / 0x17E86)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x22B);
    // SHL BX,0x1 (17C6_0229 / 0x17E89)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs9, 0x22E);
    // LES SI,[BP + 0x6] (17C6_022B / 0x17E8B)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x231);
    // MOV AX,word ptr ES:[BX + SI] (17C6_022E / 0x17E8E)
    AX = UInt16[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x233);
    // MOV CL,0x5 (17C6_0231 / 0x17E91)
    CL = 0x5;
    CheckExternalEvents(cs9, 0x235);
    // SHL AX,CL (17C6_0233 / 0x17E93)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x239);
    // MOV ES,word ptr [0x56d4] (17C6_0235 / 0x17E95)
    ES = UInt16[DS, 0x56D4];
    CheckExternalEvents(cs9, 0x23E);
    // ADD AX,word ptr ES:[0x4066] (17C6_0239 / 0x17E99)
    // AX += UInt16[ES, 0x4066];
    AX = Alu16.Add(AX, UInt16[ES, 0x4066]);
    CheckExternalEvents(cs9, 0x243);
    // MOV DX,word ptr ES:[0x4068] (17C6_023E / 0x17E9E)
    DX = UInt16[ES, 0x4068];
    CheckExternalEvents(cs9, 0x246);
    // MOV word ptr [BP + -0x6],AX (17C6_0243 / 0x17EA3)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs9, 0x249);
    // MOV word ptr [BP + -0x4],DX (17C6_0246 / 0x17EA6)
    UInt16[SS, (ushort)(BP - 0x4)] = DX;
    CheckExternalEvents(cs9, 0x24C);
    // PUSH word ptr [BP + 0xe] (17C6_0249 / 0x17EA9)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs9, 0x24F);
    // PUSH word ptr [BP + 0xc] (17C6_024C / 0x17EAC)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs9, 0x250);
    // PUSH DX (17C6_024F / 0x17EAF)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0x251);
    // PUSH AX (17C6_0250 / 0x17EB0)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x256);
    // CALLF 0x1000:c64c (17C6_0251 / 0x17EB1)
    FarCall(cs9, 0x256, unknown_19EF_275C_1C64C);
    CheckExternalEvents(cs9, 0x259);
    // ADD SP,0x8 (17C6_0256 / 0x17EB6)
    SP += 0x8;
    CheckExternalEvents(cs9, 0x25D);
    // CMP word ptr [BP + 0x12],0x0 (17C6_0259 / 0x17EB9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x12)], 0x0);
    CheckExternalEvents(cs9, 0x25F);
    // JZ 0x1000:7e60 (17C6_025D / 0x17EBD)
    if(ZeroFlag) {
      goto label_17C6_0200_17E60;
    }
    CheckExternalEvents(cs9, 0x262);
    // INC word ptr [BP + 0xc] (17C6_025F / 0x17EBF)
    UInt16[SS, (ushort)(BP + 0xC)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs9, 0x264);
    // JMP 0x1000:7e63 (17C6_0262 / 0x17EC2)
    goto label_17C6_0203_17E63;
    label_17C6_0264_17EC4:
    CheckExternalEvents(cs9, 0x267);
    // INC word ptr [BP + -0x8] (17C6_0264 / 0x17EC4)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    label_17C6_0267_17EC7:
    CheckExternalEvents(cs9, 0x26A);
    // MOV BX,word ptr [BP + -0x8] (17C6_0267 / 0x17EC7)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x26C);
    // SHL BX,0x1 (17C6_026A / 0x17ECA)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs9, 0x26F);
    // LES SI,[BP + 0x6] (17C6_026C / 0x17ECC)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x274);
    // CMP word ptr ES:[BX + SI],0xff (17C6_026F / 0x17ECF)
    Alu16.Sub(UInt16[ES, (ushort)(BX + SI)], 0xFF);
    CheckExternalEvents(cs9, 0x276);
    // JNZ 0x1000:7ec4 (17C6_0274 / 0x17ED4)
    if(!ZeroFlag) {
      goto label_17C6_0264_17EC4;
    }
    CheckExternalEvents(cs9, 0x279);
    // INC word ptr [BP + -0x8] (17C6_0276 / 0x17ED6)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x27C);
    // MOV AX,word ptr [BP + -0x8] (17C6_0279 / 0x17ED9)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x27D);
    // POP SI (17C6_027C / 0x17EDC)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x27F);
    // MOV SP,BP (17C6_027D / 0x17EDD)
    SP = BP;
    CheckExternalEvents(cs9, 0x280);
    // POP BP (17C6_027F / 0x17EDF)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x281);
    // RETF  (17C6_0280 / 0x17EE0)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_0281_17EE1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_0281_17EE1:
    CheckExternalEvents(cs9, 0x282);
    // PUSH BP (17C6_0281 / 0x17EE1)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0x284);
    // MOV BP,SP (17C6_0282 / 0x17EE2)
    BP = SP;
    CheckExternalEvents(cs9, 0x286);
    // XOR AX,AX (17C6_0284 / 0x17EE4)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs9, 0x28B);
    // CALLF 0x1000:cecc (17C6_0286 / 0x17EE6)
    FarCall(cs9, 0x28B, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x28C);
    // PUSH SI (17C6_028B / 0x17EEB)
    Stack.Push16(SI);
    CheckExternalEvents(cs9, 0x291);
    // CMP word ptr [0x4fa2],0x0 (17C6_028C / 0x17EEC)
    Alu16.Sub(UInt16[DS, 0x4FA2], 0x0);
    CheckExternalEvents(cs9, 0x293);
    // JZ 0x1000:7f46 (17C6_0291 / 0x17EF1)
    if(ZeroFlag) {
      goto label_17C6_02E6_17F46;
    }
    CheckExternalEvents(cs9, 0x297);
    // MOV ES,word ptr [0x56da] (17C6_0293 / 0x17EF3)
    ES = UInt16[DS, 0x56DA];
    CheckExternalEvents(cs9, 0x29C);
    // MOV SI,word ptr ES:[0x4600] (17C6_0297 / 0x17EF7)
    SI = UInt16[ES, 0x4600];
    CheckExternalEvents(cs9, 0x29E);
    // MOV CL,0x4 (17C6_029C / 0x17EFC)
    CL = 0x4;
    CheckExternalEvents(cs9, 0x2A0);
    // SHL SI,CL (17C6_029E / 0x17EFE)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs9, 0x2A4);
    // MOV ES,word ptr [0x56dc] (17C6_02A0 / 0x17F00)
    ES = UInt16[DS, 0x56DC];
    CheckExternalEvents(cs9, 0x2A8);
    // MOV AX,ES:[0x37fe] (17C6_02A4 / 0x17F04)
    AX = UInt16[ES, 0x37FE];
    CheckExternalEvents(cs9, 0x2AC);
    // MOV ES,word ptr [0x56de] (17C6_02A8 / 0x17F08)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x2B1);
    // MOV word ptr ES:[SI + 0x8],AX (17C6_02AC / 0x17F0C)
    UInt16[ES, (ushort)(SI + 0x8)] = AX;
    CheckExternalEvents(cs9, 0x2B5);
    // MOV ES,word ptr [0x56e0] (17C6_02B1 / 0x17F11)
    ES = UInt16[DS, 0x56E0];
    CheckExternalEvents(cs9, 0x2B9);
    // MOV AX,ES:[0x377e] (17C6_02B5 / 0x17F15)
    AX = UInt16[ES, 0x377E];
    CheckExternalEvents(cs9, 0x2BD);
    // MOV ES,word ptr [0x56de] (17C6_02B9 / 0x17F19)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x2C2);
    // MOV word ptr ES:[SI + 0xa],AX (17C6_02BD / 0x17F1D)
    UInt16[ES, (ushort)(SI + 0xA)] = AX;
    CheckExternalEvents(cs9, 0x2C6);
    // MOV ES,word ptr [0x56e2] (17C6_02C2 / 0x17F22)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x2CA);
    // MOV AX,ES:[0x3748] (17C6_02C6 / 0x17F26)
    AX = UInt16[ES, 0x3748];
    CheckExternalEvents(cs9, 0x2CE);
    // MOV ES,word ptr [0x56de] (17C6_02CA / 0x17F2A)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x2D3);
    // MOV word ptr ES:[SI + 0xc],AX (17C6_02CE / 0x17F2E)
    UInt16[ES, (ushort)(SI + 0xC)] = AX;
    CheckExternalEvents(cs9, 0x2D7);
    // MOV ES,word ptr [0x56e4] (17C6_02D3 / 0x17F33)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0x2DB);
    // MOV AX,ES:[0x374e] (17C6_02D7 / 0x17F37)
    AX = UInt16[ES, 0x374E];
    CheckExternalEvents(cs9, 0x2DF);
    // MOV ES,word ptr [0x56de] (17C6_02DB / 0x17F3B)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x2E4);
    // MOV word ptr ES:[SI + 0xe],AX (17C6_02DF / 0x17F3F)
    UInt16[ES, (ushort)(SI + 0xE)] = AX;
    CheckExternalEvents(cs9, 0x2E6);
    // JMP 0x1000:7f4c (17C6_02E4 / 0x17F44)
    goto label_17C6_02EC_17F4C;
    label_17C6_02E6_17F46:
    CheckExternalEvents(cs9, 0x2EC);
    // MOV word ptr [0x4fa2],0x1 (17C6_02E6 / 0x17F46)
    UInt16[DS, 0x4FA2] = 0x1;
    label_17C6_02EC_17F4C:
    CheckExternalEvents(cs9, 0x2F0);
    // MOV ES,word ptr [0x56da] (17C6_02EC / 0x17F4C)
    ES = UInt16[DS, 0x56DA];
    CheckExternalEvents(cs9, 0x2F3);
    // MOV AX,word ptr [BP + 0x6] (17C6_02F0 / 0x17F50)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0x2F7);
    // MOV ES:[0x4600],AX (17C6_02F3 / 0x17F53)
    UInt16[ES, 0x4600] = AX;
    CheckExternalEvents(cs9, 0x2F9);
    // MOV SI,AX (17C6_02F7 / 0x17F57)
    SI = AX;
    CheckExternalEvents(cs9, 0x2FB);
    // MOV CL,0x4 (17C6_02F9 / 0x17F59)
    CL = 0x4;
    CheckExternalEvents(cs9, 0x2FD);
    // SHL SI,CL (17C6_02FB / 0x17F5B)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs9, 0x301);
    // MOV ES,word ptr [0x56de] (17C6_02FD / 0x17F5D)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x306);
    // MOV AX,word ptr ES:[SI + 0x0] (17C6_0301 / 0x17F61)
    AX = UInt16[ES, (ushort)(SI)];
    CheckExternalEvents(cs9, 0x30A);
    // MOV ES,word ptr [0x56d0] (17C6_0306 / 0x17F66)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x30E);
    // MOV ES:[0x39a0],AX (17C6_030A / 0x17F6A)
    UInt16[ES, 0x39A0] = AX;
    CheckExternalEvents(cs9, 0x312);
    // MOV ES,word ptr [0x56de] (17C6_030E / 0x17F6E)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x317);
    // MOV AX,word ptr ES:[SI + 0x2] (17C6_0312 / 0x17F72)
    AX = UInt16[ES, (ushort)(SI + 0x2)];
    CheckExternalEvents(cs9, 0x31B);
    // MOV ES,word ptr [0x56d2] (17C6_0317 / 0x17F77)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x31F);
    // MOV ES:[0x39a4],AX (17C6_031B / 0x17F7B)
    UInt16[ES, 0x39A4] = AX;
    CheckExternalEvents(cs9, 0x323);
    // MOV ES,word ptr [0x56de] (17C6_031F / 0x17F7F)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x328);
    // MOV AX,word ptr ES:[SI + 0x4] (17C6_0323 / 0x17F83)
    AX = UInt16[ES, (ushort)(SI + 0x4)];
    CheckExternalEvents(cs9, 0x32C);
    // MOV ES,word ptr [0x56d6] (17C6_0328 / 0x17F88)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x330);
    // MOV ES:[0x3990],AX (17C6_032C / 0x17F8C)
    UInt16[ES, 0x3990] = AX;
    CheckExternalEvents(cs9, 0x334);
    // MOV ES,word ptr [0x56de] (17C6_0330 / 0x17F90)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x339);
    // MOV AX,word ptr ES:[SI + 0x6] (17C6_0334 / 0x17F94)
    AX = UInt16[ES, (ushort)(SI + 0x6)];
    CheckExternalEvents(cs9, 0x33D);
    // MOV ES,word ptr [0x56d8] (17C6_0339 / 0x17F99)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x341);
    // MOV ES:[0x393a],AX (17C6_033D / 0x17F9D)
    UInt16[ES, 0x393A] = AX;
    CheckExternalEvents(cs9, 0x345);
    // MOV ES,word ptr [0x56de] (17C6_0341 / 0x17FA1)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x34A);
    // MOV AX,word ptr ES:[SI + 0x8] (17C6_0345 / 0x17FA5)
    AX = UInt16[ES, (ushort)(SI + 0x8)];
    CheckExternalEvents(cs9, 0x34E);
    // MOV ES,word ptr [0x56dc] (17C6_034A / 0x17FAA)
    ES = UInt16[DS, 0x56DC];
    CheckExternalEvents(cs9, 0x352);
    // MOV ES:[0x37fe],AX (17C6_034E / 0x17FAE)
    UInt16[ES, 0x37FE] = AX;
    CheckExternalEvents(cs9, 0x356);
    // MOV ES,word ptr [0x56de] (17C6_0352 / 0x17FB2)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x35B);
    // MOV AX,word ptr ES:[SI + 0xa] (17C6_0356 / 0x17FB6)
    AX = UInt16[ES, (ushort)(SI + 0xA)];
    CheckExternalEvents(cs9, 0x35F);
    // MOV ES,word ptr [0x56e0] (17C6_035B / 0x17FBB)
    ES = UInt16[DS, 0x56E0];
    CheckExternalEvents(cs9, 0x363);
    // MOV ES:[0x377e],AX (17C6_035F / 0x17FBF)
    UInt16[ES, 0x377E] = AX;
    CheckExternalEvents(cs9, 0x367);
    // MOV ES,word ptr [0x56de] (17C6_0363 / 0x17FC3)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x36C);
    // MOV AX,word ptr ES:[SI + 0xc] (17C6_0367 / 0x17FC7)
    AX = UInt16[ES, (ushort)(SI + 0xC)];
    CheckExternalEvents(cs9, 0x370);
    // MOV ES,word ptr [0x56e2] (17C6_036C / 0x17FCC)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x374);
    // MOV ES:[0x3748],AX (17C6_0370 / 0x17FD0)
    UInt16[ES, 0x3748] = AX;
    CheckExternalEvents(cs9, 0x378);
    // MOV ES,word ptr [0x56de] (17C6_0374 / 0x17FD4)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0x37D);
    // MOV AX,word ptr ES:[SI + 0xe] (17C6_0378 / 0x17FD8)
    AX = UInt16[ES, (ushort)(SI + 0xE)];
    CheckExternalEvents(cs9, 0x381);
    // MOV ES,word ptr [0x56e4] (17C6_037D / 0x17FDD)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0x385);
    // MOV ES:[0x374e],AX (17C6_0381 / 0x17FE1)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs9, 0x386);
    // POP SI (17C6_0385 / 0x17FE5)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x387);
    // POP BP (17C6_0386 / 0x17FE6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x388);
    // RETF  (17C6_0387 / 0x17FE7)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_0388_17FE8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_0388_17FE8:
    CheckExternalEvents(cs9, 0x38A);
    // XOR AX,AX (17C6_0388 / 0x17FE8)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs9, 0x38F);
    // CALLF 0x1000:cecc (17C6_038A / 0x17FEA)
    FarCall(cs9, 0x38F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x393);
    // MOV ES,word ptr [0x56e0] (17C6_038F / 0x17FEF)
    ES = UInt16[DS, 0x56E0];
    CheckExternalEvents(cs9, 0x398);
    // PUSH word ptr ES:[0x377e] (17C6_0393 / 0x17FF3)
    Stack.Push16(UInt16[ES, 0x377E]);
    CheckExternalEvents(cs9, 0x39C);
    // MOV ES,word ptr [0x56d2] (17C6_0398 / 0x17FF8)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x3A0);
    // MOV AX,ES:[0x39a4] (17C6_039C / 0x17FFC)
    AX = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x3A4);
    // MOV ES,word ptr [0x56d8] (17C6_03A0 / 0x18000)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x3A9);
    // ADD AX,word ptr ES:[0x393a] (17C6_03A4 / 0x18004)
    // AX += UInt16[ES, 0x393A];
    AX = Alu16.Add(AX, UInt16[ES, 0x393A]);
    CheckExternalEvents(cs9, 0x3AB);
    // MOV CL,0x3 (17C6_03A9 / 0x18009)
    CL = 0x3;
    CheckExternalEvents(cs9, 0x3AD);
    // SHL AX,CL (17C6_03AB / 0x1800B)
    AX <<= CL;
    CheckExternalEvents(cs9, 0x3AE);
    // DEC AX (17C6_03AD / 0x1800D)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs9, 0x3AF);
    // PUSH AX (17C6_03AE / 0x1800E)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x3B3);
    // MOV ES,word ptr [0x56d0] (17C6_03AF / 0x1800F)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x3B7);
    // MOV AX,ES:[0x39a0] (17C6_03B3 / 0x18013)
    AX = UInt16[ES, 0x39A0];
    CheckExternalEvents(cs9, 0x3BB);
    // MOV ES,word ptr [0x56d6] (17C6_03B7 / 0x18017)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x3C0);
    // ADD AX,word ptr ES:[0x3990] (17C6_03BB / 0x1801B)
    AX += UInt16[ES, 0x3990];
    CheckExternalEvents(cs9, 0x3C2);
    // SHL AX,CL (17C6_03C0 / 0x18020)
    AX <<= CL;
    CheckExternalEvents(cs9, 0x3C3);
    // DEC AX (17C6_03C2 / 0x18022)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs9, 0x3C4);
    // PUSH AX (17C6_03C3 / 0x18023)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x3C8);
    // MOV ES,word ptr [0x56d2] (17C6_03C4 / 0x18024)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x3CC);
    // MOV AX,ES:[0x39a4] (17C6_03C8 / 0x18028)
    AX = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x3CE);
    // SHL AX,CL (17C6_03CC / 0x1802C)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x3CF);
    // PUSH AX (17C6_03CE / 0x1802E)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x3D3);
    // MOV ES,word ptr [0x56d0] (17C6_03CF / 0x1802F)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x3D7);
    // MOV AX,ES:[0x39a0] (17C6_03D3 / 0x18033)
    AX = UInt16[ES, 0x39A0];
    CheckExternalEvents(cs9, 0x3D9);
    // SHL AX,CL (17C6_03D7 / 0x18037)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x3DA);
    // PUSH AX (17C6_03D9 / 0x18039)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x3DF);
    // CALLF 0x1000:8ccb (17C6_03DA / 0x1803A)
    FarCall(cs9, 0x3DF, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs9, 0x3E2);
    // ADD SP,0xa (17C6_03DF / 0x1803F)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs9, 0x3E6);
    // MOV ES,word ptr [0x56e4] (17C6_03E2 / 0x18042)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0x3E8);
    // SUB AX,AX (17C6_03E6 / 0x18046)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x3EC);
    // MOV ES:[0x374e],AX (17C6_03E8 / 0x18048)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs9, 0x3F0);
    // MOV ES,word ptr [0x56e2] (17C6_03EC / 0x1804C)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x3F4);
    // MOV ES:[0x3748],AX (17C6_03F0 / 0x18050)
    UInt16[ES, 0x3748] = AX;
    CheckExternalEvents(cs9, 0x3F5);
    // RETF  (17C6_03F4 / 0x18054)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_03F5_18055(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_03F5_18055:
    CheckExternalEvents(cs9, 0x3F6);
    // PUSH BP (17C6_03F5 / 0x18055)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0x3F8);
    // MOV BP,SP (17C6_03F6 / 0x18056)
    BP = SP;
    CheckExternalEvents(cs9, 0x3FB);
    // MOV AX,0x62 (17C6_03F8 / 0x18058)
    AX = 0x62;
    CheckExternalEvents(cs9, 0x400);
    // CALLF 0x1000:cecc (17C6_03FB / 0x1805B)
    FarCall(cs9, 0x400, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x401);
    // PUSH DI (17C6_0400 / 0x18060)
    Stack.Push16(DI);
    CheckExternalEvents(cs9, 0x402);
    // PUSH SI (17C6_0401 / 0x18061)
    Stack.Push16(SI);
    CheckExternalEvents(cs9, 0x404);
    // SUB AX,AX (17C6_0402 / 0x18062)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x407);
    // MOV word ptr [BP + -0x2],AX (17C6_0404 / 0x18064)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs9, 0x40A);
    // MOV word ptr [BP + -0x8],AX (17C6_0407 / 0x18067)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs9, 0x40D);
    // MOV word ptr [BP + -0x6],AX (17C6_040A / 0x1806A)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs9, 0x411);
    // MOV byte ptr [BP + -0x32],0x0 (17C6_040D / 0x1806D)
    UInt8[SS, (ushort)(BP - 0x32)] = 0x0;
    CheckExternalEvents(cs9, 0x415);
    // MOV ES,word ptr [0x56e2] (17C6_0411 / 0x18071)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x419);
    // MOV AX,ES:[0x3748] (17C6_0415 / 0x18075)
    AX = UInt16[ES, 0x3748];
    label_17C6_0419_18079:
    CheckExternalEvents(cs9, 0x41C);
    // MOV word ptr [BP + -0x60],AX (17C6_0419 / 0x18079)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs9, 0x41F);
    // JMP 0x1000:83b2 (17C6_041C / 0x1807C)
    goto label_17C6_0752_183B2;
    label_17C6_041F_1807F:
    CheckExternalEvents(cs9, 0x423);
    // CMP word ptr [BP + -0x2],0x0 (17C6_041F / 0x1807F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs9, 0x425);
    // JZ 0x1000:8088 (17C6_0423 / 0x18083)
    if(ZeroFlag) {
      goto label_17C6_0428_18088;
    }
    CheckExternalEvents(cs9, 0x428);
    // JMP 0x1000:83c8 (17C6_0425 / 0x18085)
    goto label_17C6_0768_183C8;
    label_17C6_0428_18088:
    CheckExternalEvents(cs9, 0x42C);
    // TEST byte ptr [BP + -0x4],0x80 (17C6_0428 / 0x18088)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x80);
    CheckExternalEvents(cs9, 0x42E);
    // JZ 0x1000:8097 (17C6_042C / 0x1808C)
    if(ZeroFlag) {
      goto label_17C6_0437_18097;
    }
    CheckExternalEvents(cs9, 0x432);
    // AND byte ptr [BP + -0x4],0x7f (17C6_042E / 0x1808E)
    // UInt8[SS, (ushort)(BP - 0x4)] &= 0x7F;
    UInt8[SS, (ushort)(BP - 0x4)] = Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x7F);
    CheckExternalEvents(cs9, 0x437);
    // MOV word ptr [BP + -0x2],0x1 (17C6_0432 / 0x18092)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_17C6_0437_18097:
    CheckExternalEvents(cs9, 0x43B);
    // CMP byte ptr [BP + -0x4],0xd (17C6_0437 / 0x18097)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x4)], 0xD);
    CheckExternalEvents(cs9, 0x43D);
    // JNZ 0x1000:80f7 (17C6_043B / 0x1809B)
    if(!ZeroFlag) {
      goto label_17C6_0497_180F7;
    }
    CheckExternalEvents(cs9, 0x440);
    // MOV SI,word ptr [BP + -0x8] (17C6_043D / 0x1809D)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x444);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_0440 / 0x180A0)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x447);
    // MOV AX,word ptr [BP + -0x8] (17C6_0444 / 0x180A4)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x44A);
    // ADD AX,word ptr [BP + -0x60] (17C6_0447 / 0x180A7)
    // AX += UInt16[SS, (ushort)(BP - 0x60)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs9, 0x44E);
    // MOV ES,word ptr [0x56d6] (17C6_044A / 0x180AA)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x453);
    // CMP AX,word ptr ES:[0x3990] (17C6_044E / 0x180AE)
    Alu16.Sub(AX, UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x455);
    // JG 0x1000:80d0 (17C6_0453 / 0x180B3)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0470_180D0;
    }
    label_17C6_0455_180B5:
    CheckExternalEvents(cs9, 0x458);
    // LEA AX,[BP + -0x5e] (17C6_0455 / 0x180B5)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x459);
    // PUSH SS (17C6_0458 / 0x180B8)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x45A);
    // PUSH AX (17C6_0459 / 0x180B9)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x45D);
    // LEA AX,[BP + -0x32] (17C6_045A / 0x180BA)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x45E);
    // PUSH SS (17C6_045D / 0x180BD)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x45F);
    // PUSH AX (17C6_045E / 0x180BE)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x464);
    // CALLF 0x1000:da12 (17C6_045F / 0x180BF)
    FarCall(cs9, 0x464, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs9, 0x467);
    // ADD SP,0x8 (17C6_0464 / 0x180C4)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs9, 0x46A);
    // MOV AX,0x1 (17C6_0467 / 0x180C7)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x46B);
    // PUSH AX (17C6_046A / 0x180CA)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x46E);
    // LEA AX,[BP + -0x32] (17C6_046B / 0x180CB)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x470);
    // JMP 0x1000:80e7 (17C6_046E / 0x180CE)
    goto label_17C6_0487_180E7;
    label_17C6_0470_180D0:
    CheckExternalEvents(cs9, 0x473);
    // MOV AX,0x1 (17C6_0470 / 0x180D0)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x474);
    // PUSH AX (17C6_0473 / 0x180D3)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x477);
    // LEA AX,[BP + -0x32] (17C6_0474 / 0x180D4)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x478);
    // PUSH SS (17C6_0477 / 0x180D7)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x479);
    // PUSH AX (17C6_0478 / 0x180D8)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x47A);
    // PUSH CS (17C6_0479 / 0x180D9)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x47D);
    // CALL 0x1000:842b (17C6_047A / 0x180DA)
    NearCall(cs9, 0x47D, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x480);
    // ADD SP,0x6 (17C6_047D / 0x180DD)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs9, 0x483);
    // MOV AX,0x1 (17C6_0480 / 0x180E0)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x484);
    // PUSH AX (17C6_0483 / 0x180E3)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x487);
    // LEA AX,[BP + -0x5e] (17C6_0484 / 0x180E4)
    AX = (ushort)(BP - 0x5E);
    label_17C6_0487_180E7:
    CheckExternalEvents(cs9, 0x488);
    // PUSH SS (17C6_0487 / 0x180E7)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x489);
    // PUSH AX (17C6_0488 / 0x180E8)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x48A);
    // PUSH CS (17C6_0489 / 0x180E9)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x48D);
    // CALL 0x1000:842b (17C6_048A / 0x180EA)
    NearCall(cs9, 0x48D, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x490);
    // ADD SP,0x6 (17C6_048D / 0x180ED)
    SP += 0x6;
    CheckExternalEvents(cs9, 0x492);
    // SUB AX,AX (17C6_0490 / 0x180F0)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x495);
    // MOV word ptr [BP + -0x8],AX (17C6_0492 / 0x180F2)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs9, 0x497);
    // JMP 0x1000:8079 (17C6_0495 / 0x180F5)
    goto label_17C6_0419_18079;
    label_17C6_0497_180F7:
    CheckExternalEvents(cs9, 0x49B);
    // CMP byte ptr [BP + -0x4],0x2 (17C6_0497 / 0x180F7)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x4)], 0x2);
    CheckExternalEvents(cs9, 0x49D);
    // JNZ 0x1000:8176 (17C6_049B / 0x180FB)
    if(!ZeroFlag) {
      goto label_17C6_0516_18176;
    }
    CheckExternalEvents(cs9, 0x4A0);
    // MOV SI,word ptr [BP + -0x8] (17C6_049D / 0x180FD)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x4A4);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_04A0 / 0x18100)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x4A7);
    // MOV AX,word ptr [BP + -0x8] (17C6_04A4 / 0x18104)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x4AA);
    // ADD AX,word ptr [BP + -0x60] (17C6_04A7 / 0x18107)
    // AX += UInt16[SS, (ushort)(BP - 0x60)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs9, 0x4AE);
    // MOV ES,word ptr [0x56d6] (17C6_04AA / 0x1810A)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x4B3);
    // CMP AX,word ptr ES:[0x3990] (17C6_04AE / 0x1810E)
    Alu16.Sub(AX, UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x4B5);
    // JG 0x1000:812f (17C6_04B3 / 0x18113)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_04CF_1812F;
    }
    CheckExternalEvents(cs9, 0x4B8);
    // LEA AX,[BP + -0x5e] (17C6_04B5 / 0x18115)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x4B9);
    // PUSH SS (17C6_04B8 / 0x18118)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x4BA);
    // PUSH AX (17C6_04B9 / 0x18119)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4BD);
    // LEA AX,[BP + -0x32] (17C6_04BA / 0x1811A)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x4BE);
    // PUSH SS (17C6_04BD / 0x1811D)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x4BF);
    // PUSH AX (17C6_04BE / 0x1811E)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4C4);
    // CALLF 0x1000:da12 (17C6_04BF / 0x1811F)
    FarCall(cs9, 0x4C4, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs9, 0x4C7);
    // ADD SP,0x8 (17C6_04C4 / 0x18124)
    SP += 0x8;
    CheckExternalEvents(cs9, 0x4C9);
    // SUB AX,AX (17C6_04C7 / 0x18127)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x4CA);
    // PUSH AX (17C6_04C9 / 0x18129)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4CD);
    // LEA AX,[BP + -0x32] (17C6_04CA / 0x1812A)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x4CF);
    // JMP 0x1000:8145 (17C6_04CD / 0x1812D)
    goto label_17C6_04E5_18145;
    label_17C6_04CF_1812F:
    CheckExternalEvents(cs9, 0x4D2);
    // MOV AX,0x1 (17C6_04CF / 0x1812F)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x4D3);
    // PUSH AX (17C6_04D2 / 0x18132)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4D6);
    // LEA AX,[BP + -0x32] (17C6_04D3 / 0x18133)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x4D7);
    // PUSH SS (17C6_04D6 / 0x18136)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x4D8);
    // PUSH AX (17C6_04D7 / 0x18137)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4D9);
    // PUSH CS (17C6_04D8 / 0x18138)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x4DC);
    // CALL 0x1000:842b (17C6_04D9 / 0x18139)
    NearCall(cs9, 0x4DC, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x4DF);
    // ADD SP,0x6 (17C6_04DC / 0x1813C)
    SP += 0x6;
    CheckExternalEvents(cs9, 0x4E1);
    // SUB AX,AX (17C6_04DF / 0x1813F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x4E2);
    // PUSH AX (17C6_04E1 / 0x18141)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4E5);
    // LEA AX,[BP + -0x5e] (17C6_04E2 / 0x18142)
    AX = (ushort)(BP - 0x5E);
    label_17C6_04E5_18145:
    CheckExternalEvents(cs9, 0x4E6);
    // PUSH SS (17C6_04E5 / 0x18145)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x4E7);
    // PUSH AX (17C6_04E6 / 0x18146)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x4E8);
    // PUSH CS (17C6_04E7 / 0x18147)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x4EB);
    // CALL 0x1000:842b (17C6_04E8 / 0x18148)
    NearCall(cs9, 0x4EB, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x4EE);
    // ADD SP,0x6 (17C6_04EB / 0x1814B)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs9, 0x4F3);
    // MOV word ptr [BP + -0x8],0x0 (17C6_04EE / 0x1814E)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs9, 0x4F7);
    // MOV ES,word ptr [0x56e2] (17C6_04F3 / 0x18153)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x4FB);
    // MOV AX,ES:[0x3748] (17C6_04F7 / 0x18157)
    AX = UInt16[ES, 0x3748];
    CheckExternalEvents(cs9, 0x4FE);
    // MOV word ptr [BP + -0x60],AX (17C6_04FB / 0x1815B)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs9, 0x501);
    // MOV BX,word ptr [BP + -0x6] (17C6_04FE / 0x1815E)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs9, 0x504);
    // INC word ptr [BP + -0x6] (17C6_0501 / 0x18161)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs9, 0x507);
    // LES SI,[BP + 0x6] (17C6_0504 / 0x18164)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x50A);
    // MOV AL,byte ptr ES:[BX + SI] (17C6_0507 / 0x18167)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x50B);
    // CBW  (17C6_050A / 0x1816A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs9, 0x50F);
    // MOV ES,word ptr [0x56e0] (17C6_050B / 0x1816B)
    ES = UInt16[DS, 0x56E0];
    CheckExternalEvents(cs9, 0x513);
    // MOV ES:[0x377e],AX (17C6_050F / 0x1816F)
    UInt16[ES, 0x377E] = AX;
    CheckExternalEvents(cs9, 0x516);
    // JMP 0x1000:83b2 (17C6_0513 / 0x18173)
    goto label_17C6_0752_183B2;
    label_17C6_0516_18176:
    CheckExternalEvents(cs9, 0x51A);
    // CMP byte ptr [BP + -0x4],0x6 (17C6_0516 / 0x18176)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x4)], 0x6);
    CheckExternalEvents(cs9, 0x51C);
    // JNZ 0x1000:81f5 (17C6_051A / 0x1817A)
    if(!ZeroFlag) {
      goto label_17C6_0595_181F5;
    }
    CheckExternalEvents(cs9, 0x51F);
    // MOV SI,word ptr [BP + -0x8] (17C6_051C / 0x1817C)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x523);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_051F / 0x1817F)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x526);
    // MOV AX,word ptr [BP + -0x8] (17C6_0523 / 0x18183)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x529);
    // ADD AX,word ptr [BP + -0x60] (17C6_0526 / 0x18186)
    // AX += UInt16[SS, (ushort)(BP - 0x60)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs9, 0x52D);
    // MOV ES,word ptr [0x56d6] (17C6_0529 / 0x18189)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x532);
    // CMP AX,word ptr ES:[0x3990] (17C6_052D / 0x1818D)
    Alu16.Sub(AX, UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x534);
    // JG 0x1000:81ae (17C6_0532 / 0x18192)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_054E_181AE;
    }
    CheckExternalEvents(cs9, 0x537);
    // LEA AX,[BP + -0x5e] (17C6_0534 / 0x18194)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x538);
    // PUSH SS (17C6_0537 / 0x18197)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x539);
    // PUSH AX (17C6_0538 / 0x18198)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x53C);
    // LEA AX,[BP + -0x32] (17C6_0539 / 0x18199)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x53D);
    // PUSH SS (17C6_053C / 0x1819C)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x53E);
    // PUSH AX (17C6_053D / 0x1819D)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x543);
    // CALLF 0x1000:da12 (17C6_053E / 0x1819E)
    FarCall(cs9, 0x543, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs9, 0x546);
    // ADD SP,0x8 (17C6_0543 / 0x181A3)
    SP += 0x8;
    CheckExternalEvents(cs9, 0x548);
    // SUB AX,AX (17C6_0546 / 0x181A6)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x549);
    // PUSH AX (17C6_0548 / 0x181A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x54C);
    // LEA AX,[BP + -0x32] (17C6_0549 / 0x181A9)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x54E);
    // JMP 0x1000:81c4 (17C6_054C / 0x181AC)
    goto label_17C6_0564_181C4;
    label_17C6_054E_181AE:
    CheckExternalEvents(cs9, 0x551);
    // MOV AX,0x1 (17C6_054E / 0x181AE)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x552);
    // PUSH AX (17C6_0551 / 0x181B1)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x555);
    // LEA AX,[BP + -0x32] (17C6_0552 / 0x181B2)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x556);
    // PUSH SS (17C6_0555 / 0x181B5)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x557);
    // PUSH AX (17C6_0556 / 0x181B6)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x558);
    // PUSH CS (17C6_0557 / 0x181B7)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x55B);
    // CALL 0x1000:842b (17C6_0558 / 0x181B8)
    NearCall(cs9, 0x55B, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x55E);
    // ADD SP,0x6 (17C6_055B / 0x181BB)
    SP += 0x6;
    CheckExternalEvents(cs9, 0x560);
    // SUB AX,AX (17C6_055E / 0x181BE)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x561);
    // PUSH AX (17C6_0560 / 0x181C0)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x564);
    // LEA AX,[BP + -0x5e] (17C6_0561 / 0x181C1)
    AX = (ushort)(BP - 0x5E);
    label_17C6_0564_181C4:
    CheckExternalEvents(cs9, 0x565);
    // PUSH SS (17C6_0564 / 0x181C4)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x566);
    // PUSH AX (17C6_0565 / 0x181C5)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x567);
    // PUSH CS (17C6_0566 / 0x181C6)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x56A);
    // CALL 0x1000:842b (17C6_0567 / 0x181C7)
    NearCall(cs9, 0x56A, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x56D);
    // ADD SP,0x6 (17C6_056A / 0x181CA)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs9, 0x572);
    // MOV word ptr [BP + -0x8],0x0 (17C6_056D / 0x181CD)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs9, 0x576);
    // MOV ES,word ptr [0x56e2] (17C6_0572 / 0x181D2)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x57A);
    // MOV AX,ES:[0x3748] (17C6_0576 / 0x181D6)
    AX = UInt16[ES, 0x3748];
    CheckExternalEvents(cs9, 0x57D);
    // MOV word ptr [BP + -0x60],AX (17C6_057A / 0x181DA)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs9, 0x580);
    // MOV BX,word ptr [BP + -0x6] (17C6_057D / 0x181DD)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs9, 0x583);
    // INC word ptr [BP + -0x6] (17C6_0580 / 0x181E0)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs9, 0x586);
    // LES SI,[BP + 0x6] (17C6_0583 / 0x181E3)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x589);
    // MOV AL,byte ptr ES:[BX + SI] (17C6_0586 / 0x181E6)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x58A);
    // CBW  (17C6_0589 / 0x181E9)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs9, 0x58E);
    // MOV ES,word ptr [0x56dc] (17C6_058A / 0x181EA)
    ES = UInt16[DS, 0x56DC];
    CheckExternalEvents(cs9, 0x592);
    // MOV ES:[0x37fe],AX (17C6_058E / 0x181EE)
    UInt16[ES, 0x37FE] = AX;
    CheckExternalEvents(cs9, 0x595);
    // JMP 0x1000:83b2 (17C6_0592 / 0x181F2)
    goto label_17C6_0752_183B2;
    label_17C6_0595_181F5:
    CheckExternalEvents(cs9, 0x599);
    // CMP byte ptr [BP + -0x4],0x9 (17C6_0595 / 0x181F5)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x4)], 0x9);
    CheckExternalEvents(cs9, 0x59B);
    // JZ 0x1000:81fe (17C6_0599 / 0x181F9)
    if(ZeroFlag) {
      goto label_17C6_059E_181FE;
    }
    CheckExternalEvents(cs9, 0x59E);
    // JMP 0x1000:828b (17C6_059B / 0x181FB)
    goto label_17C6_062B_1828B;
    label_17C6_059E_181FE:
    CheckExternalEvents(cs9, 0x5A1);
    // MOV SI,word ptr [BP + -0x8] (17C6_059E / 0x181FE)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x5A5);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_05A1 / 0x18201)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x5A8);
    // MOV AX,word ptr [BP + -0x8] (17C6_05A5 / 0x18205)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x5AB);
    // ADD AX,word ptr [BP + -0x60] (17C6_05A8 / 0x18208)
    // AX += UInt16[SS, (ushort)(BP - 0x60)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs9, 0x5AF);
    // MOV ES,word ptr [0x56d6] (17C6_05AB / 0x1820B)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x5B4);
    // CMP AX,word ptr ES:[0x3990] (17C6_05AF / 0x1820F)
    Alu16.Sub(AX, UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x5B6);
    // JG 0x1000:8230 (17C6_05B4 / 0x18214)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_05D0_18230;
    }
    CheckExternalEvents(cs9, 0x5B9);
    // LEA AX,[BP + -0x5e] (17C6_05B6 / 0x18216)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x5BA);
    // PUSH SS (17C6_05B9 / 0x18219)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x5BB);
    // PUSH AX (17C6_05BA / 0x1821A)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5BE);
    // LEA AX,[BP + -0x32] (17C6_05BB / 0x1821B)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x5BF);
    // PUSH SS (17C6_05BE / 0x1821E)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x5C0);
    // PUSH AX (17C6_05BF / 0x1821F)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5C5);
    // CALLF 0x1000:da12 (17C6_05C0 / 0x18220)
    FarCall(cs9, 0x5C5, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs9, 0x5C8);
    // ADD SP,0x8 (17C6_05C5 / 0x18225)
    SP += 0x8;
    CheckExternalEvents(cs9, 0x5CA);
    // SUB AX,AX (17C6_05C8 / 0x18228)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x5CB);
    // PUSH AX (17C6_05CA / 0x1822A)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5CE);
    // LEA AX,[BP + -0x32] (17C6_05CB / 0x1822B)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x5D0);
    // JMP 0x1000:8246 (17C6_05CE / 0x1822E)
    goto label_17C6_05E6_18246;
    label_17C6_05D0_18230:
    CheckExternalEvents(cs9, 0x5D3);
    // MOV AX,0x1 (17C6_05D0 / 0x18230)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x5D4);
    // PUSH AX (17C6_05D3 / 0x18233)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5D7);
    // LEA AX,[BP + -0x32] (17C6_05D4 / 0x18234)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x5D8);
    // PUSH SS (17C6_05D7 / 0x18237)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x5D9);
    // PUSH AX (17C6_05D8 / 0x18238)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5DA);
    // PUSH CS (17C6_05D9 / 0x18239)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x5DD);
    // CALL 0x1000:842b (17C6_05DA / 0x1823A)
    NearCall(cs9, 0x5DD, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x5E0);
    // ADD SP,0x6 (17C6_05DD / 0x1823D)
    SP += 0x6;
    CheckExternalEvents(cs9, 0x5E2);
    // SUB AX,AX (17C6_05E0 / 0x18240)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x5E3);
    // PUSH AX (17C6_05E2 / 0x18242)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5E6);
    // LEA AX,[BP + -0x5e] (17C6_05E3 / 0x18243)
    AX = (ushort)(BP - 0x5E);
    label_17C6_05E6_18246:
    CheckExternalEvents(cs9, 0x5E7);
    // PUSH SS (17C6_05E6 / 0x18246)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x5E8);
    // PUSH AX (17C6_05E7 / 0x18247)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x5E9);
    // PUSH CS (17C6_05E8 / 0x18248)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x5EC);
    // CALL 0x1000:842b (17C6_05E9 / 0x18249)
    NearCall(cs9, 0x5EC, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x5EF);
    // ADD SP,0x6 (17C6_05EC / 0x1824C)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs9, 0x5F4);
    // MOV word ptr [BP + -0x8],0x0 (17C6_05EF / 0x1824F)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs9, 0x5F7);
    // MOV BX,word ptr [BP + -0x6] (17C6_05F4 / 0x18254)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs9, 0x5FA);
    // INC word ptr [BP + -0x6] (17C6_05F7 / 0x18257)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs9, 0x5FD);
    // LES SI,[BP + 0x6] (17C6_05FA / 0x1825A)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x600);
    // MOV AL,byte ptr ES:[BX + SI] (17C6_05FD / 0x1825D)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x601);
    // CBW  (17C6_0600 / 0x18260)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs9, 0x604);
    // MOV word ptr [BP + -0x60],AX (17C6_0601 / 0x18261)
    UInt16[SS, (ushort)(BP - 0x60)] = AX;
    CheckExternalEvents(cs9, 0x608);
    // MOV ES,word ptr [0x56e2] (17C6_0604 / 0x18264)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x60C);
    // MOV ES:[0x3748],AX (17C6_0608 / 0x18268)
    UInt16[ES, 0x3748] = AX;
    CheckExternalEvents(cs9, 0x610);
    // MOV ES,word ptr [0x56d6] (17C6_060C / 0x1826C)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x614);
    // MOV AX,ES:[0x3990] (17C6_0610 / 0x18270)
    AX = UInt16[ES, 0x3990];
    CheckExternalEvents(cs9, 0x618);
    // MOV ES,word ptr [0x56e2] (17C6_0614 / 0x18274)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x61D);
    // CMP word ptr ES:[0x3748],AX (17C6_0618 / 0x18278)
    Alu16.Sub(UInt16[ES, 0x3748], AX);
    CheckExternalEvents(cs9, 0x61F);
    // JGE 0x1000:8282 (17C6_061D / 0x1827D)
    if(SignFlag == OverflowFlag) {
      goto label_17C6_0622_18282;
    }
    CheckExternalEvents(cs9, 0x622);
    // JMP 0x1000:83b2 (17C6_061F / 0x1827F)
    goto label_17C6_0752_183B2;
    label_17C6_0622_18282:
    CheckExternalEvents(cs9, 0x624);
    // SUB AX,AX (17C6_0622 / 0x18282)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x628);
    // MOV ES:[0x3748],AX (17C6_0624 / 0x18284)
    UInt16[ES, 0x3748] = AX;
    CheckExternalEvents(cs9, 0x62B);
    // JMP 0x1000:8079 (17C6_0628 / 0x18288)
    goto label_17C6_0419_18079;
    label_17C6_062B_1828B:
    CheckExternalEvents(cs9, 0x62F);
    // CMP byte ptr [BP + -0x4],0x13 (17C6_062B / 0x1828B)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x4)], 0x13);
    CheckExternalEvents(cs9, 0x631);
    // JNZ 0x1000:82f3 (17C6_062F / 0x1828F)
    if(!ZeroFlag) {
      goto label_17C6_0693_182F3;
    }
    CheckExternalEvents(cs9, 0x634);
    // MOV BX,word ptr [BP + -0x6] (17C6_0631 / 0x18291)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs9, 0x637);
    // INC word ptr [BP + -0x6] (17C6_0634 / 0x18294)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs9, 0x63A);
    // LES SI,[BP + 0x6] (17C6_0637 / 0x18297)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x63D);
    // MOV AL,byte ptr ES:[BX + SI] (17C6_063A / 0x1829A)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x63E);
    // CBW  (17C6_063D / 0x1829D)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs9, 0x641);
    // MOV word ptr [BP + -0x34],AX (17C6_063E / 0x1829E)
    UInt16[SS, (ushort)(BP - 0x34)] = AX;
    CheckExternalEvents(cs9, 0x645);
    // MOV ES,word ptr [0x56e2] (17C6_0641 / 0x182A1)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x64A);
    // CMP word ptr ES:[0x3748],AX (17C6_0645 / 0x182A5)
    Alu16.Sub(UInt16[ES, 0x3748], AX);
    CheckExternalEvents(cs9, 0x64C);
    // JL 0x1000:82af (17C6_064A / 0x182AA)
    if(SignFlag != OverflowFlag) {
      // JL target is JMP, inlining.
      CheckExternalEvents(cs9, 0x651);
      // JMP 0x1000:82be (17C6_064F / 0x182AF)
      goto label_17C6_065E_182BE;
    }
    CheckExternalEvents(cs9, 0x64F);
    // JMP 0x1000:83b2 (17C6_064C / 0x182AC)
    goto label_17C6_0752_183B2;
    label_17C6_064F_182AF:
    CheckExternalEvents(cs9, 0x651);
    // JMP 0x1000:82be (17C6_064F / 0x182AF)
    goto label_17C6_065E_182BE;
    label_17C6_0651_182B1:
    CheckExternalEvents(cs9, 0x654);
    // MOV SI,word ptr [BP + -0x8] (17C6_0651 / 0x182B1)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x657);
    // INC word ptr [BP + -0x8] (17C6_0654 / 0x182B4)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x65B);
    // MOV byte ptr [BP + SI + -0x5e],0x20 (17C6_0657 / 0x182B7)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x20;
    CheckExternalEvents(cs9, 0x65E);
    // DEC word ptr [BP + -0x34] (17C6_065B / 0x182BB)
    UInt16[SS, (ushort)(BP - 0x34)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x34)]);
    label_17C6_065E_182BE:
    CheckExternalEvents(cs9, 0x662);
    // MOV ES,word ptr [0x56e2] (17C6_065E / 0x182BE)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x665);
    // MOV AX,word ptr [BP + -0x34] (17C6_0662 / 0x182C2)
    AX = UInt16[SS, (ushort)(BP - 0x34)];
    CheckExternalEvents(cs9, 0x66A);
    // CMP word ptr ES:[0x3748],AX (17C6_0665 / 0x182C5)
    Alu16.Sub(UInt16[ES, 0x3748], AX);
    CheckExternalEvents(cs9, 0x66C);
    // JL 0x1000:82b1 (17C6_066A / 0x182CA)
    if(SignFlag != OverflowFlag) {
      goto label_17C6_0651_182B1;
    }
    label_17C6_066C_182CC:
    CheckExternalEvents(cs9, 0x66F);
    // MOV SI,word ptr [BP + -0x8] (17C6_066C / 0x182CC)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x673);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_066F / 0x182CF)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x676);
    // LEA AX,[BP + -0x5e] (17C6_0673 / 0x182D3)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x677);
    // PUSH SS (17C6_0676 / 0x182D6)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x678);
    // PUSH AX (17C6_0677 / 0x182D7)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x67B);
    // LEA AX,[BP + -0x32] (17C6_0678 / 0x182D8)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x67C);
    // PUSH SS (17C6_067B / 0x182DB)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x67D);
    // PUSH AX (17C6_067C / 0x182DC)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x682);
    // CALLF 0x1000:da12 (17C6_067D / 0x182DD)
    FarCall(cs9, 0x682, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs9, 0x685);
    // ADD SP,0x8 (17C6_0682 / 0x182E2)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_17C6_0685_182E5:
    CheckExternalEvents(cs9, 0x688);
    // MOV AX,word ptr [BP + -0x8] (17C6_0685 / 0x182E5)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x68B);
    // ADD word ptr [BP + -0x60],AX (17C6_0688 / 0x182E8)
    // UInt16[SS, (ushort)(BP - 0x60)] += AX;
    UInt16[SS, (ushort)(BP - 0x60)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x60)], AX);
    CheckExternalEvents(cs9, 0x690);
    // MOV word ptr [BP + -0x8],0x0 (17C6_068B / 0x182EB)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs9, 0x693);
    // JMP 0x1000:83b2 (17C6_0690 / 0x182F0)
    goto label_17C6_0752_183B2;
    label_17C6_0693_182F3:
    CheckExternalEvents(cs9, 0x697);
    // CMP byte ptr [BP + -0x4],0x20 (17C6_0693 / 0x182F3)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x4)], 0x20);
    CheckExternalEvents(cs9, 0x699);
    // JNZ 0x1000:836c (17C6_0697 / 0x182F7)
    if(!ZeroFlag) {
      goto label_17C6_070C_1836C;
    }
    CheckExternalEvents(cs9, 0x69C);
    // MOV SI,word ptr [BP + -0x8] (17C6_0699 / 0x182F9)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x69F);
    // ADD SI,word ptr [BP + -0x60] (17C6_069C / 0x182FC)
    // SI += UInt16[SS, (ushort)(BP - 0x60)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs9, 0x6A3);
    // MOV ES,word ptr [0x56d6] (17C6_069F / 0x182FF)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x6A8);
    // CMP word ptr ES:[0x3990],SI (17C6_06A3 / 0x18303)
    Alu16.Sub(UInt16[ES, 0x3990], SI);
    CheckExternalEvents(cs9, 0x6AA);
    // JL 0x1000:831c (17C6_06A8 / 0x18308)
    if(SignFlag != OverflowFlag) {
      goto label_17C6_06BC_1831C;
    }
    CheckExternalEvents(cs9, 0x6AC);
    // JZ 0x1000:82cc (17C6_06AA / 0x1830A)
    if(ZeroFlag) {
      goto label_17C6_066C_182CC;
    }
    CheckExternalEvents(cs9, 0x6AE);
    // OR SI,SI (17C6_06AC / 0x1830C)
    // SI |= SI;
    SI = Alu16.Or(SI, SI);
    CheckExternalEvents(cs9, 0x6B0);
    // JZ 0x1000:82cc (17C6_06AE / 0x1830E)
    if(ZeroFlag) {
      goto label_17C6_066C_182CC;
    }
    CheckExternalEvents(cs9, 0x6B3);
    // MOV DI,word ptr [BP + -0x8] (17C6_06B0 / 0x18310)
    DI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x6B6);
    // INC word ptr [BP + -0x8] (17C6_06B3 / 0x18313)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x6BA);
    // MOV byte ptr [BP + DI + -0x5e],0x20 (17C6_06B6 / 0x18316)
    UInt8[SS, (ushort)(BP + DI - 0x5E)] = 0x20;
    CheckExternalEvents(cs9, 0x6BC);
    // JMP 0x1000:82cc (17C6_06BA / 0x1831A)
    goto label_17C6_066C_182CC;
    label_17C6_06BC_1831C:
    CheckExternalEvents(cs9, 0x6BF);
    // MOV SI,word ptr [BP + -0x8] (17C6_06BC / 0x1831C)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x6C2);
    // INC word ptr [BP + -0x8] (17C6_06BF / 0x1831F)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x6C6);
    // MOV byte ptr [BP + SI + -0x5e],0x20 (17C6_06C2 / 0x18322)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x20;
    label_17C6_06C6_18326:
    CheckExternalEvents(cs9, 0x6C9);
    // MOV SI,word ptr [BP + -0x8] (17C6_06C6 / 0x18326)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x6CD);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_06C9 / 0x18329)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x6D0);
    // MOV AX,0x1 (17C6_06CD / 0x1832D)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x6D1);
    // PUSH AX (17C6_06D0 / 0x18330)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x6D4);
    // LEA AX,[BP + -0x32] (17C6_06D1 / 0x18331)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x6D5);
    // PUSH SS (17C6_06D4 / 0x18334)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x6D6);
    // PUSH AX (17C6_06D5 / 0x18335)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x6D7);
    // PUSH CS (17C6_06D6 / 0x18336)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x6DA);
    // CALL 0x1000:842b (17C6_06D7 / 0x18337)
    NearCall(cs9, 0x6DA, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x6DD);
    // ADD SP,0x6 (17C6_06DA / 0x1833A)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs9, 0x6E2);
    // MOV word ptr [BP + -0x60],0x0 (17C6_06DD / 0x1833D)
    UInt16[SS, (ushort)(BP - 0x60)] = 0x0;
    CheckExternalEvents(cs9, 0x6E5);
    // LEA AX,[BP + -0x5e] (17C6_06E2 / 0x18342)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x6E6);
    // PUSH SS (17C6_06E5 / 0x18345)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x6E7);
    // PUSH AX (17C6_06E6 / 0x18346)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x6EA);
    // LEA AX,[BP + -0x32] (17C6_06E7 / 0x18347)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x6EB);
    // PUSH SS (17C6_06EA / 0x1834A)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x6EC);
    // PUSH AX (17C6_06EB / 0x1834B)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x6F1);
    // CALLF 0x1000:da58 (17C6_06EC / 0x1834C)
    FarCall(cs9, 0x6F1, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs9, 0x6F4);
    // ADD SP,0x8 (17C6_06F1 / 0x18351)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs9, 0x6F6);
    // JMP 0x1000:8359 (17C6_06F4 / 0x18354)
    goto label_17C6_06F9_18359;
    label_17C6_06F6_18356:
    CheckExternalEvents(cs9, 0x6F9);
    // INC word ptr [BP + -0x6] (17C6_06F6 / 0x18356)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    label_17C6_06F9_18359:
    CheckExternalEvents(cs9, 0x6FC);
    // MOV BX,word ptr [BP + -0x6] (17C6_06F9 / 0x18359)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs9, 0x6FF);
    // LES SI,[BP + 0x6] (17C6_06FC / 0x1835C)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x702);
    // MOV AL,byte ptr ES:[BX + SI] (17C6_06FF / 0x1835F)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x705);
    // MOV byte ptr [BP + -0x4],AL (17C6_0702 / 0x18362)
    UInt8[SS, (ushort)(BP - 0x4)] = AL;
    CheckExternalEvents(cs9, 0x707);
    // CMP AL,0x20 (17C6_0705 / 0x18365)
    Alu8.Sub(AL, 0x20);
    CheckExternalEvents(cs9, 0x709);
    // JZ 0x1000:8356 (17C6_0707 / 0x18367)
    if(ZeroFlag) {
      goto label_17C6_06F6_18356;
    }
    CheckExternalEvents(cs9, 0x70C);
    // JMP 0x1000:82e5 (17C6_0709 / 0x18369)
    goto label_17C6_0685_182E5;
    label_17C6_070C_1836C:
    CheckExternalEvents(cs9, 0x710);
    // MOV ES,word ptr [0x56d6] (17C6_070C / 0x1836C)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x714);
    // MOV AX,ES:[0x3990] (17C6_0710 / 0x18370)
    AX = UInt16[ES, 0x3990];
    CheckExternalEvents(cs9, 0x715);
    // DEC AX (17C6_0714 / 0x18374)
    AX--;
    CheckExternalEvents(cs9, 0x718);
    // CMP AX,word ptr [BP + -0x8] (17C6_0715 / 0x18375)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x71A);
    // JG 0x1000:83a6 (17C6_0718 / 0x18378)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0746_183A6;
    }
    CheckExternalEvents(cs9, 0x71E);
    // CMP byte ptr [BP + -0x32],0x0 (17C6_071A / 0x1837A)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x32)], 0x0);
    CheckExternalEvents(cs9, 0x720);
    // JZ 0x1000:8390 (17C6_071E / 0x1837E)
    if(ZeroFlag) {
      goto label_17C6_0730_18390;
    }
    CheckExternalEvents(cs9, 0x723);
    // MOV AX,0x1 (17C6_0720 / 0x18380)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x724);
    // PUSH AX (17C6_0723 / 0x18383)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x727);
    // LEA AX,[BP + -0x32] (17C6_0724 / 0x18384)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x728);
    // PUSH SS (17C6_0727 / 0x18387)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x729);
    // PUSH AX (17C6_0728 / 0x18388)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x72A);
    // PUSH CS (17C6_0729 / 0x18389)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x72D);
    // CALL 0x1000:842b (17C6_072A / 0x1838A)
    NearCall(cs9, 0x72D, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x730);
    // ADD SP,0x6 (17C6_072D / 0x1838D)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_17C6_0730_18390:
    CheckExternalEvents(cs9, 0x733);
    // MOV SI,word ptr [BP + -0x8] (17C6_0730 / 0x18390)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x736);
    // INC word ptr [BP + -0x8] (17C6_0733 / 0x18393)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x739);
    // MOV AL,byte ptr [BP + -0x4] (17C6_0736 / 0x18396)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs9, 0x73C);
    // MOV byte ptr [BP + SI + -0x5e],AL (17C6_0739 / 0x18399)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = AL;
    CheckExternalEvents(cs9, 0x73F);
    // MOV SI,word ptr [BP + -0x8] (17C6_073C / 0x1839C)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x743);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_073F / 0x1839F)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x746);
    // JMP 0x1000:80b5 (17C6_0743 / 0x183A3)
    goto label_17C6_0455_180B5;
    label_17C6_0746_183A6:
    CheckExternalEvents(cs9, 0x749);
    // MOV SI,word ptr [BP + -0x8] (17C6_0746 / 0x183A6)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x74C);
    // INC word ptr [BP + -0x8] (17C6_0749 / 0x183A9)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0x74F);
    // MOV AL,byte ptr [BP + -0x4] (17C6_074C / 0x183AC)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs9, 0x752);
    // MOV byte ptr [BP + SI + -0x5e],AL (17C6_074F / 0x183AF)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = AL;
    label_17C6_0752_183B2:
    CheckExternalEvents(cs9, 0x755);
    // MOV BX,word ptr [BP + -0x6] (17C6_0752 / 0x183B2)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs9, 0x758);
    // INC word ptr [BP + -0x6] (17C6_0755 / 0x183B5)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs9, 0x75B);
    // LES SI,[BP + 0x6] (17C6_0758 / 0x183B8)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x75E);
    // MOV AL,byte ptr ES:[BX + SI] (17C6_075B / 0x183BB)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs9, 0x761);
    // MOV byte ptr [BP + -0x4],AL (17C6_075E / 0x183BE)
    UInt8[SS, (ushort)(BP - 0x4)] = AL;
    CheckExternalEvents(cs9, 0x763);
    // OR AL,AL (17C6_0761 / 0x183C1)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs9, 0x765);
    // JZ 0x1000:83c8 (17C6_0763 / 0x183C3)
    if(ZeroFlag) {
      goto label_17C6_0768_183C8;
    }
    CheckExternalEvents(cs9, 0x768);
    // JMP 0x1000:807f (17C6_0765 / 0x183C5)
    goto label_17C6_041F_1807F;
    label_17C6_0768_183C8:
    CheckExternalEvents(cs9, 0x76C);
    // CMP word ptr [BP + -0x8],0x0 (17C6_0768 / 0x183C8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs9, 0x76E);
    // JNZ 0x1000:83d4 (17C6_076C / 0x183CC)
    if(!ZeroFlag) {
      goto label_17C6_0774_183D4;
    }
    CheckExternalEvents(cs9, 0x772);
    // CMP byte ptr [BP + -0x32],0x0 (17C6_076E / 0x183CE)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x32)], 0x0);
    CheckExternalEvents(cs9, 0x774);
    // JZ 0x1000:8425 (17C6_0772 / 0x183D2)
    if(ZeroFlag) {
      goto label_17C6_07C5_18425;
    }
    label_17C6_0774_183D4:
    CheckExternalEvents(cs9, 0x777);
    // MOV SI,word ptr [BP + -0x8] (17C6_0774 / 0x183D4)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x77B);
    // MOV byte ptr [BP + SI + -0x5e],0x0 (17C6_0777 / 0x183D7)
    UInt8[SS, (ushort)(BP + SI - 0x5E)] = 0x0;
    CheckExternalEvents(cs9, 0x77E);
    // MOV AX,word ptr [BP + -0x8] (17C6_077B / 0x183DB)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs9, 0x781);
    // ADD AX,word ptr [BP + -0x60] (17C6_077E / 0x183DE)
    // AX += UInt16[SS, (ushort)(BP - 0x60)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x60)]);
    CheckExternalEvents(cs9, 0x785);
    // MOV ES,word ptr [0x56d6] (17C6_0781 / 0x183E1)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x78A);
    // CMP AX,word ptr ES:[0x3990] (17C6_0785 / 0x183E5)
    Alu16.Sub(AX, UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x78C);
    // JG 0x1000:8406 (17C6_078A / 0x183EA)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_07A6_18406;
    }
    CheckExternalEvents(cs9, 0x78F);
    // LEA AX,[BP + -0x5e] (17C6_078C / 0x183EC)
    AX = (ushort)(BP - 0x5E);
    CheckExternalEvents(cs9, 0x790);
    // PUSH SS (17C6_078F / 0x183EF)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x791);
    // PUSH AX (17C6_0790 / 0x183F0)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x794);
    // LEA AX,[BP + -0x32] (17C6_0791 / 0x183F1)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x795);
    // PUSH SS (17C6_0794 / 0x183F4)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x796);
    // PUSH AX (17C6_0795 / 0x183F5)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x79B);
    // CALLF 0x1000:da12 (17C6_0796 / 0x183F6)
    FarCall(cs9, 0x79B, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs9, 0x79E);
    // ADD SP,0x8 (17C6_079B / 0x183FB)
    SP += 0x8;
    CheckExternalEvents(cs9, 0x7A0);
    // SUB AX,AX (17C6_079E / 0x183FE)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x7A1);
    // PUSH AX (17C6_07A0 / 0x18400)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x7A4);
    // LEA AX,[BP + -0x32] (17C6_07A1 / 0x18401)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x7A6);
    // JMP 0x1000:841c (17C6_07A4 / 0x18404)
    goto label_17C6_07BC_1841C;
    label_17C6_07A6_18406:
    CheckExternalEvents(cs9, 0x7A9);
    // MOV AX,0x1 (17C6_07A6 / 0x18406)
    AX = 0x1;
    CheckExternalEvents(cs9, 0x7AA);
    // PUSH AX (17C6_07A9 / 0x18409)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x7AD);
    // LEA AX,[BP + -0x32] (17C6_07AA / 0x1840A)
    AX = (ushort)(BP - 0x32);
    CheckExternalEvents(cs9, 0x7AE);
    // PUSH SS (17C6_07AD / 0x1840D)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x7AF);
    // PUSH AX (17C6_07AE / 0x1840E)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x7B0);
    // PUSH CS (17C6_07AF / 0x1840F)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x7B3);
    // CALL 0x1000:842b (17C6_07B0 / 0x18410)
    NearCall(cs9, 0x7B3, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x7B6);
    // ADD SP,0x6 (17C6_07B3 / 0x18413)
    SP += 0x6;
    CheckExternalEvents(cs9, 0x7B8);
    // SUB AX,AX (17C6_07B6 / 0x18416)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x7B9);
    // PUSH AX (17C6_07B8 / 0x18418)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x7BC);
    // LEA AX,[BP + -0x5e] (17C6_07B9 / 0x18419)
    AX = (ushort)(BP - 0x5E);
    label_17C6_07BC_1841C:
    CheckExternalEvents(cs9, 0x7BD);
    // PUSH SS (17C6_07BC / 0x1841C)
    Stack.Push16(SS);
    CheckExternalEvents(cs9, 0x7BE);
    // PUSH AX (17C6_07BD / 0x1841D)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x7BF);
    // PUSH CS (17C6_07BE / 0x1841E)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0x7C2);
    // CALL 0x1000:842b (17C6_07BF / 0x1841F)
    NearCall(cs9, 0x7C2, unknown_17C6_07CB_1842B);
    CheckExternalEvents(cs9, 0x7C5);
    // ADD SP,0x6 (17C6_07C2 / 0x18422)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_17C6_07C5_18425:
    CheckExternalEvents(cs9, 0x7C6);
    // POP SI (17C6_07C5 / 0x18425)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x7C7);
    // POP DI (17C6_07C6 / 0x18426)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x7C9);
    // MOV SP,BP (17C6_07C7 / 0x18427)
    SP = BP;
    CheckExternalEvents(cs9, 0x7CA);
    // POP BP (17C6_07C9 / 0x18429)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0x7CB);
    // RETF  (17C6_07CA / 0x1842A)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_07CB_1842B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_07CB_1842B:
    CheckExternalEvents(cs9, 0x7CC);
    // PUSH BP (17C6_07CB / 0x1842B)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0x7CE);
    // MOV BP,SP (17C6_07CC / 0x1842C)
    BP = SP;
    CheckExternalEvents(cs9, 0x7D1);
    // MOV AX,0x14 (17C6_07CE / 0x1842E)
    AX = 0x14;
    CheckExternalEvents(cs9, 0x7D6);
    // CALLF 0x1000:cecc (17C6_07D1 / 0x18431)
    FarCall(cs9, 0x7D6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x7D7);
    // PUSH SI (17C6_07D6 / 0x18436)
    Stack.Push16(SI);
    CheckExternalEvents(cs9, 0x7DB);
    // MOV ES,word ptr [0x56d8] (17C6_07D7 / 0x18437)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x7DF);
    // MOV AX,ES:[0x393a] (17C6_07DB / 0x1843B)
    AX = UInt16[ES, 0x393A];
    CheckExternalEvents(cs9, 0x7E3);
    // MOV ES,word ptr [0x56e4] (17C6_07DF / 0x1843F)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0x7E8);
    // CMP word ptr ES:[0x374e],AX (17C6_07E3 / 0x18443)
    Alu16.Sub(UInt16[ES, 0x374E], AX);
    CheckExternalEvents(cs9, 0x7EA);
    // JGE 0x1000:844d (17C6_07E8 / 0x18448)
    if(SignFlag == OverflowFlag) {
      goto label_17C6_07ED_1844D;
    }
    CheckExternalEvents(cs9, 0x7ED);
    // JMP 0x1000:860b (17C6_07EA / 0x1844A)
    goto label_17C6_09AB_1860B;
    label_17C6_07ED_1844D:
    CheckExternalEvents(cs9, 0x7F0);
    // PUSH word ptr [BP + 0x8] (17C6_07ED / 0x1844D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs9, 0x7F3);
    // PUSH word ptr [BP + 0x6] (17C6_07F0 / 0x18450)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs9, 0x7F8);
    // CALLF 0x1000:da8e (17C6_07F3 / 0x18453)
    FarCall(cs9, 0x7F8, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs9, 0x7FB);
    // ADD SP,0x4 (17C6_07F8 / 0x18458)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs9, 0x7FE);
    // MOV word ptr [BP + -0x12],AX (17C6_07FB / 0x1845B)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs9, 0x801);
    // MOV word ptr [BP + -0xe],AX (17C6_07FE / 0x1845E)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs9, 0x803);
    // JMP 0x1000:8470 (17C6_0801 / 0x18461)
    goto label_17C6_0810_18470;
    label_17C6_0803_18463:
    CheckExternalEvents(cs9, 0x806);
    // MOV BX,word ptr [BP + -0x12] (17C6_0803 / 0x18463)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs9, 0x809);
    // LES SI,[BP + 0x6] (17C6_0806 / 0x18466)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x80D);
    // MOV byte ptr ES:[BX + SI],0x20 (17C6_0809 / 0x18469)
    UInt8[ES, (ushort)(BX + SI)] = 0x20;
    CheckExternalEvents(cs9, 0x810);
    // INC word ptr [BP + -0x12] (17C6_080D / 0x1846D)
    UInt16[SS, (ushort)(BP - 0x12)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x12)]);
    label_17C6_0810_18470:
    CheckExternalEvents(cs9, 0x814);
    // MOV ES,word ptr [0x56d6] (17C6_0810 / 0x18470)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x817);
    // MOV AX,word ptr [BP + -0x12] (17C6_0814 / 0x18474)
    AX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs9, 0x81C);
    // CMP word ptr ES:[0x3990],AX (17C6_0817 / 0x18477)
    Alu16.Sub(UInt16[ES, 0x3990], AX);
    CheckExternalEvents(cs9, 0x81E);
    // JG 0x1000:8463 (17C6_081C / 0x1847C)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0803_18463;
    }
    CheckExternalEvents(cs9, 0x823);
    // MOV BX,word ptr ES:[0x3990] (17C6_081E / 0x1847E)
    BX = UInt16[ES, 0x3990];
    CheckExternalEvents(cs9, 0x826);
    // LES SI,[BP + 0x6] (17C6_0823 / 0x18483)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0x82A);
    // MOV byte ptr ES:[BX + SI],0x0 (17C6_0826 / 0x18486)
    UInt8[ES, (ushort)(BX + SI)] = 0x0;
    CheckExternalEvents(cs9, 0x82E);
    // MOV ES,word ptr [0x56d2] (17C6_082A / 0x1848A)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x832);
    // MOV AX,ES:[0x39a4] (17C6_082E / 0x1848E)
    AX = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x834);
    // MOV CL,0x3 (17C6_0832 / 0x18492)
    CL = 0x3;
    CheckExternalEvents(cs9, 0x836);
    // SHL AX,CL (17C6_0834 / 0x18494)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x839);
    // MOV word ptr [BP + -0x14],AX (17C6_0836 / 0x18496)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs9, 0x83D);
    // MOV ES,word ptr [0x56d8] (17C6_0839 / 0x18499)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x841);
    // MOV AX,ES:[0x393a] (17C6_083D / 0x1849D)
    AX = UInt16[ES, 0x393A];
    CheckExternalEvents(cs9, 0x843);
    // SHL AX,CL (17C6_0841 / 0x184A1)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x846);
    // MOV word ptr [BP + -0x10],AX (17C6_0843 / 0x184A3)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs9, 0x84A);
    // MOV ES,word ptr [0x56e6] (17C6_0846 / 0x184A6)
    ES = UInt16[DS, 0x56E6];
    CheckExternalEvents(cs9, 0x850);
    // CMP word ptr ES:[0x4fba],0x2 (17C6_084A / 0x184AA)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs9, 0x852);
    // JNZ 0x1000:84d7 (17C6_0850 / 0x184B0)
    if(!ZeroFlag) {
      goto label_17C6_0877_184D7;
    }
    CheckExternalEvents(cs9, 0x855);
    // SUB AX,0x8 (17C6_0852 / 0x184B2)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs9, 0x856);
    // PUSH AX (17C6_0855 / 0x184B5)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x85A);
    // MOV ES,word ptr [0x56d6] (17C6_0856 / 0x184B6)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x85F);
    // PUSH word ptr ES:[0x3990] (17C6_085A / 0x184BA)
    Stack.Push16(UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x862);
    // PUSH word ptr [BP + -0x14] (17C6_085F / 0x184BF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs9, 0x866);
    // MOV ES,word ptr [0x56d0] (17C6_0862 / 0x184C2)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x86B);
    // PUSH word ptr ES:[0x39a0] (17C6_0866 / 0x184C6)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0x86D);
    // SUB AX,AX (17C6_086B / 0x184CB)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x870);
    // MOV DX,0xa000 (17C6_086D / 0x184CD)
    DX = 0xA000;
    label_17C6_0870_184D0:
    CheckExternalEvents(cs9, 0x871);
    // PUSH DX (17C6_0870 / 0x184D0)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0x872);
    // PUSH AX (17C6_0871 / 0x184D1)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x875);
    // MOV AX,0x140 (17C6_0872 / 0x184D2)
    AX = 0x140;
    CheckExternalEvents(cs9, 0x877);
    // JMP 0x1000:854e (17C6_0875 / 0x184D5)
    goto label_17C6_08EE_1854E;
    label_17C6_0877_184D7:
    CheckExternalEvents(cs9, 0x87B);
    // MOV ES,word ptr [0x56e6] (17C6_0877 / 0x184D7)
    ES = UInt16[DS, 0x56E6];
    CheckExternalEvents(cs9, 0x881);
    // CMP word ptr ES:[0x4fba],0x3 (17C6_087B / 0x184DB)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x3);
    CheckExternalEvents(cs9, 0x883);
    // JZ 0x1000:8517 (17C6_0881 / 0x184E1)
    if(ZeroFlag) {
      goto label_17C6_08B7_18517;
    }
    CheckExternalEvents(cs9, 0x887);
    // MOV ES,word ptr [0x56d8] (17C6_0883 / 0x184E3)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x88B);
    // MOV AX,ES:[0x393a] (17C6_0887 / 0x184E7)
    AX = UInt16[ES, 0x393A];
    CheckExternalEvents(cs9, 0x88D);
    // MOV CL,0x3 (17C6_088B / 0x184EB)
    CL = 0x3;
    CheckExternalEvents(cs9, 0x88F);
    // SHL AX,CL (17C6_088D / 0x184ED)
    AX <<= CL;
    CheckExternalEvents(cs9, 0x892);
    // SUB AX,0x8 (17C6_088F / 0x184EF)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs9, 0x893);
    // PUSH AX (17C6_0892 / 0x184F2)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x897);
    // MOV ES,word ptr [0x56d6] (17C6_0893 / 0x184F3)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x89C);
    // PUSH word ptr ES:[0x3990] (17C6_0897 / 0x184F7)
    Stack.Push16(UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x8A0);
    // MOV ES,word ptr [0x56d2] (17C6_089C / 0x184FC)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x8A4);
    // MOV AX,ES:[0x39a4] (17C6_08A0 / 0x18500)
    AX = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x8A6);
    // SHL AX,CL (17C6_08A4 / 0x18504)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x8A7);
    // PUSH AX (17C6_08A6 / 0x18506)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x8AB);
    // MOV ES,word ptr [0x56d0] (17C6_08A7 / 0x18507)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x8B0);
    // PUSH word ptr ES:[0x39a0] (17C6_08AB / 0x1850B)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0x8B2);
    // SUB AX,AX (17C6_08B0 / 0x18510)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x8B5);
    // MOV DX,0xb800 (17C6_08B2 / 0x18512)
    DX = 0xB800;
    CheckExternalEvents(cs9, 0x8B7);
    // JMP 0x1000:84d0 (17C6_08B5 / 0x18515)
    goto label_17C6_0870_184D0;
    label_17C6_08B7_18517:
    CheckExternalEvents(cs9, 0x8BB);
    // MOV ES,word ptr [0x56d8] (17C6_08B7 / 0x18517)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x8BF);
    // MOV AX,ES:[0x393a] (17C6_08BB / 0x1851B)
    AX = UInt16[ES, 0x393A];
    CheckExternalEvents(cs9, 0x8C1);
    // MOV CL,0x3 (17C6_08BF / 0x1851F)
    CL = 0x3;
    CheckExternalEvents(cs9, 0x8C3);
    // SHL AX,CL (17C6_08C1 / 0x18521)
    AX <<= CL;
    CheckExternalEvents(cs9, 0x8C6);
    // SUB AX,0x8 (17C6_08C3 / 0x18523)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs9, 0x8C7);
    // PUSH AX (17C6_08C6 / 0x18526)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x8CB);
    // MOV ES,word ptr [0x56d6] (17C6_08C7 / 0x18527)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x8D0);
    // PUSH word ptr ES:[0x3990] (17C6_08CB / 0x1852B)
    Stack.Push16(UInt16[ES, 0x3990]);
    CheckExternalEvents(cs9, 0x8D4);
    // MOV ES,word ptr [0x56d2] (17C6_08D0 / 0x18530)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x8D8);
    // MOV AX,ES:[0x39a4] (17C6_08D4 / 0x18534)
    AX = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x8DA);
    // SHL AX,CL (17C6_08D8 / 0x18538)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x8DB);
    // PUSH AX (17C6_08DA / 0x1853A)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x8DF);
    // MOV ES,word ptr [0x56d0] (17C6_08DB / 0x1853B)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x8E4);
    // PUSH word ptr ES:[0x39a0] (17C6_08DF / 0x1853F)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0x8E6);
    // SUB AX,AX (17C6_08E4 / 0x18544)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x8E9);
    // MOV DX,0xa000 (17C6_08E6 / 0x18546)
    DX = 0xA000;
    CheckExternalEvents(cs9, 0x8EA);
    // PUSH DX (17C6_08E9 / 0x18549)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0x8EB);
    // PUSH AX (17C6_08EA / 0x1854A)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x8EE);
    // MOV AX,0xa00 (17C6_08EB / 0x1854B)
    AX = 0xA00;
    label_17C6_08EE_1854E:
    CheckExternalEvents(cs9, 0x8EF);
    // PUSH DX (17C6_08EE / 0x1854E)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0x8F0);
    // PUSH AX (17C6_08EF / 0x1854F)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x8F5);
    // CALLF 0x1000:c34c (17C6_08F0 / 0x18550)
    FarCall(cs9, 0x8F5, unknown_19EF_245C_1C34C);
    CheckExternalEvents(cs9, 0x8F8);
    // ADD SP,0x10 (17C6_08F5 / 0x18555)
    // SP += 0x10;
    SP = Alu16.Add(SP, 0x10);
    CheckExternalEvents(cs9, 0x8FC);
    // MOV ES,word ptr [0x56d2] (17C6_08F8 / 0x18558)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x901);
    // MOV SI,word ptr ES:[0x39a4] (17C6_08FC / 0x1855C)
    SI = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x905);
    // MOV ES,word ptr [0x56d8] (17C6_0901 / 0x18561)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x90A);
    // ADD SI,word ptr ES:[0x393a] (17C6_0905 / 0x18565)
    // SI += UInt16[ES, 0x393A];
    SI = Alu16.Add(SI, UInt16[ES, 0x393A]);
    CheckExternalEvents(cs9, 0x90C);
    // MOV CL,0x3 (17C6_090A / 0x1856A)
    CL = 0x3;
    CheckExternalEvents(cs9, 0x90E);
    // SHL SI,CL (17C6_090C / 0x1856C)
    SI <<= CL;
    CheckExternalEvents(cs9, 0x910);
    // SUB AX,AX (17C6_090E / 0x1856E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x911);
    // PUSH AX (17C6_0910 / 0x18570)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x914);
    // LEA AX,[SI + -0x1] (17C6_0911 / 0x18571)
    AX = (ushort)(SI - 0x1);
    CheckExternalEvents(cs9, 0x915);
    // PUSH AX (17C6_0914 / 0x18574)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x919);
    // MOV ES,word ptr [0x56d0] (17C6_0915 / 0x18575)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x91D);
    // MOV AX,ES:[0x39a0] (17C6_0919 / 0x18579)
    AX = UInt16[ES, 0x39A0];
    CheckExternalEvents(cs9, 0x921);
    // MOV ES,word ptr [0x56d6] (17C6_091D / 0x1857D)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0x926);
    // ADD AX,word ptr ES:[0x3990] (17C6_0921 / 0x18581)
    AX += UInt16[ES, 0x3990];
    CheckExternalEvents(cs9, 0x928);
    // SHL AX,CL (17C6_0926 / 0x18586)
    AX <<= CL;
    CheckExternalEvents(cs9, 0x92B);
    // SUB AX,0x8 (17C6_0928 / 0x18588)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs9, 0x92C);
    // PUSH AX (17C6_092B / 0x1858B)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x92F);
    // LEA AX,[SI + -0x8] (17C6_092C / 0x1858C)
    AX = (ushort)(SI - 0x8);
    CheckExternalEvents(cs9, 0x930);
    // PUSH AX (17C6_092F / 0x1858F)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x934);
    // MOV ES,word ptr [0x56d0] (17C6_0930 / 0x18590)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x938);
    // MOV AX,ES:[0x39a0] (17C6_0934 / 0x18594)
    AX = UInt16[ES, 0x39A0];
    CheckExternalEvents(cs9, 0x93A);
    // SHL AX,CL (17C6_0938 / 0x18598)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0x93B);
    // PUSH AX (17C6_093A / 0x1859A)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x940);
    // CALLF 0x1000:8ccb (17C6_093B / 0x1859B)
    FarCall(cs9, 0x940, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs9, 0x943);
    // ADD SP,0xa (17C6_0940 / 0x185A0)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs9, 0x947);
    // MOV ES,word ptr [0x56e0] (17C6_0943 / 0x185A3)
    ES = UInt16[DS, 0x56E0];
    CheckExternalEvents(cs9, 0x94C);
    // PUSH word ptr ES:[0x377e] (17C6_0947 / 0x185A7)
    Stack.Push16(UInt16[ES, 0x377E]);
    CheckExternalEvents(cs9, 0x950);
    // MOV ES,word ptr [0x56dc] (17C6_094C / 0x185AC)
    ES = UInt16[DS, 0x56DC];
    CheckExternalEvents(cs9, 0x955);
    // PUSH word ptr ES:[0x37fe] (17C6_0950 / 0x185B0)
    Stack.Push16(UInt16[ES, 0x37FE]);
    CheckExternalEvents(cs9, 0x959);
    // MOV ES,word ptr [0x56d2] (17C6_0955 / 0x185B5)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x95D);
    // MOV AX,ES:[0x39a4] (17C6_0959 / 0x185B9)
    AX = UInt16[ES, 0x39A4];
    CheckExternalEvents(cs9, 0x961);
    // MOV ES,word ptr [0x56d8] (17C6_095D / 0x185BD)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x966);
    // ADD AX,word ptr ES:[0x393a] (17C6_0961 / 0x185C1)
    AX += UInt16[ES, 0x393A];
    CheckExternalEvents(cs9, 0x967);
    // DEC AX (17C6_0966 / 0x185C6)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs9, 0x968);
    // PUSH AX (17C6_0967 / 0x185C7)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x96C);
    // MOV ES,word ptr [0x56d0] (17C6_0968 / 0x185C8)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x971);
    // PUSH word ptr ES:[0x39a0] (17C6_096C / 0x185CC)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0x974);
    // PUSH word ptr [BP + 0x8] (17C6_0971 / 0x185D1)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs9, 0x977);
    // PUSH word ptr [BP + 0x6] (17C6_0974 / 0x185D4)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs9, 0x97C);
    // CALLF 0x1000:8ba5 (17C6_0977 / 0x185D7)
    FarCall(cs9, 0x97C, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs9, 0x97F);
    // ADD SP,0xc (17C6_097C / 0x185DC)
    SP += 0xC;
    CheckExternalEvents(cs9, 0x983);
    // CMP word ptr [BP + 0xa],0x0 (17C6_097F / 0x185DF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs9, 0x985);
    // JZ 0x1000:85ec (17C6_0983 / 0x185E3)
    if(ZeroFlag) {
      goto label_17C6_098C_185EC;
    }
    label_17C6_0985_185E5:
    CheckExternalEvents(cs9, 0x989);
    // MOV ES,word ptr [0x56e2] (17C6_0985 / 0x185E5)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x98C);
    // JMP 0x1000:867f (17C6_0989 / 0x185E9)
    goto label_17C6_0A1F_1867F;
    label_17C6_098C_185EC:
    CheckExternalEvents(cs9, 0x990);
    // MOV ES,word ptr [0x56e2] (17C6_098C / 0x185EC)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x993);
    // MOV AX,word ptr [BP + -0xe] (17C6_0990 / 0x185F0)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs9, 0x998);
    // ADD word ptr ES:[0x3748],AX (17C6_0993 / 0x185F3)
    // UInt16[ES, 0x3748] += AX;
    UInt16[ES, 0x3748] = Alu16.Add(UInt16[ES, 0x3748], AX);
    CheckExternalEvents(cs9, 0x99C);
    // MOV ES,word ptr [0x56d8] (17C6_0998 / 0x185F8)
    ES = UInt16[DS, 0x56D8];
    CheckExternalEvents(cs9, 0x9A0);
    // MOV AX,ES:[0x393a] (17C6_099C / 0x185FC)
    AX = UInt16[ES, 0x393A];
    CheckExternalEvents(cs9, 0x9A1);
    // DEC AX (17C6_09A0 / 0x18600)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs9, 0x9A5);
    // MOV ES,word ptr [0x56e4] (17C6_09A1 / 0x18601)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0x9A9);
    // MOV ES:[0x374e],AX (17C6_09A5 / 0x18605)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs9, 0x9AB);
    // JMP 0x1000:866c (17C6_09A9 / 0x18609)
    goto label_17C6_0A0C_1866C;
    label_17C6_09AB_1860B:
    CheckExternalEvents(cs9, 0x9AF);
    // MOV ES,word ptr [0x56e0] (17C6_09AB / 0x1860B)
    ES = UInt16[DS, 0x56E0];
    CheckExternalEvents(cs9, 0x9B4);
    // PUSH word ptr ES:[0x377e] (17C6_09AF / 0x1860F)
    Stack.Push16(UInt16[ES, 0x377E]);
    CheckExternalEvents(cs9, 0x9B8);
    // MOV ES,word ptr [0x56dc] (17C6_09B4 / 0x18614)
    ES = UInt16[DS, 0x56DC];
    CheckExternalEvents(cs9, 0x9BD);
    // PUSH word ptr ES:[0x37fe] (17C6_09B8 / 0x18618)
    Stack.Push16(UInt16[ES, 0x37FE]);
    CheckExternalEvents(cs9, 0x9C1);
    // MOV ES,word ptr [0x56e4] (17C6_09BD / 0x1861D)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0x9C5);
    // MOV AX,ES:[0x374e] (17C6_09C1 / 0x18621)
    AX = UInt16[ES, 0x374E];
    CheckExternalEvents(cs9, 0x9C9);
    // MOV ES,word ptr [0x56d2] (17C6_09C5 / 0x18625)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0x9CE);
    // ADD AX,word ptr ES:[0x39a4] (17C6_09C9 / 0x18629)
    // AX += UInt16[ES, 0x39A4];
    AX = Alu16.Add(AX, UInt16[ES, 0x39A4]);
    CheckExternalEvents(cs9, 0x9CF);
    // PUSH AX (17C6_09CE / 0x1862E)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x9D3);
    // MOV ES,word ptr [0x56e2] (17C6_09CF / 0x1862F)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0x9D7);
    // MOV AX,ES:[0x3748] (17C6_09D3 / 0x18633)
    AX = UInt16[ES, 0x3748];
    CheckExternalEvents(cs9, 0x9DB);
    // MOV ES,word ptr [0x56d0] (17C6_09D7 / 0x18637)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0x9E0);
    // ADD AX,word ptr ES:[0x39a0] (17C6_09DB / 0x1863B)
    // AX += UInt16[ES, 0x39A0];
    AX = Alu16.Add(AX, UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0x9E1);
    // PUSH AX (17C6_09E0 / 0x18640)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x9E4);
    // PUSH word ptr [BP + 0x8] (17C6_09E1 / 0x18641)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs9, 0x9E7);
    // PUSH word ptr [BP + 0x6] (17C6_09E4 / 0x18644)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs9, 0x9EC);
    // CALLF 0x1000:8ba5 (17C6_09E7 / 0x18647)
    FarCall(cs9, 0x9EC, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs9, 0x9EF);
    // ADD SP,0xc (17C6_09EC / 0x1864C)
    SP += 0xC;
    CheckExternalEvents(cs9, 0x9F3);
    // CMP word ptr [BP + 0xa],0x0 (17C6_09EF / 0x1864F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs9, 0x9F5);
    // JNZ 0x1000:85e5 (17C6_09F3 / 0x18653)
    if(!ZeroFlag) {
      goto label_17C6_0985_185E5;
    }
    CheckExternalEvents(cs9, 0x9F8);
    // PUSH word ptr [BP + 0x8] (17C6_09F5 / 0x18655)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs9, 0x9FB);
    // PUSH word ptr [BP + 0x6] (17C6_09F8 / 0x18658)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs9, 0xA00);
    // CALLF 0x1000:da8e (17C6_09FB / 0x1865B)
    FarCall(cs9, 0xA00, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs9, 0xA03);
    // ADD SP,0x4 (17C6_0A00 / 0x18660)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs9, 0xA07);
    // MOV ES,word ptr [0x56e2] (17C6_0A03 / 0x18663)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0xA0C);
    // ADD word ptr ES:[0x3748],AX (17C6_0A07 / 0x18667)
    // UInt16[ES, 0x3748] += AX;
    UInt16[ES, 0x3748] = Alu16.Add(UInt16[ES, 0x3748], AX);
    label_17C6_0A0C_1866C:
    CheckExternalEvents(cs9, 0xA10);
    // MOV ES,word ptr [0x56d6] (17C6_0A0C / 0x1866C)
    ES = UInt16[DS, 0x56D6];
    CheckExternalEvents(cs9, 0xA14);
    // MOV AX,ES:[0x3990] (17C6_0A10 / 0x18670)
    AX = UInt16[ES, 0x3990];
    CheckExternalEvents(cs9, 0xA18);
    // MOV ES,word ptr [0x56e2] (17C6_0A14 / 0x18674)
    ES = UInt16[DS, 0x56E2];
    CheckExternalEvents(cs9, 0xA1D);
    // CMP word ptr ES:[0x3748],AX (17C6_0A18 / 0x18678)
    Alu16.Sub(UInt16[ES, 0x3748], AX);
    CheckExternalEvents(cs9, 0xA1F);
    // JL 0x1000:868f (17C6_0A1D / 0x1867D)
    if(SignFlag != OverflowFlag) {
      goto label_17C6_0A2F_1868F;
    }
    label_17C6_0A1F_1867F:
    CheckExternalEvents(cs9, 0xA26);
    // MOV word ptr ES:[0x3748],0x0 (17C6_0A1F / 0x1867F)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs9, 0xA2A);
    // MOV ES,word ptr [0x56e4] (17C6_0A26 / 0x18686)
    ES = UInt16[DS, 0x56E4];
    CheckExternalEvents(cs9, 0xA2F);
    // INC word ptr ES:[0x374e] (17C6_0A2A / 0x1868A)
    UInt16[ES, 0x374E] = Alu16.Inc(UInt16[ES, 0x374E]);
    label_17C6_0A2F_1868F:
    CheckExternalEvents(cs9, 0xA32);
    // LES BX,[BP + 0x6] (17C6_0A2F / 0x1868F)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0xA36);
    // MOV byte ptr ES:[BX],0x0 (17C6_0A32 / 0x18692)
    UInt8[ES, (ushort)(BX)] = 0x0;
    CheckExternalEvents(cs9, 0xA37);
    // POP SI (17C6_0A36 / 0x18696)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs9, 0xA39);
    // MOV SP,BP (17C6_0A37 / 0x18697)
    SP = BP;
    CheckExternalEvents(cs9, 0xA3A);
    // POP BP (17C6_0A39 / 0x18699)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0xA3B);
    // RETF  (17C6_0A3A / 0x1869A)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_0A3B_1869B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_0A3B_1869B:
    CheckExternalEvents(cs9, 0xA3C);
    // PUSH BP (17C6_0A3B / 0x1869B)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0xA3E);
    // MOV BP,SP (17C6_0A3C / 0x1869C)
    BP = SP;
    CheckExternalEvents(cs9, 0xA41);
    // MOV AX,0x4 (17C6_0A3E / 0x1869E)
    AX = 0x4;
    CheckExternalEvents(cs9, 0xA46);
    // CALLF 0x1000:cecc (17C6_0A41 / 0x186A1)
    FarCall(cs9, 0xA46, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0xA4A);
    // MOV ES,word ptr [0x56e6] (17C6_0A46 / 0x186A6)
    ES = UInt16[DS, 0x56E6];
    CheckExternalEvents(cs9, 0xA50);
    // CMP word ptr ES:[0x4fba],0x2 (17C6_0A4A / 0x186AA)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs9, 0xA52);
    // JZ 0x1000:872d (17C6_0A50 / 0x186B0)
    if(ZeroFlag) {
      goto label_17C6_0ACD_1872D;
    }
    CheckExternalEvents(cs9, 0xA57);
    // MOV word ptr [BP + -0x2],0x50 (17C6_0A52 / 0x186B2)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x50;
    CheckExternalEvents(cs9, 0xA5D);
    // CMP word ptr ES:[0x4fba],0x0 (17C6_0A57 / 0x186B7)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs9, 0xA5F);
    // JZ 0x1000:86d3 (17C6_0A5D / 0x186BD)
    if(ZeroFlag) {
      goto label_17C6_0A73_186D3;
    }
    CheckExternalEvents(cs9, 0xA62);
    // MOV AX,0x280 (17C6_0A5F / 0x186BF)
    AX = 0x280;
    CheckExternalEvents(cs9, 0xA65);
    // IMUL word ptr [BP + 0x10] (17C6_0A62 / 0x186C2)
    int resImul17C6_0A62 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x10)]);
    AX = (ushort)(resImul17C6_0A62);
    DX = (ushort)(resImul17C6_0A62 >> 16);
    CheckExternalEvents(cs9, 0xA68);
    // MOV CX,word ptr [BP + 0xe] (17C6_0A65 / 0x186C5)
    CX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs9, 0xA6A);
    // SHL CX,0x1 (17C6_0A68 / 0x186C8)
    CX <<= 0x1;
    CheckExternalEvents(cs9, 0xA6C);
    // ADD AX,CX (17C6_0A6A / 0x186CA)
    AX += CX;
    CheckExternalEvents(cs9, 0xA6E);
    // SHL AX,0x1 (17C6_0A6C / 0x186CC)
    AX <<= 0x1;
    CheckExternalEvents(cs9, 0xA71);
    // ADD word ptr [BP + 0x6],AX (17C6_0A6E / 0x186CE)
    // UInt16[SS, (ushort)(BP + 0x6)] += AX;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs9, 0xA73);
    // JMP 0x1000:86e6 (17C6_0A71 / 0x186D1)
    goto label_17C6_0A86_186E6;
    label_17C6_0A73_186D3:
    CheckExternalEvents(cs9, 0xA76);
    // MOV AX,0x140 (17C6_0A73 / 0x186D3)
    AX = 0x140;
    CheckExternalEvents(cs9, 0xA79);
    // IMUL word ptr [BP + 0x10] (17C6_0A76 / 0x186D6)
    int resImul17C6_0A76 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x10)]);
    AX = (ushort)(resImul17C6_0A76);
    DX = (ushort)(resImul17C6_0A76 >> 16);
    CheckExternalEvents(cs9, 0xA7C);
    // ADD AX,word ptr [BP + 0xe] (17C6_0A79 / 0x186D9)
    AX += UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs9, 0xA7E);
    // SHL AX,0x1 (17C6_0A7C / 0x186DC)
    AX <<= 0x1;
    CheckExternalEvents(cs9, 0xA81);
    // ADD word ptr [BP + 0x6],AX (17C6_0A7E / 0x186DE)
    // UInt16[SS, (ushort)(BP + 0x6)] += AX;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs9, 0xA86);
    // MOV word ptr [BP + -0x2],0x28 (17C6_0A81 / 0x186E1)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x28;
    label_17C6_0A86_186E6:
    CheckExternalEvents(cs9, 0xA8B);
    // MOV word ptr [BP + -0x4],0x0 (17C6_0A86 / 0x186E6)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs9, 0xA8D);
    // JMP 0x1000:86f0 (17C6_0A8B / 0x186EB)
    goto label_17C6_0A90_186F0;
    label_17C6_0A8D_186ED:
    CheckExternalEvents(cs9, 0xA90);
    // INC word ptr [BP + -0x4] (17C6_0A8D / 0x186ED)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_17C6_0A90_186F0:
    CheckExternalEvents(cs9, 0xA94);
    // CMP word ptr [BP + -0x4],0x8 (17C6_0A90 / 0x186F0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x8);
    CheckExternalEvents(cs9, 0xA96);
    // JGE 0x1000:8741 (17C6_0A94 / 0x186F4)
    if(SignFlag == OverflowFlag) {
      goto label_17C6_0AE1_18741;
    }
    CheckExternalEvents(cs9, 0xA99);
    // LES BX,[BP + 0x6] (17C6_0A96 / 0x186F6)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0xA9C);
    // MOV AX,word ptr ES:[BX] (17C6_0A99 / 0x186F9)
    AX = UInt16[ES, (ushort)(BX)];
    CheckExternalEvents(cs9, 0xA9F);
    // LES BX,[BP + 0xa] (17C6_0A9C / 0x186FC)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    ES = UInt16[SS, (ushort)(BP + 0xA + 2)];
    CheckExternalEvents(cs9, 0xAA3);
    // ADD word ptr [BP + 0xa],0x2 (17C6_0A9F / 0x186FF)
    // UInt16[SS, (ushort)(BP + 0xA)] += 0x2;
    UInt16[SS, (ushort)(BP + 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0xA)], 0x2);
    CheckExternalEvents(cs9, 0xAA6);
    // MOV word ptr ES:[BX],AX (17C6_0AA3 / 0x18703)
    UInt16[ES, (ushort)(BX)] = AX;
    CheckExternalEvents(cs9, 0xAAA);
    // MOV ES,word ptr [0x56e6] (17C6_0AA6 / 0x18706)
    ES = UInt16[DS, 0x56E6];
    CheckExternalEvents(cs9, 0xAB0);
    // CMP word ptr ES:[0x4fba],0x0 (17C6_0AAA / 0x1870A)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs9, 0xAB2);
    // JZ 0x1000:8723 (17C6_0AB0 / 0x18710)
    if(ZeroFlag) {
      goto label_17C6_0AC3_18723;
    }
    CheckExternalEvents(cs9, 0xAB5);
    // LES BX,[BP + 0x6] (17C6_0AB2 / 0x18712)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs9, 0xAB9);
    // MOV AX,word ptr ES:[BX + 0x2] (17C6_0AB5 / 0x18715)
    AX = UInt16[ES, (ushort)(BX + 0x2)];
    CheckExternalEvents(cs9, 0xABC);
    // LES BX,[BP + 0xa] (17C6_0AB9 / 0x18719)
    BX = UInt16[SS, (ushort)(BP + 0xA)];
    ES = UInt16[SS, (ushort)(BP + 0xA + 2)];
    CheckExternalEvents(cs9, 0xAC0);
    // ADD word ptr [BP + 0xa],0x2 (17C6_0ABC / 0x1871C)
    // UInt16[SS, (ushort)(BP + 0xA)] += 0x2;
    UInt16[SS, (ushort)(BP + 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0xA)], 0x2);
    CheckExternalEvents(cs9, 0xAC3);
    // MOV word ptr ES:[BX],AX (17C6_0AC0 / 0x18720)
    UInt16[ES, (ushort)(BX)] = AX;
    label_17C6_0AC3_18723:
    CheckExternalEvents(cs9, 0xAC6);
    // MOV AX,word ptr [BP + -0x2] (17C6_0AC3 / 0x18723)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs9, 0xAC8);
    // SHL AX,0x1 (17C6_0AC6 / 0x18726)
    AX <<= 0x1;
    CheckExternalEvents(cs9, 0xACB);
    // ADD word ptr [BP + 0x6],AX (17C6_0AC8 / 0x18728)
    // UInt16[SS, (ushort)(BP + 0x6)] += AX;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Add(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs9, 0xACD);
    // JMP 0x1000:86ed (17C6_0ACB / 0x1872B)
    goto label_17C6_0A8D_186ED;
    label_17C6_0ACD_1872D:
    CheckExternalEvents(cs9, 0xAD0);
    // PUSH word ptr [BP + 0x10] (17C6_0ACD / 0x1872D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs9, 0xAD3);
    // PUSH word ptr [BP + 0xe] (17C6_0AD0 / 0x18730)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs9, 0xAD6);
    // PUSH word ptr [BP + 0xc] (17C6_0AD3 / 0x18733)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs9, 0xAD9);
    // PUSH word ptr [BP + 0xa] (17C6_0AD6 / 0x18736)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs9, 0xADE);
    // CALLF 0x1000:a203 (17C6_0AD9 / 0x18739)
    FarCall(cs9, 0xADE, ghidra_guess_1000_A203_1A203);
    CheckExternalEvents(cs9, 0xAE1);
    // ADD SP,0x8 (17C6_0ADE / 0x1873E)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_17C6_0AE1_18741:
    CheckExternalEvents(cs9, 0xAE3);
    // MOV SP,BP (17C6_0AE1 / 0x18741)
    SP = BP;
    CheckExternalEvents(cs9, 0xAE4);
    // POP BP (17C6_0AE3 / 0x18743)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0xAE5);
    // RETF  (17C6_0AE4 / 0x18744)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_0AE5_18745(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_0AE5_18745:
    CheckExternalEvents(cs9, 0xAE6);
    // PUSH BP (17C6_0AE5 / 0x18745)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0xAE8);
    // MOV BP,SP (17C6_0AE6 / 0x18746)
    BP = SP;
    CheckExternalEvents(cs9, 0xAEB);
    // MOV AX,0xe (17C6_0AE8 / 0x18748)
    AX = 0xE;
    CheckExternalEvents(cs9, 0xAF0);
    // CALLF 0x1000:cecc (17C6_0AEB / 0x1874B)
    FarCall(cs9, 0xAF0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0xAF3);
    // MOV AX,word ptr [BP + 0xe] (17C6_0AF0 / 0x18750)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs9, 0xAF5);
    // MOV CL,0x5 (17C6_0AF3 / 0x18753)
    CL = 0x5;
    CheckExternalEvents(cs9, 0xAF7);
    // SHL AX,CL (17C6_0AF5 / 0x18755)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs9, 0xAF8);
    // CWD  (17C6_0AF7 / 0x18757)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs9, 0xAFB);
    // MOV word ptr [BP + -0x4],AX (17C6_0AF8 / 0x18758)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs9, 0xAFE);
    // MOV word ptr [BP + -0x2],DX (17C6_0AFB / 0x1875B)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs9, 0xAFF);
    // PUSH DX (17C6_0AFE / 0x1875E)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0xB00);
    // PUSH AX (17C6_0AFF / 0x1875F)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xB05);
    // CALLF 0x1000:908c (17C6_0B00 / 0x18760)
    FarCall(cs9, 0xB05, unknown_18AD_05BC_1908C);
    CheckExternalEvents(cs9, 0xB08);
    // ADD SP,0x4 (17C6_0B05 / 0x18765)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs9, 0xB0B);
    // MOV word ptr [BP + -0xa],AX (17C6_0B08 / 0x18768)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs9, 0xB0E);
    // MOV word ptr [BP + -0x8],DX (17C6_0B0B / 0x1876B)
    UInt16[SS, (ushort)(BP - 0x8)] = DX;
    CheckExternalEvents(cs9, 0xB11);
    // MOV word ptr [BP + -0xe],AX (17C6_0B0E / 0x1876E)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs9, 0xB14);
    // MOV word ptr [BP + -0xc],DX (17C6_0B11 / 0x18771)
    UInt16[SS, (ushort)(BP - 0xC)] = DX;
    CheckExternalEvents(cs9, 0xB19);
    // MOV word ptr [BP + -0x6],0x0 (17C6_0B14 / 0x18774)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs9, 0xB1B);
    // JMP 0x1000:87ac (17C6_0B19 / 0x18779)
    goto label_17C6_0B4C_187AC;
    label_17C6_0B1B_1877B:
    CheckExternalEvents(cs9, 0xB1E);
    // PUSH word ptr [BP + 0xc] (17C6_0B1B / 0x1877B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs9, 0xB21);
    // PUSH word ptr [BP + 0xa] (17C6_0B1E / 0x1877E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs9, 0xB24);
    // PUSH word ptr [BP + -0x8] (17C6_0B21 / 0x18781)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs9, 0xB27);
    // PUSH word ptr [BP + -0xa] (17C6_0B24 / 0x18784)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs9, 0xB2A);
    // PUSH word ptr [BP + 0x8] (17C6_0B27 / 0x18787)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs9, 0xB2D);
    // PUSH word ptr [BP + 0x6] (17C6_0B2A / 0x1878A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs9, 0xB2E);
    // PUSH CS (17C6_0B2D / 0x1878D)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0xB31);
    // CALL 0x1000:869b (17C6_0B2E / 0x1878E)
    NearCall(cs9, 0xB31, unknown_17C6_0A3B_1869B);
    CheckExternalEvents(cs9, 0xB34);
    // ADD SP,0xc (17C6_0B31 / 0x18791)
    SP += 0xC;
    CheckExternalEvents(cs9, 0xB37);
    // INC word ptr [BP + 0xa] (17C6_0B34 / 0x18794)
    UInt16[SS, (ushort)(BP + 0xA)]++;
    CheckExternalEvents(cs9, 0xB3B);
    // CMP word ptr [BP + 0xa],0x27 (17C6_0B37 / 0x18797)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x27);
    CheckExternalEvents(cs9, 0xB3D);
    // JLE 0x1000:87a5 (17C6_0B3B / 0x1879B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_17C6_0B45_187A5;
    }
    CheckExternalEvents(cs9, 0xB42);
    // MOV word ptr [BP + 0xa],0x0 (17C6_0B3D / 0x1879D)
    UInt16[SS, (ushort)(BP + 0xA)] = 0x0;
    CheckExternalEvents(cs9, 0xB45);
    // INC word ptr [BP + 0xc] (17C6_0B42 / 0x187A2)
    UInt16[SS, (ushort)(BP + 0xC)]++;
    label_17C6_0B45_187A5:
    CheckExternalEvents(cs9, 0xB49);
    // ADD word ptr [BP + -0xa],0x20 (17C6_0B45 / 0x187A5)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x20;
    CheckExternalEvents(cs9, 0xB4C);
    // INC word ptr [BP + -0x6] (17C6_0B49 / 0x187A9)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x6)]);
    label_17C6_0B4C_187AC:
    CheckExternalEvents(cs9, 0xB4F);
    // MOV AX,word ptr [BP + 0xe] (17C6_0B4C / 0x187AC)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs9, 0xB52);
    // CMP word ptr [BP + -0x6],AX (17C6_0B4F / 0x187AF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], AX);
    CheckExternalEvents(cs9, 0xB54);
    // JL 0x1000:877b (17C6_0B52 / 0x187B2)
    if(SignFlag != OverflowFlag) {
      goto label_17C6_0B1B_1877B;
    }
    CheckExternalEvents(cs9, 0xB57);
    // MOV AX,word ptr [BP + -0xe] (17C6_0B54 / 0x187B4)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs9, 0xB5A);
    // MOV DX,word ptr [BP + -0xc] (17C6_0B57 / 0x187B7)
    DX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs9, 0xB5C);
    // MOV SP,BP (17C6_0B5A / 0x187BA)
    SP = BP;
    CheckExternalEvents(cs9, 0xB5D);
    // POP BP (17C6_0B5C / 0x187BC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0xB5E);
    // RETF  (17C6_0B5D / 0x187BD)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_0B5E_187BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_0B5E_187BE:
    CheckExternalEvents(cs9, 0xB5F);
    // PUSH BP (17C6_0B5E / 0x187BE)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0xB61);
    // MOV BP,SP (17C6_0B5F / 0x187BF)
    BP = SP;
    CheckExternalEvents(cs9, 0xB64);
    // MOV AX,0xc (17C6_0B61 / 0x187C1)
    AX = 0xC;
    CheckExternalEvents(cs9, 0xB69);
    // CALLF 0x1000:cecc (17C6_0B64 / 0x187C4)
    FarCall(cs9, 0xB69, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0xB6A);
    // PUSH SI (17C6_0B69 / 0x187C9)
    Stack.Push16(SI);
    CheckExternalEvents(cs9, 0xB6D);
    // MOV SI,word ptr [BP + 0x6] (17C6_0B6A / 0x187CA)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xB6F);
    // MOV CL,0x4 (17C6_0B6D / 0x187CD)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xB71);
    // SHL SI,CL (17C6_0B6F / 0x187CF)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs9, 0xB75);
    // MOV ES,word ptr [0x56de] (17C6_0B71 / 0x187D1)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xB7A);
    // MOV AX,word ptr ES:[SI + 0x92] (17C6_0B75 / 0x187D5)
    AX = UInt16[ES, (ushort)(SI + 0x92)];
    CheckExternalEvents(cs9, 0xB7E);
    // MOV ES,word ptr [0x56d2] (17C6_0B7A / 0x187DA)
    ES = UInt16[DS, 0x56D2];
    CheckExternalEvents(cs9, 0xB83);
    // ADD AX,word ptr ES:[0x39a4] (17C6_0B7E / 0x187DE)
    // AX += UInt16[ES, 0x39A4];
    AX = Alu16.Add(AX, UInt16[ES, 0x39A4]);
    CheckExternalEvents(cs9, 0xB86);
    // MOV word ptr [BP + -0xa],AX (17C6_0B83 / 0x187E3)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs9, 0xB8B);
    // MOV word ptr [BP + -0x2],0x1 (17C6_0B86 / 0x187E6)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs9, 0xB8F);
    // MOV ES,word ptr [0x56de] (17C6_0B8B / 0x187EB)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xB94);
    // MOV AX,word ptr ES:[SI + 0x96] (17C6_0B8F / 0x187EF)
    AX = UInt16[ES, (ushort)(SI + 0x96)];
    CheckExternalEvents(cs9, 0xB99);
    // CMP word ptr ES:[SI + 0x98],AX (17C6_0B94 / 0x187F4)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x98)], AX);
    CheckExternalEvents(cs9, 0xB9B);
    // JL 0x1000:8802 (17C6_0B99 / 0x187F9)
    if(SignFlag != OverflowFlag) {
      goto label_17C6_0BA2_18802;
    }
    CheckExternalEvents(cs9, 0xBA2);
    // MOV word ptr ES:[SI + 0x98],0x0 (17C6_0B9B / 0x187FB)
    UInt16[ES, (ushort)(SI + 0x98)] = 0x0;
    label_17C6_0BA2_18802:
    CheckExternalEvents(cs9, 0xBA6);
    // MOV ES,word ptr [0x56e8] (17C6_0BA2 / 0x18802)
    ES = UInt16[DS, 0x56E8];
    CheckExternalEvents(cs9, 0xBAC);
    // CMP word ptr ES:[0x3938],0x0 (17C6_0BA6 / 0x18806)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs9, 0xBAE);
    // JNZ 0x1000:881a (17C6_0BAC / 0x1880C)
    if(!ZeroFlag) {
      goto label_17C6_0BBA_1881A;
    }
    CheckExternalEvents(cs9, 0xBB2);
    // MOV ES,word ptr [0x56ea] (17C6_0BAE / 0x1880E)
    ES = UInt16[DS, 0x56EA];
    CheckExternalEvents(cs9, 0xBB8);
    // CMP word ptr ES:[0x458c],0x0 (17C6_0BB2 / 0x18812)
    Alu16.Sub(UInt16[ES, 0x458C], 0x0);
    CheckExternalEvents(cs9, 0xBBA);
    // JZ 0x1000:882c (17C6_0BB8 / 0x18818)
    if(ZeroFlag) {
      goto label_17C6_0BCC_1882C;
    }
    label_17C6_0BBA_1881A:
    CheckExternalEvents(cs9, 0xBBD);
    // MOV BX,word ptr [BP + 0x6] (17C6_0BBA / 0x1881A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xBBF);
    // MOV CL,0x4 (17C6_0BBD / 0x1881D)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xBC1);
    // SHL BX,CL (17C6_0BBF / 0x1881F)
    // BX <<= CL;
    BX = Alu16.Shl(BX, CL);
    CheckExternalEvents(cs9, 0xBC5);
    // MOV ES,word ptr [0x56de] (17C6_0BC1 / 0x18821)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xBCC);
    // MOV word ptr ES:[BX + 0x98],0x0 (17C6_0BC5 / 0x18825)
    UInt16[ES, (ushort)(BX + 0x98)] = 0x0;
    label_17C6_0BCC_1882C:
    CheckExternalEvents(cs9, 0xBCF);
    // MOV SI,word ptr [BP + 0x6] (17C6_0BCC / 0x1882C)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xBD1);
    // MOV CL,0x4 (17C6_0BCF / 0x1882F)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xBD3);
    // SHL SI,CL (17C6_0BD1 / 0x18831)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs9, 0xBD7);
    // MOV ES,word ptr [0x56de] (17C6_0BD3 / 0x18833)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xBDC);
    // MOV AX,word ptr ES:[SI + 0x98] (17C6_0BD7 / 0x18837)
    AX = UInt16[ES, (ushort)(SI + 0x98)];
    CheckExternalEvents(cs9, 0xBDF);
    // MOV word ptr [BP + -0xc],AX (17C6_0BDC / 0x1883C)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs9, 0xBE2);
    // MOV word ptr [BP + -0x4],AX (17C6_0BDF / 0x1883F)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs9, 0xBE6);
    // MOV ES,word ptr [0x56ec] (17C6_0BE2 / 0x18842)
    ES = UInt16[DS, 0x56EC];
    CheckExternalEvents(cs9, 0xBED);
    // MOV word ptr ES:[0xb782],0x0 (17C6_0BE6 / 0x18846)
    UInt16[ES, 0xB782] = 0x0;
    CheckExternalEvents(cs9, 0xBF1);
    // MOV ES,word ptr [0x56de] (17C6_0BED / 0x1884D)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xBF6);
    // PUSH word ptr ES:[SI + 0x9c] (17C6_0BF1 / 0x18851)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x9C)]);
    CheckExternalEvents(cs9, 0xBFB);
    // PUSH word ptr ES:[SI + 0x94] (17C6_0BF6 / 0x18856)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x94)]);
    CheckExternalEvents(cs9, 0xBFE);
    // MOV AX,word ptr [BP + -0xa] (17C6_0BFB / 0x1885B)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs9, 0xC01);
    // ADD AX,word ptr [BP + -0xc] (17C6_0BFE / 0x1885E)
    // AX += UInt16[SS, (ushort)(BP - 0xC)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs9, 0xC02);
    // PUSH AX (17C6_0C01 / 0x18861)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xC06);
    // MOV ES,word ptr [0x56d0] (17C6_0C02 / 0x18862)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0xC0B);
    // PUSH word ptr ES:[0x39a0] (17C6_0C06 / 0x18866)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0xC10);
    // CALLF 0x1000:ca77 (17C6_0C0B / 0x1886B)
    FarCall(cs9, 0xC10, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs9, 0xC13);
    // ADD SP,0x8 (17C6_0C10 / 0x18870)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs9, 0xC18);
    // CALLF 0x0000:412b (17C6_0C13 / 0x18873)
    FarCall(cs9, 0xC18, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs9, 0xC1B);
    // JMP 0x1000:894b (17C6_0C18 / 0x18878)
    goto label_17C6_0CEB_1894B;
    label_17C6_0C1B_1887B:
    CheckExternalEvents(cs9, 0xC20);
    // CALLF 0x1000:8d29 (17C6_0C1B / 0x1887B)
    FarCall(cs9, 0xC20, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs9, 0xC23);
    // MOV word ptr [BP + -0x8],AX (17C6_0C20 / 0x18880)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs9, 0xC24);
    // PUSH AX (17C6_0C23 / 0x18883)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xC25);
    // PUSH CS (17C6_0C24 / 0x18884)
    Stack.Push16(cs9);
    CheckExternalEvents(cs9, 0xC28);
    // CALL 0x1000:897d (17C6_0C25 / 0x18885)
    NearCall(cs9, 0xC28, unknown_17C6_0D1D_1897D);
    CheckExternalEvents(cs9, 0xC2B);
    // ADD SP,0x2 (17C6_0C28 / 0x18888)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0xC2E);
    // MOV word ptr [BP + -0x8],AX (17C6_0C2B / 0x1888B)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs9, 0xC31);
    // CMP AX,0xd (17C6_0C2E / 0x1888E)
    Alu16.Sub(AX, 0xD);
    CheckExternalEvents(cs9, 0xC33);
    // JZ 0x1000:8898 (17C6_0C31 / 0x18891)
    if(ZeroFlag) {
      goto label_17C6_0C38_18898;
    }
    CheckExternalEvents(cs9, 0xC36);
    // CMP AX,0x20 (17C6_0C33 / 0x18893)
    Alu16.Sub(AX, 0x20);
    CheckExternalEvents(cs9, 0xC38);
    // JNZ 0x1000:88a0 (17C6_0C36 / 0x18896)
    if(!ZeroFlag) {
      goto label_17C6_0C40_188A0;
    }
    label_17C6_0C38_18898:
    CheckExternalEvents(cs9, 0xC3D);
    // MOV word ptr [BP + -0x2],0x0 (17C6_0C38 / 0x18898)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs9, 0xC40);
    // JMP 0x1000:894b (17C6_0C3D / 0x1889D)
    goto label_17C6_0CEB_1894B;
    label_17C6_0C40_188A0:
    CheckExternalEvents(cs9, 0xC44);
    // CMP word ptr [BP + -0x8],-0x48 (17C6_0C40 / 0x188A0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xFFB8);
    CheckExternalEvents(cs9, 0xC46);
    // JZ 0x1000:88af (17C6_0C44 / 0x188A4)
    if(ZeroFlag) {
      goto label_17C6_0C4F_188AF;
    }
    CheckExternalEvents(cs9, 0xC4A);
    // CMP word ptr [BP + -0x8],-0x50 (17C6_0C46 / 0x188A6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xFFB0);
    CheckExternalEvents(cs9, 0xC4C);
    // JZ 0x1000:88af (17C6_0C4A / 0x188AA)
    if(ZeroFlag) {
      goto label_17C6_0C4F_188AF;
    }
    CheckExternalEvents(cs9, 0xC4F);
    // JMP 0x1000:894b (17C6_0C4C / 0x188AC)
    goto label_17C6_0CEB_1894B;
    label_17C6_0C4F_188AF:
    CheckExternalEvents(cs9, 0xC52);
    // MOV SI,word ptr [BP + 0x6] (17C6_0C4F / 0x188AF)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xC54);
    // MOV CL,0x4 (17C6_0C52 / 0x188B2)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xC56);
    // SHL SI,CL (17C6_0C54 / 0x188B4)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs9, 0xC5A);
    // MOV ES,word ptr [0x56de] (17C6_0C56 / 0x188B6)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xC5F);
    // PUSH word ptr ES:[SI + 0x9c] (17C6_0C5A / 0x188BA)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x9C)]);
    CheckExternalEvents(cs9, 0xC64);
    // PUSH word ptr ES:[SI + 0x94] (17C6_0C5F / 0x188BF)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x94)]);
    CheckExternalEvents(cs9, 0xC67);
    // MOV AX,word ptr [BP + -0xa] (17C6_0C64 / 0x188C4)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs9, 0xC6A);
    // ADD AX,word ptr [BP + -0xc] (17C6_0C67 / 0x188C7)
    // AX += UInt16[SS, (ushort)(BP - 0xC)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs9, 0xC6B);
    // PUSH AX (17C6_0C6A / 0x188CA)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xC6F);
    // MOV ES,word ptr [0x56d0] (17C6_0C6B / 0x188CB)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0xC74);
    // PUSH word ptr ES:[0x39a0] (17C6_0C6F / 0x188CF)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0xC79);
    // CALLF 0x1000:ca77 (17C6_0C74 / 0x188D4)
    FarCall(cs9, 0xC79, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs9, 0xC7C);
    // ADD SP,0x8 (17C6_0C79 / 0x188D9)
    SP += 0x8;
    CheckExternalEvents(cs9, 0xC80);
    // CMP word ptr [BP + -0x8],-0x48 (17C6_0C7C / 0x188DC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xFFB8);
    CheckExternalEvents(cs9, 0xC82);
    // JNZ 0x1000:88e5 (17C6_0C80 / 0x188E0)
    if(!ZeroFlag) {
      goto label_17C6_0C85_188E5;
    }
    CheckExternalEvents(cs9, 0xC85);
    // DEC word ptr [BP + -0xc] (17C6_0C82 / 0x188E2)
    UInt16[SS, (ushort)(BP - 0xC)]--;
    label_17C6_0C85_188E5:
    CheckExternalEvents(cs9, 0xC89);
    // CMP word ptr [BP + -0x8],-0x50 (17C6_0C85 / 0x188E5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xFFB0);
    CheckExternalEvents(cs9, 0xC8B);
    // JNZ 0x1000:88ee (17C6_0C89 / 0x188E9)
    if(!ZeroFlag) {
      goto label_17C6_0C8E_188EE;
    }
    CheckExternalEvents(cs9, 0xC8E);
    // INC word ptr [BP + -0xc] (17C6_0C8B / 0x188EB)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_17C6_0C8E_188EE:
    CheckExternalEvents(cs9, 0xC92);
    // CMP word ptr [BP + -0xc],0x0 (17C6_0C8E / 0x188EE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs9, 0xC94);
    // JGE 0x1000:8908 (17C6_0C92 / 0x188F2)
    if(SignFlag == OverflowFlag) {
      goto label_17C6_0CA8_18908;
    }
    CheckExternalEvents(cs9, 0xC97);
    // MOV BX,word ptr [BP + 0x6] (17C6_0C94 / 0x188F4)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xC99);
    // MOV CL,0x4 (17C6_0C97 / 0x188F7)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xC9B);
    // SHL BX,CL (17C6_0C99 / 0x188F9)
    // BX <<= CL;
    BX = Alu16.Shl(BX, CL);
    CheckExternalEvents(cs9, 0xC9F);
    // MOV ES,word ptr [0x56de] (17C6_0C9B / 0x188FB)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xCA4);
    // MOV AX,word ptr ES:[BX + 0x96] (17C6_0C9F / 0x188FF)
    AX = UInt16[ES, (ushort)(BX + 0x96)];
    CheckExternalEvents(cs9, 0xCA5);
    // DEC AX (17C6_0CA4 / 0x18904)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs9, 0xCA8);
    // MOV word ptr [BP + -0xc],AX (17C6_0CA5 / 0x18905)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    label_17C6_0CA8_18908:
    CheckExternalEvents(cs9, 0xCAB);
    // MOV AX,word ptr [BP + -0xc] (17C6_0CA8 / 0x18908)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs9, 0xCAE);
    // MOV BX,word ptr [BP + 0x6] (17C6_0CAB / 0x1890B)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xCB0);
    // MOV CL,0x4 (17C6_0CAE / 0x1890E)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xCB2);
    // SHL BX,CL (17C6_0CB0 / 0x18910)
    // BX <<= CL;
    BX = Alu16.Shl(BX, CL);
    CheckExternalEvents(cs9, 0xCB6);
    // MOV ES,word ptr [0x56de] (17C6_0CB2 / 0x18912)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xCBB);
    // CMP word ptr ES:[BX + 0x96],AX (17C6_0CB6 / 0x18916)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x96)], AX);
    CheckExternalEvents(cs9, 0xCBD);
    // JG 0x1000:8922 (17C6_0CBB / 0x1891B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0CC2_18922;
    }
    CheckExternalEvents(cs9, 0xCC2);
    // MOV word ptr [BP + -0xc],0x0 (17C6_0CBD / 0x1891D)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_17C6_0CC2_18922:
    CheckExternalEvents(cs9, 0xCC5);
    // MOV SI,word ptr [BP + 0x6] (17C6_0CC2 / 0x18922)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xCC7);
    // MOV CL,0x4 (17C6_0CC5 / 0x18925)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xCC9);
    // SHL SI,CL (17C6_0CC7 / 0x18927)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs9, 0xCCE);
    // PUSH word ptr ES:[SI + 0x9c] (17C6_0CC9 / 0x18929)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x9C)]);
    CheckExternalEvents(cs9, 0xCD3);
    // PUSH word ptr ES:[SI + 0x94] (17C6_0CCE / 0x1892E)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x94)]);
    CheckExternalEvents(cs9, 0xCD6);
    // MOV AX,word ptr [BP + -0xa] (17C6_0CD3 / 0x18933)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs9, 0xCD9);
    // ADD AX,word ptr [BP + -0xc] (17C6_0CD6 / 0x18936)
    // AX += UInt16[SS, (ushort)(BP - 0xC)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs9, 0xCDA);
    // PUSH AX (17C6_0CD9 / 0x18939)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xCDE);
    // MOV ES,word ptr [0x56d0] (17C6_0CDA / 0x1893A)
    ES = UInt16[DS, 0x56D0];
    CheckExternalEvents(cs9, 0xCE3);
    // PUSH word ptr ES:[0x39a0] (17C6_0CDE / 0x1893E)
    Stack.Push16(UInt16[ES, 0x39A0]);
    CheckExternalEvents(cs9, 0xCE8);
    // CALLF 0x1000:ca77 (17C6_0CE3 / 0x18943)
    FarCall(cs9, 0xCE8, unknown_19EF_2B87_1CA77);
    CheckExternalEvents(cs9, 0xCEB);
    // ADD SP,0x8 (17C6_0CE8 / 0x18948)
    SP += 0x8;
    label_17C6_0CEB_1894B:
    CheckExternalEvents(cs9, 0xCEF);
    // CMP word ptr [BP + -0x2],0x0 (17C6_0CEB / 0x1894B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs9, 0xCF1);
    // JZ 0x1000:8954 (17C6_0CEF / 0x1894F)
    if(ZeroFlag) {
      goto label_17C6_0CF4_18954;
    }
    CheckExternalEvents(cs9, 0xCF4);
    // JMP 0x1000:887b (17C6_0CF1 / 0x18951)
    goto label_17C6_0C1B_1887B;
    label_17C6_0CF4_18954:
    CheckExternalEvents(cs9, 0xCF8);
    // CMP word ptr [BP + -0x8],0x1b (17C6_0CF4 / 0x18954)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x1B);
    CheckExternalEvents(cs9, 0xCFA);
    // JZ 0x1000:896f (17C6_0CF8 / 0x18958)
    if(ZeroFlag) {
      goto label_17C6_0D0F_1896F;
    }
    CheckExternalEvents(cs9, 0xCFD);
    // MOV AX,word ptr [BP + -0xc] (17C6_0CFA / 0x1895A)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs9, 0xD00);
    // MOV BX,word ptr [BP + 0x6] (17C6_0CFD / 0x1895D)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xD02);
    // MOV CL,0x4 (17C6_0D00 / 0x18960)
    CL = 0x4;
    CheckExternalEvents(cs9, 0xD04);
    // SHL BX,CL (17C6_0D02 / 0x18962)
    // BX <<= CL;
    BX = Alu16.Shl(BX, CL);
    CheckExternalEvents(cs9, 0xD08);
    // MOV ES,word ptr [0x56de] (17C6_0D04 / 0x18964)
    ES = UInt16[DS, 0x56DE];
    CheckExternalEvents(cs9, 0xD0D);
    // MOV word ptr ES:[BX + 0x98],AX (17C6_0D08 / 0x18968)
    UInt16[ES, (ushort)(BX + 0x98)] = AX;
    CheckExternalEvents(cs9, 0xD0F);
    // JMP 0x1000:8975 (17C6_0D0D / 0x1896D)
    goto label_17C6_0D15_18975;
    label_17C6_0D0F_1896F:
    CheckExternalEvents(cs9, 0xD12);
    // MOV AX,word ptr [BP + -0x4] (17C6_0D0F / 0x1896F)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs9, 0xD15);
    // MOV word ptr [BP + -0xc],AX (17C6_0D12 / 0x18972)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    label_17C6_0D15_18975:
    CheckExternalEvents(cs9, 0xD18);
    // MOV AX,word ptr [BP + -0xc] (17C6_0D15 / 0x18975)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs9, 0xD19);
    // POP SI (17C6_0D18 / 0x18978)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs9, 0xD1B);
    // MOV SP,BP (17C6_0D19 / 0x18979)
    SP = BP;
    CheckExternalEvents(cs9, 0xD1C);
    // POP BP (17C6_0D1B / 0x1897B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs9, 0xD1D);
    // RETF  (17C6_0D1C / 0x1897C)
    return FarRet();
  }
  
  public virtual Action unknown_17C6_0D1D_1897D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_17C6_0D1D_1897D:
    CheckExternalEvents(cs9, 0xD1E);
    // PUSH BP (17C6_0D1D / 0x1897D)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0xD20);
    // MOV BP,SP (17C6_0D1E / 0x1897E)
    BP = SP;
    CheckExternalEvents(cs9, 0xD22);
    // XOR AX,AX (17C6_0D20 / 0x18980)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs9, 0xD27);
    // CALLF 0x1000:cecc (17C6_0D22 / 0x18982)
    FarCall(cs9, 0xD27, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0xD2A);
    // MOV AX,word ptr [BP + 0x6] (17C6_0D27 / 0x18987)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0xD2D);
    // CMP AX,0x41 (17C6_0D2A / 0x1898A)
    Alu16.Sub(AX, 0x41);
    CheckExternalEvents(cs9, 0xD2F);
    // JZ 0x1000:89c9 (17C6_0D2D / 0x1898D)
    if(ZeroFlag) {
      goto label_17C6_0D69_189C9;
    }
    CheckExternalEvents(cs9, 0xD31);
    // JLE 0x1000:8994 (17C6_0D2F / 0x1898F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_17C6_0D34_18994;
    }
    CheckExternalEvents(cs9, 0xD34);
    // JMP 0x1000:8a3d (17C6_0D31 / 0x18991)
    goto label_17C6_0DDD_18A3D;
    label_17C6_0D34_18994:
    CheckExternalEvents(cs9, 0xD37);
    // CMP AX,0xffb9 (17C6_0D34 / 0x18994)
    Alu16.Sub(AX, 0xFFB9);
    CheckExternalEvents(cs9, 0xD39);
    // JZ 0x1000:89d9 (17C6_0D37 / 0x18997)
    if(ZeroFlag) {
      goto label_17C6_0D79_189D9;
    }
    CheckExternalEvents(cs9, 0xD3B);
    // JG 0x1000:8a08 (17C6_0D39 / 0x18999)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0DA8_18A08;
    }
    CheckExternalEvents(cs9, 0xD3E);
    // CMP AX,0xffb1 (17C6_0D3B / 0x1899B)
    Alu16.Sub(AX, 0xFFB1);
    CheckExternalEvents(cs9, 0xD40);
    // JZ 0x1000:89b1 (17C6_0D3E / 0x1899E)
    if(ZeroFlag) {
      goto label_17C6_0D51_189B1;
    }
    CheckExternalEvents(cs9, 0xD42);
    // JG 0x1000:89f1 (17C6_0D40 / 0x189A0)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0D91_189F1;
    }
    CheckExternalEvents(cs9, 0xD45);
    // CMP AX,0xff0c (17C6_0D42 / 0x189A2)
    Alu16.Sub(AX, 0xFF0C);
    CheckExternalEvents(cs9, 0xD47);
    // JZ 0x1000:89d1 (17C6_0D45 / 0x189A5)
    if(ZeroFlag) {
      goto label_17C6_0D71_189D1;
    }
    CheckExternalEvents(cs9, 0xD4A);
    // CMP AX,0xffaf (17C6_0D47 / 0x189A7)
    Alu16.Sub(AX, 0xFFAF);
    CheckExternalEvents(cs9, 0xD4C);
    // JZ 0x1000:89c1 (17C6_0D4A / 0x189AA)
    if(ZeroFlag) {
      goto label_17C6_0D61_189C1;
    }
    CheckExternalEvents(cs9, 0xD4F);
    // CMP AX,0xffb0 (17C6_0D4C / 0x189AC)
    Alu16.Sub(AX, 0xFFB0);
    CheckExternalEvents(cs9, 0xD51);
    // JMP 0x1000:8a1c (17C6_0D4F / 0x189AF)
    goto label_17C6_0DBC_18A1C;
    label_17C6_0D51_189B1:
    CheckExternalEvents(cs9, 0xD56);
    // MOV word ptr [BP + 0x6],0xffb1 (17C6_0D51 / 0x189B1)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB1;
    CheckExternalEvents(cs9, 0xD59);
    // JMP 0x1000:8ad1 (17C6_0D56 / 0x189B6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D59_189B9:
    CheckExternalEvents(cs9, 0xD5E);
    // MOV word ptr [BP + 0x6],0xffb0 (17C6_0D59 / 0x189B9)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB0;
    CheckExternalEvents(cs9, 0xD61);
    // JMP 0x1000:8ad1 (17C6_0D5E / 0x189BE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D61_189C1:
    CheckExternalEvents(cs9, 0xD66);
    // MOV word ptr [BP + 0x6],0xffaf (17C6_0D61 / 0x189C1)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFAF;
    CheckExternalEvents(cs9, 0xD69);
    // JMP 0x1000:8ad1 (17C6_0D66 / 0x189C6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D69_189C9:
    CheckExternalEvents(cs9, 0xD6E);
    // MOV word ptr [BP + 0x6],0xffb5 (17C6_0D69 / 0x189C9)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB5;
    CheckExternalEvents(cs9, 0xD71);
    // JMP 0x1000:8ad1 (17C6_0D6E / 0x189CE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D71_189D1:
    CheckExternalEvents(cs9, 0xD76);
    // MOV word ptr [BP + 0x6],0xffb3 (17C6_0D71 / 0x189D1)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB3;
    CheckExternalEvents(cs9, 0xD79);
    // JMP 0x1000:8ad1 (17C6_0D76 / 0x189D6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D79_189D9:
    CheckExternalEvents(cs9, 0xD7E);
    // MOV word ptr [BP + 0x6],0xffb9 (17C6_0D79 / 0x189D9)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB9;
    CheckExternalEvents(cs9, 0xD81);
    // JMP 0x1000:8ad1 (17C6_0D7E / 0x189DE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D81_189E1:
    CheckExternalEvents(cs9, 0xD86);
    // MOV word ptr [BP + 0x6],0xffb8 (17C6_0D81 / 0x189E1)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB8;
    CheckExternalEvents(cs9, 0xD89);
    // JMP 0x1000:8ad1 (17C6_0D86 / 0x189E6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D89_189E9:
    CheckExternalEvents(cs9, 0xD8E);
    // MOV word ptr [BP + 0x6],0xffb7 (17C6_0D89 / 0x189E9)
    UInt16[SS, (ushort)(BP + 0x6)] = 0xFFB7;
    CheckExternalEvents(cs9, 0xD91);
    // JMP 0x1000:8ad1 (17C6_0D8E / 0x189EE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0D91_189F1:
    CheckExternalEvents(cs9, 0xD94);
    // CMP AX,0xffb3 (17C6_0D91 / 0x189F1)
    Alu16.Sub(AX, 0xFFB3);
    CheckExternalEvents(cs9, 0xD96);
    // JZ 0x1000:89d1 (17C6_0D94 / 0x189F4)
    if(ZeroFlag) {
      goto label_17C6_0D71_189D1;
    }
    CheckExternalEvents(cs9, 0xD99);
    // CMP AX,0xffb5 (17C6_0D96 / 0x189F6)
    Alu16.Sub(AX, 0xFFB5);
    CheckExternalEvents(cs9, 0xD9B);
    // JZ 0x1000:89c9 (17C6_0D99 / 0x189F9)
    if(ZeroFlag) {
      goto label_17C6_0D69_189C9;
    }
    CheckExternalEvents(cs9, 0xD9E);
    // CMP AX,0xffb7 (17C6_0D9B / 0x189FB)
    Alu16.Sub(AX, 0xFFB7);
    CheckExternalEvents(cs9, 0xDA0);
    // JZ 0x1000:89e9 (17C6_0D9E / 0x189FE)
    if(ZeroFlag) {
      goto label_17C6_0D89_189E9;
    }
    CheckExternalEvents(cs9, 0xDA3);
    // CMP AX,0xffb8 (17C6_0DA0 / 0x18A00)
    Alu16.Sub(AX, 0xFFB8);
    CheckExternalEvents(cs9, 0xDA5);
    // JZ 0x1000:89e1 (17C6_0DA3 / 0x18A03)
    if(ZeroFlag) {
      goto label_17C6_0D81_189E1;
    }
    CheckExternalEvents(cs9, 0xDA8);
    // JMP 0x1000:8ad1 (17C6_0DA5 / 0x18A05)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0DA8_18A08:
    CheckExternalEvents(cs9, 0xDAB);
    // CMP AX,0x33 (17C6_0DA8 / 0x18A08)
    Alu16.Sub(AX, 0x33);
    CheckExternalEvents(cs9, 0xDAD);
    // JZ 0x1000:89c1 (17C6_0DAB / 0x18A0B)
    if(ZeroFlag) {
      goto label_17C6_0D61_189C1;
    }
    CheckExternalEvents(cs9, 0xDAF);
    // JG 0x1000:8a21 (17C6_0DAD / 0x18A0D)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0DC1_18A21;
    }
    CheckExternalEvents(cs9, 0xDB2);
    // CMP AX,0xc (17C6_0DAF / 0x18A0F)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs9, 0xDB4);
    // JZ 0x1000:89d1 (17C6_0DB2 / 0x18A12)
    if(ZeroFlag) {
      goto label_17C6_0D71_189D1;
    }
    CheckExternalEvents(cs9, 0xDB7);
    // CMP AX,0x31 (17C6_0DB4 / 0x18A14)
    Alu16.Sub(AX, 0x31);
    CheckExternalEvents(cs9, 0xDB9);
    // JZ 0x1000:89b1 (17C6_0DB7 / 0x18A17)
    if(ZeroFlag) {
      goto label_17C6_0D51_189B1;
    }
    CheckExternalEvents(cs9, 0xDBC);
    // CMP AX,0x32 (17C6_0DB9 / 0x18A19)
    Alu16.Sub(AX, 0x32);
    label_17C6_0DBC_18A1C:
    CheckExternalEvents(cs9, 0xDBE);
    // JZ 0x1000:89b9 (17C6_0DBC / 0x18A1C)
    if(ZeroFlag) {
      goto label_17C6_0D59_189B9;
    }
    CheckExternalEvents(cs9, 0xDC1);
    // JMP 0x1000:8ad1 (17C6_0DBE / 0x18A1E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0DC1_18A21:
    CheckExternalEvents(cs9, 0xDC4);
    // CMP AX,0x34 (17C6_0DC1 / 0x18A21)
    Alu16.Sub(AX, 0x34);
    CheckExternalEvents(cs9, 0xDC6);
    // JZ 0x1000:89c9 (17C6_0DC4 / 0x18A24)
    if(ZeroFlag) {
      goto label_17C6_0D69_189C9;
    }
    CheckExternalEvents(cs9, 0xDC9);
    // CMP AX,0x36 (17C6_0DC6 / 0x18A26)
    Alu16.Sub(AX, 0x36);
    CheckExternalEvents(cs9, 0xDCB);
    // JZ 0x1000:89d1 (17C6_0DC9 / 0x18A29)
    if(ZeroFlag) {
      goto label_17C6_0D71_189D1;
    }
    CheckExternalEvents(cs9, 0xDCE);
    // CMP AX,0x37 (17C6_0DCB / 0x18A2B)
    Alu16.Sub(AX, 0x37);
    CheckExternalEvents(cs9, 0xDD0);
    // JZ 0x1000:89d9 (17C6_0DCE / 0x18A2E)
    if(ZeroFlag) {
      goto label_17C6_0D79_189D9;
    }
    CheckExternalEvents(cs9, 0xDD3);
    // CMP AX,0x38 (17C6_0DD0 / 0x18A30)
    Alu16.Sub(AX, 0x38);
    CheckExternalEvents(cs9, 0xDD5);
    // JZ 0x1000:89e1 (17C6_0DD3 / 0x18A33)
    if(ZeroFlag) {
      goto label_17C6_0D81_189E1;
    }
    CheckExternalEvents(cs9, 0xDD8);
    // CMP AX,0x39 (17C6_0DD5 / 0x18A35)
    Alu16.Sub(AX, 0x39);
    label_17C6_0DD8_18A38:
    CheckExternalEvents(cs9, 0xDDA);
    // JZ 0x1000:89e9 (17C6_0DD8 / 0x18A38)
    if(ZeroFlag) {
      goto label_17C6_0D89_189E9;
    }
    CheckExternalEvents(cs9, 0xDDD);
    // JMP 0x1000:8ad1 (17C6_0DDA / 0x18A3A)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0DDD_18A3D:
    CheckExternalEvents(cs9, 0xDE0);
    // CMP AX,0x60 (17C6_0DDD / 0x18A3D)
    Alu16.Sub(AX, 0x60);
    CheckExternalEvents(cs9, 0xDE2);
    // JNZ 0x1000:8a45 (17C6_0DE0 / 0x18A40)
    if(!ZeroFlag) {
      goto label_17C6_0DE5_18A45;
    }
    CheckExternalEvents(cs9, 0xDE5);
    // JMP 0x1000:89b9 (17C6_0DE2 / 0x18A42)
    goto label_17C6_0D59_189B9;
    label_17C6_0DE5_18A45:
    CheckExternalEvents(cs9, 0xDE7);
    // JG 0x1000:8a85 (17C6_0DE5 / 0x18A45)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0E25_18A85;
    }
    CheckExternalEvents(cs9, 0xDEA);
    // CMP AX,0x51 (17C6_0DE7 / 0x18A47)
    Alu16.Sub(AX, 0x51);
    CheckExternalEvents(cs9, 0xDEC);
    // JZ 0x1000:89d9 (17C6_0DEA / 0x18A4A)
    if(ZeroFlag) {
      goto label_17C6_0D79_189D9;
    }
    CheckExternalEvents(cs9, 0xDEE);
    // JG 0x1000:8a63 (17C6_0DEC / 0x18A4C)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_17C6_0E03_18A63;
    }
    CheckExternalEvents(cs9, 0xDF1);
    // CMP AX,0x43 (17C6_0DEE / 0x18A4E)
    Alu16.Sub(AX, 0x43);
    CheckExternalEvents(cs9, 0xDF3);
    // JNZ 0x1000:8a56 (17C6_0DF1 / 0x18A51)
    if(!ZeroFlag) {
      goto label_17C6_0DF6_18A56;
    }
    CheckExternalEvents(cs9, 0xDF6);
    // JMP 0x1000:89c1 (17C6_0DF3 / 0x18A53)
    goto label_17C6_0D61_189C1;
    label_17C6_0DF6_18A56:
    CheckExternalEvents(cs9, 0xDF9);
    // CMP AX,0x44 (17C6_0DF6 / 0x18A56)
    Alu16.Sub(AX, 0x44);
    CheckExternalEvents(cs9, 0xDFB);
    // JNZ 0x1000:8a5e (17C6_0DF9 / 0x18A59)
    if(!ZeroFlag) {
      goto label_17C6_0DFE_18A5E;
    }
    CheckExternalEvents(cs9, 0xDFE);
    // JMP 0x1000:89d1 (17C6_0DFB / 0x18A5B)
    goto label_17C6_0D71_189D1;
    label_17C6_0DFE_18A5E:
    CheckExternalEvents(cs9, 0xE01);
    // CMP AX,0x45 (17C6_0DFE / 0x18A5E)
    Alu16.Sub(AX, 0x45);
    CheckExternalEvents(cs9, 0xE03);
    // JMP 0x1000:8a38 (17C6_0E01 / 0x18A61)
    goto label_17C6_0DD8_18A38;
    label_17C6_0E03_18A63:
    CheckExternalEvents(cs9, 0xE06);
    // CMP AX,0x57 (17C6_0E03 / 0x18A63)
    Alu16.Sub(AX, 0x57);
    CheckExternalEvents(cs9, 0xE08);
    // JNZ 0x1000:8a6b (17C6_0E06 / 0x18A66)
    if(!ZeroFlag) {
      goto label_17C6_0E0B_18A6B;
    }
    CheckExternalEvents(cs9, 0xE0B);
    // JMP 0x1000:89e1 (17C6_0E08 / 0x18A68)
    goto label_17C6_0D81_189E1;
    label_17C6_0E0B_18A6B:
    CheckExternalEvents(cs9, 0xE0E);
    // CMP AX,0x58 (17C6_0E0B / 0x18A6B)
    Alu16.Sub(AX, 0x58);
    CheckExternalEvents(cs9, 0xE10);
    // JNZ 0x1000:8a73 (17C6_0E0E / 0x18A6E)
    if(!ZeroFlag) {
      goto label_17C6_0E13_18A73;
    }
    CheckExternalEvents(cs9, 0xE13);
    // JMP 0x1000:89b9 (17C6_0E10 / 0x18A70)
    goto label_17C6_0D59_189B9;
    label_17C6_0E13_18A73:
    CheckExternalEvents(cs9, 0xE16);
    // CMP AX,0x5a (17C6_0E13 / 0x18A73)
    Alu16.Sub(AX, 0x5A);
    CheckExternalEvents(cs9, 0xE18);
    // JNZ 0x1000:8a7b (17C6_0E16 / 0x18A76)
    if(!ZeroFlag) {
      goto label_17C6_0E1B_18A7B;
    }
    CheckExternalEvents(cs9, 0xE1B);
    // JMP 0x1000:89b1 (17C6_0E18 / 0x18A78)
    goto label_17C6_0D51_189B1;
    label_17C6_0E1B_18A7B:
    CheckExternalEvents(cs9, 0xE1E);
    // CMP AX,0x5c (17C6_0E1B / 0x18A7B)
    Alu16.Sub(AX, 0x5C);
    CheckExternalEvents(cs9, 0xE20);
    // JNZ 0x1000:8a83 (17C6_0E1E / 0x18A7E)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      CheckExternalEvents(cs9, 0xE25);
      // JMP 0x1000:8ad1 (17C6_0E23 / 0x18A83)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs9, 0xE23);
    // JMP 0x1000:89d9 (17C6_0E20 / 0x18A80)
    goto label_17C6_0D79_189D9;
    label_17C6_0E23_18A83:
    CheckExternalEvents(cs9, 0xE25);
    // JMP 0x1000:8ad1 (17C6_0E23 / 0x18A83)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_17C6_0E25_18A85:
    CheckExternalEvents(cs9, 0xE28);
    // SUB AX,0x61 (17C6_0E25 / 0x18A85)
    AX -= 0x61;
    CheckExternalEvents(cs9, 0xE2B);
    // CMP AX,0x1d (17C6_0E28 / 0x18A88)
    Alu16.Sub(AX, 0x1D);
    CheckExternalEvents(cs9, 0xE2D);
    // JA 0x1000:8ad1 (17C6_0E2B / 0x18A8B)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs9, 0xE2F);
    // ADD AX,AX (17C6_0E2D / 0x18A8D)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs9, 0xE30);
    // XCHG AX,BX (17C6_0E2F / 0x18A8F)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs9, 0xE35);
    // JMP word ptr CS:[BX + 0xe35] (17C6_0E30 / 0x18A90)
    // Indirect jump to word ptr CS:[BX + 0xe35], generating possible targets from emulator records
    uint targetAddress_17C6_0E30 = (uint)(cs9 * 0x10 + UInt16[cs9, (ushort)(BX + 0xE35)] - cs1 * 0x10);
    switch(targetAddress_17C6_0E30) {
      case 0x189C9 : {
        goto label_17C6_0D69_189C9;
        break;
      }
      case 0x18AD1 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_1000_8AD1_18AD1, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x189B9 : {
        goto label_17C6_0D59_189B9;
        break;
      }
      case 0x189C1 : {
        goto label_17C6_0D61_189C1;
        break;
      }
      case 0x189B1 : {
        goto label_17C6_0D51_189B1;
        break;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_17C6_0E30));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_1000_8AD1_18AD1(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8AD1_18AD1:
    CheckExternalEvents(cs7, 0x8AD4);
    // MOV AX,word ptr [BP + 0x6] (1000_8AD1 / 0x18AD1)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x8AD5);
    // POP BP (1000_8AD4 / 0x18AD4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x8AD6);
    // RETF  (1000_8AD5 / 0x18AD5)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0006_18AD6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0006_18AD6:
    CheckExternalEvents(cs10, 0x7);
    // PUSH BP (18AD_0006 / 0x18AD6)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x9);
    // MOV BP,SP (18AD_0007 / 0x18AD7)
    BP = SP;
    CheckExternalEvents(cs10, 0xB);
    // XOR AX,AX (18AD_0009 / 0x18AD9)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs10, 0x10);
    // CALLF 0x1000:cecc (18AD_000B / 0x18ADB)
    FarCall(cs10, 0x10, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x12);
    // JMP 0x1000:8af3 (18AD_0010 / 0x18AE0)
    goto label_18AD_0023_18AF3;
    label_18AD_0012_18AE2:
    CheckExternalEvents(cs10, 0x16);
    // MOV ES,word ptr [0x56ee] (18AD_0012 / 0x18AE2)
    ES = UInt16[DS, 0x56EE];
    CheckExternalEvents(cs10, 0x1B);
    // PUSH word ptr ES:[0x32ac] (18AD_0016 / 0x18AE6)
    Stack.Push16(UInt16[ES, 0x32AC]);
    CheckExternalEvents(cs10, 0x20);
    // CALLF 0x1000:aa30 (18AD_001B / 0x18AEB)
    FarCall(cs10, 0x20, unknown_19EF_0B40_1AA30);
    CheckExternalEvents(cs10, 0x23);
    // ADD SP,0x2 (18AD_0020 / 0x18AF0)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_18AD_0023_18AF3:
    CheckExternalEvents(cs10, 0x26);
    // MOV AX,word ptr [BP + 0x6] (18AD_0023 / 0x18AF3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs10, 0x29);
    // DEC word ptr [BP + 0x6] (18AD_0026 / 0x18AF6)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x2B);
    // OR AX,AX (18AD_0029 / 0x18AF9)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs10, 0x2D);
    // JNZ 0x1000:8ae2 (18AD_002B / 0x18AFB)
    if(!ZeroFlag) {
      goto label_18AD_0012_18AE2;
    }
    CheckExternalEvents(cs10, 0x2E);
    // POP BP (18AD_002D / 0x18AFD)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x2F);
    // RETF  (18AD_002E / 0x18AFE)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_002F_18AFF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_002F_18AFF:
    CheckExternalEvents(cs10, 0x31);
    // XOR AX,AX (18AD_002F / 0x18AFF)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs10, 0x36);
    // CALLF 0x1000:cecc (18AD_0031 / 0x18B01)
    FarCall(cs10, 0x36, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x3B);
    // CALLF 0x1000:dacc (18AD_0036 / 0x18B06)
    FarCall(cs10, 0x3B, unknown_19EF_3BDC_1DACC);
    CheckExternalEvents(cs10, 0x3D);
    // OR AX,AX (18AD_003B / 0x18B0B)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs10, 0x3F);
    // JNZ 0x1000:8b1b (18AD_003D / 0x18B0D)
    if(!ZeroFlag) {
      goto label_18AD_004B_18B1B;
    }
    CheckExternalEvents(cs10, 0x43);
    // MOV ES,word ptr [0x56f0] (18AD_003F / 0x18B0F)
    ES = UInt16[DS, 0x56F0];
    CheckExternalEvents(cs10, 0x49);
    // CMP word ptr ES:[0x3938],0x0 (18AD_0043 / 0x18B13)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs10, 0x4B);
    // JZ 0x1000:8b20 (18AD_0049 / 0x18B19)
    if(ZeroFlag) {
      goto label_18AD_0050_18B20;
    }
    label_18AD_004B_18B1B:
    CheckExternalEvents(cs10, 0x4E);
    // MOV AX,0x1 (18AD_004B / 0x18B1B)
    AX = 0x1;
    CheckExternalEvents(cs10, 0x50);
    // JMP 0x1000:8b22 (18AD_004E / 0x18B1E)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs10, 0x53);
    // RETF  (18AD_0052 / 0x18B22)
    return FarRet();
    label_18AD_0050_18B20:
    CheckExternalEvents(cs10, 0x52);
    // SUB AX,AX (18AD_0050 / 0x18B20)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    label_18AD_0052_18B22:
    CheckExternalEvents(cs10, 0x53);
    // RETF  (18AD_0052 / 0x18B22)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_8B23_18B23(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_8B23_18B23:
    CheckExternalEvents(cs7, 0x8B24);
    // PUSH BP (1000_8B23 / 0x18B23)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x8B26);
    // MOV BP,SP (1000_8B24 / 0x18B24)
    BP = SP;
    CheckExternalEvents(cs7, 0x8B28);
    // XOR AX,AX (1000_8B26 / 0x18B26)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0x8B2D);
    // CALLF 0x1000:cecc (1000_8B28 / 0x18B28)
    FarCall(cs7, 0x8B2D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x8B30);
    // MOV AX,0xa (1000_8B2D / 0x18B2D)
    AX = 0xA;
    CheckExternalEvents(cs7, 0x8B31);
    // PUSH AX (1000_8B30 / 0x18B30)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x8B34);
    // MOV AX,0x12 (1000_8B31 / 0x18B31)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x8B37);
    // MOV DX,0x2a02 (1000_8B34 / 0x18B34)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x8B38);
    // PUSH DX (1000_8B37 / 0x18B37)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x8B39);
    // PUSH AX (1000_8B38 / 0x18B38)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x8B3C);
    // PUSH word ptr [BP + 0x6] (1000_8B39 / 0x18B39)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x8B41);
    // CALLF 0x1000:daa6 (1000_8B3C / 0x18B3C)
    FarCall(cs7, 0x8B41, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs7, 0x8B44);
    // ADD SP,0x8 (1000_8B41 / 0x18B41)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs7, 0x8B47);
    // MOV AX,0x12 (1000_8B44 / 0x18B44)
    AX = 0x12;
    CheckExternalEvents(cs7, 0x8B4A);
    // MOV DX,0x2a02 (1000_8B47 / 0x18B47)
    DX = 0x2A02;
    CheckExternalEvents(cs7, 0x8B4B);
    // PUSH DX (1000_8B4A / 0x18B4A)
    Stack.Push16(DX);
    CheckExternalEvents(cs7, 0x8B4C);
    // PUSH AX (1000_8B4B / 0x18B4B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x8B51);
    // CALLF 0x1000:8055 (1000_8B4C / 0x18B4C)
    FarCall(cs7, 0x8B51, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0x8B54);
    // ADD SP,0x4 (1000_8B51 / 0x18B51)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x8B55);
    // POP BP (1000_8B54 / 0x18B54)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x8B56);
    // RETF  (1000_8B55 / 0x18B55)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0086_18B56(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0086_18B56:
    CheckExternalEvents(cs10, 0x87);
    // PUSH BP (18AD_0086 / 0x18B56)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x89);
    // MOV BP,SP (18AD_0087 / 0x18B57)
    BP = SP;
    CheckExternalEvents(cs10, 0x8B);
    // XOR AX,AX (18AD_0089 / 0x18B59)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs10, 0x90);
    // CALLF 0x1000:cecc (18AD_008B / 0x18B5B)
    FarCall(cs10, 0x90, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x95);
    // CMP word ptr [0x4fba],0x2 (18AD_0090 / 0x18B60)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs10, 0x97);
    // JZ 0x1000:8b83 (18AD_0095 / 0x18B65)
    if(ZeroFlag) {
      goto label_18AD_00B3_18B83;
    }
    CheckExternalEvents(cs10, 0x9A);
    // PUSH word ptr [BP + 0x10] (18AD_0097 / 0x18B67)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs10, 0x9D);
    // PUSH word ptr [BP + 0xe] (18AD_009A / 0x18B6A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0xA0);
    // PUSH word ptr [BP + 0xc] (18AD_009D / 0x18B6D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0xA3);
    // PUSH word ptr [BP + 0xa] (18AD_00A0 / 0x18B70)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0xA6);
    // PUSH word ptr [BP + 0x8] (18AD_00A3 / 0x18B73)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0xA9);
    // PUSH word ptr [BP + 0x6] (18AD_00A6 / 0x18B76)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0xAE);
    // CALLF 0x1000:befe (18AD_00A9 / 0x18B79)
    FarCall(cs10, 0xAE, unknown_19EF_200E_1BEFE);
    CheckExternalEvents(cs10, 0xB1);
    // ADD SP,0xc (18AD_00AE / 0x18B7E)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs10, 0xB3);
    // JMP 0x1000:8ba3 (18AD_00B1 / 0x18B81)
    goto label_18AD_00D3_18BA3;
    label_18AD_00B3_18B83:
    CheckExternalEvents(cs10, 0xB6);
    // PUSH word ptr [BP + 0x10] (18AD_00B3 / 0x18B83)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs10, 0xB9);
    // PUSH word ptr [BP + 0xe] (18AD_00B6 / 0x18B86)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0xBC);
    // PUSH word ptr [BP + 0xc] (18AD_00B9 / 0x18B89)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0xBF);
    // PUSH word ptr [BP + 0xa] (18AD_00BC / 0x18B8C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0xC1);
    // SUB AX,AX (18AD_00BF / 0x18B8F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0xC4);
    // MOV DX,0xa000 (18AD_00C1 / 0x18B91)
    DX = 0xA000;
    CheckExternalEvents(cs10, 0xC5);
    // PUSH DX (18AD_00C4 / 0x18B94)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0xC6);
    // PUSH AX (18AD_00C5 / 0x18B95)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0xC9);
    // MOV DX,0xa800 (18AD_00C6 / 0x18B96)
    DX = 0xA800;
    CheckExternalEvents(cs10, 0xCA);
    // PUSH DX (18AD_00C9 / 0x18B99)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0xCB);
    // PUSH AX (18AD_00CA / 0x18B9A)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0xD0);
    // CALLF 0x1000:c34c (18AD_00CB / 0x18B9B)
    FarCall(cs10, 0xD0, unknown_19EF_245C_1C34C);
    CheckExternalEvents(cs10, 0xD3);
    // ADD SP,0x10 (18AD_00D0 / 0x18BA0)
    // SP += 0x10;
    SP = Alu16.Add(SP, 0x10);
    label_18AD_00D3_18BA3:
    CheckExternalEvents(cs10, 0xD4);
    // POP BP (18AD_00D3 / 0x18BA3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0xD5);
    // RETF  (18AD_00D4 / 0x18BA4)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_00D5_18BA5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_00D5_18BA5:
    CheckExternalEvents(cs10, 0xD6);
    // PUSH BP (18AD_00D5 / 0x18BA5)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0xD8);
    // MOV BP,SP (18AD_00D6 / 0x18BA6)
    BP = SP;
    CheckExternalEvents(cs10, 0xDB);
    // MOV AX,0xe (18AD_00D8 / 0x18BA8)
    AX = 0xE;
    CheckExternalEvents(cs10, 0xE0);
    // CALLF 0x1000:cecc (18AD_00DB / 0x18BAB)
    FarCall(cs10, 0xE0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0xE3);
    // PUSH word ptr [BP + 0x10] (18AD_00E0 / 0x18BB0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x10)]);
    CheckExternalEvents(cs10, 0xE6);
    // PUSH word ptr [BP + 0xe] (18AD_00E3 / 0x18BB3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0xEB);
    // CALLF 0x1000:c017 (18AD_00E6 / 0x18BB6)
    FarCall(cs10, 0xEB, unknown_19EF_2127_1C017);
    CheckExternalEvents(cs10, 0xEE);
    // ADD SP,0x4 (18AD_00EB / 0x18BBB)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs10, 0xF1);
    // MOV AX,word ptr [BP + 0x6] (18AD_00EE / 0x18BBE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs10, 0xF4);
    // MOV DX,word ptr [BP + 0x8] (18AD_00F1 / 0x18BC1)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs10, 0xF7);
    // MOV word ptr [BP + -0x4],AX (18AD_00F4 / 0x18BC4)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs10, 0xFA);
    // MOV word ptr [BP + -0x2],DX (18AD_00F7 / 0x18BC7)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs10, 0xFD);
    // MOV AX,0x140 (18AD_00FA / 0x18BCA)
    AX = 0x140;
    CheckExternalEvents(cs10, 0x100);
    // IMUL word ptr [BP + 0xc] (18AD_00FD / 0x18BCD)
    int resImul18AD_00FD = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resImul18AD_00FD);
    DX = (ushort)(resImul18AD_00FD >> 16);
    CheckExternalEvents(cs10, 0x103);
    // MOV word ptr [BP + -0xa],AX (18AD_0100 / 0x18BD0)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs10, 0x108);
    // CMP word ptr [0x4fba],0x3 (18AD_0103 / 0x18BD3)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs10, 0x10A);
    // JNZ 0x1000:8be3 (18AD_0108 / 0x18BD8)
    if(!ZeroFlag) {
      goto label_18AD_0113_18BE3;
    }
    CheckExternalEvents(cs10, 0x10D);
    // MOV AX,0xa00 (18AD_010A / 0x18BDA)
    AX = 0xA00;
    CheckExternalEvents(cs10, 0x110);
    // IMUL word ptr [BP + 0xc] (18AD_010D / 0x18BDD)
    int resImul18AD_010D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xC)]);
    AX = (ushort)(resImul18AD_010D);
    DX = (ushort)(resImul18AD_010D >> 16);
    CheckExternalEvents(cs10, 0x113);
    // MOV word ptr [BP + -0xa],AX (18AD_0110 / 0x18BE0)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_18AD_0113_18BE3:
    CheckExternalEvents(cs10, 0x116);
    // MOV AX,word ptr [BP + 0xa] (18AD_0113 / 0x18BE3)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x119);
    // MOV word ptr [BP + -0x6],AX (18AD_0116 / 0x18BE6)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs10, 0x11C);
    // JMP 0x1000:8cb7 (18AD_0119 / 0x18BE9)
    goto label_18AD_01E7_18CB7;
    label_18AD_011C_18BEC:
    CheckExternalEvents(cs10, 0x120);
    // CMP byte ptr [BP + -0xe],0xd (18AD_011C / 0x18BEC)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0xE)], 0xD);
    CheckExternalEvents(cs10, 0x122);
    // JNZ 0x1000:8c0f (18AD_0120 / 0x18BF0)
    if(!ZeroFlag) {
      goto label_18AD_013F_18C0F;
    }
    CheckExternalEvents(cs10, 0x125);
    // MOV AX,word ptr [BP + -0x6] (18AD_0122 / 0x18BF2)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs10, 0x128);
    // MOV word ptr [BP + 0xa],AX (18AD_0125 / 0x18BF5)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs10, 0x12D);
    // ADD word ptr [BP + -0xa],0x140 (18AD_0128 / 0x18BF8)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x140;
    CheckExternalEvents(cs10, 0x132);
    // CMP word ptr [0x4fba],0x3 (18AD_012D / 0x18BFD)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs10, 0x134);
    // JNZ 0x1000:8c09 (18AD_0132 / 0x18C02)
    if(!ZeroFlag) {
      goto label_18AD_0139_18C09;
    }
    CheckExternalEvents(cs10, 0x139);
    // ADD word ptr [BP + -0xa],0x8c0 (18AD_0134 / 0x18C04)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x8C0;
    label_18AD_0139_18C09:
    CheckExternalEvents(cs10, 0x13C);
    // INC word ptr [BP + -0x4] (18AD_0139 / 0x18C09)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs10, 0x13F);
    // JMP 0x1000:8cb7 (18AD_013C / 0x18C0C)
    goto label_18AD_01E7_18CB7;
    label_18AD_013F_18C0F:
    CheckExternalEvents(cs10, 0x142);
    // LES BX,[BP + -0x4] (18AD_013F / 0x18C0F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs10, 0x145);
    // INC word ptr [BP + -0x4] (18AD_0142 / 0x18C12)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs10, 0x148);
    // MOV AL,byte ptr ES:[BX] (18AD_0145 / 0x18C15)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs10, 0x14B);
    // AND AX,0x7f (18AD_0148 / 0x18C18)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs10, 0x14D);
    // MOV CL,0x3 (18AD_014B / 0x18C1B)
    CL = 0x3;
    CheckExternalEvents(cs10, 0x14F);
    // SHL AX,CL (18AD_014D / 0x18C1D)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs10, 0x152);
    // MOV word ptr [BP + -0xc],AX (18AD_014F / 0x18C1F)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs10, 0x155);
    // MOV AX,[0x4fb8] (18AD_0152 / 0x18C22)
    AX = UInt16[DS, 0x4FB8];
    CheckExternalEvents(cs10, 0x156);
    // DEC AX (18AD_0155 / 0x18C25)
    AX--;
    CheckExternalEvents(cs10, 0x159);
    // CMP word ptr [BP + 0xa],AX (18AD_0156 / 0x18C26)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], AX);
    CheckExternalEvents(cs10, 0x15B);
    // JLE 0x1000:8c46 (18AD_0159 / 0x18C29)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_0176_18C46;
    }
    CheckExternalEvents(cs10, 0x15E);
    // MOV AX,word ptr [BP + -0x6] (18AD_015B / 0x18C2B)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs10, 0x161);
    // MOV word ptr [BP + 0xa],AX (18AD_015E / 0x18C2E)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs10, 0x165);
    // INC word ptr [0x4fbe] (18AD_0161 / 0x18C31)
    UInt16[DS, 0x4FBE]++;
    CheckExternalEvents(cs10, 0x16A);
    // ADD word ptr [BP + -0xa],0x140 (18AD_0165 / 0x18C35)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x140;
    CheckExternalEvents(cs10, 0x16F);
    // CMP word ptr [0x4fba],0x3 (18AD_016A / 0x18C3A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs10, 0x171);
    // JNZ 0x1000:8c46 (18AD_016F / 0x18C3F)
    if(!ZeroFlag) {
      goto label_18AD_0176_18C46;
    }
    CheckExternalEvents(cs10, 0x176);
    // ADD word ptr [BP + -0xa],0x8c0 (18AD_0171 / 0x18C41)
    // UInt16[SS, (ushort)(BP - 0xA)] += 0x8C0;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xA)], 0x8C0);
    label_18AD_0176_18C46:
    CheckExternalEvents(cs10, 0x179);
    // MOV AX,word ptr [BP + 0xa] (18AD_0176 / 0x18C46)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x17C);
    // INC word ptr [BP + 0xa] (18AD_0179 / 0x18C49)
    UInt16[SS, (ushort)(BP + 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x17F);
    // MOV word ptr [BP + -0x8],AX (18AD_017C / 0x18C4C)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs10, 0x184);
    // CMP word ptr [0x4fba],0x0 (18AD_017F / 0x18C4F)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs10, 0x186);
    // JNZ 0x1000:8c69 (18AD_0184 / 0x18C54)
    if(!ZeroFlag) {
      goto label_18AD_0199_18C69;
    }
    CheckExternalEvents(cs10, 0x188);
    // SHL AX,0x1 (18AD_0186 / 0x18C56)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs10, 0x189);
    // PUSH AX (18AD_0188 / 0x18C58)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x18C);
    // PUSH word ptr [BP + -0xa] (18AD_0189 / 0x18C59)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs10, 0x18F);
    // MOV AX,word ptr [BP + -0xc] (18AD_018C / 0x18C5C)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs10, 0x191);
    // SHL AX,0x1 (18AD_018F / 0x18C5F)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs10, 0x192);
    // PUSH AX (18AD_0191 / 0x18C61)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x197);
    // CALLF 0x1000:c0f9 (18AD_0192 / 0x18C62)
    FarCall(cs10, 0x197, ghidra_guess_1000_C0F9_1C0F9);
    CheckExternalEvents(cs10, 0x199);
    // JMP 0x1000:8cb4 (18AD_0197 / 0x18C67)
    goto label_18AD_01E4_18CB4;
    label_18AD_0199_18C69:
    CheckExternalEvents(cs10, 0x19E);
    // CMP word ptr [0x4fba],0x1 (18AD_0199 / 0x18C69)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x1);
    CheckExternalEvents(cs10, 0x1A0);
    // JNZ 0x1000:8c8a (18AD_019E / 0x18C6E)
    if(!ZeroFlag) {
      goto label_18AD_01BA_18C8A;
    }
    CheckExternalEvents(cs10, 0x1A3);
    // MOV AX,word ptr [BP + -0x8] (18AD_01A0 / 0x18C70)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs10, 0x1A5);
    // SHL AX,0x1 (18AD_01A3 / 0x18C73)
    AX <<= 0x1;
    CheckExternalEvents(cs10, 0x1A7);
    // SHL AX,0x1 (18AD_01A5 / 0x18C75)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs10, 0x1A8);
    // PUSH AX (18AD_01A7 / 0x18C77)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x1AB);
    // PUSH word ptr [BP + -0xa] (18AD_01A8 / 0x18C78)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs10, 0x1AE);
    // MOV AX,word ptr [BP + -0xc] (18AD_01AB / 0x18C7B)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs10, 0x1B0);
    // SHL AX,0x1 (18AD_01AE / 0x18C7E)
    AX <<= 0x1;
    CheckExternalEvents(cs10, 0x1B2);
    // SHL AX,0x1 (18AD_01B0 / 0x18C80)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs10, 0x1B3);
    // PUSH AX (18AD_01B2 / 0x18C82)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x1B8);
    // CALLF 0x1000:c098 (18AD_01B3 / 0x18C83)
    FarCall(cs10, 0x1B8, ghidra_guess_1000_C098_1C098);
    CheckExternalEvents(cs10, 0x1BA);
    // JMP 0x1000:8cb4 (18AD_01B8 / 0x18C88)
    goto label_18AD_01E4_18CB4;
    label_18AD_01BA_18C8A:
    CheckExternalEvents(cs10, 0x1BF);
    // CMP word ptr [0x4fba],0x2 (18AD_01BA / 0x18C8A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs10, 0x1C1);
    // JNZ 0x1000:8ca1 (18AD_01BF / 0x18C8F)
    if(!ZeroFlag) {
      goto label_18AD_01D1_18CA1;
    }
    CheckExternalEvents(cs10, 0x1C4);
    // PUSH word ptr [BP + -0x8] (18AD_01C1 / 0x18C91)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs10, 0x1C7);
    // PUSH word ptr [BP + -0xa] (18AD_01C4 / 0x18C94)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs10, 0x1CA);
    // PUSH word ptr [BP + -0xc] (18AD_01C7 / 0x18C97)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs10, 0x1CF);
    // CALLF 0x1000:c141 (18AD_01CA / 0x18C9A)
    FarCall(cs10, 0x1CF, ghidra_guess_1000_C141_1C141);
    CheckExternalEvents(cs10, 0x1D1);
    // JMP 0x1000:8cb4 (18AD_01CF / 0x18C9F)
    goto label_18AD_01E4_18CB4;
    label_18AD_01D1_18CA1:
    CheckExternalEvents(cs10, 0x1D4);
    // MOV AX,word ptr [BP + -0x8] (18AD_01D1 / 0x18CA1)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs10, 0x1D6);
    // MOV CL,0x3 (18AD_01D4 / 0x18CA4)
    CL = 0x3;
    CheckExternalEvents(cs10, 0x1D8);
    // SHL AX,CL (18AD_01D6 / 0x18CA6)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs10, 0x1D9);
    // PUSH AX (18AD_01D8 / 0x18CA8)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x1DC);
    // PUSH word ptr [BP + -0xa] (18AD_01D9 / 0x18CA9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs10, 0x1DF);
    // PUSH word ptr [BP + -0xc] (18AD_01DC / 0x18CAC)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs10, 0x1E4);
    // CALLF 0x1000:c195 (18AD_01DF / 0x18CAF)
    FarCall(cs10, 0x1E4, unknown_19EF_22A5_1C195);
    label_18AD_01E4_18CB4:
    CheckExternalEvents(cs10, 0x1E7);
    // ADD SP,0x6 (18AD_01E4 / 0x18CB4)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_18AD_01E7_18CB7:
    CheckExternalEvents(cs10, 0x1EA);
    // LES BX,[BP + -0x4] (18AD_01E7 / 0x18CB7)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs10, 0x1ED);
    // MOV AL,byte ptr ES:[BX] (18AD_01EA / 0x18CBA)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs10, 0x1F0);
    // MOV byte ptr [BP + -0xe],AL (18AD_01ED / 0x18CBD)
    UInt8[SS, (ushort)(BP - 0xE)] = AL;
    CheckExternalEvents(cs10, 0x1F2);
    // OR AL,AL (18AD_01F0 / 0x18CC0)
    // AL |= AL;
    AL = Alu8.Or(AL, AL);
    CheckExternalEvents(cs10, 0x1F4);
    // JZ 0x1000:8cc7 (18AD_01F2 / 0x18CC2)
    if(ZeroFlag) {
      goto label_18AD_01F7_18CC7;
    }
    CheckExternalEvents(cs10, 0x1F7);
    // JMP 0x1000:8bec (18AD_01F4 / 0x18CC4)
    goto label_18AD_011C_18BEC;
    label_18AD_01F7_18CC7:
    CheckExternalEvents(cs10, 0x1F9);
    // MOV SP,BP (18AD_01F7 / 0x18CC7)
    SP = BP;
    CheckExternalEvents(cs10, 0x1FA);
    // POP BP (18AD_01F9 / 0x18CC9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x1FB);
    // RETF  (18AD_01FA / 0x18CCA)
    return FarRet();
  }
  
}
