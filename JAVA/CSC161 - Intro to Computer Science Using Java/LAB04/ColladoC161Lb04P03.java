import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb04P03
public class ColladoC161Lb04P03
{
 public static void main(String[] args)
 {
  boolean OkToSpray;
  int Temperature, Humidity, WindSpeed;

  System.out.println("WEATHER CONDITIONS:");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("Current Temperature: ");
  Temperature = keyboard.nextInt();
  System.out.print("Relative Humidity: ");
  Humidity = keyboard.nextInt();
  System.out.print("Current Wind Speed: ");
  WindSpeed = keyboard.nextInt();

  if ((Temperature >= 70) && (Humidity >=15 && Humidity <= 36) && (WindSpeed <= 10))
  {
     OkToSpray = true;
  }

  else
  {
     OkToSpray = false;
  }

  System.out.println("\nGiven the following weather conditions:");
  System.out.println("Temperature: " + Temperature + " degrees");
  System.out.println("Humidity: " + Humidity + "%");
  System.out.println("WindSpeed: " + WindSpeed + "Mph");
  System.out.println("Ok to spray: " + OkToSpray);
 }
}

/*
WEATHER CONDITIONS:
Current Temperature: 65
Relative Humidity: 14
Current Wind Speed: 11

Given the following weather conditions:
Temperature: 65 degrees
Humidity: 14%
WindSpeed: 11Mph
Ok to spray: false



WEATHER CONDITIONS:
Current Temperature: 80
Relative Humidity: 36
Current Wind Speed: 5

Given the following weather conditions:
Temperature: 80 degrees
Humidity: 36%
WindSpeed: 5Mph
Ok to spray: true
*/