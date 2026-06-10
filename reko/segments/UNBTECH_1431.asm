;;; Segment 1431 (1431:0000)
1431:0000 03                                              .               

l135D_0D41:
	jmp	0CACh

l135D_0D44:
	pop	si
	mov	sp,bp
	pop	bp
	retf
135D:0D49                            90                            .      

;; fn1431_000A: 1431:000A
;;   Called from:
;;     0800:2D75 (in fn0800_2C50)
;;     183B:12B5 (in fn183B_000A)
;;     1CD3:0D87 (in fn1CD3_0004)
;;     1CD3:0DBA (in fn1CD3_0004)
fn1431_000A proc
	push	bp
	mov	bp,sp
	mov	ax,1Ah
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[5522h]
	cmp	byte ptr es:[0D335h],0h
	jz	0026h

l1431_0023:
	jmp	02FBh

l1431_0026:
	sub	ax,ax
	mov	[bp-0Eh],ax
	mov	[bp-0Ch],ax
	mov	[bp-6h],ax
	mov	[bp-16h],ax

l1431_0034:
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	si,ax
	mov	es,[5522h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	005Eh

l1431_0048:
	mov	al,es:[si+0C61Eh]
	cbw
	mov	di,ax
	cmp	[bp-0Ch],di
	jge	005Eh

l1431_0055:
	mov	ax,[bp-16h]
	mov	[bp-6h],ax
	mov	[bp-0Ch],di

l1431_005E:
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],8h
	jl	0034h

l1431_0067:
	mov	ax,17h
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	es,[5522h]
	cmp	byte ptr es:[0D325h],0h
	jnz	0082h

l1431_007F:
	jmp	02DCh

l1431_0082:
	mov	ax,1h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,1h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	call	far 1E56h:0388h
	mov	word ptr [bp-8h],1h
	mov	es,[5522h]
	cmp	byte ptr es:[0D450h],0h
	jz	00B3h

l1431_00B0:
	inc	word ptr [bp-8h]

l1431_00B3:
	cmp	word ptr [bp-0Ch],3h
	jl	00C6h

l1431_00B9:
	cmp	byte ptr es:[0D451h],0h
	jz	00C6h

l1431_00C1:
	mov	word ptr [bp-8h],3h

l1431_00C6:
	cmp	word ptr [bp+6h],0h
	jz	00F1h

l1431_00CC:
	mov	word ptr [bp-8h],2h
	cmp	word ptr [bp+6h],2h
	jle	00DCh

l1431_00D7:
	mov	word ptr [bp-8h],4h

l1431_00DC:
	mov	ax,252Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp+6h]
	mov	[bp-0Ch],ax
	jmp	011Fh

l1431_00F1:
	mov	ax,11h
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	es,[5522h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5524h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h

l1431_011F:
	cmp	word ptr [bp-0Ch],0h
	jz	018Eh

l1431_0125:
	mov	ax,2538h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-0Ch],5h
	jge	0160h

l1431_0138:
	cmp	word ptr [bp-0Ch],3h
	jge	014Fh

l1431_013E:
	mov	bx,[bp-0Ch]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+25E0h]
	push	word ptr [bx+25DEh]
	jmp	0168h

l1431_014F:
	mov	bx,[bp-0Ch]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+25DCh]
	push	word ptr [bx+25DAh]
	jmp	0168h

l1431_0160:
	push	word ptr [25F0h]
	push	word ptr [25EEh]

l1431_0168:
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2543h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-8h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+25F0h]
	push	word ptr [bx+25EEh]
	jmp	0193h

l1431_018E:
	mov	ax,2553h
	push	ds
	push	ax

l1431_0193:
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,256Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:28A2h
	mov	word ptr [bp-16h],0h
	jmp	020Ah

l1431_01B4:
	call	far 0800h:19F3h
	add	[bp-2h],ax

l1431_01BC:
	mov	ax,[bp-0Ah]
	dec	word ptr [bp-0Ah]
	or	ax,ax
	jnz	01B4h

l1431_01C6:
	mov	ax,[bp-12h]
	imul	word ptr [bp-2h]
	mov	[bp-2h],ax
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	bx,ax
	mov	es,[5522h]
	mov	al,es:[bx+0C623h]
	cbw
	mov	[bp-10h],ax
	mov	ax,[bp-2h]
	add	[bp-10h],ax
	mov	ax,[bp-1Ah]
	cmp	[bp-10h],ax
	jle	01F5h

l1431_01F2:
	mov	[bp-10h],ax

l1431_01F5:
	mov	al,[bp-10h]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	bx,ax
	mov	es:[bx+0C623h],cl

l1431_0207:
	inc	word ptr [bp-16h]

l1431_020A:
	cmp	word ptr [bp-16h],8h
	jl	0213h

l1431_0210:
	jmp	02AFh

l1431_0213:
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	si,ax
	mov	es,[5522h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	0207h

l1431_0227:
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	mov	[bp-1Ah],ax
	mov	al,es:[si+0C623h]
	cbw
	cmp	ax,[bp-1Ah]
	jz	0207h

l1431_023C:
	call	far 1CD3h:181Eh
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	bx,ax
	mov	es,[5522h]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[5524h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,2587h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	di,[bp-0Ch]
	shl	di,1h
	shl	di,1h
	mov	bx,[bp-8h]
	mov	al,[bx+di+2601h]
	cbw
	mov	[bp-0Ah],ax
	mov	word ptr [bp-12h],1h
	test	byte ptr [bp-0Ah],0F0h
	jz	02A7h

l1431_0299:
	mov	cl,4h
	sar	ax,cl
	and	ax,0Fh
	mov	[bp-12h],ax
	and	word ptr [bp-0Ah],0Fh

l1431_02A7:
	mov	word ptr [bp-2h],0h
	jmp	01BCh

l1431_02AF:
	mov	es,[5526h]
	mov	word ptr es:[37FEh],0Fh
	call	far 1F3Dh:086Ah
	call	far 0800h:2A4Fh
	sub	ax,ax
	push	ax
	call	far 0800h:4CACh
	add	sp,2h
	mov	es,[5522h]
	mov	byte ptr es:[0D335h],3Fh
	jmp	035Ch

l1431_02DC:
	cmp	word ptr [bp+6h],0h
	jnz	035Ch

l1431_02E2:
	call	far 1CD3h:17C6h
	mov	ax,2591h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:2A2Bh
	jmp	0357h

l1431_02FB:
	call	far 1CD3h:17C6h
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-16h],0h

l1431_030A:
	mov	ax,11h
	imul	word ptr [bp-16h]
	mov	si,ax
	mov	es,[5522h]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	0336h

l1431_031E:
	mov	al,es:[si+0C623h]
	cbw
	mov	cx,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	cmp	ax,cx
	jz	0336h

l1431_0331:
	mov	word ptr [bp-2h],1h

l1431_0336:
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],8h
	jl	030Ah

l1431_033F:
	cmp	word ptr [bp-2h],0h
	jz	034Ah

l1431_0345:
	mov	ax,25A4h
	jmp	034Dh

l1431_034A:
	mov	ax,25CFh

l1431_034D:
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h

l1431_0357:
	call	far 1F3Dh:0259h

l1431_035C:
	pop	si
	pop	di
	mov	sp,bp
