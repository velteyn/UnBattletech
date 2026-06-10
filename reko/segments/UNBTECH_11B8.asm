;;; Segment 11B8 (11B8:0000)
11B8:0000 5D CB                                           ].              

;; fn11B8_0002: 11B8:0002
;;   Called from:
;;     1CD3:0CD8 (in fn1CD3_0004)
fn11B8_0002 proc
	push	bp
	mov	bp,sp
	mov	ax,6Ch
	call	far 207Fh:2FDCh
	push	si
	call	far 1E56h:0388h
	mov	ax,17E5h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1467h:0B98h
	mov	[bp-32h],ax
	sub	ax,ax
	mov	[bp-36h],ax
	mov	[bp-2Ah],ax
	mov	[bp-2Ch],ax
	mov	[bp-30h],ax
	mov	[bp-2Eh],ax
	mov	word ptr [bp-3Ah],11h

l11B8_003E:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-3Ah]
	mov	es,[54B8h]
	mov	al,es:[si+0C769h]
	sub	ah,ah
	mov	cl,es:[si+0C724h]
	sub	ch,ch
	sub	ax,cx
	add	[bp-2Eh],ax
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],1Bh
	jle	003Eh

l11B8_006F:
	mov	word ptr [bp-3Ah],1Ch

l11B8_0074:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-3Ah]
	mov	es,[54B8h]
	mov	al,es:[si+0C769h]
	sub	ah,ah
	mov	cl,es:[si+0C724h]
	sub	ch,ch
	sub	ax,cx
	add	[bp-2Ch],ax
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],23h
	jle	0074h

l11B8_00A5:
	mov	word ptr [bp-3Ah],0h

l11B8_00AA:
	mov	si,[bp-3Ah]
	shl	si,1h
	sub	ax,ax
	mov	[bp+si-28h],ax
	mov	si,[bp-3Ah]
	shl	si,1h
	mov	[bp+si-64h],ax
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],14h
	jl	00AAh

l11B8_00C5:
	mov	word ptr [bp-3Ah],33h

l11B8_00CA:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-3Ah]
	mov	es,[54B8h]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	mov	[bp-66h],ax
	test	byte ptr [bp-66h],80h
	jz	0116h

l11B8_00EF:
	and	word ptr [bp-66h],7Fh
	cmp	word ptr [bp-66h],22h
	jnz	00FCh

l11B8_00F9:
	inc	word ptr [bp-30h]

l11B8_00FC:
	cmp	word ptr [bp-66h],10h
	jl	0116h

l11B8_0102:
	cmp	word ptr [bp-66h],20h
	jg	0116h

l11B8_0108:
	mov	si,[bp-66h]
	shl	si,1h
	inc	word ptr [bp+si+0FF7Ch]
	mov	word ptr [bp-2Ah],1h

l11B8_0116:
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],55h
	jle	00CAh

l11B8_011F:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	es,[54B8h]
	mov	al,es:[si+0C78Dh]
	cmp	es:[si+0C748h],al
	jz	0142h

l11B8_013D:
	mov	word ptr [bp-36h],1h

l11B8_0142:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	es,[54B8h]
	mov	al,es:[si+0C78Eh]
	cmp	es:[si+0C749h],al
	jz	0164h

l11B8_0160:
	or	byte ptr [bp-36h],2h

l11B8_0164:
	mov	ax,[bp-2Ah]
	add	ax,[bp-2Ch]
	add	ax,[bp-2Eh]
	add	ax,[bp-30h]
	add	ax,[bp-36h]
	jnz	01E2h

l11B8_0175:
	mov	word ptr [bp-36h],0h
	mov	word ptr [bp-34h],75h

l11B8_017F:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-34h]
	mov	es,[54B8h]
	cmp	byte ptr es:[bx+0C724h],0h
	jz	01CAh

l11B8_019C:
	mov	word ptr [bp-36h],1h
	mov	ax,17F7h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-34h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+1B40h]
	push	word ptr [bx+1B3Eh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-34h],78h

l11B8_01CA:
	inc	word ptr [bp-34h]
	cmp	word ptr [bp-34h],77h
	jle	017Fh

l11B8_01D3:
	cmp	word ptr [bp-36h],0h
	jz	01DCh

l11B8_01D9:
	jmp	0800h

l11B8_01DC:
	mov	ax,1834h
	jmp	07F6h

l11B8_01E2:
	mov	es,[54B8h]
	mov	ax,es:[0D370h]
	or	ax,es:[0D372h]
	jnz	0206h

l11B8_01F1:
	mov	ax,1879h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1CD3h:1809h
	jmp	0800h

l11B8_0206:
	cmp	word ptr [bp-2Eh],0h
	jnz	020Fh

l11B8_020C:
	jmp	032Fh

l11B8_020F:
	call	far 1E56h:0388h
	mov	ax,1899h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	word ptr [bp-2Eh]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,18BFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-2Eh]
	shl	ax,1h
	shl	ax,1h
	push	ax
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,1902h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	ax,1919h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jnz	0282h

l11B8_027F:
	jmp	032Fh

l11B8_0282:
	mov	word ptr [bp-3Ah],11h
	jmp	02DEh

l11B8_0289:
	mov	es,[54B8h]
	cmp	word ptr es:[0D372h],0h
	jnz	029Dh

l11B8_0295:
	cmp	word ptr es:[0D370h],4h
	jc	02D0h

l11B8_029D:
	sub	word ptr es:[0D370h],4h
	sbb	word ptr es:[0D372h],0h
	dec	word ptr [bp-68h]
	dec	word ptr [bp-2Eh]
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-3Ah]
	mov	es,[54B8h]
	inc	byte ptr es:[bx+0C724h]
	call	far 1631h:1FDFh
	jmp	02D5h

l11B8_02D0:
	mov	word ptr [bp-68h],0h

l11B8_02D5:
	cmp	word ptr [bp-68h],0h
	jnz	0289h

l11B8_02DB:
	inc	word ptr [bp-3Ah]

l11B8_02DE:
	cmp	word ptr [bp-3Ah],1Bh
	jg	0312h

l11B8_02E4:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-3Ah]
	mov	es,[54B8h]
	mov	al,es:[si+0C769h]
	sub	ah,ah
	mov	cl,es:[si+0C724h]
	sub	ch,ch
	sub	ax,cx
	mov	[bp-68h],ax
	or	ax,ax
	jz	02DBh

l11B8_0310:
	jmp	02D5h

l11B8_0312:
	cmp	word ptr [bp-2Eh],0h
	jz	032Fh

l11B8_0318:
	call	far 1E56h:0388h
	mov	ax,192Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h

l11B8_032F:
	cmp	word ptr [bp-2Ch],0h
	jnz	0338h

l11B8_0335:
	jmp	0459h

l11B8_0338:
	call	far 1E56h:0388h
	mov	ax,1981h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,19BCh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1A19h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,9h
	imul	word ptr [bp-2Ch]
	push	ax
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,1A4Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	ax,1A66h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jnz	03ACh

l11B8_03A9:
	jmp	0459h

l11B8_03AC:
	mov	word ptr [bp-3Ah],1Ch
	jmp	0408h

l11B8_03B3:
	mov	es,[54B8h]
	cmp	word ptr es:[0D372h],0h
	jnz	03C7h

l11B8_03BF:
	cmp	word ptr es:[0D370h],9h
	jc	03FAh

l11B8_03C7:
	sub	word ptr es:[0D370h],9h
	sbb	word ptr es:[0D372h],0h
	dec	word ptr [bp-68h]
	dec	word ptr [bp-2Ch]
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-3Ah]
	mov	es,[54B8h]
	inc	byte ptr es:[bx+0C724h]
	call	far 1631h:1FDFh
	jmp	03FFh

l11B8_03FA:
	mov	word ptr [bp-68h],0h

l11B8_03FF:
	cmp	word ptr [bp-68h],0h
	jnz	03B3h

l11B8_0405:
	inc	word ptr [bp-3Ah]

l11B8_0408:
	cmp	word ptr [bp-3Ah],23h
	jg	043Ch

l11B8_040E:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-3Ah]
	mov	es,[54B8h]
	mov	al,es:[si+0C769h]
	sub	ah,ah
	mov	cl,es:[si+0C724h]
	sub	ch,ch
	sub	ax,cx
	mov	[bp-68h],ax
	or	ax,ax
	jz	0405h

l11B8_043A:
	jmp	03FFh

l11B8_043C:
	cmp	word ptr [bp-2Ch],0h
	jz	0459h

l11B8_0442:
	call	far 1E56h:0388h
	mov	ax,1A77h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h

l11B8_0459:
	cmp	word ptr [bp-30h],0h
	jnz	0462h

l11B8_045F:
	jmp	0744h

l11B8_0462:
	call	far 1E56h:0388h
	mov	ax,1ACEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	word ptr [bp-30h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,1ADAh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-30h],1h
	jle	049Fh

l11B8_0492:
	mov	ax,1AE5h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l11B8_049F:
	mov	ax,1AE7h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	ax,1B44h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jnz	04D8h

l11B8_04D5:
	jmp	0744h

l11B8_04D8:
	mov	word ptr [bp-3Ah],33h

l11B8_04DD:
	cmp	word ptr [bp-30h],0h
	jz	053Eh

l11B8_04E3:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	add	ax,[bp-3Ah]
	add	ax,0C724h
	mov	[bp-6Ch],ax
	mov	word ptr [bp-6Ah],3092h
	les	bx,[bp-6Ch]
	mov	al,es:[bx]
	sub	ah,ah
	mov	[bp-68h],ax
	cmp	ax,0A2h
	jnz	053Eh

l11B8_050D:
	mov	es,[54B8h]
	cmp	word ptr es:[0D372h],0h
	jnz	0522h

l11B8_0519:
	cmp	word ptr es:[0D370h],320h
	jc	053Eh

l11B8_0522:
	sub	word ptr es:[0D370h],320h
	sbb	word ptr es:[0D372h],0h
	dec	word ptr [bp-30h]
	mov	es,[bp-6Ah]
	mov	byte ptr es:[bx],22h
	call	far 1631h:1FDFh

l11B8_053E:
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],55h
	jle	04DDh

l11B8_0547:
	cmp	word ptr [bp-30h],0h
	jnz	0550h

l11B8_054D:
	jmp	0744h

l11B8_0550:
	call	far 1E56h:0388h
	mov	ax,1B63h

l11B8_0558:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	0744h

l11B8_056A:
	call	far 1E56h:0388h
	mov	ax,1BB5h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-34h],0h

l11B8_0581:
	mov	si,[bp-34h]
	shl	si,1h
	mov	word ptr [bp+si-28h],0h
	inc	word ptr [bp-34h]
	cmp	word ptr [bp-34h],14h
	jl	0581h

l11B8_0594:
	mov	word ptr [bp-3Ah],0h
	mov	word ptr [bp-34h],0h

l11B8_059E:
	mov	si,[bp-34h]
	shl	si,1h
	cmp	word ptr [bp+si-64h],0h
	jz	05EEh

l11B8_05A9:
	call	far 1CD3h:181Eh
	mov	si,[bp-34h]
	shl	si,1h
	push	word ptr [bp+si-64h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	es,[54BAh]
	inc	word ptr es:[3748h]
	mov	ax,11h
	imul	word ptr [bp-34h]
	mov	bx,ax
	lea	ax,[bx+2FD7h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	si,[bp-3Ah]
	inc	word ptr [bp-3Ah]
	shl	si,1h
	mov	ax,[bp-34h]
	mov	[bp+si-28h],ax

l11B8_05EE:
	inc	word ptr [bp-34h]
	cmp	word ptr [bp-34h],10h
	jle	059Eh

l11B8_05F7:
	mov	es,[54BCh]
	mov	word ptr es:[0202h],2h
	mov	es,[54BEh]
	mov	ax,es:[374Eh]
	mov	es,[54BCh]
	mov	es:[0206h],ax
	mov	word ptr es:[0208h],0h
	mov	ax,1BD3h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54BAh]
	mov	word ptr es:[3748h],0h
	mov	es,[54BEh]
	mov	word ptr es:[374Eh],16h
	mov	ax,1C0Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	ax,17h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-34h],ax
	mov	es,[54BCh]
	mov	ax,es:[0206h]
	dec	ax
	cmp	ax,[bp-34h]
	jnz	0675h

l11B8_0672:
	jmp	073Fh

l11B8_0675:
	mov	es,[54B8h]
	cmp	word ptr es:[0D372h],0h
	jnz	068Dh

l11B8_0681:
	cmp	word ptr es:[0D370h],12Ch
	jnc	068Dh

l11B8_068A:
	jmp	0734h

l11B8_068D:
	sub	word ptr es:[0D370h],12Ch
	sbb	word ptr es:[0D372h],0h
	call	far 1631h:1FDFh
	mov	si,[bp-34h]
	shl	si,1h
	mov	ax,[bp+si-28h]
	mov	[bp-38h],ax
	mov	si,ax
	shl	si,1h
	dec	word ptr [bp+si-64h]
	add	word ptr [bp-38h],90h
	mov	word ptr [bp-3Ah],33h

l11B8_06BB:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	add	ax,[bp-3Ah]
	add	ax,0C724h
	mov	[bp-6Ch],ax
	mov	word ptr [bp-6Ah],3092h
	les	bx,[bp-6Ch]
	mov	al,es:[bx]
	sub	ah,ah
	cmp	ax,[bp-38h]
	jnz	06E6h

l11B8_06E2:
	and	byte ptr es:[bx],7Fh

l11B8_06E6:
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],55h
	jle	06BBh

l11B8_06EF:
	mov	word ptr [bp-2Ah],0h
	mov	word ptr [bp-3Ah],0h

l11B8_06F9:
	mov	si,[bp-3Ah]
	shl	si,1h
	cmp	word ptr [bp+si-64h],0h
	jz	0709h

l11B8_0704:
	mov	word ptr [bp-2Ah],1h

l11B8_0709:
	inc	word ptr [bp-3Ah]
	cmp	word ptr [bp-3Ah],10h
	jl	06F9h

l11B8_0712:
	cmp	word ptr [bp-2Ah],0h
	jnz	0744h

l11B8_0718:
	mov	es,[54BAh]
	mov	word ptr es:[3748h],0h
	mov	es,[54BEh]
	mov	word ptr es:[374Eh],12h
	mov	ax,1C19h
	jmp	0558h

l11B8_0734:
	mov	word ptr [bp-2Ah],0h
	mov	ax,1C35h
	jmp	0558h

l11B8_073F:
	mov	word ptr [bp-2Ah],0h

l11B8_0744:
	cmp	word ptr [bp-2Ah],0h
	jz	074Dh

l11B8_074A:
	jmp	056Ah

l11B8_074D:
	cmp	word ptr [bp-36h],0h
	jnz	0756h

l11B8_0753:
	jmp	0805h

l11B8_0756:
	call	far 1E56h:0388h
	mov	ax,1C4Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54B8h]
	cmp	word ptr es:[0D372h],0h
	jnz	077Dh

l11B8_0774:
	cmp	word ptr es:[0D370h],0C8h
	jc	07F3h

l11B8_077D:
	mov	ax,1C70h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1C97h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jz	0805h

l11B8_07A7:
	mov	ax,1CA7h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	es,[54B8h]
	mov	al,es:[si+0C78Eh]
	mov	es:[si+0C749h],al
	mov	al,es:[si+0C78Dh]
	mov	es:[si+0C748h],al
	sub	word ptr es:[0D370h],0C8h
	sbb	word ptr es:[0D372h],0h
	call	far 1631h:1FDFh
	jmp	0805h

l11B8_07F3:
	mov	ax,1CCEh

l11B8_07F6:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l11B8_0800:
	call	far 1F3Dh:0259h

l11B8_0805:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_080A: 11B8:080A
;;   Called from:
;;     1CD3:0CE8 (in fn1CD3_0004)
fn11B8_080A proc
	push	bp
	mov	bp,sp
	mov	ax,0Ah
	call	far 207Fh:2FDCh
	call	far 1E56h:0388h
	mov	ax,1D1Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1467h:0B98h
	mov	[bp-8h],ax
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	cmp	byte ptr es:[bx+0C7A0h],3h
	jnz	0868h

l11B8_0849:
	call	far 1E56h:0388h
	mov	ax,1D33h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54B8h]
	mov	byte ptr es:[0D31Eh],0h
	jmp	0921h

l11B8_0868:
	mov	byte ptr es:[0D31Eh],1h
	call	far 1E56h:0388h
	mov	es,[54BAh]
	mov	word ptr es:[3748h],0h
	mov	es,[54BEh]
	mov	word ptr es:[374Eh],16h
	mov	ax,1D82h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	es,[54BEh]
	sub	ax,ax
	mov	es:[374Eh],ax
	mov	es,[54BAh]
	mov	es:[3748h],ax
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	al,es:[bx+0C79Fh]
	sub	ah,ah
	mov	[bp-2h],ax
	cmp	ax,3h
	jle	08DCh

l11B8_08D5:
	mov	word ptr [bp-2h],8h
	jmp	08FAh

l11B8_08DC:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	cmp	byte ptr es:[bx+0C7A0h],1h
	jnz	08FAh

l11B8_08F6:
	add	word ptr [bp-2h],4h

l11B8_08FA:
	cmp	word ptr [bp-2h],7h
	jle	0905h

l11B8_0900:
	mov	word ptr [bp-2h],8h

l11B8_0905:
	mov	es,[54B8h]
	mov	al,[bp-2h]
	mov	es:[0D31Dh],al
	cbw
	mov	bx,ax
	shl	bx,1h
	mov	ax,[bx+1D8Ch]
	mov	es,[54C0h]
	mov	es:[0076h],ax

l11B8_0921:
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_0925: 11B8:0925
;;   Called from:
;;     1CD3:0CF0 (in fn1CD3_0004)
fn11B8_0925 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,1D9Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54C0h]
	push	word ptr es:[0076h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,1DC8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jnz	096Fh

l11B8_096C:
	jmp	0D53h

l11B8_096F:
	mov	es,[54C0h]
	mov	ax,es:[0076h]
	cwd
	mov	es,[54B8h]
	cmp	dx,es:[0D372h]
	jc	099Eh

l11B8_0983:
	ja	098Ch

l11B8_0985:
	cmp	ax,es:[0D370h]
	jbe	099Eh

l11B8_098C:
	call	far 1CD3h:181Eh
	call	far 1CD3h:181Eh
	call	far 1CD3h:1809h
	jmp	0D4Eh

l11B8_099E:
	mov	es,[54C0h]
	mov	ax,es:[0076h]
	cwd
	mov	es,[54B8h]
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	call	far 1631h:1FDFh
	mov	es,[54B8h]
	mov	al,es:[0D31Dh]
	cbw
	cmp	ax,7h
	jbe	09CBh

l11B8_09C8:
	jmp	0D41h

l11B8_09CB:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+0D31h]

l11B8_09D3:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	al,11h
	mov	es,[54B8h]
	mov	es:[si+0C765h],al
	mov	es:[si+0C757h],al
	mov	al,0FFh
	mov	es:[si+0C790h],al
	mov	es:[si+0C78Fh],al
	mov	es:[si+0C74Ch],al
	mov	es:[si+0C74Bh],al
	mov	byte ptr es:[si+0C7A0h],1h
	jmp	0D41h

l11B8_0A10:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	es,[54B8h]
	mov	byte ptr es:[si+0C773h],11h
	mov	al,0FFh
	mov	es:[si+0C790h],al
	mov	es:[si+0C74Ch],al
	mov	word ptr [bp-2h],11h

l11B8_0A39:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-2h]
	mov	bx,[bp-2h]
	mov	es,[54C2h]
	mov	al,es:[bx+2F0h]
	mov	es,[54B8h]
	mov	es:[si+0C724h],al
	mov	bx,[bp-2h]
	mov	es,[54C2h]
	mov	al,es:[bx+335h]
	mov	es,[54B8h]
	mov	es:[si+0C769h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],1Bh
	jle	0A39h

l11B8_0A7D:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	byte ptr es:[bx+0C7A0h],1h
	jmp	0D41h

l11B8_0A98:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	al,10h
	mov	es,[54B8h]
	mov	es:[si+0C767h],al
	mov	es:[si+0C766h],al
	mov	es:[si+0C758h],al
	mov	es:[si+0C757h],al
	mov	word ptr [bp-2h],0h
	jmp	0ACAh

l11B8_0AC7:
	inc	word ptr [bp-2h]

l11B8_0ACA:
	cmp	word ptr [bp-2h],4h
	jg	0A7Dh

l11B8_0AD0:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-2h]
	mov	al,0FFh
	mov	es,[54B8h]
	mov	es:[si+0C78Fh],al
	mov	es:[si+0C74Bh],al
	jmp	0AC7h

l11B8_0AF3:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	al,11h
	mov	es,[54B8h]
	mov	es:[si+0C76Eh],al
	mov	es:[si+0C765h],al
	mov	al,es:[si+0C74Dh]
	mov	es:[si+0C74Eh],al
	mov	al,es:[si+0C791h]
	mov	es:[si+0C792h],al
	mov	al,0FFh
	mov	es:[si+0C791h],al
	mov	es:[si+0C790h],al
	mov	es:[si+0C74Dh],al
	mov	es:[si+0C74Ch],al
	mov	word ptr [bp-2h],11h
	jmp	0B45h

l11B8_0B42:
	inc	word ptr [bp-2h]

l11B8_0B45:
	cmp	word ptr [bp-2h],1Bh
	jle	0B4Eh

l11B8_0B4B:
	jmp	0A7Dh

l11B8_0B4E:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-2h]
	mov	bx,[bp-2h]
	mov	al,[bx+1E13h]
	mov	es,[54B8h]
	mov	es:[si+0C769h],al
	mov	es:[si+0C724h],al
	jmp	0B42h

l11B8_0B76:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	es,[54B8h]
	mov	byte ptr es:[si+0C755h],7h
	mov	byte ptr es:[si+0C799h],0h
	mov	al,10h
	mov	es:[si+0C76Dh],al
	mov	es:[si+0C75Fh],al
	mov	al,0FFh
	mov	es:[si+0C793h],al
	mov	es:[si+0C792h],al
	mov	es:[si+0C74Fh],al
	mov	es:[si+0C74Eh],al

l11B8_0BB6:
	or	byte ptr es:[si+0C7A0h],2h
	jmp	0D41h

l11B8_0BBF:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	es,[54B8h]
	mov	byte ptr es:[si+0C756h],0h
	mov	al,11h
	mov	es:[si+0C777h],al
	mov	es:[si+0C757h],al
	mov	es:[si+0C779h],al
	mov	word ptr [bp-2h],0h

l11B8_0BED:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-2h]
	mov	al,0FFh
	mov	es,[54B8h]
	mov	es:[si+0C791h],al
	mov	es:[si+0C74Dh],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],3h
	jl	0BEDh

l11B8_0C17:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	or	byte ptr es:[bx+0C7A0h],2h
	jmp	0D41h

l11B8_0C32:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	byte ptr es:[bx+0C756h],0h
	mov	word ptr [bp-2h],11h

l11B8_0C4F:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-2h]
	mov	bx,[bp-2h]
	mov	es,[54C2h]
	mov	al,es:[bx+2F0h]
	mov	es,[54B8h]
	mov	es:[si+0C769h],al
	mov	es:[si+0C724h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],1Bh
	jle	0C4Fh

l11B8_0C83:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	mov	al,11h
	mov	es,[54B8h]
	mov	es:[si+0C778h],al
	mov	es:[si+0C777h],al
	mov	al,0FFh
	mov	es:[si+0C795h],al
	mov	es:[si+0C794h],al
	mov	es:[si+0C751h],al
	mov	es:[si+0C750h],al
	jmp	0BB6h

l11B8_0CBA:
	mov	word ptr [bp-2h],4Fh

l11B8_0CBF:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-2h]
	mov	es,[54B8h]
	mov	byte ptr es:[bx+0C724h],10h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],55h
	jl	0CBFh

l11B8_0CE3:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	byte ptr es:[bx+0C779h],11h
	mov	word ptr [bp-2h],0h
	jmp	0D05h

l11B8_0D02:
	inc	word ptr [bp-2h]

l11B8_0D05:
	cmp	word ptr [bp-2h],0Ah
	jl	0D0Eh

l11B8_0D0B:
	jmp	0C17h

l11B8_0D0E:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-2h]
	mov	al,0FFh
	mov	es,[54B8h]
	mov	es:[si+0C78Fh],al
	mov	es:[si+0C74Bh],al
	jmp	0D02h
l11B8_0D31	dw	0x09D3
l11B8_0D33	dw	0x0A10
l11B8_0D35	dw	0x0A98
l11B8_0D37	dw	0x0AF3
l11B8_0D39	dw	0x0B76
l11B8_0D3B	dw	0x0BBF
l11B8_0D3D	dw	0x0C32
l11B8_0D3F	dw	0x0CBA

l11B8_0D41:
	mov	ax,1DEEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l11B8_0D4E:
	call	far 1F3Dh:0259h

l11B8_0D53:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_0D58: 11B8:0D58
;;   Called from:
;;     0FDC:04DA (in fn0FDC_01C0)
fn11B8_0D58 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0h
	jmp	0E32h

l11B8_0D6C:
	mov	ax,1E56h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	al,7Dh
	imul	byte ptr es:[bx+0C620h]
	mov	bx,ax
	mov	al,11h
	mul	byte ptr es:[bx+0C79Dh]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[54C8h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1E70h

l11B8_0DBC:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:4CACh
	add	sp,2h
	mov	es,[54CAh]
	cmp	word ptr es:[3938h],0h
	jnz	0DEEh

l11B8_0DDE:
	jmp	0DE5h

l11B8_0DE0:
	call	far 207Fh:0BC0h

l11B8_0DE5:
	call	far 1F3Dh:002Fh
	or	ax,ax
	jz	0DE0h

l11B8_0DEE:
	call	far 0800h:2A2Bh
	call	far 1F3Dh:0259h
	mov	es,[54B8h]
	cmp	byte ptr es:[0D332h],0h
	jnz	0E2Ah

l11B8_0E04:
	call	far 207Fh:0BC0h
	test	al,1h
	jz	0E2Ah

l11B8_0E0D:
	mov	es,[54B8h]
	mov	al,[bp-2h]
	mov	es:[0D331h],al
	mov	byte ptr es:[0D332h],1h
	mov	byte ptr es:[0D333h],1h
	mov	byte ptr es:[0D330h],1Fh

l11B8_0E2A:
	mov	word ptr [bp-2h],8h

l11B8_0E2F:
	inc	word ptr [bp-2h]

l11B8_0E32:
	cmp	word ptr [bp-2h],8h
	jl	0E3Bh

l11B8_0E38:
	jmp	101Ch

l11B8_0E3B:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jnz	0E2Fh

l11B8_0E4F:
	mov	cx,187h
	mov	al,es:[0D456h]
	cbw
	imul	cx
	cwd
	mov	es,[54C4h]
	mov	es:[4FC0h],ax
	mov	es:[4FC2h],dx
	mov	es,[54B8h]
	mov	al,es:[0D456h]
	inc	byte ptr es:[0D456h]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es:[bx+0C614h],cl
	cmp	byte ptr es:[0D456h],0Ah
	jl	0E91h

l11B8_0E8B:
	mov	byte ptr es:[0D456h],2h

l11B8_0E91:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	si,ax
	sub	al,al
	mov	es:[si+0C624h],al
	mov	es:[si+0C622h],al
	mov	es:[si+0C621h],al
	mov	es:[si+0C61Fh],al
	call	far 0800h:19DDh
	mov	es,[54B8h]
	mov	es:[si+0C615h],al
	call	far 0800h:19DDh
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	es:[bx+0C616h],cl
	call	far 0800h:19DDh
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	es:[bx+0C617h],cl
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	mov	es:[si+0C623h],al
	mov	bx,[bp-2h]
	mov	es,[54C6h]
	mov	byte ptr es:[bx+0D562h],0h
	mov	es,[54B8h]
	mov	byte ptr es:[si+0C620h],8h
	mov	word ptr [bp-4h],0h

l11B8_0F1D:
	call	far 207Fh:0BC0h
	and	al,1h
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-4h]
	mov	es,[54B8h]
	mov	es:[bx+0C618h],cl
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],6h
	jle	0F1Dh

l11B8_0F43:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	byte ptr es:[si+0C61Ch],0h
	mov	bx,[bp+6h]
	add	bx,si
	mov	byte ptr es:[bx+0C618h],3h
	cmp	word ptr [bp+6h],4h
	jnz	0F6Eh

l11B8_0F62:
	mov	al,es:[si+0C615h]
	shl	al,1h
	sub	es:[si+0C623h],al

l11B8_0F6E:
	mov	word ptr [bp-4h],0h

l11B8_0F73:
	mov	ax,7Dh
	imul	word ptr [bp-4h]
	mov	si,ax
	mov	es,[54B8h]
	cmp	byte ptr es:[si+0C724h],0FFh
	jz	0FAEh

l11B8_0F87:
	cmp	byte ptr es:[si+0C79Eh],0FFh
	jnz	0FAEh

l11B8_0F8F:
	mov	al,[bp-2h]
	mov	es:[si+0C79Eh],al
	mov	al,[bp-4h]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es:[bx+0C620h],cl
	mov	word ptr [bp-4h],8h

l11B8_0FAE:
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],4h
	jl	0F73h

l11B8_0FB7:
	mov	ax,1E2Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[54C8h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1E3Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	cmp	byte ptr es:[bx+0C620h],8h
	jz	1016h

l11B8_1013:
	jmp	0D6Ch

l11B8_1016:
	mov	ax,1E4Dh
	jmp	0DBCh

l11B8_101C:
	mov	es,[54CCh]
	mov	si,es:[4584h]
	shl	si,1h
	mov	es,[54CEh]
	mov	ax,es:[si+39B4h]
	mov	es,[54D0h]
	mov	es:[0A44Bh],ax
	mov	es,[54D2h]
	mov	ax,es:[si+39D4h]
	mov	es,[54D4h]
	mov	es:[0A44Dh],ax
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_104E: 11B8:104E
;;   Called from:
;;     1CD3:0ED2 (in fn1CD3_0004)
fn11B8_104E proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[54D0h]
	mov	word ptr es:[0A44Bh],0A69h
	mov	es,[54D4h]
	mov	word ptr es:[0A44Dh],805Eh
	mov	es,[54B8h]
	mov	al,es:[0D456h]
	inc	byte ptr es:[0D456h]
	mov	es:[0C625h],al
	mov	byte ptr es:[0C630h],7h
	mov	byte ptr es:[0C626h],0Ch
	mov	byte ptr es:[0C627h],9h
	mov	byte ptr es:[0C628h],8h
	mov	byte ptr es:[0C634h],78h
	sub	al,al
	mov	es:[0C635h],al
	mov	es:[0C633h],al
	mov	es:[0C632h],al
	mov	es,[54C6h]
	mov	es:[0D563h],al
	mov	es,[54B8h]
	mov	byte ptr es:[0C631h],8h
	mov	word ptr [bp-0Ah],0h

l11B8_10C5:
	mov	bx,[bp-0Ah]
	mov	al,[bx+1E7Ah]
	mov	es:[bx+0C629h],al
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],6h
	jle	10C5h

l11B8_10DA:
	mov	word ptr [bp-0Eh],0h
	jmp	10E4h

l11B8_10E1:
	inc	word ptr [bp-0Eh]

l11B8_10E4:
	cmp	word ptr [bp-0Eh],4h
	jge	10F5h

l11B8_10EA:
	mov	bx,[bp-0Eh]
	cmp	byte ptr es:[bx+0D452h],0FFh
	jnz	10E1h

l11B8_10F5:
	mov	word ptr [bp-0Ah],0h

l11B8_10FA:
	mov	bx,[bp-0Ah]
	mov	es,[54D6h]
	mov	al,es:[bx+467h]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	bx,ax
	add	bx,[bp-0Ah]
	mov	es,[54B8h]
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],7Dh
	jl	10FAh

l11B8_1125:
	mov	bx,[bp-0Eh]
	mov	byte ptr es:[bx+0D452h],43h
	mov	ax,7Dh
	imul	word ptr [bp-0Eh]
	mov	si,ax
	mov	byte ptr es:[si+0C724h],0FFh
	mov	byte ptr es:[si+0C79Dh],1h
	mov	bx,[bp-0Eh]
	mov	es,[54C6h]
	mov	byte ptr es:[bx+0D55Eh],92h
	mov	word ptr [bp-6h],0h

l11B8_1154:
	mov	si,[bp-6h]
	shl	si,1h
	mov	ax,1Ah
	imul	word ptr [bp-6h]
	mov	di,ax
	mov	es,[54D8h]
	mov	ax,es:[si+4024h]
	mov	es,[54B8h]
	mov	es:[di+0D390h],ax
	mov	es,[54DAh]
	mov	ax,es:[si+4056h]
	mov	es,[54B8h]
	mov	es:[di+0D392h],ax
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],8h
	jl	1154h

l11B8_118E:
	mov	word ptr [bp-6h],0h

l11B8_1193:
	mov	ax,7Dh
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C918h],0FFh
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],4h
	jl	1193h

l11B8_11AA:
	mov	word ptr [bp-6h],8h

l11B8_11AF:
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C614h],0FFh
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],10h
	jl	11AFh

l11B8_11C6:
	mov	word ptr [bp-6h],0h

l11B8_11CB:
	mov	si,[bp-6h]
	shl	si,1h
	sub	ax,ax
	mov	es,[54DCh]
	mov	es:[si+393Ch],ax
	mov	es,[54DEh]
	mov	es:[si+406Ah],ax
	mov	ax,0FFFFh
	mov	es,[54DAh]
	mov	es:[si+4036h],ax
	mov	es,[54D8h]
	mov	es:[si+4004h],ax
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],18h
	jl	11CBh

l11B8_1202:
	mov	es,[54DEh]
	mov	ax,1h
	mov	es:[4074h],ax
	mov	es:[4072h],ax
	mov	es,[54E0h]
	sub	al,al
	mov	es:[3999h],al
	mov	es:[3998h],al
	call	far 207Fh:0BC0h
	and	ax,1h
	add	ax,0A72h
	mov	[bp-8h],ax
	call	far 207Fh:0BC0h
	and	ax,1h
	add	ax,805Dh
	mov	[bp-0Ch],ax
	mov	word ptr [bp-4h],8h
	call	far 207Fh:0BC0h
	and	ax,3h
	add	ax,0Ah
	mov	[bp-2h],ax
	mov	ax,[bp-4h]
	mov	[bp-6h],ax
	jmp	1362h

l11B8_1257:
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	si,ax
	mov	es,[54B8h]
	mov	byte ptr es:[si+0C614h],0h
	mov	byte ptr es:[si+0C620h],8h
	mov	bx,[bp-6h]
	mov	es,[54C6h]
	mov	byte ptr es:[bx+0D566h],0FEh
	mov	bx,[bp-6h]
	mov	es,[54E2h]
	mov	byte ptr es:[bx+40A2h],1Ch
	mov	bx,[bp-6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[54E4h]
	mov	word ptr es:[bx+216h],2E0h
	mov	word ptr es:[bx+218h],2FE8h
	mov	al,6h
	mov	bx,[bp-6h]
	mov	es,[54E6h]
	mov	es:[bx+3928h],al
	mov	bx,[bp-6h]
	mov	es,[54E8h]
	mov	es:[bx+3974h],al
	mov	si,[bp-6h]
	shl	si,1h
	mov	es,[54DEh]
	mov	word ptr es:[si+407Ah],1h
	mov	bx,[bp-6h]
	mov	al,[bx+1E7Ah]
	cbw
	add	ax,[bp-8h]
	mov	es,[54D8h]
	mov	es:[si+4014h],ax
	mov	bx,[bp-6h]
	mov	al,[bx+1E82h]
	cbw
	add	ax,[bp-0Ch]
	mov	es,[54DAh]
	mov	es:[si+4046h],ax
	mov	word ptr [bp-0Ah],0h

l11B8_12F9:
	call	far 207Fh:0BC0h
	and	al,1h
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	add	bx,[bp-0Ah]
	mov	es,[54B8h]
	mov	es:[bx+0C618h],cl
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],5h
	jle	12F9h

l11B8_131F:
	call	far 0800h:19DDh
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	es:[bx+0C615h],cl
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	si,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	mov	es:[si+0C623h],al
	call	far 207Fh:0BC0h
	cwd
	mov	cx,8h
	idiv	cx
	mov	es,[54B8h]
	mov	es:[si+0C61Fh],dl
	inc	word ptr [bp-6h]

l11B8_1362:
	mov	ax,[bp-2h]
	cmp	[bp-6h],ax
	jge	136Dh

l11B8_136A:
	jmp	1257h

l11B8_136D:
	mov	ax,0FFFFh
	push	ax
	call	far 183Bh:000Ah
	add	sp,2h
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_137F: 11B8:137F
;;   Called from:
;;     1CD3:10D9 (in fn1CD3_0004)
fn11B8_137F proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	call	far 207Fh:0BC0h
	and	ax,3h
	mov	es,[54EAh]
	mov	es:[0010h],ax
	cmp	ax,1h
	jz	13ACh

l11B8_139F:
	cmp	ax,2h
	jz	13D5h

l11B8_13A4:
	cmp	ax,3h
	jz	1415h

l11B8_13A9:
	jmp	143Dh

l11B8_13AC:
	mov	es,[54ECh]
	mov	byte ptr es:[1C8Fh],6Fh
	mov	word ptr [bp-2h],0h

l11B8_13BB:
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+1C90h],6Ah
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],5h
	jl	13BBh

l11B8_13CD:
	mov	byte ptr es:[1CCDh],70h
	jmp	143Dh

l11B8_13D5:
	mov	es,[54ECh]
	mov	byte ptr es:[1A78h],6Fh
	mov	word ptr [bp-2h],0h

l11B8_13E4:
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+1A79h],6Ah
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],4h
	jl	13E4h

l11B8_13F6:
	mov	word ptr [bp-2h],0h

l11B8_13FB:
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+1AB5h],6Ah
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],6h
	jl	13FBh

l11B8_140D:
	mov	byte ptr es:[1ABBh],70h
	jmp	143Dh

l11B8_1415:
	mov	es,[54ECh]
	mov	byte ptr es:[1AD9h],71h
	mov	word ptr [bp-2h],4h

l11B8_1424:
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+1C9Dh],6Bh
	add	word ptr [bp-2h],8h
	cmp	word ptr [bp-2h],3Ch
	jl	1424h

l11B8_1437:
	mov	byte ptr es:[1CD9h],70h

l11B8_143D:
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_1441: 11B8:1441
;;   Called from:
;;     1CD3:114B (in fn1CD3_0004)
fn11B8_1441 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	es,[54EAh]
	mov	ax,es:[0010h]
	cmp	ax,1h
	jz	1469h

l11B8_1459:
	cmp	ax,2h
	jz	149Fh

l11B8_145E:
	cmp	ax,3h
	jnz	1466h

l11B8_1463:
	jmp	14F7h

l11B8_1466:
	jmp	152Bh

l11B8_1469:
	mov	es,[54ECh]
	mov	byte ptr es:[1C8Fh],43h
	mov	word ptr [bp-2h],0h

l11B8_1478:
	call	far 207Fh:0BC0h
	and	al,3h
	add	al,40h
	mov	bx,[bp-2h]
	mov	es,[54ECh]
	mov	es:[bx+1C90h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],5h
	jl	1478h

l11B8_1496:
	mov	byte ptr es:[1CCDh],42h
	jmp	152Bh

l11B8_149F:
	mov	es,[54ECh]
	mov	byte ptr es:[1A78h],41h
	mov	word ptr [bp-2h],0h

l11B8_14AE:
	call	far 207Fh:0BC0h
	and	al,3h
	add	al,40h
	mov	bx,[bp-2h]
	mov	es,[54ECh]
	mov	es:[bx+1A79h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],4h
	jl	14AEh

l11B8_14CC:
	mov	word ptr [bp-2h],0h

l11B8_14D1:
	call	far 207Fh:0BC0h
	and	al,3h
	add	al,40h
	mov	bx,[bp-2h]
	mov	es,[54ECh]
	mov	es:[bx+1AB5h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],6h
	jl	14D1h

l11B8_14EF:
	mov	byte ptr es:[1ABBh],42h
	jmp	152Bh

l11B8_14F7:
	mov	es,[54ECh]
	mov	byte ptr es:[1AD9h],40h
	mov	word ptr [bp-2h],4h

l11B8_1506:
	call	far 207Fh:0BC0h
	and	al,3h
	add	al,40h
	mov	bx,[bp-2h]
	mov	es,[54ECh]
	mov	es:[bx+1C9Dh],al
	add	word ptr [bp-2h],8h
	cmp	word ptr [bp-2h],3Ch
	jl	1506h

l11B8_1525:
	mov	byte ptr es:[1CD9h],41h

l11B8_152B:
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_152F: 11B8:152F
;;   Called from:
;;     1CD3:13EC (in fn1CD3_0004)
fn11B8_152F proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-2h],1h

l11B8_153F:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	al,es:[bx+0C614h]
	mov	bx,[bp-2h]
	mov	es,[54EEh]
	mov	es:[bx+3FE9h],al
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	byte ptr es:[bx+0C614h],0FFh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jl	153Fh

l11B8_1577:
	mov	word ptr [bp-2h],0h

l11B8_157C:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	mov	al,es:[bx+0C724h]
	mov	bx,[bp-2h]
	mov	es:[bx+0D452h],al
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C724h],0FFh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],4h
	jl	157Ch

l11B8_15AC:
	mov	es,[54D0h]
	mov	word ptr es:[0A44Bh],0D10h
	mov	es,[54D4h]
	mov	word ptr es:[0A44Dh],7024h
	mov	es,[54B8h]
	mov	byte ptr es:[0C620h],8h
	mov	ax,9h
	push	ax
	call	far 0FDCh:0629h
	add	sp,2h
	mov	es,[54D0h]
	mov	word ptr es:[0A44Bh],0D00h
	mov	es,[54D4h]
	mov	word ptr es:[0A44Dh],7014h
	mov	word ptr [bp-2h],1h

l11B8_15F3:
	mov	bx,[bp-2h]
	mov	es,[54EEh]
	mov	al,es:[bx+3FE9h]
	mov	cx,ax
	mov	ax,11h
	imul	bx
	mov	bx,ax
	mov	es,[54B8h]
	mov	es:[bx+0C614h],cl
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jl	15F3h

l11B8_161A:
	mov	word ptr [bp-2h],0h

l11B8_161F:
	mov	bx,[bp-2h]
	mov	es,[54B8h]
	mov	al,es:[bx+0D452h]
	mov	cx,ax
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	mov	es:[bx+0C724h],cl
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+0D452h],0FFh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],4h
	jl	161Fh

l11B8_164B:
	mov	es,[54F0h]
	cmp	word ptr es:[014Ah],0h
	jz	16AEh

l11B8_1657:
	mov	word ptr [bp-2h],0h

l11B8_165C:
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[54B8h]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jnz	16A5h

l11B8_1670:
	mov	word ptr [bp-4h],0h

l11B8_1675:
	mov	bx,[bp-4h]
	mov	es,[54F2h]
	mov	al,es:[bx+3EAh]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-2h]
	mov	bx,ax
	add	bx,[bp-4h]
	mov	es,[54B8h]
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],7Dh
	jl	1675h

l11B8_16A0:
	mov	word ptr [bp-2h],5h

l11B8_16A5:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],4h
	jl	165Ch

l11B8_16AE:
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_16B2: 11B8:16B2
;;   Called from:
;;     0FDC:0B0D (in fn0FDC_0629)
fn11B8_16B2 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	ax,1h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	ax,3E80h
	push	ax
	mov	ax,42C3h
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,1E92h
	push	ds
	push	ax
	call	far 1F3Dh:0814h
	add	sp,0Ah
	mov	word ptr [bp-2h],0h

l11B8_16E7:
	mov	bx,[bp-2h]
	mov	es,[54F4h]
	mov	byte ptr es:[bx+244Bh],0h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],1E78h
	jl	16E7h

l11B8_16FE:
	mov	es,[54F6h]
	mov	word ptr es:[0E48Ah],0h
	mov	es,[54F8h]
	mov	word ptr es:[0064h],42F6h
	mov	word ptr es:[0066h],246Ch

l11B8_171B:
	call	far 0800h:1AFDh
	mov	es,[54F6h]
	mov	bx,es:[0E48Ah]
	mov	es,[54F4h]
	cmp	byte ptr es:[bx+42C3h],49h
	jl	171Bh

l11B8_1735:
	mov	ax,0Eh
	push	ax
	call	far 0800h:19BFh
	add	sp,2h
	mov	ax,3Ch
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	sp,bp
	pop	bp
	retf

;; fn11B8_1762: 11B8:1762
;;   Called from:
;;     1CD3:0CE0 (in fn1CD3_0004)
fn11B8_1762 proc
	push	bp
	mov	bp,sp
	mov	ax,24h
	call	far 207Fh:2FDCh
	push	di
	push	si
	call	far 1E56h:0388h
	mov	ax,1E99h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1467h:0B98h
	mov	[bp-10h],ax
	mov	word ptr [bp-8h],0h
	mov	word ptr [bp-0Ch],33h
	mov	word ptr [bp-12h],0h

l11B8_1798:
	mov	si,[bp-12h]
	mov	byte ptr [bp+si-20h],0h
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],0Ah
	jl	1798h

l11B8_17A8:
	mov	word ptr [bp-12h],0h
	jmp	17B2h

l11B8_17AF:
	inc	word ptr [bp-12h]

l11B8_17B2:
	cmp	word ptr [bp-12h],0Ah
	jge	1814h

l11B8_17B8:
	mov	word ptr [bp-16h],0h

l11B8_17BD:
	cmp	word ptr [bp-16h],0h
	jnz	17AFh

l11B8_17C3:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-0Ch]
	mov	es,[54B8h]
	mov	al,es:[bx+0C724h]
	mov	[bp-24h],al
	sub	ah,ah
	and	ax,7Fh
	mov	[bp-22h],ax
	cmp	ax,10h
	jl	1800h

l11B8_17ED:
	cmp	ax,20h
	jg	1800h

l11B8_17F2:
	mov	word ptr [bp-16h],1h
	mov	si,[bp-12h]
	mov	al,[bp-24h]
	mov	[bp+si-20h],al

l11B8_1800:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],56h
	jl	17BDh

l11B8_1809:
	mov	ax,0Ah
	mov	[bp-12h],ax
	mov	[bp-16h],ax
	jmp	17BDh

l11B8_1814:
	sub	ax,ax
	mov	[bp-0Ah],ax
	mov	[bp-16h],ax
	mov	[bp-12h],ax

l11B8_181F:
	mov	si,[bp-12h]
	cmp	byte ptr [bp+si-20h],18h
	jz	182Eh

l11B8_1828:
	cmp	byte ptr [bp+si-20h],1Ah
	jl	1833h

l11B8_182E:
	mov	word ptr [bp-16h],1h

l11B8_1833:
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],0Ah
	jl	181Fh

l11B8_183C:
	mov	word ptr [bp-12h],0h

l11B8_1841:
	mov	si,[bp-12h]
	test	byte ptr [bp+si-20h],80h
	jz	184Fh

l11B8_184A:
	mov	word ptr [bp-0Ah],1h

l11B8_184F:
	inc	word ptr [bp-12h]
	cmp	word ptr [bp-12h],0Ah
	jl	1841h

l11B8_1858:
	cmp	word ptr [bp-16h],0h
	jnz	1861h

l11B8_185E:
	jmp	1A1Eh

l11B8_1861:
	mov	word ptr [bp-12h],0h
	jmp	19A0h

l11B8_1869:
	mov	ax,1ED1h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-12h]
	mov	es,[54B8h]
	mov	al,es:[si+0C78Fh]
	sub	ah,ah
	mov	cl,es:[si+0C74Bh]
	sub	ch,ch
	sub	ax,cx
	mov	[bp-6h],ax
	call	far 0800h:28A2h
	push	word ptr [bp-6h]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,1EFFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:28A2h
	mov	word ptr [bp-0Eh],2h
	mov	di,[bp-12h]
	cmp	byte ptr [bp+di-20h],18h
	jz	18DCh

l11B8_18CE:
	mov	al,[bp+di-20h]
	cbw
	mov	bx,ax
	mov	al,[bx+2046h]
	cbw
	mov	[bp-0Eh],ax

l11B8_18DC:
	push	word ptr [bp-0Eh]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,1F19h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1543h:0CDEh
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	or	ax,dx
	jnz	1906h

l11B8_1903:
	jmp	199Dh

l11B8_1906:
	mov	ax,[bp-6h]
	cwd
	cmp	dx,[bp-2h]
	jg	192Ah

l11B8_190F:
	jl	1916h

l11B8_1911:
	cmp	ax,[bp-4h]
	jnc	192Ah

l11B8_1916:
	mov	ax,1F49h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	197Ah

l11B8_192A:
	mov	ax,[bp-4h]
	mov	[bp-6h],ax
	jmp	197Ah

l11B8_1932:
	mov	ax,[bp-0Eh]
	cwd
	mov	es,[54B8h]
	cmp	dx,es:[0D372h]
	ja	1980h

l11B8_1941:
	jc	194Ah

l11B8_1943:
	cmp	ax,es:[0D370h]
	ja	1980h

l11B8_194A:
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	bx,ax
	add	bx,[bp-12h]
	mov	es,[54B8h]
	inc	byte ptr es:[bx+0C74Bh]
	mov	ax,[bp-0Eh]
	cwd
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	dec	word ptr [bp-6h]
	call	far 1631h:1FDFh

l11B8_197A:
	cmp	word ptr [bp-6h],0h
	jnz	1932h

l11B8_1980:
	cmp	word ptr [bp-6h],0h
	jz	1998h

l11B8_1986:
	mov	ax,1F94h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h

l11B8_1998:
	call	far 1631h:1FDFh

l11B8_199D:
	inc	word ptr [bp-12h]

l11B8_19A0:
	cmp	word ptr [bp-12h],0Ah
	jl	19A9h

l11B8_19A6:
	jmp	1A36h

l11B8_19A9:
	mov	si,[bp-12h]
	cmp	byte ptr [bp+si-20h],18h
	jz	19B8h

l11B8_19B2:
	cmp	byte ptr [bp+si-20h],1Ah
	jl	199Dh

l11B8_19B8:
	call	far 1E56h:0388h
	mov	ax,1EA8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	di,[bp-12h]
	mov	al,11h
	imul	byte ptr [bp+di-20h]
	mov	bx,ax
	lea	ax,[bx+2EC7h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[54B6h]
	mov	ax,7Dh
	imul	word ptr es:[0068h]
	mov	si,ax
	add	si,[bp-12h]
	mov	es,[54B8h]
	mov	al,es:[si+0C78Fh]
	cmp	es:[si+0C74Bh],al
	jz	1A09h

l11B8_1A06:
	jmp	1869h

l11B8_1A09:
	mov	ax,1EAEh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	199Dh

l11B8_1A1E:
	mov	ax,1FC9h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	cmp	word ptr [bp-0Ah],0h
	jnz	1A36h

l11B8_1A31:
	call	far 1F3Dh:0259h

l11B8_1A36:
	cmp	word ptr [bp-0Ah],0h
	jz	1A4Eh

l11B8_1A3C:
	mov	ax,2008h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h

l11B8_1A4E:
	pop	si
	pop	di
