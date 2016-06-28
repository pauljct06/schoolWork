# Read and Print integer f

	.text
	.globl main

main: 
	li $t0, 26
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
	
	move $a0, $t4			# this a a test to see if i can print the remainder next to the quotient
	li $v0, 1
	syscall
	
	li $v0, 10
	syscall
	
	.data

message:
	.asciiz "The answer is: "
