public class SelectionSortBothSides
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
	 SelectionSort(myarray,n);

	 for (int index=0; index<myarray.length; index++)
	 {
		 System.out.print(myarray[index] + " ");
	 }

	 System.out.println();



 }
 public static void SelectionSort(int[] arr, int n)
 {
   // last = index of the last item in the subarray of items yet
   // to be sorted,
   // l = index of the largest item found
   // first = index of the first item in the subarray of items yet
   // to be sorted,
   // f = index of the first item found

        int last, l, templ;
        int first, f, tempf;

        for(last = n-1, first = 0; last >= first; --last, ++first)
        {
        // select largest item in arr[first..last]
            l = indexOfLargest(arr, first, last+1);
        // swap largest item arr[l] with arr[last]
            templ = arr[l];
            arr[l] = arr[last];
            arr[last] = templ;

            // select smallest item in arr[first..last]
            f = indexOfSmallest(arr, first, last+1);
            // swap smallest item arr[f] with arr[first]
            tempf = arr[f];
            arr[f] = arr[first];
            arr[first] = tempf;
        }  // end of for loop
 }

 public static int indexOfLargest(int[] arr, int start, int size)
 {
        int indexSoFar = start;  // index of largest item found so far
        int currIndex;
        //System.out.println("size is: " + size);
        for (currIndex = start+1; currIndex < size; ++currIndex)
        {
            //System.out.println(currIndex);
            if (arr[currIndex] > arr[indexSoFar])
               indexSoFar = currIndex;
        }

        /*for (int index=start; index<size; ++index)
		{
			System.out.print(arr[index] + " ");
	 	}
        System.out.println("max is: " + indexSoFar);
		*/
        return indexSoFar;  // index of largest item
 }
 public static int indexOfSmallest(int[] arr, int start, int size)
 {
        int indexSoFar = start;  // index of Smallest item found so far
        int currIndex;
        for (currIndex = start+1; currIndex < size; ++currIndex)
        {
        //    System.out.println(currIndex);
            if (arr[currIndex] < arr[indexSoFar])
               indexSoFar = currIndex;
        }

	   	/*for (int index=start; index<size; ++index)
		{
			 System.out.print(arr[index] + " ");
	 	}
        System.out.println("min is: " + indexSoFar);
		*/
        return indexSoFar;  // index of Smallest item
 }

}
