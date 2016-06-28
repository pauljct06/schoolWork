import java.util.Scanner;
public class arraySintax
{
 public static void main(String []args)
 {
  final int maxsize = 10;
  int[] array = new int[maxsize];

  Scanner kb = new Scanner(System.in);
  int LCV;
  for (LCV = 0; LCV<maxsize; LCV++)
  {
	  System.out.print("Enter array [" + LCV + "]: ");
	  array[LCV]= kb.nextInt();
  }
 }
}
/*
Enter array [0]: 1
Enter array [1]: 2
Enter array [2]: 3
Enter array [3]: 4
Enter array [4]: 5
Enter array [5]: 6
Enter array [6]: 7
Enter array [7]: 8
Enter array [8]: 9
Enter array [9]: 10
*/