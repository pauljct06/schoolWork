//filename:AreaDemo.java
//Paul Collado
//CSC-162 Lab 3 Page 597 #1

import java.util.Scanner;
import java.text.DecimalFormat;

public class AreaDemo
{
 public static void main(String[] args)
 {
  	 System.out.println("Filename: AreaDemo \nPaul Collado \nCSC-162 Lab 3 Page 597 #1\n");
	 System.out.println("This programs calculates the areas of a circle, a rectangle and a cylinder");

	 int choice;
	 double circleradius;
	 double recwidth, reclength;
	 double cyradius, cyheight;
	 double areacircle, arearectangle, areacylinder;

     DecimalFormat fmt = new DecimalFormat("0.00");
   	 Scanner Keyboard = new Scanner(System.in);


	 do //LOOP CONTROLED BY THE USER
	 {
	 	System.out.println("What would you like to test now?");
	 	System.out.print("Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: ");
	 	choice = Keyboard.nextInt();
	 	System.out.println();

	 	if(choice == 1) //TESTS FOR CIRCLE
	 	{
			System.out.println("AREA OF THE CIRCLE");
			System.out.print("Enter the radius of the circle: ");
	 	    circleradius = Keyboard.nextDouble();
	 	    System.out.println();
	 	    areacircle = Area.getArea(circleradius);
	 	    System.out.println("The area of the Circle is: " + fmt.format(areacircle));
	 	    System.out.println();
	 	}

	 	else if(choice == 2) //TESTS FOR RECTANGLE
	 	{
			System.out.println("AREA OF THE RECTANGLE");
	 		System.out.print("Enter the width: ");
	 		recwidth = Keyboard.nextDouble();
	 		System.out.print("Now Enter the length: ");
	 		reclength = Keyboard.nextDouble();
	 		System.out.println();
	 		arearectangle = Area.getArea(recwidth, reclength);
	 		System.out.println("The area of the Rectangle is: " + fmt.format(arearectangle));
	 		System.out.println();
	 	}

	 	else if(choice == 3) //TESTS FOR CYLINDER
	 	{
			System.out.println("AREA OF THE CYLINDER");
	 		System.out.print("Enter the radius of the cylinder: ");
	 		cyradius = Keyboard.nextDouble();
	 		System.out.print("Now enter the height of the cylinder: ");
	 		cyheight = Keyboard.nextDouble();
	 		System.out.println();
	 		areacylinder = Area.getArea(cyradius, cyradius, cyheight);
	 		System.out.println("The area of the cylinder is: " + fmt.format(areacylinder));
	 		System.out.println();
	 	}
	 }while(choice != 0);
 }
}

/*
Filename: AreaDemo
Paul Collado
CSC-162 Lab 3 Page 597 #1

This programs calculates the areas of a circle, a rectangle and a cylinder
What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 1

AREA OF THE CIRCLE
Enter the radius of the circle: 10

The area of the Circle is: 314.16

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 1

AREA OF THE CIRCLE
Enter the radius of the circle: 0

The area of the Circle is: 0.00

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 1

AREA OF THE CIRCLE
Enter the radius of the circle: 15.2

The area of the Circle is: 725.83

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 1

AREA OF THE CIRCLE
Enter the radius of the circle: 25.5

The area of the Circle is: 2042.82

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 2

AREA OF THE RECTANGLE
Enter the width: 10
Now Enter the length: 5

The area of the Rectangle is: 50.00

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 2

AREA OF THE RECTANGLE
Enter the width: 10.5
Now Enter the length: 5.25

The area of the Rectangle is: 55.12

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 2

AREA OF THE RECTANGLE
Enter the width: 3.0
Now Enter the length: 25.5

The area of the Rectangle is: 76.50

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 3

AREA OF THE CYLINDER
Enter the radius of the cylinder: 10
Now enter the height of the cylinder: 5

The area of the cylinder is: 1570.80

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 3

AREA OF THE CYLINDER
Enter the radius of the cylinder: 15.2
Now enter the height of the cylinder: 5.25

The area of the cylinder is: 3810.63

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 3

AREA OF THE CYLINDER
Enter the radius of the cylinder: 25.5
Now enter the height of the cylinder: 3.0

The area of the cylinder is: 6128.46

What would you like to test now?
Enter 1 for circle 2 for rectangle, 3 for cylinder OR 0 to exit the program: 0

Press any key to continue . . .
*/
