namespace generated;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action unknown_094C_0008_094C8(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_094C_0008_094C8:
    CheckExternalEvents(cs5, 0x9);
    // PUSH BP (094C_0008 / 0x94C8)
    Stack.Push16(BP);
    CheckExternalEvents(cs5, 0xB);
    // MOV BP,SP (094C_0009 / 0x94C9)
    BP = SP;
    CheckExternalEvents(cs5, 0xE);
    // MOV AX,0xa (094C_000B / 0x94CB)
    AX = 0xA;
    CheckExternalEvents(cs5, 0x13);
    // CALLF 0x1000:cecc (094C_000E / 0x94CE)
    FarCall(cs5, 0x13, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs5, 0x17);
    // MOV ES,word ptr [0x545c] (094C_0013 / 0x94D3)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0x1D);
    // MOV byte ptr ES:[0xd316],0x1 (094C_0017 / 0x94D7)
    UInt8[ES, 0xD316] = 0x1;
    CheckExternalEvents(cs5, 0x21);
    // MOV ES,word ptr [0x545e] (094C_001D / 0x94DD)
    ES = UInt16[DS, 0x545E];
    CheckExternalEvents(cs5, 0x24);
    // MOV AX,word ptr [BP + 0x6] (094C_0021 / 0x94E1)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs5, 0x28);
    // MOV ES:[0x4584],AX (094C_0024 / 0x94E4)
    UInt16[ES, 0x4584] = AX;
    CheckExternalEvents(cs5, 0x2B);
    // CMP AX,0x12 (094C_0028 / 0x94E8)
    Alu.Sub16(AX, 0x12);
    CheckExternalEvents(cs5, 0x2D);
    // JZ 0x0000:9501 (094C_002B / 0x94EB)
    if(ZeroFlag) {
      goto label_094C_0041_09501;
    }
    CheckExternalEvents(cs5, 0x30);
    // CMP AX,0x16 (094C_002D / 0x94ED)
    Alu.Sub16(AX, 0x16);
    CheckExternalEvents(cs5, 0x32);
    // JGE 0x0000:9501 (094C_0030 / 0x94F0)
    if(SignFlag == OverflowFlag) {
      goto label_094C_0041_09501;
    }
    CheckExternalEvents(cs5, 0x34);
    // MOV BX,AX (094C_0032 / 0x94F2)
    BX = AX;
    CheckExternalEvents(cs5, 0x38);
    // MOV ES,word ptr [0x5460] (094C_0034 / 0x94F4)
    ES = UInt16[DS, 0x5460];
    CheckExternalEvents(cs5, 0x3D);
    // MOV AL,byte ptr ES:[BX + 0x4602] (094C_0038 / 0x94F8)
    AL = UInt8[ES, (ushort)(BX + 0x4602)];
    CheckExternalEvents(cs5, 0x3E);
    // CBW  (094C_003D / 0x94FD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs5, 0x41);
    // MOV word ptr [BP + 0x6],AX (094C_003E / 0x94FE)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    label_094C_0041_09501:
    CheckExternalEvents(cs5, 0x44);
    // MOV AX,0x1 (094C_0041 / 0x9501)
    AX = 0x1;
    CheckExternalEvents(cs5, 0x45);
    // PUSH AX (094C_0044 / 0x9504)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x4A);
    // CALLF 0x0000:3fcc (094C_0045 / 0x9505)
    FarCall(cs5, 0x4A, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs5, 0x4D);
    // ADD SP,0x2 (094C_004A / 0x950A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x52);
    // MOV word ptr [BP + -0x8],0x1 (094C_004D / 0x950D)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs5, 0x56);
    // CMP word ptr [BP + 0x6],0x0 (094C_0052 / 0x9512)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs5, 0x58);
    // JNZ 0x0000:9545 (094C_0056 / 0x9516)
    if(!ZeroFlag) {
      goto label_094C_0085_09545;
    }
    CheckExternalEvents(cs5, 0x5C);
    // MOV ES,word ptr [0x545c] (094C_0058 / 0x9518)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0x62);
    // CMP byte ptr ES:[0xd320],0x0 (094C_005C / 0x951C)
    Alu.Sub8(UInt8[ES, 0xD320], 0x0);
    CheckExternalEvents(cs5, 0x64);
    // JNZ 0x0000:9545 (094C_0062 / 0x9522)
    if(!ZeroFlag) {
      goto label_094C_0085_09545;
    }
    CheckExternalEvents(cs5, 0x68);
    // MOV ES,word ptr [0x5462] (094C_0064 / 0x9524)
    ES = UInt16[DS, 0x5462];
    CheckExternalEvents(cs5, 0x6C);
    // MOV AX,ES:[0x3938] (094C_0068 / 0x9528)
    AX = UInt16[ES, 0x3938];
    CheckExternalEvents(cs5, 0x70);
    // MOV ES,word ptr [0x5464] (094C_006C / 0x952C)
    ES = UInt16[DS, 0x5464];
    CheckExternalEvents(cs5, 0x75);
    // OR AX,word ptr ES:[0x458c] (094C_0070 / 0x9530)
    // AX |= UInt16[ES, 0x458C];
    AX = Alu.Or16(AX, UInt16[ES, 0x458C]);
    CheckExternalEvents(cs5, 0x77);
    // JNZ 0x0000:9545 (094C_0075 / 0x9535)
    if(!ZeroFlag) {
      goto label_094C_0085_09545;
    }
    CheckExternalEvents(cs5, 0x7C);
    // CALLF 0x0000:e618 (094C_0077 / 0x9537)
    FarCall(cs5, 0x7C, ghidra_guess_0000_E618_0E618);
    CheckExternalEvents(cs5, 0x7E);
    // OR AX,AX (094C_007C / 0x953C)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs5, 0x80);
    // JZ 0x0000:9545 (094C_007E / 0x953E)
    if(ZeroFlag) {
      goto label_094C_0085_09545;
    }
    CheckExternalEvents(cs5, 0x85);
    // MOV word ptr [BP + -0x8],0x0 (094C_0080 / 0x9540)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_094C_0085_09545:
    CheckExternalEvents(cs5, 0x89);
    // CMP word ptr [BP + -0x8],0x0 (094C_0085 / 0x9545)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs5, 0x8B);
    // JNZ 0x0000:954e (094C_0089 / 0x9549)
    if(!ZeroFlag) {
      goto label_094C_008E_0954E;
    }
    CheckExternalEvents(cs5, 0x8E);
    // JMP 0x0000:967c (094C_008B / 0x954B)
    goto label_094C_01BC_0967C;
    label_094C_008E_0954E:
    CheckExternalEvents(cs5, 0x91);
    // PUSH word ptr [BP + 0x6] (094C_008E / 0x954E)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs5, 0x92);
    // PUSH CS (094C_0091 / 0x9551)
    Stack.Push16(cs5);
    CheckExternalEvents(cs5, 0x95);
    // CALL 0x0000:b1f0 (094C_0092 / 0x9552)
    NearCall(cs5, 0x95, unknown_094C_1D30_0B1F0);
    CheckExternalEvents(cs5, 0x98);
    // ADD SP,0x2 (094C_0095 / 0x9555)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x9B);
    // MOV BX,word ptr [BP + 0x6] (094C_0098 / 0x9558)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs5, 0xA0);
    // CMP byte ptr [BX + 0x141a],0x0 (094C_009B / 0x955B)
    Alu.Sub8(UInt8[DS, (ushort)(BX + 0x141A)], 0x0);
    CheckExternalEvents(cs5, 0xA2);
    // JZ 0x0000:9574 (094C_00A0 / 0x9560)
    if(ZeroFlag) {
      goto label_094C_00B4_09574;
    }
    CheckExternalEvents(cs5, 0xA5);
    // MOV AX,0x1 (094C_00A2 / 0x9562)
    AX = 0x1;
    CheckExternalEvents(cs5, 0xA6);
    // PUSH AX (094C_00A5 / 0x9565)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0xAA);
    // MOV AL,byte ptr [BX + 0x141a] (094C_00A6 / 0x9566)
    AL = UInt8[DS, (ushort)(BX + 0x141A)];
    CheckExternalEvents(cs5, 0xAB);
    // CBW  (094C_00AA / 0x956A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs5, 0xAC);
    // PUSH AX (094C_00AB / 0x956B)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0xB1);
    // CALLF 0x0000:5fb7 (094C_00AC / 0x956C)
    FarCall(cs5, 0xB1, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs5, 0xB4);
    // ADD SP,0x4 (094C_00B1 / 0x9571)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    label_094C_00B4_09574:
    CheckExternalEvents(cs5, 0xB7);
    // MOV AX,0xa0 (094C_00B4 / 0x9574)
    AX = 0xA0;
    CheckExternalEvents(cs5, 0xBA);
    // MOV DX,0x2a02 (094C_00B7 / 0x9577)
    DX = 0x2A02;
    CheckExternalEvents(cs5, 0xBB);
    // PUSH DX (094C_00BA / 0x957A)
    Stack.Push16(DX);
    CheckExternalEvents(cs5, 0xBC);
    // PUSH AX (094C_00BB / 0x957B)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0xBD);
    // PUSH CS (094C_00BC / 0x957C)
    Stack.Push16(cs5);
    CheckExternalEvents(cs5, 0xC0);
    // CALL 0x0000:9680 (094C_00BD / 0x957D)
    NearCall(cs5, 0xC0, unknown_094C_01C0_09680);
    CheckExternalEvents(cs5, 0xC3);
    // ADD SP,0x4 (094C_00C0 / 0x9580)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs5, 0xC6);
    // MOV AX,0xe (094C_00C3 / 0x9583)
    AX = 0xE;
    CheckExternalEvents(cs5, 0xC7);
    // PUSH AX (094C_00C6 / 0x9586)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0xCC);
    // CALLF 0x1000:6434 (094C_00C7 / 0x9587)
    FarCall(cs5, 0xCC, unknown_1643_0004_16434);
    CheckExternalEvents(cs5, 0xCF);
    // ADD SP,0x2 (094C_00CC / 0x958C)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0xD3);
    // MOV ES,word ptr [0x545c] (094C_00CF / 0x958F)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0xD9);
    // CMP byte ptr ES:[0xd33e],0x0 (094C_00D3 / 0x9593)
    Alu.Sub8(UInt8[ES, 0xD33E], 0x0);
    CheckExternalEvents(cs5, 0xDB);
    // JNZ 0x0000:95f6 (094C_00D9 / 0x9599)
    if(!ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xDF);
    // CMP word ptr [BP + 0x6],0x8 (094C_00DB / 0x959B)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs5, 0xE1);
    // JNZ 0x0000:95f6 (094C_00DF / 0x959F)
    if(!ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xE7);
    // CMP byte ptr ES:[0xd33c],0x0 (094C_00E1 / 0x95A1)
    Alu.Sub8(UInt8[ES, 0xD33C], 0x0);
    CheckExternalEvents(cs5, 0xE9);
    // JZ 0x0000:95f6 (094C_00E7 / 0x95A7)
    if(ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xEF);
    // CMP byte ptr ES:[0xd31a],0x0 (094C_00E9 / 0x95A9)
    Alu.Sub8(UInt8[ES, 0xD31A], 0x0);
    CheckExternalEvents(cs5, 0xF1);
    // JZ 0x0000:95f6 (094C_00EF / 0x95AF)
    if(ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xF4);
    // MOV AX,0x6 (094C_00F1 / 0x95B1)
    AX = 0x6;
    CheckExternalEvents(cs5, 0xF5);
    // PUSH AX (094C_00F4 / 0x95B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0xFA);
    // CALLF 0x1000:7ee1 (094C_00F5 / 0x95B5)
    FarCall(cs5, 0xFA, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs5, 0xFD);
    // ADD SP,0x2 (094C_00FA / 0x95BA)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x102);
    // CALLF 0x1000:7fe8 (094C_00FD / 0x95BD)
    FarCall(cs5, 0x102, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs5, 0x105);
    // MOV AX,0x1384 (094C_0102 / 0x95C2)
    AX = 0x1384;
    CheckExternalEvents(cs5, 0x106);
    // PUSH DS (094C_0105 / 0x95C5)
    Stack.Push16(DS);
    CheckExternalEvents(cs5, 0x107);
    // PUSH AX (094C_0106 / 0x95C6)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x10C);
    // CALLF 0x1000:8055 (094C_0107 / 0x95C7)
    FarCall(cs5, 0x10C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs5, 0x10F);
    // ADD SP,0x4 (094C_010C / 0x95CC)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs5, 0x112);
    // MOV AX,0x13b6 (094C_010F / 0x95CF)
    AX = 0x13B6;
    CheckExternalEvents(cs5, 0x113);
    // PUSH DS (094C_0112 / 0x95D2)
    Stack.Push16(DS);
    CheckExternalEvents(cs5, 0x114);
    // PUSH AX (094C_0113 / 0x95D3)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x119);
    // CALLF 0x1000:7c1a (094C_0114 / 0x95D4)
    FarCall(cs5, 0x119, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs5, 0x11C);
    // ADD SP,0x4 (094C_0119 / 0x95D9)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs5, 0x121);
    // CALLF 0x1000:8d29 (094C_011C / 0x95DC)
    FarCall(cs5, 0x121, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs5, 0x124);
    // MOV AX,0x12 (094C_0121 / 0x95E1)
    AX = 0x12;
    CheckExternalEvents(cs5, 0x125);
    // PUSH AX (094C_0124 / 0x95E4)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x126);
    // PUSH CS (094C_0125 / 0x95E5)
    Stack.Push16(cs5);
    CheckExternalEvents(cs5, 0x129);
    // CALL 0x0000:94c8 (094C_0126 / 0x95E6)
    NearCall(cs5, 0x129, unknown_094C_0008_094C8);
    CheckExternalEvents(cs5, 0x12C);
    // ADD SP,0x2 (094C_0129 / 0x95E9)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x130);
    // MOV ES,word ptr [0x5466] (094C_012C / 0x95EC)
    ES = UInt16[DS, 0x5466];
    CheckExternalEvents(cs5, 0x136);
    // MOV byte ptr ES:[0x64],0xc (094C_0130 / 0x95F0)
    UInt8[ES, 0x64] = 0xC;
    label_094C_0136_095F6:
    CheckExternalEvents(cs5, 0x13A);
    // CMP word ptr [BP + 0x6],0x13 (094C_0136 / 0x95F6)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x13);
    CheckExternalEvents(cs5, 0x13C);
    // JNZ 0x0000:961d (094C_013A / 0x95FA)
    if(!ZeroFlag) {
      goto label_094C_015D_0961D;
    }
    CheckExternalEvents(cs5, 0x140);
    // MOV ES,word ptr [0x545c] (094C_013C / 0x95FC)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0x146);
    // CMP byte ptr ES:[0xd31a],0x0 (094C_0140 / 0x9600)
    Alu.Sub8(UInt8[ES, 0xD31A], 0x0);
    CheckExternalEvents(cs5, 0x148);
    // JZ 0x0000:961d (094C_0146 / 0x9606)
    if(ZeroFlag) {
      goto label_094C_015D_0961D;
    }
    CheckExternalEvents(cs5, 0x14B);
    // MOV AX,0x12 (094C_0148 / 0x9608)
    AX = 0x12;
    CheckExternalEvents(cs5, 0x14C);
    // PUSH AX (094C_014B / 0x960B)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x14D);
    // PUSH CS (094C_014C / 0x960C)
    Stack.Push16(cs5);
    CheckExternalEvents(cs5, 0x150);
    // CALL 0x0000:94c8 (094C_014D / 0x960D)
    NearCall(cs5, 0x150, unknown_094C_0008_094C8);
    CheckExternalEvents(cs5, 0x153);
    // ADD SP,0x2 (094C_0150 / 0x9610)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x157);
    // MOV ES,word ptr [0x5466] (094C_0153 / 0x9613)
    ES = UInt16[DS, 0x5466];
    CheckExternalEvents(cs5, 0x15D);
    // MOV byte ptr ES:[0x64],0xc (094C_0157 / 0x9617)
    UInt8[ES, 0x64] = 0xC;
    label_094C_015D_0961D:
    CheckExternalEvents(cs5, 0x160);
    // MOV AX,0x4 (094C_015D / 0x961D)
    AX = 0x4;
    CheckExternalEvents(cs5, 0x161);
    // PUSH AX (094C_0160 / 0x9620)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x166);
    // CALLF 0x1000:7ee1 (094C_0161 / 0x9621)
    FarCall(cs5, 0x166, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs5, 0x169);
    // ADD SP,0x2 (094C_0166 / 0x9626)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x16E);
    // CALLF 0x1000:7fe8 (094C_0169 / 0x9629)
    FarCall(cs5, 0x16E, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs5, 0x171);
    // MOV AX,0x3 (094C_016E / 0x962E)
    AX = 0x3;
    CheckExternalEvents(cs5, 0x172);
    // PUSH AX (094C_0171 / 0x9631)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x177);
    // CALLF 0x1000:7ee1 (094C_0172 / 0x9632)
    FarCall(cs5, 0x177, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs5, 0x17A);
    // ADD SP,0x2 (094C_0177 / 0x9637)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs5, 0x17D);
    // MOV AX,0x1 (094C_017A / 0x963A)
    AX = 0x1;
    CheckExternalEvents(cs5, 0x17E);
    // PUSH AX (094C_017D / 0x963D)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x183);
    // CALLF 0x0000:63ac (094C_017E / 0x963E)
    FarCall(cs5, 0x183, unknown_0170_4CAC_063AC);
    CheckExternalEvents(cs5, 0x186);
    // ADD SP,0x2 (094C_0183 / 0x9643)
    SP += 0x2;
    CheckExternalEvents(cs5, 0x18A);
    // CMP word ptr [BP + 0x6],0x14 (094C_0186 / 0x9646)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x14);
    CheckExternalEvents(cs5, 0x18C);
    // JNZ 0x0000:967c (094C_018A / 0x964A)
    if(!ZeroFlag) {
      goto label_094C_01BC_0967C;
    }
    CheckExternalEvents(cs5, 0x190);
    // MOV ES,word ptr [0x545c] (094C_018C / 0x964C)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0x196);
    // CMP byte ptr ES:[0xd342],0x0 (094C_0190 / 0x9650)
    Alu.Sub8(UInt8[ES, 0xD342], 0x0);
    CheckExternalEvents(cs5, 0x198);
    // JZ 0x0000:967c (094C_0196 / 0x9656)
    if(ZeroFlag) {
      goto label_094C_01BC_0967C;
    }
    CheckExternalEvents(cs5, 0x19D);
    // MOV word ptr [BP + -0x2],0x0 (094C_0198 / 0x9658)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_094C_019D_0965D:
    CheckExternalEvents(cs5, 0x1A0);
    // MOV BX,word ptr [BP + -0x2] (094C_019D / 0x965D)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs5, 0x1A2);
    // MOV CL,0x4 (094C_01A0 / 0x9660)
    CL = 0x4;
    CheckExternalEvents(cs5, 0x1A4);
    // SHL BX,CL (094C_01A2 / 0x9662)
    // BX <<= CL;
    BX = Alu.Shl16(BX, CL);
    CheckExternalEvents(cs5, 0x1A8);
    // MOV ES,word ptr [0x545c] (094C_01A4 / 0x9664)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0x1AE);
    // MOV byte ptr ES:[BX + 0xd118],0x0 (094C_01A8 / 0x9668)
    UInt8[ES, (ushort)(BX + 0xD118)] = 0x0;
    CheckExternalEvents(cs5, 0x1B1);
    // INC word ptr [BP + -0x2] (094C_01AE / 0x966E)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs5, 0x1B5);
    // CMP word ptr [BP + -0x2],0x8 (094C_01B1 / 0x9671)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x8);
    CheckExternalEvents(cs5, 0x1B7);
    // JL 0x0000:965d (094C_01B5 / 0x9675)
    if(SignFlag != OverflowFlag) {
      goto label_094C_019D_0965D;
    }
    CheckExternalEvents(cs5, 0x1BC);
    // CALLF 0x0000:ccd4 (094C_01B7 / 0x9677)
    FarCall(cs5, 0x1BC, ghidra_guess_0000_CCD4_0CCD4);
    label_094C_01BC_0967C:
    CheckExternalEvents(cs5, 0x1BE);
    // MOV SP,BP (094C_01BC / 0x967C)
    SP = BP;
    CheckExternalEvents(cs5, 0x1BF);
    // POP BP (094C_01BE / 0x967E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs5, 0x1C0);
    // RETF  (094C_01BF / 0x967F)
    return FarRet();
  }
  
  public virtual Action unknown_094C_01C0_09680(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9697: goto label_094C_01D7_09697;break; // Target of external jump from 0x9AAF
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_094C_01C0_09680:
    CheckExternalEvents(cs5, 0x1C1);
    // PUSH BP (094C_01C0 / 0x9680)
    Stack.Push16(BP);
    CheckExternalEvents(cs5, 0x1C3);
    // MOV BP,SP (094C_01C1 / 0x9681)
    BP = SP;
    CheckExternalEvents(cs5, 0x1C6);
    // MOV AX,0xc (094C_01C3 / 0x9683)
    AX = 0xC;
    CheckExternalEvents(cs5, 0x1CB);
    // CALLF 0x1000:cecc (094C_01C6 / 0x9686)
    FarCall(cs5, 0x1CB, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs5, 0x1CC);
    // PUSH SI (094C_01CB / 0x968B)
    Stack.Push16(SI);
    CheckExternalEvents(cs5, 0x1CE);
    // SUB AX,AX (094C_01CC / 0x968C)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs5, 0x1D1);
    // MOV word ptr [BP + -0x8],AX (094C_01CE / 0x968E)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    label_094C_01D1_09691:
    CheckExternalEvents(cs5, 0x1D4);
    // MOV word ptr [BP + -0xa],AX (094C_01D1 / 0x9691)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs5, 0x1D7);
    // JMP 0x0000:9aa9 (094C_01D4 / 0x9694)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_094C_01D7_09697:
    CheckExternalEvents(cs5, 0x1DA);
    // MOV BX,word ptr [BP + -0xa] (094C_01D7 / 0x9697)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs5, 0x1DD);
    // INC word ptr [BP + -0xa] (094C_01DA / 0x969A)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs5, 0x1E0);
    // LES SI,[BP + 0x6] (094C_01DD / 0x969D)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs5, 0x1E3);
    // MOV AL,byte ptr ES:[BX + SI] (094C_01E0 / 0x96A0)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs5, 0x1E4);
    // CBW  (094C_01E3 / 0x96A3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs5, 0x1E7);
    // SUB AX,0xffe4 (094C_01E4 / 0x96A4)
    AX -= 0xFFE4;
    CheckExternalEvents(cs5, 0x1EA);
    // CMP AX,0x1b (094C_01E7 / 0x96A7)
    Alu.Sub16(AX, 0x1B);
    CheckExternalEvents(cs5, 0x1EC);
    // JBE 0x0000:96af (094C_01EA / 0x96AA)
    if(CarryFlag || ZeroFlag) {
      goto label_094C_01EF_096AF;
    }
    CheckExternalEvents(cs5, 0x1EF);
    // JMP 0x0000:9aa9 (094C_01EC / 0x96AC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_094C_01EF_096AF:
    CheckExternalEvents(cs5, 0x1F1);
    // ADD AX,AX (094C_01EF / 0x96AF)
    // AX += AX;
    AX = Alu.Add16(AX, AX);
    CheckExternalEvents(cs5, 0x1F2);
    // XCHG AX,BX (094C_01F1 / 0x96B1)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs5, 0x1F7);
    // JMP word ptr CS:[BX + 0x5b1] (094C_01F2 / 0x96B2)
    // Indirect jump to word ptr CS:[BX + 0x5b1], generating possible targets from emulator records
    uint targetAddress_094C_01F2 = (uint)(cs5 * 0x10 + UInt16[cs5, (ushort)(BX + 0x5B1)] - cs1 * 0x10);
    switch(targetAddress_094C_01F2) {
      case 0x96BF : throw FailAsUntested("Would have been a goto but label label_094C_01FF_096BF does not exist because no instruction was found there that belongs to a function.");
      case 0x96D5 : throw FailAsUntested("Would have been a goto but label label_094C_0215_096D5 does not exist because no instruction was found there that belongs to a function.");
      case 0x9712 : throw FailAsUntested("Would have been a goto but label label_094C_0252_09712 does not exist because no instruction was found there that belongs to a function.");
      case 0x9758 : throw FailAsUntested("Would have been a goto but label label_094C_0298_09758 does not exist because no instruction was found there that belongs to a function.");
      case 0x96DD : throw FailAsUntested("Would have been a goto but label label_094C_021D_096DD does not exist because no instruction was found there that belongs to a function.");
      case 0x9728 : throw FailAsUntested("Would have been a goto but label label_094C_0268_09728 does not exist because no instruction was found there that belongs to a function.");
      case 0x99E9 : throw FailAsUntested("Would have been a goto but label label_094C_0529_099E9 does not exist because no instruction was found there that belongs to a function.");
      case 0x9827 : throw FailAsUntested("Would have been a goto but label label_094C_0367_09827 does not exist because no instruction was found there that belongs to a function.");
      case 0x9793 : throw FailAsUntested("Would have been a goto but label label_094C_02D3_09793 does not exist because no instruction was found there that belongs to a function.");
      case 0x96B7 : throw FailAsUntested("Would have been a goto but label label_094C_01F7_096B7 does not exist because no instruction was found there that belongs to a function.");
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_094C_01F2));
        break;
    }
    throw FailAsUntested("Function does not end with return and no instruction after the body ...");
  }
  
  public virtual Action split_0000_9AA9_09AA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_9AA9_09AA9:
    CheckExternalEvents(cs1, 0x9AAD);
    // CMP word ptr [BP + -0x8],0x0 (0000_9AA9 / 0x9AA9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs1, 0x9AAF);
    // JNZ 0x0000:9ab2 (0000_9AAD / 0x9AAD)
    if(!ZeroFlag) {
      goto label_0000_9AB2_09AB2;
    }
    CheckExternalEvents(cs1, 0x9AB2);
    // JMP 0x0000:9697 (0000_9AAF / 0x9AAF)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(unknown_094C_01C0_09680, 0x9697 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9AB2_09AB2:
    CheckExternalEvents(cs1, 0x9AB3);
    // POP SI (0000_9AB2 / 0x9AB2)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x9AB5);
    // MOV SP,BP (0000_9AB3 / 0x9AB3)
    SP = BP;
    CheckExternalEvents(cs1, 0x9AB6);
    // POP BP (0000_9AB5 / 0x9AB5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0x9AB7);
    // RETF  (0000_9AB6 / 0x9AB6)
    return FarRet();
  }
  
  public virtual Action unknown_094C_05F7_09AB7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_094C_05F7_09AB7:
    CheckExternalEvents(cs5, 0x5F8);
    // PUSH BP (094C_05F7 / 0x9AB7)
    Stack.Push16(BP);
    CheckExternalEvents(cs5, 0x5FA);
    // MOV BP,SP (094C_05F8 / 0x9AB8)
    BP = SP;
    CheckExternalEvents(cs5, 0x5FD);
    // MOV AX,0x6 (094C_05FA / 0x9ABA)
    AX = 0x6;
    CheckExternalEvents(cs5, 0x602);
    // CALLF 0x1000:cecc (094C_05FD / 0x9ABD)
    FarCall(cs5, 0x602, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs5, 0x605);
    // LES BX,[BP + 0x6] (094C_0602 / 0x9AC2)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs5, 0x608);
    // MOV AL,byte ptr ES:[BX] (094C_0605 / 0x9AC5)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs5, 0x60A);
    // SUB AH,AH (094C_0608 / 0x9AC8)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs5, 0x60D);
    // MOV word ptr [BP + -0x4],AX (094C_060A / 0x9ACA)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs5, 0x611);
    // MOV AL,byte ptr ES:[BX + 0x1] (094C_060D / 0x9ACD)
    AL = UInt8[ES, (ushort)(BX + 0x1)];
    CheckExternalEvents(cs5, 0x614);
    // MOV word ptr [BP + -0x2],AX (094C_0611 / 0x9AD1)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs5, 0x617);
    // AND byte ptr [BP + -0x3],AH (094C_0614 / 0x9AD4)
    UInt8[SS, (ushort)(BP - 0x3)] &= AH;
    CheckExternalEvents(cs5, 0x61A);
    // AND byte ptr [BP + -0x1],AH (094C_0617 / 0x9AD7)
    // UInt8[SS, (ushort)(BP - 0x1)] &= AH;
    UInt8[SS, (ushort)(BP - 0x1)] = Alu.And8(UInt8[SS, (ushort)(BP - 0x1)], AH);
    CheckExternalEvents(cs5, 0x61D);
    // MOV AH,byte ptr [BP + -0x2] (094C_061A / 0x9ADA)
    AH = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs5, 0x61F);
    // SUB AL,AL (094C_061D / 0x9ADD)
    AL -= AL;
    CheckExternalEvents(cs5, 0x622);
    // ADD AX,word ptr [BP + -0x4] (094C_061F / 0x9ADF)
    // AX += UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu.Add16(AX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs5, 0x625);
    // MOV word ptr [BP + -0x6],AX (094C_0622 / 0x9AE2)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs5, 0x627);
    // MOV SP,BP (094C_0625 / 0x9AE5)
    SP = BP;
    CheckExternalEvents(cs5, 0x628);
    // POP BP (094C_0627 / 0x9AE7)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs5, 0x629);
    // RETF  (094C_0628 / 0x9AE8)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_AAA6_0AAA6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_AAA6_0AAA6:
    CheckExternalEvents(cs1, 0xAAA7);
    // PUSH BP (0000_AAA6 / 0xAAA6)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xAAA9);
    // MOV BP,SP (0000_AAA7 / 0xAAA7)
    BP = SP;
    CheckExternalEvents(cs1, 0xAAAC);
    // MOV AX,0x1e (0000_AAA9 / 0xAAA9)
    AX = 0x1E;
    CheckExternalEvents(cs1, 0xAAB1);
    // CALLF 0x1000:cecc (0000_AAAC / 0xAAAC)
    FarCall(cs1, 0xAAB1, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xAAB2);
    // PUSH SI (0000_AAB1 / 0xAAB1)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xAAB7);
    // MOV word ptr [BP + -0x16],0x0 (0000_AAB2 / 0xAAB2)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    label_0000_AAB7_0AAB7:
    CheckExternalEvents(cs1, 0xAABA);
    // MOV SI,word ptr [BP + -0x16] (0000_AAB7 / 0xAAB7)
    SI = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0xAABC);
    // SHL SI,0x1 (0000_AABA / 0xAABA)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xAAC1);
    // MOV word ptr [BP + SI + -0x10],0xffff (0000_AABC / 0xAABC)
    UInt16[SS, (ushort)(BP + SI - 0x10)] = 0xFFFF;
    CheckExternalEvents(cs1, 0xAAC4);
    // INC word ptr [BP + -0x16] (0000_AAC1 / 0xAAC1)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    CheckExternalEvents(cs1, 0xAAC8);
    // CMP word ptr [BP + -0x16],0x8 (0000_AAC4 / 0xAAC4)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x8);
    CheckExternalEvents(cs1, 0xAACA);
    // JL 0x0000:aab7 (0000_AAC8 / 0xAAC8)
    if(SignFlag != OverflowFlag) {
      goto label_0000_AAB7_0AAB7;
    }
    CheckExternalEvents(cs1, 0xAACC);
    // SUB AX,AX (0000_AACA / 0xAACA)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xAACF);
    // MOV word ptr [BP + -0x14],AX (0000_AACC / 0xAACC)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xAAD2);
    // MOV word ptr [BP + -0x16],AX (0000_AACF / 0xAACF)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0xAAD4);
    // JMP 0x0000:aaf9 (0000_AAD2 / 0xAAD2)
    goto label_0000_AAF9_0AAF9;
    label_0000_AAD4_0AAD4:
    CheckExternalEvents(cs1, 0xAAD7);
    // MOV AX,0x11 (0000_AAD4 / 0xAAD4)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xAADA);
    // IMUL word ptr [BP + -0x16] (0000_AAD7 / 0xAAD7)
    int resImul0000_AAD7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x16)]);
    AX = (ushort)(resImul0000_AAD7);
    DX = (ushort)(resImul0000_AAD7 >> 16);
    CheckExternalEvents(cs1, 0xAADC);
    // MOV BX,AX (0000_AADA / 0xAADA)
    BX = AX;
    CheckExternalEvents(cs1, 0xAAE0);
    // MOV ES,word ptr [0x545c] (0000_AADC / 0xAADC)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xAAE6);
    // CMP byte ptr ES:[BX + 0xc614],0xff (0000_AAE0 / 0xAAE0)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xC614)], 0xFF);
    CheckExternalEvents(cs1, 0xAAE8);
    // JZ 0x0000:aaf6 (0000_AAE6 / 0xAAE6)
    if(ZeroFlag) {
      goto label_0000_AAF6_0AAF6;
    }
    CheckExternalEvents(cs1, 0xAAEB);
    // MOV SI,word ptr [BP + -0x14] (0000_AAE8 / 0xAAE8)
    SI = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xAAEE);
    // INC word ptr [BP + -0x14] (0000_AAEB / 0xAAEB)
    UInt16[SS, (ushort)(BP - 0x14)]++;
    CheckExternalEvents(cs1, 0xAAF0);
    // SHL SI,0x1 (0000_AAEE / 0xAAEE)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xAAF3);
    // MOV AX,word ptr [BP + -0x16] (0000_AAF0 / 0xAAF0)
    AX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0xAAF6);
    // MOV word ptr [BP + SI + -0x10],AX (0000_AAF3 / 0xAAF3)
    UInt16[SS, (ushort)(BP + SI - 0x10)] = AX;
    label_0000_AAF6_0AAF6:
    CheckExternalEvents(cs1, 0xAAF9);
    // INC word ptr [BP + -0x16] (0000_AAF6 / 0xAAF6)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    label_0000_AAF9_0AAF9:
    CheckExternalEvents(cs1, 0xAAFD);
    // CMP word ptr [BP + -0x16],0x8 (0000_AAF9 / 0xAAF9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], 0x8);
    CheckExternalEvents(cs1, 0xAAFF);
    // JL 0x0000:aad4 (0000_AAFD / 0xAAFD)
    if(SignFlag != OverflowFlag) {
      goto label_0000_AAD4_0AAD4;
    }
    CheckExternalEvents(cs1, 0xAB02);
    // JMP 0x0000:ac6b (0000_AAFF / 0xAAFF)
    goto label_0000_AC6B_0AC6B;
    label_0000_AB02_0AB02:
    CheckExternalEvents(cs1, 0xAB06);
    // CMP word ptr [BP + -0x14],0x1 (0000_AB02 / 0xAB02)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x14)], 0x1);
    CheckExternalEvents(cs1, 0xAB08);
    // JG 0x0000:ab0b (0000_AB06 / 0xAB06)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_AB0B_0AB0B;
    }
    CheckExternalEvents(cs1, 0xAB0B);
    // JMP 0x0000:abf4 (0000_AB08 / 0xAB08)
    goto label_0000_ABF4_0ABF4;
    label_0000_AB0B_0AB0B:
    CheckExternalEvents(cs1, 0xAB10);
    // CALLF 0x1000:7fe8 (0000_AB0B / 0xAB0B)
    FarCall(cs1, 0xAB10, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xAB13);
    // MOV AX,0x16ae (0000_AB10 / 0xAB10)
    AX = 0x16AE;
    CheckExternalEvents(cs1, 0xAB14);
    // PUSH DS (0000_AB13 / 0xAB13)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xAB15);
    // PUSH AX (0000_AB14 / 0xAB14)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xAB1A);
    // CALLF 0x1000:8055 (0000_AB15 / 0xAB15)
    FarCall(cs1, 0xAB1A, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xAB1D);
    // ADD SP,0x4 (0000_AB1A / 0xAB1A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xAB20);
    // MOV AX,0x11 (0000_AB1D / 0xAB1D)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xAB23);
    // IMUL word ptr [BP + 0x6] (0000_AB20 / 0xAB20)
    int resImul0000_AB20 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul0000_AB20);
    DX = (ushort)(resImul0000_AB20 >> 16);
    CheckExternalEvents(cs1, 0xAB25);
    // MOV BX,AX (0000_AB23 / 0xAB23)
    BX = AX;
    CheckExternalEvents(cs1, 0xAB29);
    // LEA AX,[BX + 0x2ed8] (0000_AB25 / 0xAB25)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0xAB2C);
    // MOV DX,0x384b (0000_AB29 / 0xAB29)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0xAB2D);
    // PUSH DX (0000_AB2C / 0xAB2C)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xAB2E);
    // PUSH AX (0000_AB2D / 0xAB2D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xAB33);
    // CALLF 0x1000:8055 (0000_AB2E / 0xAB2E)
    FarCall(cs1, 0xAB33, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xAB36);
    // ADD SP,0x4 (0000_AB33 / 0xAB33)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xAB39);
    // MOV AX,0x16b4 (0000_AB36 / 0xAB36)
    AX = 0x16B4;
    CheckExternalEvents(cs1, 0xAB3A);
    // PUSH DS (0000_AB39 / 0xAB39)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xAB3B);
    // PUSH AX (0000_AB3A / 0xAB3A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xAB40);
    // CALLF 0x1000:8055 (0000_AB3B / 0xAB3B)
    FarCall(cs1, 0xAB40, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xAB43);
    // ADD SP,0x4 (0000_AB40 / 0xAB40)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xAB48);
    // MOV word ptr [BP + -0x16],0x0 (0000_AB43 / 0xAB43)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    CheckExternalEvents(cs1, 0xAB4A);
    // JMP 0x0000:abc2 (0000_AB48 / 0xAB48)
    goto label_0000_ABC2_0ABC2;
    label_0000_AB4A_0AB4A:
    CheckExternalEvents(cs1, 0xAB4D);
    // MOV SI,word ptr [BP + -0x16] (0000_AB4A / 0xAB4A)
    SI = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0xAB4F);
    // SHL SI,0x1 (0000_AB4D / 0xAB4D)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xAB52);
    // MOV AX,0x11 (0000_AB4F / 0xAB4F)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xAB55);
    // IMUL word ptr [BP + SI + -0x10] (0000_AB52 / 0xAB52)
    int resImul0000_AB52 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + SI - 0x10)]);
    AX = (ushort)(resImul0000_AB52);
    DX = (ushort)(resImul0000_AB52 >> 16);
    CheckExternalEvents(cs1, 0xAB57);
    // MOV BX,AX (0000_AB55 / 0xAB55)
    BX = AX;
    CheckExternalEvents(cs1, 0xAB5B);
    // MOV ES,word ptr [0x545c] (0000_AB57 / 0xAB57)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xAB60);
    // MOV AL,byte ptr ES:[BX + 0xc614] (0000_AB5B / 0xAB5B)
    AL = UInt8[ES, (ushort)(BX + 0xC614)];
    CheckExternalEvents(cs1, 0xAB63);
    // MOV byte ptr [BP + -0x1a],AL (0000_AB60 / 0xAB60)
    UInt8[SS, (ushort)(BP - 0x1A)] = AL;
    CheckExternalEvents(cs1, 0xAB65);
    // CMP AL,0xff (0000_AB63 / 0xAB63)
    Alu.Sub8(AL, 0xFF);
    CheckExternalEvents(cs1, 0xAB67);
    // JZ 0x0000:abbf (0000_AB65 / 0xAB65)
    if(ZeroFlag) {
      goto label_0000_ABBF_0ABBF;
    }
    CheckExternalEvents(cs1, 0xAB68);
    // CBW  (0000_AB67 / 0xAB67)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xAB6A);
    // MOV BX,AX (0000_AB68 / 0xAB68)
    BX = AX;
    CheckExternalEvents(cs1, 0xAB6C);
    // SHL BX,0x1 (0000_AB6A / 0xAB6A)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xAB6E);
    // SHL BX,0x1 (0000_AB6C / 0xAB6C)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xAB72);
    // MOV ES,word ptr [0x549e] (0000_AB6E / 0xAB6E)
    ES = UInt16[DS, 0x549E];
    CheckExternalEvents(cs1, 0xAB77);
    // PUSH word ptr ES:[BX + 0x1cc] (0000_AB72 / 0xAB72)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CC)]);
    CheckExternalEvents(cs1, 0xAB7C);
    // PUSH word ptr ES:[BX + 0x1ca] (0000_AB77 / 0xAB77)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x1CA)]);
    CheckExternalEvents(cs1, 0xAB81);
    // CALLF 0x1000:8055 (0000_AB7C / 0xAB7C)
    FarCall(cs1, 0xAB81, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xAB84);
    // ADD SP,0x4 (0000_AB81 / 0xAB81)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xAB88);
    // MOV ES,word ptr [0x5468] (0000_AB84 / 0xAB84)
    ES = UInt16[DS, 0x5468];
    CheckExternalEvents(cs1, 0xAB8F);
    // MOV word ptr ES:[0x3748],0xa (0000_AB88 / 0xAB88)
    UInt16[ES, 0x3748] = 0xA;
    CheckExternalEvents(cs1, 0xAB92);
    // MOV SI,word ptr [BP + -0x16] (0000_AB8F / 0xAB8F)
    SI = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0xAB94);
    // SHL SI,0x1 (0000_AB92 / 0xAB92)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xAB97);
    // MOV AX,0x11 (0000_AB94 / 0xAB94)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xAB9A);
    // IMUL word ptr [BP + SI + -0x10] (0000_AB97 / 0xAB97)
    int resImul0000_AB97 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + SI - 0x10)]);
    AX = (ushort)(resImul0000_AB97);
    DX = (ushort)(resImul0000_AB97 >> 16);
    CheckExternalEvents(cs1, 0xAB9C);
    // MOV BX,AX (0000_AB9A / 0xAB9A)
    BX = AX;
    CheckExternalEvents(cs1, 0xABA0);
    // MOV ES,word ptr [0x545c] (0000_AB9C / 0xAB9C)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xABA2);
    // MOV AL,0x11 (0000_ABA0 / 0xABA0)
    AL = 0x11;
    CheckExternalEvents(cs1, 0xABA7);
    // IMUL byte ptr ES:[BX + 0xc61f] (0000_ABA2 / 0xABA2)
    short resImul0000_ABA2 = Alu.Imul8((sbyte)AL, (sbyte)UInt8[ES, (ushort)(BX + 0xC61F)]);
    AL = (byte)(resImul0000_ABA2);
    AH = (byte)(resImul0000_ABA2 >> 8);
    CheckExternalEvents(cs1, 0xABA9);
    // MOV BX,AX (0000_ABA7 / 0xABA7)
    BX = AX;
    CheckExternalEvents(cs1, 0xABAD);
    // LEA AX,[BX + 0x2ed8] (0000_ABA9 / 0xABA9)
    AX = (ushort)(BX + 0x2ED8);
    CheckExternalEvents(cs1, 0xABB0);
    // MOV DX,0x384b (0000_ABAD / 0xABAD)
    DX = 0x384B;
    CheckExternalEvents(cs1, 0xABB1);
    // PUSH DX (0000_ABB0 / 0xABB0)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xABB2);
    // PUSH AX (0000_ABB1 / 0xABB1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xABB7);
    // CALLF 0x1000:8055 (0000_ABB2 / 0xABB2)
    FarCall(cs1, 0xABB7, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xABBA);
    // ADD SP,0x4 (0000_ABB7 / 0xABB7)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xABBF);
    // CALLF 0x1000:7c4e (0000_ABBA / 0xABBA)
    FarCall(cs1, 0xABBF, ghidra_guess_1000_7C4E_17C4E);
    label_0000_ABBF_0ABBF:
    CheckExternalEvents(cs1, 0xABC2);
    // INC word ptr [BP + -0x16] (0000_ABBF / 0xABBF)
    UInt16[SS, (ushort)(BP - 0x16)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x16)]);
    label_0000_ABC2_0ABC2:
    CheckExternalEvents(cs1, 0xABC5);
    // MOV AX,word ptr [BP + -0x14] (0000_ABC2 / 0xABC2)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xABC8);
    // CMP word ptr [BP + -0x16],AX (0000_ABC5 / 0xABC5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x16)], AX);
    CheckExternalEvents(cs1, 0xABCA);
    // JGE 0x0000:abcd (0000_ABC8 / 0xABC8)
    if(SignFlag == OverflowFlag) {
      goto label_0000_ABCD_0ABCD;
    }
    CheckExternalEvents(cs1, 0xABCD);
    // JMP 0x0000:ab4a (0000_ABCA / 0xABCA)
    goto label_0000_AB4A_0AB4A;
    label_0000_ABCD_0ABCD:
    CheckExternalEvents(cs1, 0xABD0);
    // MOV AX,0x16ba (0000_ABCD / 0xABCD)
    AX = 0x16BA;
    CheckExternalEvents(cs1, 0xABD1);
    // PUSH DS (0000_ABD0 / 0xABD0)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xABD2);
    // PUSH AX (0000_ABD1 / 0xABD1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xABD7);
    // CALLF 0x1000:8055 (0000_ABD2 / 0xABD2)
    FarCall(cs1, 0xABD7, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xABDA);
    // ADD SP,0x4 (0000_ABD7 / 0xABD7)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xABDE);
    // MOV ES,word ptr [0x54a0] (0000_ABDA / 0xABDA)
    ES = UInt16[DS, 0x54A0];
    CheckExternalEvents(cs1, 0xABE1);
    // MOV AX,word ptr [BP + -0x14] (0000_ABDE / 0xABDE)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xABE2);
    // INC AX (0000_ABE1 / 0xABE1)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0xABE6);
    // MOV ES:[0xd6],AX (0000_ABE2 / 0xABE2)
    UInt16[ES, 0xD6] = AX;
    CheckExternalEvents(cs1, 0xABE9);
    // MOV AX,0x4 (0000_ABE6 / 0xABE6)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xABEA);
    // PUSH AX (0000_ABE9 / 0xABE9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xABEF);
    // CALLF 0x1000:87be (0000_ABEA / 0xABEA)
    FarCall(cs1, 0xABEF, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0xABF2);
    // ADD SP,0x2 (0000_ABEF / 0xABEF)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xABF4);
    // JMP 0x0000:ac07 (0000_ABF2 / 0xABF2)
    goto label_0000_AC07_0AC07;
    label_0000_ABF4_0ABF4:
    CheckExternalEvents(cs1, 0xABF8);
    // MOV ES,word ptr [0x545c] (0000_ABF4 / 0xABF4)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xABFB);
    // MOV AL,byte ptr [BP + 0x6] (0000_ABF8 / 0xABF8)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xABFF);
    // MOV ES:[0xc61f],AL (0000_ABFB / 0xABFB)
    UInt8[ES, 0xC61F] = AL;
    CheckExternalEvents(cs1, 0xAC04);
    // MOV word ptr [BP + 0x6],0x0 (0000_ABFF / 0xABFF)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0xAC07);
    // MOV AX,word ptr [BP + -0x14] (0000_AC04 / 0xAC04)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    label_0000_AC07_0AC07:
    CheckExternalEvents(cs1, 0xAC0A);
    // MOV word ptr [BP + -0x12],AX (0000_AC07 / 0xAC07)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs1, 0xAC0D);
    // MOV AX,word ptr [BP + -0x14] (0000_AC0A / 0xAC0A)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xAC10);
    // CMP word ptr [BP + -0x12],AX (0000_AC0D / 0xAC0D)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x12)], AX);
    CheckExternalEvents(cs1, 0xAC12);
    // JNZ 0x0000:ac19 (0000_AC10 / 0xAC10)
    if(!ZeroFlag) {
      goto label_0000_AC19_0AC19;
    }
    CheckExternalEvents(cs1, 0xAC17);
    // MOV word ptr [BP + 0x6],0x0 (0000_AC12 / 0xAC12)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0xAC19);
    // JMP 0x0000:ac6b (0000_AC17 / 0xAC17)
    goto label_0000_AC6B_0AC6B;
    label_0000_AC19_0AC19:
    CheckExternalEvents(cs1, 0xAC1C);
    // MOV SI,word ptr [BP + -0x12] (0000_AC19 / 0xAC19)
    SI = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xAC1E);
    // SHL SI,0x1 (0000_AC1C / 0xAC1C)
    // SI <<= 0x1;
    SI = Alu.Shl16(SI, 0x1);
    CheckExternalEvents(cs1, 0xAC21);
    // MOV AX,0x11 (0000_AC1E / 0xAC1E)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xAC24);
    // IMUL word ptr [BP + SI + -0x10] (0000_AC21 / 0xAC21)
    int resImul0000_AC21 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP + SI - 0x10)]);
    AX = (ushort)(resImul0000_AC21);
    DX = (ushort)(resImul0000_AC21 >> 16);
    CheckExternalEvents(cs1, 0xAC27);
    // ADD AX,0xc61f (0000_AC24 / 0xAC24)
    // AX += 0xC61F;
    AX = Alu.Add16(AX, 0xC61F);
    CheckExternalEvents(cs1, 0xAC2A);
    // MOV word ptr [BP + -0x1e],AX (0000_AC27 / 0xAC27)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs1, 0xAC2F);
    // MOV word ptr [BP + -0x1c],0x2a02 (0000_AC2A / 0xAC2A)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x2A02;
    CheckExternalEvents(cs1, 0xAC32);
    // LES BX,[BP + -0x1e] (0000_AC2F / 0xAC2F)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    ES = UInt16[SS, (ushort)(BP - 0x1E + 2)];
    CheckExternalEvents(cs1, 0xAC35);
    // MOV AL,byte ptr ES:[BX] (0000_AC32 / 0xAC32)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs1, 0xAC36);
    // CBW  (0000_AC35 / 0xAC35)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xAC39);
    // MOV word ptr [BP + -0x18],AX (0000_AC36 / 0xAC36)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs1, 0xAC3C);
    // MOV AL,byte ptr [BP + 0x6] (0000_AC39 / 0xAC39)
    AL = UInt8[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xAC3F);
    // MOV byte ptr ES:[BX],AL (0000_AC3C / 0xAC3C)
    UInt8[ES, (ushort)(BX)] = AL;
    CheckExternalEvents(cs1, 0xAC42);
    // MOV AX,word ptr [BP + -0x18] (0000_AC3F / 0xAC3F)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xAC45);
    // CMP word ptr [BP + 0x6],AX (0000_AC42 / 0xAC42)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs1, 0xAC47);
    // JNZ 0x0000:ac65 (0000_AC45 / 0xAC45)
    if(!ZeroFlag) {
      goto label_0000_AC65_0AC65;
    }
    CheckExternalEvents(cs1, 0xAC4A);
    // MOV AX,0x14 (0000_AC47 / 0xAC47)
    AX = 0x14;
    CheckExternalEvents(cs1, 0xAC4B);
    // PUSH AX (0000_AC4A / 0xAC4A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xAC4D);
    // SUB AX,AX (0000_AC4B / 0xAC4B)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xAC4E);
    // PUSH AX (0000_AC4D / 0xAC4D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xAC51);
    // MOV AX,0x16c2 (0000_AC4E / 0xAC4E)
    AX = 0x16C2;
    CheckExternalEvents(cs1, 0xAC52);
    // PUSH DS (0000_AC51 / 0xAC51)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xAC53);
    // PUSH AX (0000_AC52 / 0xAC52)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xAC58);
    // CALLF 0x0000:3f67 (0000_AC53 / 0xAC53)
    FarCall(cs1, 0xAC58, ghidra_guess_0000_3F67_03F67);
    CheckExternalEvents(cs1, 0xAC5B);
    // ADD SP,0x8 (0000_AC58 / 0xAC58)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xAC60);
    // CALLF 0x1000:933a (0000_AC5B / 0xAC5B)
    FarCall(cs1, 0xAC60, ghidra_guess_1000_933A_1933A);
    CheckExternalEvents(cs1, 0xAC65);
    // CALLF 0x1000:8d29 (0000_AC60 / 0xAC60)
    FarCall(cs1, 0xAC65, unknown_18AD_0259_18D29);
    label_0000_AC65_0AC65:
    CheckExternalEvents(cs1, 0xAC68);
    // MOV AX,word ptr [BP + -0x18] (0000_AC65 / 0xAC65)
    AX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xAC6B);
    // MOV word ptr [BP + 0x6],AX (0000_AC68 / 0xAC68)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    label_0000_AC6B_0AC6B:
    CheckExternalEvents(cs1, 0xAC6F);
    // CMP word ptr [BP + 0x6],0x0 (0000_AC6B / 0xAC6B)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xAC71);
    // JZ 0x0000:ac74 (0000_AC6F / 0xAC6F)
    if(ZeroFlag) {
      goto label_0000_AC74_0AC74;
    }
    CheckExternalEvents(cs1, 0xAC74);
    // JMP 0x0000:ab02 (0000_AC71 / 0xAC71)
    goto label_0000_AB02_0AB02;
    label_0000_AC74_0AC74:
    CheckExternalEvents(cs1, 0xAC75);
    // POP SI (0000_AC74 / 0xAC74)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xAC77);
    // MOV SP,BP (0000_AC75 / 0xAC75)
    SP = BP;
    CheckExternalEvents(cs1, 0xAC78);
    // POP BP (0000_AC77 / 0xAC77)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xAC79);
    // RETF  (0000_AC78 / 0xAC78)
    return FarRet();
  }
  
  public virtual Action split_0000_B046_0B046(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_B046_0B046:
    CheckExternalEvents(cs1, 0xB048);
    // ADD byte ptr [BX + SI],AL (0000_B046 / 0xB046)
    // UInt8[DS, (ushort)(BX + SI)] += AL;
    UInt8[DS, (ushort)(BX + SI)] = Alu.Add8(UInt8[DS, (ushort)(BX + SI)], AL);
    label_0000_B048_0B048:
    CheckExternalEvents(cs1, 0xB04B);
    // MOV BX,word ptr [BP + -0x2] (0000_B048 / 0xB048)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xB04F);
    // MOV ES,word ptr [0x545c] (0000_B04B / 0xB04B)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB054);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_B04F / 0xB04F)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0xB058);
    // MOV ES,word ptr [0x54ac] (0000_B054 / 0xB054)
    ES = UInt16[DS, 0x54AC];
    CheckExternalEvents(cs1, 0xB05A);
    // MOV CX,AX (0000_B058 / 0xB058)
    CX = AX;
    CheckExternalEvents(cs1, 0xB05D);
    // MOV AX,0x7d (0000_B05A / 0xB05A)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xB062);
    // IMUL word ptr ES:[0x68] (0000_B05D / 0xB05D)
    int resImul0000_B05D = Alu.Imul16((short)AX, (short)UInt16[ES, 0x68]);
    AX = (ushort)(resImul0000_B05D);
    DX = (ushort)(resImul0000_B05D >> 16);
    CheckExternalEvents(cs1, 0xB064);
    // MOV BX,AX (0000_B062 / 0xB062)
    BX = AX;
    CheckExternalEvents(cs1, 0xB067);
    // ADD BX,word ptr [BP + -0x2] (0000_B064 / 0xB064)
    // BX += UInt16[SS, (ushort)(BP - 0x2)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0xB06B);
    // MOV ES,word ptr [0x545c] (0000_B067 / 0xB067)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB070);
    // MOV byte ptr ES:[BX + 0xc724],CL (0000_B06B / 0xB06B)
    UInt8[ES, (ushort)(BX + 0xC724)] = CL;
    CheckExternalEvents(cs1, 0xB073);
    // INC word ptr [BP + -0x2] (0000_B070 / 0xB070)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xB077);
    // CMP word ptr [BP + -0x2],0x7d (0000_B073 / 0xB073)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x7D);
    CheckExternalEvents(cs1, 0xB079);
    // JL 0x0000:b048 (0000_B077 / 0xB077)
    if(SignFlag != OverflowFlag) {
      goto label_0000_B048_0B048;
    }
    CheckExternalEvents(cs1, 0xB07F);
    // CMP byte ptr ES:[0xc724],0xff (0000_B079 / 0xB079)
    Alu.Sub8(UInt8[ES, 0xC724], 0xFF);
    CheckExternalEvents(cs1, 0xB081);
    // JNZ 0x0000:b094 (0000_B07F / 0xB07F)
    if(!ZeroFlag) {
      goto label_0000_B094_0B094;
    }
    CheckExternalEvents(cs1, 0xB085);
    // MOV ES,word ptr [0x54ac] (0000_B081 / 0xB081)
    ES = UInt16[DS, 0x54AC];
    CheckExternalEvents(cs1, 0xB08A);
    // MOV BX,word ptr ES:[0x68] (0000_B085 / 0xB085)
    BX = UInt16[ES, 0x68];
    CheckExternalEvents(cs1, 0xB08E);
    // MOV ES,word ptr [0x545c] (0000_B08A / 0xB08A)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB094);
    // MOV byte ptr ES:[BX + 0xd452],0xff (0000_B08E / 0xB08E)
    UInt8[ES, (ushort)(BX + 0xD452)] = 0xFF;
    label_0000_B094_0B094:
    CheckExternalEvents(cs1, 0xB098);
    // MOV ES,word ptr [0x54ac] (0000_B094 / 0xB094)
    ES = UInt16[DS, 0x54AC];
    CheckExternalEvents(cs1, 0xB09B);
    // MOV AX,0x7d (0000_B098 / 0xB098)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xB0A0);
    // IMUL word ptr ES:[0x68] (0000_B09B / 0xB09B)
    int resImul0000_B09B = Alu.Imul16((short)AX, (short)UInt16[ES, 0x68]);
    AX = (ushort)(resImul0000_B09B);
    DX = (ushort)(resImul0000_B09B >> 16);
    CheckExternalEvents(cs1, 0xB0A2);
    // MOV BX,AX (0000_B0A0 / 0xB0A0)
    BX = AX;
    CheckExternalEvents(cs1, 0xB0A6);
    // MOV ES,word ptr [0x545c] (0000_B0A2 / 0xB0A2)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB0AC);
    // MOV byte ptr ES:[BX + 0xc724],0xff (0000_B0A6 / 0xB0A6)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0xFF;
    CheckExternalEvents(cs1, 0xB0B0);
    // MOV ES,word ptr [0x54ac] (0000_B0AC / 0xB0AC)
    ES = UInt16[DS, 0x54AC];
    CheckExternalEvents(cs1, 0xB0B6);
    // CMP word ptr ES:[0x68],0x0 (0000_B0B0 / 0xB0B0)
    Alu.Sub16(UInt16[ES, 0x68], 0x0);
    CheckExternalEvents(cs1, 0xB0B8);
    // JZ 0x0000:b0db (0000_B0B6 / 0xB0B6)
    if(ZeroFlag) {
      goto label_0000_B0DB_0B0DB;
    }
    CheckExternalEvents(cs1, 0xB0BD);
    // MOV word ptr [BP + -0x2],0x0 (0000_B0B8 / 0xB0B8)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_B0BD_0B0BD:
    CheckExternalEvents(cs1, 0xB0C0);
    // MOV BX,word ptr [BP + -0x2] (0000_B0BD / 0xB0BD)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xB0C4);
    // MOV ES,word ptr [0x54aa] (0000_B0C0 / 0xB0C0)
    ES = UInt16[DS, 0x54AA];
    CheckExternalEvents(cs1, 0xB0C9);
    // MOV AL,byte ptr ES:[BX + 0x3780] (0000_B0C4 / 0xB0C4)
    AL = UInt8[ES, (ushort)(BX + 0x3780)];
    CheckExternalEvents(cs1, 0xB0CD);
    // MOV ES,word ptr [0x545c] (0000_B0C9 / 0xB0C9)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB0D2);
    // MOV byte ptr ES:[BX + 0xc724],AL (0000_B0CD / 0xB0CD)
    UInt8[ES, (ushort)(BX + 0xC724)] = AL;
    CheckExternalEvents(cs1, 0xB0D5);
    // INC word ptr [BP + -0x2] (0000_B0D2 / 0xB0D2)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xB0D9);
    // CMP word ptr [BP + -0x2],0x7d (0000_B0D5 / 0xB0D5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x7D);
    CheckExternalEvents(cs1, 0xB0DB);
    // JL 0x0000:b0bd (0000_B0D9 / 0xB0D9)
    if(SignFlag != OverflowFlag) {
      goto label_0000_B0BD_0B0BD;
    }
    label_0000_B0DB_0B0DB:
    CheckExternalEvents(cs1, 0xB0E0);
    // MOV word ptr [BP + -0x2],0x0 (0000_B0DB / 0xB0DB)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_B0E0_0B0E0:
    CheckExternalEvents(cs1, 0xB0E3);
    // MOV AX,0x7d (0000_B0E0 / 0xB0E0)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xB0E6);
    // IMUL word ptr [BP + -0x2] (0000_B0E3 / 0xB0E3)
    int resImul0000_B0E3 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_B0E3);
    DX = (ushort)(resImul0000_B0E3 >> 16);
    CheckExternalEvents(cs1, 0xB0E8);
    // MOV SI,AX (0000_B0E6 / 0xB0E6)
    SI = AX;
    CheckExternalEvents(cs1, 0xB0EB);
    // MOV BX,word ptr [BP + -0x2] (0000_B0E8 / 0xB0E8)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xB0EF);
    // MOV ES,word ptr [0x54a6] (0000_B0EB / 0xB0EB)
    ES = UInt16[DS, 0x54A6];
    CheckExternalEvents(cs1, 0xB0F4);
    // MOV AL,byte ptr ES:[BX + 0x430e] (0000_B0EF / 0xB0EF)
    AL = UInt8[ES, (ushort)(BX + 0x430E)];
    CheckExternalEvents(cs1, 0xB0F8);
    // MOV ES,word ptr [0x545c] (0000_B0F4 / 0xB0F4)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB0FD);
    // MOV byte ptr ES:[SI + 0xc79d],AL (0000_B0F8 / 0xB0F8)
    UInt8[ES, (ushort)(SI + 0xC79D)] = AL;
    CheckExternalEvents(cs1, 0xB100);
    // MOV BX,word ptr [BP + -0x2] (0000_B0FD / 0xB0FD)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xB104);
    // MOV ES,word ptr [0x54a8] (0000_B100 / 0xB100)
    ES = UInt16[DS, 0x54A8];
    CheckExternalEvents(cs1, 0xB109);
    // MOV AL,byte ptr ES:[BX + 0x3ffa] (0000_B104 / 0xB104)
    AL = UInt8[ES, (ushort)(BX + 0x3FFA)];
    CheckExternalEvents(cs1, 0xB10D);
    // MOV ES,word ptr [0x545c] (0000_B109 / 0xB109)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB112);
    // MOV byte ptr ES:[SI + 0xc79e],AL (0000_B10D / 0xB10D)
    UInt8[ES, (ushort)(SI + 0xC79E)] = AL;
    CheckExternalEvents(cs1, 0xB115);
    // INC word ptr [BP + -0x2] (0000_B112 / 0xB112)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xB119);
    // CMP word ptr [BP + -0x2],0x4 (0000_B115 / 0xB115)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x4);
    CheckExternalEvents(cs1, 0xB11B);
    // JL 0x0000:b0e0 (0000_B119 / 0xB119)
    if(SignFlag != OverflowFlag) {
      goto label_0000_B0E0_0B0E0;
    }
    CheckExternalEvents(cs1, 0xB120);
    // MOV word ptr [BP + -0x2],0x1 (0000_B11B / 0xB11B)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    label_0000_B120_0B120:
    CheckExternalEvents(cs1, 0xB123);
    // MOV AX,0x11 (0000_B120 / 0xB120)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xB126);
    // IMUL word ptr [BP + -0x2] (0000_B123 / 0xB123)
    int resImul0000_B123 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x2)]);
    AX = (ushort)(resImul0000_B123);
    DX = (ushort)(resImul0000_B123 >> 16);
    CheckExternalEvents(cs1, 0xB128);
    // MOV SI,AX (0000_B126 / 0xB126)
    SI = AX;
    CheckExternalEvents(cs1, 0xB12A);
    // MOV AL,0x8 (0000_B128 / 0xB128)
    AL = 0x8;
    CheckExternalEvents(cs1, 0xB12E);
    // MOV ES,word ptr [0x545c] (0000_B12A / 0xB12A)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB133);
    // MOV byte ptr ES:[SI + 0xc620],AL (0000_B12E / 0xB12E)
    UInt8[ES, (ushort)(SI + 0xC620)] = AL;
    CheckExternalEvents(cs1, 0xB138);
    // MOV byte ptr ES:[SI + 0xc60f],AL (0000_B133 / 0xB133)
    UInt8[ES, (ushort)(SI + 0xC60F)] = AL;
    CheckExternalEvents(cs1, 0xB13B);
    // MOV BX,word ptr [BP + -0x2] (0000_B138 / 0xB138)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xB13F);
    // MOV ES,word ptr [0x54ae] (0000_B13B / 0xB13B)
    ES = UInt16[DS, 0x54AE];
    CheckExternalEvents(cs1, 0xB144);
    // MOV AL,byte ptr ES:[BX + 0x3fe9] (0000_B13F / 0xB13F)
    AL = UInt8[ES, (ushort)(BX + 0x3FE9)];
    CheckExternalEvents(cs1, 0xB148);
    // MOV ES,word ptr [0x545c] (0000_B144 / 0xB144)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xB14D);
    // MOV byte ptr ES:[SI + 0xc614],AL (0000_B148 / 0xB148)
    UInt8[ES, (ushort)(SI + 0xC614)] = AL;
    CheckExternalEvents(cs1, 0xB150);
    // INC word ptr [BP + -0x2] (0000_B14D / 0xB14D)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xB154);
    // CMP word ptr [BP + -0x2],0x8 (0000_B150 / 0xB150)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x8);
    CheckExternalEvents(cs1, 0xB156);
    // JL 0x0000:b120 (0000_B154 / 0xB154)
    if(SignFlag != OverflowFlag) {
      goto label_0000_B120_0B120;
    }
    CheckExternalEvents(cs1, 0xB157);
    // POP SI (0000_B156 / 0xB156)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xB159);
    // MOV SP,BP (0000_B157 / 0xB157)
    SP = BP;
    CheckExternalEvents(cs1, 0xB15A);
    // POP BP (0000_B159 / 0xB159)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xB15B);
    // RETF  (0000_B15A / 0xB15A)
    return FarRet();
  }
  
  public virtual Action unknown_094C_1D30_0B1F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_094C_1D30_0B1F0:
    CheckExternalEvents(cs5, 0x1D31);
    // PUSH BP (094C_1D30 / 0xB1F0)
    Stack.Push16(BP);
    CheckExternalEvents(cs5, 0x1D33);
    // MOV BP,SP (094C_1D31 / 0xB1F1)
    BP = SP;
    CheckExternalEvents(cs5, 0x1D36);
    // MOV AX,0x2 (094C_1D33 / 0xB1F3)
    AX = 0x2;
    CheckExternalEvents(cs5, 0x1D3B);
    // CALLF 0x1000:cecc (094C_1D36 / 0xB1F6)
    FarCall(cs5, 0x1D3B, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs5, 0x1D3E);
    // MOV AX,0x1 (094C_1D3B / 0xB1FB)
    AX = 0x1;
    CheckExternalEvents(cs5, 0x1D3F);
    // PUSH AX (094C_1D3E / 0xB1FE)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x1D44);
    // CALLF 0x0000:3fcc (094C_1D3F / 0xB1FF)
    FarCall(cs5, 0x1D44, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs5, 0x1D47);
    // ADD SP,0x2 (094C_1D44 / 0xB204)
    SP += 0x2;
    CheckExternalEvents(cs5, 0x1D4B);
    // CMP word ptr [BP + 0x6],0x2 (094C_1D47 / 0xB207)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs5, 0x1D4D);
    // JL 0x0000:b213 (094C_1D4B / 0xB20B)
    if(SignFlag != OverflowFlag) {
      goto label_094C_1D53_0B213;
    }
    CheckExternalEvents(cs5, 0x1D51);
    // CMP word ptr [BP + 0x6],0x11 (094C_1D4D / 0xB20D)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x11);
    CheckExternalEvents(cs5, 0x1D53);
    // JL 0x0000:b21f (094C_1D51 / 0xB211)
    if(SignFlag != OverflowFlag) {
      goto label_094C_1D5F_0B21F;
    }
    label_094C_1D53_0B213:
    CheckExternalEvents(cs5, 0x1D56);
    // MOV AX,0x2 (094C_1D53 / 0xB213)
    AX = 0x2;
    CheckExternalEvents(cs5, 0x1D57);
    // PUSH AX (094C_1D56 / 0xB216)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x1D5C);
    // CALLF 0x0000:3fcc (094C_1D57 / 0xB217)
    FarCall(cs5, 0x1D5C, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs5, 0x1D5F);
    // ADD SP,0x2 (094C_1D5C / 0xB21C)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_094C_1D5F_0B21F:
    CheckExternalEvents(cs5, 0x1D63);
    // MOV ES,word ptr [0x5480] (094C_1D5F / 0xB21F)
    ES = UInt16[DS, 0x5480];
    CheckExternalEvents(cs5, 0x1D66);
    // MOV AX,word ptr [BP + 0x6] (094C_1D63 / 0xB223)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs5, 0x1D6A);
    // MOV ES:[0x3ff8],AX (094C_1D66 / 0xB226)
    UInt16[ES, 0x3FF8] = AX;
    CheckExternalEvents(cs5, 0x1D6D);
    // MOV AX,0xa0 (094C_1D6A / 0xB22A)
    AX = 0xA0;
    CheckExternalEvents(cs5, 0x1D70);
    // MOV DX,0x2a02 (094C_1D6D / 0xB22D)
    DX = 0x2A02;
    CheckExternalEvents(cs5, 0x1D71);
    // PUSH DX (094C_1D70 / 0xB230)
    Stack.Push16(DX);
    CheckExternalEvents(cs5, 0x1D72);
    // PUSH AX (094C_1D71 / 0xB231)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x1D75);
    // MOV BX,word ptr [BP + 0x6] (094C_1D72 / 0xB232)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs5, 0x1D77);
    // SHL BX,0x1 (094C_1D75 / 0xB235)
    BX <<= 0x1;
    CheckExternalEvents(cs5, 0x1D79);
    // SHL BX,0x1 (094C_1D77 / 0xB237)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs5, 0x1D7D);
    // MOV ES,word ptr [0x54b2] (094C_1D79 / 0xB239)
    ES = UInt16[DS, 0x54B2];
    CheckExternalEvents(cs5, 0x1D82);
    // PUSH word ptr ES:[BX + 0x4ec4] (094C_1D7D / 0xB23D)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4EC4)]);
    CheckExternalEvents(cs5, 0x1D87);
    // PUSH word ptr ES:[BX + 0x4ec2] (094C_1D82 / 0xB242)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0x4EC2)]);
    CheckExternalEvents(cs5, 0x1D8C);
    // CALLF 0x1000:910b (094C_1D87 / 0xB247)
    FarCall(cs5, 0x1D8C, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs5, 0x1D8F);
    // ADD SP,0x8 (094C_1D8C / 0xB24C)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs5, 0x1D94);
    // MOV word ptr [BP + -0x2],0x0 (094C_1D8F / 0xB24F)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_094C_1D94_0B254:
    CheckExternalEvents(cs5, 0x1D97);
    // MOV BX,word ptr [BP + -0x2] (094C_1D94 / 0xB254)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs5, 0x1D9B);
    // MOV ES,word ptr [0x54b4] (094C_1D97 / 0xB257)
    ES = UInt16[DS, 0x54B4];
    CheckExternalEvents(cs5, 0x1DA0);
    // MOV AL,byte ptr ES:[BX + 0xa0] (094C_1D9B / 0xB25B)
    AL = UInt8[ES, (ushort)(BX + 0xA0)];
    CheckExternalEvents(cs5, 0x1DA2);
    // ADD AL,0x29 (094C_1DA0 / 0xB260)
    AL += 0x29;
    CheckExternalEvents(cs5, 0x1DA4);
    // XOR AL,0xe9 (094C_1DA2 / 0xB262)
    // AL ^= 0xE9;
    AL = Alu.Xor8(AL, 0xE9);
    CheckExternalEvents(cs5, 0x1DA9);
    // MOV byte ptr ES:[BX + 0xa0],AL (094C_1DA4 / 0xB264)
    UInt8[ES, (ushort)(BX + 0xA0)] = AL;
    CheckExternalEvents(cs5, 0x1DAC);
    // INC word ptr [BP + -0x2] (094C_1DA9 / 0xB269)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs5, 0x1DB1);
    // CMP word ptr [BP + -0x2],0x2328 (094C_1DAC / 0xB26C)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x2328);
    CheckExternalEvents(cs5, 0x1DB3);
    // JL 0x0000:b254 (094C_1DB1 / 0xB271)
    if(SignFlag != OverflowFlag) {
      goto label_094C_1D94_0B254;
    }
    CheckExternalEvents(cs5, 0x1DB7);
    // MOV ES,word ptr [0x547e] (094C_1DB3 / 0xB273)
    ES = UInt16[DS, 0x547E];
    CheckExternalEvents(cs5, 0x1DBE);
    // MOV word ptr ES:[0x4594],0x0 (094C_1DB7 / 0xB277)
    UInt16[ES, 0x4594] = 0x0;
    CheckExternalEvents(cs5, 0x1DC0);
    // MOV SP,BP (094C_1DBE / 0xB27E)
    SP = BP;
    CheckExternalEvents(cs5, 0x1DC1);
    // POP BP (094C_1DC0 / 0xB280)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs5, 0x1DC2);
    // RETF  (094C_1DC1 / 0xB281)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_CCD4_0CCD4(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_CCD4_0CCD4:
    CheckExternalEvents(cs1, 0xCCD5);
    // PUSH BP (0000_CCD4 / 0xCCD4)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xCCD7);
    // MOV BP,SP (0000_CCD5 / 0xCCD5)
    BP = SP;
    CheckExternalEvents(cs1, 0xCCDA);
    // MOV AX,0x4 (0000_CCD7 / 0xCCD7)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xCCDF);
    // CALLF 0x1000:cecc (0000_CCDA / 0xCCDA)
    FarCall(cs1, 0xCCDF, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xCCE4);
    // MOV word ptr [BP + -0x4],0x0 (0000_CCDF / 0xCCDF)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_CCE4_0CCE4:
    CheckExternalEvents(cs1, 0xCCE7);
    // MOV AX,0x7d (0000_CCE4 / 0xCCE4)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xCCEA);
    // IMUL word ptr [BP + -0x4] (0000_CCE7 / 0xCCE7)
    int resImul0000_CCE7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_CCE7);
    DX = (ushort)(resImul0000_CCE7 >> 16);
    CheckExternalEvents(cs1, 0xCCEC);
    // MOV BX,AX (0000_CCEA / 0xCCEA)
    BX = AX;
    CheckExternalEvents(cs1, 0xCCF0);
    // MOV ES,word ptr [0x54fa] (0000_CCEC / 0xCCEC)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCCF5);
    // MOV AL,byte ptr ES:[BX + 0xc724] (0000_CCF0 / 0xCCF0)
    AL = UInt8[ES, (ushort)(BX + 0xC724)];
    CheckExternalEvents(cs1, 0xCCF8);
    // MOV BX,word ptr [BP + -0x4] (0000_CCF5 / 0xCCF5)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xCCFC);
    // MOV ES,word ptr [0x54fc] (0000_CCF8 / 0xCCF8)
    ES = UInt16[DS, 0x54FC];
    CheckExternalEvents(cs1, 0xCD01);
    // MOV byte ptr ES:[BX + 0x3248],AL (0000_CCFC / 0xCCFC)
    UInt8[ES, (ushort)(BX + 0x3248)] = AL;
    CheckExternalEvents(cs1, 0xCD04);
    // MOV AX,0x7d (0000_CD01 / 0xCD01)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xCD07);
    // IMUL word ptr [BP + -0x4] (0000_CD04 / 0xCD04)
    int resImul0000_CD04 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_CD04);
    DX = (ushort)(resImul0000_CD04 >> 16);
    CheckExternalEvents(cs1, 0xCD09);
    // MOV BX,AX (0000_CD07 / 0xCD07)
    BX = AX;
    CheckExternalEvents(cs1, 0xCD0D);
    // MOV ES,word ptr [0x54fa] (0000_CD09 / 0xCD09)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCD13);
    // MOV byte ptr ES:[BX + 0xc724],0xff (0000_CD0D / 0xCD0D)
    UInt8[ES, (ushort)(BX + 0xC724)] = 0xFF;
    CheckExternalEvents(cs1, 0xCD16);
    // INC word ptr [BP + -0x4] (0000_CD13 / 0xCD13)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xCD1A);
    // CMP word ptr [BP + -0x4],0x4 (0000_CD16 / 0xCD16)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs1, 0xCD1C);
    // JL 0x0000:cce4 (0000_CD1A / 0xCD1A)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CCE4_0CCE4;
    }
    CheckExternalEvents(cs1, 0xCD21);
    // MOV word ptr [BP + -0x4],0x0 (0000_CD1C / 0xCD1C)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_CD21_0CD21:
    CheckExternalEvents(cs1, 0xCD24);
    // MOV AX,0x11 (0000_CD21 / 0xCD21)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xCD27);
    // IMUL word ptr [BP + -0x4] (0000_CD24 / 0xCD24)
    int resImul0000_CD24 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_CD24);
    DX = (ushort)(resImul0000_CD24 >> 16);
    CheckExternalEvents(cs1, 0xCD29);
    // MOV BX,AX (0000_CD27 / 0xCD27)
    BX = AX;
    CheckExternalEvents(cs1, 0xCD2D);
    // MOV ES,word ptr [0x54fa] (0000_CD29 / 0xCD29)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCD33);
    // MOV byte ptr ES:[BX + 0xc620],0x0 (0000_CD2D / 0xCD2D)
    UInt8[ES, (ushort)(BX + 0xC620)] = 0x0;
    CheckExternalEvents(cs1, 0xCD36);
    // INC word ptr [BP + -0x4] (0000_CD33 / 0xCD33)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xCD3A);
    // CMP word ptr [BP + -0x4],0x8 (0000_CD36 / 0xCD36)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x8);
    CheckExternalEvents(cs1, 0xCD3C);
    // JL 0x0000:cd21 (0000_CD3A / 0xCD3A)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CD21_0CD21;
    }
    CheckExternalEvents(cs1, 0xCD40);
    // MOV ES,word ptr [0x54fe] (0000_CD3C / 0xCD3C)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xCD47);
    // MOV word ptr ES:[0xa44b],0xc06 (0000_CD40 / 0xCD40)
    UInt16[ES, 0xA44B] = 0xC06;
    CheckExternalEvents(cs1, 0xCD4B);
    // MOV ES,word ptr [0x5500] (0000_CD47 / 0xCD47)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xCD52);
    // MOV word ptr ES:[0xa44d],0xc07e (0000_CD4B / 0xCD4B)
    UInt16[ES, 0xA44D] = 0xC07E;
    CheckExternalEvents(cs1, 0xCD55);
    // MOV AX,0x1b0 (0000_CD52 / 0xCD52)
    AX = 0x1B0;
    CheckExternalEvents(cs1, 0xCD58);
    // MOV DX,0x2958 (0000_CD55 / 0xCD55)
    DX = 0x2958;
    CheckExternalEvents(cs1, 0xCD59);
    // PUSH DX (0000_CD58 / 0xCD58)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xCD5A);
    // PUSH AX (0000_CD59 / 0xCD59)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCD5F);
    // CALLF 0x1000:9fc1 (0000_CD5A / 0xCD5A)
    FarCall(cs1, 0xCD5F, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs1, 0xCD62);
    // ADD SP,0x4 (0000_CD5F / 0xCD5F)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCD65);
    // MOV AX,0x2 (0000_CD62 / 0xCD62)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xCD66);
    // PUSH AX (0000_CD65 / 0xCD65)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCD6B);
    // CALLF 0x0000:3fcc (0000_CD66 / 0xCD66)
    FarCall(cs1, 0xCD6B, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0xCD6E);
    // ADD SP,0x2 (0000_CD6B / 0xCD6B)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xCD73);
    // MOV word ptr [BP + -0x4],0x0 (0000_CD6E / 0xCD6E)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_CD73_0CD73:
    CheckExternalEvents(cs1, 0xCD76);
    // MOV BX,word ptr [BP + -0x4] (0000_CD73 / 0xCD73)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xCD7A);
    // MOV ES,word ptr [0x5502] (0000_CD76 / 0xCD76)
    ES = UInt16[DS, 0x5502];
    CheckExternalEvents(cs1, 0xCD80);
    // MOV byte ptr ES:[BX + 0x564],0xd0 (0000_CD7A / 0xCD7A)
    UInt8[ES, (ushort)(BX + 0x564)] = 0xD0;
    CheckExternalEvents(cs1, 0xCD83);
    // INC word ptr [BP + -0x4] (0000_CD80 / 0xCD80)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xCD88);
    // CMP word ptr [BP + -0x4],0x240 (0000_CD83 / 0xCD83)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x240);
    CheckExternalEvents(cs1, 0xCD8A);
    // JL 0x0000:cd73 (0000_CD88 / 0xCD88)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CD73_0CD73;
    }
    CheckExternalEvents(cs1, 0xCD8D);
    // MOV AX,0xe (0000_CD8A / 0xCD8A)
    AX = 0xE;
    CheckExternalEvents(cs1, 0xCD8E);
    // PUSH AX (0000_CD8D / 0xCD8D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCD91);
    // MOV AX,0x4 (0000_CD8E / 0xCD8E)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xCD92);
    // PUSH AX (0000_CD91 / 0xCD91)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCD97);
    // CALLF 0x0000:44a8 (0000_CD92 / 0xCD92)
    FarCall(cs1, 0xCD97, unknown_0170_2DA8_044A8);
    CheckExternalEvents(cs1, 0xCD9A);
    // ADD SP,0x4 (0000_CD97 / 0xCD97)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCD9F);
    // MOV word ptr [BP + -0x4],0x0 (0000_CD9A / 0xCD9A)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_CD9F_0CD9F:
    CheckExternalEvents(cs1, 0xCDA2);
    // MOV BX,word ptr [BP + -0x4] (0000_CD9F / 0xCD9F)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xCDA6);
    // MOV ES,word ptr [0x5504] (0000_CDA2 / 0xCDA2)
    ES = UInt16[DS, 0x5504];
    CheckExternalEvents(cs1, 0xCDAC);
    // MOV byte ptr ES:[BX + 0x9f3],0xff (0000_CDA6 / 0xCDA6)
    UInt8[ES, (ushort)(BX + 0x9F3)] = 0xFF;
    CheckExternalEvents(cs1, 0xCDAF);
    // INC word ptr [BP + -0x4] (0000_CDAC / 0xCDAC)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xCDB3);
    // CMP word ptr [BP + -0x4],0x3 (0000_CDAF / 0xCDAF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs1, 0xCDB5);
    // JL 0x0000:cd9f (0000_CDB3 / 0xCDB3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CD9F_0CD9F;
    }
    CheckExternalEvents(cs1, 0xCDB9);
    // MOV ES,word ptr [0x5506] (0000_CDB5 / 0xCDB5)
    ES = UInt16[DS, 0x5506];
    CheckExternalEvents(cs1, 0xCDC0);
    // MOV word ptr ES:[0x4fbc],0x1 (0000_CDB9 / 0xCDB9)
    UInt16[ES, 0x4FBC] = 0x1;
    CheckExternalEvents(cs1, 0xCDC3);
    // MOV AX,0x244b (0000_CDC0 / 0xCDC0)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xCDC6);
    // MOV DX,0x1ddc (0000_CDC3 / 0xCDC3)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xCDC7);
    // PUSH DX (0000_CDC6 / 0xCDC6)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xCDC8);
    // PUSH AX (0000_CDC7 / 0xCDC7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCDCB);
    // MOV AX,0x2068 (0000_CDC8 / 0xCDC8)
    AX = 0x2068;
    CheckExternalEvents(cs1, 0xCDCC);
    // PUSH DS (0000_CDCB / 0xCDCB)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xCDCD);
    // PUSH AX (0000_CDCC / 0xCDCC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCDD2);
    // CALLF 0x1000:910b (0000_CDCD / 0xCDCD)
    FarCall(cs1, 0xCDD2, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs1, 0xCDD5);
    // ADD SP,0x8 (0000_CDD2 / 0xCDD2)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xCDD8);
    // MOV AX,0x4614 (0000_CDD5 / 0xCDD5)
    AX = 0x4614;
    CheckExternalEvents(cs1, 0xCDDB);
    // MOV DX,0x2a02 (0000_CDD8 / 0xCDD8)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xCDDC);
    // PUSH DX (0000_CDDB / 0xCDDB)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xCDDD);
    // PUSH AX (0000_CDDC / 0xCDDC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCDE0);
    // MOV AX,0x244b (0000_CDDD / 0xCDDD)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xCDE3);
    // MOV DX,0x1ddc (0000_CDE0 / 0xCDE0)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xCDE4);
    // PUSH DX (0000_CDE3 / 0xCDE3)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xCDE5);
    // PUSH AX (0000_CDE4 / 0xCDE4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCDEA);
    // CALLF 0x1000:8f6d (0000_CDE5 / 0xCDE5)
    FarCall(cs1, 0xCDEA, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs1, 0xCDED);
    // ADD SP,0x8 (0000_CDEA / 0xCDEA)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xCDF1);
    // MOV ES,word ptr [0x5508] (0000_CDED / 0xCDED)
    ES = UInt16[DS, 0x5508];
    CheckExternalEvents(cs1, 0xCDF7);
    // CMP word ptr ES:[0x4fba],0x2 (0000_CDF1 / 0xCDF1)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0xCDF9);
    // JNZ 0x0000:ce0d (0000_CDF7 / 0xCDF7)
    if(!ZeroFlag) {
      goto label_0000_CE0D_0CE0D;
    }
    CheckExternalEvents(cs1, 0xCDFC);
    // MOV AX,0xa400 (0000_CDF9 / 0xCDF9)
    AX = 0xA400;
    CheckExternalEvents(cs1, 0xCDFD);
    // PUSH AX (0000_CDFC / 0xCDFC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE00);
    // MOV AX,0x4614 (0000_CDFD / 0xCDFD)
    AX = 0x4614;
    CheckExternalEvents(cs1, 0xCE03);
    // MOV DX,0x2a02 (0000_CE00 / 0xCE00)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xCE04);
    // PUSH DX (0000_CE03 / 0xCE03)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xCE05);
    // PUSH AX (0000_CE04 / 0xCE04)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE0A);
    // CALLF 0x1000:a150 (0000_CE05 / 0xCE05)
    FarCall(cs1, 0xCE0A, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs1, 0xCE0D);
    // ADD SP,0x6 (0000_CE0A / 0xCE0A)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0000_CE0D_0CE0D:
    CheckExternalEvents(cs1, 0xCE11);
    // MOV ES,word ptr [0x550a] (0000_CE0D / 0xCE0D)
    ES = UInt16[DS, 0x550A];
    CheckExternalEvents(cs1, 0xCE18);
    // MOV word ptr ES:[0x3988],0x2 (0000_CE11 / 0xCE11)
    UInt16[ES, 0x3988] = 0x2;
    CheckExternalEvents(cs1, 0xCE1D);
    // CALLF 0x1000:bc98 (0000_CE18 / 0xCE18)
    FarCall(cs1, 0xCE1D, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs1, 0xCE21);
    // MOV ES,word ptr [0x5500] (0000_CE1D / 0xCE1D)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xCE26);
    // PUSH word ptr ES:[0xa44d] (0000_CE21 / 0xCE21)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0xCE2A);
    // MOV ES,word ptr [0x54fe] (0000_CE26 / 0xCE26)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xCE2F);
    // PUSH word ptr ES:[0xa44b] (0000_CE2A / 0xCE2A)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xCE34);
    // CALLF 0x1000:b204 (0000_CE2F / 0xCE2F)
    FarCall(cs1, 0xCE34, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0xCE37);
    // ADD SP,0x4 (0000_CE34 / 0xCE34)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCE3C);
    // CALLF 0x1000:b7df (0000_CE37 / 0xCE37)
    FarCall(cs1, 0xCE3C, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0xCE41);
    // CALLF 0x1000:9193 (0000_CE3C / 0xCE3C)
    FarCall(cs1, 0xCE41, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0xCE44);
    // MOV AX,0x3c (0000_CE41 / 0xCE41)
    AX = 0x3C;
    CheckExternalEvents(cs1, 0xCE45);
    // PUSH AX (0000_CE44 / 0xCE44)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE4A);
    // CALLF 0x1000:8ad6 (0000_CE45 / 0xCE45)
    FarCall(cs1, 0xCE4A, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs1, 0xCE4D);
    // ADD SP,0x2 (0000_CE4A / 0xCE4A)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xCE50);
    // MOV AX,0xffff (0000_CE4D / 0xCE4D)
    AX = 0xFFFF;
    CheckExternalEvents(cs1, 0xCE51);
    // PUSH AX (0000_CE50 / 0xCE50)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE54);
    // MOV AX,0x97d (0000_CE51 / 0xCE51)
    AX = 0x97D;
    CheckExternalEvents(cs1, 0xCE55);
    // PUSH AX (0000_CE54 / 0xCE54)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE58);
    // MOV AX,0xc03 (0000_CE55 / 0xCE55)
    AX = 0xC03;
    CheckExternalEvents(cs1, 0xCE59);
    // PUSH AX (0000_CE58 / 0xCE58)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE5A);
    // PUSH CS (0000_CE59 / 0xCE59)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0xCE5D);
    // CALL 0x0000:d786 (0000_CE5A / 0xCE5A)
    NearCall(cs1, 0xCE5D, ghidra_guess_0000_D786_0D786);
    CheckExternalEvents(cs1, 0xCE60);
    // ADD SP,0x6 (0000_CE5D / 0xCE5D)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    CheckExternalEvents(cs1, 0xCE65);
    // MOV word ptr [BP + -0x4],0x0 (0000_CE60 / 0xCE60)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_CE65_0CE65:
    CheckExternalEvents(cs1, 0xCE68);
    // MOV AX,0x11 (0000_CE65 / 0xCE65)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xCE6B);
    // IMUL word ptr [BP + -0x4] (0000_CE68 / 0xCE68)
    int resImul0000_CE68 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_CE68);
    DX = (ushort)(resImul0000_CE68 >> 16);
    CheckExternalEvents(cs1, 0xCE6D);
    // MOV BX,AX (0000_CE6B / 0xCE6B)
    BX = AX;
    CheckExternalEvents(cs1, 0xCE71);
    // MOV ES,word ptr [0x54fa] (0000_CE6D / 0xCE6D)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCE77);
    // MOV byte ptr ES:[BX + 0xc620],0x8 (0000_CE71 / 0xCE71)
    UInt8[ES, (ushort)(BX + 0xC620)] = 0x8;
    CheckExternalEvents(cs1, 0xCE7A);
    // INC word ptr [BP + -0x4] (0000_CE77 / 0xCE77)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xCE7E);
    // CMP word ptr [BP + -0x4],0x8 (0000_CE7A / 0xCE7A)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x8);
    CheckExternalEvents(cs1, 0xCE80);
    // JL 0x0000:ce65 (0000_CE7E / 0xCE7E)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CE65_0CE65;
    }
    CheckExternalEvents(cs1, 0xCE83);
    // MOV AX,0x17 (0000_CE80 / 0xCE80)
    AX = 0x17;
    CheckExternalEvents(cs1, 0xCE84);
    // PUSH AX (0000_CE83 / 0xCE83)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCE89);
    // CALLF 0x0000:94c8 (0000_CE84 / 0xCE84)
    FarCall(cs1, 0xCE89, unknown_094C_0008_094C8);
    CheckExternalEvents(cs1, 0xCE8C);
    // ADD SP,0x2 (0000_CE89 / 0xCE89)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xCE91);
    // MOV word ptr [BP + -0x2],0x0 (0000_CE8C / 0xCE8C)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_CE91_0CE91:
    CheckExternalEvents(cs1, 0xCE94);
    // MOV BX,word ptr [BP + -0x2] (0000_CE91 / 0xCE91)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xCE98);
    // MOV ES,word ptr [0x54fa] (0000_CE94 / 0xCE94)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCE9E);
    // CMP byte ptr ES:[BX + 0xd34f],0x0 (0000_CE98 / 0xCE98)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0xD34F)], 0x0);
    CheckExternalEvents(cs1, 0xCEA0);
    // JZ 0x0000:ceac (0000_CE9E / 0xCE9E)
    if(ZeroFlag) {
      goto label_0000_CEAC_0CEAC;
    }
    CheckExternalEvents(cs1, 0xCEA1);
    // PUSH BX (0000_CEA0 / 0xCEA0)
    Stack.Push16(BX);
    CheckExternalEvents(cs1, 0xCEA3);
    // SUB AX,AX (0000_CEA1 / 0xCEA1)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xCEA4);
    // PUSH AX (0000_CEA3 / 0xCEA3)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCEA5);
    // PUSH AX (0000_CEA4 / 0xCEA4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCEA6);
    // PUSH CS (0000_CEA5 / 0xCEA5)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0xCEA9);
    // CALL 0x0000:d786 (0000_CEA6 / 0xCEA6)
    NearCall(cs1, 0xCEA9, ghidra_guess_0000_D786_0D786);
    CheckExternalEvents(cs1, 0xCEAC);
    // ADD SP,0x6 (0000_CEA9 / 0xCEA9)
    SP += 0x6;
    label_0000_CEAC_0CEAC:
    CheckExternalEvents(cs1, 0xCEAF);
    // INC word ptr [BP + -0x2] (0000_CEAC / 0xCEAC)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xCEB3);
    // CMP word ptr [BP + -0x2],0xb (0000_CEAF / 0xCEAF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0xB);
    CheckExternalEvents(cs1, 0xCEB5);
    // JL 0x0000:ce91 (0000_CEB3 / 0xCEB3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CE91_0CE91;
    }
    CheckExternalEvents(cs1, 0xCEB7);
    // MOV SP,BP (0000_CEB5 / 0xCEB5)
    SP = BP;
    CheckExternalEvents(cs1, 0xCEB8);
    // POP BP (0000_CEB7 / 0xCEB7)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xCEB9);
    // RETF  (0000_CEB8 / 0xCEB8)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_CEB9_0CEB9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_CEB9_0CEB9:
    CheckExternalEvents(cs1, 0xCEBA);
    // PUSH BP (0000_CEB9 / 0xCEB9)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xCEBC);
    // MOV BP,SP (0000_CEBA / 0xCEBA)
    BP = SP;
    CheckExternalEvents(cs1, 0xCEBF);
    // MOV AX,0x6 (0000_CEBC / 0xCEBC)
    AX = 0x6;
    CheckExternalEvents(cs1, 0xCEC4);
    // CALLF 0x1000:cecc (0000_CEBF / 0xCEBF)
    FarCall(cs1, 0xCEC4, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xCEC5);
    // PUSH SI (0000_CEC4 / 0xCEC4)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xCECA);
    // MOV word ptr [BP + -0x2],0xa10 (0000_CEC5 / 0xCEC5)
    UInt16[SS, (ushort)(BP - 0x2)] = 0xA10;
    CheckExternalEvents(cs1, 0xCECF);
    // MOV word ptr [BP + -0x4],0x0 (0000_CECA / 0xCECA)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    label_0000_CECF_0CECF:
    CheckExternalEvents(cs1, 0xCED4);
    // MOV word ptr [BP + -0x6],0x0 (0000_CECF / 0xCECF)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_CED4_0CED4:
    CheckExternalEvents(cs1, 0xCED7);
    // MOV AX,0x3 (0000_CED4 / 0xCED4)
    AX = 0x3;
    CheckExternalEvents(cs1, 0xCEDA);
    // IMUL word ptr [BP + -0x4] (0000_CED7 / 0xCED7)
    int resImul0000_CED7 = Alu.Imul16((short)AX, (short)UInt16[SS, (ushort)(BP - 0x4)]);
    AX = (ushort)(resImul0000_CED7);
    DX = (ushort)(resImul0000_CED7 >> 16);
    CheckExternalEvents(cs1, 0xCEDC);
    // MOV SI,AX (0000_CEDA / 0xCEDA)
    SI = AX;
    CheckExternalEvents(cs1, 0xCEDF);
    // MOV BX,word ptr [BP + -0x6] (0000_CEDC / 0xCEDC)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xCEE3);
    // MOV AL,byte ptr [BX + SI + 0x20bc] (0000_CEDF / 0xCEDF)
    AL = UInt8[DS, (ushort)(BX + SI + 0x20BC)];
    CheckExternalEvents(cs1, 0xCEE6);
    // MOV BX,word ptr [BP + -0x2] (0000_CEE3 / 0xCEE3)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xCEE9);
    // ADD BX,word ptr [BP + -0x6] (0000_CEE6 / 0xCEE6)
    // BX += UInt16[SS, (ushort)(BP - 0x6)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0xCEED);
    // MOV ES,word ptr [0x550c] (0000_CEE9 / 0xCEE9)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xCEF2);
    // MOV byte ptr ES:[BX + 0x101d],AL (0000_CEED / 0xCEED)
    UInt8[ES, (ushort)(BX + 0x101D)] = AL;
    CheckExternalEvents(cs1, 0xCEF5);
    // INC word ptr [BP + -0x6] (0000_CEF2 / 0xCEF2)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0xCEF9);
    // CMP word ptr [BP + -0x6],0x3 (0000_CEF5 / 0xCEF5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs1, 0xCEFB);
    // JL 0x0000:ced4 (0000_CEF9 / 0xCEF9)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CED4_0CED4;
    }
    CheckExternalEvents(cs1, 0xCEFF);
    // ADD word ptr [BP + -0x2],0x8 (0000_CEFB / 0xCEFB)
    UInt16[SS, (ushort)(BP - 0x2)] += 0x8;
    CheckExternalEvents(cs1, 0xCF02);
    // INC word ptr [BP + -0x4] (0000_CEFF / 0xCEFF)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    CheckExternalEvents(cs1, 0xCF06);
    // CMP word ptr [BP + -0x4],0x6 (0000_CF02 / 0xCF02)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x6);
    CheckExternalEvents(cs1, 0xCF08);
    // JL 0x0000:cecf (0000_CF06 / 0xCF06)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CECF_0CECF;
    }
    CheckExternalEvents(cs1, 0xCF0C);
    // MOV ES,word ptr [0x5500] (0000_CF08 / 0xCF08)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xCF11);
    // PUSH word ptr ES:[0xa44d] (0000_CF0C / 0xCF0C)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0xCF15);
    // MOV ES,word ptr [0x54fe] (0000_CF11 / 0xCF11)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xCF1A);
    // PUSH word ptr ES:[0xa44b] (0000_CF15 / 0xCF15)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xCF1F);
    // CALLF 0x1000:b204 (0000_CF1A / 0xCF1A)
    FarCall(cs1, 0xCF1F, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0xCF22);
    // ADD SP,0x4 (0000_CF1F / 0xCF1F)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCF27);
    // CALLF 0x1000:b7df (0000_CF22 / 0xCF22)
    FarCall(cs1, 0xCF27, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0xCF2C);
    // CALLF 0x0000:1c1b (0000_CF27 / 0xCF27)
    FarCall(cs1, 0xCF2C, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs1, 0xCF31);
    // CALLF 0x1000:9193 (0000_CF2C / 0xCF2C)
    FarCall(cs1, 0xCF31, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0xCF36);
    // CALLF 0x1000:7bf6 (0000_CF31 / 0xCF31)
    FarCall(cs1, 0xCF36, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xCF39);
    // MOV AX,0x2075 (0000_CF36 / 0xCF36)
    AX = 0x2075;
    CheckExternalEvents(cs1, 0xCF3A);
    // PUSH DS (0000_CF39 / 0xCF39)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xCF3B);
    // PUSH AX (0000_CF3A / 0xCF3A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCF40);
    // CALLF 0x1000:7c1a (0000_CF3B / 0xCF3B)
    FarCall(cs1, 0xCF40, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xCF43);
    // ADD SP,0x4 (0000_CF40 / 0xCF40)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCF48);
    // CALLF 0x1000:8d29 (0000_CF43 / 0xCF43)
    FarCall(cs1, 0xCF48, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xCF4C);
    // MOV ES,word ptr [0x550e] (0000_CF48 / 0xCF48)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xCF53);
    // MOV word ptr ES:[0xd55c],0x1 (0000_CF4C / 0xCF4C)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs1, 0xCF54);
    // POP SI (0000_CF53 / 0xCF53)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xCF56);
    // MOV SP,BP (0000_CF54 / 0xCF54)
    SP = BP;
    CheckExternalEvents(cs1, 0xCF57);
    // POP BP (0000_CF56 / 0xCF56)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xCF58);
    // RETF  (0000_CF57 / 0xCF57)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_CF58_0CF58(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_CF58_0CF58:
    CheckExternalEvents(cs1, 0xCF5A);
    // XOR AX,AX (0000_CF58 / 0xCF58)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0xCF5F);
    // CALLF 0x1000:cecc (0000_CF5A / 0xCF5A)
    FarCall(cs1, 0xCF5F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xCF63);
    // MOV ES,word ptr [0x54fa] (0000_CF5F / 0xCF5F)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCF69);
    // CMP byte ptr ES:[0xd34b],0x0 (0000_CF63 / 0xCF63)
    Alu.Sub8(UInt8[ES, 0xD34B], 0x0);
    CheckExternalEvents(cs1, 0xCF6B);
    // JNZ 0x0000:cf77 (0000_CF69 / 0xCF69)
    if(!ZeroFlag) {
      // JNZ target is RETF, inlining.
      CheckExternalEvents(cs1, 0xCF78);
      // RETF  (0000_CF77 / 0xCF77)
      return FarRet();
    }
    CheckExternalEvents(cs1, 0xCF6E);
    // MOV AX,0x16 (0000_CF6B / 0xCF6B)
    AX = 0x16;
    CheckExternalEvents(cs1, 0xCF6F);
    // PUSH AX (0000_CF6E / 0xCF6E)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCF74);
    // CALLF 0x0000:94c8 (0000_CF6F / 0xCF6F)
    FarCall(cs1, 0xCF74, unknown_094C_0008_094C8);
    CheckExternalEvents(cs1, 0xCF77);
    // ADD SP,0x2 (0000_CF74 / 0xCF74)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0000_CF77_0CF77:
    CheckExternalEvents(cs1, 0xCF78);
    // RETF  (0000_CF77 / 0xCF77)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_CF78_0CF78(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_CF78_0CF78:
    CheckExternalEvents(cs1, 0xCF7A);
    // XOR AX,AX (0000_CF78 / 0xCF78)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0xCF7F);
    // CALLF 0x1000:cecc (0000_CF7A / 0xCF7A)
    FarCall(cs1, 0xCF7F, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xCF84);
    // CALLF 0x1000:7bf6 (0000_CF7F / 0xCF7F)
    FarCall(cs1, 0xCF84, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xCF87);
    // MOV AX,0x20ce (0000_CF84 / 0xCF84)
    AX = 0x20CE;
    CheckExternalEvents(cs1, 0xCF88);
    // PUSH DS (0000_CF87 / 0xCF87)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xCF89);
    // PUSH AX (0000_CF88 / 0xCF88)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCF8E);
    // CALLF 0x1000:7c1a (0000_CF89 / 0xCF89)
    FarCall(cs1, 0xCF8E, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xCF91);
    // ADD SP,0x4 (0000_CF8E / 0xCF8E)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCF96);
    // CALLF 0x1000:8d29 (0000_CF91 / 0xCF91)
    FarCall(cs1, 0xCF96, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xCF9A);
    // MOV ES,word ptr [0x550e] (0000_CF96 / 0xCF96)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xCFA1);
    // MOV word ptr ES:[0xd55c],0x1 (0000_CF9A / 0xCF9A)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs1, 0xCFA2);
    // RETF  (0000_CFA1 / 0xCFA1)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_CFA2_0CFA2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_CFA2_0CFA2:
    CheckExternalEvents(cs1, 0xCFA3);
    // PUSH BP (0000_CFA2 / 0xCFA2)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xCFA5);
    // MOV BP,SP (0000_CFA3 / 0xCFA3)
    BP = SP;
    CheckExternalEvents(cs1, 0xCFA7);
    // XOR AX,AX (0000_CFA5 / 0xCFA5)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0xCFAC);
    // CALLF 0x1000:cecc (0000_CFA7 / 0xCFA7)
    FarCall(cs1, 0xCFAC, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xCFAF);
    // MOV AX,word ptr [BP + 0x6] (0000_CFAC / 0xCFAC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xCFB0);
    // INC AX (0000_CFAF / 0xCFAF)
    AX++;
    CheckExternalEvents(cs1, 0xCFB3);
    // AND AX,0x7e (0000_CFB0 / 0xCFB0)
    // AX &= 0x7E;
    AX = Alu.And16(AX, 0x7E);
    CheckExternalEvents(cs1, 0xCFB6);
    // MOV word ptr [BP + 0x6],AX (0000_CFB3 / 0xCFB3)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xCFBA);
    // AND word ptr [BP + 0x8],0x7e (0000_CFB6 / 0xCFB6)
    UInt16[SS, (ushort)(BP + 0x8)] &= 0x7E;
    CheckExternalEvents(cs1, 0xCFBD);
    // CMP AX,0x4e (0000_CFBA / 0xCFBA)
    Alu.Sub16(AX, 0x4E);
    CheckExternalEvents(cs1, 0xCFBF);
    // JNZ 0x0000:cff5 (0000_CFBD / 0xCFBD)
    if(!ZeroFlag) {
      goto label_0000_CFF5_0CFF5;
    }
    CheckExternalEvents(cs1, 0xCFC3);
    // CMP word ptr [BP + 0x8],0xc (0000_CFBF / 0xCFBF)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0xC);
    CheckExternalEvents(cs1, 0xCFC5);
    // JL 0x0000:cff5 (0000_CFC3 / 0xCFC3)
    if(SignFlag != OverflowFlag) {
      goto label_0000_CFF5_0CFF5;
    }
    CheckExternalEvents(cs1, 0xCFC9);
    // CMP word ptr [BP + 0x8],0x11 (0000_CFC5 / 0xCFC5)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x11);
    CheckExternalEvents(cs1, 0xCFCB);
    // JG 0x0000:cff5 (0000_CFC9 / 0xCFC9)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_CFF5_0CFF5;
    }
    CheckExternalEvents(cs1, 0xCFD0);
    // CALLF 0x1000:7bf6 (0000_CFCB / 0xCFCB)
    FarCall(cs1, 0xCFD0, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xCFD3);
    // MOV AX,0x2113 (0000_CFD0 / 0xCFD0)
    AX = 0x2113;
    CheckExternalEvents(cs1, 0xCFD4);
    // PUSH DS (0000_CFD3 / 0xCFD3)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xCFD5);
    // PUSH AX (0000_CFD4 / 0xCFD4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xCFDA);
    // CALLF 0x1000:7c1a (0000_CFD5 / 0xCFD5)
    FarCall(cs1, 0xCFDA, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xCFDD);
    // ADD SP,0x4 (0000_CFDA / 0xCFDA)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xCFE2);
    // CALLF 0x1000:8d29 (0000_CFDD / 0xCFDD)
    FarCall(cs1, 0xCFE2, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xCFE4);
    // MOV AL,0x1 (0000_CFE2 / 0xCFE2)
    AL = 0x1;
    CheckExternalEvents(cs1, 0xCFE8);
    // MOV ES,word ptr [0x54fa] (0000_CFE4 / 0xCFE4)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xCFEC);
    // MOV ES:[0xd34c],AL (0000_CFE8 / 0xCFE8)
    UInt8[ES, 0xD34C] = AL;
    CheckExternalEvents(cs1, 0xCFED);
    // CBW  (0000_CFEC / 0xCFEC)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xCFF1);
    // MOV ES,word ptr [0x550e] (0000_CFED / 0xCFED)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xCFF5);
    // MOV ES:[0xd55c],AX (0000_CFF1 / 0xCFF1)
    UInt16[ES, 0xD55C] = AX;
    label_0000_CFF5_0CFF5:
    CheckExternalEvents(cs1, 0xCFF6);
    // POP BP (0000_CFF5 / 0xCFF5)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xCFF7);
    // RETF  (0000_CFF6 / 0xCFF6)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_CFF7_0CFF7(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_CFF7_0CFF7:
    CheckExternalEvents(cs1, 0xCFF8);
    // PUSH BP (0000_CFF7 / 0xCFF7)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xCFFA);
    // MOV BP,SP (0000_CFF8 / 0xCFF8)
    BP = SP;
    CheckExternalEvents(cs1, 0xCFFD);
    // MOV AX,0x4 (0000_CFFA / 0xCFFA)
    AX = 0x4;
    CheckExternalEvents(cs1, 0xD002);
    // CALLF 0x1000:cecc (0000_CFFD / 0xCFFD)
    FarCall(cs1, 0xD002, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD007);
    // MOV word ptr [BP + -0x4],0x0 (0000_D002 / 0xD002)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0xD009);
    // JMP 0x0000:d030 (0000_D007 / 0xD007)
    goto label_0000_D030_0D030;
    label_0000_D009_0D009:
    CheckExternalEvents(cs1, 0xD00C);
    // MOV BX,word ptr [BP + -0x4] (0000_D009 / 0xD009)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xD010);
    // MOV ES,word ptr [0x5514] (0000_D00C / 0xD00C)
    ES = UInt16[DS, 0x5514];
    CheckExternalEvents(cs1, 0xD015);
    // MOV AL,byte ptr ES:[BX + 0x2257] (0000_D010 / 0xD010)
    AL = UInt8[ES, (ushort)(BX + 0x2257)];
    CheckExternalEvents(cs1, 0xD019);
    // MOV ES,word ptr [0x5510] (0000_D015 / 0xD015)
    ES = UInt16[DS, 0x5510];
    CheckExternalEvents(cs1, 0xD01E);
    // MOV byte ptr ES:[BX + 0x215d],AL (0000_D019 / 0xD019)
    UInt8[ES, (ushort)(BX + 0x215D)] = AL;
    CheckExternalEvents(cs1, 0xD021);
    // MOV AL,byte ptr [BP + -0x2] (0000_D01E / 0xD01E)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD024);
    // MOV BX,word ptr [BP + -0x4] (0000_D021 / 0xD021)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xD028);
    // MOV ES,word ptr [0x5514] (0000_D024 / 0xD024)
    ES = UInt16[DS, 0x5514];
    CheckExternalEvents(cs1, 0xD02D);
    // MOV byte ptr ES:[BX + 0x2257],AL (0000_D028 / 0xD028)
    UInt8[ES, (ushort)(BX + 0x2257)] = AL;
    label_0000_D02D_0D02D:
    CheckExternalEvents(cs1, 0xD030);
    // INC word ptr [BP + -0x4] (0000_D02D / 0xD02D)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_D030_0D030:
    CheckExternalEvents(cs1, 0xD035);
    // CMP word ptr [BP + -0x4],0xfa (0000_D030 / 0xD030)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0xFA);
    CheckExternalEvents(cs1, 0xD037);
    // JGE 0x0000:d076 (0000_D035 / 0xD035)
    if(SignFlag == OverflowFlag) {
      goto label_0000_D076_0D076;
    }
    CheckExternalEvents(cs1, 0xD03A);
    // MOV BX,word ptr [BP + -0x4] (0000_D037 / 0xD037)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xD03E);
    // MOV ES,word ptr [0x5510] (0000_D03A / 0xD03A)
    ES = UInt16[DS, 0x5510];
    CheckExternalEvents(cs1, 0xD043);
    // MOV AL,byte ptr ES:[BX + 0x215d] (0000_D03E / 0xD03E)
    AL = UInt8[ES, (ushort)(BX + 0x215D)];
    CheckExternalEvents(cs1, 0xD044);
    // CBW  (0000_D043 / 0xD043)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD047);
    // MOV word ptr [BP + -0x2],AX (0000_D044 / 0xD044)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xD04B);
    // MOV ES,word ptr [0x54fa] (0000_D047 / 0xD047)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD051);
    // CMP byte ptr ES:[0xd34e],0x0 (0000_D04B / 0xD04B)
    Alu.Sub8(UInt8[ES, 0xD34E], 0x0);
    CheckExternalEvents(cs1, 0xD053);
    // JZ 0x0000:d009 (0000_D051 / 0xD051)
    if(ZeroFlag) {
      goto label_0000_D009_0D009;
    }
    CheckExternalEvents(cs1, 0xD057);
    // MOV ES,word ptr [0x5512] (0000_D053 / 0xD053)
    ES = UInt16[DS, 0x5512];
    CheckExternalEvents(cs1, 0xD05C);
    // MOV AL,byte ptr ES:[BX + 0x2351] (0000_D057 / 0xD057)
    AL = UInt8[ES, (ushort)(BX + 0x2351)];
    CheckExternalEvents(cs1, 0xD060);
    // MOV ES,word ptr [0x5510] (0000_D05C / 0xD05C)
    ES = UInt16[DS, 0x5510];
    CheckExternalEvents(cs1, 0xD065);
    // MOV byte ptr ES:[BX + 0x215d],AL (0000_D060 / 0xD060)
    UInt8[ES, (ushort)(BX + 0x215D)] = AL;
    CheckExternalEvents(cs1, 0xD068);
    // MOV AL,byte ptr [BP + -0x2] (0000_D065 / 0xD065)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD06B);
    // MOV BX,word ptr [BP + -0x4] (0000_D068 / 0xD068)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xD06F);
    // MOV ES,word ptr [0x5512] (0000_D06B / 0xD06B)
    ES = UInt16[DS, 0x5512];
    CheckExternalEvents(cs1, 0xD074);
    // MOV byte ptr ES:[BX + 0x2351],AL (0000_D06F / 0xD06F)
    UInt8[ES, (ushort)(BX + 0x2351)] = AL;
    CheckExternalEvents(cs1, 0xD076);
    // JMP 0x0000:d02d (0000_D074 / 0xD074)
    goto label_0000_D02D_0D02D;
    label_0000_D076_0D076:
    CheckExternalEvents(cs1, 0xD078);
    // MOV SP,BP (0000_D076 / 0xD076)
    SP = BP;
    CheckExternalEvents(cs1, 0xD079);
    // POP BP (0000_D078 / 0xD078)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD07A);
    // RETF  (0000_D079 / 0xD079)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_D07A_0D07A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D07A_0D07A:
    CheckExternalEvents(cs1, 0xD07B);
    // PUSH BP (0000_D07A / 0xD07A)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD07D);
    // MOV BP,SP (0000_D07B / 0xD07B)
    BP = SP;
    CheckExternalEvents(cs1, 0xD080);
    // MOV AX,0x2 (0000_D07D / 0xD07D)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xD085);
    // CALLF 0x1000:cecc (0000_D080 / 0xD080)
    FarCall(cs1, 0xD085, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD086);
    // PUSH SI (0000_D085 / 0xD085)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xD089);
    // MOV AX,word ptr [BP + 0x6] (0000_D086 / 0xD086)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD08A);
    // INC AX (0000_D089 / 0xD089)
    AX++;
    CheckExternalEvents(cs1, 0xD08D);
    // AND AX,0x7f (0000_D08A / 0xD08A)
    // AX &= 0x7F;
    AX = Alu.And16(AX, 0x7F);
    CheckExternalEvents(cs1, 0xD090);
    // MOV word ptr [BP + 0x6],AX (0000_D08D / 0xD08D)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD094);
    // AND word ptr [BP + 0x8],0x7f (0000_D090 / 0xD090)
    // UInt16[SS, (ushort)(BP + 0x8)] &= 0x7F;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu.And16(UInt16[SS, (ushort)(BP + 0x8)], 0x7F);
    CheckExternalEvents(cs1, 0xD099);
    // MOV word ptr [BP + -0x2],0x0 (0000_D094 / 0xD094)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    CheckExternalEvents(cs1, 0xD09C);
    // JMP 0x0000:d124 (0000_D099 / 0xD099)
    goto label_0000_D124_0D124;
    label_0000_D09C_0D09C:
    CheckExternalEvents(cs1, 0xD09F);
    // MOV AX,0x2187 (0000_D09C / 0xD09C)
    AX = 0x2187;
    CheckExternalEvents(cs1, 0xD0A0);
    // PUSH DS (0000_D09F / 0xD09F)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD0A1);
    // PUSH AX (0000_D0A0 / 0xD0A0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD0A6);
    // CALLF 0x1000:8055 (0000_D0A1 / 0xD0A1)
    FarCall(cs1, 0xD0A6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD0A9);
    // ADD SP,0x4 (0000_D0A6 / 0xD0A6)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD0AC);
    // MOV BX,word ptr [BP + -0x2] (0000_D0A9 / 0xD0A9)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD0B0);
    // MOV AL,byte ptr [BX + 0x2212] (0000_D0AC / 0xD0AC)
    AL = UInt8[DS, (ushort)(BX + 0x2212)];
    CheckExternalEvents(cs1, 0xD0B1);
    // CBW  (0000_D0B0 / 0xD0B0)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD0B3);
    // MOV BX,AX (0000_D0B1 / 0xD0B1)
    BX = AX;
    CheckExternalEvents(cs1, 0xD0B5);
    // SHL BX,0x1 (0000_D0B3 / 0xD0B3)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xD0B7);
    // SHL BX,0x1 (0000_D0B5 / 0xD0B5)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xD0BB);
    // PUSH word ptr [BX + 0x2236] (0000_D0B7 / 0xD0B7)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x2236)]);
    CheckExternalEvents(cs1, 0xD0BF);
    // PUSH word ptr [BX + 0x2234] (0000_D0BB / 0xD0BB)
    Stack.Push16(UInt16[DS, (ushort)(BX + 0x2234)]);
    CheckExternalEvents(cs1, 0xD0C4);
    // CALLF 0x1000:8055 (0000_D0BF / 0xD0BF)
    FarCall(cs1, 0xD0C4, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD0C7);
    // ADD SP,0x4 (0000_D0C4 / 0xD0C4)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD0CA);
    // MOV AX,0x21b2 (0000_D0C7 / 0xD0C7)
    AX = 0x21B2;
    CheckExternalEvents(cs1, 0xD0CB);
    // PUSH DS (0000_D0CA / 0xD0CA)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD0CC);
    // PUSH AX (0000_D0CB / 0xD0CB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD0D1);
    // CALLF 0x1000:8055 (0000_D0CC / 0xD0CC)
    FarCall(cs1, 0xD0D1, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD0D4);
    // ADD SP,0x4 (0000_D0D1 / 0xD0D1)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD0D7);
    // MOV AX,word ptr [BP + -0x2] (0000_D0D4 / 0xD0D4)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD0D8);
    // INC AX (0000_D0D7 / 0xD0D7)
    AX = Alu.Inc16(AX);
    CheckExternalEvents(cs1, 0xD0D9);
    // PUSH AX (0000_D0D8 / 0xD0D8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD0DE);
    // CALLF 0x1000:8b23 (0000_D0D9 / 0xD0D9)
    FarCall(cs1, 0xD0DE, ghidra_guess_1000_8B23_18B23);
    CheckExternalEvents(cs1, 0xD0E1);
    // ADD SP,0x2 (0000_D0DE / 0xD0DE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD0E4);
    // MOV AX,0x21b9 (0000_D0E1 / 0xD0E1)
    AX = 0x21B9;
    CheckExternalEvents(cs1, 0xD0E5);
    // PUSH DS (0000_D0E4 / 0xD0E4)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD0E6);
    // PUSH AX (0000_D0E5 / 0xD0E5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD0EB);
    // CALLF 0x1000:8055 (0000_D0E6 / 0xD0E6)
    FarCall(cs1, 0xD0EB, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xD0EE);
    // ADD SP,0x4 (0000_D0EB / 0xD0EB)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD0F1);
    // MOV AX,0x1 (0000_D0EE / 0xD0EE)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xD0F2);
    // PUSH AX (0000_D0F1 / 0xD0F1)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD0F7);
    // CALLF 0x0000:3113 (0000_D0F2 / 0xD0F2)
    FarCall(cs1, 0xD0F7, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0xD0FA);
    // ADD SP,0x2 (0000_D0F7 / 0xD0F7)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD0FC);
    // OR AX,AX (0000_D0FA / 0xD0FA)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    CheckExternalEvents(cs1, 0xD0FE);
    // JZ 0x0000:d116 (0000_D0FC / 0xD0FC)
    if(ZeroFlag) {
      goto label_0000_D116_0D116;
    }
    CheckExternalEvents(cs1, 0xD101);
    // MOV AL,byte ptr [BP + -0x2] (0000_D0FE / 0xD0FE)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD104);
    // MOV BX,word ptr [BP + -0x2] (0000_D101 / 0xD101)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD106);
    // MOV CX,AX (0000_D104 / 0xD104)
    CX = AX;
    CheckExternalEvents(cs1, 0xD10A);
    // MOV AL,byte ptr [BX + 0x2212] (0000_D106 / 0xD106)
    AL = UInt8[DS, (ushort)(BX + 0x2212)];
    CheckExternalEvents(cs1, 0xD10B);
    // CBW  (0000_D10A / 0xD10A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD10D);
    // MOV BX,AX (0000_D10B / 0xD10B)
    BX = AX;
    CheckExternalEvents(cs1, 0xD111);
    // MOV ES,word ptr [0x54fa] (0000_D10D / 0xD10D)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD116);
    // MOV byte ptr ES:[BX + 0xd347],CL (0000_D111 / 0xD111)
    UInt8[ES, (ushort)(BX + 0xD347)] = CL;
    label_0000_D116_0D116:
    CheckExternalEvents(cs1, 0xD11A);
    // MOV ES,word ptr [0x550e] (0000_D116 / 0xD116)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD121);
    // MOV word ptr ES:[0xd55c],0x1 (0000_D11A / 0xD11A)
    UInt16[ES, 0xD55C] = 0x1;
    label_0000_D121_0D121:
    CheckExternalEvents(cs1, 0xD124);
    // INC word ptr [BP + -0x2] (0000_D121 / 0xD121)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    label_0000_D124_0D124:
    CheckExternalEvents(cs1, 0xD128);
    // CMP word ptr [BP + -0x2],0x21 (0000_D124 / 0xD124)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x21);
    CheckExternalEvents(cs1, 0xD12A);
    // JGE 0x0000:d176 (0000_D128 / 0xD128)
    if(SignFlag == OverflowFlag) {
      goto label_0000_D176_0D176;
    }
    CheckExternalEvents(cs1, 0xD12D);
    // MOV BX,word ptr [BP + -0x2] (0000_D12A / 0xD12A)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD131);
    // MOV AL,byte ptr [BX + 0x21f0] (0000_D12D / 0xD12D)
    AL = UInt8[DS, (ushort)(BX + 0x21F0)];
    CheckExternalEvents(cs1, 0xD132);
    // CBW  (0000_D131 / 0xD131)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD135);
    // CMP AX,word ptr [BP + 0x8] (0000_D132 / 0xD132)
    Alu.Sub16(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs1, 0xD137);
    // JNZ 0x0000:d121 (0000_D135 / 0xD135)
    if(!ZeroFlag) {
      goto label_0000_D121_0D121;
    }
    CheckExternalEvents(cs1, 0xD13B);
    // MOV AL,byte ptr [BX + 0x21ce] (0000_D137 / 0xD137)
    AL = UInt8[DS, (ushort)(BX + 0x21CE)];
    CheckExternalEvents(cs1, 0xD13C);
    // CBW  (0000_D13B / 0xD13B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD13E);
    // MOV SI,AX (0000_D13C / 0xD13C)
    SI = AX;
    CheckExternalEvents(cs1, 0xD141);
    // CMP word ptr [BP + 0x6],SI (0000_D13E / 0xD13E)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], SI);
    CheckExternalEvents(cs1, 0xD143);
    // JL 0x0000:d121 (0000_D141 / 0xD141)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D121_0D121;
    }
    CheckExternalEvents(cs1, 0xD146);
    // LEA AX,[SI + 0x3] (0000_D143 / 0xD143)
    AX = (ushort)(SI + 0x3);
    CheckExternalEvents(cs1, 0xD149);
    // CMP word ptr [BP + 0x6],AX (0000_D146 / 0xD146)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], AX);
    CheckExternalEvents(cs1, 0xD14B);
    // JGE 0x0000:d121 (0000_D149 / 0xD149)
    if(SignFlag == OverflowFlag) {
      goto label_0000_D121_0D121;
    }
    CheckExternalEvents(cs1, 0xD150);
    // CALLF 0x1000:7bf6 (0000_D14B / 0xD14B)
    FarCall(cs1, 0xD150, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD153);
    // MOV BX,word ptr [BP + -0x2] (0000_D150 / 0xD150)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD157);
    // MOV ES,word ptr [0x5516] (0000_D153 / 0xD153)
    ES = UInt16[DS, 0x5516];
    CheckExternalEvents(cs1, 0xD15D);
    // CMP byte ptr ES:[BX + 0x45de],0x0 (0000_D157 / 0xD157)
    Alu.Sub8(UInt8[ES, (ushort)(BX + 0x45DE)], 0x0);
    CheckExternalEvents(cs1, 0xD15F);
    // JNZ 0x0000:d162 (0000_D15D / 0xD15D)
    if(!ZeroFlag) {
      goto label_0000_D162_0D162;
    }
    CheckExternalEvents(cs1, 0xD162);
    // JMP 0x0000:d09c (0000_D15F / 0xD15F)
    goto label_0000_D09C_0D09C;
    label_0000_D162_0D162:
    CheckExternalEvents(cs1, 0xD165);
    // MOV AX,0x215d (0000_D162 / 0xD162)
    AX = 0x215D;
    CheckExternalEvents(cs1, 0xD166);
    // PUSH DS (0000_D165 / 0xD165)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD167);
    // PUSH AX (0000_D166 / 0xD166)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD16C);
    // CALLF 0x1000:7c1a (0000_D167 / 0xD167)
    FarCall(cs1, 0xD16C, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD16F);
    // ADD SP,0x4 (0000_D16C / 0xD16C)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD174);
    // CALLF 0x1000:8d29 (0000_D16F / 0xD16F)
    FarCall(cs1, 0xD174, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD176);
    // JMP 0x0000:d116 (0000_D174 / 0xD174)
    goto label_0000_D116_0D116;
    label_0000_D176_0D176:
    CheckExternalEvents(cs1, 0xD177);
    // POP SI (0000_D176 / 0xD176)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD179);
    // MOV SP,BP (0000_D177 / 0xD177)
    SP = BP;
    CheckExternalEvents(cs1, 0xD17A);
    // POP BP (0000_D179 / 0xD179)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD17B);
    // RETF  (0000_D17A / 0xD17A)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_D17B_0D17B(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D17B_0D17B:
    CheckExternalEvents(cs1, 0xD17C);
    // PUSH BP (0000_D17B / 0xD17B)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD17E);
    // MOV BP,SP (0000_D17C / 0xD17C)
    BP = SP;
    CheckExternalEvents(cs1, 0xD180);
    // XOR AX,AX (0000_D17E / 0xD17E)
    // AX ^= AX;
    AX = Alu.Xor16(AX, AX);
    CheckExternalEvents(cs1, 0xD185);
    // CALLF 0x1000:cecc (0000_D180 / 0xD180)
    FarCall(cs1, 0xD185, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD188);
    // MOV AX,word ptr [BP + 0x6] (0000_D185 / 0xD185)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD189);
    // INC AX (0000_D188 / 0xD188)
    AX++;
    CheckExternalEvents(cs1, 0xD18C);
    // AND AX,0x7e (0000_D189 / 0xD189)
    // AX &= 0x7E;
    AX = Alu.And16(AX, 0x7E);
    CheckExternalEvents(cs1, 0xD18F);
    // MOV word ptr [BP + 0x6],AX (0000_D18C / 0xD18C)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD193);
    // AND word ptr [BP + 0x8],0x7e (0000_D18F / 0xD18F)
    UInt16[SS, (ushort)(BP + 0x8)] &= 0x7E;
    CheckExternalEvents(cs1, 0xD197);
    // CMP word ptr [BP + 0x8],0x4 (0000_D193 / 0xD193)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x4);
    CheckExternalEvents(cs1, 0xD199);
    // JNZ 0x0000:d19e (0000_D197 / 0xD197)
    if(!ZeroFlag) {
      goto label_0000_D19E_0D19E;
    }
    CheckExternalEvents(cs1, 0xD19C);
    // CMP AX,0x4 (0000_D199 / 0xD199)
    Alu.Sub16(AX, 0x4);
    CheckExternalEvents(cs1, 0xD19E);
    // JZ 0x0000:d1ad (0000_D19C / 0xD19C)
    if(ZeroFlag) {
      goto label_0000_D1AD_0D1AD;
    }
    label_0000_D19E_0D19E:
    CheckExternalEvents(cs1, 0xD1A2);
    // CMP word ptr [BP + 0x6],0x2 (0000_D19E / 0xD19E)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x2);
    CheckExternalEvents(cs1, 0xD1A4);
    // JZ 0x0000:d1a7 (0000_D1A2 / 0xD1A2)
    if(ZeroFlag) {
      goto label_0000_D1A7_0D1A7;
    }
    CheckExternalEvents(cs1, 0xD1A7);
    // JMP 0x0000:d228 (0000_D1A4 / 0xD1A4)
    goto label_0000_D228_0D228;
    label_0000_D1A7_0D1A7:
    CheckExternalEvents(cs1, 0xD1AB);
    // CMP word ptr [BP + 0x8],0xe (0000_D1A7 / 0xD1A7)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0xE);
    CheckExternalEvents(cs1, 0xD1AD);
    // JNZ 0x0000:d228 (0000_D1AB / 0xD1AB)
    if(!ZeroFlag) {
      goto label_0000_D228_0D228;
    }
    label_0000_D1AD_0D1AD:
    CheckExternalEvents(cs1, 0xD1B1);
    // MOV ES,word ptr [0x54fa] (0000_D1AD / 0xD1AD)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD1B7);
    // CMP byte ptr ES:[0xd34c],0x0 (0000_D1B1 / 0xD1B1)
    Alu.Sub8(UInt8[ES, 0xD34C], 0x0);
    CheckExternalEvents(cs1, 0xD1B9);
    // JNZ 0x0000:d1c3 (0000_D1B7 / 0xD1B7)
    if(!ZeroFlag) {
      goto label_0000_D1C3_0D1C3;
    }
    CheckExternalEvents(cs1, 0xD1BE);
    // CALLF 0x1000:7bf6 (0000_D1B9 / 0xD1B9)
    FarCall(cs1, 0xD1BE, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD1C1);
    // MOV AX,0x2240 (0000_D1BE / 0xD1BE)
    AX = 0x2240;
    CheckExternalEvents(cs1, 0xD1C3);
    // JMP 0x0000:d20e (0000_D1C1 / 0xD1C1)
    goto label_0000_D20E_0D20E;
    label_0000_D1C3_0D1C3:
    CheckExternalEvents(cs1, 0xD1C7);
    // MOV ES,word ptr [0x54fa] (0000_D1C3 / 0xD1C3)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD1CD);
    // CMP byte ptr ES:[0xd34a],0x1 (0000_D1C7 / 0xD1C7)
    Alu.Sub8(UInt8[ES, 0xD34A], 0x1);
    CheckExternalEvents(cs1, 0xD1CF);
    // JZ 0x0000:d1d9 (0000_D1CD / 0xD1CD)
    if(ZeroFlag) {
      goto label_0000_D1D9_0D1D9;
    }
    CheckExternalEvents(cs1, 0xD1D4);
    // CALLF 0x1000:7bf6 (0000_D1CF / 0xD1CF)
    FarCall(cs1, 0xD1D4, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD1D7);
    // MOV AX,0x2275 (0000_D1D4 / 0xD1D4)
    AX = 0x2275;
    CheckExternalEvents(cs1, 0xD1D9);
    // JMP 0x0000:d20e (0000_D1D7 / 0xD1D7)
    goto label_0000_D20E_0D20E;
    label_0000_D1D9_0D1D9:
    CheckExternalEvents(cs1, 0xD1DD);
    // MOV ES,word ptr [0x54fa] (0000_D1D9 / 0xD1D9)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD1E3);
    // CMP byte ptr ES:[0xd34d],0x0 (0000_D1DD / 0xD1DD)
    Alu.Sub8(UInt8[ES, 0xD34D], 0x0);
    CheckExternalEvents(cs1, 0xD1E5);
    // JZ 0x0000:d206 (0000_D1E3 / 0xD1E3)
    if(ZeroFlag) {
      goto label_0000_D206_0D206;
    }
    CheckExternalEvents(cs1, 0xD1E8);
    // MOV AX,0x19 (0000_D1E5 / 0xD1E5)
    AX = 0x19;
    CheckExternalEvents(cs1, 0xD1E9);
    // PUSH AX (0000_D1E8 / 0xD1E8)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD1EE);
    // CALLF 0x0000:94c8 (0000_D1E9 / 0xD1E9)
    FarCall(cs1, 0xD1EE, unknown_094C_0008_094C8);
    CheckExternalEvents(cs1, 0xD1F1);
    // ADD SP,0x2 (0000_D1EE / 0xD1EE)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD1F5);
    // MOV ES,word ptr [0x550e] (0000_D1F1 / 0xD1F1)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD1F8);
    // MOV AX,0x1 (0000_D1F5 / 0xD1F5)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xD1FC);
    // MOV ES:[0xd55c],AX (0000_D1F8 / 0xD1F8)
    UInt16[ES, 0xD55C] = AX;
    CheckExternalEvents(cs1, 0xD200);
    // MOV ES,word ptr [0x5518] (0000_D1FC / 0xD1FC)
    ES = UInt16[DS, 0x5518];
    CheckExternalEvents(cs1, 0xD204);
    // MOV ES:[0x1a8],AX (0000_D200 / 0xD200)
    UInt16[ES, 0x1A8] = AX;
    CheckExternalEvents(cs1, 0xD206);
    // JMP 0x0000:d228 (0000_D204 / 0xD204)
    goto label_0000_D228_0D228;
    label_0000_D206_0D206:
    CheckExternalEvents(cs1, 0xD20B);
    // CALLF 0x1000:7bf6 (0000_D206 / 0xD206)
    FarCall(cs1, 0xD20B, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD20E);
    // MOV AX,0x228b (0000_D20B / 0xD20B)
    AX = 0x228B;
    label_0000_D20E_0D20E:
    CheckExternalEvents(cs1, 0xD20F);
    // PUSH DS (0000_D20E / 0xD20E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD210);
    // PUSH AX (0000_D20F / 0xD20F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD215);
    // CALLF 0x1000:7c1a (0000_D210 / 0xD210)
    FarCall(cs1, 0xD215, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD218);
    // ADD SP,0x4 (0000_D215 / 0xD215)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD21D);
    // CALLF 0x1000:8d29 (0000_D218 / 0xD218)
    FarCall(cs1, 0xD21D, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD221);
    // MOV ES,word ptr [0x550e] (0000_D21D / 0xD21D)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD228);
    // MOV word ptr ES:[0xd55c],0x1 (0000_D221 / 0xD221)
    UInt16[ES, 0xD55C] = 0x1;
    label_0000_D228_0D228:
    CheckExternalEvents(cs1, 0xD229);
    // POP BP (0000_D228 / 0xD228)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD22A);
    // RETF  (0000_D229 / 0xD229)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_D22A_0D22A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D22A_0D22A:
    CheckExternalEvents(cs1, 0xD22B);
    // PUSH BP (0000_D22A / 0xD22A)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD22D);
    // MOV BP,SP (0000_D22B / 0xD22B)
    BP = SP;
    CheckExternalEvents(cs1, 0xD230);
    // MOV AX,0x8 (0000_D22D / 0xD22D)
    AX = 0x8;
    CheckExternalEvents(cs1, 0xD235);
    // CALLF 0x1000:cecc (0000_D230 / 0xD230)
    FarCall(cs1, 0xD235, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD238);
    // MOV AX,word ptr [BP + 0x6] (0000_D235 / 0xD235)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD239);
    // INC AX (0000_D238 / 0xD238)
    AX++;
    CheckExternalEvents(cs1, 0xD23C);
    // AND AX,0x7e (0000_D239 / 0xD239)
    // AX &= 0x7E;
    AX = Alu.And16(AX, 0x7E);
    CheckExternalEvents(cs1, 0xD23F);
    // MOV word ptr [BP + 0x6],AX (0000_D23C / 0xD23C)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD243);
    // AND word ptr [BP + 0x8],0x7e (0000_D23F / 0xD23F)
    UInt16[SS, (ushort)(BP + 0x8)] &= 0x7E;
    CheckExternalEvents(cs1, 0xD246);
    // CMP AX,0x7c (0000_D243 / 0xD243)
    Alu.Sub16(AX, 0x7C);
    CheckExternalEvents(cs1, 0xD248);
    // JNZ 0x0000:d26d (0000_D246 / 0xD246)
    if(!ZeroFlag) {
      goto label_0000_D26D_0D26D;
    }
    CheckExternalEvents(cs1, 0xD24C);
    // CMP word ptr [BP + 0x8],0x4 (0000_D248 / 0xD248)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x4);
    CheckExternalEvents(cs1, 0xD24E);
    // JNZ 0x0000:d26d (0000_D24C / 0xD24C)
    if(!ZeroFlag) {
      goto label_0000_D26D_0D26D;
    }
    CheckExternalEvents(cs1, 0xD251);
    // MOV AX,0x18 (0000_D24E / 0xD24E)
    AX = 0x18;
    CheckExternalEvents(cs1, 0xD252);
    // PUSH AX (0000_D251 / 0xD251)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD257);
    // CALLF 0x0000:94c8 (0000_D252 / 0xD252)
    FarCall(cs1, 0xD257, unknown_094C_0008_094C8);
    CheckExternalEvents(cs1, 0xD25A);
    // ADD SP,0x2 (0000_D257 / 0xD257)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD25C);
    // MOV AL,0x1 (0000_D25A / 0xD25A)
    AL = 0x1;
    CheckExternalEvents(cs1, 0xD260);
    // MOV ES,word ptr [0x54fa] (0000_D25C / 0xD25C)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD264);
    // MOV ES:[0xd34d],AL (0000_D260 / 0xD260)
    UInt8[ES, 0xD34D] = AL;
    CheckExternalEvents(cs1, 0xD265);
    // CBW  (0000_D264 / 0xD264)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xD269);
    // MOV ES,word ptr [0x550e] (0000_D265 / 0xD265)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD26D);
    // MOV ES:[0xd55c],AX (0000_D269 / 0xD269)
    UInt16[ES, 0xD55C] = AX;
    label_0000_D26D_0D26D:
    CheckExternalEvents(cs1, 0xD271);
    // CMP word ptr [BP + 0x6],0x48 (0000_D26D / 0xD26D)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x6)], 0x48);
    CheckExternalEvents(cs1, 0xD273);
    // JZ 0x0000:d276 (0000_D271 / 0xD271)
    if(ZeroFlag) {
      goto label_0000_D276_0D276;
    }
    CheckExternalEvents(cs1, 0xD276);
    // JMP 0x0000:d468 (0000_D273 / 0xD273)
    goto label_0000_D468_0D468;
    label_0000_D276_0D276:
    CheckExternalEvents(cs1, 0xD27A);
    // CMP word ptr [BP + 0x8],0x38 (0000_D276 / 0xD276)
    Alu.Sub16(UInt16[SS, (ushort)(BP + 0x8)], 0x38);
    CheckExternalEvents(cs1, 0xD27C);
    // JZ 0x0000:d27f (0000_D27A / 0xD27A)
    if(ZeroFlag) {
      goto label_0000_D27F_0D27F;
    }
    CheckExternalEvents(cs1, 0xD27F);
    // JMP 0x0000:d468 (0000_D27C / 0xD27C)
    goto label_0000_D468_0D468;
    label_0000_D27F_0D27F:
    CheckExternalEvents(cs1, 0xD284);
    // CALLF 0x1000:7bf6 (0000_D27F / 0xD27F)
    FarCall(cs1, 0xD284, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD288);
    // MOV ES,word ptr [0x550e] (0000_D284 / 0xD284)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD28F);
    // MOV word ptr ES:[0xd55c],0x1 (0000_D288 / 0xD288)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs1, 0xD293);
    // MOV ES,word ptr [0x54fa] (0000_D28F / 0xD28F)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD299);
    // CMP byte ptr ES:[0xd34a],0x1 (0000_D293 / 0xD293)
    Alu.Sub8(UInt8[ES, 0xD34A], 0x1);
    CheckExternalEvents(cs1, 0xD29B);
    // JNZ 0x0000:d2b0 (0000_D299 / 0xD299)
    if(!ZeroFlag) {
      goto label_0000_D2B0_0D2B0;
    }
    CheckExternalEvents(cs1, 0xD29E);
    // MOV AX,0x22c7 (0000_D29B / 0xD29B)
    AX = 0x22C7;
    CheckExternalEvents(cs1, 0xD29F);
    // PUSH DS (0000_D29E / 0xD29E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD2A0);
    // PUSH AX (0000_D29F / 0xD29F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD2A5);
    // CALLF 0x1000:7c1a (0000_D2A0 / 0xD2A0)
    FarCall(cs1, 0xD2A5, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD2A8);
    // ADD SP,0x4 (0000_D2A5 / 0xD2A5)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD2AD);
    // CALLF 0x1000:8d29 (0000_D2A8 / 0xD2A8)
    FarCall(cs1, 0xD2AD, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD2B0);
    // JMP 0x0000:d468 (0000_D2AD / 0xD2AD)
    goto label_0000_D468_0D468;
    label_0000_D2B0_0D2B0:
    CheckExternalEvents(cs1, 0xD2B3);
    // MOV AX,0x22e8 (0000_D2B0 / 0xD2B0)
    AX = 0x22E8;
    CheckExternalEvents(cs1, 0xD2B4);
    // PUSH DS (0000_D2B3 / 0xD2B3)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD2B5);
    // PUSH AX (0000_D2B4 / 0xD2B4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD2BA);
    // CALLF 0x1000:7c1a (0000_D2B5 / 0xD2B5)
    FarCall(cs1, 0xD2BA, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD2BD);
    // ADD SP,0x4 (0000_D2BA / 0xD2BA)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD2C2);
    // CALLF 0x1000:8d29 (0000_D2BD / 0xD2BD)
    FarCall(cs1, 0xD2C2, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD2C7);
    // CALLF 0x1000:7fe8 (0000_D2C2 / 0xD2C2)
    FarCall(cs1, 0xD2C7, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xD2CA);
    // MOV AX,0x2328 (0000_D2C7 / 0xD2C7)
    AX = 0x2328;
    CheckExternalEvents(cs1, 0xD2CB);
    // PUSH DS (0000_D2CA / 0xD2CA)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD2CC);
    // PUSH AX (0000_D2CB / 0xD2CB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD2D1);
    // CALLF 0x1000:7c1a (0000_D2CC / 0xD2CC)
    FarCall(cs1, 0xD2D1, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD2D4);
    // ADD SP,0x4 (0000_D2D1 / 0xD2D1)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD2D9);
    // CALLF 0x1000:8d29 (0000_D2D4 / 0xD2D4)
    FarCall(cs1, 0xD2D9, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD2DD);
    // MOV ES,word ptr [0x551a] (0000_D2D9 / 0xD2D9)
    ES = UInt16[DS, 0x551A];
    CheckExternalEvents(cs1, 0xD2E4);
    // MOV word ptr ES:[0x15a],0x1 (0000_D2DD / 0xD2DD)
    UInt16[ES, 0x15A] = 0x1;
    CheckExternalEvents(cs1, 0xD2E8);
    // MOV ES,word ptr [0x54fe] (0000_D2E4 / 0xD2E4)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xD2EF);
    // MOV word ptr ES:[0xa44b],0xc04 (0000_D2E8 / 0xD2E8)
    UInt16[ES, 0xA44B] = 0xC04;
    CheckExternalEvents(cs1, 0xD2F3);
    // MOV ES,word ptr [0x5500] (0000_D2EF / 0xD2EF)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xD2FA);
    // MOV word ptr ES:[0xa44d],0xc022 (0000_D2F3 / 0xD2F3)
    UInt16[ES, 0xA44D] = 0xC022;
    CheckExternalEvents(cs1, 0xD2FD);
    // MOV AX,0x1d0 (0000_D2FA / 0xD2FA)
    AX = 0x1D0;
    CheckExternalEvents(cs1, 0xD300);
    // MOV DX,0x2958 (0000_D2FD / 0xD2FD)
    DX = 0x2958;
    CheckExternalEvents(cs1, 0xD301);
    // PUSH DX (0000_D300 / 0xD300)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD302);
    // PUSH AX (0000_D301 / 0xD301)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD307);
    // CALLF 0x1000:9fc1 (0000_D302 / 0xD302)
    FarCall(cs1, 0xD307, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs1, 0xD30A);
    // ADD SP,0x4 (0000_D307 / 0xD307)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD30D);
    // MOV AX,0x2 (0000_D30A / 0xD30A)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xD30E);
    // PUSH AX (0000_D30D / 0xD30D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD313);
    // CALLF 0x0000:3fcc (0000_D30E / 0xD30E)
    FarCall(cs1, 0xD313, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0xD316);
    // ADD SP,0x2 (0000_D313 / 0xD313)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD31B);
    // MOV word ptr [BP + -0x8],0x0 (0000_D316 / 0xD316)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0000_D31B_0D31B:
    CheckExternalEvents(cs1, 0xD31E);
    // MOV BX,word ptr [BP + -0x8] (0000_D31B / 0xD31B)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xD322);
    // MOV ES,word ptr [0x5502] (0000_D31E / 0xD31E)
    ES = UInt16[DS, 0x5502];
    CheckExternalEvents(cs1, 0xD328);
    // MOV byte ptr ES:[BX + 0x564],0xd1 (0000_D322 / 0xD322)
    UInt8[ES, (ushort)(BX + 0x564)] = 0xD1;
    CheckExternalEvents(cs1, 0xD32B);
    // INC word ptr [BP + -0x8] (0000_D328 / 0xD328)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs1, 0xD330);
    // CMP word ptr [BP + -0x8],0x240 (0000_D32B / 0xD32B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x240);
    CheckExternalEvents(cs1, 0xD332);
    // JL 0x0000:d31b (0000_D330 / 0xD330)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D31B_0D31B;
    }
    CheckExternalEvents(cs1, 0xD336);
    // MOV ES,word ptr [0x5506] (0000_D332 / 0xD332)
    ES = UInt16[DS, 0x5506];
    CheckExternalEvents(cs1, 0xD33D);
    // MOV word ptr ES:[0x4fbc],0x1 (0000_D336 / 0xD336)
    UInt16[ES, 0x4FBC] = 0x1;
    CheckExternalEvents(cs1, 0xD340);
    // MOV AX,0x244b (0000_D33D / 0xD33D)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xD343);
    // MOV DX,0x1ddc (0000_D340 / 0xD340)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xD344);
    // PUSH DX (0000_D343 / 0xD343)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD345);
    // PUSH AX (0000_D344 / 0xD344)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD348);
    // MOV AX,0x2355 (0000_D345 / 0xD345)
    AX = 0x2355;
    CheckExternalEvents(cs1, 0xD349);
    // PUSH DS (0000_D348 / 0xD348)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD34A);
    // PUSH AX (0000_D349 / 0xD349)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD34F);
    // CALLF 0x1000:910b (0000_D34A / 0xD34A)
    FarCall(cs1, 0xD34F, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs1, 0xD352);
    // ADD SP,0x8 (0000_D34F / 0xD34F)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xD355);
    // MOV AX,0x4614 (0000_D352 / 0xD352)
    AX = 0x4614;
    CheckExternalEvents(cs1, 0xD358);
    // MOV DX,0x2a02 (0000_D355 / 0xD355)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xD359);
    // PUSH DX (0000_D358 / 0xD358)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD35A);
    // PUSH AX (0000_D359 / 0xD359)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD35D);
    // MOV AX,0x244b (0000_D35A / 0xD35A)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xD360);
    // MOV DX,0x1ddc (0000_D35D / 0xD35D)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xD361);
    // PUSH DX (0000_D360 / 0xD360)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD362);
    // PUSH AX (0000_D361 / 0xD361)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD367);
    // CALLF 0x1000:8f6d (0000_D362 / 0xD362)
    FarCall(cs1, 0xD367, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs1, 0xD36A);
    // ADD SP,0x8 (0000_D367 / 0xD367)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xD36E);
    // MOV ES,word ptr [0x5508] (0000_D36A / 0xD36A)
    ES = UInt16[DS, 0x5508];
    CheckExternalEvents(cs1, 0xD374);
    // CMP word ptr ES:[0x4fba],0x2 (0000_D36E / 0xD36E)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0xD376);
    // JNZ 0x0000:d38a (0000_D374 / 0xD374)
    if(!ZeroFlag) {
      goto label_0000_D38A_0D38A;
    }
    CheckExternalEvents(cs1, 0xD379);
    // MOV AX,0xa400 (0000_D376 / 0xD376)
    AX = 0xA400;
    CheckExternalEvents(cs1, 0xD37A);
    // PUSH AX (0000_D379 / 0xD379)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD37D);
    // MOV AX,0x4614 (0000_D37A / 0xD37A)
    AX = 0x4614;
    CheckExternalEvents(cs1, 0xD380);
    // MOV DX,0x2a02 (0000_D37D / 0xD37D)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xD381);
    // PUSH DX (0000_D380 / 0xD380)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD382);
    // PUSH AX (0000_D381 / 0xD381)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD387);
    // CALLF 0x1000:a150 (0000_D382 / 0xD382)
    FarCall(cs1, 0xD387, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs1, 0xD38A);
    // ADD SP,0x6 (0000_D387 / 0xD387)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0000_D38A_0D38A:
    CheckExternalEvents(cs1, 0xD38F);
    // MOV word ptr [BP + -0x8],0x0 (0000_D38A / 0xD38A)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    label_0000_D38F_0D38F:
    CheckExternalEvents(cs1, 0xD392);
    // MOV BX,word ptr [BP + -0x8] (0000_D38F / 0xD38F)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xD396);
    // MOV ES,word ptr [0x550c] (0000_D392 / 0xD392)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD39B);
    // MOV AL,byte ptr ES:[BX + 0x101d] (0000_D396 / 0xD396)
    AL = UInt8[ES, (ushort)(BX + 0x101D)];
    CheckExternalEvents(cs1, 0xD39F);
    // MOV ES,word ptr [0x551c] (0000_D39B / 0xD39B)
    ES = UInt16[DS, 0x551C];
    CheckExternalEvents(cs1, 0xD3A4);
    // MOV byte ptr ES:[BX + 0x4614],AL (0000_D39F / 0xD39F)
    UInt8[ES, (ushort)(BX + 0x4614)] = AL;
    CheckExternalEvents(cs1, 0xD3A7);
    // INC word ptr [BP + -0x8] (0000_D3A4 / 0xD3A4)
    UInt16[SS, (ushort)(BP - 0x8)]++;
    CheckExternalEvents(cs1, 0xD3AC);
    // CMP word ptr [BP + -0x8],0x300 (0000_D3A7 / 0xD3A7)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x300);
    CheckExternalEvents(cs1, 0xD3AE);
    // JL 0x0000:d38f (0000_D3AC / 0xD3AC)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D38F_0D38F;
    }
    CheckExternalEvents(cs1, 0xD3B2);
    // MOV ES,word ptr [0x550a] (0000_D3AE / 0xD3AE)
    ES = UInt16[DS, 0x550A];
    CheckExternalEvents(cs1, 0xD3B9);
    // MOV word ptr ES:[0x3988],0x3 (0000_D3B2 / 0xD3B2)
    UInt16[ES, 0x3988] = 0x3;
    CheckExternalEvents(cs1, 0xD3BC);
    // MOV AX,0x300 (0000_D3B9 / 0xD3B9)
    AX = 0x300;
    CheckExternalEvents(cs1, 0xD3BD);
    // PUSH AX (0000_D3BC / 0xD3BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD3C0);
    // MOV AX,0x101d (0000_D3BD / 0xD3BD)
    AX = 0x101D;
    CheckExternalEvents(cs1, 0xD3C3);
    // MOV DX,0x1ddc (0000_D3C0 / 0xD3C0)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xD3C4);
    // PUSH DX (0000_D3C3 / 0xD3C3)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD3C5);
    // PUSH AX (0000_D3C4 / 0xD3C4)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD3C8);
    // MOV AX,0x235d (0000_D3C5 / 0xD3C5)
    AX = 0x235D;
    CheckExternalEvents(cs1, 0xD3C9);
    // PUSH DS (0000_D3C8 / 0xD3C8)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD3CA);
    // PUSH AX (0000_D3C9 / 0xD3C9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD3CF);
    // CALLF 0x1000:92e4 (0000_D3CA / 0xD3CA)
    FarCall(cs1, 0xD3CF, unknown_18AD_0814_192E4);
    CheckExternalEvents(cs1, 0xD3D2);
    // ADD SP,0xa (0000_D3CF / 0xD3CF)
    // SP += 0xA;
    SP = Alu.Add16(SP, 0xA);
    CheckExternalEvents(cs1, 0xD3D6);
    // MOV ES,word ptr [0x54fa] (0000_D3D2 / 0xD3D2)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD3DC);
    // MOV byte ptr ES:[0xd34e],0x1 (0000_D3D6 / 0xD3D6)
    UInt8[ES, 0xD34E] = 0x1;
    CheckExternalEvents(cs1, 0xD3E1);
    // MOV word ptr [BP + -0x2],0x90 (0000_D3DC / 0xD3DC)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x90;
    CheckExternalEvents(cs1, 0xD3E6);
    // MOV word ptr [BP + -0x6],0x0 (0000_D3E1 / 0xD3E1)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    CheckExternalEvents(cs1, 0xD3E8);
    // JMP 0x0000:d40f (0000_D3E6 / 0xD3E6)
    goto label_0000_D40F_0D40F;
    label_0000_D3E8_0D3E8:
    CheckExternalEvents(cs1, 0xD3EB);
    // INC word ptr [BP + -0x4] (0000_D3E8 / 0xD3E8)
    UInt16[SS, (ushort)(BP - 0x4)]++;
    label_0000_D3EB_0D3EB:
    CheckExternalEvents(cs1, 0xD3EF);
    // CMP word ptr [BP + -0x4],0x4 (0000_D3EB / 0xD3EB)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x4)], 0x4);
    CheckExternalEvents(cs1, 0xD3F1);
    // JGE 0x0000:d40c (0000_D3EF / 0xD3EF)
    if(SignFlag == OverflowFlag) {
      goto label_0000_D40C_0D40C;
    }
    CheckExternalEvents(cs1, 0xD3F4);
    // MOV AX,word ptr [BP + -0x2] (0000_D3F1 / 0xD3F1)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD3F7);
    // INC word ptr [BP + -0x2] (0000_D3F4 / 0xD3F4)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu.Inc16(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0xD3FA);
    // MOV BX,word ptr [BP + -0x6] (0000_D3F7 / 0xD3F7)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xD3FC);
    // MOV CL,0x3 (0000_D3FA / 0xD3FA)
    CL = 0x3;
    CheckExternalEvents(cs1, 0xD3FE);
    // SHL BX,CL (0000_D3FC / 0xD3FC)
    BX <<= CL;
    CheckExternalEvents(cs1, 0xD401);
    // ADD BX,word ptr [BP + -0x4] (0000_D3FE / 0xD3FE)
    // BX += UInt16[SS, (ushort)(BP - 0x4)];
    BX = Alu.Add16(BX, UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs1, 0xD405);
    // MOV ES,word ptr [0x551e] (0000_D401 / 0xD401)
    ES = UInt16[DS, 0x551E];
    CheckExternalEvents(cs1, 0xD40A);
    // MOV byte ptr ES:[BX + 0x664],AL (0000_D405 / 0xD405)
    UInt8[ES, (ushort)(BX + 0x664)] = AL;
    CheckExternalEvents(cs1, 0xD40C);
    // JMP 0x0000:d3e8 (0000_D40A / 0xD40A)
    goto label_0000_D3E8_0D3E8;
    label_0000_D40C_0D40C:
    CheckExternalEvents(cs1, 0xD40F);
    // INC word ptr [BP + -0x6] (0000_D40C / 0xD40C)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    label_0000_D40F_0D40F:
    CheckExternalEvents(cs1, 0xD413);
    // CMP word ptr [BP + -0x6],0x3 (0000_D40F / 0xD40F)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x3);
    CheckExternalEvents(cs1, 0xD415);
    // JGE 0x0000:d41c (0000_D413 / 0xD413)
    if(SignFlag == OverflowFlag) {
      goto label_0000_D41C_0D41C;
    }
    CheckExternalEvents(cs1, 0xD41A);
    // MOV word ptr [BP + -0x4],0x0 (0000_D415 / 0xD415)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x0;
    CheckExternalEvents(cs1, 0xD41C);
    // JMP 0x0000:d3eb (0000_D41A / 0xD41A)
    goto label_0000_D3EB_0D3EB;
    label_0000_D41C_0D41C:
    CheckExternalEvents(cs1, 0xD421);
    // CALLF 0x1000:bc98 (0000_D41C / 0xD41C)
    FarCall(cs1, 0xD421, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs1, 0xD425);
    // MOV ES,word ptr [0x5500] (0000_D421 / 0xD421)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xD42A);
    // PUSH word ptr ES:[0xa44d] (0000_D425 / 0xD425)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0xD42E);
    // MOV ES,word ptr [0x54fe] (0000_D42A / 0xD42A)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xD433);
    // PUSH word ptr ES:[0xa44b] (0000_D42E / 0xD42E)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xD438);
    // CALLF 0x1000:b204 (0000_D433 / 0xD433)
    FarCall(cs1, 0xD438, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0xD43B);
    // ADD SP,0x4 (0000_D438 / 0xD438)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD440);
    // CALLF 0x1000:b7df (0000_D43B / 0xD43B)
    FarCall(cs1, 0xD440, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0xD444);
    // MOV ES,word ptr [0x5508] (0000_D440 / 0xD440)
    ES = UInt16[DS, 0x5508];
    CheckExternalEvents(cs1, 0xD44A);
    // CMP word ptr ES:[0x4fba],0x0 (0000_D444 / 0xD444)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0xD44C);
    // JNZ 0x0000:d458 (0000_D44A / 0xD44A)
    if(!ZeroFlag) {
      goto label_0000_D458_0D458;
    }
    CheckExternalEvents(cs1, 0xD44F);
    // MOV AX,0x1 (0000_D44C / 0xD44C)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xD450);
    // PUSH AX (0000_D44F / 0xD44F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD455);
    // CALLF 0x1000:aa97 (0000_D450 / 0xD450)
    FarCall(cs1, 0xD455, ghidra_guess_1000_AA97_1AA97);
    CheckExternalEvents(cs1, 0xD458);
    // ADD SP,0x2 (0000_D455 / 0xD455)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0000_D458_0D458:
    CheckExternalEvents(cs1, 0xD45D);
    // CALLF 0x1000:9193 (0000_D458 / 0xD458)
    FarCall(cs1, 0xD45D, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0xD461);
    // MOV ES,word ptr [0x5520] (0000_D45D / 0xD45D)
    ES = UInt16[DS, 0x5520];
    CheckExternalEvents(cs1, 0xD468);
    // MOV word ptr ES:[0x150],0x8b (0000_D461 / 0xD461)
    UInt16[ES, 0x150] = 0x8B;
    label_0000_D468_0D468:
    CheckExternalEvents(cs1, 0xD46A);
    // MOV SP,BP (0000_D468 / 0xD468)
    SP = BP;
    CheckExternalEvents(cs1, 0xD46B);
    // POP BP (0000_D46A / 0xD46A)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD46C);
    // RETF  (0000_D46B / 0xD46B)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_D46C_0D46C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D46C_0D46C:
    CheckExternalEvents(cs1, 0xD46D);
    // PUSH BP (0000_D46C / 0xD46C)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD46F);
    // MOV BP,SP (0000_D46D / 0xD46D)
    BP = SP;
    CheckExternalEvents(cs1, 0xD472);
    // MOV AX,0x2 (0000_D46F / 0xD46F)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xD477);
    // CALLF 0x1000:cecc (0000_D472 / 0xD472)
    FarCall(cs1, 0xD477, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD47C);
    // CALLF 0x1000:7bf6 (0000_D477 / 0xD477)
    FarCall(cs1, 0xD47C, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD47F);
    // MOV AX,0x2367 (0000_D47C / 0xD47C)
    AX = 0x2367;
    CheckExternalEvents(cs1, 0xD480);
    // PUSH DS (0000_D47F / 0xD47F)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD481);
    // PUSH AX (0000_D480 / 0xD480)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD486);
    // CALLF 0x1000:7c1a (0000_D481 / 0xD481)
    FarCall(cs1, 0xD486, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD489);
    // ADD SP,0x4 (0000_D486 / 0xD486)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD48E);
    // CALLF 0x1000:8d29 (0000_D489 / 0xD489)
    FarCall(cs1, 0xD48E, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD492);
    // MOV ES,word ptr [0x54fe] (0000_D48E / 0xD48E)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xD499);
    // MOV word ptr ES:[0xa44b],0xc45 (0000_D492 / 0xD492)
    UInt16[ES, 0xA44B] = 0xC45;
    CheckExternalEvents(cs1, 0xD49D);
    // MOV ES,word ptr [0x5500] (0000_D499 / 0xD499)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xD4A4);
    // MOV word ptr ES:[0xa44d],0xc039 (0000_D49D / 0xD49D)
    UInt16[ES, 0xA44D] = 0xC039;
    CheckExternalEvents(cs1, 0xD4A7);
    // MOV AX,0x1b0 (0000_D4A4 / 0xD4A4)
    AX = 0x1B0;
    CheckExternalEvents(cs1, 0xD4AA);
    // MOV DX,0x2958 (0000_D4A7 / 0xD4A7)
    DX = 0x2958;
    CheckExternalEvents(cs1, 0xD4AB);
    // PUSH DX (0000_D4AA / 0xD4AA)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD4AC);
    // PUSH AX (0000_D4AB / 0xD4AB)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD4B1);
    // CALLF 0x1000:9fc1 (0000_D4AC / 0xD4AC)
    FarCall(cs1, 0xD4B1, unknown_19EF_00D1_19FC1);
    CheckExternalEvents(cs1, 0xD4B4);
    // ADD SP,0x4 (0000_D4B1 / 0xD4B1)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD4B7);
    // MOV AX,0x2 (0000_D4B4 / 0xD4B4)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xD4B8);
    // PUSH AX (0000_D4B7 / 0xD4B7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD4BD);
    // CALLF 0x0000:3fcc (0000_D4B8 / 0xD4B8)
    FarCall(cs1, 0xD4BD, unknown_0170_28CC_03FCC);
    CheckExternalEvents(cs1, 0xD4C0);
    // ADD SP,0x2 (0000_D4BD / 0xD4BD)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD4C5);
    // MOV word ptr [BP + -0x2],0x0 (0000_D4C0 / 0xD4C0)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_D4C5_0D4C5:
    CheckExternalEvents(cs1, 0xD4C8);
    // MOV BX,word ptr [BP + -0x2] (0000_D4C5 / 0xD4C5)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD4CC);
    // MOV ES,word ptr [0x5502] (0000_D4C8 / 0xD4C8)
    ES = UInt16[DS, 0x5502];
    CheckExternalEvents(cs1, 0xD4D2);
    // MOV byte ptr ES:[BX + 0x564],0xd0 (0000_D4CC / 0xD4CC)
    UInt8[ES, (ushort)(BX + 0x564)] = 0xD0;
    CheckExternalEvents(cs1, 0xD4D5);
    // INC word ptr [BP + -0x2] (0000_D4D2 / 0xD4D2)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xD4DA);
    // CMP word ptr [BP + -0x2],0x240 (0000_D4D5 / 0xD4D5)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x240);
    CheckExternalEvents(cs1, 0xD4DC);
    // JL 0x0000:d4c5 (0000_D4DA / 0xD4DA)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D4C5_0D4C5;
    }
    CheckExternalEvents(cs1, 0xD4E1);
    // MOV word ptr [BP + -0x2],0x0 (0000_D4DC / 0xD4DC)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_D4E1_0D4E1:
    CheckExternalEvents(cs1, 0xD4E4);
    // MOV BX,word ptr [BP + -0x2] (0000_D4E1 / 0xD4E1)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD4E8);
    // MOV ES,word ptr [0x551c] (0000_D4E4 / 0xD4E4)
    ES = UInt16[DS, 0x551C];
    CheckExternalEvents(cs1, 0xD4ED);
    // MOV AL,byte ptr ES:[BX + 0x4614] (0000_D4E8 / 0xD4E8)
    AL = UInt8[ES, (ushort)(BX + 0x4614)];
    CheckExternalEvents(cs1, 0xD4F1);
    // MOV ES,word ptr [0x550c] (0000_D4ED / 0xD4ED)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD4F6);
    // MOV byte ptr ES:[BX + 0x101d],AL (0000_D4F1 / 0xD4F1)
    UInt8[ES, (ushort)(BX + 0x101D)] = AL;
    CheckExternalEvents(cs1, 0xD4F9);
    // INC word ptr [BP + -0x2] (0000_D4F6 / 0xD4F6)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xD4FE);
    // CMP word ptr [BP + -0x2],0x300 (0000_D4F9 / 0xD4F9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x300);
    CheckExternalEvents(cs1, 0xD500);
    // JL 0x0000:d4e1 (0000_D4FE / 0xD4FE)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D4E1_0D4E1;
    }
    CheckExternalEvents(cs1, 0xD504);
    // MOV ES,word ptr [0x5506] (0000_D500 / 0xD500)
    ES = UInt16[DS, 0x5506];
    CheckExternalEvents(cs1, 0xD507);
    // MOV AX,0x1 (0000_D504 / 0xD504)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xD50B);
    // MOV ES:[0x4fbc],AX (0000_D507 / 0xD507)
    UInt16[ES, 0x4FBC] = AX;
    CheckExternalEvents(cs1, 0xD50F);
    // MOV ES,word ptr [0x550e] (0000_D50B / 0xD50B)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD513);
    // MOV ES:[0xd55c],AX (0000_D50F / 0xD50F)
    UInt16[ES, 0xD55C] = AX;
    CheckExternalEvents(cs1, 0xD516);
    // MOV AX,0x244b (0000_D513 / 0xD513)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xD519);
    // MOV DX,0x1ddc (0000_D516 / 0xD516)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xD51A);
    // PUSH DX (0000_D519 / 0xD519)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD51B);
    // PUSH AX (0000_D51A / 0xD51A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD51E);
    // MOV AX,0x23a5 (0000_D51B / 0xD51B)
    AX = 0x23A5;
    CheckExternalEvents(cs1, 0xD51F);
    // PUSH DS (0000_D51E / 0xD51E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD520);
    // PUSH AX (0000_D51F / 0xD51F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD525);
    // CALLF 0x1000:910b (0000_D520 / 0xD520)
    FarCall(cs1, 0xD525, unknown_18AD_063B_1910B);
    CheckExternalEvents(cs1, 0xD528);
    // ADD SP,0x8 (0000_D525 / 0xD525)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xD52B);
    // MOV AX,0x4614 (0000_D528 / 0xD528)
    AX = 0x4614;
    CheckExternalEvents(cs1, 0xD52E);
    // MOV DX,0x2a02 (0000_D52B / 0xD52B)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xD52F);
    // PUSH DX (0000_D52E / 0xD52E)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD530);
    // PUSH AX (0000_D52F / 0xD52F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD533);
    // MOV AX,0x244b (0000_D530 / 0xD530)
    AX = 0x244B;
    CheckExternalEvents(cs1, 0xD536);
    // MOV DX,0x1ddc (0000_D533 / 0xD533)
    DX = 0x1DDC;
    CheckExternalEvents(cs1, 0xD537);
    // PUSH DX (0000_D536 / 0xD536)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD538);
    // PUSH AX (0000_D537 / 0xD537)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD53D);
    // CALLF 0x1000:8f6d (0000_D538 / 0xD538)
    FarCall(cs1, 0xD53D, unknown_18AD_049D_18F6D);
    CheckExternalEvents(cs1, 0xD540);
    // ADD SP,0x8 (0000_D53D / 0xD53D)
    // SP += 0x8;
    SP = Alu.Add16(SP, 0x8);
    CheckExternalEvents(cs1, 0xD544);
    // MOV ES,word ptr [0x5508] (0000_D540 / 0xD540)
    ES = UInt16[DS, 0x5508];
    CheckExternalEvents(cs1, 0xD54A);
    // CMP word ptr ES:[0x4fba],0x2 (0000_D544 / 0xD544)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x2);
    CheckExternalEvents(cs1, 0xD54C);
    // JNZ 0x0000:d560 (0000_D54A / 0xD54A)
    if(!ZeroFlag) {
      goto label_0000_D560_0D560;
    }
    CheckExternalEvents(cs1, 0xD54F);
    // MOV AX,0xa400 (0000_D54C / 0xD54C)
    AX = 0xA400;
    CheckExternalEvents(cs1, 0xD550);
    // PUSH AX (0000_D54F / 0xD54F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD553);
    // MOV AX,0x4614 (0000_D550 / 0xD550)
    AX = 0x4614;
    CheckExternalEvents(cs1, 0xD556);
    // MOV DX,0x2a02 (0000_D553 / 0xD553)
    DX = 0x2A02;
    CheckExternalEvents(cs1, 0xD557);
    // PUSH DX (0000_D556 / 0xD556)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0xD558);
    // PUSH AX (0000_D557 / 0xD557)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD55D);
    // CALLF 0x1000:a150 (0000_D558 / 0xD558)
    FarCall(cs1, 0xD55D, ghidra_guess_1000_A150_1A150);
    CheckExternalEvents(cs1, 0xD560);
    // ADD SP,0x6 (0000_D55D / 0xD55D)
    // SP += 0x6;
    SP = Alu.Add16(SP, 0x6);
    label_0000_D560_0D560:
    CheckExternalEvents(cs1, 0xD564);
    // MOV ES,word ptr [0x550a] (0000_D560 / 0xD560)
    ES = UInt16[DS, 0x550A];
    CheckExternalEvents(cs1, 0xD56B);
    // MOV word ptr ES:[0x3988],0x2 (0000_D564 / 0xD564)
    UInt16[ES, 0x3988] = 0x2;
    CheckExternalEvents(cs1, 0xD570);
    // MOV word ptr [BP + -0x2],0x0 (0000_D56B / 0xD56B)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_D570_0D570:
    CheckExternalEvents(cs1, 0xD573);
    // MOV AL,byte ptr [BP + -0x2] (0000_D570 / 0xD570)
    AL = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD575);
    // SUB AL,0x70 (0000_D573 / 0xD573)
    // AL -= 0x70;
    AL = Alu.Sub8(AL, 0x70);
    CheckExternalEvents(cs1, 0xD578);
    // MOV BX,word ptr [BP + -0x2] (0000_D575 / 0xD575)
    BX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD57C);
    // MOV ES,word ptr [0x551e] (0000_D578 / 0xD578)
    ES = UInt16[DS, 0x551E];
    CheckExternalEvents(cs1, 0xD581);
    // MOV byte ptr ES:[BX + 0x664],AL (0000_D57C / 0xD57C)
    UInt8[ES, (ushort)(BX + 0x664)] = AL;
    CheckExternalEvents(cs1, 0xD584);
    // INC word ptr [BP + -0x2] (0000_D581 / 0xD581)
    UInt16[SS, (ushort)(BP - 0x2)]++;
    CheckExternalEvents(cs1, 0xD588);
    // CMP word ptr [BP + -0x2],0x40 (0000_D584 / 0xD584)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x40);
    CheckExternalEvents(cs1, 0xD58A);
    // JL 0x0000:d570 (0000_D588 / 0xD588)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D570_0D570;
    }
    CheckExternalEvents(cs1, 0xD58F);
    // CALLF 0x1000:bc98 (0000_D58A / 0xD58A)
    FarCall(cs1, 0xD58F, unknown_19EF_1DA8_1BC98);
    CheckExternalEvents(cs1, 0xD593);
    // MOV ES,word ptr [0x5500] (0000_D58F / 0xD58F)
    ES = UInt16[DS, 0x5500];
    CheckExternalEvents(cs1, 0xD598);
    // PUSH word ptr ES:[0xa44d] (0000_D593 / 0xD593)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs1, 0xD59C);
    // MOV ES,word ptr [0x54fe] (0000_D598 / 0xD598)
    ES = UInt16[DS, 0x54FE];
    CheckExternalEvents(cs1, 0xD5A1);
    // PUSH word ptr ES:[0xa44b] (0000_D59C / 0xD59C)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xD5A6);
    // CALLF 0x1000:b204 (0000_D5A1 / 0xD5A1)
    FarCall(cs1, 0xD5A6, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs1, 0xD5A9);
    // ADD SP,0x4 (0000_D5A6 / 0xD5A6)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD5AE);
    // CALLF 0x1000:b7df (0000_D5A9 / 0xD5A9)
    FarCall(cs1, 0xD5AE, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0xD5B2);
    // MOV ES,word ptr [0x5508] (0000_D5AE / 0xD5AE)
    ES = UInt16[DS, 0x5508];
    CheckExternalEvents(cs1, 0xD5B8);
    // CMP word ptr ES:[0x4fba],0x0 (0000_D5B2 / 0xD5B2)
    Alu.Sub16(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs1, 0xD5BA);
    // JNZ 0x0000:d5c5 (0000_D5B8 / 0xD5B8)
    if(!ZeroFlag) {
      goto label_0000_D5C5_0D5C5;
    }
    CheckExternalEvents(cs1, 0xD5BC);
    // SUB AX,AX (0000_D5BA / 0xD5BA)
    // AX -= AX;
    AX = Alu.Sub16(AX, AX);
    CheckExternalEvents(cs1, 0xD5BD);
    // PUSH AX (0000_D5BC / 0xD5BC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD5C2);
    // CALLF 0x1000:aa97 (0000_D5BD / 0xD5BD)
    FarCall(cs1, 0xD5C2, ghidra_guess_1000_AA97_1AA97);
    CheckExternalEvents(cs1, 0xD5C5);
    // ADD SP,0x2 (0000_D5C2 / 0xD5C2)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    label_0000_D5C5_0D5C5:
    CheckExternalEvents(cs1, 0xD5CA);
    // CALLF 0x1000:9193 (0000_D5C5 / 0xD5C5)
    FarCall(cs1, 0xD5CA, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0xD5CE);
    // MOV ES,word ptr [0x54fa] (0000_D5CA / 0xD5CA)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD5D4);
    // MOV byte ptr ES:[0xd34e],0x0 (0000_D5CE / 0xD5CE)
    UInt8[ES, 0xD34E] = 0x0;
    CheckExternalEvents(cs1, 0xD5D8);
    // MOV ES,word ptr [0x5520] (0000_D5D4 / 0xD5D4)
    ES = UInt16[DS, 0x5520];
    CheckExternalEvents(cs1, 0xD5DF);
    // MOV word ptr ES:[0x150],0x21 (0000_D5D8 / 0xD5D8)
    UInt16[ES, 0x150] = 0x21;
    CheckExternalEvents(cs1, 0xD5E1);
    // MOV SP,BP (0000_D5DF / 0xD5DF)
    SP = BP;
    CheckExternalEvents(cs1, 0xD5E2);
    // POP BP (0000_D5E1 / 0xD5E1)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD5E3);
    // RETF  (0000_D5E2 / 0xD5E2)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_D5E3_0D5E3(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D5E3_0D5E3:
    CheckExternalEvents(cs1, 0xD5E4);
    // PUSH BP (0000_D5E3 / 0xD5E3)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD5E6);
    // MOV BP,SP (0000_D5E4 / 0xD5E4)
    BP = SP;
    CheckExternalEvents(cs1, 0xD5E9);
    // MOV AX,0x2 (0000_D5E6 / 0xD5E6)
    AX = 0x2;
    CheckExternalEvents(cs1, 0xD5EE);
    // CALLF 0x1000:cecc (0000_D5E9 / 0xD5E9)
    FarCall(cs1, 0xD5EE, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD5F1);
    // MOV AX,word ptr [BP + 0x6] (0000_D5EE / 0xD5EE)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD5F2);
    // INC AX (0000_D5F1 / 0xD5F1)
    AX++;
    CheckExternalEvents(cs1, 0xD5F5);
    // AND AX,0x7f (0000_D5F2 / 0xD5F2)
    // AX &= 0x7F;
    AX = Alu.And16(AX, 0x7F);
    CheckExternalEvents(cs1, 0xD5F8);
    // MOV word ptr [BP + 0x6],AX (0000_D5F5 / 0xD5F5)
    UInt16[SS, (ushort)(BP + 0x6)] = AX;
    CheckExternalEvents(cs1, 0xD5FB);
    // MOV AX,word ptr [BP + 0x8] (0000_D5F8 / 0xD5F8)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xD5FE);
    // AND AX,0x70 (0000_D5FB / 0xD5FB)
    // AX &= 0x70;
    AX = Alu.And16(AX, 0x70);
    CheckExternalEvents(cs1, 0xD600);
    // MOV CL,0x4 (0000_D5FE / 0xD5FE)
    CL = 0x4;
    CheckExternalEvents(cs1, 0xD602);
    // SHL AX,CL (0000_D600 / 0xD600)
    // AX <<= CL;
    AX = Alu.Shl16(AX, CL);
    CheckExternalEvents(cs1, 0xD605);
    // MOV CX,word ptr [BP + 0x8] (0000_D602 / 0xD602)
    CX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xD608);
    // AND CX,0xe (0000_D605 / 0xD605)
    CX &= 0xE;
    CheckExternalEvents(cs1, 0xD60A);
    // SHL CX,0x1 (0000_D608 / 0xD608)
    CX <<= 0x1;
    CheckExternalEvents(cs1, 0xD60C);
    // SHL CX,0x1 (0000_D60A / 0xD60A)
    CX <<= 0x1;
    CheckExternalEvents(cs1, 0xD60E);
    // ADD AX,CX (0000_D60C / 0xD60C)
    // AX += CX;
    AX = Alu.Add16(AX, CX);
    CheckExternalEvents(cs1, 0xD611);
    // MOV word ptr [BP + 0x8],AX (0000_D60E / 0xD60E)
    UInt16[SS, (ushort)(BP + 0x8)] = AX;
    CheckExternalEvents(cs1, 0xD614);
    // MOV AX,word ptr [BP + 0x6] (0000_D611 / 0xD611)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD616);
    // SAR AX,0x1 (0000_D614 / 0xD614)
    AX = Alu.Sar16(AX, 0x1);
    CheckExternalEvents(cs1, 0xD619);
    // AND AX,0x7 (0000_D616 / 0xD616)
    // AX &= 0x7;
    AX = Alu.And16(AX, 0x7);
    CheckExternalEvents(cs1, 0xD61C);
    // MOV word ptr [BP + -0x2],AX (0000_D619 / 0xD619)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xD61F);
    // MOV AX,word ptr [BP + 0x6] (0000_D61C / 0xD61C)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xD622);
    // AND AX,0x70 (0000_D61F / 0xD61F)
    AX &= 0x70;
    CheckExternalEvents(cs1, 0xD624);
    // SHL AX,0x1 (0000_D622 / 0xD622)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0xD626);
    // SHL AX,0x1 (0000_D624 / 0xD624)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0xD629);
    // ADD AX,word ptr [BP + -0x2] (0000_D626 / 0xD626)
    AX += UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs1, 0xD62C);
    // ADD word ptr [BP + 0x8],AX (0000_D629 / 0xD629)
    // UInt16[SS, (ushort)(BP + 0x8)] += AX;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu.Add16(UInt16[SS, (ushort)(BP + 0x8)], AX);
    CheckExternalEvents(cs1, 0xD62F);
    // MOV BX,word ptr [BP + 0x8] (0000_D62C / 0xD62C)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xD633);
    // MOV ES,word ptr [0x550c] (0000_D62F / 0xD62F)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD638);
    // MOV AL,byte ptr ES:[BX + 0x101d] (0000_D633 / 0xD633)
    AL = UInt8[ES, (ushort)(BX + 0x101D)];
    CheckExternalEvents(cs1, 0xD63A);
    // INC AL (0000_D638 / 0xD638)
    AL++;
    CheckExternalEvents(cs1, 0xD63C);
    // XOR AL,0x1 (0000_D63A / 0xD63A)
    AL ^= 0x1;
    CheckExternalEvents(cs1, 0xD63E);
    // DEC AL (0000_D63C / 0xD63C)
    AL = Alu.Dec8(AL);
    CheckExternalEvents(cs1, 0xD643);
    // MOV byte ptr ES:[BX + 0x101d],AL (0000_D63E / 0xD63E)
    UInt8[ES, (ushort)(BX + 0x101D)] = AL;
    CheckExternalEvents(cs1, 0xD646);
    // MOV AX,0xf (0000_D643 / 0xD643)
    AX = 0xF;
    CheckExternalEvents(cs1, 0xD647);
    // PUSH AX (0000_D646 / 0xD646)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD64C);
    // CALLF 0x0000:30bf (0000_D647 / 0xD647)
    FarCall(cs1, 0xD64C, ghidra_guess_0000_30BF_030BF);
    CheckExternalEvents(cs1, 0xD64E);
    // MOV SP,BP (0000_D64C / 0xD64C)
    SP = BP;
    CheckExternalEvents(cs1, 0xD64F);
    // POP BP (0000_D64E / 0xD64E)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD650);
    // RETF  (0000_D64F / 0xD64F)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_D650_0D650(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_D650_0D650:
    CheckExternalEvents(cs1, 0xD651);
    // PUSH BP (0000_D650 / 0xD650)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xD653);
    // MOV BP,SP (0000_D651 / 0xD651)
    BP = SP;
    CheckExternalEvents(cs1, 0xD656);
    // MOV AX,0xa (0000_D653 / 0xD653)
    AX = 0xA;
    CheckExternalEvents(cs1, 0xD65B);
    // CALLF 0x1000:cecc (0000_D656 / 0xD656)
    FarCall(cs1, 0xD65B, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xD660);
    // MOV word ptr [BP + -0x2],0x1 (0000_D65B / 0xD65B)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x1;
    CheckExternalEvents(cs1, 0xD665);
    // MOV word ptr [BP + -0x6],0x0 (0000_D660 / 0xD660)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_D665_0D665:
    CheckExternalEvents(cs1, 0xD668);
    // MOV BX,word ptr [BP + -0x6] (0000_D665 / 0xD665)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xD66A);
    // SHL BX,0x1 (0000_D668 / 0xD668)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xD66E);
    // MOV BX,word ptr [BX + 0x241e] (0000_D66A / 0xD66A)
    BX = UInt16[DS, (ushort)(BX + 0x241E)];
    CheckExternalEvents(cs1, 0xD672);
    // MOV ES,word ptr [0x550c] (0000_D66E / 0xD66E)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD678);
    // TEST byte ptr ES:[BX + 0x101d],0x1 (0000_D672 / 0xD672)
    Alu.And8(UInt8[ES, (ushort)(BX + 0x101D)], 0x1);
    CheckExternalEvents(cs1, 0xD67A);
    // JZ 0x0000:d67f (0000_D678 / 0xD678)
    if(ZeroFlag) {
      goto label_0000_D67F_0D67F;
    }
    CheckExternalEvents(cs1, 0xD67F);
    // MOV word ptr [BP + -0x2],0x0 (0000_D67A / 0xD67A)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_D67F_0D67F:
    CheckExternalEvents(cs1, 0xD682);
    // INC word ptr [BP + -0x6] (0000_D67F / 0xD67F)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0xD686);
    // CMP word ptr [BP + -0x6],0x7 (0000_D682 / 0xD682)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x7);
    CheckExternalEvents(cs1, 0xD688);
    // JL 0x0000:d665 (0000_D686 / 0xD686)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D665_0D665;
    }
    CheckExternalEvents(cs1, 0xD68C);
    // CMP word ptr [BP + -0x2],0x0 (0000_D688 / 0xD688)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0xD68E);
    // JZ 0x0000:d6f4 (0000_D68C / 0xD68C)
    if(ZeroFlag) {
      goto label_0000_D6F4_0D6F4;
    }
    CheckExternalEvents(cs1, 0xD693);
    // MOV word ptr [BP + -0x6],0x0 (0000_D68E / 0xD68E)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_D693_0D693:
    CheckExternalEvents(cs1, 0xD696);
    // MOV BX,word ptr [BP + -0x6] (0000_D693 / 0xD693)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xD69A);
    // MOV ES,word ptr [0x550c] (0000_D696 / 0xD696)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD69F);
    // MOV AL,byte ptr ES:[BX + 0x101d] (0000_D69A / 0xD69A)
    AL = UInt8[ES, (ushort)(BX + 0x101D)];
    CheckExternalEvents(cs1, 0xD6A1);
    // SUB AH,AH (0000_D69F / 0xD69F)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0xD6A4);
    // MOV word ptr [BP + -0x4],AX (0000_D6A1 / 0xD6A1)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0xD6A7);
    // CMP AX,0x97 (0000_D6A4 / 0xD6A4)
    Alu.Sub16(AX, 0x97);
    CheckExternalEvents(cs1, 0xD6A9);
    // JL 0x0000:d6ea (0000_D6A7 / 0xD6A7)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D6EA_0D6EA;
    }
    CheckExternalEvents(cs1, 0xD6AC);
    // CMP AX,0xf0 (0000_D6A9 / 0xD6A9)
    Alu.Sub16(AX, 0xF0);
    CheckExternalEvents(cs1, 0xD6AE);
    // JG 0x0000:d6ea (0000_D6AC / 0xD6AC)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_D6EA_0D6EA;
    }
    CheckExternalEvents(cs1, 0xD6B2);
    // TEST byte ptr [BP + -0x4],0x1 (0000_D6AE / 0xD6AE)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs1, 0xD6B4);
    // JNZ 0x0000:d6ea (0000_D6B2 / 0xD6B2)
    if(!ZeroFlag) {
      goto label_0000_D6EA_0D6EA;
    }
    CheckExternalEvents(cs1, 0xD6B9);
    // MOV word ptr [BP + -0x8],0x0 (0000_D6B4 / 0xD6B4)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs1, 0xD6BE);
    // MOV word ptr [BP + -0xa],0x0 (0000_D6B9 / 0xD6B9)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x0;
    label_0000_D6BE_0D6BE:
    CheckExternalEvents(cs1, 0xD6C1);
    // MOV BX,word ptr [BP + -0xa] (0000_D6BE / 0xD6BE)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xD6C3);
    // SHL BX,0x1 (0000_D6C1 / 0xD6C1)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    CheckExternalEvents(cs1, 0xD6C6);
    // MOV AX,word ptr [BP + -0x6] (0000_D6C3 / 0xD6C3)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xD6CA);
    // CMP word ptr [BX + 0x241e],AX (0000_D6C6 / 0xD6C6)
    Alu.Sub16(UInt16[DS, (ushort)(BX + 0x241E)], AX);
    CheckExternalEvents(cs1, 0xD6CC);
    // JNZ 0x0000:d6d6 (0000_D6CA / 0xD6CA)
    if(!ZeroFlag) {
      goto label_0000_D6D6_0D6D6;
    }
    CheckExternalEvents(cs1, 0xD6D1);
    // MOV word ptr [BP + -0x8],0x1 (0000_D6CC / 0xD6CC)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs1, 0xD6D6);
    // MOV word ptr [BP + -0xa],0x8 (0000_D6D1 / 0xD6D1)
    UInt16[SS, (ushort)(BP - 0xA)] = 0x8;
    label_0000_D6D6_0D6D6:
    CheckExternalEvents(cs1, 0xD6D9);
    // INC word ptr [BP + -0xa] (0000_D6D6 / 0xD6D6)
    UInt16[SS, (ushort)(BP - 0xA)]++;
    CheckExternalEvents(cs1, 0xD6DD);
    // CMP word ptr [BP + -0xa],0x7 (0000_D6D9 / 0xD6D9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0xA)], 0x7);
    CheckExternalEvents(cs1, 0xD6DF);
    // JL 0x0000:d6be (0000_D6DD / 0xD6DD)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D6BE_0D6BE;
    }
    CheckExternalEvents(cs1, 0xD6E3);
    // CMP word ptr [BP + -0x8],0x0 (0000_D6DF / 0xD6DF)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs1, 0xD6E5);
    // JNZ 0x0000:d6ea (0000_D6E3 / 0xD6E3)
    if(!ZeroFlag) {
      goto label_0000_D6EA_0D6EA;
    }
    CheckExternalEvents(cs1, 0xD6EA);
    // MOV word ptr [BP + -0x2],0x0 (0000_D6E5 / 0xD6E5)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x0;
    label_0000_D6EA_0D6EA:
    CheckExternalEvents(cs1, 0xD6ED);
    // INC word ptr [BP + -0x6] (0000_D6EA / 0xD6EA)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0xD6F2);
    // CMP word ptr [BP + -0x6],0x300 (0000_D6ED / 0xD6ED)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x300);
    CheckExternalEvents(cs1, 0xD6F4);
    // JL 0x0000:d693 (0000_D6F2 / 0xD6F2)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D693_0D693;
    }
    label_0000_D6F4_0D6F4:
    CheckExternalEvents(cs1, 0xD6F9);
    // CALLF 0x1000:7bf6 (0000_D6F4 / 0xD6F4)
    FarCall(cs1, 0xD6F9, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0xD6FD);
    // CMP word ptr [BP + -0x2],0x0 (0000_D6F9 / 0xD6F9)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0xD6FF);
    // JZ 0x0000:d724 (0000_D6FD / 0xD6FD)
    if(ZeroFlag) {
      goto label_0000_D724_0D724;
    }
    CheckExternalEvents(cs1, 0xD702);
    // MOV AX,0x10 (0000_D6FF / 0xD6FF)
    AX = 0x10;
    CheckExternalEvents(cs1, 0xD703);
    // PUSH AX (0000_D702 / 0xD702)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD708);
    // CALLF 0x0000:30bf (0000_D703 / 0xD703)
    FarCall(cs1, 0xD708, ghidra_guess_0000_30BF_030BF);
    CheckExternalEvents(cs1, 0xD70B);
    // ADD SP,0x2 (0000_D708 / 0xD708)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD70E);
    // MOV AX,0x23b2 (0000_D70B / 0xD70B)
    AX = 0x23B2;
    CheckExternalEvents(cs1, 0xD70F);
    // PUSH DS (0000_D70E / 0xD70E)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD710);
    // PUSH AX (0000_D70F / 0xD70F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD715);
    // CALLF 0x1000:7c1a (0000_D710 / 0xD710)
    FarCall(cs1, 0xD715, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD718);
    // ADD SP,0x4 (0000_D715 / 0xD715)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD71C);
    // MOV ES,word ptr [0x54fa] (0000_D718 / 0xD718)
    ES = UInt16[DS, 0x54FA];
    CheckExternalEvents(cs1, 0xD722);
    // MOV byte ptr ES:[0xd34a],0x1 (0000_D71C / 0xD71C)
    UInt8[ES, 0xD34A] = 0x1;
    CheckExternalEvents(cs1, 0xD724);
    // JMP 0x0000:d772 (0000_D722 / 0xD722)
    goto label_0000_D772_0D772;
    label_0000_D724_0D724:
    CheckExternalEvents(cs1, 0xD727);
    // MOV AX,0x11 (0000_D724 / 0xD724)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xD728);
    // PUSH AX (0000_D727 / 0xD727)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD72D);
    // CALLF 0x0000:30bf (0000_D728 / 0xD728)
    FarCall(cs1, 0xD72D, ghidra_guess_0000_30BF_030BF);
    CheckExternalEvents(cs1, 0xD730);
    // ADD SP,0x2 (0000_D72D / 0xD72D)
    // SP += 0x2;
    SP = Alu.Add16(SP, 0x2);
    CheckExternalEvents(cs1, 0xD733);
    // MOV AX,0x2409 (0000_D730 / 0xD730)
    AX = 0x2409;
    CheckExternalEvents(cs1, 0xD734);
    // PUSH DS (0000_D733 / 0xD733)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xD735);
    // PUSH AX (0000_D734 / 0xD734)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xD73A);
    // CALLF 0x1000:7c1a (0000_D735 / 0xD735)
    FarCall(cs1, 0xD73A, ghidra_guess_1000_7C1A_17C1A);
    CheckExternalEvents(cs1, 0xD73D);
    // ADD SP,0x4 (0000_D73A / 0xD73A)
    // SP += 0x4;
    SP = Alu.Add16(SP, 0x4);
    CheckExternalEvents(cs1, 0xD742);
    // MOV word ptr [BP + -0x6],0x0 (0000_D73D / 0xD73D)
    UInt16[SS, (ushort)(BP - 0x6)] = 0x0;
    label_0000_D742_0D742:
    CheckExternalEvents(cs1, 0xD745);
    // MOV BX,word ptr [BP + -0x6] (0000_D742 / 0xD742)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xD749);
    // MOV ES,word ptr [0x550c] (0000_D745 / 0xD745)
    ES = UInt16[DS, 0x550C];
    CheckExternalEvents(cs1, 0xD74E);
    // MOV AL,byte ptr ES:[BX + 0x101d] (0000_D749 / 0xD749)
    AL = UInt8[ES, (ushort)(BX + 0x101D)];
    CheckExternalEvents(cs1, 0xD750);
    // SUB AH,AH (0000_D74E / 0xD74E)
    // AH -= AH;
    AH = Alu.Sub8(AH, AH);
    CheckExternalEvents(cs1, 0xD753);
    // MOV word ptr [BP + -0x4],AX (0000_D750 / 0xD750)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0xD756);
    // CMP AX,0x97 (0000_D753 / 0xD753)
    Alu.Sub16(AX, 0x97);
    CheckExternalEvents(cs1, 0xD758);
    // JL 0x0000:d768 (0000_D756 / 0xD756)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D768_0D768;
    }
    CheckExternalEvents(cs1, 0xD75B);
    // CMP AX,0xf0 (0000_D758 / 0xD758)
    Alu.Sub16(AX, 0xF0);
    CheckExternalEvents(cs1, 0xD75D);
    // JG 0x0000:d768 (0000_D75B / 0xD75B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_D768_0D768;
    }
    CheckExternalEvents(cs1, 0xD761);
    // TEST byte ptr [BP + -0x4],0x1 (0000_D75D / 0xD75D)
    Alu.And8(UInt8[SS, (ushort)(BP - 0x4)], 0x1);
    CheckExternalEvents(cs1, 0xD763);
    // JNZ 0x0000:d768 (0000_D761 / 0xD761)
    if(!ZeroFlag) {
      goto label_0000_D768_0D768;
    }
    CheckExternalEvents(cs1, 0xD768);
    // DEC byte ptr ES:[BX + 0x101d] (0000_D763 / 0xD763)
    UInt8[ES, (ushort)(BX + 0x101D)]--;
    label_0000_D768_0D768:
    CheckExternalEvents(cs1, 0xD76B);
    // INC word ptr [BP + -0x6] (0000_D768 / 0xD768)
    UInt16[SS, (ushort)(BP - 0x6)]++;
    CheckExternalEvents(cs1, 0xD770);
    // CMP word ptr [BP + -0x6],0x300 (0000_D76B / 0xD76B)
    Alu.Sub16(UInt16[SS, (ushort)(BP - 0x6)], 0x300);
    CheckExternalEvents(cs1, 0xD772);
    // JL 0x0000:d742 (0000_D770 / 0xD770)
    if(SignFlag != OverflowFlag) {
      goto label_0000_D742_0D742;
    }
    label_0000_D772_0D772:
    CheckExternalEvents(cs1, 0xD777);
    // CALLF 0x1000:8d29 (0000_D772 / 0xD772)
    FarCall(cs1, 0xD777, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xD77B);
    // MOV ES,word ptr [0x550e] (0000_D777 / 0xD777)
    ES = UInt16[DS, 0x550E];
    CheckExternalEvents(cs1, 0xD782);
    // MOV word ptr ES:[0xd55c],0x1 (0000_D77B / 0xD77B)
    UInt16[ES, 0xD55C] = 0x1;
    CheckExternalEvents(cs1, 0xD784);
    // MOV SP,BP (0000_D782 / 0xD782)
    SP = BP;
    CheckExternalEvents(cs1, 0xD785);
    // POP BP (0000_D784 / 0xD784)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xD786);
    // RETF  (0000_D785 / 0xD785)
    return FarRet();
  }
  
}
