import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb04P02
public class ColladoC161Lb04P02
{
 public static void main(String[] args)
 {
  int degree1, minute1, second1, degree2, minute2, second2, z1, z2, z3;

  System.out.println("Given the following Values:");
  System.out.println("First set of angular measurements:");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("Please enter degrees: ");
  degree1 = keyboard.nextInt();
  System.out.print("Please enter minutes: ");
  minute1 = keyboard.nextInt();
  System.out.print("Please enter seconds: ");
  second1 = keyboard.nextInt();
  System.out.println("Second set of angular measurements:");
  System.out.print("Please enter degrees: ");
  degree2 = keyboard.nextInt();
  System.out.print("Please enter minutes: ");
  minute2 = keyboard.nextInt();
  System.out.print("Please enter seconds: ");
  second2 = keyboard.nextInt();

  z1 = (second1 + second2);
  z2 = (minute1 + minute2);
  z3 = (degree1 + degree2);

  if (z1 >= 60)
  {
      z2= (z2 + 1);
      z1= (z1 - 60);
  }
  if (z2 >= 60)
  {
      z3= (z3 +1);
      z2= (z2 - 60);
  }
  if (z3 >= 360)
  {
	  z3= (z3 - 360);
  }

  System.out.println("Adding the two set of angular measurements:");
  System.out.println("Total Degrees = " + z3 + " Degrees");
  System.out.println("Total Minutes = " + z2 + " Minutes");
  System.out.println("Total Seconds = " + z1 + " Seconds");
 }
}

/*
Given the following Values:
First set of angular measurements:
Please enter degrees: 74
Please enter minutes: 29
Please enter seconds: 13
Second set of angular measurements:
Please enter degrees: 105
Please enter minutes: 8
Please enter seconds: 16
Adding the two set of angular measurements:
Total Degrees = 179 Degrees
Total Minutes = 37 Minutes
Total Seconds = 29 Seconds


Given the following Values:
First set of angular measurements:
Please enter degrees: 7
Please enter minutes: 14
Please enter seconds: 55
Second set of angular measurements:
Please enter degrees: 5
Please enter minutes: 24
Please enter seconds: 55
Adding the two set of angular measurements:
Total Degrees = 12 Degrees
Total Minutes = 39 Minutes
Total Seconds = 50 Seconds


Given the following Values:
First set of angular measurements:
Please enter degrees: 122
Please enter minutes: 17
Please enter seconds: 48
Second set of angular measurements:
Please enter degrees: 237
Please enter minutes: 42
Please enter seconds: 12
Adding the two set of angular measurements:
Total Degrees = 0 Degrees
Total Minutes = 0 Minutes
Total Seconds = 0 Seconds

*/
