import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb07P01A
public class ColladoC161Lb07P01A
{
 public static void main (String[]args)
 {
  String star= "*" ;
  double sales1, sales2, sales3, sales4, sales5;
  long salesR1,salesR2, salesR3, salesR4, salesR5;


  System.out.println("Please enter today's sales for the five stores:");
  Scanner keyboard = new Scanner(System.in);

  System.out.printf("Enter today's sales for store 1: ");
  sales1 = keyboard.nextDouble();
  System.out.printf("Enter today's sales for store 2: ");
  sales2 = keyboard.nextDouble();
  System.out.printf("Enter today's sales for store 3: ");
  sales3 = keyboard.nextDouble();
  System.out.printf("Enter today's sales for store 4: ");
  sales4 = keyboard.nextDouble();
  System.out.printf("Enter today's sales for store 5: ");
  sales5 = keyboard.nextDouble();

  salesR1 = (Math.round(sales1/100)*100)/100;
  salesR2 = (Math.round(sales2/100)*100)/100;
  salesR3 = (Math.round(sales3/100)*100)/100;
  salesR4 = (Math.round(sales4/100)*100)/100;
  salesR5 = (Math.round(sales5/100)*100)/100;



  System.out.println("\nSALES BAR CHART");
  System.out.print("Store 1: ");
  for (int x = 1 ;x <= salesR1 ;x++)
  {System.out.print(star);}
  System.out.print("\nStore 2: ");
  for (int x = 1 ;x <= salesR2 ;x++)
  {System.out.print(star);}
  System.out.print("\nStore 3: ");
  for (int x = 1 ;x <= salesR3 ;x++)
  {System.out.print(star);}
  System.out.print("\nStore 4: ");
  for (int x = 1 ;x <= salesR4 ;x++)
  {System.out.print(star);}
  System.out.print("\nStore 5: ");
  for (int x = 1 ;x <= salesR5 ;x++)
  {System.out.print(star);}
  System.out.println();
 }
}
/*
Please enter today's sales for the five stores:
Enter today's sales for store 1: 120
Enter today's sales for store 2: 230
Enter today's sales for store 3: 349
Enter today's sales for store 4: 450
Enter today's sales for store 5: 590

SALES BAR CHART
Store 1: *
Store 2: **
Store 3: ***
Store 4: *****
Store 5: ******
*/