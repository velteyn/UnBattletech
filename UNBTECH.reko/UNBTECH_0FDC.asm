;;; Segment 0FDC (0FDC:0000)
0FDC:0000 02 3D 1F 5E 8B E5 5D CB                         .=.^..].        

;; fn0FDC_0008: 0FDC:0008
;;   Called from:
;;     0800:1E56 (in fn0800_1C12)
;;     0800:20C2 (in fn0800_1C12)
;;     0FDC:0125 (in fn0FDC_0008)
;;     0FDC:014C (in fn0FDC_0008)
;;     135D:01B4 (in fn135D_0004)
;;     135D:029F (in fn135D_0288)
;;     135D:0519 (in fn135D_04AB)
;;     135D:0582 (in fn135D_055A)
fn0FDC_0008 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ah
	call	far 207Fh:2FDCh
	mov	es,[545Ch]
	mov	byte ptr es:[0D316h],1h
	mov	es,[545Eh]
	mov	ax,[bp+6h]
	mov	es:[4584h],ax
	cmp	ax,12h
	jz	0041h

l0FDC_002D:
	cmp	ax,16h
	jge	0041h

l0FDC_0032:
	mov	bx,ax
	mov	es,[5460h]
	mov	al,es:[bx+4602h]
	cbw
	mov	[bp+6h],ax

l0FDC_0041:
	mov	ax,1h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	word ptr [bp-8h],1h
	cmp	word ptr [bp+6h],0h
	jnz	0085h

l0FDC_0058:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D320h],0h
	jnz	0085h

l0FDC_0064:
	mov	es,[5462h]
	mov	ax,es:[3938h]
	mov	es,[5464h]
	or	ax,es:[458Ch]
	jnz	0085h

l0FDC_0077:
	call	far 1467h:08A8h
	or	ax,ax
	jz	0085h

l0FDC_0080:
	mov	word ptr [bp-8h],0h

l0FDC_0085:
	cmp	word ptr [bp-8h],0h
	jnz	008Eh

l0FDC_008B:
	jmp	01BCh

l0FDC_008E:
	push	word ptr [bp+6h]
	push	cs
	call	1D30h
	add	sp,2h
	mov	bx,[bp+6h]
	cmp	byte ptr [bx+141Ah],0h
	jz	00B4h

l0FDC_00A2:
	mov	ax,1h
	push	ax
	mov	al,[bx+141Ah]
	cbw
	push	ax
	call	far 0800h:48B7h
	add	sp,4h

l0FDC_00B4:
	mov	ax,0A0h
	mov	dx,3092h
	push	dx
	push	ax
	push	cs
	call	01C0h
	add	sp,4h
	mov	ax,0Eh
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	es,[545Ch]
	cmp	byte ptr es:[0D33Eh],0h
	jnz	0136h

l0FDC_00DB:
	cmp	word ptr [bp+6h],8h
	jnz	0136h

l0FDC_00E1:
	cmp	byte ptr es:[0D33Ch],0h
	jz	0136h

l0FDC_00E9:
	cmp	byte ptr es:[0D31Ah],0h
	jz	0136h

l0FDC_00F1:
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,1384h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,13B6h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	ax,12h
	push	ax
	push	cs
	call	0008h
	add	sp,2h
	mov	es,[5466h]
	mov	byte ptr es:[0064h],0Ch

l0FDC_0136:
	cmp	word ptr [bp+6h],13h
	jnz	015Dh

l0FDC_013C:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D31Ah],0h
	jz	015Dh

l0FDC_0148:
	mov	ax,12h
	push	ax
	push	cs
	call	0008h
	add	sp,2h
	mov	es,[5466h]
	mov	byte ptr es:[0064h],0Ch

l0FDC_015D:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,1h
	push	ax
	call	far 0800h:4CACh
	add	sp,2h
	cmp	word ptr [bp+6h],14h
	jnz	01BCh

l0FDC_018C:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D342h],0h
	jz	01BCh

l0FDC_0198:
	mov	word ptr [bp-2h],0h

l0FDC_019D:
	mov	bx,[bp-2h]
	mov	cl,4h
	shl	bx,cl
	mov	es,[545Ch]
	mov	byte ptr es:[bx+0D118h],0h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jl	019Dh

l0FDC_01B7:
	call	far 135Dh:0004h

l0FDC_01BC:
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_01C0: 0FDC:01C0
;;   Called from:
;;     0FDC:00BC (in fn0FDC_0008)
fn0FDC_01C0 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ch
	call	far 207Fh:2FDCh
	push	si
	sub	ax,ax
	mov	[bp-8h],ax

l0FDC_01D1:
	mov	[bp-0Ah],ax
	jmp	05E9h

l0FDC_01D7:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	sub	ax,0FFE4h
	cmp	ax,1Bh
	jbe	01EFh

l0FDC_01EC:
	jmp	05E9h

l0FDC_01EF:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+5B1h]

l0FDC_01F7:
	mov	word ptr [bp-8h],1h
	jmp	05E9h

l0FDC_01FF:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	mov	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 1E56h:0281h
	jmp	05ACh

l0FDC_0215:
	call	far 1E56h:0388h
	jmp	05E9h

l0FDC_021D:
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	inc	ax
	add	[bp-0Ah],ax
	jmp	05E9h

l0FDC_024A:
	call	far 1F3Dh:0259h
	jmp	05E9h

l0FDC_0252:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 1E56h:0004h
	jmp	05ACh

l0FDC_0268:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-6h],ax
	shl	ax,1h
	add	ax,[bp-0Ah]

l0FDC_0286:
	add	ax,[bp+6h]

l0FDC_0289:
	mov	dx,[bp+8h]

l0FDC_028C:
	push	dx
	push	ax
	push	cs
	call	05F7h
	add	sp,4h
	jmp	01D1h

l0FDC_0298:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	bx,ax
	mov	es,[545Ch]
	cmp	byte ptr es:[bx+0D30Ch],0h
	jnz	02B6h

l0FDC_02B3:
	jmp	0567h

l0FDC_02B6:
	mov	ax,[bp-0Ah]

l0FDC_02B9:
	add	ax,si
	jmp	0289h

l0FDC_02BD:
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax

l0FDC_02CB:
	jnz	02D0h

l0FDC_02CD:
	jmp	0567h

l0FDC_02D0:
	jmp	0529h

l0FDC_02D3:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 1CD3h:0004h
	jmp	05ACh

l0FDC_02E9:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-6h],ax
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	mov	al,es:[bx+si]
	mov	bx,[bp-6h]
	mov	es,[545Ch]
	mov	es:[bx+0D30Ch],al
	jmp	05E9h

l0FDC_0311:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	bx,ax
	mov	es,[545Ch]
	mov	al,es:[bx+0D30Ch]
	cbw
	shl	ax,1h
	mov	[bp-6h],ax
	mov	ax,[bp-0Ah]
	add	ax,[bp-6h]
	jmp	02B9h

l0FDC_0337:
	call	far 1F3Dh:086Ah
	jmp	05E9h

l0FDC_033F:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-6h],ax
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	mov	al,es:[bx+si]
	mov	bx,[bp-6h]
	mov	es,[545Ch]
	add	es:[bx+0D30Ch],al
	jmp	05E9h

l0FDC_0367:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	es,[5468h]
	mov	es:[3748h],ax
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	mov	es,[bp+8h]
	mov	al,es:[bx+si]
	cbw
	mov	es,[546Ah]
	mov	es:[374Eh],ax
	jmp	05E9h

l0FDC_0394:
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	push	cs
	call	19F6h
	add	sp,4h
	mov	[bp-2h],ax
	add	word ptr [bp-0Ah],2h
	cwd
	mov	es,[545Ch]
	cmp	dx,es:[0D372h]
	jbe	03BCh

l0FDC_03B9:
	jmp	0567h

l0FDC_03BC:
	jnc	03C1h

l0FDC_03BE:
	jmp	0529h

l0FDC_03C1:
	cmp	ax,es:[0D370h]
	jbe	03CBh

l0FDC_03C8:
	jmp	0567h

l0FDC_03CB:
	jmp	0529h

l0FDC_03CE:
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	push	cs
	call	19F6h
	add	sp,4h
	mov	[bp-2h],ax
	add	word ptr [bp-0Ah],2h
	cwd
	mov	es,[545Ch]
	cmp	dx,es:[0D372h]
	ja	040Dh

l0FDC_03F3:
	jc	03FCh

l0FDC_03F5:
	cmp	ax,es:[0D370h]
	ja	040Dh

l0FDC_03FC:
	mov	ax,[bp-2h]
	cwd
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	jmp	0592h

l0FDC_040D:
	sub	ax,ax
	mov	es:[0D372h],ax
	mov	es:[0D370h],ax
	jmp	0592h

l0FDC_041A:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-6h],ax
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-4h],ax
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-0Ch],0h

l0FDC_0441:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[545Ch]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	046Ah

l0FDC_0455:
	mov	bx,[bp-6h]
	add	bx,si
	mov	al,es:[bx+0C618h]
	cbw
	cmp	ax,[bp-4h]
	jl	046Ah

l0FDC_0465:
	mov	word ptr [bp-2h],1h

l0FDC_046A:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],8h
	jl	0441h

l0FDC_0473:
	cmp	word ptr [bp-2h],0h
	jmp	02CBh

l0FDC_047A:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D450h],0h
	jmp	02CBh

l0FDC_0487:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D451h],0h
	jmp	02CBh

l0FDC_0494:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-4h],ax
	mov	es,[5462h]
	cmp	word ptr es:[3938h],0h
	jnz	04C6h

l0FDC_04B0:
	mov	bx,[bp-0Ah]
	mov	es,[bp+8h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	push	word ptr [bp-4h]
	call	far 0800h:48B7h
	add	sp,4h

l0FDC_04C6:
	inc	word ptr [bp-0Ah]
	jmp	05E9h

l0FDC_04CC:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 11B8h:0D58h
	jmp	05ACh

l0FDC_04E2:
	call	far 207Fh:0BC0h
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	cx,ax
	mov	al,es:[bx+si]
	cbw
	test	cx,ax
	jz	0567h

l0FDC_04FA:
	mov	ax,[bp-0Ah]
	add	ax,si
	mov	dx,es
	jmp	028Ch

l0FDC_0504:
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,es
	push	dx
	push	ax
	push	cs
	call	19F6h
	add	sp,4h
	mov	[bp-2h],ax
	add	word ptr [bp-0Ah],2h
	mov	es,[546Ch]
	mov	ax,es:[0A44Bh]
	cmp	[bp-2h],ax
	jnz	0567h

l0FDC_0529:
	mov	ax,[bp-0Ah]
	jmp	0286h

l0FDC_052F:
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	push	cs
	call	19F6h
	add	sp,4h
	mov	es,[546Ch]
	mov	es:[0A44Bh],ax
	add	word ptr [bp-0Ah],2h
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	push	cs
	call	19F6h
	add	sp,4h
	mov	es,[546Eh]
	mov	es:[0A44Dh],ax

l0FDC_0567:
	add	word ptr [bp-0Ah],2h
	jmp	05E9h

l0FDC_056D:
	mov	ax,[bp-0Ah]
	add	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	dx
	push	ax
	push	cs
	call	19F6h
	add	sp,4h
	cwd
	mov	es,[545Ch]
	add	es:[0D370h],ax
	adc	es:[0D372h],dx
	add	word ptr [bp-0Ah],2h

l0FDC_0592:
	call	far 1631h:1FDFh
	jmp	05E9h

l0FDC_0599:
	mov	bx,[bp-0Ah]
	inc	word ptr [bp-0Ah]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 0800h:19BFh

l0FDC_05AC:
	add	sp,2h
	jmp	05E9h
l0FDC_05B1	dw	0x0599
l0FDC_05B3	dw	0x056D
l0FDC_05B5	dw	0x052F
l0FDC_05B7	dw	0x0504
l0FDC_05B9	dw	0x04E2
l0FDC_05BB	dw	0x04CC
l0FDC_05BD	dw	0x0494
l0FDC_05BF	dw	0x0487
l0FDC_05C1	dw	0x047A
l0FDC_05C3	dw	0x041A
l0FDC_05C5	dw	0x03CE
l0FDC_05C7	dw	0x0394
l0FDC_05C9	dw	0x0367
l0FDC_05CB	dw	0x033F
l0FDC_05CD	dw	0x0337
l0FDC_05CF	dw	0x0311
l0FDC_05D1	dw	0x02E9
l0FDC_05D3	dw	0x02D3
l0FDC_05D5	dw	0x02BD
l0FDC_05D7	dw	0x0298
l0FDC_05D9	dw	0x0529
l0FDC_05DB	dw	0x0268
l0FDC_05DD	dw	0x0252
l0FDC_05DF	dw	0x024A
l0FDC_05E1	dw	0x021D
l0FDC_05E3	dw	0x0215
l0FDC_05E5	dw	0x01FF
l0FDC_05E7	dw	0x01F7

l0FDC_05E9:
	cmp	word ptr [bp-8h],0h
	jnz	05F2h

l0FDC_05EF:
	jmp	01D7h

l0FDC_05F2:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_05F7: 0FDC:05F7
;;   Called from:
;;     0FDC:028E (in fn0FDC_01C0)
fn0FDC_05F7 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	les	bx,[bp+6h]
	mov	al,es:[bx]
	sub	ah,ah
	mov	[bp-4h],ax
	mov	al,es:[bx+1h]
	mov	[bp-2h],ax
	and	[bp-3h],ah
	and	[bp-1h],ah
	mov	ah,[bp-2h]
	sub	al,al
	add	ax,[bp-4h]
	mov	[bp-6h],ax
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_0629: 0FDC:0629
;;   Called from:
;;     11B8:15D0 (in fn11B8_152F)
;;     1CD3:017C (in fn1CD3_0004)
;;     1CD3:10E2 (in fn1CD3_0004)
fn0FDC_0629 proc
	push	bp
	mov	bp,sp
	mov	ax,24h
	call	far 207Fh:2FDCh
	push	si
	sub	ax,ax
	mov	[bp-0Eh],ax
	mov	[bp-2h],ax
	mov	ax,[bp+6h]
	cmp	ax,9h
	jbe	0648h

l0FDC_0645:
	jmp	0883h

l0FDC_0648:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+86Fh]

l0FDC_0650:
	mov	es,[5470h]
	mov	al,es:[200Ah]
	cbw
	mov	[bp-18h],ax
	mov	byte ptr es:[200Ah],0h
	sub	ax,ax
	mov	[bp-2h],ax
	mov	[bp-14h],ax

l0FDC_066A:
	sub	ax,ax
	push	ax
	call	far 0800h:218Fh
	add	sp,2h
	jmp	0883h

l0FDC_0678:
	call	far 207Fh:0BC0h
	and	ax,7h
	mov	[bp-22h],ax
	mov	bx,ax
	mov	al,[bx+1632h]
	cbw
	mov	[bp-16h],ax
	mov	al,[bx+163Ah]
	cbw
	mov	[bp-1Ah],ax
	and	ax,78h
	mov	cl,6h
	shl	ax,cl
	mov	dx,[bp-1Ah]
	and	dx,7h
	mov	cl,3h
	shl	dx,cl
	add	ax,dx
	mov	dx,[bp-16h]
	and	dx,78h
	shl	dx,cl
	add	ax,dx
	mov	cx,[bp-16h]
	and	cx,7h
	add	ax,cx
	mov	[bp-4h],ax
	mov	bx,ax
	mov	es,[5470h]
	mov	al,es:[bx+101Dh]
	cbw
	mov	[bp-18h],ax
	mov	byte ptr es:[bx+101Dh],50h
	mov	es,[545Ch]
	cmp	byte ptr es:[0C724h],4Ch
	jnz	066Ah

l0FDC_06DE:
	call	far 1CD3h:17C6h
	mov	ax,1434h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	066Ah

l0FDC_06F8:
	sub	ax,ax
	push	ax
	mov	ax,1h
	push	ax
	push	cs
	call	0D49h
	add	sp,4h
	mov	es,[545Ch]
	sub	al,al
	mov	es:[0C93Dh],al
	mov	es:[0C93Ch],al
	mov	word ptr [bp-20h],27h

l0FDC_0719:
	mov	bx,[bp-20h]
	mov	byte ptr es:[bx+0C918h],0h
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],30h
	jle	0719h

l0FDC_072B:
	sub	al,al
	mov	es:[0C94Ah],al
	mov	es:[0C949h],al

l0FDC_0735:
	mov	ax,1h
	push	ax
	call	far 183Bh:000Ah
	add	sp,2h
	push	cs
	call	134Bh

l0FDC_0745:
	mov	word ptr [bp-2h],1h
	jmp	0883h

l0FDC_074D:
	call	far 207Fh:0BC0h
	and	ax,3h
	add	ax,3h
	push	ax
	sub	ax,ax
	push	ax
	push	cs
	call	0D49h
	add	sp,4h
	jmp	0735h

l0FDC_0765:
	mov	es,[5472h]
	mov	word ptr es:[0090h],1h

l0FDC_0770:
	cmp	word ptr [bp+6h],6h
	jnz	078Ah

l0FDC_0776:
	call	far 207Fh:0BC0h
	test	al,1h
	jz	078Ah

l0FDC_077F:
	mov	es,[5474h]
	mov	word ptr es:[3772h],1h

l0FDC_078A:
	cmp	word ptr [bp+6h],7h
	jnz	079Bh

l0FDC_0790:
	mov	es,[5474h]
	mov	word ptr es:[3772h],1h

l0FDC_079B:
	mov	es,[5474h]
	cmp	word ptr es:[3772h],0h
	jz	07C3h

l0FDC_07A7:
	mov	word ptr [bp-2h],0FF0h

l0FDC_07AC:
	mov	bx,[bp-2h]
	mov	es,[5470h]
	mov	byte ptr es:[bx+101Dh],40h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],1000h
	jl	07ACh

l0FDC_07C3:
	sub	ax,ax
	push	ax
	mov	ax,[bp+6h]
	sub	ax,3h
	push	ax
	push	cs
	call	0D49h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 183Bh:000Ah
	add	sp,2h
	push	cs
	call	134Bh
	mov	word ptr [bp-2h],1h
	mov	es,[5472h]
	mov	word ptr es:[0090h],0h
	jmp	0883h

l0FDC_07F7:
	sub	ax,ax
	push	ax
	mov	ax,81h
	push	ax
	push	cs
	call	0D49h
	add	sp,4h
	mov	ax,2h
	push	ax
	call	far 183Bh:000Ah
	add	sp,2h
	jmp	0745h

l0FDC_0814:
	sub	ax,ax
	mov	[bp-2h],ax
	mov	[bp-14h],ax
	mov	es,[5476h]
	mov	word ptr es:[398Eh],1h
	mov	es,[546Eh]
	push	word ptr es:[0A44Dh]
	mov	es,[546Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:051Bh
	call	far 1F3Dh:06C3h
	mov	word ptr [bp-1Ch],0h

l0FDC_0855:
	mov	si,[bp-1Ch]
	shl	si,1h
	mov	word ptr [bp+si-0Ch],0h
	inc	word ptr [bp-1Ch]
	cmp	word ptr [bp-1Ch],4h
	jl	0855h

l0FDC_0868:
	mov	word ptr [bp-24h],0h
	jmp	0883h
l0FDC_086F	dw	0x0650
l0FDC_0871	dw	0x0678
l0FDC_0873	dw	0x06F8
l0FDC_0875	dw	0x074D
l0FDC_0877	dw	0x0765
l0FDC_0879	dw	0x0770
l0FDC_087B	dw	0x0770
l0FDC_087D	dw	0x0770
l0FDC_087F	dw	0x07F7
l0FDC_0881	dw	0x0814

l0FDC_0883:
	mov	es,[5474h]
	mov	ax,es:[3772h]
	mov	[bp-10h],ax
	cmp	word ptr [bp+6h],8h
	jnz	0899h

l0FDC_0894:
	mov	word ptr [bp-10h],1h

l0FDC_0899:
	mov	word ptr [bp-1Eh],0h

l0FDC_089E:
	cmp	word ptr [bp-10h],0h
	jz	08A7h

l0FDC_08A4:
	jmp	0BF2h

l0FDC_08A7:
	mov	es,[546Ch]
	cmp	word ptr es:[0A44Bh],0C3Ch
	ja	08FEh

l0FDC_08B4:
	mov	es,[546Eh]
	cmp	word ptr es:[0A44Dh],0C049h
	jc	08FEh

l0FDC_08C1:
	cmp	word ptr es:[0A44Dh],0C04Fh
	ja	08FEh

l0FDC_08CA:
	cmp	word ptr [bp-2h],0h
	jz	08D7h

l0FDC_08D0:
	mov	word ptr [bp-10h],1h
	jmp	08FEh

l0FDC_08D7:
	cmp	word ptr [bp-0Eh],0h
	jnz	08F9h

l0FDC_08DD:
	call	far 1CD3h:17C6h
	mov	ax,146Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h

l0FDC_08F9:
	mov	word ptr [bp-0Eh],1h

l0FDC_08FE:
	cmp	word ptr [bp-10h],0h
	jnz	089Eh

l0FDC_0904:
	mov	word ptr [bp-12h],0h
	call	far 1F3Dh:002Fh
	or	ax,ax
	jz	0945h

l0FDC_0912:
	mov	word ptr [bp-12h],1h
	call	far 1F3Dh:0259h
	push	ax
	call	far 1E56h:0D1Dh
	add	sp,2h
	mov	[bp-20h],ax
	call	far 0800h:2A2Bh
	push	word ptr [bp-20h]
	call	far 0800h:231Dh
	add	sp,2h
	push	word ptr [bp-20h]
	call	far 0800h:218Fh
	add	sp,2h
	jmp	095Bh

l0FDC_0945:
	mov	ax,1h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	dec	word ptr [bp-1Eh]
	jns	095Bh

l0FDC_0956:
	mov	word ptr [bp-12h],1h

l0FDC_095B:
	cmp	word ptr [bp-12h],0h
	jnz	0964h

l0FDC_0961:
	jmp	089Eh

l0FDC_0964:
	mov	word ptr [bp-1Eh],0Ah
	call	far 0800h:240Bh
	inc	word ptr [5802h]
	cmp	word ptr [5802h],1h
	jnz	097Eh

l0FDC_0979:
	call	far 0800h:24C2h

l0FDC_097E:
	and	word ptr [5802h],3h
	call	far 207Fh:18EFh
	call	far 0800h:051Bh
	call	far 1F3Dh:06C3h
	mov	ax,[bp+6h]
	or	ax,ax
	jz	09A9h

l0FDC_0999:
	cmp	ax,1h
	jz	0A0Ah

l0FDC_099E:
	cmp	ax,9h
	jnz	09A6h

l0FDC_09A3:
	jmp	0AA8h

l0FDC_09A6:
	jmp	089Eh

l0FDC_09A9:
	inc	word ptr [bp-14h]
	mov	es,[5478h]
	cmp	byte ptr es:[32AEh],0h
	jz	09C4h

l0FDC_09B8:
	mov	al,es:[32AEh]
	cbw
	mov	cl,3h
	sar	ax,cl
	add	[bp-14h],ax

l0FDC_09C4:
	mov	es,[546Ch]
	cmp	word ptr es:[0A44Bh],0C78h
	jnc	09D4h

l0FDC_09D1:
	jmp	089Eh

l0FDC_09D4:
	mov	es,[546Eh]
	cmp	word ptr es:[0A44Dh],0C07Ch
	jnc	09E4h

l0FDC_09E1:
	jmp	089Eh

l0FDC_09E4:
	cmp	word ptr [bp-2h],0h
	jz	09EDh

l0FDC_09EA:
	jmp	089Eh

l0FDC_09ED:
	inc	word ptr [bp-2h]
	call	far 1CD3h:17C6h
	mov	ax,14A1h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h

l0FDC_0A02:
	call	far 1F3Dh:0259h
	jmp	089Eh

l0FDC_0A0A:
	mov	es,[546Ch]
	mov	ax,es:[0A44Bh]
	and	ax,7Fh
	shr	ax,1h
	mov	[bp-16h],ax
	mov	es,[546Eh]
	mov	ax,es:[0A44Dh]
	and	ax,7Fh
	shr	ax,1h
	mov	[bp-1Ah],ax
	mov	bx,[bp-22h]
	mov	al,[bx+1632h]
	cbw
	mov	si,ax
	lea	ax,[si-1h]
	cmp	[bp-16h],ax
	jge	0A3Fh

l0FDC_0A3C:
	jmp	089Eh

l0FDC_0A3F:
	cmp	[bp-16h],si
	jle	0A47h

l0FDC_0A44:
	jmp	089Eh

l0FDC_0A47:
	mov	bx,[bp-22h]
	mov	al,[bx+163Ah]
	cbw
	inc	ax
	cmp	ax,[bp-1Ah]
	jz	0A58h

l0FDC_0A55:
	jmp	089Eh

l0FDC_0A58:
	cmp	word ptr [bp-2h],0h
	jz	0A61h

l0FDC_0A5E:
	jmp	089Eh

l0FDC_0A61:
	inc	word ptr [bp-2h]
	call	far 1CD3h:17C6h
	mov	es,[545Ch]
	cmp	byte ptr es:[0C724h],4Ch
	jnz	0A84h

l0FDC_0A75:
	mov	ax,14EFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	0AA0h

l0FDC_0A84:
	mov	ax,152Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	al,[bp-18h]
	mov	bx,[bp-4h]
	mov	es,[5470h]
	mov	es:[bx+101Dh],al

l0FDC_0AA0:
	call	far 1F3Dh:086Ah
	jmp	0A02h

l0FDC_0AA8:
	mov	ax,[bp-14h]
	inc	word ptr [bp-14h]
	cmp	ax,50h
	jl	0AE7h

l0FDC_0AB3:
	mov	ax,88h
	push	ax
	sub	ax,ax
	push	ax
	push	cs
	call	0D49h
	add	sp,4h
	mov	ax,3h
	push	ax
	call	far 183Bh:000Ah
	add	sp,2h
	mov	word ptr [bp-14h],0h
	mov	es,[547Ah]
	cmp	word ptr es:[014Ah],0h
	jnz	0AE7h

l0FDC_0ADE:
	mov	ax,1h
	mov	[bp-10h],ax
	mov	[bp-2h],ax

l0FDC_0AE7:
	mov	es,[547Ah]
	cmp	word ptr es:[014Ah],0h
	jnz	0AF6h

l0FDC_0AF3:
	jmp	089Eh

l0FDC_0AF6:
	mov	es,[546Eh]
	cmp	word ptr es:[0A44Dh],702Dh
	jz	0B06h

l0FDC_0B03:
	jmp	089Eh

l0FDC_0B06:
	mov	word ptr [bp-1Ch],0h
	jmp	0B33h

l0FDC_0B0D:
	call	far 11B8h:16B2h
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,1611h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h

l0FDC_0B2B:
	call	far 1F3Dh:0259h

l0FDC_0B30:
	inc	word ptr [bp-1Ch]

l0FDC_0B33:
	cmp	word ptr [bp-1Ch],4h
	jl	0B3Ch

l0FDC_0B39:
	jmp	089Eh

l0FDC_0B3C:
	mov	ax,[bp-1Ch]
	shl	ax,1h
	shl	ax,1h
	add	ax,0D14h
	mov	es,[546Ch]
	cmp	ax,es:[0A44Bh]
	jnz	0B30h

l0FDC_0B51:
	mov	si,[bp-1Ch]
	shl	si,1h
	cmp	word ptr [bp+si-0Ch],0h
	jnz	0B30h

l0FDC_0B5C:
	mov	si,[bp-1Ch]
	shl	si,1h
	mov	word ptr [bp+si-0Ch],1h
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	ax,155Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,159Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	mov	ax,15D4h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-24h]
	inc	word ptr [bp-24h]
	cmp	ax,2h
	jz	0BC1h

l0FDC_0BBE:
	jmp	0B0Dh

l0FDC_0BC1:
	sub	ax,ax
	push	ax
	push	ax
	call	far 0800h:48B7h
	add	sp,4h
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,15F8h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	mov	ax,1h
	mov	[bp-2h],ax
	mov	[bp-10h],ax
	jmp	0B2Bh

l0FDC_0BF2:
	mov	es,[545Ch]
	mov	byte ptr es:[0D30Dh],0h
	mov	ax,[bp+6h]
	or	ax,ax
	jz	0C18h

l0FDC_0C03:
	cmp	ax,1h
	jz	0C45h

l0FDC_0C08:
	cmp	ax,2h
	jge	0C10h

l0FDC_0C0D:
	jmp	0D1Dh

l0FDC_0C10:
	cmp	ax,7h
	jle	0C80h

l0FDC_0C15:
	jmp	0D1Dh

l0FDC_0C18:
	cmp	byte ptr es:[0C724h],4Ch
	jnz	0C24h

l0FDC_0C20:
	sub	word ptr [bp-14h],32h

l0FDC_0C24:
	cmp	word ptr [bp-2h],0h
	jz	0C37h

l0FDC_0C2A:
	cmp	word ptr [bp-14h],0D7h
	jge	0C37h

l0FDC_0C31:
	mov	byte ptr es:[0D30Dh],1h

l0FDC_0C37:
	mov	es,[5470h]
	mov	al,[bp-18h]
	mov	es:[200Ah],al
	jmp	0D1Dh

l0FDC_0C45:
	mov	al,[bp-18h]
	mov	bx,[bp-4h]
	mov	es,[5470h]
	mov	es:[bx+101Dh],al
	mov	es,[545Ch]
	cmp	byte ptr es:[0C724h],4Ch
	jz	0C66h

l0FDC_0C60:
	mov	byte ptr es:[0D30Dh],1h

l0FDC_0C66:
	mov	al,es:[0C61Ch]
	cbw
	mov	[bp-14h],ax
	cmp	ax,3h
	jge	0C76h

l0FDC_0C73:
	inc	word ptr [bp-14h]

l0FDC_0C76:
	mov	al,[bp-14h]
	mov	es:[0C61Ch],al
	jmp	0D1Dh

l0FDC_0C80:
	cmp	byte ptr es:[0C724h],0FFh
	jz	0C9Eh

l0FDC_0C88:
	mov	es,[547Ch]
	cmp	word ptr es:[3992h],0h
	jnz	0C9Eh

l0FDC_0C94:
	mov	es,[545Ch]
	mov	byte ptr es:[0D30Dh],1h

l0FDC_0C9E:
	cmp	word ptr [bp+6h],4h
	jle	0CEEh

l0FDC_0CA4:
	mov	es,[545Ch]
	mov	al,es:[0C61Bh]
	cbw
	mov	[bp-14h],ax
	cmp	ax,4h
	jge	0CC0h

l0FDC_0CB5:
	call	far 207Fh:0BC0h
	and	ax,1h
	add	[bp-14h],ax

l0FDC_0CC0:
	mov	es,[545Ch]
	mov	al,[bp-14h]
	mov	es:[0C61Bh],al
	mov	al,es:[0C61Ch]
	cbw
	mov	[bp-14h],ax
	cmp	ax,4h
	jge	0CE3h

l0FDC_0CD8:
	call	far 207Fh:0BC0h
	and	ax,1h
	add	[bp-14h],ax

l0FDC_0CE3:
	mov	es,[545Ch]
	mov	al,[bp-14h]
	mov	es:[0C61Ch],al

l0FDC_0CEE:
	mov	es,[5474h]
	cmp	word ptr es:[3772h],0h
	jz	0D12h

l0FDC_0CFA:
	mov	es,[545Ch]
	mov	byte ptr es:[0D310h],1h
	cmp	byte ptr es:[0C724h],0FFh
	jz	0D12h

l0FDC_0D0C:
	mov	byte ptr es:[0D311h],1h

l0FDC_0D12:
	mov	es,[5474h]
	mov	word ptr es:[3772h],0h

l0FDC_0D1D:
	mov	es,[5476h]
	mov	word ptr es:[398Eh],0h
	mov	es,[547Eh]
	cmp	word ptr es:[4594h],0h
	jz	0D44h

l0FDC_0D34:
	mov	es,[5480h]
	push	word ptr es:[3FF8h]
	push	cs
	call	1D30h
	add	sp,2h

l0FDC_0D44:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_0D49: 0FDC:0D49
;;   Called from:
;;     0FDC:06FF (in fn0FDC_0629)
;;     0FDC:075C (in fn0FDC_0629)
;;     0FDC:07CD (in fn0FDC_0629)
;;     0FDC:07FE (in fn0FDC_0629)
;;     0FDC:0ABA (in fn0FDC_0629)
fn0FDC_0D49 proc
	push	bp
	mov	bp,sp
	mov	ax,1Ah
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-4h],2F0h
	mov	word ptr [bp-2h],2FE8h
	mov	es,[5482h]
	sub	ax,ax
	mov	[bp-6h],ax
	mov	es:[3994h],al
	mov	[bp-0Eh],ax

l0FDC_0D70:
	mov	si,[bp-0Eh]
	shl	si,1h
	mov	ax,1Ah
	imul	word ptr [bp-0Eh]
	mov	di,ax
	mov	es,[5484h]
	mov	ax,es:[si+4024h]
	mov	es,[545Ch]
	mov	es:[di+0D390h],ax
	mov	es,[5486h]
	mov	ax,es:[si+4056h]
	mov	es,[545Ch]
	mov	es:[di+0D392h],ax
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],8h
	jl	0D70h

l0FDC_0DAA:
	mov	word ptr [bp-0Eh],0h

l0FDC_0DAF:
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[545Ch]
	mov	byte ptr es:[bx+0C918h],0FFh
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],4h
	jl	0DAFh

l0FDC_0DCA:
	mov	word ptr [bp-0Eh],8h

l0FDC_0DCF:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[545Ch]
	mov	byte ptr es:[bx+0C614h],0FFh
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],10h
	jl	0DCFh

l0FDC_0DEA:
	mov	word ptr [bp-0Eh],0h

l0FDC_0DEF:
	mov	si,[bp-0Eh]
	shl	si,1h
	sub	ax,ax
	mov	es,[5488h]
	mov	es:[si+393Ch],ax
	mov	es,[548Ah]
	mov	es:[si+406Ah],ax
	mov	ax,0FFFFh
	mov	es,[5486h]
	mov	es:[si+4036h],ax
	mov	es,[5484h]
	mov	es:[si+4004h],ax
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],18h
	jl	0DEFh

l0FDC_0E26:
	cmp	word ptr [bp+8h],80h
	jge	0E3Ah

l0FDC_0E2D:
	mov	es,[548Ah]
	mov	word ptr es:[406Ah],1h
	jmp	0E45h

l0FDC_0E3A:
	mov	es,[548Ah]
	mov	word ptr es:[4072h],1h

l0FDC_0E45:
	test	byte ptr [bp+6h],80h
	jnz	0E4Eh

l0FDC_0E4B:
	jmp	0EF5h

l0FDC_0E4E:
	call	far 207Fh:0BC0h
	and	ax,3h
	add	ax,0A10h
	mov	[bp-10h],ax
	call	far 207Fh:0BC0h
	test	al,1h
	jz	0E73h

l0FDC_0E65:
	call	far 207Fh:0BC0h
	and	ax,3h
	add	ax,0A28h
	mov	[bp-10h],ax

l0FDC_0E73:
	call	far 207Fh:0BC0h
	and	ax,3h
	add	ax,806Fh
	mov	[bp-14h],ax
	mov	es,[548Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	0EAFh

l0FDC_0E8D:
	mov	word ptr [bp-0Eh],0h

l0FDC_0E92:
	mov	bx,[bp-0Eh]
	mov	es,[545Ch]
	cmp	byte ptr es:[bx+0D452h],0FFh
	jnz	0EA6h

l0FDC_0EA1:
	mov	word ptr [bp+6h],2h

l0FDC_0EA6:
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],4h
	jl	0E92h

l0FDC_0EAF:
	call	far 0800h:19DDh
	dec	ax
	dec	ax
	mov	[bp-8h],ax
	mov	es,[548Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	0ED3h

l0FDC_0EC5:
	call	far 207Fh:0BC0h
	and	ax,3h
	add	ax,3h
	mov	[bp-8h],ax

l0FDC_0ED3:
	mov	bx,[bp-8h]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+13E2h]
	mov	dx,[bx+13E4h]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	mov	bx,[bp-8h]
	mov	al,[bx+140Eh]
	cbw
	mov	[bp-6h],ax
	jmp	0F32h

l0FDC_0EF5:
	call	far 207Fh:0BC0h
	and	ax,7h
	add	ax,0C65h
	mov	[bp-10h],ax
	call	far 207Fh:0BC0h
	and	ax,7h
	add	ax,0C059h
	mov	[bp-14h],ax
	test	byte ptr [bp+8h],80h
	jz	0F21h

l0FDC_0F17:
	mov	word ptr [bp-10h],0D10h
	mov	word ptr [bp-14h],7024h

l0FDC_0F21:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D30Ch],2h
	jnz	0F32h

l0FDC_0F2D:
	mov	word ptr [bp-10h],0C72h

l0FDC_0F32:
	mov	word ptr [bp-0Ch],8h
	and	word ptr [bp+6h],7Fh
	mov	es,[5474h]
	cmp	word ptr es:[3772h],0h
	jz	0F4Ch

l0FDC_0F47:
	mov	word ptr [bp+6h],4h

l0FDC_0F4C:
	cmp	word ptr [bp+6h],0h
	jnz	0F55h

l0FDC_0F52:
	jmp	1208h

l0FDC_0F55:
	mov	word ptr [bp-0Eh],0h
	jmp	11D9h

l0FDC_0F5D:
	mov	bx,[bp-12h]
	mov	es,[548Eh]
	mov	al,es:[bx+561h]

l0FDC_0F69:
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	add	bx,[bp-12h]
	mov	es,[545Ch]
	mov	es:[bx+0C918h],cl
	mov	es,[548Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	0FA6h

l0FDC_0F8B:
	cmp	word ptr [bp-0Eh],0h
	jz	0FA6h

l0FDC_0F91:
	mov	bx,[bp-12h]
	mov	es,[5490h]
	mov	al,es:[bx+5DEh]
	mov	es,[545Ch]
	mov	es:[bx+0C995h],al

l0FDC_0FA6:
	inc	word ptr [bp-12h]

l0FDC_0FA9:
	cmp	word ptr [bp-12h],7Dh
	jge	0FC6h

l0FDC_0FAF:
	mov	es,[5474h]
	cmp	word ptr es:[3772h],0h
	jnz	0F5Dh

l0FDC_0FBB:
	mov	bx,[bp-12h]
	les	si,[bp-4h]
	mov	al,es:[bx+si]
	jmp	0F69h

l0FDC_0FC6:
	mov	es,[5474h]
	cmp	word ptr es:[3772h],0h
	jz	0FDCh

l0FDC_0FD2:
	mov	es,[545Ch]
	mov	byte ptr es:[0D30Fh],0h

l0FDC_0FDC:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D30Fh],6h
	jle	0FEEh

l0FDC_0FE8:
	mov	byte ptr es:[0D30Fh],6h

l0FDC_0FEE:
	mov	word ptr [bp-12h],11h
	jmp	100Dh

l0FDC_0FF5:
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	add	bx,[bp-12h]
	mov	es,[545Ch]
	mov	byte ptr es:[bx+0C918h],0h

l0FDC_100A:
	inc	word ptr [bp-12h]

l0FDC_100D:
	cmp	word ptr [bp-12h],1Bh
	jg	1049h

l0FDC_1013:
	mov	es,[545Ch]
	mov	al,es:[0D30Fh]
	cbw
	mov	bx,ax
	mov	al,[bx+165Ah]
	mov	[bp-16h],al
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	add	ax,[bp-12h]
	add	ax,0C918h
	mov	[bp-1Ah],ax
	mov	word ptr [bp-18h],3092h
	les	bx,[bp-1Ah]
	mov	al,[bp-16h]
	cmp	es:[bx],al
	jbe	0FF5h

l0FDC_1044:
	sub	es:[bx],al
	jmp	100Ah

l0FDC_1049:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D30Fh],4h
	jg	1058h

l0FDC_1055:
	jmp	10EFh

l0FDC_1058:
	mov	word ptr [bp-12h],0h

l0FDC_105D:
	call	far 207Fh:0BC0h
	and	ax,1Fh
	add	ax,34h
	mov	[bp-0Ah],ax
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	add	ax,[bp-0Ah]
	add	ax,0C918h
	mov	[bp-1Ah],ax
	mov	word ptr [bp-18h],3092h
	les	bx,[bp-1Ah]
	cmp	byte ptr es:[bx],0h
	jz	108Ch

l0FDC_1088:
	or	byte ptr es:[bx],80h

l0FDC_108C:
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],5h
	jl	105Dh

l0FDC_1095:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D30Fh],5h
	jle	10EFh

l0FDC_10A1:
	call	far 207Fh:0BC0h
	and	al,1h
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[545Ch]
	mov	es:[bx+0C98Dh],cl
	call	far 207Fh:0BC0h
	and	al,1h
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[545Ch]
	mov	es:[bx+0C98Fh],cl
	call	far 207Fh:0BC0h
	and	al,1h
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[545Ch]
	mov	es:[bx+0C98Eh],cl

l0FDC_10EF:
	mov	al,[bp-6h]
	mov	bx,[bp-0Eh]
	mov	es,[5492h]
	mov	es:[bx+0D56Ah],al
	mov	bx,[bp-0Eh]
	mov	es,[5494h]
	mov	byte ptr es:[bx+40A6h],0Ch
	mov	bx,[bp-0Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5496h]
	mov	word ptr es:[bx+226h],2A0h
	mov	word ptr es:[bx+228h],2FE8h
	mov	al,6h
	mov	bx,[bp-0Eh]
	mov	es,[5498h]
	mov	es:[bx+392Ch],al
	mov	bx,[bp-0Eh]
	mov	es,[549Ah]
	mov	es:[bx+3978h],al
	mov	si,[bp-0Eh]
	shl	si,1h
	mov	es,[548Ah]
	mov	word ptr es:[si+4082h],1h
	mov	bx,[bp-0Eh]
	mov	al,[bx+1642h]
	cbw
	add	ax,[bp-10h]
	mov	es,[5484h]
	mov	es:[si+401Ch],ax
	mov	bx,[bp-0Eh]
	mov	al,[bx+164Eh]
	cbw
	add	ax,[bp-14h]
	mov	es,[5486h]
	mov	es:[si+404Eh],ax
	mov	es,[548Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	11D6h

l0FDC_1182:
	cmp	word ptr [bp-0Eh],0h
	jz	11D6h

l0FDC_1188:
	mov	es,[5494h]
	mov	byte ptr es:[40A7h],10h
	mov	es,[5492h]
	mov	byte ptr es:[0D56Bh],0h
	mov	es,[5496h]
	mov	word ptr es:[022Ah],4DD8h
	mov	word ptr es:[022Ch],3EDBh
	mov	es,[5498h]
	mov	al,2h
	mov	es:[392Dh],al
	mov	es,[549Ah]
	mov	es:[3979h],al
	mov	es,[5484h]
	mov	word ptr es:[401Eh],0A06h
	mov	es,[5486h]
	mov	word ptr es:[4050h],8066h

l0FDC_11D6:
	inc	word ptr [bp-0Eh]

l0FDC_11D9:
	mov	ax,[bp+6h]
	cmp	[bp-0Eh],ax
	jge	1208h

l0FDC_11E1:
	mov	ax,11h
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[545Ch]
	mov	byte ptr es:[si+0C614h],0h
	mov	al,[bp-0Eh]
	add	al,4h
	mov	es:[si+0C620h],al
	inc	word ptr [bp-0Ch]
	mov	word ptr [bp-12h],0h
	jmp	0FA9h

l0FDC_1208:
	cmp	word ptr [bp+8h],0h
	jnz	1211h

l0FDC_120E:
	jmp	1345h

l0FDC_1211:
	and	word ptr [bp+8h],7Fh
	mov	ax,[bp-0Ch]
	add	[bp+8h],ax
	cmp	word ptr [bp+8h],10h
	jle	1226h

l0FDC_1221:
	mov	word ptr [bp+8h],10h

l0FDC_1226:
	mov	ax,[bp-0Ch]
	mov	[bp-0Eh],ax
	jmp	133Ah

l0FDC_122F:
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	si,ax
	mov	es,[545Ch]
	mov	byte ptr es:[si+0C614h],0h
	mov	byte ptr es:[si+0C620h],8h
	mov	bx,[bp-0Eh]
	mov	es,[5492h]
	mov	byte ptr es:[bx+0D566h],0FEh
	mov	bx,[bp-0Eh]
	mov	es,[5494h]
	mov	byte ptr es:[bx+40A2h],1Ch
	mov	bx,[bp-0Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[5496h]
	mov	word ptr es:[bx+216h],2E0h
	mov	word ptr es:[bx+218h],2FE8h
	mov	al,6h
	mov	bx,[bp-0Eh]
	mov	es,[5498h]
	mov	es:[bx+3928h],al
	mov	bx,[bp-0Eh]
	mov	es,[549Ah]
	mov	es:[bx+3974h],al
	mov	si,[bp-0Eh]
	shl	si,1h
	mov	es,[548Ah]
	mov	word ptr es:[si+407Ah],1h
	mov	bx,[bp-0Eh]
	mov	al,[bx+1642h]
	cbw
	add	ax,[bp-10h]
	mov	es,[5484h]
	mov	es:[si+4014h],ax
	mov	bx,[bp-0Eh]
	mov	al,[bx+164Eh]
	cbw
	add	ax,[bp-14h]
	mov	es,[5486h]
	mov	es:[si+4046h],ax
	mov	word ptr [bp-12h],0h

l0FDC_12D1:
	call	far 207Fh:0BC0h
	and	al,1h
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	add	bx,[bp-12h]
	mov	es,[545Ch]
	mov	es:[bx+0C618h],cl
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],5h
	jle	12D1h

l0FDC_12F7:
	call	far 0800h:19DDh
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	mov	es,[545Ch]
	mov	es:[bx+0C615h],cl
	mov	ax,11h
	imul	word ptr [bp-0Eh]
	mov	si,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	mov	es:[si+0C623h],al
	call	far 207Fh:0BC0h
	cwd
	mov	cx,0Eh
	idiv	cx
	mov	es,[545Ch]
	mov	es:[si+0C61Fh],dl
	inc	word ptr [bp-0Eh]

l0FDC_133A:
	mov	ax,[bp+8h]
	cmp	[bp-0Eh],ax
	jge	1345h

l0FDC_1342:
	jmp	122Fh

l0FDC_1345:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_134B: 0FDC:134B
;;   Called from:
;;     0FDC:0741 (in fn0FDC_0629)
;;     0FDC:07E0 (in fn0FDC_0629)
fn0FDC_134B proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	es,[545Ch]
	cmp	byte ptr es:[0C620h],8h
	jz	1395h

l0FDC_1362:
	mov	es,[5484h]
	mov	ax,es:[4004h]
	mov	es,[546Ch]
	mov	es:[0A44Bh],ax
	mov	es,[5486h]
	mov	ax,es:[4036h]
	inc	ax
	inc	ax
	mov	es,[546Eh]
	mov	es:[0A44Dh],ax
	test	byte ptr es:[0A44Dh],80h
	jz	13B5h

l0FDC_138C:
	add	word ptr es:[0A44Dh],0F80h
	jmp	13B5h

l0FDC_1395:
	mov	es,[5484h]
	mov	ax,es:[400Ch]
	mov	es,[546Ch]
	mov	es:[0A44Bh],ax
	mov	es,[5486h]
	mov	ax,es:[403Eh]
	mov	es,[546Eh]
	mov	es:[0A44Dh],ax

l0FDC_13B5:
	push	word ptr es:[0A44Dh]
	mov	es,[546Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:051Bh
	call	far 1F3Dh:06C3h
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_13DE: 0FDC:13DE
;;   Called from:
;;     1CD3:0A43 (in fn1CD3_0004)
fn0FDC_13DE proc
	push	bp
	mov	bp,sp
	mov	ax,1Ch
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-16h],0h

l0FDC_13F0:
	mov	si,[bp-16h]
	shl	si,1h
	mov	word ptr [bp+si-10h],0FFFFh
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],8h
	jl	13F0h

l0FDC_1403:
	sub	ax,ax
	mov	[bp-14h],ax
	mov	[bp-16h],ax
	jmp	1432h

l0FDC_140D:
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	bx,ax
	mov	es,[545Ch]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jz	142Fh

l0FDC_1421:
	mov	si,[bp-14h]
	inc	word ptr [bp-14h]
	shl	si,1h
	mov	ax,[bp-16h]
	mov	[bp+si-10h],ax

l0FDC_142F:
	inc	word ptr [bp-16h]

l0FDC_1432:
	cmp	word ptr [bp-16h],8h
	jl	140Dh

l0FDC_1438:
	jmp	15D7h

l0FDC_143B:
	cmp	word ptr [bp-14h],1h
	jg	1444h

l0FDC_1441:
	jmp	1545h

l0FDC_1444:
	call	far 1E56h:0388h
	mov	ax,1661h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[549Ch]
	push	word ptr es:[bx+4E8Ch]
	push	word ptr es:[bx+4E8Ah]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1667h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-16h],0h
	jmp	1508h

l0FDC_1488:
	mov	si,[bp-16h]
	shl	si,1h
	mov	ax,11h
	imul	word ptr [bp+si-10h]
	mov	bx,ax
	mov	es,[545Ch]
	mov	al,es:[bx+0C614h]
	mov	[bp-1Ch],al
	cmp	al,0FFh
	jz	1505h

l0FDC_14A5:
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[549Eh]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5468h]
	mov	word ptr es:[3748h],0Ah
	mov	si,[bp-16h]
	shl	si,1h
	mov	ax,11h
	imul	word ptr [bp+si-10h]
	mov	bx,ax
	mov	es,[545Ch]
	mov	al,es:[bx+0C621h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[549Ch]
	push	word ptr es:[bx+4E8Ch]
	push	word ptr es:[bx+4E8Ah]
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1CD3h:181Eh

l0FDC_1505:
	inc	word ptr [bp-16h]

l0FDC_1508:
	mov	ax,[bp-14h]
	cmp	[bp-16h],ax
	jge	1513h

l0FDC_1510:
	jmp	1488h

l0FDC_1513:
	mov	ax,166Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	word ptr [bp+8h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	es,[54A0h]
	mov	ax,[bp-14h]
	inc	ax
	mov	es:[00D6h],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	jmp	155Ah

l0FDC_1545:
	mov	es,[545Ch]
	mov	al,[bp+6h]
	mov	es:[fn0800_4621],al
	mov	al,[bp+8h]
	mov	es:[0C622h],al
	mov	ax,[bp-14h]

l0FDC_155A:
	mov	[bp-12h],ax
	mov	ax,[bp-14h]
	cmp	[bp-12h],ax
	jnz	156Ch

l0FDC_1565:
	mov	word ptr [bp+6h],0h
	jmp	15D7h

l0FDC_156C:
	mov	di,[bp-12h]
	shl	di,1h
	mov	ax,[bp+di-10h]
	mov	[bp-12h],ax
	mov	ax,11h
	imul	word ptr [bp-12h]
	mov	si,ax
	mov	es,[545Ch]
	mov	al,es:[si+0C621h]
	cbw
	mov	[bp-1Ah],ax
	mov	al,es:[si+0C622h]
	cbw
	mov	[bp-18h],ax
	mov	al,[bp+6h]
	mov	es:[si+0C621h],al
	mov	al,[bp+8h]
	mov	es:[si+0C622h],al
	mov	ax,[bp-1Ah]
	cmp	[bp+6h],ax
	jnz	15CBh

l0FDC_15AD:
	mov	ax,14h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,168Bh
	push	ds
	push	ax
	call	far 0800h:2867h
	add	sp,8h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h

l0FDC_15CB:
	mov	ax,[bp-1Ah]
	mov	[bp+6h],ax
	mov	ax,[bp-18h]
	mov	[bp+8h],ax

l0FDC_15D7:
	cmp	word ptr [bp+6h],0h
	jz	15E0h

l0FDC_15DD:
	jmp	143Bh

l0FDC_15E0:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_15E6: 0FDC:15E6
;;   Called from:
;;     0DAB:0B4F (in fn0DAB_094B)
;;     1CD3:0AE2 (in fn1CD3_0004)
;;     1CD3:144A (in fn1CD3_0004)
fn0FDC_15E6 proc
	push	bp
	mov	bp,sp
	mov	ax,1Eh
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-16h],0h

l0FDC_15F7:
	mov	si,[bp-16h]
	shl	si,1h
	mov	word ptr [bp+si-10h],0FFFFh
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],8h
	jl	15F7h

l0FDC_160A:
	sub	ax,ax
	mov	[bp-14h],ax
	mov	[bp-16h],ax
	jmp	1639h

l0FDC_1614:
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	bx,ax
	mov	es,[545Ch]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jz	1636h

l0FDC_1628:
	mov	si,[bp-14h]
	inc	word ptr [bp-14h]
	shl	si,1h
	mov	ax,[bp-16h]
	mov	[bp+si-10h],ax

l0FDC_1636:
	inc	word ptr [bp-16h]

l0FDC_1639:
	cmp	word ptr [bp-16h],8h
	jl	1614h

l0FDC_163F:
	jmp	17ABh

l0FDC_1642:
	cmp	word ptr [bp-14h],1h
	jg	164Bh

l0FDC_1648:
	jmp	1734h

l0FDC_164B:
	call	far 1E56h:0388h
	mov	ax,16AEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,16B4h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-16h],0h
	jmp	1702h

l0FDC_168A:
	mov	si,[bp-16h]
	shl	si,1h
	mov	ax,11h
	imul	word ptr [bp+si-10h]
	mov	bx,ax
	mov	es,[545Ch]
	mov	al,es:[bx+0C614h]
	mov	[bp-1Ah],al
	cmp	al,0FFh
	jz	16FFh

l0FDC_16A7:
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[549Eh]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5468h]
	mov	word ptr es:[3748h],0Ah
	mov	si,[bp-16h]
	shl	si,1h
	mov	ax,11h
	imul	word ptr [bp+si-10h]
	mov	bx,ax
	mov	es,[545Ch]
	mov	al,11h
	imul	byte ptr es:[bx+0C61Fh]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1CD3h:181Eh

l0FDC_16FF:
	inc	word ptr [bp-16h]

l0FDC_1702:
	mov	ax,[bp-14h]
	cmp	[bp-16h],ax
	jge	170Dh

l0FDC_170A:
	jmp	168Ah

l0FDC_170D:
	mov	ax,16BAh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54A0h]
	mov	ax,[bp-14h]
	inc	ax
	mov	es:[00D6h],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	jmp	1747h

l0FDC_1734:
	mov	es,[545Ch]
	mov	al,[bp+6h]
	mov	es:[0C61Fh],al
	mov	word ptr [bp+6h],0h
	mov	ax,[bp-14h]

l0FDC_1747:
	mov	[bp-12h],ax
	mov	ax,[bp-14h]
	cmp	[bp-12h],ax
	jnz	1759h

l0FDC_1752:
	mov	word ptr [bp+6h],0h
	jmp	17ABh

l0FDC_1759:
	mov	si,[bp-12h]
	shl	si,1h
	mov	ax,11h
	imul	word ptr [bp+si-10h]
	add	ax,0C61Fh
	mov	[bp-1Eh],ax
	mov	word ptr [bp-1Ch],3092h
	les	bx,[bp-1Eh]
	mov	al,es:[bx]
	cbw
	mov	[bp-18h],ax
	mov	al,[bp+6h]
	mov	es:[bx],al
	mov	ax,[bp-18h]
	cmp	[bp+6h],ax
	jnz	17A5h

l0FDC_1787:
	mov	ax,14h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,16C2h
	push	ds
	push	ax
	call	far 0800h:2867h
	add	sp,8h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h

l0FDC_17A5:
	mov	ax,[bp-18h]
	mov	[bp+6h],ax

l0FDC_17AB:
	cmp	word ptr [bp+6h],0h
	jz	17B4h

l0FDC_17B1:
	jmp	1642h

l0FDC_17B4:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_17B9: 0FDC:17B9
;;   Called from:
;;     1CD3:0AEA (in fn1CD3_0004)
fn0FDC_17B9 proc
	push	bp
	mov	bp,sp
	mov	ax,12h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-0Ah],0h
	jmp	17D0h

l0FDC_17CD:
	inc	word ptr [bp-0Ah]

l0FDC_17D0:
	cmp	word ptr [bp-0Ah],8h
	jge	17ECh

l0FDC_17D6:
	mov	es,[545Ch]
	mov	al,es:[0D319h]
	mov	bx,[bp-0Ah]
	mov	es,[5460h]
	cmp	es:[bx+4602h],al
	jnz	17CDh

l0FDC_17EC:
	call	far 1E56h:0388h
	mov	word ptr [bp-0Ch],0h
	mov	word ptr [bp-12h],0h

l0FDC_17FB:
	mov	di,[bp-12h]
	mov	byte ptr [bp+di-8h],0h
	mov	ax,1Ah
	imul	word ptr [bp-12h]
	mov	si,ax
	mov	es,[545Ch]
	cmp	byte ptr es:[si+0D399h],0h
	jz	183Ch

l0FDC_1816:
	mov	al,es:[si+0D398h]
	sub	ah,ah
	mov	[bp-0Eh],ax
	mov	cl,4h
	sar	ax,cl
	and	ax,7h
	mov	[bp-0Eh],ax
	mov	ax,[bp-0Ah]
	cmp	[bp-0Eh],ax
	jnz	183Ch

l0FDC_1832:
	mov	di,[bp-12h]
	mov	byte ptr [bp+di-8h],1h
	inc	word ptr [bp-0Ch]

l0FDC_183C:
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],8h
	jl	17FBh

l0FDC_1845:
	cmp	word ptr [bp-0Ch],0h
	jnz	1853h

l0FDC_184B:
	mov	ax,16DEh
	push	ds
	push	ax
	jmp	19CEh

l0FDC_1853:
	mov	ax,170Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-12h],0h

l0FDC_1865:
	mov	si,[bp-12h]
	cmp	byte ptr [bp+si-8h],0h
	jz	188Ah

l0FDC_186E:
	mov	bx,si
	mov	cl,4h
	shl	bx,cl
	lea	ax,[bx+0A461h]
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1CD3h:181Eh

l0FDC_188A:
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],8h
	jl	1865h

l0FDC_1893:
	mov	ax,1728h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54A0h]
	mov	ax,[bp-0Ch]
	inc	ax
	mov	es:[01D6h],ax
	mov	ax,14h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-10h],ax
	mov	ax,[bp-0Ch]
	cmp	[bp-10h],ax
	jnz	18C6h

l0FDC_18C3:
	jmp	19DBh

l0FDC_18C6:
	mov	es,[545Ch]
	cmp	byte ptr es:[0D339h],0h
	jz	18F3h

l0FDC_18D2:
	cmp	word ptr [bp-0Eh],7h
	jnz	18F3h

l0FDC_18D8:
	cmp	word ptr [bp-10h],0h
	jnz	18F3h

l0FDC_18DE:
	cmp	byte ptr [bp-8h],0h
	jz	18F3h

l0FDC_18E4:
	mov	byte ptr es:[0D33Ah],1h
	mov	byte ptr es:[0D399h],0h
	jmp	19DBh

l0FDC_18F3:
	mov	byte ptr es:[0D33Ah],0h
	call	far 1E56h:0388h
	mov	es,[545Ch]
	cmp	byte ptr es:[0D310h],0h
	jz	190Dh

l0FDC_190A:
	jmp	19B2h

l0FDC_190D:
	mov	ax,172Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[545Ch]
	mov	al,es:[0D319h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[54A2h]
	push	word ptr es:[bx+4E34h]
	push	word ptr es:[bx+4E32h]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1761h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-12h],0h
	jmp	1956h

l0FDC_1953:
	inc	word ptr [bp-12h]

l0FDC_1956:
	cmp	word ptr [bp-12h],8h
	jge	19DBh

l0FDC_195C:
	mov	si,[bp-12h]
	cmp	byte ptr [bp+si-8h],0h
	jz	1953h

l0FDC_1965:
	dec	word ptr [bp-10h]
	jns	1953h

l0FDC_196A:
	mov	ax,1Ah
	imul	si
	mov	bx,ax
	mov	es,[545Ch]
	mov	al,es:[bx+0D398h]
	sub	ah,ah
	and	ax,7h
	mov	[bp-0Ch],ax
	mov	bx,ax
	mov	cl,4h
	shl	bx,cl
	lea	ax,[bx+0A561h]
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,178Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	word ptr [bp-12h],8h
	jmp	1953h

l0FDC_19B2:
	call	far 207Fh:0BC0h
	mov	bx,ax
	and	bx,7h
	shl	bx,1h
	shl	bx,1h
	mov	es,[54A4h]
	push	word ptr es:[bx+4E60h]
	push	word ptr es:[bx+4E5Eh]

l0FDC_19CE:
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h

l0FDC_19DB:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_19E1: 0FDC:19E1
;;   Called from:
;;     1CD3:0717 (in fn1CD3_0004)
fn0FDC_19E1 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,1791h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	retf

;; fn0FDC_19F6: 0FDC:19F6
;;   Called from:
;;     0FDC:039F (in fn0FDC_01C0)
;;     0FDC:03D9 (in fn0FDC_01C0)
;;     0FDC:050E (in fn0FDC_01C0)
;;     0FDC:053A (in fn0FDC_01C0)
;;     0FDC:0558 (in fn0FDC_01C0)
;;     0FDC:0578 (in fn0FDC_01C0)
fn0FDC_19F6 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	les	bx,[bp+6h]
	mov	al,es:[bx]
	cbw
	mov	[bp-4h],ax
	mov	al,es:[bx+1h]
	cbw
	mov	[bp-2h],ax
	mov	al,[bp-4h]
	sub	ah,ah
	mov	ch,[bp-2h]
	sub	cl,cl
	or	ax,cx
	mov	[bp-2h],ax
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_1A26: 0FDC:1A26
;;   Called from:
;;     1CD3:105A (in fn1CD3_0004)
fn0FDC_1A26 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-4h],0h

l0FDC_1A37:
	mov	ax,7Dh
	imul	word ptr [bp-4h]
	mov	si,ax
	mov	es,[545Ch]
	mov	al,es:[si+0C79Dh]
	mov	bx,[bp-4h]
	mov	es,[54A6h]
	mov	es:[bx+430Eh],al
	mov	es,[545Ch]
	mov	al,es:[si+0C79Eh]
	mov	bx,[bp-4h]
	mov	es,[54A8h]
	mov	es:[bx+3FFAh],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],4h
	jl	1A37h

l0FDC_1A72:
	call	far 1E56h:0388h
	mov	ax,17A5h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1467h:0B98h
	mov	word ptr [bp-4h],0h

l0FDC_1A8E:
	mov	bx,[bp-4h]
	mov	es,[545Ch]
	mov	al,es:[bx+0C724h]
	mov	es,[54AAh]
	mov	es:[bx+3780h],al
	mov	es,[54ACh]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-4h]
	mov	es,[545Ch]
	mov	al,es:[bx+0C724h]
	mov	bx,[bp-4h]
	mov	es:[bx+0C724h],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],7Dh
	jl	1A8Eh

l0FDC_1ACE:
	mov	es,[54ACh]
	mov	bx,es:[0068h]
	mov	es,[545Ch]
	mov	al,es:[bx+0D452h]
	mov	es:[0C724h],al
	mov	word ptr [bp-4h],1h

l0FDC_1AE9:
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	si,ax
	mov	al,3h
	mov	es,[545Ch]
	mov	es:[si+0C620h],al
	mov	es:[si+0C60Fh],al
	mov	al,es:[si+0C614h]
	mov	bx,[bp-4h]
	mov	es,[54AEh]
	mov	es:[bx+3FE9h],al
	mov	es,[545Ch]
	mov	byte ptr es:[si+0C614h],0FFh
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],8h
	jl	1AE9h

l0FDC_1B25:
	mov	byte ptr es:[0C79Dh],0h
	mov	byte ptr es:[0C79Eh],0FFh
	mov	es,[548Ch]
	mov	word ptr es:[0E48Eh],0h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_1B41: 0FDC:1B41
;;   Called from:
;;     1CD3:1150 (in fn1CD3_0004)
fn0FDC_1B41 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[548Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	1B83h

l0FDC_1B59:
	mov	word ptr [bp-2h],0h
	jmp	1B63h

l0FDC_1B60:
	inc	word ptr [bp-2h]

l0FDC_1B63:
	cmp	word ptr [bp-2h],7Dh
	jl	1B6Ch

l0FDC_1B69:
	jmp	1C5Bh

l0FDC_1B6C:
	mov	bx,[bp-2h]
	mov	es,[54AAh]
	mov	al,es:[bx+3780h]
	mov	es,[545Ch]
	mov	es:[bx+0C724h],al
	jmp	1B60h

l0FDC_1B83:
	mov	word ptr [bp-2h],0h

l0FDC_1B88:
	mov	bx,[bp-2h]
	mov	es,[545Ch]
	mov	al,es:[bx+0C724h]
	mov	es,[54ACh]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-2h]
	mov	es,[545Ch]
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],7Dh
	jl	1B88h

l0FDC_1BB9:
	cmp	byte ptr es:[0C724h],0FFh
	jnz	1BD4h

l0FDC_1BC1:
	mov	es,[54ACh]
	mov	bx,es:[0068h]
	mov	es,[545Ch]
	mov	byte ptr es:[bx+0D452h],0FFh

l0FDC_1BD4:
	mov	es,[54ACh]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[545Ch]
	mov	byte ptr es:[bx+0C724h],0FFh
	mov	es,[54ACh]
	cmp	word ptr es:[0068h],0h
	jz	1C1Bh

l0FDC_1BF8:
	mov	word ptr [bp-2h],0h

l0FDC_1BFD:
	mov	bx,[bp-2h]
	mov	es,[54AAh]
	mov	al,es:[bx+3780h]
	mov	es,[545Ch]
	mov	es:[bx+0C724h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],7Dh
	jl	1BFDh

l0FDC_1C1B:
	mov	word ptr [bp-2h],0h

l0FDC_1C20:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	bx,[bp-2h]
	mov	es,[54A6h]
	mov	al,es:[bx+430Eh]
	mov	es,[545Ch]
	mov	es:[si+0C79Dh],al
	mov	bx,[bp-2h]
	mov	es,[54A8h]
	mov	al,es:[bx+3FFAh]
	mov	es,[545Ch]
	mov	es:[si+0C79Eh],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],4h
	jl	1C20h

l0FDC_1C5B:
	mov	word ptr [bp-2h],1h

l0FDC_1C60:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	al,8h
	mov	es,[545Ch]
	mov	es:[si+0C620h],al
	mov	es:[si+0C60Fh],al
	mov	bx,[bp-2h]
	mov	es,[54AEh]
	mov	al,es:[bx+3FE9h]
	mov	es,[545Ch]
	mov	es:[si+0C614h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jl	1C60h

l0FDC_1C96:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_1C9B: 0FDC:1C9B
;;   Called from:
;;     1CD3:1052 (in fn1CD3_0004)
fn0FDC_1C9B proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0h

l0FDC_1CAC:
	mov	bx,[bp-2h]
	mov	es,[545Ch]
	mov	al,es:[bx+0C724h]
	mov	es,[54AAh]
	mov	es:[bx+3780h],al
	mov	bx,[bp-2h]
	mov	es,[54B0h]
	mov	al,es:[bx+2F0h]
	mov	es,[545Ch]
	mov	es:[bx+0C724h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],7Dh
	jl	1CACh

l0FDC_1CDF:
	mov	word ptr [bp-2h],1h

l0FDC_1CE4:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	al,3h
	mov	es,[545Ch]
	mov	es:[si+0C620h],al
	mov	es:[si+0C60Fh],al
	mov	al,es:[si+0C614h]
	mov	bx,[bp-2h]
	mov	es,[54AEh]
	mov	es:[bx+3FE9h],al
	mov	es,[545Ch]
	mov	byte ptr es:[si+0C614h],0FFh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jl	1CE4h

l0FDC_1D20:
	mov	es,[548Ch]
	mov	word ptr es:[0E48Eh],1h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0FDC_1D30: 0FDC:1D30
;;   Called from:
;;     0FDC:0091 (in fn0FDC_0008)
;;     0FDC:0D3D (in fn0FDC_0629)
fn0FDC_1D30 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	ax,1h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	cmp	word ptr [bp+6h],2h
	jl	1D53h

l0FDC_1D4D:
	cmp	word ptr [bp+6h],11h
	jl	1D5Fh

l0FDC_1D53:
	mov	ax,2h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h

l0FDC_1D5F:
	mov	es,[5480h]
	mov	ax,[bp+6h]
	mov	es:[3FF8h],ax
	mov	ax,0A0h
	mov	dx,3092h
	push	dx
	push	ax
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[54B2h]
	push	word ptr es:[bx+4EC4h]
	push	word ptr es:[bx+4EC2h]
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	word ptr [bp-2h],0h

l0FDC_1D94:
	mov	bx,[bp-2h]
	mov	es,[54B4h]
	mov	al,es:[bx+0A0h]
	add	al,29h
	xor	al,0E9h
	mov	es:[bx+0A0h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],2328h
	jl	1D94h

l0FDC_1DB3:
	mov	es,[547Eh]
	mov	word ptr es:[4594h],0h
	mov	sp,bp
