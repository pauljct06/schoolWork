public class BubbleSortDemo
{
 public static void main(String [] args)
 {
	 int [] myarray = {30,40,70,10,50,60};
	 int n = myarray.length;

	 for (int index=0; index<myarray.length; index++)
	 {
	 		 System.out.print(myarray[index] + " ");
	 }

	 System.out.println();
	 bubbleSort(myarray);

	 for (int index=0; index<myarray.length; index++)
	 {
		 System.out.print(myarray[index] + " ");
	 }

	 System.out.println();
 }
 public static void bubbleSort(int[] list)
 {
    	boolean needNextPass = true;
    	int k = 1;
    	int i = 0;

    	while ( k < list.length && needNextPass)
    	{
			// Array may be sorted and next pass not needed
     		needNextPass = false;
      		while ( i < list.length - k)
      		{
				if (list[i] > list[i + 1])
				{
					// Swap list[i] with list[i + 1]
         			int temp = list[i];
         		 	list[i] = list[i + 1];
          			list[i + 1] = temp;

       				needNextPass = true; // Next pass still needed
        		}  // end if
        		++i;
      		}   // end inner while
      		++k;
			i = 0;
   	 	} // end outer while
  }

}
