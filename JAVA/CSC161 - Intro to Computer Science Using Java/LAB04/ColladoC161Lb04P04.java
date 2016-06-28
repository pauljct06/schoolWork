import java.util.Scanner;
//Paul Collado, CSC161-62
//C161Lb04P03
public class ColladoC161Lb04P04
{
 public static void main(String[] args)
 {
  String name1, name2, name3, a, b, c;

  System.out.println("Given the following names:");
  Scanner keyboard = new Scanner(System.in);
  System.out.print("First name: ");
  name1 = keyboard.nextLine();
  System.out.print("Second name: ");
  name2 = keyboard.nextLine();
  System.out.print("Third name: ");
  name3 = keyboard.nextLine();

  a= name1;
  b= name2;
  c= name3;
  if(name1.compareTo(name2) < 0 && name1.compareTo(name3) < 0 && name2.compareTo(name3) < 0)
  {
    a = name1;
    b = name2;
    c = name3;
  }
  else if(name2.compareTo(name1) < 0 && name2.compareTo(name3) < 0 && name1.compareTo(name3) < 0)
  {
     a = name2;
     b = name1;
     c = name3;
  }
  else if(name3.compareTo(name1) < 0 && name3.compareTo(name2) < 0 && name1.compareTo(name2) < 0)
  {
     a = name3;
     b = name1;
     c = name2;
  }
  else if(name1.compareTo(name2) < 0 && name1.compareTo(name3) < 0 && name3.compareTo(name2) < 0)
  {
     a = name1;
     b = name3;
     c = name2;
  }
  else if(name2.compareTo(name1) < 0 && name2.compareTo(name3) < 0 && name3.compareTo(name1) < 0)
  {
     a = name2;
     b = name3;
     c = name1;
  }
  else if(name3.compareTo(name1) < 0 && name3.compareTo(name2) < 0 && name2.compareTo(name1) < 0)
  {
     a = name3;
     b = name2;
     c = name1;
  }
  System.out.println("\nSorting the names alphabetically:");
  System.out.println(a);
  System.out.println(b);
  System.out.println(c);
 }
}
/*
Given the following names:
First name: Andy
Second name: Charlie
Third name: Leslie

Sorting the names alphabetically:
Andy
Charlie
Leslie

Given the following names:
First name: Charlie
Second name: Andy
Third name: Leslie

Sorting the names alphabetically:
Andy
Charlie
Leslie

Given the following names:
First name: Leslie
Second name: Andy
Third name: Charlie

Sorting the names alphabetically:
Andy
Charlie
Leslie

Given the following names:
First name: Andy
Second name: Leslie
Third name: Charlie

Sorting the names alphabetically:
Andy
Charlie
Leslie

Given the following names:
First name: Charlie
Second name: Leslie
Third name: Andy

Sorting the names alphabetically:
Andy
Charlie
Leslie

Given the following names:
First name: Leslie
Second name: Charlie
Third name: Andy

Sorting the names alphabetically:
Andy
Charlie
Leslie
*/