//filename: RoomCarpet.java
//Paul Collado
//CSC-162 Lab 3 Page 598 #3

import java.text.DecimalFormat;

public class RoomCarpet
{
	private RoomDimension size;
	private double carpetcost;

	public RoomCarpet()   //NO-ARG CONSTRUCTOR
	{
		carpetcost = 0.0;
		size = null;
	}

	public RoomCarpet(RoomDimension dim, double cost) // CONSTRUCTOR
	{
		carpetcost = cost;
		size = new RoomDimension(dim);   // CALLING COPY CONSTRUCTOR
	}

	public double getCost()
	{
		return carpetcost;
	}

	public RoomDimension getRoomDimension()
	{
		return new RoomDimension(size);
	}

	public double getTotalCost()
	{
		double totalcost;

		if(size != null)     // TESTING FOR NULL OBJECT
		{
			totalcost = size.getArea() * carpetcost;
		}

		else
		{
		totalcost = 0.0;
		}

		return totalcost;
	}

	public String toString()
	{
		DecimalFormat fmt = new DecimalFormat("0.00");

		String str = "Room Dimension in sqft are: " + size +
		             "\nCarpet cost per sqft is: $" + fmt.format(carpetcost) +
		             "\nTotal cost of carpet is: $" + fmt.format(getTotalCost());
		return str;
	}
}
