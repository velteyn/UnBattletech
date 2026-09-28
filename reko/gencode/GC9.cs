namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_0000_F2FB_0F2FB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_F2FB_0F2FB:
    CheckExternalEvents(cs1, 0xF2FC);
    // PUSH BP (0000_F2FB / 0xF2FB)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xF2FE);
    // MOV BP,SP (0000_F2FC / 0xF2FC)
    BP = SP;
    CheckExternalEvents(cs1, 0xF301);
    // MOV AX,0x2 (0000_F2FE / 0xF2FE)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xF306);
    // CALLF 0x1000:cecc (0000_F301 / 0xF301)
    FarCall(cs1, 0xF306, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xF307);
    // PUSH SI (0000_F306 / 0xF306)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xF30C);
    // CALLF 0x0000:3fa2 (0000_F307 / 0xF307)
    FarCall(cs1, 0xF30C, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0xF30F);
    // MOV AX,0x2b22 (0000_F30C / 0xF30C)
    AX = 0x2B22;
    CheckExternalEvents(cs1, 0xF310);
    // PUSH DS (0000_F30F / 0xF30F)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF311);
    // PUSH AX (0000_F310 / 0xF310)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF316);
    // CALLF 0x1000:8055 (0000_F311 / 0xF311)
    FarCall(cs1, 0xF316, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF319);
    // ADD SP,0x4 (0000_F316 / 0xF316)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF31E);
    // MOV word ptr [BP + -0x2],0x1 (0000_F319 / 0xF319)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0000_F31E_0F31E:
    CheckExternalEvents(cs1, 0xF322);
    // MOV BX,word ptr [0x2b20] (0000_F31E / 0xF31E)
    BX = UInt16[DS, 0x2B20];
    CheckExternalEvents(cs1, 0xF324);
    // SHL BX,0x1 (0000_F322 / 0xF322)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xF328);
    // MOV ES,word ptr [0x5556] (0000_F324 / 0xF324)
    ES = UInt16[DS, 0x5556];
    CheckExternalEvents(cs1, 0xF32E);
    // CMP word ptr ES:[BX + 0x406a],0x0 (0000_F328 / 0xF328)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs1, 0xF330);
    // JNZ 0x0000:f333 (0000_F32E / 0xF32E)
    if(!ZeroFlag) {
      goto label_0000_F333_0F333;
    }
    CheckExternalEvents(cs1, 0xF333);
    // JMP 0x0000:f546 (0000_F330 / 0xF330)
    goto label_0000_F546_0F546;
    label_0000_F333_0F333:
    CheckExternalEvents(cs1, 0xF336);
    // MOV AX,0x3 (0000_F333 / 0xF333)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF337);
    // PUSH AX (0000_F336 / 0xF336)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF33C);
    // CALLF 0x1000:7ee1 (0000_F337 / 0xF337)
    FarCall(cs1, 0xF33C, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF33F);
    // ADD SP,0x2 (0000_F33C / 0xF33C)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xF342);
    // MOV AX,0x3 (0000_F33F / 0xF33F)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF343);
    // PUSH AX (0000_F342 / 0xF342)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF348);
    // CALLF 0x1000:7c64 (0000_F343 / 0xF343)
    FarCall(cs1, 0xF348, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xF34B);
    // ADD SP,0x2 (0000_F348 / 0xF348)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xF350);
    // CALLF 0x1000:7fe8 (0000_F34B / 0xF34B)
    FarCall(cs1, 0xF350, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xF354);
    // MOV ES,word ptr [0x555a] (0000_F350 / 0xF350)
    ES = UInt16[DS, 0x555A];
    CheckExternalEvents(cs1, 0xF35B);
    // MOV word ptr ES:[0xc6],0x3 (0000_F354 / 0xF354)
    UInt16[ES, 0xC6] = 0x3;
    CheckExternalEvents(cs1, 0xF35E);
    // MOV AX,0x2b36 (0000_F35B / 0xF35B)
    AX = 0x2B36;
    CheckExternalEvents(cs1, 0xF35F);
    // PUSH DS (0000_F35E / 0xF35E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF360);
    // PUSH AX (0000_F35F / 0xF35F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF365);
    // CALLF 0x1000:8055 (0000_F360 / 0xF360)
    FarCall(cs1, 0xF365, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF368);
    // ADD SP,0x4 (0000_F365 / 0xF365)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF36B);
    // MOV AX,0x1 (0000_F368 / 0xF368)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xF36C);
    // PUSH AX (0000_F36B / 0xF36B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF370);
    // PUSH word ptr [0x2b20] (0000_F36C / 0xF36C)
    Stack.Push16(UInt16[DS, 0x2B20]);
    CheckExternalEvents(cs1, 0xF375);
    // CALLF 0x1000:3224 (0000_F370 / 0xF370)
    FarCall(cs1, 0xF375, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs1, 0xF378);
    // ADD SP,0x4 (0000_F375 / 0xF375)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF37B);
    // MOV AX,0x4 (0000_F378 / 0xF378)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF37C);
    // PUSH AX (0000_F37B / 0xF37B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF381);
    // CALLF 0x1000:7ee1 (0000_F37C / 0xF37C)
    FarCall(cs1, 0xF381, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF384);
    // ADD SP,0x2 (0000_F381 / 0xF381)
    SP += 0x2;
    CheckExternalEvents(cs1, 0xF389);
    // CMP word ptr [0x2b20],0x10 (0000_F384 / 0xF384)
    Alu16.Sub(UInt16[DS, 0x2B20], 0x10);
    CheckExternalEvents(cs1, 0xF38B);
    // JL 0x0000:f3b5 (0000_F389 / 0xF389)
    if(SignFlag != OverflowFlag) {
      goto label_0000_F3B5_0F3B5;
    }
    CheckExternalEvents(cs1, 0xF390);
    // CALLF 0x0000:3fa2 (0000_F38B / 0xF38B)
    FarCall(cs1, 0xF390, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0xF394);
    // MOV ES,word ptr [0x554e] (0000_F390 / 0xF390)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xF39B);
    // MOV word ptr ES:[0x3748],0x0 (0000_F394 / 0xF394)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0xF39F);
    // MOV ES,word ptr [0x5550] (0000_F39B / 0xF39B)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xF3A6);
    // MOV word ptr ES:[0x374e],0x8 (0000_F39F / 0xF39F)
    UInt16[ES, 0x374E] = 0x8;
    CheckExternalEvents(cs1, 0xF3A9);
    // MOV AX,0x2b54 (0000_F3A6 / 0xF3A6)
    AX = 0x2B54;
    CheckExternalEvents(cs1, 0xF3AA);
    // PUSH DS (0000_F3A9 / 0xF3A9)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF3AB);
    // PUSH AX (0000_F3AA / 0xF3AA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3B0);
    // CALLF 0x1000:8055 (0000_F3AB / 0xF3AB)
    FarCall(cs1, 0xF3B0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF3B3);
    // ADD SP,0x4 (0000_F3B0 / 0xF3B0)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF3B5);
    // JMP 0x0000:f3cd (0000_F3B3 / 0xF3B3)
    goto label_0000_F3CD_0F3CD;
    label_0000_F3B5_0F3B5:
    CheckExternalEvents(cs1, 0xF3B7);
    // SUB AX,AX (0000_F3B5 / 0xF3B5)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xF3B8);
    // PUSH AX (0000_F3B7 / 0xF3B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3BB);
    // MOV AX,0x57 (0000_F3B8 / 0xF3B8)
    AX = 0x57;
    CheckExternalEvents(cs1, 0xF3BC);
    // PUSH AX (0000_F3BB / 0xF3BB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3BD);
    // PUSH AX (0000_F3BC / 0xF3BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3C0);
    // MOV AX,0x48 (0000_F3BD / 0xF3BD)
    AX = 0x48;
    CheckExternalEvents(cs1, 0xF3C1);
    // PUSH AX (0000_F3C0 / 0xF3C0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3C4);
    // MOV AX,0x8 (0000_F3C1 / 0xF3C1)
    AX = 0x8;
    CheckExternalEvents(cs1, 0xF3C5);
    // PUSH AX (0000_F3C4 / 0xF3C4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3CA);
    // CALLF 0x1000:8ccb (0000_F3C5 / 0xF3C5)
    FarCall(cs1, 0xF3CA, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0xF3CD);
    // ADD SP,0xa (0000_F3CA / 0xF3CA)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_0000_F3CD_0F3CD:
    CheckExternalEvents(cs1, 0xF3D1);
    // MOV ES,word ptr [0x554e] (0000_F3CD / 0xF3CD)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xF3D8);
    // MOV word ptr ES:[0x3748],0x0 (0000_F3D1 / 0xF3D1)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0xF3DC);
    // MOV ES,word ptr [0x5550] (0000_F3D8 / 0xF3D8)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xF3E3);
    // MOV word ptr ES:[0x374e],0x5 (0000_F3DC / 0xF3DC)
    UInt16[ES, 0x374E] = 0x5;
    CheckExternalEvents(cs1, 0xF3E8);
    // CMP word ptr [0x2b20],0xf (0000_F3E3 / 0xF3E3)
    Alu16.Sub(UInt16[DS, 0x2B20], 0xF);
    CheckExternalEvents(cs1, 0xF3EA);
    // JLE 0x0000:f447 (0000_F3E8 / 0xF3E8)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_F447_0F447;
    }
    CheckExternalEvents(cs1, 0xF3ED);
    // MOV AX,0x2b5e (0000_F3EA / 0xF3EA)
    AX = 0x2B5E;
    CheckExternalEvents(cs1, 0xF3EE);
    // PUSH DS (0000_F3ED / 0xF3ED)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF3EF);
    // PUSH AX (0000_F3EE / 0xF3EE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3F4);
    // CALLF 0x1000:8055 (0000_F3EF / 0xF3EF)
    FarCall(cs1, 0xF3F4, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF3F7);
    // ADD SP,0x4 (0000_F3F4 / 0xF3F4)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xF3F9);
    // SUB AX,AX (0000_F3F7 / 0xF3F7)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xF3FA);
    // PUSH AX (0000_F3F9 / 0xF3F9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3FD);
    // MOV AX,0x57 (0000_F3FA / 0xF3FA)
    AX = 0x57;
    CheckExternalEvents(cs1, 0xF3FE);
    // PUSH AX (0000_F3FD / 0xF3FD)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF3FF);
    // PUSH AX (0000_F3FE / 0xF3FE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF402);
    // MOV AX,0x50 (0000_F3FF / 0xF3FF)
    AX = 0x50;
    CheckExternalEvents(cs1, 0xF403);
    // PUSH AX (0000_F402 / 0xF402)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF406);
    // MOV AX,0x8 (0000_F403 / 0xF403)
    AX = 0x8;
    CheckExternalEvents(cs1, 0xF407);
    // PUSH AX (0000_F406 / 0xF406)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF40C);
    // CALLF 0x1000:8ccb (0000_F407 / 0xF407)
    FarCall(cs1, 0xF40C, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0xF40F);
    // ADD SP,0xa (0000_F40C / 0xF40C)
    SP += 0xA;
    CheckExternalEvents(cs1, 0xF411);
    // SUB AX,AX (0000_F40F / 0xF40F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xF412);
    // PUSH AX (0000_F411 / 0xF411)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF415);
    // MOV AX,0xf (0000_F412 / 0xF412)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xF416);
    // PUSH AX (0000_F415 / 0xF415)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF419);
    // MOV AX,0xa (0000_F416 / 0xF416)
    AX = 0xA;
    CheckExternalEvents(cs1, 0xF41A);
    // PUSH AX (0000_F419 / 0xF419)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF41D);
    // MOV AX,0x1 (0000_F41A / 0xF41A)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xF41E);
    // PUSH AX (0000_F41D / 0xF41D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF421);
    // MOV AX,0x11 (0000_F41E / 0xF41E)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF425);
    // IMUL word ptr [0x2b20] (0000_F421 / 0xF421)
    int resImul0000_F421 = Alu16.Imul((short)AX, (short)UInt16[DS, 0x2B20]);
    AX = (ushort)(resImul0000_F421);
    DX = (ushort)(resImul0000_F421 >> 16);
    CheckExternalEvents(cs1, 0xF427);
    // MOV BX,AX (0000_F425 / 0xF425)
    BX = AX;
    CheckExternalEvents(cs1, 0xF42B);
    // MOV ES,word ptr [0x5546] (0000_F427 / 0xF427)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF42D);
    // MOV AL,0x11 (0000_F42B / 0xF42B)
    AL = 0x11;
    CheckExternalEvents(cs1, 0xF432);
    // IMUL byte ptr ES:[BX + 0xc597] (0000_F42D / 0xF42D)
    short resImul0000_F42D = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC597)]);
    AL = (byte)(resImul0000_F42D);
    AH = (byte)(resImul0000_F42D >> 8);
    CheckExternalEvents(cs1, 0xF434);
    // MOV BX,AX (0000_F432 / 0xF432)
    BX = AX;
    CheckExternalEvents(cs1, 0xF438);
    // LEA AX,[BX + 0x2ed8] (0000_F434 / 0xF434)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0xF43B);
    // MOV DX,0x384b (0000_F438 / 0xF438)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0xF43C);
    // PUSH DX (0000_F43B / 0xF43B)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xF43D);
    // PUSH AX (0000_F43C / 0xF43C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF442);
    // CALLF 0x1000:8ba5 (0000_F43D / 0xF43D)
    FarCall(cs1, 0xF442, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0xF445);
    // ADD SP,0xc (0000_F442 / 0xF442)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0xF447);
    // JMP 0x0000:f47c (0000_F445 / 0xF445)
    goto label_0000_F47C_0F47C;
    label_0000_F447_0F447:
    CheckExternalEvents(cs1, 0xF44A);
    // MOV AX,0x7d (0000_F447 / 0xF447)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF44E);
    // IMUL word ptr [0x2b20] (0000_F44A / 0xF44A)
    int resImul0000_F44A = Alu16.Imul((short)AX, (short)UInt16[DS, 0x2B20]);
    AX = (ushort)(resImul0000_F44A);
    DX = (ushort)(resImul0000_F44A >> 16);
    CheckExternalEvents(cs1, 0xF450);
    // MOV BX,AX (0000_F44E / 0xF44E)
    BX = AX;
    CheckExternalEvents(cs1, 0xF454);
    // LEA AX,[BX + 0xc33c] (0000_F450 / 0xF450)
    AX = (ushort)(BX + 0xC33C);
    CheckExternalEvents(cs1, 0xF457);
    // MOV DX,0x2a02 (0000_F454 / 0xF454)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xF458);
    // PUSH DX (0000_F457 / 0xF457)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xF459);
    // PUSH AX (0000_F458 / 0xF458)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF45E);
    // CALLF 0x1000:8055 (0000_F459 / 0xF459)
    FarCall(cs1, 0xF45E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF461);
    // ADD SP,0x4 (0000_F45E / 0xF45E)
    SP += 0x4;
    CheckExternalEvents(cs1, 0xF463);
    // SUB AX,AX (0000_F461 / 0xF461)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xF464);
    // PUSH AX (0000_F463 / 0xF463)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF467);
    // MOV AX,0x4f (0000_F464 / 0xF464)
    AX = 0x4F;
    CheckExternalEvents(cs1, 0xF468);
    // PUSH AX (0000_F467 / 0xF467)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF46B);
    // MOV AX,0x57 (0000_F468 / 0xF468)
    AX = 0x57;
    CheckExternalEvents(cs1, 0xF46C);
    // PUSH AX (0000_F46B / 0xF46B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF46F);
    // MOV AX,0x48 (0000_F46C / 0xF46C)
    AX = 0x48;
    CheckExternalEvents(cs1, 0xF470);
    // PUSH AX (0000_F46F / 0xF46F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF473);
    // MOV AX,0x8 (0000_F470 / 0xF470)
    AX = 0x8;
    CheckExternalEvents(cs1, 0xF474);
    // PUSH AX (0000_F473 / 0xF473)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF479);
    // CALLF 0x1000:8ccb (0000_F474 / 0xF474)
    FarCall(cs1, 0xF479, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0xF47C);
    // ADD SP,0xa (0000_F479 / 0xF479)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_0000_F47C_0F47C:
    CheckExternalEvents(cs1, 0xF480);
    // MOV ES,word ptr [0x554e] (0000_F47C / 0xF47C)
    ES = UInt16[DS, 0x554E];
    CheckExternalEvents(cs1, 0xF487);
    // MOV word ptr ES:[0x3748],0x0 (0000_F480 / 0xF480)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0xF48B);
    // MOV ES,word ptr [0x5550] (0000_F487 / 0xF487)
    ES = UInt16[DS, 0x5550];
    CheckExternalEvents(cs1, 0xF492);
    // MOV word ptr ES:[0x374e],0x7 (0000_F48B / 0xF48B)
    UInt16[ES, 0x374E] = 0x7;
    CheckExternalEvents(cs1, 0xF495);
    // MOV SI,word ptr [BP + 0x6] (0000_F492 / 0xF492)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xF497);
    // SHL SI,0x1 (0000_F495 / 0xF495)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xF49B);
    // MOV ES,word ptr [0x5560] (0000_F497 / 0xF497)
    ES = UInt16[DS, 0x5560];
    CheckExternalEvents(cs1, 0xF4A0);
    // PUSH word ptr ES:[SI + 0x4036] (0000_F49B / 0xF49B)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs1, 0xF4A4);
    // MOV ES,word ptr [0x5562] (0000_F4A0 / 0xF4A0)
    ES = UInt16[DS, 0x5562];
    CheckExternalEvents(cs1, 0xF4A9);
    // PUSH word ptr ES:[SI + 0x4004] (0000_F4A4 / 0xF4A4)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs1, 0xF4AE);
    // CALLF 0x0000:2ebb (0000_F4A9 / 0xF4A9)
    FarCall(cs1, 0xF4AE, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs1, 0xF4B1);
    // ADD SP,0x4 (0000_F4AE / 0xF4AE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF4B4);
    // PUSH word ptr [BP + 0x8] (0000_F4B1 / 0xF4B1)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs1, 0xF4B8);
    // PUSH word ptr [0x2b20] (0000_F4B4 / 0xF4B4)
    Stack.Push16(UInt16[DS, 0x2B20]);
    CheckExternalEvents(cs1, 0xF4BD);
    // CALLF 0x1000:0934 (0000_F4B8 / 0xF4B8)
    FarCall(cs1, 0xF4BD, ghidra_guess_1000_0934_10934);
    CheckExternalEvents(cs1, 0xF4C0);
    // ADD SP,0x4 (0000_F4BD / 0xF4BD)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF4C2);
    // MOV BX,AX (0000_F4C0 / 0xF4C0)
    BX = AX;
    CheckExternalEvents(cs1, 0xF4C4);
    // SHL BX,0x1 (0000_F4C2 / 0xF4C2)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xF4C6);
    // SHL BX,0x1 (0000_F4C4 / 0xF4C4)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xF4CA);
    // MOV ES,word ptr [0x5558] (0000_F4C6 / 0xF4C6)
    ES = UInt16[DS, 0x5558];
    CheckExternalEvents(cs1, 0xF4CF);
    // PUSH word ptr ES:[BX + 0x2ebe] (0000_F4CA / 0xF4CA)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2EBE)]);
    CheckExternalEvents(cs1, 0xF4D4);
    // PUSH word ptr ES:[BX + 0x2ebc] (0000_F4CF / 0xF4CF)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x2EBC)]);
    CheckExternalEvents(cs1, 0xF4D9);
    // CALLF 0x1000:8055 (0000_F4D4 / 0xF4D4)
    FarCall(cs1, 0xF4D9, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF4DC);
    // ADD SP,0x4 (0000_F4D9 / 0xF4D9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF4DF);
    // MOV AX,0x2b6a (0000_F4DC / 0xF4DC)
    AX = 0x2B6A;
    CheckExternalEvents(cs1, 0xF4E0);
    // PUSH DS (0000_F4DF / 0xF4DF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF4E1);
    // PUSH AX (0000_F4E0 / 0xF4E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF4E6);
    // CALLF 0x1000:8055 (0000_F4E1 / 0xF4E1)
    FarCall(cs1, 0xF4E6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF4E9);
    // ADD SP,0x4 (0000_F4E6 / 0xF4E6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF4EC);
    // MOV AX,0x3 (0000_F4E9 / 0xF4E9)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF4ED);
    // PUSH AX (0000_F4EC / 0xF4EC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF4F2);
    // CALLF 0x1000:7ee1 (0000_F4ED / 0xF4ED)
    FarCall(cs1, 0xF4F2, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF4F5);
    // ADD SP,0x2 (0000_F4F2 / 0xF4F2)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xF4F8);
    // MOV AX,0x3 (0000_F4F5 / 0xF4F5)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xF4F9);
    // PUSH AX (0000_F4F8 / 0xF4F8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF4FE);
    // CALLF 0x1000:87be (0000_F4F9 / 0xF4F9)
    FarCall(cs1, 0xF4FE, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0xF501);
    // ADD SP,0x2 (0000_F4FE / 0xF4FE)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xF504);
    // MOV word ptr [BP + -0x2],AX (0000_F501 / 0xF501)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xF506);
    // OR AX,AX (0000_F504 / 0xF504)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0xF508);
    // JZ 0x0000:f514 (0000_F506 / 0xF506)
    if(ZeroFlag) {
      goto label_0000_F514_0F514;
    }
    CheckExternalEvents(cs1, 0xF50B);
    // CMP AX,0x1 (0000_F508 / 0xF508)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0xF50D);
    // JZ 0x0000:f546 (0000_F50B / 0xF50B)
    if(ZeroFlag) {
      goto label_0000_F546_0F546;
    }
    CheckExternalEvents(cs1, 0xF510);
    // CMP AX,0x2 (0000_F50D / 0xF50D)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0xF512);
    // JZ 0x0000:f52f (0000_F510 / 0xF510)
    if(ZeroFlag) {
      goto label_0000_F52F_0F52F;
    }
    CheckExternalEvents(cs1, 0xF514);
    // JMP 0x0000:f557 (0000_F512 / 0xF512)
    goto label_0000_F557_0F557;
    label_0000_F514_0F514:
    CheckExternalEvents(cs1, 0xF517);
    // MOV AL,[0x2b20] (0000_F514 / 0xF514)
    AL = UInt8[DS, 0x2B20];
    CheckExternalEvents(cs1, 0xF519);
    // MOV CX,AX (0000_F517 / 0xF517)
    CX = AX;
    CheckExternalEvents(cs1, 0xF51C);
    // MOV AX,0xc (0000_F519 / 0xF519)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xF51F);
    // IMUL word ptr [BP + 0x6] (0000_F51C / 0xF51C)
    int resImul0000_F51C = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F51C);
    DX = (ushort)(resImul0000_F51C >> 16);
    CheckExternalEvents(cs1, 0xF521);
    // MOV BX,AX (0000_F51F / 0xF51F)
    BX = AX;
    CheckExternalEvents(cs1, 0xF524);
    // ADD BX,word ptr [BP + 0xa] (0000_F521 / 0xF521)
    // BX += UInt16[SS, (ushort)(BP + 0xA)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs1, 0xF528);
    // MOV ES,word ptr [0x554a] (0000_F524 / 0xF524)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xF52D);
    // MOV byte ptr ES:[BX + 0x3800],CL (0000_F528 / 0xF528)
    UInt8[ES, (ushort)(BX + 0x3800)] = CL;
    CheckExternalEvents(cs1, 0xF52F);
    // JMP 0x0000:f557 (0000_F52D / 0xF52D)
    goto label_0000_F557_0F557;
    label_0000_F52F_0F52F:
    CheckExternalEvents(cs1, 0xF532);
    // MOV AX,0xc (0000_F52F / 0xF52F)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xF535);
    // IMUL word ptr [BP + 0x6] (0000_F532 / 0xF532)
    int resImul0000_F532 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_F532);
    DX = (ushort)(resImul0000_F532 >> 16);
    CheckExternalEvents(cs1, 0xF537);
    // MOV BX,AX (0000_F535 / 0xF535)
    BX = AX;
    CheckExternalEvents(cs1, 0xF53A);
    // ADD BX,word ptr [BP + 0xa] (0000_F537 / 0xF537)
    // BX += UInt16[SS, (ushort)(BP + 0xA)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs1, 0xF53E);
    // MOV ES,word ptr [0x554a] (0000_F53A / 0xF53A)
    ES = UInt16[DS, 0x554A];
    CheckExternalEvents(cs1, 0xF544);
    // MOV byte ptr ES:[BX + 0x3800],0xff (0000_F53E / 0xF53E)
    UInt8[ES, (ushort)(BX + 0x3800)] = 0xFF;
    CheckExternalEvents(cs1, 0xF546);
    // JMP 0x0000:f557 (0000_F544 / 0xF544)
    goto label_0000_F557_0F557;
    label_0000_F546_0F546:
    CheckExternalEvents(cs1, 0xF54A);
    // INC word ptr [0x2b20] (0000_F546 / 0xF546)
    UInt16[DS, 0x2B20]++;
    CheckExternalEvents(cs1, 0xF54F);
    // CMP word ptr [0x2b20],0x17 (0000_F54A / 0xF54A)
    Alu16.Sub(UInt16[DS, 0x2B20], 0x17);
    CheckExternalEvents(cs1, 0xF551);
    // JLE 0x0000:f557 (0000_F54F / 0xF54F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_F557_0F557;
    }
    CheckExternalEvents(cs1, 0xF557);
    // MOV word ptr [0x2b20],0xc (0000_F551 / 0xF551)
    UInt16[DS, 0x2B20] = 0xC;
    label_0000_F557_0F557:
    CheckExternalEvents(cs1, 0xF55B);
    // CMP word ptr [BP + -0x2],0x1 (0000_F557 / 0xF557)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x1);
    CheckExternalEvents(cs1, 0xF55D);
    // JNZ 0x0000:f560 (0000_F55B / 0xF55B)
    if(!ZeroFlag) {
      goto label_0000_F560_0F560;
    }
    CheckExternalEvents(cs1, 0xF560);
    // JMP 0x0000:f31e (0000_F55D / 0xF55D)
    goto label_0000_F31E_0F31E;
    label_0000_F560_0F560:
    CheckExternalEvents(cs1, 0xF561);
    // POP SI (0000_F560 / 0xF560)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF563);
    // MOV SP,BP (0000_F561 / 0xF561)
    SP = BP;
    CheckExternalEvents(cs1, 0xF564);
    // POP BP (0000_F563 / 0xF563)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF565);
    // RETF  (0000_F564 / 0xF564)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_F565_0F565(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_F565_0F565:
    CheckExternalEvents(cs1, 0xF566);
    // PUSH BP (0000_F565 / 0xF565)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xF568);
    // MOV BP,SP (0000_F566 / 0xF566)
    BP = SP;
    CheckExternalEvents(cs1, 0xF56B);
    // MOV AX,0xe (0000_F568 / 0xF568)
    AX = 0xE;
    CheckExternalEvents(cs1, 0xF570);
    // CALLF 0x1000:cecc (0000_F56B / 0xF56B)
    FarCall(cs1, 0xF570, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xF571);
    // PUSH DI (0000_F570 / 0xF570)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0xF572);
    // PUSH SI (0000_F571 / 0xF571)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xF575);
    // MOV SI,word ptr [BP + 0x6] (0000_F572 / 0xF572)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xF577);
    // SHL SI,0x1 (0000_F575 / 0xF575)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xF57B);
    // MOV ES,word ptr [0x5556] (0000_F577 / 0xF577)
    ES = UInt16[DS, 0x5556];
    CheckExternalEvents(cs1, 0xF582);
    // MOV word ptr ES:[SI + 0x406a],0x0 (0000_F57B / 0xF57B)
    UInt16[ES, (ushort)(SI + 0x406A)] = 0x0;
    CheckExternalEvents(cs1, 0xF586);
    // MOV ES,word ptr [0x5564] (0000_F582 / 0xF582)
    ES = UInt16[DS, 0x5564];
    CheckExternalEvents(cs1, 0xF58D);
    // MOV word ptr ES:[SI + 0x393c],0x1 (0000_F586 / 0xF586)
    UInt16[ES, (ushort)(SI + 0x393C)] = 0x1;
    CheckExternalEvents(cs1, 0xF592);
    // MOV word ptr [BP + -0x4],0x0 (0000_F58D / 0xF58D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0xF594);
    // JMP 0x0000:f5c6 (0000_F592 / 0xF592)
    goto label_0000_F5C6_0F5C6;
    label_0000_F594_0F594:
    CheckExternalEvents(cs1, 0xF597);
    // INC word ptr [BP + -0x6] (0000_F594 / 0xF594)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    label_0000_F597_0F597:
    CheckExternalEvents(cs1, 0xF59B);
    // CMP word ptr [BP + -0x6],0xc (0000_F597 / 0xF597)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0xC);
    CheckExternalEvents(cs1, 0xF59D);
    // JGE 0x0000:f5c3 (0000_F59B / 0xF59B)
    if(SignFlag == OverflowFlag) {
      goto label_0000_F5C3_0F5C3;
    }
    CheckExternalEvents(cs1, 0xF5A0);
    // MOV AX,0xc (0000_F59D / 0xF59D)
    AX = 0xC;
    CheckExternalEvents(cs1, 0xF5A3);
    // IMUL word ptr [BP + -0x4] (0000_F5A0 / 0xF5A0)
    int resImul0000_F5A0 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_F5A0);
    DX = (ushort)(resImul0000_F5A0 >> 16);
    CheckExternalEvents(cs1, 0xF5A6);
    // ADD AX,word ptr [BP + -0x6] (0000_F5A3 / 0xF5A3)
    AX += UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xF5A9);
    // ADD AX,0x3800 (0000_F5A6 / 0xF5A6)
    // AX += 0x3800;
    AX = Alu16.Add(AX, 0x3800);
    CheckExternalEvents(cs1, 0xF5AC);
    // MOV word ptr [BP + -0xe],AX (0000_F5A9 / 0xF5A9)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0xF5B1);
    // MOV word ptr [BP + -0xc],0x2a02 (0000_F5AC / 0xF5AC)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x2A02;
    CheckExternalEvents(cs1, 0xF5B4);
    // LES BX,[BP + -0xe] (0000_F5B1 / 0xF5B1)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    ES = UInt16[SS, (ushort)(BP - 0xE + 2)];
    CheckExternalEvents(cs1, 0xF5B7);
    // MOV AL,byte ptr ES:[BX] (0000_F5B4 / 0xF5B4)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs1, 0xF5B8);
    // CBW  (0000_F5B7 / 0xF5B7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xF5BB);
    // CMP AX,word ptr [BP + 0x6] (0000_F5B8 / 0xF5B8)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0xF5BD);
    // JNZ 0x0000:f594 (0000_F5BB / 0xF5BB)
    if(!ZeroFlag) {
      goto label_0000_F594_0F594;
    }
    CheckExternalEvents(cs1, 0xF5C1);
    // MOV byte ptr ES:[BX],0xff (0000_F5BD / 0xF5BD)
    UInt8[ES, (ushort)(BX)] = 0xFF;
    CheckExternalEvents(cs1, 0xF5C3);
    // JMP 0x0000:f594 (0000_F5C1 / 0xF5C1)
    goto label_0000_F594_0F594;
    label_0000_F5C3_0F5C3:
    CheckExternalEvents(cs1, 0xF5C6);
    // INC word ptr [BP + -0x4] (0000_F5C3 / 0xF5C3)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_F5C6_0F5C6:
    CheckExternalEvents(cs1, 0xF5CA);
    // CMP word ptr [BP + -0x4],0x18 (0000_F5C6 / 0xF5C6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x18);
    CheckExternalEvents(cs1, 0xF5CC);
    // JGE 0x0000:f5d3 (0000_F5CA / 0xF5CA)
    if(SignFlag == OverflowFlag) {
      goto label_0000_F5D3_0F5D3;
    }
    CheckExternalEvents(cs1, 0xF5D1);
    // MOV word ptr [BP + -0x6],0x0 (0000_F5CC / 0xF5CC)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0xF5D3);
    // JMP 0x0000:f597 (0000_F5D1 / 0xF5D1)
    goto label_0000_F597_0F597;
    label_0000_F5D3_0F5D3:
    CheckExternalEvents(cs1, 0xF5D6);
    // MOV AX,word ptr [BP + 0x6] (0000_F5D3 / 0xF5D3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xF5D9);
    // MOV word ptr [BP + -0xa],AX (0000_F5D6 / 0xF5D6)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0xF5DC);
    // CMP AX,0xc (0000_F5D9 / 0xF5D9)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs1, 0xF5DE);
    // JL 0x0000:f5e2 (0000_F5DC / 0xF5DC)
    if(SignFlag != OverflowFlag) {
      goto label_0000_F5E2_0F5E2;
    }
    CheckExternalEvents(cs1, 0xF5E2);
    // SUB word ptr [BP + -0xa],0x8 (0000_F5DE / 0xF5DE)
    // UInt16[SS, (ushort)(BP - 0xA)] -= 0x8;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x8);
    label_0000_F5E2_0F5E2:
    CheckExternalEvents(cs1, 0xF5E5);
    // MOV AX,0x7d (0000_F5E2 / 0xF5E2)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF5E8);
    // IMUL word ptr [BP + -0xa] (0000_F5E5 / 0xF5E5)
    int resImul0000_F5E5 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_F5E5);
    DX = (ushort)(resImul0000_F5E5 >> 16);
    CheckExternalEvents(cs1, 0xF5EA);
    // MOV BX,AX (0000_F5E8 / 0xF5E8)
    BX = AX;
    CheckExternalEvents(cs1, 0xF5EE);
    // MOV ES,word ptr [0x5546] (0000_F5EA / 0xF5EA)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF5F3);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_F5EE / 0xF5EE)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0xF5F6);
    // MOV BX,word ptr [BP + -0xa] (0000_F5F3 / 0xF5F3)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xF5FA);
    // MOV ES,word ptr [0x5566] (0000_F5F6 / 0xF5F6)
    ES = UInt16[DS, 0x5566];
    CheckExternalEvents(cs1, 0xF5FF);
    // MOV byte ptr ES:[BX + 0x323e],AL (0000_F5FA / 0xF5FA)
    UInt8[ES, (ushort)(BX + 0x323E)] = AL;
    CheckExternalEvents(cs1, 0xF602);
    // MOV AX,0x7d (0000_F5FF / 0xF5FF)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF605);
    // IMUL word ptr [BP + -0xa] (0000_F602 / 0xF602)
    int resImul0000_F602 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_F602);
    DX = (ushort)(resImul0000_F602 >> 16);
    CheckExternalEvents(cs1, 0xF607);
    // MOV BX,AX (0000_F605 / 0xF605)
    BX = AX;
    CheckExternalEvents(cs1, 0xF60B);
    // MOV ES,word ptr [0x5546] (0000_F607 / 0xF607)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF611);
    // MOV byte ptr ES:[BX + 0xc724],0xff (0000_F60B / 0xF60B)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0xFF;
    CheckExternalEvents(cs1, 0xF615);
    // MOV ES,word ptr [0x5568] (0000_F611 / 0xF611)
    ES = UInt16[DS, 0x5568];
    CheckExternalEvents(cs1, 0xF61B);
    // CMP word ptr ES:[0xe48e],0x0 (0000_F615 / 0xF615)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0xF61D);
    // JZ 0x0000:f64a (0000_F61B / 0xF61B)
    if(ZeroFlag) {
      goto label_0000_F64A_0F64A;
    }
    CheckExternalEvents(cs1, 0xF621);
    // CMP word ptr [BP + -0xa],0x4 (0000_F61D / 0xF61D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs1, 0xF623);
    // JNZ 0x0000:f63a (0000_F621 / 0xF621)
    if(!ZeroFlag) {
      goto label_0000_F63A_0F63A;
    }
    CheckExternalEvents(cs1, 0xF627);
    // MOV ES,word ptr [0x5546] (0000_F623 / 0xF623)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF62D);
    // MOV byte ptr ES:[0xc995],0xff (0000_F627 / 0xF627)
    UInt8[ES, 0xC995] = 0xFF;
    CheckExternalEvents(cs1, 0xF631);
    // MOV ES,word ptr [0x5556] (0000_F62D / 0xF62D)
    ES = UInt16[DS, 0x5556];
    CheckExternalEvents(cs1, 0xF638);
    // MOV word ptr ES:[0x4084],0x0 (0000_F631 / 0xF631)
    UInt16[ES, 0x4084] = 0x0;
    CheckExternalEvents(cs1, 0xF63A);
    // JMP 0x0000:f64a (0000_F638 / 0xF638)
    goto label_0000_F64A_0F64A;
    label_0000_F63A_0F63A:
    CheckExternalEvents(cs1, 0xF63E);
    // CMP word ptr [BP + -0xa],0x5 (0000_F63A / 0xF63A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x5);
    CheckExternalEvents(cs1, 0xF640);
    // JNZ 0x0000:f64a (0000_F63E / 0xF63E)
    if(!ZeroFlag) {
      goto label_0000_F64A_0F64A;
    }
    CheckExternalEvents(cs1, 0xF642);
    // SUB AX,AX (0000_F640 / 0xF640)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xF643);
    // PUSH AX (0000_F642 / 0xF642)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF644);
    // PUSH CS (0000_F643 / 0xF643)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0xF647);
    // CALL 0x0000:f7a2 (0000_F644 / 0xF644)
    NearCall(cs1, 0xF647, ghidra_guess_0000_F7A2_0F7A2);
    CheckExternalEvents(cs1, 0xF64A);
    // ADD SP,0x2 (0000_F647 / 0xF647)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_F64A_0F64A:
    CheckExternalEvents(cs1, 0xF64E);
    // MOV ES,word ptr [0x556a] (0000_F64A / 0xF64A)
    ES = UInt16[DS, 0x556A];
    CheckExternalEvents(cs1, 0xF650);
    // SUB AX,AX (0000_F64E / 0xF64E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xF654);
    // MOV ES:[0x4586],AX (0000_F650 / 0xF650)
    UInt16[ES, 0x4586] = AX;
    CheckExternalEvents(cs1, 0xF658);
    // MOV ES,word ptr [0x556c] (0000_F654 / 0xF654)
    ES = UInt16[DS, 0x556C];
    CheckExternalEvents(cs1, 0xF65C);
    // MOV ES:[0x3986],AX (0000_F658 / 0xF658)
    UInt16[ES, 0x3986] = AX;
    CheckExternalEvents(cs1, 0xF65F);
    // MOV AX,0x4 (0000_F65C / 0xF65C)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xF660);
    // PUSH AX (0000_F65F / 0xF65F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF665);
    // CALLF 0x1000:7ee1 (0000_F660 / 0xF660)
    FarCall(cs1, 0xF665, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xF668);
    // ADD SP,0x2 (0000_F665 / 0xF665)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xF66D);
    // CALLF 0x0000:3fa2 (0000_F668 / 0xF668)
    FarCall(cs1, 0xF66D, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0xF671);
    // MOV ES,word ptr [0x5568] (0000_F66D / 0xF66D)
    ES = UInt16[DS, 0x5568];
    CheckExternalEvents(cs1, 0xF677);
    // CMP word ptr ES:[0xe48e],0x0 (0000_F671 / 0xF671)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0xF679);
    // JZ 0x0000:f67f (0000_F677 / 0xF677)
    if(ZeroFlag) {
      goto label_0000_F67F_0F67F;
    }
    CheckExternalEvents(cs1, 0xF67D);
    // CMP word ptr [BP + 0x6],0xd (0000_F679 / 0xF679)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xD);
    CheckExternalEvents(cs1, 0xF67F);
    // JZ 0x0000:f698 (0000_F67D / 0xF67D)
    if(ZeroFlag) {
      goto label_0000_F698_0F698;
    }
    label_0000_F67F_0F67F:
    CheckExternalEvents(cs1, 0xF683);
    // MOV ES,word ptr [0x556e] (0000_F67F / 0xF67F)
    ES = UInt16[DS, 0x556E];
    CheckExternalEvents(cs1, 0xF689);
    // CMP word ptr ES:[0x2e38],0x0 (0000_F683 / 0xF683)
    Alu16.Sub(UInt16[ES, 0x2E38], 0x0);
    CheckExternalEvents(cs1, 0xF68B);
    // JZ 0x0000:f698 (0000_F689 / 0xF689)
    if(ZeroFlag) {
      goto label_0000_F698_0F698;
    }
    CheckExternalEvents(cs1, 0xF68E);
    // MOV AX,0x2b6d (0000_F68B / 0xF68B)
    AX = 0x2B6D;
    CheckExternalEvents(cs1, 0xF68F);
    // PUSH DS (0000_F68E / 0xF68E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF690);
    // PUSH AX (0000_F68F / 0xF68F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF695);
    // CALLF 0x1000:17bb (0000_F690 / 0xF690)
    FarCall(cs1, 0xF695, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs1, 0xF698);
    // ADD SP,0x4 (0000_F695 / 0xF695)
    SP += 0x4;
    label_0000_F698_0F698:
    CheckExternalEvents(cs1, 0xF69C);
    // CMP word ptr [BP + -0xa],0x4 (0000_F698 / 0xF698)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs1, 0xF69E);
    // JL 0x0000:f6a1 (0000_F69C / 0xF69C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_F6A1_0F6A1;
    }
    CheckExternalEvents(cs1, 0xF6A1);
    // JMP 0x0000:f791 (0000_F69E / 0xF69E)
    goto label_0000_F791_0F791;
    label_0000_F6A1_0F6A1:
    CheckExternalEvents(cs1, 0xF6A4);
    // MOV AX,0x2b81 (0000_F6A1 / 0xF6A1)
    AX = 0x2B81;
    CheckExternalEvents(cs1, 0xF6A5);
    // PUSH DS (0000_F6A4 / 0xF6A4)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xF6A6);
    // PUSH AX (0000_F6A5 / 0xF6A5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xF6AB);
    // CALLF 0x1000:8055 (0000_F6A6 / 0xF6A6)
    FarCall(cs1, 0xF6AB, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xF6AE);
    // ADD SP,0x4 (0000_F6AB / 0xF6AB)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xF6B1);
    // MOV AX,0x7d (0000_F6AE / 0xF6AE)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF6B4);
    // IMUL word ptr [BP + -0xa] (0000_F6B1 / 0xF6B1)
    int resImul0000_F6B1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_F6B1);
    DX = (ushort)(resImul0000_F6B1 >> 16);
    CheckExternalEvents(cs1, 0xF6B6);
    // MOV BX,AX (0000_F6B4 / 0xF6B4)
    BX = AX;
    CheckExternalEvents(cs1, 0xF6BA);
    // MOV ES,word ptr [0x5546] (0000_F6B6 / 0xF6B6)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF6BF);
    // MOV AL,byte ptr ES:[BX + 0xc79d] (0000_F6BA / 0xF6BA)
    AL = UInt8[ES, (ushort)(BX + 0xC79D)];
    CheckExternalEvents(cs1, 0xF6C2);
    // MOV byte ptr [BP + -0xe],AL (0000_F6BF / 0xF6BF)
    UInt8[SS, (ushort)(BP - 0xE)] = AL;
    CheckExternalEvents(cs1, 0xF6C4);
    // CMP AL,0xff (0000_F6C2 / 0xF6C2)
    Alu8.Sub(AL, 0xFF);
    CheckExternalEvents(cs1, 0xF6C6);
    // JZ 0x0000:f70a (0000_F6C4 / 0xF6C4)
    if(ZeroFlag) {
      goto label_0000_F70A_0F70A;
    }
    CheckExternalEvents(cs1, 0xF6C8);
    // SUB AH,AH (0000_F6C6 / 0xF6C6)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0xF6CB);
    // MOV word ptr [BP + -0x2],AX (0000_F6C8 / 0xF6C8)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xF6CE);
    // MOV AX,0x11 (0000_F6CB / 0xF6CB)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF6D1);
    // IMUL word ptr [BP + -0x2] (0000_F6CE / 0xF6CE)
    int resImul0000_F6CE = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_F6CE);
    DX = (ushort)(resImul0000_F6CE >> 16);
    CheckExternalEvents(cs1, 0xF6D3);
    // MOV BX,AX (0000_F6D1 / 0xF6D1)
    BX = AX;
    CheckExternalEvents(cs1, 0xF6D9);
    // MOV byte ptr ES:[BX + 0xc620],0x8 (0000_F6D3 / 0xF6D3)
    UInt8[ES, (ushort)(BX + 0xC620)] = 0x8;
    CheckExternalEvents(cs1, 0xF6DC);
    // MOV SI,word ptr [BP + -0x2] (0000_F6D9 / 0xF6D9)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xF6DE);
    // SHL SI,0x1 (0000_F6DC / 0xF6DC)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xF6E2);
    // MOV ES,word ptr [0x5556] (0000_F6DE / 0xF6DE)
    ES = UInt16[DS, 0x5556];
    CheckExternalEvents(cs1, 0xF6E9);
    // MOV word ptr ES:[SI + 0x4072],0x1 (0000_F6E2 / 0xF6E2)
    UInt16[ES, (ushort)(SI + 0x4072)] = 0x1;
    CheckExternalEvents(cs1, 0xF6EC);
    // MOV DI,word ptr [BP + -0xa] (0000_F6E9 / 0xF6E9)
    DI = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xF6EE);
    // SHL DI,0x1 (0000_F6EC / 0xF6EC)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs1, 0xF6F2);
    // MOV ES,word ptr [0x5562] (0000_F6EE / 0xF6EE)
    ES = UInt16[DS, 0x5562];
    CheckExternalEvents(cs1, 0xF6F7);
    // MOV AX,word ptr ES:[DI + 0x4004] (0000_F6F2 / 0xF6F2)
    AX = UInt16[ES, (ushort)(DI + 0x4004)];
    CheckExternalEvents(cs1, 0xF6FC);
    // MOV word ptr ES:[SI + 0x400c],AX (0000_F6F7 / 0xF6F7)
    UInt16[ES, (ushort)(SI + 0x400C)] = AX;
    CheckExternalEvents(cs1, 0xF700);
    // MOV ES,word ptr [0x5560] (0000_F6FC / 0xF6FC)
    ES = UInt16[DS, 0x5560];
    CheckExternalEvents(cs1, 0xF705);
    // MOV AX,word ptr ES:[DI + 0x4036] (0000_F700 / 0xF700)
    AX = UInt16[ES, (ushort)(DI + 0x4036)];
    CheckExternalEvents(cs1, 0xF70A);
    // MOV word ptr ES:[SI + 0x403e],AX (0000_F705 / 0xF705)
    UInt16[ES, (ushort)(SI + 0x403E)] = AX;
    label_0000_F70A_0F70A:
    CheckExternalEvents(cs1, 0xF70D);
    // MOV AX,0x7d (0000_F70A / 0xF70A)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xF710);
    // IMUL word ptr [BP + -0xa] (0000_F70D / 0xF70D)
    int resImul0000_F70D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_F70D);
    DX = (ushort)(resImul0000_F70D >> 16);
    CheckExternalEvents(cs1, 0xF712);
    // MOV BX,AX (0000_F710 / 0xF710)
    BX = AX;
    CheckExternalEvents(cs1, 0xF716);
    // MOV ES,word ptr [0x5546] (0000_F712 / 0xF712)
    ES = UInt16[DS, 0x5546];
    CheckExternalEvents(cs1, 0xF71B);
    // MOV AL,byte ptr ES:[BX + 0xc79e] (0000_F716 / 0xF716)
    AL = UInt8[ES, (ushort)(BX + 0xC79E)];
    CheckExternalEvents(cs1, 0xF71E);
    // MOV byte ptr [BP + -0xe],AL (0000_F71B / 0xF71B)
    UInt8[SS, (ushort)(BP - 0xE)] = AL;
    CheckExternalEvents(cs1, 0xF720);
    // CMP AL,0xff (0000_F71E / 0xF71E)
    Alu8.Sub(AL, 0xFF);
    CheckExternalEvents(cs1, 0xF722);
    // JZ 0x0000:f780 (0000_F720 / 0xF720)
    if(ZeroFlag) {
      goto label_0000_F780_0F780;
    }
    CheckExternalEvents(cs1, 0xF724);
    // SUB AH,AH (0000_F722 / 0xF722)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0xF727);
    // MOV word ptr [BP + -0x2],AX (0000_F724 / 0xF724)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xF72A);
    // MOV AX,0x11 (0000_F727 / 0xF727)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xF72D);
    // IMUL word ptr [BP + -0x2] (0000_F72A / 0xF72A)
    int resImul0000_F72A = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_F72A);
    DX = (ushort)(resImul0000_F72A >> 16);
    CheckExternalEvents(cs1, 0xF72F);
    // MOV BX,AX (0000_F72D / 0xF72D)
    BX = AX;
    CheckExternalEvents(cs1, 0xF735);
    // MOV byte ptr ES:[BX + 0xc620],0x8 (0000_F72F / 0xF72F)
    UInt8[ES, (ushort)(BX + 0xC620)] = 0x8;
    CheckExternalEvents(cs1, 0xF738);
    // MOV SI,word ptr [BP + -0x2] (0000_F735 / 0xF735)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xF73A);
    // SHL SI,0x1 (0000_F738 / 0xF738)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xF73E);
    // MOV ES,word ptr [0x5556] (0000_F73A / 0xF73A)
    ES = UInt16[DS, 0x5556];
    CheckExternalEvents(cs1, 0xF745);
    // MOV word ptr ES:[SI + 0x4072],0x1 (0000_F73E / 0xF73E)
    UInt16[ES, (ushort)(SI + 0x4072)] = 0x1;
    CheckExternalEvents(cs1, 0xF748);
    // MOV BX,word ptr [BP + -0xa] (0000_F745 / 0xF745)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xF74A);
    // SHL BX,0x1 (0000_F748 / 0xF748)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xF74E);
    // MOV ES,word ptr [0x5562] (0000_F74A / 0xF74A)
    ES = UInt16[DS, 0x5562];
    CheckExternalEvents(cs1, 0xF753);
    // MOV AX,word ptr ES:[BX + 0x4004] (0000_F74E / 0xF74E)
    AX = UInt16[ES, (ushort)(BX + 0x4004)];
    CheckExternalEvents(cs1, 0xF754);
    // INC AX (0000_F753 / 0xF753)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0xF759);
    // MOV word ptr ES:[SI + 0x400c],AX (0000_F754 / 0xF754)
    UInt16[ES, (ushort)(SI + 0x400C)] = AX;
    CheckExternalEvents(cs1, 0xF75F);
    // TEST byte ptr ES:[SI + 0x400c],0x80 (0000_F759 / 0xF759)
    Alu8.And(UInt8[ES, (ushort)(SI + 0x400C)], 0x80);
    CheckExternalEvents(cs1, 0xF761);
    // JZ 0x0000:f768 (0000_F75F / 0xF75F)
    if(ZeroFlag) {
      goto label_0000_F768_0F768;
    }
    CheckExternalEvents(cs1, 0xF768);
    // ADD word ptr ES:[SI + 0x400c],0x80 (0000_F761 / 0xF761)
    // UInt16[ES, (ushort)(SI + 0x400C)] += 0x80;
    UInt16[ES, (ushort)(SI + 0x400C)] = Alu16.Add(UInt16[ES, (ushort)(SI + 0x400C)], 0x80);
    label_0000_F768_0F768:
    CheckExternalEvents(cs1, 0xF76B);
    // MOV BX,word ptr [BP + -0xa] (0000_F768 / 0xF768)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xF76D);
    // SHL BX,0x1 (0000_F76B / 0xF76B)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xF771);
    // MOV ES,word ptr [0x5560] (0000_F76D / 0xF76D)
    ES = UInt16[DS, 0x5560];
    CheckExternalEvents(cs1, 0xF776);
    // MOV AX,word ptr ES:[BX + 0x4036] (0000_F771 / 0xF771)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs1, 0xF779);
    // MOV BX,word ptr [BP + -0x2] (0000_F776 / 0xF776)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xF77B);
    // SHL BX,0x1 (0000_F779 / 0xF779)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xF780);
    // MOV word ptr ES:[BX + 0x403e],AX (0000_F77B / 0xF77B)
    UInt16[ES, (ushort)(BX + 0x403E)] = AX;
    label_0000_F780_0F780:
    CheckExternalEvents(cs1, 0xF784);
    // MOV ES,word ptr [0x5570] (0000_F780 / 0xF780)
    ES = UInt16[DS, 0x5570];
    CheckExternalEvents(cs1, 0xF78A);
    // CMP word ptr ES:[0x15e],0x5 (0000_F784 / 0xF784)
    Alu16.Sub(UInt16[ES, 0x15E], 0x5);
    CheckExternalEvents(cs1, 0xF78C);
    // JGE 0x0000:f791 (0000_F78A / 0xF78A)
    if(SignFlag == OverflowFlag) {
      goto label_0000_F791_0F791;
    }
    CheckExternalEvents(cs1, 0xF791);
    // CALLF 0x1000:17dc (0000_F78C / 0xF78C)
    FarCall(cs1, 0xF791, ghidra_guess_1000_17DC_117DC);
    label_0000_F791_0F791:
    CheckExternalEvents(cs1, 0xF795);
    // MOV ES,word ptr [0x5552] (0000_F791 / 0xF791)
    ES = UInt16[DS, 0x5552];
    CheckExternalEvents(cs1, 0xF79C);
    // MOV word ptr ES:[0x37fe],0xf (0000_F795 / 0xF795)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0xF79D);
    // POP SI (0000_F79C / 0xF79C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF79E);
    // POP DI (0000_F79D / 0xF79D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF7A0);
    // MOV SP,BP (0000_F79E / 0xF79E)
    SP = BP;
    CheckExternalEvents(cs1, 0xF7A1);
    // POP BP (0000_F7A0 / 0xF7A0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF7A2);
    // RETF  (0000_F7A1 / 0xF7A1)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_F7A2_0F7A2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_F7A2_0F7A2:
    CheckExternalEvents(cs1, 0xF7A3);
    // PUSH BP (0000_F7A2 / 0xF7A2)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xF7A5);
    // MOV BP,SP (0000_F7A3 / 0xF7A3)
    BP = SP;
    CheckExternalEvents(cs1, 0xF7A8);
    // MOV AX,0x2 (0000_F7A5 / 0xF7A5)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xF7AD);
    // CALLF 0x1000:cecc (0000_F7A8 / 0xF7A8)
    FarCall(cs1, 0xF7AD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xF7AE);
    // PUSH SI (0000_F7AD / 0xF7AD)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xF7B2);
    // CMP word ptr [BP + 0x6],0x0 (0000_F7AE / 0xF7AE)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xF7B4);
    // JZ 0x0000:f7d6 (0000_F7B2 / 0xF7B2)
    if(ZeroFlag) {
      goto label_0000_F7D6_0F7D6;
    }
    CheckExternalEvents(cs1, 0xF7B9);
    // MOV word ptr [BP + -0x2],0x0 (0000_F7B4 / 0xF7B4)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0xF7BB);
    // JMP 0x0000:f7be (0000_F7B9 / 0xF7B9)
    goto label_0000_F7BE_0F7BE;
    label_0000_F7BB_0F7BB:
    CheckExternalEvents(cs1, 0xF7BE);
    // INC word ptr [BP + -0x2] (0000_F7BB / 0xF7BB)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0000_F7BE_0F7BE:
    CheckExternalEvents(cs1, 0xF7C2);
    // CMP word ptr [BP + -0x2],0x26 (0000_F7BE / 0xF7BE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x26);
    CheckExternalEvents(cs1, 0xF7C4);
    // JGE 0x0000:f809 (0000_F7C2 / 0xF7C2)
    if(SignFlag == OverflowFlag) {
      goto label_0000_F809_0F809;
    }
    CheckExternalEvents(cs1, 0xF7C7);
    // MOV BX,word ptr [BP + -0x2] (0000_F7C4 / 0xF7C4)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xF7CB);
    // MOV AL,byte ptr [BX + 0x5804] (0000_F7C7 / 0xF7C7)
    AL = UInt8[DS, (ushort)(BX + 0x5804)];
    CheckExternalEvents(cs1, 0xF7CF);
    // MOV ES,word ptr [0x5572] (0000_F7CB / 0xF7CB)
    ES = UInt16[DS, 0x5572];
    CheckExternalEvents(cs1, 0xF7D4);
    // MOV byte ptr ES:[BX + 0x1c1d],AL (0000_F7CF / 0xF7CF)
    UInt8[ES, (ushort)(BX + 0x1C1D)] = AL;
    CheckExternalEvents(cs1, 0xF7D6);
    // JMP 0x0000:f7bb (0000_F7D4 / 0xF7D4)
    goto label_0000_F7BB_0F7BB;
    label_0000_F7D6_0F7D6:
    CheckExternalEvents(cs1, 0xF7DB);
    // MOV word ptr [BP + -0x2],0x0 (0000_F7D6 / 0xF7D6)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_F7DB_0F7DB:
    CheckExternalEvents(cs1, 0xF7DE);
    // MOV BX,word ptr [BP + -0x2] (0000_F7DB / 0xF7DB)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xF7E0);
    // MOV SI,BX (0000_F7DE / 0xF7DE)
    SI = BX;
    CheckExternalEvents(cs1, 0xF7E4);
    // MOV ES,word ptr [0x5572] (0000_F7E0 / 0xF7E0)
    ES = UInt16[DS, 0x5572];
    CheckExternalEvents(cs1, 0xF7E9);
    // MOV AL,byte ptr ES:[SI + 0x1c1d] (0000_F7E4 / 0xF7E4)
    AL = UInt8[ES, (ushort)(SI + 0x1C1D)];
    CheckExternalEvents(cs1, 0xF7ED);
    // MOV byte ptr [BX + 0x5804],AL (0000_F7E9 / 0xF7E9)
    UInt8[DS, (ushort)(BX + 0x5804)] = AL;
    CheckExternalEvents(cs1, 0xF7F0);
    // MOV BX,word ptr [BP + -0x2] (0000_F7ED / 0xF7ED)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xF7F5);
    // CMP byte ptr [BX + 0x2b8e],0x0 (0000_F7F0 / 0xF7F0)
    Alu8.Sub(UInt8[DS, (ushort)(BX + 0x2B8E)], 0x0);
    CheckExternalEvents(cs1, 0xF7F7);
    // JZ 0x0000:f800 (0000_F7F5 / 0xF7F5)
    if(ZeroFlag) {
      goto label_0000_F800_0F800;
    }
    CheckExternalEvents(cs1, 0xF7FB);
    // MOV AL,byte ptr [BX + 0x2b8e] (0000_F7F7 / 0xF7F7)
    AL = UInt8[DS, (ushort)(BX + 0x2B8E)];
    CheckExternalEvents(cs1, 0xF800);
    // MOV byte ptr ES:[BX + 0x1c1d],AL (0000_F7FB / 0xF7FB)
    UInt8[ES, (ushort)(BX + 0x1C1D)] = AL;
    label_0000_F800_0F800:
    CheckExternalEvents(cs1, 0xF803);
    // INC word ptr [BP + -0x2] (0000_F800 / 0xF800)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xF807);
    // CMP word ptr [BP + -0x2],0x26 (0000_F803 / 0xF803)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x26);
    CheckExternalEvents(cs1, 0xF809);
    // JL 0x0000:f7db (0000_F807 / 0xF807)
    if(SignFlag != OverflowFlag) {
      goto label_0000_F7DB_0F7DB;
    }
    label_0000_F809_0F809:
    CheckExternalEvents(cs1, 0xF80A);
    // POP SI (0000_F809 / 0xF809)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF80C);
    // MOV SP,BP (0000_F80A / 0xF80A)
    SP = BP;
    CheckExternalEvents(cs1, 0xF80D);
    // POP BP (0000_F80C / 0xF80C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xF80E);
    // RETF  (0000_F80D / 0xF80D)
    return FarRet();
  }
  
  public virtual Action unknown_0FA1_0006_0FA16(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0FA1_0006_0FA16:
    CheckExternalEvents(cs6, 0x7);
    // PUSH BP (0FA1_0006 / 0xFA16)
    Stack.Push16(BP);
    CheckExternalEvents(cs6, 0x9);
    // MOV BP,SP (0FA1_0007 / 0xFA17)
    BP = SP;
    CheckExternalEvents(cs6, 0xC);
    // MOV AX,0x1c (0FA1_0009 / 0xFA19)
    AX = 0x1C;
    CheckExternalEvents(cs6, 0x11);
    // CALLF 0x1000:cecc (0FA1_000C / 0xFA1C)
    FarCall(cs6, 0x11, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs6, 0x12);
    // PUSH DI (0FA1_0011 / 0xFA21)
    Stack.Push16(DI);
    CheckExternalEvents(cs6, 0x13);
    // PUSH SI (0FA1_0012 / 0xFA22)
    Stack.Push16(SI);
    CheckExternalEvents(cs6, 0x17);
    // CMP word ptr [BP + 0x10],0x0 (0FA1_0013 / 0xFA23)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x10)], 0x0);
    CheckExternalEvents(cs6, 0x19);
    // JZ 0x0000:fa3c (0FA1_0017 / 0xFA27)
    if(ZeroFlag) {
      goto label_0FA1_002C_0FA3C;
    }
    CheckExternalEvents(cs6, 0x1D);
    // DEC word ptr [0x315a] (0FA1_0019 / 0xFA29)
    UInt16[DS, 0x315A] = Alu16.Dec(UInt16[DS, 0x315A]);
    CheckExternalEvents(cs6, 0x1F);
    // JNZ 0x0000:fa42 (0FA1_001D / 0xFA2D)
    if(!ZeroFlag) {
      goto label_0FA1_0032_0FA42;
    }
    CheckExternalEvents(cs6, 0x25);
    // MOV word ptr [0x315a],0x1e (0FA1_001F / 0xFA2F)
    UInt16[DS, 0x315A] = 0x1E;
    CheckExternalEvents(cs6, 0x2A);
    // XOR byte ptr [0x315c],0x8 (0FA1_0025 / 0xFA35)
    // UInt8[DS, 0x315C] ^= 0x8;
    UInt8[DS, 0x315C] = Alu8.Xor(UInt8[DS, 0x315C], 0x8);
    CheckExternalEvents(cs6, 0x2C);
    // JMP 0x0000:fa42 (0FA1_002A / 0xFA3A)
    goto label_0FA1_0032_0FA42;
    label_0FA1_002C_0FA3C:
    CheckExternalEvents(cs6, 0x32);
    // MOV word ptr [0x315c],0x0 (0FA1_002C / 0xFA3C)
    UInt16[DS, 0x315C] = 0x0;
    label_0FA1_0032_0FA42:
    CheckExternalEvents(cs6, 0x35);
    // MOV BX,word ptr [BP + 0x6] (0FA1_0032 / 0xFA42)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs6, 0x38);
    // AND BX,0x7f (0FA1_0035 / 0xFA45)
    // BX &= 0x7F;
    BX = Alu16.And(BX, 0x7F);
    CheckExternalEvents(cs6, 0x3C);
    // MOV ES,word ptr [0x5578] (0FA1_0038 / 0xFA48)
    ES = UInt16[DS, 0x5578];
    CheckExternalEvents(cs6, 0x41);
    // MOV AL,byte ptr ES:[BX + 0x3920] (0FA1_003C / 0xFA4C)
    AL = UInt8[ES, (ushort)(BX + 0x3920)];
    CheckExternalEvents(cs6, 0x42);
    // CBW  (0FA1_0041 / 0xFA51)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs6, 0x45);
    // MOV word ptr [BP + -0x10],AX (0FA1_0042 / 0xFA52)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs6, 0x49);
    // MOV ES,word ptr [0x557a] (0FA1_0045 / 0xFA55)
    ES = UInt16[DS, 0x557A];
    CheckExternalEvents(cs6, 0x4B);
    // SUB AX,AX (0FA1_0049 / 0xFA59)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs6, 0x4E);
    // MOV word ptr [BP + -0x18],AX (0FA1_004B / 0xFA5B)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs6, 0x52);
    // MOV ES:[0x4590],AX (0FA1_004E / 0xFA5E)
    UInt16[ES, 0x4590] = AX;
    CheckExternalEvents(cs6, 0x56);
    // MOV ES,word ptr [0x557c] (0FA1_0052 / 0xFA62)
    ES = UInt16[DS, 0x557C];
    CheckExternalEvents(cs6, 0x5A);
    // MOV ES:[0x458e],AX (0FA1_0056 / 0xFA66)
    UInt16[ES, 0x458E] = AX;
    CheckExternalEvents(cs6, 0x5D);
    // MOV AL,byte ptr [BP + 0x6] (0FA1_005A / 0xFA6A)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs6, 0x5F);
    // AND AL,0x7f (0FA1_005D / 0xFA6D)
    AL &= 0x7F;
    CheckExternalEvents(cs6, 0x61);
    // CMP AL,0x4 (0FA1_005F / 0xFA6F)
    Alu8.Sub(AL, 0x4);
    CheckExternalEvents(cs6, 0x63);
    // JC 0x0000:fa7f (0FA1_0061 / 0xFA71)
    if(CarryFlag) {
      goto label_0FA1_006F_0FA7F;
    }
    CheckExternalEvents(cs6, 0x67);
    // CMP word ptr [BP + 0x6],0xc (0FA1_0063 / 0xFA73)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs6, 0x69);
    // JL 0x0000:fa84 (0FA1_0067 / 0xFA77)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_0074_0FA84;
    }
    CheckExternalEvents(cs6, 0x6D);
    // CMP word ptr [BP + 0x6],0x10 (0FA1_0069 / 0xFA79)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs6, 0x6F);
    // JGE 0x0000:fa84 (0FA1_006D / 0xFA7D)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_0074_0FA84;
    }
    label_0FA1_006F_0FA7F:
    CheckExternalEvents(cs6, 0x74);
    // MOV word ptr [BP + -0x18],0x1 (0FA1_006F / 0xFA7F)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x1;
    label_0FA1_0074_0FA84:
    CheckExternalEvents(cs6, 0x77);
    // PUSH word ptr [BP + 0xa] (0FA1_0074 / 0xFA84)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs6, 0x7A);
    // PUSH word ptr [BP + 0x8] (0FA1_0077 / 0xFA87)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs6, 0x7E);
    // MOV ES,word ptr [0x557e] (0FA1_007A / 0xFA8A)
    ES = UInt16[DS, 0x557E];
    CheckExternalEvents(cs6, 0x83);
    // PUSH word ptr ES:[0xe488] (0FA1_007E / 0xFA8E)
    Stack.Push16(UInt16[ES, 0xE488]);
    CheckExternalEvents(cs6, 0x87);
    // MOV ES,word ptr [0x5580] (0FA1_0083 / 0xFA93)
    ES = UInt16[DS, 0x5580];
    CheckExternalEvents(cs6, 0x8C);
    // PUSH word ptr ES:[0xe486] (0FA1_0087 / 0xFA97)
    Stack.Push16(UInt16[ES, 0xE486]);
    CheckExternalEvents(cs6, 0x91);
    // CALLF 0x1000:a861 (0FA1_008C / 0xFA9C)
    FarCall(cs6, 0x91, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs6, 0x94);
    // ADD SP,0x8 (0FA1_0091 / 0xFAA1)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs6, 0x97);
    // MOV word ptr [BP + -0x4],AX (0FA1_0094 / 0xFAA4)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs6, 0x98);
    // INC AX (0FA1_0097 / 0xFAA7)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs6, 0x9A);
    // JNZ 0x0000:faad (0FA1_0098 / 0xFAA8)
    if(!ZeroFlag) {
      goto label_0FA1_009D_0FAAD;
    }
    CheckExternalEvents(cs6, 0x9D);
    // JMP 0x0000:fcee (0FA1_009A / 0xFAAA)
    goto label_0FA1_02DE_0FCEE;
    label_0FA1_009D_0FAAD:
    CheckExternalEvents(cs6, 0xA0);
    // MOV AX,word ptr [BP + -0x4] (0FA1_009D / 0xFAAD)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs6, 0xA3);
    // SUB AX,word ptr [BP + -0x10] (0FA1_00A0 / 0xFAB0)
    // AX -= UInt16[SS, (ushort)(BP - 0x10)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs6, 0xA6);
    // MOV word ptr [BP + -0x16],AX (0FA1_00A3 / 0xFAB3)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs6, 0xA8);
    // OR AX,AX (0FA1_00A6 / 0xFAB6)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs6, 0xAA);
    // JZ 0x0000:fad0 (0FA1_00A8 / 0xFAB8)
    if(ZeroFlag) {
      goto label_0FA1_00C0_0FAD0;
    }
    CheckExternalEvents(cs6, 0xAE);
    // AND word ptr [BP + -0x16],0x7 (0FA1_00AA / 0xFABA)
    UInt16[SS, (ushort)(BP - 0x16)] &= 0x7;
    CheckExternalEvents(cs6, 0xB2);
    // CMP word ptr [BP + -0x16],0x5 (0FA1_00AE / 0xFABE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x16)], 0x5);
    CheckExternalEvents(cs6, 0xB4);
    // JGE 0x0000:fac9 (0FA1_00B2 / 0xFAC2)
    if(SignFlag == OverflowFlag) {
      goto label_0FA1_00B9_0FAC9;
    }
    CheckExternalEvents(cs6, 0xB7);
    // INC word ptr [BP + -0x10] (0FA1_00B4 / 0xFAC4)
    UInt16[SS, (ushort)(BP - 0x10)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs6, 0xB9);
    // JMP 0x0000:facc (0FA1_00B7 / 0xFAC7)
    goto label_0FA1_00BC_0FACC;
    label_0FA1_00B9_0FAC9:
    CheckExternalEvents(cs6, 0xBC);
    // DEC word ptr [BP + -0x10] (0FA1_00B9 / 0xFAC9)
    UInt16[SS, (ushort)(BP - 0x10)]--;
    label_0FA1_00BC_0FACC:
    CheckExternalEvents(cs6, 0xC0);
    // AND word ptr [BP + -0x10],0x7 (0FA1_00BC / 0xFACC)
    // UInt16[SS, (ushort)(BP - 0x10)] &= 0x7;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x10)], 0x7);
    label_0FA1_00C0_0FAD0:
    CheckExternalEvents(cs6, 0xC5);
    // MOV word ptr [BP + -0x14],0x7 (0FA1_00C0 / 0xFAD0)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x7;
    CheckExternalEvents(cs6, 0xC8);
    // JMP 0x0000:fbe6 (0FA1_00C5 / 0xFAD5)
    goto label_0FA1_01D6_0FBE6;
    label_0FA1_00C8_0FAD8:
    CheckExternalEvents(cs6, 0xCB);
    // INC word ptr [BP + -0xe] (0FA1_00C8 / 0xFAD8)
    UInt16[SS, (ushort)(BP - 0xE)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xE)]);
    label_0FA1_00CB_0FADB:
    CheckExternalEvents(cs6, 0xCF);
    // MOV ES,word ptr [0x5586] (0FA1_00CB / 0xFADB)
    ES = UInt16[DS, 0x5586];
    CheckExternalEvents(cs6, 0xD4);
    // MOV BX,word ptr ES:[0x9ed] (0FA1_00CF / 0xFADF)
    BX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs6, 0xD7);
    // ADD BX,word ptr [BP + -0xe] (0FA1_00D4 / 0xFAE4)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs6, 0xDB);
    // MOV ES,word ptr [0x5588] (0FA1_00D7 / 0xFAE7)
    ES = UInt16[DS, 0x5588];
    CheckExternalEvents(cs6, 0xE0);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0FA1_00DB / 0xFAEB)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs6, 0xE2);
    // SUB AH,AH (0FA1_00E0 / 0xFAF0)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs6, 0xE6);
    // MOV ES,word ptr [0x558a] (0FA1_00E2 / 0xFAF2)
    ES = UInt16[DS, 0x558A];
    CheckExternalEvents(cs6, 0xEB);
    // CMP AX,word ptr ES:[0x150] (0FA1_00E6 / 0xFAF6)
    Alu16.Sub(AX, UInt16[ES, 0x150]);
    CheckExternalEvents(cs6, 0xED);
    // JC 0x0000:fb02 (0FA1_00EB / 0xFAFB)
    if(CarryFlag) {
      goto label_0FA1_00F2_0FB02;
    }
    CheckExternalEvents(cs6, 0xF2);
    // MOV word ptr [BP + -0xc],0x0 (0FA1_00ED / 0xFAFD)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0FA1_00F2_0FB02:
    CheckExternalEvents(cs6, 0xF6);
    // CMP word ptr [BP + -0xc],0x0 (0FA1_00F2 / 0xFB02)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs6, 0xF8);
    // JNZ 0x0000:fb0b (0FA1_00F6 / 0xFB06)
    if(!ZeroFlag) {
      goto label_0FA1_00FB_0FB0B;
    }
    CheckExternalEvents(cs6, 0xFB);
    // JMP 0x0000:fb95 (0FA1_00F8 / 0xFB08)
    goto label_0FA1_0185_0FB95;
    label_0FA1_00FB_0FB0B:
    CheckExternalEvents(cs6, 0x100);
    // CMP word ptr [BP + 0x6],0x80 (0FA1_00FB / 0xFB0B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x80);
    CheckExternalEvents(cs6, 0x102);
    // JL 0x0000:fb15 (0FA1_0100 / 0xFB10)
    if(SignFlag != OverflowFlag) {
      goto label_0FA1_0105_0FB15;
    }
    CheckExternalEvents(cs6, 0x105);
    // JMP 0x0000:fb95 (0FA1_0102 / 0xFB12)
    goto label_0FA1_0185_0FB95;
    label_0FA1_0105_0FB15:
    CheckExternalEvents(cs6, 0x109);
    // MOV ES,word ptr [0x5582] (0FA1_0105 / 0xFB15)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs6, 0x10D);
    // MOV AX,ES:[0xa44b] (0FA1_0109 / 0xFB19)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs6, 0x110);
    // MOV word ptr [BP + -0x1a],AX (0FA1_010D / 0xFB1D)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs6, 0x114);
    // MOV ES,word ptr [0x5584] (0FA1_0110 / 0xFB20)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs6, 0x118);
    // MOV AX,ES:[0xa44d] (0FA1_0114 / 0xFB24)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs6, 0x11B);
    // MOV word ptr [BP + -0x1c],AX (0FA1_0118 / 0xFB28)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs6, 0x11F);
    // MOV ES,word ptr [0x5582] (0FA1_011B / 0xFB2B)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs6, 0x122);
    // MOV AX,word ptr [BP + -0x2] (0FA1_011F / 0xFB2F)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs6, 0x126);
    // MOV ES:[0xa44b],AX (0FA1_0122 / 0xFB32)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs6, 0x12A);
    // MOV ES,word ptr [0x5584] (0FA1_0126 / 0xFB36)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs6, 0x12D);
    // MOV AX,word ptr [BP + -0x6] (0FA1_012A / 0xFB3A)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs6, 0x131);
    // MOV ES:[0xa44d],AX (0FA1_012D / 0xFB3D)
    UInt16[ES, 0xA44D] = AX;
    CheckExternalEvents(cs6, 0x134);
    // MOV SI,word ptr [BP + -0x10] (0FA1_0131 / 0xFB41)
    SI = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs6, 0x136);
    // SHL SI,0x1 (0FA1_0134 / 0xFB44)
    SI <<= 0x1;
    CheckExternalEvents(cs6, 0x138);
    // SUB AX,AX (0FA1_0136 / 0xFB46)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs6, 0x139);
    // PUSH AX (0FA1_0138 / 0xFB48)
    Stack.Push16(AX);
    CheckExternalEvents(cs6, 0x13D);
    // PUSH word ptr [SI + 0x312a] (0FA1_0139 / 0xFB49)
    Stack.Push16(UInt16[DS, (ushort)(SI + 0x312A)]);
    CheckExternalEvents(cs6, 0x141);
    // PUSH word ptr [SI + 0x311a] (0FA1_013D / 0xFB4D)
    Stack.Push16(UInt16[DS, (ushort)(SI + 0x311A)]);
    CheckExternalEvents(cs6, 0x144);
    // PUSH word ptr [BP + 0x6] (0FA1_0141 / 0xFB51)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs6, 0x145);
    // PUSH CS (0FA1_0144 / 0xFB54)
    Stack.Push16(cs6);
    CheckExternalEvents(cs6, 0x148);
    // CALL 0x0000:10bb (0FA1_0145 / 0xFB55)
    NearCall(cs6, 0x148, unknown_0FA1_16AB_110BB);
    CheckExternalEvents(cs6, 0x14B);
    // ADD SP,0x8 (0FA1_0148 / 0xFB58)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs6, 0x14D);
    // OR AX,AX (0FA1_014B / 0xFB5B)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs6, 0x14F);
    // JZ 0x0000:fb7f (0FA1_014D / 0xFB5D)
    if(ZeroFlag) {
      goto label_0FA1_016F_0FB7F;
    }
    CheckExternalEvents(cs6, 0x154);
    // MOV word ptr [BP + -0xc],0x0 (0FA1_014F / 0xFB5F)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    CheckExternalEvents(cs6, 0x157);
    // MOV AX,word ptr [BP + 0x8] (0FA1_0154 / 0xFB64)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs6, 0x15A);
    // CMP word ptr [BP + -0x2],AX (0FA1_0157 / 0xFB67)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs6, 0x15C);
    // JNZ 0x0000:fb7f (0FA1_015A / 0xFB6A)
    if(!ZeroFlag) {
      goto label_0FA1_016F_0FB7F;
    }
    CheckExternalEvents(cs6, 0x15F);
    // MOV AX,word ptr [BP + 0xa] (0FA1_015C / 0xFB6C)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs6, 0x162);
    // CMP word ptr [BP + -0x6],AX (0FA1_015F / 0xFB6F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], AX);
    CheckExternalEvents(cs6, 0x164);
    // JNZ 0x0000:fb7f (0FA1_0162 / 0xFB72)
    if(!ZeroFlag) {
      goto label_0FA1_016F_0FB7F;
    }
    CheckExternalEvents(cs6, 0x168);
    // MOV ES,word ptr [0x558c] (0FA1_0164 / 0xFB74)
    ES = UInt16[DS, 0x558C];
    CheckExternalEvents(cs6, 0x16F);
    // MOV word ptr ES:[0xd57e],0x1 (0FA1_0168 / 0xFB78)
    UInt16[ES, 0xD57E] = 0x1;
    label_0FA1_016F_0FB7F:
    CheckExternalEvents(cs6, 0x173);
    // MOV ES,word ptr [0x5582] (0FA1_016F / 0xFB7F)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs6, 0x176);
    // MOV AX,word ptr [BP + -0x1a] (0FA1_0173 / 0xFB83)
    AX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs6, 0x17A);
    // MOV ES:[0xa44b],AX (0FA1_0176 / 0xFB86)
    UInt16[ES, 0xA44B] = AX;
    CheckExternalEvents(cs6, 0x17E);
    // MOV ES,word ptr [0x5584] (0FA1_017A / 0xFB8A)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs6, 0x181);
    // MOV AX,word ptr [BP + -0x1c] (0FA1_017E / 0xFB8E)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs6, 0x185);
    // MOV ES:[0xa44d],AX (0FA1_0181 / 0xFB91)
    UInt16[ES, 0xA44D] = AX;
    label_0FA1_0185_0FB95:
    CheckExternalEvents(cs6, 0x189);
    // CMP word ptr [BP + -0xc],0x0 (0FA1_0185 / 0xFB95)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs6, 0x18B);
    // JZ 0x0000:fbe3 (0FA1_0189 / 0xFB99)
    if(ZeroFlag) {
      goto label_0FA1_01D3_0FBE3;
    }
    CheckExternalEvents(cs6, 0x18F);
    // MOV ES,word ptr [0x5580] (0FA1_018B / 0xFB9B)
    ES = UInt16[DS, 0x5580];
    CheckExternalEvents(cs6, 0x192);
    // MOV AX,word ptr [BP + -0x2] (0FA1_018F / 0xFB9F)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs6, 0x196);
    // MOV ES:[0xe486],AX (0FA1_0192 / 0xFBA2)
    UInt16[ES, 0xE486] = AX;
    CheckExternalEvents(cs6, 0x19A);
    // MOV ES,word ptr [0x557e] (0FA1_0196 / 0xFBA6)
    ES = UInt16[DS, 0x557E];
    CheckExternalEvents(cs6, 0x19D);
    // MOV AX,word ptr [BP + -0x6] (0FA1_019A / 0xFBAA)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs6, 0x1A1);
    // MOV ES:[0xe488],AX (0FA1_019D / 0xFBAD)
    UInt16[ES, 0xE488] = AX;
    CheckExternalEvents(cs6, 0x1A4);
    // MOV AL,byte ptr [BP + -0x10] (0FA1_01A1 / 0xFBB1)
    AL = UInt8[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs6, 0x1A7);
    // MOV BX,word ptr [BP + 0x6] (0FA1_01A4 / 0xFBB4)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs6, 0x1AA);
    // AND BX,0x7f (0FA1_01A7 / 0xFBB7)
    // BX &= 0x7F;
    BX = Alu16.And(BX, 0x7F);
    CheckExternalEvents(cs6, 0x1AE);
    // MOV ES,word ptr [0x5578] (0FA1_01AA / 0xFBBA)
    ES = UInt16[DS, 0x5578];
    CheckExternalEvents(cs6, 0x1B3);
    // MOV byte ptr ES:[BX + 0x3920],AL (0FA1_01AE / 0xFBBE)
    UInt8[ES, (ushort)(BX + 0x3920)] = AL;
    CheckExternalEvents(cs6, 0x1B6);
    // MOV SI,word ptr [BP + -0x10] (0FA1_01B3 / 0xFBC3)
    SI = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs6, 0x1B8);
    // SHL SI,0x1 (0FA1_01B6 / 0xFBC6)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs6, 0x1BC);
    // MOV ES,word ptr [0x557c] (0FA1_01B8 / 0xFBC8)
    ES = UInt16[DS, 0x557C];
    CheckExternalEvents(cs6, 0x1C0);
    // MOV AX,word ptr [SI + 0x311a] (0FA1_01BC / 0xFBCC)
    AX = UInt16[DS, (ushort)(SI + 0x311A)];
    CheckExternalEvents(cs6, 0x1C4);
    // MOV ES:[0x458e],AX (0FA1_01C0 / 0xFBD0)
    UInt16[ES, 0x458E] = AX;
    CheckExternalEvents(cs6, 0x1C8);
    // MOV ES,word ptr [0x557a] (0FA1_01C4 / 0xFBD4)
    ES = UInt16[DS, 0x557A];
    CheckExternalEvents(cs6, 0x1CC);
    // MOV AX,word ptr [SI + 0x312a] (0FA1_01C8 / 0xFBD8)
    AX = UInt16[DS, (ushort)(SI + 0x312A)];
    CheckExternalEvents(cs6, 0x1D0);
    // MOV ES:[0x4590],AX (0FA1_01CC / 0xFBDC)
    UInt16[ES, 0x4590] = AX;
    CheckExternalEvents(cs6, 0x1D3);
    // JMP 0x0000:fcee (0FA1_01D0 / 0xFBE0)
    goto label_0FA1_02DE_0FCEE;
    label_0FA1_01D3_0FBE3:
    CheckExternalEvents(cs6, 0x1D6);
    // DEC word ptr [BP + -0x14] (0FA1_01D3 / 0xFBE3)
    UInt16[SS, (ushort)(BP - 0x14)]--;
    label_0FA1_01D6_0FBE6:
    CheckExternalEvents(cs6, 0x1DA);
    // CMP word ptr [BP + -0x14],-0x1 (0FA1_01D6 / 0xFBE6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x14)], 0xFFFF);
    CheckExternalEvents(cs6, 0x1DC);
    // JG 0x0000:fbef (0FA1_01DA / 0xFBEA)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0FA1_01DF_0FBEF;
    }
    CheckExternalEvents(cs6, 0x1DF);
    // JMP 0x0000:fcee (0FA1_01DC / 0xFBEC)
    goto label_0FA1_02DE_0FCEE;
    label_0FA1_01DF_0FBEF:
    CheckExternalEvents(cs6, 0x1E2);
    // MOV DI,word ptr [BP + -0x14] (0FA1_01DF / 0xFBEF)
    DI = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs6, 0x1E6);
    // MOV BX,word ptr [0x315c] (0FA1_01E2 / 0xFBF2)
    BX = UInt16[DS, 0x315C];
    CheckExternalEvents(cs6, 0x1EA);
    // MOV AL,byte ptr [BX + DI + 0x310a] (0FA1_01E6 / 0xFBF6)
    AL = UInt8[DS, (ushort)(BX + DI + 0x310A)];
    CheckExternalEvents(cs6, 0x1EB);
    // CBW  (0FA1_01EA / 0xFBFA)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs6, 0x1EE);
    // ADD AX,word ptr [BP + -0x10] (0FA1_01EB / 0xFBFB)
    AX += UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs6, 0x1F1);
    // AND AX,0x7 (0FA1_01EE / 0xFBFE)
    // AX &= 0x7;
    AX = Alu16.And(AX, 0x7);
    CheckExternalEvents(cs6, 0x1F4);
    // MOV word ptr [BP + -0x10],AX (0FA1_01F1 / 0xFC01)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs6, 0x1F6);
    // MOV SI,AX (0FA1_01F4 / 0xFC04)
    SI = AX;
    CheckExternalEvents(cs6, 0x1F8);
    // SHL SI,0x1 (0FA1_01F6 / 0xFC06)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs6, 0x1FC);
    // MOV AX,word ptr [SI + 0x311a] (0FA1_01F8 / 0xFC08)
    AX = UInt16[DS, (ushort)(SI + 0x311A)];
    CheckExternalEvents(cs6, 0x200);
    // MOV ES,word ptr [0x5580] (0FA1_01FC / 0xFC0C)
    ES = UInt16[DS, 0x5580];
    CheckExternalEvents(cs6, 0x205);
    // ADD AX,word ptr ES:[0xe486] (0FA1_0200 / 0xFC10)
    // AX += UInt16[ES, 0xE486];
    AX = Alu16.Add(AX, UInt16[ES, 0xE486]);
    CheckExternalEvents(cs6, 0x208);
    // MOV word ptr [BP + -0x2],AX (0FA1_0205 / 0xFC15)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs6, 0x20C);
    // TEST byte ptr [BP + -0x2],0x80 (0FA1_0208 / 0xFC18)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x2)], 0x80);
    CheckExternalEvents(cs6, 0x20E);
    // JZ 0x0000:fc25 (0FA1_020C / 0xFC1C)
    if(ZeroFlag) {
      goto label_0FA1_0215_0FC25;
    }
    CheckExternalEvents(cs6, 0x212);
    // MOV AX,word ptr [SI + 0x313a] (0FA1_020E / 0xFC1E)
    AX = UInt16[DS, (ushort)(SI + 0x313A)];
    CheckExternalEvents(cs6, 0x215);
    // ADD word ptr [BP + -0x2],AX (0FA1_0212 / 0xFC22)
    // UInt16[SS, (ushort)(BP - 0x2)] += AX;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x2)], AX);
    label_0FA1_0215_0FC25:
    CheckExternalEvents(cs6, 0x218);
    // MOV SI,word ptr [BP + -0x10] (0FA1_0215 / 0xFC25)
    SI = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs6, 0x21A);
    // SHL SI,0x1 (0FA1_0218 / 0xFC28)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs6, 0x21E);
    // MOV AX,word ptr [SI + 0x312a] (0FA1_021A / 0xFC2A)
    AX = UInt16[DS, (ushort)(SI + 0x312A)];
    CheckExternalEvents(cs6, 0x222);
    // MOV ES,word ptr [0x557e] (0FA1_021E / 0xFC2E)
    ES = UInt16[DS, 0x557E];
    CheckExternalEvents(cs6, 0x227);
    // ADD AX,word ptr ES:[0xe488] (0FA1_0222 / 0xFC32)
    // AX += UInt16[ES, 0xE488];
    AX = Alu16.Add(AX, UInt16[ES, 0xE488]);
    CheckExternalEvents(cs6, 0x22A);
    // MOV word ptr [BP + -0x6],AX (0FA1_0227 / 0xFC37)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs6, 0x22E);
    // TEST byte ptr [BP + -0x6],0x80 (0FA1_022A / 0xFC3A)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x6)], 0x80);
    CheckExternalEvents(cs6, 0x230);
    // JZ 0x0000:fc47 (0FA1_022E / 0xFC3E)
    if(ZeroFlag) {
      goto label_0FA1_0237_0FC47;
    }
    CheckExternalEvents(cs6, 0x234);
    // MOV AX,word ptr [SI + 0x314a] (0FA1_0230 / 0xFC40)
    AX = UInt16[DS, (ushort)(SI + 0x314A)];
    CheckExternalEvents(cs6, 0x237);
    // ADD word ptr [BP + -0x6],AX (0FA1_0234 / 0xFC44)
    // UInt16[SS, (ushort)(BP - 0x6)] += AX;
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x6)], AX);
    label_0FA1_0237_0FC47:
    CheckExternalEvents(cs6, 0x23A);
    // MOV SI,word ptr [BP + -0x10] (0FA1_0237 / 0xFC47)
    SI = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs6, 0x23C);
    // SHL SI,0x1 (0FA1_023A / 0xFC4A)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs6, 0x240);
    // MOV AX,word ptr [SI + 0x311a] (0FA1_023C / 0xFC4C)
    AX = UInt16[DS, (ushort)(SI + 0x311A)];
    CheckExternalEvents(cs6, 0x243);
    // ADD AX,word ptr [BP + 0xc] (0FA1_0240 / 0xFC50)
    // AX += UInt16[SS, (ushort)(BP + 0xC)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0xC)]);
    CheckExternalEvents(cs6, 0x246);
    // MOV word ptr [BP + -0x8],AX (0FA1_0243 / 0xFC53)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs6, 0x24A);
    // MOV AX,word ptr [SI + 0x312a] (0FA1_0246 / 0xFC56)
    AX = UInt16[DS, (ushort)(SI + 0x312A)];
    CheckExternalEvents(cs6, 0x24D);
    // ADD AX,word ptr [BP + 0xe] (0FA1_024A / 0xFC5A)
    // AX += UInt16[SS, (ushort)(BP + 0xE)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0xE)]);
    CheckExternalEvents(cs6, 0x250);
    // MOV word ptr [BP + -0xa],AX (0FA1_024D / 0xFC5D)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs6, 0x252);
    // SAR AX,0x1 (0FA1_0250 / 0xFC60)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs6, 0x255);
    // MOV CX,0x18 (0FA1_0252 / 0xFC62)
    CX = 0x18;
    CheckExternalEvents(cs6, 0x257);
    // IMUL CX (0FA1_0255 / 0xFC65)
    int resImul0FA1_0255 = Alu16.Imul((short)AX, (short)CX);
    AX = (ushort)(resImul0FA1_0255);
    DX = (ushort)(resImul0FA1_0255 >> 16);
    CheckExternalEvents(cs6, 0x25A);
    // MOV CX,word ptr [BP + -0x8] (0FA1_0257 / 0xFC67)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs6, 0x25D);
    // SUB CX,0xd (0FA1_025A / 0xFC6A)
    CX -= 0xD;
    CheckExternalEvents(cs6, 0x25F);
    // SAR CX,0x1 (0FA1_025D / 0xFC6D)
    CX = Alu16.Sar(CX, 0x1);
    CheckExternalEvents(cs6, 0x261);
    // ADD AX,CX (0FA1_025F / 0xFC6F)
    // AX += CX;
    AX = Alu16.Add(AX, CX);
    CheckExternalEvents(cs6, 0x264);
    // MOV word ptr [BP + -0xe],AX (0FA1_0261 / 0xFC71)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs6, 0x268);
    // TEST byte ptr [BP + -0x8],0x1 (0FA1_0264 / 0xFC74)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs6, 0x26A);
    // JNZ 0x0000:fc89 (0FA1_0268 / 0xFC78)
    if(!ZeroFlag) {
      goto label_0FA1_0279_0FC89;
    }
    CheckExternalEvents(cs6, 0x26E);
    // MOV ES,word ptr [0x5582] (0FA1_026A / 0xFC7A)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs6, 0x274);
    // TEST byte ptr ES:[0xa44b],0x1 (0FA1_026E / 0xFC7E)
    Alu8.And(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs6, 0x276);
    // JZ 0x0000:fc89 (0FA1_0274 / 0xFC84)
    if(ZeroFlag) {
      goto label_0FA1_0279_0FC89;
    }
    CheckExternalEvents(cs6, 0x279);
    // INC word ptr [BP + -0xe] (0FA1_0276 / 0xFC86)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0FA1_0279_0FC89:
    CheckExternalEvents(cs6, 0x27D);
    // TEST byte ptr [BP + -0xa],0x1 (0FA1_0279 / 0xFC89)
    Alu8.And(UInt8[SS, (ushort)(BP - 0xA)], 0x1);
    CheckExternalEvents(cs6, 0x27F);
    // JZ 0x0000:fc9f (0FA1_027D / 0xFC8D)
    if(ZeroFlag) {
      goto label_0FA1_028F_0FC9F;
    }
    CheckExternalEvents(cs6, 0x283);
    // MOV ES,word ptr [0x5584] (0FA1_027F / 0xFC8F)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs6, 0x289);
    // TEST byte ptr ES:[0xa44d],0x1 (0FA1_0283 / 0xFC93)
    Alu8.And(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs6, 0x28B);
    // JZ 0x0000:fc9f (0FA1_0289 / 0xFC99)
    if(ZeroFlag) {
      goto label_0FA1_028F_0FC9F;
    }
    CheckExternalEvents(cs6, 0x28F);
    // ADD word ptr [BP + -0xe],0x18 (0FA1_028B / 0xFC9B)
    // UInt16[SS, (ushort)(BP - 0xE)] += 0x18;
    UInt16[SS, (ushort)(BP - 0xE)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xE)], 0x18);
    label_0FA1_028F_0FC9F:
    CheckExternalEvents(cs6, 0x293);
    // MOV ES,word ptr [0x5586] (0FA1_028F / 0xFC9F)
    ES = UInt16[DS, 0x5586];
    CheckExternalEvents(cs6, 0x298);
    // MOV BX,word ptr ES:[0x9ed] (0FA1_0293 / 0xFCA3)
    BX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs6, 0x29B);
    // ADD BX,word ptr [BP + -0xe] (0FA1_0298 / 0xFCA8)
    // BX += UInt16[SS, (ushort)(BP - 0xE)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs6, 0x29F);
    // MOV ES,word ptr [0x5588] (0FA1_029B / 0xFCAB)
    ES = UInt16[DS, 0x5588];
    CheckExternalEvents(cs6, 0x2A4);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0FA1_029F / 0xFCAF)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs6, 0x2A6);
    // SUB AH,AH (0FA1_02A4 / 0xFCB4)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs6, 0x2A9);
    // MOV word ptr [BP + -0x12],AX (0FA1_02A6 / 0xFCB6)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs6, 0x2AD);
    // MOV ES,word ptr [0x558a] (0FA1_02A9 / 0xFCB9)
    ES = UInt16[DS, 0x558A];
    CheckExternalEvents(cs6, 0x2B2);
    // CMP word ptr ES:[0x150],AX (0FA1_02AD / 0xFCBD)
    Alu16.Sub(UInt16[ES, 0x150], AX);
    CheckExternalEvents(cs6, 0x2B4);
    // JG 0x0000:fcc7 (0FA1_02B2 / 0xFCC2)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0FA1_02B7_0FCC7;
    }
    CheckExternalEvents(cs6, 0x2B7);
    // JMP 0x0000:fbe3 (0FA1_02B4 / 0xFCC4)
    goto label_0FA1_01D3_0FBE3;
    label_0FA1_02B7_0FCC7:
    CheckExternalEvents(cs6, 0x2BC);
    // MOV word ptr [BP + -0xc],0x1 (0FA1_02B7 / 0xFCC7)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x1;
    CheckExternalEvents(cs6, 0x2C0);
    // CMP word ptr [BP + -0x18],0x0 (0FA1_02BC / 0xFCCC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x0);
    CheckExternalEvents(cs6, 0x2C2);
    // JNZ 0x0000:fcd5 (0FA1_02C0 / 0xFCD0)
    if(!ZeroFlag) {
      goto label_0FA1_02C5_0FCD5;
    }
    CheckExternalEvents(cs6, 0x2C5);
    // JMP 0x0000:fb02 (0FA1_02C2 / 0xFCD2)
    goto label_0FA1_00F2_0FB02;
    label_0FA1_02C5_0FCD5:
    CheckExternalEvents(cs6, 0x2C8);
    // MOV AL,byte ptr [BP + -0x8] (0FA1_02C5 / 0xFCD5)
    AL = UInt8[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs6, 0x2CC);
    // MOV ES,word ptr [0x5582] (0FA1_02C8 / 0xFCD8)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs6, 0x2D1);
    // XOR AL,byte ptr ES:[0xa44b] (0FA1_02CC / 0xFCDC)
    AL ^= UInt8[ES, 0xA44B];
    CheckExternalEvents(cs6, 0x2D3);
    // TEST AL,0x1 (0FA1_02D1 / 0xFCE1)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs6, 0x2D5);
    // JNZ 0x0000:fce8 (0FA1_02D3 / 0xFCE3)
    if(!ZeroFlag) {
      goto label_0FA1_02D8_0FCE8;
    }
    CheckExternalEvents(cs6, 0x2D8);
    // JMP 0x0000:fad8 (0FA1_02D5 / 0xFCE5)
    goto label_0FA1_00C8_0FAD8;
    label_0FA1_02D8_0FCE8:
    CheckExternalEvents(cs6, 0x2DB);
    // DEC word ptr [BP + -0xe] (0FA1_02D8 / 0xFCE8)
    UInt16[SS, (ushort)(BP - 0xE)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs6, 0x2DE);
    // JMP 0x0000:fadb (0FA1_02DB / 0xFCEB)
    goto label_0FA1_00CB_0FADB;
    label_0FA1_02DE_0FCEE:
    CheckExternalEvents(cs6, 0x2DF);
    // POP SI (0FA1_02DE / 0xFCEE)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs6, 0x2E0);
    // POP DI (0FA1_02DF / 0xFCEF)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs6, 0x2E2);
    // MOV SP,BP (0FA1_02E0 / 0xFCF0)
    SP = BP;
    CheckExternalEvents(cs6, 0x2E3);
    // POP BP (0FA1_02E2 / 0xFCF2)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs6, 0x2E4);
    // RETF  (0FA1_02E3 / 0xFCF3)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_FCF4_0FCF4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_FCF4_0FCF4:
    CheckExternalEvents(cs1, 0xFCF5);
    // PUSH BP (0000_FCF4 / 0xFCF4)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xFCF7);
    // MOV BP,SP (0000_FCF5 / 0xFCF5)
    BP = SP;
    CheckExternalEvents(cs1, 0xFCFA);
    // MOV AX,0x4 (0000_FCF7 / 0xFCF7)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xFCFF);
    // CALLF 0x1000:cecc (0000_FCFA / 0xFCFA)
    FarCall(cs1, 0xFCFF, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xFD00);
    // PUSH SI (0000_FCFF / 0xFCFF)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xFD03);
    // MOV AX,0x11 (0000_FD00 / 0xFD00)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xFD06);
    // IMUL word ptr [BP + 0x6] (0000_FD03 / 0xFD03)
    int resImul0000_FD03 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_FD03);
    DX = (ushort)(resImul0000_FD03 >> 16);
    CheckExternalEvents(cs1, 0xFD08);
    // MOV SI,AX (0000_FD06 / 0xFD06)
    SI = AX;
    CheckExternalEvents(cs1, 0xFD0C);
    // MOV ES,word ptr [0x558e] (0000_FD08 / 0xFD08)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs1, 0xFD11);
    // MOV AL,byte ptr ES:[SI + 0xc615] (0000_FD0C / 0xFD0C)
    AL = UInt8[ES, (ushort)(SI + 0xC615)];
    CheckExternalEvents(cs1, 0xFD12);
    // CBW  (0000_FD11 / 0xFD11)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xFD15);
    // MOV word ptr [BP + -0x4],AX (0000_FD12 / 0xFD12)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0xFD1A);
    // MOV AL,byte ptr ES:[SI + 0xc623] (0000_FD15 / 0xFD15)
    AL = UInt8[ES, (ushort)(SI + 0xC623)];
    CheckExternalEvents(cs1, 0xFD1B);
    // CBW  (0000_FD1A / 0xFD1A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xFD1E);
    // MOV word ptr [BP + -0x2],AX (0000_FD1B / 0xFD1B)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xFD1F);
    // CWD  (0000_FD1E / 0xFD1E)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0xFD22);
    // MOV CX,word ptr [BP + -0x4] (0000_FD1F / 0xFD1F)
    CX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xFD24);
    // IDIV CX (0000_FD22 / 0xFD22)
    int op1IDiv0000_FD22 = (int)(DX << 16 | AX);
    short op2IDiv0000_FD22 = (short)CX;
    short? resIDiv0000_FD22 = Alu16.Idiv(op1IDiv0000_FD22, op2IDiv0000_FD22);
    if(resIDiv0000_FD22 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIDiv0000_FD22.Value;
    DX = (ushort)(op1IDiv0000_FD22 % op2IDiv0000_FD22);
    CheckExternalEvents(cs1, 0xFD26);
    // MOV BX,AX (0000_FD24 / 0xFD24)
    BX = AX;
    CheckExternalEvents(cs1, 0xFD28);
    // SHL BX,0x1 (0000_FD26 / 0xFD26)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xFD2A);
    // SHL BX,0x1 (0000_FD28 / 0xFD28)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xFD2E);
    // PUSH word ptr [BX + 0x2e0e] (0000_FD2A / 0xFD2A)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x2E0E)]);
    CheckExternalEvents(cs1, 0xFD32);
    // PUSH word ptr [BX + 0x2e0c] (0000_FD2E / 0xFD2E)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x2E0C)]);
    CheckExternalEvents(cs1, 0xFD37);
    // CALLF 0x1000:8055 (0000_FD32 / 0xFD32)
    FarCall(cs1, 0xFD37, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xFD3A);
    // ADD SP,0x4 (0000_FD37 / 0xFD37)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xFD3B);
    // POP SI (0000_FD3A / 0xFD3A)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xFD3D);
    // MOV SP,BP (0000_FD3B / 0xFD3B)
    SP = BP;
    CheckExternalEvents(cs1, 0xFD3E);
    // POP BP (0000_FD3D / 0xFD3D)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xFD3F);
    // RETF  (0000_FD3E / 0xFD3E)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_FD3F_0FD3F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_FD3F_0FD3F:
    CheckExternalEvents(cs1, 0xFD40);
    // PUSH BP (0000_FD3F / 0xFD3F)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xFD42);
    // MOV BP,SP (0000_FD40 / 0xFD40)
    BP = SP;
    CheckExternalEvents(cs1, 0xFD44);
    // XOR AX,AX (0000_FD42 / 0xFD42)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs1, 0xFD49);
    // CALLF 0x1000:cecc (0000_FD44 / 0xFD44)
    FarCall(cs1, 0xFD49, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xFD4D);
    // MOV ES,word ptr [0x5584] (0000_FD49 / 0xFD49)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs1, 0xFD52);
    // PUSH word ptr ES:[0xa44d] (0000_FD4D / 0xFD4D)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0xFD56);
    // MOV ES,word ptr [0x5582] (0000_FD52 / 0xFD52)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs1, 0xFD5B);
    // PUSH word ptr ES:[0xa44b] (0000_FD56 / 0xFD56)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xFD60);
    // CALLF 0x1000:b204 (0000_FD5B / 0xFD5B)
    FarCall(cs1, 0xFD60, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0xFD63);
    // ADD SP,0x4 (0000_FD60 / 0xFD60)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xFD68);
    // CALLF 0x1000:b7df (0000_FD63 / 0xFD63)
    FarCall(cs1, 0xFD68, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0xFD6C);
    // CMP word ptr [BP + 0x6],0x0 (0000_FD68 / 0xFD68)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xFD6E);
    // JZ 0x0000:fd75 (0000_FD6C / 0xFD6C)
    if(ZeroFlag) {
      goto label_0000_FD75_0FD75;
    }
    CheckExternalEvents(cs1, 0xFD73);
    // CALLF 0x0000:254b (0000_FD6E / 0xFD6E)
    FarCall(cs1, 0xFD73, ghidra_guess_0000_254B_0254B);
    CheckExternalEvents(cs1, 0xFD75);
    // JMP 0x0000:fd7a (0000_FD73 / 0xFD73)
    goto label_0000_FD7A_0FD7A;
    label_0000_FD75_0FD75:
    CheckExternalEvents(cs1, 0xFD7A);
    // CALLF 0x0000:1c1b (0000_FD75 / 0xFD75)
    FarCall(cs1, 0xFD7A, unknown_0170_051B_01C1B);
    label_0000_FD7A_0FD7A:
    CheckExternalEvents(cs1, 0xFD7F);
    // CALLF 0x1000:9193 (0000_FD7A / 0xFD7A)
    FarCall(cs1, 0xFD7F, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0xFD82);
    // MOV AX,0x4 (0000_FD7F / 0xFD7F)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xFD83);
    // PUSH AX (0000_FD82 / 0xFD82)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xFD88);
    // CALLF 0x1000:7ee1 (0000_FD83 / 0xFD83)
    FarCall(cs1, 0xFD88, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xFD8B);
    // ADD SP,0x2 (0000_FD88 / 0xFD88)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xFD90);
    // CALLF 0x1000:7fe8 (0000_FD8B / 0xFD8B)
    FarCall(cs1, 0xFD90, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xFD93);
    // MOV AX,0x4 (0000_FD90 / 0xFD90)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xFD94);
    // PUSH AX (0000_FD93 / 0xFD93)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xFD99);
    // CALLF 0x1000:7c64 (0000_FD94 / 0xFD94)
    FarCall(cs1, 0xFD99, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xFD9C);
    // ADD SP,0x2 (0000_FD99 / 0xFD99)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xFD9F);
    // MOV AX,0x3 (0000_FD9C / 0xFD9C)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xFDA0);
    // PUSH AX (0000_FD9F / 0xFD9F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xFDA5);
    // CALLF 0x1000:7ee1 (0000_FDA0 / 0xFDA0)
    FarCall(cs1, 0xFDA5, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xFDA8);
    // ADD SP,0x2 (0000_FDA5 / 0xFDA5)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xFDAD);
    // CALLF 0x1000:7fe8 (0000_FDA8 / 0xFDA8)
    FarCall(cs1, 0xFDAD, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xFDB0);
    // MOV AX,0x3 (0000_FDAD / 0xFDAD)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xFDB1);
    // PUSH AX (0000_FDB0 / 0xFDB0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xFDB6);
    // CALLF 0x1000:7c64 (0000_FDB1 / 0xFDB1)
    FarCall(cs1, 0xFDB6, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xFDB9);
    // ADD SP,0x2 (0000_FDB6 / 0xFDB6)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xFDBA);
    // POP BP (0000_FDB9 / 0xFDB9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xFDBB);
    // RETF  (0000_FDBA / 0xFDBA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_05C5_105C5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_05C5_105C5:
    CheckExternalEvents(cs7, 0x5C6);
    // PUSH BP (1000_05C5 / 0x105C5)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x5C8);
    // MOV BP,SP (1000_05C6 / 0x105C6)
    BP = SP;
    CheckExternalEvents(cs7, 0x5CB);
    // MOV AX,0xa (1000_05C8 / 0x105C8)
    AX = 0xA;
    CheckExternalEvents(cs7, 0x5D0);
    // CALLF 0x1000:cecc (1000_05CB / 0x105CB)
    FarCall(cs7, 0x5D0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x5D3);
    // MOV AX,word ptr [BP + 0x6] (1000_05D0 / 0x105D0)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x5D6);
    // AND AX,0xf00 (1000_05D3 / 0x105D3)
    AX &= 0xF00;
    CheckExternalEvents(cs7, 0x5D8);
    // SHR AX,0x1 (1000_05D6 / 0x105D6)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs7, 0x5DB);
    // MOV CX,word ptr [BP + 0x6] (1000_05D8 / 0x105D8)
    CX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x5DE);
    // AND CX,0x7f (1000_05DB / 0x105DB)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x5E0);
    // OR AX,CX (1000_05DE / 0x105DE)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x5E3);
    // MOV word ptr [BP + 0x6],AX (1000_05E0 / 0x105E0)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs7, 0x5E6);
    // MOV AX,word ptr [BP + 0x8] (1000_05E3 / 0x105E3)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x5E9);
    // AND AX,0xf000 (1000_05E6 / 0x105E6)
    // AX &= 0xF000;
    AX = Alu16.And(AX, 0xF000);
    CheckExternalEvents(cs7, 0x5EB);
    // MOV CL,0x5 (1000_05E9 / 0x105E9)
    CL = 0x5;
    CheckExternalEvents(cs7, 0x5ED);
    // SHR AX,CL (1000_05EB / 0x105EB)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs7, 0x5F0);
    // MOV CX,word ptr [BP + 0x8] (1000_05ED / 0x105ED)
    CX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0x5F3);
    // AND CX,0x7f (1000_05F0 / 0x105F0)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x5F5);
    // OR AX,CX (1000_05F3 / 0x105F3)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x5F8);
    // MOV word ptr [BP + 0x8],AX (1000_05F5 / 0x105F5)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs7, 0x5FC);
    // MOV ES,word ptr [0x5582] (1000_05F8 / 0x105F8)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x600);
    // MOV AX,ES:[0xa44b] (1000_05FC / 0x105FC)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x603);
    // AND AX,0xf00 (1000_0600 / 0x10600)
    AX &= 0xF00;
    CheckExternalEvents(cs7, 0x605);
    // SHR AX,0x1 (1000_0603 / 0x10603)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs7, 0x60A);
    // MOV CX,word ptr ES:[0xa44b] (1000_0605 / 0x10605)
    CX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs7, 0x60D);
    // AND CX,0x7f (1000_060A / 0x1060A)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x60F);
    // OR AX,CX (1000_060D / 0x1060D)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x612);
    // MOV word ptr [BP + -0x2],AX (1000_060F / 0x1060F)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x616);
    // MOV ES,word ptr [0x5584] (1000_0612 / 0x10612)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x61A);
    // MOV AX,ES:[0xa44d] (1000_0616 / 0x10616)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x61D);
    // AND AX,0xf000 (1000_061A / 0x1061A)
    // AX &= 0xF000;
    AX = Alu16.And(AX, 0xF000);
    CheckExternalEvents(cs7, 0x61F);
    // MOV CL,0x5 (1000_061D / 0x1061D)
    CL = 0x5;
    CheckExternalEvents(cs7, 0x621);
    // SHR AX,CL (1000_061F / 0x1061F)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs7, 0x626);
    // MOV CX,word ptr ES:[0xa44d] (1000_0621 / 0x10621)
    CX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs7, 0x629);
    // AND CX,0x7f (1000_0626 / 0x10626)
    // CX &= 0x7F;
    CX = Alu16.And(CX, 0x7F);
    CheckExternalEvents(cs7, 0x62B);
    // OR AX,CX (1000_0629 / 0x10629)
    // AX |= CX;
    AX = Alu16.Or(AX, CX);
    CheckExternalEvents(cs7, 0x62E);
    // MOV word ptr [BP + -0x6],AX (1000_062B / 0x1062B)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x631);
    // MOV AX,word ptr [BP + -0x2] (1000_062E / 0x1062E)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0x634);
    // SUB AX,word ptr [BP + 0x6] (1000_0631 / 0x10631)
    // AX -= UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0x637);
    // MOV word ptr [BP + -0x8],AX (1000_0634 / 0x10634)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x639);
    // OR AX,AX (1000_0637 / 0x10637)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x63B);
    // JGE 0x1000:0640 (1000_0639 / 0x10639)
    if(SignFlag == OverflowFlag) {
      goto label_1000_0640_10640;
    }
    CheckExternalEvents(cs7, 0x63D);
    // NEG AX (1000_063B / 0x1063B)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs7, 0x640);
    // MOV word ptr [BP + -0x8],AX (1000_063D / 0x1063D)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    label_1000_0640_10640:
    CheckExternalEvents(cs7, 0x643);
    // MOV AX,word ptr [BP + -0x6] (1000_0640 / 0x10640)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0x646);
    // SUB AX,word ptr [BP + 0x8] (1000_0643 / 0x10643)
    // AX -= UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs7, 0x649);
    // MOV word ptr [BP + -0xa],AX (1000_0646 / 0x10646)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x64B);
    // OR AX,AX (1000_0649 / 0x10649)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs7, 0x64D);
    // JGE 0x1000:0652 (1000_064B / 0x1064B)
    if(SignFlag == OverflowFlag) {
      goto label_1000_0652_10652;
    }
    CheckExternalEvents(cs7, 0x64F);
    // NEG AX (1000_064D / 0x1064D)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs7, 0x652);
    // MOV word ptr [BP + -0xa],AX (1000_064F / 0x1064F)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_1000_0652_10652:
    CheckExternalEvents(cs7, 0x655);
    // MOV AX,word ptr [BP + -0xa] (1000_0652 / 0x10652)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x658);
    // CMP word ptr [BP + -0x8],AX (1000_0655 / 0x10655)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs7, 0x65A);
    // JLE 0x1000:0664 (1000_0658 / 0x10658)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_0664_10664;
    }
    CheckExternalEvents(cs7, 0x65D);
    // MOV AX,word ptr [BP + -0x8] (1000_065A / 0x1065A)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x65F);
    // SAR AX,0x1 (1000_065D / 0x1065D)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x662);
    // ADD AX,word ptr [BP + -0xa] (1000_065F / 0x1065F)
    // AX += UInt16[SS, (ushort)(BP - 0xA)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x664);
    // JMP 0x1000:066c (1000_0662 / 0x10662)
    goto label_1000_066C_1066C;
    label_1000_0664_10664:
    CheckExternalEvents(cs7, 0x667);
    // MOV AX,word ptr [BP + -0xa] (1000_0664 / 0x10664)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x669);
    // SAR AX,0x1 (1000_0667 / 0x10667)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0x66C);
    // ADD AX,word ptr [BP + -0x8] (1000_0669 / 0x10669)
    // AX += UInt16[SS, (ushort)(BP - 0x8)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    label_1000_066C_1066C:
    CheckExternalEvents(cs7, 0x66F);
    // MOV word ptr [BP + -0x4],AX (1000_066C / 0x1066C)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x671);
    // MOV SP,BP (1000_066F / 0x1066F)
    SP = BP;
    CheckExternalEvents(cs7, 0x672);
    // POP BP (1000_0671 / 0x10671)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x673);
    // RETF  (1000_0672 / 0x10672)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_0673_10673(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0673_10673:
    CheckExternalEvents(cs7, 0x674);
    // PUSH BP (1000_0673 / 0x10673)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x676);
    // MOV BP,SP (1000_0674 / 0x10674)
    BP = SP;
    CheckExternalEvents(cs7, 0x679);
    // MOV AX,0x10 (1000_0676 / 0x10676)
    AX = 0x10;
    CheckExternalEvents(cs7, 0x67E);
    // CALLF 0x1000:cecc (1000_0679 / 0x10679)
    FarCall(cs7, 0x67E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x67F);
    // PUSH SI (1000_067E / 0x1067E)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x684);
    // MOV word ptr [BP + -0x8],0x0 (1000_067F / 0x1067F)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs7, 0x686);
    // JMP 0x1000:06d3 (1000_0684 / 0x10684)
    goto label_1000_06D3_106D3;
    label_1000_0686_10686:
    CheckExternalEvents(cs7, 0x689);
    // INC word ptr [BP + -0xa] (1000_0686 / 0x10686)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    label_1000_0689_10689:
    CheckExternalEvents(cs7, 0x68D);
    // CMP word ptr [BP + -0xa],0xc (1000_0689 / 0x10689)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0xC);
    CheckExternalEvents(cs7, 0x68F);
    // JGE 0x1000:06d0 (1000_068D / 0x1068D)
    if(SignFlag == OverflowFlag) {
      goto label_1000_06D0_106D0;
    }
    CheckExternalEvents(cs7, 0x692);
    // MOV AX,0xc (1000_068F / 0x1068F)
    AX = 0xC;
    CheckExternalEvents(cs7, 0x695);
    // IMUL word ptr [BP + -0x8] (1000_0692 / 0x10692)
    int resImul1000_0692 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x8)]);
    AX = (ushort)(resImul1000_0692);
    DX = (ushort)(resImul1000_0692 >> 16);
    CheckExternalEvents(cs7, 0x698);
    // ADD AX,word ptr [BP + -0xa] (1000_0695 / 0x10695)
    AX += UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x69B);
    // ADD AX,0x3800 (1000_0698 / 0x10698)
    // AX += 0x3800;
    AX = Alu16.Add(AX, 0x3800);
    CheckExternalEvents(cs7, 0x69E);
    // MOV word ptr [BP + -0x10],AX (1000_069B / 0x1069B)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs7, 0x6A3);
    // MOV word ptr [BP + -0xe],0x2a02 (1000_069E / 0x1069E)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x2A02;
    CheckExternalEvents(cs7, 0x6A6);
    // LES BX,[BP + -0x10] (1000_06A3 / 0x106A3)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs7, 0x6AA);
    // CMP byte ptr ES:[BX],0xff (1000_06A6 / 0x106A6)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0xFF);
    CheckExternalEvents(cs7, 0x6AC);
    // JZ 0x1000:0686 (1000_06AA / 0x106AA)
    if(ZeroFlag) {
      goto label_1000_0686_10686;
    }
    CheckExternalEvents(cs7, 0x6B0);
    // AND byte ptr ES:[BX],0x7f (1000_06AC / 0x106AC)
    // UInt8[ES, (ushort)(BX)] &= 0x7F;
    UInt8[ES, (ushort)(BX)] = Alu8.And(UInt8[ES, (ushort)(BX)], 0x7F);
    CheckExternalEvents(cs7, 0x6B3);
    // LES BX,[BP + -0x10] (1000_06B0 / 0x106B0)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs7, 0x6B6);
    // MOV AL,byte ptr ES:[BX] (1000_06B3 / 0x106B3)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs7, 0x6B7);
    // CBW  (1000_06B6 / 0x106B6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x6B9);
    // MOV BX,AX (1000_06B7 / 0x106B7)
    BX = AX;
    CheckExternalEvents(cs7, 0x6BB);
    // SHL BX,0x1 (1000_06B9 / 0x106B9)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs7, 0x6BF);
    // MOV ES,word ptr [0x559a] (1000_06BB / 0x106BB)
    ES = UInt16[DS, 0x559A];
    CheckExternalEvents(cs7, 0x6C5);
    // CMP word ptr ES:[BX + 0x406a],0x0 (1000_06BF / 0x106BF)
    Alu16.Sub(UInt16[ES, (ushort)(BX + 0x406A)], 0x0);
    CheckExternalEvents(cs7, 0x6C7);
    // JNZ 0x1000:0686 (1000_06C5 / 0x106C5)
    if(!ZeroFlag) {
      goto label_1000_0686_10686;
    }
    CheckExternalEvents(cs7, 0x6CA);
    // LES BX,[BP + -0x10] (1000_06C7 / 0x106C7)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs7, 0x6CE);
    // MOV byte ptr ES:[BX],0xff (1000_06CA / 0x106CA)
    UInt8[ES, (ushort)(BX)] = 0xFF;
    CheckExternalEvents(cs7, 0x6D0);
    // JMP 0x1000:0686 (1000_06CE / 0x106CE)
    goto label_1000_0686_10686;
    label_1000_06D0_106D0:
    CheckExternalEvents(cs7, 0x6D3);
    // INC word ptr [BP + -0x8] (1000_06D0 / 0x106D0)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    label_1000_06D3_106D3:
    CheckExternalEvents(cs7, 0x6D7);
    // CMP word ptr [BP + -0x8],0x18 (1000_06D3 / 0x106D3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x18);
    CheckExternalEvents(cs7, 0x6D9);
    // JGE 0x1000:06e0 (1000_06D7 / 0x106D7)
    if(SignFlag == OverflowFlag) {
      goto label_1000_06E0_106E0;
    }
    CheckExternalEvents(cs7, 0x6DE);
    // MOV word ptr [BP + -0xa],0x0 (1000_06D9 / 0x106D9)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs7, 0x6E0);
    // JMP 0x1000:0689 (1000_06DE / 0x106DE)
    goto label_1000_0689_10689;
    label_1000_06E0_106E0:
    CheckExternalEvents(cs7, 0x6E5);
    // MOV word ptr [BP + -0x8],0x0 (1000_06E0 / 0x106E0)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs7, 0x6E8);
    // JMP 0x1000:08a7 (1000_06E5 / 0x106E5)
    goto label_1000_08A7_108A7;
    label_1000_06E8_106E8:
    CheckExternalEvents(cs7, 0x6EC);
    // ADD word ptr [BP + -0xa],0x4 (1000_06E8 / 0x106E8)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x4;
    label_1000_06EC_106EC:
    CheckExternalEvents(cs7, 0x6F0);
    // CMP word ptr [BP + -0xa],0x5 (1000_06EC / 0x106EC)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x5);
    CheckExternalEvents(cs7, 0x6F2);
    // JL 0x1000:06f5 (1000_06F0 / 0x106F0)
    if(SignFlag != OverflowFlag) {
      goto label_1000_06F5_106F5;
    }
    CheckExternalEvents(cs7, 0x6F5);
    // JMP 0x1000:08a4 (1000_06F2 / 0x106F2)
    goto label_1000_08A4_108A4;
    label_1000_06F5_106F5:
    CheckExternalEvents(cs7, 0x6F8);
    // MOV AX,word ptr [BP + -0x8] (1000_06F5 / 0x106F5)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x6FB);
    // ADD AX,word ptr [BP + -0xa] (1000_06F8 / 0x106F8)
    // AX += UInt16[SS, (ushort)(BP - 0xA)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x6FE);
    // MOV CX,0x7d (1000_06FB / 0x106FB)
    CX = 0x7D;
    CheckExternalEvents(cs7, 0x700);
    // IMUL CX (1000_06FE / 0x106FE)
    int resImul1000_06FE = Alu16.Imul((short)AX, (short)CX);
    AX = (ushort)(resImul1000_06FE);
    DX = (ushort)(resImul1000_06FE >> 16);
    CheckExternalEvents(cs7, 0x702);
    // MOV BX,AX (1000_0700 / 0x10700)
    BX = AX;
    CheckExternalEvents(cs7, 0x706);
    // MOV ES,word ptr [0x558e] (1000_0702 / 0x10702)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x70C);
    // CMP byte ptr ES:[BX + 0xc724],0xff (1000_0706 / 0x10706)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs7, 0x70E);
    // JNZ 0x1000:0711 (1000_070C / 0x1070C)
    if(!ZeroFlag) {
      goto label_1000_0711_10711;
    }
    CheckExternalEvents(cs7, 0x711);
    // JMP 0x1000:0891 (1000_070E / 0x1070E)
    goto label_1000_0891_10891;
    label_1000_0711_10711:
    CheckExternalEvents(cs7, 0x714);
    // MOV AX,0x30 (1000_0711 / 0x10711)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x717);
    // IMUL word ptr [BP + -0x8] (1000_0714 / 0x10714)
    int resImul1000_0714 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x8)]);
    AX = (ushort)(resImul1000_0714);
    DX = (ushort)(resImul1000_0714 >> 16);
    CheckExternalEvents(cs7, 0x719);
    // MOV BX,AX (1000_0717 / 0x10717)
    BX = AX;
    CheckExternalEvents(cs7, 0x71D);
    // MOV ES,word ptr [0x5594] (1000_0719 / 0x10719)
    ES = UInt16[DS, 0x5594];
    CheckExternalEvents(cs7, 0x722);
    // MOV AL,byte ptr ES:[BX + 0x32c6] (1000_071D / 0x1071D)
    AL = UInt8[ES, (ushort)(BX + 0x32C6)];
    CheckExternalEvents(cs7, 0x723);
    // CBW  (1000_0722 / 0x10722)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x724);
    // INC AX (1000_0723 / 0x10723)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0x727);
    // MOV word ptr [BP + -0x4],AX (1000_0724 / 0x10724)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x72A);
    // CMP AX,0x3 (1000_0727 / 0x10727)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs7, 0x72C);
    // JNZ 0x1000:0740 (1000_072A / 0x1072A)
    if(!ZeroFlag) {
      goto label_1000_0740_10740;
    }
    CheckExternalEvents(cs7, 0x72F);
    // MOV BX,word ptr [BP + -0x8] (1000_072C / 0x1072C)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x732);
    // LES SI,[BP + 0x6] (1000_072F / 0x1072F)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs7, 0x735);
    // MOV AL,byte ptr ES:[BX + SI] (1000_0732 / 0x10732)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs7, 0x738);
    // MOV byte ptr [BP + -0x10],AL (1000_0735 / 0x10735)
    UInt8[SS, (ushort)(BP - 0x10)] = AL;
    CheckExternalEvents(cs7, 0x73A);
    // CMP AL,0x3 (1000_0738 / 0x10738)
    Alu8.Sub(AL, 0x3);
    CheckExternalEvents(cs7, 0x73C);
    // JLE 0x1000:0740 (1000_073A / 0x1073A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_0740_10740;
    }
    CheckExternalEvents(cs7, 0x73D);
    // CBW  (1000_073C / 0x1073C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x740);
    // MOV word ptr [BP + -0x4],AX (1000_073D / 0x1073D)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    label_1000_0740_10740:
    CheckExternalEvents(cs7, 0x744);
    // CMP word ptr [BP + -0xa],0x0 (1000_0740 / 0x10740)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs7, 0x746);
    // JZ 0x1000:0776 (1000_0744 / 0x10744)
    if(ZeroFlag) {
      goto label_1000_0776_10776;
    }
    CheckExternalEvents(cs7, 0x749);
    // MOV AX,0x30 (1000_0746 / 0x10746)
    AX = 0x30;
    CheckExternalEvents(cs7, 0x74C);
    // IMUL word ptr [BP + -0x8] (1000_0749 / 0x10749)
    int resImul1000_0749 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x8)]);
    AX = (ushort)(resImul1000_0749);
    DX = (ushort)(resImul1000_0749 >> 16);
    CheckExternalEvents(cs7, 0x74E);
    // MOV BX,AX (1000_074C / 0x1074C)
    BX = AX;
    CheckExternalEvents(cs7, 0x752);
    // MOV ES,word ptr [0x5594] (1000_074E / 0x1074E)
    ES = UInt16[DS, 0x5594];
    CheckExternalEvents(cs7, 0x757);
    // MOV AL,byte ptr ES:[BX + 0x3506] (1000_0752 / 0x10752)
    AL = UInt8[ES, (ushort)(BX + 0x3506)];
    CheckExternalEvents(cs7, 0x758);
    // CBW  (1000_0757 / 0x10757)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x759);
    // INC AX (1000_0758 / 0x10758)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0x75C);
    // MOV word ptr [BP + -0x4],AX (1000_0759 / 0x10759)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0x75F);
    // CMP AX,0x3 (1000_075C / 0x1075C)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs7, 0x761);
    // JNZ 0x1000:0776 (1000_075F / 0x1075F)
    if(!ZeroFlag) {
      goto label_1000_0776_10776;
    }
    CheckExternalEvents(cs7, 0x764);
    // MOV SI,word ptr [BP + -0x8] (1000_0761 / 0x10761)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x767);
    // LES BX,[BP + 0x6] (1000_0764 / 0x10764)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs7, 0x76B);
    // MOV AL,byte ptr ES:[BX + SI + 0xc] (1000_0767 / 0x10767)
    AL = UInt8[ES, (ushort)(BX + SI + 0xC)];
    CheckExternalEvents(cs7, 0x76E);
    // MOV byte ptr [BP + -0x10],AL (1000_076B / 0x1076B)
    UInt8[SS, (ushort)(BP - 0x10)] = AL;
    CheckExternalEvents(cs7, 0x770);
    // CMP AL,0x3 (1000_076E / 0x1076E)
    Alu8.Sub(AL, 0x3);
    CheckExternalEvents(cs7, 0x772);
    // JLE 0x1000:0776 (1000_0770 / 0x10770)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_0776_10776;
    }
    CheckExternalEvents(cs7, 0x773);
    // CBW  (1000_0772 / 0x10772)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x776);
    // MOV word ptr [BP + -0x4],AX (1000_0773 / 0x10773)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    label_1000_0776_10776:
    CheckExternalEvents(cs7, 0x779);
    // MOV AX,word ptr [BP + -0x8] (1000_0776 / 0x10776)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x77C);
    // ADD AX,word ptr [BP + -0xa] (1000_0779 / 0x10779)
    // AX += UInt16[SS, (ushort)(BP - 0xA)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x77F);
    // MOV CX,0x7d (1000_077C / 0x1077C)
    CX = 0x7D;
    CheckExternalEvents(cs7, 0x781);
    // IMUL CX (1000_077F / 0x1077F)
    int resImul1000_077F = Alu16.Imul((short)AX, (short)CX);
    AX = (ushort)(resImul1000_077F);
    DX = (ushort)(resImul1000_077F >> 16);
    CheckExternalEvents(cs7, 0x783);
    // MOV SI,AX (1000_0781 / 0x10781)
    SI = AX;
    CheckExternalEvents(cs7, 0x787);
    // MOV ES,word ptr [0x558e] (1000_0783 / 0x10783)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x789);
    // MOV AL,0x5 (1000_0787 / 0x10787)
    AL = 0x5;
    CheckExternalEvents(cs7, 0x78E);
    // MUL byte ptr ES:[SI + 0xc799] (1000_0789 / 0x10789)
    ushort resMul1000_0789 = Alu8.Mul(AL, UInt8[ES, (ushort)(SI + 0xC799)]);
    AL = (byte)(resMul1000_0789);
    AH = (byte)(resMul1000_0789 >> 8);
    CheckExternalEvents(cs7, 0x791);
    // ADD word ptr [BP + -0x4],AX (1000_078E / 0x1078E)
    // UInt16[SS, (ushort)(BP - 0x4)] += AX;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x796);
    // MOV AL,byte ptr ES:[SI + 0xc74a] (1000_0791 / 0x10791)
    AL = UInt8[ES, (ushort)(SI + 0xC74A)];
    CheckExternalEvents(cs7, 0x798);
    // SUB AH,AH (1000_0796 / 0x10796)
    AH -= AH;
    CheckExternalEvents(cs7, 0x79B);
    // SUB word ptr [BP + -0x4],AX (1000_0798 / 0x10798)
    // UInt16[SS, (ushort)(BP - 0x4)] -= AX;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x7A0);
    // MOV word ptr [BP + -0xc],0x33 (1000_079B / 0x1079B)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x33;
    label_1000_07A0_107A0:
    CheckExternalEvents(cs7, 0x7A3);
    // MOV AX,word ptr [BP + -0x8] (1000_07A0 / 0x107A0)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x7A6);
    // ADD AX,word ptr [BP + -0xa] (1000_07A3 / 0x107A3)
    // AX += UInt16[SS, (ushort)(BP - 0xA)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x7A9);
    // MOV CX,0x7d (1000_07A6 / 0x107A6)
    CX = 0x7D;
    CheckExternalEvents(cs7, 0x7AB);
    // IMUL CX (1000_07A9 / 0x107A9)
    int resImul1000_07A9 = Alu16.Imul((short)AX, (short)CX);
    AX = (ushort)(resImul1000_07A9);
    DX = (ushort)(resImul1000_07A9 >> 16);
    CheckExternalEvents(cs7, 0x7AD);
    // MOV BX,AX (1000_07AB / 0x107AB)
    BX = AX;
    CheckExternalEvents(cs7, 0x7B0);
    // ADD BX,word ptr [BP + -0xc] (1000_07AD / 0x107AD)
    // BX += UInt16[SS, (ushort)(BP - 0xC)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x7B4);
    // MOV ES,word ptr [0x558e] (1000_07B0 / 0x107B0)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x7BA);
    // CMP byte ptr ES:[BX + 0xc724],0x22 (1000_07B4 / 0x107B4)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0x22);
    CheckExternalEvents(cs7, 0x7BC);
    // JNZ 0x1000:07bf (1000_07BA / 0x107BA)
    if(!ZeroFlag) {
      goto label_1000_07BF_107BF;
    }
    CheckExternalEvents(cs7, 0x7BF);
    // DEC word ptr [BP + -0x4] (1000_07BC / 0x107BC)
    UInt16[SS, (ushort)(BP - 0x4)]--;
    label_1000_07BF_107BF:
    CheckExternalEvents(cs7, 0x7C2);
    // INC word ptr [BP + -0xc] (1000_07BF / 0x107BF)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs7, 0x7C6);
    // CMP word ptr [BP + -0xc],0x55 (1000_07C2 / 0x107C2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xC)], 0x55);
    CheckExternalEvents(cs7, 0x7C8);
    // JLE 0x1000:07a0 (1000_07C6 / 0x107C6)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_07A0_107A0;
    }
    CheckExternalEvents(cs7, 0x7CB);
    // MOV SI,word ptr [BP + -0x8] (1000_07C8 / 0x107C8)
    SI = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x7CE);
    // ADD SI,word ptr [BP + -0xa] (1000_07CB / 0x107CB)
    // SI += UInt16[SS, (ushort)(BP - 0xA)];
    SI = Alu16.Add(SI, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x7D2);
    // MOV ES,word ptr [0x55a6] (1000_07CE / 0x107CE)
    ES = UInt16[DS, 0x55A6];
    CheckExternalEvents(cs7, 0x7D7);
    // MOV AL,byte ptr ES:[SI + 0x92] (1000_07D2 / 0x107D2)
    AL = UInt8[ES, (ushort)(SI + 0x92)];
    CheckExternalEvents(cs7, 0x7D8);
    // CBW  (1000_07D7 / 0x107D7)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x7DB);
    // ADD word ptr [BP + -0x4],AX (1000_07D8 / 0x107D8)
    // UInt16[SS, (ushort)(BP - 0x4)] += AX;
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs7, 0x7DE);
    // MOV AL,byte ptr [BP + -0x4] (1000_07DB / 0x107DB)
    AL = UInt8[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0x7E2);
    // MOV ES,word ptr [0x5598] (1000_07DE / 0x107DE)
    ES = UInt16[DS, 0x5598];
    CheckExternalEvents(cs7, 0x7E7);
    // ADD byte ptr ES:[SI + 0x6e],AL (1000_07E2 / 0x107E2)
    // UInt8[ES, (ushort)(SI + 0x6E)] += AL;
    UInt8[ES, (ushort)(SI + 0x6E)] = Alu8.Add(UInt8[ES, (ushort)(SI + 0x6E)], AL);
    CheckExternalEvents(cs7, 0x7EB);
    // MOV ES,word ptr [0x55a8] (1000_07E7 / 0x107E7)
    ES = UInt16[DS, 0x55A8];
    CheckExternalEvents(cs7, 0x7F1);
    // CMP byte ptr ES:[SI + 0xd576],0x0 (1000_07EB / 0x107EB)
    Alu8.Sub(UInt8[ES, (ushort)(SI + 0xD576)], 0x0);
    CheckExternalEvents(cs7, 0x7F3);
    // JZ 0x1000:0806 (1000_07F1 / 0x107F1)
    if(ZeroFlag) {
      goto label_1000_0806_10806;
    }
    CheckExternalEvents(cs7, 0x7F7);
    // MOV ES,word ptr [0x5598] (1000_07F3 / 0x107F3)
    ES = UInt16[DS, 0x5598];
    CheckExternalEvents(cs7, 0x7FD);
    // ADD byte ptr ES:[SI + 0x6e],0x6 (1000_07F7 / 0x107F7)
    // UInt8[ES, (ushort)(SI + 0x6E)] += 0x6;
    UInt8[ES, (ushort)(SI + 0x6E)] = Alu8.Add(UInt8[ES, (ushort)(SI + 0x6E)], 0x6);
    CheckExternalEvents(cs7, 0x801);
    // MOV ES,word ptr [0x55a8] (1000_07FD / 0x107FD)
    ES = UInt16[DS, 0x55A8];
    CheckExternalEvents(cs7, 0x806);
    // DEC byte ptr ES:[SI + 0xd576] (1000_0801 / 0x10801)
    UInt8[ES, (ushort)(SI + 0xD576)] = Alu8.Dec(UInt8[ES, (ushort)(SI + 0xD576)]);
    label_1000_0806_10806:
    CheckExternalEvents(cs7, 0x809);
    // MOV BX,word ptr [BP + -0x8] (1000_0806 / 0x10806)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x80D);
    // MOV ES,word ptr [0x55aa] (1000_0809 / 0x10809)
    ES = UInt16[DS, 0x55AA];
    CheckExternalEvents(cs7, 0x812);
    // MOV AL,byte ptr ES:[BX + 0x32ae] (1000_080D / 0x1080D)
    AL = UInt8[ES, (ushort)(BX + 0x32AE)];
    CheckExternalEvents(cs7, 0x813);
    // CBW  (1000_0812 / 0x10812)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x816);
    // MOV word ptr [BP + -0x6],AX (1000_0813 / 0x10813)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x81A);
    // MOV ES,word ptr [0x55ac] (1000_0816 / 0x10816)
    ES = UInt16[DS, 0x55AC];
    CheckExternalEvents(cs7, 0x81F);
    // MOV AL,byte ptr ES:[BX + 0x3750] (1000_081A / 0x1081A)
    AL = UInt8[ES, (ushort)(BX + 0x3750)];
    CheckExternalEvents(cs7, 0x821);
    // SUB AH,AH (1000_081F / 0x1081F)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x824);
    // MOV word ptr [BP + -0x2],AX (1000_0821 / 0x10821)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0x828);
    // CMP word ptr [BP + -0xa],0x0 (1000_0824 / 0x10824)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs7, 0x82A);
    // JZ 0x1000:0845 (1000_0828 / 0x10828)
    if(ZeroFlag) {
      goto label_1000_0845_10845;
    }
    CheckExternalEvents(cs7, 0x82E);
    // MOV ES,word ptr [0x55aa] (1000_082A / 0x1082A)
    ES = UInt16[DS, 0x55AA];
    CheckExternalEvents(cs7, 0x833);
    // MOV AL,byte ptr ES:[BX + 0x32ba] (1000_082E / 0x1082E)
    AL = UInt8[ES, (ushort)(BX + 0x32BA)];
    CheckExternalEvents(cs7, 0x834);
    // CBW  (1000_0833 / 0x10833)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0x837);
    // MOV word ptr [BP + -0x6],AX (1000_0834 / 0x10834)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0x83B);
    // MOV ES,word ptr [0x55ac] (1000_0837 / 0x10837)
    ES = UInt16[DS, 0x55AC];
    CheckExternalEvents(cs7, 0x840);
    // MOV AL,byte ptr ES:[BX + 0x375c] (1000_083B / 0x1083B)
    AL = UInt8[ES, (ushort)(BX + 0x375C)];
    CheckExternalEvents(cs7, 0x842);
    // SUB AH,AH (1000_0840 / 0x10840)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0x845);
    // MOV word ptr [BP + -0x2],AX (1000_0842 / 0x10842)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    label_1000_0845_10845:
    CheckExternalEvents(cs7, 0x849);
    // CMP word ptr [BP + -0x6],0x0 (1000_0845 / 0x10845)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs7, 0x84B);
    // JZ 0x1000:085e (1000_0849 / 0x10849)
    if(ZeroFlag) {
      goto label_1000_085E_1085E;
    }
    CheckExternalEvents(cs7, 0x84F);
    // CMP word ptr [BP + -0x2],0x10 (1000_084B / 0x1084B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x10);
    CheckExternalEvents(cs7, 0x851);
    // JGE 0x1000:085e (1000_084F / 0x1084F)
    if(SignFlag == OverflowFlag) {
      goto label_1000_085E_1085E;
    }
    CheckExternalEvents(cs7, 0x854);
    // ADD BX,word ptr [BP + -0xa] (1000_0851 / 0x10851)
    // BX += UInt16[SS, (ushort)(BP - 0xA)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x858);
    // MOV ES,word ptr [0x5598] (1000_0854 / 0x10854)
    ES = UInt16[DS, 0x5598];
    CheckExternalEvents(cs7, 0x85E);
    // SUB byte ptr ES:[BX + 0x6e],0x4 (1000_0858 / 0x10858)
    // UInt8[ES, (ushort)(BX + 0x6E)] -= 0x4;
    UInt8[ES, (ushort)(BX + 0x6E)] = Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x4);
    label_1000_085E_1085E:
    CheckExternalEvents(cs7, 0x861);
    // MOV AX,word ptr [BP + -0x8] (1000_085E / 0x1085E)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x864);
    // ADD AX,word ptr [BP + -0xa] (1000_0861 / 0x10861)
    AX += UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x867);
    // ADD AX,0x6e (1000_0864 / 0x10864)
    // AX += 0x6E;
    AX = Alu16.Add(AX, 0x6E);
    CheckExternalEvents(cs7, 0x86A);
    // MOV word ptr [BP + -0x10],AX (1000_0867 / 0x10867)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs7, 0x86F);
    // MOV word ptr [BP + -0xe],0x2a02 (1000_086A / 0x1086A)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x2A02;
    CheckExternalEvents(cs7, 0x872);
    // LES BX,[BP + -0x10] (1000_086F / 0x1086F)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs7, 0x876);
    // CMP byte ptr ES:[BX],0x0 (1000_0872 / 0x10872)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x0);
    CheckExternalEvents(cs7, 0x878);
    // JGE 0x1000:087c (1000_0876 / 0x10876)
    if(SignFlag == OverflowFlag) {
      goto label_1000_087C_1087C;
    }
    CheckExternalEvents(cs7, 0x87C);
    // MOV byte ptr ES:[BX],0x0 (1000_0878 / 0x10878)
    UInt8[ES, (ushort)(BX)] = 0x0;
    label_1000_087C_1087C:
    CheckExternalEvents(cs7, 0x87F);
    // MOV BX,word ptr [BP + -0x8] (1000_087C / 0x1087C)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x883);
    // MOV ES,word ptr [0x5598] (1000_087F / 0x1087F)
    ES = UInt16[DS, 0x5598];
    CheckExternalEvents(cs7, 0x889);
    // CMP byte ptr ES:[BX + 0x6e],0x1e (1000_0883 / 0x10883)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x1E);
    CheckExternalEvents(cs7, 0x88B);
    // JLE 0x1000:0891 (1000_0889 / 0x10889)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_0891_10891;
    }
    CheckExternalEvents(cs7, 0x891);
    // MOV byte ptr ES:[BX + 0x6e],0x1e (1000_088B / 0x1088B)
    UInt8[ES, (ushort)(BX + 0x6E)] = 0x1E;
    label_1000_0891_10891:
    CheckExternalEvents(cs7, 0x894);
    // MOV BX,word ptr [BP + -0x8] (1000_0891 / 0x10891)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x897);
    // ADD BX,word ptr [BP + -0xa] (1000_0894 / 0x10894)
    // BX += UInt16[SS, (ushort)(BP - 0xA)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x89B);
    // MOV ES,word ptr [0x55a6] (1000_0897 / 0x10897)
    ES = UInt16[DS, 0x55A6];
    CheckExternalEvents(cs7, 0x8A1);
    // MOV byte ptr ES:[BX + 0x92],0x0 (1000_089B / 0x1089B)
    UInt8[ES, (ushort)(BX + 0x92)] = 0x0;
    CheckExternalEvents(cs7, 0x8A4);
    // JMP 0x1000:06e8 (1000_08A1 / 0x108A1)
    goto label_1000_06E8_106E8;
    label_1000_08A4_108A4:
    CheckExternalEvents(cs7, 0x8A7);
    // INC word ptr [BP + -0x8] (1000_08A4 / 0x108A4)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    label_1000_08A7_108A7:
    CheckExternalEvents(cs7, 0x8AB);
    // CMP word ptr [BP + -0x8],0x4 (1000_08A7 / 0x108A7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x4);
    CheckExternalEvents(cs7, 0x8AD);
    // JGE 0x1000:08b5 (1000_08AB / 0x108AB)
    if(SignFlag == OverflowFlag) {
      goto label_1000_08B5_108B5;
    }
    CheckExternalEvents(cs7, 0x8B2);
    // MOV word ptr [BP + -0xa],0x0 (1000_08AD / 0x108AD)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs7, 0x8B5);
    // JMP 0x1000:06ec (1000_08B2 / 0x108B2)
    goto label_1000_06EC_106EC;
    label_1000_08B5_108B5:
    CheckExternalEvents(cs7, 0x8BA);
    // MOV word ptr [BP + -0x8],0x0 (1000_08B5 / 0x108B5)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_1000_08BA_108BA:
    CheckExternalEvents(cs7, 0x8BD);
    // MOV AX,0x11 (1000_08BA / 0x108BA)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x8C0);
    // IMUL word ptr [BP + -0x8] (1000_08BD / 0x108BD)
    int resImul1000_08BD = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x8)]);
    AX = (ushort)(resImul1000_08BD);
    DX = (ushort)(resImul1000_08BD >> 16);
    CheckExternalEvents(cs7, 0x8C2);
    // MOV BX,AX (1000_08C0 / 0x108C0)
    BX = AX;
    CheckExternalEvents(cs7, 0x8C6);
    // MOV ES,word ptr [0x558e] (1000_08C2 / 0x108C2)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0x8CC);
    // CMP byte ptr ES:[BX + 0xc614],0xff (1000_08C6 / 0x108C6)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC614)], 0xFF);
    CheckExternalEvents(cs7, 0x8CE);
    // JNZ 0x1000:0926 (1000_08CC / 0x108CC)
    if(!ZeroFlag) {
      goto label_1000_0926_10926;
    }
    CheckExternalEvents(cs7, 0x8D1);
    // MOV AX,word ptr [BP + -0x8] (1000_08CE / 0x108CE)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0x8D4);
    // ADD AX,0x4 (1000_08D1 / 0x108D1)
    // AX += 0x4;
    AX = Alu16.Add(AX, 0x4);
    CheckExternalEvents(cs7, 0x8D7);
    // MOV word ptr [BP + -0xa],AX (1000_08D4 / 0x108D4)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x8DA);
    // CMP AX,0xc (1000_08D7 / 0x108D7)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs7, 0x8DC);
    // JL 0x1000:08e0 (1000_08DA / 0x108DA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_08E0_108E0;
    }
    CheckExternalEvents(cs7, 0x8E0);
    // ADD word ptr [BP + -0xa],0x4 (1000_08DC / 0x108DC)
    UInt16[SS, (ushort)(BP - 0xA)] += 0x4;
    label_1000_08E0_108E0:
    CheckExternalEvents(cs7, 0x8E4);
    // CMP word ptr [BP + -0x8],0x0 (1000_08E0 / 0x108E0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs7, 0x8E6);
    // JZ 0x1000:0900 (1000_08E4 / 0x108E4)
    if(ZeroFlag) {
      goto label_1000_0900_10900;
    }
    CheckExternalEvents(cs7, 0x8E9);
    // MOV SI,word ptr [BP + -0xa] (1000_08E6 / 0x108E6)
    SI = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x8EB);
    // SHL SI,0x1 (1000_08E9 / 0x108E9)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x8EE);
    // MOV AX,0xffff (1000_08EB / 0x108EB)
    AX = 0xFFFF;
    CheckExternalEvents(cs7, 0x8F2);
    // MOV ES,word ptr [0x5590] (1000_08EE / 0x108EE)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x8F7);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_08F2 / 0x108F2)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs7, 0x8FB);
    // MOV ES,word ptr [0x5592] (1000_08F7 / 0x108F7)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x900);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_08FB / 0x108FB)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    label_1000_0900_10900:
    CheckExternalEvents(cs7, 0x904);
    // CMP word ptr [BP + -0xa],0x10 (1000_0900 / 0x10900)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x10);
    CheckExternalEvents(cs7, 0x906);
    // JL 0x1000:0913 (1000_0904 / 0x10904)
    if(SignFlag != OverflowFlag) {
      goto label_1000_0913_10913;
    }
    CheckExternalEvents(cs7, 0x909);
    // MOV BX,word ptr [BP + -0xa] (1000_0906 / 0x10906)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x90D);
    // MOV ES,word ptr [0x55ae] (1000_0909 / 0x10909)
    ES = UInt16[DS, 0x55AE];
    CheckExternalEvents(cs7, 0x913);
    // MOV byte ptr ES:[BX + 0xd55e],0xfe (1000_090D / 0x1090D)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0xFE;
    label_1000_0913_10913:
    CheckExternalEvents(cs7, 0x917);
    // CMP word ptr [BP + -0x8],0x0 (1000_0913 / 0x10913)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs7, 0x919);
    // JNZ 0x1000:0926 (1000_0917 / 0x10917)
    if(!ZeroFlag) {
      goto label_1000_0926_10926;
    }
    CheckExternalEvents(cs7, 0x91C);
    // MOV BX,word ptr [BP + -0xa] (1000_0919 / 0x10919)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x920);
    // MOV ES,word ptr [0x55ae] (1000_091C / 0x1091C)
    ES = UInt16[DS, 0x55AE];
    CheckExternalEvents(cs7, 0x926);
    // MOV byte ptr ES:[BX + 0xd55e],0x96 (1000_0920 / 0x10920)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x96;
    label_1000_0926_10926:
    CheckExternalEvents(cs7, 0x929);
    // INC word ptr [BP + -0x8] (1000_0926 / 0x10926)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs7, 0x92D);
    // CMP word ptr [BP + -0x8],0x10 (1000_0929 / 0x10929)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x10);
    CheckExternalEvents(cs7, 0x92F);
    // JL 0x1000:08ba (1000_092D / 0x1092D)
    if(SignFlag != OverflowFlag) {
      goto label_1000_08BA_108BA;
    }
    CheckExternalEvents(cs7, 0x930);
    // POP SI (1000_092F / 0x1092F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x932);
    // MOV SP,BP (1000_0930 / 0x10930)
    SP = BP;
    CheckExternalEvents(cs7, 0x933);
    // POP BP (1000_0932 / 0x10932)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0x934);
    // RETF  (1000_0933 / 0x10933)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_0934_10934(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0934_10934:
    CheckExternalEvents(cs7, 0x935);
    // PUSH BP (1000_0934 / 0x10934)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0x937);
    // MOV BP,SP (1000_0935 / 0x10935)
    BP = SP;
    CheckExternalEvents(cs7, 0x93A);
    // MOV AX,0xe (1000_0937 / 0x10937)
    AX = 0xE;
    CheckExternalEvents(cs7, 0x93F);
    // CALLF 0x1000:cecc (1000_093A / 0x1093A)
    FarCall(cs7, 0x93F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0x940);
    // PUSH SI (1000_093F / 0x1093F)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0x943);
    // MOV SI,word ptr [BP + 0x6] (1000_0940 / 0x10940)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0x945);
    // SHL SI,0x1 (1000_0943 / 0x10943)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs7, 0x949);
    // MOV ES,word ptr [0x5592] (1000_0945 / 0x10945)
    ES = UInt16[DS, 0x5592];
    CheckExternalEvents(cs7, 0x94E);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_0949 / 0x10949)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs7, 0x951);
    // MOV word ptr [BP + -0xa],AX (1000_094E / 0x1094E)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs7, 0x955);
    // MOV ES,word ptr [0x5590] (1000_0951 / 0x10951)
    ES = UInt16[DS, 0x5590];
    CheckExternalEvents(cs7, 0x95A);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_0955 / 0x10955)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs7, 0x95D);
    // MOV word ptr [BP + -0xc],AX (1000_095A / 0x1095A)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0x961);
    // CMP word ptr [BP + 0x6],0x4 (1000_095D / 0x1095D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs7, 0x963);
    // JL 0x1000:096f (1000_0961 / 0x10961)
    if(SignFlag != OverflowFlag) {
      goto label_1000_096F_1096F;
    }
    CheckExternalEvents(cs7, 0x967);
    // CMP word ptr [BP + 0x6],0xc (1000_0963 / 0x10963)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs7, 0x969);
    // JL 0x1000:09d8 (1000_0967 / 0x10967)
    if(SignFlag != OverflowFlag) {
      goto label_1000_09D8_109D8;
    }
    CheckExternalEvents(cs7, 0x96D);
    // CMP word ptr [BP + 0x6],0xf (1000_0969 / 0x10969)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xF);
    CheckExternalEvents(cs7, 0x96F);
    // JG 0x1000:09d8 (1000_096D / 0x1096D)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_09D8_109D8;
    }
    label_1000_096F_1096F:
    CheckExternalEvents(cs7, 0x972);
    // PUSH word ptr [BP + -0xc] (1000_096F / 0x1096F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x975);
    // PUSH word ptr [BP + -0xa] (1000_0972 / 0x10972)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x976);
    // PUSH CS (1000_0975 / 0x10975)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x979);
    // CALL 0x1000:05c5 (1000_0976 / 0x10976)
    NearCall(cs7, 0x979, ghidra_guess_1000_05C5_105C5);
    CheckExternalEvents(cs7, 0x97C);
    // ADD SP,0x4 (1000_0979 / 0x10979)
    SP += 0x4;
    CheckExternalEvents(cs7, 0x97F);
    // CMP AX,0x3 (1000_097C / 0x1097C)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs7, 0x981);
    // JLE 0x1000:09d8 (1000_097F / 0x1097F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_09D8_109D8;
    }
    CheckExternalEvents(cs7, 0x985);
    // MOV ES,word ptr [0x5582] (1000_0981 / 0x10981)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x988);
    // MOV AX,word ptr [BP + -0xa] (1000_0985 / 0x10985)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x98D);
    // CMP word ptr ES:[0xa44b],AX (1000_0988 / 0x10988)
    Alu16.Sub(UInt16[ES, 0xA44B], AX);
    CheckExternalEvents(cs7, 0x98F);
    // JNC 0x1000:099e (1000_098D / 0x1098D)
    if(!CarryFlag) {
      goto label_1000_099E_1099E;
    }
    CheckExternalEvents(cs7, 0x992);
    // DEC word ptr [BP + -0xa] (1000_098F / 0x1098F)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x995);
    // MOV AL,byte ptr [BP + -0xa] (1000_0992 / 0x10992)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x997);
    // TEST AL,0x80 (1000_0995 / 0x10995)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs7, 0x999);
    // JZ 0x1000:099e (1000_0997 / 0x10997)
    if(ZeroFlag) {
      goto label_1000_099E_1099E;
    }
    CheckExternalEvents(cs7, 0x99E);
    // AND word ptr [BP + -0xa],0xf7f (1000_0999 / 0x10999)
    // UInt16[SS, (ushort)(BP - 0xA)] &= 0xF7F;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.And(UInt16[SS, (ushort)(BP - 0xA)], 0xF7F);
    label_1000_099E_1099E:
    CheckExternalEvents(cs7, 0x9A2);
    // MOV ES,word ptr [0x5582] (1000_099E / 0x1099E)
    ES = UInt16[DS, 0x5582];
    CheckExternalEvents(cs7, 0x9A5);
    // MOV AX,word ptr [BP + -0xa] (1000_09A2 / 0x109A2)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x9AA);
    // CMP word ptr ES:[0xa44b],AX (1000_09A5 / 0x109A5)
    Alu16.Sub(UInt16[ES, 0xA44B], AX);
    CheckExternalEvents(cs7, 0x9AC);
    // JBE 0x1000:09bb (1000_09AA / 0x109AA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_09BB_109BB;
    }
    CheckExternalEvents(cs7, 0x9AF);
    // INC word ptr [BP + -0xa] (1000_09AC / 0x109AC)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x9B2);
    // MOV AL,byte ptr [BP + -0xa] (1000_09AF / 0x109AF)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs7, 0x9B4);
    // TEST AL,0x80 (1000_09B2 / 0x109B2)
    Alu8.And(AL, 0x80);
    CheckExternalEvents(cs7, 0x9B6);
    // JZ 0x1000:09bb (1000_09B4 / 0x109B4)
    if(ZeroFlag) {
      goto label_1000_09BB_109BB;
    }
    CheckExternalEvents(cs7, 0x9BB);
    // ADD word ptr [BP + -0xa],0x80 (1000_09B6 / 0x109B6)
    // UInt16[SS, (ushort)(BP - 0xA)] += 0x80;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xA)], 0x80);
    label_1000_09BB_109BB:
    CheckExternalEvents(cs7, 0x9BF);
    // MOV ES,word ptr [0x5584] (1000_09BB / 0x109BB)
    ES = UInt16[DS, 0x5584];
    CheckExternalEvents(cs7, 0x9C2);
    // MOV AX,word ptr [BP + -0xc] (1000_09BF / 0x109BF)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs7, 0x9C7);
    // CMP word ptr ES:[0xa44d],AX (1000_09C2 / 0x109C2)
    Alu16.Sub(UInt16[ES, 0xA44D], AX);
    CheckExternalEvents(cs7, 0x9C9);
    // JNC 0x1000:09d8 (1000_09C7 / 0x109C7)
    if(!CarryFlag) {
      goto label_1000_09D8_109D8;
    }
    CheckExternalEvents(cs7, 0x9CD);
    // SUB word ptr [BP + -0xc],0x2 (1000_09C9 / 0x109C9)
    UInt16[SS, (ushort)(BP - 0xC)] -= 0x2;
    CheckExternalEvents(cs7, 0x9D1);
    // TEST byte ptr [BP + -0xc],0x80 (1000_09CD / 0x109CD)
    Alu8.And(UInt8[SS, (ushort)(BP - 0xC)], 0x80);
    CheckExternalEvents(cs7, 0x9D3);
    // JZ 0x1000:09d8 (1000_09D1 / 0x109D1)
    if(ZeroFlag) {
      goto label_1000_09D8_109D8;
    }
    CheckExternalEvents(cs7, 0x9D8);
    // AND word ptr [BP + -0xc],0xf07f (1000_09D3 / 0x109D3)
    // UInt16[SS, (ushort)(BP - 0xC)] &= 0xF07F;
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.And(UInt16[SS, (ushort)(BP - 0xC)], 0xF07F);
    label_1000_09D8_109D8:
    CheckExternalEvents(cs7, 0x9DB);
    // PUSH word ptr [BP + -0xc] (1000_09D8 / 0x109D8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs7, 0x9DE);
    // PUSH word ptr [BP + -0xa] (1000_09DB / 0x109DB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs7, 0x9DF);
    // PUSH CS (1000_09DE / 0x109DE)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0x9E2);
    // CALL 0x1000:05c5 (1000_09DF / 0x109DF)
    NearCall(cs7, 0x9E2, ghidra_guess_1000_05C5_105C5);
    CheckExternalEvents(cs7, 0x9E5);
    // ADD SP,0x4 (1000_09E2 / 0x109E2)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0x9E8);
    // MOV word ptr [BP + -0x8],AX (1000_09E5 / 0x109E5)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0x9ED);
    // MOV word ptr [BP + -0xe],0x3 (1000_09E8 / 0x109E8)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x3;
    CheckExternalEvents(cs7, 0x9F0);
    // MOV AX,0x11 (1000_09ED / 0x109ED)
    AX = 0x11;
    CheckExternalEvents(cs7, 0x9F3);
    // IMUL word ptr [BP + 0x8] (1000_09F0 / 0x109F0)
    int resImul1000_09F0 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x8)]);
    AX = (ushort)(resImul1000_09F0);
    DX = (ushort)(resImul1000_09F0 >> 16);
    CheckExternalEvents(cs7, 0x9F5);
    // MOV BX,AX (1000_09F3 / 0x109F3)
    BX = AX;
    CheckExternalEvents(cs7, 0x9F9);
    // MOV AL,byte ptr [BX + 0x2ee7] (1000_09F5 / 0x109F5)
    AL = UInt8[DS, (ushort)(BX + 0x2EE7)];
    CheckExternalEvents(cs7, 0x9FB);
    // SUB AH,AH (1000_09F9 / 0x109F9)
    AH -= AH;
    CheckExternalEvents(cs7, 0x9FE);
    // CMP AX,word ptr [BP + -0x8] (1000_09FB / 0x109FB)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0xA00);
    // JBE 0x1000:0a05 (1000_09FE / 0x109FE)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0A05_10A05;
    }
    CheckExternalEvents(cs7, 0xA05);
    // MOV word ptr [BP + -0xe],0x2 (1000_0A00 / 0x10A00)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x2;
    label_1000_0A05_10A05:
    CheckExternalEvents(cs7, 0xA08);
    // MOV AX,0x11 (1000_0A05 / 0x10A05)
    AX = 0x11;
    CheckExternalEvents(cs7, 0xA0B);
    // IMUL word ptr [BP + 0x8] (1000_0A08 / 0x10A08)
    int resImul1000_0A08 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x8)]);
    AX = (ushort)(resImul1000_0A08);
    DX = (ushort)(resImul1000_0A08 >> 16);
    CheckExternalEvents(cs7, 0xA0D);
    // MOV SI,AX (1000_0A0B / 0x10A0B)
    SI = AX;
    CheckExternalEvents(cs7, 0xA11);
    // MOV AL,byte ptr [SI + 0x2ee6] (1000_0A0D / 0x10A0D)
    AL = UInt8[DS, (ushort)(SI + 0x2EE6)];
    CheckExternalEvents(cs7, 0xA13);
    // SUB AH,AH (1000_0A11 / 0x10A11)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0xA16);
    // MOV word ptr [BP + -0x4],AX (1000_0A13 / 0x10A13)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs7, 0xA19);
    // AND AX,0x1f (1000_0A16 / 0x10A16)
    // AX &= 0x1F;
    AX = Alu16.And(AX, 0x1F);
    CheckExternalEvents(cs7, 0xA1C);
    // MOV word ptr [BP + -0x2],AX (1000_0A19 / 0x10A19)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0xA1F);
    // MOV AX,word ptr [BP + -0x4] (1000_0A1C / 0x10A1C)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0xA21);
    // MOV CL,0x5 (1000_0A1F / 0x10A1F)
    CL = 0x5;
    CheckExternalEvents(cs7, 0xA23);
    // SHR AX,CL (1000_0A21 / 0x10A21)
    // AX >>= CL;
    AX = Alu16.Shr(AX, CL);
    CheckExternalEvents(cs7, 0xA26);
    // MOV word ptr [BP + -0x6],AX (1000_0A23 / 0x10A23)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0xA2B);
    // CMP byte ptr [SI + 0x2ee4],0x80 (1000_0A26 / 0x10A26)
    Alu8.Sub(UInt8[DS, (ushort)(SI + 0x2EE4)], 0x80);
    CheckExternalEvents(cs7, 0xA2D);
    // JNC 0x1000:0a45 (1000_0A2B / 0x10A2B)
    if(!CarryFlag) {
      goto label_1000_0A45_10A45;
    }
    CheckExternalEvents(cs7, 0xA31);
    // CMP word ptr [BP + 0x8],0x20 (1000_0A2D / 0x10A2D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x20);
    CheckExternalEvents(cs7, 0xA33);
    // JZ 0x1000:0a45 (1000_0A31 / 0x10A31)
    if(ZeroFlag) {
      goto label_1000_0A45_10A45;
    }
    CheckExternalEvents(cs7, 0xA36);
    // MOV AX,0x3 (1000_0A33 / 0x10A33)
    AX = 0x3;
    CheckExternalEvents(cs7, 0xA39);
    // MUL word ptr [BP + -0x2] (1000_0A36 / 0x10A36)
    uint resMul1000_0A36 = Alu16.Mul(AX, UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resMul1000_0A36);
    DX = (ushort)(resMul1000_0A36 >> 16);
    CheckExternalEvents(cs7, 0xA3C);
    // MOV word ptr [BP + -0x2],AX (1000_0A39 / 0x10A39)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0xA3F);
    // MOV AX,0x3 (1000_0A3C / 0x10A3C)
    AX = 0x3;
    CheckExternalEvents(cs7, 0xA42);
    // MUL word ptr [BP + -0x6] (1000_0A3F / 0x10A3F)
    uint resMul1000_0A3F = Alu16.Mul(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resMul1000_0A3F);
    DX = (ushort)(resMul1000_0A3F >> 16);
    CheckExternalEvents(cs7, 0xA45);
    // MOV word ptr [BP + -0x6],AX (1000_0A42 / 0x10A42)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    label_1000_0A45_10A45:
    CheckExternalEvents(cs7, 0xA48);
    // MOV AX,word ptr [BP + -0x2] (1000_0A45 / 0x10A45)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0xA4B);
    // CMP word ptr [BP + -0x8],AX (1000_0A48 / 0x10A48)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs7, 0xA4D);
    // JNC 0x1000:0a52 (1000_0A4B / 0x10A4B)
    if(!CarryFlag) {
      goto label_1000_0A52_10A52;
    }
    CheckExternalEvents(cs7, 0xA52);
    // MOV word ptr [BP + -0xe],0x1 (1000_0A4D / 0x10A4D)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    label_1000_0A52_10A52:
    CheckExternalEvents(cs7, 0xA55);
    // MOV AX,word ptr [BP + -0x6] (1000_0A52 / 0x10A52)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs7, 0xA58);
    // CMP word ptr [BP + -0x8],AX (1000_0A55 / 0x10A55)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs7, 0xA5A);
    // JNC 0x1000:0a5f (1000_0A58 / 0x10A58)
    if(!CarryFlag) {
      goto label_1000_0A5F_10A5F;
    }
    CheckExternalEvents(cs7, 0xA5F);
    // MOV word ptr [BP + -0xe],0x0 (1000_0A5A / 0x10A5A)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_1000_0A5F_10A5F:
    CheckExternalEvents(cs7, 0xA62);
    // MOV AX,word ptr [BP + -0xe] (1000_0A5F / 0x10A5F)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs7, 0xA63);
    // POP SI (1000_0A62 / 0x10A62)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA65);
    // MOV SP,BP (1000_0A63 / 0x10A63)
    SP = BP;
    CheckExternalEvents(cs7, 0xA66);
    // POP BP (1000_0A65 / 0x10A65)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xA67);
    // RETF  (1000_0A66 / 0x10A66)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_0A67_10A67(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0A67_10A67:
    CheckExternalEvents(cs7, 0xA68);
    // PUSH BP (1000_0A67 / 0x10A67)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xA6A);
    // MOV BP,SP (1000_0A68 / 0x10A68)
    BP = SP;
    CheckExternalEvents(cs7, 0xA6D);
    // MOV AX,0x2 (1000_0A6A / 0x10A6A)
    AX = 0x2;
    CheckExternalEvents(cs7, 0xA72);
    // CALLF 0x1000:cecc (1000_0A6D / 0x10A6D)
    FarCall(cs7, 0xA72, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0xA76);
    // MOV ES,word ptr [0x55b0] (1000_0A72 / 0x10A72)
    ES = UInt16[DS, 0x55B0];
    CheckExternalEvents(cs7, 0xA7A);
    // MOV AX,ES:[0x4600] (1000_0A76 / 0x10A76)
    AX = UInt16[ES, 0x4600];
    CheckExternalEvents(cs7, 0xA7D);
    // MOV word ptr [BP + -0x2],AX (1000_0A7A / 0x10A7A)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0xA80);
    // MOV AX,0x4 (1000_0A7D / 0x10A7D)
    AX = 0x4;
    CheckExternalEvents(cs7, 0xA81);
    // PUSH AX (1000_0A80 / 0x10A80)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0xA86);
    // CALLF 0x1000:7ee1 (1000_0A81 / 0x10A81)
    FarCall(cs7, 0xA86, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0xA89);
    // ADD SP,0x2 (1000_0A86 / 0x10A86)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0xA8E);
    // CALLF 0x1000:7fe8 (1000_0A89 / 0x10A89)
    FarCall(cs7, 0xA8E, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0xA91);
    // PUSH word ptr [BP + 0x8] (1000_0A8E / 0x10A8E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs7, 0xA94);
    // PUSH word ptr [BP + 0x6] (1000_0A91 / 0x10A91)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs7, 0xA99);
    // CALLF 0x1000:8055 (1000_0A94 / 0x10A94)
    FarCall(cs7, 0xA99, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs7, 0xA9C);
    // ADD SP,0x4 (1000_0A99 / 0x10A99)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0xAA1);
    // CALLF 0x1000:8d29 (1000_0A9C / 0x10A9C)
    FarCall(cs7, 0xAA1, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs7, 0xAA6);
    // CALLF 0x1000:7fe8 (1000_0AA1 / 0x10AA1)
    FarCall(cs7, 0xAA6, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs7, 0xAA9);
    // PUSH word ptr [BP + -0x2] (1000_0AA6 / 0x10AA6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs7, 0xAAE);
    // CALLF 0x1000:7ee1 (1000_0AA9 / 0x10AA9)
    FarCall(cs7, 0xAAE, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0xAB0);
    // MOV SP,BP (1000_0AAE / 0x10AAE)
    SP = BP;
    CheckExternalEvents(cs7, 0xAB1);
    // POP BP (1000_0AB0 / 0x10AB0)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xAB2);
    // RETF  (1000_0AB1 / 0x10AB1)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_0AB2_10AB2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0AB2_10AB2:
    CheckExternalEvents(cs7, 0xAB3);
    // PUSH BP (1000_0AB2 / 0x10AB2)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xAB5);
    // MOV BP,SP (1000_0AB3 / 0x10AB3)
    BP = SP;
    CheckExternalEvents(cs7, 0xAB8);
    // MOV AX,0x8 (1000_0AB5 / 0x10AB5)
    AX = 0x8;
    CheckExternalEvents(cs7, 0xABD);
    // CALLF 0x1000:cecc (1000_0AB8 / 0x10AB8)
    FarCall(cs7, 0xABD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0xABE);
    // PUSH DI (1000_0ABD / 0x10ABD)
    Stack.Push16(DI);
    CheckExternalEvents(cs7, 0xABF);
    // PUSH SI (1000_0ABE / 0x10ABE)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xAC4);
    // MOV word ptr [BP + -0x2],0x0 (1000_0ABF / 0x10ABF)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs7, 0xAC9);
    // MOV word ptr [BP + -0x8],0xff (1000_0AC4 / 0x10AC4)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xFF;
    CheckExternalEvents(cs7, 0xACE);
    // MOV word ptr [BP + -0x4],0x33 (1000_0AC9 / 0x10AC9)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x33;
    label_1000_0ACE_10ACE:
    CheckExternalEvents(cs7, 0xAD1);
    // MOV AX,0x7d (1000_0ACE / 0x10ACE)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xAD4);
    // IMUL word ptr [BP + 0x6] (1000_0AD1 / 0x10AD1)
    int resImul1000_0AD1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0AD1);
    DX = (ushort)(resImul1000_0AD1 >> 16);
    CheckExternalEvents(cs7, 0xAD6);
    // MOV SI,AX (1000_0AD4 / 0x10AD4)
    SI = AX;
    CheckExternalEvents(cs7, 0xAD9);
    // MOV BX,word ptr [BP + -0x4] (1000_0AD6 / 0x10AD6)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs7, 0xADB);
    // ADD BX,SI (1000_0AD9 / 0x10AD9)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs7, 0xADF);
    // MOV ES,word ptr [0x558e] (1000_0ADB / 0x10ADB)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0xAE4);
    // MOV AL,byte ptr ES:[BX + 0xc724] (1000_0ADF / 0x10ADF)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs7, 0xAE6);
    // SUB AH,AH (1000_0AE4 / 0x10AE4)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs7, 0xAE8);
    // MOV DI,AX (1000_0AE6 / 0x10AE6)
    DI = AX;
    CheckExternalEvents(cs7, 0xAEB);
    // AND AX,0x7f (1000_0AE8 / 0x10AE8)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs7, 0xAEE);
    // MOV word ptr [BP + -0x6],AX (1000_0AEB / 0x10AEB)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs7, 0xAF1);
    // CMP AX,0x10 (1000_0AEE / 0x10AEE)
    Alu16.Sub(AX, 0x10);
    CheckExternalEvents(cs7, 0xAF3);
    // JL 0x1000:0b20 (1000_0AF1 / 0x10AF1)
    if(SignFlag != OverflowFlag) {
      goto label_1000_0B20_10B20;
    }
    CheckExternalEvents(cs7, 0xAF6);
    // CMP AX,0x20 (1000_0AF3 / 0x10AF3)
    Alu16.Sub(AX, 0x20);
    CheckExternalEvents(cs7, 0xAF8);
    // JG 0x1000:0b20 (1000_0AF6 / 0x10AF6)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_0B20_10B20;
    }
    CheckExternalEvents(cs7, 0xAFB);
    // MOV AX,word ptr [BP + -0x2] (1000_0AF8 / 0x10AF8)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0xAFE);
    // INC word ptr [BP + -0x2] (1000_0AFB / 0x10AFB)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs7, 0xB01);
    // CMP AX,word ptr [BP + 0x8] (1000_0AFE / 0x10AFE)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs7, 0xB03);
    // JNZ 0x1000:0b20 (1000_0B01 / 0x10B01)
    if(!ZeroFlag) {
      goto label_1000_0B20_10B20;
    }
    CheckExternalEvents(cs7, 0xB06);
    // LEA AX,[DI + -0x1] (1000_0B03 / 0x10B03)
    AX = (ushort)(DI - 0x1);
    CheckExternalEvents(cs7, 0xB09);
    // MOV word ptr [BP + -0x8],AX (1000_0B06 / 0x10B06)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs7, 0xB0C);
    // MOV BX,word ptr [BP + 0x8] (1000_0B09 / 0x10B09)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xB0E);
    // ADD BX,SI (1000_0B0C / 0x10B0C)
    BX += SI;
    CheckExternalEvents(cs7, 0xB14);
    // CMP byte ptr ES:[BX + 0xc74b],0x0 (1000_0B0E / 0x10B0E)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC74B)], 0x0);
    CheckExternalEvents(cs7, 0xB16);
    // JNZ 0x1000:0b1b (1000_0B14 / 0x10B14)
    if(!ZeroFlag) {
      goto label_1000_0B1B_10B1B;
    }
    CheckExternalEvents(cs7, 0xB1B);
    // MOV word ptr [BP + -0x8],0xff (1000_0B16 / 0x10B16)
    UInt16[SS, (ushort)(BP - 0x8)] = 0xFF;
    label_1000_0B1B_10B1B:
    CheckExternalEvents(cs7, 0xB20);
    // MOV word ptr [BP + -0x4],0x57 (1000_0B1B / 0x10B1B)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x57;
    label_1000_0B20_10B20:
    CheckExternalEvents(cs7, 0xB23);
    // INC word ptr [BP + -0x4] (1000_0B20 / 0x10B20)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs7, 0xB27);
    // CMP word ptr [BP + -0x4],0x56 (1000_0B23 / 0x10B23)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x56);
    CheckExternalEvents(cs7, 0xB29);
    // JL 0x1000:0ace (1000_0B27 / 0x10B27)
    if(SignFlag != OverflowFlag) {
      goto label_1000_0ACE_10ACE;
    }
    CheckExternalEvents(cs7, 0xB2C);
    // MOV AX,word ptr [BP + -0x8] (1000_0B29 / 0x10B29)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0xB2D);
    // POP SI (1000_0B2C / 0x10B2C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB2E);
    // POP DI (1000_0B2D / 0x10B2D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB30);
    // MOV SP,BP (1000_0B2E / 0x10B2E)
    SP = BP;
    CheckExternalEvents(cs7, 0xB31);
    // POP BP (1000_0B30 / 0x10B30)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xB32);
    // RETF  (1000_0B31 / 0x10B31)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_0B32_10B32(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0B32_10B32:
    CheckExternalEvents(cs7, 0xB33);
    // PUSH BP (1000_0B32 / 0x10B32)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xB35);
    // MOV BP,SP (1000_0B33 / 0x10B33)
    BP = SP;
    CheckExternalEvents(cs7, 0xB38);
    // MOV AX,0x2 (1000_0B35 / 0x10B35)
    AX = 0x2;
    CheckExternalEvents(cs7, 0xB3D);
    // CALLF 0x1000:cecc (1000_0B38 / 0x10B38)
    FarCall(cs7, 0xB3D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0xB41);
    // CMP word ptr [BP + 0x6],0x11 (1000_0B3D / 0x10B3D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x11);
    CheckExternalEvents(cs7, 0xB43);
    // JC 0x1000:0b54 (1000_0B41 / 0x10B41)
    if(CarryFlag) {
      goto label_1000_0B54_10B54;
    }
    CheckExternalEvents(cs7, 0xB47);
    // CMP word ptr [BP + 0x6],0x18 (1000_0B43 / 0x10B43)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x18);
    CheckExternalEvents(cs7, 0xB49);
    // JA 0x1000:0b54 (1000_0B47 / 0x10B47)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_0B54_10B54;
    }
    CheckExternalEvents(cs7, 0xB4C);
    // MOV AX,word ptr [BP + 0x6] (1000_0B49 / 0x10B49)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xB4F);
    // ADD AX,0xb (1000_0B4C / 0x10B4C)
    // AX += 0xB;
    AX = Alu16.Add(AX, 0xB);
    CheckExternalEvents(cs7, 0xB52);
    // MOV word ptr [BP + -0x2],AX (1000_0B4F / 0x10B4F)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0xB54);
    // JMP 0x1000:0bb4 (1000_0B52 / 0x10B52)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_0BB4_10BB4, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_0B54_10B54:
    CheckExternalEvents(cs7, 0xB57);
    // MOV AX,word ptr [BP + 0x6] (1000_0B54 / 0x10B54)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs7, 0xB5A);
    // SUB AX,0x19 (1000_0B57 / 0x10B57)
    AX -= 0x19;
    CheckExternalEvents(cs7, 0xB5D);
    // CMP AX,0xa (1000_0B5A / 0x10B5A)
    Alu16.Sub(AX, 0xA);
    CheckExternalEvents(cs7, 0xB5F);
    // JA 0x1000:0bb4 (1000_0B5D / 0x10B5D)
    if(!CarryFlag && !ZeroFlag) {
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_1000_0BB4_10BB4, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs7, 0xB61);
    // ADD AX,AX (1000_0B5F / 0x10B5F)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs7, 0xB62);
    // XCHG AX,BX (1000_0B61 / 0x10B61)
    (BX, AX) = (AX, BX);
    label_1000_0B62_10B62:
    CheckExternalEvents(cs7, 0xB67);
    // JMP word ptr CS:[BX + 0x118e] (1000_0B62 / 0x10B62)
    // Indirect jump to word ptr CS:[BX + 0x118e], generating possible targets from emulator records
    uint targetAddress_1000_0B62 = (uint)(cs7 * 0x10 + UInt16[cs7, (ushort)(BX + 0x118E)] - cs1 * 0x10);
    switch(targetAddress_1000_0B62) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0B62));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_1000_0BB4_10BB4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0BB4_10BB4:
    CheckExternalEvents(cs7, 0xBB7);
    // MOV AX,word ptr [BP + -0x2] (1000_0BB4 / 0x10BB4)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0xBB9);
    // MOV SP,BP (1000_0BB7 / 0x10BB7)
    SP = BP;
    CheckExternalEvents(cs7, 0xBBA);
    // POP BP (1000_0BB9 / 0x10BB9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs7, 0xBBB);
    // RETF  (1000_0BBA / 0x10BBA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_0BBB_10BBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_0BBB_10BBB:
    CheckExternalEvents(cs7, 0xBBC);
    // PUSH BP (1000_0BBB / 0x10BBB)
    Stack.Push16(BP);
    CheckExternalEvents(cs7, 0xBBE);
    // MOV BP,SP (1000_0BBC / 0x10BBC)
    BP = SP;
    CheckExternalEvents(cs7, 0xBC1);
    // MOV AX,0x12 (1000_0BBE / 0x10BBE)
    AX = 0x12;
    CheckExternalEvents(cs7, 0xBC6);
    // CALLF 0x1000:cecc (1000_0BC1 / 0x10BC1)
    FarCall(cs7, 0xBC6, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs7, 0xBC7);
    // PUSH SI (1000_0BC6 / 0x10BC6)
    Stack.Push16(SI);
    CheckExternalEvents(cs7, 0xBCC);
    // MOV word ptr [BP + -0x4],0x0 (1000_0BC7 / 0x10BC7)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs7, 0xBD1);
    // MOV word ptr [BP + -0xa],0x1 (1000_0BCC / 0x10BCC)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    CheckExternalEvents(cs7, 0xBD4);
    // MOV AX,0x7d (1000_0BD1 / 0x10BD1)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xBD7);
    // IMUL word ptr [BP + 0x6] (1000_0BD4 / 0x10BD4)
    int resImul1000_0BD4 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0BD4);
    DX = (ushort)(resImul1000_0BD4 >> 16);
    CheckExternalEvents(cs7, 0xBD9);
    // MOV BX,AX (1000_0BD7 / 0x10BD7)
    BX = AX;
    CheckExternalEvents(cs7, 0xBDC);
    // ADD BX,word ptr [BP + 0x8] (1000_0BD9 / 0x10BD9)
    // BX += UInt16[SS, (ushort)(BP + 0x8)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs7, 0xBE0);
    // MOV ES,word ptr [0x558e] (1000_0BDC / 0x10BDC)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0xBE6);
    // CMP byte ptr ES:[BX + 0xc724],0x0 (1000_0BE0 / 0x10BE0)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0x0);
    CheckExternalEvents(cs7, 0xBE8);
    // JNZ 0x1000:0bed (1000_0BE6 / 0x10BE6)
    if(!ZeroFlag) {
      goto label_1000_0BED_10BED;
    }
    CheckExternalEvents(cs7, 0xBED);
    // MOV word ptr [BP + -0x4],0x1 (1000_0BE8 / 0x10BE8)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_1000_0BED_10BED:
    CheckExternalEvents(cs7, 0xBF2);
    // CALLF 0x0000:30dd (1000_0BED / 0x10BED)
    FarCall(cs7, 0xBF2, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs7, 0xBF5);
    // MOV word ptr [BP + -0xc],AX (1000_0BF2 / 0x10BF2)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs7, 0xBF8);
    // CMP AX,0x8 (1000_0BF5 / 0x10BF5)
    Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs7, 0xBFA);
    // JL 0x1000:0c03 (1000_0BF8 / 0x10BF8)
    if(SignFlag != OverflowFlag) {
      goto label_1000_0C03_10C03;
    }
    CheckExternalEvents(cs7, 0xBFD);
    // SUB AX,0x8 (1000_0BFA / 0x10BFA)
    AX -= 0x8;
    CheckExternalEvents(cs7, 0xBFF);
    // SAR AX,0x1 (1000_0BFD / 0x10BFD)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs7, 0xC00);
    // INC AX (1000_0BFF / 0x10BFF)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs7, 0xC03);
    // MOV word ptr [BP + -0xa],AX (1000_0C00 / 0x10C00)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_1000_0C03_10C03:
    CheckExternalEvents(cs7, 0xC08);
    // CMP word ptr [0x2e38],0x0 (1000_0C03 / 0x10C03)
    Alu16.Sub(UInt16[DS, 0x2E38], 0x0);
    CheckExternalEvents(cs7, 0xC0A);
    // JZ 0x1000:0c33 (1000_0C08 / 0x10C08)
    if(ZeroFlag) {
      goto label_1000_0C33_10C33;
    }
    CheckExternalEvents(cs7, 0xC0E);
    // CMP word ptr [BP + -0xa],0x0 (1000_0C0A / 0x10C0A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs7, 0xC10);
    // JZ 0x1000:0c33 (1000_0C0E / 0x10C0E)
    if(ZeroFlag) {
      goto label_1000_0C33_10C33;
    }
    CheckExternalEvents(cs7, 0xC13);
    // MOV AX,0x4 (1000_0C10 / 0x10C10)
    AX = 0x4;
    CheckExternalEvents(cs7, 0xC14);
    // PUSH AX (1000_0C13 / 0x10C13)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0xC19);
    // CALLF 0x1000:7ee1 (1000_0C14 / 0x10C14)
    FarCall(cs7, 0xC19, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs7, 0xC1C);
    // ADD SP,0x2 (1000_0C19 / 0x10C19)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs7, 0xC1F);
    // MOV AX,0x315e (1000_0C1C / 0x10C1C)
    AX = 0x315E;
    CheckExternalEvents(cs7, 0xC20);
    // PUSH DS (1000_0C1F / 0x10C1F)
    Stack.Push16(DS);
    CheckExternalEvents(cs7, 0xC21);
    // PUSH AX (1000_0C20 / 0x10C20)
    Stack.Push16(AX);
    CheckExternalEvents(cs7, 0xC22);
    // PUSH CS (1000_0C21 / 0x10C21)
    Stack.Push16(cs7);
    CheckExternalEvents(cs7, 0xC25);
    // CALL 0x1000:17bb (1000_0C22 / 0x10C22)
    NearCall(cs7, 0xC25, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs7, 0xC28);
    // ADD SP,0x4 (1000_0C25 / 0x10C25)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs7, 0xC2C);
    // MOV ES,word ptr [0x55b4] (1000_0C28 / 0x10C28)
    ES = UInt16[DS, 0x55B4];
    CheckExternalEvents(cs7, 0xC33);
    // MOV word ptr ES:[0x4586],0x1 (1000_0C2C / 0x10C2C)
    UInt16[ES, 0x4586] = 0x1;
    label_1000_0C33_10C33:
    CheckExternalEvents(cs7, 0xC37);
    // CMP word ptr [BP + -0x4],0x0 (1000_0C33 / 0x10C33)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs7, 0xC39);
    // JZ 0x1000:0cae (1000_0C37 / 0x10C37)
    if(ZeroFlag) {
      goto label_1000_0CAE_10CAE;
    }
    CheckExternalEvents(cs7, 0xC3E);
    // MOV word ptr [BP + -0xa],0x0 (1000_0C39 / 0x10C39)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs7, 0xC41);
    // MOV BX,word ptr [BP + 0x8] (1000_0C3E / 0x10C3E)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xC45);
    // MOV AL,byte ptr [BX + 0x316e] (1000_0C41 / 0x10C41)
    AL = UInt8[DS, (ushort)(BX + 0x316E)];
    CheckExternalEvents(cs7, 0xC46);
    // CBW  (1000_0C45 / 0x10C45)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0xC49);
    // MOV word ptr [BP + -0x2],AX (1000_0C46 / 0x10C46)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs7, 0xC4E);
    // MOV word ptr [BP + -0x8],0x0 (1000_0C49 / 0x10C49)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs7, 0xC50);
    // JMP 0x1000:0c77 (1000_0C4E / 0x10C4E)
    goto label_1000_0C77_10C77;
    label_1000_0C50_10C50:
    CheckExternalEvents(cs7, 0xC53);
    // MOV AX,0x7d (1000_0C50 / 0x10C50)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xC56);
    // IMUL word ptr [BP + 0x6] (1000_0C53 / 0x10C53)
    int resImul1000_0C53 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0C53);
    DX = (ushort)(resImul1000_0C53 >> 16);
    CheckExternalEvents(cs7, 0xC59);
    // ADD AX,word ptr [BP + -0x2] (1000_0C56 / 0x10C56)
    AX += UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs7, 0xC5C);
    // ADD AX,word ptr [BP + -0x8] (1000_0C59 / 0x10C59)
    AX += UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs7, 0xC5F);
    // ADD AX,0xc724 (1000_0C5C / 0x10C5C)
    // AX += 0xC724;
    AX = Alu16.Add(AX, 0xC724);
    CheckExternalEvents(cs7, 0xC62);
    // MOV word ptr [BP + -0x10],AX (1000_0C5F / 0x10C5F)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs7, 0xC67);
    // MOV word ptr [BP + -0xe],0x2a02 (1000_0C62 / 0x10C62)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x2A02;
    CheckExternalEvents(cs7, 0xC6A);
    // LES BX,[BP + -0x10] (1000_0C67 / 0x10C67)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    ES = UInt16[SS, (ushort)(BP - 0x10 + 2)];
    CheckExternalEvents(cs7, 0xC6E);
    // CMP byte ptr ES:[BX],0x0 (1000_0C6A / 0x10C6A)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x0);
    CheckExternalEvents(cs7, 0xC70);
    // JZ 0x1000:0c74 (1000_0C6E / 0x10C6E)
    if(ZeroFlag) {
      goto label_1000_0C74_10C74;
    }
    CheckExternalEvents(cs7, 0xC74);
    // OR byte ptr ES:[BX],0x80 (1000_0C70 / 0x10C70)
    UInt8[ES, (ushort)(BX)] |= 0x80;
    label_1000_0C74_10C74:
    CheckExternalEvents(cs7, 0xC77);
    // INC word ptr [BP + -0x8] (1000_0C74 / 0x10C74)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x8)]);
    label_1000_0C77_10C77:
    CheckExternalEvents(cs7, 0xC7A);
    // MOV BX,word ptr [BP + 0x8] (1000_0C77 / 0x10C77)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xC7E);
    // MOV AL,byte ptr [BX + 0x3176] (1000_0C7A / 0x10C7A)
    AL = UInt8[DS, (ushort)(BX + 0x3176)];
    CheckExternalEvents(cs7, 0xC7F);
    // CBW  (1000_0C7E / 0x10C7E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs7, 0xC82);
    // CMP AX,word ptr [BP + -0x8] (1000_0C7F / 0x10C7F)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs7, 0xC84);
    // JG 0x1000:0c50 (1000_0C82 / 0x10C82)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_0C50_10C50;
    }
    CheckExternalEvents(cs7, 0xC86);
    // MOV AX,BX (1000_0C84 / 0x10C84)
    AX = BX;
    CheckExternalEvents(cs7, 0xC89);
    // CMP AX,0x1c (1000_0C86 / 0x10C86)
    Alu16.Sub(AX, 0x1C);
    CheckExternalEvents(cs7, 0xC8B);
    // JZ 0x1000:0c9c (1000_0C89 / 0x10C89)
    if(ZeroFlag) {
      goto label_1000_0C9C_10C9C;
    }
    CheckExternalEvents(cs7, 0xC8E);
    // CMP AX,0x1e (1000_0C8B / 0x10C8B)
    Alu16.Sub(AX, 0x1E);
    CheckExternalEvents(cs7, 0xC90);
    // JZ 0x1000:0cde (1000_0C8E / 0x10C8E)
    if(ZeroFlag) {
      goto label_1000_0CDE_10CDE;
    }
    CheckExternalEvents(cs7, 0xC93);
    // CMP AX,0x21 (1000_0C90 / 0x10C90)
    Alu16.Sub(AX, 0x21);
    CheckExternalEvents(cs7, 0xC95);
    // JZ 0x1000:0cca (1000_0C93 / 0x10C93)
    if(ZeroFlag) {
      goto label_1000_0CCA_10CCA;
    }
    CheckExternalEvents(cs7, 0xC98);
    // CMP AX,0x23 (1000_0C95 / 0x10C95)
    Alu16.Sub(AX, 0x23);
    CheckExternalEvents(cs7, 0xC9A);
    // JZ 0x1000:0cf2 (1000_0C98 / 0x10C98)
    if(ZeroFlag) {
      goto label_1000_0CF2_10CF2;
    }
    CheckExternalEvents(cs7, 0xC9C);
    // JMP 0x1000:0cae (1000_0C9A / 0x10C9A)
    goto label_1000_0CAE_10CAE;
    label_1000_0C9C_10C9C:
    CheckExternalEvents(cs7, 0xC9F);
    // MOV AX,0x7d (1000_0C9C / 0x10C9C)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xCA2);
    // IMUL word ptr [BP + 0x6] (1000_0C9F / 0x10C9F)
    int resImul1000_0C9F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0C9F);
    DX = (ushort)(resImul1000_0C9F >> 16);
    CheckExternalEvents(cs7, 0xCA4);
    // MOV BX,AX (1000_0CA2 / 0x10CA2)
    BX = AX;
    CheckExternalEvents(cs7, 0xCA8);
    // MOV ES,word ptr [0x558e] (1000_0CA4 / 0x10CA4)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0xCAE);
    // AND byte ptr ES:[BX + 0xc748],0xf (1000_0CA8 / 0x10CA8)
    UInt8[ES, (ushort)(BX + 0xC748)] &= 0xF;
    label_1000_0CAE_10CAE:
    CheckExternalEvents(cs7, 0xCB2);
    // CMP word ptr [BP + -0xa],0x0 (1000_0CAE / 0x10CAE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs7, 0xCB4);
    // JNZ 0x1000:0cb7 (1000_0CB2 / 0x10CB2)
    if(!ZeroFlag) {
      goto label_1000_0CB7_10CB7;
    }
    CheckExternalEvents(cs7, 0xCB7);
    // JMP 0x1000:1005 (1000_0CB4 / 0x10CB4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_1005_11005, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_0CB7_10CB7:
    CheckExternalEvents(cs7, 0xCBA);
    // MOV AX,word ptr [BP + 0x8] (1000_0CB7 / 0x10CB7)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs7, 0xCBD);
    // SUB AX,0x1c (1000_0CBA / 0x10CBA)
    AX -= 0x1C;
    CheckExternalEvents(cs7, 0xCC0);
    // CMP AX,0x7 (1000_0CBD / 0x10CBD)
    Alu16.Sub(AX, 0x7);
    CheckExternalEvents(cs7, 0xCC2);
    // JA 0x1000:0cae (1000_0CC0 / 0x10CC0)
    if(!CarryFlag && !ZeroFlag) {
      goto label_1000_0CAE_10CAE;
    }
    CheckExternalEvents(cs7, 0xCC4);
    // ADD AX,AX (1000_0CC2 / 0x10CC2)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs7, 0xCC5);
    // XCHG AX,BX (1000_0CC4 / 0x10CC4)
    (BX, AX) = (AX, BX);
    label_1000_0CC5_10CC5:
    CheckExternalEvents(cs7, 0xCCA);
    // JMP word ptr CS:[BX + 0x15e2] (1000_0CC5 / 0x10CC5)
    // Indirect jump to word ptr CS:[BX + 0x15e2], generating possible targets from emulator records
    uint targetAddress_1000_0CC5 = (uint)(cs7 * 0x10 + UInt16[cs7, (ushort)(BX + 0x15E2)] - cs1 * 0x10);
    switch(targetAddress_1000_0CC5) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0CC5));
        break;
    }
    label_1000_0CCA_10CCA:
    CheckExternalEvents(cs7, 0xCCD);
    // MOV AX,0x7d (1000_0CCA / 0x10CCA)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xCD0);
    // IMUL word ptr [BP + 0x6] (1000_0CCD / 0x10CCD)
    int resImul1000_0CCD = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0CCD);
    DX = (ushort)(resImul1000_0CCD >> 16);
    CheckExternalEvents(cs7, 0xCD2);
    // MOV BX,AX (1000_0CD0 / 0x10CD0)
    BX = AX;
    CheckExternalEvents(cs7, 0xCD6);
    // MOV ES,word ptr [0x558e] (1000_0CD2 / 0x10CD2)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0xCDC);
    // AND byte ptr ES:[BX + 0xc749],0xf (1000_0CD6 / 0x10CD6)
    // UInt8[ES, (ushort)(BX + 0xC749)] &= 0xF;
    UInt8[ES, (ushort)(BX + 0xC749)] = Alu8.And(UInt8[ES, (ushort)(BX + 0xC749)], 0xF);
    CheckExternalEvents(cs7, 0xCDE);
    // JMP 0x1000:0cae (1000_0CDC / 0x10CDC)
    goto label_1000_0CAE_10CAE;
    label_1000_0CDE_10CDE:
    CheckExternalEvents(cs7, 0xCE1);
    // MOV AX,0x7d (1000_0CDE / 0x10CDE)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xCE4);
    // IMUL word ptr [BP + 0x6] (1000_0CE1 / 0x10CE1)
    int resImul1000_0CE1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0CE1);
    DX = (ushort)(resImul1000_0CE1 >> 16);
    CheckExternalEvents(cs7, 0xCE6);
    // MOV BX,AX (1000_0CE4 / 0x10CE4)
    BX = AX;
    CheckExternalEvents(cs7, 0xCEA);
    // MOV ES,word ptr [0x558e] (1000_0CE6 / 0x10CE6)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0xCF0);
    // AND byte ptr ES:[BX + 0xc748],0xf0 (1000_0CEA / 0x10CEA)
    // UInt8[ES, (ushort)(BX + 0xC748)] &= 0xF0;
    UInt8[ES, (ushort)(BX + 0xC748)] = Alu8.And(UInt8[ES, (ushort)(BX + 0xC748)], 0xF0);
    CheckExternalEvents(cs7, 0xCF2);
    // JMP 0x1000:0cae (1000_0CF0 / 0x10CF0)
    goto label_1000_0CAE_10CAE;
    label_1000_0CF2_10CF2:
    CheckExternalEvents(cs7, 0xCF5);
    // MOV AX,0x7d (1000_0CF2 / 0x10CF2)
    AX = 0x7D;
    CheckExternalEvents(cs7, 0xCF8);
    // IMUL word ptr [BP + 0x6] (1000_0CF5 / 0x10CF5)
    int resImul1000_0CF5 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_0CF5);
    DX = (ushort)(resImul1000_0CF5 >> 16);
    CheckExternalEvents(cs7, 0xCFA);
    // MOV BX,AX (1000_0CF8 / 0x10CF8)
    BX = AX;
    CheckExternalEvents(cs7, 0xCFE);
    // MOV ES,word ptr [0x558e] (1000_0CFA / 0x10CFA)
    ES = UInt16[DS, 0x558E];
    CheckExternalEvents(cs7, 0xD04);
    // AND byte ptr ES:[BX + 0xc749],0xf0 (1000_0CFE / 0x10CFE)
    // UInt8[ES, (ushort)(BX + 0xC749)] &= 0xF0;
    UInt8[ES, (ushort)(BX + 0xC749)] = Alu8.And(UInt8[ES, (ushort)(BX + 0xC749)], 0xF0);
    CheckExternalEvents(cs7, 0xD06);
    // JMP 0x1000:0cae (1000_0D04 / 0x10D04)
    goto label_1000_0CAE_10CAE;
  }
  
}
