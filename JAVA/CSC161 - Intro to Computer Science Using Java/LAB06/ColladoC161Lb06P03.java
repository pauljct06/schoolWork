import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb06P03
public class ColladoC161Lb06P03
{
 public static void main(String[] args)
 {
  int Grade, LCV;
  char GradeLetter;

  Scanner keyboard = new Scanner (System.in);
  for (LCV=1; LCV<=3; LCV++)
  {
  System.out.print("Please input a score: ");
  Grade = keyboard.nextInt();

  switch (Grade/10)
  {
   case 10 :System.out.println("Grade is A"); break;
   case 9  :System.out.println("Grade is A"); break;
   case 8  :System.out.println("Grade is B"); break;
   case 7  :System.out.println("Grade is C"); break;
   case 6  :System.out.println("Grade is D"); break;
   case 5  :System.out.println("Grade is F"); break;
   case 4  :System.out.println("Grade is F"); break;
   case 3  :System.out.println("Grade is F"); break;
   case 2  :System.out.println("Grade is F"); break;
   case 1  :System.out.println("Grade is F"); break;
   case 0  :System.out.println("Grade is F"); break;
   default :System.out.println("Invalid Entry");
  }
  }

 }
}