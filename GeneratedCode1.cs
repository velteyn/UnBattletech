namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_0000_254B_0254B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_254B_0254B:
    CheckExternalEvents(cs1, 0x254C);
    // PUSH BP (0000_254B / 0x254B)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x254E);
    // MOV BP,SP (0000_254C / 0x254C)
    BP = SP;
    CheckExternalEvents(cs1, 0x2551);
    // MOV AX,0x5e (0000_254E / 0x254E)
    AX = 0x5E;
    CheckExternalEvents(cs1, 0x2556);
    // CALLF 0x1000:cecc (0000_2551 / 0x2551)
    FarCall(cs1, 0x2556, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x2557);
    // PUSH DI (0000_2556 / 0x2556)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0x2558);
    // PUSH SI (0000_2557 / 0x2557)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x255C);
    // MOV ES,word ptr [0x538c] (0000_2558 / 0x2558)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2560);
    // MOV AX,ES:[0xa44b] (0000_255C / 0x255C)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x2564);
    // MOV ES,word ptr [0x538e] (0000_2560 / 0x2560)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2569);
    // OR AX,word ptr ES:[0xa44d] (0000_2564 / 0x2564)
    // AX |= UInt16[ES, 0xA44D];
    AX = Alu.Or16(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x256B);
    // MOV CL,0x8 (0000_2569 / 0x2569)
    CL = 0x8;
    CheckExternalEvents(cs1, 0x256D);
    // SHR AX,CL (0000_256B / 0x256B)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    CheckExternalEvents(cs1, 0x2570);
    // MOV word ptr [BP + -0x3e],AX (0000_256D / 0x256D)
    UInt16[SS, (ushort)(BP - 0x3E)] = AX;
    CheckExternalEvents(cs1, 0x2571);
    // PUSH CS (0000_2570 / 0x2570)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x2574);
    // CALL 0x0000:4193 (0000_2571 / 0x2571)
    NearCall(cs1, 0x2574, unknown_0170_2A93_04193);
    CheckExternalEvents(cs1, 0x2578);
    // MOV ES,word ptr [0x538c] (0000_2574 / 0x2574)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x257C);
    // MOV AX,ES:[0xa44b] (0000_2578 / 0x2578)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x257F);
    // MOV word ptr [BP + -0xc],AX (0000_257C / 0x257C)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x2583);
    // MOV ES,word ptr [0x538e] (0000_257F / 0x257F)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2587);
    // MOV AX,ES:[0xa44d] (0000_2583 / 0x2583)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x258A);
    // MOV word ptr [BP + -0x16],AX (0000_2587 / 0x2587)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x258F);
    // MOV word ptr [BP + -0x4c],0x0 (0000_258A / 0x258A)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x0;
    label_0000_258F_0258F:
    CheckExternalEvents(cs1, 0x2592);
    // MOV BX,word ptr [BP + -0x4c] (0000_258F / 0x258F)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2596);
    // MOV ES,word ptr [0x53b2] (0000_2592 / 0x2592)
    ES = UInt16[DS, 0x53B2];
    CheckExternalEvents(cs1, 0x259C);
    // MOV byte ptr ES:[BX + 0x42f6],0x0 (0000_2596 / 0x2596)
    UInt8[ES, (ushort)(BX + 0x42F6)] = 0x0;
    CheckExternalEvents(cs1, 0x259F);
    // INC word ptr [BP + -0x4c] (0000_259C / 0x259C)
    UInt16[SS, (ushort)(BP - 0x4C)]++;
    CheckExternalEvents(cs1, 0x25A3);
    // CMP word ptr [BP + -0x4c],0x18 (0000_259F / 0x259F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4C)], 0x18);
    CheckExternalEvents(cs1, 0x25A5);
    // JL 0x0000:258f (0000_25A3 / 0x25A3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_258F_0258F;
    }
    CheckExternalEvents(cs1, 0x25AA);
    // MOV word ptr [BP + -0x5c],0x0 (0000_25A5 / 0x25A5)
    UInt16[SS, (ushort)(BP - 0x5C)] = 0x0;
    CheckExternalEvents(cs1, 0x25AD);
    // JMP 0x0000:2891 (0000_25AA / 0x25AA)
    goto label_0000_2891_02891;
    label_0000_25AD_025AD:
    CheckExternalEvents(cs1, 0x25B0);
    // PUSH word ptr [BP + -0x4a] (0000_25AD / 0x25AD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4A)]);
    CheckExternalEvents(cs1, 0x25B3);
    // PUSH word ptr [BP + -0x46] (0000_25B0 / 0x25B0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x46)]);
    CheckExternalEvents(cs1, 0x25B6);
    // PUSH word ptr [BP + -0x2] (0000_25B3 / 0x25B3)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x25B9);
    // PUSH word ptr [BP + -0x4] (0000_25B6 / 0x25B6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x25BB);
    // SUB AX,AX (0000_25B9 / 0x25B9)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x25BE);
    // MOV DX,0xac00 (0000_25BB / 0x25BB)
    DX = 0xAC00;
    CheckExternalEvents(cs1, 0x25BF);
    // PUSH DX (0000_25BE / 0x25BE)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x25C0);
    // PUSH AX (0000_25BF / 0x25BF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x25C5);
    // CALLF 0x1000:a267 (0000_25C0 / 0x25C0)
    FarCall(cs1, 0x25C5, ghidra_guess_1000_A267_1A267);
    CheckExternalEvents(cs1, 0x25C8);
    // ADD SP,0xc (0000_25C5 / 0x25C5)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    label_0000_25C8_025C8:
    CheckExternalEvents(cs1, 0x25CC);
    // MOV ES,word ptr [0x53a0] (0000_25C8 / 0x25C8)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x25D2);
    // CMP word ptr ES:[0x4fba],0x0 (0000_25CC / 0x25CC)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x25D4);
    // JZ 0x0000:25de (0000_25D2 / 0x25D2)
    if(ZeroFlag) {
      goto label_0000_25DE_025DE;
    }
    CheckExternalEvents(cs1, 0x25D7);
    // LES BX,[BP + -0x4] (0000_25D4 / 0x25D4)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs1, 0x25DA);
    // MOV AL,byte ptr [BP + -0x44] (0000_25D7 / 0x25D7)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x25DE);
    // ADD byte ptr ES:[BX + 0x1],AL (0000_25DA / 0x25DA)
    UInt8[ES, (ushort)(BX + 0x1)] += AL;
    label_0000_25DE_025DE:
    CheckExternalEvents(cs1, 0x25E1);
    // INC word ptr [BP + -0x4c] (0000_25DE / 0x25DE)
    UInt16[SS, (ushort)(BP - 0x4C)]++;
    label_0000_25E1_025E1:
    CheckExternalEvents(cs1, 0x25E5);
    // CMP word ptr [BP + -0x4c],0x8 (0000_25E1 / 0x25E1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4C)], 0x8);
    CheckExternalEvents(cs1, 0x25E7);
    // JL 0x0000:25ea (0000_25E5 / 0x25E5)
    if(SignFlag != OverflowFlag) {
      goto label_0000_25EA_025EA;
    }
    CheckExternalEvents(cs1, 0x25EA);
    // JMP 0x0000:288d (0000_25E7 / 0x25E7)
    goto label_0000_288D_0288D;
    label_0000_25EA_025EA:
    CheckExternalEvents(cs1, 0x25ED);
    // MOV SI,word ptr [BP + -0x4c] (0000_25EA / 0x25EA)
    SI = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x25F0);
    // ADD SI,word ptr [BP + -0x5c] (0000_25ED / 0x25ED)
    // SI += UInt16[SS, (ushort)(BP - 0x5C)];
    SI = Alu.Add16(SI, UInt16[SS, (ushort)(BP - 0x5C)]);
    CheckExternalEvents(cs1, 0x25F2);
    // MOV BX,SI (0000_25F0 / 0x25F0)
    BX = SI;
    CheckExternalEvents(cs1, 0x25F4);
    // SHL BX,0x1 (0000_25F2 / 0x25F2)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x25F8);
    // MOV ES,word ptr [0x53a4] (0000_25F4 / 0x25F4)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs1, 0x25FE);
    // CMP word ptr ES:[BX + 0x400c],-0x1 (0000_25F8 / 0x25F8)
    Alu.Sub16(UInt16[ES, (ushort)(BX + 0x400C)], 0xFFFF);
    CheckExternalEvents(cs1, 0x2600);
    // JZ 0x0000:25de (0000_25FE / 0x25FE)
    if(ZeroFlag) {
      goto label_0000_25DE_025DE;
    }
    CheckExternalEvents(cs1, 0x2603);
    // LEA AX,[SI + 0x4] (0000_2600 / 0x2600)
    AX = (ushort)(SI + 0x4);
    CheckExternalEvents(cs1, 0x2606);
    // MOV word ptr [BP + -0x3c],AX (0000_2603 / 0x2603)
    UInt16[SS, (ushort)(BP - 0x3C)] = AX;
    CheckExternalEvents(cs1, 0x2608);
    // MOV SI,AX (0000_2606 / 0x2606)
    SI = AX;
    CheckExternalEvents(cs1, 0x260A);
    // SHL SI,0x1 (0000_2608 / 0x2608)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x260F);
    // MOV AX,word ptr ES:[SI + 0x4004] (0000_260A / 0x260A)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs1, 0x2612);
    // MOV word ptr [BP + -0x46],AX (0000_260F / 0x260F)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2616);
    // MOV ES,word ptr [0x53a6] (0000_2612 / 0x2612)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs1, 0x261B);
    // MOV AX,word ptr ES:[SI + 0x4036] (0000_2616 / 0x2616)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs1, 0x261E);
    // MOV word ptr [BP + -0x4a],AX (0000_261B / 0x261B)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs1, 0x2620);
    // SUB AX,AX (0000_261E / 0x261E)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x2623);
    // MOV word ptr [BP + -0x50],AX (0000_2620 / 0x2620)
    UInt16[SS, (ushort)(BP - 0x50)] = AX;
    CheckExternalEvents(cs1, 0x2626);
    // MOV word ptr [BP + -0x4e],AX (0000_2623 / 0x2623)
    UInt16[SS, (ushort)(BP - 0x4E)] = AX;
    CheckExternalEvents(cs1, 0x2629);
    // MOV AX,word ptr [BP + -0x46] (0000_2626 / 0x2626)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x262C);
    // SUB AX,word ptr [BP + -0xc] (0000_2629 / 0x2629)
    AX -= UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x262F);
    // ADD AX,0x1a (0000_262C / 0x262C)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs1, 0x2632);
    // MOV word ptr [BP + -0x46],AX (0000_262F / 0x262F)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2635);
    // MOV AX,word ptr [BP + -0x4a] (0000_2632 / 0x2632)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2638);
    // SUB AX,word ptr [BP + -0x16] (0000_2635 / 0x2635)
    AX -= UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0x263B);
    // ADD AX,0xc (0000_2638 / 0x2638)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs1, 0x263E);
    // MOV word ptr [BP + -0x4a],AX (0000_263B / 0x263B)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs1, 0x2642);
    // MOV ES,word ptr [0x53a4] (0000_263E / 0x263E)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs1, 0x2647);
    // MOV AX,word ptr ES:[SI + 0x4004] (0000_2642 / 0x2642)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs1, 0x2649);
    // SUB AL,AL (0000_2647 / 0x2647)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs1, 0x264C);
    // MOV CX,word ptr [BP + -0xc] (0000_2649 / 0x2649)
    CX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x264E);
    // SUB CL,CL (0000_264C / 0x264C)
    CL -= CL;
    CheckExternalEvents(cs1, 0x2650);
    // CMP AX,CX (0000_264E / 0x264E)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0x2652);
    // JNZ 0x0000:2663 (0000_2650 / 0x2650)
    if(!ZeroFlag) {
      goto label_0000_2663_02663;
    }
    CheckExternalEvents(cs1, 0x2656);
    // CMP word ptr [BP + -0x46],0xd (0000_2652 / 0x2652)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xD);
    CheckExternalEvents(cs1, 0x2658);
    // JL 0x0000:265e (0000_2656 / 0x2656)
    if(SignFlag != OverflowFlag) {
      goto label_0000_265E_0265E;
    }
    CheckExternalEvents(cs1, 0x265C);
    // CMP word ptr [BP + -0x46],0x27 (0000_2658 / 0x2658)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0x27);
    CheckExternalEvents(cs1, 0x265E);
    // JLE 0x0000:2663 (0000_265C / 0x265C)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2663_02663;
    }
    label_0000_265E_0265E:
    CheckExternalEvents(cs1, 0x2663);
    // MOV word ptr [BP + -0x4e],0x1 (0000_265E / 0x265E)
    UInt16[SS, (ushort)(BP - 0x4E)] = 0x1;
    label_0000_2663_02663:
    CheckExternalEvents(cs1, 0x2666);
    // MOV BX,word ptr [BP + -0x3c] (0000_2663 / 0x2663)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2668);
    // SHL BX,0x1 (0000_2666 / 0x2666)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x266C);
    // MOV ES,word ptr [0x53a6] (0000_2668 / 0x2668)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs1, 0x2671);
    // MOV AX,word ptr ES:[BX + 0x4036] (0000_266C / 0x266C)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs1, 0x2673);
    // SUB AL,AL (0000_2671 / 0x2671)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs1, 0x2676);
    // MOV CX,word ptr [BP + -0x16] (0000_2673 / 0x2673)
    CX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0x2678);
    // SUB CL,CL (0000_2676 / 0x2676)
    CL -= CL;
    CheckExternalEvents(cs1, 0x267A);
    // CMP AX,CX (0000_2678 / 0x2678)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0x267C);
    // JNZ 0x0000:268d (0000_267A / 0x267A)
    if(!ZeroFlag) {
      goto label_0000_268D_0268D;
    }
    CheckExternalEvents(cs1, 0x2680);
    // CMP word ptr [BP + -0x4a],0x0 (0000_267C / 0x267C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0x0);
    CheckExternalEvents(cs1, 0x2682);
    // JL 0x0000:2688 (0000_2680 / 0x2680)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2688_02688;
    }
    CheckExternalEvents(cs1, 0x2686);
    // CMP word ptr [BP + -0x4a],0x18 (0000_2682 / 0x2682)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0x18);
    CheckExternalEvents(cs1, 0x2688);
    // JLE 0x0000:268d (0000_2686 / 0x2686)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_268D_0268D;
    }
    label_0000_2688_02688:
    CheckExternalEvents(cs1, 0x268D);
    // MOV word ptr [BP + -0x50],0x1 (0000_2688 / 0x2688)
    UInt16[SS, (ushort)(BP - 0x50)] = 0x1;
    label_0000_268D_0268D:
    CheckExternalEvents(cs1, 0x2691);
    // CMP word ptr [BP + -0x46],-0x73 (0000_268D / 0x268D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xFF8D);
    CheckExternalEvents(cs1, 0x2693);
    // JGE 0x0000:2696 (0000_2691 / 0x2691)
    if(SignFlag == OverflowFlag) {
      goto label_0000_2696_02696;
    }
    CheckExternalEvents(cs1, 0x2696);
    // JMP 0x0000:25de (0000_2693 / 0x2693)
    goto label_0000_25DE_025DE;
    label_0000_2696_02696:
    CheckExternalEvents(cs1, 0x269B);
    // CMP word ptr [BP + -0x46],0xa7 (0000_2696 / 0x2696)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xA7);
    CheckExternalEvents(cs1, 0x269D);
    // JLE 0x0000:26a0 (0000_269B / 0x269B)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_26A0_026A0;
    }
    CheckExternalEvents(cs1, 0x26A0);
    // JMP 0x0000:25de (0000_269D / 0x269D)
    goto label_0000_25DE_025DE;
    label_0000_26A0_026A0:
    CheckExternalEvents(cs1, 0x26A5);
    // CMP word ptr [BP + -0x4a],0xf080 (0000_26A0 / 0x26A0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0xF080);
    CheckExternalEvents(cs1, 0x26A7);
    // JGE 0x0000:26aa (0000_26A5 / 0x26A5)
    if(SignFlag == OverflowFlag) {
      goto label_0000_26AA_026AA;
    }
    CheckExternalEvents(cs1, 0x26AA);
    // JMP 0x0000:25de (0000_26A7 / 0x26A7)
    goto label_0000_25DE_025DE;
    label_0000_26AA_026AA:
    CheckExternalEvents(cs1, 0x26AF);
    // CMP word ptr [BP + -0x4a],0xf98 (0000_26AA / 0x26AA)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0xF98);
    CheckExternalEvents(cs1, 0x26B1);
    // JLE 0x0000:26b4 (0000_26AF / 0x26AF)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_26B4_026B4;
    }
    CheckExternalEvents(cs1, 0x26B4);
    // JMP 0x0000:25de (0000_26B1 / 0x26B1)
    goto label_0000_25DE_025DE;
    label_0000_26B4_026B4:
    CheckExternalEvents(cs1, 0x26B7);
    // MOV AX,word ptr [BP + -0x4e] (0000_26B4 / 0x26B4)
    AX = UInt16[SS, (ushort)(BP - 0x4E)];
    CheckExternalEvents(cs1, 0x26BA);
    // ADD AX,word ptr [BP + -0x50] (0000_26B7 / 0x26B7)
    // AX += UInt16[SS, (ushort)(BP - 0x50)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x50)]);
    CheckExternalEvents(cs1, 0x26BC);
    // JZ 0x0000:26bf (0000_26BA / 0x26BA)
    if(ZeroFlag) {
      goto label_0000_26BF_026BF;
    }
    CheckExternalEvents(cs1, 0x26BF);
    // JMP 0x0000:25de (0000_26BC / 0x26BC)
    goto label_0000_25DE_025DE;
    label_0000_26BF_026BF:
    CheckExternalEvents(cs1, 0x26C2);
    // MOV BX,word ptr [BP + -0x3c] (0000_26BF / 0x26BF)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x26C6);
    // MOV ES,word ptr [0x53b2] (0000_26C2 / 0x26C2)
    ES = UInt16[DS, 0x53B2];
    CheckExternalEvents(cs1, 0x26CC);
    // MOV byte ptr ES:[BX + 0x42f6],0x1 (0000_26C6 / 0x26C6)
    UInt8[ES, (ushort)(BX + 0x42F6)] = 0x1;
    CheckExternalEvents(cs1, 0x26D0);
    // AND word ptr [BP + -0x46],0x7f (0000_26CC / 0x26CC)
    UInt16[SS, (ushort)(BP - 0x46)] &= 0x7F;
    CheckExternalEvents(cs1, 0x26D4);
    // AND word ptr [BP + -0x4a],0x7f (0000_26D0 / 0x26D0)
    // UInt16[SS, (ushort)(BP - 0x4A)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x4A)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x4A)], 0x7F);
    CheckExternalEvents(cs1, 0x26D7);
    // MOV AX,word ptr [BP + -0x46] (0000_26D4 / 0x26D4)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x26DA);
    // SUB AX,0xd (0000_26D7 / 0x26D7)
    // AX -= 0xD;
    AX = Alu.Sub16(AX, 0xD);
    CheckExternalEvents(cs1, 0x26DD);
    // MOV word ptr [BP + -0x52],AX (0000_26DA / 0x26DA)
    UInt16[SS, (ushort)(BP - 0x52)] = AX;
    CheckExternalEvents(cs1, 0x26E0);
    // MOV AX,word ptr [BP + -0x4a] (0000_26DD / 0x26DD)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x26E2);
    // SAR AX,0x1 (0000_26E0 / 0x26E0)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x26E5);
    // MOV CX,0x18 (0000_26E2 / 0x26E2)
    CX = 0x18;
    CheckExternalEvents(cs1, 0x26E7);
    // IMUL CX (0000_26E5 / 0x26E5)
    int resImul0000_26E5 = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_26E5);
    DX = (ushort)(resImul0000_26E5 >> 16);
    CheckExternalEvents(cs1, 0x26EA);
    // MOV CX,word ptr [BP + -0x52] (0000_26E7 / 0x26E7)
    CX = UInt16[SS, (ushort)(BP - 0x52)];
    CheckExternalEvents(cs1, 0x26EC);
    // SAR CX,0x1 (0000_26EA / 0x26EA)
    CX = Alu.Sar16(CX, 0x1);
    CheckExternalEvents(cs1, 0x26EE);
    // ADD AX,CX (0000_26EC / 0x26EC)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs1, 0x26F2);
    // MOV ES,word ptr [0x5394] (0000_26EE / 0x26EE)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs1, 0x26F7);
    // ADD AX,word ptr ES:[0x9ed] (0000_26F2 / 0x26F2)
    // AX += UInt16[ES, 0x9ED];
    AX = Alu.Add16(AX, UInt16[ES, 0x9ED]);
    CheckExternalEvents(cs1, 0x26FA);
    // MOV word ptr [BP + -0x42],AX (0000_26F7 / 0x26F7)
    UInt16[SS, (ushort)(BP - 0x42)] = AX;
    CheckExternalEvents(cs1, 0x26FE);
    // TEST byte ptr [BP + -0x52],0x1 (0000_26FA / 0x26FA)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x52)], 0x1);
    CheckExternalEvents(cs1, 0x2700);
    // JZ 0x0000:270f (0000_26FE / 0x26FE)
    if(ZeroFlag) {
      goto label_0000_270F_0270F;
    }
    CheckExternalEvents(cs1, 0x2704);
    // MOV ES,word ptr [0x538c] (0000_2700 / 0x2700)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x270A);
    // TEST byte ptr ES:[0xa44b],0x1 (0000_2704 / 0x2704)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs1, 0x270C);
    // JZ 0x0000:270f (0000_270A / 0x270A)
    if(ZeroFlag) {
      goto label_0000_270F_0270F;
    }
    CheckExternalEvents(cs1, 0x270F);
    // INC word ptr [BP + -0x42] (0000_270C / 0x270C)
    UInt16[SS, (ushort)(BP - 0x42)]++;
    label_0000_270F_0270F:
    CheckExternalEvents(cs1, 0x2713);
    // TEST byte ptr [BP + -0x4a],0x1 (0000_270F / 0x270F)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x4A)], 0x1);
    CheckExternalEvents(cs1, 0x2715);
    // JZ 0x0000:2725 (0000_2713 / 0x2713)
    if(ZeroFlag) {
      goto label_0000_2725_02725;
    }
    CheckExternalEvents(cs1, 0x2719);
    // MOV ES,word ptr [0x538e] (0000_2715 / 0x2715)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x271F);
    // TEST byte ptr ES:[0xa44d],0x1 (0000_2719 / 0x2719)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs1, 0x2721);
    // JZ 0x0000:2725 (0000_271F / 0x271F)
    if(ZeroFlag) {
      goto label_0000_2725_02725;
    }
    CheckExternalEvents(cs1, 0x2725);
    // ADD word ptr [BP + -0x42],0x18 (0000_2721 / 0x2721)
    // UInt16[SS, (ushort)(BP - 0x42)] += 0x18;
    UInt16[SS, (ushort)(BP - 0x42)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x42)], 0x18);
    label_0000_2725_02725:
    CheckExternalEvents(cs1, 0x2728);
    // MOV BX,word ptr [BP + -0x4a] (0000_2725 / 0x2725)
    BX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x272C);
    // MOV ES,word ptr [0x538e] (0000_2728 / 0x2728)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2731);
    // XOR BX,word ptr ES:[0xa44d] (0000_272C / 0x272C)
    BX ^= UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x2734);
    // AND BX,0x1 (0000_2731 / 0x2731)
    BX &= 0x1;
    CheckExternalEvents(cs1, 0x2736);
    // SHL BX,0x1 (0000_2734 / 0x2734)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x2739);
    // MOV AX,word ptr [BP + -0x52] (0000_2736 / 0x2736)
    AX = UInt16[SS, (ushort)(BP - 0x52)];
    CheckExternalEvents(cs1, 0x273D);
    // MOV ES,word ptr [0x538c] (0000_2739 / 0x2739)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2742);
    // XOR AX,word ptr ES:[0xa44b] (0000_273D / 0x273D)
    AX ^= UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x2745);
    // AND AX,0x1 (0000_2742 / 0x2742)
    AX &= 0x1;
    CheckExternalEvents(cs1, 0x2747);
    // ADD BX,AX (0000_2745 / 0x2745)
    BX += AX;
    CheckExternalEvents(cs1, 0x2749);
    // SHL BX,0x1 (0000_2747 / 0x2747)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x274D);
    // MOV AX,word ptr [BX + 0x372] (0000_2749 / 0x2749)
    AX = UInt16[DS, (ushort)(BX + 0x372)];
    CheckExternalEvents(cs1, 0x2750);
    // MOV word ptr [BP + -0x5e],AX (0000_274D / 0x274D)
    UInt16[SS, (ushort)(BP - 0x5E)] = AX;
    CheckExternalEvents(cs1, 0x2753);
    // MOV BX,word ptr [BP + -0x42] (0000_2750 / 0x2750)
    BX = UInt16[SS, (ushort)(BP - 0x42)];
    CheckExternalEvents(cs1, 0x2757);
    // MOV ES,word ptr [0x5396] (0000_2753 / 0x2753)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs1, 0x275C);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0000_2757 / 0x2757)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs1, 0x275E);
    // SUB AH,AH (0000_275C / 0x275C)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x2761);
    // MOV word ptr [BP + -0x48],AX (0000_275E / 0x275E)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    CheckExternalEvents(cs1, 0x2764);
    // MOV BX,word ptr [BP + -0x3c] (0000_2761 / 0x2761)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2768);
    // MOV ES,word ptr [0x53b4] (0000_2764 / 0x2764)
    ES = UInt16[DS, 0x53B4];
    CheckExternalEvents(cs1, 0x276D);
    // MOV byte ptr ES:[BX + 0x3750],AL (0000_2768 / 0x2768)
    UInt8[ES, (ushort)(BX + 0x3750)] = AL;
    CheckExternalEvents(cs1, 0x2772);
    // MOV word ptr [BP + -0x44],0x0 (0000_276D / 0x276D)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x0;
    CheckExternalEvents(cs1, 0x2776);
    // MOV ES,word ptr [0x538a] (0000_2772 / 0x2772)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x277B);
    // CMP byte ptr ES:[0xd346],AH (0000_2776 / 0x2776)
    Alu.Sub8(UInt8[ES, 0xD346], AH);
    CheckExternalEvents(cs1, 0x277D);
    // JNZ 0x0000:27a9 (0000_277B / 0x277B)
    if(!ZeroFlag) {
      goto label_0000_27A9_027A9;
    }
    CheckExternalEvents(cs1, 0x2782);
    // CMP word ptr [BP + -0x48],0xf6 (0000_277D / 0x277D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x48)], 0xF6);
    CheckExternalEvents(cs1, 0x2784);
    // JGE 0x0000:27a9 (0000_2782 / 0x2782)
    if(SignFlag == OverflowFlag) {
      goto label_0000_27A9_027A9;
    }
    CheckExternalEvents(cs1, 0x2787);
    // MOV AX,word ptr [BP + -0x5e] (0000_2784 / 0x2784)
    AX = UInt16[SS, (ushort)(BP - 0x5E)];
    CheckExternalEvents(cs1, 0x278A);
    // TEST word ptr [BP + -0x48],AX (0000_2787 / 0x2787)
    Alu.And16(UInt16[SS, (ushort)(BP - 0x48)], AX);
    CheckExternalEvents(cs1, 0x278C);
    // JZ 0x0000:27a9 (0000_278A / 0x278A)
    if(ZeroFlag) {
      goto label_0000_27A9_027A9;
    }
    CheckExternalEvents(cs1, 0x278F);
    // MOV AX,word ptr [BP + -0x48] (0000_278C / 0x278C)
    AX = UInt16[SS, (ushort)(BP - 0x48)];
    CheckExternalEvents(cs1, 0x2792);
    // AND AX,0xf0 (0000_278F / 0x278F)
    // AX &= 0xF0;
    AX = Alu.And16(AX, 0xF0);
    CheckExternalEvents(cs1, 0x2795);
    // MOV word ptr [BP + -0xa],AX (0000_2792 / 0x2792)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x2798);
    // CMP AX,0x30 (0000_2795 / 0x2795)
    Alu.Sub16(AX, 0x30);
    CheckExternalEvents(cs1, 0x279A);
    // JGE 0x0000:27a9 (0000_2798 / 0x2798)
    if(SignFlag == OverflowFlag) {
      goto label_0000_27A9_027A9;
    }
    CheckExternalEvents(cs1, 0x279F);
    // MOV word ptr [BP + -0x44],0x2 (0000_279A / 0x279A)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x2;
    CheckExternalEvents(cs1, 0x27A2);
    // CMP AX,0x20 (0000_279F / 0x279F)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs1, 0x27A4);
    // JNZ 0x0000:27a9 (0000_27A2 / 0x27A2)
    if(!ZeroFlag) {
      goto label_0000_27A9_027A9;
    }
    CheckExternalEvents(cs1, 0x27A9);
    // MOV word ptr [BP + -0x44],0x4 (0000_27A4 / 0x27A4)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x4;
    label_0000_27A9_027A9:
    CheckExternalEvents(cs1, 0x27AC);
    // MOV AL,byte ptr [BP + -0x44] (0000_27A9 / 0x27A9)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x27AF);
    // MOV BX,word ptr [BP + -0x3c] (0000_27AC / 0x27AC)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x27B3);
    // MOV ES,word ptr [0x5398] (0000_27AF / 0x27AF)
    ES = UInt16[DS, 0x5398];
    CheckExternalEvents(cs1, 0x27B8);
    // MOV byte ptr ES:[BX + 0x32ae],AL (0000_27B3 / 0x27B3)
    UInt8[ES, (ushort)(BX + 0x32AE)] = AL;
    CheckExternalEvents(cs1, 0x27BA);
    // MOV CL,0x3 (0000_27B8 / 0x27B8)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x27BD);
    // SHL word ptr [BP + -0x46],CL (0000_27BA / 0x27BA)
    UInt16[SS, (ushort)(BP - 0x46)] <<= CL;
    CheckExternalEvents(cs1, 0x27C0);
    // SHL word ptr [BP + -0x4a],CL (0000_27BD / 0x27BD)
    // UInt16[SS, (ushort)(BP - 0x4A)] <<= CL;
    UInt16[SS, (ushort)(BP - 0x4A)] = Alu.Shl16(UInt16[SS, (ushort)(BP - 0x4A)], CL);
    CheckExternalEvents(cs1, 0x27C3);
    // MOV SI,word ptr [BP + -0x3c] (0000_27C0 / 0x27C0)
    SI = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x27C5);
    // SHL SI,0x1 (0000_27C3 / 0x27C3)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x27C8);
    // MOV AX,word ptr [BP + -0x46] (0000_27C5 / 0x27C5)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x27CC);
    // MOV ES,word ptr [0x53b6] (0000_27C8 / 0x27C8)
    ES = UInt16[DS, 0x53B6];
    CheckExternalEvents(cs1, 0x27D1);
    // MOV word ptr ES:[SI + 0x324c],AX (0000_27CC / 0x27CC)
    UInt16[ES, (ushort)(SI + 0x324C)] = AX;
    CheckExternalEvents(cs1, 0x27D4);
    // MOV AX,word ptr [BP + -0x4a] (0000_27D1 / 0x27D1)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x27D8);
    // MOV ES,word ptr [0x53b8] (0000_27D4 / 0x27D4)
    ES = UInt16[DS, 0x53B8];
    CheckExternalEvents(cs1, 0x27DD);
    // MOV word ptr ES:[SI + 0x327c],AX (0000_27D8 / 0x27D8)
    UInt16[ES, (ushort)(SI + 0x327C)] = AX;
    CheckExternalEvents(cs1, 0x27E0);
    // MOV BX,word ptr [BP + -0x3c] (0000_27DD / 0x27DD)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x27E4);
    // MOV ES,word ptr [0x539a] (0000_27E0 / 0x27E0)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs1, 0x27E9);
    // MOV BL,byte ptr ES:[BX + 0x409a] (0000_27E4 / 0x27E4)
    BL = UInt8[ES, (ushort)(BX + 0x409A)];
    CheckExternalEvents(cs1, 0x27EB);
    // SUB BH,BH (0000_27E9 / 0x27E9)
    // BH -= BH;
    BH = Alu.Sub8(BH, BH);
    CheckExternalEvents(cs1, 0x27EE);
    // MOV DI,word ptr [BP + -0x3c] (0000_27EB / 0x27EB)
    DI = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x27F2);
    // MOV ES,word ptr [0x539c] (0000_27EE / 0x27EE)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs1, 0x27F7);
    // MOV AL,byte ptr ES:[DI + 0xd55e] (0000_27F2 / 0x27F2)
    AL = UInt8[ES, (ushort)(DI + 0xD55E)];
    CheckExternalEvents(cs1, 0x27F9);
    // SUB AH,AH (0000_27F7 / 0x27F7)
    AH -= AH;
    CheckExternalEvents(cs1, 0x27FB);
    // ADD BX,AX (0000_27F9 / 0x27F9)
    BX += AX;
    CheckExternalEvents(cs1, 0x27FD);
    // SHL BX,0x1 (0000_27FB / 0x27FB)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x27FF);
    // SHL BX,0x1 (0000_27FD / 0x27FD)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x2803);
    // MOV ES,word ptr [0x539e] (0000_27FF / 0x27FF)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs1, 0x2808);
    // MOV AX,word ptr ES:[BX + 0x39fa] (0000_2803 / 0x2803)
    AX = UInt16[ES, (ushort)(BX + 0x39FA)];
    CheckExternalEvents(cs1, 0x280D);
    // MOV DX,word ptr ES:[BX + 0x39fc] (0000_2808 / 0x2808)
    DX = UInt16[ES, (ushort)(BX + 0x39FC)];
    CheckExternalEvents(cs1, 0x2810);
    // MOV word ptr [BP + -0x4],AX (0000_280D / 0x280D)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x2813);
    // MOV word ptr [BP + -0x2],DX (0000_2810 / 0x2810)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs1, 0x2817);
    // MOV ES,word ptr [0x53a0] (0000_2813 / 0x2813)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x281D);
    // CMP word ptr ES:[0x4fba],0x0 (0000_2817 / 0x2817)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x281F);
    // JZ 0x0000:2829 (0000_281D / 0x281D)
    if(ZeroFlag) {
      goto label_0000_2829_02829;
    }
    CheckExternalEvents(cs1, 0x2822);
    // LES BX,[BP + -0x4] (0000_281F / 0x281F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs1, 0x2825);
    // MOV AL,byte ptr [BP + -0x44] (0000_2822 / 0x2822)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2829);
    // SUB byte ptr ES:[BX + 0x1],AL (0000_2825 / 0x2825)
    // UInt8[ES, (ushort)(BX + 0x1)] -= AL;
    UInt8[ES, (ushort)(BX + 0x1)] = Alu.Sub8(UInt8[ES, (ushort)(BX + 0x1)], AL);
    label_0000_2829_02829:
    CheckExternalEvents(cs1, 0x282D);
    // MOV ES,word ptr [0x53a0] (0000_2829 / 0x2829)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x2833);
    // CMP word ptr ES:[0x4fba],0x2 (0000_282D / 0x282D)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0x2835);
    // JNZ 0x0000:2838 (0000_2833 / 0x2833)
    if(!ZeroFlag) {
      goto label_0000_2838_02838;
    }
    CheckExternalEvents(cs1, 0x2838);
    // JMP 0x0000:25ad (0000_2835 / 0x2835)
    goto label_0000_25AD_025AD;
    label_0000_2838_02838:
    CheckExternalEvents(cs1, 0x283E);
    // CMP word ptr ES:[0x4fba],0x0 (0000_2838 / 0x2838)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x2840);
    // JNZ 0x0000:2863 (0000_283E / 0x283E)
    if(!ZeroFlag) {
      goto label_0000_2863_02863;
    }
    CheckExternalEvents(cs1, 0x2844);
    // CMP word ptr [BP + -0x44],0x0 (0000_2840 / 0x2840)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x44)], 0x0);
    CheckExternalEvents(cs1, 0x2846);
    // JZ 0x0000:2863 (0000_2844 / 0x2844)
    if(ZeroFlag) {
      goto label_0000_2863_02863;
    }
    CheckExternalEvents(cs1, 0x284A);
    // MOV ES,word ptr [0x53a2] (0000_2846 / 0x2846)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs1, 0x284D);
    // MOV AX,word ptr [BP + -0x4a] (0000_284A / 0x284A)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2850);
    // SUB AX,word ptr [BP + -0x44] (0000_284D / 0x284D)
    AX -= UInt16[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2853);
    // ADD AX,0x8 (0000_2850 / 0x2850)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs1, 0x2857);
    // MOV ES:[0xb780],AX (0000_2853 / 0x2853)
    UInt16[ES, 0xB780] = AX;
    CheckExternalEvents(cs1, 0x285A);
    // CMP AX,0xc8 (0000_2857 / 0x2857)
    Alu.Sub16(AX, 0xC8);
    CheckExternalEvents(cs1, 0x285C);
    // JLE 0x0000:2863 (0000_285A / 0x285A)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2863_02863;
    }
    CheckExternalEvents(cs1, 0x2863);
    // MOV word ptr ES:[0xb780],0xc8 (0000_285C / 0x285C)
    UInt16[ES, 0xB780] = 0xC8;
    label_0000_2863_02863:
    CheckExternalEvents(cs1, 0x2866);
    // PUSH word ptr [BP + -0x4a] (0000_2863 / 0x2863)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4A)]);
    CheckExternalEvents(cs1, 0x2869);
    // PUSH word ptr [BP + -0x46] (0000_2866 / 0x2866)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x46)]);
    CheckExternalEvents(cs1, 0x286C);
    // PUSH word ptr [BP + -0x2] (0000_2869 / 0x2869)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x286F);
    // PUSH word ptr [BP + -0x4] (0000_286C / 0x286C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x2872);
    // MOV AX,0x244b (0000_286F / 0x286F)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0x2875);
    // MOV DX,0x1ddc (0000_2872 / 0x2872)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x2876);
    // PUSH DX (0000_2875 / 0x2875)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x2877);
    // PUSH AX (0000_2876 / 0x2876)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x287C);
    // CALLF 0x1000:c7db (0000_2877 / 0x2877)
    FarCall(cs1, 0x287C, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs1, 0x287F);
    // ADD SP,0xc (0000_287C / 0x287C)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs1, 0x2883);
    // MOV ES,word ptr [0x53a2] (0000_287F / 0x287F)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs1, 0x288A);
    // MOV word ptr ES:[0xb780],0xc8 (0000_2883 / 0x2883)
    UInt16[ES, 0xB780] = 0xC8;
    CheckExternalEvents(cs1, 0x288D);
    // JMP 0x0000:25c8 (0000_288A / 0x288A)
    goto label_0000_25C8_025C8;
    label_0000_288D_0288D:
    CheckExternalEvents(cs1, 0x2891);
    // ADD word ptr [BP + -0x5c],0xc (0000_288D / 0x288D)
    UInt16[SS, (ushort)(BP - 0x5C)] += 0xC;
    label_0000_2891_02891:
    CheckExternalEvents(cs1, 0x2895);
    // CMP word ptr [BP + -0x5c],0xe (0000_2891 / 0x2891)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x5C)], 0xE);
    CheckExternalEvents(cs1, 0x2897);
    // JGE 0x0000:289f (0000_2895 / 0x2895)
    if(SignFlag == OverflowFlag) {
      goto label_0000_289F_0289F;
    }
    CheckExternalEvents(cs1, 0x289C);
    // MOV word ptr [BP + -0x4c],0x0 (0000_2897 / 0x2897)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x0;
    CheckExternalEvents(cs1, 0x289F);
    // JMP 0x0000:25e1 (0000_289C / 0x289C)
    goto label_0000_25E1_025E1;
    label_0000_289F_0289F:
    CheckExternalEvents(cs1, 0x28A4);
    // MOV word ptr [BP + -0x6],0xffff (0000_289F / 0x289F)
    UInt16[SS, (ushort)(BP - 0x6)] = 0xFFFF;
    CheckExternalEvents(cs1, 0x28A9);
    // MOV word ptr [BP + -0x5c],0x0 (0000_28A4 / 0x28A4)
    UInt16[SS, (ushort)(BP - 0x5C)] = 0x0;
    CheckExternalEvents(cs1, 0x28AC);
    // JMP 0x0000:2b0c (0000_28A9 / 0x28A9)
    goto label_0000_2B0C_02B0C;
    label_0000_28AC_028AC:
    CheckExternalEvents(cs1, 0x28AF);
    // INC word ptr [BP + -0x4c] (0000_28AC / 0x28AC)
    UInt16[SS, (ushort)(BP - 0x4C)]++;
    label_0000_28AF_028AF:
    CheckExternalEvents(cs1, 0x28B3);
    // CMP word ptr [BP + -0x4c],0x4 (0000_28AF / 0x28AF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4C)], 0x4);
    CheckExternalEvents(cs1, 0x28B5);
    // JL 0x0000:28b8 (0000_28B3 / 0x28B3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_28B8_028B8;
    }
    CheckExternalEvents(cs1, 0x28B8);
    // JMP 0x0000:2b08 (0000_28B5 / 0x28B5)
    goto label_0000_2B08_02B08;
    label_0000_28B8_028B8:
    CheckExternalEvents(cs1, 0x28BB);
    // MOV SI,word ptr [BP + -0x4c] (0000_28B8 / 0x28B8)
    SI = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x28BE);
    // ADD SI,word ptr [BP + -0x5c] (0000_28BB / 0x28BB)
    SI += UInt16[SS, (ushort)(BP - 0x5C)];
    CheckExternalEvents(cs1, 0x28C0);
    // SHL SI,0x1 (0000_28BE / 0x28BE)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x28C4);
    // MOV ES,word ptr [0x53a4] (0000_28C0 / 0x28C0)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs1, 0x28CA);
    // CMP word ptr ES:[SI + 0x4004],-0x1 (0000_28C4 / 0x28C4)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x4004)], 0xFFFF);
    CheckExternalEvents(cs1, 0x28CC);
    // JZ 0x0000:28ac (0000_28CA / 0x28CA)
    if(ZeroFlag) {
      goto label_0000_28AC_028AC;
    }
    CheckExternalEvents(cs1, 0x28CF);
    // MOV AX,word ptr [BP + -0x4c] (0000_28CC / 0x28CC)
    AX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x28D2);
    // ADD AX,word ptr [BP + -0x5c] (0000_28CF / 0x28CF)
    // AX += UInt16[SS, (ushort)(BP - 0x5C)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x5C)]);
    CheckExternalEvents(cs1, 0x28D5);
    // MOV word ptr [BP + -0x3c],AX (0000_28D2 / 0x28D2)
    UInt16[SS, (ushort)(BP - 0x3C)] = AX;
    CheckExternalEvents(cs1, 0x28DA);
    // MOV AX,word ptr ES:[SI + 0x4004] (0000_28D5 / 0x28D5)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs1, 0x28DD);
    // MOV word ptr [BP + -0x46],AX (0000_28DA / 0x28DA)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x28E1);
    // MOV ES,word ptr [0x53a6] (0000_28DD / 0x28DD)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs1, 0x28E6);
    // MOV AX,word ptr ES:[SI + 0x4036] (0000_28E1 / 0x28E1)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs1, 0x28E9);
    // MOV word ptr [BP + -0x4a],AX (0000_28E6 / 0x28E6)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs1, 0x28EB);
    // SUB AX,AX (0000_28E9 / 0x28E9)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x28EE);
    // MOV word ptr [BP + -0x50],AX (0000_28EB / 0x28EB)
    UInt16[SS, (ushort)(BP - 0x50)] = AX;
    CheckExternalEvents(cs1, 0x28F1);
    // MOV word ptr [BP + -0x4e],AX (0000_28EE / 0x28EE)
    UInt16[SS, (ushort)(BP - 0x4E)] = AX;
    CheckExternalEvents(cs1, 0x28F4);
    // MOV AX,word ptr [BP + -0x46] (0000_28F1 / 0x28F1)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x28F7);
    // SUB AX,word ptr [BP + -0xc] (0000_28F4 / 0x28F4)
    AX -= UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x28FA);
    // ADD AX,0x1a (0000_28F7 / 0x28F7)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs1, 0x28FD);
    // MOV word ptr [BP + -0x46],AX (0000_28FA / 0x28FA)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2900);
    // MOV AX,word ptr [BP + -0x4a] (0000_28FD / 0x28FD)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2903);
    // SUB AX,word ptr [BP + -0x16] (0000_2900 / 0x2900)
    AX -= UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0x2906);
    // ADD AX,0xc (0000_2903 / 0x2903)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs1, 0x2909);
    // MOV word ptr [BP + -0x4a],AX (0000_2906 / 0x2906)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs1, 0x290D);
    // MOV ES,word ptr [0x53a4] (0000_2909 / 0x2909)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs1, 0x2912);
    // MOV AX,word ptr ES:[SI + 0x4004] (0000_290D / 0x290D)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs1, 0x2914);
    // SUB AL,AL (0000_2912 / 0x2912)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs1, 0x2917);
    // MOV CX,word ptr [BP + -0xc] (0000_2914 / 0x2914)
    CX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0x2919);
    // SUB CL,CL (0000_2917 / 0x2917)
    CL -= CL;
    CheckExternalEvents(cs1, 0x291B);
    // CMP AX,CX (0000_2919 / 0x2919)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0x291D);
    // JNZ 0x0000:292e (0000_291B / 0x291B)
    if(!ZeroFlag) {
      goto label_0000_292E_0292E;
    }
    CheckExternalEvents(cs1, 0x2921);
    // CMP word ptr [BP + -0x46],0xb (0000_291D / 0x291D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xB);
    CheckExternalEvents(cs1, 0x2923);
    // JL 0x0000:2929 (0000_2921 / 0x2921)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2929_02929;
    }
    CheckExternalEvents(cs1, 0x2927);
    // CMP word ptr [BP + -0x46],0x27 (0000_2923 / 0x2923)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0x27);
    CheckExternalEvents(cs1, 0x2929);
    // JLE 0x0000:292e (0000_2927 / 0x2927)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_292E_0292E;
    }
    label_0000_2929_02929:
    CheckExternalEvents(cs1, 0x292E);
    // MOV word ptr [BP + -0x4e],0x1 (0000_2929 / 0x2929)
    UInt16[SS, (ushort)(BP - 0x4E)] = 0x1;
    label_0000_292E_0292E:
    CheckExternalEvents(cs1, 0x2931);
    // MOV BX,word ptr [BP + -0x3c] (0000_292E / 0x292E)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2933);
    // SHL BX,0x1 (0000_2931 / 0x2931)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x2937);
    // MOV ES,word ptr [0x53a6] (0000_2933 / 0x2933)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs1, 0x293C);
    // MOV AX,word ptr ES:[BX + 0x4036] (0000_2937 / 0x2937)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs1, 0x293E);
    // SUB AL,AL (0000_293C / 0x293C)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs1, 0x2941);
    // MOV CX,word ptr [BP + -0x16] (0000_293E / 0x293E)
    CX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0x2943);
    // SUB CL,CL (0000_2941 / 0x2941)
    CL -= CL;
    CheckExternalEvents(cs1, 0x2945);
    // CMP AX,CX (0000_2943 / 0x2943)
    Alu.Sub16(AX, CX);
    CheckExternalEvents(cs1, 0x2947);
    // JNZ 0x0000:2958 (0000_2945 / 0x2945)
    if(!ZeroFlag) {
      goto label_0000_2958_02958;
    }
    CheckExternalEvents(cs1, 0x294B);
    // CMP word ptr [BP + -0x4a],0x0 (0000_2947 / 0x2947)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0x0);
    CheckExternalEvents(cs1, 0x294D);
    // JL 0x0000:2953 (0000_294B / 0x294B)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2953_02953;
    }
    CheckExternalEvents(cs1, 0x2951);
    // CMP word ptr [BP + -0x4a],0x1a (0000_294D / 0x294D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0x1A);
    CheckExternalEvents(cs1, 0x2953);
    // JLE 0x0000:2958 (0000_2951 / 0x2951)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2958_02958;
    }
    label_0000_2953_02953:
    CheckExternalEvents(cs1, 0x2958);
    // MOV word ptr [BP + -0x50],0x1 (0000_2953 / 0x2953)
    UInt16[SS, (ushort)(BP - 0x50)] = 0x1;
    label_0000_2958_02958:
    CheckExternalEvents(cs1, 0x295A);
    // SUB AL,AL (0000_2958 / 0x2958)
    // AL -= AL;
    AL = Alu.Sub8(AL, AL);
    CheckExternalEvents(cs1, 0x295D);
    // MOV BX,word ptr [BP + -0x3c] (0000_295A / 0x295A)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2961);
    // MOV ES,word ptr [0x53ba] (0000_295D / 0x295D)
    ES = UInt16[DS, 0x53BA];
    CheckExternalEvents(cs1, 0x2966);
    // MOV byte ptr ES:[BX + 0x4554],AL (0000_2961 / 0x2961)
    UInt8[ES, (ushort)(BX + 0x4554)] = AL;
    CheckExternalEvents(cs1, 0x2969);
    // MOV BX,word ptr [BP + -0x3c] (0000_2966 / 0x2966)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x296D);
    // MOV ES,word ptr [0x53bc] (0000_2969 / 0x2969)
    ES = UInt16[DS, 0x53BC];
    CheckExternalEvents(cs1, 0x2972);
    // MOV byte ptr ES:[BX + 0x45ce],AL (0000_296D / 0x296D)
    UInt8[ES, (ushort)(BX + 0x45CE)] = AL;
    CheckExternalEvents(cs1, 0x2976);
    // CMP word ptr [BP + -0x46],-0x75 (0000_2972 / 0x2972)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xFF8B);
    CheckExternalEvents(cs1, 0x2978);
    // JGE 0x0000:297b (0000_2976 / 0x2976)
    if(SignFlag == OverflowFlag) {
      goto label_0000_297B_0297B;
    }
    CheckExternalEvents(cs1, 0x297B);
    // JMP 0x0000:28ac (0000_2978 / 0x2978)
    goto label_0000_28AC_028AC;
    label_0000_297B_0297B:
    CheckExternalEvents(cs1, 0x2980);
    // CMP word ptr [BP + -0x46],0xa7 (0000_297B / 0x297B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xA7);
    CheckExternalEvents(cs1, 0x2982);
    // JLE 0x0000:2985 (0000_2980 / 0x2980)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2985_02985;
    }
    CheckExternalEvents(cs1, 0x2985);
    // JMP 0x0000:28ac (0000_2982 / 0x2982)
    goto label_0000_28AC_028AC;
    label_0000_2985_02985:
    CheckExternalEvents(cs1, 0x298A);
    // CMP word ptr [BP + -0x4a],0xf080 (0000_2985 / 0x2985)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0xF080);
    CheckExternalEvents(cs1, 0x298C);
    // JGE 0x0000:298f (0000_298A / 0x298A)
    if(SignFlag == OverflowFlag) {
      goto label_0000_298F_0298F;
    }
    CheckExternalEvents(cs1, 0x298F);
    // JMP 0x0000:28ac (0000_298C / 0x298C)
    goto label_0000_28AC_028AC;
    label_0000_298F_0298F:
    CheckExternalEvents(cs1, 0x2994);
    // CMP word ptr [BP + -0x4a],0xf9a (0000_298F / 0x298F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0xF9A);
    CheckExternalEvents(cs1, 0x2996);
    // JLE 0x0000:2999 (0000_2994 / 0x2994)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2999_02999;
    }
    CheckExternalEvents(cs1, 0x2999);
    // JMP 0x0000:28ac (0000_2996 / 0x2996)
    goto label_0000_28AC_028AC;
    label_0000_2999_02999:
    CheckExternalEvents(cs1, 0x299C);
    // MOV AX,word ptr [BP + -0x4e] (0000_2999 / 0x2999)
    AX = UInt16[SS, (ushort)(BP - 0x4E)];
    CheckExternalEvents(cs1, 0x299F);
    // ADD AX,word ptr [BP + -0x50] (0000_299C / 0x299C)
    // AX += UInt16[SS, (ushort)(BP - 0x50)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x50)]);
    CheckExternalEvents(cs1, 0x29A1);
    // JZ 0x0000:29a4 (0000_299F / 0x299F)
    if(ZeroFlag) {
      goto label_0000_29A4_029A4;
    }
    CheckExternalEvents(cs1, 0x29A4);
    // JMP 0x0000:28ac (0000_29A1 / 0x29A1)
    goto label_0000_28AC_028AC;
    label_0000_29A4_029A4:
    CheckExternalEvents(cs1, 0x29A7);
    // MOV BX,word ptr [BP + -0x3c] (0000_29A4 / 0x29A4)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x29AB);
    // MOV ES,word ptr [0x53b2] (0000_29A7 / 0x29A7)
    ES = UInt16[DS, 0x53B2];
    CheckExternalEvents(cs1, 0x29B1);
    // MOV byte ptr ES:[BX + 0x42f6],0x1 (0000_29AB / 0x29AB)
    UInt8[ES, (ushort)(BX + 0x42F6)] = 0x1;
    CheckExternalEvents(cs1, 0x29B5);
    // AND word ptr [BP + -0x46],0x7f (0000_29B1 / 0x29B1)
    UInt16[SS, (ushort)(BP - 0x46)] &= 0x7F;
    CheckExternalEvents(cs1, 0x29B9);
    // AND word ptr [BP + -0x4a],0x7f (0000_29B5 / 0x29B5)
    // UInt16[SS, (ushort)(BP - 0x4A)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x4A)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x4A)], 0x7F);
    CheckExternalEvents(cs1, 0x29BC);
    // MOV AX,word ptr [BP + -0x4a] (0000_29B9 / 0x29B9)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x29BE);
    // SAR AX,0x1 (0000_29BC / 0x29BC)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0x29C1);
    // MOV CX,0x18 (0000_29BE / 0x29BE)
    CX = 0x18;
    CheckExternalEvents(cs1, 0x29C3);
    // IMUL CX (0000_29C1 / 0x29C1)
    int resImul0000_29C1 = Alu.Imul16((short)AX, (short)CX);
    AX = (ushort)(resImul0000_29C1);
    DX = (ushort)(resImul0000_29C1 >> 16);
    CheckExternalEvents(cs1, 0x29C6);
    // MOV word ptr [BP + -0x42],AX (0000_29C3 / 0x29C3)
    UInt16[SS, (ushort)(BP - 0x42)] = AX;
    CheckExternalEvents(cs1, 0x29CA);
    // TEST byte ptr [BP + -0x4a],0x1 (0000_29C6 / 0x29C6)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x4A)], 0x1);
    CheckExternalEvents(cs1, 0x29CC);
    // JZ 0x0000:29d6 (0000_29CA / 0x29CA)
    if(ZeroFlag) {
      goto label_0000_29D6_029D6;
    }
    CheckExternalEvents(cs1, 0x29D0);
    // TEST byte ptr [BP + -0x16],0x1 (0000_29CC / 0x29CC)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x16)], 0x1);
    CheckExternalEvents(cs1, 0x29D2);
    // JZ 0x0000:29d6 (0000_29D0 / 0x29D0)
    if(ZeroFlag) {
      goto label_0000_29D6_029D6;
    }
    CheckExternalEvents(cs1, 0x29D6);
    // ADD word ptr [BP + -0x42],0x18 (0000_29D2 / 0x29D2)
    // UInt16[SS, (ushort)(BP - 0x42)] += 0x18;
    UInt16[SS, (ushort)(BP - 0x42)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x42)], 0x18);
    label_0000_29D6_029D6:
    CheckExternalEvents(cs1, 0x29DB);
    // MOV word ptr [BP + -0x5e],0x1 (0000_29D6 / 0x29D6)
    UInt16[SS, (ushort)(BP - 0x5E)] = 0x1;
    CheckExternalEvents(cs1, 0x29DE);
    // MOV AL,byte ptr [BP + -0x4a] (0000_29DB / 0x29DB)
    AL = UInt8[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x29E1);
    // XOR AL,byte ptr [BP + -0x16] (0000_29DE / 0x29DE)
    AL ^= UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0x29E3);
    // TEST AL,0x1 (0000_29E1 / 0x29E1)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs1, 0x29E5);
    // JZ 0x0000:29f7 (0000_29E3 / 0x29E3)
    if(ZeroFlag) {
      goto label_0000_29F7_029F7;
    }
    CheckExternalEvents(cs1, 0x29EA);
    // MOV word ptr [BP + -0x5e],0x4 (0000_29E5 / 0x29E5)
    UInt16[SS, (ushort)(BP - 0x5E)] = 0x4;
    CheckExternalEvents(cs1, 0x29ED);
    // MOV BX,word ptr [BP + -0x3c] (0000_29EA / 0x29EA)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x29F1);
    // MOV ES,word ptr [0x53ba] (0000_29ED / 0x29ED)
    ES = UInt16[DS, 0x53BA];
    CheckExternalEvents(cs1, 0x29F7);
    // MOV byte ptr ES:[BX + 0x4554],0x1 (0000_29F1 / 0x29F1)
    UInt8[ES, (ushort)(BX + 0x4554)] = 0x1;
    label_0000_29F7_029F7:
    CheckExternalEvents(cs1, 0x29FA);
    // MOV SI,word ptr [BP + -0x46] (0000_29F7 / 0x29F7)
    SI = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x29FC);
    // SHL SI,0x1 (0000_29FA / 0x29FA)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x2A00);
    // MOV AX,word ptr [SI + 0x364] (0000_29FC / 0x29FC)
    AX = UInt16[DS, (ushort)(SI + 0x364)];
    CheckExternalEvents(cs1, 0x2A03);
    // ADD word ptr [BP + -0x42],AX (0000_2A00 / 0x2A00)
    UInt16[SS, (ushort)(BP - 0x42)] += AX;
    CheckExternalEvents(cs1, 0x2A07);
    // TEST byte ptr [BP + -0xc],0x1 (0000_2A03 / 0x2A03)
    Alu.And8(UInt8[SS, (ushort)(BP - 0xC)], 0x1);
    CheckExternalEvents(cs1, 0x2A09);
    // JZ 0x0000:2a10 (0000_2A07 / 0x2A07)
    if(ZeroFlag) {
      goto label_0000_2A10_02A10;
    }
    CheckExternalEvents(cs1, 0x2A0D);
    // MOV AX,word ptr [SI + 0x39e] (0000_2A09 / 0x2A09)
    AX = UInt16[DS, (ushort)(SI + 0x39E)];
    CheckExternalEvents(cs1, 0x2A10);
    // ADD word ptr [BP + -0x42],AX (0000_2A0D / 0x2A0D)
    // UInt16[SS, (ushort)(BP - 0x42)] += AX;
    UInt16[SS, (ushort)(BP - 0x42)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0x42)], AX);
    label_0000_2A10_02A10:
    CheckExternalEvents(cs1, 0x2A14);
    // MOV ES,word ptr [0x5394] (0000_2A10 / 0x2A10)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs1, 0x2A19);
    // MOV SI,word ptr ES:[0x9ed] (0000_2A14 / 0x2A14)
    SI = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs1, 0x2A1C);
    // ADD SI,word ptr [BP + -0x42] (0000_2A19 / 0x2A19)
    // SI += UInt16[SS, (ushort)(BP - 0x42)];
    SI = Alu.Add16(SI, UInt16[SS, (ushort)(BP - 0x42)]);
    CheckExternalEvents(cs1, 0x2A20);
    // MOV ES,word ptr [0x5396] (0000_2A1C / 0x2A1C)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs1, 0x2A25);
    // MOV AL,byte ptr ES:[SI + 0x795] (0000_2A20 / 0x2A20)
    AL = UInt8[ES, (ushort)(SI + 0x795)];
    CheckExternalEvents(cs1, 0x2A28);
    // MOV BX,word ptr [BP + -0x3c] (0000_2A25 / 0x2A25)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2A2C);
    // MOV ES,word ptr [0x53bc] (0000_2A28 / 0x2A28)
    ES = UInt16[DS, 0x53BC];
    CheckExternalEvents(cs1, 0x2A31);
    // MOV byte ptr ES:[BX + 0x45ce],AL (0000_2A2C / 0x2A2C)
    UInt8[ES, (ushort)(BX + 0x45CE)] = AL;
    CheckExternalEvents(cs1, 0x2A35);
    // MOV ES,word ptr [0x5396] (0000_2A31 / 0x2A31)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs1, 0x2A3A);
    // MOV AL,byte ptr ES:[SI + 0x7ad] (0000_2A35 / 0x2A35)
    AL = UInt8[ES, (ushort)(SI + 0x7AD)];
    CheckExternalEvents(cs1, 0x2A3C);
    // SUB AH,AH (0000_2A3A / 0x2A3A)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x2A3F);
    // MOV word ptr [BP + -0x48],AX (0000_2A3C / 0x2A3C)
    UInt16[SS, (ushort)(BP - 0x48)] = AX;
    CheckExternalEvents(cs1, 0x2A42);
    // MOV BX,word ptr [BP + -0x3c] (0000_2A3F / 0x2A3F)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2A46);
    // MOV ES,word ptr [0x53b4] (0000_2A42 / 0x2A42)
    ES = UInt16[DS, 0x53B4];
    CheckExternalEvents(cs1, 0x2A4B);
    // MOV byte ptr ES:[BX + 0x3750],AL (0000_2A46 / 0x2A46)
    UInt8[ES, (ushort)(BX + 0x3750)] = AL;
    CheckExternalEvents(cs1, 0x2A50);
    // MOV word ptr [BP + -0x44],0x0 (0000_2A4B / 0x2A4B)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x0;
    CheckExternalEvents(cs1, 0x2A54);
    // MOV ES,word ptr [0x538a] (0000_2A50 / 0x2A50)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs1, 0x2A59);
    // CMP byte ptr ES:[0xd346],AH (0000_2A54 / 0x2A54)
    Alu.Sub8(UInt8[ES, 0xD346], AH);
    CheckExternalEvents(cs1, 0x2A5B);
    // JNZ 0x0000:2a94 (0000_2A59 / 0x2A59)
    if(!ZeroFlag) {
      goto label_0000_2A94_02A94;
    }
    CheckExternalEvents(cs1, 0x2A60);
    // CMP word ptr [BP + -0x48],0xf6 (0000_2A5B / 0x2A5B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x48)], 0xF6);
    CheckExternalEvents(cs1, 0x2A62);
    // JGE 0x0000:2a94 (0000_2A60 / 0x2A60)
    if(SignFlag == OverflowFlag) {
      goto label_0000_2A94_02A94;
    }
    CheckExternalEvents(cs1, 0x2A65);
    // MOV AX,word ptr [BP + -0x5e] (0000_2A62 / 0x2A62)
    AX = UInt16[SS, (ushort)(BP - 0x5E)];
    CheckExternalEvents(cs1, 0x2A68);
    // TEST word ptr [BP + -0x48],AX (0000_2A65 / 0x2A65)
    Alu.And16(UInt16[SS, (ushort)(BP - 0x48)], AX);
    CheckExternalEvents(cs1, 0x2A6A);
    // JZ 0x0000:2a94 (0000_2A68 / 0x2A68)
    if(ZeroFlag) {
      goto label_0000_2A94_02A94;
    }
    CheckExternalEvents(cs1, 0x2A6D);
    // MOV AX,word ptr [BP + -0x48] (0000_2A6A / 0x2A6A)
    AX = UInt16[SS, (ushort)(BP - 0x48)];
    CheckExternalEvents(cs1, 0x2A70);
    // AND AX,0xf0 (0000_2A6D / 0x2A6D)
    // AX &= 0xF0;
    AX = Alu.And16(AX, 0xF0);
    CheckExternalEvents(cs1, 0x2A73);
    // MOV word ptr [BP + -0xa],AX (0000_2A70 / 0x2A70)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0x2A76);
    // CMP AX,0x30 (0000_2A73 / 0x2A73)
    Alu.Sub16(AX, 0x30);
    CheckExternalEvents(cs1, 0x2A78);
    // JGE 0x0000:2a94 (0000_2A76 / 0x2A76)
    if(SignFlag == OverflowFlag) {
      goto label_0000_2A94_02A94;
    }
    CheckExternalEvents(cs1, 0x2A7D);
    // MOV word ptr [BP + -0x44],0x8 (0000_2A78 / 0x2A78)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x8;
    CheckExternalEvents(cs1, 0x2A80);
    // CMP AX,0x20 (0000_2A7D / 0x2A7D)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs1, 0x2A82);
    // JZ 0x0000:2a86 (0000_2A80 / 0x2A80)
    if(ZeroFlag) {
      goto label_0000_2A86_02A86;
    }
    CheckExternalEvents(cs1, 0x2A84);
    // OR AX,AX (0000_2A82 / 0x2A82)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0x2A86);
    // JNZ 0x0000:2a94 (0000_2A84 / 0x2A84)
    if(!ZeroFlag) {
      goto label_0000_2A94_02A94;
    }
    label_0000_2A86_02A86:
    CheckExternalEvents(cs1, 0x2A89);
    // MOV AL,byte ptr [BP + -0x48] (0000_2A86 / 0x2A86)
    AL = UInt8[SS, (ushort)(BP - 0x48)];
    CheckExternalEvents(cs1, 0x2A8B);
    // AND AL,0xf (0000_2A89 / 0x2A89)
    AL &= 0xF;
    CheckExternalEvents(cs1, 0x2A8D);
    // CMP AL,0xf (0000_2A8B / 0x2A8B)
    Alu.Sub8(AL, 0xF);
    CheckExternalEvents(cs1, 0x2A8F);
    // JNZ 0x0000:2a94 (0000_2A8D / 0x2A8D)
    if(!ZeroFlag) {
      goto label_0000_2A94_02A94;
    }
    CheckExternalEvents(cs1, 0x2A94);
    // MOV word ptr [BP + -0x44],0x10 (0000_2A8F / 0x2A8F)
    UInt16[SS, (ushort)(BP - 0x44)] = 0x10;
    label_0000_2A94_02A94:
    CheckExternalEvents(cs1, 0x2A97);
    // MOV AL,byte ptr [BP + -0x44] (0000_2A94 / 0x2A94)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2A9A);
    // MOV BX,word ptr [BP + -0x3c] (0000_2A97 / 0x2A97)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2A9E);
    // MOV ES,word ptr [0x5398] (0000_2A9A / 0x2A9A)
    ES = UInt16[DS, 0x5398];
    CheckExternalEvents(cs1, 0x2AA3);
    // MOV byte ptr ES:[BX + 0x32ae],AL (0000_2A9E / 0x2A9E)
    UInt8[ES, (ushort)(BX + 0x32AE)] = AL;
    CheckExternalEvents(cs1, 0x2AA5);
    // MOV CL,0x3 (0000_2AA3 / 0x2AA3)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x2AA8);
    // SHL word ptr [BP + -0x46],CL (0000_2AA5 / 0x2AA5)
    UInt16[SS, (ushort)(BP - 0x46)] <<= CL;
    CheckExternalEvents(cs1, 0x2AAB);
    // SHL word ptr [BP + -0x4a],CL (0000_2AA8 / 0x2AA8)
    // UInt16[SS, (ushort)(BP - 0x4A)] <<= CL;
    UInt16[SS, (ushort)(BP - 0x4A)] = Alu.Shl16(UInt16[SS, (ushort)(BP - 0x4A)], CL);
    CheckExternalEvents(cs1, 0x2AAE);
    // MOV SI,word ptr [BP + -0x3c] (0000_2AAB / 0x2AAB)
    SI = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2AB0);
    // SHL SI,0x1 (0000_2AAE / 0x2AAE)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x2AB3);
    // MOV AX,word ptr [BP + -0x46] (0000_2AB0 / 0x2AB0)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2AB7);
    // MOV ES,word ptr [0x53b6] (0000_2AB3 / 0x2AB3)
    ES = UInt16[DS, 0x53B6];
    CheckExternalEvents(cs1, 0x2ABC);
    // MOV word ptr ES:[SI + 0x324c],AX (0000_2AB7 / 0x2AB7)
    UInt16[ES, (ushort)(SI + 0x324C)] = AX;
    CheckExternalEvents(cs1, 0x2ABF);
    // MOV AX,word ptr [BP + -0x4a] (0000_2ABC / 0x2ABC)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2AC3);
    // MOV ES,word ptr [0x53b8] (0000_2ABF / 0x2ABF)
    ES = UInt16[DS, 0x53B8];
    CheckExternalEvents(cs1, 0x2AC8);
    // MOV word ptr ES:[SI + 0x327c],AX (0000_2AC3 / 0x2AC3)
    UInt16[ES, (ushort)(SI + 0x327C)] = AX;
    CheckExternalEvents(cs1, 0x2ACB);
    // INC word ptr [BP + -0x6] (0000_2AC8 / 0x2AC8)
    UInt16[SS, (ushort)(BP - 0x6)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x2ACE);
    // MOV DI,word ptr [BP + -0x6] (0000_2ACB / 0x2ACB)
    DI = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2AD0);
    // SHL DI,0x1 (0000_2ACE / 0x2ACE)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    CheckExternalEvents(cs1, 0x2AD3);
    // MOV AX,word ptr [BP + -0x46] (0000_2AD0 / 0x2AD0)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2AD6);
    // MOV word ptr [BP + DI + -0x26],AX (0000_2AD3 / 0x2AD3)
    UInt16[SS, (ushort)(BP + DI - 0x26)] = AX;
    CheckExternalEvents(cs1, 0x2AD9);
    // MOV DI,word ptr [BP + -0x6] (0000_2AD6 / 0x2AD6)
    DI = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2ADB);
    // SHL DI,0x1 (0000_2AD9 / 0x2AD9)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    CheckExternalEvents(cs1, 0x2ADE);
    // MOV AX,word ptr [BP + -0x4a] (0000_2ADB / 0x2ADB)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2AE1);
    // MOV word ptr [BP + DI + -0x3a],AX (0000_2ADE / 0x2ADE)
    UInt16[SS, (ushort)(BP + DI - 0x3A)] = AX;
    CheckExternalEvents(cs1, 0x2AE4);
    // MOV DI,word ptr [BP + -0x6] (0000_2AE1 / 0x2AE1)
    DI = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2AE7);
    // MOV AL,byte ptr [BP + -0x44] (0000_2AE4 / 0x2AE4)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2AEA);
    // MOV byte ptr [BP + DI + -0x14],AL (0000_2AE7 / 0x2AE7)
    UInt8[SS, (ushort)(BP + DI - 0x14)] = AL;
    CheckExternalEvents(cs1, 0x2AED);
    // MOV BX,word ptr [BP + -0x3c] (0000_2AEA / 0x2AEA)
    BX = UInt16[SS, (ushort)(BP - 0x3C)];
    CheckExternalEvents(cs1, 0x2AF1);
    // MOV ES,word ptr [0x539a] (0000_2AED / 0x2AED)
    ES = UInt16[DS, 0x539A];
    CheckExternalEvents(cs1, 0x2AF6);
    // MOV AL,byte ptr ES:[BX + 0x409a] (0000_2AF1 / 0x2AF1)
    AL = UInt8[ES, (ushort)(BX + 0x409A)];
    CheckExternalEvents(cs1, 0x2AFA);
    // MOV ES,word ptr [0x539c] (0000_2AF6 / 0x2AF6)
    ES = UInt16[DS, 0x539C];
    CheckExternalEvents(cs1, 0x2AFF);
    // ADD AL,byte ptr ES:[BX + 0xd55e] (0000_2AFA / 0x2AFA)
    // AL += UInt8[ES, (ushort)(BX + 0xD55E)];
    AL = Alu.Add8(AL, UInt8[ES, (ushort)(BX + 0xD55E)]);
    CheckExternalEvents(cs1, 0x2B02);
    // MOV DI,word ptr [BP + -0x6] (0000_2AFF / 0x2AFF)
    DI = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2B05);
    // MOV byte ptr [BP + DI + -0x5a],AL (0000_2B02 / 0x2B02)
    UInt8[SS, (ushort)(BP + DI - 0x5A)] = AL;
    CheckExternalEvents(cs1, 0x2B08);
    // JMP 0x0000:28ac (0000_2B05 / 0x2B05)
    goto label_0000_28AC_028AC;
    label_0000_2B08_02B08:
    CheckExternalEvents(cs1, 0x2B0C);
    // ADD word ptr [BP + -0x5c],0xc (0000_2B08 / 0x2B08)
    UInt16[SS, (ushort)(BP - 0x5C)] += 0xC;
    label_0000_2B0C_02B0C:
    CheckExternalEvents(cs1, 0x2B10);
    // CMP word ptr [BP + -0x5c],0xe (0000_2B0C / 0x2B0C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x5C)], 0xE);
    CheckExternalEvents(cs1, 0x2B12);
    // JGE 0x0000:2b1a (0000_2B10 / 0x2B10)
    if(SignFlag == OverflowFlag) {
      goto label_0000_2B1A_02B1A;
    }
    CheckExternalEvents(cs1, 0x2B17);
    // MOV word ptr [BP + -0x4c],0x0 (0000_2B12 / 0x2B12)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x0;
    CheckExternalEvents(cs1, 0x2B1A);
    // JMP 0x0000:28af (0000_2B17 / 0x2B17)
    goto label_0000_28AF_028AF;
    label_0000_2B1A_02B1A:
    CheckExternalEvents(cs1, 0x2B1E);
    // CMP word ptr [BP + -0x6],-0x1 (0000_2B1A / 0x2B1A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0xFFFF);
    CheckExternalEvents(cs1, 0x2B20);
    // JNZ 0x0000:2b23 (0000_2B1E / 0x2B1E)
    if(!ZeroFlag) {
      goto label_0000_2B23_02B23;
    }
    CheckExternalEvents(cs1, 0x2B23);
    // JMP 0x0000:2d16 (0000_2B20 / 0x2B20)
    goto label_0000_2D16_02D16;
    label_0000_2B23_02B23:
    CheckExternalEvents(cs1, 0x2B27);
    // CMP word ptr [BP + -0x6],0x0 (0000_2B23 / 0x2B23)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x0);
    CheckExternalEvents(cs1, 0x2B29);
    // JG 0x0000:2b2c (0000_2B27 / 0x2B27)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_2B2C_02B2C;
    }
    CheckExternalEvents(cs1, 0x2B2C);
    // JMP 0x0000:2c08 (0000_2B29 / 0x2B29)
    goto label_0000_2C08_02C08;
    label_0000_2B2C_02B2C:
    CheckExternalEvents(cs1, 0x2B31);
    // MOV word ptr [BP + -0x4c],0x0 (0000_2B2C / 0x2B2C)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x0;
    CheckExternalEvents(cs1, 0x2B34);
    // JMP 0x0000:2bf6 (0000_2B31 / 0x2B31)
    goto label_0000_2BF6_02BF6;
    label_0000_2B34_02B34:
    CheckExternalEvents(cs1, 0x2B37);
    // INC word ptr [BP + -0x46] (0000_2B34 / 0x2B34)
    UInt16[SS, (ushort)(BP - 0x46)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x46)]);
    label_0000_2B37_02B37:
    CheckExternalEvents(cs1, 0x2B3A);
    // MOV AX,word ptr [BP + -0x6] (0000_2B37 / 0x2B37)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2B3D);
    // CMP word ptr [BP + -0x46],AX (0000_2B3A / 0x2B3A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], AX);
    CheckExternalEvents(cs1, 0x2B3F);
    // JLE 0x0000:2b42 (0000_2B3D / 0x2B3D)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2B42_02B42;
    }
    CheckExternalEvents(cs1, 0x2B42);
    // JMP 0x0000:2bf3 (0000_2B3F / 0x2B3F)
    goto label_0000_2BF3_02BF3;
    label_0000_2B42_02B42:
    CheckExternalEvents(cs1, 0x2B45);
    // MOV BX,word ptr [BP + -0x4c] (0000_2B42 / 0x2B42)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2B47);
    // SHL BX,0x1 (0000_2B45 / 0x2B45)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B49);
    // ADD BX,BP (0000_2B47 / 0x2B47)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B4C);
    // MOV SI,word ptr [BX + -0x3a] (0000_2B49 / 0x2B49)
    SI = UInt16[DS, (ushort)(BX - 0x3A)];
    CheckExternalEvents(cs1, 0x2B4F);
    // MOV BX,word ptr [BP + -0x46] (0000_2B4C / 0x2B4C)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2B51);
    // SHL BX,0x1 (0000_2B4F / 0x2B4F)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B53);
    // ADD BX,BP (0000_2B51 / 0x2B51)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B56);
    // MOV DI,word ptr [BX + -0x3a] (0000_2B53 / 0x2B53)
    DI = UInt16[DS, (ushort)(BX - 0x3A)];
    CheckExternalEvents(cs1, 0x2B58);
    // CMP DI,SI (0000_2B56 / 0x2B56)
    Alu.Sub16(DI, SI);
    CheckExternalEvents(cs1, 0x2B5A);
    // JGE 0x0000:2b34 (0000_2B58 / 0x2B58)
    if(SignFlag == OverflowFlag) {
      goto label_0000_2B34_02B34;
    }
    CheckExternalEvents(cs1, 0x2B5D);
    // MOV BX,word ptr [BP + -0x46] (0000_2B5A / 0x2B5A)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2B5F);
    // SHL BX,0x1 (0000_2B5D / 0x2B5D)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B61);
    // ADD BX,BP (0000_2B5F / 0x2B5F)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B64);
    // MOV AX,word ptr [BX + -0x26] (0000_2B61 / 0x2B61)
    AX = UInt16[DS, (ushort)(BX - 0x26)];
    CheckExternalEvents(cs1, 0x2B67);
    // MOV word ptr [BP + -0x28],AX (0000_2B64 / 0x2B64)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x2B6A);
    // MOV BX,word ptr [BP + -0x4c] (0000_2B67 / 0x2B67)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2B6C);
    // SHL BX,0x1 (0000_2B6A / 0x2B6A)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B6E);
    // ADD BX,BP (0000_2B6C / 0x2B6C)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B71);
    // MOV AX,word ptr [BX + -0x26] (0000_2B6E / 0x2B6E)
    AX = UInt16[DS, (ushort)(BX - 0x26)];
    CheckExternalEvents(cs1, 0x2B74);
    // MOV BX,word ptr [BP + -0x46] (0000_2B71 / 0x2B71)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2B76);
    // SHL BX,0x1 (0000_2B74 / 0x2B74)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B78);
    // ADD BX,BP (0000_2B76 / 0x2B76)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B7B);
    // MOV word ptr [BX + -0x26],AX (0000_2B78 / 0x2B78)
    UInt16[DS, (ushort)(BX - 0x26)] = AX;
    CheckExternalEvents(cs1, 0x2B7E);
    // MOV BX,word ptr [BP + -0x4c] (0000_2B7B / 0x2B7B)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2B80);
    // SHL BX,0x1 (0000_2B7E / 0x2B7E)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B82);
    // ADD BX,BP (0000_2B80 / 0x2B80)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B85);
    // MOV AX,word ptr [BP + -0x28] (0000_2B82 / 0x2B82)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x2B88);
    // MOV word ptr [BX + -0x26],AX (0000_2B85 / 0x2B85)
    UInt16[DS, (ushort)(BX - 0x26)] = AX;
    CheckExternalEvents(cs1, 0x2B8B);
    // MOV word ptr [BP + -0x28],DI (0000_2B88 / 0x2B88)
    UInt16[SS, (ushort)(BP - 0x28)] = DI;
    CheckExternalEvents(cs1, 0x2B8E);
    // MOV BX,word ptr [BP + -0x46] (0000_2B8B / 0x2B8B)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2B90);
    // SHL BX,0x1 (0000_2B8E / 0x2B8E)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B92);
    // ADD BX,BP (0000_2B90 / 0x2B90)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B95);
    // MOV word ptr [BX + -0x3a],SI (0000_2B92 / 0x2B92)
    UInt16[DS, (ushort)(BX - 0x3A)] = SI;
    CheckExternalEvents(cs1, 0x2B98);
    // MOV BX,word ptr [BP + -0x4c] (0000_2B95 / 0x2B95)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2B9A);
    // SHL BX,0x1 (0000_2B98 / 0x2B98)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2B9C);
    // ADD BX,BP (0000_2B9A / 0x2B9A)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2B9F);
    // MOV AX,word ptr [BP + -0x28] (0000_2B9C / 0x2B9C)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x2BA2);
    // MOV word ptr [BX + -0x3a],AX (0000_2B9F / 0x2B9F)
    UInt16[DS, (ushort)(BX - 0x3A)] = AX;
    CheckExternalEvents(cs1, 0x2BA5);
    // MOV BX,word ptr [BP + -0x46] (0000_2BA2 / 0x2BA2)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2BA7);
    // ADD BX,BP (0000_2BA5 / 0x2BA5)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BAA);
    // MOV AL,byte ptr [BX + -0x5a] (0000_2BA7 / 0x2BA7)
    AL = UInt8[DS, (ushort)(BX - 0x5A)];
    CheckExternalEvents(cs1, 0x2BAC);
    // SUB AH,AH (0000_2BAA / 0x2BAA)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x2BAF);
    // MOV word ptr [BP + -0x28],AX (0000_2BAC / 0x2BAC)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x2BB2);
    // MOV BX,word ptr [BP + -0x4c] (0000_2BAF / 0x2BAF)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2BB4);
    // ADD BX,BP (0000_2BB2 / 0x2BB2)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BB7);
    // MOV AL,byte ptr [BX + -0x5a] (0000_2BB4 / 0x2BB4)
    AL = UInt8[DS, (ushort)(BX - 0x5A)];
    CheckExternalEvents(cs1, 0x2BBA);
    // MOV BX,word ptr [BP + -0x46] (0000_2BB7 / 0x2BB7)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2BBC);
    // ADD BX,BP (0000_2BBA / 0x2BBA)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BBF);
    // MOV byte ptr [BX + -0x5a],AL (0000_2BBC / 0x2BBC)
    UInt8[DS, (ushort)(BX - 0x5A)] = AL;
    CheckExternalEvents(cs1, 0x2BC2);
    // MOV BX,word ptr [BP + -0x4c] (0000_2BBF / 0x2BBF)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2BC4);
    // ADD BX,BP (0000_2BC2 / 0x2BC2)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BC7);
    // MOV AL,byte ptr [BP + -0x28] (0000_2BC4 / 0x2BC4)
    AL = UInt8[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x2BCA);
    // MOV byte ptr [BX + -0x5a],AL (0000_2BC7 / 0x2BC7)
    UInt8[DS, (ushort)(BX - 0x5A)] = AL;
    CheckExternalEvents(cs1, 0x2BCD);
    // MOV BX,word ptr [BP + -0x46] (0000_2BCA / 0x2BCA)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2BCF);
    // ADD BX,BP (0000_2BCD / 0x2BCD)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BD2);
    // MOV AL,byte ptr [BX + -0x14] (0000_2BCF / 0x2BCF)
    AL = UInt8[DS, (ushort)(BX - 0x14)];
    CheckExternalEvents(cs1, 0x2BD5);
    // MOV word ptr [BP + -0x28],AX (0000_2BD2 / 0x2BD2)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs1, 0x2BD8);
    // MOV BX,word ptr [BP + -0x4c] (0000_2BD5 / 0x2BD5)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2BDA);
    // ADD BX,BP (0000_2BD8 / 0x2BD8)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BDD);
    // MOV AL,byte ptr [BX + -0x14] (0000_2BDA / 0x2BDA)
    AL = UInt8[DS, (ushort)(BX - 0x14)];
    CheckExternalEvents(cs1, 0x2BE0);
    // MOV BX,word ptr [BP + -0x46] (0000_2BDD / 0x2BDD)
    BX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2BE2);
    // ADD BX,BP (0000_2BE0 / 0x2BE0)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BE5);
    // MOV byte ptr [BX + -0x14],AL (0000_2BE2 / 0x2BE2)
    UInt8[DS, (ushort)(BX - 0x14)] = AL;
    CheckExternalEvents(cs1, 0x2BE8);
    // MOV BX,word ptr [BP + -0x4c] (0000_2BE5 / 0x2BE5)
    BX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2BEA);
    // ADD BX,BP (0000_2BE8 / 0x2BE8)
    // BX += BP;
    BX = Alu.Add16(BX, BP);
    CheckExternalEvents(cs1, 0x2BED);
    // MOV AL,byte ptr [BP + -0x28] (0000_2BEA / 0x2BEA)
    AL = UInt8[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs1, 0x2BF0);
    // MOV byte ptr [BX + -0x14],AL (0000_2BED / 0x2BED)
    UInt8[DS, (ushort)(BX - 0x14)] = AL;
    CheckExternalEvents(cs1, 0x2BF3);
    // JMP 0x0000:2b34 (0000_2BF0 / 0x2BF0)
    goto label_0000_2B34_02B34;
    label_0000_2BF3_02BF3:
    CheckExternalEvents(cs1, 0x2BF6);
    // INC word ptr [BP + -0x4c] (0000_2BF3 / 0x2BF3)
    UInt16[SS, (ushort)(BP - 0x4C)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x4C)]);
    label_0000_2BF6_02BF6:
    CheckExternalEvents(cs1, 0x2BF9);
    // MOV AX,word ptr [BP + -0x6] (0000_2BF6 / 0x2BF6)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2BFC);
    // CMP word ptr [BP + -0x4c],AX (0000_2BF9 / 0x2BF9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4C)], AX);
    CheckExternalEvents(cs1, 0x2BFE);
    // JGE 0x0000:2c08 (0000_2BFC / 0x2BFC)
    if(SignFlag == OverflowFlag) {
      goto label_0000_2C08_02C08;
    }
    CheckExternalEvents(cs1, 0x2C01);
    // MOV AX,word ptr [BP + -0x4c] (0000_2BFE / 0x2BFE)
    AX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2C02);
    // INC AX (0000_2C01 / 0x2C01)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0x2C05);
    // MOV word ptr [BP + -0x46],AX (0000_2C02 / 0x2C02)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2C08);
    // JMP 0x0000:2b37 (0000_2C05 / 0x2C05)
    goto label_0000_2B37_02B37;
    label_0000_2C08_02C08:
    CheckExternalEvents(cs1, 0x2C0D);
    // MOV word ptr [BP + -0x4c],0x0 (0000_2C08 / 0x2C08)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x0;
    CheckExternalEvents(cs1, 0x2C0F);
    // JMP 0x0000:2c4b (0000_2C0D / 0x2C0D)
    goto label_0000_2C4B_02C4B;
    label_0000_2C0F_02C0F:
    CheckExternalEvents(cs1, 0x2C12);
    // MOV AX,word ptr [BP + -0x4a] (0000_2C0F / 0x2C0F)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2C15);
    // SUB AX,0x10 (0000_2C12 / 0x2C12)
    // AX -= 0x10;
    AX = Alu.Sub16(AX, 0x10);
    CheckExternalEvents(cs1, 0x2C16);
    // PUSH AX (0000_2C15 / 0x2C15)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2C19);
    // MOV AX,word ptr [BP + -0x46] (0000_2C16 / 0x2C16)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2C1C);
    // SUB AX,0x8 (0000_2C19 / 0x2C19)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    CheckExternalEvents(cs1, 0x2C1D);
    // PUSH AX (0000_2C1C / 0x2C1C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2C20);
    // PUSH word ptr [BP + -0x2] (0000_2C1D / 0x2C1D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x2C23);
    // PUSH word ptr [BP + -0x4] (0000_2C20 / 0x2C20)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x2C25);
    // SUB AX,AX (0000_2C23 / 0x2C23)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x2C28);
    // MOV DX,0xac00 (0000_2C25 / 0x2C25)
    DX = 0xAC00;
    CheckExternalEvents(cs1, 0x2C29);
    // PUSH DX (0000_2C28 / 0x2C28)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x2C2A);
    // PUSH AX (0000_2C29 / 0x2C29)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2C2F);
    // CALLF 0x1000:a267 (0000_2C2A / 0x2C2A)
    FarCall(cs1, 0x2C2F, ghidra_guess_1000_A267_1A267);
    CheckExternalEvents(cs1, 0x2C32);
    // ADD SP,0xc (0000_2C2F / 0x2C2F)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    label_0000_2C32_02C32:
    CheckExternalEvents(cs1, 0x2C36);
    // MOV ES,word ptr [0x53a0] (0000_2C32 / 0x2C32)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x2C3C);
    // CMP word ptr ES:[0x4fba],0x0 (0000_2C36 / 0x2C36)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x2C3E);
    // JZ 0x0000:2c48 (0000_2C3C / 0x2C3C)
    if(ZeroFlag) {
      goto label_0000_2C48_02C48;
    }
    CheckExternalEvents(cs1, 0x2C41);
    // LES BX,[BP + -0x4] (0000_2C3E / 0x2C3E)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs1, 0x2C44);
    // MOV AL,byte ptr [BP + -0x44] (0000_2C41 / 0x2C41)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2C48);
    // ADD byte ptr ES:[BX + 0x1],AL (0000_2C44 / 0x2C44)
    UInt8[ES, (ushort)(BX + 0x1)] += AL;
    label_0000_2C48_02C48:
    CheckExternalEvents(cs1, 0x2C4B);
    // INC word ptr [BP + -0x4c] (0000_2C48 / 0x2C48)
    UInt16[SS, (ushort)(BP - 0x4C)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x4C)]);
    label_0000_2C4B_02C4B:
    CheckExternalEvents(cs1, 0x2C4E);
    // MOV AX,word ptr [BP + -0x6] (0000_2C4B / 0x2C4B)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x2C51);
    // CMP word ptr [BP + -0x4c],AX (0000_2C4E / 0x2C4E)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4C)], AX);
    CheckExternalEvents(cs1, 0x2C53);
    // JLE 0x0000:2c56 (0000_2C51 / 0x2C51)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2C56_02C56;
    }
    CheckExternalEvents(cs1, 0x2C56);
    // JMP 0x0000:2d16 (0000_2C53 / 0x2C53)
    goto label_0000_2D16_02D16;
    label_0000_2C56_02C56:
    CheckExternalEvents(cs1, 0x2C59);
    // MOV SI,word ptr [BP + -0x4c] (0000_2C56 / 0x2C56)
    SI = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2C5C);
    // MOV BL,byte ptr [BP + SI + -0x5a] (0000_2C59 / 0x2C59)
    BL = UInt8[SS, (ushort)(BP + SI - 0x5A)];
    CheckExternalEvents(cs1, 0x2C5E);
    // SUB BH,BH (0000_2C5C / 0x2C5C)
    BH -= BH;
    CheckExternalEvents(cs1, 0x2C60);
    // SHL BX,0x1 (0000_2C5E / 0x2C5E)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x2C62);
    // SHL BX,0x1 (0000_2C60 / 0x2C60)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0x2C66);
    // MOV ES,word ptr [0x539e] (0000_2C62 / 0x2C62)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs1, 0x2C6B);
    // MOV AX,word ptr ES:[BX + 0x39fa] (0000_2C66 / 0x2C66)
    AX = UInt16[ES, (ushort)(BX + 0x39FA)];
    CheckExternalEvents(cs1, 0x2C70);
    // MOV DX,word ptr ES:[BX + 0x39fc] (0000_2C6B / 0x2C6B)
    DX = UInt16[ES, (ushort)(BX + 0x39FC)];
    CheckExternalEvents(cs1, 0x2C73);
    // MOV word ptr [BP + -0x4],AX (0000_2C70 / 0x2C70)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x2C76);
    // MOV word ptr [BP + -0x2],DX (0000_2C73 / 0x2C73)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs1, 0x2C78);
    // SHL SI,0x1 (0000_2C76 / 0x2C76)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x2C7B);
    // MOV AX,word ptr [BP + SI + -0x26] (0000_2C78 / 0x2C78)
    AX = UInt16[SS, (ushort)(BP + SI - 0x26)];
    CheckExternalEvents(cs1, 0x2C7E);
    // MOV word ptr [BP + -0x46],AX (0000_2C7B / 0x2C7B)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2C81);
    // MOV SI,word ptr [BP + -0x4c] (0000_2C7E / 0x2C7E)
    SI = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2C83);
    // SHL SI,0x1 (0000_2C81 / 0x2C81)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0x2C86);
    // MOV AX,word ptr [BP + SI + -0x3a] (0000_2C83 / 0x2C83)
    AX = UInt16[SS, (ushort)(BP + SI - 0x3A)];
    CheckExternalEvents(cs1, 0x2C89);
    // MOV word ptr [BP + -0x4a],AX (0000_2C86 / 0x2C86)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs1, 0x2C8C);
    // MOV SI,word ptr [BP + -0x4c] (0000_2C89 / 0x2C89)
    SI = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2C8F);
    // MOV AL,byte ptr [BP + SI + -0x14] (0000_2C8C / 0x2C8C)
    AL = UInt8[SS, (ushort)(BP + SI - 0x14)];
    CheckExternalEvents(cs1, 0x2C91);
    // SUB AH,AH (0000_2C8F / 0x2C8F)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0x2C94);
    // MOV word ptr [BP + -0x44],AX (0000_2C91 / 0x2C91)
    UInt16[SS, (ushort)(BP - 0x44)] = AX;
    CheckExternalEvents(cs1, 0x2C98);
    // MOV ES,word ptr [0x53a0] (0000_2C94 / 0x2C94)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x2C9E);
    // CMP word ptr ES:[0x4fba],0x0 (0000_2C98 / 0x2C98)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x2CA0);
    // JZ 0x0000:2caa (0000_2C9E / 0x2C9E)
    if(ZeroFlag) {
      goto label_0000_2CAA_02CAA;
    }
    CheckExternalEvents(cs1, 0x2CA3);
    // LES BX,[BP + -0x4] (0000_2CA0 / 0x2CA0)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs1, 0x2CA6);
    // MOV AL,byte ptr [BP + -0x44] (0000_2CA3 / 0x2CA3)
    AL = UInt8[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2CAA);
    // SUB byte ptr ES:[BX + 0x1],AL (0000_2CA6 / 0x2CA6)
    // UInt8[ES, (ushort)(BX + 0x1)] -= AL;
    UInt8[ES, (ushort)(BX + 0x1)] = Alu.Sub8(UInt8[ES, (ushort)(BX + 0x1)], AL);
    label_0000_2CAA_02CAA:
    CheckExternalEvents(cs1, 0x2CAE);
    // MOV ES,word ptr [0x53a0] (0000_2CAA / 0x2CAA)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x2CB4);
    // CMP word ptr ES:[0x4fba],0x2 (0000_2CAE / 0x2CAE)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0x2CB6);
    // JNZ 0x0000:2cb9 (0000_2CB4 / 0x2CB4)
    if(!ZeroFlag) {
      goto label_0000_2CB9_02CB9;
    }
    CheckExternalEvents(cs1, 0x2CB9);
    // JMP 0x0000:2c0f (0000_2CB6 / 0x2CB6)
    goto label_0000_2C0F_02C0F;
    label_0000_2CB9_02CB9:
    CheckExternalEvents(cs1, 0x2CBF);
    // CMP word ptr ES:[0x4fba],0x0 (0000_2CB9 / 0x2CB9)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x2CC1);
    // JNZ 0x0000:2ce4 (0000_2CBF / 0x2CBF)
    if(!ZeroFlag) {
      goto label_0000_2CE4_02CE4;
    }
    CheckExternalEvents(cs1, 0x2CC5);
    // CMP word ptr [BP + -0x44],0x0 (0000_2CC1 / 0x2CC1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x44)], 0x0);
    CheckExternalEvents(cs1, 0x2CC7);
    // JZ 0x0000:2ce4 (0000_2CC5 / 0x2CC5)
    if(ZeroFlag) {
      goto label_0000_2CE4_02CE4;
    }
    CheckExternalEvents(cs1, 0x2CCB);
    // MOV ES,word ptr [0x53a2] (0000_2CC7 / 0x2CC7)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs1, 0x2CCE);
    // MOV AX,word ptr [BP + -0x4a] (0000_2CCB / 0x2CCB)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2CD1);
    // SUB AX,word ptr [BP + -0x44] (0000_2CCE / 0x2CCE)
    AX -= UInt16[SS, (ushort)(BP - 0x44)];
    CheckExternalEvents(cs1, 0x2CD4);
    // ADD AX,0x8 (0000_2CD1 / 0x2CD1)
    // AX += 0x8;
    AX = Alu.Add16(AX, 0x8);
    CheckExternalEvents(cs1, 0x2CD8);
    // MOV ES:[0xb780],AX (0000_2CD4 / 0x2CD4)
    UInt16[ES, 0xB780] = AX;
    CheckExternalEvents(cs1, 0x2CDB);
    // CMP AX,0xc8 (0000_2CD8 / 0x2CD8)
    Alu.Sub16(AX, 0xC8);
    CheckExternalEvents(cs1, 0x2CDD);
    // JLE 0x0000:2ce4 (0000_2CDB / 0x2CDB)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2CE4_02CE4;
    }
    CheckExternalEvents(cs1, 0x2CE4);
    // MOV word ptr ES:[0xb780],0xc8 (0000_2CDD / 0x2CDD)
    UInt16[ES, 0xB780] = 0xC8;
    label_0000_2CE4_02CE4:
    CheckExternalEvents(cs1, 0x2CE7);
    // MOV AX,word ptr [BP + -0x4a] (0000_2CE4 / 0x2CE4)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2CEA);
    // SUB AX,0x10 (0000_2CE7 / 0x2CE7)
    // AX -= 0x10;
    AX = Alu.Sub16(AX, 0x10);
    CheckExternalEvents(cs1, 0x2CEB);
    // PUSH AX (0000_2CEA / 0x2CEA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2CEE);
    // MOV AX,word ptr [BP + -0x46] (0000_2CEB / 0x2CEB)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2CF1);
    // SUB AX,0x8 (0000_2CEE / 0x2CEE)
    // AX -= 0x8;
    AX = Alu.Sub16(AX, 0x8);
    CheckExternalEvents(cs1, 0x2CF2);
    // PUSH AX (0000_2CF1 / 0x2CF1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2CF5);
    // PUSH word ptr [BP + -0x2] (0000_2CF2 / 0x2CF2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x2CF8);
    // PUSH word ptr [BP + -0x4] (0000_2CF5 / 0x2CF5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x2CFB);
    // MOV AX,0x244b (0000_2CF8 / 0x2CF8)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0x2CFE);
    // MOV DX,0x1ddc (0000_2CFB / 0x2CFB)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x2CFF);
    // PUSH DX (0000_2CFE / 0x2CFE)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x2D00);
    // PUSH AX (0000_2CFF / 0x2CFF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2D05);
    // CALLF 0x1000:c7db (0000_2D00 / 0x2D00)
    FarCall(cs1, 0x2D05, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs1, 0x2D08);
    // ADD SP,0xc (0000_2D05 / 0x2D05)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs1, 0x2D0C);
    // MOV ES,word ptr [0x53a2] (0000_2D08 / 0x2D08)
    ES = UInt16[DS, 0x53A2];
    CheckExternalEvents(cs1, 0x2D13);
    // MOV word ptr ES:[0xb780],0xc8 (0000_2D0C / 0x2D0C)
    UInt16[ES, 0xB780] = 0xC8;
    CheckExternalEvents(cs1, 0x2D16);
    // JMP 0x0000:2c32 (0000_2D13 / 0x2D13)
    goto label_0000_2C32_02C32;
    label_0000_2D16_02D16:
    CheckExternalEvents(cs1, 0x2D1A);
    // MOV ES,word ptr [0x53b0] (0000_2D16 / 0x2D16)
    ES = UInt16[DS, 0x53B0];
    CheckExternalEvents(cs1, 0x2D20);
    // CMP word ptr ES:[0x398e],0x0 (0000_2D1A / 0x2D1A)
    Alu.Sub16(UInt16[ES, 0x398E], 0x0);
    CheckExternalEvents(cs1, 0x2D22);
    // JNZ 0x0000:2d25 (0000_2D20 / 0x2D20)
    if(!ZeroFlag) {
      goto label_0000_2D25_02D25;
    }
    CheckExternalEvents(cs1, 0x2D25);
    // JMP 0x0000:2e2c (0000_2D22 / 0x2D22)
    goto label_0000_2E2C_02E2C;
    label_0000_2D25_02D25:
    CheckExternalEvents(cs1, 0x2D2A);
    // MOV word ptr [BP + -0x4c],0x0 (0000_2D25 / 0x2D25)
    UInt16[SS, (ushort)(BP - 0x4C)] = 0x0;
    CheckExternalEvents(cs1, 0x2D2C);
    // JMP 0x0000:2d5a (0000_2D2A / 0x2D2A)
    goto label_0000_2D5A_02D5A;
    label_0000_2D2C_02D2C:
    CheckExternalEvents(cs1, 0x2D2F);
    // MOV AX,word ptr [BP + -0x4a] (0000_2D2C / 0x2D2C)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2D31);
    // MOV CL,0x3 (0000_2D2F / 0x2D2F)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x2D33);
    // SHL AX,CL (0000_2D31 / 0x2D31)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs1, 0x2D34);
    // PUSH AX (0000_2D33 / 0x2D33)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2D37);
    // MOV AX,word ptr [BP + -0x46] (0000_2D34 / 0x2D34)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2D39);
    // SHL AX,CL (0000_2D37 / 0x2D37)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs1, 0x2D3A);
    // PUSH AX (0000_2D39 / 0x2D39)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2D3E);
    // MOV ES,word ptr [0x539e] (0000_2D3A / 0x2D3A)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs1, 0x2D43);
    // PUSH word ptr ES:[0x3c44] (0000_2D3E / 0x2D3E)
    Stack.Push16(UInt16[ES, 0x3C44]);
    CheckExternalEvents(cs1, 0x2D48);
    // PUSH word ptr ES:[0x3c42] (0000_2D43 / 0x2D43)
    Stack.Push16(UInt16[ES, 0x3C42]);
    CheckExternalEvents(cs1, 0x2D4A);
    // SUB AX,AX (0000_2D48 / 0x2D48)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x2D4D);
    // MOV DX,0xac00 (0000_2D4A / 0x2D4A)
    DX = 0xAC00;
    CheckExternalEvents(cs1, 0x2D4E);
    // PUSH DX (0000_2D4D / 0x2D4D)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x2D4F);
    // PUSH AX (0000_2D4E / 0x2D4E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2D54);
    // CALLF 0x1000:a267 (0000_2D4F / 0x2D4F)
    FarCall(cs1, 0x2D54, ghidra_guess_1000_A267_1A267);
    label_0000_2D54_02D54:
    CheckExternalEvents(cs1, 0x2D57);
    // ADD SP,0xc (0000_2D54 / 0x2D54)
    SP += 0xC;
    label_0000_2D57_02D57:
    CheckExternalEvents(cs1, 0x2D5A);
    // INC word ptr [BP + -0x4c] (0000_2D57 / 0x2D57)
    UInt16[SS, (ushort)(BP - 0x4C)]++;
    label_0000_2D5A_02D5A:
    CheckExternalEvents(cs1, 0x2D5E);
    // CMP word ptr [BP + -0x4c],0x4 (0000_2D5A / 0x2D5A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4C)], 0x4);
    CheckExternalEvents(cs1, 0x2D60);
    // JL 0x0000:2d63 (0000_2D5E / 0x2D5E)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2D63_02D63;
    }
    CheckExternalEvents(cs1, 0x2D63);
    // JMP 0x0000:2e2c (0000_2D60 / 0x2D60)
    goto label_0000_2E2C_02E2C;
    label_0000_2D63_02D63:
    CheckExternalEvents(cs1, 0x2D66);
    // MOV AX,word ptr [BP + -0x4c] (0000_2D63 / 0x2D63)
    AX = UInt16[SS, (ushort)(BP - 0x4C)];
    CheckExternalEvents(cs1, 0x2D68);
    // SHL AX,0x1 (0000_2D66 / 0x2D66)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0x2D6A);
    // SHL AX,0x1 (0000_2D68 / 0x2D68)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0x2D6D);
    // ADD AX,0xd13 (0000_2D6A / 0x2D6A)
    // AX += 0xD13;
    AX = Alu.Add16(AX, 0xD13);
    CheckExternalEvents(cs1, 0x2D70);
    // MOV word ptr [BP + -0x46],AX (0000_2D6D / 0x2D6D)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2D75);
    // MOV word ptr [BP + -0x4a],0x702c (0000_2D70 / 0x2D70)
    UInt16[SS, (ushort)(BP - 0x4A)] = 0x702C;
    CheckExternalEvents(cs1, 0x2D79);
    // MOV ES,word ptr [0x538c] (0000_2D75 / 0x2D75)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2D7E);
    // SUB AX,word ptr ES:[0xa44b] (0000_2D79 / 0x2D79)
    AX -= UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x2D81);
    // ADD AX,0x1a (0000_2D7E / 0x2D7E)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs1, 0x2D84);
    // MOV word ptr [BP + -0x46],AX (0000_2D81 / 0x2D81)
    UInt16[SS, (ushort)(BP - 0x46)] = AX;
    CheckExternalEvents(cs1, 0x2D87);
    // MOV AX,0x702c (0000_2D84 / 0x2D84)
    AX = 0x702C;
    CheckExternalEvents(cs1, 0x2D8B);
    // MOV ES,word ptr [0x538e] (0000_2D87 / 0x2D87)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2D90);
    // SUB AX,word ptr ES:[0xa44d] (0000_2D8B / 0x2D8B)
    AX -= UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x2D93);
    // ADD AX,0xc (0000_2D90 / 0x2D90)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs1, 0x2D96);
    // MOV word ptr [BP + -0x4a],AX (0000_2D93 / 0x2D93)
    UInt16[SS, (ushort)(BP - 0x4A)] = AX;
    CheckExternalEvents(cs1, 0x2D98);
    // SUB AX,AX (0000_2D96 / 0x2D96)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0x2D9B);
    // MOV word ptr [BP + -0x50],AX (0000_2D98 / 0x2D98)
    UInt16[SS, (ushort)(BP - 0x50)] = AX;
    CheckExternalEvents(cs1, 0x2D9E);
    // MOV word ptr [BP + -0x4e],AX (0000_2D9B / 0x2D9B)
    UInt16[SS, (ushort)(BP - 0x4E)] = AX;
    CheckExternalEvents(cs1, 0x2DA2);
    // CMP word ptr [BP + -0x46],0xd (0000_2D9E / 0x2D9E)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xD);
    CheckExternalEvents(cs1, 0x2DA4);
    // JL 0x0000:2daa (0000_2DA2 / 0x2DA2)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2DAA_02DAA;
    }
    CheckExternalEvents(cs1, 0x2DA8);
    // CMP word ptr [BP + -0x46],0x27 (0000_2DA4 / 0x2DA4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0x27);
    CheckExternalEvents(cs1, 0x2DAA);
    // JLE 0x0000:2daf (0000_2DA8 / 0x2DA8)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2DAF_02DAF;
    }
    label_0000_2DAA_02DAA:
    CheckExternalEvents(cs1, 0x2DAF);
    // MOV word ptr [BP + -0x4e],0x1 (0000_2DAA / 0x2DAA)
    UInt16[SS, (ushort)(BP - 0x4E)] = 0x1;
    label_0000_2DAF_02DAF:
    CheckExternalEvents(cs1, 0x2DB3);
    // CMP word ptr [BP + -0x4a],0x0 (0000_2DAF / 0x2DAF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0x0);
    CheckExternalEvents(cs1, 0x2DB5);
    // JL 0x0000:2dbb (0000_2DB3 / 0x2DB3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2DBB_02DBB;
    }
    CheckExternalEvents(cs1, 0x2DB9);
    // CMP word ptr [BP + -0x4a],0x18 (0000_2DB5 / 0x2DB5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0x18);
    CheckExternalEvents(cs1, 0x2DBB);
    // JLE 0x0000:2dc0 (0000_2DB9 / 0x2DB9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2DC0_02DC0;
    }
    label_0000_2DBB_02DBB:
    CheckExternalEvents(cs1, 0x2DC0);
    // MOV word ptr [BP + -0x50],0x1 (0000_2DBB / 0x2DBB)
    UInt16[SS, (ushort)(BP - 0x50)] = 0x1;
    label_0000_2DC0_02DC0:
    CheckExternalEvents(cs1, 0x2DC4);
    // CMP word ptr [BP + -0x46],-0x73 (0000_2DC0 / 0x2DC0)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xFF8D);
    CheckExternalEvents(cs1, 0x2DC6);
    // JL 0x0000:2d57 (0000_2DC4 / 0x2DC4)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2D57_02D57;
    }
    CheckExternalEvents(cs1, 0x2DCB);
    // CMP word ptr [BP + -0x46],0xa7 (0000_2DC6 / 0x2DC6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x46)], 0xA7);
    CheckExternalEvents(cs1, 0x2DCD);
    // JG 0x0000:2d57 (0000_2DCB / 0x2DCB)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_2D57_02D57;
    }
    CheckExternalEvents(cs1, 0x2DD2);
    // CMP word ptr [BP + -0x4a],0xf080 (0000_2DCD / 0x2DCD)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0xF080);
    CheckExternalEvents(cs1, 0x2DD4);
    // JL 0x0000:2d57 (0000_2DD2 / 0x2DD2)
    if(SignFlag != OverflowFlag) {
      goto label_0000_2D57_02D57;
    }
    CheckExternalEvents(cs1, 0x2DD9);
    // CMP word ptr [BP + -0x4a],0xf98 (0000_2DD4 / 0x2DD4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4A)], 0xF98);
    CheckExternalEvents(cs1, 0x2DDB);
    // JLE 0x0000:2dde (0000_2DD9 / 0x2DD9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_2DDE_02DDE;
    }
    CheckExternalEvents(cs1, 0x2DDE);
    // JMP 0x0000:2d57 (0000_2DDB / 0x2DDB)
    goto label_0000_2D57_02D57;
    label_0000_2DDE_02DDE:
    CheckExternalEvents(cs1, 0x2DE1);
    // MOV AX,word ptr [BP + -0x4e] (0000_2DDE / 0x2DDE)
    AX = UInt16[SS, (ushort)(BP - 0x4E)];
    CheckExternalEvents(cs1, 0x2DE4);
    // ADD AX,word ptr [BP + -0x50] (0000_2DE1 / 0x2DE1)
    // AX += UInt16[SS, (ushort)(BP - 0x50)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x50)]);
    CheckExternalEvents(cs1, 0x2DE6);
    // JZ 0x0000:2de9 (0000_2DE4 / 0x2DE4)
    if(ZeroFlag) {
      goto label_0000_2DE9_02DE9;
    }
    CheckExternalEvents(cs1, 0x2DE9);
    // JMP 0x0000:2d57 (0000_2DE6 / 0x2DE6)
    goto label_0000_2D57_02D57;
    label_0000_2DE9_02DE9:
    CheckExternalEvents(cs1, 0x2DED);
    // AND word ptr [BP + -0x46],0x7f (0000_2DE9 / 0x2DE9)
    UInt16[SS, (ushort)(BP - 0x46)] &= 0x7F;
    CheckExternalEvents(cs1, 0x2DF1);
    // AND word ptr [BP + -0x4a],0x7f (0000_2DED / 0x2DED)
    // UInt16[SS, (ushort)(BP - 0x4A)] &= 0x7F;
    UInt16[SS, (ushort)(BP - 0x4A)] = Alu.And16(UInt16[SS, (ushort)(BP - 0x4A)], 0x7F);
    CheckExternalEvents(cs1, 0x2DF5);
    // MOV ES,word ptr [0x53a0] (0000_2DF1 / 0x2DF1)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs1, 0x2DFB);
    // CMP word ptr ES:[0x4fba],0x2 (0000_2DF5 / 0x2DF5)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0x2DFD);
    // JNZ 0x0000:2e00 (0000_2DFB / 0x2DFB)
    if(!ZeroFlag) {
      goto label_0000_2E00_02E00;
    }
    CheckExternalEvents(cs1, 0x2E00);
    // JMP 0x0000:2d2c (0000_2DFD / 0x2DFD)
    goto label_0000_2D2C_02D2C;
    label_0000_2E00_02E00:
    CheckExternalEvents(cs1, 0x2E03);
    // MOV AX,word ptr [BP + -0x4a] (0000_2E00 / 0x2E00)
    AX = UInt16[SS, (ushort)(BP - 0x4A)];
    CheckExternalEvents(cs1, 0x2E05);
    // MOV CL,0x3 (0000_2E03 / 0x2E03)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x2E07);
    // SHL AX,CL (0000_2E05 / 0x2E05)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs1, 0x2E08);
    // PUSH AX (0000_2E07 / 0x2E07)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2E0B);
    // MOV AX,word ptr [BP + -0x46] (0000_2E08 / 0x2E08)
    AX = UInt16[SS, (ushort)(BP - 0x46)];
    CheckExternalEvents(cs1, 0x2E0D);
    // SHL AX,CL (0000_2E0B / 0x2E0B)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs1, 0x2E0E);
    // PUSH AX (0000_2E0D / 0x2E0D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2E12);
    // MOV ES,word ptr [0x539e] (0000_2E0E / 0x2E0E)
    ES = UInt16[DS, 0x539E];
    CheckExternalEvents(cs1, 0x2E17);
    // PUSH word ptr ES:[0x3c44] (0000_2E12 / 0x2E12)
    Stack.Push16(UInt16[ES, 0x3C44]);
    CheckExternalEvents(cs1, 0x2E1C);
    // PUSH word ptr ES:[0x3c42] (0000_2E17 / 0x2E17)
    Stack.Push16(UInt16[ES, 0x3C42]);
    CheckExternalEvents(cs1, 0x2E1F);
    // MOV AX,0x244b (0000_2E1C / 0x2E1C)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0x2E22);
    // MOV DX,0x1ddc (0000_2E1F / 0x2E1F)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x2E23);
    // PUSH DX (0000_2E22 / 0x2E22)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x2E24);
    // PUSH AX (0000_2E23 / 0x2E23)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x2E29);
    // CALLF 0x1000:c7db (0000_2E24 / 0x2E24)
    FarCall(cs1, 0x2E29, unknown_19EF_28EB_1C7DB);
    CheckExternalEvents(cs1, 0x2E2C);
    // JMP 0x0000:2d54 (0000_2E29 / 0x2E29)
    goto label_0000_2D54_02D54;
    label_0000_2E2C_02E2C:
    CheckExternalEvents(cs1, 0x2E2D);
    // POP SI (0000_2E2C / 0x2E2C)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x2E2E);
    // POP DI (0000_2E2D / 0x2E2D)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x2E30);
    // MOV SP,BP (0000_2E2E / 0x2E2E)
    SP = BP;
    CheckExternalEvents(cs1, 0x2E31);
    // POP BP (0000_2E30 / 0x2E30)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x2E32);
    // RETF  (0000_2E31 / 0x2E31)
    return FarRet();
  }
  
  public virtual Action unknown_0170_1732_02E32(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_1732_02E32:
    CheckExternalEvents(cs2, 0x1733);
    // PUSH BP (0170_1732 / 0x2E32)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x1735);
    // MOV BP,SP (0170_1733 / 0x2E33)
    BP = SP;
    CheckExternalEvents(cs2, 0x1738);
    // MOV AX,0x2 (0170_1735 / 0x2E35)
    AX = 0x2;
    CheckExternalEvents(cs2, 0x173D);
    // CALLF 0x1000:cecc (0170_1738 / 0x2E38)
    FarCall(cs2, 0x173D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x173E);
    // PUSH SI (0170_173D / 0x2E3D)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x1743);
    // MOV word ptr [BP + -0x2],0xffff (0170_173E / 0x2E3E)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xFFFF;
    CheckExternalEvents(cs2, 0x1745);
    // JMP 0x0000:2e98 (0170_1743 / 0x2E43)
    goto label_0170_1798_02E98;
    label_0170_1745_02E45:
    CheckExternalEvents(cs2, 0x1748);
    // CMP AX,0xfffd (0170_1745 / 0x2E45)
    Alu.Sub16(AX, 0xFFFD);
    CheckExternalEvents(cs2, 0x174A);
    // JZ 0x0000:2e76 (0170_1748 / 0x2E48)
    if(ZeroFlag) {
      goto label_0170_1776_02E76;
    }
    CheckExternalEvents(cs2, 0x174D);
    // CMP AX,0xfffe (0170_174A / 0x2E4A)
    Alu.Sub16(AX, 0xFFFE);
    CheckExternalEvents(cs2, 0x174F);
    // JZ 0x0000:2e61 (0170_174D / 0x2E4D)
    if(ZeroFlag) {
      goto label_0170_1761_02E61;
    }
    CheckExternalEvents(cs2, 0x1752);
    // CMP AX,0xffff (0170_174F / 0x2E4F)
    Alu.Sub16(AX, 0xFFFF);
    CheckExternalEvents(cs2, 0x1754);
    // JNZ 0x0000:2e98 (0170_1752 / 0x2E52)
    if(!ZeroFlag) {
      goto label_0170_1798_02E98;
    }
    CheckExternalEvents(cs2, 0x1757);
    // MOV BX,word ptr [BP + 0x6] (0170_1754 / 0x2E54)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x1759);
    // SHL BX,0x1 (0170_1757 / 0x2E57)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x175B);
    // SHL BX,0x1 (0170_1759 / 0x2E59)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x175F);
    // DEC word ptr [BX + 0x1f6] (0170_175B / 0x2E5B)
    UInt16[DS, (ushort)(BX + 0x1F6)] = Alu.Dec16(UInt16[DS, (ushort)(BX + 0x1F6)]);
    CheckExternalEvents(cs2, 0x1761);
    // JMP 0x0000:2e98 (0170_175F / 0x2E5F)
    goto label_0170_1798_02E98;
    label_0170_1761_02E61:
    CheckExternalEvents(cs2, 0x1764);
    // MOV SI,word ptr [BP + 0x6] (0170_1761 / 0x2E61)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x1766);
    // MOV CL,0x2 (0170_1764 / 0x2E64)
    CL = 0x2;
    CheckExternalEvents(cs2, 0x1768);
    // SHL SI,CL (0170_1766 / 0x2E66)
    SI <<= CL;
    CheckExternalEvents(cs2, 0x176C);
    // ADD SI,0x1f6 (0170_1768 / 0x2E68)
    // SI += 0x1F6;
    SI = Alu.Add16(SI, 0x1F6);
    CheckExternalEvents(cs2, 0x176E);
    // LES BX,[SI] (0170_176C / 0x2E6C)
    BX = UInt16[DS, (ushort)(SI)];
    ES = UInt16[DS, (ushort)(SI + 2)];
    CheckExternalEvents(cs2, 0x1771);
    // MOV AL,byte ptr ES:[BX] (0170_176E / 0x2E6E)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs2, 0x1772);
    // CBW  (0170_1771 / 0x2E71)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x1774);
    // SUB word ptr [SI],AX (0170_1772 / 0x2E72)
    // UInt16[DS, (ushort)(SI)] -= AX;
    UInt16[DS, (ushort)(SI)] = Alu.Sub16(UInt16[DS, (ushort)(SI)], AX);
    CheckExternalEvents(cs2, 0x1776);
    // JMP 0x0000:2e98 (0170_1774 / 0x2E74)
    goto label_0170_1798_02E98;
    label_0170_1776_02E76:
    CheckExternalEvents(cs2, 0x1779);
    // MOV BX,word ptr [BP + 0x6] (0170_1776 / 0x2E76)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x177B);
    // SHL BX,0x1 (0170_1779 / 0x2E79)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x177D);
    // SHL BX,0x1 (0170_177B / 0x2E7B)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x1781);
    // MOV SI,word ptr [BX + 0x1f6] (0170_177D / 0x2E7D)
    SI = UInt16[DS, (ushort)(BX + 0x1F6)];
    CheckExternalEvents(cs2, 0x1785);
    // INC word ptr [BX + 0x1f6] (0170_1781 / 0x2E81)
    UInt16[DS, (ushort)(BX + 0x1F6)] = Alu.Inc16(UInt16[DS, (ushort)(BX + 0x1F6)]);
    CheckExternalEvents(cs2, 0x1789);
    // MOV ES,word ptr [BX + 0x1f8] (0170_1785 / 0x2E85)
    ES = UInt16[DS, (ushort)(BX + 0x1F8)];
    CheckExternalEvents(cs2, 0x178C);
    // MOV AL,byte ptr ES:[SI] (0170_1789 / 0x2E89)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs2, 0x178F);
    // MOV BX,word ptr [BP + 0x6] (0170_178C / 0x2E8C)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x1793);
    // MOV ES,word ptr [0x53be] (0170_178F / 0x2E8F)
    ES = UInt16[DS, 0x53BE];
    CheckExternalEvents(cs2, 0x1798);
    // MOV byte ptr ES:[BX + 0x396c],AL (0170_1793 / 0x2E93)
    UInt8[ES, (ushort)(BX + 0x396C)] = AL;
    label_0170_1798_02E98:
    CheckExternalEvents(cs2, 0x179B);
    // MOV BX,word ptr [BP + 0x6] (0170_1798 / 0x2E98)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x179D);
    // SHL BX,0x1 (0170_179B / 0x2E9B)
    BX <<= 0x1;
    CheckExternalEvents(cs2, 0x179F);
    // SHL BX,0x1 (0170_179D / 0x2E9D)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs2, 0x17A3);
    // MOV SI,word ptr [BX + 0x1f6] (0170_179F / 0x2E9F)
    SI = UInt16[DS, (ushort)(BX + 0x1F6)];
    CheckExternalEvents(cs2, 0x17A7);
    // INC word ptr [BX + 0x1f6] (0170_17A3 / 0x2EA3)
    UInt16[DS, (ushort)(BX + 0x1F6)] = Alu.Inc16(UInt16[DS, (ushort)(BX + 0x1F6)]);
    CheckExternalEvents(cs2, 0x17AB);
    // MOV ES,word ptr [BX + 0x1f8] (0170_17A7 / 0x2EA7)
    ES = UInt16[DS, (ushort)(BX + 0x1F8)];
    CheckExternalEvents(cs2, 0x17AE);
    // MOV AL,byte ptr ES:[SI] (0170_17AB / 0x2EAB)
    AL = UInt8[ES, (ushort)(SI)];
    CheckExternalEvents(cs2, 0x17AF);
    // CBW  (0170_17AE / 0x2EAE)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x17B2);
    // MOV word ptr [BP + -0x2],AX (0170_17AF / 0x2EAF)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x17B4);
    // OR AX,AX (0170_17B2 / 0x2EB2)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x17B6);
    // JL 0x0000:2e45 (0170_17B4 / 0x2EB4)
    if(SignFlag != OverflowFlag) {
      goto label_0170_1745_02E45;
    }
    CheckExternalEvents(cs2, 0x17B7);
    // POP SI (0170_17B6 / 0x2EB6)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x17B9);
    // MOV SP,BP (0170_17B7 / 0x2EB7)
    SP = BP;
    CheckExternalEvents(cs2, 0x17BA);
    // POP BP (0170_17B9 / 0x2EB9)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x17BB);
    // RETF  (0170_17BA / 0x2EBA)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_2EBB_02EBB(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_2EBB_02EBB:
    CheckExternalEvents(cs1, 0x2EBC);
    // PUSH BP (0000_2EBB / 0x2EBB)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x2EBE);
    // MOV BP,SP (0000_2EBC / 0x2EBC)
    BP = SP;
    CheckExternalEvents(cs1, 0x2EC0);
    // XOR AX,AX (0000_2EBE / 0x2EBE)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x2EC5);
    // CALLF 0x1000:cecc (0000_2EC0 / 0x2EC0)
    FarCall(cs1, 0x2EC5, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x2EC7);
    // JMP 0x0000:2ecc (0000_2EC5 / 0x2EC5)
    goto label_0000_2ECC_02ECC;
    label_0000_2EC7_02EC7:
    CheckExternalEvents(cs1, 0x2ECC);
    // CALLF 0x1000:b47c (0000_2EC7 / 0x2EC7)
    FarCall(cs1, 0x2ECC, ghidra_guess_1000_B47C_1B47C);
    label_0000_2ECC_02ECC:
    CheckExternalEvents(cs1, 0x2ED0);
    // MOV ES,word ptr [0x538e] (0000_2ECC / 0x2ECC)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2ED4);
    // MOV AX,ES:[0xa44d] (0000_2ED0 / 0x2ED0)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x2ED7);
    // CMP word ptr [BP + 0x8],AX (0000_2ED4 / 0x2ED4)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs1, 0x2ED9);
    // JC 0x0000:2ec7 (0000_2ED7 / 0x2ED7)
    if(CarryFlag) {
      goto label_0000_2EC7_02EC7;
    }
    CheckExternalEvents(cs1, 0x2EDB);
    // JMP 0x0000:2ee0 (0000_2ED9 / 0x2ED9)
    goto label_0000_2EE0_02EE0;
    label_0000_2EDB_02EDB:
    CheckExternalEvents(cs1, 0x2EE0);
    // CALLF 0x1000:b52b (0000_2EDB / 0x2EDB)
    FarCall(cs1, 0x2EE0, unknown_19EF_163B_1B52B);
    label_0000_2EE0_02EE0:
    CheckExternalEvents(cs1, 0x2EE4);
    // MOV ES,word ptr [0x538e] (0000_2EE0 / 0x2EE0)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2EE8);
    // MOV AX,ES:[0xa44d] (0000_2EE4 / 0x2EE4)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x2EEB);
    // CMP word ptr [BP + 0x8],AX (0000_2EE8 / 0x2EE8)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs1, 0x2EED);
    // JA 0x0000:2edb (0000_2EEB / 0x2EEB)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_2EDB_02EDB;
    }
    CheckExternalEvents(cs1, 0x2EEF);
    // JMP 0x0000:2ef4 (0000_2EED / 0x2EED)
    goto label_0000_2EF4_02EF4;
    label_0000_2EEF_02EEF:
    CheckExternalEvents(cs1, 0x2EF4);
    // CALLF 0x1000:b5d3 (0000_2EEF / 0x2EEF)
    FarCall(cs1, 0x2EF4, unknown_19EF_16E3_1B5D3);
    label_0000_2EF4_02EF4:
    CheckExternalEvents(cs1, 0x2EF8);
    // MOV ES,word ptr [0x538c] (0000_2EF4 / 0x2EF4)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2EFC);
    // MOV AX,ES:[0xa44b] (0000_2EF8 / 0x2EF8)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x2EFF);
    // CMP word ptr [BP + 0x6],AX (0000_2EFC / 0x2EFC)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs1, 0x2F01);
    // JC 0x0000:2eef (0000_2EFF / 0x2EFF)
    if(CarryFlag) {
      goto label_0000_2EEF_02EEF;
    }
    CheckExternalEvents(cs1, 0x2F03);
    // JMP 0x0000:2f08 (0000_2F01 / 0x2F01)
    goto label_0000_2F08_02F08;
    label_0000_2F03_02F03:
    CheckExternalEvents(cs1, 0x2F08);
    // CALLF 0x1000:b6b5 (0000_2F03 / 0x2F03)
    FarCall(cs1, 0x2F08, unknown_19EF_17C5_1B6B5);
    label_0000_2F08_02F08:
    CheckExternalEvents(cs1, 0x2F0C);
    // MOV ES,word ptr [0x538c] (0000_2F08 / 0x2F08)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2F10);
    // MOV AX,ES:[0xa44b] (0000_2F0C / 0x2F0C)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x2F13);
    // CMP word ptr [BP + 0x6],AX (0000_2F10 / 0x2F10)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs1, 0x2F15);
    // JA 0x0000:2f03 (0000_2F13 / 0x2F13)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_2F03_02F03;
    }
    CheckExternalEvents(cs1, 0x2F16);
    // POP BP (0000_2F15 / 0x2F15)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x2F17);
    // RETF  (0000_2F16 / 0x2F16)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_2F6F_02F6F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_2F6F_02F6F:
    CheckExternalEvents(cs1, 0x2F70);
    // PUSH BP (0000_2F6F / 0x2F6F)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x2F72);
    // MOV BP,SP (0000_2F70 / 0x2F70)
    BP = SP;
    CheckExternalEvents(cs1, 0x2F74);
    // XOR AX,AX (0000_2F72 / 0x2F72)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x2F79);
    // CALLF 0x1000:cecc (0000_2F74 / 0x2F74)
    FarCall(cs1, 0x2F79, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x2F7B);
    // JMP 0x0000:2f93 (0000_2F79 / 0x2F79)
    goto label_0000_2F93_02F93;
    label_0000_2F7B_02F7B:
    CheckExternalEvents(cs1, 0x2F7F);
    // MOV ES,word ptr [0x538e] (0000_2F7B / 0x2F7B)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2F84);
    // DEC word ptr ES:[0xa44d] (0000_2F7F / 0x2F7F)
    UInt16[ES, 0xA44D] = Alu.Dec16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x2F88);
    // MOV AL,ES:[0xa44d] (0000_2F84 / 0x2F84)
    AL = UInt8[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x2F8A);
    // TEST AL,0x80 (0000_2F88 / 0x2F88)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs1, 0x2F8C);
    // JZ 0x0000:2f93 (0000_2F8A / 0x2F8A)
    if(ZeroFlag) {
      goto label_0000_2F93_02F93;
    }
    CheckExternalEvents(cs1, 0x2F93);
    // AND word ptr ES:[0xa44d],0xf07f (0000_2F8C / 0x2F8C)
    // UInt16[ES, 0xA44D] &= 0xF07F;
    UInt16[ES, 0xA44D] = Alu.And16(UInt16[ES, 0xA44D], 0xF07F);
    label_0000_2F93_02F93:
    CheckExternalEvents(cs1, 0x2F97);
    // MOV ES,word ptr [0x538e] (0000_2F93 / 0x2F93)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2F9A);
    // MOV AX,word ptr [BP + 0x8] (0000_2F97 / 0x2F97)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x2F9F);
    // CMP word ptr ES:[0xa44d],AX (0000_2F9A / 0x2F9A)
    Alu.Sub16(UInt16[ES, 0xA44D], AX);
    CheckExternalEvents(cs1, 0x2FA1);
    // JA 0x0000:2f7b (0000_2F9F / 0x2F9F)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_2F7B_02F7B;
    }
    CheckExternalEvents(cs1, 0x2FA3);
    // JMP 0x0000:2fbb (0000_2FA1 / 0x2FA1)
    goto label_0000_2FBB_02FBB;
    label_0000_2FA3_02FA3:
    CheckExternalEvents(cs1, 0x2FA7);
    // MOV ES,word ptr [0x538e] (0000_2FA3 / 0x2FA3)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2FAC);
    // INC word ptr ES:[0xa44d] (0000_2FA7 / 0x2FA7)
    UInt16[ES, 0xA44D] = Alu.Inc16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0x2FB0);
    // MOV AL,ES:[0xa44d] (0000_2FAC / 0x2FAC)
    AL = UInt8[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x2FB2);
    // TEST AL,0x80 (0000_2FB0 / 0x2FB0)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs1, 0x2FB4);
    // JZ 0x0000:2fbb (0000_2FB2 / 0x2FB2)
    if(ZeroFlag) {
      goto label_0000_2FBB_02FBB;
    }
    CheckExternalEvents(cs1, 0x2FBB);
    // ADD word ptr ES:[0xa44d],0xf80 (0000_2FB4 / 0x2FB4)
    // UInt16[ES, 0xA44D] += 0xF80;
    UInt16[ES, 0xA44D] = Alu.Add16(UInt16[ES, 0xA44D], 0xF80);
    label_0000_2FBB_02FBB:
    CheckExternalEvents(cs1, 0x2FBF);
    // MOV ES,word ptr [0x538e] (0000_2FBB / 0x2FBB)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs1, 0x2FC2);
    // MOV AX,word ptr [BP + 0x8] (0000_2FBF / 0x2FBF)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x2FC7);
    // CMP word ptr ES:[0xa44d],AX (0000_2FC2 / 0x2FC2)
    Alu.Sub16(UInt16[ES, 0xA44D], AX);
    CheckExternalEvents(cs1, 0x2FC9);
    // JC 0x0000:2fa3 (0000_2FC7 / 0x2FC7)
    if(CarryFlag) {
      goto label_0000_2FA3_02FA3;
    }
    CheckExternalEvents(cs1, 0x2FCB);
    // JMP 0x0000:2fe3 (0000_2FC9 / 0x2FC9)
    goto label_0000_2FE3_02FE3;
    label_0000_2FCB_02FCB:
    CheckExternalEvents(cs1, 0x2FCF);
    // MOV ES,word ptr [0x538c] (0000_2FCB / 0x2FCB)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2FD4);
    // DEC word ptr ES:[0xa44b] (0000_2FCF / 0x2FCF)
    UInt16[ES, 0xA44B] = Alu.Dec16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0x2FD8);
    // MOV AL,ES:[0xa44b] (0000_2FD4 / 0x2FD4)
    AL = UInt8[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x2FDA);
    // TEST AL,0x80 (0000_2FD8 / 0x2FD8)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs1, 0x2FDC);
    // JZ 0x0000:2fe3 (0000_2FDA / 0x2FDA)
    if(ZeroFlag) {
      goto label_0000_2FE3_02FE3;
    }
    CheckExternalEvents(cs1, 0x2FE3);
    // AND word ptr ES:[0xa44b],0xf7f (0000_2FDC / 0x2FDC)
    // UInt16[ES, 0xA44B] &= 0xF7F;
    UInt16[ES, 0xA44B] = Alu.And16(UInt16[ES, 0xA44B], 0xF7F);
    label_0000_2FE3_02FE3:
    CheckExternalEvents(cs1, 0x2FE7);
    // MOV ES,word ptr [0x538c] (0000_2FE3 / 0x2FE3)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2FEA);
    // MOV AX,word ptr [BP + 0x6] (0000_2FE7 / 0x2FE7)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x2FEF);
    // CMP word ptr ES:[0xa44b],AX (0000_2FEA / 0x2FEA)
    Alu.Sub16(UInt16[ES, 0xA44B], AX);
    CheckExternalEvents(cs1, 0x2FF1);
    // JA 0x0000:2fcb (0000_2FEF / 0x2FEF)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_2FCB_02FCB;
    }
    CheckExternalEvents(cs1, 0x2FF3);
    // JMP 0x0000:300b (0000_2FF1 / 0x2FF1)
    goto label_0000_300B_0300B;
    label_0000_2FF3_02FF3:
    CheckExternalEvents(cs1, 0x2FF7);
    // MOV ES,word ptr [0x538c] (0000_2FF3 / 0x2FF3)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x2FFC);
    // INC word ptr ES:[0xa44b] (0000_2FF7 / 0x2FF7)
    UInt16[ES, 0xA44B] = Alu.Inc16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0x3000);
    // MOV AL,ES:[0xa44b] (0000_2FFC / 0x2FFC)
    AL = UInt8[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x3002);
    // TEST AL,0x80 (0000_3000 / 0x3000)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs1, 0x3004);
    // JZ 0x0000:300b (0000_3002 / 0x3002)
    if(ZeroFlag) {
      goto label_0000_300B_0300B;
    }
    CheckExternalEvents(cs1, 0x300B);
    // ADD word ptr ES:[0xa44b],0x80 (0000_3004 / 0x3004)
    // UInt16[ES, 0xA44B] += 0x80;
    UInt16[ES, 0xA44B] = Alu.Add16(UInt16[ES, 0xA44B], 0x80);
    label_0000_300B_0300B:
    CheckExternalEvents(cs1, 0x300F);
    // MOV ES,word ptr [0x538c] (0000_300B / 0x300B)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs1, 0x3012);
    // MOV AX,word ptr [BP + 0x6] (0000_300F / 0x300F)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x3017);
    // CMP word ptr ES:[0xa44b],AX (0000_3012 / 0x3012)
    Alu.Sub16(UInt16[ES, 0xA44B], AX);
    CheckExternalEvents(cs1, 0x3019);
    // JC 0x0000:2ff3 (0000_3017 / 0x3017)
    if(CarryFlag) {
      goto label_0000_2FF3_02FF3;
    }
    CheckExternalEvents(cs1, 0x301A);
    // POP BP (0000_3019 / 0x3019)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x301B);
    // RETF  (0000_301A / 0x301A)
    return FarRet();
  }
  
  public virtual Action unknown_0170_191B_0301B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_191B_0301B:
    CheckExternalEvents(cs2, 0x191C);
    // PUSH BP (0170_191B / 0x301B)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x191E);
    // MOV BP,SP (0170_191C / 0x301C)
    BP = SP;
    CheckExternalEvents(cs2, 0x1920);
    // XOR AX,AX (0170_191E / 0x301E)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs2, 0x1925);
    // CALLF 0x1000:cecc (0170_1920 / 0x3020)
    FarCall(cs2, 0x1925, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x1929);
    // CMP word ptr [BP + 0x8],0x0 (0170_1925 / 0x3025)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x192B);
    // JGE 0x0000:306b (0170_1929 / 0x3029)
    if(SignFlag == OverflowFlag) {
      goto label_0170_196B_0306B;
    }
    CheckExternalEvents(cs2, 0x192D);
    // JMP 0x0000:3048 (0170_192B / 0x302B)
    goto label_0170_1948_03048;
    label_0170_192D_0302D:
    CheckExternalEvents(cs2, 0x1931);
    // MOV ES,word ptr [0x538e] (0170_192D / 0x302D)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x1936);
    // DEC word ptr ES:[0xa44d] (0170_1931 / 0x3031)
    UInt16[ES, 0xA44D] = Alu.Dec16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x193A);
    // MOV AL,ES:[0xa44d] (0170_1936 / 0x3036)
    AL = UInt8[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x193C);
    // TEST AL,0x80 (0170_193A / 0x303A)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs2, 0x193E);
    // JZ 0x0000:3045 (0170_193C / 0x303C)
    if(ZeroFlag) {
      goto label_0170_1945_03045;
    }
    CheckExternalEvents(cs2, 0x1945);
    // AND word ptr ES:[0xa44d],0xf07f (0170_193E / 0x303E)
    UInt16[ES, 0xA44D] &= 0xF07F;
    label_0170_1945_03045:
    CheckExternalEvents(cs2, 0x1948);
    // INC word ptr [BP + 0x8] (0170_1945 / 0x3045)
    UInt16[SS, (ushort)(BP + 0x8)]++;
    label_0170_1948_03048:
    CheckExternalEvents(cs2, 0x194C);
    // CMP word ptr [BP + 0x8],0x0 (0170_1948 / 0x3048)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x194E);
    // JNZ 0x0000:302d (0170_194C / 0x304C)
    if(!ZeroFlag) {
      goto label_0170_192D_0302D;
    }
    CheckExternalEvents(cs2, 0x1950);
    // JMP 0x0000:306b (0170_194E / 0x304E)
    goto label_0170_196B_0306B;
    label_0170_1950_03050:
    CheckExternalEvents(cs2, 0x1954);
    // MOV ES,word ptr [0x538e] (0170_1950 / 0x3050)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x1959);
    // INC word ptr ES:[0xa44d] (0170_1954 / 0x3054)
    UInt16[ES, 0xA44D] = Alu.Inc16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x195D);
    // MOV AL,ES:[0xa44d] (0170_1959 / 0x3059)
    AL = UInt8[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x195F);
    // TEST AL,0x80 (0170_195D / 0x305D)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs2, 0x1961);
    // JZ 0x0000:3068 (0170_195F / 0x305F)
    if(ZeroFlag) {
      goto label_0170_1968_03068;
    }
    CheckExternalEvents(cs2, 0x1968);
    // ADD word ptr ES:[0xa44d],0xf80 (0170_1961 / 0x3061)
    UInt16[ES, 0xA44D] += 0xF80;
    label_0170_1968_03068:
    CheckExternalEvents(cs2, 0x196B);
    // DEC word ptr [BP + 0x8] (0170_1968 / 0x3068)
    UInt16[SS, (ushort)(BP + 0x8)]--;
    label_0170_196B_0306B:
    CheckExternalEvents(cs2, 0x196F);
    // CMP word ptr [BP + 0x8],0x0 (0170_196B / 0x306B)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x1971);
    // JNZ 0x0000:3050 (0170_196F / 0x306F)
    if(!ZeroFlag) {
      goto label_0170_1950_03050;
    }
    CheckExternalEvents(cs2, 0x1975);
    // CMP word ptr [BP + 0x6],0x0 (0170_1971 / 0x3071)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x1977);
    // JGE 0x0000:30b7 (0170_1975 / 0x3075)
    if(SignFlag == OverflowFlag) {
      goto label_0170_19B7_030B7;
    }
    CheckExternalEvents(cs2, 0x1979);
    // JMP 0x0000:3094 (0170_1977 / 0x3077)
    goto label_0170_1994_03094;
    label_0170_1979_03079:
    CheckExternalEvents(cs2, 0x197D);
    // MOV ES,word ptr [0x538c] (0170_1979 / 0x3079)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x1982);
    // DEC word ptr ES:[0xa44b] (0170_197D / 0x307D)
    UInt16[ES, 0xA44B] = Alu.Dec16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x1986);
    // MOV AL,ES:[0xa44b] (0170_1982 / 0x3082)
    AL = UInt8[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x1988);
    // TEST AL,0x80 (0170_1986 / 0x3086)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs2, 0x198A);
    // JZ 0x0000:3091 (0170_1988 / 0x3088)
    if(ZeroFlag) {
      goto label_0170_1991_03091;
    }
    CheckExternalEvents(cs2, 0x1991);
    // AND word ptr ES:[0xa44b],0xf7f (0170_198A / 0x308A)
    UInt16[ES, 0xA44B] &= 0xF7F;
    label_0170_1991_03091:
    CheckExternalEvents(cs2, 0x1994);
    // INC word ptr [BP + 0x6] (0170_1991 / 0x3091)
    UInt16[SS, (ushort)(BP + 0x6)]++;
    label_0170_1994_03094:
    CheckExternalEvents(cs2, 0x1998);
    // CMP word ptr [BP + 0x6],0x0 (0170_1994 / 0x3094)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x199A);
    // JNZ 0x0000:3079 (0170_1998 / 0x3098)
    if(!ZeroFlag) {
      goto label_0170_1979_03079;
    }
    CheckExternalEvents(cs2, 0x199C);
    // JMP 0x0000:30b7 (0170_199A / 0x309A)
    goto label_0170_19B7_030B7;
    label_0170_199C_0309C:
    CheckExternalEvents(cs2, 0x19A0);
    // MOV ES,word ptr [0x538c] (0170_199C / 0x309C)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x19A5);
    // INC word ptr ES:[0xa44b] (0170_19A0 / 0x30A0)
    UInt16[ES, 0xA44B] = Alu.Inc16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x19A9);
    // MOV AL,ES:[0xa44b] (0170_19A5 / 0x30A5)
    AL = UInt8[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x19AB);
    // TEST AL,0x80 (0170_19A9 / 0x30A9)
    Alu.And8(AL, 0x80);
    CheckExternalEvents(cs2, 0x19AD);
    // JZ 0x0000:30b4 (0170_19AB / 0x30AB)
    if(ZeroFlag) {
      goto label_0170_19B4_030B4;
    }
    CheckExternalEvents(cs2, 0x19B4);
    // ADD word ptr ES:[0xa44b],0x80 (0170_19AD / 0x30AD)
    UInt16[ES, 0xA44B] += 0x80;
    label_0170_19B4_030B4:
    CheckExternalEvents(cs2, 0x19B7);
    // DEC word ptr [BP + 0x6] (0170_19B4 / 0x30B4)
    UInt16[SS, (ushort)(BP + 0x6)]--;
    label_0170_19B7_030B7:
    CheckExternalEvents(cs2, 0x19BB);
    // CMP word ptr [BP + 0x6],0x0 (0170_19B7 / 0x30B7)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x19BD);
    // JNZ 0x0000:309c (0170_19BB / 0x30BB)
    if(!ZeroFlag) {
      goto label_0170_199C_0309C;
    }
    CheckExternalEvents(cs2, 0x19BE);
    // POP BP (0170_19BD / 0x30BD)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x19BF);
    // RETF  (0170_19BE / 0x30BE)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_30BF_030BF(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_30BF_030BF:
    CheckExternalEvents(cs1, 0x30C0);
    // PUSH BP (0000_30BF / 0x30BF)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x30C2);
    // MOV BP,SP (0000_30C0 / 0x30C0)
    BP = SP;
    CheckExternalEvents(cs1, 0x30C4);
    // XOR AX,AX (0000_30C2 / 0x30C2)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x30C9);
    // CALLF 0x1000:cecc (0000_30C4 / 0x30C4)
    FarCall(cs1, 0x30C9, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x30CE);
    // CMP word ptr [0x15c],0x0 (0000_30C9 / 0x30C9)
    Alu.Sub16(UInt16[DS, 0x15C], 0x0);
    CheckExternalEvents(cs1, 0x30D0);
    // JZ 0x0000:30db (0000_30CE / 0x30CE)
    if(ZeroFlag) {
      goto label_0000_30DB_030DB;
    }
    CheckExternalEvents(cs1, 0x30D3);
    // PUSH word ptr [BP + 0x6] (0000_30D0 / 0x30D0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x30D8);
    // CALLF 0x1000:9352 (0000_30D3 / 0x30D3)
    FarCall(cs1, 0x30D8, ghidra_guess_1000_9352_19352);
    CheckExternalEvents(cs1, 0x30DB);
    // ADD SP,0x2 (0000_30D8 / 0x30D8)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0000_30DB_030DB:
    CheckExternalEvents(cs1, 0x30DC);
    // POP BP (0000_30DB / 0x30DB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x30DD);
    // RETF  (0000_30DC / 0x30DC)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_30DD_030DD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_30DD_030DD:
    CheckExternalEvents(cs1, 0x30DF);
    // XOR AX,AX (0000_30DD / 0x30DD)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0x30E4);
    // CALLF 0x1000:cecc (0000_30DF / 0x30DF)
    FarCall(cs1, 0x30E4, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x30E5);
    // PUSH SI (0000_30E4 / 0x30E4)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x30E6);
    // PUSH CS (0000_30E5 / 0x30E5)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x30E9);
    // CALL 0x0000:30f3 (0000_30E6 / 0x30E6)
    NearCall(cs1, 0x30E9, ghidra_guess_0000_30F3_030F3);
    CheckExternalEvents(cs1, 0x30EB);
    // MOV SI,AX (0000_30E9 / 0x30E9)
    SI = AX;
    CheckExternalEvents(cs1, 0x30EC);
    // PUSH CS (0000_30EB / 0x30EB)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x30EF);
    // CALL 0x0000:30f3 (0000_30EC / 0x30EC)
    NearCall(cs1, 0x30EF, ghidra_guess_0000_30F3_030F3);
    CheckExternalEvents(cs1, 0x30F1);
    // ADD AX,SI (0000_30EF / 0x30EF)
    // AX += SI;
    AX = Alu.Add16(AX, SI);
    CheckExternalEvents(cs1, 0x30F2);
    // POP SI (0000_30F1 / 0x30F1)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x30F3);
    // RETF  (0000_30F2 / 0x30F2)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_30F3_030F3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_30F3_030F3:
    CheckExternalEvents(cs1, 0x30F4);
    // PUSH BP (0000_30F3 / 0x30F3)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x30F6);
    // MOV BP,SP (0000_30F4 / 0x30F4)
    BP = SP;
    CheckExternalEvents(cs1, 0x30F9);
    // MOV AX,0x2 (0000_30F6 / 0x30F6)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x30FE);
    // CALLF 0x1000:cecc (0000_30F9 / 0x30F9)
    FarCall(cs1, 0x30FE, unknown_19EF_2FDC_1CECC);
    label_0000_30FE_030FE:
    CheckExternalEvents(cs1, 0x3103);
    // CALLF 0x1000:aab0 (0000_30FE / 0x30FE)
    FarCall(cs1, 0x3103, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0x3106);
    // AND AX,0x7 (0000_3103 / 0x3103)
    // AX &= 0x7;
    AX = Alu.And16(AX, 0x7);
    CheckExternalEvents(cs1, 0x3109);
    // MOV word ptr [BP + -0x2],AX (0000_3106 / 0x3106)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x310C);
    // CMP AX,0x5 (0000_3109 / 0x3109)
    Alu.Sub16(AX, 0x5);
    CheckExternalEvents(cs1, 0x310E);
    // JG 0x0000:30fe (0000_310C / 0x310C)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_30FE_030FE;
    }
    CheckExternalEvents(cs1, 0x310F);
    // INC AX (0000_310E / 0x310E)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0x3111);
    // MOV SP,BP (0000_310F / 0x310F)
    SP = BP;
    CheckExternalEvents(cs1, 0x3112);
    // POP BP (0000_3111 / 0x3111)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x3113);
    // RETF  (0000_3112 / 0x3112)
    return FarRet();
  }
  
  public virtual Action unknown_0170_1A13_03113(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_1A13_03113:
    CheckExternalEvents(cs2, 0x1A14);
    // PUSH BP (0170_1A13 / 0x3113)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x1A16);
    // MOV BP,SP (0170_1A14 / 0x3114)
    BP = SP;
    CheckExternalEvents(cs2, 0x1A19);
    // MOV AX,0xa (0170_1A16 / 0x3116)
    AX = 0xA;
    CheckExternalEvents(cs2, 0x1A1E);
    // CALLF 0x1000:cecc (0170_1A19 / 0x3119)
    FarCall(cs2, 0x1A1E, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x1A22);
    // MOV ES,word ptr [0x5388] (0170_1A1E / 0x311E)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs2, 0x1A26);
    // MOV AX,ES:[0x37fe] (0170_1A22 / 0x3122)
    AX = UInt16[ES, 0x37FE];
    CheckExternalEvents(cs2, 0x1A29);
    // MOV word ptr [BP + -0x2],AX (0170_1A26 / 0x3126)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x1A2E);
    // MOV word ptr [BP + -0xa],0x0 (0170_1A29 / 0x3129)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs2, 0x1A32);
    // CMP word ptr [BP + 0x6],0x0 (0170_1A2E / 0x312E)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x1A34);
    // JZ 0x0000:313e (0170_1A32 / 0x3132)
    if(ZeroFlag) {
      goto label_0170_1A3E_0313E;
    }
    CheckExternalEvents(cs2, 0x1A39);
    // MOV word ptr [BP + -0xa],0x1 (0170_1A34 / 0x3134)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    CheckExternalEvents(cs2, 0x1A3C);
    // MOV AX,0x3ee (0170_1A39 / 0x3139)
    AX = 0x3EE;
    CheckExternalEvents(cs2, 0x1A3E);
    // JMP 0x0000:3141 (0170_1A3C / 0x313C)
    goto label_0170_1A41_03141;
    label_0170_1A3E_0313E:
    CheckExternalEvents(cs2, 0x1A41);
    // MOV AX,0x3fe (0170_1A3E / 0x313E)
    AX = 0x3FE;
    label_0170_1A41_03141:
    CheckExternalEvents(cs2, 0x1A42);
    // PUSH DS (0170_1A41 / 0x3141)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x1A43);
    // PUSH AX (0170_1A42 / 0x3142)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1A48);
    // CALLF 0x1000:8055 (0170_1A43 / 0x3143)
    FarCall(cs2, 0x1A48, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x1A4B);
    // ADD SP,0x4 (0170_1A48 / 0x3148)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x1A4F);
    // MOV ES,word ptr [0x53c0] (0170_1A4B / 0x314B)
    ES = UInt16[DS, 0x53C0];
    CheckExternalEvents(cs2, 0x1A53);
    // MOV AX,ES:[0x374e] (0170_1A4F / 0x314F)
    AX = UInt16[ES, 0x374E];
    CheckExternalEvents(cs2, 0x1A56);
    // MOV word ptr [BP + -0x6],AX (0170_1A53 / 0x3153)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x1A5B);
    // MOV word ptr [BP + -0x4],0x0 (0170_1A56 / 0x3156)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs2, 0x1A5C);
    // PUSH CS (0170_1A5B / 0x315B)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x1A5F);
    // CALL 0x0000:412b (0170_1A5C / 0x315C)
    NearCall(cs2, 0x1A5F, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs2, 0x1A62);
    // JMP 0x0000:31e2 (0170_1A5F / 0x315F)
    goto label_0170_1AE2_031E2;
    label_0170_1A62_03162:
    CheckExternalEvents(cs2, 0x1A67);
    // CALLF 0x1000:8d29 (0170_1A62 / 0x3162)
    FarCall(cs2, 0x1A67, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs2, 0x1A6A);
    // MOV word ptr [BP + -0x8],AX (0170_1A67 / 0x3167)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x1A6B);
    // PUSH AX (0170_1A6A / 0x316A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1A70);
    // CALLF 0x1000:897d (0170_1A6B / 0x316B)
    FarCall(cs2, 0x1A70, unknown_17C6_0D1D_1897D);
    CheckExternalEvents(cs2, 0x1A73);
    // ADD SP,0x2 (0170_1A70 / 0x3170)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x1A76);
    // MOV word ptr [BP + -0x8],AX (0170_1A73 / 0x3173)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x1A79);
    // CMP AX,0x20 (0170_1A76 / 0x3176)
    Alu.Sub16(AX, 0x20);
    CheckExternalEvents(cs2, 0x1A7B);
    // JZ 0x0000:31b8 (0170_1A79 / 0x3179)
    if(ZeroFlag) {
      goto label_0170_1AB8_031B8;
    }
    CheckExternalEvents(cs2, 0x1A7D);
    // JG 0x0000:31bf (0170_1A7B / 0x317B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_1ABF_031BF;
    }
    CheckExternalEvents(cs2, 0x1A80);
    // CMP AX,0xffb3 (0170_1A7D / 0x317D)
    Alu.Sub16(AX, 0xFFB3);
    CheckExternalEvents(cs2, 0x1A82);
    // JZ 0x0000:31b1 (0170_1A80 / 0x3180)
    if(ZeroFlag) {
      goto label_0170_1AB1_031B1;
    }
    CheckExternalEvents(cs2, 0x1A85);
    // CMP AX,0xffb5 (0170_1A82 / 0x3182)
    Alu.Sub16(AX, 0xFFB5);
    CheckExternalEvents(cs2, 0x1A87);
    // JZ 0x0000:3193 (0170_1A85 / 0x3185)
    if(ZeroFlag) {
      goto label_0170_1A93_03193;
    }
    CheckExternalEvents(cs2, 0x1A8A);
    // CMP AX,0xd (0170_1A87 / 0x3187)
    Alu.Sub16(AX, 0xD);
    CheckExternalEvents(cs2, 0x1A8C);
    // JZ 0x0000:31b8 (0170_1A8A / 0x318A)
    if(ZeroFlag) {
      goto label_0170_1AB8_031B8;
    }
    CheckExternalEvents(cs2, 0x1A8E);
    // JMP 0x0000:3198 (0170_1A8C / 0x318C)
    goto label_0170_1A98_03198;
    label_0170_1A8E_0318E:
    CheckExternalEvents(cs2, 0x1A93);
    // MOV word ptr [BP + -0x4],0x1 (0170_1A8E / 0x318E)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_0170_1A93_03193:
    CheckExternalEvents(cs2, 0x1A98);
    // MOV word ptr [BP + -0xa],0x1 (0170_1A93 / 0x3193)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x1;
    label_0170_1A98_03198:
    CheckExternalEvents(cs2, 0x1A9C);
    // MOV ES,word ptr [0x53c0] (0170_1A98 / 0x3198)
    ES = UInt16[DS, 0x53C0];
    CheckExternalEvents(cs2, 0x1AA1);
    // DEC word ptr ES:[0x374e] (0170_1A9C / 0x319C)
    UInt16[ES, 0x374E]--;
    CheckExternalEvents(cs2, 0x1AA5);
    // CMP word ptr [BP + -0xa],0x0 (0170_1AA1 / 0x31A1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], 0x0);
    CheckExternalEvents(cs2, 0x1AA7);
    // JZ 0x0000:31d5 (0170_1AA5 / 0x31A5)
    if(ZeroFlag) {
      goto label_0170_1AD5_031D5;
    }
    CheckExternalEvents(cs2, 0x1AAA);
    // MOV AX,0x3ee (0170_1AA7 / 0x31A7)
    AX = 0x3EE;
    CheckExternalEvents(cs2, 0x1AAC);
    // JMP 0x0000:31d8 (0170_1AAA / 0x31AA)
    goto label_0170_1AD8_031D8;
    label_0170_1AAC_031AC:
    CheckExternalEvents(cs2, 0x1AB1);
    // MOV word ptr [BP + -0x4],0x1 (0170_1AAC / 0x31AC)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_0170_1AB1_031B1:
    CheckExternalEvents(cs2, 0x1AB6);
    // MOV word ptr [BP + -0xa],0x0 (0170_1AB1 / 0x31B1)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    CheckExternalEvents(cs2, 0x1AB8);
    // JMP 0x0000:3198 (0170_1AB6 / 0x31B6)
    goto label_0170_1A98_03198;
    label_0170_1AB8_031B8:
    CheckExternalEvents(cs2, 0x1ABD);
    // MOV word ptr [BP + -0x4],0x1 (0170_1AB8 / 0x31B8)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    CheckExternalEvents(cs2, 0x1ABF);
    // JMP 0x0000:3198 (0170_1ABD / 0x31BD)
    goto label_0170_1A98_03198;
    label_0170_1ABF_031BF:
    CheckExternalEvents(cs2, 0x1AC2);
    // CMP AX,0x4e (0170_1ABF / 0x31BF)
    Alu.Sub16(AX, 0x4E);
    CheckExternalEvents(cs2, 0x1AC4);
    // JZ 0x0000:31ac (0170_1AC2 / 0x31C2)
    if(ZeroFlag) {
      goto label_0170_1AAC_031AC;
    }
    CheckExternalEvents(cs2, 0x1AC7);
    // CMP AX,0x59 (0170_1AC4 / 0x31C4)
    Alu.Sub16(AX, 0x59);
    CheckExternalEvents(cs2, 0x1AC9);
    // JZ 0x0000:318e (0170_1AC7 / 0x31C7)
    if(ZeroFlag) {
      goto label_0170_1A8E_0318E;
    }
    CheckExternalEvents(cs2, 0x1ACC);
    // CMP AX,0x6e (0170_1AC9 / 0x31C9)
    Alu.Sub16(AX, 0x6E);
    CheckExternalEvents(cs2, 0x1ACE);
    // JZ 0x0000:31ac (0170_1ACC / 0x31CC)
    if(ZeroFlag) {
      goto label_0170_1AAC_031AC;
    }
    CheckExternalEvents(cs2, 0x1AD1);
    // CMP AX,0x79 (0170_1ACE / 0x31CE)
    Alu.Sub16(AX, 0x79);
    CheckExternalEvents(cs2, 0x1AD3);
    // JZ 0x0000:318e (0170_1AD1 / 0x31D1)
    if(ZeroFlag) {
      goto label_0170_1A8E_0318E;
    }
    CheckExternalEvents(cs2, 0x1AD5);
    // JMP 0x0000:3198 (0170_1AD3 / 0x31D3)
    goto label_0170_1A98_03198;
    label_0170_1AD5_031D5:
    CheckExternalEvents(cs2, 0x1AD8);
    // MOV AX,0x3fe (0170_1AD5 / 0x31D5)
    AX = 0x3FE;
    label_0170_1AD8_031D8:
    CheckExternalEvents(cs2, 0x1AD9);
    // PUSH DS (0170_1AD8 / 0x31D8)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x1ADA);
    // PUSH AX (0170_1AD9 / 0x31D9)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1ADF);
    // CALLF 0x1000:8055 (0170_1ADA / 0x31DA)
    FarCall(cs2, 0x1ADF, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x1AE2);
    // ADD SP,0x4 (0170_1ADF / 0x31DF)
    SP += 0x4;
    label_0170_1AE2_031E2:
    CheckExternalEvents(cs2, 0x1AE6);
    // CMP word ptr [BP + -0x4],0x0 (0170_1AE2 / 0x31E2)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs2, 0x1AE8);
    // JNZ 0x0000:31eb (0170_1AE6 / 0x31E6)
    if(!ZeroFlag) {
      goto label_0170_1AEB_031EB;
    }
    CheckExternalEvents(cs2, 0x1AEB);
    // JMP 0x0000:3162 (0170_1AE8 / 0x31E8)
    goto label_0170_1A62_03162;
    label_0170_1AEB_031EB:
    CheckExternalEvents(cs2, 0x1AEF);
    // MOV ES,word ptr [0x5388] (0170_1AEB / 0x31EB)
    ES = UInt16[DS, 0x5388];
    CheckExternalEvents(cs2, 0x1AF2);
    // MOV AX,word ptr [BP + -0x2] (0170_1AEF / 0x31EF)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x1AF6);
    // MOV ES:[0x37fe],AX (0170_1AF2 / 0x31F2)
    UInt16[ES, 0x37FE] = AX;
    CheckExternalEvents(cs2, 0x1AF9);
    // MOV AX,word ptr [BP + -0xa] (0170_1AF6 / 0x31F6)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs2, 0x1AFB);
    // MOV SP,BP (0170_1AF9 / 0x31F9)
    SP = BP;
    CheckExternalEvents(cs2, 0x1AFC);
    // POP BP (0170_1AFB / 0x31FB)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x1AFD);
    // RETF  (0170_1AFC / 0x31FC)
    return FarRet();
  }
  
  public virtual Action unknown_0170_1AFD_031FD(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_1AFD_031FD:
    CheckExternalEvents(cs2, 0x1AFE);
    // PUSH BP (0170_1AFD / 0x31FD)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x1B00);
    // MOV BP,SP (0170_1AFE / 0x31FE)
    BP = SP;
    CheckExternalEvents(cs2, 0x1B03);
    // MOV AX,0x8 (0170_1B00 / 0x3200)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x1B08);
    // CALLF 0x1000:cecc (0170_1B03 / 0x3203)
    FarCall(cs2, 0x1B08, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x1B0D);
    // MOV word ptr [BP + -0x6],0x244b (0170_1B08 / 0x3208)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x244B;
    CheckExternalEvents(cs2, 0x1B12);
    // MOV word ptr [BP + -0x4],0x1ddc (0170_1B0D / 0x320D)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1DDC;
    CheckExternalEvents(cs2, 0x1B15);
    // PUSH word ptr [BP + -0x4] (0170_1B12 / 0x3212)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x1B18);
    // PUSH word ptr [BP + -0x6] (0170_1B15 / 0x3215)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1B1C);
    // MOV ES,word ptr [0x53c2] (0170_1B18 / 0x3218)
    ES = UInt16[DS, 0x53C2];
    CheckExternalEvents(cs2, 0x1B21);
    // PUSH word ptr ES:[0x66] (0170_1B1C / 0x321C)
    Stack.Push16(UInt16[ES, 0x66]);
    CheckExternalEvents(cs2, 0x1B26);
    // PUSH word ptr ES:[0x64] (0170_1B21 / 0x3221)
    Stack.Push16(UInt16[ES, 0x64]);
    CheckExternalEvents(cs2, 0x1B2B);
    // CALLF 0x1000:c2dc (0170_1B26 / 0x3226)
    FarCall(cs2, 0x1B2B, unknown_19EF_23EC_1C2DC);
    CheckExternalEvents(cs2, 0x1B2E);
    // ADD SP,0x8 (0170_1B2B / 0x322B)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs2, 0x1B31);
    // MOV word ptr [BP + -0x8],AX (0170_1B2E / 0x322E)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x1B35);
    // MOV ES,word ptr [0x53a0] (0170_1B31 / 0x3231)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x1B3B);
    // CMP word ptr ES:[0x4fba],0x0 (0170_1B35 / 0x3235)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs2, 0x1B3D);
    // JNZ 0x0000:3265 (0170_1B3B / 0x323B)
    if(!ZeroFlag) {
      goto label_0170_1B65_03265;
    }
    CheckExternalEvents(cs2, 0x1B40);
    // MOV AX,0x790 (0170_1B3D / 0x323D)
    AX = 0x790;
    CheckExternalEvents(cs2, 0x1B41);
    // PUSH AX (0170_1B40 / 0x3240)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B44);
    // MOV AX,0x16 (0170_1B41 / 0x3241)
    AX = 0x16;
    CheckExternalEvents(cs2, 0x1B45);
    // PUSH AX (0170_1B44 / 0x3244)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B48);
    // MOV AX,0x336b (0170_1B45 / 0x3245)
    AX = 0x336B;
    CheckExternalEvents(cs2, 0x1B4B);
    // MOV DX,0x1ddc (0170_1B48 / 0x3248)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x1B4C);
    // PUSH DX (0170_1B4B / 0x324B)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x1B4D);
    // PUSH AX (0170_1B4C / 0x324C)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B50);
    // PUSH word ptr [BP + -0x4] (0170_1B4D / 0x324D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x1B53);
    // PUSH word ptr [BP + -0x6] (0170_1B50 / 0x3250)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1B58);
    // CALLF 0x1000:a053 (0170_1B53 / 0x3253)
    FarCall(cs2, 0x1B58, ghidra_guess_1000_A053_1A053);
    CheckExternalEvents(cs2, 0x1B5B);
    // ADD SP,0xc (0170_1B58 / 0x3258)
    // SP += 0xC;
    SP = Alu.Add16(SP, 0xC);
    CheckExternalEvents(cs2, 0x1B60);
    // MOV word ptr [BP + -0x6],0x336b (0170_1B5B / 0x325B)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x336B;
    CheckExternalEvents(cs2, 0x1B65);
    // MOV word ptr [BP + -0x4],0x1ddc (0170_1B60 / 0x3260)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1DDC;
    label_0170_1B65_03265:
    CheckExternalEvents(cs2, 0x1B69);
    // MOV ES,word ptr [0x53a0] (0170_1B65 / 0x3265)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x1B6F);
    // CMP word ptr ES:[0x4fba],0x2 (0170_1B69 / 0x3269)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x1B71);
    // JGE 0x0000:3294 (0170_1B6F / 0x326F)
    if(SignFlag == OverflowFlag) {
      goto label_0170_1B94_03294;
    }
    CheckExternalEvents(cs2, 0x1B73);
    // SUB AX,AX (0170_1B71 / 0x3271)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs2, 0x1B74);
    // PUSH AX (0170_1B73 / 0x3273)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B77);
    // MOV AX,0x58 (0170_1B74 / 0x3274)
    AX = 0x58;
    CheckExternalEvents(cs2, 0x1B78);
    // PUSH AX (0170_1B77 / 0x3277)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B7B);
    // MOV AX,0xb (0170_1B78 / 0x3278)
    AX = 0xB;
    CheckExternalEvents(cs2, 0x1B7C);
    // PUSH AX (0170_1B7B / 0x327B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B7F);
    // MOV AX,0x8 (0170_1B7C / 0x327C)
    AX = 0x8;
    CheckExternalEvents(cs2, 0x1B80);
    // PUSH AX (0170_1B7F / 0x327F)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B83);
    // MOV AX,0x1 (0170_1B80 / 0x3280)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x1B84);
    // PUSH AX (0170_1B83 / 0x3283)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1B87);
    // PUSH word ptr [BP + -0x4] (0170_1B84 / 0x3284)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs2, 0x1B8A);
    // PUSH word ptr [BP + -0x6] (0170_1B87 / 0x3287)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1B8F);
    // CALLF 0x1000:8b56 (0170_1B8A / 0x328A)
    FarCall(cs2, 0x1B8F, unknown_18AD_0086_18B56);
    CheckExternalEvents(cs2, 0x1B92);
    // ADD SP,0xe (0170_1B8F / 0x328F)
    // SP += 0xE;
    SP = Alu.Add16(SP, 0xE);
    CheckExternalEvents(cs2, 0x1B94);
    // JMP 0x0000:32be (0170_1B92 / 0x3292)
    goto label_0170_1BBE_032BE;
    label_0170_1B94_03294:
    CheckExternalEvents(cs2, 0x1B98);
    // MOV ES,word ptr [0x53a0] (0170_1B94 / 0x3294)
    ES = UInt16[DS, 0x53A0];
    CheckExternalEvents(cs2, 0x1B9E);
    // CMP word ptr ES:[0x4fba],0x2 (0170_1B98 / 0x3298)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs2, 0x1BA0);
    // JNZ 0x0000:32b9 (0170_1B9E / 0x329E)
    if(!ZeroFlag) {
      goto label_0170_1BB9_032B9;
    }
    CheckExternalEvents(cs2, 0x1BA3);
    // MOV AX,0x790 (0170_1BA0 / 0x32A0)
    AX = 0x790;
    CheckExternalEvents(cs2, 0x1BA4);
    // PUSH AX (0170_1BA3 / 0x32A3)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1BA7);
    // MOV AX,0x336b (0170_1BA4 / 0x32A4)
    AX = 0x336B;
    CheckExternalEvents(cs2, 0x1BAA);
    // MOV DX,0x1ddc (0170_1BA7 / 0x32A7)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x1BAB);
    // PUSH DX (0170_1BAA / 0x32AA)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x1BAC);
    // PUSH AX (0170_1BAB / 0x32AB)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1BAF);
    // MOV AX,0x244b (0170_1BAC / 0x32AC)
    AX = 0x244B;
    CheckExternalEvents(cs2, 0x1BB0);
    // PUSH DX (0170_1BAF / 0x32AF)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x1BB1);
    // PUSH AX (0170_1BB0 / 0x32B0)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1BB6);
    // CALLF 0x1000:a462 (0170_1BB1 / 0x32B1)
    FarCall(cs2, 0x1BB6, ghidra_guess_1000_A462_1A462);
    CheckExternalEvents(cs2, 0x1BB9);
    // ADD SP,0xa (0170_1BB6 / 0x32B6)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    label_0170_1BB9_032B9:
    CheckExternalEvents(cs2, 0x1BBE);
    // CALLF 0x1000:bd27 (0170_1BB9 / 0x32B9)
    FarCall(cs2, 0x1BBE, unknown_19EF_1E37_1BD27);
    label_0170_1BBE_032BE:
    CheckExternalEvents(cs2, 0x1BC2);
    // MOV ES,word ptr [0x53c2] (0170_1BBE / 0x32BE)
    ES = UInt16[DS, 0x53C2];
    CheckExternalEvents(cs2, 0x1BC5);
    // MOV AX,word ptr [BP + -0x8] (0170_1BC2 / 0x32C2)
    AX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x1BCA);
    // ADD word ptr ES:[0x64],AX (0170_1BC5 / 0x32C5)
    // UInt16[ES, 0x64] += AX;
    UInt16[ES, 0x64] = Alu.Add16(UInt16[ES, 0x64], AX);
    CheckExternalEvents(cs2, 0x1BCE);
    // MOV ES,word ptr [0x53c4] (0170_1BCA / 0x32CA)
    ES = UInt16[DS, 0x53C4];
    CheckExternalEvents(cs2, 0x1BD3);
    // MOV BX,word ptr ES:[0xe48a] (0170_1BCE / 0x32CE)
    BX = UInt16[ES, 0xE48A];
    CheckExternalEvents(cs2, 0x1BD7);
    // MOV ES,word ptr [0x53c6] (0170_1BD3 / 0x32D3)
    ES = UInt16[DS, 0x53C6];
    CheckExternalEvents(cs2, 0x1BDC);
    // MOV AL,byte ptr ES:[BX + 0x42c3] (0170_1BD7 / 0x32D7)
    AL = UInt8[ES, (ushort)(BX + 0x42C3)];
    CheckExternalEvents(cs2, 0x1BDD);
    // CBW  (0170_1BDC / 0x32DC)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x1BE0);
    // SUB AX,0x41 (0170_1BDD / 0x32DD)
    // AX -= 0x41;
    AX = Alu.Sub16(AX, 0x41);
    CheckExternalEvents(cs2, 0x1BE3);
    // MOV word ptr [BP + -0x2],AX (0170_1BE0 / 0x32E0)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x1BE5);
    // MOV BX,AX (0170_1BE3 / 0x32E3)
    BX = AX;
    CheckExternalEvents(cs2, 0x1BEA);
    // MOV AL,byte ptr ES:[BX + 0x42e3] (0170_1BE5 / 0x32E5)
    AL = UInt8[ES, (ushort)(BX + 0x42E3)];
    CheckExternalEvents(cs2, 0x1BEF);
    // IMUL byte ptr ES:[0x42f5] (0170_1BEA / 0x32EA)
    short resImul0170_1BEA = Alu.Imul8((sbyte)AL, (sbyte)UInt8[ES, 0x42F5]);
    AL = (byte)(resImul0170_1BEA);
    AH = (byte)(resImul0170_1BEA >> 8);
    CheckExternalEvents(cs2, 0x1BF2);
    // MOV word ptr [BP + -0x2],AX (0170_1BEF / 0x32EF)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x1BF5);
    // MOV AX,0x3 (0170_1BF2 / 0x32F2)
    AX = 0x3;
    CheckExternalEvents(cs2, 0x1BF8);
    // IMUL word ptr [BP + -0x2] (0170_1BF5 / 0x32F5)
    int resImul0170_1BF5 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0170_1BF5);
    DX = (ushort)(resImul0170_1BF5 >> 16);
    CheckExternalEvents(cs2, 0x1BFA);
    // SAR AX,0x1 (0170_1BF8 / 0x32F8)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs2, 0x1BFC);
    // SAR AX,0x1 (0170_1BFA / 0x32FA)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs2, 0x1BFF);
    // MOV word ptr [BP + -0x2],AX (0170_1BFC / 0x32FC)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x1C00);
    // PUSH AX (0170_1BFF / 0x32FF)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1C05);
    // CALLF 0x1000:8ad6 (0170_1C00 / 0x3300)
    FarCall(cs2, 0x1C05, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs2, 0x1C09);
    // MOV ES,word ptr [0x53c4] (0170_1C05 / 0x3305)
    ES = UInt16[DS, 0x53C4];
    CheckExternalEvents(cs2, 0x1C0E);
    // INC word ptr ES:[0xe48a] (0170_1C09 / 0x3309)
    UInt16[ES, 0xE48A] = Alu.Inc16(UInt16[ES, 0xE48A]);
    CheckExternalEvents(cs2, 0x1C10);
    // MOV SP,BP (0170_1C0E / 0x330E)
    SP = BP;
    CheckExternalEvents(cs2, 0x1C11);
    // POP BP (0170_1C10 / 0x3310)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x1C12);
    // RETF  (0170_1C11 / 0x3311)
    return FarRet();
  }
  
  public virtual Action unknown_0170_1C12_03312(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0170_1C12_03312:
    CheckExternalEvents(cs2, 0x1C13);
    // PUSH BP (0170_1C12 / 0x3312)
    Stack.Push16(BP);
    CheckExternalEvents(cs2, 0x1C15);
    // MOV BP,SP (0170_1C13 / 0x3313)
    BP = SP;
    CheckExternalEvents(cs2, 0x1C18);
    // MOV AX,0x1a (0170_1C15 / 0x3315)
    AX = 0x1A;
    CheckExternalEvents(cs2, 0x1C1D);
    // CALLF 0x1000:cecc (0170_1C18 / 0x3318)
    FarCall(cs2, 0x1C1D, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs2, 0x1C1E);
    // PUSH DI (0170_1C1D / 0x331D)
    Stack.Push16(DI);
    CheckExternalEvents(cs2, 0x1C1F);
    // PUSH SI (0170_1C1E / 0x331E)
    Stack.Push16(SI);
    CheckExternalEvents(cs2, 0x1C24);
    // MOV word ptr [BP + -0x4],0x0 (0170_1C1F / 0x331F)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs2, 0x1C28);
    // MOV ES,word ptr [0x538c] (0170_1C24 / 0x3324)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x1C2C);
    // MOV AX,ES:[0xa44b] (0170_1C28 / 0x3328)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x1C2F);
    // AND AX,0xf (0170_1C2C / 0x332C)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    CheckExternalEvents(cs2, 0x1C32);
    // MOV word ptr [BP + -0x18],AX (0170_1C2F / 0x332F)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs2, 0x1C36);
    // MOV ES,word ptr [0x538e] (0170_1C32 / 0x3332)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x1C3A);
    // MOV AX,ES:[0xa44d] (0170_1C36 / 0x3336)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs2, 0x1C3D);
    // AND AX,0xf (0170_1C3A / 0x333A)
    // AX &= 0xF;
    AX = Alu.And16(AX, 0xF);
    CheckExternalEvents(cs2, 0x1C40);
    // MOV word ptr [BP + -0x1a],AX (0170_1C3D / 0x333D)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs2, 0x1C45);
    // MOV word ptr [BP + -0x16],0x0 (0170_1C40 / 0x3340)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs2, 0x1C49);
    // CMP word ptr [BP + 0x8],0x0 (0170_1C45 / 0x3345)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x1C4B);
    // JGE 0x0000:3354 (0170_1C49 / 0x3349)
    if(SignFlag == OverflowFlag) {
      goto label_0170_1C54_03354;
    }
    CheckExternalEvents(cs2, 0x1C4D);
    // OR AX,AX (0170_1C4B / 0x334B)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x1C4F);
    // JNZ 0x0000:3354 (0170_1C4D / 0x334D)
    if(!ZeroFlag) {
      goto label_0170_1C54_03354;
    }
    CheckExternalEvents(cs2, 0x1C54);
    // MOV word ptr [BP + -0x16],0x8 (0170_1C4F / 0x334F)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x8;
    label_0170_1C54_03354:
    CheckExternalEvents(cs2, 0x1C58);
    // CMP word ptr [BP + 0x8],0x0 (0170_1C54 / 0x3354)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs2, 0x1C5A);
    // JLE 0x0000:3364 (0170_1C58 / 0x3358)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_1C64_03364;
    }
    CheckExternalEvents(cs2, 0x1C5E);
    // CMP word ptr [BP + -0x1a],0xf (0170_1C5A / 0x335A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x1A)], 0xF);
    CheckExternalEvents(cs2, 0x1C60);
    // JNZ 0x0000:3364 (0170_1C5E / 0x335E)
    if(!ZeroFlag) {
      goto label_0170_1C64_03364;
    }
    CheckExternalEvents(cs2, 0x1C64);
    // OR byte ptr [BP + -0x16],0x4 (0170_1C60 / 0x3360)
    UInt8[SS, (ushort)(BP - 0x16)] |= 0x4;
    label_0170_1C64_03364:
    CheckExternalEvents(cs2, 0x1C68);
    // CMP word ptr [BP + 0x6],0x0 (0170_1C64 / 0x3364)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x1C6A);
    // JGE 0x0000:3374 (0170_1C68 / 0x3368)
    if(SignFlag == OverflowFlag) {
      goto label_0170_1C74_03374;
    }
    CheckExternalEvents(cs2, 0x1C6E);
    // CMP word ptr [BP + -0x18],0x0 (0170_1C6A / 0x336A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0x0);
    CheckExternalEvents(cs2, 0x1C70);
    // JNZ 0x0000:3374 (0170_1C6E / 0x336E)
    if(!ZeroFlag) {
      goto label_0170_1C74_03374;
    }
    CheckExternalEvents(cs2, 0x1C74);
    // OR byte ptr [BP + -0x16],0x2 (0170_1C70 / 0x3370)
    UInt8[SS, (ushort)(BP - 0x16)] |= 0x2;
    label_0170_1C74_03374:
    CheckExternalEvents(cs2, 0x1C78);
    // CMP word ptr [BP + 0x6],0x0 (0170_1C74 / 0x3374)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs2, 0x1C7A);
    // JLE 0x0000:3385 (0170_1C78 / 0x3378)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0170_1C85_03385;
    }
    CheckExternalEvents(cs2, 0x1C7E);
    // CMP word ptr [BP + -0x18],0xf (0170_1C7A / 0x337A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x18)], 0xF);
    CheckExternalEvents(cs2, 0x1C80);
    // JNZ 0x0000:3385 (0170_1C7E / 0x337E)
    if(!ZeroFlag) {
      goto label_0170_1C85_03385;
    }
    CheckExternalEvents(cs2, 0x1C85);
    // OR word ptr [BP + -0x16],0x1 (0170_1C80 / 0x3380)
    UInt16[SS, (ushort)(BP - 0x16)] |= 0x1;
    label_0170_1C85_03385:
    CheckExternalEvents(cs2, 0x1C89);
    // CMP word ptr [BP + -0x16],0x0 (0170_1C85 / 0x3385)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x0);
    CheckExternalEvents(cs2, 0x1C8B);
    // JZ 0x0000:33c1 (0170_1C89 / 0x3389)
    if(ZeroFlag) {
      goto label_0170_1CC1_033C1;
    }
    CheckExternalEvents(cs2, 0x1C8E);
    // MOV BX,word ptr [BP + -0x16] (0170_1C8B / 0x338B)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs2, 0x1C92);
    // MOV AL,byte ptr [BX + 0x4a0] (0170_1C8E / 0x338E)
    AL = UInt8[DS, (ushort)(BX + 0x4A0)];
    CheckExternalEvents(cs2, 0x1C93);
    // CBW  (0170_1C92 / 0x3392)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs2, 0x1C95);
    // MOV BX,AX (0170_1C93 / 0x3393)
    BX = AX;
    CheckExternalEvents(cs2, 0x1C99);
    // MOV ES,word ptr [0x53c8] (0170_1C95 / 0x3395)
    ES = UInt16[DS, 0x53C8];
    CheckExternalEvents(cs2, 0x1C9F);
    // CMP byte ptr ES:[BX + 0x7a4],0xf (0170_1C99 / 0x3399)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x7A4)], 0xF);
    CheckExternalEvents(cs2, 0x1CA1);
    // JNZ 0x0000:33c1 (0170_1C9F / 0x339F)
    if(!ZeroFlag) {
      goto label_0170_1CC1_033C1;
    }
    CheckExternalEvents(cs2, 0x1CA5);
    // MOV ES,word ptr [0x5386] (0170_1CA1 / 0x33A1)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0x1CA8);
    // MOV AX,0x1 (0170_1CA5 / 0x33A5)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x1CAC);
    // MOV ES:[0xd55c],AX (0170_1CA8 / 0x33A8)
    UInt16[ES, 0xD55C] = AX;
    CheckExternalEvents(cs2, 0x1CAF);
    // MOV word ptr [BP + -0x4],AX (0170_1CAC / 0x33AC)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs2, 0x1CB4);
    // CALLF 0x1000:7bf6 (0170_1CAF / 0x33AF)
    FarCall(cs2, 0x1CB4, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs2, 0x1CB7);
    // MOV AX,0x410 (0170_1CB4 / 0x33B4)
    AX = 0x410;
    CheckExternalEvents(cs2, 0x1CB8);
    // PUSH DS (0170_1CB7 / 0x33B7)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x1CB9);
    // PUSH AX (0170_1CB8 / 0x33B8)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1CBE);
    // CALLF 0x1000:7c1a (0170_1CB9 / 0x33B9)
    FarCall(cs2, 0x1CBE, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs2, 0x1CC1);
    // ADD SP,0x4 (0170_1CBE / 0x33BE)
    SP += 0x4;
    label_0170_1CC1_033C1:
    CheckExternalEvents(cs2, 0x1CC5);
    // CMP word ptr [BP + -0x4],0x0 (0170_1CC1 / 0x33C1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs2, 0x1CC7);
    // JZ 0x0000:33ca (0170_1CC5 / 0x33C5)
    if(ZeroFlag) {
      goto label_0170_1CCA_033CA;
    }
    CheckExternalEvents(cs2, 0x1CCA);
    // JMP 0x0000:3886 (0170_1CC7 / 0x33C7)
    goto label_0170_2186_03886;
    label_0170_1CCA_033CA:
    CheckExternalEvents(cs2, 0x1CCF);
    // MOV word ptr [BP + -0x12],0x0 (0170_1CCA / 0x33CA)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs2, 0x1CD1);
    // JMP 0x0000:3419 (0170_1CCF / 0x33CF)
    goto label_0170_1D19_03419;
    label_0170_1CD1_033D1:
    CheckExternalEvents(cs2, 0x1CD6);
    // CMP word ptr [BP + -0x10],0x94 (0170_1CD1 / 0x33D1)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x94);
    CheckExternalEvents(cs2, 0x1CD8);
    // JNZ 0x0000:33dd (0170_1CD6 / 0x33D6)
    if(!ZeroFlag) {
      goto label_0170_1CDD_033DD;
    }
    CheckExternalEvents(cs2, 0x1CDD);
    // CALLF 0x0000:d46c (0170_1CD8 / 0x33D8)
    FarCall(cs2, 0x1CDD, ghidra_guess_0000_D46C_0D46C);
    label_0170_1CDD_033DD:
    CheckExternalEvents(cs2, 0x1CE2);
    // CMP word ptr [BP + -0x10],0x97 (0170_1CDD / 0x33DD)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x97);
    CheckExternalEvents(cs2, 0x1CE4);
    // JL 0x0000:33f9 (0170_1CE2 / 0x33E2)
    if(SignFlag != OverflowFlag) {
      goto label_0170_1CF9_033F9;
    }
    CheckExternalEvents(cs2, 0x1CE9);
    // CMP word ptr [BP + -0x10],0xf0 (0170_1CE4 / 0x33E4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xF0);
    CheckExternalEvents(cs2, 0x1CEB);
    // JG 0x0000:33f9 (0170_1CE9 / 0x33E9)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_1CF9_033F9;
    }
    CheckExternalEvents(cs2, 0x1CEE);
    // PUSH word ptr [BP + -0x6] (0170_1CEB / 0x33EB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1CF1);
    // PUSH word ptr [BP + -0x2] (0170_1CEE / 0x33EE)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x1CF6);
    // CALLF 0x0000:d5e3 (0170_1CF1 / 0x33F1)
    FarCall(cs2, 0x1CF6, ghidra_guess_0000_D5E3_0D5E3);
    CheckExternalEvents(cs2, 0x1CF9);
    // ADD SP,0x4 (0170_1CF6 / 0x33F6)
    SP += 0x4;
    label_0170_1CF9_033F9:
    CheckExternalEvents(cs2, 0x1CFE);
    // CMP word ptr [BP + -0x10],0x8c (0170_1CF9 / 0x33F9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x8C);
    CheckExternalEvents(cs2, 0x1D00);
    // JZ 0x0000:3407 (0170_1CFE / 0x33FE)
    if(ZeroFlag) {
      goto label_0170_1D07_03407;
    }
    CheckExternalEvents(cs2, 0x1D05);
    // CMP word ptr [BP + -0x10],0x8d (0170_1D00 / 0x3400)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x8D);
    CheckExternalEvents(cs2, 0x1D07);
    // JNZ 0x0000:340c (0170_1D05 / 0x3405)
    if(!ZeroFlag) {
      goto label_0170_1D0C_0340C;
    }
    label_0170_1D07_03407:
    CheckExternalEvents(cs2, 0x1D0C);
    // CALLF 0x0000:d650 (0170_1D07 / 0x3407)
    FarCall(cs2, 0x1D0C, ghidra_guess_0000_D650_0D650);
    label_0170_1D0C_0340C:
    CheckExternalEvents(cs2, 0x1D11);
    // MOV word ptr [BP + -0x4],0x1 (0170_1D0C / 0x340C)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    CheckExternalEvents(cs2, 0x1D16);
    // MOV word ptr [BP + -0x12],0x8 (0170_1D11 / 0x3411)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x8;
    label_0170_1D16_03416:
    CheckExternalEvents(cs2, 0x1D19);
    // INC word ptr [BP + -0x12] (0170_1D16 / 0x3416)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    label_0170_1D19_03419:
    CheckExternalEvents(cs2, 0x1D1D);
    // CMP word ptr [BP + -0x12],0x8 (0170_1D19 / 0x3419)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x8);
    CheckExternalEvents(cs2, 0x1D1F);
    // JL 0x0000:3422 (0170_1D1D / 0x341D)
    if(SignFlag != OverflowFlag) {
      goto label_0170_1D22_03422;
    }
    CheckExternalEvents(cs2, 0x1D22);
    // JMP 0x0000:36be (0170_1D1F / 0x341F)
    goto label_0170_1FBE_036BE;
    label_0170_1D22_03422:
    CheckExternalEvents(cs2, 0x1D25);
    // MOV SI,word ptr [BP + -0x12] (0170_1D22 / 0x3422)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0x1D27);
    // SHL SI,0x1 (0170_1D25 / 0x3425)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x1D2B);
    // MOV ES,word ptr [0x5392] (0170_1D27 / 0x3427)
    ES = UInt16[DS, 0x5392];
    CheckExternalEvents(cs2, 0x1D31);
    // CMP word ptr ES:[SI + 0x4072],0x0 (0170_1D2B / 0x342B)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x4072)], 0x0);
    CheckExternalEvents(cs2, 0x1D33);
    // JZ 0x0000:3416 (0170_1D31 / 0x3431)
    if(ZeroFlag) {
      goto label_0170_1D16_03416;
    }
    CheckExternalEvents(cs2, 0x1D37);
    // MOV AX,word ptr [SI + 0x464] (0170_1D33 / 0x3433)
    AX = UInt16[DS, (ushort)(SI + 0x464)];
    CheckExternalEvents(cs2, 0x1D3A);
    // ADD AX,word ptr [BP + 0x6] (0170_1D37 / 0x3437)
    AX += UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x1D3D);
    // ADD AX,0x1a (0170_1D3A / 0x343A)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs2, 0x1D40);
    // MOV word ptr [BP + -0x8],AX (0170_1D3D / 0x343D)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x1D44);
    // MOV AX,word ptr [SI + 0x47c] (0170_1D40 / 0x3440)
    AX = UInt16[DS, (ushort)(SI + 0x47C)];
    CheckExternalEvents(cs2, 0x1D47);
    // ADD AX,word ptr [BP + 0x8] (0170_1D44 / 0x3444)
    AX += UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x1D4A);
    // ADD AX,0xc (0170_1D47 / 0x3447)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs2, 0x1D4D);
    // MOV word ptr [BP + -0xa],AX (0170_1D4A / 0x344A)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs2, 0x1D4F);
    // MOV BX,AX (0170_1D4D / 0x344D)
    BX = AX;
    CheckExternalEvents(cs2, 0x1D52);
    // AND BL,0xfe (0170_1D4F / 0x344F)
    // BL &= 0xFE;
    BL = Alu.And8(BL, 0xFE);
    CheckExternalEvents(cs2, 0x1D56);
    // MOV AX,word ptr [BX + 0x48c] (0170_1D52 / 0x3452)
    AX = UInt16[DS, (ushort)(BX + 0x48C)];
    CheckExternalEvents(cs2, 0x1D59);
    // MOV CX,word ptr [BP + -0x8] (0170_1D56 / 0x3456)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x1D5C);
    // SUB CX,0xd (0170_1D59 / 0x3459)
    CX -= 0xD;
    CheckExternalEvents(cs2, 0x1D5E);
    // SAR CX,0x1 (0170_1D5C / 0x345C)
    CX = Alu.Sar16(CX, 0x1);
    CheckExternalEvents(cs2, 0x1D60);
    // ADD AX,CX (0170_1D5E / 0x345E)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs2, 0x1D63);
    // MOV word ptr [BP + -0xc],AX (0170_1D60 / 0x3460)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs2, 0x1D67);
    // TEST byte ptr [BP + -0x8],0x1 (0170_1D63 / 0x3463)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs2, 0x1D69);
    // JNZ 0x0000:3478 (0170_1D67 / 0x3467)
    if(!ZeroFlag) {
      goto label_0170_1D78_03478;
    }
    CheckExternalEvents(cs2, 0x1D6D);
    // MOV ES,word ptr [0x538c] (0170_1D69 / 0x3469)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x1D73);
    // TEST byte ptr ES:[0xa44b],0x1 (0170_1D6D / 0x346D)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs2, 0x1D75);
    // JZ 0x0000:3478 (0170_1D73 / 0x3473)
    if(ZeroFlag) {
      goto label_0170_1D78_03478;
    }
    CheckExternalEvents(cs2, 0x1D78);
    // INC word ptr [BP + -0xc] (0170_1D75 / 0x3475)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_0170_1D78_03478:
    CheckExternalEvents(cs2, 0x1D7C);
    // TEST byte ptr [BP + -0xa],0x1 (0170_1D78 / 0x3478)
    Alu.And8(UInt8[SS, (ushort)(BP - 0xA)], 0x1);
    CheckExternalEvents(cs2, 0x1D7E);
    // JZ 0x0000:348e (0170_1D7C / 0x347C)
    if(ZeroFlag) {
      goto label_0170_1D8E_0348E;
    }
    CheckExternalEvents(cs2, 0x1D82);
    // MOV ES,word ptr [0x538e] (0170_1D7E / 0x347E)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x1D88);
    // TEST byte ptr ES:[0xa44d],0x1 (0170_1D82 / 0x3482)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs2, 0x1D8A);
    // JZ 0x0000:348e (0170_1D88 / 0x3488)
    if(ZeroFlag) {
      goto label_0170_1D8E_0348E;
    }
    CheckExternalEvents(cs2, 0x1D8E);
    // ADD word ptr [BP + -0xc],0x18 (0170_1D8A / 0x348A)
    // UInt16[SS, (ushort)(BP - 0xC)] += 0x18;
    UInt16[SS, (ushort)(BP - 0xC)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0xC)], 0x18);
    label_0170_1D8E_0348E:
    CheckExternalEvents(cs2, 0x1D92);
    // MOV ES,word ptr [0x5394] (0170_1D8E / 0x348E)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs2, 0x1D97);
    // MOV BX,word ptr ES:[0x9ed] (0170_1D92 / 0x3492)
    BX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs2, 0x1D9A);
    // ADD BX,word ptr [BP + -0xc] (0170_1D97 / 0x3497)
    // BX += UInt16[SS, (ushort)(BP - 0xC)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs2, 0x1D9E);
    // MOV ES,word ptr [0x5396] (0170_1D9A / 0x349A)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs2, 0x1DA3);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0170_1D9E / 0x349E)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs2, 0x1DA5);
    // SUB AH,AH (0170_1DA3 / 0x34A3)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs2, 0x1DA8);
    // MOV word ptr [BP + -0x10],AX (0170_1DA5 / 0x34A5)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs2, 0x1DAC);
    // MOV ES,word ptr [0x538a] (0170_1DA8 / 0x34A8)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x1DB1);
    // CMP byte ptr ES:[0xd346],AH (0170_1DAC / 0x34AC)
    Alu.Sub8(UInt8[ES, 0xD346], AH);
    CheckExternalEvents(cs2, 0x1DB3);
    // JZ 0x0000:34b6 (0170_1DB1 / 0x34B1)
    if(ZeroFlag) {
      goto label_0170_1DB6_034B6;
    }
    CheckExternalEvents(cs2, 0x1DB6);
    // JMP 0x0000:356f (0170_1DB3 / 0x34B3)
    goto label_0170_1E6F_0356F;
    label_0170_1DB6_034B6:
    CheckExternalEvents(cs2, 0x1DBA);
    // MOV ES,word ptr [0x5386] (0170_1DB6 / 0x34B6)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0x1DC0);
    // CMP word ptr ES:[0xd55c],0x0 (0170_1DBA / 0x34BA)
    Alu.Sub16(UInt16[ES, 0xD55C], 0x0);
    CheckExternalEvents(cs2, 0x1DC2);
    // JZ 0x0000:34c5 (0170_1DC0 / 0x34C0)
    if(ZeroFlag) {
      goto label_0170_1DC5_034C5;
    }
    CheckExternalEvents(cs2, 0x1DC5);
    // JMP 0x0000:356f (0170_1DC2 / 0x34C2)
    goto label_0170_1E6F_0356F;
    label_0170_1DC5_034C5:
    CheckExternalEvents(cs2, 0x1DCA);
    // MOV word ptr [BP + -0x14],0x0 (0170_1DC5 / 0x34C5)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x0;
    label_0170_1DCA_034CA:
    CheckExternalEvents(cs2, 0x1DCD);
    // MOV SI,word ptr [BP + -0x14] (0170_1DCA / 0x34CA)
    SI = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x1DCF);
    // SHL SI,0x1 (0170_1DCD / 0x34CD)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x1DD2);
    // MOV DI,word ptr [BP + -0x12] (0170_1DCF / 0x34CF)
    DI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0x1DD4);
    // SHL DI,0x1 (0170_1DD2 / 0x34D2)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    CheckExternalEvents(cs2, 0x1DD8);
    // MOV ES,word ptr [0x53a4] (0170_1DD4 / 0x34D4)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x1DDD);
    // MOV AX,word ptr ES:[DI + 0x400c] (0170_1DD8 / 0x34D8)
    AX = UInt16[ES, (ushort)(DI + 0x400C)];
    CheckExternalEvents(cs2, 0x1DE0);
    // ADD AX,word ptr [BP + 0x6] (0170_1DDD / 0x34DD)
    // AX += UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs2, 0x1DE4);
    // MOV ES,word ptr [0x53ca] (0170_1DE0 / 0x34E0)
    ES = UInt16[DS, 0x53CA];
    CheckExternalEvents(cs2, 0x1DE9);
    // CMP AX,word ptr ES:[SI + 0x4564] (0170_1DE4 / 0x34E4)
    Alu.Sub16(AX, UInt16[ES, (ushort)(SI + 0x4564)]);
    CheckExternalEvents(cs2, 0x1DEB);
    // JNZ 0x0000:3563 (0170_1DE9 / 0x34E9)
    if(!ZeroFlag) {
      goto label_0170_1E63_03563;
    }
    CheckExternalEvents(cs2, 0x1DEF);
    // MOV ES,word ptr [0x53a6] (0170_1DEB / 0x34EB)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x1DF4);
    // MOV AX,word ptr ES:[DI + 0x403e] (0170_1DEF / 0x34EF)
    AX = UInt16[ES, (ushort)(DI + 0x403E)];
    CheckExternalEvents(cs2, 0x1DF7);
    // ADD AX,word ptr [BP + 0x8] (0170_1DF4 / 0x34F4)
    // AX += UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x1DFB);
    // MOV ES,word ptr [0x53cc] (0170_1DF7 / 0x34F7)
    ES = UInt16[DS, 0x53CC];
    CheckExternalEvents(cs2, 0x1E00);
    // CMP AX,word ptr ES:[SI + 0x4596] (0170_1DFB / 0x34FB)
    Alu.Sub16(AX, UInt16[ES, (ushort)(SI + 0x4596)]);
    CheckExternalEvents(cs2, 0x1E02);
    // JNZ 0x0000:3563 (0170_1E00 / 0x3500)
    if(!ZeroFlag) {
      goto label_0170_1E63_03563;
    }
    CheckExternalEvents(cs2, 0x1E06);
    // MOV ES,word ptr [0x5386] (0170_1E02 / 0x3502)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0x1E0D);
    // MOV word ptr ES:[0xd55c],0x1 (0170_1E06 / 0x3506)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs2, 0x1E12);
    // CALLF 0x1000:7bf6 (0170_1E0D / 0x350D)
    FarCall(cs2, 0x1E12, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs2, 0x1E15);
    // MOV AX,0x430 (0170_1E12 / 0x3512)
    AX = 0x430;
    CheckExternalEvents(cs2, 0x1E16);
    // PUSH DS (0170_1E15 / 0x3515)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x1E17);
    // PUSH AX (0170_1E16 / 0x3516)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1E1C);
    // CALLF 0x1000:8055 (0170_1E17 / 0x3517)
    FarCall(cs2, 0x1E1C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x1E1F);
    // ADD SP,0x4 (0170_1E1C / 0x351C)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x1E22);
    // MOV BX,word ptr [BP + -0x14] (0170_1E1F / 0x351F)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x1E24);
    // MOV CL,0x4 (0170_1E22 / 0x3522)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x1E26);
    // SHL BX,CL (0170_1E24 / 0x3524)
    // BX <<= CL;
    BX = Alu.Shl16(BX, CL);
    CheckExternalEvents(cs2, 0x1E2A);
    // LEA AX,[BX + 0xa561] (0170_1E26 / 0x3526)
    AX = (ushort)(BX + 0xA561);
    CheckExternalEvents(cs2, 0x1E2D);
    // MOV DX,0x1ddc (0170_1E2A / 0x352A)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x1E2E);
    // PUSH DX (0170_1E2D / 0x352D)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x1E2F);
    // PUSH AX (0170_1E2E / 0x352E)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1E34);
    // CALLF 0x1000:8055 (0170_1E2F / 0x352F)
    FarCall(cs2, 0x1E34, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x1E37);
    // ADD SP,0x4 (0170_1E34 / 0x3534)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x1E3A);
    // MOV AX,0x444 (0170_1E37 / 0x3537)
    AX = 0x444;
    CheckExternalEvents(cs2, 0x1E3B);
    // PUSH DS (0170_1E3A / 0x353A)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x1E3C);
    // PUSH AX (0170_1E3B / 0x353B)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1E41);
    // CALLF 0x1000:8055 (0170_1E3C / 0x353C)
    FarCall(cs2, 0x1E41, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x1E44);
    // ADD SP,0x4 (0170_1E41 / 0x3541)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x1E47);
    // MOV AX,0x1 (0170_1E44 / 0x3544)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x1E48);
    // PUSH AX (0170_1E47 / 0x3547)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1E49);
    // PUSH CS (0170_1E48 / 0x3548)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x1E4C);
    // CALL 0x0000:3113 (0170_1E49 / 0x3549)
    NearCall(cs2, 0x1E4C, unknown_0170_1A13_03113);
    CheckExternalEvents(cs2, 0x1E4F);
    // ADD SP,0x2 (0170_1E4C / 0x354C)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x1E51);
    // OR AX,AX (0170_1E4F / 0x354F)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x1E53);
    // JZ 0x0000:355e (0170_1E51 / 0x3551)
    if(ZeroFlag) {
      goto label_0170_1E5E_0355E;
    }
    CheckExternalEvents(cs2, 0x1E56);
    // PUSH word ptr [BP + -0x14] (0170_1E53 / 0x3553)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs2, 0x1E5B);
    // CALLF 0x0000:94c8 (0170_1E56 / 0x3556)
    FarCall(cs2, 0x1E5B, unknown_094C_0008_094C8);
    CheckExternalEvents(cs2, 0x1E5E);
    // ADD SP,0x2 (0170_1E5B / 0x355B)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0170_1E5E_0355E:
    CheckExternalEvents(cs2, 0x1E63);
    // MOV word ptr [BP + -0x14],0x64 (0170_1E5E / 0x355E)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x64;
    label_0170_1E63_03563:
    CheckExternalEvents(cs2, 0x1E66);
    // INC word ptr [BP + -0x14] (0170_1E63 / 0x3563)
    UInt16[SS, (ushort)(BP - 0x14)]++;
    CheckExternalEvents(cs2, 0x1E6A);
    // CMP word ptr [BP + -0x14],0xc (0170_1E66 / 0x3566)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x14)], 0xC);
    CheckExternalEvents(cs2, 0x1E6C);
    // JGE 0x0000:356f (0170_1E6A / 0x356A)
    if(SignFlag == OverflowFlag) {
      goto label_0170_1E6F_0356F;
    }
    CheckExternalEvents(cs2, 0x1E6F);
    // JMP 0x0000:34ca (0170_1E6C / 0x356C)
    goto label_0170_1DCA_034CA;
    label_0170_1E6F_0356F:
    CheckExternalEvents(cs2, 0x1E72);
    // MOV AX,[0x150] (0170_1E6F / 0x356F)
    AX = UInt16[DS, 0x150];
    CheckExternalEvents(cs2, 0x1E75);
    // CMP word ptr [BP + -0x10],AX (0170_1E72 / 0x3572)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], AX);
    CheckExternalEvents(cs2, 0x1E77);
    // JGE 0x0000:357a (0170_1E75 / 0x3575)
    if(SignFlag == OverflowFlag) {
      goto label_0170_1E7A_0357A;
    }
    CheckExternalEvents(cs2, 0x1E7A);
    // JMP 0x0000:3416 (0170_1E77 / 0x3577)
    goto label_0170_1D16_03416;
    label_0170_1E7A_0357A:
    CheckExternalEvents(cs2, 0x1E7E);
    // MOV ES,word ptr [0x538a] (0170_1E7A / 0x357A)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x1E84);
    // CMP byte ptr ES:[0xd346],0x0 (0170_1E7E / 0x357E)
    Alu.Sub8(UInt8[ES, 0xD346], 0x0);
    CheckExternalEvents(cs2, 0x1E86);
    // JNZ 0x0000:3589 (0170_1E84 / 0x3584)
    if(!ZeroFlag) {
      goto label_0170_1E89_03589;
    }
    CheckExternalEvents(cs2, 0x1E89);
    // JMP 0x0000:340c (0170_1E86 / 0x3586)
    goto label_0170_1D0C_0340C;
    label_0170_1E89_03589:
    CheckExternalEvents(cs2, 0x1E8C);
    // MOV SI,word ptr [BP + -0x12] (0170_1E89 / 0x3589)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0x1E8E);
    // SHL SI,0x1 (0170_1E8C / 0x358C)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x1E92);
    // MOV AX,word ptr [SI + 0x464] (0170_1E8E / 0x358E)
    AX = UInt16[DS, (ushort)(SI + 0x464)];
    CheckExternalEvents(cs2, 0x1E95);
    // ADD AX,word ptr [BP + 0x6] (0170_1E92 / 0x3592)
    // AX += UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs2, 0x1E99);
    // MOV ES,word ptr [0x538c] (0170_1E95 / 0x3595)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x1E9E);
    // ADD AX,word ptr ES:[0xa44b] (0170_1E99 / 0x3599)
    // AX += UInt16[ES, 0xA44B];
    AX = Alu.Add16(AX, UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs2, 0x1EA1);
    // MOV word ptr [BP + -0x2],AX (0170_1E9E / 0x359E)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs2, 0x1EA5);
    // MOV AX,word ptr [SI + 0x47c] (0170_1EA1 / 0x35A1)
    AX = UInt16[DS, (ushort)(SI + 0x47C)];
    CheckExternalEvents(cs2, 0x1EA8);
    // ADD AX,word ptr [BP + 0x8] (0170_1EA5 / 0x35A5)
    // AX += UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x1EAC);
    // MOV ES,word ptr [0x538e] (0170_1EA8 / 0x35A8)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x1EB1);
    // ADD AX,word ptr ES:[0xa44d] (0170_1EAC / 0x35AC)
    // AX += UInt16[ES, 0xA44D];
    AX = Alu.Add16(AX, UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs2, 0x1EB4);
    // MOV word ptr [BP + -0x6],AX (0170_1EB1 / 0x35B1)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs2, 0x1EB8);
    // MOV ES,word ptr [0x538a] (0170_1EB4 / 0x35B4)
    ES = UInt16[DS, 0x538A];
    CheckExternalEvents(cs2, 0x1EBE);
    // CMP byte ptr ES:[0xd34e],0x0 (0170_1EB8 / 0x35B8)
    Alu.Sub8(UInt8[ES, 0xD34E], 0x0);
    CheckExternalEvents(cs2, 0x1EC0);
    // JZ 0x0000:35c3 (0170_1EBE / 0x35BE)
    if(ZeroFlag) {
      goto label_0170_1EC3_035C3;
    }
    CheckExternalEvents(cs2, 0x1EC3);
    // JMP 0x0000:33d1 (0170_1EC0 / 0x35C0)
    goto label_0170_1CD1_033D1;
    label_0170_1EC3_035C3:
    CheckExternalEvents(cs2, 0x1EC7);
    // CMP word ptr [BP + -0x10],0x7e (0170_1EC3 / 0x35C3)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x7E);
    CheckExternalEvents(cs2, 0x1EC9);
    // JNZ 0x0000:35db (0170_1EC7 / 0x35C7)
    if(!ZeroFlag) {
      goto label_0170_1EDB_035DB;
    }
    CheckExternalEvents(cs2, 0x1ECC);
    // MOV AX,0xffff (0170_1EC9 / 0x35C9)
    AX = 0xFFFF;
    CheckExternalEvents(cs2, 0x1ECD);
    // PUSH AX (0170_1ECC / 0x35CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1ED0);
    // PUSH word ptr [BP + -0x6] (0170_1ECD / 0x35CD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1ED3);
    // PUSH word ptr [BP + -0x2] (0170_1ED0 / 0x35D0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x1ED8);
    // CALLF 0x0000:d786 (0170_1ED3 / 0x35D3)
    FarCall(cs2, 0x1ED8, ghidra_guess_0000_D786_0D786);
    CheckExternalEvents(cs2, 0x1EDB);
    // ADD SP,0x6 (0170_1ED8 / 0x35D8)
    SP += 0x6;
    label_0170_1EDB_035DB:
    CheckExternalEvents(cs2, 0x1EDF);
    // CMP word ptr [BP + -0x10],0x7f (0170_1EDB / 0x35DB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x7F);
    CheckExternalEvents(cs2, 0x1EE1);
    // JNZ 0x0000:35f6 (0170_1EDF / 0x35DF)
    if(!ZeroFlag) {
      goto label_0170_1EF6_035F6;
    }
    CheckExternalEvents(cs2, 0x1EE4);
    // MOV AX,0xffff (0170_1EE1 / 0x35E1)
    AX = 0xFFFF;
    CheckExternalEvents(cs2, 0x1EE5);
    // PUSH AX (0170_1EE4 / 0x35E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1EE8);
    // PUSH word ptr [BP + -0x6] (0170_1EE5 / 0x35E5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1EEB);
    // MOV AX,word ptr [BP + -0x2] (0170_1EE8 / 0x35E8)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x1EEC);
    // DEC AX (0170_1EEB / 0x35EB)
    AX--;
    CheckExternalEvents(cs2, 0x1EED);
    // DEC AX (0170_1EEC / 0x35EC)
    AX = Alu.Dec16(AX);
    CheckExternalEvents(cs2, 0x1EEE);
    // PUSH AX (0170_1EED / 0x35ED)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1EF3);
    // CALLF 0x0000:d786 (0170_1EEE / 0x35EE)
    FarCall(cs2, 0x1EF3, ghidra_guess_0000_D786_0D786);
    CheckExternalEvents(cs2, 0x1EF6);
    // ADD SP,0x6 (0170_1EF3 / 0x35F3)
    SP += 0x6;
    label_0170_1EF6_035F6:
    CheckExternalEvents(cs2, 0x1EFB);
    // CMP word ptr [BP + -0x10],0x80 (0170_1EF6 / 0x35F6)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x80);
    CheckExternalEvents(cs2, 0x1EFD);
    // JNZ 0x0000:3613 (0170_1EFB / 0x35FB)
    if(!ZeroFlag) {
      goto label_0170_1F13_03613;
    }
    CheckExternalEvents(cs2, 0x1F00);
    // MOV AX,0xffff (0170_1EFD / 0x35FD)
    AX = 0xFFFF;
    CheckExternalEvents(cs2, 0x1F01);
    // PUSH AX (0170_1F00 / 0x3600)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1F04);
    // PUSH word ptr [BP + -0x6] (0170_1F01 / 0x3601)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1F07);
    // MOV AX,word ptr [BP + -0x2] (0170_1F04 / 0x3604)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs2, 0x1F0A);
    // SUB AX,0x4 (0170_1F07 / 0x3607)
    // AX -= 0x4;
    AX = Alu.Sub16(AX, 0x4);
    CheckExternalEvents(cs2, 0x1F0B);
    // PUSH AX (0170_1F0A / 0x360A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x1F10);
    // CALLF 0x0000:d786 (0170_1F0B / 0x360B)
    FarCall(cs2, 0x1F10, ghidra_guess_0000_D786_0D786);
    CheckExternalEvents(cs2, 0x1F13);
    // ADD SP,0x6 (0170_1F10 / 0x3610)
    SP += 0x6;
    label_0170_1F13_03613:
    CheckExternalEvents(cs2, 0x1F18);
    // CMP word ptr [BP + -0x10],0xf5 (0170_1F13 / 0x3613)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xF5);
    CheckExternalEvents(cs2, 0x1F1A);
    // JNZ 0x0000:3634 (0170_1F18 / 0x3618)
    if(!ZeroFlag) {
      goto label_0170_1F34_03634;
    }
    CheckExternalEvents(cs2, 0x1F1F);
    // CMP word ptr [BP + -0x2],0xc01 (0170_1F1A / 0x361A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0xC01);
    CheckExternalEvents(cs2, 0x1F21);
    // JC 0x0000:3634 (0170_1F1F / 0x361F)
    if(CarryFlag) {
      goto label_0170_1F34_03634;
    }
    CheckExternalEvents(cs2, 0x1F26);
    // CMP word ptr [BP + -0x2],0xc04 (0170_1F21 / 0x3621)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0xC04);
    CheckExternalEvents(cs2, 0x1F28);
    // JA 0x0000:3634 (0170_1F26 / 0x3626)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0170_1F34_03634;
    }
    CheckExternalEvents(cs2, 0x1F2D);
    // CMP word ptr [BP + -0x6],0xc054 (0170_1F28 / 0x3628)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0xC054);
    CheckExternalEvents(cs2, 0x1F2F);
    // JNZ 0x0000:3634 (0170_1F2D / 0x362D)
    if(!ZeroFlag) {
      goto label_0170_1F34_03634;
    }
    CheckExternalEvents(cs2, 0x1F34);
    // CALLF 0x0000:ceb9 (0170_1F2F / 0x362F)
    FarCall(cs2, 0x1F34, ghidra_guess_0000_CEB9_0CEB9);
    label_0170_1F34_03634:
    CheckExternalEvents(cs2, 0x1F39);
    // CMP word ptr [BP + -0x10],0xb6 (0170_1F34 / 0x3634)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xB6);
    CheckExternalEvents(cs2, 0x1F3B);
    // JZ 0x0000:3642 (0170_1F39 / 0x3639)
    if(ZeroFlag) {
      goto label_0170_1F42_03642;
    }
    CheckExternalEvents(cs2, 0x1F40);
    // CMP word ptr [BP + -0x10],0xb7 (0170_1F3B / 0x363B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xB7);
    CheckExternalEvents(cs2, 0x1F42);
    // JNZ 0x0000:3650 (0170_1F40 / 0x3640)
    if(!ZeroFlag) {
      goto label_0170_1F50_03650;
    }
    label_0170_1F42_03642:
    CheckExternalEvents(cs2, 0x1F45);
    // PUSH word ptr [BP + -0x6] (0170_1F42 / 0x3642)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1F48);
    // PUSH word ptr [BP + -0x2] (0170_1F45 / 0x3645)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x1F4D);
    // CALLF 0x0000:d07a (0170_1F48 / 0x3648)
    FarCall(cs2, 0x1F4D, ghidra_guess_0000_D07A_0D07A);
    CheckExternalEvents(cs2, 0x1F50);
    // ADD SP,0x4 (0170_1F4D / 0x364D)
    SP += 0x4;
    label_0170_1F50_03650:
    CheckExternalEvents(cs2, 0x1F55);
    // CMP word ptr [BP + -0x10],0xf6 (0170_1F50 / 0x3650)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xF6);
    CheckExternalEvents(cs2, 0x1F57);
    // JL 0x0000:365c (0170_1F55 / 0x3655)
    if(SignFlag != OverflowFlag) {
      goto label_0170_1F5C_0365C;
    }
    CheckExternalEvents(cs2, 0x1F5C);
    // CALLF 0x0000:cf58 (0170_1F57 / 0x3657)
    FarCall(cs2, 0x1F5C, ghidra_guess_0000_CF58_0CF58);
    label_0170_1F5C_0365C:
    CheckExternalEvents(cs2, 0x1F61);
    // CMP word ptr [BP + -0x10],0x83 (0170_1F5C / 0x365C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x83);
    CheckExternalEvents(cs2, 0x1F63);
    // JZ 0x0000:3671 (0170_1F61 / 0x3661)
    if(ZeroFlag) {
      goto label_0170_1F71_03671;
    }
    CheckExternalEvents(cs2, 0x1F68);
    // CMP word ptr [BP + -0x10],0xa5 (0170_1F63 / 0x3663)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xA5);
    CheckExternalEvents(cs2, 0x1F6A);
    // JL 0x0000:3676 (0170_1F68 / 0x3668)
    if(SignFlag != OverflowFlag) {
      goto label_0170_1F76_03676;
    }
    CheckExternalEvents(cs2, 0x1F6F);
    // CMP word ptr [BP + -0x10],0xa7 (0170_1F6A / 0x366A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0xA7);
    CheckExternalEvents(cs2, 0x1F71);
    // JG 0x0000:3676 (0170_1F6F / 0x366F)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0170_1F76_03676;
    }
    label_0170_1F71_03671:
    CheckExternalEvents(cs2, 0x1F76);
    // CALLF 0x0000:cf78 (0170_1F71 / 0x3671)
    FarCall(cs2, 0x1F76, ghidra_guess_0000_CF78_0CF78);
    label_0170_1F76_03676:
    CheckExternalEvents(cs2, 0x1F7A);
    // CMP word ptr [BP + -0x10],0x4d (0170_1F76 / 0x3676)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x4D);
    CheckExternalEvents(cs2, 0x1F7C);
    // JNZ 0x0000:368a (0170_1F7A / 0x367A)
    if(!ZeroFlag) {
      goto label_0170_1F8A_0368A;
    }
    CheckExternalEvents(cs2, 0x1F7F);
    // PUSH word ptr [BP + -0x6] (0170_1F7C / 0x367C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1F82);
    // PUSH word ptr [BP + -0x2] (0170_1F7F / 0x367F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x1F87);
    // CALLF 0x0000:d17b (0170_1F82 / 0x3682)
    FarCall(cs2, 0x1F87, ghidra_guess_0000_D17B_0D17B);
    CheckExternalEvents(cs2, 0x1F8A);
    // ADD SP,0x4 (0170_1F87 / 0x3687)
    SP += 0x4;
    label_0170_1F8A_0368A:
    CheckExternalEvents(cs2, 0x1F8E);
    // CMP word ptr [BP + -0x10],0x3a (0170_1F8A / 0x368A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x3A);
    CheckExternalEvents(cs2, 0x1F90);
    // JZ 0x0000:3696 (0170_1F8E / 0x368E)
    if(ZeroFlag) {
      goto label_0170_1F96_03696;
    }
    CheckExternalEvents(cs2, 0x1F94);
    // CMP word ptr [BP + -0x10],0x3d (0170_1F90 / 0x3690)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x3D);
    CheckExternalEvents(cs2, 0x1F96);
    // JNZ 0x0000:36a4 (0170_1F94 / 0x3694)
    if(!ZeroFlag) {
      goto label_0170_1FA4_036A4;
    }
    label_0170_1F96_03696:
    CheckExternalEvents(cs2, 0x1F99);
    // PUSH word ptr [BP + -0x6] (0170_1F96 / 0x3696)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1F9C);
    // PUSH word ptr [BP + -0x2] (0170_1F99 / 0x3699)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x1FA1);
    // CALLF 0x0000:cfa2 (0170_1F9C / 0x369C)
    FarCall(cs2, 0x1FA1, ghidra_guess_0000_CFA2_0CFA2);
    CheckExternalEvents(cs2, 0x1FA4);
    // ADD SP,0x4 (0170_1FA1 / 0x36A1)
    SP += 0x4;
    label_0170_1FA4_036A4:
    CheckExternalEvents(cs2, 0x1FA8);
    // CMP word ptr [BP + -0x10],0x28 (0170_1FA4 / 0x36A4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], 0x28);
    CheckExternalEvents(cs2, 0x1FAA);
    // JZ 0x0000:36ad (0170_1FA8 / 0x36A8)
    if(ZeroFlag) {
      goto label_0170_1FAD_036AD;
    }
    CheckExternalEvents(cs2, 0x1FAD);
    // JMP 0x0000:340c (0170_1FAA / 0x36AA)
    goto label_0170_1D0C_0340C;
    label_0170_1FAD_036AD:
    CheckExternalEvents(cs2, 0x1FB0);
    // PUSH word ptr [BP + -0x6] (0170_1FAD / 0x36AD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs2, 0x1FB3);
    // PUSH word ptr [BP + -0x2] (0170_1FB0 / 0x36B0)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs2, 0x1FB8);
    // CALLF 0x0000:d22a (0170_1FB3 / 0x36B3)
    FarCall(cs2, 0x1FB8, ghidra_guess_0000_D22A_0D22A);
    CheckExternalEvents(cs2, 0x1FBB);
    // ADD SP,0x4 (0170_1FB8 / 0x36B8)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x1FBE);
    // JMP 0x0000:340c (0170_1FBB / 0x36BB)
    goto label_0170_1D0C_0340C;
    label_0170_1FBE_036BE:
    CheckExternalEvents(cs2, 0x1FC2);
    // CMP word ptr [BP + -0x4],0x0 (0170_1FBE / 0x36BE)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs2, 0x1FC4);
    // JZ 0x0000:36c7 (0170_1FC2 / 0x36C2)
    if(ZeroFlag) {
      goto label_0170_1FC7_036C7;
    }
    CheckExternalEvents(cs2, 0x1FC7);
    // JMP 0x0000:3886 (0170_1FC4 / 0x36C4)
    goto label_0170_2186_03886;
    label_0170_1FC7_036C7:
    CheckExternalEvents(cs2, 0x1FCC);
    // MOV word ptr [BP + -0x12],0x0 (0170_1FC7 / 0x36C7)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs2, 0x1FCF);
    // JMP 0x0000:37e9 (0170_1FCC / 0x36CC)
    goto label_0170_20E9_037E9;
    label_0170_1FCF_036CF:
    CheckExternalEvents(cs2, 0x1FD2);
    // MOV AL,byte ptr [BP + -0x8] (0170_1FCF / 0x36CF)
    AL = UInt8[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x1FD6);
    // MOV ES,word ptr [0x538c] (0170_1FD2 / 0x36D2)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x1FDB);
    // XOR AL,byte ptr ES:[0xa44b] (0170_1FD6 / 0x36D6)
    AL ^= UInt8[ES, 0xA44B];
    CheckExternalEvents(cs2, 0x1FDD);
    // TEST AL,0x1 (0170_1FDB / 0x36DB)
    Alu.And8(AL, 0x1);
    CheckExternalEvents(cs2, 0x1FDF);
    // JZ 0x0000:36e4 (0170_1FDD / 0x36DD)
    if(ZeroFlag) {
      goto label_0170_1FE4_036E4;
    }
    CheckExternalEvents(cs2, 0x1FE2);
    // DEC word ptr [BP + -0xc] (0170_1FDF / 0x36DF)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu.Dec16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs2, 0x1FE4);
    // JMP 0x0000:36e7 (0170_1FE2 / 0x36E2)
    goto label_0170_1FE7_036E7;
    label_0170_1FE4_036E4:
    CheckExternalEvents(cs2, 0x1FE7);
    // INC word ptr [BP + -0xc] (0170_1FE4 / 0x36E4)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0xC)]);
    label_0170_1FE7_036E7:
    CheckExternalEvents(cs2, 0x1FEB);
    // MOV ES,word ptr [0x5394] (0170_1FE7 / 0x36E7)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs2, 0x1FF0);
    // MOV BX,word ptr ES:[0x9ed] (0170_1FEB / 0x36EB)
    BX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs2, 0x1FF3);
    // ADD BX,word ptr [BP + -0xc] (0170_1FF0 / 0x36F0)
    // BX += UInt16[SS, (ushort)(BP - 0xC)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs2, 0x1FF7);
    // MOV ES,word ptr [0x5396] (0170_1FF3 / 0x36F3)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs2, 0x1FFC);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0170_1FF7 / 0x36F7)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs2, 0x1FFE);
    // SUB AH,AH (0170_1FFC / 0x36FC)
    AH -= AH;
    CheckExternalEvents(cs2, 0x2002);
    // CMP AX,word ptr [0x150] (0170_1FFE / 0x36FE)
    Alu.Sub16(AX, UInt16[DS, 0x150]);
    CheckExternalEvents(cs2, 0x2004);
    // JC 0x0000:3709 (0170_2002 / 0x3702)
    if(CarryFlag) {
      goto label_0170_2009_03709;
    }
    label_0170_2004_03704:
    CheckExternalEvents(cs2, 0x2009);
    // MOV word ptr [BP + -0x4],0x1 (0170_2004 / 0x3704)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x1;
    label_0170_2009_03709:
    CheckExternalEvents(cs2, 0x200D);
    // MOV ES,word ptr [0x5386] (0170_2009 / 0x3709)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0x2013);
    // CMP word ptr ES:[0xd55c],0x0 (0170_200D / 0x370D)
    Alu.Sub16(UInt16[ES, 0xD55C], 0x0);
    CheckExternalEvents(cs2, 0x2015);
    // JZ 0x0000:3718 (0170_2013 / 0x3713)
    if(ZeroFlag) {
      goto label_0170_2018_03718;
    }
    CheckExternalEvents(cs2, 0x2018);
    // JMP 0x0000:37db (0170_2015 / 0x3715)
    goto label_0170_20DB_037DB;
    label_0170_2018_03718:
    CheckExternalEvents(cs2, 0x201D);
    // MOV word ptr [BP + -0x14],0x0 (0170_2018 / 0x3718)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x0;
    label_0170_201D_0371D:
    CheckExternalEvents(cs2, 0x2020);
    // MOV SI,word ptr [BP + -0x14] (0170_201D / 0x371D)
    SI = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x2022);
    // SHL SI,0x1 (0170_2020 / 0x3720)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x2025);
    // MOV DI,word ptr [BP + -0x12] (0170_2022 / 0x3722)
    DI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0x2027);
    // SHL DI,0x1 (0170_2025 / 0x3725)
    // DI <<= 0x1;
    DI = Alu.Shl16(DI, 0x1);
    CheckExternalEvents(cs2, 0x202B);
    // MOV ES,word ptr [0x53a6] (0170_2027 / 0x3727)
    ES = UInt16[DS, 0x53A6];
    CheckExternalEvents(cs2, 0x2030);
    // MOV AX,word ptr ES:[DI + 0x4036] (0170_202B / 0x372B)
    AX = UInt16[ES, (ushort)(DI + 0x4036)];
    CheckExternalEvents(cs2, 0x2033);
    // ADD AX,word ptr [BP + 0x8] (0170_2030 / 0x3730)
    // AX += UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs2, 0x2037);
    // MOV ES,word ptr [0x53cc] (0170_2033 / 0x3733)
    ES = UInt16[DS, 0x53CC];
    CheckExternalEvents(cs2, 0x203C);
    // CMP AX,word ptr ES:[SI + 0x4596] (0170_2037 / 0x3737)
    Alu.Sub16(AX, UInt16[ES, (ushort)(SI + 0x4596)]);
    CheckExternalEvents(cs2, 0x203E);
    // JZ 0x0000:3741 (0170_203C / 0x373C)
    if(ZeroFlag) {
      goto label_0170_2041_03741;
    }
    CheckExternalEvents(cs2, 0x2041);
    // JMP 0x0000:37cf (0170_203E / 0x373E)
    goto label_0170_20CF_037CF;
    label_0170_2041_03741:
    CheckExternalEvents(cs2, 0x2045);
    // MOV ES,word ptr [0x53a4] (0170_2041 / 0x3741)
    ES = UInt16[DS, 0x53A4];
    CheckExternalEvents(cs2, 0x204A);
    // MOV AX,word ptr ES:[DI + 0x4004] (0170_2045 / 0x3745)
    AX = UInt16[ES, (ushort)(DI + 0x4004)];
    CheckExternalEvents(cs2, 0x204D);
    // ADD AX,word ptr [BP + 0x6] (0170_204A / 0x374A)
    // AX += UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs2, 0x2050);
    // MOV word ptr [BP + -0xe],AX (0170_204D / 0x374D)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs2, 0x2054);
    // MOV ES,word ptr [0x53ca] (0170_2050 / 0x3750)
    ES = UInt16[DS, 0x53CA];
    CheckExternalEvents(cs2, 0x2059);
    // CMP word ptr ES:[SI + 0x4564],AX (0170_2054 / 0x3754)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x4564)], AX);
    CheckExternalEvents(cs2, 0x205B);
    // JZ 0x0000:376e (0170_2059 / 0x3759)
    if(ZeroFlag) {
      goto label_0170_206E_0376E;
    }
    CheckExternalEvents(cs2, 0x205C);
    // DEC AX (0170_205B / 0x375B)
    AX--;
    CheckExternalEvents(cs2, 0x2061);
    // CMP word ptr ES:[SI + 0x4564],AX (0170_205C / 0x375C)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x4564)], AX);
    CheckExternalEvents(cs2, 0x2063);
    // JZ 0x0000:376e (0170_2061 / 0x3761)
    if(ZeroFlag) {
      goto label_0170_206E_0376E;
    }
    CheckExternalEvents(cs2, 0x2066);
    // MOV AX,word ptr [BP + -0xe] (0170_2063 / 0x3763)
    AX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs2, 0x2067);
    // INC AX (0170_2066 / 0x3766)
    AX++;
    CheckExternalEvents(cs2, 0x206C);
    // CMP word ptr ES:[SI + 0x4564],AX (0170_2067 / 0x3767)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x4564)], AX);
    CheckExternalEvents(cs2, 0x206E);
    // JNZ 0x0000:37cf (0170_206C / 0x376C)
    if(!ZeroFlag) {
      goto label_0170_20CF_037CF;
    }
    label_0170_206E_0376E:
    CheckExternalEvents(cs2, 0x2072);
    // MOV ES,word ptr [0x5386] (0170_206E / 0x376E)
    ES = UInt16[DS, 0x5386];
    CheckExternalEvents(cs2, 0x2079);
    // MOV word ptr ES:[0xd55c],0x1 (0170_2072 / 0x3772)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs2, 0x207E);
    // CALLF 0x1000:7bf6 (0170_2079 / 0x3779)
    FarCall(cs2, 0x207E, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs2, 0x2081);
    // MOV AX,0x446 (0170_207E / 0x377E)
    AX = 0x446;
    CheckExternalEvents(cs2, 0x2082);
    // PUSH DS (0170_2081 / 0x3781)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x2083);
    // PUSH AX (0170_2082 / 0x3782)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x2088);
    // CALLF 0x1000:8055 (0170_2083 / 0x3783)
    FarCall(cs2, 0x2088, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x208B);
    // ADD SP,0x4 (0170_2088 / 0x3788)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x208E);
    // MOV BX,word ptr [BP + -0x14] (0170_208B / 0x378B)
    BX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs2, 0x2090);
    // MOV CL,0x4 (0170_208E / 0x378E)
    CL = 0x4;
    CheckExternalEvents(cs2, 0x2092);
    // SHL BX,CL (0170_2090 / 0x3790)
    // BX <<= CL;
    BX = Alu.Shl16(BX, CL);
    CheckExternalEvents(cs2, 0x2096);
    // LEA AX,[BX + 0xa561] (0170_2092 / 0x3792)
    AX = (ushort)(BX + 0xA561);
    CheckExternalEvents(cs2, 0x2099);
    // MOV DX,0x1ddc (0170_2096 / 0x3796)
    DX = 0x1DDC;
    CheckExternalEvents(cs2, 0x209A);
    // PUSH DX (0170_2099 / 0x3799)
    Stack.Push16(DX);
    CheckExternalEvents(cs2, 0x209B);
    // PUSH AX (0170_209A / 0x379A)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x20A0);
    // CALLF 0x1000:8055 (0170_209B / 0x379B)
    FarCall(cs2, 0x20A0, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x20A3);
    // ADD SP,0x4 (0170_20A0 / 0x37A0)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x20A6);
    // MOV AX,0x45a (0170_20A3 / 0x37A3)
    AX = 0x45A;
    CheckExternalEvents(cs2, 0x20A7);
    // PUSH DS (0170_20A6 / 0x37A6)
    Stack.Push16(DS);
    CheckExternalEvents(cs2, 0x20A8);
    // PUSH AX (0170_20A7 / 0x37A7)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x20AD);
    // CALLF 0x1000:8055 (0170_20A8 / 0x37A8)
    FarCall(cs2, 0x20AD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs2, 0x20B0);
    // ADD SP,0x4 (0170_20AD / 0x37AD)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs2, 0x20B3);
    // MOV AX,0x1 (0170_20B0 / 0x37B0)
    AX = 0x1;
    CheckExternalEvents(cs2, 0x20B4);
    // PUSH AX (0170_20B3 / 0x37B3)
    Stack.Push16(AX);
    CheckExternalEvents(cs2, 0x20B5);
    // PUSH CS (0170_20B4 / 0x37B4)
    Stack.Push16(cs2);
    CheckExternalEvents(cs2, 0x20B8);
    // CALL 0x0000:3113 (0170_20B5 / 0x37B5)
    NearCall(cs2, 0x20B8, unknown_0170_1A13_03113);
    CheckExternalEvents(cs2, 0x20BB);
    // ADD SP,0x2 (0170_20B8 / 0x37B8)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs2, 0x20BD);
    // OR AX,AX (0170_20BB / 0x37BB)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs2, 0x20BF);
    // JZ 0x0000:37ca (0170_20BD / 0x37BD)
    if(ZeroFlag) {
      goto label_0170_20CA_037CA;
    }
    CheckExternalEvents(cs2, 0x20C2);
    // PUSH word ptr [BP + -0x14] (0170_20BF / 0x37BF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs2, 0x20C7);
    // CALLF 0x0000:94c8 (0170_20C2 / 0x37C2)
    FarCall(cs2, 0x20C7, unknown_094C_0008_094C8);
    CheckExternalEvents(cs2, 0x20CA);
    // ADD SP,0x2 (0170_20C7 / 0x37C7)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0170_20CA_037CA:
    CheckExternalEvents(cs2, 0x20CF);
    // MOV word ptr [BP + -0x14],0x64 (0170_20CA / 0x37CA)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x64;
    label_0170_20CF_037CF:
    CheckExternalEvents(cs2, 0x20D2);
    // INC word ptr [BP + -0x14] (0170_20CF / 0x37CF)
    UInt16[SS, (ushort)(BP - 0x14)]++;
    CheckExternalEvents(cs2, 0x20D6);
    // CMP word ptr [BP + -0x14],0xc (0170_20D2 / 0x37D2)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x14)], 0xC);
    CheckExternalEvents(cs2, 0x20D8);
    // JGE 0x0000:37db (0170_20D6 / 0x37D6)
    if(SignFlag == OverflowFlag) {
      goto label_0170_20DB_037DB;
    }
    CheckExternalEvents(cs2, 0x20DB);
    // JMP 0x0000:371d (0170_20D8 / 0x37D8)
    goto label_0170_201D_0371D;
    label_0170_20DB_037DB:
    CheckExternalEvents(cs2, 0x20DF);
    // CMP word ptr [BP + -0x4],0x0 (0170_20DB / 0x37DB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x0);
    CheckExternalEvents(cs2, 0x20E1);
    // JZ 0x0000:37e6 (0170_20DF / 0x37DF)
    if(ZeroFlag) {
      goto label_0170_20E6_037E6;
    }
    CheckExternalEvents(cs2, 0x20E6);
    // MOV word ptr [BP + -0x12],0x8 (0170_20E1 / 0x37E1)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x8;
    label_0170_20E6_037E6:
    CheckExternalEvents(cs2, 0x20E9);
    // INC word ptr [BP + -0x12] (0170_20E6 / 0x37E6)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    label_0170_20E9_037E9:
    CheckExternalEvents(cs2, 0x20ED);
    // CMP word ptr [BP + -0x12],0x4 (0170_20E9 / 0x37E9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], 0x4);
    CheckExternalEvents(cs2, 0x20EF);
    // JL 0x0000:37f2 (0170_20ED / 0x37ED)
    if(SignFlag != OverflowFlag) {
      goto label_0170_20F2_037F2;
    }
    CheckExternalEvents(cs2, 0x20F2);
    // JMP 0x0000:3886 (0170_20EF / 0x37EF)
    goto label_0170_2186_03886;
    label_0170_20F2_037F2:
    CheckExternalEvents(cs2, 0x20F5);
    // MOV SI,word ptr [BP + -0x12] (0170_20F2 / 0x37F2)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs2, 0x20F7);
    // SHL SI,0x1 (0170_20F5 / 0x37F5)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs2, 0x20FB);
    // MOV ES,word ptr [0x5392] (0170_20F7 / 0x37F7)
    ES = UInt16[DS, 0x5392];
    CheckExternalEvents(cs2, 0x2101);
    // CMP word ptr ES:[SI + 0x406a],0x0 (0170_20FB / 0x37FB)
    Alu.Sub16(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs2, 0x2103);
    // JZ 0x0000:37e6 (0170_2101 / 0x3801)
    if(ZeroFlag) {
      goto label_0170_20E6_037E6;
    }
    CheckExternalEvents(cs2, 0x2107);
    // MOV AX,word ptr [SI + 0x45c] (0170_2103 / 0x3803)
    AX = UInt16[DS, (ushort)(SI + 0x45C)];
    CheckExternalEvents(cs2, 0x210A);
    // ADD AX,word ptr [BP + 0x6] (0170_2107 / 0x3807)
    AX += UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs2, 0x210D);
    // ADD AX,0x1a (0170_210A / 0x380A)
    // AX += 0x1A;
    AX = Alu.Add16(AX, 0x1A);
    CheckExternalEvents(cs2, 0x2110);
    // MOV word ptr [BP + -0x8],AX (0170_210D / 0x380D)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs2, 0x2114);
    // MOV AX,word ptr [SI + 0x474] (0170_2110 / 0x3810)
    AX = UInt16[DS, (ushort)(SI + 0x474)];
    CheckExternalEvents(cs2, 0x2117);
    // ADD AX,word ptr [BP + 0x8] (0170_2114 / 0x3814)
    AX += UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs2, 0x211A);
    // ADD AX,0xc (0170_2117 / 0x3817)
    // AX += 0xC;
    AX = Alu.Add16(AX, 0xC);
    CheckExternalEvents(cs2, 0x211D);
    // MOV word ptr [BP + -0xa],AX (0170_211A / 0x381A)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs2, 0x211F);
    // MOV BX,AX (0170_211D / 0x381D)
    BX = AX;
    CheckExternalEvents(cs2, 0x2122);
    // AND BL,0xfe (0170_211F / 0x381F)
    // BL &= 0xFE;
    BL = Alu.And8(BL, 0xFE);
    CheckExternalEvents(cs2, 0x2126);
    // MOV AX,word ptr [BX + 0x48c] (0170_2122 / 0x3822)
    AX = UInt16[DS, (ushort)(BX + 0x48C)];
    CheckExternalEvents(cs2, 0x2129);
    // MOV CX,word ptr [BP + -0x8] (0170_2126 / 0x3826)
    CX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs2, 0x212C);
    // SUB CX,0xd (0170_2129 / 0x3829)
    CX -= 0xD;
    CheckExternalEvents(cs2, 0x212E);
    // SAR CX,0x1 (0170_212C / 0x382C)
    CX = Alu.Sar16(CX, 0x1);
    CheckExternalEvents(cs2, 0x2130);
    // ADD AX,CX (0170_212E / 0x382E)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs2, 0x2133);
    // MOV word ptr [BP + -0xc],AX (0170_2130 / 0x3830)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs2, 0x2137);
    // TEST byte ptr [BP + -0x8],0x1 (0170_2133 / 0x3833)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x8)], 0x1);
    CheckExternalEvents(cs2, 0x2139);
    // JNZ 0x0000:3848 (0170_2137 / 0x3837)
    if(!ZeroFlag) {
      goto label_0170_2148_03848;
    }
    CheckExternalEvents(cs2, 0x213D);
    // MOV ES,word ptr [0x538c] (0170_2139 / 0x3839)
    ES = UInt16[DS, 0x538C];
    CheckExternalEvents(cs2, 0x2143);
    // TEST byte ptr ES:[0xa44b],0x1 (0170_213D / 0x383D)
    Alu.And8(UInt8[ES, 0xA44B], 0x1);
    CheckExternalEvents(cs2, 0x2145);
    // JZ 0x0000:3848 (0170_2143 / 0x3843)
    if(ZeroFlag) {
      goto label_0170_2148_03848;
    }
    CheckExternalEvents(cs2, 0x2148);
    // INC word ptr [BP + -0xc] (0170_2145 / 0x3845)
    UInt16[SS, (ushort)(BP - 0xC)]++;
    label_0170_2148_03848:
    CheckExternalEvents(cs2, 0x214C);
    // TEST byte ptr [BP + -0xa],0x1 (0170_2148 / 0x3848)
    Alu.And8(UInt8[SS, (ushort)(BP - 0xA)], 0x1);
    CheckExternalEvents(cs2, 0x214E);
    // JZ 0x0000:385e (0170_214C / 0x384C)
    if(ZeroFlag) {
      goto label_0170_215E_0385E;
    }
    CheckExternalEvents(cs2, 0x2152);
    // MOV ES,word ptr [0x538e] (0170_214E / 0x384E)
    ES = UInt16[DS, 0x538E];
    CheckExternalEvents(cs2, 0x2158);
    // TEST byte ptr ES:[0xa44d],0x1 (0170_2152 / 0x3852)
    Alu.And8(UInt8[ES, 0xA44D], 0x1);
    CheckExternalEvents(cs2, 0x215A);
    // JZ 0x0000:385e (0170_2158 / 0x3858)
    if(ZeroFlag) {
      goto label_0170_215E_0385E;
    }
    CheckExternalEvents(cs2, 0x215E);
    // ADD word ptr [BP + -0xc],0x18 (0170_215A / 0x385A)
    // UInt16[SS, (ushort)(BP - 0xC)] += 0x18;
    UInt16[SS, (ushort)(BP - 0xC)] = Alu.Add16(UInt16[SS, (ushort)(BP - 0xC)], 0x18);
    label_0170_215E_0385E:
    CheckExternalEvents(cs2, 0x2162);
    // MOV ES,word ptr [0x5394] (0170_215E / 0x385E)
    ES = UInt16[DS, 0x5394];
    CheckExternalEvents(cs2, 0x2167);
    // MOV BX,word ptr ES:[0x9ed] (0170_2162 / 0x3862)
    BX = UInt16[ES, 0x9ED];
    CheckExternalEvents(cs2, 0x216A);
    // ADD BX,word ptr [BP + -0xc] (0170_2167 / 0x3867)
    // BX += UInt16[SS, (ushort)(BP - 0xC)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs2, 0x216E);
    // MOV ES,word ptr [0x5396] (0170_216A / 0x386A)
    ES = UInt16[DS, 0x5396];
    CheckExternalEvents(cs2, 0x2173);
    // MOV AL,byte ptr ES:[BX + 0x7ad] (0170_216E / 0x386E)
    AL = UInt8[ES, (ushort)(BX + 0x7AD)];
    CheckExternalEvents(cs2, 0x2175);
    // SUB AH,AH (0170_2173 / 0x3873)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs2, 0x2178);
    // MOV word ptr [BP + -0x10],AX (0170_2175 / 0x3875)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs2, 0x217B);
    // MOV AX,[0x150] (0170_2178 / 0x3878)
    AX = UInt16[DS, 0x150];
    CheckExternalEvents(cs2, 0x217E);
    // CMP word ptr [BP + -0x10],AX (0170_217B / 0x387B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x10)], AX);
    CheckExternalEvents(cs2, 0x2180);
    // JGE 0x0000:3883 (0170_217E / 0x387E)
    if(SignFlag == OverflowFlag) {
      // JGE target is JMP, inlining.
      CheckExternalEvents(cs2, 0x2186);
      // JMP 0x0000:3704 (0170_2183 / 0x3883)
      goto label_0170_2004_03704;
    }
    CheckExternalEvents(cs2, 0x2183);
    // JMP 0x0000:36cf (0170_2180 / 0x3880)
    goto label_0170_1FCF_036CF;
    label_0170_2183_03883:
    CheckExternalEvents(cs2, 0x2186);
    // JMP 0x0000:3704 (0170_2183 / 0x3883)
    goto label_0170_2004_03704;
    label_0170_2186_03886:
    CheckExternalEvents(cs2, 0x2189);
    // MOV AX,word ptr [BP + -0x4] (0170_2186 / 0x3886)
    AX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs2, 0x218A);
    // POP SI (0170_2189 / 0x3889)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x218B);
    // POP DI (0170_218A / 0x388A)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x218D);
    // MOV SP,BP (0170_218B / 0x388B)
    SP = BP;
    CheckExternalEvents(cs2, 0x218E);
    // POP BP (0170_218D / 0x388D)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs2, 0x218F);
    // RETF  (0170_218E / 0x388E)
    return FarRet();
  }
  
}
