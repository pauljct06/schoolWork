import java.io.*;
//import java.util.Scanner;
public class writearraytoafile
{
	public static void main (String [] args) throws IOException
	{
		int [] any = {1,2,3};

		PrintWriter OF = new PrintWriter("Some.txt");

		for (int LCV = 0; LCV<any.length; LCV++)
		{
			OF.print(any[LCV] + " ");
		}
		OF.close();
	}
}




