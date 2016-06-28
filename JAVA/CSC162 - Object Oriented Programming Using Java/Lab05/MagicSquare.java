//filename: MagicSquare.java
//Paul Collado
//CSC-162 Lab 5 MagicSquare

import java.util.Scanner;

public class MagicSquare
{
 public static void main(String[] args)
 {
	 System.out.print("Filename: MagicSquare.java \nPaul Collado");
	 System.out.println("\nCSC-162 Lab 5 MagicSquare\n");

	 int N;
	 String answer;
	 char repeat;

	 System.out.println("This program generates a \"Magic Square\"");

	 do
	 {
		Scanner keyboard = new Scanner(System.in);
	 	System.out.print("Enter the value of N: ");
	 	N = keyboard.nextInt();
	 	keyboard.nextLine();

	 	int[][] myarray = new int[N][N];

	 	int startcol;
	 	startcol = N / 2;

	 	FillMagicSquare(myarray, N, 0, startcol, 1);


	 	System.out.println("When N is " + N + ", this is my MagicSquare: \n");

	 	for(int rowindex = 0; rowindex < N; rowindex++)  // LOOP TO PRINT ARRAY
	 	{
			 System.out.print("\t");
			 for(int colindex = 0; colindex < N; colindex++)
			 {
				 System.out.print(myarray[rowindex][colindex] + "   ");
			 }
			 System.out.println();
	 	}
	 	System.out.println();
	 	System.out.println("Do you want to run this program again?");
	 	System.out.print("Enter Y for yes, else enter any other key: ");
	 	answer = keyboard.nextLine();
	 	repeat = answer.charAt(0);
	 	System.out.println();

	  }while(repeat == 'y' || repeat == 'Y');

	  System.out.println();

 }

 public static void FillMagicSquare(int[][]array, int n, int row, int col,int nuntofill)
 {
	 int newrow;
	 int newcol;

	 if(nuntofill > Math.pow(n,2))
	 {
		 System.out.println();
	 }
	 else
	 {
		 array[row][col] = nuntofill;

		 if(row == 0)
		 {
			 newrow = n - 1; // TILING THE PLANE
		 }
		 else
		 {
			 newrow = row - 1;
		 }

		 if(col == 0)
		 {
			 newcol = n - 1;  // TILING THE PLANE
		 }
		 else
		 {
			 newcol = col - 1;
		 }

		 if(array[newrow][newcol] > 0)  // TESTING TO SEE IF NEW BOX IS ALREADY OCCUPIED
		 {
			 newrow = row + 1;
			 newcol = col;
		 }

		 FillMagicSquare(array,n,newrow,newcol, nuntofill + 1);
	 }
 }
}

/*
Filename: MagicSquare.java
Paul Collado
CSC-162 Lab 5 MagicSquare

This program generates a "Magic Square"
Enter the value of N: 5

When N is 5, this is my MagicSquare:

        15   8   1   24   17
        16   14   7   5   23
        22   20   13   6   4
        3   21   19   12   10
        9   2   25   18   11

Do you want to run this program again?
Enter Y for yes, else enter any other key: y

Enter the value of N: 7

When N is 7, this is my MagicSquare:

        28   19   10   1   48   39   30
        29   27   18   9   7   47   38
        37   35   26   17   8   6   46
        45   36   34   25   16   14   5
        4   44   42   33   24   15   13
        12   3   43   41   32   23   21
        20   11   2   49   40   31   22

Do you want to run this program again?
Enter Y for yes, else enter any other key: y

Enter the value of N: 9

When N is 9, this is my MagicSquare:

        45   34   23   12   1   80   69   58   47
        46   44   33   22   11   9   79   68   57
        56   54   43   32   21   10   8   78   67
        66   55   53   42   31   20   18   7   77
        76   65   63   52   41   30   19   17   6
        5   75   64   62   51   40   29   27   16
        15   4   74   72   61   50   39   28   26
        25   14   3   73   71   60   49   38   36
        35   24   13   2   81   70   59   48   37

Do you want to run this program again?
Enter Y for yes, else enter any other key: y

Enter the value of N: 11

When N is 11, this is my MagicSquare:

        66   53   40   27   14   1   120   107   94   81   68
        67   65   52   39   26   13   11   119   106   93   80
        79   77   64   51   38   25   12   10   118   105   92
        91   78   76   63   50   37   24   22   9   117   104
        103   90   88   75   62   49   36   23   21   8   116
        115   102   89   87   74   61   48   35   33   20   7
        6   114   101   99   86   73   60   47   34   32   19
        18   5   113   100   98   85   72   59   46   44   31
        30   17   4   112   110   97   84   71   58   45   43
        42   29   16   3   111   109   96   83   70   57   55
        54   41   28   15   2   121   108   95   82   69   56

Do you want to run this program again?
Enter Y for yes, else enter any other key: n


Press any key to continue . . .
*/