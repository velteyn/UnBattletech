namespace generated;

using Spice86.Core.CLI;
using Spice86.Core.Emulator.CPU.InstructionsImpl;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides : CSharpOverrideHelper {

  public virtual Action ghidra_guess_1000_5847_15847(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_5847_15847:
    CheckExternalEvents(cs8, 0x5848);
    // PUSH BP (1000_5847 / 0x15847)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x584A);
    // MOV BP,SP (1000_5848 / 0x15848)
    BP = SP;
    CheckExternalEvents(cs8, 0x584D);
    // MOV AX,0x32 (1000_584A / 0x1584A)
    AX = 0x32;
    CheckExternalEvents(cs8, 0x5852);
    // CALLF 0x1000:cecc (1000_584D / 0x1584D)
    FarCall(cs8, 0x5852, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x5853);
    // PUSH SI (1000_5852 / 0x15852)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x5858);
    // MOV word ptr [BP + -0x24],0x0 (1000_5853 / 0x15853)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x0;
    CheckExternalEvents(cs8, 0x585C);
    // MOV ES,word ptr [0x5646] (1000_5858 / 0x15858)
    ES = UInt16[DS, 0x5646];
    CheckExternalEvents(cs8, 0x5862);
    // CMP word ptr ES:[0x2e3a],0x0 (1000_585C / 0x1585C)
    Alu16.Sub(UInt16[ES, 0x2E3A], 0x0);
    CheckExternalEvents(cs8, 0x5864);
    // JNZ 0x1000:5867 (1000_5862 / 0x15862)
    if(!ZeroFlag) {
      goto label_1000_5867_15867;
    }
    CheckExternalEvents(cs8, 0x5867);
    // JMP 0x1000:608c (1000_5864 / 0x15864)
    goto label_1000_608C_1608C;
    label_1000_5867_15867:
    CheckExternalEvents(cs8, 0x586B);
    // MOV ES,word ptr [0x5630] (1000_5867 / 0x15867)
    ES = UInt16[DS, 0x5630];
    CheckExternalEvents(cs8, 0x5871);
    // CMP word ptr ES:[0x14a],0x0 (1000_586B / 0x1586B)
    Alu16.Sub(UInt16[ES, 0x14A], 0x0);
    CheckExternalEvents(cs8, 0x5873);
    // JNZ 0x1000:5876 (1000_5871 / 0x15871)
    if(!ZeroFlag) {
      goto label_1000_5876_15876;
    }
    CheckExternalEvents(cs8, 0x5876);
    // JMP 0x1000:608c (1000_5873 / 0x15873)
    goto label_1000_608C_1608C;
    label_1000_5876_15876:
    CheckExternalEvents(cs8, 0x587A);
    // MOV ES,word ptr [0x5648] (1000_5876 / 0x15876)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs8, 0x587E);
    // MOV AL,ES:[0xc620] (1000_587A / 0x1587A)
    AL = UInt8[ES, 0xC620];
    CheckExternalEvents(cs8, 0x587F);
    // CBW  (1000_587E / 0x1587E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5882);
    // MOV word ptr [BP + -0x18],AX (1000_587F / 0x1587F)
    UInt16[SS, (ushort)(BP - 0x18)] = AX;
    CheckExternalEvents(cs8, 0x5885);
    // CMP AX,0x8 (1000_5882 / 0x15882)
    Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs8, 0x5887);
    // JL 0x1000:588c (1000_5885 / 0x15885)
    if(SignFlag != OverflowFlag) {
      goto label_1000_588C_1588C;
    }
    CheckExternalEvents(cs8, 0x588C);
    // MOV word ptr [BP + -0x18],0x4 (1000_5887 / 0x15887)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x4;
    label_1000_588C_1588C:
    CheckExternalEvents(cs8, 0x588F);
    // MOV SI,word ptr [BP + -0x18] (1000_588C / 0x1588C)
    SI = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs8, 0x5891);
    // SHL SI,0x1 (1000_588F / 0x1588F)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x5895);
    // MOV ES,word ptr [0x5638] (1000_5891 / 0x15891)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x589A);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_5895 / 0x15895)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs8, 0x589D);
    // MOV word ptr [BP + -0x10],AX (1000_589A / 0x1589A)
    UInt16[SS, (ushort)(BP - 0x10)] = AX;
    CheckExternalEvents(cs8, 0x58A1);
    // MOV ES,word ptr [0x5636] (1000_589D / 0x1589D)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x58A6);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_58A1 / 0x158A1)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs8, 0x58A9);
    // MOV word ptr [BP + -0x12],AX (1000_58A6 / 0x158A6)
    UInt16[SS, (ushort)(BP - 0x12)] = AX;
    CheckExternalEvents(cs8, 0x58AC);
    // MOV BX,word ptr [BP + 0x6] (1000_58A9 / 0x158A9)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x58B0);
    // MOV ES,word ptr [0x563c] (1000_58AC / 0x158AC)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs8, 0x58B6);
    // CMP byte ptr ES:[BX + 0x396c],0xff (1000_58B0 / 0x158B0)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x396C)], 0xFF);
    CheckExternalEvents(cs8, 0x58B8);
    // JZ 0x1000:58c6 (1000_58B6 / 0x158B6)
    if(ZeroFlag) {
      goto label_1000_58C6_158C6;
    }
    CheckExternalEvents(cs8, 0x58BD);
    // MOV AL,byte ptr ES:[BX + 0x396c] (1000_58B8 / 0x158B8)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs8, 0x58C1);
    // MOV ES,word ptr [0x5666] (1000_58BD / 0x158BD)
    ES = UInt16[DS, 0x5666];
    CheckExternalEvents(cs8, 0x58C6);
    // MOV byte ptr ES:[BX + 0x45b6],AL (1000_58C1 / 0x158C1)
    UInt8[ES, (ushort)(BX + 0x45B6)] = AL;
    label_1000_58C6_158C6:
    CheckExternalEvents(cs8, 0x58CA);
    // CMP word ptr [BP + 0x6],0x4 (1000_58C6 / 0x158C6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs8, 0x58CC);
    // JL 0x1000:58de (1000_58CA / 0x158CA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_58DE_158DE;
    }
    CheckExternalEvents(cs8, 0x58D0);
    // CMP word ptr [BP + 0x6],0xc (1000_58CC / 0x158CC)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs8, 0x58D2);
    // JGE 0x1000:58d5 (1000_58D0 / 0x158D0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_58D5_158D5;
    }
    CheckExternalEvents(cs8, 0x58D5);
    // JMP 0x1000:5984 (1000_58D2 / 0x158D2)
    goto label_1000_5984_15984;
    label_1000_58D5_158D5:
    CheckExternalEvents(cs8, 0x58D9);
    // CMP word ptr [BP + 0x6],0x10 (1000_58D5 / 0x158D5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs8, 0x58DB);
    // JL 0x1000:58de (1000_58D9 / 0x158D9)
    if(SignFlag != OverflowFlag) {
      goto label_1000_58DE_158DE;
    }
    CheckExternalEvents(cs8, 0x58DE);
    // JMP 0x1000:5984 (1000_58DB / 0x158DB)
    goto label_1000_5984_15984;
    label_1000_58DE_158DE:
    CheckExternalEvents(cs8, 0x58E1);
    // MOV BX,word ptr [BP + 0x6] (1000_58DE / 0x158DE)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x58E5);
    // MOV ES,word ptr [0x5642] (1000_58E1 / 0x158E1)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs8, 0x58EA);
    // MOV AL,byte ptr ES:[BX + 0x409a] (1000_58E5 / 0x158E5)
    AL = UInt8[ES, (ushort)(BX + 0x409A)];
    CheckExternalEvents(cs8, 0x58EC);
    // SUB AH,AH (1000_58EA / 0x158EA)
    // AH -= AH;
    AH = Alu8.Sub(AH, AH);
    CheckExternalEvents(cs8, 0x58EF);
    // MOV word ptr [BP + -0xc],AX (1000_58EC / 0x158EC)
    UInt16[SS, (ushort)(BP - 0xC)] = AX;
    CheckExternalEvents(cs8, 0x58F3);
    // CMP word ptr [BP + 0xa],0x20 (1000_58EF / 0x158EF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x20);
    CheckExternalEvents(cs8, 0x58F5);
    // JZ 0x1000:593e (1000_58F3 / 0x158F3)
    if(ZeroFlag) {
      goto label_1000_593E_1593E;
    }
    CheckExternalEvents(cs8, 0x58F8);
    // MOV SI,word ptr [BP + 0xc] (1000_58F5 / 0x158F5)
    SI = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x58FA);
    // MOV CL,0x2 (1000_58F8 / 0x158F8)
    CL = 0x2;
    CheckExternalEvents(cs8, 0x58FC);
    // SHL SI,CL (1000_58FA / 0x158FA)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs8, 0x5900);
    // MOV ES,word ptr [0x5678] (1000_58FC / 0x158FC)
    ES = UInt16[DS, 0x5678];
    CheckExternalEvents(cs8, 0x5905);
    // MOV AX,word ptr ES:[SI + 0x2d58] (1000_5900 / 0x15900)
    AX = UInt16[ES, (ushort)(SI + 0x2D58)];
    CheckExternalEvents(cs8, 0x590A);
    // MOV DX,word ptr ES:[SI + 0x2d5a] (1000_5905 / 0x15905)
    DX = UInt16[ES, (ushort)(SI + 0x2D5A)];
    CheckExternalEvents(cs8, 0x590C);
    // SHL BX,0x1 (1000_590A / 0x1590A)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x590E);
    // SHL BX,0x1 (1000_590C / 0x1590C)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x5912);
    // MOV ES,word ptr [0x5640] (1000_590E / 0x1590E)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x5917);
    // MOV word ptr ES:[BX + 0x1f6],AX (1000_5912 / 0x15912)
    UInt16[ES, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs8, 0x591C);
    // MOV word ptr ES:[BX + 0x1f8],DX (1000_5917 / 0x15917)
    UInt16[ES, (ushort)(BX + 0x1F8)] = DX;
    CheckExternalEvents(cs8, 0x591F);
    // MOV BX,word ptr [BP + 0x6] (1000_591C / 0x1591C)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5923);
    // MOV ES,word ptr [0x567a] (1000_591F / 0x1591F)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x5929);
    // CMP byte ptr ES:[BX + 0xd55e],0x0 (1000_5923 / 0x15923)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x0);
    CheckExternalEvents(cs8, 0x592B);
    // JNZ 0x1000:592e (1000_5929 / 0x15929)
    if(!ZeroFlag) {
      goto label_1000_592E_1592E;
    }
    CheckExternalEvents(cs8, 0x592E);
    // JMP 0x1000:59af (1000_592B / 0x1592B)
    goto label_1000_59AF_159AF;
    label_1000_592E_1592E:
    CheckExternalEvents(cs8, 0x5932);
    // MOV ES,word ptr [0x5678] (1000_592E / 0x1592E)
    ES = UInt16[DS, 0x5678];
    CheckExternalEvents(cs8, 0x5937);
    // MOV AX,word ptr ES:[SI + 0x2d78] (1000_5932 / 0x15932)
    AX = UInt16[ES, (ushort)(SI + 0x2D78)];
    CheckExternalEvents(cs8, 0x593C);
    // MOV DX,word ptr ES:[SI + 0x2d7a] (1000_5937 / 0x15937)
    DX = UInt16[ES, (ushort)(SI + 0x2D7A)];
    CheckExternalEvents(cs8, 0x593E);
    // JMP 0x1000:599d (1000_593C / 0x1593C)
    goto label_1000_599D_1599D;
    label_1000_593E_1593E:
    CheckExternalEvents(cs8, 0x5941);
    // MOV SI,word ptr [BP + 0xc] (1000_593E / 0x1593E)
    SI = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x5943);
    // MOV CL,0x2 (1000_5941 / 0x15941)
    CL = 0x2;
    CheckExternalEvents(cs8, 0x5945);
    // SHL SI,CL (1000_5943 / 0x15943)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs8, 0x5949);
    // MOV ES,word ptr [0x567c] (1000_5945 / 0x15945)
    ES = UInt16[DS, 0x567C];
    CheckExternalEvents(cs8, 0x594E);
    // MOV AX,word ptr ES:[SI + 0x2d98] (1000_5949 / 0x15949)
    AX = UInt16[ES, (ushort)(SI + 0x2D98)];
    CheckExternalEvents(cs8, 0x5953);
    // MOV DX,word ptr ES:[SI + 0x2d9a] (1000_594E / 0x1594E)
    DX = UInt16[ES, (ushort)(SI + 0x2D9A)];
    CheckExternalEvents(cs8, 0x5955);
    // SHL BX,0x1 (1000_5953 / 0x15953)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x5957);
    // SHL BX,0x1 (1000_5955 / 0x15955)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x595B);
    // MOV ES,word ptr [0x5640] (1000_5957 / 0x15957)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x5960);
    // MOV word ptr ES:[BX + 0x1f6],AX (1000_595B / 0x1595B)
    UInt16[ES, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs8, 0x5965);
    // MOV word ptr ES:[BX + 0x1f8],DX (1000_5960 / 0x15960)
    UInt16[ES, (ushort)(BX + 0x1F8)] = DX;
    CheckExternalEvents(cs8, 0x5968);
    // MOV BX,word ptr [BP + 0x6] (1000_5965 / 0x15965)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x596C);
    // MOV ES,word ptr [0x567a] (1000_5968 / 0x15968)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x5972);
    // CMP byte ptr ES:[BX + 0xd55e],0x0 (1000_596C / 0x1596C)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x0);
    CheckExternalEvents(cs8, 0x5974);
    // JZ 0x1000:59af (1000_5972 / 0x15972)
    if(ZeroFlag) {
      goto label_1000_59AF_159AF;
    }
    CheckExternalEvents(cs8, 0x5978);
    // MOV ES,word ptr [0x567c] (1000_5974 / 0x15974)
    ES = UInt16[DS, 0x567C];
    CheckExternalEvents(cs8, 0x597D);
    // MOV AX,word ptr ES:[SI + 0x2db8] (1000_5978 / 0x15978)
    AX = UInt16[ES, (ushort)(SI + 0x2DB8)];
    CheckExternalEvents(cs8, 0x5982);
    // MOV DX,word ptr ES:[SI + 0x2dba] (1000_597D / 0x1597D)
    DX = UInt16[ES, (ushort)(SI + 0x2DBA)];
    CheckExternalEvents(cs8, 0x5984);
    // JMP 0x1000:599d (1000_5982 / 0x15982)
    goto label_1000_599D_1599D;
    label_1000_5984_15984:
    CheckExternalEvents(cs8, 0x5987);
    // MOV SI,word ptr [BP + 0xa] (1000_5984 / 0x15984)
    SI = UInt16[SS, (ushort)(BP + 0xA)];
    CheckExternalEvents(cs8, 0x5989);
    // MOV CL,0x5 (1000_5987 / 0x15987)
    CL = 0x5;
    CheckExternalEvents(cs8, 0x598B);
    // SHL SI,CL (1000_5989 / 0x15989)
    // SI <<= CL;
    SI = Alu16.Shl(SI, CL);
    CheckExternalEvents(cs8, 0x598E);
    // MOV BX,word ptr [BP + 0xc] (1000_598B / 0x1598B)
    BX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x5990);
    // SHL BX,0x1 (1000_598E / 0x1598E)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x5992);
    // SHL BX,0x1 (1000_5990 / 0x15990)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x5996);
    // MOV AX,word ptr [BX + SI + 0x3ff8] (1000_5992 / 0x15992)
    AX = UInt16[DS, (ushort)(BX + SI + 0x3FF8)];
    CheckExternalEvents(cs8, 0x599A);
    // MOV DX,word ptr [BX + SI + 0x3ffa] (1000_5996 / 0x15996)
    DX = UInt16[DS, (ushort)(BX + SI + 0x3FFA)];
    CheckExternalEvents(cs8, 0x599D);
    // MOV BX,word ptr [BP + 0x6] (1000_599A / 0x1599A)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    label_1000_599D_1599D:
    CheckExternalEvents(cs8, 0x599F);
    // SHL BX,0x1 (1000_599D / 0x1599D)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x59A1);
    // SHL BX,0x1 (1000_599F / 0x1599F)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x59A5);
    // MOV ES,word ptr [0x5640] (1000_59A1 / 0x159A1)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x59AA);
    // MOV word ptr ES:[BX + 0x1f6],AX (1000_59A5 / 0x159A5)
    UInt16[ES, (ushort)(BX + 0x1F6)] = AX;
    CheckExternalEvents(cs8, 0x59AF);
    // MOV word ptr ES:[BX + 0x1f8],DX (1000_59AA / 0x159AA)
    UInt16[ES, (ushort)(BX + 0x1F8)] = DX;
    label_1000_59AF_159AF:
    CheckExternalEvents(cs8, 0x59B3);
    // CMP word ptr [BP + 0xa],0xa (1000_59AF / 0x159AF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xA);
    CheckExternalEvents(cs8, 0x59B5);
    // JZ 0x1000:59bb (1000_59B3 / 0x159B3)
    if(ZeroFlag) {
      goto label_1000_59BB_159BB;
    }
    CheckExternalEvents(cs8, 0x59B9);
    // CMP word ptr [BP + 0xa],0xb (1000_59B5 / 0x159B5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xB);
    CheckExternalEvents(cs8, 0x59BB);
    // JNZ 0x1000:59d7 (1000_59B9 / 0x159B9)
    if(!ZeroFlag) {
      goto label_1000_59D7_159D7;
    }
    label_1000_59BB_159BB:
    CheckExternalEvents(cs8, 0x59C0);
    // MOV word ptr [BP + 0xe],0x0 (1000_59BB / 0x159BB)
    UInt16[SS, (ushort)(BP + 0xE)] = 0x0;
    CheckExternalEvents(cs8, 0x59C4);
    // CMP word ptr [BP + 0x8],0x4 (1000_59C0 / 0x159C0)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x4);
    CheckExternalEvents(cs8, 0x59C6);
    // JL 0x1000:59d2 (1000_59C4 / 0x159C4)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59D2_159D2;
    }
    CheckExternalEvents(cs8, 0x59CA);
    // CMP word ptr [BP + 0x8],0xc (1000_59C6 / 0x159C6)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xC);
    CheckExternalEvents(cs8, 0x59CC);
    // JL 0x1000:59d7 (1000_59CA / 0x159CA)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59D7_159D7;
    }
    CheckExternalEvents(cs8, 0x59D0);
    // CMP word ptr [BP + 0x8],0x10 (1000_59CC / 0x159CC)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x10);
    CheckExternalEvents(cs8, 0x59D2);
    // JGE 0x1000:59d7 (1000_59D0 / 0x159D0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_59D7_159D7;
    }
    label_1000_59D2_159D2:
    CheckExternalEvents(cs8, 0x59D7);
    // MOV word ptr [BP + -0x24],0x1 (1000_59D2 / 0x159D2)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x1;
    label_1000_59D7_159D7:
    CheckExternalEvents(cs8, 0x59DB);
    // CMP word ptr [BP + 0xa],0x19 (1000_59D7 / 0x159D7)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x19);
    CheckExternalEvents(cs8, 0x59DD);
    // JL 0x1000:59e8 (1000_59DB / 0x159DB)
    if(SignFlag != OverflowFlag) {
      goto label_1000_59E8_159E8;
    }
    CheckExternalEvents(cs8, 0x59E1);
    // CMP word ptr [BP + 0xa],0x1f (1000_59DD / 0x159DD)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x1F);
    CheckExternalEvents(cs8, 0x59E3);
    // JG 0x1000:59e8 (1000_59E1 / 0x159E1)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_59E8_159E8;
    }
    CheckExternalEvents(cs8, 0x59E8);
    // MOV word ptr [BP + 0xe],0x0 (1000_59E3 / 0x159E3)
    UInt16[SS, (ushort)(BP + 0xE)] = 0x0;
    label_1000_59E8_159E8:
    CheckExternalEvents(cs8, 0x59EC);
    // CMP word ptr [BP + 0xe],0x0 (1000_59E8 / 0x159E8)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xE)], 0x0);
    CheckExternalEvents(cs8, 0x59EE);
    // JNZ 0x1000:59f1 (1000_59EC / 0x159EC)
    if(!ZeroFlag) {
      goto label_1000_59F1_159F1;
    }
    CheckExternalEvents(cs8, 0x59F1);
    // JMP 0x1000:5a8b (1000_59EE / 0x159EE)
    goto label_1000_5A8B_15A8B;
    label_1000_59F1_159F1:
    CheckExternalEvents(cs8, 0x59F4);
    // MOV BX,word ptr [BP + 0x8] (1000_59F1 / 0x159F1)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x59F8);
    // MOV ES,word ptr [0x563c] (1000_59F4 / 0x159F4)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs8, 0x59FE);
    // CMP byte ptr ES:[BX + 0x396c],0xff (1000_59F8 / 0x159F8)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x396C)], 0xFF);
    CheckExternalEvents(cs8, 0x5A00);
    // JZ 0x1000:5a0e (1000_59FE / 0x159FE)
    if(ZeroFlag) {
      goto label_1000_5A0E_15A0E;
    }
    CheckExternalEvents(cs8, 0x5A05);
    // MOV AL,byte ptr ES:[BX + 0x396c] (1000_5A00 / 0x15A00)
    AL = UInt8[ES, (ushort)(BX + 0x396C)];
    CheckExternalEvents(cs8, 0x5A09);
    // MOV ES,word ptr [0x5666] (1000_5A05 / 0x15A05)
    ES = UInt16[DS, 0x5666];
    CheckExternalEvents(cs8, 0x5A0E);
    // MOV byte ptr ES:[BX + 0x45b6],AL (1000_5A09 / 0x15A09)
    UInt8[ES, (ushort)(BX + 0x45B6)] = AL;
    label_1000_5A0E_15A0E:
    CheckExternalEvents(cs8, 0x5A11);
    // MOV BX,word ptr [BP + 0x8] (1000_5A0E / 0x15A0E)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x5A13);
    // SHL BX,0x1 (1000_5A11 / 0x15A11)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x5A15);
    // SHL BX,0x1 (1000_5A13 / 0x15A13)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x5A19);
    // MOV ES,word ptr [0x5640] (1000_5A15 / 0x15A15)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x5A20);
    // MOV word ptr ES:[BX + 0x1f6],0x2e3c (1000_5A19 / 0x15A19)
    UInt16[ES, (ushort)(BX + 0x1F6)] = 0x2E3C;
    CheckExternalEvents(cs8, 0x5A27);
    // MOV word ptr ES:[BX + 0x1f8],0x384b (1000_5A20 / 0x15A20)
    UInt16[ES, (ushort)(BX + 0x1F8)] = 0x384B;
    CheckExternalEvents(cs8, 0x5A29);
    // JMP 0x1000:5a8b (1000_5A27 / 0x15A27)
    goto label_1000_5A8B_15A8B;
    label_1000_5A29_15A29:
    CheckExternalEvents(cs8, 0x5A2C);
    // PUSH word ptr [BP + 0x6] (1000_5A29 / 0x15A29)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x6)]);
    CheckExternalEvents(cs8, 0x5A31);
    // CALLF 0x0000:2e32 (1000_5A2C / 0x15A2C)
    FarCall(cs8, 0x5A31, unknown_0170_1732_02E32);
    CheckExternalEvents(cs8, 0x5A34);
    // ADD SP,0x2 (1000_5A31 / 0x15A31)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x5A37);
    // MOV BX,word ptr [BP + 0x6] (1000_5A34 / 0x15A34)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5A3B);
    // MOV ES,word ptr [0x5642] (1000_5A37 / 0x15A37)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs8, 0x5A40);
    // MOV byte ptr ES:[BX + 0x409a],AL (1000_5A3B / 0x15A3B)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    CheckExternalEvents(cs8, 0x5A44);
    // CMP word ptr [BP + 0xe],0x0 (1000_5A40 / 0x15A40)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xE)], 0x0);
    CheckExternalEvents(cs8, 0x5A46);
    // JZ 0x1000:5a5d (1000_5A44 / 0x15A44)
    if(ZeroFlag) {
      goto label_1000_5A5D_15A5D;
    }
    CheckExternalEvents(cs8, 0x5A49);
    // PUSH word ptr [BP + 0x8] (1000_5A46 / 0x15A46)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x5A4E);
    // CALLF 0x0000:2e32 (1000_5A49 / 0x15A49)
    FarCall(cs8, 0x5A4E, unknown_0170_1732_02E32);
    CheckExternalEvents(cs8, 0x5A51);
    // ADD SP,0x2 (1000_5A4E / 0x15A4E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x5A54);
    // MOV BX,word ptr [BP + 0x8] (1000_5A51 / 0x15A51)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x5A58);
    // MOV ES,word ptr [0x5642] (1000_5A54 / 0x15A54)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs8, 0x5A5D);
    // MOV byte ptr ES:[BX + 0x409a],AL (1000_5A58 / 0x15A58)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    label_1000_5A5D_15A5D:
    CheckExternalEvents(cs8, 0x5A60);
    // MOV BX,word ptr [BP + 0x6] (1000_5A5D / 0x15A5D)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5A64);
    // MOV ES,word ptr [0x567e] (1000_5A60 / 0x15A60)
    ES = UInt16[DS, 0x567E];
    CheckExternalEvents(cs8, 0x5A6A);
    // CMP byte ptr ES:[BX + 0x42f6],0x0 (1000_5A64 / 0x15A64)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x42F6)], 0x0);
    CheckExternalEvents(cs8, 0x5A6C);
    // JZ 0x1000:5a8b (1000_5A6A / 0x15A6A)
    if(ZeroFlag) {
      goto label_1000_5A8B_15A8B;
    }
    CheckExternalEvents(cs8, 0x5A6F);
    // PUSH word ptr [BP + 0x1a] (1000_5A6C / 0x15A6C)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x1A)]);
    CheckExternalEvents(cs8, 0x5A72);
    // PUSH word ptr [BP + 0x18] (1000_5A6F / 0x15A6F)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x18)]);
    CheckExternalEvents(cs8, 0x5A77);
    // CALLF 0x1000:1919 (1000_5A72 / 0x15A72)
    FarCall(cs8, 0x5A77, ghidra_guess_1000_1919_11919);
    CheckExternalEvents(cs8, 0x5A7A);
    // ADD SP,0x4 (1000_5A77 / 0x15A77)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x5A7F);
    // CALLF 0x1000:9193 (1000_5A7A / 0x15A7A)
    FarCall(cs8, 0x5A7F, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs8, 0x5A82);
    // MOV AX,0x5 (1000_5A7F / 0x15A7F)
    AX = 0x5;
    CheckExternalEvents(cs8, 0x5A83);
    // PUSH AX (1000_5A82 / 0x15A82)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5A88);
    // CALLF 0x1000:8ad6 (1000_5A83 / 0x15A83)
    FarCall(cs8, 0x5A88, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs8, 0x5A8B);
    // ADD SP,0x2 (1000_5A88 / 0x15A88)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_5A8B_15A8B:
    CheckExternalEvents(cs8, 0x5A8E);
    // MOV BX,word ptr [BP + 0x6] (1000_5A8B / 0x15A8B)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5A90);
    // SHL BX,0x1 (1000_5A8E / 0x15A8E)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x5A92);
    // SHL BX,0x1 (1000_5A90 / 0x15A90)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x5A96);
    // MOV ES,word ptr [0x5640] (1000_5A92 / 0x15A92)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x5A9B);
    // LES BX,ES:[BX + 0x1f6] (1000_5A96 / 0x15A96)
    BX = UInt16[ES, (ushort)(BX + 0x1F6)];
    ES = UInt16[ES, (ushort)(BX + 0x1F6 + 2)];
    CheckExternalEvents(cs8, 0x5A9F);
    // CMP byte ptr ES:[BX],0xff (1000_5A9B / 0x15A9B)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0xFF);
    CheckExternalEvents(cs8, 0x5AA1);
    // JNZ 0x1000:5a29 (1000_5A9F / 0x15A9F)
    if(!ZeroFlag) {
      goto label_1000_5A29_15A29;
    }
    CheckExternalEvents(cs8, 0x5AA5);
    // CMP word ptr [BP + 0xa],0x3 (1000_5AA1 / 0x15AA1)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x3);
    CheckExternalEvents(cs8, 0x5AA7);
    // JGE 0x1000:5ab3 (1000_5AA5 / 0x15AA5)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5AB3_15AB3;
    }
    CheckExternalEvents(cs8, 0x5AAA);
    // MOV AX,0xd (1000_5AA7 / 0x15AA7)
    AX = 0xD;
    CheckExternalEvents(cs8, 0x5AAB);
    // PUSH AX (1000_5AAA / 0x15AAA)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5AB0);
    // CALLF 0x0000:30bf (1000_5AAB / 0x15AAB)
    FarCall(cs8, 0x5AB0, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5AB3);
    // ADD SP,0x2 (1000_5AB0 / 0x15AB0)
    SP += 0x2;
    label_1000_5AB3_15AB3:
    CheckExternalEvents(cs8, 0x5AB7);
    // CMP word ptr [BP + 0xa],0x17 (1000_5AB3 / 0x15AB3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x17);
    CheckExternalEvents(cs8, 0x5AB9);
    // JZ 0x1000:5acb (1000_5AB7 / 0x15AB7)
    if(ZeroFlag) {
      goto label_1000_5ACB_15ACB;
    }
    CheckExternalEvents(cs8, 0x5ABD);
    // CMP word ptr [BP + 0xa],0x9 (1000_5AB9 / 0x15AB9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x9);
    CheckExternalEvents(cs8, 0x5ABF);
    // JZ 0x1000:5acb (1000_5ABD / 0x15ABD)
    if(ZeroFlag) {
      goto label_1000_5ACB_15ACB;
    }
    CheckExternalEvents(cs8, 0x5AC3);
    // CMP word ptr [BP + 0xa],0x13 (1000_5ABF / 0x15ABF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x13);
    CheckExternalEvents(cs8, 0x5AC5);
    // JL 0x1000:5ad7 (1000_5AC3 / 0x15AC3)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5AD7_15AD7;
    }
    CheckExternalEvents(cs8, 0x5AC9);
    // CMP word ptr [BP + 0xa],0x16 (1000_5AC5 / 0x15AC5)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x16);
    CheckExternalEvents(cs8, 0x5ACB);
    // JG 0x1000:5ad7 (1000_5AC9 / 0x15AC9)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5AD7_15AD7;
    }
    label_1000_5ACB_15ACB:
    CheckExternalEvents(cs8, 0x5ACE);
    // MOV AX,0x3 (1000_5ACB / 0x15ACB)
    AX = 0x3;
    CheckExternalEvents(cs8, 0x5ACF);
    // PUSH AX (1000_5ACE / 0x15ACE)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5AD4);
    // CALLF 0x0000:30bf (1000_5ACF / 0x15ACF)
    FarCall(cs8, 0x5AD4, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5AD7);
    // ADD SP,0x2 (1000_5AD4 / 0x15AD4)
    SP += 0x2;
    label_1000_5AD7_15AD7:
    CheckExternalEvents(cs8, 0x5ADB);
    // CMP word ptr [BP + 0xa],0x3 (1000_5AD7 / 0x15AD7)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x3);
    CheckExternalEvents(cs8, 0x5ADD);
    // JNZ 0x1000:5ae9 (1000_5ADB / 0x15ADB)
    if(!ZeroFlag) {
      goto label_1000_5AE9_15AE9;
    }
    CheckExternalEvents(cs8, 0x5AE0);
    // MOV AX,0x5 (1000_5ADD / 0x15ADD)
    AX = 0x5;
    CheckExternalEvents(cs8, 0x5AE1);
    // PUSH AX (1000_5AE0 / 0x15AE0)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5AE6);
    // CALLF 0x0000:30bf (1000_5AE1 / 0x15AE1)
    FarCall(cs8, 0x5AE6, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5AE9);
    // ADD SP,0x2 (1000_5AE6 / 0x15AE6)
    SP += 0x2;
    label_1000_5AE9_15AE9:
    CheckExternalEvents(cs8, 0x5AED);
    // CMP word ptr [BP + 0xa],0x7 (1000_5AE9 / 0x15AE9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x7);
    CheckExternalEvents(cs8, 0x5AEF);
    // JZ 0x1000:5af5 (1000_5AED / 0x15AED)
    if(ZeroFlag) {
      goto label_1000_5AF5_15AF5;
    }
    CheckExternalEvents(cs8, 0x5AF3);
    // CMP word ptr [BP + 0xa],0x8 (1000_5AEF / 0x15AEF)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x8);
    CheckExternalEvents(cs8, 0x5AF5);
    // JNZ 0x1000:5b01 (1000_5AF3 / 0x15AF3)
    if(!ZeroFlag) {
      goto label_1000_5B01_15B01;
    }
    label_1000_5AF5_15AF5:
    CheckExternalEvents(cs8, 0x5AF8);
    // MOV AX,0x6 (1000_5AF5 / 0x15AF5)
    AX = 0x6;
    CheckExternalEvents(cs8, 0x5AF9);
    // PUSH AX (1000_5AF8 / 0x15AF8)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5AFE);
    // CALLF 0x0000:30bf (1000_5AF9 / 0x15AF9)
    FarCall(cs8, 0x5AFE, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5B01);
    // ADD SP,0x2 (1000_5AFE / 0x15AFE)
    SP += 0x2;
    label_1000_5B01_15B01:
    CheckExternalEvents(cs8, 0x5B05);
    // CMP word ptr [BP + 0xa],0x4 (1000_5B01 / 0x15B01)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x4);
    CheckExternalEvents(cs8, 0x5B07);
    // JL 0x1000:5b19 (1000_5B05 / 0x15B05)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5B19_15B19;
    }
    CheckExternalEvents(cs8, 0x5B0B);
    // CMP word ptr [BP + 0xa],0x6 (1000_5B07 / 0x15B07)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x6);
    CheckExternalEvents(cs8, 0x5B0D);
    // JG 0x1000:5b19 (1000_5B0B / 0x15B0B)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5B19_15B19;
    }
    CheckExternalEvents(cs8, 0x5B10);
    // MOV AX,0xb (1000_5B0D / 0x15B0D)
    AX = 0xB;
    CheckExternalEvents(cs8, 0x5B11);
    // PUSH AX (1000_5B10 / 0x15B10)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5B16);
    // CALLF 0x0000:30bf (1000_5B11 / 0x15B11)
    FarCall(cs8, 0x5B16, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5B19);
    // ADD SP,0x2 (1000_5B16 / 0x15B16)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_5B19_15B19:
    CheckExternalEvents(cs8, 0x5B1E);
    // MOV word ptr [BP + -0x18],0x0 (1000_5B19 / 0x15B19)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x0;
    CheckExternalEvents(cs8, 0x5B22);
    // CMP word ptr [BP + 0xa],0xa (1000_5B1E / 0x15B1E)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xA);
    CheckExternalEvents(cs8, 0x5B24);
    // JZ 0x1000:5b2a (1000_5B22 / 0x15B22)
    if(ZeroFlag) {
      goto label_1000_5B2A_15B2A;
    }
    CheckExternalEvents(cs8, 0x5B28);
    // CMP word ptr [BP + 0xa],0xb (1000_5B24 / 0x15B24)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xB);
    CheckExternalEvents(cs8, 0x5B2A);
    // JNZ 0x1000:5b2f (1000_5B28 / 0x15B28)
    if(!ZeroFlag) {
      goto label_1000_5B2F_15B2F;
    }
    label_1000_5B2A_15B2A:
    CheckExternalEvents(cs8, 0x5B2F);
    // MOV word ptr [BP + -0x18],0x1 (1000_5B2A / 0x15B2A)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x1;
    label_1000_5B2F_15B2F:
    CheckExternalEvents(cs8, 0x5B33);
    // CMP word ptr [BP + 0xa],0x19 (1000_5B2F / 0x15B2F)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x19);
    CheckExternalEvents(cs8, 0x5B35);
    // JL 0x1000:5b40 (1000_5B33 / 0x15B33)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5B40_15B40;
    }
    CheckExternalEvents(cs8, 0x5B39);
    // CMP word ptr [BP + 0xa],0x1f (1000_5B35 / 0x15B35)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x1F);
    CheckExternalEvents(cs8, 0x5B3B);
    // JG 0x1000:5b40 (1000_5B39 / 0x15B39)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5B40_15B40;
    }
    CheckExternalEvents(cs8, 0x5B40);
    // MOV word ptr [BP + -0x18],0x1 (1000_5B3B / 0x15B3B)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x1;
    label_1000_5B40_15B40:
    CheckExternalEvents(cs8, 0x5B45);
    // MOV word ptr [BP + -0x8],0x0 (1000_5B40 / 0x15B40)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x0;
    CheckExternalEvents(cs8, 0x5B49);
    // CMP word ptr [BP + 0xa],0xc (1000_5B45 / 0x15B45)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xC);
    CheckExternalEvents(cs8, 0x5B4B);
    // JZ 0x1000:5b51 (1000_5B49 / 0x15B49)
    if(ZeroFlag) {
      goto label_1000_5B51_15B51;
    }
    CheckExternalEvents(cs8, 0x5B4F);
    // CMP word ptr [BP + 0xa],0xd (1000_5B4B / 0x15B4B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xD);
    CheckExternalEvents(cs8, 0x5B51);
    // JNZ 0x1000:5b7c (1000_5B4F / 0x15B4F)
    if(!ZeroFlag) {
      goto label_1000_5B7C_15B7C;
    }
    label_1000_5B51_15B51:
    CheckExternalEvents(cs8, 0x5B56);
    // MOV word ptr [BP + -0x18],0x2 (1000_5B51 / 0x15B51)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x2;
    CheckExternalEvents(cs8, 0x5B5B);
    // MOV word ptr [BP + -0x2c],0xe (1000_5B56 / 0x15B56)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xE;
    CheckExternalEvents(cs8, 0x5B5F);
    // CMP word ptr [BP + 0x6],0x10 (1000_5B5B / 0x15B5B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs8, 0x5B61);
    // JL 0x1000:5b66 (1000_5B5F / 0x15B5F)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5B66_15B66;
    }
    CheckExternalEvents(cs8, 0x5B66);
    // MOV word ptr [BP + -0x2c],0xa (1000_5B61 / 0x15B61)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xA;
    label_1000_5B66_15B66:
    CheckExternalEvents(cs8, 0x5B6A);
    // MOV ES,word ptr [0x5680] (1000_5B66 / 0x15B66)
    ES = UInt16[DS, 0x5680];
    CheckExternalEvents(cs8, 0x5B70);
    // CMP word ptr ES:[0x4fba],0x0 (1000_5B6A / 0x15B6A)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs8, 0x5B72);
    // JNZ 0x1000:5b77 (1000_5B70 / 0x15B70)
    if(!ZeroFlag) {
      goto label_1000_5B77_15B77;
    }
    CheckExternalEvents(cs8, 0x5B77);
    // MOV word ptr [BP + -0x2c],0x3 (1000_5B72 / 0x15B72)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x3;
    label_1000_5B77_15B77:
    CheckExternalEvents(cs8, 0x5B7C);
    // MOV word ptr [BP + -0x8],0x1 (1000_5B77 / 0x15B77)
    UInt16[SS, (ushort)(BP - 0x8)] = 0x1;
    label_1000_5B7C_15B7C:
    CheckExternalEvents(cs8, 0x5B80);
    // CMP word ptr [BP + 0xa],0xf (1000_5B7C / 0x15B7C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0xF);
    CheckExternalEvents(cs8, 0x5B82);
    // JL 0x1000:5be5 (1000_5B80 / 0x15B80)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5BE5_15BE5;
    }
    CheckExternalEvents(cs8, 0x5B86);
    // CMP word ptr [BP + 0xa],0x12 (1000_5B82 / 0x15B82)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x12);
    CheckExternalEvents(cs8, 0x5B88);
    // JG 0x1000:5be5 (1000_5B86 / 0x15B86)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5BE5_15BE5;
    }
    CheckExternalEvents(cs8, 0x5B8D);
    // MOV word ptr [BP + -0x18],0x3 (1000_5B88 / 0x15B88)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x3;
    CheckExternalEvents(cs8, 0x5B92);
    // MOV word ptr [BP + -0x2c],0xc (1000_5B8D / 0x15B8D)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0xC;
    CheckExternalEvents(cs8, 0x5B96);
    // CMP word ptr [BP + 0x6],0xc (1000_5B92 / 0x15B92)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs8, 0x5B98);
    // JL 0x1000:5bb9 (1000_5B96 / 0x15B96)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5BB9_15BB9;
    }
    CheckExternalEvents(cs8, 0x5B9D);
    // MOV word ptr [BP + -0x2c],0x5 (1000_5B98 / 0x15B98)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x5;
    CheckExternalEvents(cs8, 0x5BA1);
    // CMP word ptr [BP + 0x8],0x0 (1000_5B9D / 0x15B9D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x0);
    CheckExternalEvents(cs8, 0x5BA3);
    // JNZ 0x1000:5bd4 (1000_5BA1 / 0x15BA1)
    if(!ZeroFlag) {
      goto label_1000_5BD4_15BD4;
    }
    CheckExternalEvents(cs8, 0x5BA6);
    // MOV BX,word ptr [BP + 0x6] (1000_5BA3 / 0x15BA3)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5BAA);
    // MOV ES,word ptr [0x567a] (1000_5BA6 / 0x15BA6)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x5BB0);
    // CMP byte ptr ES:[BX + 0xd55e],0x0 (1000_5BAA / 0x15BAA)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x0);
    CheckExternalEvents(cs8, 0x5BB2);
    // JZ 0x1000:5bd4 (1000_5BB0 / 0x15BB0)
    if(ZeroFlag) {
      goto label_1000_5BD4_15BD4;
    }
    CheckExternalEvents(cs8, 0x5BB7);
    // MOV word ptr [BP + -0x24],0x3 (1000_5BB2 / 0x15BB2)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x3;
    CheckExternalEvents(cs8, 0x5BB9);
    // JMP 0x1000:5bd4 (1000_5BB7 / 0x15BB7)
    goto label_1000_5BD4_15BD4;
    label_1000_5BB9_15BB9:
    CheckExternalEvents(cs8, 0x5BBC);
    // MOV BX,word ptr [BP + 0x6] (1000_5BB9 / 0x15BB9)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5BC0);
    // MOV ES,word ptr [0x567a] (1000_5BBC / 0x15BBC)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x5BC6);
    // CMP byte ptr ES:[BX + 0xd55e],0x0 (1000_5BC0 / 0x15BC0)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x0);
    CheckExternalEvents(cs8, 0x5BC8);
    // JNZ 0x1000:5bcf (1000_5BC6 / 0x15BC6)
    if(!ZeroFlag) {
      goto label_1000_5BCF_15BCF;
    }
    CheckExternalEvents(cs8, 0x5BCD);
    // MOV word ptr [BP + -0x24],0x4 (1000_5BC8 / 0x15BC8)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x4;
    CheckExternalEvents(cs8, 0x5BCF);
    // JMP 0x1000:5bd4 (1000_5BCD / 0x15BCD)
    goto label_1000_5BD4_15BD4;
    label_1000_5BCF_15BCF:
    CheckExternalEvents(cs8, 0x5BD4);
    // MOV word ptr [BP + -0x24],0x7 (1000_5BCF / 0x15BCF)
    UInt16[SS, (ushort)(BP - 0x24)] = 0x7;
    label_1000_5BD4_15BD4:
    CheckExternalEvents(cs8, 0x5BD8);
    // MOV ES,word ptr [0x5680] (1000_5BD4 / 0x15BD4)
    ES = UInt16[DS, 0x5680];
    CheckExternalEvents(cs8, 0x5BDE);
    // CMP word ptr ES:[0x4fba],0x0 (1000_5BD8 / 0x15BD8)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs8, 0x5BE0);
    // JNZ 0x1000:5be5 (1000_5BDE / 0x15BDE)
    if(!ZeroFlag) {
      goto label_1000_5BE5_15BE5;
    }
    CheckExternalEvents(cs8, 0x5BE5);
    // MOV word ptr [BP + -0x2c],0x2 (1000_5BE0 / 0x15BE0)
    UInt16[SS, (ushort)(BP - 0x2C)] = 0x2;
    label_1000_5BE5_15BE5:
    CheckExternalEvents(cs8, 0x5BE9);
    // CMP word ptr [BP + -0x18],0x0 (1000_5BE5 / 0x15BE5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x0);
    CheckExternalEvents(cs8, 0x5BEB);
    // JNZ 0x1000:5bee (1000_5BE9 / 0x15BE9)
    if(!ZeroFlag) {
      goto label_1000_5BEE_15BEE;
    }
    CheckExternalEvents(cs8, 0x5BEE);
    // JMP 0x1000:5f87 (1000_5BEB / 0x15BEB)
    goto label_1000_5F87_15F87;
    label_1000_5BEE_15BEE:
    CheckExternalEvents(cs8, 0x5BF2);
    // CMP word ptr [BP + -0x18],0x1 (1000_5BEE / 0x15BEE)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x1);
    CheckExternalEvents(cs8, 0x5BF4);
    // JNZ 0x1000:5c00 (1000_5BF2 / 0x15BF2)
    if(!ZeroFlag) {
      goto label_1000_5C00_15C00;
    }
    CheckExternalEvents(cs8, 0x5BF7);
    // MOV AX,0x1 (1000_5BF4 / 0x15BF4)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x5BF8);
    // PUSH AX (1000_5BF7 / 0x15BF7)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5BFD);
    // CALLF 0x0000:30bf (1000_5BF8 / 0x15BF8)
    FarCall(cs8, 0x5BFD, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5C00);
    // ADD SP,0x2 (1000_5BFD / 0x15BFD)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_5C00_15C00:
    CheckExternalEvents(cs8, 0x5C03);
    // MOV BX,word ptr [BP + 0x6] (1000_5C00 / 0x15C00)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5C07);
    // MOV ES,word ptr [0x567e] (1000_5C03 / 0x15C03)
    ES = UInt16[DS, 0x567E];
    CheckExternalEvents(cs8, 0x5C0D);
    // CMP byte ptr ES:[BX + 0x42f6],0x0 (1000_5C07 / 0x15C07)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x42F6)], 0x0);
    CheckExternalEvents(cs8, 0x5C0F);
    // JNZ 0x1000:5c1d (1000_5C0D / 0x15C0D)
    if(!ZeroFlag) {
      goto label_1000_5C1D_15C1D;
    }
    CheckExternalEvents(cs8, 0x5C12);
    // MOV BX,word ptr [BP + 0x8] (1000_5C0F / 0x15C0F)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x5C18);
    // CMP byte ptr ES:[BX + 0x42f6],0x0 (1000_5C12 / 0x15C12)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x42F6)], 0x0);
    CheckExternalEvents(cs8, 0x5C1A);
    // JNZ 0x1000:5c1d (1000_5C18 / 0x15C18)
    if(!ZeroFlag) {
      goto label_1000_5C1D_15C1D;
    }
    CheckExternalEvents(cs8, 0x5C1D);
    // JMP 0x1000:5f87 (1000_5C1A / 0x15C1A)
    goto label_1000_5F87_15F87;
    label_1000_5C1D_15C1D:
    CheckExternalEvents(cs8, 0x5C20);
    // MOV BX,word ptr [BP + 0x6] (1000_5C1D / 0x15C1D)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5C26);
    // CMP byte ptr ES:[BX + 0x42f6],0x0 (1000_5C20 / 0x15C20)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x42F6)], 0x0);
    CheckExternalEvents(cs8, 0x5C28);
    // JZ 0x1000:5c43 (1000_5C26 / 0x15C26)
    if(ZeroFlag) {
      goto label_1000_5C43_15C43;
    }
    CheckExternalEvents(cs8, 0x5C2A);
    // MOV SI,BX (1000_5C28 / 0x15C28)
    SI = BX;
    CheckExternalEvents(cs8, 0x5C2C);
    // SHL SI,0x1 (1000_5C2A / 0x15C2A)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x5C30);
    // MOV ES,word ptr [0x5682] (1000_5C2C / 0x15C2C)
    ES = UInt16[DS, 0x5682];
    CheckExternalEvents(cs8, 0x5C35);
    // MOV AX,word ptr ES:[SI + 0x324c] (1000_5C30 / 0x15C30)
    AX = UInt16[ES, (ushort)(SI + 0x324C)];
    CheckExternalEvents(cs8, 0x5C38);
    // MOV word ptr [BP + -0x1e],AX (1000_5C35 / 0x15C35)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs8, 0x5C3C);
    // MOV ES,word ptr [0x5684] (1000_5C38 / 0x15C38)
    ES = UInt16[DS, 0x5684];
    CheckExternalEvents(cs8, 0x5C41);
    // MOV AX,word ptr ES:[SI + 0x327c] (1000_5C3C / 0x15C3C)
    AX = UInt16[ES, (ushort)(SI + 0x327C)];
    CheckExternalEvents(cs8, 0x5C43);
    // JMP 0x1000:5c80 (1000_5C41 / 0x15C41)
    goto label_1000_5C80_15C80;
    label_1000_5C43_15C43:
    CheckExternalEvents(cs8, 0x5C45);
    // MOV SI,BX (1000_5C43 / 0x15C43)
    SI = BX;
    CheckExternalEvents(cs8, 0x5C47);
    // SHL SI,0x1 (1000_5C45 / 0x15C45)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x5C4B);
    // MOV ES,word ptr [0x5636] (1000_5C47 / 0x15C47)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x5C50);
    // PUSH word ptr ES:[SI + 0x4036] (1000_5C4B / 0x15C4B)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x5C54);
    // MOV ES,word ptr [0x5638] (1000_5C50 / 0x15C50)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x5C59);
    // PUSH word ptr ES:[SI + 0x4004] (1000_5C54 / 0x15C54)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x5C5C);
    // PUSH word ptr [BP + -0x12] (1000_5C59 / 0x15C59)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs8, 0x5C5F);
    // PUSH word ptr [BP + -0x10] (1000_5C5C / 0x15C5C)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs8, 0x5C64);
    // CALLF 0x1000:1808 (1000_5C5F / 0x15C5F)
    FarCall(cs8, 0x5C64, ghidra_guess_1000_1808_11808);
    CheckExternalEvents(cs8, 0x5C67);
    // ADD SP,0x8 (1000_5C64 / 0x15C64)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x5C6B);
    // MOV ES,word ptr [0x5686] (1000_5C67 / 0x15C67)
    ES = UInt16[DS, 0x5686];
    CheckExternalEvents(cs8, 0x5C6F);
    // MOV AX,ES:[0xe486] (1000_5C6B / 0x15C6B)
    AX = UInt16[ES, 0xE486];
    CheckExternalEvents(cs8, 0x5C71);
    // MOV CL,0x3 (1000_5C6F / 0x15C6F)
    CL = 0x3;
    CheckExternalEvents(cs8, 0x5C73);
    // SHL AX,CL (1000_5C71 / 0x15C71)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs8, 0x5C76);
    // MOV word ptr [BP + -0x1e],AX (1000_5C73 / 0x15C73)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs8, 0x5C7A);
    // MOV ES,word ptr [0x5688] (1000_5C76 / 0x15C76)
    ES = UInt16[DS, 0x5688];
    CheckExternalEvents(cs8, 0x5C7E);
    // MOV AX,ES:[0xe488] (1000_5C7A / 0x15C7A)
    AX = UInt16[ES, 0xE488];
    CheckExternalEvents(cs8, 0x5C80);
    // SHL AX,CL (1000_5C7E / 0x15C7E)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    label_1000_5C80_15C80:
    CheckExternalEvents(cs8, 0x5C83);
    // MOV word ptr [BP + -0x22],AX (1000_5C80 / 0x15C80)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs8, 0x5C86);
    // MOV BX,word ptr [BP + 0x8] (1000_5C83 / 0x15C83)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x5C8A);
    // MOV ES,word ptr [0x567e] (1000_5C86 / 0x15C86)
    ES = UInt16[DS, 0x567E];
    CheckExternalEvents(cs8, 0x5C90);
    // CMP byte ptr ES:[BX + 0x42f6],0x0 (1000_5C8A / 0x15C8A)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x42F6)], 0x0);
    CheckExternalEvents(cs8, 0x5C92);
    // JZ 0x1000:5cad (1000_5C90 / 0x15C90)
    if(ZeroFlag) {
      goto label_1000_5CAD_15CAD;
    }
    CheckExternalEvents(cs8, 0x5C94);
    // MOV SI,BX (1000_5C92 / 0x15C92)
    SI = BX;
    CheckExternalEvents(cs8, 0x5C96);
    // SHL SI,0x1 (1000_5C94 / 0x15C94)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x5C9A);
    // MOV ES,word ptr [0x5682] (1000_5C96 / 0x15C96)
    ES = UInt16[DS, 0x5682];
    CheckExternalEvents(cs8, 0x5C9F);
    // MOV AX,word ptr ES:[SI + 0x324c] (1000_5C9A / 0x15C9A)
    AX = UInt16[ES, (ushort)(SI + 0x324C)];
    CheckExternalEvents(cs8, 0x5CA2);
    // MOV word ptr [BP + -0x20],AX (1000_5C9F / 0x15C9F)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs8, 0x5CA6);
    // MOV ES,word ptr [0x5684] (1000_5CA2 / 0x15CA2)
    ES = UInt16[DS, 0x5684];
    CheckExternalEvents(cs8, 0x5CAB);
    // MOV AX,word ptr ES:[SI + 0x327c] (1000_5CA6 / 0x15CA6)
    AX = UInt16[ES, (ushort)(SI + 0x327C)];
    CheckExternalEvents(cs8, 0x5CAD);
    // JMP 0x1000:5cea (1000_5CAB / 0x15CAB)
    goto label_1000_5CEA_15CEA;
    label_1000_5CAD_15CAD:
    CheckExternalEvents(cs8, 0x5CAF);
    // MOV SI,BX (1000_5CAD / 0x15CAD)
    SI = BX;
    CheckExternalEvents(cs8, 0x5CB1);
    // SHL SI,0x1 (1000_5CAF / 0x15CAF)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x5CB5);
    // MOV ES,word ptr [0x5636] (1000_5CB1 / 0x15CB1)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x5CBA);
    // PUSH word ptr ES:[SI + 0x4036] (1000_5CB5 / 0x15CB5)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x5CBE);
    // MOV ES,word ptr [0x5638] (1000_5CBA / 0x15CBA)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x5CC3);
    // PUSH word ptr ES:[SI + 0x4004] (1000_5CBE / 0x15CBE)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x5CC6);
    // PUSH word ptr [BP + -0x12] (1000_5CC3 / 0x15CC3)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs8, 0x5CC9);
    // PUSH word ptr [BP + -0x10] (1000_5CC6 / 0x15CC6)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x10)]);
    CheckExternalEvents(cs8, 0x5CCE);
    // CALLF 0x1000:1808 (1000_5CC9 / 0x15CC9)
    FarCall(cs8, 0x5CCE, ghidra_guess_1000_1808_11808);
    CheckExternalEvents(cs8, 0x5CD1);
    // ADD SP,0x8 (1000_5CCE / 0x15CCE)
    // SP += 0x8;
    SP = Alu16.Add(SP, 0x8);
    CheckExternalEvents(cs8, 0x5CD5);
    // MOV ES,word ptr [0x5686] (1000_5CD1 / 0x15CD1)
    ES = UInt16[DS, 0x5686];
    CheckExternalEvents(cs8, 0x5CD9);
    // MOV AX,ES:[0xe486] (1000_5CD5 / 0x15CD5)
    AX = UInt16[ES, 0xE486];
    CheckExternalEvents(cs8, 0x5CDB);
    // MOV CL,0x3 (1000_5CD9 / 0x15CD9)
    CL = 0x3;
    CheckExternalEvents(cs8, 0x5CDD);
    // SHL AX,CL (1000_5CDB / 0x15CDB)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    CheckExternalEvents(cs8, 0x5CE0);
    // MOV word ptr [BP + -0x20],AX (1000_5CDD / 0x15CDD)
    UInt16[SS, (ushort)(BP - 0x20)] = AX;
    CheckExternalEvents(cs8, 0x5CE4);
    // MOV ES,word ptr [0x5688] (1000_5CE0 / 0x15CE0)
    ES = UInt16[DS, 0x5688];
    CheckExternalEvents(cs8, 0x5CE8);
    // MOV AX,ES:[0xe488] (1000_5CE4 / 0x15CE4)
    AX = UInt16[ES, 0xE488];
    CheckExternalEvents(cs8, 0x5CEA);
    // SHL AX,CL (1000_5CE8 / 0x15CE8)
    // AX <<= CL;
    AX = Alu16.Shl(AX, CL);
    label_1000_5CEA_15CEA:
    CheckExternalEvents(cs8, 0x5CED);
    // MOV word ptr [BP + -0x28],AX (1000_5CEA / 0x15CEA)
    UInt16[SS, (ushort)(BP - 0x28)] = AX;
    CheckExternalEvents(cs8, 0x5CF1);
    // CMP word ptr [BP + 0x8],0x4 (1000_5CED / 0x15CED)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x4);
    CheckExternalEvents(cs8, 0x5CF3);
    // JL 0x1000:5cff (1000_5CF1 / 0x15CF1)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5CFF_15CFF;
    }
    CheckExternalEvents(cs8, 0x5CF7);
    // CMP word ptr [BP + 0x8],0xc (1000_5CF3 / 0x15CF3)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xC);
    CheckExternalEvents(cs8, 0x5CF9);
    // JL 0x1000:5d03 (1000_5CF7 / 0x15CF7)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5D03_15D03;
    }
    CheckExternalEvents(cs8, 0x5CFD);
    // CMP word ptr [BP + 0x8],0x10 (1000_5CF9 / 0x15CF9)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0x10);
    CheckExternalEvents(cs8, 0x5CFF);
    // JGE 0x1000:5d03 (1000_5CFD / 0x15CFD)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5D03_15D03;
    }
    label_1000_5CFF_15CFF:
    CheckExternalEvents(cs8, 0x5D03);
    // SUB word ptr [BP + -0x28],0x8 (1000_5CFF / 0x15CFF)
    UInt16[SS, (ushort)(BP - 0x28)] -= 0x8;
    label_1000_5D03_15D03:
    CheckExternalEvents(cs8, 0x5D07);
    // CMP word ptr [BP + -0x18],0x1 (1000_5D03 / 0x15D03)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x1);
    CheckExternalEvents(cs8, 0x5D09);
    // JZ 0x1000:5d85 (1000_5D07 / 0x15D07)
    if(ZeroFlag) {
      goto label_1000_5D85_15D85;
    }
    CheckExternalEvents(cs8, 0x5D0D);
    // ADD word ptr [BP + -0x20],0x3 (1000_5D09 / 0x15D09)
    UInt16[SS, (ushort)(BP - 0x20)] += 0x3;
    CheckExternalEvents(cs8, 0x5D11);
    // ADD word ptr [BP + -0x28],0x3 (1000_5D0D / 0x15D0D)
    UInt16[SS, (ushort)(BP - 0x28)] += 0x3;
    CheckExternalEvents(cs8, 0x5D15);
    // CMP word ptr [BP + 0x6],0x4 (1000_5D11 / 0x15D11)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs8, 0x5D17);
    // JL 0x1000:5d23 (1000_5D15 / 0x15D15)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5D23_15D23;
    }
    CheckExternalEvents(cs8, 0x5D1B);
    // CMP word ptr [BP + 0x6],0xc (1000_5D17 / 0x15D17)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs8, 0x5D1D);
    // JL 0x1000:5d68 (1000_5D1B / 0x15D1B)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5D68_15D68;
    }
    CheckExternalEvents(cs8, 0x5D21);
    // CMP word ptr [BP + 0x6],0x10 (1000_5D1D / 0x15D1D)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs8, 0x5D23);
    // JGE 0x1000:5d68 (1000_5D21 / 0x15D21)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5D68_15D68;
    }
    label_1000_5D23_15D23:
    CheckExternalEvents(cs8, 0x5D26);
    // MOV BX,word ptr [BP + 0x6] (1000_5D23 / 0x15D23)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x5D2A);
    // MOV ES,word ptr [0x567a] (1000_5D26 / 0x15D26)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x5D30);
    // CMP byte ptr ES:[BX + 0xd55e],0x0 (1000_5D2A / 0x15D2A)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x0);
    CheckExternalEvents(cs8, 0x5D32);
    // JNZ 0x1000:5d4d (1000_5D30 / 0x15D30)
    if(!ZeroFlag) {
      goto label_1000_5D4D_15D4D;
    }
    CheckExternalEvents(cs8, 0x5D35);
    // MOV BX,word ptr [BP + 0xc] (1000_5D32 / 0x15D32)
    BX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x5D39);
    // MOV ES,word ptr [0x568a] (1000_5D35 / 0x15D35)
    ES = UInt16[DS, 0x568A];
    CheckExternalEvents(cs8, 0x5D3E);
    // MOV AL,byte ptr ES:[BX + 0x2d28] (1000_5D39 / 0x15D39)
    AL = UInt8[ES, (ushort)(BX + 0x2D28)];
    CheckExternalEvents(cs8, 0x5D3F);
    // CBW  (1000_5D3E / 0x15D3E)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5D42);
    // ADD word ptr [BP + -0x1e],AX (1000_5D3F / 0x15D3F)
    // UInt16[SS, (ushort)(BP - 0x1E)] += AX;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    CheckExternalEvents(cs8, 0x5D46);
    // MOV ES,word ptr [0x568c] (1000_5D42 / 0x15D42)
    ES = UInt16[DS, 0x568C];
    CheckExternalEvents(cs8, 0x5D4B);
    // MOV AL,byte ptr ES:[BX + 0x2d30] (1000_5D46 / 0x15D46)
    AL = UInt8[ES, (ushort)(BX + 0x2D30)];
    CheckExternalEvents(cs8, 0x5D4D);
    // JMP 0x1000:5d81 (1000_5D4B / 0x15D4B)
    goto label_1000_5D81_15D81;
    label_1000_5D4D_15D4D:
    CheckExternalEvents(cs8, 0x5D50);
    // MOV BX,word ptr [BP + 0xc] (1000_5D4D / 0x15D4D)
    BX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x5D54);
    // MOV ES,word ptr [0x568e] (1000_5D50 / 0x15D50)
    ES = UInt16[DS, 0x568E];
    CheckExternalEvents(cs8, 0x5D59);
    // MOV AL,byte ptr ES:[BX + 0x2d38] (1000_5D54 / 0x15D54)
    AL = UInt8[ES, (ushort)(BX + 0x2D38)];
    CheckExternalEvents(cs8, 0x5D5A);
    // CBW  (1000_5D59 / 0x15D59)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5D5D);
    // ADD word ptr [BP + -0x1e],AX (1000_5D5A / 0x15D5A)
    // UInt16[SS, (ushort)(BP - 0x1E)] += AX;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    CheckExternalEvents(cs8, 0x5D61);
    // MOV ES,word ptr [0x5690] (1000_5D5D / 0x15D5D)
    ES = UInt16[DS, 0x5690];
    CheckExternalEvents(cs8, 0x5D66);
    // MOV AL,byte ptr ES:[BX + 0x2d40] (1000_5D61 / 0x15D61)
    AL = UInt8[ES, (ushort)(BX + 0x2D40)];
    CheckExternalEvents(cs8, 0x5D68);
    // JMP 0x1000:5d81 (1000_5D66 / 0x15D66)
    goto label_1000_5D81_15D81;
    label_1000_5D68_15D68:
    CheckExternalEvents(cs8, 0x5D6B);
    // MOV BX,word ptr [BP + 0xc] (1000_5D68 / 0x15D68)
    BX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x5D6F);
    // MOV ES,word ptr [0x5692] (1000_5D6B / 0x15D6B)
    ES = UInt16[DS, 0x5692];
    CheckExternalEvents(cs8, 0x5D74);
    // MOV AL,byte ptr ES:[BX + 0x2d48] (1000_5D6F / 0x15D6F)
    AL = UInt8[ES, (ushort)(BX + 0x2D48)];
    CheckExternalEvents(cs8, 0x5D75);
    // CBW  (1000_5D74 / 0x15D74)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5D78);
    // ADD word ptr [BP + -0x1e],AX (1000_5D75 / 0x15D75)
    // UInt16[SS, (ushort)(BP - 0x1E)] += AX;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    CheckExternalEvents(cs8, 0x5D7C);
    // MOV ES,word ptr [0x5694] (1000_5D78 / 0x15D78)
    ES = UInt16[DS, 0x5694];
    CheckExternalEvents(cs8, 0x5D81);
    // MOV AL,byte ptr ES:[BX + 0x2d50] (1000_5D7C / 0x15D7C)
    AL = UInt8[ES, (ushort)(BX + 0x2D50)];
    label_1000_5D81_15D81:
    CheckExternalEvents(cs8, 0x5D82);
    // CBW  (1000_5D81 / 0x15D81)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5D85);
    // ADD word ptr [BP + -0x22],AX (1000_5D82 / 0x15D82)
    // UInt16[SS, (ushort)(BP - 0x22)] += AX;
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x22)], AX);
    label_1000_5D85_15D85:
    CheckExternalEvents(cs8, 0x5D88);
    // MOV BX,word ptr [BP + 0xc] (1000_5D85 / 0x15D85)
    BX = UInt16[SS, (ushort)(BP + 0xC)];
    CheckExternalEvents(cs8, 0x5D8A);
    // SHL BX,0x1 (1000_5D88 / 0x15D88)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x5D8C);
    // SHL BX,0x1 (1000_5D8A / 0x15D8A)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x5D90);
    // MOV ES,word ptr [0x5696] (1000_5D8C / 0x15D8C)
    ES = UInt16[DS, 0x5696];
    CheckExternalEvents(cs8, 0x5D95);
    // MOV AX,word ptr ES:[BX + 0x2dd8] (1000_5D90 / 0x15D90)
    AX = UInt16[ES, (ushort)(BX + 0x2DD8)];
    CheckExternalEvents(cs8, 0x5D9A);
    // MOV DX,word ptr ES:[BX + 0x2dda] (1000_5D95 / 0x15D95)
    DX = UInt16[ES, (ushort)(BX + 0x2DDA)];
    CheckExternalEvents(cs8, 0x5D9E);
    // MOV ES,word ptr [0x5640] (1000_5D9A / 0x15D9A)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x5DA2);
    // MOV ES:[0x256],AX (1000_5D9E / 0x15D9E)
    UInt16[ES, 0x256] = AX;
    CheckExternalEvents(cs8, 0x5DA7);
    // MOV word ptr ES:[0x258],DX (1000_5DA2 / 0x15DA2)
    UInt16[ES, 0x258] = DX;
    CheckExternalEvents(cs8, 0x5DAA);
    // MOV AX,word ptr [BP + -0x1e] (1000_5DA7 / 0x15DA7)
    AX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs8, 0x5DAD);
    // SUB AX,word ptr [BP + -0x20] (1000_5DAA / 0x15DAA)
    // AX -= UInt16[SS, (ushort)(BP - 0x20)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x20)]);
    CheckExternalEvents(cs8, 0x5DAE);
    // PUSH AX (1000_5DAD / 0x15DAD)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5DB3);
    // CALLF 0x1000:db5c (1000_5DAE / 0x15DAE)
    FarCall(cs8, 0x5DB3, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs8, 0x5DB6);
    // ADD SP,0x2 (1000_5DB3 / 0x15DB3)
    SP += 0x2;
    CheckExternalEvents(cs8, 0x5DB9);
    // CMP AX,0x8 (1000_5DB6 / 0x15DB6)
    Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs8, 0x5DBB);
    // JG 0x1000:5dd2 (1000_5DB9 / 0x15DB9)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5DD2_15DD2;
    }
    CheckExternalEvents(cs8, 0x5DBE);
    // MOV AX,word ptr [BP + -0x22] (1000_5DBB / 0x15DBB)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs8, 0x5DC1);
    // SUB AX,word ptr [BP + -0x28] (1000_5DBE / 0x15DBE)
    // AX -= UInt16[SS, (ushort)(BP - 0x28)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs8, 0x5DC2);
    // PUSH AX (1000_5DC1 / 0x15DC1)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5DC7);
    // CALLF 0x1000:db5c (1000_5DC2 / 0x15DC2)
    FarCall(cs8, 0x5DC7, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs8, 0x5DCA);
    // ADD SP,0x2 (1000_5DC7 / 0x15DC7)
    SP += 0x2;
    CheckExternalEvents(cs8, 0x5DCD);
    // CMP AX,0x8 (1000_5DCA / 0x15DCA)
    Alu16.Sub(AX, 0x8);
    CheckExternalEvents(cs8, 0x5DCF);
    // JG 0x1000:5dd2 (1000_5DCD / 0x15DCD)
    if(!ZeroFlag && SignFlag == OverflowFlag) {
      goto label_1000_5DD2_15DD2;
    }
    CheckExternalEvents(cs8, 0x5DD2);
    // JMP 0x1000:5f6a (1000_5DCF / 0x15DCF)
    goto label_1000_5F6A_15F6A;
    label_1000_5DD2_15DD2:
    CheckExternalEvents(cs8, 0x5DD5);
    // MOV AX,word ptr [BP + -0x22] (1000_5DD2 / 0x15DD2)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs8, 0x5DD8);
    // SUB AX,word ptr [BP + -0x28] (1000_5DD5 / 0x15DD5)
    // AX -= UInt16[SS, (ushort)(BP - 0x28)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x28)]);
    CheckExternalEvents(cs8, 0x5DDB);
    // MOV word ptr [BP + -0xe],AX (1000_5DD8 / 0x15DD8)
    UInt16[SS, (ushort)(BP - 0xE)] = AX;
    CheckExternalEvents(cs8, 0x5DDE);
    // MOV AX,word ptr [BP + -0x20] (1000_5DDB / 0x15DDB)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs8, 0x5DE1);
    // SUB AX,word ptr [BP + -0x1e] (1000_5DDE / 0x15DDE)
    // AX -= UInt16[SS, (ushort)(BP - 0x1E)];
    AX = Alu16.Sub(AX, UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs8, 0x5DE4);
    // MOV word ptr [BP + -0x14],AX (1000_5DE1 / 0x15DE1)
    UInt16[SS, (ushort)(BP - 0x14)] = AX;
    CheckExternalEvents(cs8, 0x5DE7);
    // PUSH word ptr [BP + -0xe] (1000_5DE4 / 0x15DE4)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs8, 0x5DEC);
    // CALLF 0x1000:db5c (1000_5DE7 / 0x15DE7)
    FarCall(cs8, 0x5DEC, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs8, 0x5DEF);
    // ADD SP,0x2 (1000_5DEC / 0x15DEC)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x5DF2);
    // MOV word ptr [BP + -0x26],AX (1000_5DEF / 0x15DEF)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    CheckExternalEvents(cs8, 0x5DF5);
    // PUSH word ptr [BP + -0x14] (1000_5DF2 / 0x15DF2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs8, 0x5DFA);
    // CALLF 0x1000:db5c (1000_5DF5 / 0x15DF5)
    FarCall(cs8, 0x5DFA, ghidra_guess_1000_DB5C_1DB5C);
    CheckExternalEvents(cs8, 0x5DFD);
    // ADD SP,0x2 (1000_5DFA / 0x15DFA)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x5E00);
    // MOV word ptr [BP + -0x2a],AX (1000_5DFD / 0x15DFD)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs8, 0x5E03);
    // MOV AX,word ptr [BP + -0x26] (1000_5E00 / 0x15E00)
    AX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x5E06);
    // CMP word ptr [BP + -0x2a],AX (1000_5E03 / 0x15E03)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x2A)], AX);
    CheckExternalEvents(cs8, 0x5E08);
    // JLE 0x1000:5e1a (1000_5E06 / 0x15E06)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_5E1A_15E1A;
    }
    CheckExternalEvents(cs8, 0x5E0B);
    // MOV AX,word ptr [BP + -0x2a] (1000_5E08 / 0x15E08)
    AX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs8, 0x5E0E);
    // MOV word ptr [BP + -0x1a],AX (1000_5E0B / 0x15E0B)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs8, 0x5E11);
    // MOV AX,word ptr [BP + -0x26] (1000_5E0E / 0x15E0E)
    AX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x5E14);
    // MOV word ptr [BP + -0x2a],AX (1000_5E11 / 0x15E11)
    UInt16[SS, (ushort)(BP - 0x2A)] = AX;
    CheckExternalEvents(cs8, 0x5E17);
    // MOV AX,word ptr [BP + -0x1a] (1000_5E14 / 0x15E14)
    AX = UInt16[SS, (ushort)(BP - 0x1A)];
    CheckExternalEvents(cs8, 0x5E1A);
    // MOV word ptr [BP + -0x26],AX (1000_5E17 / 0x15E17)
    UInt16[SS, (ushort)(BP - 0x26)] = AX;
    label_1000_5E1A_15E1A:
    CheckExternalEvents(cs8, 0x5E1D);
    // PUSH word ptr [BP + -0x14] (1000_5E1A / 0x15E1A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x14)]);
    CheckExternalEvents(cs8, 0x5E20);
    // PUSH word ptr [BP + -0xe] (1000_5E1D / 0x15E1D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0xE)]);
    CheckExternalEvents(cs8, 0x5E25);
    // CALLF 0x1000:18b2 (1000_5E20 / 0x15E20)
    FarCall(cs8, 0x5E25, ghidra_guess_1000_18B2_118B2);
    CheckExternalEvents(cs8, 0x5E28);
    // ADD SP,0x4 (1000_5E25 / 0x15E25)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x5E2B);
    // MOV word ptr [BP + -0x16],AX (1000_5E28 / 0x15E28)
    UInt16[SS, (ushort)(BP - 0x16)] = AX;
    CheckExternalEvents(cs8, 0x5E2E);
    // MOV AX,word ptr [BP + -0x26] (1000_5E2B / 0x15E2B)
    AX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x5E30);
    // SAR AX,0x1 (1000_5E2E / 0x15E2E)
    AX = Alu16.Sar(AX, 0x1);
    CheckExternalEvents(cs8, 0x5E33);
    // MOV word ptr [BP + -0x1a],AX (1000_5E30 / 0x15E30)
    UInt16[SS, (ushort)(BP - 0x1A)] = AX;
    CheckExternalEvents(cs8, 0x5E36);
    // MOV BX,word ptr [BP + -0x16] (1000_5E33 / 0x15E33)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs8, 0x5E3A);
    // MOV AL,byte ptr [BX + 0x41dc] (1000_5E36 / 0x15E36)
    AL = UInt8[DS, (ushort)(BX + 0x41DC)];
    CheckExternalEvents(cs8, 0x5E3B);
    // CBW  (1000_5E3A / 0x15E3A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5E3E);
    // MOV word ptr [BP + -0x2e],AX (1000_5E3B / 0x15E3B)
    UInt16[SS, (ushort)(BP - 0x2E)] = AX;
    CheckExternalEvents(cs8, 0x5E42);
    // MOV AL,byte ptr [BX + 0x41e4] (1000_5E3E / 0x15E3E)
    AL = UInt8[DS, (ushort)(BX + 0x41E4)];
    CheckExternalEvents(cs8, 0x5E43);
    // CBW  (1000_5E42 / 0x15E42)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5E46);
    // MOV word ptr [BP + -0x2],AX (1000_5E43 / 0x15E43)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs8, 0x5E4A);
    // MOV AL,byte ptr [BX + 0x41ec] (1000_5E46 / 0x15E46)
    AL = UInt8[DS, (ushort)(BX + 0x41EC)];
    CheckExternalEvents(cs8, 0x5E4B);
    // CBW  (1000_5E4A / 0x15E4A)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5E4E);
    // MOV word ptr [BP + -0x6],AX (1000_5E4B / 0x15E4B)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs8, 0x5E52);
    // MOV AL,byte ptr [BX + 0x41f4] (1000_5E4E / 0x15E4E)
    AL = UInt8[DS, (ushort)(BX + 0x41F4)];
    CheckExternalEvents(cs8, 0x5E53);
    // CBW  (1000_5E52 / 0x15E52)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs8, 0x5E56);
    // MOV word ptr [BP + -0xa],AX (1000_5E53 / 0x15E53)
    UInt16[SS, (ushort)(BP - 0xA)] = AX;
    CheckExternalEvents(cs8, 0x5E5A);
    // CMP word ptr [BP + -0x18],0x1 (1000_5E56 / 0x15E56)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x1);
    CheckExternalEvents(cs8, 0x5E5C);
    // JNZ 0x1000:5e6a (1000_5E5A / 0x15E5A)
    if(!ZeroFlag) {
      goto label_1000_5E6A_15E6A;
    }
    CheckExternalEvents(cs8, 0x5E5E);
    // MOV CL,0x2 (1000_5E5C / 0x15E5C)
    CL = 0x2;
    CheckExternalEvents(cs8, 0x5E61);
    // SHL word ptr [BP + -0x2e],CL (1000_5E5E / 0x15E5E)
    UInt16[SS, (ushort)(BP - 0x2E)] <<= CL;
    CheckExternalEvents(cs8, 0x5E64);
    // SHL word ptr [BP + -0x2],CL (1000_5E61 / 0x15E61)
    UInt16[SS, (ushort)(BP - 0x2)] <<= CL;
    CheckExternalEvents(cs8, 0x5E67);
    // SHL word ptr [BP + -0x6],CL (1000_5E64 / 0x15E64)
    UInt16[SS, (ushort)(BP - 0x6)] <<= CL;
    CheckExternalEvents(cs8, 0x5E6A);
    // SHL word ptr [BP + -0xa],CL (1000_5E67 / 0x15E67)
    // UInt16[SS, (ushort)(BP - 0xA)] <<= CL;
    UInt16[SS, (ushort)(BP - 0xA)] = Alu16.Shl(UInt16[SS, (ushort)(BP - 0xA)], CL);
    label_1000_5E6A_15E6A:
    CheckExternalEvents(cs8, 0x5E6D);
    // MOV AX,word ptr [BP + -0x20] (1000_5E6A / 0x15E6A)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs8, 0x5E70);
    // CMP word ptr [BP + -0x1e],AX (1000_5E6D / 0x15E6D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    CheckExternalEvents(cs8, 0x5E72);
    // JNZ 0x1000:5e7d (1000_5E70 / 0x15E70)
    if(!ZeroFlag) {
      goto label_1000_5E7D_15E7D;
    }
    CheckExternalEvents(cs8, 0x5E75);
    // MOV AX,word ptr [BP + -0x28] (1000_5E72 / 0x15E72)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs8, 0x5E78);
    // CMP word ptr [BP + -0x22],AX (1000_5E75 / 0x15E75)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], AX);
    CheckExternalEvents(cs8, 0x5E7A);
    // JNZ 0x1000:5e7d (1000_5E78 / 0x15E78)
    if(!ZeroFlag) {
      goto label_1000_5E7D_15E7D;
    }
    CheckExternalEvents(cs8, 0x5E7D);
    // JMP 0x1000:5f6a (1000_5E7A / 0x15E7A)
    goto label_1000_5F6A_15F6A;
    label_1000_5E7D_15E7D:
    CheckExternalEvents(cs8, 0x5E81);
    // CMP word ptr [BP + -0x18],0x1 (1000_5E7D / 0x15E7D)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x1);
    CheckExternalEvents(cs8, 0x5E83);
    // JNZ 0x1000:5eed (1000_5E81 / 0x15E81)
    if(!ZeroFlag) {
      goto label_1000_5EED_15EED;
    }
    CheckExternalEvents(cs8, 0x5E86);
    // MOV AX,0x18 (1000_5E83 / 0x15E83)
    AX = 0x18;
    CheckExternalEvents(cs8, 0x5E87);
    // PUSH AX (1000_5E86 / 0x15E86)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5E8C);
    // CALLF 0x0000:2e32 (1000_5E87 / 0x15E87)
    FarCall(cs8, 0x5E8C, unknown_0170_1732_02E32);
    CheckExternalEvents(cs8, 0x5E8F);
    // ADD SP,0x2 (1000_5E8C / 0x15E8C)
    SP += 0x2;
    CheckExternalEvents(cs8, 0x5E92);
    // ADD AX,0x68 (1000_5E8F / 0x15E8F)
    // AX += 0x68;
    AX = Alu16.Add(AX, 0x68);
    CheckExternalEvents(cs8, 0x5E95);
    // MOV word ptr [BP + -0x1c],AX (1000_5E92 / 0x15E92)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs8, 0x5E99);
    // CMP word ptr [BP + -0x1e],0x68 (1000_5E95 / 0x15E95)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0x68);
    CheckExternalEvents(cs8, 0x5E9B);
    // JGE 0x1000:5e9e (1000_5E99 / 0x15E99)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5E9E_15E9E;
    }
    CheckExternalEvents(cs8, 0x5E9E);
    // JMP 0x1000:5f1e (1000_5E9B / 0x15E9B)
    goto label_1000_5F1E_15F1E;
    label_1000_5E9E_15E9E:
    CheckExternalEvents(cs8, 0x5EA3);
    // CMP word ptr [BP + -0x1e],0x140 (1000_5E9E / 0x15E9E)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0x140);
    CheckExternalEvents(cs8, 0x5EA5);
    // JGE 0x1000:5f1e (1000_5EA3 / 0x15EA3)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5EA9);
    // CMP word ptr [BP + -0x22],0x0 (1000_5EA5 / 0x15EA5)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0x0);
    CheckExternalEvents(cs8, 0x5EAB);
    // JL 0x1000:5f1e (1000_5EA9 / 0x15EA9)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5EB0);
    // CMP word ptr [BP + -0x22],0xc8 (1000_5EAB / 0x15EAB)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0xC8);
    CheckExternalEvents(cs8, 0x5EB2);
    // JGE 0x1000:5f1e (1000_5EB0 / 0x15EB0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5EB6);
    // MOV ES,word ptr [0x5680] (1000_5EB2 / 0x15EB2)
    ES = UInt16[DS, 0x5680];
    CheckExternalEvents(cs8, 0x5EBC);
    // CMP word ptr ES:[0x4fba],0x1 (1000_5EB6 / 0x15EB6)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x1);
    CheckExternalEvents(cs8, 0x5EBE);
    // JNZ 0x1000:5ec4 (1000_5EBC / 0x15EBC)
    if(!ZeroFlag) {
      goto label_1000_5EC4_15EC4;
    }
    CheckExternalEvents(cs8, 0x5EC2);
    // TEST byte ptr [BP + -0x4],0x3 (1000_5EBE / 0x15EBE)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x3);
    CheckExternalEvents(cs8, 0x5EC4);
    // JNZ 0x1000:5ee8 (1000_5EC2 / 0x15EC2)
    if(!ZeroFlag) {
      goto label_1000_5EE8_15EE8;
    }
    label_1000_5EC4_15EC4:
    CheckExternalEvents(cs8, 0x5EC7);
    // PUSH word ptr [BP + 0x1a] (1000_5EC4 / 0x15EC4)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x1A)]);
    CheckExternalEvents(cs8, 0x5ECA);
    // PUSH word ptr [BP + 0x18] (1000_5EC7 / 0x15EC7)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x18)]);
    CheckExternalEvents(cs8, 0x5ECF);
    // CALLF 0x1000:1919 (1000_5ECA / 0x15ECA)
    FarCall(cs8, 0x5ECF, ghidra_guess_1000_1919_11919);
    CheckExternalEvents(cs8, 0x5ED2);
    // ADD SP,0x4 (1000_5ECF / 0x15ECF)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x5ED5);
    // PUSH word ptr [BP + -0x22] (1000_5ED2 / 0x15ED2)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs8, 0x5ED8);
    // PUSH word ptr [BP + -0x1e] (1000_5ED5 / 0x15ED5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs8, 0x5EDB);
    // PUSH word ptr [BP + -0x1c] (1000_5ED8 / 0x15ED8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1C)]);
    CheckExternalEvents(cs8, 0x5EE0);
    // CALLF 0x1000:1983 (1000_5EDB / 0x15EDB)
    FarCall(cs8, 0x5EE0, ghidra_guess_1000_1983_11983);
    CheckExternalEvents(cs8, 0x5EE3);
    // ADD SP,0x6 (1000_5EE0 / 0x15EE0)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x5EE8);
    // CALLF 0x1000:9193 (1000_5EE3 / 0x15EE3)
    FarCall(cs8, 0x5EE8, unknown_18AD_06C3_19193);
    label_1000_5EE8_15EE8:
    CheckExternalEvents(cs8, 0x5EEB);
    // INC word ptr [BP + -0x4] (1000_5EE8 / 0x15EE8)
    UInt16[SS, (ushort)(BP - 0x4)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0x5EED);
    // JMP 0x1000:5f1e (1000_5EEB / 0x15EEB)
    goto label_1000_5F1E_15F1E;
    label_1000_5EED_15EED:
    CheckExternalEvents(cs8, 0x5EF1);
    // CMP word ptr [BP + -0x1e],0x68 (1000_5EED / 0x15EED)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0x68);
    CheckExternalEvents(cs8, 0x5EF3);
    // JL 0x1000:5f1e (1000_5EF1 / 0x15EF1)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5EF8);
    // CMP word ptr [BP + -0x1e],0x140 (1000_5EF3 / 0x15EF3)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0x140);
    CheckExternalEvents(cs8, 0x5EFA);
    // JGE 0x1000:5f1e (1000_5EF8 / 0x15EF8)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5EFE);
    // CMP word ptr [BP + -0x22],0x0 (1000_5EFA / 0x15EFA)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0x0);
    CheckExternalEvents(cs8, 0x5F00);
    // JL 0x1000:5f1e (1000_5EFE / 0x15EFE)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5F05);
    // CMP word ptr [BP + -0x22],0xc8 (1000_5F00 / 0x15F00)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0xC8);
    CheckExternalEvents(cs8, 0x5F07);
    // JGE 0x1000:5f1e (1000_5F05 / 0x15F05)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5F1E_15F1E;
    }
    CheckExternalEvents(cs8, 0x5F0A);
    // PUSH word ptr [BP + -0x2c] (1000_5F07 / 0x15F07)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x2C)]);
    CheckExternalEvents(cs8, 0x5F0D);
    // PUSH word ptr [BP + -0x22] (1000_5F0A / 0x15F0A)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs8, 0x5F10);
    // PUSH word ptr [BP + -0x1e] (1000_5F0D / 0x15F0D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs8, 0x5F13);
    // PUSH word ptr [BP + -0x22] (1000_5F10 / 0x15F10)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs8, 0x5F16);
    // PUSH word ptr [BP + -0x1e] (1000_5F13 / 0x15F13)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs8, 0x5F1B);
    // CALLF 0x1000:8dec (1000_5F16 / 0x15F16)
    FarCall(cs8, 0x5F1B, unknown_18AD_031C_18DEC);
    CheckExternalEvents(cs8, 0x5F1E);
    // ADD SP,0xa (1000_5F1B / 0x15F1B)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    label_1000_5F1E_15F1E:
    CheckExternalEvents(cs8, 0x5F21);
    // MOV AX,word ptr [BP + -0x20] (1000_5F1E / 0x15F1E)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs8, 0x5F24);
    // CMP word ptr [BP + -0x1e],AX (1000_5F21 / 0x15F21)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    CheckExternalEvents(cs8, 0x5F26);
    // JZ 0x1000:5f2c (1000_5F24 / 0x15F24)
    if(ZeroFlag) {
      goto label_1000_5F2C_15F2C;
    }
    CheckExternalEvents(cs8, 0x5F29);
    // MOV AX,word ptr [BP + -0x2e] (1000_5F26 / 0x15F26)
    AX = UInt16[SS, (ushort)(BP - 0x2E)];
    CheckExternalEvents(cs8, 0x5F2C);
    // ADD word ptr [BP + -0x1e],AX (1000_5F29 / 0x15F29)
    // UInt16[SS, (ushort)(BP - 0x1E)] += AX;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    label_1000_5F2C_15F2C:
    CheckExternalEvents(cs8, 0x5F2F);
    // MOV AX,word ptr [BP + -0x28] (1000_5F2C / 0x15F2C)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs8, 0x5F32);
    // CMP word ptr [BP + -0x22],AX (1000_5F2F / 0x15F2F)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], AX);
    CheckExternalEvents(cs8, 0x5F34);
    // JZ 0x1000:5f3a (1000_5F32 / 0x15F32)
    if(ZeroFlag) {
      goto label_1000_5F3A_15F3A;
    }
    CheckExternalEvents(cs8, 0x5F37);
    // MOV AX,word ptr [BP + -0x2] (1000_5F34 / 0x15F34)
    AX = UInt16[SS, (ushort)(BP - 0x2)];
    CheckExternalEvents(cs8, 0x5F3A);
    // ADD word ptr [BP + -0x22],AX (1000_5F37 / 0x15F37)
    // UInt16[SS, (ushort)(BP - 0x22)] += AX;
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x22)], AX);
    label_1000_5F3A_15F3A:
    CheckExternalEvents(cs8, 0x5F3D);
    // MOV AX,word ptr [BP + -0x2a] (1000_5F3A / 0x15F3A)
    AX = UInt16[SS, (ushort)(BP - 0x2A)];
    CheckExternalEvents(cs8, 0x5F40);
    // SUB word ptr [BP + -0x1a],AX (1000_5F3D / 0x15F3D)
    // UInt16[SS, (ushort)(BP - 0x1A)] -= AX;
    UInt16[SS, (ushort)(BP - 0x1A)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1A)], AX);
    CheckExternalEvents(cs8, 0x5F42);
    // JS 0x1000:5f45 (1000_5F40 / 0x15F40)
    if(SignFlag) {
      goto label_1000_5F45_15F45;
    }
    CheckExternalEvents(cs8, 0x5F45);
    // JMP 0x1000:5e6a (1000_5F42 / 0x15F42)
    goto label_1000_5E6A_15E6A;
    label_1000_5F45_15F45:
    CheckExternalEvents(cs8, 0x5F48);
    // MOV AX,word ptr [BP + -0x20] (1000_5F45 / 0x15F45)
    AX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs8, 0x5F4B);
    // CMP word ptr [BP + -0x1e],AX (1000_5F48 / 0x15F48)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    CheckExternalEvents(cs8, 0x5F4D);
    // JZ 0x1000:5f53 (1000_5F4B / 0x15F4B)
    if(ZeroFlag) {
      goto label_1000_5F53_15F53;
    }
    CheckExternalEvents(cs8, 0x5F50);
    // MOV AX,word ptr [BP + -0x6] (1000_5F4D / 0x15F4D)
    AX = UInt16[SS, (ushort)(BP - 0x6)];
    CheckExternalEvents(cs8, 0x5F53);
    // ADD word ptr [BP + -0x1e],AX (1000_5F50 / 0x15F50)
    // UInt16[SS, (ushort)(BP - 0x1E)] += AX;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1E)], AX);
    label_1000_5F53_15F53:
    CheckExternalEvents(cs8, 0x5F56);
    // MOV AX,word ptr [BP + -0x28] (1000_5F53 / 0x15F53)
    AX = UInt16[SS, (ushort)(BP - 0x28)];
    CheckExternalEvents(cs8, 0x5F59);
    // CMP word ptr [BP + -0x22],AX (1000_5F56 / 0x15F56)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], AX);
    CheckExternalEvents(cs8, 0x5F5B);
    // JZ 0x1000:5f61 (1000_5F59 / 0x15F59)
    if(ZeroFlag) {
      goto label_1000_5F61_15F61;
    }
    CheckExternalEvents(cs8, 0x5F5E);
    // MOV AX,word ptr [BP + -0xa] (1000_5F5B / 0x15F5B)
    AX = UInt16[SS, (ushort)(BP - 0xA)];
    CheckExternalEvents(cs8, 0x5F61);
    // ADD word ptr [BP + -0x22],AX (1000_5F5E / 0x15F5E)
    // UInt16[SS, (ushort)(BP - 0x22)] += AX;
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x22)], AX);
    label_1000_5F61_15F61:
    CheckExternalEvents(cs8, 0x5F64);
    // MOV AX,word ptr [BP + -0x26] (1000_5F61 / 0x15F61)
    AX = UInt16[SS, (ushort)(BP - 0x26)];
    CheckExternalEvents(cs8, 0x5F67);
    // ADD word ptr [BP + -0x1a],AX (1000_5F64 / 0x15F64)
    // UInt16[SS, (ushort)(BP - 0x1A)] += AX;
    UInt16[SS, (ushort)(BP - 0x1A)] = Alu16.Add(UInt16[SS, (ushort)(BP - 0x1A)], AX);
    CheckExternalEvents(cs8, 0x5F6A);
    // JMP 0x1000:5e6a (1000_5F67 / 0x15F67)
    goto label_1000_5E6A_15E6A;
    label_1000_5F6A_15F6A:
    CheckExternalEvents(cs8, 0x5F6E);
    // CMP word ptr [BP + -0x18],0x1 (1000_5F6A / 0x15F6A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x1);
    CheckExternalEvents(cs8, 0x5F70);
    // JZ 0x1000:5f87 (1000_5F6E / 0x15F6E)
    if(ZeroFlag) {
      goto label_1000_5F87_15F87;
    }
    CheckExternalEvents(cs8, 0x5F74);
    // CMP word ptr [BP + -0x8],0x0 (1000_5F70 / 0x15F70)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x8)], 0x0);
    CheckExternalEvents(cs8, 0x5F76);
    // JNZ 0x1000:5f7b (1000_5F74 / 0x15F74)
    if(!ZeroFlag) {
      goto label_1000_5F7B_15F7B;
    }
    CheckExternalEvents(cs8, 0x5F79);
    // MOV AX,0x2 (1000_5F76 / 0x15F76)
    AX = 0x2;
    CheckExternalEvents(cs8, 0x5F7B);
    // JMP 0x1000:5f7e (1000_5F79 / 0x15F79)
    goto label_1000_5F7E_15F7E;
    label_1000_5F7B_15F7B:
    CheckExternalEvents(cs8, 0x5F7E);
    // MOV AX,0x9 (1000_5F7B / 0x15F7B)
    AX = 0x9;
    label_1000_5F7E_15F7E:
    CheckExternalEvents(cs8, 0x5F7F);
    // PUSH AX (1000_5F7E / 0x15F7E)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5F84);
    // CALLF 0x0000:30bf (1000_5F7F / 0x15F7F)
    FarCall(cs8, 0x5F84, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5F87);
    // ADD SP,0x2 (1000_5F84 / 0x15F84)
    SP += 0x2;
    label_1000_5F87_15F87:
    CheckExternalEvents(cs8, 0x5F8B);
    // CMP word ptr [BP + 0x16],0x0 (1000_5F87 / 0x15F87)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x16)], 0x0);
    CheckExternalEvents(cs8, 0x5F8D);
    // JNZ 0x1000:5f90 (1000_5F8B / 0x15F8B)
    if(!ZeroFlag) {
      goto label_1000_5F90_15F90;
    }
    CheckExternalEvents(cs8, 0x5F90);
    // JMP 0x1000:605d (1000_5F8D / 0x15F8D)
    goto label_1000_605D_1605D;
    label_1000_5F90_15F90:
    CheckExternalEvents(cs8, 0x5F93);
    // MOV AX,0x4 (1000_5F90 / 0x15F90)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x5F94);
    // PUSH AX (1000_5F93 / 0x15F93)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x5F99);
    // CALLF 0x0000:30bf (1000_5F94 / 0x15F94)
    FarCall(cs8, 0x5F99, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x5F9C);
    // ADD SP,0x2 (1000_5F99 / 0x15F99)
    SP += 0x2;
    CheckExternalEvents(cs8, 0x5FA0);
    // CMP word ptr [BP + 0xa],0x7 (1000_5F9C / 0x15F9C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0xA)], 0x7);
    CheckExternalEvents(cs8, 0x5FA2);
    // JGE 0x1000:5fa5 (1000_5FA0 / 0x15FA0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_5FA5_15FA5;
    }
    CheckExternalEvents(cs8, 0x5FA5);
    // JMP 0x1000:606b (1000_5FA2 / 0x15FA2)
    goto label_1000_606B_1606B;
    label_1000_5FA5_15FA5:
    CheckExternalEvents(cs8, 0x5FA8);
    // MOV BX,word ptr [BP + 0x8] (1000_5FA5 / 0x15FA5)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x5FAC);
    // MOV ES,word ptr [0x567e] (1000_5FA8 / 0x15FA8)
    ES = UInt16[DS, 0x567E];
    CheckExternalEvents(cs8, 0x5FB2);
    // CMP byte ptr ES:[BX + 0x42f6],0x0 (1000_5FAC / 0x15FAC)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0x42F6)], 0x0);
    CheckExternalEvents(cs8, 0x5FB4);
    // JNZ 0x1000:5fb7 (1000_5FB2 / 0x15FB2)
    if(!ZeroFlag) {
      goto label_1000_5FB7_15FB7;
    }
    CheckExternalEvents(cs8, 0x5FB7);
    // JMP 0x1000:606b (1000_5FB4 / 0x15FB4)
    goto label_1000_606B_1606B;
    label_1000_5FB7_15FB7:
    CheckExternalEvents(cs8, 0x5FBB);
    // MOV ES,word ptr [0x5640] (1000_5FB7 / 0x15FB7)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x5FBE);
    // MOV AX,0x41d8 (1000_5FBB / 0x15FBB)
    AX = 0x41D8;
    CheckExternalEvents(cs8, 0x5FC2);
    // MOV ES:[0x256],AX (1000_5FBE / 0x15FBE)
    UInt16[ES, 0x256] = AX;
    CheckExternalEvents(cs8, 0x5FC7);
    // MOV word ptr ES:[0x258],DS (1000_5FC2 / 0x15FC2)
    UInt16[ES, 0x258] = DS;
    CheckExternalEvents(cs8, 0x5FC9);
    // MOV SI,BX (1000_5FC7 / 0x15FC7)
    SI = BX;
    CheckExternalEvents(cs8, 0x5FCB);
    // SHL SI,0x1 (1000_5FC9 / 0x15FC9)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x5FCF);
    // MOV ES,word ptr [0x5682] (1000_5FCB / 0x15FCB)
    ES = UInt16[DS, 0x5682];
    CheckExternalEvents(cs8, 0x5FD4);
    // MOV AX,word ptr ES:[SI + 0x324c] (1000_5FCF / 0x15FCF)
    AX = UInt16[ES, (ushort)(SI + 0x324C)];
    CheckExternalEvents(cs8, 0x5FD7);
    // MOV word ptr [BP + -0x1e],AX (1000_5FD4 / 0x15FD4)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs8, 0x5FDB);
    // MOV ES,word ptr [0x5684] (1000_5FD7 / 0x15FD7)
    ES = UInt16[DS, 0x5684];
    CheckExternalEvents(cs8, 0x5FE0);
    // MOV AX,word ptr ES:[SI + 0x327c] (1000_5FDB / 0x15FDB)
    AX = UInt16[ES, (ushort)(SI + 0x327C)];
    CheckExternalEvents(cs8, 0x5FE3);
    // MOV word ptr [BP + -0x22],AX (1000_5FE0 / 0x15FE0)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs8, 0x5FE6);
    // CMP BX,0x4 (1000_5FE3 / 0x15FE3)
    Alu16.Sub(BX, 0x4);
    CheckExternalEvents(cs8, 0x5FE8);
    // JL 0x1000:5ff2 (1000_5FE6 / 0x15FE6)
    if(SignFlag != OverflowFlag) {
      goto label_1000_5FF2_15FF2;
    }
    CheckExternalEvents(cs8, 0x5FEB);
    // CMP BX,0xc (1000_5FE8 / 0x15FE8)
    Alu16.Sub(BX, 0xC);
    CheckExternalEvents(cs8, 0x5FED);
    // JL 0x1000:602f (1000_5FEB / 0x15FEB)
    if(SignFlag != OverflowFlag) {
      goto label_1000_602F_1602F;
    }
    CheckExternalEvents(cs8, 0x5FF0);
    // CMP BX,0x10 (1000_5FED / 0x15FED)
    Alu16.Sub(BX, 0x10);
    CheckExternalEvents(cs8, 0x5FF2);
    // JGE 0x1000:602f (1000_5FF0 / 0x15FF0)
    if(SignFlag == OverflowFlag) {
      goto label_1000_602F_1602F;
    }
    label_1000_5FF2_15FF2:
    CheckExternalEvents(cs8, 0x5FF6);
    // SUB word ptr [BP + -0x22],0x8 (1000_5FF2 / 0x15FF2)
    // UInt16[SS, (ushort)(BP - 0x22)] -= 0x8;
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0x8);
    CheckExternalEvents(cs8, 0x5FF8);
    // JMP 0x1000:602f (1000_5FF6 / 0x15FF6)
    goto label_1000_602F_1602F;
    label_1000_5FF8_15FF8:
    CheckExternalEvents(cs8, 0x5FFB);
    // MOV AX,0x18 (1000_5FF8 / 0x15FF8)
    AX = 0x18;
    CheckExternalEvents(cs8, 0x5FFC);
    // PUSH AX (1000_5FFB / 0x15FFB)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6001);
    // CALLF 0x0000:2e32 (1000_5FFC / 0x15FFC)
    FarCall(cs8, 0x6001, unknown_0170_1732_02E32);
    CheckExternalEvents(cs8, 0x6004);
    // ADD SP,0x2 (1000_6001 / 0x16001)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x6007);
    // MOV word ptr [BP + -0x1c],AX (1000_6004 / 0x16004)
    UInt16[SS, (ushort)(BP - 0x1C)] = AX;
    CheckExternalEvents(cs8, 0x600A);
    // PUSH word ptr [BP + 0x1a] (1000_6007 / 0x16007)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x1A)]);
    CheckExternalEvents(cs8, 0x600D);
    // PUSH word ptr [BP + 0x18] (1000_600A / 0x1600A)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x18)]);
    CheckExternalEvents(cs8, 0x6012);
    // CALLF 0x1000:1919 (1000_600D / 0x1600D)
    FarCall(cs8, 0x6012, ghidra_guess_1000_1919_11919);
    CheckExternalEvents(cs8, 0x6015);
    // ADD SP,0x4 (1000_6012 / 0x16012)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x6018);
    // PUSH word ptr [BP + -0x22] (1000_6015 / 0x16015)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs8, 0x601B);
    // PUSH word ptr [BP + -0x1e] (1000_6018 / 0x16018)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs8, 0x601E);
    // MOV AX,word ptr [BP + -0x1c] (1000_601B / 0x1601B)
    AX = UInt16[SS, (ushort)(BP - 0x1C)];
    CheckExternalEvents(cs8, 0x6021);
    // ADD AX,0xfa (1000_601E / 0x1601E)
    // AX += 0xFA;
    AX = Alu16.Add(AX, 0xFA);
    CheckExternalEvents(cs8, 0x6022);
    // PUSH AX (1000_6021 / 0x16021)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6027);
    // CALLF 0x1000:1983 (1000_6022 / 0x16022)
    FarCall(cs8, 0x6027, ghidra_guess_1000_1983_11983);
    CheckExternalEvents(cs8, 0x602A);
    // ADD SP,0x6 (1000_6027 / 0x16027)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x602F);
    // CALLF 0x1000:9193 (1000_602A / 0x1602A)
    FarCall(cs8, 0x602F, unknown_18AD_06C3_19193);
    label_1000_602F_1602F:
    CheckExternalEvents(cs8, 0x6033);
    // MOV ES,word ptr [0x5640] (1000_602F / 0x1602F)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x6038);
    // LES BX,ES:[0x256] (1000_6033 / 0x16033)
    BX = UInt16[ES, 0x256];
    ES = UInt16[ES, 0x258];
    CheckExternalEvents(cs8, 0x603C);
    // CMP byte ptr ES:[BX],0xff (1000_6038 / 0x16038)
    Alu8.Sub(UInt8[ES, (ushort)(BX)], 0xFF);
    CheckExternalEvents(cs8, 0x603E);
    // JNZ 0x1000:5ff8 (1000_603C / 0x1603C)
    if(!ZeroFlag) {
      goto label_1000_5FF8_15FF8;
    }
    CheckExternalEvents(cs8, 0x6041);
    // MOV AX,0x5 (1000_603E / 0x1603E)
    AX = 0x5;
    CheckExternalEvents(cs8, 0x6042);
    // PUSH AX (1000_6041 / 0x16041)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6047);
    // CALLF 0x1000:8ad6 (1000_6042 / 0x16042)
    FarCall(cs8, 0x6047, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs8, 0x604A);
    // ADD SP,0x2 (1000_6047 / 0x16047)
    SP += 0x2;
    CheckExternalEvents(cs8, 0x604E);
    // CMP word ptr [BP + -0x24],0x0 (1000_604A / 0x1604A)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x24)], 0x0);
    CheckExternalEvents(cs8, 0x6050);
    // JZ 0x1000:606b (1000_604E / 0x1604E)
    if(ZeroFlag) {
      goto label_1000_606B_1606B;
    }
    CheckExternalEvents(cs8, 0x6052);
    // SUB AX,AX (1000_6050 / 0x16050)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x6053);
    // PUSH AX (1000_6052 / 0x16052)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6056);
    // PUSH word ptr [BP + -0x24] (1000_6053 / 0x16053)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x24)]);
    CheckExternalEvents(cs8, 0x605B);
    // CALLF 0x0000:5fb7 (1000_6056 / 0x16056)
    FarCall(cs8, 0x605B, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs8, 0x605D);
    // JMP 0x1000:6068 (1000_605B / 0x1605B)
    goto label_1000_6068_16068;
    label_1000_605D_1605D:
    CheckExternalEvents(cs8, 0x6060);
    // PUSH word ptr [BP + 0x1a] (1000_605D / 0x1605D)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x1A)]);
    CheckExternalEvents(cs8, 0x6063);
    // PUSH word ptr [BP + 0x18] (1000_6060 / 0x16060)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x18)]);
    CheckExternalEvents(cs8, 0x6068);
    // CALLF 0x1000:1919 (1000_6063 / 0x16063)
    FarCall(cs8, 0x6068, ghidra_guess_1000_1919_11919);
    label_1000_6068_16068:
    CheckExternalEvents(cs8, 0x606B);
    // ADD SP,0x4 (1000_6068 / 0x16068)
    SP += 0x4;
    label_1000_606B_1606B:
    CheckExternalEvents(cs8, 0x606F);
    // CMP word ptr [BP + 0x6],0x4 (1000_606B / 0x1606B)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x4);
    CheckExternalEvents(cs8, 0x6071);
    // JL 0x1000:607d (1000_606F / 0x1606F)
    if(SignFlag != OverflowFlag) {
      goto label_1000_607D_1607D;
    }
    CheckExternalEvents(cs8, 0x6075);
    // CMP word ptr [BP + 0x6],0xc (1000_6071 / 0x16071)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0xC);
    CheckExternalEvents(cs8, 0x6077);
    // JL 0x1000:608c (1000_6075 / 0x16075)
    if(SignFlag != OverflowFlag) {
      goto label_1000_608C_1608C;
    }
    CheckExternalEvents(cs8, 0x607B);
    // CMP word ptr [BP + 0x6],0x10 (1000_6077 / 0x16077)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x10);
    CheckExternalEvents(cs8, 0x607D);
    // JGE 0x1000:608c (1000_607B / 0x1607B)
    if(SignFlag == OverflowFlag) {
      goto label_1000_608C_1608C;
    }
    label_1000_607D_1607D:
    CheckExternalEvents(cs8, 0x6080);
    // MOV AL,byte ptr [BP + -0xc] (1000_607D / 0x1607D)
    AL = UInt8[SS, (ushort)(BP - 0xC)];
    CheckExternalEvents(cs8, 0x6083);
    // MOV BX,word ptr [BP + 0x6] (1000_6080 / 0x16080)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x6087);
    // MOV ES,word ptr [0x5642] (1000_6083 / 0x16083)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs8, 0x608C);
    // MOV byte ptr ES:[BX + 0x409a],AL (1000_6087 / 0x16087)
    UInt8[ES, (ushort)(BX + 0x409A)] = AL;
    label_1000_608C_1608C:
    CheckExternalEvents(cs8, 0x6090);
    // CMP word ptr [BP + 0x10],0x0 (1000_608C / 0x1608C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x10)], 0x0);
    CheckExternalEvents(cs8, 0x6092);
    // JNZ 0x1000:6095 (1000_6090 / 0x16090)
    if(!ZeroFlag) {
      goto label_1000_6095_16095;
    }
    CheckExternalEvents(cs8, 0x6095);
    // JMP 0x1000:617c (1000_6092 / 0x16092)
    goto label_1000_617C_1617C;
    label_1000_6095_16095:
    CheckExternalEvents(cs8, 0x6098);
    // MOV AX,0x41fc (1000_6095 / 0x16095)
    AX = 0x41FC;
    CheckExternalEvents(cs8, 0x6099);
    // PUSH DS (1000_6098 / 0x16098)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x609A);
    // PUSH AX (1000_6099 / 0x16099)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x609F);
    // CALLF 0x1000:17bb (1000_609A / 0x1609A)
    FarCall(cs8, 0x609F, ghidra_guess_1000_17BB_117BB);
    CheckExternalEvents(cs8, 0x60A2);
    // ADD SP,0x4 (1000_609F / 0x1609F)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x60A5);
    // MOV SI,word ptr [BP + 0x8] (1000_60A2 / 0x160A2)
    SI = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x60A7);
    // SHL SI,0x1 (1000_60A5 / 0x160A5)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x60AB);
    // MOV ES,word ptr [0x5698] (1000_60A7 / 0x160A7)
    ES = UInt16[DS, 0x5698];
    CheckExternalEvents(cs8, 0x60B2);
    // MOV word ptr ES:[SI + 0x393c],0x1 (1000_60AB / 0x160AB)
    UInt16[ES, (ushort)(SI + 0x393C)] = 0x1;
    CheckExternalEvents(cs8, 0x60B6);
    // MOV ES,word ptr [0x5632] (1000_60B2 / 0x160B2)
    ES = UInt16[DS, 0x5632];
    CheckExternalEvents(cs8, 0x60BD);
    // MOV word ptr ES:[SI + 0x406a],0x0 (1000_60B6 / 0x160B6)
    UInt16[ES, (ushort)(SI + 0x406A)] = 0x0;
    CheckExternalEvents(cs8, 0x60C0);
    // MOV AX,0x11 (1000_60BD / 0x160BD)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x60C3);
    // IMUL word ptr [BP + 0x14] (1000_60C0 / 0x160C0)
    int resImul1000_60C0 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x14)]);
    AX = (ushort)(resImul1000_60C0);
    DX = (ushort)(resImul1000_60C0 >> 16);
    CheckExternalEvents(cs8, 0x60C5);
    // MOV BX,AX (1000_60C3 / 0x160C3)
    BX = AX;
    CheckExternalEvents(cs8, 0x60C9);
    // MOV ES,word ptr [0x5648] (1000_60C5 / 0x160C5)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs8, 0x60CF);
    // MOV byte ptr ES:[BX + 0xc614],0xff (1000_60C9 / 0x160C9)
    UInt8[ES, (ushort)(BX + 0xC614)] = 0xFF;
    CheckExternalEvents(cs8, 0x60D2);
    // MOV BX,word ptr [BP + 0x8] (1000_60CF / 0x160CF)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x60D6);
    // MOV ES,word ptr [0x5642] (1000_60D2 / 0x160D2)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs8, 0x60DC);
    // MOV byte ptr ES:[BX + 0x409a],0x7e (1000_60D6 / 0x160D6)
    UInt8[ES, (ushort)(BX + 0x409A)] = 0x7E;
    CheckExternalEvents(cs8, 0x60DF);
    // MOV BX,word ptr [BP + 0x8] (1000_60DC / 0x160DC)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x60E3);
    // MOV ES,word ptr [0x567a] (1000_60DF / 0x160DF)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x60E9);
    // MOV byte ptr ES:[BX + 0xd55e],0x0 (1000_60E3 / 0x160E3)
    UInt8[ES, (ushort)(BX + 0xD55E)] = 0x0;
    CheckExternalEvents(cs8, 0x60ED);
    // MOV ES,word ptr [0x5636] (1000_60E9 / 0x160E9)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x60F2);
    // PUSH word ptr ES:[SI + 0x4036] (1000_60ED / 0x160ED)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4036)]);
    CheckExternalEvents(cs8, 0x60F6);
    // MOV ES,word ptr [0x5638] (1000_60F2 / 0x160F2)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x60FB);
    // PUSH word ptr ES:[SI + 0x4004] (1000_60F6 / 0x160F6)
    Stack.Push16(UInt16[ES, (ushort)(SI + 0x4004)]);
    CheckExternalEvents(cs8, 0x60FE);
    // MOV AX,0x7e (1000_60FB / 0x160FB)
    AX = 0x7E;
    CheckExternalEvents(cs8, 0x60FF);
    // PUSH AX (1000_60FE / 0x160FE)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6104);
    // CALLF 0x1000:4279 (1000_60FF / 0x160FF)
    FarCall(cs8, 0x6104, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x6107);
    // ADD SP,0x6 (1000_6104 / 0x16104)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x610C);
    // MOV word ptr [BP + -0x1e],0x0 (1000_6107 / 0x16107)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x0;
    CheckExternalEvents(cs8, 0x610E);
    // JMP 0x1000:6144 (1000_610C / 0x1610C)
    goto label_1000_6144_16144;
    label_1000_610E_1610E:
    CheckExternalEvents(cs8, 0x6111);
    // INC word ptr [BP + -0x22] (1000_610E / 0x1610E)
    UInt16[SS, (ushort)(BP - 0x22)]++;
    label_1000_6111_16111:
    CheckExternalEvents(cs8, 0x6115);
    // CMP word ptr [BP + -0x22],0xc (1000_6111 / 0x16111)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x22)], 0xC);
    CheckExternalEvents(cs8, 0x6117);
    // JGE 0x1000:6141 (1000_6115 / 0x16115)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6141_16141;
    }
    CheckExternalEvents(cs8, 0x611A);
    // MOV AX,0xc (1000_6117 / 0x16117)
    AX = 0xC;
    CheckExternalEvents(cs8, 0x611D);
    // IMUL word ptr [BP + -0x1e] (1000_611A / 0x1611A)
    int resImul1000_611A = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP - 0x1E)]);
    AX = (ushort)(resImul1000_611A);
    DX = (ushort)(resImul1000_611A >> 16);
    CheckExternalEvents(cs8, 0x6120);
    // ADD AX,word ptr [BP + -0x22] (1000_611D / 0x1611D)
    AX += UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs8, 0x6123);
    // ADD AX,0x3800 (1000_6120 / 0x16120)
    // AX += 0x3800;
    AX = Alu16.Add(AX, 0x3800);
    CheckExternalEvents(cs8, 0x6126);
    // MOV word ptr [BP + -0x32],AX (1000_6123 / 0x16123)
    UInt16[SS, (ushort)(BP - 0x32)] = AX;
    CheckExternalEvents(cs8, 0x612B);
    // MOV word ptr [BP + -0x30],0x2a02 (1000_6126 / 0x16126)
    UInt16[SS, (ushort)(BP - 0x30)] = 0x2A02;
    CheckExternalEvents(cs8, 0x612E);
    // LES BX,[BP + -0x32] (1000_612B / 0x1612B)
    BX = UInt16[SS, (ushort)(BP - 0x32)];
    ES = UInt16[SS, (ushort)(BP - 0x32 + 2)];
    CheckExternalEvents(cs8, 0x6131);
    // MOV AL,byte ptr ES:[BX] (1000_612E / 0x1612E)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs8, 0x6133);
    // SUB AH,AH (1000_6131 / 0x16131)
    AH -= AH;
    CheckExternalEvents(cs8, 0x6136);
    // AND AX,0x7f (1000_6133 / 0x16133)
    AX &= 0x7F;
    CheckExternalEvents(cs8, 0x6139);
    // CMP AX,word ptr [BP + 0x8] (1000_6136 / 0x16136)
    Alu16.Sub(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x613B);
    // JNZ 0x1000:610e (1000_6139 / 0x16139)
    if(!ZeroFlag) {
      goto label_1000_610E_1610E;
    }
    CheckExternalEvents(cs8, 0x613F);
    // MOV byte ptr ES:[BX],0xff (1000_613B / 0x1613B)
    UInt8[ES, (ushort)(BX)] = 0xFF;
    CheckExternalEvents(cs8, 0x6141);
    // JMP 0x1000:610e (1000_613F / 0x1613F)
    goto label_1000_610E_1610E;
    label_1000_6141_16141:
    CheckExternalEvents(cs8, 0x6144);
    // INC word ptr [BP + -0x1e] (1000_6141 / 0x16141)
    UInt16[SS, (ushort)(BP - 0x1E)]++;
    label_1000_6144_16144:
    CheckExternalEvents(cs8, 0x6148);
    // CMP word ptr [BP + -0x1e],0x18 (1000_6144 / 0x16144)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0x18);
    CheckExternalEvents(cs8, 0x614A);
    // JGE 0x1000:6151 (1000_6148 / 0x16148)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6151_16151;
    }
    CheckExternalEvents(cs8, 0x614F);
    // MOV word ptr [BP + -0x22],0x0 (1000_614A / 0x1614A)
    UInt16[SS, (ushort)(BP - 0x22)] = 0x0;
    CheckExternalEvents(cs8, 0x6151);
    // JMP 0x1000:6111 (1000_614F / 0x1614F)
    goto label_1000_6111_16111;
    label_1000_6151_16151:
    CheckExternalEvents(cs8, 0x6155);
    // CMP word ptr [BP + 0x14],0x2 (1000_6151 / 0x16151)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x14)], 0x2);
    CheckExternalEvents(cs8, 0x6157);
    // JGE 0x1000:6162 (1000_6155 / 0x16155)
    if(SignFlag == OverflowFlag) {
      goto label_1000_6162_16162;
    }
    CheckExternalEvents(cs8, 0x615B);
    // MOV ES,word ptr [0x5630] (1000_6157 / 0x16157)
    ES = UInt16[DS, 0x5630];
    CheckExternalEvents(cs8, 0x6162);
    // MOV word ptr ES:[0x14a],0x0 (1000_615B / 0x1615B)
    UInt16[ES, 0x14A] = 0x0;
    label_1000_6162_16162:
    CheckExternalEvents(cs8, 0x6165);
    // MOV SI,word ptr [BP + 0x8] (1000_6162 / 0x16162)
    SI = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x6167);
    // SHL SI,0x1 (1000_6165 / 0x16165)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x616A);
    // MOV AX,0xffff (1000_6167 / 0x16167)
    AX = 0xFFFF;
    CheckExternalEvents(cs8, 0x616E);
    // MOV ES,word ptr [0x5636] (1000_616A / 0x1616A)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x6173);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_616E / 0x1616E)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs8, 0x6177);
    // MOV ES,word ptr [0x5638] (1000_6173 / 0x16173)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x617C);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_6177 / 0x16177)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    label_1000_617C_1617C:
    CheckExternalEvents(cs8, 0x6180);
    // CMP word ptr [BP + 0x12],0x0 (1000_617C / 0x1617C)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x12)], 0x0);
    CheckExternalEvents(cs8, 0x6182);
    // JNZ 0x1000:6185 (1000_6180 / 0x16180)
    if(!ZeroFlag) {
      goto label_1000_6185_16185;
    }
    CheckExternalEvents(cs8, 0x6185);
    // JMP 0x1000:63a8 (1000_6182 / 0x16182)
    goto label_1000_63A8_163A8;
    label_1000_6185_16185:
    CheckExternalEvents(cs8, 0x6189);
    // MOV ES,word ptr [0x5660] (1000_6185 / 0x16185)
    ES = UInt16[DS, 0x5660];
    CheckExternalEvents(cs8, 0x618F);
    // CMP word ptr ES:[0xe48e],0x0 (1000_6189 / 0x16189)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs8, 0x6191);
    // JZ 0x1000:6197 (1000_618F / 0x1618F)
    if(ZeroFlag) {
      goto label_1000_6197_16197;
    }
    CheckExternalEvents(cs8, 0x6195);
    // CMP word ptr [BP + 0x8],0xd (1000_6191 / 0x16191)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xD);
    CheckExternalEvents(cs8, 0x6197);
    // JZ 0x1000:6202 (1000_6195 / 0x16195)
    if(ZeroFlag) {
      goto label_1000_6202_16202;
    }
    label_1000_6197_16197:
    CheckExternalEvents(cs8, 0x619C);
    // MOV word ptr [BP + 0x12],0x80 (1000_6197 / 0x16197)
    UInt16[SS, (ushort)(BP + 0x12)] = 0x80;
    CheckExternalEvents(cs8, 0x619F);
    // MOV BX,word ptr [BP + 0x8] (1000_619C / 0x1619C)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x61A3);
    // MOV ES,word ptr [0x567a] (1000_619F / 0x1619F)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x61A9);
    // CMP byte ptr ES:[BX + 0xd55e],0x0 (1000_61A3 / 0x161A3)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xD55E)], 0x0);
    CheckExternalEvents(cs8, 0x61AB);
    // JZ 0x1000:61ae (1000_61A9 / 0x161A9)
    if(ZeroFlag) {
      goto label_1000_61AE_161AE;
    }
    CheckExternalEvents(cs8, 0x61AE);
    // INC word ptr [BP + 0x12] (1000_61AB / 0x161AB)
    UInt16[SS, (ushort)(BP + 0x12)]++;
    label_1000_61AE_161AE:
    CheckExternalEvents(cs8, 0x61B0);
    // SHL BX,0x1 (1000_61AE / 0x161AE)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x61B4);
    // MOV ES,word ptr [0x5638] (1000_61B0 / 0x161B0)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x61B9);
    // MOV AX,word ptr ES:[BX + 0x4004] (1000_61B4 / 0x161B4)
    AX = UInt16[ES, (ushort)(BX + 0x4004)];
    CheckExternalEvents(cs8, 0x61BA);
    // DEC AX (1000_61B9 / 0x161B9)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs8, 0x61BD);
    // MOV word ptr [BP + -0x1e],AX (1000_61BA / 0x161BA)
    UInt16[SS, (ushort)(BP - 0x1E)] = AX;
    CheckExternalEvents(cs8, 0x61C1);
    // TEST byte ptr [BP + -0x1e],0x80 (1000_61BD / 0x161BD)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x1E)], 0x80);
    CheckExternalEvents(cs8, 0x61C3);
    // JZ 0x1000:61c8 (1000_61C1 / 0x161C1)
    if(ZeroFlag) {
      goto label_1000_61C8_161C8;
    }
    CheckExternalEvents(cs8, 0x61C8);
    // AND word ptr [BP + -0x1e],0xf7f (1000_61C3 / 0x161C3)
    // UInt16[SS, (ushort)(BP - 0x1E)] &= 0xF7F;
    UInt16[SS, (ushort)(BP - 0x1E)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x1E)], 0xF7F);
    label_1000_61C8_161C8:
    CheckExternalEvents(cs8, 0x61CB);
    // MOV BX,word ptr [BP + 0x8] (1000_61C8 / 0x161C8)
    BX = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x61CD);
    // SHL BX,0x1 (1000_61CB / 0x161CB)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x61D1);
    // MOV ES,word ptr [0x5636] (1000_61CD / 0x161CD)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x61D6);
    // MOV AX,word ptr ES:[BX + 0x4036] (1000_61D1 / 0x161D1)
    AX = UInt16[ES, (ushort)(BX + 0x4036)];
    CheckExternalEvents(cs8, 0x61D7);
    // DEC AX (1000_61D6 / 0x161D6)
    AX = Alu16.Dec(AX);
    CheckExternalEvents(cs8, 0x61DA);
    // MOV word ptr [BP + -0x22],AX (1000_61D7 / 0x161D7)
    UInt16[SS, (ushort)(BP - 0x22)] = AX;
    CheckExternalEvents(cs8, 0x61DE);
    // TEST byte ptr [BP + -0x22],0x80 (1000_61DA / 0x161DA)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x22)], 0x80);
    CheckExternalEvents(cs8, 0x61E0);
    // JZ 0x1000:61e5 (1000_61DE / 0x161DE)
    if(ZeroFlag) {
      goto label_1000_61E5_161E5;
    }
    CheckExternalEvents(cs8, 0x61E5);
    // AND word ptr [BP + -0x22],0xf07f (1000_61E0 / 0x161E0)
    // UInt16[SS, (ushort)(BP - 0x22)] &= 0xF07F;
    UInt16[SS, (ushort)(BP - 0x22)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x22)], 0xF07F);
    label_1000_61E5_161E5:
    CheckExternalEvents(cs8, 0x61E8);
    // PUSH word ptr [BP + -0x22] (1000_61E5 / 0x161E5)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x22)]);
    CheckExternalEvents(cs8, 0x61EB);
    // PUSH word ptr [BP + -0x1e] (1000_61E8 / 0x161E8)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x1E)]);
    CheckExternalEvents(cs8, 0x61EE);
    // PUSH word ptr [BP + 0x12] (1000_61EB / 0x161EB)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x12)]);
    CheckExternalEvents(cs8, 0x61F3);
    // CALLF 0x1000:4279 (1000_61EE / 0x161EE)
    FarCall(cs8, 0x61F3, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x61F6);
    // ADD SP,0x6 (1000_61F3 / 0x161F3)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x61F9);
    // MOV AX,0x8 (1000_61F6 / 0x161F6)
    AX = 0x8;
    CheckExternalEvents(cs8, 0x61FA);
    // PUSH AX (1000_61F9 / 0x161F9)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x61FF);
    // CALLF 0x0000:30bf (1000_61FA / 0x161FA)
    FarCall(cs8, 0x61FF, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x6202);
    // ADD SP,0x2 (1000_61FF / 0x161FF)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_6202_16202:
    CheckExternalEvents(cs8, 0x6206);
    // MOV ES,word ptr [0x5660] (1000_6202 / 0x16202)
    ES = UInt16[DS, 0x5660];
    CheckExternalEvents(cs8, 0x620C);
    // CMP word ptr ES:[0xe48e],0x0 (1000_6206 / 0x16206)
    Alu16.Sub(UInt16[ES, 0xE48E], 0x0);
    CheckExternalEvents(cs8, 0x620E);
    // JNZ 0x1000:6211 (1000_620C / 0x1620C)
    if(!ZeroFlag) {
      goto label_1000_6211_16211;
    }
    CheckExternalEvents(cs8, 0x6211);
    // JMP 0x1000:6383 (1000_620E / 0x1620E)
    goto label_1000_6383_16383;
    label_1000_6211_16211:
    CheckExternalEvents(cs8, 0x6215);
    // CMP word ptr [BP + 0x8],0xd (1000_6211 / 0x16211)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x8)], 0xD);
    CheckExternalEvents(cs8, 0x6217);
    // JZ 0x1000:621a (1000_6215 / 0x16215)
    if(ZeroFlag) {
      goto label_1000_621A_1621A;
    }
    CheckExternalEvents(cs8, 0x621A);
    // JMP 0x1000:6383 (1000_6217 / 0x16217)
    goto label_1000_6383_16383;
    label_1000_621A_1621A:
    CheckExternalEvents(cs8, 0x621F);
    // CALLF 0x1000:7bf6 (1000_621A / 0x1621A)
    FarCall(cs8, 0x621F, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x6222);
    // MOV AX,0x7 (1000_621F / 0x1621F)
    AX = 0x7;
    CheckExternalEvents(cs8, 0x6223);
    // PUSH AX (1000_6222 / 0x16222)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6228);
    // CALLF 0x0000:30bf (1000_6223 / 0x16223)
    FarCall(cs8, 0x6228, unknown_0170_19BF_030BF);
    CheckExternalEvents(cs8, 0x622B);
    // ADD SP,0x2 (1000_6228 / 0x16228)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs8, 0x622E);
    // MOV AX,0x4209 (1000_622B / 0x1622B)
    AX = 0x4209;
    CheckExternalEvents(cs8, 0x622F);
    // PUSH DS (1000_622E / 0x1622E)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x6230);
    // PUSH AX (1000_622F / 0x1622F)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6235);
    // CALLF 0x1000:7c1a (1000_6230 / 0x16230)
    FarCall(cs8, 0x6235, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x6238);
    // ADD SP,0x4 (1000_6235 / 0x16235)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x623D);
    // CALLF 0x1000:8d29 (1000_6238 / 0x16238)
    FarCall(cs8, 0x623D, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x6241);
    // MOV ES,word ptr [0x5636] (1000_623D / 0x1623D)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x6246);
    // PUSH word ptr ES:[0x4036] (1000_6241 / 0x16241)
    Stack.Push16(UInt16[ES, 0x4036]);
    CheckExternalEvents(cs8, 0x624A);
    // MOV ES,word ptr [0x5638] (1000_6246 / 0x16246)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x624F);
    // PUSH word ptr ES:[0x4004] (1000_624A / 0x1624A)
    Stack.Push16(UInt16[ES, 0x4004]);
    CheckExternalEvents(cs8, 0x6254);
    // CALLF 0x0000:2ebb (1000_624F / 0x1624F)
    FarCall(cs8, 0x6254, ghidra_guess_0000_2EBB_02EBB);
    CheckExternalEvents(cs8, 0x6257);
    // ADD SP,0x4 (1000_6254 / 0x16254)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x625B);
    // MOV ES,word ptr [0x562c] (1000_6257 / 0x16257)
    ES = UInt16[DS, 0x562C];
    CheckExternalEvents(cs8, 0x6260);
    // PUSH word ptr ES:[0xa44d] (1000_625B / 0x1625B)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs8, 0x6264);
    // MOV ES,word ptr [0x562a] (1000_6260 / 0x16260)
    ES = UInt16[DS, 0x562A];
    CheckExternalEvents(cs8, 0x6269);
    // PUSH word ptr ES:[0xa44b] (1000_6264 / 0x16264)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs8, 0x626E);
    // CALLF 0x1000:b204 (1000_6269 / 0x16269)
    FarCall(cs8, 0x626E, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs8, 0x6271);
    // ADD SP,0x4 (1000_626E / 0x1626E)
    SP += 0x4;
    CheckExternalEvents(cs8, 0x6273);
    // SUB AX,AX (1000_6271 / 0x16271)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs8, 0x6274);
    // PUSH AX (1000_6273 / 0x16273)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6277);
    // PUSH word ptr [BP + 0x1a] (1000_6274 / 0x16274)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x1A)]);
    CheckExternalEvents(cs8, 0x627A);
    // PUSH word ptr [BP + 0x18] (1000_6277 / 0x16277)
    Stack.Push16(UInt16[SS, (ushort)(BP + 0x18)]);
    CheckExternalEvents(cs8, 0x627F);
    // CALLF 0x1000:bdbe (1000_627A / 0x1627A)
    FarCall(cs8, 0x627F, ghidra_guess_1000_BDBE_1BDBE);
    CheckExternalEvents(cs8, 0x6282);
    // ADD SP,0x6 (1000_627F / 0x1627F)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    CheckExternalEvents(cs8, 0x6287);
    // CALLF 0x0000:3b0b (1000_6282 / 0x16282)
    FarCall(cs8, 0x6287, unknown_0170_240B_03B0B);
    CheckExternalEvents(cs8, 0x628C);
    // CALLF 0x1000:b7df (1000_6287 / 0x16287)
    FarCall(cs8, 0x628C, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs8, 0x6291);
    // CALLF 0x0000:254b (1000_628C / 0x1628C)
    FarCall(cs8, 0x6291, ghidra_guess_0000_254B_0254B);
    CheckExternalEvents(cs8, 0x6296);
    // CALLF 0x1000:9193 (1000_6291 / 0x16291)
    FarCall(cs8, 0x6296, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs8, 0x629B);
    // CALLF 0x1000:7bf6 (1000_6296 / 0x16296)
    FarCall(cs8, 0x629B, unknown_1643_17C6_17BF6);
    CheckExternalEvents(cs8, 0x629E);
    // MOV AX,0x4235 (1000_629B / 0x1629B)
    AX = 0x4235;
    CheckExternalEvents(cs8, 0x629F);
    // PUSH DS (1000_629E / 0x1629E)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x62A0);
    // PUSH AX (1000_629F / 0x1629F)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x62A5);
    // CALLF 0x1000:7c1a (1000_62A0 / 0x162A0)
    FarCall(cs8, 0x62A5, unknown_1643_17EA_17C1A);
    CheckExternalEvents(cs8, 0x62A8);
    // ADD SP,0x4 (1000_62A5 / 0x162A5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x62AD);
    // CALLF 0x1000:8d29 (1000_62A8 / 0x162A8)
    FarCall(cs8, 0x62AD, unknown_18AD_0259_18D29);
    CheckExternalEvents(cs8, 0x62B2);
    // MOV word ptr [BP + -0x1e],0x0 (1000_62AD / 0x162AD)
    UInt16[SS, (ushort)(BP - 0x1E)] = 0x0;
    label_1000_62B2_162B2:
    CheckExternalEvents(cs8, 0x62B5);
    // MOV BX,word ptr [BP + -0x1e] (1000_62B2 / 0x162B2)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs8, 0x62B9);
    // MOV ES,word ptr [0x569a] (1000_62B5 / 0x162B5)
    ES = UInt16[DS, 0x569A];
    CheckExternalEvents(cs8, 0x62BE);
    // MOV AL,byte ptr ES:[BX + 0x65b] (1000_62B9 / 0x162B9)
    AL = UInt8[ES, (ushort)(BX + 0x65B)];
    CheckExternalEvents(cs8, 0x62C2);
    // MOV ES,word ptr [0x5648] (1000_62BE / 0x162BE)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs8, 0x62C7);
    // MOV byte ptr ES:[BX + 0xca8f],AL (1000_62C2 / 0x162C2)
    UInt8[ES, (ushort)(BX + 0xCA8F)] = AL;
    CheckExternalEvents(cs8, 0x62CA);
    // MOV BX,word ptr [BP + -0x1e] (1000_62C7 / 0x162C7)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs8, 0x62CF);
    // MOV byte ptr ES:[BX + 0xca12],AL (1000_62CA / 0x162CA)
    UInt8[ES, (ushort)(BX + 0xCA12)] = AL;
    CheckExternalEvents(cs8, 0x62D2);
    // INC word ptr [BP + -0x1e] (1000_62CF / 0x162CF)
    UInt16[SS, (ushort)(BP - 0x1E)]++;
    CheckExternalEvents(cs8, 0x62D6);
    // CMP word ptr [BP + -0x1e],0x7d (1000_62D2 / 0x162D2)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1E)], 0x7D);
    CheckExternalEvents(cs8, 0x62D8);
    // JL 0x1000:62b2 (1000_62D6 / 0x162D6)
    if(SignFlag != OverflowFlag) {
      goto label_1000_62B2_162B2;
    }
    CheckExternalEvents(cs8, 0x62DC);
    // MOV ES,word ptr [0x5642] (1000_62D8 / 0x162D8)
    ES = UInt16[DS, 0x5642];
    CheckExternalEvents(cs8, 0x62DE);
    // SUB AL,AL (1000_62DC / 0x162DC)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs8, 0x62E2);
    // MOV ES:[0x40a9],AL (1000_62DE / 0x162DE)
    UInt8[ES, 0x40A9] = AL;
    CheckExternalEvents(cs8, 0x62E6);
    // MOV ES:[0x40a8],AL (1000_62E2 / 0x162E2)
    UInt8[ES, 0x40A8] = AL;
    CheckExternalEvents(cs8, 0x62EA);
    // MOV ES,word ptr [0x567a] (1000_62E6 / 0x162E6)
    ES = UInt16[DS, 0x567A];
    CheckExternalEvents(cs8, 0x62EE);
    // MOV ES:[0xd56d],AL (1000_62EA / 0x162EA)
    UInt8[ES, 0xD56D] = AL;
    CheckExternalEvents(cs8, 0x62F2);
    // MOV ES:[0xd56c],AL (1000_62EE / 0x162EE)
    UInt8[ES, 0xD56C] = AL;
    CheckExternalEvents(cs8, 0x62F6);
    // MOV ES,word ptr [0x5644] (1000_62F2 / 0x162F2)
    ES = UInt16[DS, 0x5644];
    CheckExternalEvents(cs8, 0x62F8);
    // MOV AL,0x4 (1000_62F6 / 0x162F6)
    AL = 0x4;
    CheckExternalEvents(cs8, 0x62FC);
    // MOV ES:[0x392e],AL (1000_62F8 / 0x162F8)
    UInt8[ES, 0x392E] = AL;
    CheckExternalEvents(cs8, 0x6300);
    // MOV ES,word ptr [0x563c] (1000_62FC / 0x162FC)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs8, 0x6304);
    // MOV ES:[0x397a],AL (1000_6300 / 0x16300)
    UInt8[ES, 0x397A] = AL;
    CheckExternalEvents(cs8, 0x6308);
    // MOV ES,word ptr [0x5644] (1000_6304 / 0x16304)
    ES = UInt16[DS, 0x5644];
    CheckExternalEvents(cs8, 0x630A);
    // SUB AL,AL (1000_6308 / 0x16308)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs8, 0x630E);
    // MOV ES:[0x392f],AL (1000_630A / 0x1630A)
    UInt8[ES, 0x392F] = AL;
    CheckExternalEvents(cs8, 0x6312);
    // MOV ES,word ptr [0x563c] (1000_630E / 0x1630E)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs8, 0x6316);
    // MOV ES:[0x397b],AL (1000_6312 / 0x16312)
    UInt8[ES, 0x397B] = AL;
    CheckExternalEvents(cs8, 0x631A);
    // MOV ES,word ptr [0x5640] (1000_6316 / 0x16316)
    ES = UInt16[DS, 0x5640];
    CheckExternalEvents(cs8, 0x631D);
    // MOV AX,0x2a0 (1000_631A / 0x1631A)
    AX = 0x2A0;
    CheckExternalEvents(cs8, 0x6320);
    // MOV DX,0x2958 (1000_631D / 0x1631D)
    DX = 0x2958;
    CheckExternalEvents(cs8, 0x6324);
    // MOV ES:[0x232],AX (1000_6320 / 0x16320)
    UInt16[ES, 0x232] = AX;
    CheckExternalEvents(cs8, 0x6329);
    // MOV word ptr ES:[0x234],DX (1000_6324 / 0x16324)
    UInt16[ES, 0x234] = DX;
    CheckExternalEvents(cs8, 0x632D);
    // MOV ES:[0x22e],AX (1000_6329 / 0x16329)
    UInt16[ES, 0x22E] = AX;
    CheckExternalEvents(cs8, 0x6332);
    // MOV word ptr ES:[0x230],DX (1000_632D / 0x1632D)
    UInt16[ES, 0x230] = DX;
    CheckExternalEvents(cs8, 0x6336);
    // MOV ES,word ptr [0x5632] (1000_6332 / 0x16332)
    ES = UInt16[DS, 0x5632];
    CheckExternalEvents(cs8, 0x6339);
    // MOV AX,0x1 (1000_6336 / 0x16336)
    AX = 0x1;
    CheckExternalEvents(cs8, 0x633D);
    // MOV ES:[0x4088],AX (1000_6339 / 0x16339)
    UInt16[ES, 0x4088] = AX;
    CheckExternalEvents(cs8, 0x6341);
    // MOV ES:[0x4086],AX (1000_633D / 0x1633D)
    UInt16[ES, 0x4086] = AX;
    CheckExternalEvents(cs8, 0x6345);
    // MOV ES,word ptr [0x5660] (1000_6341 / 0x16341)
    ES = UInt16[DS, 0x5660];
    CheckExternalEvents(cs8, 0x634C);
    // MOV word ptr ES:[0xe48e],0x0 (1000_6345 / 0x16345)
    UInt16[ES, 0xE48E] = 0x0;
    CheckExternalEvents(cs8, 0x6350);
    // MOV ES,word ptr [0x5648] (1000_634C / 0x1634C)
    ES = UInt16[DS, 0x5648];
    CheckExternalEvents(cs8, 0x6356);
    // MOV byte ptr ES:[0xd32f],0x1 (1000_6350 / 0x16350)
    UInt8[ES, 0xD32F] = 0x1;
    CheckExternalEvents(cs8, 0x635A);
    // MOV ES,word ptr [0x5638] (1000_6356 / 0x16356)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x635D);
    // MOV AX,0x97d (1000_635A / 0x1635A)
    AX = 0x97D;
    CheckExternalEvents(cs8, 0x6361);
    // MOV ES:[0x4022],AX (1000_635D / 0x1635D)
    UInt16[ES, 0x4022] = AX;
    CheckExternalEvents(cs8, 0x6365);
    // MOV ES:[0x4020],AX (1000_6361 / 0x16361)
    UInt16[ES, 0x4020] = AX;
    CheckExternalEvents(cs8, 0x6369);
    // MOV ES,word ptr [0x5636] (1000_6365 / 0x16365)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x6370);
    // MOV word ptr ES:[0x4052],0x8030 (1000_6369 / 0x16369)
    UInt16[ES, 0x4052] = 0x8030;
    CheckExternalEvents(cs8, 0x6377);
    // MOV word ptr ES:[0x4054],0x8070 (1000_6370 / 0x16370)
    UInt16[ES, 0x4054] = 0x8070;
    CheckExternalEvents(cs8, 0x637A);
    // MOV AX,0x4 (1000_6377 / 0x16377)
    AX = 0x4;
    CheckExternalEvents(cs8, 0x637B);
    // PUSH AX (1000_637A / 0x1637A)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6380);
    // CALLF 0x1000:7ee1 (1000_637B / 0x1637B)
    FarCall(cs8, 0x6380, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs8, 0x6383);
    // ADD SP,0x2 (1000_6380 / 0x16380)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    label_1000_6383_16383:
    CheckExternalEvents(cs8, 0x6386);
    // MOV SI,word ptr [BP + 0x8] (1000_6383 / 0x16383)
    SI = UInt16[SS, (ushort)(BP + 0x8)];
    CheckExternalEvents(cs8, 0x6388);
    // SHL SI,0x1 (1000_6386 / 0x16386)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x638B);
    // MOV AX,0xffff (1000_6388 / 0x16388)
    AX = 0xFFFF;
    CheckExternalEvents(cs8, 0x638F);
    // MOV ES,word ptr [0x5636] (1000_638B / 0x1638B)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x6394);
    // MOV word ptr ES:[SI + 0x4036],AX (1000_638F / 0x1638F)
    UInt16[ES, (ushort)(SI + 0x4036)] = AX;
    CheckExternalEvents(cs8, 0x6398);
    // MOV ES,word ptr [0x5638] (1000_6394 / 0x16394)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x639D);
    // MOV word ptr ES:[SI + 0x4004],AX (1000_6398 / 0x16398)
    UInt16[ES, (ushort)(SI + 0x4004)] = AX;
    CheckExternalEvents(cs8, 0x63A1);
    // MOV ES,word ptr [0x5632] (1000_639D / 0x1639D)
    ES = UInt16[DS, 0x5632];
    CheckExternalEvents(cs8, 0x63A8);
    // MOV word ptr ES:[SI + 0x406a],0x0 (1000_63A1 / 0x163A1)
    UInt16[ES, (ushort)(SI + 0x406A)] = 0x0;
    label_1000_63A8_163A8:
    CheckExternalEvents(cs8, 0x63AC);
    // MOV ES,word ptr [0x5646] (1000_63A8 / 0x163A8)
    ES = UInt16[DS, 0x5646];
    CheckExternalEvents(cs8, 0x63B2);
    // CMP word ptr ES:[0x2e3a],0x0 (1000_63AC / 0x163AC)
    Alu16.Sub(UInt16[ES, 0x2E3A], 0x0);
    CheckExternalEvents(cs8, 0x63B4);
    // JZ 0x1000:63c1 (1000_63B2 / 0x163B2)
    if(ZeroFlag) {
      goto label_1000_63C1_163C1;
    }
    CheckExternalEvents(cs8, 0x63B7);
    // MOV BX,word ptr [BP + 0x6] (1000_63B4 / 0x163B4)
    BX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x63BB);
    // MOV ES,word ptr [0x563c] (1000_63B7 / 0x163B7)
    ES = UInt16[DS, 0x563C];
    CheckExternalEvents(cs8, 0x63C1);
    // MOV byte ptr ES:[BX + 0x396c],0xff (1000_63BB / 0x163BB)
    UInt8[ES, (ushort)(BX + 0x396C)] = 0xFF;
    label_1000_63C1_163C1:
    CheckExternalEvents(cs8, 0x63C2);
    // POP SI (1000_63C1 / 0x163C1)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x63C4);
    // MOV SP,BP (1000_63C2 / 0x163C2)
    SP = BP;
    CheckExternalEvents(cs8, 0x63C5);
    // POP BP (1000_63C4 / 0x163C4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x63C6);
    // RETF  (1000_63C5 / 0x163C5)
    return FarRet();
  }
  
  public virtual Action ghidra_guess_1000_63C6_163C6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_63C6_163C6:
    CheckExternalEvents(cs8, 0x63C7);
    // PUSH BP (1000_63C6 / 0x163C6)
    Stack.Push16(BP);
    CheckExternalEvents(cs8, 0x63C9);
    // MOV BP,SP (1000_63C7 / 0x163C7)
    BP = SP;
    CheckExternalEvents(cs8, 0x63CC);
    // MOV AX,0x6 (1000_63C9 / 0x163C9)
    AX = 0x6;
    CheckExternalEvents(cs8, 0x63D1);
    // CALLF 0x1000:cecc (1000_63CC / 0x163CC)
    FarCall(cs8, 0x63D1, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs8, 0x63D2);
    // PUSH SI (1000_63D1 / 0x163D1)
    Stack.Push16(SI);
    CheckExternalEvents(cs8, 0x63D7);
    // CALLF 0x0000:30dd (1000_63D2 / 0x163D2)
    FarCall(cs8, 0x63D7, ghidra_guess_0000_30DD_030DD);
    CheckExternalEvents(cs8, 0x63DA);
    // MOV word ptr [BP + -0x2],AX (1000_63D7 / 0x163D7)
    UInt16[SS, (ushort)(BP - 0x2)] = AX;
    CheckExternalEvents(cs8, 0x63DD);
    // CMP AX,0x5 (1000_63DA / 0x163DA)
    Alu16.Sub(AX, 0x5);
    CheckExternalEvents(cs8, 0x63DF);
    // JL 0x1000:63e4 (1000_63DD / 0x163DD)
    if(SignFlag != OverflowFlag) {
      goto label_1000_63E4_163E4;
    }
    CheckExternalEvents(cs8, 0x63E2);
    // CMP AX,0x9 (1000_63DF / 0x163DF)
    Alu16.Sub(AX, 0x9);
    CheckExternalEvents(cs8, 0x63E4);
    // JLE 0x1000:642f (1000_63E2 / 0x163E2)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_642F_1642F;
    }
    label_1000_63E4_163E4:
    CheckExternalEvents(cs8, 0x63E7);
    // MOV SI,word ptr [BP + 0x6] (1000_63E4 / 0x163E4)
    SI = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs8, 0x63E9);
    // SHL SI,0x1 (1000_63E7 / 0x163E7)
    // SI <<= 0x1;
    SI = Alu16.Shl(SI, 0x1);
    CheckExternalEvents(cs8, 0x63ED);
    // MOV ES,word ptr [0x5638] (1000_63E9 / 0x163E9)
    ES = UInt16[DS, 0x5638];
    CheckExternalEvents(cs8, 0x63F2);
    // MOV AX,word ptr ES:[SI + 0x4004] (1000_63ED / 0x163ED)
    AX = UInt16[ES, (ushort)(SI + 0x4004)];
    CheckExternalEvents(cs8, 0x63F5);
    // ADD AX,word ptr [BP + 0x8] (1000_63F2 / 0x163F2)
    // AX += UInt16[SS, (ushort)(BP + 0x8)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0x8)]);
    CheckExternalEvents(cs8, 0x63F8);
    // MOV word ptr [BP + -0x4],AX (1000_63F5 / 0x163F5)
    UInt16[SS, (ushort)(BP - 0x4)] = AX;
    CheckExternalEvents(cs8, 0x63FC);
    // MOV ES,word ptr [0x5636] (1000_63F8 / 0x163F8)
    ES = UInt16[DS, 0x5636];
    CheckExternalEvents(cs8, 0x6401);
    // MOV AX,word ptr ES:[SI + 0x4036] (1000_63FC / 0x163FC)
    AX = UInt16[ES, (ushort)(SI + 0x4036)];
    CheckExternalEvents(cs8, 0x6404);
    // ADD AX,word ptr [BP + 0xa] (1000_6401 / 0x16401)
    // AX += UInt16[SS, (ushort)(BP + 0xA)];
    AX = Alu16.Add(AX, UInt16[SS, (ushort)(BP + 0xA)]);
    CheckExternalEvents(cs8, 0x6407);
    // MOV word ptr [BP + -0x6],AX (1000_6404 / 0x16404)
    UInt16[SS, (ushort)(BP - 0x6)] = AX;
    CheckExternalEvents(cs8, 0x640B);
    // TEST byte ptr [BP + -0x4],0x80 (1000_6407 / 0x16407)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x4)], 0x80);
    CheckExternalEvents(cs8, 0x640D);
    // JZ 0x1000:6412 (1000_640B / 0x1640B)
    if(ZeroFlag) {
      goto label_1000_6412_16412;
    }
    CheckExternalEvents(cs8, 0x6412);
    // AND word ptr [BP + -0x4],0xf7f (1000_640D / 0x1640D)
    UInt16[SS, (ushort)(BP - 0x4)] &= 0xF7F;
    label_1000_6412_16412:
    CheckExternalEvents(cs8, 0x6416);
    // TEST byte ptr [BP + -0x6],0x80 (1000_6412 / 0x16412)
    Alu8.And(UInt8[SS, (ushort)(BP - 0x6)], 0x80);
    CheckExternalEvents(cs8, 0x6418);
    // JZ 0x1000:641d (1000_6416 / 0x16416)
    if(ZeroFlag) {
      goto label_1000_641D_1641D;
    }
    CheckExternalEvents(cs8, 0x641D);
    // AND word ptr [BP + -0x6],0xf07f (1000_6418 / 0x16418)
    // UInt16[SS, (ushort)(BP - 0x6)] &= 0xF07F;
    UInt16[SS, (ushort)(BP - 0x6)] = Alu16.And(UInt16[SS, (ushort)(BP - 0x6)], 0xF07F);
    label_1000_641D_1641D:
    CheckExternalEvents(cs8, 0x6420);
    // PUSH word ptr [BP + -0x6] (1000_641D / 0x1641D)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x6)]);
    CheckExternalEvents(cs8, 0x6423);
    // PUSH word ptr [BP + -0x4] (1000_6420 / 0x16420)
    Stack.Push16(UInt16[SS, (ushort)(BP - 0x4)]);
    CheckExternalEvents(cs8, 0x6426);
    // MOV AX,0x7c (1000_6423 / 0x16423)
    AX = 0x7C;
    CheckExternalEvents(cs8, 0x6427);
    // PUSH AX (1000_6426 / 0x16426)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x642C);
    // CALLF 0x1000:4279 (1000_6427 / 0x16427)
    FarCall(cs8, 0x642C, ghidra_guess_1000_4279_14279);
    CheckExternalEvents(cs8, 0x642F);
    // ADD SP,0x6 (1000_642C / 0x1642C)
    // SP += 0x6;
    SP = Alu16.Add(SP, 0x6);
    label_1000_642F_1642F:
    CheckExternalEvents(cs8, 0x6430);
    // POP SI (1000_642F / 0x1642F)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x6432);
    // MOV SP,BP (1000_6430 / 0x16430)
    SP = BP;
    CheckExternalEvents(cs8, 0x6433);
    // POP BP (1000_6432 / 0x16432)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x6434);
    // RETF  (1000_6433 / 0x16433)
    return FarRet();
  }
  
  public virtual Action unknown_1643_0004_16434(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1643_0004_16434:
    CheckExternalEvents(cs9, 0x5);
    // PUSH BP (1643_0004 / 0x16434)
    Stack.Push16(BP);
    CheckExternalEvents(cs9, 0x7);
    // MOV BP,SP (1643_0005 / 0x16435)
    BP = SP;
    CheckExternalEvents(cs9, 0xA);
    // MOV AX,0x34 (1643_0007 / 0x16437)
    AX = 0x34;
    CheckExternalEvents(cs9, 0xF);
    // CALLF 0x1000:cecc (1643_000A / 0x1643A)
    FarCall(cs9, 0xF, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x10);
    // PUSH DI (1643_000F / 0x1643F)
    Stack.Push16(DI);
    CheckExternalEvents(cs9, 0x11);
    // PUSH SI (1643_0010 / 0x16440)
    Stack.Push16(SI);
    CheckExternalEvents(cs9, 0x14);
    // MOV AX,word ptr [BP + 0x6] (1643_0011 / 0x16441)
    AX = UInt16[SS, (ushort)(BP + 0x6)];
    CheckExternalEvents(cs9, 0x17);
    // SUB AX,0x1 (1643_0014 / 0x16444)
    AX -= 0x1;
    CheckExternalEvents(cs9, 0x1A);
    // CMP AX,0x2e (1643_0017 / 0x16447)
    Alu16.Sub(AX, 0x2E);
    CheckExternalEvents(cs9, 0x1C);
    // JBE 0x1000:644f (1643_001A / 0x1644A)
    if(CarryFlag || ZeroFlag) {
      goto label_1643_001F_1644F;
    }
    CheckExternalEvents(cs9, 0x1F);
    // JMP 0x1000:7bf0 (1643_001C / 0x1644C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1643_001F_1644F:
    CheckExternalEvents(cs9, 0x21);
    // ADD AX,AX (1643_001F / 0x1644F)
    // AX += AX;
    AX = Alu16.Add(AX, AX);
    CheckExternalEvents(cs9, 0x22);
    // XCHG AX,BX (1643_0021 / 0x16451)
    (BX, AX) = (AX, BX);
    CheckExternalEvents(cs9, 0x27);
    // JMP word ptr CS:[BX + 0x1762] (1643_0022 / 0x16452)
    // Indirect jump to word ptr CS:[BX + 0x1762], generating possible targets from emulator records
    uint targetAddress_1643_0022 = (uint)(cs9 * 0x10 + UInt16[cs9, (ushort)(BX + 0x1762)] - cs1 * 0x10);
    switch(targetAddress_1643_0022) {
      case 0x16D9F : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(spice86_imported_label_jump_target_1643_096F_16D9F, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x16F22 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_1000_6F22_16F22, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x16457 : {
        goto label_1643_0027_16457;
        break;
      }
      case 0x165F2 : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_1000_65F2_165F2, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      case 0x16F1A : {
        // Jump converted to entry function call
        if(JumpDispatcher.Jump(split_1000_6F1A_16F1A, 0)) {
          loadOffset = JumpDispatcher.NextEntryAddress;
          goto entrydispatcher;
        }
        return JumpDispatcher.JumpAsmReturn!;
      }
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1643_0022));
        break;
    }
    label_1643_0027_16457:
    CheckExternalEvents(cs9, 0x2C);
    // MOV word ptr [BP + -0x12],0x2f0 (1643_0027 / 0x16457)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x2F0;
    CheckExternalEvents(cs9, 0x31);
    // MOV word ptr [BP + -0x10],0x2958 (1643_002C / 0x1645C)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x2958;
    CheckExternalEvents(cs9, 0x35);
    // MOV ES,word ptr [0x569c] (1643_0031 / 0x16461)
    ES = UInt16[DS, 0x569C];
    CheckExternalEvents(cs9, 0x3B);
    // MOV byte ptr ES:[0xd55e],0x0 (1643_0035 / 0x16465)
    UInt8[ES, 0xD55E] = 0x0;
    CheckExternalEvents(cs9, 0x3F);
    // MOV ES,word ptr [0x569e] (1643_003B / 0x1646B)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs9, 0x45);
    // CMP byte ptr ES:[0xd30e],0x0 (1643_003F / 0x1646F)
    Alu8.Sub(UInt8[ES, 0xD30E], 0x0);
    CheckExternalEvents(cs9, 0x47);
    // JZ 0x1000:64a1 (1643_0045 / 0x16475)
    if(ZeroFlag) {
      goto label_1643_0071_164A1;
    }
    CheckExternalEvents(cs9, 0x4B);
    // MOV ES,word ptr [0x569c] (1643_0047 / 0x16477)
    ES = UInt16[DS, 0x569C];
    CheckExternalEvents(cs9, 0x51);
    // MOV byte ptr ES:[0xd55e],0x92 (1643_004B / 0x1647B)
    UInt8[ES, 0xD55E] = 0x92;
    CheckExternalEvents(cs9, 0x56);
    // MOV word ptr [BP + -0x12],0x36d (1643_0051 / 0x16481)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x36D;
    CheckExternalEvents(cs9, 0x5B);
    // MOV word ptr [BP + -0x10],0x2958 (1643_0056 / 0x16486)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x2958;
    CheckExternalEvents(cs9, 0x5F);
    // MOV ES,word ptr [0x569e] (1643_005B / 0x1648B)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs9, 0x65);
    // CMP byte ptr ES:[0xd30e],0x2 (1643_005F / 0x1648F)
    Alu8.Sub(UInt8[ES, 0xD30E], 0x2);
    CheckExternalEvents(cs9, 0x67);
    // JNZ 0x1000:64a1 (1643_0065 / 0x16495)
    if(!ZeroFlag) {
      goto label_1643_0071_164A1;
    }
    CheckExternalEvents(cs9, 0x6C);
    // MOV word ptr [BP + -0x12],0x4e4 (1643_0067 / 0x16497)
    UInt16[SS, (ushort)(BP - 0x12)] = 0x4E4;
    CheckExternalEvents(cs9, 0x71);
    // MOV word ptr [BP + -0x10],0x2958 (1643_006C / 0x1649C)
    UInt16[SS, (ushort)(BP - 0x10)] = 0x2958;
    label_1643_0071_164A1:
    CheckExternalEvents(cs9, 0x77);
    // MOV byte ptr ES:[0xc620],0x0 (1643_0071 / 0x164A1)
    UInt8[ES, 0xC620] = 0x0;
    CheckExternalEvents(cs9, 0x7C);
    // MOV word ptr [BP + -0x16],0x0 (1643_0077 / 0x164A7)
    UInt16[SS, (ushort)(BP - 0x16)] = 0x0;
    label_1643_007C_164AC:
    CheckExternalEvents(cs9, 0x7F);
    // LES BX,[BP + -0x12] (1643_007C / 0x164AC)
    BX = UInt16[SS, (ushort)(BP - 0x12)];
    ES = UInt16[SS, (ushort)(BP - 0x12 + 2)];
    CheckExternalEvents(cs9, 0x82);
    // INC word ptr [BP + -0x12] (1643_007F / 0x164AF)
    UInt16[SS, (ushort)(BP - 0x12)] = Alu16.Inc(UInt16[SS, (ushort)(BP - 0x12)]);
    CheckExternalEvents(cs9, 0x85);
    // MOV AL,byte ptr ES:[BX] (1643_0082 / 0x164B2)
    AL = UInt8[ES, (ushort)(BX)];
    CheckExternalEvents(cs9, 0x88);
    // MOV BX,word ptr [BP + -0x16] (1643_0085 / 0x164B5)
    BX = UInt16[SS, (ushort)(BP - 0x16)];
    CheckExternalEvents(cs9, 0x8C);
    // MOV ES,word ptr [0x569e] (1643_0088 / 0x164B8)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs9, 0x91);
    // MOV byte ptr ES:[BX + 0xc724],AL (1643_008C / 0x164BC)
    UInt8[ES, (ushort)(BX + 0xC724)] = AL;
    CheckExternalEvents(cs9, 0x94);
    // INC word ptr [BP + -0x16] (1643_0091 / 0x164C1)
    UInt16[SS, (ushort)(BP - 0x16)]++;
    CheckExternalEvents(cs9, 0x98);
    // CMP word ptr [BP + -0x16],0x7d (1643_0094 / 0x164C4)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x16)], 0x7D);
    CheckExternalEvents(cs9, 0x9A);
    // JL 0x1000:64ac (1643_0098 / 0x164C8)
    if(SignFlag != OverflowFlag) {
      goto label_1643_007C_164AC;
    }
    CheckExternalEvents(cs9, 0xA0);
    // MOV byte ptr ES:[0xc79d],0x0 (1643_009A / 0x164CA)
    UInt8[ES, 0xC79D] = 0x0;
    CheckExternalEvents(cs9, 0xA4);
    // MOV ES,word ptr [0x56a0] (1643_00A0 / 0x164D0)
    ES = UInt16[DS, 0x56A0];
    CheckExternalEvents(cs9, 0xAA);
    // CMP word ptr ES:[0x3938],0x0 (1643_00A4 / 0x164D4)
    Alu16.Sub(UInt16[ES, 0x3938], 0x0);
    CheckExternalEvents(cs9, 0xAC);
    // JNZ 0x1000:64e8 (1643_00AA / 0x164DA)
    if(!ZeroFlag) {
      goto label_1643_00B8_164E8;
    }
    CheckExternalEvents(cs9, 0xAE);
    // SUB AX,AX (1643_00AC / 0x164DC)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0xAF);
    // PUSH AX (1643_00AE / 0x164DE)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xB0);
    // PUSH AX (1643_00AF / 0x164DF)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0xB5);
    // CALLF 0x0000:5fb7 (1643_00B0 / 0x164E0)
    FarCall(cs9, 0xB5, unknown_0170_48B7_05FB7);
    CheckExternalEvents(cs9, 0xB8);
    // ADD SP,0x4 (1643_00B5 / 0x164E5)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    label_1643_00B8_164E8:
    CheckExternalEvents(cs9, 0xBC);
    // MOV ES,word ptr [0x56a2] (1643_00B8 / 0x164E8)
    ES = UInt16[DS, 0x56A2];
    CheckExternalEvents(cs9, 0xC3);
    // MOV word ptr ES:[0xa44d],0xc04f (1643_00BC / 0x164EC)
    UInt16[ES, 0xA44D] = 0xC04F;
    CheckExternalEvents(cs9, 0xC7);
    // MOV ES,word ptr [0x56a4] (1643_00C3 / 0x164F3)
    ES = UInt16[DS, 0x56A4];
    CheckExternalEvents(cs9, 0xCE);
    // MOV word ptr ES:[0x1f6],0x280 (1643_00C7 / 0x164F7)
    UInt16[ES, 0x1F6] = 0x280;
    CheckExternalEvents(cs9, 0xD5);
    // MOV word ptr ES:[0x1f8],0x2958 (1643_00CE / 0x164FE)
    UInt16[ES, 0x1F8] = 0x2958;
    CheckExternalEvents(cs9, 0xD9);
    // MOV ES,word ptr [0x56a6] (1643_00D5 / 0x16505)
    ES = UInt16[DS, 0x56A6];
    CheckExternalEvents(cs9, 0xE0);
    // MOV word ptr ES:[0xa44b],0xc3c (1643_00D9 / 0x16509)
    UInt16[ES, 0xA44B] = 0xC3C;
    CheckExternalEvents(cs9, 0xE2);
    // JMP 0x1000:656c (1643_00E0 / 0x16510)
    goto label_1643_013C_1656C;
    label_1643_00E2_16512:
    CheckExternalEvents(cs9, 0xE5);
    // INC word ptr [BP + -0x1c] (1643_00E2 / 0x16512)
    UInt16[SS, (ushort)(BP - 0x1C)]++;
    label_1643_00E5_16515:
    CheckExternalEvents(cs9, 0xE9);
    // CMP word ptr [BP + -0x1c],0x6 (1643_00E5 / 0x16515)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x1C)], 0x6);
    CheckExternalEvents(cs9, 0xEB);
    // JGE 0x1000:6563 (1643_00E9 / 0x16519)
    if(SignFlag == OverflowFlag) {
      goto label_1643_0133_16563;
    }
    CheckExternalEvents(cs9, 0xF0);
    // CALLF 0x0000:3b0b (1643_00EB / 0x1651B)
    FarCall(cs9, 0xF0, unknown_0170_240B_03B0B);
    CheckExternalEvents(cs9, 0xF4);
    // MOV ES,word ptr [0x56a2] (1643_00F0 / 0x16520)
    ES = UInt16[DS, 0x56A2];
    CheckExternalEvents(cs9, 0xF9);
    // PUSH word ptr ES:[0xa44d] (1643_00F4 / 0x16524)
    Stack.Push16(UInt16[ES, 0xA44D]);
    CheckExternalEvents(cs9, 0xFD);
    // MOV ES,word ptr [0x56a6] (1643_00F9 / 0x16529)
    ES = UInt16[DS, 0x56A6];
    CheckExternalEvents(cs9, 0x102);
    // PUSH word ptr ES:[0xa44b] (1643_00FD / 0x1652D)
    Stack.Push16(UInt16[ES, 0xA44B]);
    CheckExternalEvents(cs9, 0x107);
    // CALLF 0x1000:b204 (1643_0102 / 0x16532)
    FarCall(cs9, 0x107, unknown_19EF_1314_1B204);
    CheckExternalEvents(cs9, 0x10A);
    // ADD SP,0x4 (1643_0107 / 0x16537)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs9, 0x10F);
    // CALLF 0x1000:b7df (1643_010A / 0x1653A)
    FarCall(cs9, 0x10F, unknown_19EF_18EF_1B7DF);
    CheckExternalEvents(cs9, 0x114);
    // CALLF 0x0000:1c1b (1643_010F / 0x1653F)
    FarCall(cs9, 0x114, unknown_0170_051B_01C1B);
    CheckExternalEvents(cs9, 0x119);
    // CALLF 0x1000:9193 (1643_0114 / 0x16544)
    FarCall(cs9, 0x119, unknown_18AD_06C3_19193);
    CheckExternalEvents(cs9, 0x11D);
    // MOV ES,word ptr [0x56aa] (1643_0119 / 0x16549)
    ES = UInt16[DS, 0x56AA];
    CheckExternalEvents(cs9, 0x123);
    // CMP word ptr ES:[0x3ff4],0x8 (1643_011D / 0x1654D)
    Alu16.Sub(UInt16[ES, 0x3FF4], 0x8);
    CheckExternalEvents(cs9, 0x125);
    // JLE 0x1000:6512 (1643_0123 / 0x16553)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1643_00E2_16512;
    }
    CheckExternalEvents(cs9, 0x128);
    // MOV AX,0x3 (1643_0125 / 0x16555)
    AX = 0x3;
    CheckExternalEvents(cs9, 0x129);
    // PUSH AX (1643_0128 / 0x16558)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x12E);
    // CALLF 0x1000:8ad6 (1643_0129 / 0x16559)
    FarCall(cs9, 0x12E, unknown_18AD_0006_18AD6);
    CheckExternalEvents(cs9, 0x131);
    // ADD SP,0x2 (1643_012E / 0x1655E)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0x133);
    // JMP 0x1000:6512 (1643_0131 / 0x16561)
    goto label_1643_00E2_16512;
    label_1643_0133_16563:
    CheckExternalEvents(cs9, 0x137);
    // MOV ES,word ptr [0x56a6] (1643_0133 / 0x16563)
    ES = UInt16[DS, 0x56A6];
    CheckExternalEvents(cs9, 0x13C);
    // INC word ptr ES:[0xa44b] (1643_0137 / 0x16567)
    UInt16[ES, 0xA44B]++;
    label_1643_013C_1656C:
    CheckExternalEvents(cs9, 0x143);
    // CMP word ptr ES:[0xa44b],0xc40 (1643_013C / 0x1656C)
    Alu16.Sub(UInt16[ES, 0xA44B], 0xC40);
    CheckExternalEvents(cs9, 0x145);
    // JNC 0x1000:658f (1643_0143 / 0x16573)
    if(!CarryFlag) {
      goto label_1643_015F_1658F;
    }
    CheckExternalEvents(cs9, 0x147);
    // SUB AX,AX (1643_0145 / 0x16575)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x148);
    // PUSH AX (1643_0147 / 0x16577)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x14D);
    // CALLF 0x0000:2e32 (1643_0148 / 0x16578)
    FarCall(cs9, 0x14D, unknown_0170_1732_02E32);
    CheckExternalEvents(cs9, 0x150);
    // ADD SP,0x2 (1643_014D / 0x1657D)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0x154);
    // MOV ES,word ptr [0x56a8] (1643_0150 / 0x16580)
    ES = UInt16[DS, 0x56A8];
    CheckExternalEvents(cs9, 0x158);
    // MOV ES:[0x409a],AL (1643_0154 / 0x16584)
    UInt8[ES, 0x409A] = AL;
    CheckExternalEvents(cs9, 0x15D);
    // MOV word ptr [BP + -0x1c],0x0 (1643_0158 / 0x16588)
    UInt16[SS, (ushort)(BP - 0x1C)] = 0x0;
    CheckExternalEvents(cs9, 0x15F);
    // JMP 0x1000:6515 (1643_015D / 0x1658D)
    goto label_1643_00E5_16515;
    label_1643_015F_1658F:
    CheckExternalEvents(cs9, 0x161);
    // SUB AX,AX (1643_015F / 0x1658F)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x162);
    // PUSH AX (1643_0161 / 0x16591)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x167);
    // CALLF 0x0000:2e32 (1643_0162 / 0x16592)
    FarCall(cs9, 0x167, unknown_0170_1732_02E32);
    CheckExternalEvents(cs9, 0x16A);
    // ADD SP,0x2 (1643_0167 / 0x16597)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0x16E);
    // MOV ES,word ptr [0x56a8] (1643_016A / 0x1659A)
    ES = UInt16[DS, 0x56A8];
    CheckExternalEvents(cs9, 0x172);
    // MOV ES:[0x409a],AL (1643_016E / 0x1659E)
    UInt8[ES, 0x409A] = AL;
    CheckExternalEvents(cs9, 0x176);
    // MOV ES,word ptr [0x569e] (1643_0172 / 0x165A2)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs9, 0x17A);
    // MOV AL,ES:[0xd30c] (1643_0176 / 0x165A6)
    AL = UInt8[ES, 0xD30C];
    CheckExternalEvents(cs9, 0x17B);
    // CBW  (1643_017A / 0x165AA)
    AX = (ushort)((short)((sbyte)AL));
    CheckExternalEvents(cs9, 0x17C);
    // PUSH AX (1643_017B / 0x165AB)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x181);
    // CALLF 0x0000:9ae9 (1643_017C / 0x165AC)
    FarCall(cs9, 0x181, unknown_094C_0629_09AE9);
    CheckExternalEvents(cs9, 0x184);
    // ADD SP,0x2 (1643_0181 / 0x165B1)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0x187);
    // JMP 0x1000:7bf0 (1643_0184 / 0x165B4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_65E5_165E5(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_65E5_165E5:
    CheckExternalEvents(cs8, 0x65E6);
    // PUSH DS (1000_65E5 / 0x165E5)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x65E7);
    // PUSH AX (1000_65E6 / 0x165E6)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x65EC);
    // CALLF 0x1000:8055 (1000_65E7 / 0x165E7)
    FarCall(cs8, 0x65EC, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x65EF);
    // ADD SP,0x4 (1000_65EC / 0x165EC)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x65F2);
    // JMP 0x1000:7bf0 (1000_65EF / 0x165EF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_65F2_165F2(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_65F2_165F2:
    CheckExternalEvents(cs8, 0x65F6);
    // MOV ES,word ptr [0x569e] (1000_65F2 / 0x165F2)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs8, 0x65FC);
    // MOV byte ptr ES:[0xc724],0xff (1000_65F6 / 0x165F6)
    UInt8[ES, 0xC724] = 0xFF;
    CheckExternalEvents(cs8, 0x6602);
    // MOV byte ptr ES:[0xc620],0x8 (1000_65FC / 0x165FC)
    UInt8[ES, 0xC620] = 0x8;
    CheckExternalEvents(cs8, 0x6606);
    // MOV ES,word ptr [0x56a6] (1000_6602 / 0x16602)
    ES = UInt16[DS, 0x56A6];
    CheckExternalEvents(cs8, 0x660D);
    // MOV word ptr ES:[0xa44b],0xc2e (1000_6606 / 0x16606)
    UInt16[ES, 0xA44B] = 0xC2E;
    CheckExternalEvents(cs8, 0x6611);
    // MOV ES,word ptr [0x56a2] (1000_660D / 0x1660D)
    ES = UInt16[DS, 0x56A2];
    CheckExternalEvents(cs8, 0x6618);
    // MOV word ptr ES:[0xa44d],0xc076 (1000_6611 / 0x16611)
    UInt16[ES, 0xA44D] = 0xC076;
    CheckExternalEvents(cs8, 0x661C);
    // MOV ES,word ptr [0x569e] (1000_6618 / 0x16618)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs8, 0x6622);
    // CMP byte ptr ES:[0xd310],0x0 (1000_661C / 0x1661C)
    Alu8.Sub(UInt8[ES, 0xD310], 0x0);
    CheckExternalEvents(cs8, 0x6624);
    // JZ 0x1000:6627 (1000_6622 / 0x16622)
    if(ZeroFlag) {
      goto label_1000_6627_16627;
    }
    CheckExternalEvents(cs8, 0x6627);
    // JMP 0x1000:7bf0 (1000_6624 / 0x16624)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6627_16627:
    CheckExternalEvents(cs8, 0x662C);
    // MOV word ptr [BP + -0x18],0x0 (1000_6627 / 0x16627)
    UInt16[SS, (ushort)(BP - 0x18)] = 0x0;
    label_1000_662C_1662C:
    CheckExternalEvents(cs8, 0x662F);
    // MOV BX,word ptr [BP + -0x18] (1000_662C / 0x1662C)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs8, 0x6633);
    // MOV ES,word ptr [0x569e] (1000_662F / 0x1662F)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs8, 0x6638);
    // MOV AL,byte ptr ES:[BX + 0xd457] (1000_6633 / 0x16633)
    AL = UInt8[ES, (ushort)(BX + 0xD457)];
    CheckExternalEvents(cs8, 0x663A);
    // AND AL,0x7e (1000_6638 / 0x16638)
    AL &= 0x7E;
    CheckExternalEvents(cs8, 0x663C);
    // CMP AL,0x7c (1000_663A / 0x1663A)
    Alu8.Sub(AL, 0x7C);
    CheckExternalEvents(cs8, 0x663E);
    // JNZ 0x1000:6655 (1000_663C / 0x1663C)
    if(!ZeroFlag) {
      goto label_1000_6655_16655;
    }
    CheckExternalEvents(cs8, 0x6640);
    // SUB AL,AL (1000_663E / 0x1663E)
    // AL -= AL;
    AL = Alu8.Sub(AL, AL);
    CheckExternalEvents(cs8, 0x6645);
    // MOV byte ptr ES:[BX + 0xd4d7],AL (1000_6640 / 0x16640)
    UInt8[ES, (ushort)(BX + 0xD4D7)] = AL;
    CheckExternalEvents(cs8, 0x6648);
    // MOV BX,word ptr [BP + -0x18] (1000_6645 / 0x16645)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs8, 0x664D);
    // MOV byte ptr ES:[BX + 0xd497],AL (1000_6648 / 0x16648)
    UInt8[ES, (ushort)(BX + 0xD497)] = AL;
    CheckExternalEvents(cs8, 0x6650);
    // MOV BX,word ptr [BP + -0x18] (1000_664D / 0x1664D)
    BX = UInt16[SS, (ushort)(BP - 0x18)];
    CheckExternalEvents(cs8, 0x6655);
    // MOV byte ptr ES:[BX + 0xd457],AL (1000_6650 / 0x16650)
    UInt8[ES, (ushort)(BX + 0xD457)] = AL;
    label_1000_6655_16655:
    CheckExternalEvents(cs8, 0x6658);
    // INC word ptr [BP + -0x18] (1000_6655 / 0x16655)
    UInt16[SS, (ushort)(BP - 0x18)]++;
    CheckExternalEvents(cs8, 0x665C);
    // CMP word ptr [BP + -0x18],0x40 (1000_6658 / 0x16658)
    Alu16.Sub(UInt16[SS, (ushort)(BP - 0x18)], 0x40);
    CheckExternalEvents(cs8, 0x665E);
    // JL 0x1000:662c (1000_665C / 0x1665C)
    if(SignFlag != OverflowFlag) {
      goto label_1000_662C_1662C;
    }
    CheckExternalEvents(cs8, 0x6661);
    // JMP 0x1000:7bf0 (1000_665E / 0x1665E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_6ABC_16ABC(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6ABC_16ABC:
    CheckExternalEvents(cs8, 0x6ABF);
    // MOV AX,0x4a8d (1000_6ABC / 0x16ABC)
    AX = 0x4A8D;
    CheckExternalEvents(cs8, 0x6AC0);
    // PUSH DS (1000_6ABF / 0x16ABF)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x6AC1);
    // PUSH AX (1000_6AC0 / 0x16AC0)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6AC6);
    // CALLF 0x1000:8055 (1000_6AC1 / 0x16AC1)
    FarCall(cs8, 0x6AC6, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x6AC9);
    // ADD SP,0x4 (1000_6AC6 / 0x16AC6)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x6ACC);
    // MOV AX,word ptr [BP + -0x22] (1000_6AC9 / 0x16AC9)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs8, 0x6ACF);
    // MOV DX,word ptr [BP + -0x20] (1000_6ACC / 0x16ACC)
    DX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs8, 0x6AD2);
    // MOV BX,word ptr [BP + -0x1e] (1000_6ACF / 0x16ACF)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs8, 0x6AD4);
    // SHL BX,0x1 (1000_6AD2 / 0x16AD2)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x6AD6);
    // SHL BX,0x1 (1000_6AD4 / 0x16AD4)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x6ADA);
    // MOV ES,word ptr [0x569e] (1000_6AD6 / 0x16AD6)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs8, 0x6ADF);
    // SUB word ptr ES:[BX + 0xd374],AX (1000_6ADA / 0x16ADA)
    // UInt16[ES, (ushort)(BX + 0xD374)] -= AX;
    UInt16[ES, (ushort)(BX + 0xD374)] = Alu16.Sub(UInt16[ES, (ushort)(BX + 0xD374)], AX);
    CheckExternalEvents(cs8, 0x6AE4);
    // SBB word ptr ES:[BX + 0xd376],DX (1000_6ADF / 0x16ADF)
    UInt16[ES, (ushort)(BX + 0xD376)] = Alu16.Sbb(UInt16[ES, (ushort)(BX + 0xD376)], DX);
    CheckExternalEvents(cs8, 0x6AE7);
    // MOV AX,word ptr [BP + -0x22] (1000_6AE4 / 0x16AE4)
    AX = UInt16[SS, (ushort)(BP - 0x22)];
    CheckExternalEvents(cs8, 0x6AEA);
    // MOV DX,word ptr [BP + -0x20] (1000_6AE7 / 0x16AE7)
    DX = UInt16[SS, (ushort)(BP - 0x20)];
    CheckExternalEvents(cs8, 0x6AEF);
    // ADD word ptr ES:[0xd370],AX (1000_6AEA / 0x16AEA)
    // UInt16[ES, 0xD370] += AX;
    UInt16[ES, 0xD370] = Alu16.Add(UInt16[ES, 0xD370], AX);
    CheckExternalEvents(cs8, 0x6AF4);
    // ADC word ptr ES:[0xd372],DX (1000_6AEF / 0x16AEF)
    UInt16[ES, 0xD372] = Alu16.Adc(UInt16[ES, 0xD372], DX);
    CheckExternalEvents(cs8, 0x6AF7);
    // MOV AX,0xa (1000_6AF4 / 0x16AF4)
    AX = 0xA;
    CheckExternalEvents(cs8, 0x6AF8);
    // PUSH AX (1000_6AF7 / 0x16AF7)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6AFB);
    // MOV AX,0x12 (1000_6AF8 / 0x16AF8)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x6AFE);
    // MOV DX,0x2a02 (1000_6AFB / 0x16AFB)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x6AFF);
    // PUSH DX (1000_6AFE / 0x16AFE)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x6B00);
    // PUSH AX (1000_6AFF / 0x16AFF)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6B03);
    // MOV BX,word ptr [BP + -0x1e] (1000_6B00 / 0x16B00)
    BX = UInt16[SS, (ushort)(BP - 0x1E)];
    CheckExternalEvents(cs8, 0x6B05);
    // SHL BX,0x1 (1000_6B03 / 0x16B03)
    BX <<= 0x1;
    CheckExternalEvents(cs8, 0x6B07);
    // SHL BX,0x1 (1000_6B05 / 0x16B05)
    // BX <<= 0x1;
    BX = Alu16.Shl(BX, 0x1);
    CheckExternalEvents(cs8, 0x6B0C);
    // PUSH word ptr ES:[BX + 0xd376] (1000_6B07 / 0x16B07)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0xD376)]);
    CheckExternalEvents(cs8, 0x6B11);
    // PUSH word ptr ES:[BX + 0xd374] (1000_6B0C / 0x16B0C)
    Stack.Push16(UInt16[ES, (ushort)(BX + 0xD374)]);
    CheckExternalEvents(cs8, 0x6B16);
    // CALLF 0x1000:dac2 (1000_6B11 / 0x16B11)
    FarCall(cs8, 0x6B16, unknown_19EF_3BD2_1DAC2);
    CheckExternalEvents(cs8, 0x6B19);
    // ADD SP,0xa (1000_6B16 / 0x16B16)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs8, 0x6B1D);
    // MOV ES,word ptr [0x56b0] (1000_6B19 / 0x16B19)
    ES = UInt16[DS, 0x56B0];
    CheckExternalEvents(cs8, 0x6B20);
    // MOV AX,word ptr [BP + -0x30] (1000_6B1D / 0x16B1D)
    AX = UInt16[SS, (ushort)(BP - 0x30)];
    CheckExternalEvents(cs8, 0x6B24);
    // MOV ES:[0x37fe],AX (1000_6B20 / 0x16B20)
    UInt16[ES, 0x37FE] = AX;
    CheckExternalEvents(cs8, 0x6B27);
    // MOV AX,0x12 (1000_6B24 / 0x16B24)
    AX = 0x12;
    CheckExternalEvents(cs8, 0x6B2A);
    // MOV DX,0x2a02 (1000_6B27 / 0x16B27)
    DX = 0x2A02;
    CheckExternalEvents(cs8, 0x6B2B);
    // PUSH DX (1000_6B2A / 0x16B2A)
    Stack.Push16(DX);
    CheckExternalEvents(cs8, 0x6B2C);
    // PUSH AX (1000_6B2B / 0x16B2B)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6B31);
    // CALLF 0x1000:8055 (1000_6B2C / 0x16B2C)
    FarCall(cs8, 0x6B31, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x6B34);
    // ADD SP,0x4 (1000_6B31 / 0x16B31)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x6B37);
    // MOV AX,0x4abc (1000_6B34 / 0x16B34)
    AX = 0x4ABC;
    CheckExternalEvents(cs8, 0x6B3A);
    // JMP 0x1000:6d87 (1000_6B37 / 0x16B37)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_6D87_16D87, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_6D87_16D87(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6D87_16D87:
    CheckExternalEvents(cs8, 0x6D88);
    // PUSH DS (1000_6D87 / 0x16D87)
    Stack.Push16(DS);
    CheckExternalEvents(cs8, 0x6D89);
    // PUSH AX (1000_6D88 / 0x16D88)
    Stack.Push16(AX);
    CheckExternalEvents(cs8, 0x6D8E);
    // CALLF 0x1000:8055 (1000_6D89 / 0x16D89)
    FarCall(cs8, 0x6D8E, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs8, 0x6D91);
    // ADD SP,0x4 (1000_6D8E / 0x16D8E)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs8, 0x6D96);
    // CALLF 0x1000:19ef (1000_6D91 / 0x16D91)
    FarCall(cs8, 0x6D96, unknown_0FA1_1FDF_119EF);
    CheckExternalEvents(cs8, 0x6D99);
    // JMP 0x1000:7bf0 (1000_6D96 / 0x16D96)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action spice86_imported_label_jump_target_1643_096F_16D9F(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1643_096F_16D9F:
    CheckExternalEvents(cs9, 0x972);
    // MOV AX,0xa (1643_096F / 0x16D9F)
    AX = 0xA;
    CheckExternalEvents(cs9, 0x973);
    // PUSH AX (1643_0972 / 0x16DA2)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x976);
    // MOV AX,0x12 (1643_0973 / 0x16DA3)
    AX = 0x12;
    CheckExternalEvents(cs9, 0x979);
    // MOV DX,0x2a02 (1643_0976 / 0x16DA6)
    DX = 0x2A02;
    CheckExternalEvents(cs9, 0x97A);
    // PUSH DX (1643_0979 / 0x16DA9)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0x97B);
    // PUSH AX (1643_097A / 0x16DAA)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x97F);
    // MOV ES,word ptr [0x569e] (1643_097B / 0x16DAB)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs9, 0x984);
    // PUSH word ptr ES:[0xd372] (1643_097F / 0x16DAF)
    Stack.Push16(UInt16[ES, 0xD372]);
    CheckExternalEvents(cs9, 0x989);
    // PUSH word ptr ES:[0xd370] (1643_0984 / 0x16DB4)
    Stack.Push16(UInt16[ES, 0xD370]);
    CheckExternalEvents(cs9, 0x98E);
    // CALLF 0x1000:dac2 (1643_0989 / 0x16DB9)
    FarCall(cs9, 0x98E, unknown_19EF_3BD2_1DAC2);
    CheckExternalEvents(cs9, 0x991);
    // ADD SP,0xa (1643_098E / 0x16DBE)
    // SP += 0xA;
    SP = Alu16.Add(SP, 0xA);
    CheckExternalEvents(cs9, 0x995);
    // MOV ES,word ptr [0x56b0] (1643_0991 / 0x16DC1)
    ES = UInt16[DS, 0x56B0];
    CheckExternalEvents(cs9, 0x99C);
    // MOV word ptr ES:[0x37fe],0x2 (1643_0995 / 0x16DC5)
    UInt16[ES, 0x37FE] = 0x2;
    CheckExternalEvents(cs9, 0x9A0);
    // MOV ES,word ptr [0x56ac] (1643_099C / 0x16DCC)
    ES = UInt16[DS, 0x56AC];
    CheckExternalEvents(cs9, 0x9A6);
    // CMP word ptr ES:[0x4fba],0x0 (1643_09A0 / 0x16DD0)
    Alu16.Sub(UInt16[ES, 0x4FBA], 0x0);
    CheckExternalEvents(cs9, 0x9A8);
    // JNZ 0x1000:6de1 (1643_09A6 / 0x16DD6)
    if(!ZeroFlag) {
      goto label_1643_09B1_16DE1;
    }
    CheckExternalEvents(cs9, 0x9AC);
    // MOV ES,word ptr [0x56b0] (1643_09A8 / 0x16DD8)
    ES = UInt16[DS, 0x56B0];
    CheckExternalEvents(cs9, 0x9B1);
    // DEC word ptr ES:[0x37fe] (1643_09AC / 0x16DDC)
    UInt16[ES, 0x37FE] = Alu16.Dec(UInt16[ES, 0x37FE]);
    label_1643_09B1_16DE1:
    CheckExternalEvents(cs9, 0x9B4);
    // MOV AX,0x12 (1643_09B1 / 0x16DE1)
    AX = 0x12;
    CheckExternalEvents(cs9, 0x9B7);
    // MOV DX,0x2a02 (1643_09B4 / 0x16DE4)
    DX = 0x2A02;
    CheckExternalEvents(cs9, 0x9B8);
    // PUSH DX (1643_09B7 / 0x16DE7)
    Stack.Push16(DX);
    CheckExternalEvents(cs9, 0x9B9);
    // PUSH AX (1643_09B8 / 0x16DE8)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x9BE);
    // CALLF 0x1000:8055 (1643_09B9 / 0x16DE9)
    FarCall(cs9, 0x9BE, unknown_17C6_03F5_18055);
    CheckExternalEvents(cs9, 0x9C1);
    // ADD SP,0x4 (1643_09BE / 0x16DEE)
    // SP += 0x4;
    SP = Alu16.Add(SP, 0x4);
    CheckExternalEvents(cs9, 0x9C4);
    // MOV AX,0x4c18 (1643_09C1 / 0x16DF1)
    AX = 0x4C18;
    CheckExternalEvents(cs9, 0x9C7);
    // JMP 0x1000:65e5 (1643_09C4 / 0x16DF4)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_65E5_165E5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_6F1A_16F1A(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6F1A_16F1A:
    CheckExternalEvents(cs8, 0x6F1F);
    // CALLF 0x0000:ac79 (1000_6F1A / 0x16F1A)
    FarCall(cs8, 0x6F1F, unknown_094C_17B9_0AC79);
    CheckExternalEvents(cs8, 0x6F22);
    // JMP 0x1000:7bf0 (1000_6F1F / 0x16F1F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public virtual Action split_1000_6F22_16F22(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_6F22_16F22:
    CheckExternalEvents(cs8, 0x6F26);
    // MOV ES,word ptr [0x569e] (1000_6F22 / 0x16F22)
    ES = UInt16[DS, 0x569E];
    CheckExternalEvents(cs8, 0x6F2C);
    // MOV byte ptr ES:[0xd31a],0x0 (1000_6F26 / 0x16F26)
    UInt8[ES, 0xD31A] = 0x0;
    CheckExternalEvents(cs8, 0x6F31);
    // MOV word ptr [BP + 0x6],0x1 (1000_6F2C / 0x16F2C)
    UInt16[SS, (ushort)(BP + 0x6)] = 0x1;
    CheckExternalEvents(cs8, 0x6F33);
    // JMP 0x1000:6f36 (1000_6F31 / 0x16F31)
    goto label_1000_6F36_16F36;
    label_1000_6F33_16F33:
    CheckExternalEvents(cs8, 0x6F36);
    // INC word ptr [BP + 0x6] (1000_6F33 / 0x16F33)
    UInt16[SS, (ushort)(BP + 0x6)]++;
    label_1000_6F36_16F36:
    CheckExternalEvents(cs8, 0x6F3A);
    // CMP word ptr [BP + 0x6],0x8 (1000_6F36 / 0x16F36)
    Alu16.Sub(UInt16[SS, (ushort)(BP + 0x6)], 0x8);
    CheckExternalEvents(cs8, 0x6F3C);
    // JL 0x1000:6f3f (1000_6F3A / 0x16F3A)
    if(SignFlag != OverflowFlag) {
      goto label_1000_6F3F_16F3F;
    }
    CheckExternalEvents(cs8, 0x6F3F);
    // JMP 0x1000:7bf0 (1000_6F3C / 0x16F3C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_7BF0_17BF0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_6F3F_16F3F:
    CheckExternalEvents(cs8, 0x6F42);
    // MOV AX,0x11 (1000_6F3F / 0x16F3F)
    AX = 0x11;
    CheckExternalEvents(cs8, 0x6F45);
    // IMUL word ptr [BP + 0x6] (1000_6F42 / 0x16F42)
    int resImul1000_6F42 = Alu16.Imul((short)AX, (short)UInt16[SS, (ushort)(BP + 0x6)]);
    AX = (ushort)(resImul1000_6F42);
    DX = (ushort)(resImul1000_6F42 >> 16);
    CheckExternalEvents(cs8, 0x6F47);
    // MOV BX,AX (1000_6F45 / 0x16F45)
    BX = AX;
    CheckExternalEvents(cs8, 0x6F4D);
    // CMP byte ptr ES:[BX + 0xc614],0xff (1000_6F47 / 0x16F47)
    Alu8.Sub(UInt8[ES, (ushort)(BX + 0xC614)], 0xFF);
    CheckExternalEvents(cs8, 0x6F4F);
    // JZ 0x1000:6f33 (1000_6F4D / 0x16F4D)
    if(ZeroFlag) {
      goto label_1000_6F33_16F33;
    }
    CheckExternalEvents(cs8, 0x6F54);
    // INC byte ptr ES:[0xd31a] (1000_6F4F / 0x16F4F)
    UInt8[ES, 0xD31A] = Alu8.Inc(UInt8[ES, 0xD31A]);
    CheckExternalEvents(cs8, 0x6F56);
    // JMP 0x1000:6f33 (1000_6F54 / 0x16F54)
    goto label_1000_6F33_16F33;
  }
  
  public virtual Action split_1000_7BF0_17BF0(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1000_7BF0_17BF0:
    CheckExternalEvents(cs8, 0x7BF1);
    // POP SI (1000_7BF0 / 0x17BF0)
    SI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x7BF2);
    // POP DI (1000_7BF1 / 0x17BF1)
    DI = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x7BF4);
    // MOV SP,BP (1000_7BF2 / 0x17BF2)
    SP = BP;
    CheckExternalEvents(cs8, 0x7BF5);
    // POP BP (1000_7BF4 / 0x17BF4)
    BP = Stack.Pop16();;
    CheckExternalEvents(cs8, 0x7BF6);
    // RETF  (1000_7BF5 / 0x17BF5)
    return FarRet();
  }
  
  public virtual Action unknown_1643_17C6_17BF6(int loadOffset) {
    entrydispatcher:
    if(loadOffset != 0) {
      throw FailAsUntested("External goto not supported for this function.");
    }
    label_1643_17C6_17BF6:
    CheckExternalEvents(cs9, 0x17C8);
    // XOR AX,AX (1643_17C6 / 0x17BF6)
    // AX ^= AX;
    AX = Alu16.Xor(AX, AX);
    CheckExternalEvents(cs9, 0x17CD);
    // CALLF 0x1000:cecc (1643_17C8 / 0x17BF8)
    FarCall(cs9, 0x17CD, unknown_19EF_2FDC_1CECC);
    CheckExternalEvents(cs9, 0x17D0);
    // MOV AX,0x7 (1643_17CD / 0x17BFD)
    AX = 0x7;
    CheckExternalEvents(cs9, 0x17D1);
    // PUSH AX (1643_17D0 / 0x17C00)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x17D6);
    // CALLF 0x1000:7ee1 (1643_17D1 / 0x17C01)
    FarCall(cs9, 0x17D6, unknown_17C6_0281_17EE1);
    CheckExternalEvents(cs9, 0x17D9);
    // ADD SP,0x2 (1643_17D6 / 0x17C06)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0x17DE);
    // CALLF 0x1000:7fe8 (1643_17D9 / 0x17C09)
    FarCall(cs9, 0x17DE, unknown_17C6_0388_17FE8);
    CheckExternalEvents(cs9, 0x17E0);
    // SUB AX,AX (1643_17DE / 0x17C0E)
    // AX -= AX;
    AX = Alu16.Sub(AX, AX);
    CheckExternalEvents(cs9, 0x17E1);
    // PUSH AX (1643_17E0 / 0x17C10)
    Stack.Push16(AX);
    CheckExternalEvents(cs9, 0x17E6);
    // CALLF 0x1000:7c64 (1643_17E1 / 0x17C11)
    FarCall(cs9, 0x17E6, unknown_17C6_0004_17C64);
    CheckExternalEvents(cs9, 0x17E9);
    // ADD SP,0x2 (1643_17E6 / 0x17C16)
    // SP += 0x2;
    SP = Alu16.Add(SP, 0x2);
    CheckExternalEvents(cs9, 0x17EA);
    // RETF  (1643_17E9 / 0x17C19)
    return FarRet();
  }
  
}
