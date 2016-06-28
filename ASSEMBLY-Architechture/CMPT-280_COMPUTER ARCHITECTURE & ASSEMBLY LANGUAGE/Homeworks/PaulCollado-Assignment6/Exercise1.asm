# This creates a NOT gate

.text
.globl main

main:


li $t0, 0		# Get input 1 or 0
xori $t3, $t0, 1	# XOR with 1 to change initial input

move $a0, $t3		# Code to print
li $v0, 1
syscall

li $v0, 10		# Exit program
syscall