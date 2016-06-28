import java.math.BigInteger;

public class main {
	public static void main(String[] args) {
		floatToDeci("01000000101000000000000000000000");
		deciToFloat("5");
		binaryToHex("10011011");
		hexToBinary("9b");
	}
	
	// Convert a decimal to a float
	public static void floatToDeci(String binary) {
		binary = binary.substring(1, binary.length());
		int intBits = Integer.parseInt(binary, 2);
        float answer = Float.intBitsToFloat(intBits);
        System.out.println(answer);
	}
	
    // Convert a decimal to a float
    public static void deciToFloat(String num)  {
   	 	float val = Float.parseFloat(num);
        int intBits = Float.floatToIntBits(val); 
        String answer = Integer.toBinaryString(intBits);
        answer = (Integer.parseInt(num) > 0) ? "0"+answer : "1"+answer;
        System.out.println(answer);
    }
    
    // Convert a binary to a hex string
    public static void binaryToHex(String bin) {
    	String answer = Long.toHexString(Long.parseLong(bin, 2));
    	System.out.println(answer);
    }
    
    // Convert a hex to a binary string
    public static void hexToBinary(String hex) {
    	String answer = new BigInteger(hex, 16).toString(2);
    	System.out.println(answer);
    }
}