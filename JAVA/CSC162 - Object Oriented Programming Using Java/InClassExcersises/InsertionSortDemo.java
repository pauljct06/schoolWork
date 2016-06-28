public class InsertionSortDemo
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
	 insertionSort(myarray,n);

	 for (int index=0; index<myarray.length; index++)
	 {
		 System.out.print(myarray[index] + " ");
	 }

	 System.out.println();
 }
 public static void insertionSort(int[] nums, int n)
 {
	 int target;
     int pos;
     int i;

 	 for (pos = 1 ; pos < n ; pos++)
 	 {
		 // nums[0] to nums[pos-1] is sorted
         // nums[pos] will be inserted into correct position in
         // sorted portion of array
         target = nums[pos];

         // compare target with elements starting at nums[pos-1]
         // if array element is bigger than target, move it up
         // one position
         for (i = pos - 1 ; i >= 0 && nums[i] > target ; i--)
         {
			 nums[i+1] = nums[i];
		 }

         // insert target into correct position
         nums[i+1] = target;
      }  // end of the otter for loop
 }

}
