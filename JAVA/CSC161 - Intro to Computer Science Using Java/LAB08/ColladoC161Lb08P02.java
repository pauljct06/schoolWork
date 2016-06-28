import java.io.*;
import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb08P02
public class ColladoC161Lb08P02
{
 public static void main(String[]args) throws IOException
 {
  String Fname= "", Lname="";
  int Hourswork=0;
  double Hourlypay=0.0, Grosspay=0.0;

  ReadData(Fname, Lname, Hourswork, Hourlypay,Grosspay);
 }

 public static void ReadData(String Fname, String Lname, int Hourswork, double Hourlypay,
                             double Grosspay) throws IOException
 {
  System.out.println("Please enter the following information:");
  File myFile = new File("Employee.txt");
  Scanner inputFile = new Scanner(myFile);
  Fname = inputFile.nextLine();
  Lname = inputFile.nextLine();
  Hourswork = inputFile.nextInt();
  Hourlypay = inputFile.nextDouble();
  Grosspay = inputFile.nextDouble();

  inputFile.close();

  System.out.printf("Employee First name: %s\nEmployee Last name: %s\nHours worked: %d\n" +
                    "Hourly pay rate: %3.2f\nGross pay: %4.2f\n",Fname, Lname, Hourswork,
                    Hourlypay,Grosspay);
 }
}
/*
Please enter the following information:
Employee First name: Paul
Employee Last name: Collado
Hours worked: 40
Hourly pay rate: 12.50
Gross pay: 500.00
*/