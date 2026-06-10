namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

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
    Alu16.Sub(AX, 0x12);
    CheckExternalEvents(cs5, 0x2D);
    // JZ 0x0000:9501 (094C_002B / 0x94EB)
    if(ZeroFlag) {
      goto label_094C_0041_09501;
    }
    CheckExternalEvents(cs5, 0x30);
    // CMP AX,0x16 (094C_002D / 0x94ED)
    Alu16.Sub(AX, 0x16);
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
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs5, 0x52);
    // MOV word ptr [BP + -0x8],0x1 (094C_004D / 0x950D)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs5, 0x56);
    // CMP word ptr [BP + 0x6],0x0 (094C_0052 / 0x9512)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
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
    Alu8.Sub(UInt8[ES, 0xD320], 0x0);
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
    AX = Alu16.Or(AX, UInt16[ES, 0x458C]);
    CheckExternalEvents(cs5, 0x77);
    // JNZ 0x0000:9545 (094C_0075 / 0x9535)
    if(!ZeroFlag) {
      goto label_094C_0085_09545;
    }
    CheckExternalEvents(cs5, 0x7C);
    // CALLF 0x0000:e618 (094C_0077 / 0x9537)
    FarCall(cs5, 0x7C, unknown_0DD7_08A8_0E618);
    CheckExternalEvents(cs5, 0x7E);
    // OR AX,AX (094C_007C / 0x953C)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
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
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
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
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs5, 0x9B);
    // MOV BX,word ptr [BP + 0x6] (094C_0098 / 0x9558)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs5, 0xA0);
    // CMP byte ptr [BX + 0x141a],0x0 (094C_009B / 0x955B)
    Alu8.Sub(UInt8[DS, (ushort)(BX + 0x141A)], 0x0);
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
    SP = Alu16.Add(SP, 0x4);
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
    SP = Alu16.Add(SP, 0x4);
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
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs5, 0xD3);
    // MOV ES,word ptr [0x545c] (094C_00CF / 0x958F)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs5, 0xD9);
    // CMP byte ptr ES:[0xd33e],0x0 (094C_00D3 / 0x9593)
    Alu8.Sub(UInt8[ES, 0xD33E], 0x0);
    CheckExternalEvents(cs5, 0xDB);
    // JNZ 0x0000:95f6 (094C_00D9 / 0x9599)
    if(!ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xDF);
    // CMP word ptr [BP + 0x6],0x8 (094C_00DB / 0x959B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs5, 0xE1);
    // JNZ 0x0000:95f6 (094C_00DF / 0x959F)
    if(!ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xE7);
    // CMP byte ptr ES:[0xd33c],0x0 (094C_00E1 / 0x95A1)
    Alu8.Sub(UInt8[ES, 0xD33C], 0x0);
    CheckExternalEvents(cs5, 0xE9);
    // JZ 0x0000:95f6 (094C_00E7 / 0x95A7)
    if(ZeroFlag) {
      goto label_094C_0136_095F6;
    }
    CheckExternalEvents(cs5, 0xEF);
    // CMP byte ptr ES:[0xd31a],0x0 (094C_00E9 / 0x95A9)
    Alu8.Sub(UInt8[ES, 0xD31A], 0x0);
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
    SP = Alu16.Add(SP, 0x2);
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
    SP = Alu16.Add(SP, 0x4);
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
    FarCall(cs5, 0x119, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs5, 0x11C);
    // ADD SP,0x4 (094C_0119 / 0x95D9)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
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
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs5, 0x130);
    // MOV ES,word ptr [0x5466] (094C_012C / 0x95EC)
    ES = UInt16[DS, 0x5466];
    CheckExternalEvents(cs5, 0x136);
    // MOV byte ptr ES:[0x64],0xc (094C_0130 / 0x95F0)
    UInt8[ES, 0x64] = 0xC;
    label_094C_0136_095F6:
    CheckExternalEvents(cs5, 0x13A);
    // CMP word ptr [BP + 0x6],0x13 (094C_0136 / 0x95F6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x13);
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
    Alu8.Sub(UInt8[ES, 0xD31A], 0x0);
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
    SP = Alu16.Add(SP, 0x2);
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
    SP = Alu16.Add(SP, 0x2);
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
    SP = Alu16.Add(SP, 0x2);
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
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x14);
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
    Alu8.Sub(UInt8[ES, 0xD342], 0x0);
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
    BX = Alu16.Shl(BX, CL);
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
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x8);
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
      case 0x9691: goto label_094C_01D1_09691;break; // Target of external jump from 0x9755
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
    AX = Alu16.Sub(AX, AX);
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
  }
  
  public virtual Action split_0000_9697_09697(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x9746: goto label_0000_9746_09746;break; // Target of external jump from 0x99EC
      case 0: break; // 0 is the entry point ghidra detected, just after this switch
      default: throw FailAsUntested("Could not find any label from outside with address " + loadOffset);
    }
    label_0000_9697_09697:
    CheckExternalEvents(cs1, 0x969A);
    // MOV BX,word ptr [BP + -0xa] (0000_9697 / 0x9697)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x969D);
    // INC word ptr [BP + -0xa] (0000_969A / 0x969A)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x96A0);
    // LES SI,[BP + 0x6] (0000_969D / 0x969D)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x96A3);
    // MOV AL,byte ptr ES:[BX + SI] (0000_96A0 / 0x96A0)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x96A4);
    // CBW  (0000_96A3 / 0x96A3)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x96A7);
    // SUB AX,0xffe4 (0000_96A4 / 0x96A4)
    AX -= 0xFFE4;
    CheckExternalEvents(cs1, 0x96AA);
    // CMP AX,0x1b (0000_96A7 / 0x96A7)
    Alu16.Sub(AX, 0x1B);
    CheckExternalEvents(cs1, 0x96AC);
    // JBE 0x0000:96af (0000_96AA / 0x96AA)
    if(CarryFlag || ZeroFlag) {
      goto label_0000_96AF_096AF;
    }
    CheckExternalEvents(cs1, 0x96AF);
    // JMP 0x0000:9aa9 (0000_96AC / 0x96AC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_96AF_096AF:
    CheckExternalEvents(cs1, 0x96B1);
    // ADD AX,AX (0000_96AF / 0x96AF)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs1, 0x96B2);
    // XCHG AX,BX (0000_96B1 / 0x96B1)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs1, 0x96B7);
    // JMP word ptr CS:[BX + 0x5b1] (0000_96B2 / 0x96B2)
    // Indirect jump to word ptr CS:[BX + 0x5b1], generating possible targets from emulator records
    uint targetAddress_0000_96B2 = (uint)(UInt16[cs1, (ushort)(BX + 0x5B1)]);
    switch(targetAddress_0000_96B2) {
      case 0x96BF : {
        goto label_094C_01FF_096BF;
        break;
      }
      case 0x96D5 : {
        goto label_094C_0215_096D5;
        break;
      }
      case 0x9712 : {
        goto label_094C_0252_09712;
        break;
      }
      case 0x9758 : {
        goto label_094C_0298_09758;
        break;
      }
      case 0x96DD : {
        goto label_094C_021D_096DD;
        break;
      }
      case 0x9728 : {
        goto label_094C_0268_09728;
        break;
      }
      case 0x99E9 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_0000_99E9_099E9, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x9827 : {
        goto label_094C_0367_09827;
        break;
      }
      case 0x9793 : {
        goto label_094C_02D3_09793;
        break;
      }
      case 0x96B7 : {
        goto label_094C_01F7_096B7;
        break;
      }
      case 0x97D1 : {
        goto label_094C_0311_097D1;
        break;
      }
      case 0x977D : {
        goto label_094C_02BD_0977D;
        break;
      }
      case 0x97F7 : {
        goto label_094C_0337_097F7;
        break;
      }
      case 0x970A : {
        goto label_094C_024A_0970A;
        break;
      }
      case 0x97A9 : {
        goto label_094C_02E9_097A9;
        break;
      }
      case 0x97FF : {
        goto label_094C_033F_097FF;
        break;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_0000_96B2));
        break;
    }
    label_0000_96B7_096B7:
    CheckExternalEvents(cs1, 0x96BC);
    // MOV word ptr [BP + -0x8],0x1 (0000_96B7 / 0x96B7)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    CheckExternalEvents(cs1, 0x96BF);
    // JMP 0x0000:9aa9 (0000_96BC / 0x96BC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_96BF_096BF:
    CheckExternalEvents(cs1, 0x96C2);
    // MOV BX,word ptr [BP + -0xa] (0000_96BF / 0x96BF)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x96C5);
    // INC word ptr [BP + -0xa] (0000_96C2 / 0x96C2)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x96C8);
    // MOV SI,word ptr [BP + 0x6] (0000_96C5 / 0x96C5)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x96CB);
    // MOV AL,byte ptr ES:[BX + SI] (0000_96C8 / 0x96C8)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x96CC);
    // CBW  (0000_96CB / 0x96CB)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x96CD);
    // PUSH AX (0000_96CC / 0x96CC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x96D2);
    // CALLF 0x1000:7ee1 (0000_96CD / 0x96CD)
    FarCall(cs1, 0x96D2, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x96D5);
    // JMP 0x0000:9a6c (0000_96D2 / 0x96D2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9A6C_09A6C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_96D5_096D5:
    CheckExternalEvents(cs1, 0x96DA);
    // CALLF 0x1000:7fe8 (0000_96D5 / 0x96D5)
    FarCall(cs1, 0x96DA, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0x96DD);
    // JMP 0x0000:9aa9 (0000_96DA / 0x96DA)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_96DD_096DD:
    CheckExternalEvents(cs1, 0x96E0);
    // MOV AX,word ptr [BP + -0xa] (0000_96DD / 0x96DD)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x96E3);
    // ADD AX,word ptr [BP + 0x6] (0000_96E0 / 0x96E0)
    // AX += UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x96E6);
    // MOV DX,word ptr [BP + 0x8] (0000_96E3 / 0x96E3)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x96E7);
    // PUSH DX (0000_96E6 / 0x96E6)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x96E8);
    // PUSH AX (0000_96E7 / 0x96E7)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x96ED);
    // CALLF 0x1000:8055 (0000_96E8 / 0x96E8)
    FarCall(cs1, 0x96ED, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x96F0);
    // ADD SP,0x4 (0000_96ED / 0x96ED)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x96F3);
    // MOV AX,word ptr [BP + -0xa] (0000_96F0 / 0x96F0)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x96F6);
    // ADD AX,word ptr [BP + 0x6] (0000_96F3 / 0x96F3)
    // AX += UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs1, 0x96F9);
    // MOV DX,word ptr [BP + 0x8] (0000_96F6 / 0x96F6)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x96FA);
    // PUSH DX (0000_96F9 / 0x96F9)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x96FB);
    // PUSH AX (0000_96FA / 0x96FA)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9700);
    // CALLF 0x1000:da8e (0000_96FB / 0x96FB)
    FarCall(cs1, 0x9700, unknown_19EF_3B9E_1DA8E);
    CheckExternalEvents(cs1, 0x9703);
    // ADD SP,0x4 (0000_9700 / 0x9700)
    SP += 0x4;
    CheckExternalEvents(cs1, 0x9704);
    // INC AX (0000_9703 / 0x9703)
    AX++;
    CheckExternalEvents(cs1, 0x9707);
    // ADD word ptr [BP + -0xa],AX (0000_9704 / 0x9704)
    // UInt16[SS, (ushort)(BP - 0xA)] += AX;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xA)], AX);
    CheckExternalEvents(cs1, 0x970A);
    // JMP 0x0000:9aa9 (0000_9707 / 0x9707)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_970A_0970A:
    CheckExternalEvents(cs1, 0x970F);
    // CALLF 0x1000:8d29 (0000_970A / 0x970A)
    FarCall(cs1, 0x970F, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x9712);
    // JMP 0x0000:9aa9 (0000_970F / 0x970F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9712_09712:
    CheckExternalEvents(cs1, 0x9715);
    // MOV BX,word ptr [BP + -0xa] (0000_9712 / 0x9712)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x9718);
    // INC word ptr [BP + -0xa] (0000_9715 / 0x9715)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x971B);
    // LES SI,[BP + 0x6] (0000_9718 / 0x9718)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x971E);
    // MOV AL,byte ptr ES:[BX + SI] (0000_971B / 0x971B)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x971F);
    // CBW  (0000_971E / 0x971E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9720);
    // PUSH AX (0000_971F / 0x971F)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9725);
    // CALLF 0x1000:7c64 (0000_9720 / 0x9720)
    FarCall(cs1, 0x9725, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0x9728);
    // JMP 0x0000:9a6c (0000_9725 / 0x9725)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9A6C_09A6C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9728_09728:
    CheckExternalEvents(cs1, 0x972B);
    // MOV BX,word ptr [BP + -0xa] (0000_9728 / 0x9728)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x972E);
    // INC word ptr [BP + -0xa] (0000_972B / 0x972B)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x9731);
    // LES SI,[BP + 0x6] (0000_972E / 0x972E)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x9734);
    // MOV AL,byte ptr ES:[BX + SI] (0000_9731 / 0x9731)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x9735);
    // CBW  (0000_9734 / 0x9734)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9736);
    // PUSH AX (0000_9735 / 0x9735)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x973B);
    // CALLF 0x1000:87be (0000_9736 / 0x9736)
    FarCall(cs1, 0x973B, unknown_17C6_0B5E_187BE);
    CheckExternalEvents(cs1, 0x973E);
    // ADD SP,0x2 (0000_973B / 0x973B)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9741);
    // MOV word ptr [BP + -0x6],AX (0000_973E / 0x973E)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x9743);
    // SHL AX,0x1 (0000_9741 / 0x9741)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0x9746);
    // ADD AX,word ptr [BP + -0xa] (0000_9743 / 0x9743)
    AX += UInt16[SS, (ushort)(BP - 0xA)];
    label_0000_9746_09746:
    CheckExternalEvents(cs1, 0x9749);
    // ADD AX,word ptr [BP + 0x6] (0000_9746 / 0x9746)
    // AX += UInt16[SS, (ushort)(BP + 0x6)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0x6)]);
    label_0000_9749_09749:
    CheckExternalEvents(cs1, 0x974C);
    // MOV DX,word ptr [BP + 0x8] (0000_9749 / 0x9749)
    DX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x974D);
    // PUSH DX (0000_974C / 0x974C)
    Stack.Push16(DX);
    CheckExternalEvents(cs1, 0x974E);
    // PUSH AX (0000_974D / 0x974D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x974F);
    // PUSH CS (0000_974E / 0x974E)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x9752);
    // CALL 0x0000:9ab7 (0000_974F / 0x974F)
    NearCall(cs1, 0x9752, unknown_094C_05F7_09AB7);
    CheckExternalEvents(cs1, 0x9755);
    // ADD SP,0x4 (0000_9752 / 0x9752)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x9758);
    // JMP 0x0000:9691 (0000_9755 / 0x9755)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(unknown_094C_01C0_09680, 0x9691 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9758_09758:
    CheckExternalEvents(cs1, 0x975B);
    // MOV BX,word ptr [BP + -0xa] (0000_9758 / 0x9758)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x975E);
    // INC word ptr [BP + -0xa] (0000_975B / 0x975B)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x9761);
    // LES SI,[BP + 0x6] (0000_975E / 0x975E)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x9764);
    // MOV AL,byte ptr ES:[BX + SI] (0000_9761 / 0x9761)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x9765);
    // CBW  (0000_9764 / 0x9764)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9767);
    // MOV BX,AX (0000_9765 / 0x9765)
    BX = AX;
    CheckExternalEvents(cs1, 0x976B);
    // MOV ES,word ptr [0x545c] (0000_9767 / 0x9767)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0x9771);
    // CMP byte ptr ES:[BX + 0xd30c],0x0 (0000_976B / 0x976B)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD30C)], 0x0);
    CheckExternalEvents(cs1, 0x9773);
    // JNZ 0x0000:9776 (0000_9771 / 0x9771)
    if(!ZeroFlag) {
      goto label_0000_9776_09776;
    }
    CheckExternalEvents(cs1, 0x9776);
    // JMP 0x0000:9a27 (0000_9773 / 0x9773)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9A27_09A27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9776_09776:
    CheckExternalEvents(cs1, 0x9779);
    // MOV AX,word ptr [BP + -0xa] (0000_9776 / 0x9776)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    label_0000_9779_09779:
    CheckExternalEvents(cs1, 0x977B);
    // ADD AX,SI (0000_9779 / 0x9779)
    // AX += SI;
    AX = Alu16.Add(AX, SI);
    CheckExternalEvents(cs1, 0x977D);
    // JMP 0x0000:9749 (0000_977B / 0x977B)
    goto label_0000_9749_09749;
    label_0000_977D_0977D:
    CheckExternalEvents(cs1, 0x9780);
    // MOV AX,0x1 (0000_977D / 0x977D)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x9781);
    // PUSH AX (0000_9780 / 0x9780)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9786);
    // CALLF 0x0000:3113 (0000_9781 / 0x9781)
    FarCall(cs1, 0x9786, unknown_0170_1A13_03113);
    CheckExternalEvents(cs1, 0x9789);
    // ADD SP,0x2 (0000_9786 / 0x9786)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x978B);
    // OR AX,AX (0000_9789 / 0x9789)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x978D);
    // JNZ 0x0000:9790 (0000_978B / 0x978B)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      CheckExternalEvents(cs1, 0x9793);
      // JMP 0x0000:99e9 (0000_9790 / 0x9790)
      // Jump converted to entry function call
      if(JumpDispatcher.Jump(split_0000_99E9_099E9, 0)) {
        loadOffset = JumpDispatcher.NextEntryAddress;
        goto entrydispatcher;
      }
      return JumpDispatcher.JumpAsmReturn!;
    }
    CheckExternalEvents(cs1, 0x9790);
    // JMP 0x0000:9a27 (0000_978D / 0x978D)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9A27_09A27, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9790_09790:
    CheckExternalEvents(cs1, 0x9793);
    // JMP 0x0000:99e9 (0000_9790 / 0x9790)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_99E9_099E9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9793_09793:
    CheckExternalEvents(cs1, 0x9796);
    // MOV BX,word ptr [BP + -0xa] (0000_9793 / 0x9793)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x9799);
    // INC word ptr [BP + -0xa] (0000_9796 / 0x9796)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x979C);
    // LES SI,[BP + 0x6] (0000_9799 / 0x9799)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x979F);
    // MOV AL,byte ptr ES:[BX + SI] (0000_979C / 0x979C)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x97A0);
    // CBW  (0000_979F / 0x979F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x97A1);
    // PUSH AX (0000_97A0 / 0x97A0)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x97A6);
    // CALLF 0x1000:6434 (0000_97A1 / 0x97A1)
    FarCall(cs1, 0x97A6, unknown_1643_0004_16434);
    CheckExternalEvents(cs1, 0x97A9);
    // JMP 0x0000:9a6c (0000_97A6 / 0x97A6)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9A6C_09A6C, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_97A9_097A9:
    CheckExternalEvents(cs1, 0x97AC);
    // MOV BX,word ptr [BP + -0xa] (0000_97A9 / 0x97A9)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x97AF);
    // INC word ptr [BP + -0xa] (0000_97AC / 0x97AC)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x97B2);
    // LES SI,[BP + 0x6] (0000_97AF / 0x97AF)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x97B5);
    // MOV AL,byte ptr ES:[BX + SI] (0000_97B2 / 0x97B2)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x97B6);
    // CBW  (0000_97B5 / 0x97B5)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x97B9);
    // MOV word ptr [BP + -0x6],AX (0000_97B6 / 0x97B6)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x97BC);
    // MOV BX,word ptr [BP + -0xa] (0000_97B9 / 0x97B9)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x97BF);
    // INC word ptr [BP + -0xa] (0000_97BC / 0x97BC)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x97C2);
    // MOV AL,byte ptr ES:[BX + SI] (0000_97BF / 0x97BF)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x97C5);
    // MOV BX,word ptr [BP + -0x6] (0000_97C2 / 0x97C2)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x97C9);
    // MOV ES,word ptr [0x545c] (0000_97C5 / 0x97C5)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0x97CE);
    // MOV byte ptr ES:[BX + 0xd30c],AL (0000_97C9 / 0x97C9)
    UInt8[ES, (ushort)(BX + 0xD30C)] = AL;
    CheckExternalEvents(cs1, 0x97D1);
    // JMP 0x0000:9aa9 (0000_97CE / 0x97CE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_97D1_097D1:
    CheckExternalEvents(cs1, 0x97D4);
    // MOV BX,word ptr [BP + -0xa] (0000_97D1 / 0x97D1)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x97D7);
    // INC word ptr [BP + -0xa] (0000_97D4 / 0x97D4)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x97DA);
    // LES SI,[BP + 0x6] (0000_97D7 / 0x97D7)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x97DD);
    // MOV AL,byte ptr ES:[BX + SI] (0000_97DA / 0x97DA)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x97DE);
    // CBW  (0000_97DD / 0x97DD)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x97E0);
    // MOV BX,AX (0000_97DE / 0x97DE)
    BX = AX;
    CheckExternalEvents(cs1, 0x97E4);
    // MOV ES,word ptr [0x545c] (0000_97E0 / 0x97E0)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0x97E9);
    // MOV AL,byte ptr ES:[BX + 0xd30c] (0000_97E4 / 0x97E4)
    AL = UInt8[ES, (ushort)(BX + 0xD30C)];
    CheckExternalEvents(cs1, 0x97EA);
    // CBW  (0000_97E9 / 0x97E9)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x97EC);
    // SHL AX,0x1 (0000_97EA / 0x97EA)
    // AX <<= 0x1;
    AX = Alu16.Shl(AX, 0x1);
    CheckExternalEvents(cs1, 0x97EF);
    // MOV word ptr [BP + -0x6],AX (0000_97EC / 0x97EC)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x97F2);
    // MOV AX,word ptr [BP + -0xa] (0000_97EF / 0x97EF)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x97F5);
    // ADD AX,word ptr [BP + -0x6] (0000_97F2 / 0x97F2)
    // AX += UInt16[SS, (ushort)(BP - 0x6)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs1, 0x97F7);
    // JMP 0x0000:9779 (0000_97F5 / 0x97F5)
    goto label_0000_9779_09779;
    label_0000_97F7_097F7:
    CheckExternalEvents(cs1, 0x97FC);
    // CALLF 0x1000:933a (0000_97F7 / 0x97F7)
    FarCall(cs1, 0x97FC, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs1, 0x97FF);
    // JMP 0x0000:9aa9 (0000_97FC / 0x97FC)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_97FF_097FF:
    CheckExternalEvents(cs1, 0x9802);
    // MOV BX,word ptr [BP + -0xa] (0000_97FF / 0x97FF)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x9805);
    // INC word ptr [BP + -0xa] (0000_9802 / 0x9802)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x9808);
    // LES SI,[BP + 0x6] (0000_9805 / 0x9805)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x980B);
    // MOV AL,byte ptr ES:[BX + SI] (0000_9808 / 0x9808)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x980C);
    // CBW  (0000_980B / 0x980B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x980F);
    // MOV word ptr [BP + -0x6],AX (0000_980C / 0x980C)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0x9812);
    // MOV BX,word ptr [BP + -0xa] (0000_980F / 0x980F)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x9815);
    // INC word ptr [BP + -0xa] (0000_9812 / 0x9812)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x9818);
    // MOV AL,byte ptr ES:[BX + SI] (0000_9815 / 0x9815)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x981B);
    // MOV BX,word ptr [BP + -0x6] (0000_9818 / 0x9818)
    BX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0x981F);
    // MOV ES,word ptr [0x545c] (0000_981B / 0x981B)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0x9824);
    // ADD byte ptr ES:[BX + 0xd30c],AL (0000_981F / 0x981F)
    // UInt8[ES, (ushort)(BX + 0xD30C)] += AL;
    UInt8[ES, (ushort)(BX + 0xD30C)] = Alu8.Add(UInt8[ES, (ushort)(BX + 0xD30C)], AL);
    CheckExternalEvents(cs1, 0x9827);
    // JMP 0x0000:9aa9 (0000_9824 / 0x9824)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_0000_9827_09827:
    CheckExternalEvents(cs1, 0x982A);
    // MOV BX,word ptr [BP + -0xa] (0000_9827 / 0x9827)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x982D);
    // INC word ptr [BP + -0xa] (0000_982A / 0x982A)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x9830);
    // LES SI,[BP + 0x6] (0000_982D / 0x982D)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    ES = UInt16[SS, (ushort)(BP + 0x6 + 2)];
    CheckExternalEvents(cs1, 0x9833);
    // MOV AL,byte ptr ES:[BX + SI] (0000_9830 / 0x9830)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x9834);
    // CBW  (0000_9833 / 0x9833)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9838);
    // MOV ES,word ptr [0x5468] (0000_9834 / 0x9834)
    ES = UInt16[DS, 0x5468];
    CheckExternalEvents(cs1, 0x983C);
    // MOV ES:[0x3748],AX (0000_9838 / 0x9838)
    UInt16[ES, 0x3748] = AX;
    CheckExternalEvents(cs1, 0x983F);
    // MOV BX,word ptr [BP + -0xa] (0000_983C / 0x983C)
    BX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x9842);
    // INC word ptr [BP + -0xa] (0000_983F / 0x983F)
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xA)]);
    CheckExternalEvents(cs1, 0x9845);
    // MOV ES,word ptr [BP + 0x8] (0000_9842 / 0x9842)
    ES = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0x9848);
    // MOV AL,byte ptr ES:[BX + SI] (0000_9845 / 0x9845)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0x9849);
    // CBW  (0000_9848 / 0x9848)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x984D);
    // MOV ES,word ptr [0x546a] (0000_9849 / 0x9849)
    ES = UInt16[DS, 0x546A];
    CheckExternalEvents(cs1, 0x9851);
    // MOV ES:[0x374e],AX (0000_984D / 0x984D)
    UInt16[ES, 0x374E] = AX;
    CheckExternalEvents(cs1, 0x9854);
    // JMP 0x0000:9aa9 (0000_9851 / 0x9851)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_99E9_099E9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_99E9_099E9:
    CheckExternalEvents(cs1, 0x99EC);
    // MOV AX,word ptr [BP + -0xa] (0000_99E9 / 0x99E9)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0x99EF);
    // JMP 0x0000:9746 (0000_99EC / 0x99EC)
    // Jump converted to non entry function call
    if(JumpDispatcher.Jump(split_0000_9697_09697, 0x9746 - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_9A27_09A27(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_9A27_09A27:
    CheckExternalEvents(cs1, 0x9A2B);
    // ADD word ptr [BP + -0xa],0x2 (0000_9A27 / 0x9A27)
    // UInt16[SS, (ushort)(BP - 0xA)] += 0x2;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0xA)], 0x2);
    CheckExternalEvents(cs1, 0x9A2D);
    // JMP 0x0000:9aa9 (0000_9A2B / 0x9A2B)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_9A6C_09A6C(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_9A6C_09A6C:
    CheckExternalEvents(cs1, 0x9A6F);
    // ADD SP,0x2 (0000_9A6C / 0x9A6C)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9A71);
    // JMP 0x0000:9aa9 (0000_9A6F / 0x9A6F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9AA9_09AA9, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_9AA9_09AA9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_9AA9_09AA9:
    CheckExternalEvents(cs1, 0x9AAD);
    // CMP word ptr [BP + -0x8],0x0 (0000_9AA9 / 0x9AA9)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs1, 0x9AAF);
    // JNZ 0x0000:9ab2 (0000_9AAD / 0x9AAD)
    if(!ZeroFlag) {
      goto label_0000_9AB2_09AB2;
    }
    CheckExternalEvents(cs1, 0x9AB2);
    // JMP 0x0000:9697 (0000_9AAF / 0x9AAF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9697_09697, 0)) {
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
    AH = Alu8.Sub(AH, AH);
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
    UInt8[SS, (ushort)(BP - 0x1)] = Alu8.And(UInt8[SS, (ushort)(BP - 0x1)], AH);
    CheckExternalEvents(cs5, 0x61D);
    // MOV AH,byte ptr [BP + -0x2] (094C_061A / 0x9ADA)
    AH = UInt8[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs5, 0x61F);
    // SUB AL,AL (094C_061D / 0x9ADD)
    AL -= AL;
    CheckExternalEvents(cs5, 0x622);
    // ADD AX,word ptr [BP + -0x4] (094C_061F / 0x9ADF)
    // AX += UInt16[SS, (ushort)(BP - 0x4)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x4)]);
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
  
  public virtual Action unknown_094C_0629_09AE9(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_094C_0629_09AE9:
    CheckExternalEvents(cs5, 0x62A);
    // PUSH BP (094C_0629 / 0x9AE9)
    Stack.Push16(BP);
    CheckExternalEvents(cs5, 0x62C);
    // MOV BP,SP (094C_062A / 0x9AEA)
    BP = SP;
    CheckExternalEvents(cs5, 0x62F);
    // MOV AX,0x24 (094C_062C / 0x9AEC)
    AX = 0x24;
    CheckExternalEvents(cs5, 0x634);
    // CALLF 0x1000:cecc (094C_062F / 0x9AEF)
    FarCall(cs5, 0x634, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs5, 0x635);
    // PUSH SI (094C_0634 / 0x9AF4)
    Stack.Push16(SI);
    CheckExternalEvents(cs5, 0x637);
    // SUB AX,AX (094C_0635 / 0x9AF5)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs5, 0x63A);
    // MOV word ptr [BP + -0xe],AX (094C_0637 / 0x9AF7)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs5, 0x63D);
    // MOV word ptr [BP + -0x2],AX (094C_063A / 0x9AFA)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs5, 0x640);
    // MOV AX,word ptr [BP + 0x6] (094C_063D / 0x9AFD)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs5, 0x643);
    // CMP AX,0x9 (094C_0640 / 0x9B00)
    Alu16.Sub(AX, 0x9);
    CheckExternalEvents(cs5, 0x645);
    // JBE 0x0000:9b08 (094C_0643 / 0x9B03)
    if(CarryFlag || ZeroFlag) {
      goto label_094C_0648_09B08;
    }
    CheckExternalEvents(cs5, 0x648);
    // JMP 0x0000:9d43 (094C_0645 / 0x9B05)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9D43_09D43, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_094C_0648_09B08:
    CheckExternalEvents(cs5, 0x64A);
    // ADD AX,AX (094C_0648 / 0x9B08)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs5, 0x64B);
    // XCHG AX,BX (094C_064A / 0x9B0A)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs5, 0x650);
    // JMP word ptr CS:[BX + 0x86f] (094C_064B / 0x9B0B)
    // Indirect jump to word ptr CS:[BX + 0x86f], generating possible targets from emulator records
    uint targetAddress_094C_064B = (uint)(cs5 * 0x10 + UInt16[cs5, (ushort)(BX + 0x86F)] - cs1 * 0x10);
    switch(targetAddress_094C_064B) {
      case 0x9B10 : {
        goto label_094C_0650_09B10;
        break;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_094C_064B));
        break;
    }
    label_094C_0650_09B10:
    CheckExternalEvents(cs5, 0x654);
    // MOV ES,word ptr [0x5470] (094C_0650 / 0x9B10)
    ES = UInt16[DS, 0x5470];
    CheckExternalEvents(cs5, 0x658);
    // MOV AL,ES:[0x200a] (094C_0654 / 0x9B14)
    AL = UInt8[ES, 0x200A];
    CheckExternalEvents(cs5, 0x659);
    // CBW  (094C_0658 / 0x9B18)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs5, 0x65C);
    // MOV word ptr [BP + -0x18],AX (094C_0659 / 0x9B19)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs5, 0x662);
    // MOV byte ptr ES:[0x200a],0x0 (094C_065C / 0x9B1C)
    UInt8[ES, 0x200A] = 0x0;
    CheckExternalEvents(cs5, 0x664);
    // SUB AX,AX (094C_0662 / 0x9B22)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs5, 0x667);
    // MOV word ptr [BP + -0x2],AX (094C_0664 / 0x9B24)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs5, 0x66A);
    // MOV word ptr [BP + -0x14],AX (094C_0667 / 0x9B27)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs5, 0x66C);
    // SUB AX,AX (094C_066A / 0x9B2A)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs5, 0x66D);
    // PUSH AX (094C_066C / 0x9B2C)
    Stack.Push16(AX);
    CheckExternalEvents(cs5, 0x672);
    // CALLF 0x0000:388f (094C_066D / 0x9B2D)
    FarCall(cs5, 0x672, unknown_0170_218F_0388F);
    CheckExternalEvents(cs5, 0x675);
    // ADD SP,0x2 (094C_0672 / 0x9B32)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs5, 0x678);
    // JMP 0x0000:9d43 (094C_0675 / 0x9B35)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_0000_9D43_09D43, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_0000_9D43_09D43(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_9D43_09D43:
    CheckExternalEvents(cs1, 0x9D47);
    // MOV ES,word ptr [0x5474] (0000_9D43 / 0x9D43)
    ES = UInt16[DS, 0x5474];
    CheckExternalEvents(cs1, 0x9D4B);
    // MOV AX,ES:[0x3772] (0000_9D47 / 0x9D47)
    AX = UInt16[ES, 0x3772];
    CheckExternalEvents(cs1, 0x9D4E);
    // MOV word ptr [BP + -0x10],AX (0000_9D4B / 0x9D4B)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x9D52);
    // CMP word ptr [BP + 0x6],0x8 (0000_9D4E / 0x9D4E)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs1, 0x9D54);
    // JNZ 0x0000:9d59 (0000_9D52 / 0x9D52)
    if(!ZeroFlag) {
      goto label_0000_9D59_09D59;
    }
    CheckExternalEvents(cs1, 0x9D59);
    // MOV word ptr [BP + -0x10],0x1 (0000_9D54 / 0x9D54)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x1;
    label_0000_9D59_09D59:
    CheckExternalEvents(cs1, 0x9D5E);
    // MOV word ptr [BP + -0x1e],0x0 (0000_9D59 / 0x9D59)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x0;
    label_0000_9D5E_09D5E:
    CheckExternalEvents(cs1, 0x9D62);
    // CMP word ptr [BP + -0x10],0x0 (0000_9D5E / 0x9D5E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0x0);
    CheckExternalEvents(cs1, 0x9D64);
    // JZ 0x0000:9d67 (0000_9D62 / 0x9D62)
    if(ZeroFlag) {
      goto label_0000_9D67_09D67;
    }
    CheckExternalEvents(cs1, 0x9D67);
    // JMP 0x0000:a0b2 (0000_9D64 / 0x9D64)
    goto label_0000_A0B2_0A0B2;
    label_0000_9D67_09D67:
    CheckExternalEvents(cs1, 0x9D6B);
    // MOV ES,word ptr [0x546c] (0000_9D67 / 0x9D67)
    ES = UInt16[DS, 0x546C];
    CheckExternalEvents(cs1, 0x9D72);
    // CMP word ptr ES:[0xa44b],0xc3c (0000_9D6B / 0x9D6B)
    Alu16.Sub(UInt16[ES, 0xA44B], 0xC3C);
    CheckExternalEvents(cs1, 0x9D74);
    // JA 0x0000:9dbe (0000_9D72 / 0x9D72)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_9DBE_09DBE;
    }
    CheckExternalEvents(cs1, 0x9D78);
    // MOV ES,word ptr [0x546e] (0000_9D74 / 0x9D74)
    ES = UInt16[DS, 0x546E];
    CheckExternalEvents(cs1, 0x9D7F);
    // CMP word ptr ES:[0xa44d],0xc049 (0000_9D78 / 0x9D78)
    Alu16.Sub(UInt16[ES, 0xA44D], 0xC049);
    CheckExternalEvents(cs1, 0x9D81);
    // JC 0x0000:9dbe (0000_9D7F / 0x9D7F)
    if(CarryFlag) {
      goto label_0000_9DBE_09DBE;
    }
    CheckExternalEvents(cs1, 0x9D88);
    // CMP word ptr ES:[0xa44d],0xc04f (0000_9D81 / 0x9D81)
    Alu16.Sub(UInt16[ES, 0xA44D], 0xC04F);
    CheckExternalEvents(cs1, 0x9D8A);
    // JA 0x0000:9dbe (0000_9D88 / 0x9D88)
    if(!CarryFlag && !ZeroFlag) {
      goto label_0000_9DBE_09DBE;
    }
    CheckExternalEvents(cs1, 0x9D8E);
    // CMP word ptr [BP + -0x2],0x0 (0000_9D8A / 0x9D8A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0x9D90);
    // JZ 0x0000:9d97 (0000_9D8E / 0x9D8E)
    if(ZeroFlag) {
      goto label_0000_9D97_09D97;
    }
    CheckExternalEvents(cs1, 0x9D95);
    // MOV word ptr [BP + -0x10],0x1 (0000_9D90 / 0x9D90)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x1;
    CheckExternalEvents(cs1, 0x9D97);
    // JMP 0x0000:9dbe (0000_9D95 / 0x9D95)
    goto label_0000_9DBE_09DBE;
    label_0000_9D97_09D97:
    CheckExternalEvents(cs1, 0x9D9B);
    // CMP word ptr [BP + -0xe],0x0 (0000_9D97 / 0x9D97)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs1, 0x9D9D);
    // JNZ 0x0000:9db9 (0000_9D9B / 0x9D9B)
    if(!ZeroFlag) {
      goto label_0000_9DB9_09DB9;
    }
    CheckExternalEvents(cs1, 0x9DA2);
    // CALLF 0x1000:7bf6 (0000_9D9D / 0x9D9D)
    FarCall(cs1, 0x9DA2, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0x9DA5);
    // MOV AX,0x146b (0000_9DA2 / 0x9DA2)
    AX = 0x146B;
    CheckExternalEvents(cs1, 0x9DA6);
    // PUSH DS (0000_9DA5 / 0x9DA5)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9DA7);
    // PUSH AX (0000_9DA6 / 0x9DA6)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9DAC);
    // CALLF 0x1000:8055 (0000_9DA7 / 0x9DA7)
    FarCall(cs1, 0x9DAC, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x9DAF);
    // ADD SP,0x4 (0000_9DAC / 0x9DAC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x9DB4);
    // CALLF 0x1000:933a (0000_9DAF / 0x9DAF)
    FarCall(cs1, 0x9DB4, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs1, 0x9DB9);
    // CALLF 0x1000:8d29 (0000_9DB4 / 0x9DB4)
    FarCall(cs1, 0x9DB9, unknown_18AD_0259_18D29);
    label_0000_9DB9_09DB9:
    CheckExternalEvents(cs1, 0x9DBE);
    // MOV word ptr [BP + -0xe],0x1 (0000_9DB9 / 0x9DB9)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x1;
    label_0000_9DBE_09DBE:
    CheckExternalEvents(cs1, 0x9DC2);
    // CMP word ptr [BP + -0x10],0x0 (0000_9DBE / 0x9DBE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x10)], 0x0);
    CheckExternalEvents(cs1, 0x9DC4);
    // JNZ 0x0000:9d5e (0000_9DC2 / 0x9DC2)
    if(!ZeroFlag) {
      goto label_0000_9D5E_09D5E;
    }
    CheckExternalEvents(cs1, 0x9DC9);
    // MOV word ptr [BP + -0x12],0x0 (0000_9DC4 / 0x9DC4)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs1, 0x9DCE);
    // CALLF 0x1000:8aff (0000_9DC9 / 0x9DC9)
    FarCall(cs1, 0x9DCE, unknown_18AD_002F_18AFF);
    CheckExternalEvents(cs1, 0x9DD0);
    // OR AX,AX (0000_9DCE / 0x9DCE)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x9DD2);
    // JZ 0x0000:9e05 (0000_9DD0 / 0x9DD0)
    if(ZeroFlag) {
      goto label_0000_9E05_09E05;
    }
    CheckExternalEvents(cs1, 0x9DD7);
    // MOV word ptr [BP + -0x12],0x1 (0000_9DD2 / 0x9DD2)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    CheckExternalEvents(cs1, 0x9DDC);
    // CALLF 0x1000:8d29 (0000_9DD7 / 0x9DD7)
    FarCall(cs1, 0x9DDC, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x9DDD);
    // PUSH AX (0000_9DDC / 0x9DDC)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9DE2);
    // CALLF 0x1000:897d (0000_9DDD / 0x9DDD)
    FarCall(cs1, 0x9DE2, unknown_17C6_0D1D_1897D);
    CheckExternalEvents(cs1, 0x9DE5);
    // ADD SP,0x2 (0000_9DE2 / 0x9DE2)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9DE8);
    // MOV word ptr [BP + -0x20],AX (0000_9DE5 / 0x9DE5)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs1, 0x9DED);
    // CALLF 0x0000:412b (0000_9DE8 / 0x9DE8)
    FarCall(cs1, 0x9DED, unknown_0170_2A2B_0412B);
    CheckExternalEvents(cs1, 0x9DF0);
    // PUSH word ptr [BP + -0x20] (0000_9DED / 0x9DED)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x9DF5);
    // CALLF 0x0000:3a1d (0000_9DF0 / 0x9DF0)
    FarCall(cs1, 0x9DF5, unknown_0170_231D_03A1D);
    CheckExternalEvents(cs1, 0x9DF8);
    // ADD SP,0x2 (0000_9DF5 / 0x9DF5)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9DFB);
    // PUSH word ptr [BP + -0x20] (0000_9DF8 / 0x9DF8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs1, 0x9E00);
    // CALLF 0x0000:388f (0000_9DFB / 0x9DFB)
    FarCall(cs1, 0x9E00, unknown_0170_218F_0388F);
    CheckExternalEvents(cs1, 0x9E03);
    // ADD SP,0x2 (0000_9E00 / 0x9E00)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9E05);
    // JMP 0x0000:9e1b (0000_9E03 / 0x9E03)
    goto label_0000_9E1B_09E1B;
    label_0000_9E05_09E05:
    CheckExternalEvents(cs1, 0x9E08);
    // MOV AX,0x1 (0000_9E05 / 0x9E05)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x9E09);
    // PUSH AX (0000_9E08 / 0x9E08)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9E0E);
    // CALLF 0x1000:8ad6 (0000_9E09 / 0x9E09)
    FarCall(cs1, 0x9E0E, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs1, 0x9E11);
    // ADD SP,0x2 (0000_9E0E / 0x9E0E)
    SP += 0x2;
    CheckExternalEvents(cs1, 0x9E14);
    // DEC word ptr [BP + -0x1e] (0000_9E11 / 0x9E11)
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.Dec(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs1, 0x9E16);
    // JNS 0x0000:9e1b (0000_9E14 / 0x9E14)
    if(!SignFlag) {
      goto label_0000_9E1B_09E1B;
    }
    CheckExternalEvents(cs1, 0x9E1B);
    // MOV word ptr [BP + -0x12],0x1 (0000_9E16 / 0x9E16)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x1;
    label_0000_9E1B_09E1B:
    CheckExternalEvents(cs1, 0x9E1F);
    // CMP word ptr [BP + -0x12],0x0 (0000_9E1B / 0x9E1B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x0);
    CheckExternalEvents(cs1, 0x9E21);
    // JNZ 0x0000:9e24 (0000_9E1F / 0x9E1F)
    if(!ZeroFlag) {
      goto label_0000_9E24_09E24;
    }
    CheckExternalEvents(cs1, 0x9E24);
    // JMP 0x0000:9d5e (0000_9E21 / 0x9E21)
    goto label_0000_9D5E_09D5E;
    label_0000_9E24_09E24:
    CheckExternalEvents(cs1, 0x9E29);
    // MOV word ptr [BP + -0x1e],0xa (0000_9E24 / 0x9E24)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0xA;
    CheckExternalEvents(cs1, 0x9E2E);
    // CALLF 0x0000:3b0b (0000_9E29 / 0x9E29)
    FarCall(cs1, 0x9E2E, unknown_0170_240B_03B0B);
    CheckExternalEvents(cs1, 0x9E32);
    // INC word ptr [0x5802] (0000_9E2E / 0x9E2E)
    UInt16[DS, 0x5802]++;
    CheckExternalEvents(cs1, 0x9E37);
    // CMP word ptr [0x5802],0x1 (0000_9E32 / 0x9E32)
    Alu16.Sub(UInt16[DS, 0x5802], 0x1);
    CheckExternalEvents(cs1, 0x9E39);
    // JNZ 0x0000:9e3e (0000_9E37 / 0x9E37)
    if(!ZeroFlag) {
      goto label_0000_9E3E_09E3E;
    }
    CheckExternalEvents(cs1, 0x9E3E);
    // CALLF 0x0000:3bc2 (0000_9E39 / 0x9E39)
    FarCall(cs1, 0x9E3E, unknown_0170_24C2_03BC2);
    label_0000_9E3E_09E3E:
    CheckExternalEvents(cs1, 0x9E43);
    // AND word ptr [0x5802],0x3 (0000_9E3E / 0x9E3E)
    // UInt16[DS, 0x5802] &= 0x3;
    UInt16[DS, 0x5802] = Alu16.And(UInt16[DS, 0x5802], 0x3);
    CheckExternalEvents(cs1, 0x9E48);
    // CALLF 0x1000:b7df (0000_9E43 / 0x9E43)
    FarCall(cs1, 0x9E48, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs1, 0x9E4D);
    // CALLF 0x0000:1c1b (0000_9E48 / 0x9E48)
    FarCall(cs1, 0x9E4D, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs1, 0x9E52);
    // CALLF 0x1000:9193 (0000_9E4D / 0x9E4D)
    FarCall(cs1, 0x9E52, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs1, 0x9E55);
    // MOV AX,word ptr [BP + 0x6] (0000_9E52 / 0x9E52)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0x9E57);
    // OR AX,AX (0000_9E55 / 0x9E55)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0x9E59);
    // JZ 0x0000:9e69 (0000_9E57 / 0x9E57)
    if(ZeroFlag) {
      goto label_0000_9E69_09E69;
    }
    CheckExternalEvents(cs1, 0x9E5C);
    // CMP AX,0x1 (0000_9E59 / 0x9E59)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0x9E5E);
    // JZ 0x0000:9eca (0000_9E5C / 0x9E5C)
    if(ZeroFlag) {
      goto label_0000_9ECA_09ECA;
    }
    CheckExternalEvents(cs1, 0x9E61);
    // CMP AX,0x9 (0000_9E5E / 0x9E5E)
    Alu16.Sub(AX, 0x9);
    CheckExternalEvents(cs1, 0x9E63);
    // JNZ 0x0000:9e66 (0000_9E61 / 0x9E61)
    if(!ZeroFlag) {
      // JNZ target is JMP, inlining.
      CheckExternalEvents(cs1, 0x9E69);
      // JMP 0x0000:9d5e (0000_9E66 / 0x9E66)
      goto label_0000_9D5E_09D5E;
    }
    CheckExternalEvents(cs1, 0x9E66);
    // JMP 0x0000:9f68 (0000_9E63 / 0x9E63)
    goto label_0000_9F68_09F68;
    label_0000_9E66_09E66:
    CheckExternalEvents(cs1, 0x9E69);
    // JMP 0x0000:9d5e (0000_9E66 / 0x9E66)
    goto label_0000_9D5E_09D5E;
    label_0000_9E69_09E69:
    CheckExternalEvents(cs1, 0x9E6C);
    // INC word ptr [BP + -0x14] (0000_9E69 / 0x9E69)
    UInt16[SS, (ushort)(BP - 0x14)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0x9E70);
    // MOV ES,word ptr [0x5478] (0000_9E6C / 0x9E6C)
    ES = UInt16[DS, 0x5478];
    CheckExternalEvents(cs1, 0x9E76);
    // CMP byte ptr ES:[0x32ae],0x0 (0000_9E70 / 0x9E70)
    Alu8.Sub(UInt8[ES, 0x32AE], 0x0);
    CheckExternalEvents(cs1, 0x9E78);
    // JZ 0x0000:9e84 (0000_9E76 / 0x9E76)
    if(ZeroFlag) {
      goto label_0000_9E84_09E84;
    }
    CheckExternalEvents(cs1, 0x9E7C);
    // MOV AL,ES:[0x32ae] (0000_9E78 / 0x9E78)
    AL = UInt8[ES, 0x32AE];
    CheckExternalEvents(cs1, 0x9E7D);
    // CBW  (0000_9E7C / 0x9E7C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9E7F);
    // MOV CL,0x3 (0000_9E7D / 0x9E7D)
    CL = 0x3;
    CheckExternalEvents(cs1, 0x9E81);
    // SAR AX,CL (0000_9E7F / 0x9E7F)
    AX = Alu16.Sar(AX, CL);
    CheckExternalEvents(cs1, 0x9E84);
    // ADD word ptr [BP + -0x14],AX (0000_9E81 / 0x9E81)
    // UInt16[SS, (ushort)(BP - 0x14)] += AX;
    UInt16[SS, (ushort)(BP - 0x14)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x14)], AX);
    label_0000_9E84_09E84:
    CheckExternalEvents(cs1, 0x9E88);
    // MOV ES,word ptr [0x546c] (0000_9E84 / 0x9E84)
    ES = UInt16[DS, 0x546C];
    CheckExternalEvents(cs1, 0x9E8F);
    // CMP word ptr ES:[0xa44b],0xc78 (0000_9E88 / 0x9E88)
    Alu16.Sub(UInt16[ES, 0xA44B], 0xC78);
    CheckExternalEvents(cs1, 0x9E91);
    // JNC 0x0000:9e94 (0000_9E8F / 0x9E8F)
    if(!CarryFlag) {
      goto label_0000_9E94_09E94;
    }
    CheckExternalEvents(cs1, 0x9E94);
    // JMP 0x0000:9d5e (0000_9E91 / 0x9E91)
    goto label_0000_9D5E_09D5E;
    label_0000_9E94_09E94:
    CheckExternalEvents(cs1, 0x9E98);
    // MOV ES,word ptr [0x546e] (0000_9E94 / 0x9E94)
    ES = UInt16[DS, 0x546E];
    CheckExternalEvents(cs1, 0x9E9F);
    // CMP word ptr ES:[0xa44d],0xc07c (0000_9E98 / 0x9E98)
    Alu16.Sub(UInt16[ES, 0xA44D], 0xC07C);
    CheckExternalEvents(cs1, 0x9EA1);
    // JNC 0x0000:9ea4 (0000_9E9F / 0x9E9F)
    if(!CarryFlag) {
      goto label_0000_9EA4_09EA4;
    }
    CheckExternalEvents(cs1, 0x9EA4);
    // JMP 0x0000:9d5e (0000_9EA1 / 0x9EA1)
    goto label_0000_9D5E_09D5E;
    label_0000_9EA4_09EA4:
    CheckExternalEvents(cs1, 0x9EA8);
    // CMP word ptr [BP + -0x2],0x0 (0000_9EA4 / 0x9EA4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0x9EAA);
    // JZ 0x0000:9ead (0000_9EA8 / 0x9EA8)
    if(ZeroFlag) {
      goto label_0000_9EAD_09EAD;
    }
    CheckExternalEvents(cs1, 0x9EAD);
    // JMP 0x0000:9d5e (0000_9EAA / 0x9EAA)
    goto label_0000_9D5E_09D5E;
    label_0000_9EAD_09EAD:
    CheckExternalEvents(cs1, 0x9EB0);
    // INC word ptr [BP + -0x2] (0000_9EAD / 0x9EAD)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x9EB5);
    // CALLF 0x1000:7bf6 (0000_9EB0 / 0x9EB0)
    FarCall(cs1, 0x9EB5, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0x9EB8);
    // MOV AX,0x14a1 (0000_9EB5 / 0x9EB5)
    AX = 0x14A1;
    CheckExternalEvents(cs1, 0x9EB9);
    // PUSH DS (0000_9EB8 / 0x9EB8)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9EBA);
    // PUSH AX (0000_9EB9 / 0x9EB9)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9EBF);
    // CALLF 0x1000:7c1a (0000_9EBA / 0x9EBA)
    FarCall(cs1, 0x9EBF, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs1, 0x9EC2);
    // ADD SP,0x4 (0000_9EBF / 0x9EBF)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_0000_9EC2_09EC2:
    CheckExternalEvents(cs1, 0x9EC7);
    // CALLF 0x1000:8d29 (0000_9EC2 / 0x9EC2)
    FarCall(cs1, 0x9EC7, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0x9ECA);
    // JMP 0x0000:9d5e (0000_9EC7 / 0x9EC7)
    goto label_0000_9D5E_09D5E;
    label_0000_9ECA_09ECA:
    CheckExternalEvents(cs1, 0x9ECE);
    // MOV ES,word ptr [0x546c] (0000_9ECA / 0x9ECA)
    ES = UInt16[DS, 0x546C];
    CheckExternalEvents(cs1, 0x9ED2);
    // MOV AX,ES:[0xa44b] (0000_9ECE / 0x9ECE)
    AX = UInt16[ES, 0xA44B];
    CheckExternalEvents(cs1, 0x9ED5);
    // AND AX,0x7f (0000_9ED2 / 0x9ED2)
    AX &= 0x7F;
    CheckExternalEvents(cs1, 0x9ED7);
    // SHR AX,0x1 (0000_9ED5 / 0x9ED5)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs1, 0x9EDA);
    // MOV word ptr [BP + -0x16],AX (0000_9ED7 / 0x9ED7)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs1, 0x9EDE);
    // MOV ES,word ptr [0x546e] (0000_9EDA / 0x9EDA)
    ES = UInt16[DS, 0x546E];
    CheckExternalEvents(cs1, 0x9EE2);
    // MOV AX,ES:[0xa44d] (0000_9EDE / 0x9EDE)
    AX = UInt16[ES, 0xA44D];
    CheckExternalEvents(cs1, 0x9EE5);
    // AND AX,0x7f (0000_9EE2 / 0x9EE2)
    AX &= 0x7F;
    CheckExternalEvents(cs1, 0x9EE7);
    // SHR AX,0x1 (0000_9EE5 / 0x9EE5)
    // AX >>= 0x1;
    AX = Alu16.Shr(AX, 0x1);
    CheckExternalEvents(cs1, 0x9EEA);
    // MOV word ptr [BP + -0x1a],AX (0000_9EE7 / 0x9EE7)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs1, 0x9EED);
    // MOV BX,word ptr [BP + -0x22] (0000_9EEA / 0x9EEA)
    BX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs1, 0x9EF1);
    // MOV AL,byte ptr [BX + 0x1632] (0000_9EED / 0x9EED)
    AL = UInt8[DS, (ushort)(BX + 0x1632)];
    CheckExternalEvents(cs1, 0x9EF2);
    // CBW  (0000_9EF1 / 0x9EF1)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9EF4);
    // MOV SI,AX (0000_9EF2 / 0x9EF2)
    SI = AX;
    CheckExternalEvents(cs1, 0x9EF7);
    // LEA AX,[SI + -0x1] (0000_9EF4 / 0x9EF4)
    AX = (ushort)(SI - 0x1);
    CheckExternalEvents(cs1, 0x9EFA);
    // CMP word ptr [BP + -0x16],AX (0000_9EF7 / 0x9EF7)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x16)], AX);
    CheckExternalEvents(cs1, 0x9EFC);
    // JGE 0x0000:9eff (0000_9EFA / 0x9EFA)
    if(SignFlag == OverflowFlag) {
      goto label_0000_9EFF_09EFF;
    }
    CheckExternalEvents(cs1, 0x9EFF);
    // JMP 0x0000:9d5e (0000_9EFC / 0x9EFC)
    goto label_0000_9D5E_09D5E;
    label_0000_9EFF_09EFF:
    CheckExternalEvents(cs1, 0x9F02);
    // CMP word ptr [BP + -0x16],SI (0000_9EFF / 0x9EFF)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x16)], SI);
    CheckExternalEvents(cs1, 0x9F04);
    // JLE 0x0000:9f07 (0000_9F02 / 0x9F02)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_9F07_09F07;
    }
    CheckExternalEvents(cs1, 0x9F07);
    // JMP 0x0000:9d5e (0000_9F04 / 0x9F04)
    goto label_0000_9D5E_09D5E;
    label_0000_9F07_09F07:
    CheckExternalEvents(cs1, 0x9F0A);
    // MOV BX,word ptr [BP + -0x22] (0000_9F07 / 0x9F07)
    BX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs1, 0x9F0E);
    // MOV AL,byte ptr [BX + 0x163a] (0000_9F0A / 0x9F0A)
    AL = UInt8[DS, (ushort)(BX + 0x163A)];
    CheckExternalEvents(cs1, 0x9F0F);
    // CBW  (0000_9F0E / 0x9F0E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0x9F10);
    // INC AX (0000_9F0F / 0x9F0F)
    AX++;
    CheckExternalEvents(cs1, 0x9F13);
    // CMP AX,word ptr [BP + -0x1a] (0000_9F10 / 0x9F10)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x1A)]);
    CheckExternalEvents(cs1, 0x9F15);
    // JZ 0x0000:9f18 (0000_9F13 / 0x9F13)
    if(ZeroFlag) {
      goto label_0000_9F18_09F18;
    }
    CheckExternalEvents(cs1, 0x9F18);
    // JMP 0x0000:9d5e (0000_9F15 / 0x9F15)
    goto label_0000_9D5E_09D5E;
    label_0000_9F18_09F18:
    CheckExternalEvents(cs1, 0x9F1C);
    // CMP word ptr [BP + -0x2],0x0 (0000_9F18 / 0x9F18)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0x9F1E);
    // JZ 0x0000:9f21 (0000_9F1C / 0x9F1C)
    if(ZeroFlag) {
      goto label_0000_9F21_09F21;
    }
    CheckExternalEvents(cs1, 0x9F21);
    // JMP 0x0000:9d5e (0000_9F1E / 0x9F1E)
    goto label_0000_9D5E_09D5E;
    label_0000_9F21_09F21:
    CheckExternalEvents(cs1, 0x9F24);
    // INC word ptr [BP + -0x2] (0000_9F21 / 0x9F21)
    UInt16[SS, (ushort)(BP - 0x2)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x2)]);
    CheckExternalEvents(cs1, 0x9F29);
    // CALLF 0x1000:7bf6 (0000_9F24 / 0x9F24)
    FarCall(cs1, 0x9F29, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs1, 0x9F2D);
    // MOV ES,word ptr [0x545c] (0000_9F29 / 0x9F29)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0x9F33);
    // CMP byte ptr ES:[0xc724],0x4c (0000_9F2D / 0x9F2D)
    Alu8.Sub(UInt8[ES, 0xC724], 0x4C);
    CheckExternalEvents(cs1, 0x9F35);
    // JNZ 0x0000:9f44 (0000_9F33 / 0x9F33)
    if(!ZeroFlag) {
      goto label_0000_9F44_09F44;
    }
    CheckExternalEvents(cs1, 0x9F38);
    // MOV AX,0x14ef (0000_9F35 / 0x9F35)
    AX = 0x14EF;
    CheckExternalEvents(cs1, 0x9F39);
    // PUSH DS (0000_9F38 / 0x9F38)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9F3A);
    // PUSH AX (0000_9F39 / 0x9F39)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9F3F);
    // CALLF 0x1000:8055 (0000_9F3A / 0x9F3A)
    FarCall(cs1, 0x9F3F, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x9F42);
    // ADD SP,0x4 (0000_9F3F / 0x9F3F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x9F44);
    // JMP 0x0000:9f60 (0000_9F42 / 0x9F42)
    goto label_0000_9F60_09F60;
    label_0000_9F44_09F44:
    CheckExternalEvents(cs1, 0x9F47);
    // MOV AX,0x152a (0000_9F44 / 0x9F44)
    AX = 0x152A;
    CheckExternalEvents(cs1, 0x9F48);
    // PUSH DS (0000_9F47 / 0x9F47)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9F49);
    // PUSH AX (0000_9F48 / 0x9F48)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9F4E);
    // CALLF 0x1000:8055 (0000_9F49 / 0x9F49)
    FarCall(cs1, 0x9F4E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0x9F51);
    // ADD SP,0x4 (0000_9F4E / 0x9F4E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x9F54);
    // MOV AL,byte ptr [BP + -0x18] (0000_9F51 / 0x9F51)
    AL = UInt8[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0x9F57);
    // MOV BX,word ptr [BP + -0x4] (0000_9F54 / 0x9F54)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0x9F5B);
    // MOV ES,word ptr [0x5470] (0000_9F57 / 0x9F57)
    ES = UInt16[DS, 0x5470];
    CheckExternalEvents(cs1, 0x9F60);
    // MOV byte ptr ES:[BX + 0x101d],AL (0000_9F5B / 0x9F5B)
    UInt8[ES, (ushort)(BX + 0x101D)] = AL;
    label_0000_9F60_09F60:
    CheckExternalEvents(cs1, 0x9F65);
    // CALLF 0x1000:933a (0000_9F60 / 0x9F60)
    FarCall(cs1, 0x9F65, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs1, 0x9F68);
    // JMP 0x0000:9ec2 (0000_9F65 / 0x9F65)
    goto label_0000_9EC2_09EC2;
    label_0000_9F68_09F68:
    CheckExternalEvents(cs1, 0x9F6B);
    // MOV AX,word ptr [BP + -0x14] (0000_9F68 / 0x9F68)
    AX = UInt16[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0x9F6E);
    // INC word ptr [BP + -0x14] (0000_9F6B / 0x9F6B)
    UInt16[SS, (ushort)(BP - 0x14)]++;
    CheckExternalEvents(cs1, 0x9F71);
    // CMP AX,0x50 (0000_9F6E / 0x9F6E)
    Alu16.Sub(AX, 0x50);
    CheckExternalEvents(cs1, 0x9F73);
    // JL 0x0000:9fa7 (0000_9F71 / 0x9F71)
    if(SignFlag != OverflowFlag) {
      goto label_0000_9FA7_09FA7;
    }
    CheckExternalEvents(cs1, 0x9F76);
    // MOV AX,0x88 (0000_9F73 / 0x9F73)
    AX = 0x88;
    CheckExternalEvents(cs1, 0x9F77);
    // PUSH AX (0000_9F76 / 0x9F76)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9F79);
    // SUB AX,AX (0000_9F77 / 0x9F77)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0x9F7A);
    // PUSH AX (0000_9F79 / 0x9F79)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9F7B);
    // PUSH CS (0000_9F7A / 0x9F7A)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0x9F7E);
    // CALL 0x0000:a209 (0000_9F7B / 0x9F7B)
    NearCall(cs1, 0x9F7E, ghidra_guess_0000_A209_0A209);
    CheckExternalEvents(cs1, 0x9F81);
    // ADD SP,0x4 (0000_9F7E / 0x9F7E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0x9F84);
    // MOV AX,0x3 (0000_9F81 / 0x9F81)
    AX = 0x3;
    CheckExternalEvents(cs1, 0x9F85);
    // PUSH AX (0000_9F84 / 0x9F84)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9F8A);
    // CALLF 0x1000:1aba (0000_9F85 / 0x9F85)
    FarCall(cs1, 0x9F8A, ghidra_guess_1000_1ABA_11ABA);
    CheckExternalEvents(cs1, 0x9F8D);
    // ADD SP,0x2 (0000_9F8A / 0x9F8A)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9F92);
    // MOV word ptr [BP + -0x14],0x0 (0000_9F8D / 0x9F8D)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x0;
    CheckExternalEvents(cs1, 0x9F96);
    // MOV ES,word ptr [0x547a] (0000_9F92 / 0x9F92)
    ES = UInt16[DS, 0x547A];
    CheckExternalEvents(cs1, 0x9F9C);
    // CMP word ptr ES:[0x14a],0x0 (0000_9F96 / 0x9F96)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs1, 0x9F9E);
    // JNZ 0x0000:9fa7 (0000_9F9C / 0x9F9C)
    if(!ZeroFlag) {
      goto label_0000_9FA7_09FA7;
    }
    CheckExternalEvents(cs1, 0x9FA1);
    // MOV AX,0x1 (0000_9F9E / 0x9F9E)
    AX = 0x1;
    CheckExternalEvents(cs1, 0x9FA4);
    // MOV word ptr [BP + -0x10],AX (0000_9FA1 / 0x9FA1)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0x9FA7);
    // MOV word ptr [BP + -0x2],AX (0000_9FA4 / 0x9FA4)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    label_0000_9FA7_09FA7:
    CheckExternalEvents(cs1, 0x9FAB);
    // MOV ES,word ptr [0x547a] (0000_9FA7 / 0x9FA7)
    ES = UInt16[DS, 0x547A];
    CheckExternalEvents(cs1, 0x9FB1);
    // CMP word ptr ES:[0x14a],0x0 (0000_9FAB / 0x9FAB)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs1, 0x9FB3);
    // JNZ 0x0000:9fb6 (0000_9FB1 / 0x9FB1)
    if(!ZeroFlag) {
      goto label_0000_9FB6_09FB6;
    }
    CheckExternalEvents(cs1, 0x9FB6);
    // JMP 0x0000:9d5e (0000_9FB3 / 0x9FB3)
    goto label_0000_9D5E_09D5E;
    label_0000_9FB6_09FB6:
    CheckExternalEvents(cs1, 0x9FBA);
    // MOV ES,word ptr [0x546e] (0000_9FB6 / 0x9FB6)
    ES = UInt16[DS, 0x546E];
    CheckExternalEvents(cs1, 0x9FC1);
    // CMP word ptr ES:[0xa44d],0x702d (0000_9FBA / 0x9FBA)
    Alu16.Sub(UInt16[ES, 0xA44D], 0x702D);
    CheckExternalEvents(cs1, 0x9FC3);
    // JZ 0x0000:9fc6 (0000_9FC1 / 0x9FC1)
    if(ZeroFlag) {
      goto label_0000_9FC6_09FC6;
    }
    CheckExternalEvents(cs1, 0x9FC6);
    // JMP 0x0000:9d5e (0000_9FC3 / 0x9FC3)
    goto label_0000_9D5E_09D5E;
    label_0000_9FC6_09FC6:
    CheckExternalEvents(cs1, 0x9FCB);
    // MOV word ptr [BP + -0x1c],0x0 (0000_9FC6 / 0x9FC6)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x0;
    CheckExternalEvents(cs1, 0x9FCD);
    // JMP 0x0000:9ff3 (0000_9FCB / 0x9FCB)
    goto label_0000_9FF3_09FF3;
    label_0000_9FCD_09FCD:
    CheckExternalEvents(cs1, 0x9FD2);
    // CALLF 0x0000:c932 (0000_9FCD / 0x9FCD)
    FarCall(cs1, 0x9FD2, ghidra_guess_0000_C932_0C932);
    CheckExternalEvents(cs1, 0x9FD5);
    // MOV AX,0x6 (0000_9FD2 / 0x9FD2)
    AX = 0x6;
    CheckExternalEvents(cs1, 0x9FD6);
    // PUSH AX (0000_9FD5 / 0x9FD5)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9FDB);
    // CALLF 0x1000:7ee1 (0000_9FD6 / 0x9FD6)
    FarCall(cs1, 0x9FDB, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0x9FDE);
    // ADD SP,0x2 (0000_9FDB / 0x9FDB)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0x9FE1);
    // MOV AX,0x1611 (0000_9FDE / 0x9FDE)
    AX = 0x1611;
    CheckExternalEvents(cs1, 0x9FE2);
    // PUSH DS (0000_9FE1 / 0x9FE1)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0x9FE3);
    // PUSH AX (0000_9FE2 / 0x9FE2)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0x9FE8);
    // CALLF 0x1000:7c1a (0000_9FE3 / 0x9FE3)
    FarCall(cs1, 0x9FE8, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs1, 0x9FEB);
    // ADD SP,0x4 (0000_9FE8 / 0x9FE8)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_0000_9FEB_09FEB:
    CheckExternalEvents(cs1, 0x9FF0);
    // CALLF 0x1000:8d29 (0000_9FEB / 0x9FEB)
    FarCall(cs1, 0x9FF0, unknown_18AD_0259_18D29);
    label_0000_9FF0_09FF0:
    CheckExternalEvents(cs1, 0x9FF3);
    // INC word ptr [BP + -0x1c] (0000_9FF0 / 0x9FF0)
    UInt16[SS, (ushort)(BP - 0x1C)]++;
    label_0000_9FF3_09FF3:
    CheckExternalEvents(cs1, 0x9FF7);
    // CMP word ptr [BP + -0x1c],0x4 (0000_9FF3 / 0x9FF3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1C)], 0x4);
    CheckExternalEvents(cs1, 0x9FF9);
    // JL 0x0000:9ffc (0000_9FF7 / 0x9FF7)
    if(SignFlag != OverflowFlag) {
      goto label_0000_9FFC_09FFC;
    }
    CheckExternalEvents(cs1, 0x9FFC);
    // JMP 0x0000:9d5e (0000_9FF9 / 0x9FF9)
    goto label_0000_9D5E_09D5E;
    label_0000_9FFC_09FFC:
    CheckExternalEvents(cs1, 0x9FFF);
    // MOV AX,word ptr [BP + -0x1c] (0000_9FFC / 0x9FFC)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs1, 0xA001);
    // SHL AX,0x1 (0000_9FFF / 0x9FFF)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0xA003);
    // SHL AX,0x1 (0000_A001 / 0xA001)
    AX <<= 0x1;
    CheckExternalEvents(cs1, 0xA006);
    // ADD AX,0xd14 (0000_A003 / 0xA003)
    // AX += 0xD14;
    AX = Alu16.Add(AX, 0xD14);
    CheckExternalEvents(cs1, 0xA00A);
    // MOV ES,word ptr [0x546c] (0000_A006 / 0xA006)
    ES = UInt16[DS, 0x546C];
    CheckExternalEvents(cs1, 0xA00F);
    // CMP AX,word ptr ES:[0xa44b] (0000_A00A / 0xA00A)
    Alu16.Sub(AX, UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs1, 0xA011);
    // JNZ 0x0000:9ff0 (0000_A00F / 0xA00F)
    if(!ZeroFlag) {
      goto label_0000_9FF0_09FF0;
    }
    CheckExternalEvents(cs1, 0xA014);
    // MOV SI,word ptr [BP + -0x1c] (0000_A011 / 0xA011)
    SI = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs1, 0xA016);
    // SHL SI,0x1 (0000_A014 / 0xA014)
    SI <<= 0x1;
    CheckExternalEvents(cs1, 0xA01A);
    // CMP word ptr [BP + SI + -0xc],0x0 (0000_A016 / 0xA016)
    Alu16.Sub(UInt16[SS, (ushort)(BP + SI - 0xC)], 0x0);
    CheckExternalEvents(cs1, 0xA01C);
    // JNZ 0x0000:9ff0 (0000_A01A / 0xA01A)
    if(!ZeroFlag) {
      goto label_0000_9FF0_09FF0;
    }
    CheckExternalEvents(cs1, 0xA01F);
    // MOV SI,word ptr [BP + -0x1c] (0000_A01C / 0xA01C)
    SI = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs1, 0xA021);
    // SHL SI,0x1 (0000_A01F / 0xA01F)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xA026);
    // MOV word ptr [BP + SI + -0xc],0x1 (0000_A021 / 0xA021)
    UInt16[SS, (ushort)(BP + SI - 0xC)] = 0x1;
    CheckExternalEvents(cs1, 0xA029);
    // MOV AX,0x6 (0000_A026 / 0xA026)
    AX = 0x6;
    CheckExternalEvents(cs1, 0xA02A);
    // PUSH AX (0000_A029 / 0xA029)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA02F);
    // CALLF 0x1000:7ee1 (0000_A02A / 0xA02A)
    FarCall(cs1, 0xA02F, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xA032);
    // ADD SP,0x2 (0000_A02F / 0xA02F)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xA037);
    // CALLF 0x1000:7fe8 (0000_A032 / 0xA032)
    FarCall(cs1, 0xA037, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs1, 0xA039);
    // SUB AX,AX (0000_A037 / 0xA037)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xA03A);
    // PUSH AX (0000_A039 / 0xA039)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA03F);
    // CALLF 0x1000:7c64 (0000_A03A / 0xA03A)
    FarCall(cs1, 0xA03F, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs1, 0xA042);
    // ADD SP,0x2 (0000_A03F / 0xA03F)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xA045);
    // MOV AX,0x155d (0000_A042 / 0xA042)
    AX = 0x155D;
    CheckExternalEvents(cs1, 0xA046);
    // PUSH DS (0000_A045 / 0xA045)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xA047);
    // PUSH AX (0000_A046 / 0xA046)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA04C);
    // CALLF 0x1000:8055 (0000_A047 / 0xA047)
    FarCall(cs1, 0xA04C, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xA04F);
    // ADD SP,0x4 (0000_A04C / 0xA04C)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xA052);
    // MOV AX,0x159a (0000_A04F / 0xA04F)
    AX = 0x159A;
    CheckExternalEvents(cs1, 0xA053);
    // PUSH DS (0000_A052 / 0xA052)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xA054);
    // PUSH AX (0000_A053 / 0xA053)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA059);
    // CALLF 0x1000:8055 (0000_A054 / 0xA054)
    FarCall(cs1, 0xA059, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xA05C);
    // ADD SP,0x4 (0000_A059 / 0xA059)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xA061);
    // CALLF 0x1000:933a (0000_A05C / 0xA05C)
    FarCall(cs1, 0xA061, unknown_18AD_086A_1933A);
    CheckExternalEvents(cs1, 0xA066);
    // CALLF 0x1000:8d29 (0000_A061 / 0xA061)
    FarCall(cs1, 0xA066, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs1, 0xA069);
    // MOV AX,0x15d4 (0000_A066 / 0xA066)
    AX = 0x15D4;
    CheckExternalEvents(cs1, 0xA06A);
    // PUSH DS (0000_A069 / 0xA069)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xA06B);
    // PUSH AX (0000_A06A / 0xA06A)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA070);
    // CALLF 0x1000:8055 (0000_A06B / 0xA06B)
    FarCall(cs1, 0xA070, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs1, 0xA073);
    // ADD SP,0x4 (0000_A070 / 0xA070)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xA076);
    // MOV AX,word ptr [BP + -0x24] (0000_A073 / 0xA073)
    AX = UInt16[SS, (ushort)(BP - 0x24)];
    CheckExternalEvents(cs1, 0xA079);
    // INC word ptr [BP + -0x24] (0000_A076 / 0xA076)
    UInt16[SS, (ushort)(BP - 0x24)]++;
    CheckExternalEvents(cs1, 0xA07C);
    // CMP AX,0x2 (0000_A079 / 0xA079)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0xA07E);
    // JZ 0x0000:a081 (0000_A07C / 0xA07C)
    if(ZeroFlag) {
      goto label_0000_A081_0A081;
    }
    CheckExternalEvents(cs1, 0xA081);
    // JMP 0x0000:9fcd (0000_A07E / 0xA07E)
    goto label_0000_9FCD_09FCD;
    label_0000_A081_0A081:
    CheckExternalEvents(cs1, 0xA083);
    // SUB AX,AX (0000_A081 / 0xA081)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xA084);
    // PUSH AX (0000_A083 / 0xA083)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA085);
    // PUSH AX (0000_A084 / 0xA084)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA08A);
    // CALLF 0x0000:5fb7 (0000_A085 / 0xA085)
    FarCall(cs1, 0xA08A, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs1, 0xA08D);
    // ADD SP,0x4 (0000_A08A / 0xA08A)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xA090);
    // MOV AX,0x6 (0000_A08D / 0xA08D)
    AX = 0x6;
    CheckExternalEvents(cs1, 0xA091);
    // PUSH AX (0000_A090 / 0xA090)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA096);
    // CALLF 0x1000:7ee1 (0000_A091 / 0xA091)
    FarCall(cs1, 0xA096, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs1, 0xA099);
    // ADD SP,0x2 (0000_A096 / 0xA096)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs1, 0xA09C);
    // MOV AX,0x15f8 (0000_A099 / 0xA099)
    AX = 0x15F8;
    CheckExternalEvents(cs1, 0xA09D);
    // PUSH DS (0000_A09C / 0xA09C)
    Stack.Push16(DS);
    CheckExternalEvents(cs1, 0xA09E);
    // PUSH AX (0000_A09D / 0xA09D)
    Stack.Push16(AX);
    CheckExternalEvents(cs1, 0xA0A3);
    // CALLF 0x1000:7c1a (0000_A09E / 0xA09E)
    FarCall(cs1, 0xA0A3, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs1, 0xA0A6);
    // ADD SP,0x4 (0000_A0A3 / 0xA0A3)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs1, 0xA0A9);
    // MOV AX,0x1 (0000_A0A6 / 0xA0A6)
    AX = 0x1;
    CheckExternalEvents(cs1, 0xA0AC);
    // MOV word ptr [BP + -0x2],AX (0000_A0A9 / 0xA0A9)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs1, 0xA0AF);
    // MOV word ptr [BP + -0x10],AX (0000_A0AC / 0xA0AC)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xA0B2);
    // JMP 0x0000:9feb (0000_A0AF / 0xA0AF)
    goto label_0000_9FEB_09FEB;
    label_0000_A0B2_0A0B2:
    CheckExternalEvents(cs1, 0xA0B6);
    // MOV ES,word ptr [0x545c] (0000_A0B2 / 0xA0B2)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA0BC);
    // MOV byte ptr ES:[0xd30d],0x0 (0000_A0B6 / 0xA0B6)
    UInt8[ES, 0xD30D] = 0x0;
    CheckExternalEvents(cs1, 0xA0BF);
    // MOV AX,word ptr [BP + 0x6] (0000_A0BC / 0xA0BC)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xA0C1);
    // OR AX,AX (0000_A0BF / 0xA0BF)
    // AX |= AX;
    AX = Alu16.Or(AX, AX);
    CheckExternalEvents(cs1, 0xA0C3);
    // JZ 0x0000:a0d8 (0000_A0C1 / 0xA0C1)
    if(ZeroFlag) {
      goto label_0000_A0D8_0A0D8;
    }
    CheckExternalEvents(cs1, 0xA0C6);
    // CMP AX,0x1 (0000_A0C3 / 0xA0C3)
    Alu16.Sub(AX, 0x1);
    CheckExternalEvents(cs1, 0xA0C8);
    // JZ 0x0000:a105 (0000_A0C6 / 0xA0C6)
    if(ZeroFlag) {
      goto label_0000_A105_0A105;
    }
    CheckExternalEvents(cs1, 0xA0CB);
    // CMP AX,0x2 (0000_A0C8 / 0xA0C8)
    Alu16.Sub(AX, 0x2);
    CheckExternalEvents(cs1, 0xA0CD);
    // JGE 0x0000:a0d0 (0000_A0CB / 0xA0CB)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A0D0_0A0D0;
    }
    CheckExternalEvents(cs1, 0xA0D0);
    // JMP 0x0000:a1dd (0000_A0CD / 0xA0CD)
    goto label_0000_A1DD_0A1DD;
    label_0000_A0D0_0A0D0:
    CheckExternalEvents(cs1, 0xA0D3);
    // CMP AX,0x7 (0000_A0D0 / 0xA0D0)
    Alu16.Sub(AX, 0x7);
    CheckExternalEvents(cs1, 0xA0D5);
    // JLE 0x0000:a140 (0000_A0D3 / 0xA0D3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_A140_0A140;
    }
    CheckExternalEvents(cs1, 0xA0D8);
    // JMP 0x0000:a1dd (0000_A0D5 / 0xA0D5)
    goto label_0000_A1DD_0A1DD;
    label_0000_A0D8_0A0D8:
    CheckExternalEvents(cs1, 0xA0DE);
    // CMP byte ptr ES:[0xc724],0x4c (0000_A0D8 / 0xA0D8)
    Alu8.Sub(UInt8[ES, 0xC724], 0x4C);
    CheckExternalEvents(cs1, 0xA0E0);
    // JNZ 0x0000:a0e4 (0000_A0DE / 0xA0DE)
    if(!ZeroFlag) {
      goto label_0000_A0E4_0A0E4;
    }
    CheckExternalEvents(cs1, 0xA0E4);
    // SUB word ptr [BP + -0x14],0x32 (0000_A0E0 / 0xA0E0)
    UInt16[SS, (ushort)(BP - 0x14)] -= 0x32;
    label_0000_A0E4_0A0E4:
    CheckExternalEvents(cs1, 0xA0E8);
    // CMP word ptr [BP + -0x2],0x0 (0000_A0E4 / 0xA0E4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2)], 0x0);
    CheckExternalEvents(cs1, 0xA0EA);
    // JZ 0x0000:a0f7 (0000_A0E8 / 0xA0E8)
    if(ZeroFlag) {
      goto label_0000_A0F7_0A0F7;
    }
    CheckExternalEvents(cs1, 0xA0EF);
    // CMP word ptr [BP + -0x14],0xd7 (0000_A0EA / 0xA0EA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x14)], 0xD7);
    CheckExternalEvents(cs1, 0xA0F1);
    // JGE 0x0000:a0f7 (0000_A0EF / 0xA0EF)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A0F7_0A0F7;
    }
    CheckExternalEvents(cs1, 0xA0F7);
    // MOV byte ptr ES:[0xd30d],0x1 (0000_A0F1 / 0xA0F1)
    UInt8[ES, 0xD30D] = 0x1;
    label_0000_A0F7_0A0F7:
    CheckExternalEvents(cs1, 0xA0FB);
    // MOV ES,word ptr [0x5470] (0000_A0F7 / 0xA0F7)
    ES = UInt16[DS, 0x5470];
    CheckExternalEvents(cs1, 0xA0FE);
    // MOV AL,byte ptr [BP + -0x18] (0000_A0FB / 0xA0FB)
    AL = UInt8[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xA102);
    // MOV ES:[0x200a],AL (0000_A0FE / 0xA0FE)
    UInt8[ES, 0x200A] = AL;
    CheckExternalEvents(cs1, 0xA105);
    // JMP 0x0000:a1dd (0000_A102 / 0xA102)
    goto label_0000_A1DD_0A1DD;
    label_0000_A105_0A105:
    CheckExternalEvents(cs1, 0xA108);
    // MOV AL,byte ptr [BP + -0x18] (0000_A105 / 0xA105)
    AL = UInt8[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs1, 0xA10B);
    // MOV BX,word ptr [BP + -0x4] (0000_A108 / 0xA108)
    BX = UInt16[SS, (ushort)(BP - 0x4)];
    CheckExternalEvents(cs1, 0xA10F);
    // MOV ES,word ptr [0x5470] (0000_A10B / 0xA10B)
    ES = UInt16[DS, 0x5470];
    CheckExternalEvents(cs1, 0xA114);
    // MOV byte ptr ES:[BX + 0x101d],AL (0000_A10F / 0xA10F)
    UInt8[ES, (ushort)(BX + 0x101D)] = AL;
    CheckExternalEvents(cs1, 0xA118);
    // MOV ES,word ptr [0x545c] (0000_A114 / 0xA114)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA11E);
    // CMP byte ptr ES:[0xc724],0x4c (0000_A118 / 0xA118)
    Alu8.Sub(UInt8[ES, 0xC724], 0x4C);
    CheckExternalEvents(cs1, 0xA120);
    // JZ 0x0000:a126 (0000_A11E / 0xA11E)
    if(ZeroFlag) {
      goto label_0000_A126_0A126;
    }
    CheckExternalEvents(cs1, 0xA126);
    // MOV byte ptr ES:[0xd30d],0x1 (0000_A120 / 0xA120)
    UInt8[ES, 0xD30D] = 0x1;
    label_0000_A126_0A126:
    CheckExternalEvents(cs1, 0xA12A);
    // MOV AL,ES:[0xc61c] (0000_A126 / 0xA126)
    AL = UInt8[ES, 0xC61C];
    CheckExternalEvents(cs1, 0xA12B);
    // CBW  (0000_A12A / 0xA12A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA12E);
    // MOV word ptr [BP + -0x14],AX (0000_A12B / 0xA12B)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xA131);
    // CMP AX,0x3 (0000_A12E / 0xA12E)
    Alu16.Sub(AX, 0x3);
    CheckExternalEvents(cs1, 0xA133);
    // JGE 0x0000:a136 (0000_A131 / 0xA131)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A136_0A136;
    }
    CheckExternalEvents(cs1, 0xA136);
    // INC word ptr [BP + -0x14] (0000_A133 / 0xA133)
    UInt16[SS, (ushort)(BP - 0x14)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x14)]);
    label_0000_A136_0A136:
    CheckExternalEvents(cs1, 0xA139);
    // MOV AL,byte ptr [BP + -0x14] (0000_A136 / 0xA136)
    AL = UInt8[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xA13D);
    // MOV ES:[0xc61c],AL (0000_A139 / 0xA139)
    UInt8[ES, 0xC61C] = AL;
    CheckExternalEvents(cs1, 0xA140);
    // JMP 0x0000:a1dd (0000_A13D / 0xA13D)
    goto label_0000_A1DD_0A1DD;
    label_0000_A140_0A140:
    CheckExternalEvents(cs1, 0xA146);
    // CMP byte ptr ES:[0xc724],0xff (0000_A140 / 0xA140)
    Alu8.Sub(UInt8[ES, 0xC724], 0xFF);
    CheckExternalEvents(cs1, 0xA148);
    // JZ 0x0000:a15e (0000_A146 / 0xA146)
    if(ZeroFlag) {
      goto label_0000_A15E_0A15E;
    }
    CheckExternalEvents(cs1, 0xA14C);
    // MOV ES,word ptr [0x547c] (0000_A148 / 0xA148)
    ES = UInt16[DS, 0x547C];
    CheckExternalEvents(cs1, 0xA152);
    // CMP word ptr ES:[0x3992],0x0 (0000_A14C / 0xA14C)
    Alu16.Sub(UInt16[ES, 0x3992], 0x0);
    CheckExternalEvents(cs1, 0xA154);
    // JNZ 0x0000:a15e (0000_A152 / 0xA152)
    if(!ZeroFlag) {
      goto label_0000_A15E_0A15E;
    }
    CheckExternalEvents(cs1, 0xA158);
    // MOV ES,word ptr [0x545c] (0000_A154 / 0xA154)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA15E);
    // MOV byte ptr ES:[0xd30d],0x1 (0000_A158 / 0xA158)
    UInt8[ES, 0xD30D] = 0x1;
    label_0000_A15E_0A15E:
    CheckExternalEvents(cs1, 0xA162);
    // CMP word ptr [BP + 0x6],0x4 (0000_A15E / 0xA15E)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs1, 0xA164);
    // JLE 0x0000:a1ae (0000_A162 / 0xA162)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_A1AE_0A1AE;
    }
    CheckExternalEvents(cs1, 0xA168);
    // MOV ES,word ptr [0x545c] (0000_A164 / 0xA164)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA16C);
    // MOV AL,ES:[0xc61b] (0000_A168 / 0xA168)
    AL = UInt8[ES, 0xC61B];
    CheckExternalEvents(cs1, 0xA16D);
    // CBW  (0000_A16C / 0xA16C)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA170);
    // MOV word ptr [BP + -0x14],AX (0000_A16D / 0xA16D)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xA173);
    // CMP AX,0x4 (0000_A170 / 0xA170)
    Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs1, 0xA175);
    // JGE 0x0000:a180 (0000_A173 / 0xA173)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A180_0A180;
    }
    CheckExternalEvents(cs1, 0xA17A);
    // CALLF 0x1000:aab0 (0000_A175 / 0xA175)
    FarCall(cs1, 0xA17A, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA17D);
    // AND AX,0x1 (0000_A17A / 0xA17A)
    AX &= 0x1;
    CheckExternalEvents(cs1, 0xA180);
    // ADD word ptr [BP + -0x14],AX (0000_A17D / 0xA17D)
    // UInt16[SS, (ushort)(BP - 0x14)] += AX;
    UInt16[SS, (ushort)(BP - 0x14)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x14)], AX);
    label_0000_A180_0A180:
    CheckExternalEvents(cs1, 0xA184);
    // MOV ES,word ptr [0x545c] (0000_A180 / 0xA180)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA187);
    // MOV AL,byte ptr [BP + -0x14] (0000_A184 / 0xA184)
    AL = UInt8[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xA18B);
    // MOV ES:[0xc61b],AL (0000_A187 / 0xA187)
    UInt8[ES, 0xC61B] = AL;
    CheckExternalEvents(cs1, 0xA18F);
    // MOV AL,ES:[0xc61c] (0000_A18B / 0xA18B)
    AL = UInt8[ES, 0xC61C];
    CheckExternalEvents(cs1, 0xA190);
    // CBW  (0000_A18F / 0xA18F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA193);
    // MOV word ptr [BP + -0x14],AX (0000_A190 / 0xA190)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xA196);
    // CMP AX,0x4 (0000_A193 / 0xA193)
    Alu16.Sub(AX, 0x4);
    CheckExternalEvents(cs1, 0xA198);
    // JGE 0x0000:a1a3 (0000_A196 / 0xA196)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A1A3_0A1A3;
    }
    CheckExternalEvents(cs1, 0xA19D);
    // CALLF 0x1000:aab0 (0000_A198 / 0xA198)
    FarCall(cs1, 0xA19D, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA1A0);
    // AND AX,0x1 (0000_A19D / 0xA19D)
    AX &= 0x1;
    CheckExternalEvents(cs1, 0xA1A3);
    // ADD word ptr [BP + -0x14],AX (0000_A1A0 / 0xA1A0)
    // UInt16[SS, (ushort)(BP - 0x14)] += AX;
    UInt16[SS, (ushort)(BP - 0x14)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x14)], AX);
    label_0000_A1A3_0A1A3:
    CheckExternalEvents(cs1, 0xA1A7);
    // MOV ES,word ptr [0x545c] (0000_A1A3 / 0xA1A3)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA1AA);
    // MOV AL,byte ptr [BP + -0x14] (0000_A1A7 / 0xA1A7)
    AL = UInt8[SS, (ushort)(BP - 0x14)];
    CheckExternalEvents(cs1, 0xA1AE);
    // MOV ES:[0xc61c],AL (0000_A1AA / 0xA1AA)
    UInt8[ES, 0xC61C] = AL;
    label_0000_A1AE_0A1AE:
    CheckExternalEvents(cs1, 0xA1B2);
    // MOV ES,word ptr [0x5474] (0000_A1AE / 0xA1AE)
    ES = UInt16[DS, 0x5474];
    CheckExternalEvents(cs1, 0xA1B8);
    // CMP word ptr ES:[0x3772],0x0 (0000_A1B2 / 0xA1B2)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs1, 0xA1BA);
    // JZ 0x0000:a1d2 (0000_A1B8 / 0xA1B8)
    if(ZeroFlag) {
      goto label_0000_A1D2_0A1D2;
    }
    CheckExternalEvents(cs1, 0xA1BE);
    // MOV ES,word ptr [0x545c] (0000_A1BA / 0xA1BA)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA1C4);
    // MOV byte ptr ES:[0xd310],0x1 (0000_A1BE / 0xA1BE)
    UInt8[ES, 0xD310] = 0x1;
    CheckExternalEvents(cs1, 0xA1CA);
    // CMP byte ptr ES:[0xc724],0xff (0000_A1C4 / 0xA1C4)
    Alu8.Sub(UInt8[ES, 0xC724], 0xFF);
    CheckExternalEvents(cs1, 0xA1CC);
    // JZ 0x0000:a1d2 (0000_A1CA / 0xA1CA)
    if(ZeroFlag) {
      goto label_0000_A1D2_0A1D2;
    }
    CheckExternalEvents(cs1, 0xA1D2);
    // MOV byte ptr ES:[0xd311],0x1 (0000_A1CC / 0xA1CC)
    UInt8[ES, 0xD311] = 0x1;
    label_0000_A1D2_0A1D2:
    CheckExternalEvents(cs1, 0xA1D6);
    // MOV ES,word ptr [0x5474] (0000_A1D2 / 0xA1D2)
    ES = UInt16[DS, 0x5474];
    CheckExternalEvents(cs1, 0xA1DD);
    // MOV word ptr ES:[0x3772],0x0 (0000_A1D6 / 0xA1D6)
    UInt16[ES, 0x3772] = 0x0;
    label_0000_A1DD_0A1DD:
    CheckExternalEvents(cs1, 0xA1E1);
    // MOV ES,word ptr [0x5476] (0000_A1DD / 0xA1DD)
    ES = UInt16[DS, 0x5476];
    CheckExternalEvents(cs1, 0xA1E8);
    // MOV word ptr ES:[0x398e],0x0 (0000_A1E1 / 0xA1E1)
    UInt16[ES, 0x398E] = 0x0;
    CheckExternalEvents(cs1, 0xA1EC);
    // MOV ES,word ptr [0x547e] (0000_A1E8 / 0xA1E8)
    ES = UInt16[DS, 0x547E];
    CheckExternalEvents(cs1, 0xA1F2);
    // CMP word ptr ES:[0x4594],0x0 (0000_A1EC / 0xA1EC)
    Alu16.Sub(UInt16[ES, 0x4594], 0x0);
    CheckExternalEvents(cs1, 0xA1F4);
    // JZ 0x0000:a204 (0000_A1F2 / 0xA1F2)
    if(ZeroFlag) {
      goto label_0000_A204_0A204;
    }
    CheckExternalEvents(cs1, 0xA1F8);
    // MOV ES,word ptr [0x5480] (0000_A1F4 / 0xA1F4)
    ES = UInt16[DS, 0x5480];
    CheckExternalEvents(cs1, 0xA1FD);
    // PUSH word ptr ES:[0x3ff8] (0000_A1F8 / 0xA1F8)
    Stack.Push16(UInt16[ES, 0x3FF8]);
    CheckExternalEvents(cs1, 0xA1FE);
    // PUSH CS (0000_A1FD / 0xA1FD)
    Stack.Push16(cs1);
    CheckExternalEvents(cs1, 0xA201);
    // CALL 0x0000:b1f0 (0000_A1FE / 0xA1FE)
    NearCall(cs1, 0xA201, unknown_094C_1D30_0B1F0);
    CheckExternalEvents(cs1, 0xA204);
    // ADD SP,0x2 (0000_A201 / 0xA201)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_0000_A204_0A204:
    CheckExternalEvents(cs1, 0xA205);
    // POP SI (0000_A204 / 0xA204)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xA207);
    // MOV SP,BP (0000_A205 / 0xA205)
    SP = BP;
    CheckExternalEvents(cs1, 0xA208);
    // POP BP (0000_A207 / 0xA207)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xA209);
    // RETF  (0000_A208 / 0xA208)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_0000_A209_0A209(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_0000_A209_0A209:
    CheckExternalEvents(cs1, 0xA20A);
    // PUSH BP (0000_A209 / 0xA209)
    Stack.Push16(BP);
    CheckExternalEvents(cs1, 0xA20C);
    // MOV BP,SP (0000_A20A / 0xA20A)
    BP = SP;
    CheckExternalEvents(cs1, 0xA20F);
    // MOV AX,0x1a (0000_A20C / 0xA20C)
    AX = 0x1A;
    CheckExternalEvents(cs1, 0xA214);
    // CALLF 0x1000:cecc (0000_A20F / 0xA20F)
    FarCall(cs1, 0xA214, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs1, 0xA215);
    // PUSH DI (0000_A214 / 0xA214)
    Stack.Push16(DI);
    CheckExternalEvents(cs1, 0xA216);
    // PUSH SI (0000_A215 / 0xA215)
    Stack.Push16(SI);
    CheckExternalEvents(cs1, 0xA21B);
    // MOV word ptr [BP + -0x4],0x2f0 (0000_A216 / 0xA216)
    UInt16[SS, (ushort)(BP - 0x4)] = 0x2F0;
    CheckExternalEvents(cs1, 0xA220);
    // MOV word ptr [BP + -0x2],0x2958 (0000_A21B / 0xA21B)
    UInt16[SS, (ushort)(BP - 0x2)] = 0x2958;
    CheckExternalEvents(cs1, 0xA224);
    // MOV ES,word ptr [0x5482] (0000_A220 / 0xA220)
    ES = UInt16[DS, 0x5482];
    CheckExternalEvents(cs1, 0xA226);
    // SUB AX,AX (0000_A224 / 0xA224)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xA229);
    // MOV word ptr [BP + -0x6],AX (0000_A226 / 0xA226)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0xA22D);
    // MOV ES:[0x3994],AL (0000_A229 / 0xA229)
    UInt8[ES, 0x3994] = AL;
    CheckExternalEvents(cs1, 0xA230);
    // MOV word ptr [BP + -0xe],AX (0000_A22D / 0xA22D)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    label_0000_A230_0A230:
    CheckExternalEvents(cs1, 0xA233);
    // MOV SI,word ptr [BP + -0xe] (0000_A230 / 0xA230)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA235);
    // SHL SI,0x1 (0000_A233 / 0xA233)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xA238);
    // MOV AX,0x1a (0000_A235 / 0xA235)
    AX = 0x1A;
    CheckExternalEvents(cs1, 0xA23B);
    // IMUL word ptr [BP + -0xe] (0000_A238 / 0xA238)
    int resImul0000_A238 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A238);
    DX = (ushort)(resImul0000_A238 >> 16);
    CheckExternalEvents(cs1, 0xA23D);
    // MOV DI,AX (0000_A23B / 0xA23B)
    DI = AX;
    CheckExternalEvents(cs1, 0xA241);
    // MOV ES,word ptr [0x5484] (0000_A23D / 0xA23D)
    ES = UInt16[DS, 0x5484];
    CheckExternalEvents(cs1, 0xA246);
    // MOV AX,word ptr ES:[SI + 0x4024] (0000_A241 / 0xA241)
    AX = UInt16[ES, (ushort)(SI + 0x4024)];
    CheckExternalEvents(cs1, 0xA24A);
    // MOV ES,word ptr [0x545c] (0000_A246 / 0xA246)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA24F);
    // MOV word ptr ES:[DI + 0xd390],AX (0000_A24A / 0xA24A)
    UInt16[ES, (ushort)(DI + 0xD390)] = AX;
    CheckExternalEvents(cs1, 0xA253);
    // MOV ES,word ptr [0x5486] (0000_A24F / 0xA24F)
    ES = UInt16[DS, 0x5486];
    CheckExternalEvents(cs1, 0xA258);
    // MOV AX,word ptr ES:[SI + 0x4056] (0000_A253 / 0xA253)
    AX = UInt16[ES, (ushort)(SI + 0x4056)];
    CheckExternalEvents(cs1, 0xA25C);
    // MOV ES,word ptr [0x545c] (0000_A258 / 0xA258)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA261);
    // MOV word ptr ES:[DI + 0xd392],AX (0000_A25C / 0xA25C)
    UInt16[ES, (ushort)(DI + 0xD392)] = AX;
    CheckExternalEvents(cs1, 0xA264);
    // INC word ptr [BP + -0xe] (0000_A261 / 0xA261)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xA268);
    // CMP word ptr [BP + -0xe],0x8 (0000_A264 / 0xA264)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x8);
    CheckExternalEvents(cs1, 0xA26A);
    // JL 0x0000:a230 (0000_A268 / 0xA268)
    if(SignFlag != OverflowFlag) {
      goto label_0000_A230_0A230;
    }
    CheckExternalEvents(cs1, 0xA26F);
    // MOV word ptr [BP + -0xe],0x0 (0000_A26A / 0xA26A)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0000_A26F_0A26F:
    CheckExternalEvents(cs1, 0xA272);
    // MOV AX,0x7d (0000_A26F / 0xA26F)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA275);
    // IMUL word ptr [BP + -0xe] (0000_A272 / 0xA272)
    int resImul0000_A272 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A272);
    DX = (ushort)(resImul0000_A272 >> 16);
    CheckExternalEvents(cs1, 0xA277);
    // MOV BX,AX (0000_A275 / 0xA275)
    BX = AX;
    CheckExternalEvents(cs1, 0xA27B);
    // MOV ES,word ptr [0x545c] (0000_A277 / 0xA277)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA281);
    // MOV byte ptr ES:[BX + 0xc918],0xff (0000_A27B / 0xA27B)
    UInt8[ES, (ushort)(BX + 0xC918)] = 0xFF;
    CheckExternalEvents(cs1, 0xA284);
    // INC word ptr [BP + -0xe] (0000_A281 / 0xA281)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xA288);
    // CMP word ptr [BP + -0xe],0x4 (0000_A284 / 0xA284)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x4);
    CheckExternalEvents(cs1, 0xA28A);
    // JL 0x0000:a26f (0000_A288 / 0xA288)
    if(SignFlag != OverflowFlag) {
      goto label_0000_A26F_0A26F;
    }
    CheckExternalEvents(cs1, 0xA28F);
    // MOV word ptr [BP + -0xe],0x8 (0000_A28A / 0xA28A)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x8;
    label_0000_A28F_0A28F:
    CheckExternalEvents(cs1, 0xA292);
    // MOV AX,0x11 (0000_A28F / 0xA28F)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xA295);
    // IMUL word ptr [BP + -0xe] (0000_A292 / 0xA292)
    int resImul0000_A292 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A292);
    DX = (ushort)(resImul0000_A292 >> 16);
    CheckExternalEvents(cs1, 0xA297);
    // MOV BX,AX (0000_A295 / 0xA295)
    BX = AX;
    CheckExternalEvents(cs1, 0xA29B);
    // MOV ES,word ptr [0x545c] (0000_A297 / 0xA297)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA2A1);
    // MOV byte ptr ES:[BX + 0xc614],0xff (0000_A29B / 0xA29B)
    UInt8[ES, (ushort)(BX + 0xC614)] = 0xFF;
    CheckExternalEvents(cs1, 0xA2A4);
    // INC word ptr [BP + -0xe] (0000_A2A1 / 0xA2A1)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xA2A8);
    // CMP word ptr [BP + -0xe],0x10 (0000_A2A4 / 0xA2A4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x10);
    CheckExternalEvents(cs1, 0xA2AA);
    // JL 0x0000:a28f (0000_A2A8 / 0xA2A8)
    if(SignFlag != OverflowFlag) {
      goto label_0000_A28F_0A28F;
    }
    CheckExternalEvents(cs1, 0xA2AF);
    // MOV word ptr [BP + -0xe],0x0 (0000_A2AA / 0xA2AA)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0000_A2AF_0A2AF:
    CheckExternalEvents(cs1, 0xA2B2);
    // MOV SI,word ptr [BP + -0xe] (0000_A2AF / 0xA2AF)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA2B4);
    // SHL SI,0x1 (0000_A2B2 / 0xA2B2)
    SI <<= 0x1;
    CheckExternalEvents(cs1, 0xA2B6);
    // SUB AX,AX (0000_A2B4 / 0xA2B4)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs1, 0xA2BA);
    // MOV ES,word ptr [0x5488] (0000_A2B6 / 0xA2B6)
    ES = UInt16[DS, 0x5488];
    CheckExternalEvents(cs1, 0xA2BF);
    // MOV word ptr ES:[SI + 0x393c],AX (0000_A2BA / 0xA2BA)
    UInt16[ES, (ushort)(SI + 0x393C)] = AX;
    CheckExternalEvents(cs1, 0xA2C3);
    // MOV ES,word ptr [0x548a] (0000_A2BF / 0xA2BF)
    ES = UInt16[DS, 0x548A];
    CheckExternalEvents(cs1, 0xA2C8);
    // MOV word ptr ES:[SI + 0x406a],AX (0000_A2C3 / 0xA2C3)
    UInt16[ES, (ushort)(SI + 0x406A)] = AX;
    CheckExternalEvents(cs1, 0xA2CB);
    // MOV AX,0xffff (0000_A2C8 / 0xA2C8)
    AX = 0xFFFF;
    CheckExternalEvents(cs1, 0xA2CF);
    // MOV ES,word ptr [0x5486] (0000_A2CB / 0xA2CB)
    ES = UInt16[DS, 0x5486];
    CheckExternalEvents(cs1, 0xA2D4);
    // MOV word ptr ES:[SI + 0x4036],AX (0000_A2CF / 0xA2CF)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs1, 0xA2D8);
    // MOV ES,word ptr [0x5484] (0000_A2D4 / 0xA2D4)
    ES = UInt16[DS, 0x5484];
    CheckExternalEvents(cs1, 0xA2DD);
    // MOV word ptr ES:[SI + 0x4004],AX (0000_A2D8 / 0xA2D8)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs1, 0xA2E0);
    // INC word ptr [BP + -0xe] (0000_A2DD / 0xA2DD)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xA2E4);
    // CMP word ptr [BP + -0xe],0x18 (0000_A2E0 / 0xA2E0)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x18);
    CheckExternalEvents(cs1, 0xA2E6);
    // JL 0x0000:a2af (0000_A2E4 / 0xA2E4)
    if(SignFlag != OverflowFlag) {
      goto label_0000_A2AF_0A2AF;
    }
    CheckExternalEvents(cs1, 0xA2EB);
    // CMP word ptr [BP + 0x8],0x80 (0000_A2E6 / 0xA2E6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x80);
    CheckExternalEvents(cs1, 0xA2ED);
    // JGE 0x0000:a2fa (0000_A2EB / 0xA2EB)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A2FA_0A2FA;
    }
    CheckExternalEvents(cs1, 0xA2F1);
    // MOV ES,word ptr [0x548a] (0000_A2ED / 0xA2ED)
    ES = UInt16[DS, 0x548A];
    CheckExternalEvents(cs1, 0xA2F8);
    // MOV word ptr ES:[0x406a],0x1 (0000_A2F1 / 0xA2F1)
    UInt16[ES, 0x406A] = 0x1;
    CheckExternalEvents(cs1, 0xA2FA);
    // JMP 0x0000:a305 (0000_A2F8 / 0xA2F8)
    goto label_0000_A305_0A305;
    label_0000_A2FA_0A2FA:
    CheckExternalEvents(cs1, 0xA2FE);
    // MOV ES,word ptr [0x548a] (0000_A2FA / 0xA2FA)
    ES = UInt16[DS, 0x548A];
    CheckExternalEvents(cs1, 0xA305);
    // MOV word ptr ES:[0x4072],0x1 (0000_A2FE / 0xA2FE)
    UInt16[ES, 0x4072] = 0x1;
    label_0000_A305_0A305:
    CheckExternalEvents(cs1, 0xA309);
    // TEST byte ptr [BP + 0x6],0x80 (0000_A305 / 0xA305)
    Alu8.And(UInt8[SS, (ushort)(BP + 0x6)], 0x80);
    CheckExternalEvents(cs1, 0xA30B);
    // JNZ 0x0000:a30e (0000_A309 / 0xA309)
    if(!ZeroFlag) {
      goto label_0000_A30E_0A30E;
    }
    CheckExternalEvents(cs1, 0xA30E);
    // JMP 0x0000:a3b5 (0000_A30B / 0xA30B)
    goto label_0000_A3B5_0A3B5;
    label_0000_A30E_0A30E:
    CheckExternalEvents(cs1, 0xA313);
    // CALLF 0x1000:aab0 (0000_A30E / 0xA30E)
    FarCall(cs1, 0xA313, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA316);
    // AND AX,0x3 (0000_A313 / 0xA313)
    AX &= 0x3;
    CheckExternalEvents(cs1, 0xA319);
    // ADD AX,0xa10 (0000_A316 / 0xA316)
    // AX += 0xA10;
    AX = Alu16.Add(AX, 0xA10);
    CheckExternalEvents(cs1, 0xA31C);
    // MOV word ptr [BP + -0x10],AX (0000_A319 / 0xA319)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xA321);
    // CALLF 0x1000:aab0 (0000_A31C / 0xA31C)
    FarCall(cs1, 0xA321, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA323);
    // TEST AL,0x1 (0000_A321 / 0xA321)
    Alu8.And(AL, 0x1);
    CheckExternalEvents(cs1, 0xA325);
    // JZ 0x0000:a333 (0000_A323 / 0xA323)
    if(ZeroFlag) {
      goto label_0000_A333_0A333;
    }
    CheckExternalEvents(cs1, 0xA32A);
    // CALLF 0x1000:aab0 (0000_A325 / 0xA325)
    FarCall(cs1, 0xA32A, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA32D);
    // AND AX,0x3 (0000_A32A / 0xA32A)
    AX &= 0x3;
    CheckExternalEvents(cs1, 0xA330);
    // ADD AX,0xa28 (0000_A32D / 0xA32D)
    // AX += 0xA28;
    AX = Alu16.Add(AX, 0xA28);
    CheckExternalEvents(cs1, 0xA333);
    // MOV word ptr [BP + -0x10],AX (0000_A330 / 0xA330)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    label_0000_A333_0A333:
    CheckExternalEvents(cs1, 0xA338);
    // CALLF 0x1000:aab0 (0000_A333 / 0xA333)
    FarCall(cs1, 0xA338, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA33B);
    // AND AX,0x3 (0000_A338 / 0xA338)
    AX &= 0x3;
    CheckExternalEvents(cs1, 0xA33E);
    // ADD AX,0x806f (0000_A33B / 0xA33B)
    // AX += 0x806F;
    AX = Alu16.Add(AX, 0x806F);
    CheckExternalEvents(cs1, 0xA341);
    // MOV word ptr [BP + -0x14],AX (0000_A33E / 0xA33E)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xA345);
    // MOV ES,word ptr [0x548c] (0000_A341 / 0xA341)
    ES = UInt16[DS, 0x548C];
    CheckExternalEvents(cs1, 0xA34B);
    // CMP word ptr ES:[0xe48e],0x0 (0000_A345 / 0xA345)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0xA34D);
    // JZ 0x0000:a36f (0000_A34B / 0xA34B)
    if(ZeroFlag) {
      goto label_0000_A36F_0A36F;
    }
    CheckExternalEvents(cs1, 0xA352);
    // MOV word ptr [BP + -0xe],0x0 (0000_A34D / 0xA34D)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    label_0000_A352_0A352:
    CheckExternalEvents(cs1, 0xA355);
    // MOV BX,word ptr [BP + -0xe] (0000_A352 / 0xA352)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA359);
    // MOV ES,word ptr [0x545c] (0000_A355 / 0xA355)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA35F);
    // CMP byte ptr ES:[BX + 0xd452],0xff (0000_A359 / 0xA359)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD452)], 0xFF);
    CheckExternalEvents(cs1, 0xA361);
    // JNZ 0x0000:a366 (0000_A35F / 0xA35F)
    if(!ZeroFlag) {
      goto label_0000_A366_0A366;
    }
    CheckExternalEvents(cs1, 0xA366);
    // MOV word ptr [BP + 0x6],0x2 (0000_A361 / 0xA361)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x2;
    label_0000_A366_0A366:
    CheckExternalEvents(cs1, 0xA369);
    // INC word ptr [BP + -0xe] (0000_A366 / 0xA366)
    UInt16[SS, (ushort)(BP - 0xE)]++;
    CheckExternalEvents(cs1, 0xA36D);
    // CMP word ptr [BP + -0xe],0x4 (0000_A369 / 0xA369)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x4);
    CheckExternalEvents(cs1, 0xA36F);
    // JL 0x0000:a352 (0000_A36D / 0xA36D)
    if(SignFlag != OverflowFlag) {
      goto label_0000_A352_0A352;
    }
    label_0000_A36F_0A36F:
    CheckExternalEvents(cs1, 0xA374);
    // CALLF 0x0000:30dd (0000_A36F / 0xA36F)
    FarCall(cs1, 0xA374, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs1, 0xA375);
    // DEC AX (0000_A374 / 0xA374)
    AX--;
    CheckExternalEvents(cs1, 0xA376);
    // DEC AX (0000_A375 / 0xA375)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs1, 0xA379);
    // MOV word ptr [BP + -0x8],AX (0000_A376 / 0xA376)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    CheckExternalEvents(cs1, 0xA37D);
    // MOV ES,word ptr [0x548c] (0000_A379 / 0xA379)
    ES = UInt16[DS, 0x548C];
    CheckExternalEvents(cs1, 0xA383);
    // CMP word ptr ES:[0xe48e],0x0 (0000_A37D / 0xA37D)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0xA385);
    // JZ 0x0000:a393 (0000_A383 / 0xA383)
    if(ZeroFlag) {
      goto label_0000_A393_0A393;
    }
    CheckExternalEvents(cs1, 0xA38A);
    // CALLF 0x1000:aab0 (0000_A385 / 0xA385)
    FarCall(cs1, 0xA38A, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA38D);
    // AND AX,0x3 (0000_A38A / 0xA38A)
    AX &= 0x3;
    CheckExternalEvents(cs1, 0xA390);
    // ADD AX,0x3 (0000_A38D / 0xA38D)
    // AX += 0x3;
    AX = Alu16.Add(AX, 0x3);
    CheckExternalEvents(cs1, 0xA393);
    // MOV word ptr [BP + -0x8],AX (0000_A390 / 0xA390)
    UInt16[SS, (ushort)(BP - 0x8)] = AX;
    label_0000_A393_0A393:
    CheckExternalEvents(cs1, 0xA396);
    // MOV BX,word ptr [BP + -0x8] (0000_A393 / 0xA393)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xA398);
    // SHL BX,0x1 (0000_A396 / 0xA396)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xA39A);
    // SHL BX,0x1 (0000_A398 / 0xA398)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xA39E);
    // MOV AX,word ptr [BX + 0x13e2] (0000_A39A / 0xA39A)
    AX = UInt16[DS, (ushort)(BX + 0x13E2)];
    CheckExternalEvents(cs1, 0xA3A2);
    // MOV DX,word ptr [BX + 0x13e4] (0000_A39E / 0xA39E)
    DX = UInt16[DS, (ushort)(BX + 0x13E4)];
    CheckExternalEvents(cs1, 0xA3A5);
    // MOV word ptr [BP + -0x4],AX (0000_A3A2 / 0xA3A2)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs1, 0xA3A8);
    // MOV word ptr [BP + -0x2],DX (0000_A3A5 / 0xA3A5)
    UInt16[SS, (ushort)(BP - 0x2)] = DX;
    CheckExternalEvents(cs1, 0xA3AB);
    // MOV BX,word ptr [BP + -0x8] (0000_A3A8 / 0xA3A8)
    BX = UInt16[SS, (ushort)(BP - 0x8)];
    CheckExternalEvents(cs1, 0xA3AF);
    // MOV AL,byte ptr [BX + 0x140e] (0000_A3AB / 0xA3AB)
    AL = UInt8[DS, (ushort)(BX + 0x140E)];
    CheckExternalEvents(cs1, 0xA3B0);
    // CBW  (0000_A3AF / 0xA3AF)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA3B3);
    // MOV word ptr [BP + -0x6],AX (0000_A3B0 / 0xA3B0)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs1, 0xA3B5);
    // JMP 0x0000:a3f2 (0000_A3B3 / 0xA3B3)
    goto label_0000_A3F2_0A3F2;
    label_0000_A3B5_0A3B5:
    CheckExternalEvents(cs1, 0xA3BA);
    // CALLF 0x1000:aab0 (0000_A3B5 / 0xA3B5)
    FarCall(cs1, 0xA3BA, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA3BD);
    // AND AX,0x7 (0000_A3BA / 0xA3BA)
    AX &= 0x7;
    CheckExternalEvents(cs1, 0xA3C0);
    // ADD AX,0xc65 (0000_A3BD / 0xA3BD)
    // AX += 0xC65;
    AX = Alu16.Add(AX, 0xC65);
    CheckExternalEvents(cs1, 0xA3C3);
    // MOV word ptr [BP + -0x10],AX (0000_A3C0 / 0xA3C0)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs1, 0xA3C8);
    // CALLF 0x1000:aab0 (0000_A3C3 / 0xA3C3)
    FarCall(cs1, 0xA3C8, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA3CB);
    // AND AX,0x7 (0000_A3C8 / 0xA3C8)
    AX &= 0x7;
    CheckExternalEvents(cs1, 0xA3CE);
    // ADD AX,0xc059 (0000_A3CB / 0xA3CB)
    // AX += 0xC059;
    AX = Alu16.Add(AX, 0xC059);
    CheckExternalEvents(cs1, 0xA3D1);
    // MOV word ptr [BP + -0x14],AX (0000_A3CE / 0xA3CE)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs1, 0xA3D5);
    // TEST byte ptr [BP + 0x8],0x80 (0000_A3D1 / 0xA3D1)
    Alu8.And(UInt8[SS, (ushort)(BP + 0x8)], 0x80);
    CheckExternalEvents(cs1, 0xA3D7);
    // JZ 0x0000:a3e1 (0000_A3D5 / 0xA3D5)
    if(ZeroFlag) {
      goto label_0000_A3E1_0A3E1;
    }
    CheckExternalEvents(cs1, 0xA3DC);
    // MOV word ptr [BP + -0x10],0xd10 (0000_A3D7 / 0xA3D7)
    UInt16[SS, (ushort)(BP - 0x10)] = 0xD10;
    CheckExternalEvents(cs1, 0xA3E1);
    // MOV word ptr [BP + -0x14],0x7024 (0000_A3DC / 0xA3DC)
    UInt16[SS, (ushort)(BP - 0x14)] = 0x7024;
    label_0000_A3E1_0A3E1:
    CheckExternalEvents(cs1, 0xA3E5);
    // MOV ES,word ptr [0x545c] (0000_A3E1 / 0xA3E1)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA3EB);
    // CMP byte ptr ES:[0xd30c],0x2 (0000_A3E5 / 0xA3E5)
    Alu8.Sub(UInt8[ES, 0xD30C], 0x2);
    CheckExternalEvents(cs1, 0xA3ED);
    // JNZ 0x0000:a3f2 (0000_A3EB / 0xA3EB)
    if(!ZeroFlag) {
      goto label_0000_A3F2_0A3F2;
    }
    CheckExternalEvents(cs1, 0xA3F2);
    // MOV word ptr [BP + -0x10],0xc72 (0000_A3ED / 0xA3ED)
    UInt16[SS, (ushort)(BP - 0x10)] = 0xC72;
    label_0000_A3F2_0A3F2:
    CheckExternalEvents(cs1, 0xA3F7);
    // MOV word ptr [BP + -0xc],0x8 (0000_A3F2 / 0xA3F2)
    UInt16[SS, (ushort)(BP - 0xC)] = 0x8;
    CheckExternalEvents(cs1, 0xA3FB);
    // AND word ptr [BP + 0x6],0x7f (0000_A3F7 / 0xA3F7)
    // UInt16[SS, (ushort)(BP + 0x6)] &= 0x7F;
    UInt16[SS, (ushort)(BP + 0x6)] = Alu16.And(UInt16[SS, (ushort)(BP + 0x6)], 0x7F);
    CheckExternalEvents(cs1, 0xA3FF);
    // MOV ES,word ptr [0x5474] (0000_A3FB / 0xA3FB)
    ES = UInt16[DS, 0x5474];
    CheckExternalEvents(cs1, 0xA405);
    // CMP word ptr ES:[0x3772],0x0 (0000_A3FF / 0xA3FF)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs1, 0xA407);
    // JZ 0x0000:a40c (0000_A405 / 0xA405)
    if(ZeroFlag) {
      goto label_0000_A40C_0A40C;
    }
    CheckExternalEvents(cs1, 0xA40C);
    // MOV word ptr [BP + 0x6],0x4 (0000_A407 / 0xA407)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x4;
    label_0000_A40C_0A40C:
    CheckExternalEvents(cs1, 0xA410);
    // CMP word ptr [BP + 0x6],0x0 (0000_A40C / 0xA40C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x0);
    CheckExternalEvents(cs1, 0xA412);
    // JNZ 0x0000:a415 (0000_A410 / 0xA410)
    if(!ZeroFlag) {
      goto label_0000_A415_0A415;
    }
    CheckExternalEvents(cs1, 0xA415);
    // JMP 0x0000:a6c8 (0000_A412 / 0xA412)
    goto label_0000_A6C8_0A6C8;
    label_0000_A415_0A415:
    CheckExternalEvents(cs1, 0xA41A);
    // MOV word ptr [BP + -0xe],0x0 (0000_A415 / 0xA415)
    UInt16[SS, (ushort)(BP - 0xE)] = 0x0;
    CheckExternalEvents(cs1, 0xA41D);
    // JMP 0x0000:a699 (0000_A41A / 0xA41A)
    goto label_0000_A699_0A699;
    label_0000_A41D_0A41D:
    CheckExternalEvents(cs1, 0xA420);
    // MOV BX,word ptr [BP + -0x12] (0000_A41D / 0xA41D)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xA424);
    // MOV ES,word ptr [0x548e] (0000_A420 / 0xA420)
    ES = UInt16[DS, 0x548E];
    CheckExternalEvents(cs1, 0xA429);
    // MOV AL,byte ptr ES:[BX + 0x561] (0000_A424 / 0xA424)
    AL = UInt8[ES, (ushort)(BX + 0x561)];
    label_0000_A429_0A429:
    CheckExternalEvents(cs1, 0xA42B);
    // MOV CX,AX (0000_A429 / 0xA429)
    CX = AX;
    CheckExternalEvents(cs1, 0xA42E);
    // MOV AX,0x7d (0000_A42B / 0xA42B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA431);
    // IMUL word ptr [BP + -0xe] (0000_A42E / 0xA42E)
    int resImul0000_A42E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A42E);
    DX = (ushort)(resImul0000_A42E >> 16);
    CheckExternalEvents(cs1, 0xA433);
    // MOV BX,AX (0000_A431 / 0xA431)
    BX = AX;
    CheckExternalEvents(cs1, 0xA436);
    // ADD BX,word ptr [BP + -0x12] (0000_A433 / 0xA433)
    // BX += UInt16[SS, (ushort)(BP - 0x12)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs1, 0xA43A);
    // MOV ES,word ptr [0x545c] (0000_A436 / 0xA436)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA43F);
    // MOV byte ptr ES:[BX + 0xc918],CL (0000_A43A / 0xA43A)
    UInt8[ES, (ushort)(BX + 0xC918)] = CL;
    CheckExternalEvents(cs1, 0xA443);
    // MOV ES,word ptr [0x548c] (0000_A43F / 0xA43F)
    ES = UInt16[DS, 0x548C];
    CheckExternalEvents(cs1, 0xA449);
    // CMP word ptr ES:[0xe48e],0x0 (0000_A443 / 0xA443)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0xA44B);
    // JZ 0x0000:a466 (0000_A449 / 0xA449)
    if(ZeroFlag) {
      goto label_0000_A466_0A466;
    }
    CheckExternalEvents(cs1, 0xA44F);
    // CMP word ptr [BP + -0xe],0x0 (0000_A44B / 0xA44B)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs1, 0xA451);
    // JZ 0x0000:a466 (0000_A44F / 0xA44F)
    if(ZeroFlag) {
      goto label_0000_A466_0A466;
    }
    CheckExternalEvents(cs1, 0xA454);
    // MOV BX,word ptr [BP + -0x12] (0000_A451 / 0xA451)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xA458);
    // MOV ES,word ptr [0x5490] (0000_A454 / 0xA454)
    ES = UInt16[DS, 0x5490];
    CheckExternalEvents(cs1, 0xA45D);
    // MOV AL,byte ptr ES:[BX + 0x5de] (0000_A458 / 0xA458)
    AL = UInt8[ES, (ushort)(BX + 0x5DE)];
    CheckExternalEvents(cs1, 0xA461);
    // MOV ES,word ptr [0x545c] (0000_A45D / 0xA45D)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA466);
    // MOV byte ptr ES:[BX + 0xc995],AL (0000_A461 / 0xA461)
    UInt8[ES, (ushort)(BX + 0xC995)] = AL;
    label_0000_A466_0A466:
    CheckExternalEvents(cs1, 0xA469);
    // INC word ptr [BP + -0x12] (0000_A466 / 0xA466)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    label_0000_A469_0A469:
    CheckExternalEvents(cs1, 0xA46D);
    // CMP word ptr [BP + -0x12],0x7d (0000_A469 / 0xA469)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x7D);
    CheckExternalEvents(cs1, 0xA46F);
    // JGE 0x0000:a486 (0000_A46D / 0xA46D)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A486_0A486;
    }
    CheckExternalEvents(cs1, 0xA473);
    // MOV ES,word ptr [0x5474] (0000_A46F / 0xA46F)
    ES = UInt16[DS, 0x5474];
    CheckExternalEvents(cs1, 0xA479);
    // CMP word ptr ES:[0x3772],0x0 (0000_A473 / 0xA473)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs1, 0xA47B);
    // JNZ 0x0000:a41d (0000_A479 / 0xA479)
    if(!ZeroFlag) {
      goto label_0000_A41D_0A41D;
    }
    CheckExternalEvents(cs1, 0xA47E);
    // MOV BX,word ptr [BP + -0x12] (0000_A47B / 0xA47B)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xA481);
    // LES SI,[BP + -0x4] (0000_A47E / 0xA47E)
    SI = UInt16[SS, (ushort)(BP - 0x4)];
    ES = UInt16[SS, (ushort)(BP - 0x4 + 2)];
    CheckExternalEvents(cs1, 0xA484);
    // MOV AL,byte ptr ES:[BX + SI] (0000_A481 / 0xA481)
    AL = UInt8[ES, (ushort)(BX + SI)];
    CheckExternalEvents(cs1, 0xA486);
    // JMP 0x0000:a429 (0000_A484 / 0xA484)
    goto label_0000_A429_0A429;
    label_0000_A486_0A486:
    CheckExternalEvents(cs1, 0xA48A);
    // MOV ES,word ptr [0x5474] (0000_A486 / 0xA486)
    ES = UInt16[DS, 0x5474];
    CheckExternalEvents(cs1, 0xA490);
    // CMP word ptr ES:[0x3772],0x0 (0000_A48A / 0xA48A)
    Alu16.Sub(UInt16[ES, 0x3772], 0x0);
    CheckExternalEvents(cs1, 0xA492);
    // JZ 0x0000:a49c (0000_A490 / 0xA490)
    if(ZeroFlag) {
      goto label_0000_A49C_0A49C;
    }
    CheckExternalEvents(cs1, 0xA496);
    // MOV ES,word ptr [0x545c] (0000_A492 / 0xA492)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA49C);
    // MOV byte ptr ES:[0xd30f],0x0 (0000_A496 / 0xA496)
    UInt8[ES, 0xD30F] = 0x0;
    label_0000_A49C_0A49C:
    CheckExternalEvents(cs1, 0xA4A0);
    // MOV ES,word ptr [0x545c] (0000_A49C / 0xA49C)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA4A6);
    // CMP byte ptr ES:[0xd30f],0x6 (0000_A4A0 / 0xA4A0)
    Alu8.Sub(UInt8[ES, 0xD30F], 0x6);
    CheckExternalEvents(cs1, 0xA4A8);
    // JLE 0x0000:a4ae (0000_A4A6 / 0xA4A6)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_A4AE_0A4AE;
    }
    CheckExternalEvents(cs1, 0xA4AE);
    // MOV byte ptr ES:[0xd30f],0x6 (0000_A4A8 / 0xA4A8)
    UInt8[ES, 0xD30F] = 0x6;
    label_0000_A4AE_0A4AE:
    CheckExternalEvents(cs1, 0xA4B3);
    // MOV word ptr [BP + -0x12],0x11 (0000_A4AE / 0xA4AE)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x11;
    CheckExternalEvents(cs1, 0xA4B5);
    // JMP 0x0000:a4cd (0000_A4B3 / 0xA4B3)
    goto label_0000_A4CD_0A4CD;
    label_0000_A4B5_0A4B5:
    CheckExternalEvents(cs1, 0xA4B8);
    // MOV AX,0x7d (0000_A4B5 / 0xA4B5)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA4BB);
    // IMUL word ptr [BP + -0xe] (0000_A4B8 / 0xA4B8)
    int resImul0000_A4B8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A4B8);
    DX = (ushort)(resImul0000_A4B8 >> 16);
    CheckExternalEvents(cs1, 0xA4BD);
    // MOV BX,AX (0000_A4BB / 0xA4BB)
    BX = AX;
    CheckExternalEvents(cs1, 0xA4C0);
    // ADD BX,word ptr [BP + -0x12] (0000_A4BD / 0xA4BD)
    // BX += UInt16[SS, (ushort)(BP - 0x12)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs1, 0xA4C4);
    // MOV ES,word ptr [0x545c] (0000_A4C0 / 0xA4C0)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA4CA);
    // MOV byte ptr ES:[BX + 0xc918],0x0 (0000_A4C4 / 0xA4C4)
    UInt8[ES, (ushort)(BX + 0xC918)] = 0x0;
    label_0000_A4CA_0A4CA:
    CheckExternalEvents(cs1, 0xA4CD);
    // INC word ptr [BP + -0x12] (0000_A4CA / 0xA4CA)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    label_0000_A4CD_0A4CD:
    CheckExternalEvents(cs1, 0xA4D1);
    // CMP word ptr [BP + -0x12],0x1b (0000_A4CD / 0xA4CD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x1B);
    CheckExternalEvents(cs1, 0xA4D3);
    // JG 0x0000:a509 (0000_A4D1 / 0xA4D1)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_A509_0A509;
    }
    CheckExternalEvents(cs1, 0xA4D7);
    // MOV ES,word ptr [0x545c] (0000_A4D3 / 0xA4D3)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA4DB);
    // MOV AL,ES:[0xd30f] (0000_A4D7 / 0xA4D7)
    AL = UInt8[ES, 0xD30F];
    CheckExternalEvents(cs1, 0xA4DC);
    // CBW  (0000_A4DB / 0xA4DB)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA4DE);
    // MOV BX,AX (0000_A4DC / 0xA4DC)
    BX = AX;
    CheckExternalEvents(cs1, 0xA4E2);
    // MOV AL,byte ptr [BX + 0x165a] (0000_A4DE / 0xA4DE)
    AL = UInt8[DS, (ushort)(BX + 0x165A)];
    CheckExternalEvents(cs1, 0xA4E5);
    // MOV byte ptr [BP + -0x16],AL (0000_A4E2 / 0xA4E2)
    UInt8[SS, (ushort)(BP - 0x16)] = AL;
    CheckExternalEvents(cs1, 0xA4E8);
    // MOV AX,0x7d (0000_A4E5 / 0xA4E5)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA4EB);
    // IMUL word ptr [BP + -0xe] (0000_A4E8 / 0xA4E8)
    int resImul0000_A4E8 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A4E8);
    DX = (ushort)(resImul0000_A4E8 >> 16);
    CheckExternalEvents(cs1, 0xA4EE);
    // ADD AX,word ptr [BP + -0x12] (0000_A4EB / 0xA4EB)
    AX += UInt16[SS, (ushort)(BP - 0x12)];
    CheckExternalEvents(cs1, 0xA4F1);
    // ADD AX,0xc918 (0000_A4EE / 0xA4EE)
    // AX += 0xC918;
    AX = Alu16.Add(AX, 0xC918);
    CheckExternalEvents(cs1, 0xA4F4);
    // MOV word ptr [BP + -0x1a],AX (0000_A4F1 / 0xA4F1)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs1, 0xA4F9);
    // MOV word ptr [BP + -0x18],0x2a02 (0000_A4F4 / 0xA4F4)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x2A02;
    CheckExternalEvents(cs1, 0xA4FC);
    // LES BX,[BP + -0x1a] (0000_A4F9 / 0xA4F9)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    ES = UInt16[SS, (ushort)(BP - 0x1A + 2)];
    CheckExternalEvents(cs1, 0xA4FF);
    // MOV AL,byte ptr [BP + -0x16] (0000_A4FC / 0xA4FC)
    AL = UInt8[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs1, 0xA502);
    // CMP byte ptr ES:[BX],AL (0000_A4FF / 0xA4FF)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], AL);
    CheckExternalEvents(cs1, 0xA504);
    // JBE 0x0000:a4b5 (0000_A502 / 0xA502)
    if(CarryFlag || ZeroFlag) {
      goto label_0000_A4B5_0A4B5;
    }
    CheckExternalEvents(cs1, 0xA507);
    // SUB byte ptr ES:[BX],AL (0000_A504 / 0xA504)
    // UInt8[ES, (ushort)(BX)] -= AL;
    UInt8[ES, (ushort)(BX)] = Alu8.Sub(UInt8[ES, (ushort)(BX)], AL);
    CheckExternalEvents(cs1, 0xA509);
    // JMP 0x0000:a4ca (0000_A507 / 0xA507)
    goto label_0000_A4CA_0A4CA;
    label_0000_A509_0A509:
    CheckExternalEvents(cs1, 0xA50D);
    // MOV ES,word ptr [0x545c] (0000_A509 / 0xA509)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA513);
    // CMP byte ptr ES:[0xd30f],0x4 (0000_A50D / 0xA50D)
    Alu8.Sub(UInt8[ES, 0xD30F], 0x4);
    CheckExternalEvents(cs1, 0xA515);
    // JG 0x0000:a518 (0000_A513 / 0xA513)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_0000_A518_0A518;
    }
    CheckExternalEvents(cs1, 0xA518);
    // JMP 0x0000:a5af (0000_A515 / 0xA515)
    goto label_0000_A5AF_0A5AF;
    label_0000_A518_0A518:
    CheckExternalEvents(cs1, 0xA51D);
    // MOV word ptr [BP + -0x12],0x0 (0000_A518 / 0xA518)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    label_0000_A51D_0A51D:
    CheckExternalEvents(cs1, 0xA522);
    // CALLF 0x1000:aab0 (0000_A51D / 0xA51D)
    FarCall(cs1, 0xA522, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA525);
    // AND AX,0x1f (0000_A522 / 0xA522)
    AX &= 0x1F;
    CheckExternalEvents(cs1, 0xA528);
    // ADD AX,0x34 (0000_A525 / 0xA525)
    // AX += 0x34;
    AX = Alu16.Add(AX, 0x34);
    CheckExternalEvents(cs1, 0xA52B);
    // MOV word ptr [BP + -0xa],AX (0000_A528 / 0xA528)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs1, 0xA52E);
    // MOV AX,0x7d (0000_A52B / 0xA52B)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA531);
    // IMUL word ptr [BP + -0xe] (0000_A52E / 0xA52E)
    int resImul0000_A52E = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A52E);
    DX = (ushort)(resImul0000_A52E >> 16);
    CheckExternalEvents(cs1, 0xA534);
    // ADD AX,word ptr [BP + -0xa] (0000_A531 / 0xA531)
    AX += UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs1, 0xA537);
    // ADD AX,0xc918 (0000_A534 / 0xA534)
    // AX += 0xC918;
    AX = Alu16.Add(AX, 0xC918);
    CheckExternalEvents(cs1, 0xA53A);
    // MOV word ptr [BP + -0x1a],AX (0000_A537 / 0xA537)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs1, 0xA53F);
    // MOV word ptr [BP + -0x18],0x2a02 (0000_A53A / 0xA53A)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x2A02;
    CheckExternalEvents(cs1, 0xA542);
    // LES BX,[BP + -0x1a] (0000_A53F / 0xA53F)
    BX = UInt16[SS, (ushort)(BP - 0x1A)];
    ES = UInt16[SS, (ushort)(BP - 0x1A + 2)];
    CheckExternalEvents(cs1, 0xA546);
    // CMP byte ptr ES:[BX],0x0 (0000_A542 / 0xA542)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0x0);
    CheckExternalEvents(cs1, 0xA548);
    // JZ 0x0000:a54c (0000_A546 / 0xA546)
    if(ZeroFlag) {
      goto label_0000_A54C_0A54C;
    }
    CheckExternalEvents(cs1, 0xA54C);
    // OR byte ptr ES:[BX],0x80 (0000_A548 / 0xA548)
    UInt8[ES, (ushort)(BX)] |= 0x80;
    label_0000_A54C_0A54C:
    CheckExternalEvents(cs1, 0xA54F);
    // INC word ptr [BP + -0x12] (0000_A54C / 0xA54C)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    CheckExternalEvents(cs1, 0xA553);
    // CMP word ptr [BP + -0x12],0x5 (0000_A54F / 0xA54F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x5);
    CheckExternalEvents(cs1, 0xA555);
    // JL 0x0000:a51d (0000_A553 / 0xA553)
    if(SignFlag != OverflowFlag) {
      goto label_0000_A51D_0A51D;
    }
    CheckExternalEvents(cs1, 0xA559);
    // MOV ES,word ptr [0x545c] (0000_A555 / 0xA555)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA55F);
    // CMP byte ptr ES:[0xd30f],0x5 (0000_A559 / 0xA559)
    Alu8.Sub(UInt8[ES, 0xD30F], 0x5);
    CheckExternalEvents(cs1, 0xA561);
    // JLE 0x0000:a5af (0000_A55F / 0xA55F)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_A5AF_0A5AF;
    }
    CheckExternalEvents(cs1, 0xA566);
    // CALLF 0x1000:aab0 (0000_A561 / 0xA561)
    FarCall(cs1, 0xA566, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA568);
    // AND AL,0x1 (0000_A566 / 0xA566)
    // AL &= 0x1;
    AL = Alu8.And(AL, 0x1);
    CheckExternalEvents(cs1, 0xA56A);
    // MOV CX,AX (0000_A568 / 0xA568)
    CX = AX;
    CheckExternalEvents(cs1, 0xA56D);
    // MOV AX,0x7d (0000_A56A / 0xA56A)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA570);
    // IMUL word ptr [BP + -0xe] (0000_A56D / 0xA56D)
    int resImul0000_A56D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A56D);
    DX = (ushort)(resImul0000_A56D >> 16);
    CheckExternalEvents(cs1, 0xA572);
    // MOV BX,AX (0000_A570 / 0xA570)
    BX = AX;
    CheckExternalEvents(cs1, 0xA576);
    // MOV ES,word ptr [0x545c] (0000_A572 / 0xA572)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA57B);
    // MOV byte ptr ES:[BX + 0xc98d],CL (0000_A576 / 0xA576)
    UInt8[ES, (ushort)(BX + 0xC98D)] = CL;
    CheckExternalEvents(cs1, 0xA580);
    // CALLF 0x1000:aab0 (0000_A57B / 0xA57B)
    FarCall(cs1, 0xA580, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA582);
    // AND AL,0x1 (0000_A580 / 0xA580)
    // AL &= 0x1;
    AL = Alu8.And(AL, 0x1);
    CheckExternalEvents(cs1, 0xA584);
    // MOV CX,AX (0000_A582 / 0xA582)
    CX = AX;
    CheckExternalEvents(cs1, 0xA587);
    // MOV AX,0x7d (0000_A584 / 0xA584)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA58A);
    // IMUL word ptr [BP + -0xe] (0000_A587 / 0xA587)
    int resImul0000_A587 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A587);
    DX = (ushort)(resImul0000_A587 >> 16);
    CheckExternalEvents(cs1, 0xA58C);
    // MOV BX,AX (0000_A58A / 0xA58A)
    BX = AX;
    CheckExternalEvents(cs1, 0xA590);
    // MOV ES,word ptr [0x545c] (0000_A58C / 0xA58C)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA595);
    // MOV byte ptr ES:[BX + 0xc98f],CL (0000_A590 / 0xA590)
    UInt8[ES, (ushort)(BX + 0xC98F)] = CL;
    CheckExternalEvents(cs1, 0xA59A);
    // CALLF 0x1000:aab0 (0000_A595 / 0xA595)
    FarCall(cs1, 0xA59A, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA59C);
    // AND AL,0x1 (0000_A59A / 0xA59A)
    // AL &= 0x1;
    AL = Alu8.And(AL, 0x1);
    CheckExternalEvents(cs1, 0xA59E);
    // MOV CX,AX (0000_A59C / 0xA59C)
    CX = AX;
    CheckExternalEvents(cs1, 0xA5A1);
    // MOV AX,0x7d (0000_A59E / 0xA59E)
    AX = 0x7D;
    CheckExternalEvents(cs1, 0xA5A4);
    // IMUL word ptr [BP + -0xe] (0000_A5A1 / 0xA5A1)
    int resImul0000_A5A1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A5A1);
    DX = (ushort)(resImul0000_A5A1 >> 16);
    CheckExternalEvents(cs1, 0xA5A6);
    // MOV BX,AX (0000_A5A4 / 0xA5A4)
    BX = AX;
    CheckExternalEvents(cs1, 0xA5AA);
    // MOV ES,word ptr [0x545c] (0000_A5A6 / 0xA5A6)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA5AF);
    // MOV byte ptr ES:[BX + 0xc98e],CL (0000_A5AA / 0xA5AA)
    UInt8[ES, (ushort)(BX + 0xC98E)] = CL;
    label_0000_A5AF_0A5AF:
    CheckExternalEvents(cs1, 0xA5B2);
    // MOV AL,byte ptr [BP + -0x6] (0000_A5AF / 0xA5AF)
    AL = UInt8[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs1, 0xA5B5);
    // MOV BX,word ptr [BP + -0xe] (0000_A5B2 / 0xA5B2)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA5B9);
    // MOV ES,word ptr [0x5492] (0000_A5B5 / 0xA5B5)
    ES = UInt16[DS, 0x5492];
    CheckExternalEvents(cs1, 0xA5BE);
    // MOV byte ptr ES:[BX + 0xd56a],AL (0000_A5B9 / 0xA5B9)
    UInt8[ES, (ushort)(BX + 0xD56A)] = AL;
    CheckExternalEvents(cs1, 0xA5C1);
    // MOV BX,word ptr [BP + -0xe] (0000_A5BE / 0xA5BE)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA5C5);
    // MOV ES,word ptr [0x5494] (0000_A5C1 / 0xA5C1)
    ES = UInt16[DS, 0x5494];
    CheckExternalEvents(cs1, 0xA5CB);
    // MOV byte ptr ES:[BX + 0x40a6],0xc (0000_A5C5 / 0xA5C5)
    UInt8[ES, (ushort)(BX + 0x40A6)] = 0xC;
    CheckExternalEvents(cs1, 0xA5CE);
    // MOV BX,word ptr [BP + -0xe] (0000_A5CB / 0xA5CB)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA5D0);
    // SHL BX,0x1 (0000_A5CE / 0xA5CE)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xA5D2);
    // SHL BX,0x1 (0000_A5D0 / 0xA5D0)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xA5D6);
    // MOV ES,word ptr [0x5496] (0000_A5D2 / 0xA5D2)
    ES = UInt16[DS, 0x5496];
    CheckExternalEvents(cs1, 0xA5DD);
    // MOV word ptr ES:[BX + 0x226],0x2a0 (0000_A5D6 / 0xA5D6)
    UInt16[ES, (ushort)(BX + 0x226)] = 0x2A0;
    CheckExternalEvents(cs1, 0xA5E4);
    // MOV word ptr ES:[BX + 0x228],0x2958 (0000_A5DD / 0xA5DD)
    UInt16[ES, (ushort)(BX + 0x228)] = 0x2958;
    CheckExternalEvents(cs1, 0xA5E6);
    // MOV AL,0x6 (0000_A5E4 / 0xA5E4)
    AL = 0x6;
    CheckExternalEvents(cs1, 0xA5E9);
    // MOV BX,word ptr [BP + -0xe] (0000_A5E6 / 0xA5E6)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA5ED);
    // MOV ES,word ptr [0x5498] (0000_A5E9 / 0xA5E9)
    ES = UInt16[DS, 0x5498];
    CheckExternalEvents(cs1, 0xA5F2);
    // MOV byte ptr ES:[BX + 0x392c],AL (0000_A5ED / 0xA5ED)
    UInt8[ES, (ushort)(BX + 0x392C)] = AL;
    CheckExternalEvents(cs1, 0xA5F5);
    // MOV BX,word ptr [BP + -0xe] (0000_A5F2 / 0xA5F2)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA5F9);
    // MOV ES,word ptr [0x549a] (0000_A5F5 / 0xA5F5)
    ES = UInt16[DS, 0x549A];
    CheckExternalEvents(cs1, 0xA5FE);
    // MOV byte ptr ES:[BX + 0x3978],AL (0000_A5F9 / 0xA5F9)
    UInt8[ES, (ushort)(BX + 0x3978)] = AL;
    CheckExternalEvents(cs1, 0xA601);
    // MOV SI,word ptr [BP + -0xe] (0000_A5FE / 0xA5FE)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA603);
    // SHL SI,0x1 (0000_A601 / 0xA601)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xA607);
    // MOV ES,word ptr [0x548a] (0000_A603 / 0xA603)
    ES = UInt16[DS, 0x548A];
    CheckExternalEvents(cs1, 0xA60E);
    // MOV word ptr ES:[SI + 0x4082],0x1 (0000_A607 / 0xA607)
    UInt16[ES, (ushort)(SI + 0x4082)] = 0x1;
    CheckExternalEvents(cs1, 0xA611);
    // MOV BX,word ptr [BP + -0xe] (0000_A60E / 0xA60E)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA615);
    // MOV AL,byte ptr [BX + 0x1642] (0000_A611 / 0xA611)
    AL = UInt8[DS, (ushort)(BX + 0x1642)];
    CheckExternalEvents(cs1, 0xA616);
    // CBW  (0000_A615 / 0xA615)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA619);
    // ADD AX,word ptr [BP + -0x10] (0000_A616 / 0xA616)
    // AX += UInt16[SS, (ushort)(BP - 0x10)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs1, 0xA61D);
    // MOV ES,word ptr [0x5484] (0000_A619 / 0xA619)
    ES = UInt16[DS, 0x5484];
    CheckExternalEvents(cs1, 0xA622);
    // MOV word ptr ES:[SI + 0x401c],AX (0000_A61D / 0xA61D)
    UInt16[ES, (ushort)(SI + 0x401C)] = AX;
    CheckExternalEvents(cs1, 0xA625);
    // MOV BX,word ptr [BP + -0xe] (0000_A622 / 0xA622)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA629);
    // MOV AL,byte ptr [BX + 0x164e] (0000_A625 / 0xA625)
    AL = UInt8[DS, (ushort)(BX + 0x164E)];
    CheckExternalEvents(cs1, 0xA62A);
    // CBW  (0000_A629 / 0xA629)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA62D);
    // ADD AX,word ptr [BP + -0x14] (0000_A62A / 0xA62A)
    // AX += UInt16[SS, (ushort)(BP - 0x14)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0xA631);
    // MOV ES,word ptr [0x5486] (0000_A62D / 0xA62D)
    ES = UInt16[DS, 0x5486];
    CheckExternalEvents(cs1, 0xA636);
    // MOV word ptr ES:[SI + 0x404e],AX (0000_A631 / 0xA631)
    UInt16[ES, (ushort)(SI + 0x404E)] = AX;
    CheckExternalEvents(cs1, 0xA63A);
    // MOV ES,word ptr [0x548c] (0000_A636 / 0xA636)
    ES = UInt16[DS, 0x548C];
    CheckExternalEvents(cs1, 0xA640);
    // CMP word ptr ES:[0xe48e],0x0 (0000_A63A / 0xA63A)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs1, 0xA642);
    // JZ 0x0000:a696 (0000_A640 / 0xA640)
    if(ZeroFlag) {
      goto label_0000_A696_0A696;
    }
    CheckExternalEvents(cs1, 0xA646);
    // CMP word ptr [BP + -0xe],0x0 (0000_A642 / 0xA642)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], 0x0);
    CheckExternalEvents(cs1, 0xA648);
    // JZ 0x0000:a696 (0000_A646 / 0xA646)
    if(ZeroFlag) {
      goto label_0000_A696_0A696;
    }
    CheckExternalEvents(cs1, 0xA64C);
    // MOV ES,word ptr [0x5494] (0000_A648 / 0xA648)
    ES = UInt16[DS, 0x5494];
    CheckExternalEvents(cs1, 0xA652);
    // MOV byte ptr ES:[0x40a7],0x10 (0000_A64C / 0xA64C)
    UInt8[ES, 0x40A7] = 0x10;
    CheckExternalEvents(cs1, 0xA656);
    // MOV ES,word ptr [0x5492] (0000_A652 / 0xA652)
    ES = UInt16[DS, 0x5492];
    CheckExternalEvents(cs1, 0xA65C);
    // MOV byte ptr ES:[0xd56b],0x0 (0000_A656 / 0xA656)
    UInt8[ES, 0xD56B] = 0x0;
    CheckExternalEvents(cs1, 0xA660);
    // MOV ES,word ptr [0x5496] (0000_A65C / 0xA65C)
    ES = UInt16[DS, 0x5496];
    CheckExternalEvents(cs1, 0xA667);
    // MOV word ptr ES:[0x22a],0x4dd8 (0000_A660 / 0xA660)
    UInt16[ES, 0x22A] = 0x4DD8;
    label_0000_A667_0A667:
    CheckExternalEvents(cs1, 0xA66E);
    // MOV word ptr ES:[0x22c],0x384b (0000_A667 / 0xA667)
    UInt16[ES, 0x22C] = 0x384B;
    CheckExternalEvents(cs1, 0xA672);
    // MOV ES,word ptr [0x5498] (0000_A66E / 0xA66E)
    ES = UInt16[DS, 0x5498];
    CheckExternalEvents(cs1, 0xA674);
    // MOV AL,0x2 (0000_A672 / 0xA672)
    AL = 0x2;
    CheckExternalEvents(cs1, 0xA678);
    // MOV ES:[0x392d],AL (0000_A674 / 0xA674)
    UInt8[ES, 0x392D] = AL;
    CheckExternalEvents(cs1, 0xA67C);
    // MOV ES,word ptr [0x549a] (0000_A678 / 0xA678)
    ES = UInt16[DS, 0x549A];
    CheckExternalEvents(cs1, 0xA680);
    // MOV ES:[0x3979],AL (0000_A67C / 0xA67C)
    UInt8[ES, 0x3979] = AL;
    CheckExternalEvents(cs1, 0xA684);
    // MOV ES,word ptr [0x5484] (0000_A680 / 0xA680)
    ES = UInt16[DS, 0x5484];
    CheckExternalEvents(cs1, 0xA68B);
    // MOV word ptr ES:[0x401e],0xa06 (0000_A684 / 0xA684)
    UInt16[ES, 0x401E] = 0xA06;
    CheckExternalEvents(cs1, 0xA68F);
    // MOV ES,word ptr [0x5486] (0000_A68B / 0xA68B)
    ES = UInt16[DS, 0x5486];
    CheckExternalEvents(cs1, 0xA696);
    // MOV word ptr ES:[0x4050],0x8066 (0000_A68F / 0xA68F)
    UInt16[ES, 0x4050] = 0x8066;
    label_0000_A696_0A696:
    CheckExternalEvents(cs1, 0xA699);
    // INC word ptr [BP + -0xe] (0000_A696 / 0xA696)
    UInt16[SS, (ushort)(BP - 0xE)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xE)]);
    label_0000_A699_0A699:
    CheckExternalEvents(cs1, 0xA69C);
    // MOV AX,word ptr [BP + 0x6] (0000_A699 / 0xA699)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs1, 0xA69F);
    // CMP word ptr [BP + -0xe],AX (0000_A69C / 0xA69C)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], AX);
    CheckExternalEvents(cs1, 0xA6A1);
    // JGE 0x0000:a6c8 (0000_A69F / 0xA69F)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A6C8_0A6C8;
    }
    CheckExternalEvents(cs1, 0xA6A4);
    // MOV AX,0x11 (0000_A6A1 / 0xA6A1)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xA6A7);
    // IMUL word ptr [BP + -0xc] (0000_A6A4 / 0xA6A4)
    int resImul0000_A6A4 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xC)]);
    AX = (ushort)(resImul0000_A6A4);
    DX = (ushort)(resImul0000_A6A4 >> 16);
    CheckExternalEvents(cs1, 0xA6A9);
    // MOV SI,AX (0000_A6A7 / 0xA6A7)
    SI = AX;
    CheckExternalEvents(cs1, 0xA6AD);
    // MOV ES,word ptr [0x545c] (0000_A6A9 / 0xA6A9)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA6B3);
    // MOV byte ptr ES:[SI + 0xc614],0x0 (0000_A6AD / 0xA6AD)
    UInt8[ES, (ushort)(SI + 0xC614)] = 0x0;
    CheckExternalEvents(cs1, 0xA6B6);
    // MOV AL,byte ptr [BP + -0xe] (0000_A6B3 / 0xA6B3)
    AL = UInt8[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA6B8);
    // ADD AL,0x4 (0000_A6B6 / 0xA6B6)
    // AL += 0x4;
    AL = Alu8.Add(AL, 0x4);
    CheckExternalEvents(cs1, 0xA6BD);
    // MOV byte ptr ES:[SI + 0xc620],AL (0000_A6B8 / 0xA6B8)
    UInt8[ES, (ushort)(SI + 0xC620)] = AL;
    CheckExternalEvents(cs1, 0xA6C0);
    // INC word ptr [BP + -0xc] (0000_A6BD / 0xA6BD)
    UInt16[SS, (ushort)(BP - 0xC)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xC)]);
    CheckExternalEvents(cs1, 0xA6C5);
    // MOV word ptr [BP + -0x12],0x0 (0000_A6C0 / 0xA6C0)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    CheckExternalEvents(cs1, 0xA6C8);
    // JMP 0x0000:a469 (0000_A6C5 / 0xA6C5)
    goto label_0000_A469_0A469;
    label_0000_A6C8_0A6C8:
    CheckExternalEvents(cs1, 0xA6CC);
    // CMP word ptr [BP + 0x8],0x0 (0000_A6C8 / 0xA6C8)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs1, 0xA6CE);
    // JNZ 0x0000:a6d1 (0000_A6CC / 0xA6CC)
    if(!ZeroFlag) {
      goto label_0000_A6D1_0A6D1;
    }
    CheckExternalEvents(cs1, 0xA6D1);
    // JMP 0x0000:a805 (0000_A6CE / 0xA6CE)
    goto label_0000_A805_0A805;
    label_0000_A6D1_0A6D1:
    CheckExternalEvents(cs1, 0xA6D5);
    // AND word ptr [BP + 0x8],0x7f (0000_A6D1 / 0xA6D1)
    // UInt16[SS, (ushort)(BP + 0x8)] &= 0x7F;
    UInt16[SS, (ushort)(BP + 0x8)] = Alu16.And(UInt16[SS, (ushort)(BP + 0x8)], 0x7F);
    CheckExternalEvents(cs1, 0xA6D8);
    // MOV AX,word ptr [BP + -0xc] (0000_A6D5 / 0xA6D5)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xA6DB);
    // ADD word ptr [BP + 0x8],AX (0000_A6D8 / 0xA6D8)
    UInt16[SS, (ushort)(BP + 0x8)] += AX;
    CheckExternalEvents(cs1, 0xA6DF);
    // CMP word ptr [BP + 0x8],0x10 (0000_A6DB / 0xA6DB)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x10);
    CheckExternalEvents(cs1, 0xA6E1);
    // JLE 0x0000:a6e6 (0000_A6DF / 0xA6DF)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_A6E6_0A6E6;
    }
    CheckExternalEvents(cs1, 0xA6E6);
    // MOV word ptr [BP + 0x8],0x10 (0000_A6E1 / 0xA6E1)
    UInt16[SS, (ushort)(BP + 0x8)] = 0x10;
    label_0000_A6E6_0A6E6:
    CheckExternalEvents(cs1, 0xA6E9);
    // MOV AX,word ptr [BP + -0xc] (0000_A6E6 / 0xA6E6)
    AX = UInt16[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs1, 0xA6EC);
    // MOV word ptr [BP + -0xe],AX (0000_A6E9 / 0xA6E9)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs1, 0xA6EF);
    // JMP 0x0000:a7fa (0000_A6EC / 0xA6EC)
    goto label_0000_A7FA_0A7FA;
    label_0000_A6EF_0A6EF:
    CheckExternalEvents(cs1, 0xA6F2);
    // MOV AX,0x11 (0000_A6EF / 0xA6EF)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xA6F5);
    // IMUL word ptr [BP + -0xe] (0000_A6F2 / 0xA6F2)
    int resImul0000_A6F2 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A6F2);
    DX = (ushort)(resImul0000_A6F2 >> 16);
    CheckExternalEvents(cs1, 0xA6F7);
    // MOV SI,AX (0000_A6F5 / 0xA6F5)
    SI = AX;
    CheckExternalEvents(cs1, 0xA6FB);
    // MOV ES,word ptr [0x545c] (0000_A6F7 / 0xA6F7)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA701);
    // MOV byte ptr ES:[SI + 0xc614],0x0 (0000_A6FB / 0xA6FB)
    UInt8[ES, (ushort)(SI + 0xC614)] = 0x0;
    CheckExternalEvents(cs1, 0xA707);
    // MOV byte ptr ES:[SI + 0xc620],0x8 (0000_A701 / 0xA701)
    UInt8[ES, (ushort)(SI + 0xC620)] = 0x8;
    CheckExternalEvents(cs1, 0xA70A);
    // MOV BX,word ptr [BP + -0xe] (0000_A707 / 0xA707)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA70E);
    // MOV ES,word ptr [0x5492] (0000_A70A / 0xA70A)
    ES = UInt16[DS, 0x5492];
    CheckExternalEvents(cs1, 0xA714);
    // MOV byte ptr ES:[BX + 0xd566],0xfe (0000_A70E / 0xA70E)
    UInt8[ES, (ushort)(BX + 0xD566)] = 0xFE;
    CheckExternalEvents(cs1, 0xA717);
    // MOV BX,word ptr [BP + -0xe] (0000_A714 / 0xA714)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA71B);
    // MOV ES,word ptr [0x5494] (0000_A717 / 0xA717)
    ES = UInt16[DS, 0x5494];
    CheckExternalEvents(cs1, 0xA721);
    // MOV byte ptr ES:[BX + 0x40a2],0x1c (0000_A71B / 0xA71B)
    UInt8[ES, (ushort)(BX + 0x40A2)] = 0x1C;
    CheckExternalEvents(cs1, 0xA724);
    // MOV BX,word ptr [BP + -0xe] (0000_A721 / 0xA721)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA726);
    // SHL BX,0x1 (0000_A724 / 0xA724)
    BX <<= 0x1;
    CheckExternalEvents(cs1, 0xA728);
    // SHL BX,0x1 (0000_A726 / 0xA726)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs1, 0xA72C);
    // MOV ES,word ptr [0x5496] (0000_A728 / 0xA728)
    ES = UInt16[DS, 0x5496];
    CheckExternalEvents(cs1, 0xA733);
    // MOV word ptr ES:[BX + 0x216],0x2e0 (0000_A72C / 0xA72C)
    UInt16[ES, (ushort)(BX + 0x216)] = 0x2E0;
    CheckExternalEvents(cs1, 0xA73A);
    // MOV word ptr ES:[BX + 0x218],0x2958 (0000_A733 / 0xA733)
    UInt16[ES, (ushort)(BX + 0x218)] = 0x2958;
    CheckExternalEvents(cs1, 0xA73C);
    // MOV AL,0x6 (0000_A73A / 0xA73A)
    AL = 0x6;
    CheckExternalEvents(cs1, 0xA73F);
    // MOV BX,word ptr [BP + -0xe] (0000_A73C / 0xA73C)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA743);
    // MOV ES,word ptr [0x5498] (0000_A73F / 0xA73F)
    ES = UInt16[DS, 0x5498];
    CheckExternalEvents(cs1, 0xA748);
    // MOV byte ptr ES:[BX + 0x3928],AL (0000_A743 / 0xA743)
    UInt8[ES, (ushort)(BX + 0x3928)] = AL;
    CheckExternalEvents(cs1, 0xA74B);
    // MOV BX,word ptr [BP + -0xe] (0000_A748 / 0xA748)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA74F);
    // MOV ES,word ptr [0x549a] (0000_A74B / 0xA74B)
    ES = UInt16[DS, 0x549A];
    CheckExternalEvents(cs1, 0xA754);
    // MOV byte ptr ES:[BX + 0x3974],AL (0000_A74F / 0xA74F)
    UInt8[ES, (ushort)(BX + 0x3974)] = AL;
    CheckExternalEvents(cs1, 0xA757);
    // MOV SI,word ptr [BP + -0xe] (0000_A754 / 0xA754)
    SI = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA759);
    // SHL SI,0x1 (0000_A757 / 0xA757)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs1, 0xA75D);
    // MOV ES,word ptr [0x548a] (0000_A759 / 0xA759)
    ES = UInt16[DS, 0x548A];
    CheckExternalEvents(cs1, 0xA764);
    // MOV word ptr ES:[SI + 0x407a],0x1 (0000_A75D / 0xA75D)
    UInt16[ES, (ushort)(SI + 0x407A)] = 0x1;
    CheckExternalEvents(cs1, 0xA767);
    // MOV BX,word ptr [BP + -0xe] (0000_A764 / 0xA764)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA76B);
    // MOV AL,byte ptr [BX + 0x1642] (0000_A767 / 0xA767)
    AL = UInt8[DS, (ushort)(BX + 0x1642)];
    CheckExternalEvents(cs1, 0xA76C);
    // CBW  (0000_A76B / 0xA76B)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA76F);
    // ADD AX,word ptr [BP + -0x10] (0000_A76C / 0xA76C)
    // AX += UInt16[SS, (ushort)(BP - 0x10)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs1, 0xA773);
    // MOV ES,word ptr [0x5484] (0000_A76F / 0xA76F)
    ES = UInt16[DS, 0x5484];
    CheckExternalEvents(cs1, 0xA778);
    // MOV word ptr ES:[SI + 0x4014],AX (0000_A773 / 0xA773)
    UInt16[ES, (ushort)(SI + 0x4014)] = AX;
    CheckExternalEvents(cs1, 0xA77B);
    // MOV BX,word ptr [BP + -0xe] (0000_A778 / 0xA778)
    BX = UInt16[SS, (ushort)(BP - 0xE)];
    CheckExternalEvents(cs1, 0xA77F);
    // MOV AL,byte ptr [BX + 0x164e] (0000_A77B / 0xA77B)
    AL = UInt8[DS, (ushort)(BX + 0x164E)];
    CheckExternalEvents(cs1, 0xA780);
    // CBW  (0000_A77F / 0xA77F)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs1, 0xA783);
    // ADD AX,word ptr [BP + -0x14] (0000_A780 / 0xA780)
    // AX += UInt16[SS, (ushort)(BP - 0x14)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs1, 0xA787);
    // MOV ES,word ptr [0x5486] (0000_A783 / 0xA783)
    ES = UInt16[DS, 0x5486];
    CheckExternalEvents(cs1, 0xA78C);
    // MOV word ptr ES:[SI + 0x4046],AX (0000_A787 / 0xA787)
    UInt16[ES, (ushort)(SI + 0x4046)] = AX;
    CheckExternalEvents(cs1, 0xA791);
    // MOV word ptr [BP + -0x12],0x0 (0000_A78C / 0xA78C)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x0;
    label_0000_A791_0A791:
    CheckExternalEvents(cs1, 0xA796);
    // CALLF 0x1000:aab0 (0000_A791 / 0xA791)
    FarCall(cs1, 0xA796, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA798);
    // AND AL,0x1 (0000_A796 / 0xA796)
    // AL &= 0x1;
    AL = Alu8.And(AL, 0x1);
    CheckExternalEvents(cs1, 0xA79A);
    // MOV CX,AX (0000_A798 / 0xA798)
    CX = AX;
    CheckExternalEvents(cs1, 0xA79D);
    // MOV AX,0x11 (0000_A79A / 0xA79A)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xA7A0);
    // IMUL word ptr [BP + -0xe] (0000_A79D / 0xA79D)
    int resImul0000_A79D = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A79D);
    DX = (ushort)(resImul0000_A79D >> 16);
    CheckExternalEvents(cs1, 0xA7A2);
    // MOV BX,AX (0000_A7A0 / 0xA7A0)
    BX = AX;
    CheckExternalEvents(cs1, 0xA7A5);
    // ADD BX,word ptr [BP + -0x12] (0000_A7A2 / 0xA7A2)
    // BX += UInt16[SS, (ushort)(BP - 0x12)];
    BX = Alu16.Add(BX, UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs1, 0xA7A9);
    // MOV ES,word ptr [0x545c] (0000_A7A5 / 0xA7A5)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA7AE);
    // MOV byte ptr ES:[BX + 0xc618],CL (0000_A7A9 / 0xA7A9)
    UInt8[ES, (ushort)(BX + 0xC618)] = CL;
    CheckExternalEvents(cs1, 0xA7B1);
    // INC word ptr [BP + -0x12] (0000_A7AE / 0xA7AE)
    UInt16[SS, (ushort)(BP - 0x12)]++;
    CheckExternalEvents(cs1, 0xA7B5);
    // CMP word ptr [BP + -0x12],0x5 (0000_A7B1 / 0xA7B1)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x12)], 0x5);
    CheckExternalEvents(cs1, 0xA7B7);
    // JLE 0x0000:a791 (0000_A7B5 / 0xA7B5)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_0000_A791_0A791;
    }
    CheckExternalEvents(cs1, 0xA7BC);
    // CALLF 0x0000:30dd (0000_A7B7 / 0xA7B7)
    FarCall(cs1, 0xA7BC, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs1, 0xA7BE);
    // MOV CX,AX (0000_A7BC / 0xA7BC)
    CX = AX;
    CheckExternalEvents(cs1, 0xA7C1);
    // MOV AX,0x11 (0000_A7BE / 0xA7BE)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xA7C4);
    // IMUL word ptr [BP + -0xe] (0000_A7C1 / 0xA7C1)
    int resImul0000_A7C1 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A7C1);
    DX = (ushort)(resImul0000_A7C1 >> 16);
    CheckExternalEvents(cs1, 0xA7C6);
    // MOV BX,AX (0000_A7C4 / 0xA7C4)
    BX = AX;
    CheckExternalEvents(cs1, 0xA7CA);
    // MOV ES,word ptr [0x545c] (0000_A7C6 / 0xA7C6)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA7CF);
    // MOV byte ptr ES:[BX + 0xc615],CL (0000_A7CA / 0xA7CA)
    UInt8[ES, (ushort)(BX + 0xC615)] = CL;
    CheckExternalEvents(cs1, 0xA7D2);
    // MOV AX,0x11 (0000_A7CF / 0xA7CF)
    AX = 0x11;
    CheckExternalEvents(cs1, 0xA7D5);
    // IMUL word ptr [BP + -0xe] (0000_A7D2 / 0xA7D2)
    int resImul0000_A7D2 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0xE)]);
    AX = (ushort)(resImul0000_A7D2);
    DX = (ushort)(resImul0000_A7D2 >> 16);
    CheckExternalEvents(cs1, 0xA7D7);
    // MOV SI,AX (0000_A7D5 / 0xA7D5)
    SI = AX;
    CheckExternalEvents(cs1, 0xA7D9);
    // MOV AL,0xa (0000_A7D7 / 0xA7D7)
    AL = 0xA;
    CheckExternalEvents(cs1, 0xA7DE);
    // IMUL byte ptr ES:[SI + 0xc615] (0000_A7D9 / 0xA7D9)
    short resImul0000_A7D9 = Alu8.Imul((sbyte)AL, (sbyte)UInt8[ES, (ushort)(SI + 0xC615)]);
    AL = (byte)(resImul0000_A7D9);
    AH = (byte)(resImul0000_A7D9 >> 8);
    CheckExternalEvents(cs1, 0xA7E3);
    // MOV byte ptr ES:[SI + 0xc623],AL (0000_A7DE / 0xA7DE)
    UInt8[ES, (ushort)(SI + 0xC623)] = AL;
    CheckExternalEvents(cs1, 0xA7E8);
    // CALLF 0x1000:aab0 (0000_A7E3 / 0xA7E3)
    FarCall(cs1, 0xA7E8, unknown_19EF_0BC0_1AAB0);
    CheckExternalEvents(cs1, 0xA7E9);
    // CWD  (0000_A7E8 / 0xA7E8)
    DX = (ushort)(AX>=0x8000?0xFFFF:0);
    CheckExternalEvents(cs1, 0xA7EC);
    // MOV CX,0xe (0000_A7E9 / 0xA7E9)
    CX = 0xE;
    CheckExternalEvents(cs1, 0xA7EE);
    // IDIV CX (0000_A7EC / 0xA7EC)
    int op1Idiv0000_A7EC = (int)(DX << 16 | AX);
    short op2Idiv0000_A7EC = (short)CX;
    short? resIdiv0000_A7EC = Alu16.Idiv(op1Idiv0000_A7EC, op2Idiv0000_A7EC);
    if(resIdiv0000_A7EC == null) {
      throw FailAsUntested("Division by 0!");
    }
    AX = (ushort)resIdiv0000_A7EC.Value;
    DX = (ushort)(op1Idiv0000_A7EC % op2Idiv0000_A7EC);
    CheckExternalEvents(cs1, 0xA7F2);
    // MOV ES,word ptr [0x545c] (0000_A7EE / 0xA7EE)
    ES = UInt16[DS, 0x545C];
    CheckExternalEvents(cs1, 0xA7F7);
    // MOV byte ptr ES:[SI + 0xc61f],DL (0000_A7F2 / 0xA7F2)
    UInt8[ES, (ushort)(SI + 0xC61F)] = DL;
    CheckExternalEvents(cs1, 0xA7FA);
    // INC word ptr [BP + -0xe] (0000_A7F7 / 0xA7F7)
    UInt16[SS, (ushort)(BP - 0xE)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0xE)]);
    label_0000_A7FA_0A7FA:
    CheckExternalEvents(cs1, 0xA7FD);
    // MOV AX,word ptr [BP + 0x8] (0000_A7FA / 0xA7FA)
    AX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs1, 0xA800);
    // CMP word ptr [BP + -0xe],AX (0000_A7FD / 0xA7FD)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0xE)], AX);
    CheckExternalEvents(cs1, 0xA802);
    // JGE 0x0000:a805 (0000_A800 / 0xA800)
    if(SignFlag == OverflowFlag) {
      goto label_0000_A805_0A805;
    }
    CheckExternalEvents(cs1, 0xA805);
    // JMP 0x0000:a6ef (0000_A802 / 0xA802)
    goto label_0000_A6EF_0A6EF;
    label_0000_A805_0A805:
    CheckExternalEvents(cs1, 0xA806);
    // POP SI (0000_A805 / 0xA805)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xA807);
    // POP DI (0000_A806 / 0xA806)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xA809);
    // MOV SP,BP (0000_A807 / 0xA807)
    SP = BP;
    CheckExternalEvents(cs1, 0xA80A);
    // POP BP (0000_A809 / 0xA809)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs1, 0xA80B);
    // RETF  (0000_A80A / 0xA80A)
    return FarRet();
  }
  
}
