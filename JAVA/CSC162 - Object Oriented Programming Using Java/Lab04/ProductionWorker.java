//filename: ProductionWorker.java
//Paul Collado
//CSC-162 Lab 4 Page 733 #1

import java.text.DecimalFormat;

public class ProductionWorker extends Employee
{
	private int shift;
	private double hourlypayrate;

	public ProductionWorker() //NO ARG-CONSTRUCTOR
	{
		super();
		shift = 0;
		hourlypayrate = 0.0;
	}

	public ProductionWorker(String name, String number, String hdate, int s, double rate) // CONSTRUCTOR
	{
		super(name,number,hdate);
		shift = s;
		hourlypayrate = rate;
	}

	public double getHourlyPayRate()
	{
		return hourlypayrate;
	}

	public String toString()
	{
		DecimalFormat fmt = new DecimalFormat("0.00");

		String str = "";

		if(this.shift == 1)
		{
			str = "Employee information:" +
				  super.toString() +
				  "\nShift is: " + shift + " (Day Shift)" +
				  "\nHourly Pay Rate is: $" + fmt.format(hourlypayrate);
		}
		else if(this.shift == 2)
		{
			str = "Employee information:" +
				  super.toString() +
				  "\nShift is: " + shift + " (Night Shift)" +
				  "\nHourly Pay Rate is: $" + fmt.format(hourlypayrate);
		}
		return str;
	}
}