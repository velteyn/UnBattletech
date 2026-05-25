;;; Segment 1631 (1631:0000)
1631:0000 F4 5E 8B E5 5D CB                               .^..].          

;; fn1631_0006: 1631:0006
;;   Called from:
;;     0800:2701 (in fn0800_24C2)
;;     183B:1AD5 (in fn183B_193B)
;;     183B:2A2C (in fn183B_28DB)
fn1631_0006 proc
	push	bp
	mov	bp,sp
	mov	ax,1Ch
	call	far 207Fh:2FDCh
	push	di
	push	si
	cmp	word ptr [bp+10h],0h
	jz	002Ch

l1631_0019:
	dec	word ptr [315Ah]
	jnz	0032h

l1631_001F:
	mov	word ptr [315Ah],1Eh
	xor	byte ptr [315Ch],8h
	jmp	0032h

l1631_002C:
	mov	word ptr [315Ch],0h

l1631_0032:
	mov	bx,[bp+6h]
	and	bx,7Fh
	mov	es,[5578h]
	mov	al,es:[bx+3920h]
	cbw
	mov	[bp-10h],ax
	mov	es,[557Ah]
	sub	ax,ax
	mov	[bp-18h],ax
	mov	es:[4590h],ax
	mov	es,[557Ch]
	mov	es:[458Eh],ax
	mov	al,[bp+6h]
	and	al,7Fh
	cmp	al,4h
	jc	006Fh

l1631_0063:
	cmp	word ptr [bp+6h],0Ch
	jl	0074h

l1631_0069:
	cmp	word ptr [bp+6h],10h
	jge	0074h

l1631_006F:
	mov	word ptr [bp-18h],1h

l1631_0074:
	push	word ptr [bp+0Ah]
	push	word ptr [bp+8h]
	mov	es,[557Eh]
	push	word ptr es:[0E488h]
	mov	es,[5580h]
	push	word ptr es:[0E486h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	[bp-4h],ax
	inc	ax
	jnz	009Dh

l1631_009A:
	jmp	02DEh

l1631_009D:
	mov	ax,[bp-4h]
	sub	ax,[bp-10h]
	mov	[bp-16h],ax
	or	ax,ax
	jz	00C0h

l1631_00AA:
	and	word ptr [bp-16h],7h
	cmp	word ptr [bp-16h],5h
	jge	00B9h

l1631_00B4:
	inc	word ptr [bp-10h]
	jmp	00BCh

l1631_00B9:
	dec	word ptr [bp-10h]

l1631_00BC:
	and	word ptr [bp-10h],7h

l1631_00C0:
	mov	word ptr [bp-14h],7h
	jmp	01D6h

l1631_00C8:
	inc	word ptr [bp-0Eh]

l1631_00CB:
	mov	es,[5586h]
	mov	bx,es:[09EDh]
	add	bx,[bp-0Eh]
	mov	es,[5588h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	es,[558Ah]
	cmp	ax,es:[0150h]
	jc	00F2h

l1631_00ED:
	mov	word ptr [bp-0Ch],0h

l1631_00F2:
	cmp	word ptr [bp-0Ch],0h
	jnz	00FBh

l1631_00F8:
	jmp	0185h

l1631_00FB:
	cmp	word ptr [bp+6h],80h
	jl	0105h

l1631_0102:
	jmp	0185h

l1631_0105:
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	[bp-1Ah],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	[bp-1Ch],ax
	mov	es,[5582h]
	mov	ax,[bp-2h]
	mov	es:[0A44Bh],ax
	mov	es,[5584h]
	mov	ax,[bp-6h]
	mov	es:[0A44Dh],ax
	mov	si,[bp-10h]
	shl	si,1h
	sub	ax,ax
	push	ax
	push	word ptr [si+312Ah]
	push	word ptr [si+311Ah]
	push	word ptr [bp+6h]
	push	cs
	call	16ABh
	add	sp,8h
	or	ax,ax
	jz	016Fh

l1631_014F:
	mov	word ptr [bp-0Ch],0h
	mov	ax,[bp+8h]
	cmp	[bp-2h],ax
	jnz	016Fh

l1631_015C:
	mov	ax,[bp+0Ah]
	cmp	[bp-6h],ax
	jnz	016Fh

l1631_0164:
	mov	es,[558Ch]
	mov	word ptr es:[0D57Eh],1h

l1631_016F:
	mov	es,[5582h]
	mov	ax,[bp-1Ah]
	mov	es:[0A44Bh],ax
	mov	es,[5584h]
	mov	ax,[bp-1Ch]
	mov	es:[0A44Dh],ax

l1631_0185:
	cmp	word ptr [bp-0Ch],0h
	jz	01D3h

l1631_018B:
	mov	es,[5580h]
	mov	ax,[bp-2h]
	mov	es:[0E486h],ax
	mov	es,[557Eh]
	mov	ax,[bp-6h]
	mov	es:[0E488h],ax
	mov	al,[bp-10h]
	mov	bx,[bp+6h]
	and	bx,7Fh
	mov	es,[5578h]
	mov	es:[bx+3920h],al
	mov	si,[bp-10h]
	shl	si,1h
	mov	es,[557Ch]
	mov	ax,[si+311Ah]
	mov	es:[458Eh],ax
	mov	es,[557Ah]
	mov	ax,[si+312Ah]
	mov	es:[4590h],ax
	jmp	02DEh

l1631_01D3:
	dec	word ptr [bp-14h]

l1631_01D6:
	cmp	word ptr [bp-14h],0FFh
	jg	01DFh

l1631_01DC:
	jmp	02DEh

l1631_01DF:
	mov	di,[bp-14h]
	mov	bx,[315Ch]
	mov	al,[bx+di+310Ah]
	cbw
	add	ax,[bp-10h]
	and	ax,7h
	mov	[bp-10h],ax
	mov	si,ax
	shl	si,1h
	mov	ax,[si+311Ah]
	mov	es,[5580h]
	add	ax,es:[0E486h]
	mov	[bp-2h],ax
	test	byte ptr [bp-2h],80h
	jz	0215h

l1631_020E:
	mov	ax,[si+313Ah]
	add	[bp-2h],ax

l1631_0215:
	mov	si,[bp-10h]
	shl	si,1h
	mov	ax,[si+312Ah]
	mov	es,[557Eh]
	add	ax,es:[0E488h]
	mov	[bp-6h],ax
	test	byte ptr [bp-6h],80h
	jz	0237h

l1631_0230:
	mov	ax,[si+314Ah]
	add	[bp-6h],ax

l1631_0237:
	mov	si,[bp-10h]
	shl	si,1h
	mov	ax,[si+311Ah]
	add	ax,[bp+0Ch]
	mov	[bp-8h],ax
	mov	ax,[si+312Ah]
	add	ax,[bp+0Eh]
	mov	[bp-0Ah],ax
	sar	ax,1h
	mov	cx,18h
	imul	cx
	mov	cx,[bp-8h]
	sub	cx,0Dh
	sar	cx,1h
	add	ax,cx
	mov	[bp-0Eh],ax
	test	byte ptr [bp-8h],1h
	jnz	0279h

l1631_026A:
	mov	es,[5582h]
	test	byte ptr es:[0A44Bh],1h
	jz	0279h

l1631_0276:
	inc	word ptr [bp-0Eh]

l1631_0279:
	test	byte ptr [bp-0Ah],1h
	jz	028Fh

l1631_027F:
	mov	es,[5584h]
	test	byte ptr es:[0A44Dh],1h
	jz	028Fh

l1631_028B:
	add	word ptr [bp-0Eh],18h

l1631_028F:
	mov	es,[5586h]
	mov	bx,es:[09EDh]
	add	bx,[bp-0Eh]
	mov	es,[5588h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-12h],ax
	mov	es,[558Ah]
	cmp	es:[0150h],ax
	jg	02B7h

l1631_02B4:
	jmp	01D3h

l1631_02B7:
	mov	word ptr [bp-0Ch],1h
	cmp	word ptr [bp-18h],0h
	jnz	02C5h

l1631_02C2:
	jmp	00F2h

l1631_02C5:
	mov	al,[bp-8h]
	mov	es,[5582h]
	xor	al,es:[0A44Bh]
	test	al,1h
	jnz	02D8h

l1631_02D5:
	jmp	00C8h

l1631_02D8:
	dec	word ptr [bp-0Eh]
	jmp	00CBh

l1631_02DE:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1631_02E4: 1631:02E4
;;   Called from:
;;     0800:3981 (in fn0800_378D)
;;     0DAB:1540 (in fn0DAB_1467)
;;     0DAB:19E0 (in fn0DAB_18E8)
fn1631_02E4 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[558Eh]
	mov	al,es:[si+0C615h]
	cbw
	mov	[bp-4h],ax
	mov	al,es:[si+0C623h]
	cbw
	mov	[bp-2h],ax
	cwd
	mov	cx,[bp-4h]
	idiv	cx
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+2E0Eh]
	push	word ptr [bx+2E0Ch]
	call	far 1E56h:03F5h
	add	sp,4h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_032F: 1631:032F
;;   Called from:
;;     0800:35B0 (in fn0800_32B3)
;;     0800:376E (in fn0800_35D3)
;;     0DAB:16CE (in fn0DAB_1467)
;;     0DAB:1733 (in fn0DAB_1467)
fn1631_032F proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[5584h]
	push	word ptr es:[0A44Dh]
	mov	es,[5582h]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	cmp	word ptr [bp+6h],0h
	jz	0365h

l1631_035E:
	call	far 0800h:0E4Bh
	jmp	036Ah

l1631_0365:
	call	far 0800h:051Bh

l1631_036A:
	call	far 1F3Dh:06C3h
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,4h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	mov	ax,3h
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	pop	bp
	retf

;; fn1631_03AB: 1631:03AB
;;   Called from:
;;     183B:07C6 (in fn183B_000A)
;;     183B:14AD (in fn183B_1482)
;;     183B:156D (in fn183B_14C3)
;;     183B:16C9 (in fn183B_14C3)
fn1631_03AB proc
	push	bp
	mov	bp,sp
	mov	ax,3Ah
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	[bp-14h],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	[bp-18h],ax
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[5590h]
	push	word ptr es:[si+4036h]
	mov	es,[5592h]
	push	word ptr es:[si+4004h]
	call	far 0800h:17BBh
	add	sp,4h
	mov	word ptr [bp-0Eh],0h

l1631_03F2:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[5594h]
	mov	byte ptr es:[bx+32C6h],0FFh
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],30h
	jl	03F2h

l1631_0410:
	mov	word ptr [bp-36h],0h
	cmp	word ptr [bp+6h],0Ch
	jl	0426h

l1631_041B:
	sub	word ptr [bp+6h],0Ch
	mov	word ptr [bp-36h],4h
	jmp	0433h

l1631_0426:
	mov	bx,[bp+6h]
	mov	es,[5596h]
	mov	byte ptr es:[bx+3994h],1h

l1631_0433:
	mov	word ptr [bp-1Ah],1h
	cmp	word ptr [bp+6h],4h
	jge	0450h

l1631_043E:
	mov	bx,[bp+6h]
	add	bx,[bp-36h]
	mov	es,[5598h]
	cmp	byte ptr es:[bx+6Eh],0h
	jz	0455h

l1631_0450:
	mov	word ptr [bp-1Ah],0h

l1631_0455:
	cmp	word ptr [bp+6h],4h
	jge	046Fh

l1631_045B:
	push	word ptr [bp-1Ah]
	mov	ax,[bp+6h]
	add	ax,[bp-36h]
	push	ax
	call	far 183Bh:22BCh
	add	sp,4h
	jmp	047Eh

l1631_046F:
	mov	ax,[bp+6h]
	add	ax,[bp-36h]
	push	ax
	call	far 183Bh:2474h
	add	sp,2h

l1631_047E:
	mov	word ptr [bp-22h],4h
	mov	word ptr [bp-34h],0Ch
	mov	ax,0FFFFh
	mov	[bp-4h],ax
	mov	[bp-2h],ax
	mov	word ptr [bp-0Ah],7FFFh
	cmp	word ptr [bp-36h],0h
	jz	04A1h

l1631_049C:
	mov	word ptr [bp-34h],0h

l1631_04A1:
	mov	word ptr [bp-12h],17h
	cmp	word ptr [bp+6h],4h
	jge	04AFh

l1631_04AC:
	jmp	0594h

l1631_04AF:
	mov	word ptr [bp-22h],8h
	mov	word ptr [bp-34h],10h
	cmp	word ptr [bp-36h],0h
	jnz	04C2h

l1631_04BF:
	jmp	0594h

l1631_04C2:
	mov	word ptr [bp-34h],4h
	jmp	0594h

l1631_04CA:
	mov	si,[bp-34h]
	shl	si,1h
	mov	es,[559Ah]
	cmp	word ptr es:[si+406Ah],0h
	jnz	04DEh

l1631_04DB:
	jmp	0570h

l1631_04DE:
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	[bp-8h],ax
	mov	es,[5590h]
	mov	ax,es:[si+4036h]
	mov	[bp-0Ch],ax
	mov	word ptr [bp-38h],1h
	mov	es,[559Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	0512h

l1631_0507:
	cmp	word ptr [bp-34h],0Dh
	jnz	0512h

l1631_050D:
	mov	word ptr [bp-38h],0h

l1631_0512:
	cmp	word ptr [bp-36h],0h
	jz	0536h

l1631_0518:
	mov	es,[558Eh]
	cmp	byte ptr es:[0D333h],0h
	jz	0536h

l1631_0524:
	mov	al,es:[0D331h]
	cbw
	add	ax,4h
	cmp	ax,[bp-34h]
	jnz	0536h

l1631_0531:
	mov	word ptr [bp-38h],0h

l1631_0536:
	cmp	word ptr [bp-38h],0h
	jz	0570h

l1631_053C:
	push	word ptr [bp-0Ch]
	push	word ptr [bp-8h]
	push	cs
	call	0BB5h
	add	sp,4h
	cmp	ax,[bp-0Ah]
	jge	0570h

l1631_054E:
	push	word ptr [bp-0Ch]
	push	word ptr [bp-8h]
	push	cs
	call	0BB5h
	add	sp,4h
	mov	[bp-0Ah],ax
	mov	ax,[bp-8h]
	mov	[bp-2h],ax
	mov	ax,[bp-0Ch]
	mov	[bp-4h],ax
	mov	ax,[bp-34h]
	mov	[bp-12h],ax

l1631_0570:
	inc	word ptr [bp-34h]
	cmp	word ptr [bp-22h],0h
	jnz	0594h

l1631_0579:
	cmp	word ptr [bp-2h],0FFh
	jnz	0594h

l1631_057F:
	cmp	word ptr [bp-34h],0Ch
	jz	058Bh

l1631_0585:
	cmp	word ptr [bp-34h],18h
	jnz	058Fh

l1631_058B:
	sub	word ptr [bp-34h],0Ch

l1631_058F:
	mov	word ptr [bp-22h],8h

l1631_0594:
	mov	ax,[bp-22h]
	dec	word ptr [bp-22h]
	or	ax,ax
	jz	05A1h

l1631_059E:
	jmp	04CAh

l1631_05A1:
	cmp	word ptr [bp-36h],0h
	jz	05ABh

l1631_05A7:
	add	word ptr [bp+6h],0Ch

l1631_05AB:
	cmp	word ptr [bp+6h],10h
	jge	05BDh

l1631_05B1:
	cmp	word ptr [bp+6h],4h
	jl	05FCh

l1631_05B7:
	cmp	word ptr [bp+6h],0Ch
	jge	05FCh

l1631_05BD:
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[558Eh]
	mov	al,es:[si+0C5DBh]
	cbw
	mov	[bp-1Ch],ax
	cmp	word ptr [bp+6h],10h
	jl	05E1h

l1631_05D8:
	mov	al,es:[si+0C597h]
	cbw
	mov	[bp-1Ch],ax

l1631_05E1:
	mov	ax,11h
	imul	word ptr [bp-1Ch]
	mov	bx,ax
	mov	al,[bx+2EE6h]
	sub	ah,ah
	mov	cl,5h
	shr	ax,cl
	and	ax,7h
	mov	[bp-2Ch],ax
	jmp	0688h

l1631_05FC:
	mov	word ptr [bp-1Ch],20h
	mov	word ptr [bp-2Ch],0FFh
	mov	ax,[bp+6h]
	mov	[bp-2Eh],ax
	cmp	word ptr [bp-36h],0h
	jz	0618h

l1631_0612:
	sub	ax,8h
	mov	[bp-2Eh],ax

l1631_0618:
	mov	word ptr [bp-0Eh],33h

l1631_061D:
	mov	ax,7Dh
	imul	word ptr [bp-2Eh]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[558Eh]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	mov	[bp-3Ah],ax
	or	ax,ax
	jz	066Ch

l1631_063A:
	test	byte ptr [bp-3Ah],80h
	jnz	066Ch

l1631_0640:
	cmp	ax,10h
	jl	066Ch

l1631_0645:
	cmp	ax,20h
	jg	066Ch

l1631_064A:
	mov	ax,11h
	imul	word ptr [bp-3Ah]
	mov	bx,ax
	mov	al,[bx+2EE6h]
	sub	ah,ah
	and	ax,0E0h
	mov	[bp-6h],ax
	mov	ax,[bp-2Ch]
	cmp	[bp-6h],ax
	jge	066Ch

l1631_0666:
	mov	ax,[bp-6h]
	mov	[bp-2Ch],ax

l1631_066C:
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],55h
	jle	061Dh

l1631_0675:
	cmp	word ptr [bp-2Ch],0FFh
	jnz	0683h

l1631_067C:
	mov	word ptr [bp-2Ch],0h
	jmp	0688h

l1631_0683:
	mov	cl,3h
	sar	word ptr [bp-2Ch],cl

l1631_0688:
	mov	si,[bp-12h]
	shl	si,1h
	mov	es,[5590h]
	push	word ptr es:[si+4036h]
	mov	es,[5592h]
	push	word ptr es:[si+4004h]
	push	word ptr [bp-12h]
	push	word ptr [bp+6h]
	push	cs
	call	1BFEh
	add	sp,8h
	mov	[bp-32h],ax
	cmp	word ptr [bp+6h],10h
	jge	06C7h

l1631_06B5:
	cmp	word ptr [bp+6h],4h
	jge	06BEh

l1631_06BB:
	jmp	0797h

l1631_06BE:
	cmp	word ptr [bp+6h],0Ch
	jl	06C7h

l1631_06C4:
	jmp	0797h

l1631_06C7:
	cmp	word ptr [bp-12h],4h
	jl	06DFh

l1631_06CD:
	cmp	word ptr [bp-12h],0Ch
	jge	06D6h

l1631_06D3:
	jmp	0797h

l1631_06D6:
	cmp	word ptr [bp-12h],10h
	jl	06DFh

l1631_06DC:
	jmp	0797h

l1631_06DF:
	cmp	word ptr [bp+6h],0Ch
	jge	06EAh

l1631_06E5:
	mov	ax,1h
	jmp	06ECh

l1631_06EA:
	sub	ax,ax

l1631_06EC:
	mov	es,[559Eh]
	mov	es:[3992h],ax
	cmp	word ptr [bp+6h],10h
	jl	0705h

l1631_06FA:
	mov	es,[55A0h]
	mov	word ptr es:[374Ch],1h

l1631_0705:
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	[bp-1Eh],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	[bp-26h],ax
	mov	ax,[bp-2h]
	cmp	[bp-1Eh],ax
	jbe	0739h

l1631_0723:
	mov	ax,[bp-1Eh]
	add	ax,6h
	mov	[bp-2h],ax
	test	byte ptr [bp-2h],80h
	jz	0755h

l1631_0732:
	add	word ptr [bp-2h],80h
	jmp	0755h

l1631_0739:
	mov	ax,[bp-2h]
	cmp	[bp-1Eh],ax
	jnc	0755h

l1631_0741:
	mov	ax,[bp-1Eh]
	sub	ax,6h
	mov	[bp-2h],ax
	test	byte ptr [bp-2h],80h
	jz	0755h

l1631_0750:
	and	word ptr [bp-2h],0F7Fh

l1631_0755:
	mov	ax,[bp-4h]
	cmp	[bp-26h],ax
	jbe	0773h

l1631_075D:
	mov	ax,[bp-26h]
	add	ax,6h
	mov	[bp-4h],ax
	test	byte ptr [bp-4h],80h
	jz	078Fh

l1631_076C:
	add	word ptr [bp-4h],0F80h
	jmp	078Fh

l1631_0773:
	mov	ax,[bp-4h]
	cmp	[bp-26h],ax
	jnc	078Fh

l1631_077B:
	mov	ax,[bp-26h]
	sub	ax,6h
	mov	[bp-4h],ax
	test	byte ptr [bp-4h],80h
	jz	078Fh

l1631_078A:
	and	word ptr [bp-4h],0F07Fh

l1631_078F:
	sub	ax,ax
	mov	[bp-32h],ax
	mov	[bp-2Ch],ax

l1631_0797:
	cmp	word ptr [bp-2Ch],0h
	jz	07A3h

l1631_079D:
	cmp	word ptr [bp-32h],0h
	jnz	07EBh

l1631_07A3:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	al,[bp-1Ah]
	mov	es,[5594h]
	mov	es:[si+32C6h],al
	mov	ax,[bp-2h]
	and	ax,0F00h
	mov	cx,[bp-4h]
	and	cx,0F000h
	or	ax,cx
	mov	cl,8h
	shr	ax,cl
	mov	[bp-24h],ax
	and	word ptr [bp-2h],7Fh
	and	word ptr [bp-4h],7Fh
	mov	al,[bp-24h]
	mov	es:[si+32C7h],al
	mov	al,[bp-2h]
	mov	es:[si+32C8h],al
	mov	al,[bp-4h]
	jmp	08F4h

l1631_07EB:
	mov	ax,[bp-2Ch]
	cmp	[bp-0Ah],ax
	jg	07F6h

l1631_07F3:
	jmp	08F9h

l1631_07F6:
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	[bp-1Eh],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	[bp-26h],ax
	sub	ax,ax
	mov	[bp-16h],ax
	mov	[bp-10h],ax
	mov	es,[5582h]
	mov	ax,[bp-2h]
	cmp	es:[0A44Bh],ax
	jbe	0829h

l1631_0822:
	mov	word ptr [bp-10h],0FFFFh
	jmp	0838h

l1631_0829:
	mov	ax,[bp-2h]
	cmp	es:[0A44Bh],ax
	jnc	0838h

l1631_0833:
	mov	word ptr [bp-10h],1h

l1631_0838:
	mov	es,[5584h]
	mov	ax,[bp-4h]
	cmp	es:[0A44Dh],ax
	jbe	084Dh

l1631_0846:
	mov	word ptr [bp-16h],0FFFFh
	jmp	08A4h

l1631_084D:
	mov	ax,[bp-4h]
	cmp	es:[0A44Dh],ax
	jnc	08A4h

l1631_0857:
	mov	word ptr [bp-16h],1h
	jmp	08A4h

l1631_085E:
	mov	ax,[bp-10h]
	add	[bp-1Eh],ax
	test	byte ptr [bp-1Eh],80h
	jz	0881h

l1631_086A:
	cmp	ax,0FFFFh
	jnz	0876h

l1631_086F:
	and	word ptr [bp-1Eh],0F7Fh
	jmp	0881h

l1631_0876:
	cmp	word ptr [bp-10h],1h
	jnz	0881h

l1631_087C:
	add	word ptr [bp-1Eh],80h

l1631_0881:
	mov	ax,[bp-16h]
	add	[bp-26h],ax
	test	byte ptr [bp-26h],80h
	jz	08A4h

l1631_088D:
	cmp	ax,0FFFFh
	jnz	0899h

l1631_0892:
	and	word ptr [bp-26h],0F07Fh
	jmp	08A4h

l1631_0899:
	cmp	word ptr [bp-16h],1h
	jnz	08A4h

l1631_089F:
	add	word ptr [bp-26h],0F80h

l1631_08A4:
	mov	ax,[bp-0Ah]
	dec	word ptr [bp-0Ah]
	cmp	ax,[bp-2Ch]
	jg	085Eh

l1631_08AF:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	al,[bp-1Ah]
	mov	es,[5594h]
	mov	es:[si+32C6h],al
	mov	ax,[bp-1Eh]
	and	ax,0F00h
	mov	cx,[bp-26h]
	and	cx,0F000h
	or	ax,cx
	mov	cl,8h
	shr	ax,cl
	mov	[bp-24h],ax
	and	word ptr [bp-1Eh],7Fh
	and	word ptr [bp-26h],7Fh
	mov	al,[bp-24h]
	mov	es:[si+32C7h],al
	mov	al,[bp-1Eh]
	mov	es:[si+32C8h],al
	mov	al,[bp-26h]

l1631_08F4:
	mov	es:[si+32C9h],al

l1631_08F9:
	cmp	word ptr [bp+6h],4h
	jl	0905h

l1631_08FF:
	cmp	word ptr [bp+6h],0Ch
	jl	090Bh

l1631_0905:
	cmp	word ptr [bp+6h],10h
	jl	0955h

l1631_090B:
	mov	al,[bp-12h]
	mov	cx,ax
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55A2h]
	mov	es:[bx+3800h],cl
	mov	es,[558Eh]
	cmp	byte ptr es:[0D333h],0h
	jnz	0930h

l1631_092D:
	jmp	0B7Bh

l1631_0930:
	mov	al,es:[0D331h]
	cbw
	add	ax,4h
	cmp	ax,[bp+6h]
	jz	0940h

l1631_093D:
	jmp	0B7Bh

l1631_0940:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55A2h]
	mov	byte ptr es:[bx+3800h],0FFh
	jmp	0B7Bh

l1631_0955:
	cmp	word ptr [bp+6h],4h
	jge	0961h

l1631_095B:
	cmp	word ptr [bp-12h],10h
	jl	097Ch

l1631_0961:
	cmp	word ptr [bp+6h],0Ch
	jge	096Ah

l1631_0967:
	jmp	0AA0h

l1631_096A:
	cmp	word ptr [bp+6h],10h
	jl	0973h

l1631_0970:
	jmp	0AA0h

l1631_0973:
	cmp	word ptr [bp-12h],4h
	jl	097Ch

l1631_0979:
	jmp	0AA0h

l1631_097C:
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	[bp-20h],ax
	mov	es,[5590h]
	mov	ax,es:[si+4036h]
	mov	[bp-2Ah],ax
	mov	ax,[bp-20h]
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp-20h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-20h],ax
	mov	ax,[bp-2Ah]
	and	ax,0F000h
	mov	cl,5h
	shr	ax,cl
	mov	cx,[bp-2Ah]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-2Ah],ax
	inc	word ptr [bp-20h]
	mov	si,[bp-12h]
	shl	si,1h
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	[bp-28h],ax
	mov	es,[5590h]
	mov	ax,es:[si+4036h]
	mov	[bp-30h],ax
	mov	ax,[bp-28h]
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp-28h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-28h],ax
	mov	ax,[bp-30h]
	and	ax,0F000h
	mov	cl,5h
	shr	ax,cl
	mov	cx,[bp-30h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-30h],ax
	inc	word ptr [bp-28h]
	cmp	word ptr [bp-32h],0h
	jnz	0A15h

l1631_0A12:
	jmp	0AA0h

l1631_0A15:
	mov	ax,[bp-28h]
	sub	ax,[bp-20h]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,3h
	jg	0AA0h

l1631_0A29:
	mov	ax,[bp-30h]
	sub	ax,[bp-2Ah]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,2h
	jge	0AA0h

l1631_0A3D:
	mov	al,0FFh
	mov	bx,[bp+6h]
	mov	es,[55A4h]
	mov	es:[bx+396Ch],al
	mov	cx,ax
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5594h]
	mov	es:[bx+32C6h],cl
	mov	si,[bp+6h]
	shl	si,1h
	mov	di,[bp-12h]
	shl	di,1h
	mov	es,[5590h]
	push	word ptr es:[di+4036h]
	mov	es,[5592h]
	push	word ptr es:[di+4004h]
	mov	es,[5590h]
	push	word ptr es:[si+4036h]
	mov	es,[5592h]
	push	word ptr es:[si+4004h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	bx,[bp+6h]
	mov	es,[5578h]
	mov	es:[bx+3920h],al

l1631_0AA0:
	mov	word ptr [bp-0Eh],0h

l1631_0AA5:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[55A2h]
	mov	byte ptr es:[bx+3800h],0FFh
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0Ch
	jl	0AA5h

l1631_0AC3:
	mov	bx,[bp+6h]
	mov	es,[5598h]
	mov	al,es:[bx+6Eh]
	cbw
	mov	[bp-34h],ax
	cmp	bx,0Ch
	jl	0AE1h

l1631_0AD8:
	mov	al,es:[bx+66h]
	cbw
	mov	[bp-34h],ax

l1631_0AE1:
	cmp	word ptr [bp-34h],1Eh
	jge	0B46h

l1631_0AE7:
	mov	ax,bx
	mov	[bp-2Eh],ax
	cmp	ax,0Ch
	jl	0AF5h

l1631_0AF1:
	sub	word ptr [bp-2Eh],8h

l1631_0AF5:
	mov	word ptr [bp-0Eh],0h

l1631_0AFA:
	push	word ptr [bp-0Eh]
	push	word ptr [bp-2Eh]
	push	cs
	call	10A2h
	add	sp,4h
	cmp	ax,0FFh
	jz	0B25h

l1631_0B0C:
	mov	al,[bp-12h]
	mov	cx,ax
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[55A2h]
	mov	es:[bx+3800h],cl

l1631_0B25:
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0Ah
	jl	0AFAh

l1631_0B2E:
	mov	al,[bp-12h]
	mov	cx,ax
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[55A2h]
	mov	es:[bx+380Bh],cl
	jmp	0B7Bh

l1631_0B46:
	mov	ax,30h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[5594h]
	mov	byte ptr es:[bx+32C6h],0FFh
	mov	word ptr [bp-0Eh],0h

l1631_0B5D:
	mov	ax,0Ch
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp-0Eh]
	mov	es,[55A2h]
	or	byte ptr es:[bx+3800h],80h
	inc	word ptr [bp-0Eh]
	cmp	word ptr [bp-0Eh],0Ch
	jl	0B5Dh

l1631_0B7B:
	push	word ptr [bp+6h]
	call	far 183Bh:193Bh
	add	sp,2h
	cmp	word ptr [bp-36h],0h
	jnz	0BA1h

l1631_0B8C:
	cmp	word ptr [bp+8h],0h
	jz	0BA1h

l1631_0B92:
	mov	ax,1h
	push	ax
	push	word ptr [bp+6h]
	call	far 183Bh:1774h
	add	sp,4h

l1631_0BA1:
	push	word ptr [bp-18h]
	push	word ptr [bp-14h]
	call	far 0800h:17BBh
	add	sp,4h
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1631_0BB5: 1631:0BB5
;;   Called from:
;;     1631:0542 (in fn1631_03AB)
;;     1631:0554 (in fn1631_03AB)
;;     1631:0F65 (in fn1631_0F24)
;;     1631:0FCE (in fn1631_0F24)
;;     183B:0E40 (in fn183B_000A)
fn1631_0BB5 proc
	push	bp
	mov	bp,sp
	mov	ax,0Ah
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp+6h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp+6h],ax
	mov	ax,[bp+8h]
	and	ax,0F000h
	mov	cl,5h
	shr	ax,cl
	mov	cx,[bp+8h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp+8h],ax
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	and	ax,0F00h
	shr	ax,1h
	mov	cx,es:[0A44Bh]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-2h],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	and	ax,0F000h
	mov	cl,5h
	shr	ax,cl
	mov	cx,es:[0A44Dh]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-6h],ax
	mov	ax,[bp-2h]
	sub	ax,[bp+6h]
	mov	[bp-8h],ax
	or	ax,ax
	jge	0C30h

l1631_0C2B:
	neg	ax
	mov	[bp-8h],ax

l1631_0C30:
	mov	ax,[bp-6h]
	sub	ax,[bp+8h]
	mov	[bp-0Ah],ax
	or	ax,ax
	jge	0C42h

l1631_0C3D:
	neg	ax
	mov	[bp-0Ah],ax

l1631_0C42:
	mov	ax,[bp-0Ah]
	cmp	[bp-8h],ax
	jle	0C54h

l1631_0C4A:
	mov	ax,[bp-8h]
	sar	ax,1h
	add	ax,[bp-0Ah]
	jmp	0C5Ch

l1631_0C54:
	mov	ax,[bp-0Ah]
	sar	ax,1h
	add	ax,[bp-8h]

l1631_0C5C:
	mov	[bp-4h],ax
	mov	sp,bp
	pop	bp
	retf

;; fn1631_0C63: 1631:0C63
;;   Called from:
;;     1AE8:12B9 (in fn1AE8_000C)
fn1631_0C63 proc
	push	bp
	mov	bp,sp
	mov	ax,10h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-8h],0h
	jmp	0CC3h

l1631_0C76:
	inc	word ptr [bp-0Ah]

l1631_0C79:
	cmp	word ptr [bp-0Ah],0Ch
	jge	0CC0h

l1631_0C7F:
	mov	ax,0Ch
	imul	word ptr [bp-8h]
	add	ax,[bp-0Ah]
	add	ax,3800h
	mov	[bp-10h],ax
	mov	word ptr [bp-0Eh],3092h
	les	bx,[bp-10h]
	cmp	byte ptr es:[bx],0FFh
	jz	0C76h

l1631_0C9C:
	and	byte ptr es:[bx],7Fh
	les	bx,[bp-10h]
	mov	al,es:[bx]
	cbw
	mov	bx,ax
	shl	bx,1h
	mov	es,[559Ah]
	cmp	word ptr es:[bx+406Ah],0h
	jnz	0C76h

l1631_0CB7:
	les	bx,[bp-10h]
	mov	byte ptr es:[bx],0FFh
	jmp	0C76h

l1631_0CC0:
	inc	word ptr [bp-8h]

l1631_0CC3:
	cmp	word ptr [bp-8h],18h
	jge	0CD0h

l1631_0CC9:
	mov	word ptr [bp-0Ah],0h
	jmp	0C79h

l1631_0CD0:
	mov	word ptr [bp-8h],0h
	jmp	0E97h

l1631_0CD8:
	add	word ptr [bp-0Ah],4h

l1631_0CDC:
	cmp	word ptr [bp-0Ah],5h
	jl	0CE5h

l1631_0CE2:
	jmp	0E94h

l1631_0CE5:
	mov	ax,[bp-8h]
	add	ax,[bp-0Ah]
	mov	cx,7Dh
	imul	cx
	mov	bx,ax
	mov	es,[558Eh]
	cmp	byte ptr es:[bx+0C724h],0FFh
	jnz	0D01h

l1631_0CFE:
	jmp	0E81h

l1631_0D01:
	mov	ax,30h
	imul	word ptr [bp-8h]
	mov	bx,ax
	mov	es,[5594h]
	mov	al,es:[bx+32C6h]
	cbw
	inc	ax
	mov	[bp-4h],ax
	cmp	ax,3h
	jnz	0D30h

l1631_0D1C:
	mov	bx,[bp-8h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	mov	[bp-10h],al
	cmp	al,3h
	jle	0D30h

l1631_0D2C:
	cbw
	mov	[bp-4h],ax

l1631_0D30:
	cmp	word ptr [bp-0Ah],0h
	jz	0D66h

l1631_0D36:
	mov	ax,30h
	imul	word ptr [bp-8h]
	mov	bx,ax
	mov	es,[5594h]
	mov	al,es:[bx+3506h]
	cbw
	inc	ax
	mov	[bp-4h],ax
	cmp	ax,3h
	jnz	0D66h

l1631_0D51:
	mov	si,[bp-8h]
	les	bx,[bp+6h]
	mov	al,es:[bx+si+0Ch]
	mov	[bp-10h],al
	cmp	al,3h
	jle	0D66h

l1631_0D62:
	cbw
	mov	[bp-4h],ax

l1631_0D66:
	mov	ax,[bp-8h]
	add	ax,[bp-0Ah]
	mov	cx,7Dh
	imul	cx
	mov	si,ax
	mov	es,[558Eh]
	mov	al,5h
	mul	byte ptr es:[si+0C799h]
	add	[bp-4h],ax
	mov	al,es:[si+0C74Ah]
	sub	ah,ah
	sub	[bp-4h],ax
	mov	word ptr [bp-0Ch],33h

l1631_0D90:
	mov	ax,[bp-8h]
	add	ax,[bp-0Ah]
	mov	cx,7Dh
	imul	cx
	mov	bx,ax
	add	bx,[bp-0Ch]
	mov	es,[558Eh]
	cmp	byte ptr es:[bx+0C724h],22h
	jnz	0DAFh

l1631_0DAC:
	dec	word ptr [bp-4h]

l1631_0DAF:
	inc	word ptr [bp-0Ch]
	cmp	word ptr [bp-0Ch],55h
	jle	0D90h

l1631_0DB8:
	mov	si,[bp-8h]
	add	si,[bp-0Ah]
	mov	es,[55A6h]
	mov	al,es:[si+92h]
	cbw
	add	[bp-4h],ax
	mov	al,[bp-4h]
	mov	es,[5598h]
	add	es:[si+6Eh],al
	mov	es,[55A8h]
	cmp	byte ptr es:[si+0D576h],0h
	jz	0DF6h

l1631_0DE3:
	mov	es,[5598h]
	add	byte ptr es:[si+6Eh],6h
	mov	es,[55A8h]
	dec	byte ptr es:[si+0D576h]

l1631_0DF6:
	mov	bx,[bp-8h]
	mov	es,[55AAh]
	mov	al,es:[bx+32AEh]
	cbw
	mov	[bp-6h],ax
	mov	es,[55ACh]
	mov	al,es:[bx+3750h]
	sub	ah,ah
	mov	[bp-2h],ax
	cmp	word ptr [bp-0Ah],0h
	jz	0E35h

l1631_0E1A:
	mov	es,[55AAh]
	mov	al,es:[bx+32BAh]
	cbw
	mov	[bp-6h],ax
	mov	es,[55ACh]
	mov	al,es:[bx+375Ch]
	sub	ah,ah
	mov	[bp-2h],ax

l1631_0E35:
	cmp	word ptr [bp-6h],0h
	jz	0E4Eh

l1631_0E3B:
	cmp	word ptr [bp-2h],10h
	jge	0E4Eh

l1631_0E41:
	add	bx,[bp-0Ah]
	mov	es,[5598h]
	sub	byte ptr es:[bx+6Eh],4h

l1631_0E4E:
	mov	ax,[bp-8h]
	add	ax,[bp-0Ah]
	add	ax,6Eh
	mov	[bp-10h],ax
	mov	word ptr [bp-0Eh],3092h
	les	bx,[bp-10h]
	cmp	byte ptr es:[bx],0h
	jge	0E6Ch

l1631_0E68:
	mov	byte ptr es:[bx],0h

l1631_0E6C:
	mov	bx,[bp-8h]
	mov	es,[5598h]
	cmp	byte ptr es:[bx+6Eh],1Eh
	jle	0E81h

l1631_0E7B:
	mov	byte ptr es:[bx+6Eh],1Eh

l1631_0E81:
	mov	bx,[bp-8h]
	add	bx,[bp-0Ah]
	mov	es,[55A6h]
	mov	byte ptr es:[bx+92h],0h
	jmp	0CD8h

l1631_0E94:
	inc	word ptr [bp-8h]

l1631_0E97:
	cmp	word ptr [bp-8h],4h
	jge	0EA5h

l1631_0E9D:
	mov	word ptr [bp-0Ah],0h
	jmp	0CDCh

l1631_0EA5:
	mov	word ptr [bp-8h],0h

l1631_0EAA:
	mov	ax,11h
	imul	word ptr [bp-8h]
	mov	bx,ax
	mov	es,[558Eh]
	cmp	byte ptr es:[bx+0C614h],0FFh
	jnz	0F16h

l1631_0EBE:
	mov	ax,[bp-8h]
	add	ax,4h
	mov	[bp-0Ah],ax
	cmp	ax,0Ch
	jl	0ED0h

l1631_0ECC:
	add	word ptr [bp-0Ah],4h

l1631_0ED0:
	cmp	word ptr [bp-8h],0h
	jz	0EF0h

l1631_0ED6:
	mov	si,[bp-0Ah]
	shl	si,1h
	mov	ax,0FFFFh
	mov	es,[5590h]
	mov	es:[si+4036h],ax
	mov	es,[5592h]
	mov	es:[si+4004h],ax

l1631_0EF0:
	cmp	word ptr [bp-0Ah],10h
	jl	0F03h

l1631_0EF6:
	mov	bx,[bp-0Ah]
	mov	es,[55AEh]
	mov	byte ptr es:[bx+0D55Eh],0FEh

l1631_0F03:
	cmp	word ptr [bp-8h],0h
	jnz	0F16h

l1631_0F09:
	mov	bx,[bp-0Ah]
	mov	es,[55AEh]
	mov	byte ptr es:[bx+0D55Eh],96h

l1631_0F16:
	inc	word ptr [bp-8h]
	cmp	word ptr [bp-8h],10h
	jl	0EAAh

l1631_0F1F:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_0F24: 1631:0F24
;;   Called from:
;;     1543:03BE (in fn1543_0004)
;;     1543:06C0 (in fn1543_0004)
;;     1543:0988 (in fn1543_07CB)
;;     1AE8:010C (in fn1AE8_000C)
fn1631_0F24 proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	push	si
	mov	si,[bp+6h]
	shl	si,1h
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	[bp-0Ah],ax
	mov	es,[5590h]
	mov	ax,es:[si+4036h]
	mov	[bp-0Ch],ax
	cmp	word ptr [bp+6h],4h
	jl	0F5Fh

l1631_0F53:
	cmp	word ptr [bp+6h],0Ch
	jl	0FC8h

l1631_0F59:
	cmp	word ptr [bp+6h],0Fh
	jg	0FC8h

l1631_0F5F:
	push	word ptr [bp-0Ch]
	push	word ptr [bp-0Ah]
	push	cs
	call	0BB5h
	add	sp,4h
	cmp	ax,3h
	jle	0FC8h

l1631_0F71:
	mov	es,[5582h]
	mov	ax,[bp-0Ah]
	cmp	es:[0A44Bh],ax
	jnc	0F8Eh

l1631_0F7F:
	dec	word ptr [bp-0Ah]
	mov	al,[bp-0Ah]
	test	al,80h
	jz	0F8Eh

l1631_0F89:
	and	word ptr [bp-0Ah],0F7Fh

l1631_0F8E:
	mov	es,[5582h]
	mov	ax,[bp-0Ah]
	cmp	es:[0A44Bh],ax
	jbe	0FABh

l1631_0F9C:
	inc	word ptr [bp-0Ah]
	mov	al,[bp-0Ah]
	test	al,80h
	jz	0FABh

l1631_0FA6:
	add	word ptr [bp-0Ah],80h

l1631_0FAB:
	mov	es,[5584h]
	mov	ax,[bp-0Ch]
	cmp	es:[0A44Dh],ax
	jnc	0FC8h

l1631_0FB9:
	sub	word ptr [bp-0Ch],2h
	test	byte ptr [bp-0Ch],80h
	jz	0FC8h

l1631_0FC3:
	and	word ptr [bp-0Ch],0F07Fh

l1631_0FC8:
	push	word ptr [bp-0Ch]
	push	word ptr [bp-0Ah]
	push	cs
	call	0BB5h
	add	sp,4h
	mov	[bp-8h],ax
	mov	word ptr [bp-0Eh],3h
	mov	ax,11h
	imul	word ptr [bp+8h]
	mov	bx,ax
	mov	al,[bx+2EE7h]
	sub	ah,ah
	cmp	ax,[bp-8h]
	jbe	0FF5h

l1631_0FF0:
	mov	word ptr [bp-0Eh],2h

l1631_0FF5:
	mov	ax,11h
	imul	word ptr [bp+8h]
	mov	si,ax
	mov	al,[si+2EE6h]
	sub	ah,ah
	mov	[bp-4h],ax
	and	ax,1Fh
	mov	[bp-2h],ax
	mov	ax,[bp-4h]
	mov	cl,5h
	shr	ax,cl
	mov	[bp-6h],ax
	cmp	byte ptr [si+2EE4h],80h
	jnc	1035h

l1631_101D:
	cmp	word ptr [bp+8h],20h
	jz	1035h

l1631_1023:
	mov	ax,3h
	mul	word ptr [bp-2h]
	mov	[bp-2h],ax
	mov	ax,3h
	mul	word ptr [bp-6h]
	mov	[bp-6h],ax

l1631_1035:
	mov	ax,[bp-2h]
	cmp	[bp-8h],ax
	jnc	1042h

l1631_103D:
	mov	word ptr [bp-0Eh],1h

l1631_1042:
	mov	ax,[bp-6h]
	cmp	[bp-8h],ax
	jnc	104Fh

l1631_104A:
	mov	word ptr [bp-0Eh],0h

l1631_104F:
	mov	ax,[bp-0Eh]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1057: 1631:1057
;;   Called from:
;;     1543:04CD (in fn1543_0004)
fn1631_1057 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	es,[55B0h]
	mov	ax,es:[4600h]
	mov	[bp-2h],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	call	far 1E56h:0388h
	push	word ptr [bp-2h]
	call	far 1E56h:0281h
	mov	sp,bp
	pop	bp
	retf

;; fn1631_10A2: 1631:10A2
;;   Called from:
;;     1631:0B00 (in fn1631_03AB)
;;     1AE8:00C4 (in fn1AE8_000C)
fn1631_10A2 proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-2h],0h
	mov	word ptr [bp-8h],0FFh
	mov	word ptr [bp-4h],33h

l1631_10BE:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-4h]
	add	bx,si
	mov	es,[558Eh]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	mov	di,ax
	and	ax,7Fh
	mov	[bp-6h],ax
	cmp	ax,10h
	jl	1110h

l1631_10E3:
	cmp	ax,20h
	jg	1110h

l1631_10E8:
	mov	ax,[bp-2h]
	inc	word ptr [bp-2h]
	cmp	ax,[bp+8h]
	jnz	1110h

l1631_10F3:
	lea	ax,[di-1h]
	mov	[bp-8h],ax
	mov	bx,[bp+8h]
	add	bx,si
	cmp	byte ptr es:[bx+0C74Bh],0h
	jnz	110Bh

l1631_1106:
	mov	word ptr [bp-8h],0FFh

l1631_110B:
	mov	word ptr [bp-4h],57h

l1631_1110:
	inc	word ptr [bp-4h]
	cmp	word ptr [bp-4h],56h
	jl	10BEh

l1631_1119:
	mov	ax,[bp-8h]
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1122: 1631:1122
;;   Called from:
;;     1AE8:0C98 (in fn1AE8_000C)
fn1631_1122 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	cmp	word ptr [bp+6h],11h
	jc	1144h

l1631_1133:
	cmp	word ptr [bp+6h],18h
	ja	1144h

l1631_1139:
	mov	ax,[bp+6h]
	add	ax,0Bh
	mov	[bp-2h],ax
	jmp	11A4h

l1631_1144:
	mov	ax,[bp+6h]
	sub	ax,19h
	cmp	ax,0Ah
	ja	11A4h

l1631_114F:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+118Eh]

l1631_1157:
	mov	word ptr [bp-2h],12h
	jmp	11A4h

l1631_115E:
	mov	word ptr [bp-2h],17h
	jmp	11A4h

l1631_1165:
	mov	word ptr [bp-2h],15h
	jmp	11A4h

l1631_116C:
	mov	es,[55B2h]
	mov	word ptr es:[0E484h],1h
	jmp	11A4h

l1631_1179:
	mov	word ptr [bp-2h],1Dh
	jmp	11A4h

l1631_1180:
	mov	word ptr [bp-2h],20h
	jmp	11A4h

l1631_1187:
	mov	word ptr [bp-2h],22h
	jmp	11A4h
l1631_118E	dw	0x1179
l1631_1190	dw	0x1180
l1631_1192	dw	0x1187
l1631_1194	dw	0x1157
l1631_1196	dw	0x1165
l1631_1198	dw	0x1157
l1631_119A	dw	0x116C
l1631_119C	dw	0x116C
l1631_119E	dw	0x115E
l1631_11A0	dw	0x1165
l1631_11A2	dw	0x115E

l1631_11A4:
	mov	ax,[bp-2h]
	mov	sp,bp
	pop	bp
	retf

;; fn1631_11AB: 1631:11AB
;;   Called from:
;;     1AE8:0BDE (in fn1AE8_000C)
;;     1AE8:0C8D (in fn1AE8_000C)
fn1631_11AB proc
	push	bp
	mov	bp,sp
	mov	ax,12h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-4h],0h
	mov	word ptr [bp-0Ah],1h
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp+8h]
	mov	es,[558Eh]
	cmp	byte ptr es:[bx+0C724h],0h
	jnz	11DDh

l1631_11D8:
	mov	word ptr [bp-4h],1h

l1631_11DD:
	call	far 0800h:19DDh
	mov	[bp-0Ch],ax
	cmp	ax,8h
	jl	11F3h

l1631_11EA:
	sub	ax,8h
	sar	ax,1h
	inc	ax
	mov	[bp-0Ah],ax

l1631_11F3:
	cmp	word ptr [2E38h],0h
	jz	1223h

l1631_11FA:
	cmp	word ptr [bp-0Ah],0h
	jz	1223h

l1631_1200:
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	ax,315Eh
	push	ds
	push	ax
	push	cs
	call	1DABh
	add	sp,4h
	mov	es,[55B4h]
	mov	word ptr es:[4586h],1h

l1631_1223:
	cmp	word ptr [bp-4h],0h
	jz	129Eh

l1631_1229:
	mov	word ptr [bp-0Ah],0h
	mov	bx,[bp+8h]
	mov	al,[bx+316Eh]
	cbw
	mov	[bp-2h],ax
	mov	word ptr [bp-8h],0h
	jmp	1267h

l1631_1240:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	add	ax,[bp-2h]
	add	ax,[bp-8h]
	add	ax,0C724h
	mov	[bp-10h],ax
	mov	word ptr [bp-0Eh],3092h
	les	bx,[bp-10h]
	cmp	byte ptr es:[bx],0h
	jz	1264h

l1631_1260:
	or	byte ptr es:[bx],80h

l1631_1264:
	inc	word ptr [bp-8h]

l1631_1267:
	mov	bx,[bp+8h]
	mov	al,[bx+3176h]
	cbw
	cmp	ax,[bp-8h]
	jg	1240h

l1631_1274:
	mov	ax,bx
	cmp	ax,1Ch
	jz	128Ch

l1631_127B:
	cmp	ax,1Eh
	jz	12CEh

l1631_1280:
	cmp	ax,21h
	jz	12BAh

l1631_1285:
	cmp	ax,23h
	jz	12E2h

l1631_128A:
	jmp	129Eh

l1631_128C:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	and	byte ptr es:[bx+0C748h],0Fh

l1631_129E:
	cmp	word ptr [bp-0Ah],0h
	jnz	12A7h

l1631_12A4:
	jmp	15F5h

l1631_12A7:
	mov	ax,[bp+8h]
	sub	ax,1Ch
	cmp	ax,7h
	ja	129Eh

l1631_12B2:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+15E2h]

l1631_12BA:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	and	byte ptr es:[bx+0C749h],0Fh
	jmp	129Eh

l1631_12CE:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	and	byte ptr es:[bx+0C748h],0F0h
	jmp	129Eh

l1631_12E2:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	and	byte ptr es:[bx+0C749h],0F0h
	jmp	129Eh

l1631_12F6:
	call	far 0800h:19F3h
	cmp	ax,1h
	jz	131Ch

l1631_1300:
	cmp	ax,2h
	jz	1347h

l1631_1305:
	cmp	ax,3h
	jz	136Dh

l1631_130A:
	cmp	ax,4h
	jnz	1312h

l1631_130F:
	jmp	1393h

l1631_1312:
	cmp	ax,5h
	jz	1347h

l1631_1317:
	cmp	ax,6h
	jnz	129Eh

l1631_131C:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	cmp	byte ptr es:[bx+0C79Ch],0h
	jnz	1333h

l1631_1330:
	jmp	129Eh

l1631_1333:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C79Ch],0FFh

l1631_1341:
	dec	word ptr [bp-0Ah]
	jmp	129Eh

l1631_1347:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	cmp	byte ptr es:[bx+0C79Bh],2h
	jc	135Eh

l1631_135B:
	jmp	129Eh

l1631_135E:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	inc	byte ptr es:[bx+0C79Bh]
	jmp	1341h

l1631_136D:
	sub	ax,ax
	mov	[bp-0Ah],ax
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[558Eh]
	mov	es:[bx+0C743h],cl

l1631_1385:
	mov	es,[55B2h]
	mov	word ptr es:[0E484h],1h
	jmp	129Eh

l1631_1393:
	mov	ax,1h
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	lea	ax,[bx+0C779h]

l1631_13A3:
	mov	dx,3092h
	push	dx
	push	ax
	push	cs
	call	163Eh
	add	sp,6h
	sub	[bp-0Ah],ax
	jmp	129Eh

l1631_13B5:
	call	far 0800h:19F3h
	cmp	ax,3h
	jg	1410h

l1631_13BF:
	call	far 0800h:19F3h
	cmp	ax,3h
	jg	13F4h

l1631_13C9:
	dec	word ptr [bp-0Ah]
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[558Eh]
	inc	byte ptr es:[si+0C79Ah]
	cmp	byte ptr es:[si+0C79Ah],2h

l1631_13E3:
	jnc	13E8h

l1631_13E5:
	jmp	129Eh

l1631_13E8:
	sub	ax,ax
	mov	[bp-0Ah],ax
	mov	es:[si+0C744h],al
	jmp	1385h

l1631_13F4:
	dec	word ptr [bp-0Ah]
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	es,[558Eh]
	inc	byte ptr es:[si+0C799h]
	cmp	byte ptr es:[si+0C799h],3h
	jmp	13E3h

l1631_1410:
	mov	ax,2h
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	lea	ax,[bx+0C777h]
	jmp	13A3h

l1631_1422:
	mov	word ptr [bp-2h],24h
	mov	word ptr [bp-6h],4Fh
	cmp	word ptr [bp+8h],23h
	jnz	143Ch

l1631_1432:
	mov	word ptr [bp-2h],25h
	mov	word ptr [bp-6h],51h

l1631_143C:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-2h]
	add	bx,si
	mov	es,[558Eh]
	test	byte ptr es:[bx+0C724h],0Fh
	jnz	1473h

l1631_1455:
	mov	ax,2h
	push	ax
	mov	bx,[bp-6h]
	lea	ax,[bx+si+0C724h]
	mov	dx,3092h
	push	dx
	push	ax
	push	cs
	call	15FAh
	add	sp,6h
	or	ax,ax
	jnz	1473h

l1631_1470:
	jmp	1573h

l1631_1473:
	call	far 0800h:19F3h
	mov	[bp-6h],ax
	cmp	ax,3h
	jl	14C7h

l1631_1480:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	add	ax,[bp-2h]
	add	ax,0C724h
	mov	[bp-10h],ax
	mov	word ptr [bp-0Eh],3092h
	les	bx,[bp-10h]
	mov	al,es:[bx]
	mov	[bp-12h],al
	test	byte ptr [bp-12h],0Fh
	jz	14C7h

l1631_14A3:
	mov	bx,[bp-6h]
	mov	al,[bx+316Ah]
	cbw
	mov	cl,[bp-12h]
	sub	ch,ch
	test	cx,ax
	jnz	14B7h

l1631_14B4:
	jmp	129Eh

l1631_14B7:
	mov	bx,[bp-10h]
	mov	si,[bp-6h]
	mov	al,[si+3172h]

l1631_14C1:
	and	es:[bx],al
	jmp	1341h

l1631_14C7:
	mov	word ptr [bp-2h],4Fh
	cmp	word ptr [bp+8h],23h
	jnz	14D7h

l1631_14D2:
	mov	word ptr [bp-2h],51h

l1631_14D7:
	mov	ax,2h

l1631_14DA:
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-2h]
	lea	ax,[bx+si+0C724h]
	jmp	13A3h

l1631_14ED:
	mov	word ptr [bp-2h],3Ah
	cmp	word ptr [bp+8h],22h
	jnz	14FDh

l1631_14F8:
	mov	word ptr [bp-2h],48h

l1631_14FD:
	mov	ax,7h
	push	ax
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-2h]
	lea	ax,[bx+si+0C724h]
	mov	dx,3092h
	push	dx
	push	ax
	push	cs
	call	15FAh
	add	sp,6h
	or	ax,ax
	jz	1573h

l1631_1520:
	mov	ax,7h
	jmp	14DAh

l1631_1525:
	mov	word ptr [bp-2h],24h
	mov	word ptr [bp-6h],33h
	cmp	word ptr [bp+8h],21h
	jnz	153Fh

l1631_1535:
	mov	word ptr [bp-2h],25h
	mov	word ptr [bp-6h],41h

l1631_153F:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	si,ax
	mov	bx,[bp-2h]
	add	bx,si
	mov	es,[558Eh]
	test	byte ptr es:[bx+0C724h],0F0h
	jnz	157Bh

l1631_1558:
	mov	ax,7h
	push	ax
	mov	bx,[bp-6h]
	lea	ax,[bx+si+0C724h]
	mov	dx,3092h
	push	dx
	push	ax
	push	cs
	call	15FAh
	add	sp,6h
	or	ax,ax
	jnz	157Bh

l1631_1573:
	mov	word ptr [bp-0Ah],0h
	jmp	129Eh

l1631_157B:
	call	far 0800h:19F3h
	mov	[bp-6h],ax
	cmp	ax,3h
	jl	15CCh

l1631_1588:
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	add	ax,[bp-2h]
	add	ax,0C724h
	mov	[bp-10h],ax
	mov	word ptr [bp-0Eh],3092h
	les	bx,[bp-10h]
	mov	al,es:[bx]
	mov	[bp-12h],al
	test	byte ptr [bp-12h],0F0h
	jz	15CCh

l1631_15AB:
	mov	bx,[bp-6h]
	mov	al,[bx+317Ah]
	cbw
	mov	cl,[bp-12h]
	sub	ch,ch
	test	cx,ax
	jnz	15BFh

l1631_15BC:
	jmp	129Eh

l1631_15BF:
	mov	bx,[bp-10h]
	mov	si,[bp-6h]
	mov	al,[si+3182h]
	jmp	14C1h

l1631_15CC:
	mov	word ptr [bp-2h],33h
	cmp	word ptr [bp+8h],21h
	jz	15DAh

l1631_15D7:
	jmp	1520h

l1631_15DA:
	mov	word ptr [bp-2h],41h
	jmp	1520h
l1631_15E2	dw	0x1525
l1631_15E4	dw	0x14ED
l1631_15E6	dw	0x1422
l1631_15E8	dw	0x12F6
l1631_15EA	dw	0x13B5
l1631_15EC	dw	0x1525
l1631_15EE	dw	0x14ED
l1631_15F0	dw	0x1422
1631:15F2       E9 A9 FC                                    ...           

l1631_15F5:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_15FA: 1631:15FA
;;   Called from:
;;     1631:1465 (in fn1631_11AB)
;;     1631:1515 (in fn1631_11AB)
;;     1631:1568 (in fn1631_11AB)
;;     1631:1658 (in fn1631_163E)
fn1631_15FA proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-4h],0h
	mov	word ptr [bp-2h],0h
	jmp	162Eh

l1631_1612:
	mov	bx,[bp-2h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	mov	[bp-6h],al
	or	al,al
	jz	162Bh

l1631_1622:
	test	byte ptr [bp-6h],80h
	jnz	162Bh

l1631_1628:
	inc	word ptr [bp-4h]

l1631_162B:
	inc	word ptr [bp-2h]

l1631_162E:
	mov	ax,[bp+0Ah]
	cmp	[bp-2h],ax
	jl	1612h

l1631_1636:
	mov	ax,[bp-4h]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_163E: 1631:163E
;;   Called from:
;;     1631:13A8 (in fn1631_11AB)
fn1631_163E proc
	push	bp
	mov	bp,sp
	mov	ax,6h
	call	far 207Fh:2FDCh
	push	si
	mov	word ptr [bp-4h],0h
	push	word ptr [bp+0Ah]
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	push	cs
	call	15FAh
	add	sp,6h
	or	ax,ax
	jz	16A3h

l1631_1663:
	call	far 207Fh:0BC0h
	and	ax,3h
	mov	[bp-2h],ax
	jmp	1690h

l1631_1670:
	mov	bx,[bp-2h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	mov	[bp-6h],al
	or	al,al
	jz	168Dh

l1631_1680:
	test	byte ptr [bp-6h],80h
	jnz	168Dh

l1631_1686:
	or	byte ptr es:[bx+si],80h
	inc	word ptr [bp-4h]

l1631_168D:
	inc	word ptr [bp-2h]

l1631_1690:
	mov	ax,[bp+0Ah]
	cmp	[bp-2h],ax
	jl	169Dh

l1631_1698:
	mov	word ptr [bp-2h],0h

l1631_169D:
	cmp	word ptr [bp-4h],0h
	jz	1670h

l1631_16A3:
	mov	ax,[bp-4h]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_16AB: 1631:16AB
;;   Called from:
;;     1631:0144 (in fn1631_0006)
;;     1AE8:10CF (in fn1AE8_000C)
fn1631_16AB proc
	push	bp
	mov	bp,sp
	mov	ax,22h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	word ptr [bp-6h],0h
	cmp	word ptr [bp+6h],4h
	jl	16C9h

l1631_16C3:
	cmp	word ptr [bp+6h],0Ch
	jl	16D2h

l1631_16C9:
	cmp	word ptr [bp+6h],10h
	jge	16D2h

l1631_16CF:
	jmp	1864h

l1631_16D2:
	cmp	word ptr [bp+6h],10h
	jl	16E0h

l1631_16D8:
	mov	ax,[bp+6h]
	sub	ax,8h
	jmp	16E6h

l1631_16E0:
	mov	ax,[bp+6h]
	sub	ax,4h

l1631_16E6:
	mov	[bp-1Ah],ax
	mov	word ptr [bp-18h],4h

l1631_16EE:
	mov	ax,[bp+6h]
	cmp	[bp-18h],ax
	jz	172Bh

l1631_16F6:
	mov	si,[bp-18h]
	shl	si,1h
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	es,[5592h]
	cmp	es:[si+4004h],ax
	jnz	172Bh

l1631_170E:
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	es,[5590h]
	cmp	es:[si+4036h],ax
	jnz	172Bh

l1631_1721:
	mov	word ptr [bp-6h],1h
	mov	word ptr [bp-18h],0Ch

l1631_172B:
	cmp	word ptr [bp-6h],0h
	jnz	1771h

l1631_1731:
	mov	ax,[bp-18h]
	add	ax,0Ch
	cmp	ax,[bp+6h]
	jz	1771h

l1631_173C:
	mov	si,[bp-18h]
	shl	si,1h
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	es,[5592h]
	cmp	es:[si+401Ch],ax
	jnz	1771h

l1631_1754:
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	es,[5590h]
	cmp	es:[si+404Eh],ax
	jnz	1771h

l1631_1767:
	mov	word ptr [bp-6h],1h
	mov	word ptr [bp-18h],0Ch

l1631_1771:
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],0Ch
	jge	177Dh

l1631_177A:
	jmp	16EEh

l1631_177D:
	cmp	word ptr [bp-6h],0h
	jz	1786h

l1631_1783:
	jmp	1B3Bh

l1631_1786:
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	[bp-4h],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	[bp-0Ah],ax
	mov	word ptr [bp-18h],0h
	jmp	183Eh

l1631_17A4:
	sub	ax,ax
	push	ax
	mov	ax,0FFFFh
	push	ax
	call	far 0800h:191Bh
	add	sp,4h
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	cmp	[bp-4h],ax
	jz	17DCh

l1631_17C0:
	sub	ax,ax
	push	ax
	mov	ax,2h
	push	ax
	call	far 0800h:191Bh
	add	sp,4h
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	cmp	[bp-4h],ax
	jnz	17E1h

l1631_17DC:
	mov	word ptr [bp-6h],1h

l1631_17E1:
	cmp	word ptr [bp-6h],0h
	jz	17F0h

l1631_17E7:
	mov	ax,0Eh
	mov	[bp-18h],ax
	mov	[bp-1Eh],ax

l1631_17F0:
	add	word ptr [bp-1Eh],0Ch

l1631_17F4:
	cmp	word ptr [bp-1Eh],0Dh
	jge	183Bh

l1631_17FA:
	mov	si,[bp-18h]
	add	si,[bp-1Eh]
	shl	si,1h
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	es,[5582h]
	mov	es:[0A44Bh],ax
	mov	es,[5590h]
	mov	ax,es:[si+4036h]
	mov	es,[5584h]
	mov	es:[0A44Dh],ax
	cmp	[bp-0Ah],ax
	jnz	17E1h

l1631_1829:
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	cmp	[bp-4h],ax
	jz	1839h

l1631_1836:
	jmp	17A4h

l1631_1839:
	jmp	17DCh

l1631_183B:
	inc	word ptr [bp-18h]

l1631_183E:
	cmp	word ptr [bp-18h],4h
	jge	184Bh

l1631_1844:
	mov	word ptr [bp-1Eh],0h
	jmp	17F4h

l1631_184B:
	mov	es,[5582h]
	mov	ax,[bp-4h]
	mov	es:[0A44Bh],ax
	mov	es,[5584h]
	mov	ax,[bp-0Ah]
	mov	es:[0A44Dh],ax
	jmp	1B3Bh

l1631_1864:
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	inc	ax
	mov	[bp-1Ch],ax
	test	byte ptr [bp-1Ch],80h
	jz	187Bh

l1631_1876:
	add	word ptr [bp-1Ch],80h

l1631_187B:
	mov	ax,[bp-1Ch]
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp-1Ch]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-1Ch],ax
	mov	word ptr [bp-18h],0h
	jmp	191Eh

l1631_1896:
	add	word ptr [bp-1Eh],0Ch

l1631_189A:
	cmp	word ptr [bp-1Eh],0Dh
	jge	191Bh

l1631_18A0:
	mov	si,[bp-18h]
	add	si,[bp-1Eh]
	mov	di,si
	shl	di,1h
	mov	es,[559Ah]
	cmp	word ptr es:[di+406Ah],0h
	jz	1896h

l1631_18B6:
	cmp	[bp+6h],si
	jz	1896h

l1631_18BB:
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	es,[5590h]
	cmp	es:[di+4036h],ax
	jnz	1896h

l1631_18CE:
	mov	es,[5592h]
	mov	ax,es:[di+4004h]
	inc	ax
	mov	[bp-8h],ax
	test	byte ptr [bp-8h],80h
	jz	18E6h

l1631_18E1:
	add	word ptr [bp-8h],80h

l1631_18E6:
	mov	ax,[bp-8h]
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp-8h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-8h],ax
	sub	ax,[bp-1Ch]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,3h
	jge	1896h

l1631_190A:
	mov	word ptr [bp-6h],1h
	mov	ax,0Dh
	mov	[bp-1Eh],ax
	mov	[bp-18h],ax
	jmp	1896h

l1631_191B:
	inc	word ptr [bp-18h]

l1631_191E:
	cmp	word ptr [bp-18h],4h
	jge	192Ch

l1631_1924:
	mov	word ptr [bp-1Eh],0h
	jmp	189Ah

l1631_192C:
	mov	word ptr [bp-10h],4h
	cmp	word ptr [bp+6h],0Ch
	jl	193Ch

l1631_1937:
	mov	word ptr [bp-10h],10h

l1631_193C:
	dec	word ptr [bp-1Ch]
	mov	ax,[bp-10h]
	mov	[bp-18h],ax
	jmp	19ACh

l1631_1947:
	mov	si,[bp-18h]
	shl	si,1h
	mov	es,[559Ah]
	cmp	word ptr es:[si+406Ah],0h
	jz	19A9h

l1631_1958:
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	es,[5590h]
	cmp	es:[si+4036h],ax
	jnz	19A9h

l1631_196B:
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	[bp-8h],ax
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp-8h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-8h],ax
	mov	ax,[bp-1Ch]
	sub	ax,[bp-8h]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,2h
	jge	19A9h

l1631_199B:
	mov	word ptr [bp-6h],1h
	mov	ax,[bp-10h]
	add	ax,9h
	mov	[bp-18h],ax

l1631_19A9:
	inc	word ptr [bp-18h]

l1631_19AC:
	mov	ax,[bp-10h]
	add	ax,8h
	cmp	ax,[bp-18h]
	jg	1947h

l1631_19B7:
	cmp	word ptr [bp-6h],0h
	jz	19C0h

l1631_19BD:
	jmp	1B3Bh

l1631_19C0:
	cmp	word ptr [bp+0Ch],0h
	jnz	19C9h

l1631_19C6:
	jmp	1B3Bh

l1631_19C9:
	xor	byte ptr [bp-10h],14h
	mov	ax,[bp-10h]
	mov	[bp-18h],ax
	jmp	1AAAh

l1631_19D6:
	mov	ax,11h
	mul	word ptr [bp-20h]
	mov	bx,ax
	mov	es,[558Eh]
	mov	al,es:[bx+0C614h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[55B6h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]

l1631_19FC:
	push	cs
	call	1DABh
	add	sp,4h
	mov	ax,31A6h
	push	ds
	push	ax
	push	cs
	call	1DABh
	add	sp,4h
	mov	ax,12h
	push	ax
	call	far 0800h:19BFh
	add	sp,2h
	mov	es,[55B8h]
	cmp	word ptr es:[015Eh],5h
	jge	1A35h

l1631_1A27:
	push	cs
	call	1DCCh
	cmp	word ptr [bp-20h],8h
	jnc	1A35h

l1631_1A31:
	push	cs
	call	1DCCh

l1631_1A35:
	mov	si,[bp-18h]
	shl	si,1h
	mov	es,[5590h]
	push	word ptr es:[si+4036h]
	mov	es,[5592h]
	push	word ptr es:[si+4004h]
	mov	ax,7Eh
	push	ax
	call	far 183Bh:27C9h
	add	sp,6h
	mov	bx,[bp-18h]
	mov	es,[55BAh]
	mov	byte ptr es:[bx+409Ah],7Eh
	mov	bx,[bp-18h]
	mov	es,[55AEh]
	mov	byte ptr es:[bx+0D55Eh],0h
	mov	ax,11h
	mul	word ptr [bp-20h]
	mov	si,ax
	sub	ax,ax
	mov	bx,[bp-18h]
	shl	bx,1h
	mov	es,[559Ah]
	mov	es:[bx+406Ah],ax
	mov	es,[558Eh]
	mov	es:[si+0C623h],al
	mov	byte ptr es:[si+0C614h],0FFh
	cmp	word ptr [bp-20h],2h
	jnc	1AA7h

l1631_1A9F:
	mov	es,[55BCh]
	mov	es:[014Ah],ax

l1631_1AA7:
	inc	word ptr [bp-18h]

l1631_1AAA:
	mov	ax,[bp-10h]
	add	ax,8h
	cmp	ax,[bp-18h]
	jg	1AB8h

l1631_1AB5:
	jmp	1B3Bh

l1631_1AB8:
	mov	si,[bp-18h]
	shl	si,1h
	mov	es,[559Ah]
	cmp	word ptr es:[si+406Ah],0h
	jz	1AA7h

l1631_1AC9:
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	es,[5590h]
	cmp	es:[si+4036h],ax
	jnz	1AA7h

l1631_1ADC:
	mov	es,[5592h]
	mov	ax,es:[si+4004h]
	mov	[bp-8h],ax
	and	ax,0F00h
	shr	ax,1h
	mov	cx,[bp-8h]
	and	cx,7Fh
	or	ax,cx
	mov	[bp-8h],ax
	mov	ax,[bp-1Ch]
	sub	ax,[bp-8h]
	push	ax
	call	far 207Fh:3C6Ch
	add	sp,2h
	cmp	ax,2h
	jge	1AA7h

l1631_1B0C:
	mov	ax,[bp-18h]
	sub	ax,4h
	mov	[bp-20h],ax
	mov	ax,4h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	cmp	word ptr [bp-20h],0Ch
	jnc	1B2Fh

l1631_1B2C:
	jmp	19D6h

l1631_1B2F:
	sub	word ptr [bp-20h],4h
	mov	ax,319Ah
	push	ds
	push	ax
	jmp	19FCh

l1631_1B3B:
	mov	ax,[bp-6h]
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1B44: 1631:1B44
;;   Called from:
;;     1AE8:02C3 (in fn1AE8_000C)
;;     1AE8:02D5 (in fn1AE8_000C)
fn1631_1B44 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	ax,7Dh
	imul	word ptr [bp+6h]
	mov	bx,ax
	add	bx,[bp+8h]
	mov	es,[558Eh]
	mov	al,es:[bx+0C724h]
	sub	ah,ah
	mov	[bp-2h],ax
	mov	word ptr [bp-4h],0h
	test	byte ptr [bp-2h],4h
	jnz	1B76h

l1631_1B73:
	inc	word ptr [bp-4h]

l1631_1B76:
	test	byte ptr [bp-2h],2h
	jnz	1B7Fh

l1631_1B7C:
	inc	word ptr [bp-4h]

l1631_1B7F:
	test	byte ptr [bp-2h],1h
	jnz	1B88h

l1631_1B85:
	inc	word ptr [bp-4h]

l1631_1B88:
	mov	ax,[bp-4h]
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1B8F: 1631:1B8F
;;   Called from:
;;     1AE8:0B38 (in fn1AE8_000C)
fn1631_1B8F proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	mov	word ptr [bp-2h],0h

l1631_1B9F:
	mov	bx,[bp-2h]
	mov	al,[bx+3242h]
	cbw
	cmp	ax,[bp+6h]
	jnz	1BF1h

l1631_1BAC:
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+3250h]
	push	word ptr [bx+324Eh]
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	mov	ax,3240h
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
	push	cs
	call	1DABh
	add	sp,4h
	mov	word ptr [bp-2h],0Bh

l1631_1BF1:
	inc	word ptr [bp-2h]
	cmp	word ptr [bp-2h],0Bh
	jl	1B9Fh

l1631_1BFA:
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1BFE: 1631:1BFE
;;   Called from:
;;     1631:06A5 (in fn1631_03AB)
;;     1AE8:01B5 (in fn1AE8_000C)
fn1631_1BFE proc
	push	bp
	mov	bp,sp
	mov	ax,1Ch
	call	far 207Fh:2FDCh
	push	si
	mov	es,[5582h]
	mov	ax,es:[0A44Bh]
	mov	[bp-4h],ax
	mov	es,[5584h]
	mov	ax,es:[0A44Dh]
	mov	[bp-8h],ax
	push	ax
	push	word ptr [bp-4h]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:1DF8h
	mov	es,[559Ch]
	cmp	word ptr es:[0E48Eh],0h
	jz	1C49h

l1631_1C3D:
	cmp	word ptr [bp+8h],0Dh
	jnz	1C49h

l1631_1C43:
	mov	ax,1h
	jmp	1DA6h

l1631_1C49:
	mov	es,[5586h]
	mov	ax,es:[09EDh]
	add	ax,96h
	mov	[bp-10h],ax
	mov	word ptr [bp-1Ch],1h
	mov	ax,[bp-8h]
	and	ax,1h
	mov	[bp-2h],ax
	test	byte ptr [bp-4h],1h
	jz	1C73h

l1631_1C6B:
	inc	word ptr [bp-10h]
	mov	word ptr [bp-1Ch],0h

l1631_1C73:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp-8h]
	push	word ptr [bp-4h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	[bp-12h],ax
	mov	word ptr [bp-0Eh],1h
	mov	bx,[bp-10h]
	mov	es,[5588h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-14h],ax
	mov	es,[558Ah]
	cmp	es:[0150h],ax
	jle	1CAEh

l1631_1CAB:
	jmp	1D5Ch

l1631_1CAE:
	sub	ax,ax
	jmp	1DA6h

l1631_1CB3:
	dec	word ptr [bp-12h]

l1631_1CB6:
	and	word ptr [bp-12h],7h

l1631_1CBA:
	mov	si,[bp-12h]
	shl	si,1h
	mov	ax,[si+328Ah]
	add	[bp-4h],ax
	test	byte ptr [bp-4h],80h
	jz	1CD3h

l1631_1CCC:
	mov	ax,[si+32AAh]
	add	[bp-4h],ax

l1631_1CD3:
	mov	si,[bp-12h]
	shl	si,1h
	mov	ax,[si+329Ah]
	add	[bp-8h],ax
	test	byte ptr [bp-8h],80h
	jz	1CECh

l1631_1CE5:
	mov	ax,[si+32BAh]
	add	[bp-8h],ax

l1631_1CEC:
	mov	bx,[bp-12h]
	shl	bx,1h
	mov	si,[bx+328Ah]
	or	si,si
	jz	1D0Bh

l1631_1CF9:
	mov	ax,[bp-1Ch]
	add	ax,si
	and	ax,1h
	mov	[bp-1Ch],ax
	or	ax,ax
	jnz	1D0Bh

l1631_1D08:
	add	[bp-10h],si

l1631_1D0B:
	mov	si,[bp-12h]
	shl	si,1h
	cmp	word ptr [si+329Ah],0h
	jz	1D2Fh

l1631_1D17:
	mov	ax,[si+329Ah]
	add	ax,[bp-2h]
	and	ax,1h
	mov	[bp-2h],ax
	or	ax,ax
	jnz	1D2Fh

l1631_1D28:
	mov	ax,[si+32CAh]
	add	[bp-10h],ax

l1631_1D2F:
	mov	bx,[bp-10h]
	mov	es,[5588h]
	mov	al,es:[bx+7ADh]
	sub	ah,ah
	mov	[bp-14h],ax
	mov	es,[558Ah]
	cmp	es:[0150h],ax
	jg	1D5Ch

l1631_1D4B:
	mov	ax,[bp+0Ah]
	mov	[bp-4h],ax
	mov	ax,[bp+0Ch]
	mov	[bp-8h],ax
	mov	word ptr [bp-0Eh],0h

l1631_1D5C:
	mov	ax,[bp+0Ah]
	cmp	[bp-4h],ax
	jnz	1D6Ch

l1631_1D64:
	mov	ax,[bp+0Ch]
	cmp	[bp-8h],ax
	jz	1DA3h

l1631_1D6C:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp-8h]
	push	word ptr [bp-4h]
	call	far 207Fh:0971h
	add	sp,8h
	mov	[bp-6h],ax
	sub	ax,[bp-12h]
	mov	[bp-18h],ax
	or	ax,ax
	jnz	1D90h

l1631_1D8D:
	jmp	1CBAh

l1631_1D90:
	and	word ptr [bp-18h],7h
	cmp	word ptr [bp-18h],5h
	jl	1D9Dh

l1631_1D9A:
	jmp	1CB3h

l1631_1D9D:
	inc	word ptr [bp-12h]
	jmp	1CB6h

l1631_1DA3:
	mov	ax,[bp-0Eh]

l1631_1DA6:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1DAB: 1631:1DAB
;;   Called from:
;;     1543:0B60 (in fn1543_0A35)
;;     1631:1211 (in fn1631_11AB)
;;     1631:19FC (in fn1631_16AB)
;;     1631:1A08 (in fn1631_16AB)
;;     1631:1BE5 (in fn1631_1B8F)
;;     1AE8:0498 (in fn1AE8_000C)
;;     1AE8:04B7 (in fn1AE8_000C)
;;     1AE8:052A (in fn1AE8_000C)
;;     1AE8:055A (in fn1AE8_000C)
;;     1AE8:05B7 (in fn1AE8_000C)
;;     1AE8:05D6 (in fn1AE8_000C)
;;     1AE8:05EF (in fn1AE8_000C)
;;     1AE8:06DC (in fn1AE8_000C)
;;     1AE8:06F4 (in fn1AE8_000C)
;;     1AE8:0713 (in fn1AE8_000C)
;;     1AE8:07E8 (in fn1AE8_000C)
;;     1AE8:0850 (in fn1AE8_000C)
;;     1AE8:0A54 (in fn1AE8_000C)
;;     1AE8:0B2D (in fn1AE8_000C)
;;     1AE8:1B1A (in fn1AE8_12C7)
fn1631_1DAB proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	cmp	word ptr [2E38h],0h
	jz	1DCAh

l1631_1DBC:
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 1E56h:03F5h
	add	sp,4h

l1631_1DCA:
	pop	bp
	retf

;; fn1631_1DCC: 1631:1DCC
;;   Called from:
;;     1543:0C5C (in fn1543_0A35)
;;     1631:1A27 (in fn1631_16AB)
;;     1631:1A31 (in fn1631_16AB)
;;     1AE8:0D76 (in fn1AE8_000C)
fn1631_1DCC proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[55B8h]
	cmp	word ptr es:[015Eh],5h
	jge	1DF2h

l1631_1DDF:
	mov	ax,0Ch
	imul	word ptr es:[015Eh]
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	jmp	1DF7h

l1631_1DF2:
	call	far 1F3Dh:0259h

l1631_1DF7:
	retf

;; fn1631_1DF8: 1631:1DF8
;;   Called from:
;;     1AE8:16DF (in fn1AE8_12C7)
;;     1AE8:1749 (in fn1AE8_12C7)
fn1631_1DF8 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[5580h]
	mov	word ptr es:[0E486h],1Ah
	mov	es,[557Eh]
	mov	word ptr es:[0E488h],0Ch
	jmp	1E32h

l1631_1E1A:
	dec	word ptr [bp+8h]
	mov	al,[bp+8h]
	test	al,80h
	jz	1E29h

l1631_1E24:
	and	word ptr [bp+8h],0F07Fh

l1631_1E29:
	mov	es,[557Eh]
	dec	word ptr es:[0E488h]

l1631_1E32:
	mov	ax,[bp+0Ch]
	cmp	[bp+8h],ax
	ja	1E1Ah

l1631_1E3A:
	jmp	1E54h

l1631_1E3C:
	inc	word ptr [bp+8h]
	mov	al,[bp+8h]
	test	al,80h
	jz	1E4Bh

l1631_1E46:
	add	word ptr [bp+8h],0F80h

l1631_1E4B:
	mov	es,[557Eh]
	inc	word ptr es:[0E488h]

l1631_1E54:
	mov	ax,[bp+0Ch]
	cmp	[bp+8h],ax
	jc	1E3Ch

l1631_1E5C:
	jmp	1E76h

l1631_1E5E:
	dec	word ptr [bp+6h]
	mov	al,[bp+6h]
	test	al,80h
	jz	1E6Dh

l1631_1E68:
	and	word ptr [bp+6h],0F7Fh

l1631_1E6D:
	mov	es,[5580h]
	dec	word ptr es:[0E486h]

l1631_1E76:
	mov	ax,[bp+0Ah]
	cmp	[bp+6h],ax
	ja	1E5Eh

l1631_1E7E:
	jmp	1E98h

l1631_1E80:
	inc	word ptr [bp+6h]
	mov	al,[bp+6h]
	test	al,80h
	jz	1E8Fh

l1631_1E8A:
	add	word ptr [bp+6h],80h

l1631_1E8F:
	mov	es,[5580h]
	inc	word ptr es:[0E486h]

l1631_1E98:
	mov	ax,[bp+0Ah]
	cmp	[bp+6h],ax
	jc	1E80h

l1631_1EA0:
	pop	bp
	retf

;; fn1631_1EA2: 1631:1EA2
;;   Called from:
;;     1AE8:18A0 (in fn1AE8_12C7)
fn1631_1EA2 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	cmp	word ptr [bp+6h],0h
	jge	1EDDh

l1631_1EB3:
	cmp	word ptr [bp+8h],0h
	jle	1ECAh

l1631_1EB9:
	mov	word ptr [bp-2h],2h
	mov	ax,[bp+6h]
	neg	ax
	cmp	ax,[bp+8h]

l1631_1EC6:
	jle	1F02h

l1631_1EC8:
	jmp	1EFFh

l1631_1ECA:
	mov	word ptr [bp-2h],4h
	mov	ax,[bp+8h]
	neg	ax
	mov	cx,[bp+6h]
	neg	cx
	cmp	ax,cx
	jmp	1EC6h

l1631_1EDD:
	cmp	word ptr [bp+8h],0h
	jle	1EF0h

l1631_1EE3:
	mov	word ptr [bp-2h],0h
	mov	ax,[bp+6h]
	cmp	[bp+8h],ax
	jmp	1EC6h

l1631_1EF0:
	mov	word ptr [bp-2h],6h
	mov	ax,[bp+8h]
	neg	ax
	cmp	ax,[bp+6h]
	jge	1F02h

l1631_1EFF:
	inc	word ptr [bp-2h]

l1631_1F02:
	mov	ax,[bp-2h]
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1F09: 1631:1F09
;;   Called from:
;;     1AE8:14F2 (in fn1AE8_12C7)
;;     1AE8:194A (in fn1AE8_12C7)
;;     1AE8:1A8D (in fn1AE8_12C7)
;;     1AE8:1AE3 (in fn1AE8_12C7)
fn1631_1F09 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,1h
	push	ax
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:1ECEh
	add	sp,6h
	mov	word ptr [bp-2h],4h
	mov	es,[558Eh]
	cmp	byte ptr es:[0C620h],8h
	jge	1F40h

l1631_1F38:
	mov	al,es:[0C620h]
	cbw
	mov	[bp-2h],ax

l1631_1F40:
	mov	si,[bp-2h]
	shl	si,1h
	mov	es,[5590h]
	push	word ptr es:[si+4036h]
	mov	es,[5592h]
	push	word ptr es:[si+4004h]
	call	far 0800h:17BBh
	add	sp,4h
	call	far 0800h:240Bh
	call	far 207Fh:18EFh
	call	far 0800h:0E4Bh
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1631_1F73: 1631:1F73
;;   Called from:
;;     1AE8:195B (in fn1AE8_12C7)
;;     1AE8:1AA2 (in fn1AE8_12C7)
fn1631_1F73 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[55BEh]
	cmp	word ptr es:[4FBAh],2h
	jz	1FB3h

l1631_1F89:
	push	word ptr [bp+0Ah]
	push	word ptr [bp+8h]
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[55C0h]
	push	word ptr es:[bx+39FCh]
	push	word ptr es:[bx+39FAh]
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:28EBh
	jmp	1FDAh

l1631_1FB3:
	push	word ptr [bp+0Ah]
	push	word ptr [bp+8h]
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	es,[55C0h]
	push	word ptr es:[bx+39FCh]
	push	word ptr es:[bx+39FAh]
	sub	ax,ax
	mov	dx,0AC00h
	push	dx
	push	ax
	call	far 207Fh:0377h

l1631_1FDA:
	add	sp,0Ch
	pop	bp
	retf

;; fn1631_1FDF: 1631:1FDF
;;   Called from:
;;     0800:0353 (in fn0800_0000)
;;     0800:4D39 (in fn0800_4CAC)
;;     0FDC:0592 (in fn0FDC_01C0)
;;     11B8:02C9 (in fn11B8_0002)
;;     11B8:03F3 (in fn11B8_0002)
;;     11B8:0539 (in fn11B8_0002)
;;     11B8:069A (in fn11B8_0002)
;;     11B8:07EC (in fn11B8_0002)
;;     11B8:09B5 (in fn11B8_0925)
;;     11B8:1975 (in fn11B8_1762)
;;     11B8:1998 (in fn11B8_1762)
;;     1CD3:0961 (in fn1CD3_0004)
;;     1CD3:0A34 (in fn1CD3_0004)
;;     1CD3:0AD8 (in fn1CD3_0004)
;;     1CD3:101C (in fn1CD3_0004)
fn1631_1FDF proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[55B0h]
	mov	ax,es:[4600h]
	mov	[bp-4h],ax
	mov	ax,3h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	mov	es,[55C2h]
	mov	word ptr es:[3748h],0h
	mov	es,[55C4h]
	mov	word ptr es:[374Eh],9h
	mov	ax,32DAh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0800h:28A2h
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	es,[558Eh]
	push	word ptr es:[0D372h]
	push	word ptr es:[0D370h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	mov	[bp-2h],ax
	jmp	2070h

l1631_2060:
	mov	bx,[bp-2h]
	inc	word ptr [bp-2h]
	mov	es,[55C6h]
	mov	byte ptr es:[bx+12h],20h

l1631_2070:
	cmp	word ptr [bp-2h],0Ah
	jl	2060h

l1631_2076:
	mov	bx,[bp-2h]
	mov	es,[55C6h]
	mov	byte ptr es:[bx+12h],0h
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[55C8h]
	mov	word ptr es:[37FEh],0Fh
	push	word ptr [bp-4h]
