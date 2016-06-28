# Read and Print integer from command line
	
	.globl main

#These are messages for the user
	.data	
string1: .asciiz "Please enter 3 numbers: \n"
string2: .asciiz "The addition of your 3 numbers is: "

	.text 
main:
	la $a0, string1			#print string1 message
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
			
	#adding is performed below
	add $t0, $t1, $t2 		#adding t1 plus t2 and storing it in t0
	add $t5, $t0, $t3		#adding t0 plus t3 and storing it in t5
	
	#Here the printing starts
	la $a0, string2			#print string2 message
	li $v0, 4
	syscall
	
	move $a0, $t5			#move $t5 contents into var $a0
	
	li $v0, 1			#print whats store in $a0 (which is the value of $t5)
	syscall
			
	li $v0, 10			#exit program
	syscall