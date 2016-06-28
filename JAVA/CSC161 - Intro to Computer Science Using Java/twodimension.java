import java.util.Scanner;
public class twodimension
{
	public static void main(String[] args)
	{
		final int DIV = 2;
		final int QTR = 4;
		double totalsales = 0.0;

		double[][] Sales = new double [DIV][QTR];

		Scanner kb = new Scanner(System.in);
		System.out.println("This program will calculate the total sales of");
		System.out.println("all the company's divisions, by entering the following sales data");
		
		for(int div=0; div<DIV; div++)
		{
			for(int qtr=0; qtr < QTR; qtr++)
			{
				System.out.print("Division " + (div + 1) + ", Quarter" + (qtr + 1) +":$");
				Sales[div][qtr] = kb.nextDouble();
		    }
		    
		    System.out.println();
		}
	}
}