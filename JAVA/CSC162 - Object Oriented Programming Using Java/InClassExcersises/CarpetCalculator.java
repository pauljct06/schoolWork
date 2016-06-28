import java.util.Scanner;

/**
   Carpet Calculator Program
   Chapter 9, Programming Challenge 3

   In-Class Exercise Oct 8:  TESTING your Lab#3's Classes

   IMPORTANT:  	This code is NOT demonstrating
   				"good coding techniques"!!

   Please note:	I am purposely hard coding values for
   				brevity and clarity - so you will know
   				exactly what values should get printed.
*/

public class CarpetCalculator
{
   public static void main(String[] args)
   {
      RoomDimension dimensions = new RoomDimension (5.0, 10.0);
      RoomCarpet room1 = new RoomCarpet(dimensions, 8.25);

	  // Note: I am reusing the same RoomDimension reference:
      dimensions = new RoomDimension(20.0, 40.0);
      RoomCarpet room2 = new RoomCarpet(dimensions, 7.75);

      System.out.println("Room ONE info: " + room1);
 	  System.out.println("Room TWO info: " + room2);
   }
}