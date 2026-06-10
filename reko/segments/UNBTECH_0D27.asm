;;; Segment 0D27 (0D27:0000)
0D27:0000 00 74 03                                        .t.             

l0800_5273:
	jmp	5126h

l0800_5276:
	mov	sp,bp
	pop	bp
	retf

;; fn0D27_000A: 0D27:000A
;;   Called from:
;;     0D27:0054 (in main)
;;     0D27:0060 (in main)
;;     0D27:0083 (in main)
;;     0D27:00D2 (in main)
;;     0D27:00DE (in main)
;;     0D27:00FB (in main)
fn0D27_000A proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0h
	jmp	0033h

l0D27_001D:
	mov	bx,[bp-2h]
	inc	word ptr [bp-2h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	push	ax
	call	far 207Fh:0213h
	add	sp,2h

l0D27_0033:
	mov	bx,[bp-2h]
	les	si,[bp+6h]
	cmp	byte ptr es:[bx+si],0h
	jnz	001Dh

l0D27_003F:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; main: 0D27:0044
main proc
	push	bp
	mov	bp,sp
	mov	ax,1Ah
	call	far 207Fh:2FDCh
	mov	ax,0CD6h
	push	ds
	push	ax
	push	cs
	call	000Ah
	add	sp,4h
	mov	ax,0D2Ah
	push	ds
	push	ax
	push	cs
	call	000Ah
	add	sp,4h

l0D27_0067:
	call	far 1F3Dh:0259h
	mov	es,[5408h]
	mov	es:[4FBAh],ax
	cmp	ax,31h
	jl	0067h

l0D27_0079:
	cmp	ax,34h
	jg	0067h

l0D27_007E:
	mov	ax,0D92h
	push	ds
	push	ax
	push	cs
	call	000Ah
	add	sp,4h
	mov	es,[540Ah]
	sub	ax,ax
	mov	[bp-12h],ax
	mov	es:[0D580h],ax
	jmp	010Ch

l0D27_0099:
	call	far 1F3Dh:0259h
	mov	[bp-10h],ax
	cmp	ax,31h
	jl	010Ch

l0D27_00A6:
	cmp	ax,33h
	jg	010Ch

l0D27_00AB:
	mov	es,[540Ch]
	sub	ax,31h
	mov	es:[3FFEh],ax
	cmp	ax,2h
	jnz	00EAh

l0D27_00BB:
	mov	word ptr es:[3FFEh],0h
	mov	es,[540Ah]
	mov	word ptr es:[0D580h],1h
	mov	ax,0E2Ch
	push	ds
	push	ax
	push	cs
	call	000Ah
	add	sp,4h
	mov	ax,0E78h
	push	ds
	push	ax
	push	cs
	call	000Ah
	add	sp,4h
	call	far 1F3Dh:0259h

l0D27_00EA:
	mov	es,[540Ch]
	cmp	word ptr es:[3FFEh],0h
	jz	0107h

l0D27_00F6:
	mov	ax,0DD0h
	push	ds
	push	ax
	push	cs
	call	000Ah
	add	sp,4h
	call	far 1F3Dh:0259h

l0D27_0107:
	mov	word ptr [bp-12h],1h

l0D27_010C:
	cmp	word ptr [bp-12h],0h
	jz	0099h

l0D27_0112:
	mov	es,[5408h]
	sub	word ptr es:[4FBAh],31h
	call	far 0DABh:0C8Fh
	mov	ax,2h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],0h
	jnz	0144h

l0D27_0139:
	sub	ax,ax
	push	ax
	call	far 207Fh:0BA7h
	add	sp,2h

l0D27_0144:
	mov	ax,230h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,0CA2h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],2h
	jnz	01A1h

l0D27_018D:
	mov	ax,0A800h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l0D27_01A1:
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],3h
	jz	01B5h

l0D27_01AD:
	mov	ax,0h
	mov	dx,2FE8h
	jmp	01BBh

l0D27_01B5:
	mov	ax,10h
	mov	dx,2FE8h

l0D27_01BB:
	push	dx
	push	ax
	call	far 1F3Dh:0525h
	add	sp,4h
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
	call	far 0800h:2A2Bh
	mov	word ptr [bp-2h],2BCh
	jmp	0207h

l0D27_01ED:
	mov	ax,1h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	call	far 1F3Dh:002Fh
	or	ax,ax
	jz	0207h

l0D27_0202:
	mov	word ptr [bp-2h],0h

l0D27_0207:
	mov	ax,[bp-2h]
	dec	word ptr [bp-2h]
	or	ax,ax
	jnz	01EDh

l0D27_0211:
	call	far 0800h:2A2Bh
	call	far 0800h:46A7h
	mov	ax,130h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,0CAEh
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],2h
	jnz	0278h

l0D27_0264:
	mov	ax,0A800h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l0D27_0278:
	mov	ax,8h
	push	ax
	sub	ax,ax
	push	ax
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1E56h:0AE5h
	add	sp,0Ah
	mov	es,[540Eh]
	mov	es:[4066h],ax
	mov	es:[4068h],dx
	mov	ax,190h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,0CBBh
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],2h
	jnz	02FAh

l0D27_02E6:
	mov	ax,0A800h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l0D27_02FA:
	mov	ax,42h
	push	ax
	sub	ax,ax
	push	ax
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1E56h:0AE5h
	add	sp,0Ah
	mov	es,[5410h]
	mov	es:[4588h],ax
	mov	es:[458Ah],dx
	mov	ax,170h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,0CC8h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	word ptr [bp-0Ah],0h
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],0h
	jnz	036Dh

l0D27_0355:
	mov	word ptr [bp-0Ah],1h
	mov	word ptr es:[4FBAh],1h
	mov	ax,1h
	push	ax
	call	far 207Fh:2CE1h
	add	sp,2h

l0D27_036D:
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:049Dh
	add	sp,8h
	cmp	word ptr [bp-0Ah],0h
	jz	03E9h

l0D27_038B:
	mov	ax,3E80h
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0A76h
	add	sp,0Ah
	mov	es,[5408h]
	mov	word ptr es:[4FBAh],0h
	sub	ax,ax
	push	ax
	call	far 207Fh:2CE1h
	add	sp,2h
	mov	ax,3E80h
	push	ax
	mov	ax,50h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	dx
	push	ax
	call	far 207Fh:0163h
	add	sp,0Ch
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	push	dx
	push	ax
	call	far 207Fh:0A26h
	add	sp,8h

l0D27_03E9:
	mov	es,[5408h]
	cmp	word ptr es:[4FBAh],2h
	jnz	040Bh

l0D27_03F5:
	mov	ax,3E80h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	dx
	push	ax
	call	far 207Fh:0572h
	add	sp,0Ah

l0D27_040B:
	mov	word ptr [bp-0Eh],0h

l0D27_0410:
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,3h
	imul	word ptr [bp-0Eh]
	push	ax
	push	word ptr [bp-0Eh]
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0Ch
	jl	0410h

l0D27_0436:
	mov	word ptr [bp-0Eh],0Ch

l0D27_043B:
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,18h
	push	ax
	mov	ax,3h
	imul	word ptr [bp-0Eh]
	sub	ax,24h
	push	ax
	push	word ptr [bp-0Eh]
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],10h
	jl	043Bh

l0D27_0465:
	mov	word ptr [bp-0Eh],10h

l0D27_046A:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,18h
	push	ax
	mov	ax,[bp-0Eh]
	sub	ax,4h
	push	ax
	push	word ptr [bp-0Eh]
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],24h
	jl	046Ah

l0D27_0491:
	mov	word ptr [bp-16h],9h
	jmp	04CEh

l0D27_0498:
	inc	word ptr [bp-0Eh]

l0D27_049B:
	cmp	word ptr [bp-0Eh],18h
	jge	04CBh

l0D27_04A1:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,[bp-16h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	push	word ptr [bp-0Eh]
	mov	ax,0Ch
	imul	word ptr [bp-16h]
	add	ax,[bp-0Eh]
	sub	ax,54h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	jmp	0498h

l0D27_04CB:
	inc	word ptr [bp-16h]

l0D27_04CE:
	cmp	word ptr [bp-16h],10h
	jge	04DBh

l0D27_04D4:
	mov	word ptr [bp-0Eh],0Ch
	jmp	049Bh

l0D27_04DB:
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,60h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,78h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,60h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,79h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,78h
	push	ax
	mov	ax,9h
	push	ax
	mov	ax,7Ah
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,78h
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,7Bh
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,0Eh
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,0A0h
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,7Ch
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,0Eh
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,0A0h
	push	ax
	mov	ax,0Ah
	push	ax
	mov	ax,7Dh
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,0A0h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,7Eh
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,0A0h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,7Fh
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,10h
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,90h
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,80h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,10h
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,90h
	push	ax
	mov	ax,0Ah
	push	ax
	mov	ax,81h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	word ptr [bp-16h],12h
	jmp	062Fh

l0D27_05F8:
	inc	word ptr [bp-0Eh]

l0D27_05FB:
	cmp	word ptr [bp-0Eh],8h
	jge	062Ch

l0D27_0601:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,[bp-16h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	push	word ptr [bp-0Eh]
	mov	ax,[bp-16h]
	shl	ax,1h
	shl	ax,1h
	add	ax,[bp-0Eh]
	add	ax,36h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	jmp	05F8h

l0D27_062C:
	inc	word ptr [bp-16h]

l0D27_062F:
	cmp	word ptr [bp-16h],16h
	jge	063Ch

l0D27_0635:
	mov	word ptr [bp-0Eh],4h
	jmp	05FBh

l0D27_063C:
	mov	word ptr [bp-0Eh],0h

l0D27_0641:
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,30h
	push	ax
	mov	ax,3h
	imul	word ptr [bp-0Eh]
	push	ax
	mov	ax,[bp-0Eh]
	add	ax,92h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0Ch
	jl	0641h

l0D27_066C:
	mov	word ptr [bp-0Eh],0h

l0D27_0671:
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,48h
	push	ax
	mov	ax,3h
	imul	word ptr [bp-0Eh]
	push	ax
	mov	ax,[bp-0Eh]
	add	ax,9Eh
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],4h
	jl	0671h

l0D27_069C:
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,60h
	push	ax
	mov	ax,6h
	push	ax
	mov	ax,0A2h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,60h
	push	ax
	mov	ax,9h
	push	ax
	mov	ax,0A3h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,78h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,0A4h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,18h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,78h
	push	ax
	mov	ax,3h
	push	ax
	mov	ax,0A5h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	word ptr [bp-0Eh],0A6h

l0D27_0710:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,20h
	push	ax
	mov	ax,[bp-0Eh]
	sub	ax,9Ah
	push	ax
	push	word ptr [bp-0Eh]
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0BAh
	jl	0710h

l0D27_0738:
	mov	word ptr [bp-16h],9h
	jmp	0775h

l0D27_073F:
	inc	word ptr [bp-0Eh]

l0D27_0742:
	cmp	word ptr [bp-0Eh],24h
	jge	0772h

l0D27_0748:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,[bp-16h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	push	word ptr [bp-0Eh]
	mov	ax,0Ch
	imul	word ptr [bp-16h]
	add	ax,[bp-0Eh]
	add	ax,36h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	jmp	073Fh

l0D27_0772:
	inc	word ptr [bp-16h]

l0D27_0775:
	cmp	word ptr [bp-16h],10h
	jge	0782h

l0D27_077B:
	mov	word ptr [bp-0Eh],18h
	jmp	0742h

l0D27_0782:
	mov	word ptr [bp-0Eh],10Ah

l0D27_0787:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,28h
	push	ax
	mov	ax,[bp-0Eh]
	sub	ax,0FEh
	push	ax
	mov	ax,[bp-0Eh]
	add	ax,4h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],11Eh
	jl	0787h

l0D27_07B3:
	mov	word ptr [bp-16h],10h
	jmp	07F0h

l0D27_07BA:
	inc	word ptr [bp-0Eh]

l0D27_07BD:
	cmp	word ptr [bp-0Eh],18h
	jge	07EDh

l0D27_07C3:
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	mov	ax,[bp-16h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	push	word ptr [bp-0Eh]
	mov	ax,0Ch
	imul	word ptr [bp-16h]
	add	ax,[bp-0Eh]
	add	ax,56h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	jmp	07BAh

l0D27_07ED:
	inc	word ptr [bp-16h]

l0D27_07F0:
	cmp	word ptr [bp-16h],17h
	jge	07FDh

l0D27_07F6:
	mov	word ptr [bp-0Eh],0Ch
	jmp	07BDh

l0D27_07FD:
	mov	ax,0Bh
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,90h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,176h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	mov	ax,0Bh
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,90h
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,177h
	push	ax
	call	far 1F3Dh:070Ah
	add	sp,0Ah
	call	far 0800h:50C8h
	call	far 0DABh:0D12h
	mov	sp,bp
