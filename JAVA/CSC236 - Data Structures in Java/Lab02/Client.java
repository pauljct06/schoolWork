/* Paul Collado
   CSC-236 Data Structures
   Lab 02 Client class
 */
import java.util.StringTokenizer;
import java.util.Scanner;

public class Client {

	public static void main(String[] args) {

		System.out.println("This program allows you to enter a Polynomial and manipulate it\nwith the following options:");

		String print;
		int printanswer;
		boolean exit = false;
		int arraysize = 10;
		Polynomial[] MyPolynomials = new Polynomial[arraysize];

		//initialize all the polynomials to avoid getting null pointer exception by printing an unexisting polynomial
		for(int index = 0; index < arraysize; index++) {
			MyPolynomials[index] = new Polynomial();
		}

		Scanner keyboard = new Scanner(System.in);

		//Loop to keep prompting the options until user decides to exit.
		do {
			System.out.println("\n1. Enter a polynomial" + "\n2. Print a Polynomial" + "\n3. Add two polynomials");
			System.out.println("4. Subtract two polynomials" + "\n5. Evaluate a polynomial" + "\n0. Exit the program");
			System.out.print("\nEnter the number of your choice please: ");
			printanswer = keyboard.nextInt();
			System.out.println();

			if(printanswer == 1)
				EnterPoly(MyPolynomials);

			else if(printanswer == 2)
				PrintPoly(MyPolynomials);

			else if(printanswer == 3)
				AddPoly(MyPolynomials);

			else if(printanswer == 4)
				SubPoly(MyPolynomials);

			else if(printanswer == 5)
				EvaPoly(MyPolynomials);

			else if(printanswer == 0)
				exit = true;

			else
				System.out.println("You have entered an invalid number! Please try again.");

			System.out.println("---------------------------------------------------");

			}while(!exit);
	}

	//This method prompts the user the polynomial to hold the Term and the numbers of each term to add them to the polynomial selected
	public static void EnterPoly(Polynomial[] MyPolynomials) {

		int arrayindex = 0;
		int coe = 0, expo = 0;
		String pair = ("");
		boolean exit = false;
		boolean outofbounds = false;

		Scanner keyboard = new Scanner(System.in);

		//loop to check for correct input of array index
		do{
			System.out.print("Please enter the polynomial number: ");
			arrayindex = keyboard.nextInt();
			keyboard.nextLine();
			outofbounds = false;

			if(arrayindex < 0 || arrayindex > MyPolynomials.length -1) {
				System.out.println("That polynomial number is out of bounds! Please try again.\n");
				outofbounds = true;
			}
		}while(outofbounds);


		System.out.println("\nNow enter coefficient and exponents pairs that define the polynomial number " + arrayindex);
		System.out.println("Please enter the pairs separated by a comma (x,y)");

		// loop to keep prompting the user to add polynomials until user decides to stop
		while (!exit) {

			System.out.print("\nEnter pair \"-1,-1\" to stop adding pairs to your polynomial:");
			pair = keyboard.nextLine();

			// StringTokenizer to split user answer into a a coefficient and exponent
			StringTokenizer line = new StringTokenizer(pair, ",");

			coe = Integer.parseInt(line.nextToken());
			expo = Integer.parseInt(line.nextToken());

			if(coe == -1 && expo == -1)
				exit = true;

			// try and catch to handle duplicates
			if(!exit) {

				try{
					MyPolynomials[arrayindex].addterm(coe,expo);
				}

				catch(DuplicateElementException e) {

					System.out.print(e);
				}
			}//end of if
		}//end of while
	}//end of EnterPoly method

	// This method prompts the user to enter the polynomial the wish to print
	public static void PrintPoly(Polynomial[] MyPolynomials) {

		String str;
		int polyindex;
		boolean outofbounds = false;

		Scanner keyboard =  new Scanner(System.in);

		// loop to check for correct index input
		do {
			outofbounds = false;
			System.out.print("Enter the location number of the polynomial you wish to print: ");
			polyindex = keyboard.nextInt();
			System.out.println();

			if(polyindex < 0 || polyindex > MyPolynomials.length -1) {

				System.out.println("That polynomial number is out of bounds! Please try again.\n");
				outofbounds = true;
			}
			else {

				// check if polynomial is empty or not
				str = MyPolynomials[polyindex].toString();
				if(str == "EmptyList") {

					System.out.println("There is no polynomial to print at this location");
				}

				else {

					System.out.println("Here is the polynomial at location " + polyindex + ":");
					System.out.println(MyPolynomials[polyindex]);
				}
			}//end of outer else
		 } while(outofbounds);  //end of while

	 }//end of PrintPoly method

	 // This method prompts the user to enter 3 polynomials indexes, 2 to add and 1 to hold the sum
	 public static void AddPoly(Polynomial[] MyPolynomials) {
		 int polysum1, polysum2, polysummed;
		 boolean again = false;

		 Scanner keyboard = new Scanner(System.in);

		 // loop to check the correct input of index
		 do {
			 System.out.print("Enter the number of the first polynomial to be added: ");
			 polysum1 = keyboard.nextInt();
		 	 again = false;
		 	 if(polysum1 < 0 || polysum1 > MyPolynomials.length - 1) {
				 System.out.println("That number is out of bounds! Please try again.");
		 		 again = true;
			 }
		 }while(again == true);

		 // loop to check the correct input of index
		 do {
			 System.out.print("Enter the number of the second polynomial to be added: ");
		 	 polysum2 = keyboard.nextInt();
		 	 again = false;
		 	 if(polysum2 < 0 || polysum2 > MyPolynomials.length - 1) {
		 	 	 System.out.println("That number is out of bounds! Please try again.");
		 	 	 again = true;
			 }
		 }while(again == true);

		 // loop to check the correct input of index
		 do {
			 System.out.print("Now Enter the number of the polynomial to hold the sum: ");
		 	 polysummed = keyboard.nextInt();
		 	 again = false;
		 	 if(polysummed < 0 || polysummed > MyPolynomials.length - 1) {
				 System.out.println("That number is out of bounds! Please try again.");
				 again = true;
			 }
		 }while(again == true); //end of while

		 //calling add method to do the sum of polynomials
		 MyPolynomials[polysummed] = MyPolynomials[polysum1].add(MyPolynomials[polysum2]);

		 System.out.println("\nPolynomials " + polysum1 + " and " + polysum2 + " have been added and the sum is store in polynomial " + polysummed);

	 }//end of AddPoly method

	 // This method prompts the user to enter 3 polynomials indexes, 2 to subtract and 1 to hold the subtraction
	 public static void SubPoly(Polynomial[] MyPolynomials) {

		 int polysub1, polysub2, polysubed;
		 boolean again = false;

		 Scanner keyboard = new Scanner(System.in);

		 // loop to check the correct input of index
		 do {
			 System.out.print("Enter the number of the first polynomial to be subtracted: ");
			 polysub1 = keyboard.nextInt();
		 	 again = false;
		 	 if(polysub1 < 0 || polysub1 > MyPolynomials.length - 1) {
				 System.out.println("That number is out of bounds! Please try again.");
		 		 again = true;
			 }
		 }while(again == true);

		 // loop to check the correct input of index
		 do {
			 System.out.print("Enter the number of the second polynomial to be subtracted: ");
		 	 polysub2 = keyboard.nextInt();
		 	 again = false;
		 	 if(polysub2 < 0 || polysub2 > MyPolynomials.length - 1) {
		 	 	 System.out.println("That number is out of bounds! Please try again.");
		 	 	 again = true;
			 }
		 }while(again == true);

		 // loop to check the correct input of index
		 do {
			 System.out.print("Now Enter the number of the polynomial to hold the subtraction: ");
		 	 polysubed = keyboard.nextInt();
		 	 again = false;
		 	 if(polysubed < 0 || polysubed > MyPolynomials.length - 1) {
				 System.out.println("That number is out of bounds! Please try again.");
				 again = true;
			 }
		 }while(again == true);

		 // calling the subtract method to do the subtraction of polynomials
		 MyPolynomials[polysubed] = MyPolynomials[polysub1].subtract(MyPolynomials[polysub2]);

		 System.out.println("\nPolynomials " + polysub1 + " and " + polysub2 + " have been subtracted\nand the subtraction is store in polynomial " + polysubed);

	 }// end of SubPoly method

	 // This method prompts the user the index of the polynomial to be evaluated and the value of the number at which to evaluate the polynomial
	 public static void EvaPoly(Polynomial[] MyPolynomials) {

		 int polytoeva;
		 double x;
		 boolean again = false;

		 Scanner keyboard = new Scanner(System.in);

		 // loop to check for correct index input
		 do {
			 System.out.print("Enter the number of the polynomial that you wish to evaluate: ");
			 polytoeva = keyboard.nextInt();
			 again = false;
		 	 if(polytoeva < 0 || polytoeva > MyPolynomials.length - 1) {
				 System.out.println("That number is out of bounds! Please try again.");
				 again = true;
			 }
		 }while(again == true);

		 System.out.print("Now enter the value of \"x\" at which to evaluate the polynomial: ");
		 x = keyboard.nextDouble();
		 System.out.println();

		 // calling the evaluate method to do the evaluation
		 System.out.println("Here is the evaluation of polynomial at location " + polytoeva + ":");
		 MyPolynomials[polytoeva].evaluate(x);

	 }// end of EvaPoly method
}//end of Client class