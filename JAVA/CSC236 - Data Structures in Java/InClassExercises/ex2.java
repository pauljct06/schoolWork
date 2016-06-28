public class ex2
{
public static void main(String[] args)
{
reverse(548);
}
public static void reverse(int n)
{
if(n==0)
System.out.println();

else
{
 System.out.print(n % 10);
 reverse(n/10);
 }
}
}
