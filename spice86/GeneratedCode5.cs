namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_0000_71B2_071B2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_71B2_071B2:
    CheckExternalEvents(cs1, 0x71B3);
    // PUSH BP (0000_71B2 / 0x71B2)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x71B5);
    // MOV BP,SP (0000_71B3 / 0x71B3)
    BP = SP;
    CheckExternalEvents(cs1, 0x71B8);
    // MOV AX,0x2a (0000_71B5 / 0x71B5)
    AX = 0x2A;
    CheckExternalEvents(cs1, 0x71BD);
    // CALLF 0x1000:cecc (0000_71B8 / 0x71B8)
    FarCall(cs1, 0x71BD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x71BE);
    // PUSH DI (0000_71BD / 0x71BD)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0x71BF);
    // PUSH SI (0000_71BE / 0x71BE)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x71C1);
    // SUB AX,AX (0000_71BF / 0x71BF)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x71C4);
    // MOV word ptr [BP + -0x8],AX (0000_71C1 / 0x71C1)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0x71C7);
    // MOV word ptr [BP + -0x6],AX (0000_71C4 / 0x71C4)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x71CA);
    // MOV word ptr [BP + -0x4],AX (0000_71C7 / 0x71C7)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x71CD);
    // MOV word ptr [BP + -0xc],AX (0000_71CA / 0x71CA)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    label_0000_71CD_071CD:
    CheckExternalEvents(cs1, 0x71D0);
    // MOV AX,0x11 (0000_71CD / 0x71CD)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x71D3);
    // IMUL word ptr [BP + -0xc] (0000_71D0 / 0x71D0)
    int resImul0000_71D0 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_71D0);
    DX = (ushort)(resImul0000_71D0 >> 16);
    CheckExternalEvents(cs1, 0x71D5);
    // MOV SI,AX (0000_71D3 / 0x71D3)
    SI = AX;
    CheckExternalEvents(cs1, 0x71D9);
    // MOV ES,word ptr [0x5412] (0000_71D5 / 0x71D5)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x71DF);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0000_71D9 / 0x71D9)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0x71E1);
    // JZ 0x0000:71f7 (0000_71DF / 0x71DF)
    if(ZeroFlag) {
      goto label_0000_71F7_071F7;
    }
    CheckExternalEvents(cs1, 0x71E6);
    // MOV AL,byte ptr ES:[SI + 0xc61d] (0000_71E1 / 0x71E1)
    AL = UInt8[ES, (ushort)(SI + 0xC61D)];
    CheckExternalEvents(cs1, 0x71E7);
    // CBW  (0000_71E6 / 0x71E6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x71E9);
    // MOV DI,AX (0000_71E7 / 0x71E7)
    DI = AX;
    CheckExternalEvents(cs1, 0x71EC);
    // CMP word ptr [BP + -0x6],DI (0000_71E9 / 0x71E9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], DI);
    CheckExternalEvents(cs1, 0x71EE);
    // JGE 0x0000:71f7 (0000_71EC / 0x71EC)
    if(SignFlag == OverflowFlag) {
      goto label_0000_71F7_071F7;
    }
    CheckExternalEvents(cs1, 0x71F1);
    // MOV AX,word ptr [BP + -0xc] (0000_71EE / 0x71EE)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x71F4);
    // MOV word ptr [BP + -0x4],AX (0000_71F1 / 0x71F1)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x71F7);
    // MOV word ptr [BP + -0x6],DI (0000_71F4 / 0x71F4)
    UInt16[SS, (ushort)(BP - 0x6)] = DI;
    label_0000_71F7_071F7:
    CheckExternalEvents(cs1, 0x71FA);
    // INC word ptr [BP + -0xc] (0000_71F7 / 0x71F7)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x71FE);
    // CMP word ptr [BP + -0xc],0x8 (0000_71FA / 0x71FA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x8);
    CheckExternalEvents(cs1, 0x7200);
    // JL 0x0000:71cd (0000_71FE / 0x71FE)
    if(SignFlag != OverflowFlag) {
      goto label_0000_71CD_071CD;
    }
    CheckExternalEvents(cs1, 0x7203);
    // MOV AX,0xefb (0000_7200 / 0x7200)
    AX = 0xEFB;
    CheckExternalEvents(cs1, 0x7204);
    // PUSH DS (0000_7203 / 0x7203)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7205);
    // PUSH AX (0000_7204 / 0x7204)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x720A);
    // CALLF 0x1000:8055 (0000_7205 / 0x7205)
    FarCall(cs1, 0x720A, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x720D);
    // ADD SP,0x4 (0000_720A / 0x720A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7210);
    // MOV AX,0x11 (0000_720D / 0x720D)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7213);
    // IMUL word ptr [BP + -0x4] (0000_7210 / 0x7210)
    int resImul0000_7210 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_7210);
    DX = (ushort)(resImul0000_7210 >> 16);
    CheckExternalEvents(cs1, 0x7215);
    // MOV BX,AX (0000_7213 / 0x7213)
    BX = AX;
    CheckExternalEvents(cs1, 0x7219);
    // MOV ES,word ptr [0x5412] (0000_7215 / 0x7215)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x721E);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_7219 / 0x7219)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x721F);
    // CBW  (0000_721E / 0x721E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x7221);
    // MOV BX,AX (0000_721F / 0x721F)
    BX = AX;
    CheckExternalEvents(cs1, 0x7223);
    // SHL BX,0x1 (0000_7221 / 0x7221)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x7225);
    // SHL BX,0x1 (0000_7223 / 0x7223)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7229);
    // MOV ES,word ptr [0x5414] (0000_7225 / 0x7225)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x722E);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_7229 / 0x7229)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x7233);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_722E / 0x722E)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x7238);
    // CALLF 0x1000:8055 (0000_7233 / 0x7233)
    FarCall(cs1, 0x7238, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x723B);
    // ADD SP,0x4 (0000_7238 / 0x7238)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x723E);
    // MOV AX,0xefe (0000_723B / 0x723B)
    AX = 0xEFE;
    CheckExternalEvents(cs1, 0x723F);
    // PUSH DS (0000_723E / 0x723E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7240);
    // PUSH AX (0000_723F / 0x723F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7245);
    // CALLF 0x1000:8055 (0000_7240 / 0x7240)
    FarCall(cs1, 0x7245, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7248);
    // ADD SP,0x4 (0000_7245 / 0x7245)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x724C);
    // CMP word ptr [BP + -0x6],0x1 (0000_7248 / 0x7248)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x1);
    CheckExternalEvents(cs1, 0x724E);
    // JLE 0x0000:7265 (0000_724C / 0x724C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7265_07265;
    }
    CheckExternalEvents(cs1, 0x7251);
    // MOV BX,word ptr [BP + -0x6] (0000_724E / 0x724E)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7253);
    // SHL BX,0x1 (0000_7251 / 0x7251)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x7255);
    // SHL BX,0x1 (0000_7253 / 0x7253)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7259);
    // PUSH word ptr [BX + 0xf9c] (0000_7255 / 0x7255)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0xF9C)]);
    CheckExternalEvents(cs1, 0x725D);
    // PUSH word ptr [BX + 0xf9a] (0000_7259 / 0x7259)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0xF9A)]);
    CheckExternalEvents(cs1, 0x7262);
    // CALLF 0x1000:8055 (0000_725D / 0x725D)
    FarCall(cs1, 0x7262, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7265);
    // ADD SP,0x4 (0000_7262 / 0x7262)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_7265_07265:
    CheckExternalEvents(cs1, 0x7268);
    // MOV AX,0xf28 (0000_7265 / 0x7265)
    AX = 0xF28;
    CheckExternalEvents(cs1, 0x7269);
    // PUSH DS (0000_7268 / 0x7268)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x726A);
    // PUSH AX (0000_7269 / 0x7269)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x726F);
    // CALLF 0x1000:8055 (0000_726A / 0x726A)
    FarCall(cs1, 0x726F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7272);
    // ADD SP,0x4 (0000_726F / 0x726F)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7277);
    // CALLF 0x0000:414f (0000_7272 / 0x7272)
    FarCall(cs1, 0x7277, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs1, 0x727C);
    // MOV word ptr [BP + -0x2],0x0 (0000_7277 / 0x7277)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0x7281);
    // MOV word ptr [BP + -0xc],0xc (0000_727C / 0x727C)
    UInt16[SS, (ushort)(BP - 0xC)] = 0xC;
    label_0000_7281_07281:
    CheckExternalEvents(cs1, 0x7284);
    // MOV BX,word ptr [BP + -0xc] (0000_7281 / 0x7281)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x7286);
    // SHL BX,0x1 (0000_7284 / 0x7284)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x728A);
    // MOV ES,word ptr [0x5416] (0000_7286 / 0x7286)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x7290);
    // CMP word ptr ES:[BX + 0x393c],0x0 (0000_728A / 0x728A)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x393C)], 0x0);
    CheckExternalEvents(cs1, 0x7292);
    // JZ 0x0000:72bc (0000_7290 / 0x7290)
    if(ZeroFlag) {
      goto label_0000_72BC_072BC;
    }
    CheckExternalEvents(cs1, 0x7297);
    // MOV word ptr [BP + -0x26],0x11 (0000_7292 / 0x7292)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x11;
    label_0000_7297_07297:
    CheckExternalEvents(cs1, 0x729A);
    // MOV AX,0x7d (0000_7297 / 0x7297)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x729D);
    // IMUL word ptr [BP + -0xc] (0000_729A / 0x729A)
    int resImul0000_729A = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_729A);
    DX = (ushort)(resImul0000_729A >> 16);
    CheckExternalEvents(cs1, 0x729F);
    // MOV BX,AX (0000_729D / 0x729D)
    BX = AX;
    CheckExternalEvents(cs1, 0x72A2);
    // ADD BX,word ptr [BP + -0x26] (0000_729F / 0x729F)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x72A6);
    // MOV ES,word ptr [0x5412] (0000_72A2 / 0x72A2)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x72AB);
    // MOV AL,byte ptr ES:[BX + 0xc33c] (0000_72A6 / 0x72A6)
    AL = UInt8[ES, (ushort)(BX + 0xC33C)];
    CheckExternalEvents(cs1, 0x72AD);
    // SUB AH,AH (0000_72AB / 0x72AB)
    AH -= AH;
    CheckExternalEvents(cs1, 0x72B0);
    // ADD word ptr [BP + -0x2],AX (0000_72AD / 0x72AD)
    UInt16[SS, (ushort)(BP - 0x2)] += AX;
    CheckExternalEvents(cs1, 0x72B3);
    // INC word ptr [BP + -0x26] (0000_72B0 / 0x72B0)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs1, 0x72B7);
    // CMP word ptr [BP + -0x26],0x1b (0000_72B3 / 0x72B3)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x1B);
    CheckExternalEvents(cs1, 0x72B9);
    // JLE 0x0000:7297 (0000_72B7 / 0x72B7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7297_07297;
    }
    CheckExternalEvents(cs1, 0x72BC);
    // INC word ptr [BP + -0x8] (0000_72B9 / 0x72B9)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    label_0000_72BC_072BC:
    CheckExternalEvents(cs1, 0x72BF);
    // INC word ptr [BP + -0xc] (0000_72BC / 0x72BC)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x72C3);
    // CMP word ptr [BP + -0xc],0x10 (0000_72BF / 0x72BF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x10);
    CheckExternalEvents(cs1, 0x72C5);
    // JL 0x0000:7281 (0000_72C3 / 0x72C3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7281_07281;
    }
    CheckExternalEvents(cs1, 0x72CA);
    // MOV word ptr [BP + -0x26],0x1b (0000_72C5 / 0x72C5)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x1B;
    CheckExternalEvents(cs1, 0x72CC);
    // JMP 0x0000:7330 (0000_72CA / 0x72CA)
    goto label_0000_7330_07330;
    label_0000_72CC_072CC:
    CheckExternalEvents(cs1, 0x72CF);
    // INC word ptr [BP + -0xc] (0000_72CC / 0x72CC)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_0000_72CF_072CF:
    CheckExternalEvents(cs1, 0x72D3);
    // CMP word ptr [BP + -0xc],0x4 (0000_72CF / 0x72CF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs1, 0x72D5);
    // JGE 0x0000:732d (0000_72D3 / 0x72D3)
    if(SignFlag == OverflowFlag) {
      goto label_0000_732D_0732D;
    }
    CheckExternalEvents(cs1, 0x72D8);
    // MOV AX,0x7d (0000_72D5 / 0x72D5)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x72DB);
    // IMUL word ptr [BP + -0xc] (0000_72D8 / 0x72D8)
    int resImul0000_72D8 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_72D8);
    DX = (ushort)(resImul0000_72D8 >> 16);
    CheckExternalEvents(cs1, 0x72DD);
    // MOV SI,AX (0000_72DB / 0x72DB)
    SI = AX;
    CheckExternalEvents(cs1, 0x72E1);
    // MOV ES,word ptr [0x5412] (0000_72DD / 0x72DD)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x72E7);
    // CMP byte ptr ES:[SI + 0xc724],0xff (0000_72E1 / 0x72E1)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x72E9);
    // JZ 0x0000:72cc (0000_72E7 / 0x72E7)
    if(ZeroFlag) {
      goto label_0000_72CC_072CC;
    }
    CheckExternalEvents(cs1, 0x72EC);
    // MOV DI,word ptr [BP + -0x26] (0000_72E9 / 0x72E9)
    DI = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs1, 0x72EE);
    // ADD DI,SI (0000_72EC / 0x72EC)
    // DI += SI;
    DI = Alu.Add16(DI, SI);
    CheckExternalEvents(cs1, 0x72F3);
    // MOV AL,byte ptr ES:[DI + 0xc769] (0000_72EE / 0x72EE)
    AL = UInt8[ES, (ushort)(DI + 0xC769)];
    CheckExternalEvents(cs1, 0x72F5);
    // SUB AH,AH (0000_72F3 / 0x72F3)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x72FA);
    // MOV CL,byte ptr ES:[DI + 0xc724] (0000_72F5 / 0x72F5)
    CL = UInt8[ES, (ushort)(DI + 0xC724)];
    CheckExternalEvents(cs1, 0x72FC);
    // SUB CH,CH (0000_72FA / 0x72FA)
    CH -= CH;
    CheckExternalEvents(cs1, 0x72FE);
    // SUB AX,CX (0000_72FC / 0x72FC)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0x7301);
    // MOV word ptr [BP + -0xa],AX (0000_72FE / 0x72FE)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x7303);
    // OR AX,AX (0000_7301 / 0x7301)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x7305);
    // JZ 0x0000:72cc (0000_7303 / 0x7303)
    if(ZeroFlag) {
      goto label_0000_72CC_072CC;
    }
    CheckExternalEvents(cs1, 0x7308);
    // MOV AX,word ptr [BP + -0x2] (0000_7305 / 0x7305)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x730B);
    // CMP word ptr [BP + -0xa],AX (0000_7308 / 0x7308)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], AX);
    CheckExternalEvents(cs1, 0x730D);
    // JLE 0x0000:7310 (0000_730B / 0x730B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7310_07310;
    }
    CheckExternalEvents(cs1, 0x7310);
    // MOV word ptr [BP + -0xa],AX (0000_730D / 0x730D)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_0000_7310_07310:
    CheckExternalEvents(cs1, 0x7313);
    // MOV AX,word ptr [BP + -0xa] (0000_7310 / 0x7310)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x7316);
    // SUB word ptr [BP + -0x2],AX (0000_7313 / 0x7313)
    // UInt16[SS, (ushort)(BP - 0x2)] -= AX;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs1, 0x7319);
    // MOV AL,byte ptr [BP + -0xa] (0000_7316 / 0x7316)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x731B);
    // MOV CX,AX (0000_7319 / 0x7319)
    CX = AX;
    CheckExternalEvents(cs1, 0x731E);
    // MOV AX,0x7d (0000_731B / 0x731B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7321);
    // IMUL word ptr [BP + -0xc] (0000_731E / 0x731E)
    int resImul0000_731E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_731E);
    DX = (ushort)(resImul0000_731E >> 16);
    CheckExternalEvents(cs1, 0x7323);
    // MOV BX,AX (0000_7321 / 0x7321)
    BX = AX;
    CheckExternalEvents(cs1, 0x7326);
    // ADD BX,word ptr [BP + -0x26] (0000_7323 / 0x7323)
    BX += UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs1, 0x732B);
    // ADD byte ptr ES:[BX + 0xc724],CL (0000_7326 / 0x7326)
    // UInt8[ES, (ushort)(BX + 0xC724)] += CL;
    UInt8[ES, (ushort)(BX + 0xC724)] = Alu.Add8(UInt8[ES, (ushort)(BX + 0xC724)], CL);
    CheckExternalEvents(cs1, 0x732D);
    // JMP 0x0000:72cc (0000_732B / 0x732B)
    goto label_0000_72CC_072CC;
    label_0000_732D_0732D:
    CheckExternalEvents(cs1, 0x7330);
    // DEC word ptr [BP + -0x26] (0000_732D / 0x732D)
    UInt16[SS, (ushort)(BP - 0x26)]--;
    label_0000_7330_07330:
    CheckExternalEvents(cs1, 0x7334);
    // CMP word ptr [BP + -0x26],0x11 (0000_7330 / 0x7330)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x11);
    CheckExternalEvents(cs1, 0x7336);
    // JL 0x0000:733d (0000_7334 / 0x7334)
    if(SignFlag != OverflowFlag) {
      goto label_0000_733D_0733D;
    }
    CheckExternalEvents(cs1, 0x733B);
    // MOV word ptr [BP + -0xc],0x0 (0000_7336 / 0x7336)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    CheckExternalEvents(cs1, 0x733D);
    // JMP 0x0000:72cf (0000_733B / 0x733B)
    goto label_0000_72CF_072CF;
    label_0000_733D_0733D:
    CheckExternalEvents(cs1, 0x7341);
    // CMP word ptr [BP + -0x6],0x4 (0000_733D / 0x733D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x4);
    CheckExternalEvents(cs1, 0x7343);
    // JGE 0x0000:7346 (0000_7341 / 0x7341)
    if(SignFlag == OverflowFlag) {
      goto label_0000_7346_07346;
    }
    CheckExternalEvents(cs1, 0x7346);
    // JMP 0x0000:7409 (0000_7343 / 0x7343)
    goto label_0000_7409_07409;
    label_0000_7346_07346:
    CheckExternalEvents(cs1, 0x734B);
    // MOV word ptr [BP + -0x2],0x0 (0000_7346 / 0x7346)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0x7350);
    // MOV word ptr [BP + -0xc],0xc (0000_734B / 0x734B)
    UInt16[SS, (ushort)(BP - 0xC)] = 0xC;
    label_0000_7350_07350:
    CheckExternalEvents(cs1, 0x7353);
    // MOV BX,word ptr [BP + -0xc] (0000_7350 / 0x7350)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x7355);
    // SHL BX,0x1 (0000_7353 / 0x7353)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7359);
    // MOV ES,word ptr [0x5416] (0000_7355 / 0x7355)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x735F);
    // CMP word ptr ES:[BX + 0x393c],0x0 (0000_7359 / 0x7359)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x393C)], 0x0);
    CheckExternalEvents(cs1, 0x7361);
    // JZ 0x0000:7388 (0000_735F / 0x735F)
    if(ZeroFlag) {
      goto label_0000_7388_07388;
    }
    CheckExternalEvents(cs1, 0x7366);
    // MOV word ptr [BP + -0x26],0x1c (0000_7361 / 0x7361)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x1C;
    label_0000_7366_07366:
    CheckExternalEvents(cs1, 0x7369);
    // MOV AX,0x7d (0000_7366 / 0x7366)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x736C);
    // IMUL word ptr [BP + -0xc] (0000_7369 / 0x7369)
    int resImul0000_7369 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_7369);
    DX = (ushort)(resImul0000_7369 >> 16);
    CheckExternalEvents(cs1, 0x736E);
    // MOV BX,AX (0000_736C / 0x736C)
    BX = AX;
    CheckExternalEvents(cs1, 0x7371);
    // ADD BX,word ptr [BP + -0x26] (0000_736E / 0x736E)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x7375);
    // MOV ES,word ptr [0x5412] (0000_7371 / 0x7371)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x737A);
    // MOV AL,byte ptr ES:[BX + 0xc33c] (0000_7375 / 0x7375)
    AL = UInt8[ES, (ushort)(BX + 0xC33C)];
    CheckExternalEvents(cs1, 0x737C);
    // SUB AH,AH (0000_737A / 0x737A)
    AH -= AH;
    CheckExternalEvents(cs1, 0x737F);
    // ADD word ptr [BP + -0x2],AX (0000_737C / 0x737C)
    UInt16[SS, (ushort)(BP - 0x2)] += AX;
    CheckExternalEvents(cs1, 0x7382);
    // INC word ptr [BP + -0x26] (0000_737F / 0x737F)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs1, 0x7386);
    // CMP word ptr [BP + -0x26],0x23 (0000_7382 / 0x7382)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x23);
    CheckExternalEvents(cs1, 0x7388);
    // JLE 0x0000:7366 (0000_7386 / 0x7386)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7366_07366;
    }
    label_0000_7388_07388:
    CheckExternalEvents(cs1, 0x738B);
    // INC word ptr [BP + -0xc] (0000_7388 / 0x7388)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x738F);
    // CMP word ptr [BP + -0xc],0x10 (0000_738B / 0x738B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x10);
    CheckExternalEvents(cs1, 0x7391);
    // JL 0x0000:7350 (0000_738F / 0x738F)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7350_07350;
    }
    CheckExternalEvents(cs1, 0x7396);
    // MOV word ptr [BP + -0x26],0x23 (0000_7391 / 0x7391)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x23;
    CheckExternalEvents(cs1, 0x7398);
    // JMP 0x0000:73fc (0000_7396 / 0x7396)
    goto label_0000_73FC_073FC;
    label_0000_7398_07398:
    CheckExternalEvents(cs1, 0x739B);
    // INC word ptr [BP + -0xc] (0000_7398 / 0x7398)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_0000_739B_0739B:
    CheckExternalEvents(cs1, 0x739F);
    // CMP word ptr [BP + -0xc],0x4 (0000_739B / 0x739B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs1, 0x73A1);
    // JGE 0x0000:73f9 (0000_739F / 0x739F)
    if(SignFlag == OverflowFlag) {
      goto label_0000_73F9_073F9;
    }
    CheckExternalEvents(cs1, 0x73A4);
    // MOV AX,0x7d (0000_73A1 / 0x73A1)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x73A7);
    // IMUL word ptr [BP + -0xc] (0000_73A4 / 0x73A4)
    int resImul0000_73A4 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_73A4);
    DX = (ushort)(resImul0000_73A4 >> 16);
    CheckExternalEvents(cs1, 0x73A9);
    // MOV SI,AX (0000_73A7 / 0x73A7)
    SI = AX;
    CheckExternalEvents(cs1, 0x73AD);
    // MOV ES,word ptr [0x5412] (0000_73A9 / 0x73A9)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x73B3);
    // CMP byte ptr ES:[SI + 0xc724],0xff (0000_73AD / 0x73AD)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x73B5);
    // JZ 0x0000:7398 (0000_73B3 / 0x73B3)
    if(ZeroFlag) {
      goto label_0000_7398_07398;
    }
    CheckExternalEvents(cs1, 0x73B8);
    // MOV DI,word ptr [BP + -0x26] (0000_73B5 / 0x73B5)
    DI = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs1, 0x73BA);
    // ADD DI,SI (0000_73B8 / 0x73B8)
    // DI += SI;
    DI = Alu.Add16(DI, SI);
    CheckExternalEvents(cs1, 0x73BF);
    // MOV AL,byte ptr ES:[DI + 0xc769] (0000_73BA / 0x73BA)
    AL = UInt8[ES, (ushort)(DI + 0xC769)];
    CheckExternalEvents(cs1, 0x73C1);
    // SUB AH,AH (0000_73BF / 0x73BF)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x73C6);
    // MOV CL,byte ptr ES:[DI + 0xc724] (0000_73C1 / 0x73C1)
    CL = UInt8[ES, (ushort)(DI + 0xC724)];
    CheckExternalEvents(cs1, 0x73C8);
    // SUB CH,CH (0000_73C6 / 0x73C6)
    CH -= CH;
    CheckExternalEvents(cs1, 0x73CA);
    // SUB AX,CX (0000_73C8 / 0x73C8)
    // AX -= CX;
    AX = Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0x73CD);
    // MOV word ptr [BP + -0xa],AX (0000_73CA / 0x73CA)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x73CF);
    // OR AX,AX (0000_73CD / 0x73CD)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x73D1);
    // JZ 0x0000:7398 (0000_73CF / 0x73CF)
    if(ZeroFlag) {
      goto label_0000_7398_07398;
    }
    CheckExternalEvents(cs1, 0x73D4);
    // MOV AX,word ptr [BP + -0x2] (0000_73D1 / 0x73D1)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x73D7);
    // CMP word ptr [BP + -0xa],AX (0000_73D4 / 0x73D4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], AX);
    CheckExternalEvents(cs1, 0x73D9);
    // JLE 0x0000:73dc (0000_73D7 / 0x73D7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_73DC_073DC;
    }
    CheckExternalEvents(cs1, 0x73DC);
    // MOV word ptr [BP + -0xa],AX (0000_73D9 / 0x73D9)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    label_0000_73DC_073DC:
    CheckExternalEvents(cs1, 0x73DF);
    // MOV AX,word ptr [BP + -0xa] (0000_73DC / 0x73DC)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x73E2);
    // SUB word ptr [BP + -0x2],AX (0000_73DF / 0x73DF)
    // UInt16[SS, (ushort)(BP - 0x2)] -= AX;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], AX);
    CheckExternalEvents(cs1, 0x73E5);
    // MOV AL,byte ptr [BP + -0xa] (0000_73E2 / 0x73E2)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x73E7);
    // MOV CX,AX (0000_73E5 / 0x73E5)
    CX = AX;
    CheckExternalEvents(cs1, 0x73EA);
    // MOV AX,0x7d (0000_73E7 / 0x73E7)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x73ED);
    // IMUL word ptr [BP + -0xc] (0000_73EA / 0x73EA)
    int resImul0000_73EA = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_73EA);
    DX = (ushort)(resImul0000_73EA >> 16);
    CheckExternalEvents(cs1, 0x73EF);
    // MOV BX,AX (0000_73ED / 0x73ED)
    BX = AX;
    CheckExternalEvents(cs1, 0x73F2);
    // ADD BX,word ptr [BP + -0x26] (0000_73EF / 0x73EF)
    BX += UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs1, 0x73F7);
    // ADD byte ptr ES:[BX + 0xc724],CL (0000_73F2 / 0x73F2)
    // UInt8[ES, (ushort)(BX + 0xC724)] += CL;
    UInt8[ES, (ushort)(BX + 0xC724)] = Alu.Add8(UInt8[ES, (ushort)(BX + 0xC724)], CL);
    CheckExternalEvents(cs1, 0x73F9);
    // JMP 0x0000:7398 (0000_73F7 / 0x73F7)
    goto label_0000_7398_07398;
    label_0000_73F9_073F9:
    CheckExternalEvents(cs1, 0x73FC);
    // DEC word ptr [BP + -0x26] (0000_73F9 / 0x73F9)
    UInt16[SS, (ushort)(BP - 0x26)]--;
    label_0000_73FC_073FC:
    CheckExternalEvents(cs1, 0x7400);
    // CMP word ptr [BP + -0x26],0x1c (0000_73FC / 0x73FC)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x1C);
    CheckExternalEvents(cs1, 0x7402);
    // JL 0x0000:7409 (0000_7400 / 0x7400)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7409_07409;
    }
    CheckExternalEvents(cs1, 0x7407);
    // MOV word ptr [BP + -0xc],0x0 (0000_7402 / 0x7402)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    CheckExternalEvents(cs1, 0x7409);
    // JMP 0x0000:739b (0000_7407 / 0x7407)
    goto label_0000_739B_0739B;
    label_0000_7409_07409:
    CheckExternalEvents(cs1, 0x740D);
    // CMP word ptr [BP + -0x6],0x2 (0000_7409 / 0x7409)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x2);
    CheckExternalEvents(cs1, 0x740F);
    // JGE 0x0000:7412 (0000_740D / 0x740D)
    if(SignFlag == OverflowFlag) {
      goto label_0000_7412_07412;
    }
    CheckExternalEvents(cs1, 0x7412);
    // JMP 0x0000:74cf (0000_740F / 0x740F)
    goto label_0000_74CF_074CF;
    label_0000_7412_07412:
    CheckExternalEvents(cs1, 0x7417);
    // MOV word ptr [BP + -0x2],0x0 (0000_7412 / 0x7412)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0x741C);
    // MOV word ptr [BP + -0xc],0x0 (0000_7417 / 0x7417)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_741C_0741C:
    CheckExternalEvents(cs1, 0x741F);
    // MOV BX,word ptr [BP + -0xc] (0000_741C / 0x741C)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x7421);
    // SHL BX,0x1 (0000_741F / 0x741F)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7425);
    // MOV ES,word ptr [0x5416] (0000_7421 / 0x7421)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x742B);
    // CMP word ptr ES:[BX + 0x3954],0x0 (0000_7425 / 0x7425)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x3954)], 0x0);
    CheckExternalEvents(cs1, 0x742D);
    // JZ 0x0000:7455 (0000_742B / 0x742B)
    if(ZeroFlag) {
      goto label_0000_7455_07455;
    }
    CheckExternalEvents(cs1, 0x7432);
    // MOV word ptr [BP + -0x26],0x33 (0000_742D / 0x742D)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x33;
    label_0000_7432_07432:
    CheckExternalEvents(cs1, 0x7435);
    // MOV AX,0x7d (0000_7432 / 0x7432)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7438);
    // IMUL word ptr [BP + -0xc] (0000_7435 / 0x7435)
    int resImul0000_7435 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_7435);
    DX = (ushort)(resImul0000_7435 >> 16);
    CheckExternalEvents(cs1, 0x743A);
    // MOV BX,AX (0000_7438 / 0x7438)
    BX = AX;
    CheckExternalEvents(cs1, 0x743D);
    // ADD BX,word ptr [BP + -0x26] (0000_743A / 0x743A)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x7441);
    // MOV ES,word ptr [0x5412] (0000_743D / 0x743D)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7447);
    // CMP byte ptr ES:[BX + 0xc918],0x22 (0000_7441 / 0x7441)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC918)], 0x22);
    CheckExternalEvents(cs1, 0x7449);
    // JNZ 0x0000:744c (0000_7447 / 0x7447)
    if(!ZeroFlag) {
      goto label_0000_744C_0744C;
    }
    CheckExternalEvents(cs1, 0x744C);
    // INC word ptr [BP + -0x2] (0000_7449 / 0x7449)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0000_744C_0744C:
    CheckExternalEvents(cs1, 0x744F);
    // INC word ptr [BP + -0x26] (0000_744C / 0x744C)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs1, 0x7453);
    // CMP word ptr [BP + -0x26],0x55 (0000_744F / 0x744F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x55);
    CheckExternalEvents(cs1, 0x7455);
    // JLE 0x0000:7432 (0000_7453 / 0x7453)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7432_07432;
    }
    label_0000_7455_07455:
    CheckExternalEvents(cs1, 0x7458);
    // INC word ptr [BP + -0xc] (0000_7455 / 0x7455)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x745C);
    // CMP word ptr [BP + -0xc],0x4 (0000_7458 / 0x7458)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs1, 0x745E);
    // JL 0x0000:741c (0000_745C / 0x745C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_741C_0741C;
    }
    CheckExternalEvents(cs1, 0x7463);
    // MOV word ptr [BP + -0xc],0x0 (0000_745E / 0x745E)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_7463_07463:
    CheckExternalEvents(cs1, 0x7466);
    // MOV AX,0x7d (0000_7463 / 0x7463)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7469);
    // IMUL word ptr [BP + -0xc] (0000_7466 / 0x7466)
    int resImul0000_7466 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_7466);
    DX = (ushort)(resImul0000_7466 >> 16);
    CheckExternalEvents(cs1, 0x746B);
    // MOV BX,AX (0000_7469 / 0x7469)
    BX = AX;
    CheckExternalEvents(cs1, 0x746F);
    // MOV ES,word ptr [0x5412] (0000_746B / 0x746B)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7475);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0000_746F / 0x746F)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x7477);
    // JZ 0x0000:74c6 (0000_7475 / 0x7475)
    if(ZeroFlag) {
      goto label_0000_74C6_074C6;
    }
    CheckExternalEvents(cs1, 0x747C);
    // MOV word ptr [BP + -0x26],0x33 (0000_7477 / 0x7477)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x33;
    label_0000_747C_0747C:
    CheckExternalEvents(cs1, 0x747F);
    // MOV AX,0x7d (0000_747C / 0x747C)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7482);
    // IMUL word ptr [BP + -0xc] (0000_747F / 0x747F)
    int resImul0000_747F = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_747F);
    DX = (ushort)(resImul0000_747F >> 16);
    CheckExternalEvents(cs1, 0x7484);
    // MOV BX,AX (0000_7482 / 0x7482)
    BX = AX;
    CheckExternalEvents(cs1, 0x7487);
    // ADD BX,word ptr [BP + -0x26] (0000_7484 / 0x7484)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x748B);
    // MOV ES,word ptr [0x5412] (0000_7487 / 0x7487)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7491);
    // CMP byte ptr ES:[BX + 0xc724],0xa2 (0000_748B / 0x748B)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xA2);
    CheckExternalEvents(cs1, 0x7493);
    // JNZ 0x0000:74bd (0000_7491 / 0x7491)
    if(!ZeroFlag) {
      goto label_0000_74BD_074BD;
    }
    CheckExternalEvents(cs1, 0x7496);
    // PUSH word ptr [BP + -0x26] (0000_7493 / 0x7493)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x7499);
    // PUSH word ptr [BP + -0xc] (0000_7496 / 0x7496)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x749E);
    // CALLF 0x1000:41ed (0000_7499 / 0x7499)
    FarCall(cs1, 0x749E, ghidra_guess_1000_41ED_141ED);
    CheckExternalEvents(cs1, 0x74A1);
    // ADD SP,0x4 (0000_749E / 0x749E)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x74A3);
    // OR AX,AX (0000_74A1 / 0x74A1)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x74A5);
    // JZ 0x0000:74bd (0000_74A3 / 0x74A3)
    if(ZeroFlag) {
      goto label_0000_74BD_074BD;
    }
    CheckExternalEvents(cs1, 0x74A8);
    // MOV AX,0x7d (0000_74A5 / 0x74A5)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x74AB);
    // IMUL word ptr [BP + -0xc] (0000_74A8 / 0x74A8)
    int resImul0000_74A8 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_74A8);
    DX = (ushort)(resImul0000_74A8 >> 16);
    CheckExternalEvents(cs1, 0x74AD);
    // MOV BX,AX (0000_74AB / 0x74AB)
    BX = AX;
    CheckExternalEvents(cs1, 0x74B0);
    // ADD BX,word ptr [BP + -0x26] (0000_74AD / 0x74AD)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x74B4);
    // MOV ES,word ptr [0x5412] (0000_74B0 / 0x74B0)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x74BA);
    // MOV byte ptr ES:[BX + 0xc724],0x22 (0000_74B4 / 0x74B4)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0x22;
    CheckExternalEvents(cs1, 0x74BD);
    // DEC word ptr [BP + -0x2] (0000_74BA / 0x74BA)
    UInt16[SS, (ushort)(BP - 0x2)]--;
    label_0000_74BD_074BD:
    CheckExternalEvents(cs1, 0x74C0);
    // INC word ptr [BP + -0x26] (0000_74BD / 0x74BD)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs1, 0x74C4);
    // CMP word ptr [BP + -0x26],0x55 (0000_74C0 / 0x74C0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x55);
    CheckExternalEvents(cs1, 0x74C6);
    // JLE 0x0000:747c (0000_74C4 / 0x74C4)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_747C_0747C;
    }
    label_0000_74C6_074C6:
    CheckExternalEvents(cs1, 0x74C9);
    // INC word ptr [BP + -0xc] (0000_74C6 / 0x74C6)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x74CD);
    // CMP word ptr [BP + -0xc],0x4 (0000_74C9 / 0x74C9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs1, 0x74CF);
    // JL 0x0000:7463 (0000_74CD / 0x74CD)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7463_07463;
    }
    label_0000_74CF_074CF:
    CheckExternalEvents(cs1, 0x74D3);
    // CMP word ptr [BP + -0x6],0x3 (0000_74CF / 0x74CF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs1, 0x74D5);
    // JGE 0x0000:74d8 (0000_74D3 / 0x74D3)
    if(SignFlag == OverflowFlag) {
      goto label_0000_74D8_074D8;
    }
    CheckExternalEvents(cs1, 0x74D8);
    // JMP 0x0000:75da (0000_74D5 / 0x74D5)
    goto label_0000_75DA_075DA;
    label_0000_74D8_074D8:
    CheckExternalEvents(cs1, 0x74DD);
    // MOV word ptr [BP + -0xc],0x0 (0000_74D8 / 0x74D8)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_74DD_074DD:
    CheckExternalEvents(cs1, 0x74E0);
    // MOV SI,word ptr [BP + -0xc] (0000_74DD / 0x74DD)
    SI = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x74E4);
    // MOV byte ptr [BP + SI + -0x24],0x0 (0000_74E0 / 0x74E0)
    UInt8[SS, (ushort)(BP + SI - 0x24)] = 0x0;
    CheckExternalEvents(cs1, 0x74E7);
    // INC word ptr [BP + -0xc] (0000_74E4 / 0x74E4)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x74EB);
    // CMP word ptr [BP + -0xc],0x10 (0000_74E7 / 0x74E7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x10);
    CheckExternalEvents(cs1, 0x74ED);
    // JL 0x0000:74dd (0000_74EB / 0x74EB)
    if(SignFlag != OverflowFlag) {
      goto label_0000_74DD_074DD;
    }
    CheckExternalEvents(cs1, 0x74F2);
    // MOV word ptr [BP + -0xc],0x0 (0000_74ED / 0x74ED)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_74F2_074F2:
    CheckExternalEvents(cs1, 0x74F5);
    // MOV BX,word ptr [BP + -0xc] (0000_74F2 / 0x74F2)
    BX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x74F7);
    // SHL BX,0x1 (0000_74F5 / 0x74F5)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x74FB);
    // MOV ES,word ptr [0x5416] (0000_74F7 / 0x74F7)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x7501);
    // CMP word ptr ES:[BX + 0x3954],0x0 (0000_74FB / 0x74FB)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x3954)], 0x0);
    CheckExternalEvents(cs1, 0x7503);
    // JZ 0x0000:753a (0000_7501 / 0x7501)
    if(ZeroFlag) {
      goto label_0000_753A_0753A;
    }
    CheckExternalEvents(cs1, 0x7508);
    // MOV word ptr [BP + -0x26],0x33 (0000_7503 / 0x7503)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x33;
    label_0000_7508_07508:
    CheckExternalEvents(cs1, 0x750B);
    // MOV AX,0x7d (0000_7508 / 0x7508)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x750E);
    // IMUL word ptr [BP + -0xc] (0000_750B / 0x750B)
    int resImul0000_750B = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_750B);
    DX = (ushort)(resImul0000_750B >> 16);
    CheckExternalEvents(cs1, 0x7510);
    // MOV BX,AX (0000_750E / 0x750E)
    BX = AX;
    CheckExternalEvents(cs1, 0x7513);
    // ADD BX,word ptr [BP + -0x26] (0000_7510 / 0x7510)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x7517);
    // MOV ES,word ptr [0x5412] (0000_7513 / 0x7513)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x751C);
    // MOV AL,byte ptr ES:[BX + 0xc918] (0000_7517 / 0x7517)
    AL = UInt8[ES, (ushort)(BX + 0xC918)];
    CheckExternalEvents(cs1, 0x751F);
    // MOV byte ptr [BP + -0x2a],AL (0000_751C / 0x751C)
    UInt8[SS, (ushort)(BP - 0x2A)] = AL;
    CheckExternalEvents(cs1, 0x7521);
    // CMP AL,0x10 (0000_751F / 0x751F)
    Alu.Sub8(AL, 0x10);
    CheckExternalEvents(cs1, 0x7523);
    // JC 0x0000:7531 (0000_7521 / 0x7521)
    if(CarryFlag) {
      goto label_0000_7531_07531;
    }
    CheckExternalEvents(cs1, 0x7525);
    // CMP AL,0x20 (0000_7523 / 0x7523)
    Alu.Sub8(AL, 0x20);
    CheckExternalEvents(cs1, 0x7527);
    // JA 0x0000:7531 (0000_7525 / 0x7525)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_7531_07531;
    }
    CheckExternalEvents(cs1, 0x752A);
    // MOV SI,word ptr [BP + -0x2a] (0000_7527 / 0x7527)
    SI = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs1, 0x752E);
    // AND SI,0xff (0000_752A / 0x752A)
    SI &= 0xFF;
    CheckExternalEvents(cs1, 0x7531);
    // INC byte ptr [BP + SI + -0x34] (0000_752E / 0x752E)
    UInt8[SS, (ushort)(BP + SI - 0x34)]++;
    label_0000_7531_07531:
    CheckExternalEvents(cs1, 0x7534);
    // INC word ptr [BP + -0x26] (0000_7531 / 0x7531)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs1, 0x7538);
    // CMP word ptr [BP + -0x26],0x55 (0000_7534 / 0x7534)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x55);
    CheckExternalEvents(cs1, 0x753A);
    // JLE 0x0000:7508 (0000_7538 / 0x7538)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7508_07508;
    }
    label_0000_753A_0753A:
    CheckExternalEvents(cs1, 0x753D);
    // INC word ptr [BP + -0xc] (0000_753A / 0x753A)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x7541);
    // CMP word ptr [BP + -0xc],0x4 (0000_753D / 0x753D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs1, 0x7543);
    // JL 0x0000:74f2 (0000_7541 / 0x7541)
    if(SignFlag != OverflowFlag) {
      goto label_0000_74F2_074F2;
    }
    CheckExternalEvents(cs1, 0x7548);
    // MOV word ptr [BP + -0xc],0x0 (0000_7543 / 0x7543)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    label_0000_7548_07548:
    CheckExternalEvents(cs1, 0x754B);
    // MOV AX,0x7d (0000_7548 / 0x7548)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x754E);
    // IMUL word ptr [BP + -0xc] (0000_754B / 0x754B)
    int resImul0000_754B = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_754B);
    DX = (ushort)(resImul0000_754B >> 16);
    CheckExternalEvents(cs1, 0x7550);
    // MOV BX,AX (0000_754E / 0x754E)
    BX = AX;
    CheckExternalEvents(cs1, 0x7554);
    // MOV ES,word ptr [0x5412] (0000_7550 / 0x7550)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x755A);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0000_7554 / 0x7554)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x755C);
    // JZ 0x0000:75ce (0000_755A / 0x755A)
    if(ZeroFlag) {
      goto label_0000_75CE_075CE;
    }
    CheckExternalEvents(cs1, 0x7561);
    // MOV word ptr [BP + -0x26],0x33 (0000_755C / 0x755C)
    UInt16[SS, (ushort)(BP - 0x26)] = 0x33;
    label_0000_7561_07561:
    CheckExternalEvents(cs1, 0x7564);
    // MOV AX,0x7d (0000_7561 / 0x7561)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7567);
    // IMUL word ptr [BP + -0xc] (0000_7564 / 0x7564)
    int resImul0000_7564 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_7564);
    DX = (ushort)(resImul0000_7564 >> 16);
    CheckExternalEvents(cs1, 0x7569);
    // MOV BX,AX (0000_7567 / 0x7567)
    BX = AX;
    CheckExternalEvents(cs1, 0x756C);
    // ADD BX,word ptr [BP + -0x26] (0000_7569 / 0x7569)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x7570);
    // MOV ES,word ptr [0x5412] (0000_756C / 0x756C)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7575);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_7570 / 0x7570)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0x7578);
    // MOV byte ptr [BP + -0x2a],AL (0000_7575 / 0x7575)
    UInt8[SS, (ushort)(BP - 0x2A)] = AL;
    CheckExternalEvents(cs1, 0x757C);
    // TEST byte ptr [BP + -0x2a],0x80 (0000_7578 / 0x7578)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x2A)], 0x80);
    CheckExternalEvents(cs1, 0x757E);
    // JZ 0x0000:75c5 (0000_757C / 0x757C)
    if(ZeroFlag) {
      goto label_0000_75C5_075C5;
    }
    CheckExternalEvents(cs1, 0x7580);
    // SUB AH,AH (0000_757E / 0x757E)
    AH -= AH;
    CheckExternalEvents(cs1, 0x7583);
    // AND AX,0x7f (0000_7580 / 0x7580)
    // AX &= 0x7F;
    AX = Alu.And16(AX, 0x7F);
    CheckExternalEvents(cs1, 0x7586);
    // MOV word ptr [BP + -0x2],AX (0000_7583 / 0x7583)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x7589);
    // CMP AX,0x10 (0000_7586 / 0x7586)
    Alu.Sub16(AX, 0x10);
    CheckExternalEvents(cs1, 0x758B);
    // JL 0x0000:75c5 (0000_7589 / 0x7589)
    if(SignFlag != OverflowFlag) {
      goto label_0000_75C5_075C5;
    }
    CheckExternalEvents(cs1, 0x758E);
    // CMP AX,0x20 (0000_758B / 0x758B)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs1, 0x7590);
    // JG 0x0000:75c5 (0000_758E / 0x758E)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_75C5_075C5;
    }
    CheckExternalEvents(cs1, 0x7592);
    // MOV SI,AX (0000_7590 / 0x7590)
    SI = AX;
    CheckExternalEvents(cs1, 0x7596);
    // CMP byte ptr [BP + SI + -0x34],0x0 (0000_7592 / 0x7592)
    Alu.Sub8(UInt8[SS, (ushort)(BP + SI - 0x34)], 0x0);
    CheckExternalEvents(cs1, 0x7598);
    // JZ 0x0000:75c5 (0000_7596 / 0x7596)
    if(ZeroFlag) {
      goto label_0000_75C5_075C5;
    }
    CheckExternalEvents(cs1, 0x759B);
    // PUSH word ptr [BP + -0x26] (0000_7598 / 0x7598)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x759E);
    // PUSH word ptr [BP + -0xc] (0000_759B / 0x759B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x75A3);
    // CALLF 0x1000:41ed (0000_759E / 0x759E)
    FarCall(cs1, 0x75A3, ghidra_guess_1000_41ED_141ED);
    CheckExternalEvents(cs1, 0x75A6);
    // ADD SP,0x4 (0000_75A3 / 0x75A3)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x75A8);
    // OR AX,AX (0000_75A6 / 0x75A6)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x75AA);
    // JZ 0x0000:75c5 (0000_75A8 / 0x75A8)
    if(ZeroFlag) {
      goto label_0000_75C5_075C5;
    }
    CheckExternalEvents(cs1, 0x75AD);
    // MOV AX,0x7d (0000_75AA / 0x75AA)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x75B0);
    // IMUL word ptr [BP + -0xc] (0000_75AD / 0x75AD)
    int resImul0000_75AD = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_75AD);
    DX = (ushort)(resImul0000_75AD >> 16);
    CheckExternalEvents(cs1, 0x75B2);
    // MOV BX,AX (0000_75B0 / 0x75B0)
    BX = AX;
    CheckExternalEvents(cs1, 0x75B5);
    // ADD BX,word ptr [BP + -0x26] (0000_75B2 / 0x75B2)
    // BX += UInt16[SS, (ushort)(BP - 0x26)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x75B9);
    // MOV ES,word ptr [0x5412] (0000_75B5 / 0x75B5)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x75BF);
    // AND byte ptr ES:[BX + 0xc724],0x7f (0000_75B9 / 0x75B9)
    // UInt8[ES, (ushort)(BX + 0xC724)] &= 0x7F;
    UInt8[ES, (ushort)(BX + 0xC724)] = Alu.And8(UInt8[ES, (ushort)(BX + 0xC724)], 0x7F);
    CheckExternalEvents(cs1, 0x75C2);
    // MOV SI,word ptr [BP + -0x2] (0000_75BF / 0x75BF)
    SI = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x75C5);
    // DEC byte ptr [BP + SI + -0x34] (0000_75C2 / 0x75C2)
    UInt8[SS, (ushort)(BP + SI - 0x34)]--;
    label_0000_75C5_075C5:
    CheckExternalEvents(cs1, 0x75C8);
    // INC word ptr [BP + -0x26] (0000_75C5 / 0x75C5)
    UInt16[SS, (ushort)(BP - 0x26)]++;
    CheckExternalEvents(cs1, 0x75CC);
    // CMP word ptr [BP + -0x26],0x55 (0000_75C8 / 0x75C8)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x26)], 0x55);
    CheckExternalEvents(cs1, 0x75CE);
    // JLE 0x0000:7561 (0000_75CC / 0x75CC)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7561_07561;
    }
    label_0000_75CE_075CE:
    CheckExternalEvents(cs1, 0x75D1);
    // INC word ptr [BP + -0xc] (0000_75CE / 0x75CE)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    CheckExternalEvents(cs1, 0x75D5);
    // CMP word ptr [BP + -0xc],0x4 (0000_75D1 / 0x75D1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x4);
    CheckExternalEvents(cs1, 0x75D7);
    // JGE 0x0000:75da (0000_75D5 / 0x75D5)
    if(SignFlag == OverflowFlag) {
      goto label_0000_75DA_075DA;
    }
    CheckExternalEvents(cs1, 0x75DA);
    // JMP 0x0000:7548 (0000_75D7 / 0x75D7)
    goto label_0000_7548_07548;
    label_0000_75DA_075DA:
    CheckExternalEvents(cs1, 0x75DE);
    // CMP word ptr [BP + -0x8],0x0 (0000_75DA / 0x75DA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs1, 0x75E0);
    // JNZ 0x0000:75e3 (0000_75DE / 0x75DE)
    if(!ZeroFlag) {
      goto label_0000_75E3_075E3;
    }
    CheckExternalEvents(cs1, 0x75E3);
    // JMP 0x0000:76a3 (0000_75E0 / 0x75E0)
    goto label_0000_76A3_076A3;
    label_0000_75E3_075E3:
    CheckExternalEvents(cs1, 0x75E7);
    // CMP word ptr [BP + -0x4],0x0 (0000_75E3 / 0x75E3)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x75E9);
    // JNZ 0x0000:75ec (0000_75E7 / 0x75E7)
    if(!ZeroFlag) {
      goto label_0000_75EC_075EC;
    }
    CheckExternalEvents(cs1, 0x75EC);
    // JMP 0x0000:76a3 (0000_75E9 / 0x75E9)
    goto label_0000_76A3_076A3;
    label_0000_75EC_075EC:
    CheckExternalEvents(cs1, 0x75F1);
    // MOV word ptr [BP + -0x28],0x0 (0000_75EC / 0x75EC)
    UInt16[SS, (ushort)(BP - 0x28)] = 0x0;
    CheckExternalEvents(cs1, 0x75F6);
    // MOV word ptr [BP + -0xc],0x0 (0000_75F1 / 0x75F1)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    CheckExternalEvents(cs1, 0x75F8);
    // JMP 0x0000:7609 (0000_75F6 / 0x75F6)
    goto label_0000_7609_07609;
    label_0000_75F8_075F8:
    CheckExternalEvents(cs1, 0x75FD);
    // CALLF 0x1000:aab0 (0000_75F8 / 0x75F8)
    FarCall(cs1, 0x75FD, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7600);
    // AND AX,0x7f (0000_75FD / 0x75FD)
    AX &= 0x7F;
    CheckExternalEvents(cs1, 0x7603);
    // ADD AX,0x5a (0000_7600 / 0x7600)
    AX += 0x5A;
    CheckExternalEvents(cs1, 0x7606);
    // ADD word ptr [BP + -0x28],AX (0000_7603 / 0x7603)
    UInt16[SS, (ushort)(BP - 0x28)] += AX;
    CheckExternalEvents(cs1, 0x7609);
    // INC word ptr [BP + -0xc] (0000_7606 / 0x7606)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0xC)]);
    label_0000_7609_07609:
    CheckExternalEvents(cs1, 0x760C);
    // MOV AX,word ptr [BP + -0x8] (0000_7609 / 0x7609)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x760F);
    // CMP word ptr [BP + -0xc],AX (0000_760C / 0x760C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], AX);
    CheckExternalEvents(cs1, 0x7611);
    // JL 0x0000:75f8 (0000_760F / 0x760F)
    if(SignFlag != OverflowFlag) {
      goto label_0000_75F8_075F8;
    }
    CheckExternalEvents(cs1, 0x7614);
    // MOV AX,word ptr [BP + -0x4] (0000_7611 / 0x7611)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x7617);
    // IMUL word ptr [BP + -0x28] (0000_7614 / 0x7614)
    int resImul0000_7614 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x28)]);
    AX = (ushort)(resImul0000_7614);
    DX = (ushort)(resImul0000_7614 >> 16);
    CheckExternalEvents(cs1, 0x761A);
    // MOV word ptr [BP + -0x28],AX (0000_7617 / 0x7617)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x761D);
    // MOV AX,0xf40 (0000_761A / 0x761A)
    AX = 0xF40;
    CheckExternalEvents(cs1, 0x761E);
    // PUSH DS (0000_761D / 0x761D)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x761F);
    // PUSH AX (0000_761E / 0x761E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7624);
    // CALLF 0x1000:8055 (0000_761F / 0x761F)
    FarCall(cs1, 0x7624, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7627);
    // ADD SP,0x4 (0000_7624 / 0x7624)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x762C);
    // CALLF 0x0000:3fa2 (0000_7627 / 0x7627)
    FarCall(cs1, 0x762C, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x762F);
    // PUSH word ptr [BP + -0x28] (0000_762C / 0x762C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs1, 0x7634);
    // CALLF 0x1000:8b23 (0000_762F / 0x762F)
    FarCall(cs1, 0x7634, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs1, 0x7637);
    // ADD SP,0x2 (0000_7634 / 0x7634)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x763A);
    // MOV AX,0xf65 (0000_7637 / 0x7637)
    AX = 0xF65;
    CheckExternalEvents(cs1, 0x763B);
    // PUSH DS (0000_763A / 0x763A)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x763C);
    // PUSH AX (0000_763B / 0x763B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x763F);
    // MOV AX,0x12 (0000_763C / 0x763C)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7642);
    // MOV DX,0x2a02 (0000_763F / 0x763F)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7643);
    // PUSH DX (0000_7642 / 0x7642)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7644);
    // PUSH AX (0000_7643 / 0x7643)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7649);
    // CALLF 0x1000:da58 (0000_7644 / 0x7644)
    FarCall(cs1, 0x7649, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs1, 0x764C);
    // ADD SP,0x8 (0000_7649 / 0x7649)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x7650);
    // CMP word ptr [BP + -0x8],0x1 (0000_764C / 0x764C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs1, 0x7652);
    // JLE 0x0000:7667 (0000_7650 / 0x7650)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_7667_07667;
    }
    CheckExternalEvents(cs1, 0x7655);
    // MOV AX,0xf9e (0000_7652 / 0x7652)
    AX = 0xF9E;
    CheckExternalEvents(cs1, 0x7656);
    // PUSH DS (0000_7655 / 0x7655)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7657);
    // PUSH AX (0000_7656 / 0x7656)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x765A);
    // MOV AX,0x12 (0000_7657 / 0x7657)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x765D);
    // MOV DX,0x2a02 (0000_765A / 0x765A)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x765E);
    // PUSH DX (0000_765D / 0x765D)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x765F);
    // PUSH AX (0000_765E / 0x765E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7664);
    // CALLF 0x1000:da12 (0000_765F / 0x765F)
    FarCall(cs1, 0x7664, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs1, 0x7667);
    // ADD SP,0x8 (0000_7664 / 0x7664)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    label_0000_7667_07667:
    CheckExternalEvents(cs1, 0x766A);
    // MOV AX,0xfa0 (0000_7667 / 0x7667)
    AX = 0xFA0;
    CheckExternalEvents(cs1, 0x766B);
    // PUSH DS (0000_766A / 0x766A)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x766C);
    // PUSH AX (0000_766B / 0x766B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x766F);
    // MOV AX,0x12 (0000_766C / 0x766C)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7672);
    // MOV DX,0x2a02 (0000_766F / 0x766F)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7673);
    // PUSH DX (0000_7672 / 0x7672)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7674);
    // PUSH AX (0000_7673 / 0x7673)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7679);
    // CALLF 0x1000:da12 (0000_7674 / 0x7674)
    FarCall(cs1, 0x7679, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs1, 0x767C);
    // ADD SP,0x8 (0000_7679 / 0x7679)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0x767F);
    // MOV AX,0x12 (0000_767C / 0x767C)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7682);
    // MOV DX,0x2a02 (0000_767F / 0x767F)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7683);
    // PUSH DX (0000_7682 / 0x7682)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7684);
    // PUSH AX (0000_7683 / 0x7683)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7689);
    // CALLF 0x1000:8055 (0000_7684 / 0x7684)
    FarCall(cs1, 0x7689, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x768C);
    // ADD SP,0x4 (0000_7689 / 0x7689)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7691);
    // CALLF 0x0000:414f (0000_768C / 0x768C)
    FarCall(cs1, 0x7691, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs1, 0x7694);
    // MOV AX,word ptr [BP + -0x28] (0000_7691 / 0x7691)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x7695);
    // CWD  (0000_7694 / 0x7694)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0x7699);
    // MOV ES,word ptr [0x5412] (0000_7695 / 0x7695)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x769E);
    // ADD word ptr ES:[0xd370],AX (0000_7699 / 0x7699)
    // UInt16[ES, 0xD370] += AX;
    UInt16[ES, 0xD370] = Alu.Add16(UInt16[ES, 0xD370], AX);
    CheckExternalEvents(cs1, 0x76A3);
    // ADC word ptr ES:[0xd372],DX (0000_769E / 0x769E)
    UInt16[ES, 0xD372] = Alu.Adc16(UInt16[ES, 0xD372], DX);
    label_0000_76A3_076A3:
    CheckExternalEvents(cs1, 0x76A4);
    // POP SI (0000_76A3 / 0x76A3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x76A5);
    // POP DI (0000_76A4 / 0x76A4)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x76A7);
    // MOV SP,BP (0000_76A5 / 0x76A5)
    SP = BP;
    CheckExternalEvents(cs1, 0x76A8);
    // POP BP (0000_76A7 / 0x76A7)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x76A9);
    // RETF  (0000_76A8 / 0x76A8)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_76A9_076A9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_76A9_076A9:
    CheckExternalEvents(cs1, 0x76AA);
    // PUSH BP (0000_76A9 / 0x76A9)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x76AC);
    // MOV BP,SP (0000_76AA / 0x76AA)
    BP = SP;
    CheckExternalEvents(cs1, 0x76AF);
    // MOV AX,0x14 (0000_76AC / 0x76AC)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x76B4);
    // CALLF 0x1000:cecc (0000_76AF / 0x76AF)
    FarCall(cs1, 0x76B4, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x76B5);
    // PUSH DI (0000_76B4 / 0x76B4)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0x76B6);
    // PUSH SI (0000_76B5 / 0x76B5)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x76B8);
    // SUB AX,AX (0000_76B6 / 0x76B6)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x76BB);
    // MOV word ptr [BP + -0x14],AX (0000_76B8 / 0x76B8)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0x76BE);
    // MOV word ptr [BP + -0x4],AX (0000_76BB / 0x76BB)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x76C1);
    // MOV word ptr [BP + -0xe],AX (0000_76BE / 0x76BE)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    label_0000_76C1_076C1:
    CheckExternalEvents(cs1, 0x76C4);
    // MOV AX,0x11 (0000_76C1 / 0x76C1)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x76C7);
    // IMUL word ptr [BP + -0xe] (0000_76C4 / 0x76C4)
    int resImul0000_76C4 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_76C4);
    DX = (ushort)(resImul0000_76C4 >> 16);
    CheckExternalEvents(cs1, 0x76C9);
    // MOV SI,AX (0000_76C7 / 0x76C7)
    SI = AX;
    CheckExternalEvents(cs1, 0x76CD);
    // MOV ES,word ptr [0x5412] (0000_76C9 / 0x76C9)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x76D3);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0000_76CD / 0x76CD)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0x76D5);
    // JZ 0x0000:76eb (0000_76D3 / 0x76D3)
    if(ZeroFlag) {
      goto label_0000_76EB_076EB;
    }
    CheckExternalEvents(cs1, 0x76DA);
    // MOV AL,byte ptr ES:[SI + 0xc61d] (0000_76D5 / 0x76D5)
    AL = UInt8[ES, (ushort)(SI + 0xC61D)];
    CheckExternalEvents(cs1, 0x76DB);
    // CBW  (0000_76DA / 0x76DA)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x76DD);
    // MOV DI,AX (0000_76DB / 0x76DB)
    DI = AX;
    CheckExternalEvents(cs1, 0x76E0);
    // CMP word ptr [BP + -0x14],DI (0000_76DD / 0x76DD)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x14)], DI);
    CheckExternalEvents(cs1, 0x76E2);
    // JGE 0x0000:76eb (0000_76E0 / 0x76E0)
    if(SignFlag == OverflowFlag) {
      goto label_0000_76EB_076EB;
    }
    CheckExternalEvents(cs1, 0x76E5);
    // MOV AX,word ptr [BP + -0xe] (0000_76E2 / 0x76E2)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0x76E8);
    // MOV word ptr [BP + -0x4],AX (0000_76E5 / 0x76E5)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x76EB);
    // MOV word ptr [BP + -0x14],DI (0000_76E8 / 0x76E8)
    UInt16[SS, (ushort)(BP - 0x14)] = DI;
    label_0000_76EB_076EB:
    CheckExternalEvents(cs1, 0x76EE);
    // INC word ptr [BP + -0xe] (0000_76EB / 0x76EB)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0x76F2);
    // CMP word ptr [BP + -0xe],0x8 (0000_76EE / 0x76EE)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x8);
    CheckExternalEvents(cs1, 0x76F4);
    // JL 0x0000:76c1 (0000_76F2 / 0x76F2)
    if(SignFlag != OverflowFlag) {
      goto label_0000_76C1_076C1;
    }
    CheckExternalEvents(cs1, 0x76F9);
    // MOV word ptr [BP + -0xe],0x0 (0000_76F4 / 0x76F4)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0x76FC);
    // JMP 0x0000:7a00 (0000_76F9 / 0x76F9)
    goto label_0000_7A00_07A00;
    label_0000_76FC_076FC:
    CheckExternalEvents(cs1, 0x76FF);
    // INC word ptr [BP + -0x10] (0000_76FC / 0x76FC)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    CheckExternalEvents(cs1, 0x7703);
    // CMP word ptr [BP + -0x10],0x10 (0000_76FF / 0x76FF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x10);
    CheckExternalEvents(cs1, 0x7705);
    // JNZ 0x0000:770a (0000_7703 / 0x7703)
    if(!ZeroFlag) {
      goto label_0000_770A_0770A;
    }
    CheckExternalEvents(cs1, 0x770A);
    // MOV word ptr [BP + -0x10],0x0 (0000_7705 / 0x7705)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x0;
    label_0000_770A_0770A:
    CheckExternalEvents(cs1, 0x770D);
    // MOV BX,word ptr [BP + -0x10] (0000_770A / 0x770A)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0x770F);
    // SHL BX,0x1 (0000_770D / 0x770D)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7713);
    // MOV ES,word ptr [0x5416] (0000_770F / 0x770F)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x7719);
    // CMP word ptr ES:[BX + 0x393c],0x0 (0000_7713 / 0x7713)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x393C)], 0x0);
    CheckExternalEvents(cs1, 0x771B);
    // JZ 0x0000:76fc (0000_7719 / 0x7719)
    if(ZeroFlag) {
      goto label_0000_76FC_076FC;
    }
    CheckExternalEvents(cs1, 0x771E);
    // MOV BX,word ptr [BP + -0x10] (0000_771B / 0x771B)
    BX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0x7720);
    // SHL BX,0x1 (0000_771E / 0x771E)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7727);
    // MOV word ptr ES:[BX + 0x393c],0x0 (0000_7720 / 0x7720)
    UInt16[ES, (ushort)(BX + 0x393C)] = 0x0;
    CheckExternalEvents(cs1, 0x772C);
    // MOV word ptr [BP + -0xc],0x0 (0000_7727 / 0x7727)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x0;
    CheckExternalEvents(cs1, 0x7731);
    // MOV word ptr [BP + -0x6],0x0 (0000_772C / 0x772C)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_7731_07731:
    CheckExternalEvents(cs1, 0x7734);
    // MOV BX,word ptr [BP + -0x6] (0000_7731 / 0x7731)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7736);
    // SHL BX,0x1 (0000_7734 / 0x7734)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x773A);
    // MOV ES,word ptr [0x5416] (0000_7736 / 0x7736)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x7740);
    // CMP word ptr ES:[BX + 0x393c],0x0 (0000_773A / 0x773A)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x393C)], 0x0);
    CheckExternalEvents(cs1, 0x7742);
    // JZ 0x0000:7745 (0000_7740 / 0x7740)
    if(ZeroFlag) {
      goto label_0000_7745_07745;
    }
    CheckExternalEvents(cs1, 0x7745);
    // INC word ptr [BP + -0xc] (0000_7742 / 0x7742)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_0000_7745_07745:
    CheckExternalEvents(cs1, 0x7748);
    // INC word ptr [BP + -0x6] (0000_7745 / 0x7745)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0x774C);
    // CMP word ptr [BP + -0x6],0x10 (0000_7748 / 0x7748)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x10);
    CheckExternalEvents(cs1, 0x774E);
    // JL 0x0000:7731 (0000_774C / 0x774C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7731_07731;
    }
    CheckExternalEvents(cs1, 0x7751);
    // MOV AX,word ptr [BP + -0x10] (0000_774E / 0x774E)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0x7754);
    // MOV word ptr [BP + -0x2],AX (0000_7751 / 0x7751)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x7757);
    // CMP AX,0xc (0000_7754 / 0x7754)
    Alu.Sub16(AX, 0xC);
    CheckExternalEvents(cs1, 0x7759);
    // JL 0x0000:775d (0000_7757 / 0x7757)
    if(SignFlag != OverflowFlag) {
      goto label_0000_775D_0775D;
    }
    CheckExternalEvents(cs1, 0x775D);
    // SUB word ptr [BP + -0x2],0x8 (0000_7759 / 0x7759)
    // UInt16[SS, (ushort)(BP - 0x2)] -= 0x8;
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x8);
    label_0000_775D_0775D:
    CheckExternalEvents(cs1, 0x7762);
    // MOV word ptr [BP + -0x8],0x1 (0000_775D / 0x775D)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs1, 0x7765);
    // MOV AX,0x7d (0000_7762 / 0x7762)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7768);
    // IMUL word ptr [BP + -0x2] (0000_7765 / 0x7765)
    int resImul0000_7765 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_7765);
    DX = (ushort)(resImul0000_7765 >> 16);
    CheckExternalEvents(cs1, 0x776A);
    // MOV SI,AX (0000_7768 / 0x7768)
    SI = AX;
    CheckExternalEvents(cs1, 0x776E);
    // MOV ES,word ptr [0x5412] (0000_776A / 0x776A)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7774);
    // CMP byte ptr ES:[SI + 0xc799],0x3 (0000_776E / 0x776E)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC799)], 0x3);
    CheckExternalEvents(cs1, 0x7776);
    // JZ 0x0000:7786 (0000_7774 / 0x7774)
    if(ZeroFlag) {
      goto label_0000_7786_07786;
    }
    CheckExternalEvents(cs1, 0x777C);
    // CMP byte ptr ES:[SI + 0xc79a],0x2 (0000_7776 / 0x7776)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC79A)], 0x2);
    CheckExternalEvents(cs1, 0x777E);
    // JZ 0x0000:7786 (0000_777C / 0x777C)
    if(ZeroFlag) {
      goto label_0000_7786_07786;
    }
    CheckExternalEvents(cs1, 0x7784);
    // CMP byte ptr ES:[SI + 0xc743],0x0 (0000_777E / 0x777E)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC743)], 0x0);
    CheckExternalEvents(cs1, 0x7786);
    // JNZ 0x0000:7791 (0000_7784 / 0x7784)
    if(!ZeroFlag) {
      goto label_0000_7791_07791;
    }
    label_0000_7786_07786:
    CheckExternalEvents(cs1, 0x778A);
    // CMP word ptr [BP + -0x14],0x4 (0000_7786 / 0x7786)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x14)], 0x4);
    CheckExternalEvents(cs1, 0x778C);
    // JGE 0x0000:7791 (0000_778A / 0x778A)
    if(SignFlag == OverflowFlag) {
      goto label_0000_7791_07791;
    }
    CheckExternalEvents(cs1, 0x7791);
    // MOV word ptr [BP + -0x8],0x0 (0000_778C / 0x778C)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0000_7791_07791:
    CheckExternalEvents(cs1, 0x7795);
    // CMP word ptr [BP + -0x8],0x0 (0000_7791 / 0x7791)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs1, 0x7797);
    // JNZ 0x0000:779a (0000_7795 / 0x7795)
    if(!ZeroFlag) {
      goto label_0000_779A_0779A;
    }
    CheckExternalEvents(cs1, 0x779A);
    // JMP 0x0000:7965 (0000_7797 / 0x7797)
    goto label_0000_7965_07965;
    label_0000_779A_0779A:
    CheckExternalEvents(cs1, 0x779D);
    // MOV AX,0x11 (0000_779A / 0x779A)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x77A0);
    // IMUL word ptr [BP + -0x4] (0000_779D / 0x779D)
    int resImul0000_779D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_779D);
    DX = (ushort)(resImul0000_779D >> 16);
    CheckExternalEvents(cs1, 0x77A2);
    // MOV BX,AX (0000_77A0 / 0x77A0)
    BX = AX;
    CheckExternalEvents(cs1, 0x77A6);
    // MOV ES,word ptr [0x5412] (0000_77A2 / 0x77A2)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x77AB);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_77A6 / 0x77A6)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x77AC);
    // CBW  (0000_77AB / 0x77AB)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x77AE);
    // MOV BX,AX (0000_77AC / 0x77AC)
    BX = AX;
    CheckExternalEvents(cs1, 0x77B0);
    // SHL BX,0x1 (0000_77AE / 0x77AE)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x77B2);
    // SHL BX,0x1 (0000_77B0 / 0x77B0)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x77B6);
    // MOV ES,word ptr [0x5414] (0000_77B2 / 0x77B2)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x77BB);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_77B6 / 0x77B6)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x77C0);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_77BB / 0x77BB)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x77C5);
    // CALLF 0x1000:8055 (0000_77C0 / 0x77C0)
    FarCall(cs1, 0x77C5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x77C8);
    // ADD SP,0x4 (0000_77C5 / 0x77C5)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x77CB);
    // MOV AX,0x101d (0000_77C8 / 0x77C8)
    AX = 0x101D;
    CheckExternalEvents(cs1, 0x77CC);
    // PUSH DS (0000_77CB / 0x77CB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x77CD);
    // PUSH AX (0000_77CC / 0x77CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x77D0);
    // MOV AX,0x12 (0000_77CD / 0x77CD)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x77D3);
    // MOV DX,0x2a02 (0000_77D0 / 0x77D0)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x77D4);
    // PUSH DX (0000_77D3 / 0x77D3)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x77D5);
    // PUSH AX (0000_77D4 / 0x77D4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x77DA);
    // CALLF 0x1000:da58 (0000_77D5 / 0x77D5)
    FarCall(cs1, 0x77DA, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs1, 0x77DD);
    // ADD SP,0x8 (0000_77DA / 0x77DA)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0x77E0);
    // MOV BX,word ptr [BP + -0x2] (0000_77DD / 0x77DD)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x77E4);
    // MOV ES,word ptr [0x5418] (0000_77E0 / 0x77E0)
    ES = UInt16[DS, 0x5418];
    CheckExternalEvents(cs1, 0x77E9);
    // MOV AL,byte ptr ES:[BX + 0x323e] (0000_77E4 / 0x77E4)
    AL = UInt8[ES, (ushort)(BX + 0x323E)];
    CheckExternalEvents(cs1, 0x77ED);
    // MOV ES,word ptr [0x541a] (0000_77E9 / 0x77E9)
    ES = UInt16[DS, 0x541A];
    CheckExternalEvents(cs1, 0x77F1);
    // MOV ES:[0x22],AL (0000_77ED / 0x77ED)
    UInt8[ES, 0x22] = AL;
    CheckExternalEvents(cs1, 0x77F4);
    // MOV AX,0x7d (0000_77F1 / 0x77F1)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x77F6);
    // IMUL BX (0000_77F4 / 0x77F4)
    int resImul0000_77F4 = Alu.Imul16((short)AX, (short)BX);
    AX = (ushort)(resImul0000_77F4);
    DX = (ushort)(resImul0000_77F4 >> 16);
    CheckExternalEvents(cs1, 0x77F8);
    // MOV BX,AX (0000_77F6 / 0x77F6)
    BX = AX;
    CheckExternalEvents(cs1, 0x77FC);
    // LEA AX,[BX + 0xc725] (0000_77F8 / 0x77F8)
    AX = (ushort)(BX + 0xC725);
    CheckExternalEvents(cs1, 0x77FF);
    // MOV DX,0x2a02 (0000_77FC / 0x77FC)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7800);
    // PUSH DX (0000_77FF / 0x77FF)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7801);
    // PUSH AX (0000_7800 / 0x7800)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7804);
    // MOV AX,0x12 (0000_7801 / 0x7801)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7807);
    // MOV DX,0x2a02 (0000_7804 / 0x7804)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7808);
    // PUSH DX (0000_7807 / 0x7807)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7809);
    // PUSH AX (0000_7808 / 0x7808)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x780E);
    // CALLF 0x1000:da12 (0000_7809 / 0x7809)
    FarCall(cs1, 0x780E, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs1, 0x7811);
    // ADD SP,0x8 (0000_780E / 0x780E)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0x7814);
    // MOV AX,0x12 (0000_7811 / 0x7811)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7817);
    // MOV DX,0x2a02 (0000_7814 / 0x7814)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7818);
    // PUSH DX (0000_7817 / 0x7817)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7819);
    // PUSH AX (0000_7818 / 0x7818)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x781E);
    // CALLF 0x1000:da8e (0000_7819 / 0x7819)
    FarCall(cs1, 0x781E, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0x7821);
    // ADD SP,0x4 (0000_781E / 0x781E)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x7822);
    // DEC AX (0000_7821 / 0x7821)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs1, 0x7825);
    // MOV word ptr [BP + -0x6],AX (0000_7822 / 0x7822)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x7827);
    // JMP 0x0000:782f (0000_7825 / 0x7825)
    goto label_0000_782F_0782F;
    label_0000_7827_07827:
    CheckExternalEvents(cs1, 0x782C);
    // MOV word ptr [BP + -0x6],0x0 (0000_7827 / 0x7827)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_782C_0782C:
    CheckExternalEvents(cs1, 0x782F);
    // DEC word ptr [BP + -0x6] (0000_782C / 0x782C)
    UInt16[SS, (ushort)(BP - 0x6)]--;
    label_0000_782F_0782F:
    CheckExternalEvents(cs1, 0x7833);
    // CMP word ptr [BP + -0x6],0x0 (0000_782F / 0x782F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs1, 0x7835);
    // JLE 0x0000:784c (0000_7833 / 0x7833)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_784C_0784C;
    }
    CheckExternalEvents(cs1, 0x7838);
    // MOV BX,word ptr [BP + -0x6] (0000_7835 / 0x7835)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x783C);
    // MOV ES,word ptr [0x541a] (0000_7838 / 0x7838)
    ES = UInt16[DS, 0x541A];
    CheckExternalEvents(cs1, 0x7842);
    // CMP byte ptr ES:[BX + 0x12],0x20 (0000_783C / 0x783C)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x12)], 0x20);
    CheckExternalEvents(cs1, 0x7844);
    // JNZ 0x0000:7827 (0000_7842 / 0x7842)
    if(!ZeroFlag) {
      goto label_0000_7827_07827;
    }
    CheckExternalEvents(cs1, 0x784A);
    // MOV byte ptr ES:[BX + 0x12],0x0 (0000_7844 / 0x7844)
    UInt8[ES, (ushort)(BX + 0x12)] = 0x0;
    CheckExternalEvents(cs1, 0x784C);
    // JMP 0x0000:782c (0000_784A / 0x784A)
    goto label_0000_782C_0782C;
    label_0000_784C_0784C:
    CheckExternalEvents(cs1, 0x784F);
    // MOV AX,0x12 (0000_784C / 0x784C)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7852);
    // MOV DX,0x2a02 (0000_784F / 0x784F)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7853);
    // PUSH DX (0000_7852 / 0x7852)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7854);
    // PUSH AX (0000_7853 / 0x7853)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7859);
    // CALLF 0x1000:8055 (0000_7854 / 0x7854)
    FarCall(cs1, 0x7859, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x785C);
    // ADD SP,0x4 (0000_7859 / 0x7859)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7861);
    // CALLF 0x0000:417e (0000_785C / 0x785C)
    FarCall(cs1, 0x7861, ghidra_guess_0000_417E_0417E);
    CheckExternalEvents(cs1, 0x7866);
    // MOV word ptr [BP + -0x12],0x1 (0000_7861 / 0x7861)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs1, 0x786B);
    // MOV word ptr [BP + -0xa],0x0 (0000_7866 / 0x7866)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs1, 0x786D);
    // JMP 0x0000:7870 (0000_786B / 0x786B)
    goto label_0000_7870_07870;
    label_0000_786D_0786D:
    CheckExternalEvents(cs1, 0x7870);
    // INC word ptr [BP + -0xa] (0000_786D / 0x786D)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    label_0000_7870_07870:
    CheckExternalEvents(cs1, 0x7874);
    // CMP word ptr [BP + -0xa],0x4 (0000_7870 / 0x7870)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], 0x4);
    CheckExternalEvents(cs1, 0x7876);
    // JL 0x0000:7879 (0000_7874 / 0x7874)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7879_07879;
    }
    CheckExternalEvents(cs1, 0x7879);
    // JMP 0x0000:79be (0000_7876 / 0x7876)
    goto label_0000_79BE_079BE;
    label_0000_7879_07879:
    CheckExternalEvents(cs1, 0x787C);
    // MOV AX,0x7d (0000_7879 / 0x7879)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x787F);
    // IMUL word ptr [BP + -0xa] (0000_787C / 0x787C)
    int resImul0000_787C = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_787C);
    DX = (ushort)(resImul0000_787C >> 16);
    CheckExternalEvents(cs1, 0x7881);
    // MOV BX,AX (0000_787F / 0x787F)
    BX = AX;
    CheckExternalEvents(cs1, 0x7885);
    // MOV ES,word ptr [0x5412] (0000_7881 / 0x7881)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x788B);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0000_7885 / 0x7885)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x788D);
    // JNZ 0x0000:786d (0000_788B / 0x788B)
    if(!ZeroFlag) {
      goto label_0000_786D_0786D;
    }
    CheckExternalEvents(cs1, 0x7892);
    // MOV word ptr [BP + -0x6],0x1 (0000_788D / 0x788D)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x1;
    label_0000_7892_07892:
    CheckExternalEvents(cs1, 0x7895);
    // MOV AX,0x7d (0000_7892 / 0x7892)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7898);
    // IMUL word ptr [BP + -0x2] (0000_7895 / 0x7895)
    int resImul0000_7895 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_7895);
    DX = (ushort)(resImul0000_7895 >> 16);
    CheckExternalEvents(cs1, 0x789A);
    // MOV BX,AX (0000_7898 / 0x7898)
    BX = AX;
    CheckExternalEvents(cs1, 0x789D);
    // ADD BX,word ptr [BP + -0x6] (0000_789A / 0x789A)
    // BX += UInt16[SS, (ushort)(BP - 0x6)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x78A2);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_789D / 0x789D)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0x78A4);
    // MOV CX,AX (0000_78A2 / 0x78A2)
    CX = AX;
    CheckExternalEvents(cs1, 0x78A7);
    // MOV AX,0x7d (0000_78A4 / 0x78A4)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x78AA);
    // IMUL word ptr [BP + -0xa] (0000_78A7 / 0x78A7)
    int resImul0000_78A7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_78A7);
    DX = (ushort)(resImul0000_78A7 >> 16);
    CheckExternalEvents(cs1, 0x78AC);
    // MOV BX,AX (0000_78AA / 0x78AA)
    BX = AX;
    CheckExternalEvents(cs1, 0x78AF);
    // ADD BX,word ptr [BP + -0x6] (0000_78AC / 0x78AC)
    // BX += UInt16[SS, (ushort)(BP - 0x6)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x78B4);
    // MOV byte ptr ES:[BX + 0xc724],CL (0000_78AF / 0x78AF)
    UInt8[ES, (ushort)(BX + 0xC724)] = CL;
    CheckExternalEvents(cs1, 0x78B7);
    // INC word ptr [BP + -0x6] (0000_78B4 / 0x78B4)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0x78BB);
    // CMP word ptr [BP + -0x6],0x7d (0000_78B7 / 0x78B7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x7D);
    CheckExternalEvents(cs1, 0x78BD);
    // JL 0x0000:7892 (0000_78BB / 0x78BB)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7892_07892;
    }
    CheckExternalEvents(cs1, 0x78C0);
    // MOV AX,0x7d (0000_78BD / 0x78BD)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x78C3);
    // IMUL word ptr [BP + -0xa] (0000_78C0 / 0x78C0)
    int resImul0000_78C0 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_78C0);
    DX = (ushort)(resImul0000_78C0 >> 16);
    CheckExternalEvents(cs1, 0x78C5);
    // MOV SI,AX (0000_78C3 / 0x78C3)
    SI = AX;
    CheckExternalEvents(cs1, 0x78C8);
    // MOV BX,word ptr [BP + -0x2] (0000_78C5 / 0x78C5)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x78CC);
    // MOV ES,word ptr [0x5418] (0000_78C8 / 0x78C8)
    ES = UInt16[DS, 0x5418];
    CheckExternalEvents(cs1, 0x78D1);
    // MOV AL,byte ptr ES:[BX + 0x323e] (0000_78CC / 0x78CC)
    AL = UInt8[ES, (ushort)(BX + 0x323E)];
    CheckExternalEvents(cs1, 0x78D5);
    // MOV ES,word ptr [0x5412] (0000_78D1 / 0x78D1)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x78DA);
    // MOV byte ptr ES:[SI + 0xc724],AL (0000_78D5 / 0x78D5)
    UInt8[ES, (ushort)(SI + 0xC724)] = AL;
    CheckExternalEvents(cs1, 0x78DD);
    // MOV AL,byte ptr [BP + -0xe] (0000_78DA / 0x78DA)
    AL = UInt8[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0x78E2);
    // MOV byte ptr ES:[SI + 0xc79d],AL (0000_78DD / 0x78DD)
    UInt8[ES, (ushort)(SI + 0xC79D)] = AL;
    CheckExternalEvents(cs1, 0x78E5);
    // MOV AL,byte ptr [BP + -0xa] (0000_78E2 / 0x78E2)
    AL = UInt8[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x78E7);
    // MOV CX,AX (0000_78E5 / 0x78E5)
    CX = AX;
    CheckExternalEvents(cs1, 0x78EA);
    // MOV AX,0x11 (0000_78E7 / 0x78E7)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x78ED);
    // IMUL word ptr [BP + -0xe] (0000_78EA / 0x78EA)
    int resImul0000_78EA = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_78EA);
    DX = (ushort)(resImul0000_78EA >> 16);
    CheckExternalEvents(cs1, 0x78EF);
    // MOV BX,AX (0000_78ED / 0x78ED)
    BX = AX;
    CheckExternalEvents(cs1, 0x78F4);
    // MOV byte ptr ES:[BX + 0xc620],CL (0000_78EF / 0x78EF)
    UInt8[ES, (ushort)(BX + 0xC620)] = CL;
    CheckExternalEvents(cs1, 0x78F7);
    // MOV BX,word ptr [BP + -0xa] (0000_78F4 / 0x78F4)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x78FB);
    // MOV ES,word ptr [0x541c] (0000_78F7 / 0x78F7)
    ES = UInt16[DS, 0x541C];
    CheckExternalEvents(cs1, 0x7901);
    // MOV byte ptr ES:[BX + 0xd55e],0x0 (0000_78FB / 0x78FB)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x0;
    CheckExternalEvents(cs1, 0x7905);
    // MOV ES,word ptr [0x5412] (0000_7901 / 0x7901)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x790B);
    // CMP byte ptr ES:[SI + 0xc724],0x4c (0000_7905 / 0x7905)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC724)], 0x4C);
    CheckExternalEvents(cs1, 0x790D);
    // JZ 0x0000:791a (0000_790B / 0x790B)
    if(ZeroFlag) {
      goto label_0000_791A_0791A;
    }
    CheckExternalEvents(cs1, 0x7910);
    // MOV BX,word ptr [BP + -0xa] (0000_790D / 0x790D)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x7914);
    // MOV ES,word ptr [0x541c] (0000_7910 / 0x7910)
    ES = UInt16[DS, 0x541C];
    CheckExternalEvents(cs1, 0x791A);
    // MOV byte ptr ES:[BX + 0xd55e],0x92 (0000_7914 / 0x7914)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x92;
    label_0000_791A_0791A:
    CheckExternalEvents(cs1, 0x791D);
    // MOV AX,0x7d (0000_791A / 0x791A)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7920);
    // IMUL word ptr [BP + -0xa] (0000_791D / 0x791D)
    int resImul0000_791D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_791D);
    DX = (ushort)(resImul0000_791D >> 16);
    CheckExternalEvents(cs1, 0x7922);
    // MOV SI,AX (0000_7920 / 0x7920)
    SI = AX;
    CheckExternalEvents(cs1, 0x7924);
    // MOV AL,0x1 (0000_7922 / 0x7922)
    AL = 0x1;
    CheckExternalEvents(cs1, 0x7928);
    // MOV ES,word ptr [0x5412] (0000_7924 / 0x7924)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x792D);
    // MOV byte ptr ES:[SI + 0xc79a],AL (0000_7928 / 0x7928)
    UInt8[ES, (ushort)(SI + 0xC79A)] = AL;
    CheckExternalEvents(cs1, 0x7932);
    // MOV byte ptr ES:[SI + 0xc799],AL (0000_792D / 0x792D)
    UInt8[ES, (ushort)(SI + 0xC799)] = AL;
    CheckExternalEvents(cs1, 0x7938);
    // CMP byte ptr ES:[SI + 0xc744],0x0 (0000_7932 / 0x7932)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC744)], 0x0);
    CheckExternalEvents(cs1, 0x793A);
    // JNZ 0x0000:793f (0000_7938 / 0x7938)
    if(!ZeroFlag) {
      goto label_0000_793F_0793F;
    }
    CheckExternalEvents(cs1, 0x793F);
    // MOV byte ptr ES:[SI + 0xc744],AL (0000_793A / 0x793A)
    UInt8[ES, (ushort)(SI + 0xC744)] = AL;
    label_0000_793F_0793F:
    CheckExternalEvents(cs1, 0x7942);
    // MOV AX,0x7d (0000_793F / 0x793F)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7945);
    // IMUL word ptr [BP + -0xa] (0000_7942 / 0x7942)
    int resImul0000_7942 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_7942);
    DX = (ushort)(resImul0000_7942 >> 16);
    CheckExternalEvents(cs1, 0x7947);
    // MOV BX,AX (0000_7945 / 0x7945)
    BX = AX;
    CheckExternalEvents(cs1, 0x794D);
    // CMP byte ptr ES:[BX + 0xc743],0x0 (0000_7947 / 0x7947)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC743)], 0x0);
    CheckExternalEvents(cs1, 0x794F);
    // JNZ 0x0000:795d (0000_794D / 0x794D)
    if(!ZeroFlag) {
      goto label_0000_795D_0795D;
    }
    CheckExternalEvents(cs1, 0x7952);
    // MOV AX,0x7d (0000_794F / 0x794F)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7955);
    // IMUL word ptr [BP + -0xa] (0000_7952 / 0x7952)
    int resImul0000_7952 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xA)]);
    AX = (ushort)(resImul0000_7952);
    DX = (ushort)(resImul0000_7952 >> 16);
    CheckExternalEvents(cs1, 0x7957);
    // MOV BX,AX (0000_7955 / 0x7955)
    BX = AX;
    CheckExternalEvents(cs1, 0x795D);
    // MOV byte ptr ES:[BX + 0xc743],0x1 (0000_7957 / 0x7957)
    UInt8[ES, (ushort)(BX + 0xC743)] = 0x1;
    label_0000_795D_0795D:
    CheckExternalEvents(cs1, 0x7962);
    // MOV word ptr [BP + -0xa],0x4 (0000_795D / 0x795D)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x4;
    CheckExternalEvents(cs1, 0x7965);
    // JMP 0x0000:786d (0000_7962 / 0x7962)
    goto label_0000_786D_0786D;
    label_0000_7965_07965:
    CheckExternalEvents(cs1, 0x7968);
    // MOV AX,0x102f (0000_7965 / 0x7965)
    AX = 0x102F;
    CheckExternalEvents(cs1, 0x7969);
    // PUSH DS (0000_7968 / 0x7968)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x796A);
    // PUSH AX (0000_7969 / 0x7969)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x796D);
    // MOV AX,0x12 (0000_796A / 0x796A)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x7970);
    // MOV DX,0x2a02 (0000_796D / 0x796D)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x7971);
    // PUSH DX (0000_7970 / 0x7970)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7972);
    // PUSH AX (0000_7971 / 0x7971)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7977);
    // CALLF 0x1000:da58 (0000_7972 / 0x7972)
    FarCall(cs1, 0x7977, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs1, 0x797A);
    // ADD SP,0x8 (0000_7977 / 0x7977)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0x797D);
    // MOV BX,word ptr [BP + -0x2] (0000_797A / 0x797A)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x7981);
    // MOV ES,word ptr [0x5418] (0000_797D / 0x797D)
    ES = UInt16[DS, 0x5418];
    CheckExternalEvents(cs1, 0x7986);
    // MOV AL,byte ptr ES:[BX + 0x323e] (0000_7981 / 0x7981)
    AL = UInt8[ES, (ushort)(BX + 0x323E)];
    CheckExternalEvents(cs1, 0x798A);
    // MOV ES,word ptr [0x541a] (0000_7986 / 0x7986)
    ES = UInt16[DS, 0x541A];
    CheckExternalEvents(cs1, 0x798E);
    // MOV ES:[0x2d],AL (0000_798A / 0x798A)
    UInt8[ES, 0x2D] = AL;
    CheckExternalEvents(cs1, 0x7991);
    // MOV AX,0x7d (0000_798E / 0x798E)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x7993);
    // IMUL BX (0000_7991 / 0x7991)
    int resImul0000_7991 = Alu.Imul16((short)AX, (short)BX);
    AX = (ushort)(resImul0000_7991);
    DX = (ushort)(resImul0000_7991 >> 16);
    CheckExternalEvents(cs1, 0x7995);
    // MOV BX,AX (0000_7993 / 0x7993)
    BX = AX;
    CheckExternalEvents(cs1, 0x7999);
    // LEA AX,[BX + 0xc725] (0000_7995 / 0x7995)
    AX = (ushort)(BX + 0xC725);
    CheckExternalEvents(cs1, 0x799C);
    // MOV DX,0x2a02 (0000_7999 / 0x7999)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x799D);
    // PUSH DX (0000_799C / 0x799C)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x799E);
    // PUSH AX (0000_799D / 0x799D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x79A1);
    // MOV AX,0x12 (0000_799E / 0x799E)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x79A4);
    // MOV DX,0x2a02 (0000_79A1 / 0x79A1)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x79A5);
    // PUSH DX (0000_79A4 / 0x79A4)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x79A6);
    // PUSH AX (0000_79A5 / 0x79A5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x79AB);
    // CALLF 0x1000:da12 (0000_79A6 / 0x79A6)
    FarCall(cs1, 0x79AB, unknown_19EF_3B22_1DA12);
    CheckExternalEvents(cs1, 0x79AE);
    // ADD SP,0x8 (0000_79AB / 0x79AB)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0x79B1);
    // MOV AX,0x12 (0000_79AE / 0x79AE)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x79B4);
    // MOV DX,0x2a02 (0000_79B1 / 0x79B1)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x79B5);
    // PUSH DX (0000_79B4 / 0x79B4)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x79B6);
    // PUSH AX (0000_79B5 / 0x79B5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x79BB);
    // CALLF 0x1000:8055 (0000_79B6 / 0x79B6)
    FarCall(cs1, 0x79BB, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x79BE);
    // ADD SP,0x4 (0000_79BB / 0x79BB)
    SP += 0x4;
    label_0000_79BE_079BE:
    CheckExternalEvents(cs1, 0x79C2);
    // CMP word ptr [BP + -0xc],0x0 (0000_79BE / 0x79BE)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs1, 0x79C4);
    // JNZ 0x0000:79cd (0000_79C2 / 0x79C2)
    if(!ZeroFlag) {
      goto label_0000_79CD_079CD;
    }
    CheckExternalEvents(cs1, 0x79C7);
    // MOV AX,0x9 (0000_79C4 / 0x79C4)
    AX = 0x9;
    CheckExternalEvents(cs1, 0x79CA);
    // MOV word ptr [BP + -0xe],AX (0000_79C7 / 0x79C7)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0x79CD);
    // MOV word ptr [BP + -0x12],AX (0000_79CA / 0x79CA)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    label_0000_79CD_079CD:
    CheckExternalEvents(cs1, 0x79D1);
    // CMP word ptr [BP + -0x12],0x0 (0000_79CD / 0x79CD)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs1, 0x79D3);
    // JNZ 0x0000:79d6 (0000_79D1 / 0x79D1)
    if(!ZeroFlag) {
      goto label_0000_79D6_079D6;
    }
    CheckExternalEvents(cs1, 0x79D6);
    // JMP 0x0000:7ad6 (0000_79D3 / 0x79D3)
    goto label_0000_7AD6_07AD6;
    label_0000_79D6_079D6:
    CheckExternalEvents(cs1, 0x79DB);
    // CALLF 0x0000:414f (0000_79D6 / 0x79D6)
    FarCall(cs1, 0x79DB, ghidra_guess_0000_414F_0414F);
    label_0000_79DB_079DB:
    CheckExternalEvents(cs1, 0x79DF);
    // CMP word ptr [BP + -0xc],0x0 (0000_79DB / 0x79DB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs1, 0x79E1);
    // JNZ 0x0000:79fd (0000_79DF / 0x79DF)
    if(!ZeroFlag) {
      goto label_0000_79FD_079FD;
    }
    CheckExternalEvents(cs1, 0x79E6);
    // CALLF 0x1000:7fe8 (0000_79E1 / 0x79E1)
    FarCall(cs1, 0x79E6, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x79E9);
    // MOV AX,0x104c (0000_79E6 / 0x79E6)
    AX = 0x104C;
    CheckExternalEvents(cs1, 0x79EA);
    // PUSH DS (0000_79E9 / 0x79E9)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x79EB);
    // PUSH AX (0000_79EA / 0x79EA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x79F0);
    // CALLF 0x1000:8055 (0000_79EB / 0x79EB)
    FarCall(cs1, 0x79F0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x79F3);
    // ADD SP,0x4 (0000_79F0 / 0x79F0)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x79F8);
    // CALLF 0x0000:414f (0000_79F3 / 0x79F3)
    FarCall(cs1, 0x79F8, ghidra_guess_0000_414F_0414F);
    CheckExternalEvents(cs1, 0x79FD);
    // MOV word ptr [BP + -0xe],0x9 (0000_79F8 / 0x79F8)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x9;
    label_0000_79FD_079FD:
    CheckExternalEvents(cs1, 0x7A00);
    // INC word ptr [BP + -0xe] (0000_79FD / 0x79FD)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_0000_7A00_07A00:
    CheckExternalEvents(cs1, 0x7A04);
    // CMP word ptr [BP + -0xe],0x8 (0000_7A00 / 0x7A00)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x8);
    CheckExternalEvents(cs1, 0x7A06);
    // JL 0x0000:7a09 (0000_7A04 / 0x7A04)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7A09_07A09;
    }
    CheckExternalEvents(cs1, 0x7A09);
    // JMP 0x0000:7af5 (0000_7A06 / 0x7A06)
    goto label_0000_7AF5_07AF5;
    label_0000_7A09_07A09:
    CheckExternalEvents(cs1, 0x7A0C);
    // MOV AX,0x11 (0000_7A09 / 0x7A09)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7A0F);
    // IMUL word ptr [BP + -0xe] (0000_7A0C / 0x7A0C)
    int resImul0000_7A0C = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_7A0C);
    DX = (ushort)(resImul0000_7A0C >> 16);
    CheckExternalEvents(cs1, 0x7A11);
    // MOV SI,AX (0000_7A0F / 0x7A0F)
    SI = AX;
    CheckExternalEvents(cs1, 0x7A15);
    // MOV ES,word ptr [0x5412] (0000_7A11 / 0x7A11)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7A1B);
    // CMP byte ptr ES:[SI + 0xc614],0xff (0000_7A15 / 0x7A15)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0x7A1D);
    // JZ 0x0000:79fd (0000_7A1B / 0x7A1B)
    if(ZeroFlag) {
      goto label_0000_79FD_079FD;
    }
    CheckExternalEvents(cs1, 0x7A23);
    // CMP byte ptr ES:[SI + 0xc61c],0x0 (0000_7A1D / 0x7A1D)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC61C)], 0x0);
    CheckExternalEvents(cs1, 0x7A25);
    // JZ 0x0000:79fd (0000_7A23 / 0x7A23)
    if(ZeroFlag) {
      goto label_0000_79FD_079FD;
    }
    CheckExternalEvents(cs1, 0x7A2B);
    // CMP byte ptr ES:[SI + 0xc620],0x8 (0000_7A25 / 0x7A25)
    Alu.Sub8(UInt8[ES, (ushort)(SI + 0xC620)], 0x8);
    CheckExternalEvents(cs1, 0x7A2D);
    // JL 0x0000:79fd (0000_7A2B / 0x7A2B)
    if(SignFlag != OverflowFlag) {
      goto label_0000_79FD_079FD;
    }
    CheckExternalEvents(cs1, 0x7A32);
    // CALLF 0x1000:7fe8 (0000_7A2D / 0x7A2D)
    FarCall(cs1, 0x7A32, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x7A35);
    // MOV AX,0x11 (0000_7A32 / 0x7A32)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7A38);
    // IMUL word ptr [BP + -0xe] (0000_7A35 / 0x7A35)
    int resImul0000_7A35 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_7A35);
    DX = (ushort)(resImul0000_7A35 >> 16);
    CheckExternalEvents(cs1, 0x7A3A);
    // MOV BX,AX (0000_7A38 / 0x7A38)
    BX = AX;
    CheckExternalEvents(cs1, 0x7A3E);
    // MOV ES,word ptr [0x5412] (0000_7A3A / 0x7A3A)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7A43);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_7A3E / 0x7A3E)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x7A44);
    // CBW  (0000_7A43 / 0x7A43)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x7A46);
    // MOV BX,AX (0000_7A44 / 0x7A44)
    BX = AX;
    CheckExternalEvents(cs1, 0x7A48);
    // SHL BX,0x1 (0000_7A46 / 0x7A46)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x7A4A);
    // SHL BX,0x1 (0000_7A48 / 0x7A48)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7A4E);
    // MOV ES,word ptr [0x5414] (0000_7A4A / 0x7A4A)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x7A53);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_7A4E / 0x7A4E)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x7A58);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_7A53 / 0x7A53)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x7A5D);
    // CALLF 0x1000:8055 (0000_7A58 / 0x7A58)
    FarCall(cs1, 0x7A5D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7A60);
    // ADD SP,0x4 (0000_7A5D / 0x7A5D)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7A65);
    // MOV word ptr [BP + -0xc],0x1 (0000_7A60 / 0x7A60)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x1;
    CheckExternalEvents(cs1, 0x7A68);
    // MOV AX,0xfae (0000_7A65 / 0x7A65)
    AX = 0xFAE;
    CheckExternalEvents(cs1, 0x7A69);
    // PUSH DS (0000_7A68 / 0x7A68)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7A6A);
    // PUSH AX (0000_7A69 / 0x7A69)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7A6F);
    // CALLF 0x1000:8055 (0000_7A6A / 0x7A6A)
    FarCall(cs1, 0x7A6F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7A72);
    // ADD SP,0x4 (0000_7A6F / 0x7A6F)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7A75);
    // MOV AX,0x1 (0000_7A72 / 0x7A72)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x7A76);
    // PUSH AX (0000_7A75 / 0x7A75)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7A7B);
    // CALLF 0x0000:3113 (0000_7A76 / 0x7A76)
    FarCall(cs1, 0x7A7B, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0x7A7E);
    // ADD SP,0x2 (0000_7A7B / 0x7A7B)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7A80);
    // OR AX,AX (0000_7A7E / 0x7A7E)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x7A82);
    // JNZ 0x0000:7a85 (0000_7A80 / 0x7A80)
    if(!ZeroFlag) {
      goto label_0000_7A85_07A85;
    }
    CheckExternalEvents(cs1, 0x7A85);
    // JMP 0x0000:79db (0000_7A82 / 0x7A82)
    goto label_0000_79DB_079DB;
    label_0000_7A85_07A85:
    CheckExternalEvents(cs1, 0x7A8A);
    // CALLF 0x1000:7fe8 (0000_7A85 / 0x7A85)
    FarCall(cs1, 0x7A8A, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x7A8D);
    // MOV AX,0x11 (0000_7A8A / 0x7A8A)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7A90);
    // IMUL word ptr [BP + -0x4] (0000_7A8D / 0x7A8D)
    int resImul0000_7A8D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_7A8D);
    DX = (ushort)(resImul0000_7A8D >> 16);
    CheckExternalEvents(cs1, 0x7A92);
    // MOV BX,AX (0000_7A90 / 0x7A90)
    BX = AX;
    CheckExternalEvents(cs1, 0x7A96);
    // MOV ES,word ptr [0x5412] (0000_7A92 / 0x7A92)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7A9B);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_7A96 / 0x7A96)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x7A9C);
    // CBW  (0000_7A9B / 0x7A9B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x7A9E);
    // MOV BX,AX (0000_7A9C / 0x7A9C)
    BX = AX;
    CheckExternalEvents(cs1, 0x7AA0);
    // SHL BX,0x1 (0000_7A9E / 0x7A9E)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x7AA2);
    // SHL BX,0x1 (0000_7AA0 / 0x7AA0)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7AA6);
    // MOV ES,word ptr [0x5414] (0000_7AA2 / 0x7AA2)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x7AAB);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_7AA6 / 0x7AA6)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x7AB0);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_7AAB / 0x7AAB)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x7AB5);
    // CALLF 0x1000:8055 (0000_7AB0 / 0x7AB0)
    FarCall(cs1, 0x7AB5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7AB8);
    // ADD SP,0x4 (0000_7AB5 / 0x7AB5)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7ABB);
    // MOV AX,0xfff (0000_7AB8 / 0x7AB8)
    AX = 0xFFF;
    CheckExternalEvents(cs1, 0x7ABC);
    // PUSH DS (0000_7ABB / 0x7ABB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7ABD);
    // PUSH AX (0000_7ABC / 0x7ABC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7AC2);
    // CALLF 0x1000:8055 (0000_7ABD / 0x7ABD)
    FarCall(cs1, 0x7AC2, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7AC5);
    // ADD SP,0x4 (0000_7AC2 / 0x7AC2)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7AC8);
    // MOV AX,0x78 (0000_7AC5 / 0x7AC5)
    AX = 0x78;
    CheckExternalEvents(cs1, 0x7AC9);
    // PUSH AX (0000_7AC8 / 0x7AC8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7ACE);
    // CALLF 0x1000:8ad6 (0000_7AC9 / 0x7AC9)
    FarCall(cs1, 0x7ACE, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs1, 0x7AD1);
    // ADD SP,0x2 (0000_7ACE / 0x7ACE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7AD6);
    // MOV word ptr [BP + -0x12],0x0 (0000_7AD1 / 0x7AD1)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    label_0000_7AD6_07AD6:
    CheckExternalEvents(cs1, 0x7ADB);
    // CALLF 0x1000:aab0 (0000_7AD6 / 0x7AD6)
    FarCall(cs1, 0x7ADB, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7ADE);
    // AND AX,0x3 (0000_7ADB / 0x7ADB)
    // AX &= 0x3;
    AX = Alu.And16(AX, 0x3);
    CheckExternalEvents(cs1, 0x7AE0);
    // MOV SI,AX (0000_7ADE / 0x7ADE)
    SI = AX;
    CheckExternalEvents(cs1, 0x7AE5);
    // CALLF 0x1000:aab0 (0000_7AE0 / 0x7AE0)
    FarCall(cs1, 0x7AE5, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7AE8);
    // AND AX,0x1 (0000_7AE5 / 0x7AE5)
    // AX &= 0x1;
    AX = Alu.And16(AX, 0x1);
    CheckExternalEvents(cs1, 0x7AEB);
    // MOV CX,0xc (0000_7AE8 / 0x7AE8)
    CX = 0xC;
    CheckExternalEvents(cs1, 0x7AED);
    // IMUL CX (0000_7AEB / 0x7AEB)
    int resImul0000_7AEB = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_7AEB);
    DX = (ushort)(resImul0000_7AEB >> 16);
    CheckExternalEvents(cs1, 0x7AEF);
    // ADD AX,SI (0000_7AED / 0x7AED)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    CheckExternalEvents(cs1, 0x7AF2);
    // MOV word ptr [BP + -0x10],AX (0000_7AEF / 0x7AEF)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x7AF5);
    // JMP 0x0000:770a (0000_7AF2 / 0x7AF2)
    goto label_0000_770A_0770A;
    label_0000_7AF5_07AF5:
    CheckExternalEvents(cs1, 0x7AF6);
    // POP SI (0000_7AF5 / 0x7AF5)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x7AF7);
    // POP DI (0000_7AF6 / 0x7AF6)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x7AF9);
    // MOV SP,BP (0000_7AF7 / 0x7AF7)
    SP = BP;
    CheckExternalEvents(cs1, 0x7AFA);
    // POP BP (0000_7AF9 / 0x7AF9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x7AFB);
    // RETF  (0000_7AFA / 0x7AFA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_7AFB_07AFB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_7AFB_07AFB:
    CheckExternalEvents(cs1, 0x7AFC);
    // PUSH BP (0000_7AFB / 0x7AFB)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x7AFE);
    // MOV BP,SP (0000_7AFC / 0x7AFC)
    BP = SP;
    CheckExternalEvents(cs1, 0x7B01);
    // MOV AX,0xe (0000_7AFE / 0x7AFE)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x7B06);
    // CALLF 0x1000:cecc (0000_7B01 / 0x7B01)
    FarCall(cs1, 0x7B06, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x7B07);
    // PUSH SI (0000_7B06 / 0x7B06)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x7B09);
    // SUB AX,AX (0000_7B07 / 0x7B07)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x7B0C);
    // MOV word ptr [BP + -0xc],AX (0000_7B09 / 0x7B09)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x7B0F);
    // MOV word ptr [BP + -0x4],AX (0000_7B0C / 0x7B0C)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x7B12);
    // MOV word ptr [BP + -0x8],AX (0000_7B0F / 0x7B0F)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0x7B15);
    // MOV word ptr [BP + -0xa],AX (0000_7B12 / 0x7B12)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x7B1A);
    // MOV word ptr [BP + -0x6],0x4 (0000_7B15 / 0x7B15)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x4;
    label_0000_7B1A_07B1A:
    CheckExternalEvents(cs1, 0x7B1D);
    // MOV SI,word ptr [BP + -0x6] (0000_7B1A / 0x7B1A)
    SI = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7B1F);
    // SHL SI,0x1 (0000_7B1D / 0x7B1D)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x7B23);
    // MOV ES,word ptr [0x5416] (0000_7B1F / 0x7B1F)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x7B29);
    // CMP word ptr ES:[SI + 0x393c],0x0 (0000_7B23 / 0x7B23)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x393C)], 0x0);
    CheckExternalEvents(cs1, 0x7B2B);
    // JNZ 0x0000:7b33 (0000_7B29 / 0x7B29)
    if(!ZeroFlag) {
      goto label_0000_7B33_07B33;
    }
    CheckExternalEvents(cs1, 0x7B31);
    // CMP word ptr ES:[SI + 0x3954],0x0 (0000_7B2B / 0x7B2B)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x3954)], 0x0);
    CheckExternalEvents(cs1, 0x7B33);
    // JZ 0x0000:7b38 (0000_7B31 / 0x7B31)
    if(ZeroFlag) {
      goto label_0000_7B38_07B38;
    }
    label_0000_7B33_07B33:
    CheckExternalEvents(cs1, 0x7B38);
    // MOV word ptr [BP + -0xa],0x1 (0000_7B33 / 0x7B33)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    label_0000_7B38_07B38:
    CheckExternalEvents(cs1, 0x7B3B);
    // MOV BX,word ptr [BP + -0x6] (0000_7B38 / 0x7B38)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7B3D);
    // SHL BX,0x1 (0000_7B3B / 0x7B3B)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x7B43);
    // CMP word ptr ES:[BX + 0x3954],0x0 (0000_7B3D / 0x7B3D)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x3954)], 0x0);
    CheckExternalEvents(cs1, 0x7B45);
    // JZ 0x0000:7b61 (0000_7B43 / 0x7B43)
    if(ZeroFlag) {
      goto label_0000_7B61_07B61;
    }
    CheckExternalEvents(cs1, 0x7B48);
    // MOV AX,0x11 (0000_7B45 / 0x7B45)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7B4B);
    // IMUL word ptr [BP + -0x6] (0000_7B48 / 0x7B48)
    int resImul0000_7B48 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul0000_7B48);
    DX = (ushort)(resImul0000_7B48 >> 16);
    CheckExternalEvents(cs1, 0x7B4D);
    // MOV BX,AX (0000_7B4B / 0x7B4B)
    BX = AX;
    CheckExternalEvents(cs1, 0x7B51);
    // MOV ES,word ptr [0x5412] (0000_7B4D / 0x7B4D)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7B57);
    // CMP byte ptr ES:[BX + 0xc6eb],0x0 (0000_7B51 / 0x7B51)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC6EB)], 0x0);
    CheckExternalEvents(cs1, 0x7B59);
    // JZ 0x0000:7b5e (0000_7B57 / 0x7B57)
    if(ZeroFlag) {
      goto label_0000_7B5E_07B5E;
    }
    CheckExternalEvents(cs1, 0x7B5E);
    // MOV word ptr [BP + -0xc],0x1 (0000_7B59 / 0x7B59)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x1;
    label_0000_7B5E_07B5E:
    CheckExternalEvents(cs1, 0x7B61);
    // INC word ptr [BP + -0x4] (0000_7B5E / 0x7B5E)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_7B61_07B61:
    CheckExternalEvents(cs1, 0x7B64);
    // INC word ptr [BP + -0x6] (0000_7B61 / 0x7B61)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0x7B68);
    // CMP word ptr [BP + -0x6],0xc (0000_7B64 / 0x7B64)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0xC);
    CheckExternalEvents(cs1, 0x7B6A);
    // JL 0x0000:7b1a (0000_7B68 / 0x7B68)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7B1A_07B1A;
    }
    CheckExternalEvents(cs1, 0x7B6E);
    // CMP word ptr [BP + -0xa],0x0 (0000_7B6A / 0x7B6A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs1, 0x7B70);
    // JNZ 0x0000:7b73 (0000_7B6E / 0x7B6E)
    if(!ZeroFlag) {
      goto label_0000_7B73_07B73;
    }
    CheckExternalEvents(cs1, 0x7B73);
    // JMP 0x0000:7d09 (0000_7B70 / 0x7B70)
    goto label_0000_7D09_07D09;
    label_0000_7B73_07B73:
    CheckExternalEvents(cs1, 0x7B76);
    // MOV AX,0x1 (0000_7B73 / 0x7B73)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x7B77);
    // PUSH AX (0000_7B76 / 0x7B76)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7B7C);
    // CALLF 0x1000:7ee1 (0000_7B77 / 0x7B77)
    FarCall(cs1, 0x7B7C, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x7B7F);
    // ADD SP,0x2 (0000_7B7C / 0x7B7C)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7B84);
    // CALLF 0x1000:7fe8 (0000_7B7F / 0x7B7F)
    FarCall(cs1, 0x7B84, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x7B86);
    // SUB AX,AX (0000_7B84 / 0x7B84)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x7B87);
    // PUSH AX (0000_7B86 / 0x7B86)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7B8C);
    // CALLF 0x1000:7c64 (0000_7B87 / 0x7B87)
    FarCall(cs1, 0x7B8C, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0x7B8F);
    // ADD SP,0x2 (0000_7B8C / 0x7B8C)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7B92);
    // MOV AX,0x1085 (0000_7B8F / 0x7B8F)
    AX = 0x1085;
    CheckExternalEvents(cs1, 0x7B93);
    // PUSH DS (0000_7B92 / 0x7B92)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7B94);
    // PUSH AX (0000_7B93 / 0x7B93)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7B99);
    // CALLF 0x1000:8055 (0000_7B94 / 0x7B94)
    FarCall(cs1, 0x7B99, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7B9C);
    // ADD SP,0x4 (0000_7B99 / 0x7B99)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7B9E);
    // JMP 0x0000:7bac (0000_7B9C / 0x7B9C)
    goto label_0000_7BAC_07BAC;
    label_0000_7B9E_07B9E:
    CheckExternalEvents(cs1, 0x7BA3);
    // CALLF 0x1000:aab0 (0000_7B9E / 0x7B9E)
    FarCall(cs1, 0x7BA3, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7BA6);
    // AND AX,0xf (0000_7BA3 / 0x7BA3)
    AX &= 0xF;
    CheckExternalEvents(cs1, 0x7BA9);
    // ADD AX,0x3 (0000_7BA6 / 0x7BA6)
    AX += 0x3;
    CheckExternalEvents(cs1, 0x7BAC);
    // ADD word ptr [BP + -0x8],AX (0000_7BA9 / 0x7BA9)
    // UInt16[SS, (ushort)(BP - 0x8)] += AX;
    UInt16[SS, (ushort)(BP - 0x8)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x8)], AX);
    label_0000_7BAC_07BAC:
    CheckExternalEvents(cs1, 0x7BAF);
    // MOV AX,word ptr [BP + -0x4] (0000_7BAC / 0x7BAC)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x7BB2);
    // DEC word ptr [BP + -0x4] (0000_7BAF / 0x7BAF)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x7BB4);
    // OR AX,AX (0000_7BB2 / 0x7BB2)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x7BB6);
    // JNZ 0x0000:7b9e (0000_7BB4 / 0x7BB4)
    if(!ZeroFlag) {
      goto label_0000_7B9E_07B9E;
    }
    CheckExternalEvents(cs1, 0x7BBA);
    // CMP word ptr [BP + -0x8],0x2 (0000_7BB6 / 0x7BB6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x2);
    CheckExternalEvents(cs1, 0x7BBC);
    // JGE 0x0000:7bc1 (0000_7BBA / 0x7BBA)
    if(SignFlag == OverflowFlag) {
      goto label_0000_7BC1_07BC1;
    }
    CheckExternalEvents(cs1, 0x7BC1);
    // MOV word ptr [BP + -0x8],0x2 (0000_7BBC / 0x7BBC)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x2;
    label_0000_7BC1_07BC1:
    CheckExternalEvents(cs1, 0x7BC6);
    // CALLF 0x0000:3fa2 (0000_7BC1 / 0x7BC1)
    FarCall(cs1, 0x7BC6, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x7BC9);
    // PUSH word ptr [BP + -0x8] (0000_7BC6 / 0x7BC6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x7BCE);
    // CALLF 0x1000:8b23 (0000_7BC9 / 0x7BC9)
    FarCall(cs1, 0x7BCE, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs1, 0x7BD1);
    // ADD SP,0x2 (0000_7BCE / 0x7BCE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7BD5);
    // MOV ES,word ptr [0x541e] (0000_7BD1 / 0x7BD1)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x7BDC);
    // MOV word ptr ES:[0x37fe],0xf (0000_7BD5 / 0x7BD5)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x7BDF);
    // MOV AX,0x10b5 (0000_7BDC / 0x7BDC)
    AX = 0x10B5;
    CheckExternalEvents(cs1, 0x7BE0);
    // PUSH DS (0000_7BDF / 0x7BDF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7BE1);
    // PUSH AX (0000_7BE0 / 0x7BE0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7BE6);
    // CALLF 0x1000:8055 (0000_7BE1 / 0x7BE1)
    FarCall(cs1, 0x7BE6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7BE9);
    // ADD SP,0x4 (0000_7BE6 / 0x7BE6)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7BEC);
    // MOV AX,word ptr [BP + -0x8] (0000_7BE9 / 0x7BE9)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0x7BED);
    // CWD  (0000_7BEC / 0x7BEC)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0x7BF1);
    // MOV ES,word ptr [0x5412] (0000_7BED / 0x7BED)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7BF6);
    // ADD word ptr ES:[0xd370],AX (0000_7BF1 / 0x7BF1)
    // UInt16[ES, 0xD370] += AX;
    UInt16[ES, 0xD370] = Alu.Add16(UInt16[ES, 0xD370], AX);
    CheckExternalEvents(cs1, 0x7BFB);
    // ADC word ptr ES:[0xd372],DX (0000_7BF6 / 0x7BF6)
    UInt16[ES, 0xD372] = Alu.Adc16(UInt16[ES, 0xD372], DX);
    CheckExternalEvents(cs1, 0x7BFF);
    // CMP word ptr [BP + -0xc],0x0 (0000_7BFB / 0x7BFB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs1, 0x7C01);
    // JZ 0x0000:7c0e (0000_7BFF / 0x7BFF)
    if(ZeroFlag) {
      goto label_0000_7C0E_07C0E;
    }
    CheckExternalEvents(cs1, 0x7C04);
    // MOV AX,0x10c6 (0000_7C01 / 0x7C01)
    AX = 0x10C6;
    CheckExternalEvents(cs1, 0x7C05);
    // PUSH DS (0000_7C04 / 0x7C04)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7C06);
    // PUSH AX (0000_7C05 / 0x7C05)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7C0B);
    // CALLF 0x1000:8055 (0000_7C06 / 0x7C06)
    FarCall(cs1, 0x7C0B, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7C0E);
    // ADD SP,0x4 (0000_7C0B / 0x7C0B)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_0000_7C0E_07C0E:
    CheckExternalEvents(cs1, 0x7C13);
    // CALLF 0x0000:417e (0000_7C0E / 0x7C0E)
    FarCall(cs1, 0x7C13, ghidra_guess_0000_417E_0417E);
    CheckExternalEvents(cs1, 0x7C18);
    // CALLF 0x1000:933a (0000_7C13 / 0x7C13)
    FarCall(cs1, 0x7C18, ghidra_guess_1000_933A_1933A);
    CheckExternalEvents(cs1, 0x7C1D);
    // CALLF 0x1000:8d29 (0000_7C18 / 0x7C18)
    FarCall(cs1, 0x7C1D, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x7C21);
    // CMP word ptr [BP + -0xc],0x0 (0000_7C1D / 0x7C1D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xC)], 0x0);
    CheckExternalEvents(cs1, 0x7C23);
    // JNZ 0x0000:7c26 (0000_7C21 / 0x7C21)
    if(!ZeroFlag) {
      goto label_0000_7C26_07C26;
    }
    CheckExternalEvents(cs1, 0x7C26);
    // JMP 0x0000:7d09 (0000_7C23 / 0x7C23)
    goto label_0000_7D09_07D09;
    label_0000_7C26_07C26:
    CheckExternalEvents(cs1, 0x7C2B);
    // MOV word ptr [BP + -0x6],0x0 (0000_7C26 / 0x7C26)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0x7C2E);
    // JMP 0x0000:7cca (0000_7C2B / 0x7C2B)
    goto label_0000_7CCA_07CCA;
    label_0000_7C2E_07C2E:
    CheckExternalEvents(cs1, 0x7C33);
    // CALLF 0x1000:7fe8 (0000_7C2E / 0x7C2E)
    FarCall(cs1, 0x7C33, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x7C37);
    // MOV ES,word ptr [0x5412] (0000_7C33 / 0x7C33)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7C3B);
    // MOV AL,ES:[0xc61f] (0000_7C37 / 0x7C37)
    AL = UInt8[ES, 0xC61F];
    CheckExternalEvents(cs1, 0x7C3C);
    // CBW  (0000_7C3B / 0x7C3B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x7C3F);
    // MOV word ptr [BP + -0x2],AX (0000_7C3C / 0x7C3C)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x7C42);
    // MOV AX,0x11 (0000_7C3F / 0x7C3F)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7C45);
    // IMUL word ptr [BP + -0x6] (0000_7C42 / 0x7C42)
    int resImul0000_7C42 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul0000_7C42);
    DX = (ushort)(resImul0000_7C42 >> 16);
    CheckExternalEvents(cs1, 0x7C47);
    // MOV BX,AX (0000_7C45 / 0x7C45)
    BX = AX;
    CheckExternalEvents(cs1, 0x7C4C);
    // MOV AL,byte ptr ES:[BX + 0xc6a7] (0000_7C47 / 0x7C47)
    AL = UInt8[ES, (ushort)(BX + 0xC6A7)];
    CheckExternalEvents(cs1, 0x7C4D);
    // CBW  (0000_7C4C / 0x7C4C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x7C50);
    // MOV word ptr [BP + -0xe],AX (0000_7C4D / 0x7C4D)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0x7C52);
    // OR AX,AX (0000_7C50 / 0x7C50)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x7C54);
    // JZ 0x0000:7cc7 (0000_7C52 / 0x7C52)
    if(ZeroFlag) {
      goto label_0000_7CC7_07CC7;
    }
    CheckExternalEvents(cs1, 0x7C57);
    // MOV AX,0x10e5 (0000_7C54 / 0x7C54)
    AX = 0x10E5;
    CheckExternalEvents(cs1, 0x7C58);
    // PUSH DS (0000_7C57 / 0x7C57)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7C59);
    // PUSH AX (0000_7C58 / 0x7C58)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7C5E);
    // CALLF 0x1000:8055 (0000_7C59 / 0x7C59)
    FarCall(cs1, 0x7C5E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7C61);
    // ADD SP,0x4 (0000_7C5E / 0x7C5E)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7C64);
    // MOV AX,0x11 (0000_7C61 / 0x7C61)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7C67);
    // IMUL word ptr [BP + -0x2] (0000_7C64 / 0x7C64)
    int resImul0000_7C64 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_7C64);
    DX = (ushort)(resImul0000_7C64 >> 16);
    CheckExternalEvents(cs1, 0x7C69);
    // MOV BX,AX (0000_7C67 / 0x7C67)
    BX = AX;
    CheckExternalEvents(cs1, 0x7C6D);
    // LEA AX,[BX + 0x2ed8] (0000_7C69 / 0x7C69)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0x7C70);
    // MOV DX,0x384b (0000_7C6D / 0x7C6D)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0x7C71);
    // PUSH DX (0000_7C70 / 0x7C70)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7C72);
    // PUSH AX (0000_7C71 / 0x7C71)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7C77);
    // CALLF 0x1000:8055 (0000_7C72 / 0x7C72)
    FarCall(cs1, 0x7C77, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7C7A);
    // ADD SP,0x4 (0000_7C77 / 0x7C77)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7C7D);
    // MOV AX,0x10ff (0000_7C7A / 0x7C7A)
    AX = 0x10FF;
    CheckExternalEvents(cs1, 0x7C7E);
    // PUSH DS (0000_7C7D / 0x7C7D)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7C7F);
    // PUSH AX (0000_7C7E / 0x7C7E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7C84);
    // CALLF 0x1000:8055 (0000_7C7F / 0x7C7F)
    FarCall(cs1, 0x7C84, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7C87);
    // ADD SP,0x4 (0000_7C84 / 0x7C84)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7C8A);
    // MOV AX,0x11 (0000_7C87 / 0x7C87)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7C8D);
    // IMUL word ptr [BP + -0xe] (0000_7C8A / 0x7C8A)
    int resImul0000_7C8A = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_7C8A);
    DX = (ushort)(resImul0000_7C8A >> 16);
    CheckExternalEvents(cs1, 0x7C8F);
    // MOV BX,AX (0000_7C8D / 0x7C8D)
    BX = AX;
    CheckExternalEvents(cs1, 0x7C93);
    // LEA AX,[BX + 0x2ed8] (0000_7C8F / 0x7C8F)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0x7C96);
    // MOV DX,0x384b (0000_7C93 / 0x7C93)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0x7C97);
    // PUSH DX (0000_7C96 / 0x7C96)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x7C98);
    // PUSH AX (0000_7C97 / 0x7C97)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7C9D);
    // CALLF 0x1000:8055 (0000_7C98 / 0x7C98)
    FarCall(cs1, 0x7C9D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7CA0);
    // ADD SP,0x4 (0000_7C9D / 0x7C9D)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7CA3);
    // MOV AX,0x1113 (0000_7CA0 / 0x7CA0)
    AX = 0x1113;
    CheckExternalEvents(cs1, 0x7CA4);
    // PUSH DS (0000_7CA3 / 0x7CA3)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7CA5);
    // PUSH AX (0000_7CA4 / 0x7CA4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7CAA);
    // CALLF 0x1000:8055 (0000_7CA5 / 0x7CA5)
    FarCall(cs1, 0x7CAA, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7CAD);
    // ADD SP,0x4 (0000_7CAA / 0x7CAA)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x7CAF);
    // SUB AX,AX (0000_7CAD / 0x7CAD)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x7CB0);
    // PUSH AX (0000_7CAF / 0x7CAF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7CB5);
    // CALLF 0x0000:3113 (0000_7CB0 / 0x7CB0)
    FarCall(cs1, 0x7CB5, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0x7CB8);
    // ADD SP,0x2 (0000_7CB5 / 0x7CB5)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7CBA);
    // OR AX,AX (0000_7CB8 / 0x7CB8)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x7CBC);
    // JZ 0x0000:7cc7 (0000_7CBA / 0x7CBA)
    if(ZeroFlag) {
      goto label_0000_7CC7_07CC7;
    }
    CheckExternalEvents(cs1, 0x7CC0);
    // MOV ES,word ptr [0x5412] (0000_7CBC / 0x7CBC)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7CC3);
    // MOV AL,byte ptr [BP + -0xe] (0000_7CC0 / 0x7CC0)
    AL = UInt8[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0x7CC7);
    // MOV ES:[0xc61f],AL (0000_7CC3 / 0x7CC3)
    UInt8[ES, 0xC61F] = AL;
    label_0000_7CC7_07CC7:
    CheckExternalEvents(cs1, 0x7CCA);
    // INC word ptr [BP + -0x6] (0000_7CC7 / 0x7CC7)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    label_0000_7CCA_07CCA:
    CheckExternalEvents(cs1, 0x7CCE);
    // CMP word ptr [BP + -0x6],0x8 (0000_7CCA / 0x7CCA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x8);
    CheckExternalEvents(cs1, 0x7CD0);
    // JGE 0x0000:7d09 (0000_7CCE / 0x7CCE)
    if(SignFlag == OverflowFlag) {
      goto label_0000_7D09_07D09;
    }
    CheckExternalEvents(cs1, 0x7CD3);
    // MOV BX,word ptr [BP + -0x6] (0000_7CD0 / 0x7CD0)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7CD5);
    // SHL BX,0x1 (0000_7CD3 / 0x7CD3)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x7CD9);
    // MOV ES,word ptr [0x5416] (0000_7CD5 / 0x7CD5)
    ES = UInt16[DS, 0x5416];
    CheckExternalEvents(cs1, 0x7CDF);
    // CMP word ptr ES:[BX + 0x395c],0x0 (0000_7CD9 / 0x7CD9)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x395C)], 0x0);
    CheckExternalEvents(cs1, 0x7CE1);
    // JZ 0x0000:7cc7 (0000_7CDF / 0x7CDF)
    if(ZeroFlag) {
      goto label_0000_7CC7_07CC7;
    }
    CheckExternalEvents(cs1, 0x7CE5);
    // MOV ES,word ptr [0x5412] (0000_7CE1 / 0x7CE1)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7CEB);
    // CMP byte ptr ES:[0xc625],0xff (0000_7CE5 / 0x7CE5)
    Alu.Sub8(UInt8[ES, 0xC625], 0xFF);
    CheckExternalEvents(cs1, 0x7CED);
    // JNZ 0x0000:7cf0 (0000_7CEB / 0x7CEB)
    if(!ZeroFlag) {
      goto label_0000_7CF0_07CF0;
    }
    CheckExternalEvents(cs1, 0x7CF0);
    // JMP 0x0000:7c2e (0000_7CED / 0x7CED)
    goto label_0000_7C2E_07C2E;
    label_0000_7CF0_07CF0:
    CheckExternalEvents(cs1, 0x7CF3);
    // MOV AX,0x11 (0000_7CF0 / 0x7CF0)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7CF6);
    // IMUL word ptr [BP + -0x6] (0000_7CF3 / 0x7CF3)
    int resImul0000_7CF3 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x6)]);
    AX = (ushort)(resImul0000_7CF3);
    DX = (ushort)(resImul0000_7CF3 >> 16);
    CheckExternalEvents(cs1, 0x7CF8);
    // MOV BX,AX (0000_7CF6 / 0x7CF6)
    BX = AX;
    CheckExternalEvents(cs1, 0x7CFD);
    // MOV AL,byte ptr ES:[BX + 0xc6a7] (0000_7CF8 / 0x7CF8)
    AL = UInt8[ES, (ushort)(BX + 0xC6A7)];
    CheckExternalEvents(cs1, 0x7CFE);
    // CBW  (0000_7CFD / 0x7CFD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x7CFF);
    // PUSH AX (0000_7CFE / 0x7CFE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7D04);
    // CALLF 0x0000:aaa6 (0000_7CFF / 0x7CFF)
    FarCall(cs1, 0x7D04, ghidra_guess_0000_AAA6_0AAA6);
    CheckExternalEvents(cs1, 0x7D07);
    // ADD SP,0x2 (0000_7D04 / 0x7D04)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7D09);
    // JMP 0x0000:7cc7 (0000_7D07 / 0x7D07)
    goto label_0000_7CC7_07CC7;
    label_0000_7D09_07D09:
    CheckExternalEvents(cs1, 0x7D0A);
    // POP SI (0000_7D09 / 0x7D09)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x7D0C);
    // MOV SP,BP (0000_7D0A / 0x7D0A)
    SP = BP;
    CheckExternalEvents(cs1, 0x7D0D);
    // POP BP (0000_7D0C / 0x7D0C)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x7D0E);
    // RETF  (0000_7D0D / 0x7D0D)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_7D0E_07D0E(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_7D0E_07D0E:
    CheckExternalEvents(cs1, 0x7D10);
    // XOR AX,AX (0000_7D0E / 0x7D0E)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x7D15);
    // CALLF 0x1000:cecc (0000_7D10 / 0x7D10)
    FarCall(cs1, 0x7D15, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x7D18);
    // MOV AX,0x3 (0000_7D15 / 0x7D15)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x7D19);
    // PUSH AX (0000_7D18 / 0x7D18)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7D1E);
    // CALLF 0x1000:7ee1 (0000_7D19 / 0x7D19)
    FarCall(cs1, 0x7D1E, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x7D21);
    // ADD SP,0x2 (0000_7D1E / 0x7D1E)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7D26);
    // CALLF 0x1000:7fe8 (0000_7D21 / 0x7D21)
    FarCall(cs1, 0x7D26, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x7D29);
    // MOV AX,0x1115 (0000_7D26 / 0x7D26)
    AX = 0x1115;
    CheckExternalEvents(cs1, 0x7D2A);
    // PUSH DS (0000_7D29 / 0x7D29)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x7D2B);
    // PUSH AX (0000_7D2A / 0x7D2A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7D30);
    // CALLF 0x1000:8055 (0000_7D2B / 0x7D2B)
    FarCall(cs1, 0x7D30, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x7D33);
    // ADD SP,0x4 (0000_7D30 / 0x7D30)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7D37);
    // MOV ES,word ptr [0x5420] (0000_7D33 / 0x7D33)
    ES = UInt16[DS, 0x5420];
    CheckExternalEvents(cs1, 0x7D3C);
    // PUSH word ptr ES:[0x9e] (0000_7D37 / 0x7D37)
    Stack.Push16(UInt16[ES, 0x9E]);
    CheckExternalEvents(cs1, 0x7D41);
    // CALLF 0x0000:3113 (0000_7D3C / 0x7D3C)
    FarCall(cs1, 0x7D41, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0x7D44);
    // ADD SP,0x2 (0000_7D41 / 0x7D41)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7D45);
    // RETF  (0000_7D44 / 0x7D44)
    return FarRet();
  }
  
  public virtual Action unknown_071B_0B95_07D45(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_071B_0B95_07D45:
    CheckExternalEvents(cs4, 0xB96);
    // PUSH BP (071B_0B95 / 0x7D45)
    Stack.Push16(BP);
    CheckExternalEvents(cs4, 0xB98);
    // MOV BP,SP (071B_0B96 / 0x7D46)
    BP = SP;
    CheckExternalEvents(cs4, 0xB9B);
    // MOV AX,0x12 (071B_0B98 / 0x7D48)
    AX = 0x12;
    CheckExternalEvents(cs4, 0xBA0);
    // CALLF 0x1000:cecc (071B_0B9B / 0x7D4B)
    FarCall(cs4, 0xBA0, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs4, 0xBA1);
    // PUSH DI (071B_0BA0 / 0x7D50)
    Stack.Push16(DI);
    CheckExternalEvents(cs4, 0xBA2);
    // PUSH SI (071B_0BA1 / 0x7D51)
    Stack.Push16(SI);
    CheckExternalEvents(cs4, 0xBA7);
    // MOV word ptr [BP + -0x4],0x46c (071B_0BA2 / 0x7D52)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x46C;
    CheckExternalEvents(cs4, 0xBAC);
    // MOV word ptr [BP + -0x2],0x0 (071B_0BA7 / 0x7D57)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs4, 0xBB0);
    // MOV ES,word ptr [0x5422] (071B_0BAC / 0x7D5C)
    ES = UInt16[DS, 0x5422];
    CheckExternalEvents(cs4, 0xBB2);
    // SUB AX,AX (071B_0BB0 / 0x7D60)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs4, 0xBB6);
    // MOV ES:[0x32ac],AX (071B_0BB2 / 0x7D62)
    UInt16[ES, 0x32AC] = AX;
    CheckExternalEvents(cs4, 0xBB8);
    // MOV SI,AX (071B_0BB6 / 0x7D66)
    SI = AX;
    CheckExternalEvents(cs4, 0xBBD);
    // CALLF 0x1000:be9d (071B_0BB8 / 0x7D68)
    FarCall(cs4, 0xBBD, unknown_19EF_1FAD_1BE9D);
    CheckExternalEvents(cs4, 0xBC0);
    // LES BX,[BP + -0x4] (071B_0BBD / 0x7D6D)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs4, 0xBC3);
    // MOV AX,word ptr ES:[BX] (071B_0BC0 / 0x7D70)
    AX = UInt16[ES, (ushort)(BX)];
    CheckExternalEvents(cs4, 0xBC7);
    // MOV DX,word ptr ES:[BX + 0x2] (071B_0BC3 / 0x7D73)
    DX = UInt16[ES, (ushort)(BX + 0x2)];
    CheckExternalEvents(cs4, 0xBCA);
    // MOV word ptr [BP + -0xc],AX (071B_0BC7 / 0x7D77)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs4, 0xBCD);
    // MOV word ptr [BP + -0xa],DX (071B_0BCA / 0x7D7A)
    UInt16[SS, (ushort)(BP - 0xA)] = DX;
    CheckExternalEvents(cs4, 0xBD2);
    // CALLF 0x1000:be8c (071B_0BCD / 0x7D7D)
    FarCall(cs4, 0xBD2, unknown_19EF_1F9C_1BE8C);
    label_071B_0BD2_07D82:
    CheckExternalEvents(cs4, 0xBD5);
    // LES BX,[BP + -0x4] (071B_0BD2 / 0x7D82)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs4, 0xBD8);
    // MOV AX,word ptr [BP + -0xc] (071B_0BD5 / 0x7D85)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs4, 0xBDB);
    // MOV DX,word ptr [BP + -0xa] (071B_0BD8 / 0x7D88)
    DX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs4, 0xBDE);
    // CMP word ptr ES:[BX],AX (071B_0BDB / 0x7D8B)
    Alu.Sub16(UInt16[ES, (ushort)(BX)], AX);
    CheckExternalEvents(cs4, 0xBE0);
    // JNZ 0x0000:7d96 (071B_0BDE / 0x7D8E)
    if(!ZeroFlag) {
      goto label_071B_0BE6_07D96;
    }
    CheckExternalEvents(cs4, 0xBE4);
    // CMP word ptr ES:[BX + 0x2],DX (071B_0BE0 / 0x7D90)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x2)], DX);
    CheckExternalEvents(cs4, 0xBE6);
    // JZ 0x0000:7d82 (071B_0BE4 / 0x7D94)
    if(ZeroFlag) {
      goto label_071B_0BD2_07D82;
    }
    label_071B_0BE6_07D96:
    CheckExternalEvents(cs4, 0xBEB);
    // CALLF 0x1000:be9d (071B_0BE6 / 0x7D96)
    FarCall(cs4, 0xBEB, unknown_19EF_1FAD_1BE9D);
    CheckExternalEvents(cs4, 0xBEE);
    // LES BX,[BP + -0x4] (071B_0BEB / 0x7D9B)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs4, 0xBF1);
    // MOV AX,word ptr ES:[BX] (071B_0BEE / 0x7D9E)
    AX = UInt16[ES, (ushort)(BX)];
    CheckExternalEvents(cs4, 0xBF5);
    // MOV DX,word ptr ES:[BX + 0x2] (071B_0BF1 / 0x7DA1)
    DX = UInt16[ES, (ushort)(BX + 0x2)];
    CheckExternalEvents(cs4, 0xBF8);
    // ADD AX,0x4 (071B_0BF5 / 0x7DA5)
    // AX += 0x4;
    AX = Alu.Add16(AX, 0x4);
    CheckExternalEvents(cs4, 0xBFB);
    // ADC DX,0x0 (071B_0BF8 / 0x7DA8)
    DX = Alu.Adc16(DX, 0x0);
    CheckExternalEvents(cs4, 0xBFE);
    // MOV word ptr [BP + -0xc],AX (071B_0BFB / 0x7DAB)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs4, 0xC01);
    // MOV word ptr [BP + -0xa],DX (071B_0BFE / 0x7DAE)
    UInt16[SS, (ushort)(BP - 0xA)] = DX;
    CheckExternalEvents(cs4, 0xC06);
    // CALLF 0x1000:be8c (071B_0C01 / 0x7DB1)
    FarCall(cs4, 0xC06, unknown_19EF_1F9C_1BE8C);
    label_071B_0C06_07DB6:
    CheckExternalEvents(cs4, 0xC09);
    // LES BX,[BP + -0x4] (071B_0C06 / 0x7DB6)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs4, 0xC0C);
    // MOV AX,word ptr [BP + -0xc] (071B_0C09 / 0x7DB9)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs4, 0xC0F);
    // MOV DX,word ptr [BP + -0xa] (071B_0C0C / 0x7DBC)
    DX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs4, 0xC13);
    // CMP word ptr ES:[BX + 0x2],DX (071B_0C0F / 0x7DBF)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x2)], DX);
    CheckExternalEvents(cs4, 0xC15);
    // JA 0x0000:7dd9 (071B_0C13 / 0x7DC3)
    if(!CarryFlag && !ZeroFlag) {
      goto label_071B_0C29_07DD9;
    }
    CheckExternalEvents(cs4, 0xC17);
    // JC 0x0000:7dcc (071B_0C15 / 0x7DC5)
    if(CarryFlag) {
      goto label_071B_0C1C_07DCC;
    }
    CheckExternalEvents(cs4, 0xC1A);
    // CMP word ptr ES:[BX],AX (071B_0C17 / 0x7DC7)
    Alu.Sub16(UInt16[ES, (ushort)(BX)], AX);
    CheckExternalEvents(cs4, 0xC1C);
    // JNC 0x0000:7dd9 (071B_0C1A / 0x7DCA)
    if(!CarryFlag) {
      goto label_071B_0C29_07DD9;
    }
    label_071B_0C1C_07DCC:
    CheckExternalEvents(cs4, 0xC1D);
    // INC SI (071B_0C1C / 0x7DCC)
    SI = Alu.Inc16(SI);
    CheckExternalEvents(cs4, 0xC20);
    // MOV DI,0xc8 (071B_0C1D / 0x7DCD)
    DI = 0xC8;
    CheckExternalEvents(cs4, 0xC22);
    // JMP 0x0000:7dd3 (071B_0C20 / 0x7DD0)
    goto label_071B_0C23_07DD3;
    label_071B_0C22_07DD2:
    CheckExternalEvents(cs4, 0xC23);
    // DEC DI (071B_0C22 / 0x7DD2)
    DI = Alu.Dec16(DI);
    label_071B_0C23_07DD3:
    CheckExternalEvents(cs4, 0xC25);
    // OR DI,DI (071B_0C23 / 0x7DD3)
    // DI |= DI;
    DI = Alu.Or16(DI, DI);
    CheckExternalEvents(cs4, 0xC27);
    // JZ 0x0000:7db6 (071B_0C25 / 0x7DD5)
    if(ZeroFlag) {
      goto label_071B_0C06_07DB6;
    }
    CheckExternalEvents(cs4, 0xC29);
    // JMP 0x0000:7dd2 (071B_0C27 / 0x7DD7)
    goto label_071B_0C22_07DD2;
    label_071B_0C29_07DD9:
    CheckExternalEvents(cs4, 0xC2C);
    // MOV AX,0x2710 (071B_0C29 / 0x7DD9)
    AX = 0x2710;
    CheckExternalEvents(cs4, 0xC2D);
    // CWD  (071B_0C2C / 0x7DDC)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs4, 0xC2E);
    // PUSH DX (071B_0C2D / 0x7DDD)
    Stack.Push16(DX);
    CheckExternalEvents(cs4, 0xC2F);
    // PUSH AX (071B_0C2E / 0x7DDE)
    Stack.Push16(AX);
    CheckExternalEvents(cs4, 0xC32);
    // MOV AX,0x1c7 (071B_0C2F / 0x7DDF)
    AX = 0x1C7;
    CheckExternalEvents(cs4, 0xC33);
    // CWD  (071B_0C32 / 0x7DE2)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs4, 0xC34);
    // PUSH DX (071B_0C33 / 0x7DE3)
    Stack.Push16(DX);
    CheckExternalEvents(cs4, 0xC35);
    // PUSH AX (071B_0C34 / 0x7DE4)
    Stack.Push16(AX);
    CheckExternalEvents(cs4, 0xC37);
    // MOV AX,SI (071B_0C35 / 0x7DE5)
    AX = SI;
    CheckExternalEvents(cs4, 0xC38);
    // CWD  (071B_0C37 / 0x7DE7)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs4, 0xC39);
    // PUSH DX (071B_0C38 / 0x7DE8)
    Stack.Push16(DX);
    CheckExternalEvents(cs4, 0xC3A);
    // PUSH AX (071B_0C39 / 0x7DE9)
    Stack.Push16(AX);
    CheckExternalEvents(cs4, 0xC3F);
    // CALLF 0x1000:dd1e (071B_0C3A / 0x7DEA)
    FarCall(cs4, 0xC3F, unknown_19EF_3E2E_1DD1E);
    CheckExternalEvents(cs4, 0xC40);
    // PUSH DX (071B_0C3F / 0x7DEF)
    Stack.Push16(DX);
    CheckExternalEvents(cs4, 0xC41);
    // PUSH AX (071B_0C40 / 0x7DF0)
    Stack.Push16(AX);
    CheckExternalEvents(cs4, 0xC46);
    // CALLF 0x1000:dc82 (071B_0C41 / 0x7DF1)
    FarCall(cs4, 0xC46, unknown_19EF_3D92_1DC82);
    CheckExternalEvents(cs4, 0xC4A);
    // MOV ES,word ptr [0x5424] (071B_0C46 / 0x7DF6)
    ES = UInt16[DS, 0x5424];
    CheckExternalEvents(cs4, 0xC4E);
    // MOV ES:[0x3ff4],AX (071B_0C4A / 0x7DFA)
    UInt16[ES, 0x3FF4] = AX;
    CheckExternalEvents(cs4, 0xC50);
    // SUB AX,AX (071B_0C4E / 0x7DFE)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs4, 0xC53);
    // MOV word ptr [BP + -0x8],AX (071B_0C50 / 0x7E00)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs4, 0xC56);
    // MOV word ptr [BP + -0xe],AX (071B_0C53 / 0x7E03)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs4, 0xC59);
    // MOV word ptr [BP + -0x10],AX (071B_0C56 / 0x7E06)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs4, 0xC5B);
    // JMP 0x0000:7e11 (071B_0C59 / 0x7E09)
    goto label_071B_0C61_07E11;
    label_071B_0C5B_07E0B:
    CheckExternalEvents(cs4, 0xC5E);
    // INC word ptr [BP + -0xe] (071B_0C5B / 0x7E0B)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    label_071B_0C5E_07E0E:
    CheckExternalEvents(cs4, 0xC61);
    // INC word ptr [BP + -0x10] (071B_0C5E / 0x7E0E)
    UInt16[SS, (ushort)(BP - 0x10)]++;
    label_071B_0C61_07E11:
    CheckExternalEvents(cs4, 0xC66);
    // CMP word ptr [BP + -0x10],0x2710 (071B_0C61 / 0x7E11)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x2710);
    CheckExternalEvents(cs4, 0xC68);
    // JGE 0x0000:7e26 (071B_0C66 / 0x7E16)
    if(SignFlag == OverflowFlag) {
      goto label_071B_0C76_07E26;
    }
    CheckExternalEvents(cs4, 0xC6D);
    // CALLF 0x1000:aa16 (071B_0C68 / 0x7E18)
    FarCall(cs4, 0xC6D, unknown_19EF_0B26_1AA16);
    CheckExternalEvents(cs4, 0xC6F);
    // OR AX,AX (071B_0C6D / 0x7E1D)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs4, 0xC71);
    // JZ 0x0000:7e0b (071B_0C6F / 0x7E1F)
    if(ZeroFlag) {
      goto label_071B_0C5B_07E0B;
    }
    CheckExternalEvents(cs4, 0xC74);
    // INC word ptr [BP + -0x8] (071B_0C71 / 0x7E21)
    UInt16[SS, (ushort)(BP - 0x8)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs4, 0xC76);
    // JMP 0x0000:7e0e (071B_0C74 / 0x7E24)
    goto label_071B_0C5E_07E0E;
    label_071B_0C76_07E26:
    CheckExternalEvents(cs4, 0xC79);
    // MOV AX,word ptr [BP + -0xe] (071B_0C76 / 0x7E26)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs4, 0xC7C);
    // CMP word ptr [BP + -0x8],AX (071B_0C79 / 0x7E29)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], AX);
    CheckExternalEvents(cs4, 0xC7E);
    // JLE 0x0000:7e39 (071B_0C7C / 0x7E2C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_071B_0C89_07E39;
    }
    CheckExternalEvents(cs4, 0xC82);
    // MOV ES,word ptr [0x5422] (071B_0C7E / 0x7E2E)
    ES = UInt16[DS, 0x5422];
    CheckExternalEvents(cs4, 0xC89);
    // MOV word ptr ES:[0x32ac],0x1 (071B_0C82 / 0x7E32)
    UInt16[ES, 0x32AC] = 0x1;
    label_071B_0C89_07E39:
    CheckExternalEvents(cs4, 0xC8A);
    // POP SI (071B_0C89 / 0x7E39)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs4, 0xC8B);
    // POP DI (071B_0C8A / 0x7E3A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs4, 0xC8D);
    // MOV SP,BP (071B_0C8B / 0x7E3B)
    SP = BP;
    CheckExternalEvents(cs4, 0xC8E);
    // POP BP (071B_0C8D / 0x7E3D)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs4, 0xC8F);
    // RETF  (071B_0C8E / 0x7E3E)
    return FarRet();
  }
  
  public virtual Action unknown_071B_0C8F_07E3F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_071B_0C8F_07E3F:
    CheckExternalEvents(cs4, 0xC91);
    // XOR AX,AX (071B_0C8F / 0x7E3F)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs4, 0xC96);
    // CALLF 0x1000:cecc (071B_0C91 / 0x7E41)
    FarCall(cs4, 0xC96, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs4, 0xC99);
    // MOV AX,0x4614 (071B_0C96 / 0x7E46)
    AX = 0x4614;
    CheckExternalEvents(cs4, 0xC9C);
    // MOV DX,0x2a02 (071B_0C99 / 0x7E49)
    DX = 0x2A02;
    CheckExternalEvents(cs4, 0xC9D);
    // PUSH DX (071B_0C9C / 0x7E4C)
    Stack.Push16(DX);
    CheckExternalEvents(cs4, 0xC9E);
    // PUSH AX (071B_0C9D / 0x7E4D)
    Stack.Push16(AX);
    CheckExternalEvents(cs4, 0xCA3);
    // CALLF 0x1000:bc7c (071B_0C9E / 0x7E4E)
    FarCall(cs4, 0xCA3, unknown_19EF_1D8C_1BC7C);
    CheckExternalEvents(cs4, 0xCA6);
    // ADD SP,0x4 (071B_0CA3 / 0x7E53)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs4, 0xCAA);
    // MOV ES,word ptr [0x5426] (071B_0CA6 / 0x7E56)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs4, 0xCAF);
    // PUSH word ptr ES:[0x4fba] (071B_0CAA / 0x7E5A)
    Stack.Push16(UInt16[ES, 0x4FBA]);
    CheckExternalEvents(cs4, 0xCB4);
    // CALLF 0x1000:cbd1 (071B_0CAF / 0x7E5F)
    FarCall(cs4, 0xCB4, unknown_19EF_2CE1_1CBD1);
    CheckExternalEvents(cs4, 0xCB7);
    // ADD SP,0x2 (071B_0CB4 / 0x7E64)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs4, 0xCBB);
    // MOV ES,word ptr [0x5426] (071B_0CB7 / 0x7E67)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs4, 0xCC0);
    // MOV BX,word ptr ES:[0x4fba] (071B_0CBB / 0x7E6B)
    BX = UInt16[ES, 0x4FBA];
    CheckExternalEvents(cs4, 0xCC2);
    // SHL BX,0x1 (071B_0CC0 / 0x7E70)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs4, 0xCC6);
    // PUSH word ptr [BX + 0x1140] (071B_0CC2 / 0x7E72)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x1140)]);
    CheckExternalEvents(cs4, 0xCCB);
    // CALLF 0x1000:aa63 (071B_0CC6 / 0x7E76)
    FarCall(cs4, 0xCCB, unknown_19EF_0B73_1AA63);
    CheckExternalEvents(cs4, 0xCCE);
    // ADD SP,0x2 (071B_0CCB / 0x7E7B)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs4, 0xCD3);
    // CALLF 0x1000:beae (071B_0CCE / 0x7E7E)
    FarCall(cs4, 0xCD3, unknown_19EF_1FBE_1BEAE);
    CheckExternalEvents(cs4, 0xCD4);
    // PUSH CS (071B_0CD3 / 0x7E83)
    Stack.Push16(cs4);
    CheckExternalEvents(cs4, 0xCD7);
    // CALL 0x0000:7d45 (071B_0CD4 / 0x7E84)
    NearCall(cs4, 0xCD7, unknown_071B_0B95_07D45);
    CheckExternalEvents(cs4, 0xCDB);
    // MOV ES,word ptr [0x5424] (071B_0CD7 / 0x7E87)
    ES = UInt16[DS, 0x5424];
    CheckExternalEvents(cs4, 0xCDF);
    // MOV AX,ES:[0x3ff4] (071B_0CDB / 0x7E8B)
    AX = UInt16[ES, 0x3FF4];
    CheckExternalEvents(cs4, 0xCE2);
    // SUB AX,0x4 (071B_0CDF / 0x7E8F)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    CheckExternalEvents(cs4, 0xCE3);
    // CWD  (071B_0CE2 / 0x7E92)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs4, 0xCE6);
    // MOV CX,0x6 (071B_0CE3 / 0x7E93)
    CX = 0x6;
    CheckExternalEvents(cs4, 0xCE8);
    // IDIV CX (071B_0CE6 / 0x7E96)
    int op1IDiv071B_0CE6 = (int)(DX << 16 | AX);
    short op2IDiv071B_0CE6 = (short)CX;
    short? resIDiv071B_0CE6 = Alu.IDiv16(op1IDiv071B_0CE6, op2IDiv071B_0CE6);
    if(resIDiv071B_0CE6 == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIDiv071B_0CE6.Value;
    DX = (ushort)(op1IDiv071B_0CE6 % op2IDiv071B_0CE6);
    CheckExternalEvents(cs4, 0xCEC);
    // MOV ES,word ptr [0x5428] (071B_0CE8 / 0x7E98)
    ES = UInt16[DS, 0x5428];
    CheckExternalEvents(cs4, 0xCF0);
    // MOV ES:[0x5006],AX (071B_0CEC / 0x7E9C)
    UInt16[ES, 0x5006] = AX;
    CheckExternalEvents(cs4, 0xCF3);
    // CMP AX,0x1 (071B_0CF0 / 0x7EA0)
    Alu.Sub16(AX, 0x1);
    CheckExternalEvents(cs4, 0xCF5);
    // JGE 0x0000:7eac (071B_0CF3 / 0x7EA3)
    if(SignFlag == OverflowFlag) {
      goto label_071B_0CFC_07EAC;
    }
    CheckExternalEvents(cs4, 0xCFC);
    // MOV word ptr ES:[0x5006],0x1 (071B_0CF5 / 0x7EA5)
    UInt16[ES, 0x5006] = 0x1;
    label_071B_0CFC_07EAC:
    CheckExternalEvents(cs4, 0xD01);
    // CALLF 0x1000:cbe7 (071B_0CFC / 0x7EAC)
    FarCall(cs4, 0xD01, unknown_19EF_2CF7_1CBE7);
    CheckExternalEvents(cs4, 0xD04);
    // MOV AX,0xd26 (071B_0D01 / 0x7EB1)
    AX = 0xD26;
    CheckExternalEvents(cs4, 0xD07);
    // MOV DX,0x71b (071B_0D04 / 0x7EB4)
    DX = 0x71B;
    CheckExternalEvents(cs4, 0xD08);
    // PUSH DX (071B_0D07 / 0x7EB7)
    Stack.Push16(DX);
    CheckExternalEvents(cs4, 0xD09);
    // PUSH AX (071B_0D08 / 0x7EB8)
    Stack.Push16(AX);
    CheckExternalEvents(cs4, 0xD0E);
    // CALLF 0x1000:db72 (071B_0D09 / 0x7EB9)
    FarCall(cs4, 0xD0E, unknown_19EF_3C82_1DB72);
    CheckExternalEvents(cs4, 0xD11);
    // ADD SP,0x4 (071B_0D0E / 0x7EBE)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs4, 0xD12);
    // RETF  (071B_0D11 / 0x7EC1)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_7EC2_07EC2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_7EC2_07EC2:
    CheckExternalEvents(cs1, 0x7EC4);
    // XOR AX,AX (0000_7EC2 / 0x7EC2)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x7EC9);
    // CALLF 0x1000:cecc (0000_7EC4 / 0x7EC4)
    FarCall(cs1, 0x7EC9, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x7ECC);
    // MOV AX,0x2 (0000_7EC9 / 0x7EC9)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x7ECD);
    // PUSH AX (0000_7ECC / 0x7ECC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x7ED2);
    // CALLF 0x1000:aa63 (0000_7ECD / 0x7ECD)
    FarCall(cs1, 0x7ED2, unknown_19EF_0B73_1AA63);
    CheckExternalEvents(cs1, 0x7ED5);
    // ADD SP,0x2 (0000_7ED2 / 0x7ED2)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0x7ED6);
    // RETF  (0000_7ED5 / 0x7ED5)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_7EED_07EED(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_7EED_07EED:
    CheckExternalEvents(cs1, 0x7EEE);
    // PUSH BP (0000_7EED / 0x7EED)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x7EF0);
    // MOV BP,SP (0000_7EEE / 0x7EEE)
    BP = SP;
    CheckExternalEvents(cs1, 0x7EF3);
    // MOV AX,0x36 (0000_7EF0 / 0x7EF0)
    AX = 0x36;
    CheckExternalEvents(cs1, 0x7EF8);
    // CALLF 0x1000:cecc (0000_7EF3 / 0x7EF3)
    FarCall(cs1, 0x7EF8, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x7EF9);
    // PUSH SI (0000_7EF8 / 0x7EF8)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x7EFD);
    // MOV ES,word ptr [0x542a] (0000_7EF9 / 0x7EF9)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x7F02);
    // PUSH word ptr ES:[0xa44d] (0000_7EFD / 0x7EFD)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x7F06);
    // MOV ES,word ptr [0x542c] (0000_7F02 / 0x7F02)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x7F0B);
    // PUSH word ptr ES:[0xa44b] (0000_7F06 / 0x7F06)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0x7F10);
    // CALLF 0x1000:b204 (0000_7F0B / 0x7F0B)
    FarCall(cs1, 0x7F10, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0x7F13);
    // ADD SP,0x4 (0000_7F10 / 0x7F10)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0x7F18);
    // CALLF 0x1000:bce8 (0000_7F13 / 0x7F13)
    FarCall(cs1, 0x7F18, unknown_19EF_1DF8_1BCE8);
    CheckExternalEvents(cs1, 0x7F1D);
    // CALLF 0x1000:aab0 (0000_7F18 / 0x7F18)
    FarCall(cs1, 0x7F1D, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7F20);
    // AND AX,0x7 (0000_7F1D / 0x7F1D)
    AX &= 0x7;
    CheckExternalEvents(cs1, 0x7F23);
    // ADD AX,0xa (0000_7F20 / 0x7F20)
    // AX += 0xA;
    AX = Alu.Add16(AX, 0xA);
    CheckExternalEvents(cs1, 0x7F26);
    // MOV word ptr [BP + -0x6],AX (0000_7F23 / 0x7F23)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x7F2B);
    // CALLF 0x1000:aab0 (0000_7F26 / 0x7F26)
    FarCall(cs1, 0x7F2B, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7F2D);
    // TEST AL,0x1 (0000_7F2B / 0x7F2B)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs1, 0x7F2F);
    // JZ 0x0000:7f37 (0000_7F2D / 0x7F2D)
    if(ZeroFlag) {
      goto label_0000_7F37_07F37;
    }
    CheckExternalEvents(cs1, 0x7F32);
    // MOV AX,word ptr [BP + -0x6] (0000_7F2F / 0x7F2F)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7F34);
    // NEG AX (0000_7F32 / 0x7F32)
    AX = Alu.Sub16(0, AX);
    CheckExternalEvents(cs1, 0x7F37);
    // MOV word ptr [BP + -0x6],AX (0000_7F34 / 0x7F34)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    label_0000_7F37_07F37:
    CheckExternalEvents(cs1, 0x7F3C);
    // CALLF 0x1000:aab0 (0000_7F37 / 0x7F37)
    FarCall(cs1, 0x7F3C, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7F3F);
    // AND AX,0x7 (0000_7F3C / 0x7F3C)
    AX &= 0x7;
    CheckExternalEvents(cs1, 0x7F42);
    // ADD AX,0xa (0000_7F3F / 0x7F3F)
    // AX += 0xA;
    AX = Alu.Add16(AX, 0xA);
    CheckExternalEvents(cs1, 0x7F45);
    // MOV word ptr [BP + -0xc],AX (0000_7F42 / 0x7F42)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x7F4A);
    // CALLF 0x1000:aab0 (0000_7F45 / 0x7F45)
    FarCall(cs1, 0x7F4A, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7F4C);
    // TEST AL,0x1 (0000_7F4A / 0x7F4A)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs1, 0x7F4E);
    // JZ 0x0000:7f56 (0000_7F4C / 0x7F4C)
    if(ZeroFlag) {
      goto label_0000_7F56_07F56;
    }
    CheckExternalEvents(cs1, 0x7F51);
    // MOV AX,word ptr [BP + -0xc] (0000_7F4E / 0x7F4E)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x7F53);
    // NEG AX (0000_7F51 / 0x7F51)
    AX = Alu.Sub16(0, AX);
    CheckExternalEvents(cs1, 0x7F56);
    // MOV word ptr [BP + -0xc],AX (0000_7F53 / 0x7F53)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    label_0000_7F56_07F56:
    CheckExternalEvents(cs1, 0x7F59);
    // MOV AX,word ptr [BP + -0x6] (0000_7F56 / 0x7F56)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x7F5C);
    // ADD AX,0x1a (0000_7F59 / 0x7F59)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs1, 0x7F5F);
    // MOV word ptr [BP + -0x28],AX (0000_7F5C / 0x7F5C)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x7F62);
    // MOV word ptr [BP + -0x30],AX (0000_7F5F / 0x7F5F)
    UInt16[SS, (ushort)(BP - 0x30)] = AX;
    CheckExternalEvents(cs1, 0x7F65);
    // MOV AX,word ptr [BP + -0xc] (0000_7F62 / 0x7F62)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x7F68);
    // ADD AX,0xc (0000_7F65 / 0x7F65)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs1, 0x7F6B);
    // MOV word ptr [BP + -0x2e],AX (0000_7F68 / 0x7F68)
    UInt16[SS, (ushort)(BP - 0x2E)] = AX;
    CheckExternalEvents(cs1, 0x7F6E);
    // MOV word ptr [BP + -0x32],AX (0000_7F6B / 0x7F6B)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs1, 0x7F73);
    // MOV word ptr [BP + -0x20],0xc (0000_7F6E / 0x7F6E)
    UInt16[SS, (ushort)(BP - 0x20)] = 0xC;
    label_0000_7F73_07F73:
    CheckExternalEvents(cs1, 0x7F76);
    // MOV SI,word ptr [BP + -0x20] (0000_7F73 / 0x7F73)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x7F78);
    // SHL SI,0x1 (0000_7F76 / 0x7F76)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x7F7C);
    // MOV ES,word ptr [0x542e] (0000_7F78 / 0x7F78)
    ES = UInt16[DS, 0x542E];
    CheckExternalEvents(cs1, 0x7F83);
    // MOV word ptr ES:[SI + 0x406a],0x0 (0000_7F7C / 0x7F7C)
    UInt16[ES, (ushort)(SI + 0x406A)] = 0x0;
    CheckExternalEvents(cs1, 0x7F86);
    // MOV AX,0xffff (0000_7F83 / 0x7F83)
    AX = 0xFFFF;
    CheckExternalEvents(cs1, 0x7F8A);
    // MOV ES,word ptr [0x5430] (0000_7F86 / 0x7F86)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x7F8F);
    // MOV word ptr ES:[SI + 0x4036],AX (0000_7F8A / 0x7F8A)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs1, 0x7F93);
    // MOV ES,word ptr [0x5432] (0000_7F8F / 0x7F8F)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x7F98);
    // MOV word ptr ES:[SI + 0x4004],AX (0000_7F93 / 0x7F93)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs1, 0x7F9B);
    // INC word ptr [BP + -0x20] (0000_7F98 / 0x7F98)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs1, 0x7F9F);
    // CMP word ptr [BP + -0x20],0x18 (0000_7F9B / 0x7F9B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x18);
    CheckExternalEvents(cs1, 0x7FA1);
    // JL 0x0000:7f73 (0000_7F9F / 0x7F9F)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7F73_07F73;
    }
    CheckExternalEvents(cs1, 0x7FA6);
    // MOV word ptr [BP + -0x20],0x8 (0000_7FA1 / 0x7FA1)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x8;
    label_0000_7FA6_07FA6:
    CheckExternalEvents(cs1, 0x7FA9);
    // MOV AX,0x11 (0000_7FA6 / 0x7FA6)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7FAC);
    // IMUL word ptr [BP + -0x20] (0000_7FA9 / 0x7FA9)
    int resImul0000_7FA9 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_7FA9);
    DX = (ushort)(resImul0000_7FA9 >> 16);
    CheckExternalEvents(cs1, 0x7FAE);
    // MOV BX,AX (0000_7FAC / 0x7FAC)
    BX = AX;
    CheckExternalEvents(cs1, 0x7FB2);
    // MOV ES,word ptr [0x5412] (0000_7FAE / 0x7FAE)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7FB8);
    // MOV byte ptr ES:[BX + 0xc614],0xff (0000_7FB2 / 0x7FB2)
    UInt8[ES, (ushort)(BX + 0xC614)] = 0xFF;
    CheckExternalEvents(cs1, 0x7FBD);
    // CALLF 0x1000:aab0 (0000_7FB8 / 0x7FB8)
    FarCall(cs1, 0x7FBD, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7FBF);
    // TEST AL,0x1 (0000_7FBD / 0x7FBD)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs1, 0x7FC1);
    // JNZ 0x0000:7fc4 (0000_7FBF / 0x7FBF)
    if(!ZeroFlag) {
      goto label_0000_7FC4_07FC4;
    }
    CheckExternalEvents(cs1, 0x7FC4);
    // JMP 0x0000:80af (0000_7FC1 / 0x7FC1)
    goto label_0000_80AF_080AF;
    label_0000_7FC4_07FC4:
    CheckExternalEvents(cs1, 0x7FC7);
    // MOV AX,0x11 (0000_7FC4 / 0x7FC4)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x7FCA);
    // IMUL word ptr [BP + -0x20] (0000_7FC7 / 0x7FC7)
    int resImul0000_7FC7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_7FC7);
    DX = (ushort)(resImul0000_7FC7 >> 16);
    CheckExternalEvents(cs1, 0x7FCC);
    // MOV SI,AX (0000_7FCA / 0x7FCA)
    SI = AX;
    CheckExternalEvents(cs1, 0x7FD0);
    // MOV ES,word ptr [0x5412] (0000_7FCC / 0x7FCC)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x7FD6);
    // MOV byte ptr ES:[SI + 0xc614],0x1 (0000_7FD0 / 0x7FD0)
    UInt8[ES, (ushort)(SI + 0xC614)] = 0x1;
    CheckExternalEvents(cs1, 0x7FDC);
    // MOV byte ptr ES:[SI + 0xc620],0x8 (0000_7FD6 / 0x7FD6)
    UInt8[ES, (ushort)(SI + 0xC620)] = 0x8;
    CheckExternalEvents(cs1, 0x7FE1);
    // MOV word ptr [BP + -0x24],0x0 (0000_7FDC / 0x7FDC)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x0;
    CheckExternalEvents(cs1, 0x7FE6);
    // MOV word ptr [BP + -0x22],0x0 (0000_7FE1 / 0x7FE1)
    UInt16[SS, (ushort)(BP - 0x22)] = 0x0;
    label_0000_7FE6_07FE6:
    CheckExternalEvents(cs1, 0x7FEB);
    // CALLF 0x1000:aab0 (0000_7FE6 / 0x7FE6)
    FarCall(cs1, 0x7FEB, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x7FEE);
    // AND AX,0x3 (0000_7FEB / 0x7FEB)
    AX &= 0x3;
    CheckExternalEvents(cs1, 0x7FF1);
    // ADD word ptr [BP + -0x24],AX (0000_7FEE / 0x7FEE)
    UInt16[SS, (ushort)(BP - 0x24)] += AX;
    CheckExternalEvents(cs1, 0x7FF4);
    // INC word ptr [BP + -0x22] (0000_7FF1 / 0x7FF1)
    UInt16[SS, (ushort)(BP - 0x22)]++;
    CheckExternalEvents(cs1, 0x7FF8);
    // CMP word ptr [BP + -0x22],0x7 (0000_7FF4 / 0x7FF4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x22)], 0x7);
    CheckExternalEvents(cs1, 0x7FFA);
    // JL 0x0000:7fe6 (0000_7FF8 / 0x7FF8)
    if(SignFlag != OverflowFlag) {
      goto label_0000_7FE6_07FE6;
    }
    CheckExternalEvents(cs1, 0x7FFD);
    // MOV AX,0x11 (0000_7FFA / 0x7FFA)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x8000);
    // IMUL word ptr [BP + -0x20] (0000_7FFD / 0x7FFD)
    int resImul0000_7FFD = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_7FFD);
    DX = (ushort)(resImul0000_7FFD >> 16);
    CheckExternalEvents(cs1, 0x8002);
    // MOV SI,AX (0000_8000 / 0x8000)
    SI = AX;
    CheckExternalEvents(cs1, 0x8005);
    // MOV BX,word ptr [BP + -0x24] (0000_8002 / 0x8002)
    BX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x8009);
    // MOV ES,word ptr [0x5434] (0000_8005 / 0x8005)
    ES = UInt16[DS, 0x5434];
    CheckExternalEvents(cs1, 0x800E);
    // MOV AL,byte ptr ES:[BX + 0x2cf4] (0000_8009 / 0x8009)
    AL = UInt8[ES, (ushort)(BX + 0x2CF4)];
    CheckExternalEvents(cs1, 0x8012);
    // MOV ES,word ptr [0x5412] (0000_800E / 0x800E)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8017);
    // MOV byte ptr ES:[SI + 0xc61f],AL (0000_8012 / 0x8012)
    UInt8[ES, (ushort)(SI + 0xC61F)] = AL;
    CheckExternalEvents(cs1, 0x801C);
    // CALLF 0x0000:30dd (0000_8017 / 0x8017)
    FarCall(cs1, 0x801C, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs1, 0x8020);
    // MOV ES,word ptr [0x5412] (0000_801C / 0x801C)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8025);
    // MOV byte ptr ES:[SI + 0xc615],AL (0000_8020 / 0x8020)
    UInt8[ES, (ushort)(SI + 0xC615)] = AL;
    CheckExternalEvents(cs1, 0x8028);
    // MOV AX,0x11 (0000_8025 / 0x8025)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x802B);
    // IMUL word ptr [BP + -0x20] (0000_8028 / 0x8028)
    int resImul0000_8028 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_8028);
    DX = (ushort)(resImul0000_8028 >> 16);
    CheckExternalEvents(cs1, 0x802D);
    // MOV SI,AX (0000_802B / 0x802B)
    SI = AX;
    CheckExternalEvents(cs1, 0x802F);
    // MOV AL,0xa (0000_802D / 0x802D)
    AL = 0xA;
    CheckExternalEvents(cs1, 0x8034);
    // IMUL byte ptr ES:[SI + 0xc615] (0000_802F / 0x802F)
    short resImul0000_802F = Alu.Imul8((sbyte)AL, (sbyte)UInt8[ES, (ushort)(SI + 0xC615)]);
    AL = (byte)(resImul0000_802F);
    AH = (byte)(resImul0000_802F >> 8);
    CheckExternalEvents(cs1, 0x8039);
    // MOV byte ptr ES:[SI + 0xc623],AL (0000_8034 / 0x8034)
    UInt8[ES, (ushort)(SI + 0xC623)] = AL;
    CheckExternalEvents(cs1, 0x803E);
    // CALLF 0x0000:30dd (0000_8039 / 0x8039)
    FarCall(cs1, 0x803E, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs1, 0x8042);
    // MOV ES,word ptr [0x5412] (0000_803E / 0x803E)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8047);
    // MOV byte ptr ES:[SI + 0xc616],AL (0000_8042 / 0x8042)
    UInt8[ES, (ushort)(SI + 0xC616)] = AL;
    CheckExternalEvents(cs1, 0x804C);
    // MOV word ptr [BP + -0x24],0x0 (0000_8047 / 0x8047)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x0;
    label_0000_804C_0804C:
    CheckExternalEvents(cs1, 0x8051);
    // CALLF 0x1000:aab0 (0000_804C / 0x804C)
    FarCall(cs1, 0x8051, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x8053);
    // AND AL,0x3 (0000_8051 / 0x8051)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    CheckExternalEvents(cs1, 0x8055);
    // MOV CX,AX (0000_8053 / 0x8053)
    CX = AX;
    CheckExternalEvents(cs1, 0x8058);
    // MOV AX,0x11 (0000_8055 / 0x8055)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x805B);
    // IMUL word ptr [BP + -0x20] (0000_8058 / 0x8058)
    int resImul0000_8058 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_8058);
    DX = (ushort)(resImul0000_8058 >> 16);
    CheckExternalEvents(cs1, 0x805D);
    // MOV BX,AX (0000_805B / 0x805B)
    BX = AX;
    CheckExternalEvents(cs1, 0x8060);
    // ADD BX,word ptr [BP + -0x24] (0000_805D / 0x805D)
    // BX += UInt16[SS, (ushort)(BP - 0x24)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs1, 0x8064);
    // MOV ES,word ptr [0x5412] (0000_8060 / 0x8060)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8069);
    // MOV byte ptr ES:[BX + 0xc618],CL (0000_8064 / 0x8064)
    UInt8[ES, (ushort)(BX + 0xC618)] = CL;
    CheckExternalEvents(cs1, 0x806C);
    // INC word ptr [BP + -0x24] (0000_8069 / 0x8069)
    UInt16[SS, (ushort)(BP - 0x24)]++;
    CheckExternalEvents(cs1, 0x8070);
    // CMP word ptr [BP + -0x24],0x7 (0000_806C / 0x806C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x24)], 0x7);
    CheckExternalEvents(cs1, 0x8072);
    // JL 0x0000:804c (0000_8070 / 0x8070)
    if(SignFlag != OverflowFlag) {
      goto label_0000_804C_0804C;
    }
    CheckExternalEvents(cs1, 0x8077);
    // CALLF 0x1000:aab0 (0000_8072 / 0x8072)
    FarCall(cs1, 0x8077, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x8079);
    // AND AL,0x3 (0000_8077 / 0x8077)
    // AL &= 0x3;
    AL = Alu.And8(AL, 0x3);
    CheckExternalEvents(cs1, 0x807B);
    // MOV CX,AX (0000_8079 / 0x8079)
    CX = AX;
    CheckExternalEvents(cs1, 0x807E);
    // MOV AX,0x11 (0000_807B / 0x807B)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x8081);
    // IMUL word ptr [BP + -0x20] (0000_807E / 0x807E)
    int resImul0000_807E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_807E);
    DX = (ushort)(resImul0000_807E >> 16);
    CheckExternalEvents(cs1, 0x8083);
    // MOV BX,AX (0000_8081 / 0x8081)
    BX = AX;
    CheckExternalEvents(cs1, 0x8087);
    // MOV ES,word ptr [0x5412] (0000_8083 / 0x8083)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x808C);
    // MOV byte ptr ES:[BX + 0xc621],CL (0000_8087 / 0x8087)
    UInt8[ES, (ushort)(BX + 0xC621)] = CL;
    CheckExternalEvents(cs1, 0x8091);
    // CALLF 0x0000:30dd (0000_808C / 0x808C)
    FarCall(cs1, 0x8091, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs1, 0x8094);
    // MOV word ptr [BP + -0x36],AX (0000_8091 / 0x8091)
    UInt16[SS, (ushort)(BP - 0x36)] = AX;
    CheckExternalEvents(cs1, 0x8099);
    // CALLF 0x0000:30dd (0000_8094 / 0x8094)
    FarCall(cs1, 0x8099, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs1, 0x809C);
    // ADD AL,byte ptr [BP + -0x36] (0000_8099 / 0x8099)
    // AL += UInt8[SS, (ushort)(BP - 0x36)];
    AL = Alu.Add8(AL, UInt8[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs1, 0x809E);
    // MOV CX,AX (0000_809C / 0x809C)
    CX = AX;
    CheckExternalEvents(cs1, 0x80A1);
    // MOV AX,0x11 (0000_809E / 0x809E)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x80A4);
    // IMUL word ptr [BP + -0x20] (0000_80A1 / 0x80A1)
    int resImul0000_80A1 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_80A1);
    DX = (ushort)(resImul0000_80A1 >> 16);
    CheckExternalEvents(cs1, 0x80A6);
    // MOV BX,AX (0000_80A4 / 0x80A4)
    BX = AX;
    CheckExternalEvents(cs1, 0x80AA);
    // MOV ES,word ptr [0x5412] (0000_80A6 / 0x80A6)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x80AF);
    // MOV byte ptr ES:[BX + 0xc622],CL (0000_80AA / 0x80AA)
    UInt8[ES, (ushort)(BX + 0xC622)] = CL;
    label_0000_80AF_080AF:
    CheckExternalEvents(cs1, 0x80B2);
    // INC word ptr [BP + -0x20] (0000_80AF / 0x80AF)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs1, 0x80B6);
    // CMP word ptr [BP + -0x20],0x10 (0000_80B2 / 0x80B2)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x10);
    CheckExternalEvents(cs1, 0x80B8);
    // JGE 0x0000:80bb (0000_80B6 / 0x80B6)
    if(SignFlag == OverflowFlag) {
      goto label_0000_80BB_080BB;
    }
    CheckExternalEvents(cs1, 0x80BB);
    // JMP 0x0000:7fa6 (0000_80B8 / 0x80B8)
    goto label_0000_7FA6_07FA6;
    label_0000_80BB_080BB:
    CheckExternalEvents(cs1, 0x80C0);
    // MOV word ptr [BP + -0x20],0x4 (0000_80BB / 0x80BB)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x4;
    label_0000_80C0_080C0:
    CheckExternalEvents(cs1, 0x80C3);
    // MOV AX,0x7d (0000_80C0 / 0x80C0)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x80C6);
    // IMUL word ptr [BP + -0x20] (0000_80C3 / 0x80C3)
    int resImul0000_80C3 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_80C3);
    DX = (ushort)(resImul0000_80C3 >> 16);
    CheckExternalEvents(cs1, 0x80C8);
    // MOV BX,AX (0000_80C6 / 0x80C6)
    BX = AX;
    CheckExternalEvents(cs1, 0x80CC);
    // MOV ES,word ptr [0x5412] (0000_80C8 / 0x80C8)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x80D2);
    // MOV byte ptr ES:[BX + 0xc724],0xff (0000_80CC / 0x80CC)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0xFF;
    CheckExternalEvents(cs1, 0x80D7);
    // CALLF 0x1000:aab0 (0000_80D2 / 0x80D2)
    FarCall(cs1, 0x80D7, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x80D9);
    // TEST AL,0x1 (0000_80D7 / 0x80D7)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs1, 0x80DB);
    // JNZ 0x0000:80de (0000_80D9 / 0x80D9)
    if(!ZeroFlag) {
      goto label_0000_80DE_080DE;
    }
    CheckExternalEvents(cs1, 0x80DE);
    // JMP 0x0000:8163 (0000_80DB / 0x80DB)
    goto label_0000_8163_08163;
    label_0000_80DE_080DE:
    CheckExternalEvents(cs1, 0x80E1);
    // MOV AX,0x7d (0000_80DE / 0x80DE)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x80E4);
    // IMUL word ptr [BP + -0x20] (0000_80E1 / 0x80E1)
    int resImul0000_80E1 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_80E1);
    DX = (ushort)(resImul0000_80E1 >> 16);
    CheckExternalEvents(cs1, 0x80E6);
    // MOV BX,AX (0000_80E4 / 0x80E4)
    BX = AX;
    CheckExternalEvents(cs1, 0x80EA);
    // MOV ES,word ptr [0x5412] (0000_80E6 / 0x80E6)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x80F0);
    // CMP byte ptr ES:[BX + 0xc530],0xff (0000_80EA / 0x80EA)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC530)], 0xFF);
    CheckExternalEvents(cs1, 0x80F2);
    // JZ 0x0000:8163 (0000_80F0 / 0x80F0)
    if(ZeroFlag) {
      goto label_0000_8163_08163;
    }
    CheckExternalEvents(cs1, 0x80F7);
    // CALLF 0x1000:aab0 (0000_80F2 / 0x80F2)
    FarCall(cs1, 0x80F7, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x80F8);
    // CWD  (0000_80F7 / 0x80F7)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0x80FB);
    // MOV CX,0x3 (0000_80F8 / 0x80F8)
    CX = 0x3;
    CheckExternalEvents(cs1, 0x80FD);
    // IDIV CX (0000_80FB / 0x80FB)
    int op1IDiv0000_80FB = (int)(DX << 16 | AX);
    short op2IDiv0000_80FB = (short)CX;
    short? resIDiv0000_80FB = Alu.IDiv16(op1IDiv0000_80FB, op2IDiv0000_80FB);
    if(resIDiv0000_80FB == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIDiv0000_80FB.Value;
    DX = (ushort)(op1IDiv0000_80FB % op2IDiv0000_80FB);
    CheckExternalEvents(cs1, 0x8100);
    // MOV word ptr [BP + -0x34],DX (0000_80FD / 0x80FD)
    UInt16[SS, (ushort)(BP - 0x34)] = DX;
    CheckExternalEvents(cs1, 0x8102);
    // MOV BX,DX (0000_8100 / 0x8100)
    BX = DX;
    CheckExternalEvents(cs1, 0x8104);
    // SHL BX,0x1 (0000_8102 / 0x8102)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x8106);
    // SHL BX,0x1 (0000_8104 / 0x8104)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x810A);
    // MOV ES,word ptr [0x5436] (0000_8106 / 0x8106)
    ES = UInt16[DS, 0x5436];
    CheckExternalEvents(cs1, 0x810F);
    // MOV AX,word ptr ES:[BX + 0x2df8] (0000_810A / 0x810A)
    AX = UInt16[ES, (ushort)(BX + 0x2DF8)];
    CheckExternalEvents(cs1, 0x8114);
    // MOV DX,word ptr ES:[BX + 0x2dfa] (0000_810F / 0x810F)
    DX = UInt16[ES, (ushort)(BX + 0x2DFA)];
    CheckExternalEvents(cs1, 0x8117);
    // MOV word ptr [BP + -0xa],AX (0000_8114 / 0x8114)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x811A);
    // MOV word ptr [BP + -0x8],DX (0000_8117 / 0x8117)
    UInt16[SS, (ushort)(BP - 0x8)] = DX;
    CheckExternalEvents(cs1, 0x811F);
    // MOV word ptr [BP + -0x1a],0x0 (0000_811A / 0x811A)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x0;
    label_0000_811F_0811F:
    CheckExternalEvents(cs1, 0x8122);
    // LES BX,[BP + -0xa] (0000_811F / 0x811F)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    ES = UInt16[SS, (ushort)(BP - 0xA + 2)];
    CheckExternalEvents(cs1, 0x8125);
    // INC word ptr [BP + -0xa] (0000_8122 / 0x8122)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x8128);
    // MOV AL,byte ptr ES:[BX] (0000_8125 / 0x8125)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs1, 0x812A);
    // MOV CX,AX (0000_8128 / 0x8128)
    CX = AX;
    CheckExternalEvents(cs1, 0x812D);
    // MOV AX,0x7d (0000_812A / 0x812A)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8130);
    // IMUL word ptr [BP + -0x20] (0000_812D / 0x812D)
    int resImul0000_812D = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_812D);
    DX = (ushort)(resImul0000_812D >> 16);
    CheckExternalEvents(cs1, 0x8132);
    // MOV BX,AX (0000_8130 / 0x8130)
    BX = AX;
    CheckExternalEvents(cs1, 0x8135);
    // ADD BX,word ptr [BP + -0x1a] (0000_8132 / 0x8132)
    // BX += UInt16[SS, (ushort)(BP - 0x1A)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0x8139);
    // MOV ES,word ptr [0x5412] (0000_8135 / 0x8135)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x813E);
    // MOV byte ptr ES:[BX + 0xc724],CL (0000_8139 / 0x8139)
    UInt8[ES, (ushort)(BX + 0xC724)] = CL;
    CheckExternalEvents(cs1, 0x8141);
    // INC word ptr [BP + -0x1a] (0000_813E / 0x813E)
    UInt16[SS, (ushort)(BP - 0x1A)]++;
    CheckExternalEvents(cs1, 0x8145);
    // CMP word ptr [BP + -0x1a],0x7d (0000_8141 / 0x8141)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1A)], 0x7D);
    CheckExternalEvents(cs1, 0x8147);
    // JL 0x0000:811f (0000_8145 / 0x8145)
    if(SignFlag != OverflowFlag) {
      goto label_0000_811F_0811F;
    }
    CheckExternalEvents(cs1, 0x814A);
    // MOV BX,word ptr [BP + -0x20] (0000_8147 / 0x8147)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x814E);
    // MOV ES,word ptr [0x541c] (0000_814A / 0x814A)
    ES = UInt16[DS, 0x541C];
    CheckExternalEvents(cs1, 0x8154);
    // MOV byte ptr ES:[BX + 0xd566],0x0 (0000_814E / 0x814E)
    UInt8[ES, (ushort)(BX + 0xD566)] = 0x0;
    CheckExternalEvents(cs1, 0x8158);
    // CMP word ptr [BP + -0x34],0x0 (0000_8154 / 0x8154)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x34)], 0x0);
    CheckExternalEvents(cs1, 0x815A);
    // JZ 0x0000:8163 (0000_8158 / 0x8158)
    if(ZeroFlag) {
      goto label_0000_8163_08163;
    }
    CheckExternalEvents(cs1, 0x815D);
    // MOV BX,word ptr [BP + -0x20] (0000_815A / 0x815A)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x8163);
    // MOV byte ptr ES:[BX + 0xd566],0x92 (0000_815D / 0x815D)
    UInt8[ES, (ushort)(BX + 0xD566)] = 0x92;
    label_0000_8163_08163:
    CheckExternalEvents(cs1, 0x8166);
    // INC word ptr [BP + -0x20] (0000_8163 / 0x8163)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs1, 0x816A);
    // CMP word ptr [BP + -0x20],0x8 (0000_8166 / 0x8166)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x8);
    CheckExternalEvents(cs1, 0x816C);
    // JGE 0x0000:816f (0000_816A / 0x816A)
    if(SignFlag == OverflowFlag) {
      goto label_0000_816F_0816F;
    }
    CheckExternalEvents(cs1, 0x816F);
    // JMP 0x0000:80c0 (0000_816C / 0x816C)
    goto label_0000_80C0_080C0;
    label_0000_816F_0816F:
    CheckExternalEvents(cs1, 0x8171);
    // SUB AX,AX (0000_816F / 0x816F)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x8174);
    // MOV word ptr [BP + -0x16],AX (0000_8171 / 0x8171)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x8177);
    // MOV word ptr [BP + -0x14],AX (0000_8174 / 0x8174)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0x817A);
    // MOV word ptr [BP + -0x2c],AX (0000_8177 / 0x8177)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs1, 0x817F);
    // MOV word ptr [BP + -0x20],0x8 (0000_817A / 0x817A)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x8;
    CheckExternalEvents(cs1, 0x8182);
    // JMP 0x0000:8302 (0000_817F / 0x817F)
    goto label_0000_8302_08302;
    label_0000_8182_08182:
    CheckExternalEvents(cs1, 0x8185);
    // INC word ptr [BP + -0x28] (0000_8182 / 0x8182)
    UInt16[SS, (ushort)(BP - 0x28)]++;
    CheckExternalEvents(cs1, 0x8188);
    // INC word ptr [BP + -0x2c] (0000_8185 / 0x8185)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs1, 0x818C);
    // CMP word ptr [BP + -0x2c],0x10 (0000_8188 / 0x8188)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2C)], 0x10);
    CheckExternalEvents(cs1, 0x818E);
    // JLE 0x0000:819c (0000_818C / 0x818C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_819C_0819C;
    }
    CheckExternalEvents(cs1, 0x8193);
    // MOV word ptr [BP + -0x2c],0x0 (0000_818E / 0x818E)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    CheckExternalEvents(cs1, 0x8196);
    // MOV AX,word ptr [BP + -0x30] (0000_8193 / 0x8193)
    AX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs1, 0x8199);
    // MOV word ptr [BP + -0x28],AX (0000_8196 / 0x8196)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x819C);
    // INC word ptr [BP + -0x2e] (0000_8199 / 0x8199)
    UInt16[SS, (ushort)(BP - 0x2E)]++;
    label_0000_819C_0819C:
    CheckExternalEvents(cs1, 0x81A0);
    // CMP word ptr [BP + -0xe],0x0 (0000_819C / 0x819C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs1, 0x81A2);
    // JZ 0x0000:81a5 (0000_81A0 / 0x81A0)
    if(ZeroFlag) {
      goto label_0000_81A5_081A5;
    }
    CheckExternalEvents(cs1, 0x81A5);
    // JMP 0x0000:8324 (0000_81A2 / 0x81A2)
    goto label_0000_8324_08324;
    label_0000_81A5_081A5:
    CheckExternalEvents(cs1, 0x81A8);
    // MOV AX,word ptr [BP + -0x28] (0000_81A5 / 0x81A5)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x81AB);
    // SUB AX,0xd (0000_81A8 / 0x81A8)
    AX -= 0xD;
    CheckExternalEvents(cs1, 0x81AD);
    // SAR AX,0x1 (0000_81AB / 0x81AB)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x81B1);
    // MOV ES,word ptr [0x543e] (0000_81AD / 0x81AD)
    ES = UInt16[DS, 0x543E];
    CheckExternalEvents(cs1, 0x81B6);
    // ADD AX,word ptr ES:[0x9ef] (0000_81B1 / 0x81B1)
    // AX += UInt16[ES, 0x9EF];
    AX = Alu.Add16(AX, UInt16[ES, 0x9EF]);
    CheckExternalEvents(cs1, 0x81B9);
    // MOV word ptr [BP + -0x2],AX (0000_81B6 / 0x81B6)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x81BD);
    // TEST byte ptr [BP + -0x28],0x1 (0000_81B9 / 0x81B9)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x28)], 0x1);
    CheckExternalEvents(cs1, 0x81BF);
    // JNZ 0x0000:81ce (0000_81BD / 0x81BD)
    if(!ZeroFlag) {
      goto label_0000_81CE_081CE;
    }
    CheckExternalEvents(cs1, 0x81C3);
    // MOV ES,word ptr [0x542c] (0000_81BF / 0x81BF)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x81C9);
    // TEST byte ptr ES:[0xa44b],0x1 (0000_81C3 / 0x81C3)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs1, 0x81CB);
    // JZ 0x0000:81ce (0000_81C9 / 0x81C9)
    if(ZeroFlag) {
      goto label_0000_81CE_081CE;
    }
    CheckExternalEvents(cs1, 0x81CE);
    // INC word ptr [BP + -0x2] (0000_81CB / 0x81CB)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2)]);
    label_0000_81CE_081CE:
    CheckExternalEvents(cs1, 0x81D1);
    // MOV AX,word ptr [BP + -0x2e] (0000_81CE / 0x81CE)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x81D3);
    // SAR AX,0x1 (0000_81D1 / 0x81D1)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x81D6);
    // MOV CX,0x18 (0000_81D3 / 0x81D3)
    CX = 0x18;
    CheckExternalEvents(cs1, 0x81D8);
    // IMUL CX (0000_81D6 / 0x81D6)
    int resImul0000_81D6 = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_81D6);
    DX = (ushort)(resImul0000_81D6 >> 16);
    CheckExternalEvents(cs1, 0x81DC);
    // MOV ES,word ptr [0x5440] (0000_81D8 / 0x81D8)
    ES = UInt16[DS, 0x5440];
    CheckExternalEvents(cs1, 0x81E1);
    // ADD AX,word ptr ES:[0x9f1] (0000_81DC / 0x81DC)
    // AX += UInt16[ES, 0x9F1];
    AX = Alu.Add16(AX, UInt16[ES, 0x9F1]);
    CheckExternalEvents(cs1, 0x81E4);
    // MOV word ptr [BP + -0x4],AX (0000_81E1 / 0x81E1)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x81E8);
    // TEST byte ptr [BP + -0x2e],0x1 (0000_81E4 / 0x81E4)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x2E)], 0x1);
    CheckExternalEvents(cs1, 0x81EA);
    // JZ 0x0000:81fa (0000_81E8 / 0x81E8)
    if(ZeroFlag) {
      goto label_0000_81FA_081FA;
    }
    CheckExternalEvents(cs1, 0x81EE);
    // MOV ES,word ptr [0x542a] (0000_81EA / 0x81EA)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x81F4);
    // TEST byte ptr ES:[0xa44d],0x1 (0000_81EE / 0x81EE)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs1, 0x81F6);
    // JZ 0x0000:81fa (0000_81F4 / 0x81F4)
    if(ZeroFlag) {
      goto label_0000_81FA_081FA;
    }
    CheckExternalEvents(cs1, 0x81FA);
    // ADD word ptr [BP + -0x4],0x18 (0000_81F6 / 0x81F6)
    UInt16[SS, (ushort)(BP - 0x4)] += 0x18;
    label_0000_81FA_081FA:
    CheckExternalEvents(cs1, 0x81FE);
    // CMP word ptr [BP + -0x2],0x0 (0000_81FA / 0x81FA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0x8200);
    // JGE 0x0000:8203 (0000_81FE / 0x81FE)
    if(SignFlag == OverflowFlag) {
      goto label_0000_8203_08203;
    }
    CheckExternalEvents(cs1, 0x8203);
    // JMP 0x0000:82ad (0000_8200 / 0x8200)
    goto label_0000_82AD_082AD;
    label_0000_8203_08203:
    CheckExternalEvents(cs1, 0x8207);
    // CMP word ptr [BP + -0x2],0x18 (0000_8203 / 0x8203)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs1, 0x8209);
    // JL 0x0000:820c (0000_8207 / 0x8207)
    if(SignFlag != OverflowFlag) {
      goto label_0000_820C_0820C;
    }
    CheckExternalEvents(cs1, 0x820C);
    // JMP 0x0000:82ad (0000_8209 / 0x8209)
    goto label_0000_82AD_082AD;
    label_0000_820C_0820C:
    CheckExternalEvents(cs1, 0x8210);
    // CMP word ptr [BP + -0x4],0x0 (0000_820C / 0x820C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x8212);
    // JGE 0x0000:8215 (0000_8210 / 0x8210)
    if(SignFlag == OverflowFlag) {
      goto label_0000_8215_08215;
    }
    CheckExternalEvents(cs1, 0x8215);
    // JMP 0x0000:82ad (0000_8212 / 0x8212)
    goto label_0000_82AD_082AD;
    label_0000_8215_08215:
    CheckExternalEvents(cs1, 0x821A);
    // CMP word ptr [BP + -0x4],0x240 (0000_8215 / 0x8215)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x240);
    CheckExternalEvents(cs1, 0x821C);
    // JL 0x0000:821f (0000_821A / 0x821A)
    if(SignFlag != OverflowFlag) {
      goto label_0000_821F_0821F;
    }
    CheckExternalEvents(cs1, 0x821F);
    // JMP 0x0000:82ad (0000_821C / 0x821C)
    goto label_0000_82AD_082AD;
    label_0000_821F_0821F:
    CheckExternalEvents(cs1, 0x8222);
    // MOV AX,word ptr [BP + -0x28] (0000_821F / 0x821F)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x8226);
    // MOV ES,word ptr [0x542c] (0000_8222 / 0x8222)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x822B);
    // ADD AX,word ptr ES:[0xa44b] (0000_8226 / 0x8226)
    AX += UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x822E);
    // SUB AX,0x1a (0000_822B / 0x822B)
    // AX -= 0x1A;
    AX = Alu.Sub16(AX, 0x1A);
    CheckExternalEvents(cs1, 0x8231);
    // MOV word ptr [BP + -0x10],AX (0000_822E / 0x822E)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x8235);
    // TEST byte ptr [BP + -0x10],0x80 (0000_8231 / 0x8231)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x10)], 0x80);
    CheckExternalEvents(cs1, 0x8237);
    // JZ 0x0000:8249 (0000_8235 / 0x8235)
    if(ZeroFlag) {
      goto label_0000_8249_08249;
    }
    CheckExternalEvents(cs1, 0x823B);
    // CMP word ptr [BP + -0x28],0x1a (0000_8237 / 0x8237)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x28)], 0x1A);
    CheckExternalEvents(cs1, 0x823D);
    // JGE 0x0000:8244 (0000_823B / 0x823B)
    if(SignFlag == OverflowFlag) {
      goto label_0000_8244_08244;
    }
    CheckExternalEvents(cs1, 0x8242);
    // AND word ptr [BP + -0x10],0xf7f (0000_823D / 0x823D)
    // UInt16[SS, (ushort)(BP - 0x10)] &= 0xF7F;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x10)], 0xF7F);
    CheckExternalEvents(cs1, 0x8244);
    // JMP 0x0000:8249 (0000_8242 / 0x8242)
    goto label_0000_8249_08249;
    label_0000_8244_08244:
    CheckExternalEvents(cs1, 0x8249);
    // ADD word ptr [BP + -0x10],0x80 (0000_8244 / 0x8244)
    // UInt16[SS, (ushort)(BP - 0x10)] += 0x80;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x10)], 0x80);
    label_0000_8249_08249:
    CheckExternalEvents(cs1, 0x824C);
    // MOV AX,word ptr [BP + -0x2e] (0000_8249 / 0x8249)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x8250);
    // MOV ES,word ptr [0x542a] (0000_824C / 0x824C)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x8255);
    // ADD AX,word ptr ES:[0xa44d] (0000_8250 / 0x8250)
    AX += UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x8258);
    // SUB AX,0xc (0000_8255 / 0x8255)
    // AX -= 0xC;
    AX = Alu.Sub16(AX, 0xC);
    CheckExternalEvents(cs1, 0x825B);
    // MOV word ptr [BP + -0x12],AX (0000_8258 / 0x8258)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0x825F);
    // TEST byte ptr [BP + -0x12],0x80 (0000_825B / 0x825B)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x12)], 0x80);
    CheckExternalEvents(cs1, 0x8261);
    // JZ 0x0000:8273 (0000_825F / 0x825F)
    if(ZeroFlag) {
      goto label_0000_8273_08273;
    }
    CheckExternalEvents(cs1, 0x8265);
    // CMP word ptr [BP + -0x2e],0xc (0000_8261 / 0x8261)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2E)], 0xC);
    CheckExternalEvents(cs1, 0x8267);
    // JGE 0x0000:826e (0000_8265 / 0x8265)
    if(SignFlag == OverflowFlag) {
      goto label_0000_826E_0826E;
    }
    CheckExternalEvents(cs1, 0x826C);
    // AND word ptr [BP + -0x12],0xf07f (0000_8267 / 0x8267)
    // UInt16[SS, (ushort)(BP - 0x12)] &= 0xF07F;
    UInt16[SS, (ushort)(BP - 0x12)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x12)], 0xF07F);
    CheckExternalEvents(cs1, 0x826E);
    // JMP 0x0000:8273 (0000_826C / 0x826C)
    goto label_0000_8273_08273;
    label_0000_826E_0826E:
    CheckExternalEvents(cs1, 0x8273);
    // ADD word ptr [BP + -0x12],0xf80 (0000_826E / 0x826E)
    // UInt16[SS, (ushort)(BP - 0x12)] += 0xF80;
    UInt16[SS, (ushort)(BP - 0x12)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x12)], 0xF80);
    label_0000_8273_08273:
    CheckExternalEvents(cs1, 0x8276);
    // MOV SI,word ptr [BP + -0x20] (0000_8273 / 0x8273)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x8278);
    // SHL SI,0x1 (0000_8276 / 0x8276)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x827B);
    // MOV AX,word ptr [BP + -0x10] (0000_8278 / 0x8278)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0x827F);
    // MOV ES,word ptr [0x5432] (0000_827B / 0x827B)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x8284);
    // MOV word ptr ES:[SI + 0x4014],AX (0000_827F / 0x827F)
    UInt16[ES, (ushort)(SI + 0x4014)] = AX;
    CheckExternalEvents(cs1, 0x8287);
    // MOV AX,word ptr [BP + -0x12] (0000_8284 / 0x8284)
    AX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0x828B);
    // MOV ES,word ptr [0x5430] (0000_8287 / 0x8287)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x8290);
    // MOV word ptr ES:[SI + 0x4046],AX (0000_828B / 0x828B)
    UInt16[ES, (ushort)(SI + 0x4046)] = AX;
    CheckExternalEvents(cs1, 0x8293);
    // MOV BX,word ptr [BP + -0x20] (0000_8290 / 0x8290)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x8297);
    // MOV ES,word ptr [0x5442] (0000_8293 / 0x8293)
    ES = UInt16[DS, 0x5442];
    CheckExternalEvents(cs1, 0x829D);
    // MOV byte ptr ES:[BX + 0x40a2],0x10 (0000_8297 / 0x8297)
    UInt8[ES, (ushort)(BX + 0x40A2)] = 0x10;
    CheckExternalEvents(cs1, 0x82A1);
    // MOV ES,word ptr [0x542e] (0000_829D / 0x829D)
    ES = UInt16[DS, 0x542E];
    CheckExternalEvents(cs1, 0x82A8);
    // MOV word ptr ES:[SI + 0x407a],0x1 (0000_82A1 / 0x82A1)
    UInt16[ES, (ushort)(SI + 0x407A)] = 0x1;
    CheckExternalEvents(cs1, 0x82AB);
    // INC word ptr [BP + -0x14] (0000_82A8 / 0x82A8)
    UInt16[SS, (ushort)(BP - 0x14)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0x82AD);
    // JMP 0x0000:82e5 (0000_82AB / 0x82AB)
    goto label_0000_82E5_082E5;
    label_0000_82AD_082AD:
    CheckExternalEvents(cs1, 0x82B0);
    // MOV SI,word ptr [BP + -0x20] (0000_82AD / 0x82AD)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x82B2);
    // SHL SI,0x1 (0000_82B0 / 0x82B0)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x82B5);
    // MOV AX,0xffff (0000_82B2 / 0x82B2)
    AX = 0xFFFF;
    CheckExternalEvents(cs1, 0x82B9);
    // MOV ES,word ptr [0x5430] (0000_82B5 / 0x82B5)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x82BE);
    // MOV word ptr ES:[SI + 0x4046],AX (0000_82B9 / 0x82B9)
    UInt16[ES, (ushort)(SI + 0x4046)] = AX;
    CheckExternalEvents(cs1, 0x82C2);
    // MOV ES,word ptr [0x5432] (0000_82BE / 0x82BE)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x82C7);
    // MOV word ptr ES:[SI + 0x4014],AX (0000_82C2 / 0x82C2)
    UInt16[ES, (ushort)(SI + 0x4014)] = AX;
    CheckExternalEvents(cs1, 0x82C9);
    // MOV CX,AX (0000_82C7 / 0x82C7)
    CX = AX;
    CheckExternalEvents(cs1, 0x82CC);
    // MOV AX,0x11 (0000_82C9 / 0x82C9)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x82CF);
    // IMUL word ptr [BP + -0x20] (0000_82CC / 0x82CC)
    int resImul0000_82CC = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_82CC);
    DX = (ushort)(resImul0000_82CC >> 16);
    CheckExternalEvents(cs1, 0x82D1);
    // MOV BX,AX (0000_82CF / 0x82CF)
    BX = AX;
    CheckExternalEvents(cs1, 0x82D5);
    // MOV ES,word ptr [0x5412] (0000_82D1 / 0x82D1)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x82DA);
    // MOV byte ptr ES:[BX + 0xc614],CL (0000_82D5 / 0x82D5)
    UInt8[ES, (ushort)(BX + 0xC614)] = CL;
    CheckExternalEvents(cs1, 0x82DE);
    // MOV ES,word ptr [0x542e] (0000_82DA / 0x82DA)
    ES = UInt16[DS, 0x542E];
    CheckExternalEvents(cs1, 0x82E5);
    // MOV word ptr ES:[SI + 0x407a],0x0 (0000_82DE / 0x82DE)
    UInt16[ES, (ushort)(SI + 0x407A)] = 0x0;
    label_0000_82E5_082E5:
    CheckExternalEvents(cs1, 0x82E8);
    // INC word ptr [BP + -0x28] (0000_82E5 / 0x82E5)
    UInt16[SS, (ushort)(BP - 0x28)]++;
    CheckExternalEvents(cs1, 0x82EB);
    // INC word ptr [BP + -0x2c] (0000_82E8 / 0x82E8)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs1, 0x82EF);
    // CMP word ptr [BP + -0x2c],0x10 (0000_82EB / 0x82EB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2C)], 0x10);
    CheckExternalEvents(cs1, 0x82F1);
    // JLE 0x0000:82ff (0000_82EF / 0x82EF)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_82FF_082FF;
    }
    CheckExternalEvents(cs1, 0x82F6);
    // MOV word ptr [BP + -0x2c],0x0 (0000_82F1 / 0x82F1)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    CheckExternalEvents(cs1, 0x82F9);
    // MOV AX,word ptr [BP + -0x30] (0000_82F6 / 0x82F6)
    AX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs1, 0x82FC);
    // MOV word ptr [BP + -0x28],AX (0000_82F9 / 0x82F9)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x82FF);
    // INC word ptr [BP + -0x2e] (0000_82FC / 0x82FC)
    UInt16[SS, (ushort)(BP - 0x2E)]++;
    label_0000_82FF_082FF:
    CheckExternalEvents(cs1, 0x8302);
    // INC word ptr [BP + -0x20] (0000_82FF / 0x82FF)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    label_0000_8302_08302:
    CheckExternalEvents(cs1, 0x8306);
    // CMP word ptr [BP + -0x20],0x10 (0000_8302 / 0x8302)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x10);
    CheckExternalEvents(cs1, 0x8308);
    // JL 0x0000:830b (0000_8306 / 0x8306)
    if(SignFlag != OverflowFlag) {
      goto label_0000_830B_0830B;
    }
    CheckExternalEvents(cs1, 0x830B);
    // JMP 0x0000:83a5 (0000_8308 / 0x8308)
    goto label_0000_83A5_083A5;
    label_0000_830B_0830B:
    CheckExternalEvents(cs1, 0x830E);
    // MOV AX,0x11 (0000_830B / 0x830B)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x8311);
    // IMUL word ptr [BP + -0x20] (0000_830E / 0x830E)
    int resImul0000_830E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_830E);
    DX = (ushort)(resImul0000_830E >> 16);
    CheckExternalEvents(cs1, 0x8313);
    // MOV BX,AX (0000_8311 / 0x8311)
    BX = AX;
    CheckExternalEvents(cs1, 0x8317);
    // MOV ES,word ptr [0x5412] (0000_8313 / 0x8313)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x831D);
    // CMP byte ptr ES:[BX + 0xc614],0xff (0000_8317 / 0x8317)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0x831F);
    // JZ 0x0000:82ff (0000_831D / 0x831D)
    if(ZeroFlag) {
      goto label_0000_82FF_082FF;
    }
    CheckExternalEvents(cs1, 0x8324);
    // MOV word ptr [BP + -0xe],0x1 (0000_831F / 0x831F)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    label_0000_8324_08324:
    CheckExternalEvents(cs1, 0x8327);
    // MOV AX,word ptr [BP + -0x2e] (0000_8324 / 0x8324)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x8329);
    // SAR AX,0x1 (0000_8327 / 0x8327)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x832C);
    // MOV CX,0x18 (0000_8329 / 0x8329)
    CX = 0x18;
    CheckExternalEvents(cs1, 0x832E);
    // IMUL CX (0000_832C / 0x832C)
    int resImul0000_832C = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_832C);
    DX = (ushort)(resImul0000_832C >> 16);
    CheckExternalEvents(cs1, 0x8331);
    // MOV CX,word ptr [BP + -0x28] (0000_832E / 0x832E)
    CX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x8334);
    // SUB CX,0xd (0000_8331 / 0x8331)
    CX -= 0xD;
    CheckExternalEvents(cs1, 0x8336);
    // SAR CX,0x1 (0000_8334 / 0x8334)
    CX = Alu.Sar16(CX, 0x1);
    CheckExternalEvents(cs1, 0x8338);
    // ADD AX,CX (0000_8336 / 0x8336)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs1, 0x833C);
    // MOV ES,word ptr [0x5438] (0000_8338 / 0x8338)
    ES = UInt16[DS, 0x5438];
    CheckExternalEvents(cs1, 0x8341);
    // ADD AX,word ptr ES:[0x9ed] (0000_833C / 0x833C)
    // AX += UInt16[ES, 0x9ED];
    AX = Alu.Add16(AX, UInt16[ES, 0x9ED]);
    CheckExternalEvents(cs1, 0x8344);
    // MOV word ptr [BP + -0x18],AX (0000_8341 / 0x8341)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs1, 0x8348);
    // TEST byte ptr [BP + -0x28],0x1 (0000_8344 / 0x8344)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x28)], 0x1);
    CheckExternalEvents(cs1, 0x834A);
    // JNZ 0x0000:8359 (0000_8348 / 0x8348)
    if(!ZeroFlag) {
      goto label_0000_8359_08359;
    }
    CheckExternalEvents(cs1, 0x834E);
    // MOV ES,word ptr [0x542c] (0000_834A / 0x834A)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x8354);
    // TEST byte ptr ES:[0xa44b],0x1 (0000_834E / 0x834E)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs1, 0x8356);
    // JZ 0x0000:8359 (0000_8354 / 0x8354)
    if(ZeroFlag) {
      goto label_0000_8359_08359;
    }
    CheckExternalEvents(cs1, 0x8359);
    // INC word ptr [BP + -0x18] (0000_8356 / 0x8356)
    UInt16[SS, (ushort)(BP - 0x18)]++;
    label_0000_8359_08359:
    CheckExternalEvents(cs1, 0x835D);
    // TEST byte ptr [BP + -0x2e],0x1 (0000_8359 / 0x8359)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x2E)], 0x1);
    CheckExternalEvents(cs1, 0x835F);
    // JZ 0x0000:836f (0000_835D / 0x835D)
    if(ZeroFlag) {
      goto label_0000_836F_0836F;
    }
    CheckExternalEvents(cs1, 0x8363);
    // MOV ES,word ptr [0x542a] (0000_835F / 0x835F)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x8369);
    // TEST byte ptr ES:[0xa44d],0x1 (0000_8363 / 0x8363)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs1, 0x836B);
    // JZ 0x0000:836f (0000_8369 / 0x8369)
    if(ZeroFlag) {
      goto label_0000_836F_0836F;
    }
    CheckExternalEvents(cs1, 0x836F);
    // ADD word ptr [BP + -0x18],0x18 (0000_836B / 0x836B)
    // UInt16[SS, (ushort)(BP - 0x18)] += 0x18;
    UInt16[SS, (ushort)(BP - 0x18)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x18)], 0x18);
    label_0000_836F_0836F:
    CheckExternalEvents(cs1, 0x8372);
    // MOV BX,word ptr [BP + -0x18] (0000_836F / 0x836F)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0x8376);
    // MOV ES,word ptr [0x543a] (0000_8372 / 0x8372)
    ES = UInt16[DS, 0x543A];
    CheckExternalEvents(cs1, 0x837B);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0000_8376 / 0x8376)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs1, 0x837D);
    // SUB AH,AH (0000_837B / 0x837B)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x8380);
    // MOV word ptr [BP + -0x1c],AX (0000_837D / 0x837D)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs1, 0x8383);
    // CMP AX,0xf (0000_8380 / 0x8380)
    Alu.Sub16(AX, 0xF);
    CheckExternalEvents(cs1, 0x8385);
    // JG 0x0000:8388 (0000_8383 / 0x8383)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_8388_08388;
    }
    CheckExternalEvents(cs1, 0x8388);
    // JMP 0x0000:8182 (0000_8385 / 0x8385)
    goto label_0000_8182_08182;
    label_0000_8388_08388:
    CheckExternalEvents(cs1, 0x838C);
    // MOV ES,word ptr [0x543c] (0000_8388 / 0x8388)
    ES = UInt16[DS, 0x543C];
    CheckExternalEvents(cs1, 0x8391);
    // CMP word ptr ES:[0x150],AX (0000_838C / 0x838C)
    Alu.Sub16(UInt16[ES, 0x150], AX);
    CheckExternalEvents(cs1, 0x8393);
    // JG 0x0000:8396 (0000_8391 / 0x8391)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_8396_08396;
    }
    CheckExternalEvents(cs1, 0x8396);
    // JMP 0x0000:8182 (0000_8393 / 0x8393)
    goto label_0000_8182_08182;
    label_0000_8396_08396:
    CheckExternalEvents(cs1, 0x8398);
    // OR BX,BX (0000_8396 / 0x8396)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    CheckExternalEvents(cs1, 0x839A);
    // JGE 0x0000:839d (0000_8398 / 0x8398)
    if(SignFlag == OverflowFlag) {
      goto label_0000_839D_0839D;
    }
    CheckExternalEvents(cs1, 0x839D);
    // JMP 0x0000:8182 (0000_839A / 0x839A)
    goto label_0000_8182_08182;
    label_0000_839D_0839D:
    CheckExternalEvents(cs1, 0x83A2);
    // MOV word ptr [BP + -0xe],0x0 (0000_839D / 0x839D)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0x83A5);
    // JMP 0x0000:819c (0000_83A2 / 0x83A2)
    goto label_0000_819C_0819C;
    label_0000_83A5_083A5:
    CheckExternalEvents(cs1, 0x83A8);
    // INC word ptr [BP + -0x28] (0000_83A5 / 0x83A5)
    UInt16[SS, (ushort)(BP - 0x28)]++;
    CheckExternalEvents(cs1, 0x83AB);
    // INC word ptr [BP + -0x2c] (0000_83A8 / 0x83A8)
    UInt16[SS, (ushort)(BP - 0x2C)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs1, 0x83B0);
    // MOV word ptr [BP + -0x20],0x4 (0000_83AB / 0x83AB)
    UInt16[SS, (ushort)(BP - 0x20)] = 0x4;
    CheckExternalEvents(cs1, 0x83B3);
    // JMP 0x0000:8586 (0000_83B0 / 0x83B0)
    goto label_0000_8586_08586;
    label_0000_83B3_083B3:
    CheckExternalEvents(cs1, 0x83B6);
    // INC word ptr [BP + -0x26] (0000_83B3 / 0x83B3)
    UInt16[SS, (ushort)(BP - 0x26)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x26)]);
    label_0000_83B6_083B6:
    CheckExternalEvents(cs1, 0x83B9);
    // MOV BX,word ptr [BP + -0x18] (0000_83B6 / 0x83B6)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0x83BD);
    // MOV ES,word ptr [0x543a] (0000_83B9 / 0x83B9)
    ES = UInt16[DS, 0x543A];
    CheckExternalEvents(cs1, 0x83C2);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0000_83BD / 0x83BD)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs1, 0x83C4);
    // SUB AH,AH (0000_83C2 / 0x83C2)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x83C7);
    // MOV word ptr [BP + -0x1c],AX (0000_83C4 / 0x83C4)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs1, 0x83CA);
    // MOV BX,word ptr [BP + -0x26] (0000_83C7 / 0x83C7)
    BX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs1, 0x83CF);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0000_83CA / 0x83CA)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs1, 0x83D2);
    // MOV word ptr [BP + -0x2a],AX (0000_83CF / 0x83CF)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs1, 0x83D6);
    // CMP word ptr [BP + -0x1c],0xf (0000_83D2 / 0x83D2)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1C)], 0xF);
    CheckExternalEvents(cs1, 0x83D8);
    // JLE 0x0000:8407 (0000_83D6 / 0x83D6)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8407_08407;
    }
    CheckExternalEvents(cs1, 0x83DC);
    // MOV ES,word ptr [0x543c] (0000_83D8 / 0x83D8)
    ES = UInt16[DS, 0x543C];
    CheckExternalEvents(cs1, 0x83DF);
    // MOV AX,word ptr [BP + -0x1c] (0000_83DC / 0x83DC)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs1, 0x83E4);
    // CMP word ptr ES:[0x150],AX (0000_83DF / 0x83DF)
    Alu.Sub16(UInt16[ES, 0x150], AX);
    CheckExternalEvents(cs1, 0x83E6);
    // JLE 0x0000:8407 (0000_83E4 / 0x83E4)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8407_08407;
    }
    CheckExternalEvents(cs1, 0x83EA);
    // CMP word ptr [BP + -0x18],0x0 (0000_83E6 / 0x83E6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0x0);
    CheckExternalEvents(cs1, 0x83EC);
    // JL 0x0000:8407 (0000_83EA / 0x83EA)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8407_08407;
    }
    CheckExternalEvents(cs1, 0x83F0);
    // CMP word ptr [BP + -0x2a],0xf (0000_83EC / 0x83EC)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2A)], 0xF);
    CheckExternalEvents(cs1, 0x83F2);
    // JLE 0x0000:8407 (0000_83F0 / 0x83F0)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8407_08407;
    }
    CheckExternalEvents(cs1, 0x83F5);
    // MOV AX,word ptr [BP + -0x2a] (0000_83F2 / 0x83F2)
    AX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs1, 0x83FA);
    // CMP word ptr ES:[0x150],AX (0000_83F5 / 0x83F5)
    Alu.Sub16(UInt16[ES, 0x150], AX);
    CheckExternalEvents(cs1, 0x83FC);
    // JLE 0x0000:8407 (0000_83FA / 0x83FA)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8407_08407;
    }
    CheckExternalEvents(cs1, 0x83FE);
    // OR BX,BX (0000_83FC / 0x83FC)
    // BX |= BX;
    BX = Alu.Or16(BX, BX);
    CheckExternalEvents(cs1, 0x8400);
    // JL 0x0000:8407 (0000_83FE / 0x83FE)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8407_08407;
    }
    CheckExternalEvents(cs1, 0x8405);
    // MOV word ptr [BP + -0xe],0x0 (0000_8400 / 0x8400)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0x8407);
    // JMP 0x0000:8421 (0000_8405 / 0x8405)
    goto label_0000_8421_08421;
    label_0000_8407_08407:
    CheckExternalEvents(cs1, 0x840A);
    // INC word ptr [BP + -0x28] (0000_8407 / 0x8407)
    UInt16[SS, (ushort)(BP - 0x28)]++;
    CheckExternalEvents(cs1, 0x840D);
    // INC word ptr [BP + -0x2c] (0000_840A / 0x840A)
    UInt16[SS, (ushort)(BP - 0x2C)]++;
    CheckExternalEvents(cs1, 0x8411);
    // CMP word ptr [BP + -0x2c],0x10 (0000_840D / 0x840D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2C)], 0x10);
    CheckExternalEvents(cs1, 0x8413);
    // JLE 0x0000:8421 (0000_8411 / 0x8411)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8421_08421;
    }
    CheckExternalEvents(cs1, 0x8418);
    // MOV word ptr [BP + -0x2c],0x0 (0000_8413 / 0x8413)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    CheckExternalEvents(cs1, 0x841B);
    // MOV AX,word ptr [BP + -0x30] (0000_8418 / 0x8418)
    AX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs1, 0x841E);
    // MOV word ptr [BP + -0x28],AX (0000_841B / 0x841B)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x8421);
    // INC word ptr [BP + -0x2e] (0000_841E / 0x841E)
    UInt16[SS, (ushort)(BP - 0x2E)]++;
    label_0000_8421_08421:
    CheckExternalEvents(cs1, 0x8425);
    // CMP word ptr [BP + -0xe],0x0 (0000_8421 / 0x8421)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs1, 0x8427);
    // JZ 0x0000:842a (0000_8425 / 0x8425)
    if(ZeroFlag) {
      goto label_0000_842A_0842A;
    }
    CheckExternalEvents(cs1, 0x842A);
    // JMP 0x0000:85a8 (0000_8427 / 0x8427)
    goto label_0000_85A8_085A8;
    label_0000_842A_0842A:
    CheckExternalEvents(cs1, 0x842D);
    // MOV AX,word ptr [BP + -0x28] (0000_842A / 0x842A)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x8430);
    // SUB AX,0xd (0000_842D / 0x842D)
    AX -= 0xD;
    CheckExternalEvents(cs1, 0x8432);
    // SAR AX,0x1 (0000_8430 / 0x8430)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x8436);
    // MOV ES,word ptr [0x543e] (0000_8432 / 0x8432)
    ES = UInt16[DS, 0x543E];
    CheckExternalEvents(cs1, 0x843B);
    // ADD AX,word ptr ES:[0x9ef] (0000_8436 / 0x8436)
    // AX += UInt16[ES, 0x9EF];
    AX = Alu.Add16(AX, UInt16[ES, 0x9EF]);
    CheckExternalEvents(cs1, 0x843E);
    // MOV word ptr [BP + -0x2],AX (0000_843B / 0x843B)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x8442);
    // TEST byte ptr [BP + -0x28],0x1 (0000_843E / 0x843E)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x28)], 0x1);
    CheckExternalEvents(cs1, 0x8444);
    // JNZ 0x0000:8453 (0000_8442 / 0x8442)
    if(!ZeroFlag) {
      goto label_0000_8453_08453;
    }
    CheckExternalEvents(cs1, 0x8448);
    // MOV ES,word ptr [0x542c] (0000_8444 / 0x8444)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x844E);
    // TEST byte ptr ES:[0xa44b],0x1 (0000_8448 / 0x8448)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs1, 0x8450);
    // JZ 0x0000:8453 (0000_844E / 0x844E)
    if(ZeroFlag) {
      goto label_0000_8453_08453;
    }
    CheckExternalEvents(cs1, 0x8453);
    // INC word ptr [BP + -0x2] (0000_8450 / 0x8450)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2)]);
    label_0000_8453_08453:
    CheckExternalEvents(cs1, 0x8456);
    // MOV AX,word ptr [BP + -0x2e] (0000_8453 / 0x8453)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x8458);
    // SAR AX,0x1 (0000_8456 / 0x8456)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x845B);
    // MOV CX,0x18 (0000_8458 / 0x8458)
    CX = 0x18;
    CheckExternalEvents(cs1, 0x845D);
    // IMUL CX (0000_845B / 0x845B)
    int resImul0000_845B = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_845B);
    DX = (ushort)(resImul0000_845B >> 16);
    CheckExternalEvents(cs1, 0x8461);
    // MOV ES,word ptr [0x5440] (0000_845D / 0x845D)
    ES = UInt16[DS, 0x5440];
    CheckExternalEvents(cs1, 0x8466);
    // ADD AX,word ptr ES:[0x9f1] (0000_8461 / 0x8461)
    // AX += UInt16[ES, 0x9F1];
    AX = Alu.Add16(AX, UInt16[ES, 0x9F1]);
    CheckExternalEvents(cs1, 0x8469);
    // MOV word ptr [BP + -0x4],AX (0000_8466 / 0x8466)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x846D);
    // TEST byte ptr [BP + -0x2e],0x1 (0000_8469 / 0x8469)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x2E)], 0x1);
    CheckExternalEvents(cs1, 0x846F);
    // JZ 0x0000:847f (0000_846D / 0x846D)
    if(ZeroFlag) {
      goto label_0000_847F_0847F;
    }
    CheckExternalEvents(cs1, 0x8473);
    // MOV ES,word ptr [0x542a] (0000_846F / 0x846F)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x8479);
    // TEST byte ptr ES:[0xa44d],0x1 (0000_8473 / 0x8473)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs1, 0x847B);
    // JZ 0x0000:847f (0000_8479 / 0x8479)
    if(ZeroFlag) {
      goto label_0000_847F_0847F;
    }
    CheckExternalEvents(cs1, 0x847F);
    // ADD word ptr [BP + -0x4],0x18 (0000_847B / 0x847B)
    UInt16[SS, (ushort)(BP - 0x4)] += 0x18;
    label_0000_847F_0847F:
    CheckExternalEvents(cs1, 0x8483);
    // CMP word ptr [BP + -0x2],0x0 (0000_847F / 0x847F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0x8485);
    // JGE 0x0000:8488 (0000_8483 / 0x8483)
    if(SignFlag == OverflowFlag) {
      goto label_0000_8488_08488;
    }
    CheckExternalEvents(cs1, 0x8488);
    // JMP 0x0000:852f (0000_8485 / 0x8485)
    goto label_0000_852F_0852F;
    label_0000_8488_08488:
    CheckExternalEvents(cs1, 0x848C);
    // CMP word ptr [BP + -0x2],0x18 (0000_8488 / 0x8488)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x18);
    CheckExternalEvents(cs1, 0x848E);
    // JL 0x0000:8491 (0000_848C / 0x848C)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8491_08491;
    }
    CheckExternalEvents(cs1, 0x8491);
    // JMP 0x0000:852f (0000_848E / 0x848E)
    goto label_0000_852F_0852F;
    label_0000_8491_08491:
    CheckExternalEvents(cs1, 0x8495);
    // CMP word ptr [BP + -0x4],0x0 (0000_8491 / 0x8491)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs1, 0x8497);
    // JGE 0x0000:849a (0000_8495 / 0x8495)
    if(SignFlag == OverflowFlag) {
      goto label_0000_849A_0849A;
    }
    CheckExternalEvents(cs1, 0x849A);
    // JMP 0x0000:852f (0000_8497 / 0x8497)
    goto label_0000_852F_0852F;
    label_0000_849A_0849A:
    CheckExternalEvents(cs1, 0x849F);
    // CMP word ptr [BP + -0x4],0x240 (0000_849A / 0x849A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x240);
    CheckExternalEvents(cs1, 0x84A1);
    // JL 0x0000:84a4 (0000_849F / 0x849F)
    if(SignFlag != OverflowFlag) {
      goto label_0000_84A4_084A4;
    }
    CheckExternalEvents(cs1, 0x84A4);
    // JMP 0x0000:852f (0000_84A1 / 0x84A1)
    goto label_0000_852F_0852F;
    label_0000_84A4_084A4:
    CheckExternalEvents(cs1, 0x84A7);
    // MOV AX,word ptr [BP + -0x28] (0000_84A4 / 0x84A4)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x84AB);
    // MOV ES,word ptr [0x542c] (0000_84A7 / 0x84A7)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x84B0);
    // ADD AX,word ptr ES:[0xa44b] (0000_84AB / 0x84AB)
    AX += UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x84B3);
    // SUB AX,0x1a (0000_84B0 / 0x84B0)
    // AX -= 0x1A;
    AX = Alu.Sub16(AX, 0x1A);
    CheckExternalEvents(cs1, 0x84B6);
    // MOV word ptr [BP + -0x10],AX (0000_84B3 / 0x84B3)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x84BA);
    // TEST byte ptr [BP + -0x10],0x80 (0000_84B6 / 0x84B6)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x10)], 0x80);
    CheckExternalEvents(cs1, 0x84BC);
    // JZ 0x0000:84ce (0000_84BA / 0x84BA)
    if(ZeroFlag) {
      goto label_0000_84CE_084CE;
    }
    CheckExternalEvents(cs1, 0x84C0);
    // CMP word ptr [BP + -0x28],0x1a (0000_84BC / 0x84BC)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x28)], 0x1A);
    CheckExternalEvents(cs1, 0x84C2);
    // JGE 0x0000:84c9 (0000_84C0 / 0x84C0)
    if(SignFlag == OverflowFlag) {
      goto label_0000_84C9_084C9;
    }
    CheckExternalEvents(cs1, 0x84C7);
    // AND word ptr [BP + -0x10],0xf7f (0000_84C2 / 0x84C2)
    // UInt16[SS, (ushort)(BP - 0x10)] &= 0xF7F;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x10)], 0xF7F);
    CheckExternalEvents(cs1, 0x84C9);
    // JMP 0x0000:84ce (0000_84C7 / 0x84C7)
    goto label_0000_84CE_084CE;
    label_0000_84C9_084C9:
    CheckExternalEvents(cs1, 0x84CE);
    // ADD word ptr [BP + -0x10],0x80 (0000_84C9 / 0x84C9)
    // UInt16[SS, (ushort)(BP - 0x10)] += 0x80;
    UInt16[SS, (ushort)(BP - 0x10)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x10)], 0x80);
    label_0000_84CE_084CE:
    CheckExternalEvents(cs1, 0x84D1);
    // MOV AX,word ptr [BP + -0x2e] (0000_84CE / 0x84CE)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x84D5);
    // MOV ES,word ptr [0x542a] (0000_84D1 / 0x84D1)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x84DA);
    // ADD AX,word ptr ES:[0xa44d] (0000_84D5 / 0x84D5)
    AX += UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x84DD);
    // SUB AX,0xc (0000_84DA / 0x84DA)
    // AX -= 0xC;
    AX = Alu.Sub16(AX, 0xC);
    CheckExternalEvents(cs1, 0x84E0);
    // MOV word ptr [BP + -0x12],AX (0000_84DD / 0x84DD)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0x84E4);
    // TEST byte ptr [BP + -0x12],0x80 (0000_84E0 / 0x84E0)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x12)], 0x80);
    CheckExternalEvents(cs1, 0x84E6);
    // JZ 0x0000:84f8 (0000_84E4 / 0x84E4)
    if(ZeroFlag) {
      goto label_0000_84F8_084F8;
    }
    CheckExternalEvents(cs1, 0x84EA);
    // CMP word ptr [BP + -0x2e],0xc (0000_84E6 / 0x84E6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2E)], 0xC);
    CheckExternalEvents(cs1, 0x84EC);
    // JGE 0x0000:84f3 (0000_84EA / 0x84EA)
    if(SignFlag == OverflowFlag) {
      goto label_0000_84F3_084F3;
    }
    CheckExternalEvents(cs1, 0x84F1);
    // AND word ptr [BP + -0x12],0xf07f (0000_84EC / 0x84EC)
    // UInt16[SS, (ushort)(BP - 0x12)] &= 0xF07F;
    UInt16[SS, (ushort)(BP - 0x12)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x12)], 0xF07F);
    CheckExternalEvents(cs1, 0x84F3);
    // JMP 0x0000:84f8 (0000_84F1 / 0x84F1)
    goto label_0000_84F8_084F8;
    label_0000_84F3_084F3:
    CheckExternalEvents(cs1, 0x84F8);
    // ADD word ptr [BP + -0x12],0xf80 (0000_84F3 / 0x84F3)
    // UInt16[SS, (ushort)(BP - 0x12)] += 0xF80;
    UInt16[SS, (ushort)(BP - 0x12)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x12)], 0xF80);
    label_0000_84F8_084F8:
    CheckExternalEvents(cs1, 0x84FB);
    // MOV SI,word ptr [BP + -0x20] (0000_84F8 / 0x84F8)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x84FD);
    // SHL SI,0x1 (0000_84FB / 0x84FB)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x8500);
    // MOV AX,word ptr [BP + -0x10] (0000_84FD / 0x84FD)
    AX = UInt16[SS, (ushort)(BP - 0x10)];
    CheckExternalEvents(cs1, 0x8504);
    // MOV ES,word ptr [0x5432] (0000_8500 / 0x8500)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x8509);
    // MOV word ptr ES:[SI + 0x4014],AX (0000_8504 / 0x8504)
    UInt16[ES, (ushort)(SI + 0x4014)] = AX;
    CheckExternalEvents(cs1, 0x850C);
    // MOV AX,word ptr [BP + -0x12] (0000_8509 / 0x8509)
    AX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0x8510);
    // MOV ES,word ptr [0x5430] (0000_850C / 0x850C)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x8515);
    // MOV word ptr ES:[SI + 0x4046],AX (0000_8510 / 0x8510)
    UInt16[ES, (ushort)(SI + 0x4046)] = AX;
    CheckExternalEvents(cs1, 0x8518);
    // MOV BX,word ptr [BP + -0x20] (0000_8515 / 0x8515)
    BX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x851C);
    // MOV ES,word ptr [0x5442] (0000_8518 / 0x8518)
    ES = UInt16[DS, 0x5442];
    CheckExternalEvents(cs1, 0x8522);
    // MOV byte ptr ES:[BX + 0x40a2],0x0 (0000_851C / 0x851C)
    UInt8[ES, (ushort)(BX + 0x40A2)] = 0x0;
    CheckExternalEvents(cs1, 0x8526);
    // MOV ES,word ptr [0x542e] (0000_8522 / 0x8522)
    ES = UInt16[DS, 0x542E];
    CheckExternalEvents(cs1, 0x852D);
    // MOV word ptr ES:[SI + 0x407a],0x1 (0000_8526 / 0x8526)
    UInt16[ES, (ushort)(SI + 0x407A)] = 0x1;
    CheckExternalEvents(cs1, 0x852F);
    // JMP 0x0000:8567 (0000_852D / 0x852D)
    goto label_0000_8567_08567;
    label_0000_852F_0852F:
    CheckExternalEvents(cs1, 0x8532);
    // MOV SI,word ptr [BP + -0x20] (0000_852F / 0x852F)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x8534);
    // SHL SI,0x1 (0000_8532 / 0x8532)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x8537);
    // MOV AX,0xffff (0000_8534 / 0x8534)
    AX = 0xFFFF;
    CheckExternalEvents(cs1, 0x853B);
    // MOV ES,word ptr [0x5430] (0000_8537 / 0x8537)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x8540);
    // MOV word ptr ES:[SI + 0x4046],AX (0000_853B / 0x853B)
    UInt16[ES, (ushort)(SI + 0x4046)] = AX;
    CheckExternalEvents(cs1, 0x8544);
    // MOV ES,word ptr [0x5432] (0000_8540 / 0x8540)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x8549);
    // MOV word ptr ES:[SI + 0x4014],AX (0000_8544 / 0x8544)
    UInt16[ES, (ushort)(SI + 0x4014)] = AX;
    CheckExternalEvents(cs1, 0x854B);
    // MOV CX,AX (0000_8549 / 0x8549)
    CX = AX;
    CheckExternalEvents(cs1, 0x854E);
    // MOV AX,0x7d (0000_854B / 0x854B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8551);
    // IMUL word ptr [BP + -0x20] (0000_854E / 0x854E)
    int resImul0000_854E = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_854E);
    DX = (ushort)(resImul0000_854E >> 16);
    CheckExternalEvents(cs1, 0x8553);
    // MOV BX,AX (0000_8551 / 0x8551)
    BX = AX;
    CheckExternalEvents(cs1, 0x8557);
    // MOV ES,word ptr [0x5412] (0000_8553 / 0x8553)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x855C);
    // MOV byte ptr ES:[BX + 0xc724],CL (0000_8557 / 0x8557)
    UInt8[ES, (ushort)(BX + 0xC724)] = CL;
    CheckExternalEvents(cs1, 0x8560);
    // MOV ES,word ptr [0x542e] (0000_855C / 0x855C)
    ES = UInt16[DS, 0x542E];
    CheckExternalEvents(cs1, 0x8567);
    // MOV word ptr ES:[SI + 0x407a],0x0 (0000_8560 / 0x8560)
    UInt16[ES, (ushort)(SI + 0x407A)] = 0x0;
    label_0000_8567_08567:
    CheckExternalEvents(cs1, 0x856B);
    // ADD word ptr [BP + -0x28],0x3 (0000_8567 / 0x8567)
    UInt16[SS, (ushort)(BP - 0x28)] += 0x3;
    CheckExternalEvents(cs1, 0x856F);
    // ADD word ptr [BP + -0x2c],0x3 (0000_856B / 0x856B)
    UInt16[SS, (ushort)(BP - 0x2C)] += 0x3;
    CheckExternalEvents(cs1, 0x8573);
    // CMP word ptr [BP + -0x2c],0x8 (0000_856F / 0x856F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2C)], 0x8);
    CheckExternalEvents(cs1, 0x8575);
    // JLE 0x0000:8583 (0000_8573 / 0x8573)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8583_08583;
    }
    CheckExternalEvents(cs1, 0x857A);
    // MOV word ptr [BP + -0x2c],0x0 (0000_8575 / 0x8575)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x0;
    CheckExternalEvents(cs1, 0x857D);
    // MOV AX,word ptr [BP + -0x30] (0000_857A / 0x857A)
    AX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs1, 0x8580);
    // MOV word ptr [BP + -0x28],AX (0000_857D / 0x857D)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x8583);
    // INC word ptr [BP + -0x2e] (0000_8580 / 0x8580)
    UInt16[SS, (ushort)(BP - 0x2E)]++;
    label_0000_8583_08583:
    CheckExternalEvents(cs1, 0x8586);
    // INC word ptr [BP + -0x20] (0000_8583 / 0x8583)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    label_0000_8586_08586:
    CheckExternalEvents(cs1, 0x858A);
    // CMP word ptr [BP + -0x20],0x8 (0000_8586 / 0x8586)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x20)], 0x8);
    CheckExternalEvents(cs1, 0x858C);
    // JL 0x0000:858f (0000_858A / 0x858A)
    if(SignFlag != OverflowFlag) {
      goto label_0000_858F_0858F;
    }
    CheckExternalEvents(cs1, 0x858F);
    // JMP 0x0000:8612 (0000_858C / 0x858C)
    goto label_0000_8612_08612;
    label_0000_858F_0858F:
    CheckExternalEvents(cs1, 0x8592);
    // MOV AX,0x7d (0000_858F / 0x858F)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8595);
    // IMUL word ptr [BP + -0x20] (0000_8592 / 0x8592)
    int resImul0000_8592 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_8592);
    DX = (ushort)(resImul0000_8592 >> 16);
    CheckExternalEvents(cs1, 0x8597);
    // MOV BX,AX (0000_8595 / 0x8595)
    BX = AX;
    CheckExternalEvents(cs1, 0x859B);
    // MOV ES,word ptr [0x5412] (0000_8597 / 0x8597)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x85A1);
    // CMP byte ptr ES:[BX + 0xc724],0xff (0000_859B / 0x859B)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC724)], 0xFF);
    CheckExternalEvents(cs1, 0x85A3);
    // JZ 0x0000:8583 (0000_85A1 / 0x85A1)
    if(ZeroFlag) {
      goto label_0000_8583_08583;
    }
    CheckExternalEvents(cs1, 0x85A8);
    // MOV word ptr [BP + -0xe],0x1 (0000_85A3 / 0x85A3)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    label_0000_85A8_085A8:
    CheckExternalEvents(cs1, 0x85AB);
    // MOV AX,word ptr [BP + -0x2e] (0000_85A8 / 0x85A8)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x85AD);
    // SAR AX,0x1 (0000_85AB / 0x85AB)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x85B0);
    // MOV CX,0x18 (0000_85AD / 0x85AD)
    CX = 0x18;
    CheckExternalEvents(cs1, 0x85B2);
    // IMUL CX (0000_85B0 / 0x85B0)
    int resImul0000_85B0 = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_85B0);
    DX = (ushort)(resImul0000_85B0 >> 16);
    CheckExternalEvents(cs1, 0x85B5);
    // MOV CX,word ptr [BP + -0x28] (0000_85B2 / 0x85B2)
    CX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x85B8);
    // SUB CX,0xd (0000_85B5 / 0x85B5)
    CX -= 0xD;
    CheckExternalEvents(cs1, 0x85BA);
    // SAR CX,0x1 (0000_85B8 / 0x85B8)
    CX = Alu.Sar16(CX, 0x1);
    CheckExternalEvents(cs1, 0x85BC);
    // ADD AX,CX (0000_85BA / 0x85BA)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs1, 0x85C0);
    // MOV ES,word ptr [0x5438] (0000_85BC / 0x85BC)
    ES = UInt16[DS, 0x5438];
    CheckExternalEvents(cs1, 0x85C5);
    // ADD AX,word ptr ES:[0x9ed] (0000_85C0 / 0x85C0)
    // AX += UInt16[ES, 0x9ED];
    AX = Alu.Add16(AX, UInt16[ES, 0x9ED]);
    CheckExternalEvents(cs1, 0x85C8);
    // MOV word ptr [BP + -0x18],AX (0000_85C5 / 0x85C5)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs1, 0x85CC);
    // TEST byte ptr [BP + -0x28],0x1 (0000_85C8 / 0x85C8)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x28)], 0x1);
    CheckExternalEvents(cs1, 0x85CE);
    // JNZ 0x0000:85dd (0000_85CC / 0x85CC)
    if(!ZeroFlag) {
      goto label_0000_85DD_085DD;
    }
    CheckExternalEvents(cs1, 0x85D2);
    // MOV ES,word ptr [0x542c] (0000_85CE / 0x85CE)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x85D8);
    // TEST byte ptr ES:[0xa44b],0x1 (0000_85D2 / 0x85D2)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs1, 0x85DA);
    // JZ 0x0000:85dd (0000_85D8 / 0x85D8)
    if(ZeroFlag) {
      goto label_0000_85DD_085DD;
    }
    CheckExternalEvents(cs1, 0x85DD);
    // INC word ptr [BP + -0x18] (0000_85DA / 0x85DA)
    UInt16[SS, (ushort)(BP - 0x18)]++;
    label_0000_85DD_085DD:
    CheckExternalEvents(cs1, 0x85E1);
    // TEST byte ptr [BP + -0x2e],0x1 (0000_85DD / 0x85DD)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x2E)], 0x1);
    CheckExternalEvents(cs1, 0x85E3);
    // JZ 0x0000:85f3 (0000_85E1 / 0x85E1)
    if(ZeroFlag) {
      goto label_0000_85F3_085F3;
    }
    CheckExternalEvents(cs1, 0x85E7);
    // MOV ES,word ptr [0x542a] (0000_85E3 / 0x85E3)
    ES = UInt16[DS, 0x542A];
    CheckExternalEvents(cs1, 0x85ED);
    // TEST byte ptr ES:[0xa44d],0x1 (0000_85E7 / 0x85E7)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs1, 0x85EF);
    // JZ 0x0000:85f3 (0000_85ED / 0x85ED)
    if(ZeroFlag) {
      goto label_0000_85F3_085F3;
    }
    CheckExternalEvents(cs1, 0x85F3);
    // ADD word ptr [BP + -0x18],0x18 (0000_85EF / 0x85EF)
    // UInt16[SS, (ushort)(BP - 0x18)] += 0x18;
    UInt16[SS, (ushort)(BP - 0x18)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x18)], 0x18);
    label_0000_85F3_085F3:
    CheckExternalEvents(cs1, 0x85F6);
    // MOV AX,word ptr [BP + -0x18] (0000_85F3 / 0x85F3)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0x85F9);
    // MOV word ptr [BP + -0x26],AX (0000_85F6 / 0x85F6)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs1, 0x85FC);
    // MOV AL,byte ptr [BP + -0x28] (0000_85F9 / 0x85F9)
    AL = UInt8[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x8600);
    // MOV ES,word ptr [0x542c] (0000_85FC / 0x85FC)
    ES = UInt16[DS, 0x542C];
    CheckExternalEvents(cs1, 0x8605);
    // XOR AL,byte ptr ES:[0xa44b] (0000_8600 / 0x8600)
    AL ^= UInt8[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x8607);
    // TEST AL,0x1 (0000_8605 / 0x8605)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs1, 0x8609);
    // JNZ 0x0000:860c (0000_8607 / 0x8607)
    if(!ZeroFlag) {
      goto label_0000_860C_0860C;
    }
    CheckExternalEvents(cs1, 0x860C);
    // JMP 0x0000:83b3 (0000_8609 / 0x8609)
    goto label_0000_83B3_083B3;
    label_0000_860C_0860C:
    CheckExternalEvents(cs1, 0x860F);
    // DEC word ptr [BP + -0x26] (0000_860C / 0x860C)
    UInt16[SS, (ushort)(BP - 0x26)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0x26)]);
    CheckExternalEvents(cs1, 0x8612);
    // JMP 0x0000:83b6 (0000_860F / 0x860F)
    goto label_0000_83B6_083B6;
    label_0000_8612_08612:
    CheckExternalEvents(cs1, 0x8613);
    // POP SI (0000_8612 / 0x8612)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8615);
    // MOV SP,BP (0000_8613 / 0x8613)
    SP = BP;
    CheckExternalEvents(cs1, 0x8616);
    // POP BP (0000_8615 / 0x8615)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8617);
    // RETF  (0000_8616 / 0x8616)
    return FarRet();
  }
  
}
