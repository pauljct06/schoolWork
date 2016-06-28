//filename: HotelOccupancy
//Paul Collado
//CSC-162 Lab 1 Page 243 #7

import java.util.Scanner;

public class HotelOccupancy
{
 public static void main(String[] args)
 {
   System.out.println("Paul Collado");
   System.out.println("CSC-162 Lab 1 Page 243 #7");

   int lcv;	//Loop control variable
   int floors, rooms, occupiedrooms;

   double totalrooms = 0, totaloccupied = 0;  //Accumulators
   double totalvacant;
   double occupancyrate;

   //Getting the number of floors form the user
   Scanner keyboard = new Scanner(System.in);
   System.out.print("Input the number of floors in the hotel: ");
   floors = keyboard.nextInt();

   //Validation for number of floors
   while(floors<1)
   {
	   System.out.println("THE NUMBER OF FLOORS CANNOT BE LESS THAN 1!, PLEASE TRY AGAIN.");
       System.out.print("\nInput the number of floors in the hotel: ");
       floors = keyboard.nextInt();
   }

   //Loop of number of floors
   for(lcv = 1; lcv <= floors; lcv++)
    {

      System.out.print("\nInput the number of rooms on floor " + lcv + ": ");
      rooms = keyboard.nextInt();

      //Validation for numbers of rooms
      while(rooms < 10)
      {
		  System.out.println("THE NUMBER OF ROOMS CANNOT BE LESS THAN 10!, PLEASE TRY AGAIN.");
          System.out.print("\nInput the number of rooms on floor " + lcv + ": ");
          rooms = keyboard.nextInt();
	  }

      System.out.print("\nInput the number of rooms occupied on floor " + lcv + ": ");
      occupiedrooms = keyboard.nextInt();

      totalrooms += rooms;
      totaloccupied += occupiedrooms;
    }
   //Calculations
   totalvacant = (totalrooms - totaloccupied);
   occupancyrate = (totaloccupied / totalrooms)*100;

   //Answers
   System.out.printf("\nTotal rooms in the hotel:%3.0f",totalrooms);
   System.out.printf("\nTotal occupied rooms:%3.0f",totaloccupied);
   System.out.printf("\nTotal vacant rooms:%3.0f" ,totalvacant);
   System.out.printf("\nThe occupancy rate of the hotel is: %3.2f",occupancyrate);
   System.out.println("%");
   System.out.println();
 }
}

/*
Paul Collado
CSC-162 Lab 1 Page 243 #7
Input the number of floors in the hotel: 0
THE NUMBER OF FLOORS CANNOT BE LESS THAN 1!, PLEASE TRY AGAIN.

Input the number of floors in the hotel: 1

Input the number of rooms on floor 1: 0
THE NUMBER OF ROOMS CANNOT BE LESS THAN 10!, PLEASE TRY AGAIN.

Input the number of rooms on floor 1: 10

Input the number of rooms occupied on floor 1: 5

Total rooms in the hotel: 10
Total occupied rooms:  5
Total vacant rooms:  5
The occupancy rate of the hotel is: 50.00%

Press any key to continue . . .


Paul Collado
CSC-162 Lab 1 Page 243 #7
Input the number of floors in the hotel: 5

Input the number of rooms on floor 1: 5
THE NUMBER OF ROOMS CANNOT BE LESS THAN 10!, PLEASE TRY AGAIN.

Input the number of rooms on floor 1: 10

Input the number of rooms occupied on floor 1: 2

Input the number of rooms on floor 2: 10

Input the number of rooms occupied on floor 2: 2

Input the number of rooms on floor 3: 10

Input the number of rooms occupied on floor 3: 2

Input the number of rooms on floor 4: 10

Input the number of rooms occupied on floor 4: 2

Input the number of rooms on floor 5: 10

Input the number of rooms occupied on floor 5: 2

Total rooms in the hotel: 50
Total occupied rooms: 10
Total vacant rooms: 40
The occupancy rate of the hotel is: 20.00%

Press any key to continue . . .


Paul Collado
CSC-162 Lab 1 Page 243 #7
Input the number of floors in the hotel: 5

Input the number of rooms on floor 1: 25

Input the number of rooms occupied on floor 1: 5

Input the number of rooms on floor 2: 10

Input the number of rooms occupied on floor 2: 10

Input the number of rooms on floor 3: 35

Input the number of rooms occupied on floor 3: 25

Input the number of rooms on floor 4: 32

Input the number of rooms occupied on floor 4: 1

Input the number of rooms on floor 5: 11

Input the number of rooms occupied on floor 5: 11

Total rooms in the hotel:113
Total occupied rooms: 52
Total vacant rooms: 61
The occupancy rate of the hotel is: 46.02%

Press any key to continue . . .


Paul Collado
CSC-162 Lab 1 Page 243 #7
Input the number of floors in the hotel: 10

Input the number of rooms on floor 1: 10

Input the number of rooms occupied on floor 1: 5

Input the number of rooms on floor 2: 15

Input the number of rooms occupied on floor 2: 0

Input the number of rooms on floor 3: 25

Input the number of rooms occupied on floor 3: 0

Input the number of rooms on floor 4: 50

Input the number of rooms occupied on floor 4: 50

Input the number of rooms on floor 5: 50

Input the number of rooms occupied on floor 5: 50

Input the number of rooms on floor 6: 50

Input the number of rooms occupied on floor 6: 50

Input the number of rooms on floor 7: 50

Input the number of rooms occupied on floor 7: 50

Input the number of rooms on floor 8: 50

Input the number of rooms occupied on floor 8: 50

Input the number of rooms on floor 9: 50

Input the number of rooms occupied on floor 9: 50

Input the number of rooms on floor 10: 50

Input the number of rooms occupied on floor 10: 50

Total rooms in the hotel:400
Total occupied rooms:355
Total vacant rooms: 45
The occupancy rate of the hotel is: 88.75%

Press any key to continue . . .

*/
