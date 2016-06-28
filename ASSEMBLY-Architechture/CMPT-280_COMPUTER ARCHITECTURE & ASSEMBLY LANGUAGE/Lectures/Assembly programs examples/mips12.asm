# Read and Print integer f

	.text
	.globl main

main: 

	li $t1, 100
	srl  $t0, $t1, 1
	li $v0, 1
	move $a0, $t0
	syscall
	
	li $v0, 10
	syscall