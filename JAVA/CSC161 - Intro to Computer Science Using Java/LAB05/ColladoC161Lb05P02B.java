import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P02B
public class ColladoC161Lb05P02B
{
 public static void main(String[] args)
 {
  int energy, water, finalTemp, initialTemp, increment = 20;
  int LCV = 1;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);

  while (LCV <= 3)
  {
  System.out.printf("Water in Kg %d: ", LCV);
  water = keyboard.nextInt();
  System.out.printf("Initial temperature %d: ", LCV);
  initialTemp = keyboard.nextInt();
  System.out.printf("Final temperature %d: ", LCV);
  finalTemp = keyboard.nextInt();

  energy = water * (finalTemp - initialTemp) * 4184;

  System.out.printf("Energy = %dKg * (%ddeg - %ddeg) * 4184)\n",water, finalTemp, initialTemp);
  System.out.printf("then energy is = %d joules\n\n",energy);
  LCV++;
  }
 }
}
/*
Given the following values:
Water in Kg 1: 50
Initial temperature 1: 15
Final temperature 1: 30
Energy = 50Kg * (30deg - 15deg) * 4184)
then energy is = 3138000 joules

Water in Kg 2: 70
Initial temperature 2: 25
Final temperature 2: 38
Energy = 70Kg * (38deg - 25deg) * 4184)
then energy is = 3807440 joules

Water in Kg 3: 30
Initial temperature 3: 5
Final temperature 3: 15
Energy = 30Kg * (15deg - 5deg) * 4184)
then energy is = 1255200 joules
*/