import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb06P01C
public class ColladoC161Lb06P01C
{
 public static void main(String[] args)
 {
  String Char;
  int LCV = 1;

  Scanner keyboard = new Scanner(System.in);
  do
  {
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
  ++LCV;
  }
  while(LCV <= 3);
 }
}
/*
Please input a single character: #
Your character: # , is a symbol.
Please input a single character: 8
Your character: 8 , is a digit.
Please input a single character: w
Your character: w , is a lower case letter.
*/