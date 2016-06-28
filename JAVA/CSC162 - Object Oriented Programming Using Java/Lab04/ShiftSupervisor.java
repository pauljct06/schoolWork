//filename: ShiftSupervisor.java
//Paul Collado
//CSC-162 Lab 4 Page 734 #2

import java.text.DecimalFormat;

public class ShiftSupervisor extends Employee
{
	private double annualsalary;
	private double annualbonus;

	public ShiftSupervisor()  // NO-ARG CONSTRUCTOR
	{
		super();
		annualsalary = 0.0;
		annualbonus = 0.0;
	}

	public ShiftSupervisor(String name, String number, String hdate, double asalary, double abonus) // CONSTRUCTOR
	{
		super(name,number,hdate);
		annualsalary = asalary;
		annualbonus = abonus;
	}

	public void setAnnualSalary(double asalary)
	{
		annualsalary = asalary;
	}

	public void setAnnualBonus(double abonus)
	{
		annualbonus = abonus;
	}

	public double getAnnualSalary()
	{
		return annualsalary;
	}

	public double getAnnualBonus()
	{
		return annualbonus;
	}

	public String toString()
	{
		DecimalFormat fmt = new DecimalFormat("0.00");

		String str ="\nShift Supervisor information:" +
					super.toString() +
					"\nSupervisor annual salary is: $" + fmt.format(annualsalary) +
					"\nSupervisor annual bonus is: $" + fmt.format(annualbonus);
		return str;
	}
}