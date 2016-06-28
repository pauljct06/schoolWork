//import java.util.Scanner;
public class highestelement
{
 public static void main(String [] args)
 {
  int[] A = {12,39,2,5};
  int Max = A[0];

  for( int I = 0; I< A.length; I++)
  {
	  if(A[I] > Max)  // Change sign to "<" to ge the lowest
	  Max=A[I];
  }
    System.out.println(Max);
 }
}

/*

39

*/
