# folder

	.text			
main:
	la $a0, output		
	li $v0, 4
	syscall
	
	li $t0,2
	move $a0, $t0
	li $v0, 1
	syscall
	
	li $v0,10
	syscall
	
	.data
output:
	.asciiz "The number is: "	