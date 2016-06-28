/* Paul Collado
   CSC-236 Data Structures
   Lab 02 Polynomial class
 */
public class Polynomial {

	OrderedList<Term> mytermlist = new OrderedList<Term>();

	// adds a new Term to the list, using the add method from the OrderedList
	public void addterm(int coe,int exp) {

		Term newterm = new Term(coe,exp);
		mytermlist.add(newterm);
	}

	// sums two polynomials and puts the answer in a new Polynomial object and returns it
	public Polynomial add(Polynomial other) {

		Polynomial addedlist = new Polynomial();

		Term list1 = this.mytermlist.first();
		Term list2 = other.mytermlist.first();

		//compare until one of them reaches null
		while(list1 != null && list2 != null) {

			// if list1 is less than list2, add list1 term to the new polynomial
			if(list1.compareTo(list2) < 0) {

				addedlist.addterm(list1.coefficient, list1.exponent);
				list1 = this.mytermlist.next();
			}

			//if list1 is equal than list2, sum the terms and add it to the new polynomial
			else if(list1.compareTo(list2) == 0) {

				int newcoe = list1.coefficient + list2.coefficient;
				addedlist.addterm(newcoe,list1.exponent);
				list1 = this.mytermlist.next();
				list2 = other.mytermlist.next();
			}

			// if list1 is greater than list2, add list2 term to the new polynomial
			else if(list1.compareTo(list2) > 0) {

				addedlist.addterm(list2.coefficient, list2.exponent);
				list2 = other.mytermlist.next();
			}
		}//end of while

			//check if there were any terms left on list2, if true then add them to the new polynomial
			while(list1 == null && list2 != null) {


				addedlist.addterm(list2.coefficient, list2.exponent);
				list2 = other.mytermlist.next();
			}

			//check if there were any terms left on list1, if true then add them to the new polynomial
			while(list2 == null && list1 != null) {

				addedlist.addterm(list1.coefficient, list1.exponent);
				list1 = this.mytermlist.next();
			}

		return addedlist;
	}

	// subtracts two polynomials and puts the answer in a new Polynomial object and returns it
	// has the same procedure of the add method but instead of summing, it subtracts.
	public Polynomial subtract(Polynomial other) {

		Polynomial subtractedlist = new Polynomial();

		Term list1 = this.mytermlist.first();
		Term list2 = other.mytermlist.first();

		while(list1 != null && list2 != null) {

			if(list1.compareTo(list2) < 0) {

				subtractedlist.addterm(list1.coefficient, list1.exponent);
				list1 = this.mytermlist.next();
			}

			else if(list1.compareTo(list2) == 0) {

				int newcoe = list1.coefficient - list2.coefficient;
				subtractedlist.addterm(newcoe,list1.exponent);
				list1 = this.mytermlist.next();
				list2 = other.mytermlist.next();
			}

			else if(list1.compareTo(list2) > 0) {

				subtractedlist.addterm(list2.coefficient, list2.exponent);
				list2 = other.mytermlist.next();
			}
		}

			while(list1 == null && list2 != null) {


				subtractedlist.addterm(list2.coefficient, list2.exponent);
				list2 = other.mytermlist.next();
			}

			while(list2 == null && list1 != null) {

				subtractedlist.addterm(list1.coefficient, list1.exponent);
				list1 = this.mytermlist.next();
			}

		return subtractedlist;
	}

	// takes a double which takes the value of x so the polynomial can be evaluated
	public void evaluate(double x) {

		Term evaluatelist = mytermlist.first();
		double result = 0;


		// loop to evaluate and store the result on a variable until it reaches the end of the list
		while(evaluatelist != null) {

			result +=  (evaluatelist.coefficient * (Math.pow(x,evaluatelist.exponent)));

			evaluatelist = mytermlist.next();
		}

		// Code similar to the toString method but with the parm replacing 'x'
		//to show polynomial before being evaluated

		Term toprintevaluate = mytermlist.first();
		System.out.print(toprintevaluate.coefficient + "(" + x + ")**" + toprintevaluate.exponent);
		toprintevaluate = mytermlist.next();

		while(toprintevaluate != null) {

			if(toprintevaluate.coefficient < 0) {
				Term print = new Term(toprintevaluate.coefficient * -1, toprintevaluate.exponent);
				System.out.print(" - " + print.coefficient + "(" + x + ")**" + print.exponent);
			}
			else {
				System.out.print(" + " + toprintevaluate.coefficient + "(" + x + ")**" + toprintevaluate.exponent);
			}

			toprintevaluate = mytermlist.next();
		}

		// finally print the result after showing the polynomial
		System.out.println(" = " + result);

	}

	// toString method uses the ToString method of Term Class
	public String toString() {

		String str;

		//check if list is empty
		if (mytermlist.isEmpty())
		{
			str = "EmptyList";
		}

		else {

			//creates countlist to keep count of each Term
			Term countlist = mytermlist.first();

			//add the first term to the String str and increment the count
			str = countlist.toString();
			countlist = mytermlist.next();

			//loop adds the next term to the String str and increments countlist until the end of the list
			while(countlist != null) {

				//if coefficient is negative number, copy term to a temp term, change its sign
				//and put a - sign before the number
				//for ex: 7 + -5x becomes ---> 7 - 5x
				if(countlist.coefficient < 0) {

					Term toprint = new Term(countlist.coefficient * -1, countlist.exponent);
					str += " - " + toprint;
				}

				//if coefficient is positive just put a + sign before the number
				else {

					str += " + " + countlist;
				}

				countlist = mytermlist.next();
			}//end of while
		}// end of else

		return str;
	}//end of method
}