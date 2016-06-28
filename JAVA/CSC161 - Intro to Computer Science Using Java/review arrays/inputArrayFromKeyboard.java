import java.util.Scanner;
public class inputArrayFromKeyboard
{
 public static void main(String []args)
 {
  int arraysize;
  Scanner kb = new Scanner(System.in);
  System.out.println("Enter number of elements");
  arraysize = kb.nextInt();

  int[] array = new int [arraysize];

  for(int LCV = 0; LCV < arraysize; LCV++)
  {
   System.out.println("Enter number");
   array[LCV] = kb.nextInt();
  }
 }
}
/*
Enter number of elements
3
Enter number
1
Enter number
2
Enter number
3
*/