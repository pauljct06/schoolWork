import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb10P01
public class C161Lb10P01
{
	public static void main(String[] args)
	{
		final int totalmonths = 12;
		double[]Rainfall = new double[totalmonths];
		String[]month = {"January", "February","March","April","May","June","July",
		                 "August","September","October","November","December"};



		Scanner kb = new Scanner(System.in);

		for(int LCV = 0; LCV< totalmonths && LCV < month.length; LCV++)
		{
			System.out.print("Please input the amount of rain for " + month[LCV] + ": ");
			Rainfall[LCV] = kb.nextDouble();
			if(Rainfall[LCV]<0)
			{
				System.out.println("\nYOU MUST INPUT A POSITIVE NUMBER! Try again.\n");
				LCV--;
			}

		}

	double totalrain = TotalRain(Rainfall);
	System.out.println("The total rain for the year is: " + totalrain);
	double AvegMonthRain = AverageMonth(Rainfall);
	System.out.printf("The average monthly rainfall is: %3.2f\n",AvegMonthRain);
    String mostRain = MostRain(Rainfall,month);
    System.out.println("The month with most rain was: " + mostRain);
    String lessRain = LessRain(Rainfall,month);
    System.out.println("The month with less rain was: " + lessRain);


	}

	public static double TotalRain(double[] Rainfall)
	{
		double total = 0;
		for(int LCV =0; LCV<Rainfall.length; LCV++)
		{
			total =  total + Rainfall[LCV];
		}
		return total;
	}
	public static double AverageMonth(double[] Rainfall)
	{
		double average = 0;

		for(int LCV = 0; LCV<Rainfall.length; LCV++)
		{
			average = average + Rainfall[LCV] /12;

		}
		return average;
	}
	public static String MostRain(double[] Rainfall, String[] month)
	{
		double Max = Rainfall[0];
		String Smax = month[0];

		for(int LCV = 1; LCV<Rainfall.length; LCV++)
		{
			if(Rainfall[LCV] > Max)
			{
				Max = Rainfall[LCV];
				Smax = month[LCV];
			}
		}
		return Smax;
	}
	public static String LessRain(double[] Rainfall, String[] month)
	{
		double Less = Rainfall[0];
		String Sless = month[0];

		for(int LCV = 1; LCV<Rainfall.length; LCV++)
		{
			if(Rainfall[LCV] < Less)
			{
				Less = Rainfall[LCV];
				Sless = month[LCV];
			}
		}
		return Sless;
	}
}
/*
Please input the amount of rain for January: 5
Please input the amount of rain for February: 1
Please input the amount of rain for March: 2
Please input the amount of rain for April: 20
Please input the amount of rain for May: 4
Please input the amount of rain for June: -1

YOU MUST INPUT A POSITIVE NUMBER! Try again.

Please input the amount of rain for June: 5
Please input the amount of rain for July: 6
Please input the amount of rain for August: 7
Please input the amount of rain for September: 7
Please input the amount of rain for October: 5
Please input the amount of rain for November: 11
Please input the amount of rain for December: 2
The total rain for the year is: 75.0
The average monthly rainfall is: 6.25
The month with most rain was: April
The month with less rain was: February
*/











