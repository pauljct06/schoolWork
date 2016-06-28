public class TwoDimensionArrays
{
	public static void main (String [] args)
	{
		int [][]B = {{1,2,3},
					 {4,5,6},
					 {7,8,9},
					 {10,11,12}};

		int total;

        for(int LCVrows = 0; LCVrows<B.length; LCVrows++)
        {
			total = 0;
			//System.out.println(B[0].length);

			for( int LCVcols=0; LCVcols<B[0].length; LCVcols++)
			{
				System.out.print(B[LCVrows][LCVcols] + "" );


				//total = total + B[LCVrows][LCVcols];
				//System.out.println("total of row" + LCVrows + " is " + total);

			}
			//System.out.println("total of cols" + LCVcols + " is " + total);


		}
	}
}
/*
1
2
3
4
5
6
7
8
9
10
11
12
*/

