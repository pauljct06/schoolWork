import java.util.Scanner;

public class decimalTOfloat {

	public static void main(String[] args) {

		Scanner keyboard = new Scanner(System.in);
		System.out.print("Please input decimal number: ");
		String decimal = keyboard.nextLine();
		deciToFloat(decimal);									//pass string to method

		//deciToFloat("11000001000100000000000000000000")		TEST
	}


// Convert a decimal to a float
    public static void deciToFloat(String num)  {
   	 	float val = Float.parseFloat(num);						//convert string to float
        int intBits = Float.floatToIntBits(val);				//converts to int
        String answer = Integer.toBinaryString(intBits);		//converts to srting and binary
        answer = (Integer.parseInt(num) > 0) ? "0"+answer : "1"+answer; 	// adds the sign digit
        System.out.println(answer);
        System.out.println();
    }
 }

 /*

 Please input decimal number: 12
 01000001010000000000000000000000

Press any key to continue . . .

*/

