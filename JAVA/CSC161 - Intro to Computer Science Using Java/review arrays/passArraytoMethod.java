import java.util.Scanner;
public class passArraytoMethod
{
 public static void main(String []args)
 {
  int[] A = {3,4,5};
  print(A);
 }
 public static void print(int []A)
 {
  for(int LCV = 0; LCV < A.length; LCV++)
  {
   System.out.println(A[LCV]);
  }
 }
}
/*
3
4
5
*/