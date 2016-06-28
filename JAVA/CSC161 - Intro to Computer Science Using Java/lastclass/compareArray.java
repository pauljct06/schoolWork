//import java.util.Scanner;
public class compareArray
{
	public static void main(String[] args)
	{
		int[] A= {1,2,3};
		int[] B= {1,2,3};

		boolean ArrayEqual = true;

		int index = 0;

		if(A.length == B.length)
		{ArrayEqual = true;}

		while(ArrayEqual && index < A.length)
		{
			if(A[index] == B[index])
			{ArrayEqual = true;}
			else
			{ArrayEqual = false;}
		index++;
		}
		if(ArrayEqual)
		{System.out.println("Equal");}
		else
		{System.out.println("Not equal");}
	}
}
/*

Equal

*/
