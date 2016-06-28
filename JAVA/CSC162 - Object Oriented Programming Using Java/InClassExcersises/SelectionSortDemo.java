public class SelectionSortDemo
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

     int last;
     int l;
     int temp;
     for (last = n-1; last >= 1; --last)
     {
		 // select largest item in arr[0..last]
         l = indexOfLargest(arr, last+1);
         // swap largest item arr[l] with arr[last]
         temp = arr[l];
         arr[l] = arr[last];
         arr[last] = temp;
     }  // end of for loop
 }

 public static int indexOfLargest(int[] arr, int size)
 {
	 int indexSoFar = 0;  // index of largest item found so far
     int currIndex;
     for (currIndex = 1; currIndex < size; ++currIndex)
     {
		 if (arr[currIndex] > arr[indexSoFar])
		 	indexSoFar = currIndex;
     }

     return indexSoFar;  // index of largest item
 }

}