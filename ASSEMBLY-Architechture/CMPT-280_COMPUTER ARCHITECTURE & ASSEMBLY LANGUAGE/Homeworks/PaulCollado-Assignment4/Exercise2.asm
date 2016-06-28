.data

Array: .space 8		#create array to hold 3 items (4 bytes each address)

.text

.globl main

main:

la $t0, Array		#load Array into $t0
li $t1, 2		#load 2 into $t1
sw $t1, 0($t0)		#store value of $t1 into first index of Array
li $t1, 3		#load 3 into $t2
sw $t1, 4($t0)		#store value of $t1 into second index of Array
li $t1, 4		#load 4 into $t1
sw $t1, 8($t0)		#store value of $t1 into third index of Array


lw $t2, 0($t0)		#load contents of first index into $t2
lw $t3, 4($t0)		#load contents of first index into $t3
lw $t4, 8($t0)		#load contents of third index into $t2		

add $t5, $t2, $t3	#adding values of $t2 and $t3a and storing it in $t5
add $t6, $t5, $t4	#adding values of $t5 and $t4 and storing it in $t6

move $a0, $t6		#move $t6 to $a0 to print
li $v0, 1		#syscall to print
syscall

li $v0, 10		# Exiting the program
syscall