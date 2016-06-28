import java.util.Scanner;
import java.math.BigInteger;

public class hexTObinary {
	public static void main(String[] args) {
		Scanner keyboard = new Scanner(System.in);
		System.out.print("Please input hexadecimal number: ");
		String hex = keyboard.nextLine();
		hexToBinary(hex);						// pass string to method

		//hexToBinary("9b");     TEST
	}

	// Convert a hex to a binary string
	    public static void hexToBinary(String hex) {
	    	String answer = new BigInteger(hex, 16).toString(2);		//converts to integer and makes it to base 2 (binary)
	    	System.out.println(answer);
	    	System.out.println();
    	}
}

/*

Please input hexadecimal number: 9b
10011011

Press any key to continue . . .

*/