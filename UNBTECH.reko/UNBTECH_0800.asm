;;; Segment 0800 (0800:0000)

;; fn0800_0000: 0800:0000
;;   Called from:
;;     0800:51E3 (in fn0800_50C8)
;;     0800:5258 (in fn0800_50C8)
fn0800_0000 proc
	push	bp
	mov	bp,sp
	mov	ax,30h
	call	far 207Fh:2FDCh
	mov	es,[5384h]
	mov	ax,[bp+6h]
	mov	es:[3938h],ax
	sub	ax,ax
	mov	[bp-1Ah],ax
	mov	[0152h],ax
	push	ax
	mov	ax,0Fh
	push	ax
	push	cs
	call	48B7h
	add	sp,4h
	jmp	050Dh

l0800_002D:
	mov	word ptr [bp-12h],0h
	call	far 1F3Dh:002Fh
	or	ax,ax
	jnz	003Eh

l0800_003B:
	jmp	01F4h

l0800_003E:
	mov	word ptr [bp-12h],1h
	call	far 1F3Dh:0259h
	mov	[bp-1Ch],ax
	push	cs
	call	2A2Bh
	push	word ptr [bp-1Ch]
	call	far 1E56h:0D1Dh
	add	sp,2h
	mov	[bp-1Ch],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	word ptr [bp-20h],0h
	jmp	009Ah

l0800_0070:
	cmp	word ptr [bp-1Ch],20h
	jz	0080h

l0800_0076:
	push	word ptr [bp-1Ch]
	push	cs
	call	218Fh
	add	sp,2h

l0800_0080:
	push	cs
	call	051Bh
	mov	es,[5386h]
	cmp	word ptr es:[0D55Ch],0h
	jz	0097h

l0800_0090:
	mov	ax,[015Ah]
	inc	ax
	mov	[bp-20h],ax

l0800_0097:
	inc	word ptr [bp-20h]

l0800_009A:
	mov	ax,[015Ah]
	cmp	[bp-20h],ax
	jl	0070h

l0800_00A2:
	mov	es,[5386h]
	cmp	word ptr es:[0D55Ch],0h
	jnz	00ECh

l0800_00AE:
	mov	word ptr [bp-16h],0h

l0800_00B3:
	mov	bx,[bp-16h]
	shl	bx,1h
	mov	ax,[bp-1Ch]
	cmp	[bx+160h],ax
	jnz	00E3h

l0800_00C1:
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Fh
	mov	bx,[bp-16h]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+1ACh]
	push	word ptr [bx+1AAh]
	call	far 1E56h:03F5h
	add	sp,4h

l0800_00E3:
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],8h
	jl	00B3h

l0800_00EC:
	mov	es,[5386h]
	mov	word ptr es:[0D55Ch],0h
	push	word ptr [bp-1Ch]
	push	cs
	call	231Dh
	add	sp,2h
	cmp	word ptr [bp-1Ch],20h
	jnz	010Bh

l0800_0107:
	push	cs
	call	2C50h

l0800_010B:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D33Dh],0h
	jz	0122h

l0800_0117:
	cmp	byte ptr es:[0D346h],0h
	jnz	0122h

l0800_011F:
	jmp	01B1h

l0800_0122:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	and	ax,70h
	mov	cl,4h
	shr	ax,cl
	mov	[bp-2Ch],ax
	mov	bx,ax
	mov	al,[bx+29Ah]
	cbw
	mov	[bp-2Ch],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	and	ax,0F000h
	mov	cl,5h
	shr	ax,cl
	mov	cx,es:[0A44Dh]
	and	cx,70h
	or	ax,cx
	mov	[bp-30h],ax
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	cl,8h
	shr	ax,cl
	add	[bp-30h],ax
	mov	al,[bp-2Ch]
	mov	bx,[bp-30h]
	mov	es,[538Ah]
	or	es:[bx+0CB0Ch],al
	mov	es,[538Eh]
	cmp	word ptr es:[0A44Dh],0h
	jz	0193h

l0800_0184:
	mov	al,[bp-2Ch]
	mov	bx,[bp-30h]
	mov	es,[538Ah]
	or	es:[bx+0CAFCh],al

l0800_0193:
	mov	es,[538Eh]
	cmp	word ptr es:[0A44Dh],0F07Fh
	jnc	020Ah

l0800_01A0:
	mov	al,[bp-2Ch]
	mov	bx,[bp-30h]
	mov	es,[538Ah]
	or	es:[bx+0CB1Ch],al
	jmp	020Ah

l0800_01B1:
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	and	ax,0F000h
	mov	cl,5h
	shr	ax,cl
	mov	[bp-30h],ax
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	cl,8h
	shr	ax,cl
	add	[bp-30h],ax
	mov	word ptr [bp-2Ch],0h

l0800_01D7:
	mov	bx,[bp-30h]
	add	bx,[bp-2Ch]
	mov	es,[538Ah]
	mov	byte ptr es:[bx+0CB0Ch],0FFh
	add	word ptr [bp-2Ch],10h
	cmp	word ptr [bp-2Ch],80h
	jl	01D7h

l0800_01F2:
	jmp	020Ah

l0800_01F4:
	mov	ax,1h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	dec	word ptr [bp-1Ah]
	jns	020Ah

l0800_0205:
	mov	word ptr [bp-12h],1h

l0800_020A:
	cmp	word ptr [bp-12h],0h
	jnz	0213h

l0800_0210:
	jmp	050Dh

l0800_0213:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D335h],0h
	jz	0224h

l0800_021F:
	dec	byte ptr es:[0D335h]

l0800_0224:
	cmp	byte ptr es:[0D343h],0h
	jz	0287h

l0800_022C:
	mov	al,es:[0D344h]
	dec	byte ptr es:[0D344h]
	or	al,al
	jnz	023Eh

l0800_0239:
	dec	byte ptr es:[0D345h]

l0800_023E:
	mov	al,es:[0D344h]
	or	al,es:[0D345h]
	mov	es:[0D343h],al
	or	al,al
	jnz	0287h

l0800_024F:
	mov	es,[538Ch]
	cmp	word ptr es:[0A44Bh],800h
	jc	0287h

l0800_025C:
	cmp	word ptr es:[0A44Bh],0D00h
	jnc	0287h

l0800_0265:
	mov	es,[538Eh]
	cmp	word ptr es:[0A44Dh],6000h
	jc	0287h

l0800_0272:
	cmp	word ptr es:[0A44Dh],0B000h
	jnc	0287h

l0800_027B:
	mov	ax,1h
	push	ax
	call	far 1543h:0C72h
	add	sp,2h

l0800_0287:
	call	far 207Fh:0BC0h
	mov	es,[538Ah]
	mov	cx,ax
	mov	al,es:[0D330h]
	cbw
	test	cx,ax
	jnz	02B6h

l0800_029B:
	cmp	byte ptr es:[0D310h],0h
	jz	02B6h

l0800_02A3:
	cmp	byte ptr es:[0D346h],0h
	jnz	02B6h

l0800_02AB:
	sub	ax,ax
	push	ax
	call	far 183Bh:000Ah
	add	sp,2h

l0800_02B6:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D329h],0h
	jz	02C7h

l0800_02C2:
	dec	byte ptr es:[0D329h]

l0800_02C7:
	cmp	byte ptr es:[0D320h],0h
	jz	02D4h

l0800_02CF:
	dec	byte ptr es:[0D320h]

l0800_02D4:
	cmp	byte ptr es:[0D321h],0h
	jz	02E1h

l0800_02DC:
	dec	byte ptr es:[0D321h]

l0800_02E1:
	cmp	byte ptr es:[0D322h],0h
	jz	02EEh

l0800_02E9:
	dec	byte ptr es:[0D322h]

l0800_02EE:
	mov	al,es:[0D323h]
	dec	byte ptr es:[0D323h]
	or	al,al
	jz	02FEh

l0800_02FB:
	jmp	044Ah

l0800_02FE:
	mov	ax,es:[0D374h]
	mov	dx,es:[0D376h]
	add	ax,es:[0D378h]
	adc	dx,es:[0D37Ah]
	add	ax,es:[0D37Ch]
	adc	dx,es:[0D37Eh]
	add	ax,es:[0D370h]
	adc	dx,es:[0D372h]
	mov	[bp-2Ah],ax
	mov	[bp-28h],dx
	cmp	byte ptr es:[0D310h],0h
	jnz	0358h

l0800_0333:
	push	cs
	call	29F5h
	cmp	dx,[bp-28h]
	jl	0353h

l0800_033C:
	jg	0343h

l0800_033E:
	cmp	ax,[bp-2Ah]
	jbe	0353h

l0800_0343:
	mov	es,[538Ah]
	add	word ptr es:[0D370h],0Fh
	adc	word ptr es:[0D372h],0h

l0800_0353:
	call	far 1631h:1FDFh

l0800_0358:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D310h],0h
	jnz	037Ah

l0800_0364:
	push	cs
	call	29F5h
	cmp	dx,[bp-28h]
	jge	0370h

l0800_036D:
	jmp	044Ah

l0800_0370:
	jg	037Ah

l0800_0372:
	cmp	ax,[bp-2Ah]
	ja	037Ah

l0800_0377:
	jmp	044Ah

l0800_037A:
	mov	word ptr [bp-1Ah],0h
	jmp	03C0h

l0800_0381:
	mov	bx,[bp-1Ah]
	shl	bx,1h
	mov	ax,[bx+2A8h]
	cwd
	push	dx
	push	ax
	mov	bx,[bp-1Ah]
	shl	bx,1h
	shl	bx,1h
	lea	ax,[bx+0D374h]
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3D1Ch
	mov	ax,6Eh
	cwd
	push	dx
	push	ax
	mov	bx,[bp-1Ah]
	shl	bx,1h
	shl	bx,1h
	lea	ax,[bx+0D374h]
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3D44h

l0800_03BD:
	inc	word ptr [bp-1Ah]

l0800_03C0:
	cmp	word ptr [bp-1Ah],3h
	jl	03C9h

l0800_03C6:
	jmp	044Ah

l0800_03C9:
	call	far 207Fh:0BC0h
	mov	bx,[bp-1Ah]
	shl	bx,1h
	mov	cx,[bx+2A2h]
	and	cx,ax
	mov	[bp-18h],cx
	or	cx,cx
	jz	0381h

l0800_03E0:
	mov	ax,64h
	cwd
	push	dx
	push	ax
	mov	bx,[bp-1Ah]
	shl	bx,1h
	shl	bx,1h
	lea	ax,[bx+0D374h]
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3D1Ch
	mov	bx,[bp-1Ah]
	shl	bx,1h
	mov	ax,[bx+2A8h]
	cwd
	push	dx
	push	ax
	mov	bx,[bp-1Ah]
	shl	bx,1h
	shl	bx,1h
	lea	ax,[bx+0D374h]
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3D44h
	cmp	word ptr [bp-1Ah],2h
	jnz	03BDh

l0800_0422:
	mov	es,[538Ah]
	cmp	word ptr es:[0D37Eh],0h
	jnz	0437h

l0800_042E:
	cmp	word ptr es:[0D37Ch],4650h
	jbe	03BDh

l0800_0437:
	mov	al,2h
	push	ax
	mov	ax,0D37Ch
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3D6Ch
	jmp	03BDh

l0800_044A:
	mov	word ptr [bp-1Ah],0Ah
	push	cs
	call	240Bh
	mov	al,[57FEh]
	inc	byte ptr [57FEh]
	cmp	al,2h
	jnz	0467h

l0800_045E:
	push	cs
	call	24C2h
	mov	byte ptr [57FEh],0h

l0800_0467:
	cmp	word ptr [014Ah],0h
	jz	0496h

l0800_046E:
	mov	es,[538Eh]
	push	word ptr es:[0A44Dh]
	mov	es,[538Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	push	cs
	call	051Bh
	call	far 1F3Dh:06C3h

l0800_0496:
	cmp	word ptr [014Ah],0h
	jz	04A4h

l0800_049D:
	cmp	word ptr [01A8h],0h
	jz	050Dh

l0800_04A4:
	call	far 1CD3h:17C6h
	cmp	word ptr [014Ah],0h
	jnz	04E5h

l0800_04B0:
	mov	es,[538Ah]
	cmp	byte ptr es:[0C614h],0FFh
	jnz	04C1h

l0800_04BC:
	mov	ax,0F1h
	jmp	04C4h

l0800_04C1:
	mov	ax,0F7h

l0800_04C4:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0FBh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h
	call	far 1E56h:0388h

l0800_04E5:
	mov	ax,12Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	or	ax,ax
	jz	0507h

l0800_0501:
	push	cs
	call	4DC7h
	jmp	050Dh

l0800_0507:
	mov	word ptr [0152h],1h

l0800_050D:
	cmp	word ptr [0152h],0h
	jnz	0517h

l0800_0514:
	jmp	002Dh

l0800_0517:
	mov	sp,bp
	pop	bp
	retf

;; fn0800_051B: 0800:051B
;;   Called from:
;;     0800:0080 (in fn0800_0000)
;;     0800:048D (in fn0800_0000)
;;     0800:3F79 (in fn0800_3D40)
;;     0800:5094 (in fn0800_4DC7)
;;     0FDC:0846 (in fn0FDC_0629)
;;     0FDC:0988 (in fn0FDC_0629)
;;     0FDC:13D0 (in fn0FDC_134B)
;;     135D:0257 (in fn135D_01E9)
;;     135D:0D1C (in fn135D_0AB6)
;;     1631:0365 (in fn1631_032F)
;;     1CD3:010F (in fn1CD3_0004)
fn0800_051B proc
	push	bp
	mov	bp,sp
	mov	ax,32h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jnz	0537h

l0800_0533:
	push	cs
	call	2A93h

l0800_0537:
	mov	es,[5390h]
	sub	ax,ax
	mov	es:[006Ah],ax
	mov	[bp-12h],ax
	mov	[bp-0Eh],ax
	mov	[bp-20h],ax

l0800_054A:
	mov	bx,[bp-20h]
	shl	bx,1h
	mov	es,[5392h]
	mov	word ptr es:[bx+406Ah],0h
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],0Ch
	jl	054Ah

l0800_0563:
	mov	word ptr [bp-20h],0h
	jmp	05A1h

l0800_056A:
	push	word ptr [bp-1Eh]
	push	word ptr [bp-18h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h
	add	sp,0Ch

l0800_0585:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	059Bh

l0800_0591:
	les	bx,[bp-4h]
	mov	al,[bp-16h]
	add	es:[bx+1h],al

l0800_059B:
	inc	word ptr [bp-0Eh]

l0800_059E:
	inc	word ptr [bp-20h]

l0800_05A1:
	cmp	word ptr [bp-20h],8h
	jl	05AAh

l0800_05A7:
	jmp	074Eh

l0800_05AA:
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	si,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	059Eh

l0800_05BE:
	cmp	byte ptr es:[si+0C620h],8h
	jl	059Eh

l0800_05C6:
	mov	es,[5390h]
	inc	word ptr es:[006Ah]
	mov	si,[bp-0Eh]
	shl	si,1h
	mov	ax,[si+2AEh]
	mov	[bp-18h],ax
	mov	ax,[si+2BEh]
	mov	[bp-1Eh],ax
	mov	ax,[si+2FEh]
	mov	es,[5394h]
	add	ax,es:[09EDh]
	mov	[bp-2Ch],ax
	mov	es,[538Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	0605h

l0800_05FE:
	mov	ax,[si+30Eh]
	add	[bp-2Ch],ax

l0800_0605:
	mov	es,[538Eh]
	test	byte ptr es:[0A44Dh],1h
	jz	061Dh

l0800_0611:
	mov	bx,[bp-0Eh]
	shl	bx,1h
	mov	ax,[bx+31Eh]
	add	[bp-2Ch],ax

l0800_061D:
	mov	si,es:[0A44Dh]
	and	si,1h
	shl	si,1h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	and	ax,1h
	add	si,ax
	shl	si,1h
	mov	bx,[bp-0Eh]
	mov	cl,3h
	shl	bx,cl
	mov	ax,[bx+si+332h]
	mov	[bp-32h],ax
	mov	bx,[bp-2Ch]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-28h],ax
	mov	word ptr [bp-16h],0h
	mov	es,[538Ah]
	cmp	es:[0D346h],ah
	jnz	068Fh

l0800_0665:
	cmp	ax,0F6h
	jge	068Fh

l0800_066A:
	mov	ax,[bp-32h]
	test	[bp-28h],ax
	jz	068Fh

l0800_0672:
	mov	ax,[bp-28h]
	and	ax,0F0h
	mov	[bp-0Ah],ax
	cmp	ax,30h
	jge	068Fh

l0800_0680:
	mov	word ptr [bp-16h],2h
	cmp	ax,20h
	jnz	068Fh

l0800_068A:
	mov	word ptr [bp-16h],4h

l0800_068F:
	mov	al,[bp-16h]
	mov	bx,[bp-20h]
	mov	es,[5398h]
	mov	es:[bx+32B2h],al
	mov	bx,[bp-20h]
	mov	es,[539Ah]
	mov	bl,es:[bx+409Eh]
	sub	bh,bh
	mov	si,[bp-20h]
	mov	es,[539Ch]
	mov	al,es:[si+0D562h]
	sub	ah,ah
	add	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	mov	ax,es:[bx+39FAh]
	mov	dx,es:[bx+39FCh]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	06EAh

l0800_06E0:
	les	bx,[bp-4h]
	mov	al,[bp-16h]
	sub	es:[bx+1h],al

l0800_06EA:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	06F9h

l0800_06F6:
	jmp	056Ah

l0800_06F9:
	cmp	word ptr es:[4FBAh],0h
	jnz	0724h

l0800_0701:
	cmp	word ptr [bp-16h],0h
	jz	0724h

l0800_0707:
	mov	es,[53A2h]
	mov	ax,[bp-1Eh]
	sub	ax,[bp-16h]
	add	ax,8h
	mov	es:[0B780h],ax
	cmp	ax,0C8h
	jle	0724h

l0800_071D:
	mov	word ptr es:[0B780h],0C8h

l0800_0724:
	push	word ptr [bp-1Eh]
	push	word ptr [bp-18h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	add	sp,0Ch
	mov	es,[53A2h]
	mov	word ptr es:[0B780h],0C8h
	jmp	0585h

l0800_074E:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-8h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-0Ch],ax
	mov	word ptr [bp-20h],10h
	jmp	079Fh

l0800_076B:
	push	word ptr [bp-1Eh]
	push	word ptr [bp-18h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h
	add	sp,0Ch

l0800_0786:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	079Ch

l0800_0792:
	les	bx,[bp-4h]
	mov	al,[bp-16h]
	add	es:[bx+1h],al

l0800_079C:
	inc	word ptr [bp-20h]

l0800_079F:
	cmp	word ptr [bp-20h],18h
	jl	07A8h

l0800_07A5:
	jmp	09FEh

l0800_07A8:
	mov	ax,1Ah
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0D1F9h],0h
	jnz	079Ch

l0800_07BC:
	mov	si,[bp-20h]
	shl	si,1h
	mov	es,[53A4h]
	mov	ax,es:[si+4004h]
	mov	[bp-18h],ax
	mov	es,[53A6h]
	mov	ax,es:[si+4036h]
	mov	[bp-1Eh],ax
	sub	ax,ax
	mov	[bp-26h],ax
	mov	[bp-22h],ax
	mov	ax,[bp-18h]
	sub	ax,[bp-8h]
	add	ax,1Ah
	mov	[bp-18h],ax
	mov	ax,[bp-1Eh]
	sub	ax,[bp-0Ch]
	add	ax,0Ch
	mov	[bp-1Eh],ax
	mov	es,[53A4h]
	mov	ax,es:[si+4004h]
	sub	al,al
	mov	cx,[bp-8h]
	sub	cl,cl
	cmp	ax,cx
	jnz	081Eh

l0800_080D:
	cmp	word ptr [bp-18h],0Dh
	jl	0819h

l0800_0813:
	cmp	word ptr [bp-18h],27h
	jle	081Eh

l0800_0819:
	mov	word ptr [bp-22h],1h

l0800_081E:
	mov	bx,[bp-20h]
	shl	bx,1h
	mov	es,[53A6h]
	mov	ax,es:[bx+4036h]
	sub	al,al
	mov	cx,[bp-0Ch]
	sub	cl,cl
	cmp	ax,cx
	jnz	0848h

l0800_0837:
	cmp	word ptr [bp-1Eh],0h
	jl	0843h

l0800_083D:
	cmp	word ptr [bp-1Eh],18h
	jle	0848h

l0800_0843:
	mov	word ptr [bp-26h],1h

l0800_0848:
	cmp	word ptr [bp-18h],8Dh
	jge	0851h

l0800_084E:
	jmp	079Ch

l0800_0851:
	cmp	word ptr [bp-18h],0A7h
	jle	085Bh

l0800_0858:
	jmp	079Ch

l0800_085B:
	cmp	word ptr [bp-1Eh],0F080h
	jge	0865h

l0800_0862:
	jmp	079Ch

l0800_0865:
	cmp	word ptr [bp-1Eh],0F98h
	jle	086Fh

l0800_086C:
	jmp	079Ch

l0800_086F:
	mov	ax,[bp-22h]
	add	ax,[bp-26h]
	jz	087Ah

l0800_0877:
	jmp	079Ch

l0800_087A:
	and	word ptr [bp-18h],7Fh
	and	word ptr [bp-1Eh],7Fh
	mov	ax,[bp-18h]
	sub	ax,0Dh
	mov	[bp-2Ah],ax
	mov	ax,[bp-1Eh]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	cx,[bp-2Ah]
	sar	cx,1h
	add	ax,cx
	mov	es,[5394h]
	add	ax,es:[09EDh]
	mov	[bp-14h],ax
	test	byte ptr [bp-2Ah],1h
	jz	08BDh

l0800_08AE:
	mov	es,[538Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	08BDh

l0800_08BA:
	inc	word ptr [bp-14h]

l0800_08BD:
	test	byte ptr [bp-1Eh],1h
	jz	08D3h

l0800_08C3:
	mov	es,[538Eh]
	test	byte ptr es:[0A44Dh],1h
	jz	08D3h

l0800_08CF:
	add	word ptr [bp-14h],18h

l0800_08D3:
	mov	si,[bp-1Eh]
	mov	es,[538Eh]
	xor	si,es:[0A44Dh]
	and	si,1h
	shl	si,1h
	mov	bx,[bp-2Ah]
	mov	es,[538Ch]
	xor	bx,es:[0A44Bh]
	and	bx,1h
	mov	al,[bx+si+32Eh]
	cbw
	mov	[bp-32h],ax
	mov	bx,[bp-14h]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-1Ah],ax
	mov	word ptr [bp-16h],0h
	mov	es,[538Ah]
	cmp	es:[0D346h],ah
	jnz	0946h

l0800_091C:
	cmp	ax,0F6h
	jge	0946h

l0800_0921:
	mov	ax,[bp-32h]
	test	[bp-1Ah],ax
	jz	0946h

l0800_0929:
	mov	ax,[bp-1Ah]
	and	ax,0F0h
	mov	[bp-0Ah],ax
	cmp	ax,30h
	jge	0946h

l0800_0937:
	mov	word ptr [bp-16h],2h
	cmp	ax,20h
	jnz	0946h

l0800_0941:
	mov	word ptr [bp-16h],4h

l0800_0946:
	mov	cl,3h
	shl	word ptr [bp-18h],cl
	shl	word ptr [bp-1Eh],cl
	mov	bx,[bp-20h]
	mov	es,[539Ah]
	mov	bl,es:[bx+409Ah]
	sub	bh,bh
	mov	si,[bp-20h]
	mov	es,[539Ch]
	mov	al,es:[si+0D55Eh]
	sub	ah,ah
	add	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	mov	ax,es:[bx+39FAh]
	mov	dx,es:[bx+39FCh]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	099Ah

l0800_0990:
	les	bx,[bp-4h]
	mov	al,[bp-16h]
	sub	es:[bx+1h],al

l0800_099A:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	09A9h

l0800_09A6:
	jmp	076Bh

l0800_09A9:
	cmp	word ptr es:[4FBAh],0h
	jnz	09D4h

l0800_09B1:
	cmp	word ptr [bp-16h],0h
	jz	09D4h

l0800_09B7:
	mov	es,[53A2h]
	mov	ax,[bp-1Eh]
	sub	ax,[bp-16h]
	add	ax,8h
	mov	es:[0B780h],ax
	cmp	ax,0C8h
	jle	09D4h

l0800_09CD:
	mov	word ptr es:[0B780h],0C8h

l0800_09D4:
	push	word ptr [bp-1Eh]
	push	word ptr [bp-18h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	add	sp,0Ch
	mov	es,[53A2h]
	mov	word ptr es:[0B780h],0C8h
	jmp	0786h

l0800_09FE:
	mov	word ptr [bp-20h],0h
	jmp	0A39h

l0800_0A05:
	push	word ptr [bp-1Eh]
	push	word ptr [bp-18h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h
	add	sp,0Ch

l0800_0A20:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	0A36h

l0800_0A2C:
	les	bx,[bp-4h]
	mov	al,[bp-16h]
	add	es:[bx+1h],al

l0800_0A36:
	inc	word ptr [bp-20h]

l0800_0A39:
	cmp	word ptr [bp-20h],4h
	jl	0A42h

l0800_0A3F:
	jmp	0BC9h

l0800_0A42:
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	0A36h

l0800_0A56:
	mov	si,[bp-12h]
	shl	si,1h
	mov	ax,[si+2CEh]
	mov	[bp-18h],ax
	mov	ax,[si+2D6h]
	mov	[bp-1Eh],ax
	mov	ax,[si+2DEh]
	mov	es,[5394h]
	add	ax,es:[09EDh]
	mov	[bp-2Ch],ax
	mov	es,[538Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	0A8Ch

l0800_0A85:
	mov	ax,[si+2EEh]
	add	[bp-2Ch],ax

l0800_0A8C:
	mov	si,[bp-12h]
	shl	si,1h
	mov	ax,[si+2E6h]
	mov	[bp-32h],ax
	mov	es,[538Eh]
	test	byte ptr es:[0A44Dh],1h
	jz	0AAFh

l0800_0AA4:
	mov	ax,[si+2F6h]
	add	[bp-2Ch],ax
	xor	byte ptr [bp-32h],5h

l0800_0AAF:
	inc	word ptr [bp-12h]
	mov	bx,[bp-20h]
	mov	es,[539Ah]
	mov	bl,es:[bx+409Ah]
	sub	bh,bh
	mov	si,[bp-20h]
	mov	es,[539Ch]
	mov	al,es:[si+0D55Eh]
	sub	ah,ah
	add	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	mov	ax,es:[bx+39FAh]
	mov	dx,es:[bx+39FCh]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	mov	word ptr [bp-16h],0h
	mov	bx,[bp-2Ch]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-28h],ax
	mov	es,[538Ah]
	cmp	es:[0D346h],ah
	jnz	0B40h

l0800_0B09:
	cmp	ax,0F6h
	jge	0B40h

l0800_0B0E:
	mov	ax,[bp-32h]
	test	[bp-28h],ax
	jz	0B40h

l0800_0B16:
	mov	ax,[bp-28h]
	and	ax,0F0h
	mov	[bp-0Ah],ax
	cmp	ax,30h
	jge	0B40h

l0800_0B24:
	mov	word ptr [bp-16h],8h
	cmp	ax,20h
	jz	0B32h

l0800_0B2E:
	or	ax,ax
	jnz	0B40h

l0800_0B32:
	mov	al,[bp-28h]
	and	al,0Fh
	cmp	al,0Fh
	jnz	0B40h

l0800_0B3B:
	mov	word ptr [bp-16h],10h

l0800_0B40:
	mov	al,[bp-16h]
	mov	bx,[bp-20h]
	mov	es,[5398h]
	mov	es:[bx+32AEh],al
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	0B65h

l0800_0B5B:
	les	bx,[bp-4h]
	mov	al,[bp-16h]
	sub	es:[bx+1h],al

l0800_0B65:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	0B74h

l0800_0B71:
	jmp	0A05h

l0800_0B74:
	cmp	word ptr es:[4FBAh],0h
	jnz	0B9Fh

l0800_0B7C:
	cmp	word ptr [bp-16h],0h
	jz	0B9Fh

l0800_0B82:
	mov	es,[53A2h]
	mov	ax,[bp-1Eh]
	sub	ax,[bp-16h]
	add	ax,18h
	mov	es:[0B780h],ax
	cmp	ax,0C8h
	jle	0B9Fh

l0800_0B98:
	mov	word ptr es:[0B780h],0C8h

l0800_0B9F:
	push	word ptr [bp-1Eh]
	push	word ptr [bp-18h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	add	sp,0Ch
	mov	es,[53A2h]
	mov	word ptr es:[0B780h],0C8h
	jmp	0A20h

l0800_0BC9:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-1Ch],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-24h],ax
	sub	ax,ax
	mov	[bp-12h],ax
	mov	[bp-0Eh],ax
	mov	[bp-20h],ax

l0800_0BEA:
	mov	ax,11h
	imul	word ptr [bp-20h]
	mov	si,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	0C71h

l0800_0BFE:
	cmp	byte ptr es:[si+0C620h],8h
	jl	0C71h

l0800_0C06:
	mov	bx,[bp-0Eh]
	mov	es,[53A8h]
	mov	al,es:[bx+3A1Eh]
	cbw
	push	ax
	mov	es,[53AAh]
	mov	al,es:[bx+3A16h]
	cbw
	push	ax
	push	cs
	call	191Bh
	add	sp,4h
	mov	si,[bp-0Eh]
	shl	si,1h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	es,[53A4h]
	mov	es:[si+400Ch],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	es,[53A6h]
	mov	es:[si+403Eh],ax
	mov	es,[5392h]
	mov	word ptr es:[si+4072h],1h
	mov	es,[538Ch]
	mov	ax,[bp-1Ch]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-24h]
	mov	es:[0A44Dh],ax
	inc	word ptr [bp-0Eh]

l0800_0C71:
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],8h
	jge	0C7Dh

l0800_0C7A:
	jmp	0BEAh

l0800_0C7D:
	mov	es,[538Ch]
	mov	ax,[bp-1Ch]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-24h]
	mov	es:[0A44Dh],ax
	mov	word ptr [bp-20h],0h

l0800_0C98:
	mov	ax,7Dh
	imul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	0D24h

l0800_0CAC:
	mov	bx,[bp-12h]
	mov	es,[53ACh]
	mov	al,es:[bx+3A26h]
	cbw
	mov	[bp-18h],ax
	mov	es,[53AEh]
	mov	al,es:[bx+3A2Ah]
	cbw
	mov	[bp-1Eh],ax
	push	ax
	push	word ptr [bp-18h]
	push	cs
	call	191Bh
	add	sp,4h
	mov	si,[bp-12h]
	shl	si,1h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	es,[53A4h]
	mov	es:[si+4004h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	es,[53A6h]
	mov	es:[si+4036h],ax
	mov	bx,[bp-12h]
	inc	word ptr [bp-12h]
	shl	bx,1h
	mov	es,[5392h]
	mov	word ptr es:[bx+406Ah],1h
	mov	es,[538Ch]
	mov	ax,[bp-1Ch]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-24h]
	mov	es:[0A44Dh],ax

l0800_0D24:
	inc	word ptr [bp-20h]
	cmp	word ptr [bp-20h],4h
	jge	0D30h

l0800_0D2D:
	jmp	0C98h

l0800_0D30:
	mov	es,[53B0h]
	cmp	word ptr es:[398Eh],0h
	jnz	0D3Fh

l0800_0D3C:
	jmp	0E46h

l0800_0D3F:
	mov	word ptr [bp-20h],0h
	jmp	0D74h

l0800_0D46:
	mov	ax,[bp-1Eh]
	mov	cl,3h
	shl	ax,cl
	push	ax
	mov	ax,[bp-18h]
	shl	ax,cl
	push	ax
	mov	es,[539Eh]
	push	word ptr es:[3C44h]
	push	word ptr es:[3C42h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h

l0800_0D6E:
	add	sp,0Ch

l0800_0D71:
	inc	word ptr [bp-20h]

l0800_0D74:
	cmp	word ptr [bp-20h],4h
	jl	0D7Dh

l0800_0D7A:
	jmp	0E46h

l0800_0D7D:
	mov	ax,[bp-20h]
	shl	ax,1h
	shl	ax,1h
	add	ax,0D13h
	mov	[bp-18h],ax
	mov	word ptr [bp-1Eh],702Ch
	mov	es,[538Ch]
	sub	ax,es:[0A44Bh]
	add	ax,1Ah
	mov	[bp-18h],ax
	mov	ax,702Ch
	mov	es,[538Eh]
	sub	ax,es:[0A44Dh]
	add	ax,0Ch
	mov	[bp-1Eh],ax
	sub	ax,ax
	mov	[bp-26h],ax
	mov	[bp-22h],ax
	cmp	word ptr [bp-18h],0Dh
	jl	0DC4h

l0800_0DBE:
	cmp	word ptr [bp-18h],27h
	jle	0DC9h

l0800_0DC4:
	mov	word ptr [bp-22h],1h

l0800_0DC9:
	cmp	word ptr [bp-1Eh],0h
	jl	0DD5h

l0800_0DCF:
	cmp	word ptr [bp-1Eh],18h
	jle	0DDAh

l0800_0DD5:
	mov	word ptr [bp-26h],1h

l0800_0DDA:
	cmp	word ptr [bp-18h],8Dh
	jl	0D71h

l0800_0DE0:
	cmp	word ptr [bp-18h],0A7h
	jg	0D71h

l0800_0DE7:
	cmp	word ptr [bp-1Eh],0F080h
	jl	0D71h

l0800_0DEE:
	cmp	word ptr [bp-1Eh],0F98h
	jle	0DF8h

l0800_0DF5:
	jmp	0D71h

l0800_0DF8:
	mov	ax,[bp-22h]
	add	ax,[bp-26h]
	jz	0E03h

l0800_0E00:
	jmp	0D71h

l0800_0E03:
	and	word ptr [bp-18h],7Fh
	and	word ptr [bp-1Eh],7Fh
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	0E1Ah

l0800_0E17:
	jmp	0D46h

l0800_0E1A:
	mov	ax,[bp-1Eh]
	mov	cl,3h
	shl	ax,cl
	push	ax
	mov	ax,[bp-18h]
	shl	ax,cl
	push	ax
	mov	es,[539Eh]
	push	word ptr es:[3C44h]
	push	word ptr es:[3C42h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	jmp	0D6Eh

l0800_0E46:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_0E4B: 0800:0E4B
;;   Called from:
;;     1631:035E (in fn1631_032F)
;;     1631:1F69 (in fn1631_1F09)
;;     183B:050B (in fn183B_000A)
;;     183B:17CF (in fn183B_1774)
;;     1AE8:127C (in fn1AE8_000C)
;;     1AE8:1D0C (in fn1AE8_12C7)
fn0800_0E4B proc
	push	bp
	mov	bp,sp
	mov	ax,5Eh
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	es,[538Eh]
	or	ax,es:[0A44Dh]
	mov	cl,8h
	shr	ax,cl
	mov	[bp-3Eh],ax
	push	cs
	call	2A93h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-0Ch],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-16h],ax
	mov	word ptr [bp-4Ch],0h

l0800_0E8F:
	mov	bx,[bp-4Ch]
	mov	es,[53B2h]
	mov	byte ptr es:[bx+42F6h],0h
	inc	word ptr [bp-4Ch]
	cmp	word ptr [bp-4Ch],18h
	jl	0E8Fh

l0800_0EA5:
	mov	word ptr [bp-5Ch],0h
	jmp	1191h

l0800_0EAD:
	push	word ptr [bp-4Ah]
	push	word ptr [bp-46h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h
	add	sp,0Ch

l0800_0EC8:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	0EDEh

l0800_0ED4:
	les	bx,[bp-4h]
	mov	al,[bp-44h]
	add	es:[bx+1h],al

l0800_0EDE:
	inc	word ptr [bp-4Ch]

l0800_0EE1:
	cmp	word ptr [bp-4Ch],8h
	jl	0EEAh

l0800_0EE7:
	jmp	118Dh

l0800_0EEA:
	mov	si,[bp-4Ch]
	add	si,[bp-5Ch]
	mov	bx,si
	shl	bx,1h
	mov	es,[53A4h]
	cmp	word ptr es:[bx+400Ch],0FFh
	jz	0EDEh

l0800_0F00:
	lea	ax,[si+4h]
	mov	[bp-3Ch],ax
	mov	si,ax
	shl	si,1h
	mov	ax,es:[si+4004h]
	mov	[bp-46h],ax
	mov	es,[53A6h]
	mov	ax,es:[si+4036h]
	mov	[bp-4Ah],ax
	sub	ax,ax
	mov	[bp-50h],ax
	mov	[bp-4Eh],ax
	mov	ax,[bp-46h]
	sub	ax,[bp-0Ch]
	add	ax,1Ah
	mov	[bp-46h],ax
	mov	ax,[bp-4Ah]
	sub	ax,[bp-16h]
	add	ax,0Ch
	mov	[bp-4Ah],ax
	mov	es,[53A4h]
	mov	ax,es:[si+4004h]
	sub	al,al
	mov	cx,[bp-0Ch]
	sub	cl,cl
	cmp	ax,cx
	jnz	0F63h

l0800_0F52:
	cmp	word ptr [bp-46h],0Dh
	jl	0F5Eh

l0800_0F58:
	cmp	word ptr [bp-46h],27h
	jle	0F63h

l0800_0F5E:
	mov	word ptr [bp-4Eh],1h

l0800_0F63:
	mov	bx,[bp-3Ch]
	shl	bx,1h
	mov	es,[53A6h]
	mov	ax,es:[bx+4036h]
	sub	al,al
	mov	cx,[bp-16h]
	sub	cl,cl
	cmp	ax,cx
	jnz	0F8Dh

l0800_0F7C:
	cmp	word ptr [bp-4Ah],0h
	jl	0F88h

l0800_0F82:
	cmp	word ptr [bp-4Ah],18h
	jle	0F8Dh

l0800_0F88:
	mov	word ptr [bp-50h],1h

l0800_0F8D:
	cmp	word ptr [bp-46h],8Dh
	jge	0F96h

l0800_0F93:
	jmp	0EDEh

l0800_0F96:
	cmp	word ptr [bp-46h],0A7h
	jle	0FA0h

l0800_0F9D:
	jmp	0EDEh

l0800_0FA0:
	cmp	word ptr [bp-4Ah],0F080h
	jge	0FAAh

l0800_0FA7:
	jmp	0EDEh

l0800_0FAA:
	cmp	word ptr [bp-4Ah],0F98h
	jle	0FB4h

l0800_0FB1:
	jmp	0EDEh

l0800_0FB4:
	mov	ax,[bp-4Eh]
	add	ax,[bp-50h]
	jz	0FBFh

l0800_0FBC:
	jmp	0EDEh

l0800_0FBF:
	mov	bx,[bp-3Ch]
	mov	es,[53B2h]
	mov	byte ptr es:[bx+42F6h],1h
	and	word ptr [bp-46h],7Fh
	and	word ptr [bp-4Ah],7Fh
	mov	ax,[bp-46h]
	sub	ax,0Dh
	mov	[bp-52h],ax
	mov	ax,[bp-4Ah]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	cx,[bp-52h]
	sar	cx,1h
	add	ax,cx
	mov	es,[5394h]
	add	ax,es:[09EDh]
	mov	[bp-42h],ax
	test	byte ptr [bp-52h],1h
	jz	100Fh

l0800_1000:
	mov	es,[538Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	100Fh

l0800_100C:
	inc	word ptr [bp-42h]

l0800_100F:
	test	byte ptr [bp-4Ah],1h
	jz	1025h

l0800_1015:
	mov	es,[538Eh]
	test	byte ptr es:[0A44Dh],1h
	jz	1025h

l0800_1021:
	add	word ptr [bp-42h],18h

l0800_1025:
	mov	bx,[bp-4Ah]
	mov	es,[538Eh]
	xor	bx,es:[0A44Dh]
	and	bx,1h
	shl	bx,1h
	mov	ax,[bp-52h]
	mov	es,[538Ch]
	xor	ax,es:[0A44Bh]
	and	ax,1h
	add	bx,ax
	shl	bx,1h
	mov	ax,[bx+372h]
	mov	[bp-5Eh],ax
	mov	bx,[bp-42h]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-48h],ax
	mov	bx,[bp-3Ch]
	mov	es,[53B4h]
	mov	es:[bx+3750h],al
	mov	word ptr [bp-44h],0h
	mov	es,[538Ah]
	cmp	es:[0D346h],ah
	jnz	10A9h

l0800_107D:
	cmp	word ptr [bp-48h],0F6h
	jge	10A9h

l0800_1084:
	mov	ax,[bp-5Eh]
	test	[bp-48h],ax
	jz	10A9h

l0800_108C:
	mov	ax,[bp-48h]
	and	ax,0F0h
	mov	[bp-0Ah],ax
	cmp	ax,30h
	jge	10A9h

l0800_109A:
	mov	word ptr [bp-44h],2h
	cmp	ax,20h
	jnz	10A9h

l0800_10A4:
	mov	word ptr [bp-44h],4h

l0800_10A9:
	mov	al,[bp-44h]
	mov	bx,[bp-3Ch]
	mov	es,[5398h]
	mov	es:[bx+32AEh],al
	mov	cl,3h
	shl	word ptr [bp-46h],cl
	shl	word ptr [bp-4Ah],cl
	mov	si,[bp-3Ch]
	shl	si,1h
	mov	ax,[bp-46h]
	mov	es,[53B6h]
	mov	es:[si+324Ch],ax
	mov	ax,[bp-4Ah]
	mov	es,[53B8h]
	mov	es:[si+327Ch],ax
	mov	bx,[bp-3Ch]
	mov	es,[539Ah]
	mov	bl,es:[bx+409Ah]
	sub	bh,bh
	mov	di,[bp-3Ch]
	mov	es,[539Ch]
	mov	al,es:[di+0D55Eh]
	sub	ah,ah
	add	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	mov	ax,es:[bx+39FAh]
	mov	dx,es:[bx+39FCh]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	1129h

l0800_111F:
	les	bx,[bp-4h]
	mov	al,[bp-44h]
	sub	es:[bx+1h],al

l0800_1129:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	1138h

l0800_1135:
	jmp	0EADh

l0800_1138:
	cmp	word ptr es:[4FBAh],0h
	jnz	1163h

l0800_1140:
	cmp	word ptr [bp-44h],0h
	jz	1163h

l0800_1146:
	mov	es,[53A2h]
	mov	ax,[bp-4Ah]
	sub	ax,[bp-44h]
	add	ax,8h
	mov	es:[0B780h],ax
	cmp	ax,0C8h
	jle	1163h

l0800_115C:
	mov	word ptr es:[0B780h],0C8h

l0800_1163:
	push	word ptr [bp-4Ah]
	push	word ptr [bp-46h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	add	sp,0Ch
	mov	es,[53A2h]
	mov	word ptr es:[0B780h],0C8h
	jmp	0EC8h

l0800_118D:
	add	word ptr [bp-5Ch],0Ch

l0800_1191:
	cmp	word ptr [bp-5Ch],0Eh
	jge	119Fh

l0800_1197:
	mov	word ptr [bp-4Ch],0h
	jmp	0EE1h

l0800_119F:
	mov	word ptr [bp-6h],0FFFFh
	mov	word ptr [bp-5Ch],0h
	jmp	140Ch

l0800_11AC:
	inc	word ptr [bp-4Ch]

l0800_11AF:
	cmp	word ptr [bp-4Ch],4h
	jl	11B8h

l0800_11B5:
	jmp	1408h

l0800_11B8:
	mov	si,[bp-4Ch]
	add	si,[bp-5Ch]
	shl	si,1h
	mov	es,[53A4h]
	cmp	word ptr es:[si+4004h],0FFh
	jz	11ACh

l0800_11CC:
	mov	ax,[bp-4Ch]
	add	ax,[bp-5Ch]
	mov	[bp-3Ch],ax
	mov	ax,es:[si+4004h]
	mov	[bp-46h],ax
	mov	es,[53A6h]
	mov	ax,es:[si+4036h]
	mov	[bp-4Ah],ax
	sub	ax,ax
	mov	[bp-50h],ax
	mov	[bp-4Eh],ax
	mov	ax,[bp-46h]
	sub	ax,[bp-0Ch]
	add	ax,1Ah
	mov	[bp-46h],ax
	mov	ax,[bp-4Ah]
	sub	ax,[bp-16h]
	add	ax,0Ch
	mov	[bp-4Ah],ax
	mov	es,[53A4h]
	mov	ax,es:[si+4004h]
	sub	al,al
	mov	cx,[bp-0Ch]
	sub	cl,cl
	cmp	ax,cx
	jnz	122Eh

l0800_121D:
	cmp	word ptr [bp-46h],0Bh
	jl	1229h

l0800_1223:
	cmp	word ptr [bp-46h],27h
	jle	122Eh

l0800_1229:
	mov	word ptr [bp-4Eh],1h

l0800_122E:
	mov	bx,[bp-3Ch]
	shl	bx,1h
	mov	es,[53A6h]
	mov	ax,es:[bx+4036h]
	sub	al,al
	mov	cx,[bp-16h]
	sub	cl,cl
	cmp	ax,cx
	jnz	1258h

l0800_1247:
	cmp	word ptr [bp-4Ah],0h
	jl	1253h

l0800_124D:
	cmp	word ptr [bp-4Ah],1Ah
	jle	1258h

l0800_1253:
	mov	word ptr [bp-50h],1h

l0800_1258:
	sub	al,al
	mov	bx,[bp-3Ch]
	mov	es,[53BAh]
	mov	es:[bx+4554h],al
	mov	bx,[bp-3Ch]
	mov	es,[53BCh]
	mov	es:[bx+45CEh],al
	cmp	word ptr [bp-46h],8Bh
	jge	127Bh

l0800_1278:
	jmp	11ACh

l0800_127B:
	cmp	word ptr [bp-46h],0A7h
	jle	1285h

l0800_1282:
	jmp	11ACh

l0800_1285:
	cmp	word ptr [bp-4Ah],0F080h
	jge	128Fh

l0800_128C:
	jmp	11ACh

l0800_128F:
	cmp	word ptr [bp-4Ah],0F9Ah
	jle	1299h

l0800_1296:
	jmp	11ACh

l0800_1299:
	mov	ax,[bp-4Eh]
	add	ax,[bp-50h]
	jz	12A4h

l0800_12A1:
	jmp	11ACh

l0800_12A4:
	mov	bx,[bp-3Ch]
	mov	es,[53B2h]
	mov	byte ptr es:[bx+42F6h],1h
	and	word ptr [bp-46h],7Fh
	and	word ptr [bp-4Ah],7Fh
	mov	ax,[bp-4Ah]
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	[bp-42h],ax
	test	byte ptr [bp-4Ah],1h
	jz	12D6h

l0800_12CC:
	test	byte ptr [bp-16h],1h
	jz	12D6h

l0800_12D2:
	add	word ptr [bp-42h],18h

l0800_12D6:
	mov	word ptr [bp-5Eh],1h
	mov	al,[bp-4Ah]
	xor	al,[bp-16h]
	test	al,1h
	jz	12F7h

l0800_12E5:
	mov	word ptr [bp-5Eh],4h
	mov	bx,[bp-3Ch]
	mov	es,[53BAh]
	mov	byte ptr es:[bx+4554h],1h

l0800_12F7:
	mov	si,[bp-46h]
	shl	si,1h
	mov	ax,[si+364h]
	add	[bp-42h],ax
	test	byte ptr [bp-0Ch],1h
	jz	1310h

l0800_1309:
	mov	ax,[si+39Eh]
	add	[bp-42h],ax

l0800_1310:
	mov	es,[5394h]
	mov	si,es:[09EDh]
	add	si,[bp-42h]
	mov	es,[5396h]
	mov	al,es:[si+795h]
	mov	bx,[bp-3Ch]
	mov	es,[53BCh]
	mov	es:[bx+45CEh],al
	mov	es,[5396h]
	mov	al,es:[si+7ADh]
	sub	ah,ah
	mov	[bp-48h],ax
	mov	bx,[bp-3Ch]
	mov	es,[53B4h]
	mov	es:[bx+3750h],al
	mov	word ptr [bp-44h],0h
	mov	es,[538Ah]
	cmp	es:[0D346h],ah
	jnz	1394h

l0800_135B:
	cmp	word ptr [bp-48h],0F6h
	jge	1394h

l0800_1362:
	mov	ax,[bp-5Eh]
	test	[bp-48h],ax
	jz	1394h

l0800_136A:
	mov	ax,[bp-48h]
	and	ax,0F0h
	mov	[bp-0Ah],ax
	cmp	ax,30h
	jge	1394h

l0800_1378:
	mov	word ptr [bp-44h],8h
	cmp	ax,20h
	jz	1386h

l0800_1382:
	or	ax,ax
	jnz	1394h

l0800_1386:
	mov	al,[bp-48h]
	and	al,0Fh
	cmp	al,0Fh
	jnz	1394h

l0800_138F:
	mov	word ptr [bp-44h],10h

l0800_1394:
	mov	al,[bp-44h]
	mov	bx,[bp-3Ch]
	mov	es,[5398h]
	mov	es:[bx+32AEh],al
	mov	cl,3h
	shl	word ptr [bp-46h],cl
	shl	word ptr [bp-4Ah],cl
	mov	si,[bp-3Ch]
	shl	si,1h
	mov	ax,[bp-46h]
	mov	es,[53B6h]
	mov	es:[si+324Ch],ax
	mov	ax,[bp-4Ah]
	mov	es,[53B8h]
	mov	es:[si+327Ch],ax
	inc	word ptr [bp-6h]
	mov	di,[bp-6h]
	shl	di,1h
	mov	ax,[bp-46h]
	mov	[bp+di-26h],ax
	mov	di,[bp-6h]
	shl	di,1h
	mov	ax,[bp-4Ah]
	mov	[bp+di-3Ah],ax
	mov	di,[bp-6h]
	mov	al,[bp-44h]
	mov	[bp+di-14h],al
	mov	bx,[bp-3Ch]
	mov	es,[539Ah]
	mov	al,es:[bx+409Ah]
	mov	es,[539Ch]
	add	al,es:[bx+0D55Eh]
	mov	di,[bp-6h]
	mov	[bp+di-5Ah],al
	jmp	11ACh

l0800_1408:
	add	word ptr [bp-5Ch],0Ch

l0800_140C:
	cmp	word ptr [bp-5Ch],0Eh
	jge	141Ah

l0800_1412:
	mov	word ptr [bp-4Ch],0h
	jmp	11AFh

l0800_141A:
	cmp	word ptr [bp-6h],0FFh
	jnz	1423h

l0800_1420:
	jmp	1616h

l0800_1423:
	cmp	word ptr [bp-6h],0h
	jg	142Ch

l0800_1429:
	jmp	1508h

l0800_142C:
	mov	word ptr [bp-4Ch],0h
	jmp	14F6h

l0800_1434:
	inc	word ptr [bp-46h]

l0800_1437:
	mov	ax,[bp-6h]
	cmp	[bp-46h],ax
	jle	1442h

l0800_143F:
	jmp	14F3h

l0800_1442:
	mov	bx,[bp-4Ch]
	shl	bx,1h
	add	bx,bp
	mov	si,[bx-3Ah]
	mov	bx,[bp-46h]
	shl	bx,1h
	add	bx,bp
	mov	di,[bx-3Ah]
	cmp	di,si
	jge	1434h

l0800_145A:
	mov	bx,[bp-46h]
	shl	bx,1h
	add	bx,bp
	mov	ax,[bx-26h]
	mov	[bp-28h],ax
	mov	bx,[bp-4Ch]
	shl	bx,1h
	add	bx,bp
	mov	ax,[bx-26h]
	mov	bx,[bp-46h]
	shl	bx,1h
	add	bx,bp
	mov	[bx-26h],ax
	mov	bx,[bp-4Ch]
	shl	bx,1h
	add	bx,bp
	mov	ax,[bp-28h]
	mov	[bx-26h],ax
	mov	[bp-28h],di
	mov	bx,[bp-46h]
	shl	bx,1h
	add	bx,bp
	mov	[bx-3Ah],si
	mov	bx,[bp-4Ch]
	shl	bx,1h
	add	bx,bp
	mov	ax,[bp-28h]
	mov	[bx-3Ah],ax
	mov	bx,[bp-46h]
	add	bx,bp
	mov	al,[bx-5Ah]
	sub	ah,ah
	mov	[bp-28h],ax
	mov	bx,[bp-4Ch]
	add	bx,bp
	mov	al,[bx-5Ah]
	mov	bx,[bp-46h]
	add	bx,bp
	mov	[bx-5Ah],al
	mov	bx,[bp-4Ch]
	add	bx,bp
	mov	al,[bp-28h]
	mov	[bx-5Ah],al
	mov	bx,[bp-46h]
	add	bx,bp
	mov	al,[bx-14h]
	mov	[bp-28h],ax
	mov	bx,[bp-4Ch]
	add	bx,bp
	mov	al,[bx-14h]
	mov	bx,[bp-46h]
	add	bx,bp
	mov	[bx-14h],al
	mov	bx,[bp-4Ch]
	add	bx,bp
	mov	al,[bp-28h]
	mov	[bx-14h],al
	jmp	1434h

l0800_14F3:
	inc	word ptr [bp-4Ch]

l0800_14F6:
	mov	ax,[bp-6h]
	cmp	[bp-4Ch],ax
	jge	1508h

l0800_14FE:
	mov	ax,[bp-4Ch]
	inc	ax
	mov	[bp-46h],ax
	jmp	1437h

l0800_1508:
	mov	word ptr [bp-4Ch],0h
	jmp	154Bh

l0800_150F:
	mov	ax,[bp-4Ah]
	sub	ax,10h
	push	ax
	mov	ax,[bp-46h]
	sub	ax,8h
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h
	add	sp,0Ch

l0800_1532:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	1548h

l0800_153E:
	les	bx,[bp-4h]
	mov	al,[bp-44h]
	add	es:[bx+1h],al

l0800_1548:
	inc	word ptr [bp-4Ch]

l0800_154B:
	mov	ax,[bp-6h]
	cmp	[bp-4Ch],ax
	jle	1556h

l0800_1553:
	jmp	1616h

l0800_1556:
	mov	si,[bp-4Ch]
	mov	bl,[bp+si-5Ah]
	sub	bh,bh
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	mov	ax,es:[bx+39FAh]
	mov	dx,es:[bx+39FCh]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	shl	si,1h
	mov	ax,[bp+si-26h]
	mov	[bp-46h],ax
	mov	si,[bp-4Ch]
	shl	si,1h
	mov	ax,[bp+si-3Ah]
	mov	[bp-4Ah],ax
	mov	si,[bp-4Ch]
	mov	al,[bp+si-14h]
	sub	ah,ah
	mov	[bp-44h],ax
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jz	15AAh

l0800_15A0:
	les	bx,[bp-4h]
	mov	al,[bp-44h]
	sub	es:[bx+1h],al

l0800_15AA:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	15B9h

l0800_15B6:
	jmp	150Fh

l0800_15B9:
	cmp	word ptr es:[4FBAh],0h
	jnz	15E4h

l0800_15C1:
	cmp	word ptr [bp-44h],0h
	jz	15E4h

l0800_15C7:
	mov	es,[53A2h]
	mov	ax,[bp-4Ah]
	sub	ax,[bp-44h]
	add	ax,8h
	mov	es:[0B780h],ax
	cmp	ax,0C8h
	jle	15E4h

l0800_15DD:
	mov	word ptr es:[0B780h],0C8h

l0800_15E4:
	mov	ax,[bp-4Ah]
	sub	ax,10h
	push	ax
	mov	ax,[bp-46h]
	sub	ax,8h
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	add	sp,0Ch
	mov	es,[53A2h]
	mov	word ptr es:[0B780h],0C8h
	jmp	1532h

l0800_1616:
	mov	es,[53B0h]
	cmp	word ptr es:[398Eh],0h
	jnz	1625h

l0800_1622:
	jmp	172Ch

l0800_1625:
	mov	word ptr [bp-4Ch],0h
	jmp	165Ah

l0800_162C:
	mov	ax,[bp-4Ah]
	mov	cl,3h
	shl	ax,cl
	push	ax
	mov	ax,[bp-46h]
	shl	ax,cl
	push	ax
	mov	es,[539Eh]
	push	word ptr es:[3C44h]
	push	word ptr es:[3C42h]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h

l0800_1654:
	add	sp,0Ch

l0800_1657:
	inc	word ptr [bp-4Ch]

l0800_165A:
	cmp	word ptr [bp-4Ch],4h
	jl	1663h

l0800_1660:
	jmp	172Ch

l0800_1663:
	mov	ax,[bp-4Ch]
	shl	ax,1h
	shl	ax,1h
	add	ax,0D13h
	mov	[bp-46h],ax
	mov	word ptr [bp-4Ah],702Ch
	mov	es,[538Ch]
	sub	ax,es:[0A44Bh]
	add	ax,1Ah
	mov	[bp-46h],ax
	mov	ax,702Ch
	mov	es,[538Eh]
	sub	ax,es:[0A44Dh]
	add	ax,0Ch
	mov	[bp-4Ah],ax
	sub	ax,ax
	mov	[bp-50h],ax
	mov	[bp-4Eh],ax
	cmp	word ptr [bp-46h],0Dh
	jl	16AAh

l0800_16A4:
	cmp	word ptr [bp-46h],27h
	jle	16AFh

l0800_16AA:
	mov	word ptr [bp-4Eh],1h

l0800_16AF:
	cmp	word ptr [bp-4Ah],0h
	jl	16BBh

l0800_16B5:
	cmp	word ptr [bp-4Ah],18h
	jle	16C0h

l0800_16BB:
	mov	word ptr [bp-50h],1h

l0800_16C0:
	cmp	word ptr [bp-46h],8Dh
	jl	1657h

l0800_16C6:
	cmp	word ptr [bp-46h],0A7h
	jg	1657h

l0800_16CD:
	cmp	word ptr [bp-4Ah],0F080h
	jl	1657h

l0800_16D4:
	cmp	word ptr [bp-4Ah],0F98h
	jle	16DEh

l0800_16DB:
	jmp	1657h

l0800_16DE:
	mov	ax,[bp-4Eh]
	add	ax,[bp-50h]
	jz	16E9h

l0800_16E6:
	jmp	1657h

l0800_16E9:
	and	word ptr [bp-46h],7Fh
	and	word ptr [bp-4Ah],7Fh
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	1700h

l0800_16FD:
	jmp	162Ch

l0800_1700:
	mov	ax,[bp-4Ah]
	mov	cl,3h
	shl	ax,cl
	push	ax
	mov	ax,[bp-46h]
	shl	ax,cl
	push	ax
	mov	es,[539Eh]
	push	word ptr es:[3C44h]
	push	word ptr es:[3C42h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	jmp	1654h

l0800_172C:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0800_1732: 0800:1732
;;   Called from:
;;     0800:2388 (in fn0800_231D)
;;     0800:23D9 (in fn0800_231D)
;;     0800:276D (in fn0800_24C2)
;;     1AE8:1194 (in fn1AE8_000C)
;;     1AE8:14AC (in fn1AE8_12C7)
;;     1AE8:14C9 (in fn1AE8_12C7)
;;     1AE8:1907 (in fn1AE8_12C7)
;;     1AE8:1A7C (in fn1AE8_12C7)
;;     1CD3:0148 (in fn1CD3_0004)
;;     1CD3:0162 (in fn1CD3_0004)
;;     1CD3:10C9 (in fn1CD3_0004)
fn0800_1732 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0FFFFh
	jmp	1798h

l0800_1745:
	cmp	ax,0FFFDh
	jz	1776h

l0800_174A:
	cmp	ax,0FFFEh
	jz	1761h

l0800_174F:
	cmp	ax,0FFFFh
	jnz	1798h

l0800_1754:
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	dec	word ptr [bx+1F6h]
	jmp	1798h

l0800_1761:
	mov	si,[bp+6h]
	mov	cl,2h
	shl	si,cl
	add	si,1F6h
	les	bx,[si]
	mov	al,es:[bx]
	cbw
	sub	[si],ax
	jmp	1798h

l0800_1776:
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	si,[bx+1F6h]
	inc	word ptr [bx+1F6h]
	mov	es,[bx+1F8h]
	mov	al,es:[si]
	mov	bx,[bp+6h]
	mov	es,[53BEh]
	mov	es:[bx+396Ch],al

l0800_1798:
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	si,[bx+1F6h]
	inc	word ptr [bx+1F6h]
	mov	es,[bx+1F8h]
	mov	al,es:[si]
	cbw
	mov	[bp-2h],ax
	or	ax,ax
	jl	1745h

l0800_17B6:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_17BB: 0800:17BB
;;   Called from:
;;     1543:0979 (in fn1543_07CB)
;;     1631:03E5 (in fn1631_03AB)
;;     1631:0BA7 (in fn1631_03AB)
;;     1631:1F57 (in fn1631_1F09)
;;     183B:0733 (in fn183B_000A)
;;     183B:0835 (in fn183B_000A)
;;     183B:0859 (in fn183B_000A)
;;     183B:133F (in fn183B_000A)
;;     183B:17A8 (in fn183B_1774)
;;     183B:2949 (in fn183B_28DB)
;;     183B:2AB3 (in fn183B_2AA3)
;;     1AE8:0190 (in fn1AE8_000C)
;;     1AE8:0DA5 (in fn1AE8_000C)
;;     1AE8:1227 (in fn1AE8_000C)
;;     1AE8:12A0 (in fn1AE8_000C)
;;     1AE8:1CCF (in fn1AE8_12C7)
fn0800_17BB proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	jmp	17CCh

l0800_17C7:
	call	far 207Fh:158Ch

l0800_17CC:
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	cmp	[bp+8h],ax
	jc	17C7h

l0800_17D9:
	jmp	17E0h

l0800_17DB:
	call	far 207Fh:163Bh

l0800_17E0:
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	cmp	[bp+8h],ax
	ja	17DBh

l0800_17ED:
	jmp	17F4h

l0800_17EF:
	call	far 207Fh:16E3h

l0800_17F4:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	cmp	[bp+6h],ax
	jc	17EFh

l0800_1801:
	jmp	1808h

l0800_1803:
	call	far 207Fh:17C5h

l0800_1808:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	cmp	[bp+6h],ax
	ja	1803h

l0800_1815:
	pop	bp
	retf
0800:1817                      55 8B EC 33 C0 9A DC 2F 7F        U..3.../.
0800:1820 20 83 7E 08 00 7D 1A EB 08 9A 8C 15 7F 20 FF 46  .~..}....... .F
0800:1830 08 83 7E 08 00 75 F2 EB 08 9A 3B 16 7F 20 FF 4E ..~..u....;.. .N
0800:1840 08 83 7E 08 00 75 F2 83 7E 06 00 7D 1A EB 08 9A ..~..u..~..}....
0800:1850 E3 16 7F 20 FF 46 06 83 7E 06 00 75 F2 EB 08 9A ... .F..~..u....
0800:1860 C5 17 7F 20 FF 4E 06 83 7E 06 00 75 F2 5D CB    ... .N..~..u.]. 

;; fn0800_186F: 0800:186F
;;   Called from:
;;     183B:0245 (in fn183B_000A)
;;     183B:02CA (in fn183B_000A)
;;     1AE8:10AC (in fn1AE8_000C)
fn0800_186F proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	jmp	1893h

l0800_187B:
	mov	es,[538Eh]
	dec	word ptr es:[0A44Dh]
	mov	al,es:[0A44Dh]
	test	al,80h
	jz	1893h

l0800_188C:
	and	word ptr es:[0A44Dh],0F07Fh

l0800_1893:
	mov	es,[538Eh]
	mov	ax,[bp+8h]
	cmp	es:[0A44Dh],ax
	ja	187Bh

l0800_18A1:
	jmp	18BBh

l0800_18A3:
	mov	es,[538Eh]
	inc	word ptr es:[0A44Dh]
	mov	al,es:[0A44Dh]
	test	al,80h
	jz	18BBh

l0800_18B4:
	add	word ptr es:[0A44Dh],0F80h

l0800_18BB:
	mov	es,[538Eh]
	mov	ax,[bp+8h]
	cmp	es:[0A44Dh],ax
	jc	18A3h

l0800_18C9:
	jmp	18E3h

l0800_18CB:
	mov	es,[538Ch]
	dec	word ptr es:[0A44Bh]
	mov	al,es:[0A44Bh]
	test	al,80h
	jz	18E3h

l0800_18DC:
	and	word ptr es:[0A44Bh],0F7Fh

l0800_18E3:
	mov	es,[538Ch]
	mov	ax,[bp+6h]
	cmp	es:[0A44Bh],ax
	ja	18CBh

l0800_18F1:
	jmp	190Bh

l0800_18F3:
	mov	es,[538Ch]
	inc	word ptr es:[0A44Bh]
	mov	al,es:[0A44Bh]
	test	al,80h
	jz	190Bh

l0800_1904:
	add	word ptr es:[0A44Bh],80h

l0800_190B:
	mov	es,[538Ch]
	mov	ax,[bp+6h]
	cmp	es:[0A44Bh],ax
	jc	18F3h

l0800_1919:
	pop	bp
	retf

;; fn0800_191B: 0800:191B
;;   Called from:
;;     0800:0C1F (in fn0800_051B)
;;     0800:0CCD (in fn0800_051B)
;;     0800:25A5 (in fn0800_24C2)
;;     0800:25E0 (in fn0800_24C2)
;;     0800:2610 (in fn0800_24C2)
;;     0800:2638 (in fn0800_24C2)
;;     1631:17AB (in fn1631_16AB)
;;     1631:17C7 (in fn1631_16AB)
;;     183B:0207 (in fn183B_000A)
;;     183B:028C (in fn183B_000A)
;;     183B:20DA (in fn183B_1C1F)
;;     1AE8:10BA (in fn1AE8_000C)
fn0800_191B proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	cmp	word ptr [bp+8h],0h
	jge	196Bh

l0800_192B:
	jmp	1948h

l0800_192D:
	mov	es,[538Eh]
	dec	word ptr es:[0A44Dh]
	mov	al,es:[0A44Dh]
	test	al,80h
	jz	1945h

l0800_193E:
	and	word ptr es:[0A44Dh],0F07Fh

l0800_1945:
	inc	word ptr [bp+8h]

l0800_1948:
	cmp	word ptr [bp+8h],0h
	jnz	192Dh

l0800_194E:
	jmp	196Bh

l0800_1950:
	mov	es,[538Eh]
	inc	word ptr es:[0A44Dh]
	mov	al,es:[0A44Dh]
	test	al,80h
	jz	1968h

l0800_1961:
	add	word ptr es:[0A44Dh],0F80h

l0800_1968:
	dec	word ptr [bp+8h]

l0800_196B:
	cmp	word ptr [bp+8h],0h
	jnz	1950h

l0800_1971:
	cmp	word ptr [bp+6h],0h
	jge	19B7h

l0800_1977:
	jmp	1994h

l0800_1979:
	mov	es,[538Ch]
	dec	word ptr es:[0A44Bh]
	mov	al,es:[0A44Bh]
	test	al,80h
	jz	1991h

l0800_198A:
	and	word ptr es:[0A44Bh],0F7Fh

l0800_1991:
	inc	word ptr [bp+6h]

l0800_1994:
	cmp	word ptr [bp+6h],0h
	jnz	1979h

l0800_199A:
	jmp	19B7h

l0800_199C:
	mov	es,[538Ch]
	inc	word ptr es:[0A44Bh]
	mov	al,es:[0A44Bh]
	test	al,80h
	jz	19B4h

l0800_19AD:
	add	word ptr es:[0A44Bh],80h

l0800_19B4:
	dec	word ptr [bp+6h]

l0800_19B7:
	cmp	word ptr [bp+6h],0h
	jnz	199Ch

l0800_19BD:
	pop	bp
	retf

;; fn0800_19BF: 0800:19BF
;;   Called from:
;;     0800:4A7E (in fn0800_48B7)
;;     0FDC:05A7 (in fn0FDC_01C0)
;;     11B8:1739 (in fn11B8_16B2)
;;     135D:0977 (in fn135D_0913)
;;     135D:0A33 (in fn135D_0980)
;;     135D:0A58 (in fn135D_0980)
;;     135D:0C6B (in fn135D_0AB6)
;;     1631:1A13 (in fn1631_16AB)
;;     1AE8:152B (in fn1AE8_12C7)
;;     1AE8:154F (in fn1AE8_12C7)
;;     1AE8:1561 (in fn1AE8_12C7)
;;     1AE8:1579 (in fn1AE8_12C7)
;;     1AE8:1591 (in fn1AE8_12C7)
;;     1AE8:1678 (in fn1AE8_12C7)
;;     1AE8:19FF (in fn1AE8_12C7)
;;     1AE8:1A14 (in fn1AE8_12C7)
;;     1AE8:1C7A (in fn1AE8_12C7)
;;     1AE8:1CA3 (in fn1AE8_12C7)
fn0800_19BF proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	cmp	word ptr [015Ch],0h
	jz	19DBh

l0800_19D0:
	push	word ptr [bp+6h]
	call	far 1FC5h:0002h
	add	sp,2h

l0800_19DB:
	pop	bp
	retf

;; fn0800_19DD: 0800:19DD
;;   Called from:
;;     0DAB:0E67 (in fn0DAB_0D3D)
;;     0DAB:0E89 (in fn0DAB_0D3D)
;;     0DAB:0EDC (in fn0DAB_0D3D)
;;     0DAB:0EE4 (in fn0DAB_0D3D)
;;     0FDC:0EAF (in fn0FDC_0D49)
;;     0FDC:12F7 (in fn0FDC_0D49)
;;     11B8:0EAF (in fn11B8_0D58)
;;     11B8:0EBD (in fn11B8_0D58)
;;     11B8:0ED5 (in fn11B8_0D58)
;;     11B8:131F (in fn11B8_104E)
;;     1631:11DD (in fn1631_11AB)
;;     1AE8:07D9 (in fn1AE8_000C)
;;     1AE8:0971 (in fn1AE8_000C)
;;     1AE8:0A1A (in fn1AE8_000C)
;;     1AE8:0A42 (in fn1AE8_000C)
;;     1AE8:1E52 (in fn1AE8_1E46)
fn0800_19DD proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	push	si
	push	cs
	call	19F3h
	mov	si,ax
	push	cs
	call	19F3h
	add	ax,si
	pop	si
	retf

;; fn0800_19F3: 0800:19F3
;;   Called from:
;;     0800:19E5 (in fn0800_19DD)
;;     0800:19EB (in fn0800_19DD)
;;     1431:01B4 (in fn1431_000A)
;;     1631:12F6 (in fn1631_11AB)
;;     1631:13B5 (in fn1631_11AB)
;;     1631:13BF (in fn1631_11AB)
;;     1631:1473 (in fn1631_11AB)
;;     1631:157B (in fn1631_11AB)
;;     1AE8:07BA (in fn1AE8_000C)
fn0800_19F3 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh

l0800_19FE:
	call	far 207Fh:0BC0h
	and	ax,7h
	mov	[bp-2h],ax
	cmp	ax,5h
	jg	19FEh

l0800_1A0E:
	inc	ax
	mov	sp,bp
	pop	bp
	retf

;; fn0800_1A13: 0800:1A13
;;   Called from:
;;     0800:04F6 (in fn0800_0000)
;;     0800:1E48 (in fn0800_1C12)
;;     0800:20B4 (in fn0800_1C12)
;;     0800:37E3 (in fn0800_378D)
;;     0800:3D35 (in fn0800_3BD0)
;;     0800:51B5 (in fn0800_50C8)
;;     0800:51D1 (in fn0800_50C8)
;;     0DAB:08C6 (in fn0DAB_04F9)
;;     0DAB:0B00 (in fn0DAB_094B)
;;     0DAB:0B8C (in fn0DAB_0B5E)
;;     0FDC:02C1 (in fn0FDC_01C0)
;;     11B8:0273 (in fn11B8_0002)
;;     11B8:039D (in fn11B8_0002)
;;     11B8:04C9 (in fn11B8_0002)
;;     11B8:079B (in fn11B8_0002)
;;     11B8:0960 (in fn11B8_0925)
;;     135D:0422 (in fn135D_03AA)
;;     1467:047F (in fn1467_0002)
;;     1467:0745 (in fn1467_0002)
;;     1543:0562 (in fn1543_0004)
;;     1543:06F5 (in fn1543_0004)
;;     183B:0464 (in fn183B_000A)
;;     183B:1D87 (in fn183B_1C1F)
;;     183B:2588 (in fn183B_2556)
;;     1CD3:0FC4 (in fn1CD3_0004)
;;     1CD3:1495 (in fn1CD3_0004)
fn0800_1A13 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ah
	call	far 207Fh:2FDCh
	mov	es,[5388h]
	mov	ax,es:[37FEh]
	mov	[bp-2h],ax
	mov	word ptr [bp-0Ah],0h
	cmp	word ptr [bp+6h],0h
	jz	1A3Eh

l0800_1A34:
	mov	word ptr [bp-0Ah],1h
	mov	ax,3EEh
	jmp	1A41h

l0800_1A3E:
	mov	ax,3FEh

l0800_1A41:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[53C0h]
	mov	ax,es:[374Eh]
	mov	[bp-6h],ax
	mov	word ptr [bp-4h],0h
	push	cs
	call	2A2Bh
	jmp	1AE2h

l0800_1A62:
	call	far 1F3Dh:0259h
	mov	[bp-8h],ax
	push	ax
	call	far 1E56h:0D1Dh
	add	sp,2h
	mov	[bp-8h],ax
	cmp	ax,20h
	jz	1AB8h

l0800_1A7B:
	jg	1ABFh

l0800_1A7D:
	cmp	ax,0FFB3h
	jz	1AB1h

l0800_1A82:
	cmp	ax,0FFB5h
	jz	1A93h

l0800_1A87:
	cmp	ax,0Dh
	jz	1AB8h

l0800_1A8C:
	jmp	1A98h

l0800_1A8E:
	mov	word ptr [bp-4h],1h

l0800_1A93:
	mov	word ptr [bp-0Ah],1h

l0800_1A98:
	mov	es,[53C0h]
	dec	word ptr es:[374Eh]
	cmp	word ptr [bp-0Ah],0h
	jz	1AD5h

l0800_1AA7:
	mov	ax,3EEh
	jmp	1AD8h

l0800_1AAC:
	mov	word ptr [bp-4h],1h

l0800_1AB1:
	mov	word ptr [bp-0Ah],0h
	jmp	1A98h

l0800_1AB8:
	mov	word ptr [bp-4h],1h
	jmp	1A98h

l0800_1ABF:
	cmp	ax,4Eh
	jz	1AACh

l0800_1AC4:
	cmp	ax,59h
	jz	1A8Eh

l0800_1AC9:
	cmp	ax,6Eh
	jz	1AACh

l0800_1ACE:
	cmp	ax,79h
	jz	1A8Eh

l0800_1AD3:
	jmp	1A98h

l0800_1AD5:
	mov	ax,3FEh

l0800_1AD8:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l0800_1AE2:
	cmp	word ptr [bp-4h],0h
	jnz	1AEBh

l0800_1AE8:
	jmp	1A62h

l0800_1AEB:
	mov	es,[5388h]
	mov	ax,[bp-2h]
	mov	es:[37FEh],ax
	mov	ax,[bp-0Ah]
	mov	sp,bp
	pop	bp
	retf

;; fn0800_1AFD: 0800:1AFD
;;   Called from:
;;     0800:4A33 (in fn0800_48B7)
;;     0800:4A4B (in fn0800_48B7)
;;     11B8:171B (in fn11B8_16B2)
fn0800_1AFD proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-6h],244Bh
	mov	word ptr [bp-4h],246Ch
	push	word ptr [bp-4h]
	push	word ptr [bp-6h]
	mov	es,[53C2h]
	push	word ptr es:[0066h]
	push	word ptr es:[0064h]
	call	far 207Fh:23ECh
	add	sp,8h
	mov	[bp-8h],ax
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	1B65h

l0800_1B3D:
	mov	ax,790h
	push	ax
	mov	ax,16h
	push	ax
	mov	ax,336Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-4h]
	push	word ptr [bp-6h]
	call	far 207Fh:0163h
	add	sp,0Ch
	mov	word ptr [bp-6h],336Bh
	mov	word ptr [bp-4h],246Ch

l0800_1B65:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jge	1B94h

l0800_1B71:
	sub	ax,ax
	push	ax
	mov	ax,58h
	push	ax
	mov	ax,0Bh
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,1h
	push	ax
	push	word ptr [bp-4h]
	push	word ptr [bp-6h]
	call	far 1F3Dh:0086h
	add	sp,0Eh
	jmp	1BBEh

l0800_1B94:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	1BB9h

l0800_1BA0:
	mov	ax,790h
	push	ax
	mov	ax,336Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,244Bh
	push	dx
	push	ax
	call	far 207Fh:0572h
	add	sp,0Ah

l0800_1BB9:
	call	far 207Fh:1E37h

l0800_1BBE:
	mov	es,[53C2h]
	mov	ax,[bp-8h]
	add	es:[0064h],ax
	mov	es,[53C4h]
	mov	bx,es:[0E48Ah]
	mov	es,[53C6h]
	mov	al,es:[bx+42C3h]
	cbw
	sub	ax,41h
	mov	[bp-2h],ax
	mov	bx,ax
	mov	al,es:[bx+42E3h]
	imul	byte ptr es:[42F5h]
	mov	[bp-2h],ax
	mov	ax,3h
	imul	word ptr [bp-2h]
	sar	ax,1h
	sar	ax,1h
	mov	[bp-2h],ax
	push	ax
	call	far 1F3Dh:0006h
	mov	es,[53C4h]
	inc	word ptr es:[0E48Ah]
	mov	sp,bp
	pop	bp
	retf

;; fn0800_1C12: 0800:1C12
;;   Called from:
;;     0800:2204 (in fn0800_218F)
fn0800_1C12 proc
	push	bp
	mov	bp,sp
	mov	ax,1Ah
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-4h],0h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	and	ax,0Fh
	mov	[bp-18h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	and	ax,0Fh
	mov	[bp-1Ah],ax
	mov	word ptr [bp-16h],0h
	cmp	word ptr [bp+8h],0h
	jge	1C54h

l0800_1C4B:
	or	ax,ax
	jnz	1C54h

l0800_1C4F:
	mov	word ptr [bp-16h],8h

l0800_1C54:
	cmp	word ptr [bp+8h],0h
	jle	1C64h

l0800_1C5A:
	cmp	word ptr [bp-1Ah],0Fh
	jnz	1C64h

l0800_1C60:
	or	byte ptr [bp-16h],4h

l0800_1C64:
	cmp	word ptr [bp+6h],0h
	jge	1C74h

l0800_1C6A:
	cmp	word ptr [bp-18h],0h
	jnz	1C74h

l0800_1C70:
	or	byte ptr [bp-16h],2h

l0800_1C74:
	cmp	word ptr [bp+6h],0h
	jle	1C85h

l0800_1C7A:
	cmp	word ptr [bp-18h],0Fh
	jnz	1C85h

l0800_1C80:
	or	word ptr [bp-16h],1h

l0800_1C85:
	cmp	word ptr [bp-16h],0h
	jz	1CC1h

l0800_1C8B:
	mov	bx,[bp-16h]
	mov	al,[bx+4A0h]
	cbw
	mov	bx,ax
	mov	es,[53C8h]
	cmp	byte ptr es:[bx+7A4h],0Fh
	jnz	1CC1h

l0800_1CA1:
	mov	es,[5386h]
	mov	ax,1h
	mov	es:[0D55Ch],ax
	mov	[bp-4h],ax
	call	far 1CD3h:17C6h
	mov	ax,410h
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h

l0800_1CC1:
	cmp	word ptr [bp-4h],0h
	jz	1CCAh

l0800_1CC7:
	jmp	2186h

l0800_1CCA:
	mov	word ptr [bp-12h],0h
	jmp	1D19h

l0800_1CD1:
	cmp	word ptr [bp-10h],94h
	jnz	1CDDh

l0800_1CD8:
	call	far 135Dh:079Ch

l0800_1CDD:
	cmp	word ptr [bp-10h],97h
	jl	1CF9h

l0800_1CE4:
	cmp	word ptr [bp-10h],0F0h
	jg	1CF9h

l0800_1CEB:
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 135Dh:0913h
	add	sp,4h

l0800_1CF9:
	cmp	word ptr [bp-10h],8Ch
	jz	1D07h

l0800_1D00:
	cmp	word ptr [bp-10h],8Dh
	jnz	1D0Ch

l0800_1D07:
	call	far 135Dh:0980h

l0800_1D0C:
	mov	word ptr [bp-4h],1h
	mov	word ptr [bp-12h],8h

l0800_1D16:
	inc	word ptr [bp-12h]

l0800_1D19:
	cmp	word ptr [bp-12h],8h
	jl	1D22h

l0800_1D1F:
	jmp	1FBEh

l0800_1D22:
	mov	si,[bp-12h]
	shl	si,1h
	mov	es,[5392h]
	cmp	word ptr es:[si+4072h],0h
	jz	1D16h

l0800_1D33:
	mov	ax,[si+464h]
	add	ax,[bp+6h]
	add	ax,1Ah
	mov	[bp-8h],ax
	mov	ax,[si+47Ch]
	add	ax,[bp+8h]
	add	ax,0Ch
	mov	[bp-0Ah],ax
	mov	bx,ax
	and	bl,0FEh
	mov	ax,[bx+48Ch]
	mov	cx,[bp-8h]
	sub	cx,0Dh
	sar	cx,1h
	add	ax,cx
	mov	[bp-0Ch],ax
	test	byte ptr [bp-8h],1h
	jnz	1D78h

l0800_1D69:
	mov	es,[538Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	1D78h

l0800_1D75:
	inc	word ptr [bp-0Ch]

l0800_1D78:
	test	byte ptr [bp-0Ah],1h
	jz	1D8Eh

l0800_1D7E:
	mov	es,[538Eh]
	test	byte ptr es:[0A44Dh],1h
	jz	1D8Eh

l0800_1D8A:
	add	word ptr [bp-0Ch],18h

l0800_1D8E:
	mov	es,[5394h]
	mov	bx,es:[09EDh]
	add	bx,[bp-0Ch]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-10h],ax
	mov	es,[538Ah]
	cmp	es:[0D346h],ah
	jz	1DB6h

l0800_1DB3:
	jmp	1E6Fh

l0800_1DB6:
	mov	es,[5386h]
	cmp	word ptr es:[0D55Ch],0h
	jz	1DC5h

l0800_1DC2:
	jmp	1E6Fh

l0800_1DC5:
	mov	word ptr [bp-14h],0h

l0800_1DCA:
	mov	si,[bp-14h]
	shl	si,1h
	mov	di,[bp-12h]
	shl	di,1h
	mov	es,[53A4h]
	mov	ax,es:[di+400Ch]
	add	ax,[bp+6h]
	mov	es,[53CAh]
	cmp	ax,es:[si+4564h]
	jnz	1E63h

l0800_1DEB:
	mov	es,[53A6h]
	mov	ax,es:[di+403Eh]
	add	ax,[bp+8h]
	mov	es,[53CCh]
	cmp	ax,es:[si+4596h]
	jnz	1E63h

l0800_1E02:
	mov	es,[5386h]
	mov	word ptr es:[0D55Ch],1h
	call	far 1CD3h:17C6h
	mov	ax,430h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-14h]
	mov	cl,4h
	shl	bx,cl
	lea	ax,[bx+0A561h]
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,444h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	or	ax,ax
	jz	1E5Eh

l0800_1E53:
	push	word ptr [bp-14h]
	call	far 0FDCh:0008h
	add	sp,2h

l0800_1E5E:
	mov	word ptr [bp-14h],64h

l0800_1E63:
	inc	word ptr [bp-14h]
	cmp	word ptr [bp-14h],0Ch
	jge	1E6Fh

l0800_1E6C:
	jmp	1DCAh

l0800_1E6F:
	mov	ax,[0150h]
	cmp	[bp-10h],ax
	jge	1E7Ah

l0800_1E77:
	jmp	1D16h

l0800_1E7A:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jnz	1E89h

l0800_1E86:
	jmp	1D0Ch

l0800_1E89:
	mov	si,[bp-12h]
	shl	si,1h
	mov	ax,[si+464h]
	add	ax,[bp+6h]
	mov	es,[538Ch]
	add	ax,es:[0A44Bh]
	mov	[bp-2h],ax
	mov	ax,[si+47Ch]
	add	ax,[bp+8h]
	mov	es,[538Eh]
	add	ax,es:[0A44Dh]
	mov	[bp-6h],ax
	mov	es,[538Ah]
	cmp	byte ptr es:[0D34Eh],0h
	jz	1EC3h

l0800_1EC0:
	jmp	1CD1h

l0800_1EC3:
	cmp	word ptr [bp-10h],7Eh
	jnz	1EDBh

l0800_1EC9:
	mov	ax,0FFFFh
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 135Dh:0AB6h
	add	sp,6h

l0800_1EDB:
	cmp	word ptr [bp-10h],7Fh
	jnz	1EF6h

l0800_1EE1:
	mov	ax,0FFFFh
	push	ax
	push	word ptr [bp-6h]
	mov	ax,[bp-2h]
	dec	ax
	dec	ax
	push	ax
	call	far 135Dh:0AB6h
	add	sp,6h

l0800_1EF6:
	cmp	word ptr [bp-10h],80h
	jnz	1F13h

l0800_1EFD:
	mov	ax,0FFFFh
	push	ax
	push	word ptr [bp-6h]
	mov	ax,[bp-2h]
	sub	ax,4h
	push	ax
	call	far 135Dh:0AB6h
	add	sp,6h

l0800_1F13:
	cmp	word ptr [bp-10h],0F5h
	jnz	1F34h

l0800_1F1A:
	cmp	word ptr [bp-2h],0C01h
	jc	1F34h

l0800_1F21:
	cmp	word ptr [bp-2h],0C04h
	ja	1F34h

l0800_1F28:
	cmp	word ptr [bp-6h],0C054h
	jnz	1F34h

l0800_1F2F:
	call	far 135Dh:01E9h

l0800_1F34:
	cmp	word ptr [bp-10h],0B6h
	jz	1F42h

l0800_1F3B:
	cmp	word ptr [bp-10h],0B7h
	jnz	1F50h

l0800_1F42:
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 135Dh:03AAh
	add	sp,4h

l0800_1F50:
	cmp	word ptr [bp-10h],0F6h
	jl	1F5Ch

l0800_1F57:
	call	far 135Dh:0288h

l0800_1F5C:
	cmp	word ptr [bp-10h],83h
	jz	1F71h

l0800_1F63:
	cmp	word ptr [bp-10h],0A5h
	jl	1F76h

l0800_1F6A:
	cmp	word ptr [bp-10h],0A7h
	jg	1F76h

l0800_1F71:
	call	far 135Dh:02A8h

l0800_1F76:
	cmp	word ptr [bp-10h],4Dh
	jnz	1F8Ah

l0800_1F7C:
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 135Dh:04ABh
	add	sp,4h

l0800_1F8A:
	cmp	word ptr [bp-10h],3Ah
	jz	1F96h

l0800_1F90:
	cmp	word ptr [bp-10h],3Dh
	jnz	1FA4h

l0800_1F96:
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 135Dh:02D2h
	add	sp,4h

l0800_1FA4:
	cmp	word ptr [bp-10h],28h
	jz	1FADh

l0800_1FAA:
	jmp	1D0Ch

l0800_1FAD:
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 135Dh:055Ah
	add	sp,4h
	jmp	1D0Ch

l0800_1FBE:
	cmp	word ptr [bp-4h],0h
	jz	1FC7h

l0800_1FC4:
	jmp	2186h

l0800_1FC7:
	mov	word ptr [bp-12h],0h
	jmp	20E9h

l0800_1FCF:
	mov	al,[bp-8h]
	mov	es,[538Ch]
	xor	al,es:[0A44Bh]
	test	al,1h
	jz	1FE4h

l0800_1FDF:
	dec	word ptr [bp-0Ch]
	jmp	1FE7h

l0800_1FE4:
	inc	word ptr [bp-0Ch]

l0800_1FE7:
	mov	es,[5394h]
	mov	bx,es:[09EDh]
	add	bx,[bp-0Ch]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	cmp	ax,[0150h]
	jc	2009h

l0800_2004:
	mov	word ptr [bp-4h],1h

l0800_2009:
	mov	es,[5386h]
	cmp	word ptr es:[0D55Ch],0h
	jz	2018h

l0800_2015:
	jmp	20DBh

l0800_2018:
	mov	word ptr [bp-14h],0h

l0800_201D:
	mov	si,[bp-14h]
	shl	si,1h
	mov	di,[bp-12h]
	shl	di,1h
	mov	es,[53A6h]
	mov	ax,es:[di+4036h]
	add	ax,[bp+8h]
	mov	es,[53CCh]
	cmp	ax,es:[si+4596h]
	jz	2041h

l0800_203E:
	jmp	20CFh

l0800_2041:
	mov	es,[53A4h]
	mov	ax,es:[di+4004h]
	add	ax,[bp+6h]
	mov	[bp-0Eh],ax
	mov	es,[53CAh]
	cmp	es:[si+4564h],ax
	jz	206Eh

l0800_205B:
	dec	ax
	cmp	es:[si+4564h],ax
	jz	206Eh

l0800_2063:
	mov	ax,[bp-0Eh]
	inc	ax
	cmp	es:[si+4564h],ax
	jnz	20CFh

l0800_206E:
	mov	es,[5386h]
	mov	word ptr es:[0D55Ch],1h
	call	far 1CD3h:17C6h
	mov	ax,446h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-14h]
	mov	cl,4h
	shl	bx,cl
	lea	ax,[bx+0A561h]
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,45Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	or	ax,ax
	jz	20CAh

l0800_20BF:
	push	word ptr [bp-14h]
	call	far 0FDCh:0008h
	add	sp,2h

l0800_20CA:
	mov	word ptr [bp-14h],64h

l0800_20CF:
	inc	word ptr [bp-14h]
	cmp	word ptr [bp-14h],0Ch
	jge	20DBh

l0800_20D8:
	jmp	201Dh

l0800_20DB:
	cmp	word ptr [bp-4h],0h
	jz	20E6h

l0800_20E1:
	mov	word ptr [bp-12h],8h

l0800_20E6:
	inc	word ptr [bp-12h]

l0800_20E9:
	cmp	word ptr [bp-12h],4h
	jl	20F2h

l0800_20EF:
	jmp	2186h

l0800_20F2:
	mov	si,[bp-12h]
	shl	si,1h
	mov	es,[5392h]
	cmp	word ptr es:[si+406Ah],0h
	jz	20E6h

l0800_2103:
	mov	ax,[si+45Ch]
	add	ax,[bp+6h]
	add	ax,1Ah
	mov	[bp-8h],ax
	mov	ax,[si+474h]
	add	ax,[bp+8h]
	add	ax,0Ch
	mov	[bp-0Ah],ax
	mov	bx,ax
	and	bl,0FEh
	mov	ax,[bx+48Ch]
	mov	cx,[bp-8h]
	sub	cx,0Dh
	sar	cx,1h
	add	ax,cx
	mov	[bp-0Ch],ax
	test	byte ptr [bp-8h],1h
	jnz	2148h

l0800_2139:
	mov	es,[538Ch]
	test	byte ptr es:[0A44Bh],1h
	jz	2148h

l0800_2145:
	inc	word ptr [bp-0Ch]

l0800_2148:
	test	byte ptr [bp-0Ah],1h
	jz	215Eh

l0800_214E:
	mov	es,[538Eh]
	test	byte ptr es:[0A44Dh],1h
	jz	215Eh

l0800_215A:
	add	word ptr [bp-0Ch],18h

l0800_215E:
	mov	es,[5394h]
	mov	bx,es:[09EDh]
	add	bx,[bp-0Ch]
	mov	es,[5396h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-10h],ax
	mov	ax,[0150h]
	cmp	[bp-10h],ax
	jge	2183h

l0800_2180:
	jmp	1FCFh

l0800_2183:
	jmp	2004h

l0800_2186:
	mov	ax,[bp-4h]
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0800_218F: 0800:218F
;;   Called from:
;;     0800:0079 (in fn0800_0000)
;;     0FDC:066D (in fn0FDC_0629)
;;     0FDC:093B (in fn0FDC_0629)
fn0800_218F proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	sub	ax,ax
	mov	[bp-4h],ax
	mov	[bp-2h],ax
	cmp	word ptr [bp+6h],0B8h
	jz	21B4h

l0800_21A8:
	cmp	word ptr [bp+6h],0B7h
	jz	21B4h

l0800_21AE:
	cmp	word ptr [bp+6h],0B9h
	jnz	21B9h

l0800_21B4:
	mov	word ptr [bp-4h],0FFFFh

l0800_21B9:
	cmp	word ptr [bp+6h],0B0h
	jz	21CBh

l0800_21BF:
	cmp	word ptr [bp+6h],0AFh
	jz	21CBh

l0800_21C5:
	cmp	word ptr [bp+6h],0B1h
	jnz	21D0h

l0800_21CB:
	mov	word ptr [bp-4h],1h

l0800_21D0:
	cmp	word ptr [bp+6h],0B3h
	jz	21E2h

l0800_21D6:
	cmp	word ptr [bp+6h],0B7h
	jz	21E2h

l0800_21DC:
	cmp	word ptr [bp+6h],0AFh
	jnz	21E7h

l0800_21E2:
	mov	word ptr [bp-2h],1h

l0800_21E7:
	cmp	word ptr [bp+6h],0B5h
	jz	21F9h

l0800_21ED:
	cmp	word ptr [bp+6h],0B9h
	jz	21F9h

l0800_21F3:
	cmp	word ptr [bp+6h],0B1h
	jnz	21FEh

l0800_21F9:
	mov	word ptr [bp-2h],0FFFFh

l0800_21FE:
	push	word ptr [bp-4h]
	push	word ptr [bp-2h]
	push	cs
	call	1C12h
	add	sp,4h
	or	ax,ax
	jz	2212h

l0800_220F:
	jmp	22FAh

l0800_2212:
	cmp	word ptr [bp-4h],0FFh
	jnz	221Dh

l0800_2218:
	call	far 207Fh:158Ch

l0800_221D:
	cmp	word ptr [bp-4h],1h
	jnz	2228h

l0800_2223:
	call	far 207Fh:163Bh

l0800_2228:
	mov	word ptr [bp-6h],0h

l0800_222D:
	mov	bx,[bp-6h]
	mov	es,[53CEh]
	cmp	byte ptr es:[bx+9F3h],0FFh
	jz	227Dh

l0800_223C:
	mov	bl,es:[bx+9F6h]
	sub	bh,bh
	mov	es,[53D0h]
	mov	al,es:[bx+30h]
	mov	[bp-8h],al
	cmp	al,bh
	jz	2270h

l0800_2253:
	cbw
	push	ax
	mov	bx,[bp-6h]
	mov	es,[53CEh]
	mov	al,es:[bx+9F3h]
	sub	ah,ah
	push	ax
	push	cs
	call	2DA8h
	add	sp,4h
	call	far 207Fh:1DA8h

l0800_2270:
	mov	bx,[bp-6h]
	mov	es,[53CEh]
	mov	byte ptr es:[bx+9F3h],0FFh

l0800_227D:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],3h
	jl	222Dh

l0800_2286:
	cmp	word ptr [bp-2h],1h
	jnz	2291h

l0800_228C:
	call	far 207Fh:17C5h

l0800_2291:
	cmp	word ptr [bp-2h],0FFh
	jnz	229Ch

l0800_2297:
	call	far 207Fh:16E3h

l0800_229C:
	mov	word ptr [bp-6h],0h

l0800_22A1:
	mov	bx,[bp-6h]
	mov	es,[53CEh]
	cmp	byte ptr es:[bx+9F3h],0FFh
	jz	22F1h

l0800_22B0:
	mov	bl,es:[bx+9F6h]
	sub	bh,bh
	mov	es,[53D0h]
	mov	al,es:[bx+30h]
	mov	[bp-8h],al
	cmp	al,bh
	jz	22E4h

l0800_22C7:
	cbw
	push	ax
	mov	bx,[bp-6h]
	mov	es,[53CEh]
	mov	al,es:[bx+9F3h]
	sub	ah,ah
	push	ax
	push	cs
	call	2DA8h
	add	sp,4h
	call	far 207Fh:1DA8h

l0800_22E4:
	mov	bx,[bp-6h]
	mov	es,[53CEh]
	mov	byte ptr es:[bx+9F3h],0FFh

l0800_22F1:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],3h
	jl	22A1h

l0800_22FA:
	mov	es,[538Eh]
	push	word ptr es:[0A44Dh]
	mov	es,[538Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:1DF8h
	mov	sp,bp
	pop	bp
	retf

;; fn0800_231D: 0800:231D
;;   Called from:
;;     0800:00FA (in fn0800_0000)
;;     0FDC:0930 (in fn0FDC_0629)
fn0800_231D proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-2h],0h

l0800_232E:
	mov	bx,[bp-2h]
	shl	bx,1h
	mov	ax,[bp+6h]
	cmp	[bx+160h],ax
	jz	233Fh

l0800_233C:
	jmp	23FAh

l0800_233F:
	mov	word ptr [bp-4h],0h

l0800_2344:
	mov	ax,7Dh
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	239Bh

l0800_2358:
	mov	bx,[bp-4h]
	mov	es,[53BEh]
	mov	al,es:[bx+396Ch]
	cbw
	cmp	ax,[bp-2h]
	jz	2385h

l0800_236A:
	shl	bx,1h
	shl	bx,1h
	mov	si,[bp-2h]
	shl	si,1h
	shl	si,1h
	mov	ax,[si+25Ah]
	mov	dx,[si+25Ch]
	mov	[bx+1F6h],ax
	mov	[bx+1F8h],dx

l0800_2385:
	push	word ptr [bp-4h]
	push	cs
	call	1732h
	add	sp,2h
	mov	bx,[bp-4h]
	mov	es,[539Ah]
	mov	es:[bx+409Ah],al

l0800_239B:
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],4h
	jl	2344h

l0800_23A4:
	mov	word ptr [bp-4h],4h

l0800_23A9:
	mov	bx,[bp-4h]
	mov	es,[53BEh]
	mov	al,es:[bx+396Ch]
	cbw
	cmp	ax,[bp-2h]
	jz	23D6h

l0800_23BB:
	shl	bx,1h
	shl	bx,1h
	mov	si,[bp-2h]
	shl	si,1h
	shl	si,1h
	mov	ax,[si+27Ah]
	mov	dx,[si+27Ch]
	mov	[bx+1F6h],ax
	mov	[bx+1F8h],dx

l0800_23D6:
	push	word ptr [bp-4h]
	push	cs
	call	1732h
	add	sp,2h
	mov	bx,[bp-4h]
	mov	es,[539Ah]
	mov	es:[bx+409Ah],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],0Ch
	jl	23A9h

l0800_23F5:
	mov	word ptr [bp-2h],8h

l0800_23FA:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jge	2406h

l0800_2403:
	jmp	232Eh

l0800_2406:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_240B: 0800:240B
;;   Called from:
;;     0800:044F (in fn0800_0000)
;;     0FDC:0969 (in fn0FDC_0629)
;;     1631:1F5F (in fn1631_1F09)
;;     1AE8:1272 (in fn1AE8_000C)
;;     1AE8:1D02 (in fn1AE8_12C7)
;;     1CD3:00EB (in fn1CD3_0004)
fn0800_240B proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	mov	es,[53D2h]
	cmp	word ptr es:[3988h],0h
	jz	2425h

l0800_2422:
	jmp	24BEh

l0800_2425:
	inc	word ptr [5800h]
	cmp	word ptr [5800h],3h
	jc	2436h

l0800_2430:
	mov	word ptr [5800h],0h

l0800_2436:
	mov	ax,[5800h]
	mov	cl,7h
	shl	ax,cl
	add	ax,0D582h
	mov	[bp-4h],ax
	mov	word ptr [bp-2h],3092h
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jz	2490h

l0800_2454:
	mov	word ptr [bp-8h],0h
	jmp	245Eh

l0800_245B:
	inc	word ptr [bp-8h]

l0800_245E:
	cmp	word ptr [bp-8h],0Ah
	jge	24BEh

l0800_2464:
	mov	bx,[bp-8h]
	mov	al,[bx+4B0h]
	cbw
	mov	bx,ax
	mov	cl,7h
	shl	bx,cl
	lea	ax,[bx+4614h]
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	call	far 207Fh:28A8h
	add	sp,8h
	add	word ptr [bp-4h],180h
	jmp	245Bh

l0800_2490:
	mov	word ptr [bp-8h],0h

l0800_2495:
	mov	bx,[bp-8h]
	mov	al,[bx+4B0h]
	cbw
	mov	cl,5h
	shl	ax,cl
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	call	far 207Fh:0A9Fh
	add	sp,6h
	add	word ptr [bp-4h],180h
	inc	word ptr [bp-8h]
	cmp	word ptr [bp-8h],0Ah
	jl	2495h

l0800_24BE:
	mov	sp,bp
	pop	bp
	retf

;; fn0800_24C2: 0800:24C2
;;   Called from:
;;     0800:045E (in fn0800_0000)
;;     0FDC:0979 (in fn0FDC_0629)
fn0800_24C2 proc
	push	bp
	mov	bp,sp
	mov	ax,10h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-8h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-0Ah],ax
	mov	word ptr [bp-0Ch],0h
	jmp	2555h

l0800_24EC:
	cmp	word ptr [bp-0Ch],0h
	jnz	2504h

l0800_24F2:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D339h],0h
	jz	2504h

l0800_24FE:
	mov	byte ptr es:[0D399h],0FFh

l0800_2504:
	mov	ax,1Ah
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[538Ah]
	dec	byte ptr es:[si+0D399h]
	jnz	2552h

l0800_2517:
	mov	al,es:[si+0D398h]
	sub	ah,ah
	mov	cl,4h
	shr	ax,cl
	mov	[bp-2h],ax
	mov	si,ax
	shl	si,1h
	mov	di,[bp-0Ch]
	shl	di,1h
	mov	es,[53CAh]
	mov	ax,es:[si+4564h]
	mov	es,[53A4h]
	mov	es:[di+4024h],ax
	mov	es,[53CCh]
	mov	ax,es:[si+4596h]
	mov	es,[53A6h]
	mov	es:[di+4056h],ax

l0800_2552:
	inc	word ptr [bp-0Ch]

l0800_2555:
	cmp	word ptr [bp-0Ch],8h
	jl	255Eh

l0800_255B:
	jmp	284Bh

l0800_255E:
	mov	bx,[bp-0Ch]
	mov	es,[53B2h]
	mov	byte ptr es:[bx+42F6h],0h
	mov	ax,1Ah
	imul	word ptr [bp-0Ch]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0D399h],0h
	jz	2582h

l0800_257F:
	jmp	24ECh

l0800_2582:
	mov	es,[538Ch]
	mov	ax,[bp-8h]
	and	ax,0F70h
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-0Ah]
	and	ax,0F070h
	mov	es:[0A44Dh],ax
	sub	ax,ax
	push	ax
	mov	ax,0FFF0h
	push	ax
	push	cs
	call	191Bh
	add	sp,4h
	mov	ax,[bp-0Ch]
	add	ax,10h
	mov	[bp-2h],ax
	mov	bx,ax
	shl	bx,1h
	mov	es,[53A4h]
	mov	ax,es:[bx+4004h]
	mov	[bp-4h],ax
	mov	es,[538Ch]
	cmp	es:[0A44Bh],ax
	jnc	2552h

l0800_25D0:
	mov	ax,[bp-8h]
	or	al,0Fh
	mov	es:[0A44Bh],ax
	sub	ax,ax
	push	ax
	mov	ax,10h
	push	ax
	push	cs
	call	191Bh
	add	sp,4h
	mov	es,[538Ch]
	mov	ax,[bp-4h]
	cmp	es:[0A44Bh],ax
	ja	25F8h

l0800_25F5:
	jmp	2552h

l0800_25F8:
	mov	bx,[bp-2h]
	shl	bx,1h
	mov	es,[53A6h]
	mov	ax,es:[bx+4036h]
	mov	[bp-6h],ax
	mov	ax,0FFF0h
	push	ax
	sub	ax,ax
	push	ax
	push	cs
	call	191Bh
	add	sp,4h
	mov	es,[538Eh]
	mov	ax,[bp-6h]
	cmp	es:[0A44Dh],ax
	jc	2628h

l0800_2625:
	jmp	2552h

l0800_2628:
	mov	ax,[bp-0Ah]
	or	al,0Fh
	mov	es:[0A44Dh],ax
	mov	ax,10h
	push	ax
	sub	ax,ax
	push	ax
	push	cs
	call	191Bh
	add	sp,4h
	mov	es,[538Eh]
	mov	ax,[bp-6h]
	cmp	es:[0A44Dh],ax
	ja	2650h

l0800_264D:
	jmp	2552h

l0800_2650:
	mov	bx,[bp-0Ch]
	mov	es,[53B2h]
	mov	byte ptr es:[bx+42F6h],1h
	mov	es,[538Ch]
	mov	ax,[bp-8h]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-0Ah]
	mov	es:[0A44Dh],ax
	mov	es,[53D4h]
	mov	ax,[bp-4h]
	mov	es:[0E486h],ax
	mov	es,[53D6h]
	mov	ax,[bp-6h]
	mov	es:[0E488h],ax
	mov	ax,[bp-4h]
	mov	es,[538Ch]
	sub	ax,es:[0A44Bh]
	mov	[bp-0Eh],ax
	mov	ax,[bp-6h]
	mov	es,[538Eh]
	sub	ax,es:[0A44Dh]
	mov	[bp-10h],ax
	cmp	word ptr [bp-0Eh],80h
	jge	26B2h

l0800_26AD:
	add	word ptr [bp-0Eh],80h

l0800_26B2:
	cmp	word ptr [bp-0Eh],80h
	jle	26BEh

l0800_26B9:
	sub	word ptr [bp-0Eh],80h

l0800_26BE:
	add	word ptr [bp-0Eh],1Ah
	cmp	word ptr [bp-10h],0F080h
	jge	26CEh

l0800_26C9:
	add	word ptr [bp-10h],0F80h

l0800_26CE:
	cmp	word ptr [bp-10h],0F80h
	jle	26DAh

l0800_26D5:
	sub	word ptr [bp-10h],0F80h

l0800_26DA:
	add	word ptr [bp-10h],0Ch
	mov	ax,1Ah
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	ax,1h
	push	ax
	push	word ptr [bp-10h]
	push	word ptr [bp-0Eh]
	mov	es,[538Ah]
	push	word ptr es:[si+0D396h]
	push	word ptr es:[si+0D394h]
	push	word ptr [bp-2h]
	call	far 1631h:0006h
	add	sp,0Ch
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[53D4h]
	mov	ax,es:[0E486h]
	mov	es,[53A4h]
	mov	es:[si+4004h],ax
	mov	es,[53D6h]
	mov	ax,es:[0E488h]
	mov	es,[53A6h]
	mov	es:[si+4036h],ax
	mov	bx,[bp-2h]
	mov	es,[53BEh]
	mov	al,es:[bx+396Ch]
	mov	es,[53D8h]
	cmp	es:[bx+3920h],al
	jz	276Ah

l0800_2747:
	mov	al,es:[bx+3920h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+27Ah]
	mov	dx,[bx+27Ch]
	mov	bx,[bp-2h]
	shl	bx,1h
	shl	bx,1h
	mov	[bx+1F6h],ax
	mov	[bx+1F8h],dx

l0800_276A:
	push	word ptr [bp-2h]
	push	cs
	call	1732h
	add	sp,2h
	mov	bx,[bp-2h]
	mov	es,[539Ah]
	mov	es:[bx+409Ah],al
	mov	ax,1Ah
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	di,[bp-2h]
	shl	di,1h
	mov	es,[538Ah]
	mov	ax,es:[si+0D394h]
	mov	es,[53A4h]
	cmp	es:[di+4004h],ax
	jz	27A4h

l0800_27A1:
	jmp	2552h

l0800_27A4:
	mov	es,[538Ah]
	mov	ax,es:[si+0D396h]
	mov	es,[53A6h]
	cmp	es:[di+4036h],ax
	jz	27BBh

l0800_27B8:
	jmp	2552h

l0800_27BB:
	call	far 207Fh:0BC0h
	and	al,1Fh
	mov	es,[538Ah]
	mov	es:[si+0D399h],al
	mov	si,[bp-2h]
	shl	si,1h
	sub	ax,ax
	mov	es,[53A6h]
	mov	es:[si+4036h],ax
	mov	es,[53A4h]
	mov	es:[si+4004h],ax
	mov	ax,1Ah
	imul	word ptr [bp-0Ch]
	mov	si,ax
	mov	es,[538Ah]
	mov	al,es:[si+0D398h]
	sub	ah,ah
	and	ax,7h
	mov	[bp-2h],ax
	mov	bx,ax
	mov	es,[53DAh]
	mov	al,es:[bx+3768h]
	cbw
	mov	[bp-2h],ax
	mov	cl,4h
	mov	es,[538Ah]
	shl	es:[si+0D398h],cl
	mov	al,[bp-2h]
	or	es:[si+0D398h],al
	mov	di,[bp-2h]
	shl	di,1h
	mov	es,[53CAh]
	mov	ax,es:[di+4564h]
	mov	es,[538Ah]
	mov	es:[si+0D394h],ax
	mov	es,[53CCh]
	mov	ax,es:[di+4596h]
	mov	es,[538Ah]
	mov	es:[si+0D396h],ax
	jmp	2552h

l0800_284B:
	mov	es,[538Ch]
	mov	ax,[bp-8h]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-0Ah]
	mov	es:[0A44Dh],ax
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0800_2867: 0800:2867
;;   Called from:
;;     0800:38D3 (in fn0800_378D)
;;     0800:3900 (in fn0800_378D)
;;     0800:3935 (in fn0800_378D)
;;     0800:3977 (in fn0800_378D)
;;     0800:3A22 (in fn0800_378D)
;;     0800:3B2A (in fn0800_378D)
;;     0800:3B60 (in fn0800_378D)
;;     0800:3B8D (in fn0800_378D)
;;     0800:3BBA (in fn0800_378D)
;;     0FDC:15B9 (in fn0FDC_13DE)
;;     0FDC:1793 (in fn0FDC_15E6)
fn0800_2867 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[53DCh]
	mov	ax,[bp+0Ah]
	mov	es:[3748h],ax
	mov	es,[53C0h]
	mov	ax,[bp+0Ch]
	mov	es:[374Eh],ax
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Fh
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 1E56h:03F5h
	add	sp,4h
	pop	bp
	retf

;; fn0800_28A2: 0800:28A2
;;   Called from:
;;     0800:388E (in fn0800_378D)
;;     0800:3A8E (in fn0800_378D)
;;     0DAB:0477 (in fn0DAB_0002)
;;     0DAB:0A11 (in fn0DAB_094B)
;;     0DAB:155E (in fn0DAB_1467)
;;     0DAB:15AC (in fn0DAB_1467)
;;     0DAB:19FE (in fn0DAB_18E8)
;;     11B8:189E (in fn11B8_1762)
;;     11B8:18BB (in fn11B8_1762)
;;     1431:01A8 (in fn1431_000A)
;;     1467:00F6 (in fn1467_0002)
;;     1467:0583 (in fn1467_0002)
;;     1543:01AD (in fn1543_0004)
;;     1543:07D7 (in fn1543_07CB)
;;     1543:085B (in fn1543_07CB)
;;     1543:0B38 (in fn1543_0A35)
;;     1631:2024 (in fn1631_1FDF)
fn0800_28A2 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Ah
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	28CBh

l0800_28C0:
	mov	es,[5388h]
	mov	word ptr es:[37FEh],1h

l0800_28CB:
	retf

;; fn0800_28CC: 0800:28CC
;;   Called from:
;;     0800:2921 (in fn0800_2913)
;;     0800:2E1C (in fn0800_2DA8)
;;     0800:2EC2 (in fn0800_2DA8)
;;     0800:2EDF (in fn0800_2DA8)
;;     0800:3216 (in fn0800_320B)
;;     0800:32AB (in fn0800_320B)
;;     0800:3300 (in fn0800_32B3)
;;     0800:35C7 (in fn0800_32B3)
;;     0800:3633 (in fn0800_35D3)
;;     0800:3785 (in fn0800_35D3)
;;     0800:4104 (in fn0800_3FAE)
;;     0800:4121 (in fn0800_3FAE)
;;     0800:4647 (in fn0800_4621)
;;     0800:46D6 (in fn0800_46A7)
;;     0800:477C (in fn0800_476D)
;;     0800:4965 (in fn0800_48B7)
;;     0800:497C (in fn0800_48B7)
;;     0800:51FD (in fn0800_50C8)
;;     0D27:0125 (in main)
;;     0DAB:1B61 (in fn0DAB_1AFE)
;;     0FDC:0045 (in fn0FDC_0008)
;;     0FDC:1D3F (in fn0FDC_1D30)
;;     0FDC:1D57 (in fn0FDC_1D30)
;;     11B8:16C1 (in fn11B8_16B2)
;;     135D:0096 (in fn135D_0004)
;;     135D:063E (in fn135D_055A)
;;     135D:07E8 (in fn135D_079C)
;;     1467:08C5 (in fn1467_08A8)
;;     1CD3:1614 (in fn1CD3_0004)
fn0800_28CC proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	mov	[014Eh],ax
	mov	es,[53DEh]
	cmp	word ptr es:[0D580h],0h
	jnz	2911h

l0800_28E8:
	sub	ax,ax
	push	ax
	call	far 207Fh:014Ch
	add	sp,2h
	mov	es,[53E0h]
	cmp	word ptr es:[3FFEh],0h
	jz	2911h

l0800_28FF:
	cmp	word ptr [bp+6h],1h
	jle	2911h

l0800_2905:
	mov	ax,1h
	push	ax
	call	far 207Fh:014Ch
	add	sp,2h

l0800_2911:
	pop	bp
	retf

;; fn0800_2913: 0800:2913
;;   Called from:
;;     0800:2EE9 (in fn0800_2DA8)
;;     0800:330A (in fn0800_32B3)
;;     0800:363D (in fn0800_35D3)
;;     0800:412B (in fn0800_3FAE)
;;     0800:4786 (in fn0800_476D)
;;     1F3D:06AE (in fn1F3D_063B)
;;     1F3D:082A (in fn1F3D_0814)
fn0800_2913 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	word ptr [bp+6h]
	push	cs
	call	28CCh
	add	sp,2h
	mov	es,[53E2h]
	mov	ax,es:[4600h]
	mov	[bp-2h],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Ch
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	2966h

l0800_295B:
	mov	es,[5388h]
	mov	word ptr es:[37FEh],2h

l0800_2966:
	mov	ax,4BAh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [014Eh],1h
	jnz	297Fh

l0800_297A:
	mov	ax,4CFh
	jmp	2982h

l0800_297F:
	mov	ax,4D9h

l0800_2982:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4E0h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[53E0h]
	cmp	word ptr es:[3FFEh],0h
	jnz	29AAh

l0800_29A5:
	mov	ax,4E5h
	jmp	29BEh

l0800_29AA:
	cmp	word ptr [bp+6h],1h
	jz	29B4h

l0800_29B0:
	mov	al,1h
	jmp	29B6h

l0800_29B4:
	sub	al,al

l0800_29B6:
	add	al,41h
	mov	[050Ah],al
	mov	ax,504h

l0800_29BE:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4EFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	cs
	call	2A2Bh
	call	far 1F3Dh:0259h
	mov	[bp+6h],ax
	call	far 1E56h:0388h
	push	word ptr [bp-2h]
	call	far 1E56h:0281h
	mov	ax,[bp+6h]
	mov	sp,bp
	pop	bp
	retf

;; fn0800_29F5: 0800:29F5
;;   Called from:
;;     0800:0333 (in fn0800_0000)
;;     0800:0364 (in fn0800_0000)
fn0800_29F5 proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	mov	es,[538Ah]
	mov	al,es:[0D33Fh]
	sub	ah,ah
	mov	[bp-4h],ax
	mov	al,es:[0D340h]
	mov	[bp-2h],ax
	mov	ah,[bp-2h]
	sub	al,al
	or	ax,[bp-4h]
	mov	[bp-8h],ax
	mov	word ptr [bp-6h],0h
	mov	dx,[bp-6h]
	mov	sp,bp
	pop	bp
	retf

;; fn0800_2A2B: 0800:2A2B
;;   Called from:
;;     0800:004B (in fn0800_0000)
;;     0800:1A5B (in fn0800_1A13)
;;     0800:29D5 (in fn0800_2913)
;;     0800:45B6 (in fn0800_3FAE)
;;     0800:513D (in fn0800_50C8)
;;     0D27:01E1 (in main)
;;     0D27:0211 (in main)
;;     0FDC:0928 (in fn0FDC_0629)
;;     11B8:0DEE (in fn11B8_0D58)
;;     1431:02F4 (in fn1431_000A)
;;     183B:0520 (in fn183B_000A)
;;     183B:053E (in fn183B_000A)
;;     183B:054F (in fn183B_000A)
;;     183B:1029 (in fn183B_000A)
;;     183B:132F (in fn183B_000A)
;;     183B:15EA (in fn183B_14C3)
;;     1E56:0C13 (in fn1E56_0B5E)
;;     1F3D:087C (in fn1F3D_086A)
fn0800_2A2B proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[5384h]
	cmp	word ptr es:[3938h],0h
	jnz	2A4Eh

l0800_2A3E:
	jmp	2A45h

l0800_2A40:
	call	far 1F3Dh:0259h

l0800_2A45:
	call	far 1F3Dh:002Fh
	or	ax,ax
	jnz	2A40h

l0800_2A4E:
	retf

;; fn0800_2A4F: 0800:2A4F
;;   Called from:
;;     0DAB:00C2 (in fn0DAB_0002)
;;     0DAB:04DC (in fn0DAB_0002)
;;     0DAB:0826 (in fn0DAB_04F9)
;;     0DAB:0843 (in fn0DAB_04F9)
;;     1431:02BF (in fn1431_000A)
;;     1543:00BC (in fn1543_0004)
;;     183B:04B4 (in fn183B_000A)
;;     183B:06AF (in fn183B_000A)
;;     183B:10DA (in fn183B_000A)
;;     183B:12DD (in fn183B_000A)
;;     183B:1406 (in fn183B_000A)
;;     183B:1F8C (in fn183B_1C1F)
;;     183B:26E3 (in fn183B_2591)
fn0800_2A4F proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,50Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	retf

;; fn0800_2A69: 0800:2A69
;;   Called from:
;;     183B:03B5 (in fn183B_000A)
;;     183B:0438 (in fn183B_000A)
fn0800_2A69 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,51Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	retf

;; fn0800_2A7E: 0800:2A7E
;;   Called from:
;;     0DAB:06AC (in fn0DAB_04F9)
;;     0DAB:0A5E (in fn0DAB_094B)
;;     183B:043D (in fn183B_000A)
fn0800_2A7E proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,51Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	retf

;; fn0800_2A93: 0800:2A93
;;   Called from:
;;     0800:0533 (in fn0800_051B)
;;     0800:0E70 (in fn0800_0E4B)
fn0800_2A93 proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	es,[538Eh]
	or	ax,es:[0A44Dh]
	mov	cl,8h
	shr	ax,cl
	mov	[bp-4h],ax
	mov	word ptr [bp-0Ah],0h
	jmp	2B15h

l0800_2ABD:
	mov	ax,[bp-8h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	mov	ax,[bp-6h]
	shl	ax,cl
	push	ax
	mov	bx,[bp-0Ah]
	mov	es,[538Ah]
	mov	bl,es:[bx+0D457h]
	sub	bh,bh
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	push	word ptr es:[bx+39FCh]
	push	word ptr es:[bx+39FAh]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h

l0800_2AF7:
	add	sp,0Ch
	mov	bx,[bp-0Ah]
	mov	es,[538Ah]
	mov	al,es:[bx+0D457h]
	and	al,7Eh
	cmp	al,7Ch
	jnz	2B12h

l0800_2B0C:
	xor	byte ptr es:[bx+0D457h],1h

l0800_2B12:
	inc	word ptr [bp-0Ah]

l0800_2B15:
	cmp	word ptr [bp-0Ah],40h
	jl	2B1Eh

l0800_2B1B:
	jmp	2C4Ch

l0800_2B1E:
	mov	bx,[bp-0Ah]
	mov	es,[538Ah]
	mov	al,es:[bx+0D497h]
	sub	ah,ah
	mov	[bp-2h],ax
	mov	al,es:[bx+0D4D7h]
	mov	[bp-6h],ax
	mov	ax,[bp-2h]
	and	ax,0Fh
	mov	ch,al
	sub	cl,cl
	or	[bp-6h],cx
	mov	al,es:[bx+0D517h]
	sub	ah,ah
	mov	[bp-8h],ax
	mov	ax,[bp-2h]
	and	ax,0F0h
	mov	ch,al
	or	[bp-8h],cx
	mov	ax,[bp-6h]
	mov	es,[538Ch]
	sub	ax,es:[0A44Bh]
	add	ax,1Ah
	mov	[bp-6h],ax
	mov	ax,[bp-8h]
	mov	es,[538Eh]
	sub	ax,es:[0A44Dh]
	add	ax,0Ch
	mov	[bp-8h],ax
	sub	ax,ax
	mov	[bp-0Eh],ax
	mov	[bp-0Ch],ax
	mov	al,[bp-4h]
	and	al,0Fh
	mov	cl,[bp-2h]
	and	cl,0Fh
	cmp	al,cl
	jnz	2BA5h

l0800_2B94:
	cmp	word ptr [bp-6h],0Dh
	jl	2BA0h

l0800_2B9A:
	cmp	word ptr [bp-6h],27h
	jle	2BA5h

l0800_2BA0:
	mov	word ptr [bp-0Ch],1h

l0800_2BA5:
	mov	al,[bp-4h]
	and	al,0F0h
	mov	cl,[bp-2h]
	and	cl,0F0h
	cmp	al,cl
	jnz	2BC5h

l0800_2BB4:
	cmp	word ptr [bp-8h],0h
	jl	2BC0h

l0800_2BBA:
	cmp	word ptr [bp-8h],18h
	jle	2BC5h

l0800_2BC0:
	mov	word ptr [bp-0Eh],1h

l0800_2BC5:
	cmp	word ptr [bp-6h],8Dh
	jge	2BCEh

l0800_2BCB:
	jmp	2B12h

l0800_2BCE:
	cmp	word ptr [bp-6h],0A7h
	jle	2BD8h

l0800_2BD5:
	jmp	2B12h

l0800_2BD8:
	cmp	word ptr [bp-8h],0F080h
	jge	2BE2h

l0800_2BDF:
	jmp	2B12h

l0800_2BE2:
	cmp	word ptr [bp-8h],0F98h
	jle	2BECh

l0800_2BE9:
	jmp	2B12h

l0800_2BEC:
	mov	ax,[bp-0Ch]
	add	ax,[bp-0Eh]
	jz	2BF7h

l0800_2BF4:
	jmp	2B12h

l0800_2BF7:
	and	word ptr [bp-6h],7Fh
	and	word ptr [bp-8h],7Fh
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	2C0Eh

l0800_2C0B:
	jmp	2ABDh

l0800_2C0E:
	mov	ax,[bp-8h]
	mov	cl,3h
	shl	ax,cl
	push	ax
	mov	ax,[bp-6h]
	shl	ax,cl
	push	ax
	mov	bx,[bp-0Ah]
	mov	es,[538Ah]
	mov	bl,es:[bx+0D457h]
	sub	bh,bh
	shl	bx,1h
	shl	bx,1h
	mov	es,[539Eh]
	push	word ptr es:[bx+39FCh]
	push	word ptr es:[bx+39FAh]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	jmp	2AF7h

l0800_2C4C:
	mov	sp,bp
	pop	bp
	retf

;; fn0800_2C50: 0800:2C50
;;   Called from:
;;     0800:0107 (in fn0800_0000)
fn0800_2C50 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	mov	es,[53E4h]
	mov	word ptr es:[0012h],0Dh
	mov	word ptr es:[0016h],7h
	mov	es,[53E6h]
	mov	word ptr es:[00A6h],7h
	sub	ax,ax
	mov	[bp-4h],ax
	mov	[bp-6h],ax
	jmp	2C9Eh

l0800_2C82:
	mov	ax,7Dh
	imul	word ptr [bp-6h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	2C9Bh

l0800_2C96:
	mov	word ptr [bp-4h],1h

l0800_2C9B:
	inc	word ptr [bp-6h]

l0800_2C9E:
	cmp	word ptr [bp-6h],4h
	jl	2C82h

l0800_2CA4:
	cmp	word ptr [bp-4h],0h
	jz	2CC1h

l0800_2CAA:
	mov	es,[53E6h]
	inc	word ptr es:[00A6h]
	mov	es,[53E4h]
	dec	word ptr es:[0012h]
	inc	word ptr es:[0016h]

l0800_2CC1:
	mov	ax,1h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,1h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	ax,51Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-4h],0h
	jz	2CFEh

l0800_2CF1:
	mov	ax,543h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l0800_2CFE:
	mov	ax,55Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,592h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-2h],ax
	cmp	word ptr [bp-4h],0h
	jnz	2D4Dh

l0800_2D2D:
	cmp	ax,1h
	jz	2D60h

l0800_2D32:
	cmp	ax,2h
	jz	2D6Ch

l0800_2D37:
	cmp	ax,3h
	jz	2D72h

l0800_2D3C:
	cmp	ax,4h
	jz	2D7Fh

l0800_2D41:
	cmp	ax,5h
	jz	2D85h

l0800_2D46:
	cmp	ax,6h
	jz	2D8Bh

l0800_2D4B:
	jmp	2D9Fh

l0800_2D4D:
	mov	ax,[bp-2h]
	sub	ax,1h
	cmp	ax,6h
	ja	2D9Fh

l0800_2D58:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+2D91h]

l0800_2D60:
	push	cs
	call	3BD0h
	jmp	2D9Fh

l0800_2D66:
	push	cs
	call	4D57h
	jmp	2D9Fh

l0800_2D6C:
	push	cs
	call	378Dh
	jmp	2D9Fh

l0800_2D72:
	sub	ax,ax
	push	ax
	call	far 1431h:000Ah
	add	sp,2h
	jmp	2D9Fh

l0800_2D7F:
	push	cs
	call	32B3h
	jmp	2D9Fh

l0800_2D85:
	push	cs
	call	35D3h
	jmp	2D9Fh

l0800_2D8B:
	push	cs
	call	3D40h
	jmp	2D9Fh
l0800_2D91	dw	0x2D60
l0800_2D93	dw	0x2D66
l0800_2D95	dw	0x2D6C
l0800_2D97	dw	0x2D72
l0800_2D99	dw	0x2D7F
l0800_2D9B	dw	0x2D85
l0800_2D9D	dw	0x2D8B

l0800_2D9F:
	call	far 1F3Dh:06C3h
	mov	sp,bp
	pop	bp
	retf

;; fn0800_2DA8: 0800:2DA8
;;   Called from:
;;     0800:2264 (in fn0800_218F)
;;     0800:22D8 (in fn0800_218F)
;;     0800:34AA (in fn0800_32B3)
;;     0800:3F1D (in fn0800_3D40)
;;     0800:4FF5 (in fn0800_4DC7)
;;     135D:00C2 (in fn135D_0004)
;;     183B:0FC8 (in fn183B_000A)
;;     183B:28B2 (in fn183B_2835)
;;     1CD3:1314 (in fn1CD3_0004)
fn0800_2DA8 proc
	push	bp
	mov	bp,sp
	mov	ax,16h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [0150h],55h
	mov	es,[538Ah]
	mov	byte ptr es:[0D346h],0h
	cmp	word ptr [bp+8h],0Eh
	jnz	2DD7h

l0800_2DCB:
	mov	word ptr [0150h],21h
	mov	byte ptr es:[0D346h],1h

l0800_2DD7:
	mov	ax,5A5h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	ax,0Ah
	push	ax
	mov	ax,15h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp+8h]
	call	far 207Fh:3BB6h
	add	sp,8h
	mov	ax,5A9h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	cmp	word ptr [bp+8h],0Bh
	jnz	2EA8h

l0800_2E29:
	mov	es,[53D2h]
	cmp	word ptr es:[3988h],1h
	jz	2EA8h

l0800_2E35:
	mov	ax,150h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	es,[53E8h]
	mov	word ptr es:[4FBCh],1h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,5AEh
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
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	2E9Dh

l0800_2E89:
	mov	ax,0A400h
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l0800_2E9D:
	mov	es,[53D2h]
	mov	word ptr es:[3988h],1h

l0800_2EA8:
	cmp	word ptr [bp+8h],0Bh
	jz	2EBEh

l0800_2EAE:
	mov	es,[53D2h]
	cmp	word ptr es:[3988h],0h
	jz	2EBEh

l0800_2EBA:
	push	cs
	call	4621h

l0800_2EBE:
	mov	ax,1h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	cmp	word ptr [bp+8h],1h
	jz	2EDBh

l0800_2ECF:
	cmp	word ptr [bp+8h],0Bh
	jz	2EDBh

l0800_2ED5:
	cmp	word ptr [bp+8h],0Eh
	jl	2EF0h

l0800_2EDB:
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	jmp	2EEDh

l0800_2EE5:
	push	word ptr [014Eh]
	push	cs
	call	2913h

l0800_2EED:
	add	sp,2h

l0800_2EF0:
	mov	ax,8000h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-0Eh],ax
	inc	ax
	jz	2EE5h

l0800_2F0A:
	mov	ax,1h
	push	ax
	lea	ax,[bp-4h]
	push	ss
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,1h
	push	ax
	lea	ax,[bp-8h]
	push	ss
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,1h
	push	ax
	lea	ax,[bp-0Ch]
	push	ss
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,1h
	push	ax
	lea	ax,[bp-2h]
	push	ss
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,1h
	push	ax
	lea	ax,[bp-0Ah]
	push	ss
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,80h
	push	ax
	mov	ax,0A461h
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,100h
	push	ax
	mov	ax,0A561h
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,20h
	push	ax
	mov	ax,4564h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,20h
	push	ax
	mov	ax,4596h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,20h
	push	ax
	mov	ax,39B4h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,20h
	push	ax
	mov	ax,39D4h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,10h
	push	ax
	mov	ax,4602h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,8h
	push	ax
	mov	ax,3768h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	mov	cl,3h
	shr	[bp-2h],cl
	shr	[bp-0Ah],cl
	mov	ax,1000h
	push	ax
	mov	ax,101Dh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-0Eh]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-0Eh]
	call	far 207Fh:3336h
	add	sp,2h
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+170h]
	mov	dx,[bx+172h]
	mov	[bp-12h],ax
	mov	[bp-10h],dx
	mov	al,[bp-0Ch]
	sub	ah,ah
	mov	cl,3h
	shl	ax,cl
	mov	cl,[bp-8h]
	sub	ch,ch
	add	ax,cx
	add	[bp-12h],ax
	mov	byte ptr [bp-6h],90h
	mov	[bp-0Ch],ch
	jmp	30ADh

l0800_3081:
	inc	byte ptr [bp-8h]

l0800_3084:
	mov	al,[bp-2h]
	cmp	[bp-8h],al
	jnc	30AAh

l0800_308C:
	mov	bl,[bp-0Ch]
	sub	bh,bh
	mov	cl,3h
	shl	bx,cl
	mov	al,[bp-8h]
	sub	ah,ah
	add	bx,ax
	les	si,[bp-12h]
	mov	al,[bp-6h]
	inc	byte ptr [bp-6h]
	mov	es:[bx+si],al
	jmp	3081h

l0800_30AA:
	inc	byte ptr [bp-0Ch]

l0800_30AD:
	mov	al,[bp-0Ah]
	cmp	[bp-0Ch],al
	jnc	30BBh

l0800_30B5:
	mov	byte ptr [bp-8h],0h
	jmp	3084h

l0800_30BB:
	cmp	word ptr [bp+8h],2h
	jnz	30D8h

l0800_30C1:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D343h],0h
	jz	30D8h

l0800_30CD:
	sub	ax,ax
	push	ax
	call	far 1543h:0C72h
	add	sp,2h

l0800_30D8:
	cmp	word ptr [014Ch],0h
	jz	30E2h

l0800_30DF:
	jmp	3205h

l0800_30E2:
	mov	byte ptr [bp-8h],0h

l0800_30E6:
	mov	al,1Ah
	mul	byte ptr [bp-8h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	byte ptr es:[bx+0D399h],1h
	call	far 207Fh:0BC0h
	and	al,7h
	mov	[bp-0Ch],al
	mov	al,1Ah
	mul	byte ptr [bp-8h]
	mov	si,ax
	mov	al,[bp-0Ch]
	mov	cl,4h
	shl	al,cl
	mov	es,[538Ah]
	mov	es:[si+0D398h],al
	mov	bl,[bp-0Ch]
	sub	bh,bh
	mov	es,[53DAh]
	mov	al,es:[bx+3768h]
	mov	[bp-0Ch],al
	mov	es,[538Ah]
	or	es:[si+0D398h],al
	mov	al,[bp-0Ch]
	sub	ah,ah
	mov	di,ax
	shl	di,1h
	mov	es,[53CAh]
	mov	ax,es:[di+4564h]
	mov	es,[538Ah]
	mov	es:[si+0D394h],ax
	mov	es,[53CCh]
	mov	ax,es:[di+4596h]
	mov	es,[538Ah]
	mov	es:[si+0D396h],ax
	mov	al,[bp-8h]
	sub	ah,ah
	mov	[bp-14h],ax
	shl	ax,1h
	mov	[bp-16h],ax
	mov	es,[53CAh]
	mov	ax,es:[di+4564h]
	mov	es,[538Ah]
	mov	es:[si+0D390h],ax
	mov	bx,[bp-16h]
	mov	es,[53A4h]
	mov	es:[bx+4024h],ax
	mov	es,[53CCh]
	mov	ax,es:[di+4596h]
	mov	es,[538Ah]
	mov	es:[si+0D392h],ax
	mov	bx,[bp-16h]
	mov	es,[53A6h]
	mov	es:[bx+4056h],ax
	mov	bx,[bp-14h]
	mov	es,[53BEh]
	mov	byte ptr es:[bx+397Ch],0FFh
	mov	bx,[bp-14h]
	mov	es,[539Ah]
	mov	byte ptr es:[bx+40AAh],10h
	cmp	word ptr [bp+8h],0Ah
	jle	31F9h

l0800_31C8:
	mov	al,[bp-8h]
	sub	ah,ah
	mov	si,ax
	shl	si,1h
	sub	al,al
	mov	cx,ax
	mov	al,1Ah
	mul	byte ptr [bp-8h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	es:[bx+0D399h],cl
	sub	ch,ch
	mov	es,[53A6h]
	mov	es:[si+4056h],cx
	mov	es,[53A4h]
	mov	es:[si+4024h],cx

l0800_31F9:
	inc	byte ptr [bp-8h]
	cmp	byte ptr [bp-8h],8h
	jnc	3205h

l0800_3202:
	jmp	30E6h

l0800_3205:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn0800_320B: 0800:320B
;;   Called from:
;;     0800:511F (in fn0800_50C8)
fn0800_320B proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	mov	ax,150h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	es,[53E8h]
	mov	word ptr es:[4FBCh],1h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,5BBh
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
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	3287h

l0800_3271:
	mov	ax,780h
	push	ax
	mov	ax,4694h
	mov	dx,3092h
	push	dx
	push	ax
	push	dx
	push	ax
	call	far 207Fh:0572h
	add	sp,0Ah

l0800_3287:
	mov	ax,780h
	push	ax
	mov	ax,0D582h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,4694h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0A76h
	add	sp,0Ah
	push	cs
	call	4621h
	mov	ax,1h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	retf

;; fn0800_32B3: 0800:32B3
;;   Called from:
;;     0800:2D7F (in fn0800_2C50)
;;     0800:51DC (in fn0800_50C8)
fn0800_32B3 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ch
	call	far 207Fh:2FDCh
	push	si
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,5C7h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,28h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-4h],ax
	cmp	ax,6h
	jnz	32F4h

l0800_32F1:
	jmp	35ADh

l0800_32F4:
	mov	al,[bp-4h]
	add	al,31h
	mov	[0158h],al
	mov	ax,3h
	push	ax
	push	cs
	call	28CCh
	jmp	330Eh

l0800_3306:
	push	word ptr [014Eh]
	push	cs
	call	2913h

l0800_330E:
	add	sp,2h
	mov	ax,8000h
	push	ax
	mov	ax,5F5h
	push	ds
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-0Ch],ax
	inc	ax
	jz	3306h

l0800_3328:
	push	word ptr [bp-0Ch]
	call	far 207Fh:3336h
	add	sp,2h
	mov	ax,8000h
	push	ax
	mov	ax,154h
	push	ds
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-0Ch],ax
	cmp	ax,0FFFFh
	jnz	334Fh

l0800_334C:
	jmp	3571h

l0800_334F:
	mov	ax,1h
	push	ax
	lea	ax,[bp-2h]
	push	ss
	push	ax
	push	word ptr [bp-0Ch]
	call	far 207Fh:3580h
	add	sp,8h
	cmp	byte ptr [bp-2h],0Ch
	jz	3383h

l0800_3369:
	call	far 1E56h:0388h
	mov	ax,601h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	34D3h

l0800_3383:
	mov	es,[53D0h]
	mov	byte ptr es:[00FCh],1h
	mov	byte ptr es:[0064h],0h
	mov	ax,0F44h
	push	ax
	mov	ax,0C614h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-0Ch]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,2h
	push	ax
	mov	ax,0A44Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-0Ch]
	call	far 207Fh:3580h
	add	sp,8h
	mov	ax,2h
	push	ax
	mov	ax,0A44Dh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-0Ch]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-0Ch]
	call	far 207Fh:3336h
	add	sp,2h
	mov	word ptr [bp-6h],0h

l0800_33E8:
	mov	bx,[bp-6h]
	mov	es,[53EAh]
	mov	byte ptr es:[bx+45DEh],0h
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],21h
	jl	33E8h

l0800_33FE:
	mov	es,[538Ah]
	mov	al,es:[0D35Bh]
	cbw
	mov	es,[53E6h]
	mov	es:[02F8h],ax
	mov	es,[538Ah]
	cmp	byte ptr es:[0D310h],0h
	jz	3425h

l0800_341B:
	mov	es,[53D0h]
	mov	byte ptr es:[00FCh],0Bh

l0800_3425:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D33Eh],0h
	jz	343Bh

l0800_3431:
	mov	es,[53D0h]
	mov	byte ptr es:[0064h],0Ch

l0800_343B:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jz	344Ah

l0800_3447:
	jmp	34CEh

l0800_344A:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	es,[538Eh]
	or	ax,es:[0A44Dh]
	mov	cl,8h
	shr	ax,cl
	mov	[bp-4h],ax
	mov	byte ptr [bp-3h],0h
	push	word ptr [bp-4h]
	call	far 207Fh:104Eh
	add	sp,2h
	sub	word ptr [bp-4h],11h
	mov	word ptr [bp-0Ah],0h

l0800_347A:
	mov	word ptr [bp-6h],0h

l0800_347F:
	mov	si,[bp-4h]
	add	si,[bp-6h]
	js	34B1h

l0800_3487:
	cmp	si,100h
	jge	34B1h

l0800_348D:
	mov	es,[53D0h]
	cmp	byte ptr es:[si+30h],0h
	jz	34B1h

l0800_3499:
	mov	al,es:[si+30h]
	cbw
	push	ax
	mov	ax,3h
	imul	word ptr [bp-0Ah]
	add	ax,[bp-6h]
	push	ax
	push	cs
	call	2DA8h
	add	sp,4h

l0800_34B1:
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],3h
	jl	347Fh

l0800_34BA:
	add	word ptr [bp-4h],10h
	inc	word ptr [bp-0Ah]
	cmp	word ptr [bp-0Ah],3h
	jl	347Ah

l0800_34C7:
	call	far 207Fh:1DA8h
	jmp	34D3h

l0800_34CE:
	call	far 135Dh:0004h

l0800_34D3:
	mov	word ptr [bp-8h],0h

l0800_34D8:
	mov	bx,[bp-8h]
	mov	es,[539Ch]
	mov	byte ptr es:[bx+0D55Eh],0h
	mov	ax,7Dh
	imul	word ptr [bp-8h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C724h],4Ch
	jz	3506h

l0800_34F9:
	mov	bx,[bp-8h]
	mov	es,[539Ch]
	mov	byte ptr es:[bx+0D55Eh],92h

l0800_3506:
	mov	bx,[bp-8h]
	mov	es,[539Ah]
	mov	byte ptr es:[bx+409Ah],0h
	sub	al,al
	mov	bx,[bp-8h]
	mov	es,[53D8h]
	mov	es:[bx+3920h],al
	mov	bx,[bp-8h]
	mov	es,[53BEh]
	mov	es:[bx+396Ch],al
	mov	bx,[bp-8h]
	shl	bx,1h
	shl	bx,1h
	mov	word ptr [bx+1F6h],270h
	mov	word ptr [bx+1F8h],2FE8h
	inc	word ptr [bp-8h]
	cmp	word ptr [bp-8h],4h
	jl	34D8h

l0800_3549:
	mov	es,[53ECh]
	mov	word ptr es:[374Ah],0h
	mov	es,[538Ah]
	cmp	es:[0D346h],al
	jnz	35ADh

l0800_355F:
	mov	es,[53D2h]
	cmp	word ptr es:[3988h],2h
	jnz	35ADh

l0800_356B:
	push	cs
	call	4621h
	jmp	35ADh

l0800_3571:
	call	far 1E56h:0388h
	mov	ax,640h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5388h]
	mov	word ptr es:[37FEh],2h
	mov	ax,154h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,658h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h

l0800_35AD:
	sub	ax,ax
	push	ax
	call	far 1631h:032Fh
	add	sp,2h
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	mov	ax,1h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_35D3: 0800:35D3
;;   Called from:
;;     0800:2D85 (in fn0800_2C50)
fn0800_35D3 proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	mov	es,[538Ah]
	cmp	byte ptr es:[0D34Eh],0h
	jz	35EDh

l0800_35EA:
	jmp	3754h

l0800_35ED:
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,673h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,28h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-4h],ax
	cmp	ax,6h
	jnz	3622h

l0800_361F:
	jmp	376Bh

l0800_3622:
	mov	al,[bp-4h]
	add	al,31h
	mov	[0158h],al
	mov	word ptr [bp-6h],0h
	mov	ax,3h
	push	ax
	push	cs
	call	28CCh
	jmp	3641h

l0800_3639:
	push	word ptr [014Eh]
	push	cs
	call	2913h

l0800_3641:
	add	sp,2h
	mov	ax,8000h
	push	ax
	mov	ax,6A1h
	push	ds
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-8h],ax
	inc	ax
	jz	3639h

l0800_365B:
	push	word ptr [bp-8h]
	call	far 207Fh:3336h
	add	sp,2h
	mov	ax,180h
	push	ax
	mov	ax,8101h
	push	ax
	mov	ax,154h
	push	ds
	push	ax
	call	far 207Fh:33D0h
	add	sp,8h
	mov	[bp-8h],ax
	cmp	ax,0FFFFh
	jnz	368Bh

l0800_3683:
	mov	word ptr [bp-6h],1h
	jmp	371Bh

l0800_368B:
	mov	byte ptr [bp-2h],0Ch
	mov	ax,1h
	push	ax
	lea	ax,[bp-2h]
	push	ss
	push	ax
	push	word ptr [bp-8h]
	call	far 207Fh:366Ah
	add	sp,8h
	cmp	ax,1h
	jz	36ADh

l0800_36A8:
	mov	word ptr [bp-6h],1h

l0800_36AD:
	mov	ax,0F44h
	push	ax
	mov	ax,0C614h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-8h]
	call	far 207Fh:366Ah
	add	sp,8h
	cmp	ax,0F44h
	jz	36CEh

l0800_36C9:
	mov	word ptr [bp-6h],1h

l0800_36CE:
	mov	ax,2h
	push	ax
	mov	ax,0A44Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-8h]
	call	far 207Fh:366Ah
	add	sp,8h
	cmp	ax,2h
	jz	36EFh

l0800_36EA:
	mov	word ptr [bp-6h],1h

l0800_36EF:
	mov	ax,2h
	push	ax
	mov	ax,0A44Dh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-8h]
	call	far 207Fh:366Ah
	add	sp,8h
	cmp	ax,2h
	jz	3710h

l0800_370B:
	mov	word ptr [bp-6h],1h

l0800_3710:
	push	word ptr [bp-8h]
	call	far 207Fh:3336h
	add	sp,2h

l0800_371B:
	cmp	word ptr [bp-6h],0h
	jz	376Bh

l0800_3721:
	call	far 1E56h:0388h
	mov	es,[5388h]
	mov	word ptr es:[37FEh],4h
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	3748h

l0800_373D:
	mov	es,[5388h]
	mov	word ptr es:[37FEh],2h

l0800_3748:
	mov	ax,6ADh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	jmp	3763h

l0800_3754:
	call	far 1CD3h:17C6h
	mov	ax,6D2h
	push	ds
	push	ax
	call	far 1CD3h:17EAh

l0800_3763:
	add	sp,4h
	call	far 1F3Dh:0259h

l0800_376B:
	sub	ax,ax
	push	ax
	call	far 1631h:032Fh
	add	sp,2h
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	mov	ax,1h
	push	ax
	push	cs
	call	28CCh
	mov	sp,bp
	pop	bp
	retf

;; fn0800_378D: 0800:378D
;;   Called from:
;;     0800:2D6C (in fn0800_2C50)
fn0800_378D proc
	push	bp
	mov	bp,sp
	mov	ax,0Ch
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-4h],1h
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	ax,11h
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D31Ch],0h
	jz	383Eh

l0800_37D2:
	mov	ax,6FFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	or	ax,ax
	jz	383Eh

l0800_37EE:
	call	far 1E56h:0388h
	mov	ax,742h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1467h:0B98h
	mov	es,[53EEh]
	mov	bx,es:[0068h]
	mov	es,[53F0h]
	mov	byte ptr es:[bx+6Eh],0h
	mov	es,[53EEh]
	push	word ptr es:[0068h]
	call	far 0DABh:1AFEh
	add	sp,2h
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	call	far 1E56h:0388h
	mov	word ptr [bp-4h],0h

l0800_383E:
	cmp	word ptr [bp-4h],0h
	jnz	3847h

l0800_3844:
	jmp	3BCBh

l0800_3847:
	mov	ax,0Eh
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D31Ah],0h
	jz	387Dh

l0800_385F:
	call	far 1E56h:0388h
	mov	ax,758h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Dh
	push	ax
	call	far 1CD3h:0004h
	add	sp,2h

l0800_387D:
	mov	es,[538Ah]
	mov	al,es:[0D31Ah]
	cbw
	mov	[bp-0Ah],ax
	call	far 1E56h:0388h
	push	cs
	call	28A2h
	mov	ax,772h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,7A3h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+1CCh]
	push	word ptr [bx+1CAh]
	push	cs
	call	2867h
	add	sp,8h
	mov	ax,1h
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,11h
	imul	byte ptr es:[bx+0C61Fh]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	push	cs
	call	2867h
	add	sp,8h
	mov	ax,2h
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C621h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[53F2h]
	push	word ptr es:[bx+4E8Ch]
	push	word ptr es:[bx+4E8Ah]
	push	cs
	call	2867h
	add	sp,8h
	mov	es,[53F4h]
	add	word ptr es:[39A0h],8h
	mov	es,[53F6h]
	sub	word ptr es:[3990h],8h
	mov	ax,4h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+1CCh]
	push	word ptr [bx+1CAh]
	push	cs
	call	2867h
	add	sp,8h
	push	word ptr [bp-0Ah]
	call	far 1631h:02E4h
	add	sp,2h
	mov	es,[53F4h]
	sub	word ptr es:[39A0h],8h
	mov	es,[53F6h]
	add	word ptr es:[3990h],8h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D333h],0h
	jz	39FFh

l0800_39A9:
	mov	al,es:[0D331h]
	cbw
	cmp	ax,[bp-0Ah]
	jnz	39FFh

l0800_39B3:
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Eh
	mov	es,[53DCh]
	mov	word ptr es:[3748h],0h
	mov	es,[53C0h]
	mov	word ptr es:[374Eh],8h
	mov	ax,7FFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Fh
	call	far 1F3Dh:086Ah
	mov	es,[53ECh]
	mov	word ptr es:[374Ah],1h
	jmp	3AE9h

l0800_39FF:
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C621h],0h
	jnz	3A16h

l0800_3A13:
	jmp	3AE9h

l0800_3A16:
	mov	ax,8h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,839h
	push	ds
	push	ax
	push	cs
	call	2867h
	add	sp,8h
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	si,ax
	mov	es,[538Ah]
	mov	al,es:[si+0C622h]
	cbw
	mov	cx,ax
	mov	al,es:[si+0C621h]
	cbw
	mov	bx,ax
	mov	es,[53F8h]
	mov	al,es:[bx+4DDBh]
	cbw
	sub	ax,cx
	mov	[bp-8h],ax
	or	ax,ax
	jnz	3A5Eh

l0800_3A58:
	mov	ax,840h
	jmp	3ADFh

l0800_3A5E:
	mov	ax,856h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C622h],0h
	jnz	3A8Eh

l0800_3A7F:
	mov	ax,860h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	jmp	3A9Dh

l0800_3A8E:
	push	cs
	call	28A2h
	push	word ptr [bp-8h]
	call	far 1F3Dh:0053h
	add	sp,2h

l0800_3A9D:
	mov	es,[5388h]
	mov	word ptr es:[37FEh],0Fh
	mov	ax,864h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C621h]
	cbw
	mov	bx,ax
	mov	es,[53F8h]
	mov	al,es:[bx+4DDBh]
	cbw
	push	ax
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,86Dh

l0800_3ADF:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l0800_3AE9:
	mov	word ptr [bp-6h],0h

l0800_3AEE:
	mov	ax,11h
	imul	word ptr [bp-0Ah]
	mov	bx,ax
	add	bx,[bp-6h]
	mov	es,[538Ah]
	mov	al,es:[bx+0C618h]
	cbw
	mov	[bp-0Ch],ax
	cmp	ax,4h
	jle	3B10h

l0800_3B0B:
	mov	word ptr [bp-0Ch],4h

l0800_3B10:
	mov	ax,[bp-6h]
	add	ax,0Dh
	push	ax
	mov	ax,0Ch
	push	ax
	mov	bx,[bp-0Ch]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+196h]
	push	word ptr [bx+194h]
	push	cs
	call	2867h
	add	sp,8h
	inc	word ptr [bp-6h]
	cmp	word ptr [bp-6h],7h
	jl	3AEEh

l0800_3B3A:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D450h],0h
	jz	3B53h

l0800_3B46:
	mov	ax,15h
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,881h
	jmp	3B5Eh

l0800_3B53:
	mov	ax,15h
	push	ax
	mov	ax,8h
	push	ax
	mov	ax,885h

l0800_3B5E:
	push	ds
	push	ax
	push	cs
	call	2867h
	add	sp,8h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D33Dh],0h
	jz	3B80h

l0800_3B73:
	mov	ax,15h
	push	ax
	mov	ax,14h
	push	ax
	mov	ax,888h
	jmp	3B8Bh

l0800_3B80:
	mov	ax,15h
	push	ax
	mov	ax,14h
	push	ax
	mov	ax,88Ch

l0800_3B8B:
	push	ds
	push	ax
	push	cs
	call	2867h
	add	sp,8h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D451h],0h
	jz	3BADh

l0800_3BA0:
	mov	ax,16h
	push	ax
	mov	ax,13h
	push	ax
	mov	ax,88Fh
	jmp	3BB8h

l0800_3BAD:
	mov	ax,16h
	push	ax
	mov	ax,13h
	push	ax
	mov	ax,893h

l0800_3BB8:
	push	ds
	push	ax
	push	cs
	call	2867h
	add	sp,8h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h

l0800_3BCB:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_3BD0: 0800:3BD0
;;   Called from:
;;     0800:2D60 (in fn0800_2C50)
fn0800_3BD0 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	call	far 1E56h:0388h
	mov	ax,896h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [015Ch],0h
	jz	3BF5h

l0800_3BF0:
	mov	ax,8C9h
	jmp	3BF8h

l0800_3BF5:
	mov	ax,8CCh

l0800_3BF8:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,8CEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,21h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	or	ax,ax
	jz	3C42h

l0800_3C1F:
	cmp	ax,1h
	jnz	3C27h

l0800_3C24:
	jmp	3CB6h

l0800_3C27:
	cmp	ax,2h
	jnz	3C2Fh

l0800_3C2C:
	jmp	3CE4h

l0800_3C2F:
	cmp	ax,3h
	jnz	3C37h

l0800_3C34:
	jmp	3CEBh

l0800_3C37:
	cmp	ax,4h
	jnz	3C3Fh

l0800_3C3C:
	jmp	3D13h

l0800_3C3F:
	jmp	3D3Fh

l0800_3C42:
	call	far 1E56h:0388h
	mov	ax,8F9h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[53E6h]
	mov	word ptr es:[0306h],3h
	mov	word ptr es:[0302h],1h
	mov	ax,[015Ah]
	dec	ax
	mov	es:[0308h],ax
	cmp	word ptr [015Ah],4h
	jnz	3C7Ah

l0800_3C75:
	dec	word ptr es:[0308h]

l0800_3C7A:
	mov	ax,27h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	inc	ax
	mov	[015Ah],ax
	cmp	ax,3h
	jnz	3C93h

l0800_3C8F:
	inc	word ptr [015Ah]

l0800_3C93:
	mov	es,[53E6h]
	mov	word ptr es:[0302h],0h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D34Eh],0h
	jnz	3CADh

l0800_3CAA:
	jmp	3D3Fh

l0800_3CAD:
	mov	word ptr [015Ah],1h
	jmp	3D3Fh

l0800_3CB6:
	call	far 1E56h:0388h
	mov	ax,92Fh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,22h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[015Eh],ax

l0800_3CD7:
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	jmp	3D3Fh

l0800_3CE4:
	xor	byte ptr [015Ch],1h
	jmp	3D3Fh

l0800_3CEB:
	call	far 1E56h:0388h
	mov	ax,95Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,26h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	es,[538Ah]
	mov	es:[0D35Bh],al
	jmp	3CD7h

l0800_3D13:
	call	far 1E56h:0388h
	mov	ax,993h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,9CFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	mov	[0152h],ax

l0800_3D3F:
	retf

;; fn0800_3D40: 0800:3D40
;;   Called from:
;;     0800:2D8B (in fn0800_2C50)
fn0800_3D40 proc
	push	bp
	mov	bp,sp
	mov	ax,12h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [014Ch],1h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-4h],ax
	mov	[bp-0Ah],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-6h],ax
	mov	[bp-0Eh],ax
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jz	3D7Fh

l0800_3D7A:
	call	far 135Dh:0327h

l0800_3D7F:
	mov	word ptr [bp-8h],0h

l0800_3D84:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jnz	3D98h

l0800_3D90:
	cmp	byte ptr es:[0D310h],0h
	jnz	3DABh

l0800_3D98:
	mov	word ptr [bp-8h],1h
	cmp	byte ptr es:[0D346h],0h
	jz	3DABh

l0800_3DA5:
	and	byte ptr es:[0D178h],7Fh

l0800_3DAB:
	push	word ptr [bp-0Eh]
	push	word ptr [bp-0Ah]
	push	cs
	call	3FAEh
	add	sp,4h
	push	ax
	call	far 1E56h:0D1Dh
	add	sp,2h
	mov	[bp-12h],ax
	cmp	ax,20h
	jnz	3DD1h

l0800_3DC9:
	mov	word ptr [bp-8h],1h
	jmp	3E8Fh

l0800_3DD1:
	mov	es,[538Ch]
	mov	ax,[bp-4h]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-6h]
	mov	es:[0A44Dh],ax
	cmp	word ptr [bp-12h],0B8h
	jz	3DF9h

l0800_3DED:
	cmp	word ptr [bp-12h],0B7h
	jz	3DF9h

l0800_3DF3:
	cmp	word ptr [bp-12h],0B9h
	jnz	3E09h

l0800_3DF9:
	cmp	word ptr es:[0A44Dh],2000h
	jc	3E09h

l0800_3E02:
	sub	word ptr es:[0A44Dh],2000h

l0800_3E09:
	cmp	word ptr [bp-12h],0B0h
	jz	3E1Bh

l0800_3E0F:
	cmp	word ptr [bp-12h],0AFh
	jz	3E1Bh

l0800_3E15:
	cmp	word ptr [bp-12h],0B1h
	jnz	3E2Eh

l0800_3E1B:
	mov	es,[538Eh]
	cmp	word ptr es:[0A44Dh],0E000h
	jnc	3E2Eh

l0800_3E28:
	add	byte ptr es:[0A44Eh],20h

l0800_3E2E:
	cmp	word ptr [bp-12h],0B5h
	jz	3E40h

l0800_3E34:
	cmp	word ptr [bp-12h],0B9h
	jz	3E40h

l0800_3E3A:
	cmp	word ptr [bp-12h],0B1h
	jnz	3E54h

l0800_3E40:
	mov	es,[538Ch]
	cmp	word ptr es:[0A44Bh],300h
	jc	3E54h

l0800_3E4D:
	sub	word ptr es:[0A44Bh],200h

l0800_3E54:
	cmp	word ptr [bp-12h],0B3h
	jz	3E66h

l0800_3E5A:
	cmp	word ptr [bp-12h],0B7h
	jz	3E66h

l0800_3E60:
	cmp	word ptr [bp-12h],0AFh
	jnz	3E79h

l0800_3E66:
	mov	es,[538Ch]
	cmp	word ptr es:[0A44Bh],0D00h
	jnc	3E79h

l0800_3E73:
	add	byte ptr es:[0A44Ch],2h

l0800_3E79:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-4h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-6h],ax

l0800_3E8F:
	cmp	word ptr [bp-8h],0h
	jnz	3E98h

l0800_3E95:
	jmp	3D84h

l0800_3E98:
	mov	es,[538Ch]
	mov	ax,[bp-0Ah]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp-0Eh]
	mov	es:[0A44Dh],ax
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jz	3EBDh

l0800_3EBA:
	jmp	3F5Ah

l0800_3EBD:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	es,[538Eh]
	or	ax,es:[0A44Dh]
	mov	cl,8h
	shr	ax,cl
	mov	[bp-2h],ax
	mov	byte ptr [bp-1h],0h
	push	word ptr [bp-2h]
	call	far 207Fh:104Eh
	add	sp,2h
	sub	word ptr [bp-2h],11h
	mov	word ptr [bp-10h],0h

l0800_3EED:
	mov	word ptr [bp-0Ch],0h

l0800_3EF2:
	mov	si,[bp-2h]
	add	si,[bp-0Ch]
	js	3F24h

l0800_3EFA:
	cmp	si,100h
	jge	3F24h

l0800_3F00:
	mov	es,[53D0h]
	cmp	byte ptr es:[si+30h],0h
	jz	3F24h

l0800_3F0C:
	mov	al,es:[si+30h]
	cbw
	push	ax
	mov	ax,3h
	imul	word ptr [bp-10h]
	add	ax,[bp-0Ch]
	push	ax
	push	cs
	call	2DA8h
	add	sp,4h

l0800_3F24:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],3h
	jl	3EF2h

l0800_3F2D:
	add	word ptr [bp-2h],10h
	inc	word ptr [bp-10h]
	cmp	word ptr [bp-10h],3h
	jl	3EEDh

l0800_3F3A:
	mov	word ptr [bp-0Ch],0h

l0800_3F3F:
	mov	bx,[bp-0Ch]
	mov	es,[53CEh]
	mov	byte ptr es:[bx+9F3h],0FFh
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],3h
	jl	3F3Fh

l0800_3F55:
	call	far 207Fh:1DA8h

l0800_3F5A:
	mov	es,[538Eh]
	push	word ptr es:[0A44Dh]
	mov	es,[538Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	push	cs
	call	051Bh
	call	far 1F3Dh:06C3h
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	call	far 1E56h:0388h
	mov	word ptr [014Ch],0h
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jz	3FA9h

l0800_3FA4:
	call	far 135Dh:0327h

l0800_3FA9:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_3FAE: 0800:3FAE
;;   Called from:
;;     0800:3DB1 (in fn0800_3D40)
fn0800_3FAE proc
	push	bp
	mov	bp,sp
	mov	ax,3Ch
	call	far 207Fh:2FDCh
	push	si
	call	far 207Fh:1FBEh
	mov	word ptr [bp-18h],90h
	mov	word ptr [bp-1Eh],4000h
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	mov	[bp-2h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	mov	[bp-6h],ax
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	and	ax,0F00h
	mov	cl,8h
	shr	ax,cl
	mov	[bp-20h],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	and	ax,0F000h
	shr	ax,cl
	mov	[bp-24h],ax
	sub	word ptr [bp-20h],2h
	jns	400Ch

l0800_4007:
	mov	word ptr [bp-20h],0h

l0800_400C:
	cmp	word ptr [bp-20h],0Bh
	jle	4017h

l0800_4012:
	mov	word ptr [bp-20h],0Bh

l0800_4017:
	sub	word ptr [bp-24h],10h
	jns	4022h

l0800_401D:
	mov	word ptr [bp-24h],0h

l0800_4022:
	cmp	word ptr [bp-24h],0D0h
	jle	402Eh

l0800_4029:
	mov	word ptr [bp-24h],0D0h

l0800_402E:
	mov	ax,[bp-24h]
	mov	cl,3h
	shl	ax,cl
	add	ax,[bp-20h]
	mov	[bp-32h],ax
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jz	404Ah

l0800_4047:
	jmp	42D7h

l0800_404A:
	mov	word ptr [bp-2Eh],0h
	jmp	4298h

l0800_4052:
	les	bx,[bp-10h]
	cmp	byte ptr es:[bx],90h
	jnc	4061h

l0800_405B:
	mov	al,[bp-18h]

l0800_405E:
	mov	es:[bx],al

l0800_4061:
	inc	word ptr [bp-12h]

l0800_4064:
	mov	ax,[bp-0Ch]
	cmp	[bp-12h],ax
	jge	4099h

l0800_406C:
	mov	ax,[bp-1Ch]
	mov	cl,3h
	shl	ax,cl
	add	ax,[bp-12h]
	add	ax,[bp-36h]
	mov	dx,[bp-34h]
	mov	[bp-10h],ax
	mov	[bp-0Eh],dx
	cmp	word ptr [bp-4h],1h
	jnz	4052h

l0800_4088:
	cmp	word ptr [bp-3Ah],1h
	jnz	4052h

l0800_408E:
	les	bx,[bp-10h]
	mov	ax,[bp-18h]
	inc	word ptr [bp-18h]
	jmp	405Eh

l0800_4099:
	inc	word ptr [bp-1Ch]

l0800_409C:
	mov	ax,[bp-14h]
	cmp	[bp-1Ch],ax
	jge	40ABh

l0800_40A4:
	mov	word ptr [bp-12h],0h
	jmp	4064h

l0800_40AB:
	cmp	word ptr [bp-4h],1h
	jz	40B4h

l0800_40B1:
	jmp	419Eh

l0800_40B4:
	cmp	word ptr [bp-3Ah],1h
	jz	40BDh

l0800_40BA:
	jmp	419Eh

l0800_40BD:
	mov	ax,9EEh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	ax,0Ah
	push	ax
	mov	ax,15h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,[bp-38h]
	inc	ax
	push	ax
	call	far 207Fh:3BB6h
	add	sp,8h
	mov	ax,9F2h
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	mov	ax,1h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	cmp	word ptr [bp-38h],0h
	jz	411Dh

l0800_4111:
	cmp	word ptr [bp-38h],0Ah
	jz	411Dh

l0800_4117:
	cmp	word ptr [bp-38h],0Dh
	jl	4132h

l0800_411D:
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	jmp	412Fh

l0800_4127:
	push	word ptr [014Eh]
	push	cs
	call	2913h

l0800_412F:
	add	sp,2h

l0800_4132:
	mov	ax,8000h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-26h],ax
	inc	ax
	jz	4127h

l0800_414C:
	mov	ax,21Dh
	push	ax
	mov	bx,[bp-1Eh]
	lea	ax,[bx+244Bh]
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-26h]
	call	far 207Fh:3580h
	add	sp,8h
	mov	bx,[bp-38h]
	shl	bx,1h
	push	word ptr [bx+0A70h]
	mov	bx,[bp-1Eh]
	lea	ax,[bx+244Bh]
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-26h]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-26h]
	call	far 207Fh:3336h
	add	sp,2h
	mov	bx,[bp-38h]
	shl	bx,1h
	mov	ax,[bx+0A70h]
	add	[bp-1Eh],ax

l0800_419E:
	inc	word ptr [bp-3Ah]

l0800_41A1:
	cmp	word ptr [bp-3Ah],3h
	jge	4224h

l0800_41A7:
	mov	si,[bp-0Ah]
	add	si,[bp-3Ah]
	js	419Eh

l0800_41AF:
	cmp	si,100h
	jge	419Eh

l0800_41B5:
	mov	es,[53D0h]
	cmp	byte ptr es:[si+30h],0h
	jz	419Eh

l0800_41C1:
	mov	word ptr [bp-28h],1h
	mov	ax,3h
	imul	word ptr [bp-4h]
	mov	bx,ax
	add	bx,[bp-3Ah]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+170h]
	mov	dx,[bx+172h]
	mov	[bp-36h],ax
	mov	[bp-34h],dx
	mov	al,es:[si+30h]
	cbw
	dec	ax
	mov	[bp-38h],ax
	mov	bx,ax
	mov	al,[bx+0A38h]
	cbw
	mov	[bp-12h],ax
	mov	al,[bx+0A46h]
	cbw
	mov	[bp-1Ch],ax
	mov	al,[bx+0A54h]
	cbw
	mov	[bp-0Ch],ax
	mov	al,[bx+0A62h]
	cbw
	mov	[bp-14h],ax
	mov	ax,[bp-1Ch]
	mov	cl,3h
	shl	ax,cl
	add	ax,[bp-12h]
	add	[bp-36h],ax
	mov	word ptr [bp-1Ch],0h
	jmp	409Ch

l0800_4224:
	add	word ptr [bp-0Ah],10h
	inc	word ptr [bp-4h]

l0800_422B:
	cmp	word ptr [bp-4h],3h
	jge	4239h

l0800_4231:
	mov	word ptr [bp-3Ah],0h
	jmp	41A1h

l0800_4239:
	cmp	word ptr [bp-28h],0h
	jz	4244h

l0800_423F:
	call	far 207Fh:1DA8h

l0800_4244:
	mov	ax,14h
	imul	word ptr [bp-2Eh]
	mov	dx,[bp-2Ah]
	mov	cl,3h
	shl	dx,cl
	add	ax,dx
	push	ax
	call	far 207Fh:1F04h
	add	sp,2h
	mov	es,[538Ch]
	or	byte ptr es:[0A44Bh],7Fh
	call	far 207Fh:17C5h
	inc	word ptr [bp-2Ah]

l0800_426E:
	cmp	word ptr [bp-2Ah],5h
	jge	4294h

l0800_4274:
	mov	word ptr [bp-28h],0h
	mov	ax,[bp-20h]
	add	ax,[bp-2Ah]
	mov	cx,[bp-24h]
	add	cx,[bp-2Eh]
	or	ax,cx
	sub	ax,11h
	mov	[bp-0Ah],ax
	mov	word ptr [bp-4h],0h
	jmp	422Bh

l0800_4294:
	add	word ptr [bp-2Eh],10h

l0800_4298:
	cmp	word ptr [bp-2Eh],30h
	jl	42A1h

l0800_429E:
	jmp	432Ch

l0800_42A1:
	mov	es,[538Ch]
	mov	ah,[bp-20h]
	sub	al,al
	mov	es:[0A44Bh],ax
	mov	si,[bp-24h]
	add	si,[bp-2Eh]
	mov	es,[538Eh]
	mov	ax,si
	mov	cl,8h
	shl	ax,cl
	mov	es:[0A44Dh],ax
	mov	ax,[bp-20h]
	or	ax,si
	push	ax
	call	far 207Fh:104Eh
	add	sp,2h
	mov	word ptr [bp-2Ah],0h
	jmp	426Eh

l0800_42D7:
	mov	word ptr [bp-4h],0h

l0800_42DC:
	mov	bx,[bp-4h]
	mov	es,[53FAh]
	mov	al,es:[bx+101Dh]
	mov	es,[53C6h]
	mov	es:[bx+644Bh],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],1080h
	jl	42DCh

l0800_42FB:
	mov	word ptr [bp-4h],0h

l0800_4300:
	mov	es,[538Ah]
	mov	al,es:[0D34Eh]
	sub	al,30h
	mov	bx,[bp-4h]
	mov	es,[53C6h]
	mov	es:[bx+244Bh],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],3C0h
	jl	4300h

l0800_4320:
	mov	ax,150h
	push	ax
	call	far 207Fh:1F04h
	add	sp,2h

l0800_432C:
	mov	word ptr [bp-4h],0h
	jmp	43C4h

l0800_4334:
	push	word ptr [bp-30h]
	push	cs
	call	45C2h
	add	sp,2h
	push	word ptr [bp-4h]
	push	word ptr [bp-3Ah]
	mov	ax,642Bh
	mov	dx,246Ch

l0800_434A:
	push	dx
	push	ax
	call	far 207Fh:275Ch
	add	sp,8h

l0800_4354:
	sar	word ptr [bp-1Ah],1h
	cmp	word ptr [bp-1Ah],0h
	jnz	4365h

l0800_435D:
	mov	word ptr [bp-1Ah],80h
	inc	word ptr [bp-32h]

l0800_4365:
	inc	word ptr [bp-3Ah]

l0800_4368:
	cmp	word ptr [bp-3Ah],28h
	jge	43BDh

l0800_436E:
	mov	ax,28h
	imul	word ptr [bp-4h]
	mov	bx,ax
	add	bx,[bp-3Ah]
	mov	es,[53C6h]
	mov	al,es:[bx+244Bh]
	sub	ah,ah
	mov	[bp-30h],ax
	mov	bx,[bp-32h]
	mov	es,[538Ah]
	mov	al,es:[bx+0CB0Ch]
	cbw
	test	[bp-1Ah],ax
	jz	4354h

l0800_4399:
	cmp	word ptr [bp-30h],90h
	jnc	4334h

l0800_43A0:
	push	word ptr [bp-4h]
	push	word ptr [bp-3Ah]
	mov	ax,[bp-30h]
	mov	cl,5h
	shl	ax,cl
	mov	es,[53FCh]
	add	ax,es:[4588h]
	mov	dx,es:[458Ah]
	jmp	434Ah

l0800_43BD:
	add	word ptr [bp-32h],0Bh
	inc	word ptr [bp-4h]

l0800_43C4:
	cmp	word ptr [bp-4h],18h
	jge	43D6h

l0800_43CA:
	mov	word ptr [bp-1Ah],80h
	mov	word ptr [bp-3Ah],0h
	jmp	4368h

l0800_43D6:
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jnz	4449h

l0800_43E2:
	cmp	byte ptr es:[0D33Bh],0h
	jz	4449h

l0800_43EA:
	mov	ax,[bp-2h]
	or	ax,[bp-6h]
	sub	al,al
	cmp	ax,8A00h
	jz	4449h

l0800_43F7:
	mov	ax,8038h
	push	ax
	mov	ax,0A38h
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	[bp-2Ch],ax
	mov	es,[53FEh]
	mov	al,[bp-2Ch]
	inc	al
	mov	es:[0012h],al
	mov	byte ptr es:[0013h],0h
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	bx,[bp-2Ch]
	mov	al,[bx+0A92h]
	cbw
	push	ax
	mov	al,[bx+0A8Ah]
	cbw
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch

l0800_4449:
	mov	word ptr [bp-8h],258h
	sub	ax,ax
	push	ax
	mov	ax,0C7h
	push	ax
	mov	ax,13Fh
	push	ax
	mov	ax,0C0h
	push	ax
	sub	ax,ax
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	mov	es,[538Ah]
	cmp	byte ptr es:[0D346h],0h
	jnz	448Fh

l0800_4474:
	cmp	byte ptr es:[0D310h],0h
	jz	448Fh

l0800_447C:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,18h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,9F7h
	jmp	44A0h

l0800_448F:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,18h
	push	ax
	sub	ax,ax
	push	ax
	mov	ax,0A16h

l0800_44A0:
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	es,[538Ch]
	mov	ax,[bp+6h]
	mov	es:[0A44Bh],ax
	mov	es,[538Eh]
	mov	ax,[bp+8h]
	mov	es:[0A44Dh],ax
	mov	word ptr [bp-16h],0h

l0800_44C5:
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	and	ax,0F00h
	mov	cl,8h
	shr	ax,cl
	mov	[bp-3Ah],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	and	ax,0F000h
	shr	ax,cl
	mov	[bp-4h],ax
	mov	ax,[bp-20h]
	sub	[bp-3Ah],ax
	mov	ax,[bp-24h]
	sub	[bp-4h],ax
	mov	es,[538Ch]
	mov	ax,es:[0A44Bh]
	and	ax,7Fh
	shr	ax,1h
	mov	dx,[bp-3Ah]
	mov	cl,6h
	shl	dx,cl
	add	ax,dx
	mov	[bp-3Ah],ax
	mov	es,[538Eh]
	mov	ax,es:[0A44Dh]
	and	ax,7Fh
	shr	ax,1h
	mov	cx,[bp-4h]
	shl	cx,1h
	shl	cx,1h
	add	ax,cx
	mov	[bp-4h],ax
	cmp	word ptr [bp-3Ah],0h
	jl	4574h

l0800_452B:
	cmp	word ptr [bp-3Ah],140h
	jge	4574h

l0800_4532:
	or	ax,ax
	jl	4574h

l0800_4536:
	cmp	ax,0C0h
	jge	4574h

l0800_453B:
	cmp	word ptr [bp-3Ah],13Eh
	jle	4547h

l0800_4542:
	mov	word ptr [bp-3Ah],13Eh

l0800_4547:
	cmp	word ptr [bp-4h],0BFh
	jle	4553h

l0800_454E:
	mov	word ptr [bp-4h],0BFh

l0800_4553:
	call	far 207Fh:0BC0h
	and	ax,0Fh
	push	ax
	mov	ax,[bp-4h]
	inc	ax
	push	ax
	mov	ax,[bp-3Ah]
	inc	ax
	push	ax
	push	word ptr [bp-4h]
	push	word ptr [bp-3Ah]
	call	far 1F3Dh:01FBh
	add	sp,0Ah

l0800_4574:
	mov	es,[5384h]
	cmp	word ptr es:[3938h],0h
	jnz	458Ah

l0800_4580:
	call	far 1F3Dh:002Fh
	mov	[bp-16h],ax
	jmp	45A5h

l0800_458A:
	mov	ax,[bp-8h]
	dec	word ptr [bp-8h]
	or	ax,ax
	jnz	4599h

l0800_4594:
	mov	word ptr [bp-16h],1h

l0800_4599:
	mov	ax,1h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h

l0800_45A5:
	cmp	word ptr [bp-16h],0h
	jnz	45AEh

l0800_45AB:
	jmp	44C5h

l0800_45AE:
	call	far 1F3Dh:0259h
	mov	[bp-22h],ax
	push	cs
	call	2A2Bh
	mov	ax,[bp-22h]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_45C2: 0800:45C2
;;   Called from:
;;     0800:4337 (in fn0800_3FAE)
fn0800_45C2 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	push	word ptr [bp+6h]
	call	far 207Fh:1F51h
	add	sp,2h
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	45FDh

l0800_45E3:
	mov	ax,10h
	push	ax
	mov	ax,2h
	push	ax
	mov	ax,642Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	dx
	push	ax
	call	far 207Fh:0163h
	add	sp,0Ch

l0800_45FD:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	461Fh

l0800_4609:
	mov	ax,10h
	push	ax
	mov	ax,642Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	dx
	push	ax
	call	far 207Fh:0572h
	add	sp,0Ah

l0800_461F:
	pop	bp
	retf

;; fn0800_4621: 0800:4621
;;   Called from:
;;     0800:2EBA (in fn0800_2DA8)
;;     0800:32A3 (in fn0800_320B)
;;     0800:356B (in fn0800_32B3)
fn0800_4621 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,150h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	es,[53E8h]
	mov	word ptr es:[4FBCh],1h
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,0A9Ah
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
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	469Bh

l0800_4687:
	mov	ax,0A400h
	push	ax
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l0800_469B:
	mov	es,[53D2h]
	mov	word ptr es:[3988h],0h
	retf

;; fn0800_46A7: 0800:46A7
;;   Called from:
;;     0800:5265 (in fn0800_50C8)
;;     0D27:0216 (in main)
fn0800_46A7 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],3h
	jz	46C2h

l0800_46BA:
	mov	ax,0h
	mov	dx,2FE8h
	jmp	46C8h

l0800_46C2:
	mov	ax,10h
	mov	dx,2FE8h

l0800_46C8:
	push	dx
	push	ax
	call	far 1F3Dh:0525h
	add	sp,4h
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	mov	ax,210h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,0AA7h
	push	ds
	push	ax
	call	far 1F3Dh:063Bh
	add	sp,8h
	mov	es,[53E8h]
	mov	word ptr es:[4FBCh],0h
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
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],2h
	jnz	4745h

l0800_4731:
	mov	ax,0A800h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l0800_4745:
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
	mov	es,[53D2h]
	mov	word ptr es:[3988h],0FFFFh
	retf

;; fn0800_476D: 0800:476D
;;   Called from:
;;     0800:5269 (in fn0800_50C8)
fn0800_476D proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	jmp	478Ah

l0800_4782:
	push	word ptr [014Eh]
	push	cs
	call	2913h

l0800_478A:
	add	sp,2h
	mov	ax,8000h
	push	ax
	mov	ax,0AB3h
	push	ds
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-4h],ax
	inc	ax
	jz	4782h

l0800_47A4:
	mov	ax,2h
	push	ax
	sub	ax,ax
	push	ax
	push	ax
	push	word ptr [bp-4h]
	call	far 207Fh:3356h
	add	sp,8h
	mov	[bp-2h],ax
	sub	ax,ax
	push	ax
	push	ax
	push	ax
	push	word ptr [bp-4h]
	call	far 207Fh:3356h
	add	sp,8h
	push	word ptr [bp-2h]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	push	word ptr [bp-4h]
	call	far 207Fh:3580h
	add	sp,8h
	push	word ptr [bp-4h]
	call	far 207Fh:3336h
	add	sp,2h
	mov	bx,[bp-2h]
	mov	es,[53C6h]
	mov	byte ptr es:[bx+244Bh],0h
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+244Ch],0h
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+244Dh],0h
	mov	bx,[bp-2h]
	mov	byte ptr es:[bx+244Eh],0h
	call	far 204Bh:0048h
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],1h
	jnz	4846h

l0800_4824:
	sub	ax,ax
	push	ax
	call	far 204Bh:02E4h
	add	sp,2h
	mov	ax,14h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,1h
	push	ax
	call	far 204Bh:02E4h
	jmp	4866h

l0800_4846:
	sub	ax,ax
	push	ax
	call	far 204Bh:0306h
	add	sp,2h
	mov	ax,4h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,1h
	push	ax
	call	far 204Bh:0306h

l0800_4866:
	add	sp,8h
	mov	es,[5384h]
	mov	word ptr es:[3938h],0h

l0800_4874:
	call	far 1F3Dh:002Fh
	or	ax,ax
	jnz	488Dh

l0800_487D:
	mov	ax,1h
	push	ax
	call	far 204Bh:033Ch
	add	sp,2h
	or	ax,ax
	jz	4874h

l0800_488D:
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],1h
	jnz	48A3h

l0800_4899:
	sub	ax,ax
	push	ax
	call	far 204Bh:02E4h
	jmp	48ABh

l0800_48A3:
	sub	ax,ax
	push	ax
	call	far 204Bh:0306h

l0800_48AB:
	add	sp,2h
	call	far 204Bh:0091h
	mov	sp,bp
	pop	bp
	retf

;; fn0800_48B7: 0800:48B7
;;   Called from:
;;     0800:0023 (in fn0800_0000)
;;     0FDC:00AC (in fn0FDC_0008)
;;     0FDC:04BE (in fn0FDC_01C0)
;;     0FDC:0BC5 (in fn0FDC_0629)
;;     183B:0F8E (in fn183B_000A)
;;     1AE8:0D39 (in fn1AE8_000C)
;;     1AE8:0D6E (in fn1AE8_000C)
;;     1AE8:1AD6 (in fn1AE8_12C7)
;;     1CD3:00B0 (in fn1CD3_0004)
;;     1CD3:1096 (in fn1CD3_0004)
fn0800_48B7 proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	mov	es,[53FEh]
	mov	byte ptr es:[0012h],4Fh
	mov	ax,0Ah
	push	ax
	mov	ax,13h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp+6h]
	call	far 207Fh:3BB6h
	add	sp,8h
	mov	ax,0ABFh
	push	ds
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	sub	ax,ax
	mov	[bp-8h],ax
	mov	[bp-2h],ax
	call	far 207Fh:0BC0h
	mov	es,[538Ah]
	mov	cx,ax
	mov	al,es:[0D35Bh]
	cbw
	mov	bx,ax
	shl	bx,1h
	test	[bx+0AC4h],cx
	jnz	491Fh

l0800_491A:
	mov	word ptr [bp-8h],1h

l0800_491F:
	cmp	word ptr [bp+6h],10h
	jz	4942h

l0800_4925:
	cmp	word ptr [bp+6h],0h
	jz	493Dh

l0800_492B:
	cmp	word ptr [bp+6h],7h
	jg	493Dh

l0800_4931:
	cmp	word ptr [bp+6h],6h
	jz	493Dh

l0800_4937:
	cmp	word ptr [bp+6h],2h
	jnz	4942h

l0800_493D:
	mov	word ptr [bp-8h],1h

l0800_4942:
	cmp	word ptr [bp+8h],2h
	jnz	494Dh

l0800_4948:
	mov	word ptr [bp-8h],1h

l0800_494D:
	cmp	word ptr [bp-8h],0h
	jnz	4956h

l0800_4953:
	jmp	4AA2h

l0800_4956:
	cmp	word ptr [bp+6h],8h
	jnz	4961h

l0800_495C:
	mov	word ptr [bp-2h],6h

l0800_4961:
	mov	ax,1h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	cmp	word ptr [bp+6h],9h
	jle	4983h

l0800_4972:
	cmp	word ptr [bp+6h],10h
	jge	4983h

l0800_4978:
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h

l0800_4983:
	cmp	word ptr [bp+6h],10h
	jle	49C5h

l0800_4989:
	mov	ax,8000h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:33D0h
	add	sp,6h
	mov	[bp-6h],ax
	push	ax
	call	far 207Fh:3336h
	add	sp,2h
	cmp	word ptr [bp-6h],0FFh
	jnz	49C5h

l0800_49AF:
	mov	word ptr [bp-8h],0h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h

l0800_49C5:
	cmp	word ptr [bp-8h],0h
	jnz	49CEh

l0800_49CB:
	jmp	4AA2h

l0800_49CE:
	mov	ax,3F00h
	push	ax
	mov	ax,42C3h
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:0814h
	add	sp,0Ah
	mov	ax,150h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h

l0800_49FA:
	mov	word ptr [bp-4h],0h

l0800_49FF:
	mov	bx,[bp-4h]
	mov	es,[53C6h]
	mov	byte ptr es:[bx+244Bh],0h
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],1E78h
	jl	49FFh

l0800_4A16:
	mov	es,[53C4h]
	mov	word ptr es:[0E48Ah],0h
	mov	es,[53C2h]
	mov	word ptr es:[0064h],42F6h
	mov	word ptr es:[0066h],246Ch
	push	cs
	call	1AFDh
	cmp	word ptr [bp+6h],8h
	jz	4A4Fh

l0800_4A3D:
	mov	ax,32h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	jmp	4A4Fh

l0800_4A4B:
	push	cs
	call	1AFDh

l0800_4A4F:
	mov	es,[53C4h]
	mov	bx,es:[0E48Ah]
	mov	es,[53C6h]
	cmp	byte ptr es:[bx+42C3h],0h
	jnz	4A4Bh

l0800_4A64:
	mov	ax,[bp-2h]
	dec	word ptr [bp-2h]
	or	ax,ax
	jnz	49FAh

l0800_4A6E:
	cmp	word ptr [bp+8h],0h
	jnz	4AA2h

l0800_4A74:
	cmp	word ptr [bp+6h],0h
	jnz	4A85h

l0800_4A7A:
	mov	ax,0Ch
	push	ax
	push	cs
	call	19BFh
	add	sp,2h

l0800_4A85:
	mov	ax,3Ch
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h

l0800_4AA2:
	mov	sp,bp
	pop	bp
	retf

;; fn0800_4AA6: 0800:4AA6
;;   Called from:
;;     0800:4D26 (in fn0800_4CAC)
fn0800_4AA6 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ah
	call	far 207Fh:2FDCh
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	push	word ptr [bp+8h]
	mov	ax,1h
	push	ax
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+1CCh]
	push	word ptr [bx+1CAh]
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	cl,3h
	shl	word ptr [bp+8h],cl
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C615h]
	cbw
	mov	[bp-8h],ax
	push	word ptr [bp+8h]
	mov	ax,9h
	push	ax
	push	word ptr [bp-8h]
	push	cs
	call	4BC1h
	add	sp,6h
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C623h]
	cbw
	mov	cl,0Ah
	idiv	cl
	cbw
	mov	[bp-2h],ax
	or	ax,ax
	jnz	4B35h

l0800_4B30:
	mov	word ptr [bp-2h],1h

l0800_4B35:
	mov	ax,[bp-8h]
	sub	ax,[bp-2h]
	mov	[bp-2h],ax
	or	ax,ax
	jz	4B7Eh

l0800_4B42:
	mov	word ptr [bp-0Ah],4h
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	4B58h

l0800_4B53:
	mov	word ptr [bp-0Ah],2h

l0800_4B58:
	mov	ax,[bp+8h]
	sub	ax,[bp-8h]
	add	ax,0Eh
	mov	[bp-6h],ax
	push	word ptr [bp-0Ah]
	add	ax,[bp-2h]
	push	ax
	mov	ax,4Ch
	push	ax
	push	word ptr [bp-6h]
	mov	ax,4Ah
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah

l0800_4B7E:
	push	word ptr [bp+8h]
	mov	ax,0Ah
	push	ax
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C616h]
	cbw
	push	ax
	push	cs
	call	4BC1h
	add	sp,6h
	push	word ptr [bp+8h]
	mov	ax,0Bh
	push	ax
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	al,es:[bx+0C617h]
	cbw
	push	ax
	push	cs
	call	4BC1h
	mov	sp,bp
	pop	bp
	retf

;; fn0800_4BC1: 0800:4BC1
;;   Called from:
;;     0800:4B0B (in fn0800_4AA6)
;;     0800:4B98 (in fn0800_4AA6)
;;     0800:4BB9 (in fn0800_4AA6)
fn0800_4BC1 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	cl,3h
	shl	word ptr [bp+8h],cl
	mov	ax,0Ch
	sub	ax,[bp+6h]
	mov	[bp+6h],ax
	mov	word ptr [bp-2h],0Eh
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	4BF1h

l0800_4BEC:
	mov	word ptr [bp-2h],3h

l0800_4BF1:
	push	word ptr [bp-2h]
	push	word ptr [bp+0Ah]
	mov	ax,[bp+8h]
	add	ax,5h
	push	ax
	push	word ptr [bp+0Ah]
	mov	ax,[bp+8h]
	inc	ax
	push	ax
	call	far 1F3Dh:031Ch
	add	sp,0Ah
	push	word ptr [bp-2h]
	mov	ax,[bp+0Ah]
	add	ax,0Dh
	push	ax
	push	word ptr [bp+8h]
	mov	ax,[bp+0Ah]
	inc	ax
	push	ax
	push	word ptr [bp+8h]
	call	far 1F3Dh:031Ch
	add	sp,0Ah
	mov	si,[bp+8h]
	add	si,6h
	push	word ptr [bp-2h]
	mov	ax,[bp+0Ah]
	add	ax,0Dh
	push	ax
	push	si
	mov	ax,[bp+0Ah]
	inc	ax
	push	ax
	push	si
	call	far 1F3Dh:031Ch
	add	sp,0Ah
	mov	si,[bp+0Ah]
	add	si,0Eh
	push	word ptr [bp-2h]
	push	si
	mov	ax,[bp+8h]
	add	ax,5h
	push	ax
	push	si
	mov	ax,[bp+8h]
	inc	ax
	push	ax
	call	far 1F3Dh:031Ch
	add	sp,0Ah
	mov	word ptr [bp-2h],0Ah
	mov	es,[53A0h]
	cmp	word ptr es:[4FBAh],0h
	jnz	4C7Fh

l0800_4C7A:
	mov	word ptr [bp-2h],1h

l0800_4C7F:
	push	word ptr [bp-2h]
	mov	ax,[bp+0Ah]
	add	ax,0Dh
	push	ax
	mov	ax,[bp+8h]
	add	ax,4h
	push	ax
	mov	ax,[bp+0Ah]
	add	ax,[bp+6h]
	inc	ax
	inc	ax
	push	ax
	mov	ax,[bp+8h]
	inc	ax
	inc	ax
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn0800_4CAC: 0800:4CAC
;;   Called from:
;;     0800:35BC (in fn0800_32B3)
;;     0800:377A (in fn0800_35D3)
;;     0800:382D (in fn0800_378D)
;;     0800:3CDB (in fn0800_3BD0)
;;     0800:3F86 (in fn0800_3D40)
;;     0800:4D9E (in fn0800_4D57)
;;     0800:4FBF (in fn0800_4DC7)
;;     0FDC:017E (in fn0FDC_0008)
;;     11B8:0DCA (in fn11B8_0D58)
;;     1431:02C7 (in fn1431_000A)
;;     1467:0B44 (in fn1467_08A8)
;;     183B:1315 (in fn183B_000A)
;;     1CD3:173F (in fn1CD3_0004)
fn0800_4CAC proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,3h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	cmp	word ptr [bp+6h],0h
	jz	4CDAh

l0800_4CD5:
	call	far 1E56h:0388h

l0800_4CDA:
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,0Dh
	push	ax
	mov	ax,9h
	push	ax
	mov	ax,0ACAh
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-4h],0h

l0800_4D00:
	cmp	word ptr [bp-2h],4h
	jge	4D30h

l0800_4D06:
	mov	ax,11h
	imul	word ptr [bp-4h]
	mov	bx,ax
	mov	es,[538Ah]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jz	4D30h

l0800_4D1A:
	mov	ax,[bp-2h]
	shl	ax,1h
	add	ax,0Eh
	push	ax
	push	word ptr [bp-4h]
	push	cs
	call	4AA6h
	add	sp,4h
	inc	word ptr [bp-2h]

l0800_4D30:
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],8h
	jl	4D00h

l0800_4D39:
	call	far 1631h:1FDFh
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,4h
	push	ax
	call	far 1E56h:0004h
	mov	sp,bp
	pop	bp
	retf

;; fn0800_4D57: 0800:4D57
;;   Called from:
;;     0800:2D66 (in fn0800_2C50)
fn0800_4D57 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-4h],1h
	mov	word ptr [bp-2h],0h

l0800_4D6C:
	mov	bx,[bp-2h]
	mov	es,[53C8h]
	test	byte ptr es:[bx+7A4h],80h
	jz	4D80h

l0800_4D7B:
	mov	word ptr [bp-4h],0h

l0800_4D80:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],9h
	jl	4D6Ch

l0800_4D89:
	cmp	word ptr [bp-4h],0h
	jz	4DACh

l0800_4D8F:
	sub	ax,ax
	push	ax
	call	far 1467h:0002h
	add	sp,2h
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	call	far 1E56h:0388h
	jmp	4DC3h

l0800_4DAC:
	call	far 1CD3h:17C6h
	mov	ax,0ACEh
	push	ds
	push	ax
	call	far 1CD3h:17EAh
	add	sp,4h
	call	far 1F3Dh:0259h

l0800_4DC3:
	mov	sp,bp
	pop	bp
	retf

;; fn0800_4DC7: 0800:4DC7
;;   Called from:
;;     0800:0501 (in fn0800_0000)
;;     0800:5141 (in fn0800_50C8)
;;     0800:5250 (in fn0800_50C8)
fn0800_4DC7 proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	mov	es,[538Ah]
	mov	al,0FFh
	mov	es:[0D455h],al
	mov	es:[0D454h],al
	mov	es:[0D453h],al
	mov	es:[0D452h],al
	mov	es:[0CA8Fh],al
	mov	es:[0CA12h],al
	mov	es:[0C995h],al
	mov	es:[0C918h],al
	mov	es:[0C89Bh],al
	mov	es:[0C81Eh],al
	mov	es:[0C7A1h],al
	mov	es:[0C724h],al
	mov	word ptr [bp-2h],1h

l0800_4E0D:
	mov	ax,11h
	imul	word ptr [bp-2h]
	mov	bx,ax
	mov	es,[538Ah]
	mov	byte ptr es:[bx+0C614h],0FFh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],8h
	jl	4E0Dh

l0800_4E28:
	mov	word ptr [bp-2h],0h

l0800_4E2D:
	mov	bx,[bp-2h]
	mov	es,[538Ah]
	mov	byte ptr es:[bx+0C618h],0h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],6h
	jle	4E2Dh

l0800_4E43:
	mov	word ptr [bp-2h],0h

l0800_4E48:
	mov	bx,[bp-2h]
	mov	es,[538Ah]
	mov	byte ptr es:[bx+0D30Ch],0h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],64h
	jl	4E48h

l0800_4E5E:
	mov	word ptr [bp-2h],0h

l0800_4E63:
	mov	bx,[bp-2h]
	mov	es,[53EAh]
	mov	byte ptr es:[bx+45DEh],0h
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],21h
	jl	4E63h

l0800_4E79:
	mov	es,[538Ah]
	mov	byte ptr es:[0C614h],0h
	mov	byte ptr es:[0C620h],8h
	mov	word ptr es:[0D370h],14h
	mov	word ptr es:[0D372h],0h
	mov	word ptr [bp-2h],0h

l0800_4E9C:
	mov	bx,[bp-2h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[538Ah]
	sub	ax,ax
	mov	es:[bx+0D376h],ax
	mov	es:[bx+0D374h],ax
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],3h
	jl	4E9Ch

l0800_4EBC:
	mov	byte ptr es:[0D456h],1h
	mov	[bp-2h],ax

l0800_4EC5:
	mov	bx,[bp-2h]
	mov	cl,4h
	shl	bx,cl
	mov	es,[538Ah]
	or	byte ptr es:[bx+0D138h],1Fh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],6h
	jl	4EC5h

l0800_4EDF:
	mov	byte ptr es:[0C615h],8h
	mov	byte ptr es:[0C623h],50h
	mov	byte ptr es:[0C616h],9h
	mov	byte ptr es:[0C617h],7h
	mov	byte ptr es:[0C61Fh],0h
	sub	al,al
	mov	es:[0C624h],al
	mov	es:[0C622h],al
	mov	es:[fn0800_4621],al
	mov	es,[539Ch]
	mov	byte ptr es:[0D562h],96h
	mov	word ptr [bp-2h],10h

l0800_4F1A:
	mov	bx,[bp-2h]
	mov	es,[539Ch]
	mov	byte ptr es:[bx+0D55Eh],0FEh
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],18h
	jl	4F1Ah

l0800_4F30:
	mov	word ptr [bp-2h],0h
	jmp	4F5Fh

l0800_4F37:
	add	word ptr [bp-6h],0Ch

l0800_4F3B:
	cmp	word ptr [bp-6h],0Dh
	jge	4F5Ch

l0800_4F41:
	call	far 207Fh:0BC0h
	test	al,1h
	jz	4F37h

l0800_4F4A:
	mov	bx,[bp-2h]
	add	bx,[bp-6h]
	mov	es,[539Ch]
	mov	byte ptr es:[bx+0D55Eh],92h
	jmp	4F37h

l0800_4F5C:
	inc	word ptr [bp-2h]

l0800_4F5F:
	cmp	word ptr [bp-2h],4h
	jge	4F6Ch

l0800_4F65:
	mov	word ptr [bp-6h],0h
	jmp	4F3Bh

l0800_4F6C:
	mov	es,[538Ah]
	mov	byte ptr es:[0D33Fh],32h
	mov	byte ptr es:[0D340h],0h
	sub	al,al
	mov	es:[0D451h],al
	mov	es:[0D450h],al
	mov	es:[0D557h],al
	mov	word ptr [bp-2h],0h

l0800_4F8F:
	sub	al,al
	mov	bx,[bp-2h]
	mov	es,[538Ah]
	mov	es:[bx+0D517h],al
	mov	bx,[bp-2h]
	mov	es:[bx+0D4D7h],al
	mov	bx,[bp-2h]
	mov	es:[bx+0D497h],al
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],40h
	jl	4F8Fh

l0800_4FB6:
	call	far 207Fh:1FBEh
	mov	ax,1h
	push	ax
	push	cs
	call	4CACh
	add	sp,2h
	call	far 1E56h:0388h
	mov	es,[538Ch]
	mov	word ptr es:[0A44Bh],0C45h
	mov	es,[538Eh]
	mov	word ptr es:[0A44Dh],0C019h
	mov	ax,0CCh
	push	ax
	call	far 207Fh:104Eh
	add	sp,2h
	mov	ax,1h
	push	ax
	mov	ax,4h
	push	ax
	push	cs
	call	2DA8h
	add	sp,4h
	call	far 207Fh:1DA8h
	mov	es,[538Eh]
	push	word ptr es:[0A44Dh]
	mov	es,[538Ch]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	mov	word ptr [bp-4h],0h

l0800_5025:
	sub	al,al
	mov	bx,[bp-4h]
	mov	es,[539Ah]
	mov	es:[bx+40A6h],al
	mov	bx,[bp-4h]
	mov	es:[bx+409Ah],al
	mov	al,0FFh
	mov	bx,[bp-4h]
	mov	es,[53BEh]
	mov	es:[bx+3978h],al
	mov	bx,[bp-4h]
	mov	es:[bx+396Ch],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],4h
	jl	5025h

l0800_505A:
	mov	word ptr [bp-4h],4h

l0800_505F:
	mov	al,10h
	mov	bx,[bp-4h]
	mov	es,[539Ah]
	mov	es:[bx+40A6h],al
	mov	bx,[bp-4h]
	mov	es:[bx+409Ah],al
	mov	al,0FFh
	mov	bx,[bp-4h]
	mov	es,[53BEh]
	mov	es:[bx+3978h],al
	mov	bx,[bp-4h]
	mov	es:[bx+396Ch],al
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],0Ch
	jl	505Fh

l0800_5094:
	push	cs
	call	051Bh
	sub	al,al
	mov	es,[53D0h]
	mov	es:[0064h],al
	cbw
	mov	[01A8h],ax
	mov	es,[53B0h]
	mov	es:[398Eh],ax
	mov	es,[53ECh]
	mov	es:[374Ah],ax
	mov	al,1h
	mov	es,[53D0h]
	mov	es:[00FCh],al
	cbw
	mov	[014Ah],ax
	mov	sp,bp
	pop	bp
	retf

;; fn0800_50C8: 0800:50C8
;;   Called from:
;;     0D27:0834 (in main)
fn0800_50C8 proc
	push	bp
	mov	bp,sp
	mov	ax,32h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-16h],0h

l0800_50D8:
	call	far 207Fh:0BC0h
	mov	bx,[bp-16h]
	mov	es,[5400h]
	mov	es:[bx+9FBh],al
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],100h
	jl	50D8h

l0800_50F3:
	mov	es,[53E8h]
	mov	word ptr es:[4FBCh],0h
	mov	ax,130h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	es,[53E8h]
	mov	ax,1h
	mov	[bp-2h],ax
	mov	[bp-1Ah],ax
	mov	es:[4FBCh],ax
	push	cs
	call	320Bh
	jmp	5269h

l0800_5126:
	mov	es,[5384h]
	mov	word ptr es:[3938h],0h
	call	far 1F3Dh:002Fh
	or	ax,ax
	jnz	513Dh

l0800_513A:
	jmp	51F9h

l0800_513D:
	push	cs
	call	2A2Bh
	push	cs
	call	4DC7h
	mov	es,[5402h]
	cmp	word ptr es:[458Ch],0h
	jz	5154h

l0800_5151:
	jmp	51E0h

l0800_5154:
	mov	ax,6h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	ax,0B0Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0B4Ch
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0B90h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0BE2h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0C0Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	or	ax,ax
	jnz	51E0h

l0800_51C0:
	mov	ax,0C39h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	push	cs
	call	1A13h
	add	sp,2h
	or	ax,ax
	jz	51E0h

l0800_51DC:
	push	cs
	call	32B3h

l0800_51E0:
	sub	ax,ax
	push	ax
	push	cs
	call	0000h
	add	sp,2h
	mov	es,[5402h]
	sub	ax,ax
	mov	es:[458Ch],ax
	mov	[bp-2h],ax
	jmp	525Fh

l0800_51F9:
	mov	ax,2h
	push	ax
	push	cs
	call	28CCh
	add	sp,2h
	mov	ax,3FFh
	push	ax
	mov	ax,27B0h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,0C98h
	push	ds
	push	ax
	call	far 1F3Dh:0814h
	add	sp,0Ah
	mov	es,[5404h]
	mov	word ptr es:[39F8h],2710h
	mov	es,[5406h]
	mov	word ptr es:[4FC0h],1325h
	mov	word ptr es:[4FC2h],90h
	mov	es,[53D2h]
	mov	word ptr es:[3988h],0FFFFh
	mov	es,[5384h]
	mov	word ptr es:[3938h],1h
	push	cs
	call	4DC7h
	mov	ax,1h
	push	ax
	push	cs
	call	0000h
	add	sp,2h

l0800_525F:
	cmp	word ptr [bp-2h],0h
	jz	526Dh

l0800_5265:
	push	cs
	call	46A7h

l0800_5269:
	push	cs
	call	476Dh

l0800_526D:
	cmp	word ptr [bp-2h],0h
