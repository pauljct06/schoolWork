import java.util.Scanner;
import java.math.BigInteger;

public class floatTOdecimal {
	public static void main(String[] args) {

		Scanner keyboard = new Scanner(System.in);
		System.out.print("Please input your 32bit float number: ");
		String floating = keyboard.nextLine();
		floatToDeci(floating);								//psss string to method


		//floatToDeci("11000001000100000000000000000000");		TEST
	}

// Convert a float to a decimal
	public static void floatToDeci(String fullbinary) {			//takes a string

		String binary = fullbinary.substring(1, fullbinary.length()); 		//converts it binary without sign (because funtion does not take 32bit binary)
		int intBits = Integer.parseInt(binary, 2);			//converts it to regular int
        float answer = Float.intBitsToFloat(intBits);		//converts it to float number

        if (fullbinary.substring(0,1).equals("1"))			//Test to add the negative sign
        System.out.print("-");

		System.out.println(answer);
		System.out.println();
	}
}
/*

Please input your 32bit float number: 11000001000100000000000000000000
-9.0

Press any key to continue . . .

Please input your 32bit float number: 01000001111110000000000000000000
31.0

Press any key to continue . . .

Please input your 32bit float number: 01000001111100000000000000000000
30.0

Press any key to continue . . .


Please input your 32bit float number: 01000001101110000000000000000000
23.0

Press any key to continue . . .

Please input your 32bit float number: 01000001101100000000000000000000
22.0

Press any key to continue . . .


*/