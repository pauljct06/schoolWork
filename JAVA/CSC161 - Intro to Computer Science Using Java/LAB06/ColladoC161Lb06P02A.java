import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb06P02A
public class ColladoC161Lb06P02A
{
 public static void main(String[] args)
 {

  String opt1, opt2, opt3, opt4, opt5;
  int numberI, numberF, numberY, inches, feet, yards, optAnswer, LCV;
  double feetD, yardsD;

opt1 = "1. Convert a whole number of inches into Feet and Inches.";
opt2 = "2. Convert Feet and Inches, both enter separately; to decimal feet.";
opt3 = "3. Convert a whole number of inches into yards and inches.";
opt4 = "4. Convert Yards and Inches, both enter separately, to decimal yards.";
opt5 = "5. Exit the program.";

Scanner keyboard = new Scanner(System.in);
System.out.printf("Please select one of the following options: \n%s\n%s\n%s\n%s\n%s\n\n", opt1, opt2, opt3, opt4, opt5);
optAnswer = keyboard.nextInt();

if(optAnswer == 1)
  {System.out.print("Please input number of inches: ");
  numberI = keyboard.nextInt();

  feet = numberI / 12;
  inches = numberI % 12;

  System.out.printf("%d inches Equals to %d feet and %d inches\n",numberI, feet, inches);
  }
else if (optAnswer == 2)
  {
  System.out.print("Please input number of feet: ");
  numberF = keyboard.nextInt();
  System.out.print("Please input number of inches: ");
  numberI = keyboard.nextInt();

  feetD = numberF + (numberI * 0.0833);

  System.out.printf("%d feet and %d inches Equals to %2.2f decimal feet\n", numberF, numberI, feetD);
  }
else if (optAnswer == 3)
  {
  System.out.print("Please input number of inches: ");
  numberI = keyboard.nextInt();

  yards = numberI / 36;
  inches = numberI % 12;

  System.out.printf("%d inches Equals to %d yards and %d inches\n", numberI,yards, inches);
  }
else if (optAnswer == 4)
  {
  System.out.print("Please input number of Yards: ");
  numberY = keyboard.nextInt();
  System.out.print("Please input number of inches: ");
  numberI = keyboard.nextInt();

  yardsD = numberY + (numberI * 0.027777);

  System.out.printf("%d yards and %d inches Equals to %2.2f decimal yard\n", numberY, numberI, yardsD);
  }
else if (optAnswer == 5)
 {}
else
 {System.out.println("Invalid choice!");}
 }
}


/*
Please input number of inches: 21
Equals to 1 feet and 9 inches


Please input number of feet: 20
Please input number of inches: 6
Equals to 20.50 decimal feet


Please input number of inches: 45
45 inches Equals to 1 yards and 9 inches


Please input number of Yards: 1
Please input number of inches: 9
1 yards and 9 inches Equals to 1.25 decimal yard
*/