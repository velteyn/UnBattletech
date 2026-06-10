namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action unknown_0170_218F_0388F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_218F_0388F:
    CheckExternalEvents(cs2, 0x2190);
    // PUSH BP (0170_218F / 0x388F)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x2192);
    // MOV BP,SP (0170_2190 / 0x3890)
    BP = SP;
    CheckExternalEvents(cs2, 0x2195);
    // MOV AX,0x8 (0170_2192 / 0x3892)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x219A);
    // CALLF 0x1000:cecc (0170_2195 / 0x3895)
    FarCall(cs2, 0x219A, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x219C);
    // SUB AX,AX (0170_219A / 0x389A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x219F);
    // MOV word ptr [BP + -0x4],AX (0170_219C / 0x389C)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x21A2);
    // MOV word ptr [BP + -0x2],AX (0170_219F / 0x389F)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x21A6);
    // CMP word ptr [BP + 0x6],-0x48 (0170_21A2 / 0x38A2)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB8);
    CheckExternalEvents(cs2, 0x21A8);
    // JZ 0x0000:38b4 (0170_21A6 / 0x38A6)
    if(ZeroFlag) {
      goto label_0170_21B4_038B4;
    }
    CheckExternalEvents(cs2, 0x21AC);
    // CMP word ptr [BP + 0x6],-0x49 (0170_21A8 / 0x38A8)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB7);
    CheckExternalEvents(cs2, 0x21AE);
    // JZ 0x0000:38b4 (0170_21AC / 0x38AC)
    if(ZeroFlag) {
      goto label_0170_21B4_038B4;
    }
    CheckExternalEvents(cs2, 0x21B2);
    // CMP word ptr [BP + 0x6],-0x47 (0170_21AE / 0x38AE)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB9);
    CheckExternalEvents(cs2, 0x21B4);
    // JNZ 0x0000:38b9 (0170_21B2 / 0x38B2)
    if(!ZeroFlag) {
      goto label_0170_21B9_038B9;
    }
    label_0170_21B4_038B4:
    CheckExternalEvents(cs2, 0x21B9);
    // MOV word ptr [BP + -0x4],0xffff (0170_21B4 / 0x38B4)
    UInt16[SS, (ushort)(BP - 0x4)] = 0xFFFF;
    label_0170_21B9_038B9:
    CheckExternalEvents(cs2, 0x21BD);
    // CMP word ptr [BP + 0x6],-0x50 (0170_21B9 / 0x38B9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB0);
    CheckExternalEvents(cs2, 0x21BF);
    // JZ 0x0000:38cb (0170_21BD / 0x38BD)
    if(ZeroFlag) {
      goto label_0170_21CB_038CB;
    }
    CheckExternalEvents(cs2, 0x21C3);
    // CMP word ptr [BP + 0x6],-0x51 (0170_21BF / 0x38BF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFAF);
    CheckExternalEvents(cs2, 0x21C5);
    // JZ 0x0000:38cb (0170_21C3 / 0x38C3)
    if(ZeroFlag) {
      goto label_0170_21CB_038CB;
    }
    CheckExternalEvents(cs2, 0x21C9);
    // CMP word ptr [BP + 0x6],-0x4f (0170_21C5 / 0x38C5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB1);
    CheckExternalEvents(cs2, 0x21CB);
    // JNZ 0x0000:38d0 (0170_21C9 / 0x38C9)
    if(!ZeroFlag) {
      goto label_0170_21D0_038D0;
    }
    label_0170_21CB_038CB:
    CheckExternalEvents(cs2, 0x21D0);
    // MOV word ptr [BP + -0x4],0x1 (0170_21CB / 0x38CB)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_0170_21D0_038D0:
    CheckExternalEvents(cs2, 0x21D4);
    // CMP word ptr [BP + 0x6],-0x4d (0170_21D0 / 0x38D0)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB3);
    CheckExternalEvents(cs2, 0x21D6);
    // JZ 0x0000:38e2 (0170_21D4 / 0x38D4)
    if(ZeroFlag) {
      goto label_0170_21E2_038E2;
    }
    CheckExternalEvents(cs2, 0x21DA);
    // CMP word ptr [BP + 0x6],-0x49 (0170_21D6 / 0x38D6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB7);
    CheckExternalEvents(cs2, 0x21DC);
    // JZ 0x0000:38e2 (0170_21DA / 0x38DA)
    if(ZeroFlag) {
      goto label_0170_21E2_038E2;
    }
    CheckExternalEvents(cs2, 0x21E0);
    // CMP word ptr [BP + 0x6],-0x51 (0170_21DC / 0x38DC)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFAF);
    CheckExternalEvents(cs2, 0x21E2);
    // JNZ 0x0000:38e7 (0170_21E0 / 0x38E0)
    if(!ZeroFlag) {
      goto label_0170_21E7_038E7;
    }
    label_0170_21E2_038E2:
    CheckExternalEvents(cs2, 0x21E7);
    // MOV word ptr [BP + -0x2],0x1 (0170_21E2 / 0x38E2)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0170_21E7_038E7:
    CheckExternalEvents(cs2, 0x21EB);
    // CMP word ptr [BP + 0x6],-0x4b (0170_21E7 / 0x38E7)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB5);
    CheckExternalEvents(cs2, 0x21ED);
    // JZ 0x0000:38f9 (0170_21EB / 0x38EB)
    if(ZeroFlag) {
      goto label_0170_21F9_038F9;
    }
    CheckExternalEvents(cs2, 0x21F1);
    // CMP word ptr [BP + 0x6],-0x47 (0170_21ED / 0x38ED)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB9);
    CheckExternalEvents(cs2, 0x21F3);
    // JZ 0x0000:38f9 (0170_21F1 / 0x38F1)
    if(ZeroFlag) {
      goto label_0170_21F9_038F9;
    }
    CheckExternalEvents(cs2, 0x21F7);
    // CMP word ptr [BP + 0x6],-0x4f (0170_21F3 / 0x38F3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xFFB1);
    CheckExternalEvents(cs2, 0x21F9);
    // JNZ 0x0000:38fe (0170_21F7 / 0x38F7)
    if(!ZeroFlag) {
      goto label_0170_21FE_038FE;
    }
    label_0170_21F9_038F9:
    CheckExternalEvents(cs2, 0x21FE);
    // MOV word ptr [BP + -0x2],0xffff (0170_21F9 / 0x38F9)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xFFFF;
    label_0170_21FE_038FE:
    CheckExternalEvents(cs2, 0x2201);
    // PUSH word ptr [BP + -0x4] (0170_21FE / 0x38FE)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x2204);
    // PUSH word ptr [BP + -0x2] (0170_2201 / 0x3901)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x2205);
    // PUSH CS (0170_2204 / 0x3904)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2208);
    // CALL 0x0000:3312 (0170_2205 / 0x3905)
    NearCall(cs2, 0x2208, unknown_0170_1C12_03312);
    CheckExternalEvents(cs2, 0x220B);
    // ADD SP,0x4 (0170_2208 / 0x3908)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x220D);
    // OR AX,AX (0170_220B / 0x390B)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs2, 0x220F);
    // JZ 0x0000:3912 (0170_220D / 0x390D)
    if(ZeroFlag) {
      goto label_0170_2212_03912;
    }
    CheckExternalEvents(cs2, 0x2212);
    // JMP 0x0000:39fa (0170_220F / 0x390F)
    goto label_0170_22FA_039FA;
    label_0170_2212_03912:
    CheckExternalEvents(cs2, 0x2216);
    // CMP word ptr [BP + -0x4],-0x1 (0170_2212 / 0x3912)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0xFFFF);
    CheckExternalEvents(cs2, 0x2218);
    // JNZ 0x0000:391d (0170_2216 / 0x3916)
    if(!ZeroFlag) {
      goto label_0170_221D_0391D;
    }
    CheckExternalEvents(cs2, 0x221D);
    // CALLF 0x1000:b47c (0170_2218 / 0x3918)
    FarCall(cs2, 0x221D, ghidra_guess_1000_B47C_1B47C);
    label_0170_221D_0391D:
    CheckExternalEvents(cs2, 0x2221);
    // CMP word ptr [BP + -0x4],0x1 (0170_221D / 0x391D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs2, 0x2223);
    // JNZ 0x0000:3928 (0170_2221 / 0x3921)
    if(!ZeroFlag) {
      goto label_0170_2228_03928;
    }
    CheckExternalEvents(cs2, 0x2228);
    // CALLF 0x1000:b52b (0170_2223 / 0x3923)
    FarCall(cs2, 0x2228, unknown_19EF_163B_1B52B);
    label_0170_2228_03928:
    CheckExternalEvents(cs2, 0x222D);
    // MOV word ptr [BP + -0x6],0x0 (0170_2228 / 0x3928)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0170_222D_0392D:
    CheckExternalEvents(cs2, 0x2230);
    // MOV BX,word ptr [BP + -0x6] (0170_222D / 0x392D)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2234);
    // MOV ES,word ptr [0x53ce] (0170_2230 / 0x3930)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs2, 0x223A);
    // CMP byte ptr ES:[BX + 0x9f3],0xff (0170_2234 / 0x3934)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x9F3)], 0xFF);
    CheckExternalEvents(cs2, 0x223C);
    // JZ 0x0000:397d (0170_223A / 0x393A)
    if(ZeroFlag) {
      goto label_0170_227D_0397D;
    }
    CheckExternalEvents(cs2, 0x2241);
    // MOV BL,byte ptr ES:[BX + 0x9f6] (0170_223C / 0x393C)
    BL = UInt8[ES, (ushort)(BX + 0x9F6)];
    CheckExternalEvents(cs2, 0x2243);
    // SUB BH,BH (0170_2241 / 0x3941)
    // BH -= BH;
    BH = Alu8.Sub(BH, BH);
    CheckExternalEvents(cs2, 0x2247);
    // MOV ES,word ptr [0x53d0] (0170_2243 / 0x3943)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs2, 0x224C);
    // MOV AL,byte ptr ES:[BX + 0x30] (0170_2247 / 0x3947)
    AL = UInt8[ES, (ushort)(BX + 0x30)];
    CheckExternalEvents(cs2, 0x224F);
    // MOV byte ptr [BP + -0x8],AL (0170_224C / 0x394C)
    UInt8[SS, (ushort)(BP - 0x8)] = AL;
    CheckExternalEvents(cs2, 0x2251);
    // CMP AL,BH (0170_224F / 0x394F)
    Alu8.Sub(AL, BH);
    CheckExternalEvents(cs2, 0x2253);
    // JZ 0x0000:3970 (0170_2251 / 0x3951)
    if(ZeroFlag) {
      goto label_0170_2270_03970;
    }
    CheckExternalEvents(cs2, 0x2254);
    // CBW  (0170_2253 / 0x3953)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x2255);
    // PUSH AX (0170_2254 / 0x3954)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2258);
    // MOV BX,word ptr [BP + -0x6] (0170_2255 / 0x3955)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x225C);
    // MOV ES,word ptr [0x53ce] (0170_2258 / 0x3958)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs2, 0x2261);
    // MOV AL,byte ptr ES:[BX + 0x9f3] (0170_225C / 0x395C)
    AL = UInt8[ES, (ushort)(BX + 0x9F3)];
    CheckExternalEvents(cs2, 0x2263);
    // SUB AH,AH (0170_2261 / 0x3961)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x2264);
    // PUSH AX (0170_2263 / 0x3963)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2265);
    // PUSH CS (0170_2264 / 0x3964)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2268);
    // CALL 0x0000:44a8 (0170_2265 / 0x3965)
    NearCall(cs2, 0x2268, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs2, 0x226B);
    // ADD SP,0x4 (0170_2268 / 0x3968)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x2270);
    // CALLF 0x1000:bc98 (0170_226B / 0x396B)
    FarCall(cs2, 0x2270, unknown_19EF_1DA8_1BC98);
    label_0170_2270_03970:
    CheckExternalEvents(cs2, 0x2273);
    // MOV BX,word ptr [BP + -0x6] (0170_2270 / 0x3970)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2277);
    // MOV ES,word ptr [0x53ce] (0170_2273 / 0x3973)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs2, 0x227D);
    // MOV byte ptr ES:[BX + 0x9f3],0xff (0170_2277 / 0x3977)
    UInt8[ES, (ushort)(BX + 0x9F3)] = 0xFF;
    label_0170_227D_0397D:
    CheckExternalEvents(cs2, 0x2280);
    // INC word ptr [BP + -0x6] (0170_227D / 0x397D)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs2, 0x2284);
    // CMP word ptr [BP + -0x6],0x3 (0170_2280 / 0x3980)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs2, 0x2286);
    // JL 0x0000:392d (0170_2284 / 0x3984)
    if(SignFlag != OverflowFlag) {
      goto label_0170_222D_0392D;
    }
    CheckExternalEvents(cs2, 0x228A);
    // CMP word ptr [BP + -0x2],0x1 (0170_2286 / 0x3986)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x1);
    CheckExternalEvents(cs2, 0x228C);
    // JNZ 0x0000:3991 (0170_228A / 0x398A)
    if(!ZeroFlag) {
      goto label_0170_2291_03991;
    }
    CheckExternalEvents(cs2, 0x2291);
    // CALLF 0x1000:b6b5 (0170_228C / 0x398C)
    FarCall(cs2, 0x2291, unknown_19EF_17C5_1B6B5);
    label_0170_2291_03991:
    CheckExternalEvents(cs2, 0x2295);
    // CMP word ptr [BP + -0x2],-0x1 (0170_2291 / 0x3991)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0xFFFF);
    CheckExternalEvents(cs2, 0x2297);
    // JNZ 0x0000:399c (0170_2295 / 0x3995)
    if(!ZeroFlag) {
      goto label_0170_229C_0399C;
    }
    CheckExternalEvents(cs2, 0x229C);
    // CALLF 0x1000:b5d3 (0170_2297 / 0x3997)
    FarCall(cs2, 0x229C, unknown_19EF_16E3_1B5D3);
    label_0170_229C_0399C:
    CheckExternalEvents(cs2, 0x22A1);
    // MOV word ptr [BP + -0x6],0x0 (0170_229C / 0x399C)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0170_22A1_039A1:
    CheckExternalEvents(cs2, 0x22A4);
    // MOV BX,word ptr [BP + -0x6] (0170_22A1 / 0x39A1)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x22A8);
    // MOV ES,word ptr [0x53ce] (0170_22A4 / 0x39A4)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs2, 0x22AE);
    // CMP byte ptr ES:[BX + 0x9f3],0xff (0170_22A8 / 0x39A8)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x9F3)], 0xFF);
    CheckExternalEvents(cs2, 0x22B0);
    // JZ 0x0000:39f1 (0170_22AE / 0x39AE)
    if(ZeroFlag) {
      goto label_0170_22F1_039F1;
    }
    CheckExternalEvents(cs2, 0x22B5);
    // MOV BL,byte ptr ES:[BX + 0x9f6] (0170_22B0 / 0x39B0)
    BL = UInt8[ES, (ushort)(BX + 0x9F6)];
    CheckExternalEvents(cs2, 0x22B7);
    // SUB BH,BH (0170_22B5 / 0x39B5)
    // BH -= BH;
    BH = Alu8.Sub(BH, BH);
    CheckExternalEvents(cs2, 0x22BB);
    // MOV ES,word ptr [0x53d0] (0170_22B7 / 0x39B7)
    ES = UInt16[DS, 0x53D0];
    CheckExternalEvents(cs2, 0x22C0);
    // MOV AL,byte ptr ES:[BX + 0x30] (0170_22BB / 0x39BB)
    AL = UInt8[ES, (ushort)(BX + 0x30)];
    CheckExternalEvents(cs2, 0x22C3);
    // MOV byte ptr [BP + -0x8],AL (0170_22C0 / 0x39C0)
    UInt8[SS, (ushort)(BP - 0x8)] = AL;
    CheckExternalEvents(cs2, 0x22C5);
    // CMP AL,BH (0170_22C3 / 0x39C3)
    Alu8.Sub(AL, BH);
    CheckExternalEvents(cs2, 0x22C7);
    // JZ 0x0000:39e4 (0170_22C5 / 0x39C5)
    if(ZeroFlag) {
      goto label_0170_22E4_039E4;
    }
    CheckExternalEvents(cs2, 0x22C8);
    // CBW  (0170_22C7 / 0x39C7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x22C9);
    // PUSH AX (0170_22C8 / 0x39C8)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x22CC);
    // MOV BX,word ptr [BP + -0x6] (0170_22C9 / 0x39C9)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x22D0);
    // MOV ES,word ptr [0x53ce] (0170_22CC / 0x39CC)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs2, 0x22D5);
    // MOV AL,byte ptr ES:[BX + 0x9f3] (0170_22D0 / 0x39D0)
    AL = UInt8[ES, (ushort)(BX + 0x9F3)];
    CheckExternalEvents(cs2, 0x22D7);
    // SUB AH,AH (0170_22D5 / 0x39D5)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x22D8);
    // PUSH AX (0170_22D7 / 0x39D7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x22D9);
    // PUSH CS (0170_22D8 / 0x39D8)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x22DC);
    // CALL 0x0000:44a8 (0170_22D9 / 0x39D9)
    NearCall(cs2, 0x22DC, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs2, 0x22DF);
    // ADD SP,0x4 (0170_22DC / 0x39DC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x22E4);
    // CALLF 0x1000:bc98 (0170_22DF / 0x39DF)
    FarCall(cs2, 0x22E4, unknown_19EF_1DA8_1BC98);
    label_0170_22E4_039E4:
    CheckExternalEvents(cs2, 0x22E7);
    // MOV BX,word ptr [BP + -0x6] (0170_22E4 / 0x39E4)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x22EB);
    // MOV ES,word ptr [0x53ce] (0170_22E7 / 0x39E7)
    ES = UInt16[DS, 0x53CE];
    CheckExternalEvents(cs2, 0x22F1);
    // MOV byte ptr ES:[BX + 0x9f3],0xff (0170_22EB / 0x39EB)
    UInt8[ES, (ushort)(BX + 0x9F3)] = 0xFF;
    label_0170_22F1_039F1:
    CheckExternalEvents(cs2, 0x22F4);
    // INC word ptr [BP + -0x6] (0170_22F1 / 0x39F1)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs2, 0x22F8);
    // CMP word ptr [BP + -0x6],0x3 (0170_22F4 / 0x39F4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs2, 0x22FA);
    // JL 0x0000:39a1 (0170_22F8 / 0x39F8)
    if(SignFlag != OverflowFlag) {
      goto label_0170_22A1_039A1;
    }
    label_0170_22FA_039FA:
    CheckExternalEvents(cs2, 0x22FE);
    // MOV ES,word ptr [0x538e] (0170_22FA / 0x39FA)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x2303);
    // PUSH word ptr ES:[0xa44d] (0170_22FE / 0x39FE)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x2307);
    // MOV ES,word ptr [0x538c] (0170_2303 / 0x3A03)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x230C);
    // PUSH word ptr ES:[0xa44b] (0170_2307 / 0x3A07)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x2311);
    // CALLF 0x1000:b204 (0170_230C / 0x3A0C)
    FarCall(cs2, 0x2311, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs2, 0x2314);
    // ADD SP,0x4 (0170_2311 / 0x3A11)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x2319);
    // CALLF 0x1000:bce8 (0170_2314 / 0x3A14)
    FarCall(cs2, 0x2319, unknown_19EF_1DF8_1BCE8);
    CheckExternalEvents(cs2, 0x231B);
    // MOV SP,BP (0170_2319 / 0x3A19)
    SP = BP;
    CheckExternalEvents(cs2, 0x231C);
    // POP BP (0170_231B / 0x3A1B)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x231D);
    // RETF  (0170_231C / 0x3A1C)
    return FarRet();
  }
  
  public virtual Action unknown_0170_231D_03A1D(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_231D_03A1D:
    CheckExternalEvents(cs2, 0x231E);
    // PUSH BP (0170_231D / 0x3A1D)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x2320);
    // MOV BP,SP (0170_231E / 0x3A1E)
    BP = SP;
    CheckExternalEvents(cs2, 0x2323);
    // MOV AX,0x4 (0170_2320 / 0x3A20)
    AX = 0x4;
    CheckExternalEvents(cs2, 0x2328);
    // CALLF 0x1000:cecc (0170_2323 / 0x3A23)
    FarCall(cs2, 0x2328, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x2329);
    // PUSH SI (0170_2328 / 0x3A28)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x232E);
    // MOV word ptr [BP + -0x2],0x0 (0170_2329 / 0x3A29)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0170_232E_03A2E:
    CheckExternalEvents(cs2, 0x2331);
    // MOV BX,word ptr [BP + -0x2] (0170_232E / 0x3A2E)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2333);
    // SHL BX,0x1 (0170_2331 / 0x3A31)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2336);
    // MOV AX,word ptr [BP + 0x6] (0170_2333 / 0x3A33)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x233A);
    // CMP word ptr [BX + 0x160],AX (0170_2336 / 0x3A36)
    Alu16.Sub(UInt16[DS, (ushort)(BX + 0x160)], AX);
    CheckExternalEvents(cs2, 0x233C);
    // JZ 0x0000:3a3f (0170_233A / 0x3A3A)
    if(ZeroFlag) {
      goto label_0170_233F_03A3F;
    }
    CheckExternalEvents(cs2, 0x233F);
    // JMP 0x0000:3afa (0170_233C / 0x3A3C)
    goto label_0170_23FA_03AFA;
    label_0170_233F_03A3F:
    CheckExternalEvents(cs2, 0x2344);
    // MOV word ptr [BP + -0x4],0x0 (0170_233F / 0x3A3F)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0170_2344_03A44:
    CheckExternalEvents(cs2, 0x2347);
    // MOV AX,0x7d (0170_2344 / 0x3A44)
    AX = 0x7D;
    CheckExternalEvents(cs2, 0x234A);
    // IMUL word ptr [BP + -0x4] (0170_2347 / 0x3A47)
    int resImul0170_2347 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0170_2347);
    DX = (ushort)(resImul0170_2347 >> 16);
    CheckExternalEvents(cs2, 0x234C);
    // MOV BX,AX (0170_234A / 0x3A4A)
    BX = AX;
    CheckExternalEvents(cs2, 0x2350);
    // MOV ES,word ptr [0x538a] (0170_234C / 0x3A4C)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2356);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0170_2350 / 0x3A50)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs2, 0x2358);
    // JZ 0x0000:3a9b (0170_2356 / 0x3A56)
    if(ZeroFlag) {
      goto label_0170_239B_03A9B;
    }
    CheckExternalEvents(cs2, 0x235B);
    // MOV BX,word ptr [BP + -0x4] (0170_2358 / 0x3A58)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x235F);
    // MOV ES,word ptr [0x53be] (0170_235B / 0x3A5B)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x2364);
    // MOV AL,byte ptr ES:[BX + 0x396c] (0170_235F / 0x3A5F)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs2, 0x2365);
    // CBW  (0170_2364 / 0x3A64)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x2368);
    // CMP AX,word ptr [BP + -0x2] (0170_2365 / 0x3A65)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x236A);
    // JZ 0x0000:3a85 (0170_2368 / 0x3A68)
    if(ZeroFlag) {
      goto label_0170_2385_03A85;
    }
    CheckExternalEvents(cs2, 0x236C);
    // SHL BX,0x1 (0170_236A / 0x3A6A)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x236E);
    // SHL BX,0x1 (0170_236C / 0x3A6C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2371);
    // MOV SI,word ptr [BP + -0x2] (0170_236E / 0x3A6E)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2373);
    // SHL SI,0x1 (0170_2371 / 0x3A71)
    SI <<= 0x1;
    CheckExternalEvents(cs2, 0x2375);
    // SHL SI,0x1 (0170_2373 / 0x3A73)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs2, 0x2379);
    // MOV AX,word ptr [SI + 0x25a] (0170_2375 / 0x3A75)
    AX = UInt16[DS, (ushort)(SI + 0x25A)];
    CheckExternalEvents(cs2, 0x237D);
    // MOV DX,word ptr [SI + 0x25c] (0170_2379 / 0x3A79)
    DX = UInt16[DS, (ushort)(SI + 0x25C)];
    CheckExternalEvents(cs2, 0x2381);
    // MOV word ptr [BX + 0x1f6],AX (0170_237D / 0x3A7D)
    UInt16[DS, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs2, 0x2385);
    // MOV word ptr [BX + 0x1f8],DX (0170_2381 / 0x3A81)
    UInt16[DS, (ushort)(BX + 0x1F8)] = DX;
    label_0170_2385_03A85:
    CheckExternalEvents(cs2, 0x2388);
    // PUSH word ptr [BP + -0x4] (0170_2385 / 0x3A85)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x2389);
    // PUSH CS (0170_2388 / 0x3A88)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x238C);
    // CALL 0x0000:2e32 (0170_2389 / 0x3A89)
    NearCall(cs2, 0x238C, unknown_0170_1732_02E32);
    CheckExternalEvents(cs2, 0x238F);
    // ADD SP,0x2 (0170_238C / 0x3A8C)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x2392);
    // MOV BX,word ptr [BP + -0x4] (0170_238F / 0x3A8F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x2396);
    // MOV ES,word ptr [0x539a] (0170_2392 / 0x3A92)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x239B);
    // MOV byte ptr ES:[BX + 0x409a],AL (0170_2396 / 0x3A96)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    label_0170_239B_03A9B:
    CheckExternalEvents(cs2, 0x239E);
    // INC word ptr [BP + -0x4] (0170_239B / 0x3A9B)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs2, 0x23A2);
    // CMP word ptr [BP + -0x4],0x4 (0170_239E / 0x3A9E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs2, 0x23A4);
    // JL 0x0000:3a44 (0170_23A2 / 0x3AA2)
    if(SignFlag != OverflowFlag) {
      goto label_0170_2344_03A44;
    }
    CheckExternalEvents(cs2, 0x23A9);
    // MOV word ptr [BP + -0x4],0x4 (0170_23A4 / 0x3AA4)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x4;
    label_0170_23A9_03AA9:
    CheckExternalEvents(cs2, 0x23AC);
    // MOV BX,word ptr [BP + -0x4] (0170_23A9 / 0x3AA9)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x23B0);
    // MOV ES,word ptr [0x53be] (0170_23AC / 0x3AAC)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x23B5);
    // MOV AL,byte ptr ES:[BX + 0x396c] (0170_23B0 / 0x3AB0)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs2, 0x23B6);
    // CBW  (0170_23B5 / 0x3AB5)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x23B9);
    // CMP AX,word ptr [BP + -0x2] (0170_23B6 / 0x3AB6)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x23BB);
    // JZ 0x0000:3ad6 (0170_23B9 / 0x3AB9)
    if(ZeroFlag) {
      goto label_0170_23D6_03AD6;
    }
    CheckExternalEvents(cs2, 0x23BD);
    // SHL BX,0x1 (0170_23BB / 0x3ABB)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x23BF);
    // SHL BX,0x1 (0170_23BD / 0x3ABD)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x23C2);
    // MOV SI,word ptr [BP + -0x2] (0170_23BF / 0x3ABF)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x23C4);
    // SHL SI,0x1 (0170_23C2 / 0x3AC2)
    SI <<= 0x1;
    CheckExternalEvents(cs2, 0x23C6);
    // SHL SI,0x1 (0170_23C4 / 0x3AC4)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs2, 0x23CA);
    // MOV AX,word ptr [SI + 0x27a] (0170_23C6 / 0x3AC6)
    AX = UInt16[DS, (ushort)(SI + 0x27A)];
    CheckExternalEvents(cs2, 0x23CE);
    // MOV DX,word ptr [SI + 0x27c] (0170_23CA / 0x3ACA)
    DX = UInt16[DS, (ushort)(SI + 0x27C)];
    CheckExternalEvents(cs2, 0x23D2);
    // MOV word ptr [BX + 0x1f6],AX (0170_23CE / 0x3ACE)
    UInt16[DS, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs2, 0x23D6);
    // MOV word ptr [BX + 0x1f8],DX (0170_23D2 / 0x3AD2)
    UInt16[DS, (ushort)(BX + 0x1F8)] = DX;
    label_0170_23D6_03AD6:
    CheckExternalEvents(cs2, 0x23D9);
    // PUSH word ptr [BP + -0x4] (0170_23D6 / 0x3AD6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x23DA);
    // PUSH CS (0170_23D9 / 0x3AD9)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x23DD);
    // CALL 0x0000:2e32 (0170_23DA / 0x3ADA)
    NearCall(cs2, 0x23DD, unknown_0170_1732_02E32);
    CheckExternalEvents(cs2, 0x23E0);
    // ADD SP,0x2 (0170_23DD / 0x3ADD)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x23E3);
    // MOV BX,word ptr [BP + -0x4] (0170_23E0 / 0x3AE0)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x23E7);
    // MOV ES,word ptr [0x539a] (0170_23E3 / 0x3AE3)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x23EC);
    // MOV byte ptr ES:[BX + 0x409a],AL (0170_23E7 / 0x3AE7)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    CheckExternalEvents(cs2, 0x23EF);
    // INC word ptr [BP + -0x4] (0170_23EC / 0x3AEC)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs2, 0x23F3);
    // CMP word ptr [BP + -0x4],0xc (0170_23EF / 0x3AEF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0xC);
    CheckExternalEvents(cs2, 0x23F5);
    // JL 0x0000:3aa9 (0170_23F3 / 0x3AF3)
    if(SignFlag != OverflowFlag) {
      goto label_0170_23A9_03AA9;
    }
    CheckExternalEvents(cs2, 0x23FA);
    // MOV word ptr [BP + -0x2],0x8 (0170_23F5 / 0x3AF5)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x8;
    label_0170_23FA_03AFA:
    CheckExternalEvents(cs2, 0x23FD);
    // INC word ptr [BP + -0x2] (0170_23FA / 0x3AFA)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs2, 0x2401);
    // CMP word ptr [BP + -0x2],0x8 (0170_23FD / 0x3AFD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x8);
    CheckExternalEvents(cs2, 0x2403);
    // JGE 0x0000:3b06 (0170_2401 / 0x3B01)
    if(SignFlag == OverflowFlag) {
      goto label_0170_2406_03B06;
    }
    CheckExternalEvents(cs2, 0x2406);
    // JMP 0x0000:3a2e (0170_2403 / 0x3B03)
    goto label_0170_232E_03A2E;
    label_0170_2406_03B06:
    CheckExternalEvents(cs2, 0x2407);
    // POP SI (0170_2406 / 0x3B06)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2409);
    // MOV SP,BP (0170_2407 / 0x3B07)
    SP = BP;
    CheckExternalEvents(cs2, 0x240A);
    // POP BP (0170_2409 / 0x3B09)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x240B);
    // RETF  (0170_240A / 0x3B0A)
    return FarRet();
  }
  
  public virtual Action unknown_0170_240B_03B0B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_240B_03B0B:
    CheckExternalEvents(cs2, 0x240C);
    // PUSH BP (0170_240B / 0x3B0B)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x240E);
    // MOV BP,SP (0170_240C / 0x3B0C)
    BP = SP;
    CheckExternalEvents(cs2, 0x2411);
    // MOV AX,0x8 (0170_240E / 0x3B0E)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x2416);
    // CALLF 0x1000:cecc (0170_2411 / 0x3B11)
    FarCall(cs2, 0x2416, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x241A);
    // MOV ES,word ptr [0x53d2] (0170_2416 / 0x3B16)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x2420);
    // CMP word ptr ES:[0x3988],0x0 (0170_241A / 0x3B1A)
    Alu16.Sub(UInt16[ES, 0x3988], 0x0);
    CheckExternalEvents(cs2, 0x2422);
    // JZ 0x0000:3b25 (0170_2420 / 0x3B20)
    if(ZeroFlag) {
      goto label_0170_2425_03B25;
    }
    CheckExternalEvents(cs2, 0x2425);
    // JMP 0x0000:3bbe (0170_2422 / 0x3B22)
    goto label_0170_24BE_03BBE;
    label_0170_2425_03B25:
    CheckExternalEvents(cs2, 0x2429);
    // INC word ptr [0x5800] (0170_2425 / 0x3B25)
    UInt16[DS, 0x5800]++;
    CheckExternalEvents(cs2, 0x242E);
    // CMP word ptr [0x5800],0x3 (0170_2429 / 0x3B29)
    Alu16.Sub(UInt16[DS, 0x5800], 0x3);
    CheckExternalEvents(cs2, 0x2430);
    // JC 0x0000:3b36 (0170_242E / 0x3B2E)
    if(CarryFlag) {
      goto label_0170_2436_03B36;
    }
    CheckExternalEvents(cs2, 0x2436);
    // MOV word ptr [0x5800],0x0 (0170_2430 / 0x3B30)
    UInt16[DS, 0x5800] = 0x0;
    label_0170_2436_03B36:
    CheckExternalEvents(cs2, 0x2439);
    // MOV AX,[0x5800] (0170_2436 / 0x3B36)
    AX = UInt16[DS, 0x5800];
    CheckExternalEvents(cs2, 0x243B);
    // MOV CL,0x7 (0170_2439 / 0x3B39)
    CL = 0x7;
    CheckExternalEvents(cs2, 0x243D);
    // SHL AX,CL (0170_243B / 0x3B3B)
    AX <<= CL;
    CheckExternalEvents(cs2, 0x2440);
    // ADD AX,0xd582 (0170_243D / 0x3B3D)
    // AX += 0xD582;
    AX = Alu16.Add(AX, 0xD582);
    CheckExternalEvents(cs2, 0x2443);
    // MOV word ptr [BP + -0x4],AX (0170_2440 / 0x3B40)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x2448);
    // MOV word ptr [BP + -0x2],0x2a02 (0170_2443 / 0x3B43)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2A02;
    CheckExternalEvents(cs2, 0x244C);
    // MOV ES,word ptr [0x53a0] (0170_2448 / 0x3B48)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x2452);
    // CMP word ptr ES:[0x4fba],0x2 (0170_244C / 0x3B4C)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x2454);
    // JZ 0x0000:3b90 (0170_2452 / 0x3B52)
    if(ZeroFlag) {
      goto label_0170_2490_03B90;
    }
    CheckExternalEvents(cs2, 0x2459);
    // MOV word ptr [BP + -0x8],0x0 (0170_2454 / 0x3B54)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs2, 0x245B);
    // JMP 0x0000:3b5e (0170_2459 / 0x3B59)
    goto label_0170_245E_03B5E;
    label_0170_245B_03B5B:
    CheckExternalEvents(cs2, 0x245E);
    // INC word ptr [BP + -0x8] (0170_245B / 0x3B5B)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    label_0170_245E_03B5E:
    CheckExternalEvents(cs2, 0x2462);
    // CMP word ptr [BP + -0x8],0xa (0170_245E / 0x3B5E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xA);
    CheckExternalEvents(cs2, 0x2464);
    // JGE 0x0000:3bbe (0170_2462 / 0x3B62)
    if(SignFlag == OverflowFlag) {
      goto label_0170_24BE_03BBE;
    }
    CheckExternalEvents(cs2, 0x2467);
    // MOV BX,word ptr [BP + -0x8] (0170_2464 / 0x3B64)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x246B);
    // MOV AL,byte ptr [BX + 0x4b0] (0170_2467 / 0x3B67)
    AL = UInt8[DS, (ushort)(BX + 0x4B0)];
    CheckExternalEvents(cs2, 0x246C);
    // CBW  (0170_246B / 0x3B6B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x246E);
    // MOV BX,AX (0170_246C / 0x3B6C)
    BX = AX;
    CheckExternalEvents(cs2, 0x2470);
    // MOV CL,0x7 (0170_246E / 0x3B6E)
    CL = 0x7;
    CheckExternalEvents(cs2, 0x2472);
    // SHL BX,CL (0170_2470 / 0x3B70)
    // BX <<= CL;
    BX = Alu16.Shl(BX, CL);
    CheckExternalEvents(cs2, 0x2476);
    // LEA AX,[BX + 0x4614] (0170_2472 / 0x3B72)
    AX = (ushort)(BX + 0x4614);
    CheckExternalEvents(cs2, 0x2479);
    // MOV DX,0x2a02 (0170_2476 / 0x3B76)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x247A);
    // PUSH DX (0170_2479 / 0x3B79)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x247B);
    // PUSH AX (0170_247A / 0x3B7A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x247E);
    // PUSH word ptr [BP + -0x2] (0170_247B / 0x3B7B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x2481);
    // PUSH word ptr [BP + -0x4] (0170_247E / 0x3B7E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x2486);
    // CALLF 0x1000:c798 (0170_2481 / 0x3B81)
    FarCall(cs2, 0x2486, unknown_19EF_28A8_1C798);
    CheckExternalEvents(cs2, 0x2489);
    // ADD SP,0x8 (0170_2486 / 0x3B86)
    SP += 0x8;
    CheckExternalEvents(cs2, 0x248E);
    // ADD word ptr [BP + -0x4],0x180 (0170_2489 / 0x3B89)
    // UInt16[SS, (ushort)(BP - 0x4)] += 0x180;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], 0x180);
    CheckExternalEvents(cs2, 0x2490);
    // JMP 0x0000:3b5b (0170_248E / 0x3B8E)
    goto label_0170_245B_03B5B;
    label_0170_2490_03B90:
    CheckExternalEvents(cs2, 0x2495);
    // MOV word ptr [BP + -0x8],0x0 (0170_2490 / 0x3B90)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0170_2495_03B95:
    CheckExternalEvents(cs2, 0x2498);
    // MOV BX,word ptr [BP + -0x8] (0170_2495 / 0x3B95)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x249C);
    // MOV AL,byte ptr [BX + 0x4b0] (0170_2498 / 0x3B98)
    AL = UInt8[DS, (ushort)(BX + 0x4B0)];
    CheckExternalEvents(cs2, 0x249D);
    // CBW  (0170_249C / 0x3B9C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x249F);
    // MOV CL,0x5 (0170_249D / 0x3B9D)
    CL = 0x5;
    CheckExternalEvents(cs2, 0x24A1);
    // SHL AX,CL (0170_249F / 0x3B9F)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs2, 0x24A2);
    // PUSH AX (0170_24A1 / 0x3BA1)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x24A5);
    // PUSH word ptr [BP + -0x2] (0170_24A2 / 0x3BA2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x24A8);
    // PUSH word ptr [BP + -0x4] (0170_24A5 / 0x3BA5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x24AD);
    // CALLF 0x1000:a98f (0170_24A8 / 0x3BA8)
    FarCall(cs2, 0x24AD, ghidra_guess_1000_A98F_1A98F);
    CheckExternalEvents(cs2, 0x24B0);
    // ADD SP,0x6 (0170_24AD / 0x3BAD)
    SP += 0x6;
    CheckExternalEvents(cs2, 0x24B5);
    // ADD word ptr [BP + -0x4],0x180 (0170_24B0 / 0x3BB0)
    UInt16[SS, (ushort)(BP - 0x4)] += 0x180;
    CheckExternalEvents(cs2, 0x24B8);
    // INC word ptr [BP + -0x8] (0170_24B5 / 0x3BB5)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs2, 0x24BC);
    // CMP word ptr [BP + -0x8],0xa (0170_24B8 / 0x3BB8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xA);
    CheckExternalEvents(cs2, 0x24BE);
    // JL 0x0000:3b95 (0170_24BC / 0x3BBC)
    if(SignFlag != OverflowFlag) {
      goto label_0170_2495_03B95;
    }
    label_0170_24BE_03BBE:
    CheckExternalEvents(cs2, 0x24C0);
    // MOV SP,BP (0170_24BE / 0x3BBE)
    SP = BP;
    CheckExternalEvents(cs2, 0x24C1);
    // POP BP (0170_24C0 / 0x3BC0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x24C2);
    // RETF  (0170_24C1 / 0x3BC1)
    return FarRet();
  }
  
  public virtual Action unknown_0170_24C2_03BC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_24C2_03BC2:
    CheckExternalEvents(cs2, 0x24C3);
    // PUSH BP (0170_24C2 / 0x3BC2)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x24C5);
    // MOV BP,SP (0170_24C3 / 0x3BC3)
    BP = SP;
    CheckExternalEvents(cs2, 0x24C8);
    // MOV AX,0x10 (0170_24C5 / 0x3BC5)
    AX = 0x10;
    CheckExternalEvents(cs2, 0x24CD);
    // CALLF 0x1000:cecc (0170_24C8 / 0x3BC8)
    FarCall(cs2, 0x24CD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x24CE);
    // PUSH DI (0170_24CD / 0x3BCD)
    Stack.Push16(DI);
    CheckExternalEvents(cs2, 0x24CF);
    // PUSH SI (0170_24CE / 0x3BCE)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x24D3);
    // MOV ES,word ptr [0x538c] (0170_24CF / 0x3BCF)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x24D7);
    // MOV AX,ES:[0xa44b] (0170_24D3 / 0x3BD3)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x24DA);
    // MOV word ptr [BP + -0x8],AX (0170_24D7 / 0x3BD7)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x24DE);
    // MOV ES,word ptr [0x538e] (0170_24DA / 0x3BDA)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x24E2);
    // MOV AX,ES:[0xa44d] (0170_24DE / 0x3BDE)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x24E5);
    // MOV word ptr [BP + -0xa],AX (0170_24E2 / 0x3BE2)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs2, 0x24EA);
    // MOV word ptr [BP + -0xc],0x0 (0170_24E5 / 0x3BE5)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    CheckExternalEvents(cs2, 0x24EC);
    // JMP 0x0000:3c55 (0170_24EA / 0x3BEA)
    goto label_0170_2555_03C55;
    label_0170_24EC_03BEC:
    CheckExternalEvents(cs2, 0x24F0);
    // CMP word ptr [BP + -0xc],0x0 (0170_24EC / 0x3BEC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs2, 0x24F2);
    // JNZ 0x0000:3c04 (0170_24F0 / 0x3BF0)
    if(!ZeroFlag) {
      goto label_0170_2504_03C04;
    }
    CheckExternalEvents(cs2, 0x24F6);
    // MOV ES,word ptr [0x538a] (0170_24F2 / 0x3BF2)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x24FC);
    // CMP byte ptr ES:[0xd339],0x0 (0170_24F6 / 0x3BF6)
    Alu8.Sub(UInt8[ES, 0xD339], 0x0);
    CheckExternalEvents(cs2, 0x24FE);
    // JZ 0x0000:3c04 (0170_24FC / 0x3BFC)
    if(ZeroFlag) {
      goto label_0170_2504_03C04;
    }
    CheckExternalEvents(cs2, 0x2504);
    // MOV byte ptr ES:[0xd399],0xff (0170_24FE / 0x3BFE)
    UInt8[ES, 0xD399] = 0xFF;
    label_0170_2504_03C04:
    CheckExternalEvents(cs2, 0x2507);
    // MOV AX,0x1a (0170_2504 / 0x3C04)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x250A);
    // IMUL word ptr [BP + -0xc] (0170_2507 / 0x3C07)
    int resImul0170_2507 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0170_2507);
    DX = (ushort)(resImul0170_2507 >> 16);
    CheckExternalEvents(cs2, 0x250C);
    // MOV SI,AX (0170_250A / 0x3C0A)
    SI = AX;
    CheckExternalEvents(cs2, 0x2510);
    // MOV ES,word ptr [0x538a] (0170_250C / 0x3C0C)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2515);
    // DEC byte ptr ES:[SI + 0xd399] (0170_2510 / 0x3C10)
    UInt8[ES, (ushort)(SI + 0xD399)] = Alu8.Dec(UInt8[ES, (ushort)(SI + 0xD399)]);
    CheckExternalEvents(cs2, 0x2517);
    // JNZ 0x0000:3c52 (0170_2515 / 0x3C15)
    if(!ZeroFlag) {
      goto label_0170_2552_03C52;
    }
    CheckExternalEvents(cs2, 0x251C);
    // MOV AL,byte ptr ES:[SI + 0xd398] (0170_2517 / 0x3C17)
    AL = UInt8[ES, (ushort)(SI + 0xD398)];
    CheckExternalEvents(cs2, 0x251E);
    // SUB AH,AH (0170_251C / 0x3C1C)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x2520);
    // MOV CL,0x4 (0170_251E / 0x3C1E)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x2522);
    // SHR AX,CL (0170_2520 / 0x3C20)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs2, 0x2525);
    // MOV word ptr [BP + -0x2],AX (0170_2522 / 0x3C22)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x2527);
    // MOV SI,AX (0170_2525 / 0x3C25)
    SI = AX;
    CheckExternalEvents(cs2, 0x2529);
    // SHL SI,0x1 (0170_2527 / 0x3C27)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs2, 0x252C);
    // MOV DI,word ptr [BP + -0xc] (0170_2529 / 0x3C29)
    DI = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x252E);
    // SHL DI,0x1 (0170_252C / 0x3C2C)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs2, 0x2532);
    // MOV ES,word ptr [0x53ca] (0170_252E / 0x3C2E)
    ES = UInt16[DS, 0x53CA];
    CheckExternalEvents(cs2, 0x2537);
    // MOV AX,word ptr ES:[SI + 0x4564] (0170_2532 / 0x3C32)
    AX = UInt16[ES, (ushort)(SI + 0x4564)];
    CheckExternalEvents(cs2, 0x253B);
    // MOV ES,word ptr [0x53a4] (0170_2537 / 0x3C37)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x2540);
    // MOV word ptr ES:[DI + 0x4024],AX (0170_253B / 0x3C3B)
    UInt16[ES, (ushort)(DI + 0x4024)] = AX;
    CheckExternalEvents(cs2, 0x2544);
    // MOV ES,word ptr [0x53cc] (0170_2540 / 0x3C40)
    ES = UInt16[DS, 0x53CC];
    CheckExternalEvents(cs2, 0x2549);
    // MOV AX,word ptr ES:[SI + 0x4596] (0170_2544 / 0x3C44)
    AX = UInt16[ES, (ushort)(SI + 0x4596)];
    CheckExternalEvents(cs2, 0x254D);
    // MOV ES,word ptr [0x53a6] (0170_2549 / 0x3C49)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x2552);
    // MOV word ptr ES:[DI + 0x4056],AX (0170_254D / 0x3C4D)
    UInt16[ES, (ushort)(DI + 0x4056)] = AX;
    label_0170_2552_03C52:
    CheckExternalEvents(cs2, 0x2555);
    // INC word ptr [BP + -0xc] (0170_2552 / 0x3C52)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_0170_2555_03C55:
    CheckExternalEvents(cs2, 0x2559);
    // CMP word ptr [BP + -0xc],0x8 (0170_2555 / 0x3C55)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x8);
    CheckExternalEvents(cs2, 0x255B);
    // JL 0x0000:3c5e (0170_2559 / 0x3C59)
    if(SignFlag != OverflowFlag) {
      goto label_0170_255E_03C5E;
    }
    CheckExternalEvents(cs2, 0x255E);
    // JMP 0x0000:3f4b (0170_255B / 0x3C5B)
    goto label_0170_284B_03F4B;
    label_0170_255E_03C5E:
    CheckExternalEvents(cs2, 0x2561);
    // MOV BX,word ptr [BP + -0xc] (0170_255E / 0x3C5E)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x2565);
    // MOV ES,word ptr [0x53b2] (0170_2561 / 0x3C61)
    ES = UInt16[DS, 0x53B2];
    CheckExternalEvents(cs2, 0x256B);
    // MOV byte ptr ES:[BX + 0x42f6],0x0 (0170_2565 / 0x3C65)
    UInt8[ES, (ushort)(BX + 0x42F6)] = 0x0;
    CheckExternalEvents(cs2, 0x256E);
    // MOV AX,0x1a (0170_256B / 0x3C6B)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x2571);
    // IMUL word ptr [BP + -0xc] (0170_256E / 0x3C6E)
    int resImul0170_256E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0170_256E);
    DX = (ushort)(resImul0170_256E >> 16);
    CheckExternalEvents(cs2, 0x2573);
    // MOV BX,AX (0170_2571 / 0x3C71)
    BX = AX;
    CheckExternalEvents(cs2, 0x2577);
    // MOV ES,word ptr [0x538a] (0170_2573 / 0x3C73)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x257D);
    // CMP byte ptr ES:[BX + 0xd399],0x0 (0170_2577 / 0x3C77)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD399)], 0x0);
    CheckExternalEvents(cs2, 0x257F);
    // JZ 0x0000:3c82 (0170_257D / 0x3C7D)
    if(ZeroFlag) {
      goto label_0170_2582_03C82;
    }
    CheckExternalEvents(cs2, 0x2582);
    // JMP 0x0000:3bec (0170_257F / 0x3C7F)
    goto label_0170_24EC_03BEC;
    label_0170_2582_03C82:
    CheckExternalEvents(cs2, 0x2586);
    // MOV ES,word ptr [0x538c] (0170_2582 / 0x3C82)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2589);
    // MOV AX,word ptr [BP + -0x8] (0170_2586 / 0x3C86)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x258C);
    // AND AX,0xf70 (0170_2589 / 0x3C89)
    // AX &= 0xF70;
    AX = Alu16.And(AX, 0xF70);
    CheckExternalEvents(cs2, 0x2590);
    // MOV ES:[0xa44b],AX (0170_258C / 0x3C8C)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0x2594);
    // MOV ES,word ptr [0x538e] (0170_2590 / 0x3C90)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x2597);
    // MOV AX,word ptr [BP + -0xa] (0170_2594 / 0x3C94)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x259A);
    // AND AX,0xf070 (0170_2597 / 0x3C97)
    // AX &= 0xF070;
    AX = Alu16.And(AX, 0xF070);
    CheckExternalEvents(cs2, 0x259E);
    // MOV ES:[0xa44d],AX (0170_259A / 0x3C9A)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs2, 0x25A0);
    // SUB AX,AX (0170_259E / 0x3C9E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x25A1);
    // PUSH AX (0170_25A0 / 0x3CA0)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x25A4);
    // MOV AX,0xfff0 (0170_25A1 / 0x3CA1)
    AX = 0xFFF0;
    CheckExternalEvents(cs2, 0x25A5);
    // PUSH AX (0170_25A4 / 0x3CA4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x25A6);
    // PUSH CS (0170_25A5 / 0x3CA5)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x25A9);
    // CALL 0x0000:301b (0170_25A6 / 0x3CA6)
    NearCall(cs2, 0x25A9, unknown_0170_191B_0301B);
    CheckExternalEvents(cs2, 0x25AC);
    // ADD SP,0x4 (0170_25A9 / 0x3CA9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x25AF);
    // MOV AX,word ptr [BP + -0xc] (0170_25AC / 0x3CAC)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x25B2);
    // ADD AX,0x10 (0170_25AF / 0x3CAF)
    // AX += 0x10;
    AX = Alu16.Add(AX, 0x10);
    CheckExternalEvents(cs2, 0x25B5);
    // MOV word ptr [BP + -0x2],AX (0170_25B2 / 0x3CB2)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x25B7);
    // MOV BX,AX (0170_25B5 / 0x3CB5)
    BX = AX;
    CheckExternalEvents(cs2, 0x25B9);
    // SHL BX,0x1 (0170_25B7 / 0x3CB7)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x25BD);
    // MOV ES,word ptr [0x53a4] (0170_25B9 / 0x3CB9)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x25C2);
    // MOV AX,word ptr ES:[BX + 0x4004] (0170_25BD / 0x3CBD)
    AX = UInt16[ES, (ushort)(BX + 0x4004)];
    CheckExternalEvents(cs2, 0x25C5);
    // MOV word ptr [BP + -0x4],AX (0170_25C2 / 0x3CC2)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x25C9);
    // MOV ES,word ptr [0x538c] (0170_25C5 / 0x3CC5)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x25CE);
    // CMP word ptr ES:[0xa44b],AX (0170_25C9 / 0x3CC9)
    Alu16.Sub(UInt16[ES, 0xA44B], AX);
    CheckExternalEvents(cs2, 0x25D0);
    // JNC 0x0000:3c52 (0170_25CE / 0x3CCE)
    if(!CarryFlag) {
      goto label_0170_2552_03C52;
    }
    CheckExternalEvents(cs2, 0x25D3);
    // MOV AX,word ptr [BP + -0x8] (0170_25D0 / 0x3CD0)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x25D5);
    // OR AL,0xf (0170_25D3 / 0x3CD3)
    // AL |= 0xF;
    AL = Alu8.Or(AL, 0xF);
    CheckExternalEvents(cs2, 0x25D9);
    // MOV ES:[0xa44b],AX (0170_25D5 / 0x3CD5)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0x25DB);
    // SUB AX,AX (0170_25D9 / 0x3CD9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x25DC);
    // PUSH AX (0170_25DB / 0x3CDB)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x25DF);
    // MOV AX,0x10 (0170_25DC / 0x3CDC)
    AX = 0x10;
    CheckExternalEvents(cs2, 0x25E0);
    // PUSH AX (0170_25DF / 0x3CDF)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x25E1);
    // PUSH CS (0170_25E0 / 0x3CE0)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x25E4);
    // CALL 0x0000:301b (0170_25E1 / 0x3CE1)
    NearCall(cs2, 0x25E4, unknown_0170_191B_0301B);
    CheckExternalEvents(cs2, 0x25E7);
    // ADD SP,0x4 (0170_25E4 / 0x3CE4)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x25EB);
    // MOV ES,word ptr [0x538c] (0170_25E7 / 0x3CE7)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x25EE);
    // MOV AX,word ptr [BP + -0x4] (0170_25EB / 0x3CEB)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x25F3);
    // CMP word ptr ES:[0xa44b],AX (0170_25EE / 0x3CEE)
    Alu16.Sub(UInt16[ES, 0xA44B], AX);
    CheckExternalEvents(cs2, 0x25F5);
    // JA 0x0000:3cf8 (0170_25F3 / 0x3CF3)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0170_25F8_03CF8;
    }
    CheckExternalEvents(cs2, 0x25F8);
    // JMP 0x0000:3c52 (0170_25F5 / 0x3CF5)
    goto label_0170_2552_03C52;
    label_0170_25F8_03CF8:
    CheckExternalEvents(cs2, 0x25FB);
    // MOV BX,word ptr [BP + -0x2] (0170_25F8 / 0x3CF8)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x25FD);
    // SHL BX,0x1 (0170_25FB / 0x3CFB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2601);
    // MOV ES,word ptr [0x53a6] (0170_25FD / 0x3CFD)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x2606);
    // MOV AX,word ptr ES:[BX + 0x4036] (0170_2601 / 0x3D01)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs2, 0x2609);
    // MOV word ptr [BP + -0x6],AX (0170_2606 / 0x3D06)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x260C);
    // MOV AX,0xfff0 (0170_2609 / 0x3D09)
    AX = 0xFFF0;
    CheckExternalEvents(cs2, 0x260D);
    // PUSH AX (0170_260C / 0x3D0C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x260F);
    // SUB AX,AX (0170_260D / 0x3D0D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x2610);
    // PUSH AX (0170_260F / 0x3D0F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2611);
    // PUSH CS (0170_2610 / 0x3D10)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2614);
    // CALL 0x0000:301b (0170_2611 / 0x3D11)
    NearCall(cs2, 0x2614, unknown_0170_191B_0301B);
    CheckExternalEvents(cs2, 0x2617);
    // ADD SP,0x4 (0170_2614 / 0x3D14)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x261B);
    // MOV ES,word ptr [0x538e] (0170_2617 / 0x3D17)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x261E);
    // MOV AX,word ptr [BP + -0x6] (0170_261B / 0x3D1B)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2623);
    // CMP word ptr ES:[0xa44d],AX (0170_261E / 0x3D1E)
    Alu16.Sub(UInt16[ES, 0xA44D], AX);
    CheckExternalEvents(cs2, 0x2625);
    // JC 0x0000:3d28 (0170_2623 / 0x3D23)
    if(CarryFlag) {
      goto label_0170_2628_03D28;
    }
    CheckExternalEvents(cs2, 0x2628);
    // JMP 0x0000:3c52 (0170_2625 / 0x3D25)
    goto label_0170_2552_03C52;
    label_0170_2628_03D28:
    CheckExternalEvents(cs2, 0x262B);
    // MOV AX,word ptr [BP + -0xa] (0170_2628 / 0x3D28)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x262D);
    // OR AL,0xf (0170_262B / 0x3D2B)
    // AL |= 0xF;
    AL = Alu8.Or(AL, 0xF);
    CheckExternalEvents(cs2, 0x2631);
    // MOV ES:[0xa44d],AX (0170_262D / 0x3D2D)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs2, 0x2634);
    // MOV AX,0x10 (0170_2631 / 0x3D31)
    AX = 0x10;
    CheckExternalEvents(cs2, 0x2635);
    // PUSH AX (0170_2634 / 0x3D34)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2637);
    // SUB AX,AX (0170_2635 / 0x3D35)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x2638);
    // PUSH AX (0170_2637 / 0x3D37)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2639);
    // PUSH CS (0170_2638 / 0x3D38)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x263C);
    // CALL 0x0000:301b (0170_2639 / 0x3D39)
    NearCall(cs2, 0x263C, unknown_0170_191B_0301B);
    CheckExternalEvents(cs2, 0x263F);
    // ADD SP,0x4 (0170_263C / 0x3D3C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x2643);
    // MOV ES,word ptr [0x538e] (0170_263F / 0x3D3F)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x2646);
    // MOV AX,word ptr [BP + -0x6] (0170_2643 / 0x3D43)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x264B);
    // CMP word ptr ES:[0xa44d],AX (0170_2646 / 0x3D46)
    Alu16.Sub(UInt16[ES, 0xA44D], AX);
    CheckExternalEvents(cs2, 0x264D);
    // JA 0x0000:3d50 (0170_264B / 0x3D4B)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0170_2650_03D50;
    }
    CheckExternalEvents(cs2, 0x2650);
    // JMP 0x0000:3c52 (0170_264D / 0x3D4D)
    goto label_0170_2552_03C52;
    label_0170_2650_03D50:
    CheckExternalEvents(cs2, 0x2653);
    // MOV BX,word ptr [BP + -0xc] (0170_2650 / 0x3D50)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x2657);
    // MOV ES,word ptr [0x53b2] (0170_2653 / 0x3D53)
    ES = UInt16[DS, 0x53B2];
    CheckExternalEvents(cs2, 0x265D);
    // MOV byte ptr ES:[BX + 0x42f6],0x1 (0170_2657 / 0x3D57)
    UInt8[ES, (ushort)(BX + 0x42F6)] = 0x1;
    CheckExternalEvents(cs2, 0x2661);
    // MOV ES,word ptr [0x538c] (0170_265D / 0x3D5D)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2664);
    // MOV AX,word ptr [BP + -0x8] (0170_2661 / 0x3D61)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x2668);
    // MOV ES:[0xa44b],AX (0170_2664 / 0x3D64)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0x266C);
    // MOV ES,word ptr [0x538e] (0170_2668 / 0x3D68)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x266F);
    // MOV AX,word ptr [BP + -0xa] (0170_266C / 0x3D6C)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x2673);
    // MOV ES:[0xa44d],AX (0170_266F / 0x3D6F)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs2, 0x2677);
    // MOV ES,word ptr [0x53d4] (0170_2673 / 0x3D73)
    ES = UInt16[DS, 0x53D4];
    CheckExternalEvents(cs2, 0x267A);
    // MOV AX,word ptr [BP + -0x4] (0170_2677 / 0x3D77)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x267E);
    // MOV ES:[0xe486],AX (0170_267A / 0x3D7A)
    UInt16[ES, 0xE486] = AX;
    CheckExternalEvents(cs2, 0x2682);
    // MOV ES,word ptr [0x53d6] (0170_267E / 0x3D7E)
    ES = UInt16[DS, 0x53D6];
    CheckExternalEvents(cs2, 0x2685);
    // MOV AX,word ptr [BP + -0x6] (0170_2682 / 0x3D82)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2689);
    // MOV ES:[0xe488],AX (0170_2685 / 0x3D85)
    UInt16[ES, 0xE488] = AX;
    CheckExternalEvents(cs2, 0x268C);
    // MOV AX,word ptr [BP + -0x4] (0170_2689 / 0x3D89)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x2690);
    // MOV ES,word ptr [0x538c] (0170_268C / 0x3D8C)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2695);
    // SUB AX,word ptr ES:[0xa44b] (0170_2690 / 0x3D90)
    // AX -= UInt16[ES, 0xA44B];
    AX = Alu16.Sub(AX, UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x2698);
    // MOV word ptr [BP + -0xe],AX (0170_2695 / 0x3D95)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs2, 0x269B);
    // MOV AX,word ptr [BP + -0x6] (0170_2698 / 0x3D98)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x269F);
    // MOV ES,word ptr [0x538e] (0170_269B / 0x3D9B)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x26A4);
    // SUB AX,word ptr ES:[0xa44d] (0170_269F / 0x3D9F)
    // AX -= UInt16[ES, 0xA44D];
    AX = Alu16.Sub(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x26A7);
    // MOV word ptr [BP + -0x10],AX (0170_26A4 / 0x3DA4)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs2, 0x26AB);
    // CMP word ptr [BP + -0xe],-0x80 (0170_26A7 / 0x3DA7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0xFF80);
    CheckExternalEvents(cs2, 0x26AD);
    // JGE 0x0000:3db2 (0170_26AB / 0x3DAB)
    if(SignFlag == OverflowFlag) {
      goto label_0170_26B2_03DB2;
    }
    CheckExternalEvents(cs2, 0x26B2);
    // ADD word ptr [BP + -0xe],0x80 (0170_26AD / 0x3DAD)
    UInt16[SS, (ushort)(BP - 0xE)] += 0x80;
    label_0170_26B2_03DB2:
    CheckExternalEvents(cs2, 0x26B7);
    // CMP word ptr [BP + -0xe],0x80 (0170_26B2 / 0x3DB2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x80);
    CheckExternalEvents(cs2, 0x26B9);
    // JLE 0x0000:3dbe (0170_26B7 / 0x3DB7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_26BE_03DBE;
    }
    CheckExternalEvents(cs2, 0x26BE);
    // SUB word ptr [BP + -0xe],0x80 (0170_26B9 / 0x3DB9)
    UInt16[SS, (ushort)(BP - 0xE)] -= 0x80;
    label_0170_26BE_03DBE:
    CheckExternalEvents(cs2, 0x26C2);
    // ADD word ptr [BP + -0xe],0x1a (0170_26BE / 0x3DBE)
    UInt16[SS, (ushort)(BP - 0xE)] += 0x1A;
    CheckExternalEvents(cs2, 0x26C7);
    // CMP word ptr [BP + -0x10],0xf080 (0170_26C2 / 0x3DC2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0xF080);
    CheckExternalEvents(cs2, 0x26C9);
    // JGE 0x0000:3dce (0170_26C7 / 0x3DC7)
    if(SignFlag == OverflowFlag) {
      goto label_0170_26CE_03DCE;
    }
    CheckExternalEvents(cs2, 0x26CE);
    // ADD word ptr [BP + -0x10],0xf80 (0170_26C9 / 0x3DC9)
    UInt16[SS, (ushort)(BP - 0x10)] += 0xF80;
    label_0170_26CE_03DCE:
    CheckExternalEvents(cs2, 0x26D3);
    // CMP word ptr [BP + -0x10],0xf80 (0170_26CE / 0x3DCE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0xF80);
    CheckExternalEvents(cs2, 0x26D5);
    // JLE 0x0000:3dda (0170_26D3 / 0x3DD3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_26DA_03DDA;
    }
    CheckExternalEvents(cs2, 0x26DA);
    // SUB word ptr [BP + -0x10],0xf80 (0170_26D5 / 0x3DD5)
    UInt16[SS, (ushort)(BP - 0x10)] -= 0xF80;
    label_0170_26DA_03DDA:
    CheckExternalEvents(cs2, 0x26DE);
    // ADD word ptr [BP + -0x10],0xc (0170_26DA / 0x3DDA)
    // UInt16[SS, (ushort)(BP - 0x10)] += 0xC;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x10)], 0xC);
    CheckExternalEvents(cs2, 0x26E1);
    // MOV AX,0x1a (0170_26DE / 0x3DDE)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x26E4);
    // IMUL word ptr [BP + -0xc] (0170_26E1 / 0x3DE1)
    int resImul0170_26E1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0170_26E1);
    DX = (ushort)(resImul0170_26E1 >> 16);
    CheckExternalEvents(cs2, 0x26E6);
    // MOV SI,AX (0170_26E4 / 0x3DE4)
    SI = AX;
    CheckExternalEvents(cs2, 0x26E9);
    // MOV AX,0x1 (0170_26E6 / 0x3DE6)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x26EA);
    // PUSH AX (0170_26E9 / 0x3DE9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x26ED);
    // PUSH word ptr [BP + -0x10] (0170_26EA / 0x3DEA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs2, 0x26F0);
    // PUSH word ptr [BP + -0xe] (0170_26ED / 0x3DED)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x26F4);
    // MOV ES,word ptr [0x538a] (0170_26F0 / 0x3DF0)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x26F9);
    // PUSH word ptr ES:[SI + 0xd396] (0170_26F4 / 0x3DF4)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0xD396)]);
    CheckExternalEvents(cs2, 0x26FE);
    // PUSH word ptr ES:[SI + 0xd394] (0170_26F9 / 0x3DF9)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0xD394)]);
    CheckExternalEvents(cs2, 0x2701);
    // PUSH word ptr [BP + -0x2] (0170_26FE / 0x3DFE)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x2706);
    // CALLF 0x0000:fa16 (0170_2701 / 0x3E01)
    FarCall(cs2, 0x2706, unknown_0FA1_0006_0FA16);
    CheckExternalEvents(cs2, 0x2709);
    // ADD SP,0xc (0170_2706 / 0x3E06)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs2, 0x270C);
    // MOV SI,word ptr [BP + -0x2] (0170_2709 / 0x3E09)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x270E);
    // SHL SI,0x1 (0170_270C / 0x3E0C)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs2, 0x2712);
    // MOV ES,word ptr [0x53d4] (0170_270E / 0x3E0E)
    ES = UInt16[DS, 0x53D4];
    CheckExternalEvents(cs2, 0x2716);
    // MOV AX,ES:[0xe486] (0170_2712 / 0x3E12)
    AX = UInt16[ES, 0xE486];
    CheckExternalEvents(cs2, 0x271A);
    // MOV ES,word ptr [0x53a4] (0170_2716 / 0x3E16)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x271F);
    // MOV word ptr ES:[SI + 0x4004],AX (0170_271A / 0x3E1A)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs2, 0x2723);
    // MOV ES,word ptr [0x53d6] (0170_271F / 0x3E1F)
    ES = UInt16[DS, 0x53D6];
    CheckExternalEvents(cs2, 0x2727);
    // MOV AX,ES:[0xe488] (0170_2723 / 0x3E23)
    AX = UInt16[ES, 0xE488];
    CheckExternalEvents(cs2, 0x272B);
    // MOV ES,word ptr [0x53a6] (0170_2727 / 0x3E27)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x2730);
    // MOV word ptr ES:[SI + 0x4036],AX (0170_272B / 0x3E2B)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs2, 0x2733);
    // MOV BX,word ptr [BP + -0x2] (0170_2730 / 0x3E30)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2737);
    // MOV ES,word ptr [0x53be] (0170_2733 / 0x3E33)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x273C);
    // MOV AL,byte ptr ES:[BX + 0x396c] (0170_2737 / 0x3E37)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs2, 0x2740);
    // MOV ES,word ptr [0x53d8] (0170_273C / 0x3E3C)
    ES = UInt16[DS, 0x53D8];
    CheckExternalEvents(cs2, 0x2745);
    // CMP byte ptr ES:[BX + 0x3920],AL (0170_2740 / 0x3E40)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x3920)], AL);
    CheckExternalEvents(cs2, 0x2747);
    // JZ 0x0000:3e6a (0170_2745 / 0x3E45)
    if(ZeroFlag) {
      goto label_0170_276A_03E6A;
    }
    CheckExternalEvents(cs2, 0x274C);
    // MOV AL,byte ptr ES:[BX + 0x3920] (0170_2747 / 0x3E47)
    AL = UInt8[ES, (ushort)(BX + 0x3920)];
    CheckExternalEvents(cs2, 0x274D);
    // CBW  (0170_274C / 0x3E4C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x274F);
    // MOV BX,AX (0170_274D / 0x3E4D)
    BX = AX;
    CheckExternalEvents(cs2, 0x2751);
    // SHL BX,0x1 (0170_274F / 0x3E4F)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x2753);
    // SHL BX,0x1 (0170_2751 / 0x3E51)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2757);
    // MOV AX,word ptr [BX + 0x27a] (0170_2753 / 0x3E53)
    AX = UInt16[DS, (ushort)(BX + 0x27A)];
    CheckExternalEvents(cs2, 0x275B);
    // MOV DX,word ptr [BX + 0x27c] (0170_2757 / 0x3E57)
    DX = UInt16[DS, (ushort)(BX + 0x27C)];
    CheckExternalEvents(cs2, 0x275E);
    // MOV BX,word ptr [BP + -0x2] (0170_275B / 0x3E5B)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2760);
    // SHL BX,0x1 (0170_275E / 0x3E5E)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x2762);
    // SHL BX,0x1 (0170_2760 / 0x3E60)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2766);
    // MOV word ptr [BX + 0x1f6],AX (0170_2762 / 0x3E62)
    UInt16[DS, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs2, 0x276A);
    // MOV word ptr [BX + 0x1f8],DX (0170_2766 / 0x3E66)
    UInt16[DS, (ushort)(BX + 0x1F8)] = DX;
    label_0170_276A_03E6A:
    CheckExternalEvents(cs2, 0x276D);
    // PUSH word ptr [BP + -0x2] (0170_276A / 0x3E6A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x276E);
    // PUSH CS (0170_276D / 0x3E6D)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2771);
    // CALL 0x0000:2e32 (0170_276E / 0x3E6E)
    NearCall(cs2, 0x2771, unknown_0170_1732_02E32);
    CheckExternalEvents(cs2, 0x2774);
    // ADD SP,0x2 (0170_2771 / 0x3E71)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x2777);
    // MOV BX,word ptr [BP + -0x2] (0170_2774 / 0x3E74)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x277B);
    // MOV ES,word ptr [0x539a] (0170_2777 / 0x3E77)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x2780);
    // MOV byte ptr ES:[BX + 0x409a],AL (0170_277B / 0x3E7B)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    CheckExternalEvents(cs2, 0x2783);
    // MOV AX,0x1a (0170_2780 / 0x3E80)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x2786);
    // IMUL word ptr [BP + -0xc] (0170_2783 / 0x3E83)
    int resImul0170_2783 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0170_2783);
    DX = (ushort)(resImul0170_2783 >> 16);
    CheckExternalEvents(cs2, 0x2788);
    // MOV SI,AX (0170_2786 / 0x3E86)
    SI = AX;
    CheckExternalEvents(cs2, 0x278B);
    // MOV DI,word ptr [BP + -0x2] (0170_2788 / 0x3E88)
    DI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x278D);
    // SHL DI,0x1 (0170_278B / 0x3E8B)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs2, 0x2791);
    // MOV ES,word ptr [0x538a] (0170_278D / 0x3E8D)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2796);
    // MOV AX,word ptr ES:[SI + 0xd394] (0170_2791 / 0x3E91)
    AX = UInt16[ES, (ushort)(SI + 0xD394)];
    CheckExternalEvents(cs2, 0x279A);
    // MOV ES,word ptr [0x53a4] (0170_2796 / 0x3E96)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x279F);
    // CMP word ptr ES:[DI + 0x4004],AX (0170_279A / 0x3E9A)
    Alu16.Sub(UInt16[ES, (ushort)(DI + 0x4004)], AX);
    CheckExternalEvents(cs2, 0x27A1);
    // JZ 0x0000:3ea4 (0170_279F / 0x3E9F)
    if(ZeroFlag) {
      goto label_0170_27A4_03EA4;
    }
    CheckExternalEvents(cs2, 0x27A4);
    // JMP 0x0000:3c52 (0170_27A1 / 0x3EA1)
    goto label_0170_2552_03C52;
    label_0170_27A4_03EA4:
    CheckExternalEvents(cs2, 0x27A8);
    // MOV ES,word ptr [0x538a] (0170_27A4 / 0x3EA4)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x27AD);
    // MOV AX,word ptr ES:[SI + 0xd396] (0170_27A8 / 0x3EA8)
    AX = UInt16[ES, (ushort)(SI + 0xD396)];
    CheckExternalEvents(cs2, 0x27B1);
    // MOV ES,word ptr [0x53a6] (0170_27AD / 0x3EAD)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x27B6);
    // CMP word ptr ES:[DI + 0x4036],AX (0170_27B1 / 0x3EB1)
    Alu16.Sub(UInt16[ES, (ushort)(DI + 0x4036)], AX);
    CheckExternalEvents(cs2, 0x27B8);
    // JZ 0x0000:3ebb (0170_27B6 / 0x3EB6)
    if(ZeroFlag) {
      goto label_0170_27BB_03EBB;
    }
    CheckExternalEvents(cs2, 0x27BB);
    // JMP 0x0000:3c52 (0170_27B8 / 0x3EB8)
    goto label_0170_2552_03C52;
    label_0170_27BB_03EBB:
    CheckExternalEvents(cs2, 0x27C0);
    // CALLF 0x1000:aab0 (0170_27BB / 0x3EBB)
    FarCall(cs2, 0x27C0, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x27C2);
    // AND AL,0x1f (0170_27C0 / 0x3EC0)
    // AL &= 0x1F;
    AL = Alu8.And(AL, 0x1F);
    CheckExternalEvents(cs2, 0x27C6);
    // MOV ES,word ptr [0x538a] (0170_27C2 / 0x3EC2)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x27CB);
    // MOV byte ptr ES:[SI + 0xd399],AL (0170_27C6 / 0x3EC6)
    UInt8[ES, (ushort)(SI + 0xD399)] = AL;
    CheckExternalEvents(cs2, 0x27CE);
    // MOV SI,word ptr [BP + -0x2] (0170_27CB / 0x3ECB)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x27D0);
    // SHL SI,0x1 (0170_27CE / 0x3ECE)
    SI <<= 0x1;
    CheckExternalEvents(cs2, 0x27D2);
    // SUB AX,AX (0170_27D0 / 0x3ED0)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x27D6);
    // MOV ES,word ptr [0x53a6] (0170_27D2 / 0x3ED2)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x27DB);
    // MOV word ptr ES:[SI + 0x4036],AX (0170_27D6 / 0x3ED6)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs2, 0x27DF);
    // MOV ES,word ptr [0x53a4] (0170_27DB / 0x3EDB)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x27E4);
    // MOV word ptr ES:[SI + 0x4004],AX (0170_27DF / 0x3EDF)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs2, 0x27E7);
    // MOV AX,0x1a (0170_27E4 / 0x3EE4)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x27EA);
    // IMUL word ptr [BP + -0xc] (0170_27E7 / 0x3EE7)
    int resImul0170_27E7 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0170_27E7);
    DX = (ushort)(resImul0170_27E7 >> 16);
    CheckExternalEvents(cs2, 0x27EC);
    // MOV SI,AX (0170_27EA / 0x3EEA)
    SI = AX;
    CheckExternalEvents(cs2, 0x27F0);
    // MOV ES,word ptr [0x538a] (0170_27EC / 0x3EEC)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x27F5);
    // MOV AL,byte ptr ES:[SI + 0xd398] (0170_27F0 / 0x3EF0)
    AL = UInt8[ES, (ushort)(SI + 0xD398)];
    CheckExternalEvents(cs2, 0x27F7);
    // SUB AH,AH (0170_27F5 / 0x3EF5)
    AH -= AH;
    CheckExternalEvents(cs2, 0x27FA);
    // AND AX,0x7 (0170_27F7 / 0x3EF7)
    // AX &= 0x7;
    AX = Alu16.And(AX, 0x7);
    CheckExternalEvents(cs2, 0x27FD);
    // MOV word ptr [BP + -0x2],AX (0170_27FA / 0x3EFA)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x27FF);
    // MOV BX,AX (0170_27FD / 0x3EFD)
    BX = AX;
    CheckExternalEvents(cs2, 0x2803);
    // MOV ES,word ptr [0x53da] (0170_27FF / 0x3EFF)
    ES = UInt16[DS, 0x53DA];
    CheckExternalEvents(cs2, 0x2808);
    // MOV AL,byte ptr ES:[BX + 0x3768] (0170_2803 / 0x3F03)
    AL = UInt8[ES, (ushort)(BX + 0x3768)];
    CheckExternalEvents(cs2, 0x2809);
    // CBW  (0170_2808 / 0x3F08)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x280C);
    // MOV word ptr [BP + -0x2],AX (0170_2809 / 0x3F09)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x280E);
    // MOV CL,0x4 (0170_280C / 0x3F0C)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x2812);
    // MOV ES,word ptr [0x538a] (0170_280E / 0x3F0E)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2817);
    // SHL byte ptr ES:[SI + 0xd398],CL (0170_2812 / 0x3F12)
    // UInt8[ES, (ushort)(SI + 0xD398)] <<= CL;
    UInt8[ES, (ushort)(SI + 0xD398)] = Alu8.Shl(UInt8[ES, (ushort)(SI + 0xD398)], CL);
    CheckExternalEvents(cs2, 0x281A);
    // MOV AL,byte ptr [BP + -0x2] (0170_2817 / 0x3F17)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x281F);
    // OR byte ptr ES:[SI + 0xd398],AL (0170_281A / 0x3F1A)
    // UInt8[ES, (ushort)(SI + 0xD398)] |= AL;
    UInt8[ES, (ushort)(SI + 0xD398)] = Alu8.Or(UInt8[ES, (ushort)(SI + 0xD398)], AL);
    CheckExternalEvents(cs2, 0x2822);
    // MOV DI,word ptr [BP + -0x2] (0170_281F / 0x3F1F)
    DI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2824);
    // SHL DI,0x1 (0170_2822 / 0x3F22)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs2, 0x2828);
    // MOV ES,word ptr [0x53ca] (0170_2824 / 0x3F24)
    ES = UInt16[DS, 0x53CA];
    CheckExternalEvents(cs2, 0x282D);
    // MOV AX,word ptr ES:[DI + 0x4564] (0170_2828 / 0x3F28)
    AX = UInt16[ES, (ushort)(DI + 0x4564)];
    CheckExternalEvents(cs2, 0x2831);
    // MOV ES,word ptr [0x538a] (0170_282D / 0x3F2D)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2836);
    // MOV word ptr ES:[SI + 0xd394],AX (0170_2831 / 0x3F31)
    UInt16[ES, (ushort)(SI + 0xD394)] = AX;
    CheckExternalEvents(cs2, 0x283A);
    // MOV ES,word ptr [0x53cc] (0170_2836 / 0x3F36)
    ES = UInt16[DS, 0x53CC];
    CheckExternalEvents(cs2, 0x283F);
    // MOV AX,word ptr ES:[DI + 0x4596] (0170_283A / 0x3F3A)
    AX = UInt16[ES, (ushort)(DI + 0x4596)];
    CheckExternalEvents(cs2, 0x2843);
    // MOV ES,word ptr [0x538a] (0170_283F / 0x3F3F)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2848);
    // MOV word ptr ES:[SI + 0xd396],AX (0170_2843 / 0x3F43)
    UInt16[ES, (ushort)(SI + 0xD396)] = AX;
    CheckExternalEvents(cs2, 0x284B);
    // JMP 0x0000:3c52 (0170_2848 / 0x3F48)
    goto label_0170_2552_03C52;
    label_0170_284B_03F4B:
    CheckExternalEvents(cs2, 0x284F);
    // MOV ES,word ptr [0x538c] (0170_284B / 0x3F4B)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2852);
    // MOV AX,word ptr [BP + -0x8] (0170_284F / 0x3F4F)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x2856);
    // MOV ES:[0xa44b],AX (0170_2852 / 0x3F52)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs2, 0x285A);
    // MOV ES,word ptr [0x538e] (0170_2856 / 0x3F56)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x285D);
    // MOV AX,word ptr [BP + -0xa] (0170_285A / 0x3F5A)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x2861);
    // MOV ES:[0xa44d],AX (0170_285D / 0x3F5D)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs2, 0x2862);
    // POP SI (0170_2861 / 0x3F61)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2863);
    // POP DI (0170_2862 / 0x3F62)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2865);
    // MOV SP,BP (0170_2863 / 0x3F63)
    SP = BP;
    CheckExternalEvents(cs2, 0x2866);
    // POP BP (0170_2865 / 0x3F65)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2867);
    // RETF  (0170_2866 / 0x3F66)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_3F67_03F67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_3F67_03F67:
    CheckExternalEvents(cs1, 0x3F68);
    // PUSH BP (0000_3F67 / 0x3F67)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x3F6A);
    // MOV BP,SP (0000_3F68 / 0x3F68)
    BP = SP;
    CheckExternalEvents(cs1, 0x3F6C);
    // XOR AX,AX (0000_3F6A / 0x3F6A)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs1, 0x3F71);
    // CALLF 0x1000:cecc (0000_3F6C / 0x3F6C)
    FarCall(cs1, 0x3F71, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x3F75);
    // MOV ES,word ptr [0x53dc] (0000_3F71 / 0x3F71)
    ES = UInt16[DS, 0x53DC];
    CheckExternalEvents(cs1, 0x3F78);
    // MOV AX,word ptr [BP + 0xa] (0000_3F75 / 0x3F75)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs1, 0x3F7C);
    // MOV ES:[0x3748],AX (0000_3F78 / 0x3F78)
    UInt16[ES, 0x3748] = AX;
    CheckExternalEvents(cs1, 0x3F80);
    // MOV ES,word ptr [0x53c0] (0000_3F7C / 0x3F7C)
    ES = UInt16[DS, 0x53C0];
    CheckExternalEvents(cs1, 0x3F83);
    // MOV AX,word ptr [BP + 0xc] (0000_3F80 / 0x3F80)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs1, 0x3F87);
    // MOV ES:[0x374e],AX (0000_3F83 / 0x3F83)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs1, 0x3F8B);
    // MOV ES,word ptr [0x5388] (0000_3F87 / 0x3F87)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x3F92);
    // MOV word ptr ES:[0x37fe],0xf (0000_3F8B / 0x3F8B)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x3F95);
    // PUSH word ptr [BP + 0x8] (0000_3F92 / 0x3F92)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs1, 0x3F98);
    // PUSH word ptr [BP + 0x6] (0000_3F95 / 0x3F95)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x3F9D);
    // CALLF 0x1000:8055 (0000_3F98 / 0x3F98)
    FarCall(cs1, 0x3F9D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x3FA0);
    // ADD SP,0x4 (0000_3F9D / 0x3F9D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x3FA1);
    // POP BP (0000_3FA0 / 0x3FA0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x3FA2);
    // RETF  (0000_3FA1 / 0x3FA1)
    return FarRet();
  }
  
  public virtual Action unknown_0170_28A2_03FA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_28A2_03FA2:
    CheckExternalEvents(cs2, 0x28A4);
    // XOR AX,AX (0170_28A2 / 0x3FA2)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs2, 0x28A9);
    // CALLF 0x1000:cecc (0170_28A4 / 0x3FA4)
    FarCall(cs2, 0x28A9, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x28AD);
    // MOV ES,word ptr [0x5388] (0170_28A9 / 0x3FA9)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs2, 0x28B4);
    // MOV word ptr ES:[0x37fe],0xa (0170_28AD / 0x3FAD)
    UInt16[ES, 0x37FE] = 0xA;
    CheckExternalEvents(cs2, 0x28B8);
    // MOV ES,word ptr [0x53a0] (0170_28B4 / 0x3FB4)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x28BE);
    // CMP word ptr ES:[0x4fba],0x0 (0170_28B8 / 0x3FB8)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x28C0);
    // JNZ 0x0000:3fcb (0170_28BE / 0x3FBE)
    if(!ZeroFlag) {
      // JNZ target is RETF, inlining.
      CheckExternalEvents(cs2, 0x28CC);
      // RETF  (0170_28CB / 0x3FCB)
      return FarRet();
    }
    CheckExternalEvents(cs2, 0x28C4);
    // MOV ES,word ptr [0x5388] (0170_28C0 / 0x3FC0)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs2, 0x28CB);
    // MOV word ptr ES:[0x37fe],0x1 (0170_28C4 / 0x3FC4)
    UInt16[ES, 0x37FE] = 0x1;
    label_0170_28CB_03FCB:
    CheckExternalEvents(cs2, 0x28CC);
    // RETF  (0170_28CB / 0x3FCB)
    return FarRet();
  }
  
  public virtual Action unknown_0170_28CC_03FCC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_28CC_03FCC:
    CheckExternalEvents(cs2, 0x28CD);
    // PUSH BP (0170_28CC / 0x3FCC)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x28CF);
    // MOV BP,SP (0170_28CD / 0x3FCD)
    BP = SP;
    CheckExternalEvents(cs2, 0x28D1);
    // XOR AX,AX (0170_28CF / 0x3FCF)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs2, 0x28D6);
    // CALLF 0x1000:cecc (0170_28D1 / 0x3FD1)
    FarCall(cs2, 0x28D6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x28D9);
    // MOV AX,word ptr [BP + 0x6] (0170_28D6 / 0x3FD6)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x28DC);
    // MOV [0x14e],AX (0170_28D9 / 0x3FD9)
    UInt16[DS, 0x14E] = AX;
    CheckExternalEvents(cs2, 0x28E0);
    // MOV ES,word ptr [0x53de] (0170_28DC / 0x3FDC)
    ES = UInt16[DS, 0x53DE];
    CheckExternalEvents(cs2, 0x28E6);
    // CMP word ptr ES:[0xd580],0x0 (0170_28E0 / 0x3FE0)
    Alu16.Sub(UInt16[ES, 0xD580], 0x0);
    CheckExternalEvents(cs2, 0x28E8);
    // JNZ 0x0000:4011 (0170_28E6 / 0x3FE6)
    if(!ZeroFlag) {
      goto label_0170_2911_04011;
    }
    CheckExternalEvents(cs2, 0x28EA);
    // SUB AX,AX (0170_28E8 / 0x3FE8)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x28EB);
    // PUSH AX (0170_28EA / 0x3FEA)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x28F0);
    // CALLF 0x1000:a03c (0170_28EB / 0x3FEB)
    FarCall(cs2, 0x28F0, ghidra_guess_1000_A03C_1A03C);
    CheckExternalEvents(cs2, 0x28F3);
    // ADD SP,0x2 (0170_28F0 / 0x3FF0)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x28F7);
    // MOV ES,word ptr [0x53e0] (0170_28F3 / 0x3FF3)
    ES = UInt16[DS, 0x53E0];
    CheckExternalEvents(cs2, 0x28FD);
    // CMP word ptr ES:[0x3ffe],0x0 (0170_28F7 / 0x3FF7)
    Alu16.Sub(UInt16[ES, 0x3FFE], 0x0);
    CheckExternalEvents(cs2, 0x28FF);
    // JZ 0x0000:4011 (0170_28FD / 0x3FFD)
    if(ZeroFlag) {
      goto label_0170_2911_04011;
    }
    CheckExternalEvents(cs2, 0x2903);
    // CMP word ptr [BP + 0x6],0x1 (0170_28FF / 0x3FFF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs2, 0x2905);
    // JLE 0x0000:4011 (0170_2903 / 0x4003)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_2911_04011;
    }
    CheckExternalEvents(cs2, 0x2908);
    // MOV AX,0x1 (0170_2905 / 0x4005)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2909);
    // PUSH AX (0170_2908 / 0x4008)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x290E);
    // CALLF 0x1000:a03c (0170_2909 / 0x4009)
    FarCall(cs2, 0x290E, ghidra_guess_1000_A03C_1A03C);
    CheckExternalEvents(cs2, 0x2911);
    // ADD SP,0x2 (0170_290E / 0x400E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0170_2911_04011:
    CheckExternalEvents(cs2, 0x2912);
    // POP BP (0170_2911 / 0x4011)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2913);
    // RETF  (0170_2912 / 0x4012)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_4013_04013(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_4013_04013:
    CheckExternalEvents(cs1, 0x4014);
    // PUSH BP (0000_4013 / 0x4013)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x4016);
    // MOV BP,SP (0000_4014 / 0x4014)
    BP = SP;
    CheckExternalEvents(cs1, 0x4019);
    // MOV AX,0x4 (0000_4016 / 0x4016)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x401E);
    // CALLF 0x1000:cecc (0000_4019 / 0x4019)
    FarCall(cs1, 0x401E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x4021);
    // PUSH word ptr [BP + 0x6] (0000_401E / 0x401E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x4022);
    // PUSH CS (0000_4021 / 0x4021)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4025);
    // CALL 0x0000:3fcc (0000_4022 / 0x4022)
    NearCall(cs1, 0x4025, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x4028);
    // ADD SP,0x2 (0000_4025 / 0x4025)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x402C);
    // MOV ES,word ptr [0x53e2] (0000_4028 / 0x4028)
    ES = UInt16[DS, 0x53E2];
    CheckExternalEvents(cs1, 0x4030);
    // MOV AX,ES:[0x4600] (0000_402C / 0x402C)
    AX = UInt16[ES, 0x4600];
    CheckExternalEvents(cs1, 0x4033);
    // MOV word ptr [BP + -0x2],AX (0000_4030 / 0x4030)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x4036);
    // MOV AX,0x4 (0000_4033 / 0x4033)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x4037);
    // PUSH AX (0000_4036 / 0x4036)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x403C);
    // CALLF 0x1000:7ee1 (0000_4037 / 0x4037)
    FarCall(cs1, 0x403C, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x403F);
    // ADD SP,0x2 (0000_403C / 0x403C)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4044);
    // CALLF 0x1000:7fe8 (0000_403F / 0x403F)
    FarCall(cs1, 0x4044, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x4048);
    // MOV ES,word ptr [0x5388] (0000_4044 / 0x4044)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x404F);
    // MOV word ptr ES:[0x37fe],0xc (0000_4048 / 0x4048)
    UInt16[ES, 0x37FE] = 0xC;
    CheckExternalEvents(cs1, 0x4053);
    // MOV ES,word ptr [0x53a0] (0000_404F / 0x404F)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x4059);
    // CMP word ptr ES:[0x4fba],0x0 (0000_4053 / 0x4053)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x405B);
    // JNZ 0x0000:4066 (0000_4059 / 0x4059)
    if(!ZeroFlag) {
      goto label_0000_4066_04066;
    }
    CheckExternalEvents(cs1, 0x405F);
    // MOV ES,word ptr [0x5388] (0000_405B / 0x405B)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs1, 0x4066);
    // MOV word ptr ES:[0x37fe],0x2 (0000_405F / 0x405F)
    UInt16[ES, 0x37FE] = 0x2;
    label_0000_4066_04066:
    CheckExternalEvents(cs1, 0x4069);
    // MOV AX,0x4ba (0000_4066 / 0x4066)
    AX = 0x4BA;
    CheckExternalEvents(cs1, 0x406A);
    // PUSH DS (0000_4069 / 0x4069)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x406B);
    // PUSH AX (0000_406A / 0x406A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4070);
    // CALLF 0x1000:8055 (0000_406B / 0x406B)
    FarCall(cs1, 0x4070, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4073);
    // ADD SP,0x4 (0000_4070 / 0x4070)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x4078);
    // CMP word ptr [0x14e],0x1 (0000_4073 / 0x4073)
    Alu16.Sub(UInt16[DS, 0x14E], 0x1);
    CheckExternalEvents(cs1, 0x407A);
    // JNZ 0x0000:407f (0000_4078 / 0x4078)
    if(!ZeroFlag) {
      goto label_0000_407F_0407F;
    }
    CheckExternalEvents(cs1, 0x407D);
    // MOV AX,0x4cf (0000_407A / 0x407A)
    AX = 0x4CF;
    CheckExternalEvents(cs1, 0x407F);
    // JMP 0x0000:4082 (0000_407D / 0x407D)
    goto label_0000_4082_04082;
    label_0000_407F_0407F:
    CheckExternalEvents(cs1, 0x4082);
    // MOV AX,0x4d9 (0000_407F / 0x407F)
    AX = 0x4D9;
    label_0000_4082_04082:
    CheckExternalEvents(cs1, 0x4083);
    // PUSH DS (0000_4082 / 0x4082)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4084);
    // PUSH AX (0000_4083 / 0x4083)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4089);
    // CALLF 0x1000:8055 (0000_4084 / 0x4084)
    FarCall(cs1, 0x4089, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x408C);
    // ADD SP,0x4 (0000_4089 / 0x4089)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x408F);
    // MOV AX,0x4e0 (0000_408C / 0x408C)
    AX = 0x4E0;
    CheckExternalEvents(cs1, 0x4090);
    // PUSH DS (0000_408F / 0x408F)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4091);
    // PUSH AX (0000_4090 / 0x4090)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4096);
    // CALLF 0x1000:8055 (0000_4091 / 0x4091)
    FarCall(cs1, 0x4096, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4099);
    // ADD SP,0x4 (0000_4096 / 0x4096)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x409D);
    // MOV ES,word ptr [0x53e0] (0000_4099 / 0x4099)
    ES = UInt16[DS, 0x53E0];
    CheckExternalEvents(cs1, 0x40A3);
    // CMP word ptr ES:[0x3ffe],0x0 (0000_409D / 0x409D)
    Alu16.Sub(UInt16[ES, 0x3FFE], 0x0);
    CheckExternalEvents(cs1, 0x40A5);
    // JNZ 0x0000:40aa (0000_40A3 / 0x40A3)
    if(!ZeroFlag) {
      goto label_0000_40AA_040AA;
    }
    CheckExternalEvents(cs1, 0x40A8);
    // MOV AX,0x4e5 (0000_40A5 / 0x40A5)
    AX = 0x4E5;
    CheckExternalEvents(cs1, 0x40AA);
    // JMP 0x0000:40be (0000_40A8 / 0x40A8)
    goto label_0000_40BE_040BE;
    label_0000_40AA_040AA:
    CheckExternalEvents(cs1, 0x40AE);
    // CMP word ptr [BP + 0x6],0x1 (0000_40AA / 0x40AA)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x1);
    CheckExternalEvents(cs1, 0x40B0);
    // JZ 0x0000:40b4 (0000_40AE / 0x40AE)
    if(ZeroFlag) {
      goto label_0000_40B4_040B4;
    }
    CheckExternalEvents(cs1, 0x40B2);
    // MOV AL,0x1 (0000_40B0 / 0x40B0)
    AL = 0x1;
    CheckExternalEvents(cs1, 0x40B4);
    // JMP 0x0000:40b6 (0000_40B2 / 0x40B2)
    goto label_0000_40B6_040B6;
    label_0000_40B4_040B4:
    CheckExternalEvents(cs1, 0x40B6);
    // SUB AL,AL (0000_40B4 / 0x40B4)
    AL -= AL;
    label_0000_40B6_040B6:
    CheckExternalEvents(cs1, 0x40B8);
    // ADD AL,0x41 (0000_40B6 / 0x40B6)
    // AL += 0x41;
    AL = Alu8.Add(AL, 0x41);
    CheckExternalEvents(cs1, 0x40BB);
    // MOV [0x50a],AL (0000_40B8 / 0x40B8)
    UInt8[DS, 0x50A] = AL;
    CheckExternalEvents(cs1, 0x40BE);
    // MOV AX,0x504 (0000_40BB / 0x40BB)
    AX = 0x504;
    label_0000_40BE_040BE:
    CheckExternalEvents(cs1, 0x40BF);
    // PUSH DS (0000_40BE / 0x40BE)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x40C0);
    // PUSH AX (0000_40BF / 0x40BF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x40C5);
    // CALLF 0x1000:8055 (0000_40C0 / 0x40C0)
    FarCall(cs1, 0x40C5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x40C8);
    // ADD SP,0x4 (0000_40C5 / 0x40C5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x40CB);
    // MOV AX,0x4ef (0000_40C8 / 0x40C8)
    AX = 0x4EF;
    CheckExternalEvents(cs1, 0x40CC);
    // PUSH DS (0000_40CB / 0x40CB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x40CD);
    // PUSH AX (0000_40CC / 0x40CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x40D2);
    // CALLF 0x1000:8055 (0000_40CD / 0x40CD)
    FarCall(cs1, 0x40D2, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x40D5);
    // ADD SP,0x4 (0000_40D2 / 0x40D2)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x40D6);
    // PUSH CS (0000_40D5 / 0x40D5)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x40D9);
    // CALL 0x0000:412b (0000_40D6 / 0x40D6)
    NearCall(cs1, 0x40D9, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs1, 0x40DE);
    // CALLF 0x1000:8d29 (0000_40D9 / 0x40D9)
    FarCall(cs1, 0x40DE, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x40E1);
    // MOV word ptr [BP + 0x6],AX (0000_40DE / 0x40DE)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0x40E6);
    // CALLF 0x1000:7fe8 (0000_40E1 / 0x40E1)
    FarCall(cs1, 0x40E6, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x40E9);
    // PUSH word ptr [BP + -0x2] (0000_40E6 / 0x40E6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x40EE);
    // CALLF 0x1000:7ee1 (0000_40E9 / 0x40E9)
    FarCall(cs1, 0x40EE, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x40F1);
    // MOV AX,word ptr [BP + 0x6] (0000_40EE / 0x40EE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x40F3);
    // MOV SP,BP (0000_40F1 / 0x40F1)
    SP = BP;
    CheckExternalEvents(cs1, 0x40F4);
    // POP BP (0000_40F3 / 0x40F3)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x40F5);
    // RETF  (0000_40F4 / 0x40F4)
    return FarRet();
  }
  
  public virtual Action unknown_0170_29F5_040F5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_29F5_040F5:
    CheckExternalEvents(cs2, 0x29F6);
    // PUSH BP (0170_29F5 / 0x40F5)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x29F8);
    // MOV BP,SP (0170_29F6 / 0x40F6)
    BP = SP;
    CheckExternalEvents(cs2, 0x29FB);
    // MOV AX,0x8 (0170_29F8 / 0x40F8)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x2A00);
    // CALLF 0x1000:cecc (0170_29FB / 0x40FB)
    FarCall(cs2, 0x2A00, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x2A04);
    // MOV ES,word ptr [0x538a] (0170_2A00 / 0x4100)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2A08);
    // MOV AL,ES:[0xd33f] (0170_2A04 / 0x4104)
    AL = UInt8[ES, 0xD33F];
    CheckExternalEvents(cs2, 0x2A0A);
    // SUB AH,AH (0170_2A08 / 0x4108)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x2A0D);
    // MOV word ptr [BP + -0x4],AX (0170_2A0A / 0x410A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x2A11);
    // MOV AL,ES:[0xd340] (0170_2A0D / 0x410D)
    AL = UInt8[ES, 0xD340];
    CheckExternalEvents(cs2, 0x2A14);
    // MOV word ptr [BP + -0x2],AX (0170_2A11 / 0x4111)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x2A17);
    // MOV AH,byte ptr [BP + -0x2] (0170_2A14 / 0x4114)
    AH = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2A19);
    // SUB AL,AL (0170_2A17 / 0x4117)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs2, 0x2A1C);
    // OR AX,word ptr [BP + -0x4] (0170_2A19 / 0x4119)
    // AX |= UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Or(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x2A1F);
    // MOV word ptr [BP + -0x8],AX (0170_2A1C / 0x411C)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x2A24);
    // MOV word ptr [BP + -0x6],0x0 (0170_2A1F / 0x411F)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs2, 0x2A27);
    // MOV DX,word ptr [BP + -0x6] (0170_2A24 / 0x4124)
    DX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2A29);
    // MOV SP,BP (0170_2A27 / 0x4127)
    SP = BP;
    CheckExternalEvents(cs2, 0x2A2A);
    // POP BP (0170_2A29 / 0x4129)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2A2B);
    // RETF  (0170_2A2A / 0x412A)
    return FarRet();
  }
  
  public virtual Action unknown_0170_2A2B_0412B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_2A2B_0412B:
    CheckExternalEvents(cs2, 0x2A2D);
    // XOR AX,AX (0170_2A2B / 0x412B)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs2, 0x2A32);
    // CALLF 0x1000:cecc (0170_2A2D / 0x412D)
    FarCall(cs2, 0x2A32, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x2A36);
    // MOV ES,word ptr [0x5384] (0170_2A32 / 0x4132)
    ES = UInt16[DS, 0x5384];
    CheckExternalEvents(cs2, 0x2A3C);
    // CMP word ptr ES:[0x3938],0x0 (0170_2A36 / 0x4136)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs2, 0x2A3E);
    // JNZ 0x0000:414e (0170_2A3C / 0x413C)
    if(!ZeroFlag) {
      // JNZ target is RETF, inlining.
      CheckExternalEvents(cs2, 0x2A4F);
      // RETF  (0170_2A4E / 0x414E)
      return FarRet();
    }
    CheckExternalEvents(cs2, 0x2A40);
    // JMP 0x0000:4145 (0170_2A3E / 0x413E)
    goto label_0170_2A45_04145;
    label_0170_2A40_04140:
    CheckExternalEvents(cs2, 0x2A45);
    // CALLF 0x1000:8d29 (0170_2A40 / 0x4140)
    FarCall(cs2, 0x2A45, unknown_18AD_0259_18D29);
    label_0170_2A45_04145:
    CheckExternalEvents(cs2, 0x2A4A);
    // CALLF 0x1000:8aff (0170_2A45 / 0x4145)
    FarCall(cs2, 0x2A4A, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs2, 0x2A4C);
    // OR AX,AX (0170_2A4A / 0x414A)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs2, 0x2A4E);
    // JNZ 0x0000:4140 (0170_2A4C / 0x414C)
    if(!ZeroFlag) {
      goto label_0170_2A40_04140;
    }
    label_0170_2A4E_0414E:
    CheckExternalEvents(cs2, 0x2A4F);
    // RETF  (0170_2A4E / 0x414E)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_414F_0414F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_414F_0414F:
    CheckExternalEvents(cs1, 0x4151);
    // XOR AX,AX (0000_414F / 0x414F)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs1, 0x4156);
    // CALLF 0x1000:cecc (0000_4151 / 0x4151)
    FarCall(cs1, 0x4156, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x4159);
    // MOV AX,0x50d (0000_4156 / 0x4156)
    AX = 0x50D;
    CheckExternalEvents(cs1, 0x415A);
    // PUSH DS (0000_4159 / 0x4159)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x415B);
    // PUSH AX (0000_415A / 0x415A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4160);
    // CALLF 0x1000:8055 (0000_415B / 0x415B)
    FarCall(cs1, 0x4160, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4163);
    // ADD SP,0x4 (0000_4160 / 0x4160)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4168);
    // CALLF 0x1000:8d29 (0000_4163 / 0x4163)
    FarCall(cs1, 0x4168, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x4169);
    // RETF  (0000_4168 / 0x4168)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_4169_04169(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_4169_04169:
    CheckExternalEvents(cs1, 0x416B);
    // XOR AX,AX (0000_4169 / 0x4169)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs1, 0x4170);
    // CALLF 0x1000:cecc (0000_416B / 0x416B)
    FarCall(cs1, 0x4170, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x4173);
    // MOV AX,0x51b (0000_4170 / 0x4170)
    AX = 0x51B;
    CheckExternalEvents(cs1, 0x4174);
    // PUSH DS (0000_4173 / 0x4173)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4175);
    // PUSH AX (0000_4174 / 0x4174)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x417A);
    // CALLF 0x1000:8055 (0000_4175 / 0x4175)
    FarCall(cs1, 0x417A, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x417D);
    // ADD SP,0x4 (0000_417A / 0x417A)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x417E);
    // RETF  (0000_417D / 0x417D)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_417E_0417E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_417E_0417E:
    CheckExternalEvents(cs1, 0x4180);
    // XOR AX,AX (0000_417E / 0x417E)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs1, 0x4185);
    // CALLF 0x1000:cecc (0000_4180 / 0x4180)
    FarCall(cs1, 0x4185, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x4188);
    // MOV AX,0x51d (0000_4185 / 0x4185)
    AX = 0x51D;
    CheckExternalEvents(cs1, 0x4189);
    // PUSH DS (0000_4188 / 0x4188)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x418A);
    // PUSH AX (0000_4189 / 0x4189)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x418F);
    // CALLF 0x1000:8055 (0000_418A / 0x418A)
    FarCall(cs1, 0x418F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4192);
    // ADD SP,0x4 (0000_418F / 0x418F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x4193);
    // RETF  (0000_4192 / 0x4192)
    return FarRet();
  }
  
  public virtual Action unknown_0170_2A93_04193(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_2A93_04193:
    CheckExternalEvents(cs2, 0x2A94);
    // PUSH BP (0170_2A93 / 0x4193)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x2A96);
    // MOV BP,SP (0170_2A94 / 0x4194)
    BP = SP;
    CheckExternalEvents(cs2, 0x2A99);
    // MOV AX,0xe (0170_2A96 / 0x4196)
    AX = 0xE;
    CheckExternalEvents(cs2, 0x2A9E);
    // CALLF 0x1000:cecc (0170_2A99 / 0x4199)
    FarCall(cs2, 0x2A9E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x2AA2);
    // MOV ES,word ptr [0x538c] (0170_2A9E / 0x419E)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2AA6);
    // MOV AX,ES:[0xa44b] (0170_2AA2 / 0x41A2)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x2AAA);
    // MOV ES,word ptr [0x538e] (0170_2AA6 / 0x41A6)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x2AAF);
    // OR AX,word ptr ES:[0xa44d] (0170_2AAA / 0x41AA)
    // AX |= UInt16[ES, 0xA44D];
    AX = Alu16.Or(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x2AB1);
    // MOV CL,0x8 (0170_2AAF / 0x41AF)
    CL = 0x8;
    CheckExternalEvents(cs2, 0x2AB3);
    // SHR AX,CL (0170_2AB1 / 0x41B1)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs2, 0x2AB6);
    // MOV word ptr [BP + -0x4],AX (0170_2AB3 / 0x41B3)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x2ABB);
    // MOV word ptr [BP + -0xa],0x0 (0170_2AB6 / 0x41B6)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs2, 0x2ABD);
    // JMP 0x0000:4215 (0170_2ABB / 0x41BB)
    goto label_0170_2B15_04215;
    label_0170_2ABD_041BD:
    CheckExternalEvents(cs2, 0x2AC0);
    // MOV AX,word ptr [BP + -0x8] (0170_2ABD / 0x41BD)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x2AC2);
    // MOV CL,0x3 (0170_2AC0 / 0x41C0)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x2AC4);
    // SHL AX,CL (0170_2AC2 / 0x41C2)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs2, 0x2AC5);
    // PUSH AX (0170_2AC4 / 0x41C4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2AC8);
    // MOV AX,word ptr [BP + -0x6] (0170_2AC5 / 0x41C5)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2ACA);
    // SHL AX,CL (0170_2AC8 / 0x41C8)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs2, 0x2ACB);
    // PUSH AX (0170_2ACA / 0x41CA)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2ACE);
    // MOV BX,word ptr [BP + -0xa] (0170_2ACB / 0x41CB)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x2AD2);
    // MOV ES,word ptr [0x538a] (0170_2ACE / 0x41CE)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2AD7);
    // MOV BL,byte ptr ES:[BX + 0xd457] (0170_2AD2 / 0x41D2)
    BL = UInt8[ES, (ushort)(BX + 0xD457)];
    CheckExternalEvents(cs2, 0x2AD9);
    // SUB BH,BH (0170_2AD7 / 0x41D7)
    BH -= BH;
    CheckExternalEvents(cs2, 0x2ADB);
    // SHL BX,0x1 (0170_2AD9 / 0x41D9)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x2ADD);
    // SHL BX,0x1 (0170_2ADB / 0x41DB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2AE1);
    // MOV ES,word ptr [0x539e] (0170_2ADD / 0x41DD)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0x2AE6);
    // PUSH word ptr ES:[BX + 0x39fc] (0170_2AE1 / 0x41E1)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FC)]);
    CheckExternalEvents(cs2, 0x2AEB);
    // PUSH word ptr ES:[BX + 0x39fa] (0170_2AE6 / 0x41E6)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FA)]);
    CheckExternalEvents(cs2, 0x2AED);
    // SUB AX,AX (0170_2AEB / 0x41EB)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x2AF0);
    // MOV DX,0xac00 (0170_2AED / 0x41ED)
    DX = 0xAC00;
    CheckExternalEvents(cs2, 0x2AF1);
    // PUSH DX (0170_2AF0 / 0x41F0)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2AF2);
    // PUSH AX (0170_2AF1 / 0x41F1)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2AF7);
    // CALLF 0x1000:a267 (0170_2AF2 / 0x41F2)
    FarCall(cs2, 0x2AF7, ghidra_guess_1000_A267_1A267);
    label_0170_2AF7_041F7:
    CheckExternalEvents(cs2, 0x2AFA);
    // ADD SP,0xc (0170_2AF7 / 0x41F7)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs2, 0x2AFD);
    // MOV BX,word ptr [BP + -0xa] (0170_2AFA / 0x41FA)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x2B01);
    // MOV ES,word ptr [0x538a] (0170_2AFD / 0x41FD)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2B06);
    // MOV AL,byte ptr ES:[BX + 0xd457] (0170_2B01 / 0x4201)
    AL = UInt8[ES, (ushort)(BX + 0xD457)];
    CheckExternalEvents(cs2, 0x2B08);
    // AND AL,0x7e (0170_2B06 / 0x4206)
    AL &= 0x7E;
    CheckExternalEvents(cs2, 0x2B0A);
    // CMP AL,0x7c (0170_2B08 / 0x4208)
    Alu8.Sub(AL, 0x7C);
    CheckExternalEvents(cs2, 0x2B0C);
    // JNZ 0x0000:4212 (0170_2B0A / 0x420A)
    if(!ZeroFlag) {
      goto label_0170_2B12_04212;
    }
    CheckExternalEvents(cs2, 0x2B12);
    // XOR byte ptr ES:[BX + 0xd457],0x1 (0170_2B0C / 0x420C)
    UInt8[ES, (ushort)(BX + 0xD457)] ^= 0x1;
    label_0170_2B12_04212:
    CheckExternalEvents(cs2, 0x2B15);
    // INC word ptr [BP + -0xa] (0170_2B12 / 0x4212)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    label_0170_2B15_04215:
    CheckExternalEvents(cs2, 0x2B19);
    // CMP word ptr [BP + -0xa],0x40 (0170_2B15 / 0x4215)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x40);
    CheckExternalEvents(cs2, 0x2B1B);
    // JL 0x0000:421e (0170_2B19 / 0x4219)
    if(SignFlag != OverflowFlag) {
      goto label_0170_2B1E_0421E;
    }
    CheckExternalEvents(cs2, 0x2B1E);
    // JMP 0x0000:434c (0170_2B1B / 0x421B)
    goto label_0170_2C4C_0434C;
    label_0170_2B1E_0421E:
    CheckExternalEvents(cs2, 0x2B21);
    // MOV BX,word ptr [BP + -0xa] (0170_2B1E / 0x421E)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x2B25);
    // MOV ES,word ptr [0x538a] (0170_2B21 / 0x4221)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2B2A);
    // MOV AL,byte ptr ES:[BX + 0xd497] (0170_2B25 / 0x4225)
    AL = UInt8[ES, (ushort)(BX + 0xD497)];
    CheckExternalEvents(cs2, 0x2B2C);
    // SUB AH,AH (0170_2B2A / 0x422A)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x2B2F);
    // MOV word ptr [BP + -0x2],AX (0170_2B2C / 0x422C)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x2B34);
    // MOV AL,byte ptr ES:[BX + 0xd4d7] (0170_2B2F / 0x422F)
    AL = UInt8[ES, (ushort)(BX + 0xD4D7)];
    CheckExternalEvents(cs2, 0x2B37);
    // MOV word ptr [BP + -0x6],AX (0170_2B34 / 0x4234)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x2B3A);
    // MOV AX,word ptr [BP + -0x2] (0170_2B37 / 0x4237)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2B3D);
    // AND AX,0xf (0170_2B3A / 0x423A)
    // AX &= 0xF;
    AX = Alu16.And(AX, 0xF);
    CheckExternalEvents(cs2, 0x2B3F);
    // MOV CH,AL (0170_2B3D / 0x423D)
    CH = AL;
    CheckExternalEvents(cs2, 0x2B41);
    // SUB CL,CL (0170_2B3F / 0x423F)
    // CL -= CL;
    CL = Alu8.Sub(CL, CL);
    CheckExternalEvents(cs2, 0x2B44);
    // OR word ptr [BP + -0x6],CX (0170_2B41 / 0x4241)
    // UInt16[SS, (ushort)(BP - 0x6)] |= CX;
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Or(UInt16[SS, (ushort)(BP - 0x6)], CX);
    CheckExternalEvents(cs2, 0x2B49);
    // MOV AL,byte ptr ES:[BX + 0xd517] (0170_2B44 / 0x4244)
    AL = UInt8[ES, (ushort)(BX + 0xD517)];
    CheckExternalEvents(cs2, 0x2B4B);
    // SUB AH,AH (0170_2B49 / 0x4249)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x2B4E);
    // MOV word ptr [BP + -0x8],AX (0170_2B4B / 0x424B)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x2B51);
    // MOV AX,word ptr [BP + -0x2] (0170_2B4E / 0x424E)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2B54);
    // AND AX,0xf0 (0170_2B51 / 0x4251)
    // AX &= 0xF0;
    AX = Alu16.And(AX, 0xF0);
    CheckExternalEvents(cs2, 0x2B56);
    // MOV CH,AL (0170_2B54 / 0x4254)
    CH = AL;
    CheckExternalEvents(cs2, 0x2B59);
    // OR word ptr [BP + -0x8],CX (0170_2B56 / 0x4256)
    // UInt16[SS, (ushort)(BP - 0x8)] |= CX;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Or(UInt16[SS, (ushort)(BP - 0x8)], CX);
    CheckExternalEvents(cs2, 0x2B5C);
    // MOV AX,word ptr [BP + -0x6] (0170_2B59 / 0x4259)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2B60);
    // MOV ES,word ptr [0x538c] (0170_2B5C / 0x425C)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2B65);
    // SUB AX,word ptr ES:[0xa44b] (0170_2B60 / 0x4260)
    AX -= UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x2B68);
    // ADD AX,0x1a (0170_2B65 / 0x4265)
    // AX += 0x1A;
    AX = Alu16.Add(AX, 0x1A);
    CheckExternalEvents(cs2, 0x2B6B);
    // MOV word ptr [BP + -0x6],AX (0170_2B68 / 0x4268)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x2B6E);
    // MOV AX,word ptr [BP + -0x8] (0170_2B6B / 0x426B)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x2B72);
    // MOV ES,word ptr [0x538e] (0170_2B6E / 0x426E)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x2B77);
    // SUB AX,word ptr ES:[0xa44d] (0170_2B72 / 0x4272)
    AX -= UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x2B7A);
    // ADD AX,0xc (0170_2B77 / 0x4277)
    // AX += 0xC;
    AX = Alu16.Add(AX, 0xC);
    CheckExternalEvents(cs2, 0x2B7D);
    // MOV word ptr [BP + -0x8],AX (0170_2B7A / 0x427A)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x2B7F);
    // SUB AX,AX (0170_2B7D / 0x427D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x2B82);
    // MOV word ptr [BP + -0xe],AX (0170_2B7F / 0x427F)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs2, 0x2B85);
    // MOV word ptr [BP + -0xc],AX (0170_2B82 / 0x4282)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs2, 0x2B88);
    // MOV AL,byte ptr [BP + -0x4] (0170_2B85 / 0x4285)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x2B8A);
    // AND AL,0xf (0170_2B88 / 0x4288)
    // AL &= 0xF;
    AL = Alu8.And(AL, 0xF);
    CheckExternalEvents(cs2, 0x2B8D);
    // MOV CL,byte ptr [BP + -0x2] (0170_2B8A / 0x428A)
    CL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2B90);
    // AND CL,0xf (0170_2B8D / 0x428D)
    CL &= 0xF;
    CheckExternalEvents(cs2, 0x2B92);
    // CMP AL,CL (0170_2B90 / 0x4290)
    Alu8.Sub(AL, CL);
    CheckExternalEvents(cs2, 0x2B94);
    // JNZ 0x0000:42a5 (0170_2B92 / 0x4292)
    if(!ZeroFlag) {
      goto label_0170_2BA5_042A5;
    }
    CheckExternalEvents(cs2, 0x2B98);
    // CMP word ptr [BP + -0x6],0xd (0170_2B94 / 0x4294)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0xD);
    CheckExternalEvents(cs2, 0x2B9A);
    // JL 0x0000:42a0 (0170_2B98 / 0x4298)
    if(SignFlag != OverflowFlag) {
      goto label_0170_2BA0_042A0;
    }
    CheckExternalEvents(cs2, 0x2B9E);
    // CMP word ptr [BP + -0x6],0x27 (0170_2B9A / 0x429A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x27);
    CheckExternalEvents(cs2, 0x2BA0);
    // JLE 0x0000:42a5 (0170_2B9E / 0x429E)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_2BA5_042A5;
    }
    label_0170_2BA0_042A0:
    CheckExternalEvents(cs2, 0x2BA5);
    // MOV word ptr [BP + -0xc],0x1 (0170_2BA0 / 0x42A0)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x1;
    label_0170_2BA5_042A5:
    CheckExternalEvents(cs2, 0x2BA8);
    // MOV AL,byte ptr [BP + -0x4] (0170_2BA5 / 0x42A5)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x2BAA);
    // AND AL,0xf0 (0170_2BA8 / 0x42A8)
    // AL &= 0xF0;
    AL = Alu8.And(AL, 0xF0);
    CheckExternalEvents(cs2, 0x2BAD);
    // MOV CL,byte ptr [BP + -0x2] (0170_2BAA / 0x42AA)
    CL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x2BB0);
    // AND CL,0xf0 (0170_2BAD / 0x42AD)
    CL &= 0xF0;
    CheckExternalEvents(cs2, 0x2BB2);
    // CMP AL,CL (0170_2BB0 / 0x42B0)
    Alu8.Sub(AL, CL);
    CheckExternalEvents(cs2, 0x2BB4);
    // JNZ 0x0000:42c5 (0170_2BB2 / 0x42B2)
    if(!ZeroFlag) {
      goto label_0170_2BC5_042C5;
    }
    CheckExternalEvents(cs2, 0x2BB8);
    // CMP word ptr [BP + -0x8],0x0 (0170_2BB4 / 0x42B4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x2BBA);
    // JL 0x0000:42c0 (0170_2BB8 / 0x42B8)
    if(SignFlag != OverflowFlag) {
      goto label_0170_2BC0_042C0;
    }
    CheckExternalEvents(cs2, 0x2BBE);
    // CMP word ptr [BP + -0x8],0x18 (0170_2BBA / 0x42BA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x18);
    CheckExternalEvents(cs2, 0x2BC0);
    // JLE 0x0000:42c5 (0170_2BBE / 0x42BE)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_2BC5_042C5;
    }
    label_0170_2BC0_042C0:
    CheckExternalEvents(cs2, 0x2BC5);
    // MOV word ptr [BP + -0xe],0x1 (0170_2BC0 / 0x42C0)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    label_0170_2BC5_042C5:
    CheckExternalEvents(cs2, 0x2BC9);
    // CMP word ptr [BP + -0x6],-0x73 (0170_2BC5 / 0x42C5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0xFF8D);
    CheckExternalEvents(cs2, 0x2BCB);
    // JGE 0x0000:42ce (0170_2BC9 / 0x42C9)
    if(SignFlag == OverflowFlag) {
      goto label_0170_2BCE_042CE;
    }
    CheckExternalEvents(cs2, 0x2BCE);
    // JMP 0x0000:4212 (0170_2BCB / 0x42CB)
    goto label_0170_2B12_04212;
    label_0170_2BCE_042CE:
    CheckExternalEvents(cs2, 0x2BD3);
    // CMP word ptr [BP + -0x6],0xa7 (0170_2BCE / 0x42CE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0xA7);
    CheckExternalEvents(cs2, 0x2BD5);
    // JLE 0x0000:42d8 (0170_2BD3 / 0x42D3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_2BD8_042D8;
    }
    CheckExternalEvents(cs2, 0x2BD8);
    // JMP 0x0000:4212 (0170_2BD5 / 0x42D5)
    goto label_0170_2B12_04212;
    label_0170_2BD8_042D8:
    CheckExternalEvents(cs2, 0x2BDD);
    // CMP word ptr [BP + -0x8],0xf080 (0170_2BD8 / 0x42D8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xF080);
    CheckExternalEvents(cs2, 0x2BDF);
    // JGE 0x0000:42e2 (0170_2BDD / 0x42DD)
    if(SignFlag == OverflowFlag) {
      goto label_0170_2BE2_042E2;
    }
    CheckExternalEvents(cs2, 0x2BE2);
    // JMP 0x0000:4212 (0170_2BDF / 0x42DF)
    goto label_0170_2B12_04212;
    label_0170_2BE2_042E2:
    CheckExternalEvents(cs2, 0x2BE7);
    // CMP word ptr [BP + -0x8],0xf98 (0170_2BE2 / 0x42E2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0xF98);
    CheckExternalEvents(cs2, 0x2BE9);
    // JLE 0x0000:42ec (0170_2BE7 / 0x42E7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_2BEC_042EC;
    }
    CheckExternalEvents(cs2, 0x2BEC);
    // JMP 0x0000:4212 (0170_2BE9 / 0x42E9)
    goto label_0170_2B12_04212;
    label_0170_2BEC_042EC:
    CheckExternalEvents(cs2, 0x2BEF);
    // MOV AX,word ptr [BP + -0xc] (0170_2BEC / 0x42EC)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x2BF2);
    // ADD AX,word ptr [BP + -0xe] (0170_2BEF / 0x42EF)
    // AX += UInt16[SS, (ushort)(BP - 0xE)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2BF4);
    // JZ 0x0000:42f7 (0170_2BF2 / 0x42F2)
    if(ZeroFlag) {
      goto label_0170_2BF7_042F7;
    }
    CheckExternalEvents(cs2, 0x2BF7);
    // JMP 0x0000:4212 (0170_2BF4 / 0x42F4)
    goto label_0170_2B12_04212;
    label_0170_2BF7_042F7:
    CheckExternalEvents(cs2, 0x2BFB);
    // AND word ptr [BP + -0x6],0x7f (0170_2BF7 / 0x42F7)
    UInt16[SS, (ushort)(BP - 0x6)] &= 0x7F;
    CheckExternalEvents(cs2, 0x2BFF);
    // AND word ptr [BP + -0x8],0x7f (0170_2BFB / 0x42FB)
    // UInt16[SS, (ushort)(BP - 0x8)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x8)], 0x7F);
    CheckExternalEvents(cs2, 0x2C03);
    // MOV ES,word ptr [0x53a0] (0170_2BFF / 0x42FF)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x2C09);
    // CMP word ptr ES:[0x4fba],0x2 (0170_2C03 / 0x4303)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x2C0B);
    // JNZ 0x0000:430e (0170_2C09 / 0x4309)
    if(!ZeroFlag) {
      goto label_0170_2C0E_0430E;
    }
    CheckExternalEvents(cs2, 0x2C0E);
    // JMP 0x0000:41bd (0170_2C0B / 0x430B)
    goto label_0170_2ABD_041BD;
    label_0170_2C0E_0430E:
    CheckExternalEvents(cs2, 0x2C11);
    // MOV AX,word ptr [BP + -0x8] (0170_2C0E / 0x430E)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x2C13);
    // MOV CL,0x3 (0170_2C11 / 0x4311)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x2C15);
    // SHL AX,CL (0170_2C13 / 0x4313)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs2, 0x2C16);
    // PUSH AX (0170_2C15 / 0x4315)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2C19);
    // MOV AX,word ptr [BP + -0x6] (0170_2C16 / 0x4316)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x2C1B);
    // SHL AX,CL (0170_2C19 / 0x4319)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs2, 0x2C1C);
    // PUSH AX (0170_2C1B / 0x431B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2C1F);
    // MOV BX,word ptr [BP + -0xa] (0170_2C1C / 0x431C)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x2C23);
    // MOV ES,word ptr [0x538a] (0170_2C1F / 0x431F)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2C28);
    // MOV BL,byte ptr ES:[BX + 0xd457] (0170_2C23 / 0x4323)
    BL = UInt8[ES, (ushort)(BX + 0xD457)];
    CheckExternalEvents(cs2, 0x2C2A);
    // SUB BH,BH (0170_2C28 / 0x4328)
    BH -= BH;
    CheckExternalEvents(cs2, 0x2C2C);
    // SHL BX,0x1 (0170_2C2A / 0x432A)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x2C2E);
    // SHL BX,0x1 (0170_2C2C / 0x432C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x2C32);
    // MOV ES,word ptr [0x539e] (0170_2C2E / 0x432E)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs2, 0x2C37);
    // PUSH word ptr ES:[BX + 0x39fc] (0170_2C32 / 0x4332)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FC)]);
    CheckExternalEvents(cs2, 0x2C3C);
    // PUSH word ptr ES:[BX + 0x39fa] (0170_2C37 / 0x4337)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x39FA)]);
    CheckExternalEvents(cs2, 0x2C3F);
    // MOV AX,0x244b (0170_2C3C / 0x433C)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x2C42);
    // MOV DX,0x1ddc (0170_2C3F / 0x433F)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x2C43);
    // PUSH DX (0170_2C42 / 0x4342)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2C44);
    // PUSH AX (0170_2C43 / 0x4343)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2C49);
    // CALLF 0x1000:c7db (0170_2C44 / 0x4344)
    FarCall(cs2, 0x2C49, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs2, 0x2C4C);
    // JMP 0x0000:41f7 (0170_2C49 / 0x4349)
    goto label_0170_2AF7_041F7;
    label_0170_2C4C_0434C:
    CheckExternalEvents(cs2, 0x2C4E);
    // MOV SP,BP (0170_2C4C / 0x434C)
    SP = BP;
    CheckExternalEvents(cs2, 0x2C4F);
    // POP BP (0170_2C4E / 0x434E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x2C50);
    // RETF  (0170_2C4F / 0x434F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_4350_04350(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_4350_04350:
    CheckExternalEvents(cs1, 0x4351);
    // PUSH BP (0000_4350 / 0x4350)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x4353);
    // MOV BP,SP (0000_4351 / 0x4351)
    BP = SP;
    CheckExternalEvents(cs1, 0x4356);
    // MOV AX,0x6 (0000_4353 / 0x4353)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x435B);
    // CALLF 0x1000:cecc (0000_4356 / 0x4356)
    FarCall(cs1, 0x435B, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x435F);
    // MOV ES,word ptr [0x53e4] (0000_435B / 0x435B)
    ES = UInt16[DS, 0x53E4];
    CheckExternalEvents(cs1, 0x4366);
    // MOV word ptr ES:[0x12],0xd (0000_435F / 0x435F)
    UInt16[ES, 0x12] = 0xD;
    CheckExternalEvents(cs1, 0x436D);
    // MOV word ptr ES:[0x16],0x7 (0000_4366 / 0x4366)
    UInt16[ES, 0x16] = 0x7;
    CheckExternalEvents(cs1, 0x4371);
    // MOV ES,word ptr [0x53e6] (0000_436D / 0x436D)
    ES = UInt16[DS, 0x53E6];
    CheckExternalEvents(cs1, 0x4378);
    // MOV word ptr ES:[0xa6],0x7 (0000_4371 / 0x4371)
    UInt16[ES, 0xA6] = 0x7;
    CheckExternalEvents(cs1, 0x437A);
    // SUB AX,AX (0000_4378 / 0x4378)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x437D);
    // MOV word ptr [BP + -0x4],AX (0000_437A / 0x437A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x4380);
    // MOV word ptr [BP + -0x6],AX (0000_437D / 0x437D)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x4382);
    // JMP 0x0000:439e (0000_4380 / 0x4380)
    goto label_0000_439E_0439E;
    label_0000_4382_04382:
    CheckExternalEvents(cs1, 0x4385);
    // MOV AX,0x7d (0000_4382 / 0x4382)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x4388);
    // IMUL word ptr [BP + -0x6] (0000_4385 / 0x4385)
    int resImul0000_4385 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul0000_4385);
    DX = (ushort)(resImul0000_4385 >> 16);
    CheckExternalEvents(cs1, 0x438A);
    // MOV BX,AX (0000_4388 / 0x4388)
    BX = AX;
    CheckExternalEvents(cs1, 0x438E);
    // MOV ES,word ptr [0x538a] (0000_438A / 0x438A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x4394);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0000_438E / 0x438E)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x4396);
    // JZ 0x0000:439b (0000_4394 / 0x4394)
    if(ZeroFlag) {
      goto label_0000_439B_0439B;
    }
    CheckExternalEvents(cs1, 0x439B);
    // MOV word ptr [BP + -0x4],0x1 (0000_4396 / 0x4396)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_0000_439B_0439B:
    CheckExternalEvents(cs1, 0x439E);
    // INC word ptr [BP + -0x6] (0000_439B / 0x439B)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    label_0000_439E_0439E:
    CheckExternalEvents(cs1, 0x43A2);
    // CMP word ptr [BP + -0x6],0x4 (0000_439E / 0x439E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x4);
    CheckExternalEvents(cs1, 0x43A4);
    // JL 0x0000:4382 (0000_43A2 / 0x43A2)
    if(SignFlag != OverflowFlag) {
      goto label_0000_4382_04382;
    }
    CheckExternalEvents(cs1, 0x43A8);
    // CMP word ptr [BP + -0x4],0x0 (0000_43A4 / 0x43A4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x43AA);
    // JZ 0x0000:43c1 (0000_43A8 / 0x43A8)
    if(ZeroFlag) {
      goto label_0000_43C1_043C1;
    }
    CheckExternalEvents(cs1, 0x43AE);
    // MOV ES,word ptr [0x53e6] (0000_43AA / 0x43AA)
    ES = UInt16[DS, 0x53E6];
    CheckExternalEvents(cs1, 0x43B3);
    // INC word ptr ES:[0xa6] (0000_43AE / 0x43AE)
    UInt16[ES, 0xA6] = Alu16.Inc(UInt16[ES, 0xA6]);
    CheckExternalEvents(cs1, 0x43B7);
    // MOV ES,word ptr [0x53e4] (0000_43B3 / 0x43B3)
    ES = UInt16[DS, 0x53E4];
    CheckExternalEvents(cs1, 0x43BC);
    // DEC word ptr ES:[0x12] (0000_43B7 / 0x43B7)
    UInt16[ES, 0x12]--;
    CheckExternalEvents(cs1, 0x43C1);
    // INC word ptr ES:[0x16] (0000_43BC / 0x43BC)
    UInt16[ES, 0x16] = Alu16.Inc(UInt16[ES, 0x16]);
    label_0000_43C1_043C1:
    CheckExternalEvents(cs1, 0x43C4);
    // MOV AX,0x1 (0000_43C1 / 0x43C1)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x43C5);
    // PUSH AX (0000_43C4 / 0x43C4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x43CA);
    // CALLF 0x1000:7ee1 (0000_43C5 / 0x43C5)
    FarCall(cs1, 0x43CA, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x43CD);
    // ADD SP,0x2 (0000_43CA / 0x43CA)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x43D2);
    // CALLF 0x1000:7fe8 (0000_43CD / 0x43CD)
    FarCall(cs1, 0x43D2, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x43D5);
    // MOV AX,0x1 (0000_43D2 / 0x43D2)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x43D6);
    // PUSH AX (0000_43D5 / 0x43D5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x43DB);
    // CALLF 0x1000:7c64 (0000_43D6 / 0x43D6)
    FarCall(cs1, 0x43DB, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0x43DE);
    // ADD SP,0x2 (0000_43DB / 0x43DB)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x43E1);
    // MOV AX,0x51f (0000_43DE / 0x43DE)
    AX = 0x51F;
    CheckExternalEvents(cs1, 0x43E2);
    // PUSH DS (0000_43E1 / 0x43E1)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x43E3);
    // PUSH AX (0000_43E2 / 0x43E2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x43E8);
    // CALLF 0x1000:8055 (0000_43E3 / 0x43E3)
    FarCall(cs1, 0x43E8, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x43EB);
    // ADD SP,0x4 (0000_43E8 / 0x43E8)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x43EF);
    // CMP word ptr [BP + -0x4],0x0 (0000_43EB / 0x43EB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x43F1);
    // JZ 0x0000:43fe (0000_43EF / 0x43EF)
    if(ZeroFlag) {
      goto label_0000_43FE_043FE;
    }
    CheckExternalEvents(cs1, 0x43F4);
    // MOV AX,0x543 (0000_43F1 / 0x43F1)
    AX = 0x543;
    CheckExternalEvents(cs1, 0x43F5);
    // PUSH DS (0000_43F4 / 0x43F4)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x43F6);
    // PUSH AX (0000_43F5 / 0x43F5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x43FB);
    // CALLF 0x1000:8055 (0000_43F6 / 0x43F6)
    FarCall(cs1, 0x43FB, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x43FE);
    // ADD SP,0x4 (0000_43FB / 0x43FB)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_0000_43FE_043FE:
    CheckExternalEvents(cs1, 0x4401);
    // MOV AX,0x55b (0000_43FE / 0x43FE)
    AX = 0x55B;
    CheckExternalEvents(cs1, 0x4402);
    // PUSH DS (0000_4401 / 0x4401)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4403);
    // PUSH AX (0000_4402 / 0x4402)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4408);
    // CALLF 0x1000:8055 (0000_4403 / 0x4403)
    FarCall(cs1, 0x4408, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x440B);
    // ADD SP,0x4 (0000_4408 / 0x4408)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x440E);
    // MOV AX,0x592 (0000_440B / 0x440B)
    AX = 0x592;
    CheckExternalEvents(cs1, 0x440F);
    // PUSH DS (0000_440E / 0x440E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x4410);
    // PUSH AX (0000_440F / 0x440F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4415);
    // CALLF 0x1000:8055 (0000_4410 / 0x4410)
    FarCall(cs1, 0x4415, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x4418);
    // ADD SP,0x4 (0000_4415 / 0x4415)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x441B);
    // MOV AX,0x1 (0000_4418 / 0x4418)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x441C);
    // PUSH AX (0000_441B / 0x441B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x4421);
    // CALLF 0x1000:87be (0000_441C / 0x441C)
    FarCall(cs1, 0x4421, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x4424);
    // ADD SP,0x2 (0000_4421 / 0x4421)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x4427);
    // MOV word ptr [BP + -0x2],AX (0000_4424 / 0x4424)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x442B);
    // CMP word ptr [BP + -0x4],0x0 (0000_4427 / 0x4427)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x442D);
    // JNZ 0x0000:444d (0000_442B / 0x442B)
    if(!ZeroFlag) {
      goto label_0000_444D_0444D;
    }
    CheckExternalEvents(cs1, 0x4430);
    // CMP AX,0x1 (0000_442D / 0x442D)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0x4432);
    // JZ 0x0000:4460 (0000_4430 / 0x4430)
    if(ZeroFlag) {
      goto label_0000_4460_04460;
    }
    CheckExternalEvents(cs1, 0x4435);
    // CMP AX,0x2 (0000_4432 / 0x4432)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0x4437);
    // JZ 0x0000:446c (0000_4435 / 0x4435)
    if(ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_0000_446C_0446C, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x443A);
    // CMP AX,0x3 (0000_4437 / 0x4437)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs1, 0x443C);
    // JZ 0x0000:4472 (0000_443A / 0x443A)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_0000_446C_0446C, 0x4472 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x443F);
    // CMP AX,0x4 (0000_443C / 0x443C)
    Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs1, 0x4441);
    // JZ 0x0000:447f (0000_443F / 0x443F)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_0000_446C_0446C, 0x447F - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x4444);
    // CMP AX,0x5 (0000_4441 / 0x4441)
    Alu16.Sub(AX, 0x5);
    CheckExternalEvents(cs1, 0x4446);
    // JZ 0x0000:4485 (0000_4444 / 0x4444)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_0000_446C_0446C, 0x4485 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x4449);
    // CMP AX,0x6 (0000_4446 / 0x4446)
    Alu16.Sub(AX, 0x6);
    CheckExternalEvents(cs1, 0x444B);
    // JZ 0x0000:448b (0000_4449 / 0x4449)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_0000_446C_0446C, 0x448B - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x444D);
    // JMP 0x0000:449f (0000_444B / 0x444B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_444D_0444D:
    CheckExternalEvents(cs1, 0x4450);
    // MOV AX,word ptr [BP + -0x2] (0000_444D / 0x444D)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x4453);
    // SUB AX,0x1 (0000_4450 / 0x4450)
    AX -= 0x1;
    CheckExternalEvents(cs1, 0x4456);
    // CMP AX,0x6 (0000_4453 / 0x4453)
    Alu16.Sub(AX, 0x6);
    CheckExternalEvents(cs1, 0x4458);
    // JA 0x0000:449f (0000_4456 / 0x4456)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x445A);
    // ADD AX,AX (0000_4458 / 0x4458)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs1, 0x445B);
    // XCHG AX,BX (0000_445A / 0x445A)
    (BX, AX) = (AX, BX);
    label_0000_445B_0445B:
    CheckExternalEvents(cs1, 0x4460);
    // JMP word ptr CS:[BX + 0x2d91] (0000_445B / 0x445B)
    // Indirect jump to word ptr CS:[BX + 0x2d91], generating possible targets from emulator records
    uint targetAddress_0000_445B = (uint)(UInt16[cs1, (ushort)(BX + 0x2D91)]);
    switch(targetAddress_0000_445B) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_0000_445B));
        break;
    }
    label_0000_4460_04460:
    CheckExternalEvents(cs1, 0x4461);
    // PUSH CS (0000_4460 / 0x4460)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4464);
    // CALL 0x0000:52d0 (0000_4461 / 0x4461)
    NearCall(cs1, 0x4464, ghidra_guess_0000_52D0_052D0);
    CheckExternalEvents(cs1, 0x4466);
    // JMP 0x0000:449f (0000_4464 / 0x4464)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_446C_0446C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_446C_0446C:
    CheckExternalEvents(cs1, 0x446D);
    // PUSH CS (0000_446C / 0x446C)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4470);
    // CALL 0x0000:4e8d (0000_446D / 0x446D)
    NearCall(cs1, 0x4470, ghidra_guess_0000_4E8D_04E8D);
    CheckExternalEvents(cs1, 0x4472);
    // JMP 0x0000:449f (0000_4470 / 0x4470)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_4472_04472:
    CheckExternalEvents(cs1, 0x4474);
    // SUB AX,AX (0000_4472 / 0x4472)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x4475);
    // PUSH AX (0000_4474 / 0x4474)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x447A);
    // CALLF 0x0000:da1a (0000_4475 / 0x4475)
    FarCall(cs1, 0x447A, ghidra_guess_0000_DA1A_0DA1A);
    CheckExternalEvents(cs1, 0x447D);
    // ADD SP,0x2 (0000_447A / 0x447A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x447F);
    // JMP 0x0000:449f (0000_447D / 0x447D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_447F_0447F:
    CheckExternalEvents(cs1, 0x4480);
    // PUSH CS (0000_447F / 0x447F)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4483);
    // CALL 0x0000:49b3 (0000_4480 / 0x4480)
    NearCall(cs1, 0x4483, ghidra_guess_0000_49B3_049B3);
    CheckExternalEvents(cs1, 0x4485);
    // JMP 0x0000:449f (0000_4483 / 0x4483)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_4485_04485:
    CheckExternalEvents(cs1, 0x4486);
    // PUSH CS (0000_4485 / 0x4485)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x4489);
    // CALL 0x0000:4cd3 (0000_4486 / 0x4486)
    NearCall(cs1, 0x4489, ghidra_guess_0000_4CD3_04CD3);
    CheckExternalEvents(cs1, 0x448B);
    // JMP 0x0000:449f (0000_4489 / 0x4489)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_448B_0448B:
    CheckExternalEvents(cs1, 0x448C);
    // PUSH CS (0000_448B / 0x448B)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x448F);
    // CALL 0x0000:5440 (0000_448C / 0x448C)
    NearCall(cs1, 0x448F, ghidra_guess_0000_5440_05440);
    CheckExternalEvents(cs1, 0x4491);
    // JMP 0x0000:449f (0000_448F / 0x448F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_449F_0449F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_449F_0449F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_449F_0449F:
    CheckExternalEvents(cs1, 0x44A4);
    // CALLF 0x1000:9193 (0000_449F / 0x449F)
    FarCall(cs1, 0x44A4, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0x44A6);
    // MOV SP,BP (0000_44A4 / 0x44A4)
    SP = BP;
    CheckExternalEvents(cs1, 0x44A7);
    // POP BP (0000_44A6 / 0x44A6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x44A8);
    // RETF  (0000_44A7 / 0x44A7)
    return FarRet();
  }
  
  public virtual Action unknown_0170_2DA8_044A8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_2DA8_044A8:
    CheckExternalEvents(cs2, 0x2DA9);
    // PUSH BP (0170_2DA8 / 0x44A8)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x2DAB);
    // MOV BP,SP (0170_2DA9 / 0x44A9)
    BP = SP;
    CheckExternalEvents(cs2, 0x2DAE);
    // MOV AX,0x16 (0170_2DAB / 0x44AB)
    AX = 0x16;
    CheckExternalEvents(cs2, 0x2DB3);
    // CALLF 0x1000:cecc (0170_2DAE / 0x44AE)
    FarCall(cs2, 0x2DB3, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x2DB4);
    // PUSH DI (0170_2DB3 / 0x44B3)
    Stack.Push16(DI);
    CheckExternalEvents(cs2, 0x2DB5);
    // PUSH SI (0170_2DB4 / 0x44B4)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x2DBB);
    // MOV word ptr [0x150],0x55 (0170_2DB5 / 0x44B5)
    UInt16[DS, 0x150] = 0x55;
    CheckExternalEvents(cs2, 0x2DBF);
    // MOV ES,word ptr [0x538a] (0170_2DBB / 0x44BB)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x2DC5);
    // MOV byte ptr ES:[0xd346],0x0 (0170_2DBF / 0x44BF)
    UInt8[ES, 0xD346] = 0x0;
    CheckExternalEvents(cs2, 0x2DC9);
    // CMP word ptr [BP + 0x8],0xe (0170_2DC5 / 0x44C5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xE);
    CheckExternalEvents(cs2, 0x2DCB);
    // JNZ 0x0000:44d7 (0170_2DC9 / 0x44C9)
    if(!ZeroFlag) {
      goto label_0170_2DD7_044D7;
    }
    CheckExternalEvents(cs2, 0x2DD1);
    // MOV word ptr [0x150],0x21 (0170_2DCB / 0x44CB)
    UInt16[DS, 0x150] = 0x21;
    CheckExternalEvents(cs2, 0x2DD7);
    // MOV byte ptr ES:[0xd346],0x1 (0170_2DD1 / 0x44D1)
    UInt8[ES, 0xD346] = 0x1;
    label_0170_2DD7_044D7:
    CheckExternalEvents(cs2, 0x2DDA);
    // MOV AX,0x5a5 (0170_2DD7 / 0x44D7)
    AX = 0x5A5;
    CheckExternalEvents(cs2, 0x2DDB);
    // PUSH DS (0170_2DDA / 0x44DA)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x2DDC);
    // PUSH AX (0170_2DDB / 0x44DB)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2DDF);
    // MOV AX,0x12 (0170_2DDC / 0x44DC)
    AX = 0x12;
    CheckExternalEvents(cs2, 0x2DE2);
    // MOV DX,0x2a02 (0170_2DDF / 0x44DF)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2DE3);
    // PUSH DX (0170_2DE2 / 0x44E2)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2DE4);
    // PUSH AX (0170_2DE3 / 0x44E3)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2DE9);
    // CALLF 0x1000:da58 (0170_2DE4 / 0x44E4)
    FarCall(cs2, 0x2DE9, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs2, 0x2DEC);
    // ADD SP,0x8 (0170_2DE9 / 0x44E9)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2DEF);
    // MOV AX,0xa (0170_2DEC / 0x44EC)
    AX = 0xA;
    CheckExternalEvents(cs2, 0x2DF0);
    // PUSH AX (0170_2DEF / 0x44EF)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2DF3);
    // MOV AX,0x15 (0170_2DF0 / 0x44F0)
    AX = 0x15;
    CheckExternalEvents(cs2, 0x2DF6);
    // MOV DX,0x2a02 (0170_2DF3 / 0x44F3)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2DF7);
    // PUSH DX (0170_2DF6 / 0x44F6)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2DF8);
    // PUSH AX (0170_2DF7 / 0x44F7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2DFB);
    // PUSH word ptr [BP + 0x8] (0170_2DF8 / 0x44F8)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x2E00);
    // CALLF 0x1000:daa6 (0170_2DFB / 0x44FB)
    FarCall(cs2, 0x2E00, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs2, 0x2E03);
    // ADD SP,0x8 (0170_2E00 / 0x4500)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2E06);
    // MOV AX,0x5a9 (0170_2E03 / 0x4503)
    AX = 0x5A9;
    CheckExternalEvents(cs2, 0x2E07);
    // PUSH DS (0170_2E06 / 0x4506)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x2E08);
    // PUSH AX (0170_2E07 / 0x4507)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E0B);
    // MOV AX,0x12 (0170_2E08 / 0x4508)
    AX = 0x12;
    CheckExternalEvents(cs2, 0x2E0E);
    // MOV DX,0x2a02 (0170_2E0B / 0x450B)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2E0F);
    // PUSH DX (0170_2E0E / 0x450E)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2E10);
    // PUSH AX (0170_2E0F / 0x450F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E15);
    // CALLF 0x1000:da12 (0170_2E10 / 0x4510)
    FarCall(cs2, 0x2E15, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs2, 0x2E18);
    // ADD SP,0x8 (0170_2E15 / 0x4515)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2E1B);
    // MOV AX,0x2 (0170_2E18 / 0x4518)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x2E1C);
    // PUSH AX (0170_2E1B / 0x451B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E1D);
    // PUSH CS (0170_2E1C / 0x451C)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2E20);
    // CALL 0x0000:3fcc (0170_2E1D / 0x451D)
    NearCall(cs2, 0x2E20, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x2E23);
    // ADD SP,0x2 (0170_2E20 / 0x4520)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x2E27);
    // CMP word ptr [BP + 0x8],0xb (0170_2E23 / 0x4523)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xB);
    CheckExternalEvents(cs2, 0x2E29);
    // JNZ 0x0000:45a8 (0170_2E27 / 0x4527)
    if(!ZeroFlag) {
      goto label_0170_2EA8_045A8;
    }
    CheckExternalEvents(cs2, 0x2E2D);
    // MOV ES,word ptr [0x53d2] (0170_2E29 / 0x4529)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x2E33);
    // CMP word ptr ES:[0x3988],0x1 (0170_2E2D / 0x452D)
    Alu16.Sub(UInt16[ES, 0x3988], 0x1);
    CheckExternalEvents(cs2, 0x2E35);
    // JZ 0x0000:45a8 (0170_2E33 / 0x4533)
    if(ZeroFlag) {
      goto label_0170_2EA8_045A8;
    }
    CheckExternalEvents(cs2, 0x2E38);
    // MOV AX,0x150 (0170_2E35 / 0x4535)
    AX = 0x150;
    CheckExternalEvents(cs2, 0x2E3B);
    // MOV DX,0x2958 (0170_2E38 / 0x4538)
    DX = 0x2958;
    CheckExternalEvents(cs2, 0x2E3C);
    // PUSH DX (0170_2E3B / 0x453B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2E3D);
    // PUSH AX (0170_2E3C / 0x453C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E42);
    // CALLF 0x1000:9fc1 (0170_2E3D / 0x453D)
    FarCall(cs2, 0x2E42, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs2, 0x2E45);
    // ADD SP,0x4 (0170_2E42 / 0x4542)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs2, 0x2E49);
    // MOV ES,word ptr [0x53e8] (0170_2E45 / 0x4545)
    ES = UInt16[DS, 0x53E8];
    CheckExternalEvents(cs2, 0x2E50);
    // MOV word ptr ES:[0x4fbc],0x1 (0170_2E49 / 0x4549)
    UInt16[ES, 0x4FBC] = 0x1;
    CheckExternalEvents(cs2, 0x2E53);
    // MOV AX,0x244b (0170_2E50 / 0x4550)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x2E56);
    // MOV DX,0x1ddc (0170_2E53 / 0x4553)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x2E57);
    // PUSH DX (0170_2E56 / 0x4556)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2E58);
    // PUSH AX (0170_2E57 / 0x4557)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E5B);
    // MOV AX,0x5ae (0170_2E58 / 0x4558)
    AX = 0x5AE;
    CheckExternalEvents(cs2, 0x2E5C);
    // PUSH DS (0170_2E5B / 0x455B)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x2E5D);
    // PUSH AX (0170_2E5C / 0x455C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E62);
    // CALLF 0x1000:910b (0170_2E5D / 0x455D)
    FarCall(cs2, 0x2E62, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs2, 0x2E65);
    // ADD SP,0x8 (0170_2E62 / 0x4562)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2E68);
    // MOV AX,0x4614 (0170_2E65 / 0x4565)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x2E6B);
    // MOV DX,0x2a02 (0170_2E68 / 0x4568)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2E6C);
    // PUSH DX (0170_2E6B / 0x456B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2E6D);
    // PUSH AX (0170_2E6C / 0x456C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E70);
    // MOV AX,0x244b (0170_2E6D / 0x456D)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x2E73);
    // MOV DX,0x1ddc (0170_2E70 / 0x4570)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x2E74);
    // PUSH DX (0170_2E73 / 0x4573)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2E75);
    // PUSH AX (0170_2E74 / 0x4574)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E7A);
    // CALLF 0x1000:8f6d (0170_2E75 / 0x4575)
    FarCall(cs2, 0x2E7A, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs2, 0x2E7D);
    // ADD SP,0x8 (0170_2E7A / 0x457A)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2E81);
    // MOV ES,word ptr [0x53a0] (0170_2E7D / 0x457D)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x2E87);
    // CMP word ptr ES:[0x4fba],0x2 (0170_2E81 / 0x4581)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x2E89);
    // JNZ 0x0000:459d (0170_2E87 / 0x4587)
    if(!ZeroFlag) {
      goto label_0170_2E9D_0459D;
    }
    CheckExternalEvents(cs2, 0x2E8C);
    // MOV AX,0xa400 (0170_2E89 / 0x4589)
    AX = 0xA400;
    CheckExternalEvents(cs2, 0x2E8D);
    // PUSH AX (0170_2E8C / 0x458C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E90);
    // MOV AX,0x4614 (0170_2E8D / 0x458D)
    AX = 0x4614;
    CheckExternalEvents(cs2, 0x2E93);
    // MOV DX,0x2a02 (0170_2E90 / 0x4590)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2E94);
    // PUSH DX (0170_2E93 / 0x4593)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2E95);
    // PUSH AX (0170_2E94 / 0x4594)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2E9A);
    // CALLF 0x1000:a150 (0170_2E95 / 0x4595)
    FarCall(cs2, 0x2E9A, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs2, 0x2E9D);
    // ADD SP,0x6 (0170_2E9A / 0x459A)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_0170_2E9D_0459D:
    CheckExternalEvents(cs2, 0x2EA1);
    // MOV ES,word ptr [0x53d2] (0170_2E9D / 0x459D)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x2EA8);
    // MOV word ptr ES:[0x3988],0x1 (0170_2EA1 / 0x45A1)
    UInt16[ES, 0x3988] = 0x1;
    label_0170_2EA8_045A8:
    CheckExternalEvents(cs2, 0x2EAC);
    // CMP word ptr [BP + 0x8],0xb (0170_2EA8 / 0x45A8)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xB);
    CheckExternalEvents(cs2, 0x2EAE);
    // JZ 0x0000:45be (0170_2EAC / 0x45AC)
    if(ZeroFlag) {
      goto label_0170_2EBE_045BE;
    }
    CheckExternalEvents(cs2, 0x2EB2);
    // MOV ES,word ptr [0x53d2] (0170_2EAE / 0x45AE)
    ES = UInt16[DS, 0x53D2];
    CheckExternalEvents(cs2, 0x2EB8);
    // CMP word ptr ES:[0x3988],0x0 (0170_2EB2 / 0x45B2)
    Alu16.Sub(UInt16[ES, 0x3988], 0x0);
    CheckExternalEvents(cs2, 0x2EBA);
    // JZ 0x0000:45be (0170_2EB8 / 0x45B8)
    if(ZeroFlag) {
      goto label_0170_2EBE_045BE;
    }
    CheckExternalEvents(cs2, 0x2EBB);
    // PUSH CS (0170_2EBA / 0x45BA)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2EBE);
    // CALL 0x0000:5d21 (0170_2EBB / 0x45BB)
    NearCall(cs2, 0x2EBE, unknown_0170_4621_05D21);
    label_0170_2EBE_045BE:
    CheckExternalEvents(cs2, 0x2EC1);
    // MOV AX,0x1 (0170_2EBE / 0x45BE)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2EC2);
    // PUSH AX (0170_2EC1 / 0x45C1)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2EC3);
    // PUSH CS (0170_2EC2 / 0x45C2)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2EC6);
    // CALL 0x0000:3fcc (0170_2EC3 / 0x45C3)
    NearCall(cs2, 0x2EC6, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x2EC9);
    // ADD SP,0x2 (0170_2EC6 / 0x45C6)
    SP += 0x2;
    CheckExternalEvents(cs2, 0x2ECD);
    // CMP word ptr [BP + 0x8],0x1 (0170_2EC9 / 0x45C9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x1);
    CheckExternalEvents(cs2, 0x2ECF);
    // JZ 0x0000:45db (0170_2ECD / 0x45CD)
    if(ZeroFlag) {
      goto label_0170_2EDB_045DB;
    }
    CheckExternalEvents(cs2, 0x2ED3);
    // CMP word ptr [BP + 0x8],0xb (0170_2ECF / 0x45CF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xB);
    CheckExternalEvents(cs2, 0x2ED5);
    // JZ 0x0000:45db (0170_2ED3 / 0x45D3)
    if(ZeroFlag) {
      goto label_0170_2EDB_045DB;
    }
    CheckExternalEvents(cs2, 0x2ED9);
    // CMP word ptr [BP + 0x8],0xe (0170_2ED5 / 0x45D5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xE);
    CheckExternalEvents(cs2, 0x2EDB);
    // JL 0x0000:45f0 (0170_2ED9 / 0x45D9)
    if(SignFlag != OverflowFlag) {
      goto label_0170_2EF0_045F0;
    }
    label_0170_2EDB_045DB:
    CheckExternalEvents(cs2, 0x2EDE);
    // MOV AX,0x2 (0170_2EDB / 0x45DB)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x2EDF);
    // PUSH AX (0170_2EDE / 0x45DE)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2EE0);
    // PUSH CS (0170_2EDF / 0x45DF)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2EE3);
    // CALL 0x0000:3fcc (0170_2EE0 / 0x45E0)
    NearCall(cs2, 0x2EE3, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs2, 0x2EE5);
    // JMP 0x0000:45ed (0170_2EE3 / 0x45E3)
    goto label_0170_2EED_045ED;
    label_0170_2EE5_045E5:
    CheckExternalEvents(cs2, 0x2EE9);
    // PUSH word ptr [0x14e] (0170_2EE5 / 0x45E5)
    Stack.Push16(UInt16[DS, 0x14E]);
    CheckExternalEvents(cs2, 0x2EEA);
    // PUSH CS (0170_2EE9 / 0x45E9)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x2EED);
    // CALL 0x0000:4013 (0170_2EEA / 0x45EA)
    NearCall(cs2, 0x2EED, ghidra_guess_0000_4013_04013);
    label_0170_2EED_045ED:
    CheckExternalEvents(cs2, 0x2EF0);
    // ADD SP,0x2 (0170_2EED / 0x45ED)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0170_2EF0_045F0:
    CheckExternalEvents(cs2, 0x2EF3);
    // MOV AX,0x8000 (0170_2EF0 / 0x45F0)
    AX = 0x8000;
    CheckExternalEvents(cs2, 0x2EF4);
    // PUSH AX (0170_2EF3 / 0x45F3)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2EF7);
    // MOV AX,0x12 (0170_2EF4 / 0x45F4)
    AX = 0x12;
    CheckExternalEvents(cs2, 0x2EFA);
    // MOV DX,0x2a02 (0170_2EF7 / 0x45F7)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2EFB);
    // PUSH DX (0170_2EFA / 0x45FA)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2EFC);
    // PUSH AX (0170_2EFB / 0x45FB)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F01);
    // CALLF 0x1000:d2c0 (0170_2EFC / 0x45FC)
    FarCall(cs2, 0x2F01, unknown_19EF_33D0_1D2C0);
    CheckExternalEvents(cs2, 0x2F04);
    // ADD SP,0x6 (0170_2F01 / 0x4601)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs2, 0x2F07);
    // MOV word ptr [BP + -0xe],AX (0170_2F04 / 0x4604)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs2, 0x2F08);
    // INC AX (0170_2F07 / 0x4607)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs2, 0x2F0A);
    // JZ 0x0000:45e5 (0170_2F08 / 0x4608)
    if(ZeroFlag) {
      goto label_0170_2EE5_045E5;
    }
    CheckExternalEvents(cs2, 0x2F0D);
    // MOV AX,0x1 (0170_2F0A / 0x460A)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2F0E);
    // PUSH AX (0170_2F0D / 0x460D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F11);
    // LEA AX,[BP + -0x4] (0170_2F0E / 0x460E)
    AX = (ushort)(BP - 0x4);
    CheckExternalEvents(cs2, 0x2F12);
    // PUSH SS (0170_2F11 / 0x4611)
    Stack.Push16(SS);
    CheckExternalEvents(cs2, 0x2F13);
    // PUSH AX (0170_2F12 / 0x4612)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F16);
    // PUSH word ptr [BP + -0xe] (0170_2F13 / 0x4613)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F1B);
    // CALLF 0x1000:d470 (0170_2F16 / 0x4616)
    FarCall(cs2, 0x2F1B, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F1E);
    // ADD SP,0x8 (0170_2F1B / 0x461B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F21);
    // MOV AX,0x1 (0170_2F1E / 0x461E)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2F22);
    // PUSH AX (0170_2F21 / 0x4621)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F25);
    // LEA AX,[BP + -0x8] (0170_2F22 / 0x4622)
    AX = (ushort)(BP - 0x8);
    CheckExternalEvents(cs2, 0x2F26);
    // PUSH SS (0170_2F25 / 0x4625)
    Stack.Push16(SS);
    CheckExternalEvents(cs2, 0x2F27);
    // PUSH AX (0170_2F26 / 0x4626)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F2A);
    // PUSH word ptr [BP + -0xe] (0170_2F27 / 0x4627)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F2F);
    // CALLF 0x1000:d470 (0170_2F2A / 0x462A)
    FarCall(cs2, 0x2F2F, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F32);
    // ADD SP,0x8 (0170_2F2F / 0x462F)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F35);
    // MOV AX,0x1 (0170_2F32 / 0x4632)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2F36);
    // PUSH AX (0170_2F35 / 0x4635)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F39);
    // LEA AX,[BP + -0xc] (0170_2F36 / 0x4636)
    AX = (ushort)(BP - 0xC);
    CheckExternalEvents(cs2, 0x2F3A);
    // PUSH SS (0170_2F39 / 0x4639)
    Stack.Push16(SS);
    CheckExternalEvents(cs2, 0x2F3B);
    // PUSH AX (0170_2F3A / 0x463A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F3E);
    // PUSH word ptr [BP + -0xe] (0170_2F3B / 0x463B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F43);
    // CALLF 0x1000:d470 (0170_2F3E / 0x463E)
    FarCall(cs2, 0x2F43, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F46);
    // ADD SP,0x8 (0170_2F43 / 0x4643)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F49);
    // MOV AX,0x1 (0170_2F46 / 0x4646)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2F4A);
    // PUSH AX (0170_2F49 / 0x4649)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F4D);
    // LEA AX,[BP + -0x2] (0170_2F4A / 0x464A)
    AX = (ushort)(BP - 0x2);
    CheckExternalEvents(cs2, 0x2F4E);
    // PUSH SS (0170_2F4D / 0x464D)
    Stack.Push16(SS);
    CheckExternalEvents(cs2, 0x2F4F);
    // PUSH AX (0170_2F4E / 0x464E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F52);
    // PUSH word ptr [BP + -0xe] (0170_2F4F / 0x464F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F57);
    // CALLF 0x1000:d470 (0170_2F52 / 0x4652)
    FarCall(cs2, 0x2F57, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F5A);
    // ADD SP,0x8 (0170_2F57 / 0x4657)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F5D);
    // MOV AX,0x1 (0170_2F5A / 0x465A)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x2F5E);
    // PUSH AX (0170_2F5D / 0x465D)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F61);
    // LEA AX,[BP + -0xa] (0170_2F5E / 0x465E)
    AX = (ushort)(BP - 0xA);
    CheckExternalEvents(cs2, 0x2F62);
    // PUSH SS (0170_2F61 / 0x4661)
    Stack.Push16(SS);
    CheckExternalEvents(cs2, 0x2F63);
    // PUSH AX (0170_2F62 / 0x4662)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F66);
    // PUSH word ptr [BP + -0xe] (0170_2F63 / 0x4663)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F6B);
    // CALLF 0x1000:d470 (0170_2F66 / 0x4666)
    FarCall(cs2, 0x2F6B, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F6E);
    // ADD SP,0x8 (0170_2F6B / 0x466B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F71);
    // MOV AX,0x80 (0170_2F6E / 0x466E)
    AX = 0x80;
    CheckExternalEvents(cs2, 0x2F72);
    // PUSH AX (0170_2F71 / 0x4671)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F75);
    // MOV AX,0xa461 (0170_2F72 / 0x4672)
    AX = 0xA461;
    CheckExternalEvents(cs2, 0x2F78);
    // MOV DX,0x1ddc (0170_2F75 / 0x4675)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x2F79);
    // PUSH DX (0170_2F78 / 0x4678)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2F7A);
    // PUSH AX (0170_2F79 / 0x4679)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F7D);
    // PUSH word ptr [BP + -0xe] (0170_2F7A / 0x467A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F82);
    // CALLF 0x1000:d470 (0170_2F7D / 0x467D)
    FarCall(cs2, 0x2F82, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F85);
    // ADD SP,0x8 (0170_2F82 / 0x4682)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F88);
    // MOV AX,0x100 (0170_2F85 / 0x4685)
    AX = 0x100;
    CheckExternalEvents(cs2, 0x2F89);
    // PUSH AX (0170_2F88 / 0x4688)
    Stack.Push16(AX);
    label_0170_2F89_04689:
    CheckExternalEvents(cs2, 0x2F8C);
    // MOV AX,0xa561 (0170_2F89 / 0x4689)
    AX = 0xA561;
    CheckExternalEvents(cs2, 0x2F8F);
    // MOV DX,0x1ddc (0170_2F8C / 0x468C)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x2F90);
    // PUSH DX (0170_2F8F / 0x468F)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2F91);
    // PUSH AX (0170_2F90 / 0x4690)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2F94);
    // PUSH word ptr [BP + -0xe] (0170_2F91 / 0x4691)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2F99);
    // CALLF 0x1000:d470 (0170_2F94 / 0x4694)
    FarCall(cs2, 0x2F99, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2F9C);
    // ADD SP,0x8 (0170_2F99 / 0x4699)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2F9F);
    // MOV AX,0x20 (0170_2F9C / 0x469C)
    AX = 0x20;
    CheckExternalEvents(cs2, 0x2FA0);
    // PUSH AX (0170_2F9F / 0x469F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FA3);
    // MOV AX,0x4564 (0170_2FA0 / 0x46A0)
    AX = 0x4564;
    CheckExternalEvents(cs2, 0x2FA6);
    // MOV DX,0x2a02 (0170_2FA3 / 0x46A3)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2FA7);
    // PUSH DX (0170_2FA6 / 0x46A6)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2FA8);
    // PUSH AX (0170_2FA7 / 0x46A7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FAB);
    // PUSH word ptr [BP + -0xe] (0170_2FA8 / 0x46A8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2FB0);
    // CALLF 0x1000:d470 (0170_2FAB / 0x46AB)
    FarCall(cs2, 0x2FB0, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2FB3);
    // ADD SP,0x8 (0170_2FB0 / 0x46B0)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2FB6);
    // MOV AX,0x20 (0170_2FB3 / 0x46B3)
    AX = 0x20;
    CheckExternalEvents(cs2, 0x2FB7);
    // PUSH AX (0170_2FB6 / 0x46B6)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FBA);
    // MOV AX,0x4596 (0170_2FB7 / 0x46B7)
    AX = 0x4596;
    CheckExternalEvents(cs2, 0x2FBD);
    // MOV DX,0x2a02 (0170_2FBA / 0x46BA)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2FBE);
    // PUSH DX (0170_2FBD / 0x46BD)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2FBF);
    // PUSH AX (0170_2FBE / 0x46BE)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FC2);
    // PUSH word ptr [BP + -0xe] (0170_2FBF / 0x46BF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2FC7);
    // CALLF 0x1000:d470 (0170_2FC2 / 0x46C2)
    FarCall(cs2, 0x2FC7, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2FCA);
    // ADD SP,0x8 (0170_2FC7 / 0x46C7)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2FCD);
    // MOV AX,0x20 (0170_2FCA / 0x46CA)
    AX = 0x20;
    CheckExternalEvents(cs2, 0x2FCE);
    // PUSH AX (0170_2FCD / 0x46CD)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FD1);
    // MOV AX,0x39b4 (0170_2FCE / 0x46CE)
    AX = 0x39B4;
    CheckExternalEvents(cs2, 0x2FD4);
    // MOV DX,0x2a02 (0170_2FD1 / 0x46D1)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2FD5);
    // PUSH DX (0170_2FD4 / 0x46D4)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2FD6);
    // PUSH AX (0170_2FD5 / 0x46D5)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FD9);
    // PUSH word ptr [BP + -0xe] (0170_2FD6 / 0x46D6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2FDE);
    // CALLF 0x1000:d470 (0170_2FD9 / 0x46D9)
    FarCall(cs2, 0x2FDE, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2FE1);
    // ADD SP,0x8 (0170_2FDE / 0x46DE)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2FE4);
    // MOV AX,0x20 (0170_2FE1 / 0x46E1)
    AX = 0x20;
    CheckExternalEvents(cs2, 0x2FE5);
    // PUSH AX (0170_2FE4 / 0x46E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FE8);
    // MOV AX,0x39d4 (0170_2FE5 / 0x46E5)
    AX = 0x39D4;
    CheckExternalEvents(cs2, 0x2FEB);
    // MOV DX,0x2a02 (0170_2FE8 / 0x46E8)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x2FEC);
    // PUSH DX (0170_2FEB / 0x46EB)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x2FED);
    // PUSH AX (0170_2FEC / 0x46EC)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FF0);
    // PUSH word ptr [BP + -0xe] (0170_2FED / 0x46ED)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x2FF5);
    // CALLF 0x1000:d470 (0170_2FF0 / 0x46F0)
    FarCall(cs2, 0x2FF5, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x2FF8);
    // ADD SP,0x8 (0170_2FF5 / 0x46F5)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x2FFB);
    // MOV AX,0x10 (0170_2FF8 / 0x46F8)
    AX = 0x10;
    CheckExternalEvents(cs2, 0x2FFC);
    // PUSH AX (0170_2FFB / 0x46FB)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2FFF);
    // MOV AX,0x4602 (0170_2FFC / 0x46FC)
    AX = 0x4602;
    CheckExternalEvents(cs2, 0x3002);
    // MOV DX,0x2a02 (0170_2FFF / 0x46FF)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x3003);
    // PUSH DX (0170_3002 / 0x4702)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x3004);
    // PUSH AX (0170_3003 / 0x4703)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3007);
    // PUSH word ptr [BP + -0xe] (0170_3004 / 0x4704)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x300C);
    // CALLF 0x1000:d470 (0170_3007 / 0x4707)
    FarCall(cs2, 0x300C, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x300F);
    // ADD SP,0x8 (0170_300C / 0x470C)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x3012);
    // MOV AX,0x8 (0170_300F / 0x470F)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x3013);
    // PUSH AX (0170_3012 / 0x4712)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3016);
    // MOV AX,0x3768 (0170_3013 / 0x4713)
    AX = 0x3768;
    CheckExternalEvents(cs2, 0x3019);
    // MOV DX,0x2a02 (0170_3016 / 0x4716)
    DX = 0x2A02;
    CheckExternalEvents(cs2, 0x301A);
    // PUSH DX (0170_3019 / 0x4719)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x301B);
    // PUSH AX (0170_301A / 0x471A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x301E);
    // PUSH word ptr [BP + -0xe] (0170_301B / 0x471B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x3023);
    // CALLF 0x1000:d470 (0170_301E / 0x471E)
    FarCall(cs2, 0x3023, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x3026);
    // ADD SP,0x8 (0170_3023 / 0x4723)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x3028);
    // MOV CL,0x3 (0170_3026 / 0x4726)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x302B);
    // SHR byte ptr [BP + -0x2],CL (0170_3028 / 0x4728)
    UInt8[SS, (ushort)(BP - 0x2)] >>= CL;
    CheckExternalEvents(cs2, 0x302E);
    // SHR byte ptr [BP + -0xa],CL (0170_302B / 0x472B)
    // UInt8[SS, (ushort)(BP - 0xA)] >>= CL;
    UInt8[SS, (ushort)(BP - 0xA)] = Alu8.Shr(UInt8[SS, (ushort)(BP - 0xA)], CL);
    CheckExternalEvents(cs2, 0x3031);
    // MOV AX,0x1000 (0170_302E / 0x472E)
    AX = 0x1000;
    CheckExternalEvents(cs2, 0x3032);
    // PUSH AX (0170_3031 / 0x4731)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x3035);
    // MOV AX,0x101d (0170_3032 / 0x4732)
    AX = 0x101D;
    CheckExternalEvents(cs2, 0x3038);
    // MOV DX,0x1ddc (0170_3035 / 0x4735)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x3039);
    // PUSH DX (0170_3038 / 0x4738)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x303A);
    // PUSH AX (0170_3039 / 0x4739)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x303D);
    // PUSH word ptr [BP + -0xe] (0170_303A / 0x473A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x3042);
    // CALLF 0x1000:d470 (0170_303D / 0x473D)
    FarCall(cs2, 0x3042, unknown_19EF_3580_1D470);
    CheckExternalEvents(cs2, 0x3045);
    // ADD SP,0x8 (0170_3042 / 0x4742)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs2, 0x3048);
    // PUSH word ptr [BP + -0xe] (0170_3045 / 0x4745)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs2, 0x304D);
    // CALLF 0x1000:d226 (0170_3048 / 0x4748)
    FarCall(cs2, 0x304D, unknown_19EF_3336_1D226);
    CheckExternalEvents(cs2, 0x3050);
    // ADD SP,0x2 (0170_304D / 0x474D)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs2, 0x3053);
    // MOV BX,word ptr [BP + 0x6] (0170_3050 / 0x4750)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x3055);
    // SHL BX,0x1 (0170_3053 / 0x4753)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x3057);
    // SHL BX,0x1 (0170_3055 / 0x4755)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs2, 0x305B);
    // MOV AX,word ptr [BX + 0x170] (0170_3057 / 0x4757)
    AX = UInt16[DS, (ushort)(BX + 0x170)];
    CheckExternalEvents(cs2, 0x305F);
    // MOV DX,word ptr [BX + 0x172] (0170_305B / 0x475B)
    DX = UInt16[DS, (ushort)(BX + 0x172)];
    CheckExternalEvents(cs2, 0x3062);
    // MOV word ptr [BP + -0x12],AX (0170_305F / 0x475F)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs2, 0x3065);
    // MOV word ptr [BP + -0x10],DX (0170_3062 / 0x4762)
    UInt16[SS, (ushort)(BP - 0x10)] = DX;
    CheckExternalEvents(cs2, 0x3068);
    // MOV AL,byte ptr [BP + -0xc] (0170_3065 / 0x4765)
    AL = UInt8[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x306A);
    // SUB AH,AH (0170_3068 / 0x4768)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x306C);
    // MOV CL,0x3 (0170_306A / 0x476A)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x306E);
    // SHL AX,CL (0170_306C / 0x476C)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs2, 0x3071);
    // MOV CL,byte ptr [BP + -0x8] (0170_306E / 0x476E)
    CL = UInt8[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x3073);
    // SUB CH,CH (0170_3071 / 0x4771)
    CH -= CH;
    CheckExternalEvents(cs2, 0x3075);
    // ADD AX,CX (0170_3073 / 0x4773)
    AX += CX;
    CheckExternalEvents(cs2, 0x3078);
    // ADD word ptr [BP + -0x12],AX (0170_3075 / 0x4775)
    // UInt16[SS, (ushort)(BP - 0x12)] += AX;
    UInt16[SS, (ushort)(BP - 0x12)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x12)], AX);
    CheckExternalEvents(cs2, 0x307C);
    // MOV byte ptr [BP + -0x6],0x90 (0170_3078 / 0x4778)
    UInt8[SS, (ushort)(BP - 0x6)] = 0x90;
    CheckExternalEvents(cs2, 0x307F);
    // MOV byte ptr [BP + -0xc],CH (0170_307C / 0x477C)
    UInt8[SS, (ushort)(BP - 0xC)] = CH;
    CheckExternalEvents(cs2, 0x3081);
    // JMP 0x0000:47ad (0170_307F / 0x477F)
    goto label_0170_30AD_047AD;
    label_0170_3081_04781:
    CheckExternalEvents(cs2, 0x3084);
    // INC byte ptr [BP + -0x8] (0170_3081 / 0x4781)
    UInt8[SS, (ushort)(BP - 0x8)] = Alu8.Inc(UInt8[SS, (ushort)(BP - 0x8)]);
    label_0170_3084_04784:
    CheckExternalEvents(cs2, 0x3087);
    // MOV AL,byte ptr [BP + -0x2] (0170_3084 / 0x4784)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x308A);
    // CMP byte ptr [BP + -0x8],AL (0170_3087 / 0x4787)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x8)], AL);
    CheckExternalEvents(cs2, 0x308C);
    // JNC 0x0000:47aa (0170_308A / 0x478A)
    if(!CarryFlag) {
      goto label_0170_30AA_047AA;
    }
    CheckExternalEvents(cs2, 0x308F);
    // MOV BL,byte ptr [BP + -0xc] (0170_308C / 0x478C)
    BL = UInt8[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x3091);
    // SUB BH,BH (0170_308F / 0x478F)
    // BH -= BH;
    BH = Alu8.Sub(BH, BH);
    CheckExternalEvents(cs2, 0x3093);
    // MOV CL,0x3 (0170_3091 / 0x4791)
    CL = 0x3;
    CheckExternalEvents(cs2, 0x3095);
    // SHL BX,CL (0170_3093 / 0x4793)
    // BX <<= CL;
    BX = Alu16.Shl(BX, CL);
    CheckExternalEvents(cs2, 0x3098);
    // MOV AL,byte ptr [BP + -0x8] (0170_3095 / 0x4795)
    AL = UInt8[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x309A);
    // SUB AH,AH (0170_3098 / 0x4798)
    AH -= AH;
    CheckExternalEvents(cs2, 0x309C);
    // ADD BX,AX (0170_309A / 0x479A)
    // BX += AX;
    BX = Alu16.Add(BX, AX);
    CheckExternalEvents(cs2, 0x309F);
    // LES SI,[BP + -0x12] (0170_309C / 0x479C)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    ES = UInt16[SS, (ushort)(BP - 0x12 + 2)];
    CheckExternalEvents(cs2, 0x30A2);
    // MOV AL,byte ptr [BP + -0x6] (0170_309F / 0x479F)
    AL = UInt8[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs2, 0x30A5);
    // INC byte ptr [BP + -0x6] (0170_30A2 / 0x47A2)
    UInt8[SS, (ushort)(BP - 0x6)] = Alu8.Inc(UInt8[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x30A8);
    // MOV byte ptr ES:[BX + SI],AL (0170_30A5 / 0x47A5)
    UInt8[ES, (ushort)(BX + SI)] = AL;
    CheckExternalEvents(cs2, 0x30AA);
    // JMP 0x0000:4781 (0170_30A8 / 0x47A8)
    goto label_0170_3081_04781;
    label_0170_30AA_047AA:
    CheckExternalEvents(cs2, 0x30AD);
    // INC byte ptr [BP + -0xc] (0170_30AA / 0x47AA)
    UInt8[SS, (ushort)(BP - 0xC)] = Alu8.Inc(UInt8[SS, (ushort)(BP - 0xC)]);
    label_0170_30AD_047AD:
    CheckExternalEvents(cs2, 0x30B0);
    // MOV AL,byte ptr [BP + -0xa] (0170_30AD / 0x47AD)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x30B3);
    // CMP byte ptr [BP + -0xc],AL (0170_30B0 / 0x47B0)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0xC)], AL);
    CheckExternalEvents(cs2, 0x30B5);
    // JNC 0x0000:47bb (0170_30B3 / 0x47B3)
    if(!CarryFlag) {
      goto label_0170_30BB_047BB;
    }
    CheckExternalEvents(cs2, 0x30B9);
    // MOV byte ptr [BP + -0x8],0x0 (0170_30B5 / 0x47B5)
    UInt8[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs2, 0x30BB);
    // JMP 0x0000:4784 (0170_30B9 / 0x47B9)
    goto label_0170_3084_04784;
    label_0170_30BB_047BB:
    CheckExternalEvents(cs2, 0x30BF);
    // CMP word ptr [BP + 0x8],0x2 (0170_30BB / 0x47BB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x2);
    CheckExternalEvents(cs2, 0x30C1);
    // JNZ 0x0000:47d8 (0170_30BF / 0x47BF)
    if(!ZeroFlag) {
      goto label_0170_30D8_047D8;
    }
    CheckExternalEvents(cs2, 0x30C5);
    // MOV ES,word ptr [0x538a] (0170_30C1 / 0x47C1)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x30CB);
    // CMP byte ptr ES:[0xd343],0x0 (0170_30C5 / 0x47C5)
    Alu8.Sub(UInt8[ES, 0xD343], 0x0);
    CheckExternalEvents(cs2, 0x30CD);
    // JZ 0x0000:47d8 (0170_30CB / 0x47CB)
    if(ZeroFlag) {
      goto label_0170_30D8_047D8;
    }
    CheckExternalEvents(cs2, 0x30CF);
    // SUB AX,AX (0170_30CD / 0x47CD)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs2, 0x30D0);
    // PUSH AX (0170_30CF / 0x47CF)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x30D5);
    // CALLF 0x0000:f7a2 (0170_30D0 / 0x47D0)
    FarCall(cs2, 0x30D5, ghidra_guess_0000_F7A2_0F7A2);
    CheckExternalEvents(cs2, 0x30D8);
    // ADD SP,0x2 (0170_30D5 / 0x47D5)
    SP += 0x2;
    label_0170_30D8_047D8:
    CheckExternalEvents(cs2, 0x30DD);
    // CMP word ptr [0x14c],0x0 (0170_30D8 / 0x47D8)
    Alu16.Sub(UInt16[DS, 0x14C], 0x0);
    CheckExternalEvents(cs2, 0x30DF);
    // JZ 0x0000:47e2 (0170_30DD / 0x47DD)
    if(ZeroFlag) {
      goto label_0170_30E2_047E2;
    }
    CheckExternalEvents(cs2, 0x30E2);
    // JMP 0x0000:4905 (0170_30DF / 0x47DF)
    goto label_0170_3205_04905;
    label_0170_30E2_047E2:
    CheckExternalEvents(cs2, 0x30E6);
    // MOV byte ptr [BP + -0x8],0x0 (0170_30E2 / 0x47E2)
    UInt8[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0170_30E6_047E6:
    CheckExternalEvents(cs2, 0x30E8);
    // MOV AL,0x1a (0170_30E6 / 0x47E6)
    AL = 0x1A;
    CheckExternalEvents(cs2, 0x30EB);
    // MUL byte ptr [BP + -0x8] (0170_30E8 / 0x47E8)
    ushort resMul0170_30E8 = Alu8.Mul(AL, UInt8[SS, (ushort)(BP - 0x8)]);
    AL = (byte)(resMul0170_30E8);
    AH = (byte)(resMul0170_30E8 >> 8);
    CheckExternalEvents(cs2, 0x30ED);
    // MOV BX,AX (0170_30EB / 0x47EB)
    BX = AX;
    CheckExternalEvents(cs2, 0x30F1);
    // MOV ES,word ptr [0x538a] (0170_30ED / 0x47ED)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x30F7);
    // MOV byte ptr ES:[BX + 0xd399],0x1 (0170_30F1 / 0x47F1)
    UInt8[ES, (ushort)(BX + 0xD399)] = 0x1;
    CheckExternalEvents(cs2, 0x30FC);
    // CALLF 0x1000:aab0 (0170_30F7 / 0x47F7)
    FarCall(cs2, 0x30FC, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs2, 0x30FE);
    // AND AL,0x7 (0170_30FC / 0x47FC)
    // AL &= 0x7;
    AL = Alu8.And(AL, 0x7);
    CheckExternalEvents(cs2, 0x3101);
    // MOV byte ptr [BP + -0xc],AL (0170_30FE / 0x47FE)
    UInt8[SS, (ushort)(BP - 0xC)] = AL;
    CheckExternalEvents(cs2, 0x3103);
    // MOV AL,0x1a (0170_3101 / 0x4801)
    AL = 0x1A;
    CheckExternalEvents(cs2, 0x3106);
    // MUL byte ptr [BP + -0x8] (0170_3103 / 0x4803)
    ushort resMul0170_3103 = Alu8.Mul(AL, UInt8[SS, (ushort)(BP - 0x8)]);
    AL = (byte)(resMul0170_3103);
    AH = (byte)(resMul0170_3103 >> 8);
    CheckExternalEvents(cs2, 0x3108);
    // MOV SI,AX (0170_3106 / 0x4806)
    SI = AX;
    CheckExternalEvents(cs2, 0x310B);
    // MOV AL,byte ptr [BP + -0xc] (0170_3108 / 0x4808)
    AL = UInt8[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x310D);
    // MOV CL,0x4 (0170_310B / 0x480B)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x310F);
    // SHL AL,CL (0170_310D / 0x480D)
    // AL <<= CL;
    AL = Alu8.Shl(AL, CL);
    CheckExternalEvents(cs2, 0x3113);
    // MOV ES,word ptr [0x538a] (0170_310F / 0x480F)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x3118);
    // MOV byte ptr ES:[SI + 0xd398],AL (0170_3113 / 0x4813)
    UInt8[ES, (ushort)(SI + 0xD398)] = AL;
    CheckExternalEvents(cs2, 0x311B);
    // MOV BL,byte ptr [BP + -0xc] (0170_3118 / 0x4818)
    BL = UInt8[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x311D);
    // SUB BH,BH (0170_311B / 0x481B)
    // BH -= BH;
    BH = Alu8.Sub(BH, BH);
    CheckExternalEvents(cs2, 0x3121);
    // MOV ES,word ptr [0x53da] (0170_311D / 0x481D)
    ES = UInt16[DS, 0x53DA];
    CheckExternalEvents(cs2, 0x3126);
    // MOV AL,byte ptr ES:[BX + 0x3768] (0170_3121 / 0x4821)
    AL = UInt8[ES, (ushort)(BX + 0x3768)];
    CheckExternalEvents(cs2, 0x3129);
    // MOV byte ptr [BP + -0xc],AL (0170_3126 / 0x4826)
    UInt8[SS, (ushort)(BP - 0xC)] = AL;
    CheckExternalEvents(cs2, 0x312D);
    // MOV ES,word ptr [0x538a] (0170_3129 / 0x4829)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x3132);
    // OR byte ptr ES:[SI + 0xd398],AL (0170_312D / 0x482D)
    // UInt8[ES, (ushort)(SI + 0xD398)] |= AL;
    UInt8[ES, (ushort)(SI + 0xD398)] = Alu8.Or(UInt8[ES, (ushort)(SI + 0xD398)], AL);
    CheckExternalEvents(cs2, 0x3135);
    // MOV AL,byte ptr [BP + -0xc] (0170_3132 / 0x4832)
    AL = UInt8[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs2, 0x3137);
    // SUB AH,AH (0170_3135 / 0x4835)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x3139);
    // MOV DI,AX (0170_3137 / 0x4837)
    DI = AX;
    CheckExternalEvents(cs2, 0x313B);
    // SHL DI,0x1 (0170_3139 / 0x4839)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs2, 0x313F);
    // MOV ES,word ptr [0x53ca] (0170_313B / 0x483B)
    ES = UInt16[DS, 0x53CA];
    CheckExternalEvents(cs2, 0x3144);
    // MOV AX,word ptr ES:[DI + 0x4564] (0170_313F / 0x483F)
    AX = UInt16[ES, (ushort)(DI + 0x4564)];
    CheckExternalEvents(cs2, 0x3148);
    // MOV ES,word ptr [0x538a] (0170_3144 / 0x4844)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x314D);
    // MOV word ptr ES:[SI + 0xd394],AX (0170_3148 / 0x4848)
    UInt16[ES, (ushort)(SI + 0xD394)] = AX;
    CheckExternalEvents(cs2, 0x3151);
    // MOV ES,word ptr [0x53cc] (0170_314D / 0x484D)
    ES = UInt16[DS, 0x53CC];
    CheckExternalEvents(cs2, 0x3156);
    // MOV AX,word ptr ES:[DI + 0x4596] (0170_3151 / 0x4851)
    AX = UInt16[ES, (ushort)(DI + 0x4596)];
    CheckExternalEvents(cs2, 0x315A);
    // MOV ES,word ptr [0x538a] (0170_3156 / 0x4856)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x315F);
    // MOV word ptr ES:[SI + 0xd396],AX (0170_315A / 0x485A)
    UInt16[ES, (ushort)(SI + 0xD396)] = AX;
    CheckExternalEvents(cs2, 0x3162);
    // MOV AL,byte ptr [BP + -0x8] (0170_315F / 0x485F)
    AL = UInt8[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x3164);
    // SUB AH,AH (0170_3162 / 0x4862)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x3167);
    // MOV word ptr [BP + -0x14],AX (0170_3164 / 0x4864)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs2, 0x3169);
    // SHL AX,0x1 (0170_3167 / 0x4867)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs2, 0x316C);
    // MOV word ptr [BP + -0x16],AX (0170_3169 / 0x4869)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs2, 0x3170);
    // MOV ES,word ptr [0x53ca] (0170_316C / 0x486C)
    ES = UInt16[DS, 0x53CA];
    CheckExternalEvents(cs2, 0x3175);
    // MOV AX,word ptr ES:[DI + 0x4564] (0170_3170 / 0x4870)
    AX = UInt16[ES, (ushort)(DI + 0x4564)];
    CheckExternalEvents(cs2, 0x3179);
    // MOV ES,word ptr [0x538a] (0170_3175 / 0x4875)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x317E);
    // MOV word ptr ES:[SI + 0xd390],AX (0170_3179 / 0x4879)
    UInt16[ES, (ushort)(SI + 0xD390)] = AX;
    CheckExternalEvents(cs2, 0x3181);
    // MOV BX,word ptr [BP + -0x16] (0170_317E / 0x487E)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x3185);
    // MOV ES,word ptr [0x53a4] (0170_3181 / 0x4881)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x318A);
    // MOV word ptr ES:[BX + 0x4024],AX (0170_3185 / 0x4885)
    UInt16[ES, (ushort)(BX + 0x4024)] = AX;
    CheckExternalEvents(cs2, 0x318E);
    // MOV ES,word ptr [0x53cc] (0170_318A / 0x488A)
    ES = UInt16[DS, 0x53CC];
    CheckExternalEvents(cs2, 0x3193);
    // MOV AX,word ptr ES:[DI + 0x4596] (0170_318E / 0x488E)
    AX = UInt16[ES, (ushort)(DI + 0x4596)];
    CheckExternalEvents(cs2, 0x3197);
    // MOV ES,word ptr [0x538a] (0170_3193 / 0x4893)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x319C);
    // MOV word ptr ES:[SI + 0xd392],AX (0170_3197 / 0x4897)
    UInt16[ES, (ushort)(SI + 0xD392)] = AX;
    CheckExternalEvents(cs2, 0x319F);
    // MOV BX,word ptr [BP + -0x16] (0170_319C / 0x489C)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x31A3);
    // MOV ES,word ptr [0x53a6] (0170_319F / 0x489F)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x31A8);
    // MOV word ptr ES:[BX + 0x4056],AX (0170_31A3 / 0x48A3)
    UInt16[ES, (ushort)(BX + 0x4056)] = AX;
    CheckExternalEvents(cs2, 0x31AB);
    // MOV BX,word ptr [BP + -0x14] (0170_31A8 / 0x48A8)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x31AF);
    // MOV ES,word ptr [0x53be] (0170_31AB / 0x48AB)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x31B5);
    // MOV byte ptr ES:[BX + 0x397c],0xff (0170_31AF / 0x48AF)
    UInt8[ES, (ushort)(BX + 0x397C)] = 0xFF;
    CheckExternalEvents(cs2, 0x31B8);
    // MOV BX,word ptr [BP + -0x14] (0170_31B5 / 0x48B5)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x31BC);
    // MOV ES,word ptr [0x539a] (0170_31B8 / 0x48B8)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs2, 0x31C2);
    // MOV byte ptr ES:[BX + 0x40aa],0x10 (0170_31BC / 0x48BC)
    UInt8[ES, (ushort)(BX + 0x40AA)] = 0x10;
    CheckExternalEvents(cs2, 0x31C6);
    // CMP word ptr [BP + 0x8],0xa (0170_31C2 / 0x48C2)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xA);
    CheckExternalEvents(cs2, 0x31C8);
    // JLE 0x0000:48f9 (0170_31C6 / 0x48C6)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_31F9_048F9;
    }
    CheckExternalEvents(cs2, 0x31CB);
    // MOV AL,byte ptr [BP + -0x8] (0170_31C8 / 0x48C8)
    AL = UInt8[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x31CD);
    // SUB AH,AH (0170_31CB / 0x48CB)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs2, 0x31CF);
    // MOV SI,AX (0170_31CD / 0x48CD)
    SI = AX;
    CheckExternalEvents(cs2, 0x31D1);
    // SHL SI,0x1 (0170_31CF / 0x48CF)
    SI <<= 0x1;
    CheckExternalEvents(cs2, 0x31D3);
    // SUB AL,AL (0170_31D1 / 0x48D1)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs2, 0x31D5);
    // MOV CX,AX (0170_31D3 / 0x48D3)
    CX = AX;
    CheckExternalEvents(cs2, 0x31D7);
    // MOV AL,0x1a (0170_31D5 / 0x48D5)
    AL = 0x1A;
    CheckExternalEvents(cs2, 0x31DA);
    // MUL byte ptr [BP + -0x8] (0170_31D7 / 0x48D7)
    ushort resMul0170_31D7 = Alu8.Mul(AL, UInt8[SS, (ushort)(BP - 0x8)]);
    AL = (byte)(resMul0170_31D7);
    AH = (byte)(resMul0170_31D7 >> 8);
    CheckExternalEvents(cs2, 0x31DC);
    // MOV BX,AX (0170_31DA / 0x48DA)
    BX = AX;
    CheckExternalEvents(cs2, 0x31E0);
    // MOV ES,word ptr [0x538a] (0170_31DC / 0x48DC)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x31E5);
    // MOV byte ptr ES:[BX + 0xd399],CL (0170_31E0 / 0x48E0)
    UInt8[ES, (ushort)(BX + 0xD399)] = CL;
    CheckExternalEvents(cs2, 0x31E7);
    // SUB CH,CH (0170_31E5 / 0x48E5)
    // CH -= CH;
    CH = Alu8.Sub(CH, CH);
    CheckExternalEvents(cs2, 0x31EB);
    // MOV ES,word ptr [0x53a6] (0170_31E7 / 0x48E7)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x31F0);
    // MOV word ptr ES:[SI + 0x4056],CX (0170_31EB / 0x48EB)
    UInt16[ES, (ushort)(SI + 0x4056)] = CX;
    CheckExternalEvents(cs2, 0x31F4);
    // MOV ES,word ptr [0x53a4] (0170_31F0 / 0x48F0)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x31F9);
    // MOV word ptr ES:[SI + 0x4024],CX (0170_31F4 / 0x48F4)
    UInt16[ES, (ushort)(SI + 0x4024)] = CX;
    label_0170_31F9_048F9:
    CheckExternalEvents(cs2, 0x31FC);
    // INC byte ptr [BP + -0x8] (0170_31F9 / 0x48F9)
    UInt8[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs2, 0x3200);
    // CMP byte ptr [BP + -0x8],0x8 (0170_31FC / 0x48FC)
    Alu8.Sub(UInt8[SS, (ushort)(BP - 0x8)], 0x8);
    CheckExternalEvents(cs2, 0x3202);
    // JNC 0x0000:4905 (0170_3200 / 0x4900)
    if(!CarryFlag) {
      goto label_0170_3205_04905;
    }
    CheckExternalEvents(cs2, 0x3205);
    // JMP 0x0000:47e6 (0170_3202 / 0x4902)
    goto label_0170_30E6_047E6;
    label_0170_3205_04905:
    CheckExternalEvents(cs2, 0x3206);
    // POP SI (0170_3205 / 0x4905)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x3207);
    // POP DI (0170_3206 / 0x4906)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x3209);
    // MOV SP,BP (0170_3207 / 0x4907)
    SP = BP;
    CheckExternalEvents(cs2, 0x320A);
    // POP BP (0170_3209 / 0x4909)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x320B);
    // RETF  (0170_320A / 0x490A)
    return FarRet();
  }
  
}
