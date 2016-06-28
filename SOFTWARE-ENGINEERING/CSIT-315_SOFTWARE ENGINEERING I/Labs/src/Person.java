import java.util.Scanner;

public class Person {

	public String name;
	public String gender;
	public String salutation;
	
	public Person(String n, String g) {

		name = n;
		gender = g;
		if (gender.equals("M"))
		{
			salutation = "Hello Mr " + name;
			
		}
		else
		{
			salutation = "Hello Mrs " + name;
		}
	
	}	

	public String getSalutation()
	{
		return salutation;
	}	
}