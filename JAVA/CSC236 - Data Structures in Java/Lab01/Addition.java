// Paul Collado
// Lab 01 Part 1 Addition Class
// CSC 236-01

import java.util.Scanner;

public class Addition{
	public static void main (String[]args){

		int A, B;

		Scanner keyboard = new Scanner(System.in);
		System.out.print("Please enter the first number: ");
		A = keyboard.nextInt();
		System.out.print("Now enter the second number: ");
		B = keyboard.nextInt();
		System.out.println(A + " + " + B + " = " + Add(A,B));
	}

	public static int Add(int A,int B){

		if(B == 0)
		return A;

		else if (B>0)
		return 1 + Add(A,B-1);

		else
		return Add(A,B+1) - 1;

	}
}
/*

Please enter the first number: 15
Now enter the second number: 20
15 + 20 = 35
Press any key to continue . . .


Please enter the first number: 5
Now enter the second number: 0
5 + 0 = 5
Press any key to continue . . .


Please enter the first number: 55
Now enter the second number: -82
55 + -82 = -27
Press any key to continue . . .

*/