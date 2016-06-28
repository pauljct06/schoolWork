import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P01
public class ColladoC161Lb05P01
{
 public static void main(String[] args)
 {
  int a, b, c;
  boolean triangle;

  System.out.printf("Given the following sides:\n");
  Scanner keyboard = new Scanner(System.in);
  System.out.printf("First side: ");
  a = keyboard.nextInt();
  System.out.printf("Second side: ");
  b = keyboard.nextInt();
  System.out.printf("Third side: ");
  c = keyboard.nextInt();

  if ((a + b) > c && (a + c) > b && (b + a) > c && (b + c) > a && (c + a) > b && (c + b) > a)
  {
   triangle = true;
   }
  else
  {
   triangle = false;
   }
  System.out.printf("\nCan edges %d, %d, and %d form a triangle? %b\n",a, b, c, triangle);
  }
}
/*
Given the following sides:
First side: 1
Second side: 2
Third side: 1

Can edges 1, 2,and 1 form a triangle? false

Given the following sides:
First side: 2
Second side: 2
Third side: 1

Can edges 2, 2,and 1 form a triangle? true
*/