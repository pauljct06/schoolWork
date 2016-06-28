//filename: RoomDimension.java
//Paul Collado
//CSC-162 Lab 3 Page 598 #3

import java.text.DecimalFormat;

public class RoomDimension
{
	private double width;
	private double length;

	public RoomDimension() //NO ARG-CONSTRUCTOR
	{
		width = 0.0;
		length = 0.0;
	}

	public RoomDimension(double w, double len) //CONSTRUCTOR
	{
		width = w;
		length = len;
	}

	public RoomDimension(RoomDimension copy) //COPY CONSTRUCTOR
	{
		width = copy.width;
		length = copy.length;
	}

	public void setAll(double w, double len)
	{
		width = w;
		length = len;
	}

	public double getArea()
	{
		double Area;
		Area = width * length;

		return Area;
	}

	public String toString()
	{
		DecimalFormat fmt = new DecimalFormat("0.00");

		String str = "\nWidth is: " + width + "ft" +
					 "\nLength is:  " + length + "ft" +
					 "\nArea of the room is: " + fmt.format(getArea()) + "sqft";
		return str;
	}
}