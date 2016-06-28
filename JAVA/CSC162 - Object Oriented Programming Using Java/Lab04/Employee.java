//filename: Employee.java
//Paul Collado
//CSC-162 Lab 4 Page 733 #1

public class Employee
{
	protected String employeename;
	protected String employeenumber;
	protected String hiredate;

	public Employee() // NO ARG-CONSTRUCTOR
	{
		employeename = "";
		employeenumber = "";
		hiredate = "";
	}

	public Employee(String name, String number, String hdate) // CONSTRUCTOR
	{
		employeename = name;
		employeenumber = number;
		hiredate = hdate;
	}

	public String getEmployeeName()
	{
		return employeename;
	}

	public String getEmployeeNumber()
	{
		return employeenumber;
	}

	public String getHireDate()
	{
		return hiredate;
	}

	public String toString()
	{
		String str = "\nName is: " + employeename +
					 "\nId Number is: " + employeenumber +
					 "\nHired Date is: " + hiredate;
		return str;
	}
}