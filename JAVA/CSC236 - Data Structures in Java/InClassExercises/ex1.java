public class ex1
{
public static void main(String[] args)
{
int x;

System.out.println(factorial(4));

}

public static int factorial(int n)
{
if(n==1)
return n;

else
return n * factorial(n-1);
}
}
