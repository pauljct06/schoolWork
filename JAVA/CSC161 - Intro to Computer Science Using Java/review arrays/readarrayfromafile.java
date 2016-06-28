import java.io.*;
import java.util.Scanner;
public class readarrayfromafile
{
	public static void main (String [] args) throws IOException
	{
		int LCV=0;
		int [] any = new int [3];

		File file =  new File ("some.txt");
		Scanner IF = new Scanner (file);

		while(IF.hasNext() && LCV < any.length)
		{
			any[LCV] = IF.nextInt();
		    System.out.println(any[LCV]);
		}
		LCV++;
		IF.close();
	}
}
/*
1
2
3
*/