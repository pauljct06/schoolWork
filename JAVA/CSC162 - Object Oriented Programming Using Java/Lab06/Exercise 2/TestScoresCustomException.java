public class TestScoresCustomException
{
  private int[] scores;

 public TestScoresCustomException()
 {
	 scores = null;
 }

 public TestScoresCustomException(int[] array)
 {
	 scores = new int[array.length];
	 for(int i=0; i<=array.length - 1; i++)
	 {
	   scores[i] = array[i];
   	 }
 }

 public double getAverage() throws InvalidTestScore
 {
   int i = 0;
   int sum = 0;
   boolean error = false;
   double avg = 0;

   while(!error && i< scores.length - 1)
   {
	   if(scores[i] <0 || scores[i] > 100)
	   {
		   error = true;
	   }

	   else
	   {
		   sum = sum + scores[i];
	   }
	   i++;

	   avg = (sum / scores.length);
   }
   if (error == true)
   {
	   throw new InvalidTestScore("\nERROR! INVALID VALUE AT INDEX: " + (i-1) + ", INVALID VALUE WAS: " + scores[i-1]);
   }
   else return avg;
 }
}




