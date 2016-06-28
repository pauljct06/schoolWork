//filename: EmployeeDemo.java
//Paul Collado
//CSC-162 Lab 4 Page 733-734 #1 and #2

import java.util.Scanner;

public class EmployeeDemo
{
 public static void main (String[] args)
 {
	 System.out.print("Filename: EmployeeDemo.java \nPaul Collado");
	 System.out.println("\nCSC-162 Lab 4 Page 733-734 #1 and #2\n");

	 String input, repeat;          // VARIABLES USED FOR LOOPS
	 char inputanswer, repeatanswer;

	 ProductionWorker[] employee = new ProductionWorker[4];  // DECLARING ARRAYS
	 ShiftSupervisor[] supervisor = new ShiftSupervisor[4];

	 String name, id, hiredate;
	 int shift;
	 double hourlyrate;
	 double supervisorsalary;
	 double supervisorbonus;
	 boolean flag = true;

	 Scanner keyboard = new Scanner(System.in);

	 do{ //USER CONTROLLEP LOOP

	 	System.out.println("This program accepts and Displays information about 4 employees");
	 	System.out.println("\nIf this employee a Shift Supervisor?");
	 	System.out.print("Enter Y, for yes, or else enter any other key: "); //DECIDES WHICH CLASS TO CALL
	 	input = keyboard.nextLine();
	 	inputanswer = input.charAt(0);

	 	if(inputanswer == 'Y' || inputanswer == 'y') //CALLING Supervisor class
	 	{
			for(int index = 0; index < supervisor.length; index++)
			{
				//GETTING SUPERVISOR INFO
				System.out.println("\nEnter info for supervisor number " + (index+1)  + ":");
				System.out.print("Enter supervisor name: ");
				name = keyboard.nextLine();

				do {
					flag = true;

					System.out.print("Enter supervisor id, 4 characters (XXX-L): "); // VALIDATION OF ID
					id = keyboard.nextLine();

					if(!(id.charAt(0) >= '0' && id.charAt(0) <= '9'))flag = false;
					if (!(id.charAt(1) >= '0' && id.charAt(1) <= '9'))flag = false;
					if (!(id.charAt(2) >= '0' && id.charAt(2) <= '9'))flag = false;
					if (!(id.charAt(3) == '-' ))flag = false;
					if (!(id.charAt(4) >= 'A' && id.charAt(4) <= 'M'))flag = false;

					if (!flag) // there was an error since flag is false
						{
						  System.out.print("You must enter a valid Id in the format XXX-L ");
						  System.out.print("(where X is a number between 0 and 9 and L is a capital ");
						  System.out.println("letter between A and M including the - (dash)...try again");
						}

					} while (!flag); //end do while

				System.out.print("Enter hire date: ");
				hiredate = keyboard.nextLine();
				System.out.print("Enter annual salary: $");
				supervisorsalary = keyboard.nextDouble();
				System.out.print("Enter annual bonus: $");
				supervisorbonus = keyboard.nextDouble();
				keyboard.nextLine();


				//CREATING NEW INSTANCE AND CALLING toString Method
				supervisor[index] = new ShiftSupervisor(name,id,hiredate,supervisorsalary,supervisorbonus);
				System.out.println();
				System.out.println(supervisor[index]);
				System.out.println();

			}//end for index
		} // end if on inputAnswer

	 	else //CALLING ProductionWorker CLASS
	 	{
		 	for(int index = 0; index < employee.length; index++)
		 	{
				//GETTING EMPLOYEE INFO
				System.out.println("\nEnter info for employee number " + (index+1) + ":");
				System.out.print("Enter employee name: ");
		 		name = keyboard.nextLine();

				do {
					flag = true;

					System.out.print("Enter employee id, 4 characters (XXX-L): ");
					id = keyboard.nextLine();

					if(!(id.charAt(0) >= '0' && id.charAt(0) <= '9'))flag = false;
					if (!(id.charAt(1) >= '0' && id.charAt(1) <= '9'))flag = false;
					if (!(id.charAt(2) >= '0' && id.charAt(2) <= '9'))flag = false;
					if (!(id.charAt(3) == '-' ))flag = false;
					if (!(id.charAt(4) >= 'A' && id.charAt(4) <= 'M'))flag = false;

					if (!flag) // there was an error since flag is false
						{
						  System.out.print("You must enter a valid Id in the format XXX-L ");
						  System.out.print("(where X is a number between 0 and 9 and L is a capital ");
						  System.out.println("letter between A and M including the - (dash)...try again");
						}

					} while (!flag); //end do while

		 		System.out.print("Enter hire date: ");
		 		hiredate = keyboard.nextLine();
		 		System.out.print("Enter 1 for day shift or 2 for night shift: ");
		 		shift = keyboard.nextInt();
		 		System.out.print("Enter hourly pay rate: $");
		 		hourlyrate = keyboard.nextDouble();
		 		keyboard.nextLine();

		 		//CREATING NEW INSTANCE AND CALLING toString Method
		 		employee[index] = new ProductionWorker(name,id,hiredate,shift,hourlyrate);
		 		System.out.println();
		 		System.out.println(employee[index]);
		 		System.out.println();
		 	} // end for index
	 	} // end if on input answer

	 	// PROMPTING TO RUN LOOP AGAIN
	 	System.out.print("Enter 'Y' if you wish to run the program again or any other key to exit: ");
	 	repeat = keyboard.nextLine();
	 	repeatanswer = input.charAt(0);
	 	System.out.println();

	}while(repeatanswer == 'Y' || repeatanswer == 'y');  // TESTING LOOP CONTINUITY
 }
}
/*
Filename: EmployeeDemo.java
Paul Collado
CSC-162 Lab 4 Page 733-734 #1 and #2

This program accepts and Displays information about 4 employees

If this employee a Shift Supervisor?
Enter Y, for yes, or else enter any other key: Y

Enter info for supervisor number 1:
Enter supervisor name: SUPER1
Enter supervisor id, 4 characters (XXX-L): ADF-A
You must enter a valid Id in the format XXX-L (where X is a number between 0 and
 9 and L is a capital letter between A and M including the - (dash)...try again
Enter supervisor id, 4 characters (XXX-L): 1230A
You must enter a valid Id in the format XXX-L (where X is a number between 0 and
 9 and L is a capital letter between A and M including the - (dash)...try again
Enter supervisor id, 4 characters (XXX-L): 123-W
You must enter a valid Id in the format XXX-L (where X is a number between 0 and
 9 and L is a capital letter between A and M including the - (dash)...try again
Enter supervisor id, 4 characters (XXX-L): 123-A
Enter hire date: 10/10/10
Enter annual salary: $20000
Enter annual bonus: $2000


Shift Supervisor information:
Name is: SUPER1
Id Number is: 123-A
Hired Date is: 10/10/10
Supervisor annual salary is: $20000.00
Supervisor annual bonus is: $2000.00


Enter info for supervisor number 2:
Enter supervisor name: SUPER2
Enter supervisor id, 4 characters (XXX-L): 321-J
Enter hire date: 09/09/09
Enter annual salary: $30000
Enter annual bonus: $3000


Shift Supervisor information:
Name is: SUPER2
Id Number is: 321-J
Hired Date is: 09/09/09
Supervisor annual salary is: $30000.00
Supervisor annual bonus is: $3000.00


Enter info for supervisor number 3:
Enter supervisor name: SUPER3
Enter supervisor id, 4 characters (XXX-L): 567-B
Enter hire date: 08/08/08
Enter annual salary: $40000
Enter annual bonus: $4000


Shift Supervisor information:
Name is: SUPER3
Id Number is: 567-B
Hired Date is: 08/08/08
Supervisor annual salary is: $40000.00
Supervisor annual bonus is: $4000.00


Enter info for supervisor number 4:
Enter supervisor name: SUPER4
Enter supervisor id, 4 characters (XXX-L): 894-C
Enter hire date: 10/09/08
Enter annual salary: $50000
Enter annual bonus: $5000


Shift Supervisor information:
Name is: SUPER4
Id Number is: 894-C
Hired Date is: 10/09/08
Supervisor annual salary is: $50000.00
Supervisor annual bonus is: $5000.00

Enter 'Y' if you wish to run the program again or any other key to exit: Y

This program accepts and Displays information about 4 employees

If this employee a Shift Supervisor?
Enter Y, for yes, or else enter any other key: N

Enter info for employee number 1:
Enter employee name: EMP1
Enter employee id, 4 characters (XXX-L): 576-D
Enter hire date: 09/10/09
Enter 1 for day shift or 2 for night shift: 1
Enter hourly pay rate: $10.5

Employee information:
Name is: EMP1
Id Number is: 576-D
Hired Date is: 09/10/09
Shift is: 1 (Day Shift)
Hourly Pay Rate is: $10.50


Enter info for employee number 2:
Enter employee name: EMP2
Enter employee id, 4 characters (XXX-L): 546-H
Enter hire date: 08/10/09
Enter 1 for day shift or 2 for night shift: 2
Enter hourly pay rate: $15.2

Employee information:
Name is: EMP2
Id Number is: 546-H
Hired Date is: 08/10/09
Shift is: 2 (Night Shift)
Hourly Pay Rate is: $15.20


Enter info for employee number 3:
Enter employee name: EMP3
Enter employee id, 4 characters (XXX-L): 888-I
Enter hire date: 09/08/10
Enter 1 for day shift or 2 for night shift: 1
Enter hourly pay rate: $18

Employee information:
Name is: EMP3
Id Number is: 888-I
Hired Date is: 09/08/10
Shift is: 1 (Day Shift)
Hourly Pay Rate is: $18.00


Enter info for employee number 4:
Enter employee name: EMP4
Enter employee id, 4 characters (XXX-L): 962-G
Enter hire date: 07/07/08
Enter 1 for day shift or 2 for night shift: 2
Enter hourly pay rate: $20

Employee information:
Name is: EMP4
Id Number is: 962-G
Hired Date is: 07/07/08
Shift is: 2 (Night Shift)
Hourly Pay Rate is: $20.00

Enter 'Y' if you wish to run the program again or any other key to exit: N

Press any key to continue . . .

*/