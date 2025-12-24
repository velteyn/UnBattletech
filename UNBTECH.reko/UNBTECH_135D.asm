;;; Segment 135D (135D:0000)
135D:0000 8B E5 5D CB                                     ..].            

;; fn135D_0004: 135D:0004
;;   Called from:
;;     0800:34CE (in fn0800_32B3)
;;     0FDC:01B7 (in fn0FDC_0008)
fn135D_0004 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-4h],0h

l135D_0014:
	mov	ax,7Dh
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[54FAh]
	mov	al,es:[bx+0C724h]
	mov	bx,[bp-4h]
	mov	es,[54FCh]
	mov	es:[bx+3248h],al
	mov	ax,7Dh
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[54FAh]
	mov	byte ptr es:[bx+0C724h],0FFh
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],4h
	jl	0014h

l135D_004C:
	mov	word ptr [bp-4h],0h

l135D_0051:
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[54FAh]
	mov	byte ptr es:[bx+0C620h],0h
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],8h
	jl	0051h

l135D_006C:
	mov	es,[54FEh]
	mov	word ptr es:[0A44Bh],0C06h
	mov	es,[5500h]
	mov	word ptr es:[0A44Dh],0C07Eh
	mov	ax,1B0h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,2h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	word ptr [bp-4h],0h

l135D_00A3:
	mov	bx,[bp-4h]
	mov	es,[5502h]
	mov	byte ptr es:[bx+564h],0D0h
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],240h
	jl	00A3h

l135D_00BA:
	mov	ax,0Eh
	push	ax
	mov	ax,4h
	push	ax
	call	far 0800h:2DA8h
	add	sp,4h
	mov	word ptr [bp-4h],0h

l135D_00CF:
	mov	bx,[bp-4h]
	mov	es,[5504h]
	mov	byte ptr es:[bx+9F3h],0FFh
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],3h
	jl	00CFh

l135D_00E5:
	mov	es,[5506h]
	mov	word ptr es:[4FBCh],1h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,2068h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5508h]
	cmp	word ptr es:[4FBAh],2h
	jnz	013Dh

l135D_0129:
	mov	ax,0A400h
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l135D_013D:
	mov	es,[550Ah]
	mov	word ptr es:[3988h],2h
	call	far 207Fh:1DA8h
	mov	es,[5500h]
	push	word ptr es:[0A44Dh]
	mov	es,[54FEh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 1F3Dh:06C3h
	mov	ax,3Ch
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	mov	ax,0FFFFh
	push	ax
	mov	ax,97Dh
	push	ax
	mov	ax,0C03h
	push	ax
	push	cs
	call	0AB6h
	add	sp,6h
	mov	word ptr [bp-4h],0h

l135D_0195:
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[54FAh]
	mov	byte ptr es:[bx+0C620h],8h
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],8h
	jl	0195h

l135D_01B0:
	mov	ax,17h
	push	ax
	call	far 0FDCh:0008h
	add	sp,2h
	mov	word ptr [bp-2h],0h

l135D_01C1:
	mov	bx,[bp-2h]
	mov	es,[54FAh]
	cmp	byte ptr es:[bx+0D34Fh],0h
	jz	01DCh

l135D_01D0:
	push	bx
	sub	ax,ax
	push	ax
	push	ax
	push	cs
	call	0AB6h
	add	sp,6h

l135D_01DC:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],0Bh
	jl	01C1h

l135D_01E5:
	mov	sp,bp
	pop	bp
	retf

;; fn135D_01E9: 135D:01E9
;;   Called from:
;;     0800:1F2F (in fn0800_1C12)
fn135D_01E9 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0A10h
	mov	word ptr [bp-4h],0h

l135D_01FF:
	mov	word ptr [bp-6h],0h

l135D_0204:
	mov	ax,3h
	imul	word ptr [bp-4h]
	mov	si,ax
	mov	bx,[bp-6h]
	mov	al,[bx+si+20BCh]
	mov	bx,[bp-2h]
	add	bx,[bp-6h]
	mov	es,[550Ch]
	mov	es:[bx+101Dh],al
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],3h
	jl	0204h

l135D_022B:
	add	word ptr [bp-2h],8h
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],6h
	jl	01FFh

l135D_0238:
	mov	es,[5500h]
	push	word ptr es:[0A44Dh]
	mov	es,[54FEh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:051Bh
	call	far 1F3Dh:06C3h
	call	far 1CD3h:17C6h
	mov	ax,2075h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn135D_0288: 135D:0288
;;   Called from:
;;     0800:1F57 (in fn0800_1C12)
fn135D_0288 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[54FAh]
	cmp	byte ptr es:[0D34Bh],0h
	jnz	02A7h

l135D_029B:
	mov	ax,16h
	push	ax
	call	far 0FDCh:0008h
	add	sp,2h

l135D_02A7:
	retf

;; fn135D_02A8: 135D:02A8
;;   Called from:
;;     0800:1F71 (in fn0800_1C12)
fn135D_02A8 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	call	far 1CD3h:17C6h
	mov	ax,20CEh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h
	retf

;; fn135D_02D2: 135D:02D2
;;   Called from:
;;     0800:1F9C (in fn0800_1C12)
fn135D_02D2 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	inc	ax
	and	ax,7Eh
	mov	[bp+6h],ax
	and	word ptr [bp+8h],7Eh
	cmp	ax,4Eh
	jnz	0325h

l135D_02EF:
	cmp	word ptr [bp+8h],0Ch
	jl	0325h

l135D_02F5:
	cmp	word ptr [bp+8h],11h
	jg	0325h

l135D_02FB:
	call	far 1CD3h:17C6h
	mov	ax,2113h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	al,1h
	mov	es,[54FAh]
	mov	es:[0D34Ch],al
	cbw
	mov	es,[550Eh]
	mov	es:[0D55Ch],ax

l135D_0325:
	pop	bp
	retf

;; fn135D_0327: 135D:0327
;;   Called from:
;;     0800:3D7A (in fn0800_3D40)
;;     0800:3FA4 (in fn0800_3D40)
fn135D_0327 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-4h],0h
	jmp	0360h

l135D_0339:
	mov	bx,[bp-4h]
	mov	es,[5514h]
	mov	al,es:[bx+2257h]
	mov	es,[5510h]
	mov	es:[bx+215Dh],al
	mov	al,[bp-2h]
	mov	bx,[bp-4h]
	mov	es,[5514h]
	mov	es:[bx+2257h],al

l135D_035D:
	inc	word ptr [bp-4h]

l135D_0360:
	cmp	word ptr [bp-4h],0FAh
	jge	03A6h

l135D_0367:
	mov	bx,[bp-4h]
	mov	es,[5510h]
	mov	al,es:[bx+215Dh]
	cbw
	mov	[bp-2h],ax
	mov	es,[54FAh]
	cmp	byte ptr es:[0D34Eh],0h
	jz	0339h

l135D_0383:
	mov	es,[5512h]
	mov	al,es:[bx+2351h]
	mov	es,[5510h]
	mov	es:[bx+215Dh],al
	mov	al,[bp-2h]
	mov	bx,[bp-4h]
	mov	es,[5512h]
	mov	es:[bx+2351h],al
	jmp	035Dh

l135D_03A6:
	mov	sp,bp
	pop	bp
	retf

;; fn135D_03AA: 135D:03AA
;;   Called from:
;;     0800:1F48 (in fn0800_1C12)
fn135D_03AA proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,[bp+6h]
	inc	ax
	and	ax,7Fh
	mov	[bp+6h],ax
	and	word ptr [bp+8h],7Fh
	mov	word ptr [bp-2h],0h
	jmp	0454h

l135D_03CC:
	mov	ax,2187h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-2h]
	mov	al,[bx+2212h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+2236h]
	push	word ptr [bx+2234h]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,21B2h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-2h]
	inc	ax
	push	ax
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,21B9h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jz	0446h

l135D_042E:
	mov	al,[bp-2h]
	mov	bx,[bp-2h]
	mov	cx,ax
	mov	al,[bx+2212h]
	cbw
	mov	bx,ax
	mov	es,[54FAh]
	mov	es:[bx+0D347h],cl

l135D_0446:
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h

l135D_0451:
	inc	word ptr [bp-2h]

l135D_0454:
	cmp	word ptr [bp-2h],21h
	jge	04A6h

l135D_045A:
	mov	bx,[bp-2h]
	mov	al,[bx+21F0h]
	cbw
	cmp	ax,[bp+8h]
	jnz	0451h

l135D_0467:
	mov	al,[bx+21CEh]
	cbw
	mov	si,ax
	cmp	[bp+6h],si
	jl	0451h

l135D_0473:
	lea	ax,[si+3h]
	cmp	[bp+6h],ax
	jge	0451h

l135D_047B:
	call	far 1CD3h:17C6h
	mov	bx,[bp-2h]
	mov	es,[5516h]
	cmp	byte ptr es:[bx+45DEh],0h
	jnz	0492h

l135D_048F:
	jmp	03CCh

l135D_0492:
	mov	ax,215Dh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	0446h

l135D_04A6:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn135D_04AB: 135D:04AB
;;   Called from:
;;     0800:1F82 (in fn0800_1C12)
fn135D_04AB proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	inc	ax
	and	ax,7Eh
	mov	[bp+6h],ax
	and	word ptr [bp+8h],7Eh
	cmp	word ptr [bp+8h],4h
	jnz	04CEh

l135D_04C9:
	cmp	ax,4h
	jz	04DDh

l135D_04CE:
	cmp	word ptr [bp+6h],2h
	jz	04D7h

l135D_04D4:
	jmp	0558h

l135D_04D7:
	cmp	word ptr [bp+8h],0Eh
	jnz	0558h

l135D_04DD:
	mov	es,[54FAh]
	cmp	byte ptr es:[0D34Ch],0h
	jnz	04F3h

l135D_04E9:
	call	far 1CD3h:17C6h
	mov	ax,2240h
	jmp	053Eh

l135D_04F3:
	mov	es,[54FAh]
	cmp	byte ptr es:[0D34Ah],1h
	jz	0509h

l135D_04FF:
	call	far 1CD3h:17C6h
	mov	ax,2275h
	jmp	053Eh

l135D_0509:
	mov	es,[54FAh]
	cmp	byte ptr es:[0D34Dh],0h
	jz	0536h

l135D_0515:
	mov	ax,19h
	push	ax
	call	far 0FDCh:0008h
	add	sp,2h
	mov	es,[550Eh]
	mov	ax,1h
	mov	es:[0D55Ch],ax
	mov	es,[5518h]
	mov	es:[01A8h],ax
	jmp	0558h

l135D_0536:
	call	far 1CD3h:17C6h
	mov	ax,228Bh

l135D_053E:
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h

l135D_0558:
	pop	bp
	retf

;; fn135D_055A: 135D:055A
;;   Called from:
;;     0800:1FB3 (in fn0800_1C12)
fn135D_055A proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	inc	ax
	and	ax,7Eh
	mov	[bp+6h],ax
	and	word ptr [bp+8h],7Eh
	cmp	ax,7Ch
	jnz	059Dh

l135D_0578:
	cmp	word ptr [bp+8h],4h
	jnz	059Dh

l135D_057E:
	mov	ax,18h
	push	ax
	call	far 0FDCh:0008h
	add	sp,2h
	mov	al,1h
	mov	es,[54FAh]
	mov	es:[0D34Dh],al
	cbw
	mov	es,[550Eh]
	mov	es:[0D55Ch],ax

l135D_059D:
	cmp	word ptr [bp+6h],48h
	jz	05A6h

l135D_05A3:
	jmp	0798h

l135D_05A6:
	cmp	word ptr [bp+8h],38h
	jz	05AFh

l135D_05AC:
	jmp	0798h

l135D_05AF:
	call	far 1CD3h:17C6h
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h
	mov	es,[54FAh]
	cmp	byte ptr es:[0D34Ah],1h
	jnz	05E0h

l135D_05CB:
	mov	ax,22C7h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	0798h

l135D_05E0:
	mov	ax,22E8h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	call	far 1E56h:0388h
	mov	ax,2328h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[551Ah]
	mov	word ptr es:[015Ah],1h
	mov	es,[54FEh]
	mov	word ptr es:[0A44Bh],0C04h
	mov	es,[5500h]
	mov	word ptr es:[0A44Dh],0C022h
	mov	ax,1D0h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,2h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	word ptr [bp-8h],0h

l135D_064B:
	mov	bx,[bp-8h]
	mov	es,[5502h]
	mov	byte ptr es:[bx+564h],0D1h
	inc	word ptr [bp-8h]
	cmp	word ptr [bp-8h],240h
	jl	064Bh

l135D_0662:
	mov	es,[5506h]
	mov	word ptr es:[4FBCh],1h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,2355h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5508h]
	cmp	word ptr es:[4FBAh],2h
	jnz	06BAh

l135D_06A6:
	mov	ax,0A400h
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l135D_06BA:
	mov	word ptr [bp-8h],0h

l135D_06BF:
	mov	bx,[bp-8h]
	mov	es,[550Ch]
	mov	al,es:[bx+101Dh]
	mov	es,[551Ch]
	mov	es:[bx+4614h],al
	inc	word ptr [bp-8h]
	cmp	word ptr [bp-8h],300h
	jl	06BFh

l135D_06DE:
	mov	es,[550Ah]
	mov	word ptr es:[3988h],3h
	mov	ax,300h
	push	ax
	mov	ax,101Dh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,235Dh
	push	ds
	push	ax
	call	far 1F3Dh:0814h
	add	sp,0Ah
	mov	es,[54FAh]
	mov	byte ptr es:[0D34Eh],1h
	mov	word ptr [bp-2h],90h
	mov	word ptr [bp-6h],0h
	jmp	073Fh

l135D_0718:
	inc	word ptr [bp-4h]

l135D_071B:
	cmp	word ptr [bp-4h],4h
	jge	073Ch

l135D_0721:
	mov	ax,[bp-2h]
	inc	word ptr [bp-2h]
	mov	bx,[bp-6h]
	mov	cl,3h
	shl	bx,cl
	add	bx,[bp-4h]
	mov	es,[551Eh]
	mov	es:[bx+664h],al
	jmp	0718h

l135D_073C:
	inc	word ptr [bp-6h]

l135D_073F:
	cmp	word ptr [bp-6h],3h
	jge	074Ch

l135D_0745:
	mov	word ptr [bp-4h],0h
	jmp	071Bh

l135D_074C:
	call	far 207Fh:1DA8h
	mov	es,[5500h]
	push	word ptr es:[0A44Dh]
	mov	es,[54FEh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	mov	es,[5508h]
	cmp	word ptr es:[4FBAh],0h
	jnz	0788h

l135D_077C:
	mov	ax,1h
	push	ax
	call	far 207Fh:0BA7h
	add	sp,2h

l135D_0788:
	call	far 1F3Dh:06C3h
	mov	es,[5520h]
	mov	word ptr es:[0150h],8Bh

l135D_0798:
	mov	sp,bp
	pop	bp
	retf

;; fn135D_079C: 135D:079C
;;   Called from:
;;     0800:1CD8 (in fn0800_1C12)
fn135D_079C proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	call	far 1CD3h:17C6h
	mov	ax,2367h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	mov	es,[54FEh]
	mov	word ptr es:[0A44Bh],0C45h
	mov	es,[5500h]
	mov	word ptr es:[0A44Dh],0C039h
	mov	ax,1B0h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,2h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	word ptr [bp-2h],0h

l135D_07F5:
	mov	bx,[bp-2h]
	mov	es,[5502h]
	mov	byte ptr es:[bx+564h],0D0h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],240h
	jl	07F5h

l135D_080C:
	mov	word ptr [bp-2h],0h

l135D_0811:
	mov	bx,[bp-2h]
	mov	es,[551Ch]
	mov	al,es:[bx+4614h]
	mov	es,[550Ch]
	mov	es:[bx+101Dh],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],300h
	jl	0811h

l135D_0830:
	mov	es,[5506h]
	mov	ax,1h
	mov	es:[4FBCh],ax
	mov	es,[550Eh]
	mov	es:[0D55Ch],ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,23A5h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5508h]
	cmp	word ptr es:[4FBAh],2h
	jnz	0890h

l135D_087C:
	mov	ax,0A400h
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l135D_0890:
	mov	es,[550Ah]
	mov	word ptr es:[3988h],2h
	mov	word ptr [bp-2h],0h

l135D_08A0:
	mov	al,[bp-2h]
	sub	al,70h
	mov	bx,[bp-2h]
	mov	es,[551Eh]
	mov	es:[bx+664h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],40h
	jl	08A0h

l135D_08BA:
	call	far 207Fh:1DA8h
	mov	es,[5500h]
	push	word ptr es:[0A44Dh]
	mov	es,[54FEh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	mov	es,[5508h]
	cmp	word ptr es:[4FBAh],0h
	jnz	08F5h

l135D_08EA:
	sub	ax,ax
	push	ax
	call	far 207Fh:0BA7h
	add	sp,2h

l135D_08F5:
	call	far 1F3Dh:06C3h
	mov	es,[54FAh]
	mov	byte ptr es:[0D34Eh],0h
	mov	es,[5520h]
	mov	word ptr es:[0150h],21h
	mov	sp,bp
	pop	bp
	retf

;; fn135D_0913: 135D:0913
;;   Called from:
;;     0800:1CF1 (in fn0800_1C12)
fn135D_0913 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	inc	ax
	and	ax,7Fh
	mov	[bp+6h],ax
	mov	ax,[bp+8h]
	and	ax,70h
	mov	cl,4h
	shl	ax,cl
	mov	cx,[bp+8h]
	and	cx,0Eh
	shl	cx,1h
	shl	cx,1h
	add	ax,cx
	mov	[bp+8h],ax
	mov	ax,[bp+6h]
	sar	ax,1h
	and	ax,7h
	mov	[bp-2h],ax
	mov	ax,[bp+6h]
	and	ax,70h
	shl	ax,1h
	shl	ax,1h
	add	ax,[bp-2h]
	add	[bp+8h],ax
	mov	bx,[bp+8h]
	mov	es,[550Ch]
	mov	al,es:[bx+101Dh]
	inc	al
	xor	al,1h
	dec	al
	mov	es:[bx+101Dh],al
	mov	ax,0Fh
	push	ax
	call	far 0800h:19BFh
	mov	sp,bp
	pop	bp
	retf

;; fn135D_0980: 135D:0980
;;   Called from:
;;     0800:1D07 (in fn0800_1C12)
fn135D_0980 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ah
	call	far 207Fh:2FDCh
	mov	word ptr [bp-2h],1h
	mov	word ptr [bp-6h],0h

l135D_0995:
	mov	bx,[bp-6h]
	shl	bx,1h
	mov	bx,[bx+241Eh]
	mov	es,[550Ch]
	test	byte ptr es:[bx+101Dh],1h
	jz	09AFh

l135D_09AA:
	mov	word ptr [bp-2h],0h

l135D_09AF:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],7h
	jl	0995h

l135D_09B8:
	cmp	word ptr [bp-2h],0h
	jz	0A24h

l135D_09BE:
	mov	word ptr [bp-6h],0h

l135D_09C3:
	mov	bx,[bp-6h]
	mov	es,[550Ch]
	mov	al,es:[bx+101Dh]
	sub	ah,ah
	mov	[bp-4h],ax
	cmp	ax,97h
	jl	0A1Ah

l135D_09D9:
	cmp	ax,0F0h
	jg	0A1Ah

l135D_09DE:
	test	byte ptr [bp-4h],1h
	jnz	0A1Ah

l135D_09E4:
	mov	word ptr [bp-8h],0h
	mov	word ptr [bp-0Ah],0h

l135D_09EE:
	mov	bx,[bp-0Ah]
	shl	bx,1h
	mov	ax,[bp-6h]
	cmp	[bx+241Eh],ax
	jnz	0A06h

l135D_09FC:
	mov	word ptr [bp-8h],1h
	mov	word ptr [bp-0Ah],8h

l135D_0A06:
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],7h
	jl	09EEh

l135D_0A0F:
	cmp	word ptr [bp-8h],0h
	jnz	0A1Ah

l135D_0A15:
	mov	word ptr [bp-2h],0h

l135D_0A1A:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],300h
	jl	09C3h

l135D_0A24:
	call	far 1CD3h:17C6h
	cmp	word ptr [bp-2h],0h
	jz	0A54h

l135D_0A2F:
	mov	ax,10h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h
	mov	ax,23B2h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	mov	es,[54FAh]
	mov	byte ptr es:[0D34Ah],1h
	jmp	0AA2h

l135D_0A54:
	mov	ax,11h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h
	mov	ax,2409h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	mov	word ptr [bp-6h],0h

l135D_0A72:
	mov	bx,[bp-6h]
	mov	es,[550Ch]
	mov	al,es:[bx+101Dh]
	sub	ah,ah
	mov	[bp-4h],ax
	cmp	ax,97h
	jl	0A98h

l135D_0A88:
	cmp	ax,0F0h
	jg	0A98h

l135D_0A8D:
	test	byte ptr [bp-4h],1h
	jnz	0A98h

l135D_0A93:
	dec	byte ptr es:[bx+101Dh]

l135D_0A98:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],300h
	jl	0A72h

l135D_0AA2:
	call	far 1F3Dh:0259h
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h
	mov	sp,bp
	pop	bp
	retf

;; fn135D_0AB6: 135D:0AB6
;;   Called from:
;;     0800:1ED3 (in fn0800_1C12)
;;     0800:1EEE (in fn0800_1C12)
;;     0800:1F0B (in fn0800_1C12)
;;     135D:0189 (in fn135D_0004)
;;     135D:01D5 (in fn135D_0004)
fn135D_0AB6 proc
	push	bp
	mov	bp,sp
	mov	ax,16h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,[bp+6h]
	inc	ax
	and	ax,7Fh
	mov	[bp+6h],ax
	and	word ptr [bp+8h],7Eh
	cmp	word ptr [bp+0Ah],0h
	jl	0AD9h

l135D_0AD6:
	jmp	0BCDh

l135D_0AD9:
	mov	word ptr [bp-6h],0h
	mov	word ptr [bp-8h],0h
	jmp	0AE8h

l135D_0AE5:
	inc	word ptr [bp-8h]

l135D_0AE8:
	cmp	word ptr [bp-8h],0Ch
	jl	0AF1h

l135D_0AEE:
	jmp	0BEAh

l135D_0AF1:
	mov	bx,[bp-8h]
	mov	al,[bx+2486h]
	cbw
	cmp	ax,[bp+8h]
	jnz	0AE5h

l135D_0AFE:
	mov	al,[bp+6h]
	and	al,7Eh
	cmp	[bx+247Ah],al
	jnz	0AE5h

l135D_0B09:
	mov	al,[bx+2492h]
	cbw
	dec	ax
	mov	[bp-12h],ax
	mov	al,[bx+249Eh]
	cbw
	dec	ax
	mov	[bp-0Ch],ax
	mov	al,[bx+24AAh]
	cbw
	dec	ax
	mov	[bp-14h],ax
	mov	word ptr [bp-6h],1h
	mov	ax,bx
	mov	[bp-0Eh],ax
	mov	word ptr [bp-8h],0Ch
	cmp	ax,0Bh
	jz	0AE5h

l135D_0B38:
	mov	es,[54FAh]
	mov	al,es:[0D347h]
	cbw
	cmp	ax,[bp-12h]
	jnz	0B5Ah

l135D_0B46:
	mov	al,es:[0D348h]
	cbw
	cmp	ax,[bp-0Ch]
	jnz	0B5Ah

l135D_0B50:
	mov	al,es:[0D349h]
	cbw
	cmp	ax,[bp-14h]
	jz	0AE5h

l135D_0B5A:
	call	far 1CD3h:17C6h
	mov	es,[54FAh]
	mov	al,es:[0D347h]
	cbw
	cmp	ax,[bp-12h]
	jz	0B7Ah

l135D_0B6D:
	mov	ax,242Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l135D_0B7A:
	mov	es,[54FAh]
	mov	al,es:[0D348h]
	cbw
	cmp	ax,[bp-0Ch]
	jz	0B95h

l135D_0B88:
	mov	ax,2441h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l135D_0B95:
	mov	es,[54FAh]
	mov	al,es:[0D349h]
	cbw
	cmp	ax,[bp-14h]
	jz	0BB0h

l135D_0BA3:
	mov	ax,2457h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l135D_0BB0:
	mov	word ptr [bp-6h],0h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	mov	es,[550Eh]
	mov	word ptr es:[0D55Ch],1h
	jmp	0AE5h

l135D_0BCD:
	mov	word ptr [bp-6h],1h
	mov	ax,[bp+0Ah]
	mov	[bp-0Eh],ax
	mov	bx,ax
	mov	al,[bx+247Ah]
	cbw
	mov	[bp+6h],ax
	mov	al,[bx+2486h]
	cbw
	mov	[bp+8h],ax

l135D_0BEA:
	cmp	word ptr [bp-6h],0h
	jnz	0BF3h

l135D_0BF0:
	jmp	0D44h

l135D_0BF3:
	cmp	word ptr [bp+0Ah],0h
	jl	0C17h

l135D_0BF9:
	mov	bx,[bp-0Eh]
	mov	al,[bx+2492h]
	cbw
	dec	ax
	mov	[bp-12h],ax
	mov	al,[bx+249Eh]
	cbw
	dec	ax
	mov	[bp-0Ch],ax
	mov	al,[bx+24AAh]
	cbw
	dec	ax
	mov	[bp-14h],ax

l135D_0C17:
	cmp	word ptr [bp-0Eh],0Bh
	jz	0C3Eh

l135D_0C1D:
	mov	bx,[bp-12h]
	mov	es,[5516h]
	mov	byte ptr es:[bx+45DEh],1h
	mov	bx,[bp-0Ch]
	mov	byte ptr es:[bx+45DEh],1h
	mov	bx,[bp-14h]
	mov	byte ptr es:[bx+45DEh],1h
	jmp	0C54h

l135D_0C3E:
	mov	es,[54FAh]
	mov	byte ptr es:[0D347h],0FFh
	mov	byte ptr es:[0D348h],0FFh
	mov	byte ptr es:[0D349h],0FFh

l135D_0C54:
	mov	bx,[bp-0Eh]
	mov	es,[54FAh]
	mov	byte ptr es:[bx+0D34Fh],1h
	cmp	word ptr [bp+0Ah],0FFh
	jnz	0C73h

l135D_0C67:
	mov	ax,0Ah
	push	ax
	call	far 0800h:19BFh
	add	sp,2h

l135D_0C73:
	mov	ax,[bp+8h]
	and	ax,70h
	mov	cl,5h
	shl	ax,cl
	mov	cx,[bp+8h]
	and	cx,0Eh
	shl	cx,1h
	shl	cx,1h
	add	ax,cx
	mov	[bp+8h],ax
	mov	ax,[bp+6h]
	sar	ax,1h
	and	ax,7h
	mov	[bp-2h],ax
	mov	ax,[bp+6h]
	and	ax,70h
	shl	ax,1h
	shl	ax,1h
	add	ax,[bp-2h]
	add	[bp+8h],ax
	mov	word ptr [bp-4h],0h

l135D_0CAC:
	mov	ax,[bp-2h]
	mov	[bp+6h],ax
	mov	word ptr [bp-0Ah],0h
	cmp	word ptr [bp+0Ah],0FFh
	jz	0CC2h

l135D_0CBD:
	mov	word ptr [bp-4h],2h

l135D_0CC2:
	mov	word ptr [bp-10h],0h

l135D_0CC7:
	mov	si,[bp-4h]
	shl	si,1h
	shl	si,1h
	mov	bx,[bp-10h]
	mov	al,[bx+si+246Eh]
	mov	bx,[bp+8h]
	add	bx,[bp-0Ah]
	mov	es,[550Ch]
	mov	es:[bx+101Dh],al
	inc	word ptr [bp+6h]
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp+6h],8h
	jnz	0CF4h

l135D_0CF0:
	add	word ptr [bp-0Ah],38h

l135D_0CF4:
	inc	word ptr [bp-10h]
	cmp	word ptr [bp-10h],4h
	jl	0CC7h

l135D_0CFD:
	mov	es,[5500h]
	push	word ptr es:[0A44Dh]
	mov	es,[54FEh]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:051Bh
	call	far 1F3Dh:06C3h
	cmp	word ptr [bp+0Ah],0FFh
	jnz	0D38h

l135D_0D2C:
	mov	ax,14h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h

l135D_0D38:
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],3h
	jge	0D44h
