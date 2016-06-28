import java.util.Scanner;
public class Test5
{
 public static void main(String [] args)
 {
   final int Arraysize= 5;
   int []A = new int [Arraysize];

   getArray(A);

 }
 public static void getArray(int []A)
 {
   Scanner kb = new Scanner(System.in);

   for(int LCV = 0; LCV< A.length; LCV++)
   {
	    System.out.println("Array name: ");
	    A[LCV]=kb.nextInt();
	}
  }
}


