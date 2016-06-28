

	.globl main				# delcare as global the label main
	
	.data
string: .asciiz " The result of (8 - 3 - 1) + 2  is: "

	.text
main:	
	#load all values
	li $s0, 8
	li $s1, 3
	li $s2, 1
	li $s3, 2
	
	sub $t1, $s0, $s1
	sub $t2, $t1, $s2
	add $t3, $t2, $s3
	
	la $a0, string			#print string message
	li $v0, 4
	syscall
	
	move $a0, $t3			#move answer into var $a0
	
	li $v0, 1			#print whats store in $a0 (which is the value of $t2)
	syscall
	
	li $v0, 10			#exit program
	syscall