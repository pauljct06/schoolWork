import java.util.Scanner;
public class partiallyFilledArrays
{
	public static void main (String [] args)
	{
		final int max = 100;
		int[]A = new int [max];
		int LCV, count=0, number;

		for(LCV=0; LCV<max; LCV++)
		{
			Scanner kb = new Scanner(System.in);
			System.out.println("Enter -1 to quit otherwise enter another number:");
			number = kb.nextInt();

			if(number== -1) break;
			else
			{A[LCV] = number;
			 count++;
			 System.out.println("The count is " + count);
		    }
		}
	}
}
/*
Enter -1 to quit otherwise enter another number:
2
The count is 1
Enter -1 to quit otherwise enter another number:
3
The count is 2
Enter -1 to quit otherwise enter another number:
4
The count is 3
Enter -1 to quit otherwise enter another number:
5
The count is 4
Enter -1 to quit otherwise enter another number:
-1
*/