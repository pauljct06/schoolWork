import java.util.Scanner;
import java.io.PrintWriter;

public class Client {
	public static void main(String[] args) {

		System.out.println("This program will print how a BST enterd by the user would look like.\n");

		int pagewidth = 64;
		int num = 0;
		int count = 1;

		BST<Integer> mytree = new BST<Integer> ();
		Scanner keyboard = new Scanner(System.in);

		System.out.println("First enter the numbers to be added to the BST, enter 0 to stop adding numbers.\n");

		do {
			System.out.print("Enter number " + count + " : ");
        	num = keyboard.nextInt();
        	if(num != 0)
        		mytree.insert(num);

			count++;
			}while(num != 0);


		PrintWriter Screen = new PrintWriter(System.out,true);

		System.out.println("\nThis is how your BST may look like:\n");

		mytree.printTree(Screen,pagewidth);

		Screen.println();
		System.out.println();

	}
}