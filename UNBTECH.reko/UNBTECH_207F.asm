;;; Segment 207F (207F:0000)
207F:0000 35 86 01 74 03                                  5..t.           

l204B_0345:
	xor	ax,ax
	retf

l204B_0348:
	mov	ax,1h
	retf
204B:034C                                     00 00 00 00             ....
204B:0350 00 00 00 00 00 00 00 00 00 00 00 00             ............    

;; fn207F_001C: 207F:001C
;;   Called from:
;;     1FC5:0475 (in fn1FC5_046E)
fn207F_001C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	al,0B6h
	out	43h,al
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0030: 207F:0030
;;   Called from:
;;     1FC5:04AD (in fn1FC5_047B)
;;     1FC5:0720 (in fn1FC5_06F6)
fn207F_0030 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	bx,[bp+6h]
	mov	ax,bx
	out	42h,al
	mov	al,ah
	out	42h,al
	in	al,61h
	or	al,3h
	out	61h,al
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0051: 207F:0051
;;   Called from:
;;     1FC5:04EB (in fn1FC5_04E4)
fn207F_0051 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	in	al,61h
	and	al,0FCh
	out	61h,al
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0067: 207F:0067
;;   Called from:
;;     1FC5:0528 (in fn1FC5_04F1)
;;     1FC5:05D1 (in fn1FC5_059A)
fn207F_0067 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	in	al,61h
	and	al,0FCh
	out	61h,al
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_007D: 207F:007D
;;   Called from:
;;     1FC5:0587 (in fn1FC5_04F1)
;;     1FC5:0630 (in fn1FC5_059A)
fn207F_007D proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[0252h],ax
	in	al,61h
	xor	al,2h
	out	61h,al
	mov	dx,[0252h]
	add	dx,9248h
	mov	cl,3h
	ror	dx,cl
	mov	[0252h],dx
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_00A9: 207F:00A9
;;   Called from:
;;     1FC5:0563 (in fn1FC5_04F1)
;;     1FC5:060C (in fn1FC5_059A)
fn207F_00A9 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[0254h],ax
	mov	ax,[bp+8h]
	mov	[0256h],ax
	mov	cx,dx
	and	cx,[0254h]
	or	cx,[0256h]

l207F_00CA:
	loop	00CAh

l207F_00CC:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_00D1: 207F:00D1
;;   Called from:
;;     0800:2E3D (in fn0800_2DA8)
;;     0800:3225 (in fn0800_320B)
;;     0800:4630 (in fn0800_4621)
;;     0800:46E5 (in fn0800_46A7)
;;     0800:49F2 (in fn0800_48B7)
;;     0800:5106 (in fn0800_50C8)
;;     0D27:014C (in main)
;;     0D27:0223 (in main)
;;     0D27:02A5 (in main)
;;     0D27:0327 (in main)
;;     0DAB:1B91 (in fn0DAB_1AFE)
;;     135D:008A (in fn135D_0004)
;;     135D:0632 (in fn135D_055A)
;;     135D:07DC (in fn135D_079C)
;;     1467:08F5 (in fn1467_08A8)
;;     1CD3:15E5 (in fn1CD3_0004)
;;     1CD3:16BC (in fn1CD3_0004)
fn207F_00D1 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	cmp	word ptr [0B764h],0h
	jnz	0147h

l207F_00E3:
	mov	ax,[bp+6h]
	mov	si,ax
	mov	ax,[bp+8h]
	push	es
	mov	es,ax
	mov	di,200h
	mov	cx,20h

l207F_00F4:
	mov	al,es:[si]
	mov	[di],al
	inc	si
	inc	di
	loop	00F4h

l207F_00FD:
	mov	si,0h
	mov	di,100h
	xor	cl,cl
	xor	dx,dx

l207F_0107:
	xor	ah,ah
	mov	al,cl
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	dl,al
	mov	al,cl
	and	al,0Fh
	mov	bx,200h
	add	bx,dx
	mov	ch,[bx]
	sub	bx,dx
	shl	ch,1h
	shl	ch,1h
	add	bx,ax
	or	ch,[bx+10h]
	sub	bx,ax
	mov	[si],ch
	inc	si
	add	bx,dx
	mov	ch,[bx+10h]
	sub	bx,dx
	shl	ch,1h
	shl	ch,1h
	add	bx,ax
	or	ch,[bx]
	mov	[di],ch
	inc	di
	inc	cl
	jnz	0107h

l207F_0146:
	pop	es

l207F_0147:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_014C: 207F:014C
;;   Called from:
;;     0800:28EB (in fn0800_28CC)
;;     0800:2909 (in fn0800_28CC)
fn207F_014C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	dx,[bp+6h]
	mov	ah,0Eh
	int	21h
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0163: 207F:0163
;;   Called from:
;;     0800:1B53 (in fn0800_1AFD)
;;     0800:45F5 (in fn0800_45C2)
;;     0D27:03CF (in main)
;;     1F3D:0504 (in fn1F3D_049D)
fn207F_0163 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	si,ax
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Ah]
	mov	di,ax
	mov	ax,[bp+0Ch]
	mov	[0B790h],ax
	mov	dx,[bp+0Eh]
	mov	[0B763h],dl
	mov	cx,[bp+10h]
	mov	dx,[0B790h]
	push	es
	push	bp
	mov	bp,dx
	xor	dh,dh

l207F_0198:
	mov	bx,0h

l207F_019B:
	mov	dl,[0B763h]

l207F_019F:
	mov	ax,[0B78Ch]
	mov	es,ax
	mov	al,es:[si]
	inc	si
	xlat
	shl	al,1h
	shl	al,1h
	shl	al,1h
	shl	al,1h
	mov	ah,al
	mov	al,es:[si]
	xlat
	inc	si
	or	al,ah
	mov	es,bp
	stosb
	dec	dl
	jz	01C6h

l207F_01C1:
	loop	019Fh

l207F_01C3:
	jmp	01D0h
207F:01C5                90                                    .          

l207F_01C6:
	xor	dh,1h
	jz	0198h

l207F_01CB:
	mov	bx,100h
	jmp	019Bh

l207F_01D0:
	pop	bp
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_01D7: 207F:01D7
;;   Called from:
;;     1F3D:0519 (in fn1F3D_049D)
fn207F_01D7 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	bx,[bp+6h]
	mov	si,bx
	mov	di,bx
	mov	ax,[bp+8h]
	push	es
	push	ds
	mov	es,ax
	mov	ds,ax
	add	si,3E40h
	add	di,7C80h
	cld

l207F_01FB:
	mov	cx,20h
	rep movsw
	sub	si,80h
	sub	di,0C0h
	cmp	di,bx
	jnz	01FBh

l207F_020C:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0213: 207F:0213
;;   Called from:
;;     0D27:002B (in fn0D27_000A)
fn207F_0213 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	dl,[bp+6h]
	mov	ah,6h
	int	21h
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_022A: 207F:022A
;;   Called from:
;;     1F3D:0598 (in fn1F3D_0525)
fn207F_022A proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	bx,[bp+6h]
	mov	cx,[bp+8h]
	mov	ax,40h
	mov	es,ax
	mov	dx,es:[0063h]
	add	dl,6h
	push	dx
	cli
	in	al,dx
	mov	dl,0C0h
	mov	al,bl
	out	dx,al
	mov	al,cl
	out	dx,al
	pop	dx
	in	al,dx
	mov	dl,0C0h
	mov	al,20h
	out	dx,al
	sti
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0260: 207F:0260
;;   Called from:
;;     0800:2E95 (in fn0800_2DA8)
;;     0800:4693 (in fn0800_4621)
;;     0800:473D (in fn0800_46A7)
;;     0D27:0199 (in main)
;;     0D27:0270 (in main)
;;     0D27:02F2 (in main)
;;     0DAB:1BC9 (in fn0DAB_1AFE)
;;     135D:0135 (in fn135D_0004)
;;     135D:06B2 (in fn135D_055A)
;;     135D:0888 (in fn135D_079C)
;;     1467:092D (in fn1467_08A8)
;;     1CD3:1661 (in fn1CD3_0004)
fn207F_0260 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	si,ax
	mov	ax,[bp+8h]
	push	es
	mov	es,ax
	mov	ax,[bp+0Ah]
	mov	cx,1F40h
	push	ds
	mov	ds,ax
	mov	di,0h
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	al,3h
	mov	ah,18h

l207F_028D:
	mov	ax,8008h
	out	dx,ax
	mov	al,[di]
	mov	bl,es:[si]
	mov	al,bl
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	[di],al
	mov	al,[di]
	mov	ax,4008h
	out	dx,ax
	mov	[di],bl
	inc	si
	mov	ax,2008h
	out	dx,ax
	mov	al,[di]
	mov	bl,es:[si]
	mov	al,bl
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	[di],al
	mov	al,[di]
	mov	ax,1008h
	out	dx,ax
	mov	[di],bl
	inc	si
	mov	ax,808h
	out	dx,ax
	mov	al,[di]
	mov	bl,es:[si]
	mov	al,bl
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	[di],al
	mov	al,[di]
	mov	ax,408h
	out	dx,ax
	mov	[di],bl
	inc	si
	mov	ax,208h
	out	dx,ax
	mov	al,[di]
	mov	bl,es:[si]
	mov	al,bl
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	[di],al
	mov	al,[di]
	mov	ax,108h
	out	dx,ax
	mov	[di],bl
	inc	si
	inc	di
	loop	028Dh

l207F_0308:
	mov	ax,8h
	out	dx,ax
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0313: 207F:0313
;;   Called from:
;;     1E56:0AD9 (in fn1E56_0A3B)
fn207F_0313 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	ax,8h
	out	dx,ax
	mov	ax,[bp+6h]
	mov	di,ax
	mov	ax,[bp+8h]
	mov	es,ax
	mov	bx,[bp+0Ah]
	mov	ax,[bp+0Ch]
	mov	dx,140h
	mul	dx
	add	ax,bx
	mov	si,ax
	push	ds
	mov	ax,0A800h
	mov	ds,ax
	mov	cx,8h
	mov	dx,3CEh

l207F_034F:
	mov	ax,4h
	out	dx,ax
	mov	al,[si]
	stosb
	mov	ax,104h
	out	dx,ax
	mov	al,[si]
	stosb
	mov	ax,204h
	out	dx,ax
	mov	al,[si]
	stosb
	mov	ax,304h
	out	dx,ax
	mov	al,[si]
	stosb
	add	si,28h
	loop	034Fh

l207F_0370:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0377: 207F:0377
;;   Called from:
;;     0800:057D (in fn0800_051B)
;;     0800:077E (in fn0800_051B)
;;     0800:0A18 (in fn0800_051B)
;;     0800:0D69 (in fn0800_051B)
;;     0800:0EC0 (in fn0800_0E4B)
;;     0800:152A (in fn0800_0E4B)
;;     0800:164F (in fn0800_0E4B)
;;     0800:2AF2 (in fn0800_2A93)
;;     1631:1FD5 (in fn1631_1F73)
fn207F_0377 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,[bp+6h]
	mov	di,ax
	mov	ax,[bp+8h]
	mov	es,ax
	mov	ax,[bp+0Ah]
	mov	si,ax
	mov	ax,[bp+0Ch]
	mov	[025Ch],ax
	mov	ax,[bp+0Eh]
	mov	[0262h],ax
	sar	ax,1h
	sar	ax,1h
	sar	ax,1h
	mov	[0266h],ax
	mov	ax,[bp+10h]
	mov	[0264h],ax
	push	ds
	inc	si
	mov	ax,[025Ch]
	mov	ds,ax
	lodsw
	inc	si
	pop	ds
	inc	al
	push	ax
	and	ax,0FFh
	mov	[026Ch],ax
	pop	ax
	xchg	ah,al
	and	ax,0FFh
	mov	[0268h],ax
	shl	ax,1h
	shl	ax,1h
	mov	[026Ah],ax
	mov	ax,[0264h]
	cmp	ax,0h
	jns	03FDh

l207F_03D8:
	neg	ax
	cmp	ax,[026Ch]
	jnc	0447h

l207F_03E0:
	mov	dx,[0268h]
	shl	dx,1h
	shl	dx,1h
	mul	dx
	add	si,ax
	mov	ax,[026Ch]
	add	ax,[0264h]
	js	0447h

l207F_03F5:
	mov	[026Ch],ax
	xor	ax,ax
	mov	[0264h],ax

l207F_03FD:
	mov	ax,0C8h
	sub	ax,[0264h]
	js	0447h

l207F_0406:
	jz	0447h

l207F_0408:
	cmp	ax,[026Ch]
	jnc	0411h

l207F_040E:
	mov	[026Ch],ax

l207F_0411:
	mov	ax,[0266h]
	cmp	ax,0h
	jns	0430h

l207F_0419:
	add	[0268h],ax
	neg	ax
	shl	ax,1h
	shl	ax,1h
	add	si,ax
	cmp	ax,[026Ah]
	jnc	0447h

l207F_042B:
	xor	ax,ax
	mov	[0266h],ax

l207F_0430:
	mov	ax,28h
	sub	ax,[0266h]
	js	0447h

l207F_0439:
	jz	0447h

l207F_043B:
	cmp	ax,[0268h]
	jnc	044Ah

l207F_0441:
	mov	[0268h],ax
	jmp	044Ah
207F:0446                   90                                  .         

l207F_0447:
	jmp	0568h

l207F_044A:
	mov	ax,[0264h]
	mov	dx,28h
	mul	dl
	add	ax,[0266h]
	add	di,ax
	mov	ax,28h
	sub	ax,[0268h]
	mov	[0264h],ax
	mov	dx,3CEh
	mov	ax,5h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax
	mov	bx,[0262h]
	and	bx,7h

l207F_0474:
	mov	bp,[0266h]
	mov	cx,[0268h]
	mov	ax,[025Ch]
	push	ds
	mov	ds,ax
	mov	dh,3h

l207F_0484:
	push	cx
	mov	dl,0CEh
	mov	ax,4h
	out	dx,ax
	mov	dl,0C4h
	mov	ax,102h
	out	dx,ax
	mov	ax,[si]
	or	ax,[si+2h]
	or	ah,al
	xor	al,al
	cmp	bl,al
	jz	04A2h

l207F_049E:
	mov	cl,bl
	shr	ax,cl

l207F_04A2:
	not	ax
	mov	ch,ah
	mov	bh,al
	and	es:[di],ch
	lodsb
	mov	ah,al
	xor	al,al
	cmp	bl,al
	jz	04B6h

l207F_04B4:
	shr	ax,cl

l207F_04B6:
	or	es:[di],ah
	cmp	bp,27h
	jnc	04C6h

l207F_04BE:
	and	es:[di+1h],bh
	or	es:[di+1h],al

l207F_04C6:
	mov	dl,0CEh
	mov	ax,104h
	out	dx,ax
	mov	dl,0C4h
	mov	ax,202h
	out	dx,ax
	and	es:[di],ch
	lodsb
	mov	ah,al
	xor	al,al
	cmp	bl,al
	jz	04E0h

l207F_04DE:
	shr	ax,cl

l207F_04E0:
	or	es:[di],ah
	cmp	bp,27h
	jnc	04F0h

l207F_04E8:
	and	es:[di+1h],bh
	or	es:[di+1h],al

l207F_04F0:
	mov	dl,0CEh
	mov	ax,204h
	out	dx,ax
	mov	dl,0C4h
	mov	ax,402h
	out	dx,ax
	and	es:[di],ch
	lodsb
	mov	ah,al
	xor	al,al
	cmp	bl,al
	jz	050Ah

l207F_0508:
	shr	ax,cl

l207F_050A:
	or	es:[di],ah
	cmp	bp,27h
	jnc	051Ah

l207F_0512:
	and	es:[di+1h],bh
	or	es:[di+1h],al

l207F_051A:
	mov	dl,0CEh
	mov	ax,304h
	out	dx,ax
	mov	dl,0C4h
	mov	ax,802h
	out	dx,ax
	and	es:[di],ch
	lodsb
	mov	ah,al
	xor	al,al
	cmp	bl,al
	jz	0534h

l207F_0532:
	shr	ax,cl

l207F_0534:
	or	es:[di],ah
	cmp	bp,27h
	jnc	0544h

l207F_053C:
	and	es:[di+1h],bh
	or	es:[di+1h],al

l207F_0544:
	inc	bp
	inc	di
	pop	cx
	loop	0565h

l207F_0549:
	pop	ds
	add	si,[026Ah]
	mov	ax,[0268h]
	shl	ax,1h
	shl	ax,1h
	sub	si,ax
	add	di,[0264h]
	sub	word ptr [026Ch],1h
	jz	0568h

l207F_0562:
	jmp	0474h

l207F_0565:
	jmp	0484h

l207F_0568:
	mov	ax,0F02h
	out	dx,ax
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0572: 207F:0572
;;   Called from:
;;     0800:1BB1 (in fn0800_1AFD)
;;     0800:327F (in fn0800_320B)
;;     0800:4617 (in fn0800_45C2)
;;     0D27:0403 (in main)
fn207F_0572 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	si,[bp+6h]
	mov	bx,[bp+8h]
	mov	di,[bp+0Ah]
	mov	ax,[bp+0Ch]
	mov	es,ax
	mov	cx,[bp+0Eh]
	shr	cx,1h
	push	ds
	mov	ds,bx

l207F_0594:
	lodsb
	call	05BFh
	call	05BFh
	lodsb
	call	05BFh
	call	05BFh
	lodsb
	call	05BFh
	call	05BFh
	lodsb
	call	05BFh
	call	05BFh
	mov	ax,bx
	stosw
	mov	ax,dx
	stosw
	loop	0594h

l207F_05B8:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_05BF: 207F:05BF
;;   Called from:
;;     207F:0595 (in fn207F_0572)
;;     207F:0598 (in fn207F_0572)
;;     207F:059C (in fn207F_0572)
;;     207F:059F (in fn207F_0572)
;;     207F:05A3 (in fn207F_0572)
;;     207F:05A6 (in fn207F_0572)
;;     207F:05AA (in fn207F_0572)
;;     207F:05AD (in fn207F_0572)
fn207F_05BF proc
	shl	al,1h
	rcl	dh,1h
	shl	al,1h
	rcl	dl,1h
	shl	al,1h
	rcl	bh,1h
	shl	al,1h
	rcl	bl,1h
	ret

;; fn207F_05D0: 207F:05D0
;;   Called from:
;;     1F3D:03C5 (in fn1F3D_031C)
;;     1F3D:041C (in fn1F3D_03EB)
;;     1F3D:0489 (in fn1F3D_03EB)
fn207F_05D0 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,[bp+6h]
	mov	[0220h],ax
	mov	ax,[bp+8h]
	mov	[0234h],ax
	mov	ax,[bp+0Ah]
	mov	[0236h],ax
	mov	ax,[bp+0Ch]
	mov	[0224h],ax
	cmp	word ptr [0B764h],3h
	jz	0605h

l207F_05FB:
	cmp	word ptr [0B764h],0h
	jnz	0630h

l207F_0602:
	jmp	06FDh

l207F_0605:
	mov	ax,0A000h
	mov	es,ax
	mov	ax,[0234h]
	mov	dx,140h
	mul	dx
	add	ax,[0220h]
	mov	di,ax
	mov	cx,[0236h]
	sub	cx,[0234h]
	inc	cx
	mov	ax,[0224h]

l207F_0624:
	mov	es:[di],al
	add	di,140h
	loop	0624h

l207F_062D:
	jmp	06F7h

l207F_0630:
	cmp	word ptr [0B764h],1h
	jz	067Fh

l207F_0637:
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	cx,[0220h]
	mov	ax,8008h
	and	cx,7h
	jz	064Ch

l207F_064A:
	shr	ah,cl

l207F_064C:
	out	dx,ax
	mov	ax,0A000h
	mov	es,ax
	mov	dx,[0234h]
	mov	ax,28h
	mul	dl
	mov	bx,[0220h]
	shr	bx,1h
	shr	bx,1h
	shr	bx,1h
	add	ax,bx
	mov	di,ax
	mov	ax,[0224h]

l207F_066C:
	mov	ah,es:[di]
	mov	es:[di],al
	add	di,28h
	inc	dx
	cmp	dx,[0236h]
	jle	066Ch

l207F_067C:
	jmp	06F7h
207F:067E                                           90                  . 

l207F_067F:
	mov	cx,4h
	shl	ax,cl
	or	ax,[0224h]
	mov	bx,0Fh
	mov	cx,[0220h]
	test	cx,1h
	jnz	069Ah

l207F_0695:
	mov	cx,4h
	shl	bx,cl

l207F_069A:
	and	ax,bx
	mov	[0224h],ax
	not	bl
	mov	ax,0B800h
	mov	es,ax
	mov	ax,[0234h]
	and	al,0FCh
	mov	dx,28h
	mul	dl
	mov	cx,[0234h]
	and	cx,3h
	jz	06BEh

l207F_06B9:
	add	ah,20h
	loop	06B9h

l207F_06BE:
	mov	dx,[0220h]
	shr	dx,1h
	add	ax,dx
	mov	dx,[0234h]
	mov	di,ax
	mov	cx,[0236h]
	sub	cx,[0234h]
	inc	cx

l207F_06D5:
	mov	al,es:[di]
	and	al,bl
	or	ax,[0224h]
	mov	es:[di],al
	inc	dl
	and	dl,3h
	jz	06F1h

l207F_06E8:
	add	di,2000h
	loop	06D5h

l207F_06EE:
	jmp	06F7h
207F:06F0 90                                              .               

l207F_06F1:
	sub	di,5F60h
	loop	06D5h

l207F_06F7:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_06FD:
	and	ax,3h
	mov	[0224h],ax
	shl	ax,1h
	shl	ax,1h
	or	ax,[0224h]
	mov	bx,ax
	mov	cx,4h
	shl	ax,cl
	or	ax,bx
	mov	bx,3h
	mov	cx,[0220h]
	and	cx,3h
	xor	cx,3h
	jz	0727h

l207F_0723:
	add	cx,cx
	shl	bx,cl

l207F_0727:
	and	ax,bx
	mov	[0224h],ax
	not	bl
	mov	ax,0B800h
	mov	es,ax
	mov	ax,[0234h]
	and	al,0FEh
	mov	dx,28h
	mul	dl
	mov	dx,[0220h]
	shr	dx,1h
	shr	dx,1h
	add	ax,dx
	mov	dx,[0234h]
	and	dx,1h
	jz	0753h

l207F_0750:
	add	ax,2000h

l207F_0753:
	mov	di,ax
	mov	cx,[0236h]
	sub	cx,[0234h]
	inc	cx

l207F_075E:
	mov	al,es:[di]
	and	al,bl
	or	ax,[0224h]
	mov	es:[di],al
	xor	dl,1h
	jz	0777h

l207F_076F:
	add	di,2000h
	loop	075Eh

l207F_0775:
	jmp	06F7h

l207F_0777:
	sub	di,1FB0h
	loop	075Eh

l207F_077D:
	jmp	06F7h

;; fn207F_0780: 207F:0780
;;   Called from:
;;     1F3D:0460 (in fn1F3D_03EB)
fn207F_0780 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,[bp+6h]
	mov	[0220h],ax
	mov	ax,[bp+8h]
	mov	[0234h],ax
	mov	cx,[bp+0Ah]
	mov	[0230h],cx
	mov	ax,[bp+0Ch]
	mov	[0224h],ax
	cmp	word ptr [0B764h],3h
	jz	07BDh

l207F_07AC:
	cmp	word ptr [0B764h],2h
	jz	07D8h

l207F_07B3:
	cmp	word ptr [0B764h],1h
	jz	080Eh

l207F_07BA:
	jmp	0854h

l207F_07BD:
	mov	ax,0A000h
	mov	es,ax
	mov	ax,[0234h]
	mov	dx,140h
	mul	dx
	add	ax,[0220h]
	mov	di,ax
	mov	ax,[0224h]

l207F_07D3:
	rep stosb

l207F_07D5:
	jmp	084Eh
207F:07D7                      90                                .        

l207F_07D8:
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax
	mov	dx,28h
	mov	ax,[0234h]
	mul	dl
	mov	bx,[0220h]
	shr	bx,1h
	shr	bx,1h
	shr	bx,1h
	add	ax,bx
	mov	di,ax
	mov	ax,0A000h
	mov	es,ax
	mov	cx,[0230h]
	mov	ax,[0224h]

l207F_0805:
	mov	ah,es:[di]
	stosb
	loop	0805h

l207F_080B:
	jmp	084Eh
207F:080D                                        90                    .  

l207F_080E:
	mov	cx,4h
	shl	al,cl
	or	ax,[0224h]
	mov	ah,al
	mov	[0224h],ax
	mov	ax,0B800h
	mov	es,ax
	mov	ax,[0234h]
	and	al,0FCh
	mov	dx,28h
	mul	dl
	mov	dx,[0220h]
	shr	dx,1h
	add	ax,dx
	mov	dx,[0234h]
	and	dx,3h
	jz	0843h

l207F_083C:
	mov	cx,dx

l207F_083E:
	add	ah,20h
	loop	083Eh

l207F_0843:
	mov	di,ax
	mov	cx,[0230h]
	mov	ax,[0224h]

l207F_084C:
	rep stosb

l207F_084E:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_0854:
	and	ax,3h
	mov	[0224h],ax
	shl	al,1h
	shl	al,1h
	or	ax,[0224h]
	mov	bl,al
	mov	cl,4h
	shl	al,cl
	or	al,bl
	mov	ah,al
	mov	[0224h],ax
	mov	ax,0B800h
	mov	es,ax
	mov	ax,[0234h]
	and	al,0FEh
	mov	dx,28h
	mul	dl
	mov	dx,[0220h]
	shr	dx,1h
	shr	dx,1h
	add	ax,dx
	mov	dx,[0234h]
	and	dx,1h
	jz	0894h

l207F_0891:
	add	ah,20h

l207F_0894:
	mov	di,ax
	mov	cx,[0230h]
	mov	ax,[0224h]

l207F_089D:
	rep stosb

l207F_089F:
	jmp	084Eh

;; fn207F_08A1: 207F:08A1
;;   Called from:
;;     1F3D:024F (in fn1F3D_01FB)
fn207F_08A1 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,[bp+6h]
	shr	ax,1h
	mov	[0220h],ax
	mov	ax,[bp+8h]
	mov	[0234h],ax
	mov	ax,[bp+0Ah]
	add	ax,1h
	mov	[0230h],ax
	mov	ax,[bp+0Ch]
	mov	[0236h],ax
	mov	ax,[bp+0Eh]
	mov	[0224h],ax
	mov	cx,4h
	shl	al,cl
	or	ax,[0224h]
	mov	ah,al
	mov	[0224h],ax
	mov	ax,0B800h
	mov	es,ax
	mov	ax,[0234h]
	and	al,0FCh
	mov	dx,28h
	mul	dl
	add	ax,[0220h]
	mov	dx,[0234h]
	and	dx,3h
	jz	0901h

l207F_08FA:
	mov	cx,dx

l207F_08FC:
	add	ah,20h
	loop	08FCh

l207F_0901:
	mov	di,ax
	mov	bx,[0236h]
	mov	ax,[0224h]

l207F_090A:
	mov	cx,[0230h]

l207F_090E:
	rep stosb

l207F_0910:
	sub	di,[0230h]
	inc	dl
	and	dl,3h
	jz	0924h

l207F_091B:
	add	di,2000h
	dec	bx
	jns	090Ah

l207F_0922:
	js	092Bh

l207F_0924:
	sub	di,5F60h
	dec	bx
	jns	090Ah

l207F_092B:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0931: 207F:0931
;;   Called from:
;;     1F3D:07C8 (in fn1F3D_070A)
;;     1F3D:0807 (in fn1F3D_070A)
fn207F_0931 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	si,[bp+6h]
	mov	ax,[bp+8h]
	mov	[025Ah],ax
	mov	di,[bp+0Ah]
	mov	ax,[bp+0Ch]
	mov	es,ax
	mov	dx,[bp+0Eh]
	mov	ax,[bp+10h]
	mov	dh,al
	mov	bx,[bp+12h]
	push	ds
	mov	ds,[025Ah]

l207F_095E:
	mov	cl,dl
	xor	ch,ch
	rep movsw
	add	si,bx
	dec	dh
	jnz	095Eh

l207F_096A:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0971: 207F:0971
;;   Called from:
;;     0800:4405 (in fn0800_3FAE)
;;     0DAB:15EC (in fn0DAB_1467)
;;     1631:008C (in fn1631_0006)
;;     1631:0A8C (in fn1631_03AB)
;;     1631:1C7F (in fn1631_1BFE)
;;     1631:1D78 (in fn1631_1BFE)
;;     183B:1A73 (in fn183B_193B)
;;     1AE8:0148 (in fn1AE8_000C)
fn207F_0971 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[0238h],ax
	mov	ax,[bp+8h]
	mov	[023Ah],ax
	mov	ax,[bp+0Ah]
	mov	[023Ch],ax
	mov	ax,[bp+0Ch]
	mov	[023Eh],ax
	mov	ax,[023Ah]
	mov	bx,[023Eh]
	sub	al,bl
	xor	dx,dx
	mov	dl,al
	or	dl,dl
	jns	09A7h

l207F_09A5:
	dec	dh

l207F_09A7:
	and	ah,0F0h
	and	bh,0F0h
	cmp	bh,ah
	jz	09BBh

l207F_09B1:
	jc	09B8h

l207F_09B3:
	or	dx,80h
	jnz	09BBh

l207F_09B8:
	and	dx,7Fh

l207F_09BB:
	mov	di,dx
	xor	dx,dx
	mov	ax,[0238h]
	mov	bx,[023Ch]
	mov	cx,bx
	sub	cx,ax
	cmp	bh,ah
	jz	09DAh

l207F_09CE:
	jc	09D6h

l207F_09D0:
	and	cx,7Fh
	jmp	09DAh
207F:09D5                90                                    .          

l207F_09D6:
	or	cx,80h

l207F_09DA:
	mov	bx,cx
	or	bx,bx
	jns	09E2h

l207F_09E0:
	neg	bx

l207F_09E2:
	mov	ax,di
	shl	ax,1h
	cmp	ax,bx
	jl	09EDh

l207F_09EA:
	or	dx,8h

l207F_09ED:
	mov	ax,di
	neg	ax
	shl	ax,1h
	cmp	ax,bx
	jl	09FAh

l207F_09F7:
	or	dx,4h

l207F_09FA:
	mov	bx,di
	or	bx,bx
	jns	0A02h

l207F_0A00:
	neg	bx

l207F_0A02:
	mov	ax,cx
	shl	ax,1h
	cmp	ax,bx
	jl	0A0Dh

l207F_0A0A:
	or	dx,2h

l207F_0A0D:
	mov	ax,cx
	neg	ax
	shl	ax,1h
	cmp	ax,bx
	jl	0A1Ah

l207F_0A17:
	or	dx,1h

l207F_0A1A:
	mov	bx,dx
	mov	al,[bx+240h]
	cbw
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0A26: 207F:0A26
;;   Called from:
;;     0D27:03E1 (in main)
fn207F_0A26 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	mov	dx,[bp+8h]
	mov	di,[bp+0Ah]
	mov	ax,[bp+0Ch]
	push	es
	mov	es,ax
	mov	cx,3E80h
	push	ds
	mov	ds,dx
	mov	dx,0F00Fh

l207F_0A49:
	lodsw
	xor	bl,bl
	test	dh,al
	jz	0A53h

l207F_0A50:
	or	bl,0C0h

l207F_0A53:
	test	dl,al
	jz	0A5Ah

l207F_0A57:
	or	bl,30h

l207F_0A5A:
	test	dh,ah
	jz	0A61h

l207F_0A5E:
	or	bl,0Ch

l207F_0A61:
	test	dl,ah
	jz	0A68h

l207F_0A65:
	or	bl,3h

l207F_0A68:
	mov	al,bl
	not	al
	stosb
	loop	0A49h

l207F_0A6F:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0A76: 207F:0A76
;;   Called from:
;;     0800:329B (in fn0800_320B)
;;     0D27:039F (in main)
fn207F_0A76 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	mov	dx,[bp+8h]
	mov	di,[bp+0Ah]
	mov	ax,[bp+0Ch]
	push	es
	mov	es,ax
	mov	cx,[bp+0Eh]
	push	ds
	mov	ds,dx
	rep movsw
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0A9F: 207F:0A9F
;;   Called from:
;;     0800:24A8 (in fn0800_240B)
fn207F_0A9F proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	dx,3CEh
	mov	ax,5h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax
	mov	ax,1h
	out	dx,ax
	mov	ax,[bp+6h]
	mov	si,ax
	mov	ax,0A400h
	push	es
	mov	es,ax
	mov	di,[bp+0Ah]
	mov	ax,[bp+8h]
	push	ds
	mov	ds,ax
	mov	cx,10h
	mov	dx,3C4h

l207F_0AD3:
	mov	ax,102h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,202h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,402h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,802h
	out	dx,ax
	mov	al,es:[di]
	movsb
	mov	ax,102h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,202h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,402h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,802h
	out	dx,ax
	mov	al,es:[di]
	movsb
	loop	0AD3h

l207F_0B1B:
	mov	ax,0F02h
	out	dx,ax
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0B26: 207F:0B26
;;   Called from:
;;     0DAB:0C68 (in fn0DAB_0B95)
fn207F_0B26 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	dx
	mov	dx,3DAh
	in	al,dx
	and	al,8h
	xor	ah,ah
	pop	dx
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0B40: 207F:0B40
;;   Called from:
;;     1F3D:001B (in fn1F3D_0006)
;;     1F3D:0541 (in fn1F3D_0525)
;;     1F3D:0566 (in fn1F3D_0525)
fn207F_0B40 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	bl,[bp+6h]
	push	dx
	mov	dx,3DAh
	cmp	bl,1h
	jz	0B63h

l207F_0B57:
	in	al,dx
	test	al,8h
	jz	0B57h

l207F_0B5C:
	in	al,dx
	test	al,8h
	jnz	0B5Ch

l207F_0B61:
	jz	0B6Dh

l207F_0B63:
	in	al,dx
	test	al,8h
	jnz	0B63h

l207F_0B68:
	in	al,dx
	test	al,8h
	jz	0B68h

l207F_0B6D:
	pop	dx
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0B73: 207F:0B73
;;   Called from:
;;     0DAB:0CC6 (in fn0DAB_0C8F)
;;     0DAB:0D1D (in fn0DAB_0D12)
fn207F_0B73 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	xor	ah,ah
	int	10h
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0B8A: 207F:0B8A
;;   Called from:
;;     1F3D:0270 (in fn1F3D_0259)
;;     1F3D:02F5 (in fn1F3D_0259)
fn207F_0B8A proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	xor	ah,ah
	int	16h
	cmp	al,0h
	jnz	0BA1h

l207F_0B9D:
	mov	al,ah
	neg	al

l207F_0BA1:
	cbw
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0BA7: 207F:0BA7
;;   Called from:
;;     0D27:013C (in main)
;;     135D:0780 (in fn135D_055A)
;;     135D:08ED (in fn135D_079C)
;;     1CD3:15FD (in fn1CD3_0004)
;;     1CD3:170F (in fn1CD3_0004)
fn207F_0BA7 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	bx,[bp+6h]
	mov	bh,1h
	mov	ah,0Bh
	int	10h
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0BC0: 207F:0BC0
;;   Called from:
;;     0800:0287 (in fn0800_0000)
;;     0800:03C9 (in fn0800_0000)
;;     0800:19FE (in fn0800_19F3)
;;     0800:27BB (in fn0800_24C2)
;;     0800:30F7 (in fn0800_2DA8)
;;     0800:4553 (in fn0800_3FAE)
;;     0800:4900 (in fn0800_48B7)
;;     0800:4F41 (in fn0800_4DC7)
;;     0800:50D8 (in fn0800_50C8)
;;     0DAB:0448 (in fn0DAB_0002)
;;     0DAB:0926 (in fn0DAB_04F9)
;;     0DAB:0930 (in fn0DAB_04F9)
;;     0DAB:09EE (in fn0DAB_094B)
;;     0DAB:0D68 (in fn0DAB_0D3D)
;;     0DAB:0D76 (in fn0DAB_0D3D)
;;     0DAB:0D87 (in fn0DAB_0D3D)
;;     0DAB:0D95 (in fn0DAB_0D3D)
;;     0DAB:0E08 (in fn0DAB_0D3D)
;;     0DAB:0E36 (in fn0DAB_0D3D)
;;     0DAB:0E9C (in fn0DAB_0D3D)
;;     0DAB:0EC2 (in fn0DAB_0D3D)
;;     0DAB:0F22 (in fn0DAB_0D3D)
;;     0DAB:0F42 (in fn0DAB_0D3D)
;;     0FDC:04E2 (in fn0FDC_01C0)
;;     0FDC:0678 (in fn0FDC_0629)
;;     0FDC:074D (in fn0FDC_0629)
;;     0FDC:0776 (in fn0FDC_0629)
;;     0FDC:0CB5 (in fn0FDC_0629)
;;     0FDC:0CD8 (in fn0FDC_0629)
;;     0FDC:0E4E (in fn0FDC_0D49)
;;     0FDC:0E5C (in fn0FDC_0D49)
;;     0FDC:0E65 (in fn0FDC_0D49)
;;     0FDC:0E73 (in fn0FDC_0D49)
;;     0FDC:0EC5 (in fn0FDC_0D49)
;;     0FDC:0EF5 (in fn0FDC_0D49)
;;     0FDC:0F03 (in fn0FDC_0D49)
;;     0FDC:105D (in fn0FDC_0D49)
;;     0FDC:10A1 (in fn0FDC_0D49)
;;     0FDC:10BB (in fn0FDC_0D49)
;;     0FDC:10D5 (in fn0FDC_0D49)
;;     0FDC:12D1 (in fn0FDC_0D49)
;;     0FDC:1323 (in fn0FDC_0D49)
;;     0FDC:19B2 (in fn0FDC_17B9)
;;     11B8:0DE0 (in fn11B8_0D58)
;;     11B8:0E04 (in fn11B8_0D58)
;;     11B8:0F1D (in fn11B8_0D58)
;;     11B8:121F (in fn11B8_104E)
;;     11B8:122D (in fn11B8_104E)
;;     11B8:1240 (in fn11B8_104E)
;;     11B8:12F9 (in fn11B8_104E)
;;     11B8:134B (in fn11B8_104E)
;;     11B8:138A (in fn11B8_137F)
;;     11B8:1478 (in fn11B8_1441)
;;     11B8:14AE (in fn11B8_1441)
;;     11B8:14D1 (in fn11B8_1441)
;;     11B8:1506 (in fn11B8_1441)
;;     1467:0B25 (in fn1467_08A8)
;;     1631:1663 (in fn1631_163E)
;;     183B:0490 (in fn183B_000A)
;;     183B:0660 (in fn183B_000A)
;;     183B:0818 (in fn183B_000A)
;;     183B:0EC2 (in fn183B_000A)
;;     1AE8:09D9 (in fn1AE8_000C)
;;     1CD3:143C (in fn1CD3_0004)
;;     1CD3:14D2 (in fn1CD3_0004)
fn207F_0BC0 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,3EDBh
	mov	es,ax
	mov	si,4FC0h
	xor	ah,ah
	mov	al,es:[si]
	shr	al,1h
	shr	al,1h
	rcl	byte ptr es:[si+2h],1h
	rcl	byte ptr es:[si+1h],1h
	cmc
	sbb	al,es:[si]
	shr	al,1h
	rcr	byte ptr es:[si],1h
	mov	al,es:[si]
	xor	al,es:[si+1h]
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_0BFB: 207F:0BFB
;;   Called from:
;;     207F:1081 (in fn207F_104E)
;;     207F:10A7 (in fn207F_104E)
;;     207F:10CD (in fn207F_104E)
;;     207F:10F3 (in fn207F_104E)
;;     207F:1119 (in fn207F_104E)
;;     207F:113F (in fn207F_104E)
;;     207F:1165 (in fn207F_104E)
;;     207F:118B (in fn207F_104E)
;;     207F:11B0 (in fn207F_104E)
;;     207F:15EA (in fn207F_158C)
;;     207F:15F9 (in fn207F_158C)
;;     207F:1607 (in fn207F_158C)
;;     207F:1692 (in fn207F_163B)
;;     207F:16A1 (in fn207F_163B)
;;     207F:16AF (in fn207F_163B)
;;     207F:1770 (in fn207F_16E3)
;;     207F:1781 (in fn207F_16E3)
;;     207F:1791 (in fn207F_16E3)
;;     207F:1831 (in fn207F_17C5)
;;     207F:1842 (in fn207F_17C5)
;;     207F:1852 (in fn207F_17C5)
fn207F_0BFB proc
	push	si
	mov	si,di
	mov	dh,[di]
	mov	dl,[di+8h]
	mov	bh,[di+48h]
	mov	bl,[di+50h]
	push	es
	mov	ax,ds
	mov	es,ax
	mov	cx,28h
	mov	ax,0FFFFh
	cld

l207F_0C15:
	rep stosw

l207F_0C17:
	pop	es
	mov	di,si
	mov	[di],dh
	mov	[di+8h],dl
	mov	[di+48h],bh
	mov	[di+50h],bl
	add	dl,dh
	xor	dh,dh
	mov	[09F9h],dx
	mov	si,279h
	mov	byte ptr [si],0h
	mov	byte ptr [si+1h],8h
	add	si,2h
	call	0D07h
	mov	al,[di+48h]
	add	al,[di+50h]
	xor	ah,ah
	mov	[09F9h],ax
	mov	si,279h
	mov	byte ptr [si],48h
	mov	byte ptr [si+1h],50h
	add	si,2h
	call	0D07h
	mov	al,[di]
	add	al,[di+48h]
	xor	ah,ah
	mov	[09F9h],ax
	mov	si,279h
	mov	byte ptr [si],0h
	mov	byte ptr [si+1h],48h
	add	si,2h
	call	0D79h
	mov	al,[di+8h]
	add	al,[di+50h]
	xor	ah,ah
	mov	[09F9h],ax
	mov	si,279h
	mov	byte ptr [si],8h
	mov	byte ptr [si+1h],50h
	add	si,2h
	call	0D79h
	mov	si,279h
	mov	byte ptr [si],0h
	mov	byte ptr [si+1h],8h
	mov	byte ptr [si+2h],48h
	mov	byte ptr [si+3h],50h
	add	si,4h
	call	0DF8h
	pop	si
	xchg	di,si
	push	es
	mov	ax,ds
	mov	es,ax
	cld
	mov	cx,4h

l207F_0CB1:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CB1h

l207F_0CB8:
	inc	si
	mov	cx,4h

l207F_0CBC:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CBCh

l207F_0CC3:
	inc	si
	mov	cx,4h

l207F_0CC7:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CC7h

l207F_0CCE:
	inc	si
	mov	cx,4h

l207F_0CD2:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CD2h

l207F_0CD9:
	inc	si
	mov	cx,4h

l207F_0CDD:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CDDh

l207F_0CE4:
	inc	si
	mov	cx,4h

l207F_0CE8:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CE8h

l207F_0CEF:
	inc	si
	mov	cx,4h

l207F_0CF3:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CF3h

l207F_0CFA:
	inc	si
	mov	cx,4h

l207F_0CFE:
	lodsw
	and	ax,0F0F0h
	stosw
	loop	0CFEh

l207F_0D05:
	pop	es
	ret

;; fn207F_0D07: 207F:0D07
;;   Called from:
;;     207F:0C3A (in fn207F_0BFB)
;;     207F:0C55 (in fn207F_0BFB)
fn207F_0D07 proc
	cmp	si,279h
	jz	0D78h

l207F_0D0D:
	sub	si,2h
	mov	dh,[si]
	mov	dl,[si+1h]
	mov	al,dl
	sub	al,dh
	cmp	al,1h
	jz	0D07h

l207F_0D1D:
	xor	bh,bh
	mov	bl,dh
	mov	ch,[bx+di]
	mov	bl,dl
	mov	cl,[bx+di]
	shr	al,1h
	mov	bl,al
	add	bl,dh
	mov	[si],dh
	mov	[si+1h],bl
	mov	[si+2h],bl
	mov	[si+3h],dl
	add	si,4h
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0D07h

l207F_0D42:
	mov	dl,ch
	xor	dh,dh
	mov	ch,dh
	add	dx,cx
	shr	dx,1h
	mov	cx,si
	mov	si,9FBh
	add	si,[09F9h]
	mov	ah,[si]
	mov	si,cx
	mov	cl,al
	shl	cl,1h
	mov	ch,cl
	shl	cl,1h
	dec	cl
	and	cl,ah
	sub	cl,ch
	add	dl,cl
	cmp	dl,80h
	jc	0D70h

l207F_0D6E:
	xor	dl,dl

l207F_0D70:
	mov	[bx+di],dl
	inc	byte ptr [09F9h]
	jmp	0D07h

l207F_0D78:
	ret

;; fn207F_0D79: 207F:0D79
;;   Called from:
;;     207F:0C6F (in fn207F_0BFB)
;;     207F:0C8A (in fn207F_0BFB)
fn207F_0D79 proc
	cmp	si,279h
	jz	0DF7h

l207F_0D7F:
	sub	si,2h
	mov	dh,[si]
	mov	dl,[si+1h]
	mov	al,dl
	sub	al,dh
	cmp	al,9h
	jz	0D79h

l207F_0D8F:
	xor	bh,bh
	mov	bl,dh
	mov	ch,[bx+di]
	mov	bl,dl
	mov	cl,[bx+di]
	shr	al,1h
	mov	bl,al
	add	bl,dh
	mov	[si],dh
	mov	[si+1h],bl
	mov	[si+2h],bl
	mov	[si+3h],dl
	add	si,4h
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0D79h

l207F_0DB4:
	mov	dl,ch
	xor	dh,dh
	mov	ch,dh
	add	dx,cx
	shr	dx,1h
	mov	cx,si
	mov	si,9FBh
	add	si,[09F9h]
	mov	ah,[si]
	mov	si,cx
	mov	dh,al
	shr	dh,1h
	shr	dh,1h
	shr	dh,1h
	cmp	dh,9h
	jnz	0DDAh

l207F_0DD8:
	dec	dh

l207F_0DDA:
	shl	dh,1h
	mov	ch,dh
	shl	dh,1h
	dec	dh
	and	dh,ah
	sub	dh,ch
	add	dl,dh
	cmp	dl,80h
	jc	0DEFh

l207F_0DED:
	xor	dl,dl

l207F_0DEF:
	mov	[bx+di],dl
	inc	byte ptr [09F9h]
	jmp	0D79h

l207F_0DF7:
	ret

;; fn207F_0DF8: 207F:0DF8
;;   Called from:
;;     207F:0CA2 (in fn207F_0BFB)
fn207F_0DF8 proc
	cmp	si,279h
	jnz	0E01h

l207F_0DFE:
	jmp	0FEDh

l207F_0E01:
	sub	si,4h
	mov	dh,[si]
	mov	dl,[si+1h]
	sub	dl,dh
	cmp	dl,1h
	jz	0DF8h

l207F_0E10:
	mov	dl,[si+3h]
	xor	bh,bh
	mov	ah,bh
	mov	bl,dh
	mov	al,[bx+di]
	mov	bl,dl
	mov	bl,[bx+di]
	add	ax,bx
	mov	bl,[si+1h]
	mov	bl,[bx+di]
	add	ax,bx
	mov	bl,[si+2h]
	mov	bl,[bx+di]
	add	ax,bx
	shr	ax,1h
	shr	ax,1h
	mov	cl,dl
	sub	cl,dh
	shr	cl,1h
	mov	bl,cl
	add	bl,dh
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0E46h

l207F_0E44:
	mov	[bx+di],al

l207F_0E46:
	mov	[0272h],dh
	mov	[0275h],dl
	mov	[0276h],bl
	mov	al,[si+1h]
	mov	[0273h],al
	mov	al,[si+2h]
	mov	[0274h],al
	mov	[si],dh
	mov	[si+3h],bl
	mov	[si+6h],bl
	mov	[si+9h],bl
	mov	[si+0Ch],bl
	mov	al,[0273h]
	sub	al,dh
	shr	al,1h
	mov	[0277h],al
	mov	bl,[0272h]
	xor	dh,dh
	mov	dl,[bx+di]
	mov	bl,[0273h]
	mov	[si+5h],bl
	mov	bl,[bx+di]
	add	dx,bx
	shr	dx,1h
	mov	bl,al
	add	bl,[0272h]
	mov	[si+1h],bl
	mov	[si+4h],bl
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0EC8h

l207F_0E9E:
	mov	cx,si
	mov	si,9FBh
	add	si,[09F9h]
	inc	byte ptr [09F9h]
	mov	ah,[si]
	mov	si,cx
	mov	cl,al
	shl	cl,1h
	mov	ch,cl
	shl	cl,1h
	dec	cl
	and	cl,ah
	sub	cl,ch
	add	dl,cl
	cmp	dl,80h
	jc	0EC6h

l207F_0EC4:
	xor	dl,dl

l207F_0EC6:
	mov	[bx+di],dl

l207F_0EC8:
	mov	cl,[0274h]
	sub	cl,[0272h]
	shr	cl,1h
	mov	[0278h],cl
	mov	bl,[0272h]
	mov	dl,[bx+di]
	xor	dh,dh
	mov	bl,[0274h]
	mov	bl,[bx+di]
	add	dx,bx
	shr	dx,1h
	mov	bl,cl
	add	bl,[0272h]
	mov	[si+2h],bl
	mov	[si+8h],bl
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0F34h

l207F_0EFB:
	mov	cx,si
	mov	si,9FBh
	add	si,[09F9h]
	inc	byte ptr [09F9h]
	mov	ah,[si]
	mov	si,cx
	mov	dh,[0278h]
	shr	dh,1h
	shr	dh,1h
	shr	dh,1h
	cmp	dh,9h
	jnz	0F1Dh

l207F_0F1B:
	dec	dh

l207F_0F1D:
	shl	dh,1h
	mov	ch,dh
	shl	dh,1h
	dec	dh
	and	dh,ah
	sub	dh,ch
	add	dl,dh
	cmp	dl,80h
	jc	0F32h

l207F_0F30:
	xor	dl,dl

l207F_0F32:
	mov	[bx+di],dl

l207F_0F34:
	mov	bl,[0274h]
	mov	[si+0Ah],bl
	mov	dl,[bx+di]
	mov	bl,[0275h]
	mov	[si+0Fh],bl
	mov	bl,[bx+di]
	add	dx,bx
	shr	dx,1h
	mov	bl,[0277h]
	add	bl,[0274h]
	mov	[si+0Bh],bl
	mov	[si+0Eh],bl
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0F8Bh

l207F_0F5F:
	mov	cx,si
	mov	si,9FBh
	add	si,[09F9h]
	inc	byte ptr [09F9h]
	mov	ah,[si]
	mov	si,cx
	mov	cl,[0277h]
	shl	cl,1h
	mov	ch,cl
	shl	cl,1h
	dec	cl
	and	cl,ah
	sub	cl,ch
	add	dl,cl
	cmp	dl,80h
	jc	0F89h

l207F_0F87:
	xor	dl,dl

l207F_0F89:
	mov	[bx+di],dl

l207F_0F8B:
	mov	bl,[0273h]
	mov	dl,[bx+di]
	mov	bl,[0275h]
	mov	bl,[bx+di]
	add	dx,bx
	shr	dx,1h
	mov	bl,[0278h]
	add	bl,[0273h]
	mov	[si+7h],bl
	mov	[si+0Dh],bl
	mov	ah,[bx+di]
	cmp	ah,0FFh
	jnz	0FE7h

l207F_0FB0:
	mov	cx,si
	mov	si,9FBh
	add	si,[09F9h]
	inc	byte ptr [09F9h]
	mov	ah,[si]
	mov	si,cx
	mov	dh,al
	shr	dh,1h
	shr	dh,1h
	shr	dh,1h
	cmp	dh,9h
	jnz	0FD0h

l207F_0FCE:
	dec	dh

l207F_0FD0:
	shl	dh,1h
	mov	ch,dh
	shl	dh,1h
	dec	dh
	and	dh,ah
	sub	dh,ch
	add	dl,dh
	cmp	dl,80h
	jc	0FE5h

l207F_0FE3:
	xor	dl,dl

l207F_0FE5:
	mov	[bx+di],dl

l207F_0FE7:
	add	si,10h
	jmp	0DF8h

l207F_0FED:
	ret

;; fn207F_0FEE: 207F:0FEE
;;   Called from:
;;     1F3D:05AF (in fn1F3D_0525)
fn207F_0FEE proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	mov	ax,[bp+8h]
	push	es
	mov	es,ax
	mov	bx,0h

l207F_1005:
	mov	al,es:[si]
	xor	ah,ah
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	di,ax
	mov	ch,[di+0A459h]
	mov	al,es:[si]
	and	al,7h
	mov	di,ax
	mov	cl,[di+0A459h]
	inc	si
	mov	al,es:[si]
	inc	si
	mov	di,ax
	mov	dh,[di+0A459h]
	mov	ax,1010h
	int	10h
	push	bx
	shl	bx,1h
	shl	bx,1h
	shl	bx,1h
	shl	bx,1h
	mov	ax,1010h
	int	10h
	pop	bx
	inc	bx
	cmp	bx,10h
	jc	1005h

l207F_1048:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_104E: 207F:104E
;;   Called from:
;;     0800:3469 (in fn0800_32B3)
;;     0800:3EDC (in fn0800_3D40)
;;     0800:42C8 (in fn0800_3FAE)
;;     0800:4FE5 (in fn0800_4DC7)
;;     1CD3:12DB (in fn1CD3_0004)
fn207F_104E proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	bx,[bp+6h]
	sub	bx,11h
	mov	di,2D3h
	mov	al,[bx+0B0Bh]
	mov	[di],al
	mov	al,[bx+0B0Ch]
	mov	[di+8h],al
	mov	al,[bx+0B1Bh]
	mov	[di+48h],al
	mov	al,[bx+0B1Ch]
	mov	[di+50h],al
	mov	si,564h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B0Ch]
	mov	[di],al
	mov	al,[bx+0B0Dh]
	mov	[di+8h],al
	mov	al,[bx+0B1Ch]
	mov	[di+48h],al
	mov	al,[bx+0B1Dh]
	mov	[di+50h],al
	mov	si,5A4h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B0Dh]
	mov	[di],al
	mov	al,[bx+0B0Eh]
	mov	[di+8h],al
	mov	al,[bx+0B1Dh]
	mov	[di+48h],al
	mov	al,[bx+0B1Eh]
	mov	[di+50h],al
	mov	si,5E4h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B1Bh]
	mov	[di],al
	mov	al,[bx+0B1Ch]
	mov	[di+8h],al
	mov	al,[bx+0B2Bh]
	mov	[di+48h],al
	mov	al,[bx+0B2Ch]
	mov	[di+50h],al
	mov	si,624h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B1Ch]
	mov	[di],al
	mov	al,[bx+0B1Dh]
	mov	[di+8h],al
	mov	al,[bx+0B2Ch]
	mov	[di+48h],al
	mov	al,[bx+0B2Dh]
	mov	[di+50h],al
	mov	si,664h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B1Dh]
	mov	[di],al
	mov	al,[bx+0B1Eh]
	mov	[di+8h],al
	mov	al,[bx+0B2Dh]
	mov	[di+48h],al
	mov	al,[bx+0B2Eh]
	mov	[di+50h],al
	mov	si,6A4h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B2Bh]
	mov	[di],al
	mov	al,[bx+0B2Ch]
	mov	[di+8h],al
	mov	al,[bx+0B3Bh]
	mov	[di+48h],al
	mov	al,[bx+0B3Ch]
	mov	[di+50h],al
	mov	si,6E4h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B2Ch]
	mov	[di],al
	mov	al,[bx+0B2Dh]
	mov	[di+8h],al
	mov	al,[bx+0B3Ch]
	mov	[di+48h],al
	mov	al,[bx+0B3Dh]
	mov	[di+50h],al
	mov	si,724h
	push	bx
	call	0BFBh
	pop	bx
	mov	di,2D3h
	mov	al,[bx+0B2Dh]
	mov	[di],al
	mov	al,[bx+0B2Eh]
	mov	[di+8h],al
	mov	al,[bx+0B3Dh]
	mov	[di+48h],al
	mov	al,[bx+0B3Eh]
	mov	[di+50h],al
	mov	si,764h
	call	0BFBh
	call	1886h
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_11BB: 207F:11BB
;;   Called from:
;;     207F:188C (in fn207F_1886)
;;     207F:1895 (in fn207F_1886)
;;     207F:189E (in fn207F_1886)
;;     207F:18A7 (in fn207F_1886)
;;     207F:18B0 (in fn207F_1886)
;;     207F:18B9 (in fn207F_1886)
;;     207F:18C2 (in fn207F_1886)
;;     207F:18CB (in fn207F_1886)
;;     207F:18D4 (in fn207F_1886)
fn207F_11BB proc
	call	12BAh
	or	al,al
	js	11C5h

l207F_11C2:
	call	12F2h

l207F_11C5:
	mov	[di],bl
	inc	si
	inc	di
	mov	cx,6h

l207F_11CC:
	xor	bl,bl
	mov	al,[si]
	or	al,al
	jns	11DBh

l207F_11D4:
	mov	bl,al
	sub	bl,80h
	jnz	11EEh

l207F_11DB:
	call	12F2h
	cmp	al,[si-1h]
	jnz	11E6h

l207F_11E3:
	or	bl,8h

l207F_11E6:
	cmp	al,[si+1h]
	jnz	11EEh

l207F_11EB:
	or	bl,2h

l207F_11EE:
	mov	[di],bl
	inc	si
	inc	di
	loop	11CCh

l207F_11F4:
	call	12D9h
	or	al,al
	js	11FEh

l207F_11FB:
	call	12F2h

l207F_11FE:
	mov	[di],bl
	inc	si
	inc	di
	mov	dx,6h

l207F_1205:
	call	12BAh
	or	al,al
	js	121Bh

l207F_120C:
	cmp	al,[si+8h]
	jnz	1214h

l207F_1211:
	or	bl,4h

l207F_1214:
	cmp	al,[si-8h]
	jnz	121Bh

l207F_1219:
	inc	bl

l207F_121B:
	mov	[di],bl
	inc	si
	inc	di
	mov	cx,6h

l207F_1222:
	xor	bl,bl
	mov	al,[si]
	or	al,al
	jns	1232h

l207F_122A:
	mov	bl,al
	sub	bl,80h
	jmp	1251h
207F:1231    90                                            .              

l207F_1232:
	cmp	al,[si-1h]
	jnz	123Ah

l207F_1237:
	or	bl,8h

l207F_123A:
	cmp	al,[si+8h]
	jnz	1242h

l207F_123F:
	or	bl,4h

l207F_1242:
	cmp	al,[si+1h]
	jnz	124Ah

l207F_1247:
	or	bl,2h

l207F_124A:
	cmp	al,[si-8h]
	jnz	1251h

l207F_124F:
	inc	bl

l207F_1251:
	mov	[di],bl
	inc	si
	inc	di
	loop	1222h

l207F_1257:
	call	12D9h
	or	al,al
	js	126Dh

l207F_125E:
	cmp	al,[si+8h]
	jnz	1266h

l207F_1263:
	or	bl,4h

l207F_1266:
	cmp	al,[si-8h]
	jnz	126Dh

l207F_126B:
	inc	bl

l207F_126D:
	mov	[di],bl
	inc	si
	inc	di
	dec	dx
	jnz	1205h

l207F_1274:
	call	12BAh
	or	al,al
	js	127Eh

l207F_127B:
	call	1303h

l207F_127E:
	mov	[di],bl
	inc	si
	inc	di
	mov	cx,6h

l207F_1285:
	xor	bl,bl
	mov	al,[si]
	or	al,al
	jns	1294h

l207F_128D:
	mov	bl,al
	sub	bl,80h
	jnz	12A7h

l207F_1294:
	cmp	al,[si-1h]
	jnz	129Ch

l207F_1299:
	or	bl,8h

l207F_129C:
	cmp	al,[si+1h]
	jnz	12A4h

l207F_12A1:
	or	bl,2h

l207F_12A4:
	call	1303h

l207F_12A7:
	mov	[di],bl
	inc	si
	inc	di
	loop	1285h

l207F_12AD:
	call	12D9h
	or	al,al
	js	12B7h

l207F_12B4:
	call	1303h

l207F_12B7:
	mov	[di],bl
	ret

;; fn207F_12BA: 207F:12BA
;;   Called from:
;;     207F:11BB (in fn207F_11BB)
;;     207F:1205 (in fn207F_11BB)
;;     207F:1274 (in fn207F_11BB)
fn207F_12BA proc
	xor	bl,bl
	mov	al,[si]
	or	al,al
	js	12D3h

l207F_12C2:
	cmp	al,[si-39h]
	jnz	12CAh

l207F_12C7:
	or	bl,8h

l207F_12CA:
	cmp	al,[si+1h]
	jnz	12D2h

l207F_12CF:
	or	bl,2h

l207F_12D2:
	ret

l207F_12D3:
	mov	bl,al
	sub	bl,80h
	ret

;; fn207F_12D9: 207F:12D9
;;   Called from:
;;     207F:11F4 (in fn207F_11BB)
;;     207F:1257 (in fn207F_11BB)
;;     207F:12AD (in fn207F_11BB)
fn207F_12D9 proc
	xor	bl,bl
	mov	al,[si]
	or	al,al
	js	12D3h

l207F_12E1:
	cmp	al,[si-1h]
	jnz	12E9h

l207F_12E6:
	or	bl,8h

l207F_12E9:
	cmp	al,[si+39h]
	jnz	12F1h

l207F_12EE:
	or	bl,2h

l207F_12F1:
	ret

;; fn207F_12F2: 207F:12F2
;;   Called from:
;;     207F:11C2 (in fn207F_11BB)
;;     207F:11DB (in fn207F_11BB)
;;     207F:11FB (in fn207F_11BB)
fn207F_12F2 proc
	cmp	al,[si+0FF78h]
	jnz	12FAh

l207F_12F8:
	inc	bl

l207F_12FA:
	cmp	al,[si+8h]
	jnz	1302h

l207F_12FF:
	or	bl,4h

l207F_1302:
	ret

;; fn207F_1303: 207F:1303
;;   Called from:
;;     207F:127B (in fn207F_11BB)
;;     207F:12A4 (in fn207F_11BB)
;;     207F:12B4 (in fn207F_11BB)
fn207F_1303 proc
	cmp	al,[si-8h]
	jnz	130Ah

l207F_1308:
	inc	bl

l207F_130A:
	cmp	al,[si+88h]
	jnz	1313h

l207F_1310:
	or	bl,4h

l207F_1313:
	ret

;; fn207F_1314: 207F:1314
;;   Called from:
;;     0800:0480 (in fn0800_0000)
;;     0800:230C (in fn0800_218F)
;;     0800:3F6C (in fn0800_3D40)
;;     0800:5013 (in fn0800_4DC7)
;;     0DAB:0D5B (in fn0DAB_0D3D)
;;     0FDC:0839 (in fn0FDC_0629)
;;     0FDC:13C3 (in fn0FDC_134B)
;;     135D:015F (in fn135D_0004)
;;     135D:024A (in fn135D_01E9)
;;     135D:0763 (in fn135D_055A)
;;     135D:08D1 (in fn135D_079C)
;;     135D:0D0F (in fn135D_0AB6)
;;     1631:034B (in fn1631_032F)
;;     1631:1C24 (in fn1631_1BFE)
;;     183B:04FE (in fn183B_000A)
;;     183B:074D (in fn183B_000A)
;;     183B:0873 (in fn183B_000A)
;;     183B:135D (in fn183B_000A)
;;     183B:17C2 (in fn183B_1774)
;;     183B:2963 (in fn183B_28DB)
;;     183B:2ACD (in fn183B_2AA3)
;;     1AE8:1241 (in fn1AE8_000C)
;;     1AE8:1CE9 (in fn1AE8_12C7)
;;     1CD3:0102 (in fn1CD3_0004)
fn207F_1314 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[02CFh],ax
	mov	bx,[bp+8h]
	mov	[02D1h],bx
	shr	bl,1h
	shr	bl,1h
	shr	bl,1h
	shr	bl,1h
	mov	[02CEh],bl
	shr	al,1h
	shr	al,1h
	shr	al,1h
	shr	al,1h
	mov	[02CDh],al
	mov	di,7ADh
	dec	al
	dec	bl
	call	13D9h
	mov	[07A4h],al
	mov	bl,[02CEh]
	mov	al,[02CDh]
	dec	bl
	call	13D9h
	mov	[07A5h],al
	mov	bl,[02CEh]
	dec	bl
	mov	al,[02CDh]
	inc	al
	call	13D9h
	add	di,0A8h
	mov	[07A6h],al
	mov	bl,[02CEh]
	mov	al,[02CDh]
	dec	al
	call	13D9h
	mov	[07A7h],al
	mov	bl,[02CEh]
	mov	al,[02CDh]
	call	13D9h
	mov	[07A8h],al
	mov	bl,[02CEh]
	mov	al,[02CDh]
	inc	al
	call	13D9h
	add	di,0A8h
	mov	[07A9h],al
	mov	bl,[02CEh]
	inc	bl
	mov	al,[02CDh]
	dec	al
	call	13D9h
	mov	[07AAh],al
	mov	bl,[02CEh]
	inc	bl
	mov	al,[02CDh]
	call	13D9h
	mov	[07ABh],al
	mov	bl,[02CEh]
	inc	bl
	mov	al,[02CDh]
	inc	al
	call	13D9h
	mov	[07ACh],al
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_13D9: 207F:13D9
;;   Called from:
;;     207F:134A (in fn207F_1314)
;;     207F:1359 (in fn207F_1314)
;;     207F:136A (in fn207F_1314)
;;     207F:137D (in fn207F_1314)
;;     207F:138A (in fn207F_1314)
;;     207F:1399 (in fn207F_1314)
;;     207F:13AE (in fn207F_1314)
;;     207F:13BD (in fn207F_1314)
;;     207F:13CE (in fn207F_1314)
fn207F_13D9 proc
	mov	si,424h
	mov	cl,bl
	mov	ch,al
	add	cl,ch
	mov	ch,cl
	and	cl,3h
	mov	[0273h],cl
	shl	ch,1h
	shl	ch,1h
	and	ch,10h
	mov	[0272h],ch
	xor	dh,dh
	mov	dl,bl
	shl	dl,1h
	shl	dl,1h
	shl	dl,1h
	add	si,dx
	cmp	bl,0FFh
	jnz	140Dh

l207F_1407:
	mov	si,364h
	add	si,38h

l207F_140D:
	cmp	bl,8h
	jnz	1415h

l207F_1412:
	mov	si,4E4h

l207F_1415:
	mov	dl,al
	cmp	al,0FFh
	jnz	1420h

l207F_141B:
	mov	dl,7h
	sub	si,40h

l207F_1420:
	cmp	al,8h
	jnz	1429h

l207F_1424:
	xor	dl,dl
	add	si,40h

l207F_1429:
	add	si,dx
	xor	dl,dl
	mov	ch,[si]
	mov	[02C9h],ch
	mov	dh,ch
	shr	dx,1h
	shr	dx,1h
	sub	si,324h
	add	si,564h
	mov	bl,[si]
	mov	[02CAh],bl
	mov	si,0C1Dh
	or	bl,bl
	js	1466h

l207F_144E:
	jz	145Fh

l207F_1450:
	cmp	bl,10h
	jz	1469h

l207F_1455:
	sub	bl,10h
	cmp	bl,31h
	jc	145Fh

l207F_145D:
	mov	bl,30h

l207F_145F:
	cmp	byte ptr [0273h],0h
	jnz	146Eh

l207F_1466:
	jmp	153Ah

l207F_1469:
	mov	bl,70h
	jmp	153Ah

l207F_146E:
	cmp	byte ptr [0273h],2h
	jnz	14AFh

l207F_1475:
	push	di
	push	bx
	mov	di,20DDh
	add	di,7h
	xor	bh,bh
	mov	bl,ch
	mov	ch,[bx+211Dh]
	xor	cl,cl
	shr	cx,1h
	shr	cx,1h
	add	si,cx
	mov	al,8h

l207F_148F:
	mov	cx,8h
	xor	bh,bh

l207F_1494:
	mov	bl,[si]
	cmp	bl,40h
	jnc	149Fh

l207F_149B:
	mov	bl,[bx+211Dh]

l207F_149F:
	mov	[di],bl
	inc	si
	dec	di
	loop	1494h

l207F_14A5:
	add	di,10h
	dec	al
	jnz	148Fh

l207F_14AC:
	jmp	1533h

l207F_14AF:
	cmp	byte ptr [0273h],1h
	jnz	14F0h

l207F_14B6:
	push	di
	push	bx
	mov	di,20DDh
	add	di,38h
	xor	bh,bh
	mov	bl,ch
	mov	ch,[bx+213Dh]
	xor	cl,cl
	shr	cx,1h
	shr	cx,1h
	add	si,cx
	mov	al,8h

l207F_14D0:
	mov	cx,8h
	xor	bh,bh

l207F_14D5:
	mov	bl,[si]
	cmp	bl,40h
	jnc	14E0h

l207F_14DC:
	mov	bl,[bx+213Dh]

l207F_14E0:
	mov	[di],bl
	inc	si
	inc	di
	loop	14D5h

l207F_14E6:
	sub	di,10h
	dec	al
	jnz	14D0h

l207F_14ED:
	jmp	1533h
207F:14EF                                              90                .

l207F_14F0:
	cmp	byte ptr [0273h],3h
	jnz	153Ah

l207F_14F7:
	push	di
	push	bx
	mov	di,20DDh
	add	di,3Fh
	xor	bh,bh
	mov	bl,ch
	mov	bl,[bx+213Dh]
	mov	ch,[bx+211Dh]
	xor	cl,cl
	shr	cx,1h
	shr	cx,1h
	add	si,cx
	mov	al,8h

l207F_1515:
	mov	cx,8h
	xor	bh,bh

l207F_151A:
	mov	bl,[si]
	cmp	bl,40h
	jnc	1529h

l207F_1521:
	mov	bl,[bx+213Dh]
	mov	bl,[bx+211Dh]

l207F_1529:
	mov	[di],bl
	inc	si
	dec	di
	loop	151Ah

l207F_152F:
	dec	al
	jnz	1515h

l207F_1533:
	mov	si,20DDh
	pop	bx
	pop	di
	xor	dx,dx

l207F_153A:
	add	si,dx
	push	es
	mov	ax,ds
	mov	es,ax
	mov	bh,bl
	cld
	mov	dx,8h
	mov	cx,4h
	or	bl,bl
	js	1556h

l207F_154E:
	cmp	bl,70h
	jnz	1565h

l207F_1553:
	mov	si,209Dh

l207F_1556:
	rep movsw
	add	di,10h
	mov	cx,4h
	dec	dl
	jnz	1556h

l207F_1562:
	jmp	157Fh
207F:1564             90                                      .           

l207F_1565:
	mov	ah,[0272h]
	mov	cx,8h

l207F_156C:
	lodsb
	cmp	al,40h
	jnc	1575h

l207F_1571:
	and	al,0Fh
	add	al,bl

l207F_1575:
	stosb
	loop	156Ch

l207F_1578:
	add	di,10h
	dec	dl
	jnz	1565h

l207F_157F:
	sub	di,0B8h
	pop	es
	mov	al,[02C9h]
	or	al,[02CAh]
	ret

;; fn207F_158C: 207F:158C
;;   Called from:
;;     0800:17C7 (in fn0800_17BB)
;;     0800:2218 (in fn0800_218F)
fn207F_158C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[0A44Dh]
	dec	al
	js	15A4h

l207F_159E:
	mov	[0A44Dh],ax

l207F_15A1:
	jmp	1636h

l207F_15A4:
	cmp	ah,0h
	jz	15A1h

l207F_15A9:
	sub	ah,10h
	mov	al,7Fh
	mov	[0A44Dh],ax
	push	es
	mov	ax,ds
	mov	es,ax
	mov	si,6E4h
	sub	si,2h
	mov	di,764h
	add	di,3Eh
	mov	cx,0C0h
	std

l207F_15C6:
	rep movsw

l207F_15C8:
	cld
	pop	es
	mov	di,2D3h
	mov	ax,[0A44Dh]
	mov	bx,[0A44Bh]
	or	ah,bh
	mov	al,ah
	xor	ah,ah
	mov	si,ax
	add	si,0B0Bh
	sub	si,11h
	call	18D8h
	push	si
	mov	si,564h
	call	0BFBh
	pop	si
	inc	si
	mov	di,2D3h
	call	18D8h
	push	si
	mov	si,5A4h
	call	0BFBh
	pop	si
	inc	si
	mov	di,2D3h
	call	18D8h
	mov	si,5E4h
	call	0BFBh
	call	1886h
	mov	si,9F3h
	mov	ax,100h
	mov	[si],ax
	add	si,2h
	inc	ah
	mov	[si],ah
	inc	si
	mov	ax,[0A44Dh]
	or	ax,[0A44Bh]
	mov	al,ah
	xor	ah,ah
	sub	al,11h
	mov	[si],al
	inc	si
	inc	al
	mov	[si],al
	inc	si
	inc	al
	mov	[si],al

l207F_1636:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_163B: 207F:163B
;;   Called from:
;;     0800:17DB (in fn0800_17BB)
;;     0800:2223 (in fn0800_218F)
fn207F_163B proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[0A44Dh]
	inc	al
	js	1653h

l207F_164D:
	mov	[0A44Dh],ax

l207F_1650:
	jmp	16DEh

l207F_1653:
	cmp	ah,0F0h
	jz	1650h

l207F_1658:
	add	ah,10h
	xor	al,al
	mov	[0A44Dh],ax
	push	es
	mov	ax,ds
	mov	es,ax
	mov	si,624h
	mov	di,564h
	mov	cx,0C0h
	cld
	rep movsw
	pop	es
	mov	di,2D3h
	mov	ax,[0A44Dh]
	mov	bx,[0A44Bh]
	or	ah,bh
	mov	al,ah
	xor	ah,ah
	mov	si,ax
	add	si,0B0Bh
	add	si,0Fh
	call	18D8h
	push	si
	mov	si,6E4h
	call	0BFBh
	pop	si
	inc	si
	mov	di,2D3h
	call	18D8h
	push	si
	mov	si,724h
	call	0BFBh
	pop	si
	inc	si
	mov	di,2D3h
	call	18D8h
	mov	si,764h
	call	0BFBh
	call	1886h
	mov	si,9F3h
	mov	ax,706h
	mov	[si],ax
	add	si,2h
	inc	ah
	mov	[si],ah
	inc	si
	mov	ax,[0A44Dh]
	or	ax,[0A44Bh]
	mov	al,ah
	xor	ah,ah
	add	al,0Fh
	mov	[si],al
	inc	si
	inc	al
	mov	[si],al
	inc	si
	inc	al
	mov	[si],al

l207F_16DE:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_16E3: 207F:16E3
;;   Called from:
;;     0800:17EF (in fn0800_17BB)
;;     0800:2297 (in fn0800_218F)
fn207F_16E3 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[0A44Bh]
	dec	al
	js	16FBh

l207F_16F5:
	mov	[0A44Bh],ax

l207F_16F8:
	jmp	17C0h

l207F_16FB:
	cmp	ah,0h
	jz	16F8h

l207F_1700:
	dec	ah
	mov	al,7Fh
	mov	[0A44Bh],ax
	push	es
	mov	ax,ds
	mov	es,ax
	mov	si,5A4h
	mov	di,5E4h
	mov	cx,20h
	cld
	rep movsw
	mov	si,564h
	mov	di,5A4h
	mov	cx,20h
	rep movsw
	mov	si,664h
	mov	di,6A4h
	mov	cx,20h
	rep movsw
	mov	si,624h
	mov	di,664h
	mov	cx,20h
	rep movsw
	mov	si,724h
	mov	di,764h
	mov	cx,20h
	rep movsw
	mov	si,6E4h
	mov	di,724h
	mov	cx,20h
	rep movsw
	pop	es
	mov	di,2D3h
	mov	ax,[0A44Dh]
	mov	bx,[0A44Bh]
	or	ah,bh
	mov	al,ah
	xor	ah,ah
	mov	si,ax
	add	si,0B0Bh
	sub	si,11h
	call	18D8h
	push	si
	mov	si,564h
	call	0BFBh
	pop	si
	add	si,10h
	mov	di,2D3h
	call	18D8h
	push	si
	mov	si,624h
	call	0BFBh
	pop	si
	add	si,10h
	mov	di,2D3h
	call	18D8h
	mov	si,6E4h
	call	0BFBh
	call	1886h
	mov	si,9F3h
	mov	ax,300h
	mov	[si],ax
	add	si,2h
	mov	ah,6h
	mov	[si],ah
	inc	si
	mov	ax,[0A44Dh]
	or	ax,[0A44Bh]
	mov	al,ah
	xor	ah,ah
	sub	al,11h
	mov	[si],al
	inc	si
	add	al,10h
	mov	[si],al
	inc	si
	add	al,10h
	mov	[si],al

l207F_17C0:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_17C5: 207F:17C5
;;   Called from:
;;     0800:1803 (in fn0800_17BB)
;;     0800:228C (in fn0800_218F)
;;     0800:4266 (in fn0800_3FAE)
fn207F_17C5 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[0A44Bh]
	inc	al
	js	17DDh

l207F_17D7:
	mov	[0A44Bh],ax

l207F_17DA:
	jmp	1881h

l207F_17DD:
	cmp	ah,0Fh
	jz	17DAh

l207F_17E2:
	inc	ah
	xor	al,al
	mov	[0A44Bh],ax
	push	es
	mov	ax,ds
	mov	es,ax
	mov	si,5A4h
	mov	di,564h
	mov	cx,40h
	cld
	rep movsw
	mov	si,664h
	mov	di,624h
	mov	cx,40h
	rep movsw
	mov	si,724h
	mov	di,6E4h
	mov	cx,40h
	rep movsw
	pop	es
	mov	di,2D3h
	mov	ax,[0A44Dh]
	mov	bx,[0A44Bh]
	or	ah,bh
	mov	al,ah
	xor	ah,ah
	mov	si,ax
	add	si,0B0Bh
	sub	si,0Fh
	call	18D8h
	push	si
	mov	si,5E4h
	call	0BFBh
	pop	si
	add	si,10h
	mov	di,2D3h
	call	18D8h
	push	si
	mov	si,6A4h
	call	0BFBh
	pop	si
	add	si,10h
	mov	di,2D3h
	call	18D8h
	mov	si,764h
	call	0BFBh
	call	1886h
	mov	si,9F3h
	mov	ax,502h
	mov	[si],ax
	add	si,2h
	mov	ah,8h
	mov	[si],ah
	inc	si
	mov	ax,[0A44Dh]
	or	ax,[0A44Bh]
	mov	al,ah
	xor	ah,ah
	sub	al,0Fh
	mov	[si],al
	inc	si
	add	al,10h
	mov	[si],al
	inc	si
	add	al,10h
	mov	[si],al

l207F_1881:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1886: 207F:1886
;;   Called from:
;;     207F:11B3 (in fn207F_104E)
;;     207F:160A (in fn207F_158C)
;;     207F:16B2 (in fn207F_163B)
;;     207F:1794 (in fn207F_16E3)
;;     207F:1855 (in fn207F_17C5)
;;     207F:1DB3 (in fn207F_1DA8)
fn207F_1886 proc
	mov	si,564h
	mov	di,324h
	call	11BBh
	mov	si,5A4h
	mov	di,364h
	call	11BBh
	mov	si,5E4h
	mov	di,3A4h
	call	11BBh
	mov	si,624h
	mov	di,3E4h
	call	11BBh
	mov	si,664h
	mov	di,424h
	call	11BBh
	mov	si,6A4h
	mov	di,464h
	call	11BBh
	mov	si,6E4h
	mov	di,4A4h
	call	11BBh
	mov	si,724h
	mov	di,4E4h
	call	11BBh
	mov	si,764h
	mov	di,524h
	call	11BBh
	ret

;; fn207F_18D8: 207F:18D8
;;   Called from:
;;     207F:15E3 (in fn207F_158C)
;;     207F:15F2 (in fn207F_158C)
;;     207F:1601 (in fn207F_158C)
;;     207F:168B (in fn207F_163B)
;;     207F:169A (in fn207F_163B)
;;     207F:16A9 (in fn207F_163B)
;;     207F:1769 (in fn207F_16E3)
;;     207F:177A (in fn207F_16E3)
;;     207F:178B (in fn207F_16E3)
;;     207F:182A (in fn207F_17C5)
;;     207F:183B (in fn207F_17C5)
;;     207F:184C (in fn207F_17C5)
fn207F_18D8 proc
	mov	al,[si]
	mov	[di],al
	mov	al,[si+1h]
	mov	[di+8h],al
	mov	al,[si+10h]
	mov	[di+48h],al
	mov	al,[si+11h]
	mov	[di+50h],al
	ret

;; fn207F_18EF: 207F:18EF
;;   Called from:
;;     0800:0488 (in fn0800_0000)
;;     0800:3F74 (in fn0800_3D40)
;;     0800:501B (in fn0800_4DC7)
;;     0FDC:0841 (in fn0FDC_0629)
;;     0FDC:0983 (in fn0FDC_0629)
;;     0FDC:13CB (in fn0FDC_134B)
;;     135D:0167 (in fn135D_0004)
;;     135D:0252 (in fn135D_01E9)
;;     135D:076B (in fn135D_055A)
;;     135D:08D9 (in fn135D_079C)
;;     135D:0D17 (in fn135D_0AB6)
;;     1631:0353 (in fn1631_032F)
;;     1631:1F64 (in fn1631_1F09)
;;     183B:0506 (in fn183B_000A)
;;     183B:1365 (in fn183B_000A)
;;     183B:17CA (in fn183B_1774)
;;     1AE8:1277 (in fn1AE8_000C)
;;     1AE8:1D07 (in fn1AE8_12C7)
;;     1CD3:010A (in fn1CD3_0004)
fn207F_18EF proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	bp
	push	es
	mov	di,34h
	add	di,244Bh
	mov	word ptr [0A452h],8h
	mov	word ptr [0A454h],994h
	mov	word ptr [0A456h],494h
	mov	ax,ds
	cmp	word ptr [0B764h],2h
	jnz	1941h

l207F_191E:
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	ax,8h
	out	dx,ax
	mov	word ptr [0A452h],2h
	mov	word ptr [0A454h],265h
	mov	word ptr [0A456h],125h
	mov	ax,0AC00h
	mov	di,0Dh

l207F_1941:
	mov	es,ax
	cmp	word ptr [0B764h],0h
	jnz	1959h

l207F_194A:
	sub	di,1Ah
	shr	word ptr [0A452h],1h
	shr	word ptr [0A454h],1h
	shr	word ptr [0A456h],1h

l207F_1959:
	cld
	mov	ax,[0A44Dh]
	shr	al,1h
	and	ax,7h
	add	al,2h
	shl	ax,1h
	shl	ax,1h
	shl	ax,1h
	mov	bx,ax
	shl	ax,1h
	add	ax,bx
	mov	bx,[0A44Bh]
	shr	bl,1h
	and	bx,7h
	add	bl,2h
	add	bx,ax
	mov	[09EDh],bx
	add	bx,7ADh
	mov	byte ptr [0A44Fh],0h
	test	word ptr [0A44Dh],1h
	jz	19F5h

l207F_1993:
	test	word ptr [0A44Bh],1h
	jz	19B7h

l207F_199B:
	mov	dh,[bx]
	mov	byte ptr [0A450h],0h
	mov	byte ptr [0A44Fh],1h
	mov	byte ptr [0A451h],1h
	call	1AA8h
	inc	bx
	mov	ax,[0A452h]
	shr	ax,1h
	add	di,ax

l207F_19B7:
	mov	cx,0Dh

l207F_19BA:
	push	cx
	mov	dh,[bx]
	call	1ACEh
	add	di,[0A452h]
	inc	bx
	pop	cx
	loop	19BAh

l207F_19C8:
	test	word ptr [0A44Bh],1h
	jnz	19EEh

l207F_19D0:
	mov	dh,[bx]
	mov	dl,1h
	mov	byte ptr [0A44Fh],1h
	mov	byte ptr [0A450h],1h
	mov	byte ptr [0A451h],1h
	call	1AA8h
	mov	ax,[0A452h]
	shr	ax,1h
	add	di,ax
	inc	bx

l207F_19EE:
	add	bx,0Ah
	add	di,[0A456h]

l207F_19F5:
	xor	al,al
	mov	[0A44Fh],al
	mov	[0A450h],al
	mov	[0A451h],al
	mov	byte ptr [0A458h],0Ch

l207F_1A05:
	test	word ptr [0A44Bh],1h
	jz	1A1Fh

l207F_1A0D:
	mov	dh,[bx]
	mov	byte ptr [0A450h],0h
	call	1AA8h
	inc	bx
	mov	ax,[0A452h]
	shr	ax,1h
	add	di,ax

l207F_1A1F:
	mov	cx,0Dh

l207F_1A22:
	mov	dh,[bx]
	push	cx
	call	1AF4h
	inc	bx
	add	di,[0A452h]
	pop	cx
	loop	1A22h

l207F_1A30:
	test	word ptr [0A44Bh],1h
	jnz	1A4Ah

l207F_1A38:
	mov	dh,[bx]
	mov	byte ptr [0A450h],1h
	call	1AA8h
	inc	bx
	mov	ax,[0A452h]
	shr	ax,1h
	add	di,ax

l207F_1A4A:
	add	bx,0Ah
	add	di,[0A454h]
	dec	byte ptr [0A458h]
	jnz	1A05h

l207F_1A57:
	test	word ptr [0A44Dh],1h
	jnz	1AA1h

l207F_1A5F:
	mov	byte ptr [0A44Fh],1h
	test	word ptr [0A44Bh],1h
	jz	1A7Eh

l207F_1A6C:
	mov	dh,[bx]
	mov	byte ptr [0A450h],0h
	call	1AA8h
	inc	bx
	mov	ax,[0A452h]
	shr	ax,1h
	add	di,ax

l207F_1A7E:
	mov	cx,0Dh

l207F_1A81:
	push	cx
	mov	dh,[bx]
	call	1AF4h
	add	di,[0A452h]
	inc	bx
	pop	cx
	loop	1A81h

l207F_1A8F:
	test	word ptr [0A44Bh],1h
	jnz	1AA1h

l207F_1A97:
	mov	dh,[bx]
	mov	byte ptr [0A450h],1h
	call	1AA8h

l207F_1AA1:
	pop	es
	pop	bp
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1AA8: 207F:1AA8
;;   Called from:
;;     207F:19AC (in fn207F_18EF)
;;     207F:19E3 (in fn207F_18EF)
;;     207F:1A14 (in fn207F_18EF)
;;     207F:1A3F (in fn207F_18EF)
;;     207F:1A73 (in fn207F_18EF)
;;     207F:1A9E (in fn207F_18EF)
fn207F_1AA8 proc
	mov	bp,bx
	push	di
	xor	dl,dl
	cmp	word ptr [0B764h],2h
	jz	1AC7h

l207F_1AB4:
	shr	dx,1h
	add	dx,[026Eh]
	mov	si,dx
	mov	dx,[0270h]
	call	1BFCh
	pop	di
	mov	bx,bp
	ret

l207F_1AC7:
	call	1C83h
	pop	di
	mov	bx,bp
	ret

;; fn207F_1ACE: 207F:1ACE
;;   Called from:
;;     207F:19BD (in fn207F_18EF)
fn207F_1ACE proc
	mov	bp,bx
	push	di
	xor	dl,dl
	cmp	word ptr [0B764h],2h
	jz	1AEDh

l207F_1ADA:
	shr	dx,1h
	add	dx,[026Eh]
	mov	si,dx
	mov	dx,[0270h]
	call	1B94h
	pop	di
	mov	bx,bp
	ret

l207F_1AED:
	call	1BDFh
	pop	di
	mov	bx,bp
	ret

;; fn207F_1AF4: 207F:1AF4
;;   Called from:
;;     207F:1A25 (in fn207F_18EF)
;;     207F:1A84 (in fn207F_18EF)
fn207F_1AF4 proc
	mov	bp,bx
	push	di
	xor	dl,dl
	cmp	word ptr [0B764h],2h
	jz	1B13h

l207F_1B00:
	shr	dx,1h
	add	dx,[026Eh]
	mov	si,dx
	mov	dx,[0270h]
	call	1B1Ah
	pop	di
	mov	bx,bp
	ret

l207F_1B13:
	call	1B71h
	pop	di
	mov	bx,bp
	ret

;; fn207F_1B1A: 207F:1B1A
;;   Called from:
;;     207F:1B0C (in fn207F_1AF4)
fn207F_1B1A proc
	cmp	word ptr [0B764h],0h
	jz	1B54h

l207F_1B21:
	mov	cx,4h
	cmp	byte ptr [0A44Fh],0h
	jz	1B2Dh

l207F_1B2B:
	shr	cx,1h

l207F_1B2D:
	push	ds
	mov	ds,dx

l207F_1B30:
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	loop	1B30h

l207F_1B52:
	pop	ds
	ret

l207F_1B54:
	mov	cx,8h
	cmp	byte ptr [0A44Fh],0h
	jz	1B60h

l207F_1B5E:
	shr	cx,1h

l207F_1B60:
	push	ds
	mov	ds,dx

l207F_1B63:
	movsw
	movsw
	add	di,4Ch
	movsw
	movsw
	add	di,4Ch
	loop	1B63h

l207F_1B6F:
	pop	ds
	ret

;; fn207F_1B71: 207F:1B71
;;   Called from:
;;     207F:1B13 (in fn207F_1AF4)
fn207F_1B71 proc
	shr	dx,1h
	shr	dx,1h
	shr	dx,1h
	mov	si,dx
	mov	cx,10h
	cmp	byte ptr [0A44Fh],0h
	jz	1B85h

l207F_1B83:
	shr	cx,1h

l207F_1B85:
	push	ds
	mov	ax,0A400h
	mov	ds,ax

l207F_1B8B:
	movsb
	movsb
	add	di,26h
	loop	1B8Bh

l207F_1B92:
	pop	ds
	ret

;; fn207F_1B94: 207F:1B94
;;   Called from:
;;     207F:1AE6 (in fn207F_1ACE)
fn207F_1B94 proc
	cmp	word ptr [0B764h],0h
	jz	1BC8h

l207F_1B9B:
	add	si,40h
	mov	cx,2h
	push	ds
	mov	ds,dx

l207F_1BA4:
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	movsw
	movsw
	movsw
	movsw
	add	di,98h
	loop	1BA4h

l207F_1BC6:
	pop	ds
	ret

l207F_1BC8:
	add	si,20h
	mov	cx,4h
	push	ds
	mov	ds,dx

l207F_1BD1:
	movsw
	movsw
	add	di,4Ch
	movsw
	movsw
	add	di,4Ch
	loop	1BD1h

l207F_1BDD:
	pop	ds
	ret

;; fn207F_1BDF: 207F:1BDF
;;   Called from:
;;     207F:1AED (in fn207F_1ACE)
fn207F_1BDF proc
	shr	dx,1h
	shr	dx,1h
	shr	dx,1h
	add	dx,10h
	mov	si,dx
	mov	cx,8h
	push	ds
	mov	ax,0A400h
	mov	ds,ax

l207F_1BF3:
	movsb
	movsb
	add	di,26h
	loop	1BF3h

l207F_1BFA:
	pop	ds
	ret

;; fn207F_1BFC: 207F:1BFC
;;   Called from:
;;     207F:1AC0 (in fn207F_1AA8)
fn207F_1BFC proc
	cmp	word ptr [0B764h],0h
	jz	1C4Eh

l207F_1C03:
	cmp	byte ptr [0A451h],0h
	jz	1C0Dh

l207F_1C0A:
	add	si,40h

l207F_1C0D:
	cmp	byte ptr [0A450h],0h
	jnz	1C17h

l207F_1C14:
	add	si,4h

l207F_1C17:
	mov	cx,4h
	cmp	byte ptr [0A44Fh],0h
	jz	1C23h

l207F_1C21:
	shr	cx,1h

l207F_1C23:
	push	ds
	mov	ds,dx

l207F_1C26:
	movsw
	movsw
	add	si,4h
	add	di,9Ch
	movsw
	movsw
	add	si,4h
	add	di,9Ch
	movsw
	movsw
	add	si,4h
	add	di,9Ch
	movsw
	movsw
	add	si,4h
	add	di,9Ch
	loop	1C26h

l207F_1C4C:
	pop	ds
	ret

l207F_1C4E:
	cmp	byte ptr [0A451h],0h
	jz	1C58h

l207F_1C55:
	add	si,20h

l207F_1C58:
	cmp	byte ptr [0A450h],0h
	jnz	1C62h

l207F_1C5F:
	add	si,2h

l207F_1C62:
	mov	cx,8h
	cmp	byte ptr [0A44Fh],0h
	jz	1C6Eh

l207F_1C6C:
	shr	cx,1h

l207F_1C6E:
	push	ds
	mov	ds,dx

l207F_1C71:
	movsw
	add	di,4Eh
	add	si,2h
	movsw
	add	di,4Eh
	add	si,2h
	loop	1C71h

l207F_1C81:
	pop	ds
	ret

;; fn207F_1C83: 207F:1C83
;;   Called from:
;;     207F:1AC7 (in fn207F_1AA8)
fn207F_1C83 proc
	shr	dx,1h
	shr	dx,1h
	shr	dx,1h
	cmp	byte ptr [0A451h],0h
	jz	1C93h

l207F_1C90:
	add	dx,10h

l207F_1C93:
	cmp	byte ptr [0A450h],0h
	jnz	1C9Bh

l207F_1C9A:
	inc	dx

l207F_1C9B:
	mov	si,dx
	mov	cx,10h
	cmp	byte ptr [0A44Fh],0h
	jz	1CA9h

l207F_1CA7:
	shr	cx,1h

l207F_1CA9:
	push	ds
	mov	ax,0A400h
	mov	ds,ax

l207F_1CAF:
	movsb
	inc	si
	add	di,27h
	loop	1CAFh

l207F_1CB6:
	pop	ds
	ret

;; fn207F_1CB8: 207F:1CB8
;;   Called from:
;;     1F3D:0704 (in fn1F3D_06C3)
fn207F_1CB8 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,0B800h
	mov	es,ax
	mov	si,244Bh
	cmp	word ptr [0B764h],0h
	jz	1D10h

l207F_1CD3:
	mov	di,34h
	add	si,di
	mov	dx,32h
	mov	bx,36h

l207F_1CDE:
	mov	cx,bx
	rep movsw
	add	si,34h
	add	di,1F94h
	mov	cx,bx
	rep movsw
	add	si,34h
	add	di,1F94h
	mov	cx,bx
	rep movsw
	add	si,34h
	add	di,1F94h
	mov	cx,bx
	rep movsw
	add	si,34h
	sub	di,5FCCh
	dec	dx
	jnz	1CDEh

l207F_1D0D:
	jmp	1D34h
207F:1D0F                                              90                .

l207F_1D10:
	mov	di,1Ah
	add	si,di
	mov	dl,64h
	mov	bx,1Bh

l207F_1D1A:
	mov	cx,bx
	rep movsw
	add	si,1Ah
	add	di,1FCAh
	mov	cx,bx
	rep movsw
	add	si,1Ah
	sub	di,1FE6h
	dec	dl
	jnz	1D1Ah

l207F_1D34:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1D3A: 207F:1D3A
;;   Called from:
;;     1F3D:06FD (in fn1F3D_06C3)
fn207F_1D3A proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,0A000h
	mov	es,ax
	mov	di,68h
	mov	si,244Bh
	add	si,34h
	mov	dl,0C8h
	mov	bx,0FF0h

l207F_1D59:
	mov	cx,1Bh

l207F_1D5C:
	lodsw
	mov	dh,ah
	mov	ah,al
	and	ax,bx
	stosw
	mov	ah,dh
	mov	al,ah
	and	ax,bx
	stosw
	lodsw
	mov	dh,ah
	mov	ah,al
	and	ax,bx
	stosw
	mov	ah,dh
	mov	al,ah
	and	ax,bx
	stosw
	loop	1D5Ch

l207F_1D7C:
	add	di,68h
	add	si,34h
	dec	dl
	jnz	1D59h

l207F_1D86:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1D8C: 207F:1D8C
;;   Called from:
;;     0DAB:0C9E (in fn0DAB_0C8F)
fn207F_1D8C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[026Eh],ax
	mov	ax,[bp+8h]
	mov	[0270h],ax
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1DA8: 207F:1DA8
;;   Called from:
;;     0800:226B (in fn0800_218F)
;;     0800:22DF (in fn0800_218F)
;;     0800:34C7 (in fn0800_32B3)
;;     0800:3F55 (in fn0800_3D40)
;;     0800:423F (in fn0800_3FAE)
;;     0800:4FFC (in fn0800_4DC7)
;;     135D:0148 (in fn135D_0004)
;;     135D:074C (in fn135D_055A)
;;     135D:08BA (in fn135D_079C)
;;     183B:0FD0 (in fn183B_000A)
;;     183B:28D0 (in fn183B_2835)
;;     1CD3:1332 (in fn1CD3_0004)
fn207F_1DA8 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	call	1886h
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf
207F:1DBB                                  55 8B EC 57 56            U..WV
207F:1DC0 1E B8 6C 24 8E D8 8B 76 06 8B 56 08 8B 7E 0A 8B ..l$...v..V..~..
207F:1DD0 5E 0C 06 8E C3 1E 8E DA BA 58 00 B9 2C 00 AC 8A ^........X..,...
207F:1DE0 E0 25 F0 0F AB E2 F7 83 C6 74 81 C7 E8 00 4A 75 .%.......t....Ju
207F:1DF0 EA 1F 07 1F 5E 5F 5D CB                         ....^_].        

;; fn207F_1DF8: 207F:1DF8
;;   Called from:
;;     0800:2314 (in fn0800_218F)
;;     0DAB:0D63 (in fn0DAB_0D3D)
;;     1631:1C2C (in fn1631_1BFE)
;;     183B:0755 (in fn183B_000A)
;;     183B:296B (in fn183B_28DB)
;;     183B:2AD5 (in fn183B_2AA3)
fn207F_1DF8 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[0A44Dh]
	shr	al,1h
	and	ax,7h
	add	al,2h
	shl	ax,1h
	shl	ax,1h
	shl	ax,1h
	mov	bx,ax
	shl	ax,1h
	add	ax,bx
	mov	[09F1h],ax
	mov	bx,[0A44Bh]
	shr	bl,1h
	and	bx,7h
	add	bl,2h
	mov	[09EFh],bx
	add	bx,ax
	mov	[09EDh],bx
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1E37: 207F:1E37
;;   Called from:
;;     0800:1BB9 (in fn0800_1AFD)
fn207F_1E37 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,0A000h
	mov	es,ax
	mov	si,244Bh
	cmp	word ptr [0B764h],2h
	jc	1E78h

l207F_1E52:
	jz	1E7Eh

l207F_1E54:
	mov	di,0A08h
	mov	dl,58h
	mov	bx,0FF0h

l207F_1E5C:
	mov	cx,16h

l207F_1E5F:
	lodsw
	mov	dh,ah
	mov	ah,al
	and	ax,bx
	stosw
	mov	ah,dh
	mov	al,ah
	and	ax,bx
	stosw
	loop	1E5Fh

l207F_1E70:
	add	di,0E8h
	dec	dl
	jnz	1E5Ch

l207F_1E78:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_1E7E:
	mov	di,141h
	add	si,0F20h
	mov	dx,3CEh
	mov	ax,5h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax
	mov	ax,1h
	out	dx,ax
	mov	bx,58h
	mov	dx,3C4h

l207F_1E9A:
	mov	cx,0Bh

l207F_1E9D:
	mov	ax,102h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,202h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,402h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,802h
	out	dx,ax
	mov	al,es:[di]
	movsb
	loop	1E9Dh

l207F_1EC2:
	add	di,1Dh
	dec	bx
	jnz	1E9Ah

l207F_1EC8:
	mov	ax,0F02h
	out	dx,ax
	jmp	1E78h

;; fn207F_1ECE: 207F:1ECE
;;   Called from:
;;     1631:1F1F (in fn1631_1F09)
;;     1AE8:126A (in fn1AE8_000C)
;;     1AE8:1CFA (in fn1AE8_12C7)
fn207F_1ECE proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	di,[bp+6h]
	mov	ax,[bp+8h]
	mov	dx,[bp+0Ah]
	push	es
	mov	es,ax
	mov	si,7ADh
	push	ds
	or	dx,dx
	jz	1EF7h

l207F_1EED:
	xchg	di,si
	mov	dx,ds
	mov	ax,es
	mov	ds,ax
	mov	es,dx

l207F_1EF7:
	mov	cx,120h
	cld
	rep movsw
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1F04: 207F:1F04
;;   Called from:
;;     0800:4254 (in fn0800_3FAE)
;;     0800:4324 (in fn0800_3FAE)
fn207F_1F04 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	di,244Bh
	add	di,ax
	push	es
	mov	ax,ds
	mov	es,ax
	mov	si,664h
	mov	bx,424h
	mov	dx,8h

l207F_1F25:
	mov	cx,8h

l207F_1F28:
	lodsb
	cmp	al,90h
	jnc	1F39h

l207F_1F2D:
	cmp	al,10h
	jz	1F49h

l207F_1F31:
	cmp	al,20h
	jc	1F37h

l207F_1F35:
	sub	al,10h

l207F_1F37:
	or	al,[bx]

l207F_1F39:
	stosb
	inc	bx
	loop	1F28h

l207F_1F3D:
	add	di,20h
	dec	dx
	jnz	1F25h

l207F_1F43:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_1F49:
	mov	al,40h
	stosb
	inc	bx
	loop	1F28h

l207F_1F4F:
	jmp	1F3Dh

;; fn207F_1F51: 207F:1F51
;;   Called from:
;;     0800:45CF (in fn0800_45C2)
fn207F_1F51 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	sub	ax,90h
	xchg	al,ah
	shr	ax,1h
	shr	ax,1h
	add	ah,40h
	mov	di,244Bh
	add	ax,di
	mov	si,ax
	add	di,3FE0h
	mov	bx,215Dh
	push	es
	mov	ax,ds
	mov	es,ax
	mov	cx,20h

l207F_1F81:
	xor	ah,ah
	lodsb
	xlat
	mov	ah,al
	shl	ah,1h
	shl	ah,1h
	shl	ah,1h
	shl	ah,1h
	lodsb
	xlat
	or	al,ah
	stosb
	loop	1F81h

l207F_1F96:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1F9C: 207F:1F9C
;;   Called from:
;;     0DAB:0BCD (in fn0DAB_0B95)
;;     0DAB:0C01 (in fn0DAB_0B95)
fn207F_1F9C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	sti
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1FAD: 207F:1FAD
;;   Called from:
;;     0DAB:0BB8 (in fn0DAB_0B95)
;;     0DAB:0BE6 (in fn0DAB_0B95)
fn207F_1FAD proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	cli
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_1FBE: 207F:1FBE
;;   Called from:
;;     0800:3FBA (in fn0800_3FAE)
;;     0800:4FB6 (in fn0800_4DC7)
;;     0DAB:0CCE (in fn0DAB_0C8F)
;;     1467:0B3B (in fn1467_08A8)
;;     1CD3:16FB (in fn1CD3_0004)
fn207F_1FBE proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,0B800h
	mov	es,ax
	mov	di,0h
	mov	cx,2000h
	cmp	word ptr [0B764h],0h
	jz	2004h

l207F_1FDC:
	shl	ch,1h
	cmp	word ptr [0B764h],1h
	jz	2004h

l207F_1FE5:
	mov	ax,0A000h
	mov	es,ax
	cmp	word ptr [0B764h],2h
	jz	1FF6h

l207F_1FF1:
	shl	ch,1h
	jmp	2004h
207F:1FF5                90                                    .          

l207F_1FF6:
	mov	cx,1F40h
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax

l207F_2004:
	mov	ax,di

l207F_2006:
	rep stosw

l207F_2008:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_200E: 207F:200E
;;   Called from:
;;     1F3D:00A9 (in fn1F3D_0086)
fn207F_200E proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,0B800h
	mov	es,ax
	mov	si,[bp+6h]
	mov	[0B78Ah],si
	mov	bx,[bp+8h]
	mov	[0B78Ch],bx
	mov	ax,[bp+0Ah]
	shl	ax,1h
	shl	ax,1h
	mov	[0B792h],ax
	mov	ax,[bp+0Ch]
	mov	[0B794h],ax
	mov	ax,[bp+0Eh]
	shl	ax,1h
	shl	ax,1h
	mov	[0B79Ah],ax
	mov	cx,[bp+10h]
	mov	[0B79Ch],cx
	cmp	word ptr [0B764h],1h
	jz	208Ah

l207F_2055:
	jc	20D5h

l207F_2057:
	shl	word ptr [0B792h],1h
	mov	ax,0A000h
	mov	es,ax

l207F_2060:
	push	cx
	mov	ax,[0B794h]
	inc	word ptr [0B794h]
	mov	dx,140h
	mul	dx
	add	ax,[0B792h]
	mov	di,ax
	mov	cx,[0B79Ah]
	push	ds
	mov	ds,bx

l207F_207A:
	lodsb
	mov	ah,al
	and	ax,0FF0h
	stosw
	loop	207Ah

l207F_2083:
	pop	ds
	pop	cx
	loop	2060h

l207F_2087:
	jmp	2121h

l207F_208A:
	push	cx
	mov	ax,28h
	mov	dx,[0B794h]
	push	dx
	and	dl,0FCh
	mul	dl
	pop	dx
	and	dl,3h
	jz	20A5h

l207F_209E:
	mov	cl,dl

l207F_20A0:
	add	ah,20h
	loop	20A0h

l207F_20A5:
	add	ax,[0B792h]
	mov	di,ax
	mov	bx,[0B78Ah]
	push	bx
	mov	cx,[0B79Ah]
	add	bx,cx
	mov	[0B78Ah],bx
	pop	bx
	mov	si,bx
	push	ds
	mov	ax,[0B78Ch]
	mov	ds,ax
	rep movsb
	pop	ds
	mov	bx,[0B794h]
	inc	bx
	mov	[0B794h],bx
	pop	cx
	loop	208Ah

l207F_20D2:
	jmp	2121h
207F:20D4             90                                      .           

l207F_20D5:
	shr	word ptr [0B792h],1h
	shr	word ptr [0B79Ah],1h

l207F_20DD:
	push	cx
	mov	ax,28h
	mov	dx,[0B794h]
	push	dx
	and	dl,0FEh
	mul	dl
	pop	dx
	test	dl,1h
	jz	20F4h

l207F_20F1:
	add	ah,20h

l207F_20F4:
	add	ax,[0B792h]
	mov	di,ax
	mov	bx,[0B78Ah]
	push	bx
	mov	cx,[0B79Ah]
	add	bx,cx
	mov	[0B78Ah],bx
	pop	bx
	mov	si,bx
	push	ds
	mov	ax,[0B78Ch]
	mov	ds,ax
	rep movsb
	pop	ds
	mov	bx,[0B794h]
	inc	bx
	mov	[0B794h],bx
	pop	cx
	loop	20DDh

l207F_2121:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2127: 207F:2127
;;   Called from:
;;     1F3D:00E6 (in fn1F3D_00D5)
fn207F_2127 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	al,[bp+6h]
	mov	[0B772h],al
	mov	al,[bp+8h]
	mov	[0B775h],al
	cmp	word ptr [0B764h],0h
	jz	2177h

l207F_2145:
	cmp	word ptr [0B764h],2h
	jnc	2172h

l207F_214C:
	mov	bl,[0B772h]
	mov	al,bl
	mov	cx,4h
	shl	bl,cl
	or	bl,al
	mov	bh,bl
	mov	[0B773h],bx
	mov	bl,[0B775h]
	mov	al,bl
	mov	cx,4h
	shl	bl,cl
	or	bl,al
	mov	bh,bl
	mov	[0B776h],bx

l207F_2172:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_2177:
	mov	bl,[0B772h]
	and	bl,3h
	mov	al,bl
	mov	dl,[0B775h]
	and	dl,3h
	mov	ah,dl
	mov	cx,3h

l207F_218C:
	shl	al,1h
	shl	al,1h
	or	bl,al
	shl	ah,1h
	shl	ah,1h
	or	dl,ah
	loop	218Ch

l207F_219A:
	mov	bh,bl
	mov	[0B773h],bx
	mov	dh,dl
	mov	[0B776h],dx
	jmp	2172h

;; fn207F_21A8: 207F:21A8
;;   Called from:
;;     1F3D:01B3 (in fn1F3D_00D5)
fn207F_21A8 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	add	si,0A661h
	mov	ax,[bp+8h]
	mov	di,[bp+0Ah]
	add	di,ax
	push	es
	mov	ax,0B800h
	mov	es,ax
	mov	word ptr [0B77Ch],2h
	mov	dx,[0B773h]
	mov	bp,[0B776h]

l207F_21D6:
	mov	cx,4h

l207F_21D9:
	lodsw
	mov	bx,ax
	and	ax,dx
	not	bx
	and	bx,bp
	or	ax,bx
	stosw
	lodsw
	mov	bx,ax
	and	ax,dx
	not	bx
	and	bx,bp
	or	ax,bx
	mov	es:[di],ax
	add	di,1FFEh
	loop	21D9h

l207F_21F9:
	sub	di,7F60h
	dec	word ptr [0B77Ch]
	jnz	21D6h

l207F_2203:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2209: 207F:2209
;;   Called from:
;;     1F3D:0192 (in fn1F3D_00D5)
fn207F_2209 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	add	si,0A661h
	mov	ax,[bp+8h]
	mov	di,[bp+0Ah]
	add	di,ax
	push	es
	mov	ax,0B800h
	mov	es,ax
	mov	dx,2000h
	mov	bp,[0B773h]
	mov	cx,8h

l207F_2233:
	lodsw
	mov	bx,ax
	and	ax,bp
	not	bx
	and	bx,[0B776h]
	or	ax,bx
	mov	es:[di],ax
	add	di,dx
	xor	dx,0C050h
	loop	2233h

l207F_224B:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2251: 207F:2251
;;   Called from:
;;     1F3D:01CA (in fn1F3D_00D5)
fn207F_2251 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	add	si,0A661h
	mov	ax,[bp+8h]
	mov	di,[bp+0Ah]
	add	di,ax
	mov	bp,es
	mov	ax,0A000h
	mov	es,ax
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	bl,[0B772h]
	mov	bh,[0B775h]
	mov	cx,8h
	mov	al,cl

l207F_2286:
	mov	ah,[si]
	out	dx,ax
	mov	ah,bl
	xchg	es:[di],ah
	mov	ah,[si]
	not	ah
	out	dx,ax
	mov	ah,bh
	xchg	es:[di],ah
	inc	si
	add	di,28h
	loop	2286h

l207F_229E:
	mov	es,bp
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_22A5: 207F:22A5
;;   Called from:
;;     1F3D:01DF (in fn1F3D_00D5)
fn207F_22A5 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	si,[bp+6h]
	add	si,0A661h
	mov	ax,[bp+8h]
	mov	di,ax
	mov	ax,[bp+0Ah]
	add	di,ax
	mov	bp,es
	mov	ax,0A000h
	mov	es,ax
	mov	bl,8h
	mov	dh,[0B772h]
	mov	dl,[0B775h]

l207F_22D2:
	lodsb
	mov	cx,8h

l207F_22D6:
	shl	al,1h
	jc	22E3h

l207F_22DA:
	mov	es:[di],dl
	inc	di
	loop	22D6h

l207F_22E0:
	jmp	22E9h
207F:22E2       90                                          .             

l207F_22E3:
	mov	es:[di],dh
	inc	di
	loop	22D6h

l207F_22E9:
	add	di,138h
	dec	bl
	jnz	22D2h

l207F_22F1:
	mov	es,bp
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_22F8: 207F:22F8
;;   Called from:
;;     1F3D:04BE (in fn1F3D_049D)
fn207F_22F8 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	push	ds
	mov	ax,[bp+6h]
	mov	[0B78Ah],ax
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Ah]
	mov	[0B78Eh],ax
	mov	ax,[bp+0Ch]
	mov	[0B790h],ax
	mov	es,ax
	mov	di,[0B78Eh]
	mov	si,[0B78Ah]
	mov	ax,[0B78Ch]
	mov	ds,ax
	jmp	2336h
207F:232E                                           90                  . 

l207F_232F:
	inc	si
	mov	ax,[si]
	inc	si
	jmp	2347h
207F:2335                90                                    .          

l207F_2336:
	mov	dx,7D00h

l207F_2339:
	xor	bx,bx
	xor	ax,ax
	mov	al,[si]
	cmp	al,0h
	jz	232Fh

l207F_2343:
	jns	2348h

l207F_2345:
	neg	al

l207F_2347:
	dec	bx

l207F_2348:
	mov	cx,ax

l207F_234A:
	inc	si
	mov	al,[si]

l207F_234D:
	stosb
	dec	dx
	jz	2361h

l207F_2351:
	test	bx,1h
	jnz	235Ch

l207F_2357:
	loop	234Ah

l207F_2359:
	inc	si
	jmp	2339h

l207F_235C:
	loop	234Dh

l207F_235E:
	inc	si
	jmp	2339h

l207F_2361:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2368: 207F:2368
;;   Called from:
;;     1F3D:04D1 (in fn1F3D_049D)
fn207F_2368 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	push	ds
	mov	ax,[bp+6h]
	mov	[0B78Ah],ax
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Ah]
	mov	[0B78Eh],ax
	mov	ax,[bp+0Ch]
	mov	[0B790h],ax
	mov	es,ax
	mov	di,[0B78Eh]
	mov	si,[0B78Ah]
	mov	ax,[0B78Ch]
	mov	ds,ax
	jmp	23A6h
207F:239E                                           90                  . 

l207F_239F:
	inc	si
	mov	ax,[si]
	inc	si
	jmp	23B9h
207F:23A5                90                                    .          

l207F_23A6:
	mov	dx,7D00h
	mov	bl,0C8h

l207F_23AB:
	sub	bh,bh
	sub	ax,ax
	mov	al,[si]
	cmp	al,0h
	jz	239Fh

l207F_23B5:
	jns	23BBh

l207F_23B7:
	neg	al

l207F_23B9:
	dec	bh

l207F_23BB:
	mov	cx,ax

l207F_23BD:
	inc	si
	mov	al,[si]

l207F_23C0:
	mov	es:[di],al
	add	di,0A0h
	dec	bl
	jz	23DDh

l207F_23CB:
	dec	dx
	jz	23E5h

l207F_23CE:
	test	bh,1h
	jnz	23D8h

l207F_23D3:
	loop	23BDh

l207F_23D5:
	inc	si
	jmp	23ABh

l207F_23D8:
	loop	23C0h

l207F_23DA:
	inc	si
	jmp	23ABh

l207F_23DD:
	mov	bl,0C8h
	sub	di,7CFFh
	jmp	23CBh

l207F_23E5:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_23EC: 207F:23EC
;;   Called from:
;;     0800:1B26 (in fn0800_1AFD)
fn207F_23EC proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,[bp+6h]
	mov	[0B78Ah],ax
	mov	si,ax
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Ah]
	mov	di,ax
	mov	ax,[bp+0Ch]
	mov	es,ax
	mov	ax,[0B78Ch]
	push	ds
	mov	ds,ax
	jmp	2422h
207F:2418                         90                              .       

l207F_2419:
	inc	si
	mov	ax,[si]
	xchg	al,ah
	inc	si
	jmp	2433h
207F:2421    90                                            .              

l207F_2422:
	mov	dx,0F20h

l207F_2425:
	xor	bx,bx
	xor	ax,ax
	mov	al,[si]
	or	al,al
	jz	2419h

l207F_242F:
	jns	2434h

l207F_2431:
	neg	al

l207F_2433:
	dec	bx

l207F_2434:
	mov	cx,ax

l207F_2436:
	inc	si
	mov	al,[si]

l207F_2439:
	xor	es:[di],al
	inc	di
	dec	dx
	jz	244Eh

l207F_2440:
	or	bx,bx
	jnz	2449h

l207F_2444:
	loop	2436h

l207F_2446:
	inc	si
	jmp	2425h

l207F_2449:
	loop	2439h

l207F_244B:
	inc	si
	jmp	2425h

l207F_244E:
	pop	ds
	pop	es
	mov	ax,si
	inc	ax
	sub	ax,[0B78Ah]
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_245C: 207F:245C
;;   Called from:
;;     0DAB:1BE7 (in fn0DAB_1AFE)
;;     1E56:08F0 (in fn1E56_07CB)
;;     1F3D:00CB (in fn1F3D_0086)
;;     1F3D:06EC (in fn1F3D_06C3)
fn207F_245C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,[bp+6h]
	mov	[0B78Ah],ax
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Ah]
	mov	[0B78Eh],ax
	mov	ax,[bp+0Ch]
	mov	[0B790h],ax
	mov	ax,[bp+0Eh]
	cmp	word ptr [0B764h],2h
	jz	249Eh

l207F_248A:
	shl	ax,1h
	cmp	word ptr [0B764h],0h
	jz	249Eh

l207F_2493:
	shl	ax,1h
	cmp	word ptr [0B764h],1h
	jz	249Eh

l207F_249C:
	shl	ax,1h

l207F_249E:
	mov	[0B792h],ax
	mov	ax,[bp+10h]
	mov	[0B794h],ax
	mov	ax,[bp+12h]
	cmp	word ptr [0B764h],2h
	jz	24C5h

l207F_24B1:
	shl	ax,1h
	cmp	word ptr [0B764h],0h
	jz	24C5h

l207F_24BA:
	shl	ax,1h
	cmp	word ptr [0B764h],1h
	jz	24C5h

l207F_24C3:
	shl	ax,1h

l207F_24C5:
	mov	[0B79Ah],ax
	mov	ax,[bp+14h]
	mov	[0B79Ch],ax
	call	24D7h
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_24D7: 207F:24D7
;;   Called from:
;;     207F:24CE (in fn207F_245C)
fn207F_24D7 proc
	cmp	word ptr [0B764h],0h
	jnz	24E1h

l207F_24DE:
	jmp	26AEh

l207F_24E1:
	cmp	word ptr [0B764h],2h
	jz	24EBh

l207F_24E8:
	jmp	256Bh

l207F_24EB:
	mov	ax,[0B79Ah]
	add	ax,[0B792h]
	cmp	ax,29h
	jc	2501h

l207F_24F7:
	mov	ax,28h
	sub	ax,[0B792h]
	mov	[0B79Ah],ax

l207F_2501:
	mov	ax,[0B794h]
	add	ax,[0B79Ch]
	cmp	ax,0C9h
	jc	2517h

l207F_250D:
	mov	ax,0C8h
	sub	ax,[0B794h]
	mov	[0B79Ch],ax

l207F_2517:
	mov	ax,[0B792h]
	cmp	ax,28h
	jnc	2568h

l207F_251F:
	mov	ax,[0B794h]
	cmp	ax,0C8h
	jnc	2568h

l207F_2527:
	mov	dx,28h
	mul	dl
	add	ax,[0B792h]
	mov	di,[0B78Eh]
	add	di,ax
	mov	dx,[0B790h]
	mov	es,dx
	mov	si,ax
	add	si,[0B78Ah]
	mov	dx,3CEh
	mov	ax,105h
	out	dx,ax
	mov	bx,[0B79Ah]
	mov	dx,[0B79Ch]
	mov	ax,[0B78Ch]
	push	ds
	mov	ds,ax

l207F_2557:
	mov	cx,bx
	rep movsb
	mov	ax,28h
	sub	ax,bx
	add	si,ax
	add	di,ax
	dec	dx
	jnz	2557h

l207F_2567:
	pop	ds

l207F_2568:
	jmp	2629h

l207F_256B:
	cmp	word ptr [0B764h],1h
	jz	2575h

l207F_2572:
	jmp	262Ah

l207F_2575:
	mov	ax,[0B79Ah]
	add	ax,[0B792h]
	cmp	ax,0A1h
	jc	258Bh

l207F_2581:
	mov	ax,0A0h
	sub	ax,[0B792h]
	mov	[0B79Ah],ax

l207F_258B:
	mov	ax,[0B794h]
	add	ax,[0B79Ch]
	cmp	ax,0C9h
	jc	25A1h

l207F_2597:
	mov	ax,0C8h
	sub	ax,[0B794h]
	mov	[0B79Ch],ax

l207F_25A1:
	mov	ax,[0B792h]
	cmp	ax,0A0h
	jnc	2568h

l207F_25A9:
	mov	ax,[0B794h]
	cmp	ax,0C8h
	jnc	2629h

l207F_25B1:
	mov	bx,ax
	and	ax,0FCh
	mov	dx,28h
	mul	dl
	add	ax,[0B792h]
	and	bx,3h
	jz	25CDh

l207F_25C4:
	mov	cx,bx
	mov	ax,2000h
	mul	bx
	add	ax,cx

l207F_25CD:
	mov	di,[0B78Eh]
	add	di,ax
	mov	dx,[0B790h]
	mov	es,dx
	mov	si,ax
	add	si,[0B78Ah]
	mov	dx,[0B79Ah]
	mov	ax,2000h
	sub	ax,dx
	mov	[0B794h],ax
	mov	ax,dx
	sub	ax,0A0h
	add	ah,60h
	shr	dx,1h
	mov	[0B79Ah],dx
	mov	dx,[0B78Ch]

l207F_25FD:
	mov	cx,[0B79Ah]
	push	ds
	mov	ds,dx
	rep movsw
	pop	ds
	inc	bx
	and	bx,3h
	jz	261Eh

l207F_260D:
	add	si,[0B794h]
	add	di,[0B794h]
	sub	word ptr [0B79Ch],1h
	jnz	25FDh

l207F_261C:
	jz	2629h

l207F_261E:
	sub	si,ax
	sub	di,ax
	sub	word ptr [0B79Ch],1h
	jnz	25FDh

l207F_2629:
	ret

l207F_262A:
	mov	ax,[0B79Ah]
	add	ax,[0B792h]
	cmp	ax,141h
	jc	2640h

l207F_2636:
	mov	ax,140h
	sub	ax,[0B792h]
	mov	[0B79Ah],ax

l207F_2640:
	mov	ax,[0B794h]
	add	ax,[0B79Ch]
	cmp	ax,0C9h
	jc	2656h

l207F_264C:
	mov	ax,0C8h
	sub	ax,[0B794h]
	mov	[0B79Ch],ax

l207F_2656:
	mov	ax,[0B792h]
	cmp	ax,140h
	jnc	2629h

l207F_265E:
	mov	ax,[0B794h]
	cmp	ax,0C8h
	jnc	2629h

l207F_2666:
	mov	bx,ax
	mov	dx,140h
	mul	dx
	add	ax,[0B792h]
	mov	di,[0B78Eh]
	add	di,ax
	mov	dx,[0B790h]
	mov	es,dx
	mov	si,ax
	add	si,[0B78Ah]
	mov	bx,140h
	mov	dx,[0B79Ah]
	sub	bx,dx
	shr	dx,1h
	mov	[0B79Ah],dx
	mov	dx,[0B78Ch]

l207F_2696:
	mov	cx,[0B79Ah]
	push	ds
	mov	ds,dx
	rep movsw
	pop	ds
	add	si,bx
	add	di,bx
	sub	word ptr [0B79Ch],1h
	jnz	2696h

l207F_26AB:
	jmp	2629h

l207F_26AE:
	mov	ax,[0B79Ah]
	add	ax,[0B792h]
	cmp	ax,51h
	jc	26C4h

l207F_26BA:
	mov	ax,50h
	sub	ax,[0B792h]
	mov	[0B79Ah],ax

l207F_26C4:
	mov	ax,[0B794h]
	add	ax,[0B79Ch]
	cmp	ax,0C9h
	jc	26DAh

l207F_26D0:
	mov	ax,0C8h
	sub	ax,[0B794h]
	mov	[0B79Ch],ax

l207F_26DA:
	mov	ax,[0B792h]
	cmp	ax,50h
	jnc	275Bh

l207F_26E2:
	mov	ax,[0B794h]
	cmp	ax,0C8h
	jnc	275Bh

l207F_26EA:
	mov	bx,ax
	and	ax,0FEh
	mov	dx,28h
	mul	dl
	add	ax,[0B792h]
	and	bx,1h
	jz	2700h

l207F_26FD:
	add	ah,20h

l207F_2700:
	mov	di,[0B78Eh]
	add	di,ax
	mov	dx,[0B790h]
	mov	es,dx
	mov	si,ax
	add	si,[0B78Ah]
	mov	dx,[0B79Ah]
	mov	ax,2000h
	sub	ax,dx
	mov	[0B794h],ax
	mov	ax,dx
	sub	ax,50h
	add	ah,20h
	shr	dx,1h
	mov	[0B79Ah],dx
	mov	dx,[0B78Ch]

l207F_2730:
	mov	cx,[0B79Ah]
	push	ds
	mov	ds,dx
	rep movsw
	pop	ds
	xor	bx,1h
	jz	2750h

l207F_273F:
	add	si,[0B794h]
	add	di,[0B794h]
	sub	word ptr [0B79Ch],1h
	jnz	2730h

l207F_274E:
	jz	275Bh

l207F_2750:
	sub	si,ax
	sub	di,ax
	sub	word ptr [0B79Ch],1h
	jnz	2730h

l207F_275B:
	ret

;; fn207F_275C: 207F:275C
;;   Called from:
;;     0800:434C (in fn0800_3FAE)
;;     1E56:0066 (in fn1E56_0004)
;;     1E56:00A2 (in fn1E56_0004)
;;     1E56:00DE (in fn1E56_0004)
;;     1E56:0121 (in fn1E56_0004)
;;     1E56:0251 (in fn1E56_01E7)
fn207F_275C proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,0B800h
	mov	es,ax
	mov	si,[bp+6h]
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	cmp	word ptr [0B764h],0h
	jnz	2780h

l207F_277D:
	jmp	2820h

l207F_2780:
	cmp	word ptr [0B764h],2h
	jnz	278Ah

l207F_2787:
	jmp	284Dh

l207F_278A:
	cmp	word ptr [0B764h],3h
	jnz	27DEh

l207F_2791:
	mov	ax,0A000h
	mov	es,ax
	mov	ax,[bp+0Ah]
	shl	ax,1h
	shl	ax,1h
	shl	ax,1h
	mov	[0B792h],ax
	mov	ax,[bp+0Ch]
	mov	dx,0A00h
	mul	dx
	add	ax,[0B792h]
	mov	di,ax
	mov	cx,8h
	push	ds
	mov	ds,[0B78Ch]
	cld
	mov	dx,0FF0h
	mov	bx,138h

l207F_27BF:
	lodsb
	mov	ah,al
	and	ax,dx
	stosw
	lodsb
	mov	ah,al
	and	ax,dx
	stosw
	lodsb
	mov	ah,al
	and	ax,dx
	stosw
	lodsb
	mov	ah,al
	and	ax,dx
	stosw
	add	di,bx
	loop	27BFh

l207F_27DB:
	jmp	2819h
207F:27DD                                        90                    .  

l207F_27DE:
	mov	ax,[bp+0Ah]
	shl	ax,1h
	shl	ax,1h
	mov	[0B792h],ax
	mov	ax,[bp+0Ch]
	mov	dx,140h
	mul	dx
	add	ax,[0B792h]
	mov	di,ax
	mov	cx,2h
	push	ds
	mov	ds,[0B78Ch]
	cld

l207F_27FF:
	movsw
	movsw
	add	di,1FFCh
	movsw
	movsw
	add	di,1FFCh
	movsw
	movsw
	add	di,1FFCh
	movsw
	movsw
	sub	di,5F64h
	loop	27FFh

l207F_2819:
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_2820:
	mov	ax,[bp+0Ah]
	shl	ax,1h
	mov	[0B792h],ax
	mov	ax,[bp+0Ch]
	mov	dx,140h
	mul	dx
	add	ax,[0B792h]
	mov	di,ax
	mov	cx,4h
	push	ds
	mov	ds,[0B78Ch]
	cld

l207F_283F:
	movsw
	add	di,1FFEh
	movsw
	sub	di,1FB2h
	loop	283Fh

l207F_284B:
	jmp	2819h

l207F_284D:
	mov	dx,3CEh
	mov	ax,5h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax
	mov	ax,1h
	out	dx,ax
	mov	ax,0A000h
	mov	es,ax
	mov	di,[bp+0Ah]
	mov	ax,[bp+0Ch]
	mov	dx,140h
	mul	dx
	add	di,ax
	push	ds
	mov	ds,[0B78Ch]
	mov	cx,8h
	mov	dx,3C4h

l207F_2879:
	mov	ax,102h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,202h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,402h
	out	dx,ax
	mov	al,es:[di]
	movsb
	dec	di
	mov	ax,802h
	out	dx,ax
	mov	al,es:[di]
	movsb
	add	di,27h
	loop	2879h

l207F_28A1:
	mov	ax,0F02h
	out	dx,ax
	jmp	2819h

;; fn207F_28A8: 207F:28A8
;;   Called from:
;;     0800:2481 (in fn0800_240B)
fn207F_28A8 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[0B78Ah],ax
	mov	ax,[bp+8h]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Ah]
	mov	[0B78Eh],ax
	mov	ax,[bp+0Ch]
	mov	[0B790h],ax
	mov	di,[0B78Eh]
	mov	ax,[0B790h]
	push	es
	mov	es,ax
	mov	si,[0B78Ah]
	mov	cx,40h
	push	ds
	mov	ds,[0B78Ch]
	cld
	rep movsw
	pop	ds
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_28EB: 207F:28EB
;;   Called from:
;;     0800:0738 (in fn0800_051B)
;;     0800:09E8 (in fn0800_051B)
;;     0800:0BB3 (in fn0800_051B)
;;     0800:0E3E (in fn0800_051B)
;;     0800:1177 (in fn0800_0E4B)
;;     0800:1600 (in fn0800_0E4B)
;;     0800:1724 (in fn0800_0E4B)
;;     0800:2C44 (in fn0800_2A93)
;;     1631:1FAC (in fn1631_1F73)
fn207F_28EB proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	cmp	word ptr [0B764h],0h
	jnz	2900h

l207F_28FD:
	jmp	2A1Eh

l207F_2900:
	push	es
	mov	ax,[bp+6h]
	mov	[0B78Eh],ax
	mov	ax,[bp+8h]
	mov	[0B790h],ax
	mov	ax,[bp+0Ah]
	mov	[0B78Ah],ax
	mov	ax,[bp+0Ch]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Eh]
	sar	ax,1h
	mov	[0B792h],ax
	mov	ax,[bp+10h]
	mov	[0B794h],ax
	push	ds
	mov	si,[0B78Ah]
	inc	si
	mov	ax,[0B78Ch]
	mov	ds,ax
	lodsw
	inc	si
	pop	ds
	inc	al
	push	ax
	and	ax,0FFh
	mov	[0B79Ch],ax
	pop	ax
	xchg	ah,al
	and	ax,0FFh
	shl	ax,1h
	shl	ax,1h
	mov	[0B79Ah],ax
	mov	[0B79Eh],ax
	mov	ax,[0B794h]
	cmp	ax,0h
	jns	2977h

l207F_2956:
	neg	ax
	cmp	ax,[0B79Ch]
	jnc	29BDh

l207F_295E:
	mov	dx,[0B79Ah]
	mul	dl
	add	si,ax
	mov	ax,[0B79Ch]
	add	ax,[0B794h]
	js	29BDh

l207F_296F:
	mov	[0B79Ch],ax
	xor	ax,ax
	mov	[0B794h],ax

l207F_2977:
	mov	ax,0C8h
	sub	ax,[0B794h]
	js	29BDh

l207F_2980:
	jz	29BDh

l207F_2982:
	cmp	ax,[0B79Ch]
	jnc	298Bh

l207F_2988:
	mov	[0B79Ch],ax

l207F_298B:
	mov	ax,[0B792h]
	cmp	ax,0h
	jns	29A6h

l207F_2993:
	add	[0B79Ah],ax
	neg	ax
	add	si,ax
	cmp	ax,[0B79Eh]
	jnc	29BDh

l207F_29A1:
	xor	ax,ax
	mov	[0B792h],ax

l207F_29A6:
	mov	ax,0A0h
	sub	ax,[0B792h]
	js	29BDh

l207F_29AF:
	jz	29BDh

l207F_29B1:
	cmp	ax,[0B79Ah]
	jnc	29C0h

l207F_29B7:
	mov	[0B79Ah],ax
	jmp	29C0h
207F:29BC                                     90                      .   

l207F_29BD:
	jmp	2A18h
207F:29BF                                              90                .

l207F_29C0:
	mov	ax,[0B794h]
	mov	dx,0A0h
	mul	dl
	add	ax,[0B792h]
	add	ax,[0B78Eh]
	mov	di,ax
	mov	dx,[0B790h]
	mov	es,dx
	mov	ax,0A0h
	sub	ax,[0B79Ah]
	mov	[0B794h],ax
	mov	dx,[0B78Ch]
	mov	bx,0B661h

l207F_29E9:
	mov	cx,[0B79Ah]
	push	bp
	mov	bp,es

l207F_29F0:
	mov	es,dx
	mov	al,es:[si]
	mov	ah,al
	xlat
	mov	es,bp
	and	es:[di],al
	or	es:[di],ah
	inc	si
	inc	di
	loop	29F0h

l207F_2A04:
	pop	bp
	add	si,[0B79Eh]
	sub	si,[0B79Ah]
	add	di,[0B794h]
	sub	word ptr [0B79Ch],1h
	jnz	29E9h

l207F_2A18:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_2A1E:
	push	es
	mov	ax,[bp+6h]
	mov	[0B78Eh],ax
	mov	ax,[bp+8h]
	mov	[0B790h],ax
	mov	ax,[bp+0Ah]
	mov	[0B78Ah],ax
	mov	ax,[bp+0Ch]
	mov	[0B78Ch],ax
	mov	ax,[bp+0Eh]
	sar	ax,1h
	sar	ax,1h
	mov	[0B792h],ax
	mov	ax,[bp+10h]
	mov	[0B794h],ax
	push	ds
	mov	si,[0B78Ah]
	inc	si
	mov	ax,[0B78Ch]
	mov	ds,ax
	lodsw
	inc	si
	mov	bx,si
	pop	ds
	inc	al
	push	ax
	and	ax,0FFh
	mov	[0B79Ch],ax
	mov	dx,ax
	pop	ax
	xchg	ah,al
	and	ax,0FFh
	shl	ax,1h
	mov	[0B79Ah],ax
	mov	[0B79Eh],ax
	xor	ah,ah
	mul	dl
	add	bx,ax
	mov	ax,[0B794h]
	cmp	ax,0h
	jns	2AA1h

l207F_2A7E:
	neg	ax
	cmp	ax,[0B79Ch]
	jnc	2AE9h

l207F_2A86:
	mov	dx,[0B79Ah]
	mul	dl
	add	si,ax
	add	bx,ax
	mov	ax,[0B79Ch]
	add	ax,[0B794h]
	js	2AE9h

l207F_2A99:
	mov	[0B79Ch],ax
	xor	ax,ax
	mov	[0B794h],ax

l207F_2AA1:
	mov	ax,[0B780h]
	sub	ax,[0B794h]
	js	2AE9h

l207F_2AAA:
	jz	2AE9h

l207F_2AAC:
	cmp	ax,[0B79Ch]
	jnc	2AB5h

l207F_2AB2:
	mov	[0B79Ch],ax

l207F_2AB5:
	mov	ax,[0B792h]
	cmp	ax,0h
	jns	2AD2h

l207F_2ABD:
	add	[0B79Ah],ax
	neg	ax
	add	si,ax
	add	bx,ax
	cmp	ax,[0B79Eh]
	jnc	2AE9h

l207F_2ACD:
	xor	ax,ax
	mov	[0B792h],ax

l207F_2AD2:
	mov	ax,50h
	sub	ax,[0B792h]
	js	2AE9h

l207F_2ADB:
	jz	2AE9h

l207F_2ADD:
	cmp	ax,[0B79Ah]
	jnc	2AECh

l207F_2AE3:
	mov	[0B79Ah],ax
	jmp	2AECh
207F:2AE8                         90                              .       

l207F_2AE9:
	jmp	2A18h

l207F_2AEC:
	mov	ax,[0B794h]
	mov	dx,50h
	mul	dl
	add	ax,[0B792h]
	add	ax,[0B78Eh]
	mov	di,ax
	mov	dx,[0B790h]
	mov	es,dx
	mov	ax,50h
	sub	ax,[0B79Ah]
	mov	[0B794h],ax
	mov	dx,[0B78Ch]

l207F_2B12:
	mov	cx,[0B79Ah]
	push	ds
	mov	ds,dx

l207F_2B19:
	mov	al,[bx]
	inc	bx
	and	es:[di],al
	lodsb
	or	es:[di],al
	inc	di
	loop	2B19h

l207F_2B26:
	pop	ds
	add	si,[0B79Eh]
	sub	si,[0B79Ah]
	add	bx,[0B79Eh]
	sub	bx,[0B79Ah]
	add	di,[0B794h]
	sub	word ptr [0B79Ch],1h
	jnz	2B12h

l207F_2B42:
	jmp	2A18h

;; fn207F_2B45: 207F:2B45
;;   Called from:
;;     1F3D:054F (in fn1F3D_0525)
fn207F_2B45 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	cmp	word ptr [0B764h],1h
	jnz	2B82h

l207F_2B57:
	mov	ax,[bp+6h]
	mov	si,ax
	mov	ax,[bp+8h]
	push	es
	mov	es,ax
	mov	cx,10h
	mov	bl,10h

l207F_2B67:
	mov	dx,3DAh
	in	al,dx
	mov	al,bl
	out	dx,al
	mov	al,es:[si]
	mov	dx,3DEh
	out	dx,al
	inc	bl
	inc	si
	loop	2B67h

l207F_2B7A:
	mov	dx,3DAh
	in	al,dx
	mov	al,0Fh
	out	dx,al
	pop	es

l207F_2B82:
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2B87: 207F:2B87
;;   Called from:
;;     1543:04FD (in fn1543_0004)
;;     183B:1831 (in fn183B_1774)
;;     183B:1FD9 (in fn183B_1C1F)
;;     183B:220F (in fn183B_1C1F)
;;     1E56:0C0B (in fn1E56_0B5E)
;;     1E56:0C74 (in fn1E56_0B5E)
;;     1E56:0CE3 (in fn1E56_0B5E)
fn207F_2B87 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	cmp	word ptr [0B764h],2h
	jz	2BB0h

l207F_2B9C:
	shl	ax,1h
	cmp	word ptr [0B764h],0h
	jz	2BB0h

l207F_2BA5:
	shl	ax,1h
	cmp	word ptr [0B764h],1h
	jz	2BB0h

l207F_2BAE:
	shl	ax,1h

l207F_2BB0:
	mov	[0B792h],ax
	mov	ax,[bp+8h]
	mov	dx,140h
	cmp	word ptr [0B764h],3h
	jnz	2BC3h

l207F_2BC0:
	mov	dx,0A00h

l207F_2BC3:
	mul	dx
	add	ax,[0B792h]
	mov	di,ax
	mov	si,ax
	add	si,0A0h
	push	es
	mov	ax,0B800h
	cmp	word ptr [0B764h],2h
	jc	2BDFh

l207F_2BDC:
	mov	ax,0A000h

l207F_2BDF:
	mov	es,ax
	mov	ax,[bp+0Ah]
	cmp	word ptr [0B764h],3h
	jnz	2BEFh

l207F_2BEB:
	shl	ax,1h
	shl	ax,1h

l207F_2BEF:
	cmp	word ptr [0B764h],1h
	jnz	2BF8h

l207F_2BF6:
	shl	ax,1h

l207F_2BF8:
	mov	[0B79Ah],ax
	mov	ax,[bp+0Ch]
	cmp	word ptr [0B764h],3h
	jz	2C11h

l207F_2C05:
	cmp	word ptr [0B764h],1h
	jz	2C48h

l207F_2C0C:
	jc	2C81h

l207F_2C0E:
	jmp	2CB0h

l207F_2C11:
	and	al,0Fh
	mov	dl,al
	mov	dh,al
	cmp	word ptr [0B782h],0h
	jz	2C26h

l207F_2C1E:
	shl	dl,1h
	shl	dl,1h
	shl	dl,1h
	shl	dl,1h

l207F_2C26:
	mov	bx,140h
	sub	bx,[0B79Ah]
	sub	bx,[0B79Ah]
	mov	al,8h

l207F_2C33:
	mov	cx,[0B79Ah]

l207F_2C37:
	xor	es:[di],dx
	add	di,2h
	loop	2C37h

l207F_2C3F:
	add	di,bx
	dec	al
	jnz	2C33h

l207F_2C45:
	jmp	2C7Bh
207F:2C47                      90                                .        

l207F_2C48:
	mov	bl,al
	mov	cx,4h
	shl	al,cl
	or	al,bl
	mov	ah,al
	mov	dx,ax
	mov	bx,2000h
	mov	ax,[0B79Ah]
	shl	ax,1h
	sub	bx,ax
	mov	al,4h

l207F_2C61:
	mov	cx,[0B79Ah]

l207F_2C65:
	xor	es:[si],dx
	xor	es:[di],dx
	add	si,2h
	add	di,2h
	loop	2C65h

l207F_2C73:
	add	si,bx
	add	di,bx
	dec	al
	jnz	2C61h

l207F_2C7B:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

l207F_2C81:
	mov	dx,0FFFFh
	add	si,1F60h
	mov	bx,50h
	mov	ax,[0B79Ah]
	shl	ax,1h
	sub	bx,ax
	mov	al,4h

l207F_2C94:
	mov	cx,[0B79Ah]

l207F_2C98:
	xor	es:[di],dx
	xor	es:[si],dx
	add	si,2h
	add	di,2h
	loop	2C98h

l207F_2CA6:
	add	si,bx
	add	di,bx
	dec	al
	jnz	2C94h

l207F_2CAE:
	jmp	2C7Bh

l207F_2CB0:
	mov	bl,al
	mov	dx,3CEh
	mov	ax,205h
	out	dx,ax
	mov	ax,0FF08h
	out	dx,ax
	mov	ax,1803h
	out	dx,ax
	mov	bh,8h

l207F_2CC3:
	mov	cx,[0B79Ah]

l207F_2CC7:
	mov	al,es:[di]
	mov	es:[di],bl
	inc	di
	loop	2CC7h

l207F_2CD0:
	add	di,28h
	sub	di,[0B79Ah]
	dec	bh
	jnz	2CC3h

l207F_2CDB:
	mov	ax,3h
	out	dx,ax
	jmp	2C7Bh

;; fn207F_2CE1: 207F:2CE1
;;   Called from:
;;     0D27:0365 (in main)
;;     0D27:03B5 (in main)
;;     0DAB:0CAF (in fn0DAB_0C8F)
fn207F_2CE1 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	mov	ax,[bp+6h]
	mov	[0B764h],ax
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2CF7: 207F:2CF7
;;   Called from:
;;     0DAB:0CFC (in fn0DAB_0C8F)
fn207F_2CF7 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	ds
	mov	ax,246Ch
	mov	ds,ax
	push	es
	mov	ax,ds
	mov	es,ax
	cld
	cmp	word ptr [0B764h],2h
	jnc	2D5Eh

l207F_2D0F:
	mov	si,0A661h
	add	si,3FFh
	mov	di,0A661h
	cmp	word ptr [0B764h],0h
	jz	2D39h

l207F_2D20:
	add	di,0FFCh

l207F_2D24:
	mov	bl,[si]
	call	2D64h
	call	2D64h
	sub	di,8h
	dec	si
	cmp	si,0A661h
	jnz	2D24h

l207F_2D36:
	jmp	2D5Eh
207F:2D38                         90                              .       

l207F_2D39:
	add	di,7FEh

l207F_2D3D:
	mov	bl,[si]
	mov	cx,8h
	xor	ax,ax

l207F_2D44:
	shl	ax,1h
	shl	ax,1h
	shl	bl,1h
	jnc	2D4Eh

l207F_2D4C:
	or	al,3h

l207F_2D4E:
	loop	2D44h

l207F_2D50:
	xchg	al,ah
	mov	[di],ax
	sub	di,2h
	dec	si
	cmp	si,0A661h
	jnz	2D3Dh

l207F_2D5E:
	pop	es
	pop	ds
	pop	si
	pop	di
	pop	bp
	retf

;; fn207F_2D64: 207F:2D64
;;   Called from:
;;     207F:2D26 (in fn207F_2CF7)
;;     207F:2D29 (in fn207F_2CF7)
fn207F_2D64 proc
	xor	ax,ax
	shl	bl,1h
	jnc	2D6Ch

l207F_2D6A:
	or	al,0F0h

l207F_2D6C:
	shl	bl,1h
	jnc	2D72h

l207F_2D70:
	or	al,0Fh

l207F_2D72:
	shl	bl,1h
	jnc	2D79h

l207F_2D76:
	or	ah,0F0h

l207F_2D79:
	shl	bl,1h
	jnc	2D80h

l207F_2D7D:
	or	ah,0Fh

l207F_2D80:
	stosw
	ret
207F:2D82       B4 30 CD 21 3C 02 73 02 CD 20 BF DB 3E 8B   .0.!<.s.. ..>.
207F:2D90 36 02 00 2B F7 81 FE 00 10 72 03 BE 00 10 FA 8E 6..+.....r......
207F:2DA0 D7 81 C4 2E 58 FB 73 14 16 1F 9A B2 2F 7F 20 33 ....X.s...../. 3
207F:2DB0 C0 50 9A 75 32 7F 20 B8 FF 4C CD 21 83 E4 FE 36 .P.u2. ..L.!...6
207F:2DC0 89 26 86 52 36 89 26 82 52 8B C6 B1 04 D3 E0 48 .&.R6.&.R......H
207F:2DD0 36 A3 80 52 03 F7 89 36 02 00 8C C3 2B DE F7 DB 6..R...6....+...
207F:2DE0 B4 4A CD 21 36 8C 1E F7 52 16 07 FC BF FE 57 B9 .J.!6...R.....W.
207F:2DF0 30 58 2B CF 33 C0 F3 AA 16 1F 9A 50 2E 7F 20 16 0X+.3......P.. .
207F:2E00 1F 9A CE 31 7F 20 9A 26 30 7F 20 33 ED FF 36 1C ...1. .&0. 3..6.
207F:2E10 53 FF 36 1A 53 FF 36 18 53 FF 36 16 53 FF 36 14 S.6.S.6.S.6.S.6.
207F:2E20 53 9A 44 00 27 0D 50 9A 14 2F 7F 20 B8 DB 3E 8E S.D.'.P../. ..>.
207F:2E30 D8 B8 03 00 36 C7 06 84 52 14 2F                ....6...R./     

;; fn207F_2E3B: 207F:2E3B
;;   Called from:
;;     207F:2FF7 (in fn207F_2FDC)
;;     207F:371B (in fn207F_366A)
fn207F_2E3B proc
	push	ax
	call	far 207Fh:2FB2h
	call	far 207Fh:3275h
	mov	ax,0FFh
	push	ax
	push	cs
	call	word ptr [5284h]
	add	[si+0CD30h],dh
	and	[bp+di+52F9h],sp
	mov	ax,3500h
	int	21h
	mov	[52E5h],bx
	mov	[52E7h],es
	push	cs
	pop	ds
	mov	ax,2500h
	mov	dx,2E2Ch
	int	21h
	push	ss
	pop	ds
	mov	cx,[537Ah]
	jcxz	2EA4h

l207F_2E76:
	mov	es,[52F7h]
	mov	si,es:[002Ch]
	lds	ax,[537Ch]
	mov	dx,ds
	xor	bx,bx
	call	dword ptr ss:[5378h]
	jnc	2E93h

l207F_2E8E:
	push	ss
	pop	ds
	jmp	2FD6h

l207F_2E93:
	lds	ax,ss:[5380h]
	mov	dx,ds
	mov	bx,3h
	call	dword ptr ss:[5378h]
	push	ss
	pop	ds

l207F_2EA4:
	mov	es,[52F7h]
	mov	cx,es:[002Ch]
	jcxz	2EE5h

l207F_2EAF:
	mov	es,cx
	xor	di,di

l207F_2EB3:
	cmp	byte ptr es:[di],0h
	jz	2EE5h

l207F_2EB9:
	mov	cx,0Ch
	mov	si,52D8h
	rep cmpsb
	jz	2ECEh

l207F_2EC3:
	mov	cx,7FFFh
	xor	ax,ax

l207F_2EC8:
	repne scasb

l207F_2ECA:
	jnz	2EE5h

l207F_2ECC:
	jmp	2EB3h

l207F_2ECE:
	push	es
	push	ds
	pop	es
	pop	ds
	mov	si,di
	mov	di,5300h
	lodsb
	cbw
	xchg	cx,ax

l207F_2EDA:
	lodsb
	inc	al
	jz	2EE0h

l207F_2EDF:
	dec	ax

l207F_2EE0:
	stosb
	loop	2EDAh

l207F_2EE3:
	push	ss
	pop	ds

l207F_2EE5:
	mov	bx,4h

l207F_2EE8:
	and	byte ptr [bx+5300h],0BFh
	mov	ax,4400h
	int	21h
	jc	2EFEh

l207F_2EF4:
	test	dl,80h
	jz	2EFEh

l207F_2EF9:
	or	byte ptr [bx+5300h],40h

l207F_2EFE:
	dec	bx
	jns	2EE8h

l207F_2F01:
	mov	si,5384h
	mov	di,5384h
	call	2F9Fh
	mov	si,5384h
	mov	di,5384h
	call	2F9Fh
	retf
207F:2F14             55 8B EC BE 2A 58 BF 2A 58 E8 7F 00     U...*X.*X...
207F:2F20 BE 84 53 BF 84 53 E8 76 00 EB 03 55 8B EC BE 84 ..S..S.v...U....
207F:2F30 53 BF 84 53 E8 68 00 BE 84 53 BF 84 53 E8 5F 00 S..S.h...S..S._.
207F:2F40 9A 00 30 7F 20 0B C0 74 0B 83 7E 06 00 75 05 C7 ..0. ..t..~..u..
207F:2F50 46 06 FF 00 B9 0F 00 BB 05 00 F6 87 00 53 01 74 F............S.t
207F:2F60 04 B4 3E CD 21 43 E2 F2 E8 07 00 8B 46 06 B4 4C ..>.!C......F..L
207F:2F70 CD 21 8B 0E 7A 53 E3 07 BB 02 00 FF 1E 78 53 1E .!..zS.......xS.
207F:2F80 C5 16 E5 52 B8 00 25 CD 21 1F 80 3E 26 53 00 74 ...R..%.!..>&S.t
207F:2F90 0D 1E A0 27 53 C5 16 28 53 B4 25 CD 21 1F C3    ...'S..(S.%.!.. 

;; fn207F_2F9F: 207F:2F9F
;;   Called from:
;;     207F:2F07 (in fn207F_2E3B)
;;     207F:2F10 (in fn207F_2E3B)
fn207F_2F9F proc
	cmp	si,di
	jnc	2FB1h

l207F_2FA3:
	sub	di,4h
	mov	ax,[di]
	or	ax,[di+2h]
	jz	2F9Fh

l207F_2FAD:
	call	dword ptr [di]
	jmp	2F9Fh

l207F_2FB1:
	ret

;; fn207F_2FB2: 207F:2FB2
;;   Called from:
;;     207F:2E3C (in fn207F_2E3B)
fn207F_2FB2 proc
	push	bp
	mov	bp,sp
	mov	ax,0FCh
	push	ax
	call	far 207Fh:3275h
	cmp	word ptr [532Eh],0h
	jz	2FC9h

l207F_2FC5:
	call	dword ptr [532Ch]

l207F_2FC9:
	mov	ax,0FFh
	push	ax
	call	far 207Fh:3275h
	mov	sp,bp
	pop	bp
	retf

l207F_2FD6:
	mov	ax,2h
	jmp	2E3Bh

;; fn207F_2FDC: 207F:2FDC
;;   Called from:
;;     0800:0006 (in fn0800_0000)
;;     0800:0521 (in fn0800_051B)
;;     0800:0E51 (in fn0800_0E4B)
;;     0800:1738 (in fn0800_1732)
;;     0800:17C0 (in fn0800_17BB)
;;     0800:1874 (in fn0800_186F)
;;     0800:1920 (in fn0800_191B)
;;     0800:19C4 (in fn0800_19BF)
;;     0800:19DF (in fn0800_19DD)
;;     0800:19F9 (in fn0800_19F3)
;;     0800:1A19 (in fn0800_1A13)
;;     0800:1B03 (in fn0800_1AFD)
;;     0800:1C18 (in fn0800_1C12)
;;     0800:2195 (in fn0800_218F)
;;     0800:2323 (in fn0800_231D)
;;     0800:2411 (in fn0800_240B)
;;     0800:24C8 (in fn0800_24C2)
;;     0800:286C (in fn0800_2867)
;;     0800:28A4 (in fn0800_28A2)
;;     0800:28D1 (in fn0800_28CC)
;;     0800:2919 (in fn0800_2913)
;;     0800:29FB (in fn0800_29F5)
;;     0800:2A2D (in fn0800_2A2B)
;;     0800:2A51 (in fn0800_2A4F)
;;     0800:2A6B (in fn0800_2A69)
;;     0800:2A80 (in fn0800_2A7E)
;;     0800:2A99 (in fn0800_2A93)
;;     0800:2C56 (in fn0800_2C50)
;;     0800:2DAE (in fn0800_2DA8)
;;     0800:320D (in fn0800_320B)
;;     0800:32B9 (in fn0800_32B3)
;;     0800:35D9 (in fn0800_35D3)
;;     0800:3793 (in fn0800_378D)
;;     0800:3BD2 (in fn0800_3BD0)
;;     0800:3D46 (in fn0800_3D40)
;;     0800:3FB4 (in fn0800_3FAE)
;;     0800:45C7 (in fn0800_45C2)
;;     0800:4623 (in fn0800_4621)
;;     0800:46A9 (in fn0800_46A7)
;;     0800:4773 (in fn0800_476D)
;;     0800:48BD (in fn0800_48B7)
;;     0800:4AAC (in fn0800_4AA6)
;;     0800:4BC7 (in fn0800_4BC1)
;;     0800:4CB2 (in fn0800_4CAC)
;;     0800:4D5D (in fn0800_4D57)
;;     0800:4DCD (in fn0800_4DC7)
;;     0800:50CE (in fn0800_50C8)
;;     0D27:0010 (in fn0D27_000A)
;;     0D27:004A (in main)
;;     0DAB:0008 (in fn0DAB_0002)
;;     0DAB:04FF (in fn0DAB_04F9)
;;     0DAB:0951 (in fn0DAB_094B)
;;     0DAB:0B60 (in fn0DAB_0B5E)
;;     0DAB:0B9B (in fn0DAB_0B95)
;;     0DAB:0C91 (in fn0DAB_0C8F)
;;     0DAB:0D14 (in fn0DAB_0D12)
;;     0DAB:0D43 (in fn0DAB_0D3D)
;;     0DAB:146D (in fn0DAB_1467)
;;     0DAB:1752 (in fn0DAB_174C)
;;     0DAB:185E (in fn0DAB_1858)
;;     0DAB:18EE (in fn0DAB_18E8)
;;     0DAB:1B04 (in fn0DAB_1AFE)
;;     0FDC:000E (in fn0FDC_0008)
;;     0FDC:01C6 (in fn0FDC_01C0)
;;     0FDC:05FD (in fn0FDC_05F7)
;;     0FDC:062F (in fn0FDC_0629)
;;     0FDC:0D4F (in fn0FDC_0D49)
;;     0FDC:1351 (in fn0FDC_134B)
;;     0FDC:13E4 (in fn0FDC_13DE)
;;     0FDC:15EC (in fn0FDC_15E6)
;;     0FDC:17BF (in fn0FDC_17B9)
;;     0FDC:19E3 (in fn0FDC_19E1)
;;     0FDC:19FC (in fn0FDC_19F6)
;;     0FDC:1A2C (in fn0FDC_1A26)
;;     0FDC:1B47 (in fn0FDC_1B41)
;;     0FDC:1CA1 (in fn0FDC_1C9B)
;;     0FDC:1D36 (in fn0FDC_1D30)
;;     11B8:0008 (in fn11B8_0002)
;;     11B8:0810 (in fn11B8_080A)
;;     11B8:092B (in fn11B8_0925)
;;     11B8:0D5E (in fn11B8_0D58)
;;     11B8:1054 (in fn11B8_104E)
;;     11B8:1385 (in fn11B8_137F)
;;     11B8:1447 (in fn11B8_1441)
;;     11B8:1535 (in fn11B8_152F)
;;     11B8:16B8 (in fn11B8_16B2)
;;     11B8:1768 (in fn11B8_1762)
;;     135D:000A (in fn135D_0004)
;;     135D:01EF (in fn135D_01E9)
;;     135D:028A (in fn135D_0288)
;;     135D:02AA (in fn135D_02A8)
;;     135D:02D7 (in fn135D_02D2)
;;     135D:032D (in fn135D_0327)
;;     135D:03B0 (in fn135D_03AA)
;;     135D:04B0 (in fn135D_04AB)
;;     135D:0560 (in fn135D_055A)
;;     135D:07A2 (in fn135D_079C)
;;     135D:0919 (in fn135D_0913)
;;     135D:0986 (in fn135D_0980)
;;     135D:0ABC (in fn135D_0AB6)
;;     1431:0010 (in fn1431_000A)
;;     1467:0008 (in fn1467_0002)
;;     1467:08AE (in fn1467_08A8)
;;     1467:0B9E (in fn1467_0B98)
;;     1467:0D84 (in fn1467_0D7E)
;;     1543:000A (in fn1543_0004)
;;     1543:07D1 (in fn1543_07CB)
;;     1543:0A3B (in fn1543_0A35)
;;     1543:0C78 (in fn1543_0C72)
;;     1543:0CE4 (in fn1543_0CDE)
;;     1631:000C (in fn1631_0006)
;;     1631:02EA (in fn1631_02E4)
;;     1631:0334 (in fn1631_032F)
;;     1631:03B1 (in fn1631_03AB)
;;     1631:0BBB (in fn1631_0BB5)
;;     1631:0C69 (in fn1631_0C63)
;;     1631:0F2A (in fn1631_0F24)
;;     1631:105D (in fn1631_1057)
;;     1631:10A8 (in fn1631_10A2)
;;     1631:1128 (in fn1631_1122)
;;     1631:11B1 (in fn1631_11AB)
;;     1631:1600 (in fn1631_15FA)
;;     1631:1644 (in fn1631_163E)
;;     1631:16B1 (in fn1631_16AB)
;;     1631:1B4A (in fn1631_1B44)
;;     1631:1B95 (in fn1631_1B8F)
;;     1631:1C04 (in fn1631_1BFE)
;;     1631:1DB0 (in fn1631_1DAB)
;;     1631:1DCE (in fn1631_1DCC)
;;     1631:1DFD (in fn1631_1DF8)
;;     1631:1EA8 (in fn1631_1EA2)
;;     1631:1F0F (in fn1631_1F09)
;;     1631:1F78 (in fn1631_1F73)
;;     1631:1FE5 (in fn1631_1FDF)
;;     183B:0010 (in fn183B_000A)
;;     183B:1488 (in fn183B_1482)
;;     183B:14C9 (in fn183B_14C3)
;;     183B:177A (in fn183B_1774)
;;     183B:1941 (in fn183B_193B)
;;     183B:1C25 (in fn183B_1C1F)
;;     183B:2237 (in fn183B_2231)
;;     183B:22C2 (in fn183B_22BC)
;;     183B:2479 (in fn183B_2474)
;;     183B:24F6 (in fn183B_24F0)
;;     183B:255C (in fn183B_2556)
;;     183B:2597 (in fn183B_2591)
;;     183B:2743 (in fn183B_273D)
;;     183B:27CF (in fn183B_27C9)
;;     183B:283B (in fn183B_2835)
;;     183B:28E1 (in fn183B_28DB)
;;     183B:2AA8 (in fn183B_2AA3)
;;     1AE8:0012 (in fn1AE8_000C)
;;     1AE8:12CD (in fn1AE8_12C7)
;;     1AE8:1E4C (in fn1AE8_1E46)
;;     1CD3:000A (in fn1CD3_0004)
;;     1CD3:17C8 (in fn1CD3_17C6)
;;     1CD3:17EF (in fn1CD3_17EA)
;;     1CD3:180B (in fn1CD3_1809)
;;     1CD3:1820 (in fn1CD3_181E)
;;     1E56:000A (in fn1E56_0004)
;;     1E56:01ED (in fn1E56_01E7)
;;     1E56:0286 (in fn1E56_0281)
;;     1E56:038A (in fn1E56_0388)
;;     1E56:03FB (in fn1E56_03F5)
;;     1E56:07D1 (in fn1E56_07CB)
;;     1E56:0A41 (in fn1E56_0A3B)
;;     1E56:0AEB (in fn1E56_0AE5)
;;     1E56:0B64 (in fn1E56_0B5E)
;;     1E56:0D22 (in fn1E56_0D1D)
;;     1F3D:000B (in fn1F3D_0006)
;;     1F3D:0031 (in fn1F3D_002F)
;;     1F3D:0058 (in fn1F3D_0053)
;;     1F3D:008B (in fn1F3D_0086)
;;     1F3D:00DB (in fn1F3D_00D5)
;;     1F3D:0200 (in fn1F3D_01FB)
;;     1F3D:025F (in fn1F3D_0259)
;;     1F3D:0322 (in fn1F3D_031C)
;;     1F3D:03F1 (in fn1F3D_03EB)
;;     1F3D:04A3 (in fn1F3D_049D)
;;     1F3D:052B (in fn1F3D_0525)
;;     1F3D:05C2 (in fn1F3D_05BC)
;;     1F3D:0641 (in fn1F3D_063B)
;;     1F3D:06C5 (in fn1F3D_06C3)
;;     1F3D:0710 (in fn1F3D_070A)
;;     1F3D:081A (in fn1F3D_0814)
;;     1F3D:086C (in fn1F3D_086A)
;;     1FC5:0008 (in fn1FC5_0002)
;;     1FC5:02A9 (in fn1FC5_02A3)
;;     1FC5:02F1 (in fn1FC5_02EB)
;;     1FC5:034B (in fn1FC5_0345)
;;     1FC5:03AE (in fn1FC5_03A8)
;;     1FC5:0411 (in fn1FC5_040B)
;;     1FC5:0470 (in fn1FC5_046E)
;;     1FC5:0481 (in fn1FC5_047B)
;;     1FC5:04E6 (in fn1FC5_04E4)
;;     1FC5:04F7 (in fn1FC5_04F1)
;;     1FC5:05A0 (in fn1FC5_059A)
;;     1FC5:0649 (in fn1FC5_0643)
;;     1FC5:06FC (in fn1FC5_06F6)
;;     1FC5:074D (in fn1FC5_0747)
;;     1FC5:07E0 (in fn1FC5_07DA)
fn207F_2FDC proc
	pop	cx
	pop	dx
	mov	bx,sp
	sub	bx,ax
	jc	2FEFh

l207F_2FE4:
	cmp	bx,[5334h]
	jc	2FEFh

l207F_2FEA:
	mov	sp,bx
	push	dx
	push	cx
	retf

l207F_2FEF:
	mov	ax,[5330h]
	inc	ax
	jnz	2FFAh

l207F_2FF5:
	xor	ax,ax
	jmp	2E3Bh

l207F_2FFA:
	push	dx
	push	cx
	jmp	dword ptr [5330h]
207F:3000 56 33 F6 B9 42 00 32 E4 FC AC 32 E0 E2 FB 80 F4 V3..B.2...2.....
207F:3010 55 74 11 9A B2 2F 7F 20 B8 01 00 50 9A 75 32 7F Ut.../. ...P.u2.
207F:3020 20 B8 01 00 5E CB 8F 06 36 53 8F 06 38 53 BA 02  ...^...6S..8S..
207F:3030 00 38 16 F9 52 74 29 8E 06 F7 52 26 8E 06 2C 00 .8..Rt)...R&..,.
207F:3040 8C 06 20 53 33 C0 99 B9 00 80 33 FF F2 AE AE 75 .. S3.....3....u
207F:3050 FB 47 47 89 3E 1E 53 B9 FF FF F2 AE F7 D1 8B D1 .GG.>.S.........
207F:3060 BF 01 00 BE 81 00 8E 1E F7 52 AC 3C 20 74 FB 3C .........R.< t.<
207F:3070 09 74 F7 3C 0D 74 6F 0A C0 74 6B 47 4E AC 3C 20 .t.<.to..tkGN.< 
207F:3080 74 E8 3C 09 74 E4 3C 0D 74 5C 0A C0 74 58 3C 22 t.<.t.<.t\..tX<"
207F:3090 74 24 3C 5C 74 03 42 EB E4 33 C9 41 AC 3C 5C 74 t$<\t.B..3.A.<\t
207F:30A0 FA 3C 22 74 04 03 D1 EB D3 8B C1 D1 E9 13 D1 A8 .<"t............
207F:30B0 01 75 CA EB 01 4E AC 3C 0D 74 2B 0A C0 74 27 3C .u...N.<.t+..t'<
207F:30C0 22 74 BA 3C 5C 74 03 42 EB EC 33 C9 41 AC 3C 5C "t.<\t.B..3.A.<\
207F:30D0 74 FA 3C 22 74 04 03 D1 EB DB 8B C1 D1 E9 13 D1 t.<"t...........
207F:30E0 A8 01 75 D2 EB 97 16 1F 89 3E 14 53 03 D7 47 D1 ..u......>.S..G.
207F:30F0 E7 D1 E7 03 D7 80 E2 FE 2B E2 8B C4 A3 16 53 8C ........+.....S.
207F:3100 1E 18 53 8B D8 03 FB 16 07 36 89 3F 36 8C 57 02 ..S......6.?6.W.
207F:3110 83 C3 04 C5 36 1E 53 AC AA 0A C0 75 FA BE 81 00 ....6.S....u....
207F:3120 36 8E 1E F7 52 EB 03 33 C0 AA AC 3C 20 74 FB 3C 6...R..3...< t.<
207F:3130 09 74 F7 3C 0D 75 03 E9 84 00 0A C0 75 03 EB 7E .t.<.u......u..~
207F:3140 90 36 89 3F 36 8C 57 02 83 C3 04 4E AC 3C 20 74 .6.?6.W....N.< t
207F:3150 D6 3C 09 74 D2 3C 0D 74 62 0A C0 74 5E 3C 22 74 .<.t.<.tb..t^<"t
207F:3160 27 3C 5C 74 03 AA EB E4 33 C9 41 AC 3C 5C 74 FA '<\t....3.A.<\t.
207F:3170 3C 22 74 06 B0 5C F3 AA EB D1 B0 5C D1 E9 F3 AA <"t..\.....\....
207F:3180 73 06 B0 22 AA EB C5 4E AC 3C 0D 74 2E 0A C0 74 s.."...N.<.t...t
207F:3190 2A 3C 22 74 B7 3C 5C 74 03 AA EB EC 33 C9 41 AC *<"t.<\t....3.A.
207F:31A0 3C 5C 74 FA 3C 22 74 06 B0 5C F3 AA EB D9 B0 5C <\t.<"t..\.....\
207F:31B0 D1 E9 F3 AA 73 96 B0 22 AA EB CD 33 C0 AA 16 1F ....s.."...3....
207F:31C0 C7 07 00 00 C7 47 02 00 00 FF 2E 36 53 00 55 8B .....G.....6S.U.
207F:31D0 EC 55 8E 1E F7 52 33 C9 8B C1 8B E9 8B F9 49 8B .U...R3.......I.
207F:31E0 36 2C 00 0B F6 74 10 8E C6 26 80 3E 00 00 00 74 6,...t...&.>...t
207F:31F0 06 F2 AE 45 AE 75 FA 45 97 40 24 FE 8B FD D1 E5 ...E.u.E.@$.....
207F:3200 D1 E5 03 C5 16 1F 57 BF 09 00 E8 93 00 5F 8B CF ......W......_..
207F:3210 8B FD 03 F8 89 2E 1A 53 8C 1E 1C 53 1E 07 8E DE .......S...S....
207F:3220 33 F6 49 E3 17 81 3C 3B 43 74 09 89 7E 00 8C 46 3.I...<;Ct..~..F
207F:3230 02 83 C5 04 AC AA 0A C0 75 FA E2 E9 89 4E 00 89 ........u....N..
207F:3240 4E 02 16 1F 5D 8B E5 5D CB 00                   N...]..]..      

;; fn207F_324A: 207F:324A
;;   Called from:
;;     207F:327C (in fn207F_3275)
fn207F_324A proc
	push	bp
	mov	bp,sp
	push	si
	push	di
	push	ds
	pop	es
	mov	dx,[bp+6h]
	mov	si,572Ch

l207F_3257:
	lodsw
	cmp	ax,dx
	jz	326Ch

l207F_325C:
	inc	ax
	xchg	si,ax
	jz	326Ch

l207F_3260:
	xchg	di,ax
	xor	ax,ax
	mov	cx,0FFFFh
	repne scasb
	mov	si,di
	jmp	3257h

l207F_326C:
	xchg	si,ax
	pop	di
	pop	si
	mov	sp,bp
	pop	bp
	retf	2h

;; fn207F_3275: 207F:3275
;;   Called from:
;;     207F:2E41 (in fn207F_2E3B)
;;     207F:2FB9 (in fn207F_2FB2)
;;     207F:2FCD (in fn207F_2FB2)
fn207F_3275 proc
	push	bp
	mov	bp,sp
	push	di
	push	word ptr [bp+6h]
	call	far 207Fh:324Ah
	or	ax,ax
	jz	3299h

l207F_3285:
	xchg	dx,ax
	mov	di,dx
	xor	ax,ax
	mov	cx,0FFFFh
	repne scasb
	not	cx
	dec	cx
	mov	bx,2h
	mov	ah,40h
	int	21h

l207F_3299:
	pop	di
	mov	sp,bp
	pop	bp
	retf	2h
207F:32A0 8B D0 03 06 86 52 72 35 39 06 80 52 73 25 05 0F .....Rr59..Rs%..
207F:32B0 00 50 D1 D8 B1 03 D3 E8 8C D9 8B 1E F7 52 2B CB .P...........R+.
207F:32C0 03 C1 8E C3 8B D8 B4 4A CD 21 58 72 10 24 F0 48 .......J.!Xr.$.H
207F:32D0 A3 80 52 95 8B 2E 86 52 01 16 86 52 C3 8B C7 E9 ..R....R...R....
207F:32E0 59 FB                                           Y.              

l207F_32E2:
	jc	32F7h

l207F_32E4:
	xor	ax,ax
	mov	sp,bp
	pop	bp
	retf
207F:32EA                               73 F8 50 E8 18 00           s.P...
207F:32F0 58 8B E5 5D CB                                  X..].           

;; fn207F_32F5: 207F:32F5
;;   Called from:
;;     207F:33CD (in fn207F_3356)
;;     207F:3417 (in fn207F_33D0)
;;     207F:34E1 (in fn207F_33D0)
;;     207F:35FC (in fn207F_3580)
;;     207F:367D (in fn207F_366A)
;;     207F:3777 (in fn207F_3777)
;;     207F:3777 (in fn207F_3777)
;;     207F:3783 (in fn207F_366A)
fn207F_32F5 proc
	jnc	32FEh

;; fn207F_32F7: 207F:32F7
;;   Called from:
;;     207F:32E2 (in fn207F_3336)
;;     207F:32F5 (in fn207F_32F5)
;;     207F:32F5 (in fn207F_32F5)
fn207F_32F7 proc
	call	3308h
	mov	ax,0FFFFh
	cwd

l207F_32FE:
	mov	sp,bp
	pop	bp
	retf
207F:3302       32 E4 E8 01 00 CB                           2.....        

;; fn207F_3308: 207F:3308
;;   Called from:
;;     207F:32F7 (in fn207F_32F7)
fn207F_3308 proc
	mov	[52FCh],al
	or	ah,ah
	jnz	3332h

l207F_330F:
	cmp	byte ptr [52F9h],3h
	jc	3323h

l207F_3316:
	cmp	al,22h
	jnc	3327h

l207F_331A:
	cmp	al,20h
	jc	3323h

l207F_331E:
	mov	al,5h
	jmp	3329h
207F:3322       90                                          .             

l207F_3323:
	cmp	al,13h
	jbe	3329h

l207F_3327:
	mov	al,13h

l207F_3329:
	mov	bx,533Ah
	xlat

l207F_332D:
	cbw
	mov	[52F1h],ax
	ret

l207F_3332:
	mov	al,ah
	jmp	332Dh

;; fn207F_3336: 207F:3336
;;   Called from:
;;     0800:3048 (in fn0800_2DA8)
;;     0800:332B (in fn0800_32B3)
;;     0800:33DB (in fn0800_32B3)
;;     0800:365E (in fn0800_35D3)
;;     0800:3713 (in fn0800_35D3)
;;     0800:418A (in fn0800_3FAE)
;;     0800:47E3 (in fn0800_476D)
;;     0800:49A1 (in fn0800_48B7)
;;     1F3D:0690 (in fn1F3D_063B)
;;     1F3D:0861 (in fn1F3D_0814)
fn207F_3336 proc
	push	bp
	mov	bp,sp
	mov	bx,[bp+6h]
	cmp	bx,[52FEh]
	jc	3348h

l207F_3342:
	mov	ax,900h
	stc
	jmp	3353h

l207F_3348:
	mov	ah,3Eh
	int	21h
	jc	3353h

l207F_334E:
	mov	byte ptr [bx+5300h],0h

l207F_3353:
	jmp	32E2h

;; fn207F_3356: 207F:3356
;;   Called from:
;;     0800:47AF (in fn0800_476D)
;;     0800:47C2 (in fn0800_476D)
fn207F_3356 proc
	push	bp
	mov	bp,sp
	sub	sp,4h
	mov	bx,[bp+6h]
	cmp	bx,[52FEh]
	jc	336Ah

l207F_3365:
	mov	ax,900h
	jmp	3394h

l207F_336A:
	test	word ptr [bp+0Ah],8000h
	jz	33B9h

l207F_3371:
	cmp	word ptr [bp+0Ch],0h
	jz	3391h

l207F_3377:
	xor	cx,cx
	mov	dx,cx
	mov	ax,4201h
	int	21h
	jc	33CDh

l207F_3382:
	test	word ptr [bp+0Ch],2h
	jnz	3397h

l207F_3389:
	add	ax,[bp+8h]
	adc	dx,[bp+0Ah]
	jns	33B9h

l207F_3391:
	mov	ax,1600h

l207F_3394:
	stc
	jmp	33CDh

l207F_3397:
	mov	[bp-2h],dx
	mov	[bp-4h],ax
	mov	dx,cx
	mov	ax,4202h
	int	21h
	add	ax,[bp+8h]
	adc	dx,[bp+0Ah]
	jns	33B9h

l207F_33AC:
	mov	cx,[bp-2h]
	mov	dx,[bp-4h]
	mov	ax,4200h
	int	21h
	jmp	3391h

l207F_33B9:
	mov	dx,[bp+8h]
	mov	cx,[bp+0Ah]
	mov	al,[bp+0Ch]
	mov	ah,42h
	int	21h
	jc	33CDh

l207F_33C8:
	and	byte ptr [bx+5300h],0FDh

l207F_33CD:
	jmp	32F5h

;; fn207F_33D0: 207F:33D0
;;   Called from:
;;     0800:2EFC (in fn0800_2DA8)
;;     0800:331A (in fn0800_32B3)
;;     0800:333C (in fn0800_32B3)
;;     0800:364D (in fn0800_35D3)
;;     0800:3673 (in fn0800_35D3)
;;     0800:413E (in fn0800_3FAE)
;;     0800:4796 (in fn0800_476D)
;;     0800:4995 (in fn0800_48B7)
;;     1F3D:0655 (in fn1F3D_063B)
;;     1F3D:083C (in fn1F3D_0814)
fn207F_33D0 proc
	push	bp
	mov	bp,sp
	sub	sp,4h
	xor	bh,bh
	mov	[bp-2h],bh
	mov	ax,[bp+0Ah]
	mov	cx,ax
	mov	byte ptr [bp-4h],0h
	test	ax,8000h
	jnz	33F9h

l207F_33E9:
	test	ax,4000h
	jnz	33F5h

l207F_33EE:
	test	byte ptr [534Fh],80h
	jnz	33F9h

l207F_33F5:
	mov	byte ptr [bp-4h],80h

l207F_33F9:
	push	ds
	lds	dx,[bp+6h]
	and	al,3h
	or	al,bh
	mov	ah,3Dh
	int	21h
	pop	ds
	jnc	341Ah

l207F_3408:
	cmp	ax,2h
	jnz	3416h

l207F_340D:
	test	cx,100h
	jz	3416h

l207F_3413:
	jmp	34B9h

l207F_3416:
	stc
	jmp	32F5h

l207F_341A:
	xchg	bx,ax
	mov	ax,cx
	and	ax,500h
	cmp	ax,500h
	jnz	342Eh

l207F_3425:
	mov	ah,3Eh
	int	21h
	mov	ax,1100h
	jmp	3416h

l207F_342E:
	mov	byte ptr [bp-3h],1h
	mov	ax,4400h
	int	21h
	test	dl,80h
	jz	3440h

l207F_343C:
	or	byte ptr [bp-4h],40h

l207F_3440:
	test	byte ptr [bp-4h],40h
	jz	3449h

l207F_3446:
	jmp	3526h

l207F_3449:
	mov	ax,[bp+0Ah]
	test	ax,200h
	jz	3470h

l207F_3451:
	test	ax,3h
	jz	345Fh

l207F_3456:
	xor	cx,cx
	mov	ah,40h
	int	21h
	jmp	3526h

l207F_345F:
	mov	ah,3Eh
	int	21h
	push	ds
	lds	dx,[bp+6h]
	mov	ax,4300h
	int	21h
	pop	ds
	jmp	34D6h
207F:346F                                              90                .

l207F_3470:
	test	byte ptr [bp-4h],80h
	jnz	3479h

l207F_3476:
	jmp	3526h

l207F_3479:
	test	ax,2h
	jnz	3481h

l207F_347E:
	jmp	3526h

l207F_3481:
	mov	cx,0FFFFh
	mov	dx,cx
	mov	ax,4202h
	int	21h
	neg	cx
	lea	dx,[bp-1h]
	mov	ah,3Fh
	int	21h
	or	ax,ax
	jz	34ADh

l207F_3498:
	cmp	byte ptr [bp-1h],1Ah
	jnz	34ADh

l207F_349E:
	neg	cx
	mov	dx,cx
	mov	ax,4202h
	int	21h
	xor	cx,cx
	mov	ah,40h
	int	21h

l207F_34AD:
	xor	cx,cx
	mov	dx,cx
	mov	ax,4200h
	int	21h
	jmp	3526h
207F:34B8                         90                              .       

l207F_34B9:
	mov	byte ptr [bp-3h],0h
	mov	cx,[bp+0Ch]
	call	356Fh
	mov	[bp+0Ch],cx
	test	byte ptr [bp-2h],0FFh
	jnz	34D3h

l207F_34CC:
	test	word ptr [bp+0Ah],2h
	jnz	34D6h

l207F_34D3:
	and	cl,0FEh

l207F_34D6:
	push	ds
	lds	dx,[bp+6h]
	mov	ah,3Ch
	int	21h
	pop	ds
	jnc	34E4h

l207F_34E1:
	jmp	32F5h

l207F_34E4:
	xchg	bx,ax
	test	byte ptr [bp-2h],0FFh
	jnz	34F2h

l207F_34EB:
	test	word ptr [bp+0Ah],2h
	jnz	3526h

l207F_34F2:
	mov	ah,3Eh
	int	21h
	mov	al,[bp+0Ah]
	and	al,3h
	or	al,[bp-2h]
	push	ds
	lds	dx,[bp+6h]
	mov	ah,3Dh
	int	21h
	pop	ds
	jc	34E1h

l207F_3509:
	xchg	bx,ax
	test	byte ptr [bp-3h],1h
	jnz	3526h

l207F_3510:
	test	word ptr [bp+0Ch],1h
	jz	3526h

l207F_3517:
	or	cl,1h
	push	ds
	lds	dx,[bp+6h]
	mov	ax,4301h
	int	21h
	pop	ds
	jc	34E1h

l207F_3526:
	test	byte ptr [bp-4h],40h
	jnz	356Bh

l207F_352C:
	push	ds
	lds	dx,[bp+6h]
	mov	ax,4300h
	int	21h
	pop	ds
	mov	ax,cx
	xor	cl,cl
	and	ax,1h
	jz	3541h

l207F_353F:
	mov	cl,10h

l207F_3541:
	test	word ptr [bp+0Ah],8h
	jz	354Bh

l207F_3548:
	or	cl,20h

l207F_354B:
	cmp	bx,[52FEh]
	jc	355Bh

l207F_3551:
	mov	ah,3Eh
	int	21h
	mov	ax,1800h
	jmp	3416h

l207F_355B:
	or	cl,[bp-4h]
	or	cl,1h
	mov	[bx+5300h],cl
	mov	ax,bx
	mov	sp,bp
	pop	bp
	retf

l207F_356B:
	xor	cl,cl
	jmp	354Bh

;; fn207F_356F: 207F:356F
;;   Called from:
;;     207F:34C0 (in fn207F_33D0)
fn207F_356F proc
	mov	ax,[52F3h]
	not	ax
	and	ax,cx
	xor	cx,cx
	test	al,80h
	jnz	357Fh

l207F_357C:
	or	cl,1h

l207F_357F:
	ret

;; fn207F_3580: 207F:3580
;;   Called from:
;;     0800:2F16 (in fn0800_2DA8)
;;     0800:2F2A (in fn0800_2DA8)
;;     0800:2F3E (in fn0800_2DA8)
;;     0800:2F52 (in fn0800_2DA8)
;;     0800:2F66 (in fn0800_2DA8)
;;     0800:2F7D (in fn0800_2DA8)
;;     0800:2F94 (in fn0800_2DA8)
;;     0800:2FAB (in fn0800_2DA8)
;;     0800:2FC2 (in fn0800_2DA8)
;;     0800:2FD9 (in fn0800_2DA8)
;;     0800:2FF0 (in fn0800_2DA8)
;;     0800:3007 (in fn0800_2DA8)
;;     0800:301E (in fn0800_2DA8)
;;     0800:303D (in fn0800_2DA8)
;;     0800:335B (in fn0800_32B3)
;;     0800:33A2 (in fn0800_32B3)
;;     0800:33B9 (in fn0800_32B3)
;;     0800:33D0 (in fn0800_32B3)
;;     0800:415F (in fn0800_3FAE)
;;     0800:417F (in fn0800_3FAE)
;;     0800:47D8 (in fn0800_476D)
;;     1F3D:0671 (in fn1F3D_063B)
;;     1F3D:0685 (in fn1F3D_063B)
;;     1F3D:0856 (in fn1F3D_0814)
fn207F_3580 proc
	push	bp
	mov	bp,sp
	sub	sp,2h
	mov	bx,[bp+6h]
	cmp	bx,[52FEh]
	jc	3595h

l207F_358F:
	stc
	mov	ax,900h
	jmp	35FCh

l207F_3595:
	xor	ax,ax
	mov	cx,[bp+0Ch]
	jcxz	35FCh

l207F_359C:
	test	byte ptr [bx+5300h],2h
	jnz	35FCh

l207F_35A3:
	mov	cx,[bp+0Ch]
	push	ds
	lds	dx,[bp+8h]
	mov	ah,3Fh
	int	21h
	pop	ds
	jnc	35B5h

l207F_35B1:
	mov	ah,9h
	jmp	35FCh

l207F_35B5:
	test	byte ptr [bx+5300h],80h
	jz	35FCh

l207F_35BC:
	and	byte ptr [bx+5300h],0FBh
	push	si
	push	di
	push	ds
	pop	es
	mov	ds,[bp+0Ah]
	cld
	mov	si,dx
	mov	di,dx
	mov	cx,ax
	jcxz	35F8h

l207F_35D1:
	mov	ah,0Dh
	cmp	byte ptr [si],0Ah
	jnz	35DEh

l207F_35D8:
	or	byte ptr es:[bx+5300h],4h

l207F_35DE:
	lodsb
	cmp	al,ah
	jz	35FFh

l207F_35E3:
	cmp	al,1Ah
	jnz	35EFh

l207F_35E7:
	or	byte ptr es:[bx+5300h],2h
	jmp	35F4h

l207F_35EF:
	mov	[di],al
	inc	di

l207F_35F2:
	loop	35DEh

l207F_35F4:
	mov	ax,di
	sub	ax,dx

l207F_35F8:
	push	es
	pop	ds

l207F_35FA:
	pop	di
	pop	si

l207F_35FC:
	jmp	32F5h

l207F_35FF:
	cmp	cx,1h
	jz	360Bh

l207F_3604:
	cmp	byte ptr [si],0Ah
	jz	35F2h

l207F_3609:
	jmp	35EFh

l207F_360B:
	push	es
	pop	ds
	test	byte ptr [bx+5300h],40h
	jz	362Ch

l207F_3614:
	mov	ax,4400h
	int	21h
	test	dx,20h
	jnz	3628h

l207F_361F:
	lea	dx,[bp-1h]
	mov	ah,3Fh
	int	21h
	jc	35FAh

l207F_3628:
	mov	al,0Ah
	jmp	3658h

l207F_362C:
	mov	byte ptr [bp-1h],0h
	lea	dx,[bp-1h]
	mov	ah,3Fh
	int	21h
	jc	35FAh

l207F_3639:
	or	ax,ax
	jz	3656h

l207F_363D:
	cmp	word ptr [bp+0Ch],1h
	jz	3662h

l207F_3643:
	mov	cx,0FFFFh
	mov	dx,cx
	mov	ax,4201h
	int	21h
	mov	cx,1h
	cmp	byte ptr [bp-1h],0Ah
	jz	365Dh

l207F_3656:
	mov	al,0Dh

l207F_3658:
	lds	dx,[bp+8h]
	jmp	35EFh

l207F_365D:
	lds	dx,[bp+8h]
	jmp	35F2h

l207F_3662:
	cmp	byte ptr [bp-1h],0Ah
	jnz	3643h

l207F_3668:
	jmp	3628h

;; fn207F_366A: 207F:366A
;;   Called from:
;;     0800:369B (in fn0800_35D3)
;;     0800:36BC (in fn0800_35D3)
;;     0800:36DD (in fn0800_35D3)
;;     0800:36FE (in fn0800_35D3)
fn207F_366A proc
	push	bp
	mov	bp,sp
	sub	sp,8h
	mov	bx,[bp+6h]
	cmp	bx,[52FEh]
	jc	3680h

l207F_3679:
	mov	ax,900h
	stc

l207F_367D:
	jmp	32F5h

l207F_3680:
	test	byte ptr [bx+5300h],20h
	jz	3692h

l207F_3687:
	mov	ax,4202h
	xor	cx,cx
	mov	dx,cx
	int	21h
	jc	367Dh

l207F_3692:
	test	byte ptr [bx+5300h],80h
	jz	3715h

l207F_3699:
	mov	[bp-6h],ds
	mov	es,[bp+0Ah]
	lds	dx,[bp+8h]
	xor	ax,ax
	mov	[bp-2h],ax
	mov	[bp-4h],ax
	cld
	push	di
	push	si
	mov	di,dx
	mov	si,dx
	mov	[bp-8h],sp
	mov	cx,[bp+0Ch]
	jcxz	3717h

l207F_36B9:
	mov	al,0Ah

l207F_36BB:
	repne scasb

l207F_36BD:
	jnz	3710h

l207F_36BF:
	push	ds
	mov	ds,[bp-6h]
	call	far 207Fh:37B4h
	pop	ds
	cmp	ax,0A8h
	jbe	3719h

l207F_36CE:
	sub	sp,2h
	mov	bx,sp
	mov	dx,200h
	cmp	ax,228h
	jnc	36DEh

l207F_36DB:
	mov	dx,80h

l207F_36DE:
	sub	sp,dx
	mov	dx,sp
	mov	di,dx
	push	ss
	pop	es
	mov	cx,[bp+0Ch]

l207F_36E9:
	lodsb
	cmp	al,0Ah
	jz	36FAh

l207F_36EE:
	cmp	di,bx
	jz	370Bh

l207F_36F2:
	stosb
	loop	36E9h

l207F_36F5:
	call	371Eh
	jmp	3769h

l207F_36FA:
	mov	al,0Dh
	cmp	di,bx
	jnz	3703h

l207F_3700:
	call	371Eh

l207F_3703:
	stosb
	mov	al,0Ah
	inc	word ptr [bp-4h]
	jmp	36EEh

l207F_370B:
	call	371Eh
	jmp	36F2h

l207F_3710:
	pop	si
	pop	di
	mov	ds,[bp-6h]

l207F_3715:
	jmp	377Ah

l207F_3717:
	jmp	3769h

l207F_3719:
	xor	ax,ax
	jmp	2E3Bh

;; fn207F_371E: 207F:371E
;;   Called from:
;;     207F:36F5 (in fn207F_366A)
;;     207F:3700 (in fn207F_366A)
;;     207F:370B (in fn207F_366A)
fn207F_371E proc
	push	ax
	push	bx
	push	cx
	push	ds
	push	es
	pop	ds
	mov	cx,di
	sub	cx,dx
	jcxz	373Ah

l207F_372A:
	mov	bx,[bp+6h]
	mov	ah,40h
	int	21h
	jc	3741h

l207F_3733:
	add	[bp-2h],ax
	or	ax,ax
	jz	3741h

l207F_373A:
	pop	ds
	pop	cx
	pop	bx
	pop	ax
	mov	di,dx
	ret

l207F_3741:
	pop	ds
	add	sp,8h
	jnc	374Bh

l207F_3747:
	mov	ah,9h
	jmp	376Fh

l207F_374B:
	mov	ds,[bp-2h]
	test	byte ptr [bx+5300h],40h
	jz	3763h

l207F_3755:
	mov	ds,[bp+0Ah]
	mov	bx,[bp+8h]
	cmp	byte ptr [bx],1Ah
	jnz	3763h

l207F_3760:
	clc
	jmp	376Fh

l207F_3763:
	stc
	mov	ax,1C00h
	jmp	376Fh

l207F_3769:
	mov	ax,[bp-2h]
	sub	ax,[bp-4h]

;; fn207F_376F: 207F:376F
;;   Called from:
;;     207F:3749 (in fn207F_371E)
;;     207F:3761 (in fn207F_371E)
;;     207F:3767 (in fn207F_371E)
;;     207F:376C (in fn207F_366A)
fn207F_376F proc
	mov	sp,[bp-8h]
	pop	si
	pop	di
	mov	ds,[bp-6h]

;; fn207F_3777: 207F:3777
;;   Called from:
;;     207F:3774 (in fn207F_376F)
;;     207F:3795 (in fn207F_366A)
;;     207F:3799 (in fn207F_366A)
;;     207F:37AB (in fn207F_366A)
;;     207F:37B1 (in fn207F_366A)
fn207F_3777 proc
	jmp	32F5h

l207F_377A:
	mov	cx,[bp+0Ch]
	or	cx,cx
	jnz	3786h

l207F_3781:
	mov	ax,cx
	jmp	32F5h

l207F_3786:
	push	ds
	lds	dx,[bp+8h]
	mov	ah,40h
	int	21h
	push	ds
	pop	es
	pop	ds
	jnc	3797h

l207F_3793:
	mov	ah,9h
	jmp	3777h

l207F_3797:
	or	ax,ax
	jnz	3777h

l207F_379B:
	test	byte ptr [bx+5300h],40h
	jz	37ADh

l207F_37A2:
	mov	bx,dx
	cmp	byte ptr es:[bx],1Ah
	jnz	37ADh

l207F_37AA:
	clc
	jmp	3777h

l207F_37AD:
	stc
	mov	ax,1C00h
	jmp	3777h
207F:37B3          00                                        .            

;; fn207F_37B4: 207F:37B4
;;   Called from:
;;     207F:36C3 (in fn207F_366A)
fn207F_37B4 proc
	pop	cx
	pop	dx
	mov	ax,[5334h]
	cmp	ax,sp
	jnc	37C4h

l207F_37BD:
	sub	ax,sp
	neg	ax

l207F_37C1:
	push	dx
	push	cx
	retf

l207F_37C4:
	xor	ax,ax
	jmp	37C1h
207F:37C8                         55 8B EC 8B 5E 06 0B DB         U...^...
207F:37D0 74 04 80 4F FE 01 8B E5 5D CB                   t..O....].      

;; fn207F_37DA: 207F:37DA
;;   Called from:
;;     207F:3866 (in fn207F_3835)
fn207F_37DA proc
	push	bp
	mov	bp,sp
	push	si
	push	di
	mov	bx,5350h
	cmp	word ptr [bx],0h
	jnz	3810h

l207F_37E7:
	push	ds
	pop	es
	mov	ax,5h
	call	3A3Ch
	jnz	37F6h

l207F_37F1:
	xor	ax,ax
	cwd
	jmp	381Ah

l207F_37F6:
	inc	ax
	and	al,0FEh
	mov	[5350h],ax
	mov	[5352h],ax
	xchg	si,ax
	mov	word ptr [si],1h
	add	si,4h
	mov	word ptr [si-2h],0FFFEh
	mov	[5356h],si

l207F_3810:
	mov	cx,[bp+6h]
	mov	ax,ds
	mov	es,ax
	call	38FDh

l207F_381A:
	pop	di
	pop	si
	mov	sp,bp
	pop	bp
	retf
207F:3820 55 8B EC C4 5E 06 8C C0 0B C3 74 05 26 80 4F FE U...^.....t.&.O.
207F:3830 01 8B E5 5D CB                                  ...].           

;; fn207F_3835: 207F:3835
;;   Called from:
;;     1F3D:05FD (in fn1F3D_05BC)
fn207F_3835 proc
	push	bp
	mov	bp,sp
	sub	sp,2h
	push	si
	push	di
	mov	ax,[bp+6h]
	cmp	ax,0FFF1h
	jnc	3863h

l207F_3845:
	cmp	word ptr [535Ah],0h
	jnz	3854h

l207F_384C:
	call	3874h
	jz	3863h

l207F_3851:
	mov	[535Ah],ax

l207F_3854:
	call	38E2h
	jnz	386Eh

l207F_3859:
	call	3874h
	jz	3863h

l207F_385E:
	call	38E2h
	jnz	386Eh

l207F_3863:
	push	word ptr [bp+6h]
	call	far 207Fh:37DAh
	add	sp,2h

l207F_386E:
	pop	di
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn207F_3874: 207F:3874
;;   Called from:
;;     207F:384C (in fn207F_3835)
;;     207F:3859 (in fn207F_3835)
fn207F_3874 proc
	mov	bx,0F0h
	cmp	[bp+6h],bx
	jbe	3883h

l207F_387C:
	mov	bx,[bp+6h]
	inc	bx
	and	bx,0FEh

l207F_3883:
	mov	[bp-2h],bx
	xor	ax,ax
	push	ds
	push	ax
	push	ax
	lea	cx,[bx+0Eh]
	push	cx
	mov	al,2h
	push	ax
	call	far 207Fh:3A5Eh
	add	sp,8h
	cmp	dx,0FFh
	jz	38E0h

l207F_389F:
	mov	ax,dx
	xchg	[535Ch],dx
	mov	[535Eh],ax
	cmp	ax,[5362h]
	jbe	38B1h

l207F_38AE:
	mov	[5362h],ax

l207F_38B1:
	or	dx,dx
	jz	38BAh

l207F_38B5:
	mov	ds,dx
	mov	[0008h],ax

l207F_38BA:
	mov	bx,[bp-2h]
	mov	ds,ax
	xor	ax,ax
	mov	[0008h],ax
	dec	ax
	dec	ax
	mov	[bx+0Ch],ax
	mov	ax,0Ah
	mov	[0000h],ax
	mov	[0002h],ax
	lea	ax,[bx+1h]
	mov	[000Ah],ax
	add	ax,0Dh
	mov	[0006h],ax
	mov	ax,ds

l207F_38E0:
	pop	ds
	ret

;; fn207F_38E2: 207F:38E2
;;   Called from:
;;     207F:3854 (in fn207F_3835)
;;     207F:385E (in fn207F_3835)
fn207F_38E2 proc
	mov	ax,ds
	mov	es,ax
	mov	cx,[bp+6h]
	xor	bx,bx
	mov	ds,[535Eh]
	call	38FDh
	or	dx,dx
	mov	cx,es
	mov	ds,cx
	ret
207F:38F9                            00                            .      

l207F_38FA:
	jmp	39CBh

;; fn207F_38FD: 207F:38FD
;;   Called from:
;;     207F:3817 (in fn207F_37DA)
;;     207F:38EF (in fn207F_38E2)
fn207F_38FD proc
	inc	cx
	jz	38FAh

l207F_3900:
	and	cl,0FEh
	cmp	cx,0EEh
	jnc	38FAh

l207F_3908:
	mov	si,[bx+2h]
	cld
	lodsw
	mov	di,si
	test	al,1h
	jz	3955h

l207F_3913:
	dec	ax
	cmp	ax,cx
	jnc	392Dh

l207F_3918:
	mov	dx,ax
	add	si,ax
	lodsw
	test	al,1h
	jz	3955h

l207F_3921:
	add	ax,dx
	add	ax,2h
	mov	si,di
	mov	[si-2h],ax
	jmp	3913h

l207F_392D:
	mov	di,si
	jz	393Dh

l207F_3931:
	add	di,cx
	mov	[si-2h],cx
	sub	ax,cx
	dec	ax
	mov	[di],ax
	jmp	3942h

l207F_393D:
	add	di,cx
	dec	byte ptr [si-2h]

l207F_3942:
	mov	ax,si
	mov	dx,ds
	mov	cx,ss
	cmp	dx,cx
	jz	3951h

l207F_394C:
	mov	es:[535Eh],ds

l207F_3951:
	mov	[bx+2h],di
	ret

l207F_3955:
	mov	byte ptr es:[5364h],2h

l207F_395B:
	cmp	ax,0FFFEh
	jz	3985h

l207F_3960:
	mov	di,si
	add	si,ax

l207F_3964:
	lodsw
	test	al,1h
	jz	395Bh

l207F_3969:
	mov	di,si

l207F_396B:
	dec	ax
	cmp	ax,cx
	jnc	392Dh

l207F_3970:
	mov	dx,ax
	add	si,ax
	lodsw
	test	al,1h
	jz	395Bh

l207F_3979:
	add	ax,dx
	add	ax,2h
	mov	si,di
	mov	[si-2h],ax
	jmp	396Bh

l207F_3985:
	mov	ax,[bx+8h]
	or	ax,ax
	jz	3990h

l207F_398C:
	mov	ds,ax
	jmp	39A4h

l207F_3990:
	dec	byte ptr es:[5364h]
	jz	39A8h

l207F_3997:
	mov	ax,ds
	mov	di,ss
	cmp	ax,di
	jz	39A4h

l207F_399F:
	mov	ds,es:[535Ah]

l207F_39A4:
	mov	si,[bx]
	jmp	3964h

l207F_39A8:
	mov	si,[bx+6h]
	xor	ax,ax
	call	3A1Ah
	cmp	ax,si
	jz	39C1h

l207F_39B4:
	and	al,1h
	inc	ax
	inc	ax
	cbw
	call	3A1Ah
	jz	39CBh

l207F_39BE:
	dec	byte ptr [di-2h]

l207F_39C1:
	call	39E0h
	jz	39CBh

l207F_39C6:
	xchg	si,ax
	dec	si
	dec	si
	jmp	3964h

l207F_39CB:
	mov	ax,ds
	mov	cx,ss
	cmp	ax,cx
	jz	39D7h

l207F_39D3:
	mov	es:[535Eh],ax

l207F_39D7:
	mov	ax,[bx]
	mov	[bx+2h],ax
	xor	ax,ax
	cwd
	ret

;; fn207F_39E0: 207F:39E0
;;   Called from:
;;     207F:39C1 (in fn207F_38FD)
fn207F_39E0 proc
	push	cx
	mov	ax,[di-2h]
	test	al,1h
	jz	39EBh

l207F_39E8:
	sub	cx,ax
	dec	cx

l207F_39EB:
	inc	cx
	inc	cx
	mov	dx,7FFFh

l207F_39F0:
	cmp	dx,es:[5360h]
	jbe	39FBh

l207F_39F7:
	shr	dx,1h
	jnz	39F0h

l207F_39FB:
	mov	ax,cx
	add	ax,si
	jc	3A16h

l207F_3A01:
	add	ax,dx
	jc	3A12h

l207F_3A05:
	not	dx
	and	ax,dx
	sub	ax,si
	call	3A1Ah
	jnz	3A18h

l207F_3A10:
	not	dx

l207F_3A12:
	shr	dx,1h
	jnz	39FBh

l207F_3A16:
	xor	ax,ax

l207F_3A18:
	pop	cx
	ret

;; fn207F_3A1A: 207F:3A1A
;;   Called from:
;;     207F:39AD (in fn207F_38FD)
;;     207F:39B9 (in fn207F_38FD)
;;     207F:3A0B (in fn207F_39E0)
fn207F_3A1A proc
	push	dx
	push	cx
	call	3A3Ch
	jz	3A39h

l207F_3A21:
	push	di
	mov	di,si
	mov	si,ax
	add	si,dx
	mov	word ptr [si-2h],0FFFEh
	mov	[bx+6h],si
	mov	dx,si
	sub	dx,di
	dec	dx
	mov	[di-2h],dx
	pop	ax

l207F_3A39:
	pop	cx
	pop	dx
	ret

;; fn207F_3A3C: 207F:3A3C
;;   Called from:
;;     207F:37EC (in fn207F_37DA)
;;     207F:3A1C (in fn207F_3A1A)
fn207F_3A3C proc
	push	bx
	push	ax
	xor	dx,dx
	push	ds
	push	dx
	push	dx
	push	ax
	mov	ax,1h
	push	ax
	push	es
	pop	ds
	call	far 207Fh:3A5Eh
	add	sp,8h
	cmp	dx,0FFh
	pop	ds
	pop	dx
	pop	bx
	jz	3A5Ch

l207F_3A5A:
	or	dx,dx

l207F_3A5C:
	ret
207F:3A5D                                        00                    .  

;; fn207F_3A5E: 207F:3A5E
;;   Called from:
;;     207F:3892 (in fn207F_3874)
;;     207F:3A4A (in fn207F_3A3C)
fn207F_3A5E proc
	push	bp
	mov	bp,sp
	push	si
	push	di
	push	es
	cmp	word ptr [bp+0Ah],0h
	jnz	3AA2h

l207F_3A6A:
	mov	di,5286h
	mov	dx,[bp+8h]
	mov	ax,[bp+6h]
	dec	ax
	jnz	3A7Dh

l207F_3A76:
	call	3ACCh
	jc	3AA2h

l207F_3A7B:
	jmp	3AC5h

l207F_3A7D:
	mov	si,[52D6h]
	dec	ax
	jz	3A95h

l207F_3A84:
	cmp	si,di
	jz	3A95h

l207F_3A88:
	mov	ax,[si+2h]
	mov	[bp+0Eh],ax
	push	si
	call	3ACCh
	pop	si
	jnc	3AC5h

l207F_3A95:
	add	si,4h
	cmp	si,52D6h
	jnc	3AA2h

l207F_3A9E:
	or	dx,dx
	jnz	3AA8h

l207F_3AA2:
	mov	ax,0FFFFh
	cwd
	jmp	3AC5h

l207F_3AA8:
	mov	bx,dx
	add	bx,0Fh
	rcr	bx,1h
	mov	cl,3h
	shr	bx,cl
	mov	ah,48h
	int	21h
	jc	3AA2h

l207F_3AB9:
	xchg	dx,ax
	mov	[si],ax
	mov	[si+2h],dx
	mov	[52D6h],si
	xor	ax,ax

l207F_3AC5:
	pop	es
	pop	di
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn207F_3ACC: 207F:3ACC
;;   Called from:
;;     207F:3A76 (in fn207F_3A5E)
;;     207F:3A8F (in fn207F_3A5E)
fn207F_3ACC proc
	mov	cx,[bp+0Eh]
	mov	si,di

l207F_3AD1:
	cmp	[si+2h],cx
	jz	3AE2h

l207F_3AD6:
	add	si,4h
	cmp	si,52D6h
	jnz	3AD1h

l207F_3ADF:
	stc
	jmp	3B21h

l207F_3AE2:
	mov	bx,dx
	add	bx,[si]
	jc	3B21h

l207F_3AE8:
	mov	dx,bx
	mov	es,cx
	cmp	si,di
	jnz	3AF6h

l207F_3AF0:
	cmp	[5280h],bx
	jnc	3B1Ch

l207F_3AF6:
	add	bx,0Fh
	rcr	bx,1h
	shr	bx,1h
	shr	bx,1h
	shr	bx,1h
	cmp	si,di
	jnz	3B0Eh

l207F_3B05:
	add	bx,cx
	mov	ax,[52F7h]
	sub	bx,ax
	mov	es,ax

l207F_3B0E:
	mov	ah,4Ah
	int	21h
	jc	3B21h

l207F_3B14:
	cmp	si,di
	jnz	3B1Ch

l207F_3B18:
	mov	[5280h],dx

l207F_3B1C:
	xchg	dx,ax
	xchg	[si],ax
	mov	dx,cx

l207F_3B21:
	ret

;; fn207F_3B22: 207F:3B22
;;   Called from:
;;     0800:2E10 (in fn0800_2DA8)
;;     0800:40F8 (in fn0800_3FAE)
;;     0800:48F0 (in fn0800_48B7)
;;     0DAB:04AF (in fn0DAB_0002)
;;     0DAB:04C4 (in fn0DAB_0002)
;;     0DAB:0659 (in fn0DAB_04F9)
;;     0DAB:07F6 (in fn0DAB_04F9)
;;     1631:1BD5 (in fn1631_1B8F)
;;     183B:1D25 (in fn183B_1C1F)
;;     183B:1D3A (in fn183B_1C1F)
;;     1AE8:0687 (in fn1AE8_000C)
;;     1AE8:069C (in fn1AE8_000C)
;;     1E56:045F (in fn1E56_03F5)
;;     1E56:04BF (in fn1E56_03F5)
;;     1E56:053E (in fn1E56_03F5)
;;     1E56:05C0 (in fn1E56_03F5)
;;     1E56:067D (in fn1E56_03F5)
;;     1E56:0796 (in fn1E56_03F5)
fn207F_3B22 proc
	push	bp
	mov	bp,sp
	mov	dx,di
	mov	bx,si
	push	ds
	les	di,[bp+6h]
	xor	ax,ax
	mov	cx,0FFFFh
	repne scasb
	lea	si,[di-1h]
	les	di,[bp+0Ah]
	mov	cx,0FFFFh
	repne scasb
	not	cx
	sub	di,cx
	mov	ax,es
	mov	ds,ax
	mov	es,[bp+8h]
	xchg	si,di
	mov	ax,[bp+6h]
	test	si,1h
	jz	3B57h

l207F_3B55:
	movsb
	dec	cx

l207F_3B57:
	shr	cx,1h
	rep movsw
	adc	cx,cx
	rep movsb
	mov	si,bx
	mov	di,dx
	pop	ds
	mov	dx,es
	pop	bp
	retf

;; fn207F_3B68: 207F:3B68
;;   Called from:
;;     0800:2DE4 (in fn0800_2DA8)
;;     0800:40CA (in fn0800_3FAE)
;;     0DAB:0494 (in fn0DAB_0002)
;;     0DAB:0625 (in fn0DAB_04F9)
;;     0DAB:07C2 (in fn0DAB_04F9)
;;     0DAB:1C4D (in fn0DAB_1AFE)
;;     1467:0146 (in fn1467_0002)
;;     1467:061F (in fn1467_0002)
;;     1467:0D2C (in fn1467_0B98)
;;     1543:0DFF (in fn1543_0CDE)
;;     1631:1BC0 (in fn1631_1B8F)
;;     183B:1D0A (in fn183B_1C1F)
;;     1AE8:04D2 (in fn1AE8_000C)
;;     1AE8:0586 (in fn1AE8_000C)
;;     1AE8:05A7 (in fn1AE8_000C)
;;     1AE8:0634 (in fn1AE8_000C)
;;     1AE8:0672 (in fn1AE8_000C)
;;     1E56:06EC (in fn1E56_03F5)
fn207F_3B68 proc
	push	bp
	mov	bp,sp
	mov	dx,di
	mov	bx,si
	push	ds
	lds	si,[bp+0Ah]
	mov	di,si
	mov	ax,ds
	mov	es,ax
	xor	ax,ax
	mov	cx,0FFFFh
	repne scasb
	not	cx
	les	di,[bp+6h]
	mov	ax,di
	test	al,1h
	jz	3B8Dh

l207F_3B8B:
	movsb
	dec	cx

l207F_3B8D:
	shr	cx,1h
	rep movsw
	adc	cx,cx
	rep movsb
	mov	si,bx
	mov	di,dx
	pop	ds
	mov	dx,es
	pop	bp
	retf

;; fn207F_3B9E: 207F:3B9E
;;   Called from:
;;     0DAB:0669 (in fn0DAB_04F9)
;;     0FDC:023B (in fn0FDC_01C0)
;;     1467:0156 (in fn1467_0002)
;;     1543:0165 (in fn1543_0004)
;;     1543:017C (in fn1543_0004)
;;     1543:02B7 (in fn1543_0004)
;;     1543:02CC (in fn1543_0004)
;;     1543:046A (in fn1543_0004)
;;     1543:0DD1 (in fn1543_0CDE)
;;     1543:0E1B (in fn1543_0CDE)
;;     1631:2053 (in fn1631_1FDF)
;;     1CD3:0285 (in fn1CD3_0004)
;;     1CD3:03C2 (in fn1CD3_0004)
;;     1CD3:0465 (in fn1CD3_0004)
;;     1CD3:059B (in fn1CD3_0004)
;;     1CD3:07F6 (in fn1CD3_0004)
;;     1E56:07F3 (in fn1E56_07CB)
;;     1E56:09FB (in fn1E56_07CB)
fn207F_3B9E proc
	push	bp
	mov	bp,sp
	mov	dx,di
	les	di,[bp+6h]
	xor	ax,ax
	mov	cx,0FFFFh
	repne scasb
	not	cx
	dec	cx
	xchg	cx,ax
	mov	di,dx
	pop	bp
	retf
207F:3BB5                00                                    .          

;; fn207F_3BB6: 207F:3BB6
;;   Called from:
;;     0800:2DFB (in fn0800_2DA8)
;;     0800:40E3 (in fn0800_3FAE)
;;     0800:48DB (in fn0800_48B7)
;;     0DAB:1C9D (in fn0DAB_1AFE)
;;     1543:02A7 (in fn1543_0004)
;;     1CD3:0267 (in fn1CD3_0004)
;;     1F3D:006C (in fn1F3D_0053)
fn207F_3BB6 proc
	push	bp
	mov	bp,sp
	push	si
	push	di
	mov	bl,1h
	mov	cx,[bp+0Ch]
	mov	ax,[bp+6h]
	xor	dx,dx
	cmp	cx,0Ah
	jnz	3BCBh

l207F_3BCA:
	cwd

l207F_3BCB:
	push	ds
	lds	di,[bp+8h]
	jmp	3C15h

;; fn207F_3BD2: 207F:3BD2
;;   Called from:
;;     1631:2043 (in fn1631_1FDF)
;;     1CD3:03A8 (in fn1CD3_0004)
;;     1CD3:0446 (in fn1CD3_0004)
;;     1CD3:0581 (in fn1CD3_0004)
;;     1CD3:062E (in fn1CD3_0004)
;;     1CD3:06E1 (in fn1CD3_0004)
;;     1CD3:07DC (in fn1CD3_0004)
;;     1CD3:087E (in fn1CD3_0004)
;;     1CD3:0931 (in fn1CD3_0004)
;;     1CD3:0989 (in fn1CD3_0004)
fn207F_3BD2 proc
	push	bp
	mov	bp,sp
	push	si
	push	di
	mov	bl,1h
	jmp	3C08h

;; fn207F_3BDC: 207F:3BDC
;;   Called from:
;;     1F3D:0036 (in fn1F3D_002F)
;;     1F3D:02E1 (in fn1F3D_0259)
fn207F_3BDC proc
	mov	ax,[5366h]
	or	ah,ah
	mov	al,0FFh
	jz	3BEBh

l207F_3BE5:
	mov	ah,0Bh
	int	21h
	mov	ah,0h

l207F_3BEB:
	retf
207F:3BEC                                     B6 01 EB 02             ....
207F:3BF0 B6 08 A1 66 53 0A E4 75 08 C7 06 66 53 FF FF EB ...fS..u...fS...
207F:3C00 05 92 CD 21 B4 00 CB 00                         ...!....        

l207F_3C08:
	mov	cx,[bp+0Eh]
	mov	ax,[bp+6h]
	mov	dx,[bp+8h]
	push	ds
	lds	di,[bp+0Ah]

;; fn207F_3C15: 207F:3C15
;;   Called from:
;;     207F:3BCF (in fn207F_3BB6)
;;     207F:3C12 (in fn207F_3BD2)
fn207F_3C15 proc
	push	di
	push	ds
	pop	es
	cld
	xchg	bx,ax
	or	al,al
	jz	3C31h

;; fn207F_3C1E: 207F:3C1E
;;   Called from:
;;     207F:3C1C (in fn207F_3C15)
;;     207F:3C1C (in fn207F_3C15)
fn207F_3C1E proc
	cmp	cx,0Ah
	jnz	3C31h

l207F_3C23:
	or	dx,dx
	jns	3C31h

l207F_3C27:
	mov	al,2Dh
	stosb
	neg	bx
	adc	dx,0h
	neg	dx

;; fn207F_3C31: 207F:3C31
;;   Called from:
;;     207F:3C1C (in fn207F_3C15)
;;     207F:3C1C (in fn207F_3C15)
;;     207F:3C21 (in fn207F_3C1E)
;;     207F:3C25 (in fn207F_3C1E)
;;     207F:3C2F (in fn207F_3C1E)
fn207F_3C31 proc
	mov	si,di

l207F_3C33:
	xchg	dx,ax
	xor	dx,dx
	or	ax,ax
	jz	3C3Ch

l207F_3C3A:
	div	cx

l207F_3C3C:
	xchg	bx,ax
	div	cx
	xchg	dx,ax
	xchg	bx,dx
	add	al,30h
	cmp	al,39h
	jbe	3C4Ah

l207F_3C48:
	add	al,27h

l207F_3C4A:
	stosb
	mov	ax,dx
	or	ax,bx
	jnz	3C33h

l207F_3C51:
	mov	[di],al

l207F_3C53:
	dec	di
	lodsb
	xchg	[di],al
	mov	[si-1h],al
	lea	ax,[si+1h]
	cmp	ax,di
	jc	3C53h

l207F_3C61:
	mov	dx,ds
	pop	ax
	pop	ds
	pop	di
	pop	si
	mov	sp,bp
	pop	bp
	retf
207F:3C6B                                  00                        .    

;; fn207F_3C6C: 207F:3C6C
;;   Called from:
;;     1631:0A1C (in fn1631_03AB)
;;     1631:0A30 (in fn1631_03AB)
;;     1631:18FD (in fn1631_16AB)
;;     1631:198E (in fn1631_16AB)
;;     1631:1AFF (in fn1631_16AB)
;;     1AE8:182E (in fn1AE8_12C7)
;;     1AE8:1842 (in fn1AE8_12C7)
;;     1AE8:1867 (in fn1AE8_12C7)
;;     1AE8:1875 (in fn1AE8_12C7)
fn207F_3C6C proc
	push	bp
	mov	bp,sp
	cmp	word ptr [bp+6h],0h
	jl	3C7Ah

l207F_3C75:
	mov	ax,[bp+6h]
	jmp	3C7Fh

l207F_3C7A:
	mov	ax,[bp+6h]
	neg	ax

l207F_3C7F:
	pop	bp
	retf
207F:3C81    90                                            .              

;; fn207F_3C82: 207F:3C82
;;   Called from:
;;     0DAB:0D09 (in fn0DAB_0C8F)
fn207F_3C82 proc
	push	bp
	mov	bp,sp
	les	dx,[bp+6h]
	mov	[536Ah],es
	mov	[5368h],dx
	push	ds
	mov	ax,cs
	mov	ds,ax
	mov	dx,3CA5h
	mov	al,24h
	mov	ah,25h
	int	21h
	pop	ds
	xor	ax,ax
	mov	sp,bp
	pop	bp
	retf
207F:3CA5                06 1E 55 57 56 52 51 53 50 BB DB      ..UWVRQSP..
207F:3CB0 3E 8E DB 89 26 6C 53 55 56 57 50 FF 1E 68 53 8B >...&lSUVWP..hS.
207F:3CC0 26 6C 53 83 C4 02 5B 59 5A 5E 5F 5D 1F 07 CF 55 &lS...[YZ^_]...U
207F:3CD0 8B EC 8B 46 06 EB E8 00 55 8B EC B4 30 CD 21 8B ...F....U...0.!.
207F:3CE0 26 6C 53 83 C4 18 8B DC 8B 07 80 FC 38 72 0C 80 &lS.........8r..
207F:3CF0 4F 16 01 8B 46 06 EA C3 3C 7F 20 8B D0 B1 04 D3 O...F...<. .....
207F:3D00 EA D2 EA 8A CA FE C1 8A DE 32 FF D1 E3 8B 97 6E .........2.....n
207F:3D10 53 D3 E2 73 02 B0 FF EA C3 3C 7F 20             S..s.....<.     

;; fn207F_3D1C: 207F:3D1C
;;   Called from:
;;     0800:039D (in fn0800_0000)
;;     0800:03F6 (in fn0800_0000)
fn207F_3D1C proc
	push	bp
	mov	bp,sp
	les	bx,[bp+6h]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr es:[bx+2h]
	push	word ptr es:[bx]
	call	far 207Fh:3E2Eh
	les	bx,[bp+6h]
	mov	es:[bx],ax
	mov	es:[bx+2h],dx
	mov	sp,bp
	pop	bp
	retf	8h

;; fn207F_3D44: 207F:3D44
;;   Called from:
;;     0800:03B8 (in fn0800_0000)
;;     0800:0417 (in fn0800_0000)
fn207F_3D44 proc
	push	bp
	mov	bp,sp
	les	bx,[bp+6h]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr es:[bx+2h]
	push	word ptr es:[bx]
	call	far 207Fh:3E62h
	les	bx,[bp+6h]
	mov	es:[bx+2h],dx
	mov	es:[bx],ax
	mov	sp,bp
	pop	bp
	retf	8h

;; fn207F_3D6C: 207F:3D6C
;;   Called from:
;;     0800:0442 (in fn0800_0000)
fn207F_3D6C proc
	push	bp
	mov	bp,sp
	les	bx,[bp+6h]
	mov	ax,es:[bx]
	mov	dx,es:[bx+2h]
	mov	cx,[bp+0Ah]
	call	far 207Fh:3EC4h
	les	bx,[bp+6h]
	mov	es:[bx],ax
	mov	es:[bx+2h],dx
	mov	sp,bp
	pop	bp
	retf	6h
207F:3D91    00                                            .              

;; fn207F_3D92: 207F:3D92
;;   Called from:
;;     0DAB:0C41 (in fn0DAB_0B95)
fn207F_3D92 proc
	push	bp
	mov	bp,sp
	push	di
	push	si
	push	bx
	xor	di,di
	mov	ax,[bp+8h]
	or	ax,ax
	jge	3DB2h

l207F_3DA1:
	inc	di
	mov	dx,[bp+6h]
	neg	ax
	neg	dx
	sbb	ax,0h
	mov	[bp+8h],ax
	mov	[bp+6h],dx

l207F_3DB2:
	mov	ax,[bp+0Ch]
	or	ax,ax
	jge	3DCAh

l207F_3DB9:
	inc	di
	mov	dx,[bp+0Ah]
	neg	ax
	neg	dx
	sbb	ax,0h
	mov	[bp+0Ch],ax
	mov	[bp+0Ah],dx

l207F_3DCA:
	or	ax,ax
	jnz	3DE3h

l207F_3DCE:
	mov	cx,[bp+0Ah]
	mov	ax,[bp+8h]
	xor	dx,dx
	div	cx
	mov	bx,ax
	mov	ax,[bp+6h]
	div	cx
	mov	dx,bx
	jmp	3E1Bh

l207F_3DE3:
	mov	bx,ax
	mov	cx,[bp+0Ah]
	mov	dx,[bp+8h]
	mov	ax,[bp+6h]

l207F_3DEE:
	shr	bx,1h
	rcr	cx,1h
	shr	dx,1h
	rcr	ax,1h
	or	bx,bx
	jnz	3DEEh

l207F_3DFA:
	div	cx
	mov	si,ax
	mul	word ptr [bp+0Ch]
	xchg	cx,ax
	mov	ax,[bp+0Ah]
	mul	si
	add	dx,cx
	jc	3E17h

l207F_3E0B:
	cmp	dx,[bp+8h]
	ja	3E17h

l207F_3E10:
	jc	3E18h

l207F_3E12:
	cmp	ax,[bp+6h]
	jbe	3E18h

l207F_3E17:
	dec	si

l207F_3E18:
	xor	dx,dx
	xchg	si,ax

l207F_3E1B:
	dec	di
	jnz	3E25h

l207F_3E1E:
	neg	dx
	neg	ax
	sbb	dx,0h

l207F_3E25:
	pop	bx
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf	8h

;; fn207F_3E2E: 207F:3E2E
;;   Called from:
;;     0DAB:0C3A (in fn0DAB_0B95)
;;     1543:0E97 (in fn1543_0CDE)
;;     207F:3D2F (in fn207F_3D1C)
fn207F_3E2E proc
	push	bp
	mov	bp,sp
	mov	ax,[bp+8h]
	mov	bx,[bp+0Ch]
	or	bx,ax
	mov	bx,[bp+0Ah]
	jnz	3E49h

l207F_3E3E:
	mov	ax,[bp+6h]
	mul	bx
	mov	sp,bp
	pop	bp
	retf	8h

l207F_3E49:
	mul	bx
	mov	cx,ax
	mov	ax,[bp+6h]
	mul	word ptr [bp+0Ch]
	add	cx,ax
	mov	ax,[bp+6h]
	mul	bx
	add	dx,cx
	mov	sp,bp
	pop	bp
	retf	8h

;; fn207F_3E62: 207F:3E62
;;   Called from:
;;     207F:3D57 (in fn207F_3D44)
fn207F_3E62 proc
	push	bp
	mov	bp,sp
	push	bx
	push	si
	mov	ax,[bp+0Ch]
	or	ax,ax
	jnz	3E83h

l207F_3E6E:
	mov	cx,[bp+0Ah]
	mov	ax,[bp+8h]
	xor	dx,dx
	div	cx
	mov	bx,ax
	mov	ax,[bp+6h]
	div	cx
	mov	dx,bx
	jmp	3EBBh

l207F_3E83:
	mov	cx,ax
	mov	bx,[bp+0Ah]
	mov	dx,[bp+8h]
	mov	ax,[bp+6h]

l207F_3E8E:
	shr	cx,1h
	rcr	bx,1h
	shr	dx,1h
	rcr	ax,1h
	or	cx,cx
	jnz	3E8Eh

l207F_3E9A:
	div	bx
	mov	si,ax
	mul	word ptr [bp+0Ch]
	xchg	cx,ax
	mov	ax,[bp+0Ah]
	mul	si
	add	dx,cx
	jc	3EB7h

l207F_3EAB:
	cmp	dx,[bp+8h]
	ja	3EB7h

l207F_3EB0:
	jc	3EB8h

l207F_3EB2:
	cmp	ax,[bp+6h]
	jbe	3EB8h

l207F_3EB7:
	dec	si

l207F_3EB8:
	xor	dx,dx
	xchg	si,ax

l207F_3EBB:
	pop	si
	pop	bx
	mov	sp,bp
	pop	bp
	retf	8h
207F:3EC3          00                                        .            

;; fn207F_3EC4: 207F:3EC4
;;   Called from:
;;     207F:3D7C (in fn207F_3D6C)
fn207F_3EC4 proc
	xor	ch,ch
	jcxz	3ECEh

l207F_3EC8:
	shr	dx,1h
	rcr	ax,1h
	loop	3EC8h

l207F_3ECE:
	retf
207F:3ECF                                              00                .
