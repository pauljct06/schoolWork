# Read and Print integer f

	.text
	.globl main

main: 
	li $t0, 24
	li $t1, 8
	div $t0, $t1
	mflo $t3
	mfhi $t4
	la $a0, message
	li $v0, 4
	syscall 
	
	move $a0, $t3
	li $v0, 1
	syscall
	
	li $v0, 10
	syscall
	
	.data

message:
	.asciiz "The answer is: "
