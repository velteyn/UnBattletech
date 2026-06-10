;;; Segment 0DAB (0DAB:0000)
0DAB:0000 5D CB                                           ].              

;; fn0DAB_0002: 0DAB:0002
;;   Called from:
;;     183B:1169 (in fn183B_000A)
fn0DAB_0002 proc
	push	bp
	mov	bp,sp
	mov	ax,2Ah
	call	far 207Fh:2FDCh
	push	di
	push	si
	sub	ax,ax
	mov	[bp-8h],ax
	mov	[bp-6h],ax
	mov	[bp-4h],ax
	mov	[bp-0Ch],ax

l0DAB_001D:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	0047h

l0DAB_0031:
	mov	al,es:[si+0C61Dh]
	cbw
	mov	di,ax
	cmp	[bp-6h],di
	jge	0047h

l0DAB_003E:
	mov	ax,[bp-0Ch]
	mov	[bp-4h],ax
	mov	[bp-6h],di

l0DAB_0047:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],8h
	jl	001Dh

l0DAB_0050:
	mov	ax,0EFBh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0EFEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-6h],1h
	jle	00B5h

l0DAB_009E:
	mov	bx,[bp-6h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+0F9Ch]
	push	word ptr [bx+0F9Ah]
	call	far 1E56h:03F5h
	add	sp,4h

l0DAB_00B5:
	mov	ax,0F28h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-0Ch],0Ch

l0DAB_00D1:
	mov	bx,[bp-0Ch]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+393Ch],0h
	jz	010Ch

l0DAB_00E2:
	mov	word ptr [bp-26h],11h

l0DAB_00E7:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	mov	al,es:[bx+0C33Ch]
	sub	ah,ah
	add	[bp-2h],ax
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],1Bh
	jle	00E7h

l0DAB_0109:
	inc	word ptr [bp-8h]

l0DAB_010C:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],10h
	jl	00D1h

l0DAB_0115:
	mov	word ptr [bp-26h],1Bh
	jmp	0180h

l0DAB_011C:
	inc	word ptr [bp-0Ch]

l0DAB_011F:
	cmp	word ptr [bp-0Ch],4h
	jge	017Dh

l0DAB_0125:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C724h],0FFh
	jz	011Ch

l0DAB_0139:
	mov	di,[bp-26h]
	add	di,si
	mov	al,es:[di+0C769h]
	sub	ah,ah
	mov	cl,es:[di+0C724h]
	sub	ch,ch
	sub	ax,cx
	mov	[bp-0Ah],ax
	or	ax,ax
	jz	011Ch

l0DAB_0155:
	mov	ax,[bp-2h]
	cmp	[bp-0Ah],ax
	jle	0160h

l0DAB_015D:
	mov	[bp-0Ah],ax

l0DAB_0160:
	mov	ax,[bp-0Ah]
	sub	[bp-2h],ax
	mov	al,[bp-0Ah]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	add	es:[bx+0C724h],cl
	jmp	011Ch

l0DAB_017D:
	dec	word ptr [bp-26h]

l0DAB_0180:
	cmp	word ptr [bp-26h],11h
	jl	018Dh

l0DAB_0186:
	mov	word ptr [bp-0Ch],0h
	jmp	011Fh

l0DAB_018D:
	cmp	word ptr [bp-6h],4h
	jge	0196h

l0DAB_0193:
	jmp	0259h

l0DAB_0196:
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-0Ch],0Ch

l0DAB_01A0:
	mov	bx,[bp-0Ch]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+393Ch],0h
	jz	01D8h

l0DAB_01B1:
	mov	word ptr [bp-26h],1Ch

l0DAB_01B6:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	mov	al,es:[bx+0C33Ch]
	sub	ah,ah
	add	[bp-2h],ax
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],23h
	jle	01B6h

l0DAB_01D8:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],10h
	jl	01A0h

l0DAB_01E1:
	mov	word ptr [bp-26h],23h
	jmp	024Ch

l0DAB_01E8:
	inc	word ptr [bp-0Ch]

l0DAB_01EB:
	cmp	word ptr [bp-0Ch],4h
	jge	0249h

l0DAB_01F1:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C724h],0FFh
	jz	01E8h

l0DAB_0205:
	mov	di,[bp-26h]
	add	di,si
	mov	al,es:[di+0C769h]
	sub	ah,ah
	mov	cl,es:[di+0C724h]
	sub	ch,ch
	sub	ax,cx
	mov	[bp-0Ah],ax
	or	ax,ax
	jz	01E8h

l0DAB_0221:
	mov	ax,[bp-2h]
	cmp	[bp-0Ah],ax
	jle	022Ch

l0DAB_0229:
	mov	[bp-0Ah],ax

l0DAB_022C:
	mov	ax,[bp-0Ah]
	sub	[bp-2h],ax
	mov	al,[bp-0Ah]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	add	es:[bx+0C724h],cl
	jmp	01E8h

l0DAB_0249:
	dec	word ptr [bp-26h]

l0DAB_024C:
	cmp	word ptr [bp-26h],1Ch
	jl	0259h

l0DAB_0252:
	mov	word ptr [bp-0Ch],0h
	jmp	01EBh

l0DAB_0259:
	cmp	word ptr [bp-6h],2h
	jge	0262h

l0DAB_025F:
	jmp	031Fh

l0DAB_0262:
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-0Ch],0h

l0DAB_026C:
	mov	bx,[bp-0Ch]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+3954h],0h
	jz	02A5h

l0DAB_027D:
	mov	word ptr [bp-26h],33h

l0DAB_0282:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C918h],22h
	jnz	029Ch

l0DAB_0299:
	inc	word ptr [bp-2h]

l0DAB_029C:
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],55h
	jle	0282h

l0DAB_02A5:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],4h
	jl	026Ch

l0DAB_02AE:
	mov	word ptr [bp-0Ch],0h

l0DAB_02B3:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	0316h

l0DAB_02C7:
	mov	word ptr [bp-26h],33h

l0DAB_02CC:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C724h],0A2h
	jnz	030Dh

l0DAB_02E3:
	push	word ptr [bp-26h]
	push	word ptr [bp-0Ch]
	call	far 183Bh:273Dh
	add	sp,4h
	or	ax,ax
	jz	030Dh

l0DAB_02F5:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	mov	byte ptr es:[bx+0C724h],22h
	dec	word ptr [bp-2h]

l0DAB_030D:
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],55h
	jle	02CCh

l0DAB_0316:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],4h
	jl	02B3h

l0DAB_031F:
	cmp	word ptr [bp-6h],3h
	jge	0328h

l0DAB_0325:
	jmp	042Ah

l0DAB_0328:
	mov	word ptr [bp-0Ch],0h

l0DAB_032D:
	mov	si,[bp-0Ch]
	mov	byte ptr [bp+si-24h],0h
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],10h
	jl	032Dh

l0DAB_033D:
	mov	word ptr [bp-0Ch],0h

l0DAB_0342:
	mov	bx,[bp-0Ch]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+3954h],0h
	jz	038Ah

l0DAB_0353:
	mov	word ptr [bp-26h],33h

l0DAB_0358:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	mov	al,es:[bx+0C918h]
	mov	[bp-2Ah],al
	cmp	al,10h
	jc	0381h

l0DAB_0373:
	cmp	al,20h
	ja	0381h

l0DAB_0377:
	mov	si,[bp-2Ah]
	and	si,0FFh
	inc	byte ptr [bp+si-34h]

l0DAB_0381:
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],55h
	jle	0358h

l0DAB_038A:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],4h
	jl	0342h

l0DAB_0393:
	mov	word ptr [bp-0Ch],0h

l0DAB_0398:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	041Eh

l0DAB_03AC:
	mov	word ptr [bp-26h],33h

l0DAB_03B1:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	mov	al,es:[bx+0C724h]
	mov	[bp-2Ah],al
	test	byte ptr [bp-2Ah],80h
	jz	0415h

l0DAB_03CE:
	sub	ah,ah
	and	ax,7Fh
	mov	[bp-2h],ax
	cmp	ax,10h
	jl	0415h

l0DAB_03DB:
	cmp	ax,20h
	jg	0415h

l0DAB_03E0:
	mov	si,ax
	cmp	byte ptr [bp+si-34h],0h
	jz	0415h

l0DAB_03E8:
	push	word ptr [bp-26h]
	push	word ptr [bp-0Ch]
	call	far 183Bh:273Dh
	add	sp,4h
	or	ax,ax
	jz	0415h

l0DAB_03FA:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-26h]
	mov	es,[5412h]
	and	byte ptr es:[bx+0C724h],7Fh
	mov	si,[bp-2h]
	dec	byte ptr [bp+si-34h]

l0DAB_0415:
	inc	word ptr [bp-26h]
	cmp	word ptr [bp-26h],55h
	jle	03B1h

l0DAB_041E:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],4h
	jge	042Ah

l0DAB_0427:
	jmp	0398h

l0DAB_042A:
	cmp	word ptr [bp-8h],0h
	jnz	0433h

l0DAB_0430:
	jmp	04F3h

l0DAB_0433:
	cmp	word ptr [bp-4h],0h
	jnz	043Ch

l0DAB_0439:
	jmp	04F3h

l0DAB_043C:
	mov	word ptr [bp-28h],0h
	mov	word ptr [bp-0Ch],0h
	jmp	0459h

l0DAB_0448:
	call	far 207Fh:0BC0h
	and	ax,7Fh
	add	ax,5Ah
	add	[bp-28h],ax
	inc	word ptr [bp-0Ch]

l0DAB_0459:
	mov	ax,[bp-8h]
	cmp	[bp-0Ch],ax
	jl	0448h

l0DAB_0461:
	mov	ax,[bp-4h]
	imul	word ptr [bp-28h]
	mov	[bp-28h],ax
	mov	ax,0F40h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:28A2h
	push	word ptr [bp-28h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,0F65h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	cmp	word ptr [bp-8h],1h
	jle	04B7h

l0DAB_04A2:
	mov	ax,0F9Eh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h

l0DAB_04B7:
	mov	ax,0FA0h
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
	call	far 0800h:2A4Fh
	mov	ax,[bp-28h]
	cwd
	mov	es,[5412h]
	add	es:[0D370h],ax
	adc	es:[0D372h],dx

l0DAB_04F3:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_04F9: 0DAB:04F9
;;   Called from:
;;     183B:124C (in fn183B_000A)
fn0DAB_04F9 proc
	push	bp
	mov	bp,sp
	mov	ax,14h
	call	far 207Fh:2FDCh
	push	di
	push	si
	sub	ax,ax
	mov	[bp-14h],ax
	mov	[bp-4h],ax
	mov	[bp-0Eh],ax

l0DAB_0511:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	si,ax
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	053Bh

l0DAB_0525:
	mov	al,es:[si+0C61Dh]
	cbw
	mov	di,ax
	cmp	[bp-14h],di
	jge	053Bh

l0DAB_0532:
	mov	ax,[bp-0Eh]
	mov	[bp-4h],ax
	mov	[bp-14h],di

l0DAB_053B:
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],8h
	jl	0511h

l0DAB_0544:
	mov	word ptr [bp-0Eh],0h
	jmp	0850h

l0DAB_054C:
	inc	word ptr [bp-10h]
	cmp	word ptr [bp-10h],10h
	jnz	055Ah

l0DAB_0555:
	mov	word ptr [bp-10h],0h

l0DAB_055A:
	mov	bx,[bp-10h]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+393Ch],0h
	jz	054Ch

l0DAB_056B:
	mov	bx,[bp-10h]
	shl	bx,1h
	mov	word ptr es:[bx+393Ch],0h
	mov	word ptr [bp-0Ch],0h
	mov	word ptr [bp-6h],0h

l0DAB_0581:
	mov	bx,[bp-6h]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+393Ch],0h
	jz	0595h

l0DAB_0592:
	inc	word ptr [bp-0Ch]

l0DAB_0595:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],10h
	jl	0581h

l0DAB_059E:
	mov	ax,[bp-10h]
	mov	[bp-2h],ax
	cmp	ax,0Ch
	jl	05ADh

l0DAB_05A9:
	sub	word ptr [bp-2h],8h

l0DAB_05AD:
	mov	word ptr [bp-8h],1h
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C799h],3h
	jz	05D6h

l0DAB_05C6:
	cmp	byte ptr es:[si+0C79Ah],2h
	jz	05D6h

l0DAB_05CE:
	cmp	byte ptr es:[si+0C743h],0h
	jnz	05E1h

l0DAB_05D6:
	cmp	word ptr [bp-14h],4h
	jge	05E1h

l0DAB_05DC:
	mov	word ptr [bp-8h],0h

l0DAB_05E1:
	cmp	word ptr [bp-8h],0h
	jnz	05EAh

l0DAB_05E7:
	jmp	07B5h

l0DAB_05EA:
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,101Dh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	bx,[bp-2h]
	mov	es,[5418h]
	mov	al,es:[bx+323Eh]
	mov	es,[541Ah]
	mov	es:[0022h],al
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	lea	ax,[bx+0C725h]
	mov	dx,3092h
	push	dx
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
	call	far 207Fh:3B9Eh
	add	sp,4h
	dec	ax
	mov	[bp-6h],ax
	jmp	067Fh

l0DAB_0677:
	mov	word ptr [bp-6h],0h

l0DAB_067C:
	dec	word ptr [bp-6h]

l0DAB_067F:
	cmp	word ptr [bp-6h],0h
	jle	069Ch

l0DAB_0685:
	mov	bx,[bp-6h]
	mov	es,[541Ah]
	cmp	byte ptr es:[bx+12h],20h
	jnz	0677h

l0DAB_0694:
	mov	byte ptr es:[bx+12h],0h
	jmp	067Ch

l0DAB_069C:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A7Eh
	mov	word ptr [bp-12h],1h
	mov	word ptr [bp-0Ah],0h
	jmp	06C0h

l0DAB_06BD:
	inc	word ptr [bp-0Ah]

l0DAB_06C0:
	cmp	word ptr [bp-0Ah],4h
	jl	06C9h

l0DAB_06C6:
	jmp	080Eh

l0DAB_06C9:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jnz	06BDh

l0DAB_06DD:
	mov	word ptr [bp-6h],1h

l0DAB_06E2:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-6h]
	mov	al,es:[bx+0C724h]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	add	bx,[bp-6h]
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],7Dh
	jl	06E2h

l0DAB_070D:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	si,ax
	mov	bx,[bp-2h]
	mov	es,[5418h]
	mov	al,es:[bx+323Eh]
	mov	es,[5412h]
	mov	es:[si+0C724h],al
	mov	al,[bp-0Eh]
	mov	es:[si+0C79Dh],al
	mov	al,[bp-0Ah]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es:[bx+0C620h],cl
	mov	bx,[bp-0Ah]
	mov	es,[541Ch]
	mov	byte ptr es:[bx+0D55Eh],0h
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C724h],4Ch
	jz	076Ah

l0DAB_075D:
	mov	bx,[bp-0Ah]
	mov	es,[541Ch]
	mov	byte ptr es:[bx+0D55Eh],92h

l0DAB_076A:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	si,ax
	mov	al,1h
	mov	es,[5412h]
	mov	es:[si+0C79Ah],al
	mov	es:[si+0C799h],al
	cmp	byte ptr es:[si+0C744h],0h
	jnz	078Fh

l0DAB_078A:
	mov	es:[si+0C744h],al

l0DAB_078F:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	cmp	byte ptr es:[bx+0C743h],0h
	jnz	07ADh

l0DAB_079F:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	byte ptr es:[bx+0C743h],1h

l0DAB_07AD:
	mov	word ptr [bp-0Ah],4h
	jmp	06BDh

l0DAB_07B5:
	mov	ax,102Fh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	bx,[bp-2h]
	mov	es,[5418h]
	mov	al,es:[bx+323Eh]
	mov	es,[541Ah]
	mov	es:[002Dh],al
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	lea	ax,[bx+0C725h]
	mov	dx,3092h
	push	dx
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

l0DAB_080E:
	cmp	word ptr [bp-0Ch],0h
	jnz	081Dh

l0DAB_0814:
	mov	ax,9h
	mov	[bp-0Eh],ax
	mov	[bp-12h],ax

l0DAB_081D:
	cmp	word ptr [bp-12h],0h
	jnz	0826h

l0DAB_0823:
	jmp	0926h

l0DAB_0826:
	call	far 0800h:2A4Fh

l0DAB_082B:
	cmp	word ptr [bp-0Ch],0h
	jnz	084Dh

l0DAB_0831:
	call	far 1E56h:0388h
	mov	ax,104Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh
	mov	word ptr [bp-0Eh],9h

l0DAB_084D:
	inc	word ptr [bp-0Eh]

l0DAB_0850:
	cmp	word ptr [bp-0Eh],8h
	jl	0859h

l0DAB_0856:
	jmp	0945h

l0DAB_0859:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	si,ax
	mov	es,[5412h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	084Dh

l0DAB_086D:
	cmp	byte ptr es:[si+0C61Ch],0h
	jz	084Dh

l0DAB_0875:
	cmp	byte ptr es:[si+0C620h],8h
	jl	084Dh

l0DAB_087D:
	call	far 1E56h:0388h
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-0Ch],1h
	mov	ax,0FAEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jnz	08D5h

l0DAB_08D2:
	jmp	082Bh

l0DAB_08D5:
	call	far 1E56h:0388h
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0FFFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,78h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	mov	word ptr [bp-12h],0h

l0DAB_0926:
	call	far 207Fh:0BC0h
	and	ax,3h
	mov	si,ax
	call	far 207Fh:0BC0h
	and	ax,1h
	mov	cx,0Ch
	imul	cx
	add	ax,si
	mov	[bp-10h],ax
	jmp	055Ah

l0DAB_0945:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_094B: 0DAB:094B
;;   Called from:
;;     183B:1251 (in fn183B_000A)
fn0DAB_094B proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	push	si
	sub	ax,ax
	mov	[bp-0Ch],ax
	mov	[bp-4h],ax
	mov	[bp-8h],ax
	mov	[bp-0Ah],ax
	mov	word ptr [bp-6h],4h

l0DAB_096A:
	mov	si,[bp-6h]
	shl	si,1h
	mov	es,[5416h]
	cmp	word ptr es:[si+393Ch],0h
	jnz	0983h

l0DAB_097B:
	cmp	word ptr es:[si+3954h],0h
	jz	0988h

l0DAB_0983:
	mov	word ptr [bp-0Ah],1h

l0DAB_0988:
	mov	bx,[bp-6h]
	shl	bx,1h
	cmp	word ptr es:[bx+3954h],0h
	jz	09B1h

l0DAB_0995:
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C6EBh],0h
	jz	09AEh

l0DAB_09A9:
	mov	word ptr [bp-0Ch],1h

l0DAB_09AE:
	inc	word ptr [bp-4h]

l0DAB_09B1:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],0Ch
	jl	096Ah

l0DAB_09BA:
	cmp	word ptr [bp-0Ah],0h
	jnz	09C3h

l0DAB_09C0:
	jmp	0B59h

l0DAB_09C3:
	mov	ax,1h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	ax,1085h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	09FCh

l0DAB_09EE:
	call	far 207Fh:0BC0h
	and	ax,0Fh
	add	ax,3h
	add	[bp-8h],ax

l0DAB_09FC:
	mov	ax,[bp-4h]
	dec	word ptr [bp-4h]
	or	ax,ax
	jnz	09EEh

l0DAB_0A06:
	cmp	word ptr [bp-8h],2h
	jge	0A11h

l0DAB_0A0C:
	mov	word ptr [bp-8h],2h

l0DAB_0A11:
	call	far 0800h:28A2h
	push	word ptr [bp-8h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],0Fh
	mov	ax,10B5h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-8h]
	cwd
	mov	es,[5412h]
	add	es:[0D370h],ax
	adc	es:[0D372h],dx
	cmp	word ptr [bp-0Ch],0h
	jz	0A5Eh

l0DAB_0A51:
	mov	ax,10C6h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l0DAB_0A5E:
	call	far 0800h:2A7Eh
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	cmp	word ptr [bp-0Ch],0h
	jnz	0A76h

l0DAB_0A73:
	jmp	0B59h

l0DAB_0A76:
	mov	word ptr [bp-6h],0h
	jmp	0B1Ah

l0DAB_0A7E:
	call	far 1E56h:0388h
	mov	es,[5412h]
	mov	al,es:[0C61Fh]
	cbw
	mov	[bp-2h],ax
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	al,es:[bx+0C6A7h]
	cbw
	mov	[bp-0Eh],ax
	or	ax,ax
	jz	0B17h

l0DAB_0AA4:
	mov	ax,10E5h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,10FFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1113h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jz	0B17h

l0DAB_0B0C:
	mov	es,[5412h]
	mov	al,[bp-0Eh]
	mov	es:[0C61Fh],al

l0DAB_0B17:
	inc	word ptr [bp-6h]

l0DAB_0B1A:
	cmp	word ptr [bp-6h],8h
	jge	0B59h

l0DAB_0B20:
	mov	bx,[bp-6h]
	shl	bx,1h
	mov	es,[5416h]
	cmp	word ptr es:[bx+395Ch],0h
	jz	0B17h

l0DAB_0B31:
	mov	es,[5412h]
	cmp	byte ptr es:[0C625h],0FFh
	jnz	0B40h

l0DAB_0B3D:
	jmp	0A7Eh

l0DAB_0B40:
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	al,es:[bx+0C6A7h]
	cbw
	push	ax
	call	far 0FDCh:15E6h
	add	sp,2h
	jmp	0B17h

l0DAB_0B59:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_0B5E: 0DAB:0B5E
;;   Called from:
;;     183B:0531 (in fn183B_000A)
fn0DAB_0B5E proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,1115h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5420h]
	push	word ptr es:[009Eh]
	call	far 0800h:1A13h
	add	sp,2h
	retf

;; fn0DAB_0B95: 0DAB:0B95
;;   Called from:
;;     0DAB:0CD3 (in fn0DAB_0C8F)
fn0DAB_0B95 proc
	push	bp
	mov	bp,sp
	mov	ax,12h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-4h],46Ch
	mov	word ptr [bp-2h],0h
	mov	es,[5422h]
	sub	ax,ax
	mov	es:[32ACh],ax
	mov	si,ax
	call	far 207Fh:1FADh
	les	bx,[bp-4h]
	mov	ax,es:[bx]
	mov	dx,es:[bx+2h]
	mov	[bp-0Ch],ax
	mov	[bp-0Ah],dx
	call	far 207Fh:1F9Ch

l0DAB_0BD2:
	les	bx,[bp-4h]
	mov	ax,[bp-0Ch]
	mov	dx,[bp-0Ah]
	cmp	es:[bx],ax
	jnz	0BE6h

l0DAB_0BE0:
	cmp	es:[bx+2h],dx
	jz	0BD2h

l0DAB_0BE6:
	call	far 207Fh:1FADh
	les	bx,[bp-4h]
	mov	ax,es:[bx]
	mov	dx,es:[bx+2h]
	add	ax,4h
	adc	dx,0h
	mov	[bp-0Ch],ax
	mov	[bp-0Ah],dx
	call	far 207Fh:1F9Ch

l0DAB_0C06:
	les	bx,[bp-4h]
	mov	ax,[bp-0Ch]
	mov	dx,[bp-0Ah]
	cmp	es:[bx+2h],dx
	ja	0C29h

l0DAB_0C15:
	jc	0C1Ch

l0DAB_0C17:
	cmp	es:[bx],ax
	jnc	0C29h

l0DAB_0C1C:
	inc	si
	mov	di,0C8h
	jmp	0C23h

l0DAB_0C22:
	dec	di

l0DAB_0C23:
	or	di,di
	jz	0C06h

l0DAB_0C27:
	jmp	0C22h

l0DAB_0C29:
	mov	ax,2710h
	cwd
	push	dx
	push	ax
	mov	ax,1C7h
	cwd
	push	dx
	push	ax
	mov	ax,si
	cwd
	push	dx
	push	ax
	call	far 207Fh:3E2Eh
	push	dx
	push	ax
	call	far 207Fh:3D92h
	mov	es,[5424h]
	mov	es:[3FF4h],ax
	sub	ax,ax
	mov	[bp-8h],ax
	mov	[bp-0Eh],ax
	mov	[bp-10h],ax
	jmp	0C61h

l0DAB_0C5B:
	inc	word ptr [bp-0Eh]

l0DAB_0C5E:
	inc	word ptr [bp-10h]

l0DAB_0C61:
	cmp	word ptr [bp-10h],2710h
	jge	0C76h

l0DAB_0C68:
	call	far 207Fh:0B26h
	or	ax,ax
	jz	0C5Bh

l0DAB_0C71:
	inc	word ptr [bp-8h]
	jmp	0C5Eh

l0DAB_0C76:
	mov	ax,[bp-0Eh]
	cmp	[bp-8h],ax
	jle	0C89h

l0DAB_0C7E:
	mov	es,[5422h]
	mov	word ptr es:[32ACh],1h

l0DAB_0C89:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_0C8F: 0DAB:0C8F
;;   Called from:
;;     0D27:011C (in main)
fn0DAB_0C8F proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:1D8Ch
	add	sp,4h
	mov	es,[5426h]
	push	word ptr es:[4FBAh]
	call	far 207Fh:2CE1h
	add	sp,2h
	mov	es,[5426h]
	mov	bx,es:[4FBAh]
	shl	bx,1h
	push	word ptr [bx+1140h]
	call	far 207Fh:0B73h
	add	sp,2h
	call	far 207Fh:1FBEh
	push	cs
	call	0B95h
	mov	es,[5424h]
	mov	ax,es:[3FF4h]
	sub	ax,4h
	cwd
	mov	cx,6h
	idiv	cx
	mov	es,[5428h]
	mov	es:[5006h],ax
	cmp	ax,1h
	jge	0CFCh

l0DAB_0CF5:
	mov	word ptr es:[5006h],1h

l0DAB_0CFC:
	call	far 207Fh:2CF7h
	mov	ax,0D26h
	mov	dx,0DABh
	push	dx
	push	ax
	call	far 207Fh:3C82h
	add	sp,4h
	retf

;; fn0DAB_0D12: 0DAB:0D12
;;   Called from:
;;     0D27:0839 (in main)
fn0DAB_0D12 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,2h
	push	ax
	call	far 207Fh:0B73h
	add	sp,2h
	retf
0DAB:0D26                   55 8B EC 33 C0 9A DC 2F 7F 20       U..3.../. 
0DAB:0D30 2B C0 50 9A D8 3C 7F 20 83 C4 02 5D CB          +.P..<. ...].   

;; fn0DAB_0D3D: 0DAB:0D3D
;;   Called from:
;;     183B:02E4 (in fn183B_000A)
fn0DAB_0D3D proc
	push	bp
	mov	bp,sp
	mov	ax,36h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[542Ah]
	push	word ptr es:[0A44Dh]
	mov	es,[542Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:1DF8h
	call	far 207Fh:0BC0h
	and	ax,7h
	add	ax,0Ah
	mov	[bp-6h],ax
	call	far 207Fh:0BC0h
	test	al,1h
	jz	0D87h

l0DAB_0D7F:
	mov	ax,[bp-6h]
	neg	ax
	mov	[bp-6h],ax

l0DAB_0D87:
	call	far 207Fh:0BC0h
	and	ax,7h
	add	ax,0Ah
	mov	[bp-0Ch],ax
	call	far 207Fh:0BC0h
	test	al,1h
	jz	0DA6h

l0DAB_0D9E:
	mov	ax,[bp-0Ch]
	neg	ax
	mov	[bp-0Ch],ax

l0DAB_0DA6:
	mov	ax,[bp-6h]
	add	ax,1Ah
	mov	[bp-28h],ax
	mov	[bp-30h],ax
	mov	ax,[bp-0Ch]
	add	ax,0Ch
	mov	[bp-2Eh],ax
	mov	[bp-32h],ax
	mov	word ptr [bp-20h],0Ch

l0DAB_0DC3:
	mov	si,[bp-20h]
	shl	si,1h
	mov	es,[542Eh]
	mov	word ptr es:[si+406Ah],0h
	mov	ax,0FFFFh
	mov	es,[5430h]
	mov	es:[si+4036h],ax
	mov	es,[5432h]
	mov	es:[si+4004h],ax
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],18h
	jl	0DC3h

l0DAB_0DF1:
	mov	word ptr [bp-20h],8h

l0DAB_0DF6:
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	byte ptr es:[bx+0C614h],0FFh
	call	far 207Fh:0BC0h
	test	al,1h
	jnz	0E14h

l0DAB_0E11:
	jmp	0EFFh

l0DAB_0E14:
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	si,ax
	mov	es,[5412h]
	mov	byte ptr es:[si+0C614h],1h
	mov	byte ptr es:[si+0C620h],8h
	mov	word ptr [bp-24h],0h
	mov	word ptr [bp-22h],0h

l0DAB_0E36:
	call	far 207Fh:0BC0h
	and	ax,3h
	add	[bp-24h],ax
	inc	word ptr [bp-22h]
	cmp	word ptr [bp-22h],7h
	jl	0E36h

l0DAB_0E4A:
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	si,ax
	mov	bx,[bp-24h]
	mov	es,[5434h]
	mov	al,es:[bx+2CF4h]
	mov	es,[5412h]
	mov	es:[si+0C61Fh],al
	call	far 0800h:19DDh
	mov	es,[5412h]
	mov	es:[si+0C615h],al
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	si,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	mov	es:[si+0C623h],al
	call	far 0800h:19DDh
	mov	es,[5412h]
	mov	es:[si+0C616h],al
	mov	word ptr [bp-24h],0h

l0DAB_0E9C:
	call	far 207Fh:0BC0h
	and	al,3h
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	add	bx,[bp-24h]
	mov	es,[5412h]
	mov	es:[bx+0C618h],cl
	inc	word ptr [bp-24h]
	cmp	word ptr [bp-24h],7h
	jl	0E9Ch

l0DAB_0EC2:
	call	far 207Fh:0BC0h
	and	al,3h
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	es:[bx+0C621h],cl
	call	far 0800h:19DDh
	mov	[bp-36h],ax
	call	far 0800h:19DDh
	add	al,[bp-36h]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	es:[bx+0C622h],cl

l0DAB_0EFF:
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],10h
	jge	0F0Bh

l0DAB_0F08:
	jmp	0DF6h

l0DAB_0F0B:
	mov	word ptr [bp-20h],4h

l0DAB_0F10:
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	byte ptr es:[bx+0C724h],0FFh
	call	far 207Fh:0BC0h
	test	al,1h
	jnz	0F2Eh

l0DAB_0F2B:
	jmp	0FB3h

l0DAB_0F2E:
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C530h],0FFh
	jz	0FB3h

l0DAB_0F42:
	call	far 207Fh:0BC0h
	cwd
	mov	cx,3h
	idiv	cx
	mov	[bp-34h],dx
	mov	bx,dx
	shl	bx,1h
	shl	bx,1h
	mov	es,[5436h]
	mov	ax,es:[bx+2DF8h]
	mov	dx,es:[bx+2DFAh]
	mov	[bp-0Ah],ax
	mov	[bp-8h],dx
	mov	word ptr [bp-1Ah],0h

l0DAB_0F6F:
	les	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	mov	al,es:[bx]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	add	bx,[bp-1Ah]
	mov	es,[5412h]
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-1Ah]
	cmp	word ptr [bp-1Ah],7Dh
	jl	0F6Fh

l0DAB_0F97:
	mov	bx,[bp-20h]
	mov	es,[541Ch]
	mov	byte ptr es:[bx+0D566h],0h
	cmp	word ptr [bp-34h],0h
	jz	0FB3h

l0DAB_0FAA:
	mov	bx,[bp-20h]
	mov	byte ptr es:[bx+0D566h],92h

l0DAB_0FB3:
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],8h
	jge	0FBFh

l0DAB_0FBC:
	jmp	0F10h

l0DAB_0FBF:
	sub	ax,ax
	mov	[bp-16h],ax
	mov	[bp-14h],ax
	mov	[bp-2Ch],ax
	mov	word ptr [bp-20h],8h
	jmp	1152h

l0DAB_0FD2:
	inc	word ptr [bp-28h]
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],10h
	jle	0FECh

l0DAB_0FDE:
	mov	word ptr [bp-2Ch],0h
	mov	ax,[bp-30h]
	mov	[bp-28h],ax
	inc	word ptr [bp-2Eh]

l0DAB_0FEC:
	cmp	word ptr [bp-0Eh],0h
	jz	0FF5h

l0DAB_0FF2:
	jmp	1174h

l0DAB_0FF5:
	mov	ax,[bp-28h]
	sub	ax,0Dh
	sar	ax,1h
	mov	es,[543Eh]
	add	ax,es:[09EFh]
	mov	[bp-2h],ax
	test	byte ptr [bp-28h],1h
	jnz	101Eh

l0DAB_100F:
	mov	es,[542Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	101Eh

l0DAB_101B:
	inc	word ptr [bp-2h]

l0DAB_101E:
	mov	ax,[bp-2Eh]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	es,[5440h]
	add	ax,es:[09F1h]
	mov	[bp-4h],ax
	test	byte ptr [bp-2Eh],1h
	jz	104Ah

l0DAB_103A:
	mov	es,[542Ah]
	test	byte ptr es:[0A44Dh],1h
	jz	104Ah

l0DAB_1046:
	add	word ptr [bp-4h],18h

l0DAB_104A:
	cmp	word ptr [bp-2h],0h
	jge	1053h

l0DAB_1050:
	jmp	10FDh

l0DAB_1053:
	cmp	word ptr [bp-2h],18h
	jl	105Ch

l0DAB_1059:
	jmp	10FDh

l0DAB_105C:
	cmp	word ptr [bp-4h],0h
	jge	1065h

l0DAB_1062:
	jmp	10FDh

l0DAB_1065:
	cmp	word ptr [bp-4h],240h
	jl	106Fh

l0DAB_106C:
	jmp	10FDh

l0DAB_106F:
	mov	ax,[bp-28h]
	mov	es,[542Ch]
	add	ax,es:[0A44Bh]
	sub	ax,1Ah
	mov	[bp-10h],ax
	test	byte ptr [bp-10h],80h
	jz	1099h

l0DAB_1087:
	cmp	word ptr [bp-28h],1Ah
	jge	1094h

l0DAB_108D:
	and	word ptr [bp-10h],0F7Fh
	jmp	1099h

l0DAB_1094:
	add	word ptr [bp-10h],80h

l0DAB_1099:
	mov	ax,[bp-2Eh]
	mov	es,[542Ah]
	add	ax,es:[0A44Dh]
	sub	ax,0Ch
	mov	[bp-12h],ax
	test	byte ptr [bp-12h],80h
	jz	10C3h

l0DAB_10B1:
	cmp	word ptr [bp-2Eh],0Ch
	jge	10BEh

l0DAB_10B7:
	and	word ptr [bp-12h],0F07Fh
	jmp	10C3h

l0DAB_10BE:
	add	word ptr [bp-12h],0F80h

l0DAB_10C3:
	mov	si,[bp-20h]
	shl	si,1h
	mov	ax,[bp-10h]
	mov	es,[5432h]
	mov	es:[si+4014h],ax
	mov	ax,[bp-12h]
	mov	es,[5430h]
	mov	es:[si+4046h],ax
	mov	bx,[bp-20h]
	mov	es,[5442h]
	mov	byte ptr es:[bx+40A2h],10h
	mov	es,[542Eh]
	mov	word ptr es:[si+407Ah],1h
	inc	word ptr [bp-14h]
	jmp	1135h

l0DAB_10FD:
	mov	si,[bp-20h]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[5430h]
	mov	es:[si+4046h],ax
	mov	es,[5432h]
	mov	es:[si+4014h],ax
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	es:[bx+0C614h],cl
	mov	es,[542Eh]
	mov	word ptr es:[si+407Ah],0h

l0DAB_1135:
	inc	word ptr [bp-28h]
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],10h
	jle	114Fh

l0DAB_1141:
	mov	word ptr [bp-2Ch],0h
	mov	ax,[bp-30h]
	mov	[bp-28h],ax
	inc	word ptr [bp-2Eh]

l0DAB_114F:
	inc	word ptr [bp-20h]

l0DAB_1152:
	cmp	word ptr [bp-20h],10h
	jl	115Bh

l0DAB_1158:
	jmp	11F5h

l0DAB_115B:
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jz	114Fh

l0DAB_116F:
	mov	word ptr [bp-0Eh],1h

l0DAB_1174:
	mov	ax,[bp-2Eh]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	cx,[bp-28h]
	sub	cx,0Dh
	sar	cx,1h
	add	ax,cx
	mov	es,[5438h]
	add	ax,es:[09EDh]
	mov	[bp-18h],ax
	test	byte ptr [bp-28h],1h
	jnz	11A9h

l0DAB_119A:
	mov	es,[542Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	11A9h

l0DAB_11A6:
	inc	word ptr [bp-18h]

l0DAB_11A9:
	test	byte ptr [bp-2Eh],1h
	jz	11BFh

l0DAB_11AF:
	mov	es,[542Ah]
	test	byte ptr es:[0A44Dh],1h
	jz	11BFh

l0DAB_11BB:
	add	word ptr [bp-18h],18h

l0DAB_11BF:
	mov	bx,[bp-18h]
	mov	es,[543Ah]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-1Ch],ax
	cmp	ax,0Fh
	jg	11D8h

l0DAB_11D5:
	jmp	0FD2h

l0DAB_11D8:
	mov	es,[543Ch]
	cmp	es:[0150h],ax
	jg	11E6h

l0DAB_11E3:
	jmp	0FD2h

l0DAB_11E6:
	or	bx,bx
	jge	11EDh

l0DAB_11EA:
	jmp	0FD2h

l0DAB_11ED:
	mov	word ptr [bp-0Eh],0h
	jmp	0FECh

l0DAB_11F5:
	inc	word ptr [bp-28h]
	inc	word ptr [bp-2Ch]
	mov	word ptr [bp-20h],4h
	jmp	13D6h

l0DAB_1203:
	inc	word ptr [bp-26h]

l0DAB_1206:
	mov	bx,[bp-18h]
	mov	es,[543Ah]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-1Ch],ax
	mov	bx,[bp-26h]
	mov	al,es:[bx+7ADh]
	mov	[bp-2Ah],ax
	cmp	word ptr [bp-1Ch],0Fh
	jle	1257h

l0DAB_1228:
	mov	es,[543Ch]
	mov	ax,[bp-1Ch]
	cmp	es:[0150h],ax
	jle	1257h

l0DAB_1236:
	cmp	word ptr [bp-18h],0h
	jl	1257h

l0DAB_123C:
	cmp	word ptr [bp-2Ah],0Fh
	jle	1257h

l0DAB_1242:
	mov	ax,[bp-2Ah]
	cmp	es:[0150h],ax
	jle	1257h

l0DAB_124C:
	or	bx,bx
	jl	1257h

l0DAB_1250:
	mov	word ptr [bp-0Eh],0h
	jmp	1271h

l0DAB_1257:
	inc	word ptr [bp-28h]
	inc	word ptr [bp-2Ch]
	cmp	word ptr [bp-2Ch],10h
	jle	1271h

l0DAB_1263:
	mov	word ptr [bp-2Ch],0h
	mov	ax,[bp-30h]
	mov	[bp-28h],ax
	inc	word ptr [bp-2Eh]

l0DAB_1271:
	cmp	word ptr [bp-0Eh],0h
	jz	127Ah

l0DAB_1277:
	jmp	13F8h

l0DAB_127A:
	mov	ax,[bp-28h]
	sub	ax,0Dh
	sar	ax,1h
	mov	es,[543Eh]
	add	ax,es:[09EFh]
	mov	[bp-2h],ax
	test	byte ptr [bp-28h],1h
	jnz	12A3h

l0DAB_1294:
	mov	es,[542Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	12A3h

l0DAB_12A0:
	inc	word ptr [bp-2h]

l0DAB_12A3:
	mov	ax,[bp-2Eh]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	es,[5440h]
	add	ax,es:[09F1h]
	mov	[bp-4h],ax
	test	byte ptr [bp-2Eh],1h
	jz	12CFh

l0DAB_12BF:
	mov	es,[542Ah]
	test	byte ptr es:[0A44Dh],1h
	jz	12CFh

l0DAB_12CB:
	add	word ptr [bp-4h],18h

l0DAB_12CF:
	cmp	word ptr [bp-2h],0h
	jge	12D8h

l0DAB_12D5:
	jmp	137Fh

l0DAB_12D8:
	cmp	word ptr [bp-2h],18h
	jl	12E1h

l0DAB_12DE:
	jmp	137Fh

l0DAB_12E1:
	cmp	word ptr [bp-4h],0h
	jge	12EAh

l0DAB_12E7:
	jmp	137Fh

l0DAB_12EA:
	cmp	word ptr [bp-4h],240h
	jl	12F4h

l0DAB_12F1:
	jmp	137Fh

l0DAB_12F4:
	mov	ax,[bp-28h]
	mov	es,[542Ch]
	add	ax,es:[0A44Bh]
	sub	ax,1Ah
	mov	[bp-10h],ax
	test	byte ptr [bp-10h],80h
	jz	131Eh

l0DAB_130C:
	cmp	word ptr [bp-28h],1Ah
	jge	1319h

l0DAB_1312:
	and	word ptr [bp-10h],0F7Fh
	jmp	131Eh

l0DAB_1319:
	add	word ptr [bp-10h],80h

l0DAB_131E:
	mov	ax,[bp-2Eh]
	mov	es,[542Ah]
	add	ax,es:[0A44Dh]
	sub	ax,0Ch
	mov	[bp-12h],ax
	test	byte ptr [bp-12h],80h
	jz	1348h

l0DAB_1336:
	cmp	word ptr [bp-2Eh],0Ch
	jge	1343h

l0DAB_133C:
	and	word ptr [bp-12h],0F07Fh
	jmp	1348h

l0DAB_1343:
	add	word ptr [bp-12h],0F80h

l0DAB_1348:
	mov	si,[bp-20h]
	shl	si,1h
	mov	ax,[bp-10h]
	mov	es,[5432h]
	mov	es:[si+4014h],ax
	mov	ax,[bp-12h]
	mov	es,[5430h]
	mov	es:[si+4046h],ax
	mov	bx,[bp-20h]
	mov	es,[5442h]
	mov	byte ptr es:[bx+40A2h],0h
	mov	es,[542Eh]
	mov	word ptr es:[si+407Ah],1h
	jmp	13B7h

l0DAB_137F:
	mov	si,[bp-20h]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[5430h]
	mov	es:[si+4046h],ax
	mov	es,[5432h]
	mov	es:[si+4014h],ax
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	es:[bx+0C724h],cl
	mov	es,[542Eh]
	mov	word ptr es:[si+407Ah],0h

l0DAB_13B7:
	add	word ptr [bp-28h],3h
	add	word ptr [bp-2Ch],3h
	cmp	word ptr [bp-2Ch],8h
	jle	13D3h

l0DAB_13C5:
	mov	word ptr [bp-2Ch],0h
	mov	ax,[bp-30h]
	mov	[bp-28h],ax
	inc	word ptr [bp-2Eh]

l0DAB_13D3:
	inc	word ptr [bp-20h]

l0DAB_13D6:
	cmp	word ptr [bp-20h],8h
	jl	13DFh

l0DAB_13DC:
	jmp	1462h

l0DAB_13DF:
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	13D3h

l0DAB_13F3:
	mov	word ptr [bp-0Eh],1h

l0DAB_13F8:
	mov	ax,[bp-2Eh]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	cx,[bp-28h]
	sub	cx,0Dh
	sar	cx,1h
	add	ax,cx
	mov	es,[5438h]
	add	ax,es:[09EDh]
	mov	[bp-18h],ax
	test	byte ptr [bp-28h],1h
	jnz	142Dh

l0DAB_141E:
	mov	es,[542Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	142Dh

l0DAB_142A:
	inc	word ptr [bp-18h]

l0DAB_142D:
	test	byte ptr [bp-2Eh],1h
	jz	1443h

l0DAB_1433:
	mov	es,[542Ah]
	test	byte ptr es:[0A44Dh],1h
	jz	1443h

l0DAB_143F:
	add	word ptr [bp-18h],18h

l0DAB_1443:
	mov	ax,[bp-18h]
	mov	[bp-26h],ax
	mov	al,[bp-28h]
	mov	es,[542Ch]
	xor	al,es:[0A44Bh]
	test	al,1h
	jnz	145Ch

l0DAB_1459:
	jmp	1203h

l0DAB_145C:
	dec	word ptr [bp-26h]
	jmp	1206h

l0DAB_1462:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_1467: 0DAB:1467
;;   Called from:
;;     183B:2711 (in fn183B_2591)
fn0DAB_1467 proc
	push	bp
	mov	bp,sp
	mov	ax,36h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-1Ah],8h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	148Ah

l0DAB_1485:
	mov	word ptr [bp-1Ah],2h

l0DAB_148A:
	mov	ax,[bp+8h]
	mov	[bp-20h],ax
	cmp	word ptr [bp+0Ah],0h
	jnz	149Ah

l0DAB_1496:
	add	word ptr [bp-20h],4h

l0DAB_149A:
	sub	ax,ax
	mov	[bp-10h],ax
	mov	[bp-12h],ax

l0DAB_14A2:
	mov	si,[bp-20h]
	shl	si,1h
	mov	es,[542Eh]
	cmp	word ptr es:[si+406Ah],0h
	jnz	14B6h

l0DAB_14B3:
	jmp	16D9h

l0DAB_14B6:
	mov	es,[5432h]
	cmp	word ptr es:[si+4004h],0FFh
	jnz	14C5h

l0DAB_14C2:
	jmp	16D9h

l0DAB_14C5:
	mov	es,[5430h]
	cmp	word ptr es:[si+4036h],0FFh
	jnz	14D4h

l0DAB_14D1:
	jmp	16D9h

l0DAB_14D4:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],0Fh
	cmp	word ptr [bp-20h],0Ch
	jge	1508h

l0DAB_14F6:
	mov	ax,1h
	push	ax
	push	ax
	push	word ptr [bp-20h]
	push	cs
	call	18E8h
	add	sp,6h
	jmp	1610h

l0DAB_1508:
	cmp	word ptr [bp-20h],10h
	jge	152Ch

l0DAB_150E:
	mov	ax,1148h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	lea	ax,[bx+0C33Ch]
	mov	dx,3092h
	jmp	15A2h

l0DAB_152C:
	mov	ax,114Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-20h]
	sub	ax,8h
	push	ax
	call	far 1631h:02E4h
	add	sp,2h
	mov	es,[5444h]
	mov	word ptr es:[3748h],0h
	mov	es,[5446h]
	mov	word ptr es:[374Eh],7h
	call	far 0800h:28A2h
	mov	ax,115Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5444h]
	mov	word ptr es:[3748h],0h
	mov	es,[5446h]
	mov	word ptr es:[374Eh],8h
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,11h
	imul	byte ptr es:[bx+0C597h]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh

l0DAB_15A2:
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:28A2h
	mov	ax,1166h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	si,[bp+6h]
	shl	si,1h
	mov	di,[bp-20h]
	shl	di,1h
	mov	es,[5430h]
	push	word ptr es:[di+4036h]
	mov	es,[5432h]
	push	word ptr es:[di+4004h]
	mov	es,[5430h]
	push	word ptr es:[si+4036h]
	mov	es,[5432h]
	push	word ptr es:[si+4004h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5448h]
	push	word ptr es:[bx+1ACh]
	push	word ptr es:[bx+1AAh]
	call	far 1E56h:03F5h
	add	sp,4h

l0DAB_1610:
	mov	ax,1h
	push	ax
	push	word ptr [bp-20h]
	call	far 183Bh:1774h
	add	sp,4h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[544Ah]
	mov	word ptr es:[00C6h],2h
	mov	ax,1174h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-0Eh],0h
	cmp	word ptr [bp+0Ah],0h
	jz	1682h

l0DAB_1653:
	cmp	word ptr [bp-20h],4h
	jl	1665h

l0DAB_1659:
	cmp	word ptr [bp-20h],0Ch
	jl	1682h

l0DAB_165F:
	cmp	word ptr [bp-20h],10h
	jge	1682h

l0DAB_1665:
	mov	ax,1189h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[544Ah]
	mov	word ptr es:[00C6h],3h
	mov	word ptr [bp-0Eh],1h

l0DAB_1682:
	mov	ax,1195h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[544Ah]
	mov	word ptr es:[00C2h],1h
	mov	word ptr es:[00C8h],0h
	mov	ax,3h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-12h],ax
	cmp	ax,1h
	jnz	16D9h

l0DAB_16B5:
	cmp	word ptr [bp-0Eh],0h
	jz	16D9h

l0DAB_16BB:
	mov	word ptr [bp-12h],0h
	push	word ptr [bp-20h]
	push	cs
	call	1AFEh
	add	sp,2h
	mov	ax,1h
	push	ax
	call	far 1631h:032Fh
	add	sp,2h
	dec	word ptr [bp-20h]

l0DAB_16D9:
	mov	ax,[bp+8h]
	add	ax,0Bh
	inc	word ptr [bp-20h]
	cmp	ax,[bp-20h]
	jge	16F7h

l0DAB_16E7:
	mov	ax,[bp+8h]
	mov	[bp-20h],ax
	cmp	word ptr [bp+0Ah],0h
	jnz	16F7h

l0DAB_16F3:
	add	word ptr [bp-20h],4h

l0DAB_16F7:
	mov	es,[544Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	170Eh

l0DAB_1703:
	cmp	word ptr [bp-20h],0Bh
	jle	170Eh

l0DAB_1709:
	mov	word ptr [bp-20h],0Ch

l0DAB_170E:
	cmp	word ptr [bp-12h],0h
	jnz	1717h

l0DAB_1714:
	jmp	14A2h

l0DAB_1717:
	mov	es,[544Ah]
	mov	word ptr es:[00C2h],0h
	mov	word ptr es:[00C8h],6h
	cmp	word ptr [bp-10h],0h
	jz	173Bh

l0DAB_172F:
	mov	ax,1h
	push	ax
	call	far 1631h:032Fh
	add	sp,2h

l0DAB_173B:
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],0Fh
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_174C: 0DAB:174C
;;   Called from:
;;     0DAB:2215 (in fn0DAB_1AFE)
;;     0DAB:2265 (in fn0DAB_1AFE)
fn0DAB_174C proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	ax,[bp+8h]
	mov	[bp-2h],ax
	cmp	word ptr [bp+0Ch],0h
	jnz	1766h

l0DAB_1763:
	jmp	180Fh

l0DAB_1766:
	mov	word ptr [bp-4h],4h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	177Ch

l0DAB_1777:
	mov	word ptr [bp-4h],2h

l0DAB_177C:
	cmp	word ptr [bp+0Ch],1h
	jle	178Ch

l0DAB_1782:
	mov	ax,[bp+8h]
	sub	ax,[bp+0Ch]
	inc	ax
	mov	[bp-2h],ax

l0DAB_178C:
	cmp	word ptr [bp+8h],0B7h
	jnz	17EDh

l0DAB_1793:
	mov	ax,[bp+0Ch]
	cwd
	mov	cx,6h
	idiv	cx
	sub	ax,0Ah
	neg	ax
	mov	[121Ah],ax
	cmp	word ptr [121Ch],0h
	jnz	17C3h

l0DAB_17AB:
	mov	word ptr [121Ch],4h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	17C3h

l0DAB_17BD:
	mov	word ptr [121Ch],2h

l0DAB_17C3:
	dec	word ptr [1218h]
	jns	17E7h

l0DAB_17C9:
	mov	ax,[121Ah]
	mov	[1218h],ax
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	17E2h

l0DAB_17DB:
	xor	byte ptr [121Ch],1h
	jmp	17E7h

l0DAB_17E2:
	xor	byte ptr [121Ch],0Ah

l0DAB_17E7:
	mov	ax,[121Ch]
	mov	[bp-4h],ax

l0DAB_17ED:
	push	word ptr [bp-4h]
	push	word ptr [bp+8h]
	mov	ax,[bp+6h]
	add	ax,5h
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp+6h]
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	mov	ax,[bp-2h]
	dec	ax
	mov	[bp+8h],ax

l0DAB_180F:
	cmp	word ptr [bp+0Ah],0h
	jz	1854h

l0DAB_1815:
	mov	word ptr [bp-4h],2h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1829h

l0DAB_1826:
	dec	word ptr [bp-4h]

l0DAB_1829:
	cmp	word ptr [bp+0Ah],1h
	jle	1839h

l0DAB_182F:
	mov	ax,[bp+8h]
	sub	ax,[bp+0Ah]
	inc	ax
	mov	[bp-2h],ax

l0DAB_1839:
	push	word ptr [bp-4h]
	push	word ptr [bp+8h]
	mov	ax,[bp+6h]
	add	ax,5h
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp+6h]
	call	far 1F3Dh:01FBh
	add	sp,0Ah

l0DAB_1854:
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_1858: 0DAB:1858
;;   Called from:
;;     0DAB:1DB1 (in fn0DAB_1AFE)
;;     0DAB:1DDD (in fn0DAB_1AFE)
;;     0DAB:1E06 (in fn0DAB_1AFE)
;;     0DAB:1E5A (in fn0DAB_1AFE)
fn0DAB_1858 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-2h],2h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	187Bh

l0DAB_1876:
	mov	word ptr [bp-2h],1h

l0DAB_187B:
	mov	word ptr [bp-4h],0h
	jmp	18DAh

l0DAB_1882:
	cmp	word ptr [bp-4h],5h
	jnz	188Fh

l0DAB_1888:
	sub	word ptr [bp+6h],5h
	inc	word ptr [bp+8h]

l0DAB_188F:
	mov	ax,[bp+0Ch]
	cmp	[bp-4h],ax
	jnz	18ADh

l0DAB_1897:
	mov	word ptr [bp-2h],4h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	18ADh

l0DAB_18A8:
	mov	word ptr [bp-2h],2h

l0DAB_18AD:
	mov	si,[bp+6h]
	mov	cl,3h
	shl	si,cl
	mov	di,[bp+8h]
	shl	di,cl
	push	word ptr [bp-2h]
	lea	ax,[di+5h]
	push	ax
	lea	ax,[si+4h]
	push	ax
	lea	ax,[di+3h]
	push	ax
	lea	ax,[si+2h]
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	inc	word ptr [bp+6h]
	inc	word ptr [bp-4h]

l0DAB_18DA:
	mov	ax,[bp+0Ah]
	cmp	[bp-4h],ax
	jl	1882h

l0DAB_18E2:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_18E8: 0DAB:18E8
;;   Called from:
;;     0DAB:14FE (in fn0DAB_1467)
;;     183B:1537 (in fn183B_14C3)
fn0DAB_18E8 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],0Fh
	cmp	word ptr [bp+6h],4h
	jge	195Ch

l0DAB_1905:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,11h
	mul	byte ptr es:[bx+0C79Dh]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,121Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	lea	ax,[bx+0C724h]
	mov	dx,3092h
	push	dx
	jmp	1AF0h

l0DAB_195C:
	mov	ax,[bp+6h]
	sub	ax,4h
	mov	[bp-4h],ax
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp+0Ah],0h
	jnz	199Ch

l0DAB_1999:
	jmp	1AF9h

l0DAB_199C:
	mov	es,[5412h]
	cmp	byte ptr es:[0D333h],0h
	jz	19DDh

l0DAB_19A8:
	mov	al,es:[0D331h]
	cbw
	cmp	ax,[bp-4h]
	jnz	19DDh

l0DAB_19B2:
	cmp	word ptr [bp+8h],0h
	jz	19DDh

l0DAB_19B8:
	mov	ax,1222h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	mov	es,[544Eh]
	mov	word ptr es:[374Ah],1h
	jmp	1AF9h

l0DAB_19DD:
	push	word ptr [bp-4h]
	call	far 1631h:02E4h
	add	sp,2h
	mov	es,[5444h]
	mov	word ptr es:[3748h],0h
	mov	es,[5446h]
	mov	word ptr es:[374Eh],7h
	call	far 0800h:28A2h
	mov	ax,1245h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5444h]
	mov	word ptr es:[3748h],0h
	mov	es,[5446h]
	mov	word ptr es:[374Eh],8h
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,11h
	imul	byte ptr es:[bx+0C61Fh]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5444h]
	mov	word ptr es:[3748h],0h
	mov	es,[5446h]
	mov	word ptr es:[374Eh],0Ah
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	si,ax
	mov	es,[5412h]
	mov	al,es:[si+0C621h]
	cbw
	mov	[bp-2h],ax
	or	ax,ax
	jz	1AECh

l0DAB_1A7B:
	mov	al,es:[si+0C622h]
	cbw
	mov	[bp-6h],ax
	or	ax,ax
	jz	1AC5h

l0DAB_1A88:
	mov	bx,[bp-2h]
	mov	es,[5450h]
	mov	al,es:[bx+4DDBh]
	cbw
	cmp	ax,[bp-6h]
	jz	1AB1h

l0DAB_1A9A:
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jz	1AB1h

l0DAB_1AA6:
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],0Eh

l0DAB_1AB1:
	shl	bx,1h
	shl	bx,1h
	mov	es,[5452h]
	push	word ptr es:[bx+4E8Ch]
	push	word ptr es:[bx+4E8Ah]
	jmp	1AF1h

l0DAB_1AC5:
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],8h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1AE7h

l0DAB_1ADC:
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],2h

l0DAB_1AE7:
	mov	ax,1257h
	jmp	1AEFh

l0DAB_1AEC:
	mov	ax,1260h

l0DAB_1AEF:
	push	ds

l0DAB_1AF0:
	push	ax

l0DAB_1AF1:
	call	far 1E56h:03F5h
	add	sp,4h

l0DAB_1AF9:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0DAB_1AFE: 0DAB:1AFE
;;   Called from:
;;     0800:3821 (in fn0800_378D)
;;     0DAB:16C3 (in fn0DAB_1467)
fn0DAB_1AFE proc
	push	bp
	mov	bp,sp
	mov	ax,38h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-1Ah],8h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1B20h

l0DAB_1B1B:
	mov	word ptr [bp-1Ah],2h

l0DAB_1B20:
	mov	ax,1265h
	mov	[bp-0Ch],ax
	mov	[bp-0Ah],ds
	mov	ax,1269h
	mov	[bp-32h],ax
	mov	[bp-30h],ds
	mov	ax,126Dh
	mov	[bp-8h],ax
	mov	[bp-6h],ds
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[5454h]
	cmp	word ptr es:[4594h],0h
	jnz	1B7Eh

l0DAB_1B58:
	inc	word ptr es:[4594h]
	mov	ax,1h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	ax,0A0h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,1272h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h

l0DAB_1B7E:
	mov	es,[5456h]
	mov	word ptr es:[4FBCh],0h
	mov	ax,0h
	mov	dx,3056h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,0A0h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],2h
	jnz	1BF1h

l0DAB_1BBD:
	mov	ax,0A800h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h
	mov	ax,0C8h
	push	ax
	mov	ax,28h
	push	ax
	sub	ax,ax
	push	ax
	push	ax
	mov	dx,0A000h
	push	dx
	push	ax
	mov	dx,0A800h
	push	dx
	push	ax
	call	far 207Fh:245Ch
	add	sp,10h
	jmp	1C0Dh

l0DAB_1BF1:
	mov	ax,0C8h
	push	ax
	mov	ax,28h
	push	ax
	sub	ax,ax
	push	ax
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1F3Dh:0086h
	add	sp,0Ch

l0DAB_1C0D:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	sub	ax,ax
	push	ax
	push	ax
	mov	ax,127Eh
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,[bp+6h]
	mov	[bp-2Eh],ax
	cmp	ax,0Ch
	jl	1C34h

l0DAB_1C30:
	sub	word ptr [bp-2Eh],8h

l0DAB_1C34:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	lea	ax,[bx+0C724h]
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	es,[541Ah]
	mov	byte ptr es:[001Ah],0h
	sub	ax,ax
	push	ax
	mov	ax,0Eh
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C734h]
	sub	ah,ah
	push	ax
	call	far 207Fh:3BB6h
	add	sp,8h
	sub	ax,ax
	push	ax
	mov	ax,0Eh
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	cmp	word ptr [bp-2Eh],4h
	jl	1CCDh

l0DAB_1CCA:
	jmp	1D71h

l0DAB_1CCD:
	sub	ax,ax
	push	ax
	mov	ax,0Eh
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,11h
	mul	byte ptr es:[bx+0C79Dh]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C79Eh]
	mov	[bp-38h],al
	cmp	al,0FFh
	jz	1D5Dh

l0DAB_1D2B:
	sub	ax,ax
	push	ax
	mov	ax,0Eh
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,6h
	push	ax
	mov	al,11h
	mul	byte ptr [bp-38h]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5414h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	jmp	1D85h

l0DAB_1D5D:
	sub	ax,ax
	push	ax
	mov	ax,0Eh
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,12AAh
	jmp	1D83h

l0DAB_1D71:
	sub	ax,ax
	push	ax
	mov	ax,0Eh
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,12AFh

l0DAB_1D83:
	push	ds
	push	ax

l0DAB_1D85:
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C799h]
	sub	ah,ah
	sub	ax,3h
	neg	ax
	push	ax
	mov	ax,3h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,25h
	push	ax
	push	cs
	call	1858h
	add	sp,8h
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C79Ah]
	sub	ah,ah
	sub	ax,2h
	neg	ax
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,25h
	push	ax
	push	cs
	call	1858h
	add	sp,8h
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C79Bh]
	sub	ah,ah
	sub	ax,2h
	neg	ax
	push	ax
	mov	ax,2h
	push	ax
	push	ax
	mov	ax,25h
	push	ax
	push	cs
	call	1858h
	add	sp,8h
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C74Ah]
	sub	ah,ah
	mov	[bp-1Eh],ax
	mov	word ptr [bp-24h],33h

l0DAB_1E28:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	add	bx,[bp-24h]
	mov	es,[5412h]
	cmp	byte ptr es:[bx+0C724h],22h
	jnz	1E42h

l0DAB_1E3F:
	inc	word ptr [bp-1Eh]

l0DAB_1E42:
	inc	word ptr [bp-24h]
	cmp	word ptr [bp-24h],55h
	jle	1E28h

l0DAB_1E4B:
	push	word ptr [bp-1Eh]
	mov	ax,0Ah
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,22h
	push	ax
	push	cs
	call	1858h
	add	sp,8h
	mov	word ptr [bp-28h],6h
	mov	word ptr [bp-24h],33h

l0DAB_1E6B:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	add	bx,[bp-24h]
	mov	es,[5412h]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	and	ax,7Fh
	mov	[bp-34h],ax
	cmp	ax,10h
	jge	1E8Fh

l0DAB_1E8C:
	jmp	1F7Ah

l0DAB_1E8F:
	cmp	ax,20h
	jle	1E97h

l0DAB_1E94:
	jmp	1F7Ah

l0DAB_1E97:
	mov	word ptr [bp-36h],0Eh
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1EADh

l0DAB_1EA8:
	mov	word ptr [bp-36h],1h

l0DAB_1EAD:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	add	bx,[bp-24h]
	mov	es,[5412h]
	test	byte ptr es:[bx+0C724h],80h
	jz	1ECAh

l0DAB_1EC4:
	mov	ax,[bp-1Ah]
	mov	[bp-36h],ax

l0DAB_1ECA:
	sub	ax,ax
	push	ax
	push	word ptr [bp-36h]
	push	word ptr [bp-28h]
	push	ax
	mov	ax,11h
	imul	word ptr [bp-34h]
	mov	bx,ax
	lea	ax,[bx+2EC7h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,12BFh
	mov	[bp-16h],ax
	mov	[bp-14h],ds
	cmp	word ptr [bp-24h],3Ah
	jl	1F02h

l0DAB_1EFC:
	mov	ax,12C2h
	mov	[bp-16h],ax

l0DAB_1F02:
	cmp	word ptr [bp-24h],41h
	jl	1F11h

l0DAB_1F08:
	mov	ax,12C5h
	mov	[bp-16h],ax
	mov	[bp-14h],ds

l0DAB_1F11:
	cmp	word ptr [bp-24h],48h
	jl	1F20h

l0DAB_1F17:
	mov	ax,12C8h
	mov	[bp-16h],ax
	mov	[bp-14h],ds

l0DAB_1F20:
	cmp	word ptr [bp-24h],4Fh
	jl	1F2Fh

l0DAB_1F26:
	mov	ax,12CBh
	mov	[bp-16h],ax
	mov	[bp-14h],ds

l0DAB_1F2F:
	cmp	word ptr [bp-24h],51h
	jl	1F3Eh

l0DAB_1F35:
	mov	ax,12CEh
	mov	[bp-16h],ax
	mov	[bp-14h],ds

l0DAB_1F3E:
	cmp	word ptr [bp-24h],53h
	jl	1F4Dh

l0DAB_1F44:
	mov	ax,12D1h
	mov	[bp-16h],ax
	mov	[bp-14h],ds

l0DAB_1F4D:
	cmp	word ptr [bp-24h],55h
	jl	1F5Ch

l0DAB_1F53:
	mov	ax,12D4h
	mov	[bp-16h],ax
	mov	[bp-14h],ds

l0DAB_1F5C:
	sub	ax,ax
	push	ax
	push	word ptr [bp-36h]
	push	word ptr [bp-28h]
	inc	word ptr [bp-28h]
	mov	ax,0Bh
	push	ax
	push	word ptr [bp-14h]
	push	word ptr [bp-16h]
	call	far 1F3Dh:00D5h
	add	sp,0Ch

l0DAB_1F7A:
	inc	word ptr [bp-24h]
	cmp	word ptr [bp-24h],55h
	jg	1F86h

l0DAB_1F83:
	jmp	1E6Bh

l0DAB_1F86:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,13h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,12D6h
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],0Eh
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1FC3h

l0DAB_1FB8:
	mov	es,[541Eh]
	mov	word ptr es:[37FEh],1h

l0DAB_1FC3:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,14h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,12E0h
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C748h]
	and	al,0Fh
	cmp	al,0Fh
	jnz	200Ch

l0DAB_1FF5:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,14h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-0Ch]
	jmp	2047h

l0DAB_200C:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	test	byte ptr es:[bx+0C748h],0Fh
	jnz	2032h

l0DAB_201C:
	sub	ax,ax
	push	ax
	push	word ptr [bp-1Ah]
	mov	ax,14h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-8h]
	jmp	2047h

l0DAB_2032:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,14h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-30h]
	push	word ptr [bp-32h]

l0DAB_2047:
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	mov	es,[5412h]
	mov	al,es:[bx+0C749h]
	and	al,0Fh
	cmp	al,0Fh
	jnz	207Dh

l0DAB_2066:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,15h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-0Ch]
	jmp	20B8h

l0DAB_207D:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	test	byte ptr es:[bx+0C749h],0Fh
	jnz	20A3h

l0DAB_208D:
	sub	ax,ax
	push	ax
	push	word ptr [bp-1Ah]
	mov	ax,15h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-8h]
	jmp	20B8h

l0DAB_20A3:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,15h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-30h]
	push	word ptr [bp-32h]

l0DAB_20B8:
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	si,ax
	mov	es,[5412h]
	mov	al,es:[si+0C748h]
	and	al,0F0h
	mov	cl,es:[si+0C78Dh]
	and	cl,0F0h
	cmp	al,cl
	jnz	20F6h

l0DAB_20DF:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,16h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-0Ch]
	jmp	2131h

l0DAB_20F6:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	test	byte ptr es:[bx+0C748h],0F0h
	jnz	211Ch

l0DAB_2106:
	sub	ax,ax
	push	ax
	push	word ptr [bp-1Ah]
	mov	ax,16h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-8h]
	jmp	2131h

l0DAB_211C:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,16h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-30h]
	push	word ptr [bp-32h]

l0DAB_2131:
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	si,ax
	mov	es,[5412h]
	mov	al,es:[si+0C749h]
	and	al,0F0h
	mov	cl,es:[si+0C78Eh]
	and	cl,0F0h
	cmp	al,cl
	jnz	216Fh

l0DAB_2158:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,17h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-0Ah]
	push	word ptr [bp-0Ch]
	jmp	21AAh

l0DAB_216F:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	test	byte ptr es:[bx+0C749h],0F0h
	jnz	2195h

l0DAB_217F:
	sub	ax,ax
	push	ax
	push	word ptr [bp-1Ah]
	mov	ax,17h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-8h]
	jmp	21AAh

l0DAB_2195:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,17h
	push	ax
	mov	ax,0Ah
	push	ax
	push	word ptr [bp-30h]
	push	word ptr [bp-32h]

l0DAB_21AA:
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	word ptr [bp-2Ah],0h
	mov	word ptr [bp-4h],258h
	jmp	22E1h

l0DAB_21BF:
	mov	word ptr [bp-24h],0h

l0DAB_21C4:
	mov	word ptr [bp-1Ch],0h
	mov	bx,[bp-24h]
	shl	bx,1h
	mov	si,[bx+1306h]
	or	si,si
	jz	21EEh

l0DAB_21D6:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	add	bx,si
	mov	es,[5412h]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	mov	[bp-1Ch],ax

l0DAB_21EE:
	mov	si,[bp-24h]
	shl	si,1h
	push	word ptr [bp-1Ch]
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	add	bx,[bp-24h]
	mov	es,[5412h]
	mov	al,es:[bx+0C735h]
	sub	ah,ah
	push	ax
	push	word ptr [si+1332h]
	push	word ptr [si+131Ch]
	push	cs
	call	174Ch
	add	sp,8h
	inc	word ptr [bp-24h]
	cmp	word ptr [bp-24h],0Bh
	jl	21C4h

l0DAB_2225:
	mov	bx,[bp-2Eh]
	mov	es,[5458h]
	cmp	byte ptr es:[bx+6Eh],0h
	jge	223Ah

l0DAB_2234:
	mov	byte ptr es:[bx+6Eh],0h

l0DAB_223A:
	mov	bx,[bp-2Eh]
	cmp	byte ptr es:[bx+6Eh],1Eh
	jle	224Bh

l0DAB_2245:
	mov	byte ptr es:[bx+6Eh],1Eh

l0DAB_224B:
	mov	bx,[bp-2Eh]
	mov	al,es:[bx+6Eh]
	cbw
	mov	si,ax
	push	si
	mov	ax,1Eh
	sub	ax,si
	push	ax
	mov	ax,0B7h
	push	ax
	mov	ax,100h
	push	ax
	push	cs
	call	174Ch
	add	sp,8h
	mov	ax,1h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	inc	word ptr [bp-22h]
	cmp	word ptr [bp-22h],10h
	jnz	22BDh

l0DAB_2281:
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],3h
	jz	2292h

l0DAB_228D:
	mov	ax,1348h
	jmp	2295h

l0DAB_2292:
	mov	ax,1358h

l0DAB_2295:
	push	ds
	push	ax
	call	far 1F3Dh:0525h
	add	sp,4h
	inc	word ptr [bp-2Ch]
	mov	ax,[bp-2Ch]
	and	ax,3h
	mov	[bp-2Ch],ax
	mov	bx,ax
	mov	al,[bx+1378h]
	mov	[134Ch],al
	shl	bx,1h
	mov	ax,[bx+137Ch]
	mov	[1360h],ax

l0DAB_22BD:
	and	word ptr [bp-22h],0Fh
	mov	es,[545Ah]
	cmp	word ptr es:[3938h],0h
	jnz	22D7h

l0DAB_22CD:
	call	far 1F3Dh:002Fh
	mov	[bp-2Ah],ax
	jmp	22E1h

l0DAB_22D7:
	dec	word ptr [bp-4h]
	jnz	22E1h

l0DAB_22DC:
	mov	word ptr [bp-2Ah],1h

l0DAB_22E1:
	cmp	word ptr [bp-2Ah],0h
	jnz	22EAh

l0DAB_22E7:
	jmp	21BFh

l0DAB_22EA:
	mov	es,[5426h]
	cmp	word ptr es:[4FBAh],3h
	jz	22FEh

l0DAB_22F6:
	mov	ax,0h
	mov	dx,2FE8h
	jmp	2304h

l0DAB_22FE:
	mov	ax,10h
	mov	dx,2FE8h

l0DAB_2304:
	push	dx
	push	ax
	call	far 1F3Dh:0525h
	add	sp,4h
	call	far 1F3Dh:0259h
