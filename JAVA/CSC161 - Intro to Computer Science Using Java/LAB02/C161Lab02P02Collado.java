 import java.util.Scanner;
import javax.swing.JOptionPane;
public class C161Lab02P02Collado
{
 public static void main (String[] args)
 {
  float Surveyed;
  float EnergyDrink,CitrusFlavor;
  float TotalEnergyDrinkers, TotalCitrusFlavor;


  Scanner keyboard = new Scanner(System.in); //input scanner method
  System.out.print("Amount of people surveyed:");
  Surveyed = keyboard.nextFloat(); // input the amount of people surveyed
  System.out.print("Percentage of energy drinks buyers:");
  EnergyDrink = keyboard.nextFloat(); // input the percentage of people who buys energy drinks
  System.out.print("Percentage of energy drinks buyers who prefer citrus flavor:");
  CitrusFlavor = keyboard.nextFloat(); // input the percentage of people who like citrus flavor

  TotalEnergyDrinkers = (Surveyed * (EnergyDrink / 100)); // calculates the amount of people surveyed who liked energy drinks
  System.out.println("\nAmount of people who purchased energy drinks: " + Math.round(TotalEnergyDrinkers));
  TotalCitrusFlavor = (TotalEnergyDrinkers * (CitrusFlavor / 100)); // calculates the amount of energy drinkers who liked citrus flavor
  System.out.println("Amount of people who prefer citrus flavored energy drinks: " + Math.round(TotalCitrusFlavor));

  JOptionPane.showMessageDialog(null, "Amount of people who purchased energy drinks " + Math.round(TotalEnergyDrinkers)); //shows the amount of people who purchase energy drinks in a message box
  JOptionPane.showMessageDialog(null, "Amount of people who prefer citrus flavored energy drinks " + Math.round(TotalCitrusFlavor)); // shows the amount of people who liked citrus flavor in a message box
 }
}
/*Amount of people surveyed:12467
Percentage of energy drinks buyers:14
Percentage of energy drinks buyers who prefer citrus flavor:64

Amount of people who purchased energy drinks: 1745
Amount of people who prefer citrus flavored energy drinks: 1117
*/