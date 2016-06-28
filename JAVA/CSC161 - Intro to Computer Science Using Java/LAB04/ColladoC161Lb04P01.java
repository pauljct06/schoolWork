import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb04P01
public class ColladoC161Lb04P01
{
 public static void main(String[] args)
 {
  double a, b, c, x1, x2;

  System.out.println("Given the following values calculate the two possible values of \"x\"");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("value for \"a\": ");
  a = keyboard.nextDouble();
  System.out.print("value for \"b\": ");
  b = keyboard.nextDouble();
  System.out.print("value for \"c\": ");
  c = keyboard.nextDouble();

  x1 = ((-b + Math.sqrt(Math.pow(b,2) - (4*a*c))) / (2*a));
  System.out.println("Using quadratic formula x1 = " + x1);
  x2 = ((-b - Math.sqrt(Math.pow(b,2) - (4*a*c))) / (2*a));
  System.out.println("Using quadratic formula x2 = " + x2);

 }
}
/*
Given the following values calculate the two possible values of "x"
value for "a": 4
value for "b": 0
value for "c": -36
Using quadratic formula x1 = 3.0
Using quadratic formula x2 = -3.0
*/
/*
Given the following values calculate the two possible values of "x"
value for "a": 1
value for "b": 5
value for "c": -36
Using quadratic formula x1 = 4.0
Using quadratic formula x2 = -9.0
*/
/*
Given the following values calculate the two possible values of "x"
value for "a": 2
value for "b": 7.5
value for "c": 6.25
Using quadratic formula x1 = -1.25
Using quadratic formula x2 = -2.5
*/




