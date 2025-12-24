;;; Segment 1E56 (1E56:0000)
1E56:0000 C4 04 CB                                        ...             
1CD3:1833          90                                        .            

;; fn1E56_0004: 1E56:0004
;;   Called from:
;;     0800:2CD6 (in fn0800_2C50)
;;     0800:37B2 (in fn0800_378D)
;;     0800:4CC7 (in fn0800_4CAC)
;;     0800:4D4E (in fn0800_4CAC)
;;     0800:5168 (in fn0800_50C8)
;;     0DAB:09D7 (in fn0DAB_094B)
;;     0FDC:0260 (in fn0FDC_01C0)
;;     0FDC:0B7A (in fn0FDC_0629)
;;     1431:0092 (in fn1431_000A)
;;     1467:00EE (in fn1467_0002)
;;     1467:0949 (in fn1467_08A8)
;;     1467:0B6B (in fn1467_08A8)
;;     1543:01A0 (in fn1543_0004)
;;     1543:059D (in fn1543_0004)
;;     1543:078B (in fn1543_0004)
;;     1543:07B3 (in fn1543_0004)
;;     1543:0813 (in fn1543_07CB)
;;     1631:0384 (in fn1631_032F)
;;     1631:03A1 (in fn1631_032F)
;;     183B:08D2 (in fn183B_000A)
;;     183B:1091 (in fn183B_000A)
;;     1CD3:17E1 (in fn1CD3_17C6)
fn1E56_0004 proc
	push	bp
	mov	bp,sp
	mov	ax,14h
	call	far 207Fh:2FDCh
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	mov	[bp-0Ch],ax
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	mov	[bp-0Eh],ax
	mov	bx,[bp+6h]
	shl	bx,1h
	shl	bx,1h
	mov	ax,[bx+4FA4h]
	mov	dx,[bx+4FA6h]
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	les	bx,[bp-4h]
	mov	ax,es:[bx]
	mov	cl,5h
	shl	ax,cl
	mov	es,[56D4h]
	add	ax,es:[4066h]
	mov	dx,es:[4068h]
	mov	[bp-14h],ax
	mov	[bp-12h],dx
	mov	ax,[bp-0Eh]
	dec	ax
	push	ax
	mov	ax,[bp-0Ch]
	dec	ax
	push	ax
	push	dx
	push	word ptr [bp-14h]
	call	far 207Fh:275Ch
	add	sp,8h
	les	bx,[bp-4h]
	mov	ax,es:[bx+2h]
	mov	cl,5h
	shl	ax,cl
	mov	es,[56D4h]
	add	ax,es:[4066h]
	mov	dx,es:[4068h]
	mov	[bp-14h],ax
	mov	[bp-12h],dx
	mov	ax,[bp-0Eh]
	dec	ax
	push	ax
	mov	es,[56D6h]
	mov	ax,es:[3990h]
	add	ax,[bp-0Ch]
	push	ax
	push	dx
	push	word ptr [bp-14h]
	call	far 207Fh:275Ch
	add	sp,8h
	les	bx,[bp-4h]
	mov	ax,es:[bx+4h]
	mov	cl,5h
	shl	ax,cl
	mov	es,[56D4h]
	add	ax,es:[4066h]
	mov	dx,es:[4068h]
	mov	[bp-14h],ax
	mov	[bp-12h],dx
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	add	ax,[bp-0Eh]
	push	ax
	mov	ax,[bp-0Ch]
	dec	ax
	push	ax
	push	dx
	push	word ptr [bp-14h]
	call	far 207Fh:275Ch
	add	sp,8h
	les	bx,[bp-4h]
	mov	ax,es:[bx+6h]
	mov	cl,5h
	shl	ax,cl
	mov	es,[56D4h]
	add	ax,es:[4066h]
	mov	dx,es:[4068h]
	mov	[bp-14h],ax
	mov	[bp-12h],dx
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	add	ax,[bp-0Eh]
	push	ax
	mov	es,[56D6h]
	mov	ax,es:[3990h]
	add	ax,[bp-0Ch]
	push	ax
	push	dx
	push	word ptr [bp-14h]
	call	far 207Fh:275Ch
	add	sp,8h
	mov	word ptr [bp-6h],4h
	mov	ax,1h
	push	ax
	mov	es,[56D6h]
	push	word ptr es:[3990h]
	mov	ax,[bp-0Eh]
	dec	ax
	push	ax
	push	word ptr [bp-0Ch]
	mov	ax,4h
	push	ax
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	push	cs
	call	01E7h
	add	sp,0Eh
	mov	[bp-6h],ax
	sub	ax,ax
	push	ax
	mov	es,[56D8h]
	push	word ptr es:[393Ah]
	push	word ptr [bp-0Eh]
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	dec	ax
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	push	cs
	call	01E7h
	add	sp,0Eh
	mov	[bp-6h],ax
	sub	ax,ax
	push	ax
	mov	es,[56D8h]
	push	word ptr es:[393Ah]
	push	word ptr [bp-0Eh]
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	mov	es,[56D6h]
	add	ax,es:[3990h]
	push	ax
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	push	cs
	call	01E7h
	add	sp,0Eh
	mov	[bp-6h],ax
	mov	ax,1h
	push	ax
	mov	es,[56D6h]
	push	word ptr es:[3990h]
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	add	ax,[bp-0Eh]
	push	ax
	push	word ptr [bp-0Ch]
	push	word ptr [bp-6h]
	push	word ptr [bp-2h]
	push	word ptr [bp-4h]
	push	cs
	call	01E7h
	mov	[bp-6h],ax
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_01E7: 1E56:01E7
;;   Called from:
;;     1E56:014D (in fn1E56_0004)
;;     1E56:0179 (in fn1E56_0004)
;;     1E56:01AD (in fn1E56_0004)
;;     1E56:01DC (in fn1E56_0004)
fn1E56_01E7 proc
	push	bp
	mov	bp,sp
	mov	ax,8h
	call	far 207Fh:2FDCh
	push	si
	mov	ax,[bp+0Ah]
	mov	[bp-8h],ax
	mov	word ptr [bp-2h],0h
	jmp	021Eh

l1E56_0200:
	inc	word ptr [bp+0Eh]

l1E56_0203:
	inc	word ptr [bp-8h]
	mov	bx,[bp-8h]
	shl	bx,1h
	les	si,[bp+6h]
	cmp	word ptr es:[bx+si],0FFh
	jnz	021Bh

l1E56_0215:
	mov	ax,[bp+0Ah]
	mov	[bp-8h],ax

l1E56_021B:
	inc	word ptr [bp-2h]

l1E56_021E:
	mov	ax,[bp+10h]
	cmp	[bp-2h],ax
	jge	0267h

l1E56_0226:
	mov	bx,[bp-8h]
	shl	bx,1h
	les	si,[bp+6h]
	mov	ax,es:[bx+si]
	mov	cl,5h
	shl	ax,cl
	mov	es,[56D4h]
	add	ax,es:[4066h]
	mov	dx,es:[4068h]
	mov	[bp-6h],ax
	mov	[bp-4h],dx
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	push	dx
	push	ax
	call	far 207Fh:275Ch
	add	sp,8h
	cmp	word ptr [bp+12h],0h
	jz	0200h

l1E56_025F:
	inc	word ptr [bp+0Ch]
	jmp	0203h

l1E56_0264:
	inc	word ptr [bp-8h]

l1E56_0267:
	mov	bx,[bp-8h]
	shl	bx,1h
	les	si,[bp+6h]
	cmp	word ptr es:[bx+si],0FFh
	jnz	0264h

l1E56_0276:
	inc	word ptr [bp-8h]
	mov	ax,[bp-8h]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_0281: 1E56:0281
;;   Called from:
;;     0800:0061 (in fn0800_0000)
;;     0800:2937 (in fn0800_2913)
;;     0800:29E9 (in fn0800_2913)
;;     0800:2CC5 (in fn0800_2C50)
;;     0800:32C3 (in fn0800_32B3)
;;     0800:35F1 (in fn0800_35D3)
;;     0800:37A2 (in fn0800_378D)
;;     0800:49B8 (in fn0800_48B7)
;;     0800:4A95 (in fn0800_48B7)
;;     0800:4CBB (in fn0800_4CAC)
;;     0800:4D42 (in fn0800_4CAC)
;;     0800:5158 (in fn0800_50C8)
;;     0DAB:09C7 (in fn0DAB_094B)
;;     0DAB:0B69 (in fn0DAB_0B5E)
;;     0DAB:14D8 (in fn0DAB_1467)
;;     0DAB:1623 (in fn0DAB_1467)
;;     0DAB:1B3F (in fn0DAB_1AFE)
;;     0FDC:00F5 (in fn0FDC_0008)
;;     0FDC:0161 (in fn0FDC_0008)
;;     0FDC:0172 (in fn0FDC_0008)
;;     0FDC:020D (in fn0FDC_01C0)
;;     0FDC:0B16 (in fn0FDC_0629)
;;     0FDC:0B6A (in fn0FDC_0629)
;;     0FDC:0BD1 (in fn0FDC_0629)
;;     11B8:1751 (in fn11B8_16B2)
;;     1431:0086 (in fn1431_000A)
;;     1467:00DE (in fn1467_0002)
;;     1467:03C8 (in fn1467_0002)
;;     1467:050D (in fn1467_0002)
;;     1467:05A6 (in fn1467_0002)
;;     1467:0939 (in fn1467_08A8)
;;     1467:0ACA (in fn1467_08A8)
;;     1467:0B5B (in fn1467_08A8)
;;     1543:0093 (in fn1543_0004)
;;     1543:0195 (in fn1543_0004)
;;     1543:049D (in fn1543_0004)
;;     1543:0544 (in fn1543_0004)
;;     1543:0591 (in fn1543_0004)
;;     1543:05D1 (in fn1543_0004)
;;     1543:05E2 (in fn1543_0004)
;;     1543:0610 (in fn1543_0004)
;;     1543:077A (in fn1543_0004)
;;     1543:07A2 (in fn1543_0004)
;;     1543:0807 (in fn1543_07CB)
;;     1543:084C (in fn1543_07CB)
;;     1543:09BD (in fn1543_07CB)
;;     1543:0B30 (in fn1543_0A35)
;;     1631:0373 (in fn1631_032F)
;;     1631:0390 (in fn1631_032F)
;;     1631:1071 (in fn1631_1057)
;;     1631:1099 (in fn1631_1057)
;;     1631:1204 (in fn1631_11AB)
;;     1631:1B19 (in fn1631_16AB)
;;     1631:1FF9 (in fn1631_1FDF)
;;     1631:20A1 (in fn1631_1FDF)
;;     183B:02ED (in fn183B_000A)
;;     183B:0446 (in fn183B_000A)
;;     183B:0673 (in fn183B_000A)
;;     183B:08C2 (in fn183B_000A)
;;     183B:0FE3 (in fn183B_000A)
;;     183B:1044 (in fn183B_000A)
;;     183B:1085 (in fn183B_000A)
;;     183B:1264 (in fn183B_000A)
;;     183B:1304 (in fn183B_000A)
;;     183B:13EC (in fn183B_000A)
;;     183B:1523 (in fn183B_14C3)
;;     183B:1586 (in fn183B_14C3)
;;     183B:1CD9 (in fn183B_1C1F)
;;     183B:1E5E (in fn183B_1C1F)
;;     183B:2241 (in fn183B_2231)
;;     183B:24FF (in fn183B_24F0)
;;     183B:2565 (in fn183B_2556)
;;     183B:25A6 (in fn183B_2591)
;;     183B:25F9 (in fn183B_2591)
;;     183B:26C9 (in fn183B_2591)
;;     1AE8:0438 (in fn1AE8_000C)
;;     1AE8:1DFB (in fn1AE8_12C7)
;;     1CD3:17D1 (in fn1CD3_17C6)
fn1E56_0281 proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	push	si
	cmp	word ptr [4FA2h],0h
	jz	02E6h

l1E56_0293:
	mov	es,[56DAh]
	mov	si,es:[4600h]
	mov	cl,4h
	shl	si,cl
	mov	es,[56DCh]
	mov	ax,es:[37FEh]
	mov	es,[56DEh]
	mov	es:[si+8h],ax
	mov	es,[56E0h]
	mov	ax,es:[377Eh]
	mov	es,[56DEh]
	mov	es:[si+0Ah],ax
	mov	es,[56E2h]
	mov	ax,es:[3748h]
	mov	es,[56DEh]
	mov	es:[si+0Ch],ax
	mov	es,[56E4h]
	mov	ax,es:[374Eh]
	mov	es,[56DEh]
	mov	es:[si+0Eh],ax
	jmp	02ECh

l1E56_02E6:
	mov	word ptr [4FA2h],1h

l1E56_02EC:
	mov	es,[56DAh]
	mov	ax,[bp+6h]
	mov	es:[4600h],ax
	mov	si,ax
	mov	cl,4h
	shl	si,cl
	mov	es,[56DEh]
	mov	ax,es:[si+0h]
	mov	es,[56D0h]
	mov	es:[39A0h],ax
	mov	es,[56DEh]
	mov	ax,es:[si+2h]
	mov	es,[56D2h]
	mov	es:[39A4h],ax
	mov	es,[56DEh]
	mov	ax,es:[si+4h]
	mov	es,[56D6h]
	mov	es:[3990h],ax
	mov	es,[56DEh]
	mov	ax,es:[si+6h]
	mov	es,[56D8h]
	mov	es:[393Ah],ax
	mov	es,[56DEh]
	mov	ax,es:[si+8h]
	mov	es,[56DCh]
	mov	es:[37FEh],ax
	mov	es,[56DEh]
	mov	ax,es:[si+0Ah]
	mov	es,[56E0h]
	mov	es:[377Eh],ax
	mov	es,[56DEh]
	mov	ax,es:[si+0Ch]
	mov	es,[56E2h]
	mov	es:[3748h],ax
	mov	es,[56DEh]
	mov	ax,es:[si+0Eh]
	mov	es,[56E4h]
	mov	es:[374Eh],ax
	pop	si
	pop	bp
	retf

;; fn1E56_0388: 1E56:0388
;;   Called from:
;;     0800:04E0 (in fn0800_0000)
;;     0800:293F (in fn0800_2913)
;;     0800:29E1 (in fn0800_2913)
;;     0800:2CCD (in fn0800_2C50)
;;     0800:32CB (in fn0800_32B3)
;;     0800:3369 (in fn0800_32B3)
;;     0800:3571 (in fn0800_32B3)
;;     0800:35F9 (in fn0800_35D3)
;;     0800:3721 (in fn0800_35D3)
;;     0800:37AA (in fn0800_378D)
;;     0800:37EE (in fn0800_378D)
;;     0800:3834 (in fn0800_378D)
;;     0800:385F (in fn0800_378D)
;;     0800:3889 (in fn0800_378D)
;;     0800:3BD7 (in fn0800_3BD0)
;;     0800:3C42 (in fn0800_3BD0)
;;     0800:3CB6 (in fn0800_3BD0)
;;     0800:3CEB (in fn0800_3BD0)
;;     0800:3D13 (in fn0800_3BD0)
;;     0800:3F8D (in fn0800_3D40)
;;     0800:49C0 (in fn0800_48B7)
;;     0800:4A9D (in fn0800_48B7)
;;     0800:4CD5 (in fn0800_4CAC)
;;     0800:4DA5 (in fn0800_4D57)
;;     0800:4FC6 (in fn0800_4DC7)
;;     0800:5160 (in fn0800_50C8)
;;     0DAB:0831 (in fn0DAB_04F9)
;;     0DAB:087D (in fn0DAB_04F9)
;;     0DAB:08D5 (in fn0DAB_04F9)
;;     0DAB:09CF (in fn0DAB_094B)
;;     0DAB:0A7E (in fn0DAB_094B)
;;     0DAB:0B71 (in fn0DAB_0B5E)
;;     0DAB:14E0 (in fn0DAB_1467)
;;     0DAB:162B (in fn0DAB_1467)
;;     0DAB:1B47 (in fn0DAB_1AFE)
;;     0FDC:00FD (in fn0FDC_0008)
;;     0FDC:0169 (in fn0FDC_0008)
;;     0FDC:0215 (in fn0FDC_01C0)
;;     0FDC:0B72 (in fn0FDC_0629)
;;     0FDC:1444 (in fn0FDC_13DE)
;;     0FDC:164B (in fn0FDC_15E6)
;;     0FDC:17EC (in fn0FDC_17B9)
;;     0FDC:18F9 (in fn0FDC_17B9)
;;     0FDC:1A72 (in fn0FDC_1A26)
;;     11B8:000E (in fn11B8_0002)
;;     11B8:020F (in fn11B8_0002)
;;     11B8:0318 (in fn11B8_0002)
;;     11B8:0338 (in fn11B8_0002)
;;     11B8:0442 (in fn11B8_0002)
;;     11B8:0462 (in fn11B8_0002)
;;     11B8:0550 (in fn11B8_0002)
;;     11B8:056A (in fn11B8_0002)
;;     11B8:0756 (in fn11B8_0002)
;;     11B8:0815 (in fn11B8_080A)
;;     11B8:0849 (in fn11B8_080A)
;;     11B8:086E (in fn11B8_080A)
;;     11B8:1759 (in fn11B8_16B2)
;;     11B8:176F (in fn11B8_1762)
;;     11B8:19B8 (in fn11B8_1762)
;;     135D:05F2 (in fn135D_055A)
;;     1431:009A (in fn1431_000A)
;;     1467:00E6 (in fn1467_0002)
;;     1467:03D0 (in fn1467_0002)
;;     1467:0453 (in fn1467_0002)
;;     1467:046A (in fn1467_0002)
;;     1467:0515 (in fn1467_0002)
;;     1467:05AE (in fn1467_0002)
;;     1467:072F (in fn1467_0002)
;;     1467:0873 (in fn1467_0002)
;;     1467:0941 (in fn1467_08A8)
;;     1467:0AD2 (in fn1467_08A8)
;;     1467:0B4C (in fn1467_08A8)
;;     1467:0B63 (in fn1467_08A8)
;;     1543:009B (in fn1543_0004)
;;     1543:0111 (in fn1543_0004)
;;     1543:013C (in fn1543_0004)
;;     1543:01A8 (in fn1543_0004)
;;     1543:054C (in fn1543_0004)
;;     1543:056D (in fn1543_0004)
;;     1543:05A5 (in fn1543_0004)
;;     1543:05D9 (in fn1543_0004)
;;     1543:05EA (in fn1543_0004)
;;     1543:0618 (in fn1543_0004)
;;     1543:0706 (in fn1543_0004)
;;     1543:0782 (in fn1543_0004)
;;     1543:07AA (in fn1543_0004)
;;     1543:081B (in fn1543_07CB)
;;     1631:037B (in fn1631_032F)
;;     1631:0398 (in fn1631_032F)
;;     1631:1079 (in fn1631_1057)
;;     1631:1091 (in fn1631_1057)
;;     1631:1B21 (in fn1631_16AB)
;;     183B:02F5 (in fn183B_000A)
;;     183B:044E (in fn183B_000A)
;;     183B:04A2 (in fn183B_000A)
;;     183B:067B (in fn183B_000A)
;;     183B:08CA (in fn183B_000A)
;;     183B:0FEB (in fn183B_000A)
;;     183B:104C (in fn183B_000A)
;;     183B:1099 (in fn183B_000A)
;;     183B:126C (in fn183B_000A)
;;     183B:12CB (in fn183B_000A)
;;     183B:130C (in fn183B_000A)
;;     183B:13F4 (in fn183B_000A)
;;     183B:152B (in fn183B_14C3)
;;     183B:158E (in fn183B_14C3)
;;     183B:1CE1 (in fn183B_1C1F)
;;     183B:1D96 (in fn183B_1C1F)
;;     183B:1E66 (in fn183B_1C1F)
;;     183B:2226 (in fn183B_1C1F)
;;     183B:2249 (in fn183B_2231)
;;     183B:2507 (in fn183B_24F0)
;;     183B:256D (in fn183B_2556)
;;     183B:25AE (in fn183B_2591)
;;     183B:2601 (in fn183B_2591)
;;     183B:2682 (in fn183B_2591)
;;     183B:26D1 (in fn183B_2591)
;;     183B:26E8 (in fn183B_2591)
;;     1AE8:0440 (in fn1AE8_000C)
;;     1CD3:04BF (in fn1CD3_0004)
;;     1CD3:073A (in fn1CD3_0004)
;;     1CD3:1454 (in fn1CD3_0004)
;;     1CD3:1747 (in fn1CD3_0004)
;;     1CD3:17D9 (in fn1CD3_17C6)
fn1E56_0388 proc
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	es,[56E0h]
	push	word ptr es:[377Eh]
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	mov	es,[56D8h]
	add	ax,es:[393Ah]
	mov	cl,3h
	shl	ax,cl
	dec	ax
	push	ax
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	mov	es,[56D6h]
	add	ax,es:[3990h]
	shl	ax,cl
	dec	ax
	push	ax
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	shl	ax,cl
	push	ax
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	shl	ax,cl
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	mov	es,[56E4h]
	sub	ax,ax
	mov	es:[374Eh],ax
	mov	es,[56E2h]
	mov	es:[3748h],ax
	retf

;; fn1E56_03F5: 1E56:03F5
;;   Called from:
;;     0800:00DB (in fn0800_0000)
;;     0800:04C6 (in fn0800_0000)
;;     0800:04EA (in fn0800_0000)
;;     0800:1A43 (in fn0800_1A13)
;;     0800:1ADA (in fn0800_1A13)
;;     0800:1E17 (in fn0800_1C12)
;;     0800:1E2F (in fn0800_1C12)
;;     0800:1E3C (in fn0800_1C12)
;;     0800:2083 (in fn0800_1C12)
;;     0800:209B (in fn0800_1C12)
;;     0800:20A8 (in fn0800_1C12)
;;     0800:2898 (in fn0800_2867)
;;     0800:296B (in fn0800_2913)
;;     0800:2984 (in fn0800_2913)
;;     0800:2991 (in fn0800_2913)
;;     0800:29C0 (in fn0800_2913)
;;     0800:29CD (in fn0800_2913)
;;     0800:2A5B (in fn0800_2A4F)
;;     0800:2A75 (in fn0800_2A69)
;;     0800:2A8A (in fn0800_2A7E)
;;     0800:2CE3 (in fn0800_2C50)
;;     0800:2CF6 (in fn0800_2C50)
;;     0800:2D03 (in fn0800_2C50)
;;     0800:2D10 (in fn0800_2C50)
;;     0800:32D5 (in fn0800_32B3)
;;     0800:3373 (in fn0800_32B3)
;;     0800:357B (in fn0800_32B3)
;;     0800:3593 (in fn0800_32B3)
;;     0800:35A0 (in fn0800_32B3)
;;     0800:3603 (in fn0800_35D3)
;;     0800:374D (in fn0800_35D3)
;;     0800:37D7 (in fn0800_378D)
;;     0800:37F8 (in fn0800_378D)
;;     0800:3869 (in fn0800_378D)
;;     0800:3897 (in fn0800_378D)
;;     0800:38A4 (in fn0800_378D)
;;     0800:39D9 (in fn0800_378D)
;;     0800:3A63 (in fn0800_378D)
;;     0800:3A84 (in fn0800_378D)
;;     0800:3AAD (in fn0800_378D)
;;     0800:3AE1 (in fn0800_378D)
;;     0800:3BE1 (in fn0800_3BD0)
;;     0800:3BFA (in fn0800_3BD0)
;;     0800:3C07 (in fn0800_3BD0)
;;     0800:3C4C (in fn0800_3BD0)
;;     0800:3CC0 (in fn0800_3BD0)
;;     0800:3CF5 (in fn0800_3BD0)
;;     0800:3D1D (in fn0800_3BD0)
;;     0800:3D2A (in fn0800_3BD0)
;;     0800:5175 (in fn0800_50C8)
;;     0800:5182 (in fn0800_50C8)
;;     0800:518F (in fn0800_50C8)
;;     0800:519C (in fn0800_50C8)
;;     0800:51A9 (in fn0800_50C8)
;;     0800:51C5 (in fn0800_50C8)
;;     0DAB:0055 (in fn0DAB_0002)
;;     0DAB:0083 (in fn0DAB_0002)
;;     0DAB:0090 (in fn0DAB_0002)
;;     0DAB:00AD (in fn0DAB_0002)
;;     0DAB:00BA (in fn0DAB_0002)
;;     0DAB:046F (in fn0DAB_0002)
;;     0DAB:04D4 (in fn0DAB_0002)
;;     0DAB:0610 (in fn0DAB_04F9)
;;     0DAB:06A4 (in fn0DAB_04F9)
;;     0DAB:0806 (in fn0DAB_04F9)
;;     0DAB:083B (in fn0DAB_04F9)
;;     0DAB:08A8 (in fn0DAB_04F9)
;;     0DAB:08BA (in fn0DAB_04F9)
;;     0DAB:0900 (in fn0DAB_04F9)
;;     0DAB:090D (in fn0DAB_04F9)
;;     0DAB:09E4 (in fn0DAB_094B)
;;     0DAB:0A31 (in fn0DAB_094B)
;;     0DAB:0A56 (in fn0DAB_094B)
;;     0DAB:0AA9 (in fn0DAB_094B)
;;     0DAB:0AC2 (in fn0DAB_094B)
;;     0DAB:0ACF (in fn0DAB_094B)
;;     0DAB:0AE8 (in fn0DAB_094B)
;;     0DAB:0AF5 (in fn0DAB_094B)
;;     0DAB:0B7B (in fn0DAB_0B5E)
;;     0DAB:1513 (in fn0DAB_1467)
;;     0DAB:1531 (in fn0DAB_1467)
;;     0DAB:1568 (in fn0DAB_1467)
;;     0DAB:15A4 (in fn0DAB_1467)
;;     0DAB:15B6 (in fn0DAB_1467)
;;     0DAB:1608 (in fn0DAB_1467)
;;     0DAB:1640 (in fn0DAB_1467)
;;     0DAB:166A (in fn0DAB_1467)
;;     0DAB:1687 (in fn0DAB_1467)
;;     0DAB:1934 (in fn0DAB_18E8)
;;     0DAB:1941 (in fn0DAB_18E8)
;;     0DAB:198B (in fn0DAB_18E8)
;;     0DAB:19BD (in fn0DAB_18E8)
;;     0DAB:1A08 (in fn0DAB_18E8)
;;     0DAB:1A44 (in fn0DAB_18E8)
;;     0DAB:1AF1 (in fn0DAB_18E8)
;;     0FDC:0107 (in fn0FDC_0008)
;;     0FDC:0228 (in fn0FDC_01C0)
;;     0FDC:08E7 (in fn0FDC_0629)
;;     0FDC:0A7A (in fn0FDC_0629)
;;     0FDC:0A89 (in fn0FDC_0629)
;;     0FDC:0B87 (in fn0FDC_0629)
;;     0FDC:0B94 (in fn0FDC_0629)
;;     0FDC:0BAB (in fn0FDC_0629)
;;     0FDC:144E (in fn0FDC_13DE)
;;     0FDC:146B (in fn0FDC_13DE)
;;     0FDC:1478 (in fn0FDC_13DE)
;;     0FDC:14BA (in fn0FDC_13DE)
;;     0FDC:14F8 (in fn0FDC_13DE)
;;     0FDC:1518 (in fn0FDC_13DE)
;;     0FDC:1655 (in fn0FDC_15E6)
;;     0FDC:166E (in fn0FDC_15E6)
;;     0FDC:167B (in fn0FDC_15E6)
;;     0FDC:16BC (in fn0FDC_15E6)
;;     0FDC:16F2 (in fn0FDC_15E6)
;;     0FDC:1712 (in fn0FDC_15E6)
;;     0FDC:1858 (in fn0FDC_17B9)
;;     0FDC:187D (in fn0FDC_17B9)
;;     0FDC:1898 (in fn0FDC_17B9)
;;     0FDC:1912 (in fn0FDC_17B9)
;;     0FDC:1937 (in fn0FDC_17B9)
;;     0FDC:1944 (in fn0FDC_17B9)
;;     0FDC:1991 (in fn0FDC_17B9)
;;     0FDC:199E (in fn0FDC_17B9)
;;     0FDC:19CE (in fn0FDC_17B9)
;;     0FDC:19ED (in fn0FDC_19E1)
;;     0FDC:1A7C (in fn0FDC_1A26)
;;     11B8:0018 (in fn11B8_0002)
;;     11B8:01A6 (in fn11B8_0002)
;;     11B8:01BD (in fn11B8_0002)
;;     11B8:01F6 (in fn11B8_0002)
;;     11B8:0219 (in fn11B8_0002)
;;     11B8:0231 (in fn11B8_0002)
;;     11B8:024E (in fn11B8_0002)
;;     11B8:0267 (in fn11B8_0002)
;;     11B8:0322 (in fn11B8_0002)
;;     11B8:0342 (in fn11B8_0002)
;;     11B8:034F (in fn11B8_0002)
;;     11B8:035C (in fn11B8_0002)
;;     11B8:0378 (in fn11B8_0002)
;;     11B8:0391 (in fn11B8_0002)
;;     11B8:044C (in fn11B8_0002)
;;     11B8:046C (in fn11B8_0002)
;;     11B8:0484 (in fn11B8_0002)
;;     11B8:0497 (in fn11B8_0002)
;;     11B8:04A4 (in fn11B8_0002)
;;     11B8:04BD (in fn11B8_0002)
;;     11B8:055A (in fn11B8_0002)
;;     11B8:0574 (in fn11B8_0002)
;;     11B8:05D8 (in fn11B8_0002)
;;     11B8:061E (in fn11B8_0002)
;;     11B8:0641 (in fn11B8_0002)
;;     11B8:0760 (in fn11B8_0002)
;;     11B8:0782 (in fn11B8_0002)
;;     11B8:078F (in fn11B8_0002)
;;     11B8:07AC (in fn11B8_0002)
;;     11B8:07F8 (in fn11B8_0002)
;;     11B8:081F (in fn11B8_080A)
;;     11B8:0853 (in fn11B8_080A)
;;     11B8:088E (in fn11B8_080A)
;;     11B8:0936 (in fn11B8_0925)
;;     11B8:0954 (in fn11B8_0925)
;;     11B8:0D46 (in fn11B8_0925)
;;     11B8:0D71 (in fn11B8_0D58)
;;     11B8:0DB1 (in fn11B8_0D58)
;;     11B8:0DBE (in fn11B8_0D58)
;;     11B8:0FBC (in fn11B8_0D58)
;;     11B8:0FEA (in fn11B8_0D58)
;;     11B8:0FF7 (in fn11B8_0D58)
;;     11B8:1779 (in fn11B8_1762)
;;     11B8:186E (in fn11B8_1762)
;;     11B8:18B3 (in fn11B8_1762)
;;     11B8:18EC (in fn11B8_1762)
;;     11B8:19C2 (in fn11B8_1762)
;;     11B8:19DD (in fn11B8_1762)
;;     135D:03D1 (in fn135D_03AA)
;;     135D:03EF (in fn135D_03AA)
;;     135D:03FC (in fn135D_03AA)
;;     135D:0416 (in fn135D_03AA)
;;     135D:0B72 (in fn135D_0AB6)
;;     135D:0B8D (in fn135D_0AB6)
;;     135D:0BA8 (in fn135D_0AB6)
;;     1431:00E1 (in fn1431_000A)
;;     1431:0117 (in fn1431_000A)
;;     1431:012A (in fn1431_000A)
;;     1431:0168 (in fn1431_000A)
;;     1431:0175 (in fn1431_000A)
;;     1431:0193 (in fn1431_000A)
;;     1431:01A0 (in fn1431_000A)
;;     1431:0267 (in fn1431_000A)
;;     1431:0274 (in fn1431_000A)
;;     1431:02EC (in fn1431_000A)
;;     1467:0100 (in fn1467_0002)
;;     1467:0191 (in fn1467_0002)
;;     1467:01BB (in fn1467_0002)
;;     1467:020A (in fn1467_0002)
;;     1467:0239 (in fn1467_0002)
;;     1467:0264 (in fn1467_0002)
;;     1467:0271 (in fn1467_0002)
;;     1467:02B9 (in fn1467_0002)
;;     1467:0319 (in fn1467_0002)
;;     1467:0326 (in fn1467_0002)
;;     1467:03DA (in fn1467_0002)
;;     1467:0550 (in fn1467_0002)
;;     1467:055D (in fn1467_0002)
;;     1467:058D (in fn1467_0002)
;;     1467:059A (in fn1467_0002)
;;     1467:05B8 (in fn1467_0002)
;;     1467:0642 (in fn1467_0002)
;;     1467:0666 (in fn1467_0002)
;;     1467:0739 (in fn1467_0002)
;;     1467:07E0 (in fn1467_0002)
;;     1467:0813 (in fn1467_0002)
;;     1467:0ADC (in fn1467_08A8)
;;     1467:0C7B (in fn1467_0B98)
;;     1467:0CD2 (in fn1467_0B98)
;;     1467:0CDF (in fn1467_0B98)
;;     1543:00B4 (in fn1543_0004)
;;     1543:0104 (in fn1543_0004)
;;     1543:012F (in fn1543_0004)
;;     1543:0149 (in fn1543_0004)
;;     1543:01B7 (in fn1543_0004)
;;     1543:0210 (in fn1543_0004)
;;     1543:022E (in fn1543_0004)
;;     1543:02DE (in fn1543_0004)
;;     1543:02F7 (in fn1543_0004)
;;     1543:0398 (in fn1543_0004)
;;     1543:03E1 (in fn1543_0004)
;;     1543:0483 (in fn1543_0004)
;;     1543:0556 (in fn1543_0004)
;;     1543:05AF (in fn1543_0004)
;;     1543:065A (in fn1543_0004)
;;     1543:0673 (in fn1543_0004)
;;     1543:0680 (in fn1543_0004)
;;     1543:06A5 (in fn1543_0004)
;;     1543:06B2 (in fn1543_0004)
;;     1543:06DC (in fn1543_0004)
;;     1543:06E9 (in fn1543_0004)
;;     1543:0710 (in fn1543_0004)
;;     1543:0736 (in fn1543_0004)
;;     1543:0743 (in fn1543_0004)
;;     1543:07E1 (in fn1543_07CB)
;;     1543:0830 (in fn1543_07CB)
;;     1543:087B (in fn1543_07CB)
;;     1543:08BF (in fn1543_07CB)
;;     1543:0929 (in fn1543_07CB)
;;     1543:09A4 (in fn1543_07CB)
;;     1543:09B1 (in fn1543_07CB)
;;     1543:0B76 (in fn1543_0A35)
;;     1543:0D5D (in fn1543_0CDE)
;;     1631:0322 (in fn1631_02E4)
;;     1631:1084 (in fn1631_1057)
;;     1631:1DC2 (in fn1631_1DAB)
;;     1631:201C (in fn1631_1FDF)
;;     1631:208B (in fn1631_1FDF)
;;     183B:0364 (in fn183B_000A)
;;     183B:03A7 (in fn183B_000A)
;;     183B:03BF (in fn183B_000A)
;;     183B:042A (in fn183B_000A)
;;     183B:0458 (in fn183B_000A)
;;     183B:04AC (in fn183B_000A)
;;     183B:06A2 (in fn183B_000A)
;;     183B:06C1 (in fn183B_000A)
;;     183B:0904 (in fn183B_000A)
;;     183B:0932 (in fn183B_000A)
;;     183B:093F (in fn183B_000A)
;;     183B:094C (in fn183B_000A)
;;     183B:0959 (in fn183B_000A)
;;     183B:0966 (in fn183B_000A)
;;     183B:09F2 (in fn183B_000A)
;;     183B:09FF (in fn183B_000A)
;;     183B:0A31 (in fn183B_000A)
;;     183B:0A3E (in fn183B_000A)
;;     183B:0A6F (in fn183B_000A)
;;     183B:0A7C (in fn183B_000A)
;;     183B:0A89 (in fn183B_000A)
;;     183B:0B66 (in fn183B_000A)
;;     183B:0B73 (in fn183B_000A)
;;     183B:0B80 (in fn183B_000A)
;;     183B:0B8D (in fn183B_000A)
;;     183B:0C2E (in fn183B_000A)
;;     183B:0C3B (in fn183B_000A)
;;     183B:0C48 (in fn183B_000A)
;;     183B:0C7F (in fn183B_000A)
;;     183B:0C8C (in fn183B_000A)
;;     183B:0C99 (in fn183B_000A)
;;     183B:10D2 (in fn183B_000A)
;;     183B:12D5 (in fn183B_000A)
;;     183B:1327 (in fn183B_000A)
;;     183B:13FE (in fn183B_000A)
;;     183B:155E (in fn183B_14C3)
;;     183B:15A9 (in fn183B_14C3)
;;     183B:15C3 (in fn183B_14C3)
;;     183B:1CEB (in fn183B_1C1F)
;;     183B:1D4A (in fn183B_1C1F)
;;     183B:1D57 (in fn183B_1C1F)
;;     183B:1D6E (in fn183B_1C1F)
;;     183B:1D7B (in fn183B_1C1F)
;;     183B:1DA0 (in fn183B_1C1F)
;;     183B:1DAD (in fn183B_1C1F)
;;     183B:1E99 (in fn183B_1C1F)
;;     183B:1EF9 (in fn183B_1C1F)
;;     183B:1F28 (in fn183B_1C1F)
;;     183B:1F4C (in fn183B_1C1F)
;;     183B:1F59 (in fn183B_1C1F)
;;     183B:1F72 (in fn183B_1C1F)
;;     183B:1F99 (in fn183B_1C1F)
;;     183B:1FB7 (in fn183B_1C1F)
;;     183B:227D (in fn183B_2231)
;;     183B:229F (in fn183B_2231)
;;     183B:2511 (in fn183B_24F0)
;;     183B:2577 (in fn183B_2556)
;;     183B:25B8 (in fn183B_2591)
;;     183B:2640 (in fn183B_2591)
;;     183B:2670 (in fn183B_2591)
;;     183B:26DB (in fn183B_2591)
;;     1CD3:01AA (in fn1CD3_0004)
;;     1CD3:01B7 (in fn1CD3_0004)
;;     1CD3:02AA (in fn1CD3_0004)
;;     1CD3:02D4 (in fn1CD3_0004)
;;     1CD3:02F3 (in fn1CD3_0004)
;;     1CD3:0306 (in fn1CD3_0004)
;;     1CD3:036C (in fn1CD3_0004)
;;     1CD3:041D (in fn1CD3_0004)
;;     1CD3:04C9 (in fn1CD3_0004)
;;     1CD3:04E5 (in fn1CD3_0004)
;;     1CD3:0523 (in fn1CD3_0004)
;;     1CD3:05FC (in fn1CD3_0004)
;;     1CD3:0614 (in fn1CD3_0004)
;;     1CD3:0660 (in fn1CD3_0004)
;;     1CD3:066D (in fn1CD3_0004)
;;     1CD3:0684 (in fn1CD3_0004)
;;     1CD3:0691 (in fn1CD3_0004)
;;     1CD3:06FC (in fn1CD3_0004)
;;     1CD3:070F (in fn1CD3_0004)
;;     1CD3:0744 (in fn1CD3_0004)
;;     1CD3:0760 (in fn1CD3_0004)
;;     1CD3:0785 (in fn1CD3_0004)
;;     1CD3:084C (in fn1CD3_0004)
;;     1CD3:0864 (in fn1CD3_0004)
;;     1CD3:08B0 (in fn1CD3_0004)
;;     1CD3:08BD (in fn1CD3_0004)
;;     1CD3:08D4 (in fn1CD3_0004)
;;     1CD3:08E1 (in fn1CD3_0004)
;;     1CD3:094C (in fn1CD3_0004)
;;     1CD3:0959 (in fn1CD3_0004)
;;     1CD3:09B9 (in fn1CD3_0004)
;;     1CD3:0BA1 (in fn1CD3_0004)
;;     1CD3:0F2C (in fn1CD3_0004)
;;     1CD3:0F41 (in fn1CD3_0004)
;;     1CD3:0F72 (in fn1CD3_0004)
;;     1CD3:0F7F (in fn1CD3_0004)
;;     1CD3:0FA0 (in fn1CD3_0004)
;;     1CD3:0FB8 (in fn1CD3_0004)
;;     1CD3:1032 (in fn1CD3_0004)
;;     1CD3:145E (in fn1CD3_0004)
;;     1CD3:147C (in fn1CD3_0004)
;;     1CD3:1489 (in fn1CD3_0004)
;;     1CD3:17FA (in fn1CD3_17EA)
;;     1CD3:1815 (in fn1CD3_1809)
;;     1CD3:182A (in fn1CD3_181E)
;;     1F3D:007C (in fn1F3D_0053)
fn1E56_03F5 proc
	push	bp
	mov	bp,sp
	mov	ax,62h
	call	far 207Fh:2FDCh
	push	di
	push	si
	sub	ax,ax
	mov	[bp-2h],ax
	mov	[bp-8h],ax
	mov	[bp-6h],ax
	mov	byte ptr [bp-32h],0h
	mov	es,[56E2h]
	mov	ax,es:[3748h]

l1E56_0419:
	mov	[bp-60h],ax
	jmp	0752h

l1E56_041F:
	cmp	word ptr [bp-2h],0h
	jz	0428h

l1E56_0425:
	jmp	0768h

l1E56_0428:
	test	byte ptr [bp-4h],80h
	jz	0437h

l1E56_042E:
	and	byte ptr [bp-4h],7Fh
	mov	word ptr [bp-2h],1h

l1E56_0437:
	cmp	byte ptr [bp-4h],0Dh
	jnz	0497h

l1E56_043D:
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	mov	ax,[bp-8h]
	add	ax,[bp-60h]
	mov	es,[56D6h]
	cmp	ax,es:[3990h]
	jg	0470h

l1E56_0455:
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	jmp	0487h

l1E56_0470:
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	mov	ax,1h
	push	ax
	lea	ax,[bp-5Eh]

l1E56_0487:
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	sub	ax,ax
	mov	[bp-8h],ax
	jmp	0419h

l1E56_0497:
	cmp	byte ptr [bp-4h],2h
	jnz	0516h

l1E56_049D:
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	mov	ax,[bp-8h]
	add	ax,[bp-60h]
	mov	es,[56D6h]
	cmp	ax,es:[3990h]
	jg	04CFh

l1E56_04B5:
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	sub	ax,ax
	push	ax
	lea	ax,[bp-32h]
	jmp	04E5h

l1E56_04CF:
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	sub	ax,ax
	push	ax
	lea	ax,[bp-5Eh]

l1E56_04E5:
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	mov	word ptr [bp-8h],0h
	mov	es,[56E2h]
	mov	ax,es:[3748h]
	mov	[bp-60h],ax
	mov	bx,[bp-6h]
	inc	word ptr [bp-6h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	es,[56E0h]
	mov	es:[377Eh],ax
	jmp	0752h

l1E56_0516:
	cmp	byte ptr [bp-4h],6h
	jnz	0595h

l1E56_051C:
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	mov	ax,[bp-8h]
	add	ax,[bp-60h]
	mov	es,[56D6h]
	cmp	ax,es:[3990h]
	jg	054Eh

l1E56_0534:
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	sub	ax,ax
	push	ax
	lea	ax,[bp-32h]
	jmp	0564h

l1E56_054E:
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	sub	ax,ax
	push	ax
	lea	ax,[bp-5Eh]

l1E56_0564:
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	mov	word ptr [bp-8h],0h
	mov	es,[56E2h]
	mov	ax,es:[3748h]
	mov	[bp-60h],ax
	mov	bx,[bp-6h]
	inc	word ptr [bp-6h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	es,[56DCh]
	mov	es:[37FEh],ax
	jmp	0752h

l1E56_0595:
	cmp	byte ptr [bp-4h],9h
	jz	059Eh

l1E56_059B:
	jmp	062Bh

l1E56_059E:
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	mov	ax,[bp-8h]
	add	ax,[bp-60h]
	mov	es,[56D6h]
	cmp	ax,es:[3990h]
	jg	05D0h

l1E56_05B6:
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	sub	ax,ax
	push	ax
	lea	ax,[bp-32h]
	jmp	05E6h

l1E56_05D0:
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	sub	ax,ax
	push	ax
	lea	ax,[bp-5Eh]

l1E56_05E6:
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	mov	word ptr [bp-8h],0h
	mov	bx,[bp-6h]
	inc	word ptr [bp-6h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-60h],ax
	mov	es,[56E2h]
	mov	es:[3748h],ax
	mov	es,[56D6h]
	mov	ax,es:[3990h]
	mov	es,[56E2h]
	cmp	es:[3748h],ax
	jge	0622h

l1E56_061F:
	jmp	0752h

l1E56_0622:
	sub	ax,ax
	mov	es:[3748h],ax
	jmp	0419h

l1E56_062B:
	cmp	byte ptr [bp-4h],13h
	jnz	0693h

l1E56_0631:
	mov	bx,[bp-6h]
	inc	word ptr [bp-6h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	cbw
	mov	[bp-34h],ax
	mov	es,[56E2h]
	cmp	es:[3748h],ax
	jl	064Fh

l1E56_064C:
	jmp	0752h

l1E56_064F:
	jmp	065Eh

l1E56_0651:
	mov	si,[bp-8h]
	inc	word ptr [bp-8h]
	mov	byte ptr [bp+si-5Eh],20h
	dec	word ptr [bp-34h]

l1E56_065E:
	mov	es,[56E2h]
	mov	ax,[bp-34h]
	cmp	es:[3748h],ax
	jl	0651h

l1E56_066C:
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h

l1E56_0685:
	mov	ax,[bp-8h]
	add	[bp-60h],ax
	mov	word ptr [bp-8h],0h
	jmp	0752h

l1E56_0693:
	cmp	byte ptr [bp-4h],20h
	jnz	070Ch

l1E56_0699:
	mov	si,[bp-8h]
	add	si,[bp-60h]
	mov	es,[56D6h]
	cmp	es:[3990h],si
	jl	06BCh

l1E56_06AA:
	jz	066Ch

l1E56_06AC:
	or	si,si
	jz	066Ch

l1E56_06B0:
	mov	di,[bp-8h]
	inc	word ptr [bp-8h]
	mov	byte ptr [bp+di-5Eh],20h
	jmp	066Ch

l1E56_06BC:
	mov	si,[bp-8h]
	inc	word ptr [bp-8h]
	mov	byte ptr [bp+si-5Eh],20h
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	mov	word ptr [bp-60h],0h
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B68h
	add	sp,8h
	jmp	06F9h

l1E56_06F6:
	inc	word ptr [bp-6h]

l1E56_06F9:
	mov	bx,[bp-6h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	mov	[bp-4h],al
	cmp	al,20h
	jz	06F6h

l1E56_0709:
	jmp	0685h

l1E56_070C:
	mov	es,[56D6h]
	mov	ax,es:[3990h]
	dec	ax
	cmp	ax,[bp-8h]
	jg	0746h

l1E56_071A:
	cmp	byte ptr [bp-32h],0h
	jz	0730h

l1E56_0720:
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h

l1E56_0730:
	mov	si,[bp-8h]
	inc	word ptr [bp-8h]
	mov	al,[bp-4h]
	mov	[bp+si-5Eh],al
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	jmp	0455h

l1E56_0746:
	mov	si,[bp-8h]
	inc	word ptr [bp-8h]
	mov	al,[bp-4h]
	mov	[bp+si-5Eh],al

l1E56_0752:
	mov	bx,[bp-6h]
	inc	word ptr [bp-6h]
	les	si,[bp+6h]
	mov	al,es:[bx+si]
	mov	[bp-4h],al
	or	al,al
	jz	0768h

l1E56_0765:
	jmp	041Fh

l1E56_0768:
	cmp	word ptr [bp-8h],0h
	jnz	0774h

l1E56_076E:
	cmp	byte ptr [bp-32h],0h
	jz	07C5h

l1E56_0774:
	mov	si,[bp-8h]
	mov	byte ptr [bp+si-5Eh],0h
	mov	ax,[bp-8h]
	add	ax,[bp-60h]
	mov	es,[56D6h]
	cmp	ax,es:[3990h]
	jg	07A6h

l1E56_078C:
	lea	ax,[bp-5Eh]
	push	ss
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	call	far 207Fh:3B22h
	add	sp,8h
	sub	ax,ax
	push	ax
	lea	ax,[bp-32h]
	jmp	07BCh

l1E56_07A6:
	mov	ax,1h
	push	ax
	lea	ax,[bp-32h]
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h
	sub	ax,ax
	push	ax
	lea	ax,[bp-5Eh]

l1E56_07BC:
	push	ss
	push	ax
	push	cs
	call	07CBh
	add	sp,6h

l1E56_07C5:
	pop	si
	pop	di
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_07CB: 1E56:07CB
;;   Called from:
;;     1E56:0479 (in fn1E56_03F5)
;;     1E56:0489 (in fn1E56_03F5)
;;     1E56:04D8 (in fn1E56_03F5)
;;     1E56:04E7 (in fn1E56_03F5)
;;     1E56:0557 (in fn1E56_03F5)
;;     1E56:0566 (in fn1E56_03F5)
;;     1E56:05D9 (in fn1E56_03F5)
;;     1E56:05E8 (in fn1E56_03F5)
;;     1E56:06D6 (in fn1E56_03F5)
;;     1E56:0729 (in fn1E56_03F5)
;;     1E56:07AF (in fn1E56_03F5)
;;     1E56:07BE (in fn1E56_03F5)
fn1E56_07CB proc
	push	bp
	mov	bp,sp
	mov	ax,14h
	call	far 207Fh:2FDCh
	push	si
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	mov	es,[56E4h]
	cmp	es:[374Eh],ax
	jge	07EDh

l1E56_07EA:
	jmp	09ABh

l1E56_07ED:
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:3B9Eh
	add	sp,4h
	mov	[bp-12h],ax
	mov	[bp-0Eh],ax
	jmp	0810h

l1E56_0803:
	mov	bx,[bp-12h]
	les	si,[bp+6h]
	mov	byte ptr es:[bx+si],20h
	inc	word ptr [bp-12h]

l1E56_0810:
	mov	es,[56D6h]
	mov	ax,[bp-12h]
	cmp	es:[3990h],ax
	jg	0803h

l1E56_081E:
	mov	bx,es:[3990h]
	les	si,[bp+6h]
	mov	byte ptr es:[bx+si],0h
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	mov	cl,3h
	shl	ax,cl
	mov	[bp-14h],ax
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	shl	ax,cl
	mov	[bp-10h],ax
	mov	es,[56E6h]
	cmp	word ptr es:[4FBAh],2h
	jnz	0877h

l1E56_0852:
	sub	ax,8h
	push	ax
	mov	es,[56D6h]
	push	word ptr es:[3990h]
	push	word ptr [bp-14h]
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	sub	ax,ax
	mov	dx,0A000h

l1E56_0870:
	push	dx
	push	ax
	mov	ax,140h
	jmp	08EEh

l1E56_0877:
	mov	es,[56E6h]
	cmp	word ptr es:[4FBAh],3h
	jz	08B7h

l1E56_0883:
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	mov	cl,3h
	shl	ax,cl
	sub	ax,8h
	push	ax
	mov	es,[56D6h]
	push	word ptr es:[3990h]
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	shl	ax,cl
	push	ax
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	sub	ax,ax
	mov	dx,0B800h
	jmp	0870h

l1E56_08B7:
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	mov	cl,3h
	shl	ax,cl
	sub	ax,8h
	push	ax
	mov	es,[56D6h]
	push	word ptr es:[3990h]
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	shl	ax,cl
	push	ax
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	sub	ax,ax
	mov	dx,0A000h
	push	dx
	push	ax
	mov	ax,0A00h

l1E56_08EE:
	push	dx
	push	ax
	call	far 207Fh:245Ch
	add	sp,10h
	mov	es,[56D2h]
	mov	si,es:[39A4h]
	mov	es,[56D8h]
	add	si,es:[393Ah]
	mov	cl,3h
	shl	si,cl
	sub	ax,ax
	push	ax
	lea	ax,[si-1h]
	push	ax
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	mov	es,[56D6h]
	add	ax,es:[3990h]
	shl	ax,cl
	sub	ax,8h
	push	ax
	lea	ax,[si-8h]
	push	ax
	mov	es,[56D0h]
	mov	ax,es:[39A0h]
	shl	ax,cl
	push	ax
	call	far 1F3Dh:01FBh
	add	sp,0Ah
	mov	es,[56E0h]
	push	word ptr es:[377Eh]
	mov	es,[56DCh]
	push	word ptr es:[37FEh]
	mov	es,[56D2h]
	mov	ax,es:[39A4h]
	mov	es,[56D8h]
	add	ax,es:[393Ah]
	dec	ax
	push	ax
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	cmp	word ptr [bp+0Ah],0h
	jz	098Ch

l1E56_0985:
	mov	es,[56E2h]
	jmp	0A1Fh

l1E56_098C:
	mov	es,[56E2h]
	mov	ax,[bp-0Eh]
	add	es:[3748h],ax
	mov	es,[56D8h]
	mov	ax,es:[393Ah]
	dec	ax
	mov	es,[56E4h]
	mov	es:[374Eh],ax
	jmp	0A0Ch

l1E56_09AB:
	mov	es,[56E0h]
	push	word ptr es:[377Eh]
	mov	es,[56DCh]
	push	word ptr es:[37FEh]
	mov	es,[56E4h]
	mov	ax,es:[374Eh]
	mov	es,[56D2h]
	add	ax,es:[39A4h]
	push	ax
	mov	es,[56E2h]
	mov	ax,es:[3748h]
	mov	es,[56D0h]
	add	ax,es:[39A0h]
	push	ax
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 1F3Dh:00D5h
	add	sp,0Ch
	cmp	word ptr [bp+0Ah],0h
	jnz	0985h

l1E56_09F5:
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	call	far 207Fh:3B9Eh
	add	sp,4h
	mov	es,[56E2h]
	add	es:[3748h],ax

l1E56_0A0C:
	mov	es,[56D6h]
	mov	ax,es:[3990h]
	mov	es,[56E2h]
	cmp	es:[3748h],ax
	jl	0A2Fh

l1E56_0A1F:
	mov	word ptr es:[3748h],0h
	mov	es,[56E4h]
	inc	word ptr es:[374Eh]

l1E56_0A2F:
	les	bx,[bp+6h]
	mov	byte ptr es:[bx],0h
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_0A3B: 1E56:0A3B
;;   Called from:
;;     1E56:0B2D (in fn1E56_0AE5)
fn1E56_0A3B proc
	push	bp
	mov	bp,sp
	mov	ax,4h
	call	far 207Fh:2FDCh
	mov	es,[56E6h]
	cmp	word ptr es:[4FBAh],2h
	jz	0ACDh

l1E56_0A52:
	mov	word ptr [bp-2h],50h
	cmp	word ptr es:[4FBAh],0h
	jz	0A73h

l1E56_0A5F:
	mov	ax,280h
	imul	word ptr [bp+10h]
	mov	cx,[bp+0Eh]
	shl	cx,1h
	add	ax,cx
	shl	ax,1h
	add	[bp+6h],ax
	jmp	0A86h

l1E56_0A73:
	mov	ax,140h
	imul	word ptr [bp+10h]
	add	ax,[bp+0Eh]
	shl	ax,1h
	add	[bp+6h],ax
	mov	word ptr [bp-2h],28h

l1E56_0A86:
	mov	word ptr [bp-4h],0h
	jmp	0A90h

l1E56_0A8D:
	inc	word ptr [bp-4h]

l1E56_0A90:
	cmp	word ptr [bp-4h],8h
	jge	0AE1h

l1E56_0A96:
	les	bx,[bp+6h]
	mov	ax,es:[bx]
	les	bx,[bp+0Ah]
	add	word ptr [bp+0Ah],2h
	mov	es:[bx],ax
	mov	es,[56E6h]
	cmp	word ptr es:[4FBAh],0h
	jz	0AC3h

l1E56_0AB2:
	les	bx,[bp+6h]
	mov	ax,es:[bx+2h]
	les	bx,[bp+0Ah]
	add	word ptr [bp+0Ah],2h
	mov	es:[bx],ax

l1E56_0AC3:
	mov	ax,[bp-2h]
	shl	ax,1h
	add	[bp+6h],ax
	jmp	0A8Dh

l1E56_0ACD:
	push	word ptr [bp+10h]
	push	word ptr [bp+0Eh]
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	call	far 207Fh:0313h
	add	sp,8h

l1E56_0AE1:
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_0AE5: 1E56:0AE5
;;   Called from:
;;     0D27:0288 (in main)
;;     0D27:030A (in main)
fn1E56_0AE5 proc
	push	bp
	mov	bp,sp
	mov	ax,0Eh
	call	far 207Fh:2FDCh
	mov	ax,[bp+0Eh]
	mov	cl,5h
	shl	ax,cl
	cwd
	mov	[bp-4h],ax
	mov	[bp-2h],dx
	push	dx
	push	ax
	call	far 1F3Dh:05BCh
	add	sp,4h
	mov	[bp-0Ah],ax
	mov	[bp-8h],dx
	mov	[bp-0Eh],ax
	mov	[bp-0Ch],dx
	mov	word ptr [bp-6h],0h
	jmp	0B4Ch

l1E56_0B1B:
	push	word ptr [bp+0Ch]
	push	word ptr [bp+0Ah]
	push	word ptr [bp-8h]
	push	word ptr [bp-0Ah]
	push	word ptr [bp+8h]
	push	word ptr [bp+6h]
	push	cs
	call	0A3Bh
	add	sp,0Ch
	inc	word ptr [bp+0Ah]
	cmp	word ptr [bp+0Ah],27h
	jle	0B45h

l1E56_0B3D:
	mov	word ptr [bp+0Ah],0h
	inc	word ptr [bp+0Ch]

l1E56_0B45:
	add	word ptr [bp-0Ah],20h
	inc	word ptr [bp-6h]

l1E56_0B4C:
	mov	ax,[bp+0Eh]
	cmp	[bp-6h],ax
	jl	0B1Bh

l1E56_0B54:
	mov	ax,[bp-0Eh]
	mov	dx,[bp-0Ch]
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_0B5E: 1E56:0B5E
;;   Called from:
;;     0800:2D1C (in fn0800_2C50)
;;     0800:32E1 (in fn0800_32B3)
;;     0800:360F (in fn0800_35D3)
;;     0800:3C13 (in fn0800_3BD0)
;;     0800:3C7E (in fn0800_3BD0)
;;     0800:3CCC (in fn0800_3BD0)
;;     0800:3D01 (in fn0800_3BD0)
;;     0DAB:16A5 (in fn0DAB_1467)
;;     0FDC:0276 (in fn0FDC_01C0)
;;     0FDC:153B (in fn0FDC_13DE)
;;     0FDC:172A (in fn0FDC_15E6)
;;     0FDC:18B0 (in fn0FDC_17B9)
;;     11B8:0659 (in fn11B8_0002)
;;     1467:0371 (in fn1467_0002)
;;     1467:06DE (in fn1467_0002)
;;     1467:0A5D (in fn1467_08A8)
;;     1467:0D53 (in fn1467_0B98)
;;     1543:04A9 (in fn1543_0004)
;;     1543:09C9 (in fn1543_07CB)
;;     183B:15F3 (in fn183B_14C3)
;;     183B:253F (in fn183B_24F0)
;;     183B:25DD (in fn183B_2591)
;;     1CD3:04FA (in fn1CD3_0004)
;;     1CD3:0775 (in fn1CD3_0004)
;;     1CD3:0BC6 (in fn1CD3_0004)
fn1E56_0B5E proc
	push	bp
	mov	bp,sp
	mov	ax,0Ch
	call	far 207Fh:2FDCh
	push	si
	mov	si,[bp+6h]
	mov	cl,4h
	shl	si,cl
	mov	es,[56DEh]
	mov	ax,es:[si+92h]
	mov	es,[56D2h]
	add	ax,es:[39A4h]
	mov	[bp-0Ah],ax
	mov	word ptr [bp-2h],1h
	mov	es,[56DEh]
	mov	ax,es:[si+96h]
	cmp	es:[si+98h],ax
	jl	0BA2h

l1E56_0B9B:
	mov	word ptr es:[si+98h],0h

l1E56_0BA2:
	mov	es,[56E8h]
	cmp	word ptr es:[3938h],0h
	jnz	0BBAh

l1E56_0BAE:
	mov	es,[56EAh]
	cmp	word ptr es:[458Ch],0h
	jz	0BCCh

l1E56_0BBA:
	mov	bx,[bp+6h]
	mov	cl,4h
	shl	bx,cl
	mov	es,[56DEh]
	mov	word ptr es:[bx+98h],0h

l1E56_0BCC:
	mov	si,[bp+6h]
	mov	cl,4h
	shl	si,cl
	mov	es,[56DEh]
	mov	ax,es:[si+98h]
	mov	[bp-0Ch],ax
	mov	[bp-4h],ax
	mov	es,[56ECh]
	mov	word ptr es:[0B782h],0h
	mov	es,[56DEh]
	push	word ptr es:[si+9Ch]
	push	word ptr es:[si+94h]
	mov	ax,[bp-0Ah]
	add	ax,[bp-0Ch]
	push	ax
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	call	far 207Fh:2B87h
	add	sp,8h
	call	far 0800h:2A2Bh
	jmp	0CEBh

l1E56_0C1B:
	call	far 1F3Dh:0259h
	mov	[bp-8h],ax
	push	ax
	push	cs
	call	0D1Dh
	add	sp,2h
	mov	[bp-8h],ax
	cmp	ax,0Dh
	jz	0C38h

l1E56_0C33:
	cmp	ax,20h
	jnz	0C40h

l1E56_0C38:
	mov	word ptr [bp-2h],0h
	jmp	0CEBh

l1E56_0C40:
	cmp	word ptr [bp-8h],0B8h
	jz	0C4Fh

l1E56_0C46:
	cmp	word ptr [bp-8h],0B0h
	jz	0C4Fh

l1E56_0C4C:
	jmp	0CEBh

l1E56_0C4F:
	mov	si,[bp+6h]
	mov	cl,4h
	shl	si,cl
	mov	es,[56DEh]
	push	word ptr es:[si+9Ch]
	push	word ptr es:[si+94h]
	mov	ax,[bp-0Ah]
	add	ax,[bp-0Ch]
	push	ax
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	call	far 207Fh:2B87h
	add	sp,8h
	cmp	word ptr [bp-8h],0B8h
	jnz	0C85h

l1E56_0C82:
	dec	word ptr [bp-0Ch]

l1E56_0C85:
	cmp	word ptr [bp-8h],0B0h
	jnz	0C8Eh

l1E56_0C8B:
	inc	word ptr [bp-0Ch]

l1E56_0C8E:
	cmp	word ptr [bp-0Ch],0h
	jge	0CA8h

l1E56_0C94:
	mov	bx,[bp+6h]
	mov	cl,4h
	shl	bx,cl
	mov	es,[56DEh]
	mov	ax,es:[bx+96h]
	dec	ax
	mov	[bp-0Ch],ax

l1E56_0CA8:
	mov	ax,[bp-0Ch]
	mov	bx,[bp+6h]
	mov	cl,4h
	shl	bx,cl
	mov	es,[56DEh]
	cmp	es:[bx+96h],ax
	jg	0CC2h

l1E56_0CBD:
	mov	word ptr [bp-0Ch],0h

l1E56_0CC2:
	mov	si,[bp+6h]
	mov	cl,4h
	shl	si,cl
	push	word ptr es:[si+9Ch]
	push	word ptr es:[si+94h]
	mov	ax,[bp-0Ah]
	add	ax,[bp-0Ch]
	push	ax
	mov	es,[56D0h]
	push	word ptr es:[39A0h]
	call	far 207Fh:2B87h
	add	sp,8h

l1E56_0CEB:
	cmp	word ptr [bp-2h],0h
	jz	0CF4h

l1E56_0CF1:
	jmp	0C1Bh

l1E56_0CF4:
	cmp	word ptr [bp-8h],1Bh
	jz	0D0Fh

l1E56_0CFA:
	mov	ax,[bp-0Ch]
	mov	bx,[bp+6h]
	mov	cl,4h
	shl	bx,cl
	mov	es,[56DEh]
	mov	es:[bx+98h],ax
	jmp	0D15h

l1E56_0D0F:
	mov	ax,[bp-4h]
	mov	[bp-0Ch],ax

l1E56_0D15:
	mov	ax,[bp-0Ch]
	pop	si
	mov	sp,bp
	pop	bp
	retf

;; fn1E56_0D1D: 1E56:0D1D
;;   Called from:
;;     0800:0052 (in fn0800_0000)
;;     0800:1A6B (in fn0800_1A13)
;;     0800:3DB9 (in fn0800_3D40)
;;     0FDC:091D (in fn0FDC_0629)
;;     183B:1FE7 (in fn183B_1C1F)
;;     1E56:0C24 (in fn1E56_0B5E)
fn1E56_0D1D proc
	push	bp
	mov	bp,sp
	xor	ax,ax
	call	far 207Fh:2FDCh
	mov	ax,[bp+6h]
	cmp	ax,41h
	jz	0D69h

l1E56_0D2F:
	jle	0D34h

l1E56_0D31:
	jmp	0DDDh

l1E56_0D34:
	cmp	ax,0FFB9h
	jz	0D79h

l1E56_0D39:
	jg	0DA8h

l1E56_0D3B:
	cmp	ax,0FFB1h
	jz	0D51h

l1E56_0D40:
	jg	0D91h

l1E56_0D42:
	cmp	ax,0FF0Ch
	jz	0D71h

l1E56_0D47:
	cmp	ax,0FFAFh
	jz	0D61h

l1E56_0D4C:
	cmp	ax,0FFB0h
	jmp	0DBCh

l1E56_0D51:
	mov	word ptr [bp+6h],0FFB1h
	jmp	0E71h

l1E56_0D59:
	mov	word ptr [bp+6h],0FFB0h
	jmp	0E71h

l1E56_0D61:
	mov	word ptr [bp+6h],0FFAFh
	jmp	0E71h

l1E56_0D69:
	mov	word ptr [bp+6h],0FFB5h
	jmp	0E71h

l1E56_0D71:
	mov	word ptr [bp+6h],0FFB3h
	jmp	0E71h

l1E56_0D79:
	mov	word ptr [bp+6h],0FFB9h
	jmp	0E71h

l1E56_0D81:
	mov	word ptr [bp+6h],0FFB8h
	jmp	0E71h

l1E56_0D89:
	mov	word ptr [bp+6h],0FFB7h
	jmp	0E71h

l1E56_0D91:
	cmp	ax,0FFB3h
	jz	0D71h

l1E56_0D96:
	cmp	ax,0FFB5h
	jz	0D69h

l1E56_0D9B:
	cmp	ax,0FFB7h
	jz	0D89h

l1E56_0DA0:
	cmp	ax,0FFB8h
	jz	0D81h

l1E56_0DA5:
	jmp	0E71h

l1E56_0DA8:
	cmp	ax,33h
	jz	0D61h

l1E56_0DAD:
	jg	0DC1h

l1E56_0DAF:
	cmp	ax,0Ch
	jz	0D71h

l1E56_0DB4:
	cmp	ax,31h
	jz	0D51h

l1E56_0DB9:
	cmp	ax,32h

l1E56_0DBC:
	jz	0D59h

l1E56_0DBE:
	jmp	0E71h

l1E56_0DC1:
	cmp	ax,34h
	jz	0D69h

l1E56_0DC6:
	cmp	ax,36h
	jz	0D71h

l1E56_0DCB:
	cmp	ax,37h
	jz	0D79h

l1E56_0DD0:
	cmp	ax,38h
	jz	0D81h

l1E56_0DD5:
	cmp	ax,39h

l1E56_0DD8:
	jz	0D89h

l1E56_0DDA:
	jmp	0E71h

l1E56_0DDD:
	cmp	ax,60h
	jnz	0DE5h

l1E56_0DE2:
	jmp	0D59h

l1E56_0DE5:
	jg	0E25h

l1E56_0DE7:
	cmp	ax,51h
	jz	0D79h

l1E56_0DEC:
	jg	0E03h

l1E56_0DEE:
	cmp	ax,43h
	jnz	0DF6h

l1E56_0DF3:
	jmp	0D61h

l1E56_0DF6:
	cmp	ax,44h
	jnz	0DFEh

l1E56_0DFB:
	jmp	0D71h

l1E56_0DFE:
	cmp	ax,45h
	jmp	0DD8h

l1E56_0E03:
	cmp	ax,57h
	jnz	0E0Bh

l1E56_0E08:
	jmp	0D81h

l1E56_0E0B:
	cmp	ax,58h
	jnz	0E13h

l1E56_0E10:
	jmp	0D59h

l1E56_0E13:
	cmp	ax,5Ah
	jnz	0E1Bh

l1E56_0E18:
	jmp	0D51h

l1E56_0E1B:
	cmp	ax,5Ch
	jnz	0E23h

l1E56_0E20:
	jmp	0D79h

l1E56_0E23:
	jmp	0E71h

l1E56_0E25:
	sub	ax,61h
	cmp	ax,1Dh
	ja	0E71h

l1E56_0E2D:
	add	ax,ax
	xchg	bx,ax
	jmp	word ptr cs:[bx+0E35h]
l1E56_0E35	dw	0x0D69
l1E56_0E37	dw	0x0E71
l1E56_0E39	dw	0x0D61
l1E56_0E3B	dw	0x0D71
l1E56_0E3D	dw	0x0D89
l1E56_0E3F	dw	0x0E71
l1E56_0E41	dw	0x0E71
l1E56_0E43	dw	0x0E71
l1E56_0E45	dw	0x0E71
l1E56_0E47	dw	0x0E71
l1E56_0E49	dw	0x0E71
l1E56_0E4B	dw	0x0E71
l1E56_0E4D	dw	0x0E71
l1E56_0E4F	dw	0x0E71
l1E56_0E51	dw	0x0E71
l1E56_0E53	dw	0x0E71
l1E56_0E55	dw	0x0D79
l1E56_0E57	dw	0x0E71
l1E56_0E59	dw	0x0E71
l1E56_0E5B	dw	0x0E71
l1E56_0E5D	dw	0x0E71
l1E56_0E5F	dw	0x0E71
l1E56_0E61	dw	0x0D81
l1E56_0E63	dw	0x0D59
l1E56_0E65	dw	0x0E71
l1E56_0E67	dw	0x0D51
l1E56_0E69	dw	0x0E71
l1E56_0E6B	dw	0x0D69
l1E56_0E6D	dw	0x0E71
l1E56_0E6F	dw	0x0D81
