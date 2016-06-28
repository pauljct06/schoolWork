import java.util.Scanner;
public class getprintarraymethods
{
 public static void main(String []args)
 {
	 int []A = new int[3];
	 Get(A);
	 Print(A);
 }
 public static void Get(int []A)
 {
	 Scanner kb = new Scanner(System.in);
	 for(int LCV =0; LCV<A.length; LCV++)
	 {
		 System.out.print("Enter No: ");
		 A[LCV] = kb.nextInt();
	 }
 }
public static void Print(int []A)
 {
	 Scanner kb = new Scanner(System.in);
	 for(int LCV =0; LCV<A.length; LCV++)
	 {
		 System.out.println(A[LCV]);

	 }
 }
}
/*
Enter No: 12
Enter No: 14
Enter No: 16
12
14
16
*/


