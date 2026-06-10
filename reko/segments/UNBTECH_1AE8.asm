;;; Segment 1AE8 (1AE8:0000)
1AE8:0000 7F 20 83 C4 04 9A F8 1D 7F 20 5D CB             . ....... ].    

;; fn1AE8_000C: 1AE8:000C
;;   Called from:
;;     183B:0889 (in fn183B_000A)
fn1AE8_000C proc
	push	bp
	mov	bp,sp
	mov	ax,80h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[562Ah]
	mov	ax,es:[0A44Bh]
	mov	[bp-3Eh],ax
	mov	es,[562Ch]
	mov	ax,es:[0A44Dh]
	mov	[bp-4Ah],ax
	mov	word ptr [bp-2h],0h

l1AE8_0034:
	mov	si,[bp-2h]
	sub	al,al
	mov	[bp+si-78h],al
	mov	bx,[bp-2h]
	mov	es,[562Eh]
	mov	es:[bx+78h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],18h
	jl	0034h

l1AE8_0051:
	mov	word ptr [bp-4h],0h
	jmp	0FF9h

l1AE8_0059:
	cmp	word ptr [bp-42h],0Bh
	jnz	00ACh

l1AE8_005F:
	mov	ax,[bp-2h]
	mov	[bp-48h],ax
	cmp	ax,0Ch
	jl	0070h

l1AE8_006A:
	sub	ax,8h
	mov	[bp-48h],ax

l1AE8_0070:
	mov	ax,7Dh
	imul	word ptr [bp-48h]
	mov	si,ax
	mov	es,[5648h]
	test	byte ptr es:[si+0C748h],8h
	jz	0093h

l1AE8_0084:
	test	byte ptr es:[si+0C749h],8h
	jz	0093h

l1AE8_008C:
	mov	word ptr [bp-48h],20h
	jmp	00E9h

l1AE8_0093:
	mov	word ptr [bp-48h],80h
	mov	ax,0Ch
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[564Eh]
	mov	byte ptr es:[bx+380Bh],0FFh
	jmp	00E9h

l1AE8_00AC:
	cmp	word ptr [bp-2h],4h
	jge	00BAh

l1AE8_00B2:
	push	word ptr [bp-42h]
	push	word ptr [bp-2h]
	jmp	00C4h

l1AE8_00BA:
	push	word ptr [bp-42h]
	mov	ax,[bp-2h]
	sub	ax,8h
	push	ax

l1AE8_00C4:
	call	far 1631h:10A2h
	add	sp,4h
	mov	[bp-48h],ax
	cmp	ax,0FFh
	jnz	00E9h

l1AE8_00D4:
	mov	ax,0Ch
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-42h]
	mov	es,[564Eh]
	mov	byte ptr es:[bx+3800h],0FFh

l1AE8_00E9:
	test	byte ptr [bp-48h],80h
	jz	00F2h

l1AE8_00EF:
	jmp	0DC4h

l1AE8_00F2:
	mov	bx,[bp-28h]
	shl	bx,1h
	mov	es,[5632h]
	cmp	word ptr es:[bx+406Ah],0h
	jnz	0106h

l1AE8_0103:
	jmp	0DAFh

l1AE8_0106:
	push	word ptr [bp-48h]
	push	word ptr [bp-28h]
	call	far 1631h:0F24h
	add	sp,4h
	mov	[bp-5Ch],ax
	cmp	ax,3h
	jl	011Fh

l1AE8_011C:
	jmp	0DC4h

l1AE8_011F:
	mov	si,[bp-28h]
	shl	si,1h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	mov	es,[562Ch]
	push	word ptr es:[0A44Dh]
	mov	es,[562Ah]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:0971h
	add	sp,8h
	mov	[bp-60h],ax
	cmp	ax,0FFFFh
	jnz	015Dh

l1AE8_0158:
	mov	word ptr [bp-60h],0h

l1AE8_015D:
	mov	ax,[bp-60h]
	mov	[bp-58h],ax
	mov	es,[562Ah]
	mov	ax,[bp-2Ah]
	mov	es:[0A44Bh],ax
	mov	es,[562Ch]
	mov	ax,[bp-36h]
	mov	es:[0A44Dh],ax
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	si,[bp-28h]
	shl	si,1h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	push	word ptr [bp-28h]
	push	word ptr [bp-2h]
	call	far 1631h:1BFEh
	add	sp,8h
	or	ax,ax
	jnz	01C4h

l1AE8_01C1:
	jmp	0D9Fh

l1AE8_01C4:
	cmp	word ptr [bp-2h],4h
	jl	0239h

l1AE8_01CA:
	cmp	word ptr [bp-2h],0Ch
	jge	0239h

l1AE8_01D0:
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	bx,ax
	mov	es,[5652h]
	mov	al,es:[bx+2EE8h]
	sub	ah,ah
	mov	[bp-22h],ax
	mov	bx,[bp-2h]
	mov	es,[5648h]
	mov	al,es:[bx+0D360h]
	cbw
	cmp	ax,[bp-22h]
	jnz	0221h

l1AE8_01F8:
	inc	byte ptr es:[bx+0D358h]
	jnz	0239h

l1AE8_01FF:
	mov	ax,11h
	imul	word ptr [bp-2h]
	add	ax,[bp-22h]
	add	ax,0C5D4h
	mov	[bp-80h],ax
	mov	word ptr [bp-7Eh],3092h
	les	bx,[bp-80h]
	cmp	byte ptr es:[bx],4h
	jge	0239h

l1AE8_021C:
	inc	byte ptr es:[bx]
	jmp	0239h

l1AE8_0221:
	mov	al,[bp-22h]
	mov	bx,[bp-2h]
	mov	es,[5648h]
	mov	es:[bx+0D360h],al
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+0D358h],0h

l1AE8_0239:
	cmp	word ptr [bp-2h],4h
	jge	0265h

l1AE8_023F:
	cmp	word ptr [bp-42h],0Bh
	jge	0265h

l1AE8_0245:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	add	ax,[bp-42h]
	add	ax,0C74Bh
	mov	[bp-80h],ax
	mov	word ptr [bp-7Eh],3092h
	les	bx,[bp-80h]
	cmp	byte ptr es:[bx],0FFh
	jz	0265h

l1AE8_0262:
	dec	byte ptr es:[bx]

l1AE8_0265:
	cmp	word ptr [bp-2h],0Ch
	jl	0297h

l1AE8_026B:
	cmp	word ptr [bp-2h],10h
	jge	0297h

l1AE8_0271:
	cmp	word ptr [bp-42h],0Bh
	jge	0297h

l1AE8_0277:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	add	ax,[bp-42h]
	add	ax,0C363h
	mov	[bp-80h],ax
	mov	word ptr [bp-7Eh],3092h
	les	bx,[bp-80h]
	cmp	byte ptr es:[bx],0FFh
	jz	0297h

l1AE8_0294:
	dec	byte ptr es:[bx]

l1AE8_0297:
	mov	ax,[bp-5Ch]
	shl	ax,1h
	add	ax,4h
	mov	[bp-30h],ax
	cmp	word ptr [bp-48h],20h
	jnz	02E0h

l1AE8_02A8:
	mov	word ptr [bp-30h],3h
	mov	ax,[bp-2h]
	mov	[bp-7Ah],ax
	cmp	ax,0Ch
	jl	02BCh

l1AE8_02B8:
	sub	word ptr [bp-7Ah],8h

l1AE8_02BC:
	mov	ax,24h
	push	ax
	push	word ptr [bp-2h]
	call	far 1631h:1B44h
	add	sp,4h
	add	[bp-30h],ax
	mov	ax,25h
	push	ax
	push	word ptr [bp-2h]
	call	far 1631h:1B44h
	add	sp,4h
	add	[bp-30h],ax

l1AE8_02E0:
	mov	ax,30h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[5654h]
	mov	al,es:[bx+32C6h]
	cbw
	inc	ax
	add	[bp-30h],ax
	mov	si,[bp-28h]
	mov	al,[bp+si-78h]
	cbw
	mov	bx,ax
	mov	es,[5656h]
	mov	al,es:[bx+2D1Ah]
	cbw
	add	[bp-30h],ax
	cmp	word ptr [bp-2h],4h
	jl	0321h

l1AE8_0312:
	cmp	word ptr [bp-2h],0Ch
	jge	0321h

l1AE8_0318:
	mov	ax,[bp-2h]
	sub	ax,4h
	mov	[bp-26h],ax

l1AE8_0321:
	cmp	word ptr [bp-2h],10h
	jl	0330h

l1AE8_0327:
	mov	ax,[bp-2h]
	sub	ax,8h
	mov	[bp-26h],ax

l1AE8_0330:
	cmp	word ptr [bp-2h],4h
	jge	03A9h

l1AE8_0336:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	es,[5648h]
	mov	al,es:[si+0C79Dh]
	sub	ah,ah
	mov	[bp-26h],ax
	cmp	es:[si+0C79Bh],ah
	jz	0357h

l1AE8_0353:
	add	word ptr [bp-30h],2h

l1AE8_0357:
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	bx,ax
	mov	es,[5652h]
	mov	al,es:[bx+2EE5h]
	and	al,0Fh
	mov	bx,[bp-2h]
	mov	es,[5658h]
	add	es:[bx+92h],al
	mov	bx,[bp-2h]
	mov	es,[5650h]
	cmp	byte ptr es:[bx+6Eh],8h
	jl	03A9h

l1AE8_0385:
	inc	word ptr [bp-30h]
	cmp	byte ptr es:[bx+6Eh],0Dh
	jl	0393h

l1AE8_0390:
	inc	word ptr [bp-30h]

l1AE8_0393:
	cmp	byte ptr es:[bx+6Eh],11h
	jl	039Eh

l1AE8_039B:
	inc	word ptr [bp-30h]

l1AE8_039E:
	cmp	byte ptr es:[bx+6Eh],18h
	jl	03A9h

l1AE8_03A6:
	inc	word ptr [bp-30h]

l1AE8_03A9:
	cmp	word ptr [bp-2h],0Ch
	jl	0428h

l1AE8_03AF:
	cmp	word ptr [bp-2h],10h
	jge	0428h

l1AE8_03B5:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	es,[5648h]
	mov	al,es:[si+0C3B5h]
	sub	ah,ah
	mov	[bp-26h],ax
	cmp	es:[si+0C3B3h],ah
	jz	03D6h

l1AE8_03D2:
	add	word ptr [bp-30h],2h

l1AE8_03D6:
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	bx,ax
	mov	es,[5652h]
	mov	al,es:[bx+2EE5h]
	and	al,0Fh
	mov	bx,[bp-2h]
	mov	es,[5658h]
	add	es:[bx+8Ah],al
	mov	bx,[bp-2h]
	mov	es,[5650h]
	cmp	byte ptr es:[bx+66h],8h
	jl	0428h

l1AE8_0404:
	inc	word ptr [bp-30h]
	cmp	byte ptr es:[bx+66h],0Dh
	jl	0412h

l1AE8_040F:
	inc	word ptr [bp-30h]

l1AE8_0412:
	cmp	byte ptr es:[bx+66h],11h
	jl	041Dh

l1AE8_041A:
	inc	word ptr [bp-30h]

l1AE8_041D:
	cmp	byte ptr es:[bx+66h],18h
	jl	0428h

l1AE8_0425:
	inc	word ptr [bp-30h]

l1AE8_0428:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],0h
	jz	0445h

l1AE8_0434:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h

l1AE8_0445:
	mov	es,[565Ch]
	mov	word ptr es:[37FEh],0Fh
	cmp	word ptr [bp-2h],0Ch
	jl	045Dh

l1AE8_0456:
	mov	word ptr es:[37FEh],0Eh

l1AE8_045D:
	cmp	word ptr [bp-2h],0Ch
	jl	0466h

l1AE8_0463:
	jmp	0519h

l1AE8_0466:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	04A0h

l1AE8_0472:
	mov	ax,11h
	imul	word ptr [bp-26h]
	mov	bx,ax
	mov	es,[5648h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[565Eh]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_04A0:
	cmp	word ptr [bp-2h],4h
	jge	0505h

l1AE8_04A6:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	04BFh

l1AE8_04B2:
	mov	ax,3E44h
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_04BF:
	cmp	word ptr [bp-48h],20h
	jnz	04EFh

l1AE8_04C5:
	mov	ax,3E4Dh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],1h
	jz	04E9h

l1AE8_04E6:
	jmp	05AFh

l1AE8_04E9:
	mov	ax,3E53h
	jmp	059Dh

l1AE8_04EF:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jz	04FEh

l1AE8_04FB:
	jmp	05BFh

l1AE8_04FE:
	mov	ax,3E58h

l1AE8_0501:
	push	ds
	jmp	05B6h

l1AE8_0505:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jz	0514h

l1AE8_0511:
	jmp	05BFh

l1AE8_0514:
	mov	ax,3E60h
	jmp	0501h

l1AE8_0519:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	0532h

l1AE8_0525:
	mov	ax,3E69h
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_0532:
	cmp	word ptr [bp-2h],10h
	jl	0549h

l1AE8_0538:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	05BFh

l1AE8_0544:
	mov	ax,3E73h
	jmp	0501h

l1AE8_0549:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	0562h

l1AE8_0555:
	mov	ax,3E81h
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_0562:
	cmp	word ptr [bp-48h],20h
	jz	0579h

l1AE8_0568:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	05BFh

l1AE8_0574:
	mov	ax,3E87h
	jmp	0501h

l1AE8_0579:
	mov	ax,3E8Fh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],1h
	jnz	05AFh

l1AE8_059A:
	mov	ax,3E95h

l1AE8_059D:
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h

l1AE8_05AF:
	mov	ax,12h
	mov	dx,3092h
	push	dx

l1AE8_05B6:
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_05BF:
	cmp	word ptr [bp-48h],20h
	jz	05DEh

l1AE8_05C5:
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_05DE:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	05F7h

l1AE8_05EA:
	mov	ax,3E9Ah
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_05F7:
	cmp	word ptr [bp-28h],0Ch
	jl	0600h

l1AE8_05FD:
	jmp	06B9h

l1AE8_0600:
	cmp	word ptr [bp-28h],4h
	jl	063Bh

l1AE8_0606:
	mov	ax,11h
	imul	word ptr [bp-28h]
	mov	bx,ax
	mov	es,[5648h]
	mov	al,es:[bx+0C5D0h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[565Eh]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	jmp	068Ch

l1AE8_063B:
	mov	ax,7Dh
	imul	word ptr [bp-28h]
	mov	bx,ax
	mov	es,[5648h]
	mov	al,11h
	mul	byte ptr es:[bx+0C79Dh]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[565Eh]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	ax,3E9Fh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h

l1AE8_068C:
	add	sp,8h
	mov	ax,3EA7h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	071Bh

l1AE8_06B0:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	jmp	0712h

l1AE8_06B9:
	mov	es,[565Ah]
	cmp	word ptr es:[2E38h],2h
	jnz	071Bh

l1AE8_06C5:
	mov	es,[5660h]
	cmp	word ptr es:[0E48Eh],0h
	jz	06D7h

l1AE8_06D1:
	cmp	word ptr [bp-28h],0Dh
	jz	06FCh

l1AE8_06D7:
	mov	ax,3EA9h
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h
	cmp	word ptr [bp-28h],10h
	jge	06EFh

l1AE8_06EA:
	mov	ax,3EB3h
	jmp	06F2h

l1AE8_06EF:
	mov	ax,3EB9h

l1AE8_06F2:
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_06FC:
	mov	es,[5660h]
	cmp	word ptr es:[0E48Eh],0h
	jz	071Bh

l1AE8_0708:
	cmp	word ptr [bp-28h],0Dh
	jnz	071Bh

l1AE8_070E:
	mov	ax,3EC0h
	push	ds

l1AE8_0712:
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1AE8_071B:
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	bx,ax
	mov	es,[5652h]
	mov	bl,es:[bx+2EE8h]
	sub	bh,bh
	mov	ax,11h
	imul	word ptr [bp-26h]
	add	bx,ax
	mov	es,[5648h]
	mov	al,es:[bx+0C618h]
	cbw
	sub	[bp-30h],ax
	cmp	word ptr [bp-28h],4h
	jl	074Fh

l1AE8_0749:
	cmp	word ptr [bp-28h],0Ch
	jl	0758h

l1AE8_074F:
	cmp	word ptr [bp-28h],10h
	jge	0758h

l1AE8_0755:
	jmp	091Dh

l1AE8_0758:
	mov	ax,[bp-28h]
	sub	ax,4h
	mov	[bp-0Ch],ax
	cmp	ax,0Ch
	jl	076Ah

l1AE8_0766:
	sub	word ptr [bp-0Ch],4h

l1AE8_076A:
	mov	bx,[bp-28h]
	mov	es,[5662h]
	mov	al,es:[bx+32AEh]
	cbw
	sar	ax,1h
	add	[bp-30h],ax
	mov	word ptr [bp-7Ch],7Fh
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	si,ax
	mov	es,[5652h]
	mov	al,es:[si+2EE4h]
	sub	ah,ah
	mov	[bp-34h],ax
	test	byte ptr [bp-34h],80h
	jz	07CCh

l1AE8_079D:
	mov	al,es:[si+2EE3h]
	mov	[bp-32h],ax
	and	ax,0Fh
	mov	[bp-7Ch],ax
	mov	ax,[bp-32h]
	mov	cl,4h
	sar	ax,cl
	and	ax,0Fh
	mov	[bp-32h],ax
	jmp	07C2h

l1AE8_07BA:
	call	far 0800h:19F3h
	add	[bp-7Ch],ax

l1AE8_07C2:
	mov	ax,[bp-32h]
	dec	word ptr [bp-32h]
	or	ax,ax
	jnz	07BAh

l1AE8_07CC:
	and	word ptr [bp-34h],7Fh
	cmp	word ptr [bp-7Ch],0h
	jnz	07D9h

l1AE8_07D6:
	inc	word ptr [bp-7Ch]

l1AE8_07D9:
	call	far 0800h:19DDh
	cmp	ax,[bp-30h]
	jge	084Bh

l1AE8_07E3:
	mov	ax,3ECDh
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h
	sub	ax,ax
	mov	[bp-56h],ax
	mov	[bp-34h],ax
	mov	bx,[bp-28h]
	mov	es,[5662h]
	cmp	byte ptr es:[bx+32AEh],0h
	jnz	080Ah

l1AE8_0807:
	jmp	08F1h

l1AE8_080A:
	cmp	word ptr [bp-48h],10h
	jl	0816h

l1AE8_0810:
	cmp	word ptr [bp-48h],12h
	jle	081Fh

l1AE8_0816:
	cmp	word ptr [bp-48h],0Bh
	jz	081Fh

l1AE8_081C:
	jmp	08F1h

l1AE8_081F:
	mov	es,[5664h]
	cmp	byte ptr es:[bx+3750h],10h
	jnc	082Eh

l1AE8_082B:
	jmp	08F1h

l1AE8_082E:
	cmp	byte ptr es:[bx+3750h],3Fh
	jbe	0839h

l1AE8_0836:
	jmp	08F1h

l1AE8_0839:
	sub	ax,ax
	push	ax
	mov	ax,0FFFFh
	push	ax
	push	bx
	push	cs
	call	1E46h
	add	sp,6h
	jmp	08F1h

l1AE8_084B:
	mov	ax,3ED6h
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h
	jmp	08F1h

l1AE8_085B:
	mov	ax,1h
	mov	[bp-56h],ax
	mov	[bp-6h],ax
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	es,[5648h]
	mov	al,es:[bx+0C622h]
	mov	[bp-80h],al
	or	al,al
	jz	08BCh

l1AE8_087C:
	cbw
	mov	cx,[bp-7Ch]
	sar	cx,1h
	cmp	ax,cx
	jl	089Dh

l1AE8_0886:
	sar	word ptr [bp-7Ch],1h
	mov	al,[bp-7Ch]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	sub	es:[bx+0C622h],cl
	jmp	08BCh

l1AE8_089D:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	al,es:[bx+0C622h]
	cbw
	sub	[bp-7Ch],ax
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	byte ptr es:[bx+0C622h],0h

l1AE8_08BC:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	al,es:[bx+0C623h]
	cbw
	cmp	ax,[bp-7Ch]
	jg	08DFh

l1AE8_08CF:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	byte ptr es:[bx+0C623h],0h
	jmp	08F1h

l1AE8_08DF:
	mov	al,[bp-7Ch]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	sub	es:[bx+0C623h],cl

l1AE8_08F1:
	mov	ax,[bp-34h]
	dec	word ptr [bp-34h]
	or	ax,ax
	jz	08FEh

l1AE8_08FB:
	jmp	085Bh

l1AE8_08FE:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	es,[5648h]
	cmp	byte ptr es:[bx+0C623h],0h
	jz	0915h

l1AE8_0912:
	jmp	0CD3h

l1AE8_0915:
	mov	word ptr [bp-2Ch],1h
	jmp	0CD3h

l1AE8_091D:
	mov	bx,[bp-28h]
	mov	es,[5662h]
	mov	al,es:[bx+32AEh]
	cbw
	mov	cl,3h
	sar	ax,cl
	add	[bp-30h],ax
	mov	ax,bx
	mov	[bp-0Ch],ax
	cmp	ax,0Ch
	jl	093Fh

l1AE8_093B:
	sub	word ptr [bp-0Ch],8h

l1AE8_093F:
	mov	es,[563Ch]
	mov	al,es:[bx+396Ch]
	cbw
	mov	[bp-46h],ax
	cmp	ax,0FFFFh
	jnz	095Eh

l1AE8_0951:
	mov	es,[5666h]
	mov	al,es:[bx+45B6h]
	cbw
	mov	[bp-46h],ax

l1AE8_095E:
	mov	bx,[bp-46h]
	sub	bx,[bp-60h]
	mov	es,[5668h]
	mov	al,es:[bx+2D11h]
	cbw
	mov	[bp-54h],ax
	call	far 0800h:19DDh
	mov	cx,ax
	mov	ax,0Bh
	imul	word ptr [bp-54h]
	mov	bx,ax
	add	bx,cx
	mov	es,[566Ah]
	mov	al,es:[bx+2E40h]
	sub	ah,ah
	mov	[bp-60h],ax
	cmp	word ptr [bp-48h],20h
	jnz	09F1h

l1AE8_0996:
	cmp	word ptr [bp-2h],4h
	jge	09AFh

l1AE8_099C:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[5648h]
	mov	al,es:[bx+0C734h]
	jmp	09C0h

l1AE8_09AF:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[5648h]
	mov	al,es:[bx+0C34Ch]

l1AE8_09C0:
	sub	ah,ah
	mov	[bp-7Ch],ax
	mov	cx,5h
	cwd
	idiv	cx
	mov	[bp-7Ch],ax
	mov	es,[5652h]
	mov	al,[bp-7Ch]
	mov	es:[3103h],al
	call	far 207Fh:0BC0h
	mov	bx,ax
	and	bx,8h
	mov	es,[566Ah]
	mov	al,es:[bx+2E43h]
	sub	ah,ah
	mov	[bp-60h],ax

l1AE8_09F1:
	mov	ax,11h
	imul	word ptr [bp-48h]
	mov	si,ax
	mov	es,[5652h]
	test	byte ptr es:[si+2EE4h],80h
	jz	0A08h

l1AE8_0A05:
	jmp	0CD3h

l1AE8_0A08:
	mov	al,es:[si+2EE3h]
	sub	ah,ah
	mov	[bp-7Ch],ax
	cmp	byte ptr es:[si+2EE4h],1h
	jbe	0A42h

l1AE8_0A1A:
	call	far 0800h:19DDh
	mov	cx,7h
	imul	cx
	mov	es,[5652h]
	mov	bl,es:[si+2EE4h]
	sub	bh,bh
	add	bx,ax
	mov	es,[566Ch]
	mov	al,es:[bx+2E5Eh]
	sub	ah,ah
	imul	word ptr [bp-7Ch]
	mov	[bp-7Ch],ax

l1AE8_0A42:
	call	far 0800h:19DDh
	cmp	ax,[bp-30h]
	jl	0A4Fh

l1AE8_0A4C:
	jmp	0B23h

l1AE8_0A4F:
	mov	ax,3EDEh
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h
	sub	ax,ax
	mov	[bp-56h],ax
	mov	[bp-7Ch],ax
	mov	bx,[bp-28h]
	mov	es,[5662h]
	cmp	byte ptr es:[bx+32AEh],0h
	jz	0AA8h

l1AE8_0A73:
	cmp	word ptr [bp-48h],10h
	jl	0A7Fh

l1AE8_0A79:
	cmp	word ptr [bp-48h],12h
	jle	0A85h

l1AE8_0A7F:
	cmp	word ptr [bp-48h],0Bh
	jnz	0AA8h

l1AE8_0A85:
	mov	es,[5664h]
	cmp	byte ptr es:[bx+3750h],10h
	jc	0AA8h

l1AE8_0A91:
	cmp	byte ptr es:[bx+3750h],3Fh
	ja	0AA8h

l1AE8_0A99:
	mov	ax,0FFFFh
	push	ax
	sub	ax,ax
	push	ax
	push	bx
	push	cs
	call	1E46h
	add	sp,6h

l1AE8_0AA8:
	cmp	word ptr [bp-28h],4h
	jl	0AC0h

l1AE8_0AAE:
	cmp	word ptr [bp-28h],0Ch
	jge	0AB7h

l1AE8_0AB4:
	jmp	0CCAh

l1AE8_0AB7:
	cmp	word ptr [bp-28h],10h
	jl	0AC0h

l1AE8_0ABD:
	jmp	0CCAh

l1AE8_0AC0:
	mov	bx,[bp-28h]
	mov	es,[566Eh]
	mov	al,es:[bx+45CEh]
	sub	ah,ah
	mov	es,[5670h]
	cmp	ax,es:[0150h]
	jnc	0ADCh

l1AE8_0AD9:
	jmp	0CCAh

l1AE8_0ADC:
	shl	bx,1h
	mov	es,[5636h]
	mov	ax,es:[bx+4036h]
	mov	bx,[bp-28h]
	mov	es,[5672h]
	mov	cl,es:[bx+4554h]
	sub	ch,ch
	sub	ax,cx
	dec	ax
	mov	[bp-18h],ax
	test	byte ptr [bp-18h],80h
	jz	0B06h

l1AE8_0B01:
	and	word ptr [bp-18h],0F07Fh

l1AE8_0B06:
	push	word ptr [bp-18h]
	shl	bx,1h
	mov	es,[5638h]
	push	word ptr es:[bx+4004h]
	mov	ax,7Fh
	push	ax
	call	far 183Bh:27C9h
	add	sp,6h
	jmp	0CCAh

l1AE8_0B23:
	mov	word ptr [bp-56h],1h
	mov	ax,3EE7h
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h
	push	word ptr [bp-60h]
	call	far 1631h:1B8Fh
	add	sp,2h
	jmp	0CCAh

l1AE8_0B43:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	es,[5648h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jnz	0B5Ah

l1AE8_0B57:
	jmp	0CD3h

l1AE8_0B5A:
	cmp	word ptr [bp-48h],0Bh
	jnz	0B75h

l1AE8_0B60:
	mov	bx,[bp-0Ch]
	mov	es,[5674h]
	mov	byte ptr es:[bx+0D576h],3h
	sub	ax,ax
	mov	[bp-34h],ax
	mov	[bp-7Ch],ax

l1AE8_0B75:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-60h]
	mov	es,[5648h]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	mov	[bp-52h],ax
	cmp	[bp-7Ch],ax
	jle	0B96h

l1AE8_0B93:
	jmp	0C44h

l1AE8_0B96:
	jnz	0BAEh

l1AE8_0B98:
	cmp	word ptr [bp-60h],1Ch
	jz	0BA4h

l1AE8_0B9E:
	cmp	word ptr [bp-60h],21h
	jnz	0BAEh

l1AE8_0BA4:
	mov	es,[5676h]
	mov	byte ptr es:[3986h],1h

l1AE8_0BAE:
	mov	al,[bp-7Ch]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-60h]
	mov	es,[5648h]
	sub	es:[bx+0C724h],cl
	mov	word ptr [bp-7Ch],0h
	cmp	word ptr [bp-60h],1Ch
	jl	0BE6h

l1AE8_0BD2:
	cmp	word ptr [bp-60h],23h
	jg	0BE6h

l1AE8_0BD8:
	push	word ptr [bp-60h]
	push	word ptr [bp-0Ch]
	call	far 1631h:11ABh
	add	sp,4h

l1AE8_0BE6:
	cmp	word ptr [bp-60h],1Fh
	jz	0BF5h

l1AE8_0BEC:
	cmp	word ptr [bp-60h],20h
	jz	0BF5h

l1AE8_0BF2:
	jmp	0CCAh

l1AE8_0BF5:
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-60h]
	mov	es,[5648h]
	cmp	byte ptr es:[bx+0C724h],0h
	jz	0C0Fh

l1AE8_0C0C:
	jmp	0CCAh

l1AE8_0C0F:
	push	word ptr [bp-28h]
	call	far 1543h:0A35h
	add	sp,2h
	mov	word ptr [bp-3Ah],1h
	mov	es,[564Ch]
	mov	word ptr es:[4586h],0h
	cmp	word ptr [bp-28h],0h
	jz	0C33h

l1AE8_0C30:
	jmp	0CCAh

l1AE8_0C33:
	cmp	word ptr [bp+6h],0h
	jnz	0C3Ch

l1AE8_0C39:
	jmp	0CCAh

l1AE8_0C3C:
	call	far 1467h:0D7Eh
	jmp	0CCAh

l1AE8_0C44:
	mov	ax,[bp-52h]
	sub	[bp-7Ch],ax
	mov	ax,7Dh
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	add	bx,[bp-60h]
	mov	es,[5648h]
	mov	byte ptr es:[bx+0C724h],0h
	cmp	word ptr [bp-52h],0h
	jz	0C7Bh

l1AE8_0C65:
	cmp	word ptr [bp-60h],1Ch
	jz	0C71h

l1AE8_0C6B:
	cmp	word ptr [bp-60h],21h
	jnz	0C7Bh

l1AE8_0C71:
	mov	es,[5676h]
	mov	byte ptr es:[3986h],1h

l1AE8_0C7B:
	cmp	word ptr [bp-60h],1Ch
	jl	0C95h

l1AE8_0C81:
	cmp	word ptr [bp-60h],23h
	jg	0C95h

l1AE8_0C87:
	push	word ptr [bp-60h]
	push	word ptr [bp-0Ch]
	call	far 1631h:11ABh
	add	sp,4h

l1AE8_0C95:
	push	word ptr [bp-60h]
	call	far 1631h:1122h
	add	sp,2h
	mov	[bp-60h],ax
	mov	es,[564Ah]
	cmp	word ptr es:[0E484h],0h
	jz	0CCAh

l1AE8_0CAF:
	push	word ptr [bp-28h]
	call	far 1543h:0A35h
	add	sp,2h
	mov	word ptr [bp-3Ah],1h
	mov	es,[564Ch]
	mov	word ptr es:[4586h],0h

l1AE8_0CCA:
	cmp	word ptr [bp-7Ch],0h
	jz	0CD3h

l1AE8_0CD0:
	jmp	0B43h

l1AE8_0CD3:
	mov	ax,4314h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-56h]
	push	word ptr [bp-0Ch]
	push	word ptr [bp-3Ah]
	push	word ptr [bp-2Ch]
	push	word ptr [bp-6h]
	push	word ptr [bp-58h]
	push	word ptr [bp-48h]
	push	word ptr [bp-28h]
	push	word ptr [bp-2h]
	push	cs
	call	12C7h
	add	sp,16h
	mov	es,[5676h]
	cmp	byte ptr es:[3986h],0h
	jz	0D41h

l1AE8_0D09:
	mov	es,[564Ch]
	mov	word ptr es:[4586h],0h
	mov	es,[5646h]
	cmp	word ptr es:[2E3Ah],0h
	jz	0D41h

l1AE8_0D20:
	cmp	word ptr [bp-28h],0Dh
	jnz	0D32h

l1AE8_0D26:
	mov	es,[5660h]
	cmp	word ptr es:[0E48Eh],0h
	jnz	0D41h

l1AE8_0D32:
	sub	ax,ax
	push	ax
	mov	ax,10h
	push	ax
	call	far 0800h:48B7h
	add	sp,4h

l1AE8_0D41:
	mov	es,[564Ch]
	cmp	word ptr es:[4586h],0h
	jz	0D76h

l1AE8_0D4D:
	mov	es,[5648h]
	mov	al,es:[0C620h]
	cbw
	cmp	ax,[bp-0Ch]
	jnz	0D76h

l1AE8_0D5B:
	mov	es,[5646h]
	cmp	word ptr es:[2E3Ah],0h
	jz	0D76h

l1AE8_0D67:
	sub	ax,ax
	push	ax
	mov	ax,5h
	push	ax
	call	far 0800h:48B7h
	add	sp,4h

l1AE8_0D76:
	call	far 1631h:1DCCh
	mov	ax,0Ch
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-42h]
	mov	es,[564Eh]
	or	byte ptr es:[bx+3800h],80h
	mov	word ptr [bp-42h],0Ch
	mov	es,[5676h]
	mov	byte ptr es:[3986h],0h

l1AE8_0D9F:
	push	word ptr [bp-36h]
	push	word ptr [bp-2Ah]
	call	far 0800h:17BBh
	add	sp,4h
	jmp	0DC4h

l1AE8_0DAF:
	mov	ax,0Ch
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-42h]
	mov	es,[564Eh]
	mov	byte ptr es:[bx+3800h],0FFh

l1AE8_0DC4:
	mov	es,[562Ah]
	mov	ax,[bp-2Ah]
	mov	es:[0A44Bh],ax
	mov	es,[562Ch]
	mov	ax,[bp-36h]
	mov	es:[0A44Dh],ax

l1AE8_0DDA:
	inc	word ptr [bp-42h]

l1AE8_0DDD:
	cmp	word ptr [bp-42h],0Ch
	jl	0DE6h

l1AE8_0DE3:
	jmp	0ED5h

l1AE8_0DE6:
	mov	es,[564Ah]
	sub	ax,ax
	mov	[bp-3Ah],ax
	mov	[bp-2Ch],ax
	mov	[bp-6h],ax
	mov	es:[0E484h],ax
	mov	es,[564Ch]
	mov	es:[4586h],ax
	mov	ax,0Ch
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-42h]
	mov	es,[564Eh]
	mov	al,es:[bx+3800h]
	cbw
	mov	[bp-28h],ax
	cmp	word ptr [bp-2h],4h
	jge	0E33h

l1AE8_0E1F:
	mov	bx,[bp-2h]
	mov	es,[5650h]
	cmp	byte ptr es:[bx+6Eh],1Eh
	jl	0E33h

l1AE8_0E2E:
	mov	word ptr [bp-28h],0FFFFh

l1AE8_0E33:
	cmp	word ptr [bp-2h],0Ch
	jl	0E53h

l1AE8_0E39:
	cmp	word ptr [bp-2h],10h
	jge	0E53h

l1AE8_0E3F:
	mov	bx,[bp-2h]
	mov	es,[5650h]
	cmp	byte ptr es:[bx+66h],1Eh
	jl	0E53h

l1AE8_0E4E:
	mov	word ptr [bp-28h],0FFFFh

l1AE8_0E53:
	test	byte ptr [bp-28h],80h
	jnz	0DDAh

l1AE8_0E59:
	mov	es,[562Ah]
	mov	ax,es:[0A44Bh]
	mov	[bp-2Ah],ax
	mov	es,[562Ch]
	mov	ax,es:[0A44Dh]
	mov	[bp-36h],ax
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[5638h]
	mov	ax,es:[si+4004h]
	mov	es,[562Ah]
	mov	es:[0A44Bh],ax
	mov	es,[5636h]
	mov	ax,es:[si+4036h]
	mov	es,[562Ch]
	mov	es:[0A44Dh],ax
	cmp	word ptr [bp-2h],4h
	jl	0EA2h

l1AE8_0E9C:
	cmp	word ptr [bp-2h],0Ch
	jl	0EABh

l1AE8_0EA2:
	cmp	word ptr [bp-2h],10h
	jge	0EABh

l1AE8_0EA8:
	jmp	0059h

l1AE8_0EAB:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	es,[5648h]
	mov	al,es:[si+0C5DBh]
	cbw
	mov	[bp-48h],ax
	cmp	word ptr [bp-2h],10h
	jge	0EC9h

l1AE8_0EC6:
	jmp	00E9h

l1AE8_0EC9:
	mov	al,es:[si+0C597h]
	cbw
	mov	[bp-48h],ax
	jmp	00E9h

l1AE8_0ED5:
	inc	word ptr [bp-2h]

l1AE8_0ED8:
	cmp	word ptr [bp-2h],18h
	jge	0F03h

l1AE8_0EDE:
	mov	es,[5630h]
	cmp	word ptr es:[014Ah],0h
	jz	0ED5h

l1AE8_0EEA:
	mov	bx,[bp-2h]
	shl	bx,1h
	mov	es,[5632h]
	cmp	word ptr es:[bx+406Ah],0h
	jz	0ED5h

l1AE8_0EFB:
	mov	word ptr [bp-42h],0h
	jmp	0DDDh

l1AE8_0F03:
	mov	word ptr [bp-5Ah],0h

l1AE8_0F08:
	mov	ax,30h
	imul	word ptr [bp-5Ah]
	mov	si,ax
	mov	es,[5654h]
	cmp	byte ptr es:[si+32C6h],0FFh
	jnz	0F1Fh

l1AE8_0F1C:
	jmp	0FEAh

l1AE8_0F1F:
	mov	di,[bp-5Ah]
	shl	di,1h
	mov	es,[5638h]
	mov	ax,es:[di+4004h]
	mov	es,[5636h]
	or	ax,es:[di+4036h]
	mov	al,ah
	sub	ah,ah
	mov	[bp-50h],ax
	mov	es,[5638h]
	mov	ax,es:[di+4004h]
	and	ax,7Fh
	mov	[bp-0Ah],ax
	mov	es,[5636h]
	mov	ax,es:[di+4036h]
	and	ax,7Fh
	mov	[bp-12h],ax
	mov	es,[5654h]
	mov	al,es:[si+32C7h]
	sub	ah,ah
	cmp	ax,[bp-50h]
	jnz	0FEAh

l1AE8_0F6B:
	mov	al,es:[si+32C8h]
	cbw
	cmp	ax,[bp-0Ah]
	jnz	0FEAh

l1AE8_0F76:
	mov	al,es:[si+32C9h]
	cbw
	cmp	ax,[bp-12h]
	jnz	0FEAh

l1AE8_0F81:
	mov	word ptr [bp-5Eh],0h

l1AE8_0F86:
	mov	ax,30h
	imul	word ptr [bp-5Ah]
	mov	si,ax
	mov	di,[bp-5Eh]
	add	di,si
	mov	al,es:[di+32CAh]
	mov	es:[di+32C6h],al
	inc	word ptr [bp-5Eh]
	mov	di,[bp-5Eh]
	add	di,si
	mov	al,es:[di+32CAh]
	mov	es:[di+32C6h],al
	inc	word ptr [bp-5Eh]
	mov	di,[bp-5Eh]
	add	di,si
	mov	al,es:[di+32CAh]
	mov	es:[di+32C6h],al
	inc	word ptr [bp-5Eh]
	mov	di,[bp-5Eh]
	add	di,si
	mov	al,es:[di+32CAh]
	mov	es:[di+32C6h],al
	inc	word ptr [bp-5Eh]
	cmp	word ptr [bp-5Eh],2Ch
	jl	0F86h

l1AE8_0FDC:
	mov	ax,30h
	imul	word ptr [bp-5Ah]
	mov	bx,ax
	mov	byte ptr es:[bx+32F2h],0FFh

l1AE8_0FEA:
	inc	word ptr [bp-5Ah]
	cmp	word ptr [bp-5Ah],0Ch
	jge	0FF6h

l1AE8_0FF3:
	jmp	0F08h

l1AE8_0FF6:
	inc	word ptr [bp-4h]

l1AE8_0FF9:
	cmp	word ptr [bp-4h],0Ch
	jl	1002h

l1AE8_0FFF:
	jmp	128Eh

l1AE8_1002:
	mov	es,[5630h]
	cmp	word ptr es:[014Ah],0h
	jz	0FF6h

l1AE8_100E:
	mov	word ptr [bp-44h],0h
	cmp	word ptr [bp-4h],0h
	jnz	101Eh

l1AE8_1019:
	mov	word ptr [bp-44h],1h

l1AE8_101E:
	mov	word ptr [bp-2h],0h

l1AE8_1023:
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[5632h]
	cmp	word ptr es:[si+406Ah],0h
	jnz	1037h

l1AE8_1034:
	jmp	11D3h

l1AE8_1037:
	mov	bx,[bp-2h]
	mov	es,[562Eh]
	mov	al,es:[bx+78h]
	cbw
	mov	[bp-20h],ax
	mov	di,ax
	shl	di,1h
	mov	ax,18h
	imul	bx
	add	di,ax
	mov	es,[5634h]
	mov	al,es:[di+40B4h]
	cbw
	mov	[bp-0Eh],ax
	mov	al,es:[di+40B5h]
	cbw
	mov	[bp-14h],ax
	cmp	word ptr [bp-0Eh],2h
	jnz	1071h

l1AE8_106E:
	jmp	11D3h

l1AE8_1071:
	cmp	ax,2h
	jnz	1079h

l1AE8_1076:
	jmp	11D3h

l1AE8_1079:
	mov	ax,[bp-0Eh]
	or	ax,[bp-14h]
	jnz	1084h

l1AE8_1081:
	jmp	11D3h

l1AE8_1084:
	mov	es,[562Ah]
	mov	ax,es:[0A44Bh]
	mov	[bp-24h],ax
	mov	es,[562Ch]
	mov	ax,es:[0A44Dh]
	mov	[bp-2Eh],ax
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	call	far 0800h:186Fh
	add	sp,4h
	push	word ptr [bp-14h]
	push	word ptr [bp-0Eh]
	call	far 0800h:191Bh
	add	sp,4h
	mov	ax,1h
	push	ax
	push	word ptr [bp-14h]
	push	word ptr [bp-0Eh]
	push	word ptr [bp-2h]
	call	far 1631h:16ABh
	add	sp,8h
	or	ax,ax
	jz	10DEh

l1AE8_10DB:
	jmp	11BDh

l1AE8_10DE:
	mov	word ptr [bp-44h],1h
	mov	bx,[bp-2h]
	mov	es,[562Eh]
	inc	byte ptr es:[bx+78h]
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[562Ah]
	mov	ax,es:[0A44Bh]
	mov	es,[5638h]
	mov	es:[si+4004h],ax
	mov	es,[562Ch]
	mov	ax,es:[0A44Dh]
	mov	es,[5636h]
	mov	es:[si+4036h],ax
	mov	bx,[bp-14h]
	shl	bx,1h
	shl	bx,1h
	add	bx,[bp-0Eh]
	mov	es,[563Ah]
	mov	al,es:[bx+2ED1h]
	cbw
	mov	[bp-40h],ax
	cmp	word ptr [bp-0Eh],0h
	jnz	113Ch

l1AE8_1133:
	cmp	word ptr [bp-14h],0h
	jnz	113Ch

l1AE8_1139:
	jmp	11BDh

l1AE8_113C:
	mov	si,[bp-2h]
	inc	byte ptr [bp+si-78h]
	mov	bx,[bp-2h]
	mov	es,[563Ch]
	mov	al,es:[bx+396Ch]
	cbw
	cmp	ax,[bp-40h]
	jz	1191h

l1AE8_1154:
	cmp	bx,4h
	jl	115Eh

l1AE8_1159:
	cmp	bx,0Ch
	jl	1163h

l1AE8_115E:
	cmp	bx,10h
	jl	1167h

l1AE8_1163:
	add	word ptr [bp-40h],8h

l1AE8_1167:
	mov	bx,[bp-40h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[563Eh]
	mov	ax,es:[bx+25Ah]
	mov	dx,es:[bx+25Ch]
	mov	bx,[bp-2h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5640h]
	mov	es:[bx+1F6h],ax
	mov	es:[bx+1F8h],dx

l1AE8_1191:
	push	word ptr [bp-2h]
	call	far 0800h:1732h
	add	sp,2h
	mov	bx,[bp-2h]
	mov	es,[5642h]
	mov	es:[bx+409Ah],al
	mov	bx,[bp-2h]
	mov	es,[563Ch]
	mov	al,es:[bx+396Ch]
	mov	es,[5644h]
	mov	es:[bx+3920h],al

l1AE8_11BD:
	mov	es,[562Ah]
	mov	ax,[bp-24h]
	mov	es:[0A44Bh],ax
	mov	es,[562Ch]
	mov	ax,[bp-2Eh]
	mov	es:[0A44Dh],ax

l1AE8_11D3:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],18h
	jge	11DFh

l1AE8_11DC:
	jmp	1023h

l1AE8_11DF:
	cmp	word ptr [bp-44h],0h
	jnz	11E8h

l1AE8_11E5:
	jmp	1286h

l1AE8_11E8:
	mov	es,[5646h]
	cmp	word ptr es:[2E3Ah],0h
	jnz	11F7h

l1AE8_11F4:
	jmp	1286h

l1AE8_11F7:
	mov	word ptr [bp-4Ch],4h
	mov	es,[5648h]
	cmp	byte ptr es:[0C620h],8h
	jge	1210h

l1AE8_1208:
	mov	al,es:[0C620h]
	cbw
	mov	[bp-4Ch],ax

l1AE8_1210:
	mov	si,[bp-4Ch]
	shl	si,1h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[562Ch]
	push	word ptr es:[0A44Dh]
	mov	es,[562Ah]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	mov	es,[562Ah]
	mov	ax,es:[0A44Bh]
	mov	[bp-10h],ax
	mov	es,[562Ch]
	mov	ax,es:[0A44Dh]
	mov	[bp-1Ah],ax
	sub	ax,ax
	push	ax
	mov	ax,4314h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:1ECEh
	add	sp,6h
	call	far 0800h:240Bh
	call	far 207Fh:18EFh
	call	far 0800h:0E4Bh
	call	far 1F3Dh:06C3h

l1AE8_1286:
	mov	word ptr [bp-2h],0h
	jmp	0ED8h

l1AE8_128E:
	mov	es,[5630h]
	cmp	word ptr es:[014Ah],0h
	jz	12A8h

l1AE8_129A:
	push	word ptr [bp-4Ah]
	push	word ptr [bp-3Eh]
	call	far 0800h:17BBh
	add	sp,4h

l1AE8_12A8:
	mov	es,[5630h]
	cmp	word ptr es:[014Ah],0h
	jz	12C1h

l1AE8_12B4:
	lea	ax,[bp-78h]
	push	ss
	push	ax
	call	far 1631h:0C63h
	add	sp,4h

l1AE8_12C1:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1AE8_12C7: 1AE8:12C7
;;   Called from:
;;     1AE8:0CF6 (in fn1AE8_000C)
fn1AE8_12C7 proc
	push	bp
	mov	bp,sp
	mov	ax,32h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-24h],0h
	mov	es,[5646h]
	cmp	word ptr es:[2E3Ah],0h
	jnz	12E7h

l1AE8_12E4:
	jmp	1B0Ch

l1AE8_12E7:
	mov	es,[5630h]
	cmp	word ptr es:[014Ah],0h
	jnz	12F6h

l1AE8_12F3:
	jmp	1B0Ch

l1AE8_12F6:
	mov	es,[5648h]
	mov	al,es:[0C620h]
	cbw
	mov	[bp-18h],ax
	cmp	ax,8h
	jl	130Ch

l1AE8_1307:
	mov	word ptr [bp-18h],4h

l1AE8_130C:
	mov	si,[bp-18h]
	shl	si,1h
	mov	es,[5638h]
	mov	ax,es:[si+4004h]
	mov	[bp-10h],ax
	mov	es,[5636h]
	mov	ax,es:[si+4036h]
	mov	[bp-12h],ax
	mov	bx,[bp+6h]
	mov	es,[563Ch]
	cmp	byte ptr es:[bx+396Ch],0FFh
	jz	1346h

l1AE8_1338:
	mov	al,es:[bx+396Ch]
	mov	es,[5666h]
	mov	es:[bx+45B6h],al

l1AE8_1346:
	cmp	word ptr [bp+6h],4h
	jl	135Eh

l1AE8_134C:
	cmp	word ptr [bp+6h],0Ch
	jge	1355h

l1AE8_1352:
	jmp	1404h

l1AE8_1355:
	cmp	word ptr [bp+6h],10h
	jl	135Eh

l1AE8_135B:
	jmp	1404h

l1AE8_135E:
	mov	bx,[bp+6h]
	mov	es,[5642h]
	mov	al,es:[bx+409Ah]
	sub	ah,ah
	mov	[bp-0Ch],ax
	cmp	word ptr [bp+0Ah],20h
	jz	13BEh

l1AE8_1375:
	mov	si,[bp+0Ch]
	mov	cl,2h
	shl	si,cl
	mov	es,[5678h]
	mov	ax,es:[si+2D58h]
	mov	dx,es:[si+2D5Ah]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5640h]
	mov	es:[bx+1F6h],ax
	mov	es:[bx+1F8h],dx
	mov	bx,[bp+6h]
	mov	es,[567Ah]
	cmp	byte ptr es:[bx+0D55Eh],0h
	jnz	13AEh

l1AE8_13AB:
	jmp	142Fh

l1AE8_13AE:
	mov	es,[5678h]
	mov	ax,es:[si+2D78h]
	mov	dx,es:[si+2D7Ah]
	jmp	141Dh

l1AE8_13BE:
	mov	si,[bp+0Ch]
	mov	cl,2h
	shl	si,cl
	mov	es,[567Ch]
	mov	ax,es:[si+2D98h]
	mov	dx,es:[si+2D9Ah]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5640h]
	mov	es:[bx+1F6h],ax
	mov	es:[bx+1F8h],dx
	mov	bx,[bp+6h]
	mov	es,[567Ah]
	cmp	byte ptr es:[bx+0D55Eh],0h
	jz	142Fh

l1AE8_13F4:
	mov	es,[567Ch]
	mov	ax,es:[si+2DB8h]
	mov	dx,es:[si+2DBAh]
	jmp	141Dh

l1AE8_1404:
	mov	si,[bp+0Ah]
	mov	cl,5h
	shl	si,cl
	mov	bx,[bp+0Ch]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+si+3FF8h]
	mov	dx,[bx+si+3FFAh]
	mov	bx,[bp+6h]

l1AE8_141D:
	shl	bx,1h
	shl	bx,1h
	mov	es,[5640h]
	mov	es:[bx+1F6h],ax
	mov	es:[bx+1F8h],dx

l1AE8_142F:
	cmp	word ptr [bp+0Ah],0Ah
	jz	143Bh

l1AE8_1435:
	cmp	word ptr [bp+0Ah],0Bh
	jnz	1457h

l1AE8_143B:
	mov	word ptr [bp+0Eh],0h
	cmp	word ptr [bp+8h],4h
	jl	1452h

l1AE8_1446:
	cmp	word ptr [bp+8h],0Ch
	jl	1457h

l1AE8_144C:
	cmp	word ptr [bp+8h],10h
	jge	1457h

l1AE8_1452:
	mov	word ptr [bp-24h],1h

l1AE8_1457:
	cmp	word ptr [bp+0Ah],19h
	jl	1468h

l1AE8_145D:
	cmp	word ptr [bp+0Ah],1Fh
	jg	1468h

l1AE8_1463:
	mov	word ptr [bp+0Eh],0h

l1AE8_1468:
	cmp	word ptr [bp+0Eh],0h
	jnz	1471h

l1AE8_146E:
	jmp	150Bh

l1AE8_1471:
	mov	bx,[bp+8h]
	mov	es,[563Ch]
	cmp	byte ptr es:[bx+396Ch],0FFh
	jz	148Eh

l1AE8_1480:
	mov	al,es:[bx+396Ch]
	mov	es,[5666h]
	mov	es:[bx+45B6h],al

l1AE8_148E:
	mov	bx,[bp+8h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5640h]
	mov	word ptr es:[bx+1F6h],2E3Ch
	mov	word ptr es:[bx+1F8h],3EDBh
	jmp	150Bh

l1AE8_14A9:
	push	word ptr [bp+6h]
	call	far 0800h:1732h
	add	sp,2h
	mov	bx,[bp+6h]
	mov	es,[5642h]
	mov	es:[bx+409Ah],al
	cmp	word ptr [bp+0Eh],0h
	jz	14DDh

l1AE8_14C6:
	push	word ptr [bp+8h]
	call	far 0800h:1732h
	add	sp,2h
	mov	bx,[bp+8h]
	mov	es,[5642h]
	mov	es:[bx+409Ah],al

l1AE8_14DD:
	mov	bx,[bp+6h]
	mov	es,[567Eh]
	cmp	byte ptr es:[bx+42F6h],0h
	jz	150Bh

l1AE8_14EC:
	push	word ptr [bp+1Ah]
	push	word ptr [bp+18h]
	call	far 1631h:1F09h
	add	sp,4h
	call	far 1F3Dh:06C3h
	mov	ax,5h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h

l1AE8_150B:
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5640h]
	les	bx,es:[bx+1F6h]
	cmp	byte ptr es:[bx],0FFh
	jnz	14A9h

l1AE8_1521:
	cmp	word ptr [bp+0Ah],3h
	jge	1533h

l1AE8_1527:
	mov	ax,0Dh
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1533:
	cmp	word ptr [bp+0Ah],17h
	jz	154Bh

l1AE8_1539:
	cmp	word ptr [bp+0Ah],9h
	jz	154Bh

l1AE8_153F:
	cmp	word ptr [bp+0Ah],13h
	jl	1557h

l1AE8_1545:
	cmp	word ptr [bp+0Ah],16h
	jg	1557h

l1AE8_154B:
	mov	ax,3h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1557:
	cmp	word ptr [bp+0Ah],3h
	jnz	1569h

l1AE8_155D:
	mov	ax,5h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1569:
	cmp	word ptr [bp+0Ah],7h
	jz	1575h

l1AE8_156F:
	cmp	word ptr [bp+0Ah],8h
	jnz	1581h

l1AE8_1575:
	mov	ax,6h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1581:
	cmp	word ptr [bp+0Ah],4h
	jl	1599h

l1AE8_1587:
	cmp	word ptr [bp+0Ah],6h
	jg	1599h

l1AE8_158D:
	mov	ax,0Bh
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1599:
	mov	word ptr [bp-18h],0h
	cmp	word ptr [bp+0Ah],0Ah
	jz	15AAh

l1AE8_15A4:
	cmp	word ptr [bp+0Ah],0Bh
	jnz	15AFh

l1AE8_15AA:
	mov	word ptr [bp-18h],1h

l1AE8_15AF:
	cmp	word ptr [bp+0Ah],19h
	jl	15C0h

l1AE8_15B5:
	cmp	word ptr [bp+0Ah],1Fh
	jg	15C0h

l1AE8_15BB:
	mov	word ptr [bp-18h],1h

l1AE8_15C0:
	mov	word ptr [bp-8h],0h
	cmp	word ptr [bp+0Ah],0Ch
	jz	15D1h

l1AE8_15CB:
	cmp	word ptr [bp+0Ah],0Dh
	jnz	15FCh

l1AE8_15D1:
	mov	word ptr [bp-18h],2h
	mov	word ptr [bp-2Ch],0Eh
	cmp	word ptr [bp+6h],10h
	jl	15E6h

l1AE8_15E1:
	mov	word ptr [bp-2Ch],0Ah

l1AE8_15E6:
	mov	es,[5680h]
	cmp	word ptr es:[4FBAh],0h
	jnz	15F7h

l1AE8_15F2:
	mov	word ptr [bp-2Ch],3h

l1AE8_15F7:
	mov	word ptr [bp-8h],1h

l1AE8_15FC:
	cmp	word ptr [bp+0Ah],0Fh
	jl	1665h

l1AE8_1602:
	cmp	word ptr [bp+0Ah],12h
	jg	1665h

l1AE8_1608:
	mov	word ptr [bp-18h],3h
	mov	word ptr [bp-2Ch],0Ch
	cmp	word ptr [bp+6h],0Ch
	jl	1639h

l1AE8_1618:
	mov	word ptr [bp-2Ch],5h
	cmp	word ptr [bp+8h],0h
	jnz	1654h

l1AE8_1623:
	mov	bx,[bp+6h]
	mov	es,[567Ah]
	cmp	byte ptr es:[bx+0D55Eh],0h
	jz	1654h

l1AE8_1632:
	mov	word ptr [bp-24h],3h
	jmp	1654h

l1AE8_1639:
	mov	bx,[bp+6h]
	mov	es,[567Ah]
	cmp	byte ptr es:[bx+0D55Eh],0h
	jnz	164Fh

l1AE8_1648:
	mov	word ptr [bp-24h],4h
	jmp	1654h

l1AE8_164F:
	mov	word ptr [bp-24h],7h

l1AE8_1654:
	mov	es,[5680h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1665h

l1AE8_1660:
	mov	word ptr [bp-2Ch],2h

l1AE8_1665:
	cmp	word ptr [bp-18h],0h
	jnz	166Eh

l1AE8_166B:
	jmp	1A07h

l1AE8_166E:
	cmp	word ptr [bp-18h],1h
	jnz	1680h

l1AE8_1674:
	mov	ax,1h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1680:
	mov	bx,[bp+6h]
	mov	es,[567Eh]
	cmp	byte ptr es:[bx+42F6h],0h
	jnz	169Dh

l1AE8_168F:
	mov	bx,[bp+8h]
	cmp	byte ptr es:[bx+42F6h],0h
	jnz	169Dh

l1AE8_169A:
	jmp	1A07h

l1AE8_169D:
	mov	bx,[bp+6h]
	cmp	byte ptr es:[bx+42F6h],0h
	jz	16C3h

l1AE8_16A8:
	mov	si,bx
	shl	si,1h
	mov	es,[5682h]
	mov	ax,es:[si+324Ch]
	mov	[bp-1Eh],ax
	mov	es,[5684h]
	mov	ax,es:[si+327Ch]
	jmp	1700h

l1AE8_16C3:
	mov	si,bx
	shl	si,1h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	push	word ptr [bp-12h]
	push	word ptr [bp-10h]
	call	far 1631h:1DF8h
	add	sp,8h
	mov	es,[5686h]
	mov	ax,es:[0E486h]
	mov	cl,3h
	shl	ax,cl
	mov	[bp-1Eh],ax
	mov	es,[5688h]
	mov	ax,es:[0E488h]
	shl	ax,cl

l1AE8_1700:
	mov	[bp-22h],ax
	mov	bx,[bp+8h]
	mov	es,[567Eh]
	cmp	byte ptr es:[bx+42F6h],0h
	jz	172Dh

l1AE8_1712:
	mov	si,bx
	shl	si,1h
	mov	es,[5682h]
	mov	ax,es:[si+324Ch]
	mov	[bp-20h],ax
	mov	es,[5684h]
	mov	ax,es:[si+327Ch]
	jmp	176Ah

l1AE8_172D:
	mov	si,bx
	shl	si,1h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	push	word ptr [bp-12h]
	push	word ptr [bp-10h]
	call	far 1631h:1DF8h
	add	sp,8h
	mov	es,[5686h]
	mov	ax,es:[0E486h]
	mov	cl,3h
	shl	ax,cl
	mov	[bp-20h],ax
	mov	es,[5688h]
	mov	ax,es:[0E488h]
	shl	ax,cl

l1AE8_176A:
	mov	[bp-28h],ax
	cmp	word ptr [bp+8h],4h
	jl	177Fh

l1AE8_1773:
	cmp	word ptr [bp+8h],0Ch
	jl	1783h

l1AE8_1779:
	cmp	word ptr [bp+8h],10h
	jge	1783h

l1AE8_177F:
	sub	word ptr [bp-28h],8h

l1AE8_1783:
	cmp	word ptr [bp-18h],1h
	jz	1805h

l1AE8_1789:
	add	word ptr [bp-20h],3h
	add	word ptr [bp-28h],3h
	cmp	word ptr [bp+6h],4h
	jl	17A3h

l1AE8_1797:
	cmp	word ptr [bp+6h],0Ch
	jl	17E8h

l1AE8_179D:
	cmp	word ptr [bp+6h],10h
	jge	17E8h

l1AE8_17A3:
	mov	bx,[bp+6h]
	mov	es,[567Ah]
	cmp	byte ptr es:[bx+0D55Eh],0h
	jnz	17CDh

l1AE8_17B2:
	mov	bx,[bp+0Ch]
	mov	es,[568Ah]
	mov	al,es:[bx+2D28h]
	cbw
	add	[bp-1Eh],ax
	mov	es,[568Ch]
	mov	al,es:[bx+2D30h]
	jmp	1801h

l1AE8_17CD:
	mov	bx,[bp+0Ch]
	mov	es,[568Eh]
	mov	al,es:[bx+2D38h]
	cbw
	add	[bp-1Eh],ax
	mov	es,[5690h]
	mov	al,es:[bx+2D40h]
	jmp	1801h

l1AE8_17E8:
	mov	bx,[bp+0Ch]
	mov	es,[5692h]
	mov	al,es:[bx+2D48h]
	cbw
	add	[bp-1Eh],ax
	mov	es,[5694h]
	mov	al,es:[bx+2D50h]

l1AE8_1801:
	cbw
	add	[bp-22h],ax

l1AE8_1805:
	mov	bx,[bp+0Ch]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5696h]
	mov	ax,es:[bx+2DD8h]
	mov	dx,es:[bx+2DDAh]
	mov	es,[5640h]
	mov	es:[0256h],ax
	mov	es:[0258h],dx
	mov	ax,[bp-1Eh]
	sub	ax,[bp-20h]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,8h
	jg	1852h

l1AE8_183B:
	mov	ax,[bp-22h]
	sub	ax,[bp-28h]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,8h
	jg	1852h

l1AE8_184F:
	jmp	19EAh

l1AE8_1852:
	mov	ax,[bp-22h]
	sub	ax,[bp-28h]
	mov	[bp-0Eh],ax
	mov	ax,[bp-20h]
	sub	ax,[bp-1Eh]
	mov	[bp-14h],ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3C6Ch
	add	sp,2h
	mov	[bp-26h],ax
	push	word ptr [bp-14h]
	call	far 207Fh:3C6Ch
	add	sp,2h
	mov	[bp-2Ah],ax
	mov	ax,[bp-26h]
	cmp	[bp-2Ah],ax
	jle	189Ah

l1AE8_1888:
	mov	ax,[bp-2Ah]
	mov	[bp-1Ah],ax
	mov	ax,[bp-26h]
	mov	[bp-2Ah],ax
	mov	ax,[bp-1Ah]
	mov	[bp-26h],ax

l1AE8_189A:
	push	word ptr [bp-14h]
	push	word ptr [bp-0Eh]
	call	far 1631h:1EA2h
	add	sp,4h
	mov	[bp-16h],ax
	mov	ax,[bp-26h]
	sar	ax,1h
	mov	[bp-1Ah],ax
	mov	bx,[bp-16h]
	mov	al,[bx+41DCh]
	cbw
	mov	[bp-2Eh],ax
	mov	al,[bx+41E4h]
	cbw
	mov	[bp-2h],ax
	mov	al,[bx+41ECh]
	cbw
	mov	[bp-6h],ax
	mov	al,[bx+41F4h]
	cbw
	mov	[bp-0Ah],ax
	cmp	word ptr [bp-18h],1h
	jnz	18EAh

l1AE8_18DC:
	mov	cl,2h
	shl	word ptr [bp-2Eh],cl
	shl	word ptr [bp-2h],cl
	shl	word ptr [bp-6h],cl
	shl	word ptr [bp-0Ah],cl

l1AE8_18EA:
	mov	ax,[bp-20h]
	cmp	[bp-1Eh],ax
	jnz	18FDh

l1AE8_18F2:
	mov	ax,[bp-28h]
	cmp	[bp-22h],ax
	jnz	18FDh

l1AE8_18FA:
	jmp	19EAh

l1AE8_18FD:
	cmp	word ptr [bp-18h],1h
	jnz	196Dh

l1AE8_1903:
	mov	ax,18h
	push	ax
	call	far 0800h:1732h
	add	sp,2h
	add	ax,68h
	mov	[bp-1Ch],ax
	cmp	word ptr [bp-1Eh],68h
	jge	191Eh

l1AE8_191B:
	jmp	199Eh

l1AE8_191E:
	cmp	word ptr [bp-1Eh],140h
	jge	199Eh

l1AE8_1925:
	cmp	word ptr [bp-22h],0h
	jl	199Eh

l1AE8_192B:
	cmp	word ptr [bp-22h],0C8h
	jge	199Eh

l1AE8_1932:
	mov	es,[5680h]
	cmp	word ptr es:[4FBAh],1h
	jnz	1944h

l1AE8_193E:
	test	byte ptr [bp-4h],3h
	jnz	1968h

l1AE8_1944:
	push	word ptr [bp+1Ah]
	push	word ptr [bp+18h]
	call	far 1631h:1F09h
	add	sp,4h
	push	word ptr [bp-22h]
	push	word ptr [bp-1Eh]
	push	word ptr [bp-1Ch]
	call	far 1631h:1F73h
	add	sp,6h
	call	far 1F3Dh:06C3h

l1AE8_1968:
	inc	word ptr [bp-4h]
	jmp	199Eh

l1AE8_196D:
	cmp	word ptr [bp-1Eh],68h
	jl	199Eh

l1AE8_1973:
	cmp	word ptr [bp-1Eh],140h
	jge	199Eh

l1AE8_197A:
	cmp	word ptr [bp-22h],0h
	jl	199Eh

l1AE8_1980:
	cmp	word ptr [bp-22h],0C8h
	jge	199Eh

l1AE8_1987:
	push	word ptr [bp-2Ch]
	push	word ptr [bp-22h]
	push	word ptr [bp-1Eh]
	push	word ptr [bp-22h]
	push	word ptr [bp-1Eh]
	call	far 1F3Dh:031Ch
	add	sp,0Ah

l1AE8_199E:
	mov	ax,[bp-20h]
	cmp	[bp-1Eh],ax
	jz	19ACh

l1AE8_19A6:
	mov	ax,[bp-2Eh]
	add	[bp-1Eh],ax

l1AE8_19AC:
	mov	ax,[bp-28h]
	cmp	[bp-22h],ax
	jz	19BAh

l1AE8_19B4:
	mov	ax,[bp-2h]
	add	[bp-22h],ax

l1AE8_19BA:
	mov	ax,[bp-2Ah]
	sub	[bp-1Ah],ax
	js	19C5h

l1AE8_19C2:
	jmp	18EAh

l1AE8_19C5:
	mov	ax,[bp-20h]
	cmp	[bp-1Eh],ax
	jz	19D3h

l1AE8_19CD:
	mov	ax,[bp-6h]
	add	[bp-1Eh],ax

l1AE8_19D3:
	mov	ax,[bp-28h]
	cmp	[bp-22h],ax
	jz	19E1h

l1AE8_19DB:
	mov	ax,[bp-0Ah]
	add	[bp-22h],ax

l1AE8_19E1:
	mov	ax,[bp-26h]
	add	[bp-1Ah],ax
	jmp	18EAh

l1AE8_19EA:
	cmp	word ptr [bp-18h],1h
	jz	1A07h

l1AE8_19F0:
	cmp	word ptr [bp-8h],0h
	jnz	19FBh

l1AE8_19F6:
	mov	ax,2h
	jmp	19FEh

l1AE8_19FB:
	mov	ax,9h

l1AE8_19FE:
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1A07:
	cmp	word ptr [bp+16h],0h
	jnz	1A10h

l1AE8_1A0D:
	jmp	1ADDh

l1AE8_1A10:
	mov	ax,4h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h
	cmp	word ptr [bp+0Ah],7h
	jge	1A25h

l1AE8_1A22:
	jmp	1AEBh

l1AE8_1A25:
	mov	bx,[bp+8h]
	mov	es,[567Eh]
	cmp	byte ptr es:[bx+42F6h],0h
	jnz	1A37h

l1AE8_1A34:
	jmp	1AEBh

l1AE8_1A37:
	mov	es,[5640h]
	mov	ax,41D8h
	mov	es:[0256h],ax
	mov	es:[0258h],ds
	mov	si,bx
	shl	si,1h
	mov	es,[5682h]
	mov	ax,es:[si+324Ch]
	mov	[bp-1Eh],ax
	mov	es,[5684h]
	mov	ax,es:[si+327Ch]
	mov	[bp-22h],ax
	cmp	bx,4h
	jl	1A72h

l1AE8_1A68:
	cmp	bx,0Ch
	jl	1AAFh

l1AE8_1A6D:
	cmp	bx,10h
	jge	1AAFh

l1AE8_1A72:
	sub	word ptr [bp-22h],8h
	jmp	1AAFh

l1AE8_1A78:
	mov	ax,18h
	push	ax
	call	far 0800h:1732h
	add	sp,2h
	mov	[bp-1Ch],ax
	push	word ptr [bp+1Ah]
	push	word ptr [bp+18h]
	call	far 1631h:1F09h
	add	sp,4h
	push	word ptr [bp-22h]
	push	word ptr [bp-1Eh]
	mov	ax,[bp-1Ch]
	add	ax,0FAh
	push	ax
	call	far 1631h:1F73h
	add	sp,6h
	call	far 1F3Dh:06C3h

l1AE8_1AAF:
	mov	es,[5640h]
	les	bx,es:[0256h]
	cmp	byte ptr es:[bx],0FFh
	jnz	1A78h

l1AE8_1ABE:
	mov	ax,5h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	cmp	word ptr [bp-24h],0h
	jz	1AEBh

l1AE8_1AD0:
	sub	ax,ax
	push	ax
	push	word ptr [bp-24h]
	call	far 0800h:48B7h
	jmp	1AE8h

l1AE8_1ADD:
	push	word ptr [bp+1Ah]
	push	word ptr [bp+18h]
	call	far 1631h:1F09h

l1AE8_1AE8:
	add	sp,4h

l1AE8_1AEB:
	cmp	word ptr [bp+6h],4h
	jl	1AFDh

l1AE8_1AF1:
	cmp	word ptr [bp+6h],0Ch
	jl	1B0Ch

l1AE8_1AF7:
	cmp	word ptr [bp+6h],10h
	jge	1B0Ch

l1AE8_1AFD:
	mov	al,[bp-0Ch]
	mov	bx,[bp+6h]
	mov	es,[5642h]
	mov	es:[bx+409Ah],al

l1AE8_1B0C:
	cmp	word ptr [bp+10h],0h
	jnz	1B15h

l1AE8_1B12:
	jmp	1BFCh

l1AE8_1B15:
	mov	ax,41FCh
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h
	mov	si,[bp+8h]
	shl	si,1h
	mov	es,[5698h]
	mov	word ptr es:[si+393Ch],1h
	mov	es,[5632h]
	mov	word ptr es:[si+406Ah],0h
	mov	ax,11h
	imul	word ptr [bp+14h]
	mov	bx,ax
	mov	es,[5648h]
	mov	byte ptr es:[bx+0C614h],0FFh
	mov	bx,[bp+8h]
	mov	es,[5642h]
	mov	byte ptr es:[bx+409Ah],7Eh
	mov	bx,[bp+8h]
	mov	es,[567Ah]
	mov	byte ptr es:[bx+0D55Eh],0h
	mov	es,[5636h]
	push	word ptr es:[si+4036h]
	mov	es,[5638h]
	push	word ptr es:[si+4004h]
	mov	ax,7Eh
	push	ax
	call	far 183Bh:27C9h
	add	sp,6h
	mov	word ptr [bp-1Eh],0h
	jmp	1BC4h

l1AE8_1B8E:
	inc	word ptr [bp-22h]

l1AE8_1B91:
	cmp	word ptr [bp-22h],0Ch
	jge	1BC1h

l1AE8_1B97:
	mov	ax,0Ch
	imul	word ptr [bp-1Eh]
	add	ax,[bp-22h]
	add	ax,3800h
	mov	[bp-32h],ax
	mov	word ptr [bp-30h],3092h
	les	bx,[bp-32h]
	mov	al,es:[bx]
	sub	ah,ah
	and	ax,7Fh
	cmp	ax,[bp+8h]
	jnz	1B8Eh

l1AE8_1BBB:
	mov	byte ptr es:[bx],0FFh
	jmp	1B8Eh

l1AE8_1BC1:
	inc	word ptr [bp-1Eh]

l1AE8_1BC4:
	cmp	word ptr [bp-1Eh],18h
	jge	1BD1h

l1AE8_1BCA:
	mov	word ptr [bp-22h],0h
	jmp	1B91h

l1AE8_1BD1:
	cmp	word ptr [bp+14h],2h
	jge	1BE2h

l1AE8_1BD7:
	mov	es,[5630h]
	mov	word ptr es:[014Ah],0h

l1AE8_1BE2:
	mov	si,[bp+8h]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[5636h]
	mov	es:[si+4036h],ax
	mov	es,[5638h]
	mov	es:[si+4004h],ax

l1AE8_1BFC:
	cmp	word ptr [bp+12h],0h
	jnz	1C05h

l1AE8_1C02:
	jmp	1E28h

l1AE8_1C05:
	mov	es,[5660h]
	cmp	word ptr es:[0E48Eh],0h
	jz	1C17h

l1AE8_1C11:
	cmp	word ptr [bp+8h],0Dh
	jz	1C82h

l1AE8_1C17:
	mov	word ptr [bp+12h],80h
	mov	bx,[bp+8h]
	mov	es,[567Ah]
	cmp	byte ptr es:[bx+0D55Eh],0h
	jz	1C2Eh

l1AE8_1C2B:
	inc	word ptr [bp+12h]

l1AE8_1C2E:
	shl	bx,1h
	mov	es,[5638h]
	mov	ax,es:[bx+4004h]
	dec	ax
	mov	[bp-1Eh],ax
	test	byte ptr [bp-1Eh],80h
	jz	1C48h

l1AE8_1C43:
	and	word ptr [bp-1Eh],0F7Fh

l1AE8_1C48:
	mov	bx,[bp+8h]
	shl	bx,1h
	mov	es,[5636h]
	mov	ax,es:[bx+4036h]
	dec	ax
	mov	[bp-22h],ax
	test	byte ptr [bp-22h],80h
	jz	1C65h

l1AE8_1C60:
	and	word ptr [bp-22h],0F07Fh

l1AE8_1C65:
	push	word ptr [bp-22h]
	push	word ptr [bp-1Eh]
	push	word ptr [bp+12h]
	call	far 183Bh:27C9h
	add	sp,6h
	mov	ax,8h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l1AE8_1C82:
	mov	es,[5660h]
	cmp	word ptr es:[0E48Eh],0h
	jnz	1C91h

l1AE8_1C8E:
	jmp	1E03h

l1AE8_1C91:
	cmp	word ptr [bp+8h],0Dh
	jz	1C9Ah

l1AE8_1C97:
	jmp	1E03h

l1AE8_1C9A:
	call	far 1CD3h:17C6h
	mov	ax,7h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h
	mov	ax,4209h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[5636h]
	push	word ptr es:[4036h]
	mov	es,[5638h]
	push	word ptr es:[4004h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	es,[562Ch]
	push	word ptr es:[0A44Dh]
	mov	es,[562Ah]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	sub	ax,ax
	push	ax
	push	word ptr [bp+1Ah]
	push	word ptr [bp+18h]
	call	far 207Fh:1ECEh
	add	sp,6h
	call	far 0800h:240Bh
	call	far 207Fh:18EFh
	call	far 0800h:0E4Bh
	call	far 1F3Dh:06C3h
	call	far 1CD3h:17C6h
	mov	ax,4235h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	word ptr [bp-1Eh],0h

l1AE8_1D32:
	mov	bx,[bp-1Eh]
	mov	es,[569Ah]
	mov	al,es:[bx+65Bh]
	mov	es,[5648h]
	mov	es:[bx+0CA8Fh],al
	mov	bx,[bp-1Eh]
	mov	es:[bx+0CA12h],al
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],7Dh
	jl	1D32h

l1AE8_1D58:
	mov	es,[5642h]
	sub	al,al
	mov	es:[40A9h],al
	mov	es:[40A8h],al
	mov	es,[567Ah]
	mov	es:[0D56Dh],al
	mov	es:[0D56Ch],al
	mov	es,[5644h]
	mov	al,4h
	mov	es:[392Eh],al
	mov	es,[563Ch]
	mov	es:[397Ah],al
	mov	es,[5644h]
	sub	al,al
	mov	es:[392Fh],al
	mov	es,[563Ch]
	mov	es:[397Bh],al
	mov	es,[5640h]
	mov	ax,2A0h
	mov	dx,2FE8h
	mov	es:[0232h],ax
	mov	es:[0234h],dx
	mov	es:[022Eh],ax
	mov	es:[0230h],dx
	mov	es,[5632h]
	mov	ax,1h
	mov	es:[4088h],ax
	mov	es:[4086h],ax
	mov	es,[5660h]
	mov	word ptr es:[0E48Eh],0h
	mov	es,[5648h]
	mov	byte ptr es:[0D32Fh],1h
	mov	es,[5638h]
	mov	ax,97Dh
	mov	es:[4022h],ax
	mov	es:[4020h],ax
	mov	es,[5636h]
	mov	word ptr es:[4052h],8030h
	mov	word ptr es:[4054h],8070h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h

l1AE8_1E03:
	mov	si,[bp+8h]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[5636h]
	mov	es:[si+4036h],ax
	mov	es,[5638h]
	mov	es:[si+4004h],ax
	mov	es,[5632h]
	mov	word ptr es:[si+406Ah],0h

l1AE8_1E28:
	mov	es,[5646h]
	cmp	word ptr es:[2E3Ah],0h
	jz	1E41h

l1AE8_1E34:
	mov	bx,[bp+6h]
	mov	es,[563Ch]
	mov	byte ptr es:[bx+396Ch],0FFh

l1AE8_1E41:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1AE8_1E46: 1AE8:1E46
;;   Called from:
;;     1AE8:0841 (in fn1AE8_000C)
;;     1AE8:0AA1 (in fn1AE8_000C)
fn1AE8_1E46 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	call	far 0800h:19DDh
	mov	[bp-2h],ax
	cmp	ax,5h
	jl	1E64h

l1AE8_1E5F:
	cmp	ax,9h
	jle	1EAFh

l1AE8_1E64:
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[5638h]
	mov	ax,es:[si+4004h]
	add	ax,[bp+8h]
	mov	[bp-4h],ax
	mov	es,[5636h]
	mov	ax,es:[si+4036h]
	add	ax,[bp+0Ah]
	mov	[bp-6h],ax
	test	byte ptr [bp-4h],80h
	jz	1E92h

l1AE8_1E8D:
	and	word ptr [bp-4h],0F7Fh

l1AE8_1E92:
	test	byte ptr [bp-6h],80h
	jz	1E9Dh

l1AE8_1E98:
	and	word ptr [bp-6h],0F07Fh

l1AE8_1E9D:
	push	word ptr [bp-6h]
	push	word ptr [bp-4h]
	mov	ax,7Ch
	push	ax
	call	far 183Bh:27C9h
	add	sp,6h

l1AE8_1EAF:
	pop	si
