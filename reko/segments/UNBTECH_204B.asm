;;; Segment 204B (204B:0000)
204B:0000 57 26 39 36 A2 39 7F BC                         W&96.9..        

l1FC5_0868:
	pop	si
	mov	sp,bp
	pop	bp
	retf
1FC5:086D                                        90 00 00              ...
1FC5:0870 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ................
1FC5:0880 2E FF 1E 16 00 50 2E A1 0E 00 3C 00 75 0E 2E A1 .....P....<.u...
1FC5:0890 10 00 2E A3 0E 00 58 2E FF 2E 12 00 FE C8 2E A3 ......X.........
1FC5:08A0 0E 00 B0 20 E6 20 58 CF                         ... . X.        

;; fn204B_0048: 204B:0048
;;   Called from:
;;     0800:4813 (in fn0800_476D)
fn204B_0048 proc
	push	ds
	mov	ax,0h
	mov	ds,ax
	mov	ax,[0020h]
	mov	cs:[0012h],ax
	mov	ax,[0022h]
	mov	cs:[0014h],ax
	mov	word ptr cs:[0010h],10h
	mov	word ptr cs:[000Eh],0h
	mov	ax,186h
	mov	cs:[0016h],ax
	push	cs
	pop	ax
	mov	cs:[0018h],ax
	mov	dx,20h
	push	cs
	pop	ds
	mov	ah,25h
	mov	al,8h
	int	21h
	mov	al,36h
	out	43h,al
	mov	ax,0FFFh
	out	40h,al
	mov	al,ah
	out	40h,al
	pop	ds
	retf

;; fn204B_0091: 204B:0091
;;   Called from:
;;     0800:48AE (in fn0800_476D)
fn204B_0091 proc
	push	ds
	mov	dx,cs:[0012h]
	mov	ax,cs:[0014h]
	push	ax
	pop	ds
	mov	ah,25h
	mov	al,8h
	int	21h
	mov	al,36h
	out	43h,al
	mov	ax,0FFFFh
	out	40h,al
	mov	al,ah
	out	40h,al
	pop	ds
	retf
204B:00B2       50 8A C1 E6 42 8A C5 E6 42 58 C3            P...B...BX.   

;; fn204B_00BD: 204B:00BD
;;   Called from:
;;     204B:02F3 (in fn204B_02E4)
;;     204B:0315 (in fn204B_0306)
fn204B_00BD proc
	push	ax
	in	al,61h
	or	al,3h
	out	61h,al
	pop	ax
	ret
204B:00C6                   50 E4 61 24 FC E6 61 58 C3 52       P.a$..aX.R
204B:00D0 50 BA 12 00 B8 DE 34 F7 F1 8B C8 58 5A C3 52 50 P.....4....XZ.RP
204B:00E0 2E A1 1C 00 2E 2B 06 1A 00 F7 E1 8B CA 2E 03 0E .....+..........
204B:00F0 1A 00 58 5A C3 2E 8B 0E 1E 00 81 C1 48 92 D1 C9 ..XZ........H...
204B:0100 D1 C9 D1 C9 2E 89 0E 1E 00 C3 2E 89 1E 1A 00 2E ................
204B:0110 89 0E 1C 00 E8 DE FF E8 C4 FF E8 B2 FF E8 92 FF ................
204B:0120 C3 5A 10 53 11 5B 12 72 13 9A 14 D4 15 20 17 80 .Z.S.[.r..... ..
204B:0130 18 F5 19 80 1B 23 1D DE 1E 51 53 50 B4 00 B1 0C .....#...QSP....
204B:0140 F6 F1 8A D0 8A C4 98 D1 E0 8B D8 2E 8B 8F 21 01 ..............!.
204B:0150 E8 7C FF 87 CA F6 D9 80 C1 08 D3 E2 58 5B 59 C3 .|..........X[Y.
204B:0160 50 B8 86 01 2E A3 16 00 E8 5B FF B0 9F E6 C0 B0 P........[......
204B:0170 BF E6 C0 B0 DF E6 C0 58 C3 50 B8 86 01 2E A3 16 .......X.P......
204B:0180 00 E8 42 FF 58 C3 CB 52 51 A8 80 74 05 B9 0E 00 ..B.X..RQ..t....
204B:0190 EB 05 E8 A4 FF 8B CA E8 18 FF 59 5A C3 CB AC 06 ..........YZ....
204B:01A0 4C 06 F0 05 98 05 4C 05 FE 04 B6 04 74 04 32 04 L.....L.....t.2.
204B:01B0 F6 03 BA 03 84 03 56 03 52 51 53 50 B4 00 B1 0C ......V.RQSP....
204B:01C0 F6 F1 8A C8 8A C4 98 D1 E0 8B D8 2E 8B 97 9E 01 ................
204B:01D0 80 E9 02 D3 FA 58 B0 80 80 FC 00 74 09 B0 A0 80 .....X.....t....
204B:01E0 FC 01 74 02 B0 C0 8A E2 80 E4 0F 0A C4 E6 C0 B1 ..t.............
204B:01F0 04 D3 EA 80 E2 3F 8A C2 E6 C0 5B 59 5A C3 8B 46 .....?....[YZ..F
204B:0200 0A E8 B4 FF C3 00 00 00 00 00 00 8B 46 08 2E A3 ............F...
204B:0210 05 02 8B 46 0A 2E A3 07 02 8B 46 0C 2E A2 0A 02 ...F......F.....
204B:0220 2E C6 06 09 02 01 B0 93 E6 C0 B0 B3 E6 C0 B0 D3 ................
204B:0230 E6 C0 C3 8B 46 08 2E A3 05 02 8B 46 0A 2E A3 07 ....F......F....
204B:0240 02 8B 46 0C 2E A2 0A 02 2E C6 06 09 02 01 C3 2E ..F.............
204B:0250 FE 0E 09 02 2E 80 3E 09 02 00 75 34 50 2E A0 0A ......>...u4P...
204B:0260 02 2E A2 09 02 1E 56 2E C5 36 05 02 32 E4 AC 3C ......V..6..2..<
204B:0270 00 74 1E 32 E4 E8 40 FF AC E8 0B FF AC B4 01 E8 .t.2..@.........
204B:0280 36 FF AC B4 02 E8 30 FF 2E 89 36 05 02 5E 1F 58 6.....0...6..^.X
204B:0290 CB 5E 1F 58 E8 C9 FE CB 2E FE 0E 09 02 2E 80 3E .^.X...........>
204B:02A0 09 02 00 75 37 50 2E A0 0A 02 2E A2 09 02 1E 56 ...u7P.........V
204B:02B0 2E C5 36 05 02 AC 3C 00 75 05 AC 3C 00 74 1E 2E ..6...<.u..<.t..
204B:02C0 89 36 05 02 5E 1F 52 51 A8 80 74 05 B9 0E 00 EB .6..^.RQ..t.....
204B:02D0 05 E8 65 FE 8B CA E8 D9 FD 59 5A 58 CB 5E 1F 58 ..e......YZX.^.X
204B:02E0 E8 96 FE CB                                     ....            

;; fn204B_02E4: 204B:02E4
;;   Called from:
;;     0800:4827 (in fn0800_476D)
;;     0800:483F (in fn0800_476D)
;;     0800:489C (in fn0800_476D)
fn204B_02E4 proc
	push	bp
	mov	bp,sp
	mov	bx,[bp+6h]
	cmp	bx,0Dh
	jge	0304h

l204B_02EF:
	add	bx,bx
	add	bx,bx
	call	00BDh
	call	word ptr cs:[bx+328h]
	mov	ax,cs:[bx+32Ah]
	mov	cs:[0016h],ax

l204B_0304:
	pop	bp
	retf

;; fn204B_0306: 204B:0306
;;   Called from:
;;     0800:4849 (in fn0800_476D)
;;     0800:4861 (in fn0800_476D)
;;     0800:48A6 (in fn0800_476D)
fn204B_0306 proc
	push	bp
	mov	bp,sp
	mov	bx,[bp+6h]
	cmp	bx,0Dh
	jge	0326h

l204B_0311:
	add	bx,bx
	add	bx,bx
	call	00BDh
	call	word ptr cs:[bx+332h]
	mov	ax,cs:[bx+334h]
	mov	cs:[0016h],ax

l204B_0326:
	pop	bp
	retf
204B:0328                         60 01 86 01 0B 02 4F 02         `.....O.
204B:0330 00 00 79 01 86 01 33 02 98 02 00 00             ..y...3.....    

;; fn204B_033C: 204B:033C
;;   Called from:
;;     0800:4881 (in fn0800_476D)
fn204B_033C proc
	mov	ax,cs:[0016h]
