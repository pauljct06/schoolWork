import java.util.Scanner;
import javax.swing.JOptionPane;
import java.math.*;
public class C161Lab02P01Collado
{
 public static void main (String[] args)
 {
  int Sharesbought, SharesSold;
  double SharePrice, StockBroker, StockPriceSell;
  double SharePriceSell;
  double TotalStockPrice, TotalCommision, TotalStockSellPrice, TotalSellCommision, Profit;


  System.out.println("Name: Joe"); //Name of the Dealer
  Scanner keyboard = new Scanner(System.in); //input scanner method
  System.out.print("Shares bought:");
  Sharesbought = keyboard.nextInt(); //input the quantity of shares bought
  System.out.print("Price per share:");
  SharePrice = keyboard.nextDouble(); // input the Price for each share bought
  System.out.print("StockBroker commission percentage:");
  StockBroker = keyboard.nextDouble(); //input the percentage paid to the StockBroker

  SharesSold = Integer.parseInt(JOptionPane.showInputDialog("Shares sold: ")); //Input box for the quantity of shares sold
  System.out.println("\nShares sold: " + SharesSold);
  SharePriceSell = Double.parseDouble(JOptionPane.showInputDialog("Price per share: ")); //Input box for Price for each Share sold
  System.out.println("Sell price per share " + SharePriceSell);
  StockPriceSell = Double.parseDouble(JOptionPane.showInputDialog("StockBroker commission percentage: ")); //Input box for the percentage paid to the StockBroker
  System.out.println("StockBroker commission percentage: " + StockPriceSell);

  TotalStockPrice = (Sharesbought * SharePrice); //Calculate the Total amount paid for the stocks bought
  System.out.println("\nAmount paid for the stock purchase: $" + TotalStockPrice);
  TotalCommision = (TotalStockPrice * (StockBroker / 100)); //Calculate the commision for paid the stocks bought
  System.out.println("Amount of commision paid to broker for purchase: $" + TotalCommision);
  TotalStockSellPrice = (SharesSold * SharePriceSell); //Calculate the total amount paid for the stocks sold
  System.out.println("Amount received for the stock sell: $" + TotalStockSellPrice);
  TotalSellCommision = (TotalStockSellPrice * (StockPriceSell / 100)); //Calculate the commision paid for the stock sold
  System.out.println("Amount of commision paid to broker for sell: $" + TotalSellCommision);
  Profit = (((TotalStockSellPrice - TotalSellCommision) - (TotalStockPrice + TotalCommision))); //Calculate the total profit

  BigDecimal profit = new BigDecimal(Profit);
  profit = profit.setScale(2,BigDecimal.ROUND_HALF_UP); //formula to round up the number to two decimal places
  System.out.println("Amount of profit: $" + profit);
 }
}

/*
Name: Joe
Shares bought:1000
Price per share:32.87
StockBroker commission percentage:2

Shares sold: 1000
Sell price per share 33.92
StockBroker commission percentage: 2.0

Amount paid for the stock purchase: $32870.0
Amount of commision paid to broker for purchase: $657.4
Amount received for the stock sell: $33920.0
Amount of commision paid to broker for sell: $678.4
Amount of profit: $-285.80
*/

