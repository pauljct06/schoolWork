# Folder L1/2.asm

	.text					# informs the assembler that intructions to follow
	.globl main				# delcare as global the label main

main:						# Execution starts at main:
	li	$t0, 2				
	addi	$t5, $t0, 3			
	li $v0, 10				
	syscall					