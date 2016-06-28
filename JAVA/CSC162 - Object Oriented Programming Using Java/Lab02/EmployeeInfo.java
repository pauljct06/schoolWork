//filename:EmployeeInfo
//Paul Collado
//CSC-162 Lab 2 Page 357 #1

import java.util.Scanner;

public class EmployeeInfo
{
 public static void main(String[] args)
 {

 	System.out.println("Filename: EmployeeInfo \nPaul Collado \nCSC-162 Lab 2 Page 357 #1\n");

   	String name, department, position;
   	int idnumber;
   	EmployeeClass emp1, emp2, emp3;

   	Scanner keyboard = new Scanner(System.in);

   	System.out.print("Enter the first employee name: ");
   	name = keyboard.nextLine();

   	System.out.print("Enter the Id number: ");
   	idnumber = keyboard.nextInt();

   	keyboard.nextLine();

   	System.out.print("Enter the department: ");
   	department = keyboard.nextLine();

   	System.out.print("Enter the position: ");
   	position = keyboard.nextLine();

   	System.out.println();

   	//Passing info of employee 1 to a new object
   	emp1 = new EmployeeClass(name,idnumber,department,position);

   	System.out.print("Enter the second employee name: ");
   	name = keyboard.nextLine();

   	System.out.print("Enter the Id number: ");
   	idnumber = keyboard.nextInt();

   	keyboard.nextLine();

   	System.out.print("Enter the department: ");
   	department = keyboard.nextLine();

   	System.out.print("Enter the position: ");
   	position = keyboard.nextLine();

   	System.out.println();

   	//Passing info of employee 2 to a new object
   	emp2 = new EmployeeClass(name,idnumber,department,position);

   	System.out.print("Enter the third employee name: ");
   	name = keyboard.nextLine();

   	System.out.print("Enter the Id number: ");
   	idnumber = keyboard.nextInt();

   	keyboard.nextLine();

   	System.out.print("Enter the department: ");
   	department = keyboard.nextLine();

   	System.out.print("Enter the position: ");
   	position = keyboard.nextLine();

   	System.out.println();

   	//Passing info of employee 3 to a new object
   	emp3 = new EmployeeClass(name,idnumber,department,position);

   	//Displaying information
   	System.out.println();
   	System.out.println("Name            ID Number      Department      Position     ");
   	System.out.println("-----------------------------------------------------------------");
   	System.out.print(emp1.getName() + "\t" + emp1.getIdnumber());
   	System.out.println(" \t\t" + emp1.getDepartment() + "\t" + emp1.getPosition());
   	System.out.print(emp2.getName() + "  \t" + emp2.getIdnumber());
   	System.out.println(" \t\t" + emp2.getDepartment() + "\t\t" + emp2.getPosition());
   	System.out.print(emp3.getName() + "  \t" + emp3.getIdnumber());
   	System.out.println(" \t\t" + emp3.getDepartment() + "\t" + emp3.getPosition());
   	System.out.println();
 }
}

/*
Filename:EmployeeInfo
Paul Collado
CSC-162 Lab 2 Page 357 #1

Enter the first employee name: Susan Meyers
Enter the Id number: 47899
Enter the department: Accounting
Enter the position: Vice President

Enter the second employee name: Mark Jones
Enter the Id number: 39119
Enter the department: IT
Enter the position: Programmer

Enter the third employee name: Joy Rogers
Enter the Id number: 81774
Enter the department: Manufacturing
Enter the position: Engineer


Name            ID Number      Department      Position
-----------------------------------------------------------------
Susan Meyers    47899           Accounting      Vice President
Mark Jones      39119           IT              Programmer
Joy Rogers      81774           Manufacturing   Engineer

Press any key to continue . . .

*/