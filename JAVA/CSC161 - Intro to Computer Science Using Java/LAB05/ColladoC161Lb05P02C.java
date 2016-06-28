import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P02C
public class ColladoC161Lb05P02C
{
 public static void main(String[] args)
 {
  int energy, water, finalTemp, initialTemp, increment = 20;
  int LCV = 1;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);

  do
  {
  System.out.printf("Water in Kg %d: ", LCV);
  water = keyboard.nextInt();
  System.out.printf("Initial temperature %d: ", LCV);
  initialTemp = keyboard.nextInt();
  System.out.printf("Final temperature %d: ", LCV);
  finalTemp = keyboard.nextInt();

  energy = water * (finalTemp - initialTemp) * 4184;

  System.out.printf("Energy = %dKg * (%ddeg - %ddeg) * 4184)\n",water, finalTemp, initialTemp);
  System.out.printf("then energy is = %d joules\n",energy);
  LCV++;
  }
  while (LCV <= 3);
 }
}
/*
Given the following values:
Water in Kg 1: 10
Initial temperature 1: 2
Final temperature 1: 8
Energy = 10Kg * (8deg - 2deg) * 4184)
then energy is = 251040 joules
Water in Kg 2: 30
Initial temperature 2: 15
Final temperature 2: 30
Energy = 30Kg * (30deg - 15deg) * 4184)
then energy is = 1882800 joules
Water in Kg 3: 35
Initial temperature 3: 28
Final temperature 3: 37
Energy = 35Kg * (37deg - 28deg) * 4184)
then energy is = 1317960 joules
*/