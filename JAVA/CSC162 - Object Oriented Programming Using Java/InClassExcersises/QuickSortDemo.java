public class QuickSortDemo
{
 public static void main(String[] args)
 {
	 int [] myarray = {30,40,70,10,50,60};

	 for (int index=0; index<myarray.length; index++)
	 {
	 		 System.out.print(myarray[index] + " ");
	 }

	 System.out.println();
	 quicksort(myarray);

	 for (int index=0; index<myarray.length; index++)
	 {
		 System.out.print(myarray[index] + " ");
	 }

	 System.out.println();
 }
 public static void quicksort(int[] arr)
 {
	 quicksort(arr,0,arr.length-1);
 }

 public static void quicksort(int[] arr, int first, int last)
 {
	 int i;
     if (first >= last)
         return;
     int pivotloc = partition(arr, first, last);
     quicksort(arr, first, pivotloc-1);
     quicksort(arr, pivotloc+1, last);
 }

 public static int partition(int[] arr, int first, int last)
 {
	 int pivot = arr[first];
     int low = first;
     int high = last;
     while (low < high)
     {
		 while (arr[low] <= pivot && low < high)
                low++;
         while (arr[high] > pivot && low <= high)
             high--;
         // swap high value in lower half with low value in
         // upper half
         if (low < high)
             swap(arr, low, high);
     }
     // move pivot to end of low half
     swap(arr, first, high);
     return high;
 }

 public static void swap (int[] arr, int i, int j)
 {
	 int temp = arr[i];
     arr[i] = arr[j];
     arr[j] = temp;
 }

}
