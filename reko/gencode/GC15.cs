namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action unknown_18AD_01FB_18CCB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_01FB_18CCB:
    CheckExternalEvents(cs10, 0x1FC);
    // PUSH BP (18AD_01FB / 0x18CCB)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x1FE);
    // MOV BP,SP (18AD_01FC / 0x18CCC)
    BP = SP;
    CheckExternalEvents(cs10, 0x200);
    // XOR AX,AX (18AD_01FE / 0x18CCE)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs10, 0x205);
    // CALLF 0x1000:cecc (18AD_0200 / 0x18CD0)
    FarCall(cs10, 0x205, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x209);
    // TEST byte ptr [BP + 0x6],0x1 (18AD_0205 / 0x18CD5)
    Alu8.And(UInt8[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs10, 0x20B);
    // JNZ 0x1000:8ce8 (18AD_0209 / 0x18CD9)
    if(!ZeroFlag) {
      goto label_18AD_0218_18CE8;
    }
    CheckExternalEvents(cs10, 0x20F);
    // TEST byte ptr [BP + 0xa],0x1 (18AD_020B / 0x18CDB)
    Alu8.And(UInt8[SS, (ushort)(BP + 0xA)], 0x1);
    CheckExternalEvents(cs10, 0x211);
    // JZ 0x1000:8ce8 (18AD_020F / 0x18CDF)
    if(ZeroFlag) {
      goto label_18AD_0218_18CE8;
    }
    CheckExternalEvents(cs10, 0x216);
    // CMP word ptr [0x4fba],0x1 (18AD_0211 / 0x18CE1)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x1);
    CheckExternalEvents(cs10, 0x218);
    // JZ 0x1000:8d06 (18AD_0216 / 0x18CE6)
    if(ZeroFlag) {
      goto label_18AD_0236_18D06;
    }
    label_18AD_0218_18CE8:
    CheckExternalEvents(cs10, 0x21B);
    // MOV AX,word ptr [BP + 0x8] (18AD_0218 / 0x18CE8)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs10, 0x21E);
    // CMP word ptr [BP + 0xc],AX (18AD_021B / 0x18CEB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], AX);
    CheckExternalEvents(cs10, 0x220);
    // JL 0x1000:8d27 (18AD_021E / 0x18CEE)
    if(SignFlag != OverflowFlag) {
      goto label_18AD_0257_18D27;
    }
    CheckExternalEvents(cs10, 0x223);
    // PUSH word ptr [BP + 0xe] (18AD_0220 / 0x18CF0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x226);
    // PUSH word ptr [BP + 0xa] (18AD_0223 / 0x18CF3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x229);
    // PUSH word ptr [BP + 0x6] (18AD_0226 / 0x18CF6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x22A);
    // PUSH AX (18AD_0229 / 0x18CF9)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x22D);
    // INC word ptr [BP + 0x8] (18AD_022A / 0x18CFA)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x22E);
    // PUSH CS (18AD_022D / 0x18CFD)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x231);
    // CALL 0x1000:8ebb (18AD_022E / 0x18CFE)
    NearCall(cs10, 0x231, unknown_18AD_03EB_18EBB);
    CheckExternalEvents(cs10, 0x234);
    // ADD SP,0x8 (18AD_0231 / 0x18D01)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs10, 0x236);
    // JMP 0x1000:8ce8 (18AD_0234 / 0x18D04)
    goto label_18AD_0218_18CE8;
    label_18AD_0236_18D06:
    CheckExternalEvents(cs10, 0x239);
    // PUSH word ptr [BP + 0xe] (18AD_0236 / 0x18D06)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x23C);
    // MOV AX,word ptr [BP + 0xc] (18AD_0239 / 0x18D09)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x23F);
    // SUB AX,word ptr [BP + 0x8] (18AD_023C / 0x18D0C)
    // AX -= UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x240);
    // PUSH AX (18AD_023F / 0x18D0F)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x243);
    // MOV AX,word ptr [BP + 0xa] (18AD_0240 / 0x18D10)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x246);
    // SUB AX,word ptr [BP + 0x6] (18AD_0243 / 0x18D13)
    AX -= UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs10, 0x248);
    // SAR AX,0x1 (18AD_0246 / 0x18D16)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs10, 0x249);
    // PUSH AX (18AD_0248 / 0x18D18)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x24C);
    // PUSH word ptr [BP + 0x8] (18AD_0249 / 0x18D19)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x24F);
    // PUSH word ptr [BP + 0x6] (18AD_024C / 0x18D1C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x254);
    // CALLF 0x1000:a791 (18AD_024F / 0x18D1F)
    FarCall(cs10, 0x254, ghidra_guess_1000_A791_1A791);
    CheckExternalEvents(cs10, 0x257);
    // ADD SP,0xa (18AD_0254 / 0x18D24)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_18AD_0257_18D27:
    CheckExternalEvents(cs10, 0x258);
    // POP BP (18AD_0257 / 0x18D27)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x259);
    // RETF  (18AD_0258 / 0x18D28)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0259_18D29(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0259_18D29:
    CheckExternalEvents(cs10, 0x25A);
    // PUSH BP (18AD_0259 / 0x18D29)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x25C);
    // MOV BP,SP (18AD_025A / 0x18D2A)
    BP = SP;
    CheckExternalEvents(cs10, 0x25F);
    // MOV AX,0x4 (18AD_025C / 0x18D2C)
    AX = 0x4;
    CheckExternalEvents(cs10, 0x264);
    // CALLF 0x1000:cecc (18AD_025F / 0x18D2F)
    FarCall(cs10, 0x264, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x268);
    // MOV ES,word ptr [0x56f0] (18AD_0264 / 0x18D34)
    ES = UInt16[DS, 0x56F0];
    CheckExternalEvents(cs10, 0x26E);
    // CMP word ptr ES:[0x3938],0x0 (18AD_0268 / 0x18D38)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs10, 0x270);
    // JNZ 0x1000:8d91 (18AD_026E / 0x18D3E)
    if(!ZeroFlag) {
      goto label_18AD_02C1_18D91;
    }
    label_18AD_0270_18D40:
    CheckExternalEvents(cs10, 0x275);
    // CALLF 0x1000:aa7a (18AD_0270 / 0x18D40)
    FarCall(cs10, 0x275, unknown_19EF_0B8A_1AA7A);
    CheckExternalEvents(cs10, 0x278);
    // MOV word ptr [BP + -0x4],AX (18AD_0275 / 0x18D45)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs10, 0x27C);
    // MOV ES,word ptr [0x56f2] (18AD_0278 / 0x18D48)
    ES = UInt16[DS, 0x56F2];
    CheckExternalEvents(cs10, 0x282);
    // CMP word ptr ES:[0x458c],0x0 (18AD_027C / 0x18D4C)
    Alu16.Sub(UInt16[ES, 0x458C], 0x0);
    CheckExternalEvents(cs10, 0x284);
    // JNZ 0x1000:8d57 (18AD_0282 / 0x18D52)
    if(!ZeroFlag) {
      goto label_18AD_0287_18D57;
    }
    CheckExternalEvents(cs10, 0x287);
    // JMP 0x1000:8de8 (18AD_0284 / 0x18D54)
    goto label_18AD_0318_18DE8;
    label_18AD_0287_18D57:
    CheckExternalEvents(cs10, 0x28A);
    // CMP AX,0x68 (18AD_0287 / 0x18D57)
    Alu16.Sub(AX, 0x68);
    CheckExternalEvents(cs10, 0x28C);
    // JNZ 0x1000:8d61 (18AD_028A / 0x18D5A)
    if(!ZeroFlag) {
      goto label_18AD_0291_18D61;
    }
    CheckExternalEvents(cs10, 0x291);
    // MOV word ptr [BP + -0x4],0x48 (18AD_028C / 0x18D5C)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x48;
    label_18AD_0291_18D61:
    CheckExternalEvents(cs10, 0x294);
    // MOV AL,byte ptr [BP + -0x4] (18AD_0291 / 0x18D61)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs10, 0x298);
    // MOV ES,word ptr [0x56f4] (18AD_0294 / 0x18D64)
    ES = UInt16[DS, 0x56F4];
    CheckExternalEvents(cs10, 0x29D);
    // MOV BX,word ptr ES:[0x39f8] (18AD_0298 / 0x18D68)
    BX = UInt16[ES, 0x39F8];
    CheckExternalEvents(cs10, 0x2A2);
    // INC word ptr ES:[0x39f8] (18AD_029D / 0x18D6D)
    UInt16[ES, 0x39F8] = Alu16.Inc(UInt16[ES, 0x39F8]);
    CheckExternalEvents(cs10, 0x2A6);
    // MOV ES,word ptr [0x56f6] (18AD_02A2 / 0x18D72)
    ES = UInt16[DS, 0x56F6];
    CheckExternalEvents(cs10, 0x2AB);
    // MOV byte ptr ES:[BX + 0xa0],AL (18AD_02A6 / 0x18D76)
    UInt8[ES, (ushort)(BX + 0xA0)] = AL;
    CheckExternalEvents(cs10, 0x2AF);
    // CMP word ptr [BP + -0x4],0x48 (18AD_02AB / 0x18D7B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x48);
    CheckExternalEvents(cs10, 0x2B1);
    // JZ 0x1000:8d40 (18AD_02AF / 0x18D7F)
    if(ZeroFlag) {
      goto label_18AD_0270_18D40;
    }
    label_18AD_02B1_18D81:
    CheckExternalEvents(cs10, 0x2B4);
    // MOV AX,word ptr [BP + -0x4] (18AD_02B1 / 0x18D81)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs10, 0x2B6);
    // JMP 0x1000:8de8 (18AD_02B4 / 0x18D84)
    goto label_18AD_0318_18DE8;
    label_18AD_02B6_18D86:
    CheckExternalEvents(cs10, 0x2B9);
    // MOV AX,0x1e (18AD_02B6 / 0x18D86)
    AX = 0x1E;
    CheckExternalEvents(cs10, 0x2BA);
    // PUSH AX (18AD_02B9 / 0x18D89)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x2BB);
    // PUSH CS (18AD_02BA / 0x18D8A)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x2BE);
    // CALL 0x1000:8ad6 (18AD_02BB / 0x18D8B)
    NearCall(cs10, 0x2BE, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs10, 0x2C1);
    // ADD SP,0x2 (18AD_02BE / 0x18D8E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_18AD_02C1_18D91:
    CheckExternalEvents(cs10, 0x2C5);
    // MOV ES,word ptr [0x56f4] (18AD_02C1 / 0x18D91)
    ES = UInt16[DS, 0x56F4];
    CheckExternalEvents(cs10, 0x2CA);
    // MOV BX,word ptr ES:[0x39f8] (18AD_02C5 / 0x18D95)
    BX = UInt16[ES, 0x39F8];
    CheckExternalEvents(cs10, 0x2CF);
    // INC word ptr ES:[0x39f8] (18AD_02CA / 0x18D9A)
    UInt16[ES, 0x39F8] = Alu16.Inc(UInt16[ES, 0x39F8]);
    CheckExternalEvents(cs10, 0x2D3);
    // MOV ES,word ptr [0x56f6] (18AD_02CF / 0x18D9F)
    ES = UInt16[DS, 0x56F6];
    CheckExternalEvents(cs10, 0x2D8);
    // MOV AL,byte ptr ES:[BX + 0xa0] (18AD_02D3 / 0x18DA3)
    AL = UInt8[ES, (ushort)(BX + 0xA0)];
    CheckExternalEvents(cs10, 0x2D9);
    // CBW  (18AD_02D8 / 0x18DA8)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs10, 0x2DC);
    // MOV word ptr [BP + -0x4],AX (18AD_02D9 / 0x18DA9)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs10, 0x2DF);
    // CMP AX,0x48 (18AD_02DC / 0x18DAC)
    Alu16.Sub(AX, 0x48);
    CheckExternalEvents(cs10, 0x2E1);
    // JZ 0x1000:8d86 (18AD_02DF / 0x18DAF)
    if(ZeroFlag) {
      goto label_18AD_02B6_18D86;
    }
    CheckExternalEvents(cs10, 0x2E6);
    // CALLF 0x1000:dacc (18AD_02E1 / 0x18DB1)
    FarCall(cs10, 0x2E6, unknown_19EF_3BDC_1DACC);
    CheckExternalEvents(cs10, 0x2E8);
    // OR AX,AX (18AD_02E6 / 0x18DB6)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs10, 0x2EA);
    // JZ 0x1000:8dca (18AD_02E8 / 0x18DB8)
    if(ZeroFlag) {
      goto label_18AD_02FA_18DCA;
    }
    CheckExternalEvents(cs10, 0x2EE);
    // MOV ES,word ptr [0x56f8] (18AD_02EA / 0x18DBA)
    ES = UInt16[DS, 0x56F8];
    CheckExternalEvents(cs10, 0x2F5);
    // MOV word ptr ES:[0x152],0x1 (18AD_02EE / 0x18DBE)
    UInt16[ES, 0x152] = 0x1;
    CheckExternalEvents(cs10, 0x2FA);
    // CALLF 0x1000:aa7a (18AD_02F5 / 0x18DC5)
    FarCall(cs10, 0x2FA, unknown_19EF_0B8A_1AA7A);
    label_18AD_02FA_18DCA:
    CheckExternalEvents(cs10, 0x2FD);
    // MOV AX,0x1 (18AD_02FA / 0x18DCA)
    AX = 0x1;
    CheckExternalEvents(cs10, 0x2FE);
    // PUSH AX (18AD_02FD / 0x18DCD)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x2FF);
    // PUSH CS (18AD_02FE / 0x18DCE)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x302);
    // CALL 0x1000:8ad6 (18AD_02FF / 0x18DCF)
    NearCall(cs10, 0x302, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs10, 0x305);
    // ADD SP,0x2 (18AD_0302 / 0x18DD2)
    SP += 0x2;
    CheckExternalEvents(cs10, 0x309);
    // CMP word ptr [BP + -0x4],0x50 (18AD_0305 / 0x18DD5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x50);
    CheckExternalEvents(cs10, 0x30B);
    // JNZ 0x1000:8d81 (18AD_0309 / 0x18DD9)
    if(!ZeroFlag) {
      goto label_18AD_02B1_18D81;
    }
    CheckExternalEvents(cs10, 0x30F);
    // MOV ES,word ptr [0x56f8] (18AD_030B / 0x18DDB)
    ES = UInt16[DS, 0x56F8];
    CheckExternalEvents(cs10, 0x316);
    // MOV word ptr ES:[0x152],0x1 (18AD_030F / 0x18DDF)
    UInt16[ES, 0x152] = 0x1;
    CheckExternalEvents(cs10, 0x318);
    // JMP 0x1000:8d81 (18AD_0316 / 0x18DE6)
    goto label_18AD_02B1_18D81;
    label_18AD_0318_18DE8:
    CheckExternalEvents(cs10, 0x31A);
    // MOV SP,BP (18AD_0318 / 0x18DE8)
    SP = BP;
    CheckExternalEvents(cs10, 0x31B);
    // POP BP (18AD_031A / 0x18DEA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x31C);
    // RETF  (18AD_031B / 0x18DEB)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_031C_18DEC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_031C_18DEC:
    CheckExternalEvents(cs10, 0x31D);
    // PUSH BP (18AD_031C / 0x18DEC)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x31F);
    // MOV BP,SP (18AD_031D / 0x18DED)
    BP = SP;
    CheckExternalEvents(cs10, 0x322);
    // MOV AX,0x2 (18AD_031F / 0x18DEF)
    AX = 0x2;
    CheckExternalEvents(cs10, 0x327);
    // CALLF 0x1000:cecc (18AD_0322 / 0x18DF2)
    FarCall(cs10, 0x327, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x32A);
    // MOV AX,word ptr [BP + 0x6] (18AD_0327 / 0x18DF7)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs10, 0x32D);
    // CMP word ptr [BP + 0xa],AX (18AD_032A / 0x18DFA)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], AX);
    CheckExternalEvents(cs10, 0x32F);
    // JGE 0x1000:8e0e (18AD_032D / 0x18DFD)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_033E_18E0E;
    }
    CheckExternalEvents(cs10, 0x332);
    // MOV word ptr [BP + -0x2],AX (18AD_032F / 0x18DFF)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs10, 0x335);
    // MOV AX,word ptr [BP + 0xa] (18AD_0332 / 0x18E02)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x338);
    // MOV word ptr [BP + 0x6],AX (18AD_0335 / 0x18E05)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs10, 0x33B);
    // MOV AX,word ptr [BP + -0x2] (18AD_0338 / 0x18E08)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs10, 0x33E);
    // MOV word ptr [BP + 0xa],AX (18AD_033B / 0x18E0B)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    label_18AD_033E_18E0E:
    CheckExternalEvents(cs10, 0x341);
    // MOV AX,word ptr [BP + 0x8] (18AD_033E / 0x18E0E)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs10, 0x344);
    // CMP word ptr [BP + 0xc],AX (18AD_0341 / 0x18E11)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], AX);
    CheckExternalEvents(cs10, 0x346);
    // JGE 0x1000:8e25 (18AD_0344 / 0x18E14)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0355_18E25;
    }
    CheckExternalEvents(cs10, 0x349);
    // MOV word ptr [BP + -0x2],AX (18AD_0346 / 0x18E16)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs10, 0x34C);
    // MOV AX,word ptr [BP + 0xc] (18AD_0349 / 0x18E19)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x34F);
    // MOV word ptr [BP + 0x8],AX (18AD_034C / 0x18E1C)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs10, 0x352);
    // MOV AX,word ptr [BP + -0x2] (18AD_034F / 0x18E1F)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs10, 0x355);
    // MOV word ptr [BP + 0xc],AX (18AD_0352 / 0x18E22)
    UInt16[SS, (ushort)(BP + 0xC)] = AX;
    label_18AD_0355_18E25:
    CheckExternalEvents(cs10, 0x359);
    // CMP word ptr [BP + 0x6],0x0 (18AD_0355 / 0x18E25)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs10, 0x35B);
    // JGE 0x1000:8e30 (18AD_0359 / 0x18E29)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0360_18E30;
    }
    CheckExternalEvents(cs10, 0x360);
    // MOV word ptr [BP + 0x6],0x0 (18AD_035B / 0x18E2B)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x0;
    label_18AD_0360_18E30:
    CheckExternalEvents(cs10, 0x364);
    // CMP word ptr [BP + 0x8],0x0 (18AD_0360 / 0x18E30)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs10, 0x366);
    // JGE 0x1000:8e3b (18AD_0364 / 0x18E34)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_036B_18E3B;
    }
    CheckExternalEvents(cs10, 0x36B);
    // MOV word ptr [BP + 0x8],0x0 (18AD_0366 / 0x18E36)
    UInt16[SS, (ushort)(BP + 0x8)] = 0x0;
    label_18AD_036B_18E3B:
    CheckExternalEvents(cs10, 0x36F);
    // CMP word ptr [BP + 0xa],0x0 (18AD_036B / 0x18E3B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs10, 0x371);
    // JGE 0x1000:8e46 (18AD_036F / 0x18E3F)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0376_18E46;
    }
    CheckExternalEvents(cs10, 0x376);
    // MOV word ptr [BP + 0xa],0x0 (18AD_0371 / 0x18E41)
    UInt16[SS, (ushort)(BP + 0xA)] = 0x0;
    label_18AD_0376_18E46:
    CheckExternalEvents(cs10, 0x37A);
    // CMP word ptr [BP + 0xc],0x0 (18AD_0376 / 0x18E46)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0x0);
    CheckExternalEvents(cs10, 0x37C);
    // JGE 0x1000:8e51 (18AD_037A / 0x18E4A)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0381_18E51;
    }
    CheckExternalEvents(cs10, 0x381);
    // MOV word ptr [BP + 0xc],0x0 (18AD_037C / 0x18E4C)
    UInt16[SS, (ushort)(BP + 0xC)] = 0x0;
    label_18AD_0381_18E51:
    CheckExternalEvents(cs10, 0x386);
    // CMP word ptr [BP + 0x6],0x13f (18AD_0381 / 0x18E51)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x13F);
    CheckExternalEvents(cs10, 0x388);
    // JLE 0x1000:8e5d (18AD_0386 / 0x18E56)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_038D_18E5D;
    }
    CheckExternalEvents(cs10, 0x38D);
    // MOV word ptr [BP + 0x6],0x13f (18AD_0388 / 0x18E58)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x13F;
    label_18AD_038D_18E5D:
    CheckExternalEvents(cs10, 0x392);
    // CMP word ptr [BP + 0xa],0x13f (18AD_038D / 0x18E5D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x13F);
    CheckExternalEvents(cs10, 0x394);
    // JLE 0x1000:8e69 (18AD_0392 / 0x18E62)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_0399_18E69;
    }
    CheckExternalEvents(cs10, 0x399);
    // MOV word ptr [BP + 0xa],0x13f (18AD_0394 / 0x18E64)
    UInt16[SS, (ushort)(BP + 0xA)] = 0x13F;
    label_18AD_0399_18E69:
    CheckExternalEvents(cs10, 0x39E);
    // CMP word ptr [BP + 0x8],0xc7 (18AD_0399 / 0x18E69)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xC7);
    CheckExternalEvents(cs10, 0x3A0);
    // JLE 0x1000:8e75 (18AD_039E / 0x18E6E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_03A5_18E75;
    }
    CheckExternalEvents(cs10, 0x3A5);
    // MOV word ptr [BP + 0x8],0xc7 (18AD_03A0 / 0x18E70)
    UInt16[SS, (ushort)(BP + 0x8)] = 0xC7;
    label_18AD_03A5_18E75:
    CheckExternalEvents(cs10, 0x3AA);
    // CMP word ptr [BP + 0xc],0xc7 (18AD_03A5 / 0x18E75)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0xC7);
    CheckExternalEvents(cs10, 0x3AC);
    // JLE 0x1000:8e81 (18AD_03AA / 0x18E7A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_03B1_18E81;
    }
    CheckExternalEvents(cs10, 0x3B1);
    // MOV word ptr [BP + 0xc],0xc7 (18AD_03AC / 0x18E7C)
    UInt16[SS, (ushort)(BP + 0xC)] = 0xC7;
    label_18AD_03B1_18E81:
    CheckExternalEvents(cs10, 0x3B4);
    // MOV AX,word ptr [BP + 0xa] (18AD_03B1 / 0x18E81)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x3B7);
    // CMP word ptr [BP + 0x6],AX (18AD_03B4 / 0x18E84)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs10, 0x3B9);
    // JNZ 0x1000:8e9c (18AD_03B7 / 0x18E87)
    if(!ZeroFlag) {
      goto label_18AD_03CC_18E9C;
    }
    CheckExternalEvents(cs10, 0x3BC);
    // PUSH word ptr [BP + 0xe] (18AD_03B9 / 0x18E89)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x3BF);
    // PUSH word ptr [BP + 0xc] (18AD_03BC / 0x18E8C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x3C2);
    // PUSH word ptr [BP + 0x8] (18AD_03BF / 0x18E8F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x3C5);
    // PUSH word ptr [BP + 0x6] (18AD_03C2 / 0x18E92)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x3CA);
    // CALLF 0x1000:a4c0 (18AD_03C5 / 0x18E95)
    FarCall(cs10, 0x3CA, unknown_19EF_05D0_1A4C0);
    CheckExternalEvents(cs10, 0x3CC);
    // JMP 0x1000:8eb4 (18AD_03CA / 0x18E9A)
    goto label_18AD_03E4_18EB4;
    label_18AD_03CC_18E9C:
    CheckExternalEvents(cs10, 0x3CF);
    // MOV AX,word ptr [BP + 0xc] (18AD_03CC / 0x18E9C)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x3D2);
    // CMP word ptr [BP + 0x8],AX (18AD_03CF / 0x18E9F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs10, 0x3D4);
    // JNZ 0x1000:8eb7 (18AD_03D2 / 0x18EA2)
    if(!ZeroFlag) {
      goto label_18AD_03E7_18EB7;
    }
    CheckExternalEvents(cs10, 0x3D7);
    // PUSH word ptr [BP + 0xe] (18AD_03D4 / 0x18EA4)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x3DA);
    // PUSH word ptr [BP + 0xa] (18AD_03D7 / 0x18EA7)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x3DD);
    // PUSH word ptr [BP + 0x6] (18AD_03DA / 0x18EAA)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x3E0);
    // PUSH word ptr [BP + 0x8] (18AD_03DD / 0x18EAD)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x3E1);
    // PUSH CS (18AD_03E0 / 0x18EB0)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x3E4);
    // CALL 0x1000:8ebb (18AD_03E1 / 0x18EB1)
    NearCall(cs10, 0x3E4, unknown_18AD_03EB_18EBB);
    label_18AD_03E4_18EB4:
    CheckExternalEvents(cs10, 0x3E7);
    // ADD SP,0x8 (18AD_03E4 / 0x18EB4)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_03E7_18EB7:
    CheckExternalEvents(cs10, 0x3E9);
    // MOV SP,BP (18AD_03E7 / 0x18EB7)
    SP = BP;
    CheckExternalEvents(cs10, 0x3EA);
    // POP BP (18AD_03E9 / 0x18EB9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x3EB);
    // RETF  (18AD_03EA / 0x18EBA)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_03EB_18EBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_03EB_18EBB:
    CheckExternalEvents(cs10, 0x3EC);
    // PUSH BP (18AD_03EB / 0x18EBB)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x3EE);
    // MOV BP,SP (18AD_03EC / 0x18EBC)
    BP = SP;
    CheckExternalEvents(cs10, 0x3F1);
    // MOV AX,0x4 (18AD_03EE / 0x18EBE)
    AX = 0x4;
    CheckExternalEvents(cs10, 0x3F6);
    // CALLF 0x1000:cecc (18AD_03F1 / 0x18EC1)
    FarCall(cs10, 0x3F6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x3FA);
    // MOV BX,word ptr [0x4fba] (18AD_03F6 / 0x18EC6)
    BX = UInt16[DS, 0x4FBA];
    CheckExternalEvents(cs10, 0x3FC);
    // SHL BX,0x1 (18AD_03FA / 0x18ECA)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs10, 0x400);
    // MOV AX,word ptr [BX + 0x4fc4] (18AD_03FC / 0x18ECC)
    AX = UInt16[DS, (ushort)(BX + 0x4FC4)];
    CheckExternalEvents(cs10, 0x403);
    // MOV word ptr [BP + -0x4],AX (18AD_0400 / 0x18ED0)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs10, 0x405);
    // JMP 0x1000:8ef4 (18AD_0403 / 0x18ED3)
    goto label_18AD_0424_18EF4;
    label_18AD_0405_18ED5:
    CheckExternalEvents(cs10, 0x408);
    // MOV AX,word ptr [BP + 0xa] (18AD_0405 / 0x18ED5)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x40B);
    // CMP word ptr [BP + 0x8],AX (18AD_0408 / 0x18ED8)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs10, 0x40D);
    // JG 0x1000:8efc (18AD_040B / 0x18EDB)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_18AD_042C_18EFC;
    }
    CheckExternalEvents(cs10, 0x410);
    // PUSH word ptr [BP + 0xc] (18AD_040D / 0x18EDD)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x413);
    // PUSH word ptr [BP + 0x6] (18AD_0410 / 0x18EE0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x416);
    // PUSH word ptr [BP + 0x6] (18AD_0413 / 0x18EE3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x419);
    // PUSH word ptr [BP + 0x8] (18AD_0416 / 0x18EE6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x41C);
    // INC word ptr [BP + 0x8] (18AD_0419 / 0x18EE9)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x421);
    // CALLF 0x1000:a4c0 (18AD_041C / 0x18EEC)
    FarCall(cs10, 0x421, unknown_19EF_05D0_1A4C0);
    CheckExternalEvents(cs10, 0x424);
    // ADD SP,0x8 (18AD_0421 / 0x18EF1)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_0424_18EF4:
    CheckExternalEvents(cs10, 0x427);
    // MOV AX,word ptr [BP + -0x4] (18AD_0424 / 0x18EF4)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs10, 0x42A);
    // TEST word ptr [BP + 0x8],AX (18AD_0427 / 0x18EF7)
    Alu16.And(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs10, 0x42C);
    // JNZ 0x1000:8ed5 (18AD_042A / 0x18EFA)
    if(!ZeroFlag) {
      goto label_18AD_0405_18ED5;
    }
    label_18AD_042C_18EFC:
    CheckExternalEvents(cs10, 0x42F);
    // MOV AX,word ptr [BP + 0xa] (18AD_042C / 0x18EFC)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x432);
    // CMP word ptr [BP + 0x8],AX (18AD_042F / 0x18EFF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs10, 0x434);
    // JGE 0x1000:8f61 (18AD_0432 / 0x18F02)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_0491_18F61;
    }
    CheckExternalEvents(cs10, 0x437);
    // SUB AX,word ptr [BP + 0x8] (18AD_0434 / 0x18F04)
    // AX -= UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x43A);
    // MOV word ptr [BP + -0x2],AX (18AD_0437 / 0x18F07)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs10, 0x43F);
    // CMP word ptr [0x4fba],0x3 (18AD_043A / 0x18F0A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs10, 0x441);
    // JZ 0x1000:8f1e (18AD_043F / 0x18F0F)
    if(ZeroFlag) {
      goto label_18AD_044E_18F1E;
    }
    CheckExternalEvents(cs10, 0x445);
    // MOV BX,word ptr [0x4fba] (18AD_0441 / 0x18F11)
    BX = UInt16[DS, 0x4FBA];
    CheckExternalEvents(cs10, 0x447);
    // SHL BX,0x1 (18AD_0445 / 0x18F15)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs10, 0x44B);
    // MOV CL,byte ptr [BX + 0x4fd4] (18AD_0447 / 0x18F17)
    CL = UInt8[DS, (ushort)(BX + 0x4FD4)];
    CheckExternalEvents(cs10, 0x44E);
    // SAR word ptr [BP + -0x2],CL (18AD_044B / 0x18F1B)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Sar(UInt16[SS, (ushort)(BP - 0x2)], CL);
    label_18AD_044E_18F1E:
    CheckExternalEvents(cs10, 0x452);
    // CMP word ptr [BP + -0x2],0x0 (18AD_044E / 0x18F1E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs10, 0x454);
    // JZ 0x1000:8f38 (18AD_0452 / 0x18F22)
    if(ZeroFlag) {
      goto label_18AD_0468_18F38;
    }
    CheckExternalEvents(cs10, 0x457);
    // PUSH word ptr [BP + 0xc] (18AD_0454 / 0x18F24)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x45A);
    // PUSH word ptr [BP + -0x2] (18AD_0457 / 0x18F27)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs10, 0x45D);
    // PUSH word ptr [BP + 0x6] (18AD_045A / 0x18F2A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x460);
    // PUSH word ptr [BP + 0x8] (18AD_045D / 0x18F2D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x465);
    // CALLF 0x1000:a670 (18AD_0460 / 0x18F30)
    FarCall(cs10, 0x465, unknown_19EF_0780_1A670);
    CheckExternalEvents(cs10, 0x468);
    // ADD SP,0x8 (18AD_0465 / 0x18F35)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_0468_18F38:
    CheckExternalEvents(cs10, 0x46C);
    // MOV BX,word ptr [0x4fba] (18AD_0468 / 0x18F38)
    BX = UInt16[DS, 0x4FBA];
    CheckExternalEvents(cs10, 0x46E);
    // SHL BX,0x1 (18AD_046C / 0x18F3C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs10, 0x472);
    // MOV AX,word ptr [BX + 0x4fcc] (18AD_046E / 0x18F3E)
    AX = UInt16[DS, (ushort)(BX + 0x4FCC)];
    CheckExternalEvents(cs10, 0x475);
    // AND AX,word ptr [BP + 0xa] (18AD_0472 / 0x18F42)
    // AX &= UInt16[SS, (ushort)(BP + 0xA)];
    AX = Alu16.And(AX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x478);
    // MOV word ptr [BP + 0x8],AX (18AD_0475 / 0x18F45)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs10, 0x47A);
    // JMP 0x1000:8f61 (18AD_0478 / 0x18F48)
    goto label_18AD_0491_18F61;
    label_18AD_047A_18F4A:
    CheckExternalEvents(cs10, 0x47D);
    // PUSH word ptr [BP + 0xc] (18AD_047A / 0x18F4A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x480);
    // PUSH word ptr [BP + 0x6] (18AD_047D / 0x18F4D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x483);
    // PUSH word ptr [BP + 0x6] (18AD_0480 / 0x18F50)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x486);
    // PUSH word ptr [BP + 0x8] (18AD_0483 / 0x18F53)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x489);
    // INC word ptr [BP + 0x8] (18AD_0486 / 0x18F56)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x48E);
    // CALLF 0x1000:a4c0 (18AD_0489 / 0x18F59)
    FarCall(cs10, 0x48E, unknown_19EF_05D0_1A4C0);
    CheckExternalEvents(cs10, 0x491);
    // ADD SP,0x8 (18AD_048E / 0x18F5E)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_18AD_0491_18F61:
    CheckExternalEvents(cs10, 0x494);
    // MOV AX,word ptr [BP + 0xa] (18AD_0491 / 0x18F61)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x497);
    // CMP word ptr [BP + 0x8],AX (18AD_0494 / 0x18F64)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs10, 0x499);
    // JLE 0x1000:8f4a (18AD_0497 / 0x18F67)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_047A_18F4A;
    }
    CheckExternalEvents(cs10, 0x49B);
    // MOV SP,BP (18AD_0499 / 0x18F69)
    SP = BP;
    CheckExternalEvents(cs10, 0x49C);
    // POP BP (18AD_049B / 0x18F6B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x49D);
    // RETF  (18AD_049C / 0x18F6C)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_049D_18F6D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_049D_18F6D:
    CheckExternalEvents(cs10, 0x49E);
    // PUSH BP (18AD_049D / 0x18F6D)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x4A0);
    // MOV BP,SP (18AD_049E / 0x18F6E)
    BP = SP;
    CheckExternalEvents(cs10, 0x4A3);
    // MOV AX,0x4 (18AD_04A0 / 0x18F70)
    AX = 0x4;
    CheckExternalEvents(cs10, 0x4A8);
    // CALLF 0x1000:cecc (18AD_04A3 / 0x18F73)
    FarCall(cs10, 0x4A8, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x4AB);
    // LES BX,[BP + 0x6] (18AD_04A8 / 0x18F78)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs10, 0x4AE);
    // INC word ptr [BP + 0x6] (18AD_04AB / 0x18F7B)
    UInt16[SS, (ushort)(BP + 0x6)]++;
    CheckExternalEvents(cs10, 0x4B2);
    // CMP byte ptr ES:[BX],0x1 (18AD_04AE / 0x18F7E)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x1);
    CheckExternalEvents(cs10, 0x4B4);
    // JNZ 0x1000:8f95 (18AD_04B2 / 0x18F82)
    if(!ZeroFlag) {
      goto label_18AD_04C5_18F95;
    }
    CheckExternalEvents(cs10, 0x4B7);
    // PUSH word ptr [BP + 0xc] (18AD_04B4 / 0x18F84)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x4BA);
    // PUSH word ptr [BP + 0xa] (18AD_04B7 / 0x18F87)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x4BB);
    // PUSH ES (18AD_04BA / 0x18F8A)
    Stack.Push16(ES);
    CheckExternalEvents(cs10, 0x4BE);
    // PUSH word ptr [BP + 0x6] (18AD_04BB / 0x18F8B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x4C3);
    // CALLF 0x1000:c1e8 (18AD_04BE / 0x18F8E)
    FarCall(cs10, 0x4C3, unknown_19EF_22F8_1C1E8);
    CheckExternalEvents(cs10, 0x4C5);
    // JMP 0x1000:8fa6 (18AD_04C3 / 0x18F93)
    goto label_18AD_04D6_18FA6;
    label_18AD_04C5_18F95:
    CheckExternalEvents(cs10, 0x4C8);
    // PUSH word ptr [BP + 0xc] (18AD_04C5 / 0x18F95)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x4CB);
    // PUSH word ptr [BP + 0xa] (18AD_04C8 / 0x18F98)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x4CE);
    // PUSH word ptr [BP + 0x8] (18AD_04CB / 0x18F9B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x4D1);
    // PUSH word ptr [BP + 0x6] (18AD_04CE / 0x18F9E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x4D6);
    // CALLF 0x1000:c258 (18AD_04D1 / 0x18FA1)
    FarCall(cs10, 0x4D6, unknown_19EF_2368_1C258);
    label_18AD_04D6_18FA6:
    CheckExternalEvents(cs10, 0x4D9);
    // ADD SP,0x8 (18AD_04D6 / 0x18FA6)
    SP += 0x8;
    CheckExternalEvents(cs10, 0x4DE);
    // CMP word ptr [0x4fba],0x0 (18AD_04D9 / 0x18FA9)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs10, 0x4E0);
    // JNZ 0x1000:8ff1 (18AD_04DE / 0x18FAE)
    if(!ZeroFlag) {
      goto label_18AD_0521_18FF1;
    }
    CheckExternalEvents(cs10, 0x4E5);
    // MOV word ptr [BP + -0x4],0x50 (18AD_04E0 / 0x18FB0)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x50;
    CheckExternalEvents(cs10, 0x4EA);
    // CMP word ptr [0x4fbc],0x0 (18AD_04E5 / 0x18FB5)
    Alu16.Sub(UInt16[DS, 0x4FBC], 0x0);
    CheckExternalEvents(cs10, 0x4EC);
    // JZ 0x1000:8fc1 (18AD_04EA / 0x18FBA)
    if(ZeroFlag) {
      goto label_18AD_04F1_18FC1;
    }
    CheckExternalEvents(cs10, 0x4F1);
    // MOV word ptr [BP + -0x4],0x4 (18AD_04EC / 0x18FBC)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x4;
    label_18AD_04F1_18FC1:
    CheckExternalEvents(cs10, 0x4F4);
    // MOV AX,0x3e80 (18AD_04F1 / 0x18FC1)
    AX = 0x3E80;
    CheckExternalEvents(cs10, 0x4F5);
    // PUSH AX (18AD_04F4 / 0x18FC4)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x4F8);
    // PUSH word ptr [BP + -0x4] (18AD_04F5 / 0x18FC5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs10, 0x4FB);
    // PUSH word ptr [BP + 0xc] (18AD_04F8 / 0x18FC8)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x4FE);
    // PUSH word ptr [BP + 0xa] (18AD_04FB / 0x18FCB)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x501);
    // PUSH word ptr [BP + 0xc] (18AD_04FE / 0x18FCE)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x504);
    // PUSH word ptr [BP + 0xa] (18AD_0501 / 0x18FD1)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x509);
    // CALLF 0x1000:a053 (18AD_0504 / 0x18FD4)
    FarCall(cs10, 0x509, ghidra_guess_1000_A053_1A053);
    CheckExternalEvents(cs10, 0x50C);
    // ADD SP,0xc (18AD_0509 / 0x18FD9)
    SP += 0xC;
    CheckExternalEvents(cs10, 0x511);
    // CMP word ptr [0x4fbc],0x0 (18AD_050C / 0x18FDC)
    Alu16.Sub(UInt16[DS, 0x4FBC], 0x0);
    CheckExternalEvents(cs10, 0x513);
    // JZ 0x1000:8ff1 (18AD_0511 / 0x18FE1)
    if(ZeroFlag) {
      goto label_18AD_0521_18FF1;
    }
    CheckExternalEvents(cs10, 0x516);
    // PUSH word ptr [BP + 0xc] (18AD_0513 / 0x18FE3)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x519);
    // PUSH word ptr [BP + 0xa] (18AD_0516 / 0x18FE6)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x51E);
    // CALLF 0x1000:a0c7 (18AD_0519 / 0x18FE9)
    FarCall(cs10, 0x51E, ghidra_guess_1000_A0C7_1A0C7);
    CheckExternalEvents(cs10, 0x521);
    // ADD SP,0x4 (18AD_051E / 0x18FEE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_18AD_0521_18FF1:
    CheckExternalEvents(cs10, 0x523);
    // MOV SP,BP (18AD_0521 / 0x18FF1)
    SP = BP;
    CheckExternalEvents(cs10, 0x524);
    // POP BP (18AD_0523 / 0x18FF3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x525);
    // RETF  (18AD_0524 / 0x18FF4)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0525_18FF5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0525_18FF5:
    CheckExternalEvents(cs10, 0x526);
    // PUSH BP (18AD_0525 / 0x18FF5)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x528);
    // MOV BP,SP (18AD_0526 / 0x18FF6)
    BP = SP;
    CheckExternalEvents(cs10, 0x52B);
    // MOV AX,0x4 (18AD_0528 / 0x18FF8)
    AX = 0x4;
    CheckExternalEvents(cs10, 0x530);
    // CALLF 0x1000:cecc (18AD_052B / 0x18FFB)
    FarCall(cs10, 0x530, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x531);
    // PUSH SI (18AD_0530 / 0x19000)
    Stack.Push16(SI);
    CheckExternalEvents(cs10, 0x536);
    // CMP word ptr [0x4fba],0x1 (18AD_0531 / 0x19001)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x1);
    CheckExternalEvents(cs10, 0x538);
    // JNZ 0x1000:9026 (18AD_0536 / 0x19006)
    if(!ZeroFlag) {
      goto label_18AD_0556_19026;
    }
    CheckExternalEvents(cs10, 0x53C);
    // MOV ES,word ptr [0x56ee] (18AD_0538 / 0x19008)
    ES = UInt16[DS, 0x56EE];
    CheckExternalEvents(cs10, 0x541);
    // PUSH word ptr ES:[0x32ac] (18AD_053C / 0x1900C)
    Stack.Push16(UInt16[ES, 0x32AC]);
    CheckExternalEvents(cs10, 0x546);
    // CALLF 0x1000:aa30 (18AD_0541 / 0x19011)
    FarCall(cs10, 0x546, unknown_19EF_0B40_1AA30);
    CheckExternalEvents(cs10, 0x549);
    // ADD SP,0x2 (18AD_0546 / 0x19016)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs10, 0x54C);
    // PUSH word ptr [BP + 0x8] (18AD_0549 / 0x19019)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x54F);
    // PUSH word ptr [BP + 0x6] (18AD_054C / 0x1901C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x554);
    // CALLF 0x1000:ca35 (18AD_054F / 0x1901F)
    FarCall(cs10, 0x554, ghidra_guess_1000_CA35_1CA35);
    CheckExternalEvents(cs10, 0x556);
    // JMP 0x1000:9084 (18AD_0554 / 0x19024)
    goto label_18AD_05B4_19084;
    label_18AD_0556_19026:
    CheckExternalEvents(cs10, 0x55B);
    // CMP word ptr [0x4fba],0x2 (18AD_0556 / 0x19026)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs10, 0x55D);
    // JNZ 0x1000:9072 (18AD_055B / 0x1902B)
    if(!ZeroFlag) {
      goto label_18AD_05A2_19072;
    }
    CheckExternalEvents(cs10, 0x561);
    // MOV ES,word ptr [0x56ee] (18AD_055D / 0x1902D)
    ES = UInt16[DS, 0x56EE];
    CheckExternalEvents(cs10, 0x566);
    // PUSH word ptr ES:[0x32ac] (18AD_0561 / 0x19031)
    Stack.Push16(UInt16[ES, 0x32AC]);
    CheckExternalEvents(cs10, 0x56B);
    // CALLF 0x1000:aa30 (18AD_0566 / 0x19036)
    FarCall(cs10, 0x56B, unknown_19EF_0B40_1AA30);
    CheckExternalEvents(cs10, 0x56E);
    // ADD SP,0x2 (18AD_056B / 0x1903B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs10, 0x573);
    // MOV word ptr [BP + -0x2],0x0 (18AD_056E / 0x1903E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs10, 0x575);
    // JMP 0x1000:9048 (18AD_0573 / 0x19043)
    goto label_18AD_0578_19048;
    label_18AD_0575_19045:
    CheckExternalEvents(cs10, 0x578);
    // INC word ptr [BP + -0x2] (18AD_0575 / 0x19045)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_18AD_0578_19048:
    CheckExternalEvents(cs10, 0x57C);
    // CMP word ptr [BP + -0x2],0x10 (18AD_0578 / 0x19048)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs10, 0x57E);
    // JGE 0x1000:9087 (18AD_057C / 0x1904C)
    if(SignFlag == OverflowFlag) {
      goto label_18AD_05B7_19087;
    }
    CheckExternalEvents(cs10, 0x581);
    // MOV BX,word ptr [BP + -0x2] (18AD_057E / 0x1904E)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs10, 0x584);
    // LES SI,[BP + 0x6] (18AD_0581 / 0x19051)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs10, 0x587);
    // MOV AL,byte ptr ES:[BX + SI] (18AD_0584 / 0x19054)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs10, 0x588);
    // CBW  (18AD_0587 / 0x19057)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs10, 0x58B);
    // MOV word ptr [BP + -0x4],AX (18AD_0588 / 0x19058)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs10, 0x58E);
    // CMP AX,0x7 (18AD_058B / 0x1905B)
    Alu16.Sub(AX, 0x7);
    CheckExternalEvents(cs10, 0x590);
    // JLE 0x1000:9064 (18AD_058E / 0x1905E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_18AD_0594_19064;
    }
    CheckExternalEvents(cs10, 0x594);
    // ADD word ptr [BP + -0x4],0x8 (18AD_0590 / 0x19060)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x8;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x8);
    label_18AD_0594_19064:
    CheckExternalEvents(cs10, 0x597);
    // PUSH word ptr [BP + -0x4] (18AD_0594 / 0x19064)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs10, 0x598);
    // PUSH BX (18AD_0597 / 0x19067)
    Stack.Push16(BX);
    CheckExternalEvents(cs10, 0x59D);
    // CALLF 0x1000:a11a (18AD_0598 / 0x19068)
    FarCall(cs10, 0x59D, ghidra_guess_1000_A11A_1A11A);
    CheckExternalEvents(cs10, 0x5A0);
    // ADD SP,0x4 (18AD_059D / 0x1906D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs10, 0x5A2);
    // JMP 0x1000:9045 (18AD_05A0 / 0x19070)
    goto label_18AD_0575_19045;
    label_18AD_05A2_19072:
    CheckExternalEvents(cs10, 0x5A7);
    // CMP word ptr [0x4fba],0x3 (18AD_05A2 / 0x19072)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs10, 0x5A9);
    // JNZ 0x1000:9087 (18AD_05A7 / 0x19077)
    if(!ZeroFlag) {
      goto label_18AD_05B7_19087;
    }
    CheckExternalEvents(cs10, 0x5AC);
    // PUSH word ptr [BP + 0x8] (18AD_05A9 / 0x19079)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x5AF);
    // PUSH word ptr [BP + 0x6] (18AD_05AC / 0x1907C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x5B4);
    // CALLF 0x1000:aede (18AD_05AF / 0x1907F)
    FarCall(cs10, 0x5B4, unknown_19EF_0FEE_1AEDE);
    label_18AD_05B4_19084:
    CheckExternalEvents(cs10, 0x5B7);
    // ADD SP,0x4 (18AD_05B4 / 0x19084)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_18AD_05B7_19087:
    CheckExternalEvents(cs10, 0x5B8);
    // POP SI (18AD_05B7 / 0x19087)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x5BA);
    // MOV SP,BP (18AD_05B8 / 0x19088)
    SP = BP;
    CheckExternalEvents(cs10, 0x5BB);
    // POP BP (18AD_05BA / 0x1908A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x5BC);
    // RETF  (18AD_05BB / 0x1908B)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_05BC_1908C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_05BC_1908C:
    CheckExternalEvents(cs10, 0x5BD);
    // PUSH BP (18AD_05BC / 0x1908C)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x5BF);
    // MOV BP,SP (18AD_05BD / 0x1908D)
    BP = SP;
    CheckExternalEvents(cs10, 0x5C2);
    // MOV AX,0x6 (18AD_05BF / 0x1908F)
    AX = 0x6;
    CheckExternalEvents(cs10, 0x5C7);
    // CALLF 0x1000:cecc (18AD_05C2 / 0x19092)
    FarCall(cs10, 0x5C7, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x5CA);
    // MOV AX,word ptr [BP + 0x6] (18AD_05C7 / 0x19097)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs10, 0x5CD);
    // MOV word ptr [BP + -0x2],AX (18AD_05CA / 0x1909A)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs10, 0x5D1);
    // CMP word ptr [BP + 0x8],0x0 (18AD_05CD / 0x1909D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs10, 0x5D3);
    // JL 0x1000:90ca (18AD_05D1 / 0x190A1)
    if(SignFlag != OverflowFlag) {
      goto label_18AD_05FA_190CA;
    }
    CheckExternalEvents(cs10, 0x5D5);
    // JG 0x1000:90aa (18AD_05D3 / 0x190A3)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_18AD_05DA_190AA;
    }
    CheckExternalEvents(cs10, 0x5D8);
    // CMP AX,0xffff (18AD_05D5 / 0x190A5)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs10, 0x5DA);
    // JBE 0x1000:90ca (18AD_05D8 / 0x190A8)
    if(CarryFlag || ZeroFlag) {
      goto label_18AD_05FA_190CA;
    }
    label_18AD_05DA_190AA:
    CheckExternalEvents(cs10, 0x5DC);
    // SUB AX,AX (18AD_05DA / 0x190AA)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0x5DD);
    // PUSH AX (18AD_05DC / 0x190AC)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x5E0);
    // MOV AX,0xf (18AD_05DD / 0x190AD)
    AX = 0xF;
    CheckExternalEvents(cs10, 0x5E1);
    // PUSH AX (18AD_05E0 / 0x190B0)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x5E4);
    // MOV AX,0xa (18AD_05E1 / 0x190B1)
    AX = 0xA;
    CheckExternalEvents(cs10, 0x5E5);
    // PUSH AX (18AD_05E4 / 0x190B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x5E7);
    // SUB AX,AX (18AD_05E5 / 0x190B5)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0x5E8);
    // PUSH AX (18AD_05E7 / 0x190B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x5EB);
    // MOV AX,0x4fda (18AD_05E8 / 0x190B8)
    AX = 0x4FDA;
    CheckExternalEvents(cs10, 0x5EC);
    // PUSH DS (18AD_05EB / 0x190BB)
    Stack.Push16(DS);
    CheckExternalEvents(cs10, 0x5ED);
    // PUSH AX (18AD_05EC / 0x190BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x5EE);
    // PUSH CS (18AD_05ED / 0x190BD)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x5F1);
    // CALL 0x1000:8ba5 (18AD_05EE / 0x190BE)
    NearCall(cs10, 0x5F1, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs10, 0x5F4);
    // ADD SP,0xc (18AD_05F1 / 0x190C1)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs10, 0x5F5);
    // PUSH CS (18AD_05F4 / 0x190C4)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x5F8);
    // CALL 0x1000:8d29 (18AD_05F5 / 0x190C5)
    NearCall(cs10, 0x5F8, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs10, 0x5FA);
    // JMP 0x1000:90db (18AD_05F8 / 0x190C8)
    goto label_18AD_060B_190DB;
    label_18AD_05FA_190CA:
    CheckExternalEvents(cs10, 0x5FD);
    // PUSH word ptr [BP + -0x2] (18AD_05FA / 0x190CA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs10, 0x602);
    // CALLF 0x1000:d725 (18AD_05FD / 0x190CD)
    FarCall(cs10, 0x602, unknown_19EF_3835_1D725);
    CheckExternalEvents(cs10, 0x605);
    // ADD SP,0x2 (18AD_0602 / 0x190D2)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs10, 0x608);
    // MOV word ptr [BP + -0x6],AX (18AD_0605 / 0x190D5)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs10, 0x60B);
    // MOV word ptr [BP + -0x4],DX (18AD_0608 / 0x190D8)
    UInt16[SS, (ushort)(BP - 0x4)] = DX;
    label_18AD_060B_190DB:
    CheckExternalEvents(cs10, 0x60E);
    // MOV AX,word ptr [BP + -0x6] (18AD_060B / 0x190DB)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs10, 0x611);
    // OR AX,word ptr [BP + -0x4] (18AD_060E / 0x190DE)
    // AX |= UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Or(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs10, 0x613);
    // JNZ 0x1000:9101 (18AD_0611 / 0x190E1)
    if(!ZeroFlag) {
      goto label_18AD_0631_19101;
    }
    CheckExternalEvents(cs10, 0x615);
    // SUB AX,AX (18AD_0613 / 0x190E3)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0x616);
    // PUSH AX (18AD_0615 / 0x190E5)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x619);
    // MOV AX,0xf (18AD_0616 / 0x190E6)
    AX = 0xF;
    CheckExternalEvents(cs10, 0x61A);
    // PUSH AX (18AD_0619 / 0x190E9)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x61D);
    // MOV AX,0xa (18AD_061A / 0x190EA)
    AX = 0xA;
    CheckExternalEvents(cs10, 0x61E);
    // PUSH AX (18AD_061D / 0x190ED)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x620);
    // SUB AX,AX (18AD_061E / 0x190EE)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0x621);
    // PUSH AX (18AD_0620 / 0x190F0)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x624);
    // MOV AX,0x4fe9 (18AD_0621 / 0x190F1)
    AX = 0x4FE9;
    CheckExternalEvents(cs10, 0x625);
    // PUSH DS (18AD_0624 / 0x190F4)
    Stack.Push16(DS);
    CheckExternalEvents(cs10, 0x626);
    // PUSH AX (18AD_0625 / 0x190F5)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x627);
    // PUSH CS (18AD_0626 / 0x190F6)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x62A);
    // CALL 0x1000:8ba5 (18AD_0627 / 0x190F7)
    NearCall(cs10, 0x62A, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs10, 0x62D);
    // ADD SP,0xc (18AD_062A / 0x190FA)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs10, 0x62E);
    // PUSH CS (18AD_062D / 0x190FD)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x631);
    // CALL 0x1000:8d29 (18AD_062E / 0x190FE)
    NearCall(cs10, 0x631, unknown_18AD_0259_18D29);
    label_18AD_0631_19101:
    CheckExternalEvents(cs10, 0x634);
    // MOV AX,word ptr [BP + -0x6] (18AD_0631 / 0x19101)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs10, 0x637);
    // MOV DX,word ptr [BP + -0x4] (18AD_0634 / 0x19104)
    DX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs10, 0x639);
    // MOV SP,BP (18AD_0637 / 0x19107)
    SP = BP;
    CheckExternalEvents(cs10, 0x63A);
    // POP BP (18AD_0639 / 0x19109)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x63B);
    // RETF  (18AD_063A / 0x1910A)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_063B_1910B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_063B_1910B:
    CheckExternalEvents(cs10, 0x63C);
    // PUSH BP (18AD_063B / 0x1910B)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x63E);
    // MOV BP,SP (18AD_063C / 0x1910C)
    BP = SP;
    CheckExternalEvents(cs10, 0x641);
    // MOV AX,0x6 (18AD_063E / 0x1910E)
    AX = 0x6;
    CheckExternalEvents(cs10, 0x646);
    // CALLF 0x1000:cecc (18AD_0641 / 0x19111)
    FarCall(cs10, 0x646, unknown_19EF_2FDC_1CECC);
    label_18AD_0646_19116:
    CheckExternalEvents(cs10, 0x64B);
    // MOV word ptr [BP + -0x4],0x0 (18AD_0646 / 0x19116)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs10, 0x64E);
    // MOV AX,0x8000 (18AD_064B / 0x1911B)
    AX = 0x8000;
    CheckExternalEvents(cs10, 0x64F);
    // PUSH AX (18AD_064E / 0x1911E)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x652);
    // PUSH word ptr [BP + 0x8] (18AD_064F / 0x1911F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x655);
    // PUSH word ptr [BP + 0x6] (18AD_0652 / 0x19122)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x65A);
    // CALLF 0x1000:d2c0 (18AD_0655 / 0x19125)
    FarCall(cs10, 0x65A, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs10, 0x65D);
    // ADD SP,0x6 (18AD_065A / 0x1912A)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs10, 0x660);
    // MOV word ptr [BP + -0x6],AX (18AD_065D / 0x1912D)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs10, 0x663);
    // CMP AX,0xffff (18AD_0660 / 0x19130)
    Alu16.Sub(AX, 0xFFFF);
    CheckExternalEvents(cs10, 0x665);
    // JZ 0x1000:916a (18AD_0663 / 0x19133)
    if(ZeroFlag) {
      goto label_18AD_069A_1916A;
    }
    CheckExternalEvents(cs10, 0x668);
    // MOV AX,0x2 (18AD_0665 / 0x19135)
    AX = 0x2;
    CheckExternalEvents(cs10, 0x669);
    // PUSH AX (18AD_0668 / 0x19138)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x66C);
    // LEA AX,[BP + -0x2] (18AD_0669 / 0x19139)
    AX = (ushort)(BP - 0x2);
    CheckExternalEvents(cs10, 0x66D);
    // PUSH SS (18AD_066C / 0x1913C)
    Stack.Push16(SS);
    CheckExternalEvents(cs10, 0x66E);
    // PUSH AX (18AD_066D / 0x1913D)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x671);
    // PUSH word ptr [BP + -0x6] (18AD_066E / 0x1913E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs10, 0x676);
    // CALLF 0x1000:d470 (18AD_0671 / 0x19141)
    FarCall(cs10, 0x676, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs10, 0x679);
    // ADD SP,0x8 (18AD_0676 / 0x19146)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs10, 0x67C);
    // PUSH word ptr [BP + -0x2] (18AD_0679 / 0x19149)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs10, 0x67F);
    // PUSH word ptr [BP + 0xc] (18AD_067C / 0x1914C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x682);
    // PUSH word ptr [BP + 0xa] (18AD_067F / 0x1914F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x685);
    // PUSH word ptr [BP + -0x6] (18AD_0682 / 0x19152)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs10, 0x68A);
    // CALLF 0x1000:d470 (18AD_0685 / 0x19155)
    FarCall(cs10, 0x68A, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs10, 0x68D);
    // ADD SP,0x8 (18AD_068A / 0x1915A)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs10, 0x690);
    // PUSH word ptr [BP + -0x6] (18AD_068D / 0x1915D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs10, 0x695);
    // CALLF 0x1000:d226 (18AD_0690 / 0x19160)
    FarCall(cs10, 0x695, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs10, 0x698);
    // ADD SP,0x2 (18AD_0695 / 0x19165)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs10, 0x69A);
    // JMP 0x1000:916f (18AD_0698 / 0x19168)
    goto label_18AD_069F_1916F;
    label_18AD_069A_1916A:
    CheckExternalEvents(cs10, 0x69F);
    // MOV word ptr [BP + -0x4],0x1 (18AD_069A / 0x1916A)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_18AD_069F_1916F:
    CheckExternalEvents(cs10, 0x6A3);
    // CMP word ptr [BP + -0x4],0x0 (18AD_069F / 0x1916F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs10, 0x6A5);
    // JZ 0x1000:9186 (18AD_06A3 / 0x19173)
    if(ZeroFlag) {
      goto label_18AD_06B6_19186;
    }
    CheckExternalEvents(cs10, 0x6A9);
    // MOV ES,word ptr [0x56fa] (18AD_06A5 / 0x19175)
    ES = UInt16[DS, 0x56FA];
    CheckExternalEvents(cs10, 0x6AE);
    // PUSH word ptr ES:[0x14e] (18AD_06A9 / 0x19179)
    Stack.Push16(UInt16[ES, 0x14E]);
    CheckExternalEvents(cs10, 0x6B3);
    // CALLF 0x0000:4013 (18AD_06AE / 0x1917E)
    FarCall(cs10, 0x6B3, ghidra_guess_0000_4013_04013);
    CheckExternalEvents(cs10, 0x6B6);
    // ADD SP,0x2 (18AD_06B3 / 0x19183)
    SP += 0x2;
    label_18AD_06B6_19186:
    CheckExternalEvents(cs10, 0x6BA);
    // CMP word ptr [BP + -0x4],0x0 (18AD_06B6 / 0x19186)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs10, 0x6BC);
    // JNZ 0x1000:9116 (18AD_06BA / 0x1918A)
    if(!ZeroFlag) {
      goto label_18AD_0646_19116;
    }
    CheckExternalEvents(cs10, 0x6BF);
    // MOV AX,0x1 (18AD_06BC / 0x1918C)
    AX = 0x1;
    CheckExternalEvents(cs10, 0x6C1);
    // MOV SP,BP (18AD_06BF / 0x1918F)
    SP = BP;
    CheckExternalEvents(cs10, 0x6C2);
    // POP BP (18AD_06C1 / 0x19191)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x6C3);
    // RETF  (18AD_06C2 / 0x19192)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_06C3_19193(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_06C3_19193:
    CheckExternalEvents(cs10, 0x6C5);
    // XOR AX,AX (18AD_06C3 / 0x19193)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs10, 0x6CA);
    // CALLF 0x1000:cecc (18AD_06C5 / 0x19195)
    FarCall(cs10, 0x6CA, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x6CF);
    // CMP word ptr [0x4fba],0x2 (18AD_06CA / 0x1919A)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x2);
    CheckExternalEvents(cs10, 0x6D1);
    // JNZ 0x1000:91c6 (18AD_06CF / 0x1919F)
    if(!ZeroFlag) {
      goto label_18AD_06F6_191C6;
    }
    CheckExternalEvents(cs10, 0x6D4);
    // MOV AX,0xc8 (18AD_06D1 / 0x191A1)
    AX = 0xC8;
    CheckExternalEvents(cs10, 0x6D5);
    // PUSH AX (18AD_06D4 / 0x191A4)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x6D8);
    // MOV AX,0x1b (18AD_06D5 / 0x191A5)
    AX = 0x1B;
    CheckExternalEvents(cs10, 0x6D9);
    // PUSH AX (18AD_06D8 / 0x191A8)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x6DB);
    // SUB AX,AX (18AD_06D9 / 0x191A9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0x6DC);
    // PUSH AX (18AD_06DB / 0x191AB)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x6DF);
    // MOV AX,0xd (18AD_06DC / 0x191AC)
    AX = 0xD;
    CheckExternalEvents(cs10, 0x6E0);
    // PUSH AX (18AD_06DF / 0x191AF)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x6E2);
    // SUB AX,AX (18AD_06E0 / 0x191B0)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs10, 0x6E5);
    // MOV DX,0xa000 (18AD_06E2 / 0x191B2)
    DX = 0xA000;
    CheckExternalEvents(cs10, 0x6E6);
    // PUSH DX (18AD_06E5 / 0x191B5)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0x6E7);
    // PUSH AX (18AD_06E6 / 0x191B6)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x6EA);
    // MOV DX,0xac00 (18AD_06E7 / 0x191B7)
    DX = 0xAC00;
    CheckExternalEvents(cs10, 0x6EB);
    // PUSH DX (18AD_06EA / 0x191BA)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0x6EC);
    // PUSH AX (18AD_06EB / 0x191BB)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x6F1);
    // CALLF 0x1000:c34c (18AD_06EC / 0x191BC)
    FarCall(cs10, 0x6F1, unknown_19EF_245C_1C34C);
    CheckExternalEvents(cs10, 0x6F4);
    // ADD SP,0x10 (18AD_06F1 / 0x191C1)
    // SP += 0x10;
    SP = Alu16.Add(SP, 0x10);
    CheckExternalEvents(cs10, 0x6F6);
    // JMP 0x1000:91d9 (18AD_06F4 / 0x191C4)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs10, 0x70A);
    // RETF  (18AD_0709 / 0x191D9)
    return FarRet();
    label_18AD_06F6_191C6:
    CheckExternalEvents(cs10, 0x6FB);
    // CMP word ptr [0x4fba],0x3 (18AD_06F6 / 0x191C6)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x3);
    CheckExternalEvents(cs10, 0x6FD);
    // JNZ 0x1000:91d4 (18AD_06FB / 0x191CB)
    if(!ZeroFlag) {
      goto label_18AD_0704_191D4;
    }
    CheckExternalEvents(cs10, 0x702);
    // CALLF 0x1000:bc2a (18AD_06FD / 0x191CD)
    FarCall(cs10, 0x702, unknown_19EF_1D3A_1BC2A);
    CheckExternalEvents(cs10, 0x704);
    // JMP 0x1000:91d9 (18AD_0702 / 0x191D2)
    // JMP target is RETF, inlining.
    CheckExternalEvents(cs10, 0x70A);
    // RETF  (18AD_0709 / 0x191D9)
    return FarRet();
    label_18AD_0704_191D4:
    CheckExternalEvents(cs10, 0x709);
    // CALLF 0x1000:bba8 (18AD_0704 / 0x191D4)
    FarCall(cs10, 0x709, ghidra_guess_1000_BBA8_1BBA8);
    label_18AD_0709_191D9:
    CheckExternalEvents(cs10, 0x70A);
    // RETF  (18AD_0709 / 0x191D9)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_070A_191DA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_070A_191DA:
    CheckExternalEvents(cs10, 0x70B);
    // PUSH BP (18AD_070A / 0x191DA)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x70D);
    // MOV BP,SP (18AD_070B / 0x191DB)
    BP = SP;
    CheckExternalEvents(cs10, 0x710);
    // MOV AX,0x8 (18AD_070D / 0x191DD)
    AX = 0x8;
    CheckExternalEvents(cs10, 0x715);
    // CALLF 0x1000:cecc (18AD_0710 / 0x191E0)
    FarCall(cs10, 0x715, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x716);
    // PUSH SI (18AD_0715 / 0x191E5)
    Stack.Push16(SI);
    CheckExternalEvents(cs10, 0x71B);
    // MOV word ptr [BP + -0x6],0x4 (18AD_0716 / 0x191E6)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x4;
    CheckExternalEvents(cs10, 0x71E);
    // MOV AX,word ptr [BP + 0xc] (18AD_071B / 0x191EB)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x721);
    // IMUL word ptr [BP + 0xe] (18AD_071E / 0x191EE)
    int resImul18AD_071E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xE)]);
    AX = (ushort)(resImul18AD_071E);
    DX = (ushort)(resImul18AD_071E >> 16);
    CheckExternalEvents(cs10, 0x724);
    // MUL word ptr [BP + -0x6] (18AD_0721 / 0x191F1)
    uint resMul18AD_0721 = Alu16.Mul(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resMul18AD_0721);
    DX = (ushort)(resMul18AD_0721 >> 16);
    CheckExternalEvents(cs10, 0x727);
    // MOV word ptr [BP + -0x6],AX (18AD_0724 / 0x191F4)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs10, 0x72A);
    // ADD AX,0x4 (18AD_0727 / 0x191F7)
    AX += 0x4;
    CheckExternalEvents(cs10, 0x72C);
    // SUB CX,CX (18AD_072A / 0x191FA)
    // CX -= CX;
    CX = Alu16.Sub(CX, CX);
    CheckExternalEvents(cs10, 0x72D);
    // PUSH CX (18AD_072C / 0x191FC)
    Stack.Push16(CX);
    CheckExternalEvents(cs10, 0x72E);
    // PUSH AX (18AD_072D / 0x191FD)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x72F);
    // PUSH CS (18AD_072E / 0x191FE)
    Stack.Push16(cs10);
    CheckExternalEvents(cs10, 0x732);
    // CALL 0x1000:908c (18AD_072F / 0x191FF)
    NearCall(cs10, 0x732, unknown_18AD_05BC_1908C);
    CheckExternalEvents(cs10, 0x735);
    // ADD SP,0x4 (18AD_0732 / 0x19202)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs10, 0x738);
    // MOV BX,word ptr [BP + 0x6] (18AD_0735 / 0x19205)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs10, 0x73A);
    // SHL BX,0x1 (18AD_0738 / 0x19208)
    BX <<= 0x1;
    CheckExternalEvents(cs10, 0x73C);
    // SHL BX,0x1 (18AD_073A / 0x1920A)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs10, 0x740);
    // MOV ES,word ptr [0x56fc] (18AD_073C / 0x1920C)
    ES = UInt16[DS, 0x56FC];
    CheckExternalEvents(cs10, 0x745);
    // MOV word ptr ES:[BX + 0x39fa],AX (18AD_0740 / 0x19210)
    UInt16[ES, (ushort)(BX + 0x39FA)] = AX;
    CheckExternalEvents(cs10, 0x74A);
    // MOV word ptr ES:[BX + 0x39fc],DX (18AD_0745 / 0x19215)
    UInt16[ES, (ushort)(BX + 0x39FC)] = DX;
    CheckExternalEvents(cs10, 0x74D);
    // MOV word ptr [BP + -0x4],AX (18AD_074A / 0x1921A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs10, 0x750);
    // MOV word ptr [BP + -0x2],DX (18AD_074D / 0x1921D)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs10, 0x752);
    // OR AX,DX (18AD_0750 / 0x19220)
    // AX |= DX;
    AX = Alu16.Or(AX, DX);
    CheckExternalEvents(cs10, 0x754);
    // JNZ 0x1000:9227 (18AD_0752 / 0x19222)
    if(!ZeroFlag) {
      goto label_18AD_0757_19227;
    }
    CheckExternalEvents(cs10, 0x757);
    // JMP 0x1000:92df (18AD_0754 / 0x19224)
    goto label_18AD_080F_192DF;
    label_18AD_0757_19227:
    CheckExternalEvents(cs10, 0x75A);
    // LES BX,[BP + -0x4] (18AD_0757 / 0x19227)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs10, 0x75D);
    // MOV AL,byte ptr [BP + 0xe] (18AD_075A / 0x1922A)
    AL = UInt8[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs10, 0x75F);
    // DEC AL (18AD_075D / 0x1922D)
    AL = Alu8.Dec(AL);
    CheckExternalEvents(cs10, 0x763);
    // MOV byte ptr ES:[BX + 0x1],AL (18AD_075F / 0x1922F)
    UInt8[ES, (ushort)(BX + 0x1)] = AL;
    CheckExternalEvents(cs10, 0x766);
    // LES BX,[BP + -0x4] (18AD_0763 / 0x19233)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs10, 0x769);
    // MOV AL,byte ptr [BP + 0xc] (18AD_0766 / 0x19236)
    AL = UInt8[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x76D);
    // MOV byte ptr ES:[BX + 0x2],AL (18AD_0769 / 0x19239)
    UInt8[ES, (ushort)(BX + 0x2)] = AL;
    CheckExternalEvents(cs10, 0x772);
    // CMP word ptr [0x4fba],0x0 (18AD_076D / 0x1923D)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs10, 0x774);
    // JNZ 0x1000:9257 (18AD_0772 / 0x19242)
    if(!ZeroFlag) {
      goto label_18AD_0787_19257;
    }
    CheckExternalEvents(cs10, 0x777);
    // SHL word ptr [BP + 0x8],0x1 (18AD_0774 / 0x19244)
    // UInt16[SS, (ushort)(BP + 0x8)] <<= 0x1;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Shl(UInt16[SS, (ushort)(BP + 0x8)], 0x1);
    CheckExternalEvents(cs10, 0x77A);
    // MOV AX,0x50 (18AD_0777 / 0x19247)
    AX = 0x50;
    CheckExternalEvents(cs10, 0x77D);
    // IMUL word ptr [BP + 0xa] (18AD_077A / 0x1924A)
    int resImul18AD_077A = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xA)]);
    AX = (ushort)(resImul18AD_077A);
    DX = (ushort)(resImul18AD_077A >> 16);
    CheckExternalEvents(cs10, 0x780);
    // MOV word ptr [BP + 0xa],AX (18AD_077D / 0x1924D)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs10, 0x785);
    // MOV word ptr [BP + -0x8],0x50 (18AD_0780 / 0x19250)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x50;
    CheckExternalEvents(cs10, 0x787);
    // JMP 0x1000:926d (18AD_0785 / 0x19255)
    goto label_18AD_079D_1926D;
    label_18AD_0787_19257:
    CheckExternalEvents(cs10, 0x789);
    // MOV CL,0x2 (18AD_0787 / 0x19257)
    CL = 0x2;
    CheckExternalEvents(cs10, 0x78C);
    // SHL word ptr [BP + 0x8],CL (18AD_0789 / 0x19259)
    // UInt16[SS, (ushort)(BP + 0x8)] <<= CL;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Shl(UInt16[SS, (ushort)(BP + 0x8)], CL);
    CheckExternalEvents(cs10, 0x78F);
    // MOV AX,0xa0 (18AD_078C / 0x1925C)
    AX = 0xA0;
    CheckExternalEvents(cs10, 0x792);
    // IMUL word ptr [BP + 0xa] (18AD_078F / 0x1925F)
    int resImul18AD_078F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0xA)]);
    AX = (ushort)(resImul18AD_078F);
    DX = (ushort)(resImul18AD_078F >> 16);
    CheckExternalEvents(cs10, 0x795);
    // MOV word ptr [BP + 0xa],AX (18AD_0792 / 0x19262)
    UInt16[SS, (ushort)(BP + 0xA)] = AX;
    CheckExternalEvents(cs10, 0x798);
    // SHL word ptr [BP + 0xc],0x1 (18AD_0795 / 0x19265)
    // UInt16[SS, (ushort)(BP + 0xC)] <<= 0x1;
    UInt16[SS, (ushort)(BP + 0xC)] = Alu16.Shl(UInt16[SS, (ushort)(BP + 0xC)], 0x1);
    CheckExternalEvents(cs10, 0x79D);
    // MOV word ptr [BP + -0x8],0xa0 (18AD_0798 / 0x19268)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xA0;
    label_18AD_079D_1926D:
    CheckExternalEvents(cs10, 0x7A0);
    // MOV AX,word ptr [BP + -0x8] (18AD_079D / 0x1926D)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs10, 0x7A3);
    // MOV CX,word ptr [BP + 0xc] (18AD_07A0 / 0x19270)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x7A5);
    // SHL CX,0x1 (18AD_07A3 / 0x19273)
    CX <<= 0x1;
    CheckExternalEvents(cs10, 0x7A7);
    // SUB AX,CX (18AD_07A5 / 0x19275)
    // AX -= CX;
    AX = Alu16.Sub(AX, CX);
    CheckExternalEvents(cs10, 0x7A8);
    // PUSH AX (18AD_07A7 / 0x19277)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x7AB);
    // PUSH word ptr [BP + 0xe] (18AD_07A8 / 0x19278)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x7AE);
    // PUSH word ptr [BP + 0xc] (18AD_07AB / 0x1927B)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x7B1);
    // MOV AX,word ptr [BP + -0x4] (18AD_07AE / 0x1927E)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs10, 0x7B4);
    // MOV DX,word ptr [BP + -0x2] (18AD_07B1 / 0x19281)
    DX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs10, 0x7B7);
    // ADD AX,0x4 (18AD_07B4 / 0x19284)
    // AX += 0x4;
    AX = Alu16.Add(AX, 0x4);
    CheckExternalEvents(cs10, 0x7B8);
    // PUSH DX (18AD_07B7 / 0x19287)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0x7B9);
    // PUSH AX (18AD_07B8 / 0x19288)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x7BC);
    // MOV SI,word ptr [BP + 0xa] (18AD_07B9 / 0x19289)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x7BF);
    // MOV BX,word ptr [BP + 0x8] (18AD_07BC / 0x1928C)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs10, 0x7C3);
    // LEA AX,[BX + SI + 0x244b] (18AD_07BF / 0x1928F)
    AX = (ushort)(BX + SI + 0x244B);
    CheckExternalEvents(cs10, 0x7C6);
    // MOV DX,0x1ddc (18AD_07C3 / 0x19293)
    DX = 0x1DDC;
    CheckExternalEvents(cs10, 0x7C7);
    // PUSH DX (18AD_07C6 / 0x19296)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0x7C8);
    // PUSH AX (18AD_07C7 / 0x19297)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x7CD);
    // CALLF 0x1000:a821 (18AD_07C8 / 0x19298)
    FarCall(cs10, 0x7CD, unknown_19EF_0931_1A821);
    CheckExternalEvents(cs10, 0x7D0);
    // ADD SP,0xe (18AD_07CD / 0x1929D)
    SP += 0xE;
    CheckExternalEvents(cs10, 0x7D5);
    // CMP word ptr [0x4fba],0x0 (18AD_07D0 / 0x192A0)
    Alu16.Sub(UInt16[DS, 0x4FBA], 0x0);
    CheckExternalEvents(cs10, 0x7D7);
    // JNZ 0x1000:92df (18AD_07D5 / 0x192A5)
    if(!ZeroFlag) {
      goto label_18AD_080F_192DF;
    }
    CheckExternalEvents(cs10, 0x7DA);
    // MOV AX,word ptr [BP + -0x8] (18AD_07D7 / 0x192A7)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs10, 0x7DD);
    // MOV CX,word ptr [BP + 0xc] (18AD_07DA / 0x192AA)
    CX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs10, 0x7DF);
    // SHL CX,0x1 (18AD_07DD / 0x192AD)
    CX <<= 0x1;
    CheckExternalEvents(cs10, 0x7E1);
    // SUB AX,CX (18AD_07DF / 0x192AF)
    // AX -= CX;
    AX = Alu16.Sub(AX, CX);
    CheckExternalEvents(cs10, 0x7E2);
    // PUSH AX (18AD_07E1 / 0x192B1)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x7E5);
    // PUSH word ptr [BP + 0xe] (18AD_07E2 / 0x192B2)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x7E8);
    // PUSH word ptr [BP + 0xc] (18AD_07E5 / 0x192B5)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x7EB);
    // MOV AX,word ptr [BP + -0x6] (18AD_07E8 / 0x192B8)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs10, 0x7ED);
    // SHR AX,0x1 (18AD_07EB / 0x192BB)
    AX >>= 0x1;
    CheckExternalEvents(cs10, 0x7F0);
    // ADD AX,word ptr [BP + -0x4] (18AD_07ED / 0x192BD)
    // AX += UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs10, 0x7F3);
    // MOV DX,word ptr [BP + -0x2] (18AD_07F0 / 0x192C0)
    DX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs10, 0x7F6);
    // ADD AX,0x4 (18AD_07F3 / 0x192C3)
    // AX += 0x4;
    AX = Alu16.Add(AX, 0x4);
    CheckExternalEvents(cs10, 0x7F7);
    // PUSH DX (18AD_07F6 / 0x192C6)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0x7F8);
    // PUSH AX (18AD_07F7 / 0x192C7)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x7FB);
    // MOV SI,word ptr [BP + 0xa] (18AD_07F8 / 0x192C8)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs10, 0x7FE);
    // MOV BX,word ptr [BP + 0x8] (18AD_07FB / 0x192CB)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs10, 0x802);
    // LEA AX,[BX + SI + 0x4614] (18AD_07FE / 0x192CE)
    AX = (ushort)(BX + SI + 0x4614);
    CheckExternalEvents(cs10, 0x805);
    // MOV DX,0x2a02 (18AD_0802 / 0x192D2)
    DX = 0x2A02;
    CheckExternalEvents(cs10, 0x806);
    // PUSH DX (18AD_0805 / 0x192D5)
    Stack.Push16(DX);
    CheckExternalEvents(cs10, 0x807);
    // PUSH AX (18AD_0806 / 0x192D6)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x80C);
    // CALLF 0x1000:a821 (18AD_0807 / 0x192D7)
    FarCall(cs10, 0x80C, unknown_19EF_0931_1A821);
    CheckExternalEvents(cs10, 0x80F);
    // ADD SP,0xe (18AD_080C / 0x192DC)
    // SP += 0xE;
    SP = Alu16.Add(SP, 0xE);
    label_18AD_080F_192DF:
    CheckExternalEvents(cs10, 0x810);
    // POP SI (18AD_080F / 0x192DF)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x812);
    // MOV SP,BP (18AD_0810 / 0x192E0)
    SP = BP;
    CheckExternalEvents(cs10, 0x813);
    // POP BP (18AD_0812 / 0x192E2)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x814);
    // RETF  (18AD_0813 / 0x192E3)
    return FarRet();
  }
  
  public virtual Action unknown_18AD_0814_192E4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_18AD_0814_192E4:
    CheckExternalEvents(cs10, 0x815);
    // PUSH BP (18AD_0814 / 0x192E4)
    Stack.Push16(BP);
    CheckExternalEvents(cs10, 0x817);
    // MOV BP,SP (18AD_0815 / 0x192E5)
    BP = SP;
    CheckExternalEvents(cs10, 0x81A);
    // MOV AX,0x2 (18AD_0817 / 0x192E7)
    AX = 0x2;
    CheckExternalEvents(cs10, 0x81F);
    // CALLF 0x1000:cecc (18AD_081A / 0x192EA)
    FarCall(cs10, 0x81F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs10, 0x821);
    // JMP 0x1000:9302 (18AD_081F / 0x192EF)
    goto label_18AD_0832_19302;
    label_18AD_0821_192F1:
    CheckExternalEvents(cs10, 0x825);
    // MOV ES,word ptr [0x56fa] (18AD_0821 / 0x192F1)
    ES = UInt16[DS, 0x56FA];
    CheckExternalEvents(cs10, 0x82A);
    // PUSH word ptr ES:[0x14e] (18AD_0825 / 0x192F5)
    Stack.Push16(UInt16[ES, 0x14E]);
    CheckExternalEvents(cs10, 0x82F);
    // CALLF 0x0000:4013 (18AD_082A / 0x192FA)
    FarCall(cs10, 0x82F, ghidra_guess_0000_4013_04013);
    CheckExternalEvents(cs10, 0x832);
    // ADD SP,0x2 (18AD_082F / 0x192FF)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_18AD_0832_19302:
    CheckExternalEvents(cs10, 0x835);
    // MOV AX,0x8000 (18AD_0832 / 0x19302)
    AX = 0x8000;
    CheckExternalEvents(cs10, 0x836);
    // PUSH AX (18AD_0835 / 0x19305)
    Stack.Push16(AX);
    CheckExternalEvents(cs10, 0x839);
    // PUSH word ptr [BP + 0x8] (18AD_0836 / 0x19306)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs10, 0x83C);
    // PUSH word ptr [BP + 0x6] (18AD_0839 / 0x19309)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs10, 0x841);
    // CALLF 0x1000:d2c0 (18AD_083C / 0x1930C)
    FarCall(cs10, 0x841, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs10, 0x844);
    // ADD SP,0x6 (18AD_0841 / 0x19311)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs10, 0x847);
    // MOV word ptr [BP + -0x2],AX (18AD_0844 / 0x19314)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs10, 0x848);
    // INC AX (18AD_0847 / 0x19317)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs10, 0x84A);
    // JZ 0x1000:92f1 (18AD_0848 / 0x19318)
    if(ZeroFlag) {
      goto label_18AD_0821_192F1;
    }
    CheckExternalEvents(cs10, 0x84D);
    // PUSH word ptr [BP + 0xe] (18AD_084A / 0x1931A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs10, 0x850);
    // PUSH word ptr [BP + 0xc] (18AD_084D / 0x1931D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs10, 0x853);
    // PUSH word ptr [BP + 0xa] (18AD_0850 / 0x19320)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs10, 0x856);
    // PUSH word ptr [BP + -0x2] (18AD_0853 / 0x19323)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs10, 0x85B);
    // CALLF 0x1000:d470 (18AD_0856 / 0x19326)
    FarCall(cs10, 0x85B, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs10, 0x85E);
    // ADD SP,0x8 (18AD_085B / 0x1932B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs10, 0x861);
    // PUSH word ptr [BP + -0x2] (18AD_085E / 0x1932E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs10, 0x866);
    // CALLF 0x1000:d226 (18AD_0861 / 0x19331)
    FarCall(cs10, 0x866, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs10, 0x868);
    // MOV SP,BP (18AD_0866 / 0x19336)
    SP = BP;
    CheckExternalEvents(cs10, 0x869);
    // POP BP (18AD_0868 / 0x19338)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs10, 0x86A);
    // RETF  (18AD_0869 / 0x19339)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_933A_1933A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_933A_1933A:
    CheckExternalEvents(cs7, 0x933C);
    // XOR AX,AX (1000_933A / 0x1933A)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0x9341);
    // CALLF 0x1000:cecc (1000_933C / 0x1933C)
    FarCall(cs7, 0x9341, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9344);
    // MOV AX,0x32 (1000_9341 / 0x19341)
    AX = 0x32;
    CheckExternalEvents(cs7, 0x9345);
    // PUSH AX (1000_9344 / 0x19344)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x9346);
    // PUSH CS (1000_9345 / 0x19345)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9349);
    // CALL 0x1000:8ad6 (1000_9346 / 0x19346)
    NearCall(cs7, 0x9349, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs7, 0x934C);
    // ADD SP,0x2 (1000_9349 / 0x19349)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x9351);
    // CALLF 0x0000:412b (1000_934C / 0x1934C)
    FarCall(cs7, 0x9351, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs7, 0x9352);
    // RETF  (1000_9351 / 0x19351)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9352_19352(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9352_19352:
    CheckExternalEvents(cs7, 0x9353);
    // PUSH BP (1000_9352 / 0x19352)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9355);
    // MOV BP,SP (1000_9353 / 0x19353)
    BP = SP;
    CheckExternalEvents(cs7, 0x9358);
    // MOV AX,0x4 (1000_9355 / 0x19355)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x935D);
    // CALLF 0x1000:cecc (1000_9358 / 0x19358)
    FarCall(cs7, 0x935D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x935E);
    // PUSH SI (1000_935D / 0x1935D)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9361);
    // DEC word ptr [BP + 0x6] (1000_935E / 0x1935E)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x9366);
    // MOV word ptr [BP + -0x4],0x0 (1000_9361 / 0x19361)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x9368);
    // JMP 0x1000:93c2 (1000_9366 / 0x19366)
    goto label_1000_93C2_193C2;
    label_1000_9368_19368:
    CheckExternalEvents(cs7, 0x936C);
    // CMP word ptr [BP + 0x6],0x0 (1000_9368 / 0x19368)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x936E);
    // JZ 0x1000:93ce (1000_936C / 0x1936C)
    if(ZeroFlag) {
      goto label_1000_93CE_193CE;
    }
    CheckExternalEvents(cs7, 0x9373);
    // CMP word ptr [SI + 0x500a],0x0 (1000_936E / 0x1936E)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500A)], 0x0);
    CheckExternalEvents(cs7, 0x9375);
    // JNZ 0x1000:937f (1000_9373 / 0x19373)
    if(!ZeroFlag) {
      goto label_1000_937F_1937F;
    }
    CheckExternalEvents(cs7, 0x937A);
    // CMP word ptr [SI + 0x500c],0x0 (1000_9375 / 0x19375)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500C)], 0x0);
    CheckExternalEvents(cs7, 0x937C);
    // JNZ 0x1000:937f (1000_937A / 0x1937A)
    if(!ZeroFlag) {
      goto label_1000_937F_1937F;
    }
    CheckExternalEvents(cs7, 0x937F);
    // DEC word ptr [BP + 0x6] (1000_937C / 0x1937C)
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.Dec(UInt16[SS, (ushort)(BP + 0x6)]);
    label_1000_937F_1937F:
    CheckExternalEvents(cs7, 0x9382);
    // MOV BX,word ptr [BP + -0x4] (1000_937F / 0x1937F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9384);
    // SHL BX,0x1 (1000_9382 / 0x19382)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9388);
    // MOV AX,word ptr [BX + 0x5008] (1000_9384 / 0x19384)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x938B);
    // MOV word ptr [BP + -0x2],AX (1000_9388 / 0x19388)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x938E);
    // CMP AX,0x3e8 (1000_938B / 0x1938B)
    Alu16.Sub(AX, 0x3E8);
    CheckExternalEvents(cs7, 0x9390);
    // JG 0x1000:9396 (1000_938E / 0x1938E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9396_19396;
    }
    CheckExternalEvents(cs7, 0x9394);
    // ADD word ptr [BP + -0x4],0x3 (1000_9390 / 0x19390)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x3;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs7, 0x9396);
    // JMP 0x1000:93c2 (1000_9394 / 0x19394)
    goto label_1000_93C2_193C2;
    label_1000_9396_19396:
    CheckExternalEvents(cs7, 0x939B);
    // SUB word ptr [BP + -0x2],0x3e8 (1000_9396 / 0x19396)
    UInt16[SS, (ushort)(BP - 0x2)] -= 0x3E8;
    CheckExternalEvents(cs7, 0x939F);
    // CMP word ptr [BP + -0x2],0x1 (1000_939B / 0x1939B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x1);
    CheckExternalEvents(cs7, 0x93A1);
    // JNZ 0x1000:93a7 (1000_939F / 0x1939F)
    if(!ZeroFlag) {
      goto label_1000_93A7_193A7;
    }
    CheckExternalEvents(cs7, 0x93A5);
    // ADD word ptr [BP + -0x4],0x6 (1000_93A1 / 0x193A1)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x6;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x6);
    CheckExternalEvents(cs7, 0x93A7);
    // JMP 0x1000:93c2 (1000_93A5 / 0x193A5)
    goto label_1000_93C2_193C2;
    label_1000_93A7_193A7:
    CheckExternalEvents(cs7, 0x93AB);
    // CMP word ptr [BP + -0x2],0x2 (1000_93A7 / 0x193A7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x2);
    CheckExternalEvents(cs7, 0x93AD);
    // JNZ 0x1000:93b3 (1000_93AB / 0x193AB)
    if(!ZeroFlag) {
      goto label_1000_93B3_193B3;
    }
    label_1000_93AD_193AD:
    CheckExternalEvents(cs7, 0x93B1);
    // ADD word ptr [BP + -0x4],0x7 (1000_93AD / 0x193AD)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x7;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x7);
    CheckExternalEvents(cs7, 0x93B3);
    // JMP 0x1000:93c2 (1000_93B1 / 0x193B1)
    goto label_1000_93C2_193C2;
    label_1000_93B3_193B3:
    CheckExternalEvents(cs7, 0x93B7);
    // CMP word ptr [BP + -0x2],0x3 (1000_93B3 / 0x193B3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x3);
    CheckExternalEvents(cs7, 0x93B9);
    // JZ 0x1000:93ad (1000_93B7 / 0x193B7)
    if(ZeroFlag) {
      goto label_1000_93AD_193AD;
    }
    CheckExternalEvents(cs7, 0x93BD);
    // CMP word ptr [BP + -0x2],0x4 (1000_93B9 / 0x193B9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs7, 0x93BF);
    // JZ 0x1000:93ad (1000_93BD / 0x193BD)
    if(ZeroFlag) {
      goto label_1000_93AD_193AD;
    }
    CheckExternalEvents(cs7, 0x93C2);
    // INC word ptr [BP + -0x4] (1000_93BF / 0x193BF)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_93C2_193C2:
    CheckExternalEvents(cs7, 0x93C5);
    // MOV SI,word ptr [BP + -0x4] (1000_93C2 / 0x193C2)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x93C7);
    // SHL SI,0x1 (1000_93C5 / 0x193C5)
    SI <<= 0x1;
    CheckExternalEvents(cs7, 0x93CC);
    // CMP word ptr [SI + 0x5008],0x0 (1000_93C7 / 0x193C7)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x5008)], 0x0);
    CheckExternalEvents(cs7, 0x93CE);
    // JNZ 0x1000:9368 (1000_93CC / 0x193CC)
    if(!ZeroFlag) {
      goto label_1000_9368_19368;
    }
    label_1000_93CE_193CE:
    CheckExternalEvents(cs7, 0x93D2);
    // CMP word ptr [BP + 0x6],0x0 (1000_93CE / 0x193CE)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x93D4);
    // JZ 0x1000:93d7 (1000_93D2 / 0x193D2)
    if(ZeroFlag) {
      goto label_1000_93D7_193D7;
    }
    CheckExternalEvents(cs7, 0x93D7);
    // JMP 0x1000:95ee (1000_93D4 / 0x193D4)
    goto label_1000_95EE_195EE;
    label_1000_93D7_193D7:
    CheckExternalEvents(cs7, 0x93DA);
    // MOV AX,word ptr [BP + -0x4] (1000_93D7 / 0x193D7)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    label_1000_93DA_193DA:
    CheckExternalEvents(cs7, 0x93DD);
    // MOV SI,word ptr [BP + -0x4] (1000_93DA / 0x193DA)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x93DF);
    // SHL SI,0x1 (1000_93DD / 0x193DD)
    SI <<= 0x1;
    CheckExternalEvents(cs7, 0x93E4);
    // CMP word ptr [SI + 0x500a],0x0 (1000_93DF / 0x193DF)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500A)], 0x0);
    CheckExternalEvents(cs7, 0x93E6);
    // JNZ 0x1000:93f0 (1000_93E4 / 0x193E4)
    if(!ZeroFlag) {
      goto label_1000_93F0_193F0;
    }
    CheckExternalEvents(cs7, 0x93EB);
    // CMP word ptr [SI + 0x500c],0x0 (1000_93E6 / 0x193E6)
    Alu16.Sub(UInt16[DS, (ushort)(SI + 0x500C)], 0x0);
    CheckExternalEvents(cs7, 0x93ED);
    // JNZ 0x1000:93f0 (1000_93EB / 0x193EB)
    if(!ZeroFlag) {
      goto label_1000_93F0_193F0;
    }
    CheckExternalEvents(cs7, 0x93F0);
    // JMP 0x1000:95ee (1000_93ED / 0x193ED)
    goto label_1000_95EE_195EE;
    label_1000_93F0_193F0:
    CheckExternalEvents(cs7, 0x93F4);
    // MOV ES,word ptr [0x56fe] (1000_93F0 / 0x193F0)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x93F7);
    // MOV BX,word ptr [BP + -0x4] (1000_93F4 / 0x193F4)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x93FA);
    // INC word ptr [BP + -0x4] (1000_93F7 / 0x193F7)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x93FC);
    // SHL BX,0x1 (1000_93FA / 0x193FA)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9400);
    // MOV AX,word ptr [BX + 0x5008] (1000_93FC / 0x193FC)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9404);
    // MOV ES:[0x4612],AX (1000_9400 / 0x19400)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs7, 0x9407);
    // CMP AX,0x3e8 (1000_9404 / 0x19404)
    Alu16.Sub(AX, 0x3E8);
    CheckExternalEvents(cs7, 0x9409);
    // JG 0x1000:9437 (1000_9407 / 0x19407)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9437_19437;
    }
    CheckExternalEvents(cs7, 0x940D);
    // MOV ES,word ptr [0x5700] (1000_9409 / 0x19409)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs7, 0x9410);
    // MOV BX,word ptr [BP + -0x4] (1000_940D / 0x1940D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9413);
    // INC word ptr [BP + -0x4] (1000_9410 / 0x19410)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9415);
    // SHL BX,0x1 (1000_9413 / 0x19413)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9419);
    // MOV AX,word ptr [BX + 0x5008] (1000_9415 / 0x19415)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x941D);
    // MOV ES:[0x3984],AX (1000_9419 / 0x19419)
    UInt16[ES, 0x3984] = AX;
    CheckExternalEvents(cs7, 0x9421);
    // MOV ES,word ptr [0x5702] (1000_941D / 0x1941D)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs7, 0x9424);
    // MOV BX,word ptr [BP + -0x4] (1000_9421 / 0x19421)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9427);
    // INC word ptr [BP + -0x4] (1000_9424 / 0x19424)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9429);
    // SHL BX,0x1 (1000_9427 / 0x19427)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x942D);
    // MOV AX,word ptr [BX + 0x5008] (1000_9429 / 0x19429)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9431);
    // MOV ES:[0xe48c],AX (1000_942D / 0x1942D)
    UInt16[ES, 0xE48C] = AX;
    CheckExternalEvents(cs7, 0x9432);
    // PUSH CS (1000_9431 / 0x19431)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9435);
    // CALL 0x1000:95f3 (1000_9432 / 0x19432)
    NearCall(cs7, 0x9435, ghidra_guess_1000_95F3_195F3);
    CheckExternalEvents(cs7, 0x9437);
    // JMP 0x1000:93da (1000_9435 / 0x19435)
    goto label_1000_93DA_193DA;
    label_1000_9437_19437:
    CheckExternalEvents(cs7, 0x943B);
    // MOV ES,word ptr [0x56fe] (1000_9437 / 0x19437)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x9442);
    // SUB word ptr ES:[0x4612],0x3e8 (1000_943B / 0x1943B)
    UInt16[ES, 0x4612] -= 0x3E8;
    CheckExternalEvents(cs7, 0x9448);
    // CMP word ptr ES:[0x4612],0x1 (1000_9442 / 0x19442)
    Alu16.Sub(UInt16[ES, 0x4612], 0x1);
    CheckExternalEvents(cs7, 0x944A);
    // JNZ 0x1000:94b1 (1000_9448 / 0x19448)
    if(!ZeroFlag) {
      goto label_1000_94B1_194B1;
    }
    CheckExternalEvents(cs7, 0x944D);
    // MOV BX,word ptr [BP + -0x4] (1000_944A / 0x1944A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9450);
    // INC word ptr [BP + -0x4] (1000_944D / 0x1944D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9452);
    // SHL BX,0x1 (1000_9450 / 0x19450)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9456);
    // MOV AX,word ptr [BX + 0x5008] (1000_9452 / 0x19452)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x945A);
    // MOV ES:[0x4612],AX (1000_9456 / 0x19456)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs7, 0x945E);
    // MOV ES,word ptr [0x5704] (1000_945A / 0x1945A)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs7, 0x9461);
    // MOV BX,word ptr [BP + -0x4] (1000_945E / 0x1945E)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9464);
    // INC word ptr [BP + -0x4] (1000_9461 / 0x19461)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9466);
    // SHL BX,0x1 (1000_9464 / 0x19464)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x946A);
    // MOV AX,word ptr [BX + 0x5008] (1000_9466 / 0x19466)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x946E);
    // MOV ES:[0x6c],AX (1000_946A / 0x1946A)
    UInt16[ES, 0x6C] = AX;
    CheckExternalEvents(cs7, 0x9472);
    // MOV ES,word ptr [0x5706] (1000_946E / 0x1946E)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs7, 0x9475);
    // MOV BX,word ptr [BP + -0x4] (1000_9472 / 0x19472)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9478);
    // INC word ptr [BP + -0x4] (1000_9475 / 0x19475)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x947A);
    // SHL BX,0x1 (1000_9478 / 0x19478)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x947E);
    // MOV AX,word ptr [BX + 0x5008] (1000_947A / 0x1947A)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9482);
    // MOV ES:[0x3776],AX (1000_947E / 0x1947E)
    UInt16[ES, 0x3776] = AX;
    CheckExternalEvents(cs7, 0x9486);
    // MOV ES,word ptr [0x5708] (1000_9482 / 0x19482)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs7, 0x9489);
    // MOV BX,word ptr [BP + -0x4] (1000_9486 / 0x19486)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x948C);
    // INC word ptr [BP + -0x4] (1000_9489 / 0x19489)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x948E);
    // SHL BX,0x1 (1000_948C / 0x1948C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9492);
    // MOV AX,word ptr [BX + 0x5008] (1000_948E / 0x1948E)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9496);
    // MOV ES:[0x4312],AX (1000_9492 / 0x19492)
    UInt16[ES, 0x4312] = AX;
    CheckExternalEvents(cs7, 0x949A);
    // MOV ES,word ptr [0x570a] (1000_9496 / 0x19496)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs7, 0x949D);
    // MOV BX,word ptr [BP + -0x4] (1000_949A / 0x1949A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x94A0);
    // INC word ptr [BP + -0x4] (1000_949D / 0x1949D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x94A2);
    // SHL BX,0x1 (1000_94A0 / 0x194A0)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x94A6);
    // MOV AX,word ptr [BX + 0x5008] (1000_94A2 / 0x194A2)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x94AA);
    // MOV ES:[0x398a],AX (1000_94A6 / 0x194A6)
    UInt16[ES, 0x398A] = AX;
    CheckExternalEvents(cs7, 0x94AB);
    // PUSH CS (1000_94AA / 0x194AA)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x94AE);
    // CALL 0x1000:963b (1000_94AB / 0x194AB)
    NearCall(cs7, 0x94AE, ghidra_guess_1000_963B_1963B);
    CheckExternalEvents(cs7, 0x94B1);
    // JMP 0x1000:93da (1000_94AE / 0x194AE)
    goto label_1000_93DA_193DA;
    label_1000_94B1_194B1:
    CheckExternalEvents(cs7, 0x94B5);
    // MOV ES,word ptr [0x56fe] (1000_94B1 / 0x194B1)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x94BB);
    // CMP word ptr ES:[0x4612],0x2 (1000_94B5 / 0x194B5)
    Alu16.Sub(UInt16[ES, 0x4612], 0x2);
    CheckExternalEvents(cs7, 0x94BD);
    // JNZ 0x1000:9538 (1000_94BB / 0x194BB)
    if(!ZeroFlag) {
      goto label_1000_9538_19538;
    }
    CheckExternalEvents(cs7, 0x94C0);
    // MOV BX,word ptr [BP + -0x4] (1000_94BD / 0x194BD)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x94C3);
    // INC word ptr [BP + -0x4] (1000_94C0 / 0x194C0)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x94C5);
    // SHL BX,0x1 (1000_94C3 / 0x194C3)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x94C9);
    // MOV AX,word ptr [BX + 0x5008] (1000_94C5 / 0x194C5)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x94CD);
    // MOV ES:[0x4612],AX (1000_94C9 / 0x194C9)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs7, 0x94D1);
    // MOV ES,word ptr [0x570c] (1000_94CD / 0x194CD)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs7, 0x94D4);
    // MOV BX,word ptr [BP + -0x4] (1000_94D1 / 0x194D1)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x94D7);
    // INC word ptr [BP + -0x4] (1000_94D4 / 0x194D4)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x94D9);
    // SHL BX,0x1 (1000_94D7 / 0x194D7)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x94DD);
    // MOV AX,word ptr [BX + 0x5008] (1000_94D9 / 0x194D9)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x94E1);
    // MOV ES:[0x0],AX (1000_94DD / 0x194DD)
    UInt16[ES, 0x0] = AX;
    CheckExternalEvents(cs7, 0x94E5);
    // MOV ES,word ptr [0x570e] (1000_94E1 / 0x194E1)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs7, 0x94E8);
    // MOV BX,word ptr [BP + -0x4] (1000_94E5 / 0x194E5)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x94EB);
    // INC word ptr [BP + -0x4] (1000_94E8 / 0x194E8)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x94ED);
    // SHL BX,0x1 (1000_94EB / 0x194EB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x94F1);
    // MOV AX,word ptr [BX + 0x5008] (1000_94ED / 0x194ED)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x94F5);
    // MOV ES:[0x39f4],AX (1000_94F1 / 0x194F1)
    UInt16[ES, 0x39F4] = AX;
    CheckExternalEvents(cs7, 0x94F9);
    // MOV ES,word ptr [0x5710] (1000_94F5 / 0x194F5)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs7, 0x94FC);
    // MOV BX,word ptr [BP + -0x4] (1000_94F9 / 0x194F9)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x94FF);
    // INC word ptr [BP + -0x4] (1000_94FC / 0x194FC)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9501);
    // SHL BX,0x1 (1000_94FF / 0x194FF)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9505);
    // MOV AX,word ptr [BX + 0x5008] (1000_9501 / 0x19501)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9509);
    // MOV ES:[0x4000],AX (1000_9505 / 0x19505)
    UInt16[ES, 0x4000] = AX;
    CheckExternalEvents(cs7, 0x950D);
    // MOV ES,word ptr [0x5712] (1000_9509 / 0x19509)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs7, 0x9510);
    // MOV BX,word ptr [BP + -0x4] (1000_950D / 0x1950D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9513);
    // INC word ptr [BP + -0x4] (1000_9510 / 0x19510)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9515);
    // SHL BX,0x1 (1000_9513 / 0x19513)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9519);
    // MOV AX,word ptr [BX + 0x5008] (1000_9515 / 0x19515)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x951D);
    // MOV ES:[0x4034],AX (1000_9519 / 0x19519)
    UInt16[ES, 0x4034] = AX;
    CheckExternalEvents(cs7, 0x9521);
    // MOV ES,word ptr [0x5714] (1000_951D / 0x1951D)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs7, 0x9524);
    // MOV BX,word ptr [BP + -0x4] (1000_9521 / 0x19521)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9527);
    // INC word ptr [BP + -0x4] (1000_9524 / 0x19524)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9529);
    // SHL BX,0x1 (1000_9527 / 0x19527)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x952D);
    // MOV AX,word ptr [BX + 0x5008] (1000_9529 / 0x19529)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9531);
    // MOV ES:[0x62],AX (1000_952D / 0x1952D)
    UInt16[ES, 0x62] = AX;
    CheckExternalEvents(cs7, 0x9532);
    // PUSH CS (1000_9531 / 0x19531)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9535);
    // CALL 0x1000:9695 (1000_9532 / 0x19532)
    NearCall(cs7, 0x9535, ghidra_guess_1000_9695_19695);
    CheckExternalEvents(cs7, 0x9538);
    // JMP 0x1000:93da (1000_9535 / 0x19535)
    goto label_1000_93DA_193DA;
    label_1000_9538_19538:
    CheckExternalEvents(cs7, 0x953C);
    // MOV ES,word ptr [0x56fe] (1000_9538 / 0x19538)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x9542);
    // CMP word ptr ES:[0x4612],0x3 (1000_953C / 0x1953C)
    Alu16.Sub(UInt16[ES, 0x4612], 0x3);
    CheckExternalEvents(cs7, 0x9544);
    // JZ 0x1000:954f (1000_9542 / 0x19542)
    if(ZeroFlag) {
      goto label_1000_954F_1954F;
    }
    CheckExternalEvents(cs7, 0x954A);
    // CMP word ptr ES:[0x4612],0x4 (1000_9544 / 0x19544)
    Alu16.Sub(UInt16[ES, 0x4612], 0x4);
    CheckExternalEvents(cs7, 0x954C);
    // JZ 0x1000:954f (1000_954A / 0x1954A)
    if(ZeroFlag) {
      goto label_1000_954F_1954F;
    }
    CheckExternalEvents(cs7, 0x954F);
    // JMP 0x1000:93da (1000_954C / 0x1954C)
    goto label_1000_93DA_193DA;
    label_1000_954F_1954F:
    CheckExternalEvents(cs7, 0x9552);
    // MOV BX,word ptr [BP + -0x4] (1000_954F / 0x1954F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9555);
    // INC word ptr [BP + -0x4] (1000_9552 / 0x19552)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9557);
    // SHL BX,0x1 (1000_9555 / 0x19555)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x955B);
    // MOV AX,word ptr [BX + 0x5008] (1000_9557 / 0x19557)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x955E);
    // MOV word ptr [BP + -0x2],AX (1000_955B / 0x1955B)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x9562);
    // MOV ES,word ptr [0x5716] (1000_955E / 0x1955E)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x9565);
    // MOV BX,word ptr [BP + -0x4] (1000_9562 / 0x19562)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9568);
    // INC word ptr [BP + -0x4] (1000_9565 / 0x19565)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x956A);
    // SHL BX,0x1 (1000_9568 / 0x19568)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x956E);
    // MOV AX,word ptr [BX + 0x5008] (1000_956A / 0x1956A)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9572);
    // MOV ES:[0x398c],AX (1000_956E / 0x1956E)
    UInt16[ES, 0x398C] = AX;
    CheckExternalEvents(cs7, 0x9576);
    // MOV ES,word ptr [0x5718] (1000_9572 / 0x19572)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9579);
    // MOV BX,word ptr [BP + -0x4] (1000_9576 / 0x19576)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x957C);
    // INC word ptr [BP + -0x4] (1000_9579 / 0x19579)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x957E);
    // SHL BX,0x1 (1000_957C / 0x1957C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9582);
    // MOV AX,word ptr [BX + 0x5008] (1000_957E / 0x1957E)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x9586);
    // MOV ES:[0x39a2],AX (1000_9582 / 0x19582)
    UInt16[ES, 0x39A2] = AX;
    CheckExternalEvents(cs7, 0x958A);
    // MOV ES,word ptr [0x571a] (1000_9586 / 0x19586)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x958D);
    // MOV BX,word ptr [BP + -0x4] (1000_958A / 0x1958A)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9590);
    // INC word ptr [BP + -0x4] (1000_958D / 0x1958D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x9592);
    // SHL BX,0x1 (1000_9590 / 0x19590)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x9596);
    // MOV AX,word ptr [BX + 0x5008] (1000_9592 / 0x19592)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x959A);
    // MOV ES:[0x39f6],AX (1000_9596 / 0x19596)
    UInt16[ES, 0x39F6] = AX;
    CheckExternalEvents(cs7, 0x959E);
    // MOV ES,word ptr [0x571c] (1000_959A / 0x1959A)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x95A1);
    // MOV BX,word ptr [BP + -0x4] (1000_959E / 0x1959E)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x95A4);
    // INC word ptr [BP + -0x4] (1000_95A1 / 0x195A1)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x95A6);
    // SHL BX,0x1 (1000_95A4 / 0x195A4)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x95AA);
    // MOV AX,word ptr [BX + 0x5008] (1000_95A6 / 0x195A6)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x95AE);
    // MOV ES:[0x3ff2],AX (1000_95AA / 0x195AA)
    UInt16[ES, 0x3FF2] = AX;
    CheckExternalEvents(cs7, 0x95B2);
    // MOV ES,word ptr [0x571e] (1000_95AE / 0x195AE)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x95B5);
    // MOV BX,word ptr [BP + -0x4] (1000_95B2 / 0x195B2)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x95B8);
    // INC word ptr [BP + -0x4] (1000_95B5 / 0x195B5)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0x95BA);
    // SHL BX,0x1 (1000_95B8 / 0x195B8)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x95BE);
    // MOV AX,word ptr [BX + 0x5008] (1000_95BA / 0x195BA)
    AX = UInt16[DS, (ushort)(BX + 0x5008)];
    CheckExternalEvents(cs7, 0x95C2);
    // MOV ES:[0x9c],AX (1000_95BE / 0x195BE)
    UInt16[ES, 0x9C] = AX;
    CheckExternalEvents(cs7, 0x95C6);
    // MOV ES,word ptr [0x56fe] (1000_95C2 / 0x195C2)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x95CC);
    // CMP word ptr ES:[0x4612],0x3 (1000_95C6 / 0x195C6)
    Alu16.Sub(UInt16[ES, 0x4612], 0x3);
    CheckExternalEvents(cs7, 0x95CE);
    // JNZ 0x1000:95dc (1000_95CC / 0x195CC)
    if(!ZeroFlag) {
      goto label_1000_95DC_195DC;
    }
    CheckExternalEvents(cs7, 0x95D1);
    // MOV AX,word ptr [BP + -0x2] (1000_95CE / 0x195CE)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x95D5);
    // MOV ES:[0x4612],AX (1000_95D1 / 0x195D1)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs7, 0x95D6);
    // PUSH CS (1000_95D5 / 0x195D5)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x95D9);
    // CALL 0x1000:96f8 (1000_95D6 / 0x195D6)
    NearCall(cs7, 0x95D9, ghidra_guess_1000_96F8_196F8);
    CheckExternalEvents(cs7, 0x95DC);
    // JMP 0x1000:93da (1000_95D9 / 0x195D9)
    goto label_1000_93DA_193DA;
    label_1000_95DC_195DC:
    CheckExternalEvents(cs7, 0x95E0);
    // MOV ES,word ptr [0x56fe] (1000_95DC / 0x195DC)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x95E3);
    // MOV AX,word ptr [BP + -0x2] (1000_95E0 / 0x195E0)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x95E7);
    // MOV ES:[0x4612],AX (1000_95E3 / 0x195E3)
    UInt16[ES, 0x4612] = AX;
    CheckExternalEvents(cs7, 0x95E8);
    // PUSH CS (1000_95E7 / 0x195E7)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x95EB);
    // CALL 0x1000:975b (1000_95E8 / 0x195E8)
    NearCall(cs7, 0x95EB, ghidra_guess_1000_975B_1975B);
    CheckExternalEvents(cs7, 0x95EE);
    // JMP 0x1000:93da (1000_95EB / 0x195EB)
    goto label_1000_93DA_193DA;
    label_1000_95EE_195EE:
    CheckExternalEvents(cs7, 0x95EF);
    // POP SI (1000_95EE / 0x195EE)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x95F1);
    // MOV SP,BP (1000_95EF / 0x195EF)
    SP = BP;
    CheckExternalEvents(cs7, 0x95F2);
    // POP BP (1000_95F1 / 0x195F1)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x95F3);
    // RETF  (1000_95F2 / 0x195F2)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_95F3_195F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_95F3_195F3:
    CheckExternalEvents(cs7, 0x95F4);
    // PUSH BP (1000_95F3 / 0x195F3)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x95F6);
    // MOV BP,SP (1000_95F4 / 0x195F4)
    BP = SP;
    CheckExternalEvents(cs7, 0x95F9);
    // MOV AX,0x2 (1000_95F6 / 0x195F6)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x95FE);
    // CALLF 0x1000:cecc (1000_95F9 / 0x195F9)
    FarCall(cs7, 0x95FE, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x95FF);
    // PUSH CS (1000_95FE / 0x195FE)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9602);
    // CALL 0x1000:97be (1000_95FF / 0x195FF)
    NearCall(cs7, 0x9602, ghidra_guess_1000_97BE_197BE);
    CheckExternalEvents(cs7, 0x9607);
    // MOV word ptr [BP + -0x2],0x0 (1000_9602 / 0x19602)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9609);
    // JMP 0x1000:9625 (1000_9607 / 0x19607)
    goto label_1000_9625_19625;
    label_1000_9609_19609:
    CheckExternalEvents(cs7, 0x960D);
    // MOV ES,word ptr [0x5702] (1000_9609 / 0x19609)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs7, 0x9612);
    // PUSH word ptr ES:[0xe48c] (1000_960D / 0x1960D)
    Stack.Push16(UInt16[ES, 0xE48C]);
    CheckExternalEvents(cs7, 0x9616);
    // MOV ES,word ptr [0x5700] (1000_9612 / 0x19612)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs7, 0x961B);
    // PUSH word ptr ES:[0x3984] (1000_9616 / 0x19616)
    Stack.Push16(UInt16[ES, 0x3984]);
    CheckExternalEvents(cs7, 0x961C);
    // PUSH CS (1000_961B / 0x1961B)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x961F);
    // CALL 0x1000:97cb (1000_961C / 0x1961C)
    NearCall(cs7, 0x961F, ghidra_guess_1000_97CB_197CB);
    CheckExternalEvents(cs7, 0x9622);
    // ADD SP,0x4 (1000_961F / 0x1961F)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x9625);
    // INC word ptr [BP + -0x2] (1000_9622 / 0x19622)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9625_19625:
    CheckExternalEvents(cs7, 0x9629);
    // MOV ES,word ptr [0x56fe] (1000_9625 / 0x19625)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x962C);
    // MOV AX,word ptr [BP + -0x2] (1000_9629 / 0x19629)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x9631);
    // CMP word ptr ES:[0x4612],AX (1000_962C / 0x1962C)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs7, 0x9633);
    // JG 0x1000:9609 (1000_9631 / 0x19631)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9609_19609;
    }
    CheckExternalEvents(cs7, 0x9634);
    // PUSH CS (1000_9633 / 0x19633)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9637);
    // CALL 0x1000:9834 (1000_9634 / 0x19634)
    NearCall(cs7, 0x9637, ghidra_guess_1000_9834_19834);
    CheckExternalEvents(cs7, 0x9639);
    // MOV SP,BP (1000_9637 / 0x19637)
    SP = BP;
    CheckExternalEvents(cs7, 0x963A);
    // POP BP (1000_9639 / 0x19639)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x963B);
    // RETF  (1000_963A / 0x1963A)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_963B_1963B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_963B_1963B:
    CheckExternalEvents(cs7, 0x963C);
    // PUSH BP (1000_963B / 0x1963B)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x963E);
    // MOV BP,SP (1000_963C / 0x1963C)
    BP = SP;
    CheckExternalEvents(cs7, 0x9641);
    // MOV AX,0x2 (1000_963E / 0x1963E)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x9646);
    // CALLF 0x1000:cecc (1000_9641 / 0x19641)
    FarCall(cs7, 0x9646, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9647);
    // PUSH CS (1000_9646 / 0x19646)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x964A);
    // CALL 0x1000:97be (1000_9647 / 0x19647)
    NearCall(cs7, 0x964A, ghidra_guess_1000_97BE_197BE);
    CheckExternalEvents(cs7, 0x964F);
    // MOV word ptr [BP + -0x2],0x0 (1000_964A / 0x1964A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9651);
    // JMP 0x1000:967f (1000_964F / 0x1964F)
    goto label_1000_967F_1967F;
    label_1000_9651_19651:
    CheckExternalEvents(cs7, 0x9655);
    // MOV ES,word ptr [0x570a] (1000_9651 / 0x19651)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs7, 0x965A);
    // PUSH word ptr ES:[0x398a] (1000_9655 / 0x19655)
    Stack.Push16(UInt16[ES, 0x398A]);
    CheckExternalEvents(cs7, 0x965E);
    // MOV ES,word ptr [0x5708] (1000_965A / 0x1965A)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs7, 0x9663);
    // PUSH word ptr ES:[0x4312] (1000_965E / 0x1965E)
    Stack.Push16(UInt16[ES, 0x4312]);
    CheckExternalEvents(cs7, 0x9667);
    // MOV ES,word ptr [0x5706] (1000_9663 / 0x19663)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs7, 0x966C);
    // PUSH word ptr ES:[0x3776] (1000_9667 / 0x19667)
    Stack.Push16(UInt16[ES, 0x3776]);
    CheckExternalEvents(cs7, 0x9670);
    // MOV ES,word ptr [0x5704] (1000_966C / 0x1966C)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs7, 0x9675);
    // PUSH word ptr ES:[0x6c] (1000_9670 / 0x19670)
    Stack.Push16(UInt16[ES, 0x6C]);
    CheckExternalEvents(cs7, 0x9676);
    // PUSH CS (1000_9675 / 0x19675)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9679);
    // CALL 0x1000:98ea (1000_9676 / 0x19676)
    NearCall(cs7, 0x9679, ghidra_guess_1000_98EA_198EA);
    CheckExternalEvents(cs7, 0x967C);
    // ADD SP,0x8 (1000_9679 / 0x19679)
    SP += 0x8;
    CheckExternalEvents(cs7, 0x967F);
    // INC word ptr [BP + -0x2] (1000_967C / 0x1967C)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_967F_1967F:
    CheckExternalEvents(cs7, 0x9683);
    // MOV ES,word ptr [0x56fe] (1000_967F / 0x1967F)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x9686);
    // MOV AX,word ptr [BP + -0x2] (1000_9683 / 0x19683)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x968B);
    // CMP word ptr ES:[0x4612],AX (1000_9686 / 0x19686)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs7, 0x968D);
    // JG 0x1000:9651 (1000_968B / 0x1968B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9651_19651;
    }
    CheckExternalEvents(cs7, 0x968E);
    // PUSH CS (1000_968D / 0x1968D)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9691);
    // CALL 0x1000:9834 (1000_968E / 0x1968E)
    NearCall(cs7, 0x9691, ghidra_guess_1000_9834_19834);
    CheckExternalEvents(cs7, 0x9693);
    // MOV SP,BP (1000_9691 / 0x19691)
    SP = BP;
    CheckExternalEvents(cs7, 0x9694);
    // POP BP (1000_9693 / 0x19693)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9695);
    // RETF  (1000_9694 / 0x19694)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9695_19695(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9695_19695:
    CheckExternalEvents(cs7, 0x9696);
    // PUSH BP (1000_9695 / 0x19695)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9698);
    // MOV BP,SP (1000_9696 / 0x19696)
    BP = SP;
    CheckExternalEvents(cs7, 0x969B);
    // MOV AX,0x2 (1000_9698 / 0x19698)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x96A0);
    // CALLF 0x1000:cecc (1000_969B / 0x1969B)
    FarCall(cs7, 0x96A0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x96A1);
    // PUSH CS (1000_96A0 / 0x196A0)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x96A4);
    // CALL 0x1000:97be (1000_96A1 / 0x196A1)
    NearCall(cs7, 0x96A4, ghidra_guess_1000_97BE_197BE);
    CheckExternalEvents(cs7, 0x96A9);
    // MOV word ptr [BP + -0x2],0x0 (1000_96A4 / 0x196A4)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x96AB);
    // JMP 0x1000:96e2 (1000_96A9 / 0x196A9)
    goto label_1000_96E2_196E2;
    label_1000_96AB_196AB:
    CheckExternalEvents(cs7, 0x96AF);
    // MOV ES,word ptr [0x5714] (1000_96AB / 0x196AB)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs7, 0x96B4);
    // PUSH word ptr ES:[0x62] (1000_96AF / 0x196AF)
    Stack.Push16(UInt16[ES, 0x62]);
    CheckExternalEvents(cs7, 0x96B8);
    // MOV ES,word ptr [0x5712] (1000_96B4 / 0x196B4)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs7, 0x96BD);
    // PUSH word ptr ES:[0x4034] (1000_96B8 / 0x196B8)
    Stack.Push16(UInt16[ES, 0x4034]);
    CheckExternalEvents(cs7, 0x96C1);
    // MOV ES,word ptr [0x5710] (1000_96BD / 0x196BD)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs7, 0x96C6);
    // PUSH word ptr ES:[0x4000] (1000_96C1 / 0x196C1)
    Stack.Push16(UInt16[ES, 0x4000]);
    CheckExternalEvents(cs7, 0x96CA);
    // MOV ES,word ptr [0x570e] (1000_96C6 / 0x196C6)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs7, 0x96CF);
    // PUSH word ptr ES:[0x39f4] (1000_96CA / 0x196CA)
    Stack.Push16(UInt16[ES, 0x39F4]);
    CheckExternalEvents(cs7, 0x96D3);
    // MOV ES,word ptr [0x570c] (1000_96CF / 0x196CF)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs7, 0x96D8);
    // PUSH word ptr ES:[0x0] (1000_96D3 / 0x196D3)
    Stack.Push16(UInt16[ES, 0x0]);
    CheckExternalEvents(cs7, 0x96D9);
    // PUSH CS (1000_96D8 / 0x196D8)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x96DC);
    // CALL 0x1000:9993 (1000_96D9 / 0x196D9)
    NearCall(cs7, 0x96DC, ghidra_guess_1000_9993_19993);
    CheckExternalEvents(cs7, 0x96DF);
    // ADD SP,0xa (1000_96DC / 0x196DC)
    SP += 0xA;
    CheckExternalEvents(cs7, 0x96E2);
    // INC word ptr [BP + -0x2] (1000_96DF / 0x196DF)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_96E2_196E2:
    CheckExternalEvents(cs7, 0x96E6);
    // MOV ES,word ptr [0x56fe] (1000_96E2 / 0x196E2)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x96E9);
    // MOV AX,word ptr [BP + -0x2] (1000_96E6 / 0x196E6)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x96EE);
    // CMP word ptr ES:[0x4612],AX (1000_96E9 / 0x196E9)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs7, 0x96F0);
    // JG 0x1000:96ab (1000_96EE / 0x196EE)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_96AB_196AB;
    }
    CheckExternalEvents(cs7, 0x96F1);
    // PUSH CS (1000_96F0 / 0x196F0)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x96F4);
    // CALL 0x1000:9834 (1000_96F1 / 0x196F1)
    NearCall(cs7, 0x96F4, ghidra_guess_1000_9834_19834);
    CheckExternalEvents(cs7, 0x96F6);
    // MOV SP,BP (1000_96F4 / 0x196F4)
    SP = BP;
    CheckExternalEvents(cs7, 0x96F7);
    // POP BP (1000_96F6 / 0x196F6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x96F8);
    // RETF  (1000_96F7 / 0x196F7)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_96F8_196F8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_96F8_196F8:
    CheckExternalEvents(cs7, 0x96F9);
    // PUSH BP (1000_96F8 / 0x196F8)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x96FB);
    // MOV BP,SP (1000_96F9 / 0x196F9)
    BP = SP;
    CheckExternalEvents(cs7, 0x96FE);
    // MOV AX,0x2 (1000_96FB / 0x196FB)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x9703);
    // CALLF 0x1000:cecc (1000_96FE / 0x196FE)
    FarCall(cs7, 0x9703, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9704);
    // PUSH CS (1000_9703 / 0x19703)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9707);
    // CALL 0x1000:97be (1000_9704 / 0x19704)
    NearCall(cs7, 0x9707, ghidra_guess_1000_97BE_197BE);
    CheckExternalEvents(cs7, 0x970C);
    // MOV word ptr [BP + -0x2],0x0 (1000_9707 / 0x19707)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x970E);
    // JMP 0x1000:9745 (1000_970C / 0x1970C)
    goto label_1000_9745_19745;
    label_1000_970E_1970E:
    CheckExternalEvents(cs7, 0x9712);
    // MOV ES,word ptr [0x571e] (1000_970E / 0x1970E)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x9717);
    // PUSH word ptr ES:[0x9c] (1000_9712 / 0x19712)
    Stack.Push16(UInt16[ES, 0x9C]);
    CheckExternalEvents(cs7, 0x971B);
    // MOV ES,word ptr [0x571c] (1000_9717 / 0x19717)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x9720);
    // PUSH word ptr ES:[0x3ff2] (1000_971B / 0x1971B)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs7, 0x9724);
    // MOV ES,word ptr [0x571a] (1000_9720 / 0x19720)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x9729);
    // PUSH word ptr ES:[0x39f6] (1000_9724 / 0x19724)
    Stack.Push16(UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs7, 0x972D);
    // MOV ES,word ptr [0x5718] (1000_9729 / 0x19729)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9732);
    // PUSH word ptr ES:[0x39a2] (1000_972D / 0x1972D)
    Stack.Push16(UInt16[ES, 0x39A2]);
    CheckExternalEvents(cs7, 0x9736);
    // MOV ES,word ptr [0x5716] (1000_9732 / 0x19732)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x973B);
    // PUSH word ptr ES:[0x398c] (1000_9736 / 0x19736)
    Stack.Push16(UInt16[ES, 0x398C]);
    CheckExternalEvents(cs7, 0x973C);
    // PUSH CS (1000_973B / 0x1973B)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x973F);
    // CALL 0x1000:9a97 (1000_973C / 0x1973C)
    NearCall(cs7, 0x973F, ghidra_guess_1000_9A97_19A97);
    CheckExternalEvents(cs7, 0x9742);
    // ADD SP,0xa (1000_973F / 0x1973F)
    SP += 0xA;
    CheckExternalEvents(cs7, 0x9745);
    // INC word ptr [BP + -0x2] (1000_9742 / 0x19742)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9745_19745:
    CheckExternalEvents(cs7, 0x9749);
    // MOV ES,word ptr [0x56fe] (1000_9745 / 0x19745)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x974C);
    // MOV AX,word ptr [BP + -0x2] (1000_9749 / 0x19749)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x9751);
    // CMP word ptr ES:[0x4612],AX (1000_974C / 0x1974C)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs7, 0x9753);
    // JG 0x1000:970e (1000_9751 / 0x19751)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_970E_1970E;
    }
    CheckExternalEvents(cs7, 0x9754);
    // PUSH CS (1000_9753 / 0x19753)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9757);
    // CALL 0x1000:9834 (1000_9754 / 0x19754)
    NearCall(cs7, 0x9757, ghidra_guess_1000_9834_19834);
    CheckExternalEvents(cs7, 0x9759);
    // MOV SP,BP (1000_9757 / 0x19757)
    SP = BP;
    CheckExternalEvents(cs7, 0x975A);
    // POP BP (1000_9759 / 0x19759)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x975B);
    // RETF  (1000_975A / 0x1975A)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_975B_1975B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_975B_1975B:
    CheckExternalEvents(cs7, 0x975C);
    // PUSH BP (1000_975B / 0x1975B)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x975E);
    // MOV BP,SP (1000_975C / 0x1975C)
    BP = SP;
    CheckExternalEvents(cs7, 0x9761);
    // MOV AX,0x2 (1000_975E / 0x1975E)
    AX = 0x2;
    CheckExternalEvents(cs7, 0x9766);
    // CALLF 0x1000:cecc (1000_9761 / 0x19761)
    FarCall(cs7, 0x9766, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9767);
    // PUSH CS (1000_9766 / 0x19766)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x976A);
    // CALL 0x1000:97be (1000_9767 / 0x19767)
    NearCall(cs7, 0x976A, ghidra_guess_1000_97BE_197BE);
    CheckExternalEvents(cs7, 0x976F);
    // MOV word ptr [BP + -0x2],0x0 (1000_976A / 0x1976A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9771);
    // JMP 0x1000:97a8 (1000_976F / 0x1976F)
    goto label_1000_97A8_197A8;
    label_1000_9771_19771:
    CheckExternalEvents(cs7, 0x9775);
    // MOV ES,word ptr [0x571e] (1000_9771 / 0x19771)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x977A);
    // PUSH word ptr ES:[0x9c] (1000_9775 / 0x19775)
    Stack.Push16(UInt16[ES, 0x9C]);
    CheckExternalEvents(cs7, 0x977E);
    // MOV ES,word ptr [0x571c] (1000_977A / 0x1977A)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x9783);
    // PUSH word ptr ES:[0x3ff2] (1000_977E / 0x1977E)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs7, 0x9787);
    // MOV ES,word ptr [0x571a] (1000_9783 / 0x19783)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x978C);
    // PUSH word ptr ES:[0x39f6] (1000_9787 / 0x19787)
    Stack.Push16(UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs7, 0x9790);
    // MOV ES,word ptr [0x5718] (1000_978C / 0x1978C)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9795);
    // PUSH word ptr ES:[0x39a2] (1000_9790 / 0x19790)
    Stack.Push16(UInt16[ES, 0x39A2]);
    CheckExternalEvents(cs7, 0x9799);
    // MOV ES,word ptr [0x5716] (1000_9795 / 0x19795)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x979E);
    // PUSH word ptr ES:[0x398c] (1000_9799 / 0x19799)
    Stack.Push16(UInt16[ES, 0x398C]);
    CheckExternalEvents(cs7, 0x979F);
    // PUSH CS (1000_979E / 0x1979E)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x97A2);
    // CALL 0x1000:9b2a (1000_979F / 0x1979F)
    NearCall(cs7, 0x97A2, ghidra_guess_1000_9B2A_19B2A);
    CheckExternalEvents(cs7, 0x97A5);
    // ADD SP,0xa (1000_97A2 / 0x197A2)
    SP += 0xA;
    CheckExternalEvents(cs7, 0x97A8);
    // INC word ptr [BP + -0x2] (1000_97A5 / 0x197A5)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_97A8_197A8:
    CheckExternalEvents(cs7, 0x97AC);
    // MOV ES,word ptr [0x56fe] (1000_97A8 / 0x197A8)
    ES = UInt16[DS, 0x56FE];
    CheckExternalEvents(cs7, 0x97AF);
    // MOV AX,word ptr [BP + -0x2] (1000_97AC / 0x197AC)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x97B4);
    // CMP word ptr ES:[0x4612],AX (1000_97AF / 0x197AF)
    Alu16.Sub(UInt16[ES, 0x4612], AX);
    CheckExternalEvents(cs7, 0x97B6);
    // JG 0x1000:9771 (1000_97B4 / 0x197B4)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9771_19771;
    }
    CheckExternalEvents(cs7, 0x97B7);
    // PUSH CS (1000_97B6 / 0x197B6)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x97BA);
    // CALL 0x1000:9834 (1000_97B7 / 0x197B7)
    NearCall(cs7, 0x97BA, ghidra_guess_1000_9834_19834);
    CheckExternalEvents(cs7, 0x97BC);
    // MOV SP,BP (1000_97BA / 0x197BA)
    SP = BP;
    CheckExternalEvents(cs7, 0x97BD);
    // POP BP (1000_97BC / 0x197BC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x97BE);
    // RETF  (1000_97BD / 0x197BD)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_97BE_197BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97BE_197BE:
    CheckExternalEvents(cs7, 0x97C0);
    // XOR AX,AX (1000_97BE / 0x197BE)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0x97C5);
    // CALLF 0x1000:cecc (1000_97C0 / 0x197C0)
    FarCall(cs7, 0x97C5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x97CA);
    // CALLF 0x1000:9f0c (1000_97C5 / 0x197C5)
    FarCall(cs7, 0x97CA, ghidra_guess_1000_9F0C_19F0C);
    CheckExternalEvents(cs7, 0x97CB);
    // RETF  (1000_97CA / 0x197CA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_97CB_197CB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_97CB_197CB:
    CheckExternalEvents(cs7, 0x97CC);
    // PUSH BP (1000_97CB / 0x197CB)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x97CE);
    // MOV BP,SP (1000_97CC / 0x197CC)
    BP = SP;
    CheckExternalEvents(cs7, 0x97D1);
    // MOV AX,0x4 (1000_97CE / 0x197CE)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x97D6);
    // CALLF 0x1000:cecc (1000_97D1 / 0x197D1)
    FarCall(cs7, 0x97D6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x97DA);
    // MOV ES,word ptr [0x5700] (1000_97D6 / 0x197D6)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs7, 0x97DD);
    // MOV AX,word ptr [BP + 0x6] (1000_97DA / 0x197DA)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x97E1);
    // MOV ES:[0x3984],AX (1000_97DD / 0x197DD)
    UInt16[ES, 0x3984] = AX;
    CheckExternalEvents(cs7, 0x97E5);
    // MOV ES,word ptr [0x5702] (1000_97E1 / 0x197E1)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs7, 0x97E8);
    // MOV AX,word ptr [BP + 0x8] (1000_97E5 / 0x197E5)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x97EC);
    // MOV ES:[0xe48c],AX (1000_97E8 / 0x197E8)
    UInt16[ES, 0xE48C] = AX;
    CheckExternalEvents(cs7, 0x97F0);
    // MOV ES,word ptr [0x5700] (1000_97EC / 0x197EC)
    ES = UInt16[DS, 0x5700];
    CheckExternalEvents(cs7, 0x97F6);
    // CMP word ptr ES:[0x3984],0x0 (1000_97F0 / 0x197F0)
    Alu16.Sub(UInt16[ES, 0x3984], 0x0);
    CheckExternalEvents(cs7, 0x97F8);
    // JZ 0x1000:9805 (1000_97F6 / 0x197F6)
    if(ZeroFlag) {
      goto label_1000_9805_19805;
    }
    CheckExternalEvents(cs7, 0x97FD);
    // PUSH word ptr ES:[0x3984] (1000_97F8 / 0x197F8)
    Stack.Push16(UInt16[ES, 0x3984]);
    CheckExternalEvents(cs7, 0x9802);
    // CALLF 0x1000:9f20 (1000_97FD / 0x197FD)
    FarCall(cs7, 0x9802, ghidra_guess_1000_9F20_19F20);
    CheckExternalEvents(cs7, 0x9805);
    // ADD SP,0x2 (1000_9802 / 0x19802)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_9805_19805:
    CheckExternalEvents(cs7, 0x980A);
    // MOV word ptr [BP + -0x4],0x0 (1000_9805 / 0x19805)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x980C);
    // JMP 0x1000:9823 (1000_980A / 0x1980A)
    goto label_1000_9823_19823;
    label_1000_980C_1980C:
    CheckExternalEvents(cs7, 0x980F);
    // INC word ptr [BP + -0x2] (1000_980C / 0x1980C)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_980F_1980F:
    CheckExternalEvents(cs7, 0x9813);
    // MOV ES,word ptr [0x5702] (1000_980F / 0x1980F)
    ES = UInt16[DS, 0x5702];
    CheckExternalEvents(cs7, 0x9817);
    // MOV AX,ES:[0xe48c] (1000_9813 / 0x19813)
    AX = UInt16[ES, 0xE48C];
    CheckExternalEvents(cs7, 0x981B);
    // IMUL word ptr [0x5006] (1000_9817 / 0x19817)
    int resImul1000_9817 = Alu16.Imul((short)AX, (short)UInt16[DS, 0x5006]);
    AX = (ushort)(resImul1000_9817);
    DX = (ushort)(resImul1000_9817 >> 16);
    CheckExternalEvents(cs7, 0x981E);
    // CMP AX,word ptr [BP + -0x2] (1000_981B / 0x1981B)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x9820);
    // JG 0x1000:980c (1000_981E / 0x1981E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_980C_1980C;
    }
    CheckExternalEvents(cs7, 0x9823);
    // INC word ptr [BP + -0x4] (1000_9820 / 0x19820)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_1000_9823_19823:
    CheckExternalEvents(cs7, 0x9827);
    // CMP word ptr [BP + -0x4],0x32 (1000_9823 / 0x19823)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x32);
    CheckExternalEvents(cs7, 0x9829);
    // JGE 0x1000:9830 (1000_9827 / 0x19827)
    if(SignFlag == OverflowFlag) {
      goto label_1000_9830_19830;
    }
    CheckExternalEvents(cs7, 0x982E);
    // MOV word ptr [BP + -0x2],0x0 (1000_9829 / 0x19829)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9830);
    // JMP 0x1000:980f (1000_982E / 0x1982E)
    goto label_1000_980F_1980F;
    label_1000_9830_19830:
    CheckExternalEvents(cs7, 0x9832);
    // MOV SP,BP (1000_9830 / 0x19830)
    SP = BP;
    CheckExternalEvents(cs7, 0x9833);
    // POP BP (1000_9832 / 0x19832)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9834);
    // RETF  (1000_9833 / 0x19833)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9834_19834(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9834_19834:
    CheckExternalEvents(cs7, 0x9836);
    // XOR AX,AX (1000_9834 / 0x19834)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs7, 0x983B);
    // CALLF 0x1000:cecc (1000_9836 / 0x19836)
    FarCall(cs7, 0x983B, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9840);
    // CALLF 0x1000:9f41 (1000_983B / 0x1983B)
    FarCall(cs7, 0x9840, ghidra_guess_1000_9F41_19F41);
    CheckExternalEvents(cs7, 0x9841);
    // RETF  (1000_9840 / 0x19840)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9841_19841(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9841_19841:
    CheckExternalEvents(cs7, 0x9842);
    // PUSH BP (1000_9841 / 0x19841)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9844);
    // MOV BP,SP (1000_9842 / 0x19842)
    BP = SP;
    CheckExternalEvents(cs7, 0x9847);
    // MOV AX,0x4 (1000_9844 / 0x19844)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x984C);
    // CALLF 0x1000:cecc (1000_9847 / 0x19847)
    FarCall(cs7, 0x984C, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9850);
    // MOV ES,word ptr [0x5704] (1000_984C / 0x1984C)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs7, 0x9853);
    // MOV AX,word ptr [BP + 0x6] (1000_9850 / 0x19850)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9857);
    // MOV ES:[0x6c],AX (1000_9853 / 0x19853)
    UInt16[ES, 0x6C] = AX;
    CheckExternalEvents(cs7, 0x985B);
    // MOV ES,word ptr [0x5706] (1000_9857 / 0x19857)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs7, 0x985E);
    // MOV AX,word ptr [BP + 0x8] (1000_985B / 0x1985B)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x9862);
    // MOV ES:[0x3776],AX (1000_985E / 0x1985E)
    UInt16[ES, 0x3776] = AX;
    CheckExternalEvents(cs7, 0x9866);
    // MOV ES,word ptr [0x5708] (1000_9862 / 0x19862)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs7, 0x9869);
    // MOV AX,word ptr [BP + 0xa] (1000_9866 / 0x19866)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0x986D);
    // MOV ES:[0x4312],AX (1000_9869 / 0x19869)
    UInt16[ES, 0x4312] = AX;
    CheckExternalEvents(cs7, 0x9871);
    // MOV ES,word ptr [0x570a] (1000_986D / 0x1986D)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs7, 0x9878);
    // MOV word ptr ES:[0x398a],0x3e8 (1000_9871 / 0x19871)
    UInt16[ES, 0x398A] = 0x3E8;
    CheckExternalEvents(cs7, 0x987D);
    // CALLF 0x1000:9f57 (1000_9878 / 0x19878)
    FarCall(cs7, 0x987D, ghidra_guess_1000_9F57_19F57);
    CheckExternalEvents(cs7, 0x9882);
    // MOV word ptr [BP + -0x2],0x1 (1000_987D / 0x1987D)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs7, 0x9884);
    // JMP 0x1000:9887 (1000_9882 / 0x19882)
    goto label_1000_9887_19887;
    label_1000_9884_19884:
    CheckExternalEvents(cs7, 0x9887);
    // INC word ptr [BP + -0x2] (1000_9884 / 0x19884)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9887_19887:
    CheckExternalEvents(cs7, 0x988A);
    // MOV AX,[0x5006] (1000_9887 / 0x19887)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs7, 0x988D);
    // CMP word ptr [BP + -0x2],AX (1000_988A / 0x1988A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs7, 0x988F);
    // JL 0x1000:9884 (1000_988D / 0x1988D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_9884_19884;
    }
    CheckExternalEvents(cs7, 0x9894);
    // MOV word ptr [BP + -0x2],0x0 (1000_988F / 0x1988F)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9896);
    // JMP 0x1000:98c0 (1000_9894 / 0x19894)
    goto label_1000_98C0_198C0;
    label_1000_9896_19896:
    CheckExternalEvents(cs7, 0x9899);
    // INC word ptr [BP + -0x4] (1000_9896 / 0x19896)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9899_19899:
    CheckExternalEvents(cs7, 0x989C);
    // MOV AX,[0x5006] (1000_9899 / 0x19899)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs7, 0x989F);
    // CMP word ptr [BP + -0x4],AX (1000_989C / 0x1989C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x98A1);
    // JGE 0x1000:98bd (1000_989F / 0x1989F)
    if(SignFlag == OverflowFlag) {
      goto label_1000_98BD_198BD;
    }
    CheckExternalEvents(cs7, 0x98A5);
    // MOV ES,word ptr [0x5706] (1000_98A1 / 0x198A1)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs7, 0x98AA);
    // PUSH word ptr ES:[0x3776] (1000_98A5 / 0x198A5)
    Stack.Push16(UInt16[ES, 0x3776]);
    CheckExternalEvents(cs7, 0x98AE);
    // MOV ES,word ptr [0x5704] (1000_98AA / 0x198AA)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs7, 0x98B3);
    // PUSH word ptr ES:[0x6c] (1000_98AE / 0x198AE)
    Stack.Push16(UInt16[ES, 0x6C]);
    CheckExternalEvents(cs7, 0x98B8);
    // CALLF 0x1000:9f99 (1000_98B3 / 0x198B3)
    FarCall(cs7, 0x98B8, ghidra_guess_1000_9F99_19F99);
    CheckExternalEvents(cs7, 0x98BB);
    // ADD SP,0x4 (1000_98B8 / 0x198B8)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x98BD);
    // JMP 0x1000:9896 (1000_98BB / 0x198BB)
    goto label_1000_9896_19896;
    label_1000_98BD_198BD:
    CheckExternalEvents(cs7, 0x98C0);
    // INC word ptr [BP + -0x2] (1000_98BD / 0x198BD)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_98C0_198C0:
    CheckExternalEvents(cs7, 0x98C4);
    // MOV ES,word ptr [0x5708] (1000_98C0 / 0x198C0)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs7, 0x98C7);
    // MOV AX,word ptr [BP + -0x2] (1000_98C4 / 0x198C4)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x98CC);
    // CMP word ptr ES:[0x4312],AX (1000_98C7 / 0x198C7)
    Alu16.Sub(UInt16[ES, 0x4312], AX);
    CheckExternalEvents(cs7, 0x98CE);
    // JLE 0x1000:98e6 (1000_98CC / 0x198CC)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_98E6_198E6;
    }
    CheckExternalEvents(cs7, 0x98D2);
    // MOV ES,word ptr [0x570a] (1000_98CE / 0x198CE)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs7, 0x98D7);
    // PUSH word ptr ES:[0x398a] (1000_98D2 / 0x198D2)
    Stack.Push16(UInt16[ES, 0x398A]);
    CheckExternalEvents(cs7, 0x98DC);
    // CALLF 0x1000:9f6d (1000_98D7 / 0x198D7)
    FarCall(cs7, 0x98DC, ghidra_guess_1000_9F6D_19F6D);
    CheckExternalEvents(cs7, 0x98DF);
    // ADD SP,0x2 (1000_98DC / 0x198DC)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x98E4);
    // MOV word ptr [BP + -0x4],0x0 (1000_98DF / 0x198DF)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x98E6);
    // JMP 0x1000:9899 (1000_98E4 / 0x198E4)
    goto label_1000_9899_19899;
    label_1000_98E6_198E6:
    CheckExternalEvents(cs7, 0x98E8);
    // MOV SP,BP (1000_98E6 / 0x198E6)
    SP = BP;
    CheckExternalEvents(cs7, 0x98E9);
    // POP BP (1000_98E8 / 0x198E8)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x98EA);
    // RETF  (1000_98E9 / 0x198E9)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_98EA_198EA(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_98EA_198EA:
    CheckExternalEvents(cs7, 0x98EB);
    // PUSH BP (1000_98EA / 0x198EA)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x98ED);
    // MOV BP,SP (1000_98EB / 0x198EB)
    BP = SP;
    CheckExternalEvents(cs7, 0x98F0);
    // MOV AX,0x4 (1000_98ED / 0x198ED)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x98F5);
    // CALLF 0x1000:cecc (1000_98F0 / 0x198F0)
    FarCall(cs7, 0x98F5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x98F9);
    // MOV ES,word ptr [0x5704] (1000_98F5 / 0x198F5)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs7, 0x98FC);
    // MOV AX,word ptr [BP + 0x6] (1000_98F9 / 0x198F9)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9900);
    // MOV ES:[0x6c],AX (1000_98FC / 0x198FC)
    UInt16[ES, 0x6C] = AX;
    CheckExternalEvents(cs7, 0x9904);
    // MOV ES,word ptr [0x5706] (1000_9900 / 0x19900)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs7, 0x9907);
    // MOV AX,word ptr [BP + 0x8] (1000_9904 / 0x19904)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x990B);
    // MOV ES:[0x3776],AX (1000_9907 / 0x19907)
    UInt16[ES, 0x3776] = AX;
    CheckExternalEvents(cs7, 0x990F);
    // MOV ES,word ptr [0x5708] (1000_990B / 0x1990B)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs7, 0x9912);
    // MOV AX,word ptr [BP + 0xa] (1000_990F / 0x1990F)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0x9916);
    // MOV ES:[0x4312],AX (1000_9912 / 0x19912)
    UInt16[ES, 0x4312] = AX;
    CheckExternalEvents(cs7, 0x991A);
    // MOV ES,word ptr [0x570a] (1000_9916 / 0x19916)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs7, 0x991D);
    // MOV AX,word ptr [BP + 0xc] (1000_991A / 0x1991A)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0x9921);
    // MOV ES:[0x398a],AX (1000_991D / 0x1991D)
    UInt16[ES, 0x398A] = AX;
    CheckExternalEvents(cs7, 0x9926);
    // CALLF 0x1000:9f57 (1000_9921 / 0x19921)
    FarCall(cs7, 0x9926, ghidra_guess_1000_9F57_19F57);
    CheckExternalEvents(cs7, 0x992B);
    // MOV word ptr [BP + -0x2],0x1 (1000_9926 / 0x19926)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs7, 0x992D);
    // JMP 0x1000:9930 (1000_992B / 0x1992B)
    goto label_1000_9930_19930;
    label_1000_992D_1992D:
    CheckExternalEvents(cs7, 0x9930);
    // INC word ptr [BP + -0x2] (1000_992D / 0x1992D)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9930_19930:
    CheckExternalEvents(cs7, 0x9933);
    // MOV AX,[0x5006] (1000_9930 / 0x19930)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs7, 0x9936);
    // CMP word ptr [BP + -0x2],AX (1000_9933 / 0x19933)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs7, 0x9938);
    // JL 0x1000:992d (1000_9936 / 0x19936)
    if(SignFlag != OverflowFlag) {
      goto label_1000_992D_1992D;
    }
    CheckExternalEvents(cs7, 0x993D);
    // MOV word ptr [BP + -0x2],0x0 (1000_9938 / 0x19938)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x993F);
    // JMP 0x1000:9969 (1000_993D / 0x1993D)
    goto label_1000_9969_19969;
    label_1000_993F_1993F:
    CheckExternalEvents(cs7, 0x9942);
    // INC word ptr [BP + -0x4] (1000_993F / 0x1993F)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9942_19942:
    CheckExternalEvents(cs7, 0x9945);
    // MOV AX,[0x5006] (1000_9942 / 0x19942)
    AX = UInt16[DS, 0x5006];
    CheckExternalEvents(cs7, 0x9948);
    // CMP word ptr [BP + -0x4],AX (1000_9945 / 0x19945)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x994A);
    // JGE 0x1000:9966 (1000_9948 / 0x19948)
    if(SignFlag == OverflowFlag) {
      goto label_1000_9966_19966;
    }
    CheckExternalEvents(cs7, 0x994E);
    // MOV ES,word ptr [0x5706] (1000_994A / 0x1994A)
    ES = UInt16[DS, 0x5706];
    CheckExternalEvents(cs7, 0x9953);
    // PUSH word ptr ES:[0x3776] (1000_994E / 0x1994E)
    Stack.Push16(UInt16[ES, 0x3776]);
    CheckExternalEvents(cs7, 0x9957);
    // MOV ES,word ptr [0x5704] (1000_9953 / 0x19953)
    ES = UInt16[DS, 0x5704];
    CheckExternalEvents(cs7, 0x995C);
    // PUSH word ptr ES:[0x6c] (1000_9957 / 0x19957)
    Stack.Push16(UInt16[ES, 0x6C]);
    CheckExternalEvents(cs7, 0x9961);
    // CALLF 0x1000:9f99 (1000_995C / 0x1995C)
    FarCall(cs7, 0x9961, ghidra_guess_1000_9F99_19F99);
    CheckExternalEvents(cs7, 0x9964);
    // ADD SP,0x4 (1000_9961 / 0x19961)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x9966);
    // JMP 0x1000:993f (1000_9964 / 0x19964)
    goto label_1000_993F_1993F;
    label_1000_9966_19966:
    CheckExternalEvents(cs7, 0x9969);
    // INC word ptr [BP + -0x2] (1000_9966 / 0x19966)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9969_19969:
    CheckExternalEvents(cs7, 0x996D);
    // MOV ES,word ptr [0x5708] (1000_9969 / 0x19969)
    ES = UInt16[DS, 0x5708];
    CheckExternalEvents(cs7, 0x9970);
    // MOV AX,word ptr [BP + -0x2] (1000_996D / 0x1996D)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x9975);
    // CMP word ptr ES:[0x4312],AX (1000_9970 / 0x19970)
    Alu16.Sub(UInt16[ES, 0x4312], AX);
    CheckExternalEvents(cs7, 0x9977);
    // JLE 0x1000:998f (1000_9975 / 0x19975)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_998F_1998F;
    }
    CheckExternalEvents(cs7, 0x997B);
    // MOV ES,word ptr [0x570a] (1000_9977 / 0x19977)
    ES = UInt16[DS, 0x570A];
    CheckExternalEvents(cs7, 0x9980);
    // PUSH word ptr ES:[0x398a] (1000_997B / 0x1997B)
    Stack.Push16(UInt16[ES, 0x398A]);
    CheckExternalEvents(cs7, 0x9985);
    // CALLF 0x1000:9f6d (1000_9980 / 0x19980)
    FarCall(cs7, 0x9985, ghidra_guess_1000_9F6D_19F6D);
    CheckExternalEvents(cs7, 0x9988);
    // ADD SP,0x2 (1000_9985 / 0x19985)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x998D);
    // MOV word ptr [BP + -0x4],0x0 (1000_9988 / 0x19988)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x998F);
    // JMP 0x1000:9942 (1000_998D / 0x1998D)
    goto label_1000_9942_19942;
    label_1000_998F_1998F:
    CheckExternalEvents(cs7, 0x9991);
    // MOV SP,BP (1000_998F / 0x1998F)
    SP = BP;
    CheckExternalEvents(cs7, 0x9992);
    // POP BP (1000_9991 / 0x19991)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9993);
    // RETF  (1000_9992 / 0x19992)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9993_19993(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9993_19993:
    CheckExternalEvents(cs7, 0x9994);
    // PUSH BP (1000_9993 / 0x19993)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9996);
    // MOV BP,SP (1000_9994 / 0x19994)
    BP = SP;
    CheckExternalEvents(cs7, 0x9999);
    // MOV AX,0x4 (1000_9996 / 0x19996)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x999E);
    // CALLF 0x1000:cecc (1000_9999 / 0x19999)
    FarCall(cs7, 0x999E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x999F);
    // PUSH SI (1000_999E / 0x1999E)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x99A3);
    // MOV ES,word ptr [0x570c] (1000_999F / 0x1999F)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs7, 0x99A6);
    // MOV AX,word ptr [BP + 0x6] (1000_99A3 / 0x199A3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x99AA);
    // MOV ES:[0x0],AX (1000_99A6 / 0x199A6)
    UInt16[ES, 0x0] = AX;
    CheckExternalEvents(cs7, 0x99AE);
    // MOV ES,word ptr [0x570e] (1000_99AA / 0x199AA)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs7, 0x99B1);
    // MOV AX,word ptr [BP + 0x8] (1000_99AE / 0x199AE)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x99B5);
    // MOV ES:[0x39f4],AX (1000_99B1 / 0x199B1)
    UInt16[ES, 0x39F4] = AX;
    CheckExternalEvents(cs7, 0x99B9);
    // MOV ES,word ptr [0x5710] (1000_99B5 / 0x199B5)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs7, 0x99BC);
    // MOV AX,word ptr [BP + 0xa] (1000_99B9 / 0x199B9)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0x99C0);
    // MOV ES:[0x4000],AX (1000_99BC / 0x199BC)
    UInt16[ES, 0x4000] = AX;
    CheckExternalEvents(cs7, 0x99C4);
    // MOV ES,word ptr [0x5712] (1000_99C0 / 0x199C0)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs7, 0x99C7);
    // MOV AX,word ptr [BP + 0xc] (1000_99C4 / 0x199C4)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0x99CB);
    // MOV ES:[0x4034],AX (1000_99C7 / 0x199C7)
    UInt16[ES, 0x4034] = AX;
    CheckExternalEvents(cs7, 0x99CF);
    // MOV ES,word ptr [0x5714] (1000_99CB / 0x199CB)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs7, 0x99D2);
    // MOV AX,word ptr [BP + 0xe] (1000_99CF / 0x199CF)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs7, 0x99D6);
    // MOV ES:[0x62],AX (1000_99D2 / 0x199D2)
    UInt16[ES, 0x62] = AX;
    CheckExternalEvents(cs7, 0x99D7);
    // PUSH CS (1000_99D6 / 0x199D6)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x99DA);
    // CALL 0x1000:97be (1000_99D7 / 0x199D7)
    NearCall(cs7, 0x99DA, ghidra_guess_1000_97BE_197BE);
    CheckExternalEvents(cs7, 0x99DF);
    // MOV word ptr [BP + -0x4],0x0 (1000_99DA / 0x199DA)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x99E1);
    // JMP 0x1000:9a28 (1000_99DF / 0x199DF)
    goto label_1000_9A28_19A28;
    label_1000_99E1_199E1:
    CheckExternalEvents(cs7, 0x99E4);
    // INC word ptr [BP + -0x2] (1000_99E1 / 0x199E1)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_99E4_199E4:
    CheckExternalEvents(cs7, 0x99E8);
    // MOV ES,word ptr [0x5714] (1000_99E4 / 0x199E4)
    ES = UInt16[DS, 0x5714];
    CheckExternalEvents(cs7, 0x99EC);
    // MOV AX,ES:[0x62] (1000_99E8 / 0x199E8)
    AX = UInt16[ES, 0x62];
    CheckExternalEvents(cs7, 0x99EF);
    // IMUL word ptr [BP + -0x2] (1000_99EC / 0x199EC)
    int resImul1000_99EC = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul1000_99EC);
    DX = (ushort)(resImul1000_99EC >> 16);
    CheckExternalEvents(cs7, 0x99F1);
    // MOV SI,AX (1000_99EF / 0x199EF)
    SI = AX;
    CheckExternalEvents(cs7, 0x99F5);
    // MOV ES,word ptr [0x570e] (1000_99F1 / 0x199F1)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs7, 0x99F9);
    // MOV AX,ES:[0x39f4] (1000_99F5 / 0x199F5)
    AX = UInt16[ES, 0x39F4];
    CheckExternalEvents(cs7, 0x99FB);
    // SHL AX,0x1 (1000_99F9 / 0x199F9)
    AX <<= 0x1;
    CheckExternalEvents(cs7, 0x99FD);
    // CMP AX,SI (1000_99FB / 0x199FB)
    Alu16.Sub(AX, SI);
    CheckExternalEvents(cs7, 0x99FF);
    // JLE 0x1000:9a25 (1000_99FD / 0x199FD)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9A25_19A25;
    }
    CheckExternalEvents(cs7, 0x9A03);
    // MOV ES,word ptr [0x5710] (1000_99FF / 0x199FF)
    ES = UInt16[DS, 0x5710];
    CheckExternalEvents(cs7, 0x9A08);
    // PUSH word ptr ES:[0x4000] (1000_9A03 / 0x19A03)
    Stack.Push16(UInt16[ES, 0x4000]);
    CheckExternalEvents(cs7, 0x9A0C);
    // MOV ES,word ptr [0x570c] (1000_9A08 / 0x19A08)
    ES = UInt16[DS, 0x570C];
    CheckExternalEvents(cs7, 0x9A10);
    // MOV AX,ES:[0x0] (1000_9A0C / 0x19A0C)
    AX = UInt16[ES, 0x0];
    CheckExternalEvents(cs7, 0x9A14);
    // MOV ES,word ptr [0x570e] (1000_9A10 / 0x19A10)
    ES = UInt16[DS, 0x570E];
    CheckExternalEvents(cs7, 0x9A19);
    // SUB AX,word ptr ES:[0x39f4] (1000_9A14 / 0x19A14)
    AX -= UInt16[ES, 0x39F4];
    CheckExternalEvents(cs7, 0x9A1B);
    // ADD AX,SI (1000_9A19 / 0x19A19)
    // AX += SI;
    AX = Alu16.Add(AX, SI);
    CheckExternalEvents(cs7, 0x9A1C);
    // PUSH AX (1000_9A1B / 0x19A1B)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x9A1D);
    // PUSH CS (1000_9A1C / 0x19A1C)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9A20);
    // CALL 0x1000:9a46 (1000_9A1D / 0x19A1D)
    NearCall(cs7, 0x9A20, ghidra_guess_1000_9A46_19A46);
    CheckExternalEvents(cs7, 0x9A23);
    // ADD SP,0x4 (1000_9A20 / 0x19A20)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x9A25);
    // JMP 0x1000:99e1 (1000_9A23 / 0x19A23)
    goto label_1000_99E1_199E1;
    label_1000_9A25_19A25:
    CheckExternalEvents(cs7, 0x9A28);
    // INC word ptr [BP + -0x4] (1000_9A25 / 0x19A25)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9A28_19A28:
    CheckExternalEvents(cs7, 0x9A2C);
    // MOV ES,word ptr [0x5712] (1000_9A28 / 0x19A28)
    ES = UInt16[DS, 0x5712];
    CheckExternalEvents(cs7, 0x9A2F);
    // MOV AX,word ptr [BP + -0x4] (1000_9A2C / 0x19A2C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x9A34);
    // CMP word ptr ES:[0x4034],AX (1000_9A2F / 0x19A2F)
    Alu16.Sub(UInt16[ES, 0x4034], AX);
    CheckExternalEvents(cs7, 0x9A36);
    // JLE 0x1000:9a3d (1000_9A34 / 0x19A34)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_9A3D_19A3D;
    }
    CheckExternalEvents(cs7, 0x9A3B);
    // MOV word ptr [BP + -0x2],0x0 (1000_9A36 / 0x19A36)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9A3D);
    // JMP 0x1000:99e4 (1000_9A3B / 0x19A3B)
    goto label_1000_99E4_199E4;
    label_1000_9A3D_19A3D:
    CheckExternalEvents(cs7, 0x9A3E);
    // PUSH CS (1000_9A3D / 0x19A3D)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9A41);
    // CALL 0x1000:9834 (1000_9A3E / 0x19A3E)
    NearCall(cs7, 0x9A41, ghidra_guess_1000_9834_19834);
    CheckExternalEvents(cs7, 0x9A42);
    // POP SI (1000_9A41 / 0x19A41)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9A44);
    // MOV SP,BP (1000_9A42 / 0x19A42)
    SP = BP;
    CheckExternalEvents(cs7, 0x9A45);
    // POP BP (1000_9A44 / 0x19A44)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9A46);
    // RETF  (1000_9A45 / 0x19A45)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9A46_19A46(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9A46_19A46:
    CheckExternalEvents(cs7, 0x9A47);
    // PUSH BP (1000_9A46 / 0x19A46)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9A49);
    // MOV BP,SP (1000_9A47 / 0x19A47)
    BP = SP;
    CheckExternalEvents(cs7, 0x9A4C);
    // MOV AX,0x4 (1000_9A49 / 0x19A49)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x9A51);
    // CALLF 0x1000:cecc (1000_9A4C / 0x19A4C)
    FarCall(cs7, 0x9A51, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9A55);
    // MOV ES,word ptr [0x5720] (1000_9A51 / 0x19A51)
    ES = UInt16[DS, 0x5720];
    CheckExternalEvents(cs7, 0x9A58);
    // MOV AX,word ptr [BP + 0x6] (1000_9A55 / 0x19A55)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9A5C);
    // MOV ES:[0x3ff6],AX (1000_9A58 / 0x19A58)
    UInt16[ES, 0x3FF6] = AX;
    CheckExternalEvents(cs7, 0x9A60);
    // MOV ES,word ptr [0x5722] (1000_9A5C / 0x19A5C)
    ES = UInt16[DS, 0x5722];
    CheckExternalEvents(cs7, 0x9A63);
    // MOV AX,word ptr [BP + 0x8] (1000_9A60 / 0x19A60)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x9A67);
    // MOV ES:[0x3246],AX (1000_9A63 / 0x19A63)
    UInt16[ES, 0x3246] = AX;
    CheckExternalEvents(cs7, 0x9A6B);
    // MOV ES,word ptr [0x5720] (1000_9A67 / 0x19A67)
    ES = UInt16[DS, 0x5720];
    CheckExternalEvents(cs7, 0x9A70);
    // PUSH word ptr ES:[0x3ff6] (1000_9A6B / 0x19A6B)
    Stack.Push16(UInt16[ES, 0x3FF6]);
    CheckExternalEvents(cs7, 0x9A75);
    // CALLF 0x1000:9f20 (1000_9A70 / 0x19A70)
    FarCall(cs7, 0x9A75, ghidra_guess_1000_9F20_19F20);
    CheckExternalEvents(cs7, 0x9A78);
    // ADD SP,0x2 (1000_9A75 / 0x19A75)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0x9A7D);
    // MOV word ptr [BP + -0x2],0x0 (1000_9A78 / 0x19A78)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0x9A7F);
    // JMP 0x1000:9a82 (1000_9A7D / 0x19A7D)
    goto label_1000_9A82_19A82;
    label_1000_9A7F_19A7F:
    CheckExternalEvents(cs7, 0x9A82);
    // INC word ptr [BP + -0x2] (1000_9A7F / 0x19A7F)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    label_1000_9A82_19A82:
    CheckExternalEvents(cs7, 0x9A86);
    // MOV ES,word ptr [0x5722] (1000_9A82 / 0x19A82)
    ES = UInt16[DS, 0x5722];
    CheckExternalEvents(cs7, 0x9A8A);
    // MOV AX,ES:[0x3246] (1000_9A86 / 0x19A86)
    AX = UInt16[ES, 0x3246];
    CheckExternalEvents(cs7, 0x9A8E);
    // IMUL word ptr [0x5006] (1000_9A8A / 0x19A8A)
    int resImul1000_9A8A = Alu16.Imul((short)AX, (short)UInt16[DS, 0x5006]);
    AX = (ushort)(resImul1000_9A8A);
    DX = (ushort)(resImul1000_9A8A >> 16);
    CheckExternalEvents(cs7, 0x9A91);
    // CMP AX,word ptr [BP + -0x2] (1000_9A8E / 0x19A8E)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0x9A93);
    // JG 0x1000:9a7f (1000_9A91 / 0x19A91)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_9A7F_19A7F;
    }
    CheckExternalEvents(cs7, 0x9A95);
    // MOV SP,BP (1000_9A93 / 0x19A93)
    SP = BP;
    CheckExternalEvents(cs7, 0x9A96);
    // POP BP (1000_9A95 / 0x19A95)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9A97);
    // RETF  (1000_9A96 / 0x19A96)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_9A97_19A97(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_9A97_19A97:
    CheckExternalEvents(cs7, 0x9A98);
    // PUSH BP (1000_9A97 / 0x19A97)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x9A9A);
    // MOV BP,SP (1000_9A98 / 0x19A98)
    BP = SP;
    CheckExternalEvents(cs7, 0x9A9D);
    // MOV AX,0x4 (1000_9A9A / 0x19A9A)
    AX = 0x4;
    CheckExternalEvents(cs7, 0x9AA2);
    // CALLF 0x1000:cecc (1000_9A9D / 0x19A9D)
    FarCall(cs7, 0x9AA2, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x9AA3);
    // PUSH SI (1000_9AA2 / 0x19AA2)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9AA7);
    // MOV ES,word ptr [0x5716] (1000_9AA3 / 0x19AA3)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x9AAA);
    // MOV AX,word ptr [BP + 0x6] (1000_9AA7 / 0x19AA7)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x9AAE);
    // MOV ES:[0x398c],AX (1000_9AAA / 0x19AAA)
    UInt16[ES, 0x398C] = AX;
    CheckExternalEvents(cs7, 0x9AB2);
    // MOV ES,word ptr [0x5718] (1000_9AAE / 0x19AAE)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9AB5);
    // MOV AX,word ptr [BP + 0x8] (1000_9AB2 / 0x19AB2)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x9AB9);
    // MOV ES:[0x39a2],AX (1000_9AB5 / 0x19AB5)
    UInt16[ES, 0x39A2] = AX;
    CheckExternalEvents(cs7, 0x9ABD);
    // MOV ES,word ptr [0x571a] (1000_9AB9 / 0x19AB9)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x9AC0);
    // MOV AX,word ptr [BP + 0xa] (1000_9ABD / 0x19ABD)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs7, 0x9AC4);
    // MOV ES:[0x39f6],AX (1000_9AC0 / 0x19AC0)
    UInt16[ES, 0x39F6] = AX;
    CheckExternalEvents(cs7, 0x9AC8);
    // MOV ES,word ptr [0x571c] (1000_9AC4 / 0x19AC4)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x9ACB);
    // MOV AX,word ptr [BP + 0xc] (1000_9AC8 / 0x19AC8)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs7, 0x9ACF);
    // MOV ES:[0x3ff2],AX (1000_9ACB / 0x19ACB)
    UInt16[ES, 0x3FF2] = AX;
    CheckExternalEvents(cs7, 0x9AD3);
    // MOV ES,word ptr [0x571e] (1000_9ACF / 0x19ACF)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x9AD6);
    // MOV AX,word ptr [BP + 0xe] (1000_9AD3 / 0x19AD3)
    AX = UInt16[SS, (ushort)(BP + 0xE)];
    CheckExternalEvents(cs7, 0x9ADA);
    // MOV ES:[0x9c],AX (1000_9AD6 / 0x19AD6)
    UInt16[ES, 0x9C] = AX;
    CheckExternalEvents(cs7, 0x9ADF);
    // MOV word ptr [BP + -0x4],0x0 (1000_9ADA / 0x19ADA)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0x9AE1);
    // JMP 0x1000:9b04 (1000_9ADF / 0x19ADF)
    goto label_1000_9B04_19B04;
    label_1000_9AE1_19AE1:
    CheckExternalEvents(cs7, 0x9AE4);
    // MOV word ptr [BP + -0x2],SI (1000_9AE1 / 0x19AE1)
    UInt16[SS, (ushort)(BP - 0x2)] = SI;
    CheckExternalEvents(cs7, 0x9AE8);
    // MOV ES,word ptr [0x571c] (1000_9AE4 / 0x19AE4)
    ES = UInt16[DS, 0x571C];
    CheckExternalEvents(cs7, 0x9AED);
    // PUSH word ptr ES:[0x3ff2] (1000_9AE8 / 0x19AE8)
    Stack.Push16(UInt16[ES, 0x3FF2]);
    CheckExternalEvents(cs7, 0x9AEF);
    // MOV AX,SI (1000_9AED / 0x19AED)
    AX = SI;
    CheckExternalEvents(cs7, 0x9AF3);
    // MOV ES,word ptr [0x571a] (1000_9AEF / 0x19AEF)
    ES = UInt16[DS, 0x571A];
    CheckExternalEvents(cs7, 0x9AF8);
    // SUB AX,word ptr ES:[0x39f6] (1000_9AF3 / 0x19AF3)
    // AX -= UInt16[ES, 0x39F6];
    AX = Alu16.Sub(AX, UInt16[ES, 0x39F6]);
    CheckExternalEvents(cs7, 0x9AF9);
    // PUSH AX (1000_9AF8 / 0x19AF8)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0x9AFA);
    // PUSH SI (1000_9AF9 / 0x19AF9)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x9AFB);
    // PUSH CS (1000_9AFA / 0x19AFA)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9AFE);
    // CALL 0x1000:9841 (1000_9AFB / 0x19AFB)
    NearCall(cs7, 0x9AFE, ghidra_guess_1000_9841_19841);
    CheckExternalEvents(cs7, 0x9B01);
    // ADD SP,0x6 (1000_9AFE / 0x19AFE)
    SP += 0x6;
    CheckExternalEvents(cs7, 0x9B04);
    // INC word ptr [BP + -0x4] (1000_9B01 / 0x19B01)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_1000_9B04_19B04:
    CheckExternalEvents(cs7, 0x9B08);
    // MOV ES,word ptr [0x5716] (1000_9B04 / 0x19B04)
    ES = UInt16[DS, 0x5716];
    CheckExternalEvents(cs7, 0x9B0D);
    // MOV SI,word ptr ES:[0x398c] (1000_9B08 / 0x19B08)
    SI = UInt16[ES, 0x398C];
    CheckExternalEvents(cs7, 0x9B11);
    // MOV ES,word ptr [0x571e] (1000_9B0D / 0x19B0D)
    ES = UInt16[DS, 0x571E];
    CheckExternalEvents(cs7, 0x9B15);
    // MOV AX,ES:[0x9c] (1000_9B11 / 0x19B11)
    AX = UInt16[ES, 0x9C];
    CheckExternalEvents(cs7, 0x9B18);
    // IMUL word ptr [BP + -0x4] (1000_9B15 / 0x19B15)
    int resImul1000_9B15 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul1000_9B15);
    DX = (ushort)(resImul1000_9B15 >> 16);
    CheckExternalEvents(cs7, 0x9B1A);
    // SUB SI,AX (1000_9B18 / 0x19B18)
    // SI -= AX;
    SI = Alu16.Sub(SI, AX);
    CheckExternalEvents(cs7, 0x9B1E);
    // MOV ES,word ptr [0x5718] (1000_9B1A / 0x19B1A)
    ES = UInt16[DS, 0x5718];
    CheckExternalEvents(cs7, 0x9B23);
    // CMP word ptr ES:[0x39a2],SI (1000_9B1E / 0x19B1E)
    Alu16.Sub(UInt16[ES, 0x39A2], SI);
    CheckExternalEvents(cs7, 0x9B25);
    // JL 0x1000:9ae1 (1000_9B23 / 0x19B23)
    if(SignFlag != OverflowFlag) {
      goto label_1000_9AE1_19AE1;
    }
    CheckExternalEvents(cs7, 0x9B26);
    // POP SI (1000_9B25 / 0x19B25)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9B28);
    // MOV SP,BP (1000_9B26 / 0x19B26)
    SP = BP;
    CheckExternalEvents(cs7, 0x9B29);
    // POP BP (1000_9B28 / 0x19B28)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x9B2A);
    // RETF  (1000_9B29 / 0x19B29)
    return FarRet();
  }
  
}
