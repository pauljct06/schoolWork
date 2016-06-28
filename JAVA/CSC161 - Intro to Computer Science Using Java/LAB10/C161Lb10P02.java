import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb10P02
public class C161Lb10P02
{
	public static void main(String[]args)
	{
		final int employees = 7;
		int[]employeeId = {5658845, 4520125, 7895122, 8777541, 8451277, 1302850, 7580489};
		int[]hours = new int[employees];
		double[]payRate = new double[employees];
		double[]wages = new double[employees];

		Scanner kb = new Scanner(System.in);

		for(int LCV=0, LCV1=0, LCV2=0, num=1; LCV1<employees ||LCV1<employees || LCV2<employees; LCV++,LCV1++,LCV2++, num++)
		{
			System.out.println("Employee number  " + num);
			System.out.print("Hours worked: ");
			hours[LCV] = kb.nextInt();
			System.out.print("Payrate by hour: $");
			payRate[LCV2] = kb.nextDouble();
			if(hours[LCV1]<0 || payRate[LCV2]<6.00)
			{
				System.out.println("\nYou entered an invalid value!HOURS must be a positive number and PAYRATE must be higher than $6.00. Try again.\n");
				num--;
				LCV--;
				LCV1--;
				LCV2--;
			}
		}
		wages = GrossPay(employeeId, hours, payRate);
		for(int lcv = 0, num = 1; lcv<employees;  lcv++, num++)
		{
			System.out.println("Employee " + num + " ID number: "+ employeeId[lcv] + " -------->Gross Pay: $" + wages[lcv]);
		}

	}
	public static double[] GrossPay(int[]employeeId, int[]hours, double[]payRate)
	{
		double []wage = new double[7];

		for(int LCV =0; LCV<employeeId.length; LCV++)
		{
			wage[LCV] = hours[LCV] * payRate[LCV];
		}
		return wage;
	}
}
/*
Employee number  1
Hours worked: 10
Payrate by hour: $10
Employee number  2
Hours worked: -1
Payrate by hour: $15

You entered an invalid value!HOURS must be a positive number and PAYRATE must be
 higher than $6.00. Try again.

Employee number  2
Hours worked: 20
Payrate by hour: $20
Employee number  3
Hours worked: 30
Payrate by hour: $30
Employee number  4
Hours worked: 40
Payrate by hour: $5

You entered an invalid value!HOURS must be a positive number and PAYRATE must be
 higher than $6.00. Try again.

Employee number  4
Hours worked: 40
Payrate by hour: $40
Employee number  5
Hours worked: 50
Payrate by hour: $50
Employee number  6
Hours worked: 60
Payrate by hour: $60
Employee number  7
Hours worked: 70
Payrate by hour: $70
Employee 1 ID number: 5658845 -------->Gross Pay: $100.0
Employee 2 ID number: 4520125 -------->Gross Pay: $400.0
Employee 3 ID number: 7895122 -------->Gross Pay: $900.0
Employee 4 ID number: 8777541 -------->Gross Pay: $1600.0
Employee 5 ID number: 8451277 -------->Gross Pay: $2500.0
Employee 6 ID number: 1302850 -------->Gross Pay: $3600.0
Employee 7 ID number: 7580489 -------->Gross Pay: $4900.0
*/