//filename:CircleFormula
//Paul Collado
//CSC-162 Lab 2 Page 359 #7

import java.util.Scanner;
import java.text.DecimalFormat;

public class CircleFormula
{
 public static void main(String[] args)
 {

  	System.out.println("Filename: CircleFormula \nPaul Collado \nCSC-162 Lab 2 Page 359 #7\n");

   	CircleClass r1;

   	double radius;

  	DecimalFormat fmt = new DecimalFormat("0.00");

   	Scanner keyboard = new Scanner(System.in);
   	System.out.print("This program will calculate area, diameter and circumference ");
   	System.out.println("of a circle when a Radius is entered.");
   	System.out.println();
   	System.out.print("Input the radius: ");
   	radius = keyboard.nextDouble();

   	r1 = new CircleClass(radius); //Creating and objetc in circle class and passing the radius

   	System.out.println();
   	System.out.println("Here are the calculations results:");
   	System.out.println();
   	System.out.println("The area of the circle is: " + fmt.format(r1.getArea()));
   	System.out.println("The diameter of the circle is: " + fmt.format(r1.getDiameter()));
   	System.out.println("The circumference of the circle is: " + fmt.format(r1.getCircumference()));
   	System.out.println();
 }
}
/*
Filename: CircleFormula
Paul Collado
CSC-162 Lab 2 Page 359 #7

This program will calculate area, diameter and circumference of a circle when a
Radius is entered.

Input the radius: 10

Here are the calculations results:

The area of the circle is: 314.16
The diameter of the circle is: 20.00
The circumference of the circle is: 62.83

Press any key to continue . . .

Filename: CircleFormula
Paul Collado
CSC-162 Lab 2 Page 359 #7

This program will calculate area, diameter and circumference of a circle when a
Radius is entered.

Input the radius: 0

Here are the calculations results:

The area of the circle is: 0.00
The diameter of the circle is: 0.00
The circumference of the circle is: 0.00

Press any key to continue . . .

Filename: CircleFormula
Paul Collado
CSC-162 Lab 2 Page 359 #7

This program will calculate area, diameter and circumference of a circle when a
Radius is entered.

Input the radius: 15.2

Here are the calculations results:

The area of the circle is: 725.83
The diameter of the circle is: 30.40
The circumference of the circle is: 95.50

Press any key to continue . . .

Filename: CircleFormula
Paul Collado
CSC-162 Lab 2 Page 359 #7

This program will calculate area, diameter and circumference of a circle when a
Radius is entered.

Input the radius: 25.5

Here are the calculations results:

The area of the circle is: 2042.82
The diameter of the circle is: 51.00
The circumference of the circle is: 160.22

Press any key to continue . . .

*/