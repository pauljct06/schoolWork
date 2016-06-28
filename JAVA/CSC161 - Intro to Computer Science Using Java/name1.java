public class name1
{
 public static void main(String [] args)
 {
  double A=2.5, Num;
  Num = Square(A);

  System.out.printf("\nSquare of A=%8.2f", Num);
 }
 public static double Square(double A)
 {
	 double SquareNum= A*A;
	 return SquareNum;
 }
}
