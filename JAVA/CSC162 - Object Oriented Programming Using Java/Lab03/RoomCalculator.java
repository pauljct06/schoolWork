//filename: RoomCalculator.java
//Paul Collado
//CSC-162 Lab 3 Page 598 #3

import java.util.Scanner;

public class RoomCalculator
{
	public static void main(String[] args)
	{
		System.out.println("Filename: RoomCalculator.java \nPaul Collado \nCSC-162 Lab 3 Page 598 #3\n");

		RoomDimension mydimensions;
		RoomCarpet mycarpet;
		double width, length;
		double cost;
		String input;
		char repeat;

		Scanner keyboard = new Scanner(System.in);

		do // USER CONTROLLED LOOP
		{
			//GETTING USER INPUT
			System.out.println("This programs calculates the price of carpeting for rectangular rooms.");
			System.out.println();
			System.out.print("Please input carpet width in feet: ");
			width = keyboard.nextDouble();
			System.out.print("Now input carpet length in feet: ");
			length = keyboard.nextDouble();
			System.out.print("Finally input the cost of carpet per foot: $");
			cost = keyboard.nextDouble();
			keyboard.nextLine(); // CONSUMING REMAINING LINE
			System.out.println();

			mydimensions = new RoomDimension(width, length);  // CREATING NEW INSTANCES OF BOTH CLASSES
			mycarpet = new RoomCarpet(mydimensions, cost);


			System.out.println(mycarpet); // CALLING ToSring METHOD
			System.out.println();

			// PROMPTING TO RUN LOOP AGAIN
			System.out.print("Enter 'Y' if you wish to run the program again or any other key to exit: ");
			input = keyboard.nextLine();
			repeat = input.charAt(0);
			System.out.println();

		}while(repeat == 'Y' || repeat == 'y');  // TESTING LOOP CONTINUITY
	}
}

/*
filename: RoomCalculator.java
Paul Collado
CSC-162 Lab 3 Page 598 #3

This programs calculates the price of carpeting for rectangular rooms.

Please input carpet width in feet: 12
Now input carpet length in feet: 10
Finally input the cost of carpet per foot: $8

Room Dimension in sqft are:
Width is: 12.0ft
Length is:  10.0ft
Area of the room is: 120.00sqft
Carpet cost per sqft is: $8.00
Total cost of carpet is: $960.00

Enter 'Y' if you wish to run the program again or any other key to exit: y

This programs calculates the price of carpeting for rectangular rooms.

Please input carpet width in feet: 24
Now input carpet length in feet: 15.5
Finally input the cost of carpet per foot: $9.50

Room Dimension in sqft are:
Width is: 24.0ft
Length is:  15.5ft
Area of the room is: 372.00sqft
Carpet cost per sqft is: $9.50
Total cost of carpet is: $3534.00

Enter 'Y' if you wish to run the program again or any other key to exit: Y

This programs calculates the price of carpeting for rectangular rooms.

Please input carpet width in feet: 15.25
Now input carpet length in feet: 15.25
Finally input the cost of carpet per foot: $10

Room Dimension in sqft are:
Width is: 15.25ft
Length is:  15.25ft
Area of the room is: 232.56sqft
Carpet cost per sqft is: $10.00
Total cost of carpet is: $2325.62

Enter 'Y' if you wish to run the program again or any other key to exit: N

Press any key to continue . . .
*/