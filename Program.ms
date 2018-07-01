;
; AssemblerApplication1.asm
;
; Created: 9/6/2018 7:40:24
; Author : cisco
;


; Replace with your application code
start:
    CALL set_timer //aranco timer
	call set_io ;configuro puertos
	call enviar_serial
loop:
	call pulso
	call wait //esperar bandera
	call clear_time_stamp //limpiar registro
	call wait
	call capture_time
	ldi		r24,116
	call calcular_distancia
	ldi	r24,10
	call calcular_distancia
	mov r5,r2
	call calcular_distancia
	mov r6,r2
	call calcular_distancia
	mov r7,r0
	ldi r16,58
	call usar_trasmit
	mov r16,r5
	call usar_trasmit
	mov r16,r6
	call usar_trasmit
	mov r16,r7
	call usar_trasmit
	ldi r16,10
	call usar_trasmit
  rjmp loop
set_timer:
	LDI R16,0X00
	STS TCCR4A,R16
	LDI R16,0X42
	STS TCCR4B, R16
ret
wait:
	IN r20,tifr4
	sbrs r20,icf4
	rjmp wait
ret
clear_time_stamp:
	ldi r16,0x00
	sts icr4h,r16
	sts icr4l,r16
	sts tcnt4h,r16
	sts tcnt4l,r16
	ldi r16,0x02; flanco de bajada
	sts	tccr4b,r16

ret

capture_time:
	lds r1,icr4h ;copio icr
	lds r0,icr4l
	ldi r16,0x42 ;Falnco de subida y prescalar franco de b
	sts	tccr4b,r16
ret
; 16/8 division, 16 bit result, 8 bit remainder
; divide r1:r0 by r24, quotient in r1:r0, remainder in r2
calcular_distancia:

				;por formula y pre escaler
        clr     r2               ; clear remainder
        ldi     r25,0x10         ; 16 bits
_d161:  lsl     r0
        rol     r1
        rol     r2               ; next dividend bit to r2
        brcs    _d162            ; this should never, ever, happen
        cp      r2,r24           ; trial subtraction
        brcs    _d163            ; not big enough
_d162:  sub     r2,r24           ; ok, subtract it
        inc     r0               ; add this power of 2 to quotient
_d163:  dec     r25              ; count bit
        brne    _d161            ; do until done
        ret                      ; remainder in r2


set_io:
	LDI R16,0X01
	OUT DDRA,R16	;PUERTO A0 C

ret
pulso:
	ldi r18,0x0
	out porta,r18
	call deley_20us
	ldi r18,0x0
	out porta,r18
ret
deley_20us:
	ldi r17,100
	_delay:
		dec r17
		brne _delay
ret



pasar_ascii:
	ldi r16,48
	add r5,r16
	add r6,r16
	add r7,r16
ret
usar_trasmit:
	lds r17, UCSR0A
	sbrs r17, UDRE0
	rjmp usar_trasmit
	sts UDR0,r16
RET
enviar_serial:
ldi r17, 0
	ldi r16, 103
	sts UBRR0H,r17
	sts UBRR0L,r16
	ldi r16, (1<<TXEN0)
	sts UCSR0B,r16
ret
