public class copyarray
{
 public static void main(String []args)
 {
  int A[] = {1,2,3};
  int []B;

  B = new int [A.length];

  for (int LCV=0; LCV < A.length; LCV++)
  {
	  B[LCV] = A[LCV];

  	  System.out.println(B[LCV]);
  }

 }
}
/*
1
2
3
*/