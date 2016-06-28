import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P03A
public class ColladoC161Lb05P03A
{
 public static void main(String[] args)
 {
  double number;
  String letter = "a";
  double Cnumber, Fnumber;
  int LCV;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);

  for(LCV=1;LCV<=3;LCV++)
 {
  System.out.print("Enter a number: ");
  number = keyboard.nextDouble();
  System.out.print("Enter F for Fahrenheit or C for Celsius: ");
  letter = keyboard.next();

 if (letter.equalsIgnoreCase("F"))
   {
	System.out.printf("Converting to Celsius\n");
	Cnumber = (5.0/9.0) * (number - 32.0);
	System.out.printf("%3.2f C\n\n",Cnumber);
   }
 else if (letter.equalsIgnoreCase("C"))
 	{
	 System.out.printf("Converting to Fahrenheit\n");
	 Fnumber = (((number * 9.0) / 5.0) + 32);
	 System.out.printf("%3.2f F\n\n",Fnumber);
	}
 else
	{
	 System.out.printf("The character enter is not a valid character\n\n");
	}
 }
 }
}
/*
Given the following values:
Enter a number: 26
Enter F for Fahrenheit or C for Celsius: c
Converting to Fahrenheit
78.80 F

Enter a number: 80
Enter F for Fahrenheit or C for Celsius: f
Converting to Celsius
26.67 C

Enter a number: 50
Enter F for Fahrenheit or C for Celsius: k
The character enter is not a valid character
*/