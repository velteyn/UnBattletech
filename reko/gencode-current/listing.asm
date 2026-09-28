017D:0000 push BP
017D:0001 mov BP,SP
017D:0003 mov AX,0x0030
017D:0006 call far 19FC:2FDC
017D:000B mov ES,word ptr DS:[0x5384]
017D:000F mov AX,word ptr SS:[BP+6]
017D:0012 mov word ptr ES:[0x3938],AX
017D:0016 sub AX,AX
017D:0018 mov word ptr SS:[BP-26],AX
017D:001B mov word ptr DS:[0x0152],AX
017D:001E push AX
017D:001F mov AX,0x000F
017D:0022 push AX
017D:0023 push CS
017D:0024 call near 0x48B7
017D:0027 add SP,4
017D:002A jmp near 0x050D
017D:002D mov word ptr SS:[BP-18],0
017D:0032 call far 18BA:002F
017D:0037 or AX,AX
017D:0039 jne short 0x003E
017D:003B jmp near 0x01F4
017D:003E mov word ptr SS:[BP-18],1
017D:0043 call far 18BA:0259
017D:0048 mov word ptr SS:[BP-28],AX
017D:004B push CS
017D:004C call near 0x2A2B
017D:004F push word ptr SS:[BP-28]
017D:0052 call far 17D3:0D1D
017D:0057 add SP,2
017D:005A mov word ptr SS:[BP-28],AX
017D:005D mov AX,4
017D:0060 push AX
017D:0061 call far 17D3:0281
017D:0066 add SP,2
017D:0069 mov word ptr SS:[BP-32],0
017D:006E jmp short 0x009A
017D:0070 cmp word ptr SS:[BP-28],0x0020
017D:0074 je short 0x0080
017D:0076 push word ptr SS:[BP-28]
017D:0079 push CS
017D:007A call near 0x218F
017D:007D add SP,2
017D:0080 push CS
017D:0081 call near 0x051B
017D:0084 mov ES,word ptr DS:[0x5386]
017D:0088 cmp word ptr ES:[0xD55C],0
017D:008E je short 0x0097
017D:0090 mov AX,word ptr DS:[0x015A]
017D:0093 inc AX
017D:0094 mov word ptr SS:[BP-32],AX
017D:0097 inc word ptr SS:[BP-32]
017D:009A mov AX,word ptr DS:[0x015A]
017D:009D cmp word ptr SS:[BP-32],AX
017D:00A0 jl short 0x0070
017D:00A2 mov ES,word ptr DS:[0x5386]
017D:00A6 cmp word ptr ES:[0xD55C],0
017D:00AC jne short 0x00EC
017D:00AE mov word ptr SS:[BP-22],0
017D:00B3 mov BX,word ptr SS:[BP-22]
017D:00B6 shl BX,1
017D:00B8 mov AX,word ptr SS:[BP-28]
017D:00BB cmp word ptr DS:[BX+0x0160],AX
017D:00BF jne short 0x00E3
017D:00C1 mov ES,word ptr DS:[0x5388]
017D:00C5 mov word ptr ES:[0x37FE],0x000F
017D:00CC mov BX,word ptr SS:[BP-22]
017D:00CF shl BX,1
017D:00D1 shl BX,1
017D:00D3 push word ptr DS:[BX+0x01AC]
017D:00D7 push word ptr DS:[BX+0x01AA]
017D:00DB call far 17D3:03F5
017D:00E3 inc word ptr SS:[BP-22]
017D:00E6 cmp word ptr SS:[BP-22],8
017D:00EA jl short 0x00B3
017D:00EC mov ES,word ptr DS:[0x5386]
017D:00F0 mov word ptr ES:[0xD55C],0
017D:00F7 push word ptr SS:[BP-28]
017D:00FA push CS
017D:00FB call near 0x231D
017D:00FE add SP,2
017D:0101 cmp word ptr SS:[BP-28],0x0020
017D:0105 jne short 0x010B
017D:0107 push CS
017D:0108 call near 0x2C50
017D:010B mov ES,word ptr DS:[0x538A]
017D:010F cmp byte ptr ES:[0xD33D],0
017D:0115 je short 0x0122
017D:0117 cmp byte ptr ES:[0xD346],0
017D:011D jne short 0x0122
017D:011F jmp near 0x01B1
017D:0122 mov ES,word ptr DS:[0x538C]
017D:0126 mov AX,word ptr ES:[0xA44B]
017D:012A and AX,0x0070
017D:012D mov CL,4
017D:012F shr AX,CL
017D:0131 mov word ptr SS:[BP-44],AX
017D:0134 mov BX,AX
017D:0136 mov AL,byte ptr DS:[BX+0x029A]
017D:013A cbw
017D:013B mov word ptr SS:[BP-44],AX
017D:013E mov ES,word ptr DS:[0x538E]
017D:0142 mov AX,word ptr ES:[0xA44D]
017D:0146 and AX,0xF000
017D:0149 mov CL,5
017D:014B shr AX,CL
017D:014D mov CX,word ptr ES:[0xA44D]
017D:0152 and CX,0x0070
017D:0155 or AX,CX
017D:0157 mov word ptr SS:[BP-48],AX
017D:015A mov ES,word ptr DS:[0x538C]
017D:015E mov AX,word ptr ES:[0xA44B]
017D:0162 mov CL,8
017D:0164 shr AX,CL
017D:0166 add word ptr SS:[BP-48],AX
017D:0169 mov AL,byte ptr SS:[BP-44]
017D:016C mov BX,word ptr SS:[BP-48]
017D:016F mov ES,word ptr DS:[0x538A]
017D:0173 or byte ptr ES:[BX-13556],AL
017D:0178 mov ES,word ptr DS:[0x538E]
017D:017C cmp word ptr ES:[0xA44D],0
017D:0182 je short 0x0193
017D:0184 mov AL,byte ptr SS:[BP-44]
017D:0187 mov BX,word ptr SS:[BP-48]
017D:018A mov ES,word ptr DS:[0x538A]
017D:018E or byte ptr ES:[BX-13572],AL
017D:0193 mov ES,word ptr DS:[0x538E]
017D:0197 cmp word ptr ES:[0xA44D],0xF07F
017D:019E jae short 0x020A
017D:01A0 mov AL,byte ptr SS:[BP-44]
017D:01A3 mov BX,word ptr SS:[BP-48]
017D:01A6 mov ES,word ptr DS:[0x538A]
017D:01AA or byte ptr ES:[BX-13540],AL
017D:01AF jmp short 0x020A
017D:01B1 mov ES,word ptr DS:[0x538E]
017D:01B5 mov AX,word ptr ES:[0xA44D]
017D:01B9 and AX,0xF000
017D:01BC mov CL,5
017D:01BE shr AX,CL
017D:01C0 mov word ptr SS:[BP-48],AX
017D:01C3 mov ES,word ptr DS:[0x538C]
017D:01C7 mov AX,word ptr ES:[0xA44B]
017D:01CB mov CL,8
017D:01CD shr AX,CL
017D:01CF add word ptr SS:[BP-48],AX
017D:01D2 mov word ptr SS:[BP-44],0
017D:01D7 mov BX,word ptr SS:[BP-48]
017D:01DA add BX,word ptr SS:[BP-44]
017D:01DD mov ES,word ptr DS:[0x538A]
017D:01E1 mov byte ptr ES:[BX-13556],0xFF
017D:01E7 add word ptr SS:[BP-44],0x0010
017D:01EB cmp word ptr SS:[BP-44],0x0080
017D:01F0 jl short 0x01D7
017D:01F2 jmp short 0x020A
017D:01F4 mov AX,1
017D:01F7 push AX
017D:01F8 call far 18BA:0006
017D:01FD add SP,2
017D:0200 dec word ptr SS:[BP-26]
017D:0203 jns short 0x020A
017D:0205 mov word ptr SS:[BP-18],1
017D:020A cmp word ptr SS:[BP-18],0
017D:020E jne short 0x0213
017D:0210 jmp near 0x050D
017D:0213 mov ES,word ptr DS:[0x538A]
017D:0217 cmp byte ptr ES:[0xD335],0
017D:021D je short 0x0224
017D:021F dec byte ptr ES:[0xD335]
017D:0224 cmp byte ptr ES:[0xD343],0
017D:022A je short 0x0287
017D:022C mov AL,byte ptr ES:[0xD344]
017D:0230 dec byte ptr ES:[0xD344]
017D:0235 or AL,AL
017D:0237 jne short 0x023E
017D:0239 dec byte ptr ES:[0xD345]
017D:023E mov AL,byte ptr ES:[0xD344]
017D:0242 or AL,byte ptr ES:[0xD345]
017D:0247 mov byte ptr ES:[0xD343],AL
017D:024B or AL,AL
017D:024D jne short 0x0287
017D:024F mov ES,word ptr DS:[0x538C]
017D:0253 cmp word ptr ES:[0xA44B],0x0800
017D:025A jb short 0x0287
017D:025C cmp word ptr ES:[0xA44B],0x0D00
017D:0263 jae short 0x0287
017D:0265 mov ES,word ptr DS:[0x538E]
017D:0269 cmp word ptr ES:[0xA44D],0x6000
017D:0270 jb short 0x0287
017D:0272 cmp word ptr ES:[0xA44D],0xB000
017D:0279 jae short 0x0287
017D:027B mov AX,1
017D:027E push AX
017D:027F call far 0EC0:0C72
017D:0287 call far 19FC:0BC0
017D:028C mov ES,word ptr DS:[0x538A]
017D:0290 mov CX,AX
017D:0292 mov AL,byte ptr ES:[0xD330]
017D:0296 cbw
017D:0297 and CX,AX
017D:0299 jne short 0x02B6
017D:029B cmp byte ptr ES:[0xD310],0
017D:02A1 je short 0x02B6
017D:02A3 cmp byte ptr ES:[0xD346],0
017D:02A9 jne short 0x02B6
017D:02AB sub AX,AX
017D:02AD push AX
017D:02AE call far 11B8:000A
017D:02B3 add SP,2
017D:02B6 mov ES,word ptr DS:[0x538A]
017D:02BA cmp byte ptr ES:[0xD329],0
017D:02C0 je short 0x02C7
017D:02C2 dec byte ptr ES:[0xD329]
017D:02C7 cmp byte ptr ES:[0xD320],0
017D:02CD je short 0x02D4
017D:02CF dec byte ptr ES:[0xD320]
017D:02D4 cmp byte ptr ES:[0xD321],0
017D:02DA je short 0x02E1
017D:02DC dec byte ptr ES:[0xD321]
017D:02E1 cmp byte ptr ES:[0xD322],0
017D:02E7 je short 0x02EE
017D:02E9 dec byte ptr ES:[0xD322]
017D:02EE mov AL,byte ptr ES:[0xD323]
017D:02F2 dec byte ptr ES:[0xD323]
017D:02F7 or AL,AL
017D:02F9 je short 0x02FE
017D:02FB jmp near 0x044A
017D:02FE mov AX,word ptr ES:[0xD374]
017D:0302 mov DX,word ptr ES:[0xD376]
017D:0307 add AX,word ptr ES:[0xD378]
017D:030C adc DX,word ptr ES:[0xD37A]
017D:0311 add AX,word ptr ES:[0xD37C]
017D:0316 adc DX,word ptr ES:[0xD37E]
017D:031B add AX,word ptr ES:[0xD370]
017D:0320 adc DX,word ptr ES:[0xD372]
017D:0325 mov word ptr SS:[BP-42],AX
017D:0328 mov word ptr SS:[BP-40],DX
017D:032B cmp byte ptr ES:[0xD310],0
017D:0331 jne short 0x0358
017D:0333 push CS
017D:0334 call near 0x29F5
017D:0337 cmp DX,word ptr SS:[BP-40]
017D:033A jl short 0x0353
017D:033C jg short 0x0343
017D:033E cmp AX,word ptr SS:[BP-42]
017D:0341 jbe short 0x0353
017D:0343 mov ES,word ptr DS:[0x538A]
017D:0347 add word ptr ES:[0xD370],0x000F
017D:034D adc word ptr ES:[0xD372],0
017D:0353 call far 0FAE:1FDF
017D:0358 mov ES,word ptr DS:[0x538A]
017D:035C cmp byte ptr ES:[0xD310],0
017D:0362 jne short 0x037A
017D:0364 push CS
017D:0365 call near 0x29F5
017D:0368 cmp DX,word ptr SS:[BP-40]
017D:036B jge short 0x0370
017D:036D jmp near 0x044A
017D:0370 jg short 0x037A
017D:0372 cmp AX,word ptr SS:[BP-42]
017D:0375 ja short 0x037A
017D:0377 jmp near 0x044A
017D:037A mov word ptr SS:[BP-26],0
017D:037F jmp short 0x03C0
017D:0381 mov BX,word ptr SS:[BP-26]
017D:0384 shl BX,1
017D:0386 mov AX,word ptr DS:[BX+0x02A8]
017D:038A cwd
017D:038B push DX
017D:038C push AX
017D:038D mov BX,word ptr SS:[BP-26]
017D:0390 shl BX,1
017D:0392 shl BX,1
017D:0394 lea AX,BX-11404
017D:0398 mov DX,0x2A0F
017D:039B push DX
017D:039C push AX
017D:039D call far 19FC:3D1C
017D:03A2 mov AX,0x006E
017D:03A5 cwd
017D:03A6 push DX
017D:03A7 push AX
017D:03A8 mov BX,word ptr SS:[BP-26]
017D:03AB shl BX,1
017D:03AD shl BX,1
017D:03AF lea AX,BX-11404
017D:03B3 mov DX,0x2A0F
017D:03B6 push DX
017D:03B7 push AX
017D:03B8 call far 19FC:3D44
017D:03BD inc word ptr SS:[BP-26]
017D:03C0 cmp word ptr SS:[BP-26],3
017D:03C4 jl short 0x03C9
017D:03C6 jmp near 0x044A
017D:03C9 call far 19FC:0BC0
017D:03CE mov BX,word ptr SS:[BP-26]
017D:03D1 shl BX,1
017D:03D3 mov CX,word ptr DS:[BX+0x02A2]
017D:03D7 and CX,AX
017D:03D9 mov word ptr SS:[BP-24],CX
017D:03DC or CX,CX
017D:03DE je short 0x0381
017D:03E0 mov AX,0x0064
017D:03E3 cwd
017D:03E4 push DX
017D:03E5 push AX
017D:03E6 mov BX,word ptr SS:[BP-26]
017D:03E9 shl BX,1
017D:03EB shl BX,1
017D:03ED lea AX,BX-11404
017D:03F1 mov DX,0x2A0F
017D:03F4 push DX
017D:03F5 push AX
017D:03F6 call far 19FC:3D1C
017D:03FB mov BX,word ptr SS:[BP-26]
017D:03FE shl BX,1
017D:0400 mov AX,word ptr DS:[BX+0x02A8]
017D:0404 cwd
017D:0405 push DX
017D:0406 push AX
017D:0407 mov BX,word ptr SS:[BP-26]
017D:040A shl BX,1
017D:040C shl BX,1
017D:040E lea AX,BX-11404
017D:0412 mov DX,0x2A0F
017D:0415 push DX
017D:0416 push AX
017D:0417 call far 19FC:3D44
017D:041C cmp word ptr SS:[BP-26],2
017D:0420 jne short 0x03BD
017D:0422 mov ES,word ptr DS:[0x538A]
017D:0426 cmp word ptr ES:[0xD37E],0
017D:042C jne short 0x0437
017D:042E cmp word ptr ES:[0xD37C],0x4650
017D:0435 jbe short 0x03BD
017D:0437 mov AL,2
017D:0439 push AX
017D:043A mov AX,0xD37C
017D:043D mov DX,0x2A0F
017D:0440 push DX
017D:0441 push AX
017D:0442 call far 19FC:3D6C
017D:044A mov word ptr SS:[BP-26],0x000A
017D:044F push CS
017D:0450 call near 0x240B
017D:0453 mov AL,byte ptr DS:[0x57FE]
017D:0456 inc byte ptr DS:[0x57FE]
017D:045A cmp AL,2
017D:045C jne short 0x0467
017D:045E push CS
017D:045F call near 0x24C2
017D:0462 mov byte ptr DS:[0x57FE],0
017D:0467 cmp word ptr DS:[0x014A],0
017D:046C je short 0x0496
017D:046E mov ES,word ptr DS:[0x538E]
017D:0472 push word ptr ES:[0xA44D]
017D:0477 mov ES,word ptr DS:[0x538C]
017D:047B push word ptr ES:[0xA44B]
017D:0480 call far 19FC:1314
017D:0485 add SP,4
017D:0488 call far 19FC:18EF
017D:048D push CS
017D:048E call near 0x051B
017D:0491 call far 18BA:06C3
017D:0496 cmp word ptr DS:[0x014A],0
017D:049B je short 0x04A4
017D:049D cmp word ptr DS:[0x01A8],0
017D:04A2 je short 0x050D
017D:04A4 call far 1650:17C6
017D:050D cmp word ptr DS:[0x0152],0
017D:0512 jne short 0x0517
017D:0514 jmp near 0x002D
017D:0517 mov SP,BP
017D:0519 pop BP
017D:051A ret far
017D:051B push BP
017D:051C mov BP,SP
017D:051E mov AX,0x0032
017D:0521 call far 19FC:2FDC
017D:0526 push SI
017D:0527 mov ES,word ptr DS:[0x538A]
017D:052B cmp byte ptr ES:[0xD346],0
017D:0531 jne short 0x0537
017D:0533 push CS
017D:0534 call near 0x2A93
017D:0537 mov ES,word ptr DS:[0x5390]
017D:053B sub AX,AX
017D:053D mov word ptr ES:[0x006A],AX
017D:0541 mov word ptr SS:[BP-18],AX
017D:0544 mov word ptr SS:[BP-14],AX
017D:0547 mov word ptr SS:[BP-32],AX
017D:054A mov BX,word ptr SS:[BP-32]
017D:054D shl BX,1
017D:054F mov ES,word ptr DS:[0x5392]
017D:0553 mov word ptr ES:[BX+0x406A],0
017D:055A inc word ptr SS:[BP-32]
017D:055D cmp word ptr SS:[BP-32],0x000C
017D:0561 jl short 0x054A
017D:0563 mov word ptr SS:[BP-32],0
017D:0568 jmp short 0x05A1
017D:056A push word ptr SS:[BP-30]
017D:056D push word ptr SS:[BP-24]
017D:0570 push word ptr SS:[BP-2]
017D:0573 push word ptr SS:[BP-4]
017D:0576 sub AX,AX
017D:0578 mov DX,0xAC00
017D:057B push DX
017D:057C push AX
017D:057D call far 19FC:0377
017D:0585 mov ES,word ptr DS:[0x53A0]
017D:0589 cmp word ptr ES:[0x4FBA],0
017D:058F je short 0x059B
017D:0591 les BX,word ptr SS:[BP-4]
017D:0594 mov AL,byte ptr SS:[BP-22]
017D:0597 add byte ptr ES:[BX+1],AL
017D:059B inc word ptr SS:[BP-14]
017D:059E inc word ptr SS:[BP-32]
017D:05A1 cmp word ptr SS:[BP-32],8
017D:05A5 jl short 0x05AA
017D:05A7 jmp near 0x074E
017D:05AA mov AX,0x0011
017D:05AD imul word ptr SS:[BP-32]
017D:05B0 mov SI,AX
017D:05B2 mov ES,word ptr DS:[0x538A]
017D:05B6 cmp byte ptr ES:[SI-14828],0xFF
017D:05BC je short 0x059E
017D:05BE cmp byte ptr ES:[SI-14816],8
017D:05C4 jl short 0x059E
017D:05C6 mov ES,word ptr DS:[0x5390]
017D:05CA inc word ptr ES:[0x006A]
017D:05CF mov SI,word ptr SS:[BP-14]
017D:05D2 shl SI,1
017D:05D4 mov AX,word ptr DS:[SI+0x02AE]
017D:05D8 mov word ptr SS:[BP-24],AX
017D:05DB mov AX,word ptr DS:[SI+0x02BE]
017D:05DF mov word ptr SS:[BP-30],AX
017D:05E2 mov AX,word ptr DS:[SI+0x02FE]
017D:05E6 mov ES,word ptr DS:[0x5394]
017D:05EA add AX,word ptr ES:[0x09ED]
017D:05EF mov word ptr SS:[BP-44],AX
017D:05F2 mov ES,word ptr DS:[0x538C]
017D:05F6 test byte ptr ES:[0xA44B],1
017D:05FC je short 0x0605
017D:05FE mov AX,word ptr DS:[SI+0x030E]
017D:0602 add word ptr SS:[BP-44],AX
017D:0605 mov ES,word ptr DS:[0x538E]
017D:0609 test byte ptr ES:[0xA44D],1
017D:060F je short 0x061D
017D:0611 mov BX,word ptr SS:[BP-14]
017D:0614 shl BX,1
017D:0616 mov AX,word ptr DS:[BX+0x031E]
017D:061A add word ptr SS:[BP-44],AX
017D:061D mov SI,word ptr ES:[0xA44D]
017D:0622 and SI,1
017D:0625 shl SI,1
017D:0627 mov ES,word ptr DS:[0x538C]
017D:062B mov AX,word ptr ES:[0xA44B]
017D:062F and AX,1
017D:0632 add SI,AX
017D:0634 shl SI,1
017D:0636 mov BX,word ptr SS:[BP-14]
017D:0639 mov CL,3
017D:063B shl BX,CL
017D:063D mov AX,word ptr DS:[BX+SI+0x0332]
017D:0641 mov word ptr SS:[BP-50],AX
017D:0644 mov BX,word ptr SS:[BP-44]
017D:0647 mov ES,word ptr DS:[0x5396]
017D:064B mov AL,byte ptr ES:[BX+0x07AD]
017D:0650 sub AH,AH
017D:0652 mov word ptr SS:[BP-40],AX
017D:0655 mov word ptr SS:[BP-22],0
017D:065A mov ES,word ptr DS:[0x538A]
017D:065E cmp byte ptr ES:[0xD346],AH
017D:0663 jne short 0x068F
017D:0665 cmp AX,0x00F6
017D:0668 jge short 0x068F
017D:066A mov AX,word ptr SS:[BP-50]
017D:066D and word ptr SS:[BP-40],AX
017D:0670 je short 0x068F
017D:0672 mov AX,word ptr SS:[BP-40]
017D:0675 and AX,0x00F0
017D:0678 mov word ptr SS:[BP-10],AX
017D:067B cmp AX,0x0030
017D:067E jge short 0x068F
017D:0680 mov word ptr SS:[BP-22],2
017D:0685 cmp AX,0x0020
017D:0688 jne short 0x068F
017D:068A mov word ptr SS:[BP-22],4
017D:068F mov AL,byte ptr SS:[BP-22]
017D:0692 mov BX,word ptr SS:[BP-32]
017D:0695 mov ES,word ptr DS:[0x5398]
017D:0699 mov byte ptr ES:[BX+0x32B2],AL
017D:069E mov BX,word ptr SS:[BP-32]
017D:06A1 mov ES,word ptr DS:[0x539A]
017D:06A5 mov BL,byte ptr ES:[BX+0x409E]
017D:06AA sub BH,BH
017D:06AC mov SI,word ptr SS:[BP-32]
017D:06AF mov ES,word ptr DS:[0x539C]
017D:06B3 mov AL,byte ptr ES:[SI-10910]
017D:06B8 sub AH,AH
017D:06BA add BX,AX
017D:06BC shl BX,1
017D:06BE shl BX,1
017D:06C0 mov ES,word ptr DS:[0x539E]
017D:06C4 mov AX,word ptr ES:[BX+0x39FA]
017D:06C9 mov DX,word ptr ES:[BX+0x39FC]
017D:06CE mov word ptr SS:[BP-4],AX
017D:06D1 mov word ptr SS:[BP-2],DX
017D:06D4 mov ES,word ptr DS:[0x53A0]
017D:06D8 cmp word ptr ES:[0x4FBA],0
017D:06DE je short 0x06EA
017D:06E0 les BX,word ptr SS:[BP-4]
017D:06E3 mov AL,byte ptr SS:[BP-22]
017D:06E6 sub byte ptr ES:[BX+1],AL
017D:06EA mov ES,word ptr DS:[0x53A0]
017D:06EE cmp word ptr ES:[0x4FBA],2
017D:06F4 jne short 0x06F9
017D:06F6 jmp near 0x056A
017D:06F9 cmp word ptr ES:[0x4FBA],0
017D:06FF jne short 0x0724
017D:0701 cmp word ptr SS:[BP-22],0
017D:0705 je short 0x0724
017D:0707 mov ES,word ptr DS:[0x53A2]
017D:070B mov AX,word ptr SS:[BP-30]
017D:070E sub AX,word ptr SS:[BP-22]
017D:0711 add AX,8
017D:0714 mov word ptr ES:[0xB780],AX
017D:0718 cmp AX,0x00C8
017D:071B jle short 0x0724
017D:071D mov word ptr ES:[0xB780],0x00C8
017D:0724 push word ptr SS:[BP-30]
017D:0727 push word ptr SS:[BP-24]
017D:072A push word ptr SS:[BP-2]
017D:072D push word ptr SS:[BP-4]
017D:0730 mov AX,0x244B
017D:0733 mov DX,0x1DE9
017D:0736 push DX
017D:0737 push AX
017D:0738 call far 19FC:28EB
017D:073D add SP,0x000C
017D:0740 mov ES,word ptr DS:[0x53A2]
017D:0744 mov word ptr ES:[0xB780],0x00C8
017D:074B jmp near 0x0585
017D:074E mov ES,word ptr DS:[0x538C]
017D:0752 mov AX,word ptr ES:[0xA44B]
017D:0756 mov word ptr SS:[BP-8],AX
017D:0759 mov ES,word ptr DS:[0x538E]
017D:075D mov AX,word ptr ES:[0xA44D]
017D:0761 mov word ptr SS:[BP-12],AX
017D:0764 mov word ptr SS:[BP-32],0x0010
017D:0769 jmp short 0x079F
017D:076B push word ptr SS:[BP-30]
017D:076E push word ptr SS:[BP-24]
017D:0771 push word ptr SS:[BP-2]
017D:0774 push word ptr SS:[BP-4]
017D:0777 sub AX,AX
017D:0779 mov DX,0xAC00
017D:077C push DX
017D:077D push AX
017D:077E call far 19FC:0377
017D:0786 mov ES,word ptr DS:[0x53A0]
017D:078A cmp word ptr ES:[0x4FBA],0
017D:0790 je short 0x079C
017D:0792 les BX,word ptr SS:[BP-4]
017D:0795 mov AL,byte ptr SS:[BP-22]
017D:0798 add byte ptr ES:[BX+1],AL
017D:079C inc word ptr SS:[BP-32]
017D:079F cmp word ptr SS:[BP-32],0x0018
017D:07A3 jl short 0x07A8
017D:07A5 jmp near 0x09FE
017D:07A8 mov AX,0x001A
017D:07AB imul word ptr SS:[BP-32]
017D:07AE mov BX,AX
017D:07B0 mov ES,word ptr DS:[0x538A]
017D:07B4 cmp byte ptr ES:[BX-11783],0
017D:07BA jne short 0x079C
017D:07BC mov SI,word ptr SS:[BP-32]
017D:07BF shl SI,1
017D:07C1 mov ES,word ptr DS:[0x53A4]
017D:07C5 mov AX,word ptr ES:[SI+0x4004]
017D:07CA mov word ptr SS:[BP-24],AX
017D:07CD mov ES,word ptr DS:[0x53A6]
017D:07D1 mov AX,word ptr ES:[SI+0x4036]
017D:07D6 mov word ptr SS:[BP-30],AX
017D:07D9 sub AX,AX
017D:07DB mov word ptr SS:[BP-38],AX
017D:07DE mov word ptr SS:[BP-34],AX
017D:07E1 mov AX,word ptr SS:[BP-24]
017D:07E4 sub AX,word ptr SS:[BP-8]
017D:07E7 add AX,0x001A
017D:07EA mov word ptr SS:[BP-24],AX
017D:07ED mov AX,word ptr SS:[BP-30]
017D:07F0 sub AX,word ptr SS:[BP-12]
017D:07F3 add AX,0x000C
017D:07F6 mov word ptr SS:[BP-30],AX
017D:07F9 mov ES,word ptr DS:[0x53A4]
017D:07FD mov AX,word ptr ES:[SI+0x4004]
017D:0802 sub AL,AL
017D:0804 mov CX,word ptr SS:[BP-8]
017D:0807 sub CL,CL
017D:0809 cmp AX,CX
017D:080B jne short 0x081E
017D:080D cmp word ptr SS:[BP-24],0x000D
017D:0811 jl short 0x0819
017D:0813 cmp word ptr SS:[BP-24],0x0027
017D:0817 jle short 0x081E
017D:0819 mov word ptr SS:[BP-34],1
017D:081E mov BX,word ptr SS:[BP-32]
017D:0821 shl BX,1
017D:0823 mov ES,word ptr DS:[0x53A6]
017D:0827 mov AX,word ptr ES:[BX+0x4036]
017D:082C sub AL,AL
017D:082E mov CX,word ptr SS:[BP-12]
017D:0831 sub CL,CL
017D:0833 cmp AX,CX
017D:0835 jne short 0x0848
017D:0837 cmp word ptr SS:[BP-30],0
017D:083B jl short 0x0843
017D:083D cmp word ptr SS:[BP-30],0x0018
017D:0841 jle short 0x0848
017D:0843 mov word ptr SS:[BP-38],1
017D:0848 cmp word ptr SS:[BP-24],-115
017D:084C jge short 0x0851
017D:084E jmp near 0x079C
017D:0851 cmp word ptr SS:[BP-24],0x00A7
017D:0856 jle short 0x085B
017D:0858 jmp near 0x079C
017D:085B cmp word ptr SS:[BP-30],0xF080
017D:0860 jge short 0x0865
017D:0862 jmp near 0x079C
017D:0865 cmp word ptr SS:[BP-30],0x0F98
017D:086A jle short 0x086F
017D:086C jmp near 0x079C
017D:086F mov AX,word ptr SS:[BP-34]
017D:0872 add AX,word ptr SS:[BP-38]
017D:0875 je short 0x087A
017D:0877 jmp near 0x079C
017D:087A and word ptr SS:[BP-24],0x007F
017D:087E and word ptr SS:[BP-30],0x007F
017D:0882 mov AX,word ptr SS:[BP-24]
017D:0885 sub AX,0x000D
017D:0888 mov word ptr SS:[BP-42],AX
017D:088B mov AX,word ptr SS:[BP-30]
017D:088E sar AX,1
017D:0890 mov CX,0x0018
017D:0893 imul CX
017D:0895 mov CX,word ptr SS:[BP-42]
017D:0898 sar CX,1
017D:089A add AX,CX
017D:089C mov ES,word ptr DS:[0x5394]
017D:08A0 add AX,word ptr ES:[0x09ED]
017D:08A5 mov word ptr SS:[BP-20],AX
017D:08A8 test byte ptr SS:[BP-42],1
017D:08AC je short 0x08BD
017D:08AE mov ES,word ptr DS:[0x538C]
017D:08B2 test byte ptr ES:[0xA44B],1
017D:08B8 je short 0x08BD
017D:08BA inc word ptr SS:[BP-20]
017D:08BD test byte ptr SS:[BP-30],1
017D:08C1 je short 0x08D3
017D:08C3 mov ES,word ptr DS:[0x538E]
017D:08C7 test byte ptr ES:[0xA44D],1
017D:08CD je short 0x08D3
017D:08CF add word ptr SS:[BP-20],0x0018
017D:08D3 mov SI,word ptr SS:[BP-30]
017D:08D6 mov ES,word ptr DS:[0x538E]
017D:08DA xor SI,word ptr ES:[0xA44D]
017D:08DF and SI,1
017D:08E2 shl SI,1
017D:08E4 mov BX,word ptr SS:[BP-42]
017D:08E7 mov ES,word ptr DS:[0x538C]
017D:08EB xor BX,word ptr ES:[0xA44B]
017D:08F0 and BX,1
017D:08F3 mov AL,byte ptr DS:[BX+SI+0x032E]
017D:08F7 cbw
017D:08F8 mov word ptr SS:[BP-50],AX
017D:08FB mov BX,word ptr SS:[BP-20]
017D:08FE mov ES,word ptr DS:[0x5396]
017D:0902 mov AL,byte ptr ES:[BX+0x07AD]
017D:0907 sub AH,AH
017D:0909 mov word ptr SS:[BP-26],AX
017D:090C mov word ptr SS:[BP-22],0
017D:0911 mov ES,word ptr DS:[0x538A]
017D:0915 cmp byte ptr ES:[0xD346],AH
017D:091A jne short 0x0946
017D:091C cmp AX,0x00F6
017D:091F jge short 0x0946
017D:0921 mov AX,word ptr SS:[BP-50]
017D:0924 and word ptr SS:[BP-26],AX
017D:0927 je short 0x0946
017D:0929 mov AX,word ptr SS:[BP-26]
017D:092C and AX,0x00F0
017D:092F mov word ptr SS:[BP-10],AX
017D:0932 cmp AX,0x0030
017D:0935 jge short 0x0946
017D:0937 mov word ptr SS:[BP-22],2
017D:093C cmp AX,0x0020
017D:093F jne short 0x0946
017D:0941 mov word ptr SS:[BP-22],4
017D:0946 mov CL,3
017D:0948 shl word ptr SS:[BP-24],CL
017D:094B shl word ptr SS:[BP-30],CL
017D:094E mov BX,word ptr SS:[BP-32]
017D:0951 mov ES,word ptr DS:[0x539A]
017D:0955 mov BL,byte ptr ES:[BX+0x409A]
017D:095A sub BH,BH
017D:095C mov SI,word ptr SS:[BP-32]
017D:095F mov ES,word ptr DS:[0x539C]
017D:0963 mov AL,byte ptr ES:[SI-10914]
017D:0968 sub AH,AH
017D:096A add BX,AX
017D:096C shl BX,1
017D:096E shl BX,1
017D:0970 mov ES,word ptr DS:[0x539E]
017D:0974 mov AX,word ptr ES:[BX+0x39FA]
017D:0979 mov DX,word ptr ES:[BX+0x39FC]
017D:097E mov word ptr SS:[BP-4],AX
017D:0981 mov word ptr SS:[BP-2],DX
017D:0984 mov ES,word ptr DS:[0x53A0]
017D:0988 cmp word ptr ES:[0x4FBA],0
017D:098E je short 0x099A
017D:0990 les BX,word ptr SS:[BP-4]
017D:0993 mov AL,byte ptr SS:[BP-22]
017D:0996 sub byte ptr ES:[BX+1],AL
017D:099A mov ES,word ptr DS:[0x53A0]
017D:099E cmp word ptr ES:[0x4FBA],2
017D:09A4 jne short 0x09A9
017D:09A6 jmp near 0x076B
017D:09A9 cmp word ptr ES:[0x4FBA],0
017D:09AF jne short 0x09D4
017D:09B1 cmp word ptr SS:[BP-22],0
017D:09B5 je short 0x09D4
017D:09B7 mov ES,word ptr DS:[0x53A2]
017D:09BB mov AX,word ptr SS:[BP-30]
017D:09BE sub AX,word ptr SS:[BP-22]
017D:09C1 add AX,8
017D:09C4 mov word ptr ES:[0xB780],AX
017D:09C8 cmp AX,0x00C8
017D:09CB jle short 0x09D4
017D:09CD mov word ptr ES:[0xB780],0x00C8
017D:09D4 push word ptr SS:[BP-30]
017D:09D7 push word ptr SS:[BP-24]
017D:09DA push word ptr SS:[BP-2]
017D:09DD push word ptr SS:[BP-4]
017D:09E0 mov AX,0x244B
017D:09E3 mov DX,0x1DE9
017D:09E6 push DX
017D:09E7 push AX
017D:09E8 call far 19FC:28EB
017D:09ED add SP,0x000C
017D:09F0 mov ES,word ptr DS:[0x53A2]
017D:09F4 mov word ptr ES:[0xB780],0x00C8
017D:09FB jmp near 0x0786
017D:09FE mov word ptr SS:[BP-32],0
017D:0A03 jmp short 0x0A39
017D:0A05 push word ptr SS:[BP-30]
017D:0A08 push word ptr SS:[BP-24]
017D:0A0B push word ptr SS:[BP-2]
017D:0A0E push word ptr SS:[BP-4]
017D:0A11 sub AX,AX
017D:0A13 mov DX,0xAC00
017D:0A16 push DX
017D:0A17 push AX
017D:0A18 call far 19FC:0377
017D:0A20 mov ES,word ptr DS:[0x53A0]
017D:0A24 cmp word ptr ES:[0x4FBA],0
017D:0A2A je short 0x0A36
017D:0A2C les BX,word ptr SS:[BP-4]
017D:0A2F mov AL,byte ptr SS:[BP-22]
017D:0A32 add byte ptr ES:[BX+1],AL
017D:0A36 inc word ptr SS:[BP-32]
017D:0A39 cmp word ptr SS:[BP-32],4
017D:0A3D jl short 0x0A42
017D:0A3F jmp near 0x0BC9
017D:0A42 mov AX,0x007D
017D:0A45 imul word ptr SS:[BP-32]
017D:0A48 mov BX,AX
017D:0A4A mov ES,word ptr DS:[0x538A]
017D:0A4E cmp byte ptr ES:[BX-14556],0xFF
017D:0A54 je short 0x0A36
017D:0A56 mov SI,word ptr SS:[BP-18]
017D:0A59 shl SI,1
017D:0A5B mov AX,word ptr DS:[SI+0x02CE]
017D:0A5F mov word ptr SS:[BP-24],AX
017D:0A62 mov AX,word ptr DS:[SI+0x02D6]
017D:0A66 mov word ptr SS:[BP-30],AX
017D:0A69 mov AX,word ptr DS:[SI+0x02DE]
017D:0A6D mov ES,word ptr DS:[0x5394]
017D:0A71 add AX,word ptr ES:[0x09ED]
017D:0A76 mov word ptr SS:[BP-44],AX
017D:0A79 mov ES,word ptr DS:[0x538C]
017D:0A7D test byte ptr ES:[0xA44B],1
017D:0A83 je short 0x0A8C
017D:0A85 mov AX,word ptr DS:[SI+0x02EE]
017D:0A89 add word ptr SS:[BP-44],AX
017D:0A8C mov SI,word ptr SS:[BP-18]
017D:0A8F shl SI,1
017D:0A91 mov AX,word ptr DS:[SI+0x02E6]
017D:0A95 mov word ptr SS:[BP-50],AX
017D:0A98 mov ES,word ptr DS:[0x538E]
017D:0A9C test byte ptr ES:[0xA44D],1
017D:0AA2 je short 0x0AAF
017D:0AA4 mov AX,word ptr DS:[SI+0x02F6]
017D:0AA8 add word ptr SS:[BP-44],AX
017D:0AAB xor byte ptr SS:[BP-50],5
017D:0AAF inc word ptr SS:[BP-18]
017D:0AB2 mov BX,word ptr SS:[BP-32]
017D:0AB5 mov ES,word ptr DS:[0x539A]
017D:0AB9 mov BL,byte ptr ES:[BX+0x409A]
017D:0ABE sub BH,BH
017D:0AC0 mov SI,word ptr SS:[BP-32]
017D:0AC3 mov ES,word ptr DS:[0x539C]
017D:0AC7 mov AL,byte ptr ES:[SI-10914]
017D:0ACC sub AH,AH
017D:0ACE add BX,AX
017D:0AD0 shl BX,1
017D:0AD2 shl BX,1
017D:0AD4 mov ES,word ptr DS:[0x539E]
017D:0AD8 mov AX,word ptr ES:[BX+0x39FA]
017D:0ADD mov DX,word ptr ES:[BX+0x39FC]
017D:0AE2 mov word ptr SS:[BP-4],AX
017D:0AE5 mov word ptr SS:[BP-2],DX
017D:0AE8 mov word ptr SS:[BP-22],0
017D:0AED mov BX,word ptr SS:[BP-44]
017D:0AF0 mov ES,word ptr DS:[0x5396]
017D:0AF4 mov AL,byte ptr ES:[BX+0x07AD]
017D:0AF9 sub AH,AH
017D:0AFB mov word ptr SS:[BP-40],AX
017D:0AFE mov ES,word ptr DS:[0x538A]
017D:0B02 cmp byte ptr ES:[0xD346],AH
017D:0B07 jne short 0x0B40
017D:0B09 cmp AX,0x00F6
017D:0B0C jge short 0x0B40
017D:0B0E mov AX,word ptr SS:[BP-50]
017D:0B11 and word ptr SS:[BP-40],AX
017D:0B14 je short 0x0B40
017D:0B16 mov AX,word ptr SS:[BP-40]
017D:0B19 and AX,0x00F0
017D:0B1C mov word ptr SS:[BP-10],AX
017D:0B1F cmp AX,0x0030
017D:0B22 jge short 0x0B40
017D:0B24 mov word ptr SS:[BP-22],8
017D:0B29 cmp AX,0x0020
017D:0B2C je short 0x0B32
017D:0B2E or AX,AX
017D:0B30 jne short 0x0B40
017D:0B32 mov AL,byte ptr SS:[BP-40]
017D:0B35 and AL,0x0F
017D:0B37 cmp AL,0x0F
017D:0B39 jne short 0x0B40
017D:0B3B mov word ptr SS:[BP-22],0x0010
017D:0B40 mov AL,byte ptr SS:[BP-22]
017D:0B43 mov BX,word ptr SS:[BP-32]
017D:0B46 mov ES,word ptr DS:[0x5398]
017D:0B4A mov byte ptr ES:[BX+0x32AE],AL
017D:0B4F mov ES,word ptr DS:[0x53A0]
017D:0B53 cmp word ptr ES:[0x4FBA],0
017D:0B59 je short 0x0B65
017D:0B5B les BX,word ptr SS:[BP-4]
017D:0B5E mov AL,byte ptr SS:[BP-22]
017D:0B61 sub byte ptr ES:[BX+1],AL
017D:0B65 mov ES,word ptr DS:[0x53A0]
017D:0B69 cmp word ptr ES:[0x4FBA],2
017D:0B6F jne short 0x0B74
017D:0B71 jmp near 0x0A05
017D:0B74 cmp word ptr ES:[0x4FBA],0
017D:0B7A jne short 0x0B9F
017D:0B7C cmp word ptr SS:[BP-22],0
017D:0B80 je short 0x0B9F
017D:0B82 mov ES,word ptr DS:[0x53A2]
017D:0B86 mov AX,word ptr SS:[BP-30]
017D:0B89 sub AX,word ptr SS:[BP-22]
017D:0B8C add AX,0x0018
017D:0B8F mov word ptr ES:[0xB780],AX
017D:0B93 cmp AX,0x00C8
017D:0B96 jle short 0x0B9F
017D:0B98 mov word ptr ES:[0xB780],0x00C8
017D:0B9F push word ptr SS:[BP-30]
017D:0BA2 push word ptr SS:[BP-24]
017D:0BA5 push word ptr SS:[BP-2]
017D:0BA8 push word ptr SS:[BP-4]
017D:0BAB mov AX,0x244B
017D:0BAE mov DX,0x1DE9
017D:0BB1 push DX
017D:0BB2 push AX
017D:0BB3 call far 19FC:28EB
017D:0BB8 add SP,0x000C
017D:0BBB mov ES,word ptr DS:[0x53A2]
017D:0BBF mov word ptr ES:[0xB780],0x00C8
017D:0BC6 jmp near 0x0A20
017D:0BC9 mov ES,word ptr DS:[0x538C]
017D:0BCD mov AX,word ptr ES:[0xA44B]
017D:0BD1 mov word ptr SS:[BP-28],AX
017D:0BD4 mov ES,word ptr DS:[0x538E]
017D:0BD8 mov AX,word ptr ES:[0xA44D]
017D:0BDC mov word ptr SS:[BP-36],AX
017D:0BDF sub AX,AX
017D:0BE1 mov word ptr SS:[BP-18],AX
017D:0BE4 mov word ptr SS:[BP-14],AX
017D:0BE7 mov word ptr SS:[BP-32],AX
017D:0BEA mov AX,0x0011
017D:0BED imul word ptr SS:[BP-32]
017D:0BF0 mov SI,AX
017D:0BF2 mov ES,word ptr DS:[0x538A]
017D:0BF6 cmp byte ptr ES:[SI-14828],0xFF
017D:0BFC je short 0x0C71
017D:0BFE cmp byte ptr ES:[SI-14816],8
017D:0C04 jl short 0x0C71
017D:0C06 mov BX,word ptr SS:[BP-14]
017D:0C09 mov ES,word ptr DS:[0x53A8]
017D:0C0D mov AL,byte ptr ES:[BX+0x3A1E]
017D:0C12 cbw
017D:0C13 push AX
017D:0C14 mov ES,word ptr DS:[0x53AA]
017D:0C18 mov AL,byte ptr ES:[BX+0x3A16]
017D:0C1D cbw
017D:0C1E push AX
017D:0C1F push CS
017D:0C20 call near 0x191B
017D:0C23 add SP,4
017D:0C26 mov SI,word ptr SS:[BP-14]
017D:0C29 shl SI,1
017D:0C2B mov ES,word ptr DS:[0x538C]
017D:0C2F mov AX,word ptr ES:[0xA44B]
017D:0C33 mov ES,word ptr DS:[0x53A4]
017D:0C37 mov word ptr ES:[SI+0x400C],AX
017D:0C3C mov ES,word ptr DS:[0x538E]
017D:0C40 mov AX,word ptr ES:[0xA44D]
017D:0C44 mov ES,word ptr DS:[0x53A6]
017D:0C48 mov word ptr ES:[SI+0x403E],AX
017D:0C4D mov ES,word ptr DS:[0x5392]
017D:0C51 mov word ptr ES:[SI+0x4072],1
017D:0C58 mov ES,word ptr DS:[0x538C]
017D:0C5C mov AX,word ptr SS:[BP-28]
017D:0C5F mov word ptr ES:[0xA44B],AX
017D:0C63 mov ES,word ptr DS:[0x538E]
017D:0C67 mov AX,word ptr SS:[BP-36]
017D:0C6A mov word ptr ES:[0xA44D],AX
017D:0C6E inc word ptr SS:[BP-14]
017D:0C71 inc word ptr SS:[BP-32]
017D:0C74 cmp word ptr SS:[BP-32],8
017D:0C78 jge short 0x0C7D
017D:0C7A jmp near 0x0BEA
017D:0C7D mov ES,word ptr DS:[0x538C]
017D:0C81 mov AX,word ptr SS:[BP-28]
017D:0C84 mov word ptr ES:[0xA44B],AX
017D:0C88 mov ES,word ptr DS:[0x538E]
017D:0C8C mov AX,word ptr SS:[BP-36]
017D:0C8F mov word ptr ES:[0xA44D],AX
017D:0C93 mov word ptr SS:[BP-32],0
017D:0C98 mov AX,0x007D
017D:0C9B imul word ptr SS:[BP-32]
017D:0C9E mov BX,AX
017D:0CA0 mov ES,word ptr DS:[0x538A]
017D:0CA4 cmp byte ptr ES:[BX-14556],0xFF
017D:0CAA je short 0x0D24
017D:0CAC mov BX,word ptr SS:[BP-18]
017D:0CAF mov ES,word ptr DS:[0x53AC]
017D:0CB3 mov AL,byte ptr ES:[BX+0x3A26]
017D:0CB8 cbw
017D:0CB9 mov word ptr SS:[BP-24],AX
017D:0CBC mov ES,word ptr DS:[0x53AE]
017D:0CC0 mov AL,byte ptr ES:[BX+0x3A2A]
017D:0CC5 cbw
017D:0CC6 mov word ptr SS:[BP-30],AX
017D:0CC9 push AX
017D:0CCA push word ptr SS:[BP-24]
017D:0CCD push CS
017D:0CCE call near 0x191B
017D:0CD1 add SP,4
017D:0CD4 mov SI,word ptr SS:[BP-18]
017D:0CD7 shl SI,1
017D:0CD9 mov ES,word ptr DS:[0x538C]
017D:0CDD mov AX,word ptr ES:[0xA44B]
017D:0CE1 mov ES,word ptr DS:[0x53A4]
017D:0CE5 mov word ptr ES:[SI+0x4004],AX
017D:0CEA mov ES,word ptr DS:[0x538E]
017D:0CEE mov AX,word ptr ES:[0xA44D]
017D:0CF2 mov ES,word ptr DS:[0x53A6]
017D:0CF6 mov word ptr ES:[SI+0x4036],AX
017D:0CFB mov BX,word ptr SS:[BP-18]
017D:0CFE inc word ptr SS:[BP-18]
017D:0D01 shl BX,1
017D:0D03 mov ES,word ptr DS:[0x5392]
017D:0D07 mov word ptr ES:[BX+0x406A],1
017D:0D0E mov ES,word ptr DS:[0x538C]
017D:0D12 mov AX,word ptr SS:[BP-28]
017D:0D15 mov word ptr ES:[0xA44B],AX
017D:0D19 mov ES,word ptr DS:[0x538E]
017D:0D1D mov AX,word ptr SS:[BP-36]
017D:0D20 mov word ptr ES:[0xA44D],AX
017D:0D24 inc word ptr SS:[BP-32]
017D:0D27 cmp word ptr SS:[BP-32],4
017D:0D2B jge short 0x0D30
017D:0D2D jmp near 0x0C98
017D:0D30 mov ES,word ptr DS:[0x53B0]
017D:0D34 cmp word ptr ES:[0x398E],0
017D:0D3A jne short 0x0D3F
017D:0D3C jmp near 0x0E46
017D:0D3F mov word ptr SS:[BP-32],0
017D:0D44 jmp short 0x0D74
017D:0D46 mov AX,word ptr SS:[BP-30]
017D:0D49 mov CL,3
017D:0D4B shl AX,CL
017D:0D4D push AX
017D:0D4E mov AX,word ptr SS:[BP-24]
017D:0D51 shl AX,CL
017D:0D53 push AX
017D:0D54 mov ES,word ptr DS:[0x539E]
017D:0D58 push word ptr ES:[0x3C44]
017D:0D5D push word ptr ES:[0x3C42]
017D:0D62 sub AX,AX
017D:0D64 mov DX,0xAC00
017D:0D67 push DX
017D:0D68 push AX
017D:0D69 call far 19FC:0377
017D:0D71 inc word ptr SS:[BP-32]
017D:0D74 cmp word ptr SS:[BP-32],4
017D:0D78 jl short 0x0D7D
017D:0D7A jmp near 0x0E46
017D:0D7D mov AX,word ptr SS:[BP-32]
017D:0D80 shl AX,1
017D:0D82 shl AX,1
017D:0D84 add AX,0x0D13
017D:0D87 mov word ptr SS:[BP-24],AX
017D:0D8A mov word ptr SS:[BP-30],0x702C
017D:0D8F mov ES,word ptr DS:[0x538C]
017D:0D93 sub AX,word ptr ES:[0xA44B]
017D:0D98 add AX,0x001A
017D:0D9B mov word ptr SS:[BP-24],AX
017D:0D9E mov AX,0x702C
017D:0DA1 mov ES,word ptr DS:[0x538E]
017D:0DA5 sub AX,word ptr ES:[0xA44D]
017D:0DAA add AX,0x000C
017D:0DAD mov word ptr SS:[BP-30],AX
017D:0DB0 sub AX,AX
017D:0DB2 mov word ptr SS:[BP-38],AX
017D:0DB5 mov word ptr SS:[BP-34],AX
017D:0DB8 cmp word ptr SS:[BP-24],0x000D
017D:0DBC jl short 0x0DC4
017D:0DBE cmp word ptr SS:[BP-24],0x0027
017D:0DC2 jle short 0x0DC9
017D:0DC4 mov word ptr SS:[BP-34],1
017D:0DC9 cmp word ptr SS:[BP-30],0
017D:0DCD jl short 0x0DD5
017D:0DCF cmp word ptr SS:[BP-30],0x0018
017D:0DD3 jle short 0x0DDA
017D:0DD5 mov word ptr SS:[BP-38],1
017D:0DDA cmp word ptr SS:[BP-24],-115
017D:0DDE jl short 0x0D71
017D:0DE0 cmp word ptr SS:[BP-24],0x00A7
017D:0DE5 jg short 0x0D71
017D:0DE7 cmp word ptr SS:[BP-30],0xF080
017D:0DEC jl short 0x0D71
017D:0DEE cmp word ptr SS:[BP-30],0x0F98
017D:0DF3 jle short 0x0DF8
017D:0DF5 jmp near 0x0D71
017D:0DF8 mov AX,word ptr SS:[BP-34]
017D:0DFB add AX,word ptr SS:[BP-38]
017D:0DFE je short 0x0E03
017D:0E00 jmp near 0x0D71
017D:0E03 and word ptr SS:[BP-24],0x007F
017D:0E07 and word ptr SS:[BP-30],0x007F
017D:0E0B mov ES,word ptr DS:[0x53A0]
017D:0E0F cmp word ptr ES:[0x4FBA],2
017D:0E15 jne short 0x0E1A
017D:0E17 jmp near 0x0D46
017D:0E1A mov AX,word ptr SS:[BP-30]
017D:0E1D mov CL,3
017D:0E1F shl AX,CL
017D:0E21 push AX
017D:0E22 mov AX,word ptr SS:[BP-24]
017D:0E25 shl AX,CL
017D:0E27 push AX
017D:0E28 mov ES,word ptr DS:[0x539E]
017D:0E2C push word ptr ES:[0x3C44]
017D:0E31 push word ptr ES:[0x3C42]
017D:0E36 mov AX,0x244B
017D:0E39 mov DX,0x1DE9
017D:0E3C push DX
017D:0E3D push AX
017D:0E3E call far 19FC:28EB
017D:0E46 pop SI
017D:0E47 mov SP,BP
017D:0E49 pop BP
017D:0E4A ret far
017D:0E4B push BP
017D:0E4C mov BP,SP
017D:0E4E mov AX,0x005E
017D:0E51 call far 19FC:2FDC
017D:0E56 push DI
017D:0E57 push SI
017D:0E58 mov ES,word ptr DS:[0x538C]
017D:0E5C mov AX,word ptr ES:[0xA44B]
017D:0E60 mov ES,word ptr DS:[0x538E]
017D:0E64 or AX,word ptr ES:[0xA44D]
017D:0E69 mov CL,8
017D:0E6B shr AX,CL
017D:0E6D mov word ptr SS:[BP-62],AX
017D:0E70 push CS
017D:0E71 call near 0x2A93
017D:0E74 mov ES,word ptr DS:[0x538C]
017D:0E78 mov AX,word ptr ES:[0xA44B]
017D:0E7C mov word ptr SS:[BP-12],AX
017D:0E7F mov ES,word ptr DS:[0x538E]
017D:0E83 mov AX,word ptr ES:[0xA44D]
017D:0E87 mov word ptr SS:[BP-22],AX
017D:0E8A mov word ptr SS:[BP-76],0
017D:0E8F mov BX,word ptr SS:[BP-76]
017D:0E92 mov ES,word ptr DS:[0x53B2]
017D:0E96 mov byte ptr ES:[BX+0x42F6],0
017D:0E9C inc word ptr SS:[BP-76]
017D:0E9F cmp word ptr SS:[BP-76],0x0018
017D:0EA3 jl short 0x0E8F
017D:0EA5 mov word ptr SS:[BP-92],0
017D:0EAA jmp near 0x1191
017D:0EAD push word ptr SS:[BP-74]
017D:0EB0 push word ptr SS:[BP-70]
017D:0EB3 push word ptr SS:[BP-2]
017D:0EB6 push word ptr SS:[BP-4]
017D:0EB9 sub AX,AX
017D:0EBB mov DX,0xAC00
017D:0EBE push DX
017D:0EBF push AX
017D:0EC0 call far 19FC:0377
017D:0EDE inc word ptr SS:[BP-76]
017D:0EE1 cmp word ptr SS:[BP-76],8
017D:0EE5 jl short 0x0EEA
017D:0EE7 jmp near 0x118D
017D:0EEA mov SI,word ptr SS:[BP-76]
017D:0EED add SI,word ptr SS:[BP-92]
017D:0EF0 mov BX,SI
017D:0EF2 shl BX,1
017D:0EF4 mov ES,word ptr DS:[0x53A4]
017D:0EF8 cmp word ptr ES:[BX+0x400C],-1
017D:0EFE je short 0x0EDE
017D:0F00 lea AX,SI+4
017D:0F03 mov word ptr SS:[BP-60],AX
017D:0F06 mov SI,AX
017D:0F08 shl SI,1
017D:0F0A mov AX,word ptr ES:[SI+0x4004]
017D:0F0F mov word ptr SS:[BP-70],AX
017D:0F12 mov ES,word ptr DS:[0x53A6]
017D:0F16 mov AX,word ptr ES:[SI+0x4036]
017D:0F1B mov word ptr SS:[BP-74],AX
017D:0F1E sub AX,AX
017D:0F20 mov word ptr SS:[BP-80],AX
017D:0F23 mov word ptr SS:[BP-78],AX
017D:0F26 mov AX,word ptr SS:[BP-70]
017D:0F29 sub AX,word ptr SS:[BP-12]
017D:0F2C add AX,0x001A
017D:0F2F mov word ptr SS:[BP-70],AX
017D:0F32 mov AX,word ptr SS:[BP-74]
017D:0F35 sub AX,word ptr SS:[BP-22]
017D:0F38 add AX,0x000C
017D:0F3B mov word ptr SS:[BP-74],AX
017D:0F3E mov ES,word ptr DS:[0x53A4]
017D:0F42 mov AX,word ptr ES:[SI+0x4004]
017D:0F47 sub AL,AL
017D:0F49 mov CX,word ptr SS:[BP-12]
017D:0F4C sub CL,CL
017D:0F4E cmp AX,CX
017D:0F50 jne short 0x0F63
017D:0F52 cmp word ptr SS:[BP-70],0x000D
017D:0F56 jl short 0x0F5E
017D:0F58 cmp word ptr SS:[BP-70],0x0027
017D:0F5C jle short 0x0F63
017D:0F5E mov word ptr SS:[BP-78],1
017D:0F63 mov BX,word ptr SS:[BP-60]
017D:0F66 shl BX,1
017D:0F68 mov ES,word ptr DS:[0x53A6]
017D:0F6C mov AX,word ptr ES:[BX+0x4036]
017D:0F71 sub AL,AL
017D:0F73 mov CX,word ptr SS:[BP-22]
017D:0F76 sub CL,CL
017D:0F78 cmp AX,CX
017D:0F7A jne short 0x0F8D
017D:0F7C cmp word ptr SS:[BP-74],0
017D:0F80 jl short 0x0F88
017D:0F82 cmp word ptr SS:[BP-74],0x0018
017D:0F86 jle short 0x0F8D
017D:0F88 mov word ptr SS:[BP-80],1
017D:0F8D cmp word ptr SS:[BP-70],-115
017D:0F91 jge short 0x0F96
017D:0F93 jmp near 0x0EDE
017D:0F96 cmp word ptr SS:[BP-70],0x00A7
017D:0F9B jle short 0x0FA0
017D:0F9D jmp near 0x0EDE
017D:0FA0 cmp word ptr SS:[BP-74],0xF080
017D:0FA5 jge short 0x0FAA
017D:0FA7 jmp near 0x0EDE
017D:0FAA cmp word ptr SS:[BP-74],0x0F98
017D:0FAF jle short 0x0FB4
017D:0FB1 jmp near 0x0EDE
017D:0FB4 mov AX,word ptr SS:[BP-78]
017D:0FB7 add AX,word ptr SS:[BP-80]
017D:0FBA je short 0x0FBF
017D:0FBC jmp near 0x0EDE
017D:0FBF mov BX,word ptr SS:[BP-60]
017D:0FC2 mov ES,word ptr DS:[0x53B2]
017D:0FC6 mov byte ptr ES:[BX+0x42F6],1
017D:0FCC and word ptr SS:[BP-70],0x007F
017D:0FD0 and word ptr SS:[BP-74],0x007F
017D:0FD4 mov AX,word ptr SS:[BP-70]
017D:0FD7 sub AX,0x000D
017D:0FDA mov word ptr SS:[BP-82],AX
017D:0FDD mov AX,word ptr SS:[BP-74]
017D:0FE0 sar AX,1
017D:0FE2 mov CX,0x0018
017D:0FE5 imul CX
017D:0FE7 mov CX,word ptr SS:[BP-82]
017D:0FEA sar CX,1
017D:0FEC add AX,CX
017D:0FEE mov ES,word ptr DS:[0x5394]
017D:0FF2 add AX,word ptr ES:[0x09ED]
017D:0FF7 mov word ptr SS:[BP-66],AX
017D:0FFA test byte ptr SS:[BP-82],1
017D:0FFE je short 0x100F
017D:1000 mov ES,word ptr DS:[0x538C]
017D:1004 test byte ptr ES:[0xA44B],1
017D:100A je short 0x100F
017D:100C inc word ptr SS:[BP-66]
017D:100F test byte ptr SS:[BP-74],1
017D:1013 je short 0x1025
017D:1015 mov ES,word ptr DS:[0x538E]
017D:1019 test byte ptr ES:[0xA44D],1
017D:101F je short 0x1025
017D:1021 add word ptr SS:[BP-66],0x0018
017D:1025 mov BX,word ptr SS:[BP-74]
017D:1028 mov ES,word ptr DS:[0x538E]
017D:102C xor BX,word ptr ES:[0xA44D]
017D:1031 and BX,1
017D:1034 shl BX,1
017D:1036 mov AX,word ptr SS:[BP-82]
017D:1039 mov ES,word ptr DS:[0x538C]
017D:103D xor AX,word ptr ES:[0xA44B]
017D:1042 and AX,1
017D:1045 add BX,AX
017D:1047 shl BX,1
017D:1049 mov AX,word ptr DS:[BX+0x0372]
017D:104D mov word ptr SS:[BP-94],AX
017D:1050 mov BX,word ptr SS:[BP-66]
017D:1053 mov ES,word ptr DS:[0x5396]
017D:1057 mov AL,byte ptr ES:[BX+0x07AD]
017D:105C sub AH,AH
017D:105E mov word ptr SS:[BP-72],AX
017D:1061 mov BX,word ptr SS:[BP-60]
017D:1064 mov ES,word ptr DS:[0x53B4]
017D:1068 mov byte ptr ES:[BX+0x3750],AL
017D:106D mov word ptr SS:[BP-68],0
017D:1072 mov ES,word ptr DS:[0x538A]
017D:1076 cmp byte ptr ES:[0xD346],AH
017D:107B jne short 0x10A9
017D:107D cmp word ptr SS:[BP-72],0x00F6
017D:1082 jge short 0x10A9
017D:1084 mov AX,word ptr SS:[BP-94]
017D:1087 and word ptr SS:[BP-72],AX
017D:108A je short 0x10A9
017D:108C mov AX,word ptr SS:[BP-72]
017D:108F and AX,0x00F0
017D:1092 mov word ptr SS:[BP-10],AX
017D:1095 cmp AX,0x0030
017D:1098 jge short 0x10A9
017D:109A mov word ptr SS:[BP-68],2
017D:109F cmp AX,0x0020
017D:10A2 jne short 0x10A9
017D:10A4 mov word ptr SS:[BP-68],4
017D:10A9 mov AL,byte ptr SS:[BP-68]
017D:10AC mov BX,word ptr SS:[BP-60]
017D:10AF mov ES,word ptr DS:[0x5398]
017D:10B3 mov byte ptr ES:[BX+0x32AE],AL
017D:10B8 mov CL,3
017D:10BA shl word ptr SS:[BP-70],CL
017D:10BD shl word ptr SS:[BP-74],CL
017D:10C0 mov SI,word ptr SS:[BP-60]
017D:10C3 shl SI,1
017D:10C5 mov AX,word ptr SS:[BP-70]
017D:10C8 mov ES,word ptr DS:[0x53B6]
017D:10CC mov word ptr ES:[SI+0x324C],AX
017D:10D1 mov AX,word ptr SS:[BP-74]
017D:10D4 mov ES,word ptr DS:[0x53B8]
017D:10D8 mov word ptr ES:[SI+0x327C],AX
017D:10DD mov BX,word ptr SS:[BP-60]
017D:10E0 mov ES,word ptr DS:[0x539A]
017D:10E4 mov BL,byte ptr ES:[BX+0x409A]
017D:10E9 sub BH,BH
017D:10EB mov DI,word ptr SS:[BP-60]
017D:10EE mov ES,word ptr DS:[0x539C]
017D:10F2 mov AL,byte ptr ES:[DI-10914]
017D:10F7 sub AH,AH
017D:10F9 add BX,AX
017D:10FB shl BX,1
017D:10FD shl BX,1
017D:10FF mov ES,word ptr DS:[0x539E]
017D:1103 mov AX,word ptr ES:[BX+0x39FA]
017D:1108 mov DX,word ptr ES:[BX+0x39FC]
017D:110D mov word ptr SS:[BP-4],AX
017D:1110 mov word ptr SS:[BP-2],DX
017D:1113 mov ES,word ptr DS:[0x53A0]
017D:1117 cmp word ptr ES:[0x4FBA],0
017D:111D je short 0x1129
017D:111F les BX,word ptr SS:[BP-4]
017D:1122 mov AL,byte ptr SS:[BP-68]
017D:1125 sub byte ptr ES:[BX+1],AL
017D:1129 mov ES,word ptr DS:[0x53A0]
017D:112D cmp word ptr ES:[0x4FBA],2
017D:1133 jne short 0x1138
017D:1135 jmp near 0x0EAD
017D:1138 cmp word ptr ES:[0x4FBA],0
017D:113E jne short 0x1163
017D:1140 cmp word ptr SS:[BP-68],0
017D:1144 je short 0x1163
017D:1146 mov ES,word ptr DS:[0x53A2]
017D:114A mov AX,word ptr SS:[BP-74]
017D:114D sub AX,word ptr SS:[BP-68]
017D:1150 add AX,8
017D:1153 mov word ptr ES:[0xB780],AX
017D:1157 cmp AX,0x00C8
017D:115A jle short 0x1163
017D:115C mov word ptr ES:[0xB780],0x00C8
017D:1163 push word ptr SS:[BP-74]
017D:1166 push word ptr SS:[BP-70]
017D:1169 push word ptr SS:[BP-2]
017D:116C push word ptr SS:[BP-4]
017D:116F mov AX,0x244B
017D:1172 mov DX,0x1DE9
017D:1175 push DX
017D:1176 push AX
017D:1177 call far 19FC:28EB
017D:118D add word ptr SS:[BP-92],0x000C
017D:1191 cmp word ptr SS:[BP-92],0x000E
017D:1195 jge short 0x119F
017D:1197 mov word ptr SS:[BP-76],0
017D:119C jmp near 0x0EE1
017D:119F mov word ptr SS:[BP-6],0xFFFF
017D:11A4 mov word ptr SS:[BP-92],0
017D:11A9 jmp near 0x140C
017D:11AC inc word ptr SS:[BP-76]
017D:11AF cmp word ptr SS:[BP-76],4
017D:11B3 jl short 0x11B8
017D:11B5 jmp near 0x1408
017D:11B8 mov SI,word ptr SS:[BP-76]
017D:11BB add SI,word ptr SS:[BP-92]
017D:11BE shl SI,1
017D:11C0 mov ES,word ptr DS:[0x53A4]
017D:11C4 cmp word ptr ES:[SI+0x4004],-1
017D:11CA je short 0x11AC
017D:11CC mov AX,word ptr SS:[BP-76]
017D:11CF add AX,word ptr SS:[BP-92]
017D:11D2 mov word ptr SS:[BP-60],AX
017D:11D5 mov AX,word ptr ES:[SI+0x4004]
017D:11DA mov word ptr SS:[BP-70],AX
017D:11DD mov ES,word ptr DS:[0x53A6]
017D:11E1 mov AX,word ptr ES:[SI+0x4036]
017D:11E6 mov word ptr SS:[BP-74],AX
017D:11E9 sub AX,AX
017D:11EB mov word ptr SS:[BP-80],AX
017D:11EE mov word ptr SS:[BP-78],AX
017D:11F1 mov AX,word ptr SS:[BP-70]
017D:11F4 sub AX,word ptr SS:[BP-12]
017D:11F7 add AX,0x001A
017D:11FA mov word ptr SS:[BP-70],AX
017D:11FD mov AX,word ptr SS:[BP-74]
017D:1200 sub AX,word ptr SS:[BP-22]
017D:1203 add AX,0x000C
017D:1206 mov word ptr SS:[BP-74],AX
017D:1209 mov ES,word ptr DS:[0x53A4]
017D:120D mov AX,word ptr ES:[SI+0x4004]
017D:1212 sub AL,AL
017D:1214 mov CX,word ptr SS:[BP-12]
017D:1217 sub CL,CL
017D:1219 cmp AX,CX
017D:121B jne short 0x122E
017D:121D cmp word ptr SS:[BP-70],0x000B
017D:1221 jl short 0x1229
017D:1223 cmp word ptr SS:[BP-70],0x0027
017D:1227 jle short 0x122E
017D:1229 mov word ptr SS:[BP-78],1
017D:122E mov BX,word ptr SS:[BP-60]
017D:1231 shl BX,1
017D:1233 mov ES,word ptr DS:[0x53A6]
017D:1237 mov AX,word ptr ES:[BX+0x4036]
017D:123C sub AL,AL
017D:123E mov CX,word ptr SS:[BP-22]
017D:1241 sub CL,CL
017D:1243 cmp AX,CX
017D:1245 jne short 0x1258
017D:1247 cmp word ptr SS:[BP-74],0
017D:124B jl short 0x1253
017D:124D cmp word ptr SS:[BP-74],0x001A
017D:1251 jle short 0x1258
017D:1253 mov word ptr SS:[BP-80],1
017D:1258 sub AL,AL
017D:125A mov BX,word ptr SS:[BP-60]
017D:125D mov ES,word ptr DS:[0x53BA]
017D:1261 mov byte ptr ES:[BX+0x4554],AL
017D:1266 mov BX,word ptr SS:[BP-60]
017D:1269 mov ES,word ptr DS:[0x53BC]
017D:126D mov byte ptr ES:[BX+0x45CE],AL
017D:1272 cmp word ptr SS:[BP-70],-117
017D:1276 jge short 0x127B
017D:1278 jmp near 0x11AC
017D:127B cmp word ptr SS:[BP-70],0x00A7
017D:1280 jle short 0x1285
017D:1282 jmp near 0x11AC
017D:1285 cmp word ptr SS:[BP-74],0xF080
017D:128A jge short 0x128F
017D:128C jmp near 0x11AC
017D:128F cmp word ptr SS:[BP-74],0x0F9A
017D:1294 jle short 0x1299
017D:1296 jmp near 0x11AC
017D:1299 mov AX,word ptr SS:[BP-78]
017D:129C add AX,word ptr SS:[BP-80]
017D:129F je short 0x12A4
017D:12A1 jmp near 0x11AC
017D:12A4 mov BX,word ptr SS:[BP-60]
017D:12A7 mov ES,word ptr DS:[0x53B2]
017D:12AB mov byte ptr ES:[BX+0x42F6],1
017D:12B1 and word ptr SS:[BP-70],0x007F
017D:12B5 and word ptr SS:[BP-74],0x007F
017D:12B9 mov AX,word ptr SS:[BP-74]
017D:12BC sar AX,1
017D:12BE mov CX,0x0018
017D:12C1 imul CX
017D:12C3 mov word ptr SS:[BP-66],AX
017D:12C6 test byte ptr SS:[BP-74],1
017D:12CA je short 0x12D6
017D:12CC test byte ptr SS:[BP-22],1
017D:12D0 je short 0x12D6
017D:12D2 add word ptr SS:[BP-66],0x0018
017D:12D6 mov word ptr SS:[BP-94],1
017D:12DB mov AL,byte ptr SS:[BP-74]
017D:12DE xor AL,byte ptr SS:[BP-22]
017D:12E1 test AL,1
017D:12E3 je short 0x12F7
017D:12E5 mov word ptr SS:[BP-94],4
017D:12EA mov BX,word ptr SS:[BP-60]
017D:12ED mov ES,word ptr DS:[0x53BA]
017D:12F1 mov byte ptr ES:[BX+0x4554],1
017D:12F7 mov SI,word ptr SS:[BP-70]
017D:12FA shl SI,1
017D:12FC mov AX,word ptr DS:[SI+0x0364]
017D:1300 add word ptr SS:[BP-66],AX
017D:1303 test byte ptr SS:[BP-12],1
017D:1307 je short 0x1310
017D:1309 mov AX,word ptr DS:[SI+0x039E]
017D:130D add word ptr SS:[BP-66],AX
017D:1310 mov ES,word ptr DS:[0x5394]
017D:1314 mov SI,word ptr ES:[0x09ED]
017D:1319 add SI,word ptr SS:[BP-66]
017D:131C mov ES,word ptr DS:[0x5396]
017D:1320 mov AL,byte ptr ES:[SI+0x0795]
017D:1325 mov BX,word ptr SS:[BP-60]
017D:1328 mov ES,word ptr DS:[0x53BC]
017D:132C mov byte ptr ES:[BX+0x45CE],AL
017D:1331 mov ES,word ptr DS:[0x5396]
017D:1335 mov AL,byte ptr ES:[SI+0x07AD]
017D:133A sub AH,AH
017D:133C mov word ptr SS:[BP-72],AX
017D:133F mov BX,word ptr SS:[BP-60]
017D:1342 mov ES,word ptr DS:[0x53B4]
017D:1346 mov byte ptr ES:[BX+0x3750],AL
017D:134B mov word ptr SS:[BP-68],0
017D:1350 mov ES,word ptr DS:[0x538A]
017D:1354 cmp byte ptr ES:[0xD346],AH
017D:1359 jne short 0x1394
017D:135B cmp word ptr SS:[BP-72],0x00F6
017D:1360 jge short 0x1394
017D:1362 mov AX,word ptr SS:[BP-94]
017D:1365 and word ptr SS:[BP-72],AX
017D:1368 je short 0x1394
017D:136A mov AX,word ptr SS:[BP-72]
017D:136D and AX,0x00F0
017D:1370 mov word ptr SS:[BP-10],AX
017D:1373 cmp AX,0x0030
017D:1376 jge short 0x1394
017D:1378 mov word ptr SS:[BP-68],8
017D:137D cmp AX,0x0020
017D:1380 je short 0x1386
017D:1382 or AX,AX
017D:1384 jne short 0x1394
017D:1386 mov AL,byte ptr SS:[BP-72]
017D:1389 and AL,0x0F
017D:138B cmp AL,0x0F
017D:138D jne short 0x1394
017D:138F mov word ptr SS:[BP-68],0x0010
017D:1394 mov AL,byte ptr SS:[BP-68]
017D:1397 mov BX,word ptr SS:[BP-60]
017D:139A mov ES,word ptr DS:[0x5398]
017D:139E mov byte ptr ES:[BX+0x32AE],AL
017D:13A3 mov CL,3
017D:13A5 shl word ptr SS:[BP-70],CL
017D:13A8 shl word ptr SS:[BP-74],CL
017D:13AB mov SI,word ptr SS:[BP-60]
017D:13AE shl SI,1
017D:13B0 mov AX,word ptr SS:[BP-70]
017D:13B3 mov ES,word ptr DS:[0x53B6]
017D:13B7 mov word ptr ES:[SI+0x324C],AX
017D:13BC mov AX,word ptr SS:[BP-74]
017D:13BF mov ES,word ptr DS:[0x53B8]
017D:13C3 mov word ptr ES:[SI+0x327C],AX
017D:13C8 inc word ptr SS:[BP-6]
017D:13CB mov DI,word ptr SS:[BP-6]
017D:13CE shl DI,1
017D:13D0 mov AX,word ptr SS:[BP-70]
017D:13D3 mov word ptr SS:[BP+DI-38],AX
017D:13D6 mov DI,word ptr SS:[BP-6]
017D:13D9 shl DI,1
017D:13DB mov AX,word ptr SS:[BP-74]
017D:13DE mov word ptr SS:[BP+DI-58],AX
017D:13E1 mov DI,word ptr SS:[BP-6]
017D:13E4 mov AL,byte ptr SS:[BP-68]
017D:13E7 mov byte ptr SS:[BP+DI-20],AL
017D:13EA mov BX,word ptr SS:[BP-60]
017D:13ED mov ES,word ptr DS:[0x539A]
017D:13F1 mov AL,byte ptr ES:[BX+0x409A]
017D:13F6 mov ES,word ptr DS:[0x539C]
017D:13FA add AL,byte ptr ES:[BX-10914]
017D:13FF mov DI,word ptr SS:[BP-6]
017D:1402 mov byte ptr SS:[BP+DI-90],AL
017D:1405 jmp near 0x11AC
017D:1408 add word ptr SS:[BP-92],0x000C
017D:140C cmp word ptr SS:[BP-92],0x000E
017D:1410 jge short 0x141A
017D:1412 mov word ptr SS:[BP-76],0
017D:1417 jmp near 0x11AF
017D:141A cmp word ptr SS:[BP-6],-1
017D:141E jne short 0x1423
017D:1420 jmp near 0x1616
017D:1423 cmp word ptr SS:[BP-6],0
017D:1427 jg short 0x142C
017D:1429 jmp near 0x1508
017D:142C mov word ptr SS:[BP-76],0
017D:1431 jmp near 0x14F6
017D:1434 inc word ptr SS:[BP-70]
017D:1437 mov AX,word ptr SS:[BP-6]
017D:143A cmp word ptr SS:[BP-70],AX
017D:143D jle short 0x1442
017D:143F jmp near 0x14F3
017D:1442 mov BX,word ptr SS:[BP-76]
017D:1445 shl BX,1
017D:1447 add BX,BP
017D:1449 mov SI,word ptr DS:[BX-58]
017D:144C mov BX,word ptr SS:[BP-70]
017D:144F shl BX,1
017D:1451 add BX,BP
017D:1453 mov DI,word ptr DS:[BX-58]
017D:1456 cmp DI,SI
017D:1458 jge short 0x1434
017D:145A mov BX,word ptr SS:[BP-70]
017D:145D shl BX,1
017D:145F add BX,BP
017D:1461 mov AX,word ptr DS:[BX-38]
017D:1464 mov word ptr SS:[BP-40],AX
017D:1467 mov BX,word ptr SS:[BP-76]
017D:146A shl BX,1
017D:146C add BX,BP
017D:146E mov AX,word ptr DS:[BX-38]
017D:1471 mov BX,word ptr SS:[BP-70]
017D:1474 shl BX,1
017D:1476 add BX,BP
017D:1478 mov word ptr DS:[BX-38],AX
017D:147B mov BX,word ptr SS:[BP-76]
017D:147E shl BX,1
017D:1480 add BX,BP
017D:1482 mov AX,word ptr SS:[BP-40]
017D:1485 mov word ptr DS:[BX-38],AX
017D:1488 mov word ptr SS:[BP-40],DI
017D:148B mov BX,word ptr SS:[BP-70]
017D:148E shl BX,1
017D:1490 add BX,BP
017D:1492 mov word ptr DS:[BX-58],SI
017D:1495 mov BX,word ptr SS:[BP-76]
017D:1498 shl BX,1
017D:149A add BX,BP
017D:149C mov AX,word ptr SS:[BP-40]
017D:149F mov word ptr DS:[BX-58],AX
017D:14A2 mov BX,word ptr SS:[BP-70]
017D:14A5 add BX,BP
017D:14A7 mov AL,byte ptr DS:[BX-90]
017D:14AA sub AH,AH
017D:14AC mov word ptr SS:[BP-40],AX
017D:14AF mov BX,word ptr SS:[BP-76]
017D:14B2 add BX,BP
017D:14B4 mov AL,byte ptr DS:[BX-90]
017D:14B7 mov BX,word ptr SS:[BP-70]
017D:14BA add BX,BP
017D:14BC mov byte ptr DS:[BX-90],AL
017D:14BF mov BX,word ptr SS:[BP-76]
017D:14C2 add BX,BP
017D:14C4 mov AL,byte ptr SS:[BP-40]
017D:14C7 mov byte ptr DS:[BX-90],AL
017D:14CA mov BX,word ptr SS:[BP-70]
017D:14CD add BX,BP
017D:14CF mov AL,byte ptr DS:[BX-20]
017D:14D2 mov word ptr SS:[BP-40],AX
017D:14D5 mov BX,word ptr SS:[BP-76]
017D:14D8 add BX,BP
017D:14DA mov AL,byte ptr DS:[BX-20]
017D:14DD mov BX,word ptr SS:[BP-70]
017D:14E0 add BX,BP
017D:14E2 mov byte ptr DS:[BX-20],AL
017D:14E5 mov BX,word ptr SS:[BP-76]
017D:14E8 add BX,BP
017D:14EA mov AL,byte ptr SS:[BP-40]
017D:14ED mov byte ptr DS:[BX-20],AL
017D:14F0 jmp near 0x1434
017D:14F3 inc word ptr SS:[BP-76]
017D:14F6 mov AX,word ptr SS:[BP-6]
017D:14F9 cmp word ptr SS:[BP-76],AX
017D:14FC jge short 0x1508
017D:14FE mov AX,word ptr SS:[BP-76]
017D:1501 inc AX
017D:1502 mov word ptr SS:[BP-70],AX
017D:1505 jmp near 0x1437
017D:1508 mov word ptr SS:[BP-76],0
017D:150D jmp short 0x154B
017D:150F mov AX,word ptr SS:[BP-74]
017D:1512 sub AX,0x0010
017D:1515 push AX
017D:1516 mov AX,word ptr SS:[BP-70]
017D:1519 sub AX,8
017D:151C push AX
017D:151D push word ptr SS:[BP-2]
017D:1520 push word ptr SS:[BP-4]
017D:1523 sub AX,AX
017D:1525 mov DX,0xAC00
017D:1528 push DX
017D:1529 push AX
017D:152A call far 19FC:0377
017D:1532 mov ES,word ptr DS:[0x53A0]
017D:1536 cmp word ptr ES:[0x4FBA],0
017D:153C je short 0x1548
017D:153E les BX,word ptr SS:[BP-4]
017D:1541 mov AL,byte ptr SS:[BP-68]
017D:1544 add byte ptr ES:[BX+1],AL
017D:1548 inc word ptr SS:[BP-76]
017D:154B mov AX,word ptr SS:[BP-6]
017D:154E cmp word ptr SS:[BP-76],AX
017D:1551 jle short 0x1556
017D:1553 jmp near 0x1616
017D:1556 mov SI,word ptr SS:[BP-76]
017D:1559 mov BL,byte ptr SS:[BP+SI-90]
017D:155C sub BH,BH
017D:155E shl BX,1
017D:1560 shl BX,1
017D:1562 mov ES,word ptr DS:[0x539E]
017D:1566 mov AX,word ptr ES:[BX+0x39FA]
017D:156B mov DX,word ptr ES:[BX+0x39FC]
017D:1570 mov word ptr SS:[BP-4],AX
017D:1573 mov word ptr SS:[BP-2],DX
017D:1576 shl SI,1
017D:1578 mov AX,word ptr SS:[BP+SI-38]
017D:157B mov word ptr SS:[BP-70],AX
017D:157E mov SI,word ptr SS:[BP-76]
017D:1581 shl SI,1
017D:1583 mov AX,word ptr SS:[BP+SI-58]
017D:1586 mov word ptr SS:[BP-74],AX
017D:1589 mov SI,word ptr SS:[BP-76]
017D:158C mov AL,byte ptr SS:[BP+SI-20]
017D:158F sub AH,AH
017D:1591 mov word ptr SS:[BP-68],AX
017D:1594 mov ES,word ptr DS:[0x53A0]
017D:1598 cmp word ptr ES:[0x4FBA],0
017D:159E je short 0x15AA
017D:15A0 les BX,word ptr SS:[BP-4]
017D:15A3 mov AL,byte ptr SS:[BP-68]
017D:15A6 sub byte ptr ES:[BX+1],AL
017D:15AA mov ES,word ptr DS:[0x53A0]
017D:15AE cmp word ptr ES:[0x4FBA],2
017D:15B4 jne short 0x15B9
017D:15B6 jmp near 0x150F
017D:15B9 cmp word ptr ES:[0x4FBA],0
017D:15BF jne short 0x15E4
017D:15C1 cmp word ptr SS:[BP-68],0
017D:15C5 je short 0x15E4
017D:15C7 mov ES,word ptr DS:[0x53A2]
017D:15CB mov AX,word ptr SS:[BP-74]
017D:15CE sub AX,word ptr SS:[BP-68]
017D:15D1 add AX,8
017D:15D4 mov word ptr ES:[0xB780],AX
017D:15D8 cmp AX,0x00C8
017D:15DB jle short 0x15E4
017D:15DD mov word ptr ES:[0xB780],0x00C8
017D:15E4 mov AX,word ptr SS:[BP-74]
017D:15E7 sub AX,0x0010
017D:15EA push AX
017D:15EB mov AX,word ptr SS:[BP-70]
017D:15EE sub AX,8
017D:15F1 push AX
017D:15F2 push word ptr SS:[BP-2]
017D:15F5 push word ptr SS:[BP-4]
017D:15F8 mov AX,0x244B
017D:15FB mov DX,0x1DE9
017D:15FE push DX
017D:15FF push AX
017D:1600 call far 19FC:28EB
017D:1605 add SP,0x000C
017D:1608 mov ES,word ptr DS:[0x53A2]
017D:160C mov word ptr ES:[0xB780],0x00C8
017D:1613 jmp near 0x1532
017D:1616 mov ES,word ptr DS:[0x53B0]
017D:161A cmp word ptr ES:[0x398E],0
017D:1620 jne short 0x1625
017D:1622 jmp near 0x172C
017D:1625 mov word ptr SS:[BP-76],0
017D:162A jmp short 0x165A
017D:162C mov AX,word ptr SS:[BP-74]
017D:162F mov CL,3
017D:1631 shl AX,CL
017D:1633 push AX
017D:1634 mov AX,word ptr SS:[BP-70]
017D:1637 shl AX,CL
017D:1639 push AX
017D:163A mov ES,word ptr DS:[0x539E]
017D:163E push word ptr ES:[0x3C44]
017D:1643 push word ptr ES:[0x3C42]
017D:1648 sub AX,AX
017D:164A mov DX,0xAC00
017D:164D push DX
017D:164E push AX
017D:164F call far 19FC:0377
017D:1657 inc word ptr SS:[BP-76]
017D:165A cmp word ptr SS:[BP-76],4
017D:165E jl short 0x1663
017D:1660 jmp near 0x172C
017D:1663 mov AX,word ptr SS:[BP-76]
017D:1666 shl AX,1
017D:1668 shl AX,1
017D:166A add AX,0x0D13
017D:166D mov word ptr SS:[BP-70],AX
017D:1670 mov word ptr SS:[BP-74],0x702C
017D:1675 mov ES,word ptr DS:[0x538C]
017D:1679 sub AX,word ptr ES:[0xA44B]
017D:167E add AX,0x001A
017D:1681 mov word ptr SS:[BP-70],AX
017D:1684 mov AX,0x702C
017D:1687 mov ES,word ptr DS:[0x538E]
017D:168B sub AX,word ptr ES:[0xA44D]
017D:1690 add AX,0x000C
017D:1693 mov word ptr SS:[BP-74],AX
017D:1696 sub AX,AX
017D:1698 mov word ptr SS:[BP-80],AX
017D:169B mov word ptr SS:[BP-78],AX
017D:169E cmp word ptr SS:[BP-70],0x000D
017D:16A2 jl short 0x16AA
017D:16A4 cmp word ptr SS:[BP-70],0x0027
017D:16A8 jle short 0x16AF
017D:16AA mov word ptr SS:[BP-78],1
017D:16AF cmp word ptr SS:[BP-74],0
017D:16B3 jl short 0x16BB
017D:16B5 cmp word ptr SS:[BP-74],0x0018
017D:16B9 jle short 0x16C0
017D:16BB mov word ptr SS:[BP-80],1
017D:16C0 cmp word ptr SS:[BP-70],-115
017D:16C4 jl short 0x1657
017D:16C6 cmp word ptr SS:[BP-70],0x00A7
017D:16CB jg short 0x1657
017D:16CD cmp word ptr SS:[BP-74],0xF080
017D:16D2 jl short 0x1657
017D:16D4 cmp word ptr SS:[BP-74],0x0F98
017D:16D9 jle short 0x16DE
017D:16DB jmp near 0x1657
017D:16DE mov AX,word ptr SS:[BP-78]
017D:16E1 add AX,word ptr SS:[BP-80]
017D:16E4 je short 0x16E9
017D:16E6 jmp near 0x1657
017D:16E9 and word ptr SS:[BP-70],0x007F
017D:16ED and word ptr SS:[BP-74],0x007F
017D:16F1 mov ES,word ptr DS:[0x53A0]
017D:16F5 cmp word ptr ES:[0x4FBA],2
017D:16FB jne short 0x1700
017D:16FD jmp near 0x162C
017D:1700 mov AX,word ptr SS:[BP-74]
017D:1703 mov CL,3
017D:1705 shl AX,CL
017D:1707 push AX
017D:1708 mov AX,word ptr SS:[BP-70]
017D:170B shl AX,CL
017D:170D push AX
017D:170E mov ES,word ptr DS:[0x539E]
017D:1712 push word ptr ES:[0x3C44]
017D:1717 push word ptr ES:[0x3C42]
017D:171C mov AX,0x244B
017D:171F mov DX,0x1DE9
017D:1722 push DX
017D:1723 push AX
017D:1724 call far 19FC:28EB
017D:172C pop SI
017D:172D pop DI
017D:172E mov SP,BP
017D:1730 pop BP
017D:1731 ret far
017D:1732 push BP
017D:1733 mov BP,SP
017D:1735 mov AX,2
017D:1738 call far 19FC:2FDC
017D:173D push SI
017D:173E mov word ptr SS:[BP-2],0xFFFF
017D:1743 jmp short 0x1798
017D:1745 cmp AX,0xFFFD
017D:1748 je short 0x1776
017D:174A cmp AX,0xFFFE
017D:174D je short 0x1761
017D:174F cmp AX,0xFFFF
017D:1752 jne short 0x1798
017D:1754 mov BX,word ptr SS:[BP+6]
017D:1757 shl BX,1
017D:1759 shl BX,1
017D:175B dec word ptr DS:[BX+0x01F6]
017D:175F jmp short 0x1798
017D:1761 mov SI,word ptr SS:[BP+6]
017D:1764 mov CL,2
017D:1766 shl SI,CL
017D:1768 add SI,0x01F6
017D:176C les BX,word ptr DS:[SI]
017D:176E mov AL,byte ptr ES:[BX]
017D:1771 cbw
017D:1772 sub word ptr DS:[SI],AX
017D:1774 jmp short 0x1798
017D:1776 mov BX,word ptr SS:[BP+6]
017D:1779 shl BX,1
017D:177B shl BX,1
017D:177D mov SI,word ptr DS:[BX+0x01F6]
017D:1781 inc word ptr DS:[BX+0x01F6]
017D:1785 mov ES,word ptr DS:[BX+0x01F8]
017D:1789 mov AL,byte ptr ES:[SI]
017D:178C mov BX,word ptr SS:[BP+6]
017D:178F mov ES,word ptr DS:[0x53BE]
017D:1793 mov byte ptr ES:[BX+0x396C],AL
017D:1798 mov BX,word ptr SS:[BP+6]
017D:179B shl BX,1
017D:179D shl BX,1
017D:179F mov SI,word ptr DS:[BX+0x01F6]
017D:17A3 inc word ptr DS:[BX+0x01F6]
017D:17A7 mov ES,word ptr DS:[BX+0x01F8]
017D:17AB mov AL,byte ptr ES:[SI]
017D:17AE cbw
017D:17AF mov word ptr SS:[BP-2],AX
017D:17B2 or AX,AX
017D:17B4 jl short 0x1745
017D:17B6 pop SI
017D:17B7 mov SP,BP
017D:17B9 pop BP
017D:17BA ret far
017D:17BB push BP
017D:17BC mov BP,SP
017D:17BE xor AX,AX
017D:17C0 call far 19FC:2FDC
017D:17C5 jmp short 0x17CC
017D:17C7 call far 19FC:158C
017D:17CC mov ES,word ptr DS:[0x538E]
017D:17D0 mov AX,word ptr ES:[0xA44D]
017D:17D4 cmp word ptr SS:[BP+8],AX
017D:17D7 jb short 0x17C7
017D:17D9 jmp short 0x17E0
017D:17DB call far 19FC:163B
017D:17E0 mov ES,word ptr DS:[0x538E]
017D:17E4 mov AX,word ptr ES:[0xA44D]
017D:17E8 cmp word ptr SS:[BP+8],AX
017D:17EB ja short 0x17DB
017D:17ED jmp short 0x17F4
017D:17EF call far 19FC:16E3
017D:17F4 mov ES,word ptr DS:[0x538C]
017D:17F8 mov AX,word ptr ES:[0xA44B]
017D:17FC cmp word ptr SS:[BP+6],AX
017D:17FF jb short 0x17EF
017D:1801 jmp short 0x1808
017D:1803 call far 19FC:17C5
017D:1808 mov ES,word ptr DS:[0x538C]
017D:180C mov AX,word ptr ES:[0xA44B]
017D:1810 cmp word ptr SS:[BP+6],AX
017D:1813 ja short 0x1803
017D:1815 pop BP
017D:1816 ret far
017D:186F push BP
017D:1870 mov BP,SP
017D:1872 xor AX,AX
017D:1874 call far 19FC:2FDC
017D:1879 jmp short 0x1893
017D:187B mov ES,word ptr DS:[0x538E]
017D:187F dec word ptr ES:[0xA44D]
017D:1884 mov AL,byte ptr ES:[0xA44D]
017D:1888 test AL,0x80
017D:188A je short 0x1893
017D:188C and word ptr ES:[0xA44D],0xF07F
017D:1893 mov ES,word ptr DS:[0x538E]
017D:1897 mov AX,word ptr SS:[BP+8]
017D:189A cmp word ptr ES:[0xA44D],AX
017D:189F ja short 0x187B
017D:18A1 jmp short 0x18BB
017D:18A3 mov ES,word ptr DS:[0x538E]
017D:18A7 inc word ptr ES:[0xA44D]
017D:18AC mov AL,byte ptr ES:[0xA44D]
017D:18B0 test AL,0x80
017D:18B2 je short 0x18BB
017D:18B4 add word ptr ES:[0xA44D],0x0F80
017D:18BB mov ES,word ptr DS:[0x538E]
017D:18BF mov AX,word ptr SS:[BP+8]
017D:18C2 cmp word ptr ES:[0xA44D],AX
017D:18C7 jb short 0x18A3
017D:18C9 jmp short 0x18E3
017D:18CB mov ES,word ptr DS:[0x538C]
017D:18CF dec word ptr ES:[0xA44B]
017D:18D4 mov AL,byte ptr ES:[0xA44B]
017D:18D8 test AL,0x80
017D:18DA je short 0x18E3
017D:18DC and word ptr ES:[0xA44B],0x0F7F
017D:18E3 mov ES,word ptr DS:[0x538C]
017D:18E7 mov AX,word ptr SS:[BP+6]
017D:18EA cmp word ptr ES:[0xA44B],AX
017D:18EF ja short 0x18CB
017D:18F1 jmp short 0x190B
017D:18F3 mov ES,word ptr DS:[0x538C]
017D:18F7 inc word ptr ES:[0xA44B]
017D:18FC mov AL,byte ptr ES:[0xA44B]
017D:1900 test AL,0x80
017D:1902 je short 0x190B
017D:1904 add word ptr ES:[0xA44B],0x0080
017D:190B mov ES,word ptr DS:[0x538C]
017D:190F mov AX,word ptr SS:[BP+6]
017D:1912 cmp word ptr ES:[0xA44B],AX
017D:1917 jb short 0x18F3
017D:1919 pop BP
017D:191A ret far
017D:191B push BP
017D:191C mov BP,SP
017D:191E xor AX,AX
017D:1920 call far 19FC:2FDC
017D:1925 cmp word ptr SS:[BP+8],0
017D:1929 jge short 0x196B
017D:192B jmp short 0x1948
017D:192D mov ES,word ptr DS:[0x538E]
017D:1931 dec word ptr ES:[0xA44D]
017D:1936 mov AL,byte ptr ES:[0xA44D]
017D:193A test AL,0x80
017D:193C je short 0x1945
017D:193E and word ptr ES:[0xA44D],0xF07F
017D:1945 inc word ptr SS:[BP+8]
017D:1948 cmp word ptr SS:[BP+8],0
017D:194C jne short 0x192D
017D:194E jmp short 0x196B
017D:1950 mov ES,word ptr DS:[0x538E]
017D:1954 inc word ptr ES:[0xA44D]
017D:1959 mov AL,byte ptr ES:[0xA44D]
017D:195D test AL,0x80
017D:195F je short 0x1968
017D:1961 add word ptr ES:[0xA44D],0x0F80
017D:1968 dec word ptr SS:[BP+8]
017D:196B cmp word ptr SS:[BP+8],0
017D:196F jne short 0x1950
017D:1971 cmp word ptr SS:[BP+6],0
017D:1975 jge short 0x19B7
017D:1977 jmp short 0x1994
017D:1979 mov ES,word ptr DS:[0x538C]
017D:197D dec word ptr ES:[0xA44B]
017D:1982 mov AL,byte ptr ES:[0xA44B]
017D:1986 test AL,0x80
017D:1988 je short 0x1991
017D:198A and word ptr ES:[0xA44B],0x0F7F
017D:1991 inc word ptr SS:[BP+6]
017D:1994 cmp word ptr SS:[BP+6],0
017D:1998 jne short 0x1979
017D:199A jmp short 0x19B7
017D:199C mov ES,word ptr DS:[0x538C]
017D:19A0 inc word ptr ES:[0xA44B]
017D:19A5 mov AL,byte ptr ES:[0xA44B]
017D:19A9 test AL,0x80
017D:19AB je short 0x19B4
017D:19AD add word ptr ES:[0xA44B],0x0080
017D:19B4 dec word ptr SS:[BP+6]
017D:19B7 cmp word ptr SS:[BP+6],0
017D:19BB jne short 0x199C
017D:19BD pop BP
017D:19BE ret far
017D:19BF push BP
017D:19C0 mov BP,SP
017D:19C2 xor AX,AX
017D:19C4 call far 19FC:2FDC
017D:19DD xor AX,AX
017D:19DF call far 19FC:2FDC
017D:19E4 push SI
017D:19E5 push CS
017D:19E6 call near 0x19F3
017D:19E9 mov SI,AX
017D:19EB push CS
017D:19EC call near 0x19F3
017D:19EF add AX,SI
017D:19F1 pop SI
017D:19F2 ret far
017D:19F3 push BP
017D:19F4 mov BP,SP
017D:19F6 mov AX,2
017D:19F9 call far 19FC:2FDC
017D:19FE call far 19FC:0BC0
017D:1A03 and AX,7
017D:1A06 mov word ptr SS:[BP-2],AX
017D:1A09 cmp AX,5
017D:1A0C jg short 0x19FE
017D:1A0E inc AX
017D:1A0F mov SP,BP
017D:1A11 pop BP
017D:1A12 ret far
017D:1A13 push BP
017D:1A14 mov BP,SP
017D:1A16 mov AX,0x000A
017D:1A19 call far 19FC:2FDC
017D:1A1E mov ES,word ptr DS:[0x5388]
017D:1A22 mov AX,word ptr ES:[0x37FE]
017D:1A26 mov word ptr SS:[BP-2],AX
017D:1A29 mov word ptr SS:[BP-10],0
017D:1A2E cmp word ptr SS:[BP+6],0
017D:1A32 je short 0x1A3E
017D:1A34 mov word ptr SS:[BP-10],1
017D:1A39 mov AX,0x03EE
017D:1A3C jmp short 0x1A41
017D:1A3E mov AX,0x03FE
017D:1A41 push DS
017D:1A42 push AX
017D:1A43 call far 17D3:03F5
017D:1A48 add SP,4
017D:1A4B mov ES,word ptr DS:[0x53C0]
017D:1A4F mov AX,word ptr ES:[0x374E]
017D:1A53 mov word ptr SS:[BP-6],AX
017D:1A56 mov word ptr SS:[BP-4],0
017D:1A5B push CS
017D:1A5C call near 0x2A2B
017D:1A5F jmp near 0x1AE2
017D:1A62 call far 18BA:0259
017D:1A67 mov word ptr SS:[BP-8],AX
017D:1A6A push AX
017D:1A6B call far 17D3:0D1D
017D:1A70 add SP,2
017D:1A73 mov word ptr SS:[BP-8],AX
017D:1A76 cmp AX,0x0020
017D:1A79 je short 0x1AB8
017D:1A7B jg short 0x1ABF
017D:1A7D cmp AX,0xFFB3
017D:1A80 je short 0x1AB1
017D:1A82 cmp AX,0xFFB5
017D:1A85 je short 0x1A93
017D:1A87 cmp AX,0x000D
017D:1A8A je short 0x1AB8
017D:1A8C jmp short 0x1A98
017D:1A8E mov word ptr SS:[BP-4],1
017D:1A93 mov word ptr SS:[BP-10],1
017D:1A98 mov ES,word ptr DS:[0x53C0]
017D:1A9C dec word ptr ES:[0x374E]
017D:1AA1 cmp word ptr SS:[BP-10],0
017D:1AA5 je short 0x1AD5
017D:1AA7 mov AX,0x03EE
017D:1AAA jmp short 0x1AD8
017D:1AAC mov word ptr SS:[BP-4],1
017D:1AB1 mov word ptr SS:[BP-10],0
017D:1AB6 jmp short 0x1A98
017D:1AB8 mov word ptr SS:[BP-4],1
017D:1ABD jmp short 0x1A98
017D:1ABF cmp AX,0x004E
017D:1AC2 je short 0x1AAC
017D:1AC4 cmp AX,0x0059
017D:1AC7 je short 0x1A8E
017D:1AC9 cmp AX,0x006E
017D:1ACC je short 0x1AAC
017D:1ACE cmp AX,0x0079
017D:1AD1 je short 0x1A8E
017D:1AD3 jmp short 0x1A98
017D:1AD5 mov AX,0x03FE
017D:1AD8 push DS
017D:1AD9 push AX
017D:1ADA call far 17D3:03F5
017D:1ADF add SP,4
017D:1AE2 cmp word ptr SS:[BP-4],0
017D:1AE6 jne short 0x1AEB
017D:1AE8 jmp near 0x1A62
017D:1AEB mov ES,word ptr DS:[0x5388]
017D:1AEF mov AX,word ptr SS:[BP-2]
017D:1AF2 mov word ptr ES:[0x37FE],AX
017D:1AF6 mov AX,word ptr SS:[BP-10]
017D:1AF9 mov SP,BP
017D:1AFB pop BP
017D:1AFC ret far
017D:1AFD push BP
017D:1AFE mov BP,SP
017D:1B00 mov AX,8
017D:1B03 call far 19FC:2FDC
017D:1B08 mov word ptr SS:[BP-6],0x244B
017D:1B0D mov word ptr SS:[BP-4],0x1DE9
017D:1B12 push word ptr SS:[BP-4]
017D:1B15 push word ptr SS:[BP-6]
017D:1B18 mov ES,word ptr DS:[0x53C2]
017D:1B1C push word ptr ES:[0x0066]
017D:1B21 push word ptr ES:[0x0064]
017D:1B26 call far 19FC:23EC
017D:1B2B add SP,8
017D:1B2E mov word ptr SS:[BP-8],AX
017D:1B31 mov ES,word ptr DS:[0x53A0]
017D:1B35 cmp word ptr ES:[0x4FBA],0
017D:1B3B jne short 0x1B65
017D:1B3D mov AX,0x0790
017D:1B40 push AX
017D:1B41 mov AX,0x0016
017D:1B44 push AX
017D:1B45 mov AX,0x336B
017D:1B48 mov DX,0x1DE9
017D:1B4B push DX
017D:1B4C push AX
017D:1B4D push word ptr SS:[BP-4]
017D:1B50 push word ptr SS:[BP-6]
017D:1B53 call far 19FC:0163
017D:1B65 mov ES,word ptr DS:[0x53A0]
017D:1B69 cmp word ptr ES:[0x4FBA],2
017D:1B6F jge short 0x1B94
017D:1B71 sub AX,AX
017D:1B73 push AX
017D:1B74 mov AX,0x0058
017D:1B77 push AX
017D:1B78 mov AX,0x000B
017D:1B7B push AX
017D:1B7C mov AX,8
017D:1B7F push AX
017D:1B80 mov AX,1
017D:1B83 push AX
017D:1B84 push word ptr SS:[BP-4]
017D:1B87 push word ptr SS:[BP-6]
017D:1B8A call far 18BA:0086
017D:1B94 mov ES,word ptr DS:[0x53A0]
017D:1B98 cmp word ptr ES:[0x4FBA],2
017D:1B9E jne short 0x1BB9
017D:1BA0 mov AX,0x0790
017D:1BA3 push AX
017D:1BA4 mov AX,0x336B
017D:1BA7 mov DX,0x1DE9
017D:1BAA push DX
017D:1BAB push AX
017D:1BAC mov AX,0x244B
017D:1BAF push DX
017D:1BB0 push AX
017D:1BB1 call far 19FC:0572
017D:1BB9 call far 19FC:1E37
017D:1BBE mov ES,word ptr DS:[0x53C2]
017D:1BC2 mov AX,word ptr SS:[BP-8]
017D:1BC5 add word ptr ES:[0x0064],AX
017D:1BCA mov ES,word ptr DS:[0x53C4]
017D:1BCE mov BX,word ptr ES:[0xE48A]
017D:1BD3 mov ES,word ptr DS:[0x53C6]
017D:1BD7 mov AL,byte ptr ES:[BX+0x42C3]
017D:1BDC cbw
017D:1BDD sub AX,0x0041
017D:1BE0 mov word ptr SS:[BP-2],AX
017D:1BE3 mov BX,AX
017D:1BE5 mov AL,byte ptr ES:[BX+0x42E3]
017D:1BEA imul byte ptr ES:[0x42F5]
017D:1BEF mov word ptr SS:[BP-2],AX
017D:1BF2 mov AX,3
017D:1BF5 imul word ptr SS:[BP-2]
017D:1BF8 sar AX,1
017D:1BFA sar AX,1
017D:1BFC mov word ptr SS:[BP-2],AX
017D:1BFF push AX
017D:1C00 call far 18BA:0006
017D:1C05 mov ES,word ptr DS:[0x53C4]
017D:1C09 inc word ptr ES:[0xE48A]
017D:1C0E mov SP,BP
017D:1C10 pop BP
017D:1C11 ret far
017D:1C12 push BP
017D:1C13 mov BP,SP
017D:1C15 mov AX,0x001A
017D:1C18 call far 19FC:2FDC
017D:1C1D push DI
017D:1C1E push SI
017D:1C1F mov word ptr SS:[BP-4],0
017D:1C24 mov ES,word ptr DS:[0x538C]
017D:1C28 mov AX,word ptr ES:[0xA44B]
017D:1C2C and AX,0x000F
017D:1C2F mov word ptr SS:[BP-24],AX
017D:1C32 mov ES,word ptr DS:[0x538E]
017D:1C36 mov AX,word ptr ES:[0xA44D]
017D:1C3A and AX,0x000F
017D:1C3D mov word ptr SS:[BP-26],AX
017D:1C40 mov word ptr SS:[BP-22],0
017D:1C45 cmp word ptr SS:[BP+8],0
017D:1C49 jge short 0x1C54
017D:1C4B or AX,AX
017D:1C4D jne short 0x1C54
017D:1C4F mov word ptr SS:[BP-22],8
017D:1C54 cmp word ptr SS:[BP+8],0
017D:1C58 jle short 0x1C64
017D:1C5A cmp word ptr SS:[BP-26],0x000F
017D:1C5E jne short 0x1C64
017D:1C60 or byte ptr SS:[BP-22],4
017D:1C64 cmp word ptr SS:[BP+6],0
017D:1C68 jge short 0x1C74
017D:1C6A cmp word ptr SS:[BP-24],0
017D:1C6E jne short 0x1C74
017D:1C70 or byte ptr SS:[BP-22],2
017D:1C74 cmp word ptr SS:[BP+6],0
017D:1C78 jle short 0x1C85
017D:1C7A cmp word ptr SS:[BP-24],0x000F
017D:1C7E jne short 0x1C85
017D:1C80 or word ptr SS:[BP-22],1
017D:1C85 cmp word ptr SS:[BP-22],0
017D:1C89 je short 0x1CC1
017D:1C8B mov BX,word ptr SS:[BP-22]
017D:1C8E mov AL,byte ptr DS:[BX+0x04A0]
017D:1C92 cbw
017D:1C93 mov BX,AX
017D:1C95 mov ES,word ptr DS:[0x53C8]
017D:1C99 cmp byte ptr ES:[BX+0x07A4],0x0F
017D:1C9F jne short 0x1CC1
017D:1CA1 mov ES,word ptr DS:[0x5386]
017D:1CA5 mov AX,1
017D:1CA8 mov word ptr ES:[0xD55C],AX
017D:1CAC mov word ptr SS:[BP-4],AX
017D:1CAF call far 1650:17C6
017D:1CC1 cmp word ptr SS:[BP-4],0
017D:1CC5 je short 0x1CCA
017D:1CC7 jmp near 0x2186
017D:1CCA mov word ptr SS:[BP-18],0
017D:1CCF jmp short 0x1D19
017D:1CD1 cmp word ptr SS:[BP-16],0x0094
017D:1CD6 jne short 0x1CDD
017D:1CD8 call far 0CDA:079C
017D:1CDD cmp word ptr SS:[BP-16],0x0097
017D:1CE2 jl short 0x1CF9
017D:1CE4 cmp word ptr SS:[BP-16],0x00F0
017D:1CE9 jg short 0x1CF9
017D:1CEB push word ptr SS:[BP-6]
017D:1CEE push word ptr SS:[BP-2]
017D:1CF1 call far 0CDA:0913
017D:1CF9 cmp word ptr SS:[BP-16],0x008C
017D:1CFE je short 0x1D07
017D:1D00 cmp word ptr SS:[BP-16],0x008D
017D:1D05 jne short 0x1D0C
017D:1D07 call far 0CDA:0980
017D:1D0C mov word ptr SS:[BP-4],1
017D:1D11 mov word ptr SS:[BP-18],8
017D:1D16 inc word ptr SS:[BP-18]
017D:1D19 cmp word ptr SS:[BP-18],8
017D:1D1D jl short 0x1D22
017D:1D1F jmp near 0x1FBE
017D:1D22 mov SI,word ptr SS:[BP-18]
017D:1D25 shl SI,1
017D:1D27 mov ES,word ptr DS:[0x5392]
017D:1D2B cmp word ptr ES:[SI+0x4072],0
017D:1D31 je short 0x1D16
017D:1D33 mov AX,word ptr DS:[SI+0x0464]
017D:1D37 add AX,word ptr SS:[BP+6]
017D:1D3A add AX,0x001A
017D:1D3D mov word ptr SS:[BP-8],AX
017D:1D40 mov AX,word ptr DS:[SI+0x047C]
017D:1D44 add AX,word ptr SS:[BP+8]
017D:1D47 add AX,0x000C
017D:1D4A mov word ptr SS:[BP-10],AX
017D:1D4D mov BX,AX
017D:1D4F and BL,0xFE
017D:1D52 mov AX,word ptr DS:[BX+0x048C]
017D:1D56 mov CX,word ptr SS:[BP-8]
017D:1D59 sub CX,0x000D
017D:1D5C sar CX,1
017D:1D5E add AX,CX
017D:1D60 mov word ptr SS:[BP-12],AX
017D:1D63 test byte ptr SS:[BP-8],1
017D:1D67 jne short 0x1D78
017D:1D69 mov ES,word ptr DS:[0x538C]
017D:1D6D test byte ptr ES:[0xA44B],1
017D:1D73 je short 0x1D78
017D:1D75 inc word ptr SS:[BP-12]
017D:1D78 test byte ptr SS:[BP-10],1
017D:1D7C je short 0x1D8E
017D:1D7E mov ES,word ptr DS:[0x538E]
017D:1D82 test byte ptr ES:[0xA44D],1
017D:1D88 je short 0x1D8E
017D:1D8A add word ptr SS:[BP-12],0x0018
017D:1D8E mov ES,word ptr DS:[0x5394]
017D:1D92 mov BX,word ptr ES:[0x09ED]
017D:1D97 add BX,word ptr SS:[BP-12]
017D:1D9A mov ES,word ptr DS:[0x5396]
017D:1D9E mov AL,byte ptr ES:[BX+0x07AD]
017D:1DA3 sub AH,AH
017D:1DA5 mov word ptr SS:[BP-16],AX
017D:1DA8 mov ES,word ptr DS:[0x538A]
017D:1DAC cmp byte ptr ES:[0xD346],AH
017D:1DB1 je short 0x1DB6
017D:1DB3 jmp near 0x1E6F
017D:1DB6 mov ES,word ptr DS:[0x5386]
017D:1DBA cmp word ptr ES:[0xD55C],0
017D:1DC0 je short 0x1DC5
017D:1DC2 jmp near 0x1E6F
017D:1DC5 mov word ptr SS:[BP-20],0
017D:1DCA mov SI,word ptr SS:[BP-20]
017D:1DCD shl SI,1
017D:1DCF mov DI,word ptr SS:[BP-18]
017D:1DD2 shl DI,1
017D:1DD4 mov ES,word ptr DS:[0x53A4]
017D:1DD8 mov AX,word ptr ES:[DI+0x400C]
017D:1DDD add AX,word ptr SS:[BP+6]
017D:1DE0 mov ES,word ptr DS:[0x53CA]
017D:1DE4 cmp AX,word ptr ES:[SI+0x4564]
017D:1DE9 jne short 0x1E63
017D:1DEB mov ES,word ptr DS:[0x53A6]
017D:1DEF mov AX,word ptr ES:[DI+0x403E]
017D:1DF4 add AX,word ptr SS:[BP+8]
017D:1DF7 mov ES,word ptr DS:[0x53CC]
017D:1DFB cmp AX,word ptr ES:[SI+0x4596]
017D:1E00 jne short 0x1E63
017D:1E02 mov ES,word ptr DS:[0x5386]
017D:1E06 mov word ptr ES:[0xD55C],1
017D:1E0D call far 1650:17C6
017D:1E63 inc word ptr SS:[BP-20]
017D:1E66 cmp word ptr SS:[BP-20],0x000C
017D:1E6A jge short 0x1E6F
017D:1E6C jmp near 0x1DCA
017D:1E6F mov AX,word ptr DS:[0x0150]
017D:1E72 cmp word ptr SS:[BP-16],AX
017D:1E75 jge short 0x1E7A
017D:1E77 jmp near 0x1D16
017D:1E7A mov ES,word ptr DS:[0x538A]
017D:1E7E cmp byte ptr ES:[0xD346],0
017D:1E84 jne short 0x1E89
017D:1E86 jmp near 0x1D0C
017D:1E89 mov SI,word ptr SS:[BP-18]
017D:1E8C shl SI,1
017D:1E8E mov AX,word ptr DS:[SI+0x0464]
017D:1E92 add AX,word ptr SS:[BP+6]
017D:1E95 mov ES,word ptr DS:[0x538C]
017D:1E99 add AX,word ptr ES:[0xA44B]
017D:1E9E mov word ptr SS:[BP-2],AX
017D:1EA1 mov AX,word ptr DS:[SI+0x047C]
017D:1EA5 add AX,word ptr SS:[BP+8]
017D:1EA8 mov ES,word ptr DS:[0x538E]
017D:1EAC add AX,word ptr ES:[0xA44D]
017D:1EB1 mov word ptr SS:[BP-6],AX
017D:1EB4 mov ES,word ptr DS:[0x538A]
017D:1EB8 cmp byte ptr ES:[0xD34E],0
017D:1EBE je short 0x1EC3
017D:1EC0 jmp near 0x1CD1
017D:1EC3 cmp word ptr SS:[BP-16],0x007E
017D:1EC7 jne short 0x1EDB
017D:1EC9 mov AX,0xFFFF
017D:1ECC push AX
017D:1ECD push word ptr SS:[BP-6]
017D:1ED0 push word ptr SS:[BP-2]
017D:1ED3 call far 0CDA:0AB6
017D:1EDB cmp word ptr SS:[BP-16],0x007F
017D:1EDF jne short 0x1EF6
017D:1EE1 mov AX,0xFFFF
017D:1EE4 push AX
017D:1EE5 push word ptr SS:[BP-6]
017D:1EE8 mov AX,word ptr SS:[BP-2]
017D:1EEB dec AX
017D:1EEC dec AX
017D:1EED push AX
017D:1EEE call far 0CDA:0AB6
017D:1EF6 cmp word ptr SS:[BP-16],0x0080
017D:1EFB jne short 0x1F13
017D:1EFD mov AX,0xFFFF
017D:1F00 push AX
017D:1F01 push word ptr SS:[BP-6]
017D:1F04 mov AX,word ptr SS:[BP-2]
017D:1F07 sub AX,4
017D:1F0A push AX
017D:1F0B call far 0CDA:0AB6
017D:1F13 cmp word ptr SS:[BP-16],0x00F5
017D:1F18 jne short 0x1F34
017D:1F1A cmp word ptr SS:[BP-2],0x0C01
017D:1F1F jb short 0x1F34
017D:1F21 cmp word ptr SS:[BP-2],0x0C04
017D:1F26 ja short 0x1F34
017D:1F28 cmp word ptr SS:[BP-6],0xC054
017D:1F2D jne short 0x1F34
017D:1F2F call far 0CDA:01E9
017D:1F34 cmp word ptr SS:[BP-16],0x00B6
017D:1F39 je short 0x1F42
017D:1F3B cmp word ptr SS:[BP-16],0x00B7
017D:1F40 jne short 0x1F50
017D:1F42 push word ptr SS:[BP-6]
017D:1F45 push word ptr SS:[BP-2]
017D:1F48 call far 0CDA:03AA
017D:1F50 cmp word ptr SS:[BP-16],0x00F6
017D:1F55 jl short 0x1F5C
017D:1F57 call far 0CDA:0288
017D:1F5C cmp word ptr SS:[BP-16],0x0083
017D:1F61 je short 0x1F71
017D:1F63 cmp word ptr SS:[BP-16],0x00A5
017D:1F68 jl short 0x1F76
017D:1F6A cmp word ptr SS:[BP-16],0x00A7
017D:1F6F jg short 0x1F76
017D:1F71 call far 0CDA:02A8
017D:1F76 cmp word ptr SS:[BP-16],0x004D
017D:1F7A jne short 0x1F8A
017D:1F7C push word ptr SS:[BP-6]
017D:1F7F push word ptr SS:[BP-2]
017D:1F82 call far 0CDA:04AB
017D:1F8A cmp word ptr SS:[BP-16],0x003A
017D:1F8E je short 0x1F96
017D:1F90 cmp word ptr SS:[BP-16],0x003D
017D:1F94 jne short 0x1FA4
017D:1F96 push word ptr SS:[BP-6]
017D:1F99 push word ptr SS:[BP-2]
017D:1F9C call far 0CDA:02D2
017D:1FA4 cmp word ptr SS:[BP-16],0x0028
017D:1FA8 je short 0x1FAD
017D:1FAA jmp near 0x1D0C
017D:1FAD push word ptr SS:[BP-6]
017D:1FB0 push word ptr SS:[BP-2]
017D:1FB3 call far 0CDA:055A
017D:1FBE cmp word ptr SS:[BP-4],0
017D:1FC2 je short 0x1FC7
017D:1FC4 jmp near 0x2186
017D:1FC7 mov word ptr SS:[BP-18],0
017D:1FCC jmp near 0x20E9
017D:1FCF mov AL,byte ptr SS:[BP-8]
017D:1FD2 mov ES,word ptr DS:[0x538C]
017D:1FD6 xor AL,byte ptr ES:[0xA44B]
017D:1FDB test AL,1
017D:1FDD je short 0x1FE4
017D:1FDF dec word ptr SS:[BP-12]
017D:1FE2 jmp short 0x1FE7
017D:1FE4 inc word ptr SS:[BP-12]
017D:1FE7 mov ES,word ptr DS:[0x5394]
017D:1FEB mov BX,word ptr ES:[0x09ED]
017D:1FF0 add BX,word ptr SS:[BP-12]
017D:1FF3 mov ES,word ptr DS:[0x5396]
017D:1FF7 mov AL,byte ptr ES:[BX+0x07AD]
017D:1FFC sub AH,AH
017D:1FFE cmp AX,word ptr DS:[0x0150]
017D:2002 jb short 0x2009
017D:2004 mov word ptr SS:[BP-4],1
017D:2009 mov ES,word ptr DS:[0x5386]
017D:200D cmp word ptr ES:[0xD55C],0
017D:2013 je short 0x2018
017D:2015 jmp near 0x20DB
017D:2018 mov word ptr SS:[BP-20],0
017D:201D mov SI,word ptr SS:[BP-20]
017D:2020 shl SI,1
017D:2022 mov DI,word ptr SS:[BP-18]
017D:2025 shl DI,1
017D:2027 mov ES,word ptr DS:[0x53A6]
017D:202B mov AX,word ptr ES:[DI+0x4036]
017D:2030 add AX,word ptr SS:[BP+8]
017D:2033 mov ES,word ptr DS:[0x53CC]
017D:2037 cmp AX,word ptr ES:[SI+0x4596]
017D:203C je short 0x2041
017D:203E jmp near 0x20CF
017D:2041 mov ES,word ptr DS:[0x53A4]
017D:2045 mov AX,word ptr ES:[DI+0x4004]
017D:204A add AX,word ptr SS:[BP+6]
017D:204D mov word ptr SS:[BP-14],AX
017D:2050 mov ES,word ptr DS:[0x53CA]
017D:2054 cmp word ptr ES:[SI+0x4564],AX
017D:2059 je short 0x206E
017D:205B dec AX
017D:205C cmp word ptr ES:[SI+0x4564],AX
017D:2061 je short 0x206E
017D:2063 mov AX,word ptr SS:[BP-14]
017D:2066 inc AX
017D:2067 cmp word ptr ES:[SI+0x4564],AX
017D:206C jne short 0x20CF
017D:206E mov ES,word ptr DS:[0x5386]
017D:2072 mov word ptr ES:[0xD55C],1
017D:2079 call far 1650:17C6
017D:20CF inc word ptr SS:[BP-20]
017D:20D2 cmp word ptr SS:[BP-20],0x000C
017D:20D6 jge short 0x20DB
017D:20D8 jmp near 0x201D
017D:20DB cmp word ptr SS:[BP-4],0
017D:20DF je short 0x20E6
017D:20E1 mov word ptr SS:[BP-18],8
017D:20E6 inc word ptr SS:[BP-18]
017D:20E9 cmp word ptr SS:[BP-18],4
017D:20ED jl short 0x20F2
017D:20EF jmp near 0x2186
017D:20F2 mov SI,word ptr SS:[BP-18]
017D:20F5 shl SI,1
017D:20F7 mov ES,word ptr DS:[0x5392]
017D:20FB cmp word ptr ES:[SI+0x406A],0
017D:2101 je short 0x20E6
017D:2103 mov AX,word ptr DS:[SI+0x045C]
017D:2107 add AX,word ptr SS:[BP+6]
017D:210A add AX,0x001A
017D:210D mov word ptr SS:[BP-8],AX
017D:2110 mov AX,word ptr DS:[SI+0x0474]
017D:2114 add AX,word ptr SS:[BP+8]
017D:2117 add AX,0x000C
017D:211A mov word ptr SS:[BP-10],AX
017D:211D mov BX,AX
017D:211F and BL,0xFE
017D:2122 mov AX,word ptr DS:[BX+0x048C]
017D:2126 mov CX,word ptr SS:[BP-8]
017D:2129 sub CX,0x000D
017D:212C sar CX,1
017D:212E add AX,CX
017D:2130 mov word ptr SS:[BP-12],AX
017D:2133 test byte ptr SS:[BP-8],1
017D:2137 jne short 0x2148
017D:2139 mov ES,word ptr DS:[0x538C]
017D:213D test byte ptr ES:[0xA44B],1
017D:2143 je short 0x2148
017D:2145 inc word ptr SS:[BP-12]
017D:2148 test byte ptr SS:[BP-10],1
017D:214C je short 0x215E
017D:214E mov ES,word ptr DS:[0x538E]
017D:2152 test byte ptr ES:[0xA44D],1
017D:2158 je short 0x215E
017D:215A add word ptr SS:[BP-12],0x0018
017D:215E mov ES,word ptr DS:[0x5394]
017D:2162 mov BX,word ptr ES:[0x09ED]
017D:2167 add BX,word ptr SS:[BP-12]
017D:216A mov ES,word ptr DS:[0x5396]
017D:216E mov AL,byte ptr ES:[BX+0x07AD]
017D:2173 sub AH,AH
017D:2175 mov word ptr SS:[BP-16],AX
017D:2178 mov AX,word ptr DS:[0x0150]
017D:217B cmp word ptr SS:[BP-16],AX
017D:217E jge short 0x2183
017D:2180 jmp near 0x1FCF
017D:2183 jmp near 0x2004
017D:2186 mov AX,word ptr SS:[BP-4]
017D:2189 pop SI
017D:218A pop DI
017D:218B mov SP,BP
017D:218D pop BP
017D:218E ret far
017D:218F push BP
017D:2190 mov BP,SP
017D:2192 mov AX,8
017D:2195 call far 19FC:2FDC
017D:219A sub AX,AX
017D:219C mov word ptr SS:[BP-4],AX
017D:219F mov word ptr SS:[BP-2],AX
017D:21A2 cmp word ptr SS:[BP+6],-72
017D:21A6 je short 0x21B4
017D:21A8 cmp word ptr SS:[BP+6],-73
017D:21AC je short 0x21B4
017D:21AE cmp word ptr SS:[BP+6],-71
017D:21B2 jne short 0x21B9
017D:21B4 mov word ptr SS:[BP-4],0xFFFF
017D:21B9 cmp word ptr SS:[BP+6],-80
017D:21BD je short 0x21CB
017D:21BF cmp word ptr SS:[BP+6],-81
017D:21C3 je short 0x21CB
017D:21C5 cmp word ptr SS:[BP+6],-79
017D:21C9 jne short 0x21D0
017D:21CB mov word ptr SS:[BP-4],1
017D:21D0 cmp word ptr SS:[BP+6],-77
017D:21D4 je short 0x21E2
017D:21D6 cmp word ptr SS:[BP+6],-73
017D:21DA je short 0x21E2
017D:21DC cmp word ptr SS:[BP+6],-81
017D:21E0 jne short 0x21E7
017D:21E2 mov word ptr SS:[BP-2],1
017D:21E7 cmp word ptr SS:[BP+6],-75
017D:21EB je short 0x21F9
017D:21ED cmp word ptr SS:[BP+6],-71
017D:21F1 je short 0x21F9
017D:21F3 cmp word ptr SS:[BP+6],-79
017D:21F7 jne short 0x21FE
017D:21F9 mov word ptr SS:[BP-2],0xFFFF
017D:21FE push word ptr SS:[BP-4]
017D:2201 push word ptr SS:[BP-2]
017D:2204 push CS
017D:2205 call near 0x1C12
017D:2208 add SP,4
017D:220B or AX,AX
017D:220D je short 0x2212
017D:220F jmp near 0x22FA
017D:2212 cmp word ptr SS:[BP-4],-1
017D:2216 jne short 0x221D
017D:2218 call far 19FC:158C
017D:221D cmp word ptr SS:[BP-4],1
017D:2221 jne short 0x2228
017D:2223 call far 19FC:163B
017D:2228 mov word ptr SS:[BP-6],0
017D:222D mov BX,word ptr SS:[BP-6]
017D:2230 mov ES,word ptr DS:[0x53CE]
017D:2234 cmp byte ptr ES:[BX+0x09F3],0xFF
017D:223A je short 0x227D
017D:223C mov BL,byte ptr ES:[BX+0x09F6]
017D:2241 sub BH,BH
017D:2243 mov ES,word ptr DS:[0x53D0]
017D:2247 mov AL,byte ptr ES:[BX+0x0030]
017D:224C mov byte ptr SS:[BP-8],AL
017D:224F cmp AL,BH
017D:2251 je short 0x2270
017D:2253 cbw
017D:2254 push AX
017D:2255 mov BX,word ptr SS:[BP-6]
017D:2258 mov ES,word ptr DS:[0x53CE]
017D:225C mov AL,byte ptr ES:[BX+0x09F3]
017D:2261 sub AH,AH
017D:2263 push AX
017D:2264 push CS
017D:2265 call near 0x2DA8
017D:2270 mov BX,word ptr SS:[BP-6]
017D:2273 mov ES,word ptr DS:[0x53CE]
017D:2277 mov byte ptr ES:[BX+0x09F3],0xFF
017D:227D inc word ptr SS:[BP-6]
017D:2280 cmp word ptr SS:[BP-6],3
017D:2284 jl short 0x222D
017D:2286 cmp word ptr SS:[BP-2],1
017D:228A jne short 0x2291
017D:228C call far 19FC:17C5
017D:2291 cmp word ptr SS:[BP-2],-1
017D:2295 jne short 0x229C
017D:2297 call far 19FC:16E3
017D:229C mov word ptr SS:[BP-6],0
017D:22A1 mov BX,word ptr SS:[BP-6]
017D:22A4 mov ES,word ptr DS:[0x53CE]
017D:22A8 cmp byte ptr ES:[BX+0x09F3],0xFF
017D:22AE je short 0x22F1
017D:22B0 mov BL,byte ptr ES:[BX+0x09F6]
017D:22B5 sub BH,BH
017D:22B7 mov ES,word ptr DS:[0x53D0]
017D:22BB mov AL,byte ptr ES:[BX+0x0030]
017D:22C0 mov byte ptr SS:[BP-8],AL
017D:22C3 cmp AL,BH
017D:22C5 je short 0x22E4
017D:22C7 cbw
017D:22C8 push AX
017D:22C9 mov BX,word ptr SS:[BP-6]
017D:22CC mov ES,word ptr DS:[0x53CE]
017D:22D0 mov AL,byte ptr ES:[BX+0x09F3]
017D:22D5 sub AH,AH
017D:22D7 push AX
017D:22D8 push CS
017D:22D9 call near 0x2DA8
017D:22E4 mov BX,word ptr SS:[BP-6]
017D:22E7 mov ES,word ptr DS:[0x53CE]
017D:22EB mov byte ptr ES:[BX+0x09F3],0xFF
017D:22F1 inc word ptr SS:[BP-6]
017D:22F4 cmp word ptr SS:[BP-6],3
017D:22F8 jl short 0x22A1
017D:22FA mov ES,word ptr DS:[0x538E]
017D:22FE push word ptr ES:[0xA44D]
017D:2303 mov ES,word ptr DS:[0x538C]
017D:2307 push word ptr ES:[0xA44B]
017D:230C call far 19FC:1314
017D:2311 add SP,4
017D:2314 call far 19FC:1DF8
017D:2319 mov SP,BP
017D:231B pop BP
017D:231C ret far
017D:231D push BP
017D:231E mov BP,SP
017D:2320 mov AX,4
017D:2323 call far 19FC:2FDC
017D:2328 push SI
017D:2329 mov word ptr SS:[BP-2],0
017D:232E mov BX,word ptr SS:[BP-2]
017D:2331 shl BX,1
017D:2333 mov AX,word ptr SS:[BP+6]
017D:2336 cmp word ptr DS:[BX+0x0160],AX
017D:233A je short 0x233F
017D:233C jmp near 0x23FA
017D:233F mov word ptr SS:[BP-4],0
017D:2344 mov AX,0x007D
017D:2347 imul word ptr SS:[BP-4]
017D:234A mov BX,AX
017D:234C mov ES,word ptr DS:[0x538A]
017D:2350 cmp byte ptr ES:[BX-14556],0xFF
017D:2356 je short 0x239B
017D:2358 mov BX,word ptr SS:[BP-4]
017D:235B mov ES,word ptr DS:[0x53BE]
017D:235F mov AL,byte ptr ES:[BX+0x396C]
017D:2364 cbw
017D:2365 cmp AX,word ptr SS:[BP-2]
017D:2368 je short 0x2385
017D:236A shl BX,1
017D:236C shl BX,1
017D:236E mov SI,word ptr SS:[BP-2]
017D:2371 shl SI,1
017D:2373 shl SI,1
017D:2375 mov AX,word ptr DS:[SI+0x025A]
017D:2379 mov DX,word ptr DS:[SI+0x025C]
017D:237D mov word ptr DS:[BX+0x01F6],AX
017D:2381 mov word ptr DS:[BX+0x01F8],DX
017D:2385 push word ptr SS:[BP-4]
017D:2388 push CS
017D:2389 call near 0x1732
017D:239B inc word ptr SS:[BP-4]
017D:239E cmp word ptr SS:[BP-4],4
017D:23A2 jl short 0x2344
017D:23A4 mov word ptr SS:[BP-4],4
017D:23A9 mov BX,word ptr SS:[BP-4]
017D:23AC mov ES,word ptr DS:[0x53BE]
017D:23B0 mov AL,byte ptr ES:[BX+0x396C]
017D:23B5 cbw
017D:23B6 cmp AX,word ptr SS:[BP-2]
017D:23B9 je short 0x23D6
017D:23BB shl BX,1
017D:23BD shl BX,1
017D:23BF mov SI,word ptr SS:[BP-2]
017D:23C2 shl SI,1
017D:23C4 shl SI,1
017D:23C6 mov AX,word ptr DS:[SI+0x027A]
017D:23CA mov DX,word ptr DS:[SI+0x027C]
017D:23CE mov word ptr DS:[BX+0x01F6],AX
017D:23D2 mov word ptr DS:[BX+0x01F8],DX
017D:23D6 push word ptr SS:[BP-4]
017D:23D9 push CS
017D:23DA call near 0x1732
017D:23FA inc word ptr SS:[BP-2]
017D:23FD cmp word ptr SS:[BP-2],8
017D:2401 jge short 0x2406
017D:2403 jmp near 0x232E
017D:2406 pop SI
017D:2407 mov SP,BP
017D:2409 pop BP
017D:240A ret far
017D:240B push BP
017D:240C mov BP,SP
017D:240E mov AX,8
017D:2411 call far 19FC:2FDC
017D:2416 mov ES,word ptr DS:[0x53D2]
017D:241A cmp word ptr ES:[0x3988],0
017D:2420 je short 0x2425
017D:2422 jmp near 0x24BE
017D:2425 inc word ptr DS:[0x5800]
017D:2429 cmp word ptr DS:[0x5800],3
017D:242E jb short 0x2436
017D:2430 mov word ptr DS:[0x5800],0
017D:2436 mov AX,word ptr DS:[0x5800]
017D:2439 mov CL,7
017D:243B shl AX,CL
017D:243D add AX,0xD582
017D:2440 mov word ptr SS:[BP-4],AX
017D:2443 mov word ptr SS:[BP-2],0x2A0F
017D:2448 mov ES,word ptr DS:[0x53A0]
017D:244C cmp word ptr ES:[0x4FBA],2
017D:2452 je short 0x2490
017D:2454 mov word ptr SS:[BP-8],0
017D:2459 jmp short 0x245E
017D:245B inc word ptr SS:[BP-8]
017D:245E cmp word ptr SS:[BP-8],0x000A
017D:2462 jge short 0x24BE
017D:2464 mov BX,word ptr SS:[BP-8]
017D:2467 mov AL,byte ptr DS:[BX+0x04B0]
017D:246B cbw
017D:246C mov BX,AX
017D:246E mov CL,7
017D:2470 shl BX,CL
017D:2472 lea AX,BX+0x4614
017D:2476 mov DX,0x2A0F
017D:2479 push DX
017D:247A push AX
017D:247B push word ptr SS:[BP-2]
017D:247E push word ptr SS:[BP-4]
017D:2481 call far 19FC:28A8
017D:2486 add SP,8
017D:2489 add word ptr SS:[BP-4],0x0180
017D:248E jmp short 0x245B
017D:2490 mov word ptr SS:[BP-8],0
017D:2495 mov BX,word ptr SS:[BP-8]
017D:2498 mov AL,byte ptr DS:[BX+0x04B0]
017D:249C cbw
017D:249D mov CL,5
017D:249F shl AX,CL
017D:24A1 push AX
017D:24A2 push word ptr SS:[BP-2]
017D:24A5 push word ptr SS:[BP-4]
017D:24A8 call far 19FC:0A9F
017D:24BE mov SP,BP
017D:24C0 pop BP
017D:24C1 ret far
017D:24C2 push BP
017D:24C3 mov BP,SP
017D:24C5 mov AX,0x0010
017D:24C8 call far 19FC:2FDC
017D:24CD push DI
017D:24CE push SI
017D:24CF mov ES,word ptr DS:[0x538C]
017D:24D3 mov AX,word ptr ES:[0xA44B]
017D:24D7 mov word ptr SS:[BP-8],AX
017D:24DA mov ES,word ptr DS:[0x538E]
017D:24DE mov AX,word ptr ES:[0xA44D]
017D:24E2 mov word ptr SS:[BP-10],AX
017D:24E5 mov word ptr SS:[BP-12],0
017D:24EA jmp short 0x2555
017D:24EC cmp word ptr SS:[BP-12],0
017D:24F0 jne short 0x2504
017D:24F2 mov ES,word ptr DS:[0x538A]
017D:24F6 cmp byte ptr ES:[0xD339],0
017D:24FC je short 0x2504
017D:24FE mov byte ptr ES:[0xD399],0xFF
017D:2504 mov AX,0x001A
017D:2507 imul word ptr SS:[BP-12]
017D:250A mov SI,AX
017D:250C mov ES,word ptr DS:[0x538A]
017D:2510 dec byte ptr ES:[SI-11367]
017D:2515 jne short 0x2552
017D:2517 mov AL,byte ptr ES:[SI-11368]
017D:251C sub AH,AH
017D:251E mov CL,4
017D:2520 shr AX,CL
017D:2522 mov word ptr SS:[BP-2],AX
017D:2525 mov SI,AX
017D:2527 shl SI,1
017D:2529 mov DI,word ptr SS:[BP-12]
017D:252C shl DI,1
017D:252E mov ES,word ptr DS:[0x53CA]
017D:2532 mov AX,word ptr ES:[SI+0x4564]
017D:2537 mov ES,word ptr DS:[0x53A4]
017D:253B mov word ptr ES:[DI+0x4024],AX
017D:2540 mov ES,word ptr DS:[0x53CC]
017D:2544 mov AX,word ptr ES:[SI+0x4596]
017D:2549 mov ES,word ptr DS:[0x53A6]
017D:254D mov word ptr ES:[DI+0x4056],AX
017D:2552 inc word ptr SS:[BP-12]
017D:2555 cmp word ptr SS:[BP-12],8
017D:2559 jl short 0x255E
017D:255B jmp near 0x284B
017D:255E mov BX,word ptr SS:[BP-12]
017D:2561 mov ES,word ptr DS:[0x53B2]
017D:2565 mov byte ptr ES:[BX+0x42F6],0
017D:256B mov AX,0x001A
017D:256E imul word ptr SS:[BP-12]
017D:2571 mov BX,AX
017D:2573 mov ES,word ptr DS:[0x538A]
017D:2577 cmp byte ptr ES:[BX-11367],0
017D:257D je short 0x2582
017D:257F jmp near 0x24EC
017D:2582 mov ES,word ptr DS:[0x538C]
017D:2586 mov AX,word ptr SS:[BP-8]
017D:2589 and AX,0x0F70
017D:258C mov word ptr ES:[0xA44B],AX
017D:2590 mov ES,word ptr DS:[0x538E]
017D:2594 mov AX,word ptr SS:[BP-10]
017D:2597 and AX,0xF070
017D:259A mov word ptr ES:[0xA44D],AX
017D:259E sub AX,AX
017D:25A0 push AX
017D:25A1 mov AX,0xFFF0
017D:25A4 push AX
017D:25A5 push CS
017D:25A6 call near 0x191B
017D:25A9 add SP,4
017D:25AC mov AX,word ptr SS:[BP-12]
017D:25AF add AX,0x0010
017D:25B2 mov word ptr SS:[BP-2],AX
017D:25B5 mov BX,AX
017D:25B7 shl BX,1
017D:25B9 mov ES,word ptr DS:[0x53A4]
017D:25BD mov AX,word ptr ES:[BX+0x4004]
017D:25C2 mov word ptr SS:[BP-4],AX
017D:25C5 mov ES,word ptr DS:[0x538C]
017D:25C9 cmp word ptr ES:[0xA44B],AX
017D:25CE jae short 0x2552
017D:25D0 mov AX,word ptr SS:[BP-8]
017D:25D3 or AL,0x0F
017D:25D5 mov word ptr ES:[0xA44B],AX
017D:25D9 sub AX,AX
017D:25DB push AX
017D:25DC mov AX,0x0010
017D:25DF push AX
017D:25E0 push CS
017D:25E1 call near 0x191B
017D:25E4 add SP,4
017D:25E7 mov ES,word ptr DS:[0x538C]
017D:25EB mov AX,word ptr SS:[BP-4]
017D:25EE cmp word ptr ES:[0xA44B],AX
017D:25F3 ja short 0x25F8
017D:25F5 jmp near 0x2552
017D:25F8 mov BX,word ptr SS:[BP-2]
017D:25FB shl BX,1
017D:25FD mov ES,word ptr DS:[0x53A6]
017D:2601 mov AX,word ptr ES:[BX+0x4036]
017D:2606 mov word ptr SS:[BP-6],AX
017D:2609 mov AX,0xFFF0
017D:260C push AX
017D:260D sub AX,AX
017D:260F push AX
017D:2610 push CS
017D:2611 call near 0x191B
017D:2614 add SP,4
017D:2617 mov ES,word ptr DS:[0x538E]
017D:261B mov AX,word ptr SS:[BP-6]
017D:261E cmp word ptr ES:[0xA44D],AX
017D:2623 jb short 0x2628
017D:2625 jmp near 0x2552
017D:2628 mov AX,word ptr SS:[BP-10]
017D:262B or AL,0x0F
017D:262D mov word ptr ES:[0xA44D],AX
017D:2631 mov AX,0x0010
017D:2634 push AX
017D:2635 sub AX,AX
017D:2637 push AX
017D:2638 push CS
017D:2639 call near 0x191B
017D:263C add SP,4
017D:263F mov ES,word ptr DS:[0x538E]
017D:2643 mov AX,word ptr SS:[BP-6]
017D:2646 cmp word ptr ES:[0xA44D],AX
017D:264B ja short 0x2650
017D:264D jmp near 0x2552
017D:2650 mov BX,word ptr SS:[BP-12]
017D:2653 mov ES,word ptr DS:[0x53B2]
017D:2657 mov byte ptr ES:[BX+0x42F6],1
017D:265D mov ES,word ptr DS:[0x538C]
017D:2661 mov AX,word ptr SS:[BP-8]
017D:2664 mov word ptr ES:[0xA44B],AX
017D:2668 mov ES,word ptr DS:[0x538E]
017D:266C mov AX,word ptr SS:[BP-10]
017D:266F mov word ptr ES:[0xA44D],AX
017D:2673 mov ES,word ptr DS:[0x53D4]
017D:2677 mov AX,word ptr SS:[BP-4]
017D:267A mov word ptr ES:[0xE486],AX
017D:267E mov ES,word ptr DS:[0x53D6]
017D:2682 mov AX,word ptr SS:[BP-6]
017D:2685 mov word ptr ES:[0xE488],AX
017D:2689 mov AX,word ptr SS:[BP-4]
017D:268C mov ES,word ptr DS:[0x538C]
017D:2690 sub AX,word ptr ES:[0xA44B]
017D:2695 mov word ptr SS:[BP-14],AX
017D:2698 mov AX,word ptr SS:[BP-6]
017D:269B mov ES,word ptr DS:[0x538E]
017D:269F sub AX,word ptr ES:[0xA44D]
017D:26A4 mov word ptr SS:[BP-16],AX
017D:26A7 cmp word ptr SS:[BP-14],-128
017D:26AB jge short 0x26B2
017D:26AD add word ptr SS:[BP-14],0x0080
017D:26B2 cmp word ptr SS:[BP-14],0x0080
017D:26B7 jle short 0x26BE
017D:26B9 sub word ptr SS:[BP-14],0x0080
017D:26BE add word ptr SS:[BP-14],0x001A
017D:26C2 cmp word ptr SS:[BP-16],0xF080
017D:26C7 jge short 0x26CE
017D:26C9 add word ptr SS:[BP-16],0x0F80
017D:26CE cmp word ptr SS:[BP-16],0x0F80
017D:26D3 jle short 0x26DA
017D:26D5 sub word ptr SS:[BP-16],0x0F80
017D:26DA add word ptr SS:[BP-16],0x000C
017D:26DE mov AX,0x001A
017D:26E1 imul word ptr SS:[BP-12]
017D:26E4 mov SI,AX
017D:26E6 mov AX,1
017D:26E9 push AX
017D:26EA push word ptr SS:[BP-16]
017D:26ED push word ptr SS:[BP-14]
017D:26F0 mov ES,word ptr DS:[0x538A]
017D:26F4 push word ptr ES:[SI-11370]
017D:26F9 push word ptr ES:[SI-11372]
017D:26FE push word ptr SS:[BP-2]
017D:2701 call far 0FAE:0006
017D:2706 add SP,0x000C
017D:2709 mov SI,word ptr SS:[BP-2]
017D:270C shl SI,1
017D:270E mov ES,word ptr DS:[0x53D4]
017D:2712 mov AX,word ptr ES:[0xE486]
017D:2716 mov ES,word ptr DS:[0x53A4]
017D:271A mov word ptr ES:[SI+0x4004],AX
017D:271F mov ES,word ptr DS:[0x53D6]
017D:2723 mov AX,word ptr ES:[0xE488]
017D:2727 mov ES,word ptr DS:[0x53A6]
017D:272B mov word ptr ES:[SI+0x4036],AX
017D:2730 mov BX,word ptr SS:[BP-2]
017D:2733 mov ES,word ptr DS:[0x53BE]
017D:2737 mov AL,byte ptr ES:[BX+0x396C]
017D:273C mov ES,word ptr DS:[0x53D8]
017D:2740 cmp byte ptr ES:[BX+0x3920],AL
017D:2745 je short 0x276A
017D:2747 mov AL,byte ptr ES:[BX+0x3920]
017D:274C cbw
017D:274D mov BX,AX
017D:274F shl BX,1
017D:2751 shl BX,1
017D:2753 mov AX,word ptr DS:[BX+0x027A]
017D:2757 mov DX,word ptr DS:[BX+0x027C]
017D:275B mov BX,word ptr SS:[BP-2]
017D:275E shl BX,1
017D:2760 shl BX,1
017D:2762 mov word ptr DS:[BX+0x01F6],AX
017D:2766 mov word ptr DS:[BX+0x01F8],DX
017D:276A push word ptr SS:[BP-2]
017D:276D push CS
017D:276E call near 0x1732
017D:2771 add SP,2
017D:2774 mov BX,word ptr SS:[BP-2]
017D:2777 mov ES,word ptr DS:[0x539A]
017D:277B mov byte ptr ES:[BX+0x409A],AL
017D:2780 mov AX,0x001A
017D:2783 imul word ptr SS:[BP-12]
017D:2786 mov SI,AX
017D:2788 mov DI,word ptr SS:[BP-2]
017D:278B shl DI,1
017D:278D mov ES,word ptr DS:[0x538A]
017D:2791 mov AX,word ptr ES:[SI-11372]
017D:2796 mov ES,word ptr DS:[0x53A4]
017D:279A cmp word ptr ES:[DI+0x4004],AX
017D:279F je short 0x27A4
017D:27A1 jmp near 0x2552
017D:27A4 mov ES,word ptr DS:[0x538A]
017D:27A8 mov AX,word ptr ES:[SI-11370]
017D:27AD mov ES,word ptr DS:[0x53A6]
017D:27B1 cmp word ptr ES:[DI+0x4036],AX
017D:27B6 je short 0x27BB
017D:27B8 jmp near 0x2552
017D:27BB call far 19FC:0BC0
017D:284B mov ES,word ptr DS:[0x538C]
017D:284F mov AX,word ptr SS:[BP-8]
017D:2852 mov word ptr ES:[0xA44B],AX
017D:2856 mov ES,word ptr DS:[0x538E]
017D:285A mov AX,word ptr SS:[BP-10]
017D:285D mov word ptr ES:[0xA44D],AX
017D:2861 pop SI
017D:2862 pop DI
017D:2863 mov SP,BP
017D:2865 pop BP
017D:2866 ret far
017D:28A2 xor AX,AX
017D:28A4 call far 19FC:2FDC
017D:28A9 mov ES,word ptr DS:[0x5388]
017D:28AD mov word ptr ES:[0x37FE],0x000A
017D:28B4 mov ES,word ptr DS:[0x53A0]
017D:28B8 cmp word ptr ES:[0x4FBA],0
017D:28BE jne short 0x28CB
017D:28C0 mov ES,word ptr DS:[0x5388]
017D:28C4 mov word ptr ES:[0x37FE],1
017D:28CB ret far
017D:28CC push BP
017D:28CD mov BP,SP
017D:28CF xor AX,AX
017D:28D1 call far 19FC:2FDC
017D:28D6 mov AX,word ptr SS:[BP+6]
017D:28D9 mov word ptr DS:[0x014E],AX
017D:28DC mov ES,word ptr DS:[0x53DE]
017D:28E0 cmp word ptr ES:[0xD580],0
017D:28E6 jne short 0x2911
017D:28E8 sub AX,AX
017D:28EA push AX
017D:28EB call far 19FC:014C
017D:2911 pop BP
017D:2912 ret far
017D:2913 push BP
017D:2914 mov BP,SP
017D:2916 mov AX,4
017D:2919 call far 19FC:2FDC
017D:29F5 push BP
017D:29F6 mov BP,SP
017D:29F8 mov AX,8
017D:29FB call far 19FC:2FDC
017D:2A00 mov ES,word ptr DS:[0x538A]
017D:2A04 mov AL,byte ptr ES:[0xD33F]
017D:2A08 sub AH,AH
017D:2A0A mov word ptr SS:[BP-4],AX
017D:2A0D mov AL,byte ptr ES:[0xD340]
017D:2A11 mov word ptr SS:[BP-2],AX
017D:2A14 mov AH,byte ptr SS:[BP-2]
017D:2A17 sub AL,AL
017D:2A19 or AX,word ptr SS:[BP-4]
017D:2A1C mov word ptr SS:[BP-8],AX
017D:2A1F mov word ptr SS:[BP-6],0
017D:2A24 mov DX,word ptr SS:[BP-6]
017D:2A27 mov SP,BP
017D:2A29 pop BP
017D:2A2A ret far
017D:2A2B xor AX,AX
017D:2A2D call far 19FC:2FDC
017D:2A32 mov ES,word ptr DS:[0x5384]
017D:2A36 cmp word ptr ES:[0x3938],0
017D:2A3C jne short 0x2A4E
017D:2A3E jmp short 0x2A45
017D:2A40 call far 18BA:0259
017D:2A45 call far 18BA:002F
017D:2A4A or AX,AX
017D:2A4C jne short 0x2A40
017D:2A4E ret far
017D:2A69 xor AX,AX
017D:2A6B call far 19FC:2FDC
017D:2A70 mov AX,0x051B
017D:2A73 push DS
017D:2A74 push AX
017D:2A75 call far 17D3:03F5
017D:2A7A add SP,4
017D:2A7D ret far
017D:2A7E xor AX,AX
017D:2A80 call far 19FC:2FDC
017D:2A85 mov AX,0x051D
017D:2A88 push DS
017D:2A89 push AX
017D:2A8A call far 17D3:03F5
017D:2A8F add SP,4
017D:2A92 ret far
017D:2A93 push BP
017D:2A94 mov BP,SP
017D:2A96 mov AX,0x000E
017D:2A99 call far 19FC:2FDC
017D:2A9E mov ES,word ptr DS:[0x538C]
017D:2AA2 mov AX,word ptr ES:[0xA44B]
017D:2AA6 mov ES,word ptr DS:[0x538E]
017D:2AAA or AX,word ptr ES:[0xA44D]
017D:2AAF mov CL,8
017D:2AB1 shr AX,CL
017D:2AB3 mov word ptr SS:[BP-4],AX
017D:2AB6 mov word ptr SS:[BP-10],0
017D:2ABB jmp short 0x2B15
017D:2ABD mov AX,word ptr SS:[BP-8]
017D:2AC0 mov CL,3
017D:2AC2 shl AX,CL
017D:2AC4 push AX
017D:2AC5 mov AX,word ptr SS:[BP-6]
017D:2AC8 shl AX,CL
017D:2ACA push AX
017D:2ACB mov BX,word ptr SS:[BP-10]
017D:2ACE mov ES,word ptr DS:[0x538A]
017D:2AD2 mov BL,byte ptr ES:[BX-11177]
017D:2AD7 sub BH,BH
017D:2AD9 shl BX,1
017D:2ADB shl BX,1
017D:2ADD mov ES,word ptr DS:[0x539E]
017D:2AE1 push word ptr ES:[BX+0x39FC]
017D:2AE6 push word ptr ES:[BX+0x39FA]
017D:2AEB sub AX,AX
017D:2AED mov DX,0xAC00
017D:2AF0 push DX
017D:2AF1 push AX
017D:2AF2 call far 19FC:0377
017D:2B12 inc word ptr SS:[BP-10]
017D:2B15 cmp word ptr SS:[BP-10],0x0040
017D:2B19 jl short 0x2B1E
017D:2B1B jmp near 0x2C4C
017D:2B1E mov BX,word ptr SS:[BP-10]
017D:2B21 mov ES,word ptr DS:[0x538A]
017D:2B25 mov AL,byte ptr ES:[BX-11113]
017D:2B2A sub AH,AH
017D:2B2C mov word ptr SS:[BP-2],AX
017D:2B2F mov AL,byte ptr ES:[BX-11049]
017D:2B34 mov word ptr SS:[BP-6],AX
017D:2B37 mov AX,word ptr SS:[BP-2]
017D:2B3A and AX,0x000F
017D:2B3D mov CH,AL
017D:2B3F sub CL,CL
017D:2B41 or word ptr SS:[BP-6],CX
017D:2B44 mov AL,byte ptr ES:[BX-10985]
017D:2B49 sub AH,AH
017D:2B4B mov word ptr SS:[BP-8],AX
017D:2B4E mov AX,word ptr SS:[BP-2]
017D:2B51 and AX,0x00F0
017D:2B54 mov CH,AL
017D:2B56 or word ptr SS:[BP-8],CX
017D:2B59 mov AX,word ptr SS:[BP-6]
017D:2B5C mov ES,word ptr DS:[0x538C]
017D:2B60 sub AX,word ptr ES:[0xA44B]
017D:2B65 add AX,0x001A
017D:2B68 mov word ptr SS:[BP-6],AX
017D:2B6B mov AX,word ptr SS:[BP-8]
017D:2B6E mov ES,word ptr DS:[0x538E]
017D:2B72 sub AX,word ptr ES:[0xA44D]
017D:2B77 add AX,0x000C
017D:2B7A mov word ptr SS:[BP-8],AX
017D:2B7D sub AX,AX
017D:2B7F mov word ptr SS:[BP-14],AX
017D:2B82 mov word ptr SS:[BP-12],AX
017D:2B85 mov AL,byte ptr SS:[BP-4]
017D:2B88 and AL,0x0F
017D:2B8A mov CL,byte ptr SS:[BP-2]
017D:2B8D and CL,0x0F
017D:2B90 cmp AL,CL
017D:2B92 jne short 0x2BA5
017D:2B94 cmp word ptr SS:[BP-6],0x000D
017D:2B98 jl short 0x2BA0
017D:2B9A cmp word ptr SS:[BP-6],0x0027
017D:2B9E jle short 0x2BA5
017D:2BA0 mov word ptr SS:[BP-12],1
017D:2BA5 mov AL,byte ptr SS:[BP-4]
017D:2BA8 and AL,0xF0
017D:2BAA mov CL,byte ptr SS:[BP-2]
017D:2BAD and CL,0xF0
017D:2BB0 cmp AL,CL
017D:2BB2 jne short 0x2BC5
017D:2BB4 cmp word ptr SS:[BP-8],0
017D:2BB8 jl short 0x2BC0
017D:2BBA cmp word ptr SS:[BP-8],0x0018
017D:2BBE jle short 0x2BC5
017D:2BC0 mov word ptr SS:[BP-14],1
017D:2BC5 cmp word ptr SS:[BP-6],-115
017D:2BC9 jge short 0x2BCE
017D:2BCB jmp near 0x2B12
017D:2BCE cmp word ptr SS:[BP-6],0x00A7
017D:2BD3 jle short 0x2BD8
017D:2BD5 jmp near 0x2B12
017D:2BD8 cmp word ptr SS:[BP-8],0xF080
017D:2BDD jge short 0x2BE2
017D:2BDF jmp near 0x2B12
017D:2BE2 cmp word ptr SS:[BP-8],0x0F98
017D:2BE7 jle short 0x2BEC
017D:2BE9 jmp near 0x2B12
017D:2BEC mov AX,word ptr SS:[BP-12]
017D:2BEF add AX,word ptr SS:[BP-14]
017D:2BF2 je short 0x2BF7
017D:2BF4 jmp near 0x2B12
017D:2BF7 and word ptr SS:[BP-6],0x007F
017D:2BFB and word ptr SS:[BP-8],0x007F
017D:2BFF mov ES,word ptr DS:[0x53A0]
017D:2C03 cmp word ptr ES:[0x4FBA],2
017D:2C09 jne short 0x2C0E
017D:2C0B jmp near 0x2ABD
017D:2C0E mov AX,word ptr SS:[BP-8]
017D:2C11 mov CL,3
017D:2C13 shl AX,CL
017D:2C15 push AX
017D:2C16 mov AX,word ptr SS:[BP-6]
017D:2C19 shl AX,CL
017D:2C1B push AX
017D:2C1C mov BX,word ptr SS:[BP-10]
017D:2C1F mov ES,word ptr DS:[0x538A]
017D:2C23 mov BL,byte ptr ES:[BX-11177]
017D:2C28 sub BH,BH
017D:2C2A shl BX,1
017D:2C2C shl BX,1
017D:2C2E mov ES,word ptr DS:[0x539E]
017D:2C32 push word ptr ES:[BX+0x39FC]
017D:2C37 push word ptr ES:[BX+0x39FA]
017D:2C3C mov AX,0x244B
017D:2C3F mov DX,0x1DE9
017D:2C42 push DX
017D:2C43 push AX
017D:2C44 call far 19FC:28EB
017D:2C4C mov SP,BP
017D:2C4E pop BP
017D:2C4F ret far
017D:2C50 push BP
017D:2C51 mov BP,SP
017D:2C53 mov AX,6
017D:2C56 call far 19FC:2FDC
017D:2C5B mov ES,word ptr DS:[0x53E4]
017D:2C5F mov word ptr ES:[0x0012],0x000D
017D:2C66 mov word ptr ES:[0x0016],7
017D:2C6D mov ES,word ptr DS:[0x53E6]
017D:2C71 mov word ptr ES:[0x00A6],7
017D:2C78 sub AX,AX
017D:2C7A mov word ptr SS:[BP-4],AX
017D:2C7D mov word ptr SS:[BP-6],AX
017D:2C80 jmp short 0x2C9E
017D:2C82 mov AX,0x007D
017D:2C85 imul word ptr SS:[BP-6]
017D:2C88 mov BX,AX
017D:2C8A mov ES,word ptr DS:[0x538A]
017D:2C8E cmp byte ptr ES:[BX-14556],0xFF
017D:2C94 je short 0x2C9B
017D:2C96 mov word ptr SS:[BP-4],1
017D:2C9B inc word ptr SS:[BP-6]
017D:2C9E cmp word ptr SS:[BP-6],4
017D:2CA2 jl short 0x2C82
017D:2CA4 cmp word ptr SS:[BP-4],0
017D:2CA8 je short 0x2CC1
017D:2CAA mov ES,word ptr DS:[0x53E6]
017D:2CAE inc word ptr ES:[0x00A6]
017D:2CB3 mov ES,word ptr DS:[0x53E4]
017D:2CB7 dec word ptr ES:[0x0012]
017D:2CBC inc word ptr ES:[0x0016]
017D:2CC1 mov AX,1
017D:2CC4 push AX
017D:2CC5 call far 17D3:0281
017D:2CCA add SP,2
017D:2CCD call far 17D3:0388
017D:2CD2 mov AX,1
017D:2CD5 push AX
017D:2CD6 call far 17D3:0004
017D:2CDB add SP,2
017D:2CDE mov AX,0x051F
017D:2CE1 push DS
017D:2CE2 push AX
017D:2CE3 call far 17D3:03F5
017D:2CE8 add SP,4
017D:2CEB cmp word ptr SS:[BP-4],0
017D:2CEF je short 0x2CFE
017D:2CF1 mov AX,0x0543
017D:2CF4 push DS
017D:2CF5 push AX
017D:2CF6 call far 17D3:03F5
017D:2CFE mov AX,0x055B
017D:2D01 push DS
017D:2D02 push AX
017D:2D03 call far 17D3:03F5
017D:2D08 add SP,4
017D:2D0B mov AX,0x0592
017D:2D0E push DS
017D:2D0F push AX
017D:2D10 call far 17D3:03F5
017D:2D15 add SP,4
017D:2D18 mov AX,1
017D:2D1B push AX
017D:2D1C call far 17D3:0B5E
017D:2D21 add SP,2
017D:2D24 mov word ptr SS:[BP-2],AX
017D:2D27 cmp word ptr SS:[BP-4],0
017D:2D2B jne short 0x2D4D
017D:2D2D cmp AX,1
017D:2D30 je short 0x2D60
017D:2D32 cmp AX,2
017D:2D35 je short 0x2D6C
017D:2D37 cmp AX,3
017D:2D3A je short 0x2D72
017D:2D3C cmp AX,4
017D:2D3F je short 0x2D7F
017D:2D41 cmp AX,5
017D:2D44 je short 0x2D85
017D:2D46 cmp AX,6
017D:2D49 je short 0x2D8B
017D:2D4B jmp short 0x2D9F
017D:2D4D mov AX,word ptr SS:[BP-2]
017D:2D50 sub AX,1
017D:2D53 cmp AX,6
017D:2D56 ja short 0x2D9F
017D:2D58 add AX,AX
017D:2D5A xchg BX,AX
017D:2D5B jmp near word ptr CS:[BX+0x2D91]
017D:2D60 push CS
017D:2D61 call near 0x3BD0
017D:2D6C push CS
017D:2D6D call near 0x378D
017D:2D72 sub AX,AX
017D:2D74 push AX
017D:2D75 call far 0DAE:000A
017D:2D7F push CS
017D:2D80 call near 0x32B3
017D:2D83 jmp short 0x2D9F
017D:2D85 push CS
017D:2D86 call near 0x35D3
017D:2D8B push CS
017D:2D8C call near 0x3D40
017D:2D9F call far 18BA:06C3
017D:2DA4 mov SP,BP
017D:2DA6 pop BP
017D:2DA7 ret far
017D:2DA8 push BP
017D:2DA9 mov BP,SP
017D:2DAB mov AX,0x0016
017D:2DAE call far 19FC:2FDC
017D:2DB3 push DI
017D:2DB4 push SI
017D:2DB5 mov word ptr DS:[0x0150],0x0055
017D:2DBB mov ES,word ptr DS:[0x538A]
017D:2DBF mov byte ptr ES:[0xD346],0
017D:2DC5 cmp word ptr SS:[BP+8],0x000E
017D:2DC9 jne short 0x2DD7
017D:2DCB mov word ptr DS:[0x0150],0x0021
017D:2DD1 mov byte ptr ES:[0xD346],1
017D:2DD7 mov AX,0x05A5
017D:2DDA push DS
017D:2DDB push AX
017D:2DDC mov AX,0x0012
017D:2DDF mov DX,0x2A0F
017D:2DE2 push DX
017D:2DE3 push AX
017D:2DE4 call far 19FC:3B68
017D:2DE9 add SP,8
017D:2DEC mov AX,0x000A
017D:2DEF push AX
017D:2DF0 mov AX,0x0015
017D:2DF3 mov DX,0x2A0F
017D:2DF6 push DX
017D:2DF7 push AX
017D:2DF8 push word ptr SS:[BP+8]
017D:2DFB call far 19FC:3BB6
017D:2E00 add SP,8
017D:2E03 mov AX,0x05A9
017D:2E06 push DS
017D:2E07 push AX
017D:2E08 mov AX,0x0012
017D:2E0B mov DX,0x2A0F
017D:2E0E push DX
017D:2E0F push AX
017D:2E10 call far 19FC:3B22
017D:2E15 add SP,8
017D:2E18 mov AX,2
017D:2E1B push AX
017D:2E1C push CS
017D:2E1D call near 0x28CC
017D:2E20 add SP,2
017D:2E23 cmp word ptr SS:[BP+8],0x000B
017D:2E27 jne short 0x2EA8
017D:2E29 mov ES,word ptr DS:[0x53D2]
017D:2E2D cmp word ptr ES:[0x3988],1
017D:2E33 je short 0x2EA8
017D:2E35 mov AX,0x0150
017D:2E38 mov DX,0x2965
017D:2E3B push DX
017D:2E3C push AX
017D:2E3D call far 19FC:00D1
017D:2EA8 cmp word ptr SS:[BP+8],0x000B
017D:2EAC je short 0x2EBE
017D:2EAE mov ES,word ptr DS:[0x53D2]
017D:2EB2 cmp word ptr ES:[0x3988],0
017D:2EB8 je short 0x2EBE
017D:2EBA push CS
017D:2EBB call near 0x4621
017D:2EBE mov AX,1
017D:2EC1 push AX
017D:2EC2 push CS
017D:2EC3 call near 0x28CC
017D:2EC6 add SP,2
017D:2EC9 cmp word ptr SS:[BP+8],1
017D:2ECD je short 0x2EDB
017D:2ECF cmp word ptr SS:[BP+8],0x000B
017D:2ED3 je short 0x2EDB
017D:2ED5 cmp word ptr SS:[BP+8],0x000E
017D:2ED9 jl short 0x2EF0
017D:2EDB mov AX,2
017D:2EDE push AX
017D:2EDF push CS
017D:2EE0 call near 0x28CC
017D:2EE3 jmp short 0x2EED
017D:2EE5 push word ptr DS:[0x014E]
017D:2EE9 push CS
017D:2EEA call near 0x2913
017D:2EED add SP,2
017D:2EF0 mov AX,0x8000
017D:2EF3 push AX
017D:2EF4 mov AX,0x0012
017D:2EF7 mov DX,0x2A0F
017D:2EFA push DX
017D:2EFB push AX
017D:2EFC call far 19FC:33D0
017D:2F01 add SP,6
017D:2F04 mov word ptr SS:[BP-14],AX
017D:2F07 inc AX
017D:2F08 je short 0x2EE5
017D:2F0A mov AX,1
017D:2F0D push AX
017D:2F0E lea AX,BP-4
017D:2F11 push SS
017D:2F12 push AX
017D:2F13 push word ptr SS:[BP-14]
017D:2F16 call far 19FC:3580
017D:2F1B add SP,8
017D:2F1E mov AX,1
017D:2F21 push AX
017D:2F22 lea AX,BP-8
017D:2F25 push SS
017D:2F26 push AX
017D:2F27 push word ptr SS:[BP-14]
017D:2F2A call far 19FC:3580
017D:2F2F add SP,8
017D:2F32 mov AX,1
017D:2F35 push AX
017D:2F36 lea AX,BP-12
017D:2F39 push SS
017D:2F3A push AX
017D:2F3B push word ptr SS:[BP-14]
017D:2F3E call far 19FC:3580
017D:2F43 add SP,8
017D:2F46 mov AX,1
017D:2F49 push AX
017D:2F4A lea AX,BP-2
017D:2F4D push SS
017D:2F4E push AX
017D:2F4F push word ptr SS:[BP-14]
017D:2F52 call far 19FC:3580
017D:2F57 add SP,8
017D:2F5A mov AX,1
017D:2F5D push AX
017D:2F5E lea AX,BP-10
017D:2F61 push SS
017D:2F62 push AX
017D:2F63 push word ptr SS:[BP-14]
017D:2F66 call far 19FC:3580
017D:2F6B add SP,8
017D:2F6E mov AX,0x0080
017D:2F71 push AX
017D:2F72 mov AX,0xA461
017D:2F75 mov DX,0x1DE9
017D:2F78 push DX
017D:2F79 push AX
017D:2F7A push word ptr SS:[BP-14]
017D:2F7D call far 19FC:3580
017D:2F82 add SP,8
017D:2F85 mov AX,0x0100
017D:2F88 push AX
017D:2F89 mov AX,0xA561
017D:2F8C mov DX,0x1DE9
017D:2F8F push DX
017D:2F90 push AX
017D:2F91 push word ptr SS:[BP-14]
017D:2F94 call far 19FC:3580
017D:2F99 add SP,8
017D:2F9C mov AX,0x0020
017D:2F9F push AX
017D:2FA0 mov AX,0x4564
017D:2FA3 mov DX,0x2A0F
017D:2FA6 push DX
017D:2FA7 push AX
017D:2FA8 push word ptr SS:[BP-14]
017D:2FAB call far 19FC:3580
017D:2FB0 add SP,8
017D:2FB3 mov AX,0x0020
017D:2FB6 push AX
017D:2FB7 mov AX,0x4596
017D:2FBA mov DX,0x2A0F
017D:2FBD push DX
017D:2FBE push AX
017D:2FBF push word ptr SS:[BP-14]
017D:2FC2 call far 19FC:3580
017D:2FC7 add SP,8
017D:2FCA mov AX,0x0020
017D:2FCD push AX
017D:2FCE mov AX,0x39B4
017D:2FD1 mov DX,0x2A0F
017D:2FD4 push DX
017D:2FD5 push AX
017D:2FD6 push word ptr SS:[BP-14]
017D:2FD9 call far 19FC:3580
017D:2FDE add SP,8
017D:2FE1 mov AX,0x0020
017D:2FE4 push AX
017D:2FE5 mov AX,0x39D4
017D:2FE8 mov DX,0x2A0F
017D:2FEB push DX
017D:2FEC push AX
017D:2FED push word ptr SS:[BP-14]
017D:2FF0 call far 19FC:3580
017D:2FF5 add SP,8
017D:2FF8 mov AX,0x0010
017D:2FFB push AX
017D:2FFC mov AX,0x4602
017D:2FFF mov DX,0x2A0F
017D:3002 push DX
017D:3003 push AX
017D:3004 push word ptr SS:[BP-14]
017D:3007 call far 19FC:3580
017D:300C add SP,8
017D:300F mov AX,8
017D:3012 push AX
017D:3013 mov AX,0x3768
017D:3016 mov DX,0x2A0F
017D:3019 push DX
017D:301A push AX
017D:301B push word ptr SS:[BP-14]
017D:301E call far 19FC:3580
017D:3023 add SP,8
017D:3026 mov CL,3
017D:3028 shr byte ptr SS:[BP-2],CL
017D:302B shr byte ptr SS:[BP-10],CL
017D:302E mov AX,0x1000
017D:3031 push AX
017D:3032 mov AX,0x101D
017D:3035 mov DX,0x1DE9
017D:3038 push DX
017D:3039 push AX
017D:303A push word ptr SS:[BP-14]
017D:303D call far 19FC:3580
017D:3042 add SP,8
017D:3045 push word ptr SS:[BP-14]
017D:3048 call far 19FC:3336
017D:304D add SP,2
017D:3050 mov BX,word ptr SS:[BP+6]
017D:3053 shl BX,1
017D:3055 shl BX,1
017D:3057 mov AX,word ptr DS:[BX+0x0170]
017D:305B mov DX,word ptr DS:[BX+0x0172]
017D:305F mov word ptr SS:[BP-18],AX
017D:3062 mov word ptr SS:[BP-16],DX
017D:3065 mov AL,byte ptr SS:[BP-12]
017D:3068 sub AH,AH
017D:306A mov CL,3
017D:306C shl AX,CL
017D:306E mov CL,byte ptr SS:[BP-8]
017D:3071 sub CH,CH
017D:3073 add AX,CX
017D:3075 add word ptr SS:[BP-18],AX
017D:3078 mov byte ptr SS:[BP-6],0x90
017D:307C mov byte ptr SS:[BP-12],CH
017D:307F jmp short 0x30AD
017D:3081 inc byte ptr SS:[BP-8]
017D:3084 mov AL,byte ptr SS:[BP-2]
017D:3087 cmp byte ptr SS:[BP-8],AL
017D:308A jae short 0x30AA
017D:308C mov BL,byte ptr SS:[BP-12]
017D:308F sub BH,BH
017D:3091 mov CL,3
017D:3093 shl BX,CL
017D:3095 mov AL,byte ptr SS:[BP-8]
017D:3098 sub AH,AH
017D:309A add BX,AX
017D:309C les SI,word ptr SS:[BP-18]
017D:309F mov AL,byte ptr SS:[BP-6]
017D:30A2 inc byte ptr SS:[BP-6]
017D:30A5 mov byte ptr ES:[BX+SI],AL
017D:30A8 jmp short 0x3081
017D:30AA inc byte ptr SS:[BP-12]
017D:30AD mov AL,byte ptr SS:[BP-10]
017D:30B0 cmp byte ptr SS:[BP-12],AL
017D:30B3 jae short 0x30BB
017D:30B5 mov byte ptr SS:[BP-8],0
017D:30B9 jmp short 0x3084
017D:30BB cmp word ptr SS:[BP+8],2
017D:30BF jne short 0x30D8
017D:30C1 mov ES,word ptr DS:[0x538A]
017D:30C5 cmp byte ptr ES:[0xD343],0
017D:30CB je short 0x30D8
017D:30CD sub AX,AX
017D:30CF push AX
017D:30D0 call far 0EC0:0C72
017D:30D8 cmp word ptr DS:[0x014C],0
017D:30DD je short 0x30E2
017D:30DF jmp near 0x3205
017D:30E2 mov byte ptr SS:[BP-8],0
017D:30E6 mov AL,0x1A
017D:30E8 mul byte ptr SS:[BP-8]
017D:30EB mov BX,AX
017D:30ED mov ES,word ptr DS:[0x538A]
017D:30F1 mov byte ptr ES:[BX-11367],1
017D:30F7 call far 19FC:0BC0
017D:30FC and AL,7
017D:30FE mov byte ptr SS:[BP-12],AL
017D:3101 mov AL,0x1A
017D:3103 mul byte ptr SS:[BP-8]
017D:3106 mov SI,AX
017D:3108 mov AL,byte ptr SS:[BP-12]
017D:310B mov CL,4
017D:310D shl AL,CL
017D:310F mov ES,word ptr DS:[0x538A]
017D:3113 mov byte ptr ES:[SI-11368],AL
017D:3118 mov BL,byte ptr SS:[BP-12]
017D:311B sub BH,BH
017D:311D mov ES,word ptr DS:[0x53DA]
017D:3121 mov AL,byte ptr ES:[BX+0x3768]
017D:3126 mov byte ptr SS:[BP-12],AL
017D:3129 mov ES,word ptr DS:[0x538A]
017D:312D or byte ptr ES:[SI-11368],AL
017D:3132 mov AL,byte ptr SS:[BP-12]
017D:3135 sub AH,AH
017D:3137 mov DI,AX
017D:3139 shl DI,1
017D:313B mov ES,word ptr DS:[0x53CA]
017D:313F mov AX,word ptr ES:[DI+0x4564]
017D:3144 mov ES,word ptr DS:[0x538A]
017D:3148 mov word ptr ES:[SI-11372],AX
017D:314D mov ES,word ptr DS:[0x53CC]
017D:3151 mov AX,word ptr ES:[DI+0x4596]
017D:3156 mov ES,word ptr DS:[0x538A]
017D:315A mov word ptr ES:[SI-11370],AX
017D:315F mov AL,byte ptr SS:[BP-8]
017D:3162 sub AH,AH
017D:3164 mov word ptr SS:[BP-20],AX
017D:3167 shl AX,1
017D:3169 mov word ptr SS:[BP-22],AX
017D:316C mov ES,word ptr DS:[0x53CA]
017D:3170 mov AX,word ptr ES:[DI+0x4564]
017D:3175 mov ES,word ptr DS:[0x538A]
017D:3179 mov word ptr ES:[SI-11376],AX
017D:317E mov BX,word ptr SS:[BP-22]
017D:3181 mov ES,word ptr DS:[0x53A4]
017D:3185 mov word ptr ES:[BX+0x4024],AX
017D:318A mov ES,word ptr DS:[0x53CC]
017D:318E mov AX,word ptr ES:[DI+0x4596]
017D:3193 mov ES,word ptr DS:[0x538A]
017D:3197 mov word ptr ES:[SI-11374],AX
017D:319C mov BX,word ptr SS:[BP-22]
017D:319F mov ES,word ptr DS:[0x53A6]
017D:31A3 mov word ptr ES:[BX+0x4056],AX
017D:31A8 mov BX,word ptr SS:[BP-20]
017D:31AB mov ES,word ptr DS:[0x53BE]
017D:31AF mov byte ptr ES:[BX+0x397C],0xFF
017D:31B5 mov BX,word ptr SS:[BP-20]
017D:31B8 mov ES,word ptr DS:[0x539A]
017D:31BC mov byte ptr ES:[BX+0x40AA],0x10
017D:31C2 cmp word ptr SS:[BP+8],0x000A
017D:31C6 jle short 0x31F9
017D:31C8 mov AL,byte ptr SS:[BP-8]
017D:31CB sub AH,AH
017D:31CD mov SI,AX
017D:31CF shl SI,1
017D:31D1 sub AL,AL
017D:31D3 mov CX,AX
017D:31D5 mov AL,0x1A
017D:31D7 mul byte ptr SS:[BP-8]
017D:31DA mov BX,AX
017D:31DC mov ES,word ptr DS:[0x538A]
017D:31E0 mov byte ptr ES:[BX-11367],CL
017D:31E5 sub CH,CH
017D:31E7 mov ES,word ptr DS:[0x53A6]
017D:31EB mov word ptr ES:[SI+0x4056],CX
017D:31F0 mov ES,word ptr DS:[0x53A4]
017D:31F4 mov word ptr ES:[SI+0x4024],CX
017D:31F9 inc byte ptr SS:[BP-8]
017D:31FC cmp byte ptr SS:[BP-8],8
017D:3200 jae short 0x3205
017D:3202 jmp near 0x30E6
017D:3205 pop SI
017D:3206 pop DI
017D:3207 mov SP,BP
017D:3209 pop BP
017D:320A ret far
017D:320B xor AX,AX
017D:320D call far 19FC:2FDC
017D:3212 mov AX,2
017D:3215 push AX
017D:3216 push CS
017D:3217 call near 0x28CC
017D:321A add SP,2
017D:321D mov AX,0x0150
017D:3220 mov DX,0x2965
017D:3223 push DX
017D:3224 push AX
017D:3225 call far 19FC:00D1
017D:322A add SP,4
017D:322D mov ES,word ptr DS:[0x53E8]
017D:3231 mov word ptr ES:[0x4FBC],1
017D:3238 mov AX,0x244B
017D:323B mov DX,0x1DE9
017D:323E push DX
017D:323F push AX
017D:3240 mov AX,0x05BB
017D:3243 push DS
017D:3244 push AX
017D:3245 call far 18BA:063B
017D:324A add SP,8
017D:324D mov AX,0x4614
017D:3250 mov DX,0x2A0F
017D:3253 push DX
017D:3254 push AX
017D:3255 mov AX,0x244B
017D:3258 mov DX,0x1DE9
017D:325B push DX
017D:325C push AX
017D:325D call far 18BA:049D
017D:3262 add SP,8
017D:3265 mov ES,word ptr DS:[0x53A0]
017D:3269 cmp word ptr ES:[0x4FBA],2
017D:326F jne short 0x3287
017D:3271 mov AX,0x0780
017D:3274 push AX
017D:3275 mov AX,0x4694
017D:3278 mov DX,0x2A0F
017D:327B push DX
017D:327C push AX
017D:327D push DX
017D:327E push AX
017D:327F call far 19FC:0572
017D:3287 mov AX,0x0780
017D:328A push AX
017D:328B mov AX,0xD582
017D:328E mov DX,0x2A0F
017D:3291 push DX
017D:3292 push AX
017D:3293 mov AX,0x4694
017D:3296 mov DX,0x2A0F
017D:3299 push DX
017D:329A push AX
017D:329B call far 19FC:0A76
017D:32A0 add SP,0x000A
017D:32A3 push CS
017D:32A4 call near 0x4621
017D:32A7 mov AX,1
017D:32AA push AX
017D:32AB push CS
017D:32AC call near 0x28CC
017D:32AF add SP,2
017D:32B2 ret far
017D:32B3 push BP
017D:32B4 mov BP,SP
017D:32B6 mov AX,0x000C
017D:32B9 call far 19FC:2FDC
017D:32BE push SI
017D:32BF mov AX,3
017D:32C2 push AX
017D:32C3 call far 17D3:0281
017D:32C8 add SP,2
017D:32CB call far 17D3:0388
017D:32D0 mov AX,0x05C7
017D:32D3 push DS
017D:32D4 push AX
017D:32D5 call far 17D3:03F5
017D:32DA add SP,4
017D:32DD mov AX,0x0028
017D:32E0 push AX
017D:32E1 call far 17D3:0B5E
017D:32E6 add SP,2
017D:32E9 mov word ptr SS:[BP-4],AX
017D:32EC cmp AX,6
017D:32EF jne short 0x32F4
017D:32F1 jmp near 0x35AD
017D:32F4 mov AL,byte ptr SS:[BP-4]
017D:32F7 add AL,0x31
017D:32F9 mov byte ptr DS:[0x0158],AL
017D:32FC mov AX,3
017D:32FF push AX
017D:3300 push CS
017D:3301 call near 0x28CC
017D:3304 jmp short 0x330E
017D:3306 push word ptr DS:[0x014E]
017D:330A push CS
017D:330B call near 0x2913
017D:330E add SP,2
017D:3311 mov AX,0x8000
017D:3314 push AX
017D:3315 mov AX,0x05F5
017D:3318 push DS
017D:3319 push AX
017D:331A call far 19FC:33D0
017D:331F add SP,6
017D:3322 mov word ptr SS:[BP-12],AX
017D:3325 inc AX
017D:3326 je short 0x3306
017D:3328 push word ptr SS:[BP-12]
017D:332B call far 19FC:3336
017D:3330 add SP,2
017D:3333 mov AX,0x8000
017D:3336 push AX
017D:3337 mov AX,0x0154
017D:333A push DS
017D:333B push AX
017D:333C call far 19FC:33D0
017D:3341 add SP,6
017D:3344 mov word ptr SS:[BP-12],AX
017D:3347 cmp AX,0xFFFF
017D:334A jne short 0x334F
017D:334C jmp near 0x3571
017D:334F mov AX,1
017D:3352 push AX
017D:3353 lea AX,BP-2
017D:3356 push SS
017D:3357 push AX
017D:3358 push word ptr SS:[BP-12]
017D:335B call far 19FC:3580
017D:3360 add SP,8
017D:3363 cmp byte ptr SS:[BP-2],0x0C
017D:3367 je short 0x3383
017D:3369 call far 17D3:0388
017D:3383 mov ES,word ptr DS:[0x53D0]
017D:3387 mov byte ptr ES:[0x00FC],1
017D:338D mov byte ptr ES:[0x0064],0
017D:3393 mov AX,0x0F44
017D:3396 push AX
017D:3397 mov AX,0xC614
017D:339A mov DX,0x2A0F
017D:339D push DX
017D:339E push AX
017D:339F push word ptr SS:[BP-12]
017D:33A2 call far 19FC:3580
017D:33A7 add SP,8
017D:33AA mov AX,2
017D:33AD push AX
017D:33AE mov AX,0xA44B
017D:33B1 mov DX,0x1DE9
017D:33B4 push DX
017D:33B5 push AX
017D:33B6 push word ptr SS:[BP-12]
017D:33B9 call far 19FC:3580
017D:33BE add SP,8
017D:33C1 mov AX,2
017D:33C4 push AX
017D:33C5 mov AX,0xA44D
017D:33C8 mov DX,0x1DE9
017D:33CB push DX
017D:33CC push AX
017D:33CD push word ptr SS:[BP-12]
017D:33D0 call far 19FC:3580
017D:33D5 add SP,8
017D:33D8 push word ptr SS:[BP-12]
017D:33DB call far 19FC:3336
017D:33E0 add SP,2
017D:33E3 mov word ptr SS:[BP-6],0
017D:33E8 mov BX,word ptr SS:[BP-6]
017D:33EB mov ES,word ptr DS:[0x53EA]
017D:33EF mov byte ptr ES:[BX+0x45DE],0
017D:33F5 inc word ptr SS:[BP-6]
017D:33F8 cmp word ptr SS:[BP-6],0x0021
017D:33FC jl short 0x33E8
017D:33FE mov ES,word ptr DS:[0x538A]
017D:3402 mov AL,byte ptr ES:[0xD35B]
017D:3406 cbw
017D:3407 mov ES,word ptr DS:[0x53E6]
017D:340B mov word ptr ES:[0x02F8],AX
017D:340F mov ES,word ptr DS:[0x538A]
017D:3413 cmp byte ptr ES:[0xD310],0
017D:3419 je short 0x3425
017D:341B mov ES,word ptr DS:[0x53D0]
017D:341F mov byte ptr ES:[0x00FC],0x0B
017D:3425 mov ES,word ptr DS:[0x538A]
017D:3429 cmp byte ptr ES:[0xD33E],0
017D:342F je short 0x343B
017D:3431 mov ES,word ptr DS:[0x53D0]
017D:3435 mov byte ptr ES:[0x0064],0x0C
017D:343B mov ES,word ptr DS:[0x538A]
017D:343F cmp byte ptr ES:[0xD346],0
017D:3445 je short 0x344A
017D:3447 jmp near 0x34CE
017D:344A mov ES,word ptr DS:[0x538C]
017D:344E mov AX,word ptr ES:[0xA44B]
017D:3452 mov ES,word ptr DS:[0x538E]
017D:3456 or AX,word ptr ES:[0xA44D]
017D:345B mov CL,8
017D:345D shr AX,CL
017D:345F mov word ptr SS:[BP-4],AX
017D:3462 mov byte ptr SS:[BP-3],0
017D:3466 push word ptr SS:[BP-4]
017D:3469 call far 19FC:104E
017D:346E add SP,2
017D:3471 sub word ptr SS:[BP-4],0x0011
017D:3475 mov word ptr SS:[BP-10],0
017D:347A mov word ptr SS:[BP-6],0
017D:347F mov SI,word ptr SS:[BP-4]
017D:3482 add SI,word ptr SS:[BP-6]
017D:3485 js short 0x34B1
017D:3487 cmp SI,0x0100
017D:348B jge short 0x34B1
017D:348D mov ES,word ptr DS:[0x53D0]
017D:3491 cmp byte ptr ES:[SI+0x0030],0
017D:3497 je short 0x34B1
017D:3499 mov AL,byte ptr ES:[SI+0x0030]
017D:349E cbw
017D:349F push AX
017D:34A0 mov AX,3
017D:34A3 imul word ptr SS:[BP-10]
017D:34A6 add AX,word ptr SS:[BP-6]
017D:34A9 push AX
017D:34AA push CS
017D:34AB call near 0x2DA8
017D:34AE add SP,4
017D:34B1 inc word ptr SS:[BP-6]
017D:34B4 cmp word ptr SS:[BP-6],3
017D:34B8 jl short 0x347F
017D:34BA add word ptr SS:[BP-4],0x0010
017D:34BE inc word ptr SS:[BP-10]
017D:34C1 cmp word ptr SS:[BP-10],3
017D:34C5 jl short 0x347A
017D:34C7 call far 19FC:1DA8
017D:34CC jmp short 0x34D3
017D:34CE call far 0CDA:0004
017D:34D3 mov word ptr SS:[BP-8],0
017D:34D8 mov BX,word ptr SS:[BP-8]
017D:34DB mov ES,word ptr DS:[0x539C]
017D:34DF mov byte ptr ES:[BX-10914],0
017D:34E5 mov AX,0x007D
017D:34E8 imul word ptr SS:[BP-8]
017D:34EB mov BX,AX
017D:34ED mov ES,word ptr DS:[0x538A]
017D:34F1 cmp byte ptr ES:[BX-14556],0x4C
017D:34F7 je short 0x3506
017D:34F9 mov BX,word ptr SS:[BP-8]
017D:34FC mov ES,word ptr DS:[0x539C]
017D:3500 mov byte ptr ES:[BX-10914],0x92
017D:3506 mov BX,word ptr SS:[BP-8]
017D:3509 mov ES,word ptr DS:[0x539A]
017D:350D mov byte ptr ES:[BX+0x409A],0
017D:3513 sub AL,AL
017D:3515 mov BX,word ptr SS:[BP-8]
017D:3518 mov ES,word ptr DS:[0x53D8]
017D:351C mov byte ptr ES:[BX+0x3920],AL
017D:3521 mov BX,word ptr SS:[BP-8]
017D:3524 mov ES,word ptr DS:[0x53BE]
017D:3528 mov byte ptr ES:[BX+0x396C],AL
017D:352D mov BX,word ptr SS:[BP-8]
017D:3530 shl BX,1
017D:3532 shl BX,1
017D:3534 mov word ptr DS:[BX+0x01F6],0x0270
017D:353A mov word ptr DS:[BX+0x01F8],0x2965
017D:3540 inc word ptr SS:[BP-8]
017D:3543 cmp word ptr SS:[BP-8],4
017D:3547 jl short 0x34D8
017D:3549 mov ES,word ptr DS:[0x53EC]
017D:354D mov word ptr ES:[0x374A],0
017D:3554 mov ES,word ptr DS:[0x538A]
017D:3558 cmp byte ptr ES:[0xD346],AL
017D:355D jne short 0x35AD
017D:355F mov ES,word ptr DS:[0x53D2]
017D:3563 cmp word ptr ES:[0x3988],2
017D:3569 jne short 0x35AD
017D:356B push CS
017D:356C call near 0x4621
017D:3571 call far 17D3:0388
017D:35AD sub AX,AX
017D:35AF push AX
017D:35B0 call far 0FAE:032F
017D:35B5 add SP,2
017D:35B8 mov AX,1
017D:35BB push AX
017D:35BC push CS
017D:35BD call near 0x4CAC
017D:35C0 add SP,2
017D:35C3 mov AX,1
017D:35C6 push AX
017D:35C7 push CS
017D:35C8 call near 0x28CC
017D:35CB add SP,2
017D:35CE pop SI
017D:35CF mov SP,BP
017D:35D1 pop BP
017D:35D2 ret far
017D:35D3 push BP
017D:35D4 mov BP,SP
017D:35D6 mov AX,8
017D:35D9 call far 19FC:2FDC
017D:378D push BP
017D:378E mov BP,SP
017D:3790 mov AX,0x000C
017D:3793 call far 19FC:2FDC
017D:3BD0 xor AX,AX
017D:3BD2 call far 19FC:2FDC
017D:3D40 push BP
017D:3D41 mov BP,SP
017D:3D43 mov AX,0x0012
017D:3D46 call far 19FC:2FDC
017D:4621 xor AX,AX
017D:4623 call far 19FC:2FDC
017D:4628 mov AX,0x0150
017D:462B mov DX,0x2965
017D:462E push DX
017D:462F push AX
017D:4630 call far 19FC:00D1
017D:4635 add SP,4
017D:4638 mov ES,word ptr DS:[0x53E8]
017D:463C mov word ptr ES:[0x4FBC],1
017D:4643 mov AX,2
017D:4646 push AX
017D:4647 push CS
017D:4648 call near 0x28CC
017D:464B add SP,2
017D:464E mov AX,0x244B
017D:4651 mov DX,0x1DE9
017D:4654 push DX
017D:4655 push AX
017D:4656 mov AX,0x0A9A
017D:4659 push DS
017D:465A push AX
017D:465B call far 18BA:063B
017D:4660 add SP,8
017D:4663 mov AX,0x4614
017D:4666 mov DX,0x2A0F
017D:4669 push DX
017D:466A push AX
017D:466B mov AX,0x244B
017D:466E mov DX,0x1DE9
017D:4671 push DX
017D:4672 push AX
017D:4673 call far 18BA:049D
017D:4678 add SP,8
017D:467B mov ES,word ptr DS:[0x53A0]
017D:467F cmp word ptr ES:[0x4FBA],2
017D:4685 jne short 0x469B
017D:4687 mov AX,0xA400
017D:468A push AX
017D:468B mov AX,0x4614
017D:468E mov DX,0x2A0F
017D:4691 push DX
017D:4692 push AX
017D:4693 call far 19FC:0260
017D:469B mov ES,word ptr DS:[0x53D2]
017D:469F mov word ptr ES:[0x3988],0
017D:46A6 ret far
017D:46A7 xor AX,AX
017D:46A9 call far 19FC:2FDC
017D:46AE mov ES,word ptr DS:[0x53A0]
017D:46B2 cmp word ptr ES:[0x4FBA],3
017D:46B8 je short 0x46C2
017D:46BA mov AX,0
017D:46BD mov DX,0x2965
017D:46C0 jmp short 0x46C8
017D:46C2 mov AX,0x0010
017D:46C5 mov DX,0x2965
017D:46C8 push DX
017D:46C9 push AX
017D:46CA call far 18BA:0525
017D:46CF add SP,4
017D:46D2 mov AX,2
017D:46D5 push AX
017D:46D6 push CS
017D:46D7 call near 0x28CC
017D:46DA add SP,2
017D:46DD mov AX,0x0210
017D:46E0 mov DX,0x2965
017D:46E3 push DX
017D:46E4 push AX
017D:46E5 call far 19FC:00D1
017D:46EA add SP,4
017D:46ED mov AX,0x4614
017D:46F0 mov DX,0x2A0F
017D:46F3 push DX
017D:46F4 push AX
017D:46F5 mov AX,0x0AA7
017D:46F8 push DS
017D:46F9 push AX
017D:46FA call far 18BA:063B
017D:46FF add SP,8
017D:4702 mov ES,word ptr DS:[0x53E8]
017D:4706 mov word ptr ES:[0x4FBC],0
017D:470D mov AX,0x244B
017D:4710 mov DX,0x1DE9
017D:4713 push DX
017D:4714 push AX
017D:4715 mov AX,0x4614
017D:4718 mov DX,0x2A0F
017D:471B push DX
017D:471C push AX
017D:471D call far 18BA:049D
017D:4722 add SP,8
017D:4725 mov ES,word ptr DS:[0x53A0]
017D:4729 cmp word ptr ES:[0x4FBA],2
017D:472F jne short 0x4745
017D:4731 mov AX,0xA800
017D:4734 push AX
017D:4735 mov AX,0x244B
017D:4738 mov DX,0x1DE9
017D:473B push DX
017D:473C push AX
017D:473D call far 19FC:0260
017D:4745 mov AX,0x00C8
017D:4748 push AX
017D:4749 mov AX,0x0028
017D:474C push AX
017D:474D sub AX,AX
017D:474F push AX
017D:4750 push AX
017D:4751 mov AX,0x244B
017D:4754 mov DX,0x1DE9
017D:4757 push DX
017D:4758 push AX
017D:4759 call far 18BA:0086
017D:475E add SP,0x000C
017D:4761 mov ES,word ptr DS:[0x53D2]
017D:4765 mov word ptr ES:[0x3988],0xFFFF
017D:476C ret far
017D:476D push BP
017D:476E mov BP,SP
017D:4770 mov AX,4
017D:4773 call far 19FC:2FDC
017D:4778 mov AX,2
017D:477B push AX
017D:477C push CS
017D:477D call near 0x28CC
017D:4780 jmp short 0x478A
017D:4782 push word ptr DS:[0x014E]
017D:4786 push CS
017D:4787 call near 0x2913
017D:478A add SP,2
017D:478D mov AX,0x8000
017D:4790 push AX
017D:4791 mov AX,0x0AB3
017D:4794 push DS
017D:4795 push AX
017D:4796 call far 19FC:33D0
017D:479B add SP,6
017D:479E mov word ptr SS:[BP-4],AX
017D:47A1 inc AX
017D:47A2 je short 0x4782
017D:47A4 mov AX,2
017D:47A7 push AX
017D:47A8 sub AX,AX
017D:47AA push AX
017D:47AB push AX
017D:47AC push word ptr SS:[BP-4]
017D:47AF call far 19FC:3356
017D:47B4 add SP,8
017D:47B7 mov word ptr SS:[BP-2],AX
017D:47BA sub AX,AX
017D:47BC push AX
017D:47BD push AX
017D:47BE push AX
017D:47BF push word ptr SS:[BP-4]
017D:47C2 call far 19FC:3356
017D:47C7 add SP,8
017D:47CA push word ptr SS:[BP-2]
017D:47CD mov AX,0x244B
017D:47D0 mov DX,0x1DE9
017D:47D3 push DX
017D:47D4 push AX
017D:47D5 push word ptr SS:[BP-4]
017D:47D8 call far 19FC:3580
017D:47DD add SP,8
017D:47E0 push word ptr SS:[BP-4]
017D:47E3 call far 19FC:3336
017D:47E8 add SP,2
017D:47EB mov BX,word ptr SS:[BP-2]
017D:47EE mov ES,word ptr DS:[0x53C6]
017D:47F2 mov byte ptr ES:[BX+0x244B],0
017D:47F8 mov BX,word ptr SS:[BP-2]
017D:47FB mov byte ptr ES:[BX+0x244C],0
017D:4801 mov BX,word ptr SS:[BP-2]
017D:4804 mov byte ptr ES:[BX+0x244D],0
017D:480A mov BX,word ptr SS:[BP-2]
017D:480D mov byte ptr ES:[BX+0x244E],0
017D:4813 call far 19C8:0048
017D:4818 mov ES,word ptr DS:[0x53A0]
017D:481C cmp word ptr ES:[0x4FBA],1
017D:4822 jne short 0x4846
017D:4824 sub AX,AX
017D:4826 push AX
017D:4827 call far 19C8:02E4
017D:4846 sub AX,AX
017D:4848 push AX
017D:4849 call far 19C8:0306
017D:484E add SP,2
017D:4851 mov AX,4
017D:4854 push AX
017D:4855 mov AX,0x244B
017D:4858 mov DX,0x1DE9
017D:485B push DX
017D:485C push AX
017D:485D mov AX,1
017D:4860 push AX
017D:4861 call far 19C8:0306
017D:4866 add SP,8
017D:4869 mov ES,word ptr DS:[0x5384]
017D:486D mov word ptr ES:[0x3938],0
017D:4874 call far 18BA:002F
017D:4879 or AX,AX
017D:487B jne short 0x488D
017D:487D mov AX,1
017D:4880 push AX
017D:4881 call far 19C8:033C
017D:488D mov ES,word ptr DS:[0x53A0]
017D:4891 cmp word ptr ES:[0x4FBA],1
017D:4897 jne short 0x48A3
017D:4899 sub AX,AX
017D:489B push AX
017D:489C call far 19C8:02E4
017D:48A3 sub AX,AX
017D:48A5 push AX
017D:48A6 call far 19C8:0306
017D:48AB add SP,2
017D:48AE call far 19C8:0091
017D:48B3 mov SP,BP
017D:48B5 pop BP
017D:48B6 ret far
017D:48B7 push BP
017D:48B8 mov BP,SP
017D:48BA mov AX,8
017D:48BD call far 19FC:2FDC
017D:48C2 mov ES,word ptr DS:[0x53FE]
017D:48C6 mov byte ptr ES:[0x0012],0x4F
017D:48CC mov AX,0x000A
017D:48CF push AX
017D:48D0 mov AX,0x0013
017D:48D3 mov DX,0x2A0F
017D:48D6 push DX
017D:48D7 push AX
017D:48D8 push word ptr SS:[BP+6]
017D:48DB call far 19FC:3BB6
017D:48E0 add SP,8
017D:48E3 mov AX,0x0ABF
017D:48E6 push DS
017D:48E7 push AX
017D:48E8 mov AX,0x0012
017D:48EB mov DX,0x2A0F
017D:48EE push DX
017D:48EF push AX
017D:48F0 call far 19FC:3B22
017D:48F5 add SP,8
017D:48F8 sub AX,AX
017D:48FA mov word ptr SS:[BP-8],AX
017D:48FD mov word ptr SS:[BP-2],AX
017D:4900 call far 19FC:0BC0
017D:4905 mov ES,word ptr DS:[0x538A]
017D:4909 mov CX,AX
017D:490B mov AL,byte ptr ES:[0xD35B]
017D:490F cbw
017D:4910 mov BX,AX
017D:4912 shl BX,1
017D:4914 and word ptr DS:[BX+0x0AC4],CX
017D:4918 jne short 0x491F
017D:491A mov word ptr SS:[BP-8],1
017D:491F cmp word ptr SS:[BP+6],0x0010
017D:4923 je short 0x4942
017D:4925 cmp word ptr SS:[BP+6],0
017D:4929 je short 0x493D
017D:492B cmp word ptr SS:[BP+6],7
017D:492F jg short 0x493D
017D:4931 cmp word ptr SS:[BP+6],6
017D:4935 je short 0x493D
017D:4937 cmp word ptr SS:[BP+6],2
017D:493B jne short 0x4942
017D:493D mov word ptr SS:[BP-8],1
017D:4942 cmp word ptr SS:[BP+8],2
017D:4946 jne short 0x494D
017D:4948 mov word ptr SS:[BP-8],1
017D:494D cmp word ptr SS:[BP-8],0
017D:4951 jne short 0x4956
017D:4953 jmp near 0x4AA2
017D:4956 cmp word ptr SS:[BP+6],8
017D:495A jne short 0x4961
017D:495C mov word ptr SS:[BP-2],6
017D:4961 mov AX,1
017D:4964 push AX
017D:4965 push CS
017D:4966 call near 0x28CC
017D:4969 add SP,2
017D:496C cmp word ptr SS:[BP+6],9
017D:4970 jle short 0x4983
017D:4972 cmp word ptr SS:[BP+6],0x0010
017D:4976 jge short 0x4983
017D:4978 mov AX,2
017D:497B push AX
017D:497C push CS
017D:497D call near 0x28CC
017D:4980 add SP,2
017D:4983 cmp word ptr SS:[BP+6],0x0010
017D:4987 jle short 0x49C5
017D:4989 mov AX,0x8000
017D:498C push AX
017D:498D mov AX,0x0012
017D:4990 mov DX,0x2A0F
017D:4993 push DX
017D:4994 push AX
017D:4995 call far 19FC:33D0
017D:49C5 cmp word ptr SS:[BP-8],0
017D:49C9 jne short 0x49CE
017D:49CB jmp near 0x4AA2
017D:49CE mov AX,0x3F00
017D:49D1 push AX
017D:49D2 mov AX,0x42C3
017D:49D5 mov DX,0x1DE9
017D:49D8 push DX
017D:49D9 push AX
017D:49DA mov AX,0x0012
017D:49DD mov DX,0x2A0F
017D:49E0 push DX
017D:49E1 push AX
017D:49E2 call far 18BA:0814
017D:49E7 add SP,0x000A
017D:49EA mov AX,0x0150
017D:49ED mov DX,0x2965
017D:49F0 push DX
017D:49F1 push AX
017D:49F2 call far 19FC:00D1
017D:49F7 add SP,4
017D:49FA mov word ptr SS:[BP-4],0
017D:49FF mov BX,word ptr SS:[BP-4]
017D:4A02 mov ES,word ptr DS:[0x53C6]
017D:4A06 mov byte ptr ES:[BX+0x244B],0
017D:4A0C inc word ptr SS:[BP-4]
017D:4A0F cmp word ptr SS:[BP-4],0x1E78
017D:4A14 jl short 0x49FF
017D:4A16 mov ES,word ptr DS:[0x53C4]
017D:4A1A mov word ptr ES:[0xE48A],0
017D:4A21 mov ES,word ptr DS:[0x53C2]
017D:4A25 mov word ptr ES:[0x0064],0x42F6
017D:4A2C mov word ptr ES:[0x0066],0x1DE9
017D:4A33 push CS
017D:4A34 call near 0x1AFD
017D:4A37 cmp word ptr SS:[BP+6],8
017D:4A3B je short 0x4A4F
017D:4A3D mov AX,0x0032
017D:4A40 push AX
017D:4A41 call far 18BA:0006
017D:4A46 add SP,2
017D:4A49 jmp short 0x4A4F
017D:4A4B push CS
017D:4A4C call near 0x1AFD
017D:4A4F mov ES,word ptr DS:[0x53C4]
017D:4A53 mov BX,word ptr ES:[0xE48A]
017D:4A58 mov ES,word ptr DS:[0x53C6]
017D:4A5C cmp byte ptr ES:[BX+0x42C3],0
017D:4A62 jne short 0x4A4B
017D:4A64 mov AX,word ptr SS:[BP-2]
017D:4A67 dec word ptr SS:[BP-2]
017D:4A6A or AX,AX
017D:4A6C jne short 0x49FA
017D:4A6E cmp word ptr SS:[BP+8],0
017D:4A72 jne short 0x4AA2
017D:4A74 cmp word ptr SS:[BP+6],0
017D:4A78 jne short 0x4A85
017D:4A7A mov AX,0x000C
017D:4A7D push AX
017D:4A7E push CS
017D:4A7F call near 0x19BF
017D:4A85 mov AX,0x003C
017D:4A88 push AX
017D:4A89 call far 18BA:0006
017D:4A8E add SP,2
017D:4A91 mov AX,4
017D:4A94 push AX
017D:4A95 call far 17D3:0281
017D:4A9A add SP,2
017D:4A9D call far 17D3:0388
017D:4AA2 mov SP,BP
017D:4AA4 pop BP
017D:4AA5 ret far
017D:4AA6 push BP
017D:4AA7 mov BP,SP
017D:4AA9 mov AX,0x000A
017D:4AAC call far 19FC:2FDC
017D:4AB1 sub AX,AX
017D:4AB3 push AX
017D:4AB4 mov AX,0x000F
017D:4AB7 push AX
017D:4AB8 push word ptr SS:[BP+8]
017D:4ABB mov AX,1
017D:4ABE push AX
017D:4ABF mov AX,0x0011
017D:4AC2 imul word ptr SS:[BP+6]
017D:4AC5 mov BX,AX
017D:4AC7 mov ES,word ptr DS:[0x538A]
017D:4ACB mov AL,byte ptr ES:[BX-14828]
017D:4AD0 cbw
017D:4AD1 mov BX,AX
017D:4AD3 shl BX,1
017D:4AD5 shl BX,1
017D:4AD7 push word ptr DS:[BX+0x01CC]
017D:4ADB push word ptr DS:[BX+0x01CA]
017D:4ADF call far 18BA:00D5
017D:4AE4 add SP,0x000C
017D:4AE7 mov CL,3
017D:4AE9 shl word ptr SS:[BP+8],CL
017D:4AEC mov AX,0x0011
017D:4AEF imul word ptr SS:[BP+6]
017D:4AF2 mov BX,AX
017D:4AF4 mov ES,word ptr DS:[0x538A]
017D:4AF8 mov AL,byte ptr ES:[BX-14827]
017D:4AFD cbw
017D:4AFE mov word ptr SS:[BP-8],AX
017D:4B01 push word ptr SS:[BP+8]
017D:4B04 mov AX,9
017D:4B07 push AX
017D:4B08 push word ptr SS:[BP-8]
017D:4B0B push CS
017D:4B0C call near 0x4BC1
017D:4B0F add SP,6
017D:4B12 mov AX,0x0011
017D:4B15 imul word ptr SS:[BP+6]
017D:4B18 mov BX,AX
017D:4B1A mov ES,word ptr DS:[0x538A]
017D:4B1E mov AL,byte ptr ES:[BX-14813]
017D:4B23 cbw
017D:4B24 mov CL,0x0A
017D:4B26 idiv CL
017D:4B28 cbw
017D:4B29 mov word ptr SS:[BP-2],AX
017D:4B2C or AX,AX
017D:4B2E jne short 0x4B35
017D:4B30 mov word ptr SS:[BP-2],1
017D:4B35 mov AX,word ptr SS:[BP-8]
017D:4B38 sub AX,word ptr SS:[BP-2]
017D:4B3B mov word ptr SS:[BP-2],AX
017D:4B3E or AX,AX
017D:4B40 je short 0x4B7E
017D:4B42 mov word ptr SS:[BP-10],4
017D:4B47 mov ES,word ptr DS:[0x53A0]
017D:4B4B cmp word ptr ES:[0x4FBA],0
017D:4B51 jne short 0x4B58
017D:4B53 mov word ptr SS:[BP-10],2
017D:4B58 mov AX,word ptr SS:[BP+8]
017D:4B5B sub AX,word ptr SS:[BP-8]
017D:4B5E add AX,0x000E
017D:4B61 mov word ptr SS:[BP-6],AX
017D:4B64 push word ptr SS:[BP-10]
017D:4B67 add AX,word ptr SS:[BP-2]
017D:4B6A push AX
017D:4B6B mov AX,0x004C
017D:4B6E push AX
017D:4B6F push word ptr SS:[BP-6]
017D:4B72 mov AX,0x004A
017D:4B75 push AX
017D:4B76 call far 18BA:01FB
017D:4B7E push word ptr SS:[BP+8]
017D:4B81 mov AX,0x000A
017D:4B84 push AX
017D:4B85 mov AX,0x0011
017D:4B88 imul word ptr SS:[BP+6]
017D:4B8B mov BX,AX
017D:4B8D mov ES,word ptr DS:[0x538A]
017D:4B91 mov AL,byte ptr ES:[BX-14826]
017D:4B96 cbw
017D:4B97 push AX
017D:4B98 push CS
017D:4B99 call near 0x4BC1
017D:4B9C add SP,6
017D:4B9F push word ptr SS:[BP+8]
017D:4BA2 mov AX,0x000B
017D:4BA5 push AX
017D:4BA6 mov AX,0x0011
017D:4BA9 imul word ptr SS:[BP+6]
017D:4BAC mov BX,AX
017D:4BAE mov ES,word ptr DS:[0x538A]
017D:4BB2 mov AL,byte ptr ES:[BX-14825]
017D:4BB7 cbw
017D:4BB8 push AX
017D:4BB9 push CS
017D:4BBA call near 0x4BC1
017D:4BBD mov SP,BP
017D:4BBF pop BP
017D:4BC0 ret far
017D:4BC1 push BP
017D:4BC2 mov BP,SP
017D:4BC4 mov AX,2
017D:4BC7 call far 19FC:2FDC
017D:4BCC push SI
017D:4BCD mov CL,3
017D:4BCF shl word ptr SS:[BP+8],CL
017D:4BD2 mov AX,0x000C
017D:4BD5 sub AX,word ptr SS:[BP+6]
017D:4BD8 mov word ptr SS:[BP+6],AX
017D:4BDB mov word ptr SS:[BP-2],0x000E
017D:4BE0 mov ES,word ptr DS:[0x53A0]
017D:4BE4 cmp word ptr ES:[0x4FBA],0
017D:4BEA jne short 0x4BF1
017D:4BEC mov word ptr SS:[BP-2],3
017D:4BF1 push word ptr SS:[BP-2]
017D:4BF4 push word ptr SS:[BP+0x0A]
017D:4BF7 mov AX,word ptr SS:[BP+8]
017D:4BFA add AX,5
017D:4BFD push AX
017D:4BFE push word ptr SS:[BP+0x0A]
017D:4C01 mov AX,word ptr SS:[BP+8]
017D:4C04 inc AX
017D:4C05 push AX
017D:4C06 call far 18BA:031C
017D:4C0B add SP,0x000A
017D:4C0E push word ptr SS:[BP-2]
017D:4C11 mov AX,word ptr SS:[BP+0x0A]
017D:4C14 add AX,0x000D
017D:4C17 push AX
017D:4C18 push word ptr SS:[BP+8]
017D:4C1B mov AX,word ptr SS:[BP+0x0A]
017D:4C1E inc AX
017D:4C1F push AX
017D:4C20 push word ptr SS:[BP+8]
017D:4C23 call far 18BA:031C
017D:4C28 add SP,0x000A
017D:4C2B mov SI,word ptr SS:[BP+8]
017D:4C2E add SI,6
017D:4C31 push word ptr SS:[BP-2]
017D:4C34 mov AX,word ptr SS:[BP+0x0A]
017D:4C37 add AX,0x000D
017D:4C3A push AX
017D:4C3B push SI
017D:4C3C mov AX,word ptr SS:[BP+0x0A]
017D:4C3F inc AX
017D:4C40 push AX
017D:4C41 push SI
017D:4C42 call far 18BA:031C
017D:4C47 add SP,0x000A
017D:4C4A mov SI,word ptr SS:[BP+0x0A]
017D:4C4D add SI,0x000E
017D:4C50 push word ptr SS:[BP-2]
017D:4C53 push SI
017D:4C54 mov AX,word ptr SS:[BP+8]
017D:4C57 add AX,5
017D:4C5A push AX
017D:4C5B push SI
017D:4C5C mov AX,word ptr SS:[BP+8]
017D:4C5F inc AX
017D:4C60 push AX
017D:4C61 call far 18BA:031C
017D:4C66 add SP,0x000A
017D:4C69 mov word ptr SS:[BP-2],0x000A
017D:4C6E mov ES,word ptr DS:[0x53A0]
017D:4C72 cmp word ptr ES:[0x4FBA],0
017D:4C78 jne short 0x4C7F
017D:4C7A mov word ptr SS:[BP-2],1
017D:4C7F push word ptr SS:[BP-2]
017D:4C82 mov AX,word ptr SS:[BP+0x0A]
017D:4C85 add AX,0x000D
017D:4C88 push AX
017D:4C89 mov AX,word ptr SS:[BP+8]
017D:4C8C add AX,4
017D:4C8F push AX
017D:4C90 mov AX,word ptr SS:[BP+0x0A]
017D:4C93 add AX,word ptr SS:[BP+6]
017D:4C96 inc AX
017D:4C97 inc AX
017D:4C98 push AX
017D:4C99 mov AX,word ptr SS:[BP+8]
017D:4C9C inc AX
017D:4C9D inc AX
017D:4C9E push AX
017D:4C9F call far 18BA:01FB
017D:4CA4 add SP,0x000A
017D:4CA7 pop SI
017D:4CA8 mov SP,BP
017D:4CAA pop BP
017D:4CAB ret far
017D:4CAC push BP
017D:4CAD mov BP,SP
017D:4CAF mov AX,4
017D:4CB2 call far 19FC:2FDC
017D:4CB7 mov AX,3
017D:4CBA push AX
017D:4CBB call far 17D3:0281
017D:4CC0 add SP,2
017D:4CC3 mov AX,3
017D:4CC6 push AX
017D:4CC7 call far 17D3:0004
017D:4CCC add SP,2
017D:4CCF cmp word ptr SS:[BP+6],0
017D:4CD3 je short 0x4CDA
017D:4CD5 call far 17D3:0388
017D:4CDA sub AX,AX
017D:4CDC push AX
017D:4CDD mov AX,0x000F
017D:4CE0 push AX
017D:4CE1 mov AX,0x000D
017D:4CE4 push AX
017D:4CE5 mov AX,9
017D:4CE8 push AX
017D:4CE9 mov AX,0x0ACA
017D:4CEC push DS
017D:4CED push AX
017D:4CEE call far 18BA:00D5
017D:4CF3 add SP,0x000C
017D:4CF6 mov word ptr SS:[BP-2],0
017D:4CFB mov word ptr SS:[BP-4],0
017D:4D00 cmp word ptr SS:[BP-2],4
017D:4D04 jge short 0x4D30
017D:4D06 mov AX,0x0011
017D:4D09 imul word ptr SS:[BP-4]
017D:4D0C mov BX,AX
017D:4D0E mov ES,word ptr DS:[0x538A]
017D:4D12 cmp byte ptr ES:[BX-14828],0xFF
017D:4D18 je short 0x4D30
017D:4D1A mov AX,word ptr SS:[BP-2]
017D:4D1D shl AX,1
017D:4D1F add AX,0x000E
017D:4D22 push AX
017D:4D23 push word ptr SS:[BP-4]
017D:4D26 push CS
017D:4D27 call near 0x4AA6
017D:4D2A add SP,4
017D:4D2D inc word ptr SS:[BP-2]
017D:4D30 inc word ptr SS:[BP-4]
017D:4D33 cmp word ptr SS:[BP-4],8
017D:4D37 jl short 0x4D00
017D:4D39 call far 0FAE:1FDF
017D:4D3E mov AX,4
017D:4D41 push AX
017D:4D42 call far 17D3:0281
017D:4D47 add SP,2
017D:4D4A mov AX,4
017D:4D4D push AX
017D:4D4E call far 17D3:0004
017D:4D53 mov SP,BP
017D:4D55 pop BP
017D:4D56 ret far
017D:4DC7 push BP
017D:4DC8 mov BP,SP
017D:4DCA mov AX,6
017D:4DCD call far 19FC:2FDC
017D:4DD2 mov ES,word ptr DS:[0x538A]
017D:4DD6 mov AL,0xFF
017D:4DD8 mov byte ptr ES:[0xD455],AL
017D:4DDC mov byte ptr ES:[0xD454],AL
017D:4DE0 mov byte ptr ES:[0xD453],AL
017D:4DE4 mov byte ptr ES:[0xD452],AL
017D:4DE8 mov byte ptr ES:[0xCA8F],AL
017D:4DEC mov byte ptr ES:[0xCA12],AL
017D:4DF0 mov byte ptr ES:[0xC995],AL
017D:4DF4 mov byte ptr ES:[0xC918],AL
017D:4DF8 mov byte ptr ES:[0xC89B],AL
017D:4DFC mov byte ptr ES:[0xC81E],AL
017D:4E00 mov byte ptr ES:[0xC7A1],AL
017D:4E04 mov byte ptr ES:[0xC724],AL
017D:4E08 mov word ptr SS:[BP-2],1
017D:4E0D mov AX,0x0011
017D:4E10 imul word ptr SS:[BP-2]
017D:4E13 mov BX,AX
017D:4E15 mov ES,word ptr DS:[0x538A]
017D:4E19 mov byte ptr ES:[BX-14828],0xFF
017D:4E1F inc word ptr SS:[BP-2]
017D:4E22 cmp word ptr SS:[BP-2],8
017D:4E26 jl short 0x4E0D
017D:4E28 mov word ptr SS:[BP-2],0
017D:4E2D mov BX,word ptr SS:[BP-2]
017D:4E30 mov ES,word ptr DS:[0x538A]
017D:4E34 mov byte ptr ES:[BX-14824],0
017D:4E3A inc word ptr SS:[BP-2]
017D:4E3D cmp word ptr SS:[BP-2],6
017D:4E41 jle short 0x4E2D
017D:4E43 mov word ptr SS:[BP-2],0
017D:4E48 mov BX,word ptr SS:[BP-2]
017D:4E4B mov ES,word ptr DS:[0x538A]
017D:4E4F mov byte ptr ES:[BX-11508],0
017D:4E55 inc word ptr SS:[BP-2]
017D:4E58 cmp word ptr SS:[BP-2],0x0064
017D:4E5C jl short 0x4E48
017D:4E5E mov word ptr SS:[BP-2],0
017D:4E63 mov BX,word ptr SS:[BP-2]
017D:4E66 mov ES,word ptr DS:[0x53EA]
017D:4E6A mov byte ptr ES:[BX+0x45DE],0
017D:4E70 inc word ptr SS:[BP-2]
017D:4E73 cmp word ptr SS:[BP-2],0x0021
017D:4E77 jl short 0x4E63
017D:4E79 mov ES,word ptr DS:[0x538A]
017D:4E7D mov byte ptr ES:[0xC614],0
017D:4E83 mov byte ptr ES:[0xC620],8
017D:4E89 mov word ptr ES:[0xD370],0x0014
017D:4E90 mov word ptr ES:[0xD372],0
017D:4E97 mov word ptr SS:[BP-2],0
017D:4E9C mov BX,word ptr SS:[BP-2]
017D:4E9F shl BX,1
017D:4EA1 shl BX,1
017D:4EA3 mov ES,word ptr DS:[0x538A]
017D:4EA7 sub AX,AX
017D:4EA9 mov word ptr ES:[BX-11402],AX
017D:4EAE mov word ptr ES:[BX-11404],AX
017D:4EB3 inc word ptr SS:[BP-2]
017D:4EB6 cmp word ptr SS:[BP-2],3
017D:4EBA jl short 0x4E9C
017D:4EBC mov byte ptr ES:[0xD456],1
017D:4EC2 mov word ptr SS:[BP-2],AX
017D:4EC5 mov BX,word ptr SS:[BP-2]
017D:4EC8 mov CL,4
017D:4ECA shl BX,CL
017D:4ECC mov ES,word ptr DS:[0x538A]
017D:4ED0 or byte ptr ES:[BX-11976],0x1F
017D:4ED6 inc word ptr SS:[BP-2]
017D:4ED9 cmp word ptr SS:[BP-2],6
017D:4EDD jl short 0x4EC5
017D:4EDF mov byte ptr ES:[0xC615],8
017D:4EE5 mov byte ptr ES:[0xC623],0x50
017D:4EEB mov byte ptr ES:[0xC616],9
017D:4EF1 mov byte ptr ES:[0xC617],7
017D:4EF7 mov byte ptr ES:[0xC61F],0
017D:4EFD sub AL,AL
017D:4EFF mov byte ptr ES:[0xC624],AL
017D:4F03 mov byte ptr ES:[0xC622],AL
017D:4F07 mov byte ptr ES:[0xC621],AL
017D:4F0B mov ES,word ptr DS:[0x539C]
017D:4F0F mov byte ptr ES:[0xD562],0x96
017D:4F15 mov word ptr SS:[BP-2],0x0010
017D:4F1A mov BX,word ptr SS:[BP-2]
017D:4F1D mov ES,word ptr DS:[0x539C]
017D:4F21 mov byte ptr ES:[BX-10914],0xFE
017D:4F27 inc word ptr SS:[BP-2]
017D:4F2A cmp word ptr SS:[BP-2],0x0018
017D:4F2E jl short 0x4F1A
017D:4F30 mov word ptr SS:[BP-2],0
017D:4F35 jmp short 0x4F5F
017D:4F37 add word ptr SS:[BP-6],0x000C
017D:4F3B cmp word ptr SS:[BP-6],0x000D
017D:4F3F jge short 0x4F5C
017D:4F41 call far 19FC:0BC0
017D:4F46 test AL,1
017D:4F48 je short 0x4F37
017D:4F4A mov BX,word ptr SS:[BP-2]
017D:4F4D add BX,word ptr SS:[BP-6]
017D:4F50 mov ES,word ptr DS:[0x539C]
017D:4F54 mov byte ptr ES:[BX-10914],0x92
017D:4F5A jmp short 0x4F37
017D:4F5C inc word ptr SS:[BP-2]
017D:4F5F cmp word ptr SS:[BP-2],4
017D:4F63 jge short 0x4F6C
017D:4F65 mov word ptr SS:[BP-6],0
017D:4F6A jmp short 0x4F3B
017D:4F6C mov ES,word ptr DS:[0x538A]
017D:4F70 mov byte ptr ES:[0xD33F],0x32
017D:4F76 mov byte ptr ES:[0xD340],0
017D:4F7C sub AL,AL
017D:4F7E mov byte ptr ES:[0xD451],AL
017D:4F82 mov byte ptr ES:[0xD450],AL
017D:4F86 mov byte ptr ES:[0xD557],AL
017D:4F8A mov word ptr SS:[BP-2],0
017D:4F8F sub AL,AL
017D:4F91 mov BX,word ptr SS:[BP-2]
017D:4F94 mov ES,word ptr DS:[0x538A]
017D:4F98 mov byte ptr ES:[BX-10985],AL
017D:4F9D mov BX,word ptr SS:[BP-2]
017D:4FA0 mov byte ptr ES:[BX-11049],AL
017D:4FA5 mov BX,word ptr SS:[BP-2]
017D:4FA8 mov byte ptr ES:[BX-11113],AL
017D:4FAD inc word ptr SS:[BP-2]
017D:4FB0 cmp word ptr SS:[BP-2],0x0040
017D:4FB4 jl short 0x4F8F
017D:4FB6 call far 19FC:1FBE
017D:4FBB mov AX,1
017D:4FBE push AX
017D:4FBF push CS
017D:4FC0 call near 0x4CAC
017D:4FC3 add SP,2
017D:4FC6 call far 17D3:0388
017D:4FCB mov ES,word ptr DS:[0x538C]
017D:4FCF mov word ptr ES:[0xA44B],0x0C45
017D:4FD6 mov ES,word ptr DS:[0x538E]
017D:4FDA mov word ptr ES:[0xA44D],0xC019
017D:4FE1 mov AX,0x00CC
017D:4FE4 push AX
017D:4FE5 call far 19FC:104E
017D:4FEA add SP,2
017D:4FED mov AX,1
017D:4FF0 push AX
017D:4FF1 mov AX,4
017D:4FF4 push AX
017D:4FF5 push CS
017D:4FF6 call near 0x2DA8
017D:4FF9 add SP,4
017D:4FFC call far 19FC:1DA8
017D:5001 mov ES,word ptr DS:[0x538E]
017D:5005 push word ptr ES:[0xA44D]
017D:500A mov ES,word ptr DS:[0x538C]
017D:500E push word ptr ES:[0xA44B]
017D:5013 call far 19FC:1314
017D:5018 add SP,4
017D:501B call far 19FC:18EF
017D:5020 mov word ptr SS:[BP-4],0
017D:5025 sub AL,AL
017D:5027 mov BX,word ptr SS:[BP-4]
017D:502A mov ES,word ptr DS:[0x539A]
017D:502E mov byte ptr ES:[BX+0x40A6],AL
017D:5033 mov BX,word ptr SS:[BP-4]
017D:5036 mov byte ptr ES:[BX+0x409A],AL
017D:503B mov AL,0xFF
017D:503D mov BX,word ptr SS:[BP-4]
017D:5040 mov ES,word ptr DS:[0x53BE]
017D:5044 mov byte ptr ES:[BX+0x3978],AL
017D:5049 mov BX,word ptr SS:[BP-4]
017D:504C mov byte ptr ES:[BX+0x396C],AL
017D:5051 inc word ptr SS:[BP-4]
017D:5054 cmp word ptr SS:[BP-4],4
017D:5058 jl short 0x5025
017D:505A mov word ptr SS:[BP-4],4
017D:505F mov AL,0x10
017D:5061 mov BX,word ptr SS:[BP-4]
017D:5064 mov ES,word ptr DS:[0x539A]
017D:5068 mov byte ptr ES:[BX+0x40A6],AL
017D:506D mov BX,word ptr SS:[BP-4]
017D:5070 mov byte ptr ES:[BX+0x409A],AL
017D:5075 mov AL,0xFF
017D:5077 mov BX,word ptr SS:[BP-4]
017D:507A mov ES,word ptr DS:[0x53BE]
017D:507E mov byte ptr ES:[BX+0x3978],AL
017D:5083 mov BX,word ptr SS:[BP-4]
017D:5086 mov byte ptr ES:[BX+0x396C],AL
017D:508B inc word ptr SS:[BP-4]
017D:508E cmp word ptr SS:[BP-4],0x000C
017D:5092 jl short 0x505F
017D:5094 push CS
017D:5095 call near 0x051B
017D:5098 sub AL,AL
017D:509A mov ES,word ptr DS:[0x53D0]
017D:509E mov byte ptr ES:[0x0064],AL
017D:50A2 cbw
017D:50A3 mov word ptr DS:[0x01A8],AX
017D:50A6 mov ES,word ptr DS:[0x53B0]
017D:50AA mov word ptr ES:[0x398E],AX
017D:50AE mov ES,word ptr DS:[0x53EC]
017D:50B2 mov word ptr ES:[0x374A],AX
017D:50B6 mov AL,1
017D:50B8 mov ES,word ptr DS:[0x53D0]
017D:50BC mov byte ptr ES:[0x00FC],AL
017D:50C0 cbw
017D:50C1 mov word ptr DS:[0x014A],AX
017D:50C4 mov SP,BP
017D:50C6 pop BP
017D:50C7 ret far
017D:50C8 push BP
017D:50C9 mov BP,SP
017D:50CB mov AX,0x0032
017D:50CE call far 19FC:2FDC
017D:50D3 mov word ptr SS:[BP-22],0
017D:50D8 call far 19FC:0BC0
017D:50DD mov BX,word ptr SS:[BP-22]
017D:50E0 mov ES,word ptr DS:[0x5400]
017D:50E4 mov byte ptr ES:[BX+0x09FB],AL
017D:50E9 inc word ptr SS:[BP-22]
017D:50EC cmp word ptr SS:[BP-22],0x0100
017D:50F1 jl short 0x50D8
017D:50F3 mov ES,word ptr DS:[0x53E8]
017D:50F7 mov word ptr ES:[0x4FBC],0
017D:50FE mov AX,0x0130
017D:5101 mov DX,0x2965
017D:5104 push DX
017D:5105 push AX
017D:5106 call far 19FC:00D1
017D:510B add SP,4
017D:510E mov ES,word ptr DS:[0x53E8]
017D:5112 mov AX,1
017D:5115 mov word ptr SS:[BP-2],AX
017D:5118 mov word ptr SS:[BP-26],AX
017D:511B mov word ptr ES:[0x4FBC],AX
017D:511F push CS
017D:5120 call near 0x320B
017D:5123 jmp near 0x5269
017D:5126 mov ES,word ptr DS:[0x5384]
017D:512A mov word ptr ES:[0x3938],0
017D:5131 call far 18BA:002F
017D:5136 or AX,AX
017D:5138 jne short 0x513D
017D:513A jmp near 0x51F9
017D:513D push CS
017D:513E call near 0x2A2B
017D:5141 push CS
017D:5142 call near 0x4DC7
017D:5145 mov ES,word ptr DS:[0x5402]
017D:5149 cmp word ptr ES:[0x458C],0
017D:514F je short 0x5154
017D:5151 jmp near 0x51E0
017D:5154 mov AX,6
017D:5157 push AX
017D:5158 call far 17D3:0281
017D:515D add SP,2
017D:5160 call far 17D3:0388
017D:5165 sub AX,AX
017D:5167 push AX
017D:5168 call far 17D3:0004
017D:516D add SP,2
017D:5170 mov AX,0x0B0E
017D:5173 push DS
017D:5174 push AX
017D:5175 call far 17D3:03F5
017D:517A add SP,4
017D:517D mov AX,0x0B4C
017D:5180 push DS
017D:5181 push AX
017D:5182 call far 17D3:03F5
017D:5187 add SP,4
017D:518A mov AX,0x0B90
017D:518D push DS
017D:518E push AX
017D:518F call far 17D3:03F5
017D:5194 add SP,4
017D:5197 mov AX,0x0BE2
017D:519A push DS
017D:519B push AX
017D:519C call far 17D3:03F5
017D:51A1 add SP,4
017D:51A4 mov AX,0x0C0D
017D:51A7 push DS
017D:51A8 push AX
017D:51A9 call far 17D3:03F5
017D:51AE add SP,4
017D:51B1 mov AX,1
017D:51B4 push AX
017D:51B5 push CS
017D:51B6 call near 0x1A13
017D:51B9 add SP,2
017D:51BC or AX,AX
017D:51BE jne short 0x51E0
017D:51C0 mov AX,0x0C39
017D:51C3 push DS
017D:51C4 push AX
017D:51C5 call far 17D3:03F5
017D:51E0 sub AX,AX
017D:51E2 push AX
017D:51E3 push CS
017D:51E4 call near 0
017D:51F9 mov AX,2
017D:51FC push AX
017D:51FD push CS
017D:51FE call near 0x28CC
017D:5269 push CS
017D:526A call near 0x476D
017D:526D cmp word ptr SS:[BP-2],0
017D:5271 je short 0x5276
017D:5273 jmp near 0x5126
017D:5276 mov SP,BP
017D:5278 pop BP
017D:5279 ret far
06A4:000A push BP
06A4:000B mov BP,SP
06A4:000D mov AX,2
06A4:0010 call far 19FC:2FDC
06A4:0015 push SI
06A4:0016 mov word ptr SS:[BP-2],0
06A4:001B jmp short 0x0033
06A4:001D mov BX,word ptr SS:[BP-2]
06A4:0020 inc word ptr SS:[BP-2]
06A4:0023 les SI,word ptr SS:[BP+6]
06A4:0026 mov AL,byte ptr ES:[BX+SI]
06A4:0029 cbw
06A4:002A push AX
06A4:002B call far 19FC:0213
06A4:0030 add SP,2
06A4:0033 mov BX,word ptr SS:[BP-2]
06A4:0036 les SI,word ptr SS:[BP+6]
06A4:0039 cmp byte ptr ES:[BX+SI],0
06A4:003D jne short 0x001D
06A4:003F pop SI
06A4:0040 mov SP,BP
06A4:0042 pop BP
06A4:0043 ret far
06A4:0044 push BP
06A4:0045 mov BP,SP
06A4:0047 mov AX,0x001A
06A4:004A call far 19FC:2FDC
06A4:004F mov AX,0x0CD6
06A4:0052 push DS
06A4:0053 push AX
06A4:0054 push CS
06A4:0055 call near 0x000A
06A4:0058 add SP,4
06A4:005B mov AX,0x0D2A
06A4:005E push DS
06A4:005F push AX
06A4:0060 push CS
06A4:0061 call near 0x000A
06A4:0064 add SP,4
06A4:0067 call far 18BA:0259
06A4:006C mov ES,word ptr DS:[0x5408]
06A4:0070 mov word ptr ES:[0x4FBA],AX
06A4:0074 cmp AX,0x0031
06A4:0077 jl short 0x0067
06A4:0079 cmp AX,0x0034
06A4:007C jg short 0x0067
06A4:007E mov AX,0x0D92
06A4:0081 push DS
06A4:0082 push AX
06A4:0083 push CS
06A4:0084 call near 0x000A
06A4:0087 add SP,4
06A4:008A mov ES,word ptr DS:[0x540A]
06A4:008E sub AX,AX
06A4:0090 mov word ptr SS:[BP-18],AX
06A4:0093 mov word ptr ES:[0xD580],AX
06A4:0097 jmp short 0x010C
06A4:0099 call far 18BA:0259
06A4:009E mov word ptr SS:[BP-16],AX
06A4:00A1 cmp AX,0x0031
06A4:00A4 jl short 0x010C
06A4:00A6 cmp AX,0x0033
06A4:00A9 jg short 0x010C
06A4:00AB mov ES,word ptr DS:[0x540C]
06A4:00AF sub AX,0x0031
06A4:00B2 mov word ptr ES:[0x3FFE],AX
06A4:00B6 cmp AX,2
06A4:00B9 jne short 0x00EA
06A4:00BB mov word ptr ES:[0x3FFE],0
06A4:00C2 mov ES,word ptr DS:[0x540A]
06A4:00C6 mov word ptr ES:[0xD580],1
06A4:00CD mov AX,0x0E2C
06A4:00D0 push DS
06A4:00D1 push AX
06A4:00D2 push CS
06A4:00D3 call near 0x000A
06A4:00D6 add SP,4
06A4:00D9 mov AX,0x0E78
06A4:00DC push DS
06A4:00DD push AX
06A4:00DE push CS
06A4:00DF call near 0x000A
06A4:00E2 add SP,4
06A4:00E5 call far 18BA:0259
06A4:00EA mov ES,word ptr DS:[0x540C]
06A4:00EE cmp word ptr ES:[0x3FFE],0
06A4:00F4 je short 0x0107
06A4:00F6 mov AX,0x0DD0
06A4:00F9 push DS
06A4:00FA push AX
06A4:00FB push CS
06A4:00FC call near 0x000A
06A4:0107 mov word ptr SS:[BP-18],1
06A4:010C cmp word ptr SS:[BP-18],0
06A4:0110 je short 0x0099
06A4:0112 mov ES,word ptr DS:[0x5408]
06A4:0116 sub word ptr ES:[0x4FBA],0x0031
06A4:011C call far 0728:0C8F
06A4:0121 mov AX,2
06A4:0124 push AX
06A4:0125 call far 017D:28CC
06A4:012A add SP,2
06A4:012D mov ES,word ptr DS:[0x5408]
06A4:0131 cmp word ptr ES:[0x4FBA],0
06A4:0137 jne short 0x0144
06A4:0139 sub AX,AX
06A4:013B push AX
06A4:013C call far 19FC:0BA7
06A4:0144 mov AX,0x0230
06A4:0147 mov DX,0x2965
06A4:014A push DX
06A4:014B push AX
06A4:014C call far 19FC:00D1
06A4:0151 add SP,4
06A4:0154 mov AX,0x4614
06A4:0157 mov DX,0x2A0F
06A4:015A push DX
06A4:015B push AX
06A4:015C mov AX,0x0CA2
06A4:015F push DS
06A4:0160 push AX
06A4:0161 call far 18BA:063B
06A4:0166 add SP,8
06A4:0169 mov AX,0x244B
06A4:016C mov DX,0x1DE9
06A4:016F push DX
06A4:0170 push AX
06A4:0171 mov AX,0x4614
06A4:0174 mov DX,0x2A0F
06A4:0177 push DX
06A4:0178 push AX
06A4:0179 call far 18BA:049D
06A4:017E add SP,8
06A4:0181 mov ES,word ptr DS:[0x5408]
06A4:0185 cmp word ptr ES:[0x4FBA],2
06A4:018B jne short 0x01A1
06A4:018D mov AX,0xA800
06A4:0190 push AX
06A4:0191 mov AX,0x244B
06A4:0194 mov DX,0x1DE9
06A4:0197 push DX
06A4:0198 push AX
06A4:0199 call far 19FC:0260
06A4:01A1 mov ES,word ptr DS:[0x5408]
06A4:01A5 cmp word ptr ES:[0x4FBA],3
06A4:01AB je short 0x01B5
06A4:01AD mov AX,0
06A4:01B0 mov DX,0x2965
06A4:01B3 jmp short 0x01BB
06A4:01B5 mov AX,0x0010
06A4:01B8 mov DX,0x2965
06A4:01BB push DX
06A4:01BC push AX
06A4:01BD call far 18BA:0525
06A4:01C2 add SP,4
06A4:01C5 mov AX,0x00C8
06A4:01C8 push AX
06A4:01C9 mov AX,0x0028
06A4:01CC push AX
06A4:01CD sub AX,AX
06A4:01CF push AX
06A4:01D0 push AX
06A4:01D1 mov AX,0x244B
06A4:01D4 mov DX,0x1DE9
06A4:01D7 push DX
06A4:01D8 push AX
06A4:01D9 call far 18BA:0086
06A4:01DE add SP,0x000C
06A4:01E1 call far 017D:2A2B
06A4:01E6 mov word ptr SS:[BP-2],0x02BC
06A4:01EB jmp short 0x0207
06A4:01ED mov AX,1
06A4:01F0 push AX
06A4:01F1 call far 18BA:0006
06A4:01F6 add SP,2
06A4:01F9 call far 18BA:002F
06A4:01FE or AX,AX
06A4:0200 je short 0x0207
06A4:0202 mov word ptr SS:[BP-2],0
06A4:0207 mov AX,word ptr SS:[BP-2]
06A4:020A dec word ptr SS:[BP-2]
06A4:020D or AX,AX
06A4:020F jne short 0x01ED
06A4:0211 call far 017D:2A2B
06A4:0216 call far 017D:46A7
06A4:021B mov AX,0x0130
06A4:021E mov DX,0x2965
06A4:0221 push DX
06A4:0222 push AX
06A4:0223 call far 19FC:00D1
06A4:0228 add SP,4
06A4:022B mov AX,0x4614
06A4:022E mov DX,0x2A0F
06A4:0231 push DX
06A4:0232 push AX
06A4:0233 mov AX,0x0CAE
06A4:0236 push DS
06A4:0237 push AX
06A4:0238 call far 18BA:063B
06A4:023D add SP,8
06A4:0240 mov AX,0x244B
06A4:0243 mov DX,0x1DE9
06A4:0246 push DX
06A4:0247 push AX
06A4:0248 mov AX,0x4614
06A4:024B mov DX,0x2A0F
06A4:024E push DX
06A4:024F push AX
06A4:0250 call far 18BA:049D
06A4:0255 add SP,8
06A4:0258 mov ES,word ptr DS:[0x5408]
06A4:025C cmp word ptr ES:[0x4FBA],2
06A4:0262 jne short 0x0278
06A4:0264 mov AX,0xA800
06A4:0267 push AX
06A4:0268 mov AX,0x244B
06A4:026B mov DX,0x1DE9
06A4:026E push DX
06A4:026F push AX
06A4:0270 call far 19FC:0260
06A4:0278 mov AX,8
06A4:027B push AX
06A4:027C sub AX,AX
06A4:027E push AX
06A4:027F push AX
06A4:0280 mov AX,0x244B
06A4:0283 mov DX,0x1DE9
06A4:0286 push DX
06A4:0287 push AX
06A4:0288 call far 17D3:0AE5
06A4:028D add SP,0x000A
06A4:0290 mov ES,word ptr DS:[0x540E]
06A4:0294 mov word ptr ES:[0x4066],AX
06A4:0298 mov word ptr ES:[0x4068],DX
06A4:029D mov AX,0x0190
06A4:02A0 mov DX,0x2965
06A4:02A3 push DX
06A4:02A4 push AX
06A4:02A5 call far 19FC:00D1
06A4:02AA add SP,4
06A4:02AD mov AX,0x4614
06A4:02B0 mov DX,0x2A0F
06A4:02B3 push DX
06A4:02B4 push AX
06A4:02B5 mov AX,0x0CBB
06A4:02B8 push DS
06A4:02B9 push AX
06A4:02BA call far 18BA:063B
06A4:02BF add SP,8
06A4:02C2 mov AX,0x244B
06A4:02C5 mov DX,0x1DE9
06A4:02C8 push DX
06A4:02C9 push AX
06A4:02CA mov AX,0x4614
06A4:02CD mov DX,0x2A0F
06A4:02D0 push DX
06A4:02D1 push AX
06A4:02D2 call far 18BA:049D
06A4:02D7 add SP,8
06A4:02DA mov ES,word ptr DS:[0x5408]
06A4:02DE cmp word ptr ES:[0x4FBA],2
06A4:02E4 jne short 0x02FA
06A4:02E6 mov AX,0xA800
06A4:02E9 push AX
06A4:02EA mov AX,0x244B
06A4:02ED mov DX,0x1DE9
06A4:02F0 push DX
06A4:02F1 push AX
06A4:02F2 call far 19FC:0260
06A4:02FA mov AX,0x0042
06A4:02FD push AX
06A4:02FE sub AX,AX
06A4:0300 push AX
06A4:0301 push AX
06A4:0302 mov AX,0x244B
06A4:0305 mov DX,0x1DE9
06A4:0308 push DX
06A4:0309 push AX
06A4:030A call far 17D3:0AE5
06A4:030F add SP,0x000A
06A4:0312 mov ES,word ptr DS:[0x5410]
06A4:0316 mov word ptr ES:[0x4588],AX
06A4:031A mov word ptr ES:[0x458A],DX
06A4:031F mov AX,0x0170
06A4:0322 mov DX,0x2965
06A4:0325 push DX
06A4:0326 push AX
06A4:0327 call far 19FC:00D1
06A4:032C add SP,4
06A4:032F mov AX,0x4614
06A4:0332 mov DX,0x2A0F
06A4:0335 push DX
06A4:0336 push AX
06A4:0337 mov AX,0x0CC8
06A4:033A push DS
06A4:033B push AX
06A4:033C call far 18BA:063B
06A4:0341 add SP,8
06A4:0344 mov word ptr SS:[BP-10],0
06A4:0349 mov ES,word ptr DS:[0x5408]
06A4:034D cmp word ptr ES:[0x4FBA],0
06A4:0353 jne short 0x036D
06A4:0355 mov word ptr SS:[BP-10],1
06A4:035A mov word ptr ES:[0x4FBA],1
06A4:0361 mov AX,1
06A4:0364 push AX
06A4:0365 call far 19FC:2CE1
06A4:036D mov AX,0x244B
06A4:0370 mov DX,0x1DE9
06A4:0373 push DX
06A4:0374 push AX
06A4:0375 mov AX,0x4614
06A4:0378 mov DX,0x2A0F
06A4:037B push DX
06A4:037C push AX
06A4:037D call far 18BA:049D
06A4:0382 add SP,8
06A4:0385 cmp word ptr SS:[BP-10],0
06A4:0389 je short 0x03E9
06A4:038B mov AX,0x3E80
06A4:038E push AX
06A4:038F mov AX,0x4614
06A4:0392 mov DX,0x2A0F
06A4:0395 push DX
06A4:0396 push AX
06A4:0397 mov AX,0x244B
06A4:039A mov DX,0x1DE9
06A4:039D push DX
06A4:039E push AX
06A4:039F call far 19FC:0A76
06A4:03E9 mov ES,word ptr DS:[0x5408]
06A4:03ED cmp word ptr ES:[0x4FBA],2
06A4:03F3 jne short 0x040B
06A4:03F5 mov AX,0x3E80
06A4:03F8 push AX
06A4:03F9 mov AX,0x244B
06A4:03FC mov DX,0x1DE9
06A4:03FF push DX
06A4:0400 push AX
06A4:0401 push DX
06A4:0402 push AX
06A4:0403 call far 19FC:0572
06A4:040B mov word ptr SS:[BP-14],0
06A4:0410 mov AX,0x0018
06A4:0413 push AX
06A4:0414 mov AX,3
06A4:0417 push AX
06A4:0418 sub AX,AX
06A4:041A push AX
06A4:041B mov AX,3
06A4:041E imul word ptr SS:[BP-14]
06A4:0421 push AX
06A4:0422 push word ptr SS:[BP-14]
06A4:0425 call far 18BA:070A
06A4:042A add SP,0x000A
06A4:042D inc word ptr SS:[BP-14]
06A4:0430 cmp word ptr SS:[BP-14],0x000C
06A4:0434 jl short 0x0410
06A4:0436 mov word ptr SS:[BP-14],0x000C
06A4:043B mov AX,0x0018
06A4:043E push AX
06A4:043F mov AX,3
06A4:0442 push AX
06A4:0443 mov AX,0x0018
06A4:0446 push AX
06A4:0447 mov AX,3
06A4:044A imul word ptr SS:[BP-14]
06A4:044D sub AX,0x0024
06A4:0450 push AX
06A4:0451 push word ptr SS:[BP-14]
06A4:0454 call far 18BA:070A
06A4:0459 add SP,0x000A
06A4:045C inc word ptr SS:[BP-14]
06A4:045F cmp word ptr SS:[BP-14],0x0010
06A4:0463 jl short 0x043B
06A4:0465 mov word ptr SS:[BP-14],0x0010
06A4:046A mov AX,8
06A4:046D push AX
06A4:046E mov AX,1
06A4:0471 push AX
06A4:0472 mov AX,0x0018
06A4:0475 push AX
06A4:0476 mov AX,word ptr SS:[BP-14]
06A4:0479 sub AX,4
06A4:047C push AX
06A4:047D push word ptr SS:[BP-14]
06A4:0480 call far 18BA:070A
06A4:0485 add SP,0x000A
06A4:0488 inc word ptr SS:[BP-14]
06A4:048B cmp word ptr SS:[BP-14],0x0024
06A4:048F jl short 0x046A
06A4:0491 mov word ptr SS:[BP-22],9
06A4:0496 jmp short 0x04CE
06A4:0498 inc word ptr SS:[BP-14]
06A4:049B cmp word ptr SS:[BP-14],0x0018
06A4:049F jge short 0x04CB
06A4:04A1 mov AX,8
06A4:04A4 push AX
06A4:04A5 mov AX,1
06A4:04A8 push AX
06A4:04A9 mov AX,word ptr SS:[BP-22]
06A4:04AC mov CL,3
06A4:04AE shl AX,CL
06A4:04B0 push AX
06A4:04B1 push word ptr SS:[BP-14]
06A4:04B4 mov AX,0x000C
06A4:04B7 imul word ptr SS:[BP-22]
06A4:04BA add AX,word ptr SS:[BP-14]
06A4:04BD sub AX,0x0054
06A4:04C0 push AX
06A4:04C1 call far 18BA:070A
06A4:04C6 add SP,0x000A
06A4:04C9 jmp short 0x0498
06A4:04CB inc word ptr SS:[BP-22]
06A4:04CE cmp word ptr SS:[BP-22],0x0010
06A4:04D2 jge short 0x04DB
06A4:04D4 mov word ptr SS:[BP-14],0x000C
06A4:04D9 jmp short 0x049B
06A4:04DB mov AX,0x0018
06A4:04DE push AX
06A4:04DF mov AX,3
06A4:04E2 push AX
06A4:04E3 mov AX,0x0060
06A4:04E6 push AX
06A4:04E7 sub AX,AX
06A4:04E9 push AX
06A4:04EA mov AX,0x0078
06A4:04ED push AX
06A4:04EE call far 18BA:070A
06A4:04F3 add SP,0x000A
06A4:04F6 mov AX,0x0018
06A4:04F9 push AX
06A4:04FA mov AX,3
06A4:04FD push AX
06A4:04FE mov AX,0x0060
06A4:0501 push AX
06A4:0502 mov AX,3
06A4:0505 push AX
06A4:0506 mov AX,0x0079
06A4:0509 push AX
06A4:050A call far 18BA:070A
06A4:050F add SP,0x000A
06A4:0512 mov AX,0x0018
06A4:0515 push AX
06A4:0516 mov AX,3
06A4:0519 push AX
06A4:051A mov AX,0x0078
06A4:051D push AX
06A4:051E mov AX,9
06A4:0521 push AX
06A4:0522 mov AX,0x007A
06A4:0525 push AX
06A4:0526 call far 18BA:070A
06A4:052B add SP,0x000A
06A4:052E mov AX,0x0018
06A4:0531 push AX
06A4:0532 mov AX,3
06A4:0535 push AX
06A4:0536 mov AX,0x0078
06A4:0539 push AX
06A4:053A mov AX,6
06A4:053D push AX
06A4:053E mov AX,0x007B
06A4:0541 push AX
06A4:0542 call far 18BA:070A
06A4:0547 add SP,0x000A
06A4:054A mov AX,0x000E
06A4:054D push AX
06A4:054E mov AX,2
06A4:0551 push AX
06A4:0552 mov AX,0x00A0
06A4:0555 push AX
06A4:0556 mov AX,8
06A4:0559 push AX
06A4:055A mov AX,0x007C
06A4:055D push AX
06A4:055E call far 18BA:070A
06A4:0563 add SP,0x000A
06A4:0566 mov AX,0x000E
06A4:0569 push AX
06A4:056A mov AX,2
06A4:056D push AX
06A4:056E mov AX,0x00A0
06A4:0571 push AX
06A4:0572 mov AX,0x000A
06A4:0575 push AX
06A4:0576 mov AX,0x007D
06A4:0579 push AX
06A4:057A call far 18BA:070A
06A4:057F add SP,0x000A
06A4:0582 mov AX,8
06A4:0585 push AX
06A4:0586 mov AX,1
06A4:0589 push AX
06A4:058A mov AX,0x00A0
06A4:058D push AX
06A4:058E sub AX,AX
06A4:0590 push AX
06A4:0591 mov AX,0x007E
06A4:0594 push AX
06A4:0595 call far 18BA:070A
06A4:059A add SP,0x000A
06A4:059D mov AX,8
06A4:05A0 push AX
06A4:05A1 mov AX,1
06A4:05A4 push AX
06A4:05A5 mov AX,0x00A0
06A4:05A8 push AX
06A4:05A9 mov AX,1
06A4:05AC push AX
06A4:05AD mov AX,0x007F
06A4:05B0 push AX
06A4:05B1 call far 18BA:070A
06A4:05B6 add SP,0x000A
06A4:05B9 mov AX,0x0010
06A4:05BC push AX
06A4:05BD mov AX,2
06A4:05C0 push AX
06A4:05C1 mov AX,0x0090
06A4:05C4 push AX
06A4:05C5 mov AX,8
06A4:05C8 push AX
06A4:05C9 mov AX,0x0080
06A4:05CC push AX
06A4:05CD call far 18BA:070A
06A4:05D2 add SP,0x000A
06A4:05D5 mov AX,0x0010
06A4:05D8 push AX
06A4:05D9 mov AX,2
06A4:05DC push AX
06A4:05DD mov AX,0x0090
06A4:05E0 push AX
06A4:05E1 mov AX,0x000A
06A4:05E4 push AX
06A4:05E5 mov AX,0x0081
06A4:05E8 push AX
06A4:05E9 call far 18BA:070A
06A4:05EE add SP,0x000A
06A4:05F1 mov word ptr SS:[BP-22],0x0012
06A4:05F6 jmp short 0x062F
06A4:05F8 inc word ptr SS:[BP-14]
06A4:05FB cmp word ptr SS:[BP-14],8
06A4:05FF jge short 0x062C
06A4:0601 mov AX,8
06A4:0604 push AX
06A4:0605 mov AX,1
06A4:0608 push AX
06A4:0609 mov AX,word ptr SS:[BP-22]
06A4:060C mov CL,3
06A4:060E shl AX,CL
06A4:0610 push AX
06A4:0611 push word ptr SS:[BP-14]
06A4:0614 mov AX,word ptr SS:[BP-22]
06A4:0617 shl AX,1
06A4:0619 shl AX,1
06A4:061B add AX,word ptr SS:[BP-14]
06A4:061E add AX,0x0036
06A4:0621 push AX
06A4:0622 call far 18BA:070A
06A4:0627 add SP,0x000A
06A4:062A jmp short 0x05F8
06A4:062C inc word ptr SS:[BP-22]
06A4:062F cmp word ptr SS:[BP-22],0x0016
06A4:0633 jge short 0x063C
06A4:0635 mov word ptr SS:[BP-14],4
06A4:063A jmp short 0x05FB
06A4:063C mov word ptr SS:[BP-14],0
06A4:0641 mov AX,0x0018
06A4:0644 push AX
06A4:0645 mov AX,3
06A4:0648 push AX
06A4:0649 mov AX,0x0030
06A4:064C push AX
06A4:064D mov AX,3
06A4:0650 imul word ptr SS:[BP-14]
06A4:0653 push AX
06A4:0654 mov AX,word ptr SS:[BP-14]
06A4:0657 add AX,0x0092
06A4:065A push AX
06A4:065B call far 18BA:070A
06A4:0660 add SP,0x000A
06A4:0663 inc word ptr SS:[BP-14]
06A4:0666 cmp word ptr SS:[BP-14],0x000C
06A4:066A jl short 0x0641
06A4:066C mov word ptr SS:[BP-14],0
06A4:0671 mov AX,0x0018
06A4:0674 push AX
06A4:0675 mov AX,3
06A4:0678 push AX
06A4:0679 mov AX,0x0048
06A4:067C push AX
06A4:067D mov AX,3
06A4:0680 imul word ptr SS:[BP-14]
06A4:0683 push AX
06A4:0684 mov AX,word ptr SS:[BP-14]
06A4:0687 add AX,0x009E
06A4:068A push AX
06A4:068B call far 18BA:070A
06A4:0690 add SP,0x000A
06A4:0693 inc word ptr SS:[BP-14]
06A4:0696 cmp word ptr SS:[BP-14],4
06A4:069A jl short 0x0671
06A4:069C mov AX,0x0018
06A4:069F push AX
06A4:06A0 mov AX,3
06A4:06A3 push AX
06A4:06A4 mov AX,0x0060
06A4:06A7 push AX
06A4:06A8 mov AX,6
06A4:06AB push AX
06A4:06AC mov AX,0x00A2
06A4:06AF push AX
06A4:06B0 call far 18BA:070A
06A4:06B5 add SP,0x000A
06A4:06B8 mov AX,0x0018
06A4:06BB push AX
06A4:06BC mov AX,3
06A4:06BF push AX
06A4:06C0 mov AX,0x0060
06A4:06C3 push AX
06A4:06C4 mov AX,9
06A4:06C7 push AX
06A4:06C8 mov AX,0x00A3
06A4:06CB push AX
06A4:06CC call far 18BA:070A
06A4:06D1 add SP,0x000A
06A4:06D4 mov AX,0x0018
06A4:06D7 push AX
06A4:06D8 mov AX,3
06A4:06DB push AX
06A4:06DC mov AX,0x0078
06A4:06DF push AX
06A4:06E0 sub AX,AX
06A4:06E2 push AX
06A4:06E3 mov AX,0x00A4
06A4:06E6 push AX
06A4:06E7 call far 18BA:070A
06A4:06EC add SP,0x000A
06A4:06EF mov AX,0x0018
06A4:06F2 push AX
06A4:06F3 mov AX,3
06A4:06F6 push AX
06A4:06F7 mov AX,0x0078
06A4:06FA push AX
06A4:06FB mov AX,3
06A4:06FE push AX
06A4:06FF mov AX,0x00A5
06A4:0702 push AX
06A4:0703 call far 18BA:070A
06A4:0708 add SP,0x000A
06A4:070B mov word ptr SS:[BP-14],0x00A6
06A4:0710 mov AX,8
06A4:0713 push AX
06A4:0714 mov AX,1
06A4:0717 push AX
06A4:0718 mov AX,0x0020
06A4:071B push AX
06A4:071C mov AX,word ptr SS:[BP-14]
06A4:071F sub AX,0x009A
06A4:0722 push AX
06A4:0723 push word ptr SS:[BP-14]
06A4:0726 call far 18BA:070A
06A4:072B add SP,0x000A
06A4:072E inc word ptr SS:[BP-14]
06A4:0731 cmp word ptr SS:[BP-14],0x00BA
06A4:0736 jl short 0x0710
06A4:0738 mov word ptr SS:[BP-22],9
06A4:073D jmp short 0x0775
06A4:073F inc word ptr SS:[BP-14]
06A4:0742 cmp word ptr SS:[BP-14],0x0024
06A4:0746 jge short 0x0772
06A4:0748 mov AX,8
06A4:074B push AX
06A4:074C mov AX,1
06A4:074F push AX
06A4:0750 mov AX,word ptr SS:[BP-22]
06A4:0753 mov CL,3
06A4:0755 shl AX,CL
06A4:0757 push AX
06A4:0758 push word ptr SS:[BP-14]
06A4:075B mov AX,0x000C
06A4:075E imul word ptr SS:[BP-22]
06A4:0761 add AX,word ptr SS:[BP-14]
06A4:0764 add AX,0x0036
06A4:0767 push AX
06A4:0768 call far 18BA:070A
06A4:076D add SP,0x000A
06A4:0770 jmp short 0x073F
06A4:0772 inc word ptr SS:[BP-22]
06A4:0775 cmp word ptr SS:[BP-22],0x0010
06A4:0779 jge short 0x0782
06A4:077B mov word ptr SS:[BP-14],0x0018
06A4:0780 jmp short 0x0742
06A4:0782 mov word ptr SS:[BP-14],0x010A
06A4:0787 mov AX,8
06A4:078A push AX
06A4:078B mov AX,1
06A4:078E push AX
06A4:078F mov AX,0x0028
06A4:0792 push AX
06A4:0793 mov AX,word ptr SS:[BP-14]
06A4:0796 sub AX,0x00FE
06A4:0799 push AX
06A4:079A mov AX,word ptr SS:[BP-14]
06A4:079D add AX,4
06A4:07A0 push AX
06A4:07A1 call far 18BA:070A
06A4:07A6 add SP,0x000A
06A4:07A9 inc word ptr SS:[BP-14]
06A4:07AC cmp word ptr SS:[BP-14],0x011E
06A4:07B1 jl short 0x0787
06A4:07B3 mov word ptr SS:[BP-22],0x0010
06A4:07B8 jmp short 0x07F0
06A4:07BA inc word ptr SS:[BP-14]
06A4:07BD cmp word ptr SS:[BP-14],0x0018
06A4:07C1 jge short 0x07ED
06A4:07C3 mov AX,8
06A4:07C6 push AX
06A4:07C7 mov AX,1
06A4:07CA push AX
06A4:07CB mov AX,word ptr SS:[BP-22]
06A4:07CE mov CL,3
06A4:07D0 shl AX,CL
06A4:07D2 push AX
06A4:07D3 push word ptr SS:[BP-14]
06A4:07D6 mov AX,0x000C
06A4:07D9 imul word ptr SS:[BP-22]
06A4:07DC add AX,word ptr SS:[BP-14]
06A4:07DF add AX,0x0056
06A4:07E2 push AX
06A4:07E3 call far 18BA:070A
06A4:07E8 add SP,0x000A
06A4:07EB jmp short 0x07BA
06A4:07ED inc word ptr SS:[BP-22]
06A4:07F0 cmp word ptr SS:[BP-22],0x0017
06A4:07F4 jge short 0x07FD
06A4:07F6 mov word ptr SS:[BP-14],0x000C
06A4:07FB jmp short 0x07BD
06A4:07FD mov AX,0x000B
06A4:0800 push AX
06A4:0801 mov AX,2
06A4:0804 push AX
06A4:0805 mov AX,0x0090
06A4:0808 push AX
06A4:0809 sub AX,AX
06A4:080B push AX
06A4:080C mov AX,0x0176
06A4:080F push AX
06A4:0810 call far 18BA:070A
06A4:0815 add SP,0x000A
06A4:0818 mov AX,0x000B
06A4:081B push AX
06A4:081C mov AX,2
06A4:081F push AX
06A4:0820 mov AX,0x0090
06A4:0823 push AX
06A4:0824 mov AX,2
06A4:0827 push AX
06A4:0828 mov AX,0x0177
06A4:082B push AX
06A4:082C call far 18BA:070A
06A4:0831 add SP,0x000A
06A4:0834 call far 017D:50C8
0728:0002 push BP
0728:0003 mov BP,SP
0728:0005 mov AX,0x002A
0728:0008 call far 19FC:2FDC
0728:04F9 push BP
0728:04FA mov BP,SP
0728:04FC mov AX,0x0014
0728:04FF call far 19FC:2FDC
0728:094B push BP
0728:094C mov BP,SP
0728:094E mov AX,0x000E
0728:0951 call far 19FC:2FDC
0728:0956 push SI
0728:0957 sub AX,AX
0728:0959 mov word ptr SS:[BP-12],AX
0728:095C mov word ptr SS:[BP-4],AX
0728:095F mov word ptr SS:[BP-8],AX
0728:0962 mov word ptr SS:[BP-10],AX
0728:0965 mov word ptr SS:[BP-6],4
0728:096A mov SI,word ptr SS:[BP-6]
0728:096D shl SI,1
0728:096F mov ES,word ptr DS:[0x5416]
0728:0973 cmp word ptr ES:[SI+0x393C],0
0728:0979 jne short 0x0983
0728:097B cmp word ptr ES:[SI+0x3954],0
0728:0981 je short 0x0988
0728:0983 mov word ptr SS:[BP-10],1
0728:0988 mov BX,word ptr SS:[BP-6]
0728:098B shl BX,1
0728:098D cmp word ptr ES:[BX+0x3954],0
0728:0993 je short 0x09B1
0728:0995 mov AX,0x0011
0728:0998 imul word ptr SS:[BP-6]
0728:099B mov BX,AX
0728:099D mov ES,word ptr DS:[0x5412]
0728:09A1 cmp byte ptr ES:[BX-14613],0
0728:09A7 je short 0x09AE
0728:09A9 mov word ptr SS:[BP-12],1
0728:09AE inc word ptr SS:[BP-4]
0728:09B1 inc word ptr SS:[BP-6]
0728:09B4 cmp word ptr SS:[BP-6],0x000C
0728:09B8 jl short 0x096A
0728:09BA cmp word ptr SS:[BP-10],0
0728:09BE jne short 0x09C3
0728:09C0 jmp near 0x0B59
0728:09C3 mov AX,1
0728:09C6 push AX
0728:09C7 call far 17D3:0281
0728:0B59 pop SI
0728:0B5A mov SP,BP
0728:0B5C pop BP
0728:0B5D ret far
0728:0B5E xor AX,AX
0728:0B60 call far 19FC:2FDC
0728:0B65 mov AX,3
0728:0B68 push AX
0728:0B69 call far 17D3:0281
0728:0B6E add SP,2
0728:0B71 call far 17D3:0388
0728:0B76 mov AX,0x1115
0728:0B79 push DS
0728:0B7A push AX
0728:0B7B call far 17D3:03F5
0728:0B80 add SP,4
0728:0B83 mov ES,word ptr DS:[0x5420]
0728:0B87 push word ptr ES:[0x009E]
0728:0B8C call far 017D:1A13
0728:0B91 add SP,2
0728:0B94 ret far
0728:0B95 push BP
0728:0B96 mov BP,SP
0728:0B98 mov AX,0x0012
0728:0B9B call far 19FC:2FDC
0728:0BA0 push DI
0728:0BA1 push SI
0728:0BA2 mov word ptr SS:[BP-4],0x046C
0728:0BA7 mov word ptr SS:[BP-2],0
0728:0BAC mov ES,word ptr DS:[0x5422]
0728:0BB0 sub AX,AX
0728:0BB2 mov word ptr ES:[0x32AC],AX
0728:0BB6 mov SI,AX
0728:0BB8 call far 19FC:1FAD
0728:0BBD les BX,word ptr SS:[BP-4]
0728:0BC0 mov AX,word ptr ES:[BX]
0728:0BC3 mov DX,word ptr ES:[BX+2]
0728:0BC7 mov word ptr SS:[BP-12],AX
0728:0BCA mov word ptr SS:[BP-10],DX
0728:0BCD call far 19FC:1F9C
0728:0BD2 les BX,word ptr SS:[BP-4]
0728:0BD5 mov AX,word ptr SS:[BP-12]
0728:0BD8 mov DX,word ptr SS:[BP-10]
0728:0BDB cmp word ptr ES:[BX],AX
0728:0BDE jne short 0x0BE6
0728:0BE0 cmp word ptr ES:[BX+2],DX
0728:0BE4 je short 0x0BD2
0728:0BE6 call far 19FC:1FAD
0728:0BEB les BX,word ptr SS:[BP-4]
0728:0BEE mov AX,word ptr ES:[BX]
0728:0BF1 mov DX,word ptr ES:[BX+2]
0728:0BF5 add AX,4
0728:0BF8 adc DX,0
0728:0BFB mov word ptr SS:[BP-12],AX
0728:0BFE mov word ptr SS:[BP-10],DX
0728:0C01 call far 19FC:1F9C
0728:0C06 les BX,word ptr SS:[BP-4]
0728:0C09 mov AX,word ptr SS:[BP-12]
0728:0C0C mov DX,word ptr SS:[BP-10]
0728:0C0F cmp word ptr ES:[BX+2],DX
0728:0C13 ja short 0x0C29
0728:0C15 jb short 0x0C1C
0728:0C17 cmp word ptr ES:[BX],AX
0728:0C1A jae short 0x0C29
0728:0C1C inc SI
0728:0C1D mov DI,0x00C8
0728:0C20 jmp short 0x0C23
0728:0C22 dec DI
0728:0C23 or DI,DI
0728:0C25 je short 0x0C06
0728:0C27 jmp short 0x0C22
0728:0C29 mov AX,0x2710
0728:0C2C cwd
0728:0C2D push DX
0728:0C2E push AX
0728:0C2F mov AX,0x01C7
0728:0C32 cwd
0728:0C33 push DX
0728:0C34 push AX
0728:0C35 mov AX,SI
0728:0C37 cwd
0728:0C38 push DX
0728:0C39 push AX
0728:0C3A call far 19FC:3E2E
0728:0C3F push DX
0728:0C40 push AX
0728:0C41 call far 19FC:3D92
0728:0C46 mov ES,word ptr DS:[0x5424]
0728:0C4A mov word ptr ES:[0x3FF4],AX
0728:0C4E sub AX,AX
0728:0C50 mov word ptr SS:[BP-8],AX
0728:0C53 mov word ptr SS:[BP-14],AX
0728:0C56 mov word ptr SS:[BP-16],AX
0728:0C59 jmp short 0x0C61
0728:0C5B inc word ptr SS:[BP-14]
0728:0C5E inc word ptr SS:[BP-16]
0728:0C61 cmp word ptr SS:[BP-16],0x2710
0728:0C66 jge short 0x0C76
0728:0C68 call far 19FC:0B26
0728:0C6D or AX,AX
0728:0C6F je short 0x0C5B
0728:0C71 inc word ptr SS:[BP-8]
0728:0C74 jmp short 0x0C5E
0728:0C76 mov AX,word ptr SS:[BP-14]
0728:0C79 cmp word ptr SS:[BP-8],AX
0728:0C7C jle short 0x0C89
0728:0C7E mov ES,word ptr DS:[0x5422]
0728:0C82 mov word ptr ES:[0x32AC],1
0728:0C89 pop SI
0728:0C8A pop DI
0728:0C8B mov SP,BP
0728:0C8D pop BP
0728:0C8E ret far
0728:0C8F xor AX,AX
0728:0C91 call far 19FC:2FDC
0728:0C96 mov AX,0x4614
0728:0C99 mov DX,0x2A0F
0728:0C9C push DX
0728:0C9D push AX
0728:0C9E call far 19FC:1D8C
0728:0CA3 add SP,4
0728:0CA6 mov ES,word ptr DS:[0x5426]
0728:0CAA push word ptr ES:[0x4FBA]
0728:0CAF call far 19FC:2CE1
0728:0CB4 add SP,2
0728:0CB7 mov ES,word ptr DS:[0x5426]
0728:0CBB mov BX,word ptr ES:[0x4FBA]
0728:0CC0 shl BX,1
0728:0CC2 push word ptr DS:[BX+0x1140]
0728:0CC6 call far 19FC:0B73
0728:0CCB add SP,2
0728:0CCE call far 19FC:1FBE
0728:0CD3 push CS
0728:0CD4 call near 0x0B95
0728:0CD7 mov ES,word ptr DS:[0x5424]
0728:0CDB mov AX,word ptr ES:[0x3FF4]
0728:0CDF sub AX,4
0728:0CE2 cwd
0728:0CE3 mov CX,6
0728:0CE6 idiv CX
0728:0CE8 mov ES,word ptr DS:[0x5428]
0728:0CEC mov word ptr ES:[0x5006],AX
0728:0CF0 cmp AX,1
0728:0CF3 jge short 0x0CFC
0728:0CF5 mov word ptr ES:[0x5006],1
0728:0CFC call far 19FC:2CF7
0728:0D01 mov AX,0x0D26
0728:0D04 mov DX,0x0728
0728:0D07 push DX
0728:0D08 push AX
0728:0D09 call far 19FC:3C82
0728:0D0E add SP,4
0728:0D11 ret far
0728:0D3D push BP
0728:0D3E mov BP,SP
0728:0D40 mov AX,0x0036
0728:0D43 call far 19FC:2FDC
0728:0D48 push SI
0728:0D49 mov ES,word ptr DS:[0x542A]
0728:0D4D push word ptr ES:[0xA44D]
0728:0D52 mov ES,word ptr DS:[0x542C]
0728:0D56 push word ptr ES:[0xA44B]
0728:0D5B call far 19FC:1314
0728:0D60 add SP,4
0728:0D63 call far 19FC:1DF8
0728:0D68 call far 19FC:0BC0
0728:0D6D and AX,7
0728:0D70 add AX,0x000A
0728:0D73 mov word ptr SS:[BP-6],AX
0728:0D76 call far 19FC:0BC0
0728:0D7B test AL,1
0728:0D7D je short 0x0D87
0728:0D7F mov AX,word ptr SS:[BP-6]
0728:0D82 neg AX
0728:0D84 mov word ptr SS:[BP-6],AX
0728:0D87 call far 19FC:0BC0
0728:0D8C and AX,7
0728:0D8F add AX,0x000A
0728:0D92 mov word ptr SS:[BP-12],AX
0728:0D95 call far 19FC:0BC0
0728:0D9A test AL,1
0728:0D9C je short 0x0DA6
0728:0D9E mov AX,word ptr SS:[BP-12]
0728:0DA1 neg AX
0728:0DA3 mov word ptr SS:[BP-12],AX
0728:0DA6 mov AX,word ptr SS:[BP-6]
0728:0DA9 add AX,0x001A
0728:0DAC mov word ptr SS:[BP-40],AX
0728:0DAF mov word ptr SS:[BP-48],AX
0728:0DB2 mov AX,word ptr SS:[BP-12]
0728:0DB5 add AX,0x000C
0728:0DB8 mov word ptr SS:[BP-46],AX
0728:0DBB mov word ptr SS:[BP-50],AX
0728:0DBE mov word ptr SS:[BP-32],0x000C
0728:0DC3 mov SI,word ptr SS:[BP-32]
0728:0DC6 shl SI,1
0728:0DC8 mov ES,word ptr DS:[0x542E]
0728:0DCC mov word ptr ES:[SI+0x406A],0
0728:0DD3 mov AX,0xFFFF
0728:0DD6 mov ES,word ptr DS:[0x5430]
0728:0DDA mov word ptr ES:[SI+0x4036],AX
0728:0DDF mov ES,word ptr DS:[0x5432]
0728:0DE3 mov word ptr ES:[SI+0x4004],AX
0728:0DE8 inc word ptr SS:[BP-32]
0728:0DEB cmp word ptr SS:[BP-32],0x0018
0728:0DEF jl short 0x0DC3
0728:0DF1 mov word ptr SS:[BP-32],8
0728:0DF6 mov AX,0x0011
0728:0DF9 imul word ptr SS:[BP-32]
0728:0DFC mov BX,AX
0728:0DFE mov ES,word ptr DS:[0x5412]
0728:0E02 mov byte ptr ES:[BX-14828],0xFF
0728:0E08 call far 19FC:0BC0
0728:0E0D test AL,1
0728:0E0F jne short 0x0E14
0728:0E11 jmp near 0x0EFF
0728:0E14 mov AX,0x0011
0728:0E17 imul word ptr SS:[BP-32]
0728:0E1A mov SI,AX
0728:0E1C mov ES,word ptr DS:[0x5412]
0728:0E20 mov byte ptr ES:[SI-14828],1
0728:0E26 mov byte ptr ES:[SI-14816],8
0728:0E2C mov word ptr SS:[BP-36],0
0728:0E31 mov word ptr SS:[BP-34],0
0728:0E36 call far 19FC:0BC0
0728:0E3B and AX,3
0728:0E3E add word ptr SS:[BP-36],AX
0728:0E41 inc word ptr SS:[BP-34]
0728:0E44 cmp word ptr SS:[BP-34],7
0728:0E48 jl short 0x0E36
0728:0E4A mov AX,0x0011
0728:0E4D imul word ptr SS:[BP-32]
0728:0E50 mov SI,AX
0728:0E52 mov BX,word ptr SS:[BP-36]
0728:0E55 mov ES,word ptr DS:[0x5434]
0728:0E59 mov AL,byte ptr ES:[BX+0x2CF4]
0728:0E5E mov ES,word ptr DS:[0x5412]
0728:0E62 mov byte ptr ES:[SI-14817],AL
0728:0E67 call far 017D:19DD
0728:0E6C mov ES,word ptr DS:[0x5412]
0728:0E70 mov byte ptr ES:[SI-14827],AL
0728:0E75 mov AX,0x0011
0728:0E78 imul word ptr SS:[BP-32]
0728:0E7B mov SI,AX
0728:0E7D mov AL,0x0A
0728:0E7F imul byte ptr ES:[SI-14827]
0728:0E84 mov byte ptr ES:[SI-14813],AL
0728:0E89 call far 017D:19DD
0728:0E8E mov ES,word ptr DS:[0x5412]
0728:0E92 mov byte ptr ES:[SI-14826],AL
0728:0E97 mov word ptr SS:[BP-36],0
0728:0E9C call far 19FC:0BC0
0728:0EA1 and AL,3
0728:0EA3 mov CX,AX
0728:0EA5 mov AX,0x0011
0728:0EA8 imul word ptr SS:[BP-32]
0728:0EAB mov BX,AX
0728:0EAD add BX,word ptr SS:[BP-36]
0728:0EB0 mov ES,word ptr DS:[0x5412]
0728:0EB4 mov byte ptr ES:[BX-14824],CL
0728:0EB9 inc word ptr SS:[BP-36]
0728:0EBC cmp word ptr SS:[BP-36],7
0728:0EC0 jl short 0x0E9C
0728:0EC2 call far 19FC:0BC0
0728:0EC7 and AL,3
0728:0EC9 mov CX,AX
0728:0ECB mov AX,0x0011
0728:0ECE imul word ptr SS:[BP-32]
0728:0ED1 mov BX,AX
0728:0ED3 mov ES,word ptr DS:[0x5412]
0728:0ED7 mov byte ptr ES:[BX-14815],CL
0728:0EDC call far 017D:19DD
0728:0EE1 mov word ptr SS:[BP-54],AX
0728:0EE4 call far 017D:19DD
0728:0EE9 add AL,byte ptr SS:[BP-54]
0728:0EEC mov CX,AX
0728:0EEE mov AX,0x0011
0728:0EF1 imul word ptr SS:[BP-32]
0728:0EF4 mov BX,AX
0728:0EF6 mov ES,word ptr DS:[0x5412]
0728:0EFA mov byte ptr ES:[BX-14814],CL
0728:0EFF inc word ptr SS:[BP-32]
0728:0F02 cmp word ptr SS:[BP-32],0x0010
0728:0F06 jge short 0x0F0B
0728:0F08 jmp near 0x0DF6
0728:0F0B mov word ptr SS:[BP-32],4
0728:0F10 mov AX,0x007D
0728:0F13 imul word ptr SS:[BP-32]
0728:0F16 mov BX,AX
0728:0F18 mov ES,word ptr DS:[0x5412]
0728:0F1C mov byte ptr ES:[BX-14556],0xFF
0728:0F22 call far 19FC:0BC0
0728:0F27 test AL,1
0728:0F29 jne short 0x0F2E
0728:0F2B jmp near 0x0FB3
0728:0F2E mov AX,0x007D
0728:0F31 imul word ptr SS:[BP-32]
0728:0F34 mov BX,AX
0728:0F36 mov ES,word ptr DS:[0x5412]
0728:0F3A cmp byte ptr ES:[BX-15056],0xFF
0728:0F40 je short 0x0FB3
0728:0F42 call far 19FC:0BC0
0728:0F47 cwd
0728:0F48 mov CX,3
0728:0F4B idiv CX
0728:0F4D mov word ptr SS:[BP-52],DX
0728:0F50 mov BX,DX
0728:0F52 shl BX,1
0728:0F54 shl BX,1
0728:0F56 mov ES,word ptr DS:[0x5436]
0728:0F5A mov AX,word ptr ES:[BX+0x2DF8]
0728:0F5F mov DX,word ptr ES:[BX+0x2DFA]
0728:0F64 mov word ptr SS:[BP-10],AX
0728:0F67 mov word ptr SS:[BP-8],DX
0728:0F6A mov word ptr SS:[BP-26],0
0728:0F6F les BX,word ptr SS:[BP-10]
0728:0F72 inc word ptr SS:[BP-10]
0728:0F75 mov AL,byte ptr ES:[BX]
0728:0F78 mov CX,AX
0728:0F7A mov AX,0x007D
0728:0F7D imul word ptr SS:[BP-32]
0728:0F80 mov BX,AX
0728:0F82 add BX,word ptr SS:[BP-26]
0728:0F85 mov ES,word ptr DS:[0x5412]
0728:0F89 mov byte ptr ES:[BX-14556],CL
0728:0F8E inc word ptr SS:[BP-26]
0728:0F91 cmp word ptr SS:[BP-26],0x007D
0728:0F95 jl short 0x0F6F
0728:0F97 mov BX,word ptr SS:[BP-32]
0728:0F9A mov ES,word ptr DS:[0x541C]
0728:0F9E mov byte ptr ES:[BX-10906],0
0728:0FA4 cmp word ptr SS:[BP-52],0
0728:0FA8 je short 0x0FB3
0728:0FAA mov BX,word ptr SS:[BP-32]
0728:0FAD mov byte ptr ES:[BX-10906],0x92
0728:0FB3 inc word ptr SS:[BP-32]
0728:0FB6 cmp word ptr SS:[BP-32],8
0728:0FBA jge short 0x0FBF
0728:0FBC jmp near 0x0F10
0728:0FBF sub AX,AX
0728:0FC1 mov word ptr SS:[BP-22],AX
0728:0FC4 mov word ptr SS:[BP-20],AX
0728:0FC7 mov word ptr SS:[BP-44],AX
0728:0FCA mov word ptr SS:[BP-32],8
0728:0FCF jmp near 0x1152
0728:0FD2 inc word ptr SS:[BP-40]
0728:0FD5 inc word ptr SS:[BP-44]
0728:0FD8 cmp word ptr SS:[BP-44],0x0010
0728:0FDC jle short 0x0FEC
0728:0FDE mov word ptr SS:[BP-44],0
0728:0FE3 mov AX,word ptr SS:[BP-48]
0728:0FE6 mov word ptr SS:[BP-40],AX
0728:0FE9 inc word ptr SS:[BP-46]
0728:0FEC cmp word ptr SS:[BP-14],0
0728:0FF0 je short 0x0FF5
0728:0FF2 jmp near 0x1174
0728:0FF5 mov AX,word ptr SS:[BP-40]
0728:0FF8 sub AX,0x000D
0728:0FFB sar AX,1
0728:0FFD mov ES,word ptr DS:[0x543E]
0728:1001 add AX,word ptr ES:[0x09EF]
0728:1006 mov word ptr SS:[BP-2],AX
0728:1009 test byte ptr SS:[BP-40],1
0728:100D jne short 0x101E
0728:100F mov ES,word ptr DS:[0x542C]
0728:1013 test byte ptr ES:[0xA44B],1
0728:1019 je short 0x101E
0728:101B inc word ptr SS:[BP-2]
0728:101E mov AX,word ptr SS:[BP-46]
0728:1021 sar AX,1
0728:1023 mov CX,0x0018
0728:1026 imul CX
0728:1028 mov ES,word ptr DS:[0x5440]
0728:102C add AX,word ptr ES:[0x09F1]
0728:1031 mov word ptr SS:[BP-4],AX
0728:1034 test byte ptr SS:[BP-46],1
0728:1038 je short 0x104A
0728:103A mov ES,word ptr DS:[0x542A]
0728:103E test byte ptr ES:[0xA44D],1
0728:1044 je short 0x104A
0728:1046 add word ptr SS:[BP-4],0x0018
0728:104A cmp word ptr SS:[BP-2],0
0728:104E jge short 0x1053
0728:1050 jmp near 0x10FD
0728:1053 cmp word ptr SS:[BP-2],0x0018
0728:1057 jl short 0x105C
0728:1059 jmp near 0x10FD
0728:105C cmp word ptr SS:[BP-4],0
0728:1060 jge short 0x1065
0728:1062 jmp near 0x10FD
0728:1065 cmp word ptr SS:[BP-4],0x0240
0728:106A jl short 0x106F
0728:106C jmp near 0x10FD
0728:106F mov AX,word ptr SS:[BP-40]
0728:1072 mov ES,word ptr DS:[0x542C]
0728:1076 add AX,word ptr ES:[0xA44B]
0728:107B sub AX,0x001A
0728:107E mov word ptr SS:[BP-16],AX
0728:1081 test byte ptr SS:[BP-16],0x80
0728:1085 je short 0x1099
0728:1087 cmp word ptr SS:[BP-40],0x001A
0728:108B jge short 0x1094
0728:108D and word ptr SS:[BP-16],0x0F7F
0728:1092 jmp short 0x1099
0728:1094 add word ptr SS:[BP-16],0x0080
0728:1099 mov AX,word ptr SS:[BP-46]
0728:109C mov ES,word ptr DS:[0x542A]
0728:10A0 add AX,word ptr ES:[0xA44D]
0728:10A5 sub AX,0x000C
0728:10A8 mov word ptr SS:[BP-18],AX
0728:10AB test byte ptr SS:[BP-18],0x80
0728:10AF je short 0x10C3
0728:10B1 cmp word ptr SS:[BP-46],0x000C
0728:10B5 jge short 0x10BE
0728:10B7 and word ptr SS:[BP-18],0xF07F
0728:10BC jmp short 0x10C3
0728:10BE add word ptr SS:[BP-18],0x0F80
0728:10C3 mov SI,word ptr SS:[BP-32]
0728:10C6 shl SI,1
0728:10C8 mov AX,word ptr SS:[BP-16]
0728:10CB mov ES,word ptr DS:[0x5432]
0728:10CF mov word ptr ES:[SI+0x4014],AX
0728:10D4 mov AX,word ptr SS:[BP-18]
0728:10D7 mov ES,word ptr DS:[0x5430]
0728:10DB mov word ptr ES:[SI+0x4046],AX
0728:10E0 mov BX,word ptr SS:[BP-32]
0728:10E3 mov ES,word ptr DS:[0x5442]
0728:10E7 mov byte ptr ES:[BX+0x40A2],0x10
0728:10ED mov ES,word ptr DS:[0x542E]
0728:10F1 mov word ptr ES:[SI+0x407A],1
0728:10F8 inc word ptr SS:[BP-20]
0728:10FB jmp short 0x1135
0728:10FD mov SI,word ptr SS:[BP-32]
0728:1100 shl SI,1
0728:1102 mov AX,0xFFFF
0728:1105 mov ES,word ptr DS:[0x5430]
0728:1109 mov word ptr ES:[SI+0x4046],AX
0728:110E mov ES,word ptr DS:[0x5432]
0728:1112 mov word ptr ES:[SI+0x4014],AX
0728:1117 mov CX,AX
0728:1119 mov AX,0x0011
0728:111C imul word ptr SS:[BP-32]
0728:111F mov BX,AX
0728:1121 mov ES,word ptr DS:[0x5412]
0728:1125 mov byte ptr ES:[BX-14828],CL
0728:112A mov ES,word ptr DS:[0x542E]
0728:112E mov word ptr ES:[SI+0x407A],0
0728:1135 inc word ptr SS:[BP-40]
0728:1138 inc word ptr SS:[BP-44]
0728:113B cmp word ptr SS:[BP-44],0x0010
0728:113F jle short 0x114F
0728:1141 mov word ptr SS:[BP-44],0
0728:1146 mov AX,word ptr SS:[BP-48]
0728:1149 mov word ptr SS:[BP-40],AX
0728:114C inc word ptr SS:[BP-46]
0728:114F inc word ptr SS:[BP-32]
0728:1152 cmp word ptr SS:[BP-32],0x0010
0728:1156 jl short 0x115B
0728:1158 jmp near 0x11F5
0728:115B mov AX,0x0011
0728:115E imul word ptr SS:[BP-32]
0728:1161 mov BX,AX
0728:1163 mov ES,word ptr DS:[0x5412]
0728:1167 cmp byte ptr ES:[BX-14828],0xFF
0728:116D je short 0x114F
0728:116F mov word ptr SS:[BP-14],1
0728:1174 mov AX,word ptr SS:[BP-46]
0728:1177 sar AX,1
0728:1179 mov CX,0x0018
0728:117C imul CX
0728:117E mov CX,word ptr SS:[BP-40]
0728:1181 sub CX,0x000D
0728:1184 sar CX,1
0728:1186 add AX,CX
0728:1188 mov ES,word ptr DS:[0x5438]
0728:118C add AX,word ptr ES:[0x09ED]
0728:1191 mov word ptr SS:[BP-24],AX
0728:1194 test byte ptr SS:[BP-40],1
0728:1198 jne short 0x11A9
0728:119A mov ES,word ptr DS:[0x542C]
0728:119E test byte ptr ES:[0xA44B],1
0728:11A4 je short 0x11A9
0728:11A6 inc word ptr SS:[BP-24]
0728:11A9 test byte ptr SS:[BP-46],1
0728:11AD je short 0x11BF
0728:11AF mov ES,word ptr DS:[0x542A]
0728:11B3 test byte ptr ES:[0xA44D],1
0728:11B9 je short 0x11BF
0728:11BB add word ptr SS:[BP-24],0x0018
0728:11BF mov BX,word ptr SS:[BP-24]
0728:11C2 mov ES,word ptr DS:[0x543A]
0728:11C6 mov AL,byte ptr ES:[BX+0x07AD]
0728:11CB sub AH,AH
0728:11CD mov word ptr SS:[BP-28],AX
0728:11D0 cmp AX,0x000F
0728:11D3 jg short 0x11D8
0728:11D5 jmp near 0x0FD2
0728:11D8 mov ES,word ptr DS:[0x543C]
0728:11DC cmp word ptr ES:[0x0150],AX
0728:11E1 jg short 0x11E6
0728:11E3 jmp near 0x0FD2
0728:11E6 or BX,BX
0728:11E8 jge short 0x11ED
0728:11EA jmp near 0x0FD2
0728:11ED mov word ptr SS:[BP-14],0
0728:11F2 jmp near 0x0FEC
0728:11F5 inc word ptr SS:[BP-40]
0728:11F8 inc word ptr SS:[BP-44]
0728:11FB mov word ptr SS:[BP-32],4
0728:1200 jmp near 0x13D6
0728:1203 inc word ptr SS:[BP-38]
0728:1206 mov BX,word ptr SS:[BP-24]
0728:1209 mov ES,word ptr DS:[0x543A]
0728:120D mov AL,byte ptr ES:[BX+0x07AD]
0728:1212 sub AH,AH
0728:1214 mov word ptr SS:[BP-28],AX
0728:1217 mov BX,word ptr SS:[BP-38]
0728:121A mov AL,byte ptr ES:[BX+0x07AD]
0728:121F mov word ptr SS:[BP-42],AX
0728:1222 cmp word ptr SS:[BP-28],0x000F
0728:1226 jle short 0x1257
0728:1228 mov ES,word ptr DS:[0x543C]
0728:122C mov AX,word ptr SS:[BP-28]
0728:122F cmp word ptr ES:[0x0150],AX
0728:1234 jle short 0x1257
0728:1236 cmp word ptr SS:[BP-24],0
0728:123A jl short 0x1257
0728:123C cmp word ptr SS:[BP-42],0x000F
0728:1240 jle short 0x1257
0728:1242 mov AX,word ptr SS:[BP-42]
0728:1245 cmp word ptr ES:[0x0150],AX
0728:124A jle short 0x1257
0728:124C or BX,BX
0728:124E jl short 0x1257
0728:1250 mov word ptr SS:[BP-14],0
0728:1255 jmp short 0x1271
0728:1257 inc word ptr SS:[BP-40]
0728:125A inc word ptr SS:[BP-44]
0728:125D cmp word ptr SS:[BP-44],0x0010
0728:1261 jle short 0x1271
0728:1263 mov word ptr SS:[BP-44],0
0728:1268 mov AX,word ptr SS:[BP-48]
0728:126B mov word ptr SS:[BP-40],AX
0728:126E inc word ptr SS:[BP-46]
0728:1271 cmp word ptr SS:[BP-14],0
0728:1275 je short 0x127A
0728:1277 jmp near 0x13F8
0728:127A mov AX,word ptr SS:[BP-40]
0728:127D sub AX,0x000D
0728:1280 sar AX,1
0728:1282 mov ES,word ptr DS:[0x543E]
0728:1286 add AX,word ptr ES:[0x09EF]
0728:128B mov word ptr SS:[BP-2],AX
0728:128E test byte ptr SS:[BP-40],1
0728:1292 jne short 0x12A3
0728:1294 mov ES,word ptr DS:[0x542C]
0728:1298 test byte ptr ES:[0xA44B],1
0728:129E je short 0x12A3
0728:12A0 inc word ptr SS:[BP-2]
0728:12A3 mov AX,word ptr SS:[BP-46]
0728:12A6 sar AX,1
0728:12A8 mov CX,0x0018
0728:12AB imul CX
0728:12AD mov ES,word ptr DS:[0x5440]
0728:12B1 add AX,word ptr ES:[0x09F1]
0728:12B6 mov word ptr SS:[BP-4],AX
0728:12B9 test byte ptr SS:[BP-46],1
0728:12BD je short 0x12CF
0728:12BF mov ES,word ptr DS:[0x542A]
0728:12C3 test byte ptr ES:[0xA44D],1
0728:12C9 je short 0x12CF
0728:12CB add word ptr SS:[BP-4],0x0018
0728:12CF cmp word ptr SS:[BP-2],0
0728:12D3 jge short 0x12D8
0728:12D5 jmp near 0x137F
0728:12D8 cmp word ptr SS:[BP-2],0x0018
0728:12DC jl short 0x12E1
0728:12DE jmp near 0x137F
0728:12E1 cmp word ptr SS:[BP-4],0
0728:12E5 jge short 0x12EA
0728:12E7 jmp near 0x137F
0728:12EA cmp word ptr SS:[BP-4],0x0240
0728:12EF jl short 0x12F4
0728:12F1 jmp near 0x137F
0728:12F4 mov AX,word ptr SS:[BP-40]
0728:12F7 mov ES,word ptr DS:[0x542C]
0728:12FB add AX,word ptr ES:[0xA44B]
0728:1300 sub AX,0x001A
0728:1303 mov word ptr SS:[BP-16],AX
0728:1306 test byte ptr SS:[BP-16],0x80
0728:130A je short 0x131E
0728:130C cmp word ptr SS:[BP-40],0x001A
0728:1310 jge short 0x1319
0728:1312 and word ptr SS:[BP-16],0x0F7F
0728:1317 jmp short 0x131E
0728:1319 add word ptr SS:[BP-16],0x0080
0728:131E mov AX,word ptr SS:[BP-46]
0728:1321 mov ES,word ptr DS:[0x542A]
0728:1325 add AX,word ptr ES:[0xA44D]
0728:132A sub AX,0x000C
0728:132D mov word ptr SS:[BP-18],AX
0728:1330 test byte ptr SS:[BP-18],0x80
0728:1334 je short 0x1348
0728:1336 cmp word ptr SS:[BP-46],0x000C
0728:133A jge short 0x1343
0728:133C and word ptr SS:[BP-18],0xF07F
0728:1341 jmp short 0x1348
0728:1343 add word ptr SS:[BP-18],0x0F80
0728:1348 mov SI,word ptr SS:[BP-32]
0728:134B shl SI,1
0728:134D mov AX,word ptr SS:[BP-16]
0728:1350 mov ES,word ptr DS:[0x5432]
0728:1354 mov word ptr ES:[SI+0x4014],AX
0728:1359 mov AX,word ptr SS:[BP-18]
0728:135C mov ES,word ptr DS:[0x5430]
0728:1360 mov word ptr ES:[SI+0x4046],AX
0728:1365 mov BX,word ptr SS:[BP-32]
0728:1368 mov ES,word ptr DS:[0x5442]
0728:136C mov byte ptr ES:[BX+0x40A2],0
0728:1372 mov ES,word ptr DS:[0x542E]
0728:1376 mov word ptr ES:[SI+0x407A],1
0728:137D jmp short 0x13B7
0728:137F mov SI,word ptr SS:[BP-32]
0728:1382 shl SI,1
0728:1384 mov AX,0xFFFF
0728:1387 mov ES,word ptr DS:[0x5430]
0728:138B mov word ptr ES:[SI+0x4046],AX
0728:1390 mov ES,word ptr DS:[0x5432]
0728:1394 mov word ptr ES:[SI+0x4014],AX
0728:1399 mov CX,AX
0728:139B mov AX,0x007D
0728:139E imul word ptr SS:[BP-32]
0728:13A1 mov BX,AX
0728:13A3 mov ES,word ptr DS:[0x5412]
0728:13A7 mov byte ptr ES:[BX-14556],CL
0728:13AC mov ES,word ptr DS:[0x542E]
0728:13B0 mov word ptr ES:[SI+0x407A],0
0728:13B7 add word ptr SS:[BP-40],3
0728:13BB add word ptr SS:[BP-44],3
0728:13BF cmp word ptr SS:[BP-44],8
0728:13C3 jle short 0x13D3
0728:13C5 mov word ptr SS:[BP-44],0
0728:13CA mov AX,word ptr SS:[BP-48]
0728:13CD mov word ptr SS:[BP-40],AX
0728:13D0 inc word ptr SS:[BP-46]
0728:13D3 inc word ptr SS:[BP-32]
0728:13D6 cmp word ptr SS:[BP-32],8
0728:13DA jl short 0x13DF
0728:13DC jmp near 0x1462
0728:13DF mov AX,0x007D
0728:13E2 imul word ptr SS:[BP-32]
0728:13E5 mov BX,AX
0728:13E7 mov ES,word ptr DS:[0x5412]
0728:13EB cmp byte ptr ES:[BX-14556],0xFF
0728:13F1 je short 0x13D3
0728:13F3 mov word ptr SS:[BP-14],1
0728:13F8 mov AX,word ptr SS:[BP-46]
0728:13FB sar AX,1
0728:13FD mov CX,0x0018
0728:1400 imul CX
0728:1402 mov CX,word ptr SS:[BP-40]
0728:1405 sub CX,0x000D
0728:1408 sar CX,1
0728:140A add AX,CX
0728:140C mov ES,word ptr DS:[0x5438]
0728:1410 add AX,word ptr ES:[0x09ED]
0728:1415 mov word ptr SS:[BP-24],AX
0728:1418 test byte ptr SS:[BP-40],1
0728:141C jne short 0x142D
0728:141E mov ES,word ptr DS:[0x542C]
0728:1422 test byte ptr ES:[0xA44B],1
0728:1428 je short 0x142D
0728:142A inc word ptr SS:[BP-24]
0728:142D test byte ptr SS:[BP-46],1
0728:1431 je short 0x1443
0728:1433 mov ES,word ptr DS:[0x542A]
0728:1437 test byte ptr ES:[0xA44D],1
0728:143D je short 0x1443
0728:143F add word ptr SS:[BP-24],0x0018
0728:1443 mov AX,word ptr SS:[BP-24]
0728:1446 mov word ptr SS:[BP-38],AX
0728:1449 mov AL,byte ptr SS:[BP-40]
0728:144C mov ES,word ptr DS:[0x542C]
0728:1450 xor AL,byte ptr ES:[0xA44B]
0728:1455 test AL,1
0728:1457 jne short 0x145C
0728:1459 jmp near 0x1203
0728:145C dec word ptr SS:[BP-38]
0728:145F jmp near 0x1206
0728:1462 pop SI
0728:1463 mov SP,BP
0728:1465 pop BP
0728:1466 ret far
0728:18E8 push BP
0728:18E9 mov BP,SP
0728:18EB mov AX,6
0728:18EE call far 19FC:2FDC
0728:18F3 push SI
0728:18F4 mov ES,word ptr DS:[0x541E]
0728:18F8 mov word ptr ES:[0x37FE],0x000F
0728:18FF cmp word ptr SS:[BP+6],4
0728:1903 jge short 0x195C
0728:1905 mov AX,0x007D
0728:1908 imul word ptr SS:[BP+6]
0728:190B mov BX,AX
0728:190D mov ES,word ptr DS:[0x5412]
0728:1911 mov AL,0x11
0728:1913 mul byte ptr ES:[BX-14435]
0728:1918 mov BX,AX
0728:191A mov AL,byte ptr ES:[BX-14828]
0728:191F cbw
0728:1920 mov BX,AX
0728:1922 shl BX,1
0728:1924 shl BX,1
0728:1926 mov ES,word ptr DS:[0x5414]
0728:192A push word ptr ES:[BX+0x01CC]
0728:192F push word ptr ES:[BX+0x01CA]
0728:1934 call far 17D3:03F5
0728:1939 add SP,4
0728:193C mov AX,0x121E
0728:193F push DS
0728:1940 push AX
0728:1941 call far 17D3:03F5
0728:1946 add SP,4
0728:1949 mov AX,0x007D
0728:194C imul word ptr SS:[BP+6]
0728:194F mov BX,AX
0728:1951 lea AX,BX-14556
0728:1955 mov DX,0x2A0F
0728:1958 push DX
0728:1959 jmp near 0x1AF0
0728:195C mov AX,word ptr SS:[BP+6]
0728:195F sub AX,4
0728:1962 mov word ptr SS:[BP-4],AX
0728:1965 mov AX,0x0011
0728:1968 imul word ptr SS:[BP-4]
0728:196B mov BX,AX
0728:196D mov ES,word ptr DS:[0x5412]
0728:1971 mov AL,byte ptr ES:[BX-14828]
0728:1976 cbw
0728:1977 mov BX,AX
0728:1979 shl BX,1
0728:197B shl BX,1
0728:197D mov ES,word ptr DS:[0x5414]
0728:1981 push word ptr ES:[BX+0x01CC]
0728:1986 push word ptr ES:[BX+0x01CA]
0728:198B call far 17D3:03F5
0728:1AF0 push AX
0728:1AF1 call far 17D3:03F5
0728:1AF6 add SP,4
0728:1AF9 pop SI
0728:1AFA mov SP,BP
0728:1AFC pop BP
0728:1AFD ret far
0CDA:0004 push BP
0CDA:0005 mov BP,SP
0CDA:0007 mov AX,4
0CDA:000A call far 19FC:2FDC
0CDA:01E9 push BP
0CDA:01EA mov BP,SP
0CDA:01EC mov AX,6
0CDA:01EF call far 19FC:2FDC
0CDA:0288 xor AX,AX
0CDA:028A call far 19FC:2FDC
0CDA:02A8 xor AX,AX
0CDA:02AA call far 19FC:2FDC
0CDA:02D2 push BP
0CDA:02D3 mov BP,SP
0CDA:02D5 xor AX,AX
0CDA:02D7 call far 19FC:2FDC
0CDA:03AA push BP
0CDA:03AB mov BP,SP
0CDA:03AD mov AX,2
0CDA:03B0 call far 19FC:2FDC
0CDA:04AB push BP
0CDA:04AC mov BP,SP
0CDA:04AE xor AX,AX
0CDA:04B0 call far 19FC:2FDC
0CDA:055A push BP
0CDA:055B mov BP,SP
0CDA:055D mov AX,8
0CDA:0560 call far 19FC:2FDC
0CDA:079C push BP
0CDA:079D mov BP,SP
0CDA:079F mov AX,2
0CDA:07A2 call far 19FC:2FDC
0CDA:0913 push BP
0CDA:0914 mov BP,SP
0CDA:0916 mov AX,2
0CDA:0919 call far 19FC:2FDC
0CDA:0980 push BP
0CDA:0981 mov BP,SP
0CDA:0983 mov AX,0x000A
0CDA:0986 call far 19FC:2FDC
0CDA:0AB6 push BP
0CDA:0AB7 mov BP,SP
0CDA:0AB9 mov AX,0x0016
0CDA:0ABC call far 19FC:2FDC
0DAE:000A push BP
0DAE:000B mov BP,SP
0DAE:000D mov AX,0x001A
0DAE:0010 call far 19FC:2FDC
0EC0:0004 push BP
0EC0:0005 mov BP,SP
0EC0:0007 mov AX,0x0026
0EC0:000A call far 19FC:2FDC
0EC0:0C72 push BP
0EC0:0C73 mov BP,SP
0EC0:0C75 mov AX,2
0EC0:0C78 call far 19FC:2FDC
0FAE:0006 push BP
0FAE:0007 mov BP,SP
0FAE:0009 mov AX,0x001C
0FAE:000C call far 19FC:2FDC
0FAE:0011 push DI
0FAE:0012 push SI
0FAE:0013 cmp word ptr SS:[BP+0x10],0
0FAE:0017 je short 0x002C
0FAE:0019 dec word ptr DS:[0x315A]
0FAE:001D jne short 0x0032
0FAE:001F mov word ptr DS:[0x315A],0x001E
0FAE:0025 xor byte ptr DS:[0x315C],8
0FAE:002A jmp short 0x0032
0FAE:002C mov word ptr DS:[0x315C],0
0FAE:0032 mov BX,word ptr SS:[BP+6]
0FAE:0035 and BX,0x007F
0FAE:0038 mov ES,word ptr DS:[0x5578]
0FAE:003C mov AL,byte ptr ES:[BX+0x3920]
0FAE:0041 cbw
0FAE:0042 mov word ptr SS:[BP-16],AX
0FAE:0045 mov ES,word ptr DS:[0x557A]
0FAE:0049 sub AX,AX
0FAE:004B mov word ptr SS:[BP-24],AX
0FAE:004E mov word ptr ES:[0x4590],AX
0FAE:0052 mov ES,word ptr DS:[0x557C]
0FAE:0056 mov word ptr ES:[0x458E],AX
0FAE:005A mov AL,byte ptr SS:[BP+6]
0FAE:005D and AL,0x7F
0FAE:005F cmp AL,4
0FAE:0061 jb short 0x006F
0FAE:0063 cmp word ptr SS:[BP+6],0x000C
0FAE:0067 jl short 0x0074
0FAE:0069 cmp word ptr SS:[BP+6],0x0010
0FAE:006D jge short 0x0074
0FAE:006F mov word ptr SS:[BP-24],1
0FAE:0074 push word ptr SS:[BP+0x0A]
0FAE:0077 push word ptr SS:[BP+8]
0FAE:007A mov ES,word ptr DS:[0x557E]
0FAE:007E push word ptr ES:[0xE488]
0FAE:0083 mov ES,word ptr DS:[0x5580]
0FAE:0087 push word ptr ES:[0xE486]
0FAE:008C call far 19FC:0971
0FAE:0091 add SP,8
0FAE:0094 mov word ptr SS:[BP-4],AX
0FAE:0097 inc AX
0FAE:0098 jne short 0x009D
0FAE:009A jmp near 0x02DE
0FAE:009D mov AX,word ptr SS:[BP-4]
0FAE:00A0 sub AX,word ptr SS:[BP-16]
0FAE:00A3 mov word ptr SS:[BP-22],AX
0FAE:00A6 or AX,AX
0FAE:00A8 je short 0x00C0
0FAE:00AA and word ptr SS:[BP-22],7
0FAE:00AE cmp word ptr SS:[BP-22],5
0FAE:00B2 jge short 0x00B9
0FAE:00B4 inc word ptr SS:[BP-16]
0FAE:00B7 jmp short 0x00BC
0FAE:00B9 dec word ptr SS:[BP-16]
0FAE:00BC and word ptr SS:[BP-16],7
0FAE:00C0 mov word ptr SS:[BP-20],7
0FAE:00C5 jmp near 0x01D6
0FAE:00C8 inc word ptr SS:[BP-14]
0FAE:00CB mov ES,word ptr DS:[0x5586]
0FAE:00CF mov BX,word ptr ES:[0x09ED]
0FAE:00D4 add BX,word ptr SS:[BP-14]
0FAE:00D7 mov ES,word ptr DS:[0x5588]
0FAE:00DB mov AL,byte ptr ES:[BX+0x07AD]
0FAE:00E0 sub AH,AH
0FAE:00E2 mov ES,word ptr DS:[0x558A]
0FAE:00E6 cmp AX,word ptr ES:[0x0150]
0FAE:00EB jb short 0x00F2
0FAE:00ED mov word ptr SS:[BP-12],0
0FAE:00F2 cmp word ptr SS:[BP-12],0
0FAE:00F6 jne short 0x00FB
0FAE:00F8 jmp near 0x0185
0FAE:00FB cmp word ptr SS:[BP+6],0x0080
0FAE:0100 jl short 0x0105
0FAE:0102 jmp near 0x0185
0FAE:0105 mov ES,word ptr DS:[0x5582]
0FAE:0109 mov AX,word ptr ES:[0xA44B]
0FAE:010D mov word ptr SS:[BP-26],AX
0FAE:0110 mov ES,word ptr DS:[0x5584]
0FAE:0114 mov AX,word ptr ES:[0xA44D]
0FAE:0118 mov word ptr SS:[BP-28],AX
0FAE:011B mov ES,word ptr DS:[0x5582]
0FAE:011F mov AX,word ptr SS:[BP-2]
0FAE:0122 mov word ptr ES:[0xA44B],AX
0FAE:0126 mov ES,word ptr DS:[0x5584]
0FAE:012A mov AX,word ptr SS:[BP-6]
0FAE:012D mov word ptr ES:[0xA44D],AX
0FAE:0131 mov SI,word ptr SS:[BP-16]
0FAE:0134 shl SI,1
0FAE:0136 sub AX,AX
0FAE:0138 push AX
0FAE:0139 push word ptr DS:[SI+0x312A]
0FAE:013D push word ptr DS:[SI+0x311A]
0FAE:0141 push word ptr SS:[BP+6]
0FAE:0144 push CS
0FAE:0145 call near 0x16AB
0FAE:0148 add SP,8
0FAE:014B or AX,AX
0FAE:014D je short 0x016F
0FAE:014F mov word ptr SS:[BP-12],0
0FAE:0154 mov AX,word ptr SS:[BP+8]
0FAE:0157 cmp word ptr SS:[BP-2],AX
0FAE:015A jne short 0x016F
0FAE:015C mov AX,word ptr SS:[BP+0x0A]
0FAE:015F cmp word ptr SS:[BP-6],AX
0FAE:0162 jne short 0x016F
0FAE:0164 mov ES,word ptr DS:[0x558C]
0FAE:0168 mov word ptr ES:[0xD57E],1
0FAE:016F mov ES,word ptr DS:[0x5582]
0FAE:0173 mov AX,word ptr SS:[BP-26]
0FAE:0176 mov word ptr ES:[0xA44B],AX
0FAE:017A mov ES,word ptr DS:[0x5584]
0FAE:017E mov AX,word ptr SS:[BP-28]
0FAE:0181 mov word ptr ES:[0xA44D],AX
0FAE:0185 cmp word ptr SS:[BP-12],0
0FAE:0189 je short 0x01D3
0FAE:018B mov ES,word ptr DS:[0x5580]
0FAE:018F mov AX,word ptr SS:[BP-2]
0FAE:0192 mov word ptr ES:[0xE486],AX
0FAE:0196 mov ES,word ptr DS:[0x557E]
0FAE:019A mov AX,word ptr SS:[BP-6]
0FAE:019D mov word ptr ES:[0xE488],AX
0FAE:01A1 mov AL,byte ptr SS:[BP-16]
0FAE:01A4 mov BX,word ptr SS:[BP+6]
0FAE:01A7 and BX,0x007F
0FAE:01AA mov ES,word ptr DS:[0x5578]
0FAE:01AE mov byte ptr ES:[BX+0x3920],AL
0FAE:01B3 mov SI,word ptr SS:[BP-16]
0FAE:01B6 shl SI,1
0FAE:01B8 mov ES,word ptr DS:[0x557C]
0FAE:01BC mov AX,word ptr DS:[SI+0x311A]
0FAE:01C0 mov word ptr ES:[0x458E],AX
0FAE:01C4 mov ES,word ptr DS:[0x557A]
0FAE:01C8 mov AX,word ptr DS:[SI+0x312A]
0FAE:01CC mov word ptr ES:[0x4590],AX
0FAE:01D0 jmp near 0x02DE
0FAE:01D3 dec word ptr SS:[BP-20]
0FAE:01D6 cmp word ptr SS:[BP-20],-1
0FAE:01DA jg short 0x01DF
0FAE:01DC jmp near 0x02DE
0FAE:01DF mov DI,word ptr SS:[BP-20]
0FAE:01E2 mov BX,word ptr DS:[0x315C]
0FAE:01E6 mov AL,byte ptr DS:[BX+DI+0x310A]
0FAE:01EA cbw
0FAE:01EB add AX,word ptr SS:[BP-16]
0FAE:01EE and AX,7
0FAE:01F1 mov word ptr SS:[BP-16],AX
0FAE:01F4 mov SI,AX
0FAE:01F6 shl SI,1
0FAE:01F8 mov AX,word ptr DS:[SI+0x311A]
0FAE:01FC mov ES,word ptr DS:[0x5580]
0FAE:0200 add AX,word ptr ES:[0xE486]
0FAE:0205 mov word ptr SS:[BP-2],AX
0FAE:0208 test byte ptr SS:[BP-2],0x80
0FAE:020C je short 0x0215
0FAE:020E mov AX,word ptr DS:[SI+0x313A]
0FAE:0212 add word ptr SS:[BP-2],AX
0FAE:0215 mov SI,word ptr SS:[BP-16]
0FAE:0218 shl SI,1
0FAE:021A mov AX,word ptr DS:[SI+0x312A]
0FAE:021E mov ES,word ptr DS:[0x557E]
0FAE:0222 add AX,word ptr ES:[0xE488]
0FAE:0227 mov word ptr SS:[BP-6],AX
0FAE:022A test byte ptr SS:[BP-6],0x80
0FAE:022E je short 0x0237
0FAE:0230 mov AX,word ptr DS:[SI+0x314A]
0FAE:0234 add word ptr SS:[BP-6],AX
0FAE:0237 mov SI,word ptr SS:[BP-16]
0FAE:023A shl SI,1
0FAE:023C mov AX,word ptr DS:[SI+0x311A]
0FAE:0240 add AX,word ptr SS:[BP+0x0C]
0FAE:0243 mov word ptr SS:[BP-8],AX
0FAE:0246 mov AX,word ptr DS:[SI+0x312A]
0FAE:024A add AX,word ptr SS:[BP+0x0E]
0FAE:024D mov word ptr SS:[BP-10],AX
0FAE:0250 sar AX,1
0FAE:0252 mov CX,0x0018
0FAE:0255 imul CX
0FAE:0257 mov CX,word ptr SS:[BP-8]
0FAE:025A sub CX,0x000D
0FAE:025D sar CX,1
0FAE:025F add AX,CX
0FAE:0261 mov word ptr SS:[BP-14],AX
0FAE:0264 test byte ptr SS:[BP-8],1
0FAE:0268 jne short 0x0279
0FAE:026A mov ES,word ptr DS:[0x5582]
0FAE:026E test byte ptr ES:[0xA44B],1
0FAE:0274 je short 0x0279
0FAE:0276 inc word ptr SS:[BP-14]
0FAE:0279 test byte ptr SS:[BP-10],1
0FAE:027D je short 0x028F
0FAE:027F mov ES,word ptr DS:[0x5584]
0FAE:0283 test byte ptr ES:[0xA44D],1
0FAE:0289 je short 0x028F
0FAE:028B add word ptr SS:[BP-14],0x0018
0FAE:028F mov ES,word ptr DS:[0x5586]
0FAE:0293 mov BX,word ptr ES:[0x09ED]
0FAE:0298 add BX,word ptr SS:[BP-14]
0FAE:029B mov ES,word ptr DS:[0x5588]
0FAE:029F mov AL,byte ptr ES:[BX+0x07AD]
0FAE:02A4 sub AH,AH
0FAE:02A6 mov word ptr SS:[BP-18],AX
0FAE:02A9 mov ES,word ptr DS:[0x558A]
0FAE:02AD cmp word ptr ES:[0x0150],AX
0FAE:02B2 jg short 0x02B7
0FAE:02B4 jmp near 0x01D3
0FAE:02B7 mov word ptr SS:[BP-12],1
0FAE:02BC cmp word ptr SS:[BP-24],0
0FAE:02C0 jne short 0x02C5
0FAE:02C2 jmp near 0x00F2
0FAE:02C5 mov AL,byte ptr SS:[BP-8]
0FAE:02C8 mov ES,word ptr DS:[0x5582]
0FAE:02CC xor AL,byte ptr ES:[0xA44B]
0FAE:02D1 test AL,1
0FAE:02D3 jne short 0x02D8
0FAE:02D5 jmp near 0x00C8
0FAE:02D8 dec word ptr SS:[BP-14]
0FAE:02DB jmp near 0x00CB
0FAE:02DE pop SI
0FAE:02DF pop DI
0FAE:02E0 mov SP,BP
0FAE:02E2 pop BP
0FAE:02E3 ret far
0FAE:032F push BP
0FAE:0330 mov BP,SP
0FAE:0332 xor AX,AX
0FAE:0334 call far 19FC:2FDC
0FAE:0339 mov ES,word ptr DS:[0x5584]
0FAE:033D push word ptr ES:[0xA44D]
0FAE:0342 mov ES,word ptr DS:[0x5582]
0FAE:0346 push word ptr ES:[0xA44B]
0FAE:034B call far 19FC:1314
0FAE:0350 add SP,4
0FAE:0353 call far 19FC:18EF
0FAE:0358 cmp word ptr SS:[BP+6],0
0FAE:035C je short 0x0365
0FAE:035E call far 017D:0E4B
0FAE:0365 call far 017D:051B
0FAE:036A call far 18BA:06C3
0FAE:036F mov AX,4
0FAE:0372 push AX
0FAE:0373 call far 17D3:0281
0FAE:0378 add SP,2
0FAE:037B call far 17D3:0388
0FAE:0380 mov AX,4
0FAE:0383 push AX
0FAE:0384 call far 17D3:0004
0FAE:0389 add SP,2
0FAE:038C mov AX,3
0FAE:038F push AX
0FAE:0390 call far 17D3:0281
0FAE:0395 add SP,2
0FAE:0398 call far 17D3:0388
0FAE:039D mov AX,3
0FAE:03A0 push AX
0FAE:03A1 call far 17D3:0004
0FAE:03A6 add SP,2
0FAE:03A9 pop BP
0FAE:03AA ret far
0FAE:03AB push BP
0FAE:03AC mov BP,SP
0FAE:03AE mov AX,0x003A
0FAE:03B1 call far 19FC:2FDC
0FAE:03B6 push DI
0FAE:03B7 push SI
0FAE:03B8 mov ES,word ptr DS:[0x5582]
0FAE:03BC mov AX,word ptr ES:[0xA44B]
0FAE:03C0 mov word ptr SS:[BP-20],AX
0FAE:03C3 mov ES,word ptr DS:[0x5584]
0FAE:03C7 mov AX,word ptr ES:[0xA44D]
0FAE:03CB mov word ptr SS:[BP-24],AX
0FAE:03CE mov SI,word ptr SS:[BP+6]
0FAE:03D1 shl SI,1
0FAE:03D3 mov ES,word ptr DS:[0x5590]
0FAE:03D7 push word ptr ES:[SI+0x4036]
0FAE:03DC mov ES,word ptr DS:[0x5592]
0FAE:03E0 push word ptr ES:[SI+0x4004]
0FAE:03E5 call far 017D:17BB
0FAE:03EA add SP,4
0FAE:03ED mov word ptr SS:[BP-14],0
0FAE:03F2 mov AX,0x0030
0FAE:03F5 imul word ptr SS:[BP+6]
0FAE:03F8 mov BX,AX
0FAE:03FA add BX,word ptr SS:[BP-14]
0FAE:03FD mov ES,word ptr DS:[0x5594]
0FAE:0401 mov byte ptr ES:[BX+0x32C6],0xFF
0FAE:0407 inc word ptr SS:[BP-14]
0FAE:040A cmp word ptr SS:[BP-14],0x0030
0FAE:040E jl short 0x03F2
0FAE:0410 mov word ptr SS:[BP-54],0
0FAE:0415 cmp word ptr SS:[BP+6],0x000C
0FAE:0419 jl short 0x0426
0FAE:041B sub word ptr SS:[BP+6],0x000C
0FAE:041F mov word ptr SS:[BP-54],4
0FAE:0424 jmp short 0x0433
0FAE:0426 mov BX,word ptr SS:[BP+6]
0FAE:0429 mov ES,word ptr DS:[0x5596]
0FAE:042D mov byte ptr ES:[BX+0x3994],1
0FAE:0433 mov word ptr SS:[BP-26],1
0FAE:0438 cmp word ptr SS:[BP+6],4
0FAE:043C jge short 0x0450
0FAE:043E mov BX,word ptr SS:[BP+6]
0FAE:0441 add BX,word ptr SS:[BP-54]
0FAE:0444 mov ES,word ptr DS:[0x5598]
0FAE:0448 cmp byte ptr ES:[BX+0x006E],0
0FAE:044E je short 0x0455
0FAE:0450 mov word ptr SS:[BP-26],0
0FAE:0455 cmp word ptr SS:[BP+6],4
0FAE:0459 jge short 0x046F
0FAE:045B push word ptr SS:[BP-26]
0FAE:045E mov AX,word ptr SS:[BP+6]
0FAE:0461 add AX,word ptr SS:[BP-54]
0FAE:0464 push AX
0FAE:0465 call far 11B8:22BC
0FAE:046F mov AX,word ptr SS:[BP+6]
0FAE:0472 add AX,word ptr SS:[BP-54]
0FAE:0475 push AX
0FAE:0476 call far 11B8:2474
0FAE:047B add SP,2
0FAE:047E mov word ptr SS:[BP-34],4
0FAE:0483 mov word ptr SS:[BP-52],0x000C
0FAE:0488 mov AX,0xFFFF
0FAE:048B mov word ptr SS:[BP-4],AX
0FAE:048E mov word ptr SS:[BP-2],AX
0FAE:0491 mov word ptr SS:[BP-10],0x7FFF
0FAE:0496 cmp word ptr SS:[BP-54],0
0FAE:049A je short 0x04A1
0FAE:049C mov word ptr SS:[BP-52],0
0FAE:04A1 mov word ptr SS:[BP-18],0x0017
0FAE:04A6 cmp word ptr SS:[BP+6],4
0FAE:04AA jge short 0x04AF
0FAE:04AC jmp near 0x0594
0FAE:04AF mov word ptr SS:[BP-34],8
0FAE:04B4 mov word ptr SS:[BP-52],0x0010
0FAE:04B9 cmp word ptr SS:[BP-54],0
0FAE:04BD jne short 0x04C2
0FAE:04BF jmp near 0x0594
0FAE:04C2 mov word ptr SS:[BP-52],4
0FAE:04C7 jmp near 0x0594
0FAE:04CA mov SI,word ptr SS:[BP-52]
0FAE:04CD shl SI,1
0FAE:04CF mov ES,word ptr DS:[0x559A]
0FAE:04D3 cmp word ptr ES:[SI+0x406A],0
0FAE:04D9 jne short 0x04DE
0FAE:04DB jmp near 0x0570
0FAE:04DE mov ES,word ptr DS:[0x5592]
0FAE:04E2 mov AX,word ptr ES:[SI+0x4004]
0FAE:04E7 mov word ptr SS:[BP-8],AX
0FAE:04EA mov ES,word ptr DS:[0x5590]
0FAE:04EE mov AX,word ptr ES:[SI+0x4036]
0FAE:04F3 mov word ptr SS:[BP-12],AX
0FAE:04F6 mov word ptr SS:[BP-56],1
0FAE:04FB mov ES,word ptr DS:[0x559C]
0FAE:04FF cmp word ptr ES:[0xE48E],0
0FAE:0505 je short 0x0512
0FAE:0507 cmp word ptr SS:[BP-52],0x000D
0FAE:050B jne short 0x0512
0FAE:050D mov word ptr SS:[BP-56],0
0FAE:0512 cmp word ptr SS:[BP-54],0
0FAE:0516 je short 0x0536
0FAE:0518 mov ES,word ptr DS:[0x558E]
0FAE:051C cmp byte ptr ES:[0xD333],0
0FAE:0522 je short 0x0536
0FAE:0524 mov AL,byte ptr ES:[0xD331]
0FAE:0528 cbw
0FAE:0529 add AX,4
0FAE:052C cmp AX,word ptr SS:[BP-52]
0FAE:052F jne short 0x0536
0FAE:0531 mov word ptr SS:[BP-56],0
0FAE:0536 cmp word ptr SS:[BP-56],0
0FAE:053A je short 0x0570
0FAE:053C push word ptr SS:[BP-12]
0FAE:053F push word ptr SS:[BP-8]
0FAE:0542 push CS
0FAE:0543 call near 0x0BB5
0FAE:0546 add SP,4
0FAE:0549 cmp AX,word ptr SS:[BP-10]
0FAE:054C jge short 0x0570
0FAE:054E push word ptr SS:[BP-12]
0FAE:0551 push word ptr SS:[BP-8]
0FAE:0554 push CS
0FAE:0555 call near 0x0BB5
0FAE:0558 add SP,4
0FAE:055B mov word ptr SS:[BP-10],AX
0FAE:055E mov AX,word ptr SS:[BP-8]
0FAE:0561 mov word ptr SS:[BP-2],AX
0FAE:0564 mov AX,word ptr SS:[BP-12]
0FAE:0567 mov word ptr SS:[BP-4],AX
0FAE:056A mov AX,word ptr SS:[BP-52]
0FAE:056D mov word ptr SS:[BP-18],AX
0FAE:0570 inc word ptr SS:[BP-52]
0FAE:0573 cmp word ptr SS:[BP-34],0
0FAE:0577 jne short 0x0594
0FAE:0579 cmp word ptr SS:[BP-2],-1
0FAE:057D jne short 0x0594
0FAE:057F cmp word ptr SS:[BP-52],0x000C
0FAE:0583 je short 0x058B
0FAE:0585 cmp word ptr SS:[BP-52],0x0018
0FAE:0589 jne short 0x058F
0FAE:058B sub word ptr SS:[BP-52],0x000C
0FAE:058F mov word ptr SS:[BP-34],8
0FAE:0594 mov AX,word ptr SS:[BP-34]
0FAE:0597 dec word ptr SS:[BP-34]
0FAE:059A or AX,AX
0FAE:059C je short 0x05A1
0FAE:059E jmp near 0x04CA
0FAE:05A1 cmp word ptr SS:[BP-54],0
0FAE:05A5 je short 0x05AB
0FAE:05A7 add word ptr SS:[BP+6],0x000C
0FAE:05AB cmp word ptr SS:[BP+6],0x0010
0FAE:05AF jge short 0x05BD
0FAE:05B1 cmp word ptr SS:[BP+6],4
0FAE:05B5 jl short 0x05FC
0FAE:05B7 cmp word ptr SS:[BP+6],0x000C
0FAE:05BB jge short 0x05FC
0FAE:05BD mov AX,0x0011
0FAE:05C0 imul word ptr SS:[BP+6]
0FAE:05C3 mov SI,AX
0FAE:05C5 mov ES,word ptr DS:[0x558E]
0FAE:05C9 mov AL,byte ptr ES:[SI-14885]
0FAE:05CE cbw
0FAE:05CF mov word ptr SS:[BP-28],AX
0FAE:05D2 cmp word ptr SS:[BP+6],0x0010
0FAE:05D6 jl short 0x05E1
0FAE:05D8 mov AL,byte ptr ES:[SI-14953]
0FAE:05DD cbw
0FAE:05DE mov word ptr SS:[BP-28],AX
0FAE:05E1 mov AX,0x0011
0FAE:05E4 imul word ptr SS:[BP-28]
0FAE:05E7 mov BX,AX
0FAE:05E9 mov AL,byte ptr DS:[BX+0x2EE6]
0FAE:05ED sub AH,AH
0FAE:05EF mov CL,5
0FAE:05F1 shr AX,CL
0FAE:05F3 and AX,7
0FAE:05F6 mov word ptr SS:[BP-44],AX
0FAE:05F9 jmp near 0x0688
0FAE:05FC mov word ptr SS:[BP-28],0x0020
0FAE:0601 mov word ptr SS:[BP-44],0x00FF
0FAE:0606 mov AX,word ptr SS:[BP+6]
0FAE:0609 mov word ptr SS:[BP-46],AX
0FAE:060C cmp word ptr SS:[BP-54],0
0FAE:0610 je short 0x0618
0FAE:0612 sub AX,8
0FAE:0615 mov word ptr SS:[BP-46],AX
0FAE:0618 mov word ptr SS:[BP-14],0x0033
0FAE:061D mov AX,0x007D
0FAE:0620 imul word ptr SS:[BP-46]
0FAE:0623 mov BX,AX
0FAE:0625 add BX,word ptr SS:[BP-14]
0FAE:0628 mov ES,word ptr DS:[0x558E]
0FAE:062C mov AL,byte ptr ES:[BX-14556]
0FAE:0631 sub AH,AH
0FAE:0633 mov word ptr SS:[BP-58],AX
0FAE:0636 or AX,AX
0FAE:0638 je short 0x066C
0FAE:063A test byte ptr SS:[BP-58],0x80
0FAE:063E jne short 0x066C
0FAE:0640 cmp AX,0x0010
0FAE:0643 jl short 0x066C
0FAE:0645 cmp AX,0x0020
0FAE:0648 jg short 0x066C
0FAE:064A mov AX,0x0011
0FAE:064D imul word ptr SS:[BP-58]
0FAE:0650 mov BX,AX
0FAE:0652 mov AL,byte ptr DS:[BX+0x2EE6]
0FAE:0656 sub AH,AH
0FAE:0658 and AX,0x00E0
0FAE:065B mov word ptr SS:[BP-6],AX
0FAE:065E mov AX,word ptr SS:[BP-44]
0FAE:0661 cmp word ptr SS:[BP-6],AX
0FAE:0664 jge short 0x066C
0FAE:0666 mov AX,word ptr SS:[BP-6]
0FAE:0669 mov word ptr SS:[BP-44],AX
0FAE:066C inc word ptr SS:[BP-14]
0FAE:066F cmp word ptr SS:[BP-14],0x0055
0FAE:0673 jle short 0x061D
0FAE:0675 cmp word ptr SS:[BP-44],0x00FF
0FAE:067A jne short 0x0683
0FAE:067C mov word ptr SS:[BP-44],0
0FAE:0681 jmp short 0x0688
0FAE:0683 mov CL,3
0FAE:0685 sar word ptr SS:[BP-44],CL
0FAE:0688 mov SI,word ptr SS:[BP-18]
0FAE:068B shl SI,1
0FAE:068D mov ES,word ptr DS:[0x5590]
0FAE:0691 push word ptr ES:[SI+0x4036]
0FAE:0696 mov ES,word ptr DS:[0x5592]
0FAE:069A push word ptr ES:[SI+0x4004]
0FAE:069F push word ptr SS:[BP-18]
0FAE:06A2 push word ptr SS:[BP+6]
0FAE:06A5 push CS
0FAE:06A6 call near 0x1BFE
0FAE:06A9 add SP,8
0FAE:06AC mov word ptr SS:[BP-50],AX
0FAE:06AF cmp word ptr SS:[BP+6],0x0010
0FAE:06B3 jge short 0x06C7
0FAE:06B5 cmp word ptr SS:[BP+6],4
0FAE:06B9 jge short 0x06BE
0FAE:06BB jmp near 0x0797
0FAE:06BE cmp word ptr SS:[BP+6],0x000C
0FAE:06C2 jl short 0x06C7
0FAE:06C4 jmp near 0x0797
0FAE:06C7 cmp word ptr SS:[BP-18],4
0FAE:06CB jl short 0x06DF
0FAE:06CD cmp word ptr SS:[BP-18],0x000C
0FAE:06D1 jge short 0x06D6
0FAE:06D3 jmp near 0x0797
0FAE:06D6 cmp word ptr SS:[BP-18],0x0010
0FAE:06DA jl short 0x06DF
0FAE:06DC jmp near 0x0797
0FAE:06DF cmp word ptr SS:[BP+6],0x000C
0FAE:06E3 jge short 0x06EA
0FAE:06E5 mov AX,1
0FAE:06E8 jmp short 0x06EC
0FAE:06EA sub AX,AX
0FAE:06EC mov ES,word ptr DS:[0x559E]
0FAE:06F0 mov word ptr ES:[0x3992],AX
0FAE:06F4 cmp word ptr SS:[BP+6],0x0010
0FAE:06F8 jl short 0x0705
0FAE:06FA mov ES,word ptr DS:[0x55A0]
0FAE:06FE mov word ptr ES:[0x374C],1
0FAE:0705 mov ES,word ptr DS:[0x5582]
0FAE:0709 mov AX,word ptr ES:[0xA44B]
0FAE:070D mov word ptr SS:[BP-30],AX
0FAE:0710 mov ES,word ptr DS:[0x5584]
0FAE:0714 mov AX,word ptr ES:[0xA44D]
0FAE:0718 mov word ptr SS:[BP-38],AX
0FAE:071B mov AX,word ptr SS:[BP-2]
0FAE:071E cmp word ptr SS:[BP-30],AX
0FAE:0721 jbe short 0x0739
0FAE:0723 mov AX,word ptr SS:[BP-30]
0FAE:0726 add AX,6
0FAE:0729 mov word ptr SS:[BP-2],AX
0FAE:072C test byte ptr SS:[BP-2],0x80
0FAE:0730 je short 0x0755
0FAE:0732 add word ptr SS:[BP-2],0x0080
0FAE:0737 jmp short 0x0755
0FAE:0739 mov AX,word ptr SS:[BP-2]
0FAE:073C cmp word ptr SS:[BP-30],AX
0FAE:073F jae short 0x0755
0FAE:0741 mov AX,word ptr SS:[BP-30]
0FAE:0744 sub AX,6
0FAE:0747 mov word ptr SS:[BP-2],AX
0FAE:074A test byte ptr SS:[BP-2],0x80
0FAE:074E je short 0x0755
0FAE:0750 and word ptr SS:[BP-2],0x0F7F
0FAE:0755 mov AX,word ptr SS:[BP-4]
0FAE:0758 cmp word ptr SS:[BP-38],AX
0FAE:075B jbe short 0x0773
0FAE:075D mov AX,word ptr SS:[BP-38]
0FAE:0760 add AX,6
0FAE:0763 mov word ptr SS:[BP-4],AX
0FAE:0766 test byte ptr SS:[BP-4],0x80
0FAE:076A je short 0x078F
0FAE:076C add word ptr SS:[BP-4],0x0F80
0FAE:0771 jmp short 0x078F
0FAE:0773 mov AX,word ptr SS:[BP-4]
0FAE:0776 cmp word ptr SS:[BP-38],AX
0FAE:0779 jae short 0x078F
0FAE:077B mov AX,word ptr SS:[BP-38]
0FAE:077E sub AX,6
0FAE:0781 mov word ptr SS:[BP-4],AX
0FAE:0784 test byte ptr SS:[BP-4],0x80
0FAE:0788 je short 0x078F
0FAE:078A and word ptr SS:[BP-4],0xF07F
0FAE:078F sub AX,AX
0FAE:0791 mov word ptr SS:[BP-50],AX
0FAE:0794 mov word ptr SS:[BP-44],AX
0FAE:0797 cmp word ptr SS:[BP-44],0
0FAE:079B je short 0x07A3
0FAE:079D cmp word ptr SS:[BP-50],0
0FAE:07A1 jne short 0x07EB
0FAE:07A3 mov AX,0x0030
0FAE:07A6 imul word ptr SS:[BP+6]
0FAE:07A9 mov SI,AX
0FAE:07AB mov AL,byte ptr SS:[BP-26]
0FAE:07AE mov ES,word ptr DS:[0x5594]
0FAE:07B2 mov byte ptr ES:[SI+0x32C6],AL
0FAE:07B7 mov AX,word ptr SS:[BP-2]
0FAE:07BA and AX,0x0F00
0FAE:07BD mov CX,word ptr SS:[BP-4]
0FAE:07C0 and CX,0xF000
0FAE:07C4 or AX,CX
0FAE:07C6 mov CL,8
0FAE:07C8 shr AX,CL
0FAE:07CA mov word ptr SS:[BP-36],AX
0FAE:07CD and word ptr SS:[BP-2],0x007F
0FAE:07D1 and word ptr SS:[BP-4],0x007F
0FAE:07D5 mov AL,byte ptr SS:[BP-36]
0FAE:07D8 mov byte ptr ES:[SI+0x32C7],AL
0FAE:07DD mov AL,byte ptr SS:[BP-2]
0FAE:07E0 mov byte ptr ES:[SI+0x32C8],AL
0FAE:07E5 mov AL,byte ptr SS:[BP-4]
0FAE:07E8 jmp near 0x08F4
0FAE:07EB mov AX,word ptr SS:[BP-44]
0FAE:07EE cmp word ptr SS:[BP-10],AX
0FAE:07F1 jg short 0x07F6
0FAE:07F3 jmp near 0x08F9
0FAE:07F6 mov ES,word ptr DS:[0x5582]
0FAE:07FA mov AX,word ptr ES:[0xA44B]
0FAE:07FE mov word ptr SS:[BP-30],AX
0FAE:0801 mov ES,word ptr DS:[0x5584]
0FAE:0805 mov AX,word ptr ES:[0xA44D]
0FAE:0809 mov word ptr SS:[BP-38],AX
0FAE:080C sub AX,AX
0FAE:080E mov word ptr SS:[BP-22],AX
0FAE:0811 mov word ptr SS:[BP-16],AX
0FAE:0814 mov ES,word ptr DS:[0x5582]
0FAE:0818 mov AX,word ptr SS:[BP-2]
0FAE:081B cmp word ptr ES:[0xA44B],AX
0FAE:0820 jbe short 0x0829
0FAE:0822 mov word ptr SS:[BP-16],0xFFFF
0FAE:0827 jmp short 0x0838
0FAE:0829 mov AX,word ptr SS:[BP-2]
0FAE:082C cmp word ptr ES:[0xA44B],AX
0FAE:0831 jae short 0x0838
0FAE:0833 mov word ptr SS:[BP-16],1
0FAE:0838 mov ES,word ptr DS:[0x5584]
0FAE:083C mov AX,word ptr SS:[BP-4]
0FAE:083F cmp word ptr ES:[0xA44D],AX
0FAE:0844 jbe short 0x084D
0FAE:0846 mov word ptr SS:[BP-22],0xFFFF
0FAE:084B jmp short 0x08A4
0FAE:084D mov AX,word ptr SS:[BP-4]
0FAE:0850 cmp word ptr ES:[0xA44D],AX
0FAE:0855 jae short 0x08A4
0FAE:0857 mov word ptr SS:[BP-22],1
0FAE:085C jmp short 0x08A4
0FAE:085E mov AX,word ptr SS:[BP-16]
0FAE:0861 add word ptr SS:[BP-30],AX
0FAE:0864 test byte ptr SS:[BP-30],0x80
0FAE:0868 je short 0x0881
0FAE:086A cmp AX,0xFFFF
0FAE:086D jne short 0x0876
0FAE:086F and word ptr SS:[BP-30],0x0F7F
0FAE:0874 jmp short 0x0881
0FAE:0876 cmp word ptr SS:[BP-16],1
0FAE:087A jne short 0x0881
0FAE:087C add word ptr SS:[BP-30],0x0080
0FAE:0881 mov AX,word ptr SS:[BP-22]
0FAE:0884 add word ptr SS:[BP-38],AX
0FAE:0887 test byte ptr SS:[BP-38],0x80
0FAE:088B je short 0x08A4
0FAE:088D cmp AX,0xFFFF
0FAE:0890 jne short 0x0899
0FAE:0892 and word ptr SS:[BP-38],0xF07F
0FAE:0897 jmp short 0x08A4
0FAE:0899 cmp word ptr SS:[BP-22],1
0FAE:089D jne short 0x08A4
0FAE:089F add word ptr SS:[BP-38],0x0F80
0FAE:08A4 mov AX,word ptr SS:[BP-10]
0FAE:08A7 dec word ptr SS:[BP-10]
0FAE:08AA cmp AX,word ptr SS:[BP-44]
0FAE:08AD jg short 0x085E
0FAE:08AF mov AX,0x0030
0FAE:08B2 imul word ptr SS:[BP+6]
0FAE:08B5 mov SI,AX
0FAE:08B7 mov AL,byte ptr SS:[BP-26]
0FAE:08BA mov ES,word ptr DS:[0x5594]
0FAE:08BE mov byte ptr ES:[SI+0x32C6],AL
0FAE:08C3 mov AX,word ptr SS:[BP-30]
0FAE:08C6 and AX,0x0F00
0FAE:08C9 mov CX,word ptr SS:[BP-38]
0FAE:08CC and CX,0xF000
0FAE:08D0 or AX,CX
0FAE:08D2 mov CL,8
0FAE:08D4 shr AX,CL
0FAE:08D6 mov word ptr SS:[BP-36],AX
0FAE:08D9 and word ptr SS:[BP-30],0x007F
0FAE:08DD and word ptr SS:[BP-38],0x007F
0FAE:08E1 mov AL,byte ptr SS:[BP-36]
0FAE:08E4 mov byte ptr ES:[SI+0x32C7],AL
0FAE:08E9 mov AL,byte ptr SS:[BP-30]
0FAE:08EC mov byte ptr ES:[SI+0x32C8],AL
0FAE:08F1 mov AL,byte ptr SS:[BP-38]
0FAE:08F4 mov byte ptr ES:[SI+0x32C9],AL
0FAE:08F9 cmp word ptr SS:[BP+6],4
0FAE:08FD jl short 0x0905
0FAE:08FF cmp word ptr SS:[BP+6],0x000C
0FAE:0903 jl short 0x090B
0FAE:0905 cmp word ptr SS:[BP+6],0x0010
0FAE:0909 jl short 0x0955
0FAE:090B mov AL,byte ptr SS:[BP-18]
0FAE:090E mov CX,AX
0FAE:0910 mov AX,0x000C
0FAE:0913 imul word ptr SS:[BP+6]
0FAE:0916 mov BX,AX
0FAE:0918 mov ES,word ptr DS:[0x55A2]
0FAE:091C mov byte ptr ES:[BX+0x3800],CL
0FAE:0921 mov ES,word ptr DS:[0x558E]
0FAE:0925 cmp byte ptr ES:[0xD333],0
0FAE:092B jne short 0x0930
0FAE:092D jmp near 0x0B7B
0FAE:0930 mov AL,byte ptr ES:[0xD331]
0FAE:0934 cbw
0FAE:0935 add AX,4
0FAE:0938 cmp AX,word ptr SS:[BP+6]
0FAE:093B je short 0x0940
0FAE:093D jmp near 0x0B7B
0FAE:0940 mov AX,0x000C
0FAE:0943 imul word ptr SS:[BP+6]
0FAE:0946 mov BX,AX
0FAE:0948 mov ES,word ptr DS:[0x55A2]
0FAE:094C mov byte ptr ES:[BX+0x3800],0xFF
0FAE:0952 jmp near 0x0B7B
0FAE:0955 cmp word ptr SS:[BP+6],4
0FAE:0959 jge short 0x0961
0FAE:095B cmp word ptr SS:[BP-18],0x0010
0FAE:095F jl short 0x097C
0FAE:0961 cmp word ptr SS:[BP+6],0x000C
0FAE:0965 jge short 0x096A
0FAE:0967 jmp near 0x0AA0
0FAE:096A cmp word ptr SS:[BP+6],0x0010
0FAE:096E jl short 0x0973
0FAE:0970 jmp near 0x0AA0
0FAE:0973 cmp word ptr SS:[BP-18],4
0FAE:0977 jl short 0x097C
0FAE:0979 jmp near 0x0AA0
0FAE:097C mov SI,word ptr SS:[BP+6]
0FAE:097F shl SI,1
0FAE:0981 mov ES,word ptr DS:[0x5592]
0FAE:0985 mov AX,word ptr ES:[SI+0x4004]
0FAE:098A mov word ptr SS:[BP-32],AX
0FAE:098D mov ES,word ptr DS:[0x5590]
0FAE:0991 mov AX,word ptr ES:[SI+0x4036]
0FAE:0996 mov word ptr SS:[BP-42],AX
0FAE:0999 mov AX,word ptr SS:[BP-32]
0FAE:099C and AX,0x0F00
0FAE:099F shr AX,1
0FAE:09A1 mov CX,word ptr SS:[BP-32]
0FAE:09A4 and CX,0x007F
0FAE:09A7 or AX,CX
0FAE:09A9 mov word ptr SS:[BP-32],AX
0FAE:09AC mov AX,word ptr SS:[BP-42]
0FAE:09AF and AX,0xF000
0FAE:09B2 mov CL,5
0FAE:09B4 shr AX,CL
0FAE:09B6 mov CX,word ptr SS:[BP-42]
0FAE:09B9 and CX,0x007F
0FAE:09BC or AX,CX
0FAE:09BE mov word ptr SS:[BP-42],AX
0FAE:09C1 inc word ptr SS:[BP-32]
0FAE:09C4 mov SI,word ptr SS:[BP-18]
0FAE:09C7 shl SI,1
0FAE:09C9 mov ES,word ptr DS:[0x5592]
0FAE:09CD mov AX,word ptr ES:[SI+0x4004]
0FAE:09D2 mov word ptr SS:[BP-40],AX
0FAE:09D5 mov ES,word ptr DS:[0x5590]
0FAE:09D9 mov AX,word ptr ES:[SI+0x4036]
0FAE:09DE mov word ptr SS:[BP-48],AX
0FAE:09E1 mov AX,word ptr SS:[BP-40]
0FAE:09E4 and AX,0x0F00
0FAE:09E7 shr AX,1
0FAE:09E9 mov CX,word ptr SS:[BP-40]
0FAE:09EC and CX,0x007F
0FAE:09EF or AX,CX
0FAE:09F1 mov word ptr SS:[BP-40],AX
0FAE:09F4 mov AX,word ptr SS:[BP-48]
0FAE:09F7 and AX,0xF000
0FAE:09FA mov CL,5
0FAE:09FC shr AX,CL
0FAE:09FE mov CX,word ptr SS:[BP-48]
0FAE:0A01 and CX,0x007F
0FAE:0A04 or AX,CX
0FAE:0A06 mov word ptr SS:[BP-48],AX
0FAE:0A09 inc word ptr SS:[BP-40]
0FAE:0A0C cmp word ptr SS:[BP-50],0
0FAE:0A10 jne short 0x0A15
0FAE:0A12 jmp near 0x0AA0
0FAE:0A15 mov AX,word ptr SS:[BP-40]
0FAE:0A18 sub AX,word ptr SS:[BP-32]
0FAE:0A1B push AX
0FAE:0A1C call far 19FC:3C6C
0FAE:0AA0 mov word ptr SS:[BP-14],0
0FAE:0AA5 mov AX,0x000C
0FAE:0AA8 imul word ptr SS:[BP+6]
0FAE:0AAB mov BX,AX
0FAE:0AAD add BX,word ptr SS:[BP-14]
0FAE:0AB0 mov ES,word ptr DS:[0x55A2]
0FAE:0AB4 mov byte ptr ES:[BX+0x3800],0xFF
0FAE:0ABA inc word ptr SS:[BP-14]
0FAE:0ABD cmp word ptr SS:[BP-14],0x000C
0FAE:0AC1 jl short 0x0AA5
0FAE:0AC3 mov BX,word ptr SS:[BP+6]
0FAE:0AC6 mov ES,word ptr DS:[0x5598]
0FAE:0ACA mov AL,byte ptr ES:[BX+0x006E]
0FAE:0ACF cbw
0FAE:0AD0 mov word ptr SS:[BP-52],AX
0FAE:0AD3 cmp BX,0x000C
0FAE:0AD6 jl short 0x0AE1
0FAE:0AD8 mov AL,byte ptr ES:[BX+0x0066]
0FAE:0ADD cbw
0FAE:0ADE mov word ptr SS:[BP-52],AX
0FAE:0AE1 cmp word ptr SS:[BP-52],0x001E
0FAE:0AE5 jge short 0x0B46
0FAE:0AE7 mov AX,BX
0FAE:0AE9 mov word ptr SS:[BP-46],AX
0FAE:0AEC cmp AX,0x000C
0FAE:0AEF jl short 0x0AF5
0FAE:0AF1 sub word ptr SS:[BP-46],8
0FAE:0AF5 mov word ptr SS:[BP-14],0
0FAE:0AFA push word ptr SS:[BP-14]
0FAE:0AFD push word ptr SS:[BP-46]
0FAE:0B00 push CS
0FAE:0B01 call near 0x10A2
0FAE:0B46 mov AX,0x0030
0FAE:0B49 imul word ptr SS:[BP+6]
0FAE:0B4C mov BX,AX
0FAE:0B4E mov ES,word ptr DS:[0x5594]
0FAE:0B52 mov byte ptr ES:[BX+0x32C6],0xFF
0FAE:0B58 mov word ptr SS:[BP-14],0
0FAE:0B5D mov AX,0x000C
0FAE:0B60 imul word ptr SS:[BP+6]
0FAE:0B63 mov BX,AX
0FAE:0B65 add BX,word ptr SS:[BP-14]
0FAE:0B68 mov ES,word ptr DS:[0x55A2]
0FAE:0B6C or byte ptr ES:[BX+0x3800],0x80
0FAE:0B72 inc word ptr SS:[BP-14]
0FAE:0B75 cmp word ptr SS:[BP-14],0x000C
0FAE:0B79 jl short 0x0B5D
0FAE:0B7B push word ptr SS:[BP+6]
0FAE:0B7E call far 11B8:193B
0FAE:0B83 add SP,2
0FAE:0B86 cmp word ptr SS:[BP-54],0
0FAE:0B8A jne short 0x0BA1
0FAE:0B8C cmp word ptr SS:[BP+8],0
0FAE:0B90 je short 0x0BA1
0FAE:0B92 mov AX,1
0FAE:0B95 push AX
0FAE:0B96 push word ptr SS:[BP+6]
0FAE:0B99 call far 11B8:1774
0FAE:0BA1 push word ptr SS:[BP-24]
0FAE:0BA4 push word ptr SS:[BP-20]
0FAE:0BA7 call far 017D:17BB
0FAE:0BAC add SP,4
0FAE:0BAF pop SI
0FAE:0BB0 pop DI
0FAE:0BB1 mov SP,BP
0FAE:0BB3 pop BP
0FAE:0BB4 ret far
0FAE:0BB5 push BP
0FAE:0BB6 mov BP,SP
0FAE:0BB8 mov AX,0x000A
0FAE:0BBB call far 19FC:2FDC
0FAE:0BC0 mov AX,word ptr SS:[BP+6]
0FAE:0BC3 and AX,0x0F00
0FAE:0BC6 shr AX,1
0FAE:0BC8 mov CX,word ptr SS:[BP+6]
0FAE:0BCB and CX,0x007F
0FAE:0BCE or AX,CX
0FAE:0BD0 mov word ptr SS:[BP+6],AX
0FAE:0BD3 mov AX,word ptr SS:[BP+8]
0FAE:0BD6 and AX,0xF000
0FAE:0BD9 mov CL,5
0FAE:0BDB shr AX,CL
0FAE:0BDD mov CX,word ptr SS:[BP+8]
0FAE:0BE0 and CX,0x007F
0FAE:0BE3 or AX,CX
0FAE:0BE5 mov word ptr SS:[BP+8],AX
0FAE:0BE8 mov ES,word ptr DS:[0x5582]
0FAE:0BEC mov AX,word ptr ES:[0xA44B]
0FAE:0BF0 and AX,0x0F00
0FAE:0BF3 shr AX,1
0FAE:0BF5 mov CX,word ptr ES:[0xA44B]
0FAE:0BFA and CX,0x007F
0FAE:0BFD or AX,CX
0FAE:0BFF mov word ptr SS:[BP-2],AX
0FAE:0C02 mov ES,word ptr DS:[0x5584]
0FAE:0C06 mov AX,word ptr ES:[0xA44D]
0FAE:0C0A and AX,0xF000
0FAE:0C0D mov CL,5
0FAE:0C0F shr AX,CL
0FAE:0C11 mov CX,word ptr ES:[0xA44D]
0FAE:0C16 and CX,0x007F
0FAE:0C19 or AX,CX
0FAE:0C1B mov word ptr SS:[BP-6],AX
0FAE:0C1E mov AX,word ptr SS:[BP-2]
0FAE:0C21 sub AX,word ptr SS:[BP+6]
0FAE:0C24 mov word ptr SS:[BP-8],AX
0FAE:0C27 or AX,AX
0FAE:0C29 jge short 0x0C30
0FAE:0C2B neg AX
0FAE:0C2D mov word ptr SS:[BP-8],AX
0FAE:0C30 mov AX,word ptr SS:[BP-6]
0FAE:0C33 sub AX,word ptr SS:[BP+8]
0FAE:0C36 mov word ptr SS:[BP-10],AX
0FAE:0C39 or AX,AX
0FAE:0C3B jge short 0x0C42
0FAE:0C3D neg AX
0FAE:0C3F mov word ptr SS:[BP-10],AX
0FAE:0C42 mov AX,word ptr SS:[BP-10]
0FAE:0C45 cmp word ptr SS:[BP-8],AX
0FAE:0C48 jle short 0x0C54
0FAE:0C4A mov AX,word ptr SS:[BP-8]
0FAE:0C4D sar AX,1
0FAE:0C4F add AX,word ptr SS:[BP-10]
0FAE:0C52 jmp short 0x0C5C
0FAE:0C54 mov AX,word ptr SS:[BP-10]
0FAE:0C57 sar AX,1
0FAE:0C59 add AX,word ptr SS:[BP-8]
0FAE:0C5C mov word ptr SS:[BP-4],AX
0FAE:0C5F mov SP,BP
0FAE:0C61 pop BP
0FAE:0C62 ret far
0FAE:0C63 push BP
0FAE:0C64 mov BP,SP
0FAE:0C66 mov AX,0x0010
0FAE:0C69 call far 19FC:2FDC
0FAE:0C6E push SI
0FAE:0C6F mov word ptr SS:[BP-8],0
0FAE:0C74 jmp short 0x0CC3
0FAE:0C76 inc word ptr SS:[BP-10]
0FAE:0C79 cmp word ptr SS:[BP-10],0x000C
0FAE:0C7D jge short 0x0CC0
0FAE:0C7F mov AX,0x000C
0FAE:0C82 imul word ptr SS:[BP-8]
0FAE:0C85 add AX,word ptr SS:[BP-10]
0FAE:0C88 add AX,0x3800
0FAE:0C8B mov word ptr SS:[BP-16],AX
0FAE:0C8E mov word ptr SS:[BP-14],0x2A0F
0FAE:0C93 les BX,word ptr SS:[BP-16]
0FAE:0C96 cmp byte ptr ES:[BX],0xFF
0FAE:0C9A je short 0x0C76
0FAE:0C9C and byte ptr ES:[BX],0x7F
0FAE:0CA0 les BX,word ptr SS:[BP-16]
0FAE:0CA3 mov AL,byte ptr ES:[BX]
0FAE:0CA6 cbw
0FAE:0CA7 mov BX,AX
0FAE:0CA9 shl BX,1
0FAE:0CAB mov ES,word ptr DS:[0x559A]
0FAE:0CAF cmp word ptr ES:[BX+0x406A],0
0FAE:0CB5 jne short 0x0C76
0FAE:0CB7 les BX,word ptr SS:[BP-16]
0FAE:0CBA mov byte ptr ES:[BX],0xFF
0FAE:0CBE jmp short 0x0C76
0FAE:0CC0 inc word ptr SS:[BP-8]
0FAE:0CC3 cmp word ptr SS:[BP-8],0x0018
0FAE:0CC7 jge short 0x0CD0
0FAE:0CC9 mov word ptr SS:[BP-10],0
0FAE:0CCE jmp short 0x0C79
0FAE:0CD0 mov word ptr SS:[BP-8],0
0FAE:0CD5 jmp near 0x0E97
0FAE:0CD8 add word ptr SS:[BP-10],4
0FAE:0CDC cmp word ptr SS:[BP-10],5
0FAE:0CE0 jl short 0x0CE5
0FAE:0CE2 jmp near 0x0E94
0FAE:0CE5 mov AX,word ptr SS:[BP-8]
0FAE:0CE8 add AX,word ptr SS:[BP-10]
0FAE:0CEB mov CX,0x007D
0FAE:0CEE imul CX
0FAE:0CF0 mov BX,AX
0FAE:0CF2 mov ES,word ptr DS:[0x558E]
0FAE:0CF6 cmp byte ptr ES:[BX-14556],0xFF
0FAE:0CFC jne short 0x0D01
0FAE:0CFE jmp near 0x0E81
0FAE:0D01 mov AX,0x0030
0FAE:0D04 imul word ptr SS:[BP-8]
0FAE:0D07 mov BX,AX
0FAE:0D09 mov ES,word ptr DS:[0x5594]
0FAE:0D0D mov AL,byte ptr ES:[BX+0x32C6]
0FAE:0D12 cbw
0FAE:0D13 inc AX
0FAE:0D14 mov word ptr SS:[BP-4],AX
0FAE:0D17 cmp AX,3
0FAE:0D1A jne short 0x0D30
0FAE:0D1C mov BX,word ptr SS:[BP-8]
0FAE:0D1F les SI,word ptr SS:[BP+6]
0FAE:0D22 mov AL,byte ptr ES:[BX+SI]
0FAE:0D25 mov byte ptr SS:[BP-16],AL
0FAE:0D28 cmp AL,3
0FAE:0D2A jle short 0x0D30
0FAE:0D2C cbw
0FAE:0D2D mov word ptr SS:[BP-4],AX
0FAE:0D30 cmp word ptr SS:[BP-10],0
0FAE:0D34 je short 0x0D66
0FAE:0D36 mov AX,0x0030
0FAE:0D39 imul word ptr SS:[BP-8]
0FAE:0D3C mov BX,AX
0FAE:0D3E mov ES,word ptr DS:[0x5594]
0FAE:0D42 mov AL,byte ptr ES:[BX+0x3506]
0FAE:0D47 cbw
0FAE:0D48 inc AX
0FAE:0D49 mov word ptr SS:[BP-4],AX
0FAE:0D4C cmp AX,3
0FAE:0D4F jne short 0x0D66
0FAE:0D51 mov SI,word ptr SS:[BP-8]
0FAE:0D54 les BX,word ptr SS:[BP+6]
0FAE:0D57 mov AL,byte ptr ES:[BX+SI+0x0C]
0FAE:0D5B mov byte ptr SS:[BP-16],AL
0FAE:0D5E cmp AL,3
0FAE:0D60 jle short 0x0D66
0FAE:0D62 cbw
0FAE:0D63 mov word ptr SS:[BP-4],AX
0FAE:0D66 mov AX,word ptr SS:[BP-8]
0FAE:0D69 add AX,word ptr SS:[BP-10]
0FAE:0D6C mov CX,0x007D
0FAE:0D6F imul CX
0FAE:0D71 mov SI,AX
0FAE:0D73 mov ES,word ptr DS:[0x558E]
0FAE:0D77 mov AL,5
0FAE:0D79 mul byte ptr ES:[SI-14439]
0FAE:0D7E add word ptr SS:[BP-4],AX
0FAE:0D81 mov AL,byte ptr ES:[SI-14518]
0FAE:0D86 sub AH,AH
0FAE:0D88 sub word ptr SS:[BP-4],AX
0FAE:0D8B mov word ptr SS:[BP-12],0x0033
0FAE:0D90 mov AX,word ptr SS:[BP-8]
0FAE:0D93 add AX,word ptr SS:[BP-10]
0FAE:0D96 mov CX,0x007D
0FAE:0D99 imul CX
0FAE:0D9B mov BX,AX
0FAE:0D9D add BX,word ptr SS:[BP-12]
0FAE:0DA0 mov ES,word ptr DS:[0x558E]
0FAE:0DA4 cmp byte ptr ES:[BX-14556],0x22
0FAE:0DAA jne short 0x0DAF
0FAE:0DAC dec word ptr SS:[BP-4]
0FAE:0DAF inc word ptr SS:[BP-12]
0FAE:0DB2 cmp word ptr SS:[BP-12],0x0055
0FAE:0DB6 jle short 0x0D90
0FAE:0DB8 mov SI,word ptr SS:[BP-8]
0FAE:0DBB add SI,word ptr SS:[BP-10]
0FAE:0DBE mov ES,word ptr DS:[0x55A6]
0FAE:0DC2 mov AL,byte ptr ES:[SI+0x0092]
0FAE:0DC7 cbw
0FAE:0DC8 add word ptr SS:[BP-4],AX
0FAE:0DCB mov AL,byte ptr SS:[BP-4]
0FAE:0DCE mov ES,word ptr DS:[0x5598]
0FAE:0DD2 add byte ptr ES:[SI+0x006E],AL
0FAE:0DD7 mov ES,word ptr DS:[0x55A8]
0FAE:0DDB cmp byte ptr ES:[SI-10890],0
0FAE:0DE1 je short 0x0DF6
0FAE:0DE3 mov ES,word ptr DS:[0x5598]
0FAE:0DE7 add byte ptr ES:[SI+0x006E],6
0FAE:0DED mov ES,word ptr DS:[0x55A8]
0FAE:0DF1 dec byte ptr ES:[SI-10890]
0FAE:0DF6 mov BX,word ptr SS:[BP-8]
0FAE:0DF9 mov ES,word ptr DS:[0x55AA]
0FAE:0DFD mov AL,byte ptr ES:[BX+0x32AE]
0FAE:0E02 cbw
0FAE:0E03 mov word ptr SS:[BP-6],AX
0FAE:0E06 mov ES,word ptr DS:[0x55AC]
0FAE:0E0A mov AL,byte ptr ES:[BX+0x3750]
0FAE:0E0F sub AH,AH
0FAE:0E11 mov word ptr SS:[BP-2],AX
0FAE:0E14 cmp word ptr SS:[BP-10],0
0FAE:0E18 je short 0x0E35
0FAE:0E1A mov ES,word ptr DS:[0x55AA]
0FAE:0E1E mov AL,byte ptr ES:[BX+0x32BA]
0FAE:0E23 cbw
0FAE:0E24 mov word ptr SS:[BP-6],AX
0FAE:0E27 mov ES,word ptr DS:[0x55AC]
0FAE:0E2B mov AL,byte ptr ES:[BX+0x375C]
0FAE:0E30 sub AH,AH
0FAE:0E32 mov word ptr SS:[BP-2],AX
0FAE:0E35 cmp word ptr SS:[BP-6],0
0FAE:0E39 je short 0x0E4E
0FAE:0E3B cmp word ptr SS:[BP-2],0x0010
0FAE:0E3F jge short 0x0E4E
0FAE:0E41 add BX,word ptr SS:[BP-10]
0FAE:0E44 mov ES,word ptr DS:[0x5598]
0FAE:0E48 sub byte ptr ES:[BX+0x006E],4
0FAE:0E4E mov AX,word ptr SS:[BP-8]
0FAE:0E51 add AX,word ptr SS:[BP-10]
0FAE:0E54 add AX,0x006E
0FAE:0E57 mov word ptr SS:[BP-16],AX
0FAE:0E5A mov word ptr SS:[BP-14],0x2A0F
0FAE:0E5F les BX,word ptr SS:[BP-16]
0FAE:0E62 cmp byte ptr ES:[BX],0
0FAE:0E66 jge short 0x0E6C
0FAE:0E68 mov byte ptr ES:[BX],0
0FAE:0E6C mov BX,word ptr SS:[BP-8]
0FAE:0E6F mov ES,word ptr DS:[0x5598]
0FAE:0E73 cmp byte ptr ES:[BX+0x006E],0x1E
0FAE:0E79 jle short 0x0E81
0FAE:0E7B mov byte ptr ES:[BX+0x006E],0x1E
0FAE:0E81 mov BX,word ptr SS:[BP-8]
0FAE:0E84 add BX,word ptr SS:[BP-10]
0FAE:0E87 mov ES,word ptr DS:[0x55A6]
0FAE:0E8B mov byte ptr ES:[BX+0x0092],0
0FAE:0E91 jmp near 0x0CD8
0FAE:0E94 inc word ptr SS:[BP-8]
0FAE:0E97 cmp word ptr SS:[BP-8],4
0FAE:0E9B jge short 0x0EA5
0FAE:0E9D mov word ptr SS:[BP-10],0
0FAE:0EA2 jmp near 0x0CDC
0FAE:0EA5 mov word ptr SS:[BP-8],0
0FAE:0EAA mov AX,0x0011
0FAE:0EAD imul word ptr SS:[BP-8]
0FAE:0EB0 mov BX,AX
0FAE:0EB2 mov ES,word ptr DS:[0x558E]
0FAE:0EB6 cmp byte ptr ES:[BX-14828],0xFF
0FAE:0EBC jne short 0x0F16
0FAE:0EBE mov AX,word ptr SS:[BP-8]
0FAE:0EC1 add AX,4
0FAE:0EC4 mov word ptr SS:[BP-10],AX
0FAE:0EC7 cmp AX,0x000C
0FAE:0ECA jl short 0x0ED0
0FAE:0ECC add word ptr SS:[BP-10],4
0FAE:0ED0 cmp word ptr SS:[BP-8],0
0FAE:0ED4 je short 0x0EF0
0FAE:0ED6 mov SI,word ptr SS:[BP-10]
0FAE:0ED9 shl SI,1
0FAE:0EDB mov AX,0xFFFF
0FAE:0EDE mov ES,word ptr DS:[0x5590]
0FAE:0EE2 mov word ptr ES:[SI+0x4036],AX
0FAE:0EE7 mov ES,word ptr DS:[0x5592]
0FAE:0EEB mov word ptr ES:[SI+0x4004],AX
0FAE:0EF0 cmp word ptr SS:[BP-10],0x0010
0FAE:0EF4 jl short 0x0F03
0FAE:0EF6 mov BX,word ptr SS:[BP-10]
0FAE:0EF9 mov ES,word ptr DS:[0x55AE]
0FAE:0EFD mov byte ptr ES:[BX-10914],0xFE
0FAE:0F03 cmp word ptr SS:[BP-8],0
0FAE:0F07 jne short 0x0F16
0FAE:0F09 mov BX,word ptr SS:[BP-10]
0FAE:0F0C mov ES,word ptr DS:[0x55AE]
0FAE:0F10 mov byte ptr ES:[BX-10914],0x96
0FAE:0F16 inc word ptr SS:[BP-8]
0FAE:0F19 cmp word ptr SS:[BP-8],0x0010
0FAE:0F1D jl short 0x0EAA
0FAE:0F1F pop SI
0FAE:0F20 mov SP,BP
0FAE:0F22 pop BP
0FAE:0F23 ret far
0FAE:0F24 push BP
0FAE:0F25 mov BP,SP
0FAE:0F27 mov AX,0x000E
0FAE:0F2A call far 19FC:2FDC
0FAE:0F2F push SI
0FAE:0F30 mov SI,word ptr SS:[BP+6]
0FAE:0F33 shl SI,1
0FAE:0F35 mov ES,word ptr DS:[0x5592]
0FAE:0F39 mov AX,word ptr ES:[SI+0x4004]
0FAE:0F3E mov word ptr SS:[BP-10],AX
0FAE:0F41 mov ES,word ptr DS:[0x5590]
0FAE:0F45 mov AX,word ptr ES:[SI+0x4036]
0FAE:0F4A mov word ptr SS:[BP-12],AX
0FAE:0F4D cmp word ptr SS:[BP+6],4
0FAE:0F51 jl short 0x0F5F
0FAE:0F53 cmp word ptr SS:[BP+6],0x000C
0FAE:0F57 jl short 0x0FC8
0FAE:0F59 cmp word ptr SS:[BP+6],0x000F
0FAE:0F5D jg short 0x0FC8
0FAE:0F5F push word ptr SS:[BP-12]
0FAE:0F62 push word ptr SS:[BP-10]
0FAE:0F65 push CS
0FAE:0F66 call near 0x0BB5
0FAE:0F69 add SP,4
0FAE:0F6C cmp AX,3
0FAE:0F6F jle short 0x0FC8
0FAE:0F71 mov ES,word ptr DS:[0x5582]
0FAE:0F75 mov AX,word ptr SS:[BP-10]
0FAE:0F78 cmp word ptr ES:[0xA44B],AX
0FAE:0F7D jae short 0x0F8E
0FAE:0F7F dec word ptr SS:[BP-10]
0FAE:0F82 mov AL,byte ptr SS:[BP-10]
0FAE:0F85 test AL,0x80
0FAE:0F87 je short 0x0F8E
0FAE:0F89 and word ptr SS:[BP-10],0x0F7F
0FAE:0F8E mov ES,word ptr DS:[0x5582]
0FAE:0F92 mov AX,word ptr SS:[BP-10]
0FAE:0F95 cmp word ptr ES:[0xA44B],AX
0FAE:0F9A jbe short 0x0FAB
0FAE:0F9C inc word ptr SS:[BP-10]
0FAE:0F9F mov AL,byte ptr SS:[BP-10]
0FAE:0FA2 test AL,0x80
0FAE:0FA4 je short 0x0FAB
0FAE:0FA6 add word ptr SS:[BP-10],0x0080
0FAE:0FAB mov ES,word ptr DS:[0x5584]
0FAE:0FAF mov AX,word ptr SS:[BP-12]
0FAE:0FB2 cmp word ptr ES:[0xA44D],AX
0FAE:0FB7 jae short 0x0FC8
0FAE:0FB9 sub word ptr SS:[BP-12],2
0FAE:0FBD test byte ptr SS:[BP-12],0x80
0FAE:0FC1 je short 0x0FC8
0FAE:0FC3 and word ptr SS:[BP-12],0xF07F
0FAE:0FC8 push word ptr SS:[BP-12]
0FAE:0FCB push word ptr SS:[BP-10]
0FAE:0FCE push CS
0FAE:0FCF call near 0x0BB5
0FAE:0FD2 add SP,4
0FAE:0FD5 mov word ptr SS:[BP-8],AX
0FAE:0FD8 mov word ptr SS:[BP-14],3
0FAE:0FDD mov AX,0x0011
0FAE:0FE0 imul word ptr SS:[BP+8]
0FAE:0FE3 mov BX,AX
0FAE:0FE5 mov AL,byte ptr DS:[BX+0x2EE7]
0FAE:0FE9 sub AH,AH
0FAE:0FEB cmp AX,word ptr SS:[BP-8]
0FAE:0FEE jbe short 0x0FF5
0FAE:0FF0 mov word ptr SS:[BP-14],2
0FAE:0FF5 mov AX,0x0011
0FAE:0FF8 imul word ptr SS:[BP+8]
0FAE:0FFB mov SI,AX
0FAE:0FFD mov AL,byte ptr DS:[SI+0x2EE6]
0FAE:1001 sub AH,AH
0FAE:1003 mov word ptr SS:[BP-4],AX
0FAE:1006 and AX,0x001F
0FAE:1009 mov word ptr SS:[BP-2],AX
0FAE:100C mov AX,word ptr SS:[BP-4]
0FAE:100F mov CL,5
0FAE:1011 shr AX,CL
0FAE:1013 mov word ptr SS:[BP-6],AX
0FAE:1016 cmp byte ptr DS:[SI+0x2EE4],0x80
0FAE:101B jae short 0x1035
0FAE:101D cmp word ptr SS:[BP+8],0x0020
0FAE:1021 je short 0x1035
0FAE:1023 mov AX,3
0FAE:1026 mul word ptr SS:[BP-2]
0FAE:1029 mov word ptr SS:[BP-2],AX
0FAE:102C mov AX,3
0FAE:102F mul word ptr SS:[BP-6]
0FAE:1032 mov word ptr SS:[BP-6],AX
0FAE:1035 mov AX,word ptr SS:[BP-2]
0FAE:1038 cmp word ptr SS:[BP-8],AX
0FAE:103B jae short 0x1042
0FAE:103D mov word ptr SS:[BP-14],1
0FAE:1042 mov AX,word ptr SS:[BP-6]
0FAE:1045 cmp word ptr SS:[BP-8],AX
0FAE:1048 jae short 0x104F
0FAE:104A mov word ptr SS:[BP-14],0
0FAE:104F mov AX,word ptr SS:[BP-14]
0FAE:1052 pop SI
0FAE:1053 mov SP,BP
0FAE:1055 pop BP
0FAE:1056 ret far
0FAE:10A2 push BP
0FAE:10A3 mov BP,SP
0FAE:10A5 mov AX,8
0FAE:10A8 call far 19FC:2FDC
0FAE:16AB push BP
0FAE:16AC mov BP,SP
0FAE:16AE mov AX,0x0022
0FAE:16B1 call far 19FC:2FDC
0FAE:16B6 push DI
0FAE:16B7 push SI
0FAE:16B8 mov word ptr SS:[BP-6],0
0FAE:16BD cmp word ptr SS:[BP+6],4
0FAE:16C1 jl short 0x16C9
0FAE:16C3 cmp word ptr SS:[BP+6],0x000C
0FAE:16C7 jl short 0x16D2
0FAE:16C9 cmp word ptr SS:[BP+6],0x0010
0FAE:16CD jge short 0x16D2
0FAE:16CF jmp near 0x1864
0FAE:16D2 cmp word ptr SS:[BP+6],0x0010
0FAE:16D6 jl short 0x16E0
0FAE:16D8 mov AX,word ptr SS:[BP+6]
0FAE:16DB sub AX,8
0FAE:16DE jmp short 0x16E6
0FAE:16E0 mov AX,word ptr SS:[BP+6]
0FAE:16E3 sub AX,4
0FAE:16E6 mov word ptr SS:[BP-26],AX
0FAE:16E9 mov word ptr SS:[BP-24],4
0FAE:16EE mov AX,word ptr SS:[BP+6]
0FAE:16F1 cmp word ptr SS:[BP-24],AX
0FAE:16F4 je short 0x172B
0FAE:16F6 mov SI,word ptr SS:[BP-24]
0FAE:16F9 shl SI,1
0FAE:16FB mov ES,word ptr DS:[0x5582]
0FAE:16FF mov AX,word ptr ES:[0xA44B]
0FAE:1703 mov ES,word ptr DS:[0x5592]
0FAE:1707 cmp word ptr ES:[SI+0x4004],AX
0FAE:170C jne short 0x172B
0FAE:170E mov ES,word ptr DS:[0x5584]
0FAE:1712 mov AX,word ptr ES:[0xA44D]
0FAE:1716 mov ES,word ptr DS:[0x5590]
0FAE:171A cmp word ptr ES:[SI+0x4036],AX
0FAE:171F jne short 0x172B
0FAE:1721 mov word ptr SS:[BP-6],1
0FAE:1726 mov word ptr SS:[BP-24],0x000C
0FAE:172B cmp word ptr SS:[BP-6],0
0FAE:172F jne short 0x1771
0FAE:1731 mov AX,word ptr SS:[BP-24]
0FAE:1734 add AX,0x000C
0FAE:1737 cmp AX,word ptr SS:[BP+6]
0FAE:173A je short 0x1771
0FAE:173C mov SI,word ptr SS:[BP-24]
0FAE:173F shl SI,1
0FAE:1741 mov ES,word ptr DS:[0x5582]
0FAE:1745 mov AX,word ptr ES:[0xA44B]
0FAE:1749 mov ES,word ptr DS:[0x5592]
0FAE:174D cmp word ptr ES:[SI+0x401C],AX
0FAE:1752 jne short 0x1771
0FAE:1754 mov ES,word ptr DS:[0x5584]
0FAE:1758 mov AX,word ptr ES:[0xA44D]
0FAE:175C mov ES,word ptr DS:[0x5590]
0FAE:1760 cmp word ptr ES:[SI+0x404E],AX
0FAE:1765 jne short 0x1771
0FAE:1767 mov word ptr SS:[BP-6],1
0FAE:176C mov word ptr SS:[BP-24],0x000C
0FAE:1771 inc word ptr SS:[BP-24]
0FAE:1774 cmp word ptr SS:[BP-24],0x000C
0FAE:1778 jge short 0x177D
0FAE:177A jmp near 0x16EE
0FAE:177D cmp word ptr SS:[BP-6],0
0FAE:1781 je short 0x1786
0FAE:1783 jmp near 0x1B3B
0FAE:1786 mov ES,word ptr DS:[0x5582]
0FAE:178A mov AX,word ptr ES:[0xA44B]
0FAE:178E mov word ptr SS:[BP-4],AX
0FAE:1791 mov ES,word ptr DS:[0x5584]
0FAE:1795 mov AX,word ptr ES:[0xA44D]
0FAE:1799 mov word ptr SS:[BP-10],AX
0FAE:179C mov word ptr SS:[BP-24],0
0FAE:17A1 jmp near 0x183E
0FAE:17A4 sub AX,AX
0FAE:17A6 push AX
0FAE:17A7 mov AX,0xFFFF
0FAE:17AA push AX
0FAE:17AB call far 017D:191B
0FAE:17B0 add SP,4
0FAE:17B3 mov ES,word ptr DS:[0x5582]
0FAE:17B7 mov AX,word ptr ES:[0xA44B]
0FAE:17BB cmp word ptr SS:[BP-4],AX
0FAE:17BE je short 0x17DC
0FAE:17C0 sub AX,AX
0FAE:17C2 push AX
0FAE:17C3 mov AX,2
0FAE:17C6 push AX
0FAE:17C7 call far 017D:191B
0FAE:17CC add SP,4
0FAE:17CF mov ES,word ptr DS:[0x5582]
0FAE:17D3 mov AX,word ptr ES:[0xA44B]
0FAE:17D7 cmp word ptr SS:[BP-4],AX
0FAE:17DA jne short 0x17E1
0FAE:17DC mov word ptr SS:[BP-6],1
0FAE:17E1 cmp word ptr SS:[BP-6],0
0FAE:17E5 je short 0x17F0
0FAE:17E7 mov AX,0x000E
0FAE:17EA mov word ptr SS:[BP-24],AX
0FAE:17ED mov word ptr SS:[BP-30],AX
0FAE:17F0 add word ptr SS:[BP-30],0x000C
0FAE:17F4 cmp word ptr SS:[BP-30],0x000D
0FAE:17F8 jge short 0x183B
0FAE:17FA mov SI,word ptr SS:[BP-24]
0FAE:17FD add SI,word ptr SS:[BP-30]
0FAE:1800 shl SI,1
0FAE:1802 mov ES,word ptr DS:[0x5592]
0FAE:1806 mov AX,word ptr ES:[SI+0x4004]
0FAE:180B mov ES,word ptr DS:[0x5582]
0FAE:180F mov word ptr ES:[0xA44B],AX
0FAE:1813 mov ES,word ptr DS:[0x5590]
0FAE:1817 mov AX,word ptr ES:[SI+0x4036]
0FAE:181C mov ES,word ptr DS:[0x5584]
0FAE:1820 mov word ptr ES:[0xA44D],AX
0FAE:1824 cmp word ptr SS:[BP-10],AX
0FAE:1827 jne short 0x17E1
0FAE:1829 mov ES,word ptr DS:[0x5582]
0FAE:182D mov AX,word ptr ES:[0xA44B]
0FAE:1831 cmp word ptr SS:[BP-4],AX
0FAE:1834 je short 0x1839
0FAE:1836 jmp near 0x17A4
0FAE:1839 jmp short 0x17DC
0FAE:183B inc word ptr SS:[BP-24]
0FAE:183E cmp word ptr SS:[BP-24],4
0FAE:1842 jge short 0x184B
0FAE:1844 mov word ptr SS:[BP-30],0
0FAE:1849 jmp short 0x17F4
0FAE:184B mov ES,word ptr DS:[0x5582]
0FAE:184F mov AX,word ptr SS:[BP-4]
0FAE:1852 mov word ptr ES:[0xA44B],AX
0FAE:1856 mov ES,word ptr DS:[0x5584]
0FAE:185A mov AX,word ptr SS:[BP-10]
0FAE:185D mov word ptr ES:[0xA44D],AX
0FAE:1861 jmp near 0x1B3B
0FAE:1864 mov ES,word ptr DS:[0x5582]
0FAE:1868 mov AX,word ptr ES:[0xA44B]
0FAE:186C inc AX
0FAE:186D mov word ptr SS:[BP-28],AX
0FAE:1870 test byte ptr SS:[BP-28],0x80
0FAE:1874 je short 0x187B
0FAE:1876 add word ptr SS:[BP-28],0x0080
0FAE:187B mov AX,word ptr SS:[BP-28]
0FAE:187E and AX,0x0F00
0FAE:1881 shr AX,1
0FAE:1883 mov CX,word ptr SS:[BP-28]
0FAE:1886 and CX,0x007F
0FAE:1889 or AX,CX
0FAE:188B mov word ptr SS:[BP-28],AX
0FAE:188E mov word ptr SS:[BP-24],0
0FAE:1893 jmp near 0x191E
0FAE:1896 add word ptr SS:[BP-30],0x000C
0FAE:189A cmp word ptr SS:[BP-30],0x000D
0FAE:189E jge short 0x191B
0FAE:18A0 mov SI,word ptr SS:[BP-24]
0FAE:18A3 add SI,word ptr SS:[BP-30]
0FAE:18A6 mov DI,SI
0FAE:18A8 shl DI,1
0FAE:18AA mov ES,word ptr DS:[0x559A]
0FAE:18AE cmp word ptr ES:[DI+0x406A],0
0FAE:18B4 je short 0x1896
0FAE:18B6 cmp word ptr SS:[BP+6],SI
0FAE:18B9 je short 0x1896
0FAE:18BB mov ES,word ptr DS:[0x5584]
0FAE:18BF mov AX,word ptr ES:[0xA44D]
0FAE:18C3 mov ES,word ptr DS:[0x5590]
0FAE:18C7 cmp word ptr ES:[DI+0x4036],AX
0FAE:18CC jne short 0x1896
0FAE:18CE mov ES,word ptr DS:[0x5592]
0FAE:18D2 mov AX,word ptr ES:[DI+0x4004]
0FAE:18D7 inc AX
0FAE:18D8 mov word ptr SS:[BP-8],AX
0FAE:18DB test byte ptr SS:[BP-8],0x80
0FAE:18DF je short 0x18E6
0FAE:18E1 add word ptr SS:[BP-8],0x0080
0FAE:18E6 mov AX,word ptr SS:[BP-8]
0FAE:18E9 and AX,0x0F00
0FAE:18EC shr AX,1
0FAE:18EE mov CX,word ptr SS:[BP-8]
0FAE:18F1 and CX,0x007F
0FAE:18F4 or AX,CX
0FAE:18F6 mov word ptr SS:[BP-8],AX
0FAE:18F9 sub AX,word ptr SS:[BP-28]
0FAE:18FC push AX
0FAE:18FD call far 19FC:3C6C
0FAE:191B inc word ptr SS:[BP-24]
0FAE:191E cmp word ptr SS:[BP-24],4
0FAE:1922 jge short 0x192C
0FAE:1924 mov word ptr SS:[BP-30],0
0FAE:1929 jmp near 0x189A
0FAE:192C mov word ptr SS:[BP-16],4
0FAE:1931 cmp word ptr SS:[BP+6],0x000C
0FAE:1935 jl short 0x193C
0FAE:1937 mov word ptr SS:[BP-16],0x0010
0FAE:193C dec word ptr SS:[BP-28]
0FAE:193F mov AX,word ptr SS:[BP-16]
0FAE:1942 mov word ptr SS:[BP-24],AX
0FAE:1945 jmp short 0x19AC
0FAE:1947 mov SI,word ptr SS:[BP-24]
0FAE:194A shl SI,1
0FAE:194C mov ES,word ptr DS:[0x559A]
0FAE:1950 cmp word ptr ES:[SI+0x406A],0
0FAE:1956 je short 0x19A9
0FAE:1958 mov ES,word ptr DS:[0x5584]
0FAE:195C mov AX,word ptr ES:[0xA44D]
0FAE:1960 mov ES,word ptr DS:[0x5590]
0FAE:1964 cmp word ptr ES:[SI+0x4036],AX
0FAE:1969 jne short 0x19A9
0FAE:196B mov ES,word ptr DS:[0x5592]
0FAE:196F mov AX,word ptr ES:[SI+0x4004]
0FAE:1974 mov word ptr SS:[BP-8],AX
0FAE:1977 and AX,0x0F00
0FAE:197A shr AX,1
0FAE:197C mov CX,word ptr SS:[BP-8]
0FAE:197F and CX,0x007F
0FAE:1982 or AX,CX
0FAE:1984 mov word ptr SS:[BP-8],AX
0FAE:1987 mov AX,word ptr SS:[BP-28]
0FAE:198A sub AX,word ptr SS:[BP-8]
0FAE:198D push AX
0FAE:198E call far 19FC:3C6C
0FAE:19A9 inc word ptr SS:[BP-24]
0FAE:19AC mov AX,word ptr SS:[BP-16]
0FAE:19AF add AX,8
0FAE:19B2 cmp AX,word ptr SS:[BP-24]
0FAE:19B5 jg short 0x1947
0FAE:19B7 cmp word ptr SS:[BP-6],0
0FAE:19BB je short 0x19C0
0FAE:19BD jmp near 0x1B3B
0FAE:19C0 cmp word ptr SS:[BP+0x0C],0
0FAE:19C4 jne short 0x19C9
0FAE:19C6 jmp near 0x1B3B
0FAE:19C9 xor byte ptr SS:[BP-16],0x14
0FAE:19CD mov AX,word ptr SS:[BP-16]
0FAE:19D0 mov word ptr SS:[BP-24],AX
0FAE:19D3 jmp near 0x1AAA
0FAE:1AA7 inc word ptr SS:[BP-24]
0FAE:1AAA mov AX,word ptr SS:[BP-16]
0FAE:1AAD add AX,8
0FAE:1AB0 cmp AX,word ptr SS:[BP-24]
0FAE:1AB3 jg short 0x1AB8
0FAE:1AB5 jmp near 0x1B3B
0FAE:1AB8 mov SI,word ptr SS:[BP-24]
0FAE:1ABB shl SI,1
0FAE:1ABD mov ES,word ptr DS:[0x559A]
0FAE:1AC1 cmp word ptr ES:[SI+0x406A],0
0FAE:1AC7 je short 0x1AA7
0FAE:1AC9 mov ES,word ptr DS:[0x5584]
0FAE:1ACD mov AX,word ptr ES:[0xA44D]
0FAE:1AD1 mov ES,word ptr DS:[0x5590]
0FAE:1AD5 cmp word ptr ES:[SI+0x4036],AX
0FAE:1ADA jne short 0x1AA7
0FAE:1ADC mov ES,word ptr DS:[0x5592]
0FAE:1AE0 mov AX,word ptr ES:[SI+0x4004]
0FAE:1AE5 mov word ptr SS:[BP-8],AX
0FAE:1AE8 and AX,0x0F00
0FAE:1AEB shr AX,1
0FAE:1AED mov CX,word ptr SS:[BP-8]
0FAE:1AF0 and CX,0x007F
0FAE:1AF3 or AX,CX
0FAE:1AF5 mov word ptr SS:[BP-8],AX
0FAE:1AF8 mov AX,word ptr SS:[BP-28]
0FAE:1AFB sub AX,word ptr SS:[BP-8]
0FAE:1AFE push AX
0FAE:1AFF call far 19FC:3C6C
0FAE:1B3B mov AX,word ptr SS:[BP-6]
0FAE:1B3E pop SI
0FAE:1B3F pop DI
0FAE:1B40 mov SP,BP
0FAE:1B42 pop BP
0FAE:1B43 ret far
0FAE:1B44 push BP
0FAE:1B45 mov BP,SP
0FAE:1B47 mov AX,4
0FAE:1B4A call far 19FC:2FDC
0FAE:1BFE push BP
0FAE:1BFF mov BP,SP
0FAE:1C01 mov AX,0x001C
0FAE:1C04 call far 19FC:2FDC
0FAE:1C09 push SI
0FAE:1C0A mov ES,word ptr DS:[0x5582]
0FAE:1C0E mov AX,word ptr ES:[0xA44B]
0FAE:1C12 mov word ptr SS:[BP-4],AX
0FAE:1C15 mov ES,word ptr DS:[0x5584]
0FAE:1C19 mov AX,word ptr ES:[0xA44D]
0FAE:1C1D mov word ptr SS:[BP-8],AX
0FAE:1C20 push AX
0FAE:1C21 push word ptr SS:[BP-4]
0FAE:1C24 call far 19FC:1314
0FAE:1C29 add SP,4
0FAE:1C2C call far 19FC:1DF8
0FAE:1C31 mov ES,word ptr DS:[0x559C]
0FAE:1C35 cmp word ptr ES:[0xE48E],0
0FAE:1C3B je short 0x1C49
0FAE:1C3D cmp word ptr SS:[BP+8],0x000D
0FAE:1C41 jne short 0x1C49
0FAE:1C43 mov AX,1
0FAE:1C46 jmp near 0x1DA6
0FAE:1C49 mov ES,word ptr DS:[0x5586]
0FAE:1C4D mov AX,word ptr ES:[0x09ED]
0FAE:1C51 add AX,0x0096
0FAE:1C54 mov word ptr SS:[BP-16],AX
0FAE:1C57 mov word ptr SS:[BP-28],1
0FAE:1C5C mov AX,word ptr SS:[BP-8]
0FAE:1C5F and AX,1
0FAE:1C62 mov word ptr SS:[BP-2],AX
0FAE:1C65 test byte ptr SS:[BP-4],1
0FAE:1C69 je short 0x1C73
0FAE:1C6B inc word ptr SS:[BP-16]
0FAE:1C6E mov word ptr SS:[BP-28],0
0FAE:1C73 push word ptr SS:[BP+0x0C]
0FAE:1C76 push word ptr SS:[BP+0x0A]
0FAE:1C79 push word ptr SS:[BP-8]
0FAE:1C7C push word ptr SS:[BP-4]
0FAE:1C7F call far 19FC:0971
0FAE:1C84 add SP,8
0FAE:1C87 mov word ptr SS:[BP-18],AX
0FAE:1C8A mov word ptr SS:[BP-14],1
0FAE:1C8F mov BX,word ptr SS:[BP-16]
0FAE:1C92 mov ES,word ptr DS:[0x5588]
0FAE:1C96 mov AL,byte ptr ES:[BX+0x07AD]
0FAE:1C9B sub AH,AH
0FAE:1C9D mov word ptr SS:[BP-20],AX
0FAE:1CA0 mov ES,word ptr DS:[0x558A]
0FAE:1CA4 cmp word ptr ES:[0x0150],AX
0FAE:1CA9 jle short 0x1CAE
0FAE:1CAB jmp near 0x1D5C
0FAE:1CAE sub AX,AX
0FAE:1CB0 jmp near 0x1DA6
0FAE:1CB3 dec word ptr SS:[BP-18]
0FAE:1CB6 and word ptr SS:[BP-18],7
0FAE:1CBA mov SI,word ptr SS:[BP-18]
0FAE:1CBD shl SI,1
0FAE:1CBF mov AX,word ptr DS:[SI+0x328A]
0FAE:1CC3 add word ptr SS:[BP-4],AX
0FAE:1CC6 test byte ptr SS:[BP-4],0x80
0FAE:1CCA je short 0x1CD3
0FAE:1CCC mov AX,word ptr DS:[SI+0x32AA]
0FAE:1CD0 add word ptr SS:[BP-4],AX
0FAE:1CD3 mov SI,word ptr SS:[BP-18]
0FAE:1CD6 shl SI,1
0FAE:1CD8 mov AX,word ptr DS:[SI+0x329A]
0FAE:1CDC add word ptr SS:[BP-8],AX
0FAE:1CDF test byte ptr SS:[BP-8],0x80
0FAE:1CE3 je short 0x1CEC
0FAE:1CE5 mov AX,word ptr DS:[SI+0x32BA]
0FAE:1CE9 add word ptr SS:[BP-8],AX
0FAE:1CEC mov BX,word ptr SS:[BP-18]
0FAE:1CEF shl BX,1
0FAE:1CF1 mov SI,word ptr DS:[BX+0x328A]
0FAE:1CF5 or SI,SI
0FAE:1CF7 je short 0x1D0B
0FAE:1CF9 mov AX,word ptr SS:[BP-28]
0FAE:1CFC add AX,SI
0FAE:1CFE and AX,1
0FAE:1D01 mov word ptr SS:[BP-28],AX
0FAE:1D04 or AX,AX
0FAE:1D06 jne short 0x1D0B
0FAE:1D08 add word ptr SS:[BP-16],SI
0FAE:1D0B mov SI,word ptr SS:[BP-18]
0FAE:1D0E shl SI,1
0FAE:1D10 cmp word ptr DS:[SI+0x329A],0
0FAE:1D15 je short 0x1D2F
0FAE:1D17 mov AX,word ptr DS:[SI+0x329A]
0FAE:1D1B add AX,word ptr SS:[BP-2]
0FAE:1D1E and AX,1
0FAE:1D21 mov word ptr SS:[BP-2],AX
0FAE:1D24 or AX,AX
0FAE:1D26 jne short 0x1D2F
0FAE:1D28 mov AX,word ptr DS:[SI+0x32CA]
0FAE:1D2C add word ptr SS:[BP-16],AX
0FAE:1D2F mov BX,word ptr SS:[BP-16]
0FAE:1D32 mov ES,word ptr DS:[0x5588]
0FAE:1D36 mov AL,byte ptr ES:[BX+0x07AD]
0FAE:1D3B sub AH,AH
0FAE:1D3D mov word ptr SS:[BP-20],AX
0FAE:1D40 mov ES,word ptr DS:[0x558A]
0FAE:1D44 cmp word ptr ES:[0x0150],AX
0FAE:1D49 jg short 0x1D5C
0FAE:1D4B mov AX,word ptr SS:[BP+0x0A]
0FAE:1D4E mov word ptr SS:[BP-4],AX
0FAE:1D51 mov AX,word ptr SS:[BP+0x0C]
0FAE:1D54 mov word ptr SS:[BP-8],AX
0FAE:1D57 mov word ptr SS:[BP-14],0
0FAE:1D5C mov AX,word ptr SS:[BP+0x0A]
0FAE:1D5F cmp word ptr SS:[BP-4],AX
0FAE:1D62 jne short 0x1D6C
0FAE:1D64 mov AX,word ptr SS:[BP+0x0C]
0FAE:1D67 cmp word ptr SS:[BP-8],AX
0FAE:1D6A je short 0x1DA3
0FAE:1D6C push word ptr SS:[BP+0x0C]
0FAE:1D6F push word ptr SS:[BP+0x0A]
0FAE:1D72 push word ptr SS:[BP-8]
0FAE:1D75 push word ptr SS:[BP-4]
0FAE:1D78 call far 19FC:0971
0FAE:1D7D add SP,8
0FAE:1D80 mov word ptr SS:[BP-6],AX
0FAE:1D83 sub AX,word ptr SS:[BP-18]
0FAE:1D86 mov word ptr SS:[BP-24],AX
0FAE:1D89 or AX,AX
0FAE:1D8B jne short 0x1D90
0FAE:1D8D jmp near 0x1CBA
0FAE:1D90 and word ptr SS:[BP-24],7
0FAE:1D94 cmp word ptr SS:[BP-24],5
0FAE:1D98 jl short 0x1D9D
0FAE:1D9A jmp near 0x1CB3
0FAE:1D9D inc word ptr SS:[BP-18]
0FAE:1DA0 jmp near 0x1CB6
0FAE:1DA3 mov AX,word ptr SS:[BP-14]
0FAE:1DA6 pop SI
0FAE:1DA7 mov SP,BP
0FAE:1DA9 pop BP
0FAE:1DAA ret far
0FAE:1DAB push BP
0FAE:1DAC mov BP,SP
0FAE:1DAE xor AX,AX
0FAE:1DB0 call far 19FC:2FDC
0FAE:1FDF push BP
0FAE:1FE0 mov BP,SP
0FAE:1FE2 mov AX,4
0FAE:1FE5 call far 19FC:2FDC
0FAE:1FEA mov ES,word ptr DS:[0x55B0]
0FAE:1FEE mov AX,word ptr ES:[0x4600]
0FAE:1FF2 mov word ptr SS:[BP-4],AX
0FAE:1FF5 mov AX,3
0FAE:1FF8 push AX
0FAE:1FF9 call far 17D3:0281
0FAE:1FFE add SP,2
0FAE:2001 mov ES,word ptr DS:[0x55C2]
0FAE:2005 mov word ptr ES:[0x3748],0
0FAE:200C mov ES,word ptr DS:[0x55C4]
0FAE:2010 mov word ptr ES:[0x374E],9
0FAE:2017 mov AX,0x32DA
0FAE:201A push DS
0FAE:201B push AX
0FAE:201C call far 17D3:03F5
0FAE:2021 add SP,4
0FAE:2024 call far 017D:28A2
0FAE:2029 mov AX,0x000A
0FAE:202C push AX
0FAE:202D mov AX,0x0012
0FAE:2030 mov DX,0x2A0F
0FAE:2033 push DX
0FAE:2034 push AX
0FAE:2035 mov ES,word ptr DS:[0x558E]
0FAE:2039 push word ptr ES:[0xD372]
0FAE:203E push word ptr ES:[0xD370]
0FAE:2043 call far 19FC:3BD2
0FAE:2048 add SP,0x000A
0FAE:204B mov AX,0x0012
0FAE:204E mov DX,0x2A0F
0FAE:2051 push DX
0FAE:2052 push AX
0FAE:2053 call far 19FC:3B9E
0FAE:2058 add SP,4
0FAE:205B mov word ptr SS:[BP-2],AX
0FAE:205E jmp short 0x2070
0FAE:2060 mov BX,word ptr SS:[BP-2]
0FAE:2063 inc word ptr SS:[BP-2]
0FAE:2066 mov ES,word ptr DS:[0x55C6]
0FAE:206A mov byte ptr ES:[BX+0x0012],0x20
0FAE:2070 cmp word ptr SS:[BP-2],0x000A
0FAE:2074 jl short 0x2060
0FAE:2076 mov BX,word ptr SS:[BP-2]
0FAE:2079 mov ES,word ptr DS:[0x55C6]
0FAE:207D mov byte ptr ES:[BX+0x0012],0
0FAE:2083 mov AX,0x0012
0FAE:2086 mov DX,0x2A0F
0FAE:2089 push DX
0FAE:208A push AX
0FAE:208B call far 17D3:03F5
0FAE:2090 add SP,4
0FAE:2093 mov ES,word ptr DS:[0x55C8]
0FAE:2097 mov word ptr ES:[0x37FE],0x000F
0FAE:209E push word ptr SS:[BP-4]
0FAE:20A1 call far 17D3:0281
0FAE:20A6 mov SP,BP
0FAE:20A8 pop BP
0FAE:20A9 ret far
11B8:000A push BP
11B8:000B mov BP,SP
11B8:000D mov AX,0x0044
11B8:0010 call far 19FC:2FDC
11B8:0015 push DI
11B8:0016 push SI
11B8:0017 mov ES,word ptr DS:[0x55CA]
11B8:001B mov word ptr ES:[0x2B20],0x000C
11B8:0022 mov ES,word ptr DS:[0x55CC]
11B8:0026 mov AX,word ptr ES:[0xA44B]
11B8:002A mov word ptr SS:[BP-50],AX
11B8:002D mov ES,word ptr DS:[0x55CE]
11B8:0031 mov AX,word ptr ES:[0xA44D]
11B8:0035 mov word ptr SS:[BP-54],AX
11B8:0038 mov word ptr SS:[BP-44],0
11B8:003D mov BX,word ptr SS:[BP-44]
11B8:0040 mov ES,word ptr DS:[0x55D0]
11B8:0044 mov AL,byte ptr ES:[BX+0x07A4]
11B8:0049 mov SI,BX
11B8:004B mov byte ptr SS:[BP+SI-28],AL
11B8:004E inc word ptr SS:[BP-44]
11B8:0051 cmp word ptr SS:[BP-44],9
11B8:0055 jl short 0x003D
11B8:0057 mov word ptr SS:[BP-10],0
11B8:005C cmp word ptr SS:[BP+6],0
11B8:0060 jne short 0x00A1
11B8:0062 mov word ptr SS:[BP-38],0
11B8:0067 mov SI,word ptr SS:[BP-38]
11B8:006A shl SI,1
11B8:006C mov AX,0x001A
11B8:006F imul word ptr SS:[BP-38]
11B8:0072 mov DI,AX
11B8:0074 mov ES,word ptr DS:[0x55D2]
11B8:0078 mov AX,word ptr ES:[SI+0x4024]
11B8:007D mov ES,word ptr DS:[0x55D4]
11B8:0081 mov word ptr ES:[DI-11376],AX
11B8:0086 mov ES,word ptr DS:[0x55D6]
11B8:008A mov AX,word ptr ES:[SI+0x4056]
11B8:008F mov ES,word ptr DS:[0x55D4]
11B8:0093 mov word ptr ES:[DI-11374],AX
11B8:0098 inc word ptr SS:[BP-38]
11B8:009B cmp word ptr SS:[BP-38],8
11B8:009F jl short 0x0067
11B8:00A1 mov word ptr SS:[BP-38],0
11B8:00A6 jmp near 0x016E
11B8:00A9 inc word ptr SS:[BP-42]
11B8:00AC cmp word ptr SS:[BP-42],0x0018
11B8:00B0 jl short 0x00B5
11B8:00B2 jmp near 0x016B
11B8:00B5 mov AX,0x0018
11B8:00B8 imul word ptr SS:[BP-38]
11B8:00BB mov SI,AX
11B8:00BD add SI,word ptr SS:[BP-42]
11B8:00C0 mov AL,2
11B8:00C2 mov ES,word ptr DS:[0x55D8]
11B8:00C6 mov byte ptr ES:[SI+0x41D4],AL
11B8:00CB mov byte ptr ES:[SI+0x40B4],AL
11B8:00D0 cmp word ptr SS:[BP-42],0x000C
11B8:00D4 jge short 0x00F1
11B8:00D6 mov AX,0x000C
11B8:00D9 imul word ptr SS:[BP-38]
11B8:00DC mov SI,AX
11B8:00DE add SI,word ptr SS:[BP-42]
11B8:00E1 mov AL,0xFF
11B8:00E3 mov ES,word ptr DS:[0x55DA]
11B8:00E7 mov byte ptr ES:[SI+0x3890],AL
11B8:00EC mov byte ptr ES:[SI+0x3800],AL
11B8:00F1 mov AX,0x0030
11B8:00F4 imul word ptr SS:[BP-38]
11B8:00F7 mov SI,AX
11B8:00F9 add SI,word ptr SS:[BP-42]
11B8:00FC mov AL,0xFF
11B8:00FE mov ES,word ptr DS:[0x55DC]
11B8:0102 mov byte ptr ES:[SI+0x351E],AL
11B8:0107 mov byte ptr ES:[SI+0x32DE],AL
11B8:010C mov byte ptr ES:[SI+0x3506],AL
11B8:0111 mov byte ptr ES:[SI+0x32C6],AL
11B8:0116 cmp word ptr SS:[BP+6],0
11B8:011A jne short 0x00A9
11B8:011C cmp word ptr SS:[BP-38],0
11B8:0120 jne short 0x00A9
11B8:0122 mov SI,word ptr SS:[BP-42]
11B8:0125 shl SI,1
11B8:0127 sub AX,AX
11B8:0129 mov ES,word ptr DS:[0x55DE]
11B8:012D mov word ptr ES:[SI+0x393C],AX
11B8:0132 mov ES,word ptr DS:[0x55E0]
11B8:0136 mov word ptr ES:[SI+0x406A],AX
11B8:013B mov BX,word ptr SS:[BP-42]
11B8:013E mov ES,word ptr DS:[0x55E2]
11B8:0142 mov byte ptr ES:[BX+0x32AE],AL
11B8:0147 mov AL,0xFF
11B8:0149 mov BX,word ptr SS:[BP-42]
11B8:014C mov ES,word ptr DS:[0x55E4]
11B8:0150 mov byte ptr ES:[BX+0x3920],AL
11B8:0155 cbw
11B8:0156 mov ES,word ptr DS:[0x55D6]
11B8:015A mov word ptr ES:[SI+0x4036],AX
11B8:015F mov ES,word ptr DS:[0x55D2]
11B8:0163 mov word ptr ES:[SI+0x4004],AX
11B8:0168 jmp near 0x00A9
11B8:016B inc word ptr SS:[BP-38]
11B8:016E cmp word ptr SS:[BP-38],0x000C
11B8:0172 jge short 0x017C
11B8:0174 mov word ptr SS:[BP-42],0
11B8:0179 jmp near 0x00AC
11B8:017C mov word ptr SS:[BP-38],0
11B8:0181 sub AL,AL
11B8:0183 mov BX,word ptr SS:[BP-38]
11B8:0186 mov ES,word ptr DS:[0x55E6]
11B8:018A mov byte ptr ES:[BX+0x3998],AL
11B8:018F mov BX,word ptr SS:[BP-38]
11B8:0192 mov byte ptr ES:[BX+0x3994],AL
11B8:0197 mov BX,word ptr SS:[BP-38]
11B8:019A mov ES,word ptr DS:[0x55E8]
11B8:019E mov byte ptr ES:[BX-10890],AL
11B8:01A3 mov BX,word ptr SS:[BP-38]
11B8:01A6 mov ES,word ptr DS:[0x55EA]
11B8:01AA mov byte ptr ES:[BX+0x006E],AL
11B8:01AF inc word ptr SS:[BP-38]
11B8:01B2 cmp word ptr SS:[BP-38],8
11B8:01B6 jl short 0x0181
11B8:01B8 mov ES,word ptr DS:[0x55CC]
11B8:01BC mov AX,word ptr ES:[0xA44B]
11B8:01C0 mov word ptr SS:[BP-40],AX
11B8:01C3 mov ES,word ptr DS:[0x55CE]
11B8:01C7 mov AX,word ptr ES:[0xA44D]
11B8:01CB mov word ptr SS:[BP-46],AX
11B8:01CE sub AX,AX
11B8:01D0 mov word ptr SS:[BP-56],AX
11B8:01D3 mov word ptr SS:[BP-34],AX
11B8:01D6 mov word ptr SS:[BP-16],AX
11B8:01D9 mov word ptr SS:[BP-44],AX
11B8:01DC mov AX,0x0011
11B8:01DF imul word ptr SS:[BP-44]
11B8:01E2 mov SI,AX
11B8:01E4 mov ES,word ptr DS:[0x55D4]
11B8:01E8 cmp byte ptr ES:[SI-14828],0xFF
11B8:01EE je short 0x0250
11B8:01F0 cmp byte ptr ES:[SI-14816],8
11B8:01F6 jl short 0x0250
11B8:01F8 mov BX,word ptr SS:[BP-16]
11B8:01FB mov AL,byte ptr DS:[BX+0x3A1E]
11B8:01FF cbw
11B8:0200 push AX
11B8:0201 mov AL,byte ptr DS:[BX+0x3A16]
11B8:0205 cbw
11B8:0206 push AX
11B8:0207 call far 017D:191B
11B8:0250 inc word ptr SS:[BP-44]
11B8:0253 cmp word ptr SS:[BP-44],8
11B8:0257 jl short 0x01DC
11B8:0259 mov word ptr SS:[BP-44],0
11B8:025E mov AX,0x007D
11B8:0261 imul word ptr SS:[BP-44]
11B8:0264 mov BX,AX
11B8:0266 mov ES,word ptr DS:[0x55D4]
11B8:026A cmp byte ptr ES:[BX-14556],0xFF
11B8:0270 je short 0x02D2
11B8:0272 mov BX,word ptr SS:[BP-34]
11B8:0275 mov AL,byte ptr DS:[BX+0x3A26]
11B8:0279 cbw
11B8:027A mov word ptr SS:[BP-38],AX
11B8:027D mov AL,byte ptr DS:[BX+0x3A2A]
11B8:0281 cbw
11B8:0282 mov word ptr SS:[BP-42],AX
11B8:0285 inc word ptr SS:[BP-34]
11B8:0288 push AX
11B8:0289 push word ptr SS:[BP-38]
11B8:028C call far 017D:191B
11B8:0291 add SP,4
11B8:0294 mov SI,word ptr SS:[BP-44]
11B8:0297 shl SI,1
11B8:0299 mov ES,word ptr DS:[0x55CC]
11B8:029D mov AX,word ptr ES:[0xA44B]
11B8:02A1 mov ES,word ptr DS:[0x55D2]
11B8:02A5 mov word ptr ES:[SI+0x4004],AX
11B8:02AA mov ES,word ptr DS:[0x55CE]
11B8:02AE mov AX,word ptr ES:[0xA44D]
11B8:02B2 mov ES,word ptr DS:[0x55D6]
11B8:02B6 mov word ptr ES:[SI+0x4036],AX
11B8:02BB mov ES,word ptr DS:[0x55E0]
11B8:02BF inc word ptr ES:[SI+0x406A]
11B8:02C4 push word ptr SS:[BP-46]
11B8:02C7 push word ptr SS:[BP-40]
11B8:02CA call far 017D:186F
11B8:02CF add SP,4
11B8:02D2 inc word ptr SS:[BP-44]
11B8:02D5 cmp word ptr SS:[BP-44],4
11B8:02D9 jl short 0x025E
11B8:02DB cmp word ptr SS:[BP+6],0
11B8:02DF je short 0x02E4
11B8:02E1 jmp near 0x0471
11B8:02E4 call far 0728:0D3D
11B8:02E9 mov AX,4
11B8:02EC push AX
11B8:02ED call far 17D3:0281
11B8:02F2 add SP,2
11B8:02F5 call far 17D3:0388
11B8:02FA mov ES,word ptr DS:[0x55EC]
11B8:02FE mov word ptr ES:[0x37FE],0x000F
11B8:0305 sub AX,AX
11B8:0307 mov word ptr SS:[BP-10],AX
11B8:030A mov word ptr SS:[BP-18],AX
11B8:030D mov word ptr SS:[BP-44],0x000C
11B8:0312 mov SI,word ptr SS:[BP-44]
11B8:0315 shl SI,1
11B8:0317 mov ES,word ptr DS:[0x55E0]
11B8:031B cmp word ptr ES:[SI+0x406A],0
11B8:0321 je short 0x0340
11B8:0323 mov ES,word ptr DS:[0x55D2]
11B8:0327 cmp word ptr ES:[SI+0x4004],-1
11B8:032D je short 0x0340
11B8:032F mov ES,word ptr DS:[0x55D6]
11B8:0333 cmp word ptr ES:[SI+0x4036],-1
11B8:0339 je short 0x0340
11B8:033B mov word ptr SS:[BP-10],1
11B8:0340 inc word ptr SS:[BP-44]
11B8:0343 cmp word ptr SS:[BP-44],0x0018
11B8:0347 jl short 0x0312
11B8:0349 cmp word ptr SS:[BP-10],0
11B8:034D je short 0x0356
11B8:034F push CS
11B8:0350 call near 0x28DB
11B8:0353 mov word ptr SS:[BP-10],AX
11B8:0356 cmp word ptr SS:[BP-10],0
11B8:035A jne short 0x035F
11B8:035C jmp near 0x0476
11B8:035F mov AX,0x3402
11B8:0362 push DS
11B8:0363 push AX
11B8:0364 call far 17D3:03F5
11B8:0369 add SP,4
11B8:036C mov word ptr SS:[BP-44],4
11B8:0371 mov AX,0x007D
11B8:0374 imul word ptr SS:[BP-44]
11B8:0377 mov BX,AX
11B8:0379 mov ES,word ptr DS:[0x55D4]
11B8:037D cmp byte ptr ES:[BX-14556],0xFF
11B8:0383 je short 0x0388
11B8:0385 inc word ptr SS:[BP-18]
11B8:0388 inc word ptr SS:[BP-44]
11B8:038B cmp word ptr SS:[BP-44],8
11B8:038F jl short 0x0371
11B8:0391 cmp word ptr SS:[BP-18],0
11B8:0395 je short 0x03C7
11B8:0397 push word ptr SS:[BP-18]
11B8:039A call far 18BA:0053
11B8:03C7 mov word ptr SS:[BP-18],0
11B8:03CC mov word ptr SS:[BP-44],8
11B8:03D1 mov AX,0x0011
11B8:03D4 imul word ptr SS:[BP-44]
11B8:03D7 mov BX,AX
11B8:03D9 mov ES,word ptr DS:[0x55D4]
11B8:03DD cmp byte ptr ES:[BX-14828],0xFF
11B8:03E3 je short 0x0411
11B8:03E5 mov SI,word ptr SS:[BP-44]
11B8:03E8 shl SI,1
11B8:03EA mov ES,word ptr DS:[0x55E0]
11B8:03EE cmp word ptr ES:[SI+0x407A],0
11B8:03F4 je short 0x0411
11B8:03F6 mov ES,word ptr DS:[0x55D2]
11B8:03FA cmp word ptr ES:[SI+0x4014],-1
11B8:0400 je short 0x0411
11B8:0402 mov ES,word ptr DS:[0x55D6]
11B8:0406 cmp word ptr ES:[SI+0x4046],-1
11B8:040C je short 0x0411
11B8:040E inc word ptr SS:[BP-18]
11B8:0411 inc word ptr SS:[BP-44]
11B8:0414 cmp word ptr SS:[BP-44],0x0010
11B8:0418 jl short 0x03D1
11B8:041A push word ptr SS:[BP-18]
11B8:041D call far 18BA:0053
11B8:0422 add SP,2
11B8:0425 mov AX,0x3421
11B8:0428 push DS
11B8:0429 push AX
11B8:042A call far 17D3:03F5
11B8:042F add SP,4
11B8:0432 cmp word ptr SS:[BP-18],1
11B8:0436 je short 0x043D
11B8:0438 call far 017D:2A69
11B8:043D call far 017D:2A7E
11B8:0442 mov AX,3
11B8:0445 push AX
11B8:0446 call far 17D3:0281
11B8:044B add SP,2
11B8:044E call far 17D3:0388
11B8:0453 mov AX,0x3428
11B8:0456 push DS
11B8:0457 push AX
11B8:0458 call far 17D3:03F5
11B8:045D add SP,4
11B8:0460 mov AX,1
11B8:0463 push AX
11B8:0464 call far 017D:1A13
11B8:0469 add SP,2
11B8:046C mov word ptr SS:[BP-6],AX
11B8:046F jmp short 0x0476
11B8:0471 mov word ptr SS:[BP-6],1
11B8:0476 cmp word ptr SS:[BP+6],0
11B8:047A je short 0x0481
11B8:047C mov word ptr SS:[BP-10],1
11B8:0481 cmp word ptr SS:[BP-10],0
11B8:0485 jne short 0x048A
11B8:0487 jmp near 0x1037
11B8:048A cmp word ptr SS:[BP-6],0
11B8:048E jne short 0x049C
11B8:0490 call far 19FC:0BC0
11B8:049C cmp word ptr SS:[BP-6],0
11B8:04A0 jne short 0x04BE
11B8:04A2 call far 17D3:0388
11B8:04BE mov ES,word ptr DS:[0x55EE]
11B8:04C2 cmp word ptr ES:[0x3772],0
11B8:04C8 je short 0x04E6
11B8:04CA call far 1650:17C6
11B8:04E6 cmp word ptr SS:[BP+6],2
11B8:04EA jne short 0x0515
11B8:04EC mov ES,word ptr DS:[0x55CE]
11B8:04F0 push word ptr ES:[0xA44D]
11B8:04F5 mov ES,word ptr DS:[0x55CC]
11B8:04F9 push word ptr ES:[0xA44B]
11B8:04FE call far 19FC:1314
11B8:0515 mov ES,word ptr DS:[0x55F0]
11B8:0519 mov word ptr ES:[0x009E],0
11B8:0520 call far 017D:2A2B
11B8:0525 mov ES,word ptr DS:[0x55F2]
11B8:0529 cmp word ptr ES:[0x0090],0
11B8:052F jne short 0x053E
11B8:0531 call far 0728:0B5E
11B8:0536 mov ES,word ptr DS:[0x55F0]
11B8:053A mov word ptr ES:[0x009E],AX
11B8:053E call far 017D:2A2B
11B8:0543 push CS
11B8:0544 call near 0x24F0
11B8:0547 mov ES,word ptr DS:[0x55F4]
11B8:054B mov word ptr ES:[0x2E38],AX
11B8:054F call far 017D:2A2B
11B8:0554 push CS
11B8:0555 call near 0x2556
11B8:0558 mov ES,word ptr DS:[0x55F6]
11B8:055C mov word ptr ES:[0x2E3A],AX
11B8:0560 sub AX,AX
11B8:0562 mov word ptr SS:[BP-12],AX
11B8:0565 mov word ptr SS:[BP-18],AX
11B8:0568 jmp near 0x102E
11B8:056B mov ES,word ptr DS:[0x55CC]
11B8:056F mov AX,word ptr ES:[0xA44B]
11B8:0573 mov word ptr SS:[BP-32],AX
11B8:0576 mov ES,word ptr DS:[0x55CE]
11B8:057A mov AX,word ptr ES:[0xA44D]
11B8:057E mov word ptr SS:[BP-36],AX
11B8:0581 mov ES,word ptr DS:[0x55F8]
11B8:0585 mov word ptr ES:[0x3992],0
11B8:058C mov ES,word ptr DS:[0x55F0]
11B8:0590 cmp word ptr ES:[0x009E],0
11B8:0596 je short 0x059B
11B8:0598 jmp near 0x07D0
11B8:059B mov word ptr SS:[BP-44],0
11B8:05A0 mov SI,word ptr SS:[BP-44]
11B8:05A3 shl SI,1
11B8:05A5 mov ES,word ptr DS:[0x55E0]
11B8:05A9 cmp word ptr ES:[SI+0x406A],0
11B8:05AF je short 0x05FC
11B8:05B1 mov ES,word ptr DS:[0x55D2]
11B8:05B5 cmp word ptr ES:[SI+0x4004],-1
11B8:05BB je short 0x05C9
11B8:05BD mov ES,word ptr DS:[0x55D6]
11B8:05C1 cmp word ptr ES:[SI+0x4036],-1
11B8:05C7 jne short 0x05D9
11B8:05C9 mov BX,word ptr SS:[BP-44]
11B8:05CC shl BX,1
11B8:05CE mov ES,word ptr DS:[0x55E0]
11B8:05D2 mov word ptr ES:[BX+0x406A],0
11B8:05D9 mov word ptr SS:[BP-48],0
11B8:05DE mov AX,0x0018
11B8:05E1 imul word ptr SS:[BP-44]
11B8:05E4 mov BX,AX
11B8:05E6 add BX,word ptr SS:[BP-48]
11B8:05E9 mov ES,word ptr DS:[0x55D8]
11B8:05ED mov byte ptr ES:[BX+0x40B4],2
11B8:05F3 inc word ptr SS:[BP-48]
11B8:05F6 cmp word ptr SS:[BP-48],0x0018
11B8:05FA jl short 0x05DE
11B8:05FC inc word ptr SS:[BP-44]
11B8:05FF cmp word ptr SS:[BP-44],0x000C
11B8:0603 jl short 0x05A0
11B8:0605 push CS
11B8:0606 call near 0x14C3
11B8:0609 mov word ptr SS:[BP-56],AX
11B8:060C mov ES,word ptr DS:[0x55EE]
11B8:0610 cmp word ptr ES:[0x3772],0
11B8:0616 je short 0x0651
11B8:0618 mov ES,word ptr DS:[0x55D6]
11B8:061C cmp word ptr ES:[0x4036],0xD000
11B8:0623 jae short 0x064C
11B8:0625 mov ES,word ptr DS:[0x55D2]
11B8:0629 cmp word ptr ES:[0x4004],0x0D00
11B8:0630 jge short 0x064C
11B8:0632 mov ES,word ptr DS:[0x55D6]
11B8:0636 cmp word ptr ES:[0x4036],0xB07F
11B8:063D jb short 0x064C
11B8:063F mov ES,word ptr DS:[0x55D2]
11B8:0643 cmp word ptr ES:[0x4004],0x0B7F
11B8:064A jge short 0x0651
11B8:064C mov word ptr SS:[BP-56],2
11B8:0651 cmp word ptr SS:[BP-56],0
11B8:0655 jne short 0x065A
11B8:0657 jmp near 0x06DC
11B8:065A cmp word ptr SS:[BP-56],2
11B8:065E je short 0x066F
11B8:0660 call far 19FC:0BC0
11B8:066F mov AX,3
11B8:0672 push AX
11B8:0673 call far 17D3:0281
11B8:06DC mov AX,word ptr SS:[BP-56]
11B8:06DF mov word ptr SS:[BP-18],AX
11B8:06E2 or AX,AX
11B8:06E4 je short 0x06E9
11B8:06E6 jmp near 0x0826
11B8:06E9 mov word ptr SS:[BP-44],0
11B8:06EE jmp near 0x0796
11B8:06F1 mov AX,0x0018
11B8:06F4 imul word ptr SS:[BP-44]
11B8:06F7 mov BX,AX
11B8:06F9 mov ES,word ptr DS:[0x55D8]
11B8:06FD cmp byte ptr ES:[BX+0x40B4],2
11B8:0703 je short 0x0708
11B8:0705 jmp near 0x0793
11B8:0708 mov AX,0x0030
11B8:070B imul word ptr SS:[BP-44]
11B8:070E mov BX,AX
11B8:0710 mov ES,word ptr DS:[0x55DC]
11B8:0714 cmp byte ptr ES:[BX+0x32C6],0xFF
11B8:071A je short 0x0793
11B8:071C mov SI,word ptr SS:[BP-44]
11B8:071F shl SI,1
11B8:0721 mov ES,word ptr DS:[0x55D6]
11B8:0725 push word ptr ES:[SI+0x4036]
11B8:072A mov ES,word ptr DS:[0x55D2]
11B8:072E push word ptr ES:[SI+0x4004]
11B8:0733 call far 017D:17BB
11B8:0793 inc word ptr SS:[BP-44]
11B8:0796 cmp word ptr SS:[BP-44],0x000C
11B8:079A jl short 0x079F
11B8:079C jmp near 0x0826
11B8:079F mov BX,word ptr SS:[BP-44]
11B8:07A2 shl BX,1
11B8:07A4 mov ES,word ptr DS:[0x55E0]
11B8:07A8 cmp word ptr ES:[BX+0x406A],0
11B8:07AE je short 0x0793
11B8:07B0 mov BX,word ptr SS:[BP-44]
11B8:07B3 mov ES,word ptr DS:[0x55E6]
11B8:07B7 cmp byte ptr ES:[BX+0x3994],0
11B8:07BD jne short 0x07C2
11B8:07BF jmp near 0x06F1
11B8:07C2 sub AX,AX
11B8:07C4 push AX
11B8:07C5 push BX
11B8:07C6 call far 0FAE:03AB
11B8:07D0 sub AX,AX
11B8:07D2 push AX
11B8:07D3 push CS
11B8:07D4 call near 0x1482
11B8:0826 cmp word ptr SS:[BP-56],0
11B8:082A je short 0x082F
11B8:082C jmp near 0x0FFD
11B8:082F push word ptr SS:[BP-36]
11B8:0832 push word ptr SS:[BP-32]
11B8:0835 call far 017D:17BB
11B8:083A add SP,4
11B8:083D mov ES,word ptr DS:[0x55FA]
11B8:0841 mov word ptr ES:[0x374C],0
11B8:0848 mov AX,0x000C
11B8:084B push AX
11B8:084C push CS
11B8:084D call near 0x1482
11B8:0850 add SP,2
11B8:0853 push word ptr SS:[BP-36]
11B8:0856 push word ptr SS:[BP-32]
11B8:0859 call far 017D:17BB
11B8:085E add SP,4
11B8:0861 mov ES,word ptr DS:[0x55CE]
11B8:0865 push word ptr ES:[0xA44D]
11B8:086A mov ES,word ptr DS:[0x55CC]
11B8:086E push word ptr ES:[0xA44B]
11B8:0873 call far 19FC:1314
11B8:0878 add SP,4
11B8:087B cmp word ptr SS:[BP+6],0
11B8:087F jle short 0x0886
11B8:0881 mov AX,1
11B8:0884 jmp short 0x0888
11B8:0886 sub AX,AX
11B8:0888 push AX
11B8:0889 call far 1465:000C
11B8:088E add SP,2
11B8:0891 mov ES,word ptr DS:[0x55FC]
11B8:0895 cmp word ptr ES:[0x014A],0
11B8:089B jne short 0x08A0
11B8:089D jmp near 0x0CDB
11B8:08A0 mov ES,word ptr DS:[0x55D4]
11B8:08A4 cmp byte ptr ES:[0xD333],0
11B8:08AA jne short 0x08AF
11B8:08AC jmp near 0x0CDB
11B8:08AF mov ES,word ptr DS:[0x55FE]
11B8:08B3 cmp word ptr ES:[0x374A],0
11B8:08B9 jne short 0x08BE
11B8:08BB jmp near 0x0CDB
11B8:08BE mov AX,6
11B8:08C1 push AX
11B8:08C2 call far 17D3:0281
11B8:0CDB mov ES,word ptr DS:[0x55D4]
11B8:0CDF cmp byte ptr ES:[0xD32F],0
11B8:0CE5 je short 0x0D0E
11B8:0CE7 mov ES,word ptr DS:[0x55E0]
11B8:0CEB cmp word ptr ES:[0x406A],0
11B8:0CF1 je short 0x0D0E
11B8:0CF3 mov ES,word ptr DS:[0x55D2]
11B8:0CF7 cmp word ptr ES:[0x4004],0x0900
11B8:0CFE jle short 0x0D0E
11B8:0D00 cmp word ptr ES:[0x4004],0x0A07
11B8:0D07 jge short 0x0D0E
11B8:0D09 mov word ptr SS:[BP-12],1
11B8:0D0E mov word ptr SS:[BP-18],1
11B8:0D13 mov word ptr SS:[BP-44],0x000C
11B8:0D18 mov SI,word ptr SS:[BP-44]
11B8:0D1B shl SI,1
11B8:0D1D mov ES,word ptr DS:[0x55D2]
11B8:0D21 cmp word ptr ES:[SI+0x4004],-1
11B8:0D27 je short 0x0D35
11B8:0D29 mov ES,word ptr DS:[0x55D6]
11B8:0D2D cmp word ptr ES:[SI+0x4036],-1
11B8:0D33 jne short 0x0D45
11B8:0D35 mov BX,word ptr SS:[BP-44]
11B8:0D38 shl BX,1
11B8:0D3A mov ES,word ptr DS:[0x55E0]
11B8:0D3E mov word ptr ES:[BX+0x406A],0
11B8:0D45 mov BX,word ptr SS:[BP-44]
11B8:0D48 shl BX,1
11B8:0D4A mov ES,word ptr DS:[0x55E0]
11B8:0D4E cmp word ptr ES:[BX+0x406A],0
11B8:0D54 je short 0x0D5B
11B8:0D56 mov word ptr SS:[BP-18],0
11B8:0D5B inc word ptr SS:[BP-44]
11B8:0D5E cmp word ptr SS:[BP-44],0x0018
11B8:0D62 jl short 0x0D18
11B8:0D64 cmp word ptr SS:[BP-18],0
11B8:0D68 je short 0x0D6D
11B8:0D6A jmp near 0x0EF6
11B8:0D6D mov ES,word ptr DS:[0x55FA]
11B8:0D71 cmp word ptr ES:[0x374C],0
11B8:0D77 jne short 0x0D7C
11B8:0D79 jmp near 0x0EF6
11B8:0D7C cmp word ptr SS:[BP+6],0
11B8:0D80 je short 0x0D85
11B8:0D82 jmp near 0x0EF6
11B8:0D85 mov word ptr SS:[BP-66],0
11B8:0D8A mov word ptr SS:[BP-44],0x000C
11B8:0D8F mov BX,word ptr SS:[BP-44]
11B8:0D92 shl BX,1
11B8:0D94 mov ES,word ptr DS:[0x55E0]
11B8:0D98 cmp word ptr ES:[BX+0x406A],0
11B8:0D9E je short 0x0DA5
11B8:0DA0 mov word ptr SS:[BP-66],1
11B8:0DA5 inc word ptr SS:[BP-44]
11B8:0DA8 cmp word ptr SS:[BP-44],0x0010
11B8:0DAC jl short 0x0D8F
11B8:0DAE cmp word ptr SS:[BP-66],0
11B8:0DB2 jne short 0x0DB7
11B8:0DB4 jmp near 0x0EB6
11B8:0DB7 mov ES,word ptr DS:[0x55CC]
11B8:0DBB mov AX,word ptr ES:[0xA44B]
11B8:0DBF mov word ptr SS:[BP-60],AX
11B8:0DC2 mov ES,word ptr DS:[0x55CE]
11B8:0DC6 mov AX,word ptr ES:[0xA44D]
11B8:0DCA mov word ptr SS:[BP-62],AX
11B8:0DCD mov ES,word ptr DS:[0x55FA]
11B8:0DD1 sub AX,AX
11B8:0DD3 mov word ptr ES:[0x374C],AX
11B8:0DD7 mov word ptr SS:[BP-64],AX
11B8:0DDA mov word ptr SS:[BP-44],0x0010
11B8:0DDF mov SI,word ptr SS:[BP-44]
11B8:0DE2 shl SI,1
11B8:0DE4 mov ES,word ptr DS:[0x55E0]
11B8:0DE8 cmp word ptr ES:[SI+0x406A],0
11B8:0DEE jne short 0x0DF3
11B8:0DF0 jmp near 0x0E77
11B8:0DF3 mov ES,word ptr DS:[0x55D2]
11B8:0DF7 mov AX,word ptr ES:[SI+0x4004]
11B8:0DFC mov ES,word ptr DS:[0x55CC]
11B8:0E00 mov word ptr ES:[0xA44B],AX
11B8:0E04 mov ES,word ptr DS:[0x55D6]
11B8:0E08 mov AX,word ptr ES:[SI+0x4036]
11B8:0E0D mov ES,word ptr DS:[0x55CE]
11B8:0E11 mov word ptr ES:[0xA44D],AX
11B8:0E15 mov AX,0x000C
11B8:0E18 imul word ptr SS:[BP-44]
11B8:0E1B mov BX,AX
11B8:0E1D mov ES,word ptr DS:[0x55DA]
11B8:0E21 mov AL,byte ptr ES:[BX+0x3800]
11B8:0E26 cbw
11B8:0E27 mov word ptr SS:[BP-30],AX
11B8:0E2A mov SI,AX
11B8:0E2C shl SI,1
11B8:0E2E mov ES,word ptr DS:[0x55D6]
11B8:0E32 push word ptr ES:[SI+0x4036]
11B8:0E37 mov ES,word ptr DS:[0x55D2]
11B8:0E3B push word ptr ES:[SI+0x4004]
11B8:0E40 call far 0FAE:0BB5
11B8:0E77 inc word ptr SS:[BP-44]
11B8:0E7A cmp word ptr SS:[BP-44],0x0018
11B8:0E7E jge short 0x0E83
11B8:0E80 jmp near 0x0DDF
11B8:0E83 cmp word ptr SS:[BP-64],0
11B8:0E87 je short 0x0EA0
11B8:0E89 call far 1650:17C6
11B8:0EA0 mov ES,word ptr DS:[0x55CC]
11B8:0EA4 mov AX,word ptr SS:[BP-60]
11B8:0EA7 mov word ptr ES:[0xA44B],AX
11B8:0EAB mov ES,word ptr DS:[0x55CE]
11B8:0EAF mov AX,word ptr SS:[BP-62]
11B8:0EB2 mov word ptr ES:[0xA44D],AX
11B8:0EB6 mov ES,word ptr DS:[0x55FA]
11B8:0EBA cmp word ptr ES:[0x374C],0
11B8:0EC0 je short 0x0ED2
11B8:0EC2 call far 19FC:0BC0
11B8:0EC7 and AX,1
11B8:0ECA mov ES,word ptr DS:[0x55FA]
11B8:0ECE mov word ptr ES:[0x374C],AX
11B8:0ED2 cmp word ptr ES:[0x374C],0
11B8:0ED8 je short 0x0EF6
11B8:0EDA mov word ptr SS:[BP-18],1
11B8:0EDF call far 1650:17C6
11B8:0EE4 mov AX,0x38E0
11B8:0EE7 push DS
11B8:0EE8 push AX
11B8:0EE9 call far 1650:17EA
11B8:0EEE add SP,4
11B8:0EF1 call far 18BA:0259
11B8:0EF6 cmp word ptr SS:[BP+6],1
11B8:0EFA jne short 0x0F0D
11B8:0EFC mov ES,word ptr DS:[0x55E0]
11B8:0F00 cmp word ptr ES:[0x406A],0
11B8:0F06 jne short 0x0F0D
11B8:0F08 mov word ptr SS:[BP-18],1
11B8:0F0D cmp word ptr SS:[BP-12],0
11B8:0F11 jne short 0x0F36
11B8:0F13 cmp word ptr SS:[BP+6],2
11B8:0F17 jne short 0x0F36
11B8:0F19 mov ES,word ptr DS:[0x55E0]
11B8:0F1D cmp word ptr ES:[0x406A],0
11B8:0F23 jne short 0x0F36
11B8:0F25 mov ES,word ptr DS:[0x55D4]
11B8:0F29 cmp byte ptr ES:[0xD32F],0
11B8:0F2F jne short 0x0F36
11B8:0F31 mov word ptr SS:[BP-18],1
11B8:0F36 cmp word ptr SS:[BP-12],0
11B8:0F3A je short 0x0F41
11B8:0F3C mov word ptr SS:[BP-18],1
11B8:0F41 mov ES,word ptr DS:[0x55FC]
11B8:0F45 cmp word ptr ES:[0x014A],0
11B8:0F4B jne short 0x0F52
11B8:0F4D mov word ptr SS:[BP-18],1
11B8:0F52 mov ES,word ptr DS:[0x55EE]
11B8:0F56 cmp word ptr ES:[0x3772],0
11B8:0F5C jne short 0x0F61
11B8:0F5E jmp near 0x0FFD
11B8:0F61 mov word ptr SS:[BP-4],1
11B8:0F66 cmp word ptr SS:[BP-18],0
11B8:0F6A jne short 0x0F6F
11B8:0F6C jmp near 0x0FF0
11B8:0F6F mov AX,5
11B8:0F72 sub AX,word ptr SS:[BP-8]
11B8:0F75 mov word ptr SS:[BP-4],AX
11B8:0F78 jmp short 0x0FF0
11B8:0F7A cmp word ptr SS:[BP-8],5
11B8:0F7E jge short 0x0FF0
11B8:0F80 cmp word ptr SS:[BP-8],1
11B8:0F84 jne short 0x0F96
11B8:0F86 mov AX,1
11B8:0F89 push AX
11B8:0F8A mov AX,2
11B8:0F8D push AX
11B8:0F8E call far 017D:48B7
11B8:0F96 call far 1650:17C6
11B8:0FF0 mov AX,word ptr SS:[BP-4]
11B8:0FF3 dec word ptr SS:[BP-4]
11B8:0FF6 or AX,AX
11B8:0FF8 je short 0x0FFD
11B8:0FFA jmp near 0x0F7A
11B8:0FFD mov ES,word ptr DS:[0x55F0]
11B8:1001 cmp word ptr ES:[0x009E],0
11B8:1007 je short 0x102E
11B8:1009 mov ES,word ptr DS:[0x5606]
11B8:100D cmp word ptr ES:[0x3938],0
11B8:1013 jne short 0x102E
11B8:1015 call far 18BA:002F
11B8:102E cmp word ptr SS:[BP-18],0
11B8:1032 jne short 0x1037
11B8:1034 jmp near 0x056B
11B8:1037 cmp word ptr SS:[BP-10],0
11B8:103B jne short 0x1040
11B8:103D jmp near 0x140D
11B8:1040 mov AX,3
11B8:1043 push AX
11B8:1044 call far 17D3:0281
11B8:1049 add SP,2
11B8:104C call far 17D3:0388
11B8:1051 cmp word ptr SS:[BP+6],1
11B8:1055 jl short 0x1060
11B8:1057 cmp word ptr SS:[BP+6],3
11B8:105B je short 0x1060
11B8:105D jmp near 0x136D
11B8:1060 cmp word ptr SS:[BP-6],0
11B8:1064 jne short 0x1069
11B8:1066 jmp near 0x12BF
11B8:1069 cmp word ptr SS:[BP-56],0
11B8:106D je short 0x1072
11B8:106F jmp near 0x12BF
11B8:1072 mov ES,word ptr DS:[0x55FC]
11B8:1076 cmp word ptr ES:[0x014A],0
11B8:107C jne short 0x1081
11B8:107E jmp near 0x12BF
11B8:1081 mov AX,1
11B8:1084 push AX
11B8:1085 call far 17D3:0281
11B8:108A add SP,2
11B8:108D mov AX,1
11B8:1090 push AX
11B8:1091 call far 17D3:0004
11B8:1096 add SP,2
11B8:1099 call far 17D3:0388
11B8:109E mov word ptr SS:[BP-58],0
11B8:10A3 mov word ptr SS:[BP-44],0x000C
11B8:10A8 mov BX,word ptr SS:[BP-44]
11B8:10AB shl BX,1
11B8:10AD mov ES,word ptr DS:[0x55DE]
11B8:10B1 cmp word ptr ES:[BX+0x393C],0
11B8:10B7 je short 0x10BE
11B8:10B9 mov word ptr SS:[BP-58],1
11B8:10BE inc word ptr SS:[BP-44]
11B8:10C1 cmp word ptr SS:[BP-44],0x0018
11B8:10C5 jl short 0x10A8
11B8:10C7 cmp word ptr SS:[BP-58],0
11B8:10CB je short 0x10DF
11B8:10CD mov AX,0x38FC
11B8:10D0 push DS
11B8:10D1 push AX
11B8:10D2 call far 17D3:03F5
11B8:10DF mov word ptr SS:[BP-58],0
11B8:10E4 mov word ptr SS:[BP-44],0
11B8:10E9 mov AX,0x007D
11B8:10EC imul word ptr SS:[BP-44]
11B8:10EF mov BX,AX
11B8:10F1 mov ES,word ptr DS:[0x55D4]
11B8:10F5 cmp byte ptr ES:[BX-14556],0xFF
11B8:10FB je short 0x1102
11B8:10FD mov word ptr SS:[BP-58],1
11B8:1102 inc word ptr SS:[BP-44]
11B8:1105 cmp word ptr SS:[BP-44],4
11B8:1109 jl short 0x10E9
11B8:110B cmp word ptr SS:[BP-58],0
11B8:110F je short 0x117C
11B8:1111 mov word ptr SS:[BP-58],0
11B8:1116 mov word ptr SS:[BP-44],0x000C
11B8:111B mov BX,word ptr SS:[BP-44]
11B8:111E shl BX,1
11B8:1120 mov ES,word ptr DS:[0x55DE]
11B8:1124 cmp word ptr ES:[BX+0x393C],0
11B8:112A je short 0x1131
11B8:112C mov word ptr SS:[BP-58],1
11B8:1131 inc word ptr SS:[BP-44]
11B8:1134 cmp word ptr SS:[BP-44],0x0010
11B8:1138 jl short 0x111B
11B8:113A cmp word ptr SS:[BP-58],0
11B8:113E je short 0x117C
11B8:1140 mov word ptr SS:[BP-58],0
11B8:1145 mov word ptr SS:[BP-44],0
11B8:114A mov AX,0x0011
11B8:114D imul word ptr SS:[BP-44]
11B8:1150 mov SI,AX
11B8:1152 mov ES,word ptr DS:[0x55D4]
11B8:1156 mov AL,byte ptr ES:[SI-14828]
11B8:115B cbw
11B8:115C cmp AX,0x00FF
11B8:115F je short 0x1173
11B8:1161 cmp byte ptr ES:[SI-14819],0
11B8:1167 je short 0x1173
11B8:1169 call far 0728:0002
11B8:1173 inc word ptr SS:[BP-44]
11B8:1176 cmp word ptr SS:[BP-44],8
11B8:117A jl short 0x114A
11B8:117C mov word ptr SS:[BP-58],0
11B8:1181 mov word ptr SS:[BP-44],0
11B8:1186 mov SI,word ptr SS:[BP-44]
11B8:1189 shl SI,1
11B8:118B mov ES,word ptr DS:[0x55DE]
11B8:118F cmp word ptr ES:[SI+0x393C],0
11B8:1195 jne short 0x119F
11B8:1197 cmp word ptr ES:[SI+0x3954],0
11B8:119D je short 0x11A4
11B8:119F mov word ptr SS:[BP-58],1
11B8:11A4 inc word ptr SS:[BP-44]
11B8:11A7 cmp word ptr SS:[BP-44],4
11B8:11AB jl short 0x1186
11B8:11AD cmp word ptr SS:[BP-58],0
11B8:11B1 jne short 0x11B6
11B8:11B3 jmp near 0x1251
11B8:11B6 mov word ptr SS:[BP-58],0
11B8:11BB mov word ptr SS:[BP-44],0
11B8:11C0 mov AX,0x0011
11B8:11C3 imul word ptr SS:[BP-44]
11B8:11C6 mov SI,AX
11B8:11C8 mov ES,word ptr DS:[0x55D4]
11B8:11CC cmp byte ptr ES:[SI-14828],0xFF
11B8:11D2 je short 0x11E9
11B8:11D4 cmp byte ptr ES:[SI-14820],0
11B8:11DA je short 0x11E9
11B8:11DC cmp byte ptr ES:[SI-14816],8
11B8:11E2 jl short 0x11E9
11B8:11E4 mov word ptr SS:[BP-58],1
11B8:11E9 inc word ptr SS:[BP-44]
11B8:11EC cmp word ptr SS:[BP-44],8
11B8:11F0 jl short 0x11C0
11B8:11F2 cmp word ptr SS:[BP-58],0
11B8:11F6 je short 0x1224
11B8:11F8 mov word ptr SS:[BP-58],0
11B8:11FD mov word ptr SS:[BP-44],0
11B8:1202 mov AX,0x007D
11B8:1205 imul word ptr SS:[BP-44]
11B8:1208 mov BX,AX
11B8:120A mov ES,word ptr DS:[0x55D4]
11B8:120E cmp byte ptr ES:[BX-14556],0xFF
11B8:1214 jne short 0x121B
11B8:1216 mov word ptr SS:[BP-58],1
11B8:121B inc word ptr SS:[BP-44]
11B8:121E cmp word ptr SS:[BP-44],4
11B8:1222 jl short 0x1202
11B8:1224 cmp word ptr SS:[BP-58],0
11B8:1228 je short 0x1251
11B8:122A mov word ptr SS:[BP-44],0
11B8:122F mov SI,word ptr SS:[BP-44]
11B8:1232 test byte ptr SS:[BP+SI-28],0x80
11B8:1236 je short 0x123D
11B8:1238 mov word ptr SS:[BP-58],0
11B8:123D inc word ptr SS:[BP-44]
11B8:1240 cmp word ptr SS:[BP-44],9
11B8:1244 jl short 0x122F
11B8:1246 cmp word ptr SS:[BP-58],0
11B8:124A je short 0x1251
11B8:124C call far 0728:04F9
11B8:1251 call far 0728:094B
11B8:1256 mov ES,word ptr DS:[0x55D4]
11B8:125A mov byte ptr ES:[0xD335],0
11B8:1260 mov AX,3
11B8:1263 push AX
11B8:1264 call far 17D3:0281
11B8:1269 add SP,2
11B8:126C call far 17D3:0388
11B8:1271 mov word ptr SS:[BP-58],0
11B8:1276 mov word ptr SS:[BP-44],0
11B8:127B mov AX,0x0011
11B8:127E imul word ptr SS:[BP-44]
11B8:1281 mov SI,AX
11B8:1283 mov ES,word ptr DS:[0x55D4]
11B8:1287 cmp byte ptr ES:[SI-14828],0xFF
11B8:128D je short 0x12A3
11B8:128F mov AL,byte ptr ES:[SI-14813]
11B8:1294 cbw
11B8:1295 mov CX,AX
11B8:1297 mov AL,0x0A
11B8:1299 imul byte ptr ES:[SI-14827]
11B8:129E sub AX,CX
11B8:12A0 add word ptr SS:[BP-58],AX
11B8:12A3 inc word ptr SS:[BP-44]
11B8:12A6 cmp word ptr SS:[BP-44],8
11B8:12AA jl short 0x127B
11B8:12AC cmp word ptr SS:[BP-58],0
11B8:12B0 je short 0x12E2
11B8:12B2 sub AX,AX
11B8:12B4 push AX
11B8:12B5 call far 0DAE:000A
11B8:12BF mov ES,word ptr DS:[0x55FC]
11B8:12C3 cmp word ptr ES:[0x014A],0
11B8:12C9 je short 0x12E2
11B8:12CB call far 17D3:0388
11B8:12E2 mov ES,word ptr DS:[0x55FC]
11B8:12E6 cmp word ptr ES:[0x014A],0
11B8:12EC jne short 0x12F1
11B8:12EE jmp near 0x141A
11B8:12F1 cmp word ptr SS:[BP+6],1
11B8:12F5 jl short 0x1300
11B8:12F7 cmp word ptr SS:[BP+6],3
11B8:12FB je short 0x1300
11B8:12FD jmp near 0x141A
11B8:1300 mov AX,4
11B8:1303 push AX
11B8:1304 call far 17D3:0281
11B8:1309 add SP,2
11B8:130C call far 17D3:0388
11B8:1311 mov AX,1
11B8:1314 push AX
11B8:1315 call far 017D:4CAC
11B8:131A add SP,2
11B8:131D call far 1650:17C6
11B8:1322 mov AX,0x3954
11B8:1325 push DS
11B8:1326 push AX
11B8:1327 call far 17D3:03F5
11B8:132C add SP,4
11B8:132F call far 017D:2A2B
11B8:1334 call far 18BA:0259
11B8:1339 push word ptr SS:[BP-54]
11B8:133C push word ptr SS:[BP-50]
11B8:133F call far 017D:17BB
11B8:1344 add SP,4
11B8:1347 push CS
11B8:1348 call near 0x2835
11B8:134B mov ES,word ptr DS:[0x55CE]
11B8:134F push word ptr ES:[0xA44D]
11B8:1354 mov ES,word ptr DS:[0x55CC]
11B8:1358 push word ptr ES:[0xA44B]
11B8:135D call far 19FC:1314
11B8:1362 add SP,4
11B8:1365 call far 19FC:18EF
11B8:136A jmp near 0x141A
11B8:136D mov ES,word ptr DS:[0x55FC]
11B8:1371 cmp word ptr ES:[0x014A],0
11B8:1377 jne short 0x137C
11B8:1379 jmp near 0x141A
11B8:137C mov ES,word ptr DS:[0x55EE]
11B8:1380 cmp word ptr ES:[0x3772],0
11B8:1386 jne short 0x13E2
11B8:1388 cmp word ptr SS:[BP+6],1
11B8:138C jne short 0x13A7
11B8:138E call far 1650:17C6
11B8:13A7 cmp word ptr SS:[BP-12],0
11B8:13AB jne short 0x141A
11B8:13AD call far 1650:17C6
11B8:13E2 cmp word ptr SS:[BP-56],2
11B8:13E6 jne short 0x141A
11B8:13E8 mov AX,3
11B8:13EB push AX
11B8:13EC call far 17D3:0281
11B8:140D push word ptr SS:[BP-54]
11B8:1410 push word ptr SS:[BP-50]
11B8:1413 push CS
11B8:1414 call near 0x2AA3
11B8:1417 add SP,4
11B8:141A mov word ptr SS:[BP-38],0
11B8:141F mov AX,0x001A
11B8:1422 imul word ptr SS:[BP-38]
11B8:1425 mov SI,AX
11B8:1427 mov DI,word ptr SS:[BP-38]
11B8:142A shl DI,1
11B8:142C mov ES,word ptr DS:[0x55D4]
11B8:1430 mov AX,word ptr ES:[SI-11376]
11B8:1435 mov ES,word ptr DS:[0x55D2]
11B8:1439 mov word ptr ES:[DI+0x4024],AX
11B8:143E mov ES,word ptr DS:[0x55D4]
11B8:1442 mov AX,word ptr ES:[SI-11374]
11B8:1447 mov ES,word ptr DS:[0x55D6]
11B8:144B mov word ptr ES:[DI+0x4056],AX
11B8:1450 mov AL,0xFF
11B8:1452 mov BX,word ptr SS:[BP-38]
11B8:1455 mov ES,word ptr DS:[0x5608]
11B8:1459 mov byte ptr ES:[BX+0x397C],AL
11B8:145E mov BX,word ptr SS:[BP-38]
11B8:1461 mov byte ptr ES:[BX+0x396C],AL
11B8:1466 mov BX,word ptr SS:[BP-38]
11B8:1469 mov ES,word ptr DS:[0x560A]
11B8:146D mov byte ptr ES:[BX+0x40AA],0x10
11B8:1473 inc word ptr SS:[BP-38]
11B8:1476 cmp word ptr SS:[BP-38],8
11B8:147A jl short 0x141F
11B8:147C pop SI
11B8:147D pop DI
11B8:147E mov SP,BP
11B8:1480 pop BP
11B8:1481 ret far
11B8:1482 push BP
11B8:1483 mov BP,SP
11B8:1485 mov AX,2
11B8:1488 call far 19FC:2FDC
11B8:148D push SI
11B8:148E mov word ptr SS:[BP-2],0
11B8:1493 mov SI,word ptr SS:[BP-2]
11B8:1496 add SI,word ptr SS:[BP+6]
11B8:1499 mov BX,SI
11B8:149B shl BX,1
11B8:149D mov ES,word ptr DS:[0x55E0]
11B8:14A1 cmp word ptr ES:[BX+0x406A],0
11B8:14A7 je short 0x14B5
11B8:14A9 sub AX,AX
11B8:14AB push AX
11B8:14AC push SI
11B8:14AD call far 0FAE:03AB
11B8:14B2 add SP,4
11B8:14B5 inc word ptr SS:[BP-2]
11B8:14B8 cmp word ptr SS:[BP-2],0x000C
11B8:14BC jl short 0x1493
11B8:14BE pop SI
11B8:14BF mov SP,BP
11B8:14C1 pop BP
11B8:14C2 ret far
11B8:14C3 push BP
11B8:14C4 mov BP,SP
11B8:14C6 mov AX,0x000C
11B8:14C9 call far 19FC:2FDC
11B8:14CE push SI
11B8:14CF mov AX,1
11B8:14D2 mov word ptr SS:[BP-4],AX
11B8:14D5 mov word ptr SS:[BP-12],AX
11B8:14D8 mov word ptr SS:[BP-10],0
11B8:14DD jmp short 0x14E2
11B8:14DF inc word ptr SS:[BP-10]
11B8:14E2 cmp word ptr SS:[BP-10],0x000C
11B8:14E6 jge short 0x14F9
11B8:14E8 mov BX,word ptr SS:[BP-10]
11B8:14EB shl BX,1
11B8:14ED mov ES,word ptr DS:[0x55E0]
11B8:14F1 cmp word ptr ES:[BX+0x406A],0
11B8:14F7 je short 0x14DF
11B8:14F9 sub AX,AX
11B8:14FB mov word ptr SS:[BP-2],AX
11B8:14FE mov word ptr SS:[BP-6],AX
11B8:1501 mov ES,word ptr DS:[0x55F2]
11B8:1505 cmp word ptr ES:[0x0090],AX
11B8:150A jne short 0x150F
11B8:150C jmp near 0x1763
11B8:150F mov BX,word ptr SS:[BP-10]
11B8:1512 mov ES,word ptr DS:[0x55E6]
11B8:1516 mov byte ptr ES:[BX+0x3994],0
11B8:151C jmp near 0x1763
11B8:151F mov AX,4
11B8:1522 push AX
11B8:1523 call far 17D3:0281
11B8:1528 add SP,2
11B8:152B call far 17D3:0388
11B8:1530 sub AX,AX
11B8:1532 push AX
11B8:1533 push AX
11B8:1534 push word ptr SS:[BP-10]
11B8:1537 call far 0728:18E8
11B8:153C add SP,6
11B8:153F mov ES,word ptr DS:[0x55EC]
11B8:1543 mov word ptr ES:[0x37FE],0x000F
11B8:154A mov BX,word ptr SS:[BP-10]
11B8:154D mov ES,word ptr DS:[0x55E6]
11B8:1551 cmp byte ptr ES:[BX+0x3994],0
11B8:1557 je short 0x1574
11B8:1559 mov AX,0x3A42
11B8:155C push DS
11B8:155D push AX
11B8:155E call far 17D3:03F5
11B8:1574 mov AX,1
11B8:1577 push AX
11B8:1578 push word ptr SS:[BP-10]
11B8:157B push CS
11B8:157C call near 0x1774
11B8:157F add SP,4
11B8:1582 mov AX,3
11B8:1585 push AX
11B8:1586 call far 17D3:0281
11B8:158B add SP,2
11B8:158E call far 17D3:0388
11B8:1593 mov ES,word ptr DS:[0x55EC]
11B8:1597 mov word ptr ES:[0x37FE],0x000F
11B8:159E cmp word ptr SS:[BP-10],4
11B8:15A2 jge short 0x15BE
11B8:15A4 mov AX,0x3A6F
11B8:15A7 push DS
11B8:15A8 push AX
11B8:15A9 call far 17D3:03F5
11B8:15AE add SP,4
11B8:15B1 mov ES,word ptr DS:[0x560C]
11B8:15B5 mov word ptr ES:[0x00C6],0x000A
11B8:15BC jmp short 0x15D6
11B8:15BE mov AX,0x3ABC
11B8:15C1 push DS
11B8:15C2 push AX
11B8:15C3 call far 17D3:03F5
11B8:15D6 cmp word ptr SS:[BP-4],0
11B8:15DA je short 0x15EA
11B8:15DC mov AX,word ptr ES:[0x00C6]
11B8:15E0 dec AX
11B8:15E1 mov word ptr ES:[0x00C8],AX
11B8:15E5 mov word ptr SS:[BP-4],0
11B8:15EA call far 017D:2A2B
11B8:15EF mov AX,3
11B8:15F2 push AX
11B8:15F3 call far 17D3:0B5E
11B8:15F8 add SP,2
11B8:15FB mov word ptr SS:[BP-12],AX
11B8:15FE mov ES,word ptr DS:[0x560C]
11B8:1602 mov SI,word ptr ES:[0x00C6]
11B8:1607 sub SI,2
11B8:160A cmp AX,SI
11B8:160C jl short 0x161A
11B8:160E inc word ptr SS:[BP-6]
11B8:1611 cmp AX,SI
11B8:1613 jne short 0x161A
11B8:1615 mov word ptr SS:[BP-2],1
11B8:161A cmp word ptr SS:[BP-10],4
11B8:161E jge short 0x1626
11B8:1620 cmp word ptr SS:[BP-12],3
11B8:1624 jl short 0x1632
11B8:1626 cmp word ptr SS:[BP-10],4
11B8:162A jl short 0x163F
11B8:162C cmp word ptr SS:[BP-12],0
11B8:1630 jne short 0x163F
11B8:1632 push word ptr SS:[BP-12]
11B8:1635 push word ptr SS:[BP-10]
11B8:1638 push CS
11B8:1639 call near 0x1C1F
11B8:163F cmp word ptr SS:[BP-10],4
11B8:1643 jl short 0x1688
11B8:1645 cmp word ptr SS:[BP-12],1
11B8:1649 jne short 0x1688
11B8:164B mov word ptr SS:[BP-8],0
11B8:1650 mov AX,0x0030
11B8:1653 imul word ptr SS:[BP-10]
11B8:1656 mov BX,AX
11B8:1658 add BX,word ptr SS:[BP-8]
11B8:165B mov ES,word ptr DS:[0x55DC]
11B8:165F mov byte ptr ES:[BX+0x32C6],0xFF
11B8:1665 inc word ptr SS:[BP-8]
11B8:1668 cmp word ptr SS:[BP-8],0x0030
11B8:166C jl short 0x1650
11B8:166E mov BX,word ptr SS:[BP-10]
11B8:1671 mov ES,word ptr DS:[0x55E6]
11B8:1675 mov byte ptr ES:[BX+0x3994],0
11B8:167B sub AX,AX
11B8:167D push AX
11B8:167E push word ptr SS:[BP-10]
11B8:1681 push CS
11B8:1682 call near 0x1774
11B8:1688 cmp word ptr SS:[BP-10],4
11B8:168C jge short 0x169E
11B8:168E cmp word ptr SS:[BP-12],4
11B8:1692 jne short 0x169E
11B8:1694 push word ptr SS:[BP-10]
11B8:1697 push CS
11B8:1698 call near 0x2231
11B8:169E cmp word ptr SS:[BP-10],4
11B8:16A2 jge short 0x16AA
11B8:16A4 cmp word ptr SS:[BP-12],5
11B8:16A8 je short 0x16B6
11B8:16AA cmp word ptr SS:[BP-10],4
11B8:16AE jl short 0x16D1
11B8:16B0 cmp word ptr SS:[BP-12],3
11B8:16B4 jne short 0x16D1
11B8:16B6 mov ES,word ptr DS:[0x55F2]
11B8:16BA cmp word ptr ES:[0x0090],0
11B8:16C0 jne short 0x16D1
11B8:16C2 mov AX,1
11B8:16C5 push AX
11B8:16C6 push word ptr SS:[BP-10]
11B8:16C9 call far 0FAE:03AB
11B8:16D1 cmp word ptr SS:[BP-10],4
11B8:16D5 jge short 0x16DD
11B8:16D7 cmp word ptr SS:[BP-12],3
11B8:16DB je short 0x16E9
11B8:16DD cmp word ptr SS:[BP-10],4
11B8:16E1 jl short 0x16F4
11B8:16E3 cmp word ptr SS:[BP-12],2
11B8:16E7 jne short 0x16F4
11B8:16E9 push word ptr SS:[BP-10]
11B8:16EC call far 0EC0:0004
11B8:16F4 cmp word ptr SS:[BP-10],4
11B8:16F8 jge short 0x1700
11B8:16FA cmp word ptr SS:[BP-12],6
11B8:16FE je short 0x170C
11B8:1700 cmp word ptr SS:[BP-10],4
11B8:1704 jl short 0x1716
11B8:1706 cmp word ptr SS:[BP-12],4
11B8:170A jne short 0x1716
11B8:170C push word ptr SS:[BP-10]
11B8:170F push CS
11B8:1710 call near 0x2591
11B8:1716 mov ES,word ptr DS:[0x560C]
11B8:171A mov AX,word ptr ES:[0x00C6]
11B8:171E sub AX,3
11B8:1721 cmp AX,word ptr SS:[BP-12]
11B8:1724 jne short 0x1763
11B8:1726 inc word ptr SS:[BP-10]
11B8:1729 cmp word ptr SS:[BP-10],0x000B
11B8:172D jle short 0x1734
11B8:172F mov word ptr SS:[BP-10],0
11B8:1734 mov BX,word ptr SS:[BP-10]
11B8:1737 shl BX,1
11B8:1739 mov ES,word ptr DS:[0x55E0]
11B8:173D cmp word ptr ES:[BX+0x406A],0
11B8:1743 je short 0x1726
11B8:1745 cmp word ptr SS:[BP-10],4
11B8:1749 jl short 0x1758
11B8:174B mov ES,word ptr DS:[0x560C]
11B8:174F mov word ptr ES:[0x00C8],5
11B8:1756 jmp short 0x1763
11B8:1758 mov ES,word ptr DS:[0x560C]
11B8:175C mov word ptr ES:[0x00C8],7
11B8:1763 cmp word ptr SS:[BP-6],0
11B8:1767 jne short 0x176C
11B8:1769 jmp near 0x151F
11B8:176C mov AX,word ptr SS:[BP-2]
11B8:176F pop SI
11B8:1770 mov SP,BP
11B8:1772 pop BP
11B8:1773 ret far
11B8:1774 push BP
11B8:1775 mov BP,SP
11B8:1777 mov AX,0x0026
11B8:177A call far 19FC:2FDC
11B8:177F push DI
11B8:1780 push SI
11B8:1781 mov SI,word ptr SS:[BP+6]
11B8:1784 shl SI,1
11B8:1786 mov ES,word ptr DS:[0x55D2]
11B8:178A mov AX,word ptr ES:[SI+0x4004]
11B8:178F mov word ptr SS:[BP-6],AX
11B8:1792 mov ES,word ptr DS:[0x55D6]
11B8:1796 mov AX,word ptr ES:[SI+0x4036]
11B8:179B mov word ptr SS:[BP-10],AX
11B8:179E cmp word ptr SS:[BP+8],0
11B8:17A2 je short 0x17D4
11B8:17A4 push AX
11B8:17A5 push word ptr SS:[BP-6]
11B8:17A8 call far 017D:17BB
11B8:17AD add SP,4
11B8:17B0 mov ES,word ptr DS:[0x55CE]
11B8:17B4 push word ptr ES:[0xA44D]
11B8:17B9 mov ES,word ptr DS:[0x55CC]
11B8:17BD push word ptr ES:[0xA44B]
11B8:17C2 call far 19FC:1314
11B8:17C7 add SP,4
11B8:17CA call far 19FC:18EF
11B8:17CF call far 017D:0E4B
11B8:17D4 mov word ptr SS:[BP-6],1
11B8:17D9 sub AX,AX
11B8:17DB mov word ptr SS:[BP-4],AX
11B8:17DE mov word ptr SS:[BP-2],AX
11B8:17E1 cmp word ptr SS:[BP+6],4
11B8:17E5 jl short 0x17F3
11B8:17E7 cmp word ptr SS:[BP+6],0x000C
11B8:17EB jl short 0x1802
11B8:17ED cmp word ptr SS:[BP+6],0x000F
11B8:17F1 jg short 0x1802
11B8:17F3 mov word ptr SS:[BP-6],3
11B8:17F8 mov word ptr SS:[BP-2],0xFFFF
11B8:17FD mov word ptr SS:[BP-4],0xFFFE
11B8:1802 call far 18BA:06C3
11B8:1807 mov ES,word ptr DS:[0x560E]
11B8:180B mov word ptr ES:[0xB782],1
11B8:1812 mov word ptr SS:[BP-8],0
11B8:1817 jmp short 0x183C
11B8:1819 mov AX,0x000F
11B8:181C push AX
11B8:181D push word ptr SS:[BP-6]
11B8:1820 mov AX,word ptr SS:[BP-8]
11B8:1823 add AX,word ptr SS:[BP-4]
11B8:1826 add AX,0x000C
11B8:1829 push AX
11B8:182A mov AX,word ptr SS:[BP-2]
11B8:182D add AX,0x001A
11B8:1830 push AX
11B8:1831 call far 19FC:2B87
11B8:1836 add SP,8
11B8:1839 inc word ptr SS:[BP-8]
11B8:183C mov AX,word ptr SS:[BP-6]
11B8:183F cmp word ptr SS:[BP-8],AX
11B8:1842 jl short 0x1819
11B8:1844 cmp word ptr SS:[BP+6],0x000C
11B8:1848 jl short 0x184D
11B8:184A jmp near 0x1935
11B8:184D cmp word ptr SS:[BP+6],4
11B8:1851 jge short 0x1872
11B8:1853 mov AX,0x0030
11B8:1856 imul word ptr SS:[BP+6]
11B8:1859 mov BX,AX
11B8:185B mov ES,word ptr DS:[0x55DC]
11B8:185F mov AL,byte ptr ES:[BX+0x32C6]
11B8:1864 cbw
11B8:1865 push AX
11B8:1866 push word ptr SS:[BP+6]
11B8:1869 push CS
11B8:186A call near 0x22BC
11B8:186D add SP,4
11B8:1870 jmp short 0x187C
11B8:1872 push word ptr SS:[BP+6]
11B8:1875 push CS
11B8:1876 call near 0x2474
11B8:187C push word ptr SS:[BP+6]
11B8:187F push CS
11B8:1880 call near 0x193B
11B8:1883 add SP,2
11B8:1886 sub AX,AX
11B8:1888 mov word ptr SS:[BP-8],AX
11B8:188B mov byte ptr SS:[BP-13],AL
11B8:188E mov word ptr SS:[BP-6],0x001A
11B8:1893 mov word ptr SS:[BP-10],0x000C
11B8:1898 jmp short 0x1903
11B8:189A cmp word ptr SS:[BP-8],0x0018
11B8:189E jge short 0x191F
11B8:18A0 mov BX,word ptr SS:[BP-8]
11B8:18A3 inc word ptr SS:[BP-8]
11B8:18A6 add BX,SI
11B8:18A8 mov ES,word ptr DS:[0x55D8]
11B8:18AC mov AL,byte ptr ES:[BX+0x40B4]
11B8:18B1 cbw
11B8:18B2 mov word ptr SS:[BP-2],AX
11B8:18B5 mov BX,word ptr SS:[BP-8]
11B8:18B8 inc word ptr SS:[BP-8]
11B8:18BB add BX,SI
11B8:18BD mov AL,byte ptr ES:[BX+0x40B4]
11B8:18C2 cbw
11B8:18C3 mov word ptr SS:[BP-4],AX
11B8:18C6 mov AX,word ptr SS:[BP-2]
11B8:18C9 add word ptr SS:[BP-6],AX
11B8:18CC mov AX,word ptr SS:[BP-4]
11B8:18CF add word ptr SS:[BP-10],AX
11B8:18D2 inc word ptr SS:[BP-4]
11B8:18D5 mov DI,word ptr SS:[BP-4]
11B8:18D8 shl DI,1
11B8:18DA shl DI,1
11B8:18DC inc word ptr SS:[BP-2]
11B8:18DF mov BX,word ptr SS:[BP-2]
11B8:18E2 mov AL,byte ptr DS:[BX+DI+0x3B06]
11B8:18E6 mov byte ptr SS:[BP-14],AL
11B8:18E9 sub AX,AX
11B8:18EB push AX
11B8:18EC mov AX,0x000F
11B8:18EF push AX
11B8:18F0 push word ptr SS:[BP-10]
11B8:18F3 push word ptr SS:[BP-6]
11B8:18F6 lea AX,BP-14
11B8:18F9 push SS
11B8:18FA push AX
11B8:18FB call far 18BA:00D5
11B8:1903 mov AX,0x0018
11B8:1906 imul word ptr SS:[BP+6]
11B8:1909 mov SI,AX
11B8:190B mov BX,word ptr SS:[BP-8]
11B8:190E add BX,SI
11B8:1910 mov ES,word ptr DS:[0x55D8]
11B8:1914 cmp byte ptr ES:[BX+0x40B4],2
11B8:191A je short 0x191F
11B8:191C jmp near 0x189A
11B8:191F mov ES,word ptr DS:[0x5610]
11B8:1923 mov AX,word ptr SS:[BP-6]
11B8:1926 mov word ptr ES:[0x3778],AX
11B8:192A mov ES,word ptr DS:[0x5612]
11B8:192E mov AX,word ptr SS:[BP-10]
11B8:1931 mov word ptr ES:[0x377A],AX
11B8:1935 pop SI
11B8:1936 pop DI
11B8:1937 mov SP,BP
11B8:1939 pop BP
11B8:193A ret far
11B8:193B push BP
11B8:193C mov BP,SP
11B8:193E mov AX,0x002A
11B8:1941 call far 19FC:2FDC
11B8:1946 push DI
11B8:1947 push SI
11B8:1948 mov word ptr SS:[BP-32],0
11B8:194D mov AX,0x0018
11B8:1950 imul word ptr SS:[BP+6]
11B8:1953 mov BX,AX
11B8:1955 add BX,word ptr SS:[BP-32]
11B8:1958 mov ES,word ptr DS:[0x55D8]
11B8:195C mov byte ptr ES:[BX+0x40B4],2
11B8:1962 inc word ptr SS:[BP-32]
11B8:1965 cmp word ptr SS:[BP-32],0x0018
11B8:1969 jl short 0x194D
11B8:196B sub AX,AX
11B8:196D mov word ptr SS:[BP-38],AX
11B8:1970 mov word ptr SS:[BP-18],AX
11B8:1973 mov word ptr SS:[BP-32],AX
11B8:1976 mov word ptr SS:[BP-12],AX
11B8:1979 mov ES,word ptr DS:[0x55CC]
11B8:197D mov AX,word ptr ES:[0xA44B]
11B8:1981 mov ES,word ptr DS:[0x5614]
11B8:1985 mov word ptr ES:[0xE486],AX
11B8:1989 mov ES,word ptr DS:[0x55CE]
11B8:198D mov AX,word ptr ES:[0xA44D]
11B8:1991 mov ES,word ptr DS:[0x5616]
11B8:1995 mov word ptr ES:[0xE488],AX
11B8:1999 mov word ptr SS:[BP-8],0x001A
11B8:199E mov word ptr SS:[BP-14],0x000C
11B8:19A3 mov BX,word ptr SS:[BP+6]
11B8:19A6 mov ES,word ptr DS:[0x55E4]
11B8:19AA mov AL,byte ptr ES:[BX+0x3920]
11B8:19AF cbw
11B8:19B0 mov word ptr SS:[BP-10],AX
11B8:19B3 jmp near 0x1C01
11B8:19B6 mov AX,0x0030
11B8:19B9 imul word ptr SS:[BP+6]
11B8:19BC mov BX,AX
11B8:19BE mov AX,word ptr SS:[BP-32]
11B8:19C1 inc word ptr SS:[BP-32]
11B8:19C4 add BX,AX
11B8:19C6 mov ES,word ptr DS:[0x55DC]
11B8:19CA mov AL,byte ptr ES:[BX+0x32C6]
11B8:19CF cbw
11B8:19D0 mov word ptr SS:[BP-26],AX
11B8:19D3 inc AX
11B8:19D4 jne short 0x19DC
11B8:19D6 inc word ptr SS:[BP-12]
11B8:19D9 jmp near 0x1C01
11B8:19DC mov AX,0x0030
11B8:19DF imul word ptr SS:[BP+6]
11B8:19E2 mov SI,AX
11B8:19E4 mov BX,word ptr SS:[BP-32]
11B8:19E7 inc word ptr SS:[BP-32]
11B8:19EA add BX,SI
11B8:19EC mov AL,byte ptr ES:[BX+0x32C6]
11B8:19F1 sub AH,AH
11B8:19F3 mov CH,AL
11B8:19F5 sub CL,CL
11B8:19F7 mov word ptr SS:[BP-4],CX
11B8:19FA mov BX,word ptr SS:[BP-32]
11B8:19FD inc word ptr SS:[BP-32]
11B8:1A00 add BX,SI
11B8:1A02 mov AL,byte ptr ES:[BX+0x32C6]
11B8:1A07 cbw
11B8:1A08 and CX,0x0F00
11B8:1A0C or AX,CX
11B8:1A0E mov word ptr SS:[BP-20],AX
11B8:1A11 mov BX,word ptr SS:[BP-32]
11B8:1A14 inc word ptr SS:[BP-32]
11B8:1A17 add BX,SI
11B8:1A19 mov AL,byte ptr ES:[BX+0x32C6]
11B8:1A1E cbw
11B8:1A1F mov CX,word ptr SS:[BP-4]
11B8:1A22 and CX,0xF000
11B8:1A26 or AX,CX
11B8:1A28 mov word ptr SS:[BP-28],AX
11B8:1A2B mov word ptr SS:[BP-36],0
11B8:1A30 cmp word ptr SS:[BP+6],0x000C
11B8:1A34 jge short 0x1A4A
11B8:1A36 mov BX,word ptr SS:[BP+6]
11B8:1A39 mov ES,word ptr DS:[0x55E6]
11B8:1A3D cmp byte ptr ES:[BX+0x3994],0
11B8:1A43 jne short 0x1A4A
11B8:1A45 mov word ptr SS:[BP-36],1
11B8:1A4A cmp word ptr SS:[BP-10],-1
11B8:1A4E jne short 0x1A55
11B8:1A50 mov word ptr SS:[BP-36],1
11B8:1A55 cmp word ptr SS:[BP-36],0
11B8:1A59 je short 0x1A87
11B8:1A5B push word ptr SS:[BP-28]
11B8:1A5E push word ptr SS:[BP-20]
11B8:1A61 mov ES,word ptr DS:[0x5616]
11B8:1A65 push word ptr ES:[0xE488]
11B8:1A6A mov ES,word ptr DS:[0x5614]
11B8:1A6E push word ptr ES:[0xE486]
11B8:1A73 call far 19FC:0971
11B8:1A78 add SP,8
11B8:1A7B mov BX,word ptr SS:[BP+6]
11B8:1A7E mov ES,word ptr DS:[0x55E4]
11B8:1A82 mov byte ptr ES:[BX+0x3920],AL
11B8:1A87 mov ES,word ptr DS:[0x5618]
11B8:1A8B mov word ptr ES:[0xD57E],0
11B8:1A92 jmp near 0x1BF2
11B8:1A95 mov ES,word ptr DS:[0x5614]
11B8:1A99 mov AX,word ptr SS:[BP-20]
11B8:1A9C cmp word ptr ES:[0xE486],AX
11B8:1AA1 jne short 0x1AB4
11B8:1AA3 mov ES,word ptr DS:[0x5616]
11B8:1AA7 mov AX,word ptr SS:[BP-28]
11B8:1AAA cmp word ptr ES:[0xE488],AX
11B8:1AAF jne short 0x1AB4
11B8:1AB1 jmp near 0x1C01
11B8:1AB4 mov ES,word ptr DS:[0x5618]
11B8:1AB8 cmp word ptr ES:[0xD57E],0
11B8:1ABE je short 0x1AC3
11B8:1AC0 jmp near 0x1C01
11B8:1AC3 sub AX,AX
11B8:1AC5 push AX
11B8:1AC6 push word ptr SS:[BP-14]
11B8:1AC9 push word ptr SS:[BP-8]
11B8:1ACC push word ptr SS:[BP-28]
11B8:1ACF push word ptr SS:[BP-20]
11B8:1AD2 push word ptr SS:[BP+6]
11B8:1AD5 call far 0FAE:0006
11B8:1ADA add SP,0x000C
11B8:1ADD mov ES,word ptr DS:[0x561C]
11B8:1AE1 mov AX,word ptr ES:[0x458E]
11B8:1AE5 add word ptr SS:[BP-8],AX
11B8:1AE8 mov ES,word ptr DS:[0x561E]
11B8:1AEC mov AX,word ptr ES:[0x4590]
11B8:1AF0 add word ptr SS:[BP-14],AX
11B8:1AF3 mov AX,0x0018
11B8:1AF6 imul word ptr SS:[BP+6]
11B8:1AF9 mov SI,AX
11B8:1AFB mov ES,word ptr DS:[0x561C]
11B8:1AFF mov AL,byte ptr ES:[0x458E]
11B8:1B03 mov BX,word ptr SS:[BP-18]
11B8:1B06 inc word ptr SS:[BP-18]
11B8:1B09 add BX,SI
11B8:1B0B mov ES,word ptr DS:[0x55D8]
11B8:1B0F mov byte ptr ES:[BX+0x40B4],AL
11B8:1B14 mov ES,word ptr DS:[0x561E]
11B8:1B18 mov AL,byte ptr ES:[0x4590]
11B8:1B1C mov BX,word ptr SS:[BP-18]
11B8:1B1F inc word ptr SS:[BP-18]
11B8:1B22 add BX,SI
11B8:1B24 mov ES,word ptr DS:[0x55D8]
11B8:1B28 mov byte ptr ES:[BX+0x40B4],AL
11B8:1B2D mov AX,word ptr SS:[BP-14]
11B8:1B30 sar AX,1
11B8:1B32 mov CX,0x0018
11B8:1B35 imul CX
11B8:1B37 mov CX,word ptr SS:[BP-8]
11B8:1B3A sub CX,0x000D
11B8:1B3D sar CX,1
11B8:1B3F add AX,CX
11B8:1B41 mov word ptr SS:[BP-16],AX
11B8:1B44 mov DI,word ptr SS:[BP-14]
11B8:1B47 and DI,1
11B8:1B4A shl DI,1
11B8:1B4C mov BX,word ptr SS:[BP-8]
11B8:1B4F and BX,1
11B8:1B52 mov AL,byte ptr DS:[BX+DI+0x3B12]
11B8:1B56 cbw
11B8:1B57 mov word ptr SS:[BP-40],AX
11B8:1B5A test byte ptr SS:[BP-8],1
11B8:1B5E je short 0x1B73
11B8:1B60 mov ES,word ptr DS:[0x55CC]
11B8:1B64 test byte ptr ES:[0xA44B],1
11B8:1B6A je short 0x1B73
11B8:1B6C inc word ptr SS:[BP-16]
11B8:1B6F xor byte ptr SS:[BP-40],0x0A
11B8:1B73 test byte ptr SS:[BP-14],1
11B8:1B77 je short 0x1B8D
11B8:1B79 mov ES,word ptr DS:[0x55CE]
11B8:1B7D test byte ptr ES:[0xA44D],1
11B8:1B83 je short 0x1B8D
11B8:1B85 add word ptr SS:[BP-16],0x0018
11B8:1B89 xor byte ptr SS:[BP-40],5
11B8:1B8D mov ES,word ptr DS:[0x5620]
11B8:1B91 mov BX,word ptr ES:[0x09ED]
11B8:1B96 add BX,word ptr SS:[BP-16]
11B8:1B99 mov ES,word ptr DS:[0x5622]
11B8:1B9D mov AL,byte ptr ES:[BX+0x07AD]
11B8:1BA2 sub AH,AH
11B8:1BA4 mov word ptr SS:[BP-24],AX
11B8:1BA7 mov word ptr SS:[BP-2],1
11B8:1BAC cmp word ptr SS:[BP-26],2
11B8:1BB0 je short 0x1BDD
11B8:1BB2 cmp AX,0x0040
11B8:1BB5 jge short 0x1BDD
11B8:1BB7 and AX,0x00F0
11B8:1BBA mov word ptr SS:[BP-6],AX
11B8:1BBD mov AX,word ptr SS:[BP-40]
11B8:1BC0 and word ptr SS:[BP-24],AX
11B8:1BC3 je short 0x1BCA
11B8:1BC5 mov word ptr SS:[BP-2],2
11B8:1BCA cmp word ptr SS:[BP-6],0x0020
11B8:1BCE jne short 0x1BDD
11B8:1BD0 mov AX,word ptr SS:[BP-40]
11B8:1BD3 and word ptr SS:[BP-24],AX
11B8:1BD6 je short 0x1BDD
11B8:1BD8 mov word ptr SS:[BP-2],3
11B8:1BDD mov ES,word ptr DS:[0x561A]
11B8:1BE1 mov AX,word ptr SS:[BP-2]
11B8:1BE4 sub word ptr ES:[0x3770],AX
11B8:1BE9 jns short 0x1BF2
11B8:1BEB mov word ptr ES:[0x3770],0
11B8:1BF2 mov ES,word ptr DS:[0x561A]
11B8:1BF6 cmp word ptr ES:[0x3770],0
11B8:1BFC jle short 0x1C01
11B8:1BFE jmp near 0x1A95
11B8:1C01 cmp word ptr SS:[BP-12],0
11B8:1C05 jne short 0x1C0A
11B8:1C07 jmp near 0x19B6
11B8:1C0A mov AL,byte ptr SS:[BP-10]
11B8:1C0D mov BX,word ptr SS:[BP+6]
11B8:1C10 mov ES,word ptr DS:[0x55E4]
11B8:1C14 mov byte ptr ES:[BX+0x3920],AL
11B8:1C19 pop SI
11B8:1C1A pop DI
11B8:1C1B mov SP,BP
11B8:1C1D pop BP
11B8:1C1E ret far
11B8:1C1F push BP
11B8:1C20 mov BP,SP
11B8:1C22 mov AX,0x0036
11B8:1C25 call far 19FC:2FDC
11B8:2231 push BP
11B8:2232 mov BP,SP
11B8:2234 mov AX,4
11B8:2237 call far 19FC:2FDC
11B8:22BC push BP
11B8:22BD mov BP,SP
11B8:22BF mov AX,6
11B8:22C2 call far 19FC:2FDC
11B8:22C7 push SI
11B8:22C8 mov ES,word ptr DS:[0x5624]
11B8:22CC sub AX,AX
11B8:22CE mov word ptr ES:[0x4592],AX
11B8:22D2 mov ES,word ptr DS:[0x5626]
11B8:22D6 mov word ptr ES:[0x377C],AX
11B8:22DA mov AX,0x007D
11B8:22DD imul word ptr SS:[BP+6]
11B8:22E0 mov SI,AX
11B8:22E2 mov ES,word ptr DS:[0x55D4]
11B8:22E6 mov AL,byte ptr ES:[SI-14507]
11B8:22EB sub AH,AH
11B8:22ED mov ES,word ptr DS:[0x561A]
11B8:22F1 mov word ptr ES:[0x3770],AX
11B8:22F5 cmp word ptr SS:[BP+8],2
11B8:22F9 jne short 0x230F
11B8:22FB mov ES,word ptr DS:[0x55D4]
11B8:22FF mov AL,byte ptr ES:[SI-14506]
11B8:2304 mov ES,word ptr DS:[0x561A]
11B8:2308 mov word ptr ES:[0x3770],AX
11B8:230C jmp near 0x2442
11B8:230F mov AX,0x007D
11B8:2312 imul word ptr SS:[BP+6]
11B8:2315 mov SI,AX
11B8:2317 mov ES,word ptr DS:[0x55D4]
11B8:231B mov AL,byte ptr ES:[SI-14520]
11B8:2320 sub AH,AH
11B8:2322 mov word ptr SS:[BP-2],AX
11B8:2325 mov AL,byte ptr ES:[SI-14519]
11B8:232A mov word ptr SS:[BP-6],AX
11B8:232D mov AL,byte ptr SS:[BP-2]
11B8:2330 or AL,byte ptr SS:[BP-6]
11B8:2333 test AL,8
11B8:2335 jne short 0x2350
11B8:2337 mov ES,word ptr DS:[0x561A]
11B8:233B mov word ptr ES:[0x3770],1
11B8:2342 mov ES,word ptr DS:[0x5626]
11B8:2346 mov word ptr ES:[0x377C],1
11B8:234D jmp near 0x23F2
11B8:2350 test byte ptr SS:[BP-2],8
11B8:2354 je short 0x235C
11B8:2356 test byte ptr SS:[BP-6],8
11B8:235A jne short 0x238D
11B8:235C mov ES,word ptr DS:[0x561A]
11B8:2360 sar word ptr ES:[0x3770],1
11B8:2365 mov AX,0x007D
11B8:2368 imul word ptr SS:[BP+6]
11B8:236B mov BX,AX
11B8:236D mov ES,word ptr DS:[0x55D4]
11B8:2371 test byte ptr ES:[BX-14507],1
11B8:2377 je short 0x2382
11B8:2379 mov ES,word ptr DS:[0x561A]
11B8:237D inc word ptr ES:[0x3770]
11B8:2382 mov ES,word ptr DS:[0x5626]
11B8:2386 mov word ptr ES:[0x377C],1
11B8:238D mov word ptr SS:[BP-4],4
11B8:2392 mov AX,word ptr SS:[BP-4]
11B8:2395 and word ptr SS:[BP-2],AX
11B8:2398 jne short 0x23AE
11B8:239A mov ES,word ptr DS:[0x561A]
11B8:239E dec word ptr ES:[0x3770]
11B8:23A3 mov ES,word ptr DS:[0x5626]
11B8:23A7 mov word ptr ES:[0x377C],1
11B8:23AE mov AX,word ptr SS:[BP-4]
11B8:23B1 and word ptr SS:[BP-6],AX
11B8:23B4 jne short 0x23CA
11B8:23B6 mov ES,word ptr DS:[0x561A]
11B8:23BA dec word ptr ES:[0x3770]
11B8:23BF mov ES,word ptr DS:[0x5626]
11B8:23C3 mov word ptr ES:[0x377C],1
11B8:23CA mov ES,word ptr DS:[0x5626]
11B8:23CE cmp word ptr ES:[0x377C],0
11B8:23D4 je short 0x23E9
11B8:23D6 mov ES,word ptr DS:[0x561A]
11B8:23DA cmp word ptr ES:[0x3770],0
11B8:23E0 jne short 0x23E9
11B8:23E2 mov word ptr ES:[0x3770],1
11B8:23E9 sar word ptr SS:[BP-4],1
11B8:23EC cmp word ptr SS:[BP-4],0
11B8:23F0 jg short 0x2392
11B8:23F2 mov BX,word ptr SS:[BP+6]
11B8:23F5 mov ES,word ptr DS:[0x55EA]
11B8:23F9 mov AL,byte ptr ES:[BX+0x006E]
11B8:23FE cbw
11B8:23FF mov CL,5
11B8:2401 idiv CL
11B8:2403 cbw
11B8:2404 mov ES,word ptr DS:[0x5624]
11B8:2408 mov word ptr ES:[0x4592],AX
11B8:240C mov ES,word ptr DS:[0x561A]
11B8:2410 sub word ptr ES:[0x3770],AX
11B8:2415 cmp word ptr SS:[BP+8],1
11B8:2419 jne short 0x2442
11B8:241B mov AX,word ptr ES:[0x3770]
11B8:241F sar AX,1
11B8:2421 add word ptr ES:[0x3770],AX
11B8:2426 mov AX,0x007D
11B8:2429 imul BX
11B8:242B mov BX,AX
11B8:242D mov ES,word ptr DS:[0x55D4]
11B8:2431 test byte ptr ES:[BX-14507],1
11B8:2437 je short 0x2442
11B8:2439 mov ES,word ptr DS:[0x561A]
11B8:243D inc word ptr ES:[0x3770]
11B8:2442 mov BX,word ptr SS:[BP+6]
11B8:2445 mov ES,word ptr DS:[0x55EA]
11B8:2449 cmp byte ptr ES:[BX+0x006E],0x1E
11B8:244F jne short 0x245C
11B8:2451 mov ES,word ptr DS:[0x561A]
11B8:2455 mov word ptr ES:[0x3770],0
11B8:245C mov ES,word ptr DS:[0x561A]
11B8:2460 cmp word ptr ES:[0x3770],0
11B8:2466 jge short 0x246F
11B8:2468 mov word ptr ES:[0x3770],0
11B8:246F pop SI
11B8:2470 mov SP,BP
11B8:2472 pop BP
11B8:2473 ret far
11B8:2474 push BP
11B8:2475 mov BP,SP
11B8:2477 xor AX,AX
11B8:2479 call far 19FC:2FDC
11B8:247E mov ES,word ptr DS:[0x561A]
11B8:2482 mov word ptr ES:[0x3770],6
11B8:2489 cmp word ptr SS:[BP+6],0x000C
11B8:248D jge short 0x24DB
11B8:248F sub word ptr SS:[BP+6],4
11B8:2493 mov AX,0x0011
11B8:2496 imul word ptr SS:[BP+6]
11B8:2499 mov BX,AX
11B8:249B mov ES,word ptr DS:[0x55D4]
11B8:249F mov AL,3
11B8:24A1 imul byte ptr ES:[BX-14826]
11B8:24A6 sar AX,1
11B8:24A8 sar AX,1
11B8:24AA mov ES,word ptr DS:[0x561A]
11B8:24AE mov word ptr ES:[0x3770],AX
11B8:24B2 cmp AX,3
11B8:24B5 jge short 0x24BE
11B8:24B7 mov word ptr ES:[0x3770],3
11B8:24BE mov AX,0x0011
11B8:24C1 imul word ptr SS:[BP+6]
11B8:24C4 mov BX,AX
11B8:24C6 mov ES,word ptr DS:[0x55D4]
11B8:24CA cmp byte ptr ES:[BX-14815],1
11B8:24D0 jle short 0x24DB
11B8:24D2 mov ES,word ptr DS:[0x561A]
11B8:24D6 sar word ptr ES:[0x3770],1
11B8:24DB mov ES,word ptr DS:[0x561A]
11B8:24DF cmp word ptr ES:[0x3770],8
11B8:24E5 jle short 0x24EE
11B8:24E7 mov word ptr ES:[0x3770],8
11B8:24EE pop BP
11B8:24EF ret far
11B8:24F0 push BP
11B8:24F1 mov BP,SP
11B8:24F3 mov AX,2
11B8:24F6 call far 19FC:2FDC
11B8:24FB mov AX,3
11B8:24FE push AX
11B8:24FF call far 17D3:0281
11B8:2504 add SP,2
11B8:2507 call far 17D3:0388
11B8:250C mov AX,0x3D3A
11B8:250F push DS
11B8:2510 push AX
11B8:2511 call far 17D3:03F5
11B8:2516 add SP,4
11B8:2519 mov ES,word ptr DS:[0x560C]
11B8:251D mov word ptr ES:[0x00C2],2
11B8:2524 mov word ptr ES:[0x00C6],3
11B8:252B mov ES,word ptr DS:[0x55F4]
11B8:252F mov AX,word ptr ES:[0x2E38]
11B8:2533 mov ES,word ptr DS:[0x560C]
11B8:2537 mov word ptr ES:[0x00C8],AX
11B8:253B mov AX,3
11B8:253E push AX
11B8:253F call far 17D3:0B5E
11B8:2544 mov word ptr SS:[BP-2],AX
11B8:2547 mov ES,word ptr DS:[0x560C]
11B8:254B mov word ptr ES:[0x00C2],0
11B8:2552 mov SP,BP
11B8:2554 pop BP
11B8:2555 ret far
11B8:2556 push BP
11B8:2557 mov BP,SP
11B8:2559 mov AX,2
11B8:255C call far 19FC:2FDC
11B8:2561 mov AX,3
11B8:2564 push AX
11B8:2565 call far 17D3:0281
11B8:256A add SP,2
11B8:256D call far 17D3:0388
11B8:2572 mov AX,0x3D5E
11B8:2575 push DS
11B8:2576 push AX
11B8:2577 call far 17D3:03F5
11B8:257C add SP,4
11B8:257F mov ES,word ptr DS:[0x55F6]
11B8:2583 push word ptr ES:[0x2E3A]
11B8:2588 call far 017D:1A13
11B8:258D mov SP,BP
11B8:258F pop BP
11B8:2590 ret far
11B8:2591 push BP
11B8:2592 mov BP,SP
11B8:2594 mov AX,0x000C
11B8:2597 call far 19FC:2FDC
11B8:2835 push BP
11B8:2836 mov BP,SP
11B8:2838 mov AX,6
11B8:283B call far 19FC:2FDC
11B8:2840 push DI
11B8:2841 push SI
11B8:2842 mov ES,word ptr DS:[0x55CC]
11B8:2846 mov AX,word ptr ES:[0xA44B]
11B8:284A mov ES,word ptr DS:[0x55CE]
11B8:284E or AX,word ptr ES:[0xA44D]
11B8:2853 mov CL,8
11B8:2855 shr AX,CL
11B8:2857 mov word ptr SS:[BP-2],AX
11B8:285A mov byte ptr SS:[BP-1],0
11B8:285E sub word ptr SS:[BP-2],0x0011
11B8:2862 mov word ptr SS:[BP-6],0
11B8:2867 mov word ptr SS:[BP-4],0
11B8:286C mov SI,word ptr SS:[BP-2]
11B8:286F add SI,word ptr SS:[BP-4]
11B8:2872 js short 0x28BA
11B8:2874 cmp SI,0x0100
11B8:2878 jge short 0x28BA
11B8:287A mov ES,word ptr DS:[0x5604]
11B8:287E cmp byte ptr ES:[SI+0x0030],0
11B8:2884 je short 0x28BA
11B8:2886 mov AX,3
11B8:2889 imul word ptr SS:[BP-6]
11B8:288C mov DI,AX
11B8:288E add DI,word ptr SS:[BP-4]
11B8:2891 mov BX,DI
11B8:2893 shl BX,1
11B8:2895 shl BX,1
11B8:2897 mov ES,word ptr DS:[0x5628]
11B8:289B les BX,word ptr ES:[BX+0x0170]
11B8:28A0 cmp byte ptr ES:[BX],0x90
11B8:28A4 je short 0x28BA
11B8:28A6 mov ES,word ptr DS:[0x5604]
11B8:28AA mov AL,byte ptr ES:[SI+0x0030]
11B8:28AF cbw
11B8:28B0 push AX
11B8:28B1 push DI
11B8:28B2 call far 017D:2DA8
11B8:28BA inc word ptr SS:[BP-4]
11B8:28BD cmp word ptr SS:[BP-4],3
11B8:28C1 jl short 0x286C
11B8:28C3 add word ptr SS:[BP-2],0x0010
11B8:28C7 inc word ptr SS:[BP-6]
11B8:28CA cmp word ptr SS:[BP-6],3
11B8:28CE jl short 0x2867
11B8:28D0 call far 19FC:1DA8
11B8:28D5 pop SI
11B8:28D6 pop DI
11B8:28D7 mov SP,BP
11B8:28D9 pop BP
11B8:28DA ret far
11B8:28DB push BP
11B8:28DC mov BP,SP
11B8:28DE mov AX,0x0014
11B8:28E1 call far 19FC:2FDC
11B8:28E6 push SI
11B8:28E7 mov ES,word ptr DS:[0x55CC]
11B8:28EB mov AX,word ptr ES:[0xA44B]
11B8:28EF mov word ptr SS:[BP-18],AX
11B8:28F2 mov ES,word ptr DS:[0x55CE]
11B8:28F6 mov AX,word ptr ES:[0xA44D]
11B8:28FA mov word ptr SS:[BP-20],AX
11B8:28FD mov ES,word ptr DS:[0x55D2]
11B8:2901 mov AX,word ptr ES:[0x400C]
11B8:2905 mov word ptr SS:[BP-4],AX
11B8:2908 mov ES,word ptr DS:[0x55D6]
11B8:290C mov AX,word ptr ES:[0x403E]
11B8:2910 mov word ptr SS:[BP-6],AX
11B8:2913 mov ES,word ptr DS:[0x55D4]
11B8:2917 cmp byte ptr ES:[0xC620],8
11B8:291D je short 0x2943
11B8:291F mov AL,byte ptr ES:[0xC620]
11B8:2923 cbw
11B8:2924 mov word ptr SS:[BP-6],AX
11B8:2927 mov SI,AX
11B8:2929 shl SI,1
11B8:292B mov ES,word ptr DS:[0x55D2]
11B8:292F mov AX,word ptr ES:[SI+0x4004]
11B8:2934 mov word ptr SS:[BP-4],AX
11B8:2937 mov ES,word ptr DS:[0x55D6]
11B8:293B mov AX,word ptr ES:[SI+0x4036]
11B8:2940 mov word ptr SS:[BP-6],AX
11B8:2943 push word ptr SS:[BP-6]
11B8:2946 push word ptr SS:[BP-4]
11B8:2949 call far 017D:17BB
11B8:294E add SP,4
11B8:2951 mov ES,word ptr DS:[0x55CE]
11B8:2955 push word ptr ES:[0xA44D]
11B8:295A mov ES,word ptr DS:[0x55CC]
11B8:295E push word ptr ES:[0xA44B]
11B8:2963 call far 19FC:1314
11B8:2968 add SP,4
11B8:296B call far 19FC:1DF8
11B8:2970 mov ES,word ptr DS:[0x55CC]
11B8:2974 mov AX,word ptr ES:[0xA44B]
11B8:2978 mov ES,word ptr DS:[0x5614]
11B8:297C mov word ptr ES:[0xE486],AX
11B8:2980 mov ES,word ptr DS:[0x55CE]
11B8:2984 mov AX,word ptr ES:[0xA44D]
11B8:2988 mov ES,word ptr DS:[0x5616]
11B8:298C mov word ptr ES:[0xE488],AX
11B8:2990 mov word ptr SS:[BP-2],0
11B8:2995 mov word ptr SS:[BP-8],0x001A
11B8:299A mov word ptr SS:[BP-10],0x000C
11B8:299F mov word ptr SS:[BP-16],0x000C
11B8:29A4 cmp word ptr SS:[BP-2],0
11B8:29A8 jne short 0x29D8
11B8:29AA mov SI,word ptr SS:[BP-16]
11B8:29AD shl SI,1
11B8:29AF mov ES,word ptr DS:[0x55E0]
11B8:29B3 cmp word ptr ES:[SI+0x406A],0
11B8:29B9 je short 0x29D8
11B8:29BB mov ES,word ptr DS:[0x55D2]
11B8:29BF mov AX,word ptr ES:[SI+0x4004]
11B8:29C4 mov word ptr SS:[BP-12],AX
11B8:29C7 mov ES,word ptr DS:[0x55D6]
11B8:29CB mov AX,word ptr ES:[SI+0x4036]
11B8:29D0 mov word ptr SS:[BP-14],AX
11B8:29D3 mov word ptr SS:[BP-2],1
11B8:29D8 inc word ptr SS:[BP-16]
11B8:29DB cmp word ptr SS:[BP-16],0x0018
11B8:29DF jl short 0x29A4
11B8:29E1 mov ES,word ptr DS:[0x561A]
11B8:29E5 mov word ptr ES:[0x3770],0x001E
11B8:29EC cmp word ptr SS:[BP-2],0
11B8:29F0 jne short 0x29F5
11B8:29F2 jmp near 0x2A8E
11B8:29F5 mov word ptr SS:[BP-2],0
11B8:29FA jmp near 0x2A7F
11B8:29FD mov ES,word ptr DS:[0x5614]
11B8:2A01 mov AX,word ptr SS:[BP-12]
11B8:2A04 cmp word ptr ES:[0xE486],AX
11B8:2A09 jne short 0x2A19
11B8:2A0B mov ES,word ptr DS:[0x5616]
11B8:2A0F mov AX,word ptr SS:[BP-14]
11B8:2A12 cmp word ptr ES:[0xE488],AX
11B8:2A17 je short 0x2A8E
11B8:2A19 sub AX,AX
11B8:2A1B push AX
11B8:2A1C push word ptr SS:[BP-10]
11B8:2A1F push word ptr SS:[BP-8]
11B8:2A22 push word ptr SS:[BP-14]
11B8:2A25 push word ptr SS:[BP-12]
11B8:2A28 mov AX,0x0080
11B8:2A2B push AX
11B8:2A2C call far 0FAE:0006
11B8:2A31 add SP,0x000C
11B8:2A34 mov ES,word ptr DS:[0x561C]
11B8:2A38 mov AX,word ptr ES:[0x458E]
11B8:2A3C add word ptr SS:[BP-8],AX
11B8:2A3F mov ES,word ptr DS:[0x561E]
11B8:2A43 mov AX,word ptr ES:[0x4590]
11B8:2A47 add word ptr SS:[BP-10],AX
11B8:2A4A mov ES,word ptr DS:[0x561A]
11B8:2A4E dec word ptr ES:[0x3770]
11B8:2A53 mov ES,word ptr DS:[0x5614]
11B8:2A57 mov AX,word ptr SS:[BP-12]
11B8:2A5A cmp word ptr ES:[0xE486],AX
11B8:2A5F jne short 0x2A7F
11B8:2A61 mov ES,word ptr DS:[0x5616]
11B8:2A65 mov AX,word ptr SS:[BP-14]
11B8:2A68 cmp word ptr ES:[0xE488],AX
11B8:2A6D jne short 0x2A7F
11B8:2A6F mov ES,word ptr DS:[0x561A]
11B8:2A73 mov word ptr ES:[0x3770],0
11B8:2A7A mov word ptr SS:[BP-2],1
11B8:2A7F mov ES,word ptr DS:[0x561A]
11B8:2A83 cmp word ptr ES:[0x3770],0
11B8:2A89 jle short 0x2A8E
11B8:2A8B jmp near 0x29FD
11B8:2A8E push word ptr SS:[BP-20]
11B8:2A91 push word ptr SS:[BP-18]
11B8:2A94 push CS
11B8:2A95 call near 0x2AA3
11B8:2A98 add SP,4
11B8:2A9B mov AX,word ptr SS:[BP-2]
11B8:2A9E pop SI
11B8:2A9F mov SP,BP
11B8:2AA1 pop BP
11B8:2AA2 ret far
11B8:2AA3 push BP
11B8:2AA4 mov BP,SP
11B8:2AA6 xor AX,AX
11B8:2AA8 call far 19FC:2FDC
11B8:2AAD push word ptr SS:[BP+8]
11B8:2AB0 push word ptr SS:[BP+6]
11B8:2AB3 call far 017D:17BB
11B8:2AB8 add SP,4
11B8:2ABB mov ES,word ptr DS:[0x55CE]
11B8:2ABF push word ptr ES:[0xA44D]
11B8:2AC4 mov ES,word ptr DS:[0x55CC]
11B8:2AC8 push word ptr ES:[0xA44B]
11B8:2ACD call far 19FC:1314
11B8:2AD2 add SP,4
11B8:2AD5 call far 19FC:1DF8
11B8:2ADA pop BP
11B8:2ADB ret far
1465:000C push BP
1465:000D mov BP,SP
1465:000F mov AX,0x0080
1465:0012 call far 19FC:2FDC
1465:0017 push DI
1465:0018 push SI
1465:0019 mov ES,word ptr DS:[0x562A]
1465:001D mov AX,word ptr ES:[0xA44B]
1465:0021 mov word ptr SS:[BP-62],AX
1465:0024 mov ES,word ptr DS:[0x562C]
1465:0028 mov AX,word ptr ES:[0xA44D]
1465:002C mov word ptr SS:[BP-74],AX
1465:002F mov word ptr SS:[BP-2],0
1465:0034 mov SI,word ptr SS:[BP-2]
1465:0037 sub AL,AL
1465:0039 mov byte ptr SS:[BP+SI-120],AL
1465:003C mov BX,word ptr SS:[BP-2]
1465:003F mov ES,word ptr DS:[0x562E]
1465:0043 mov byte ptr ES:[BX+0x0078],AL
1465:0048 inc word ptr SS:[BP-2]
1465:004B cmp word ptr SS:[BP-2],0x0018
1465:004F jl short 0x0034
1465:0051 mov word ptr SS:[BP-4],0
1465:0056 jmp near 0x0FF9
1465:0059 cmp word ptr SS:[BP-66],0x000B
1465:005D jne short 0x00AC
1465:005F mov AX,word ptr SS:[BP-2]
1465:0062 mov word ptr SS:[BP-72],AX
1465:0065 cmp AX,0x000C
1465:0068 jl short 0x0070
1465:006A sub AX,8
1465:006D mov word ptr SS:[BP-72],AX
1465:0070 mov AX,0x007D
1465:0073 imul word ptr SS:[BP-72]
1465:0076 mov SI,AX
1465:0078 mov ES,word ptr DS:[0x5648]
1465:007C test byte ptr ES:[SI-14520],8
1465:0082 je short 0x0093
1465:0084 test byte ptr ES:[SI-14519],8
1465:008A je short 0x0093
1465:008C mov word ptr SS:[BP-72],0x0020
1465:0091 jmp short 0x00E9
1465:0093 mov word ptr SS:[BP-72],0x0080
1465:0098 mov AX,0x000C
1465:009B imul word ptr SS:[BP-2]
1465:009E mov BX,AX
1465:00A0 mov ES,word ptr DS:[0x564E]
1465:00A4 mov byte ptr ES:[BX+0x380B],0xFF
1465:00AA jmp short 0x00E9
1465:00AC cmp word ptr SS:[BP-2],4
1465:00B0 jge short 0x00BA
1465:00B2 push word ptr SS:[BP-66]
1465:00B5 push word ptr SS:[BP-2]
1465:00B8 jmp short 0x00C4
1465:00BA push word ptr SS:[BP-66]
1465:00BD mov AX,word ptr SS:[BP-2]
1465:00C0 sub AX,8
1465:00C3 push AX
1465:00C4 call far 0FAE:10A2
1465:00E9 test byte ptr SS:[BP-72],0x80
1465:00ED je short 0x00F2
1465:00EF jmp near 0x0DC4
1465:00F2 mov BX,word ptr SS:[BP-40]
1465:00F5 shl BX,1
1465:00F7 mov ES,word ptr DS:[0x5632]
1465:00FB cmp word ptr ES:[BX+0x406A],0
1465:0101 jne short 0x0106
1465:0103 jmp near 0x0DAF
1465:0106 push word ptr SS:[BP-72]
1465:0109 push word ptr SS:[BP-40]
1465:010C call far 0FAE:0F24
1465:0111 add SP,4
1465:0114 mov word ptr SS:[BP-92],AX
1465:0117 cmp AX,3
1465:011A jl short 0x011F
1465:011C jmp near 0x0DC4
1465:011F mov SI,word ptr SS:[BP-40]
1465:0122 shl SI,1
1465:0124 mov ES,word ptr DS:[0x5636]
1465:0128 push word ptr ES:[SI+0x4036]
1465:012D mov ES,word ptr DS:[0x5638]
1465:0131 push word ptr ES:[SI+0x4004]
1465:0136 mov ES,word ptr DS:[0x562C]
1465:013A push word ptr ES:[0xA44D]
1465:013F mov ES,word ptr DS:[0x562A]
1465:0143 push word ptr ES:[0xA44B]
1465:0148 call far 19FC:0971
1465:014D add SP,8
1465:0150 mov word ptr SS:[BP-96],AX
1465:0153 cmp AX,0xFFFF
1465:0156 jne short 0x015D
1465:0158 mov word ptr SS:[BP-96],0
1465:015D mov AX,word ptr SS:[BP-96]
1465:0160 mov word ptr SS:[BP-88],AX
1465:0163 mov ES,word ptr DS:[0x562A]
1465:0167 mov AX,word ptr SS:[BP-42]
1465:016A mov word ptr ES:[0xA44B],AX
1465:016E mov ES,word ptr DS:[0x562C]
1465:0172 mov AX,word ptr SS:[BP-54]
1465:0175 mov word ptr ES:[0xA44D],AX
1465:0179 mov SI,word ptr SS:[BP-2]
1465:017C shl SI,1
1465:017E mov ES,word ptr DS:[0x5636]
1465:0182 push word ptr ES:[SI+0x4036]
1465:0187 mov ES,word ptr DS:[0x5638]
1465:018B push word ptr ES:[SI+0x4004]
1465:0190 call far 017D:17BB
1465:0195 add SP,4
1465:0198 mov SI,word ptr SS:[BP-40]
1465:019B shl SI,1
1465:019D mov ES,word ptr DS:[0x5636]
1465:01A1 push word ptr ES:[SI+0x4036]
1465:01A6 mov ES,word ptr DS:[0x5638]
1465:01AA push word ptr ES:[SI+0x4004]
1465:01AF push word ptr SS:[BP-40]
1465:01B2 push word ptr SS:[BP-2]
1465:01B5 call far 0FAE:1BFE
1465:01BA add SP,8
1465:01BD or AX,AX
1465:01BF jne short 0x01C4
1465:01C1 jmp near 0x0D9F
1465:01C4 cmp word ptr SS:[BP-2],4
1465:01C8 jl short 0x0239
1465:01CA cmp word ptr SS:[BP-2],0x000C
1465:01CE jge short 0x0239
1465:01D0 mov AX,0x0011
1465:01D3 imul word ptr SS:[BP-72]
1465:01D6 mov BX,AX
1465:01D8 mov ES,word ptr DS:[0x5652]
1465:01DC mov AL,byte ptr ES:[BX+0x2EE8]
1465:01E1 sub AH,AH
1465:01E3 mov word ptr SS:[BP-34],AX
1465:01E6 mov BX,word ptr SS:[BP-2]
1465:01E9 mov ES,word ptr DS:[0x5648]
1465:01ED mov AL,byte ptr ES:[BX-11424]
1465:01F2 cbw
1465:01F3 cmp AX,word ptr SS:[BP-34]
1465:01F6 jne short 0x0221
1465:01F8 inc byte ptr ES:[BX-11432]
1465:01FD jne short 0x0239
1465:01FF mov AX,0x0011
1465:0202 imul word ptr SS:[BP-2]
1465:0205 add AX,word ptr SS:[BP-34]
1465:0208 add AX,0xC5D4
1465:020B mov word ptr SS:[BP-128],AX
1465:020E mov word ptr SS:[BP-126],0x2A0F
1465:0213 les BX,word ptr SS:[BP-128]
1465:0216 cmp byte ptr ES:[BX],4
1465:021A jge short 0x0239
1465:021C inc byte ptr ES:[BX]
1465:021F jmp short 0x0239
1465:0221 mov AL,byte ptr SS:[BP-34]
1465:0224 mov BX,word ptr SS:[BP-2]
1465:0227 mov ES,word ptr DS:[0x5648]
1465:022B mov byte ptr ES:[BX-11424],AL
1465:0230 mov BX,word ptr SS:[BP-2]
1465:0233 mov byte ptr ES:[BX-11432],0
1465:0239 cmp word ptr SS:[BP-2],4
1465:023D jge short 0x0265
1465:023F cmp word ptr SS:[BP-66],0x000B
1465:0243 jge short 0x0265
1465:0245 mov AX,0x007D
1465:0248 imul word ptr SS:[BP-2]
1465:024B add AX,word ptr SS:[BP-66]
1465:024E add AX,0xC74B
1465:0251 mov word ptr SS:[BP-128],AX
1465:0254 mov word ptr SS:[BP-126],0x2A0F
1465:0259 les BX,word ptr SS:[BP-128]
1465:025C cmp byte ptr ES:[BX],0xFF
1465:0260 je short 0x0265
1465:0262 dec byte ptr ES:[BX]
1465:0265 cmp word ptr SS:[BP-2],0x000C
1465:0269 jl short 0x0297
1465:026B cmp word ptr SS:[BP-2],0x0010
1465:026F jge short 0x0297
1465:0271 cmp word ptr SS:[BP-66],0x000B
1465:0275 jge short 0x0297
1465:0277 mov AX,0x007D
1465:027A imul word ptr SS:[BP-2]
1465:027D add AX,word ptr SS:[BP-66]
1465:0280 add AX,0xC363
1465:0283 mov word ptr SS:[BP-128],AX
1465:0286 mov word ptr SS:[BP-126],0x2A0F
1465:028B les BX,word ptr SS:[BP-128]
1465:028E cmp byte ptr ES:[BX],0xFF
1465:0292 je short 0x0297
1465:0294 dec byte ptr ES:[BX]
1465:0297 mov AX,word ptr SS:[BP-92]
1465:029A shl AX,1
1465:029C add AX,4
1465:029F mov word ptr SS:[BP-48],AX
1465:02A2 cmp word ptr SS:[BP-72],0x0020
1465:02A6 jne short 0x02E0
1465:02A8 mov word ptr SS:[BP-48],3
1465:02AD mov AX,word ptr SS:[BP-2]
1465:02B0 mov word ptr SS:[BP-122],AX
1465:02B3 cmp AX,0x000C
1465:02B6 jl short 0x02BC
1465:02B8 sub word ptr SS:[BP-122],8
1465:02BC mov AX,0x0024
1465:02BF push AX
1465:02C0 push word ptr SS:[BP-2]
1465:02C3 call far 0FAE:1B44
1465:02E0 mov AX,0x0030
1465:02E3 imul word ptr SS:[BP-2]
1465:02E6 mov BX,AX
1465:02E8 mov ES,word ptr DS:[0x5654]
1465:02EC mov AL,byte ptr ES:[BX+0x32C6]
1465:02F1 cbw
1465:02F2 inc AX
1465:02F3 add word ptr SS:[BP-48],AX
1465:02F6 mov SI,word ptr SS:[BP-40]
1465:02F9 mov AL,byte ptr SS:[BP+SI-120]
1465:02FC cbw
1465:02FD mov BX,AX
1465:02FF mov ES,word ptr DS:[0x5656]
1465:0303 mov AL,byte ptr ES:[BX+0x2D1A]
1465:0308 cbw
1465:0309 add word ptr SS:[BP-48],AX
1465:030C cmp word ptr SS:[BP-2],4
1465:0310 jl short 0x0321
1465:0312 cmp word ptr SS:[BP-2],0x000C
1465:0316 jge short 0x0321
1465:0318 mov AX,word ptr SS:[BP-2]
1465:031B sub AX,4
1465:031E mov word ptr SS:[BP-38],AX
1465:0321 cmp word ptr SS:[BP-2],0x0010
1465:0325 jl short 0x0330
1465:0327 mov AX,word ptr SS:[BP-2]
1465:032A sub AX,8
1465:032D mov word ptr SS:[BP-38],AX
1465:0330 cmp word ptr SS:[BP-2],4
1465:0334 jge short 0x03A9
1465:0336 mov AX,0x007D
1465:0339 imul word ptr SS:[BP-2]
1465:033C mov SI,AX
1465:033E mov ES,word ptr DS:[0x5648]
1465:0342 mov AL,byte ptr ES:[SI-14435]
1465:0347 sub AH,AH
1465:0349 mov word ptr SS:[BP-38],AX
1465:034C cmp byte ptr ES:[SI-14437],AH
1465:0351 je short 0x0357
1465:0353 add word ptr SS:[BP-48],2
1465:0357 mov AX,0x0011
1465:035A imul word ptr SS:[BP-72]
1465:035D mov BX,AX
1465:035F mov ES,word ptr DS:[0x5652]
1465:0363 mov AL,byte ptr ES:[BX+0x2EE5]
1465:0368 and AL,0x0F
1465:036A mov BX,word ptr SS:[BP-2]
1465:036D mov ES,word ptr DS:[0x5658]
1465:0371 add byte ptr ES:[BX+0x0092],AL
1465:0376 mov BX,word ptr SS:[BP-2]
1465:0379 mov ES,word ptr DS:[0x5650]
1465:037D cmp byte ptr ES:[BX+0x006E],8
1465:0383 jl short 0x03A9
1465:0385 inc word ptr SS:[BP-48]
1465:0388 cmp byte ptr ES:[BX+0x006E],0x0D
1465:038E jl short 0x0393
1465:0390 inc word ptr SS:[BP-48]
1465:0393 cmp byte ptr ES:[BX+0x006E],0x11
1465:0399 jl short 0x039E
1465:039B inc word ptr SS:[BP-48]
1465:039E cmp byte ptr ES:[BX+0x006E],0x18
1465:03A4 jl short 0x03A9
1465:03A6 inc word ptr SS:[BP-48]
1465:03A9 cmp word ptr SS:[BP-2],0x000C
1465:03AD jl short 0x0428
1465:03AF cmp word ptr SS:[BP-2],0x0010
1465:03B3 jge short 0x0428
1465:03B5 mov AX,0x007D
1465:03B8 imul word ptr SS:[BP-2]
1465:03BB mov SI,AX
1465:03BD mov ES,word ptr DS:[0x5648]
1465:03C1 mov AL,byte ptr ES:[SI-15435]
1465:03C6 sub AH,AH
1465:03C8 mov word ptr SS:[BP-38],AX
1465:03CB cmp byte ptr ES:[SI-15437],AH
1465:03D0 je short 0x03D6
1465:03D2 add word ptr SS:[BP-48],2
1465:03D6 mov AX,0x0011
1465:03D9 imul word ptr SS:[BP-72]
1465:03DC mov BX,AX
1465:03DE mov ES,word ptr DS:[0x5652]
1465:03E2 mov AL,byte ptr ES:[BX+0x2EE5]
1465:03E7 and AL,0x0F
1465:03E9 mov BX,word ptr SS:[BP-2]
1465:03EC mov ES,word ptr DS:[0x5658]
1465:03F0 add byte ptr ES:[BX+0x008A],AL
1465:03F5 mov BX,word ptr SS:[BP-2]
1465:03F8 mov ES,word ptr DS:[0x5650]
1465:03FC cmp byte ptr ES:[BX+0x0066],8
1465:0402 jl short 0x0428
1465:0404 inc word ptr SS:[BP-48]
1465:0407 cmp byte ptr ES:[BX+0x0066],0x0D
1465:040D jl short 0x0412
1465:040F inc word ptr SS:[BP-48]
1465:0412 cmp byte ptr ES:[BX+0x0066],0x11
1465:0418 jl short 0x041D
1465:041A inc word ptr SS:[BP-48]
1465:041D cmp byte ptr ES:[BX+0x0066],0x18
1465:0423 jl short 0x0428
1465:0425 inc word ptr SS:[BP-48]
1465:0428 mov ES,word ptr DS:[0x565A]
1465:042C cmp word ptr ES:[0x2E38],0
1465:0432 je short 0x0445
1465:0434 mov AX,4
1465:0437 push AX
1465:0438 call far 17D3:0281
1465:0445 mov ES,word ptr DS:[0x565C]
1465:0449 mov word ptr ES:[0x37FE],0x000F
1465:0450 cmp word ptr SS:[BP-2],0x000C
1465:0454 jl short 0x045D
1465:0456 mov word ptr ES:[0x37FE],0x000E
1465:045D cmp word ptr SS:[BP-2],0x000C
1465:0461 jl short 0x0466
1465:0463 jmp near 0x0519
1465:0466 mov ES,word ptr DS:[0x565A]
1465:046A cmp word ptr ES:[0x2E38],2
1465:0470 jne short 0x04A0
1465:0472 mov AX,0x0011
1465:0475 imul word ptr SS:[BP-38]
1465:0478 mov BX,AX
1465:047A mov ES,word ptr DS:[0x5648]
1465:047E mov AL,byte ptr ES:[BX-14828]
1465:0483 cbw
1465:0484 mov BX,AX
1465:0486 shl BX,1
1465:0488 shl BX,1
1465:048A mov ES,word ptr DS:[0x565E]
1465:048E push word ptr ES:[BX+0x01CC]
1465:0493 push word ptr ES:[BX+0x01CA]
1465:0498 call far 0FAE:1DAB
1465:04A0 cmp word ptr SS:[BP-2],4
1465:04A4 jge short 0x0505
1465:04A6 mov ES,word ptr DS:[0x565A]
1465:04AA cmp word ptr ES:[0x2E38],2
1465:04B0 jne short 0x04BF
1465:04B2 mov AX,0x3E44
1465:04B5 push DS
1465:04B6 push AX
1465:04B7 call far 0FAE:1DAB
1465:04BF cmp word ptr SS:[BP-72],0x0020
1465:04C3 jne short 0x04EF
1465:04C5 mov AX,0x3E4D
1465:04C8 push DS
1465:04C9 push AX
1465:04CA mov AX,0x0012
1465:04CD mov DX,0x2A0F
1465:04D0 push DX
1465:04D1 push AX
1465:04D2 call far 19FC:3B68
1465:04EF mov ES,word ptr DS:[0x565A]
1465:04F3 cmp word ptr ES:[0x2E38],2
1465:04F9 je short 0x04FE
1465:04FB jmp near 0x05BF
1465:04FE mov AX,0x3E58
1465:0501 push DS
1465:0502 jmp near 0x05B6
1465:0505 mov ES,word ptr DS:[0x565A]
1465:0509 cmp word ptr ES:[0x2E38],2
1465:050F je short 0x0514
1465:0511 jmp near 0x05BF
1465:0514 mov AX,0x3E60
1465:0517 jmp short 0x0501
1465:0519 mov ES,word ptr DS:[0x565A]
1465:051D cmp word ptr ES:[0x2E38],2
1465:0523 jne short 0x0532
1465:0525 mov AX,0x3E69
1465:0528 push DS
1465:0529 push AX
1465:052A call far 0FAE:1DAB
1465:0532 cmp word ptr SS:[BP-2],0x0010
1465:0536 jl short 0x0549
1465:0538 mov ES,word ptr DS:[0x565A]
1465:053C cmp word ptr ES:[0x2E38],2
1465:0542 jne short 0x05BF
1465:0544 mov AX,0x3E73
1465:0547 jmp short 0x0501
1465:0549 mov ES,word ptr DS:[0x565A]
1465:054D cmp word ptr ES:[0x2E38],2
1465:0553 jne short 0x0562
1465:0555 mov AX,0x3E81
1465:0558 push DS
1465:0559 push AX
1465:055A call far 0FAE:1DAB
1465:0562 cmp word ptr SS:[BP-72],0x0020
1465:0566 je short 0x0579
1465:0568 mov ES,word ptr DS:[0x565A]
1465:056C cmp word ptr ES:[0x2E38],2
1465:0572 jne short 0x05BF
1465:0574 mov AX,0x3E87
1465:0577 jmp short 0x0501
1465:0579 mov AX,0x3E8F
1465:057C push DS
1465:057D push AX
1465:057E mov AX,0x0012
1465:0581 mov DX,0x2A0F
1465:0584 push DX
1465:0585 push AX
1465:0586 call far 19FC:3B68
1465:05B6 push AX
1465:05B7 call far 0FAE:1DAB
1465:05BF cmp word ptr SS:[BP-72],0x0020
1465:05C3 je short 0x05DE
1465:05C5 mov AX,0x0011
1465:05C8 imul word ptr SS:[BP-72]
1465:05CB mov BX,AX
1465:05CD lea AX,BX+0x2ED8
1465:05D1 mov DX,0x3858
1465:05D4 push DX
1465:05D5 push AX
1465:05D6 call far 0FAE:1DAB
1465:05DE mov ES,word ptr DS:[0x565A]
1465:05E2 cmp word ptr ES:[0x2E38],2
1465:05E8 jne short 0x05F7
1465:05EA mov AX,0x3E9A
1465:05ED push DS
1465:05EE push AX
1465:05EF call far 0FAE:1DAB
1465:05F7 cmp word ptr SS:[BP-40],0x000C
1465:05FB jl short 0x0600
1465:05FD jmp near 0x06B9
1465:0600 cmp word ptr SS:[BP-40],4
1465:0604 jl short 0x063B
1465:0606 mov AX,0x0011
1465:0609 imul word ptr SS:[BP-40]
1465:060C mov BX,AX
1465:060E mov ES,word ptr DS:[0x5648]
1465:0612 mov AL,byte ptr ES:[BX-14896]
1465:0617 cbw
1465:0618 mov BX,AX
1465:061A shl BX,1
1465:061C shl BX,1
1465:061E mov ES,word ptr DS:[0x565E]
1465:0622 push word ptr ES:[BX+0x01CC]
1465:0627 push word ptr ES:[BX+0x01CA]
1465:062C mov AX,0x0012
1465:062F mov DX,0x2A0F
1465:0632 push DX
1465:0633 push AX
1465:0634 call far 19FC:3B68
1465:063B mov AX,0x007D
1465:063E imul word ptr SS:[BP-40]
1465:0641 mov BX,AX
1465:0643 mov ES,word ptr DS:[0x5648]
1465:0647 mov AL,0x11
1465:0649 mul byte ptr ES:[BX-14435]
1465:064E mov BX,AX
1465:0650 mov AL,byte ptr ES:[BX-14828]
1465:0655 cbw
1465:0656 mov BX,AX
1465:0658 shl BX,1
1465:065A shl BX,1
1465:065C mov ES,word ptr DS:[0x565E]
1465:0660 push word ptr ES:[BX+0x01CC]
1465:0665 push word ptr ES:[BX+0x01CA]
1465:066A mov AX,0x0012
1465:066D mov DX,0x2A0F
1465:0670 push DX
1465:0671 push AX
1465:0672 call far 19FC:3B68
1465:06B9 mov ES,word ptr DS:[0x565A]
1465:06BD cmp word ptr ES:[0x2E38],2
1465:06C3 jne short 0x071B
1465:06C5 mov ES,word ptr DS:[0x5660]
1465:06C9 cmp word ptr ES:[0xE48E],0
1465:06CF je short 0x06D7
1465:06D1 cmp word ptr SS:[BP-40],0x000D
1465:06D5 je short 0x06FC
1465:06D7 mov AX,0x3EA9
1465:06DA push DS
1465:06DB push AX
1465:06DC call far 0FAE:1DAB
1465:06FC mov ES,word ptr DS:[0x5660]
1465:0700 cmp word ptr ES:[0xE48E],0
1465:0706 je short 0x071B
1465:0708 cmp word ptr SS:[BP-40],0x000D
1465:070C jne short 0x071B
1465:070E mov AX,0x3EC0
1465:0711 push DS
1465:0712 push AX
1465:0713 call far 0FAE:1DAB
1465:071B mov AX,0x0011
1465:071E imul word ptr SS:[BP-72]
1465:0721 mov BX,AX
1465:0723 mov ES,word ptr DS:[0x5652]
1465:0727 mov BL,byte ptr ES:[BX+0x2EE8]
1465:072C sub BH,BH
1465:072E mov AX,0x0011
1465:0731 imul word ptr SS:[BP-38]
1465:0734 add BX,AX
1465:0736 mov ES,word ptr DS:[0x5648]
1465:073A mov AL,byte ptr ES:[BX-14824]
1465:073F cbw
1465:0740 sub word ptr SS:[BP-48],AX
1465:0743 cmp word ptr SS:[BP-40],4
1465:0747 jl short 0x074F
1465:0749 cmp word ptr SS:[BP-40],0x000C
1465:074D jl short 0x0758
1465:074F cmp word ptr SS:[BP-40],0x0010
1465:0753 jge short 0x0758
1465:0755 jmp near 0x091D
1465:0758 mov AX,word ptr SS:[BP-40]
1465:075B sub AX,4
1465:075E mov word ptr SS:[BP-12],AX
1465:0761 cmp AX,0x000C
1465:0764 jl short 0x076A
1465:0766 sub word ptr SS:[BP-12],4
1465:076A mov BX,word ptr SS:[BP-40]
1465:076D mov ES,word ptr DS:[0x5662]
1465:0771 mov AL,byte ptr ES:[BX+0x32AE]
1465:0776 cbw
1465:0777 sar AX,1
1465:0779 add word ptr SS:[BP-48],AX
1465:077C mov word ptr SS:[BP-124],0x007F
1465:0781 mov AX,0x0011
1465:0784 imul word ptr SS:[BP-72]
1465:0787 mov SI,AX
1465:0789 mov ES,word ptr DS:[0x5652]
1465:078D mov AL,byte ptr ES:[SI+0x2EE4]
1465:0792 sub AH,AH
1465:0794 mov word ptr SS:[BP-52],AX
1465:0797 test byte ptr SS:[BP-52],0x80
1465:079B je short 0x07CC
1465:079D mov AL,byte ptr ES:[SI+0x2EE3]
1465:07A2 mov word ptr SS:[BP-50],AX
1465:07A5 and AX,0x000F
1465:07A8 mov word ptr SS:[BP-124],AX
1465:07AB mov AX,word ptr SS:[BP-50]
1465:07AE mov CL,4
1465:07B0 sar AX,CL
1465:07B2 and AX,0x000F
1465:07B5 mov word ptr SS:[BP-50],AX
1465:07B8 jmp short 0x07C2
1465:07BA call far 017D:19F3
1465:07C2 mov AX,word ptr SS:[BP-50]
1465:07C5 dec word ptr SS:[BP-50]
1465:07C8 or AX,AX
1465:07CA jne short 0x07BA
1465:07CC and word ptr SS:[BP-52],0x007F
1465:07D0 cmp word ptr SS:[BP-124],0
1465:07D4 jne short 0x07D9
1465:07D6 inc word ptr SS:[BP-124]
1465:07D9 call far 017D:19DD
1465:091D mov BX,word ptr SS:[BP-40]
1465:0920 mov ES,word ptr DS:[0x5662]
1465:0924 mov AL,byte ptr ES:[BX+0x32AE]
1465:0929 cbw
1465:092A mov CL,3
1465:092C sar AX,CL
1465:092E add word ptr SS:[BP-48],AX
1465:0931 mov AX,BX
1465:0933 mov word ptr SS:[BP-12],AX
1465:0936 cmp AX,0x000C
1465:0939 jl short 0x093F
1465:093B sub word ptr SS:[BP-12],8
1465:093F mov ES,word ptr DS:[0x563C]
1465:0943 mov AL,byte ptr ES:[BX+0x396C]
1465:0948 cbw
1465:0949 mov word ptr SS:[BP-70],AX
1465:094C cmp AX,0xFFFF
1465:094F jne short 0x095E
1465:0951 mov ES,word ptr DS:[0x5666]
1465:0955 mov AL,byte ptr ES:[BX+0x45B6]
1465:095A cbw
1465:095B mov word ptr SS:[BP-70],AX
1465:095E mov BX,word ptr SS:[BP-70]
1465:0961 sub BX,word ptr SS:[BP-96]
1465:0964 mov ES,word ptr DS:[0x5668]
1465:0968 mov AL,byte ptr ES:[BX+0x2D11]
1465:096D cbw
1465:096E mov word ptr SS:[BP-84],AX
1465:0971 call far 017D:19DD
1465:0D9F push word ptr SS:[BP-54]
1465:0DA2 push word ptr SS:[BP-42]
1465:0DA5 call far 017D:17BB
1465:0DAA add SP,4
1465:0DAD jmp short 0x0DC4
1465:0DAF mov AX,0x000C
1465:0DB2 imul word ptr SS:[BP-2]
1465:0DB5 mov BX,AX
1465:0DB7 add BX,word ptr SS:[BP-66]
1465:0DBA mov ES,word ptr DS:[0x564E]
1465:0DBE mov byte ptr ES:[BX+0x3800],0xFF
1465:0DC4 mov ES,word ptr DS:[0x562A]
1465:0DC8 mov AX,word ptr SS:[BP-42]
1465:0DCB mov word ptr ES:[0xA44B],AX
1465:0DCF mov ES,word ptr DS:[0x562C]
1465:0DD3 mov AX,word ptr SS:[BP-54]
1465:0DD6 mov word ptr ES:[0xA44D],AX
1465:0DDA inc word ptr SS:[BP-66]
1465:0DDD cmp word ptr SS:[BP-66],0x000C
1465:0DE1 jl short 0x0DE6
1465:0DE3 jmp near 0x0ED5
1465:0DE6 mov ES,word ptr DS:[0x564A]
1465:0DEA sub AX,AX
1465:0DEC mov word ptr SS:[BP-58],AX
1465:0DEF mov word ptr SS:[BP-44],AX
1465:0DF2 mov word ptr SS:[BP-6],AX
1465:0DF5 mov word ptr ES:[0xE484],AX
1465:0DF9 mov ES,word ptr DS:[0x564C]
1465:0DFD mov word ptr ES:[0x4586],AX
1465:0E01 mov AX,0x000C
1465:0E04 imul word ptr SS:[BP-2]
1465:0E07 mov BX,AX
1465:0E09 add BX,word ptr SS:[BP-66]
1465:0E0C mov ES,word ptr DS:[0x564E]
1465:0E10 mov AL,byte ptr ES:[BX+0x3800]
1465:0E15 cbw
1465:0E16 mov word ptr SS:[BP-40],AX
1465:0E19 cmp word ptr SS:[BP-2],4
1465:0E1D jge short 0x0E33
1465:0E1F mov BX,word ptr SS:[BP-2]
1465:0E22 mov ES,word ptr DS:[0x5650]
1465:0E26 cmp byte ptr ES:[BX+0x006E],0x1E
1465:0E2C jl short 0x0E33
1465:0E2E mov word ptr SS:[BP-40],0xFFFF
1465:0E33 cmp word ptr SS:[BP-2],0x000C
1465:0E37 jl short 0x0E53
1465:0E39 cmp word ptr SS:[BP-2],0x0010
1465:0E3D jge short 0x0E53
1465:0E3F mov BX,word ptr SS:[BP-2]
1465:0E42 mov ES,word ptr DS:[0x5650]
1465:0E46 cmp byte ptr ES:[BX+0x0066],0x1E
1465:0E4C jl short 0x0E53
1465:0E4E mov word ptr SS:[BP-40],0xFFFF
1465:0E53 test byte ptr SS:[BP-40],0x80
1465:0E57 jne short 0x0DDA
1465:0E59 mov ES,word ptr DS:[0x562A]
1465:0E5D mov AX,word ptr ES:[0xA44B]
1465:0E61 mov word ptr SS:[BP-42],AX
1465:0E64 mov ES,word ptr DS:[0x562C]
1465:0E68 mov AX,word ptr ES:[0xA44D]
1465:0E6C mov word ptr SS:[BP-54],AX
1465:0E6F mov SI,word ptr SS:[BP-2]
1465:0E72 shl SI,1
1465:0E74 mov ES,word ptr DS:[0x5638]
1465:0E78 mov AX,word ptr ES:[SI+0x4004]
1465:0E7D mov ES,word ptr DS:[0x562A]
1465:0E81 mov word ptr ES:[0xA44B],AX
1465:0E85 mov ES,word ptr DS:[0x5636]
1465:0E89 mov AX,word ptr ES:[SI+0x4036]
1465:0E8E mov ES,word ptr DS:[0x562C]
1465:0E92 mov word ptr ES:[0xA44D],AX
1465:0E96 cmp word ptr SS:[BP-2],4
1465:0E9A jl short 0x0EA2
1465:0E9C cmp word ptr SS:[BP-2],0x000C
1465:0EA0 jl short 0x0EAB
1465:0EA2 cmp word ptr SS:[BP-2],0x0010
1465:0EA6 jge short 0x0EAB
1465:0EA8 jmp near 0x0059
1465:0EAB mov AX,0x0011
1465:0EAE imul word ptr SS:[BP-2]
1465:0EB1 mov SI,AX
1465:0EB3 mov ES,word ptr DS:[0x5648]
1465:0EB7 mov AL,byte ptr ES:[SI-14885]
1465:0EBC cbw
1465:0EBD mov word ptr SS:[BP-72],AX
1465:0EC0 cmp word ptr SS:[BP-2],0x0010
1465:0EC4 jge short 0x0EC9
1465:0EC6 jmp near 0x00E9
1465:0EC9 mov AL,byte ptr ES:[SI-14953]
1465:0ECE cbw
1465:0ECF mov word ptr SS:[BP-72],AX
1465:0ED2 jmp near 0x00E9
1465:0ED5 inc word ptr SS:[BP-2]
1465:0ED8 cmp word ptr SS:[BP-2],0x0018
1465:0EDC jge short 0x0F03
1465:0EDE mov ES,word ptr DS:[0x5630]
1465:0EE2 cmp word ptr ES:[0x014A],0
1465:0EE8 je short 0x0ED5
1465:0EEA mov BX,word ptr SS:[BP-2]
1465:0EED shl BX,1
1465:0EEF mov ES,word ptr DS:[0x5632]
1465:0EF3 cmp word ptr ES:[BX+0x406A],0
1465:0EF9 je short 0x0ED5
1465:0EFB mov word ptr SS:[BP-66],0
1465:0F00 jmp near 0x0DDD
1465:0F03 mov word ptr SS:[BP-90],0
1465:0F08 mov AX,0x0030
1465:0F0B imul word ptr SS:[BP-90]
1465:0F0E mov SI,AX
1465:0F10 mov ES,word ptr DS:[0x5654]
1465:0F14 cmp byte ptr ES:[SI+0x32C6],0xFF
1465:0F1A jne short 0x0F1F
1465:0F1C jmp near 0x0FEA
1465:0F1F mov DI,word ptr SS:[BP-90]
1465:0F22 shl DI,1
1465:0F24 mov ES,word ptr DS:[0x5638]
1465:0F28 mov AX,word ptr ES:[DI+0x4004]
1465:0F2D mov ES,word ptr DS:[0x5636]
1465:0F31 or AX,word ptr ES:[DI+0x4036]
1465:0F36 mov AL,AH
1465:0F38 sub AH,AH
1465:0F3A mov word ptr SS:[BP-80],AX
1465:0F3D mov ES,word ptr DS:[0x5638]
1465:0F41 mov AX,word ptr ES:[DI+0x4004]
1465:0F46 and AX,0x007F
1465:0F49 mov word ptr SS:[BP-10],AX
1465:0F4C mov ES,word ptr DS:[0x5636]
1465:0F50 mov AX,word ptr ES:[DI+0x4036]
1465:0F55 and AX,0x007F
1465:0F58 mov word ptr SS:[BP-18],AX
1465:0F5B mov ES,word ptr DS:[0x5654]
1465:0F5F mov AL,byte ptr ES:[SI+0x32C7]
1465:0F64 sub AH,AH
1465:0F66 cmp AX,word ptr SS:[BP-80]
1465:0F69 jne short 0x0FEA
1465:0F6B mov AL,byte ptr ES:[SI+0x32C8]
1465:0F70 cbw
1465:0F71 cmp AX,word ptr SS:[BP-10]
1465:0F74 jne short 0x0FEA
1465:0F76 mov AL,byte ptr ES:[SI+0x32C9]
1465:0F7B cbw
1465:0F7C cmp AX,word ptr SS:[BP-18]
1465:0F7F jne short 0x0FEA
1465:0F81 mov word ptr SS:[BP-94],0
1465:0F86 mov AX,0x0030
1465:0F89 imul word ptr SS:[BP-90]
1465:0F8C mov SI,AX
1465:0F8E mov DI,word ptr SS:[BP-94]
1465:0F91 add DI,SI
1465:0F93 mov AL,byte ptr ES:[DI+0x32CA]
1465:0F98 mov byte ptr ES:[DI+0x32C6],AL
1465:0F9D inc word ptr SS:[BP-94]
1465:0FA0 mov DI,word ptr SS:[BP-94]
1465:0FA3 add DI,SI
1465:0FA5 mov AL,byte ptr ES:[DI+0x32CA]
1465:0FAA mov byte ptr ES:[DI+0x32C6],AL
1465:0FAF inc word ptr SS:[BP-94]
1465:0FB2 mov DI,word ptr SS:[BP-94]
1465:0FB5 add DI,SI
1465:0FB7 mov AL,byte ptr ES:[DI+0x32CA]
1465:0FBC mov byte ptr ES:[DI+0x32C6],AL
1465:0FC1 inc word ptr SS:[BP-94]
1465:0FC4 mov DI,word ptr SS:[BP-94]
1465:0FC7 add DI,SI
1465:0FC9 mov AL,byte ptr ES:[DI+0x32CA]
1465:0FCE mov byte ptr ES:[DI+0x32C6],AL
1465:0FD3 inc word ptr SS:[BP-94]
1465:0FD6 cmp word ptr SS:[BP-94],0x002C
1465:0FDA jl short 0x0F86
1465:0FDC mov AX,0x0030
1465:0FDF imul word ptr SS:[BP-90]
1465:0FE2 mov BX,AX
1465:0FE4 mov byte ptr ES:[BX+0x32F2],0xFF
1465:0FEA inc word ptr SS:[BP-90]
1465:0FED cmp word ptr SS:[BP-90],0x000C
1465:0FF1 jge short 0x0FF6
1465:0FF3 jmp near 0x0F08
1465:0FF6 inc word ptr SS:[BP-4]
1465:0FF9 cmp word ptr SS:[BP-4],0x000C
1465:0FFD jl short 0x1002
1465:0FFF jmp near 0x128E
1465:1002 mov ES,word ptr DS:[0x5630]
1465:1006 cmp word ptr ES:[0x014A],0
1465:100C je short 0x0FF6
1465:100E mov word ptr SS:[BP-68],0
1465:1013 cmp word ptr SS:[BP-4],0
1465:1017 jne short 0x101E
1465:1019 mov word ptr SS:[BP-68],1
1465:101E mov word ptr SS:[BP-2],0
1465:1023 mov SI,word ptr SS:[BP-2]
1465:1026 shl SI,1
1465:1028 mov ES,word ptr DS:[0x5632]
1465:102C cmp word ptr ES:[SI+0x406A],0
1465:1032 jne short 0x1037
1465:1034 jmp near 0x11D3
1465:1037 mov BX,word ptr SS:[BP-2]
1465:103A mov ES,word ptr DS:[0x562E]
1465:103E mov AL,byte ptr ES:[BX+0x0078]
1465:1043 cbw
1465:1044 mov word ptr SS:[BP-32],AX
1465:1047 mov DI,AX
1465:1049 shl DI,1
1465:104B mov AX,0x0018
1465:104E imul BX
1465:1050 add DI,AX
1465:1052 mov ES,word ptr DS:[0x5634]
1465:1056 mov AL,byte ptr ES:[DI+0x40B4]
1465:105B cbw
1465:105C mov word ptr SS:[BP-14],AX
1465:105F mov AL,byte ptr ES:[DI+0x40B5]
1465:1064 cbw
1465:1065 mov word ptr SS:[BP-20],AX
1465:1068 cmp word ptr SS:[BP-14],2
1465:106C jne short 0x1071
1465:106E jmp near 0x11D3
1465:1071 cmp AX,2
1465:1074 jne short 0x1079
1465:1076 jmp near 0x11D3
1465:1079 mov AX,word ptr SS:[BP-14]
1465:107C or AX,word ptr SS:[BP-20]
1465:107F jne short 0x1084
1465:1081 jmp near 0x11D3
1465:1084 mov ES,word ptr DS:[0x562A]
1465:1088 mov AX,word ptr ES:[0xA44B]
1465:108C mov word ptr SS:[BP-36],AX
1465:108F mov ES,word ptr DS:[0x562C]
1465:1093 mov AX,word ptr ES:[0xA44D]
1465:1097 mov word ptr SS:[BP-46],AX
1465:109A mov ES,word ptr DS:[0x5636]
1465:109E push word ptr ES:[SI+0x4036]
1465:10A3 mov ES,word ptr DS:[0x5638]
1465:10A7 push word ptr ES:[SI+0x4004]
1465:10AC call far 017D:186F
1465:10B1 add SP,4
1465:10B4 push word ptr SS:[BP-20]
1465:10B7 push word ptr SS:[BP-14]
1465:10BA call far 017D:191B
1465:10BF add SP,4
1465:10C2 mov AX,1
1465:10C5 push AX
1465:10C6 push word ptr SS:[BP-20]
1465:10C9 push word ptr SS:[BP-14]
1465:10CC push word ptr SS:[BP-2]
1465:10CF call far 0FAE:16AB
1465:10D4 add SP,8
1465:10D7 or AX,AX
1465:10D9 je short 0x10DE
1465:10DB jmp near 0x11BD
1465:10DE mov word ptr SS:[BP-68],1
1465:10E3 mov BX,word ptr SS:[BP-2]
1465:10E6 mov ES,word ptr DS:[0x562E]
1465:10EA inc byte ptr ES:[BX+0x0078]
1465:10EF mov SI,word ptr SS:[BP-2]
1465:10F2 shl SI,1
1465:10F4 mov ES,word ptr DS:[0x562A]
1465:10F8 mov AX,word ptr ES:[0xA44B]
1465:10FC mov ES,word ptr DS:[0x5638]
1465:1100 mov word ptr ES:[SI+0x4004],AX
1465:1105 mov ES,word ptr DS:[0x562C]
1465:1109 mov AX,word ptr ES:[0xA44D]
1465:110D mov ES,word ptr DS:[0x5636]
1465:1111 mov word ptr ES:[SI+0x4036],AX
1465:1116 mov BX,word ptr SS:[BP-20]
1465:1119 shl BX,1
1465:111B shl BX,1
1465:111D add BX,word ptr SS:[BP-14]
1465:1120 mov ES,word ptr DS:[0x563A]
1465:1124 mov AL,byte ptr ES:[BX+0x2ED1]
1465:1129 cbw
1465:112A mov word ptr SS:[BP-64],AX
1465:112D cmp word ptr SS:[BP-14],0
1465:1131 jne short 0x113C
1465:1133 cmp word ptr SS:[BP-20],0
1465:1137 jne short 0x113C
1465:1139 jmp near 0x11BD
1465:113C mov SI,word ptr SS:[BP-2]
1465:113F inc byte ptr SS:[BP+SI-120]
1465:1142 mov BX,word ptr SS:[BP-2]
1465:1145 mov ES,word ptr DS:[0x563C]
1465:1149 mov AL,byte ptr ES:[BX+0x396C]
1465:114E cbw
1465:114F cmp AX,word ptr SS:[BP-64]
1465:1152 je short 0x1191
1465:1154 cmp BX,4
1465:1157 jl short 0x115E
1465:1159 cmp BX,0x000C
1465:115C jl short 0x1163
1465:115E cmp BX,0x0010
1465:1161 jl short 0x1167
1465:1163 add word ptr SS:[BP-64],8
1465:1167 mov BX,word ptr SS:[BP-64]
1465:116A shl BX,1
1465:116C shl BX,1
1465:116E mov ES,word ptr DS:[0x563E]
1465:1172 mov AX,word ptr ES:[BX+0x025A]
1465:1177 mov DX,word ptr ES:[BX+0x025C]
1465:117C mov BX,word ptr SS:[BP-2]
1465:117F shl BX,1
1465:1181 shl BX,1
1465:1183 mov ES,word ptr DS:[0x5640]
1465:1187 mov word ptr ES:[BX+0x01F6],AX
1465:118C mov word ptr ES:[BX+0x01F8],DX
1465:1191 push word ptr SS:[BP-2]
1465:1194 call far 017D:1732
1465:1199 add SP,2
1465:119C mov BX,word ptr SS:[BP-2]
1465:119F mov ES,word ptr DS:[0x5642]
1465:11A3 mov byte ptr ES:[BX+0x409A],AL
1465:11A8 mov BX,word ptr SS:[BP-2]
1465:11AB mov ES,word ptr DS:[0x563C]
1465:11AF mov AL,byte ptr ES:[BX+0x396C]
1465:11B4 mov ES,word ptr DS:[0x5644]
1465:11B8 mov byte ptr ES:[BX+0x3920],AL
1465:11BD mov ES,word ptr DS:[0x562A]
1465:11C1 mov AX,word ptr SS:[BP-36]
1465:11C4 mov word ptr ES:[0xA44B],AX
1465:11C8 mov ES,word ptr DS:[0x562C]
1465:11CC mov AX,word ptr SS:[BP-46]
1465:11CF mov word ptr ES:[0xA44D],AX
1465:11D3 inc word ptr SS:[BP-2]
1465:11D6 cmp word ptr SS:[BP-2],0x0018
1465:11DA jge short 0x11DF
1465:11DC jmp near 0x1023
1465:11DF cmp word ptr SS:[BP-68],0
1465:11E3 jne short 0x11E8
1465:11E5 jmp near 0x1286
1465:11E8 mov ES,word ptr DS:[0x5646]
1465:11EC cmp word ptr ES:[0x2E3A],0
1465:11F2 jne short 0x11F7
1465:11F4 jmp near 0x1286
1465:11F7 mov word ptr SS:[BP-76],4
1465:11FC mov ES,word ptr DS:[0x5648]
1465:1200 cmp byte ptr ES:[0xC620],8
1465:1206 jge short 0x1210
1465:1208 mov AL,byte ptr ES:[0xC620]
1465:120C cbw
1465:120D mov word ptr SS:[BP-76],AX
1465:1210 mov SI,word ptr SS:[BP-76]
1465:1213 shl SI,1
1465:1215 mov ES,word ptr DS:[0x5636]
1465:1219 push word ptr ES:[SI+0x4036]
1465:121E mov ES,word ptr DS:[0x5638]
1465:1222 push word ptr ES:[SI+0x4004]
1465:1227 call far 017D:17BB
1465:122C add SP,4
1465:122F mov ES,word ptr DS:[0x562C]
1465:1233 push word ptr ES:[0xA44D]
1465:1238 mov ES,word ptr DS:[0x562A]
1465:123C push word ptr ES:[0xA44B]
1465:1241 call far 19FC:1314
1465:1246 add SP,4
1465:1249 mov ES,word ptr DS:[0x562A]
1465:124D mov AX,word ptr ES:[0xA44B]
1465:1251 mov word ptr SS:[BP-16],AX
1465:1254 mov ES,word ptr DS:[0x562C]
1465:1258 mov AX,word ptr ES:[0xA44D]
1465:125C mov word ptr SS:[BP-26],AX
1465:125F sub AX,AX
1465:1261 push AX
1465:1262 mov AX,0x4314
1465:1265 mov DX,0x2A0F
1465:1268 push DX
1465:1269 push AX
1465:126A call far 19FC:1ECE
1465:126F add SP,6
1465:1272 call far 017D:240B
1465:1277 call far 19FC:18EF
1465:127C call far 017D:0E4B
1465:1281 call far 18BA:06C3
1465:1286 mov word ptr SS:[BP-2],0
1465:128B jmp near 0x0ED8
1465:128E mov ES,word ptr DS:[0x5630]
1465:1292 cmp word ptr ES:[0x014A],0
1465:1298 je short 0x12A8
1465:129A push word ptr SS:[BP-74]
1465:129D push word ptr SS:[BP-62]
1465:12A0 call far 017D:17BB
1465:12A5 add SP,4
1465:12A8 mov ES,word ptr DS:[0x5630]
1465:12AC cmp word ptr ES:[0x014A],0
1465:12B2 je short 0x12C1
1465:12B4 lea AX,BP-120
1465:12B7 push SS
1465:12B8 push AX
1465:12B9 call far 0FAE:0C63
1465:12BE add SP,4
1465:12C1 pop SI
1465:12C2 pop DI
1465:12C3 mov SP,BP
1465:12C5 pop BP
1465:12C6 ret far
1650:17C6 xor AX,AX
1650:17C8 call far 19FC:2FDC
1650:17CD mov AX,7
1650:17D0 push AX
1650:17D1 call far 17D3:0281
1650:17D6 add SP,2
1650:17D9 call far 17D3:0388
1650:17DE sub AX,AX
1650:17E0 push AX
1650:17E1 call far 17D3:0004
1650:17E6 add SP,2
1650:17E9 ret far
1650:17EA push BP
1650:17EB mov BP,SP
1650:17ED xor AX,AX
1650:17EF call far 19FC:2FDC
1650:17F4 push word ptr SS:[BP+8]
1650:17F7 push word ptr SS:[BP+6]
1650:17FA call far 17D3:03F5
1650:17FF add SP,4
1650:1802 call far 18BA:086A
1650:1807 pop BP
1650:1808 ret far
17D3:0004 push BP
17D3:0005 mov BP,SP
17D3:0007 mov AX,0x0014
17D3:000A call far 19FC:2FDC
17D3:000F mov ES,word ptr DS:[0x56D0]
17D3:0013 mov AX,word ptr ES:[0x39A0]
17D3:0017 mov word ptr SS:[BP-12],AX
17D3:001A mov ES,word ptr DS:[0x56D2]
17D3:001E mov AX,word ptr ES:[0x39A4]
17D3:0022 mov word ptr SS:[BP-14],AX
17D3:0025 mov BX,word ptr SS:[BP+6]
17D3:0028 shl BX,1
17D3:002A shl BX,1
17D3:002C mov AX,word ptr DS:[BX+0x4FA4]
17D3:0030 mov DX,word ptr DS:[BX+0x4FA6]
17D3:0034 mov word ptr SS:[BP-4],AX
17D3:0037 mov word ptr SS:[BP-2],DX
17D3:003A les BX,word ptr SS:[BP-4]
17D3:003D mov AX,word ptr ES:[BX]
17D3:0040 mov CL,5
17D3:0042 shl AX,CL
17D3:0044 mov ES,word ptr DS:[0x56D4]
17D3:0048 add AX,word ptr ES:[0x4066]
17D3:004D mov DX,word ptr ES:[0x4068]
17D3:0052 mov word ptr SS:[BP-20],AX
17D3:0055 mov word ptr SS:[BP-18],DX
17D3:0058 mov AX,word ptr SS:[BP-14]
17D3:005B dec AX
17D3:005C push AX
17D3:005D mov AX,word ptr SS:[BP-12]
17D3:0060 dec AX
17D3:0061 push AX
17D3:0062 push DX
17D3:0063 push word ptr SS:[BP-20]
17D3:0066 call far 19FC:275C
17D3:006B add SP,8
17D3:006E les BX,word ptr SS:[BP-4]
17D3:0071 mov AX,word ptr ES:[BX+2]
17D3:0075 mov CL,5
17D3:0077 shl AX,CL
17D3:0079 mov ES,word ptr DS:[0x56D4]
17D3:007D add AX,word ptr ES:[0x4066]
17D3:0082 mov DX,word ptr ES:[0x4068]
17D3:0087 mov word ptr SS:[BP-20],AX
17D3:008A mov word ptr SS:[BP-18],DX
17D3:008D mov AX,word ptr SS:[BP-14]
17D3:0090 dec AX
17D3:0091 push AX
17D3:0092 mov ES,word ptr DS:[0x56D6]
17D3:0096 mov AX,word ptr ES:[0x3990]
17D3:009A add AX,word ptr SS:[BP-12]
17D3:009D push AX
17D3:009E push DX
17D3:009F push word ptr SS:[BP-20]
17D3:00A2 call far 19FC:275C
17D3:00A7 add SP,8
17D3:00AA les BX,word ptr SS:[BP-4]
17D3:00AD mov AX,word ptr ES:[BX+4]
17D3:00B1 mov CL,5
17D3:00B3 shl AX,CL
17D3:00B5 mov ES,word ptr DS:[0x56D4]
17D3:00B9 add AX,word ptr ES:[0x4066]
17D3:00BE mov DX,word ptr ES:[0x4068]
17D3:00C3 mov word ptr SS:[BP-20],AX
17D3:00C6 mov word ptr SS:[BP-18],DX
17D3:00C9 mov ES,word ptr DS:[0x56D8]
17D3:00CD mov AX,word ptr ES:[0x393A]
17D3:00D1 add AX,word ptr SS:[BP-14]
17D3:00D4 push AX
17D3:00D5 mov AX,word ptr SS:[BP-12]
17D3:00D8 dec AX
17D3:00D9 push AX
17D3:00DA push DX
17D3:00DB push word ptr SS:[BP-20]
17D3:00DE call far 19FC:275C
17D3:00E3 add SP,8
17D3:00E6 les BX,word ptr SS:[BP-4]
17D3:00E9 mov AX,word ptr ES:[BX+6]
17D3:00ED mov CL,5
17D3:00EF shl AX,CL
17D3:00F1 mov ES,word ptr DS:[0x56D4]
17D3:00F5 add AX,word ptr ES:[0x4066]
17D3:00FA mov DX,word ptr ES:[0x4068]
17D3:00FF mov word ptr SS:[BP-20],AX
17D3:0102 mov word ptr SS:[BP-18],DX
17D3:0105 mov ES,word ptr DS:[0x56D8]
17D3:0109 mov AX,word ptr ES:[0x393A]
17D3:010D add AX,word ptr SS:[BP-14]
17D3:0110 push AX
17D3:0111 mov ES,word ptr DS:[0x56D6]
17D3:0115 mov AX,word ptr ES:[0x3990]
17D3:0119 add AX,word ptr SS:[BP-12]
17D3:011C push AX
17D3:011D push DX
17D3:011E push word ptr SS:[BP-20]
17D3:0121 call far 19FC:275C
17D3:0126 add SP,8
17D3:0129 mov word ptr SS:[BP-6],4
17D3:012E mov AX,1
17D3:0131 push AX
17D3:0132 mov ES,word ptr DS:[0x56D6]
17D3:0136 push word ptr ES:[0x3990]
17D3:013B mov AX,word ptr SS:[BP-14]
17D3:013E dec AX
17D3:013F push AX
17D3:0140 push word ptr SS:[BP-12]
17D3:0143 mov AX,4
17D3:0146 push AX
17D3:0147 push word ptr SS:[BP-2]
17D3:014A push word ptr SS:[BP-4]
17D3:014D push CS
17D3:014E call near 0x01E7
17D3:0151 add SP,0x000E
17D3:0154 mov word ptr SS:[BP-6],AX
17D3:0157 sub AX,AX
17D3:0159 push AX
17D3:015A mov ES,word ptr DS:[0x56D8]
17D3:015E push word ptr ES:[0x393A]
17D3:0163 push word ptr SS:[BP-14]
17D3:0166 mov ES,word ptr DS:[0x56D0]
17D3:016A mov AX,word ptr ES:[0x39A0]
17D3:016E dec AX
17D3:016F push AX
17D3:0170 push word ptr SS:[BP-6]
17D3:0173 push word ptr SS:[BP-2]
17D3:0176 push word ptr SS:[BP-4]
17D3:0179 push CS
17D3:017A call near 0x01E7
17D3:017D add SP,0x000E
17D3:0180 mov word ptr SS:[BP-6],AX
17D3:0183 sub AX,AX
17D3:0185 push AX
17D3:0186 mov ES,word ptr DS:[0x56D8]
17D3:018A push word ptr ES:[0x393A]
17D3:018F push word ptr SS:[BP-14]
17D3:0192 mov ES,word ptr DS:[0x56D0]
17D3:0196 mov AX,word ptr ES:[0x39A0]
17D3:019A mov ES,word ptr DS:[0x56D6]
17D3:019E add AX,word ptr ES:[0x3990]
17D3:01A3 push AX
17D3:01A4 push word ptr SS:[BP-6]
17D3:01A7 push word ptr SS:[BP-2]
17D3:01AA push word ptr SS:[BP-4]
17D3:01AD push CS
17D3:01AE call near 0x01E7
17D3:01B1 add SP,0x000E
17D3:01B4 mov word ptr SS:[BP-6],AX
17D3:01B7 mov AX,1
17D3:01BA push AX
17D3:01BB mov ES,word ptr DS:[0x56D6]
17D3:01BF push word ptr ES:[0x3990]
17D3:01C4 mov ES,word ptr DS:[0x56D8]
17D3:01C8 mov AX,word ptr ES:[0x393A]
17D3:01CC add AX,word ptr SS:[BP-14]
17D3:01CF push AX
17D3:01D0 push word ptr SS:[BP-12]
17D3:01D3 push word ptr SS:[BP-6]
17D3:01D6 push word ptr SS:[BP-2]
17D3:01D9 push word ptr SS:[BP-4]
17D3:01DC push CS
17D3:01DD call near 0x01E7
17D3:01E0 mov word ptr SS:[BP-6],AX
17D3:01E3 mov SP,BP
17D3:01E5 pop BP
17D3:01E6 ret far
17D3:01E7 push BP
17D3:01E8 mov BP,SP
17D3:01EA mov AX,8
17D3:01ED call far 19FC:2FDC
17D3:01F2 push SI
17D3:01F3 mov AX,word ptr SS:[BP+0x0A]
17D3:01F6 mov word ptr SS:[BP-8],AX
17D3:01F9 mov word ptr SS:[BP-2],0
17D3:01FE jmp short 0x021E
17D3:0200 inc word ptr SS:[BP+0x0E]
17D3:0203 inc word ptr SS:[BP-8]
17D3:0206 mov BX,word ptr SS:[BP-8]
17D3:0209 shl BX,1
17D3:020B les SI,word ptr SS:[BP+6]
17D3:020E cmp word ptr ES:[BX+SI],0x00FF
17D3:0213 jne short 0x021B
17D3:0215 mov AX,word ptr SS:[BP+0x0A]
17D3:0218 mov word ptr SS:[BP-8],AX
17D3:021B inc word ptr SS:[BP-2]
17D3:021E mov AX,word ptr SS:[BP+0x10]
17D3:0221 cmp word ptr SS:[BP-2],AX
17D3:0224 jge short 0x0267
17D3:0226 mov BX,word ptr SS:[BP-8]
17D3:0229 shl BX,1
17D3:022B les SI,word ptr SS:[BP+6]
17D3:022E mov AX,word ptr ES:[BX+SI]
17D3:0231 mov CL,5
17D3:0233 shl AX,CL
17D3:0235 mov ES,word ptr DS:[0x56D4]
17D3:0239 add AX,word ptr ES:[0x4066]
17D3:023E mov DX,word ptr ES:[0x4068]
17D3:0243 mov word ptr SS:[BP-6],AX
17D3:0246 mov word ptr SS:[BP-4],DX
17D3:0249 push word ptr SS:[BP+0x0E]
17D3:024C push word ptr SS:[BP+0x0C]
17D3:024F push DX
17D3:0250 push AX
17D3:0251 call far 19FC:275C
17D3:0256 add SP,8
17D3:0259 cmp word ptr SS:[BP+0x12],0
17D3:025D je short 0x0200
17D3:025F inc word ptr SS:[BP+0x0C]
17D3:0262 jmp short 0x0203
17D3:0264 inc word ptr SS:[BP-8]
17D3:0267 mov BX,word ptr SS:[BP-8]
17D3:026A shl BX,1
17D3:026C les SI,word ptr SS:[BP+6]
17D3:026F cmp word ptr ES:[BX+SI],0x00FF
17D3:0274 jne short 0x0264
17D3:0276 inc word ptr SS:[BP-8]
17D3:0279 mov AX,word ptr SS:[BP-8]
17D3:027C pop SI
17D3:027D mov SP,BP
17D3:027F pop BP
17D3:0280 ret far
17D3:0281 push BP
17D3:0282 mov BP,SP
17D3:0284 xor AX,AX
17D3:0286 call far 19FC:2FDC
17D3:028B push SI
17D3:028C cmp word ptr DS:[0x4FA2],0
17D3:0291 je short 0x02E6
17D3:0293 mov ES,word ptr DS:[0x56DA]
17D3:0297 mov SI,word ptr ES:[0x4600]
17D3:029C mov CL,4
17D3:029E shl SI,CL
17D3:02A0 mov ES,word ptr DS:[0x56DC]
17D3:02A4 mov AX,word ptr ES:[0x37FE]
17D3:02A8 mov ES,word ptr DS:[0x56DE]
17D3:02AC mov word ptr ES:[SI+8],AX
17D3:02B1 mov ES,word ptr DS:[0x56E0]
17D3:02B5 mov AX,word ptr ES:[0x377E]
17D3:02B9 mov ES,word ptr DS:[0x56DE]
17D3:02BD mov word ptr ES:[SI+0x000A],AX
17D3:02C2 mov ES,word ptr DS:[0x56E2]
17D3:02C6 mov AX,word ptr ES:[0x3748]
17D3:02CA mov ES,word ptr DS:[0x56DE]
17D3:02CE mov word ptr ES:[SI+0x000C],AX
17D3:02D3 mov ES,word ptr DS:[0x56E4]
17D3:02D7 mov AX,word ptr ES:[0x374E]
17D3:02DB mov ES,word ptr DS:[0x56DE]
17D3:02DF mov word ptr ES:[SI+0x000E],AX
17D3:02E4 jmp short 0x02EC
17D3:02E6 mov word ptr DS:[0x4FA2],1
17D3:02EC mov ES,word ptr DS:[0x56DA]
17D3:02F0 mov AX,word ptr SS:[BP+6]
17D3:02F3 mov word ptr ES:[0x4600],AX
17D3:02F7 mov SI,AX
17D3:02F9 mov CL,4
17D3:02FB shl SI,CL
17D3:02FD mov ES,word ptr DS:[0x56DE]
17D3:0301 mov AX,word ptr ES:[SI]
17D3:0306 mov ES,word ptr DS:[0x56D0]
17D3:030A mov word ptr ES:[0x39A0],AX
17D3:030E mov ES,word ptr DS:[0x56DE]
17D3:0312 mov AX,word ptr ES:[SI+2]
17D3:0317 mov ES,word ptr DS:[0x56D2]
17D3:031B mov word ptr ES:[0x39A4],AX
17D3:031F mov ES,word ptr DS:[0x56DE]
17D3:0323 mov AX,word ptr ES:[SI+4]
17D3:0328 mov ES,word ptr DS:[0x56D6]
17D3:032C mov word ptr ES:[0x3990],AX
17D3:0330 mov ES,word ptr DS:[0x56DE]
17D3:0334 mov AX,word ptr ES:[SI+6]
17D3:0339 mov ES,word ptr DS:[0x56D8]
17D3:033D mov word ptr ES:[0x393A],AX
17D3:0341 mov ES,word ptr DS:[0x56DE]
17D3:0345 mov AX,word ptr ES:[SI+8]
17D3:034A mov ES,word ptr DS:[0x56DC]
17D3:034E mov word ptr ES:[0x37FE],AX
17D3:0352 mov ES,word ptr DS:[0x56DE]
17D3:0356 mov AX,word ptr ES:[SI+0x000A]
17D3:035B mov ES,word ptr DS:[0x56E0]
17D3:035F mov word ptr ES:[0x377E],AX
17D3:0363 mov ES,word ptr DS:[0x56DE]
17D3:0367 mov AX,word ptr ES:[SI+0x000C]
17D3:036C mov ES,word ptr DS:[0x56E2]
17D3:0370 mov word ptr ES:[0x3748],AX
17D3:0374 mov ES,word ptr DS:[0x56DE]
17D3:0378 mov AX,word ptr ES:[SI+0x000E]
17D3:037D mov ES,word ptr DS:[0x56E4]
17D3:0381 mov word ptr ES:[0x374E],AX
17D3:0385 pop SI
17D3:0386 pop BP
17D3:0387 ret far
17D3:0388 xor AX,AX
17D3:038A call far 19FC:2FDC
17D3:038F mov ES,word ptr DS:[0x56E0]
17D3:0393 push word ptr ES:[0x377E]
17D3:0398 mov ES,word ptr DS:[0x56D2]
17D3:039C mov AX,word ptr ES:[0x39A4]
17D3:03A0 mov ES,word ptr DS:[0x56D8]
17D3:03A4 add AX,word ptr ES:[0x393A]
17D3:03A9 mov CL,3
17D3:03AB shl AX,CL
17D3:03AD dec AX
17D3:03AE push AX
17D3:03AF mov ES,word ptr DS:[0x56D0]
17D3:03B3 mov AX,word ptr ES:[0x39A0]
17D3:03B7 mov ES,word ptr DS:[0x56D6]
17D3:03BB add AX,word ptr ES:[0x3990]
17D3:03C0 shl AX,CL
17D3:03C2 dec AX
17D3:03C3 push AX
17D3:03C4 mov ES,word ptr DS:[0x56D2]
17D3:03C8 mov AX,word ptr ES:[0x39A4]
17D3:03CC shl AX,CL
17D3:03CE push AX
17D3:03CF mov ES,word ptr DS:[0x56D0]
17D3:03D3 mov AX,word ptr ES:[0x39A0]
17D3:03D7 shl AX,CL
17D3:03D9 push AX
17D3:03DA call far 18BA:01FB
17D3:03DF add SP,0x000A
17D3:03E2 mov ES,word ptr DS:[0x56E4]
17D3:03E6 sub AX,AX
17D3:03E8 mov word ptr ES:[0x374E],AX
17D3:03EC mov ES,word ptr DS:[0x56E2]
17D3:03F0 mov word ptr ES:[0x3748],AX
17D3:03F4 ret far
17D3:03F5 push BP
17D3:03F6 mov BP,SP
17D3:03F8 mov AX,0x0062
17D3:03FB call far 19FC:2FDC
17D3:0400 push DI
17D3:0401 push SI
17D3:0402 sub AX,AX
17D3:0404 mov word ptr SS:[BP-2],AX
17D3:0407 mov word ptr SS:[BP-8],AX
17D3:040A mov word ptr SS:[BP-6],AX
17D3:040D mov byte ptr SS:[BP-50],0
17D3:0411 mov ES,word ptr DS:[0x56E2]
17D3:0415 mov AX,word ptr ES:[0x3748]
17D3:0419 mov word ptr SS:[BP-96],AX
17D3:041C jmp near 0x0752
17D3:041F cmp word ptr SS:[BP-2],0
17D3:0423 je short 0x0428
17D3:0425 jmp near 0x0768
17D3:0428 test byte ptr SS:[BP-4],0x80
17D3:042C je short 0x0437
17D3:042E and byte ptr SS:[BP-4],0x7F
17D3:0432 mov word ptr SS:[BP-2],1
17D3:0437 cmp byte ptr SS:[BP-4],0x0D
17D3:043B jne short 0x0497
17D3:043D mov SI,word ptr SS:[BP-8]
17D3:0440 mov byte ptr SS:[BP+SI-94],0
17D3:0444 mov AX,word ptr SS:[BP-8]
17D3:0447 add AX,word ptr SS:[BP-96]
17D3:044A mov ES,word ptr DS:[0x56D6]
17D3:044E cmp AX,word ptr ES:[0x3990]
17D3:0453 jg short 0x0470
17D3:0455 lea AX,BP-94
17D3:0458 push SS
17D3:0459 push AX
17D3:045A lea AX,BP-50
17D3:045D push SS
17D3:045E push AX
17D3:045F call far 19FC:3B22
17D3:0464 add SP,8
17D3:0467 mov AX,1
17D3:046A push AX
17D3:046B lea AX,BP-50
17D3:046E jmp short 0x0487
17D3:0470 mov AX,1
17D3:0473 push AX
17D3:0474 lea AX,BP-50
17D3:0477 push SS
17D3:0478 push AX
17D3:0479 push CS
17D3:047A call near 0x07CB
17D3:047D add SP,6
17D3:0480 mov AX,1
17D3:0483 push AX
17D3:0484 lea AX,BP-94
17D3:0487 push SS
17D3:0488 push AX
17D3:0489 push CS
17D3:048A call near 0x07CB
17D3:048D add SP,6
17D3:0490 sub AX,AX
17D3:0492 mov word ptr SS:[BP-8],AX
17D3:0495 jmp short 0x0419
17D3:0497 cmp byte ptr SS:[BP-4],2
17D3:049B jne short 0x0516
17D3:049D mov SI,word ptr SS:[BP-8]
17D3:04A0 mov byte ptr SS:[BP+SI-94],0
17D3:04A4 mov AX,word ptr SS:[BP-8]
17D3:04A7 add AX,word ptr SS:[BP-96]
17D3:04AA mov ES,word ptr DS:[0x56D6]
17D3:04AE cmp AX,word ptr ES:[0x3990]
17D3:04B3 jg short 0x04CF
17D3:04B5 lea AX,BP-94
17D3:04B8 push SS
17D3:04B9 push AX
17D3:04BA lea AX,BP-50
17D3:04BD push SS
17D3:04BE push AX
17D3:04BF call far 19FC:3B22
17D3:04C4 add SP,8
17D3:04C7 sub AX,AX
17D3:04C9 push AX
17D3:04CA lea AX,BP-50
17D3:04CD jmp short 0x04E5
17D3:04CF mov AX,1
17D3:04D2 push AX
17D3:04D3 lea AX,BP-50
17D3:04D6 push SS
17D3:04D7 push AX
17D3:04D8 push CS
17D3:04D9 call near 0x07CB
17D3:04E5 push SS
17D3:04E6 push AX
17D3:04E7 push CS
17D3:04E8 call near 0x07CB
17D3:04EB add SP,6
17D3:04EE mov word ptr SS:[BP-8],0
17D3:04F3 mov ES,word ptr DS:[0x56E2]
17D3:04F7 mov AX,word ptr ES:[0x3748]
17D3:04FB mov word ptr SS:[BP-96],AX
17D3:04FE mov BX,word ptr SS:[BP-6]
17D3:0501 inc word ptr SS:[BP-6]
17D3:0504 les SI,word ptr SS:[BP+6]
17D3:0507 mov AL,byte ptr ES:[BX+SI]
17D3:050A cbw
17D3:050B mov ES,word ptr DS:[0x56E0]
17D3:050F mov word ptr ES:[0x377E],AX
17D3:0513 jmp near 0x0752
17D3:0516 cmp byte ptr SS:[BP-4],6
17D3:051A jne short 0x0595
17D3:051C mov SI,word ptr SS:[BP-8]
17D3:051F mov byte ptr SS:[BP+SI-94],0
17D3:0523 mov AX,word ptr SS:[BP-8]
17D3:0526 add AX,word ptr SS:[BP-96]
17D3:0529 mov ES,word ptr DS:[0x56D6]
17D3:052D cmp AX,word ptr ES:[0x3990]
17D3:0532 jg short 0x054E
17D3:0534 lea AX,BP-94
17D3:0537 push SS
17D3:0538 push AX
17D3:0539 lea AX,BP-50
17D3:053C push SS
17D3:053D push AX
17D3:053E call far 19FC:3B22
17D3:0543 add SP,8
17D3:0546 sub AX,AX
17D3:0548 push AX
17D3:0549 lea AX,BP-50
17D3:054C jmp short 0x0564
17D3:054E mov AX,1
17D3:0551 push AX
17D3:0552 lea AX,BP-50
17D3:0555 push SS
17D3:0556 push AX
17D3:0557 push CS
17D3:0558 call near 0x07CB
17D3:0564 push SS
17D3:0565 push AX
17D3:0566 push CS
17D3:0567 call near 0x07CB
17D3:056A add SP,6
17D3:056D mov word ptr SS:[BP-8],0
17D3:0572 mov ES,word ptr DS:[0x56E2]
17D3:0576 mov AX,word ptr ES:[0x3748]
17D3:057A mov word ptr SS:[BP-96],AX
17D3:057D mov BX,word ptr SS:[BP-6]
17D3:0580 inc word ptr SS:[BP-6]
17D3:0583 les SI,word ptr SS:[BP+6]
17D3:0586 mov AL,byte ptr ES:[BX+SI]
17D3:0589 cbw
17D3:058A mov ES,word ptr DS:[0x56DC]
17D3:058E mov word ptr ES:[0x37FE],AX
17D3:0592 jmp near 0x0752
17D3:0595 cmp byte ptr SS:[BP-4],9
17D3:0599 je short 0x059E
17D3:059B jmp near 0x062B
17D3:059E mov SI,word ptr SS:[BP-8]
17D3:05A1 mov byte ptr SS:[BP+SI-94],0
17D3:05A5 mov AX,word ptr SS:[BP-8]
17D3:05A8 add AX,word ptr SS:[BP-96]
17D3:05AB mov ES,word ptr DS:[0x56D6]
17D3:05AF cmp AX,word ptr ES:[0x3990]
17D3:05B4 jg short 0x05D0
17D3:05B6 lea AX,BP-94
17D3:05B9 push SS
17D3:05BA push AX
17D3:05BB lea AX,BP-50
17D3:05BE push SS
17D3:05BF push AX
17D3:05C0 call far 19FC:3B22
17D3:05D0 mov AX,1
17D3:05D3 push AX
17D3:05D4 lea AX,BP-50
17D3:05D7 push SS
17D3:05D8 push AX
17D3:05D9 push CS
17D3:05DA call near 0x07CB
17D3:062B cmp byte ptr SS:[BP-4],0x13
17D3:062F jne short 0x0693
17D3:0631 mov BX,word ptr SS:[BP-6]
17D3:0634 inc word ptr SS:[BP-6]
17D3:0637 les SI,word ptr SS:[BP+6]
17D3:063A mov AL,byte ptr ES:[BX+SI]
17D3:063D cbw
17D3:063E mov word ptr SS:[BP-52],AX
17D3:0641 mov ES,word ptr DS:[0x56E2]
17D3:0645 cmp word ptr ES:[0x3748],AX
17D3:064A jl short 0x064F
17D3:064C jmp near 0x0752
17D3:064F jmp short 0x065E
17D3:0651 mov SI,word ptr SS:[BP-8]
17D3:0654 inc word ptr SS:[BP-8]
17D3:0657 mov byte ptr SS:[BP+SI-94],0x20
17D3:065B dec word ptr SS:[BP-52]
17D3:065E mov ES,word ptr DS:[0x56E2]
17D3:0662 mov AX,word ptr SS:[BP-52]
17D3:0665 cmp word ptr ES:[0x3748],AX
17D3:066A jl short 0x0651
17D3:066C mov SI,word ptr SS:[BP-8]
17D3:066F mov byte ptr SS:[BP+SI-94],0
17D3:0673 lea AX,BP-94
17D3:0676 push SS
17D3:0677 push AX
17D3:0678 lea AX,BP-50
17D3:067B push SS
17D3:067C push AX
17D3:067D call far 19FC:3B22
17D3:0682 add SP,8
17D3:0685 mov AX,word ptr SS:[BP-8]
17D3:0688 add word ptr SS:[BP-96],AX
17D3:068B mov word ptr SS:[BP-8],0
17D3:0690 jmp near 0x0752
17D3:0693 cmp byte ptr SS:[BP-4],0x20
17D3:0697 jne short 0x070C
17D3:0699 mov SI,word ptr SS:[BP-8]
17D3:069C add SI,word ptr SS:[BP-96]
17D3:069F mov ES,word ptr DS:[0x56D6]
17D3:06A3 cmp word ptr ES:[0x3990],SI
17D3:06A8 jl short 0x06BC
17D3:06AA je short 0x066C
17D3:06AC or SI,SI
17D3:06AE je short 0x066C
17D3:06B0 mov DI,word ptr SS:[BP-8]
17D3:06B3 inc word ptr SS:[BP-8]
17D3:06B6 mov byte ptr SS:[BP+DI-94],0x20
17D3:06BA jmp short 0x066C
17D3:06BC mov SI,word ptr SS:[BP-8]
17D3:06BF inc word ptr SS:[BP-8]
17D3:06C2 mov byte ptr SS:[BP+SI-94],0x20
17D3:06C6 mov SI,word ptr SS:[BP-8]
17D3:06C9 mov byte ptr SS:[BP+SI-94],0
17D3:06CD mov AX,1
17D3:06D0 push AX
17D3:06D1 lea AX,BP-50
17D3:06D4 push SS
17D3:06D5 push AX
17D3:06D6 push CS
17D3:06D7 call near 0x07CB
17D3:06DA add SP,6
17D3:06DD mov word ptr SS:[BP-96],0
17D3:06E2 lea AX,BP-94
17D3:06E5 push SS
17D3:06E6 push AX
17D3:06E7 lea AX,BP-50
17D3:06EA push SS
17D3:06EB push AX
17D3:06EC call far 19FC:3B68
17D3:06F1 add SP,8
17D3:06F4 jmp short 0x06F9
17D3:06F6 inc word ptr SS:[BP-6]
17D3:06F9 mov BX,word ptr SS:[BP-6]
17D3:06FC les SI,word ptr SS:[BP+6]
17D3:06FF mov AL,byte ptr ES:[BX+SI]
17D3:0702 mov byte ptr SS:[BP-4],AL
17D3:0705 cmp AL,0x20
17D3:0707 je short 0x06F6
17D3:0709 jmp near 0x0685
17D3:070C mov ES,word ptr DS:[0x56D6]
17D3:0710 mov AX,word ptr ES:[0x3990]
17D3:0714 dec AX
17D3:0715 cmp AX,word ptr SS:[BP-8]
17D3:0718 jg short 0x0746
17D3:071A cmp byte ptr SS:[BP-50],0
17D3:071E je short 0x0730
17D3:0720 mov AX,1
17D3:0723 push AX
17D3:0724 lea AX,BP-50
17D3:0727 push SS
17D3:0728 push AX
17D3:0729 push CS
17D3:072A call near 0x07CB
17D3:0730 mov SI,word ptr SS:[BP-8]
17D3:0733 inc word ptr SS:[BP-8]
17D3:0736 mov AL,byte ptr SS:[BP-4]
17D3:0739 mov byte ptr SS:[BP+SI-94],AL
17D3:073C mov SI,word ptr SS:[BP-8]
17D3:073F mov byte ptr SS:[BP+SI-94],0
17D3:0743 jmp near 0x0455
17D3:0746 mov SI,word ptr SS:[BP-8]
17D3:0749 inc word ptr SS:[BP-8]
17D3:074C mov AL,byte ptr SS:[BP-4]
17D3:074F mov byte ptr SS:[BP+SI-94],AL
17D3:0752 mov BX,word ptr SS:[BP-6]
17D3:0755 inc word ptr SS:[BP-6]
17D3:0758 les SI,word ptr SS:[BP+6]
17D3:075B mov AL,byte ptr ES:[BX+SI]
17D3:075E mov byte ptr SS:[BP-4],AL
17D3:0761 or AL,AL
17D3:0763 je short 0x0768
17D3:0765 jmp near 0x041F
17D3:0768 cmp word ptr SS:[BP-8],0
17D3:076C jne short 0x0774
17D3:076E cmp byte ptr SS:[BP-50],0
17D3:0772 je short 0x07C5
17D3:0774 mov SI,word ptr SS:[BP-8]
17D3:0777 mov byte ptr SS:[BP+SI-94],0
17D3:077B mov AX,word ptr SS:[BP-8]
17D3:077E add AX,word ptr SS:[BP-96]
17D3:0781 mov ES,word ptr DS:[0x56D6]
17D3:0785 cmp AX,word ptr ES:[0x3990]
17D3:078A jg short 0x07A6
17D3:078C lea AX,BP-94
17D3:078F push SS
17D3:0790 push AX
17D3:0791 lea AX,BP-50
17D3:0794 push SS
17D3:0795 push AX
17D3:0796 call far 19FC:3B22
17D3:079B add SP,8
17D3:079E sub AX,AX
17D3:07A0 push AX
17D3:07A1 lea AX,BP-50
17D3:07A4 jmp short 0x07BC
17D3:07A6 mov AX,1
17D3:07A9 push AX
17D3:07AA lea AX,BP-50
17D3:07AD push SS
17D3:07AE push AX
17D3:07AF push CS
17D3:07B0 call near 0x07CB
17D3:07B3 add SP,6
17D3:07B6 sub AX,AX
17D3:07B8 push AX
17D3:07B9 lea AX,BP-94
17D3:07BC push SS
17D3:07BD push AX
17D3:07BE push CS
17D3:07BF call near 0x07CB
17D3:07C2 add SP,6
17D3:07C5 pop SI
17D3:07C6 pop DI
17D3:07C7 mov SP,BP
17D3:07C9 pop BP
17D3:07CA ret far
17D3:07CB push BP
17D3:07CC mov BP,SP
17D3:07CE mov AX,0x0014
17D3:07D1 call far 19FC:2FDC
17D3:07D6 push SI
17D3:07D7 mov ES,word ptr DS:[0x56D8]
17D3:07DB mov AX,word ptr ES:[0x393A]
17D3:07DF mov ES,word ptr DS:[0x56E4]
17D3:07E3 cmp word ptr ES:[0x374E],AX
17D3:07E8 jge short 0x07ED
17D3:07EA jmp near 0x09AB
17D3:07ED push word ptr SS:[BP+8]
17D3:07F0 push word ptr SS:[BP+6]
17D3:07F3 call far 19FC:3B9E
17D3:0985 mov ES,word ptr DS:[0x56E2]
17D3:0989 jmp near 0x0A1F
17D3:09AB mov ES,word ptr DS:[0x56E0]
17D3:09AF push word ptr ES:[0x377E]
17D3:09B4 mov ES,word ptr DS:[0x56DC]
17D3:09B8 push word ptr ES:[0x37FE]
17D3:09BD mov ES,word ptr DS:[0x56E4]
17D3:09C1 mov AX,word ptr ES:[0x374E]
17D3:09C5 mov ES,word ptr DS:[0x56D2]
17D3:09C9 add AX,word ptr ES:[0x39A4]
17D3:09CE push AX
17D3:09CF mov ES,word ptr DS:[0x56E2]
17D3:09D3 mov AX,word ptr ES:[0x3748]
17D3:09D7 mov ES,word ptr DS:[0x56D0]
17D3:09DB add AX,word ptr ES:[0x39A0]
17D3:09E0 push AX
17D3:09E1 push word ptr SS:[BP+8]
17D3:09E4 push word ptr SS:[BP+6]
17D3:09E7 call far 18BA:00D5
17D3:09EC add SP,0x000C
17D3:09EF cmp word ptr SS:[BP+0x0A],0
17D3:09F3 jne short 0x0985
17D3:09F5 push word ptr SS:[BP+8]
17D3:09F8 push word ptr SS:[BP+6]
17D3:09FB call far 19FC:3B9E
17D3:0A00 add SP,4
17D3:0A03 mov ES,word ptr DS:[0x56E2]
17D3:0A07 add word ptr ES:[0x3748],AX
17D3:0A0C mov ES,word ptr DS:[0x56D6]
17D3:0A10 mov AX,word ptr ES:[0x3990]
17D3:0A14 mov ES,word ptr DS:[0x56E2]
17D3:0A18 cmp word ptr ES:[0x3748],AX
17D3:0A1D jl short 0x0A2F
17D3:0A1F mov word ptr ES:[0x3748],0
17D3:0A26 mov ES,word ptr DS:[0x56E4]
17D3:0A2A inc word ptr ES:[0x374E]
17D3:0A2F les BX,word ptr SS:[BP+6]
17D3:0A32 mov byte ptr ES:[BX],0
17D3:0A36 pop SI
17D3:0A37 mov SP,BP
17D3:0A39 pop BP
17D3:0A3A ret far
17D3:0A3B push BP
17D3:0A3C mov BP,SP
17D3:0A3E mov AX,4
17D3:0A41 call far 19FC:2FDC
17D3:0A46 mov ES,word ptr DS:[0x56E6]
17D3:0A4A cmp word ptr ES:[0x4FBA],2
17D3:0A50 je short 0x0ACD
17D3:0A52 mov word ptr SS:[BP-2],0x0050
17D3:0A57 cmp word ptr ES:[0x4FBA],0
17D3:0A5D je short 0x0A73
17D3:0A5F mov AX,0x0280
17D3:0A62 imul word ptr SS:[BP+0x10]
17D3:0A65 mov CX,word ptr SS:[BP+0x0E]
17D3:0A68 shl CX,1
17D3:0A6A add AX,CX
17D3:0A6C shl AX,1
17D3:0A6E add word ptr SS:[BP+6],AX
17D3:0A71 jmp short 0x0A86
17D3:0A73 mov AX,0x0140
17D3:0A76 imul word ptr SS:[BP+0x10]
17D3:0A79 add AX,word ptr SS:[BP+0x0E]
17D3:0A7C shl AX,1
17D3:0A7E add word ptr SS:[BP+6],AX
17D3:0A81 mov word ptr SS:[BP-2],0x0028
17D3:0A86 mov word ptr SS:[BP-4],0
17D3:0A8B jmp short 0x0A90
17D3:0A8D inc word ptr SS:[BP-4]
17D3:0A90 cmp word ptr SS:[BP-4],8
17D3:0A94 jge short 0x0AE1
17D3:0A96 les BX,word ptr SS:[BP+6]
17D3:0A99 mov AX,word ptr ES:[BX]
17D3:0A9C les BX,word ptr SS:[BP+0x0A]
17D3:0A9F add word ptr SS:[BP+0x0A],2
17D3:0AA3 mov word ptr ES:[BX],AX
17D3:0AA6 mov ES,word ptr DS:[0x56E6]
17D3:0AAA cmp word ptr ES:[0x4FBA],0
17D3:0AB0 je short 0x0AC3
17D3:0AB2 les BX,word ptr SS:[BP+6]
17D3:0AB5 mov AX,word ptr ES:[BX+2]
17D3:0AB9 les BX,word ptr SS:[BP+0x0A]
17D3:0ABC add word ptr SS:[BP+0x0A],2
17D3:0AC0 mov word ptr ES:[BX],AX
17D3:0AC3 mov AX,word ptr SS:[BP-2]
17D3:0AC6 shl AX,1
17D3:0AC8 add word ptr SS:[BP+6],AX
17D3:0ACB jmp short 0x0A8D
17D3:0ACD push word ptr SS:[BP+0x10]
17D3:0AD0 push word ptr SS:[BP+0x0E]
17D3:0AD3 push word ptr SS:[BP+0x0C]
17D3:0AD6 push word ptr SS:[BP+0x0A]
17D3:0AD9 call far 19FC:0313
17D3:0AE1 mov SP,BP
17D3:0AE3 pop BP
17D3:0AE4 ret far
17D3:0AE5 push BP
17D3:0AE6 mov BP,SP
17D3:0AE8 mov AX,0x000E
17D3:0AEB call far 19FC:2FDC
17D3:0AF0 mov AX,word ptr SS:[BP+0x0E]
17D3:0AF3 mov CL,5
17D3:0AF5 shl AX,CL
17D3:0AF7 cwd
17D3:0AF8 mov word ptr SS:[BP-4],AX
17D3:0AFB mov word ptr SS:[BP-2],DX
17D3:0AFE push DX
17D3:0AFF push AX
17D3:0B00 call far 18BA:05BC
17D3:0B05 add SP,4
17D3:0B08 mov word ptr SS:[BP-10],AX
17D3:0B0B mov word ptr SS:[BP-8],DX
17D3:0B0E mov word ptr SS:[BP-14],AX
17D3:0B11 mov word ptr SS:[BP-12],DX
17D3:0B14 mov word ptr SS:[BP-6],0
17D3:0B19 jmp short 0x0B4C
17D3:0B1B push word ptr SS:[BP+0x0C]
17D3:0B1E push word ptr SS:[BP+0x0A]
17D3:0B21 push word ptr SS:[BP-8]
17D3:0B24 push word ptr SS:[BP-10]
17D3:0B27 push word ptr SS:[BP+8]
17D3:0B2A push word ptr SS:[BP+6]
17D3:0B2D push CS
17D3:0B2E call near 0x0A3B
17D3:0B31 add SP,0x000C
17D3:0B34 inc word ptr SS:[BP+0x0A]
17D3:0B37 cmp word ptr SS:[BP+0x0A],0x0027
17D3:0B3B jle short 0x0B45
17D3:0B3D mov word ptr SS:[BP+0x0A],0
17D3:0B42 inc word ptr SS:[BP+0x0C]
17D3:0B45 add word ptr SS:[BP-10],0x0020
17D3:0B49 inc word ptr SS:[BP-6]
17D3:0B4C mov AX,word ptr SS:[BP+0x0E]
17D3:0B4F cmp word ptr SS:[BP-6],AX
17D3:0B52 jl short 0x0B1B
17D3:0B54 mov AX,word ptr SS:[BP-14]
17D3:0B57 mov DX,word ptr SS:[BP-12]
17D3:0B5A mov SP,BP
17D3:0B5C pop BP
17D3:0B5D ret far
17D3:0B5E push BP
17D3:0B5F mov BP,SP
17D3:0B61 mov AX,0x000C
17D3:0B64 call far 19FC:2FDC
17D3:0B69 push SI
17D3:0B6A mov SI,word ptr SS:[BP+6]
17D3:0B6D mov CL,4
17D3:0B6F shl SI,CL
17D3:0B71 mov ES,word ptr DS:[0x56DE]
17D3:0B75 mov AX,word ptr ES:[SI+0x0092]
17D3:0B7A mov ES,word ptr DS:[0x56D2]
17D3:0B7E add AX,word ptr ES:[0x39A4]
17D3:0B83 mov word ptr SS:[BP-10],AX
17D3:0B86 mov word ptr SS:[BP-2],1
17D3:0B8B mov ES,word ptr DS:[0x56DE]
17D3:0B8F mov AX,word ptr ES:[SI+0x0096]
17D3:0B94 cmp word ptr ES:[SI+0x0098],AX
17D3:0B99 jl short 0x0BA2
17D3:0B9B mov word ptr ES:[SI+0x0098],0
17D3:0BA2 mov ES,word ptr DS:[0x56E8]
17D3:0BA6 cmp word ptr ES:[0x3938],0
17D3:0BAC jne short 0x0BBA
17D3:0BAE mov ES,word ptr DS:[0x56EA]
17D3:0BB2 cmp word ptr ES:[0x458C],0
17D3:0BB8 je short 0x0BCC
17D3:0BBA mov BX,word ptr SS:[BP+6]
17D3:0BBD mov CL,4
17D3:0BBF shl BX,CL
17D3:0BC1 mov ES,word ptr DS:[0x56DE]
17D3:0BC5 mov word ptr ES:[BX+0x0098],0
17D3:0BCC mov SI,word ptr SS:[BP+6]
17D3:0BCF mov CL,4
17D3:0BD1 shl SI,CL
17D3:0BD3 mov ES,word ptr DS:[0x56DE]
17D3:0BD7 mov AX,word ptr ES:[SI+0x0098]
17D3:0BDC mov word ptr SS:[BP-12],AX
17D3:0BDF mov word ptr SS:[BP-4],AX
17D3:0BE2 mov ES,word ptr DS:[0x56EC]
17D3:0BE6 mov word ptr ES:[0xB782],0
17D3:0BED mov ES,word ptr DS:[0x56DE]
17D3:0BF1 push word ptr ES:[SI+0x009C]
17D3:0BF6 push word ptr ES:[SI+0x0094]
17D3:0BFB mov AX,word ptr SS:[BP-10]
17D3:0BFE add AX,word ptr SS:[BP-12]
17D3:0C01 push AX
17D3:0C02 mov ES,word ptr DS:[0x56D0]
17D3:0C06 push word ptr ES:[0x39A0]
17D3:0C0B call far 19FC:2B87
17D3:0C10 add SP,8
17D3:0C13 call far 017D:2A2B
17D3:0C18 jmp near 0x0CEB
17D3:0C1B call far 18BA:0259
17D3:0C20 mov word ptr SS:[BP-8],AX
17D3:0C23 push AX
17D3:0C24 push CS
17D3:0C25 call near 0x0D1D
17D3:0C28 add SP,2
17D3:0C2B mov word ptr SS:[BP-8],AX
17D3:0C2E cmp AX,0x000D
17D3:0C31 je short 0x0C38
17D3:0C33 cmp AX,0x0020
17D3:0C36 jne short 0x0C40
17D3:0C38 mov word ptr SS:[BP-2],0
17D3:0C3D jmp near 0x0CEB
17D3:0C40 cmp word ptr SS:[BP-8],-72
17D3:0C44 je short 0x0C4F
17D3:0C46 cmp word ptr SS:[BP-8],-80
17D3:0C4A je short 0x0C4F
17D3:0C4C jmp near 0x0CEB
17D3:0C4F mov SI,word ptr SS:[BP+6]
17D3:0C52 mov CL,4
17D3:0C54 shl SI,CL
17D3:0C56 mov ES,word ptr DS:[0x56DE]
17D3:0C5A push word ptr ES:[SI+0x009C]
17D3:0C5F push word ptr ES:[SI+0x0094]
17D3:0C64 mov AX,word ptr SS:[BP-10]
17D3:0C67 add AX,word ptr SS:[BP-12]
17D3:0C6A push AX
17D3:0C6B mov ES,word ptr DS:[0x56D0]
17D3:0C6F push word ptr ES:[0x39A0]
17D3:0C74 call far 19FC:2B87
17D3:0C79 add SP,8
17D3:0C7C cmp word ptr SS:[BP-8],-72
17D3:0C80 jne short 0x0C85
17D3:0C82 dec word ptr SS:[BP-12]
17D3:0C85 cmp word ptr SS:[BP-8],-80
17D3:0C89 jne short 0x0C8E
17D3:0C8B inc word ptr SS:[BP-12]
17D3:0C8E cmp word ptr SS:[BP-12],0
17D3:0C92 jge short 0x0CA8
17D3:0C94 mov BX,word ptr SS:[BP+6]
17D3:0C97 mov CL,4
17D3:0C99 shl BX,CL
17D3:0C9B mov ES,word ptr DS:[0x56DE]
17D3:0C9F mov AX,word ptr ES:[BX+0x0096]
17D3:0CA4 dec AX
17D3:0CA5 mov word ptr SS:[BP-12],AX
17D3:0CA8 mov AX,word ptr SS:[BP-12]
17D3:0CAB mov BX,word ptr SS:[BP+6]
17D3:0CAE mov CL,4
17D3:0CB0 shl BX,CL
17D3:0CB2 mov ES,word ptr DS:[0x56DE]
17D3:0CB6 cmp word ptr ES:[BX+0x0096],AX
17D3:0CBB jg short 0x0CC2
17D3:0CBD mov word ptr SS:[BP-12],0
17D3:0CC2 mov SI,word ptr SS:[BP+6]
17D3:0CC5 mov CL,4
17D3:0CC7 shl SI,CL
17D3:0CC9 push word ptr ES:[SI+0x009C]
17D3:0CCE push word ptr ES:[SI+0x0094]
17D3:0CD3 mov AX,word ptr SS:[BP-10]
17D3:0CD6 add AX,word ptr SS:[BP-12]
17D3:0CD9 push AX
17D3:0CDA mov ES,word ptr DS:[0x56D0]
17D3:0CDE push word ptr ES:[0x39A0]
17D3:0CE3 call far 19FC:2B87
17D3:0CE8 add SP,8
17D3:0CEB cmp word ptr SS:[BP-2],0
17D3:0CEF je short 0x0CF4
17D3:0CF1 jmp near 0x0C1B
17D3:0CF4 cmp word ptr SS:[BP-8],0x001B
17D3:0CF8 je short 0x0D0F
17D3:0CFA mov AX,word ptr SS:[BP-12]
17D3:0CFD mov BX,word ptr SS:[BP+6]
17D3:0D00 mov CL,4
17D3:0D02 shl BX,CL
17D3:0D04 mov ES,word ptr DS:[0x56DE]
17D3:0D08 mov word ptr ES:[BX+0x0098],AX
17D3:0D0D jmp short 0x0D15
17D3:0D0F mov AX,word ptr SS:[BP-4]
17D3:0D12 mov word ptr SS:[BP-12],AX
17D3:0D15 mov AX,word ptr SS:[BP-12]
17D3:0D18 pop SI
17D3:0D19 mov SP,BP
17D3:0D1B pop BP
17D3:0D1C ret far
17D3:0D1D push BP
17D3:0D1E mov BP,SP
17D3:0D20 xor AX,AX
17D3:0D22 call far 19FC:2FDC
17D3:0D27 mov AX,word ptr SS:[BP+6]
17D3:0D2A cmp AX,0x0041
17D3:0D2D je short 0x0D69
17D3:0D2F jle short 0x0D34
17D3:0D31 jmp near 0x0DDD
17D3:0D34 cmp AX,0xFFB9
17D3:0D37 je short 0x0D79
17D3:0D39 jg short 0x0DA8
17D3:0D3B cmp AX,0xFFB1
17D3:0D3E je short 0x0D51
17D3:0D40 jg short 0x0D91
17D3:0D42 cmp AX,0xFF0C
17D3:0D45 je short 0x0D71
17D3:0D47 cmp AX,0xFFAF
17D3:0D4A je short 0x0D61
17D3:0D4C cmp AX,0xFFB0
17D3:0D4F jmp short 0x0DBC
17D3:0D51 mov word ptr SS:[BP+6],0xFFB1
17D3:0D56 jmp near 0x0E71
17D3:0D59 mov word ptr SS:[BP+6],0xFFB0
17D3:0D5E jmp near 0x0E71
17D3:0D61 mov word ptr SS:[BP+6],0xFFAF
17D3:0D66 jmp near 0x0E71
17D3:0D69 mov word ptr SS:[BP+6],0xFFB5
17D3:0D6E jmp near 0x0E71
17D3:0D71 mov word ptr SS:[BP+6],0xFFB3
17D3:0D76 jmp near 0x0E71
17D3:0D79 mov word ptr SS:[BP+6],0xFFB9
17D3:0D7E jmp near 0x0E71
17D3:0D81 mov word ptr SS:[BP+6],0xFFB8
17D3:0D86 jmp near 0x0E71
17D3:0D89 mov word ptr SS:[BP+6],0xFFB7
17D3:0D8E jmp near 0x0E71
17D3:0D91 cmp AX,0xFFB3
17D3:0D94 je short 0x0D71
17D3:0D96 cmp AX,0xFFB5
17D3:0D99 je short 0x0D69
17D3:0D9B cmp AX,0xFFB7
17D3:0D9E je short 0x0D89
17D3:0DA0 cmp AX,0xFFB8
17D3:0DA3 je short 0x0D81
17D3:0DA5 jmp near 0x0E71
17D3:0DA8 cmp AX,0x0033
17D3:0DAB je short 0x0D61
17D3:0DAD jg short 0x0DC1
17D3:0DAF cmp AX,0x000C
17D3:0DB2 je short 0x0D71
17D3:0DB4 cmp AX,0x0031
17D3:0DB7 je short 0x0D51
17D3:0DB9 cmp AX,0x0032
17D3:0DBC je short 0x0D59
17D3:0DBE jmp near 0x0E71
17D3:0DC1 cmp AX,0x0034
17D3:0DC4 je short 0x0D69
17D3:0DC6 cmp AX,0x0036
17D3:0DC9 je short 0x0D71
17D3:0DCB cmp AX,0x0037
17D3:0DCE je short 0x0D79
17D3:0DD0 cmp AX,0x0038
17D3:0DD3 je short 0x0D81
17D3:0DD5 cmp AX,0x0039
17D3:0DD8 je short 0x0D89
17D3:0DDA jmp near 0x0E71
17D3:0DDD cmp AX,0x0060
17D3:0DE0 jne short 0x0DE5
17D3:0DE2 jmp near 0x0D59
17D3:0DE5 jg short 0x0E25
17D3:0DE7 cmp AX,0x0051
17D3:0DEA je short 0x0D79
17D3:0DEC jg short 0x0E03
17D3:0DEE cmp AX,0x0043
17D3:0DF1 jne short 0x0DF6
17D3:0DF3 jmp near 0x0D61
17D3:0DF6 cmp AX,0x0044
17D3:0DF9 jne short 0x0DFE
17D3:0DFB jmp near 0x0D71
17D3:0DFE cmp AX,0x0045
17D3:0E01 jmp short 0x0DD8
17D3:0E03 cmp AX,0x0057
17D3:0E06 jne short 0x0E0B
17D3:0E08 jmp near 0x0D81
17D3:0E0B cmp AX,0x0058
17D3:0E0E jne short 0x0E13
17D3:0E10 jmp near 0x0D59
17D3:0E13 cmp AX,0x005A
17D3:0E16 jne short 0x0E1B
17D3:0E18 jmp near 0x0D51
17D3:0E1B cmp AX,0x005C
17D3:0E1E jne short 0x0E23
17D3:0E20 jmp near 0x0D79
17D3:0E23 jmp short 0x0E71
17D3:0E25 sub AX,0x0061
17D3:0E28 cmp AX,0x001D
17D3:0E2B ja short 0x0E71
17D3:0E2D add AX,AX
17D3:0E2F xchg BX,AX
17D3:0E30 jmp near word ptr CS:[BX+0x0E35]
17D3:0E71 mov AX,word ptr SS:[BP+6]
17D3:0E74 pop BP
17D3:0E75 ret far
18BA:0006 push BP
18BA:0007 mov BP,SP
18BA:0009 xor AX,AX
18BA:000B call far 19FC:2FDC
18BA:0010 jmp short 0x0023
18BA:0012 mov ES,word ptr DS:[0x56EE]
18BA:0016 push word ptr ES:[0x32AC]
18BA:001B call far 19FC:0B40
18BA:0020 add SP,2
18BA:0023 mov AX,word ptr SS:[BP+6]
18BA:0026 dec word ptr SS:[BP+6]
18BA:0029 or AX,AX
18BA:002B jne short 0x0012
18BA:002D pop BP
18BA:002E ret far
18BA:002F xor AX,AX
18BA:0031 call far 19FC:2FDC
18BA:0036 call far 19FC:3BDC
18BA:003B or AX,AX
18BA:003D jne short 0x004B
18BA:003F mov ES,word ptr DS:[0x56F0]
18BA:0043 cmp word ptr ES:[0x3938],0
18BA:0049 je short 0x0050
18BA:004B mov AX,1
18BA:004E jmp short 0x0052
18BA:0050 sub AX,AX
18BA:0052 ret far
18BA:0053 push BP
18BA:0054 mov BP,SP
18BA:0056 xor AX,AX
18BA:0058 call far 19FC:2FDC
18BA:005D mov AX,0x000A
18BA:0060 push AX
18BA:0061 mov AX,0x0012
18BA:0064 mov DX,0x2A0F
18BA:0067 push DX
18BA:0068 push AX
18BA:0069 push word ptr SS:[BP+6]
18BA:006C call far 19FC:3BB6
18BA:0071 add SP,8
18BA:0074 mov AX,0x0012
18BA:0077 mov DX,0x2A0F
18BA:007A push DX
18BA:007B push AX
18BA:007C call far 17D3:03F5
18BA:0081 add SP,4
18BA:0084 pop BP
18BA:0085 ret far
18BA:0086 push BP
18BA:0087 mov BP,SP
18BA:0089 xor AX,AX
18BA:008B call far 19FC:2FDC
18BA:0090 cmp word ptr DS:[0x4FBA],2
18BA:0095 je short 0x00B3
18BA:0097 push word ptr SS:[BP+0x10]
18BA:009A push word ptr SS:[BP+0x0E]
18BA:009D push word ptr SS:[BP+0x0C]
18BA:00A0 push word ptr SS:[BP+0x0A]
18BA:00A3 push word ptr SS:[BP+8]
18BA:00A6 push word ptr SS:[BP+6]
18BA:00A9 call far 19FC:200E
18BA:00AE add SP,0x000C
18BA:00B1 jmp short 0x00D3
18BA:00B3 push word ptr SS:[BP+0x10]
18BA:00B6 push word ptr SS:[BP+0x0E]
18BA:00B9 push word ptr SS:[BP+0x0C]
18BA:00BC push word ptr SS:[BP+0x0A]
18BA:00BF sub AX,AX
18BA:00C1 mov DX,0xA000
18BA:00C4 push DX
18BA:00C5 push AX
18BA:00C6 mov DX,0xA800
18BA:00C9 push DX
18BA:00CA push AX
18BA:00CB call far 19FC:245C
18BA:00D3 pop BP
18BA:00D4 ret far
18BA:00D5 push BP
18BA:00D6 mov BP,SP
18BA:00D8 mov AX,0x000E
18BA:00DB call far 19FC:2FDC
18BA:00E0 push word ptr SS:[BP+0x10]
18BA:00E3 push word ptr SS:[BP+0x0E]
18BA:00E6 call far 19FC:2127
18BA:00EB add SP,4
18BA:00EE mov AX,word ptr SS:[BP+6]
18BA:00F1 mov DX,word ptr SS:[BP+8]
18BA:00F4 mov word ptr SS:[BP-4],AX
18BA:00F7 mov word ptr SS:[BP-2],DX
18BA:00FA mov AX,0x0140
18BA:00FD imul word ptr SS:[BP+0x0C]
18BA:0100 mov word ptr SS:[BP-10],AX
18BA:0103 cmp word ptr DS:[0x4FBA],3
18BA:0108 jne short 0x0113
18BA:010A mov AX,0x0A00
18BA:010D imul word ptr SS:[BP+0x0C]
18BA:0110 mov word ptr SS:[BP-10],AX
18BA:0113 mov AX,word ptr SS:[BP+0x0A]
18BA:0116 mov word ptr SS:[BP-6],AX
18BA:0119 jmp near 0x01E7
18BA:011C cmp byte ptr SS:[BP-14],0x0D
18BA:0120 jne short 0x013F
18BA:0122 mov AX,word ptr SS:[BP-6]
18BA:0125 mov word ptr SS:[BP+0x0A],AX
18BA:0128 add word ptr SS:[BP-10],0x0140
18BA:012D cmp word ptr DS:[0x4FBA],3
18BA:0132 jne short 0x0139
18BA:0134 add word ptr SS:[BP-10],0x08C0
18BA:0139 inc word ptr SS:[BP-4]
18BA:013C jmp near 0x01E7
18BA:013F les BX,word ptr SS:[BP-4]
18BA:0142 inc word ptr SS:[BP-4]
18BA:0145 mov AL,byte ptr ES:[BX]
18BA:0148 and AX,0x007F
18BA:014B mov CL,3
18BA:014D shl AX,CL
18BA:014F mov word ptr SS:[BP-12],AX
18BA:0152 mov AX,word ptr DS:[0x4FB8]
18BA:0155 dec AX
18BA:0156 cmp word ptr SS:[BP+0x0A],AX
18BA:0159 jle short 0x0176
18BA:015B mov AX,word ptr SS:[BP-6]
18BA:015E mov word ptr SS:[BP+0x0A],AX
18BA:0161 inc word ptr DS:[0x4FBE]
18BA:0165 add word ptr SS:[BP-10],0x0140
18BA:016A cmp word ptr DS:[0x4FBA],3
18BA:016F jne short 0x0176
18BA:0171 add word ptr SS:[BP-10],0x08C0
18BA:0176 mov AX,word ptr SS:[BP+0x0A]
18BA:0179 inc word ptr SS:[BP+0x0A]
18BA:017C mov word ptr SS:[BP-8],AX
18BA:017F cmp word ptr DS:[0x4FBA],0
18BA:0184 jne short 0x0199
18BA:0186 shl AX,1
18BA:0188 push AX
18BA:0189 push word ptr SS:[BP-10]
18BA:018C mov AX,word ptr SS:[BP-12]
18BA:018F shl AX,1
18BA:0191 push AX
18BA:0192 call far 19FC:2209
18BA:0199 cmp word ptr DS:[0x4FBA],1
18BA:019E jne short 0x01BA
18BA:01A0 mov AX,word ptr SS:[BP-8]
18BA:01A3 shl AX,1
18BA:01A5 shl AX,1
18BA:01A7 push AX
18BA:01A8 push word ptr SS:[BP-10]
18BA:01AB mov AX,word ptr SS:[BP-12]
18BA:01AE shl AX,1
18BA:01B0 shl AX,1
18BA:01B2 push AX
18BA:01B3 call far 19FC:21A8
18BA:01BA cmp word ptr DS:[0x4FBA],2
18BA:01BF jne short 0x01D1
18BA:01C1 push word ptr SS:[BP-8]
18BA:01C4 push word ptr SS:[BP-10]
18BA:01C7 push word ptr SS:[BP-12]
18BA:01CA call far 19FC:2251
18BA:01D1 mov AX,word ptr SS:[BP-8]
18BA:01D4 mov CL,3
18BA:01D6 shl AX,CL
18BA:01D8 push AX
18BA:01D9 push word ptr SS:[BP-10]
18BA:01DC push word ptr SS:[BP-12]
18BA:01DF call far 19FC:22A5
18BA:01E4 add SP,6
18BA:01E7 les BX,word ptr SS:[BP-4]
18BA:01EA mov AL,byte ptr ES:[BX]
18BA:01ED mov byte ptr SS:[BP-14],AL
18BA:01F0 or AL,AL
18BA:01F2 je short 0x01F7
18BA:01F4 jmp near 0x011C
18BA:01F7 mov SP,BP
18BA:01F9 pop BP
18BA:01FA ret far
18BA:01FB push BP
18BA:01FC mov BP,SP
18BA:01FE xor AX,AX
18BA:0200 call far 19FC:2FDC
18BA:0205 test byte ptr SS:[BP+6],1
18BA:0209 jne short 0x0218
18BA:020B test byte ptr SS:[BP+0x0A],1
18BA:020F je short 0x0218
18BA:0211 cmp word ptr DS:[0x4FBA],1
18BA:0216 je short 0x0236
18BA:0218 mov AX,word ptr SS:[BP+8]
18BA:021B cmp word ptr SS:[BP+0x0C],AX
18BA:021E jl short 0x0257
18BA:0220 push word ptr SS:[BP+0x0E]
18BA:0223 push word ptr SS:[BP+0x0A]
18BA:0226 push word ptr SS:[BP+6]
18BA:0229 push AX
18BA:022A inc word ptr SS:[BP+8]
18BA:022D push CS
18BA:022E call near 0x03EB
18BA:0231 add SP,8
18BA:0234 jmp short 0x0218
18BA:0236 push word ptr SS:[BP+0x0E]
18BA:0239 mov AX,word ptr SS:[BP+0x0C]
18BA:023C sub AX,word ptr SS:[BP+8]
18BA:023F push AX
18BA:0240 mov AX,word ptr SS:[BP+0x0A]
18BA:0243 sub AX,word ptr SS:[BP+6]
18BA:0246 sar AX,1
18BA:0248 push AX
18BA:0249 push word ptr SS:[BP+8]
18BA:024C push word ptr SS:[BP+6]
18BA:024F call far 19FC:08A1
18BA:0257 pop BP
18BA:0258 ret far
18BA:0259 push BP
18BA:025A mov BP,SP
18BA:025C mov AX,4
18BA:025F call far 19FC:2FDC
18BA:0264 mov ES,word ptr DS:[0x56F0]
18BA:0268 cmp word ptr ES:[0x3938],0
18BA:026E jne short 0x02C1
18BA:0270 call far 19FC:0B8A
18BA:0275 mov word ptr SS:[BP-4],AX
18BA:0278 mov ES,word ptr DS:[0x56F2]
18BA:027C cmp word ptr ES:[0x458C],0
18BA:0282 jne short 0x0287
18BA:0284 jmp near 0x0318
18BA:0287 cmp AX,0x0068
18BA:028A jne short 0x0291
18BA:028C mov word ptr SS:[BP-4],0x0048
18BA:0291 mov AL,byte ptr SS:[BP-4]
18BA:0294 mov ES,word ptr DS:[0x56F4]
18BA:0298 mov BX,word ptr ES:[0x39F8]
18BA:029D inc word ptr ES:[0x39F8]
18BA:02A2 mov ES,word ptr DS:[0x56F6]
18BA:02A6 mov byte ptr ES:[BX+0x00A0],AL
18BA:02AB cmp word ptr SS:[BP-4],0x0048
18BA:02AF je short 0x0270
18BA:02B1 mov AX,word ptr SS:[BP-4]
18BA:02B4 jmp short 0x0318
18BA:02B6 mov AX,0x001E
18BA:02B9 push AX
18BA:02BA push CS
18BA:02BB call near 6
18BA:02C1 mov ES,word ptr DS:[0x56F4]
18BA:02C5 mov BX,word ptr ES:[0x39F8]
18BA:02CA inc word ptr ES:[0x39F8]
18BA:02CF mov ES,word ptr DS:[0x56F6]
18BA:02D3 mov AL,byte ptr ES:[BX+0x00A0]
18BA:02D8 cbw
18BA:02D9 mov word ptr SS:[BP-4],AX
18BA:02DC cmp AX,0x0048
18BA:02DF je short 0x02B6
18BA:02E1 call far 19FC:3BDC
18BA:0318 mov SP,BP
18BA:031A pop BP
18BA:031B ret far
18BA:031C push BP
18BA:031D mov BP,SP
18BA:031F mov AX,2
18BA:0322 call far 19FC:2FDC
18BA:0327 mov AX,word ptr SS:[BP+6]
18BA:032A cmp word ptr SS:[BP+0x0A],AX
18BA:032D jge short 0x033E
18BA:032F mov word ptr SS:[BP-2],AX
18BA:0332 mov AX,word ptr SS:[BP+0x0A]
18BA:0335 mov word ptr SS:[BP+6],AX
18BA:0338 mov AX,word ptr SS:[BP-2]
18BA:033B mov word ptr SS:[BP+0x0A],AX
18BA:033E mov AX,word ptr SS:[BP+8]
18BA:0341 cmp word ptr SS:[BP+0x0C],AX
18BA:0344 jge short 0x0355
18BA:0346 mov word ptr SS:[BP-2],AX
18BA:0349 mov AX,word ptr SS:[BP+0x0C]
18BA:034C mov word ptr SS:[BP+8],AX
18BA:034F mov AX,word ptr SS:[BP-2]
18BA:0352 mov word ptr SS:[BP+0x0C],AX
18BA:0355 cmp word ptr SS:[BP+6],0
18BA:0359 jge short 0x0360
18BA:035B mov word ptr SS:[BP+6],0
18BA:0360 cmp word ptr SS:[BP+8],0
18BA:0364 jge short 0x036B
18BA:0366 mov word ptr SS:[BP+8],0
18BA:036B cmp word ptr SS:[BP+0x0A],0
18BA:036F jge short 0x0376
18BA:0371 mov word ptr SS:[BP+0x0A],0
18BA:0376 cmp word ptr SS:[BP+0x0C],0
18BA:037A jge short 0x0381
18BA:037C mov word ptr SS:[BP+0x0C],0
18BA:0381 cmp word ptr SS:[BP+6],0x013F
18BA:0386 jle short 0x038D
18BA:0388 mov word ptr SS:[BP+6],0x013F
18BA:038D cmp word ptr SS:[BP+0x0A],0x013F
18BA:0392 jle short 0x0399
18BA:0394 mov word ptr SS:[BP+0x0A],0x013F
18BA:0399 cmp word ptr SS:[BP+8],0x00C7
18BA:039E jle short 0x03A5
18BA:03A0 mov word ptr SS:[BP+8],0x00C7
18BA:03A5 cmp word ptr SS:[BP+0x0C],0x00C7
18BA:03AA jle short 0x03B1
18BA:03AC mov word ptr SS:[BP+0x0C],0x00C7
18BA:03B1 mov AX,word ptr SS:[BP+0x0A]
18BA:03B4 cmp word ptr SS:[BP+6],AX
18BA:03B7 jne short 0x03CC
18BA:03B9 push word ptr SS:[BP+0x0E]
18BA:03BC push word ptr SS:[BP+0x0C]
18BA:03BF push word ptr SS:[BP+8]
18BA:03C2 push word ptr SS:[BP+6]
18BA:03C5 call far 19FC:05D0
18BA:03CA jmp short 0x03E4
18BA:03CC mov AX,word ptr SS:[BP+0x0C]
18BA:03CF cmp word ptr SS:[BP+8],AX
18BA:03D2 jne short 0x03E7
18BA:03D4 push word ptr SS:[BP+0x0E]
18BA:03D7 push word ptr SS:[BP+0x0A]
18BA:03DA push word ptr SS:[BP+6]
18BA:03DD push word ptr SS:[BP+8]
18BA:03E0 push CS
18BA:03E1 call near 0x03EB
18BA:03E4 add SP,8
18BA:03E7 mov SP,BP
18BA:03E9 pop BP
18BA:03EA ret far
18BA:03EB push BP
18BA:03EC mov BP,SP
18BA:03EE mov AX,4
18BA:03F1 call far 19FC:2FDC
18BA:03F6 mov BX,word ptr DS:[0x4FBA]
18BA:03FA shl BX,1
18BA:03FC mov AX,word ptr DS:[BX+0x4FC4]
18BA:0400 mov word ptr SS:[BP-4],AX
18BA:0403 jmp short 0x0424
18BA:0405 mov AX,word ptr SS:[BP+0x0A]
18BA:0408 cmp word ptr SS:[BP+8],AX
18BA:040B jg short 0x042C
18BA:040D push word ptr SS:[BP+0x0C]
18BA:0410 push word ptr SS:[BP+6]
18BA:0413 push word ptr SS:[BP+6]
18BA:0416 push word ptr SS:[BP+8]
18BA:0419 inc word ptr SS:[BP+8]
18BA:041C call far 19FC:05D0
18BA:0424 mov AX,word ptr SS:[BP-4]
18BA:0427 and word ptr SS:[BP+8],AX
18BA:042A jne short 0x0405
18BA:042C mov AX,word ptr SS:[BP+0x0A]
18BA:042F cmp word ptr SS:[BP+8],AX
18BA:0432 jge short 0x0491
18BA:0434 sub AX,word ptr SS:[BP+8]
18BA:0437 mov word ptr SS:[BP-2],AX
18BA:043A cmp word ptr DS:[0x4FBA],3
18BA:043F je short 0x044E
18BA:0441 mov BX,word ptr DS:[0x4FBA]
18BA:0445 shl BX,1
18BA:0447 mov CL,byte ptr DS:[BX+0x4FD4]
18BA:044B sar word ptr SS:[BP-2],CL
18BA:044E cmp word ptr SS:[BP-2],0
18BA:0452 je short 0x0468
18BA:0454 push word ptr SS:[BP+0x0C]
18BA:0457 push word ptr SS:[BP-2]
18BA:045A push word ptr SS:[BP+6]
18BA:045D push word ptr SS:[BP+8]
18BA:0460 call far 19FC:0780
18BA:0465 add SP,8
18BA:0468 mov BX,word ptr DS:[0x4FBA]
18BA:046C shl BX,1
18BA:046E mov AX,word ptr DS:[BX+0x4FCC]
18BA:0472 and AX,word ptr SS:[BP+0x0A]
18BA:0475 mov word ptr SS:[BP+8],AX
18BA:0478 jmp short 0x0491
18BA:047A push word ptr SS:[BP+0x0C]
18BA:047D push word ptr SS:[BP+6]
18BA:0480 push word ptr SS:[BP+6]
18BA:0483 push word ptr SS:[BP+8]
18BA:0486 inc word ptr SS:[BP+8]
18BA:0489 call far 19FC:05D0
18BA:048E add SP,8
18BA:0491 mov AX,word ptr SS:[BP+0x0A]
18BA:0494 cmp word ptr SS:[BP+8],AX
18BA:0497 jle short 0x047A
18BA:0499 mov SP,BP
18BA:049B pop BP
18BA:049C ret far
18BA:049D push BP
18BA:049E mov BP,SP
18BA:04A0 mov AX,4
18BA:04A3 call far 19FC:2FDC
18BA:04A8 les BX,word ptr SS:[BP+6]
18BA:04AB inc word ptr SS:[BP+6]
18BA:04AE cmp byte ptr ES:[BX],1
18BA:04B2 jne short 0x04C5
18BA:04B4 push word ptr SS:[BP+0x0C]
18BA:04B7 push word ptr SS:[BP+0x0A]
18BA:04BA push ES
18BA:04BB push word ptr SS:[BP+6]
18BA:04BE call far 19FC:22F8
18BA:04C3 jmp short 0x04D6
18BA:04C5 push word ptr SS:[BP+0x0C]
18BA:04C8 push word ptr SS:[BP+0x0A]
18BA:04CB push word ptr SS:[BP+8]
18BA:04CE push word ptr SS:[BP+6]
18BA:04D1 call far 19FC:2368
18BA:04D6 add SP,8
18BA:04D9 cmp word ptr DS:[0x4FBA],0
18BA:04DE jne short 0x0521
18BA:04E0 mov word ptr SS:[BP-4],0x0050
18BA:04E5 cmp word ptr DS:[0x4FBC],0
18BA:04EA je short 0x04F1
18BA:04EC mov word ptr SS:[BP-4],4
18BA:04F1 mov AX,0x3E80
18BA:04F4 push AX
18BA:04F5 push word ptr SS:[BP-4]
18BA:04F8 push word ptr SS:[BP+0x0C]
18BA:04FB push word ptr SS:[BP+0x0A]
18BA:04FE push word ptr SS:[BP+0x0C]
18BA:0501 push word ptr SS:[BP+0x0A]
18BA:0504 call far 19FC:0163
18BA:0521 mov SP,BP
18BA:0523 pop BP
18BA:0524 ret far
18BA:0525 push BP
18BA:0526 mov BP,SP
18BA:0528 mov AX,4
18BA:052B call far 19FC:2FDC
18BA:0530 push SI
18BA:0531 cmp word ptr DS:[0x4FBA],1
18BA:0536 jne short 0x0556
18BA:0538 mov ES,word ptr DS:[0x56EE]
18BA:053C push word ptr ES:[0x32AC]
18BA:0541 call far 19FC:0B40
18BA:0556 cmp word ptr DS:[0x4FBA],2
18BA:055B jne short 0x05A2
18BA:055D mov ES,word ptr DS:[0x56EE]
18BA:0561 push word ptr ES:[0x32AC]
18BA:0566 call far 19FC:0B40
18BA:05A2 cmp word ptr DS:[0x4FBA],3
18BA:05A7 jne short 0x05B7
18BA:05A9 push word ptr SS:[BP+8]
18BA:05AC push word ptr SS:[BP+6]
18BA:05AF call far 19FC:0FEE
18BA:05B4 add SP,4
18BA:05B7 pop SI
18BA:05B8 mov SP,BP
18BA:05BA pop BP
18BA:05BB ret far
18BA:05BC push BP
18BA:05BD mov BP,SP
18BA:05BF mov AX,6
18BA:05C2 call far 19FC:2FDC
18BA:05C7 mov AX,word ptr SS:[BP+6]
18BA:05CA mov word ptr SS:[BP-2],AX
18BA:05CD cmp word ptr SS:[BP+8],0
18BA:05D1 jl short 0x05FA
18BA:05D3 jg short 0x05DA
18BA:05D5 cmp AX,0xFFFF
18BA:05D8 jbe short 0x05FA
18BA:05DA sub AX,AX
18BA:05DC push AX
18BA:05DD mov AX,0x000F
18BA:05E0 push AX
18BA:05E1 mov AX,0x000A
18BA:05E4 push AX
18BA:05E5 sub AX,AX
18BA:05E7 push AX
18BA:05E8 mov AX,0x4FDA
18BA:05EB push DS
18BA:05EC push AX
18BA:05ED push CS
18BA:05EE call near 0x00D5
18BA:05FA push word ptr SS:[BP-2]
18BA:05FD call far 19FC:3835
18BA:0602 add SP,2
18BA:0605 mov word ptr SS:[BP-6],AX
18BA:0608 mov word ptr SS:[BP-4],DX
18BA:060B mov AX,word ptr SS:[BP-6]
18BA:060E or AX,word ptr SS:[BP-4]
18BA:0611 jne short 0x0631
18BA:0613 sub AX,AX
18BA:0615 push AX
18BA:0616 mov AX,0x000F
18BA:0619 push AX
18BA:061A mov AX,0x000A
18BA:061D push AX
18BA:061E sub AX,AX
18BA:0620 push AX
18BA:0621 mov AX,0x4FE9
18BA:0624 push DS
18BA:0625 push AX
18BA:0626 push CS
18BA:0627 call near 0x00D5
18BA:0631 mov AX,word ptr SS:[BP-6]
18BA:0634 mov DX,word ptr SS:[BP-4]
18BA:0637 mov SP,BP
18BA:0639 pop BP
18BA:063A ret far
18BA:063B push BP
18BA:063C mov BP,SP
18BA:063E mov AX,6
18BA:0641 call far 19FC:2FDC
18BA:0646 mov word ptr SS:[BP-4],0
18BA:064B mov AX,0x8000
18BA:064E push AX
18BA:064F push word ptr SS:[BP+8]
18BA:0652 push word ptr SS:[BP+6]
18BA:0655 call far 19FC:33D0
18BA:065A add SP,6
18BA:065D mov word ptr SS:[BP-6],AX
18BA:0660 cmp AX,0xFFFF
18BA:0663 je short 0x069A
18BA:0665 mov AX,2
18BA:0668 push AX
18BA:0669 lea AX,BP-2
18BA:066C push SS
18BA:066D push AX
18BA:066E push word ptr SS:[BP-6]
18BA:0671 call far 19FC:3580
18BA:0676 add SP,8
18BA:0679 push word ptr SS:[BP-2]
18BA:067C push word ptr SS:[BP+0x0C]
18BA:067F push word ptr SS:[BP+0x0A]
18BA:0682 push word ptr SS:[BP-6]
18BA:0685 call far 19FC:3580
18BA:068A add SP,8
18BA:068D push word ptr SS:[BP-6]
18BA:0690 call far 19FC:3336
18BA:0695 add SP,2
18BA:0698 jmp short 0x069F
18BA:069A mov word ptr SS:[BP-4],1
18BA:069F cmp word ptr SS:[BP-4],0
18BA:06A3 je short 0x06B6
18BA:06A5 mov ES,word ptr DS:[0x56FA]
18BA:06A9 push word ptr ES:[0x014E]
18BA:06AE call far 017D:2913
18BA:06B6 cmp word ptr SS:[BP-4],0
18BA:06BA jne short 0x0646
18BA:06BC mov AX,1
18BA:06BF mov SP,BP
18BA:06C1 pop BP
18BA:06C2 ret far
18BA:06C3 xor AX,AX
18BA:06C5 call far 19FC:2FDC
18BA:06CA cmp word ptr DS:[0x4FBA],2
18BA:06CF jne short 0x06F6
18BA:06D1 mov AX,0x00C8
18BA:06D4 push AX
18BA:06D5 mov AX,0x001B
18BA:06D8 push AX
18BA:06D9 sub AX,AX
18BA:06DB push AX
18BA:06DC mov AX,0x000D
18BA:06DF push AX
18BA:06E0 sub AX,AX
18BA:06E2 mov DX,0xA000
18BA:06E5 push DX
18BA:06E6 push AX
18BA:06E7 mov DX,0xAC00
18BA:06EA push DX
18BA:06EB push AX
18BA:06EC call far 19FC:245C
18BA:06F6 cmp word ptr DS:[0x4FBA],3
18BA:06FB jne short 0x0704
18BA:06FD call far 19FC:1D3A
18BA:0702 jmp short 0x0709
18BA:0704 call far 19FC:1CB8
18BA:0709 ret far
18BA:070A push BP
18BA:070B mov BP,SP
18BA:070D mov AX,8
18BA:0710 call far 19FC:2FDC
18BA:0715 push SI
18BA:0716 mov word ptr SS:[BP-6],4
18BA:071B mov AX,word ptr SS:[BP+0x0C]
18BA:071E imul word ptr SS:[BP+0x0E]
18BA:0721 mul word ptr SS:[BP-6]
18BA:0724 mov word ptr SS:[BP-6],AX
18BA:0727 add AX,4
18BA:072A sub CX,CX
18BA:072C push CX
18BA:072D push AX
18BA:072E push CS
18BA:072F call near 0x05BC
18BA:0732 add SP,4
18BA:0735 mov BX,word ptr SS:[BP+6]
18BA:0738 shl BX,1
18BA:073A shl BX,1
18BA:073C mov ES,word ptr DS:[0x56FC]
18BA:0740 mov word ptr ES:[BX+0x39FA],AX
18BA:0745 mov word ptr ES:[BX+0x39FC],DX
18BA:074A mov word ptr SS:[BP-4],AX
18BA:074D mov word ptr SS:[BP-2],DX
18BA:0750 or AX,DX
18BA:0752 jne short 0x0757
18BA:0754 jmp near 0x080F
18BA:0757 les BX,word ptr SS:[BP-4]
18BA:075A mov AL,byte ptr SS:[BP+0x0E]
18BA:075D dec AL
18BA:075F mov byte ptr ES:[BX+1],AL
18BA:0763 les BX,word ptr SS:[BP-4]
18BA:0766 mov AL,byte ptr SS:[BP+0x0C]
18BA:0769 mov byte ptr ES:[BX+2],AL
18BA:076D cmp word ptr DS:[0x4FBA],0
18BA:0772 jne short 0x0787
18BA:0774 shl word ptr SS:[BP+8],1
18BA:0777 mov AX,0x0050
18BA:077A imul word ptr SS:[BP+0x0A]
18BA:077D mov word ptr SS:[BP+0x0A],AX
18BA:0780 mov word ptr SS:[BP-8],0x0050
18BA:0785 jmp short 0x079D
18BA:0787 mov CL,2
18BA:0789 shl word ptr SS:[BP+8],CL
18BA:078C mov AX,0x00A0
18BA:078F imul word ptr SS:[BP+0x0A]
18BA:0792 mov word ptr SS:[BP+0x0A],AX
18BA:0795 shl word ptr SS:[BP+0x0C],1
18BA:0798 mov word ptr SS:[BP-8],0x00A0
18BA:079D mov AX,word ptr SS:[BP-8]
18BA:07A0 mov CX,word ptr SS:[BP+0x0C]
18BA:07A3 shl CX,1
18BA:07A5 sub AX,CX
18BA:07A7 push AX
18BA:07A8 push word ptr SS:[BP+0x0E]
18BA:07AB push word ptr SS:[BP+0x0C]
18BA:07AE mov AX,word ptr SS:[BP-4]
18BA:07B1 mov DX,word ptr SS:[BP-2]
18BA:07B4 add AX,4
18BA:07B7 push DX
18BA:07B8 push AX
18BA:07B9 mov SI,word ptr SS:[BP+0x0A]
18BA:07BC mov BX,word ptr SS:[BP+8]
18BA:07BF lea AX,BX+SI+0x244B
18BA:07C3 mov DX,0x1DE9
18BA:07C6 push DX
18BA:07C7 push AX
18BA:07C8 call far 19FC:0931
18BA:07CD add SP,0x000E
18BA:07D0 cmp word ptr DS:[0x4FBA],0
18BA:07D5 jne short 0x080F
18BA:07D7 mov AX,word ptr SS:[BP-8]
18BA:07DA mov CX,word ptr SS:[BP+0x0C]
18BA:07DD shl CX,1
18BA:07DF sub AX,CX
18BA:07E1 push AX
18BA:07E2 push word ptr SS:[BP+0x0E]
18BA:07E5 push word ptr SS:[BP+0x0C]
18BA:07E8 mov AX,word ptr SS:[BP-6]
18BA:07EB shr AX,1
18BA:07ED add AX,word ptr SS:[BP-4]
18BA:07F0 mov DX,word ptr SS:[BP-2]
18BA:07F3 add AX,4
18BA:07F6 push DX
18BA:07F7 push AX
18BA:07F8 mov SI,word ptr SS:[BP+0x0A]
18BA:07FB mov BX,word ptr SS:[BP+8]
18BA:07FE lea AX,BX+SI+0x4614
18BA:0802 mov DX,0x2A0F
18BA:0805 push DX
18BA:0806 push AX
18BA:0807 call far 19FC:0931
18BA:080F pop SI
18BA:0810 mov SP,BP
18BA:0812 pop BP
18BA:0813 ret far
18BA:0814 push BP
18BA:0815 mov BP,SP
18BA:0817 mov AX,2
18BA:081A call far 19FC:2FDC
18BA:081F jmp short 0x0832
18BA:0821 mov ES,word ptr DS:[0x56FA]
18BA:0825 push word ptr ES:[0x014E]
18BA:082A call far 017D:2913
18BA:0832 mov AX,0x8000
18BA:0835 push AX
18BA:0836 push word ptr SS:[BP+8]
18BA:0839 push word ptr SS:[BP+6]
18BA:083C call far 19FC:33D0
18BA:0841 add SP,6
18BA:0844 mov word ptr SS:[BP-2],AX
18BA:0847 inc AX
18BA:0848 je short 0x0821
18BA:084A push word ptr SS:[BP+0x0E]
18BA:084D push word ptr SS:[BP+0x0C]
18BA:0850 push word ptr SS:[BP+0x0A]
18BA:0853 push word ptr SS:[BP-2]
18BA:0856 call far 19FC:3580
18BA:085B add SP,8
18BA:085E push word ptr SS:[BP-2]
18BA:0861 call far 19FC:3336
18BA:0866 mov SP,BP
18BA:0868 pop BP
18BA:0869 ret far
18BA:086A xor AX,AX
18BA:086C call far 19FC:2FDC
18BA:0871 mov AX,0x0032
18BA:0874 push AX
18BA:0875 push CS
18BA:0876 call near 6
18BA:0879 add SP,2
18BA:087C call far 017D:2A2B
18BA:0881 ret far
19C8:0020 call far dword ptr CS:[0x0016]
19C8:0025 push AX
19C8:0026 mov AX,word ptr CS:[0x000E]
19C8:002A cmp AL,0
19C8:002C jne short 0x003C
19C8:002E mov AX,word ptr CS:[0x0010]
19C8:0032 mov word ptr CS:[0x000E],AX
19C8:0036 pop AX
19C8:0037 jmp far dword ptr CS:[0x0012]
19C8:003C dec AL
19C8:003E mov word ptr CS:[0x000E],AX
19C8:0042 mov AL,0x20
19C8:0044 out 0x20,AL
19C8:0046 pop AX
19C8:0047 iret
19C8:0048 push DS
19C8:0049 mov AX,0
19C8:004C mov DS,AX
19C8:004E mov AX,word ptr DS:[0x0020]
19C8:0051 mov word ptr CS:[0x0012],AX
19C8:0055 mov AX,word ptr DS:[0x0022]
19C8:0058 mov word ptr CS:[0x0014],AX
19C8:005C mov word ptr CS:[0x0010],0x0010
19C8:0063 mov word ptr CS:[0x000E],0
19C8:006A mov AX,0x0186
19C8:006D mov word ptr CS:[0x0016],AX
19C8:0071 push CS
19C8:0072 pop AX
19C8:0073 mov word ptr CS:[0x0018],AX
19C8:0077 mov DX,0x0020
19C8:007A push CS
19C8:007B pop DS
19C8:007C mov AH,0x25
19C8:007E mov AL,8
19C8:0080 int 0x21
19C8:0082 mov AL,0x36
19C8:0084 out 0x43,AL
19C8:0086 mov AX,0x0FFF
19C8:0089 out 0x40,AL
19C8:008B mov AL,AH
19C8:008D out 0x40,AL
19C8:008F pop DS
19C8:0090 ret far
19C8:0091 push DS
19C8:0092 mov DX,word ptr CS:[0x0012]
19C8:0097 mov AX,word ptr CS:[0x0014]
19C8:009B push AX
19C8:009C pop DS
19C8:009D mov AH,0x25
19C8:009F mov AL,8
19C8:00A1 int 0x21
19C8:00A3 mov AL,0x36
19C8:00A5 out 0x43,AL
19C8:00A7 mov AX,0xFFFF
19C8:00AA out 0x40,AL
19C8:00AC mov AL,AH
19C8:00AE out 0x40,AL
19C8:00B0 pop DS
19C8:00B1 ret far
19C8:00B2 push AX
19C8:00B3 mov AL,CL
19C8:00B5 out 0x42,AL
19C8:00B7 mov AL,CH
19C8:00B9 out 0x42,AL
19C8:00BB pop AX
19C8:00BC ret near
19C8:00BD push AX
19C8:00BE in AL,0x61
19C8:00C0 or AL,3
19C8:00C2 out 0x61,AL
19C8:00C4 pop AX
19C8:00C5 ret near
19C8:00C6 push AX
19C8:00C7 in AL,0x61
19C8:00C9 and AL,0xFC
19C8:00CB out 0x61,AL
19C8:00CD pop AX
19C8:00CE ret near
19C8:00CF push DX
19C8:00D0 push AX
19C8:00D1 mov DX,0x0012
19C8:00D4 mov AX,0x34DE
19C8:00D7 div CX
19C8:00D9 mov CX,AX
19C8:00DB pop AX
19C8:00DC pop DX
19C8:00DD ret near
19C8:0139 push CX
19C8:013A push BX
19C8:013B push AX
19C8:013C mov AH,0
19C8:013E mov CL,0x0C
19C8:0140 div CL
19C8:0142 mov DL,AL
19C8:0144 mov AL,AH
19C8:0146 cbw
19C8:0147 shl AX,1
19C8:0149 mov BX,AX
19C8:014B mov CX,word ptr CS:[BX+0x0121]
19C8:0150 call near 0x00CF
19C8:0179 push AX
19C8:017A mov AX,0x0186
19C8:017D mov word ptr CS:[0x0016],AX
19C8:0181 call near 0x00C6
19C8:0184 pop AX
19C8:0185 ret near
19C8:0186 ret far
19C8:0233 mov AX,word ptr SS:[BP+8]
19C8:0236 mov word ptr CS:[0x0205],AX
19C8:023A mov AX,word ptr SS:[BP+0x0A]
19C8:023D mov word ptr CS:[0x0207],AX
19C8:0241 mov AX,word ptr SS:[BP+0x0C]
19C8:0244 mov byte ptr CS:[0x020A],AL
19C8:0248 mov byte ptr CS:[0x0209],1
19C8:024E ret near
19C8:0298 dec byte ptr CS:[0x0209]
19C8:029D cmp byte ptr CS:[0x0209],0
19C8:02A3 jne short 0x02DC
19C8:02A5 push AX
19C8:02A6 mov AL,byte ptr CS:[0x020A]
19C8:02AA mov byte ptr CS:[0x0209],AL
19C8:02AE push DS
19C8:02AF push SI
19C8:02B0 lds SI,word ptr CS:[0x0205]
19C8:02B5 lods AL,byte ptr DS:[SI]
19C8:02B6 cmp AL,0
19C8:02B8 jne short 0x02BF
19C8:02BA lods AL,byte ptr DS:[SI]
19C8:02BB cmp AL,0
19C8:02BD je short 0x02DD
19C8:02BF mov word ptr CS:[0x0205],SI
19C8:02C4 pop SI
19C8:02C5 pop DS
19C8:02C6 push DX
19C8:02C7 push CX
19C8:02C8 test AL,0x80
19C8:02CA je short 0x02D1
19C8:02CC mov CX,0x000E
19C8:02CF jmp short 0x02D6
19C8:02D1 call near 0x0139
19C8:02D6 call near 0x00B2
19C8:02D9 pop CX
19C8:02DA pop DX
19C8:02DB pop AX
19C8:02DC ret far
19C8:02DD pop SI
19C8:02DE pop DS
19C8:02DF pop AX
19C8:02E0 call near 0x0179
19C8:02E4 push BP
19C8:02E5 mov BP,SP
19C8:02E7 mov BX,word ptr SS:[BP+6]
19C8:02EA cmp BX,0x000D
19C8:02ED jge short 0x0304
19C8:02EF add BX,BX
19C8:02F1 add BX,BX
19C8:02F3 call near 0x00BD
19C8:0304 pop BP
19C8:0305 ret far
19C8:0306 push BP
19C8:0307 mov BP,SP
19C8:0309 mov BX,word ptr SS:[BP+6]
19C8:030C cmp BX,0x000D
19C8:030F jge short 0x0326
19C8:0311 add BX,BX
19C8:0313 add BX,BX
19C8:0315 call near 0x00BD
19C8:0318 call near word ptr CS:[BX+0x0332]
19C8:031D mov AX,word ptr CS:[BX+0x0334]
19C8:0322 mov word ptr CS:[0x0016],AX
19C8:0326 pop BP
19C8:0327 ret far
19C8:033C mov AX,word ptr CS:[0x0016]
19C8:0340 xor AX,0x0186
19C8:0343 je short 0x0348
19C8:0345 xor AX,AX
19C8:0347 ret far
19C8:0348 mov AX,1
19C8:034B ret far
19FC:00D1 push BP
19FC:00D2 mov BP,SP
19FC:00D4 push DI
19FC:00D5 push SI
19FC:00D6 push DS
19FC:00D7 mov AX,0x1DE9
19FC:00DA mov DS,AX
19FC:00DC cmp word ptr DS:[0xB764],0
19FC:00E1 jne short 0x0147
19FC:00E3 mov AX,word ptr SS:[BP+6]
19FC:00E6 mov SI,AX
19FC:00E8 mov AX,word ptr SS:[BP+8]
19FC:00EB push ES
19FC:00EC mov ES,AX
19FC:00EE mov DI,0x0200
19FC:00F1 mov CX,0x0020
19FC:00F4 mov AL,byte ptr ES:[SI]
19FC:00F7 mov byte ptr DS:[DI],AL
19FC:00F9 inc SI
19FC:00FA inc DI
19FC:00FB loop 0x00F4
19FC:00FD mov SI,0
19FC:0100 mov DI,0x0100
19FC:0103 xor CL,CL
19FC:0105 xor DX,DX
19FC:0107 xor AH,AH
19FC:0109 mov AL,CL
19FC:010B shr AL,1
19FC:010D shr AL,1
19FC:010F shr AL,1
19FC:0111 shr AL,1
19FC:0113 mov DL,AL
19FC:0115 mov AL,CL
19FC:0117 and AL,0x0F
19FC:0119 mov BX,0x0200
19FC:011C add BX,DX
19FC:011E mov CH,byte ptr DS:[BX]
19FC:0120 sub BX,DX
19FC:0122 shl CH,1
19FC:0124 shl CH,1
19FC:0126 add BX,AX
19FC:0128 or CH,byte ptr DS:[BX+0x10]
19FC:012B sub BX,AX
19FC:012D mov byte ptr DS:[SI],CH
19FC:012F inc SI
19FC:0130 add BX,DX
19FC:0132 mov CH,byte ptr DS:[BX+0x10]
19FC:0135 sub BX,DX
19FC:0137 shl CH,1
19FC:0139 shl CH,1
19FC:013B add BX,AX
19FC:013D or CH,byte ptr DS:[BX]
19FC:013F mov byte ptr DS:[DI],CH
19FC:0141 inc DI
19FC:0142 inc CL
19FC:0144 jne short 0x0107
19FC:0146 pop ES
19FC:0147 pop DS
19FC:0148 pop SI
19FC:0149 pop DI
19FC:014A pop BP
19FC:014B ret far
19FC:014C push BP
19FC:014D mov BP,SP
19FC:014F push DI
19FC:0150 push SI
19FC:0151 push DS
19FC:0152 mov AX,0x1DE9
19FC:0155 mov DS,AX
19FC:0157 mov DX,word ptr SS:[BP+6]
19FC:015A mov AH,0x0E
19FC:015C int 0x21
19FC:0163 push BP
19FC:0164 mov BP,SP
19FC:0166 push DI
19FC:0167 push SI
19FC:0168 push DS
19FC:0169 mov AX,0x1DE9
19FC:016C mov DS,AX
19FC:016E mov AX,word ptr SS:[BP+6]
19FC:0171 mov SI,AX
19FC:0173 mov AX,word ptr SS:[BP+8]
19FC:0176 mov word ptr DS:[0xB78C],AX
19FC:0179 mov AX,word ptr SS:[BP+0x0A]
19FC:017C mov DI,AX
19FC:017E mov AX,word ptr SS:[BP+0x0C]
19FC:0181 mov word ptr DS:[0xB790],AX
19FC:0184 mov DX,word ptr SS:[BP+0x0E]
19FC:0187 mov byte ptr DS:[0xB763],DL
19FC:018B mov CX,word ptr SS:[BP+0x10]
19FC:018E mov DX,word ptr DS:[0xB790]
19FC:0192 push ES
19FC:0193 push BP
19FC:0194 mov BP,DX
19FC:0196 xor DH,DH
19FC:0198 mov BX,0
19FC:019B mov DL,byte ptr DS:[0xB763]
19FC:019F mov AX,word ptr DS:[0xB78C]
19FC:01A2 mov ES,AX
19FC:01A4 mov AL,byte ptr ES:[SI]
19FC:01A7 inc SI
19FC:01A8 xlat byte ptr DS:[BX+AL]
19FC:01A9 shl AL,1
19FC:01AB shl AL,1
19FC:01AD shl AL,1
19FC:01AF shl AL,1
19FC:01B1 mov AH,AL
19FC:01B3 mov AL,byte ptr ES:[SI]
19FC:01B6 xlat byte ptr DS:[BX+AL]
19FC:01B7 inc SI
19FC:01B8 or AL,AH
19FC:01BA mov ES,BP
19FC:01BC stos byte ptr ES:[DI],AL
19FC:01BD dec DL
19FC:01BF je short 0x01C6
19FC:01C1 loop 0x019F
19FC:01C3 jmp short 0x01D0
19FC:01C6 xor DH,1
19FC:01C9 je short 0x0198
19FC:01CB mov BX,0x0100
19FC:01CE jmp short 0x019B
19FC:01D0 pop BP
19FC:01D1 pop ES
19FC:01D2 pop DS
19FC:01D3 pop SI
19FC:01D4 pop DI
19FC:01D5 pop BP
19FC:01D6 ret far
19FC:0213 push BP
19FC:0214 mov BP,SP
19FC:0216 push DI
19FC:0217 push SI
19FC:0218 push DS
19FC:0219 mov AX,0x1DE9
19FC:021C mov DS,AX
19FC:021E mov DL,byte ptr SS:[BP+6]
19FC:0221 mov AH,6
19FC:0223 int 0x21
19FC:0225 pop DS
19FC:0226 pop SI
19FC:0227 pop DI
19FC:0228 pop BP
19FC:0229 ret far
19FC:0260 push BP
19FC:0261 mov BP,SP
19FC:0263 push DI
19FC:0264 push SI
19FC:0265 push DS
19FC:0266 mov AX,0x1DE9
19FC:0269 mov DS,AX
19FC:026B mov AX,word ptr SS:[BP+6]
19FC:026E mov SI,AX
19FC:0270 mov AX,word ptr SS:[BP+8]
19FC:0273 push ES
19FC:0274 mov ES,AX
19FC:0276 mov AX,word ptr SS:[BP+0x0A]
19FC:0279 mov CX,0x1F40
19FC:027C push DS
19FC:027D mov DS,AX
19FC:027F mov DI,0
19FC:0282 mov DX,0x03CE
19FC:0285 mov AX,0x0205
19FC:0288 out DX,AX
19FC:0289 mov AL,3
19FC:028B mov AH,0x18
19FC:028D mov AX,0x8008
19FC:0290 out DX,AX
19FC:0291 mov AL,byte ptr DS:[DI]
19FC:0293 mov BL,byte ptr ES:[SI]
19FC:0296 mov AL,BL
19FC:0298 shr AL,1
19FC:029A shr AL,1
19FC:029C shr AL,1
19FC:029E shr AL,1
19FC:02A0 mov byte ptr DS:[DI],AL
19FC:02A2 mov AL,byte ptr DS:[DI]
19FC:02A4 mov AX,0x4008
19FC:02A7 out DX,AX
19FC:02A8 mov byte ptr DS:[DI],BL
19FC:02AA inc SI
19FC:02AB mov AX,0x2008
19FC:02AE out DX,AX
19FC:02AF mov AL,byte ptr DS:[DI]
19FC:02B1 mov BL,byte ptr ES:[SI]
19FC:02B4 mov AL,BL
19FC:02B6 shr AL,1
19FC:02B8 shr AL,1
19FC:02BA shr AL,1
19FC:02BC shr AL,1
19FC:02BE mov byte ptr DS:[DI],AL
19FC:02C0 mov AL,byte ptr DS:[DI]
19FC:02C2 mov AX,0x1008
19FC:02C5 out DX,AX
19FC:02C6 mov byte ptr DS:[DI],BL
19FC:02C8 inc SI
19FC:02C9 mov AX,0x0808
19FC:02CC out DX,AX
19FC:02CD mov AL,byte ptr DS:[DI]
19FC:02CF mov BL,byte ptr ES:[SI]
19FC:02D2 mov AL,BL
19FC:02D4 shr AL,1
19FC:02D6 shr AL,1
19FC:02D8 shr AL,1
19FC:02DA shr AL,1
19FC:02DC mov byte ptr DS:[DI],AL
19FC:02DE mov AL,byte ptr DS:[DI]
19FC:02E0 mov AX,0x0408
19FC:02E3 out DX,AX
19FC:02E4 mov byte ptr DS:[DI],BL
19FC:02E6 inc SI
19FC:02E7 mov AX,0x0208
19FC:02EA out DX,AX
19FC:02EB mov AL,byte ptr DS:[DI]
19FC:02ED mov BL,byte ptr ES:[SI]
19FC:02F0 mov AL,BL
19FC:02F2 shr AL,1
19FC:02F4 shr AL,1
19FC:02F6 shr AL,1
19FC:02F8 shr AL,1
19FC:02FA mov byte ptr DS:[DI],AL
19FC:02FC mov AL,byte ptr DS:[DI]
19FC:02FE mov AX,0x0108
19FC:0301 out DX,AX
19FC:0302 mov byte ptr DS:[DI],BL
19FC:0304 inc SI
19FC:0305 inc DI
19FC:0306 loop 0x028D
19FC:0308 mov AX,8
19FC:030B out DX,AX
19FC:030C pop DS
19FC:030D pop ES
19FC:030E pop DS
19FC:030F pop SI
19FC:0310 pop DI
19FC:0311 pop BP
19FC:0312 ret far
19FC:0313 push BP
19FC:0314 mov BP,SP
19FC:0316 push DI
19FC:0317 push SI
19FC:0318 push DS
19FC:0319 mov AX,0x1DE9
19FC:031C mov DS,AX
19FC:031E push ES
19FC:031F mov DX,0x03CE
19FC:0322 mov AX,0x0205
19FC:0325 out DX,AX
19FC:0326 mov AX,8
19FC:0329 out DX,AX
19FC:032A mov AX,word ptr SS:[BP+6]
19FC:032D mov DI,AX
19FC:032F mov AX,word ptr SS:[BP+8]
19FC:0332 mov ES,AX
19FC:0334 mov BX,word ptr SS:[BP+0x0A]
19FC:0337 mov AX,word ptr SS:[BP+0x0C]
19FC:033A mov DX,0x0140
19FC:033D mul DX
19FC:033F add AX,BX
19FC:0341 mov SI,AX
19FC:0343 push DS
19FC:0344 mov AX,0xA800
19FC:0347 mov DS,AX
19FC:0349 mov CX,8
19FC:034C mov DX,0x03CE
19FC:034F mov AX,4
19FC:0352 out DX,AX
19FC:0353 mov AL,byte ptr DS:[SI]
19FC:0355 stos byte ptr ES:[DI],AL
19FC:0356 mov AX,0x0104
19FC:0359 out DX,AX
19FC:035A mov AL,byte ptr DS:[SI]
19FC:035C stos byte ptr ES:[DI],AL
19FC:035D mov AX,0x0204
19FC:0360 out DX,AX
19FC:0361 mov AL,byte ptr DS:[SI]
19FC:0363 stos byte ptr ES:[DI],AL
19FC:0364 mov AX,0x0304
19FC:0367 out DX,AX
19FC:0368 mov AL,byte ptr DS:[SI]
19FC:036A stos byte ptr ES:[DI],AL
19FC:036B add SI,0x0028
19FC:036E loop 0x034F
19FC:0370 pop DS
19FC:0371 pop ES
19FC:0372 pop DS
19FC:0373 pop SI
19FC:0374 pop DI
19FC:0375 pop BP
19FC:0376 ret far
19FC:0377 push BP
19FC:0378 mov BP,SP
19FC:037A push DI
19FC:037B push SI
19FC:037C push DS
19FC:037D mov AX,0x1DE9
19FC:0380 mov DS,AX
19FC:0382 push ES
19FC:0383 mov AX,word ptr SS:[BP+6]
19FC:0386 mov DI,AX
19FC:0388 mov AX,word ptr SS:[BP+8]
19FC:038B mov ES,AX
19FC:038D mov AX,word ptr SS:[BP+0x0A]
19FC:0390 mov SI,AX
19FC:0392 mov AX,word ptr SS:[BP+0x0C]
19FC:0395 mov word ptr DS:[0x025C],AX
19FC:0398 mov AX,word ptr SS:[BP+0x0E]
19FC:039B mov word ptr DS:[0x0262],AX
19FC:039E sar AX,1
19FC:03A0 sar AX,1
19FC:03A2 sar AX,1
19FC:03A4 mov word ptr DS:[0x0266],AX
19FC:03A7 mov AX,word ptr SS:[BP+0x10]
19FC:03AA mov word ptr DS:[0x0264],AX
19FC:03AD push DS
19FC:03AE inc SI
19FC:03AF mov AX,word ptr DS:[0x025C]
19FC:03B2 mov DS,AX
19FC:03B4 lods AX,word ptr DS:[SI]
19FC:03B5 inc SI
19FC:03B6 pop DS
19FC:03B7 inc AL
19FC:03B9 push AX
19FC:03BA and AX,0x00FF
19FC:03BD mov word ptr DS:[0x026C],AX
19FC:03C0 pop AX
19FC:03C1 xchg AL,AH
19FC:03C3 and AX,0x00FF
19FC:03C6 mov word ptr DS:[0x0268],AX
19FC:03C9 shl AX,1
19FC:03CB shl AX,1
19FC:03CD mov word ptr DS:[0x026A],AX
19FC:03D0 mov AX,word ptr DS:[0x0264]
19FC:03D3 cmp AX,0
19FC:03D6 jns short 0x03FD
19FC:03D8 neg AX
19FC:03DA cmp AX,word ptr DS:[0x026C]
19FC:03DE jae short 0x0447
19FC:03E0 mov DX,word ptr DS:[0x0268]
19FC:03E4 shl DX,1
19FC:03E6 shl DX,1
19FC:03E8 mul DX
19FC:03EA add SI,AX
19FC:03EC mov AX,word ptr DS:[0x026C]
19FC:03EF add AX,word ptr DS:[0x0264]
19FC:03F3 js short 0x0447
19FC:03F5 mov word ptr DS:[0x026C],AX
19FC:03F8 xor AX,AX
19FC:03FA mov word ptr DS:[0x0264],AX
19FC:03FD mov AX,0x00C8
19FC:0400 sub AX,word ptr DS:[0x0264]
19FC:0404 js short 0x0447
19FC:0406 je short 0x0447
19FC:0408 cmp AX,word ptr DS:[0x026C]
19FC:040C jae short 0x0411
19FC:040E mov word ptr DS:[0x026C],AX
19FC:0411 mov AX,word ptr DS:[0x0266]
19FC:0414 cmp AX,0
19FC:0417 jns short 0x0430
19FC:0419 add word ptr DS:[0x0268],AX
19FC:041D neg AX
19FC:041F shl AX,1
19FC:0421 shl AX,1
19FC:0423 add SI,AX
19FC:0425 cmp AX,word ptr DS:[0x026A]
19FC:0429 jae short 0x0447
19FC:042B xor AX,AX
19FC:042D mov word ptr DS:[0x0266],AX
19FC:0430 mov AX,0x0028
19FC:0433 sub AX,word ptr DS:[0x0266]
19FC:0437 js short 0x0447
19FC:0439 je short 0x0447
19FC:043B cmp AX,word ptr DS:[0x0268]
19FC:043F jae short 0x044A
19FC:0441 mov word ptr DS:[0x0268],AX
19FC:0444 jmp short 0x044A
19FC:0447 jmp near 0x0568
19FC:044A mov AX,word ptr DS:[0x0264]
19FC:044D mov DX,0x0028
19FC:0450 mul DL
19FC:0452 add AX,word ptr DS:[0x0266]
19FC:0456 add DI,AX
19FC:0458 mov AX,0x0028
19FC:045B sub AX,word ptr DS:[0x0268]
19FC:045F mov word ptr DS:[0x0264],AX
19FC:0462 mov DX,0x03CE
19FC:0465 mov AX,5
19FC:0468 out DX,AX
19FC:0469 mov AX,0xFF08
19FC:046C out DX,AX
19FC:046D mov BX,word ptr DS:[0x0262]
19FC:0471 and BX,7
19FC:0474 mov BP,word ptr DS:[0x0266]
19FC:0478 mov CX,word ptr DS:[0x0268]
19FC:047C mov AX,word ptr DS:[0x025C]
19FC:047F push DS
19FC:0480 mov DS,AX
19FC:0482 mov DH,3
19FC:0484 push CX
19FC:0485 mov DL,0xCE
19FC:0487 mov AX,4
19FC:048A out DX,AX
19FC:048B mov DL,0xC4
19FC:048D mov AX,0x0102
19FC:0490 out DX,AX
19FC:0491 mov AX,word ptr DS:[SI]
19FC:0493 or AX,word ptr DS:[SI+2]
19FC:0496 or AH,AL
19FC:0498 xor AL,AL
19FC:049A cmp BL,AL
19FC:049C je short 0x04A2
19FC:049E mov CL,BL
19FC:04A0 shr AX,CL
19FC:04A2 not AX
19FC:04A4 mov CH,AH
19FC:04A6 mov BH,AL
19FC:04A8 and byte ptr ES:[DI],CH
19FC:04AB lods AL,byte ptr DS:[SI]
19FC:04AC mov AH,AL
19FC:04AE xor AL,AL
19FC:04B0 cmp BL,AL
19FC:04B2 je short 0x04B6
19FC:04B4 shr AX,CL
19FC:04B6 or byte ptr ES:[DI],AH
19FC:04B9 cmp BP,0x0027
19FC:04BC jae short 0x04C6
19FC:04BE and byte ptr ES:[DI+1],BH
19FC:04C2 or byte ptr ES:[DI+1],AL
19FC:04C6 mov DL,0xCE
19FC:04C8 mov AX,0x0104
19FC:04CB out DX,AX
19FC:04CC mov DL,0xC4
19FC:04CE mov AX,0x0202
19FC:04D1 out DX,AX
19FC:04D2 and byte ptr ES:[DI],CH
19FC:04D5 lods AL,byte ptr DS:[SI]
19FC:04D6 mov AH,AL
19FC:04D8 xor AL,AL
19FC:04DA cmp BL,AL
19FC:04DC je short 0x04E0
19FC:04DE shr AX,CL
19FC:04E0 or byte ptr ES:[DI],AH
19FC:04E3 cmp BP,0x0027
19FC:04E6 jae short 0x04F0
19FC:04E8 and byte ptr ES:[DI+1],BH
19FC:04EC or byte ptr ES:[DI+1],AL
19FC:04F0 mov DL,0xCE
19FC:04F2 mov AX,0x0204
19FC:04F5 out DX,AX
19FC:04F6 mov DL,0xC4
19FC:04F8 mov AX,0x0402
19FC:04FB out DX,AX
19FC:04FC and byte ptr ES:[DI],CH
19FC:04FF lods AL,byte ptr DS:[SI]
19FC:0500 mov AH,AL
19FC:0502 xor AL,AL
19FC:0504 cmp BL,AL
19FC:0506 je short 0x050A
19FC:0508 shr AX,CL
19FC:050A or byte ptr ES:[DI],AH
19FC:050D cmp BP,0x0027
19FC:0510 jae short 0x051A
19FC:0512 and byte ptr ES:[DI+1],BH
19FC:0516 or byte ptr ES:[DI+1],AL
19FC:051A mov DL,0xCE
19FC:051C mov AX,0x0304
19FC:051F out DX,AX
19FC:0520 mov DL,0xC4
19FC:0522 mov AX,0x0802
19FC:0525 out DX,AX
19FC:0526 and byte ptr ES:[DI],CH
19FC:0529 lods AL,byte ptr DS:[SI]
19FC:052A mov AH,AL
19FC:052C xor AL,AL
19FC:052E cmp BL,AL
19FC:0530 je short 0x0534
19FC:0532 shr AX,CL
19FC:0534 or byte ptr ES:[DI],AH
19FC:0537 cmp BP,0x0027
19FC:053A jae short 0x0544
19FC:053C and byte ptr ES:[DI+1],BH
19FC:0540 or byte ptr ES:[DI+1],AL
19FC:0544 inc BP
19FC:0545 inc DI
19FC:0546 pop CX
19FC:0547 loop 0x0565
19FC:0549 pop DS
19FC:054A add SI,word ptr DS:[0x026A]
19FC:054E mov AX,word ptr DS:[0x0268]
19FC:0551 shl AX,1
19FC:0553 shl AX,1
19FC:0555 sub SI,AX
19FC:0557 add DI,word ptr DS:[0x0264]
19FC:055B sub word ptr DS:[0x026C],1
19FC:0560 je short 0x0568
19FC:0562 jmp near 0x0474
19FC:0565 jmp near 0x0484
19FC:0568 mov AX,0x0F02
19FC:056B out DX,AX
19FC:056C pop ES
19FC:056D pop DS
19FC:056E pop SI
19FC:056F pop DI
19FC:0570 pop BP
19FC:0571 ret far
19FC:0572 push BP
19FC:0573 mov BP,SP
19FC:0575 push DI
19FC:0576 push SI
19FC:0577 push DS
19FC:0578 mov AX,0x1DE9
19FC:057B mov DS,AX
19FC:057D push ES
19FC:057E mov SI,word ptr SS:[BP+6]
19FC:0581 mov BX,word ptr SS:[BP+8]
19FC:0584 mov DI,word ptr SS:[BP+0x0A]
19FC:0587 mov AX,word ptr SS:[BP+0x0C]
19FC:058A mov ES,AX
19FC:058C mov CX,word ptr SS:[BP+0x0E]
19FC:058F shr CX,1
19FC:0591 push DS
19FC:0592 mov DS,BX
19FC:0594 lods AL,byte ptr DS:[SI]
19FC:0595 call near 0x05BF
19FC:05BF shl AL,1
19FC:05C1 rcl DH,1
19FC:05C3 shl AL,1
19FC:05C5 rcl DL,1
19FC:05C7 shl AL,1
19FC:05C9 rcl BH,1
19FC:05CB shl AL,1
19FC:05CD rcl BL,1
19FC:05CF ret near
19FC:05D0 push BP
19FC:05D1 mov BP,SP
19FC:05D3 push DI
19FC:05D4 push SI
19FC:05D5 push DS
19FC:05D6 mov AX,0x1DE9
19FC:05D9 mov DS,AX
19FC:05DB push ES
19FC:05DC mov AX,word ptr SS:[BP+6]
19FC:05DF mov word ptr DS:[0x0220],AX
19FC:05E2 mov AX,word ptr SS:[BP+8]
19FC:05E5 mov word ptr DS:[0x0234],AX
19FC:05E8 mov AX,word ptr SS:[BP+0x0A]
19FC:05EB mov word ptr DS:[0x0236],AX
19FC:05EE mov AX,word ptr SS:[BP+0x0C]
19FC:05F1 mov word ptr DS:[0x0224],AX
19FC:05F4 cmp word ptr DS:[0xB764],3
19FC:05F9 je short 0x0605
19FC:05FB cmp word ptr DS:[0xB764],0
19FC:0600 jne short 0x0630
19FC:0602 jmp near 0x06FD
19FC:0605 mov AX,0xA000
19FC:0608 mov ES,AX
19FC:060A mov AX,word ptr DS:[0x0234]
19FC:060D mov DX,0x0140
19FC:0610 mul DX
19FC:0612 add AX,word ptr DS:[0x0220]
19FC:0616 mov DI,AX
19FC:0618 mov CX,word ptr DS:[0x0236]
19FC:061C sub CX,word ptr DS:[0x0234]
19FC:0620 inc CX
19FC:0621 mov AX,word ptr DS:[0x0224]
19FC:0624 mov byte ptr ES:[DI],AL
19FC:0627 add DI,0x0140
19FC:062B loop 0x0624
19FC:062D jmp near 0x06F7
19FC:0630 cmp word ptr DS:[0xB764],1
19FC:0635 je short 0x067F
19FC:0637 mov DX,0x03CE
19FC:063A mov AX,0x0205
19FC:063D out DX,AX
19FC:063E mov CX,word ptr DS:[0x0220]
19FC:0642 mov AX,0x8008
19FC:0645 and CX,7
19FC:0648 je short 0x064C
19FC:064A shr AH,CL
19FC:064C out DX,AX
19FC:064D mov AX,0xA000
19FC:0650 mov ES,AX
19FC:0652 mov DX,word ptr DS:[0x0234]
19FC:0656 mov AX,0x0028
19FC:0659 mul DL
19FC:065B mov BX,word ptr DS:[0x0220]
19FC:065F shr BX,1
19FC:0661 shr BX,1
19FC:0663 shr BX,1
19FC:0665 add AX,BX
19FC:0667 mov DI,AX
19FC:0669 mov AX,word ptr DS:[0x0224]
19FC:066C mov AH,byte ptr ES:[DI]
19FC:066F mov byte ptr ES:[DI],AL
19FC:0672 add DI,0x0028
19FC:0675 inc DX
19FC:0676 cmp DX,word ptr DS:[0x0236]
19FC:067A jle short 0x066C
19FC:067C jmp short 0x06F7
19FC:067F mov CX,4
19FC:0682 shl AX,CL
19FC:0684 or AX,word ptr DS:[0x0224]
19FC:0688 mov BX,0x000F
19FC:068B mov CX,word ptr DS:[0x0220]
19FC:068F test CX,1
19FC:0693 jne short 0x069A
19FC:0695 mov CX,4
19FC:0698 shl BX,CL
19FC:069A and AX,BX
19FC:069C mov word ptr DS:[0x0224],AX
19FC:069F not BL
19FC:06A1 mov AX,0xB800
19FC:06A4 mov ES,AX
19FC:06A6 mov AX,word ptr DS:[0x0234]
19FC:06A9 and AL,0xFC
19FC:06AB mov DX,0x0028
19FC:06AE mul DL
19FC:06B0 mov CX,word ptr DS:[0x0234]
19FC:06B4 and CX,3
19FC:06B7 je short 0x06BE
19FC:06B9 add AH,0x20
19FC:06BC loop 0x06B9
19FC:06BE mov DX,word ptr DS:[0x0220]
19FC:06C2 shr DX,1
19FC:06C4 add AX,DX
19FC:06C6 mov DX,word ptr DS:[0x0234]
19FC:06CA mov DI,AX
19FC:06CC mov CX,word ptr DS:[0x0236]
19FC:06D0 sub CX,word ptr DS:[0x0234]
19FC:06D4 inc CX
19FC:06D5 mov AL,byte ptr ES:[DI]
19FC:06D8 and AL,BL
19FC:06DA or AX,word ptr DS:[0x0224]
19FC:06DE mov byte ptr ES:[DI],AL
19FC:06E1 inc DL
19FC:06E3 and DL,3
19FC:06E6 je short 0x06F1
19FC:06E8 add DI,0x2000
19FC:06EC loop 0x06D5
19FC:06EE jmp short 0x06F7
19FC:06F1 sub DI,0x5F60
19FC:06F5 loop 0x06D5
19FC:06F7 pop ES
19FC:06F8 pop DS
19FC:06F9 pop SI
19FC:06FA pop DI
19FC:06FB pop BP
19FC:06FC ret far
19FC:06FD and AX,3
19FC:0700 mov word ptr DS:[0x0224],AX
19FC:0703 shl AX,1
19FC:0705 shl AX,1
19FC:0707 or AX,word ptr DS:[0x0224]
19FC:070B mov BX,AX
19FC:070D mov CX,4
19FC:0710 shl AX,CL
19FC:0712 or AX,BX
19FC:0714 mov BX,3
19FC:0717 mov CX,word ptr DS:[0x0220]
19FC:071B and CX,3
19FC:071E xor CX,3
19FC:0721 je short 0x0727
19FC:0723 add CX,CX
19FC:0725 shl BX,CL
19FC:0727 and AX,BX
19FC:0729 mov word ptr DS:[0x0224],AX
19FC:072C not BL
19FC:072E mov AX,0xB800
19FC:0731 mov ES,AX
19FC:0733 mov AX,word ptr DS:[0x0234]
19FC:0736 and AL,0xFE
19FC:0738 mov DX,0x0028
19FC:073B mul DL
19FC:073D mov DX,word ptr DS:[0x0220]
19FC:0741 shr DX,1
19FC:0743 shr DX,1
19FC:0745 add AX,DX
19FC:0747 mov DX,word ptr DS:[0x0234]
19FC:074B and DX,1
19FC:074E je short 0x0753
19FC:0750 add AX,0x2000
19FC:0753 mov DI,AX
19FC:0755 mov CX,word ptr DS:[0x0236]
19FC:0759 sub CX,word ptr DS:[0x0234]
19FC:075D inc CX
19FC:075E mov AL,byte ptr ES:[DI]
19FC:0761 and AL,BL
19FC:0763 or AX,word ptr DS:[0x0224]
19FC:0767 mov byte ptr ES:[DI],AL
19FC:076A xor DL,1
19FC:076D je short 0x0777
19FC:076F add DI,0x2000
19FC:0773 loop 0x075E
19FC:0775 jmp short 0x06F7
19FC:0777 sub DI,0x1FB0
19FC:077B loop 0x075E
19FC:077D jmp near 0x06F7
19FC:0780 push BP
19FC:0781 mov BP,SP
19FC:0783 push DI
19FC:0784 push SI
19FC:0785 push DS
19FC:0786 mov AX,0x1DE9
19FC:0789 mov DS,AX
19FC:078B push ES
19FC:078C mov AX,word ptr SS:[BP+6]
19FC:078F mov word ptr DS:[0x0220],AX
19FC:0792 mov AX,word ptr SS:[BP+8]
19FC:0795 mov word ptr DS:[0x0234],AX
19FC:0798 mov CX,word ptr SS:[BP+0x0A]
19FC:079B mov word ptr DS:[0x0230],CX
19FC:079F mov AX,word ptr SS:[BP+0x0C]
19FC:07A2 mov word ptr DS:[0x0224],AX
19FC:07A5 cmp word ptr DS:[0xB764],3
19FC:07AA je short 0x07BD
19FC:07AC cmp word ptr DS:[0xB764],2
19FC:07B1 je short 0x07D8
19FC:07B3 cmp word ptr DS:[0xB764],1
19FC:07B8 je short 0x080E
19FC:07BA jmp near 0x0854
19FC:07BD mov AX,0xA000
19FC:07C0 mov ES,AX
19FC:07C2 mov AX,word ptr DS:[0x0234]
19FC:07C5 mov DX,0x0140
19FC:07C8 mul DX
19FC:07CA add AX,word ptr DS:[0x0220]
19FC:07CE mov DI,AX
19FC:07D0 mov AX,word ptr DS:[0x0224]
19FC:07D3 rep stos byte ptr ES:[DI],AL
19FC:07D5 jmp short 0x084E
19FC:07D8 mov DX,0x03CE
19FC:07DB mov AX,0x0205
19FC:07DE out DX,AX
19FC:07DF mov AX,0xFF08
19FC:07E2 out DX,AX
19FC:07E3 mov DX,0x0028
19FC:07E6 mov AX,word ptr DS:[0x0234]
19FC:07E9 mul DL
19FC:07EB mov BX,word ptr DS:[0x0220]
19FC:07EF shr BX,1
19FC:07F1 shr BX,1
19FC:07F3 shr BX,1
19FC:07F5 add AX,BX
19FC:07F7 mov DI,AX
19FC:07F9 mov AX,0xA000
19FC:07FC mov ES,AX
19FC:07FE mov CX,word ptr DS:[0x0230]
19FC:0802 mov AX,word ptr DS:[0x0224]
19FC:0805 mov AH,byte ptr ES:[DI]
19FC:0808 stos byte ptr ES:[DI],AL
19FC:0809 loop 0x0805
19FC:080B jmp short 0x084E
19FC:080E mov CX,4
19FC:0811 shl AL,CL
19FC:0813 or AX,word ptr DS:[0x0224]
19FC:0817 mov AH,AL
19FC:0819 mov word ptr DS:[0x0224],AX
19FC:081C mov AX,0xB800
19FC:081F mov ES,AX
19FC:0821 mov AX,word ptr DS:[0x0234]
19FC:0824 and AL,0xFC
19FC:0826 mov DX,0x0028
19FC:0829 mul DL
19FC:082B mov DX,word ptr DS:[0x0220]
19FC:082F shr DX,1
19FC:0831 add AX,DX
19FC:0833 mov DX,word ptr DS:[0x0234]
19FC:0837 and DX,3
19FC:083A je short 0x0843
19FC:083C mov CX,DX
19FC:083E add AH,0x20
19FC:0841 loop 0x083E
19FC:0843 mov DI,AX
19FC:0845 mov CX,word ptr DS:[0x0230]
19FC:0849 mov AX,word ptr DS:[0x0224]
19FC:084C rep stos byte ptr ES:[DI],AL
19FC:084E pop ES
19FC:084F pop DS
19FC:0850 pop SI
19FC:0851 pop DI
19FC:0852 pop BP
19FC:0853 ret far
19FC:0854 and AX,3
19FC:0857 mov word ptr DS:[0x0224],AX
19FC:085A shl AL,1
19FC:085C shl AL,1
19FC:085E or AX,word ptr DS:[0x0224]
19FC:0862 mov BL,AL
19FC:0864 mov CL,4
19FC:0866 shl AL,CL
19FC:0868 or AL,BL
19FC:086A mov AH,AL
19FC:086C mov word ptr DS:[0x0224],AX
19FC:086F mov AX,0xB800
19FC:0872 mov ES,AX
19FC:0874 mov AX,word ptr DS:[0x0234]
19FC:0877 and AL,0xFE
19FC:0879 mov DX,0x0028
19FC:087C mul DL
19FC:087E mov DX,word ptr DS:[0x0220]
19FC:0882 shr DX,1
19FC:0884 shr DX,1
19FC:0886 add AX,DX
19FC:0888 mov DX,word ptr DS:[0x0234]
19FC:088C and DX,1
19FC:088F je short 0x0894
19FC:0891 add AH,0x20
19FC:0894 mov DI,AX
19FC:0896 mov CX,word ptr DS:[0x0230]
19FC:089A mov AX,word ptr DS:[0x0224]
19FC:089D rep stos byte ptr ES:[DI],AL
19FC:089F jmp short 0x084E
19FC:08A1 push BP
19FC:08A2 mov BP,SP
19FC:08A4 push DI
19FC:08A5 push SI
19FC:08A6 push DS
19FC:08A7 mov AX,0x1DE9
19FC:08AA mov DS,AX
19FC:08AC push ES
19FC:08AD mov AX,word ptr SS:[BP+6]
19FC:08B0 shr AX,1
19FC:08B2 mov word ptr DS:[0x0220],AX
19FC:08B5 mov AX,word ptr SS:[BP+8]
19FC:08B8 mov word ptr DS:[0x0234],AX
19FC:08BB mov AX,word ptr SS:[BP+0x0A]
19FC:08BE add AX,1
19FC:08C1 mov word ptr DS:[0x0230],AX
19FC:08C4 mov AX,word ptr SS:[BP+0x0C]
19FC:08C7 mov word ptr DS:[0x0236],AX
19FC:08CA mov AX,word ptr SS:[BP+0x0E]
19FC:08CD mov word ptr DS:[0x0224],AX
19FC:08D0 mov CX,4
19FC:08D3 shl AL,CL
19FC:08D5 or AX,word ptr DS:[0x0224]
19FC:08D9 mov AH,AL
19FC:08DB mov word ptr DS:[0x0224],AX
19FC:08DE mov AX,0xB800
19FC:08E1 mov ES,AX
19FC:08E3 mov AX,word ptr DS:[0x0234]
19FC:08E6 and AL,0xFC
19FC:08E8 mov DX,0x0028
19FC:08EB mul DL
19FC:08ED add AX,word ptr DS:[0x0220]
19FC:08F1 mov DX,word ptr DS:[0x0234]
19FC:08F5 and DX,3
19FC:08F8 je short 0x0901
19FC:08FA mov CX,DX
19FC:08FC add AH,0x20
19FC:08FF loop 0x08FC
19FC:0901 mov DI,AX
19FC:0903 mov BX,word ptr DS:[0x0236]
19FC:0907 mov AX,word ptr DS:[0x0224]
19FC:090A mov CX,word ptr DS:[0x0230]
19FC:090E rep stos byte ptr ES:[DI],AL
19FC:0910 sub DI,word ptr DS:[0x0230]
19FC:0914 inc DL
19FC:0916 and DL,3
19FC:0919 je short 0x0924
19FC:091B add DI,0x2000
19FC:091F dec BX
19FC:0920 jns short 0x090A
19FC:0922 js short 0x092B
19FC:0924 sub DI,0x5F60
19FC:0928 dec BX
19FC:0929 jns short 0x090A
19FC:092B pop ES
19FC:092C pop DS
19FC:092D pop SI
19FC:092E pop DI
19FC:092F pop BP
19FC:0930 ret far
19FC:0931 push BP
19FC:0932 mov BP,SP
19FC:0934 push DI
19FC:0935 push SI
19FC:0936 push DS
19FC:0937 mov AX,0x1DE9
19FC:093A mov DS,AX
19FC:093C push ES
19FC:093D mov SI,word ptr SS:[BP+6]
19FC:0940 mov AX,word ptr SS:[BP+8]
19FC:0943 mov word ptr DS:[0x025A],AX
19FC:0946 mov DI,word ptr SS:[BP+0x0A]
19FC:0949 mov AX,word ptr SS:[BP+0x0C]
19FC:094C mov ES,AX
19FC:094E mov DX,word ptr SS:[BP+0x0E]
19FC:0951 mov AX,word ptr SS:[BP+0x10]
19FC:0954 mov DH,AL
19FC:0956 mov BX,word ptr SS:[BP+0x12]
19FC:0959 push DS
19FC:095A mov DS,word ptr DS:[0x025A]
19FC:095E mov CL,DL
19FC:0960 xor CH,CH
19FC:0962 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:0964 add SI,BX
19FC:0966 dec DH
19FC:0968 jne short 0x095E
19FC:096A pop DS
19FC:096B pop ES
19FC:096C pop DS
19FC:096D pop SI
19FC:096E pop DI
19FC:096F pop BP
19FC:0970 ret far
19FC:0971 push BP
19FC:0972 mov BP,SP
19FC:0974 push DI
19FC:0975 push SI
19FC:0976 push DS
19FC:0977 mov AX,0x1DE9
19FC:097A mov DS,AX
19FC:097C mov AX,word ptr SS:[BP+6]
19FC:097F mov word ptr DS:[0x0238],AX
19FC:0982 mov AX,word ptr SS:[BP+8]
19FC:0985 mov word ptr DS:[0x023A],AX
19FC:0988 mov AX,word ptr SS:[BP+0x0A]
19FC:098B mov word ptr DS:[0x023C],AX
19FC:098E mov AX,word ptr SS:[BP+0x0C]
19FC:0991 mov word ptr DS:[0x023E],AX
19FC:0994 mov AX,word ptr DS:[0x023A]
19FC:0997 mov BX,word ptr DS:[0x023E]
19FC:099B sub AL,BL
19FC:099D xor DX,DX
19FC:099F mov DL,AL
19FC:09A1 or DL,DL
19FC:09A3 jns short 0x09A7
19FC:09A5 dec DH
19FC:09A7 and AH,0xF0
19FC:09AA and BH,0xF0
19FC:09AD cmp BH,AH
19FC:09AF je short 0x09BB
19FC:09B1 jb short 0x09B8
19FC:09B3 or DX,-128
19FC:09B6 jne short 0x09BB
19FC:09B8 and DX,0x007F
19FC:09BB mov DI,DX
19FC:09BD xor DX,DX
19FC:09BF mov AX,word ptr DS:[0x0238]
19FC:09C2 mov BX,word ptr DS:[0x023C]
19FC:09C6 mov CX,BX
19FC:09C8 sub CX,AX
19FC:09CA cmp BH,AH
19FC:09CC je short 0x09DA
19FC:09CE jb short 0x09D6
19FC:09D0 and CX,0x007F
19FC:09D3 jmp short 0x09DA
19FC:09D6 or CX,0x0080
19FC:09DA mov BX,CX
19FC:09DC or BX,BX
19FC:09DE jns short 0x09E2
19FC:09E0 neg BX
19FC:09E2 mov AX,DI
19FC:09E4 shl AX,1
19FC:09E6 cmp AX,BX
19FC:09E8 jl short 0x09ED
19FC:09EA or DX,8
19FC:09ED mov AX,DI
19FC:09EF neg AX
19FC:09F1 shl AX,1
19FC:09F3 cmp AX,BX
19FC:09F5 jl short 0x09FA
19FC:09F7 or DX,4
19FC:09FA mov BX,DI
19FC:09FC or BX,BX
19FC:09FE jns short 0x0A02
19FC:0A00 neg BX
19FC:0A02 mov AX,CX
19FC:0A04 shl AX,1
19FC:0A06 cmp AX,BX
19FC:0A08 jl short 0x0A0D
19FC:0A0A or DX,2
19FC:0A0D mov AX,CX
19FC:0A0F neg AX
19FC:0A11 shl AX,1
19FC:0A13 cmp AX,BX
19FC:0A15 jl short 0x0A1A
19FC:0A17 or DX,1
19FC:0A1A mov BX,DX
19FC:0A1C mov AL,byte ptr DS:[BX+0x0240]
19FC:0A20 cbw
19FC:0A21 pop DS
19FC:0A22 pop SI
19FC:0A23 pop DI
19FC:0A24 pop BP
19FC:0A25 ret far
19FC:0A76 push BP
19FC:0A77 mov BP,SP
19FC:0A79 push DI
19FC:0A7A push SI
19FC:0A7B push DS
19FC:0A7C mov AX,0x1DE9
19FC:0A7F mov DS,AX
19FC:0A81 mov SI,word ptr SS:[BP+6]
19FC:0A84 mov DX,word ptr SS:[BP+8]
19FC:0A87 mov DI,word ptr SS:[BP+0x0A]
19FC:0A8A mov AX,word ptr SS:[BP+0x0C]
19FC:0A8D push ES
19FC:0A8E mov ES,AX
19FC:0A90 mov CX,word ptr SS:[BP+0x0E]
19FC:0A93 push DS
19FC:0A94 mov DS,DX
19FC:0A96 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:0A98 pop DS
19FC:0A99 pop ES
19FC:0A9A pop DS
19FC:0A9B pop SI
19FC:0A9C pop DI
19FC:0A9D pop BP
19FC:0A9E ret far
19FC:0A9F push BP
19FC:0AA0 mov BP,SP
19FC:0AA2 push DI
19FC:0AA3 push SI
19FC:0AA4 push DS
19FC:0AA5 mov AX,0x1DE9
19FC:0AA8 mov DS,AX
19FC:0AAA mov DX,0x03CE
19FC:0AAD mov AX,5
19FC:0AB0 out DX,AX
19FC:0AB1 mov AX,0xFF08
19FC:0AB4 out DX,AX
19FC:0AB5 mov AX,1
19FC:0AB8 out DX,AX
19FC:0AB9 mov AX,word ptr SS:[BP+6]
19FC:0ABC mov SI,AX
19FC:0ABE mov AX,0xA400
19FC:0AC1 push ES
19FC:0AC2 mov ES,AX
19FC:0AC4 mov DI,word ptr SS:[BP+0x0A]
19FC:0AC7 mov AX,word ptr SS:[BP+8]
19FC:0ACA push DS
19FC:0ACB mov DS,AX
19FC:0ACD mov CX,0x0010
19FC:0AD0 mov DX,0x03C4
19FC:0AD3 mov AX,0x0102
19FC:0AD6 out DX,AX
19FC:0AD7 mov AL,byte ptr ES:[DI]
19FC:0ADA movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0ADB dec DI
19FC:0ADC mov AX,0x0202
19FC:0ADF out DX,AX
19FC:0AE0 mov AL,byte ptr ES:[DI]
19FC:0AE3 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0AE4 dec DI
19FC:0AE5 mov AX,0x0402
19FC:0AE8 out DX,AX
19FC:0AE9 mov AL,byte ptr ES:[DI]
19FC:0AEC movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0AED dec DI
19FC:0AEE mov AX,0x0802
19FC:0AF1 out DX,AX
19FC:0AF2 mov AL,byte ptr ES:[DI]
19FC:0AF5 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0AF6 mov AX,0x0102
19FC:0AF9 out DX,AX
19FC:0AFA mov AL,byte ptr ES:[DI]
19FC:0AFD movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0AFE dec DI
19FC:0AFF mov AX,0x0202
19FC:0B02 out DX,AX
19FC:0B03 mov AL,byte ptr ES:[DI]
19FC:0B06 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0B07 dec DI
19FC:0B08 mov AX,0x0402
19FC:0B0B out DX,AX
19FC:0B0C mov AL,byte ptr ES:[DI]
19FC:0B0F movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0B10 dec DI
19FC:0B11 mov AX,0x0802
19FC:0B14 out DX,AX
19FC:0B15 mov AL,byte ptr ES:[DI]
19FC:0B18 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:0B19 loop 0x0AD3
19FC:0B1B mov AX,0x0F02
19FC:0B1E out DX,AX
19FC:0B1F pop DS
19FC:0B20 pop ES
19FC:0B21 pop DS
19FC:0B22 pop SI
19FC:0B23 pop DI
19FC:0B24 pop BP
19FC:0B25 ret far
19FC:0B26 push BP
19FC:0B27 mov BP,SP
19FC:0B29 push DI
19FC:0B2A push SI
19FC:0B2B push DS
19FC:0B2C mov AX,0x1DE9
19FC:0B2F mov DS,AX
19FC:0B31 push DX
19FC:0B32 mov DX,0x03DA
19FC:0B35 in AL,DX
19FC:0B36 and AL,8
19FC:0B38 xor AH,AH
19FC:0B3A pop DX
19FC:0B3B pop DS
19FC:0B3C pop SI
19FC:0B3D pop DI
19FC:0B3E pop BP
19FC:0B3F ret far
19FC:0B40 push BP
19FC:0B41 mov BP,SP
19FC:0B43 push DI
19FC:0B44 push SI
19FC:0B45 push DS
19FC:0B46 mov AX,0x1DE9
19FC:0B49 mov DS,AX
19FC:0B4B mov BL,byte ptr SS:[BP+6]
19FC:0B4E push DX
19FC:0B4F mov DX,0x03DA
19FC:0B52 cmp BL,1
19FC:0B55 je short 0x0B63
19FC:0B57 in AL,DX
19FC:0B58 test AL,8
19FC:0B5A je short 0x0B57
19FC:0B5C in AL,DX
19FC:0B5D test AL,8
19FC:0B5F jne short 0x0B5C
19FC:0B61 je short 0x0B6D
19FC:0B63 in AL,DX
19FC:0B64 test AL,8
19FC:0B66 jne short 0x0B63
19FC:0B68 in AL,DX
19FC:0B69 test AL,8
19FC:0B6B je short 0x0B68
19FC:0B6D pop DX
19FC:0B6E pop DS
19FC:0B6F pop SI
19FC:0B70 pop DI
19FC:0B71 pop BP
19FC:0B72 ret far
19FC:0B73 push BP
19FC:0B74 mov BP,SP
19FC:0B76 push DI
19FC:0B77 push SI
19FC:0B78 push DS
19FC:0B79 mov AX,0x1DE9
19FC:0B7C mov DS,AX
19FC:0B7E mov AX,word ptr SS:[BP+6]
19FC:0B81 xor AH,AH
19FC:0B83 int 0x10
19FC:0B85 pop DS
19FC:0B86 pop SI
19FC:0B87 pop DI
19FC:0B88 pop BP
19FC:0B89 ret far
19FC:0B8A push BP
19FC:0B8B mov BP,SP
19FC:0B8D push DI
19FC:0B8E push SI
19FC:0B8F push DS
19FC:0B90 mov AX,0x1DE9
19FC:0B93 mov DS,AX
19FC:0B95 xor AH,AH
19FC:0B97 int 0x16
19FC:0B99 cmp AL,0
19FC:0B9B jne short 0x0BA1
19FC:0B9D mov AL,AH
19FC:0B9F neg AL
19FC:0BA1 cbw
19FC:0BA2 pop DS
19FC:0BA3 pop SI
19FC:0BA4 pop DI
19FC:0BA5 pop BP
19FC:0BA6 ret far
19FC:0BA7 push BP
19FC:0BA8 mov BP,SP
19FC:0BAA push DI
19FC:0BAB push SI
19FC:0BAC push DS
19FC:0BAD mov AX,0x1DE9
19FC:0BB0 mov DS,AX
19FC:0BB2 mov BX,word ptr SS:[BP+6]
19FC:0BB5 mov BH,1
19FC:0BB7 mov AH,0x0B
19FC:0BB9 int 0x10
19FC:0BC0 push BP
19FC:0BC1 mov BP,SP
19FC:0BC3 push DI
19FC:0BC4 push SI
19FC:0BC5 push DS
19FC:0BC6 mov AX,0x1DE9
19FC:0BC9 mov DS,AX
19FC:0BCB push ES
19FC:0BCC mov AX,0x3858
19FC:0BCF mov ES,AX
19FC:0BD1 mov SI,0x4FC0
19FC:0BD4 xor AH,AH
19FC:0BD6 mov AL,byte ptr ES:[SI]
19FC:0BD9 shr AL,1
19FC:0BDB shr AL,1
19FC:0BDD rcl byte ptr ES:[SI+2],1
19FC:0BE1 rcl byte ptr ES:[SI+1],1
19FC:0BE5 cmc
19FC:0BE6 sbb AL,byte ptr ES:[SI]
19FC:0BE9 shr AL,1
19FC:0BEB rcr byte ptr ES:[SI],1
19FC:0BEE mov AL,byte ptr ES:[SI]
19FC:0BF1 xor AL,byte ptr ES:[SI+1]
19FC:0BF5 pop ES
19FC:0BF6 pop DS
19FC:0BF7 pop SI
19FC:0BF8 pop DI
19FC:0BF9 pop BP
19FC:0BFA ret far
19FC:0BFB push SI
19FC:0BFC mov SI,DI
19FC:0BFE mov DH,byte ptr DS:[DI]
19FC:0C00 mov DL,byte ptr DS:[DI+8]
19FC:0C03 mov BH,byte ptr DS:[DI+0x48]
19FC:0C06 mov BL,byte ptr DS:[DI+0x50]
19FC:0C09 push ES
19FC:0C0A mov AX,DS
19FC:0C0C mov ES,AX
19FC:0C0E mov CX,0x0028
19FC:0C11 mov AX,0xFFFF
19FC:0C14 cld
19FC:0C15 rep stos word ptr ES:[DI],AX
19FC:0C17 pop ES
19FC:0C18 mov DI,SI
19FC:0C1A mov byte ptr DS:[DI],DH
19FC:0C1C mov byte ptr DS:[DI+8],DL
19FC:0C1F mov byte ptr DS:[DI+0x48],BH
19FC:0C22 mov byte ptr DS:[DI+0x50],BL
19FC:0C25 add DL,DH
19FC:0C27 xor DH,DH
19FC:0C29 mov word ptr DS:[0x09F9],DX
19FC:0C2D mov SI,0x0279
19FC:0C30 mov byte ptr DS:[SI],0
19FC:0C33 mov byte ptr DS:[SI+1],8
19FC:0C37 add SI,2
19FC:0C3A call near 0x0D07
19FC:0C3D mov AL,byte ptr DS:[DI+0x48]
19FC:0C40 add AL,byte ptr DS:[DI+0x50]
19FC:0C43 xor AH,AH
19FC:0C45 mov word ptr DS:[0x09F9],AX
19FC:0C48 mov SI,0x0279
19FC:0C4B mov byte ptr DS:[SI],0x48
19FC:0C4E mov byte ptr DS:[SI+1],0x50
19FC:0C52 add SI,2
19FC:0C55 call near 0x0D07
19FC:0C58 mov AL,byte ptr DS:[DI]
19FC:0C5A add AL,byte ptr DS:[DI+0x48]
19FC:0C5D xor AH,AH
19FC:0C5F mov word ptr DS:[0x09F9],AX
19FC:0C62 mov SI,0x0279
19FC:0C65 mov byte ptr DS:[SI],0
19FC:0C68 mov byte ptr DS:[SI+1],0x48
19FC:0C6C add SI,2
19FC:0C6F call near 0x0D79
19FC:0C72 mov AL,byte ptr DS:[DI+8]
19FC:0C75 add AL,byte ptr DS:[DI+0x50]
19FC:0C78 xor AH,AH
19FC:0C7A mov word ptr DS:[0x09F9],AX
19FC:0C7D mov SI,0x0279
19FC:0C80 mov byte ptr DS:[SI],8
19FC:0C83 mov byte ptr DS:[SI+1],0x50
19FC:0C87 add SI,2
19FC:0C8A call near 0x0D79
19FC:0C8D mov SI,0x0279
19FC:0C90 mov byte ptr DS:[SI],0
19FC:0C93 mov byte ptr DS:[SI+1],8
19FC:0C97 mov byte ptr DS:[SI+2],0x48
19FC:0C9B mov byte ptr DS:[SI+3],0x50
19FC:0C9F add SI,4
19FC:0CA2 call near 0x0DF8
19FC:0CA5 pop SI
19FC:0CA6 xchg SI,DI
19FC:0CA8 push ES
19FC:0CA9 mov AX,DS
19FC:0CAB mov ES,AX
19FC:0CAD cld
19FC:0CAE mov CX,4
19FC:0CB1 lods AX,word ptr DS:[SI]
19FC:0CB2 and AX,0xF0F0
19FC:0CB5 stos word ptr ES:[DI],AX
19FC:0CB6 loop 0x0CB1
19FC:0CB8 inc SI
19FC:0CB9 mov CX,4
19FC:0CBC lods AX,word ptr DS:[SI]
19FC:0CBD and AX,0xF0F0
19FC:0CC0 stos word ptr ES:[DI],AX
19FC:0CC1 loop 0x0CBC
19FC:0CC3 inc SI
19FC:0CC4 mov CX,4
19FC:0CC7 lods AX,word ptr DS:[SI]
19FC:0CC8 and AX,0xF0F0
19FC:0CCB stos word ptr ES:[DI],AX
19FC:0CCC loop 0x0CC7
19FC:0CCE inc SI
19FC:0CCF mov CX,4
19FC:0CD2 lods AX,word ptr DS:[SI]
19FC:0CD3 and AX,0xF0F0
19FC:0CD6 stos word ptr ES:[DI],AX
19FC:0CD7 loop 0x0CD2
19FC:0CD9 inc SI
19FC:0CDA mov CX,4
19FC:0CDD lods AX,word ptr DS:[SI]
19FC:0CDE and AX,0xF0F0
19FC:0CE1 stos word ptr ES:[DI],AX
19FC:0CE2 loop 0x0CDD
19FC:0CE4 inc SI
19FC:0CE5 mov CX,4
19FC:0CE8 lods AX,word ptr DS:[SI]
19FC:0CE9 and AX,0xF0F0
19FC:0CEC stos word ptr ES:[DI],AX
19FC:0CED loop 0x0CE8
19FC:0CEF inc SI
19FC:0CF0 mov CX,4
19FC:0CF3 lods AX,word ptr DS:[SI]
19FC:0CF4 and AX,0xF0F0
19FC:0CF7 stos word ptr ES:[DI],AX
19FC:0CF8 loop 0x0CF3
19FC:0CFA inc SI
19FC:0CFB mov CX,4
19FC:0CFE lods AX,word ptr DS:[SI]
19FC:0CFF and AX,0xF0F0
19FC:0D02 stos word ptr ES:[DI],AX
19FC:0D03 loop 0x0CFE
19FC:0D05 pop ES
19FC:0D06 ret near
19FC:0D07 cmp SI,0x0279
19FC:0D0B je short 0x0D78
19FC:0D0D sub SI,2
19FC:0D10 mov DH,byte ptr DS:[SI]
19FC:0D12 mov DL,byte ptr DS:[SI+1]
19FC:0D15 mov AL,DL
19FC:0D17 sub AL,DH
19FC:0D19 cmp AL,1
19FC:0D1B je short 0x0D07
19FC:0D1D xor BH,BH
19FC:0D1F mov BL,DH
19FC:0D21 mov CH,byte ptr DS:[BX+DI]
19FC:0D23 mov BL,DL
19FC:0D25 mov CL,byte ptr DS:[BX+DI]
19FC:0D27 shr AL,1
19FC:0D29 mov BL,AL
19FC:0D2B add BL,DH
19FC:0D2D mov byte ptr DS:[SI],DH
19FC:0D2F mov byte ptr DS:[SI+1],BL
19FC:0D32 mov byte ptr DS:[SI+2],BL
19FC:0D35 mov byte ptr DS:[SI+3],DL
19FC:0D38 add SI,4
19FC:0D3B mov AH,byte ptr DS:[BX+DI]
19FC:0D3D cmp AH,0xFF
19FC:0D40 jne short 0x0D07
19FC:0D42 mov DL,CH
19FC:0D44 xor DH,DH
19FC:0D46 mov CH,DH
19FC:0D48 add DX,CX
19FC:0D4A shr DX,1
19FC:0D4C mov CX,SI
19FC:0D4E mov SI,0x09FB
19FC:0D51 add SI,word ptr DS:[0x09F9]
19FC:0D55 mov AH,byte ptr DS:[SI]
19FC:0D57 mov SI,CX
19FC:0D59 mov CL,AL
19FC:0D5B shl CL,1
19FC:0D5D mov CH,CL
19FC:0D5F shl CL,1
19FC:0D61 dec CL
19FC:0D63 and CL,AH
19FC:0D65 sub CL,CH
19FC:0D67 add DL,CL
19FC:0D69 cmp DL,0x80
19FC:0D6C jb short 0x0D70
19FC:0D6E xor DL,DL
19FC:0D70 mov byte ptr DS:[BX+DI],DL
19FC:0D72 inc byte ptr DS:[0x09F9]
19FC:0D76 jmp short 0x0D07
19FC:0D78 ret near
19FC:0D79 cmp SI,0x0279
19FC:0D7D je short 0x0DF7
19FC:0D7F sub SI,2
19FC:0D82 mov DH,byte ptr DS:[SI]
19FC:0D84 mov DL,byte ptr DS:[SI+1]
19FC:0D87 mov AL,DL
19FC:0D89 sub AL,DH
19FC:0D8B cmp AL,9
19FC:0D8D je short 0x0D79
19FC:0D8F xor BH,BH
19FC:0D91 mov BL,DH
19FC:0D93 mov CH,byte ptr DS:[BX+DI]
19FC:0D95 mov BL,DL
19FC:0D97 mov CL,byte ptr DS:[BX+DI]
19FC:0D99 shr AL,1
19FC:0D9B mov BL,AL
19FC:0D9D add BL,DH
19FC:0D9F mov byte ptr DS:[SI],DH
19FC:0DA1 mov byte ptr DS:[SI+1],BL
19FC:0DA4 mov byte ptr DS:[SI+2],BL
19FC:0DA7 mov byte ptr DS:[SI+3],DL
19FC:0DAA add SI,4
19FC:0DAD mov AH,byte ptr DS:[BX+DI]
19FC:0DAF cmp AH,0xFF
19FC:0DB2 jne short 0x0D79
19FC:0DB4 mov DL,CH
19FC:0DB6 xor DH,DH
19FC:0DB8 mov CH,DH
19FC:0DBA add DX,CX
19FC:0DBC shr DX,1
19FC:0DBE mov CX,SI
19FC:0DC0 mov SI,0x09FB
19FC:0DC3 add SI,word ptr DS:[0x09F9]
19FC:0DC7 mov AH,byte ptr DS:[SI]
19FC:0DC9 mov SI,CX
19FC:0DCB mov DH,AL
19FC:0DCD shr DH,1
19FC:0DCF shr DH,1
19FC:0DD1 shr DH,1
19FC:0DD3 cmp DH,9
19FC:0DD6 jne short 0x0DDA
19FC:0DD8 dec DH
19FC:0DDA shl DH,1
19FC:0DDC mov CH,DH
19FC:0DDE shl DH,1
19FC:0DE0 dec DH
19FC:0DE2 and DH,AH
19FC:0DE4 sub DH,CH
19FC:0DE6 add DL,DH
19FC:0DE8 cmp DL,0x80
19FC:0DEB jb short 0x0DEF
19FC:0DED xor DL,DL
19FC:0DEF mov byte ptr DS:[BX+DI],DL
19FC:0DF1 inc byte ptr DS:[0x09F9]
19FC:0DF5 jmp short 0x0D79
19FC:0DF7 ret near
19FC:0DF8 cmp SI,0x0279
19FC:0DFC jne short 0x0E01
19FC:0DFE jmp near 0x0FED
19FC:0E01 sub SI,4
19FC:0E04 mov DH,byte ptr DS:[SI]
19FC:0E06 mov DL,byte ptr DS:[SI+1]
19FC:0E09 sub DL,DH
19FC:0E0B cmp DL,1
19FC:0E0E je short 0x0DF8
19FC:0E10 mov DL,byte ptr DS:[SI+3]
19FC:0E13 xor BH,BH
19FC:0E15 mov AH,BH
19FC:0E17 mov BL,DH
19FC:0E19 mov AL,byte ptr DS:[BX+DI]
19FC:0E1B mov BL,DL
19FC:0E1D mov BL,byte ptr DS:[BX+DI]
19FC:0E1F add AX,BX
19FC:0E21 mov BL,byte ptr DS:[SI+1]
19FC:0E24 mov BL,byte ptr DS:[BX+DI]
19FC:0E26 add AX,BX
19FC:0E28 mov BL,byte ptr DS:[SI+2]
19FC:0E2B mov BL,byte ptr DS:[BX+DI]
19FC:0E2D add AX,BX
19FC:0E2F shr AX,1
19FC:0E31 shr AX,1
19FC:0E33 mov CL,DL
19FC:0E35 sub CL,DH
19FC:0E37 shr CL,1
19FC:0E39 mov BL,CL
19FC:0E3B add BL,DH
19FC:0E3D mov AH,byte ptr DS:[BX+DI]
19FC:0E3F cmp AH,0xFF
19FC:0E42 jne short 0x0E46
19FC:0E44 mov byte ptr DS:[BX+DI],AL
19FC:0E46 mov byte ptr DS:[0x0272],DH
19FC:0E4A mov byte ptr DS:[0x0275],DL
19FC:0E4E mov byte ptr DS:[0x0276],BL
19FC:0E52 mov AL,byte ptr DS:[SI+1]
19FC:0E55 mov byte ptr DS:[0x0273],AL
19FC:0E58 mov AL,byte ptr DS:[SI+2]
19FC:0E5B mov byte ptr DS:[0x0274],AL
19FC:0E5E mov byte ptr DS:[SI],DH
19FC:0E60 mov byte ptr DS:[SI+3],BL
19FC:0E63 mov byte ptr DS:[SI+6],BL
19FC:0E66 mov byte ptr DS:[SI+9],BL
19FC:0E69 mov byte ptr DS:[SI+0x0C],BL
19FC:0E6C mov AL,byte ptr DS:[0x0273]
19FC:0E6F sub AL,DH
19FC:0E71 shr AL,1
19FC:0E73 mov byte ptr DS:[0x0277],AL
19FC:0E76 mov BL,byte ptr DS:[0x0272]
19FC:0E7A xor DH,DH
19FC:0E7C mov DL,byte ptr DS:[BX+DI]
19FC:0E7E mov BL,byte ptr DS:[0x0273]
19FC:0E82 mov byte ptr DS:[SI+5],BL
19FC:0E85 mov BL,byte ptr DS:[BX+DI]
19FC:0E87 add DX,BX
19FC:0E89 shr DX,1
19FC:0E8B mov BL,AL
19FC:0E8D add BL,byte ptr DS:[0x0272]
19FC:0E91 mov byte ptr DS:[SI+1],BL
19FC:0E94 mov byte ptr DS:[SI+4],BL
19FC:0E97 mov AH,byte ptr DS:[BX+DI]
19FC:0E99 cmp AH,0xFF
19FC:0E9C jne short 0x0EC8
19FC:0E9E mov CX,SI
19FC:0EA0 mov SI,0x09FB
19FC:0EA3 add SI,word ptr DS:[0x09F9]
19FC:0EA7 inc byte ptr DS:[0x09F9]
19FC:0EAB mov AH,byte ptr DS:[SI]
19FC:0EAD mov SI,CX
19FC:0EAF mov CL,AL
19FC:0EB1 shl CL,1
19FC:0EB3 mov CH,CL
19FC:0EB5 shl CL,1
19FC:0EB7 dec CL
19FC:0EB9 and CL,AH
19FC:0EBB sub CL,CH
19FC:0EBD add DL,CL
19FC:0EBF cmp DL,0x80
19FC:0EC2 jb short 0x0EC6
19FC:0EC4 xor DL,DL
19FC:0EC6 mov byte ptr DS:[BX+DI],DL
19FC:0EC8 mov CL,byte ptr DS:[0x0274]
19FC:0ECC sub CL,byte ptr DS:[0x0272]
19FC:0ED0 shr CL,1
19FC:0ED2 mov byte ptr DS:[0x0278],CL
19FC:0ED6 mov BL,byte ptr DS:[0x0272]
19FC:0EDA mov DL,byte ptr DS:[BX+DI]
19FC:0EDC xor DH,DH
19FC:0EDE mov BL,byte ptr DS:[0x0274]
19FC:0EE2 mov BL,byte ptr DS:[BX+DI]
19FC:0EE4 add DX,BX
19FC:0EE6 shr DX,1
19FC:0EE8 mov BL,CL
19FC:0EEA add BL,byte ptr DS:[0x0272]
19FC:0EEE mov byte ptr DS:[SI+2],BL
19FC:0EF1 mov byte ptr DS:[SI+8],BL
19FC:0EF4 mov AH,byte ptr DS:[BX+DI]
19FC:0EF6 cmp AH,0xFF
19FC:0EF9 jne short 0x0F34
19FC:0EFB mov CX,SI
19FC:0EFD mov SI,0x09FB
19FC:0F00 add SI,word ptr DS:[0x09F9]
19FC:0F04 inc byte ptr DS:[0x09F9]
19FC:0F08 mov AH,byte ptr DS:[SI]
19FC:0F0A mov SI,CX
19FC:0F0C mov DH,byte ptr DS:[0x0278]
19FC:0F10 shr DH,1
19FC:0F12 shr DH,1
19FC:0F14 shr DH,1
19FC:0F16 cmp DH,9
19FC:0F19 jne short 0x0F1D
19FC:0F1B dec DH
19FC:0F1D shl DH,1
19FC:0F1F mov CH,DH
19FC:0F21 shl DH,1
19FC:0F23 dec DH
19FC:0F25 and DH,AH
19FC:0F27 sub DH,CH
19FC:0F29 add DL,DH
19FC:0F2B cmp DL,0x80
19FC:0F2E jb short 0x0F32
19FC:0F30 xor DL,DL
19FC:0F32 mov byte ptr DS:[BX+DI],DL
19FC:0F34 mov BL,byte ptr DS:[0x0274]
19FC:0F38 mov byte ptr DS:[SI+0x0A],BL
19FC:0F3B mov DL,byte ptr DS:[BX+DI]
19FC:0F3D mov BL,byte ptr DS:[0x0275]
19FC:0F41 mov byte ptr DS:[SI+0x0F],BL
19FC:0F44 mov BL,byte ptr DS:[BX+DI]
19FC:0F46 add DX,BX
19FC:0F48 shr DX,1
19FC:0F4A mov BL,byte ptr DS:[0x0277]
19FC:0F4E add BL,byte ptr DS:[0x0274]
19FC:0F52 mov byte ptr DS:[SI+0x0B],BL
19FC:0F55 mov byte ptr DS:[SI+0x0E],BL
19FC:0F58 mov AH,byte ptr DS:[BX+DI]
19FC:0F5A cmp AH,0xFF
19FC:0F5D jne short 0x0F8B
19FC:0F5F mov CX,SI
19FC:0F61 mov SI,0x09FB
19FC:0F64 add SI,word ptr DS:[0x09F9]
19FC:0F68 inc byte ptr DS:[0x09F9]
19FC:0F6C mov AH,byte ptr DS:[SI]
19FC:0F6E mov SI,CX
19FC:0F70 mov CL,byte ptr DS:[0x0277]
19FC:0F74 shl CL,1
19FC:0F76 mov CH,CL
19FC:0F78 shl CL,1
19FC:0F7A dec CL
19FC:0F7C and CL,AH
19FC:0F7E sub CL,CH
19FC:0F80 add DL,CL
19FC:0F82 cmp DL,0x80
19FC:0F85 jb short 0x0F89
19FC:0F87 xor DL,DL
19FC:0F89 mov byte ptr DS:[BX+DI],DL
19FC:0F8B mov BL,byte ptr DS:[0x0273]
19FC:0F8F mov DL,byte ptr DS:[BX+DI]
19FC:0F91 mov BL,byte ptr DS:[0x0275]
19FC:0F95 mov BL,byte ptr DS:[BX+DI]
19FC:0F97 add DX,BX
19FC:0F99 shr DX,1
19FC:0F9B mov BL,byte ptr DS:[0x0278]
19FC:0F9F add BL,byte ptr DS:[0x0273]
19FC:0FA3 mov byte ptr DS:[SI+7],BL
19FC:0FA6 mov byte ptr DS:[SI+0x0D],BL
19FC:0FA9 mov AH,byte ptr DS:[BX+DI]
19FC:0FAB cmp AH,0xFF
19FC:0FAE jne short 0x0FE7
19FC:0FB0 mov CX,SI
19FC:0FB2 mov SI,0x09FB
19FC:0FB5 add SI,word ptr DS:[0x09F9]
19FC:0FB9 inc byte ptr DS:[0x09F9]
19FC:0FBD mov AH,byte ptr DS:[SI]
19FC:0FBF mov SI,CX
19FC:0FC1 mov DH,AL
19FC:0FC3 shr DH,1
19FC:0FC5 shr DH,1
19FC:0FC7 shr DH,1
19FC:0FC9 cmp DH,9
19FC:0FCC jne short 0x0FD0
19FC:0FCE dec DH
19FC:0FD0 shl DH,1
19FC:0FD2 mov CH,DH
19FC:0FD4 shl DH,1
19FC:0FD6 dec DH
19FC:0FD8 and DH,AH
19FC:0FDA sub DH,CH
19FC:0FDC add DL,DH
19FC:0FDE cmp DL,0x80
19FC:0FE1 jb short 0x0FE5
19FC:0FE3 xor DL,DL
19FC:0FE5 mov byte ptr DS:[BX+DI],DL
19FC:0FE7 add SI,0x0010
19FC:0FEA jmp near 0x0DF8
19FC:0FED ret near
19FC:0FEE push BP
19FC:0FEF mov BP,SP
19FC:0FF1 push DI
19FC:0FF2 push SI
19FC:0FF3 push DS
19FC:0FF4 mov AX,0x1DE9
19FC:0FF7 mov DS,AX
19FC:0FF9 mov SI,word ptr SS:[BP+6]
19FC:0FFC mov AX,word ptr SS:[BP+8]
19FC:0FFF push ES
19FC:1000 mov ES,AX
19FC:1002 mov BX,0
19FC:1005 mov AL,byte ptr ES:[SI]
19FC:1008 xor AH,AH
19FC:100A shr AL,1
19FC:100C shr AL,1
19FC:100E shr AL,1
19FC:1010 shr AL,1
19FC:1012 mov DI,AX
19FC:1014 mov CH,byte ptr DS:[DI-23463]
19FC:1018 mov AL,byte ptr ES:[SI]
19FC:101B and AL,7
19FC:101D mov DI,AX
19FC:101F mov CL,byte ptr DS:[DI-23463]
19FC:1023 inc SI
19FC:1024 mov AL,byte ptr ES:[SI]
19FC:1027 inc SI
19FC:1028 mov DI,AX
19FC:102A mov DH,byte ptr DS:[DI-23463]
19FC:102E mov AX,0x1010
19FC:1031 int 0x10
19FC:1033 push BX
19FC:1034 shl BX,1
19FC:1036 shl BX,1
19FC:1038 shl BX,1
19FC:103A shl BX,1
19FC:103C mov AX,0x1010
19FC:103F int 0x10
19FC:1041 pop BX
19FC:1042 inc BX
19FC:1043 cmp BX,0x0010
19FC:1046 jb short 0x1005
19FC:1048 pop ES
19FC:1049 pop DS
19FC:104A pop SI
19FC:104B pop DI
19FC:104C pop BP
19FC:104D ret far
19FC:104E push BP
19FC:104F mov BP,SP
19FC:1051 push DI
19FC:1052 push SI
19FC:1053 push DS
19FC:1054 mov AX,0x1DE9
19FC:1057 mov DS,AX
19FC:1059 mov BX,word ptr SS:[BP+6]
19FC:105C sub BX,0x0011
19FC:105F mov DI,0x02D3
19FC:1062 mov AL,byte ptr DS:[BX+0x0B0B]
19FC:1066 mov byte ptr DS:[DI],AL
19FC:1068 mov AL,byte ptr DS:[BX+0x0B0C]
19FC:106C mov byte ptr DS:[DI+8],AL
19FC:106F mov AL,byte ptr DS:[BX+0x0B1B]
19FC:1073 mov byte ptr DS:[DI+0x48],AL
19FC:1076 mov AL,byte ptr DS:[BX+0x0B1C]
19FC:107A mov byte ptr DS:[DI+0x50],AL
19FC:107D mov SI,0x0564
19FC:1080 push BX
19FC:1081 call near 0x0BFB
19FC:1084 pop BX
19FC:1085 mov DI,0x02D3
19FC:1088 mov AL,byte ptr DS:[BX+0x0B0C]
19FC:108C mov byte ptr DS:[DI],AL
19FC:108E mov AL,byte ptr DS:[BX+0x0B0D]
19FC:1092 mov byte ptr DS:[DI+8],AL
19FC:1095 mov AL,byte ptr DS:[BX+0x0B1C]
19FC:1099 mov byte ptr DS:[DI+0x48],AL
19FC:109C mov AL,byte ptr DS:[BX+0x0B1D]
19FC:10A0 mov byte ptr DS:[DI+0x50],AL
19FC:10A3 mov SI,0x05A4
19FC:10A6 push BX
19FC:10A7 call near 0x0BFB
19FC:10AA pop BX
19FC:10AB mov DI,0x02D3
19FC:10AE mov AL,byte ptr DS:[BX+0x0B0D]
19FC:10B2 mov byte ptr DS:[DI],AL
19FC:10B4 mov AL,byte ptr DS:[BX+0x0B0E]
19FC:10B8 mov byte ptr DS:[DI+8],AL
19FC:10BB mov AL,byte ptr DS:[BX+0x0B1D]
19FC:10BF mov byte ptr DS:[DI+0x48],AL
19FC:10C2 mov AL,byte ptr DS:[BX+0x0B1E]
19FC:10C6 mov byte ptr DS:[DI+0x50],AL
19FC:10C9 mov SI,0x05E4
19FC:10CC push BX
19FC:10CD call near 0x0BFB
19FC:10D0 pop BX
19FC:10D1 mov DI,0x02D3
19FC:10D4 mov AL,byte ptr DS:[BX+0x0B1B]
19FC:10D8 mov byte ptr DS:[DI],AL
19FC:10DA mov AL,byte ptr DS:[BX+0x0B1C]
19FC:10DE mov byte ptr DS:[DI+8],AL
19FC:10E1 mov AL,byte ptr DS:[BX+0x0B2B]
19FC:10E5 mov byte ptr DS:[DI+0x48],AL
19FC:10E8 mov AL,byte ptr DS:[BX+0x0B2C]
19FC:10EC mov byte ptr DS:[DI+0x50],AL
19FC:10EF mov SI,0x0624
19FC:10F2 push BX
19FC:10F3 call near 0x0BFB
19FC:10F6 pop BX
19FC:10F7 mov DI,0x02D3
19FC:10FA mov AL,byte ptr DS:[BX+0x0B1C]
19FC:10FE mov byte ptr DS:[DI],AL
19FC:1100 mov AL,byte ptr DS:[BX+0x0B1D]
19FC:1104 mov byte ptr DS:[DI+8],AL
19FC:1107 mov AL,byte ptr DS:[BX+0x0B2C]
19FC:110B mov byte ptr DS:[DI+0x48],AL
19FC:110E mov AL,byte ptr DS:[BX+0x0B2D]
19FC:1112 mov byte ptr DS:[DI+0x50],AL
19FC:1115 mov SI,0x0664
19FC:1118 push BX
19FC:1119 call near 0x0BFB
19FC:111C pop BX
19FC:111D mov DI,0x02D3
19FC:1120 mov AL,byte ptr DS:[BX+0x0B1D]
19FC:1124 mov byte ptr DS:[DI],AL
19FC:1126 mov AL,byte ptr DS:[BX+0x0B1E]
19FC:112A mov byte ptr DS:[DI+8],AL
19FC:112D mov AL,byte ptr DS:[BX+0x0B2D]
19FC:1131 mov byte ptr DS:[DI+0x48],AL
19FC:1134 mov AL,byte ptr DS:[BX+0x0B2E]
19FC:1138 mov byte ptr DS:[DI+0x50],AL
19FC:113B mov SI,0x06A4
19FC:113E push BX
19FC:113F call near 0x0BFB
19FC:1142 pop BX
19FC:1143 mov DI,0x02D3
19FC:1146 mov AL,byte ptr DS:[BX+0x0B2B]
19FC:114A mov byte ptr DS:[DI],AL
19FC:114C mov AL,byte ptr DS:[BX+0x0B2C]
19FC:1150 mov byte ptr DS:[DI+8],AL
19FC:1153 mov AL,byte ptr DS:[BX+0x0B3B]
19FC:1157 mov byte ptr DS:[DI+0x48],AL
19FC:115A mov AL,byte ptr DS:[BX+0x0B3C]
19FC:115E mov byte ptr DS:[DI+0x50],AL
19FC:1161 mov SI,0x06E4
19FC:1164 push BX
19FC:1165 call near 0x0BFB
19FC:1168 pop BX
19FC:1169 mov DI,0x02D3
19FC:116C mov AL,byte ptr DS:[BX+0x0B2C]
19FC:1170 mov byte ptr DS:[DI],AL
19FC:1172 mov AL,byte ptr DS:[BX+0x0B2D]
19FC:1176 mov byte ptr DS:[DI+8],AL
19FC:1179 mov AL,byte ptr DS:[BX+0x0B3C]
19FC:117D mov byte ptr DS:[DI+0x48],AL
19FC:1180 mov AL,byte ptr DS:[BX+0x0B3D]
19FC:1184 mov byte ptr DS:[DI+0x50],AL
19FC:1187 mov SI,0x0724
19FC:118A push BX
19FC:118B call near 0x0BFB
19FC:118E pop BX
19FC:118F mov DI,0x02D3
19FC:1192 mov AL,byte ptr DS:[BX+0x0B2D]
19FC:1196 mov byte ptr DS:[DI],AL
19FC:1198 mov AL,byte ptr DS:[BX+0x0B2E]
19FC:119C mov byte ptr DS:[DI+8],AL
19FC:119F mov AL,byte ptr DS:[BX+0x0B3D]
19FC:11A3 mov byte ptr DS:[DI+0x48],AL
19FC:11A6 mov AL,byte ptr DS:[BX+0x0B3E]
19FC:11AA mov byte ptr DS:[DI+0x50],AL
19FC:11AD mov SI,0x0764
19FC:11B0 call near 0x0BFB
19FC:11B3 call near 0x1886
19FC:11B6 pop DS
19FC:11B7 pop SI
19FC:11B8 pop DI
19FC:11B9 pop BP
19FC:11BA ret far
19FC:11BB call near 0x12BA
19FC:11BE or AL,AL
19FC:11C0 js short 0x11C5
19FC:11C2 call near 0x12F2
19FC:11C5 mov byte ptr DS:[DI],BL
19FC:11C7 inc SI
19FC:11C8 inc DI
19FC:11C9 mov CX,6
19FC:11CC xor BL,BL
19FC:11CE mov AL,byte ptr DS:[SI]
19FC:11D0 or AL,AL
19FC:11D2 jns short 0x11DB
19FC:11D4 mov BL,AL
19FC:11D6 sub BL,0x80
19FC:11D9 jne short 0x11EE
19FC:11DB call near 0x12F2
19FC:11DE cmp AL,byte ptr DS:[SI-1]
19FC:11E1 jne short 0x11E6
19FC:11E3 or BL,8
19FC:11E6 cmp AL,byte ptr DS:[SI+1]
19FC:11E9 jne short 0x11EE
19FC:11EB or BL,2
19FC:11EE mov byte ptr DS:[DI],BL
19FC:11F0 inc SI
19FC:11F1 inc DI
19FC:11F2 loop 0x11CC
19FC:11F4 call near 0x12D9
19FC:11F7 or AL,AL
19FC:11F9 js short 0x11FE
19FC:11FB call near 0x12F2
19FC:11FE mov byte ptr DS:[DI],BL
19FC:1200 inc SI
19FC:1201 inc DI
19FC:1202 mov DX,6
19FC:1205 call near 0x12BA
19FC:1208 or AL,AL
19FC:120A js short 0x121B
19FC:120C cmp AL,byte ptr DS:[SI+8]
19FC:120F jne short 0x1214
19FC:1211 or BL,4
19FC:1214 cmp AL,byte ptr DS:[SI-8]
19FC:1217 jne short 0x121B
19FC:1219 inc BL
19FC:121B mov byte ptr DS:[DI],BL
19FC:121D inc SI
19FC:121E inc DI
19FC:121F mov CX,6
19FC:1222 xor BL,BL
19FC:1224 mov AL,byte ptr DS:[SI]
19FC:1226 or AL,AL
19FC:1228 jns short 0x1232
19FC:122A mov BL,AL
19FC:122C sub BL,0x80
19FC:122F jmp short 0x1251
19FC:1232 cmp AL,byte ptr DS:[SI-1]
19FC:1235 jne short 0x123A
19FC:1237 or BL,8
19FC:123A cmp AL,byte ptr DS:[SI+8]
19FC:123D jne short 0x1242
19FC:123F or BL,4
19FC:1242 cmp AL,byte ptr DS:[SI+1]
19FC:1245 jne short 0x124A
19FC:1247 or BL,2
19FC:124A cmp AL,byte ptr DS:[SI-8]
19FC:124D jne short 0x1251
19FC:124F inc BL
19FC:1251 mov byte ptr DS:[DI],BL
19FC:1253 inc SI
19FC:1254 inc DI
19FC:1255 loop 0x1222
19FC:1257 call near 0x12D9
19FC:125A or AL,AL
19FC:125C js short 0x126D
19FC:125E cmp AL,byte ptr DS:[SI+8]
19FC:1261 jne short 0x1266
19FC:1263 or BL,4
19FC:1266 cmp AL,byte ptr DS:[SI-8]
19FC:1269 jne short 0x126D
19FC:126B inc BL
19FC:126D mov byte ptr DS:[DI],BL
19FC:126F inc SI
19FC:1270 inc DI
19FC:1271 dec DX
19FC:1272 jne short 0x1205
19FC:1274 call near 0x12BA
19FC:1277 or AL,AL
19FC:1279 js short 0x127E
19FC:127B call near 0x1303
19FC:127E mov byte ptr DS:[DI],BL
19FC:1280 inc SI
19FC:1281 inc DI
19FC:1282 mov CX,6
19FC:1285 xor BL,BL
19FC:1287 mov AL,byte ptr DS:[SI]
19FC:1289 or AL,AL
19FC:128B jns short 0x1294
19FC:128D mov BL,AL
19FC:128F sub BL,0x80
19FC:1292 jne short 0x12A7
19FC:1294 cmp AL,byte ptr DS:[SI-1]
19FC:1297 jne short 0x129C
19FC:1299 or BL,8
19FC:129C cmp AL,byte ptr DS:[SI+1]
19FC:129F jne short 0x12A4
19FC:12A1 or BL,2
19FC:12A4 call near 0x1303
19FC:12A7 mov byte ptr DS:[DI],BL
19FC:12A9 inc SI
19FC:12AA inc DI
19FC:12AB loop 0x1285
19FC:12AD call near 0x12D9
19FC:12B0 or AL,AL
19FC:12B2 js short 0x12B7
19FC:12B4 call near 0x1303
19FC:12B7 mov byte ptr DS:[DI],BL
19FC:12B9 ret near
19FC:12BA xor BL,BL
19FC:12BC mov AL,byte ptr DS:[SI]
19FC:12BE or AL,AL
19FC:12C0 js short 0x12D3
19FC:12C2 cmp AL,byte ptr DS:[SI-57]
19FC:12C5 jne short 0x12CA
19FC:12C7 or BL,8
19FC:12CA cmp AL,byte ptr DS:[SI+1]
19FC:12CD jne short 0x12D2
19FC:12CF or BL,2
19FC:12D2 ret near
19FC:12D3 mov BL,AL
19FC:12D5 sub BL,0x80
19FC:12D8 ret near
19FC:12D9 xor BL,BL
19FC:12DB mov AL,byte ptr DS:[SI]
19FC:12DD or AL,AL
19FC:12DF js short 0x12D3
19FC:12E1 cmp AL,byte ptr DS:[SI-1]
19FC:12E4 jne short 0x12E9
19FC:12E6 or BL,8
19FC:12E9 cmp AL,byte ptr DS:[SI+0x39]
19FC:12EC jne short 0x12F1
19FC:12EE or BL,2
19FC:12F1 ret near
19FC:12F2 cmp AL,byte ptr DS:[SI-136]
19FC:12F6 jne short 0x12FA
19FC:12F8 inc BL
19FC:12FA cmp AL,byte ptr DS:[SI+8]
19FC:12FD jne short 0x1302
19FC:12FF or BL,4
19FC:1302 ret near
19FC:1303 cmp AL,byte ptr DS:[SI-8]
19FC:1306 jne short 0x130A
19FC:1308 inc BL
19FC:130A cmp AL,byte ptr DS:[SI+0x0088]
19FC:130E jne short 0x1313
19FC:1310 or BL,4
19FC:1313 ret near
19FC:1314 push BP
19FC:1315 mov BP,SP
19FC:1317 push DI
19FC:1318 push SI
19FC:1319 push DS
19FC:131A mov AX,0x1DE9
19FC:131D mov DS,AX
19FC:131F mov AX,word ptr SS:[BP+6]
19FC:1322 mov word ptr DS:[0x02CF],AX
19FC:1325 mov BX,word ptr SS:[BP+8]
19FC:1328 mov word ptr DS:[0x02D1],BX
19FC:132C shr BL,1
19FC:132E shr BL,1
19FC:1330 shr BL,1
19FC:1332 shr BL,1
19FC:1334 mov byte ptr DS:[0x02CE],BL
19FC:1338 shr AL,1
19FC:133A shr AL,1
19FC:133C shr AL,1
19FC:133E shr AL,1
19FC:1340 mov byte ptr DS:[0x02CD],AL
19FC:1343 mov DI,0x07AD
19FC:1346 dec AL
19FC:1348 dec BL
19FC:134A call near 0x13D9
19FC:134D mov byte ptr DS:[0x07A4],AL
19FC:1350 mov BL,byte ptr DS:[0x02CE]
19FC:1354 mov AL,byte ptr DS:[0x02CD]
19FC:1357 dec BL
19FC:1359 call near 0x13D9
19FC:135C mov byte ptr DS:[0x07A5],AL
19FC:135F mov BL,byte ptr DS:[0x02CE]
19FC:1363 dec BL
19FC:1365 mov AL,byte ptr DS:[0x02CD]
19FC:1368 inc AL
19FC:136A call near 0x13D9
19FC:136D add DI,0x00A8
19FC:1371 mov byte ptr DS:[0x07A6],AL
19FC:1374 mov BL,byte ptr DS:[0x02CE]
19FC:1378 mov AL,byte ptr DS:[0x02CD]
19FC:137B dec AL
19FC:137D call near 0x13D9
19FC:1380 mov byte ptr DS:[0x07A7],AL
19FC:1383 mov BL,byte ptr DS:[0x02CE]
19FC:1387 mov AL,byte ptr DS:[0x02CD]
19FC:138A call near 0x13D9
19FC:138D mov byte ptr DS:[0x07A8],AL
19FC:1390 mov BL,byte ptr DS:[0x02CE]
19FC:1394 mov AL,byte ptr DS:[0x02CD]
19FC:1397 inc AL
19FC:1399 call near 0x13D9
19FC:139C add DI,0x00A8
19FC:13A0 mov byte ptr DS:[0x07A9],AL
19FC:13A3 mov BL,byte ptr DS:[0x02CE]
19FC:13A7 inc BL
19FC:13A9 mov AL,byte ptr DS:[0x02CD]
19FC:13AC dec AL
19FC:13AE call near 0x13D9
19FC:13B1 mov byte ptr DS:[0x07AA],AL
19FC:13B4 mov BL,byte ptr DS:[0x02CE]
19FC:13B8 inc BL
19FC:13BA mov AL,byte ptr DS:[0x02CD]
19FC:13BD call near 0x13D9
19FC:13C0 mov byte ptr DS:[0x07AB],AL
19FC:13C3 mov BL,byte ptr DS:[0x02CE]
19FC:13C7 inc BL
19FC:13C9 mov AL,byte ptr DS:[0x02CD]
19FC:13CC inc AL
19FC:13CE call near 0x13D9
19FC:13D1 mov byte ptr DS:[0x07AC],AL
19FC:13D4 pop DS
19FC:13D5 pop SI
19FC:13D6 pop DI
19FC:13D7 pop BP
19FC:13D8 ret far
19FC:13D9 mov SI,0x0424
19FC:13DC mov CL,BL
19FC:13DE mov CH,AL
19FC:13E0 add CL,CH
19FC:13E2 mov CH,CL
19FC:13E4 and CL,3
19FC:13E7 mov byte ptr DS:[0x0273],CL
19FC:13EB shl CH,1
19FC:13ED shl CH,1
19FC:13EF and CH,0x10
19FC:13F2 mov byte ptr DS:[0x0272],CH
19FC:13F6 xor DH,DH
19FC:13F8 mov DL,BL
19FC:13FA shl DL,1
19FC:13FC shl DL,1
19FC:13FE shl DL,1
19FC:1400 add SI,DX
19FC:1402 cmp BL,0xFF
19FC:1405 jne short 0x140D
19FC:1407 mov SI,0x0364
19FC:140A add SI,0x0038
19FC:140D cmp BL,8
19FC:1410 jne short 0x1415
19FC:1412 mov SI,0x04E4
19FC:1415 mov DL,AL
19FC:1417 cmp AL,0xFF
19FC:1419 jne short 0x1420
19FC:141B mov DL,7
19FC:141D sub SI,0x0040
19FC:1420 cmp AL,8
19FC:1422 jne short 0x1429
19FC:1424 xor DL,DL
19FC:1426 add SI,0x0040
19FC:1429 add SI,DX
19FC:142B xor DL,DL
19FC:142D mov CH,byte ptr DS:[SI]
19FC:142F mov byte ptr DS:[0x02C9],CH
19FC:1433 mov DH,CH
19FC:1435 shr DX,1
19FC:1437 shr DX,1
19FC:1439 sub SI,0x0324
19FC:143D add SI,0x0564
19FC:1441 mov BL,byte ptr DS:[SI]
19FC:1443 mov byte ptr DS:[0x02CA],BL
19FC:1447 mov SI,0x0C1D
19FC:144A or BL,BL
19FC:144C js short 0x1466
19FC:144E je short 0x145F
19FC:1450 cmp BL,0x10
19FC:1453 je short 0x1469
19FC:1455 sub BL,0x10
19FC:1458 cmp BL,0x31
19FC:145B jb short 0x145F
19FC:145D mov BL,0x30
19FC:145F cmp byte ptr DS:[0x0273],0
19FC:1464 jne short 0x146E
19FC:1466 jmp near 0x153A
19FC:1469 mov BL,0x70
19FC:146B jmp near 0x153A
19FC:146E cmp byte ptr DS:[0x0273],2
19FC:1473 jne short 0x14AF
19FC:1475 push DI
19FC:1476 push BX
19FC:1477 mov DI,0x20DD
19FC:147A add DI,7
19FC:147D xor BH,BH
19FC:147F mov BL,CH
19FC:1481 mov CH,byte ptr DS:[BX+0x211D]
19FC:1485 xor CL,CL
19FC:1487 shr CX,1
19FC:1489 shr CX,1
19FC:148B add SI,CX
19FC:148D mov AL,8
19FC:148F mov CX,8
19FC:1492 xor BH,BH
19FC:1494 mov BL,byte ptr DS:[SI]
19FC:1496 cmp BL,0x40
19FC:1499 jae short 0x149F
19FC:149B mov BL,byte ptr DS:[BX+0x211D]
19FC:149F mov byte ptr DS:[DI],BL
19FC:14A1 inc SI
19FC:14A2 dec DI
19FC:14A3 loop 0x1494
19FC:14A5 add DI,0x0010
19FC:14A8 dec AL
19FC:14AA jne short 0x148F
19FC:14AC jmp near 0x1533
19FC:14AF cmp byte ptr DS:[0x0273],1
19FC:14B4 jne short 0x14F0
19FC:14B6 push DI
19FC:14B7 push BX
19FC:14B8 mov DI,0x20DD
19FC:14BB add DI,0x0038
19FC:14BE xor BH,BH
19FC:14C0 mov BL,CH
19FC:14C2 mov CH,byte ptr DS:[BX+0x213D]
19FC:14C6 xor CL,CL
19FC:14C8 shr CX,1
19FC:14CA shr CX,1
19FC:14CC add SI,CX
19FC:14CE mov AL,8
19FC:14D0 mov CX,8
19FC:14D3 xor BH,BH
19FC:14D5 mov BL,byte ptr DS:[SI]
19FC:14D7 cmp BL,0x40
19FC:14DA jae short 0x14E0
19FC:14DC mov BL,byte ptr DS:[BX+0x213D]
19FC:14E0 mov byte ptr DS:[DI],BL
19FC:14E2 inc SI
19FC:14E3 inc DI
19FC:14E4 loop 0x14D5
19FC:14E6 sub DI,0x0010
19FC:14E9 dec AL
19FC:14EB jne short 0x14D0
19FC:14ED jmp short 0x1533
19FC:14F0 cmp byte ptr DS:[0x0273],3
19FC:14F5 jne short 0x153A
19FC:14F7 push DI
19FC:14F8 push BX
19FC:14F9 mov DI,0x20DD
19FC:14FC add DI,0x003F
19FC:14FF xor BH,BH
19FC:1501 mov BL,CH
19FC:1503 mov BL,byte ptr DS:[BX+0x213D]
19FC:1507 mov CH,byte ptr DS:[BX+0x211D]
19FC:150B xor CL,CL
19FC:150D shr CX,1
19FC:150F shr CX,1
19FC:1511 add SI,CX
19FC:1513 mov AL,8
19FC:1515 mov CX,8
19FC:1518 xor BH,BH
19FC:151A mov BL,byte ptr DS:[SI]
19FC:151C cmp BL,0x40
19FC:151F jae short 0x1529
19FC:1521 mov BL,byte ptr DS:[BX+0x213D]
19FC:1525 mov BL,byte ptr DS:[BX+0x211D]
19FC:1529 mov byte ptr DS:[DI],BL
19FC:152B inc SI
19FC:152C dec DI
19FC:152D loop 0x151A
19FC:152F dec AL
19FC:1531 jne short 0x1515
19FC:1533 mov SI,0x20DD
19FC:1536 pop BX
19FC:1537 pop DI
19FC:1538 xor DX,DX
19FC:153A add SI,DX
19FC:153C push ES
19FC:153D mov AX,DS
19FC:153F mov ES,AX
19FC:1541 mov BH,BL
19FC:1543 cld
19FC:1544 mov DX,8
19FC:1547 mov CX,4
19FC:154A or BL,BL
19FC:154C js short 0x1556
19FC:154E cmp BL,0x70
19FC:1551 jne short 0x1565
19FC:1553 mov SI,0x209D
19FC:1556 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1558 add DI,0x0010
19FC:155B mov CX,4
19FC:155E dec DL
19FC:1560 jne short 0x1556
19FC:1562 jmp short 0x157F
19FC:1565 mov AH,byte ptr DS:[0x0272]
19FC:1569 mov CX,8
19FC:156C lods AL,byte ptr DS:[SI]
19FC:156D cmp AL,0x40
19FC:156F jae short 0x1575
19FC:1571 and AL,0x0F
19FC:1573 add AL,BL
19FC:1575 stos byte ptr ES:[DI],AL
19FC:1576 loop 0x156C
19FC:1578 add DI,0x0010
19FC:157B dec DL
19FC:157D jne short 0x1565
19FC:157F sub DI,0x00B8
19FC:1583 pop ES
19FC:1584 mov AL,byte ptr DS:[0x02C9]
19FC:1587 or AL,byte ptr DS:[0x02CA]
19FC:158B ret near
19FC:158C push BP
19FC:158D mov BP,SP
19FC:158F push DI
19FC:1590 push SI
19FC:1591 push DS
19FC:1592 mov AX,0x1DE9
19FC:1595 mov DS,AX
19FC:1597 mov AX,word ptr DS:[0xA44D]
19FC:159A dec AL
19FC:159C js short 0x15A4
19FC:159E mov word ptr DS:[0xA44D],AX
19FC:15A1 jmp near 0x1636
19FC:15A4 cmp AH,0
19FC:15A7 je short 0x15A1
19FC:15A9 sub AH,0x10
19FC:15AC mov AL,0x7F
19FC:15AE mov word ptr DS:[0xA44D],AX
19FC:15B1 push ES
19FC:15B2 mov AX,DS
19FC:15B4 mov ES,AX
19FC:15B6 mov SI,0x06E4
19FC:15B9 sub SI,2
19FC:15BC mov DI,0x0764
19FC:15BF add DI,0x003E
19FC:15C2 mov CX,0x00C0
19FC:15C5 std
19FC:15C6 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:15C8 cld
19FC:15C9 pop ES
19FC:15CA mov DI,0x02D3
19FC:15CD mov AX,word ptr DS:[0xA44D]
19FC:15D0 mov BX,word ptr DS:[0xA44B]
19FC:15D4 or AH,BH
19FC:15D6 mov AL,AH
19FC:15D8 xor AH,AH
19FC:15DA mov SI,AX
19FC:15DC add SI,0x0B0B
19FC:15E0 sub SI,0x0011
19FC:15E3 call near 0x18D8
19FC:1636 pop DS
19FC:1637 pop SI
19FC:1638 pop DI
19FC:1639 pop BP
19FC:163A ret far
19FC:163B push BP
19FC:163C mov BP,SP
19FC:163E push DI
19FC:163F push SI
19FC:1640 push DS
19FC:1641 mov AX,0x1DE9
19FC:1644 mov DS,AX
19FC:1646 mov AX,word ptr DS:[0xA44D]
19FC:1649 inc AL
19FC:164B js short 0x1653
19FC:164D mov word ptr DS:[0xA44D],AX
19FC:1650 jmp near 0x16DE
19FC:1653 cmp AH,0xF0
19FC:1656 je short 0x1650
19FC:1658 add AH,0x10
19FC:165B xor AL,AL
19FC:165D mov word ptr DS:[0xA44D],AX
19FC:1660 push ES
19FC:1661 mov AX,DS
19FC:1663 mov ES,AX
19FC:1665 mov SI,0x0624
19FC:1668 mov DI,0x0564
19FC:166B mov CX,0x00C0
19FC:166E cld
19FC:166F rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1671 pop ES
19FC:1672 mov DI,0x02D3
19FC:1675 mov AX,word ptr DS:[0xA44D]
19FC:1678 mov BX,word ptr DS:[0xA44B]
19FC:167C or AH,BH
19FC:167E mov AL,AH
19FC:1680 xor AH,AH
19FC:1682 mov SI,AX
19FC:1684 add SI,0x0B0B
19FC:1688 add SI,0x000F
19FC:168B call near 0x18D8
19FC:16DE pop DS
19FC:16DF pop SI
19FC:16E0 pop DI
19FC:16E1 pop BP
19FC:16E2 ret far
19FC:16E3 push BP
19FC:16E4 mov BP,SP
19FC:16E6 push DI
19FC:16E7 push SI
19FC:16E8 push DS
19FC:16E9 mov AX,0x1DE9
19FC:16EC mov DS,AX
19FC:16EE mov AX,word ptr DS:[0xA44B]
19FC:16F1 dec AL
19FC:16F3 js short 0x16FB
19FC:16F5 mov word ptr DS:[0xA44B],AX
19FC:16F8 jmp near 0x17C0
19FC:16FB cmp AH,0
19FC:16FE je short 0x16F8
19FC:1700 dec AH
19FC:1702 mov AL,0x7F
19FC:1704 mov word ptr DS:[0xA44B],AX
19FC:1707 push ES
19FC:1708 mov AX,DS
19FC:170A mov ES,AX
19FC:170C mov SI,0x05A4
19FC:170F mov DI,0x05E4
19FC:1712 mov CX,0x0020
19FC:1715 cld
19FC:1716 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1718 mov SI,0x0564
19FC:171B mov DI,0x05A4
19FC:171E mov CX,0x0020
19FC:1721 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1723 mov SI,0x0664
19FC:1726 mov DI,0x06A4
19FC:1729 mov CX,0x0020
19FC:172C rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:172E mov SI,0x0624
19FC:1731 mov DI,0x0664
19FC:1734 mov CX,0x0020
19FC:1737 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1739 mov SI,0x0724
19FC:173C mov DI,0x0764
19FC:173F mov CX,0x0020
19FC:1742 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1744 mov SI,0x06E4
19FC:1747 mov DI,0x0724
19FC:174A mov CX,0x0020
19FC:174D rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:174F pop ES
19FC:1750 mov DI,0x02D3
19FC:1753 mov AX,word ptr DS:[0xA44D]
19FC:1756 mov BX,word ptr DS:[0xA44B]
19FC:175A or AH,BH
19FC:175C mov AL,AH
19FC:175E xor AH,AH
19FC:1760 mov SI,AX
19FC:1762 add SI,0x0B0B
19FC:1766 sub SI,0x0011
19FC:1769 call near 0x18D8
19FC:17C0 pop DS
19FC:17C1 pop SI
19FC:17C2 pop DI
19FC:17C3 pop BP
19FC:17C4 ret far
19FC:17C5 push BP
19FC:17C6 mov BP,SP
19FC:17C8 push DI
19FC:17C9 push SI
19FC:17CA push DS
19FC:17CB mov AX,0x1DE9
19FC:17CE mov DS,AX
19FC:17D0 mov AX,word ptr DS:[0xA44B]
19FC:17D3 inc AL
19FC:17D5 js short 0x17DD
19FC:17D7 mov word ptr DS:[0xA44B],AX
19FC:17DA jmp near 0x1881
19FC:17DD cmp AH,0x0F
19FC:17E0 je short 0x17DA
19FC:17E2 inc AH
19FC:17E4 xor AL,AL
19FC:17E6 mov word ptr DS:[0xA44B],AX
19FC:17E9 push ES
19FC:17EA mov AX,DS
19FC:17EC mov ES,AX
19FC:17EE mov SI,0x05A4
19FC:17F1 mov DI,0x0564
19FC:17F4 mov CX,0x0040
19FC:17F7 cld
19FC:17F8 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:17FA mov SI,0x0664
19FC:17FD mov DI,0x0624
19FC:1800 mov CX,0x0040
19FC:1803 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1805 mov SI,0x0724
19FC:1808 mov DI,0x06E4
19FC:180B mov CX,0x0040
19FC:180E rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1810 pop ES
19FC:1811 mov DI,0x02D3
19FC:1814 mov AX,word ptr DS:[0xA44D]
19FC:1817 mov BX,word ptr DS:[0xA44B]
19FC:181B or AH,BH
19FC:181D mov AL,AH
19FC:181F xor AH,AH
19FC:1821 mov SI,AX
19FC:1823 add SI,0x0B0B
19FC:1827 sub SI,0x000F
19FC:182A call near 0x18D8
19FC:1881 pop DS
19FC:1882 pop SI
19FC:1883 pop DI
19FC:1884 pop BP
19FC:1885 ret far
19FC:1886 mov SI,0x0564
19FC:1889 mov DI,0x0324
19FC:188C call near 0x11BB
19FC:188F mov SI,0x05A4
19FC:1892 mov DI,0x0364
19FC:1895 call near 0x11BB
19FC:1898 mov SI,0x05E4
19FC:189B mov DI,0x03A4
19FC:189E call near 0x11BB
19FC:18A1 mov SI,0x0624
19FC:18A4 mov DI,0x03E4
19FC:18A7 call near 0x11BB
19FC:18AA mov SI,0x0664
19FC:18AD mov DI,0x0424
19FC:18B0 call near 0x11BB
19FC:18B3 mov SI,0x06A4
19FC:18B6 mov DI,0x0464
19FC:18B9 call near 0x11BB
19FC:18BC mov SI,0x06E4
19FC:18BF mov DI,0x04A4
19FC:18C2 call near 0x11BB
19FC:18C5 mov SI,0x0724
19FC:18C8 mov DI,0x04E4
19FC:18CB call near 0x11BB
19FC:18CE mov SI,0x0764
19FC:18D1 mov DI,0x0524
19FC:18D4 call near 0x11BB
19FC:18D7 ret near
19FC:18D8 mov AL,byte ptr DS:[SI]
19FC:18DA mov byte ptr DS:[DI],AL
19FC:18DC mov AL,byte ptr DS:[SI+1]
19FC:18DF mov byte ptr DS:[DI+8],AL
19FC:18E2 mov AL,byte ptr DS:[SI+0x10]
19FC:18E5 mov byte ptr DS:[DI+0x48],AL
19FC:18E8 mov AL,byte ptr DS:[SI+0x11]
19FC:18EB mov byte ptr DS:[DI+0x50],AL
19FC:18EE ret near
19FC:18EF push BP
19FC:18F0 mov BP,SP
19FC:18F2 push DI
19FC:18F3 push SI
19FC:18F4 push DS
19FC:18F5 mov AX,0x1DE9
19FC:18F8 mov DS,AX
19FC:18FA push BP
19FC:18FB push ES
19FC:18FC mov DI,0x0034
19FC:18FF add DI,0x244B
19FC:1903 mov word ptr DS:[0xA452],8
19FC:1909 mov word ptr DS:[0xA454],0x0994
19FC:190F mov word ptr DS:[0xA456],0x0494
19FC:1915 mov AX,DS
19FC:1917 cmp word ptr DS:[0xB764],2
19FC:191C jne short 0x1941
19FC:191E mov DX,0x03CE
19FC:1921 mov AX,0x0205
19FC:1924 out DX,AX
19FC:1925 mov AX,8
19FC:1928 out DX,AX
19FC:1929 mov word ptr DS:[0xA452],2
19FC:192F mov word ptr DS:[0xA454],0x0265
19FC:1935 mov word ptr DS:[0xA456],0x0125
19FC:193B mov AX,0xAC00
19FC:193E mov DI,0x000D
19FC:1941 mov ES,AX
19FC:1943 cmp word ptr DS:[0xB764],0
19FC:1948 jne short 0x1959
19FC:194A sub DI,0x001A
19FC:194D shr word ptr DS:[0xA452],1
19FC:1951 shr word ptr DS:[0xA454],1
19FC:1955 shr word ptr DS:[0xA456],1
19FC:1959 cld
19FC:195A mov AX,word ptr DS:[0xA44D]
19FC:195D shr AL,1
19FC:195F and AX,7
19FC:1962 add AL,2
19FC:1964 shl AX,1
19FC:1966 shl AX,1
19FC:1968 shl AX,1
19FC:196A mov BX,AX
19FC:196C shl AX,1
19FC:196E add AX,BX
19FC:1970 mov BX,word ptr DS:[0xA44B]
19FC:1974 shr BL,1
19FC:1976 and BX,7
19FC:1979 add BL,2
19FC:197C add BX,AX
19FC:197E mov word ptr DS:[0x09ED],BX
19FC:1982 add BX,0x07AD
19FC:1986 mov byte ptr DS:[0xA44F],0
19FC:198B test word ptr DS:[0xA44D],1
19FC:1991 je short 0x19F5
19FC:1993 test word ptr DS:[0xA44B],1
19FC:1999 je short 0x19B7
19FC:199B mov DH,byte ptr DS:[BX]
19FC:199D mov byte ptr DS:[0xA450],0
19FC:19A2 mov byte ptr DS:[0xA44F],1
19FC:19A7 mov byte ptr DS:[0xA451],1
19FC:19AC call near 0x1AA8
19FC:19AF inc BX
19FC:19B0 mov AX,word ptr DS:[0xA452]
19FC:19B3 shr AX,1
19FC:19B5 add DI,AX
19FC:19B7 mov CX,0x000D
19FC:19BA push CX
19FC:19BB mov DH,byte ptr DS:[BX]
19FC:19BD call near 0x1ACE
19FC:19C0 add DI,word ptr DS:[0xA452]
19FC:19C4 inc BX
19FC:19C5 pop CX
19FC:19C6 loop 0x19BA
19FC:19C8 test word ptr DS:[0xA44B],1
19FC:19CE jne short 0x19EE
19FC:19D0 mov DH,byte ptr DS:[BX]
19FC:19D2 mov DL,1
19FC:19D4 mov byte ptr DS:[0xA44F],1
19FC:19D9 mov byte ptr DS:[0xA450],1
19FC:19DE mov byte ptr DS:[0xA451],1
19FC:19E3 call near 0x1AA8
19FC:19EE add BX,0x000A
19FC:19F1 add DI,word ptr DS:[0xA456]
19FC:19F5 xor AL,AL
19FC:19F7 mov byte ptr DS:[0xA44F],AL
19FC:19FA mov byte ptr DS:[0xA450],AL
19FC:19FD mov byte ptr DS:[0xA451],AL
19FC:1A00 mov byte ptr DS:[0xA458],0x0C
19FC:1A05 test word ptr DS:[0xA44B],1
19FC:1A0B je short 0x1A1F
19FC:1A0D mov DH,byte ptr DS:[BX]
19FC:1A0F mov byte ptr DS:[0xA450],0
19FC:1A14 call near 0x1AA8
19FC:1A17 inc BX
19FC:1A18 mov AX,word ptr DS:[0xA452]
19FC:1A1B shr AX,1
19FC:1A1D add DI,AX
19FC:1A1F mov CX,0x000D
19FC:1A22 mov DH,byte ptr DS:[BX]
19FC:1A24 push CX
19FC:1A25 call near 0x1AF4
19FC:1A28 inc BX
19FC:1A29 add DI,word ptr DS:[0xA452]
19FC:1A2D pop CX
19FC:1A2E loop 0x1A22
19FC:1A30 test word ptr DS:[0xA44B],1
19FC:1A36 jne short 0x1A4A
19FC:1A38 mov DH,byte ptr DS:[BX]
19FC:1A3A mov byte ptr DS:[0xA450],1
19FC:1A3F call near 0x1AA8
19FC:1A4A add BX,0x000A
19FC:1A4D add DI,word ptr DS:[0xA454]
19FC:1A51 dec byte ptr DS:[0xA458]
19FC:1A55 jne short 0x1A05
19FC:1A57 test word ptr DS:[0xA44D],1
19FC:1A5D jne short 0x1AA1
19FC:1A5F mov byte ptr DS:[0xA44F],1
19FC:1A64 test word ptr DS:[0xA44B],1
19FC:1A6A je short 0x1A7E
19FC:1A6C mov DH,byte ptr DS:[BX]
19FC:1A6E mov byte ptr DS:[0xA450],0
19FC:1A73 call near 0x1AA8
19FC:1A7E mov CX,0x000D
19FC:1A81 push CX
19FC:1A82 mov DH,byte ptr DS:[BX]
19FC:1A84 call near 0x1AF4
19FC:1AA1 pop ES
19FC:1AA2 pop BP
19FC:1AA3 pop DS
19FC:1AA4 pop SI
19FC:1AA5 pop DI
19FC:1AA6 pop BP
19FC:1AA7 ret far
19FC:1AA8 mov BP,BX
19FC:1AAA push DI
19FC:1AAB xor DL,DL
19FC:1AAD cmp word ptr DS:[0xB764],2
19FC:1AB2 je short 0x1AC7
19FC:1AB4 shr DX,1
19FC:1AB6 add DX,word ptr DS:[0x026E]
19FC:1ABA mov SI,DX
19FC:1ABC mov DX,word ptr DS:[0x0270]
19FC:1AC0 call near 0x1BFC
19FC:1AC3 pop DI
19FC:1AC4 mov BX,BP
19FC:1AC6 ret near
19FC:1AC7 call near 0x1C83
19FC:1ACE mov BP,BX
19FC:1AD0 push DI
19FC:1AD1 xor DL,DL
19FC:1AD3 cmp word ptr DS:[0xB764],2
19FC:1AD8 je short 0x1AED
19FC:1ADA shr DX,1
19FC:1ADC add DX,word ptr DS:[0x026E]
19FC:1AE0 mov SI,DX
19FC:1AE2 mov DX,word ptr DS:[0x0270]
19FC:1AE6 call near 0x1B94
19FC:1AE9 pop DI
19FC:1AEA mov BX,BP
19FC:1AEC ret near
19FC:1AED call near 0x1BDF
19FC:1AF4 mov BP,BX
19FC:1AF6 push DI
19FC:1AF7 xor DL,DL
19FC:1AF9 cmp word ptr DS:[0xB764],2
19FC:1AFE je short 0x1B13
19FC:1B00 shr DX,1
19FC:1B02 add DX,word ptr DS:[0x026E]
19FC:1B06 mov SI,DX
19FC:1B08 mov DX,word ptr DS:[0x0270]
19FC:1B0C call near 0x1B1A
19FC:1B0F pop DI
19FC:1B10 mov BX,BP
19FC:1B12 ret near
19FC:1B13 call near 0x1B71
19FC:1B1A cmp word ptr DS:[0xB764],0
19FC:1B1F je short 0x1B54
19FC:1B21 mov CX,4
19FC:1B24 cmp byte ptr DS:[0xA44F],0
19FC:1B29 je short 0x1B2D
19FC:1B2B shr CX,1
19FC:1B2D push DS
19FC:1B2E mov DS,DX
19FC:1B30 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B31 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B32 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B33 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B34 add DI,0x0098
19FC:1B38 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B39 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B3A movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B3B movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B3C add DI,0x0098
19FC:1B40 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B41 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B42 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B43 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B44 add DI,0x0098
19FC:1B48 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B49 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B4A movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B4B movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B4C add DI,0x0098
19FC:1B50 loop 0x1B30
19FC:1B52 pop DS
19FC:1B53 ret near
19FC:1B54 mov CX,8
19FC:1B57 cmp byte ptr DS:[0xA44F],0
19FC:1B5C je short 0x1B60
19FC:1B5E shr CX,1
19FC:1B60 push DS
19FC:1B61 mov DS,DX
19FC:1B63 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B64 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B65 add DI,0x004C
19FC:1B68 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B69 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1B6A add DI,0x004C
19FC:1B6D loop 0x1B63
19FC:1B6F pop DS
19FC:1B70 ret near
19FC:1B71 shr DX,1
19FC:1B73 shr DX,1
19FC:1B75 shr DX,1
19FC:1B77 mov SI,DX
19FC:1B79 mov CX,0x0010
19FC:1B7C cmp byte ptr DS:[0xA44F],0
19FC:1B81 je short 0x1B85
19FC:1B83 shr CX,1
19FC:1B85 push DS
19FC:1B86 mov AX,0xA400
19FC:1B89 mov DS,AX
19FC:1B8B movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1B8C movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1B8D add DI,0x0026
19FC:1B90 loop 0x1B8B
19FC:1B92 pop DS
19FC:1B93 ret near
19FC:1B94 cmp word ptr DS:[0xB764],0
19FC:1B99 je short 0x1BC8
19FC:1B9B add SI,0x0040
19FC:1B9E mov CX,2
19FC:1BA1 push DS
19FC:1BA2 mov DS,DX
19FC:1BA4 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BA5 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BA6 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BA7 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BA8 add DI,0x0098
19FC:1BAC movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BAD movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BAE movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BAF movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BB0 add DI,0x0098
19FC:1BB4 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BB5 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BB6 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BB7 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BB8 add DI,0x0098
19FC:1BBC movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BBD movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BBE movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BBF movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BC0 add DI,0x0098
19FC:1BC4 loop 0x1BA4
19FC:1BC6 pop DS
19FC:1BC7 ret near
19FC:1BC8 add SI,0x0020
19FC:1BCB mov CX,4
19FC:1BCE push DS
19FC:1BCF mov DS,DX
19FC:1BD1 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BD2 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BD3 add DI,0x004C
19FC:1BD6 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BD7 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1BD8 add DI,0x004C
19FC:1BDB loop 0x1BD1
19FC:1BDD pop DS
19FC:1BDE ret near
19FC:1BDF shr DX,1
19FC:1BE1 shr DX,1
19FC:1BE3 shr DX,1
19FC:1BE5 add DX,0x0010
19FC:1BE8 mov SI,DX
19FC:1BEA mov CX,8
19FC:1BED push DS
19FC:1BEE mov AX,0xA400
19FC:1BF1 mov DS,AX
19FC:1BF3 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1BF4 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1BF5 add DI,0x0026
19FC:1BF8 loop 0x1BF3
19FC:1BFA pop DS
19FC:1BFB ret near
19FC:1BFC cmp word ptr DS:[0xB764],0
19FC:1C01 je short 0x1C4E
19FC:1C03 cmp byte ptr DS:[0xA451],0
19FC:1C08 je short 0x1C0D
19FC:1C0A add SI,0x0040
19FC:1C0D cmp byte ptr DS:[0xA450],0
19FC:1C12 jne short 0x1C17
19FC:1C14 add SI,4
19FC:1C17 mov CX,4
19FC:1C1A cmp byte ptr DS:[0xA44F],0
19FC:1C1F je short 0x1C23
19FC:1C21 shr CX,1
19FC:1C23 push DS
19FC:1C24 mov DS,DX
19FC:1C26 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C27 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C28 add SI,4
19FC:1C2B add DI,0x009C
19FC:1C2F movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C30 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C31 add SI,4
19FC:1C34 add DI,0x009C
19FC:1C38 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C39 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C3A add SI,4
19FC:1C3D add DI,0x009C
19FC:1C41 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C42 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C43 add SI,4
19FC:1C46 add DI,0x009C
19FC:1C4A loop 0x1C26
19FC:1C4C pop DS
19FC:1C4D ret near
19FC:1C4E cmp byte ptr DS:[0xA451],0
19FC:1C53 je short 0x1C58
19FC:1C55 add SI,0x0020
19FC:1C58 cmp byte ptr DS:[0xA450],0
19FC:1C5D jne short 0x1C62
19FC:1C5F add SI,2
19FC:1C62 mov CX,8
19FC:1C65 cmp byte ptr DS:[0xA44F],0
19FC:1C6A je short 0x1C6E
19FC:1C6C shr CX,1
19FC:1C6E push DS
19FC:1C6F mov DS,DX
19FC:1C71 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C72 add DI,0x004E
19FC:1C75 add SI,2
19FC:1C78 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1C79 add DI,0x004E
19FC:1C7C add SI,2
19FC:1C7F loop 0x1C71
19FC:1C81 pop DS
19FC:1C82 ret near
19FC:1C83 shr DX,1
19FC:1C85 shr DX,1
19FC:1C87 shr DX,1
19FC:1C89 cmp byte ptr DS:[0xA451],0
19FC:1C8E je short 0x1C93
19FC:1C90 add DX,0x0010
19FC:1C93 cmp byte ptr DS:[0xA450],0
19FC:1C98 jne short 0x1C9B
19FC:1C9A inc DX
19FC:1C9B mov SI,DX
19FC:1C9D mov CX,0x0010
19FC:1CA0 cmp byte ptr DS:[0xA44F],0
19FC:1CA5 je short 0x1CA9
19FC:1CA7 shr CX,1
19FC:1CA9 push DS
19FC:1CAA mov AX,0xA400
19FC:1CAD mov DS,AX
19FC:1CAF movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1CB0 inc SI
19FC:1CB1 add DI,0x0027
19FC:1CB4 loop 0x1CAF
19FC:1CB6 pop DS
19FC:1CB7 ret near
19FC:1CB8 push BP
19FC:1CB9 mov BP,SP
19FC:1CBB push DI
19FC:1CBC push SI
19FC:1CBD push DS
19FC:1CBE mov AX,0x1DE9
19FC:1CC1 mov DS,AX
19FC:1CC3 push ES
19FC:1CC4 mov AX,0xB800
19FC:1CC7 mov ES,AX
19FC:1CC9 mov SI,0x244B
19FC:1CCC cmp word ptr DS:[0xB764],0
19FC:1CD1 je short 0x1D10
19FC:1CD3 mov DI,0x0034
19FC:1CD6 add SI,DI
19FC:1CD8 mov DX,0x0032
19FC:1CDB mov BX,0x0036
19FC:1CDE mov CX,BX
19FC:1CE0 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1CE2 add SI,0x0034
19FC:1CE5 add DI,0x1F94
19FC:1CE9 mov CX,BX
19FC:1CEB rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1CED add SI,0x0034
19FC:1CF0 add DI,0x1F94
19FC:1CF4 mov CX,BX
19FC:1CF6 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1CF8 add SI,0x0034
19FC:1CFB add DI,0x1F94
19FC:1CFF mov CX,BX
19FC:1D01 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1D03 add SI,0x0034
19FC:1D06 sub DI,0x5FCC
19FC:1D0A dec DX
19FC:1D0B jne short 0x1CDE
19FC:1D0D jmp short 0x1D34
19FC:1D10 mov DI,0x001A
19FC:1D13 add SI,DI
19FC:1D15 mov DL,0x64
19FC:1D17 mov BX,0x001B
19FC:1D1A mov CX,BX
19FC:1D1C rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1D1E add SI,0x001A
19FC:1D21 add DI,0x1FCA
19FC:1D25 mov CX,BX
19FC:1D27 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1D29 add SI,0x001A
19FC:1D2C sub DI,0x1FE6
19FC:1D30 dec DL
19FC:1D32 jne short 0x1D1A
19FC:1D34 pop ES
19FC:1D35 pop DS
19FC:1D36 pop SI
19FC:1D37 pop DI
19FC:1D38 pop BP
19FC:1D39 ret far
19FC:1D3A push BP
19FC:1D3B mov BP,SP
19FC:1D3D push DI
19FC:1D3E push SI
19FC:1D3F push DS
19FC:1D40 mov AX,0x1DE9
19FC:1D43 mov DS,AX
19FC:1D45 push ES
19FC:1D46 mov AX,0xA000
19FC:1D49 mov ES,AX
19FC:1D4B mov DI,0x0068
19FC:1D4E mov SI,0x244B
19FC:1D51 add SI,0x0034
19FC:1D54 mov DL,0xC8
19FC:1D56 mov BX,0x0FF0
19FC:1D59 mov CX,0x001B
19FC:1D5C lods AX,word ptr DS:[SI]
19FC:1D5D mov DH,AH
19FC:1D5F mov AH,AL
19FC:1D61 and AX,BX
19FC:1D63 stos word ptr ES:[DI],AX
19FC:1D64 mov AH,DH
19FC:1D66 mov AL,AH
19FC:1D68 and AX,BX
19FC:1D6A stos word ptr ES:[DI],AX
19FC:1D6B lods AX,word ptr DS:[SI]
19FC:1D6C mov DH,AH
19FC:1D6E mov AH,AL
19FC:1D70 and AX,BX
19FC:1D72 stos word ptr ES:[DI],AX
19FC:1D73 mov AH,DH
19FC:1D75 mov AL,AH
19FC:1D77 and AX,BX
19FC:1D79 stos word ptr ES:[DI],AX
19FC:1D7A loop 0x1D5C
19FC:1D7C add DI,0x0068
19FC:1D7F add SI,0x0034
19FC:1D82 dec DL
19FC:1D84 jne short 0x1D59
19FC:1D86 pop ES
19FC:1D87 pop DS
19FC:1D88 pop SI
19FC:1D89 pop DI
19FC:1D8A pop BP
19FC:1D8B ret far
19FC:1D8C push BP
19FC:1D8D mov BP,SP
19FC:1D8F push DI
19FC:1D90 push SI
19FC:1D91 push DS
19FC:1D92 mov AX,0x1DE9
19FC:1D95 mov DS,AX
19FC:1D97 mov AX,word ptr SS:[BP+6]
19FC:1D9A mov word ptr DS:[0x026E],AX
19FC:1D9D mov AX,word ptr SS:[BP+8]
19FC:1DA0 mov word ptr DS:[0x0270],AX
19FC:1DA3 pop DS
19FC:1DA4 pop SI
19FC:1DA5 pop DI
19FC:1DA6 pop BP
19FC:1DA7 ret far
19FC:1DA8 push BP
19FC:1DA9 mov BP,SP
19FC:1DAB push DI
19FC:1DAC push SI
19FC:1DAD push DS
19FC:1DAE mov AX,0x1DE9
19FC:1DB1 mov DS,AX
19FC:1DB3 call near 0x1886
19FC:1DB6 pop DS
19FC:1DB7 pop SI
19FC:1DB8 pop DI
19FC:1DB9 pop BP
19FC:1DBA ret far
19FC:1DF8 push BP
19FC:1DF9 mov BP,SP
19FC:1DFB push DI
19FC:1DFC push SI
19FC:1DFD push DS
19FC:1DFE mov AX,0x1DE9
19FC:1E01 mov DS,AX
19FC:1E03 mov AX,word ptr DS:[0xA44D]
19FC:1E06 shr AL,1
19FC:1E08 and AX,7
19FC:1E0B add AL,2
19FC:1E0D shl AX,1
19FC:1E0F shl AX,1
19FC:1E11 shl AX,1
19FC:1E13 mov BX,AX
19FC:1E15 shl AX,1
19FC:1E17 add AX,BX
19FC:1E19 mov word ptr DS:[0x09F1],AX
19FC:1E1C mov BX,word ptr DS:[0xA44B]
19FC:1E20 shr BL,1
19FC:1E22 and BX,7
19FC:1E25 add BL,2
19FC:1E28 mov word ptr DS:[0x09EF],BX
19FC:1E2C add BX,AX
19FC:1E2E mov word ptr DS:[0x09ED],BX
19FC:1E32 pop DS
19FC:1E33 pop SI
19FC:1E34 pop DI
19FC:1E35 pop BP
19FC:1E36 ret far
19FC:1E37 push BP
19FC:1E38 mov BP,SP
19FC:1E3A push DI
19FC:1E3B push SI
19FC:1E3C push DS
19FC:1E3D mov AX,0x1DE9
19FC:1E40 mov DS,AX
19FC:1E42 push ES
19FC:1E43 mov AX,0xA000
19FC:1E46 mov ES,AX
19FC:1E48 mov SI,0x244B
19FC:1E4B cmp word ptr DS:[0xB764],2
19FC:1E50 jb short 0x1E78
19FC:1E52 je short 0x1E7E
19FC:1E54 mov DI,0x0A08
19FC:1E57 mov DL,0x58
19FC:1E59 mov BX,0x0FF0
19FC:1E5C mov CX,0x0016
19FC:1E5F lods AX,word ptr DS:[SI]
19FC:1E60 mov DH,AH
19FC:1E62 mov AH,AL
19FC:1E64 and AX,BX
19FC:1E66 stos word ptr ES:[DI],AX
19FC:1E67 mov AH,DH
19FC:1E69 mov AL,AH
19FC:1E6B and AX,BX
19FC:1E6D stos word ptr ES:[DI],AX
19FC:1E6E loop 0x1E5F
19FC:1E70 add DI,0x00E8
19FC:1E74 dec DL
19FC:1E76 jne short 0x1E5C
19FC:1E78 pop ES
19FC:1E79 pop DS
19FC:1E7A pop SI
19FC:1E7B pop DI
19FC:1E7C pop BP
19FC:1E7D ret far
19FC:1E7E mov DI,0x0141
19FC:1E81 add SI,0x0F20
19FC:1E85 mov DX,0x03CE
19FC:1E88 mov AX,5
19FC:1E8B out DX,AX
19FC:1E8C mov AX,0xFF08
19FC:1E8F out DX,AX
19FC:1E90 mov AX,1
19FC:1E93 out DX,AX
19FC:1E94 mov BX,0x0058
19FC:1E97 mov DX,0x03C4
19FC:1E9A mov CX,0x000B
19FC:1E9D mov AX,0x0102
19FC:1EA0 out DX,AX
19FC:1EA1 mov AL,byte ptr ES:[DI]
19FC:1EA4 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1EA5 dec DI
19FC:1EA6 mov AX,0x0202
19FC:1EA9 out DX,AX
19FC:1EAA mov AL,byte ptr ES:[DI]
19FC:1EAD movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1EAE dec DI
19FC:1EAF mov AX,0x0402
19FC:1EB2 out DX,AX
19FC:1EB3 mov AL,byte ptr ES:[DI]
19FC:1EB6 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1EB7 dec DI
19FC:1EB8 mov AX,0x0802
19FC:1EBB out DX,AX
19FC:1EBC mov AL,byte ptr ES:[DI]
19FC:1EBF movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:1EC0 loop 0x1E9D
19FC:1EC2 add DI,0x001D
19FC:1EC5 dec BX
19FC:1EC6 jne short 0x1E9A
19FC:1EC8 mov AX,0x0F02
19FC:1ECB out DX,AX
19FC:1ECC jmp short 0x1E78
19FC:1ECE push BP
19FC:1ECF mov BP,SP
19FC:1ED1 push DI
19FC:1ED2 push SI
19FC:1ED3 push DS
19FC:1ED4 mov AX,0x1DE9
19FC:1ED7 mov DS,AX
19FC:1ED9 mov DI,word ptr SS:[BP+6]
19FC:1EDC mov AX,word ptr SS:[BP+8]
19FC:1EDF mov DX,word ptr SS:[BP+0x0A]
19FC:1EE2 push ES
19FC:1EE3 mov ES,AX
19FC:1EE5 mov SI,0x07AD
19FC:1EE8 push DS
19FC:1EE9 or DX,DX
19FC:1EEB je short 0x1EF7
19FC:1EED xchg SI,DI
19FC:1EEF mov DX,DS
19FC:1EF1 mov AX,ES
19FC:1EF3 mov DS,AX
19FC:1EF5 mov ES,DX
19FC:1EF7 mov CX,0x0120
19FC:1EFA cld
19FC:1EFB rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:1EFD pop DS
19FC:1EFE pop ES
19FC:1EFF pop DS
19FC:1F00 pop SI
19FC:1F01 pop DI
19FC:1F02 pop BP
19FC:1F03 ret far
19FC:1F9C push BP
19FC:1F9D mov BP,SP
19FC:1F9F push DI
19FC:1FA0 push SI
19FC:1FA1 push DS
19FC:1FA2 mov AX,0x1DE9
19FC:1FA5 mov DS,AX
19FC:1FA7 sti
19FC:1FA8 pop DS
19FC:1FA9 pop SI
19FC:1FAA pop DI
19FC:1FAB pop BP
19FC:1FAC ret far
19FC:1FAD push BP
19FC:1FAE mov BP,SP
19FC:1FB0 push DI
19FC:1FB1 push SI
19FC:1FB2 push DS
19FC:1FB3 mov AX,0x1DE9
19FC:1FB6 mov DS,AX
19FC:1FB8 cli
19FC:1FB9 pop DS
19FC:1FBA pop SI
19FC:1FBB pop DI
19FC:1FBC pop BP
19FC:1FBD ret far
19FC:1FBE push BP
19FC:1FBF mov BP,SP
19FC:1FC1 push DI
19FC:1FC2 push SI
19FC:1FC3 push DS
19FC:1FC4 mov AX,0x1DE9
19FC:1FC7 mov DS,AX
19FC:1FC9 push ES
19FC:1FCA mov AX,0xB800
19FC:1FCD mov ES,AX
19FC:1FCF mov DI,0
19FC:1FD2 mov CX,0x2000
19FC:1FD5 cmp word ptr DS:[0xB764],0
19FC:1FDA je short 0x2004
19FC:1FDC shl CH,1
19FC:1FDE cmp word ptr DS:[0xB764],1
19FC:1FE3 je short 0x2004
19FC:1FE5 mov AX,0xA000
19FC:1FE8 mov ES,AX
19FC:1FEA cmp word ptr DS:[0xB764],2
19FC:1FEF je short 0x1FF6
19FC:1FF1 shl CH,1
19FC:1FF3 jmp short 0x2004
19FC:1FF6 mov CX,0x1F40
19FC:1FF9 mov DX,0x03CE
19FC:1FFC mov AX,0x0205
19FC:1FFF out DX,AX
19FC:2000 mov AX,0xFF08
19FC:2003 out DX,AX
19FC:2004 mov AX,DI
19FC:2006 rep stos word ptr ES:[DI],AX
19FC:2008 pop ES
19FC:2009 pop DS
19FC:200A pop SI
19FC:200B pop DI
19FC:200C pop BP
19FC:200D ret far
19FC:200E push BP
19FC:200F mov BP,SP
19FC:2011 push DI
19FC:2012 push SI
19FC:2013 push DS
19FC:2014 mov AX,0x1DE9
19FC:2017 mov DS,AX
19FC:2019 push ES
19FC:201A mov AX,0xB800
19FC:201D mov ES,AX
19FC:201F mov SI,word ptr SS:[BP+6]
19FC:2022 mov word ptr DS:[0xB78A],SI
19FC:2026 mov BX,word ptr SS:[BP+8]
19FC:2029 mov word ptr DS:[0xB78C],BX
19FC:202D mov AX,word ptr SS:[BP+0x0A]
19FC:2030 shl AX,1
19FC:2032 shl AX,1
19FC:2034 mov word ptr DS:[0xB792],AX
19FC:2037 mov AX,word ptr SS:[BP+0x0C]
19FC:203A mov word ptr DS:[0xB794],AX
19FC:203D mov AX,word ptr SS:[BP+0x0E]
19FC:2040 shl AX,1
19FC:2042 shl AX,1
19FC:2044 mov word ptr DS:[0xB79A],AX
19FC:2047 mov CX,word ptr SS:[BP+0x10]
19FC:204A mov word ptr DS:[0xB79C],CX
19FC:204E cmp word ptr DS:[0xB764],1
19FC:2053 je short 0x208A
19FC:2055 jb short 0x20D5
19FC:2057 shl word ptr DS:[0xB792],1
19FC:205B mov AX,0xA000
19FC:205E mov ES,AX
19FC:2060 push CX
19FC:2061 mov AX,word ptr DS:[0xB794]
19FC:2064 inc word ptr DS:[0xB794]
19FC:2068 mov DX,0x0140
19FC:206B mul DX
19FC:206D add AX,word ptr DS:[0xB792]
19FC:2071 mov DI,AX
19FC:2073 mov CX,word ptr DS:[0xB79A]
19FC:2077 push DS
19FC:2078 mov DS,BX
19FC:207A lods AL,byte ptr DS:[SI]
19FC:207B mov AH,AL
19FC:207D and AX,0x0FF0
19FC:2080 stos word ptr ES:[DI],AX
19FC:2081 loop 0x207A
19FC:2083 pop DS
19FC:2084 pop CX
19FC:2085 loop 0x2060
19FC:2087 jmp near 0x2121
19FC:208A push CX
19FC:208B mov AX,0x0028
19FC:208E mov DX,word ptr DS:[0xB794]
19FC:2092 push DX
19FC:2093 and DL,0xFC
19FC:2096 mul DL
19FC:2098 pop DX
19FC:2099 and DL,3
19FC:209C je short 0x20A5
19FC:209E mov CL,DL
19FC:20A0 add AH,0x20
19FC:20A3 loop 0x20A0
19FC:20A5 add AX,word ptr DS:[0xB792]
19FC:20A9 mov DI,AX
19FC:20AB mov BX,word ptr DS:[0xB78A]
19FC:20AF push BX
19FC:20B0 mov CX,word ptr DS:[0xB79A]
19FC:20B4 add BX,CX
19FC:20B6 mov word ptr DS:[0xB78A],BX
19FC:20BA pop BX
19FC:20BB mov SI,BX
19FC:20BD push DS
19FC:20BE mov AX,word ptr DS:[0xB78C]
19FC:20C1 mov DS,AX
19FC:20C3 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:20C5 pop DS
19FC:20C6 mov BX,word ptr DS:[0xB794]
19FC:20CA inc BX
19FC:20CB mov word ptr DS:[0xB794],BX
19FC:20CF pop CX
19FC:20D0 loop 0x208A
19FC:20D2 jmp short 0x2121
19FC:20D5 shr word ptr DS:[0xB792],1
19FC:20D9 shr word ptr DS:[0xB79A],1
19FC:20DD push CX
19FC:20DE mov AX,0x0028
19FC:20E1 mov DX,word ptr DS:[0xB794]
19FC:20E5 push DX
19FC:20E6 and DL,0xFE
19FC:20E9 mul DL
19FC:20EB pop DX
19FC:20EC test DL,1
19FC:20EF je short 0x20F4
19FC:20F1 add AH,0x20
19FC:20F4 add AX,word ptr DS:[0xB792]
19FC:20F8 mov DI,AX
19FC:20FA mov BX,word ptr DS:[0xB78A]
19FC:20FE push BX
19FC:20FF mov CX,word ptr DS:[0xB79A]
19FC:2103 add BX,CX
19FC:2105 mov word ptr DS:[0xB78A],BX
19FC:2109 pop BX
19FC:210A mov SI,BX
19FC:210C push DS
19FC:210D mov AX,word ptr DS:[0xB78C]
19FC:2110 mov DS,AX
19FC:2112 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:2114 pop DS
19FC:2115 mov BX,word ptr DS:[0xB794]
19FC:2119 inc BX
19FC:211A mov word ptr DS:[0xB794],BX
19FC:211E pop CX
19FC:211F loop 0x20DD
19FC:2121 pop ES
19FC:2122 pop DS
19FC:2123 pop SI
19FC:2124 pop DI
19FC:2125 pop BP
19FC:2126 ret far
19FC:2127 push BP
19FC:2128 mov BP,SP
19FC:212A push DI
19FC:212B push SI
19FC:212C push DS
19FC:212D mov AX,0x1DE9
19FC:2130 mov DS,AX
19FC:2132 mov AL,byte ptr SS:[BP+6]
19FC:2135 mov byte ptr DS:[0xB772],AL
19FC:2138 mov AL,byte ptr SS:[BP+8]
19FC:213B mov byte ptr DS:[0xB775],AL
19FC:213E cmp word ptr DS:[0xB764],0
19FC:2143 je short 0x2177
19FC:2145 cmp word ptr DS:[0xB764],2
19FC:214A jae short 0x2172
19FC:214C mov BL,byte ptr DS:[0xB772]
19FC:2150 mov AL,BL
19FC:2152 mov CX,4
19FC:2155 shl BL,CL
19FC:2157 or BL,AL
19FC:2159 mov BH,BL
19FC:215B mov word ptr DS:[0xB773],BX
19FC:215F mov BL,byte ptr DS:[0xB775]
19FC:2163 mov AL,BL
19FC:2165 mov CX,4
19FC:2168 shl BL,CL
19FC:216A or BL,AL
19FC:216C mov BH,BL
19FC:216E mov word ptr DS:[0xB776],BX
19FC:2172 pop DS
19FC:2173 pop SI
19FC:2174 pop DI
19FC:2175 pop BP
19FC:2176 ret far
19FC:2177 mov BL,byte ptr DS:[0xB772]
19FC:217B and BL,3
19FC:217E mov AL,BL
19FC:2180 mov DL,byte ptr DS:[0xB775]
19FC:2184 and DL,3
19FC:2187 mov AH,DL
19FC:2189 mov CX,3
19FC:218C shl AL,1
19FC:218E shl AL,1
19FC:2190 or BL,AL
19FC:2192 shl AH,1
19FC:2194 shl AH,1
19FC:2196 or DL,AH
19FC:2198 loop 0x218C
19FC:219A mov BH,BL
19FC:219C mov word ptr DS:[0xB773],BX
19FC:21A0 mov DH,DL
19FC:21A2 mov word ptr DS:[0xB776],DX
19FC:21A6 jmp short 0x2172
19FC:21A8 push BP
19FC:21A9 mov BP,SP
19FC:21AB push DI
19FC:21AC push SI
19FC:21AD push DS
19FC:21AE mov AX,0x1DE9
19FC:21B1 mov DS,AX
19FC:21B3 mov SI,word ptr SS:[BP+6]
19FC:21B6 add SI,0xA661
19FC:21BA mov AX,word ptr SS:[BP+8]
19FC:21BD mov DI,word ptr SS:[BP+0x0A]
19FC:21C0 add DI,AX
19FC:21C2 push ES
19FC:21C3 mov AX,0xB800
19FC:21C6 mov ES,AX
19FC:21C8 mov word ptr DS:[0xB77C],2
19FC:21CE mov DX,word ptr DS:[0xB773]
19FC:21D2 mov BP,word ptr DS:[0xB776]
19FC:21D6 mov CX,4
19FC:21D9 lods AX,word ptr DS:[SI]
19FC:21DA mov BX,AX
19FC:21DC and AX,DX
19FC:21DE not BX
19FC:21E0 and BX,BP
19FC:21E2 or AX,BX
19FC:21E4 stos word ptr ES:[DI],AX
19FC:21E5 lods AX,word ptr DS:[SI]
19FC:21E6 mov BX,AX
19FC:21E8 and AX,DX
19FC:21EA not BX
19FC:21EC and BX,BP
19FC:21EE or AX,BX
19FC:21F0 mov word ptr ES:[DI],AX
19FC:21F3 add DI,0x1FFE
19FC:21F7 loop 0x21D9
19FC:21F9 sub DI,0x7F60
19FC:21FD dec word ptr DS:[0xB77C]
19FC:2201 jne short 0x21D6
19FC:2203 pop ES
19FC:2204 pop DS
19FC:2205 pop SI
19FC:2206 pop DI
19FC:2207 pop BP
19FC:2208 ret far
19FC:2209 push BP
19FC:220A mov BP,SP
19FC:220C push DI
19FC:220D push SI
19FC:220E push DS
19FC:220F mov AX,0x1DE9
19FC:2212 mov DS,AX
19FC:2214 mov SI,word ptr SS:[BP+6]
19FC:2217 add SI,0xA661
19FC:221B mov AX,word ptr SS:[BP+8]
19FC:221E mov DI,word ptr SS:[BP+0x0A]
19FC:2221 add DI,AX
19FC:2223 push ES
19FC:2224 mov AX,0xB800
19FC:2227 mov ES,AX
19FC:2229 mov DX,0x2000
19FC:222C mov BP,word ptr DS:[0xB773]
19FC:2230 mov CX,8
19FC:2233 lods AX,word ptr DS:[SI]
19FC:2234 mov BX,AX
19FC:2236 and AX,BP
19FC:2238 not BX
19FC:223A and BX,word ptr DS:[0xB776]
19FC:223E or AX,BX
19FC:2240 mov word ptr ES:[DI],AX
19FC:2243 add DI,DX
19FC:2245 xor DX,0xC050
19FC:2249 loop 0x2233
19FC:224B pop ES
19FC:224C pop DS
19FC:224D pop SI
19FC:224E pop DI
19FC:224F pop BP
19FC:2250 ret far
19FC:2251 push BP
19FC:2252 mov BP,SP
19FC:2254 push DI
19FC:2255 push SI
19FC:2256 push DS
19FC:2257 mov AX,0x1DE9
19FC:225A mov DS,AX
19FC:225C mov SI,word ptr SS:[BP+6]
19FC:225F add SI,0xA661
19FC:2263 mov AX,word ptr SS:[BP+8]
19FC:2266 mov DI,word ptr SS:[BP+0x0A]
19FC:2269 add DI,AX
19FC:226B mov BP,ES
19FC:226D mov AX,0xA000
19FC:2270 mov ES,AX
19FC:2272 mov DX,0x03CE
19FC:2275 mov AX,0x0205
19FC:2278 out DX,AX
19FC:2279 mov BL,byte ptr DS:[0xB772]
19FC:227D mov BH,byte ptr DS:[0xB775]
19FC:2281 mov CX,8
19FC:2284 mov AL,CL
19FC:2286 mov AH,byte ptr DS:[SI]
19FC:2288 out DX,AX
19FC:2289 mov AH,BL
19FC:228B xchg AH,byte ptr ES:[DI]
19FC:228E mov AH,byte ptr DS:[SI]
19FC:2290 not AH
19FC:2292 out DX,AX
19FC:2293 mov AH,BH
19FC:2295 xchg AH,byte ptr ES:[DI]
19FC:2298 inc SI
19FC:2299 add DI,0x0028
19FC:229C loop 0x2286
19FC:229E mov ES,BP
19FC:22A0 pop DS
19FC:22A1 pop SI
19FC:22A2 pop DI
19FC:22A3 pop BP
19FC:22A4 ret far
19FC:22A5 push BP
19FC:22A6 mov BP,SP
19FC:22A8 push DI
19FC:22A9 push SI
19FC:22AA push DS
19FC:22AB mov AX,0x1DE9
19FC:22AE mov DS,AX
19FC:22B0 mov SI,word ptr SS:[BP+6]
19FC:22B3 add SI,0xA661
19FC:22B7 mov AX,word ptr SS:[BP+8]
19FC:22BA mov DI,AX
19FC:22BC mov AX,word ptr SS:[BP+0x0A]
19FC:22BF add DI,AX
19FC:22C1 mov BP,ES
19FC:22C3 mov AX,0xA000
19FC:22C6 mov ES,AX
19FC:22C8 mov BL,8
19FC:22CA mov DH,byte ptr DS:[0xB772]
19FC:22CE mov DL,byte ptr DS:[0xB775]
19FC:22D2 lods AL,byte ptr DS:[SI]
19FC:22D3 mov CX,8
19FC:22D6 shl AL,1
19FC:22D8 jb short 0x22E3
19FC:22DA mov byte ptr ES:[DI],DL
19FC:22DD inc DI
19FC:22DE loop 0x22D6
19FC:22E0 jmp short 0x22E9
19FC:22E3 mov byte ptr ES:[DI],DH
19FC:22E6 inc DI
19FC:22E7 loop 0x22D6
19FC:22E9 add DI,0x0138
19FC:22ED dec BL
19FC:22EF jne short 0x22D2
19FC:22F1 mov ES,BP
19FC:22F3 pop DS
19FC:22F4 pop SI
19FC:22F5 pop DI
19FC:22F6 pop BP
19FC:22F7 ret far
19FC:22F8 push BP
19FC:22F9 mov BP,SP
19FC:22FB push DI
19FC:22FC push SI
19FC:22FD push DS
19FC:22FE mov AX,0x1DE9
19FC:2301 mov DS,AX
19FC:2303 push ES
19FC:2304 push DS
19FC:2305 mov AX,word ptr SS:[BP+6]
19FC:2308 mov word ptr DS:[0xB78A],AX
19FC:230B mov AX,word ptr SS:[BP+8]
19FC:230E mov word ptr DS:[0xB78C],AX
19FC:2311 mov AX,word ptr SS:[BP+0x0A]
19FC:2314 mov word ptr DS:[0xB78E],AX
19FC:2317 mov AX,word ptr SS:[BP+0x0C]
19FC:231A mov word ptr DS:[0xB790],AX
19FC:231D mov ES,AX
19FC:231F mov DI,word ptr DS:[0xB78E]
19FC:2323 mov SI,word ptr DS:[0xB78A]
19FC:2327 mov AX,word ptr DS:[0xB78C]
19FC:232A mov DS,AX
19FC:232C jmp short 0x2336
19FC:232F inc SI
19FC:2330 mov AX,word ptr DS:[SI]
19FC:2332 inc SI
19FC:2333 jmp short 0x2347
19FC:2336 mov DX,0x7D00
19FC:2339 xor BX,BX
19FC:233B xor AX,AX
19FC:233D mov AL,byte ptr DS:[SI]
19FC:233F cmp AL,0
19FC:2341 je short 0x232F
19FC:2343 jns short 0x2348
19FC:2345 neg AL
19FC:2347 dec BX
19FC:2348 mov CX,AX
19FC:234A inc SI
19FC:234B mov AL,byte ptr DS:[SI]
19FC:234D stos byte ptr ES:[DI],AL
19FC:234E dec DX
19FC:234F je short 0x2361
19FC:2351 test BX,1
19FC:2355 jne short 0x235C
19FC:2357 loop 0x234A
19FC:2359 inc SI
19FC:235A jmp short 0x2339
19FC:235C loop 0x234D
19FC:235E inc SI
19FC:235F jmp short 0x2339
19FC:2361 pop DS
19FC:2362 pop ES
19FC:2363 pop DS
19FC:2364 pop SI
19FC:2365 pop DI
19FC:2366 pop BP
19FC:2367 ret far
19FC:2368 push BP
19FC:2369 mov BP,SP
19FC:236B push DI
19FC:236C push SI
19FC:236D push DS
19FC:236E mov AX,0x1DE9
19FC:2371 mov DS,AX
19FC:2373 push ES
19FC:2374 push DS
19FC:2375 mov AX,word ptr SS:[BP+6]
19FC:2378 mov word ptr DS:[0xB78A],AX
19FC:237B mov AX,word ptr SS:[BP+8]
19FC:237E mov word ptr DS:[0xB78C],AX
19FC:2381 mov AX,word ptr SS:[BP+0x0A]
19FC:2384 mov word ptr DS:[0xB78E],AX
19FC:2387 mov AX,word ptr SS:[BP+0x0C]
19FC:238A mov word ptr DS:[0xB790],AX
19FC:238D mov ES,AX
19FC:238F mov DI,word ptr DS:[0xB78E]
19FC:2393 mov SI,word ptr DS:[0xB78A]
19FC:2397 mov AX,word ptr DS:[0xB78C]
19FC:239A mov DS,AX
19FC:239C jmp short 0x23A6
19FC:239F inc SI
19FC:23A0 mov AX,word ptr DS:[SI]
19FC:23A2 inc SI
19FC:23A3 jmp short 0x23B9
19FC:23A6 mov DX,0x7D00
19FC:23A9 mov BL,0xC8
19FC:23AB sub BH,BH
19FC:23AD sub AX,AX
19FC:23AF mov AL,byte ptr DS:[SI]
19FC:23B1 cmp AL,0
19FC:23B3 je short 0x239F
19FC:23B5 jns short 0x23BB
19FC:23B7 neg AL
19FC:23B9 dec BH
19FC:23BB mov CX,AX
19FC:23BD inc SI
19FC:23BE mov AL,byte ptr DS:[SI]
19FC:23C0 mov byte ptr ES:[DI],AL
19FC:23C3 add DI,0x00A0
19FC:23C7 dec BL
19FC:23C9 je short 0x23DD
19FC:23CB dec DX
19FC:23CC je short 0x23E5
19FC:23CE test BH,1
19FC:23D1 jne short 0x23D8
19FC:23D3 loop 0x23BD
19FC:23D5 inc SI
19FC:23D6 jmp short 0x23AB
19FC:23D8 loop 0x23C0
19FC:23DA inc SI
19FC:23DB jmp short 0x23AB
19FC:23DD mov BL,0xC8
19FC:23DF sub DI,0x7CFF
19FC:23E3 jmp short 0x23CB
19FC:23E5 pop DS
19FC:23E6 pop ES
19FC:23E7 pop DS
19FC:23E8 pop SI
19FC:23E9 pop DI
19FC:23EA pop BP
19FC:23EB ret far
19FC:23EC push BP
19FC:23ED mov BP,SP
19FC:23EF push DI
19FC:23F0 push SI
19FC:23F1 push DS
19FC:23F2 mov AX,0x1DE9
19FC:23F5 mov DS,AX
19FC:23F7 push ES
19FC:23F8 mov AX,word ptr SS:[BP+6]
19FC:23FB mov word ptr DS:[0xB78A],AX
19FC:23FE mov SI,AX
19FC:2400 mov AX,word ptr SS:[BP+8]
19FC:2403 mov word ptr DS:[0xB78C],AX
19FC:2406 mov AX,word ptr SS:[BP+0x0A]
19FC:2409 mov DI,AX
19FC:240B mov AX,word ptr SS:[BP+0x0C]
19FC:240E mov ES,AX
19FC:2410 mov AX,word ptr DS:[0xB78C]
19FC:2413 push DS
19FC:2414 mov DS,AX
19FC:2416 jmp short 0x2422
19FC:2419 inc SI
19FC:241A mov AX,word ptr DS:[SI]
19FC:241C xchg AH,AL
19FC:241E inc SI
19FC:241F jmp short 0x2433
19FC:2422 mov DX,0x0F20
19FC:2425 xor BX,BX
19FC:2427 xor AX,AX
19FC:2429 mov AL,byte ptr DS:[SI]
19FC:242B or AL,AL
19FC:242D je short 0x2419
19FC:242F jns short 0x2434
19FC:2431 neg AL
19FC:2433 dec BX
19FC:2434 mov CX,AX
19FC:2436 inc SI
19FC:2437 mov AL,byte ptr DS:[SI]
19FC:2439 xor byte ptr ES:[DI],AL
19FC:243C inc DI
19FC:243D dec DX
19FC:243E je short 0x244E
19FC:2440 or BX,BX
19FC:2442 jne short 0x2449
19FC:2444 loop 0x2436
19FC:2446 inc SI
19FC:2447 jmp short 0x2425
19FC:2449 loop 0x2439
19FC:244B inc SI
19FC:244C jmp short 0x2425
19FC:244E pop DS
19FC:244F pop ES
19FC:2450 mov AX,SI
19FC:2452 inc AX
19FC:2453 sub AX,word ptr DS:[0xB78A]
19FC:2457 pop DS
19FC:2458 pop SI
19FC:2459 pop DI
19FC:245A pop BP
19FC:245B ret far
19FC:245C push BP
19FC:245D mov BP,SP
19FC:245F push DI
19FC:2460 push SI
19FC:2461 push DS
19FC:2462 mov AX,0x1DE9
19FC:2465 mov DS,AX
19FC:2467 push ES
19FC:2468 mov AX,word ptr SS:[BP+6]
19FC:246B mov word ptr DS:[0xB78A],AX
19FC:246E mov AX,word ptr SS:[BP+8]
19FC:2471 mov word ptr DS:[0xB78C],AX
19FC:2474 mov AX,word ptr SS:[BP+0x0A]
19FC:2477 mov word ptr DS:[0xB78E],AX
19FC:247A mov AX,word ptr SS:[BP+0x0C]
19FC:247D mov word ptr DS:[0xB790],AX
19FC:2480 mov AX,word ptr SS:[BP+0x0E]
19FC:2483 cmp word ptr DS:[0xB764],2
19FC:2488 je short 0x249E
19FC:248A shl AX,1
19FC:248C cmp word ptr DS:[0xB764],0
19FC:2491 je short 0x249E
19FC:2493 shl AX,1
19FC:2495 cmp word ptr DS:[0xB764],1
19FC:249A je short 0x249E
19FC:249C shl AX,1
19FC:249E mov word ptr DS:[0xB792],AX
19FC:24A1 mov AX,word ptr SS:[BP+0x10]
19FC:24A4 mov word ptr DS:[0xB794],AX
19FC:24A7 mov AX,word ptr SS:[BP+0x12]
19FC:24AA cmp word ptr DS:[0xB764],2
19FC:24AF je short 0x24C5
19FC:24B1 shl AX,1
19FC:24B3 cmp word ptr DS:[0xB764],0
19FC:24B8 je short 0x24C5
19FC:24BA shl AX,1
19FC:24BC cmp word ptr DS:[0xB764],1
19FC:24C1 je short 0x24C5
19FC:24C3 shl AX,1
19FC:24C5 mov word ptr DS:[0xB79A],AX
19FC:24C8 mov AX,word ptr SS:[BP+0x14]
19FC:24CB mov word ptr DS:[0xB79C],AX
19FC:24CE call near 0x24D7
19FC:24D7 cmp word ptr DS:[0xB764],0
19FC:24DC jne short 0x24E1
19FC:24DE jmp near 0x26AE
19FC:24E1 cmp word ptr DS:[0xB764],2
19FC:24E6 je short 0x24EB
19FC:24E8 jmp near 0x256B
19FC:24EB mov AX,word ptr DS:[0xB79A]
19FC:24EE add AX,word ptr DS:[0xB792]
19FC:24F2 cmp AX,0x0029
19FC:24F5 jb short 0x2501
19FC:24F7 mov AX,0x0028
19FC:24FA sub AX,word ptr DS:[0xB792]
19FC:24FE mov word ptr DS:[0xB79A],AX
19FC:2501 mov AX,word ptr DS:[0xB794]
19FC:2504 add AX,word ptr DS:[0xB79C]
19FC:2508 cmp AX,0x00C9
19FC:250B jb short 0x2517
19FC:250D mov AX,0x00C8
19FC:2510 sub AX,word ptr DS:[0xB794]
19FC:2514 mov word ptr DS:[0xB79C],AX
19FC:2517 mov AX,word ptr DS:[0xB792]
19FC:251A cmp AX,0x0028
19FC:251D jae short 0x2568
19FC:251F mov AX,word ptr DS:[0xB794]
19FC:2522 cmp AX,0x00C8
19FC:2525 jae short 0x2568
19FC:2527 mov DX,0x0028
19FC:252A mul DL
19FC:252C add AX,word ptr DS:[0xB792]
19FC:2530 mov DI,word ptr DS:[0xB78E]
19FC:2534 add DI,AX
19FC:2536 mov DX,word ptr DS:[0xB790]
19FC:253A mov ES,DX
19FC:253C mov SI,AX
19FC:253E add SI,word ptr DS:[0xB78A]
19FC:2542 mov DX,0x03CE
19FC:2545 mov AX,0x0105
19FC:2548 out DX,AX
19FC:2549 mov BX,word ptr DS:[0xB79A]
19FC:254D mov DX,word ptr DS:[0xB79C]
19FC:2551 mov AX,word ptr DS:[0xB78C]
19FC:2554 push DS
19FC:2555 mov DS,AX
19FC:2557 mov CX,BX
19FC:2559 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:255B mov AX,0x0028
19FC:255E sub AX,BX
19FC:2560 add SI,AX
19FC:2562 add DI,AX
19FC:2564 dec DX
19FC:2565 jne short 0x2557
19FC:2567 pop DS
19FC:2568 jmp near 0x2629
19FC:256B cmp word ptr DS:[0xB764],1
19FC:2570 je short 0x2575
19FC:2572 jmp near 0x262A
19FC:2575 mov AX,word ptr DS:[0xB79A]
19FC:2578 add AX,word ptr DS:[0xB792]
19FC:257C cmp AX,0x00A1
19FC:257F jb short 0x258B
19FC:2581 mov AX,0x00A0
19FC:2584 sub AX,word ptr DS:[0xB792]
19FC:2588 mov word ptr DS:[0xB79A],AX
19FC:258B mov AX,word ptr DS:[0xB794]
19FC:258E add AX,word ptr DS:[0xB79C]
19FC:2592 cmp AX,0x00C9
19FC:2595 jb short 0x25A1
19FC:2597 mov AX,0x00C8
19FC:259A sub AX,word ptr DS:[0xB794]
19FC:259E mov word ptr DS:[0xB79C],AX
19FC:25A1 mov AX,word ptr DS:[0xB792]
19FC:25A4 cmp AX,0x00A0
19FC:25A7 jae short 0x2568
19FC:25A9 mov AX,word ptr DS:[0xB794]
19FC:25AC cmp AX,0x00C8
19FC:25AF jae short 0x2629
19FC:25B1 mov BX,AX
19FC:25B3 and AX,0x00FC
19FC:25B6 mov DX,0x0028
19FC:25B9 mul DL
19FC:25BB add AX,word ptr DS:[0xB792]
19FC:25BF and BX,3
19FC:25C2 je short 0x25CD
19FC:25C4 mov CX,BX
19FC:25C6 mov AX,0x2000
19FC:25C9 mul BX
19FC:25CB add AX,CX
19FC:25CD mov DI,word ptr DS:[0xB78E]
19FC:25D1 add DI,AX
19FC:25D3 mov DX,word ptr DS:[0xB790]
19FC:25D7 mov ES,DX
19FC:25D9 mov SI,AX
19FC:25DB add SI,word ptr DS:[0xB78A]
19FC:25DF mov DX,word ptr DS:[0xB79A]
19FC:25E3 mov AX,0x2000
19FC:25E6 sub AX,DX
19FC:25E8 mov word ptr DS:[0xB794],AX
19FC:25EB mov AX,DX
19FC:25ED sub AX,0x00A0
19FC:25F0 add AH,0x60
19FC:25F3 shr DX,1
19FC:25F5 mov word ptr DS:[0xB79A],DX
19FC:25F9 mov DX,word ptr DS:[0xB78C]
19FC:25FD mov CX,word ptr DS:[0xB79A]
19FC:2601 push DS
19FC:2602 mov DS,DX
19FC:2604 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2606 pop DS
19FC:2607 inc BX
19FC:2608 and BX,3
19FC:260B je short 0x261E
19FC:260D add SI,word ptr DS:[0xB794]
19FC:2611 add DI,word ptr DS:[0xB794]
19FC:2615 sub word ptr DS:[0xB79C],1
19FC:261A jne short 0x25FD
19FC:261C je short 0x2629
19FC:261E sub SI,AX
19FC:2620 sub DI,AX
19FC:2622 sub word ptr DS:[0xB79C],1
19FC:2627 jne short 0x25FD
19FC:2629 ret near
19FC:262A mov AX,word ptr DS:[0xB79A]
19FC:262D add AX,word ptr DS:[0xB792]
19FC:2631 cmp AX,0x0141
19FC:2634 jb short 0x2640
19FC:2636 mov AX,0x0140
19FC:2639 sub AX,word ptr DS:[0xB792]
19FC:263D mov word ptr DS:[0xB79A],AX
19FC:2640 mov AX,word ptr DS:[0xB794]
19FC:2643 add AX,word ptr DS:[0xB79C]
19FC:2647 cmp AX,0x00C9
19FC:264A jb short 0x2656
19FC:264C mov AX,0x00C8
19FC:264F sub AX,word ptr DS:[0xB794]
19FC:2653 mov word ptr DS:[0xB79C],AX
19FC:2656 mov AX,word ptr DS:[0xB792]
19FC:2659 cmp AX,0x0140
19FC:265C jae short 0x2629
19FC:265E mov AX,word ptr DS:[0xB794]
19FC:2661 cmp AX,0x00C8
19FC:2664 jae short 0x2629
19FC:2666 mov BX,AX
19FC:2668 mov DX,0x0140
19FC:266B mul DX
19FC:266D add AX,word ptr DS:[0xB792]
19FC:2671 mov DI,word ptr DS:[0xB78E]
19FC:2675 add DI,AX
19FC:2677 mov DX,word ptr DS:[0xB790]
19FC:267B mov ES,DX
19FC:267D mov SI,AX
19FC:267F add SI,word ptr DS:[0xB78A]
19FC:2683 mov BX,0x0140
19FC:2686 mov DX,word ptr DS:[0xB79A]
19FC:268A sub BX,DX
19FC:268C shr DX,1
19FC:268E mov word ptr DS:[0xB79A],DX
19FC:2692 mov DX,word ptr DS:[0xB78C]
19FC:2696 mov CX,word ptr DS:[0xB79A]
19FC:269A push DS
19FC:269B mov DS,DX
19FC:269D rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:269F pop DS
19FC:26A0 add SI,BX
19FC:26A2 add DI,BX
19FC:26A4 sub word ptr DS:[0xB79C],1
19FC:26A9 jne short 0x2696
19FC:26AB jmp near 0x2629
19FC:26AE mov AX,word ptr DS:[0xB79A]
19FC:26B1 add AX,word ptr DS:[0xB792]
19FC:26B5 cmp AX,0x0051
19FC:26B8 jb short 0x26C4
19FC:26BA mov AX,0x0050
19FC:26BD sub AX,word ptr DS:[0xB792]
19FC:26C1 mov word ptr DS:[0xB79A],AX
19FC:26C4 mov AX,word ptr DS:[0xB794]
19FC:26C7 add AX,word ptr DS:[0xB79C]
19FC:26CB cmp AX,0x00C9
19FC:26CE jb short 0x26DA
19FC:26D0 mov AX,0x00C8
19FC:26D3 sub AX,word ptr DS:[0xB794]
19FC:26D7 mov word ptr DS:[0xB79C],AX
19FC:26DA mov AX,word ptr DS:[0xB792]
19FC:26DD cmp AX,0x0050
19FC:26E0 jae short 0x275B
19FC:26E2 mov AX,word ptr DS:[0xB794]
19FC:26E5 cmp AX,0x00C8
19FC:26E8 jae short 0x275B
19FC:26EA mov BX,AX
19FC:26EC and AX,0x00FE
19FC:26EF mov DX,0x0028
19FC:26F2 mul DL
19FC:26F4 add AX,word ptr DS:[0xB792]
19FC:26F8 and BX,1
19FC:26FB je short 0x2700
19FC:26FD add AH,0x20
19FC:2700 mov DI,word ptr DS:[0xB78E]
19FC:2704 add DI,AX
19FC:2706 mov DX,word ptr DS:[0xB790]
19FC:270A mov ES,DX
19FC:270C mov SI,AX
19FC:270E add SI,word ptr DS:[0xB78A]
19FC:2712 mov DX,word ptr DS:[0xB79A]
19FC:2716 mov AX,0x2000
19FC:2719 sub AX,DX
19FC:271B mov word ptr DS:[0xB794],AX
19FC:271E mov AX,DX
19FC:2720 sub AX,0x0050
19FC:2723 add AH,0x20
19FC:2726 shr DX,1
19FC:2728 mov word ptr DS:[0xB79A],DX
19FC:272C mov DX,word ptr DS:[0xB78C]
19FC:2730 mov CX,word ptr DS:[0xB79A]
19FC:2734 push DS
19FC:2735 mov DS,DX
19FC:2737 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2739 pop DS
19FC:273A xor BX,1
19FC:273D je short 0x2750
19FC:273F add SI,word ptr DS:[0xB794]
19FC:2743 add DI,word ptr DS:[0xB794]
19FC:2747 sub word ptr DS:[0xB79C],1
19FC:274C jne short 0x2730
19FC:274E je short 0x275B
19FC:2750 sub SI,AX
19FC:2752 sub DI,AX
19FC:2754 sub word ptr DS:[0xB79C],1
19FC:2759 jne short 0x2730
19FC:275B ret near
19FC:275C push BP
19FC:275D mov BP,SP
19FC:275F push DI
19FC:2760 push SI
19FC:2761 push DS
19FC:2762 mov AX,0x1DE9
19FC:2765 mov DS,AX
19FC:2767 push ES
19FC:2768 mov AX,0xB800
19FC:276B mov ES,AX
19FC:276D mov SI,word ptr SS:[BP+6]
19FC:2770 mov AX,word ptr SS:[BP+8]
19FC:2773 mov word ptr DS:[0xB78C],AX
19FC:2776 cmp word ptr DS:[0xB764],0
19FC:277B jne short 0x2780
19FC:277D jmp near 0x2820
19FC:2780 cmp word ptr DS:[0xB764],2
19FC:2785 jne short 0x278A
19FC:2787 jmp near 0x284D
19FC:278A cmp word ptr DS:[0xB764],3
19FC:278F jne short 0x27DE
19FC:2791 mov AX,0xA000
19FC:2794 mov ES,AX
19FC:2796 mov AX,word ptr SS:[BP+0x0A]
19FC:2799 shl AX,1
19FC:279B shl AX,1
19FC:279D shl AX,1
19FC:279F mov word ptr DS:[0xB792],AX
19FC:27A2 mov AX,word ptr SS:[BP+0x0C]
19FC:27A5 mov DX,0x0A00
19FC:27A8 mul DX
19FC:27AA add AX,word ptr DS:[0xB792]
19FC:27AE mov DI,AX
19FC:27B0 mov CX,8
19FC:27B3 push DS
19FC:27B4 mov DS,word ptr DS:[0xB78C]
19FC:27B8 cld
19FC:27B9 mov DX,0x0FF0
19FC:27BC mov BX,0x0138
19FC:27BF lods AL,byte ptr DS:[SI]
19FC:27C0 mov AH,AL
19FC:27C2 and AX,DX
19FC:27C4 stos word ptr ES:[DI],AX
19FC:27C5 lods AL,byte ptr DS:[SI]
19FC:27C6 mov AH,AL
19FC:27C8 and AX,DX
19FC:27CA stos word ptr ES:[DI],AX
19FC:27CB lods AL,byte ptr DS:[SI]
19FC:27CC mov AH,AL
19FC:27CE and AX,DX
19FC:27D0 stos word ptr ES:[DI],AX
19FC:27D1 lods AL,byte ptr DS:[SI]
19FC:27D2 mov AH,AL
19FC:27D4 and AX,DX
19FC:27D6 stos word ptr ES:[DI],AX
19FC:27D7 add DI,BX
19FC:27D9 loop 0x27BF
19FC:27DB jmp short 0x2819
19FC:27DE mov AX,word ptr SS:[BP+0x0A]
19FC:27E1 shl AX,1
19FC:27E3 shl AX,1
19FC:27E5 mov word ptr DS:[0xB792],AX
19FC:27E8 mov AX,word ptr SS:[BP+0x0C]
19FC:27EB mov DX,0x0140
19FC:27EE mul DX
19FC:27F0 add AX,word ptr DS:[0xB792]
19FC:27F4 mov DI,AX
19FC:27F6 mov CX,2
19FC:27F9 push DS
19FC:27FA mov DS,word ptr DS:[0xB78C]
19FC:27FE cld
19FC:27FF movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2800 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2801 add DI,0x1FFC
19FC:2805 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2806 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2807 add DI,0x1FFC
19FC:280B movs word ptr ES:[DI],word ptr DS:[SI]
19FC:280C movs word ptr ES:[DI],word ptr DS:[SI]
19FC:280D add DI,0x1FFC
19FC:2811 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2812 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2813 sub DI,0x5F64
19FC:2817 loop 0x27FF
19FC:2819 pop DS
19FC:281A pop ES
19FC:281B pop DS
19FC:281C pop SI
19FC:281D pop DI
19FC:281E pop BP
19FC:281F ret far
19FC:2820 mov AX,word ptr SS:[BP+0x0A]
19FC:2823 shl AX,1
19FC:2825 mov word ptr DS:[0xB792],AX
19FC:2828 mov AX,word ptr SS:[BP+0x0C]
19FC:282B mov DX,0x0140
19FC:282E mul DX
19FC:2830 add AX,word ptr DS:[0xB792]
19FC:2834 mov DI,AX
19FC:2836 mov CX,4
19FC:2839 push DS
19FC:283A mov DS,word ptr DS:[0xB78C]
19FC:283E cld
19FC:283F movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2840 add DI,0x1FFE
19FC:2844 movs word ptr ES:[DI],word ptr DS:[SI]
19FC:2845 sub DI,0x1FB2
19FC:2849 loop 0x283F
19FC:284B jmp short 0x2819
19FC:284D mov DX,0x03CE
19FC:2850 mov AX,5
19FC:2853 out DX,AX
19FC:2854 mov AX,0xFF08
19FC:2857 out DX,AX
19FC:2858 mov AX,1
19FC:285B out DX,AX
19FC:285C mov AX,0xA000
19FC:285F mov ES,AX
19FC:2861 mov DI,word ptr SS:[BP+0x0A]
19FC:2864 mov AX,word ptr SS:[BP+0x0C]
19FC:2867 mov DX,0x0140
19FC:286A mul DX
19FC:286C add DI,AX
19FC:286E push DS
19FC:286F mov DS,word ptr DS:[0xB78C]
19FC:2873 mov CX,8
19FC:2876 mov DX,0x03C4
19FC:2879 mov AX,0x0102
19FC:287C out DX,AX
19FC:287D mov AL,byte ptr ES:[DI]
19FC:2880 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:2881 dec DI
19FC:2882 mov AX,0x0202
19FC:2885 out DX,AX
19FC:2886 mov AL,byte ptr ES:[DI]
19FC:2889 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:288A dec DI
19FC:288B mov AX,0x0402
19FC:288E out DX,AX
19FC:288F mov AL,byte ptr ES:[DI]
19FC:2892 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:2893 dec DI
19FC:2894 mov AX,0x0802
19FC:2897 out DX,AX
19FC:2898 mov AL,byte ptr ES:[DI]
19FC:289B movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:289C add DI,0x0027
19FC:289F loop 0x2879
19FC:28A1 mov AX,0x0F02
19FC:28A4 out DX,AX
19FC:28A5 jmp near 0x2819
19FC:28A8 push BP
19FC:28A9 mov BP,SP
19FC:28AB push DI
19FC:28AC push SI
19FC:28AD push DS
19FC:28AE mov AX,0x1DE9
19FC:28B1 mov DS,AX
19FC:28B3 mov AX,word ptr SS:[BP+6]
19FC:28B6 mov word ptr DS:[0xB78A],AX
19FC:28B9 mov AX,word ptr SS:[BP+8]
19FC:28BC mov word ptr DS:[0xB78C],AX
19FC:28BF mov AX,word ptr SS:[BP+0x0A]
19FC:28C2 mov word ptr DS:[0xB78E],AX
19FC:28C5 mov AX,word ptr SS:[BP+0x0C]
19FC:28C8 mov word ptr DS:[0xB790],AX
19FC:28CB mov DI,word ptr DS:[0xB78E]
19FC:28CF mov AX,word ptr DS:[0xB790]
19FC:28D2 push ES
19FC:28D3 mov ES,AX
19FC:28D5 mov SI,word ptr DS:[0xB78A]
19FC:28D9 mov CX,0x0040
19FC:28DC push DS
19FC:28DD mov DS,word ptr DS:[0xB78C]
19FC:28E1 cld
19FC:28E2 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:28E4 pop DS
19FC:28E5 pop ES
19FC:28E6 pop DS
19FC:28E7 pop SI
19FC:28E8 pop DI
19FC:28E9 pop BP
19FC:28EA ret far
19FC:28EB push BP
19FC:28EC mov BP,SP
19FC:28EE push DI
19FC:28EF push SI
19FC:28F0 push DS
19FC:28F1 mov AX,0x1DE9
19FC:28F4 mov DS,AX
19FC:28F6 cmp word ptr DS:[0xB764],0
19FC:28FB jne short 0x2900
19FC:28FD jmp near 0x2A1E
19FC:2900 push ES
19FC:2901 mov AX,word ptr SS:[BP+6]
19FC:2904 mov word ptr DS:[0xB78E],AX
19FC:2907 mov AX,word ptr SS:[BP+8]
19FC:290A mov word ptr DS:[0xB790],AX
19FC:290D mov AX,word ptr SS:[BP+0x0A]
19FC:2910 mov word ptr DS:[0xB78A],AX
19FC:2913 mov AX,word ptr SS:[BP+0x0C]
19FC:2916 mov word ptr DS:[0xB78C],AX
19FC:2919 mov AX,word ptr SS:[BP+0x0E]
19FC:291C sar AX,1
19FC:291E mov word ptr DS:[0xB792],AX
19FC:2921 mov AX,word ptr SS:[BP+0x10]
19FC:2924 mov word ptr DS:[0xB794],AX
19FC:2927 push DS
19FC:2928 mov SI,word ptr DS:[0xB78A]
19FC:292C inc SI
19FC:292D mov AX,word ptr DS:[0xB78C]
19FC:2930 mov DS,AX
19FC:2932 lods AX,word ptr DS:[SI]
19FC:2933 inc SI
19FC:2934 pop DS
19FC:2935 inc AL
19FC:2937 push AX
19FC:2938 and AX,0x00FF
19FC:293B mov word ptr DS:[0xB79C],AX
19FC:293E pop AX
19FC:293F xchg AL,AH
19FC:2941 and AX,0x00FF
19FC:2944 shl AX,1
19FC:2946 shl AX,1
19FC:2948 mov word ptr DS:[0xB79A],AX
19FC:294B mov word ptr DS:[0xB79E],AX
19FC:294E mov AX,word ptr DS:[0xB794]
19FC:2951 cmp AX,0
19FC:2954 jns short 0x2977
19FC:2956 neg AX
19FC:2958 cmp AX,word ptr DS:[0xB79C]
19FC:295C jae short 0x29BD
19FC:295E mov DX,word ptr DS:[0xB79A]
19FC:2962 mul DL
19FC:2964 add SI,AX
19FC:2966 mov AX,word ptr DS:[0xB79C]
19FC:2969 add AX,word ptr DS:[0xB794]
19FC:296D js short 0x29BD
19FC:296F mov word ptr DS:[0xB79C],AX
19FC:2972 xor AX,AX
19FC:2974 mov word ptr DS:[0xB794],AX
19FC:2977 mov AX,0x00C8
19FC:297A sub AX,word ptr DS:[0xB794]
19FC:297E js short 0x29BD
19FC:2980 je short 0x29BD
19FC:2982 cmp AX,word ptr DS:[0xB79C]
19FC:2986 jae short 0x298B
19FC:2988 mov word ptr DS:[0xB79C],AX
19FC:298B mov AX,word ptr DS:[0xB792]
19FC:298E cmp AX,0
19FC:2991 jns short 0x29A6
19FC:2993 add word ptr DS:[0xB79A],AX
19FC:2997 neg AX
19FC:2999 add SI,AX
19FC:299B cmp AX,word ptr DS:[0xB79E]
19FC:299F jae short 0x29BD
19FC:29A1 xor AX,AX
19FC:29A3 mov word ptr DS:[0xB792],AX
19FC:29A6 mov AX,0x00A0
19FC:29A9 sub AX,word ptr DS:[0xB792]
19FC:29AD js short 0x29BD
19FC:29AF je short 0x29BD
19FC:29B1 cmp AX,word ptr DS:[0xB79A]
19FC:29B5 jae short 0x29C0
19FC:29B7 mov word ptr DS:[0xB79A],AX
19FC:29BA jmp short 0x29C0
19FC:29BD jmp short 0x2A18
19FC:29C0 mov AX,word ptr DS:[0xB794]
19FC:29C3 mov DX,0x00A0
19FC:29C6 mul DL
19FC:29C8 add AX,word ptr DS:[0xB792]
19FC:29CC add AX,word ptr DS:[0xB78E]
19FC:29D0 mov DI,AX
19FC:29D2 mov DX,word ptr DS:[0xB790]
19FC:29D6 mov ES,DX
19FC:29D8 mov AX,0x00A0
19FC:29DB sub AX,word ptr DS:[0xB79A]
19FC:29DF mov word ptr DS:[0xB794],AX
19FC:29E2 mov DX,word ptr DS:[0xB78C]
19FC:29E6 mov BX,0xB661
19FC:29E9 mov CX,word ptr DS:[0xB79A]
19FC:29ED push BP
19FC:29EE mov BP,ES
19FC:29F0 mov ES,DX
19FC:29F2 mov AL,byte ptr ES:[SI]
19FC:29F5 mov AH,AL
19FC:29F7 xlat byte ptr DS:[BX+AL]
19FC:29F8 mov ES,BP
19FC:29FA and byte ptr ES:[DI],AL
19FC:29FD or byte ptr ES:[DI],AH
19FC:2A00 inc SI
19FC:2A01 inc DI
19FC:2A02 loop 0x29F0
19FC:2A04 pop BP
19FC:2A05 add SI,word ptr DS:[0xB79E]
19FC:2A09 sub SI,word ptr DS:[0xB79A]
19FC:2A0D add DI,word ptr DS:[0xB794]
19FC:2A11 sub word ptr DS:[0xB79C],1
19FC:2A16 jne short 0x29E9
19FC:2A18 pop ES
19FC:2A19 pop DS
19FC:2A1A pop SI
19FC:2A1B pop DI
19FC:2A1C pop BP
19FC:2A1D ret far
19FC:2A1E push ES
19FC:2A1F mov AX,word ptr SS:[BP+6]
19FC:2A22 mov word ptr DS:[0xB78E],AX
19FC:2A25 mov AX,word ptr SS:[BP+8]
19FC:2A28 mov word ptr DS:[0xB790],AX
19FC:2A2B mov AX,word ptr SS:[BP+0x0A]
19FC:2A2E mov word ptr DS:[0xB78A],AX
19FC:2A31 mov AX,word ptr SS:[BP+0x0C]
19FC:2A34 mov word ptr DS:[0xB78C],AX
19FC:2A37 mov AX,word ptr SS:[BP+0x0E]
19FC:2A3A sar AX,1
19FC:2A3C sar AX,1
19FC:2A3E mov word ptr DS:[0xB792],AX
19FC:2A41 mov AX,word ptr SS:[BP+0x10]
19FC:2A44 mov word ptr DS:[0xB794],AX
19FC:2A47 push DS
19FC:2A48 mov SI,word ptr DS:[0xB78A]
19FC:2A4C inc SI
19FC:2A4D mov AX,word ptr DS:[0xB78C]
19FC:2A50 mov DS,AX
19FC:2A52 lods AX,word ptr DS:[SI]
19FC:2A53 inc SI
19FC:2A54 mov BX,SI
19FC:2A56 pop DS
19FC:2A57 inc AL
19FC:2A59 push AX
19FC:2A5A and AX,0x00FF
19FC:2A5D mov word ptr DS:[0xB79C],AX
19FC:2A60 mov DX,AX
19FC:2A62 pop AX
19FC:2A63 xchg AL,AH
19FC:2A65 and AX,0x00FF
19FC:2A68 shl AX,1
19FC:2A6A mov word ptr DS:[0xB79A],AX
19FC:2A6D mov word ptr DS:[0xB79E],AX
19FC:2A70 xor AH,AH
19FC:2A72 mul DL
19FC:2A74 add BX,AX
19FC:2A76 mov AX,word ptr DS:[0xB794]
19FC:2A79 cmp AX,0
19FC:2A7C jns short 0x2AA1
19FC:2A7E neg AX
19FC:2A80 cmp AX,word ptr DS:[0xB79C]
19FC:2A84 jae short 0x2AE9
19FC:2A86 mov DX,word ptr DS:[0xB79A]
19FC:2A8A mul DL
19FC:2A8C add SI,AX
19FC:2A8E add BX,AX
19FC:2A90 mov AX,word ptr DS:[0xB79C]
19FC:2A93 add AX,word ptr DS:[0xB794]
19FC:2A97 js short 0x2AE9
19FC:2A99 mov word ptr DS:[0xB79C],AX
19FC:2A9C xor AX,AX
19FC:2A9E mov word ptr DS:[0xB794],AX
19FC:2AA1 mov AX,word ptr DS:[0xB780]
19FC:2AA4 sub AX,word ptr DS:[0xB794]
19FC:2AA8 js short 0x2AE9
19FC:2AAA je short 0x2AE9
19FC:2AAC cmp AX,word ptr DS:[0xB79C]
19FC:2AB0 jae short 0x2AB5
19FC:2AB2 mov word ptr DS:[0xB79C],AX
19FC:2AB5 mov AX,word ptr DS:[0xB792]
19FC:2AB8 cmp AX,0
19FC:2ABB jns short 0x2AD2
19FC:2ABD add word ptr DS:[0xB79A],AX
19FC:2AC1 neg AX
19FC:2AC3 add SI,AX
19FC:2AC5 add BX,AX
19FC:2AC7 cmp AX,word ptr DS:[0xB79E]
19FC:2ACB jae short 0x2AE9
19FC:2ACD xor AX,AX
19FC:2ACF mov word ptr DS:[0xB792],AX
19FC:2AD2 mov AX,0x0050
19FC:2AD5 sub AX,word ptr DS:[0xB792]
19FC:2AD9 js short 0x2AE9
19FC:2ADB je short 0x2AE9
19FC:2ADD cmp AX,word ptr DS:[0xB79A]
19FC:2AE1 jae short 0x2AEC
19FC:2AE3 mov word ptr DS:[0xB79A],AX
19FC:2AE6 jmp short 0x2AEC
19FC:2AE9 jmp near 0x2A18
19FC:2AEC mov AX,word ptr DS:[0xB794]
19FC:2AEF mov DX,0x0050
19FC:2AF2 mul DL
19FC:2AF4 add AX,word ptr DS:[0xB792]
19FC:2AF8 add AX,word ptr DS:[0xB78E]
19FC:2AFC mov DI,AX
19FC:2AFE mov DX,word ptr DS:[0xB790]
19FC:2B02 mov ES,DX
19FC:2B04 mov AX,0x0050
19FC:2B07 sub AX,word ptr DS:[0xB79A]
19FC:2B0B mov word ptr DS:[0xB794],AX
19FC:2B0E mov DX,word ptr DS:[0xB78C]
19FC:2B12 mov CX,word ptr DS:[0xB79A]
19FC:2B16 push DS
19FC:2B17 mov DS,DX
19FC:2B19 mov AL,byte ptr DS:[BX]
19FC:2B1B inc BX
19FC:2B1C and byte ptr ES:[DI],AL
19FC:2B1F lods AL,byte ptr DS:[SI]
19FC:2B20 or byte ptr ES:[DI],AL
19FC:2B23 inc DI
19FC:2B24 loop 0x2B19
19FC:2B26 pop DS
19FC:2B27 add SI,word ptr DS:[0xB79E]
19FC:2B2B sub SI,word ptr DS:[0xB79A]
19FC:2B2F add BX,word ptr DS:[0xB79E]
19FC:2B33 sub BX,word ptr DS:[0xB79A]
19FC:2B37 add DI,word ptr DS:[0xB794]
19FC:2B3B sub word ptr DS:[0xB79C],1
19FC:2B40 jne short 0x2B12
19FC:2B42 jmp near 0x2A18
19FC:2B87 push BP
19FC:2B88 mov BP,SP
19FC:2B8A push DI
19FC:2B8B push SI
19FC:2B8C push DS
19FC:2B8D mov AX,0x1DE9
19FC:2B90 mov DS,AX
19FC:2B92 mov AX,word ptr SS:[BP+6]
19FC:2B95 cmp word ptr DS:[0xB764],2
19FC:2B9A je short 0x2BB0
19FC:2B9C shl AX,1
19FC:2B9E cmp word ptr DS:[0xB764],0
19FC:2BA3 je short 0x2BB0
19FC:2BA5 shl AX,1
19FC:2BA7 cmp word ptr DS:[0xB764],1
19FC:2BAC je short 0x2BB0
19FC:2BAE shl AX,1
19FC:2BB0 mov word ptr DS:[0xB792],AX
19FC:2BB3 mov AX,word ptr SS:[BP+8]
19FC:2BB6 mov DX,0x0140
19FC:2BB9 cmp word ptr DS:[0xB764],3
19FC:2BBE jne short 0x2BC3
19FC:2BC0 mov DX,0x0A00
19FC:2BC3 mul DX
19FC:2BC5 add AX,word ptr DS:[0xB792]
19FC:2BC9 mov DI,AX
19FC:2BCB mov SI,AX
19FC:2BCD add SI,0x00A0
19FC:2BD1 push ES
19FC:2BD2 mov AX,0xB800
19FC:2BD5 cmp word ptr DS:[0xB764],2
19FC:2BDA jb short 0x2BDF
19FC:2BDC mov AX,0xA000
19FC:2BDF mov ES,AX
19FC:2BE1 mov AX,word ptr SS:[BP+0x0A]
19FC:2BE4 cmp word ptr DS:[0xB764],3
19FC:2BE9 jne short 0x2BEF
19FC:2BEB shl AX,1
19FC:2BED shl AX,1
19FC:2BEF cmp word ptr DS:[0xB764],1
19FC:2BF4 jne short 0x2BF8
19FC:2BF6 shl AX,1
19FC:2BF8 mov word ptr DS:[0xB79A],AX
19FC:2BFB mov AX,word ptr SS:[BP+0x0C]
19FC:2BFE cmp word ptr DS:[0xB764],3
19FC:2C03 je short 0x2C11
19FC:2C05 cmp word ptr DS:[0xB764],1
19FC:2C0A je short 0x2C48
19FC:2C0C jb short 0x2C81
19FC:2C0E jmp near 0x2CB0
19FC:2C11 and AL,0x0F
19FC:2C13 mov DL,AL
19FC:2C15 mov DH,AL
19FC:2C17 cmp word ptr DS:[0xB782],0
19FC:2C1C je short 0x2C26
19FC:2C1E shl DL,1
19FC:2C20 shl DL,1
19FC:2C22 shl DL,1
19FC:2C24 shl DL,1
19FC:2C26 mov BX,0x0140
19FC:2C29 sub BX,word ptr DS:[0xB79A]
19FC:2C2D sub BX,word ptr DS:[0xB79A]
19FC:2C31 mov AL,8
19FC:2C33 mov CX,word ptr DS:[0xB79A]
19FC:2C37 xor word ptr ES:[DI],DX
19FC:2C3A add DI,2
19FC:2C3D loop 0x2C37
19FC:2C3F add DI,BX
19FC:2C41 dec AL
19FC:2C43 jne short 0x2C33
19FC:2C45 jmp short 0x2C7B
19FC:2C48 mov BL,AL
19FC:2C4A mov CX,4
19FC:2C4D shl AL,CL
19FC:2C4F or AL,BL
19FC:2C51 mov AH,AL
19FC:2C53 mov DX,AX
19FC:2C55 mov BX,0x2000
19FC:2C58 mov AX,word ptr DS:[0xB79A]
19FC:2C5B shl AX,1
19FC:2C5D sub BX,AX
19FC:2C5F mov AL,4
19FC:2C61 mov CX,word ptr DS:[0xB79A]
19FC:2C65 xor word ptr ES:[SI],DX
19FC:2C68 xor word ptr ES:[DI],DX
19FC:2C6B add SI,2
19FC:2C6E add DI,2
19FC:2C71 loop 0x2C65
19FC:2C73 add SI,BX
19FC:2C75 add DI,BX
19FC:2C77 dec AL
19FC:2C79 jne short 0x2C61
19FC:2C7B pop ES
19FC:2C7C pop DS
19FC:2C7D pop SI
19FC:2C7E pop DI
19FC:2C7F pop BP
19FC:2C80 ret far
19FC:2C81 mov DX,0xFFFF
19FC:2C84 add SI,0x1F60
19FC:2C88 mov BX,0x0050
19FC:2C8B mov AX,word ptr DS:[0xB79A]
19FC:2C8E shl AX,1
19FC:2C90 sub BX,AX
19FC:2C92 mov AL,4
19FC:2C94 mov CX,word ptr DS:[0xB79A]
19FC:2C98 xor word ptr ES:[DI],DX
19FC:2C9B xor word ptr ES:[SI],DX
19FC:2C9E add SI,2
19FC:2CA1 add DI,2
19FC:2CA4 loop 0x2C98
19FC:2CA6 add SI,BX
19FC:2CA8 add DI,BX
19FC:2CAA dec AL
19FC:2CAC jne short 0x2C94
19FC:2CAE jmp short 0x2C7B
19FC:2CB0 mov BL,AL
19FC:2CB2 mov DX,0x03CE
19FC:2CB5 mov AX,0x0205
19FC:2CB8 out DX,AX
19FC:2CB9 mov AX,0xFF08
19FC:2CBC out DX,AX
19FC:2CBD mov AX,0x1803
19FC:2CC0 out DX,AX
19FC:2CC1 mov BH,8
19FC:2CC3 mov CX,word ptr DS:[0xB79A]
19FC:2CC7 mov AL,byte ptr ES:[DI]
19FC:2CCA mov byte ptr ES:[DI],BL
19FC:2CCD inc DI
19FC:2CCE loop 0x2CC7
19FC:2CD0 add DI,0x0028
19FC:2CD3 sub DI,word ptr DS:[0xB79A]
19FC:2CD7 dec BH
19FC:2CD9 jne short 0x2CC3
19FC:2CDB mov AX,3
19FC:2CDE out DX,AX
19FC:2CDF jmp short 0x2C7B
19FC:2CE1 push BP
19FC:2CE2 mov BP,SP
19FC:2CE4 push DI
19FC:2CE5 push SI
19FC:2CE6 push DS
19FC:2CE7 mov AX,0x1DE9
19FC:2CEA mov DS,AX
19FC:2CEC mov AX,word ptr SS:[BP+6]
19FC:2CEF mov word ptr DS:[0xB764],AX
19FC:2CF2 pop DS
19FC:2CF3 pop SI
19FC:2CF4 pop DI
19FC:2CF5 pop BP
19FC:2CF6 ret far
19FC:2CF7 push BP
19FC:2CF8 mov BP,SP
19FC:2CFA push DI
19FC:2CFB push SI
19FC:2CFC push DS
19FC:2CFD mov AX,0x1DE9
19FC:2D00 mov DS,AX
19FC:2D02 push ES
19FC:2D03 mov AX,DS
19FC:2D05 mov ES,AX
19FC:2D07 cld
19FC:2D08 cmp word ptr DS:[0xB764],2
19FC:2D0D jae short 0x2D5E
19FC:2D0F mov SI,0xA661
19FC:2D12 add SI,0x03FF
19FC:2D16 mov DI,0xA661
19FC:2D19 cmp word ptr DS:[0xB764],0
19FC:2D1E je short 0x2D39
19FC:2D20 add DI,0x0FFC
19FC:2D24 mov BL,byte ptr DS:[SI]
19FC:2D26 call near 0x2D64
19FC:2D39 add DI,0x07FE
19FC:2D3D mov BL,byte ptr DS:[SI]
19FC:2D3F mov CX,8
19FC:2D42 xor AX,AX
19FC:2D44 shl AX,1
19FC:2D46 shl AX,1
19FC:2D48 shl BL,1
19FC:2D4A jae short 0x2D4E
19FC:2D4C or AL,3
19FC:2D4E loop 0x2D44
19FC:2D50 xchg AH,AL
19FC:2D52 mov word ptr DS:[DI],AX
19FC:2D54 sub DI,2
19FC:2D57 dec SI
19FC:2D58 cmp SI,0xA661
19FC:2D5C jne short 0x2D3D
19FC:2D5E pop ES
19FC:2D5F pop DS
19FC:2D60 pop SI
19FC:2D61 pop DI
19FC:2D62 pop BP
19FC:2D63 ret far
19FC:2D64 xor AX,AX
19FC:2D66 shl BL,1
19FC:2D68 jae short 0x2D6C
19FC:2D6A or AL,0xF0
19FC:2D6C shl BL,1
19FC:2D6E jae short 0x2D72
19FC:2D70 or AL,0x0F
19FC:2D72 shl BL,1
19FC:2D74 jae short 0x2D79
19FC:2D76 or AH,0xF0
19FC:2D79 shl BL,1
19FC:2D7B jae short 0x2D80
19FC:2D7D or AH,0x0F
19FC:2D80 stos word ptr ES:[DI],AX
19FC:2D81 ret near
19FC:2D82 mov AH,0x30
19FC:2D84 int 0x21
19FC:2D86 cmp AL,2
19FC:2D88 jae short 0x2D8C
19FC:2D8A int 0x20
19FC:2D8C mov DI,0x3858
19FC:2D8F mov SI,word ptr DS:[2]
19FC:2D93 sub SI,DI
19FC:2D95 cmp SI,0x1000
19FC:2D99 jb short 0x2D9E
19FC:2D9B mov SI,0x1000
19FC:2D9E cli
19FC:2D9F mov SS,DI
19FC:2DA1 add SP,0x582E
19FC:2DA5 sti
19FC:2DA6 jae short 0x2DBC
19FC:2DA8 push SS
19FC:2DA9 pop DS
19FC:2DAA call far 19FC:2FB2
19FC:2DBC and SP,-2
19FC:2DBF mov word ptr SS:[0x5286],SP
19FC:2DC4 mov word ptr SS:[0x5282],SP
19FC:2DC9 mov AX,SI
19FC:2DCB mov CL,4
19FC:2DCD shl AX,CL
19FC:2DCF dec AX
19FC:2DD0 mov word ptr SS:[0x5280],AX
19FC:2DD4 add SI,DI
19FC:2DD6 mov word ptr DS:[2],SI
19FC:2DDA mov BX,ES
19FC:2DDC sub BX,SI
19FC:2DDE neg BX
19FC:2DE0 mov AH,0x4A
19FC:2DE2 int 0x21
19FC:2DE4 mov word ptr SS:[0x52F7],DS
19FC:2DE9 push SS
19FC:2DEA pop ES
19FC:2DEB cld
19FC:2DEC mov DI,0x57FE
19FC:2DEF mov CX,0x5830
19FC:2DF2 sub CX,DI
19FC:2DF4 xor AX,AX
19FC:2DF6 rep stos byte ptr ES:[DI],AL
19FC:2DF8 push SS
19FC:2DF9 pop DS
19FC:2DFA call far 19FC:2E50
19FC:2DFF push SS
19FC:2E00 pop DS
19FC:2E01 call far 19FC:31CE
19FC:2E06 call far 19FC:3026
19FC:2E0B xor BP,BP
19FC:2E0D push word ptr DS:[0x531C]
19FC:2E11 push word ptr DS:[0x531A]
19FC:2E15 push word ptr DS:[0x5318]
19FC:2E19 push word ptr DS:[0x5316]
19FC:2E1D push word ptr DS:[0x5314]
19FC:2E21 call far 06A4:0044
19FC:2E3B push AX
19FC:2E3C call far 19FC:2FB2
19FC:2E50 mov AH,0x30
19FC:2E52 int 0x21
19FC:2E54 mov word ptr DS:[0x52F9],AX
19FC:2E57 mov AX,0x3500
19FC:2E5A int 0x21
19FC:2E5C mov word ptr DS:[0x52E5],BX
19FC:2E60 mov word ptr DS:[0x52E7],ES
19FC:2E64 push CS
19FC:2E65 pop DS
19FC:2E66 mov AX,0x2500
19FC:2E69 mov DX,0x2E2C
19FC:2E6C int 0x21
19FC:2E6E push SS
19FC:2E6F pop DS
19FC:2E70 mov CX,word ptr DS:[0x537A]
19FC:2E74 jcxz short 0x2EA4
19FC:2E76 mov ES,word ptr DS:[0x52F7]
19FC:2E7A mov SI,word ptr ES:[0x002C]
19FC:2E7F lds AX,word ptr DS:[0x537C]
19FC:2E83 mov DX,DS
19FC:2E85 xor BX,BX
19FC:2E87 call far dword ptr SS:[0x5378]
19FC:2EA4 mov ES,word ptr DS:[0x52F7]
19FC:2EA8 mov CX,word ptr ES:[0x002C]
19FC:2EAD jcxz short 0x2EE5
19FC:2EAF mov ES,CX
19FC:2EB1 xor DI,DI
19FC:2EB3 cmp byte ptr ES:[DI],0
19FC:2EB7 je short 0x2EE5
19FC:2EB9 mov CX,0x000C
19FC:2EBC mov SI,0x52D8
19FC:2EBF repe cmps byte ptr DS:[SI],byte ptr ES:[DI]
19FC:2EC1 je short 0x2ECE
19FC:2EC3 mov CX,0x7FFF
19FC:2EC6 xor AX,AX
19FC:2EC8 repne scas AL,byte ptr ES:[DI]
19FC:2ECA jne short 0x2EE5
19FC:2ECC jmp short 0x2EB3
19FC:2ECE push ES
19FC:2ECF push DS
19FC:2ED0 pop ES
19FC:2ED1 pop DS
19FC:2ED2 mov SI,DI
19FC:2ED4 mov DI,0x5300
19FC:2ED7 lods AL,byte ptr DS:[SI]
19FC:2ED8 cbw
19FC:2ED9 xchg CX,AX
19FC:2EDA lods AL,byte ptr DS:[SI]
19FC:2EDB inc AL
19FC:2EDD je short 0x2EE0
19FC:2EDF dec AX
19FC:2EE0 stos byte ptr ES:[DI],AL
19FC:2EE1 loop 0x2EDA
19FC:2EE3 push SS
19FC:2EE4 pop DS
19FC:2EE5 mov BX,4
19FC:2EE8 and byte ptr DS:[BX+0x5300],0xBF
19FC:2EED mov AX,0x4400
19FC:2EF0 int 0x21
19FC:2EF2 jb short 0x2EFE
19FC:2EF4 test DL,0x80
19FC:2EF7 je short 0x2EFE
19FC:2EF9 or byte ptr DS:[BX+0x5300],0x40
19FC:2EFE dec BX
19FC:2EFF jns short 0x2EE8
19FC:2F01 mov SI,0x5384
19FC:2F04 mov DI,0x5384
19FC:2F07 call near 0x2F9F
19FC:2F0A mov SI,0x5384
19FC:2F0D mov DI,0x5384
19FC:2F10 call near 0x2F9F
19FC:2F13 ret far
19FC:2F9F cmp SI,DI
19FC:2FA1 jae short 0x2FB1
19FC:2FA3 sub DI,4
19FC:2FA6 mov AX,word ptr DS:[DI]
19FC:2FA8 or AX,word ptr DS:[DI+2]
19FC:2FAB je short 0x2F9F
19FC:2FAD call far dword ptr DS:[DI]
19FC:2FB1 ret near
19FC:2FB2 push BP
19FC:2FB3 mov BP,SP
19FC:2FB5 mov AX,0x00FC
19FC:2FB8 push AX
19FC:2FB9 call far 19FC:3275
19FC:2FDC pop CX
19FC:2FDD pop DX
19FC:2FDE mov BX,SP
19FC:2FE0 sub BX,AX
19FC:2FE2 jb short 0x2FEF
19FC:2FE4 cmp BX,word ptr DS:[0x5334]
19FC:2FE8 jb short 0x2FEF
19FC:2FEA mov SP,BX
19FC:2FEC push DX
19FC:2FED push CX
19FC:2FEE ret far
19FC:2FEF mov AX,word ptr DS:[0x5330]
19FC:2FF2 inc AX
19FC:2FF3 jne short 0x2FFA
19FC:2FF5 xor AX,AX
19FC:2FF7 jmp near 0x2E3B
19FC:2FFA push DX
19FC:2FFB push CX
19FC:2FFC jmp far dword ptr DS:[0x5330]
19FC:3026 pop word ptr DS:[0x5336]
19FC:302A pop word ptr DS:[0x5338]
19FC:302E mov DX,2
19FC:3031 cmp byte ptr DS:[0x52F9],DL
19FC:3035 je short 0x3060
19FC:3037 mov ES,word ptr DS:[0x52F7]
19FC:303B mov ES,word ptr ES:[0x002C]
19FC:3040 mov word ptr DS:[0x5320],ES
19FC:3044 xor AX,AX
19FC:3046 cwd
19FC:3047 mov CX,0x8000
19FC:304A xor DI,DI
19FC:304C repne scas AL,byte ptr ES:[DI]
19FC:304E scas AL,byte ptr ES:[DI]
19FC:304F jne short 0x304C
19FC:3051 inc DI
19FC:3052 inc DI
19FC:3053 mov word ptr DS:[0x531E],DI
19FC:3057 mov CX,0xFFFF
19FC:305A repne scas AL,byte ptr ES:[DI]
19FC:305C not CX
19FC:305E mov DX,CX
19FC:3060 mov DI,1
19FC:3063 mov SI,0x0081
19FC:3066 mov DS,word ptr DS:[0x52F7]
19FC:306A lods AL,byte ptr DS:[SI]
19FC:306B cmp AL,0x20
19FC:306D je short 0x306A
19FC:306F cmp AL,9
19FC:3071 je short 0x306A
19FC:3073 cmp AL,0x0D
19FC:3075 je short 0x30E6
19FC:3077 or AL,AL
19FC:3079 je short 0x30E6
19FC:307B inc DI
19FC:307C dec SI
19FC:307D lods AL,byte ptr DS:[SI]
19FC:307E cmp AL,0x20
19FC:3080 je short 0x306A
19FC:3082 cmp AL,9
19FC:3084 je short 0x306A
19FC:3086 cmp AL,0x0D
19FC:3088 je short 0x30E6
19FC:308A or AL,AL
19FC:308C je short 0x30E6
19FC:308E cmp AL,0x22
19FC:3090 je short 0x30B6
19FC:3092 cmp AL,0x5C
19FC:3094 je short 0x3099
19FC:3096 inc DX
19FC:3097 jmp short 0x307D
19FC:3099 xor CX,CX
19FC:309B inc CX
19FC:309C lods AL,byte ptr DS:[SI]
19FC:309D cmp AL,0x5C
19FC:309F je short 0x309B
19FC:30A1 cmp AL,0x22
19FC:30A3 je short 0x30A9
19FC:30A5 add DX,CX
19FC:30A7 jmp short 0x307C
19FC:30A9 mov AX,CX
19FC:30AB shr CX,1
19FC:30AD adc DX,CX
19FC:30AF test AL,1
19FC:30B1 jne short 0x307D
19FC:30B3 jmp short 0x30B6
19FC:30B5 dec SI
19FC:30B6 lods AL,byte ptr DS:[SI]
19FC:30B7 cmp AL,0x0D
19FC:30B9 je short 0x30E6
19FC:30BB or AL,AL
19FC:30BD je short 0x30E6
19FC:30BF cmp AL,0x22
19FC:30C1 je short 0x307D
19FC:30C3 cmp AL,0x5C
19FC:30C5 je short 0x30CA
19FC:30C7 inc DX
19FC:30C8 jmp short 0x30B6
19FC:30CA xor CX,CX
19FC:30CC inc CX
19FC:30CD lods AL,byte ptr DS:[SI]
19FC:30CE cmp AL,0x5C
19FC:30D0 je short 0x30CC
19FC:30D2 cmp AL,0x22
19FC:30D4 je short 0x30DA
19FC:30D6 add DX,CX
19FC:30D8 jmp short 0x30B5
19FC:30DA mov AX,CX
19FC:30DC shr CX,1
19FC:30DE adc DX,CX
19FC:30E0 test AL,1
19FC:30E2 jne short 0x30B6
19FC:30E4 jmp short 0x307D
19FC:30E6 push SS
19FC:30E7 pop DS
19FC:30E8 mov word ptr DS:[0x5314],DI
19FC:30EC add DX,DI
19FC:30EE inc DI
19FC:30EF shl DI,1
19FC:30F1 shl DI,1
19FC:30F3 add DX,DI
19FC:30F5 and DL,0xFE
19FC:30F8 sub SP,DX
19FC:30FA mov AX,SP
19FC:30FC mov word ptr DS:[0x5316],AX
19FC:30FF mov word ptr DS:[0x5318],DS
19FC:3103 mov BX,AX
19FC:3105 add DI,BX
19FC:3107 push SS
19FC:3108 pop ES
19FC:3109 mov word ptr SS:[BX],DI
19FC:310C mov word ptr SS:[BX+2],SS
19FC:3110 add BX,4
19FC:3113 lds SI,word ptr DS:[0x531E]
19FC:3117 lods AL,byte ptr DS:[SI]
19FC:3118 stos byte ptr ES:[DI],AL
19FC:3119 or AL,AL
19FC:311B jne short 0x3117
19FC:311D mov SI,0x0081
19FC:3120 mov DS,word ptr SS:[0x52F7]
19FC:3125 jmp short 0x312A
19FC:3127 xor AX,AX
19FC:3129 stos byte ptr ES:[DI],AL
19FC:312A lods AL,byte ptr DS:[SI]
19FC:312B cmp AL,0x20
19FC:312D je short 0x312A
19FC:312F cmp AL,9
19FC:3131 je short 0x312A
19FC:3133 cmp AL,0x0D
19FC:3135 jne short 0x313A
19FC:3137 jmp near 0x31BE
19FC:313A or AL,AL
19FC:313C jne short 0x3141
19FC:313E jmp short 0x31BE
19FC:3141 mov word ptr SS:[BX],DI
19FC:3144 mov word ptr SS:[BX+2],SS
19FC:3148 add BX,4
19FC:314B dec SI
19FC:314C lods AL,byte ptr DS:[SI]
19FC:314D cmp AL,0x20
19FC:314F je short 0x3127
19FC:3151 cmp AL,9
19FC:3153 je short 0x3127
19FC:3155 cmp AL,0x0D
19FC:3157 je short 0x31BB
19FC:3159 or AL,AL
19FC:315B je short 0x31BB
19FC:315D cmp AL,0x22
19FC:315F je short 0x3188
19FC:3161 cmp AL,0x5C
19FC:3163 je short 0x3168
19FC:3165 stos byte ptr ES:[DI],AL
19FC:3166 jmp short 0x314C
19FC:3168 xor CX,CX
19FC:316A inc CX
19FC:316B lods AL,byte ptr DS:[SI]
19FC:316C cmp AL,0x5C
19FC:316E je short 0x316A
19FC:3170 cmp AL,0x22
19FC:3172 je short 0x317A
19FC:3174 mov AL,0x5C
19FC:3176 rep stos byte ptr ES:[DI],AL
19FC:3178 jmp short 0x314B
19FC:317A mov AL,0x5C
19FC:317C shr CX,1
19FC:317E rep stos byte ptr ES:[DI],AL
19FC:3180 jae short 0x3188
19FC:3182 mov AL,0x22
19FC:3184 stos byte ptr ES:[DI],AL
19FC:3185 jmp short 0x314C
19FC:3187 dec SI
19FC:3188 lods AL,byte ptr DS:[SI]
19FC:3189 cmp AL,0x0D
19FC:318B je short 0x31BB
19FC:318D or AL,AL
19FC:318F je short 0x31BB
19FC:3191 cmp AL,0x22
19FC:3193 je short 0x314C
19FC:3195 cmp AL,0x5C
19FC:3197 je short 0x319C
19FC:3199 stos byte ptr ES:[DI],AL
19FC:319A jmp short 0x3188
19FC:319C xor CX,CX
19FC:319E inc CX
19FC:319F lods AL,byte ptr DS:[SI]
19FC:31A0 cmp AL,0x5C
19FC:31A2 je short 0x319E
19FC:31A4 cmp AL,0x22
19FC:31A6 je short 0x31AE
19FC:31A8 mov AL,0x5C
19FC:31AA rep stos byte ptr ES:[DI],AL
19FC:31AC jmp short 0x3187
19FC:31AE mov AL,0x5C
19FC:31B0 shr CX,1
19FC:31B2 rep stos byte ptr ES:[DI],AL
19FC:31B4 jae short 0x314C
19FC:31B6 mov AL,0x22
19FC:31B8 stos byte ptr ES:[DI],AL
19FC:31B9 jmp short 0x3188
19FC:31BB xor AX,AX
19FC:31BD stos byte ptr ES:[DI],AL
19FC:31BE push SS
19FC:31BF pop DS
19FC:31C0 mov word ptr DS:[BX],0
19FC:31C4 mov word ptr DS:[BX+2],0
19FC:31C9 jmp far dword ptr DS:[0x5336]
19FC:31CE push BP
19FC:31CF mov BP,SP
19FC:31D1 push BP
19FC:31D2 mov DS,word ptr DS:[0x52F7]
19FC:31D6 xor CX,CX
19FC:31D8 mov AX,CX
19FC:31DA mov BP,CX
19FC:31DC mov DI,CX
19FC:31DE dec CX
19FC:31DF mov SI,word ptr DS:[0x002C]
19FC:31E3 or SI,SI
19FC:31E5 je short 0x31F7
19FC:31E7 mov ES,SI
19FC:31E9 cmp byte ptr ES:[0],0
19FC:31EF je short 0x31F7
19FC:31F1 repne scas AL,byte ptr ES:[DI]
19FC:31F3 inc BP
19FC:31F4 scas AL,byte ptr ES:[DI]
19FC:31F5 jne short 0x31F1
19FC:31F7 inc BP
19FC:31F8 xchg DI,AX
19FC:31F9 inc AX
19FC:31FA and AL,0xFE
19FC:31FC mov DI,BP
19FC:31FE shl BP,1
19FC:3200 shl BP,1
19FC:3202 add AX,BP
19FC:3204 push SS
19FC:3205 pop DS
19FC:3206 push DI
19FC:3207 mov DI,9
19FC:320A call near 0x32A0
19FC:320D pop DI
19FC:320E mov CX,DI
19FC:3210 mov DI,BP
19FC:3212 add DI,AX
19FC:3214 mov word ptr DS:[0x531A],BP
19FC:3218 mov word ptr DS:[0x531C],DS
19FC:321C push DS
19FC:321D pop ES
19FC:321E mov DS,SI
19FC:3220 xor SI,SI
19FC:3222 dec CX
19FC:3223 jcxz short 0x323C
19FC:3225 cmp word ptr DS:[SI],0x433B
19FC:3229 je short 0x3234
19FC:322B mov word ptr SS:[BP],DI
19FC:322E mov word ptr SS:[BP+2],ES
19FC:3231 add BP,4
19FC:3234 lods AL,byte ptr DS:[SI]
19FC:3235 stos byte ptr ES:[DI],AL
19FC:3236 or AL,AL
19FC:3238 jne short 0x3234
19FC:323A loop 0x3225
19FC:323C mov word ptr SS:[BP],CX
19FC:323F mov word ptr SS:[BP+2],CX
19FC:3242 push SS
19FC:3243 pop DS
19FC:3244 pop BP
19FC:3245 mov SP,BP
19FC:3247 pop BP
19FC:3248 ret far
19FC:324A push BP
19FC:324B mov BP,SP
19FC:324D push SI
19FC:324E push DI
19FC:324F push DS
19FC:3250 pop ES
19FC:3251 mov DX,word ptr SS:[BP+6]
19FC:3254 mov SI,0x572C
19FC:3257 lods AX,word ptr DS:[SI]
19FC:3258 cmp AX,DX
19FC:325A je short 0x326C
19FC:325C inc AX
19FC:325D xchg SI,AX
19FC:325E je short 0x326C
19FC:3260 xchg DI,AX
19FC:3261 xor AX,AX
19FC:3263 mov CX,0xFFFF
19FC:3266 repne scas AL,byte ptr ES:[DI]
19FC:3268 mov SI,DI
19FC:326A jmp short 0x3257
19FC:326C xchg SI,AX
19FC:326D pop DI
19FC:326E pop SI
19FC:326F mov SP,BP
19FC:3271 pop BP
19FC:3272 ret far 2
19FC:3275 push BP
19FC:3276 mov BP,SP
19FC:3278 push DI
19FC:3279 push word ptr SS:[BP+6]
19FC:327C call far 19FC:324A
19FC:32A0 mov DX,AX
19FC:32A2 add AX,word ptr DS:[0x5286]
19FC:32A6 jb short 0x32DD
19FC:32A8 cmp word ptr DS:[0x5280],AX
19FC:32AC jae short 0x32D3
19FC:32AE add AX,0x000F
19FC:32B1 push AX
19FC:32B2 rcr AX,1
19FC:32B4 mov CL,3
19FC:32B6 shr AX,CL
19FC:32B8 mov CX,DS
19FC:32BA mov BX,word ptr DS:[0x52F7]
19FC:32BE sub CX,BX
19FC:32C0 add AX,CX
19FC:32C2 mov ES,BX
19FC:32C4 mov BX,AX
19FC:32C6 mov AH,0x4A
19FC:32C8 int 0x21
19FC:32D3 xchg BP,AX
19FC:32D4 mov BP,word ptr DS:[0x5286]
19FC:32D8 add word ptr DS:[0x5286],DX
19FC:32DC ret near
19FC:32DD mov AX,DI
19FC:32DF jmp near 0x2E3B
19FC:32E2 jb short 0x32F7
19FC:32E4 xor AX,AX
19FC:32E6 mov SP,BP
19FC:32E8 pop BP
19FC:32E9 ret far
19FC:32F5 jae short 0x32FE
19FC:32F7 call near 0x3308
19FC:32FE mov SP,BP
19FC:3300 pop BP
19FC:3301 ret far
19FC:3308 mov byte ptr DS:[0x52FC],AL
19FC:330B or AH,AH
19FC:330D jne short 0x3332
19FC:330F cmp byte ptr DS:[0x52F9],3
19FC:3314 jb short 0x3323
19FC:3316 cmp AL,0x22
19FC:3318 jae short 0x3327
19FC:331A cmp AL,0x20
19FC:331C jb short 0x3323
19FC:331E mov AL,5
19FC:3320 jmp short 0x3329
19FC:3323 cmp AL,0x13
19FC:3325 jbe short 0x3329
19FC:3327 mov AL,0x13
19FC:3329 mov BX,0x533A
19FC:332C xlat byte ptr DS:[BX+AL]
19FC:332D cbw
19FC:332E mov word ptr DS:[0x52F1],AX
19FC:3331 ret near
19FC:3332 mov AL,AH
19FC:3334 jmp short 0x332D
19FC:3336 push BP
19FC:3337 mov BP,SP
19FC:3339 mov BX,word ptr SS:[BP+6]
19FC:333C cmp BX,word ptr DS:[0x52FE]
19FC:3340 jb short 0x3348
19FC:3342 mov AX,0x0900
19FC:3345 stc
19FC:3346 jmp short 0x3353
19FC:3348 mov AH,0x3E
19FC:334A int 0x21
19FC:334C jb short 0x3353
19FC:334E mov byte ptr DS:[BX+0x5300],0
19FC:3353 jmp near 0x32E2
19FC:3356 push BP
19FC:3357 mov BP,SP
19FC:3359 sub SP,4
19FC:335C mov BX,word ptr SS:[BP+6]
19FC:335F cmp BX,word ptr DS:[0x52FE]
19FC:3363 jb short 0x336A
19FC:3365 mov AX,0x0900
19FC:3368 jmp short 0x3394
19FC:336A test word ptr SS:[BP+0x0A],0x8000
19FC:336F je short 0x33B9
19FC:3371 cmp word ptr SS:[BP+0x0C],0
19FC:3375 je short 0x3391
19FC:3377 xor CX,CX
19FC:3379 mov DX,CX
19FC:337B mov AX,0x4201
19FC:337E int 0x21
19FC:3391 mov AX,0x1600
19FC:3394 stc
19FC:3395 jmp short 0x33CD
19FC:33B9 mov DX,word ptr SS:[BP+8]
19FC:33BC mov CX,word ptr SS:[BP+0x0A]
19FC:33BF mov AL,byte ptr SS:[BP+0x0C]
19FC:33C2 mov AH,0x42
19FC:33C4 int 0x21
19FC:33C6 jb short 0x33CD
19FC:33C8 and byte ptr DS:[BX+0x5300],0xFD
19FC:33CD jmp near 0x32F5
19FC:33D0 push BP
19FC:33D1 mov BP,SP
19FC:33D3 sub SP,4
19FC:33D6 xor BH,BH
19FC:33D8 mov byte ptr SS:[BP-2],BH
19FC:33DB mov AX,word ptr SS:[BP+0x0A]
19FC:33DE mov CX,AX
19FC:33E0 mov byte ptr SS:[BP-4],0
19FC:33E4 test AX,0x8000
19FC:33E7 jne short 0x33F9
19FC:33E9 test AX,0x4000
19FC:33EC jne short 0x33F5
19FC:33EE test byte ptr DS:[0x534F],0x80
19FC:33F3 jne short 0x33F9
19FC:33F5 mov byte ptr SS:[BP-4],0x80
19FC:33F9 push DS
19FC:33FA lds DX,word ptr SS:[BP+6]
19FC:33FD and AL,3
19FC:33FF or AL,BH
19FC:3401 mov AH,0x3D
19FC:3403 int 0x21
19FC:3405 pop DS
19FC:3406 jae short 0x341A
19FC:3408 cmp AX,2
19FC:340B jne short 0x3416
19FC:340D test CX,0x0100
19FC:3411 je short 0x3416
19FC:3413 jmp near 0x34B9
19FC:3416 stc
19FC:3417 jmp near 0x32F5
19FC:341A xchg BX,AX
19FC:341B mov AX,CX
19FC:341D and AX,0x0500
19FC:3420 cmp AX,0x0500
19FC:3423 jne short 0x342E
19FC:3425 mov AH,0x3E
19FC:3427 int 0x21
19FC:342E mov byte ptr SS:[BP-3],1
19FC:3432 mov AX,0x4400
19FC:3435 int 0x21
19FC:3437 test DL,0x80
19FC:343A je short 0x3440
19FC:343C or byte ptr SS:[BP-4],0x40
19FC:3440 test byte ptr SS:[BP-4],0x40
19FC:3444 je short 0x3449
19FC:3446 jmp near 0x3526
19FC:3449 mov AX,word ptr SS:[BP+0x0A]
19FC:344C test AX,0x0200
19FC:344F je short 0x3470
19FC:3451 test AX,3
19FC:3454 je short 0x345F
19FC:3456 xor CX,CX
19FC:3458 mov AH,0x40
19FC:345A int 0x21
19FC:345F mov AH,0x3E
19FC:3461 int 0x21
19FC:3470 test byte ptr SS:[BP-4],0x80
19FC:3474 jne short 0x3479
19FC:3476 jmp near 0x3526
19FC:3479 test AX,2
19FC:347C jne short 0x3481
19FC:347E jmp near 0x3526
19FC:3481 mov CX,0xFFFF
19FC:3484 mov DX,CX
19FC:3486 mov AX,0x4202
19FC:3489 int 0x21
19FC:34B9 mov byte ptr SS:[BP-3],0
19FC:34BD mov CX,word ptr SS:[BP+0x0C]
19FC:34C0 call near 0x356F
19FC:3526 test byte ptr SS:[BP-4],0x40
19FC:352A jne short 0x356B
19FC:352C push DS
19FC:352D lds DX,word ptr SS:[BP+6]
19FC:3530 mov AX,0x4300
19FC:3533 int 0x21
19FC:3535 pop DS
19FC:3536 mov AX,CX
19FC:3538 xor CL,CL
19FC:353A and AX,1
19FC:353D je short 0x3541
19FC:353F mov CL,0x10
19FC:3541 test word ptr SS:[BP+0x0A],8
19FC:3546 je short 0x354B
19FC:3548 or CL,0x20
19FC:354B cmp BX,word ptr DS:[0x52FE]
19FC:354F jb short 0x355B
19FC:3551 mov AH,0x3E
19FC:3553 int 0x21
19FC:355B or CL,byte ptr SS:[BP-4]
19FC:355E or CL,1
19FC:3561 mov byte ptr DS:[BX+0x5300],CL
19FC:3565 mov AX,BX
19FC:3567 mov SP,BP
19FC:3569 pop BP
19FC:356A ret far
19FC:356B xor CL,CL
19FC:356D jmp short 0x354B
19FC:356F mov AX,word ptr DS:[0x52F3]
19FC:3572 not AX
19FC:3574 and AX,CX
19FC:3576 xor CX,CX
19FC:3578 test AL,0x80
19FC:357A jne short 0x357F
19FC:357C or CL,1
19FC:357F ret near
19FC:3580 push BP
19FC:3581 mov BP,SP
19FC:3583 sub SP,2
19FC:3586 mov BX,word ptr SS:[BP+6]
19FC:3589 cmp BX,word ptr DS:[0x52FE]
19FC:358D jb short 0x3595
19FC:358F stc
19FC:3590 mov AX,0x0900
19FC:3593 jmp short 0x35FC
19FC:3595 xor AX,AX
19FC:3597 mov CX,word ptr SS:[BP+0x0C]
19FC:359A jcxz short 0x35FC
19FC:359C test byte ptr DS:[BX+0x5300],2
19FC:35A1 jne short 0x35FC
19FC:35A3 mov CX,word ptr SS:[BP+0x0C]
19FC:35A6 push DS
19FC:35A7 lds DX,word ptr SS:[BP+8]
19FC:35AA mov AH,0x3F
19FC:35AC int 0x21
19FC:35AE pop DS
19FC:35AF jae short 0x35B5
19FC:35B1 mov AH,9
19FC:35B3 jmp short 0x35FC
19FC:35B5 test byte ptr DS:[BX+0x5300],0x80
19FC:35BA je short 0x35FC
19FC:35BC and byte ptr DS:[BX+0x5300],0xFB
19FC:35C1 push SI
19FC:35C2 push DI
19FC:35C3 push DS
19FC:35C4 pop ES
19FC:35C5 mov DS,word ptr SS:[BP+0x0A]
19FC:35C8 cld
19FC:35C9 mov SI,DX
19FC:35CB mov DI,DX
19FC:35CD mov CX,AX
19FC:35CF jcxz short 0x35F8
19FC:35D1 mov AH,0x0D
19FC:35D3 cmp byte ptr DS:[SI],0x0A
19FC:35D6 jne short 0x35DE
19FC:35D8 or byte ptr ES:[BX+0x5300],4
19FC:35DE lods AL,byte ptr DS:[SI]
19FC:35DF cmp AL,AH
19FC:35E1 je short 0x35FF
19FC:35E3 cmp AL,0x1A
19FC:35E5 jne short 0x35EF
19FC:35E7 or byte ptr ES:[BX+0x5300],2
19FC:35ED jmp short 0x35F4
19FC:35EF mov byte ptr DS:[DI],AL
19FC:35F1 inc DI
19FC:35F2 loop 0x35DE
19FC:35F4 mov AX,DI
19FC:35F6 sub AX,DX
19FC:35F8 push ES
19FC:35F9 pop DS
19FC:35FA pop DI
19FC:35FB pop SI
19FC:35FC jmp near 0x32F5
19FC:35FF cmp CX,1
19FC:3602 je short 0x360B
19FC:3604 cmp byte ptr DS:[SI],0x0A
19FC:3607 je short 0x35F2
19FC:3609 jmp short 0x35EF
19FC:360B push ES
19FC:360C pop DS
19FC:360D test byte ptr DS:[BX+0x5300],0x40
19FC:3612 je short 0x362C
19FC:3614 mov AX,0x4400
19FC:3617 int 0x21
19FC:362C mov byte ptr SS:[BP-1],0
19FC:3630 lea DX,BP-1
19FC:3633 mov AH,0x3F
19FC:3635 int 0x21
19FC:37DA push BP
19FC:37DB mov BP,SP
19FC:37DD push SI
19FC:37DE push DI
19FC:37DF mov BX,0x5350
19FC:37E2 cmp word ptr DS:[BX],0
19FC:37E5 jne short 0x3810
19FC:37E7 push DS
19FC:37E8 pop ES
19FC:37E9 mov AX,5
19FC:37EC call near 0x3A3C
19FC:3810 mov CX,word ptr SS:[BP+6]
19FC:3813 mov AX,DS
19FC:3815 mov ES,AX
19FC:3817 call near 0x38FD
19FC:3835 push BP
19FC:3836 mov BP,SP
19FC:3838 sub SP,2
19FC:383B push SI
19FC:383C push DI
19FC:383D mov AX,word ptr SS:[BP+6]
19FC:3840 cmp AX,0xFFF1
19FC:3843 jae short 0x3863
19FC:3845 cmp word ptr DS:[0x535A],0
19FC:384A jne short 0x3854
19FC:384C call near 0x3874
19FC:384F je short 0x3863
19FC:3851 mov word ptr DS:[0x535A],AX
19FC:3854 call near 0x38E2
19FC:3857 jne short 0x386E
19FC:3859 call near 0x3874
19FC:3863 push word ptr SS:[BP+6]
19FC:3866 call far 19FC:37DA
19FC:386E pop DI
19FC:386F pop SI
19FC:3870 mov SP,BP
19FC:3872 pop BP
19FC:3873 ret far
19FC:3874 mov BX,0x00F0
19FC:3877 cmp word ptr SS:[BP+6],BX
19FC:387A jbe short 0x3883
19FC:387C mov BX,word ptr SS:[BP+6]
19FC:387F inc BX
19FC:3880 and BX,-2
19FC:3883 mov word ptr SS:[BP-2],BX
19FC:3886 xor AX,AX
19FC:3888 push DS
19FC:3889 push AX
19FC:388A push AX
19FC:388B lea CX,BX+0x0E
19FC:388E push CX
19FC:388F mov AL,2
19FC:3891 push AX
19FC:3892 call far 19FC:3A5E
19FC:3897 add SP,8
19FC:389A cmp DX,-1
19FC:389D je short 0x38E0
19FC:389F mov AX,DX
19FC:38A1 xchg DX,word ptr DS:[0x535C]
19FC:38A5 mov word ptr DS:[0x535E],AX
19FC:38A8 cmp AX,word ptr DS:[0x5362]
19FC:38AC jbe short 0x38B1
19FC:38AE mov word ptr DS:[0x5362],AX
19FC:38B1 or DX,DX
19FC:38B3 je short 0x38BA
19FC:38B5 mov DS,DX
19FC:38B7 mov word ptr DS:[8],AX
19FC:38BA mov BX,word ptr SS:[BP-2]
19FC:38BD mov DS,AX
19FC:38BF xor AX,AX
19FC:38C1 mov word ptr DS:[8],AX
19FC:38C4 dec AX
19FC:38C5 dec AX
19FC:38C6 mov word ptr DS:[BX+0x0C],AX
19FC:38C9 mov AX,0x000A
19FC:38CC mov word ptr DS:[0],AX
19FC:38CF mov word ptr DS:[2],AX
19FC:38D2 lea AX,BX+1
19FC:38D5 mov word ptr DS:[0x000A],AX
19FC:38D8 add AX,0x000D
19FC:38DB mov word ptr DS:[6],AX
19FC:38DE mov AX,DS
19FC:38E0 pop DS
19FC:38E1 ret near
19FC:38E2 mov AX,DS
19FC:38E4 mov ES,AX
19FC:38E6 mov CX,word ptr SS:[BP+6]
19FC:38E9 xor BX,BX
19FC:38EB mov DS,word ptr DS:[0x535E]
19FC:38EF call near 0x38FD
19FC:38F2 or DX,DX
19FC:38F4 mov CX,ES
19FC:38F6 mov DS,CX
19FC:38F8 ret near
19FC:38FA jmp near 0x39CB
19FC:38FD inc CX
19FC:38FE je short 0x38FA
19FC:3900 and CL,0xFE
19FC:3903 cmp CX,-18
19FC:3906 jae short 0x38FA
19FC:3908 mov SI,word ptr DS:[BX+2]
19FC:390B cld
19FC:390C lods AX,word ptr DS:[SI]
19FC:390D mov DI,SI
19FC:390F test AL,1
19FC:3911 je short 0x3955
19FC:3913 dec AX
19FC:3914 cmp AX,CX
19FC:3916 jae short 0x392D
19FC:3918 mov DX,AX
19FC:391A add SI,AX
19FC:391C lods AX,word ptr DS:[SI]
19FC:391D test AL,1
19FC:391F je short 0x3955
19FC:3921 add AX,DX
19FC:3923 add AX,2
19FC:3926 mov SI,DI
19FC:3928 mov word ptr DS:[SI-2],AX
19FC:392B jmp short 0x3913
19FC:392D mov DI,SI
19FC:392F je short 0x393D
19FC:3931 add DI,CX
19FC:3933 mov word ptr DS:[SI-2],CX
19FC:3936 sub AX,CX
19FC:3938 dec AX
19FC:3939 mov word ptr DS:[DI],AX
19FC:393B jmp short 0x3942
19FC:393D add DI,CX
19FC:393F dec byte ptr DS:[SI-2]
19FC:3942 mov AX,SI
19FC:3944 mov DX,DS
19FC:3946 mov CX,SS
19FC:3948 cmp DX,CX
19FC:394A je short 0x3951
19FC:394C mov word ptr ES:[0x535E],DS
19FC:3951 mov word ptr DS:[BX+2],DI
19FC:3954 ret near
19FC:3955 mov byte ptr ES:[0x5364],2
19FC:395B cmp AX,0xFFFE
19FC:395E je short 0x3985
19FC:3960 mov DI,SI
19FC:3962 add SI,AX
19FC:3964 lods AX,word ptr DS:[SI]
19FC:3965 test AL,1
19FC:3967 je short 0x395B
19FC:3969 mov DI,SI
19FC:396B dec AX
19FC:396C cmp AX,CX
19FC:396E jae short 0x392D
19FC:3970 mov DX,AX
19FC:3972 add SI,AX
19FC:3974 lods AX,word ptr DS:[SI]
19FC:3975 test AL,1
19FC:3977 je short 0x395B
19FC:3979 add AX,DX
19FC:397B add AX,2
19FC:397E mov SI,DI
19FC:3980 mov word ptr DS:[SI-2],AX
19FC:3983 jmp short 0x396B
19FC:3985 mov AX,word ptr DS:[BX+8]
19FC:3988 or AX,AX
19FC:398A je short 0x3990
19FC:398C mov DS,AX
19FC:398E jmp short 0x39A4
19FC:3990 dec byte ptr ES:[0x5364]
19FC:3995 je short 0x39A8
19FC:3997 mov AX,DS
19FC:3999 mov DI,SS
19FC:399B cmp AX,DI
19FC:399D je short 0x39A4
19FC:399F mov DS,word ptr ES:[0x535A]
19FC:39A4 mov SI,word ptr DS:[BX]
19FC:39A6 jmp short 0x3964
19FC:39A8 mov SI,word ptr DS:[BX+6]
19FC:39AB xor AX,AX
19FC:39AD call near 0x3A1A
19FC:39B0 cmp AX,SI
19FC:39B2 je short 0x39C1
19FC:39B4 and AL,1
19FC:39B6 inc AX
19FC:39B7 inc AX
19FC:39B8 cbw
19FC:39B9 call near 0x3A1A
19FC:39C1 call near 0x39E0
19FC:39C4 je short 0x39CB
19FC:39C6 xchg SI,AX
19FC:39C7 dec SI
19FC:39C8 dec SI
19FC:39C9 jmp short 0x3964
19FC:39CB mov AX,DS
19FC:39CD mov CX,SS
19FC:39CF cmp AX,CX
19FC:39D1 je short 0x39D7
19FC:39D3 mov word ptr ES:[0x535E],AX
19FC:39D7 mov AX,word ptr DS:[BX]
19FC:39D9 mov word ptr DS:[BX+2],AX
19FC:39DC xor AX,AX
19FC:39DE cwd
19FC:39DF ret near
19FC:39E0 push CX
19FC:39E1 mov AX,word ptr DS:[DI-2]
19FC:39E4 test AL,1
19FC:39E6 je short 0x39EB
19FC:39E8 sub CX,AX
19FC:39EA dec CX
19FC:39EB inc CX
19FC:39EC inc CX
19FC:39ED mov DX,0x7FFF
19FC:39F0 cmp DX,word ptr ES:[0x5360]
19FC:39F5 jbe short 0x39FB
19FC:39F7 shr DX,1
19FC:39F9 jne short 0x39F0
19FC:39FB mov AX,CX
19FC:39FD add AX,SI
19FC:39FF jb short 0x3A16
19FC:3A01 add AX,DX
19FC:3A03 jb short 0x3A12
19FC:3A05 not DX
19FC:3A07 and AX,DX
19FC:3A09 sub AX,SI
19FC:3A0B call near 0x3A1A
19FC:3A0E jne short 0x3A18
19FC:3A10 not DX
19FC:3A12 shr DX,1
19FC:3A14 jne short 0x39FB
19FC:3A16 xor AX,AX
19FC:3A18 pop CX
19FC:3A19 ret near
19FC:3A1A push DX
19FC:3A1B push CX
19FC:3A1C call near 0x3A3C
19FC:3A1F je short 0x3A39
19FC:3A21 push DI
19FC:3A22 mov DI,SI
19FC:3A24 mov SI,AX
19FC:3A26 add SI,DX
19FC:3A28 mov word ptr DS:[SI-2],0xFFFE
19FC:3A2D mov word ptr DS:[BX+6],SI
19FC:3A30 mov DX,SI
19FC:3A32 sub DX,DI
19FC:3A34 dec DX
19FC:3A35 mov word ptr DS:[DI-2],DX
19FC:3A38 pop AX
19FC:3A39 pop CX
19FC:3A3A pop DX
19FC:3A3B ret near
19FC:3A3C push BX
19FC:3A3D push AX
19FC:3A3E xor DX,DX
19FC:3A40 push DS
19FC:3A41 push DX
19FC:3A42 push DX
19FC:3A43 push AX
19FC:3A44 mov AX,1
19FC:3A47 push AX
19FC:3A48 push ES
19FC:3A49 pop DS
19FC:3A4A call far 19FC:3A5E
19FC:3A4F add SP,8
19FC:3A52 cmp DX,-1
19FC:3A55 pop DS
19FC:3A56 pop DX
19FC:3A57 pop BX
19FC:3A58 je short 0x3A5C
19FC:3A5A or DX,DX
19FC:3A5C ret near
19FC:3A5E push BP
19FC:3A5F mov BP,SP
19FC:3A61 push SI
19FC:3A62 push DI
19FC:3A63 push ES
19FC:3A64 cmp word ptr SS:[BP+0x0A],0
19FC:3A68 jne short 0x3AA2
19FC:3A6A mov DI,0x5286
19FC:3A6D mov DX,word ptr SS:[BP+8]
19FC:3A70 mov AX,word ptr SS:[BP+6]
19FC:3A73 dec AX
19FC:3A74 jne short 0x3A7D
19FC:3A76 call near 0x3ACC
19FC:3A79 jb short 0x3AA2
19FC:3A7B jmp short 0x3AC5
19FC:3A7D mov SI,word ptr DS:[0x52D6]
19FC:3A81 dec AX
19FC:3A82 je short 0x3A95
19FC:3A84 cmp SI,DI
19FC:3A86 je short 0x3A95
19FC:3A88 mov AX,word ptr DS:[SI+2]
19FC:3A8B mov word ptr SS:[BP+0x0E],AX
19FC:3A8E push SI
19FC:3A8F call near 0x3ACC
19FC:3A95 add SI,4
19FC:3A98 cmp SI,0x52D6
19FC:3A9C jae short 0x3AA2
19FC:3A9E or DX,DX
19FC:3AA0 jne short 0x3AA8
19FC:3AA2 mov AX,0xFFFF
19FC:3AA5 cwd
19FC:3AA6 jmp short 0x3AC5
19FC:3AA8 mov BX,DX
19FC:3AAA add BX,0x000F
19FC:3AAD rcr BX,1
19FC:3AAF mov CL,3
19FC:3AB1 shr BX,CL
19FC:3AB3 mov AH,0x48
19FC:3AB5 int 0x21
19FC:3AB7 jb short 0x3AA2
19FC:3AB9 xchg DX,AX
19FC:3ABA mov word ptr DS:[SI],AX
19FC:3ABC mov word ptr DS:[SI+2],DX
19FC:3ABF mov word ptr DS:[0x52D6],SI
19FC:3AC3 xor AX,AX
19FC:3AC5 pop ES
19FC:3AC6 pop DI
19FC:3AC7 pop SI
19FC:3AC8 mov SP,BP
19FC:3ACA pop BP
19FC:3ACB ret far
19FC:3ACC mov CX,word ptr SS:[BP+0x0E]
19FC:3ACF mov SI,DI
19FC:3AD1 cmp word ptr DS:[SI+2],CX
19FC:3AD4 je short 0x3AE2
19FC:3AD6 add SI,4
19FC:3AD9 cmp SI,0x52D6
19FC:3ADD jne short 0x3AD1
19FC:3ADF stc
19FC:3AE0 jmp short 0x3B21
19FC:3AE2 mov BX,DX
19FC:3AE4 add BX,word ptr DS:[SI]
19FC:3AE6 jb short 0x3B21
19FC:3AE8 mov DX,BX
19FC:3AEA mov ES,CX
19FC:3AEC cmp SI,DI
19FC:3AEE jne short 0x3AF6
19FC:3AF0 cmp word ptr DS:[0x5280],BX
19FC:3AF4 jae short 0x3B1C
19FC:3AF6 add BX,0x000F
19FC:3AF9 rcr BX,1
19FC:3AFB shr BX,1
19FC:3AFD shr BX,1
19FC:3AFF shr BX,1
19FC:3B01 cmp SI,DI
19FC:3B03 jne short 0x3B0E
19FC:3B05 add BX,CX
19FC:3B07 mov AX,word ptr DS:[0x52F7]
19FC:3B0A sub BX,AX
19FC:3B0C mov ES,AX
19FC:3B0E mov AH,0x4A
19FC:3B10 int 0x21
19FC:3B12 jb short 0x3B21
19FC:3B14 cmp SI,DI
19FC:3B16 jne short 0x3B1C
19FC:3B18 mov word ptr DS:[0x5280],DX
19FC:3B1C xchg DX,AX
19FC:3B1D xchg AX,word ptr DS:[SI]
19FC:3B1F mov DX,CX
19FC:3B21 ret near
19FC:3B22 push BP
19FC:3B23 mov BP,SP
19FC:3B25 mov DX,DI
19FC:3B27 mov BX,SI
19FC:3B29 push DS
19FC:3B2A les DI,word ptr SS:[BP+6]
19FC:3B2D xor AX,AX
19FC:3B2F mov CX,0xFFFF
19FC:3B32 repne scas AL,byte ptr ES:[DI]
19FC:3B34 lea SI,DI-1
19FC:3B37 les DI,word ptr SS:[BP+0x0A]
19FC:3B3A mov CX,0xFFFF
19FC:3B3D repne scas AL,byte ptr ES:[DI]
19FC:3B3F not CX
19FC:3B41 sub DI,CX
19FC:3B43 mov AX,ES
19FC:3B45 mov DS,AX
19FC:3B47 mov ES,word ptr SS:[BP+8]
19FC:3B4A xchg DI,SI
19FC:3B4C mov AX,word ptr SS:[BP+6]
19FC:3B4F test SI,1
19FC:3B53 je short 0x3B57
19FC:3B55 movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:3B56 dec CX
19FC:3B57 shr CX,1
19FC:3B59 rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:3B5B adc CX,CX
19FC:3B5D rep movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:3B5F mov SI,BX
19FC:3B61 mov DI,DX
19FC:3B63 pop DS
19FC:3B64 mov DX,ES
19FC:3B66 pop BP
19FC:3B67 ret far
19FC:3B68 push BP
19FC:3B69 mov BP,SP
19FC:3B6B mov DX,DI
19FC:3B6D mov BX,SI
19FC:3B6F push DS
19FC:3B70 lds SI,word ptr SS:[BP+0x0A]
19FC:3B73 mov DI,SI
19FC:3B75 mov AX,DS
19FC:3B77 mov ES,AX
19FC:3B79 xor AX,AX
19FC:3B7B mov CX,0xFFFF
19FC:3B7E repne scas AL,byte ptr ES:[DI]
19FC:3B80 not CX
19FC:3B82 les DI,word ptr SS:[BP+6]
19FC:3B85 mov AX,DI
19FC:3B87 test AL,1
19FC:3B89 je short 0x3B8D
19FC:3B8B movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:3B8C dec CX
19FC:3B8D shr CX,1
19FC:3B8F rep movs word ptr ES:[DI],word ptr DS:[SI]
19FC:3B91 adc CX,CX
19FC:3B93 rep movs byte ptr ES:[DI],byte ptr DS:[SI]
19FC:3B95 mov SI,BX
19FC:3B97 mov DI,DX
19FC:3B99 pop DS
19FC:3B9A mov DX,ES
19FC:3B9C pop BP
19FC:3B9D ret far
19FC:3B9E push BP
19FC:3B9F mov BP,SP
19FC:3BA1 mov DX,DI
19FC:3BA3 les DI,word ptr SS:[BP+6]
19FC:3BA6 xor AX,AX
19FC:3BA8 mov CX,0xFFFF
19FC:3BAB repne scas AL,byte ptr ES:[DI]
19FC:3BAD not CX
19FC:3BAF dec CX
19FC:3BB0 xchg CX,AX
19FC:3BB1 mov DI,DX
19FC:3BB3 pop BP
19FC:3BB4 ret far
19FC:3BB6 push BP
19FC:3BB7 mov BP,SP
19FC:3BB9 push SI
19FC:3BBA push DI
19FC:3BBB mov BL,1
19FC:3BBD mov CX,word ptr SS:[BP+0x0C]
19FC:3BC0 mov AX,word ptr SS:[BP+6]
19FC:3BC3 xor DX,DX
19FC:3BC5 cmp CX,0x000A
19FC:3BC8 jne short 0x3BCB
19FC:3BCA cwd
19FC:3BCB push DS
19FC:3BCC lds DI,word ptr SS:[BP+8]
19FC:3BCF jmp near 0x3C15
19FC:3BD2 push BP
19FC:3BD3 mov BP,SP
19FC:3BD5 push SI
19FC:3BD6 push DI
19FC:3BD7 mov BL,1
19FC:3BD9 jmp near 0x3C08
19FC:3BDC mov AX,word ptr DS:[0x5366]
19FC:3BDF or AH,AH
19FC:3BE1 mov AL,0xFF
19FC:3BE3 je short 0x3BEB
19FC:3BE5 mov AH,0x0B
19FC:3BE7 int 0x21
19FC:3BE9 mov AH,0
19FC:3BEB ret far
19FC:3C08 mov CX,word ptr SS:[BP+0x0E]
19FC:3C0B mov AX,word ptr SS:[BP+6]
19FC:3C0E mov DX,word ptr SS:[BP+8]
19FC:3C11 push DS
19FC:3C12 lds DI,word ptr SS:[BP+0x0A]
19FC:3C15 push DI
19FC:3C16 push DS
19FC:3C17 pop ES
19FC:3C18 cld
19FC:3C19 xchg BX,AX
19FC:3C1A or AL,AL
19FC:3C1C je short 0x3C31
19FC:3C1E cmp CX,0x000A
19FC:3C21 jne short 0x3C31
19FC:3C23 or DX,DX
19FC:3C25 jns short 0x3C31
19FC:3C27 mov AL,0x2D
19FC:3C29 stos byte ptr ES:[DI],AL
19FC:3C2A neg BX
19FC:3C2C adc DX,0
19FC:3C2F neg DX
19FC:3C31 mov SI,DI
19FC:3C33 xchg DX,AX
19FC:3C34 xor DX,DX
19FC:3C36 or AX,AX
19FC:3C38 je short 0x3C3C
19FC:3C3A div CX
19FC:3C3C xchg BX,AX
19FC:3C3D div CX
19FC:3C3F xchg DX,AX
19FC:3C40 xchg DX,BX
19FC:3C42 add AL,0x30
19FC:3C44 cmp AL,0x39
19FC:3C46 jbe short 0x3C4A
19FC:3C48 add AL,0x27
19FC:3C4A stos byte ptr ES:[DI],AL
19FC:3C4B mov AX,DX
19FC:3C4D or AX,BX
19FC:3C4F jne short 0x3C33
19FC:3C51 mov byte ptr DS:[DI],AL
19FC:3C53 dec DI
19FC:3C54 lods AL,byte ptr DS:[SI]
19FC:3C55 xchg AL,byte ptr DS:[DI]
19FC:3C57 mov byte ptr DS:[SI-1],AL
19FC:3C5A lea AX,SI+1
19FC:3C5D cmp AX,DI
19FC:3C5F jb short 0x3C53
19FC:3C61 mov DX,DS
19FC:3C63 pop AX
19FC:3C64 pop DS
19FC:3C65 pop DI
19FC:3C66 pop SI
19FC:3C67 mov SP,BP
19FC:3C69 pop BP
19FC:3C6A ret far
19FC:3C6C push BP
19FC:3C6D mov BP,SP
19FC:3C6F cmp word ptr SS:[BP+6],0
19FC:3C73 jl short 0x3C7A
19FC:3C75 mov AX,word ptr SS:[BP+6]
19FC:3C78 jmp short 0x3C7F
19FC:3C7A mov AX,word ptr SS:[BP+6]
19FC:3C7D neg AX
19FC:3C7F pop BP
19FC:3C80 ret far
19FC:3C82 push BP
19FC:3C83 mov BP,SP
19FC:3C85 les DX,word ptr SS:[BP+6]
19FC:3C88 mov word ptr DS:[0x536A],ES
19FC:3C8C mov word ptr DS:[0x5368],DX
19FC:3C90 push DS
19FC:3C91 mov AX,CS
19FC:3C93 mov DS,AX
19FC:3C95 mov DX,0x3CA5
19FC:3C98 mov AL,0x24
19FC:3C9A mov AH,0x25
19FC:3C9C int 0x21
19FC:3C9E pop DS
19FC:3C9F xor AX,AX
19FC:3CA1 mov SP,BP
19FC:3CA3 pop BP
19FC:3CA4 ret far
19FC:3D1C push BP
19FC:3D1D mov BP,SP
19FC:3D1F les BX,word ptr SS:[BP+6]
19FC:3D22 push word ptr SS:[BP+0x0C]
19FC:3D25 push word ptr SS:[BP+0x0A]
19FC:3D28 push word ptr ES:[BX+2]
19FC:3D2C push word ptr ES:[BX]
19FC:3D2F call far 19FC:3E2E
19FC:3D34 les BX,word ptr SS:[BP+6]
19FC:3D37 mov word ptr ES:[BX],AX
19FC:3D3A mov word ptr ES:[BX+2],DX
19FC:3D3E mov SP,BP
19FC:3D40 pop BP
19FC:3D41 ret far 8
19FC:3D44 push BP
19FC:3D45 mov BP,SP
19FC:3D47 les BX,word ptr SS:[BP+6]
19FC:3D4A push word ptr SS:[BP+0x0C]
19FC:3D4D push word ptr SS:[BP+0x0A]
19FC:3D50 push word ptr ES:[BX+2]
19FC:3D54 push word ptr ES:[BX]
19FC:3D57 call far 19FC:3E62
19FC:3D5C les BX,word ptr SS:[BP+6]
19FC:3D5F mov word ptr ES:[BX+2],DX
19FC:3D63 mov word ptr ES:[BX],AX
19FC:3D66 mov SP,BP
19FC:3D68 pop BP
19FC:3D69 ret far 8
19FC:3D6C push BP
19FC:3D6D mov BP,SP
19FC:3D6F les BX,word ptr SS:[BP+6]
19FC:3D72 mov AX,word ptr ES:[BX]
19FC:3D75 mov DX,word ptr ES:[BX+2]
19FC:3D79 mov CX,word ptr SS:[BP+0x0A]
19FC:3D7C call far 19FC:3EC4
19FC:3D92 push BP
19FC:3D93 mov BP,SP
19FC:3D95 push DI
19FC:3D96 push SI
19FC:3D97 push BX
19FC:3D98 xor DI,DI
19FC:3D9A mov AX,word ptr SS:[BP+8]
19FC:3D9D or AX,AX
19FC:3D9F jge short 0x3DB2
19FC:3DA1 inc DI
19FC:3DA2 mov DX,word ptr SS:[BP+6]
19FC:3DA5 neg AX
19FC:3DA7 neg DX
19FC:3DA9 sbb AX,0
19FC:3DAC mov word ptr SS:[BP+8],AX
19FC:3DAF mov word ptr SS:[BP+6],DX
19FC:3DB2 mov AX,word ptr SS:[BP+0x0C]
19FC:3DB5 or AX,AX
19FC:3DB7 jge short 0x3DCA
19FC:3DB9 inc DI
19FC:3DBA mov DX,word ptr SS:[BP+0x0A]
19FC:3DBD neg AX
19FC:3DBF neg DX
19FC:3DC1 sbb AX,0
19FC:3DC4 mov word ptr SS:[BP+0x0C],AX
19FC:3DC7 mov word ptr SS:[BP+0x0A],DX
19FC:3DCA or AX,AX
19FC:3DCC jne short 0x3DE3
19FC:3DCE mov CX,word ptr SS:[BP+0x0A]
19FC:3DD1 mov AX,word ptr SS:[BP+8]
19FC:3DD4 xor DX,DX
19FC:3DD6 div CX
19FC:3DD8 mov BX,AX
19FC:3DDA mov AX,word ptr SS:[BP+6]
19FC:3DDD div CX
19FC:3DDF mov DX,BX
19FC:3DE1 jmp short 0x3E1B
19FC:3DE3 mov BX,AX
19FC:3DE5 mov CX,word ptr SS:[BP+0x0A]
19FC:3DE8 mov DX,word ptr SS:[BP+8]
19FC:3DEB mov AX,word ptr SS:[BP+6]
19FC:3DEE shr BX,1
19FC:3DF0 rcr CX,1
19FC:3DF2 shr DX,1
19FC:3DF4 rcr AX,1
19FC:3DF6 or BX,BX
19FC:3DF8 jne short 0x3DEE
19FC:3DFA div CX
19FC:3DFC mov SI,AX
19FC:3DFE mul word ptr SS:[BP+0x0C]
19FC:3E01 xchg CX,AX
19FC:3E02 mov AX,word ptr SS:[BP+0x0A]
19FC:3E05 mul SI
19FC:3E07 add DX,CX
19FC:3E09 jb short 0x3E17
19FC:3E0B cmp DX,word ptr SS:[BP+8]
19FC:3E0E ja short 0x3E17
19FC:3E10 jb short 0x3E18
19FC:3E12 cmp AX,word ptr SS:[BP+6]
19FC:3E15 jbe short 0x3E18
19FC:3E17 dec SI
19FC:3E18 xor DX,DX
19FC:3E1A xchg SI,AX
19FC:3E1B dec DI
19FC:3E1C jne short 0x3E25
19FC:3E1E neg DX
19FC:3E20 neg AX
19FC:3E22 sbb DX,0
19FC:3E25 pop BX
19FC:3E26 pop SI
19FC:3E27 pop DI
19FC:3E28 mov SP,BP
19FC:3E2A pop BP
19FC:3E2B ret far 8
19FC:3E2E push BP
19FC:3E2F mov BP,SP
19FC:3E31 mov AX,word ptr SS:[BP+8]
19FC:3E34 mov BX,word ptr SS:[BP+0x0C]
19FC:3E37 or BX,AX
19FC:3E39 mov BX,word ptr SS:[BP+0x0A]
19FC:3E3C jne short 0x3E49
19FC:3E3E mov AX,word ptr SS:[BP+6]
19FC:3E41 mul BX
19FC:3E43 mov SP,BP
19FC:3E45 pop BP
19FC:3E46 ret far 8
19FC:3E49 mul BX
19FC:3E4B mov CX,AX
19FC:3E4D mov AX,word ptr SS:[BP+6]
19FC:3E50 mul word ptr SS:[BP+0x0C]
19FC:3E53 add CX,AX
19FC:3E55 mov AX,word ptr SS:[BP+6]
19FC:3E58 mul BX
19FC:3E5A add DX,CX
19FC:3E5C mov SP,BP
19FC:3E5E pop BP
19FC:3E5F ret far 8
19FC:3E62 push BP
19FC:3E63 mov BP,SP
19FC:3E65 push BX
19FC:3E66 push SI
19FC:3E67 mov AX,word ptr SS:[BP+0x0C]
19FC:3E6A or AX,AX
19FC:3E6C jne short 0x3E83
19FC:3E6E mov CX,word ptr SS:[BP+0x0A]
19FC:3E71 mov AX,word ptr SS:[BP+8]
19FC:3E74 xor DX,DX
19FC:3E76 div CX
19FC:3E78 mov BX,AX
19FC:3E7A mov AX,word ptr SS:[BP+6]
19FC:3E7D div CX
19FC:3E7F mov DX,BX
19FC:3E81 jmp short 0x3EBB
19FC:3E83 mov CX,AX
19FC:3E85 mov BX,word ptr SS:[BP+0x0A]
19FC:3E88 mov DX,word ptr SS:[BP+8]
19FC:3E8B mov AX,word ptr SS:[BP+6]
19FC:3E8E shr CX,1
19FC:3E90 rcr BX,1
19FC:3E92 shr DX,1
19FC:3E94 rcr AX,1
19FC:3E96 or CX,CX
19FC:3E98 jne short 0x3E8E
19FC:3E9A div BX
19FC:3E9C mov SI,AX
19FC:3E9E mul word ptr SS:[BP+0x0C]
19FC:3EA1 xchg CX,AX
19FC:3EA2 mov AX,word ptr SS:[BP+0x0A]
19FC:3EA5 mul SI
19FC:3EA7 add DX,CX
19FC:3EA9 jb short 0x3EB7
19FC:3EAB cmp DX,word ptr SS:[BP+8]
19FC:3EAE ja short 0x3EB7
19FC:3EB0 jb short 0x3EB8
19FC:3EB2 cmp AX,word ptr SS:[BP+6]
19FC:3EB5 jbe short 0x3EB8
19FC:3EB7 dec SI
19FC:3EB8 xor DX,DX
19FC:3EBA xchg SI,AX
19FC:3EBB pop SI
19FC:3EBC pop BX
19FC:3EBD mov SP,BP
19FC:3EBF pop BP
19FC:3EC0 ret far 8
19FC:3EC4 xor CH,CH
19FC:3EC6 jcxz short 0x3ECE
19FC:3EC8 shr DX,1
19FC:3ECA rcr AX,1
19FC:3ECC loop 0x3EC8
19FC:3ECE ret far
F000:0000 callback 0x0010
F000:0004 iret
F000:0005 iret
F000:0006 callback 8
F000:000A int 0x1C
F000:000C callback 0x0101
F000:0010 iret
F000:0011 callback 9
F000:0015 iret
F000:002F cmp AH,0
F000:0032 je short 0x003E
F000:0034 cmp AH,0x10
F000:0037 je short 0x003E
F000:0039 callback 0x0016
F000:003D iret
F000:003E callback 0x0102
F000:0042 jne short 0x0048
F000:0044 int 9
F000:0046 jmp short 0x003E
F000:0048 callback 0x0103
F000:004C iret
F000:0057 callback 0x0070
F000:005B iret
F000:005D call far F000:00E3
F000:0062 callback 0x0074
F000:0066 iret
F000:0067 callback 0x0104
F000:006B iret
F000:006C callback 0x0105
F000:0070 iret
F000:0071 callback 0x0106
F000:0075 iret
F000:0076 callback 0x0107
F000:007A iret
F000:007B callback 0x0108
F000:007F iret
F000:0080 callback 0x0109
F000:0084 iret
F000:0090 cmp AH,7
F000:0093 je short 0x00A4
F000:0095 cmp AH,8
F000:0098 je short 0x00A4
F000:009A cmp AH,0x0A
F000:009D je short 0x00A4
F000:009F callback 0x0021
F000:00A3 iret
F000:00A4 sti
F000:00E2 ret far
F000:00E3 callback 0x010C
F000:00E7 call far F000:00E2
F000:00EC callback 0x010D
F000:00F0 ret far
