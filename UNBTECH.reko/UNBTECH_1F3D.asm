;;; Segment 1F3D (1F3D:0000)
1F3D:0000 0D                                              .               

l1E56_0E71:
	mov	ax,[bp+6h]
	pop	bp
	retf

;; fn1F3D_0006: 1F3D:0006
;;   Called from:
;;     0800:01F8 (in fn0800_0000)
;;     0800:1C00 (in fn0800_1AFD)
;;     0800:459D (in fn0800_3FAE)
;;     0800:4A41 (in fn0800_48B7)
;;     0800:4A89 (in fn0800_48B7)
;;     0D27:01F1 (in main)
;;     0DAB:0919 (in fn0DAB_04F9)
;;     0DAB:2270 (in fn0DAB_1AFE)
;;     0FDC:0949 (in fn0FDC_0629)
;;     11B8:1745 (in fn11B8_16B2)
;;     135D:0175 (in fn135D_0004)
;;     135D:0D30 (in fn135D_0AB6)
;;     1631:1DE8 (in fn1631_1DCC)
;;     1AE8:1503 (in fn1AE8_12C7)
;;     1AE8:1AC2 (in fn1AE8_12C7)
;;     1CD3:0129 (in fn1CD3_0004)
;;     1F3D:02BA (in fn1F3D_0259)
;;     1F3D:02FE (in fn1F3D_0259)
;;     1F3D:0875 (in fn1F3D_086A)
fn1F3D_0006 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	jmp	0023h

l1F3D_0012:
	mov	es,[56EEh]
	push	word ptr es:[32ACh]
	call	far 207Fh:0B40h
	add	sp,2h

l1F3D_0023:
	mov	ax,[bp+6h]
	dec	word ptr [bp+6h]
	or	ax,ax
	jnz	0012h

l1F3D_002D:
	pop	bp
	retf

;; fn1F3D_002F: 1F3D:002F
;;   Called from:
;;     0800:0032 (in fn0800_0000)
;;     0800:2A45 (in fn0800_2A2B)
;;     0800:4580 (in fn0800_3FAE)
;;     0800:4874 (in fn0800_476D)
;;     0800:5131 (in fn0800_50C8)
;;     0D27:01F9 (in main)
;;     0DAB:22CD (in fn0DAB_1AFE)
;;     0FDC:0909 (in fn0FDC_0629)
;;     11B8:0DE5 (in fn11B8_0D58)
;;     183B:1015 (in fn183B_000A)
fn1F3D_002F proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	call	far 207Fh:3BDCh
	or	ax,ax
	jnz	004Bh

l1F3D_003F:
	mov	es,[56F0h]
	cmp	word ptr es:[3938h],0h
	jz	0050h

l1F3D_004B:
	mov	ax,1h
	jmp	0052h

l1F3D_0050:
	sub	ax,ax

l1F3D_0052:
	retf

;; fn1F3D_0053: 1F3D:0053
;;   Called from:
;;     0800:3A95 (in fn0800_378D)
;;     0800:3AD4 (in fn0800_378D)
;;     0DAB:047F (in fn0DAB_0002)
;;     0DAB:0A19 (in fn0DAB_094B)
;;     0FDC:1523 (in fn0FDC_13DE)
;;     11B8:0224 (in fn11B8_0002)
;;     11B8:0241 (in fn11B8_0002)
;;     11B8:036B (in fn11B8_0002)
;;     11B8:0477 (in fn11B8_0002)
;;     11B8:05B6 (in fn11B8_0002)
;;     11B8:0947 (in fn11B8_0925)
;;     11B8:18A6 (in fn11B8_1762)
;;     11B8:18DF (in fn11B8_1762)
;;     135D:0409 (in fn135D_03AA)
;;     183B:039A (in fn183B_000A)
;;     183B:041D (in fn183B_000A)
;;     183B:1FAA (in fn183B_1C1F)
;;     1CD3:0F65 (in fn1CD3_0004)
;;     1CD3:0F93 (in fn1CD3_0004)
fn1F3D_0053 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp+6h]
	call	far 207Fh:3BB6h
	add	sp,8h
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	pop	bp
	retf

;; fn1F3D_0086: 1F3D:0086
;;   Called from:
;;     0800:1B8A (in fn0800_1AFD)
;;     0800:4759 (in fn0800_46A7)
;;     0D27:01D9 (in main)
;;     0DAB:1C05 (in fn0DAB_1AFE)
;;     1467:0A95 (in fn1467_08A8)
;;     1CD3:16A1 (in fn1CD3_0004)
fn1F3D_0086 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	cmp	word ptr [4FBAh],2h
	jz	00B3h

l1F3D_0097:
	push	word ptr [bp+10h]
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:200Eh
	add	sp,0Ch
	jmp	00D3h

l1F3D_00B3:
	push	word ptr [bp+10h]
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	sub	ax,ax
	mov	dx,0A000h
	push	dx
	push	ax
	mov	dx,0A800h
	push	dx
	push	ax
	call	far 207Fh:245Ch
	add	sp,10h

l1F3D_00D3:
	pop	bp
	retf

;; fn1F3D_00D5: 1F3D:00D5
;;   Called from:
;;     0800:4441 (in fn0800_3FAE)
;;     0800:44A2 (in fn0800_3FAE)
;;     0800:4ADF (in fn0800_4AA6)
;;     0800:4CEE (in fn0800_4CAC)
;;     0DAB:1C1D (in fn0DAB_1AFE)
;;     0DAB:1C75 (in fn0DAB_1AFE)
;;     0DAB:1CBC (in fn0DAB_1AFE)
;;     0DAB:1D0B (in fn0DAB_1AFE)
;;     0DAB:1D85 (in fn0DAB_1AFE)
;;     0DAB:1EE5 (in fn0DAB_1AFE)
;;     0DAB:1F72 (in fn0DAB_1AFE)
;;     0DAB:1F99 (in fn0DAB_1AFE)
;;     0DAB:1FD6 (in fn0DAB_1AFE)
;;     0DAB:2047 (in fn0DAB_1AFE)
;;     0DAB:20B8 (in fn0DAB_1AFE)
;;     0DAB:2131 (in fn0DAB_1AFE)
;;     0DAB:21AA (in fn0DAB_1AFE)
;;     1467:0B0F (in fn1467_08A8)
;;     1543:090D (in fn1543_07CB)
;;     183B:18FB (in fn183B_1774)
;;     1CD3:029B (in fn1CD3_0004)
;;     1CD3:03D8 (in fn1CD3_0004)
;;     1CD3:047B (in fn1CD3_0004)
;;     1CD3:0544 (in fn1CD3_0004)
;;     1CD3:05B1 (in fn1CD3_0004)
;;     1CD3:07A6 (in fn1CD3_0004)
;;     1CD3:080C (in fn1CD3_0004)
;;     1E56:0977 (in fn1E56_07CB)
;;     1E56:09E7 (in fn1E56_07CB)
;;     1F3D:05ED (in fn1F3D_05BC)
;;     1F3D:0626 (in fn1F3D_05BC)
fn1F3D_00D5 proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	push	word ptr [bp+10h]
	push	word ptr [bp+0Eh]
	call	far 207Fh:2127h
	add	sp,4h
	mov	ax,[bp+6h]
	mov	dx,[bp+8h]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	mov	ax,140h
	imul	word ptr [bp+0Ch]
	mov	[bp-0Ah],ax
	cmp	word ptr [4FBAh],3h
	jnz	0113h

l1F3D_010A:
	mov	ax,0A00h
	imul	word ptr [bp+0Ch]
	mov	[bp-0Ah],ax

l1F3D_0113:
	mov	ax,[bp+0Ah]
	mov	[bp-6h],ax
	jmp	01E7h

l1F3D_011C:
	cmp	byte ptr [bp-0Eh],0Dh
	jnz	013Fh

l1F3D_0122:
	mov	ax,[bp-6h]
	mov	[bp+0Ah],ax
	add	word ptr [bp-0Ah],140h
	cmp	word ptr [4FBAh],3h
	jnz	0139h

l1F3D_0134:
	add	word ptr [bp-0Ah],8C0h

l1F3D_0139:
	inc	word ptr [bp-4h]
	jmp	01E7h

l1F3D_013F:
	les	bx,[bp-4h]
	inc	word ptr [bp-4h]
	mov	al,es:[bx]
	and	ax,7Fh
	mov	cl,3h
	shl	ax,cl
	mov	[bp-0Ch],ax
	mov	ax,[4FB8h]
	dec	ax
	cmp	[bp+0Ah],ax
	jle	0176h

l1F3D_015B:
	mov	ax,[bp-6h]
	mov	[bp+0Ah],ax
	inc	word ptr [4FBEh]
	add	word ptr [bp-0Ah],140h
	cmp	word ptr [4FBAh],3h
	jnz	0176h

l1F3D_0171:
	add	word ptr [bp-0Ah],8C0h

l1F3D_0176:
	mov	ax,[bp+0Ah]
	inc	word ptr [bp+0Ah]
	mov	[bp-8h],ax
	cmp	word ptr [4FBAh],0h
	jnz	0199h

l1F3D_0186:
	shl	ax,1h
	push	ax
	push	word ptr [bp-0Ah]
	mov	ax,[bp-0Ch]
	shl	ax,1h
	push	ax
	call	far 207Fh:2209h
	jmp	01E4h

l1F3D_0199:
	cmp	word ptr [4FBAh],1h
	jnz	01BAh

l1F3D_01A0:
	mov	ax,[bp-8h]
	shl	ax,1h
	shl	ax,1h
	push	ax
	push	word ptr [bp-0Ah]
	mov	ax,[bp-0Ch]
	shl	ax,1h
	shl	ax,1h
	push	ax
	call	far 207Fh:21A8h
	jmp	01E4h

l1F3D_01BA:
	cmp	word ptr [4FBAh],2h
	jnz	01D1h

l1F3D_01C1:
	push	word ptr [bp-8h]
	push	word ptr [bp-0Ah]
	push	word ptr [bp-0Ch]
	call	far 207Fh:2251h
	jmp	01E4h

l1F3D_01D1:
	mov	ax,[bp-8h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-0Ch]
	call	far 207Fh:22A5h

l1F3D_01E4:
	add	sp,6h

l1F3D_01E7:
	les	bx,[bp-4h]
	mov	al,es:[bx]
	mov	[bp-0Eh],al
	or	al,al
	jz	01F7h

l1F3D_01F4:
	jmp	011Ch

l1F3D_01F7:
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_01FB: 1F3D:01FB
;;   Called from:
;;     0800:4460 (in fn0800_3FAE)
;;     0800:456C (in fn0800_3FAE)
;;     0800:4B76 (in fn0800_4AA6)
;;     0800:4C9F (in fn0800_4BC1)
;;     0DAB:1800 (in fn0DAB_174C)
;;     0DAB:184C (in fn0DAB_174C)
;;     0DAB:18CC (in fn0DAB_1858)
;;     1467:0A51 (in fn1467_08A8)
;;     1543:0895 (in fn1543_07CB)
;;     1543:08D7 (in fn1543_07CB)
;;     1543:0944 (in fn1543_07CB)
;;     1543:0DAC (in fn1543_0CDE)
;;     1E56:03DA (in fn1E56_0388)
;;     1E56:093B (in fn1E56_07CB)
fn1F3D_01FB proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	test	byte ptr [bp+6h],1h
	jnz	0218h

l1F3D_020B:
	test	byte ptr [bp+0Ah],1h
	jz	0218h

l1F3D_0211:
	cmp	word ptr [4FBAh],1h
	jz	0236h

l1F3D_0218:
	mov	ax,[bp+8h]
	cmp	[bp+0Ch],ax
	jl	0257h

l1F3D_0220:
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ah]
	push	word ptr [bp+6h]
	push	ax
	inc	word ptr [bp+8h]
	push	cs
	call	03EBh
	add	sp,8h
	jmp	0218h

l1F3D_0236:
	push	word ptr [bp+0Eh]
	mov	ax,[bp+0Ch]
	sub	ax,[bp+8h]
	push	ax
	mov	ax,[bp+0Ah]
	sub	ax,[bp+6h]
	sar	ax,1h
	push	ax
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:08A1h
	add	sp,0Ah

l1F3D_0257:
	pop	bp
	retf

;; fn1F3D_0259: 1F3D:0259
;;   Called from:
;;     0800:0043 (in fn0800_0000)
;;     0800:04DB (in fn0800_0000)
;;     0800:1A62 (in fn0800_1A13)
;;     0800:29D9 (in fn0800_2913)
;;     0800:2A40 (in fn0800_2A2B)
;;     0800:2A63 (in fn0800_2A4F)
;;     0800:337B (in fn0800_32B3)
;;     0800:35A8 (in fn0800_32B3)
;;     0800:3766 (in fn0800_35D3)
;;     0800:3BC6 (in fn0800_378D)
;;     0800:45AE (in fn0800_3FAE)
;;     0800:4DBE (in fn0800_4D57)
;;     0D27:0067 (in main)
;;     0D27:0099 (in main)
;;     0D27:00E5 (in main)
;;     0D27:0102 (in main)
;;     0DAB:0A68 (in fn0DAB_094B)
;;     0DAB:19CA (in fn0DAB_18E8)
;;     0DAB:230E (in fn0DAB_1AFE)
;;     0FDC:011C (in fn0FDC_0008)
;;     0FDC:024A (in fn0FDC_01C0)
;;     0FDC:06F0 (in fn0FDC_0629)
;;     0FDC:08F4 (in fn0FDC_0629)
;;     0FDC:0917 (in fn0FDC_0629)
;;     0FDC:0A02 (in fn0FDC_0629)
;;     0FDC:0B2B (in fn0FDC_0629)
;;     0FDC:0BA1 (in fn0FDC_0629)
;;     0FDC:15C6 (in fn0FDC_13DE)
;;     0FDC:17A0 (in fn0FDC_15E6)
;;     0FDC:19A6 (in fn0FDC_17B9)
;;     0FDC:19D6 (in fn0FDC_17B9)
;;     11B8:032A (in fn11B8_0002)
;;     11B8:0454 (in fn11B8_0002)
;;     11B8:0562 (in fn11B8_0002)
;;     11B8:07B4 (in fn11B8_0002)
;;     11B8:0800 (in fn11B8_0002)
;;     11B8:0D4E (in fn11B8_0925)
;;     11B8:0DF3 (in fn11B8_0D58)
;;     11B8:1923 (in fn11B8_1762)
;;     11B8:1993 (in fn11B8_1762)
;;     11B8:1A16 (in fn11B8_1762)
;;     11B8:1A31 (in fn11B8_1762)
;;     11B8:1A49 (in fn11B8_1762)
;;     135D:0273 (in fn135D_01E9)
;;     135D:02C1 (in fn135D_02A8)
;;     135D:030D (in fn135D_02D2)
;;     135D:049F (in fn135D_03AA)
;;     135D:0548 (in fn135D_04AB)
;;     135D:05D8 (in fn135D_055A)
;;     135D:05ED (in fn135D_055A)
;;     135D:0604 (in fn135D_055A)
;;     135D:07B9 (in fn135D_079C)
;;     135D:0AA2 (in fn135D_0980)
;;     135D:0BBA (in fn135D_0AB6)
;;     1431:0357 (in fn1431_000A)
;;     1467:044E (in fn1467_0002)
;;     1467:0465 (in fn1467_0002)
;;     1467:0501 (in fn1467_0002)
;;     1467:0833 (in fn1467_0002)
;;     1467:095E (in fn1467_08A8)
;;     1467:0B8A (in fn1467_08A8)
;;     1543:010C (in fn1543_0004)
;;     1543:0137 (in fn1543_0004)
;;     1543:0DB4 (in fn1543_0CDE)
;;     1631:108C (in fn1631_1057)
;;     1631:1DF2 (in fn1631_1DCC)
;;     183B:04DC (in fn183B_000A)
;;     183B:0CA6 (in fn183B_000A)
;;     183B:0E9B (in fn183B_000A)
;;     183B:0EF1 (in fn183B_000A)
;;     183B:0FB5 (in fn183B_000A)
;;     183B:1334 (in fn183B_000A)
;;     183B:13A0 (in fn183B_000A)
;;     183B:1DE5 (in fn183B_1C1F)
;;     183B:1FE1 (in fn183B_1C1F)
;;     183B:22A7 (in fn183B_2231)
;;     183B:2648 (in fn183B_2591)
;;     183B:267D (in fn183B_2591)
;;     1AE8:1CB8 (in fn1AE8_12C7)
;;     1AE8:1D28 (in fn1AE8_12C7)
;;     1CD3:0D9F (in fn1CD3_0004)
;;     1CD3:0F34 (in fn1CD3_0004)
;;     1CD3:16F6 (in fn1CD3_0004)
;;     1E56:0C1B (in fn1E56_0B5E)
;;     1F3D:05F4 (in fn1F3D_05BC)
;;     1F3D:062D (in fn1F3D_05BC)
fn1F3D_0259 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[56F0h]
	cmp	word ptr es:[3938h],0h
	jnz	02C1h

l1F3D_0270:
	call	far 207Fh:0B8Ah
	mov	[bp-4h],ax
	mov	es,[56F2h]
	cmp	word ptr es:[458Ch],0h
	jnz	0287h

l1F3D_0284:
	jmp	0318h

l1F3D_0287:
	cmp	ax,68h
	jnz	0291h

l1F3D_028C:
	mov	word ptr [bp-4h],48h

l1F3D_0291:
	mov	al,[bp-4h]
	mov	es,[56F4h]
	mov	bx,es:[39F8h]
	inc	word ptr es:[39F8h]
	mov	es,[56F6h]
	mov	es:[bx+0A0h],al
	cmp	word ptr [bp-4h],48h
	jz	0270h

l1F3D_02B1:
	mov	ax,[bp-4h]
	jmp	0318h

l1F3D_02B6:
	mov	ax,1Eh
	push	ax
	push	cs
	call	0006h
	add	sp,2h

l1F3D_02C1:
	mov	es,[56F4h]
	mov	bx,es:[39F8h]
	inc	word ptr es:[39F8h]
	mov	es,[56F6h]
	mov	al,es:[bx+0A0h]
	cbw
	mov	[bp-4h],ax
	cmp	ax,48h
	jz	02B6h

l1F3D_02E1:
	call	far 207Fh:3BDCh
	or	ax,ax
	jz	02FAh

l1F3D_02EA:
	mov	es,[56F8h]
	mov	word ptr es:[0152h],1h
	call	far 207Fh:0B8Ah

l1F3D_02FA:
	mov	ax,1h
	push	ax
	push	cs
	call	0006h
	add	sp,2h
	cmp	word ptr [bp-4h],50h
	jnz	02B1h

l1F3D_030B:
	mov	es,[56F8h]
	mov	word ptr es:[0152h],1h
	jmp	02B1h

l1F3D_0318:
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_031C: 1F3D:031C
;;   Called from:
;;     0800:4C06 (in fn0800_4BC1)
;;     0800:4C23 (in fn0800_4BC1)
;;     0800:4C42 (in fn0800_4BC1)
;;     0800:4C61 (in fn0800_4BC1)
;;     1467:09D9 (in fn1467_08A8)
;;     1467:09F7 (in fn1467_08A8)
;;     1467:0A13 (in fn1467_08A8)
;;     1467:0A31 (in fn1467_08A8)
;;     1467:0ABE (in fn1467_08A8)
;;     1AE8:1996 (in fn1AE8_12C7)
fn1F3D_031C proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	cmp	[bp+0Ah],ax
	jge	033Eh

l1F3D_032F:
	mov	[bp-2h],ax
	mov	ax,[bp+0Ah]
	mov	[bp+6h],ax
	mov	ax,[bp-2h]
	mov	[bp+0Ah],ax

l1F3D_033E:
	mov	ax,[bp+8h]
	cmp	[bp+0Ch],ax
	jge	0355h

l1F3D_0346:
	mov	[bp-2h],ax
	mov	ax,[bp+0Ch]
	mov	[bp+8h],ax
	mov	ax,[bp-2h]
	mov	[bp+0Ch],ax

l1F3D_0355:
	cmp	word ptr [bp+6h],0h
	jge	0360h

l1F3D_035B:
	mov	word ptr [bp+6h],0h

l1F3D_0360:
	cmp	word ptr [bp+8h],0h
	jge	036Bh

l1F3D_0366:
	mov	word ptr [bp+8h],0h

l1F3D_036B:
	cmp	word ptr [bp+0Ah],0h
	jge	0376h

l1F3D_0371:
	mov	word ptr [bp+0Ah],0h

l1F3D_0376:
	cmp	word ptr [bp+0Ch],0h
	jge	0381h

l1F3D_037C:
	mov	word ptr [bp+0Ch],0h

l1F3D_0381:
	cmp	word ptr [bp+6h],13Fh
	jle	038Dh

l1F3D_0388:
	mov	word ptr [bp+6h],13Fh

l1F3D_038D:
	cmp	word ptr [bp+0Ah],13Fh
	jle	0399h

l1F3D_0394:
	mov	word ptr [bp+0Ah],13Fh

l1F3D_0399:
	cmp	word ptr [bp+8h],0C7h
	jle	03A5h

l1F3D_03A0:
	mov	word ptr [bp+8h],0C7h

l1F3D_03A5:
	cmp	word ptr [bp+0Ch],0C7h
	jle	03B1h

l1F3D_03AC:
	mov	word ptr [bp+0Ch],0C7h

l1F3D_03B1:
	mov	ax,[bp+0Ah]
	cmp	[bp+6h],ax
	jnz	03CCh

l1F3D_03B9:
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:05D0h
	jmp	03E4h

l1F3D_03CC:
	mov	ax,[bp+0Ch]
	cmp	[bp+8h],ax
	jnz	03E7h

l1F3D_03D4:
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ah]
	push	word ptr [bp+6h]
	push	word ptr [bp+8h]
	push	cs
	call	03EBh

l1F3D_03E4:
	add	sp,8h

l1F3D_03E7:
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_03EB: 1F3D:03EB
;;   Called from:
;;     1F3D:022D (in fn1F3D_01FB)
;;     1F3D:03E0 (in fn1F3D_031C)
fn1F3D_03EB proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	bx,[4FBAh]
	shl	bx,1h
	mov	ax,[bx+4FC4h]
	mov	[bp-4h],ax
	jmp	0424h

l1F3D_0405:
	mov	ax,[bp+0Ah]
	cmp	[bp+8h],ax
	jg	042Ch

l1F3D_040D:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+6h]
	push	word ptr [bp+6h]
	push	word ptr [bp+8h]
	inc	word ptr [bp+8h]
	call	far 207Fh:05D0h
	add	sp,8h

l1F3D_0424:
	mov	ax,[bp-4h]
	test	[bp+8h],ax
	jnz	0405h

l1F3D_042C:
	mov	ax,[bp+0Ah]
	cmp	[bp+8h],ax
	jge	0491h

l1F3D_0434:
	sub	ax,[bp+8h]
	mov	[bp-2h],ax
	cmp	word ptr [4FBAh],3h
	jz	044Eh

l1F3D_0441:
	mov	bx,[4FBAh]
	shl	bx,1h
	mov	cl,[bx+4FD4h]
	sar	word ptr [bp-2h],cl

l1F3D_044E:
	cmp	word ptr [bp-2h],0h
	jz	0468h

l1F3D_0454:
	push	word ptr [bp+0Ch]
	push	word ptr [bp-2h]
	push	word ptr [bp+6h]
	push	word ptr [bp+8h]
	call	far 207Fh:0780h
	add	sp,8h

l1F3D_0468:
	mov	bx,[4FBAh]
	shl	bx,1h
	mov	ax,[bx+4FCCh]
	and	ax,[bp+0Ah]
	mov	[bp+8h],ax
	jmp	0491h

l1F3D_047A:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+6h]
	push	word ptr [bp+6h]
	push	word ptr [bp+8h]
	inc	word ptr [bp+8h]
	call	far 207Fh:05D0h
	add	sp,8h

l1F3D_0491:
	mov	ax,[bp+0Ah]
	cmp	[bp+8h],ax
	jle	047Ah

l1F3D_0499:
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_049D: 1F3D:049D
;;   Called from:
;;     0800:2E75 (in fn0800_2DA8)
;;     0800:325D (in fn0800_320B)
;;     0800:4673 (in fn0800_4621)
;;     0800:471D (in fn0800_46A7)
;;     0D27:0179 (in main)
;;     0D27:0250 (in main)
;;     0D27:02D2 (in main)
;;     0D27:037D (in main)
;;     0DAB:1BA9 (in fn0DAB_1AFE)
;;     135D:0115 (in fn135D_0004)
;;     135D:0692 (in fn135D_055A)
;;     135D:0868 (in fn135D_079C)
;;     1467:090D (in fn1467_08A8)
;;     1CD3:1641 (in fn1CD3_0004)
;;     1CD3:16E9 (in fn1CD3_0004)
fn1F3D_049D proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	les	bx,[bp+6h]
	inc	word ptr [bp+6h]
	cmp	byte ptr es:[bx],1h
	jnz	04C5h

l1F3D_04B4:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	es
	push	word ptr [bp+6h]
	call	far 207Fh:22F8h
	jmp	04D6h

l1F3D_04C5:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:2368h

l1F3D_04D6:
	add	sp,8h
	cmp	word ptr [4FBAh],0h
	jnz	0521h

l1F3D_04E0:
	mov	word ptr [bp-4h],50h
	cmp	word ptr [4FBCh],0h
	jz	04F1h

l1F3D_04EC:
	mov	word ptr [bp-4h],4h

l1F3D_04F1:
	mov	ax,3E80h
	push	ax
	push	word ptr [bp-4h]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	call	far 207Fh:0163h
	add	sp,0Ch
	cmp	word ptr [4FBCh],0h
	jz	0521h

l1F3D_0513:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	call	far 207Fh:01D7h
	add	sp,4h

l1F3D_0521:
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_0525: 1F3D:0525
;;   Called from:
;;     0800:46CA (in fn0800_46A7)
;;     0D27:01BD (in main)
;;     0DAB:2297 (in fn0DAB_1AFE)
;;     0DAB:2306 (in fn0DAB_1AFE)
;;     1CD3:1685 (in fn1CD3_0004)
;;     1CD3:1733 (in fn1CD3_0004)
fn1F3D_0525 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	cmp	word ptr [4FBAh],1h
	jnz	0556h

l1F3D_0538:
	mov	es,[56EEh]
	push	word ptr es:[32ACh]
	call	far 207Fh:0B40h
	add	sp,2h
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:2B45h
	jmp	05B4h

l1F3D_0556:
	cmp	word ptr [4FBAh],2h
	jnz	05A2h

l1F3D_055D:
	mov	es,[56EEh]
	push	word ptr es:[32ACh]
	call	far 207Fh:0B40h
	add	sp,2h
	mov	word ptr [bp-2h],0h
	jmp	0578h

l1F3D_0575:
	inc	word ptr [bp-2h]

l1F3D_0578:
	cmp	word ptr [bp-2h],10h
	jge	05B7h

l1F3D_057E:
	mov	bx,[bp-2h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-4h],ax
	cmp	ax,7h
	jle	0594h

l1F3D_0590:
	add	word ptr [bp-4h],8h

l1F3D_0594:
	push	word ptr [bp-4h]
	push	bx
	call	far 207Fh:022Ah
	add	sp,4h
	jmp	0575h

l1F3D_05A2:
	cmp	word ptr [4FBAh],3h
	jnz	05B7h

l1F3D_05A9:
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:0FEEh

l1F3D_05B4:
	add	sp,4h

l1F3D_05B7:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_05BC: 1F3D:05BC
;;   Called from:
;;     1E56:0B00 (in fn1E56_0AE5)
;;     1F3D:072E (in fn1F3D_070A)
fn1F3D_05BC proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	mov	[bp-2h],ax
	cmp	word ptr [bp+8h],0h
	jl	05FAh

l1F3D_05D3:
	jg	05DAh

l1F3D_05D5:
	cmp	ax,0FFFFh
	jbe	05FAh

l1F3D_05DA:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,0Ah
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,4FDAh
	push	ds
	push	ax
	push	cs
	call	00D5h
	add	sp,0Ch
	push	cs
	call	0259h
	jmp	060Bh

l1F3D_05FA:
	push	word ptr [bp-2h]
	call	far 207Fh:3835h
	add	sp,2h
	mov	[bp-6h],ax
	mov	[bp-4h],dx

l1F3D_060B:
	mov	ax,[bp-6h]
	or	ax,[bp-4h]
	jnz	0631h

l1F3D_0613:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,0Ah
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,4FE9h
	push	ds
	push	ax
	push	cs
	call	00D5h
	add	sp,0Ch
	push	cs
	call	0259h

l1F3D_0631:
	mov	ax,[bp-6h]
	mov	dx,[bp-4h]
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_063B: 1F3D:063B
;;   Called from:
;;     0800:2E5D (in fn0800_2DA8)
;;     0800:3245 (in fn0800_320B)
;;     0800:465B (in fn0800_4621)
;;     0800:46FA (in fn0800_46A7)
;;     0D27:0161 (in main)
;;     0D27:0238 (in main)
;;     0D27:02BA (in main)
;;     0D27:033C (in main)
;;     0DAB:1B76 (in fn0DAB_1AFE)
;;     0FDC:1D87 (in fn0FDC_1D30)
;;     135D:00FD (in fn135D_0004)
;;     135D:067A (in fn135D_055A)
;;     135D:0850 (in fn135D_079C)
;;     1467:08DA (in fn1467_08A8)
;;     1CD3:1629 (in fn1CD3_0004)
;;     1CD3:16D1 (in fn1CD3_0004)
fn1F3D_063B proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh

l1F3D_0646:
	mov	word ptr [bp-4h],0h
	mov	ax,8000h
	push	ax
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-6h],ax
	cmp	ax,0FFFFh
	jz	069Ah

l1F3D_0665:
	mov	ax,2h
	push	ax
	lea	ax,[bp-2h]
	push	ss
	push	ax
	push	word ptr [bp-6h]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-2h]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp-6h]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-6h]
	call	far 207Fh:3336h
	add	sp,2h
	jmp	069Fh

l1F3D_069A:
	mov	word ptr [bp-4h],1h

l1F3D_069F:
	cmp	word ptr [bp-4h],0h
	jz	06B6h

l1F3D_06A5:
	mov	es,[56FAh]
	push	word ptr es:[014Eh]
	call	far 0800h:2913h
	add	sp,2h

l1F3D_06B6:
	cmp	word ptr [bp-4h],0h
	jnz	0646h

l1F3D_06BC:
	mov	ax,1h
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_06C3: 1F3D:06C3
;;   Called from:
;;     0800:0491 (in fn0800_0000)
;;     0800:2D9F (in fn0800_2C50)
;;     0800:3F7D (in fn0800_3D40)
;;     0FDC:084B (in fn0FDC_0629)
;;     0FDC:098D (in fn0FDC_0629)
;;     0FDC:13D5 (in fn0FDC_134B)
;;     135D:016C (in fn135D_0004)
;;     135D:025C (in fn135D_01E9)
;;     135D:0788 (in fn135D_055A)
;;     135D:08F5 (in fn135D_079C)
;;     135D:0D21 (in fn135D_0AB6)
;;     1631:036A (in fn1631_032F)
;;     183B:0510 (in fn183B_000A)
;;     183B:1802 (in fn183B_1774)
;;     1AE8:1281 (in fn1AE8_000C)
;;     1AE8:14FA (in fn1AE8_12C7)
;;     1AE8:1963 (in fn1AE8_12C7)
;;     1AE8:1AAA (in fn1AE8_12C7)
;;     1AE8:1D11 (in fn1AE8_12C7)
;;     1CD3:0114 (in fn1CD3_0004)
fn1F3D_06C3 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	cmp	word ptr [4FBAh],2h
	jnz	06F6h

l1F3D_06D1:
	mov	ax,0C8h
	push	ax
	mov	ax,1Bh
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,0Dh
	push	ax
	sub	ax,ax
	mov	dx,0A000h
	push	dx
	push	ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:245Ch
	add	sp,10h
	jmp	0709h

l1F3D_06F6:
	cmp	word ptr [4FBAh],3h
	jnz	0704h

l1F3D_06FD:
	call	far 207Fh:1D3Ah
	jmp	0709h

l1F3D_0704:
	call	far 207Fh:1CB8h

l1F3D_0709:
	retf

;; fn1F3D_070A: 1F3D:070A
;;   Called from:
;;     0D27:0425 (in main)
;;     0D27:0454 (in main)
;;     0D27:0480 (in main)
;;     0D27:04C1 (in main)
;;     0D27:04EE (in main)
;;     0D27:050A (in main)
;;     0D27:0526 (in main)
;;     0D27:0542 (in main)
;;     0D27:055E (in main)
;;     0D27:057A (in main)
;;     0D27:0595 (in main)
;;     0D27:05B1 (in main)
;;     0D27:05CD (in main)
;;     0D27:05E9 (in main)
;;     0D27:0622 (in main)
;;     0D27:065B (in main)
;;     0D27:068B (in main)
;;     0D27:06B0 (in main)
;;     0D27:06CC (in main)
;;     0D27:06E7 (in main)
;;     0D27:0703 (in main)
;;     0D27:0726 (in main)
;;     0D27:0768 (in main)
;;     0D27:07A1 (in main)
;;     0D27:07E3 (in main)
;;     0D27:0810 (in main)
;;     0D27:082C (in main)
fn1F3D_070A proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-6h],4h
	mov	ax,[bp+0Ch]
	imul	word ptr [bp+0Eh]
	mul	word ptr [bp-6h]
	mov	[bp-6h],ax
	add	ax,4h
	sub	cx,cx
	push	cx
	push	ax
	push	cs
	call	05BCh
	add	sp,4h
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[56FCh]
	mov	es:[bx+39FAh],ax
	mov	es:[bx+39FCh],dx
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	or	ax,dx
	jnz	0757h

l1F3D_0754:
	jmp	080Fh

l1F3D_0757:
	les	bx,[bp-4h]
	mov	al,[bp+0Eh]
	dec	al
	mov	es:[bx+1h],al
	les	bx,[bp-4h]
	mov	al,[bp+0Ch]
	mov	es:[bx+2h],al
	cmp	word ptr [4FBAh],0h
	jnz	0787h

l1F3D_0774:
	shl	word ptr [bp+8h],1h
	mov	ax,50h
	imul	word ptr [bp+0Ah]
	mov	[bp+0Ah],ax
	mov	word ptr [bp-8h],50h
	jmp	079Dh

l1F3D_0787:
	mov	cl,2h
	shl	word ptr [bp+8h],cl
	mov	ax,0A0h
	imul	word ptr [bp+0Ah]
	mov	[bp+0Ah],ax
	shl	word ptr [bp+0Ch],1h
	mov	word ptr [bp-8h],0A0h

l1F3D_079D:
	mov	ax,[bp-8h]
	mov	cx,[bp+0Ch]
	shl	cx,1h
	sub	ax,cx
	push	ax
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	mov	ax,[bp-4h]
	mov	dx,[bp-2h]
	add	ax,4h
	push	dx
	push	ax
	mov	si,[bp+0Ah]
	mov	bx,[bp+8h]
	lea	ax,[bx+si+244Bh]
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0931h
	add	sp,0Eh
	cmp	word ptr [4FBAh],0h
	jnz	080Fh

l1F3D_07D7:
	mov	ax,[bp-8h]
	mov	cx,[bp+0Ch]
	shl	cx,1h
	sub	ax,cx
	push	ax
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	mov	ax,[bp-6h]
	shr	ax,1h
	add	ax,[bp-4h]
	mov	dx,[bp-2h]
	add	ax,4h
	push	dx
	push	ax
	mov	si,[bp+0Ah]
	mov	bx,[bp+8h]
	lea	ax,[bx+si+4614h]
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0931h
	add	sp,0Eh

l1F3D_080F:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_0814: 1F3D:0814
;;   Called from:
;;     0800:49E2 (in fn0800_48B7)
;;     0800:5215 (in fn0800_50C8)
;;     11B8:16DA (in fn11B8_16B2)
;;     135D:06FA (in fn135D_055A)
fn1F3D_0814 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	jmp	0832h

l1F3D_0821:
	mov	es,[56FAh]
	push	word ptr es:[014Eh]
	call	far 0800h:2913h
	add	sp,2h

l1F3D_0832:
	mov	ax,8000h
	push	ax
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-2h],ax
	inc	ax
	jz	0821h

l1F3D_084A:
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp-2h]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-2h]
	call	far 207Fh:3336h
	mov	sp,bp
	pop	bp
	retf

;; fn1F3D_086A: 1F3D:086A
;;   Called from:
;;     0800:39EC (in fn0800_378D)
;;     0800:3BC1 (in fn0800_378D)
;;     0DAB:0A63 (in fn0DAB_094B)
;;     0DAB:19C5 (in fn0DAB_18E8)
;;     0FDC:0337 (in fn0FDC_01C0)
;;     0FDC:08EF (in fn0FDC_0629)
;;     0FDC:0AA0 (in fn0FDC_0629)
;;     0FDC:0B9C (in fn0FDC_0629)
;;     0FDC:15C1 (in fn0FDC_13DE)
;;     0FDC:179B (in fn0FDC_15E6)
;;     135D:0BB5 (in fn135D_0AB6)
;;     1431:02BA (in fn1431_000A)
;;     1467:0449 (in fn1467_0002)
;;     183B:0CA1 (in fn183B_000A)
;;     1CD3:0D9A (in fn1CD3_0004)
;;     1CD3:16F1 (in fn1CD3_0004)
;;     1CD3:1802 (in fn1CD3_17EA)
fn1F3D_086A proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,32h
	push	ax
	push	cs
	call	0006h
	add	sp,2h
	call	far 0800h:2A2Bh
