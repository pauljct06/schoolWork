import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P02A
public class ColladoC161Lb05P02A
{
 public static void main(String[] args)
 {
  int energy, water, finalTemp, initialTemp, increment = 20;
  int LCV;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);

  for (LCV=1;LCV <=3; LCV++)
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
  }

 }
}
/*
Given the following values:
Water in Kg 1: 50
Initial temperature 1: 40
Final temperature 1: 45
Energy = 50Kg * (45deg - 40deg) * 4184)
then energy is = 1046000 joules
Water in Kg 2: 46
Initial temperature 2: 25
Final temperature 2: 32
Energy = 46Kg * (32deg - 25deg) * 4184)
then energy is = 1347248 joules
Water in Kg 3: 19
Initial temperature 3: 15
Final temperature 3: 18
Energy = 19Kg * (18deg - 15deg) * 4184)
then energy is = 238488 joules
*/