# Folder L1/1.asm

	.text					# informs the assembler that intructions to follow
	.globl main				# delcare as global the label main

main:						# Execution starts at main:
	li	$t0, 2				# $t0 = 2
	li	$t1, 3				# $t1 = 3
	add	$t5, $t1, $t0			# $t5 = $t1 + $t0
	li $v0, 10				# system call for exit (load code 10)
	syscall					# Call operationg system to perform operation (exit)