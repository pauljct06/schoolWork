//filename:CircleClass
//Paul Collado
//CSC-162 Lab 2 Page 359 #7

public class CircleClass
{
 	private double radius;
 	private final double PI = 3.14159;

 public CircleClass()
 {
  	radius = 0.0;
 }

 public CircleClass(double r)
 {
    radius = r;
 }

 public void setRadius(double r)
 {
    radius = r;
 }

 public double getRadius()
 {
    return radius;
 }

 public double getArea()
 {
    double area;
    area = PI * radius * radius;
    return area;
 }

 public double getDiameter()
 {
    double diameter;
    diameter = radius * 2;
    return diameter;
 }

 public double getCircumference()
 {
    double circumf;
    circumf = 2 * PI * radius;
    return circumf;
 }
}