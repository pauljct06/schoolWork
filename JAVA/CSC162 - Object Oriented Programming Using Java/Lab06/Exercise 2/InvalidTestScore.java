public class InvalidTestScore extends Exception
{
 public InvalidTestScore()
 {
	 super("ERROR! INVALID VALUE INDEX");
 }

 public InvalidTestScore(String str)
 {
	 super(str);
 }
}