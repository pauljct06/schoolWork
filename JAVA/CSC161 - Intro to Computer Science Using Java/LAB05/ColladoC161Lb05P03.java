import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P03
public class ColladoC161Lb05P03
{
 public static void main(String[] args)
 {
  double number;
  String letter = "a";
  double Cnumber, Fnumber;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("Enter a number: ");
  number = keyboard.nextDouble();
  System.out.print("Enter F for Fahrenheit or C for Celsius: ");
  letter = keyboard.next();

 if (letter.equalsIgnoreCase("F"))
   {
	System.out.printf("Converting to Celsius\n");
	Cnumber = (5.0/9.0) * (number - 32.0);
	System.out.printf("%3.2f C\n",Cnumber);
   }
 else if (letter.equalsIgnoreCase("C"))
 	{
	 System.out.printf("Converting to Fahrenheit\n");
	 Fnumber = (((number * 9.0) / 5.0) + 32);
	 System.out.printf("%3.2f F\n",Fnumber);
	}
 else
	{
	 System.out.printf("The character entered is not a valid character\n");
	}
 }
}
/*
Given the following values:
Enter a number: 26
Enter F for Fahrenheit or C for Celsius: c
Converting to Fahrenheit
78.80 F

Given the following values:
Enter a number: 78.8
Enter F for Fahrenheit or C for Celsius: f
Converting to Celsius
26.00 C

Given the following values:
Enter a number: 26
Enter F for Fahrenheit or C for Celsius: k
The character enter is not a valid character
*/