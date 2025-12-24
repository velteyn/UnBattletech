;;; Segment 1CD3 (1CD3:0000)
1CD3:0000 8B E5 5D CB                                     ..].            

;; fn1CD3_0004: 1CD3:0004
;;   Called from:
;;     0800:37BE (in fn0800_378D)
;;     0800:384B (in fn0800_378D)
;;     0800:3875 (in fn0800_378D)
;;     0FDC:00C7 (in fn0FDC_0008)
;;     0FDC:02E1 (in fn0FDC_01C0)
;;     11B8:025A (in fn11B8_0002)
;;     11B8:0384 (in fn11B8_0002)
;;     11B8:04B0 (in fn11B8_0002)
;;     11B8:064D (in fn11B8_0002)
;;     11B8:089A (in fn11B8_080A)
;;     1431:006B (in fn1431_000A)
;;     1CD3:0B2A (in fn1CD3_0004)
;;     1CD3:0FAC (in fn1CD3_0004)
fn1CD3_0004 proc
	push	bp
	mov	bp,sp
	mov	ax,34h
	call	far 207Fh:2FDCh
	push	di
	push	si
	mov	ax,[bp+6h]
	sub	ax,1h
	cmp	ax,2Eh
	jbe	001Fh

l1CD3_001C:
	jmp	17C0h

l1CD3_001F:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+1762h]

l1CD3_0027:
	mov	word ptr [bp-12h],2F0h
	mov	word ptr [bp-10h],2FE8h
	mov	es,[569Ch]
	mov	byte ptr es:[0D55Eh],0h
	mov	es,[569Eh]
	cmp	byte ptr es:[0D30Eh],0h
	jz	0071h

l1CD3_0047:
	mov	es,[569Ch]
	mov	byte ptr es:[0D55Eh],92h
	mov	word ptr [bp-12h],36Dh
	mov	word ptr [bp-10h],2FE8h
	mov	es,[569Eh]
	cmp	byte ptr es:[0D30Eh],2h
	jnz	0071h

l1CD3_0067:
	mov	word ptr [bp-12h],4E4h
	mov	word ptr [bp-10h],2FE8h

l1CD3_0071:
	mov	byte ptr es:[0C620h],0h
	mov	word ptr [bp-16h],0h

l1CD3_007C:
	les	bx,[bp-12h]
	inc	word ptr [bp-12h]
	mov	al,es:[bx]
	mov	bx,[bp-16h]
	mov	es,[569Eh]
	mov	es:[bx+0C724h],al
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],7Dh
	jl	007Ch

l1CD3_009A:
	mov	byte ptr es:[0C79Dh],0h
	mov	es,[56A0h]
	cmp	word ptr es:[3938h],0h
	jnz	00B8h

l1CD3_00AC:
	sub	ax,ax
	push	ax
	push	ax
	call	far 0800h:48B7h
	add	sp,4h

l1CD3_00B8:
	mov	es,[56A2h]
	mov	word ptr es:[0A44Dh],0C04Fh
	mov	es,[56A4h]
	mov	word ptr es:[01F6h],280h
	mov	word ptr es:[01F8h],2FE8h
	mov	es,[56A6h]
	mov	word ptr es:[0A44Bh],0C3Ch
	jmp	013Ch

l1CD3_00E2:
	inc	word ptr [bp-1Ch]

l1CD3_00E5:
	cmp	word ptr [bp-1Ch],6h
	jge	0133h

l1CD3_00EB:
	call	far 0800h:240Bh
	mov	es,[56A2h]
	push	word ptr es:[0A44Dh]
	mov	es,[56A6h]
	push	word ptr es:[0A44Bh]
	call	far 207Fh:1314h
	add	sp,4h
	call	far 207Fh:18EFh
	call	far 0800h:051Bh
	call	far 1F3Dh:06C3h
	mov	es,[56AAh]
	cmp	word ptr es:[3FF4h],8h
	jle	00E2h

l1CD3_0125:
	mov	ax,3h
	push	ax
	call	far 1F3Dh:0006h
	add	sp,2h
	jmp	00E2h

l1CD3_0133:
	mov	es,[56A6h]
	inc	word ptr es:[0A44Bh]

l1CD3_013C:
	cmp	word ptr es:[0A44Bh],0C40h
	jnc	015Fh

l1CD3_0145:
	sub	ax,ax
	push	ax
	call	far 0800h:1732h
	add	sp,2h
	mov	es,[56A8h]
	mov	es:[409Ah],al
	mov	word ptr [bp-1Ch],0h
	jmp	00E5h

l1CD3_015F:
	sub	ax,ax
	push	ax
	call	far 0800h:1732h
	add	sp,2h
	mov	es,[56A8h]
	mov	es:[409Ah],al
	mov	es,[569Eh]
	mov	al,es:[0D30Ch]
	cbw
	push	ax
	call	far 0FDCh:0629h

l1CD3_0181:
	add	sp,2h
	jmp	17C0h

l1CD3_0187:
	mov	es,[569Eh]
	cmp	byte ptr es:[0C724h],4Ch
	jnz	0198h

l1CD3_0193:
	mov	ax,48B3h
	jmp	01B5h

l1CD3_0198:
	cmp	byte ptr es:[0C724h],57h
	jnz	01A5h

l1CD3_01A0:
	mov	ax,48DFh
	jmp	01A8h

l1CD3_01A5:
	mov	ax,48E4h

l1CD3_01A8:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,48EEh

l1CD3_01B5:
	push	ds
	push	ax

l1CD3_01B7:
	call	far 1E56h:03F5h

l1CD3_01BC:
	add	sp,4h
	jmp	17C0h

l1CD3_01C2:
	mov	es,[569Eh]
	mov	byte ptr es:[0C724h],0FFh
	mov	byte ptr es:[0C620h],8h
	mov	es,[56A6h]
	mov	word ptr es:[0A44Bh],0C2Eh
	mov	es,[56A2h]
	mov	word ptr es:[0A44Dh],0C076h
	mov	es,[569Eh]
	cmp	byte ptr es:[0D310h],0h
	jz	01F7h

l1CD3_01F4:
	jmp	17C0h

l1CD3_01F7:
	mov	word ptr [bp-18h],0h

l1CD3_01FC:
	mov	bx,[bp-18h]
	mov	es,[569Eh]
	mov	al,es:[bx+0D457h]
	and	al,7Eh
	cmp	al,7Ch
	jnz	0225h

l1CD3_020E:
	sub	al,al
	mov	es:[bx+0D4D7h],al
	mov	bx,[bp-18h]
	mov	es:[bx+0D497h],al
	mov	bx,[bp-18h]
	mov	es:[bx+0D457h],al

l1CD3_0225:
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],40h
	jl	01FCh

l1CD3_022E:
	jmp	17C0h

l1CD3_0231:
	mov	word ptr [bp-1Eh],0h
	jmp	023Bh

l1CD3_0238:
	inc	word ptr [bp-1Eh]

l1CD3_023B:
	cmp	word ptr [bp-1Eh],3h
	jl	0244h

l1CD3_0241:
	jmp	17C0h

l1CD3_0244:
	mov	bx,[bp-1Eh]
	mov	es,[569Eh]
	mov	al,7Dh
	imul	byte ptr es:[bx+0C618h]
	add	ax,4Bh
	mov	[bp-2Eh],ax
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-2Eh]
	call	far 207Fh:3BB6h
	add	sp,8h
	sub	ax,ax
	push	ax
	mov	ax,0Ah
	push	ax
	mov	ax,[bp-1Eh]
	add	ax,5h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	sub	ax,27h
	neg	ax
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	jmp	0238h

l1CD3_02A5:
	mov	ax,491Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[569Eh]
	mov	al,es:[0D314h]
	cbw
	mov	bx,ax
	mov	al,es:[bx+0C618h]
	cbw
	mov	[bp-14h],ax
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+4EA4h]
	push	word ptr [bx+4EA2h]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[569Eh]
	mov	al,es:[0D314h]
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+4EB8h]
	push	word ptr [bx+4EB6h]
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-14h],4h
	jnz	031Bh

l1CD3_0301:
	mov	ax,4948h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l1CD3_030E:
	mov	es,[569Eh]
	mov	byte ptr es:[0D315h],0h
	jmp	17C0h

l1CD3_031B:
	mov	es,[569Eh]
	mov	al,es:[0D314h]
	cbw
	mov	bx,ax
	mov	al,7Dh
	imul	byte ptr es:[bx+0C618h]
	add	ax,4Bh
	mov	[bp-2Eh],ax
	cwd
	cmp	dx,es:[0D372h]
	ja	0367h

l1CD3_033B:
	jc	0344h

l1CD3_033D:
	cmp	ax,es:[0D370h]
	ja	0367h

l1CD3_0344:
	mov	byte ptr es:[0D315h],1h
	mov	al,es:[0D314h]
	cbw
	mov	bx,ax
	inc	byte ptr es:[bx+0C618h]
	mov	ax,[bp-2Eh]
	cwd
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	jmp	0961h

l1CD3_0367:
	mov	ax,4999h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	push	cs
	call	1809h
	jmp	030Eh

l1CD3_037A:
	mov	word ptr [bp-30h],2h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	038Eh

l1CD3_038B:
	dec	word ptr [bp-30h]

l1CD3_038E:
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	es,[569Eh]
	push	word ptr es:[0D372h]
	push	word ptr es:[0D370h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	sub	ax,ax
	push	ax
	push	word ptr [bp-30h]
	mov	ax,1h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	sub	ax,27h
	neg	ax
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	es,[56AEh]
	mov	word ptr es:[0E482h],0h
	mov	word ptr [bp-1Eh],0h

l1CD3_03F0:
	mov	si,[bp-1Eh]
	mov	cl,2h
	shl	si,cl
	mov	es,[569Eh]
	mov	ax,es:[si+0D374h]
	or	ax,es:[si+0D376h]
	jnz	040Ah

l1CD3_0407:
	jmp	048Ch

l1CD3_040A:
	mov	es,[56B0h]
	mov	word ptr es:[37FEh],0Fh
	push	word ptr [si+4E80h]
	push	word ptr [si+4E7Eh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[569Eh]
	push	word ptr es:[bx+0D376h]
	push	word ptr es:[bx+0D374h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	sub	ax,ax
	push	ax
	push	word ptr [bp-30h]
	mov	es,[56B2h]
	push	word ptr es:[374Eh]
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	sub	ax,27h
	neg	ax
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	es,[56AEh]
	inc	word ptr es:[0E482h]

l1CD3_048C:
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],3h
	jge	0498h

l1CD3_0495:
	jmp	03F0h

l1CD3_0498:
	mov	es,[56AEh]
	cmp	word ptr es:[0E482h],0h
	jz	04A7h

l1CD3_04A4:
	jmp	17C0h

l1CD3_04A7:
	mov	ax,49D3h
	jmp	01B5h

l1CD3_04AD:
	mov	es,[56AEh]
	cmp	word ptr es:[0E482h],0h
	jnz	04BFh

l1CD3_04B9:
	mov	ax,49D9h
	jmp	01B5h

l1CD3_04BF:
	call	far 1E56h:0388h
	mov	ax,49F6h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-1Eh],0h

l1CD3_04D6:
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+4E80h]
	push	word ptr [bx+4E7Eh]
	call	far 1E56h:03F5h
	add	sp,4h
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],3h
	jl	04D6h

l1CD3_04F6:
	mov	ax,7h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-1Eh],ax
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[569Eh]
	mov	ax,es:[bx+0D374h]
	or	ax,es:[bx+0D376h]
	jnz	051Eh

l1CD3_051B:
	jmp	071Fh

l1CD3_051E:
	mov	ax,4A09h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,17h
	push	ax
	mov	es,[56B4h]
	push	word ptr es:[39A0h]
	mov	ax,4A1Ch
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	word ptr [bp-30h],2h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	0560h

l1CD3_055D:
	dec	word ptr [bp-30h]

l1CD3_0560:
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[569Eh]
	push	word ptr es:[bx+0D376h]
	push	word ptr es:[bx+0D374h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	sub	ax,ax
	push	ax
	push	word ptr [bp-30h]
	mov	ax,17h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	sub	ax,27h
	neg	ax
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	call	far 1543h:0CDEh
	mov	[bp-22h],ax
	mov	[bp-20h],dx
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[569Eh]
	mov	ax,es:[bx+0D374h]
	mov	dx,es:[bx+0D376h]
	mov	[bp-34h],ax
	mov	[bp-32h],dx
	cmp	[bp-20h],dx
	jc	0604h

l1CD3_05E4:
	ja	05EBh

l1CD3_05E6:
	cmp	[bp-22h],ax
	jbe	0604h

l1CD3_05EB:
	mov	ax,[bp-34h]
	mov	dx,[bp-32h]
	mov	[bp-22h],ax
	mov	[bp-20h],dx
	mov	ax,4A2Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l1CD3_0604:
	mov	ax,[bp-22h]
	or	ax,[bp-20h]
	jnz	060Fh

l1CD3_060C:
	jmp	070Ah

l1CD3_060F:
	mov	ax,4A6Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-20h]
	push	word ptr [bp-22h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	mov	es,[56B0h]
	mov	word ptr es:[37FEh],2h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	0658h

l1CD3_064D:
	mov	es,[56B0h]
	mov	word ptr es:[37FEh],1h

l1CD3_0658:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4A86h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+4E80h]
	push	word ptr [bx+4E7Eh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4A8Dh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-22h]
	mov	dx,[bp-20h]
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[569Eh]
	sub	es:[bx+0D374h],ax
	sbb	es:[bx+0D376h],dx
	mov	ax,[bp-22h]
	mov	dx,[bp-20h]
	add	es:[0D370h],ax
	adc	es:[0D372h],dx
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr es:[bx+0D376h]
	push	word ptr es:[bx+0D374h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	mov	es,[56B0h]
	mov	ax,[bp-30h]
	mov	es:[37FEh],ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4ABCh
	jmp	0957h

l1CD3_070A:
	mov	ax,4AC0h

l1CD3_070D:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 0FDCh:19E1h
	jmp	17C0h

l1CD3_071F:
	mov	ax,4ACBh
	jmp	01B5h

l1CD3_0725:
	mov	es,[569Eh]
	mov	ax,es:[0D370h]
	or	ax,es:[0D372h]
	jnz	073Ah

l1CD3_0734:
	mov	ax,4AF5h
	jmp	01B5h

l1CD3_073A:
	call	far 1E56h:0388h
	mov	ax,4B3Bh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	word ptr [bp-1Eh],0h

l1CD3_0751:
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+4E80h]
	push	word ptr [bx+4E7Eh]
	call	far 1E56h:03F5h
	add	sp,4h
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],3h
	jl	0751h

l1CD3_0771:
	mov	ax,7h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp-1Eh],ax
	mov	ax,4B52h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	sub	ax,ax
	push	ax
	mov	ax,0Fh
	push	ax
	mov	ax,17h
	push	ax
	mov	es,[56B4h]
	push	word ptr es:[39A0h]
	mov	ax,4B67h
	push	ds
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	mov	word ptr [bp-30h],2h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	07C2h

l1CD3_07BF:
	dec	word ptr [bp-30h]

l1CD3_07C2:
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	es,[569Eh]
	push	word ptr es:[0D372h]
	push	word ptr es:[0D370h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	sub	ax,ax
	push	ax
	push	word ptr [bp-30h]
	mov	ax,17h
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 207Fh:3B9Eh
	add	sp,4h
	sub	ax,27h
	neg	ax
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	call	far 1543h:0CDEh
	mov	[bp-22h],ax
	mov	[bp-20h],dx
	mov	es,[569Eh]
	mov	ax,es:[0D370h]
	mov	dx,es:[0D372h]
	cmp	[bp-20h],dx
	jc	0854h

l1CD3_0831:
	ja	0838h

l1CD3_0833:
	cmp	[bp-22h],ax
	jbe	0854h

l1CD3_0838:
	mov	ax,es:[0D370h]
	mov	dx,es:[0D372h]
	mov	[bp-22h],ax
	mov	[bp-20h],dx
	mov	ax,4B77h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l1CD3_0854:
	mov	ax,[bp-22h]
	or	ax,[bp-20h]
	jnz	085Fh

l1CD3_085C:
	jmp	0969h

l1CD3_085F:
	mov	ax,4BB8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	push	word ptr [bp-20h]
	push	word ptr [bp-22h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	mov	es,[56B0h]
	mov	word ptr es:[37FEh],2h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	08A8h

l1CD3_089D:
	mov	es,[56B0h]
	mov	word ptr es:[37FEh],1h

l1CD3_08A8:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4BD8h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr [bx+4E80h]
	push	word ptr [bx+4E7Eh]
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4BDFh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,[bp-22h]
	mov	dx,[bp-20h]
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	mov	es,[569Eh]
	add	es:[bx+0D374h],ax
	adc	es:[bx+0D376h],dx
	mov	ax,[bp-22h]
	mov	dx,[bp-20h]
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	bx,[bp-1Eh]
	shl	bx,1h
	shl	bx,1h
	push	word ptr es:[bx+0D376h]
	push	word ptr es:[bx+0D374h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	mov	es,[56B0h]
	mov	ax,[bp-30h]
	mov	es:[37FEh],ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4C07h

l1CD3_0957:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h

l1CD3_0961:
	call	far 1631h:1FDFh
	jmp	17C0h

l1CD3_0969:
	mov	ax,4C0Bh
	jmp	070Dh

l1CD3_096F:
	mov	ax,0Ah
	push	ax
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	mov	es,[569Eh]
	push	word ptr es:[0D372h]
	push	word ptr es:[0D370h]
	call	far 207Fh:3BD2h
	add	sp,0Ah
	mov	es,[56B0h]
	mov	word ptr es:[37FEh],2h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	09B1h

l1CD3_09A8:
	mov	es,[56B0h]
	dec	word ptr es:[37FEh]

l1CD3_09B1:
	mov	ax,12h
	mov	dx,3092h
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4C18h
	jmp	01B5h

l1CD3_09C7:
	mov	es,[56B6h]
	mov	ax,es:[0178h]
	mov	[bp+6h],ax
	mov	es,[569Eh]
	cmp	byte ptr es:[0D316h],0h
	jz	09E9h

l1CD3_09DE:
	mov	es,[56B6h]
	mov	ax,es:[0168h]
	mov	[bp+6h],ax

l1CD3_09E9:
	mov	es,[569Eh]
	mov	byte ptr es:[0D317h],0h
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+4F26h]
	mov	dx,[bx+4F28h]
	mov	[bp-34h],ax
	mov	[bp-32h],dx
	cmp	es:[0D372h],dx
	jnc	0A12h

l1CD3_0A0F:
	jmp	17C0h

l1CD3_0A12:
	ja	0A1Eh

l1CD3_0A14:
	cmp	es:[0D370h],ax
	jnc	0A1Eh

l1CD3_0A1B:
	jmp	17C0h

l1CD3_0A1E:
	mov	ax,[bp-34h]
	mov	dx,[bp-32h]
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	mov	byte ptr es:[0D317h],1h
	call	far 1631h:1FDFh
	mov	bx,[bp+6h]
	mov	al,[bx+4DDBh]
	cbw
	push	ax
	push	bx
	call	far 0FDCh:13DEh
	jmp	01BCh

l1CD3_0A4B:
	mov	es,[56B6h]
	mov	ax,es:[0198h]
	mov	[bp+6h],ax
	mov	es,[569Eh]
	cmp	byte ptr es:[0D318h],6h
	jnz	0A70h

l1CD3_0A62:
	mov	es,[56B6h]
	mov	ax,es:[01A8h]
	add	ax,6h
	mov	[bp+6h],ax

l1CD3_0A70:
	mov	es,[569Eh]
	cmp	byte ptr es:[0D318h],9h
	jnz	0A8Ah

l1CD3_0A7C:
	mov	es,[56B6h]
	mov	ax,es:[01B8h]
	add	ax,9h
	mov	[bp+6h],ax

l1CD3_0A8A:
	dec	word ptr [bp+6h]
	mov	es,[569Eh]
	mov	byte ptr es:[0D317h],0h
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+4F44h]
	mov	dx,[bx+4F46h]
	mov	[bp-34h],ax
	mov	[bp-32h],dx
	cmp	es:[0D372h],dx
	jnc	0AB6h

l1CD3_0AB3:
	jmp	17C0h

l1CD3_0AB6:
	ja	0AC2h

l1CD3_0AB8:
	cmp	es:[0D370h],ax
	jnc	0AC2h

l1CD3_0ABF:
	jmp	17C0h

l1CD3_0AC2:
	mov	ax,[bp-34h]
	mov	dx,[bp-32h]
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	mov	byte ptr es:[0D317h],1h
	call	far 1631h:1FDFh
	mov	ax,[bp+6h]
	inc	ax
	push	ax
	call	far 0FDCh:15E6h
	jmp	0181h

l1CD3_0AEA:
	call	far 0FDCh:17B9h
	jmp	17C0h

l1CD3_0AF2:
	mov	es,[569Eh]
	mov	byte ptr es:[0D31Ah],0h
	mov	word ptr [bp+6h],1h
	jmp	0B06h

l1CD3_0B03:
	inc	word ptr [bp+6h]

l1CD3_0B06:
	cmp	word ptr [bp+6h],8h
	jl	0B0Fh

l1CD3_0B0C:
	jmp	17C0h

l1CD3_0B0F:
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	cmp	byte ptr es:[bx+0C614h],0FFh
	jz	0B03h

l1CD3_0B1F:
	inc	byte ptr es:[0D31Ah]
	jmp	0B03h

l1CD3_0B26:
	mov	ax,0Eh
	push	ax
	push	cs
	call	0004h
	add	sp,2h
	mov	word ptr [bp-1Eh],0h

l1CD3_0B36:
	mov	si,[bp-1Eh]
	mov	byte ptr [bp+si-8h],0h
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],8h
	jl	0B36h

l1CD3_0B46:
	mov	es,[56B2h]
	mov	ax,es:[374Eh]
	mov	es,[56B6h]
	mov	es:[0202h],ax
	mov	es,[569Eh]
	mov	al,es:[0D31Ah]
	cbw
	inc	ax
	mov	es,[56B6h]
	mov	es:[0206h],ax
	sub	ax,ax
	mov	[bp-1Eh],ax
	mov	es:[0208h],ax
	mov	[bp+6h],ax

l1CD3_0B74:
	mov	ax,11h
	imul	word ptr [bp+6h]
	mov	bx,ax
	mov	es,[569Eh]
	mov	al,es:[bx+0C614h]
	mov	[bp-34h],al
	cmp	al,0FFh
	jz	0BB9h

l1CD3_0B8C:
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[56B8h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	call	far 1E56h:03F5h
	add	sp,4h
	push	cs
	call	181Eh
	mov	si,[bp-1Eh]
	inc	word ptr [bp-1Eh]
	mov	al,[bp+6h]
	mov	[bp+si-8h],al

l1CD3_0BB9:
	inc	word ptr [bp+6h]
	cmp	word ptr [bp+6h],8h
	jl	0B74h

l1CD3_0BC2:
	mov	ax,17h
	push	ax
	call	far 1E56h:0B5Eh
	add	sp,2h
	mov	[bp+6h],ax
	mov	es,[569Eh]
	mov	si,ax
	mov	al,[bp+si-8h]
	mov	es:[0D31Ah],al
	jmp	17C0h

l1CD3_0BE1:
	mov	es,[569Eh]
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	mov	al,es:[bx+0C624h]
	and	al,1h

l1CD3_0BF5:
	mov	es:[0D31Bh],al
	jmp	17C0h

l1CD3_0BFC:
	mov	es,[569Eh]
	cmp	word ptr es:[0D372h],0h
	jnz	0C11h

l1CD3_0C08:
	cmp	word ptr es:[0D370h],1F4h
	jc	0C3Dh

l1CD3_0C11:
	sub	word ptr es:[0D370h],1F4h
	sbb	word ptr es:[0D372h],0h
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	inc	byte ptr es:[bx+0C61Dh]
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	or	byte ptr es:[bx+0C624h],1h
	jmp	0C9Bh

l1CD3_0C3D:
	mov	byte ptr es:[0D31Ah],0h
	jmp	17C0h

l1CD3_0C46:
	mov	es,[569Eh]
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	mov	al,es:[bx+0C624h]
	and	al,2h
	jmp	0BF5h

l1CD3_0C5C:
	mov	es,[569Eh]
	cmp	word ptr es:[0D372h],0h
	jnz	0C71h

l1CD3_0C68:
	cmp	word ptr es:[0D370h],1F4h
	jc	0C3Dh

l1CD3_0C71:
	sub	word ptr es:[0D370h],1F4h
	sbb	word ptr es:[0D372h],0h
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	inc	byte ptr es:[bx+0C61Eh]
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	or	byte ptr es:[bx+0C624h],2h

l1CD3_0C9B:
	mov	byte ptr es:[0D31Ah],1h
	jmp	0961h

l1CD3_0CA4:
	mov	es,[569Eh]
	mov	byte ptr es:[0D31Ch],0h
	mov	word ptr [bp-1Eh],0h
	jmp	0CB8h

l1CD3_0CB5:
	inc	word ptr [bp-1Eh]

l1CD3_0CB8:
	cmp	word ptr [bp-1Eh],4h
	jl	0CC1h

l1CD3_0CBE:
	jmp	17C0h

l1CD3_0CC1:
	mov	ax,7Dh
	imul	word ptr [bp-1Eh]
	mov	bx,ax
	cmp	byte ptr es:[bx+0C724h],0FFh
	jz	0CB5h

l1CD3_0CD1:
	inc	byte ptr es:[0D31Ch]
	jmp	0CB5h

l1CD3_0CD8:
	call	far 11B8h:0002h
	jmp	17C0h

l1CD3_0CE0:
	call	far 11B8h:1762h
	jmp	17C0h

l1CD3_0CE8:
	call	far 11B8h:080Ah
	jmp	17C0h

l1CD3_0CF0:
	call	far 11B8h:0925h
	jmp	17C0h

l1CD3_0CF8:
	mov	es,[569Eh]
	mov	byte ptr es:[0D325h],0h
	mov	word ptr [bp-1Eh],0h
	jmp	0D0Ch

l1CD3_0D09:
	inc	word ptr [bp-1Eh]

l1CD3_0D0C:
	cmp	word ptr [bp-1Eh],8h
	jl	0D15h

l1CD3_0D12:
	jmp	17C0h

l1CD3_0D15:
	mov	ax,11h
	imul	word ptr [bp-1Eh]
	mov	si,ax
	mov	es,[569Eh]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	0D09h

l1CD3_0D29:
	mov	al,es:[si+0C623h]
	cbw
	mov	cx,ax
	mov	al,0Ah
	imul	byte ptr es:[si+0C615h]
	cmp	ax,cx
	jz	0D09h

l1CD3_0D3C:
	mov	byte ptr es:[0D325h],1h
	jmp	0D09h

l1CD3_0D44:
	mov	es,[569Eh]
	cmp	byte ptr es:[0D326h],0h
	jz	0DB7h

l1CD3_0D50:
	mov	al,es:[0D326h]
	cbw
	mov	si,ax
	mov	bx,si
	shl	bx,1h
	mov	ax,[bx+4F6Eh]
	cwd
	mov	[bp-34h],ax
	mov	[bp-32h],dx
	cmp	es:[0D372h],dx
	jc	0D92h

l1CD3_0D6D:
	ja	0D76h

l1CD3_0D6F:
	cmp	es:[0D370h],ax
	jc	0D92h

l1CD3_0D76:
	mov	ax,[bp-34h]
	mov	dx,[bp-32h]
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	push	si
	call	far 1431h:000Ah
	add	sp,2h
	jmp	0961h

l1CD3_0D92:
	push	cs
	call	181Eh
	push	cs
	call	1809h
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	mov	es,[569Eh]
	add	word ptr es:[0D370h],19h
	adc	word ptr es:[0D372h],0h
	jmp	0961h

l1CD3_0DB7:
	sub	ax,ax
	push	ax
	call	far 1431h:000Ah
	jmp	0181h

l1CD3_0DC2:
	mov	es,[569Eh]
	mov	byte ptr es:[0D450h],1h
	jmp	17C0h

l1CD3_0DCF:
	mov	es,[569Eh]
	mov	byte ptr es:[0D451h],1h
	jmp	17C0h

l1CD3_0DDC:
	mov	word ptr [bp-18h],0h
	jmp	0DE6h

l1CD3_0DE3:
	inc	word ptr [bp-18h]

l1CD3_0DE6:
	cmp	word ptr [bp-18h],4h
	jl	0DEFh

l1CD3_0DEC:
	jmp	17C0h

l1CD3_0DEF:
	mov	ax,7Dh
	imul	word ptr [bp-18h]
	mov	bx,ax
	mov	es,[569Eh]
	mov	al,es:[bx+0C724h]
	mov	bx,[bp-18h]
	mov	es:[bx+0D452h],al
	mov	ax,7Dh
	imul	word ptr [bp-18h]
	mov	bx,ax
	mov	byte ptr es:[bx+0C724h],0FFh
	mov	ax,11h
	imul	word ptr [bp-18h]
	mov	si,ax
	mov	al,8h
	mov	es:[si+0C664h],al
	mov	es:[si+0C620h],al
	jmp	0DE3h

l1CD3_0E2C:
	mov	word ptr [bp-18h],0h

l1CD3_0E31:
	mov	bx,[bp-18h]
	mov	es,[569Eh]
	mov	al,es:[bx+0D452h]
	mov	cx,ax
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],4h
	jl	0E31h

l1CD3_0E54:
	mov	word ptr [bp-18h],0h

l1CD3_0E59:
	mov	bx,[bp-18h]
	mov	es,[569Ch]
	mov	byte ptr es:[bx+0D55Eh],0h
	mov	ax,7Dh
	imul	word ptr [bp-18h]
	mov	bx,ax
	mov	es,[569Eh]
	cmp	byte ptr es:[bx+0C724h],4Ch
	jz	0E87h

l1CD3_0E7A:
	mov	bx,[bp-18h]
	mov	es,[569Ch]
	mov	byte ptr es:[bx+0D55Eh],92h

l1CD3_0E87:
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],4h
	jl	0E59h

l1CD3_0E90:
	sub	ax,ax

l1CD3_0E92:
	push	ax
	call	far 1467h:0002h
	jmp	0181h

l1CD3_0E9B:
	mov	es,[569Eh]
	mov	byte ptr es:[0D31Ch],0h
	mov	word ptr [bp-1Eh],0h
	jmp	0EAFh

l1CD3_0EAC:
	inc	word ptr [bp-1Eh]

l1CD3_0EAF:
	cmp	word ptr [bp-1Eh],4h
	jl	0EB8h

l1CD3_0EB5:
	jmp	17C0h

l1CD3_0EB8:
	mov	bx,[bp-1Eh]
	cmp	byte ptr es:[bx+0D452h],41h
	jl	0EACh

l1CD3_0EC3:
	cmp	byte ptr es:[bx+0D452h],5Ah
	jg	0EACh

l1CD3_0ECB:
	inc	byte ptr es:[0D31Ch]
	jmp	0EACh

l1CD3_0ED2:
	call	far 11B8h:104Eh
	jmp	17C0h

l1CD3_0EDA:
	mov	es,[569Eh]
	mov	al,11h
	imul	byte ptr es:[0D31Ah]
	mov	bx,ax
	mov	al,es:[bx+0C621h]
	mov	es:[0D32Bh],al
	jmp	17C0h

l1CD3_0EF3:
	mov	es,[569Eh]
	mov	al,es:[0D31Ah]
	cbw
	mov	[bp-2Ah],ax
	mov	ax,11h
	imul	word ptr [bp-2Ah]
	mov	si,ax
	mov	al,es:[si+0C621h]
	cbw
	dec	ax
	mov	[bp-0Ah],ax
	mov	al,es:[si+0C622h]
	cbw
	mov	[bp-26h],ax
	mov	bx,[bp-0Ah]
	mov	al,[bx+4DDCh]
	cbw
	cmp	ax,[bp-26h]
	jnz	0F3Ch

l1CD3_0F27:
	mov	ax,4C1Ch

l1CD3_0F2A:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:0259h
	jmp	17C0h

l1CD3_0F3C:
	mov	ax,4C60h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-0Ah]
	mov	al,[bx+4DDCh]
	cbw
	sub	ax,[bp-26h]
	mov	[bp-0Ch],ax
	cmp	word ptr [bp-26h],0h
	jnz	0F62h

l1CD3_0F5D:
	mov	ax,4C75h
	jmp	0F70h

l1CD3_0F62:
	push	word ptr [bp-0Ch]
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,4C79h

l1CD3_0F70:
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4C81h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	bx,[bp-0Ah]
	mov	al,[bx+4F3Eh]
	cbw
	imul	word ptr [bp-0Ch]
	push	ax
	call	far 1F3Dh:0053h
	add	sp,2h
	mov	ax,4CAEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,0Ah
	push	ax
	push	cs
	call	0004h
	add	sp,2h
	mov	ax,4CD3h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jnz	0FD3h

l1CD3_0FD0:
	jmp	17C0h

l1CD3_0FD3:
	mov	word ptr [bp-2Ch],0h
	jmp	1021h

l1CD3_0FDA:
	mov	bx,[bp-0Ah]
	mov	al,[bx+4F3Eh]
	cbw
	cwd
	mov	es,[569Eh]
	cmp	dx,es:[0D372h]
	ja	1027h

l1CD3_0FEE:
	jc	0FF7h

l1CD3_0FF0:
	cmp	ax,es:[0D370h]
	ja	1027h

l1CD3_0FF7:
	mov	word ptr [bp-2Ch],1h
	dec	word ptr [bp-0Ch]
	mov	al,[bx+4F3Eh]
	cbw
	cwd
	sub	es:[0D370h],ax
	sbb	es:[0D372h],dx
	mov	ax,11h
	imul	word ptr [bp-2Ah]
	mov	bx,ax
	inc	byte ptr es:[bx+0C622h]
	call	far 1631h:1FDFh

l1CD3_1021:
	cmp	word ptr [bp-0Ch],0h
	jnz	0FDAh

l1CD3_1027:
	cmp	word ptr [bp-0Ch],0h
	jz	104Ch

l1CD3_102D:
	mov	ax,4CEEh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	cmp	word ptr [bp-2Ch],0h
	jz	1046h

l1CD3_1040:
	mov	ax,4D14h
	jmp	0F2Ah

l1CD3_1046:
	mov	ax,4D4Fh
	jmp	0F2Ah

l1CD3_104C:
	mov	ax,4D67h
	jmp	0F2Ah

l1CD3_1052:
	call	far 0FDCh:1C9Bh
	jmp	17C0h

l1CD3_105A:
	call	far 0FDCh:1A26h
	jmp	17C0h

l1CD3_1062:
	mov	es,[569Ch]
	mov	byte ptr es:[0D55Eh],0h
	mov	es,[569Eh]
	cmp	byte ptr es:[0C79Fh],0h
	jz	1082h

l1CD3_1078:
	mov	es,[569Ch]
	mov	byte ptr es:[0D55Eh],92h

l1CD3_1082:
	mov	es,[569Eh]
	mov	byte ptr es:[0C620h],0h
	mov	byte ptr es:[0C79Dh],0h
	sub	ax,ax
	push	ax
	push	ax
	call	far 0800h:48B7h
	add	sp,4h
	mov	es,[56A6h]
	mov	word ptr es:[0A44Bh],0A2Bh
	mov	es,[56A2h]
	mov	word ptr es:[0A44Dh],8057h
	mov	es,[56A4h]
	mov	word ptr es:[01F6h],2A0h
	mov	word ptr es:[01F8h],2FE8h
	sub	ax,ax
	push	ax
	call	far 0800h:1732h
	add	sp,2h
	mov	es,[56A8h]
	mov	es:[409Ah],al
	call	far 11B8h:137Fh
	mov	ax,8h
	push	ax
	call	far 0FDCh:0629h
	add	sp,2h
	mov	word ptr [bp-18h],0h

l1CD3_10EF:
	mov	bx,[bp-18h]
	mov	es,[569Eh]
	mov	al,es:[bx+0D457h]
	and	al,7Eh
	cmp	al,7Ch
	jnz	1120h

l1CD3_1101:
	cmp	byte ptr es:[bx+0D497h],8Ah
	jnz	1120h

l1CD3_1109:
	sub	al,al
	mov	es:[bx+0D4D7h],al
	mov	bx,[bp-18h]
	mov	es:[bx+0D497h],al
	mov	bx,[bp-18h]
	mov	es:[bx+0D457h],al

l1CD3_1120:
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],40h
	jl	10EFh

l1CD3_1129:
	mov	es,[56BAh]
	cmp	word ptr es:[014Ah],0h
	jnz	113Fh

l1CD3_1135:
	mov	es,[569Eh]
	mov	byte ptr es:[0D334h],1h

l1CD3_113F:
	mov	es,[569Eh]
	cmp	byte ptr es:[0D32Fh],0h
	jnz	116Eh

l1CD3_114B:
	call	far 11B8h:1441h
	call	far 0FDCh:1B41h
	mov	es,[56A6h]
	mov	word ptr es:[0A44Bh],0A39h
	mov	es,[56A2h]
	mov	word ptr es:[0A44Dh],805Dh
	jmp	138Ch

l1CD3_116E:
	mov	es,[56A6h]
	mov	word ptr es:[0A44Bh],970h
	mov	es,[56BCh]
	mov	ax,es:[4036h]
	mov	es,[56A2h]
	mov	es:[0A44Dh],ax
	mov	es,[56BEh]
	cmp	word ptr es:[406Ah],0h
	jnz	11A5h

l1CD3_1195:
	mov	es,[56BCh]
	mov	ax,es:[403Eh]
	mov	es,[56A2h]
	mov	es:[0A44Dh],ax

l1CD3_11A5:
	mov	word ptr [bp-1Eh],1h

l1CD3_11AA:
	mov	bx,[bp-1Eh]
	mov	es,[56C0h]
	mov	al,es:[bx+3FE9h]
	mov	cx,ax
	mov	ax,11h
	imul	bx
	mov	bx,ax
	mov	es,[569Eh]
	mov	es:[bx+0C614h],cl
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],8h
	jl	11AAh

l1CD3_11D1:
	mov	word ptr [bp-28h],1h
	mov	word ptr [bp-1Eh],0h

l1CD3_11DB:
	mov	bx,[bp-1Eh]
	mov	es,[569Eh]
	cmp	byte ptr es:[bx+0D452h],0FFh
	jz	11EFh

l1CD3_11EA:
	mov	word ptr [bp-28h],0h

l1CD3_11EF:
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],4h
	jl	11DBh

l1CD3_11F8:
	mov	word ptr [bp-1Eh],1h

l1CD3_11FD:
	cmp	word ptr [bp-28h],0h
	jnz	127Eh

l1CD3_1203:
	mov	bx,[bp-1Eh]
	mov	es,[569Eh]
	cmp	byte ptr es:[bx+0D452h],0FFh
	jnz	127Eh

l1CD3_1212:
	mov	word ptr [bp-28h],1h
	mov	word ptr [bp-18h],1h

l1CD3_121C:
	mov	bx,[bp-18h]
	mov	al,es:[bx+0D452h]
	mov	cx,ax
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],4h
	jl	121Ch

l1CD3_123B:
	mov	word ptr [bp-24h],0h

l1CD3_1240:
	mov	bx,[bp-24h]
	mov	es,[56C2h]
	mov	al,es:[bx+3780h]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-1Eh]
	mov	bx,ax
	add	bx,[bp-24h]
	mov	es,[569Eh]
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-24h]
	cmp	word ptr [bp-24h],7Dh
	jl	1240h

l1CD3_126B:
	mov	al,es:[0D452h]
	mov	cx,ax
	mov	ax,7Dh
	imul	word ptr [bp-1Eh]
	mov	bx,ax
	mov	es:[bx+0C724h],cl

l1CD3_127E:
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],4h
	jge	128Ah

l1CD3_1287:
	jmp	11FDh

l1CD3_128A:
	cmp	word ptr [bp-28h],0h
	jnz	12D7h

l1CD3_1290:
	mov	word ptr [bp-1Eh],0h

l1CD3_1295:
	mov	bx,[bp-1Eh]
	mov	es,[56C2h]
	mov	al,es:[bx+3780h]
	mov	es,[569Eh]
	mov	es:[bx+0C724h],al
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],7Dh
	jl	1295h

l1CD3_12B3:
	mov	word ptr [bp-1Eh],0h

l1CD3_12B8:
	mov	bx,[bp-1Eh]
	mov	al,es:[bx+0D452h]
	mov	cx,ax
	mov	ax,7Dh
	imul	bx
	mov	bx,ax
	mov	es:[bx+0C724h],cl
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],4h
	jl	12B8h

l1CD3_12D7:
	mov	ax,89h
	push	ax
	call	far 207Fh:104Eh
	add	sp,2h
	mov	word ptr [bp-0Eh],78h
	mov	word ptr [bp-1Ah],0h

l1CD3_12ED:
	mov	word ptr [bp-16h],0h

l1CD3_12F2:
	mov	bx,[bp-0Eh]
	add	bx,[bp-16h]
	mov	es,[56C4h]
	mov	al,es:[bx+30h]
	mov	[bp-34h],al
	or	al,al
	jz	131Ch

l1CD3_1308:
	cbw
	push	ax
	mov	ax,3h
	imul	word ptr [bp-1Ah]
	add	ax,[bp-16h]
	push	ax
	call	far 0800h:2DA8h
	add	sp,4h

l1CD3_131C:
	inc	word ptr [bp-16h]
	cmp	word ptr [bp-16h],3h
	jl	12F2h

l1CD3_1325:
	add	word ptr [bp-0Eh],10h
	inc	word ptr [bp-1Ah]
	cmp	word ptr [bp-1Ah],3h
	jl	12EDh

l1CD3_1332:
	call	far 207Fh:1DA8h
	sub	ax,ax
	push	ax
	call	far 1543h:0C72h
	add	sp,2h
	mov	word ptr [bp-1Eh],0h

l1CD3_1347:
	mov	ax,7Dh
	imul	word ptr [bp-1Eh]
	mov	si,ax
	mov	al,0FFh
	mov	bx,[bp-1Eh]
	mov	es,[569Eh]
	mov	es:[bx+0D452h],al
	mov	es:[si+0C79Eh],al
	mov	es:[si+0C79Dh],al
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],4h
	jl	1347h

l1CD3_1370:
	mov	word ptr [bp-1Eh],0h

l1CD3_1375:
	mov	ax,11h
	imul	word ptr [bp-1Eh]
	mov	bx,ax
	mov	byte ptr es:[bx+0C620h],8h
	inc	word ptr [bp-1Eh]
	cmp	word ptr [bp-1Eh],8h
	jl	1375h

l1CD3_138C:
	mov	es,[56C6h]
	mov	word ptr es:[0E48Eh],0h
	jmp	17C0h

l1CD3_139A:
	mov	es,[56BAh]
	mov	word ptr es:[014Ah],0h
	mov	es,[569Eh]
	mov	byte ptr es:[0C614h],0FFh
	jmp	17C0h

l1CD3_13B2:
	mov	es,[569Eh]
	mov	al,11h
	imul	byte ptr es:[0D331h]
	mov	bx,ax
	mov	al,es:[bx+0C614h]
	jmp	13CEh

l1CD3_13C6:
	mov	es,[569Eh]
	mov	al,es:[0D456h]

l1CD3_13CE:
	cbw
	mov	bx,ax
	shl	bx,1h
	shl	bx,1h
	mov	es,[56B8h]
	push	word ptr es:[bx+1CCh]
	push	word ptr es:[bx+1CAh]
	jmp	01B7h

l1CD3_13E6:
	mov	ax,1h
	jmp	0E92h

l1CD3_13EC:
	call	far 11B8h:152Fh
	mov	es,[56BAh]
	cmp	word ptr es:[014Ah],0h
	jz	1400h

l1CD3_13FD:
	jmp	17C0h

l1CD3_1400:
	mov	es,[569Eh]
	mov	byte ptr es:[0D334h],1h
	jmp	17C0h

l1CD3_140D:
	mov	es,[569Eh]
	cmp	byte ptr es:[0D31Ah],0h
	jz	1454h

l1CD3_1419:
	mov	word ptr [bp-18h],0h
	jmp	1423h

l1CD3_1420:
	inc	word ptr [bp-18h]

l1CD3_1423:
	mov	es,[569Eh]
	mov	al,es:[0D31Ah]
	cbw
	cmp	ax,[bp-18h]
	jl	14ABh

l1CD3_1431:
	mov	word ptr [bp-1Eh],0Dh
	cmp	word ptr [bp-18h],0h
	jz	1447h

l1CD3_143C:
	call	far 207Fh:0BC0h
	and	ax,1h
	sub	[bp-1Eh],ax

l1CD3_1447:
	push	word ptr [bp-1Eh]
	call	far 0FDCh:15E6h
	add	sp,2h
	jmp	1420h

l1CD3_1454:
	call	far 1E56h:0388h
	mov	ax,4D8Ah
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	es,[569Eh]
	mov	al,11h
	imul	byte ptr es:[0C61Fh]
	mov	bx,ax
	lea	ax,[bx+2ED8h]
	mov	dx,3EDBh
	push	dx
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,4DA4h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:1A13h
	add	sp,2h
	or	ax,ax
	jz	14ABh

l1CD3_14A1:
	mov	es,[569Eh]
	mov	byte ptr es:[0C61Fh],0Dh

l1CD3_14AB:
	mov	word ptr [bp-18h],0h
	jmp	14B5h

l1CD3_14B2:
	inc	word ptr [bp-18h]

l1CD3_14B5:
	cmp	word ptr [bp-18h],8h
	jl	14BEh

l1CD3_14BB:
	jmp	17C0h

l1CD3_14BE:
	mov	ax,11h
	imul	word ptr [bp-18h]
	mov	si,ax
	mov	es,[569Eh]
	cmp	byte ptr es:[si+0C614h],0FFh
	jz	14B2h

l1CD3_14D2:
	call	far 207Fh:0BC0h
	mov	cx,ax
	and	cx,1h
	add	cx,6h
	mov	es,[569Eh]
	mov	al,es:[si+0C615h]
	cbw
	imul	cx
	mov	[bp-1Eh],ax
	mov	ax,11h
	imul	word ptr [bp-18h]
	mov	bx,ax
	mov	al,es:[bx+0C623h]
	cbw
	cmp	ax,[bp-1Eh]
	jle	14B2h

l1CD3_1501:
	mov	al,[bp-1Eh]
	mov	cx,ax
	mov	ax,11h
	imul	word ptr [bp-18h]
	mov	bx,ax
	mov	es:[bx+0C623h],cl
	jmp	14B2h

l1CD3_1515:
	mov	word ptr [bp-18h],0h

l1CD3_151A:
	mov	ax,1Ah
	imul	word ptr [bp-18h]
	mov	si,ax
	mov	di,[bp-18h]
	shl	di,1h
	mov	es,[56A6h]
	mov	ax,es:[0A44Bh]
	mov	es,[56C8h]
	mov	es:[di+4024h],ax
	mov	es,[569Eh]
	mov	es:[si+0D390h],ax
	mov	es,[56A2h]
	mov	ax,es:[0A44Dh]
	mov	es,[56BCh]
	mov	es:[di+4056h],ax
	mov	es,[569Eh]
	mov	es:[si+0D392h],ax
	mov	al,[bp-18h]
	mov	es:[si+0D399h],al
	mov	byte ptr es:[si+0D398h],77h
	inc	word ptr [bp-18h]
	cmp	word ptr [bp-18h],8h
	jl	151Ah

l1CD3_1572:
	mov	es,[56A2h]
	inc	word ptr es:[0A44Dh]
	jmp	17C0h

l1CD3_157E:
	mov	es,[56CAh]
	mov	ax,es:[4572h]
	mov	es,[56C8h]
	mov	es:[4024h],ax
	mov	es,[569Eh]
	mov	es:[0D390h],ax
	mov	es,[56CCh]
	mov	ax,es:[45A4h]
	mov	es,[56BCh]
	mov	es:[4056h],ax
	mov	es,[569Eh]
	mov	es:[0D392h],ax
	mov	byte ptr es:[0D399h],0FFh
	mov	byte ptr es:[0D398h],70h
	mov	es,[56CAh]
	mov	ax,es:[4564h]
	mov	es,[569Eh]
	mov	es:[0D394h],ax
	mov	es,[56CCh]
	mov	ax,es:[4596h]
	mov	es,[569Eh]
	mov	es:[0D396h],ax
	jmp	17C0h

l1CD3_15DD:
	mov	ax,1F0h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	1605h

l1CD3_15F9:
	mov	ax,1h
	push	ax
	call	far 207Fh:0BA7h
	add	sp,2h

l1CD3_1605:
	mov	es,[56CEh]
	mov	word ptr es:[4FBCh],0h
	mov	ax,2h
	push	ax
	call	far 0800h:28CCh
	add	sp,2h
	mov	ax,4614h
	mov	dx,3092h
	push	dx
	push	ax
	mov	ax,4DBFh
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
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],2h
	jnz	1669h

l1CD3_1655:
	mov	ax,0A800h
	push	ax
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	call	far 207Fh:0260h
	add	sp,6h

l1CD3_1669:
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],3h
	jz	167Dh

l1CD3_1675:
	mov	ax,0h
	mov	dx,3058h
	jmp	1683h

l1CD3_167D:
	mov	ax,10h
	mov	dx,3058h

l1CD3_1683:
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
	mov	es,[56CEh]
	mov	word ptr es:[4FBCh],1h
	mov	ax,1B0h
	mov	dx,2FE8h
	push	dx
	push	ax
	call	far 207Fh:00D1h
	add	sp,4h
	mov	ax,244Bh
	mov	dx,246Ch
	push	dx
	push	ax
	mov	ax,4DCBh
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
	call	far 1F3Dh:086Ah
	call	far 1F3Dh:0259h
	call	far 207Fh:1FBEh
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],0h
	jnz	1717h

l1CD3_170C:
	sub	ax,ax
	push	ax
	call	far 207Fh:0BA7h
	add	sp,2h

l1CD3_1717:
	mov	es,[56ACh]
	cmp	word ptr es:[4FBAh],3h
	jz	172Bh

l1CD3_1723:
	mov	ax,0h
	mov	dx,2FE8h
	jmp	1731h

l1CD3_172B:
	mov	ax,10h
	mov	dx,2FE8h

l1CD3_1731:
	push	dx
	push	ax
	call	far 1F3Dh:0525h
	add	sp,4h
	mov	ax,1h
	push	ax
	call	far 0800h:4CACh
	add	sp,2h
	call	far 1E56h:0388h
	jmp	17C0h

l1CD3_174E:
	mov	es,[569Eh]
	cmp	byte ptr es:[0C623h],5h
	jle	17C0h

l1CD3_175A:
	sub	byte ptr es:[0C623h],4h
	jmp	17C0h
l1CD3_1762	dw	0x0027
l1CD3_1764	dw	0x0187
l1CD3_1766	dw	0x01C2
l1CD3_1768	dw	0x0231
l1CD3_176A	dw	0x02A5
l1CD3_176C	dw	0x037A
l1CD3_176E	dw	0x0725
l1CD3_1770	dw	0x04AD
l1CD3_1772	dw	0x09C7
l1CD3_1774	dw	0x096F
l1CD3_1776	dw	0x0A4B
l1CD3_1778	dw	0x0AEA
l1CD3_177A	dw	0x0B26
l1CD3_177C	dw	0x0AF2
l1CD3_177E	dw	0x0BFC
l1CD3_1780	dw	0x0BE1
l1CD3_1782	dw	0x0CA4
l1CD3_1784	dw	0x0CD8
l1CD3_1786	dw	0x0CE8
l1CD3_1788	dw	0x0CF0
l1CD3_178A	dw	0x0C5C
l1CD3_178C	dw	0x0C46
l1CD3_178E	dw	0x0CF8
l1CD3_1790	dw	0x0D44
l1CD3_1792	dw	0x0DC2
l1CD3_1794	dw	0x0DCF
l1CD3_1796	dw	0x0E54
l1CD3_1798	dw	0x0DDC
l1CD3_179A	dw	0x0E9B
l1CD3_179C	dw	0x0ED2
l1CD3_179E	dw	0x0EDA
l1CD3_17A0	dw	0x0EF3
l1CD3_17A2	dw	0x1052
l1CD3_17A4	dw	0x105A
l1CD3_17A6	dw	0x1062
l1CD3_17A8	dw	0x13B2
l1CD3_17AA	dw	0x139A
l1CD3_17AC	dw	0x13C6
l1CD3_17AE	dw	0x13E6
l1CD3_17B0	dw	0x13EC
l1CD3_17B2	dw	0x140D
l1CD3_17B4	dw	0x1515
l1CD3_17B6	dw	0x157E
l1CD3_17B8	dw	0x0CE0
l1CD3_17BA	dw	0x15DD
l1CD3_17BC	dw	0x0E2C
l1CD3_17BE	dw	0x174E

l1CD3_17C0:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1CD3_17C6: 1CD3:17C6
;;   Called from:
;;     0800:04A4 (in fn0800_0000)
;;     0800:1CAF (in fn0800_1C12)
;;     0800:1E0D (in fn0800_1C12)
;;     0800:2079 (in fn0800_1C12)
;;     0800:3754 (in fn0800_35D3)
;;     0800:4DAC (in fn0800_4D57)
;;     0FDC:06DE (in fn0FDC_0629)
;;     0FDC:08DD (in fn0FDC_0629)
;;     0FDC:09F0 (in fn0FDC_0629)
;;     0FDC:0A64 (in fn0FDC_0629)
;;     135D:0261 (in fn135D_01E9)
;;     135D:02AF (in fn135D_02A8)
;;     135D:02FB (in fn135D_02D2)
;;     135D:047B (in fn135D_03AA)
;;     135D:04E9 (in fn135D_04AB)
;;     135D:04FF (in fn135D_04AB)
;;     135D:0536 (in fn135D_04AB)
;;     135D:05AF (in fn135D_055A)
;;     135D:07A7 (in fn135D_079C)
;;     135D:0A24 (in fn135D_0980)
;;     135D:0B5A (in fn135D_0AB6)
;;     1431:02E2 (in fn1431_000A)
;;     1431:02FB (in fn1431_000A)
;;     1467:07D6 (in fn1467_0002)
;;     183B:04CA (in fn183B_000A)
;;     183B:0E89 (in fn183B_000A)
;;     183B:0EDF (in fn183B_000A)
;;     183B:0F96 (in fn183B_000A)
;;     183B:131D (in fn183B_000A)
;;     183B:138E (in fn183B_000A)
;;     183B:13AD (in fn183B_000A)
;;     1AE8:1C9A (in fn1AE8_12C7)
;;     1AE8:1D16 (in fn1AE8_12C7)
fn1CD3_17C6 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,7h
	push	ax
	call	far 1E56h:0281h
	add	sp,2h
	call	far 1E56h:0388h
	sub	ax,ax
	push	ax
	call	far 1E56h:0004h
	add	sp,2h
	retf

;; fn1CD3_17EA: 1CD3:17EA
;;   Called from:
;;     0800:04D3 (in fn0800_0000)
;;     0800:1CB9 (in fn0800_1C12)
;;     0800:375E (in fn0800_35D3)
;;     0800:4DB6 (in fn0800_4D57)
;;     0FDC:0114 (in fn0FDC_0008)
;;     0FDC:06E8 (in fn0FDC_0629)
;;     0FDC:09FA (in fn0FDC_0629)
;;     0FDC:0B23 (in fn0FDC_0629)
;;     0FDC:0BDE (in fn0FDC_0629)
;;     11B8:191B (in fn11B8_1762)
;;     11B8:198B (in fn11B8_1762)
;;     11B8:1A0E (in fn11B8_1762)
;;     11B8:1A23 (in fn11B8_1762)
;;     11B8:1A41 (in fn11B8_1762)
;;     135D:026B (in fn135D_01E9)
;;     135D:02B9 (in fn135D_02A8)
;;     135D:0305 (in fn135D_02D2)
;;     135D:0497 (in fn135D_03AA)
;;     135D:0540 (in fn135D_04AB)
;;     135D:05D0 (in fn135D_055A)
;;     135D:05E5 (in fn135D_055A)
;;     135D:05FC (in fn135D_055A)
;;     135D:07B1 (in fn135D_079C)
;;     135D:0A40 (in fn135D_0980)
;;     135D:0A65 (in fn135D_0980)
;;     1431:034F (in fn1431_000A)
;;     1467:045D (in fn1467_0002)
;;     1467:0474 (in fn1467_0002)
;;     1467:04F9 (in fn1467_0002)
;;     1467:0820 (in fn1467_0002)
;;     1467:0956 (in fn1467_08A8)
;;     1467:0B78 (in fn1467_08A8)
;;     183B:04D4 (in fn183B_000A)
;;     183B:0E93 (in fn183B_000A)
;;     183B:0EE9 (in fn183B_000A)
;;     183B:0FAD (in fn183B_000A)
;;     183B:1398 (in fn183B_000A)
;;     183B:13CE (in fn183B_000A)
;;     1AE8:1CB0 (in fn1AE8_12C7)
;;     1AE8:1D20 (in fn1AE8_12C7)
fn1CD3_17EA proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 1E56h:03F5h
	add	sp,4h
	call	far 1F3Dh:086Ah
	pop	bp
	retf

;; fn1CD3_1809: 1CD3:1809
;;   Called from:
;;     11B8:01FE (in fn11B8_0002)
;;     11B8:0996 (in fn11B8_0925)
;;     1CD3:0374 (in fn1CD3_0004)
;;     1CD3:0D96 (in fn1CD3_0004)
fn1CD3_1809 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,4F7Eh
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
	retf

;; fn1CD3_181E: 1CD3:181E
;;   Called from:
;;     0FDC:1500 (in fn0FDC_13DE)
;;     0FDC:16FA (in fn0FDC_15E6)
;;     0FDC:1885 (in fn0FDC_17B9)
;;     11B8:05A9 (in fn11B8_0002)
;;     11B8:098C (in fn11B8_0925)
;;     11B8:0991 (in fn11B8_0925)
;;     1431:023C (in fn1431_000A)
;;     1467:02CC (in fn1467_0002)
;;     1467:0C83 (in fn1467_0B98)
;;     1CD3:0BA9 (in fn1CD3_0004)
;;     1CD3:0D92 (in fn1CD3_0004)
fn1CD3_181E proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,4FA0h
	push	ds
	push	ax
	call	far 1E56h:03F5h
	add	sp,4h
