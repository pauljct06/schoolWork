import java.util.Scanner;
import java.util.Random;
//Paul Collado, CSC161-62
//C161Lb07P03
public class ColladoC161Lb07P03
{
 public static void main (String[] args)
  {
  int random, guess = 0, LCV;


  Scanner keyboard = new Scanner(System.in);
  Random randomNumbers = new Random();


  random = randomNumbers.nextInt(100);
  System.out.println("Guess a number between 0 to 100....can you??!!!");
  System.out.print("Enter your guess: ");
  //guess = keyboard.nextInt();
  while(guess != random)
  {
  guess = keyboard.nextInt();

  if (guess == random)break;

  else if (guess < random)
  {System.out.println("Too low...keep trying!");
   System.out.print("Enter your new guess :");}

  else
  {System.out.println("Too high....keep trying!");
   System.out.print("Enter your new guess :");}
  }
  System.out.println("\nYou guessed it!!, The number was " + random);
 }
}
/*
Guess a number between 0 to 100....can you??!!!
Enter your guess: 50
Too high....keep trying!
Enter your new guess :40
Too high....keep trying!
Enter your new guess :30
Too high....keep trying!
Enter your new guess :20
Too low...keep trying!
Enter your new guess :25
Too high....keep trying!
Enter your new guess :24
Too high....keep trying!
Enter your new guess :23
Too high....keep trying!
Enter your new guess :22

You guessed it!!, The number was 22
*/