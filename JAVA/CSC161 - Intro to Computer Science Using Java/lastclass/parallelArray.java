//import java.util.Scanner;
public class parallelArray
{
 public static void main(String [] args)
 {
	 double[] price = {1.99,2.99}; //both must be the same size
	 int [] quantity = { 100,253}; //both must be the same size
	 double [] totalprice = new double[price.length];

	 for( int L=0; L < price.length; L++)
	 {
		totalprice[L] = price[L] * quantity[L]; //We multiply 2 arrays by using the parallel array conpcept

	    System.out.println(totalprice[L]);
	 }
 }
}
/*
199.0
756.47
*/