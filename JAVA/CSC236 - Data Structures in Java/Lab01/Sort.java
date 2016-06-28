// Paul Collado
// Lab 01 Part 2 MergeSort
// CSC 236-01

public class Sort {

		//THIS METHOD DIVIDES AN ARRAY INTO BOTTOM AND TOP PARTS
		public static void mergesort(Comparable[] names) {

			if(names.length > 1){
				//COPYING INTO BOTTOM PART
				Comparable[] bot = new Comparable[names.length/2];
				System.arraycopy(names,0,bot,0,bot.length);

				//COPYING INTO TOP PART
				Comparable[] top = new Comparable[names.length - bot.length];
				System.arraycopy(names,bot.length,top,0,top.length);

				mergesort(bot);
				mergesort(top);
				merge(names,bot,top);
			}
		}// END OF mergesort METHOD

		//THIS METHOD SORTS AND MERGES THE BOTTOM AND TOP PART INTO ORIGINAL ARRAY PASS IN THE mergesort METHOD
		public static void merge(Comparable[] names, Comparable[] bot, Comparable[] top) {

			int i=0,b=0,t=0; //ARRYS COUNTERS
			while(b<bot.length && t<top.length) {

				if(bot[b].compareTo(top[t]) <= 0) {
					names[i] = bot[b];
					b++;
				}

				else {
					names[i] = top[t];
					t++;
				}i++;
			}

			while(b < bot.length) {
				names[i] = bot[b];
				i++;
				b++;
			}

			while(t < top.length) {
				names[i] = top[t];
				i++;
				t++;
		    }
		}//END OF merge METHOD
}