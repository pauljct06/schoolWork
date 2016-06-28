# Read and Print integer f

	.text
	.globl main

main: 
	li $t1, 50
	li $t2, 2
	mult $t1, $t2
	mflo $t3
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
