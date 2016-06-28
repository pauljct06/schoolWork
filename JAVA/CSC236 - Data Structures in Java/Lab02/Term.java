/* Paul Collado
   CSC-236 Data Structures
   Lab 02 Term class
 */

public class Term implements Comparable<Term> {

	int coefficient;
	int exponent;

	// Default constructor initializes both field to 0
	public Term() {

		coefficient = 0;
		exponent = 0;
	}

	// Constructor to initialize coefficient and exponent
	public Term(int coef, int expo) {

		coefficient = coef;
		exponent =  expo;
	}

	// Compare method compares the exponents of to Terms and returns whether they are less, greater or equal
	public int compareTo(Term otherTerm) {

		final int LESS = -1;
		final int GREATER = 1;
		final int EQUAL = 0;

		if(this.exponent > otherTerm.exponent)
			return GREATER;

		else if(this.exponent < otherTerm.exponent)
			return LESS;

		else
			return EQUAL;
	}

	public String toString() {

		String str = coefficient + "x**" + exponent;

		return str;
	}



}

