//filename: Tests.java
//Paul Collado
//CSC-162 Lab 6.1  TestScores Class

import java.util.Scanner;
public class Tests
{
 public static void main(String[] args)
 {
	 System.out.print("Filename: Tests.java \nPaul Collado");
	 System.out.println("\nCSC-162 Lab 6.1 TestScores\n");

	 int scoretest1[] = {77,85,100,65,93,45,0}; // good
	 int scoretest2[] = {69,90,-1,89,95,10,50}; // negative num
	 int scoretest3[] = {85,73,69,90,101,33,59}; // num greater than 100

	 //This is only the avoid error of "variable may have not be initialized"
	 TestScores testAverage = new TestScores(scoretest1);

	 int selection;
	 String rerun; char retry;boolean selectionflag;
	 Scanner keyboard = new Scanner(System.in);

	 System.out.println("This program calculates the average test score of an array of tests");

	 do //Prompts user to run the program again
	 {
	 	do // Select which array user wants to use
	 	{
			 selectionflag = false;
			 System.out.print("Please select one of three availables array of tests: ");
	 		 selection = keyboard.nextInt();

	 		 if(selection == 1) testAverage = new TestScores(scoretest1);
	 		 else if(selection == 2) testAverage = new TestScores(scoretest2);
	 		 else if(selection == 3) testAverage = new TestScores(scoretest3);
	 		 else
	 		 {
				 selectionflag = true;
			 	 System.out.println("You made an invalid selection...please try again\n");
	 		 }
	 	}while(selectionflag); //end of do while to select array

	 	try
	 	{
			 System.out.println("\nThe average of the test scores is: " + testAverage.getAverage());
	 	}
	 	catch(IllegalArgumentException e)
	 	{
			 System.out.println(e.getMessage());
	 	}

	 	System.out.print("\nDo you want to get another average? Y/N: ");
	 	keyboard.nextLine();
	 	rerun = keyboard.nextLine();
	 	retry = rerun.charAt(0);
	 	System.out.println("----------------------------------------------------------------");

	}while (retry == 'Y' || retry == 'y'); //End of do while to prompt user to re-run program
 }
}

/*
Filename: Tests.java
Paul Collado
CSC-162 Lab 6.1 TestScores

This program calculates the average test score of an array of tests
Please select one of three availables array of tests: 3

ERROR! INVALID VALUE AT INDEX: 4, INVALID VALUE WAS: 101

Do you want to get another average? Y/N: y
----------------------------------------------------------------
Please select one of three availables array of tests: 1

The average of the test scores is: 66.0

Do you want to get another average? Y/N: y
----------------------------------------------------------------
Please select one of three availables array of tests: 2

ERROR! INVALID VALUE AT INDEX: 2, INVALID VALUE WAS: -1

Do you want to get another average? Y/N: n
----------------------------------------------------------------
Press any key to continue . . .

*/



