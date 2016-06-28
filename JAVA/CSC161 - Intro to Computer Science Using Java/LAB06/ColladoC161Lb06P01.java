import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb06P01
public class ColladoC161Lb06P01
{
 public static void main(String[] args)
 {
  String Char;

  Scanner keyboard = new Scanner(System.in);
  System.out.printf("Please input a single character: ");
  Char = keyboard.nextLine();

  char letter = Char.charAt(0);

  if(letter >= '0' && letter <= '9')
  {System.out.printf("Your character: %c , is a digit.\n", letter);}
  else if(letter >= 'a' && letter <= 'z')
 {System.out.printf("Your character: %c , is a lower case letter.\n", letter);}
  else if(letter >= 'A' && letter <= 'Z')
 {System.out.printf("Your character: %c , is a upper case letter.\n", letter);}
  else
  {System.out.printf("Your character: %c , is a symbol.\n", letter);}
 }
}
/*
Please input a single character: 5
Your character: 5 , is a digit
*/