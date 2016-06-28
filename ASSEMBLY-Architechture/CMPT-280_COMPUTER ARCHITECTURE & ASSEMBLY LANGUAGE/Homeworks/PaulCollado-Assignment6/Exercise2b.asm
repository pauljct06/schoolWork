.text
.globl main

main:

li $t0, 1		# A
li $t1, 0		# B
li $t2, 1		# C
li $t3, 0		# D

and $s0, $t0, $t1	# A*B first, result on $s0
and $s1, $s0, $t2	# $s0 * C, in other word AB*C

or $t5, $s1, $t3	# $s1 + $t3, [(ABC) + D] store result on $t5

move $a0, $t5		# Print Result
li $v0, 1
syscall

li $v0, 10		# Exit Program
syscall	
