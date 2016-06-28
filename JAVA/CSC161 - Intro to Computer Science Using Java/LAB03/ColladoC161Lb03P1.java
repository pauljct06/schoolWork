import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb03P1
public class ColladoC161Lb03P1
{
 public static void main (String[] args)
 {
  int YourNumber;


  Scanner keyboard = new Scanner(System.in);
  System.out.print("Your 6 digits number is: ");
  YourNumber = keyboard.nextInt();

  System.out.println("First digit: " + (YourNumber / 100000) % 10);
  System.out.println("Second digit: " + (YourNumber / 10000) % 10);
  System.out.println("Third digit: " + (YourNumber / 1000) % 10);
  System.out.println("Fourth digit: " + (YourNumber / 100) % 10);
  System.out.println("Fifth digit: " + (YourNumber / 10) % 10);
  System.out.println("Sixth digit: " + YourNumber % 10);
 }
}
/*
Your 6 digits number is: 123456
First digit: 1
Second digit: 2
Third digit: 3
Fourth digit: 4
Fifth digit: 5
Sixth digit: 6
*/
