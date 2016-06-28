import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb03P4
public class ColladoC161Lb03P4
{
 public static void main (String[] args)
 {
  int year;
  double population;

  System.out.println("Given the year");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("Year: ");
  year = keyboard.nextInt();

  population = (6 * (1 + (Math.pow(Math.E, (0.02 * (year - 2000))))));
  System.out.println("World Population is: " + Math.round(population) + " billions");
 }
}
/*
Given the year
Year: 2012
World Population is: 14 billions
*/