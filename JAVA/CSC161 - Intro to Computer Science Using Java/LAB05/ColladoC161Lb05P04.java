import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P04
public class ColladoC161Lb05P04
{
 public static void main(String[] args)
 {
  int Year, Weight, WeightClass = 0;
  double Fee = 0;

  System.out.println("Given the following data about your car:");
  Scanner keyboard = new Scanner(System.in);
  System.out.printf("Please input car's model year? ");
  Year = keyboard.nextInt();
  System.out.printf("Please input car's weight? ");
  Weight = keyboard.nextInt();


  if(Weight < 2700 && Year <= 1970)
  {WeightClass = 1;}
  else if(Weight >=2700 && Weight <= 3800 && Year <= 1970)
  {WeightClass = 2;}
  else if(Weight > 3800 && Year <= 1970)
  {WeightClass = 3;}
  else if(Weight < 2700 && Year > 1970 && Year <= 1979)
  {WeightClass = 4;}
  else if(Weight >=2700 && Weight <= 3800 && Year > 1970 && Year <= 1979)
  {WeightClass = 5;}
  else if(Weight > 3800 && Year > 1970 && Year <= 1979)
  {WeightClass = 6;}
  else if(Weight < 3500 && Year >= 1980)
  {WeightClass = 7;}
  else if(Weight >= 3500 && Year >= 1980)
  {WeightClass = 8;}

  System.out.printf("Your Weight Class is: %d\n",WeightClass);

  if(WeightClass == 1)
  {Fee = 16.50;}
  else if(WeightClass == 2)
  {Fee = 25.50;}
  else if(WeightClass == 3)
  {Fee = 46.50;}
  else if(WeightClass == 4)
  {Fee = 27.00;}
  else if(WeightClass == 5)
  {Fee = 30.50;}
  else if(WeightClass == 6)
  {Fee = 52.50;}
  else if(WeightClass == 7)
  {Fee = 19.50;}
  else if(WeightClass == 8)
  {Fee = 52.50;}

  System.out.printf("Then your Registration fee is: $%2.2f\n",Fee);
 }
}
/*
Given the following data about your car:
Please input car's model year? 1960
Please input car's weight? 2699
Your Weight Class is: 1
Then your Registration fee is: $16.50

Given the following data about your car:
Please input car's model year? 1970
Please input car's weight? 2700
Your Weight Class is: 2
Then your Registration fee is: $25.50

Given the following data about your car:
Please input car's model year? 1962
Please input car's weight? 3801
Your Weight Class is: 3
Then your Registration fee is: $46.50

Given the following data about your car:
Please input car's model year? 1971
Please input car's weight? 2699
Your Weight Class is: 4
Then your Registration fee is: $27.00

Given the following data about your car:
Please input car's model year? 1975
Please input car's weight? 3800
Your Weight Class is: 5
Then your Registration fee is: $30.50

Given the following data about your car:
Please input car's model year? 1979
Please input car's weight? 4000
Your Weight Class is: 6
Then your Registration fee is: $52.50

Given the following data about your car:
Please input car's model year? 1980
Please input car's weight? 3499
Your Weight Class is: 7
Then your Registration fee is: $19.50

Given the following data about your car:
Please input car's model year? 2009
Please input car's weight? 3500
Your Weight Class is: 8
Then your Registration fee is: $52.50
*/