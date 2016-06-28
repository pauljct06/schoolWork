//Paul Collado, CSC161-62
//CSC161Lab01P02

public class C161Lab01P02Collado
{
 public static void main (String[] args)
 {
  float BookQty, CSC105Book, CSC161Book;
  float TotalBookPrice;
  float TaxRate;

  BookQty = 2;                                 //Quantity of Books
  CSC105Book = 105;                            //Cost of Book for Class CSC105
  CSC161Book = 100;                            //Cost of Book for Class CSC161
  TotalBookPrice = CSC105Book + CSC161Book;    //Total Book Cost
  TaxRate = TotalBookPrice * 0.07F;             //Sales Tax of 7%

  System.out.println("Quantity of Books = " + BookQty);
  System.out.println("Cost price of first book for CSC105 Class = $" + CSC105Book);
  System.out.println("Cost price of second book for CSC161 Class = $" + CSC161Book);
  System.out.println("Total cost price of books = $" + TotalBookPrice);
  System.out.println("Total Sales tax rate = $" + TaxRate);
 }
}

//Quantity of Books = 2.0
//Cost price of first book for CSC105 Class = $105.0
//Cost price of second book for CSC161 Class = $100.0
//Total cost price of books = $205.0
//Total Sales tax rate = $14.35

