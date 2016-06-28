import java.util.Scanner;
import java.math.BigInteger;

public class binaryTOhex {
	public static void main(String[] args) {
		Scanner keyboard = new Scanner(System.in);
		System.out.print("Please input binary number: ");
		String binary = keyboard.nextLine();
		binaryToHex(binary);								//pass string to method


		//binaryToHex("10011011");   TEST

	}

	// Convert a binary to a hex string
	    public static void binaryToHex(String bin) {
	    	String answer = Long.toHexString(Long.parseLong(bin, 2));		//converts to Long
	    	System.out.println(answer);										//converts to Hex
	    	System.out.println();
    	}

}
/*

Please input binary number: 10011011
9b
Press any key to continue . . .

*/