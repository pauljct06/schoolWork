
//filename: DriverLicenseExam
//Paul Collado
//CSC-162 Lab 1 Page 535 #5

import java.util.Scanner;

public class DriverLicenseExam
{
 public static void main (String[] args)
  {
  	System.out.println("Paul Collado");
  	System.out.println("CSC-162 Lab 1 Page 535 #5");
  	System.out.println();


  	final char[] ANSWER_KEY = {'B','D','A','A','C',
  							   'A','B','A','C','D',
  							   'B','C','D','A','D',
  							   'C','C','B','D','A'};

	boolean[] booleanarray = new boolean [20];


	int totalstudents;

    Scanner keyboard = new Scanner(System.in);
    System.out.print("Enter how many students took the test: ");
    totalstudents = keyboard.nextInt();

    for(int lcv =1; lcv<= totalstudents; lcv++)  // lcv = Loop Control Variable
    {

	  	char []answers = getanswers(ANSWER_KEY, totalstudents, lcv);
	  	System.out.println();

  		int correctans = getcorrect(ANSWER_KEY,answers, booleanarray); //METHOD TO GET CORRECT ANSWERS

  		int wrongans = getwrong(ANSWER_KEY, answers);   //METHOD TO GET WRONG ANSWERS

  		System.out.println("------------------------------------------");
  		System.out.println();
  		boolean testscore = passedorfailed(correctans); //METHOD TO FIND OUT IF STUDENT PASSED OR NOT
  		if(testscore == true)
  		{
		   System.out.println("Congratulations! You passed the test.");
  		}
  		else                                                               //PASSED OR FAILED MESSAGE
  		{
		   System.out.println("Sorry. You did not passed the test.");
  		}

  		System.out.println();
  		System.out.println("Total correct answers: "+ correctans);         //DISPLAY CORRECT ANSWERS
  		System.out.println();
  		System.out.println("Total incorrect answers: " + wrongans);		   //DISPLAY WRONG ANSWERS
  		System.out.println();

  		if(correctans<ANSWER_KEY.length)
  		{
    	   System.out.println("Here is the list of questions you missed.");   //IF STAMENT TO SHOW ONLY IF
		   System.out.println();                                              //STUDENT MISSED ANY QUESTION
    	   questionsmissed(booleanarray);
    	}
    	System.out.println();
	}
  }

 public static char [] getanswers (char []ANSWERS, int studentsnum, int studentnumber)
  {

      char[] studentanswer;
      studentanswer = new char[ANSWERS.length];

      int[] students;

      students = new int[studentsnum];

        System.out.println("Now enter answers for student " + (studentnumber));
        System.out.println();

        for(int questionnumber = 0; questionnumber < ANSWERS.length; questionnumber++)
        {
   		   System.out.print("Enter answer of student " + (studentnumber) + " for question " + (questionnumber +1) + ": ");
   		   Scanner keyboard = new Scanner(System.in);
   		   String temp = keyboard.next();
   		   studentanswer[questionnumber] = temp.charAt(0);
   	 	}

      return studentanswer;
   }

 public static int getcorrect(char[] KEYS, char[] ans, boolean[] q)
  {
	   boolean arrayequal = true;
	   int rightcount=0;


	   for(int index2 = 0; index2 < KEYS.length; index2++)
	   {
		   if(KEYS[index2] == (ans[index2]))
		   {
			   arrayequal = true;
			   q[index2] = true;
			   rightcount++;
		   }
		   else
		   {
			   q[index2] = false;
		   }
	   }
	   return rightcount;
   }

 public static int getwrong(char[] KEYS, char[] ans)
  {
	   boolean arrayequal = true;
	   int wrongcount=0;

	   for(int index2 = 0; index2 < KEYS.length; index2++)
	   {
		   if(KEYS[index2] != (ans[index2]))
		   {
			   arrayequal = false;
			   wrongcount++;
		   }
	   }
	   return wrongcount;
   }

 public static boolean passedorfailed(int correctans)
  {
		boolean score = true;

		if(correctans >= 15)
		{
			score = true;
		}
		else
		{
			score = false;
		}

		return score;
    }

 public static void questionsmissed(boolean[] q)
  {

	   for(int index2 = 0; index2 < q.length; index2++)
	   {
		   if(q[index2]!=(true))
		   {
			   System.out.println("Question " + (index2 +1) + " was wrong");
		   }
	   }
   }
}

/*
Enter answer of student 4 for question 7: A
Enter answer of student 4 for question 8: B
Enter answer of student 4 for question 9: C
Enter answer of student 4 for question 10: A
Enter answer of student 4 for question 11: B
Enter answer of student 4 for question 12: C
Enter answer of student 4 for question 13: A
Enter answer of student 4 for question 14: C
Enter answer of student 4 for question 15: D
Enter answer of student 4 for question 16: C
Enter answer of student 4 for question 17: A
Enter answer of student 4 for question 18: D
Enter answer of student 4 for question 19: A
Enter answer of student 4 for question 20: A

------------------------------------------

Sorry. You did not passed the test.

Total correct answers: 7

Total incorrect answers: 13

Here is the list of questions you missed.

Question 1 was wrong
Question 2 was wrong
Question 3 was wrong
Question 4 was wrong
Question 6 was wrong
Question 7 was wrong
Question 8 was wrong
Question 10 was wrong
Question 13 was wrong
Question 14 was wrong
Question 17 was wrong
Question 18 was wrong
Question 19 was wrong

Now enter answers for student 5

Enter answer of student 5 for question 1: B
Enter answer of student 5 for question 2: D
Enter answer of student 5 for question 3: A
Enter answer of student 5 for question 4: C
Enter answer of student 5 for question 5: A
Enter answer of student 5 for question 6: B
Enter answer of student 5 for question 7: C
Enter answer of student 5 for question 8: B
Enter answer of student 5 for question 9: D
Enter answer of student 5 for question 10: A
Enter answer of student 5 for question 11: B
Enter answer of student 5 for question 12: C
Enter answer of student 5 for question 13: A
Enter answer of student 5 for question 14: D
Enter answer of student 5 for question 15: C
Enter answer of student 5 for question 16: B
Enter answer of student 5 for question 17: D
Enter answer of student 5 for question 18: A
Enter answer of student 5 for question 19: A
Enter answer of student 5 for question 20: D

------------------------------------------

Sorry. You did not passed the test.

Total correct answers: 5

Total incorrect answers: 15

Here is the list of questions you missed.

Question 4 was wrong
Question 5 was wrong
Question 6 was wrong
Question 7 was wrong
Question 8 was wrong
Question 9 was wrong
Question 10 was wrong
Question 13 was wrong
Question 14 was wrong
Question 15 was wrong
Question 16 was wrong
Question 17 was wrong
Question 18 was wrong
Question 19 was wrong
Question 20 was wrong

Now enter answers for student 6

Enter answer of student 6 for question 1: C
Enter answer of student 6 for question 2: D
Enter answer of student 6 for question 3: A
Enter answer of student 6 for question 4: A
Enter answer of student 6 for question 5: C
Enter answer of student 6 for question 6: B
Enter answer of student 6 for question 7: C
Enter answer of student 6 for question 8: A
Enter answer of student 6 for question 9: C
Enter answer of student 6 for question 10: D
Enter answer of student 6 for question 11: B
Enter answer of student 6 for question 12: C
Enter answer of student 6 for question 13: D
Enter answer of student 6 for question 14: D
Enter answer of student 6 for question 15: D
Enter answer of student 6 for question 16: C
Enter answer of student 6 for question 17: C
Enter answer of student 6 for question 18: B
Enter answer of student 6 for question 19: A
Enter answer of student 6 for question 20: A

------------------------------------------

Congratulations! You passed the test.

Total correct answers: 15

Total incorrect answers: 5

Here is the list of questions you missed.

Question 1 was wrong
Question 6 was wrong
Question 7 was wrong
Question 14 was wrong
Question 19 was wrong

Now enter answers for student 7

Enter answer of student 7 for question 1: B
Enter answer of student 7 for question 2: D
Enter answer of student 7 for question 3: B
Enter answer of student 7 for question 4: D
Enter answer of student 7 for question 5: D
Enter answer of student 7 for question 6: A
Enter answer of student 7 for question 7: B
Enter answer of student 7 for question 8: A
Enter answer of student 7 for question 9: C
Enter answer of student 7 for question 10: D
Enter answer of student 7 for question 11: B
Enter answer of student 7 for question 12: C
Enter answer of student 7 for question 13: D
Enter answer of student 7 for question 14: A
Enter answer of student 7 for question 15: D
Enter answer of student 7 for question 16: C
Enter answer of student 7 for question 17: C
Enter answer of student 7 for question 18: B
Enter answer of student 7 for question 19: D
Enter answer of student 7 for question 20: A

------------------------------------------

Congratulations! You passed the test.

Total correct answers: 17

Total incorrect answers: 3

Here is the list of questions you missed.

Question 3 was wrong
Question 4 was wrong
Question 5 was wrong

Now enter answers for student 8

Enter answer of student 8 for question 1: B
Enter answer of student 8 for question 2: D
Enter answer of student 8 for question 3: A
Enter answer of student 8 for question 4: D
Enter answer of student 8 for question 5: C
Enter answer of student 8 for question 6: A
Enter answer of student 8 for question 7: B
Enter answer of student 8 for question 8: D
Enter answer of student 8 for question 9: A
Enter answer of student 8 for question 10: D
Enter answer of student 8 for question 11: B
Enter answer of student 8 for question 12: A
Enter answer of student 8 for question 13: D
Enter answer of student 8 for question 14: A
Enter answer of student 8 for question 15: A
Enter answer of student 8 for question 16: C
Enter answer of student 8 for question 17: C
Enter answer of student 8 for question 18: A
Enter answer of student 8 for question 19: D
Enter answer of student 8 for question 20: A

------------------------------------------

Sorry. You did not passed the test.

Total correct answers: 14

Total incorrect answers: 6

Here is the list of questions you missed.

Question 4 was wrong
Question 8 was wrong
Question 9 was wrong
Question 12 was wrong
Question 15 was wrong
Question 18 was wrong

Now enter answers for student 9

Enter answer of student 9 for question 1: A
Enter answer of student 9 for question 2: D
Enter answer of student 9 for question 3: B
Enter answer of student 9 for question 4: C
Enter answer of student 9 for question 5: C
Enter answer of student 9 for question 6: D
Enter answer of student 9 for question 7: A
Enter answer of student 9 for question 8: D
Enter answer of student 9 for question 9: C
Enter answer of student 9 for question 10: B
Enter answer of student 9 for question 11: D
Enter answer of student 9 for question 12: C
Enter answer of student 9 for question 13: A
Enter answer of student 9 for question 14: B
Enter answer of student 9 for question 15: A
Enter answer of student 9 for question 16: C
Enter answer of student 9 for question 17: A
Enter answer of student 9 for question 18: A
Enter answer of student 9 for question 19: D
Enter answer of student 9 for question 20: B

------------------------------------------

Sorry. You did not passed the test.

Total correct answers: 6

Total incorrect answers: 14

Here is the list of questions you missed.

Question 1 was wrong
Question 3 was wrong
Question 4 was wrong
Question 6 was wrong
Question 7 was wrong
Question 8 was wrong
Question 10 was wrong
Question 11 was wrong
Question 13 was wrong
Question 14 was wrong
Question 15 was wrong
Question 17 was wrong
Question 18 was wrong
Question 20 was wrong

Now enter answers for student 10

Enter answer of student 10 for question 1: A
Enter answer of student 10 for question 2: B
Enter answer of student 10 for question 3: C
Enter answer of student 10 for question 4: D
Enter answer of student 10 for question 5: D
Enter answer of student 10 for question 6: B
Enter answer of student 10 for question 7: C
Enter answer of student 10 for question 8: A
Enter answer of student 10 for question 9: D
Enter answer of student 10 for question 10: B
Enter answer of student 10 for question 11: A
Enter answer of student 10 for question 12: C
Enter answer of student 10 for question 13: B
Enter answer of student 10 for question 14: A
Enter answer of student 10 for question 15: D
Enter answer of student 10 for question 16: C
Enter answer of student 10 for question 17: C
Enter answer of student 10 for question 18: A
Enter answer of student 10 for question 19: A
Enter answer of student 10 for question 20: A

------------------------------------------

Sorry. You did not passed the test.

Total correct answers: 7

Total incorrect answers: 13

Here is the list of questions you missed.

Question 1 was wrong
Question 2 was wrong
Question 3 was wrong
Question 4 was wrong
Question 5 was wrong
Question 6 was wrong
Question 7 was wrong
Question 9 was wrong
Question 10 was wrong
Question 11 was wrong
Question 13 was wrong
Question 18 was wrong
Question 19 was wrong

Press any key to continue . . .

*/
