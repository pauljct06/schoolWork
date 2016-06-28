/*public class MergeSort{
	public static void main(String []args) {

		int[] array = {7,4,5,2,1,6,3,9,8};
		mergesort(array);

		System.out.println();
		for(int i : array)
		System.out.print(i + " ");
		System.out.println();


	}
	public static void mergesort(int[] arr) {

		if(arr.length > 1){
			int[] bot = new int[arr.length/2];
			System.arraycopy(arr,0,bot,0,bot.length);

			System.out.println("bottom part:");
			for(int i : bot)
			System.out.println(i);

			int[] top = new int[arr.length - bot.length];
			System.arraycopy(arr,bot.length,top,0,top.length);

			System.out.println("top part:");
			for(int i : top)
			System.out.println(i);

			mergesort(bot);
			mergesort(top);
			merge(arr,bot,top);
		}
	}

	public static void merge(int[] arr, int[] bot, int[] top) {

		int i=0,b=0,t=0;
		while(b<bot.length && t<top.length) {

			if(bot[b] <= top[t]) {
				arr[i] = bot[b];
				b++;
			}

			else {
				arr[i] = top[t];
				t++;
			}i++;
		}

		while(b < bot.length) {
			arr[i] = bot[b];
			i++;
			b++;
		}

		while(t < top.length) {
			arr[i] = top[t];
			i++;
			t++;
	    }
	}
}
*/