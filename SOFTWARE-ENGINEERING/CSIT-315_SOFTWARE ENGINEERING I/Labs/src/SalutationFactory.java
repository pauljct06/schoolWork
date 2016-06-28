import java.util.Scanner;

public class SalutationFactory {

public static void main(String[] args)	
{


String name;
String gender;

Scanner keyboard = new Scanner(System.in);


System.out.print("Enter your name: ");

name = keyboard.nextLine();


System.out.print("Enter your gender: ");

gender = keyboard.nextLine();
keyboard.close();

Person person1;

if (gender.equals("Male"))
{
	person1 = new Male(name, "M");
}

else
{
	person1 = new Female(name, "F");

}
	
System.out.println(person1.getSalutation());
}

	
}
