//filename: PaintJob
//Paul Collado
//CSC-162 Lab 1 Page 290 #4

import java.util.Scanner;
import java.lang.Math;

public class PaintJob
{
 public static void main(String[] args)
 {
	System.out.println("Paul Collado");
    System.out.println("CSC-162 Lab 1 Page 290 #4");
    System.out.println();

	final int SQRPERGAL = 115;
    final double SQRFEETPERHOUR = 14.375; // square feet covered per hour
	final double COMPANYCHARGEPERHOUR = 18;

	double totalsqrfeet = 0;   //Accumulator
	double sqrfeet;
	double pricepergallon;

	int rooms;


	//Getting number of rooms and price of paint
	Scanner keyboard = new Scanner(System.in);
	System.out.print("Please enter the number of rooms to be painted: ");
	rooms = keyboard.nextInt();
	System.out.print("Now enter the price of paint per gallon: $");
	pricepergallon = keyboard.nextDouble();

    //loop to get sqr feet for each room
    for(int lcv = 1; lcv <= rooms; lcv++)
    {
	  System.out.printf("Please enter the Sqr feet of wall space in room %d: ", lcv);
	  sqrfeet = keyboard.nextDouble();

	  totalsqrfeet += sqrfeet;
    }

    double requiredgals = gallonsofpaint(totalsqrfeet,SQRPERGAL); //passing total of sqr feet of all rooms
                                                                  //and sqrfeet covered per gallon

    double requiredhours = hoursoflabor(totalsqrfeet, SQRFEETPERHOUR); //passing total of sqr feet of all rooms
																	   //and hours covert per each 115ft

	double paintcost = costofpaint(pricepergallon, requiredgals);

	double laborcost = laborcharges(requiredhours, COMPANYCHARGEPERHOUR);

	finalresult(paintcost,laborcost);

 }
 public static double gallonsofpaint(double sqrf, double gal)
 {
	 System.out.println("\nMethod name: gallonsofpaint");
	 System.out.println("Parameters: Sqrfeet sum of all rooms, and amount of sqrfeet covered by a gallon of paint");
	 double totgals;

	 totgals = (Math.ceil(sqrf / gal));

     System.out.printf("Calculated gallons of paint needed: %2.0f \n", totgals);
     return totgals;
 }
 public static double hoursoflabor(double sqrfeet, double hours)
 {
	 System.out.println("\nMethod name: hoursoflabor");
	 System.out.println("Parameters: Sqrfeet sum of all rooms, and sqrfeet covered per hour of work");

	 double tothours;

	 tothours = (sqrfeet / hours);

	 System.out.printf("Calculated number of hours needed: %3.4f \n", tothours);

	 return tothours;
 }
 public static double costofpaint(double galprice, double gals)
 {
 	 System.out.println("\nMethod name: costofpaint");
	 System.out.println("Parameters: Price per gallon, and gallons needed for paint job");

	 double totcostofpaint;

	 totcostofpaint = (galprice * gals);

	 System.out.printf("Calculated cost of paint is: $%3.2f \n", totcostofpaint);

	 return totcostofpaint;
 }
 public static double laborcharges(double hrs, double hourfee)
 {
 	 System.out.println("\nMethod name: laborcharges");
	 System.out.println("Parameters: Required hours for paint job, and company hourly fee");

	 double totcharge = (hrs * hourfee);

	 System.out.printf("Calculated charge of labor is: $%4.2f \n", totcharge);

	 return totcharge;
 }
 public static void finalresult(double costpaint, double costlabor)
 {
 	 System.out.println("\nMethod name: finalresult");
	 System.out.println("Parameters: Total cost fo paint, and total cost of labor");

	 double totaljobcost;

	 totaljobcost = (costpaint + costlabor);

	 System.out.printf("The total cost of paint is: $%3.2f \n", costpaint);
	 System.out.printf("The total cost of labor is: $%4.2f \n", costlabor);
	 System.out.printf("The total cost of the job is: $%4.2f \n\n", totaljobcost);
 }
}

/*
Please enter the number of rooms to be painted: 5
Now enter the price of paint per gallon: $10
Please enter the Sqr feet of wall space in room 1: 100
Please enter the Sqr feet of wall space in room 2: 115
Please enter the Sqr feet of wall space in room 3: 120.5
Please enter the Sqr feet of wall space in room 4: 150.25
Please enter the Sqr feet of wall space in room 5: 230

Method name: gallonsofpaint
Parameters: Sqrfeet sum of all rooms, and amount of sqrfeet covered by a gallon of paint
Calculated gallons of paint needed:  7

Method name: hoursoflabor
Parameters: Sqrfeet sum of all rooms, and sqrfeet covered per hour of work
Calculated number of hours needed: 49.7913

Method name: costofpaint
Parameters: Price per gallon, and gallons needed for paint job
Calculated cost of paint is: $70.00

Method name: laborcharges
Parameters: Required hours for paint job, and company hourly fee
Calculated charge of labor is: $896.24

Method name: finalresult
Parameters: Total cost fo paint, and total cost of labor
The total cost of paint is: $70.00
The total cost of labor is: $896.24
The total cost of the job is: $966.24

Press any key to continue . . .


Please enter the number of rooms to be painted: 3
Now enter the price of paint per gallon: $7
Please enter the Sqr feet of wall space in room 1: 114
Please enter the Sqr feet of wall space in room 2: 345
Please enter the Sqr feet of wall space in room 3: 350

Method name: gallonsofpaint
Parameters: Sqrfeet sum of all rooms, and amount of sqrfeet covered by a gallon of paint
Calculated gallons of paint needed:  8

Method name: hoursoflabor
Parameters: Sqrfeet sum of all rooms, and sqrfeet covered per hour of work
Calculated number of hours needed: 56.2783

Method name: costofpaint
Parameters: Price per gallon, and gallons needed for paint job
Calculated cost of paint is: $56.00

Method name: laborcharges
Parameters: Required hours for paint job, and company hourly fee
Calculated charge of labor is: $1013.01

Method name: finalresult
Parameters: Total cost fo paint, and total cost of labor
The total cost of paint is: $56.00
The total cost of labor is: $1013.01
The total cost of the job is: $1069.01

Press any key to continue . . .

*/