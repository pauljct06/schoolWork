//filename:InternetServiceProvider
//Paul Collado
//CSC-162 Lab 1 Page 177 #13

import java.util.Scanner;

public class InternetServiceProvider
{
 public static void main(String[] args)
 {
  final  double PRICEA= 9.95;
  final  double PRICEB= 13.95;
  final  double PRICEC= 19.95;
  final  double EXTRAA= 2.00;
  final  double EXTRAB= 1.00;
  final  double MAXHRSA = 10;
  final  double MAXHRSB = 20;

  System.out.println("Paul Collado");
  System.out.println("CSC-162 Lab 1 Page 177 #13");
  System.out.println();

  String Package;

  double hours;
  double regularhours, Extrahours;
  double TotalPrice;

   do{
   	  //Getting  info( package and number of hours)
   	  Scanner keyboard = new Scanner(System.in);
      System.out.print("Select among packages A, B, or C: ");
      Package = keyboard.nextLine();
      System.out.print("Input number of hours: ");
      hours = keyboard.nextDouble();

	  //Calculation of monthly charges
	  if((Package.equals("A")) && (hours >= 0) && (hours <= MAXHRSA))
		{
		  System.out.println("Your total charges for this month are: $" + PRICEA);
		  System.out.println();
		}
	  else if((Package.equals("A")) && (hours > MAXHRSA))
		{
		  Extrahours = hours - MAXHRSA;
		  TotalPrice = PRICEA + (EXTRAA*Extrahours);
		  System.out.println("Your total charges for this month are: $" + TotalPrice);
		  System.out.println();
		}
	  else if((Package.equals("B")) && (hours >= 0) && (hours <= MAXHRSB))
		{
		  System.out.println("Your total charges for this month are: $" + PRICEB);
		  System.out.println();
		}
	  else if((Package.equals("B")) && (hours >= MAXHRSB))
		{
		  Extrahours = hours - MAXHRSB;
		  TotalPrice = PRICEB + (EXTRAB*Extrahours);
		  System.out.println("Your total charges for this month are: $" + TotalPrice);
		  System.out.println();
		}
	  else if((Package.equals("C")) && (hours >= 0))
		{
		  System.out.println("Your total charges for this month are: $" + PRICEC);
		  System.out.println();
		}
    }while (hours >= 0);
	System.out.println("You entered an incorrect amount of hours!");
	System.out.println();
 }
}