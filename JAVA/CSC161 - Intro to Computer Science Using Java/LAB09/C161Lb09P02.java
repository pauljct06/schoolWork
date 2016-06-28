import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb09P02
public class C161Lb09P02
{
 public static void main(String[] args)
 {

	 int dmeters;
	 int menuAnswer=0;

	 Scanner keyboard = new Scanner(System.in);
	 for(int LCV = 0; ;LCV++)
	 {
	 	System.out.print("Please enter a distance in meters:");
	 	dmeters = keyboard.nextInt();
	    if(dmeters>0)
	    {
	    	getMenu();
	    	System.out.print("Choice: ");
			menuAnswer=keyboard.nextInt();

			if(menuAnswer==1)
			{
				double kilometers = ShowKilometers(dmeters);
	 			System.out.println(dmeters+" meters is "+kilometers +" kilometers.");
			}
	 		else if(menuAnswer==2)
	 		{
				double inches = ShowInches(dmeters);
	 			System.out.println(dmeters+" meters is "+inches+" inches.");
			}
			else if(menuAnswer==3)
	 		{
				double feet = ShowFeet(dmeters);
	 			System.out.println(dmeters+" meters is "+feet+" feet.");
			}
	 		else if(menuAnswer==4)
	 		break;
	 		else
	 		{
				System.out.println("Error! You selected an invalid option, try again.\n");
			}
		}
		else
		{
			System.out.println("You must enter a positive number!, try again.\n");
		}
     }
 }
 public static void getMenu()
 {
	 String opt1, opt2, opt3, opt4;
	 opt1 = "1. Convert to kilometers" ;
	 opt2 = "2. Convert to inches";
	 opt3 = "3. Convert to feet";
	 opt4 = "4. Quit the program";


	 System.out.println("\nNow select one of the following options");
	 System.out.println(opt1+"\n"+opt2+"\n"+opt3+"\n"+opt4);
 }
 public static double ShowKilometers(int dmeters)
 {
	 double kiloResult=0;

	 kiloResult = dmeters * 0.001;

	 return kiloResult;
 }
 public static double ShowInches(int dmeters)
 {
	 double inchResult=0;

	 inchResult = dmeters * 39.37;

	 return inchResult;
 }
 public static double ShowFeet(int dmeters)
 {
	 double feetResult=0;

	 feetResult = dmeters * 3.281;

	 return feetResult;
 }
}
/*
Please enter a distance in meters:-1
You must enter a positive number!, try again.

Please enter a distance in meters:10

Now select one of the following options
1. Convert to kilometers
2. Convert to inches
3. Convert to feet
4. Quit the program
Choice: 1
10 meters is 0.01 kilometers.
Please enter a distance in meters:20

Now select one of the following options
1. Convert to kilometers
2. Convert to inches
3. Convert to feet
4. Quit the program
Choice: 2
20 meters is 787.4 inches.
Please enter a distance in meters:30

Now select one of the following options
1. Convert to kilometers
2. Convert to inches
3. Convert to feet
4. Quit the program
Choice: 3
30 meters is 98.43 feet.
Please enter a distance in meters:5

Now select one of the following options
1. Convert to kilometers
2. Convert to inches
3. Convert to feet
4. Quit the program
Choice: 5
Error! You selected an invalid option, try again.

Please enter a distance in meters:40

Now select one of the following options
1. Convert to kilometers
2. Convert to inches
3. Convert to feet
4. Quit the program
Choice: 4
*/









