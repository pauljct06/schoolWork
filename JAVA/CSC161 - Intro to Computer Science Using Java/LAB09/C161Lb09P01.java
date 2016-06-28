import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb09P01
public class C161Lb09P01
{
 public static void main(String args[])
 {
  final double G = 9.8;
  double D;
  int stime;
  double time;

  for(stime = 1; stime<=10; stime++)
  {
  System.out.println("To determine the distance an object falls in an specific period of time:");
  //Scanner keyboard = new Scanner (System.in);
  System.out.print("Please input the objects fallin time in seconds: ");
  //stime = keyboard.nextInt();
  System.out.println(stime);

  time = FallingDistance(G,stime);

  System.out.printf("Distance is %3.2f meters.\n\n", time);

 }
 }
 public static double FallingDistance(final double G, int stime)
 {
 double distance;

 distance = 0.5*G*(Math.pow(stime,2));
 return distance;
 }
}

/*
To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 1
Distance is 4.90 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 2
Distance is 19.60 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 3
Distance is 44.10 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 4
Distance is 78.40 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 5
Distance is 122.50 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 6
Distance is 176.40 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 7
Distance is 240.10 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 8
Distance is 313.60 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 9
Distance is 396.90 meters.

To determine the distance an object falls in an specific period of time:
Please input the objects fallin time in seconds: 10
Distance is 490.00 meters.
*/

