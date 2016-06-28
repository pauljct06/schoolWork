// Paul Collado
// Lab 01 Part 2 Name Class
// CSC 236-01

public class Name implements Comparable {

	private String name;
	private String initial;
	private String lastname;

	public Name() {

		name = "";
		initial = "";
		lastname = "";
	}

	public Name(String n, String ini, String lstn) {

		name = n;
		initial = ini;
		lastname = lstn;
	}
	public String toString() {

		String str = name + " " + initial + " " + lastname + "\n";
		return str;
	}

	public boolean equals(Name otherName) {

		if( (this.name.equals(otherName.name)) && (this.initial.equals(otherName.initial)) && (this.lastname.equals(otherName.lastname)) )

			return true;

		else

			return false;
	}

	//THIS METHOD COMPARES TO NAMES AND RETURNS WHICH ONE IS GREATER ALPHABETICALLY
	public int compareTo(Object otherName) {

		final int LESS = -1;
		final int GREATER = 1;
		final int EQUAL = 0;

		//COMPARING LASTNAMES
		if(((Name)this).lastname.compareTo(((Name)otherName).lastname) > 0)
		{
			return GREATER;
		}

		else if(((Name)this).lastname.compareTo(((Name)otherName).lastname) < 0)
		{
			return LESS;
		}

		//COMPARING THE NAMES IN CASE THE LASTNAMES WERE EQUUAL
		else {

			if(((Name)this).name.compareTo(((Name)otherName).name) > 0)
			{
				return GREATER;
			}

			else if(((Name)this).name.compareTo(((Name)otherName).name) <0)
			{
				return LESS;
			}

			//COMPARING THE INITIAL IN CASE THE NAMES WERE ALSO EQUAL
			else {

				if(((Name)this).initial.compareTo(((Name)otherName).initial) > 0)
				{
					return GREATER;
				}

				else if(((Name)this).initial.compareTo(((Name)otherName).initial) < 0)
				{
					return LESS;
				}

				//RETURNS 0 IN CASE THE GIVEN NAMES WERE EXACTLY THE SAME
				else {
					return EQUAL;
				}
			}// END OF INITIALS COMPARISON
		}// END OF NAMES COMPARISON
	}//END OF compareTo METHOD
}
