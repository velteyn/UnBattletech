;;; Segment 1FC5 (1FC5:0000)
1FC5:0000 08 CB                                           ..              

;; fn1FC5_0002: 1FC5:0002
;;   Called from:
;;     0800:19D3 (in fn0800_19BF)
fn1FC5_0002 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	dec	word ptr [bp+6h]
	mov	word ptr [bp-4h],0h
	jmp	0072h

l1FC5_0018:
	cmp	word ptr [bp+6h],0h
	jz	007Eh

l1FC5_001E:
	cmp	word ptr [si+500Ah],0h
	jnz	002Fh

l1FC5_0025:
	cmp	word ptr [si+500Ch],0h
	jnz	002Fh

l1FC5_002C:
	dec	word ptr [bp+6h]

l1FC5_002F:
	mov	bx,[bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	[bp-2h],ax
	cmp	ax,3E8h
	jg	0046h

l1FC5_0040:
	add	word ptr [bp-4h],3h
	jmp	0072h

l1FC5_0046:
	sub	word ptr [bp-2h],3E8h
	cmp	word ptr [bp-2h],1h
	jnz	0057h

l1FC5_0051:
	add	word ptr [bp-4h],6h
	jmp	0072h

l1FC5_0057:
	cmp	word ptr [bp-2h],2h
	jnz	0063h

l1FC5_005D:
	add	word ptr [bp-4h],7h
	jmp	0072h

l1FC5_0063:
	cmp	word ptr [bp-2h],3h
	jz	005Dh

l1FC5_0069:
	cmp	word ptr [bp-2h],4h
	jz	005Dh

l1FC5_006F:
	inc	word ptr [bp-4h]

l1FC5_0072:
	mov	si,[bp-4h]
	shl	si,1h
	cmp	word ptr [si+5008h],0h
	jnz	0018h

l1FC5_007E:
	cmp	word ptr [bp+6h],0h
	jz	0087h

l1FC5_0084:
	jmp	029Eh

l1FC5_0087:
	mov	ax,[bp-4h]

l1FC5_008A:
	mov	si,[bp-4h]
	shl	si,1h
	cmp	word ptr [si+500Ah],0h
	jnz	00A0h

l1FC5_0096:
	cmp	word ptr [si+500Ch],0h
	jnz	00A0h

l1FC5_009D:
	jmp	029Eh

l1FC5_00A0:
	mov	es,[56FEh]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[4612h],ax
	cmp	ax,3E8h
	jg	00E7h

l1FC5_00B9:
	mov	es,[5700h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[3984h],ax
	mov	es,[5702h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[0E48Ch],ax
	push	cs
	call	02A3h
	jmp	008Ah

l1FC5_00E7:
	mov	es,[56FEh]
	sub	word ptr es:[4612h],3E8h
	cmp	word ptr es:[4612h],1h
	jnz	0161h

l1FC5_00FA:
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[4612h],ax
	mov	es,[5704h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[006Ch],ax
	mov	es,[5706h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[3776h],ax
	mov	es,[5708h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[4312h],ax
	mov	es,[570Ah]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[398Ah],ax
	push	cs
	call	02EBh
	jmp	008Ah

l1FC5_0161:
	mov	es,[56FEh]
	cmp	word ptr es:[4612h],2h
	jnz	01E8h

l1FC5_016D:
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[4612h],ax
	mov	es,[570Ch]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[0000h],ax
	mov	es,[570Eh]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[39F4h],ax
	mov	es,[5710h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[4000h],ax
	mov	es,[5712h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[4034h],ax
	mov	es,[5714h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[0062h],ax
	push	cs
	call	0345h
	jmp	008Ah

l1FC5_01E8:
	mov	es,[56FEh]
	cmp	word ptr es:[4612h],3h
	jz	01FFh

l1FC5_01F4:
	cmp	word ptr es:[4612h],4h
	jz	01FFh

l1FC5_01FC:
	jmp	008Ah

l1FC5_01FF:
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	[bp-2h],ax
	mov	es,[5716h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[398Ch],ax
	mov	es,[5718h]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[39A2h],ax
	mov	es,[571Ah]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[39F6h],ax
	mov	es,[571Ch]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[3FF2h],ax
	mov	es,[571Eh]
	mov	bx,[bp-4h]
	inc	word ptr [bp-4h]
	shl	bx,1h
	mov	ax,[bx+5008h]
	mov	es:[009Ch],ax
	mov	es,[56FEh]
	cmp	word ptr es:[4612h],3h
	jnz	028Ch

l1FC5_027E:
	mov	ax,[bp-2h]
	mov	es:[4612h],ax
	push	cs
	call	03A8h
	jmp	008Ah

l1FC5_028C:
	mov	es,[56FEh]
	mov	ax,[bp-2h]
	mov	es:[4612h],ax
	push	cs
	call	040Bh
	jmp	008Ah

l1FC5_029E:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_02A3: 1FC5:02A3
;;   Called from:
;;     1FC5:00E1 (in fn1FC5_0002)
fn1FC5_02A3 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	cs
	call	046Eh
	mov	word ptr [bp-2h],0h
	jmp	02D5h

l1FC5_02B9:
	mov	es,[5702h]
	push	word ptr es:[0E48Ch]
	mov	es,[5700h]
	push	word ptr es:[3984h]
	push	cs
	call	047Bh
	add	sp,4h
	inc	word ptr [bp-2h]

l1FC5_02D5:
	mov	es,[56FEh]
	mov	ax,[bp-2h]
	cmp	es:[4612h],ax
	jg	02B9h

l1FC5_02E3:
	push	cs
	call	04E4h
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_02EB: 1FC5:02EB
;;   Called from:
;;     1FC5:015A (in fn1FC5_0002)
fn1FC5_02EB proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	cs
	call	046Eh
	mov	word ptr [bp-2h],0h
	jmp	032Fh

l1FC5_0301:
	mov	es,[570Ah]
	push	word ptr es:[398Ah]
	mov	es,[5708h]
	push	word ptr es:[4312h]
	mov	es,[5706h]
	push	word ptr es:[3776h]
	mov	es,[5704h]
	push	word ptr es:[006Ch]
	push	cs
	call	059Ah
	add	sp,8h
	inc	word ptr [bp-2h]

l1FC5_032F:
	mov	es,[56FEh]
	mov	ax,[bp-2h]
	cmp	es:[4612h],ax
	jg	0301h

l1FC5_033D:
	push	cs
	call	04E4h
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_0345: 1FC5:0345
;;   Called from:
;;     1FC5:01E1 (in fn1FC5_0002)
fn1FC5_0345 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	cs
	call	046Eh
	mov	word ptr [bp-2h],0h
	jmp	0392h

l1FC5_035B:
	mov	es,[5714h]
	push	word ptr es:[0062h]
	mov	es,[5712h]
	push	word ptr es:[4034h]
	mov	es,[5710h]
	push	word ptr es:[4000h]
	mov	es,[570Eh]
	push	word ptr es:[39F4h]
	mov	es,[570Ch]
	push	word ptr es:[0000h]
	push	cs
	call	0643h
	add	sp,0Ah
	inc	word ptr [bp-2h]

l1FC5_0392:
	mov	es,[56FEh]
	mov	ax,[bp-2h]
	cmp	es:[4612h],ax
	jg	035Bh

l1FC5_03A0:
	push	cs
	call	04E4h
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_03A8: 1FC5:03A8
;;   Called from:
;;     1FC5:0285 (in fn1FC5_0002)
fn1FC5_03A8 proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	cs
	call	046Eh
	mov	word ptr [bp-2h],0h
	jmp	03F5h

l1FC5_03BE:
	mov	es,[571Eh]
	push	word ptr es:[009Ch]
	mov	es,[571Ch]
	push	word ptr es:[3FF2h]
	mov	es,[571Ah]
	push	word ptr es:[39F6h]
	mov	es,[5718h]
	push	word ptr es:[39A2h]
	mov	es,[5716h]
	push	word ptr es:[398Ch]
	push	cs
	call	0747h
	add	sp,0Ah
	inc	word ptr [bp-2h]

l1FC5_03F5:
	mov	es,[56FEh]
	mov	ax,[bp-2h]
	cmp	es:[4612h],ax
	jg	03BEh

l1FC5_0403:
	push	cs
	call	04E4h
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_040B: 1FC5:040B
;;   Called from:
;;     1FC5:0297 (in fn1FC5_0002)
fn1FC5_040B proc
	push	bp
	mov	bp,sp
	mov	ax,2h
	call	far 207Fh:2FDCh
	push	cs
	call	046Eh
	mov	word ptr [bp-2h],0h
	jmp	0458h

l1FC5_0421:
	mov	es,[571Eh]
	push	word ptr es:[009Ch]
	mov	es,[571Ch]
	push	word ptr es:[3FF2h]
	mov	es,[571Ah]
	push	word ptr es:[39F6h]
	mov	es,[5718h]
	push	word ptr es:[39A2h]
	mov	es,[5716h]
	push	word ptr es:[398Ch]
	push	cs
	call	07DAh
	add	sp,0Ah
	inc	word ptr [bp-2h]

l1FC5_0458:
	mov	es,[56FEh]
	mov	ax,[bp-2h]
	cmp	es:[4612h],ax
	jg	0421h

l1FC5_0466:
	push	cs
	call	04E4h
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_046E: 1FC5:046E
;;   Called from:
;;     1FC5:02AE (in fn1FC5_02A3)
;;     1FC5:02F6 (in fn1FC5_02EB)
;;     1FC5:0350 (in fn1FC5_0345)
;;     1FC5:03B3 (in fn1FC5_03A8)
;;     1FC5:0416 (in fn1FC5_040B)
;;     1FC5:0686 (in fn1FC5_0643)
fn1FC5_046E proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	call	far 207Fh:001Ch
	retf

;; fn1FC5_047B: 1FC5:047B
;;   Called from:
;;     1FC5:02CB (in fn1FC5_02A3)
fn1FC5_047B proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[5700h]
	mov	ax,[bp+6h]
	mov	es:[3984h],ax
	mov	es,[5702h]
	mov	ax,[bp+8h]
	mov	es:[0E48Ch],ax
	mov	es,[5700h]
	cmp	word ptr es:[3984h],0h
	jz	04B5h

l1FC5_04A8:
	push	word ptr es:[3984h]
	call	far 207Fh:0030h
	add	sp,2h

l1FC5_04B5:
	mov	word ptr [bp-4h],0h
	jmp	04D3h

l1FC5_04BC:
	inc	word ptr [bp-2h]

l1FC5_04BF:
	mov	es,[5702h]
	mov	ax,es:[0E48Ch]
	imul	word ptr [5006h]
	cmp	ax,[bp-2h]
	jg	04BCh

l1FC5_04D0:
	inc	word ptr [bp-4h]

l1FC5_04D3:
	cmp	word ptr [bp-4h],32h
	jge	04E0h

l1FC5_04D9:
	mov	word ptr [bp-2h],0h
	jmp	04BFh

l1FC5_04E0:
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_04E4: 1FC5:04E4
;;   Called from:
;;     1FC5:02E3 (in fn1FC5_02A3)
;;     1FC5:033D (in fn1FC5_02EB)
;;     1FC5:03A0 (in fn1FC5_0345)
;;     1FC5:0403 (in fn1FC5_03A8)
;;     1FC5:0466 (in fn1FC5_040B)
;;     1FC5:06ED (in fn1FC5_0643)
fn1FC5_04E4 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	call	far 207Fh:0051h
	retf

;; fn1FC5_04F1: 1FC5:04F1
;;   Called from:
;;     1FC5:07AA (in fn1FC5_0747)
;;     1FC5:083D (in fn1FC5_07DA)
fn1FC5_04F1 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[5704h]
	mov	ax,[bp+6h]
	mov	es:[006Ch],ax
	mov	es,[5706h]
	mov	ax,[bp+8h]
	mov	es:[3776h],ax
	mov	es,[5708h]
	mov	ax,[bp+0Ah]
	mov	es:[4312h],ax
	mov	es,[570Ah]
	mov	word ptr es:[398Ah],3E8h
	call	far 207Fh:0067h
	mov	word ptr [bp-2h],1h
	jmp	0537h

l1FC5_0534:
	inc	word ptr [bp-2h]

l1FC5_0537:
	mov	ax,[5006h]
	cmp	[bp-2h],ax
	jl	0534h

l1FC5_053F:
	mov	word ptr [bp-2h],0h
	jmp	0570h

l1FC5_0546:
	inc	word ptr [bp-4h]

l1FC5_0549:
	mov	ax,[5006h]
	cmp	[bp-4h],ax
	jge	056Dh

l1FC5_0551:
	mov	es,[5706h]
	push	word ptr es:[3776h]
	mov	es,[5704h]
	push	word ptr es:[006Ch]
	call	far 207Fh:00A9h
	add	sp,4h
	jmp	0546h

l1FC5_056D:
	inc	word ptr [bp-2h]

l1FC5_0570:
	mov	es,[5708h]
	mov	ax,[bp-2h]
	cmp	es:[4312h],ax
	jle	0596h

l1FC5_057E:
	mov	es,[570Ah]
	push	word ptr es:[398Ah]
	call	far 207Fh:007Dh
	add	sp,2h
	mov	word ptr [bp-4h],0h
	jmp	0549h

l1FC5_0596:
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_059A: 1FC5:059A
;;   Called from:
;;     1FC5:0325 (in fn1FC5_02EB)
fn1FC5_059A proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[5704h]
	mov	ax,[bp+6h]
	mov	es:[006Ch],ax
	mov	es,[5706h]
	mov	ax,[bp+8h]
	mov	es:[3776h],ax
	mov	es,[5708h]
	mov	ax,[bp+0Ah]
	mov	es:[4312h],ax
	mov	es,[570Ah]
	mov	ax,[bp+0Ch]
	mov	es:[398Ah],ax
	call	far 207Fh:0067h
	mov	word ptr [bp-2h],1h
	jmp	05E0h

l1FC5_05DD:
	inc	word ptr [bp-2h]

l1FC5_05E0:
	mov	ax,[5006h]
	cmp	[bp-2h],ax
	jl	05DDh

l1FC5_05E8:
	mov	word ptr [bp-2h],0h
	jmp	0619h

l1FC5_05EF:
	inc	word ptr [bp-4h]

l1FC5_05F2:
	mov	ax,[5006h]
	cmp	[bp-4h],ax
	jge	0616h

l1FC5_05FA:
	mov	es,[5706h]
	push	word ptr es:[3776h]
	mov	es,[5704h]
	push	word ptr es:[006Ch]
	call	far 207Fh:00A9h
	add	sp,4h
	jmp	05EFh

l1FC5_0616:
	inc	word ptr [bp-2h]

l1FC5_0619:
	mov	es,[5708h]
	mov	ax,[bp-2h]
	cmp	es:[4312h],ax
	jle	063Fh

l1FC5_0627:
	mov	es,[570Ah]
	push	word ptr es:[398Ah]
	call	far 207Fh:007Dh
	add	sp,2h
	mov	word ptr [bp-4h],0h
	jmp	05F2h

l1FC5_063F:
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_0643: 1FC5:0643
;;   Called from:
;;     1FC5:0388 (in fn1FC5_0345)
fn1FC5_0643 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[570Ch]
	mov	ax,[bp+6h]
	mov	es:[0000h],ax
	mov	es,[570Eh]
	mov	ax,[bp+8h]
	mov	es:[39F4h],ax
	mov	es,[5710h]
	mov	ax,[bp+0Ah]
	mov	es:[4000h],ax
	mov	es,[5712h]
	mov	ax,[bp+0Ch]
	mov	es:[4034h],ax
	mov	es,[5714h]
	mov	ax,[bp+0Eh]
	mov	es:[0062h],ax
	push	cs
	call	046Eh
	mov	word ptr [bp-4h],0h
	jmp	06D8h

l1FC5_0691:
	inc	word ptr [bp-2h]

l1FC5_0694:
	mov	es,[5714h]
	mov	ax,es:[0062h]
	imul	word ptr [bp-2h]
	mov	si,ax
	mov	es,[570Eh]
	mov	ax,es:[39F4h]
	shl	ax,1h
	cmp	ax,si
	jle	06D5h

l1FC5_06AF:
	mov	es,[5710h]
	push	word ptr es:[4000h]
	mov	es,[570Ch]
	mov	ax,es:[0000h]
	mov	es,[570Eh]
	sub	ax,es:[39F4h]
	add	ax,si
	push	ax
	push	cs
	call	06F6h
	add	sp,4h
	jmp	0691h

l1FC5_06D5:
	inc	word ptr [bp-4h]

l1FC5_06D8:
	mov	es,[5712h]
	mov	ax,[bp-4h]
	cmp	es:[4034h],ax
	jle	06EDh

l1FC5_06E6:
	mov	word ptr [bp-2h],0h
	jmp	0694h

l1FC5_06ED:
	push	cs
	call	04E4h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_06F6: 1FC5:06F6
;;   Called from:
;;     1FC5:06CC (in fn1FC5_0643)
fn1FC5_06F6 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[5720h]
	mov	ax,[bp+6h]
	mov	es:[3FF6h],ax
	mov	es,[5722h]
	mov	ax,[bp+8h]
	mov	es:[3246h],ax
	mov	es,[5720h]
	push	word ptr es:[3FF6h]
	call	far 207Fh:0030h
	add	sp,2h
	mov	word ptr [bp-2h],0h
	jmp	0732h

l1FC5_072F:
	inc	word ptr [bp-2h]

l1FC5_0732:
	mov	es,[5722h]
	mov	ax,es:[3246h]
	imul	word ptr [5006h]
	cmp	ax,[bp-2h]
	jg	072Fh

l1FC5_0743:
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_0747: 1FC5:0747
;;   Called from:
;;     1FC5:03EB (in fn1FC5_03A8)
fn1FC5_0747 proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[5716h]
	mov	ax,[bp+6h]
	mov	es:[398Ch],ax
	mov	es,[5718h]
	mov	ax,[bp+8h]
	mov	es:[39A2h],ax
	mov	es,[571Ah]
	mov	ax,[bp+0Ah]
	mov	es:[39F6h],ax
	mov	es,[571Ch]
	mov	ax,[bp+0Ch]
	mov	es:[3FF2h],ax
	mov	es,[571Eh]
	mov	ax,[bp+0Eh]
	mov	es:[009Ch],ax
	mov	word ptr [bp-4h],0h
	jmp	07B4h

l1FC5_0791:
	mov	[bp-2h],si
	mov	es,[571Ch]
	push	word ptr es:[3FF2h]
	mov	ax,si
	mov	es,[571Ah]
	sub	ax,es:[39F6h]
	push	ax
	push	si
	push	cs
	call	04F1h
	add	sp,6h
	inc	word ptr [bp-4h]

l1FC5_07B4:
	mov	es,[5716h]
	mov	si,es:[398Ch]
	mov	es,[571Eh]
	mov	ax,es:[009Ch]
	imul	word ptr [bp-4h]
	sub	si,ax
	mov	es,[5718h]
	cmp	es:[39A2h],si
	jl	0791h

l1FC5_07D5:
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1FC5_07DA: 1FC5:07DA
;;   Called from:
;;     1FC5:044E (in fn1FC5_040B)
fn1FC5_07DA proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[5716h]
	mov	ax,[bp+6h]
	mov	es:[398Ch],ax
	mov	es,[5718h]
	mov	ax,[bp+8h]
	mov	es:[39A2h],ax
	mov	es,[571Ah]
	mov	ax,[bp+0Ah]
	mov	es:[39F6h],ax
	mov	es,[571Ch]
	mov	ax,[bp+0Ch]
	mov	es:[3FF2h],ax
	mov	es,[571Eh]
	mov	ax,[bp+0Eh]
	mov	es:[009Ch],ax
	mov	word ptr [bp-4h],0h
	jmp	0847h

l1FC5_0824:
	mov	[bp-2h],si
	mov	es,[571Ch]
	push	word ptr es:[3FF2h]
	mov	ax,si
	mov	es,[571Ah]
	sub	ax,es:[39F6h]
	push	ax
	push	si
	push	cs
	call	04F1h
	add	sp,6h
	inc	word ptr [bp-4h]

l1FC5_0847:
	mov	es,[571Eh]
	mov	ax,es:[009Ch]
	imul	word ptr [bp-4h]
	mov	si,ax
	mov	es,[5716h]
	add	si,es:[398Ch]
	mov	es,[5718h]
