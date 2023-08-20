namespace TrueLeetCode.Leetcode.Common;

//https://leetcode.com/problems/count-primes
public class L204
{
    public int CountPrimes(int n)
    {
        if (n <= 2)
        {
            return 0;
        }

        bool[] sieve = new bool[n];
        int result = 0;
        for (int i = 2; i < n; i++)
        {
            if (sieve[i])
            {
                continue;
            }

            result++;

            int count = 2;
            while (i * count < n)
            {
                sieve[i * count] = true;
                count++;
            }
        }

        return result;
    }
}
