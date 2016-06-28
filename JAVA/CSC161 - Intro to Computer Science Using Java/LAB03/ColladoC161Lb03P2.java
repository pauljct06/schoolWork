import java.util.Scanner;
import java.math.*;

//Paul Collado, CSC161-62
//C161Lb03P2
public class ColladoC161Lb03P2
{
 public static void main (String[] args)
 {
  int x1, x2, y1, y2;
  double distance;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("x1 = ");
  x1 = keyboard.nextInt();
  System.out.print("x2 = ");
  x2 = keyboard.nextInt();
  System.out.print("y1 = ");
  y1 = keyboard.nextInt();
  System.out.print("y2 = ");
  y2 = keyboard.nextInt();

  System.out.println("Coordinates for the first point: (" + x1 + "," + x2 + ")");
  System.out.println("Coordinates for the second point: (" + y1 + "," + y2 + ")");

  distance = (Math.sqrt((Math.pow((x1 - x2), 2)) + (Math.pow((y1 - y2), 2))));
  BigDecimal rdistance = new BigDecimal (distance);
  rdistance = rdistance.setScale(2, BigDecimal.ROUND_HALF_UP);

  System.out.println("Distance is = " + rdistance);
 }
}
/*
Given the following values:
x1 = -12
x2 = -15
y1 = 22
y2 = 5
Coordinates for the first point: (-12,-15)
Coordinates for the second point: (22,5)
Distance is = 17.26
*/