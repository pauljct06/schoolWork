
	.globl main				# delcare as global the label main
	
	.data
string: .asciiz " The result of (2400/8) - (2*50) + 600 is: "

	.text
	
main:	
	#load all values
	li $s0, 2400
	li $s1, 50
	li $s2, 600
	li $s3, 8
	li $s4, 2
	
	#division
	div $s0, $s3
	mflo $t3
	mfhi $t4
	
	#multiplication
	mult $s1, $s4
	mflo $t6
	
	#substraction and addition
	sub $t1, $t3, $t6
	add $t0, $t1, $s2
	
	#printing
	la $a0, string			#print string message
	li $v0, 4
	syscall
	
	move $a0, $t0			#move answer into var $a0
	
	li $v0, 1			#print whats store in $a0 (which is the value of $t0)
	syscall
	
	li $v0, 10			#exit program
	syscall
