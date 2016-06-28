.data

Array: .space 8		#create array to hold 2 items (4 bytes each address)

.text

.globl main

main:

la $t0, Array		#load Array into $t0
li $t1, 3		#load 3 into $t1
sw $t1, 0($t0)		#store value of $t1 into first index of Array
li $t1, 4		#load 4 into $t2
sw $t1, 4($t0)		#store value of $t1 into second index of Array

lw $t2, 0($t0)		#load contents of first index into $t2
move $a0, $t2		#move it to $a0 to print
li $v0, 1		#print it
syscall

lw $t3, 4($t0)		#load contents of first index into $t2
move $a0, $t3		#move it to $a0 to print
li $v0,1		#print it
syscall

li $v0, 10		# Exiting the program
syscall

