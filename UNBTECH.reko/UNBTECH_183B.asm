;;; Segment 183B (183B:0000)
183B:0000 FC 9A 81 02 56 1E 8B E5 5D CB                   ....V...].      

;; fn183B_000A: 183B:000A
;;   Called from:
;;     0800:02AE (in fn0800_0000)
;;     0FDC:0739 (in fn0FDC_0629)
;;     0FDC:07D8 (in fn0FDC_0629)
;;     0FDC:0809 (in fn0FDC_0629)
;;     0FDC:0AC5 (in fn0FDC_0629)
;;     11B8:1371 (in fn11B8_104E)
fn183B_000A proc
	push	bp
	mov	bp,sp
	mov	ax,44h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[55CAh]
	mov	word ptr es:[2B20h],0Ch
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	[bp-32h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	[bp-36h],ax
	mov	word ptr [bp-2Ch],0h

l183B_003D:
	mov	bx,[bp-2Ch]
	mov	es,[55D0h]
	mov	al,es:[bx+7A4h]
	mov	si,bx
	mov	[bp+si-1Ch],al
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],9h
	jl	003Dh

l183B_0057:
	mov	word ptr [bp-0Ah],0h
	cmp	word ptr [bp+6h],0h
	jnz	00A1h

l183B_0062:
	mov	word ptr [bp-26h],0h

l183B_0067:
	mov	si,[bp-26h]
	shl	si,1h
	mov	ax,1Ah
	imul	word ptr [bp-26h]
	mov	di,ax
	mov	es,[55D2h]
	mov	ax,es:[si+4024h]
	mov	es,[55D4h]
	mov	es:[di+0D390h],ax
	mov	es,[55D6h]
	mov	ax,es:[si+4056h]
	mov	es,[55D4h]
	mov	es:[di+0D392h],ax
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],8h
	jl	0067h

l183B_00A1:
	mov	word ptr [bp-26h],0h
	jmp	016Eh

l183B_00A9:
	inc	word ptr [bp-2Ah]

l183B_00AC:
	cmp	word ptr [bp-2Ah],18h
	jl	00B5h

l183B_00B2:
	jmp	016Bh

l183B_00B5:
	mov	ax,18h
	imul	word ptr [bp-26h]
	mov	si,ax
	add	si,[bp-2Ah]
	mov	al,2h
	mov	es,[55D8h]
	mov	es:[si+41D4h],al
	mov	es:[si+40B4h],al
	cmp	word ptr [bp-2Ah],0Ch
	jge	00F1h

l183B_00D6:
	mov	ax,0Ch
	imul	word ptr [bp-26h]
	mov	si,ax
	add	si,[bp-2Ah]
	mov	al,0FFh
	mov	es,[55DAh]
	mov	es:[si+3890h],al
	mov	es:[si+3800h],al

l183B_00F1:
	mov	ax,30h
	imul	word ptr [bp-26h]
	mov	si,ax
	add	si,[bp-2Ah]
	mov	al,0FFh
	mov	es,[55DCh]
	mov	es:[si+351Eh],al
	mov	es:[si+32DEh],al
	mov	es:[si+3506h],al
	mov	es:[si+32C6h],al
	cmp	word ptr [bp+6h],0h
	jnz	00A9h

l183B_011C:
	cmp	word ptr [bp-26h],0h
	jnz	00A9h

l183B_0122:
	mov	si,[bp-2Ah]
	shl	si,1h
	sub	ax,ax
	mov	es,[55DEh]
	mov	es:[si+393Ch],ax
	mov	es,[55E0h]
	mov	es:[si+406Ah],ax
	mov	bx,[bp-2Ah]
	mov	es,[55E2h]
	mov	es:[bx+32AEh],al
	mov	al,0FFh
	mov	bx,[bp-2Ah]
	mov	es,[55E4h]
	mov	es:[bx+3920h],al
	cbw
	mov	es,[55D6h]
	mov	es:[si+4036h],ax
	mov	es,[55D2h]
	mov	es:[si+4004h],ax
	jmp	00A9h

l183B_016B:
	inc	word ptr [bp-26h]

l183B_016E:
	cmp	word ptr [bp-26h],0Ch
	jge	017Ch

l183B_0174:
	mov	word ptr [bp-2Ah],0h
	jmp	00ACh

l183B_017C:
	mov	word ptr [bp-26h],0h

l183B_0181:
	sub	al,al
	mov	bx,[bp-26h]
	mov	es,[55E6h]
	mov	es:[bx+3998h],al
	mov	bx,[bp-26h]
	mov	es:[bx+3994h],al
	mov	bx,[bp-26h]
	mov	es,[55E8h]
	mov	es:[bx+0D576h],al
	mov	bx,[bp-26h]
	mov	es,[55EAh]
	mov	es:[bx+6Eh],al
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],8h
	jl	0181h

l183B_01B8:
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	[bp-28h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	[bp-2Eh],ax
	sub	ax,ax
	mov	[bp-38h],ax
	mov	[bp-22h],ax
	mov	[bp-10h],ax
	mov	[bp-2Ch],ax

l183B_01DC:
	mov	ax,11h
	imul	word ptr [bp-2Ch]
	mov	si,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	0250h

l183B_01F0:
	cmp	byte ptr es:[si+0C620h],8h
	jl	0250h

l183B_01F8:
	mov	bx,[bp-10h]
	mov	al,[bx+3A1Eh]
	cbw
	push	ax
	mov	al,[bx+3A16h]
	cbw
	push	ax
	call	far 0800h:191Bh
	add	sp,4h
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	es,[55D2h]
	mov	es:[si+400Ch],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	es,[55D6h]
	mov	es:[si+403Eh],ax
	mov	es,[55E0h]
	inc	word ptr es:[si+4072h]
	push	word ptr [bp-2Eh]
	push	word ptr [bp-28h]
	call	far 0800h:186Fh
	add	sp,4h
	inc	word ptr [bp-10h]

l183B_0250:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],8h
	jl	01DCh

l183B_0259:
	mov	word ptr [bp-2Ch],0h

l183B_025E:
	mov	ax,7Dh
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	02D2h

l183B_0272:
	mov	bx,[bp-22h]
	mov	al,[bx+3A26h]
	cbw
	mov	[bp-26h],ax
	mov	al,[bx+3A2Ah]
	cbw
	mov	[bp-2Ah],ax
	inc	word ptr [bp-22h]
	push	ax
	push	word ptr [bp-26h]
	call	far 0800h:191Bh
	add	sp,4h
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	es,[55D2h]
	mov	es:[si+4004h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	es,[55D6h]
	mov	es:[si+4036h],ax
	mov	es,[55E0h]
	inc	word ptr es:[si+406Ah]
	push	word ptr [bp-2Eh]
	push	word ptr [bp-28h]
	call	far 0800h:186Fh
	add	sp,4h

l183B_02D2:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],4h
	jl	025Eh

l183B_02DB:
	cmp	word ptr [bp+6h],0h
	jz	02E4h

l183B_02E1:
	jmp	0471h

l183B_02E4:
	call	far 0DABh:0D3Dh
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[55ECh]
	mov	word ptr es:[37FEh],0Fh
	sub	ax,ax
	mov	[bp-0Ah],ax
	mov	[bp-12h],ax
	mov	word ptr [bp-2Ch],0Ch

l183B_0312:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55E0h]
	cmp	word ptr es:[si+406Ah],0h
	jz	0340h

l183B_0323:
	mov	es,[55D2h]
	cmp	word ptr es:[si+4004h],0FFh
	jz	0340h

l183B_032F:
	mov	es,[55D6h]
	cmp	word ptr es:[si+4036h],0FFh
	jz	0340h

l183B_033B:
	mov	word ptr [bp-0Ah],1h

l183B_0340:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],18h
	jl	0312h

l183B_0349:
	cmp	word ptr [bp-0Ah],0h
	jz	0356h

l183B_034F:
	push	cs
	call	28DBh
	mov	[bp-0Ah],ax

l183B_0356:
	cmp	word ptr [bp-0Ah],0h
	jnz	035Fh

l183B_035C:
	jmp	0476h

l183B_035F:
	mov	ax,3402h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-2Ch],4h

l183B_0371:
	mov	ax,7Dh
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	0388h

l183B_0385:
	inc	word ptr [bp-12h]

l183B_0388:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],8h
	jl	0371h

l183B_0391:
	cmp	word ptr [bp-12h],0h
	jz	03C7h

l183B_0397:
	push	word ptr [bp-12h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,3414h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-12h],1h
	jle	03BAh

l183B_03B5:
	call	far 0800h:2A69h

l183B_03BA:
	mov	ax,341Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l183B_03C7:
	mov	word ptr [bp-12h],0h
	mov	word ptr [bp-2Ch],8h

l183B_03D1:
	mov	ax,11h
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jz	0411h

l183B_03E5:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55E0h]
	cmp	word ptr es:[si+407Ah],0h
	jz	0411h

l183B_03F6:
	mov	es,[55D2h]
	cmp	word ptr es:[si+4014h],0FFh
	jz	0411h

l183B_0402:
	mov	es,[55D6h]
	cmp	word ptr es:[si+4046h],0FFh
	jz	0411h

l183B_040E:
	inc	word ptr [bp-12h]

l183B_0411:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],10h
	jl	03D1h

l183B_041A:
	push	word ptr [bp-12h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,3421h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-12h],1h
	jz	043Dh

l183B_0438:
	call	far 0800h:2A69h

l183B_043D:
	call	far 0800h:2A7Eh
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3428h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	mov	[bp-6h],ax
	jmp	0476h

l183B_0471:
	mov	word ptr [bp-6h],1h

l183B_0476:
	cmp	word ptr [bp+6h],0h
	jz	0481h

l183B_047C:
	mov	word ptr [bp-0Ah],1h

l183B_0481:
	cmp	word ptr [bp-0Ah],0h
	jnz	048Ah

l183B_0487:
	jmp	1037h

l183B_048A:
	cmp	word ptr [bp-6h],0h
	jnz	049Ch

l183B_0490:
	call	far 207Fh:0BC0h
	test	al,3h
	jz	049Ch

l183B_0499:
	jmp	1037h

l183B_049C:
	cmp	word ptr [bp-6h],0h
	jnz	04BEh

l183B_04A2:
	call	far 1E56h:0388h
	mov	ax,343Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh
	mov	word ptr [bp-6h],1h

l183B_04BE:
	mov	es,[55EEh]
	cmp	word ptr es:[3772h],0h
	jz	04E6h

l183B_04CA:
	call	far 1CD3h:17C6h
	mov	ax,3452h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	word ptr [bp-8h],0h

l183B_04E6:
	cmp	word ptr [bp+6h],2h
	jnz	0515h

l183B_04EC:
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:0E4Bh
	call	far 1F3Dh:06C3h

l183B_0515:
	mov	es,[55F0h]
	mov	word ptr es:[009Eh],0h
	call	far 0800h:2A2Bh
	mov	es,[55F2h]
	cmp	word ptr es:[0090h],0h
	jnz	053Eh

l183B_0531:
	call	far 0DABh:0B5Eh
	mov	es,[55F0h]
	mov	es:[009Eh],ax

l183B_053E:
	call	far 0800h:2A2Bh
	push	cs
	call	24F0h
	mov	es,[55F4h]
	mov	es:[2E38h],ax
	call	far 0800h:2A2Bh
	push	cs
	call	2556h
	mov	es,[55F6h]
	mov	es:[2E3Ah],ax
	sub	ax,ax
	mov	[bp-0Ch],ax
	mov	[bp-12h],ax
	jmp	102Eh

l183B_056B:
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	[bp-20h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	[bp-24h],ax
	mov	es,[55F8h]
	mov	word ptr es:[3992h],0h
	mov	es,[55F0h]
	cmp	word ptr es:[009Eh],0h
	jz	059Bh

l183B_0598:
	jmp	07D0h

l183B_059B:
	mov	word ptr [bp-2Ch],0h

l183B_05A0:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55E0h]
	cmp	word ptr es:[si+406Ah],0h
	jz	05FCh

l183B_05B1:
	mov	es,[55D2h]
	cmp	word ptr es:[si+4004h],0FFh
	jz	05C9h

l183B_05BD:
	mov	es,[55D6h]
	cmp	word ptr es:[si+4036h],0FFh
	jnz	05D9h

l183B_05C9:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55E0h]
	mov	word ptr es:[bx+406Ah],0h

l183B_05D9:
	mov	word ptr [bp-30h],0h

l183B_05DE:
	mov	ax,18h
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	add	bx,[bp-30h]
	mov	es,[55D8h]
	mov	byte ptr es:[bx+40B4h],2h
	inc	word ptr [bp-30h]
	cmp	word ptr [bp-30h],18h
	jl	05DEh

l183B_05FC:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],0Ch
	jl	05A0h

l183B_0605:
	push	cs
	call	14C3h
	mov	[bp-38h],ax
	mov	es,[55EEh]
	cmp	word ptr es:[3772h],0h
	jz	0651h

l183B_0618:
	mov	es,[55D6h]
	cmp	word ptr es:[4036h],0D000h
	jnc	064Ch

l183B_0625:
	mov	es,[55D2h]
	cmp	word ptr es:[4004h],0D00h
	jge	064Ch

l183B_0632:
	mov	es,[55D6h]
	cmp	word ptr es:[4036h],0B07Fh
	jc	064Ch

l183B_063F:
	mov	es,[55D2h]
	cmp	word ptr es:[4004h],0B7Fh
	jge	0651h

l183B_064C:
	mov	word ptr [bp-38h],2h

l183B_0651:
	cmp	word ptr [bp-38h],0h
	jnz	065Ah

l183B_0657:
	jmp	06DCh

l183B_065A:
	cmp	word ptr [bp-38h],2h
	jz	066Fh

l183B_0660:
	call	far 207Fh:0BC0h
	and	al,3h
	cmp	al,1h
	sbb	cx,cx
	inc	cx
	mov	[bp-38h],cx

l183B_066F:
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	cmp	word ptr [bp+6h],2h
	jl	068Bh

l183B_0686:
	mov	word ptr [bp-38h],0h

l183B_068B:
	mov	es,[55EEh]
	cmp	word ptr es:[3772h],0h
	jz	06B6h

l183B_0697:
	cmp	word ptr [bp-38h],2h
	jz	06B6h

l183B_069D:
	mov	ax,3497h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-38h],0h

l183B_06AF:
	call	far 0800h:2A4Fh
	jmp	06DCh

l183B_06B6:
	cmp	word ptr [bp-38h],0h
	jnz	06CBh

l183B_06BC:
	mov	ax,34B8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	06AFh

l183B_06CB:
	cmp	word ptr [bp+6h],0h
	jle	06DCh

l183B_06D1:
	mov	es,[55F8h]
	mov	word ptr es:[3992h],1h

l183B_06DC:
	mov	ax,[bp-38h]
	mov	[bp-12h],ax
	or	ax,ax
	jz	06E9h

l183B_06E6:
	jmp	0826h

l183B_06E9:
	mov	word ptr [bp-2Ch],0h
	jmp	0796h

l183B_06F1:
	mov	ax,18h
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D8h]
	cmp	byte ptr es:[bx+40B4h],2h
	jz	0708h

l183B_0705:
	jmp	0793h

l183B_0708:
	mov	ax,30h
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55DCh]
	cmp	byte ptr es:[bx+32C6h],0FFh
	jz	0793h

l183B_071C:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55D6h]
	push	word ptr es:[si+4036h]
	mov	es,[55D2h]
	push	word ptr es:[si+4004h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:1DF8h
	cmp	word ptr [bp-2Ch],4h
	jge	077Fh

l183B_0760:
	mov	ax,30h
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55DCh]
	mov	al,es:[bx+32C6h]
	cbw
	push	ax
	push	word ptr [bp-2Ch]
	push	cs
	call	22BCh
	add	sp,4h
	jmp	0789h

l183B_077F:
	push	word ptr [bp-2Ch]
	push	cs
	call	2474h
	add	sp,2h

l183B_0789:
	push	word ptr [bp-2Ch]
	push	cs
	call	193Bh
	add	sp,2h

l183B_0793:
	inc	word ptr [bp-2Ch]

l183B_0796:
	cmp	word ptr [bp-2Ch],0Ch
	jl	079Fh

l183B_079C:
	jmp	0826h

l183B_079F:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	0793h

l183B_07B0:
	mov	bx,[bp-2Ch]
	mov	es,[55E6h]
	cmp	byte ptr es:[bx+3994h],0h
	jnz	07C2h

l183B_07BF:
	jmp	06F1h

l183B_07C2:
	sub	ax,ax
	push	ax
	push	bx
	call	far 1631h:03ABh
	add	sp,4h
	jmp	0793h

l183B_07D0:
	sub	ax,ax
	push	ax
	push	cs
	call	1482h
	add	sp,2h
	mov	es,[55F8h]
	cmp	word ptr es:[3992h],0h
	jz	0826h

l183B_07E6:
	mov	word ptr [bp-38h],1h
	mov	word ptr [bp-2Ch],0h

l183B_07F0:
	mov	ax,7Dh
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	0809h

l183B_0804:
	mov	word ptr [bp-38h],0h

l183B_0809:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],4h
	jl	07F0h

l183B_0812:
	cmp	word ptr [bp-38h],0h
	jz	0826h

l183B_0818:
	call	far 207Fh:0BC0h
	and	ax,3h
	mov	[bp-38h],ax
	mov	[bp-12h],ax

l183B_0826:
	cmp	word ptr [bp-38h],0h
	jz	082Fh

l183B_082C:
	jmp	0FFDh

l183B_082F:
	push	word ptr [bp-24h]
	push	word ptr [bp-20h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[55FAh]
	mov	word ptr es:[374Ch],0h
	mov	ax,0Ch
	push	ax
	push	cs
	call	1482h
	add	sp,2h
	push	word ptr [bp-24h]
	push	word ptr [bp-20h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	cmp	word ptr [bp+6h],0h
	jle	0886h

l183B_0881:
	mov	ax,1h
	jmp	0888h

l183B_0886:
	sub	ax,ax

l183B_0888:
	push	ax
	call	far 1AE8h:000Ch
	add	sp,2h
	mov	es,[55FCh]
	cmp	word ptr es:[014Ah],0h
	jnz	08A0h

l183B_089D:
	jmp	0CDBh

l183B_08A0:
	mov	es,[55D4h]
	cmp	byte ptr es:[0D333h],0h
	jnz	08AFh

l183B_08AC:
	jmp	0CDBh

l183B_08AF:
	mov	es,[55FEh]
	cmp	word ptr es:[374Ah],0h
	jnz	08BEh

l183B_08BB:
	jmp	0CDBh

l183B_08BE:
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	es,[55D4h]
	mov	al,es:[0D331h]
	cbw
	mov	[bp-44h],ax
	mov	ax,11h
	imul	word ptr [bp-44h]
	mov	bx,ax
	mov	al,es:[bx+0C620h]
	cbw
	mov	[bp-2h],ax
	cmp	ax,8h
	jz	08FFh

l183B_08FC:
	jmp	09ADh

l183B_08FF:
	mov	ax,34E9h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-44h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5600h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,34F6h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3510h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3555h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,358Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	si,[bp-44h]
	shl	si,1h
	mov	es,[55D6h]
	push	word ptr es:[si+403Eh]
	mov	es,[55D2h]
	push	word ptr es:[si+400Ch]
	mov	ax,7Eh
	push	ax
	push	cs
	call	27C9h
	add	sp,6h
	mov	si,[bp-44h]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[55D6h]
	mov	es:[si+403Eh],ax
	mov	es,[55D2h]
	mov	es:[si+400Ch],ax
	jmp	0CA1h

l183B_09AD:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	es,[55D4h]
	mov	al,es:[si+0C79Dh]
	sub	ah,ah
	cmp	ax,[bp-44h]
	jz	09C8h

l183B_09C5:
	jmp	0BD4h

l183B_09C8:
	mov	al,es:[si+0C79Eh]
	mov	[bp-0Eh],ax
	mov	ax,11h
	imul	word ptr [bp-44h]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5600h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,35D1h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-0Eh],0FFh
	jz	0A25h

l183B_0A0E:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C61Ch],0h
	jz	0A25h

l183B_0A22:
	jmp	0B40h

l183B_0A25:
	cmp	word ptr [bp-0Eh],0FFh
	jnz	0A49h

l183B_0A2C:
	mov	ax,3610h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3653h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	0AD4h

l183B_0A49:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[55D4h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5600h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3666h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,36A9h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[55D4h]
	mov	byte ptr es:[bx+0C620h],8h
	mov	si,[bp-0Eh]
	shl	si,1h
	mov	es,[55E0h]
	mov	word ptr es:[si+4072h],1h
	mov	di,[bp-2h]
	shl	di,1h
	mov	es,[55D2h]
	mov	ax,es:[di+4004h]
	mov	es:[si+400Ch],ax
	mov	es,[55D6h]
	mov	ax,es:[di+4036h]
	mov	es:[si+403Eh],ax

l183B_0AD4:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	byte ptr es:[bx+0C724h],0FFh
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[55D6h]
	push	word ptr es:[si+4036h]
	mov	es,[55D2h]
	push	word ptr es:[si+4004h]
	mov	bx,[bp-2h]
	mov	es,[5602h]
	cmp	byte ptr es:[bx+0D55Eh],1h
	sbb	ax,ax
	inc	ax
	add	ax,80h
	push	ax
	push	cs
	call	27C9h
	add	sp,6h
	mov	si,[bp-2h]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[55D6h]
	mov	es:[si+4036h],ax
	mov	es,[55D2h]
	mov	es:[si+4004h],ax
	mov	es,[55E0h]
	mov	word ptr es:[si+406Ah],0h
	jmp	0CA1h

l183B_0B40:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[55D4h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5600h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,36F6h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3731h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3774h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	al,[bp-0Eh]
	mov	es,[55D4h]
	mov	es:[si+0C79Dh],al
	mov	byte ptr es:[si+0C79Eh],0FFh
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[55D6h]
	push	word ptr es:[si+4036h]
	mov	es,[55D2h]
	push	word ptr es:[si+4004h]
	mov	ax,7Eh
	push	ax
	push	cs
	call	27C9h
	add	sp,6h
	jmp	0CA1h

l183B_0BD4:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	byte ptr es:[bx+0C79Eh],0FFh
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[55D6h]
	push	word ptr es:[si+4036h]
	mov	es,[55D2h]
	push	word ptr es:[si+4004h]
	mov	ax,7Eh
	push	ax
	push	cs
	call	27C9h
	add	sp,6h
	mov	ax,11h
	imul	word ptr [bp-44h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5600h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,37B8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,37FDh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	al,11h
	mul	byte ptr es:[bx+0C79Dh]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5600h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3830h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,387Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l183B_0CA1:
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	mov	ax,11h
	imul	word ptr [bp-44h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	byte ptr es:[bx+0C614h],0FFh
	sub	ax,ax
	mov	bx,[bp-44h]
	shl	bx,1h
	mov	es,[55E0h]
	mov	es:[bx+4072h],ax
	mov	es,[55D4h]
	mov	es:[0D333h],al
	mov	byte ptr es:[0D330h],7Fh

l183B_0CDB:
	mov	es,[55D4h]
	cmp	byte ptr es:[0D32Fh],0h
	jz	0D0Eh

l183B_0CE7:
	mov	es,[55E0h]
	cmp	word ptr es:[406Ah],0h
	jz	0D0Eh

l183B_0CF3:
	mov	es,[55D2h]
	cmp	word ptr es:[4004h],900h
	jle	0D0Eh

l183B_0D00:
	cmp	word ptr es:[4004h],0A07h
	jge	0D0Eh

l183B_0D09:
	mov	word ptr [bp-0Ch],1h

l183B_0D0E:
	mov	word ptr [bp-12h],1h
	mov	word ptr [bp-2Ch],0Ch

l183B_0D18:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55D2h]
	cmp	word ptr es:[si+4004h],0FFh
	jz	0D35h

l183B_0D29:
	mov	es,[55D6h]
	cmp	word ptr es:[si+4036h],0FFh
	jnz	0D45h

l183B_0D35:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55E0h]
	mov	word ptr es:[bx+406Ah],0h

l183B_0D45:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	0D5Bh

l183B_0D56:
	mov	word ptr [bp-12h],0h

l183B_0D5B:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],18h
	jl	0D18h

l183B_0D64:
	cmp	word ptr [bp-12h],0h
	jz	0D6Dh

l183B_0D6A:
	jmp	0EF6h

l183B_0D6D:
	mov	es,[55FAh]
	cmp	word ptr es:[374Ch],0h
	jnz	0D7Ch

l183B_0D79:
	jmp	0EF6h

l183B_0D7C:
	cmp	word ptr [bp+6h],0h
	jz	0D85h

l183B_0D82:
	jmp	0EF6h

l183B_0D85:
	mov	word ptr [bp-42h],0h
	mov	word ptr [bp-2Ch],0Ch

l183B_0D8F:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	0DA5h

l183B_0DA0:
	mov	word ptr [bp-42h],1h

l183B_0DA5:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],10h
	jl	0D8Fh

l183B_0DAE:
	cmp	word ptr [bp-42h],0h
	jnz	0DB7h

l183B_0DB4:
	jmp	0EB6h

l183B_0DB7:
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	[bp-3Ch],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	[bp-3Eh],ax
	mov	es,[55FAh]
	sub	ax,ax
	mov	es:[374Ch],ax
	mov	[bp-40h],ax
	mov	word ptr [bp-2Ch],10h

l183B_0DDF:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55E0h]
	cmp	word ptr es:[si+406Ah],0h
	jnz	0DF3h

l183B_0DF0:
	jmp	0E77h

l183B_0DF3:
	mov	es,[55D2h]
	mov	ax,es:[si+4004h]
	mov	es,[55CCh]
	mov	es:[0A44Bh],ax
	mov	es,[55D6h]
	mov	ax,es:[si+4036h]
	mov	es,[55CEh]
	mov	es:[0A44Dh],ax
	mov	ax,0Ch
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55DAh]
	mov	al,es:[bx+3800h]
	cbw
	mov	[bp-1Eh],ax
	mov	si,ax
	shl	si,1h
	mov	es,[55D6h]
	push	word ptr es:[si+4036h]
	mov	es,[55D2h]
	push	word ptr es:[si+4004h]
	call	far 1631h:0BB5h
	add	sp,4h
	cmp	ax,19h
	jle	0E77h

l183B_0E4D:
	mov	word ptr [bp-40h],1h
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55E0h]
	mov	word ptr es:[si+406Ah],0h
	mov	ax,0FFFFh
	mov	es,[55D6h]
	mov	es:[si+4036h],ax
	mov	es,[55D2h]
	mov	es:[si+4004h],ax

l183B_0E77:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],18h
	jge	0E83h

l183B_0E80:
	jmp	0DDFh

l183B_0E83:
	cmp	word ptr [bp-40h],0h
	jz	0EA0h

l183B_0E89:
	call	far 1CD3h:17C6h
	mov	ax,38BCh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h

l183B_0EA0:
	mov	es,[55CCh]
	mov	ax,[bp-3Ch]
	mov	es:[0A44Bh],ax
	mov	es,[55CEh]
	mov	ax,[bp-3Eh]
	mov	es:[0A44Dh],ax

l183B_0EB6:
	mov	es,[55FAh]
	cmp	word ptr es:[374Ch],0h
	jz	0ED2h

l183B_0EC2:
	call	far 207Fh:0BC0h
	and	ax,1h
	mov	es,[55FAh]
	mov	es:[374Ch],ax

l183B_0ED2:
	cmp	word ptr es:[374Ch],0h
	jz	0EF6h

l183B_0EDA:
	mov	word ptr [bp-12h],1h
	call	far 1CD3h:17C6h
	mov	ax,38E0h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h

l183B_0EF6:
	cmp	word ptr [bp+6h],1h
	jnz	0F0Dh

l183B_0EFC:
	mov	es,[55E0h]
	cmp	word ptr es:[406Ah],0h
	jnz	0F0Dh

l183B_0F08:
	mov	word ptr [bp-12h],1h

l183B_0F0D:
	cmp	word ptr [bp-0Ch],0h
	jnz	0F36h

l183B_0F13:
	cmp	word ptr [bp+6h],2h
	jnz	0F36h

l183B_0F19:
	mov	es,[55E0h]
	cmp	word ptr es:[406Ah],0h
	jnz	0F36h

l183B_0F25:
	mov	es,[55D4h]
	cmp	byte ptr es:[0D32Fh],0h
	jnz	0F36h

l183B_0F31:
	mov	word ptr [bp-12h],1h

l183B_0F36:
	cmp	word ptr [bp-0Ch],0h
	jz	0F41h

l183B_0F3C:
	mov	word ptr [bp-12h],1h

l183B_0F41:
	mov	es,[55FCh]
	cmp	word ptr es:[014Ah],0h
	jnz	0F52h

l183B_0F4D:
	mov	word ptr [bp-12h],1h

l183B_0F52:
	mov	es,[55EEh]
	cmp	word ptr es:[3772h],0h
	jnz	0F61h

l183B_0F5E:
	jmp	0FFDh

l183B_0F61:
	mov	word ptr [bp-4h],1h
	cmp	word ptr [bp-12h],0h
	jnz	0F6Fh

l183B_0F6C:
	jmp	0FF0h

l183B_0F6F:
	mov	ax,5h
	sub	ax,[bp-8h]
	mov	[bp-4h],ax
	jmp	0FF0h

l183B_0F7A:
	cmp	word ptr [bp-8h],5h
	jge	0FF0h

l183B_0F80:
	cmp	word ptr [bp-8h],1h
	jnz	0F96h

l183B_0F86:
	mov	ax,1h
	push	ax
	mov	ax,2h
	push	ax
	call	far 0800h:48B7h
	add	sp,4h

l183B_0F96:
	call	far 1CD3h:17C6h
	mov	bx,[bp-8h]
	inc	word ptr [bp-8h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+3A30h]
	push	word ptr [bx+3A2Eh]
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	cmp	word ptr [bp-8h],3h
	jnz	0FDFh

l183B_0FC0:
	mov	ax,0Bh
	push	ax
	mov	ax,4h
	push	ax
	call	far 0800h:2DA8h
	add	sp,4h
	call	far 207Fh:1DA8h
	mov	es,[5604h]
	mov	byte ptr es:[00FCh],0Bh

l183B_0FDF:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h

l183B_0FF0:
	mov	ax,[bp-4h]
	dec	word ptr [bp-4h]
	or	ax,ax
	jz	0FFDh

l183B_0FFA:
	jmp	0F7Ah

l183B_0FFD:
	mov	es,[55F0h]
	cmp	word ptr es:[009Eh],0h
	jz	102Eh

l183B_1009:
	mov	es,[5606h]
	cmp	word ptr es:[3938h],0h
	jnz	102Eh

l183B_1015:
	call	far 1F3Dh:002Fh
	or	ax,ax
	jz	102Eh

l183B_101E:
	mov	es,[55F0h]
	mov	word ptr es:[009Eh],0h
	call	far 0800h:2A2Bh

l183B_102E:
	cmp	word ptr [bp-12h],0h
	jnz	1037h

l183B_1034:
	jmp	056Bh

l183B_1037:
	cmp	word ptr [bp-0Ah],0h
	jnz	1040h

l183B_103D:
	jmp	140Dh

l183B_1040:
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	cmp	word ptr [bp+6h],1h
	jl	1060h

l183B_1057:
	cmp	word ptr [bp+6h],3h
	jz	1060h

l183B_105D:
	jmp	136Dh

l183B_1060:
	cmp	word ptr [bp-6h],0h
	jnz	1069h

l183B_1066:
	jmp	12BFh

l183B_1069:
	cmp	word ptr [bp-38h],0h
	jz	1072h

l183B_106F:
	jmp	12BFh

l183B_1072:
	mov	es,[55FCh]
	cmp	word ptr es:[014Ah],0h
	jnz	1081h

l183B_107E:
	jmp	12BFh

l183B_1081:
	mov	ax,1h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,1h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	call	far 1E56h:0388h
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0Ch

l183B_10A8:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55DEh]
	cmp	word ptr es:[bx+393Ch],0h
	jz	10BEh

l183B_10B9:
	mov	word ptr [bp-3Ah],1h

l183B_10BE:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],18h
	jl	10A8h

l183B_10C7:
	cmp	word ptr [bp-3Ah],0h
	jz	10DFh

l183B_10CD:
	mov	ax,38FCh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh

l183B_10DF:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0h

l183B_10E9:
	mov	ax,7Dh
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	1102h

l183B_10FD:
	mov	word ptr [bp-3Ah],1h

l183B_1102:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],4h
	jl	10E9h

l183B_110B:
	cmp	word ptr [bp-3Ah],0h
	jz	117Ch

l183B_1111:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0Ch

l183B_111B:
	mov	bx,[bp-2Ch]
	shl	bx,1h
	mov	es,[55DEh]
	cmp	word ptr es:[bx+393Ch],0h
	jz	1131h

l183B_112C:
	mov	word ptr [bp-3Ah],1h

l183B_1131:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],10h
	jl	111Bh

l183B_113A:
	cmp	word ptr [bp-3Ah],0h
	jz	117Ch

l183B_1140:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0h

l183B_114A:
	mov	ax,11h
	imul	word ptr [bp-2Ch]
	mov	si,ax
	mov	es,[55D4h]
	mov	al,es:[si+0C614h]
	cbw
	cmp	ax,0FFh
	jz	1173h

l183B_1161:
	cmp	byte ptr es:[si+0C61Dh],0h
	jz	1173h

l183B_1169:
	call	far 0DABh:0002h
	mov	word ptr [bp-2Ch],8h

l183B_1173:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],8h
	jl	114Ah

l183B_117C:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0h

l183B_1186:
	mov	si,[bp-2Ch]
	shl	si,1h
	mov	es,[55DEh]
	cmp	word ptr es:[si+393Ch],0h
	jnz	119Fh

l183B_1197:
	cmp	word ptr es:[si+3954h],0h
	jz	11A4h

l183B_119F:
	mov	word ptr [bp-3Ah],1h

l183B_11A4:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],4h
	jl	1186h

l183B_11AD:
	cmp	word ptr [bp-3Ah],0h
	jnz	11B6h

l183B_11B3:
	jmp	1251h

l183B_11B6:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0h

l183B_11C0:
	mov	ax,11h
	imul	word ptr [bp-2Ch]
	mov	si,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	11E9h

l183B_11D4:
	cmp	byte ptr es:[si+0C61Ch],0h
	jz	11E9h

l183B_11DC:
	cmp	byte ptr es:[si+0C620h],8h
	jl	11E9h

l183B_11E4:
	mov	word ptr [bp-3Ah],1h

l183B_11E9:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],8h
	jl	11C0h

l183B_11F2:
	cmp	word ptr [bp-3Ah],0h
	jz	1224h

l183B_11F8:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0h

l183B_1202:
	mov	ax,7Dh
	imul	word ptr [bp-2Ch]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jnz	121Bh

l183B_1216:
	mov	word ptr [bp-3Ah],1h

l183B_121B:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],4h
	jl	1202h

l183B_1224:
	cmp	word ptr [bp-3Ah],0h
	jz	1251h

l183B_122A:
	mov	word ptr [bp-2Ch],0h

l183B_122F:
	mov	si,[bp-2Ch]
	test	byte ptr [bp+si-1Ch],80h
	jz	123Dh

l183B_1238:
	mov	word ptr [bp-3Ah],0h

l183B_123D:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],9h
	jl	122Fh

l183B_1246:
	cmp	word ptr [bp-3Ah],0h
	jz	1251h

l183B_124C:
	call	far 0DABh:04F9h

l183B_1251:
	call	far 0DABh:094Bh
	mov	es,[55D4h]
	mov	byte ptr es:[0D335h],0h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-2Ch],0h

l183B_127B:
	mov	ax,11h
	imul	word ptr [bp-2Ch]
	mov	si,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	12A3h

l183B_128F:
	mov	al,es:[si+0C623h]
	cbw
	mov	cx,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	sub	ax,cx
	add	[bp-3Ah],ax

l183B_12A3:
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],8h
	jl	127Bh

l183B_12AC:
	cmp	word ptr [bp-3Ah],0h
	jz	12E2h

l183B_12B2:
	sub	ax,ax
	push	ax
	call	far 1431h:000Ah
	add	sp,2h
	jmp	12E2h

l183B_12BF:
	mov	es,[55FCh]
	cmp	word ptr es:[014Ah],0h
	jz	12E2h

l183B_12CB:
	call	far 1E56h:0388h
	mov	ax,3936h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh

l183B_12E2:
	mov	es,[55FCh]
	cmp	word ptr es:[014Ah],0h
	jnz	12F1h

l183B_12EE:
	jmp	141Ah

l183B_12F1:
	cmp	word ptr [bp+6h],1h
	jl	1300h

l183B_12F7:
	cmp	word ptr [bp+6h],3h
	jz	1300h

l183B_12FD:
	jmp	141Ah

l183B_1300:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,1h
	push	ax
	call	far 0800h:4CACh
	add	sp,2h
	call	far 1CD3h:17C6h
	mov	ax,3954h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A2Bh
	call	far 1F3Dh:0259h
	push	word ptr [bp-36h]
	push	word ptr [bp-32h]
	call	far 0800h:17BBh
	add	sp,4h
	push	cs
	call	2835h
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	jmp	141Ah

l183B_136D:
	mov	es,[55FCh]
	cmp	word ptr es:[014Ah],0h
	jnz	137Ch

l183B_1379:
	jmp	141Ah

l183B_137C:
	mov	es,[55EEh]
	cmp	word ptr es:[3772h],0h
	jnz	13E2h

l183B_1388:
	cmp	word ptr [bp+6h],1h
	jnz	13A7h

l183B_138E:
	call	far 1CD3h:17C6h
	mov	ax,398Bh

l183B_1396:
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h

l183B_13A0:
	call	far 1F3Dh:0259h
	jmp	141Ah

l183B_13A7:
	cmp	word ptr [bp-0Ch],0h
	jnz	141Ah

l183B_13AD:
	call	far 1CD3h:17C6h
	mov	es,[55D4h]
	mov	byte ptr es:[0D32Dh],1h
	cmp	byte ptr es:[0C724h],0FFh
	jz	13C9h

l183B_13C4:
	mov	ax,39AAh
	jmp	1396h

l183B_13C9:
	mov	ax,39CAh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	mov	es,[55D4h]
	mov	byte ptr es:[0D32Dh],0h
	jmp	13A0h

l183B_13E2:
	cmp	word ptr [bp-38h],2h
	jnz	141Ah

l183B_13E8:
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,39F7h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh
	jmp	141Ah

l183B_140D:
	push	word ptr [bp-36h]
	push	word ptr [bp-32h]
	push	cs
	call	2AA3h
	add	sp,4h

l183B_141A:
	mov	word ptr [bp-26h],0h

l183B_141F:
	mov	ax,1Ah
	imul	word ptr [bp-26h]
	mov	si,ax
	mov	di,[bp-26h]
	shl	di,1h
	mov	es,[55D4h]
	mov	ax,es:[si+0D390h]
	mov	es,[55D2h]
	mov	es:[di+4024h],ax
	mov	es,[55D4h]
	mov	ax,es:[si+0D392h]
	mov	es,[55D6h]
	mov	es:[di+4056h],ax
	mov	al,0FFh
	mov	bx,[bp-26h]
	mov	es,[5608h]
	mov	es:[bx+397Ch],al
	mov	bx,[bp-26h]
	mov	es:[bx+396Ch],al
	mov	bx,[bp-26h]
	mov	es,[560Ah]
	mov	byte ptr es:[bx+40AAh],10h
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],8h
	jl	141Fh

l183B_147C:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn183B_1482: 183B:1482
;;   Called from:
;;     183B:07D3 (in fn183B_000A)
;;     183B:084C (in fn183B_000A)
fn183B_1482 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0h

l183B_1493:
	mov	si,[bp-2h]
	add	si,[bp+6h]
	mov	bx,si
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	14B5h

l183B_14A9:
	sub	ax,ax
	push	ax
	push	si
	call	far 1631h:03ABh
	add	sp,4h

l183B_14B5:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],0Ch
	jl	1493h

l183B_14BE:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn183B_14C3: 183B:14C3
;;   Called from:
;;     183B:0605 (in fn183B_000A)
fn183B_14C3 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ch
	call	far 207Fh:2FDCh
	push	si
	mov	ax,1h
	mov	[bp-4h],ax
	mov	[bp-0Ch],ax
	mov	word ptr [bp-0Ah],0h
	jmp	14E2h

l183B_14DF:
	inc	word ptr [bp-0Ah]

l183B_14E2:
	cmp	word ptr [bp-0Ah],0Ch
	jge	14F9h

l183B_14E8:
	mov	bx,[bp-0Ah]
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	14DFh

l183B_14F9:
	sub	ax,ax
	mov	[bp-2h],ax
	mov	[bp-6h],ax
	mov	es,[55F2h]
	cmp	es:[0090h],ax
	jnz	150Fh

l183B_150C:
	jmp	1763h

l183B_150F:
	mov	bx,[bp-0Ah]
	mov	es,[55E6h]
	mov	byte ptr es:[bx+3994h],0h
	jmp	1763h

l183B_151F:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	push	ax
	push	word ptr [bp-0Ah]
	call	far 0DABh:18E8h
	add	sp,6h
	mov	es,[55ECh]
	mov	word ptr es:[37FEh],0Fh
	mov	bx,[bp-0Ah]
	mov	es,[55E6h]
	cmp	byte ptr es:[bx+3994h],0h
	jz	1574h

l183B_1559:
	mov	ax,3A42h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	word ptr [bp-0Ah]
	call	far 1631h:03ABh
	jmp	157Fh

l183B_1574:
	mov	ax,1h
	push	ax
	push	word ptr [bp-0Ah]
	push	cs
	call	1774h

l183B_157F:
	add	sp,4h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[55ECh]
	mov	word ptr es:[37FEh],0Fh
	cmp	word ptr [bp-0Ah],4h
	jge	15BEh

l183B_15A4:
	mov	ax,3A6Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[560Ch]
	mov	word ptr es:[00C6h],0Ah
	jmp	15D6h

l183B_15BE:
	mov	ax,3ABCh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[560Ch]
	mov	word ptr es:[00C6h],8h

l183B_15D6:
	cmp	word ptr [bp-4h],0h
	jz	15EAh

l183B_15DC:
	mov	ax,es:[00C6h]
	dec	ax
	mov	es:[00C8h],ax
	mov	word ptr [bp-4h],0h

l183B_15EA:
	call	far 0800h:2A2Bh
	mov	ax,3h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-0Ch],ax
	mov	es,[560Ch]
	mov	si,es:[00C6h]
	sub	si,2h
	cmp	ax,si
	jl	161Ah

l183B_160E:
	inc	word ptr [bp-6h]
	cmp	ax,si
	jnz	161Ah

l183B_1615:
	mov	word ptr [bp-2h],1h

l183B_161A:
	cmp	word ptr [bp-0Ah],4h
	jge	1626h

l183B_1620:
	cmp	word ptr [bp-0Ch],3h
	jl	1632h

l183B_1626:
	cmp	word ptr [bp-0Ah],4h
	jl	163Fh

l183B_162C:
	cmp	word ptr [bp-0Ch],0h
	jnz	163Fh

l183B_1632:
	push	word ptr [bp-0Ch]
	push	word ptr [bp-0Ah]
	push	cs
	call	1C1Fh
	add	sp,4h

l183B_163F:
	cmp	word ptr [bp-0Ah],4h
	jl	1688h

l183B_1645:
	cmp	word ptr [bp-0Ch],1h
	jnz	1688h

l183B_164B:
	mov	word ptr [bp-8h],0h

l183B_1650:
	mov	ax,30h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	add	bx,[bp-8h]
	mov	es,[55DCh]
	mov	byte ptr es:[bx+32C6h],0FFh
	inc	word ptr [bp-8h]
	cmp	word ptr [bp-8h],30h
	jl	1650h

l183B_166E:
	mov	bx,[bp-0Ah]
	mov	es,[55E6h]
	mov	byte ptr es:[bx+3994h],0h
	sub	ax,ax
	push	ax
	push	word ptr [bp-0Ah]
	push	cs
	call	1774h
	add	sp,4h

l183B_1688:
	cmp	word ptr [bp-0Ah],4h
	jge	169Eh

l183B_168E:
	cmp	word ptr [bp-0Ch],4h
	jnz	169Eh

l183B_1694:
	push	word ptr [bp-0Ah]
	push	cs
	call	2231h
	add	sp,2h

l183B_169E:
	cmp	word ptr [bp-0Ah],4h
	jge	16AAh

l183B_16A4:
	cmp	word ptr [bp-0Ch],5h
	jz	16B6h

l183B_16AA:
	cmp	word ptr [bp-0Ah],4h
	jl	16D1h

l183B_16B0:
	cmp	word ptr [bp-0Ch],3h
	jnz	16D1h

l183B_16B6:
	mov	es,[55F2h]
	cmp	word ptr es:[0090h],0h
	jnz	16D1h

l183B_16C2:
	mov	ax,1h
	push	ax
	push	word ptr [bp-0Ah]
	call	far 1631h:03ABh
	add	sp,4h

l183B_16D1:
	cmp	word ptr [bp-0Ah],4h
	jge	16DDh

l183B_16D7:
	cmp	word ptr [bp-0Ch],3h
	jz	16E9h

l183B_16DD:
	cmp	word ptr [bp-0Ah],4h
	jl	16F4h

l183B_16E3:
	cmp	word ptr [bp-0Ch],2h
	jnz	16F4h

l183B_16E9:
	push	word ptr [bp-0Ah]
	call	far 1543h:0004h
	add	sp,2h

l183B_16F4:
	cmp	word ptr [bp-0Ah],4h
	jge	1700h

l183B_16FA:
	cmp	word ptr [bp-0Ch],6h
	jz	170Ch

l183B_1700:
	cmp	word ptr [bp-0Ah],4h
	jl	1716h

l183B_1706:
	cmp	word ptr [bp-0Ch],4h
	jnz	1716h

l183B_170C:
	push	word ptr [bp-0Ah]
	push	cs
	call	2591h
	add	sp,2h

l183B_1716:
	mov	es,[560Ch]
	mov	ax,es:[00C6h]
	sub	ax,3h
	cmp	ax,[bp-0Ch]
	jnz	1763h

l183B_1726:
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],0Bh
	jle	1734h

l183B_172F:
	mov	word ptr [bp-0Ah],0h

l183B_1734:
	mov	bx,[bp-0Ah]
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	1726h

l183B_1745:
	cmp	word ptr [bp-0Ah],4h
	jl	1758h

l183B_174B:
	mov	es,[560Ch]
	mov	word ptr es:[00C8h],5h
	jmp	1763h

l183B_1758:
	mov	es,[560Ch]
	mov	word ptr es:[00C8h],7h

l183B_1763:
	cmp	word ptr [bp-6h],0h
	jnz	176Ch

l183B_1769:
	jmp	151Fh

l183B_176C:
	mov	ax,[bp-2h]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn183B_1774: 183B:1774
;;   Called from:
;;     0DAB:1617 (in fn0DAB_1467)
;;     1543:0158 (in fn1543_0004)
;;     1543:0604 (in fn1543_0004)
;;     1543:0840 (in fn1543_07CB)
;;     1631:0B99 (in fn1631_03AB)
;;     183B:157B (in fn183B_14C3)
;;     183B:1681 (in fn183B_14C3)
;;     183B:1C6B (in fn183B_1C1F)
;;     183B:1DDE (in fn183B_1C1F)
;;     183B:21DC (in fn183B_1C1F)
fn183B_1774 proc
	push	bp
	mov	bp,sp
	mov	ax,26h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[55D2h]
	mov	ax,es:[si+4004h]
	mov	[bp-6h],ax
	mov	es,[55D6h]
	mov	ax,es:[si+4036h]
	mov	[bp-0Ah],ax
	cmp	word ptr [bp+8h],0h
	jz	17D4h

l183B_17A4:
	push	ax
	push	word ptr [bp-6h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:0E4Bh

l183B_17D4:
	mov	word ptr [bp-6h],1h
	sub	ax,ax
	mov	[bp-4h],ax
	mov	[bp-2h],ax
	cmp	word ptr [bp+6h],4h
	jl	17F3h

l183B_17E7:
	cmp	word ptr [bp+6h],0Ch
	jl	1802h

l183B_17ED:
	cmp	word ptr [bp+6h],0Fh
	jg	1802h

l183B_17F3:
	mov	word ptr [bp-6h],3h
	mov	word ptr [bp-2h],0FFFFh
	mov	word ptr [bp-4h],0FFFEh

l183B_1802:
	call	far 1F3Dh:06C3h
	mov	es,[560Eh]
	mov	word ptr es:[0B782h],1h
	mov	word ptr [bp-8h],0h
	jmp	183Ch

l183B_1819:
	mov	ax,0Fh
	push	ax
	push	word ptr [bp-6h]
	mov	ax,[bp-8h]
	add	ax,[bp-4h]
	add	ax,0Ch
	push	ax
	mov	ax,[bp-2h]
	add	ax,1Ah
	push	ax
	call	far 207Fh:2B87h
	add	sp,8h
	inc	word ptr [bp-8h]

l183B_183C:
	mov	ax,[bp-6h]
	cmp	[bp-8h],ax
	jl	1819h

l183B_1844:
	cmp	word ptr [bp+6h],0Ch
	jl	184Dh

l183B_184A:
	jmp	1935h

l183B_184D:
	cmp	word ptr [bp+6h],4h
	jge	1872h

l183B_1853:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55DCh]
	mov	al,es:[bx+32C6h]
	cbw
	push	ax
	push	word ptr [bp+6h]
	push	cs
	call	22BCh
	add	sp,4h
	jmp	187Ch

l183B_1872:
	push	word ptr [bp+6h]
	push	cs
	call	2474h
	add	sp,2h

l183B_187C:
	push	word ptr [bp+6h]
	push	cs
	call	193Bh
	add	sp,2h
	sub	ax,ax
	mov	[bp-8h],ax
	mov	[bp-0Dh],al
	mov	word ptr [bp-6h],1Ah
	mov	word ptr [bp-0Ah],0Ch
	jmp	1903h

l183B_189A:
	cmp	word ptr [bp-8h],18h
	jge	191Fh

l183B_18A0:
	mov	bx,[bp-8h]
	inc	word ptr [bp-8h]
	add	bx,si
	mov	es,[55D8h]
	mov	al,es:[bx+40B4h]
	cbw
	mov	[bp-2h],ax
	mov	bx,[bp-8h]
	inc	word ptr [bp-8h]
	add	bx,si
	mov	al,es:[bx+40B4h]
	cbw
	mov	[bp-4h],ax
	mov	ax,[bp-2h]
	add	[bp-6h],ax
	mov	ax,[bp-4h]
	add	[bp-0Ah],ax
	inc	word ptr [bp-4h]
	mov	di,[bp-4h]
	shl	di,1h
	shl	di,1h
	inc	word ptr [bp-2h]
	mov	bx,[bp-2h]
	mov	al,[bx+di+3B06h]
	mov	[bp-0Eh],al
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-6h]
	lea	ax,[bp-0Eh]
	push	ss
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch

l183B_1903:
	mov	ax,18h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-8h]
	add	bx,si
	mov	es,[55D8h]
	cmp	byte ptr es:[bx+40B4h],2h
	jz	191Fh

l183B_191C:
	jmp	189Ah

l183B_191F:
	mov	es,[5610h]
	mov	ax,[bp-6h]
	mov	es:[3778h],ax
	mov	es,[5612h]
	mov	ax,[bp-0Ah]
	mov	es:[377Ah],ax

l183B_1935:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn183B_193B: 183B:193B
;;   Called from:
;;     1631:0B7E (in fn1631_03AB)
;;     183B:078C (in fn183B_000A)
;;     183B:187F (in fn183B_1774)
;;     183B:1E3D (in fn183B_1C1F)
fn183B_193B proc
	push	bp
	mov	bp,sp
	mov	ax,2Ah
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-20h],0h

l183B_194D:
	mov	ax,18h
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-20h]
	mov	es,[55D8h]
	mov	byte ptr es:[bx+40B4h],2h
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],18h
	jl	194Dh

l183B_196B:
	sub	ax,ax
	mov	[bp-26h],ax
	mov	[bp-12h],ax
	mov	[bp-20h],ax
	mov	[bp-0Ch],ax
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	es,[5614h]
	mov	es:[0E486h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	es,[5616h]
	mov	es:[0E488h],ax
	mov	word ptr [bp-8h],1Ah
	mov	word ptr [bp-0Eh],0Ch
	mov	bx,[bp+6h]
	mov	es,[55E4h]
	mov	al,es:[bx+3920h]
	cbw
	mov	[bp-0Ah],ax
	jmp	1C01h

l183B_19B6:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	ax,[bp-20h]
	inc	word ptr [bp-20h]
	add	bx,ax
	mov	es,[55DCh]
	mov	al,es:[bx+32C6h]
	cbw
	mov	[bp-1Ah],ax
	inc	ax
	jnz	19DCh

l183B_19D6:
	inc	word ptr [bp-0Ch]
	jmp	1C01h

l183B_19DC:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-20h]
	inc	word ptr [bp-20h]
	add	bx,si
	mov	al,es:[bx+32C6h]
	sub	ah,ah
	mov	ch,al
	sub	cl,cl
	mov	[bp-4h],cx
	mov	bx,[bp-20h]
	inc	word ptr [bp-20h]
	add	bx,si
	mov	al,es:[bx+32C6h]
	cbw
	and	cx,0F00h
	or	ax,cx
	mov	[bp-14h],ax
	mov	bx,[bp-20h]
	inc	word ptr [bp-20h]
	add	bx,si
	mov	al,es:[bx+32C6h]
	cbw
	mov	cx,[bp-4h]
	and	cx,0F000h
	or	ax,cx
	mov	[bp-1Ch],ax
	mov	word ptr [bp-24h],0h
	cmp	word ptr [bp+6h],0Ch
	jge	1A4Ah

l183B_1A36:
	mov	bx,[bp+6h]
	mov	es,[55E6h]
	cmp	byte ptr es:[bx+3994h],0h
	jnz	1A4Ah

l183B_1A45:
	mov	word ptr [bp-24h],1h

l183B_1A4A:
	cmp	word ptr [bp-0Ah],0FFh
	jnz	1A55h

l183B_1A50:
	mov	word ptr [bp-24h],1h

l183B_1A55:
	cmp	word ptr [bp-24h],0h
	jz	1A87h

l183B_1A5B:
	push	word ptr [bp-1Ch]
	push	word ptr [bp-14h]
	mov	es,[5616h]
	push	word ptr es:[0E488h]
	mov	es,[5614h]
	push	word ptr es:[0E486h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	bx,[bp+6h]
	mov	es,[55E4h]
	mov	es:[bx+3920h],al

l183B_1A87:
	mov	es,[5618h]
	mov	word ptr es:[0D57Eh],0h
	jmp	1BF2h

l183B_1A95:
	mov	es,[5614h]
	mov	ax,[bp-14h]
	cmp	es:[0E486h],ax
	jnz	1AB4h

l183B_1AA3:
	mov	es,[5616h]
	mov	ax,[bp-1Ch]
	cmp	es:[0E488h],ax
	jnz	1AB4h

l183B_1AB1:
	jmp	1C01h

l183B_1AB4:
	mov	es,[5618h]
	cmp	word ptr es:[0D57Eh],0h
	jz	1AC3h

l183B_1AC0:
	jmp	1C01h

l183B_1AC3:
	sub	ax,ax
	push	ax
	push	word ptr [bp-0Eh]
	push	word ptr [bp-8h]
	push	word ptr [bp-1Ch]
	push	word ptr [bp-14h]
	push	word ptr [bp+6h]
	call	far 1631h:0006h
	add	sp,0Ch
	mov	es,[561Ch]
	mov	ax,es:[458Eh]
	add	[bp-8h],ax
	mov	es,[561Eh]
	mov	ax,es:[4590h]
	add	[bp-0Eh],ax
	mov	ax,18h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[561Ch]
	mov	al,es:[458Eh]
	mov	bx,[bp-12h]
	inc	word ptr [bp-12h]
	add	bx,si
	mov	es,[55D8h]
	mov	es:[bx+40B4h],al
	mov	es,[561Eh]
	mov	al,es:[4590h]
	mov	bx,[bp-12h]
	inc	word ptr [bp-12h]
	add	bx,si
	mov	es,[55D8h]
	mov	es:[bx+40B4h],al
	mov	ax,[bp-0Eh]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	cx,[bp-8h]
	sub	cx,0Dh
	sar	cx,1h
	add	ax,cx
	mov	[bp-10h],ax
	mov	di,[bp-0Eh]
	and	di,1h
	shl	di,1h
	mov	bx,[bp-8h]
	and	bx,1h
	mov	al,[bx+di+3B12h]
	cbw
	mov	[bp-28h],ax
	test	byte ptr [bp-8h],1h
	jz	1B73h

l183B_1B60:
	mov	es,[55CCh]
	test	byte ptr es:[0A44Bh],1h
	jz	1B73h

l183B_1B6C:
	inc	word ptr [bp-10h]
	xor	byte ptr [bp-28h],0Ah

l183B_1B73:
	test	byte ptr [bp-0Eh],1h
	jz	1B8Dh

l183B_1B79:
	mov	es,[55CEh]
	test	byte ptr es:[0A44Dh],1h
	jz	1B8Dh

l183B_1B85:
	add	word ptr [bp-10h],18h
	xor	byte ptr [bp-28h],5h

l183B_1B8D:
	mov	es,[5620h]
	mov	bx,es:[09EDh]
	add	bx,[bp-10h]
	mov	es,[5622h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-18h],ax
	mov	word ptr [bp-2h],1h
	cmp	word ptr [bp-1Ah],2h
	jz	1BDDh

l183B_1BB2:
	cmp	ax,40h
	jge	1BDDh

l183B_1BB7:
	and	ax,0F0h
	mov	[bp-6h],ax
	mov	ax,[bp-28h]
	test	[bp-18h],ax
	jz	1BCAh

l183B_1BC5:
	mov	word ptr [bp-2h],2h

l183B_1BCA:
	cmp	word ptr [bp-6h],20h
	jnz	1BDDh

l183B_1BD0:
	mov	ax,[bp-28h]
	test	[bp-18h],ax
	jz	1BDDh

l183B_1BD8:
	mov	word ptr [bp-2h],3h

l183B_1BDD:
	mov	es,[561Ah]
	mov	ax,[bp-2h]
	sub	es:[3770h],ax
	jns	1BF2h

l183B_1BEB:
	mov	word ptr es:[3770h],0h

l183B_1BF2:
	mov	es,[561Ah]
	cmp	word ptr es:[3770h],0h
	jle	1C01h

l183B_1BFE:
	jmp	1A95h

l183B_1C01:
	cmp	word ptr [bp-0Ch],0h
	jnz	1C0Ah

l183B_1C07:
	jmp	19B6h

l183B_1C0A:
	mov	al,[bp-0Ah]
	mov	bx,[bp+6h]
	mov	es,[55E4h]
	mov	es:[bx+3920h],al
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn183B_1C1F: 183B:1C1F
;;   Called from:
;;     183B:1638 (in fn183B_14C3)
fn183B_1C1F proc
	push	bp
	mov	bp,sp
	mov	ax,36h
	call	far 207Fh:2FDCh
	push	di
	push	si
	cmp	word ptr [bp+6h],0Ch
	jge	1C7Fh

l183B_1C32:
	mov	bx,[bp+6h]
	mov	es,[55E6h]
	cmp	byte ptr es:[bx+3994h],0h
	jz	1C72h

l183B_1C41:
	mov	word ptr [bp-1Ch],0h

l183B_1C46:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-1Ch]
	mov	es,[55DCh]
	mov	byte ptr es:[bx+32C6h],0FFh
	inc	word ptr [bp-1Ch]
	cmp	word ptr [bp-1Ch],30h
	jl	1C46h

l183B_1C64:
	mov	ax,1h
	push	ax
	push	word ptr [bp+6h]
	push	cs
	call	1774h
	add	sp,4h

l183B_1C72:
	mov	bx,[bp+6h]
	mov	es,[55E6h]
	mov	byte ptr es:[bx+3994h],0h

l183B_1C7F:
	mov	word ptr [bp-0Ch],1h
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55DCh]
	mov	al,es:[bx+32C6h]
	cbw
	mov	[bp-0Eh],ax
	cmp	word ptr [bp+6h],4h
	jl	1CA2h

l183B_1C9F:
	jmp	1DEAh

l183B_1CA2:
	cmp	ax,0FFFFh
	jnz	1CAAh

l183B_1CA7:
	jmp	1DEAh

l183B_1CAA:
	cmp	word ptr [bp+8h],2h
	jnz	1CC7h

l183B_1CB0:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C756h],0h
	jnz	1CC7h

l183B_1CC4:
	jmp	1DEAh

l183B_1CC7:
	mov	ax,[bp+8h]
	cmp	[bp-0Eh],ax
	jnz	1CD2h

l183B_1CCF:
	jmp	1DEAh

l183B_1CD2:
	dec	word ptr [bp-0Ch]
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3B24h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-0Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+3CD6h]
	push	word ptr [bx+3CD4h]
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	cmp	word ptr [bp-0Eh],1h
	jnz	1D2Dh

l183B_1D18:
	mov	ax,3B36h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h

l183B_1D2D:
	mov	ax,3B38h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3B3Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp+8h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+3CD6h]
	push	word ptr [bx+3CD4h]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3B4Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jz	1DEAh

l183B_1D93:
	inc	word ptr [bp-0Ch]
	call	far 1E56h:0388h
	mov	ax,3B58h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3B8Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-0Ah],0h

l183B_1DBA:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Ah]
	mov	es,[55DCh]
	mov	byte ptr es:[bx+32C6h],0FFh
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],30h
	jl	1DBAh

l183B_1DD8:
	sub	ax,ax
	push	ax
	push	word ptr [bp+6h]
	push	cs
	call	1774h
	add	sp,4h
	call	far 1F3Dh:0259h

l183B_1DEA:
	cmp	word ptr [bp-0Ch],0h
	jnz	1DF3h

l183B_1DF0:
	jmp	2226h

l183B_1DF3:
	mov	word ptr [bp-0Ah],0h
	jmp	1DFEh

l183B_1DFA:
	add	word ptr [bp-0Ah],4h

l183B_1DFE:
	cmp	word ptr [bp-0Ah],30h
	jge	1E1Bh

l183B_1E04:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Ah]
	mov	es,[55DCh]
	cmp	byte ptr es:[bx+32C6h],0FFh
	jnz	1DFAh

l183B_1E1B:
	cmp	word ptr [bp+6h],4h
	jge	1E30h

l183B_1E21:
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	push	cs
	call	22BCh
	add	sp,4h
	jmp	1E3Ah

l183B_1E30:
	push	word ptr [bp+6h]
	push	cs
	call	2474h
	add	sp,2h

l183B_1E3A:
	push	word ptr [bp+6h]
	push	cs
	call	193Bh
	add	sp,2h
	mov	es,[5610h]
	mov	ax,es:[3778h]
	mov	[bp-16h],ax
	mov	es,[5612h]
	mov	ax,es:[377Ah]
	mov	[bp-1Ah],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[561Ah]
	cmp	word ptr es:[3770h],0h
	jz	1E7Ah

l183B_1E77:
	jmp	1F94h

l183B_1E7A:
	cmp	word ptr [bp+8h],2h
	jnz	1EA4h

l183B_1E80:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C756h],0h
	jnz	1EA4h

l183B_1E94:
	mov	ax,3BADh

l183B_1E97:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	1F8Ch

l183B_1EA4:
	cmp	word ptr [bp+6h],4h
	jge	1EBEh

l183B_1EAA:
	mov	bx,[bp+6h]
	mov	es,[55EAh]
	cmp	byte ptr es:[bx+6Eh],1Eh
	jnz	1EBEh

l183B_1EB9:
	mov	ax,3BCAh
	jmp	1E97h

l183B_1EBE:
	cmp	word ptr [bp+6h],4h
	jl	1EDCh

l183B_1EC4:
	cmp	word ptr [bp+6h],0Ch
	jge	1EDCh

l183B_1ECA:
	mov	es,[5624h]
	sub	ax,ax
	mov	es:[4592h],ax
	mov	es,[5626h]
	mov	es:[377Ch],ax

l183B_1EDC:
	mov	es,[5626h]
	cmp	word ptr es:[377Ch],0h
	jnz	1EF4h

l183B_1EE8:
	mov	es,[5624h]
	cmp	word ptr es:[4592h],0h
	jz	1F23h

l183B_1EF4:
	mov	ax,3BF3h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5626h]
	cmp	word ptr es:[377Ch],0h
	jz	1F12h

l183B_1F0D:
	mov	ax,3C0Dh
	jmp	1F70h

l183B_1F12:
	mov	es,[5624h]
	cmp	word ptr es:[4592h],0h
	jz	1F7Ah

l183B_1F1E:
	mov	ax,3C1Ah
	jmp	1F70h

l183B_1F23:
	mov	ax,3C33h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp+6h],4h
	jge	1F47h

l183B_1F36:
	mov	bx,[bp+8h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+3CD6h]
	push	word ptr [bx+3CD4h]
	jmp	1F4Ch

l183B_1F47:
	mov	ax,3C3Eh
	push	ds
	push	ax

l183B_1F4C:
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3C43h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp+6h],4h
	jge	1F7Ah

l183B_1F67:
	cmp	word ptr [bp+8h],1h
	jz	1F7Ah

l183B_1F6D:
	mov	ax,3C5Bh

l183B_1F70:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l183B_1F7A:
	mov	es,[5624h]
	sub	ax,ax
	mov	es:[4592h],ax
	mov	es,[5626h]
	mov	es:[377Ch],ax

l183B_1F8C:
	call	far 0800h:2A4Fh
	jmp	2226h

l183B_1F94:
	mov	ax,3C89h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[561Ah]
	push	word ptr es:[3770h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,3C93h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Eh
	push	ax
	mov	ax,1h
	push	ax
	mov	es,[5612h]
	push	word ptr es:[377Ah]
	mov	es,[5610h]
	push	word ptr es:[3778h]
	call	far 207Fh:2B87h
	add	sp,8h

l183B_1FE1:
	call	far 1F3Dh:0259h
	push	ax
	call	far 1E56h:0D1Dh
	add	sp,2h
	mov	[bp-12h],ax
	sub	ax,ax
	mov	[bp-8h],ax
	mov	[bp-4h],ax
	mov	ax,[bp-12h]
	sub	ax,0FFAFh
	cmp	ax,0Ah
	ja	205Fh

l183B_2005:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+2049h]

l183B_200D:
	mov	word ptr [bp-8h],0FFFFh
	jmp	205Fh

l183B_2014:
	mov	word ptr [bp-8h],0FFFFh

l183B_2019:
	mov	word ptr [bp-4h],1h
	jmp	205Fh

l183B_2020:
	mov	ax,1h
	mov	[bp-8h],ax
	mov	[bp-4h],ax
	jmp	205Fh

l183B_202B:
	mov	word ptr [bp-8h],1h
	jmp	205Fh

l183B_2032:
	mov	word ptr [bp-8h],1h

l183B_2037:
	mov	word ptr [bp-4h],0FFFFh
	jmp	205Fh

l183B_203E:
	mov	ax,0FFFFh
	mov	[bp-4h],ax
	mov	[bp-8h],ax
	jmp	205Fh
l183B_2049	dw	0x2020
l183B_204B	dw	0x202B
l183B_204D	dw	0x2032
l183B_204F	dw	0x205F
l183B_2051	dw	0x2019
l183B_2053	dw	0x205F
l183B_2055	dw	0x2037
l183B_2057	dw	0x205F
l183B_2059	dw	0x2014
l183B_205B	dw	0x200D
l183B_205D	dw	0x203E

l183B_205F:
	mov	es,[5610h]
	mov	ax,[bp-4h]
	add	es:[3778h],ax
	cmp	word ptr es:[3778h],0Dh
	jl	207Bh

l183B_2073:
	cmp	word ptr es:[3778h],27h
	jle	2083h

l183B_207B:
	mov	ax,[bp-4h]
	sub	es:[3778h],ax

l183B_2083:
	mov	es,[5612h]
	mov	ax,[bp-8h]
	add	es:[377Ah],ax
	js	2099h

l183B_2091:
	cmp	word ptr es:[377Ah],18h
	jle	20A1h

l183B_2099:
	mov	ax,[bp-8h]
	sub	es:[377Ah],ax

l183B_20A1:
	mov	ax,[bp-4h]
	or	ax,[bp-8h]
	jnz	20ACh

l183B_20A9:
	jmp	2217h

l183B_20AC:
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	[bp-10h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	[bp-14h],ax
	mov	es,[5612h]
	mov	ax,es:[377Ah]
	sub	ax,0Ch
	push	ax
	mov	es,[5610h]
	mov	ax,es:[3778h]
	sub	ax,1Ah
	push	ax
	call	far 0800h:191Bh
	add	sp,4h
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	and	ax,7Fh
	mov	[bp-2h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	and	ax,7Fh
	mov	[bp-6h],ax
	mov	ax,es:[0A44Dh]
	and	ax,0F000h
	mov	es,[55CCh]
	mov	cx,es:[0A44Bh]
	and	cx,0F00h
	or	ax,cx
	mov	al,ah
	sub	ah,ah
	mov	[bp-18h],ax
	mov	word ptr [bp-8h],1h
	mov	word ptr [bp-4h],0h
	jmp	216Dh

l183B_2127:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	di,[bp-4h]
	add	di,si
	mov	es,[55DCh]
	mov	al,es:[di+32C7h]
	cbw
	cmp	ax,[bp-18h]
	jnz	2169h

l183B_2143:
	mov	al,es:[di+32C8h]
	cbw
	cmp	ax,[bp-2h]
	jnz	2169h

l183B_214E:
	mov	al,es:[di+32C9h]
	cbw
	cmp	ax,[bp-6h]
	jnz	2169h

l183B_2159:
	mov	word ptr [bp-8h],0h
	mov	bx,[bp-0Ah]
	add	bx,si
	mov	byte ptr es:[bx+32C6h],0FFh

l183B_2169:
	add	word ptr [bp-4h],4h

l183B_216D:
	mov	ax,[bp-0Ah]
	cmp	[bp-4h],ax
	jl	2127h

l183B_2175:
	cmp	word ptr [bp-8h],0h
	jz	21AAh

l183B_217B:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	si,ax
	add	si,[bp-0Ah]
	mov	al,[bp+8h]
	mov	es,[55DCh]
	mov	es:[si+32C6h],al
	mov	al,[bp-18h]
	mov	es:[si+32C7h],al
	mov	al,[bp-2h]
	mov	es:[si+32C8h],al
	mov	al,[bp-6h]
	mov	es:[si+32C9h],al

l183B_21AA:
	mov	es,[55CCh]
	mov	ax,[bp-10h]
	mov	es:[0A44Bh],ax
	mov	es,[55CEh]
	mov	ax,[bp-14h]
	mov	es:[0A44Dh],ax
	mov	es,[5610h]
	mov	ax,es:[3778h]
	mov	[bp-1Ch],ax
	mov	es,[5612h]
	mov	ax,es:[377Ah]
	mov	[bp-36h],ax
	sub	ax,ax
	push	ax
	push	word ptr [bp+6h]
	push	cs
	call	1774h
	add	sp,4h
	mov	es,[5610h]
	mov	ax,[bp-1Ch]
	mov	es:[3778h],ax
	mov	es,[5612h]
	mov	ax,[bp-36h]
	mov	es:[377Ah],ax
	mov	ax,0Eh
	push	ax
	mov	ax,1h
	push	ax
	push	word ptr es:[377Ah]
	mov	es,[5610h]
	push	word ptr es:[3778h]
	call	far 207Fh:2B87h
	add	sp,8h

l183B_2217:
	cmp	word ptr [bp-12h],20h
	jz	2226h

l183B_221D:
	cmp	word ptr [bp-12h],0Dh
	jz	2226h

l183B_2223:
	jmp	1FE1h

l183B_2226:
	call	far 1E56h:0388h
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn183B_2231: 183B:2231
;;   Called from:
;;     183B:1697 (in fn183B_14C3)
fn183B_2231 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[55D4h]
	mov	al,es:[si+0C748h]
	sub	ah,ah
	mov	[bp-2h],ax
	mov	al,es:[si+0C749h]
	mov	[bp-4h],ax
	test	byte ptr [bp-2h],8h
	jz	229Ah

l183B_2272:
	test	byte ptr [bp-4h],8h
	jz	229Ah

l183B_2278:
	mov	ax,3CE0h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Bh
	push	ax
	mov	ax,20h
	push	ax
	push	word ptr [bp+6h]
	call	far 1543h:07CBh
	add	sp,6h
	jmp	22ACh

l183B_229A:
	mov	ax,3CFAh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h

l183B_22AC:
	mov	es,[560Ch]
	mov	word ptr es:[00C8h],4h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn183B_22BC: 183B:22BC
;;   Called from:
;;     1631:0465 (in fn1631_03AB)
;;     183B:0776 (in fn183B_000A)
;;     183B:1869 (in fn183B_1774)
;;     183B:1E27 (in fn183B_1C1F)
fn183B_22BC proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[5624h]
	sub	ax,ax
	mov	es:[4592h],ax
	mov	es,[5626h]
	mov	es:[377Ch],ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[55D4h]
	mov	al,es:[si+0C755h]
	sub	ah,ah
	mov	es,[561Ah]
	mov	es:[3770h],ax
	cmp	word ptr [bp+8h],2h
	jnz	230Fh

l183B_22FB:
	mov	es,[55D4h]
	mov	al,es:[si+0C756h]
	mov	es,[561Ah]
	mov	es:[3770h],ax
	jmp	2442h

l183B_230F:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[55D4h]
	mov	al,es:[si+0C748h]
	sub	ah,ah
	mov	[bp-2h],ax
	mov	al,es:[si+0C749h]
	mov	[bp-6h],ax
	mov	al,[bp-2h]
	or	al,[bp-6h]
	test	al,8h
	jnz	2350h

l183B_2337:
	mov	es,[561Ah]
	mov	word ptr es:[3770h],1h
	mov	es,[5626h]
	mov	word ptr es:[377Ch],1h
	jmp	23F2h

l183B_2350:
	test	byte ptr [bp-2h],8h
	jz	235Ch

l183B_2356:
	test	byte ptr [bp-6h],8h
	jnz	238Dh

l183B_235C:
	mov	es,[561Ah]
	sar	word ptr es:[3770h],1h
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	test	byte ptr es:[bx+0C755h],1h
	jz	2382h

l183B_2379:
	mov	es,[561Ah]
	inc	word ptr es:[3770h]

l183B_2382:
	mov	es,[5626h]
	mov	word ptr es:[377Ch],1h

l183B_238D:
	mov	word ptr [bp-4h],4h

l183B_2392:
	mov	ax,[bp-4h]
	test	[bp-2h],ax
	jnz	23AEh

l183B_239A:
	mov	es,[561Ah]
	dec	word ptr es:[3770h]
	mov	es,[5626h]
	mov	word ptr es:[377Ch],1h

l183B_23AE:
	mov	ax,[bp-4h]
	test	[bp-6h],ax
	jnz	23CAh

l183B_23B6:
	mov	es,[561Ah]
	dec	word ptr es:[3770h]
	mov	es,[5626h]
	mov	word ptr es:[377Ch],1h

l183B_23CA:
	mov	es,[5626h]
	cmp	word ptr es:[377Ch],0h
	jz	23E9h

l183B_23D6:
	mov	es,[561Ah]
	cmp	word ptr es:[3770h],0h
	jnz	23E9h

l183B_23E2:
	mov	word ptr es:[3770h],1h

l183B_23E9:
	sar	word ptr [bp-4h],1h
	cmp	word ptr [bp-4h],0h
	jg	2392h

l183B_23F2:
	mov	bx,[bp+6h]
	mov	es,[55EAh]
	mov	al,es:[bx+6Eh]
	cbw
	mov	cl,5h
	idiv	cl
	cbw
	mov	es,[5624h]
	mov	es:[4592h],ax
	mov	es,[561Ah]
	sub	es:[3770h],ax
	cmp	word ptr [bp+8h],1h
	jnz	2442h

l183B_241B:
	mov	ax,es:[3770h]
	sar	ax,1h
	add	es:[3770h],ax
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	mov	es,[55D4h]
	test	byte ptr es:[bx+0C755h],1h
	jz	2442h

l183B_2439:
	mov	es,[561Ah]
	inc	word ptr es:[3770h]

l183B_2442:
	mov	bx,[bp+6h]
	mov	es,[55EAh]
	cmp	byte ptr es:[bx+6Eh],1Eh
	jnz	245Ch

l183B_2451:
	mov	es,[561Ah]
	mov	word ptr es:[3770h],0h

l183B_245C:
	mov	es,[561Ah]
	cmp	word ptr es:[3770h],0h
	jge	246Fh

l183B_2468:
	mov	word ptr es:[3770h],0h

l183B_246F:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn183B_2474: 183B:2474
;;   Called from:
;;     1631:0476 (in fn1631_03AB)
;;     183B:0782 (in fn183B_000A)
;;     183B:1875 (in fn183B_1774)
;;     183B:1E33 (in fn183B_1C1F)
fn183B_2474 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[561Ah]
	mov	word ptr es:[3770h],6h
	cmp	word ptr [bp+6h],0Ch
	jge	24DBh

l183B_248F:
	sub	word ptr [bp+6h],4h
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	mov	al,3h
	imul	byte ptr es:[bx+0C616h]
	sar	ax,1h
	sar	ax,1h
	mov	es,[561Ah]
	mov	es:[3770h],ax
	cmp	ax,3h
	jge	24BEh

l183B_24B7:
	mov	word ptr es:[3770h],3h

l183B_24BE:
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C621h],1h
	jle	24DBh

l183B_24D2:
	mov	es,[561Ah]
	sar	word ptr es:[3770h],1h

l183B_24DB:
	mov	es,[561Ah]
	cmp	word ptr es:[3770h],8h
	jle	24EEh

l183B_24E7:
	mov	word ptr es:[3770h],8h

l183B_24EE:
	pop	bp
	retf

;; fn183B_24F0: 183B:24F0
;;   Called from:
;;     183B:0543 (in fn183B_000A)
fn183B_24F0 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3D3Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[560Ch]
	mov	word ptr es:[00C2h],2h
	mov	word ptr es:[00C6h],3h
	mov	es,[55F4h]
	mov	ax,es:[2E38h]
	mov	es,[560Ch]
	mov	es:[00C8h],ax
	mov	ax,3h
	push	ax
	call	far 1E56h:0B5Eh
	mov	[bp-2h],ax
	mov	es,[560Ch]
	mov	word ptr es:[00C2h],0h
	mov	sp,bp
	pop	bp
	retf

;; fn183B_2556: 183B:2556
;;   Called from:
;;     183B:0554 (in fn183B_000A)
fn183B_2556 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3D5Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[55F6h]
	push	word ptr es:[2E3Ah]
	call	far 0800h:1A13h
	mov	sp,bp
	pop	bp
	retf

;; fn183B_2591: 183B:2591
;;   Called from:
;;     183B:170F (in fn183B_14C3)
fn183B_2591 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ch
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-4h],1h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3D73h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[560Ch]
	mov	word ptr es:[00C2h],1h
	mov	word ptr es:[00C6h],3h
	mov	word ptr es:[00C8h],0h
	mov	ax,3h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-8h],ax
	mov	word ptr [bp-2h],1h
	cmp	ax,1h
	jz	25F5h

l183B_25F2:
	jmp	2687h

l183B_25F5:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	cmp	word ptr [bp+6h],4h
	jl	2657h

l183B_260C:
	sub	ax,ax
	mov	[bp-6h],ax
	mov	[bp-0Ah],ax
	jmp	262Fh

l183B_2616:
	mov	bx,[bp-0Ah]
	shl	bx,1h
	mov	es,[55E0h]
	cmp	word ptr es:[bx+4082h],0h
	jz	262Ch

l183B_2627:
	mov	word ptr [bp-6h],1h

l183B_262C:
	inc	word ptr [bp-0Ah]

l183B_262F:
	cmp	word ptr [bp-0Ah],4h
	jl	2616h

l183B_2635:
	cmp	word ptr [bp-6h],0h
	jz	264Dh

l183B_263B:
	mov	ax,3D94h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h

l183B_264D:
	sub	ax,ax
	mov	[bp-2h],ax
	mov	[bp-4h],ax
	jmp	2687h

l183B_2657:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C79Bh],2h
	jnz	2687h

l183B_266B:
	mov	ax,3DCDh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-4h],0h
	call	far 1F3Dh:0259h
	call	far 1E56h:0388h

l183B_2687:
	mov	word ptr [bp-0Ch],10h

l183B_268C:
	mov	si,[bp-0Ch]
	shl	si,1h
	mov	es,[55E0h]
	cmp	word ptr es:[si+406Ah],0h
	jz	26AEh

l183B_269D:
	mov	es,[55D2h]
	cmp	word ptr es:[si+4004h],0FFh
	jz	26AEh

l183B_26A9:
	mov	word ptr [bp-2h],1h

l183B_26AE:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],18h
	jl	268Ch

l183B_26B7:
	mov	ax,[bp-4h]
	add	[bp-2h],ax
	jnz	26E8h

l183B_26BF:
	cmp	word ptr [bp-8h],1h
	jnz	26E8h

l183B_26C5:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3E19h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh

l183B_26E8:
	call	far 1E56h:0388h
	cmp	word ptr [bp-8h],0h
	jge	26F8h

l183B_26F3:
	mov	word ptr [bp-8h],0h

l183B_26F8:
	cmp	word ptr [bp-8h],2h
	jge	2719h

l183B_26FE:
	cmp	word ptr [bp-2h],0h
	jz	2719h

l183B_2704:
	push	word ptr [bp-4h]
	mov	ax,0Ch
	imul	word ptr [bp-8h]
	push	ax
	push	word ptr [bp+6h]
	call	far 0DABh:1467h
	add	sp,6h

l183B_2719:
	mov	es,[560Ch]
	mov	word ptr es:[00C2h],0h
	mov	word ptr es:[00C8h],4h
	cmp	word ptr [bp+6h],4h
	jge	2738h

l183B_2731:
	mov	word ptr es:[00C8h],6h

l183B_2738:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn183B_273D: 183B:273D
;;   Called from:
;;     0DAB:02E9 (in fn0DAB_0002)
;;     0DAB:03EE (in fn0DAB_0002)
fn183B_273D proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-2h],1Ch
	cmp	word ptr [bp+8h],3Ah
	jl	2758h

l183B_2753:
	mov	word ptr [bp-2h],1Dh

l183B_2758:
	cmp	word ptr [bp+8h],41h
	jl	2763h

l183B_275E:
	mov	word ptr [bp-2h],21h

l183B_2763:
	cmp	word ptr [bp+8h],48h
	jl	276Eh

l183B_2769:
	mov	word ptr [bp-2h],22h

l183B_276E:
	cmp	word ptr [bp+8h],4Fh
	jl	2779h

l183B_2774:
	mov	word ptr [bp-2h],1Eh

l183B_2779:
	cmp	word ptr [bp+8h],51h
	jl	2784h

l183B_277F:
	mov	word ptr [bp-2h],23h

l183B_2784:
	cmp	word ptr [bp+8h],53h
	jl	278Fh

l183B_278A:
	mov	word ptr [bp-2h],20h

l183B_278F:
	cmp	word ptr [bp+8h],55h
	jl	279Ah

l183B_2795:
	mov	word ptr [bp-2h],1Fh

l183B_279A:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55D4h]
	cmp	byte ptr es:[bx+0C79Fh],0C8h
	jnz	27B3h

l183B_27AE:
	mov	ax,1h
	jmp	27C5h

l183B_27B3:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-2h]
	mov	al,es:[bx+0C724h]
	sub	ah,ah

l183B_27C5:
	mov	sp,bp
	pop	bp
	retf

;; fn183B_27C9: 183B:27C9
;;   Called from:
;;     1631:1A50 (in fn1631_16AB)
;;     183B:0989 (in fn183B_000A)
;;     183B:0B11 (in fn183B_000A)
;;     183B:0BCA (in fn183B_000A)
;;     183B:0C01 (in fn183B_000A)
;;     1AE8:0B18 (in fn1AE8_000C)
;;     1AE8:1B7F (in fn1AE8_12C7)
;;     1AE8:1C6E (in fn1AE8_12C7)
;;     1AE8:1EA7 (in fn1AE8_1E46)
fn183B_27C9 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	al,[bp+6h]
	mov	es,[55D4h]
	mov	bl,es:[0D557h]
	sub	bh,bh
	mov	es:[bx+0D457h],al
	mov	ax,[bp+8h]
	or	ax,[bp+0Ah]
	mov	al,ah
	sub	ah,ah
	mov	[bp-2h],ax
	mov	al,[bp-2h]
	mov	bl,es:[0D557h]
	mov	es:[bx+0D497h],al
	mov	al,[bp+8h]
	and	al,7Fh
	mov	bl,es:[0D557h]
	mov	es:[bx+0D4D7h],al
	mov	al,[bp+0Ah]
	and	al,7Fh
	mov	bl,es:[0D557h]
	inc	word ptr es:[0D557h]
	mov	es:[bx+0D517h],al
	cmp	byte ptr es:[0D557h],3Fh
	jbe	2831h

l183B_282C:
	mov	es:[0D557h],ah

l183B_2831:
	mov	sp,bp
	pop	bp
	retf

;; fn183B_2835: 183B:2835
;;   Called from:
;;     183B:1347 (in fn183B_000A)
fn183B_2835 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	es,[55CEh]
	or	ax,es:[0A44Dh]
	mov	cl,8h
	shr	ax,cl
	mov	[bp-2h],ax
	mov	byte ptr [bp-1h],0h
	sub	word ptr [bp-2h],11h
	mov	word ptr [bp-6h],0h

l183B_2867:
	mov	word ptr [bp-4h],0h

l183B_286C:
	mov	si,[bp-2h]
	add	si,[bp-4h]
	js	28BAh

l183B_2874:
	cmp	si,100h
	jge	28BAh

l183B_287A:
	mov	es,[5604h]
	cmp	byte ptr es:[si+30h],0h
	jz	28BAh

l183B_2886:
	mov	ax,3h
	imul	word ptr [bp-6h]
	mov	di,ax
	add	di,[bp-4h]
	mov	bx,di
	shl	bx,1h
	shl	bx,1h
	mov	es,[5628h]
	les	bx,es:[bx+170h]
	cmp	byte ptr es:[bx],90h
	jz	28BAh

l183B_28A6:
	mov	es,[5604h]
	mov	al,es:[si+30h]
	cbw
	push	ax
	push	di
	call	far 0800h:2DA8h
	add	sp,4h

l183B_28BA:
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],3h
	jl	286Ch

l183B_28C3:
	add	word ptr [bp-2h],10h
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],3h
	jl	2867h

l183B_28D0:
	call	far 207Fh:1DA8h
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn183B_28DB: 183B:28DB
;;   Called from:
;;     183B:034F (in fn183B_000A)
fn183B_28DB proc
	push	bp
	mov	bp,sp
	mov	ax,14h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	[bp-12h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	[bp-14h],ax
	mov	es,[55D2h]
	mov	ax,es:[400Ch]
	mov	[bp-4h],ax
	mov	es,[55D6h]
	mov	ax,es:[403Eh]
	mov	[bp-6h],ax
	mov	es,[55D4h]
	cmp	byte ptr es:[0C620h],8h
	jz	2943h

l183B_291F:
	mov	al,es:[0C620h]
	cbw
	mov	[bp-6h],ax
	mov	si,ax
	shl	si,1h
	mov	es,[55D2h]
	mov	ax,es:[si+4004h]
	mov	[bp-4h],ax
	mov	es,[55D6h]
	mov	ax,es:[si+4036h]
	mov	[bp-6h],ax

l183B_2943:
	push	word ptr [bp-6h]
	push	word ptr [bp-4h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:1DF8h
	mov	es,[55CCh]
	mov	ax,es:[0A44Bh]
	mov	es,[5614h]
	mov	es:[0E486h],ax
	mov	es,[55CEh]
	mov	ax,es:[0A44Dh]
	mov	es,[5616h]
	mov	es:[0E488h],ax
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-8h],1Ah
	mov	word ptr [bp-0Ah],0Ch
	mov	word ptr [bp-10h],0Ch

l183B_29A4:
	cmp	word ptr [bp-2h],0h
	jnz	29D8h

l183B_29AA:
	mov	si,[bp-10h]
	shl	si,1h
	mov	es,[55E0h]
	cmp	word ptr es:[si+406Ah],0h
	jz	29D8h

l183B_29BB:
	mov	es,[55D2h]
	mov	ax,es:[si+4004h]
	mov	[bp-0Ch],ax
	mov	es,[55D6h]
	mov	ax,es:[si+4036h]
	mov	[bp-0Eh],ax
	mov	word ptr [bp-2h],1h

l183B_29D8:
	inc	word ptr [bp-10h]
	cmp	word ptr [bp-10h],18h
	jl	29A4h

l183B_29E1:
	mov	es,[561Ah]
	mov	word ptr es:[3770h],1Eh
	cmp	word ptr [bp-2h],0h
	jnz	29F5h

l183B_29F2:
	jmp	2A8Eh

l183B_29F5:
	mov	word ptr [bp-2h],0h
	jmp	2A7Fh

l183B_29FD:
	mov	es,[5614h]
	mov	ax,[bp-0Ch]
	cmp	es:[0E486h],ax
	jnz	2A19h

l183B_2A0B:
	mov	es,[5616h]
	mov	ax,[bp-0Eh]
	cmp	es:[0E488h],ax
	jz	2A8Eh

l183B_2A19:
	sub	ax,ax
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-8h]
	push	word ptr [bp-0Eh]
	push	word ptr [bp-0Ch]
	mov	ax,80h
	push	ax
	call	far 1631h:0006h
	add	sp,0Ch
	mov	es,[561Ch]
	mov	ax,es:[458Eh]
	add	[bp-8h],ax
	mov	es,[561Eh]
	mov	ax,es:[4590h]
	add	[bp-0Ah],ax
	mov	es,[561Ah]
	dec	word ptr es:[3770h]
	mov	es,[5614h]
	mov	ax,[bp-0Ch]
	cmp	es:[0E486h],ax
	jnz	2A7Fh

l183B_2A61:
	mov	es,[5616h]
	mov	ax,[bp-0Eh]
	cmp	es:[0E488h],ax
	jnz	2A7Fh

l183B_2A6F:
	mov	es,[561Ah]
	mov	word ptr es:[3770h],0h
	mov	word ptr [bp-2h],1h

l183B_2A7F:
	mov	es,[561Ah]
	cmp	word ptr es:[3770h],0h
	jle	2A8Eh

l183B_2A8B:
	jmp	29FDh

l183B_2A8E:
	push	word ptr [bp-14h]
	push	word ptr [bp-12h]
	push	cs
	call	2AA3h
	add	sp,4h
	mov	ax,[bp-2h]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn183B_2AA3: 183B:2AA3
;;   Called from:
;;     183B:1413 (in fn183B_000A)
;;     183B:2A94 (in fn183B_28DB)
fn183B_2AA3 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[55CEh]
	push	word ptr es:[0A44Dh]
	mov	es,[55CCh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
