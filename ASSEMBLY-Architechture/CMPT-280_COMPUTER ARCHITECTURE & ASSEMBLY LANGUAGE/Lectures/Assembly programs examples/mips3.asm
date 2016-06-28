# Folder L1/2.asm

	.text					# informs the assembler that intructions to follow
	.globl main				# delcare as global the label main

main:	
	li	$t0, 1
	li	$t1, 3
	add	$t2, $t0, $t1			
	addi	$t3, $t2, 4
	li $v0, 10				
	syscall