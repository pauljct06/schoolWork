//filename:Area.java
//Paul Collado
//CSC-162 Lab 3 Page 597 #1

import java.lang.Math;
public class Area
{
 public static double getArea(double c)
 {
 	double AreaCircle;
 	AreaCircle = (Math.PI) * (Math.pow(c,2));

 	return AreaCircle;
 }
 public static double getArea(double w, double l)
 {
 	double AreaRectangle;
 	AreaRectangle = w * l;

 	return AreaRectangle;
 }

 public static double getArea(double r1, double r2, double h)
 {
	 double AreaCylinder;
	 AreaCylinder = (Math.PI)* r1 * r2 * h;

	 return AreaCylinder;
 }
}

