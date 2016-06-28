	.globl main

	.data	
string1: .asciiz "Please enter 3 numbers: \n"
string2: .asciiz "These are the numbers you entered: \n"
string3: .asciiz "\n"

	.text 
main:
	la $a0, string1			#print string1	
	li $v0, 4
	syscall

	li $v0, 5			#enter input1
	syscall
	
	move $t1, $v0			#move input1 into var $t1
		
	li $v0, 5			#enter input2
	syscall
	
	move $t2, $v0			#move input2 into var $t2
	
	li $v0, 5			#enter input3
	syscall				
	
	move $t3, $v0			#move input3 into var $t3
	
			
	#Here the printing starts
	
	la $a0, string2			#print string2	
	li $v0, 4
	syscall
	
	move $a0, $t1			#move input1 into var $a0
	
	li $v0, 1			#print whats store in $a0 (which is the value of $t1)
	syscall
	
	la $a0, string3			#print string3	
	li $v0, 4
	syscall
		
	move $a0, $t2			#move input1 into var $a0
	
	li $v0, 1			#print whats store in $a0 (which is the value of $t2)
	syscall
	
	la $a0, string3			#print string3	
	li $v0, 4
	syscall
	
	move $a0, $t3			#move input3 into var $a0
	
	li $v0, 1			#print whats store in $a0 (which is the value of $t3)
	syscall
		
	
	li $v0, 10
	syscall
