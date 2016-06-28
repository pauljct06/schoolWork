import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb07P01
public class ColladoC161Lb07P01
{
 public static void main (String[]args)
 {
  String star= "*" ;
  double sales = 1;
  long salesR = 1;


  System.out.println("Please enter today's sales for the five stores:");
  Scanner keyboard = new Scanner(System.in);
  for (int LCV =1; LCV <6; LCV++)
  {
  System.out.printf("Enter today's sales for store %d: ",LCV);
  sales = keyboard.nextInt();

  salesR = (Math.round(sales/100)*100)/100;
  }


  //System.out.println("SALES BAR CHART");
  //for (int x = 1 ;x<=salesR ;x++)
  //{System.out.printf("Store %d: %s",LCV, star);}
  //}


 }
}
