namespace TrueLeetCode.Leetcode.DP;
public class L509
{
    public int Fib(int n)
    {
        if(n <= 1)
        {
            return 1;
        }

        int n1 = 0;
        int n2 = 1;
        int next = 0;
        for (int i = 2; i <= n; i++)
        {
            next = n1 + n2;
            n1 = n2;
            n2 = next;
        }

        return next;
    }
}
