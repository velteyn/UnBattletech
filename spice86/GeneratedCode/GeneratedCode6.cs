using Spice86.Core.Emulator.CPU;

namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_0000_8617_08617(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_8617_08617:
    CheckExternalEvents(cs1, 0x8618);
    // PUSH BP (0000_8617 / 0x8617)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x861A);
    // MOV BP,SP (0000_8618 / 0x8618)
    BP = SP;
    CheckExternalEvents(cs1, 0x861D);
    // MOV AX,0x36 (0000_861A / 0x861A)
    AX = 0x36;
    CheckExternalEvents(cs1, 0x8622);
    // CALLF 0x1000:cecc (0000_861D / 0x861D)
    FarCall(cs1, 0x8622, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x8623);
    // PUSH DI (0000_8622 / 0x8622)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0x8624);
    // PUSH SI (0000_8623 / 0x8623)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x8629);
    // MOV word ptr [BP + -0x1a],0x8 (0000_8624 / 0x8624)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x8;
    CheckExternalEvents(cs1, 0x862D);
    // MOV ES,word ptr [0x5426] (0000_8629 / 0x8629)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8633);
    // CMP word ptr ES:[0x4fba],0x0 (0000_862D / 0x862D)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8635);
    // JNZ 0x0000:863a (0000_8633 / 0x8633)
    if(!ZeroFlag) {
      goto label_0000_863A_0863A;
    }
    CheckExternalEvents(cs1, 0x863A);
    // MOV word ptr [BP + -0x1a],0x2 (0000_8635 / 0x8635)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x2;
    label_0000_863A_0863A:
    CheckExternalEvents(cs1, 0x863D);
    // MOV AX,word ptr [BP + 0x8] (0000_863A / 0x863A)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x8640);
    // MOV word ptr [BP + -0x20],AX (0000_863D / 0x863D)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs1, 0x8644);
    // CMP word ptr [BP + 0xa],0x0 (0000_8640 / 0x8640)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0x8646);
    // JNZ 0x0000:864a (0000_8644 / 0x8644)
    if(!ZeroFlag) {
      goto label_0000_864A_0864A;
    }
    CheckExternalEvents(cs1, 0x864A);
    // ADD word ptr [BP + -0x20],0x4 (0000_8646 / 0x8646)
    UInt16[SS, (ushort)(BP - 0x20)] += 0x4;
    label_0000_864A_0864A:
    CheckExternalEvents(cs1, 0x864C);
    // SUB AX,AX (0000_864A / 0x864A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x864F);
    // MOV word ptr [BP + -0x10],AX (0000_864C / 0x864C)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x8652);
    // MOV word ptr [BP + -0x12],AX (0000_864F / 0x864F)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    label_0000_8652_08652:
    CheckExternalEvents(cs1, 0x8655);
    // MOV SI,word ptr [BP + -0x20] (0000_8652 / 0x8652)
    SI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x8657);
    // SHL SI,0x1 (0000_8655 / 0x8655)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0x865B);
    // MOV ES,word ptr [0x542e] (0000_8657 / 0x8657)
    ES = UInt16[DS, 0x542E];
    CheckExternalEvents(cs1, 0x8661);
    // CMP word ptr ES:[SI + 0x406a],0x0 (0000_865B / 0x865B)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x406A)], 0x0);
    CheckExternalEvents(cs1, 0x8663);
    // JNZ 0x0000:8666 (0000_8661 / 0x8661)
    if(!ZeroFlag) {
      goto label_0000_8666_08666;
    }
    CheckExternalEvents(cs1, 0x8666);
    // JMP 0x0000:8889 (0000_8663 / 0x8663)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_0000_8809_08809, 0x8889 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_8666_08666:
    CheckExternalEvents(cs1, 0x866A);
    // MOV ES,word ptr [0x5432] (0000_8666 / 0x8666)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x8670);
    // CMP word ptr ES:[SI + 0x4004],-0x1 (0000_866A / 0x866A)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4004)], 0xFFFF);
    CheckExternalEvents(cs1, 0x8672);
    // JNZ 0x0000:8675 (0000_8670 / 0x8670)
    if(!ZeroFlag) {
      goto label_0000_8675_08675;
    }
    CheckExternalEvents(cs1, 0x8675);
    // JMP 0x0000:8889 (0000_8672 / 0x8672)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_0000_8809_08809, 0x8889 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_8675_08675:
    CheckExternalEvents(cs1, 0x8679);
    // MOV ES,word ptr [0x5430] (0000_8675 / 0x8675)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x867F);
    // CMP word ptr ES:[SI + 0x4036],-0x1 (0000_8679 / 0x8679)
    Alu16.Sub(UInt16[ES, (ushort)(SI + 0x4036)], 0xFFFF);
    CheckExternalEvents(cs1, 0x8681);
    // JNZ 0x0000:8684 (0000_867F / 0x867F)
    if(!ZeroFlag) {
      goto label_0000_8684_08684;
    }
    CheckExternalEvents(cs1, 0x8684);
    // JMP 0x0000:8889 (0000_8681 / 0x8681)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_0000_8809_08809, 0x8889 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_8684_08684:
    CheckExternalEvents(cs1, 0x8687);
    // MOV AX,0x4 (0000_8684 / 0x8684)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x8688);
    // PUSH AX (0000_8687 / 0x8687)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x868D);
    // CALLF 0x1000:7ee1 (0000_8688 / 0x8688)
    FarCall(cs1, 0x868D, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x8690);
    // ADD SP,0x2 (0000_868D / 0x868D)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x8695);
    // CALLF 0x1000:7fe8 (0000_8690 / 0x8690)
    FarCall(cs1, 0x8695, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x8699);
    // MOV ES,word ptr [0x541e] (0000_8695 / 0x8695)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x86A0);
    // MOV word ptr ES:[0x37fe],0xf (0000_8699 / 0x8699)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x86A4);
    // CMP word ptr [BP + -0x20],0xc (0000_86A0 / 0x86A0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0xC);
    CheckExternalEvents(cs1, 0x86A6);
    // JGE 0x0000:86b8 (0000_86A4 / 0x86A4)
    if(SignFlag == OverflowFlag) {
      goto label_0000_86B8_086B8;
    }
    CheckExternalEvents(cs1, 0x86A9);
    // MOV AX,0x1 (0000_86A6 / 0x86A6)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x86AA);
    // PUSH AX (0000_86A9 / 0x86A9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x86AB);
    // PUSH AX (0000_86AA / 0x86AA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x86AE);
    // PUSH word ptr [BP + -0x20] (0000_86AB / 0x86AB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x86AF);
    // PUSH CS (0000_86AE / 0x86AE)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x86B2);
    // CALL 0x0000:8a98 (0000_86AF / 0x86AF)
    NearCall(cs1, 0x86B2, ghidra_guess_0000_8A98_08A98);
    CheckExternalEvents(cs1, 0x86B5);
    // ADD SP,0x6 (0000_86B2 / 0x86B2)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs1, 0x86B8);
    // JMP 0x0000:87c0 (0000_86B5 / 0x86B5)
    goto label_0000_87C0_087C0;
    label_0000_86B8_086B8:
    CheckExternalEvents(cs1, 0x86BC);
    // CMP word ptr [BP + -0x20],0x10 (0000_86B8 / 0x86B8)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x10);
    CheckExternalEvents(cs1, 0x86BE);
    // JGE 0x0000:86dc (0000_86BC / 0x86BC)
    if(SignFlag == OverflowFlag) {
      goto label_0000_86DC_086DC;
    }
    CheckExternalEvents(cs1, 0x86C1);
    // MOV AX,0x1148 (0000_86BE / 0x86BE)
    AX = 0x1148;
    CheckExternalEvents(cs1, 0x86C2);
    // PUSH DS (0000_86C1 / 0x86C1)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x86C3);
    // PUSH AX (0000_86C2 / 0x86C2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x86C8);
    // CALLF 0x1000:8055 (0000_86C3 / 0x86C3)
    FarCall(cs1, 0x86C8, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x86CB);
    // ADD SP,0x4 (0000_86C8 / 0x86C8)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x86CE);
    // MOV AX,0x7d (0000_86CB / 0x86CB)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x86D1);
    // IMUL word ptr [BP + -0x20] (0000_86CE / 0x86CE)
    int resImul0000_86CE = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_86CE);
    DX = (ushort)(resImul0000_86CE >> 16);
    CheckExternalEvents(cs1, 0x86D3);
    // MOV BX,AX (0000_86D1 / 0x86D1)
    BX = AX;
    CheckExternalEvents(cs1, 0x86D7);
    // LEA AX,[BX + 0xc33c] (0000_86D3 / 0x86D3)
    AX = (ushort)(BX + 0xC33C);
    CheckExternalEvents(cs1, 0x86DA);
    // MOV DX,0x2a02 (0000_86D7 / 0x86D7)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x86DC);
    // JMP 0x0000:8752 (0000_86DA / 0x86DA)
    goto label_0000_8752_08752;
    label_0000_86DC_086DC:
    CheckExternalEvents(cs1, 0x86DF);
    // MOV AX,0x114f (0000_86DC / 0x86DC)
    AX = 0x114F;
    CheckExternalEvents(cs1, 0x86E0);
    // PUSH DS (0000_86DF / 0x86DF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x86E1);
    // PUSH AX (0000_86E0 / 0x86E0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x86E6);
    // CALLF 0x1000:8055 (0000_86E1 / 0x86E1)
    FarCall(cs1, 0x86E6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x86E9);
    // ADD SP,0x4 (0000_86E6 / 0x86E6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x86EC);
    // MOV AX,word ptr [BP + -0x20] (0000_86E9 / 0x86E9)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x86EF);
    // SUB AX,0x8 (0000_86EC / 0x86EC)
    // AX -= 0x8;
    AX = Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs1, 0x86F0);
    // PUSH AX (0000_86EF / 0x86EF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x86F5);
    // CALLF 0x0000:fcf4 (0000_86F0 / 0x86F0)
    FarCall(cs1, 0x86F5, ghidra_guess_0000_FCF4_0FCF4);
    CheckExternalEvents(cs1, 0x86F8);
    // ADD SP,0x2 (0000_86F5 / 0x86F5)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x86FC);
    // MOV ES,word ptr [0x5444] (0000_86F8 / 0x86F8)
    ES = UInt16[DS, 0x5444];
    CheckExternalEvents(cs1, 0x8703);
    // MOV word ptr ES:[0x3748],0x0 (0000_86FC / 0x86FC)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0x8707);
    // MOV ES,word ptr [0x5446] (0000_8703 / 0x8703)
    ES = UInt16[DS, 0x5446];
    CheckExternalEvents(cs1, 0x870E);
    // MOV word ptr ES:[0x374e],0x7 (0000_8707 / 0x8707)
    UInt16[ES, 0x374E] = 0x7;
    CheckExternalEvents(cs1, 0x8713);
    // CALLF 0x0000:3fa2 (0000_870E / 0x870E)
    FarCall(cs1, 0x8713, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x8716);
    // MOV AX,0x115b (0000_8713 / 0x8713)
    AX = 0x115B;
    CheckExternalEvents(cs1, 0x8717);
    // PUSH DS (0000_8716 / 0x8716)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8718);
    // PUSH AX (0000_8717 / 0x8717)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x871D);
    // CALLF 0x1000:8055 (0000_8718 / 0x8718)
    FarCall(cs1, 0x871D, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8720);
    // ADD SP,0x4 (0000_871D / 0x871D)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8724);
    // MOV ES,word ptr [0x5444] (0000_8720 / 0x8720)
    ES = UInt16[DS, 0x5444];
    CheckExternalEvents(cs1, 0x872B);
    // MOV word ptr ES:[0x3748],0x0 (0000_8724 / 0x8724)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0x872F);
    // MOV ES,word ptr [0x5446] (0000_872B / 0x872B)
    ES = UInt16[DS, 0x5446];
    CheckExternalEvents(cs1, 0x8736);
    // MOV word ptr ES:[0x374e],0x8 (0000_872F / 0x872F)
    UInt16[ES, 0x374E] = 0x8;
    CheckExternalEvents(cs1, 0x8739);
    // MOV AX,0x11 (0000_8736 / 0x8736)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x873C);
    // IMUL word ptr [BP + -0x20] (0000_8739 / 0x8739)
    int resImul0000_8739 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x20)]);
    AX = (ushort)(resImul0000_8739);
    DX = (ushort)(resImul0000_8739 >> 16);
    CheckExternalEvents(cs1, 0x873E);
    // MOV BX,AX (0000_873C / 0x873C)
    BX = AX;
    CheckExternalEvents(cs1, 0x8742);
    // MOV ES,word ptr [0x5412] (0000_873E / 0x873E)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8744);
    // MOV AL,0x11 (0000_8742 / 0x8742)
    AL = 0x11;
    CheckExternalEvents(cs1, 0x8749);
    // IMUL byte ptr ES:[BX + 0xc597] (0000_8744 / 0x8744)
    short resImul0000_8744 = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC597)]);
    AL = (byte)(resImul0000_8744);
    AH = (byte)(resImul0000_8744 >> 8);
    CheckExternalEvents(cs1, 0x874B);
    // MOV BX,AX (0000_8749 / 0x8749)
    BX = AX;
    CheckExternalEvents(cs1, 0x874F);
    // LEA AX,[BX + 0x2ed8] (0000_874B / 0x874B)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0x8752);
    // MOV DX,0x384b (0000_874F / 0x874F)
    DX = 0x384B;
    label_0000_8752_08752:
    CheckExternalEvents(cs1, 0x8753);
    // PUSH DX (0000_8752 / 0x8752)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8754);
    // PUSH AX (0000_8753 / 0x8753)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8759);
    // CALLF 0x1000:8055 (0000_8754 / 0x8754)
    FarCall(cs1, 0x8759, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x875C);
    // ADD SP,0x4 (0000_8759 / 0x8759)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8761);
    // CALLF 0x0000:3fa2 (0000_875C / 0x875C)
    FarCall(cs1, 0x8761, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x8764);
    // MOV AX,0x1166 (0000_8761 / 0x8761)
    AX = 0x1166;
    CheckExternalEvents(cs1, 0x8765);
    // PUSH DS (0000_8764 / 0x8764)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8766);
    // PUSH AX (0000_8765 / 0x8765)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x876B);
    // CALLF 0x1000:8055 (0000_8766 / 0x8766)
    FarCall(cs1, 0x876B, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x876E);
    // ADD SP,0x4 (0000_876B / 0x876B)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8771);
    // MOV SI,word ptr [BP + 0x6] (0000_876E / 0x876E)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x8773);
    // SHL SI,0x1 (0000_8771 / 0x8771)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0x8776);
    // MOV DI,word ptr [BP + -0x20] (0000_8773 / 0x8773)
    DI = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs1, 0x8778);
    // SHL DI,0x1 (0000_8776 / 0x8776)
    // DI <<= 0x1;
    DI = Alu16.Shl(DI, 0x1);
    CheckExternalEvents(cs1, 0x877C);
    // MOV ES,word ptr [0x5430] (0000_8778 / 0x8778)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x8781);
    // PUSH word ptr ES:[DI + 0x4036] (0000_877C / 0x877C)
    Stack.Push16(UInt16[ES, (ushort)(DI + 0x4036)]);
    CheckExternalEvents(cs1, 0x8785);
    // MOV ES,word ptr [0x5432] (0000_8781 / 0x8781)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x878A);
    // PUSH word ptr ES:[DI + 0x4004] (0000_8785 / 0x8785)
    Stack.Push16(UInt16[ES, (ushort)(DI + 0x4004)]);
    CheckExternalEvents(cs1, 0x878E);
    // MOV ES,word ptr [0x5430] (0000_878A / 0x878A)
    ES = UInt16[DS, 0x5430];
    CheckExternalEvents(cs1, 0x8793);
    // PUSH word ptr ES:[SI + 0x4036] (0000_878E / 0x878E)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs1, 0x8797);
    // MOV ES,word ptr [0x5432] (0000_8793 / 0x8793)
    ES = UInt16[DS, 0x5432];
    CheckExternalEvents(cs1, 0x879C);
    // PUSH word ptr ES:[SI + 0x4004] (0000_8797 / 0x8797)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs1, 0x87A1);
    // CALLF 0x1000:a861 (0000_879C / 0x879C)
    FarCall(cs1, 0x87A1, unknown_19EF_0971_1A861);
    CheckExternalEvents(cs1, 0x87A4);
    // ADD SP,0x8 (0000_87A1 / 0x87A1)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x87A6);
    // MOV BX,AX (0000_87A4 / 0x87A4)
    BX = AX;
    CheckExternalEvents(cs1, 0x87A8);
    // SHL BX,0x1 (0000_87A6 / 0x87A6)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x87AA);
    // SHL BX,0x1 (0000_87A8 / 0x87A8)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x87AE);
    // MOV ES,word ptr [0x5448] (0000_87AA / 0x87AA)
    ES = UInt16[DS, 0x5448];
    CheckExternalEvents(cs1, 0x87B3);
    // PUSH word ptr ES:[BX + 0x1ac] (0000_87AE / 0x87AE)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1AC)]);
    CheckExternalEvents(cs1, 0x87B8);
    // PUSH word ptr ES:[BX + 0x1aa] (0000_87B3 / 0x87B3)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1AA)]);
    CheckExternalEvents(cs1, 0x87BD);
    // CALLF 0x1000:8055 (0000_87B8 / 0x87B8)
    FarCall(cs1, 0x87BD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x87C0);
    // ADD SP,0x4 (0000_87BD / 0x87BD)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_0000_87C0_087C0:
    CheckExternalEvents(cs1, 0x87C3);
    // MOV AX,0x1 (0000_87C0 / 0x87C0)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x87C4);
    // PUSH AX (0000_87C3 / 0x87C3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x87C7);
    // PUSH word ptr [BP + -0x20] (0000_87C4 / 0x87C4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x87CC);
    // CALLF 0x1000:3224 (0000_87C7 / 0x87C7)
    FarCall(cs1, 0x87CC, ghidra_guess_1000_3224_13224);
    CheckExternalEvents(cs1, 0x87CF);
    // ADD SP,0x4 (0000_87CC / 0x87CC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x87D2);
    // MOV AX,0x3 (0000_87CF / 0x87CF)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x87D3);
    // PUSH AX (0000_87D2 / 0x87D2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x87D8);
    // CALLF 0x1000:7ee1 (0000_87D3 / 0x87D3)
    FarCall(cs1, 0x87D8, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x87DB);
    // ADD SP,0x2 (0000_87D8 / 0x87D8)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x87E0);
    // CALLF 0x1000:7fe8 (0000_87DB / 0x87DB)
    FarCall(cs1, 0x87E0, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x87E4);
    // MOV ES,word ptr [0x544a] (0000_87E0 / 0x87E0)
    ES = UInt16[DS, 0x544A];
    CheckExternalEvents(cs1, 0x87EB);
    // MOV word ptr ES:[0xc6],0x2 (0000_87E4 / 0x87E4)
    UInt16[ES, 0xC6] = 0x2;
    CheckExternalEvents(cs1, 0x87EE);
    // MOV AX,0x1174 (0000_87EB / 0x87EB)
    AX = 0x1174;
    CheckExternalEvents(cs1, 0x87EF);
    // PUSH DS (0000_87EE / 0x87EE)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x87F0);
    // PUSH AX (0000_87EF / 0x87EF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x87F5);
    // CALLF 0x1000:8055 (0000_87F0 / 0x87F0)
    FarCall(cs1, 0x87F5, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x87F8);
    // ADD SP,0x4 (0000_87F5 / 0x87F5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x87FD);
    // MOV word ptr [BP + -0xe],0x0 (0000_87F8 / 0x87F8)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0x8801);
    // CMP word ptr [BP + 0xa],0x0 (0000_87FD / 0x87FD)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0x8803);
    // JZ 0x0000:8832 (0000_8801 / 0x8801)
    if(ZeroFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_0000_8809_08809, 0x8832 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x8807);
    // CMP word ptr [BP + -0x20],0x4 (0000_8803 / 0x8803)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x4);
    CheckExternalEvents(cs1, 0x8809);
    // JL 0x0000:8815 (0000_8807 / 0x8807)
    if(SignFlag != OverflowFlag) {
      // Jump converted to non entry function call
      if(JumpDispatcher.Jump(split_0000_8809_08809, 0x8815 - cs1 * 0x10)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    // Function call generated as ASM continues to next function entry point without return
    return split_0000_8809_08809(0);
  }
  
  public virtual Action split_0000_8809_08809(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_8809_08809:
    CheckExternalEvents(cs1, 0x880D);
    // CMP word ptr [BP + -0x20],0xc (0000_8809 / 0x8809)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0xC);
    CheckExternalEvents(cs1, 0x880F);
    // JL 0x0000:8832 (0000_880D / 0x880D)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8832_08832;
    }
    CheckExternalEvents(cs1, 0x8813);
    // CMP word ptr [BP + -0x20],0x10 (0000_880F / 0x880F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0x10);
    CheckExternalEvents(cs1, 0x8815);
    // JGE 0x0000:8832 (0000_8813 / 0x8813)
    if(SignFlag == OverflowFlag) {
      goto label_0000_8832_08832;
    }
    label_0000_8815_08815:
    CheckExternalEvents(cs1, 0x8818);
    // MOV AX,0x1189 (0000_8815 / 0x8815)
    AX = 0x1189;
    CheckExternalEvents(cs1, 0x8819);
    // PUSH DS (0000_8818 / 0x8818)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x881A);
    // PUSH AX (0000_8819 / 0x8819)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x881F);
    // CALLF 0x1000:8055 (0000_881A / 0x881A)
    FarCall(cs1, 0x881F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8822);
    // ADD SP,0x4 (0000_881F / 0x881F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8826);
    // MOV ES,word ptr [0x544a] (0000_8822 / 0x8822)
    ES = UInt16[DS, 0x544A];
    CheckExternalEvents(cs1, 0x882D);
    // MOV word ptr ES:[0xc6],0x3 (0000_8826 / 0x8826)
    UInt16[ES, 0xC6] = 0x3;
    CheckExternalEvents(cs1, 0x8832);
    // MOV word ptr [BP + -0xe],0x1 (0000_882D / 0x882D)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    label_0000_8832_08832:
    CheckExternalEvents(cs1, 0x8835);
    // MOV AX,0x1195 (0000_8832 / 0x8832)
    AX = 0x1195;
    CheckExternalEvents(cs1, 0x8836);
    // PUSH DS (0000_8835 / 0x8835)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8837);
    // PUSH AX (0000_8836 / 0x8836)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x883C);
    // CALLF 0x1000:8055 (0000_8837 / 0x8837)
    FarCall(cs1, 0x883C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x883F);
    // ADD SP,0x4 (0000_883C / 0x883C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8843);
    // MOV ES,word ptr [0x544a] (0000_883F / 0x883F)
    ES = UInt16[DS, 0x544A];
    CheckExternalEvents(cs1, 0x884A);
    // MOV word ptr ES:[0xc2],0x1 (0000_8843 / 0x8843)
    UInt16[ES, 0xC2] = 0x1;
    CheckExternalEvents(cs1, 0x8851);
    // MOV word ptr ES:[0xc8],0x0 (0000_884A / 0x884A)
    UInt16[ES, 0xC8] = 0x0;
    CheckExternalEvents(cs1, 0x8854);
    // MOV AX,0x3 (0000_8851 / 0x8851)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x8855);
    // PUSH AX (0000_8854 / 0x8854)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x885A);
    // CALLF 0x1000:87be (0000_8855 / 0x8855)
    FarCall(cs1, 0x885A, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x885D);
    // ADD SP,0x2 (0000_885A / 0x885A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x8860);
    // MOV word ptr [BP + -0x12],AX (0000_885D / 0x885D)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0x8863);
    // CMP AX,0x1 (0000_8860 / 0x8860)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0x8865);
    // JNZ 0x0000:8889 (0000_8863 / 0x8863)
    if(!ZeroFlag) {
      goto label_0000_8889_08889;
    }
    CheckExternalEvents(cs1, 0x8869);
    // CMP word ptr [BP + -0xe],0x0 (0000_8865 / 0x8865)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs1, 0x886B);
    // JZ 0x0000:8889 (0000_8869 / 0x8869)
    if(ZeroFlag) {
      goto label_0000_8889_08889;
    }
    CheckExternalEvents(cs1, 0x8870);
    // MOV word ptr [BP + -0x12],0x0 (0000_886B / 0x886B)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs1, 0x8873);
    // PUSH word ptr [BP + -0x20] (0000_8870 / 0x8870)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x8874);
    // PUSH CS (0000_8873 / 0x8873)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x8877);
    // CALL 0x0000:8cae (0000_8874 / 0x8874)
    NearCall(cs1, 0x8877, ghidra_guess_0000_8CAE_08CAE);
    CheckExternalEvents(cs1, 0x887A);
    // ADD SP,0x2 (0000_8877 / 0x8877)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x887D);
    // MOV AX,0x1 (0000_887A / 0x887A)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x887E);
    // PUSH AX (0000_887D / 0x887D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8883);
    // CALLF 0x0000:fd3f (0000_887E / 0x887E)
    FarCall(cs1, 0x8883, ghidra_guess_0000_FD3F_0FD3F);
    CheckExternalEvents(cs1, 0x8886);
    // ADD SP,0x2 (0000_8883 / 0x8883)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x8889);
    // DEC word ptr [BP + -0x20] (0000_8886 / 0x8886)
    UInt16[SS, (ushort)(BP - 0x20)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x20)]);
    label_0000_8889_08889:
    CheckExternalEvents(cs1, 0x888C);
    // MOV AX,word ptr [BP + 0x8] (0000_8889 / 0x8889)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x888F);
    // ADD AX,0xb (0000_888C / 0x888C)
    AX += 0xB;
    CheckExternalEvents(cs1, 0x8892);
    // INC word ptr [BP + -0x20] (0000_888F / 0x888F)
    UInt16[SS, (ushort)(BP - 0x20)]++;
    CheckExternalEvents(cs1, 0x8895);
    // CMP AX,word ptr [BP + -0x20] (0000_8892 / 0x8892)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x8897);
    // JGE 0x0000:88a7 (0000_8895 / 0x8895)
    if(SignFlag == OverflowFlag) {
      goto label_0000_88A7_088A7;
    }
    CheckExternalEvents(cs1, 0x889A);
    // MOV AX,word ptr [BP + 0x8] (0000_8897 / 0x8897)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x889D);
    // MOV word ptr [BP + -0x20],AX (0000_889A / 0x889A)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs1, 0x88A1);
    // CMP word ptr [BP + 0xa],0x0 (0000_889D / 0x889D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0x88A3);
    // JNZ 0x0000:88a7 (0000_88A1 / 0x88A1)
    if(!ZeroFlag) {
      goto label_0000_88A7_088A7;
    }
    CheckExternalEvents(cs1, 0x88A7);
    // ADD word ptr [BP + -0x20],0x4 (0000_88A3 / 0x88A3)
    // UInt16[SS, (ushort)(BP - 0x20)] += 0x4;
    UInt16[SS, (ushort)(BP - 0x20)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x20)], 0x4);
    label_0000_88A7_088A7:
    CheckExternalEvents(cs1, 0x88AB);
    // MOV ES,word ptr [0x544c] (0000_88A7 / 0x88A7)
    ES = UInt16[DS, 0x544C];
    CheckExternalEvents(cs1, 0x88B1);
    // CMP word ptr ES:[0xe48e],0x0 (0000_88AB / 0x88AB)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0x88B3);
    // JZ 0x0000:88be (0000_88B1 / 0x88B1)
    if(ZeroFlag) {
      goto label_0000_88BE_088BE;
    }
    CheckExternalEvents(cs1, 0x88B7);
    // CMP word ptr [BP + -0x20],0xb (0000_88B3 / 0x88B3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x20)], 0xB);
    CheckExternalEvents(cs1, 0x88B9);
    // JLE 0x0000:88be (0000_88B7 / 0x88B7)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_88BE_088BE;
    }
    CheckExternalEvents(cs1, 0x88BE);
    // MOV word ptr [BP + -0x20],0xc (0000_88B9 / 0x88B9)
    UInt16[SS, (ushort)(BP - 0x20)] = 0xC;
    label_0000_88BE_088BE:
    CheckExternalEvents(cs1, 0x88C2);
    // CMP word ptr [BP + -0x12],0x0 (0000_88BE / 0x88BE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs1, 0x88C4);
    // JNZ 0x0000:88c7 (0000_88C2 / 0x88C2)
    if(!ZeroFlag) {
      goto label_0000_88C7_088C7;
    }
    CheckExternalEvents(cs1, 0x88C7);
    // JMP 0x0000:8652 (0000_88C4 / 0x88C4)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(ghidra_guess_0000_8617_08617, 0x8652 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_88C7_088C7:
    CheckExternalEvents(cs1, 0x88CB);
    // MOV ES,word ptr [0x544a] (0000_88C7 / 0x88C7)
    ES = UInt16[DS, 0x544A];
    CheckExternalEvents(cs1, 0x88D2);
    // MOV word ptr ES:[0xc2],0x0 (0000_88CB / 0x88CB)
    UInt16[ES, 0xC2] = 0x0;
    CheckExternalEvents(cs1, 0x88D9);
    // MOV word ptr ES:[0xc8],0x6 (0000_88D2 / 0x88D2)
    UInt16[ES, 0xC8] = 0x6;
    CheckExternalEvents(cs1, 0x88DD);
    // CMP word ptr [BP + -0x10],0x0 (0000_88D9 / 0x88D9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0x0);
    CheckExternalEvents(cs1, 0x88DF);
    // JZ 0x0000:88eb (0000_88DD / 0x88DD)
    if(ZeroFlag) {
      goto label_0000_88EB_088EB;
    }
    CheckExternalEvents(cs1, 0x88E2);
    // MOV AX,0x1 (0000_88DF / 0x88DF)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x88E3);
    // PUSH AX (0000_88E2 / 0x88E2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x88E8);
    // CALLF 0x0000:fd3f (0000_88E3 / 0x88E3)
    FarCall(cs1, 0x88E8, ghidra_guess_0000_FD3F_0FD3F);
    CheckExternalEvents(cs1, 0x88EB);
    // ADD SP,0x2 (0000_88E8 / 0x88E8)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_88EB_088EB:
    CheckExternalEvents(cs1, 0x88EF);
    // MOV ES,word ptr [0x541e] (0000_88EB / 0x88EB)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x88F6);
    // MOV word ptr ES:[0x37fe],0xf (0000_88EF / 0x88EF)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x88F7);
    // POP SI (0000_88F6 / 0x88F6)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x88F8);
    // POP DI (0000_88F7 / 0x88F7)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x88FA);
    // MOV SP,BP (0000_88F8 / 0x88F8)
    SP = BP;
    CheckExternalEvents(cs1, 0x88FB);
    // POP BP (0000_88FA / 0x88FA)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x88FC);
    // RETF  (0000_88FB / 0x88FB)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_88FC_088FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_88FC_088FC:
    CheckExternalEvents(cs1, 0x88FD);
    // PUSH BP (0000_88FC / 0x88FC)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x88FF);
    // MOV BP,SP (0000_88FD / 0x88FD)
    BP = SP;
    CheckExternalEvents(cs1, 0x8902);
    // MOV AX,0x4 (0000_88FF / 0x88FF)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x8907);
    // CALLF 0x1000:cecc (0000_8902 / 0x8902)
    FarCall(cs1, 0x8907, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x890A);
    // MOV AX,word ptr [BP + 0x8] (0000_8907 / 0x8907)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x890D);
    // MOV word ptr [BP + -0x2],AX (0000_890A / 0x890A)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x8911);
    // CMP word ptr [BP + 0xc],0x0 (0000_890D / 0x890D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0x0);
    CheckExternalEvents(cs1, 0x8913);
    // JNZ 0x0000:8916 (0000_8911 / 0x8911)
    if(!ZeroFlag) {
      goto label_0000_8916_08916;
    }
    CheckExternalEvents(cs1, 0x8916);
    // JMP 0x0000:89bf (0000_8913 / 0x8913)
    goto label_0000_89BF_089BF;
    label_0000_8916_08916:
    CheckExternalEvents(cs1, 0x891B);
    // MOV word ptr [BP + -0x4],0x4 (0000_8916 / 0x8916)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x4;
    CheckExternalEvents(cs1, 0x891F);
    // MOV ES,word ptr [0x5426] (0000_891B / 0x891B)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8925);
    // CMP word ptr ES:[0x4fba],0x0 (0000_891F / 0x891F)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8927);
    // JNZ 0x0000:892c (0000_8925 / 0x8925)
    if(!ZeroFlag) {
      goto label_0000_892C_0892C;
    }
    CheckExternalEvents(cs1, 0x892C);
    // MOV word ptr [BP + -0x4],0x2 (0000_8927 / 0x8927)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x2;
    label_0000_892C_0892C:
    CheckExternalEvents(cs1, 0x8930);
    // CMP word ptr [BP + 0xc],0x1 (0000_892C / 0x892C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xC)], 0x1);
    CheckExternalEvents(cs1, 0x8932);
    // JLE 0x0000:893c (0000_8930 / 0x8930)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_893C_0893C;
    }
    CheckExternalEvents(cs1, 0x8935);
    // MOV AX,word ptr [BP + 0x8] (0000_8932 / 0x8932)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x8938);
    // SUB AX,word ptr [BP + 0xc] (0000_8935 / 0x8935)
    AX -= UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs1, 0x8939);
    // INC AX (0000_8938 / 0x8938)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x893C);
    // MOV word ptr [BP + -0x2],AX (0000_8939 / 0x8939)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    label_0000_893C_0893C:
    CheckExternalEvents(cs1, 0x8941);
    // CMP word ptr [BP + 0x8],0xb7 (0000_893C / 0x893C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xB7);
    CheckExternalEvents(cs1, 0x8943);
    // JNZ 0x0000:899d (0000_8941 / 0x8941)
    if(!ZeroFlag) {
      goto label_0000_899D_0899D;
    }
    CheckExternalEvents(cs1, 0x8946);
    // MOV AX,word ptr [BP + 0xc] (0000_8943 / 0x8943)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs1, 0x8947);
    // CWD  (0000_8946 / 0x8946)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0x894A);
    // MOV CX,0x6 (0000_8947 / 0x8947)
    CX = 0x6;
    CheckExternalEvents(cs1, 0x894C);
    // IDIV CX (0000_894A / 0x894A)
    int op1IDiv0000_894A = (int)(DX << 16 | AX);
    short op2IDiv0000_894A = (short)CX;
    short? resIDiv0000_894A = Alu16.Idiv(op1IDiv0000_894A, op2IDiv0000_894A);
    if(resIDiv0000_894A == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIDiv0000_894A.Value;
    DX = (ushort)(op1IDiv0000_894A % op2IDiv0000_894A);
    CheckExternalEvents(cs1, 0x894F);
    // SUB AX,0xa (0000_894C / 0x894C)
    AX -= 0xA;
    CheckExternalEvents(cs1, 0x8951);
    // NEG AX (0000_894F / 0x894F)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs1, 0x8954);
    // MOV [0x121a],AX (0000_8951 / 0x8951)
    UInt16[DS, 0x121A] = AX;
    CheckExternalEvents(cs1, 0x8959);
    // CMP word ptr [0x121c],0x0 (0000_8954 / 0x8954)
    Alu16.Sub(UInt16[DS, 0x121C], 0x0);
    CheckExternalEvents(cs1, 0x895B);
    // JNZ 0x0000:8973 (0000_8959 / 0x8959)
    if(!ZeroFlag) {
      goto label_0000_8973_08973;
    }
    CheckExternalEvents(cs1, 0x8961);
    // MOV word ptr [0x121c],0x4 (0000_895B / 0x895B)
    UInt16[DS, 0x121C] = 0x4;
    CheckExternalEvents(cs1, 0x8965);
    // MOV ES,word ptr [0x5426] (0000_8961 / 0x8961)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x896B);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8965 / 0x8965)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x896D);
    // JNZ 0x0000:8973 (0000_896B / 0x896B)
    if(!ZeroFlag) {
      goto label_0000_8973_08973;
    }
    CheckExternalEvents(cs1, 0x8973);
    // MOV word ptr [0x121c],0x2 (0000_896D / 0x896D)
    UInt16[DS, 0x121C] = 0x2;
    label_0000_8973_08973:
    CheckExternalEvents(cs1, 0x8977);
    // DEC word ptr [0x1218] (0000_8973 / 0x8973)
    UInt16[DS, 0x1218] = Alu16.Dec(UInt16[DS, 0x1218]);
    CheckExternalEvents(cs1, 0x8979);
    // JNS 0x0000:8997 (0000_8977 / 0x8977)
    if(!SignFlag) {
      goto label_0000_8997_08997;
    }
    CheckExternalEvents(cs1, 0x897C);
    // MOV AX,[0x121a] (0000_8979 / 0x8979)
    AX = UInt16[DS, 0x121A];
    CheckExternalEvents(cs1, 0x897F);
    // MOV [0x1218],AX (0000_897C / 0x897C)
    UInt16[DS, 0x1218] = AX;
    CheckExternalEvents(cs1, 0x8983);
    // MOV ES,word ptr [0x5426] (0000_897F / 0x897F)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8989);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8983 / 0x8983)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x898B);
    // JNZ 0x0000:8992 (0000_8989 / 0x8989)
    if(!ZeroFlag) {
      goto label_0000_8992_08992;
    }
    CheckExternalEvents(cs1, 0x8990);
    // XOR byte ptr [0x121c],0x1 (0000_898B / 0x898B)
    // UInt8[DS, 0x121C] ^= 0x1;
    UInt8[DS, 0x121C] = Alu8.Xor(UInt8[DS, 0x121C], 0x1);
    CheckExternalEvents(cs1, 0x8992);
    // JMP 0x0000:8997 (0000_8990 / 0x8990)
    goto label_0000_8997_08997;
    label_0000_8992_08992:
    CheckExternalEvents(cs1, 0x8997);
    // XOR byte ptr [0x121c],0xa (0000_8992 / 0x8992)
    // UInt8[DS, 0x121C] ^= 0xA;
    UInt8[DS, 0x121C] = Alu8.Xor(UInt8[DS, 0x121C], 0xA);
    label_0000_8997_08997:
    CheckExternalEvents(cs1, 0x899A);
    // MOV AX,[0x121c] (0000_8997 / 0x8997)
    AX = UInt16[DS, 0x121C];
    CheckExternalEvents(cs1, 0x899D);
    // MOV word ptr [BP + -0x4],AX (0000_899A / 0x899A)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    label_0000_899D_0899D:
    CheckExternalEvents(cs1, 0x89A0);
    // PUSH word ptr [BP + -0x4] (0000_899D / 0x899D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x89A3);
    // PUSH word ptr [BP + 0x8] (0000_89A0 / 0x89A0)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs1, 0x89A6);
    // MOV AX,word ptr [BP + 0x6] (0000_89A3 / 0x89A3)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x89A9);
    // ADD AX,0x5 (0000_89A6 / 0x89A6)
    // AX += 0x5;
    AX = Alu16.Add(AX, 0x5);
    CheckExternalEvents(cs1, 0x89AA);
    // PUSH AX (0000_89A9 / 0x89A9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x89AD);
    // PUSH word ptr [BP + -0x2] (0000_89AA / 0x89AA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x89B0);
    // PUSH word ptr [BP + 0x6] (0000_89AD / 0x89AD)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x89B5);
    // CALLF 0x1000:8ccb (0000_89B0 / 0x89B0)
    FarCall(cs1, 0x89B5, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0x89B8);
    // ADD SP,0xa (0000_89B5 / 0x89B5)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs1, 0x89BB);
    // MOV AX,word ptr [BP + -0x2] (0000_89B8 / 0x89B8)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x89BC);
    // DEC AX (0000_89BB / 0x89BB)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs1, 0x89BF);
    // MOV word ptr [BP + 0x8],AX (0000_89BC / 0x89BC)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    label_0000_89BF_089BF:
    CheckExternalEvents(cs1, 0x89C3);
    // CMP word ptr [BP + 0xa],0x0 (0000_89BF / 0x89BF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0x89C5);
    // JZ 0x0000:8a04 (0000_89C3 / 0x89C3)
    if(ZeroFlag) {
      goto label_0000_8A04_08A04;
    }
    CheckExternalEvents(cs1, 0x89CA);
    // MOV word ptr [BP + -0x4],0x2 (0000_89C5 / 0x89C5)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x2;
    CheckExternalEvents(cs1, 0x89CE);
    // MOV ES,word ptr [0x5426] (0000_89CA / 0x89CA)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x89D4);
    // CMP word ptr ES:[0x4fba],0x0 (0000_89CE / 0x89CE)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x89D6);
    // JNZ 0x0000:89d9 (0000_89D4 / 0x89D4)
    if(!ZeroFlag) {
      goto label_0000_89D9_089D9;
    }
    CheckExternalEvents(cs1, 0x89D9);
    // DEC word ptr [BP + -0x4] (0000_89D6 / 0x89D6)
    UInt16[SS, (ushort)(BP - 0x4)]--;
    label_0000_89D9_089D9:
    CheckExternalEvents(cs1, 0x89DD);
    // CMP word ptr [BP + 0xa],0x1 (0000_89D9 / 0x89D9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x1);
    CheckExternalEvents(cs1, 0x89DF);
    // JLE 0x0000:89e9 (0000_89DD / 0x89DD)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_89E9_089E9;
    }
    CheckExternalEvents(cs1, 0x89E2);
    // MOV AX,word ptr [BP + 0x8] (0000_89DF / 0x89DF)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x89E5);
    // SUB AX,word ptr [BP + 0xa] (0000_89E2 / 0x89E2)
    AX -= UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs1, 0x89E6);
    // INC AX (0000_89E5 / 0x89E5)
    AX = Alu16.Inc(AX);
    CheckExternalEvents(cs1, 0x89E9);
    // MOV word ptr [BP + -0x2],AX (0000_89E6 / 0x89E6)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    label_0000_89E9_089E9:
    CheckExternalEvents(cs1, 0x89EC);
    // PUSH word ptr [BP + -0x4] (0000_89E9 / 0x89E9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x89EF);
    // PUSH word ptr [BP + 0x8] (0000_89EC / 0x89EC)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs1, 0x89F2);
    // MOV AX,word ptr [BP + 0x6] (0000_89EF / 0x89EF)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x89F5);
    // ADD AX,0x5 (0000_89F2 / 0x89F2)
    // AX += 0x5;
    AX = Alu16.Add(AX, 0x5);
    CheckExternalEvents(cs1, 0x89F6);
    // PUSH AX (0000_89F5 / 0x89F5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x89F9);
    // PUSH word ptr [BP + -0x2] (0000_89F6 / 0x89F6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x89FC);
    // PUSH word ptr [BP + 0x6] (0000_89F9 / 0x89F9)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x8A01);
    // CALLF 0x1000:8ccb (0000_89FC / 0x89FC)
    FarCall(cs1, 0x8A01, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0x8A04);
    // ADD SP,0xa (0000_8A01 / 0x8A01)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_0000_8A04_08A04:
    CheckExternalEvents(cs1, 0x8A06);
    // MOV SP,BP (0000_8A04 / 0x8A04)
    SP = BP;
    CheckExternalEvents(cs1, 0x8A07);
    // POP BP (0000_8A06 / 0x8A06)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8A08);
    // RETF  (0000_8A07 / 0x8A07)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_8A08_08A08(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_8A08_08A08:
    CheckExternalEvents(cs1, 0x8A09);
    // PUSH BP (0000_8A08 / 0x8A08)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x8A0B);
    // MOV BP,SP (0000_8A09 / 0x8A09)
    BP = SP;
    CheckExternalEvents(cs1, 0x8A0E);
    // MOV AX,0x4 (0000_8A0B / 0x8A0B)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x8A13);
    // CALLF 0x1000:cecc (0000_8A0E / 0x8A0E)
    FarCall(cs1, 0x8A13, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x8A14);
    // PUSH DI (0000_8A13 / 0x8A13)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0x8A15);
    // PUSH SI (0000_8A14 / 0x8A14)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x8A1A);
    // MOV word ptr [BP + -0x2],0x2 (0000_8A15 / 0x8A15)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2;
    CheckExternalEvents(cs1, 0x8A1E);
    // MOV ES,word ptr [0x5426] (0000_8A1A / 0x8A1A)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8A24);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8A1E / 0x8A1E)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8A26);
    // JNZ 0x0000:8a2b (0000_8A24 / 0x8A24)
    if(!ZeroFlag) {
      goto label_0000_8A2B_08A2B;
    }
    CheckExternalEvents(cs1, 0x8A2B);
    // MOV word ptr [BP + -0x2],0x1 (0000_8A26 / 0x8A26)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0000_8A2B_08A2B:
    CheckExternalEvents(cs1, 0x8A30);
    // MOV word ptr [BP + -0x4],0x0 (0000_8A2B / 0x8A2B)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0x8A32);
    // JMP 0x0000:8a8a (0000_8A30 / 0x8A30)
    goto label_0000_8A8A_08A8A;
    label_0000_8A32_08A32:
    CheckExternalEvents(cs1, 0x8A36);
    // CMP word ptr [BP + -0x4],0x5 (0000_8A32 / 0x8A32)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], 0x5);
    CheckExternalEvents(cs1, 0x8A38);
    // JNZ 0x0000:8a3f (0000_8A36 / 0x8A36)
    if(!ZeroFlag) {
      goto label_0000_8A3F_08A3F;
    }
    CheckExternalEvents(cs1, 0x8A3C);
    // SUB word ptr [BP + 0x6],0x5 (0000_8A38 / 0x8A38)
    UInt16[SS, (ushort)(BP + 0x6)] -= 0x5;
    CheckExternalEvents(cs1, 0x8A3F);
    // INC word ptr [BP + 0x8] (0000_8A3C / 0x8A3C)
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.Inc(UInt16[SS, (ushort)(BP + 0x8)]);
    label_0000_8A3F_08A3F:
    CheckExternalEvents(cs1, 0x8A42);
    // MOV AX,word ptr [BP + 0xc] (0000_8A3F / 0x8A3F)
    AX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs1, 0x8A45);
    // CMP word ptr [BP + -0x4],AX (0000_8A42 / 0x8A42)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs1, 0x8A47);
    // JNZ 0x0000:8a5d (0000_8A45 / 0x8A45)
    if(!ZeroFlag) {
      goto label_0000_8A5D_08A5D;
    }
    CheckExternalEvents(cs1, 0x8A4C);
    // MOV word ptr [BP + -0x2],0x4 (0000_8A47 / 0x8A47)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x4;
    CheckExternalEvents(cs1, 0x8A50);
    // MOV ES,word ptr [0x5426] (0000_8A4C / 0x8A4C)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8A56);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8A50 / 0x8A50)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8A58);
    // JNZ 0x0000:8a5d (0000_8A56 / 0x8A56)
    if(!ZeroFlag) {
      goto label_0000_8A5D_08A5D;
    }
    CheckExternalEvents(cs1, 0x8A5D);
    // MOV word ptr [BP + -0x2],0x2 (0000_8A58 / 0x8A58)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2;
    label_0000_8A5D_08A5D:
    CheckExternalEvents(cs1, 0x8A60);
    // MOV SI,word ptr [BP + 0x6] (0000_8A5D / 0x8A5D)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x8A62);
    // MOV CL,0x3 (0000_8A60 / 0x8A60)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x8A64);
    // SHL SI,CL (0000_8A62 / 0x8A62)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs1, 0x8A67);
    // MOV DI,word ptr [BP + 0x8] (0000_8A64 / 0x8A64)
    DI = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x8A69);
    // SHL DI,CL (0000_8A67 / 0x8A67)
    // DI <<= CL;
    DI = Alu16.Shl(DI, CL);
    CheckExternalEvents(cs1, 0x8A6C);
    // PUSH word ptr [BP + -0x2] (0000_8A69 / 0x8A69)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x8A6F);
    // LEA AX,[DI + 0x5] (0000_8A6C / 0x8A6C)
    AX = (ushort)(DI + 0x5);
    CheckExternalEvents(cs1, 0x8A70);
    // PUSH AX (0000_8A6F / 0x8A6F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8A73);
    // LEA AX,[SI + 0x4] (0000_8A70 / 0x8A70)
    AX = (ushort)(SI + 0x4);
    CheckExternalEvents(cs1, 0x8A74);
    // PUSH AX (0000_8A73 / 0x8A73)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8A77);
    // LEA AX,[DI + 0x3] (0000_8A74 / 0x8A74)
    AX = (ushort)(DI + 0x3);
    CheckExternalEvents(cs1, 0x8A78);
    // PUSH AX (0000_8A77 / 0x8A77)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8A7B);
    // LEA AX,[SI + 0x2] (0000_8A78 / 0x8A78)
    AX = (ushort)(SI + 0x2);
    CheckExternalEvents(cs1, 0x8A7C);
    // PUSH AX (0000_8A7B / 0x8A7B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8A81);
    // CALLF 0x1000:8ccb (0000_8A7C / 0x8A7C)
    FarCall(cs1, 0x8A81, unknown_18AD_01FB_18CCB);
    CheckExternalEvents(cs1, 0x8A84);
    // ADD SP,0xa (0000_8A81 / 0x8A81)
    SP += 0xA;
    CheckExternalEvents(cs1, 0x8A87);
    // INC word ptr [BP + 0x6] (0000_8A84 / 0x8A84)
    UInt16[SS, (ushort)(BP + 0x6)]++;
    CheckExternalEvents(cs1, 0x8A8A);
    // INC word ptr [BP + -0x4] (0000_8A87 / 0x8A87)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    label_0000_8A8A_08A8A:
    CheckExternalEvents(cs1, 0x8A8D);
    // MOV AX,word ptr [BP + 0xa] (0000_8A8A / 0x8A8A)
    AX = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs1, 0x8A90);
    // CMP word ptr [BP + -0x4],AX (0000_8A8D / 0x8A8D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x4)], AX);
    CheckExternalEvents(cs1, 0x8A92);
    // JL 0x0000:8a32 (0000_8A90 / 0x8A90)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8A32_08A32;
    }
    CheckExternalEvents(cs1, 0x8A93);
    // POP SI (0000_8A92 / 0x8A92)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8A94);
    // POP DI (0000_8A93 / 0x8A93)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8A96);
    // MOV SP,BP (0000_8A94 / 0x8A94)
    SP = BP;
    CheckExternalEvents(cs1, 0x8A97);
    // POP BP (0000_8A96 / 0x8A96)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8A98);
    // RETF  (0000_8A97 / 0x8A97)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_8A98_08A98(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_8A98_08A98:
    CheckExternalEvents(cs1, 0x8A99);
    // PUSH BP (0000_8A98 / 0x8A98)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x8A9B);
    // MOV BP,SP (0000_8A99 / 0x8A99)
    BP = SP;
    CheckExternalEvents(cs1, 0x8A9E);
    // MOV AX,0x6 (0000_8A9B / 0x8A9B)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8AA3);
    // CALLF 0x1000:cecc (0000_8A9E / 0x8A9E)
    FarCall(cs1, 0x8AA3, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x8AA4);
    // PUSH SI (0000_8AA3 / 0x8AA3)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x8AA8);
    // MOV ES,word ptr [0x541e] (0000_8AA4 / 0x8AA4)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x8AAF);
    // MOV word ptr ES:[0x37fe],0xf (0000_8AA8 / 0x8AA8)
    UInt16[ES, 0x37FE] = 0xF;
    CheckExternalEvents(cs1, 0x8AB3);
    // CMP word ptr [BP + 0x6],0x4 (0000_8AAF / 0x8AAF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs1, 0x8AB5);
    // JGE 0x0000:8b0c (0000_8AB3 / 0x8AB3)
    if(SignFlag == OverflowFlag) {
      goto label_0000_8B0C_08B0C;
    }
    CheckExternalEvents(cs1, 0x8AB8);
    // MOV AX,0x7d (0000_8AB5 / 0x8AB5)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8ABB);
    // IMUL word ptr [BP + 0x6] (0000_8AB8 / 0x8AB8)
    int resImul0000_8AB8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_8AB8);
    DX = (ushort)(resImul0000_8AB8 >> 16);
    CheckExternalEvents(cs1, 0x8ABD);
    // MOV BX,AX (0000_8ABB / 0x8ABB)
    BX = AX;
    CheckExternalEvents(cs1, 0x8AC1);
    // MOV ES,word ptr [0x5412] (0000_8ABD / 0x8ABD)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8AC3);
    // MOV AL,0x11 (0000_8AC1 / 0x8AC1)
    AL = 0x11;
    CheckExternalEvents(cs1, 0x8AC8);
    // MUL byte ptr ES:[BX + 0xc79d] (0000_8AC3 / 0x8AC3)
    ushort resMul0000_8AC3 = Alu8.Mul(AL, UInt8[ES, (ushort)(BX + 0xC79D)]);
    AL = (byte)(resMul0000_8AC3);
    AH = (byte)(resMul0000_8AC3 >> 8);
    CheckExternalEvents(cs1, 0x8ACA);
    // MOV BX,AX (0000_8AC8 / 0x8AC8)
    BX = AX;
    CheckExternalEvents(cs1, 0x8ACF);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_8ACA / 0x8ACA)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x8AD0);
    // CBW  (0000_8ACF / 0x8ACF)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8AD2);
    // MOV BX,AX (0000_8AD0 / 0x8AD0)
    BX = AX;
    CheckExternalEvents(cs1, 0x8AD4);
    // SHL BX,0x1 (0000_8AD2 / 0x8AD2)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x8AD6);
    // SHL BX,0x1 (0000_8AD4 / 0x8AD4)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x8ADA);
    // MOV ES,word ptr [0x5414] (0000_8AD6 / 0x8AD6)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x8ADF);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_8ADA / 0x8ADA)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x8AE4);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_8ADF / 0x8ADF)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x8AE9);
    // CALLF 0x1000:8055 (0000_8AE4 / 0x8AE4)
    FarCall(cs1, 0x8AE9, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8AEC);
    // ADD SP,0x4 (0000_8AE9 / 0x8AE9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8AEF);
    // MOV AX,0x121e (0000_8AEC / 0x8AEC)
    AX = 0x121E;
    CheckExternalEvents(cs1, 0x8AF0);
    // PUSH DS (0000_8AEF / 0x8AEF)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8AF1);
    // PUSH AX (0000_8AF0 / 0x8AF0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8AF6);
    // CALLF 0x1000:8055 (0000_8AF1 / 0x8AF1)
    FarCall(cs1, 0x8AF6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8AF9);
    // ADD SP,0x4 (0000_8AF6 / 0x8AF6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8AFC);
    // MOV AX,0x7d (0000_8AF9 / 0x8AF9)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8AFF);
    // IMUL word ptr [BP + 0x6] (0000_8AFC / 0x8AFC)
    int resImul0000_8AFC = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_8AFC);
    DX = (ushort)(resImul0000_8AFC >> 16);
    CheckExternalEvents(cs1, 0x8B01);
    // MOV BX,AX (0000_8AFF / 0x8AFF)
    BX = AX;
    CheckExternalEvents(cs1, 0x8B05);
    // LEA AX,[BX + 0xc724] (0000_8B01 / 0x8B01)
    AX = (ushort)(BX + 0xC724);
    CheckExternalEvents(cs1, 0x8B08);
    // MOV DX,0x2a02 (0000_8B05 / 0x8B05)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8B09);
    // PUSH DX (0000_8B08 / 0x8B08)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8B0C);
    // JMP 0x0000:8ca0 (0000_8B09 / 0x8B09)
    goto label_0000_8CA0_08CA0;
    label_0000_8B0C_08B0C:
    CheckExternalEvents(cs1, 0x8B0F);
    // MOV AX,word ptr [BP + 0x6] (0000_8B0C / 0x8B0C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x8B12);
    // SUB AX,0x4 (0000_8B0F / 0x8B0F)
    // AX -= 0x4;
    AX = Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs1, 0x8B15);
    // MOV word ptr [BP + -0x4],AX (0000_8B12 / 0x8B12)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0x8B18);
    // MOV AX,0x11 (0000_8B15 / 0x8B15)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x8B1B);
    // IMUL word ptr [BP + -0x4] (0000_8B18 / 0x8B18)
    int resImul0000_8B18 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_8B18);
    DX = (ushort)(resImul0000_8B18 >> 16);
    CheckExternalEvents(cs1, 0x8B1D);
    // MOV BX,AX (0000_8B1B / 0x8B1B)
    BX = AX;
    CheckExternalEvents(cs1, 0x8B21);
    // MOV ES,word ptr [0x5412] (0000_8B1D / 0x8B1D)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8B26);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_8B21 / 0x8B21)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x8B27);
    // CBW  (0000_8B26 / 0x8B26)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8B29);
    // MOV BX,AX (0000_8B27 / 0x8B27)
    BX = AX;
    CheckExternalEvents(cs1, 0x8B2B);
    // SHL BX,0x1 (0000_8B29 / 0x8B29)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x8B2D);
    // SHL BX,0x1 (0000_8B2B / 0x8B2B)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x8B31);
    // MOV ES,word ptr [0x5414] (0000_8B2D / 0x8B2D)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x8B36);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_8B31 / 0x8B31)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x8B3B);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_8B36 / 0x8B36)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x8B40);
    // CALLF 0x1000:8055 (0000_8B3B / 0x8B3B)
    FarCall(cs1, 0x8B40, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8B43);
    // ADD SP,0x4 (0000_8B40 / 0x8B40)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x8B47);
    // CMP word ptr [BP + 0xa],0x0 (0000_8B43 / 0x8B43)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x0);
    CheckExternalEvents(cs1, 0x8B49);
    // JNZ 0x0000:8b4c (0000_8B47 / 0x8B47)
    if(!ZeroFlag) {
      goto label_0000_8B4C_08B4C;
    }
    CheckExternalEvents(cs1, 0x8B4C);
    // JMP 0x0000:8ca9 (0000_8B49 / 0x8B49)
    goto label_0000_8CA9_08CA9;
    label_0000_8B4C_08B4C:
    CheckExternalEvents(cs1, 0x8B50);
    // MOV ES,word ptr [0x5412] (0000_8B4C / 0x8B4C)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8B56);
    // CMP byte ptr ES:[0xd333],0x0 (0000_8B50 / 0x8B50)
    Alu8.Sub(UInt8[ES, 0xD333], 0x0);
    CheckExternalEvents(cs1, 0x8B58);
    // JZ 0x0000:8b8d (0000_8B56 / 0x8B56)
    if(ZeroFlag) {
      goto label_0000_8B8D_08B8D;
    }
    CheckExternalEvents(cs1, 0x8B5C);
    // MOV AL,ES:[0xd331] (0000_8B58 / 0x8B58)
    AL = UInt8[ES, 0xD331];
    CheckExternalEvents(cs1, 0x8B5D);
    // CBW  (0000_8B5C / 0x8B5C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8B60);
    // CMP AX,word ptr [BP + -0x4] (0000_8B5D / 0x8B5D)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x8B62);
    // JNZ 0x0000:8b8d (0000_8B60 / 0x8B60)
    if(!ZeroFlag) {
      goto label_0000_8B8D_08B8D;
    }
    CheckExternalEvents(cs1, 0x8B66);
    // CMP word ptr [BP + 0x8],0x0 (0000_8B62 / 0x8B62)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs1, 0x8B68);
    // JZ 0x0000:8b8d (0000_8B66 / 0x8B66)
    if(ZeroFlag) {
      goto label_0000_8B8D_08B8D;
    }
    CheckExternalEvents(cs1, 0x8B6B);
    // MOV AX,0x1222 (0000_8B68 / 0x8B68)
    AX = 0x1222;
    CheckExternalEvents(cs1, 0x8B6C);
    // PUSH DS (0000_8B6B / 0x8B6B)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8B6D);
    // PUSH AX (0000_8B6C / 0x8B6C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8B72);
    // CALLF 0x1000:8055 (0000_8B6D / 0x8B6D)
    FarCall(cs1, 0x8B72, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8B75);
    // ADD SP,0x4 (0000_8B72 / 0x8B72)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8B7A);
    // CALLF 0x1000:933a (0000_8B75 / 0x8B75)
    FarCall(cs1, 0x8B7A, ghidra_guess_1000_933A_1933A);
    CheckExternalEvents(cs1, 0x8B7F);
    // CALLF 0x1000:8d29 (0000_8B7A / 0x8B7A)
    FarCall(cs1, 0x8B7F, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x8B83);
    // MOV ES,word ptr [0x544e] (0000_8B7F / 0x8B7F)
    ES = UInt16[DS, 0x544E];
    CheckExternalEvents(cs1, 0x8B8A);
    // MOV word ptr ES:[0x374a],0x1 (0000_8B83 / 0x8B83)
    UInt16[ES, 0x374A] = 0x1;
    CheckExternalEvents(cs1, 0x8B8D);
    // JMP 0x0000:8ca9 (0000_8B8A / 0x8B8A)
    goto label_0000_8CA9_08CA9;
    label_0000_8B8D_08B8D:
    CheckExternalEvents(cs1, 0x8B90);
    // PUSH word ptr [BP + -0x4] (0000_8B8D / 0x8B8D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x8B95);
    // CALLF 0x0000:fcf4 (0000_8B90 / 0x8B90)
    FarCall(cs1, 0x8B95, ghidra_guess_0000_FCF4_0FCF4);
    CheckExternalEvents(cs1, 0x8B98);
    // ADD SP,0x2 (0000_8B95 / 0x8B95)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x8B9C);
    // MOV ES,word ptr [0x5444] (0000_8B98 / 0x8B98)
    ES = UInt16[DS, 0x5444];
    CheckExternalEvents(cs1, 0x8BA3);
    // MOV word ptr ES:[0x3748],0x0 (0000_8B9C / 0x8B9C)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0x8BA7);
    // MOV ES,word ptr [0x5446] (0000_8BA3 / 0x8BA3)
    ES = UInt16[DS, 0x5446];
    CheckExternalEvents(cs1, 0x8BAE);
    // MOV word ptr ES:[0x374e],0x7 (0000_8BA7 / 0x8BA7)
    UInt16[ES, 0x374E] = 0x7;
    CheckExternalEvents(cs1, 0x8BB3);
    // CALLF 0x0000:3fa2 (0000_8BAE / 0x8BAE)
    FarCall(cs1, 0x8BB3, unknown_0170_28A2_03FA2);
    CheckExternalEvents(cs1, 0x8BB6);
    // MOV AX,0x1245 (0000_8BB3 / 0x8BB3)
    AX = 0x1245;
    CheckExternalEvents(cs1, 0x8BB7);
    // PUSH DS (0000_8BB6 / 0x8BB6)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8BB8);
    // PUSH AX (0000_8BB7 / 0x8BB7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8BBD);
    // CALLF 0x1000:8055 (0000_8BB8 / 0x8BB8)
    FarCall(cs1, 0x8BBD, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8BC0);
    // ADD SP,0x4 (0000_8BBD / 0x8BBD)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8BC4);
    // MOV ES,word ptr [0x5444] (0000_8BC0 / 0x8BC0)
    ES = UInt16[DS, 0x5444];
    CheckExternalEvents(cs1, 0x8BCB);
    // MOV word ptr ES:[0x3748],0x0 (0000_8BC4 / 0x8BC4)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0x8BCF);
    // MOV ES,word ptr [0x5446] (0000_8BCB / 0x8BCB)
    ES = UInt16[DS, 0x5446];
    CheckExternalEvents(cs1, 0x8BD6);
    // MOV word ptr ES:[0x374e],0x8 (0000_8BCF / 0x8BCF)
    UInt16[ES, 0x374E] = 0x8;
    CheckExternalEvents(cs1, 0x8BD9);
    // MOV AX,0x11 (0000_8BD6 / 0x8BD6)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x8BDC);
    // IMUL word ptr [BP + -0x4] (0000_8BD9 / 0x8BD9)
    int resImul0000_8BD9 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_8BD9);
    DX = (ushort)(resImul0000_8BD9 >> 16);
    CheckExternalEvents(cs1, 0x8BDE);
    // MOV BX,AX (0000_8BDC / 0x8BDC)
    BX = AX;
    CheckExternalEvents(cs1, 0x8BE2);
    // MOV ES,word ptr [0x5412] (0000_8BDE / 0x8BDE)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8BE4);
    // MOV AL,0x11 (0000_8BE2 / 0x8BE2)
    AL = 0x11;
    CheckExternalEvents(cs1, 0x8BE9);
    // IMUL byte ptr ES:[BX + 0xc61f] (0000_8BE4 / 0x8BE4)
    short resImul0000_8BE4 = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC61F)]);
    AL = (byte)(resImul0000_8BE4);
    AH = (byte)(resImul0000_8BE4 >> 8);
    CheckExternalEvents(cs1, 0x8BEB);
    // MOV BX,AX (0000_8BE9 / 0x8BE9)
    BX = AX;
    CheckExternalEvents(cs1, 0x8BEF);
    // LEA AX,[BX + 0x2ed8] (0000_8BEB / 0x8BEB)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0x8BF2);
    // MOV DX,0x384b (0000_8BEF / 0x8BEF)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0x8BF3);
    // PUSH DX (0000_8BF2 / 0x8BF2)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8BF4);
    // PUSH AX (0000_8BF3 / 0x8BF3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8BF9);
    // CALLF 0x1000:8055 (0000_8BF4 / 0x8BF4)
    FarCall(cs1, 0x8BF9, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8BFC);
    // ADD SP,0x4 (0000_8BF9 / 0x8BF9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8C00);
    // MOV ES,word ptr [0x5444] (0000_8BFC / 0x8BFC)
    ES = UInt16[DS, 0x5444];
    CheckExternalEvents(cs1, 0x8C07);
    // MOV word ptr ES:[0x3748],0x0 (0000_8C00 / 0x8C00)
    UInt16[ES, 0x3748] = 0x0;
    CheckExternalEvents(cs1, 0x8C0B);
    // MOV ES,word ptr [0x5446] (0000_8C07 / 0x8C07)
    ES = UInt16[DS, 0x5446];
    CheckExternalEvents(cs1, 0x8C12);
    // MOV word ptr ES:[0x374e],0xa (0000_8C0B / 0x8C0B)
    UInt16[ES, 0x374E] = 0xA;
    CheckExternalEvents(cs1, 0x8C15);
    // MOV AX,0x11 (0000_8C12 / 0x8C12)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x8C18);
    // IMUL word ptr [BP + -0x4] (0000_8C15 / 0x8C15)
    int resImul0000_8C15 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_8C15);
    DX = (ushort)(resImul0000_8C15 >> 16);
    CheckExternalEvents(cs1, 0x8C1A);
    // MOV SI,AX (0000_8C18 / 0x8C18)
    SI = AX;
    CheckExternalEvents(cs1, 0x8C1E);
    // MOV ES,word ptr [0x5412] (0000_8C1A / 0x8C1A)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8C23);
    // MOV AL,byte ptr ES:[SI + 0xc621] (0000_8C1E / 0x8C1E)
    AL = UInt8[ES, (ushort)(SI + 0xC621)];
    CheckExternalEvents(cs1, 0x8C24);
    // CBW  (0000_8C23 / 0x8C23)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8C27);
    // MOV word ptr [BP + -0x2],AX (0000_8C24 / 0x8C24)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0x8C29);
    // OR AX,AX (0000_8C27 / 0x8C27)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x8C2B);
    // JZ 0x0000:8c9c (0000_8C29 / 0x8C29)
    if(ZeroFlag) {
      goto label_0000_8C9C_08C9C;
    }
    CheckExternalEvents(cs1, 0x8C30);
    // MOV AL,byte ptr ES:[SI + 0xc622] (0000_8C2B / 0x8C2B)
    AL = UInt8[ES, (ushort)(SI + 0xC622)];
    CheckExternalEvents(cs1, 0x8C31);
    // CBW  (0000_8C30 / 0x8C30)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8C34);
    // MOV word ptr [BP + -0x6],AX (0000_8C31 / 0x8C31)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x8C36);
    // OR AX,AX (0000_8C34 / 0x8C34)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x8C38);
    // JZ 0x0000:8c75 (0000_8C36 / 0x8C36)
    if(ZeroFlag) {
      goto label_0000_8C75_08C75;
    }
    CheckExternalEvents(cs1, 0x8C3B);
    // MOV BX,word ptr [BP + -0x2] (0000_8C38 / 0x8C38)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0x8C3F);
    // MOV ES,word ptr [0x5450] (0000_8C3B / 0x8C3B)
    ES = UInt16[DS, 0x5450];
    CheckExternalEvents(cs1, 0x8C44);
    // MOV AL,byte ptr ES:[BX + 0x4ddb] (0000_8C3F / 0x8C3F)
    AL = UInt8[ES, (ushort)(BX + 0x4DDB)];
    CheckExternalEvents(cs1, 0x8C45);
    // CBW  (0000_8C44 / 0x8C44)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8C48);
    // CMP AX,word ptr [BP + -0x6] (0000_8C45 / 0x8C45)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x8C4A);
    // JZ 0x0000:8c61 (0000_8C48 / 0x8C48)
    if(ZeroFlag) {
      goto label_0000_8C61_08C61;
    }
    CheckExternalEvents(cs1, 0x8C4E);
    // MOV ES,word ptr [0x5426] (0000_8C4A / 0x8C4A)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8C54);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8C4E / 0x8C4E)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8C56);
    // JZ 0x0000:8c61 (0000_8C54 / 0x8C54)
    if(ZeroFlag) {
      goto label_0000_8C61_08C61;
    }
    CheckExternalEvents(cs1, 0x8C5A);
    // MOV ES,word ptr [0x541e] (0000_8C56 / 0x8C56)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x8C61);
    // MOV word ptr ES:[0x37fe],0xe (0000_8C5A / 0x8C5A)
    UInt16[ES, 0x37FE] = 0xE;
    label_0000_8C61_08C61:
    CheckExternalEvents(cs1, 0x8C63);
    // SHL BX,0x1 (0000_8C61 / 0x8C61)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x8C65);
    // SHL BX,0x1 (0000_8C63 / 0x8C63)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x8C69);
    // MOV ES,word ptr [0x5452] (0000_8C65 / 0x8C65)
    ES = UInt16[DS, 0x5452];
    CheckExternalEvents(cs1, 0x8C6E);
    // PUSH word ptr ES:[BX + 0x4e8c] (0000_8C69 / 0x8C69)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4E8C)]);
    CheckExternalEvents(cs1, 0x8C73);
    // PUSH word ptr ES:[BX + 0x4e8a] (0000_8C6E / 0x8C6E)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4E8A)]);
    CheckExternalEvents(cs1, 0x8C75);
    // JMP 0x0000:8ca1 (0000_8C73 / 0x8C73)
    goto label_0000_8CA1_08CA1;
    label_0000_8C75_08C75:
    CheckExternalEvents(cs1, 0x8C79);
    // MOV ES,word ptr [0x541e] (0000_8C75 / 0x8C75)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x8C80);
    // MOV word ptr ES:[0x37fe],0x8 (0000_8C79 / 0x8C79)
    UInt16[ES, 0x37FE] = 0x8;
    CheckExternalEvents(cs1, 0x8C84);
    // MOV ES,word ptr [0x5426] (0000_8C80 / 0x8C80)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8C8A);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8C84 / 0x8C84)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8C8C);
    // JNZ 0x0000:8c97 (0000_8C8A / 0x8C8A)
    if(!ZeroFlag) {
      goto label_0000_8C97_08C97;
    }
    CheckExternalEvents(cs1, 0x8C90);
    // MOV ES,word ptr [0x541e] (0000_8C8C / 0x8C8C)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x8C97);
    // MOV word ptr ES:[0x37fe],0x2 (0000_8C90 / 0x8C90)
    UInt16[ES, 0x37FE] = 0x2;
    label_0000_8C97_08C97:
    CheckExternalEvents(cs1, 0x8C9A);
    // MOV AX,0x1257 (0000_8C97 / 0x8C97)
    AX = 0x1257;
    CheckExternalEvents(cs1, 0x8C9C);
    // JMP 0x0000:8c9f (0000_8C9A / 0x8C9A)
    goto label_0000_8C9F_08C9F;
    label_0000_8C9C_08C9C:
    CheckExternalEvents(cs1, 0x8C9F);
    // MOV AX,0x1260 (0000_8C9C / 0x8C9C)
    AX = 0x1260;
    label_0000_8C9F_08C9F:
    CheckExternalEvents(cs1, 0x8CA0);
    // PUSH DS (0000_8C9F / 0x8C9F)
    Stack.Push16(DS);
    label_0000_8CA0_08CA0:
    CheckExternalEvents(cs1, 0x8CA1);
    // PUSH AX (0000_8CA0 / 0x8CA0)
    Stack.Push16(AX);
    label_0000_8CA1_08CA1:
    CheckExternalEvents(cs1, 0x8CA6);
    // CALLF 0x1000:8055 (0000_8CA1 / 0x8CA1)
    FarCall(cs1, 0x8CA6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x8CA9);
    // ADD SP,0x4 (0000_8CA6 / 0x8CA6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_0000_8CA9_08CA9:
    CheckExternalEvents(cs1, 0x8CAA);
    // POP SI (0000_8CA9 / 0x8CA9)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8CAC);
    // MOV SP,BP (0000_8CAA / 0x8CAA)
    SP = BP;
    CheckExternalEvents(cs1, 0x8CAD);
    // POP BP (0000_8CAC / 0x8CAC)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x8CAE);
    // RETF  (0000_8CAD / 0x8CAD)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_8CAE_08CAE(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_8CAE_08CAE:
    CheckExternalEvents(cs1, 0x8CAF);
    // PUSH BP (0000_8CAE / 0x8CAE)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0x8CB1);
    // MOV BP,SP (0000_8CAF / 0x8CAF)
    BP = SP;
    CheckExternalEvents(cs1, 0x8CB4);
    // MOV AX,0x38 (0000_8CB1 / 0x8CB1)
    AX = 0x38;
    CheckExternalEvents(cs1, 0x8CB9);
    // CALLF 0x1000:cecc (0000_8CB4 / 0x8CB4)
    FarCall(cs1, 0x8CB9, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0x8CBA);
    // PUSH SI (0000_8CB9 / 0x8CB9)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x8CBF);
    // MOV word ptr [BP + -0x1a],0x8 (0000_8CBA / 0x8CBA)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x8;
    CheckExternalEvents(cs1, 0x8CC3);
    // MOV ES,word ptr [0x5426] (0000_8CBF / 0x8CBF)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8CC9);
    // CMP word ptr ES:[0x4fba],0x0 (0000_8CC3 / 0x8CC3)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x8CCB);
    // JNZ 0x0000:8cd0 (0000_8CC9 / 0x8CC9)
    if(!ZeroFlag) {
      goto label_0000_8CD0_08CD0;
    }
    CheckExternalEvents(cs1, 0x8CD0);
    // MOV word ptr [BP + -0x1a],0x2 (0000_8CCB / 0x8CCB)
    UInt16[SS, (ushort)(BP - 0x1A)] = 0x2;
    label_0000_8CD0_08CD0:
    CheckExternalEvents(cs1, 0x8CD3);
    // MOV AX,0x1265 (0000_8CD0 / 0x8CD0)
    AX = 0x1265;
    CheckExternalEvents(cs1, 0x8CD6);
    // MOV word ptr [BP + -0xc],AX (0000_8CD3 / 0x8CD3)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs1, 0x8CD9);
    // MOV word ptr [BP + -0xa],DS (0000_8CD6 / 0x8CD6)
    UInt16[SS, (ushort)(BP - 0xA)] = DS;
    CheckExternalEvents(cs1, 0x8CDC);
    // MOV AX,0x1269 (0000_8CD9 / 0x8CD9)
    AX = 0x1269;
    CheckExternalEvents(cs1, 0x8CDF);
    // MOV word ptr [BP + -0x32],AX (0000_8CDC / 0x8CDC)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs1, 0x8CE2);
    // MOV word ptr [BP + -0x30],DS (0000_8CDF / 0x8CDF)
    UInt16[SS, (ushort)(BP - 0x30)] = DS;
    CheckExternalEvents(cs1, 0x8CE5);
    // MOV AX,0x126d (0000_8CE2 / 0x8CE2)
    AX = 0x126D;
    CheckExternalEvents(cs1, 0x8CE8);
    // MOV word ptr [BP + -0x8],AX (0000_8CE5 / 0x8CE5)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0x8CEB);
    // MOV word ptr [BP + -0x6],DS (0000_8CE8 / 0x8CE8)
    UInt16[SS, (ushort)(BP - 0x6)] = DS;
    CheckExternalEvents(cs1, 0x8CEE);
    // MOV AX,0x4 (0000_8CEB / 0x8CEB)
    AX = 0x4;
    CheckExternalEvents(cs1, 0x8CEF);
    // PUSH AX (0000_8CEE / 0x8CEE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8CF4);
    // CALLF 0x1000:7ee1 (0000_8CEF / 0x8CEF)
    FarCall(cs1, 0x8CF4, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x8CF7);
    // ADD SP,0x2 (0000_8CF4 / 0x8CF4)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x8CFC);
    // CALLF 0x1000:7fe8 (0000_8CF7 / 0x8CF7)
    FarCall(cs1, 0x8CFC, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x8D00);
    // MOV ES,word ptr [0x5454] (0000_8CFC / 0x8CFC)
    ES = UInt16[DS, 0x5454];
    CheckExternalEvents(cs1, 0x8D06);
    // CMP word ptr ES:[0x4594],0x0 (0000_8D00 / 0x8D00)
    Alu16.Sub(UInt16[ES, 0x4594], 0x0);
    CheckExternalEvents(cs1, 0x8D08);
    // JNZ 0x0000:8d2e (0000_8D06 / 0x8D06)
    if(!ZeroFlag) {
      goto label_0000_8D2E_08D2E;
    }
    CheckExternalEvents(cs1, 0x8D0D);
    // INC word ptr ES:[0x4594] (0000_8D08 / 0x8D08)
    UInt16[ES, 0x4594] = Alu16.Inc(UInt16[ES, 0x4594]);
    CheckExternalEvents(cs1, 0x8D10);
    // MOV AX,0x1 (0000_8D0D / 0x8D0D)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x8D11);
    // PUSH AX (0000_8D10 / 0x8D10)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D16);
    // CALLF 0x0000:3fcc (0000_8D11 / 0x8D11)
    FarCall(cs1, 0x8D16, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0x8D19);
    // ADD SP,0x2 (0000_8D16 / 0x8D16)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x8D1C);
    // MOV AX,0xa0 (0000_8D19 / 0x8D19)
    AX = 0xA0;
    CheckExternalEvents(cs1, 0x8D1F);
    // MOV DX,0x2a02 (0000_8D1C / 0x8D1C)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8D20);
    // PUSH DX (0000_8D1F / 0x8D1F)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D21);
    // PUSH AX (0000_8D20 / 0x8D20)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D24);
    // MOV AX,0x1272 (0000_8D21 / 0x8D21)
    AX = 0x1272;
    CheckExternalEvents(cs1, 0x8D25);
    // PUSH DS (0000_8D24 / 0x8D24)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8D26);
    // PUSH AX (0000_8D25 / 0x8D25)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D2B);
    // CALLF 0x1000:910b (0000_8D26 / 0x8D26)
    FarCall(cs1, 0x8D2B, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs1, 0x8D2E);
    // ADD SP,0x8 (0000_8D2B / 0x8D2B)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    label_0000_8D2E_08D2E:
    CheckExternalEvents(cs1, 0x8D32);
    // MOV ES,word ptr [0x5456] (0000_8D2E / 0x8D2E)
    ES = UInt16[DS, 0x5456];
    CheckExternalEvents(cs1, 0x8D39);
    // MOV word ptr ES:[0x4fbc],0x0 (0000_8D32 / 0x8D32)
    UInt16[ES, 0x4FBC] = 0x0;
    CheckExternalEvents(cs1, 0x8D3C);
    // MOV AX,0x0 (0000_8D39 / 0x8D39)
    AX = 0x0;
    CheckExternalEvents(cs1, 0x8D3F);
    // MOV DX,0x29c6 (0000_8D3C / 0x8D3C)
    DX = 0x29C6;
    CheckExternalEvents(cs1, 0x8D40);
    // PUSH DX (0000_8D3F / 0x8D3F)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D41);
    // PUSH AX (0000_8D40 / 0x8D40)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D46);
    // CALLF 0x1000:9fc1 (0000_8D41 / 0x8D41)
    FarCall(cs1, 0x8D46, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs1, 0x8D49);
    // ADD SP,0x4 (0000_8D46 / 0x8D46)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x8D4C);
    // MOV AX,0x244b (0000_8D49 / 0x8D49)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0x8D4F);
    // MOV DX,0x1ddc (0000_8D4C / 0x8D4C)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x8D50);
    // PUSH DX (0000_8D4F / 0x8D4F)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D51);
    // PUSH AX (0000_8D50 / 0x8D50)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D54);
    // MOV AX,0xa0 (0000_8D51 / 0x8D51)
    AX = 0xA0;
    CheckExternalEvents(cs1, 0x8D57);
    // MOV DX,0x2a02 (0000_8D54 / 0x8D54)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8D58);
    // PUSH DX (0000_8D57 / 0x8D57)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D59);
    // PUSH AX (0000_8D58 / 0x8D58)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D5E);
    // CALLF 0x1000:8f6d (0000_8D59 / 0x8D59)
    FarCall(cs1, 0x8D5E, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs1, 0x8D61);
    // ADD SP,0x8 (0000_8D5E / 0x8D5E)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x8D65);
    // MOV ES,word ptr [0x5426] (0000_8D61 / 0x8D61)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x8D6B);
    // CMP word ptr ES:[0x4fba],0x2 (0000_8D65 / 0x8D65)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0x8D6D);
    // JNZ 0x0000:8da1 (0000_8D6B / 0x8D6B)
    if(!ZeroFlag) {
      goto label_0000_8DA1_08DA1;
    }
    CheckExternalEvents(cs1, 0x8D70);
    // MOV AX,0xa800 (0000_8D6D / 0x8D6D)
    AX = 0xA800;
    CheckExternalEvents(cs1, 0x8D71);
    // PUSH AX (0000_8D70 / 0x8D70)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D74);
    // MOV AX,0x244b (0000_8D71 / 0x8D71)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0x8D77);
    // MOV DX,0x1ddc (0000_8D74 / 0x8D74)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x8D78);
    // PUSH DX (0000_8D77 / 0x8D77)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D79);
    // PUSH AX (0000_8D78 / 0x8D78)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D7E);
    // CALLF 0x1000:a150 (0000_8D79 / 0x8D79)
    FarCall(cs1, 0x8D7E, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs1, 0x8D81);
    // ADD SP,0x6 (0000_8D7E / 0x8D7E)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs1, 0x8D84);
    // MOV AX,0xc8 (0000_8D81 / 0x8D81)
    AX = 0xC8;
    CheckExternalEvents(cs1, 0x8D85);
    // PUSH AX (0000_8D84 / 0x8D84)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D88);
    // MOV AX,0x28 (0000_8D85 / 0x8D85)
    AX = 0x28;
    CheckExternalEvents(cs1, 0x8D89);
    // PUSH AX (0000_8D88 / 0x8D88)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D8B);
    // SUB AX,AX (0000_8D89 / 0x8D89)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8D8C);
    // PUSH AX (0000_8D8B / 0x8D8B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D8D);
    // PUSH AX (0000_8D8C / 0x8D8C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D90);
    // MOV DX,0xa000 (0000_8D8D / 0x8D8D)
    DX = 0xA000;
    CheckExternalEvents(cs1, 0x8D91);
    // PUSH DX (0000_8D90 / 0x8D90)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D92);
    // PUSH AX (0000_8D91 / 0x8D91)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D95);
    // MOV DX,0xa800 (0000_8D92 / 0x8D92)
    DX = 0xA800;
    CheckExternalEvents(cs1, 0x8D96);
    // PUSH DX (0000_8D95 / 0x8D95)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8D97);
    // PUSH AX (0000_8D96 / 0x8D96)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8D9C);
    // CALLF 0x1000:c34c (0000_8D97 / 0x8D97)
    FarCall(cs1, 0x8D9C, unknown_19EF_245C_1C34C);
    CheckExternalEvents(cs1, 0x8D9F);
    // ADD SP,0x10 (0000_8D9C / 0x8D9C)
    // SP += 0x10;
    SP = Alu16.Add(SP, 0x10);
    CheckExternalEvents(cs1, 0x8DA1);
    // JMP 0x0000:8dbd (0000_8D9F / 0x8D9F)
    goto label_0000_8DBD_08DBD;
    label_0000_8DA1_08DA1:
    CheckExternalEvents(cs1, 0x8DA4);
    // MOV AX,0xc8 (0000_8DA1 / 0x8DA1)
    AX = 0xC8;
    CheckExternalEvents(cs1, 0x8DA5);
    // PUSH AX (0000_8DA4 / 0x8DA4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DA8);
    // MOV AX,0x28 (0000_8DA5 / 0x8DA5)
    AX = 0x28;
    CheckExternalEvents(cs1, 0x8DA9);
    // PUSH AX (0000_8DA8 / 0x8DA8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DAB);
    // SUB AX,AX (0000_8DA9 / 0x8DA9)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8DAC);
    // PUSH AX (0000_8DAB / 0x8DAB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DAD);
    // PUSH AX (0000_8DAC / 0x8DAC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DB0);
    // MOV AX,0x244b (0000_8DAD / 0x8DAD)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0x8DB3);
    // MOV DX,0x1ddc (0000_8DB0 / 0x8DB0)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0x8DB4);
    // PUSH DX (0000_8DB3 / 0x8DB3)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8DB5);
    // PUSH AX (0000_8DB4 / 0x8DB4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DBA);
    // CALLF 0x1000:8b56 (0000_8DB5 / 0x8DB5)
    FarCall(cs1, 0x8DBA, unknown_18AD_0086_18B56);
    CheckExternalEvents(cs1, 0x8DBD);
    // ADD SP,0xc (0000_8DBA / 0x8DBA)
    SP += 0xC;
    label_0000_8DBD_08DBD:
    CheckExternalEvents(cs1, 0x8DBF);
    // SUB AX,AX (0000_8DBD / 0x8DBD)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8DC0);
    // PUSH AX (0000_8DBF / 0x8DBF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DC3);
    // MOV AX,0xf (0000_8DC0 / 0x8DC0)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x8DC4);
    // PUSH AX (0000_8DC3 / 0x8DC3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DC6);
    // SUB AX,AX (0000_8DC4 / 0x8DC4)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8DC7);
    // PUSH AX (0000_8DC6 / 0x8DC6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DC8);
    // PUSH AX (0000_8DC7 / 0x8DC7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DCB);
    // MOV AX,0x127e (0000_8DC8 / 0x8DC8)
    AX = 0x127E;
    CheckExternalEvents(cs1, 0x8DCC);
    // PUSH DS (0000_8DCB / 0x8DCB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8DCD);
    // PUSH AX (0000_8DCC / 0x8DCC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DD2);
    // CALLF 0x1000:8ba5 (0000_8DCD / 0x8DCD)
    FarCall(cs1, 0x8DD2, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x8DD5);
    // ADD SP,0xc (0000_8DD2 / 0x8DD2)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x8DD8);
    // MOV AX,word ptr [BP + 0x6] (0000_8DD5 / 0x8DD5)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x8DDB);
    // MOV word ptr [BP + -0x2e],AX (0000_8DD8 / 0x8DD8)
    UInt16[SS, (ushort)(BP - 0x2E)] = AX;
    CheckExternalEvents(cs1, 0x8DDE);
    // CMP AX,0xc (0000_8DDB / 0x8DDB)
    Alu16.Sub(AX, 0xC);
    CheckExternalEvents(cs1, 0x8DE0);
    // JL 0x0000:8de4 (0000_8DDE / 0x8DDE)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8DE4_08DE4;
    }
    CheckExternalEvents(cs1, 0x8DE4);
    // SUB word ptr [BP + -0x2e],0x8 (0000_8DE0 / 0x8DE0)
    // UInt16[SS, (ushort)(BP - 0x2E)] -= 0x8;
    UInt16[SS, (ushort)(BP - 0x2E)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2E)], 0x8);
    label_0000_8DE4_08DE4:
    CheckExternalEvents(cs1, 0x8DE7);
    // MOV AX,0x7d (0000_8DE4 / 0x8DE4)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8DEA);
    // IMUL word ptr [BP + -0x2e] (0000_8DE7 / 0x8DE7)
    int resImul0000_8DE7 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8DE7);
    DX = (ushort)(resImul0000_8DE7 >> 16);
    CheckExternalEvents(cs1, 0x8DEC);
    // MOV BX,AX (0000_8DEA / 0x8DEA)
    BX = AX;
    CheckExternalEvents(cs1, 0x8DF0);
    // LEA AX,[BX + 0xc724] (0000_8DEC / 0x8DEC)
    AX = (ushort)(BX + 0xC724);
    CheckExternalEvents(cs1, 0x8DF3);
    // MOV DX,0x2a02 (0000_8DF0 / 0x8DF0)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8DF4);
    // PUSH DX (0000_8DF3 / 0x8DF3)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8DF5);
    // PUSH AX (0000_8DF4 / 0x8DF4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8DF8);
    // MOV AX,0x12 (0000_8DF5 / 0x8DF5)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x8DFB);
    // MOV DX,0x2a02 (0000_8DF8 / 0x8DF8)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8DFC);
    // PUSH DX (0000_8DFB / 0x8DFB)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8DFD);
    // PUSH AX (0000_8DFC / 0x8DFC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E02);
    // CALLF 0x1000:da58 (0000_8DFD / 0x8DFD)
    FarCall(cs1, 0x8E02, unknown_19EF_3B68_1DA58);
    CheckExternalEvents(cs1, 0x8E05);
    // ADD SP,0x8 (0000_8E02 / 0x8E02)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x8E09);
    // MOV ES,word ptr [0x541a] (0000_8E05 / 0x8E05)
    ES = UInt16[DS, 0x541A];
    CheckExternalEvents(cs1, 0x8E0F);
    // MOV byte ptr ES:[0x1a],0x0 (0000_8E09 / 0x8E09)
    UInt8[ES, 0x1A] = 0x0;
    CheckExternalEvents(cs1, 0x8E11);
    // SUB AX,AX (0000_8E0F / 0x8E0F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8E12);
    // PUSH AX (0000_8E11 / 0x8E11)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E15);
    // MOV AX,0xe (0000_8E12 / 0x8E12)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x8E16);
    // PUSH AX (0000_8E15 / 0x8E15)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E18);
    // SUB AX,AX (0000_8E16 / 0x8E16)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8E19);
    // PUSH AX (0000_8E18 / 0x8E18)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E1C);
    // MOV AX,0x6 (0000_8E19 / 0x8E19)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8E1D);
    // PUSH AX (0000_8E1C / 0x8E1C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E20);
    // MOV AX,0x12 (0000_8E1D / 0x8E1D)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x8E23);
    // MOV DX,0x2a02 (0000_8E20 / 0x8E20)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8E24);
    // PUSH DX (0000_8E23 / 0x8E23)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8E25);
    // PUSH AX (0000_8E24 / 0x8E24)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E2A);
    // CALLF 0x1000:8ba5 (0000_8E25 / 0x8E25)
    FarCall(cs1, 0x8E2A, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x8E2D);
    // ADD SP,0xc (0000_8E2A / 0x8E2A)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x8E30);
    // MOV AX,0xa (0000_8E2D / 0x8E2D)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x8E31);
    // PUSH AX (0000_8E30 / 0x8E30)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E34);
    // MOV AX,0x12 (0000_8E31 / 0x8E31)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x8E37);
    // MOV DX,0x2a02 (0000_8E34 / 0x8E34)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8E38);
    // PUSH DX (0000_8E37 / 0x8E37)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8E39);
    // PUSH AX (0000_8E38 / 0x8E38)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E3C);
    // MOV AX,0x7d (0000_8E39 / 0x8E39)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8E3F);
    // IMUL word ptr [BP + -0x2e] (0000_8E3C / 0x8E3C)
    int resImul0000_8E3C = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8E3C);
    DX = (ushort)(resImul0000_8E3C >> 16);
    CheckExternalEvents(cs1, 0x8E41);
    // MOV BX,AX (0000_8E3F / 0x8E3F)
    BX = AX;
    CheckExternalEvents(cs1, 0x8E45);
    // MOV ES,word ptr [0x5412] (0000_8E41 / 0x8E41)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8E4A);
    // MOV AL,byte ptr ES:[BX + 0xc734] (0000_8E45 / 0x8E45)
    AL = UInt8[ES, (ushort)(BX + 0xC734)];
    CheckExternalEvents(cs1, 0x8E4C);
    // SUB AH,AH (0000_8E4A / 0x8E4A)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0x8E4D);
    // PUSH AX (0000_8E4C / 0x8E4C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E52);
    // CALLF 0x1000:daa6 (0000_8E4D / 0x8E4D)
    FarCall(cs1, 0x8E52, unknown_19EF_3BB6_1DAA6);
    CheckExternalEvents(cs1, 0x8E55);
    // ADD SP,0x8 (0000_8E52 / 0x8E52)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x8E57);
    // SUB AX,AX (0000_8E55 / 0x8E55)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8E58);
    // PUSH AX (0000_8E57 / 0x8E57)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E5B);
    // MOV AX,0xe (0000_8E58 / 0x8E58)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x8E5C);
    // PUSH AX (0000_8E5B / 0x8E5B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E5F);
    // MOV AX,0x1 (0000_8E5C / 0x8E5C)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x8E60);
    // PUSH AX (0000_8E5F / 0x8E5F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E63);
    // MOV AX,0x6 (0000_8E60 / 0x8E60)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8E64);
    // PUSH AX (0000_8E63 / 0x8E63)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E67);
    // MOV AX,0x12 (0000_8E64 / 0x8E64)
    AX = 0x12;
    CheckExternalEvents(cs1, 0x8E6A);
    // MOV DX,0x2a02 (0000_8E67 / 0x8E67)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0x8E6B);
    // PUSH DX (0000_8E6A / 0x8E6A)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x8E6C);
    // PUSH AX (0000_8E6B / 0x8E6B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E71);
    // CALLF 0x1000:8ba5 (0000_8E6C / 0x8E6C)
    FarCall(cs1, 0x8E71, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x8E74);
    // ADD SP,0xc (0000_8E71 / 0x8E71)
    SP += 0xC;
    CheckExternalEvents(cs1, 0x8E78);
    // CMP word ptr [BP + -0x2e],0x4 (0000_8E74 / 0x8E74)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2E)], 0x4);
    CheckExternalEvents(cs1, 0x8E7A);
    // JL 0x0000:8e7d (0000_8E78 / 0x8E78)
    if(SignFlag != OverflowFlag) {
      goto label_0000_8E7D_08E7D;
    }
    CheckExternalEvents(cs1, 0x8E7D);
    // JMP 0x0000:8f21 (0000_8E7A / 0x8E7A)
    goto label_0000_8F21_08F21;
    label_0000_8E7D_08E7D:
    CheckExternalEvents(cs1, 0x8E7F);
    // SUB AX,AX (0000_8E7D / 0x8E7D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8E80);
    // PUSH AX (0000_8E7F / 0x8E7F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E83);
    // MOV AX,0xe (0000_8E80 / 0x8E80)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x8E84);
    // PUSH AX (0000_8E83 / 0x8E83)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E87);
    // MOV AX,0x2 (0000_8E84 / 0x8E84)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x8E88);
    // PUSH AX (0000_8E87 / 0x8E87)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E8B);
    // MOV AX,0x6 (0000_8E88 / 0x8E88)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8E8C);
    // PUSH AX (0000_8E8B / 0x8E8B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8E8F);
    // MOV AX,0x7d (0000_8E8C / 0x8E8C)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8E92);
    // IMUL word ptr [BP + -0x2e] (0000_8E8F / 0x8E8F)
    int resImul0000_8E8F = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8E8F);
    DX = (ushort)(resImul0000_8E8F >> 16);
    CheckExternalEvents(cs1, 0x8E94);
    // MOV BX,AX (0000_8E92 / 0x8E92)
    BX = AX;
    CheckExternalEvents(cs1, 0x8E98);
    // MOV ES,word ptr [0x5412] (0000_8E94 / 0x8E94)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8E9A);
    // MOV AL,0x11 (0000_8E98 / 0x8E98)
    AL = 0x11;
    CheckExternalEvents(cs1, 0x8E9F);
    // MUL byte ptr ES:[BX + 0xc79d] (0000_8E9A / 0x8E9A)
    ushort resMul0000_8E9A = Alu8.Mul(AL, UInt8[ES, (ushort)(BX + 0xC79D)]);
    AL = (byte)(resMul0000_8E9A);
    AH = (byte)(resMul0000_8E9A >> 8);
    CheckExternalEvents(cs1, 0x8EA1);
    // MOV BX,AX (0000_8E9F / 0x8E9F)
    BX = AX;
    CheckExternalEvents(cs1, 0x8EA6);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_8EA1 / 0x8EA1)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x8EA7);
    // CBW  (0000_8EA6 / 0x8EA6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8EA9);
    // MOV BX,AX (0000_8EA7 / 0x8EA7)
    BX = AX;
    CheckExternalEvents(cs1, 0x8EAB);
    // SHL BX,0x1 (0000_8EA9 / 0x8EA9)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x8EAD);
    // SHL BX,0x1 (0000_8EAB / 0x8EAB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x8EB1);
    // MOV ES,word ptr [0x5414] (0000_8EAD / 0x8EAD)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x8EB6);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_8EB1 / 0x8EB1)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x8EBB);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_8EB6 / 0x8EB6)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x8EC0);
    // CALLF 0x1000:8ba5 (0000_8EBB / 0x8EBB)
    FarCall(cs1, 0x8EC0, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x8EC3);
    // ADD SP,0xc (0000_8EC0 / 0x8EC0)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x8EC6);
    // MOV AX,0x7d (0000_8EC3 / 0x8EC3)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8EC9);
    // IMUL word ptr [BP + -0x2e] (0000_8EC6 / 0x8EC6)
    int resImul0000_8EC6 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8EC6);
    DX = (ushort)(resImul0000_8EC6 >> 16);
    CheckExternalEvents(cs1, 0x8ECB);
    // MOV BX,AX (0000_8EC9 / 0x8EC9)
    BX = AX;
    CheckExternalEvents(cs1, 0x8ECF);
    // MOV ES,word ptr [0x5412] (0000_8ECB / 0x8ECB)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8ED4);
    // MOV AL,byte ptr ES:[BX + 0xc79e] (0000_8ECF / 0x8ECF)
    AL = UInt8[ES, (ushort)(BX + 0xC79E)];
    CheckExternalEvents(cs1, 0x8ED7);
    // MOV byte ptr [BP + -0x38],AL (0000_8ED4 / 0x8ED4)
    UInt8[SS, (ushort)(BP - 0x38)] = AL;
    CheckExternalEvents(cs1, 0x8ED9);
    // CMP AL,0xff (0000_8ED7 / 0x8ED7)
    Alu8.Sub(AL, 0xFF);
    CheckExternalEvents(cs1, 0x8EDB);
    // JZ 0x0000:8f0d (0000_8ED9 / 0x8ED9)
    if(ZeroFlag) {
      goto label_0000_8F0D_08F0D;
    }
    CheckExternalEvents(cs1, 0x8EDD);
    // SUB AX,AX (0000_8EDB / 0x8EDB)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8EDE);
    // PUSH AX (0000_8EDD / 0x8EDD)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8EE1);
    // MOV AX,0xe (0000_8EDE / 0x8EDE)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x8EE2);
    // PUSH AX (0000_8EE1 / 0x8EE1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8EE5);
    // MOV AX,0x3 (0000_8EE2 / 0x8EE2)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x8EE6);
    // PUSH AX (0000_8EE5 / 0x8EE5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8EE9);
    // MOV AX,0x6 (0000_8EE6 / 0x8EE6)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8EEA);
    // PUSH AX (0000_8EE9 / 0x8EE9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8EEC);
    // MOV AL,0x11 (0000_8EEA / 0x8EEA)
    AL = 0x11;
    CheckExternalEvents(cs1, 0x8EEF);
    // MUL byte ptr [BP + -0x38] (0000_8EEC / 0x8EEC)
    ushort resMul0000_8EEC = Alu8.Mul(AL, UInt8[SS, (ushort)(BP - 0x38)]);
    AL = (byte)(resMul0000_8EEC);
    AH = (byte)(resMul0000_8EEC >> 8);
    CheckExternalEvents(cs1, 0x8EF1);
    // MOV BX,AX (0000_8EEF / 0x8EEF)
    BX = AX;
    CheckExternalEvents(cs1, 0x8EF6);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_8EF1 / 0x8EF1)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0x8EF7);
    // CBW  (0000_8EF6 / 0x8EF6)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x8EF9);
    // MOV BX,AX (0000_8EF7 / 0x8EF7)
    BX = AX;
    CheckExternalEvents(cs1, 0x8EFB);
    // SHL BX,0x1 (0000_8EF9 / 0x8EF9)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0x8EFD);
    // SHL BX,0x1 (0000_8EFB / 0x8EFB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x8F01);
    // MOV ES,word ptr [0x5414] (0000_8EFD / 0x8EFD)
    ES = UInt16[DS, 0x5414];
    CheckExternalEvents(cs1, 0x8F06);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_8F01 / 0x8F01)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0x8F0B);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_8F06 / 0x8F06)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0x8F0D);
    // JMP 0x0000:8f35 (0000_8F0B / 0x8F0B)
    goto label_0000_8F35_08F35;
    label_0000_8F0D_08F0D:
    CheckExternalEvents(cs1, 0x8F0F);
    // SUB AX,AX (0000_8F0D / 0x8F0D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8F10);
    // PUSH AX (0000_8F0F / 0x8F0F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F13);
    // MOV AX,0xe (0000_8F10 / 0x8F10)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x8F14);
    // PUSH AX (0000_8F13 / 0x8F13)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F17);
    // MOV AX,0x3 (0000_8F14 / 0x8F14)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x8F18);
    // PUSH AX (0000_8F17 / 0x8F17)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F1B);
    // MOV AX,0x6 (0000_8F18 / 0x8F18)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8F1C);
    // PUSH AX (0000_8F1B / 0x8F1B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F1F);
    // MOV AX,0x12aa (0000_8F1C / 0x8F1C)
    AX = 0x12AA;
    CheckExternalEvents(cs1, 0x8F21);
    // JMP 0x0000:8f33 (0000_8F1F / 0x8F1F)
    goto label_0000_8F33_08F33;
    label_0000_8F21_08F21:
    CheckExternalEvents(cs1, 0x8F23);
    // SUB AX,AX (0000_8F21 / 0x8F21)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8F24);
    // PUSH AX (0000_8F23 / 0x8F23)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F27);
    // MOV AX,0xe (0000_8F24 / 0x8F24)
    AX = 0xE;
    CheckExternalEvents(cs1, 0x8F28);
    // PUSH AX (0000_8F27 / 0x8F27)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F2B);
    // MOV AX,0x2 (0000_8F28 / 0x8F28)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x8F2C);
    // PUSH AX (0000_8F2B / 0x8F2B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F2F);
    // MOV AX,0x6 (0000_8F2C / 0x8F2C)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x8F30);
    // PUSH AX (0000_8F2F / 0x8F2F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F33);
    // MOV AX,0x12af (0000_8F30 / 0x8F30)
    AX = 0x12AF;
    label_0000_8F33_08F33:
    CheckExternalEvents(cs1, 0x8F34);
    // PUSH DS (0000_8F33 / 0x8F33)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x8F35);
    // PUSH AX (0000_8F34 / 0x8F34)
    Stack.Push16(AX);
    label_0000_8F35_08F35:
    CheckExternalEvents(cs1, 0x8F3A);
    // CALLF 0x1000:8ba5 (0000_8F35 / 0x8F35)
    FarCall(cs1, 0x8F3A, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x8F3D);
    // ADD SP,0xc (0000_8F3A / 0x8F3A)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x8F40);
    // MOV AX,0x7d (0000_8F3D / 0x8F3D)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8F43);
    // IMUL word ptr [BP + -0x2e] (0000_8F40 / 0x8F40)
    int resImul0000_8F40 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8F40);
    DX = (ushort)(resImul0000_8F40 >> 16);
    CheckExternalEvents(cs1, 0x8F45);
    // MOV BX,AX (0000_8F43 / 0x8F43)
    BX = AX;
    CheckExternalEvents(cs1, 0x8F49);
    // MOV ES,word ptr [0x5412] (0000_8F45 / 0x8F45)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8F4E);
    // MOV AL,byte ptr ES:[BX + 0xc799] (0000_8F49 / 0x8F49)
    AL = UInt8[ES, (ushort)(BX + 0xC799)];
    CheckExternalEvents(cs1, 0x8F50);
    // SUB AH,AH (0000_8F4E / 0x8F4E)
    AH -= AH;
    CheckExternalEvents(cs1, 0x8F53);
    // SUB AX,0x3 (0000_8F50 / 0x8F50)
    AX -= 0x3;
    CheckExternalEvents(cs1, 0x8F55);
    // NEG AX (0000_8F53 / 0x8F53)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs1, 0x8F56);
    // PUSH AX (0000_8F55 / 0x8F55)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F59);
    // MOV AX,0x3 (0000_8F56 / 0x8F56)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x8F5A);
    // PUSH AX (0000_8F59 / 0x8F59)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F5C);
    // SUB AX,AX (0000_8F5A / 0x8F5A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x8F5D);
    // PUSH AX (0000_8F5C / 0x8F5C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F60);
    // MOV AX,0x25 (0000_8F5D / 0x8F5D)
    AX = 0x25;
    CheckExternalEvents(cs1, 0x8F61);
    // PUSH AX (0000_8F60 / 0x8F60)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F62);
    // PUSH CS (0000_8F61 / 0x8F61)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x8F65);
    // CALL 0x0000:8a08 (0000_8F62 / 0x8F62)
    NearCall(cs1, 0x8F65, ghidra_guess_0000_8A08_08A08);
    CheckExternalEvents(cs1, 0x8F68);
    // ADD SP,0x8 (0000_8F65 / 0x8F65)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x8F6B);
    // MOV AX,0x7d (0000_8F68 / 0x8F68)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8F6E);
    // IMUL word ptr [BP + -0x2e] (0000_8F6B / 0x8F6B)
    int resImul0000_8F6B = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8F6B);
    DX = (ushort)(resImul0000_8F6B >> 16);
    CheckExternalEvents(cs1, 0x8F70);
    // MOV BX,AX (0000_8F6E / 0x8F6E)
    BX = AX;
    CheckExternalEvents(cs1, 0x8F74);
    // MOV ES,word ptr [0x5412] (0000_8F70 / 0x8F70)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8F79);
    // MOV AL,byte ptr ES:[BX + 0xc79a] (0000_8F74 / 0x8F74)
    AL = UInt8[ES, (ushort)(BX + 0xC79A)];
    CheckExternalEvents(cs1, 0x8F7B);
    // SUB AH,AH (0000_8F79 / 0x8F79)
    AH -= AH;
    CheckExternalEvents(cs1, 0x8F7E);
    // SUB AX,0x2 (0000_8F7B / 0x8F7B)
    AX -= 0x2;
    CheckExternalEvents(cs1, 0x8F80);
    // NEG AX (0000_8F7E / 0x8F7E)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs1, 0x8F81);
    // PUSH AX (0000_8F80 / 0x8F80)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F84);
    // MOV AX,0x2 (0000_8F81 / 0x8F81)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x8F85);
    // PUSH AX (0000_8F84 / 0x8F84)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F88);
    // MOV AX,0x1 (0000_8F85 / 0x8F85)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x8F89);
    // PUSH AX (0000_8F88 / 0x8F88)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F8C);
    // MOV AX,0x25 (0000_8F89 / 0x8F89)
    AX = 0x25;
    CheckExternalEvents(cs1, 0x8F8D);
    // PUSH AX (0000_8F8C / 0x8F8C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8F8E);
    // PUSH CS (0000_8F8D / 0x8F8D)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x8F91);
    // CALL 0x0000:8a08 (0000_8F8E / 0x8F8E)
    NearCall(cs1, 0x8F91, ghidra_guess_0000_8A08_08A08);
    CheckExternalEvents(cs1, 0x8F94);
    // ADD SP,0x8 (0000_8F91 / 0x8F91)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x8F97);
    // MOV AX,0x7d (0000_8F94 / 0x8F94)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8F9A);
    // IMUL word ptr [BP + -0x2e] (0000_8F97 / 0x8F97)
    int resImul0000_8F97 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8F97);
    DX = (ushort)(resImul0000_8F97 >> 16);
    CheckExternalEvents(cs1, 0x8F9C);
    // MOV BX,AX (0000_8F9A / 0x8F9A)
    BX = AX;
    CheckExternalEvents(cs1, 0x8FA0);
    // MOV ES,word ptr [0x5412] (0000_8F9C / 0x8F9C)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8FA5);
    // MOV AL,byte ptr ES:[BX + 0xc79b] (0000_8FA0 / 0x8FA0)
    AL = UInt8[ES, (ushort)(BX + 0xC79B)];
    CheckExternalEvents(cs1, 0x8FA7);
    // SUB AH,AH (0000_8FA5 / 0x8FA5)
    AH -= AH;
    CheckExternalEvents(cs1, 0x8FAA);
    // SUB AX,0x2 (0000_8FA7 / 0x8FA7)
    AX -= 0x2;
    CheckExternalEvents(cs1, 0x8FAC);
    // NEG AX (0000_8FAA / 0x8FAA)
    AX = Alu16.Sub(0, AX);
    CheckExternalEvents(cs1, 0x8FAD);
    // PUSH AX (0000_8FAC / 0x8FAC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8FB0);
    // MOV AX,0x2 (0000_8FAD / 0x8FAD)
    AX = 0x2;
    CheckExternalEvents(cs1, 0x8FB1);
    // PUSH AX (0000_8FB0 / 0x8FB0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8FB2);
    // PUSH AX (0000_8FB1 / 0x8FB1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8FB5);
    // MOV AX,0x25 (0000_8FB2 / 0x8FB2)
    AX = 0x25;
    CheckExternalEvents(cs1, 0x8FB6);
    // PUSH AX (0000_8FB5 / 0x8FB5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x8FB7);
    // PUSH CS (0000_8FB6 / 0x8FB6)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x8FBA);
    // CALL 0x0000:8a08 (0000_8FB7 / 0x8FB7)
    NearCall(cs1, 0x8FBA, ghidra_guess_0000_8A08_08A08);
    CheckExternalEvents(cs1, 0x8FBD);
    // ADD SP,0x8 (0000_8FBA / 0x8FBA)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x8FC0);
    // MOV AX,0x7d (0000_8FBD / 0x8FBD)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8FC3);
    // IMUL word ptr [BP + -0x2e] (0000_8FC0 / 0x8FC0)
    int resImul0000_8FC0 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8FC0);
    DX = (ushort)(resImul0000_8FC0 >> 16);
    CheckExternalEvents(cs1, 0x8FC5);
    // MOV BX,AX (0000_8FC3 / 0x8FC3)
    BX = AX;
    CheckExternalEvents(cs1, 0x8FC9);
    // MOV ES,word ptr [0x5412] (0000_8FC5 / 0x8FC5)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8FCE);
    // MOV AL,byte ptr ES:[BX + 0xc74a] (0000_8FC9 / 0x8FC9)
    AL = UInt8[ES, (ushort)(BX + 0xC74A)];
    CheckExternalEvents(cs1, 0x8FD0);
    // SUB AH,AH (0000_8FCE / 0x8FCE)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0x8FD3);
    // MOV word ptr [BP + -0x1e],AX (0000_8FD0 / 0x8FD0)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs1, 0x8FD8);
    // MOV word ptr [BP + -0x24],0x33 (0000_8FD3 / 0x8FD3)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x33;
    label_0000_8FD8_08FD8:
    CheckExternalEvents(cs1, 0x8FDB);
    // MOV AX,0x7d (0000_8FD8 / 0x8FD8)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x8FDE);
    // IMUL word ptr [BP + -0x2e] (0000_8FDB / 0x8FDB)
    int resImul0000_8FDB = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_8FDB);
    DX = (ushort)(resImul0000_8FDB >> 16);
    CheckExternalEvents(cs1, 0x8FE0);
    // MOV BX,AX (0000_8FDE / 0x8FDE)
    BX = AX;
    CheckExternalEvents(cs1, 0x8FE3);
    // ADD BX,word ptr [BP + -0x24] (0000_8FE0 / 0x8FE0)
    // BX += UInt16[SS, (ushort)(BP - 0x24)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs1, 0x8FE7);
    // MOV ES,word ptr [0x5412] (0000_8FE3 / 0x8FE3)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x8FED);
    // CMP byte ptr ES:[BX + 0xc724],0x22 (0000_8FE7 / 0x8FE7)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC724)], 0x22);
    CheckExternalEvents(cs1, 0x8FEF);
    // JNZ 0x0000:8ff2 (0000_8FED / 0x8FED)
    if(!ZeroFlag) {
      goto label_0000_8FF2_08FF2;
    }
    CheckExternalEvents(cs1, 0x8FF2);
    // INC word ptr [BP + -0x1e] (0000_8FEF / 0x8FEF)
    UInt16[SS, (ushort)(BP - 0x1E)]++;
    label_0000_8FF2_08FF2:
    CheckExternalEvents(cs1, 0x8FF5);
    // INC word ptr [BP + -0x24] (0000_8FF2 / 0x8FF2)
    UInt16[SS, (ushort)(BP - 0x24)]++;
    CheckExternalEvents(cs1, 0x8FF9);
    // CMP word ptr [BP + -0x24],0x55 (0000_8FF5 / 0x8FF5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x55);
    CheckExternalEvents(cs1, 0x8FFB);
    // JLE 0x0000:8fd8 (0000_8FF9 / 0x8FF9)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_8FD8_08FD8;
    }
    CheckExternalEvents(cs1, 0x8FFE);
    // PUSH word ptr [BP + -0x1e] (0000_8FFB / 0x8FFB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs1, 0x9001);
    // MOV AX,0xa (0000_8FFE / 0x8FFE)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x9002);
    // PUSH AX (0000_9001 / 0x9001)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9005);
    // MOV AX,0x6 (0000_9002 / 0x9002)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x9006);
    // PUSH AX (0000_9005 / 0x9005)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9009);
    // MOV AX,0x22 (0000_9006 / 0x9006)
    AX = 0x22;
    CheckExternalEvents(cs1, 0x900A);
    // PUSH AX (0000_9009 / 0x9009)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x900B);
    // PUSH CS (0000_900A / 0x900A)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x900E);
    // CALL 0x0000:8a08 (0000_900B / 0x900B)
    NearCall(cs1, 0x900E, ghidra_guess_0000_8A08_08A08);
    CheckExternalEvents(cs1, 0x9011);
    // ADD SP,0x8 (0000_900E / 0x900E)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x9016);
    // MOV word ptr [BP + -0x28],0x6 (0000_9011 / 0x9011)
    UInt16[SS, (ushort)(BP - 0x28)] = 0x6;
    CheckExternalEvents(cs1, 0x901B);
    // MOV word ptr [BP + -0x24],0x33 (0000_9016 / 0x9016)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x33;
    label_0000_901B_0901B:
    CheckExternalEvents(cs1, 0x901E);
    // MOV AX,0x7d (0000_901B / 0x901B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9021);
    // IMUL word ptr [BP + -0x2e] (0000_901E / 0x901E)
    int resImul0000_901E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_901E);
    DX = (ushort)(resImul0000_901E >> 16);
    CheckExternalEvents(cs1, 0x9023);
    // MOV BX,AX (0000_9021 / 0x9021)
    BX = AX;
    CheckExternalEvents(cs1, 0x9026);
    // ADD BX,word ptr [BP + -0x24] (0000_9023 / 0x9023)
    // BX += UInt16[SS, (ushort)(BP - 0x24)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs1, 0x902A);
    // MOV ES,word ptr [0x5412] (0000_9026 / 0x9026)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x902F);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_902A / 0x902A)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0x9031);
    // SUB AH,AH (0000_902F / 0x902F)
    AH -= AH;
    CheckExternalEvents(cs1, 0x9034);
    // AND AX,0x7f (0000_9031 / 0x9031)
    // AX &= 0x7F;
    AX = Alu16.And(AX, 0x7F);
    CheckExternalEvents(cs1, 0x9037);
    // MOV word ptr [BP + -0x34],AX (0000_9034 / 0x9034)
    UInt16[SS, (ushort)(BP - 0x34)] = AX;
    CheckExternalEvents(cs1, 0x903A);
    // CMP AX,0x10 (0000_9037 / 0x9037)
    Alu16.Sub(AX, 0x10);
    CheckExternalEvents(cs1, 0x903C);
    // JGE 0x0000:903f (0000_903A / 0x903A)
    if(SignFlag == OverflowFlag) {
      goto label_0000_903F_0903F;
    }
    CheckExternalEvents(cs1, 0x903F);
    // JMP 0x0000:912a (0000_903C / 0x903C)
    goto label_0000_912A_0912A;
    label_0000_903F_0903F:
    CheckExternalEvents(cs1, 0x9042);
    // CMP AX,0x20 (0000_903F / 0x903F)
    Alu16.Sub(AX, 0x20);
    CheckExternalEvents(cs1, 0x9044);
    // JLE 0x0000:9047 (0000_9042 / 0x9042)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_9047_09047;
    }
    CheckExternalEvents(cs1, 0x9047);
    // JMP 0x0000:912a (0000_9044 / 0x9044)
    goto label_0000_912A_0912A;
    label_0000_9047_09047:
    CheckExternalEvents(cs1, 0x904C);
    // MOV word ptr [BP + -0x36],0xe (0000_9047 / 0x9047)
    UInt16[SS, (ushort)(BP - 0x36)] = 0xE;
    CheckExternalEvents(cs1, 0x9050);
    // MOV ES,word ptr [0x5426] (0000_904C / 0x904C)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x9056);
    // CMP word ptr ES:[0x4fba],0x0 (0000_9050 / 0x9050)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x9058);
    // JNZ 0x0000:905d (0000_9056 / 0x9056)
    if(!ZeroFlag) {
      goto label_0000_905D_0905D;
    }
    CheckExternalEvents(cs1, 0x905D);
    // MOV word ptr [BP + -0x36],0x1 (0000_9058 / 0x9058)
    UInt16[SS, (ushort)(BP - 0x36)] = 0x1;
    label_0000_905D_0905D:
    CheckExternalEvents(cs1, 0x9060);
    // MOV AX,0x7d (0000_905D / 0x905D)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9063);
    // IMUL word ptr [BP + -0x2e] (0000_9060 / 0x9060)
    int resImul0000_9060 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9060);
    DX = (ushort)(resImul0000_9060 >> 16);
    CheckExternalEvents(cs1, 0x9065);
    // MOV BX,AX (0000_9063 / 0x9063)
    BX = AX;
    CheckExternalEvents(cs1, 0x9068);
    // ADD BX,word ptr [BP + -0x24] (0000_9065 / 0x9065)
    // BX += UInt16[SS, (ushort)(BP - 0x24)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs1, 0x906C);
    // MOV ES,word ptr [0x5412] (0000_9068 / 0x9068)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x9072);
    // TEST byte ptr ES:[BX + 0xc724],0x80 (0000_906C / 0x906C)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC724)], 0x80);
    CheckExternalEvents(cs1, 0x9074);
    // JZ 0x0000:907a (0000_9072 / 0x9072)
    if(ZeroFlag) {
      goto label_0000_907A_0907A;
    }
    CheckExternalEvents(cs1, 0x9077);
    // MOV AX,word ptr [BP + -0x1a] (0000_9074 / 0x9074)
    AX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs1, 0x907A);
    // MOV word ptr [BP + -0x36],AX (0000_9077 / 0x9077)
    UInt16[SS, (ushort)(BP - 0x36)] = AX;
    label_0000_907A_0907A:
    CheckExternalEvents(cs1, 0x907C);
    // SUB AX,AX (0000_907A / 0x907A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x907D);
    // PUSH AX (0000_907C / 0x907C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9080);
    // PUSH word ptr [BP + -0x36] (0000_907D / 0x907D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs1, 0x9083);
    // PUSH word ptr [BP + -0x28] (0000_9080 / 0x9080)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs1, 0x9084);
    // PUSH AX (0000_9083 / 0x9083)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9087);
    // MOV AX,0x11 (0000_9084 / 0x9084)
    AX = 0x11;
    CheckExternalEvents(cs1, 0x908A);
    // IMUL word ptr [BP + -0x34] (0000_9087 / 0x9087)
    int resImul0000_9087 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x34)]);
    AX = (ushort)(resImul0000_9087);
    DX = (ushort)(resImul0000_9087 >> 16);
    CheckExternalEvents(cs1, 0x908C);
    // MOV BX,AX (0000_908A / 0x908A)
    BX = AX;
    CheckExternalEvents(cs1, 0x9090);
    // LEA AX,[BX + 0x2ec7] (0000_908C / 0x908C)
    AX = (ushort)(BX + 0x2EC7);
    CheckExternalEvents(cs1, 0x9093);
    // MOV DX,0x384b (0000_9090 / 0x9090)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0x9094);
    // PUSH DX (0000_9093 / 0x9093)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x9095);
    // PUSH AX (0000_9094 / 0x9094)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x909A);
    // CALLF 0x1000:8ba5 (0000_9095 / 0x9095)
    FarCall(cs1, 0x909A, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x909D);
    // ADD SP,0xc (0000_909A / 0x909A)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x90A0);
    // MOV AX,0x12bf (0000_909D / 0x909D)
    AX = 0x12BF;
    CheckExternalEvents(cs1, 0x90A3);
    // MOV word ptr [BP + -0x16],AX (0000_90A0 / 0x90A0)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x90A6);
    // MOV word ptr [BP + -0x14],DS (0000_90A3 / 0x90A3)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    CheckExternalEvents(cs1, 0x90AA);
    // CMP word ptr [BP + -0x24],0x3a (0000_90A6 / 0x90A6)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x3A);
    CheckExternalEvents(cs1, 0x90AC);
    // JL 0x0000:90b2 (0000_90AA / 0x90AA)
    if(SignFlag != OverflowFlag) {
      goto label_0000_90B2_090B2;
    }
    CheckExternalEvents(cs1, 0x90AF);
    // MOV AX,0x12c2 (0000_90AC / 0x90AC)
    AX = 0x12C2;
    CheckExternalEvents(cs1, 0x90B2);
    // MOV word ptr [BP + -0x16],AX (0000_90AF / 0x90AF)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    label_0000_90B2_090B2:
    CheckExternalEvents(cs1, 0x90B6);
    // CMP word ptr [BP + -0x24],0x41 (0000_90B2 / 0x90B2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x41);
    CheckExternalEvents(cs1, 0x90B8);
    // JL 0x0000:90c1 (0000_90B6 / 0x90B6)
    if(SignFlag != OverflowFlag) {
      goto label_0000_90C1_090C1;
    }
    CheckExternalEvents(cs1, 0x90BB);
    // MOV AX,0x12c5 (0000_90B8 / 0x90B8)
    AX = 0x12C5;
    CheckExternalEvents(cs1, 0x90BE);
    // MOV word ptr [BP + -0x16],AX (0000_90BB / 0x90BB)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x90C1);
    // MOV word ptr [BP + -0x14],DS (0000_90BE / 0x90BE)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    label_0000_90C1_090C1:
    CheckExternalEvents(cs1, 0x90C5);
    // CMP word ptr [BP + -0x24],0x48 (0000_90C1 / 0x90C1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x48);
    CheckExternalEvents(cs1, 0x90C7);
    // JL 0x0000:90d0 (0000_90C5 / 0x90C5)
    if(SignFlag != OverflowFlag) {
      goto label_0000_90D0_090D0;
    }
    CheckExternalEvents(cs1, 0x90CA);
    // MOV AX,0x12c8 (0000_90C7 / 0x90C7)
    AX = 0x12C8;
    CheckExternalEvents(cs1, 0x90CD);
    // MOV word ptr [BP + -0x16],AX (0000_90CA / 0x90CA)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x90D0);
    // MOV word ptr [BP + -0x14],DS (0000_90CD / 0x90CD)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    label_0000_90D0_090D0:
    CheckExternalEvents(cs1, 0x90D4);
    // CMP word ptr [BP + -0x24],0x4f (0000_90D0 / 0x90D0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x4F);
    CheckExternalEvents(cs1, 0x90D6);
    // JL 0x0000:90df (0000_90D4 / 0x90D4)
    if(SignFlag != OverflowFlag) {
      goto label_0000_90DF_090DF;
    }
    CheckExternalEvents(cs1, 0x90D9);
    // MOV AX,0x12cb (0000_90D6 / 0x90D6)
    AX = 0x12CB;
    CheckExternalEvents(cs1, 0x90DC);
    // MOV word ptr [BP + -0x16],AX (0000_90D9 / 0x90D9)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x90DF);
    // MOV word ptr [BP + -0x14],DS (0000_90DC / 0x90DC)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    label_0000_90DF_090DF:
    CheckExternalEvents(cs1, 0x90E3);
    // CMP word ptr [BP + -0x24],0x51 (0000_90DF / 0x90DF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x51);
    CheckExternalEvents(cs1, 0x90E5);
    // JL 0x0000:90ee (0000_90E3 / 0x90E3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_90EE_090EE;
    }
    CheckExternalEvents(cs1, 0x90E8);
    // MOV AX,0x12ce (0000_90E5 / 0x90E5)
    AX = 0x12CE;
    CheckExternalEvents(cs1, 0x90EB);
    // MOV word ptr [BP + -0x16],AX (0000_90E8 / 0x90E8)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x90EE);
    // MOV word ptr [BP + -0x14],DS (0000_90EB / 0x90EB)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    label_0000_90EE_090EE:
    CheckExternalEvents(cs1, 0x90F2);
    // CMP word ptr [BP + -0x24],0x53 (0000_90EE / 0x90EE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x53);
    CheckExternalEvents(cs1, 0x90F4);
    // JL 0x0000:90fd (0000_90F2 / 0x90F2)
    if(SignFlag != OverflowFlag) {
      goto label_0000_90FD_090FD;
    }
    CheckExternalEvents(cs1, 0x90F7);
    // MOV AX,0x12d1 (0000_90F4 / 0x90F4)
    AX = 0x12D1;
    CheckExternalEvents(cs1, 0x90FA);
    // MOV word ptr [BP + -0x16],AX (0000_90F7 / 0x90F7)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x90FD);
    // MOV word ptr [BP + -0x14],DS (0000_90FA / 0x90FA)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    label_0000_90FD_090FD:
    CheckExternalEvents(cs1, 0x9101);
    // CMP word ptr [BP + -0x24],0x55 (0000_90FD / 0x90FD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x55);
    CheckExternalEvents(cs1, 0x9103);
    // JL 0x0000:910c (0000_9101 / 0x9101)
    if(SignFlag != OverflowFlag) {
      goto label_0000_910C_0910C;
    }
    CheckExternalEvents(cs1, 0x9106);
    // MOV AX,0x12d4 (0000_9103 / 0x9103)
    AX = 0x12D4;
    CheckExternalEvents(cs1, 0x9109);
    // MOV word ptr [BP + -0x16],AX (0000_9106 / 0x9106)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x910C);
    // MOV word ptr [BP + -0x14],DS (0000_9109 / 0x9109)
    UInt16[SS, (ushort)(BP - 0x14)] = DS;
    label_0000_910C_0910C:
    CheckExternalEvents(cs1, 0x910E);
    // SUB AX,AX (0000_910C / 0x910C)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x910F);
    // PUSH AX (0000_910E / 0x910E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9112);
    // PUSH word ptr [BP + -0x36] (0000_910F / 0x910F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x36)]);
    CheckExternalEvents(cs1, 0x9115);
    // PUSH word ptr [BP + -0x28] (0000_9112 / 0x9112)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs1, 0x9118);
    // INC word ptr [BP + -0x28] (0000_9115 / 0x9115)
    UInt16[SS, (ushort)(BP - 0x28)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs1, 0x911B);
    // MOV AX,0xb (0000_9118 / 0x9118)
    AX = 0xB;
    CheckExternalEvents(cs1, 0x911C);
    // PUSH AX (0000_911B / 0x911B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x911F);
    // PUSH word ptr [BP + -0x14] (0000_911C / 0x911C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0x9122);
    // PUSH word ptr [BP + -0x16] (0000_911F / 0x911F)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x16)]);
    CheckExternalEvents(cs1, 0x9127);
    // CALLF 0x1000:8ba5 (0000_9122 / 0x9122)
    FarCall(cs1, 0x9127, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x912A);
    // ADD SP,0xc (0000_9127 / 0x9127)
    SP += 0xC;
    label_0000_912A_0912A:
    CheckExternalEvents(cs1, 0x912D);
    // INC word ptr [BP + -0x24] (0000_912A / 0x912A)
    UInt16[SS, (ushort)(BP - 0x24)]++;
    CheckExternalEvents(cs1, 0x9131);
    // CMP word ptr [BP + -0x24],0x55 (0000_912D / 0x912D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x55);
    CheckExternalEvents(cs1, 0x9133);
    // JG 0x0000:9136 (0000_9131 / 0x9131)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_9136_09136;
    }
    CheckExternalEvents(cs1, 0x9136);
    // JMP 0x0000:901b (0000_9133 / 0x9133)
    goto label_0000_901B_0901B;
    label_0000_9136_09136:
    CheckExternalEvents(cs1, 0x9138);
    // SUB AX,AX (0000_9136 / 0x9136)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9139);
    // PUSH AX (0000_9138 / 0x9138)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x913C);
    // MOV AX,0xf (0000_9139 / 0x9139)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x913D);
    // PUSH AX (0000_913C / 0x913C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9140);
    // MOV AX,0x13 (0000_913D / 0x913D)
    AX = 0x13;
    CheckExternalEvents(cs1, 0x9141);
    // PUSH AX (0000_9140 / 0x9140)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9143);
    // SUB AX,AX (0000_9141 / 0x9141)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9144);
    // PUSH AX (0000_9143 / 0x9143)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9147);
    // MOV AX,0x12d6 (0000_9144 / 0x9144)
    AX = 0x12D6;
    CheckExternalEvents(cs1, 0x9148);
    // PUSH DS (0000_9147 / 0x9147)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9149);
    // PUSH AX (0000_9148 / 0x9148)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x914E);
    // CALLF 0x1000:8ba5 (0000_9149 / 0x9149)
    FarCall(cs1, 0x914E, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x9151);
    // ADD SP,0xc (0000_914E / 0x914E)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x9155);
    // MOV ES,word ptr [0x541e] (0000_9151 / 0x9151)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x915C);
    // MOV word ptr ES:[0x37fe],0xe (0000_9155 / 0x9155)
    UInt16[ES, 0x37FE] = 0xE;
    CheckExternalEvents(cs1, 0x9160);
    // MOV ES,word ptr [0x5426] (0000_915C / 0x915C)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x9166);
    // CMP word ptr ES:[0x4fba],0x0 (0000_9160 / 0x9160)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0x9168);
    // JNZ 0x0000:9173 (0000_9166 / 0x9166)
    if(!ZeroFlag) {
      goto label_0000_9173_09173;
    }
    CheckExternalEvents(cs1, 0x916C);
    // MOV ES,word ptr [0x541e] (0000_9168 / 0x9168)
    ES = UInt16[DS, 0x541E];
    CheckExternalEvents(cs1, 0x9173);
    // MOV word ptr ES:[0x37fe],0x1 (0000_916C / 0x916C)
    UInt16[ES, 0x37FE] = 0x1;
    label_0000_9173_09173:
    CheckExternalEvents(cs1, 0x9175);
    // SUB AX,AX (0000_9173 / 0x9173)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9176);
    // PUSH AX (0000_9175 / 0x9175)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9179);
    // MOV AX,0xf (0000_9176 / 0x9176)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x917A);
    // PUSH AX (0000_9179 / 0x9179)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x917D);
    // MOV AX,0x14 (0000_917A / 0x917A)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x917E);
    // PUSH AX (0000_917D / 0x917D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9180);
    // SUB AX,AX (0000_917E / 0x917E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9181);
    // PUSH AX (0000_9180 / 0x9180)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9184);
    // MOV AX,0x12e0 (0000_9181 / 0x9181)
    AX = 0x12E0;
    CheckExternalEvents(cs1, 0x9185);
    // PUSH DS (0000_9184 / 0x9184)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9186);
    // PUSH AX (0000_9185 / 0x9185)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x918B);
    // CALLF 0x1000:8ba5 (0000_9186 / 0x9186)
    FarCall(cs1, 0x918B, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x918E);
    // ADD SP,0xc (0000_918B / 0x918B)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x9191);
    // MOV AX,0x7d (0000_918E / 0x918E)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9194);
    // IMUL word ptr [BP + -0x2e] (0000_9191 / 0x9191)
    int resImul0000_9191 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9191);
    DX = (ushort)(resImul0000_9191 >> 16);
    CheckExternalEvents(cs1, 0x9196);
    // MOV BX,AX (0000_9194 / 0x9194)
    BX = AX;
    CheckExternalEvents(cs1, 0x919A);
    // MOV ES,word ptr [0x5412] (0000_9196 / 0x9196)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x919F);
    // MOV AL,byte ptr ES:[BX + 0xc748] (0000_919A / 0x919A)
    AL = UInt8[ES, (ushort)(BX + 0xC748)];
    CheckExternalEvents(cs1, 0x91A1);
    // AND AL,0xf (0000_919F / 0x919F)
    AL &= 0xF;
    CheckExternalEvents(cs1, 0x91A3);
    // CMP AL,0xf (0000_91A1 / 0x91A1)
    Alu8.Sub(AL, 0xF);
    CheckExternalEvents(cs1, 0x91A5);
    // JNZ 0x0000:91bc (0000_91A3 / 0x91A3)
    if(!ZeroFlag) {
      goto label_0000_91BC_091BC;
    }
    CheckExternalEvents(cs1, 0x91A7);
    // SUB AX,AX (0000_91A5 / 0x91A5)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x91A8);
    // PUSH AX (0000_91A7 / 0x91A7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91AB);
    // MOV AX,0xf (0000_91A8 / 0x91A8)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x91AC);
    // PUSH AX (0000_91AB / 0x91AB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91AF);
    // MOV AX,0x14 (0000_91AC / 0x91AC)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x91B0);
    // PUSH AX (0000_91AF / 0x91AF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91B3);
    // MOV AX,0xa (0000_91B0 / 0x91B0)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x91B4);
    // PUSH AX (0000_91B3 / 0x91B3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91B7);
    // PUSH word ptr [BP + -0xa] (0000_91B4 / 0x91B4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x91BA);
    // PUSH word ptr [BP + -0xc] (0000_91B7 / 0x91B7)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x91BC);
    // JMP 0x0000:91f7 (0000_91BA / 0x91BA)
    goto label_0000_91F7_091F7;
    label_0000_91BC_091BC:
    CheckExternalEvents(cs1, 0x91BF);
    // MOV AX,0x7d (0000_91BC / 0x91BC)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x91C2);
    // IMUL word ptr [BP + -0x2e] (0000_91BF / 0x91BF)
    int resImul0000_91BF = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_91BF);
    DX = (ushort)(resImul0000_91BF >> 16);
    CheckExternalEvents(cs1, 0x91C4);
    // MOV BX,AX (0000_91C2 / 0x91C2)
    BX = AX;
    CheckExternalEvents(cs1, 0x91CA);
    // TEST byte ptr ES:[BX + 0xc748],0xf (0000_91C4 / 0x91C4)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC748)], 0xF);
    CheckExternalEvents(cs1, 0x91CC);
    // JNZ 0x0000:91e2 (0000_91CA / 0x91CA)
    if(!ZeroFlag) {
      goto label_0000_91E2_091E2;
    }
    CheckExternalEvents(cs1, 0x91CE);
    // SUB AX,AX (0000_91CC / 0x91CC)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x91CF);
    // PUSH AX (0000_91CE / 0x91CE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91D2);
    // PUSH word ptr [BP + -0x1a] (0000_91CF / 0x91CF)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0x91D5);
    // MOV AX,0x14 (0000_91D2 / 0x91D2)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x91D6);
    // PUSH AX (0000_91D5 / 0x91D5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91D9);
    // MOV AX,0xa (0000_91D6 / 0x91D6)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x91DA);
    // PUSH AX (0000_91D9 / 0x91D9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91DD);
    // PUSH word ptr [BP + -0x6] (0000_91DA / 0x91DA)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x91E0);
    // PUSH word ptr [BP + -0x8] (0000_91DD / 0x91DD)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x91E2);
    // JMP 0x0000:91f7 (0000_91E0 / 0x91E0)
    goto label_0000_91F7_091F7;
    label_0000_91E2_091E2:
    CheckExternalEvents(cs1, 0x91E4);
    // SUB AX,AX (0000_91E2 / 0x91E2)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x91E5);
    // PUSH AX (0000_91E4 / 0x91E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91E8);
    // MOV AX,0xf (0000_91E5 / 0x91E5)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x91E9);
    // PUSH AX (0000_91E8 / 0x91E8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91EC);
    // MOV AX,0x14 (0000_91E9 / 0x91E9)
    AX = 0x14;
    CheckExternalEvents(cs1, 0x91ED);
    // PUSH AX (0000_91EC / 0x91EC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91F0);
    // MOV AX,0xa (0000_91ED / 0x91ED)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x91F1);
    // PUSH AX (0000_91F0 / 0x91F0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x91F4);
    // PUSH word ptr [BP + -0x30] (0000_91F1 / 0x91F1)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs1, 0x91F7);
    // PUSH word ptr [BP + -0x32] (0000_91F4 / 0x91F4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x32)]);
    label_0000_91F7_091F7:
    CheckExternalEvents(cs1, 0x91FC);
    // CALLF 0x1000:8ba5 (0000_91F7 / 0x91F7)
    FarCall(cs1, 0x91FC, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x91FF);
    // ADD SP,0xc (0000_91FC / 0x91FC)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x9202);
    // MOV AX,0x7d (0000_91FF / 0x91FF)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9205);
    // IMUL word ptr [BP + -0x2e] (0000_9202 / 0x9202)
    int resImul0000_9202 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9202);
    DX = (ushort)(resImul0000_9202 >> 16);
    CheckExternalEvents(cs1, 0x9207);
    // MOV BX,AX (0000_9205 / 0x9205)
    BX = AX;
    CheckExternalEvents(cs1, 0x920B);
    // MOV ES,word ptr [0x5412] (0000_9207 / 0x9207)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x9210);
    // MOV AL,byte ptr ES:[BX + 0xc749] (0000_920B / 0x920B)
    AL = UInt8[ES, (ushort)(BX + 0xC749)];
    CheckExternalEvents(cs1, 0x9212);
    // AND AL,0xf (0000_9210 / 0x9210)
    AL &= 0xF;
    CheckExternalEvents(cs1, 0x9214);
    // CMP AL,0xf (0000_9212 / 0x9212)
    Alu8.Sub(AL, 0xF);
    CheckExternalEvents(cs1, 0x9216);
    // JNZ 0x0000:922d (0000_9214 / 0x9214)
    if(!ZeroFlag) {
      goto label_0000_922D_0922D;
    }
    CheckExternalEvents(cs1, 0x9218);
    // SUB AX,AX (0000_9216 / 0x9216)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9219);
    // PUSH AX (0000_9218 / 0x9218)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x921C);
    // MOV AX,0xf (0000_9219 / 0x9219)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x921D);
    // PUSH AX (0000_921C / 0x921C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9220);
    // MOV AX,0x15 (0000_921D / 0x921D)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x9221);
    // PUSH AX (0000_9220 / 0x9220)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9224);
    // MOV AX,0xa (0000_9221 / 0x9221)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x9225);
    // PUSH AX (0000_9224 / 0x9224)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9228);
    // PUSH word ptr [BP + -0xa] (0000_9225 / 0x9225)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x922B);
    // PUSH word ptr [BP + -0xc] (0000_9228 / 0x9228)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x922D);
    // JMP 0x0000:9268 (0000_922B / 0x922B)
    goto label_0000_9268_09268;
    label_0000_922D_0922D:
    CheckExternalEvents(cs1, 0x9230);
    // MOV AX,0x7d (0000_922D / 0x922D)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9233);
    // IMUL word ptr [BP + -0x2e] (0000_9230 / 0x9230)
    int resImul0000_9230 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9230);
    DX = (ushort)(resImul0000_9230 >> 16);
    CheckExternalEvents(cs1, 0x9235);
    // MOV BX,AX (0000_9233 / 0x9233)
    BX = AX;
    CheckExternalEvents(cs1, 0x923B);
    // TEST byte ptr ES:[BX + 0xc749],0xf (0000_9235 / 0x9235)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC749)], 0xF);
    CheckExternalEvents(cs1, 0x923D);
    // JNZ 0x0000:9253 (0000_923B / 0x923B)
    if(!ZeroFlag) {
      goto label_0000_9253_09253;
    }
    CheckExternalEvents(cs1, 0x923F);
    // SUB AX,AX (0000_923D / 0x923D)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9240);
    // PUSH AX (0000_923F / 0x923F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9243);
    // PUSH word ptr [BP + -0x1a] (0000_9240 / 0x9240)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0x9246);
    // MOV AX,0x15 (0000_9243 / 0x9243)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x9247);
    // PUSH AX (0000_9246 / 0x9246)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x924A);
    // MOV AX,0xa (0000_9247 / 0x9247)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x924B);
    // PUSH AX (0000_924A / 0x924A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x924E);
    // PUSH word ptr [BP + -0x6] (0000_924B / 0x924B)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x9251);
    // PUSH word ptr [BP + -0x8] (0000_924E / 0x924E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x9253);
    // JMP 0x0000:9268 (0000_9251 / 0x9251)
    goto label_0000_9268_09268;
    label_0000_9253_09253:
    CheckExternalEvents(cs1, 0x9255);
    // SUB AX,AX (0000_9253 / 0x9253)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9256);
    // PUSH AX (0000_9255 / 0x9255)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9259);
    // MOV AX,0xf (0000_9256 / 0x9256)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x925A);
    // PUSH AX (0000_9259 / 0x9259)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x925D);
    // MOV AX,0x15 (0000_925A / 0x925A)
    AX = 0x15;
    CheckExternalEvents(cs1, 0x925E);
    // PUSH AX (0000_925D / 0x925D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9261);
    // MOV AX,0xa (0000_925E / 0x925E)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x9262);
    // PUSH AX (0000_9261 / 0x9261)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9265);
    // PUSH word ptr [BP + -0x30] (0000_9262 / 0x9262)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs1, 0x9268);
    // PUSH word ptr [BP + -0x32] (0000_9265 / 0x9265)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x32)]);
    label_0000_9268_09268:
    CheckExternalEvents(cs1, 0x926D);
    // CALLF 0x1000:8ba5 (0000_9268 / 0x9268)
    FarCall(cs1, 0x926D, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x9270);
    // ADD SP,0xc (0000_926D / 0x926D)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x9273);
    // MOV AX,0x7d (0000_9270 / 0x9270)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9276);
    // IMUL word ptr [BP + -0x2e] (0000_9273 / 0x9273)
    int resImul0000_9273 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9273);
    DX = (ushort)(resImul0000_9273 >> 16);
    CheckExternalEvents(cs1, 0x9278);
    // MOV SI,AX (0000_9276 / 0x9276)
    SI = AX;
    CheckExternalEvents(cs1, 0x927C);
    // MOV ES,word ptr [0x5412] (0000_9278 / 0x9278)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x9281);
    // MOV AL,byte ptr ES:[SI + 0xc748] (0000_927C / 0x927C)
    AL = UInt8[ES, (ushort)(SI + 0xC748)];
    CheckExternalEvents(cs1, 0x9283);
    // AND AL,0xf0 (0000_9281 / 0x9281)
    // AL &= 0xF0;
    AL = Alu8.And(AL, 0xF0);
    CheckExternalEvents(cs1, 0x9288);
    // MOV CL,byte ptr ES:[SI + 0xc78d] (0000_9283 / 0x9283)
    CL = UInt8[ES, (ushort)(SI + 0xC78D)];
    CheckExternalEvents(cs1, 0x928B);
    // AND CL,0xf0 (0000_9288 / 0x9288)
    CL &= 0xF0;
    CheckExternalEvents(cs1, 0x928D);
    // CMP AL,CL (0000_928B / 0x928B)
    Alu8.Sub(AL, CL);
    CheckExternalEvents(cs1, 0x928F);
    // JNZ 0x0000:92a6 (0000_928D / 0x928D)
    if(!ZeroFlag) {
      goto label_0000_92A6_092A6;
    }
    CheckExternalEvents(cs1, 0x9291);
    // SUB AX,AX (0000_928F / 0x928F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9292);
    // PUSH AX (0000_9291 / 0x9291)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9295);
    // MOV AX,0xf (0000_9292 / 0x9292)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x9296);
    // PUSH AX (0000_9295 / 0x9295)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9299);
    // MOV AX,0x16 (0000_9296 / 0x9296)
    AX = 0x16;
    CheckExternalEvents(cs1, 0x929A);
    // PUSH AX (0000_9299 / 0x9299)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x929D);
    // MOV AX,0xa (0000_929A / 0x929A)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x929E);
    // PUSH AX (0000_929D / 0x929D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92A1);
    // PUSH word ptr [BP + -0xa] (0000_929E / 0x929E)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x92A4);
    // PUSH word ptr [BP + -0xc] (0000_92A1 / 0x92A1)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x92A6);
    // JMP 0x0000:92e1 (0000_92A4 / 0x92A4)
    goto label_0000_92E1_092E1;
    label_0000_92A6_092A6:
    CheckExternalEvents(cs1, 0x92A9);
    // MOV AX,0x7d (0000_92A6 / 0x92A6)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x92AC);
    // IMUL word ptr [BP + -0x2e] (0000_92A9 / 0x92A9)
    int resImul0000_92A9 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_92A9);
    DX = (ushort)(resImul0000_92A9 >> 16);
    CheckExternalEvents(cs1, 0x92AE);
    // MOV BX,AX (0000_92AC / 0x92AC)
    BX = AX;
    CheckExternalEvents(cs1, 0x92B4);
    // TEST byte ptr ES:[BX + 0xc748],0xf0 (0000_92AE / 0x92AE)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC748)], 0xF0);
    CheckExternalEvents(cs1, 0x92B6);
    // JNZ 0x0000:92cc (0000_92B4 / 0x92B4)
    if(!ZeroFlag) {
      goto label_0000_92CC_092CC;
    }
    CheckExternalEvents(cs1, 0x92B8);
    // SUB AX,AX (0000_92B6 / 0x92B6)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x92B9);
    // PUSH AX (0000_92B8 / 0x92B8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92BC);
    // PUSH word ptr [BP + -0x1a] (0000_92B9 / 0x92B9)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0x92BF);
    // MOV AX,0x16 (0000_92BC / 0x92BC)
    AX = 0x16;
    CheckExternalEvents(cs1, 0x92C0);
    // PUSH AX (0000_92BF / 0x92BF)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92C3);
    // MOV AX,0xa (0000_92C0 / 0x92C0)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x92C4);
    // PUSH AX (0000_92C3 / 0x92C3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92C7);
    // PUSH word ptr [BP + -0x6] (0000_92C4 / 0x92C4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x92CA);
    // PUSH word ptr [BP + -0x8] (0000_92C7 / 0x92C7)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x92CC);
    // JMP 0x0000:92e1 (0000_92CA / 0x92CA)
    goto label_0000_92E1_092E1;
    label_0000_92CC_092CC:
    CheckExternalEvents(cs1, 0x92CE);
    // SUB AX,AX (0000_92CC / 0x92CC)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x92CF);
    // PUSH AX (0000_92CE / 0x92CE)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92D2);
    // MOV AX,0xf (0000_92CF / 0x92CF)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x92D3);
    // PUSH AX (0000_92D2 / 0x92D2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92D6);
    // MOV AX,0x16 (0000_92D3 / 0x92D3)
    AX = 0x16;
    CheckExternalEvents(cs1, 0x92D7);
    // PUSH AX (0000_92D6 / 0x92D6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92DA);
    // MOV AX,0xa (0000_92D7 / 0x92D7)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x92DB);
    // PUSH AX (0000_92DA / 0x92DA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x92DE);
    // PUSH word ptr [BP + -0x30] (0000_92DB / 0x92DB)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs1, 0x92E1);
    // PUSH word ptr [BP + -0x32] (0000_92DE / 0x92DE)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x32)]);
    label_0000_92E1_092E1:
    CheckExternalEvents(cs1, 0x92E6);
    // CALLF 0x1000:8ba5 (0000_92E1 / 0x92E1)
    FarCall(cs1, 0x92E6, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x92E9);
    // ADD SP,0xc (0000_92E6 / 0x92E6)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x92EC);
    // MOV AX,0x7d (0000_92E9 / 0x92E9)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x92EF);
    // IMUL word ptr [BP + -0x2e] (0000_92EC / 0x92EC)
    int resImul0000_92EC = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_92EC);
    DX = (ushort)(resImul0000_92EC >> 16);
    CheckExternalEvents(cs1, 0x92F1);
    // MOV SI,AX (0000_92EF / 0x92EF)
    SI = AX;
    CheckExternalEvents(cs1, 0x92F5);
    // MOV ES,word ptr [0x5412] (0000_92F1 / 0x92F1)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x92FA);
    // MOV AL,byte ptr ES:[SI + 0xc749] (0000_92F5 / 0x92F5)
    AL = UInt8[ES, (ushort)(SI + 0xC749)];
    CheckExternalEvents(cs1, 0x92FC);
    // AND AL,0xf0 (0000_92FA / 0x92FA)
    // AL &= 0xF0;
    AL = Alu8.And(AL, 0xF0);
    CheckExternalEvents(cs1, 0x9301);
    // MOV CL,byte ptr ES:[SI + 0xc78e] (0000_92FC / 0x92FC)
    CL = UInt8[ES, (ushort)(SI + 0xC78E)];
    CheckExternalEvents(cs1, 0x9304);
    // AND CL,0xf0 (0000_9301 / 0x9301)
    CL &= 0xF0;
    CheckExternalEvents(cs1, 0x9306);
    // CMP AL,CL (0000_9304 / 0x9304)
    Alu8.Sub(AL, CL);
    CheckExternalEvents(cs1, 0x9308);
    // JNZ 0x0000:931f (0000_9306 / 0x9306)
    if(!ZeroFlag) {
      goto label_0000_931F_0931F;
    }
    CheckExternalEvents(cs1, 0x930A);
    // SUB AX,AX (0000_9308 / 0x9308)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x930B);
    // PUSH AX (0000_930A / 0x930A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x930E);
    // MOV AX,0xf (0000_930B / 0x930B)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x930F);
    // PUSH AX (0000_930E / 0x930E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9312);
    // MOV AX,0x17 (0000_930F / 0x930F)
    AX = 0x17;
    CheckExternalEvents(cs1, 0x9313);
    // PUSH AX (0000_9312 / 0x9312)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9316);
    // MOV AX,0xa (0000_9313 / 0x9313)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x9317);
    // PUSH AX (0000_9316 / 0x9316)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x931A);
    // PUSH word ptr [BP + -0xa] (0000_9317 / 0x9317)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x931D);
    // PUSH word ptr [BP + -0xc] (0000_931A / 0x931A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0x931F);
    // JMP 0x0000:935a (0000_931D / 0x931D)
    goto label_0000_935A_0935A;
    label_0000_931F_0931F:
    CheckExternalEvents(cs1, 0x9322);
    // MOV AX,0x7d (0000_931F / 0x931F)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x9325);
    // IMUL word ptr [BP + -0x2e] (0000_9322 / 0x9322)
    int resImul0000_9322 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9322);
    DX = (ushort)(resImul0000_9322 >> 16);
    CheckExternalEvents(cs1, 0x9327);
    // MOV BX,AX (0000_9325 / 0x9325)
    BX = AX;
    CheckExternalEvents(cs1, 0x932D);
    // TEST byte ptr ES:[BX + 0xc749],0xf0 (0000_9327 / 0x9327)
    Alu8.And(UInt8[ES, (ushort)(BX + 0xC749)], 0xF0);
    CheckExternalEvents(cs1, 0x932F);
    // JNZ 0x0000:9345 (0000_932D / 0x932D)
    if(!ZeroFlag) {
      goto label_0000_9345_09345;
    }
    CheckExternalEvents(cs1, 0x9331);
    // SUB AX,AX (0000_932F / 0x932F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9332);
    // PUSH AX (0000_9331 / 0x9331)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9335);
    // PUSH word ptr [BP + -0x1a] (0000_9332 / 0x9332)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0x9338);
    // MOV AX,0x17 (0000_9335 / 0x9335)
    AX = 0x17;
    CheckExternalEvents(cs1, 0x9339);
    // PUSH AX (0000_9338 / 0x9338)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x933C);
    // MOV AX,0xa (0000_9339 / 0x9339)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x933D);
    // PUSH AX (0000_933C / 0x933C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9340);
    // PUSH word ptr [BP + -0x6] (0000_933D / 0x933D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x9343);
    // PUSH word ptr [BP + -0x8] (0000_9340 / 0x9340)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x8)]);
    CheckExternalEvents(cs1, 0x9345);
    // JMP 0x0000:935a (0000_9343 / 0x9343)
    goto label_0000_935A_0935A;
    label_0000_9345_09345:
    CheckExternalEvents(cs1, 0x9347);
    // SUB AX,AX (0000_9345 / 0x9345)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9348);
    // PUSH AX (0000_9347 / 0x9347)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x934B);
    // MOV AX,0xf (0000_9348 / 0x9348)
    AX = 0xF;
    CheckExternalEvents(cs1, 0x934C);
    // PUSH AX (0000_934B / 0x934B)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x934F);
    // MOV AX,0x17 (0000_934C / 0x934C)
    AX = 0x17;
    CheckExternalEvents(cs1, 0x9350);
    // PUSH AX (0000_934F / 0x934F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9353);
    // MOV AX,0xa (0000_9350 / 0x9350)
    AX = 0xA;
    CheckExternalEvents(cs1, 0x9354);
    // PUSH AX (0000_9353 / 0x9353)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9357);
    // PUSH word ptr [BP + -0x30] (0000_9354 / 0x9354)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x30)]);
    CheckExternalEvents(cs1, 0x935A);
    // PUSH word ptr [BP + -0x32] (0000_9357 / 0x9357)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x32)]);
    label_0000_935A_0935A:
    CheckExternalEvents(cs1, 0x935F);
    // CALLF 0x1000:8ba5 (0000_935A / 0x935A)
    FarCall(cs1, 0x935F, unknown_18AD_00D5_18BA5);
    CheckExternalEvents(cs1, 0x9362);
    // ADD SP,0xc (0000_935F / 0x935F)
    // SP += 0xC;
    SP = Alu16.Add(SP, 0xC);
    CheckExternalEvents(cs1, 0x9367);
    // MOV word ptr [BP + -0x2a],0x0 (0000_9362 / 0x9362)
    UInt16[SS, (ushort)(BP - 0x2A)] = 0x0;
    CheckExternalEvents(cs1, 0x936C);
    // MOV word ptr [BP + -0x4],0x258 (0000_9367 / 0x9367)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x258;
    CheckExternalEvents(cs1, 0x936F);
    // JMP 0x0000:9491 (0000_936C / 0x936C)
    goto label_0000_9491_09491;
    label_0000_936F_0936F:
    CheckExternalEvents(cs1, 0x9374);
    // MOV word ptr [BP + -0x24],0x0 (0000_936F / 0x936F)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x0;
    label_0000_9374_09374:
    CheckExternalEvents(cs1, 0x9379);
    // MOV word ptr [BP + -0x1c],0x0 (0000_9374 / 0x9374)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x0;
    CheckExternalEvents(cs1, 0x937C);
    // MOV BX,word ptr [BP + -0x24] (0000_9379 / 0x9379)
    BX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x937E);
    // SHL BX,0x1 (0000_937C / 0x937C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x9382);
    // MOV SI,word ptr [BX + 0x1306] (0000_937E / 0x937E)
    SI = UInt16[DS, (ushort)(BX + 0x1306)];
    CheckExternalEvents(cs1, 0x9384);
    // OR SI,SI (0000_9382 / 0x9382)
    // SI |= SI;
    SI = Alu16.Or(SI, SI);
    CheckExternalEvents(cs1, 0x9386);
    // JZ 0x0000:939e (0000_9384 / 0x9384)
    if(ZeroFlag) {
      goto label_0000_939E_0939E;
    }
    CheckExternalEvents(cs1, 0x9389);
    // MOV AX,0x7d (0000_9386 / 0x9386)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x938C);
    // IMUL word ptr [BP + -0x2e] (0000_9389 / 0x9389)
    int resImul0000_9389 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_9389);
    DX = (ushort)(resImul0000_9389 >> 16);
    CheckExternalEvents(cs1, 0x938E);
    // MOV BX,AX (0000_938C / 0x938C)
    BX = AX;
    CheckExternalEvents(cs1, 0x9390);
    // ADD BX,SI (0000_938E / 0x938E)
    // BX += SI;
    BX = Alu16.Add(BX, SI);
    CheckExternalEvents(cs1, 0x9394);
    // MOV ES,word ptr [0x5412] (0000_9390 / 0x9390)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x9399);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_9394 / 0x9394)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0x939B);
    // SUB AH,AH (0000_9399 / 0x9399)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0x939E);
    // MOV word ptr [BP + -0x1c],AX (0000_939B / 0x939B)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    label_0000_939E_0939E:
    CheckExternalEvents(cs1, 0x93A1);
    // MOV SI,word ptr [BP + -0x24] (0000_939E / 0x939E)
    SI = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0x93A3);
    // SHL SI,0x1 (0000_93A1 / 0x93A1)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0x93A6);
    // PUSH word ptr [BP + -0x1c] (0000_93A3 / 0x93A3)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs1, 0x93A9);
    // MOV AX,0x7d (0000_93A6 / 0x93A6)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0x93AC);
    // IMUL word ptr [BP + -0x2e] (0000_93A9 / 0x93A9)
    int resImul0000_93A9 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2E)]);
    AX = (ushort)(resImul0000_93A9);
    DX = (ushort)(resImul0000_93A9 >> 16);
    CheckExternalEvents(cs1, 0x93AE);
    // MOV BX,AX (0000_93AC / 0x93AC)
    BX = AX;
    CheckExternalEvents(cs1, 0x93B1);
    // ADD BX,word ptr [BP + -0x24] (0000_93AE / 0x93AE)
    // BX += UInt16[SS, (ushort)(BP - 0x24)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs1, 0x93B5);
    // MOV ES,word ptr [0x5412] (0000_93B1 / 0x93B1)
    ES = UInt16[DS, 0x5412];
    CheckExternalEvents(cs1, 0x93BA);
    // MOV AL,byte ptr ES:[BX + 0xc735] (0000_93B5 / 0x93B5)
    AL = UInt8[ES, (ushort)(BX + 0xC735)];
    CheckExternalEvents(cs1, 0x93BC);
    // SUB AH,AH (0000_93BA / 0x93BA)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs1, 0x93BD);
    // PUSH AX (0000_93BC / 0x93BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x93C1);
    // PUSH word ptr [SI + 0x1332] (0000_93BD / 0x93BD)
    Stack.Push16(UInt16[DS, (ushort)(SI + 0x1332)]);
    CheckExternalEvents(cs1, 0x93C5);
    // PUSH word ptr [SI + 0x131c] (0000_93C1 / 0x93C1)
    Stack.Push16(UInt16[DS, (ushort)(SI + 0x131C)]);
    CheckExternalEvents(cs1, 0x93C6);
    // PUSH CS (0000_93C5 / 0x93C5)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x93C9);
    // CALL 0x0000:88fc (0000_93C6 / 0x93C6)
    NearCall(cs1, 0x93C9, ghidra_guess_0000_88FC_088FC);
    CheckExternalEvents(cs1, 0x93CC);
    // ADD SP,0x8 (0000_93C9 / 0x93C9)
    SP += 0x8;
    CheckExternalEvents(cs1, 0x93CF);
    // INC word ptr [BP + -0x24] (0000_93CC / 0x93CC)
    UInt16[SS, (ushort)(BP - 0x24)]++;
    CheckExternalEvents(cs1, 0x93D3);
    // CMP word ptr [BP + -0x24],0xb (0000_93CF / 0x93CF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0xB);
    CheckExternalEvents(cs1, 0x93D5);
    // JL 0x0000:9374 (0000_93D3 / 0x93D3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_9374_09374;
    }
    CheckExternalEvents(cs1, 0x93D8);
    // MOV BX,word ptr [BP + -0x2e] (0000_93D5 / 0x93D5)
    BX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x93DC);
    // MOV ES,word ptr [0x5458] (0000_93D8 / 0x93D8)
    ES = UInt16[DS, 0x5458];
    CheckExternalEvents(cs1, 0x93E2);
    // CMP byte ptr ES:[BX + 0x6e],0x0 (0000_93DC / 0x93DC)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x0);
    CheckExternalEvents(cs1, 0x93E4);
    // JGE 0x0000:93ea (0000_93E2 / 0x93E2)
    if(SignFlag == OverflowFlag) {
      goto label_0000_93EA_093EA;
    }
    CheckExternalEvents(cs1, 0x93EA);
    // MOV byte ptr ES:[BX + 0x6e],0x0 (0000_93E4 / 0x93E4)
    UInt8[ES, (ushort)(BX + 0x6E)] = 0x0;
    label_0000_93EA_093EA:
    CheckExternalEvents(cs1, 0x93ED);
    // MOV BX,word ptr [BP + -0x2e] (0000_93EA / 0x93EA)
    BX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x93F3);
    // CMP byte ptr ES:[BX + 0x6e],0x1e (0000_93ED / 0x93ED)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x6E)], 0x1E);
    CheckExternalEvents(cs1, 0x93F5);
    // JLE 0x0000:93fb (0000_93F3 / 0x93F3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_93FB_093FB;
    }
    CheckExternalEvents(cs1, 0x93FB);
    // MOV byte ptr ES:[BX + 0x6e],0x1e (0000_93F5 / 0x93F5)
    UInt8[ES, (ushort)(BX + 0x6E)] = 0x1E;
    label_0000_93FB_093FB:
    CheckExternalEvents(cs1, 0x93FE);
    // MOV BX,word ptr [BP + -0x2e] (0000_93FB / 0x93FB)
    BX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs1, 0x9403);
    // MOV AL,byte ptr ES:[BX + 0x6e] (0000_93FE / 0x93FE)
    AL = UInt8[ES, (ushort)(BX + 0x6E)];
    CheckExternalEvents(cs1, 0x9404);
    // CBW  (0000_9403 / 0x9403)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9406);
    // MOV SI,AX (0000_9404 / 0x9404)
    SI = AX;
    CheckExternalEvents(cs1, 0x9407);
    // PUSH SI (0000_9406 / 0x9406)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0x940A);
    // MOV AX,0x1e (0000_9407 / 0x9407)
    AX = 0x1E;
    CheckExternalEvents(cs1, 0x940C);
    // SUB AX,SI (0000_940A / 0x940A)
    // AX -= SI;
    AX = Alu16.Sub(AX, SI);
    CheckExternalEvents(cs1, 0x940D);
    // PUSH AX (0000_940C / 0x940C)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9410);
    // MOV AX,0xb7 (0000_940D / 0x940D)
    AX = 0xB7;
    CheckExternalEvents(cs1, 0x9411);
    // PUSH AX (0000_9410 / 0x9410)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9414);
    // MOV AX,0x100 (0000_9411 / 0x9411)
    AX = 0x100;
    CheckExternalEvents(cs1, 0x9415);
    // PUSH AX (0000_9414 / 0x9414)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9416);
    // PUSH CS (0000_9415 / 0x9415)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x9419);
    // CALL 0x0000:88fc (0000_9416 / 0x9416)
    NearCall(cs1, 0x9419, ghidra_guess_0000_88FC_088FC);
    CheckExternalEvents(cs1, 0x941C);
    // ADD SP,0x8 (0000_9419 / 0x9419)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs1, 0x941F);
    // MOV AX,0x1 (0000_941C / 0x941C)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x9420);
    // PUSH AX (0000_941F / 0x941F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9425);
    // CALLF 0x1000:8ad6 (0000_9420 / 0x9420)
    FarCall(cs1, 0x9425, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs1, 0x9428);
    // ADD SP,0x2 (0000_9425 / 0x9425)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x942B);
    // INC word ptr [BP + -0x22] (0000_9428 / 0x9428)
    UInt16[SS, (ushort)(BP - 0x22)]++;
    CheckExternalEvents(cs1, 0x942F);
    // CMP word ptr [BP + -0x22],0x10 (0000_942B / 0x942B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0x10);
    CheckExternalEvents(cs1, 0x9431);
    // JNZ 0x0000:946d (0000_942F / 0x942F)
    if(!ZeroFlag) {
      goto label_0000_946D_0946D;
    }
    CheckExternalEvents(cs1, 0x9435);
    // MOV ES,word ptr [0x5426] (0000_9431 / 0x9431)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x943B);
    // CMP word ptr ES:[0x4fba],0x3 (0000_9435 / 0x9435)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x3);
    CheckExternalEvents(cs1, 0x943D);
    // JZ 0x0000:9442 (0000_943B / 0x943B)
    if(ZeroFlag) {
      goto label_0000_9442_09442;
    }
    CheckExternalEvents(cs1, 0x9440);
    // MOV AX,0x1348 (0000_943D / 0x943D)
    AX = 0x1348;
    CheckExternalEvents(cs1, 0x9442);
    // JMP 0x0000:9445 (0000_9440 / 0x9440)
    goto label_0000_9445_09445;
    label_0000_9442_09442:
    CheckExternalEvents(cs1, 0x9445);
    // MOV AX,0x1358 (0000_9442 / 0x9442)
    AX = 0x1358;
    label_0000_9445_09445:
    CheckExternalEvents(cs1, 0x9446);
    // PUSH DS (0000_9445 / 0x9445)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9447);
    // PUSH AX (0000_9446 / 0x9446)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x944C);
    // CALLF 0x1000:8ff5 (0000_9447 / 0x9447)
    FarCall(cs1, 0x944C, unknown_18AD_0525_18FF5);
    CheckExternalEvents(cs1, 0x944F);
    // ADD SP,0x4 (0000_944C / 0x944C)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x9452);
    // INC word ptr [BP + -0x2c] (0000_944F / 0x944F)
    UInt16[SS, (ushort)(BP - 0x2C)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs1, 0x9455);
    // MOV AX,word ptr [BP + -0x2c] (0000_9452 / 0x9452)
    AX = UInt16[SS, (ushort)(BP - 0x2C)];
    CheckExternalEvents(cs1, 0x9458);
    // AND AX,0x3 (0000_9455 / 0x9455)
    // AX &= 0x3;
    AX = Alu16.And(AX, 0x3);
    CheckExternalEvents(cs1, 0x945B);
    // MOV word ptr [BP + -0x2c],AX (0000_9458 / 0x9458)
    UInt16[SS, (ushort)(BP - 0x2C)] = AX;
    CheckExternalEvents(cs1, 0x945D);
    // MOV BX,AX (0000_945B / 0x945B)
    BX = AX;
    CheckExternalEvents(cs1, 0x9461);
    // MOV AL,byte ptr [BX + 0x1378] (0000_945D / 0x945D)
    AL = UInt8[DS, (ushort)(BX + 0x1378)];
    CheckExternalEvents(cs1, 0x9464);
    // MOV [0x134c],AL (0000_9461 / 0x9461)
    UInt8[DS, 0x134C] = AL;
    CheckExternalEvents(cs1, 0x9466);
    // SHL BX,0x1 (0000_9464 / 0x9464)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0x946A);
    // MOV AX,word ptr [BX + 0x137c] (0000_9466 / 0x9466)
    AX = UInt16[DS, (ushort)(BX + 0x137C)];
    CheckExternalEvents(cs1, 0x946D);
    // MOV [0x1360],AX (0000_946A / 0x946A)
    UInt16[DS, 0x1360] = AX;
    label_0000_946D_0946D:
    CheckExternalEvents(cs1, 0x9471);
    // AND word ptr [BP + -0x22],0xf (0000_946D / 0x946D)
    // UInt16[SS, (ushort)(BP - 0x22)] &= 0xF;
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x22)], 0xF);
    CheckExternalEvents(cs1, 0x9475);
    // MOV ES,word ptr [0x545a] (0000_9471 / 0x9471)
    ES = UInt16[DS, 0x545A];
    CheckExternalEvents(cs1, 0x947B);
    // CMP word ptr ES:[0x3938],0x0 (0000_9475 / 0x9475)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs1, 0x947D);
    // JNZ 0x0000:9487 (0000_947B / 0x947B)
    if(!ZeroFlag) {
      goto label_0000_9487_09487;
    }
    CheckExternalEvents(cs1, 0x9482);
    // CALLF 0x1000:8aff (0000_947D / 0x947D)
    FarCall(cs1, 0x9482, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs1, 0x9485);
    // MOV word ptr [BP + -0x2a],AX (0000_9482 / 0x9482)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs1, 0x9487);
    // JMP 0x0000:9491 (0000_9485 / 0x9485)
    goto label_0000_9491_09491;
    label_0000_9487_09487:
    CheckExternalEvents(cs1, 0x948A);
    // DEC word ptr [BP + -0x4] (0000_9487 / 0x9487)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0x948C);
    // JNZ 0x0000:9491 (0000_948A / 0x948A)
    if(!ZeroFlag) {
      goto label_0000_9491_09491;
    }
    CheckExternalEvents(cs1, 0x9491);
    // MOV word ptr [BP + -0x2a],0x1 (0000_948C / 0x948C)
    UInt16[SS, (ushort)(BP - 0x2A)] = 0x1;
    label_0000_9491_09491:
    CheckExternalEvents(cs1, 0x9495);
    // CMP word ptr [BP + -0x2a],0x0 (0000_9491 / 0x9491)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2A)], 0x0);
    CheckExternalEvents(cs1, 0x9497);
    // JNZ 0x0000:949a (0000_9495 / 0x9495)
    if(!ZeroFlag) {
      goto label_0000_949A_0949A;
    }
    CheckExternalEvents(cs1, 0x949A);
    // JMP 0x0000:936f (0000_9497 / 0x9497)
    goto label_0000_936F_0936F;
    label_0000_949A_0949A:
    CheckExternalEvents(cs1, 0x949E);
    // MOV ES,word ptr [0x5426] (0000_949A / 0x949A)
    ES = UInt16[DS, 0x5426];
    CheckExternalEvents(cs1, 0x94A4);
    // CMP word ptr ES:[0x4fba],0x3 (0000_949E / 0x949E)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x3);
    CheckExternalEvents(cs1, 0x94A6);
    // JZ 0x0000:94ae (0000_94A4 / 0x94A4)
    if(ZeroFlag) {
      goto label_0000_94AE_094AE;
    }
    CheckExternalEvents(cs1, 0x94A9);
    // MOV AX,0x0 (0000_94A6 / 0x94A6)
    AX = 0x0;
    CheckExternalEvents(cs1, 0x94AC);
    // MOV DX,0x2958 (0000_94A9 / 0x94A9)
    DX = 0x2958;
    CheckExternalEvents(cs1, 0x94AE);
    // JMP 0x0000:94b4 (0000_94AC / 0x94AC)
    goto label_0000_94B4_094B4;
    label_0000_94AE_094AE:
    CheckExternalEvents(cs1, 0x94B1);
    // MOV AX,0x10 (0000_94AE / 0x94AE)
    AX = 0x10;
    CheckExternalEvents(cs1, 0x94B4);
    // MOV DX,0x2958 (0000_94B1 / 0x94B1)
    DX = 0x2958;
    label_0000_94B4_094B4:
    CheckExternalEvents(cs1, 0x94B5);
    // PUSH DX (0000_94B4 / 0x94B4)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x94B6);
    // PUSH AX (0000_94B5 / 0x94B5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x94BB);
    // CALLF 0x1000:8ff5 (0000_94B6 / 0x94B6)
    FarCall(cs1, 0x94BB, unknown_18AD_0525_18FF5);
    CheckExternalEvents(cs1, 0x94BE);
    // ADD SP,0x4 (0000_94BB / 0x94BB)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x94C3);
    // CALLF 0x1000:8d29 (0000_94BE / 0x94BE)
    FarCall(cs1, 0x94C3, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x94C4);
    // POP SI (0000_94C3 / 0x94C3)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x94C6);
    // MOV SP,BP (0000_94C4 / 0x94C4)
    SP = BP;
    CheckExternalEvents(cs1, 0x94C7);
    // POP BP (0000_94C6 / 0x94C6)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x94C8);
    // RETF  (0000_94C7 / 0x94C7)
    return FarRet();
  }
  
}
