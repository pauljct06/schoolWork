
public class readarrayfromamethod
{
	public static void main (String [] args)
	{
		double[] nums;
		nums = getArray();

		for( int LCV= 0; LCV<nums.length; LCV++)
		{
		 System.out.println(nums[LCV]);
		}
	}
	public static double[]getArray()
	{
		double [] A = {4,2,3};
		return A;
	}
}
/*
4.0
2.0
3.0
*/
