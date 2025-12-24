;;; Segment 1543 (1543:0000)

l1467_0DC0:
	mov	sp,bp
	pop	bp
	retf

;; fn1543_0004: 1543:0004
;;   Called from:
;;     183B:16EC (in fn183B_14C3)
fn1543_0004 proc
	push	bp
	mov	bp,sp
	mov	ax,26h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-0Eh],0h

l1543_0015:
	mov	si,[bp-0Eh]
	mov	byte ptr [bp+si-20h],0h
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0Ch
	jl	0015h

l1543_0025:
	cmp	word ptr [bp+6h],0Ch
	jge	0038h

l1543_002B:
	mov	bx,[bp+6h]
	mov	es,[5544h]
	mov	byte ptr es:[bx+3994h],0h

l1543_0038:
	cmp	word ptr [bp+6h],4h
	jl	0041h

l1543_003E:
	jmp	05FDh

l1543_0041:
	mov	word ptr [bp-8h],0h
	mov	word ptr [bp-0Eh],33h

l1543_004B:
	cmp	word ptr [bp-8h],0Ch
	jge	0086h

l1543_0051:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[5546h]
	mov	al,es:[bx+0C724h]
	mov	[bp-22h],al
	sub	ah,ah
	and	ax,7Fh
	mov	[bp-10h],ax
	cmp	ax,10h
	jl	0086h

l1543_0075:
	cmp	ax,20h
	jg	0086h

l1543_007A:
	mov	si,[bp-8h]
	inc	word ptr [bp-8h]
	mov	al,[bp-22h]
	mov	[bp+si-20h],al

l1543_0086:
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],56h
	jl	004Bh

l1543_008F:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	bx,[bp+6h]
	mov	es,[5548h]
	cmp	byte ptr es:[bx+6Eh],1Eh
	jnz	00EBh

l1543_00AF:
	mov	ax,2904h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A4Fh
	mov	word ptr [bp-0Eh],0h
	jmp	00CBh

l1543_00C8:
	inc	word ptr [bp-0Eh]

l1543_00CB:
	cmp	word ptr [bp-0Eh],0Ch
	jl	00D4h

l1543_00D1:
	jmp	076Bh

l1543_00D4:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[554Ah]
	or	byte ptr es:[bx+3800h],80h
	jmp	00C8h

l1543_00EB:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5546h]
	cmp	byte ptr es:[bx+0C79Bh],1h
	jnz	0116h

l1543_00FF:
	mov	ax,292Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	call	far 1E56h:0388h

l1543_0116:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5546h]
	cmp	byte ptr es:[bx+0C79Bh],2h
	jnz	0144h

l1543_012A:
	mov	ax,2964h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	call	far 1E56h:0388h
	jmp	07C6h

l1543_0144:
	mov	ax,29A3h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l1543_0151:
	mov	ax,1h
	push	ax
	push	word ptr [bp+6h]
	call	far 183Bh:1774h
	add	sp,4h
	lea	ax,[bp-20h]
	push	ss
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	inc	ax
	inc	ax
	mov	es,[554Ch]
	mov	es:[0056h],ax
	lea	ax,[bp-20h]
	push	ss
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	sub	ax,16h
	neg	ax
	mov	es,[554Ch]
	mov	es:[0052h],ax
	mov	ax,5h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	call	far 1E56h:0388h
	call	far 0800h:28A2h
	mov	ax,29BEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-0Eh],0h
	jmp	03ECh

l1543_01C7:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],1h

l1543_01D2:
	test	byte ptr [bp-10h],80h
	jz	01FAh

l1543_01D8:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],8h
	mov	es,[5554h]
	cmp	word ptr es:[4FBAh],0h
	jnz	01FAh

l1543_01EF:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],2h

l1543_01FA:
	mov	ax,[bp-10h]
	and	ax,7Fh
	mov	cx,11h
	imul	cx
	mov	bx,ax
	lea	ax,[bx+2EC7h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[554Eh]
	mov	word ptr es:[3748h],0Bh
	test	byte ptr [bp-10h],80h
	jz	024Eh

l1543_0229:
	mov	ax,29D9h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[554Ah]
	mov	byte ptr es:[bx+3800h],0FFh
	jmp	03E9h

l1543_024E:
	and	word ptr [bp-10h],7Fh
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[5546h]
	cmp	byte ptr es:[bx+0C74Bh],0FFh
	jnz	0270h

l1543_0269:
	mov	ax,29E3h

l1543_026C:
	push	ds
	jmp	02F6h

l1543_0270:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	cmp	byte ptr es:[bx+0C74Bh],0h
	jnz	0288h

l1543_0283:
	mov	ax,29E8h
	jmp	026Ch

l1543_0288:
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	al,es:[bx+0C74Bh]
	sub	ah,ah
	push	ax
	call	far 207Fh:3BB6h
	add	sp,8h
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	cmp	ax,3h
	jge	02EFh

l1543_02C4:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	mov	[bp-2h],ax
	jmp	02E9h

l1543_02D9:
	mov	ax,29ECh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	inc	word ptr [bp-2h]

l1543_02E9:
	cmp	word ptr [bp-2h],3h
	jl	02D9h

l1543_02EF:
	mov	ax,12h
	mov	dx,3092h
	push	dx

l1543_02F6:
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[554Eh]
	mov	word ptr es:[3748h],10h
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	add	ax,[bp-0Eh]
	add	ax,3800h
	mov	[bp-26h],ax
	mov	word ptr [bp-24h],3092h
	les	bx,[bp-26h]
	mov	al,es:[bx]
	mov	[bp-22h],al
	cmp	al,0FFh
	jz	0345h

l1543_032B:
	mov	bl,al
	and	bx,7Fh
	shl	bx,1h
	mov	es,[5556h]
	cmp	word ptr es:[bx+406Ah],0h
	jnz	0345h

l1543_033E:
	les	bx,[bp-26h]
	mov	byte ptr es:[bx],0FFh

l1543_0345:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	add	ax,[bp-0Eh]
	add	ax,3800h
	mov	[bp-26h],ax
	mov	word ptr [bp-24h],3092h
	les	bx,[bp-26h]
	cmp	byte ptr es:[bx],0FFh
	jz	03DCh

l1543_0362:
	and	byte ptr es:[bx],7Fh
	les	bx,[bp-26h]
	mov	al,es:[bx]
	cbw
	mov	[bp-0Ah],ax
	mov	es,[5550h]
	mov	ax,es:[374Eh]
	mov	[bp-14h],ax
	cmp	word ptr [bp-0Ah],10h
	jl	0387h

l1543_0381:
	mov	ax,29EEh
	push	ds
	jmp	0397h

l1543_0387:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	lea	ax,[bx+0C33Ch]
	mov	dx,3092h
	push	dx

l1543_0397:
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[554Eh]
	mov	word ptr es:[3748h],18h
	mov	es,[5550h]
	mov	ax,[bp-14h]
	mov	es:[374Eh],ax
	mov	ax,[bp-10h]
	dec	ax
	push	ax
	push	word ptr [bp-0Ah]
	call	far 1631h:0F24h
	add	sp,4h
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5558h]
	push	word ptr es:[bx+2EBEh]
	push	word ptr es:[bx+2EBCh]
	jmp	03E1h

l1543_03DC:
	mov	ax,29F4h
	push	ds
	push	ax

l1543_03E1:
	call	far 1E56h:03F5h
	add	sp,4h

l1543_03E9:
	inc	word ptr [bp-0Eh]

l1543_03EC:
	cmp	word ptr [bp-0Eh],0Ch
	jge	045Ah

l1543_03F2:
	mov	es,[554Eh]
	mov	word ptr es:[3748h],0h
	mov	es,[5550h]
	mov	ax,[bp-0Eh]
	inc	ax
	mov	es:[374Eh],ax
	mov	si,[bp-0Eh]
	cmp	byte ptr [bp+si-20h],0h
	jz	03E9h

l1543_0412:
	mov	al,[bp+si-20h]
	cbw
	mov	[bp-10h],ax
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Fh
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,si
	mov	es,[554Ah]
	cmp	byte ptr es:[bx+3800h],0FFh
	jnz	043Dh

l1543_043A:
	jmp	01D2h

l1543_043D:
	mov	es,[5554h]
	cmp	word ptr es:[4FBAh],0h
	jnz	044Ch

l1543_0449:
	jmp	01C7h

l1543_044C:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Eh
	jmp	01D2h

l1543_045A:
	mov	es,[554Eh]
	mov	word ptr es:[3748h],0h
	lea	ax,[bp-20h]
	push	ss
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	inc	ax
	mov	[bp-0Ch],ax
	mov	es,[5550h]
	mov	es:[374Eh],ax
	mov	ax,29F9h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[555Ah]
	mov	ax,[bp-0Ch]
	dec	word ptr [bp-0Ch]
	mov	es:[00E6h],ax
	mov	ax,5h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,5h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-0Eh],ax
	mov	ax,[bp-0Ch]
	cmp	[bp-0Eh],ax
	jl	04BFh

l1543_04BC:
	jmp	05EFh

l1543_04BF:
	mov	si,[bp-0Eh]
	test	byte ptr [bp+si-20h],80h
	jz	0508h

l1543_04C8:
	mov	ax,2A00h

l1543_04CB:
	push	ds
	push	ax
	call	far 1631h:1057h
	add	sp,4h
	mov	es,[555Ah]
	push	word ptr es:[00ECh]
	push	word ptr es:[00E4h]
	mov	ax,es:[00E2h]
	mov	es,[555Ch]
	add	ax,es:[39A4h]
	add	ax,[bp-0Eh]
	push	ax
	mov	es,[555Eh]
	push	word ptr es:[39A0h]
	call	far 207Fh:2B87h
	add	sp,8h
	jmp	05EFh

l1543_0508:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[5546h]
	cmp	byte ptr es:[bx+0C74Bh],0h
	jnz	0524h

l1543_051F:
	mov	ax,2A39h
	jmp	04CBh

l1543_0524:
	mov	word ptr [bp-12h],1h
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[554Ah]
	cmp	byte ptr es:[bx+3800h],0FFh
	jz	0572h

l1543_0540:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,2A74h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	mov	[bp-12h],ax
	call	far 1E56h:0388h

l1543_0572:
	cmp	word ptr [bp-12h],0h
	jz	05EFh

l1543_0578:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[554Ah]
	mov	byte ptr es:[bx+3800h],0FFh
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,4h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,2AA8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	word ptr [bp-0Eh]
	mov	si,[bp-0Eh]
	mov	al,[bp+si-20h]
	cbw
	dec	ax
	push	ax
	push	word ptr [bp+6h]
	push	cs
	call	07CBh
	add	sp,6h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h

l1543_05EF:
	mov	ax,[bp-0Ch]
	cmp	[bp-0Eh],ax
	jz	05FAh

l1543_05F7:
	jmp	0151h

l1543_05FA:
	jmp	076Bh

l1543_05FD:
	mov	ax,1h
	push	ax
	push	word ptr [bp+6h]
	call	far 183Bh:1774h
	add	sp,4h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	word ptr [bp-12h],1h
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[554Ah]
	mov	al,es:[bx+3800h]
	cbw
	mov	[bp-6h],ax
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,es:[bx+0C5DBh]
	cbw
	mov	[bp-10h],ax
	cmp	word ptr [bp-6h],0FFh
	jnz	0655h

l1543_0652:
	jmp	0700h

l1543_0655:
	mov	ax,2AC6h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-10h]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2ADAh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-6h],10h
	jl	0694h

l1543_068E:
	mov	ax,2AE6h
	push	ds
	jmp	06A4h

l1543_0694:
	mov	ax,7Dh
	imul	word ptr [bp-6h]
	mov	bx,ax
	lea	ax,[bx+0C33Ch]
	mov	dx,3092h
	push	dx

l1543_06A4:
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2AECh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	word ptr [bp-10h]
	push	word ptr [bp-6h]
	call	far 1631h:0F24h
	add	sp,4h
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5558h]
	push	word ptr es:[bx+2EBEh]
	push	word ptr es:[bx+2EBCh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2AF1h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	mov	[bp-12h],ax

l1543_0700:
	cmp	word ptr [bp-12h],0h
	jz	076Bh

l1543_0706:
	call	far 1E56h:0388h
	mov	ax,2B0Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,11h
	imul	byte ptr es:[bx+0C5DBh]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2B16h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,es:[bx+0C5DBh]
	cbw
	push	ax
	push	word ptr [bp+6h]
	push	cs
	call	07CBh
	add	sp,6h

l1543_076B:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Fh
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,4h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Fh
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Fh

l1543_07C6:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1543_07CB: 1543:07CB
;;   Called from:
;;     1543:05C6 (in fn1543_0004)
;;     1543:0764 (in fn1543_0004)
;;     183B:2290 (in fn183B_2231)
fn1543_07CB proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	call	far 0800h:28A2h
	mov	ax,2B22h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-2h],1h

l1543_07EE:
	mov	bx,[2B20h]
	shl	bx,1h
	mov	es,[5556h]
	cmp	word ptr es:[bx+406Ah],0h
	jnz	0803h

l1543_0800:
	jmp	0A16h

l1543_0803:
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,3h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[555Ah]
	mov	word ptr es:[00C6h],3h
	mov	ax,2B36h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	word ptr [2B20h]
	call	far 183Bh:1774h
	add	sp,4h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	cmp	word ptr [2B20h],10h
	jl	0885h

l1543_085B:
	call	far 0800h:28A2h
	mov	es,[554Eh]
	mov	word ptr es:[3748h],0h
	mov	es,[5550h]
	mov	word ptr es:[374Eh],8h
	mov	ax,2B54h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	089Dh

l1543_0885:
	sub	ax,ax
	push	ax
	mov	ax,57h
	push	ax
	push	ax
	mov	ax,48h
	push	ax
	mov	ax,8h
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah

l1543_089D:
	mov	es,[554Eh]
	mov	word ptr es:[3748h],0h
	mov	es,[5550h]
	mov	word ptr es:[374Eh],5h
	cmp	word ptr [2B20h],0Fh
	jle	0917h

l1543_08BA:
	mov	ax,2B5Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	mov	ax,57h
	push	ax
	push	ax
	mov	ax,50h
	push	ax
	mov	ax,8h
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,0Ah
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,11h
	imul	word ptr [2B20h]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,11h
	imul	byte ptr es:[bx+0C597h]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	jmp	094Ch

l1543_0917:
	mov	ax,7Dh
	imul	word ptr [2B20h]
	mov	bx,ax
	lea	ax,[bx+0C33Ch]
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	mov	ax,4Fh
	push	ax
	mov	ax,57h
	push	ax
	mov	ax,48h
	push	ax
	mov	ax,8h
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah

l1543_094C:
	mov	es,[554Eh]
	mov	word ptr es:[3748h],0h
	mov	es,[5550h]
	mov	word ptr es:[374Eh],7h
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[5560h]
	push	word ptr es:[si+4036h]
	mov	es,[5562h]
	push	word ptr es:[si+4004h]
	call	far 0800h:17BBh
	add	sp,4h
	push	word ptr [bp+8h]
	push	word ptr [2B20h]
	call	far 1631h:0F24h
	add	sp,4h
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5558h]
	push	word ptr es:[bx+2EBEh]
	push	word ptr es:[bx+2EBCh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2B6Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,3h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-2h],ax
	or	ax,ax
	jz	09E4h

l1543_09D8:
	cmp	ax,1h
	jz	0A16h

l1543_09DD:
	cmp	ax,2h
	jz	09FFh

l1543_09E2:
	jmp	0A27h

l1543_09E4:
	mov	al,[2B20h]
	mov	cx,ax
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp+0Ah]
	mov	es,[554Ah]
	mov	es:[bx+3800h],cl
	jmp	0A27h

l1543_09FF:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp+0Ah]
	mov	es,[554Ah]
	mov	byte ptr es:[bx+3800h],0FFh
	jmp	0A27h

l1543_0A16:
	inc	word ptr [2B20h]
	cmp	word ptr [2B20h],17h
	jle	0A27h

l1543_0A21:
	mov	word ptr [2B20h],0Ch

l1543_0A27:
	cmp	word ptr [bp-2h],1h
	jnz	0A30h

l1543_0A2D:
	jmp	07EEh

l1543_0A30:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1543_0A35: 1543:0A35
;;   Called from:
;;     1AE8:0C12 (in fn1AE8_000C)
;;     1AE8:0CB2 (in fn1AE8_000C)
fn1543_0A35 proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[5556h]
	mov	word ptr es:[si+406Ah],0h
	mov	es,[5564h]
	mov	word ptr es:[si+393Ch],1h
	mov	word ptr [bp-4h],0h
	jmp	0A96h

l1543_0A64:
	inc	word ptr [bp-6h]

l1543_0A67:
	cmp	word ptr [bp-6h],0Ch
	jge	0A93h

l1543_0A6D:
	mov	ax,0Ch
	imul	word ptr [bp-4h]
	add	ax,[bp-6h]
	add	ax,3800h
	mov	[bp-0Eh],ax
	mov	word ptr [bp-0Ch],3092h
	les	bx,[bp-0Eh]
	mov	al,es:[bx]
	cbw
	cmp	ax,[bp+6h]
	jnz	0A64h

l1543_0A8D:
	mov	byte ptr es:[bx],0FFh
	jmp	0A64h

l1543_0A93:
	inc	word ptr [bp-4h]

l1543_0A96:
	cmp	word ptr [bp-4h],18h
	jge	0AA3h

l1543_0A9C:
	mov	word ptr [bp-6h],0h
	jmp	0A67h

l1543_0AA3:
	mov	ax,[bp+6h]
	mov	[bp-0Ah],ax
	cmp	ax,0Ch
	jl	0AB2h

l1543_0AAE:
	sub	word ptr [bp-0Ah],8h

l1543_0AB2:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,es:[bx+0C724h]
	mov	bx,[bp-0Ah]
	mov	es,[5566h]
	mov	es:[bx+323Eh],al
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[5546h]
	mov	byte ptr es:[bx+0C724h],0FFh
	mov	es,[5568h]
	cmp	word ptr es:[0E48Eh],0h
	jz	0B1Ah

l1543_0AED:
	cmp	word ptr [bp-0Ah],4h
	jnz	0B0Ah

l1543_0AF3:
	mov	es,[5546h]
	mov	byte ptr es:[0C995h],0FFh
	mov	es,[5556h]
	mov	word ptr es:[4084h],0h
	jmp	0B1Ah

l1543_0B0A:
	cmp	word ptr [bp-0Ah],5h
	jnz	0B1Ah

l1543_0B10:
	sub	ax,ax
	push	ax
	push	cs
	call	0C72h
	add	sp,2h

l1543_0B1A:
	mov	es,[556Ah]
	sub	ax,ax
	mov	es:[4586h],ax
	mov	es,[556Ch]
	mov	es:[3986h],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 0800h:28A2h
	mov	es,[5568h]
	cmp	word ptr es:[0E48Eh],0h
	jz	0B4Fh

l1543_0B49:
	cmp	word ptr [bp+6h],0Dh
	jz	0B68h

l1543_0B4F:
	mov	es,[556Eh]
	cmp	word ptr es:[2E38h],0h
	jz	0B68h

l1543_0B5B:
	mov	ax,2B6Dh
	push	ds
	push	ax
	call	far 1631h:1DABh
	add	sp,4h

l1543_0B68:
	cmp	word ptr [bp-0Ah],4h
	jl	0B71h

l1543_0B6E:
	jmp	0C61h

l1543_0B71:
	mov	ax,2B81h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,es:[bx+0C79Dh]
	mov	[bp-0Eh],al
	cmp	al,0FFh
	jz	0BDAh

l1543_0B96:
	sub	ah,ah
	mov	[bp-2h],ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C620h],8h
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[5556h]
	mov	word ptr es:[si+4072h],1h
	mov	di,[bp-0Ah]
	shl	di,1h
	mov	es,[5562h]
	mov	ax,es:[di+4004h]
	mov	es:[si+400Ch],ax
	mov	es,[5560h]
	mov	ax,es:[di+4036h]
	mov	es:[si+403Eh],ax

l1543_0BDA:
	mov	ax,7Dh
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[5546h]
	mov	al,es:[bx+0C79Eh]
	mov	[bp-0Eh],al
	cmp	al,0FFh
	jz	0C50h

l1543_0BF2:
	sub	ah,ah
	mov	[bp-2h],ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C620h],8h
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[5556h]
	mov	word ptr es:[si+4072h],1h
	mov	bx,[bp-0Ah]
	shl	bx,1h
	mov	es,[5562h]
	mov	ax,es:[bx+4004h]
	inc	ax
	mov	es:[si+400Ch],ax
	test	byte ptr es:[si+400Ch],80h
	jz	0C38h

l1543_0C31:
	add	word ptr es:[si+400Ch],80h

l1543_0C38:
	mov	bx,[bp-0Ah]
	shl	bx,1h
	mov	es,[5560h]
	mov	ax,es:[bx+4036h]
	mov	bx,[bp-2h]
	shl	bx,1h
	mov	es:[bx+403Eh],ax

l1543_0C50:
	mov	es,[5570h]
	cmp	word ptr es:[015Eh],5h
	jge	0C61h

l1543_0C5C:
	call	far 1631h:1DCCh

l1543_0C61:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Fh
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1543_0C72: 1543:0C72
;;   Called from:
;;     0800:027F (in fn0800_0000)
;;     0800:30D0 (in fn0800_2DA8)
;;     1543:0B13 (in fn1543_0A35)
;;     1CD3:133A (in fn1CD3_0004)
fn1543_0C72 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	cmp	word ptr [bp+6h],0h
	jz	0CA6h

l1543_0C84:
	mov	word ptr [bp-2h],0h
	jmp	0C8Eh

l1543_0C8B:
	inc	word ptr [bp-2h]

l1543_0C8E:
	cmp	word ptr [bp-2h],26h
	jge	0CD9h

l1543_0C94:
	mov	bx,[bp-2h]
	mov	al,[bx+5804h]
	mov	es,[5572h]
	mov	es:[bx+1C1Dh],al
	jmp	0C8Bh

l1543_0CA6:
	mov	word ptr [bp-2h],0h

l1543_0CAB:
	mov	bx,[bp-2h]
	mov	si,bx
	mov	es,[5572h]
	mov	al,es:[si+1C1Dh]
	mov	[bx+5804h],al
	mov	bx,[bp-2h]
	cmp	byte ptr [bx+2B8Eh],0h
	jz	0CD0h

l1543_0CC7:
	mov	al,[bx+2B8Eh]
	mov	es:[bx+1C1Dh],al

l1543_0CD0:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],26h
	jl	0CABh

l1543_0CD9:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1543_0CDE: 1543:0CDE
;;   Called from:
;;     11B8:18F4 (in fn11B8_1762)
;;     1CD3:05B9 (in fn1CD3_0004)
;;     1CD3:0814 (in fn1CD3_0004)
fn1543_0CDE proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	push	si
	sub	ax,ax
	mov	[bp-0Ch],ax
	mov	[bp-0Eh],ax
	mov	es,[5574h]
	mov	byte ptr es:[0012h],30h
	mov	[bp-4h],ax
	mov	es:[0013h],al
	mov	es,[554Eh]
	mov	ax,es:[3748h]
	mov	[bp-6h],ax
	mov	es,[5550h]
	mov	ax,es:[374Eh]
	mov	[bp-0Ah],ax
	mov	es,[5552h]
	mov	word ptr es:[37FEh],2h
	mov	es,[5554h]
	cmp	word ptr es:[4FBAh],0h
	jz	0D33h

l1543_0D30:
	jmp	0E75h

l1543_0D33:
	mov	es,[5552h]
	dec	word ptr es:[37FEh]
	jmp	0E75h

l1543_0D3F:
	mov	es,[554Eh]
	mov	ax,[bp-6h]
	mov	es:[3748h],ax
	mov	es,[5550h]
	mov	ax,[bp-0Ah]
	mov	es:[374Eh],ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[555Ch]
	mov	si,es:[39A4h]
	mov	es,[5550h]
	add	si,es:[374Eh]
	mov	cl,3h
	shl	si,cl
	sub	ax,ax
	push	ax
	lea	ax,[si+7h]
	push	ax
	mov	es,[555Eh]
	mov	ax,es:[39A0h]
	mov	es,[5576h]
	add	ax,es:[3990h]
	shl	ax,cl
	dec	ax
	push	ax
	push	si
	mov	es,[555Eh]
	mov	ax,es:[39A0h]
	mov	es,[554Eh]
	add	ax,es:[3748h]
	shl	ax,cl
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	call	far 1F3Dh:0259h
	mov	[bp-8h],ax
	cmp	ax,0Dh
	jnz	0DC9h

l1543_0DC1:
	mov	word ptr [bp-4h],1h
	jmp	0E75h

l1543_0DC9:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	mov	[bp-2h],ax
	cmp	word ptr [bp-8h],30h
	jl	0E46h

l1543_0DE2:
	cmp	word ptr [bp-8h],39h
	jg	0E46h

l1543_0DE8:
	cmp	ax,7h
	jl	0DF0h

l1543_0DED:
	jmp	0E75h

l1543_0DF0:
	jmp	0E07h

l1543_0DF2:
	mov	ax,13h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,12h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h

l1543_0E07:
	mov	es,[5574h]
	cmp	byte ptr es:[0012h],30h
	jz	0DF2h

l1543_0E13:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	mov	[bp-2h],ax
	mov	al,[bp-8h]
	mov	bx,[bp-2h]
	inc	word ptr [bp-2h]
	mov	es,[5574h]
	mov	es:[bx+12h],al
	mov	bx,[bp-2h]
	inc	word ptr [bp-2h]
	mov	byte ptr es:[bx+12h],0h
	jmp	0E75h

l1543_0E46:
	cmp	word ptr [bp-8h],1Bh
	jnz	0E5Ch

l1543_0E4C:
	mov	es,[5574h]
	mov	byte ptr es:[0012h],30h
	mov	byte ptr es:[0013h],0h

l1543_0E5C:
	cmp	word ptr [bp-8h],8h
	jnz	0E75h

l1543_0E62:
	cmp	word ptr [bp-2h],0h
	jz	0E75h

l1543_0E68:
	mov	bx,[bp-2h]
	mov	es,[5574h]
	mov	byte ptr es:[bx+11h],0h

l1543_0E75:
	cmp	word ptr [bp-4h],0h
	jnz	0E7Eh

l1543_0E7B:
	jmp	0D3Fh

l1543_0E7E:
	sub	ax,ax
	mov	[bp-0Ch],ax
	mov	[bp-0Eh],ax
	mov	[bp-2h],ax
	jmp	0EC1h

l1543_0E8B:
	mov	ax,0Ah
	cwd
	push	dx
	push	ax
	push	word ptr [bp-0Ch]
	push	word ptr [bp-0Eh]
	call	far 207Fh:3E2Eh
	mov	bx,[bp-2h]
	inc	word ptr [bp-2h]
	mov	es,[5574h]
	mov	cx,ax
	mov	al,es:[bx+12h]
	cbw
	mov	bx,dx
	cwd
	add	ax,cx
	adc	dx,bx
	sub	ax,30h
	sbb	dx,0h
	mov	[bp-0Eh],ax
	mov	[bp-0Ch],dx

l1543_0EC1:
	mov	bx,[bp-2h]
	mov	es,[5574h]
	cmp	byte ptr es:[bx+12h],0h
	jnz	0E8Bh

l1543_0ED0:
	mov	es,[5552h]
	mov	word ptr es:[37FEh],0Fh
	mov	ax,[bp-0Eh]
	mov	dx,[bp-0Ch]
