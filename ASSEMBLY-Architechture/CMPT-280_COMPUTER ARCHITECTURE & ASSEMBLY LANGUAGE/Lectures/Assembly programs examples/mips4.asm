# folder

	.text			# The followingare to be assembled in to text segment
start:	la $a0, msg		# Load the address of the message text
	li $v0, 4		# Load the syscall (4) code for printing the string of text
	syscall			
	li $v0, 10		# Load the syscall (10) code for exiting
	syscall
	
	.data
msg:	.asciiz "hello world!"		#informs the assembler that data needed within instructions follows
	