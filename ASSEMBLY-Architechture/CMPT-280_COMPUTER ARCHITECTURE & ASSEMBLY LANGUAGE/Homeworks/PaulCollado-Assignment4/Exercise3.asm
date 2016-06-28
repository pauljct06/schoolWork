.data

ArrayA: .space 8	# Creting Array A
ArrayB: .space 8	# Creting Array B	
ArrayC: .space 8	# Creting Array C

.text
.globl main

main:

la $t0, ArrayA		# Load ArrayA address into Var $t0
li $t3, 2		# load 2 into $t3
sw $t3, 0($t0)		# store contents of var $t3 into first index of ArrayA
li $t3, 3		# load 3 into $t3
sw $t3, 4($t0)		# store contents of var $t3 into second index of ArrayA

la $t1, ArrayB		# Load ArrayB address into Var $t1
li $t3, 4		# load 4 into $t3
sw $t3, 0($t1)		# store contents of var $t3 into first index of ArrayB
li $t3, 5		# load 5 into $t3
sw $t3, 4($t1)		# store contents of var $t3 into second index of ArrayB

lw $s0, 0($t0)		# load ArrayA first index value into $s0	
lw $s1, 4($t0)		# load ArrayA second index value into $s1	
lw $s2, 0($t1)		# load ArrayB first index value into $s2			
lw $s3, 4($t1)		# load ArrayB second index value into $s3		

add $s4, $s0, $s2	# adding $0 and $s2 and storing it into $s4
add $s5, $s1, $s3	# adding $1 and $s3 and storing it into $s5

la $t2, ArrayC		# Load ArrayC address into Var $t2
sw $s4, 0($t2)		# store contents of var $s4 into first index of ArrayC
sw $s5, 4($t2)		# store contents of var $s5 into second index of ArrayC

lw $s6, 0($t2)		# Load contents of first index of ArrayC into $s6
move $a0, $s6		# move $s6 to $a0 to print
li $v0, 1		# System call to print
syscall

lw $s7, 4($t2)		# Load contents of second index of ArrayC into $s7
move $a0, $s7		# move $s7 to $a0 to print
li $v0, 1		# System call to print
syscall

li $v0, 10		# Exiting the program
syscall


