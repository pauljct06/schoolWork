.text
.globl main

main:

li $t0, 0		# A
li $t1, 1		# B
li $t2, 1		# C
li $t3, 1		# D

or $s1, $t0, $t1	# (A + B) into $s1
or $s2, $t2, $t3	# (C + D) into $s2

and $t5, $s1, $s2	# ($s1 * $s2) into $t5

move $a0, $t5		# Print Result
li $v0, 1
syscall

li $v0, 10		# Exit Program
syscall	