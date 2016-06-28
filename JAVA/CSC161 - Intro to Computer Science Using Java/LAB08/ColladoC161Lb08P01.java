import java.io.*;
import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb08P01
public class ColladoC161Lb08P01
{
 public static void main(String [] args) throws IOException
 {
  String Fname, Lname;
  int Hourswork;
  double Hourlypay, Grosspay;

  Scanner keyboard = new Scanner(System.in);
  System.out.println("Please enter the followin information:");
  System.out.print("First name of the employee: ");
  Fname = keyboard.nextLine();
  System.out.print("Last name of the employee: ");
  Lname = keyboard.nextLine();
  System.out.print("Number of hours worked: ");
  Hourswork = keyboard.nextInt();
  System.out.print("Hourly pay rate: ");
  Hourlypay = keyboard.nextDouble();
  System.out.print("Gross pay: ");
  Grosspay = Hourswork * Hourlypay;
  System.out.println(Grosspay);
  }

  public static void InputData(String Fname, String Lname, int Hourswork,
                               double Hourlypay, double Grosspay) throws IOException
 {

  PrintWriter outputFile = new PrintWriter("Employee.txt");

  outputFile.println(Fname);
  outputFile.println(Lname);
  outputFile.println(Hourswork);
  outputFile.println(Hourlypay);
  outputFile.println(Grosspay);

  outputFile.close();

  System.out.println("Data has been written to the employee.txt file");
   }
  }
/*
Please enter the followin information:
First name of the employee: Paul
Last name of the employee: Collado
Number of hours worked: 40
Hourly pay rate: 12
Gross pay: 480.0
*/
