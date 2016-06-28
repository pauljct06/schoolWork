// Paul Collado
// Lab 01 Part 2 Client Class
// CSC 236-01

import java.util.StringTokenizer;
import java.util.Scanner;
import java.io.*;
import java.util.NoSuchElementException;

public class Client {

	//MAIN READS THE FILE DIVIDES THE WORDS PASS THEM INTO THE ARRAY, THEN CALLS MERGESORT AND FINALLY PRINTS THE SORTED ARRAY
	public static void main(String[] args) throws IOException
	{
		System.out.println("This programs reads a file of names and sorts them alphabetically.\n");

		Comparable[] dummyarray = new Comparable[100];

		Scanner keyboard = new Scanner(System.in);
		String filename;

		StringTokenizer lineToTokenize;
		String name, initial, lastname;

		System.out.print("Please enter the name of the file to be read: ");
		filename = keyboard.nextLine();

	// READING THE FILE

		FileReader freader = new FileReader(filename);
		BufferedReader infile = new BufferedReader(freader);

	// READING EACH LINE AT A TIME
		String oneLine = infile.readLine();

		int index = 0; //dummyarray INDEX COUNT

	// THIS LOOP TOKENIZES A LINE AND PASSES IT TO THE ARRAY UNTIL THERE ARE NO MORE LINES
		while(oneLine != null) {

			lineToTokenize = new StringTokenizer(oneLine);

			try {
				name = lineToTokenize.nextToken();
				initial = lineToTokenize.nextToken();
				lastname = lineToTokenize.nextToken();
				dummyarray[index] = new Name(name,initial,lastname);  //FILLING THE dummyarray WITH ELEMENTS THAT WERE TOKENIZED
			}

			catch (NoSuchElementException e) { }

			oneLine = infile.readLine();

		index++;
		}//END OF WHILE LOOP

		infile.close();

		Comparable myarray[] = new Comparable[index-1];  // CREATING A NEW ARRAY TO HOLD ALL THE ELEMENTS THAT ARE BEING USED
		System.arraycopy(dummyarray,0,myarray,0,myarray.length);  //COPYING dummyarray TO myarray

		Sort.mergesort(myarray);	// CALLING MERGESORT TO SORT THE ARRAY

		System.out.println("\nSorted names:\n------------------------------");

		for(int i = 0; i<myarray.length; i++)
		{
			System.out.println(myarray[i]);
		}

		System.exit(0);
	}//END OF MAIN
}