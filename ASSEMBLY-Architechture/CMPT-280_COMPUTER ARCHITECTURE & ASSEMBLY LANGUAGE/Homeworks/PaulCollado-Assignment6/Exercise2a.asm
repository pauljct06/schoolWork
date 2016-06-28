.text
.globl main

main:

li $t0, 1		# A
li $t1, 0		# B
li $t2, 1		# C

xor $t3, $t0, 1		# A' into $t3

and $s1, $t0, $t1	# (A * B) into $s1
and $s2, $t3, $t2	# (A' * C) into $s2

or $t5, $s1, $s2	# ($s1 + $s2) into $t5

move $a0, $t5		# Print Result
li $v0, 1
syscall

li $v0, 10		# Exit Program
syscall	

  
