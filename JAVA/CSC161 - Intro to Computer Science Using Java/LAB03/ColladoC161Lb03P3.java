import java.util.Scanner;
import java.math.*;

//Paul Collado, CSC161-62
//C161Lb03P3
public class ColladoC161Lb03P3
{
 public static void main (String[] args)
 {
  double LadderLength;
  double height;

  System.out.println("Given the following ladder length");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("Ladder Length: ");
  LadderLength = keyboard.nextDouble();

  height = (LadderLength * Math.sin(Math.toRadians(85)));

  BigDecimal Height = new BigDecimal (height);
  Height = Height.setScale(2, BigDecimal.ROUND_HALF_UP);
  System.out.println("Building height is: " + Height);
 }
}
/*
Given the following ladder length
Ladder Length: 25
Building height is: 24.90
*/