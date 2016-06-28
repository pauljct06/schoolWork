import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb05P02
public class ColladoC161Lb05P02
{
 public static void main(String[] args)
 {
  int energy, water, finalTemp, initialTemp;

  System.out.println("Given the following values:");
  Scanner keyboard = new Scanner(System.in);
  System.out.printf("Water in Kg: ");
  water = keyboard.nextInt();
  System.out.printf("Initial temperature: ");
  initialTemp = keyboard.nextInt();
  System.out.printf("Final temperature: ");
  finalTemp = keyboard.nextInt();

  energy = water * (finalTemp - initialTemp) * 4184;

  System.out.printf("Energy = %dKg * (%ddeg - %ddeg) * 4184)\n",water, finalTemp, initialTemp);
  System.out.printf("then energy is = %d joules\n",energy);
 }
}
/*
Given the following values:
Water in Kg: 20
Initial temperature: 15
Final temperature: 30
Energy = 20Kg * (30deg - 15deg) * 4184)
then energy is = 1255200 joules
*/