import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb07P02
public class ColladoC161Lb07P02
{
 public static void main (String[] args)
 {
 double budget, expenses;
 int LCV;


 Scanner keyboard = new Scanner (System.in);
 System.out.print("Please enter the amount budgeted this month: $");
 budget = keyboard.nextDouble();
 System.out.println("Now enter your expenses for this month and enter 0 when you are done");

 for (LCV = 1; LCV >=1; LCV++)
 {
 System.out.printf("Expense %d: $", LCV);
 expenses = keyboard.nextDouble();

 budget = budget - expenses;
 if (expenses == 0)
  {break;}
 }
 System.out.print("Your budget is now: $");
 System.out.printf("%.2f \n", budget);
  }
 }
 /*
 Please enter the amount budgeted this month: $1000
 Now enter your expenses for this month and enter 0 when you are done
 Expense 1: $500
 Expense 2: $200
 Expense 3: $10
 Expense 4: $0
 Your budget is now: $290.00
 */