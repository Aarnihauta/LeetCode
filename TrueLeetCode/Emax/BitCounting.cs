namespace TrueLeetCode.Emax;
public static class BitCounting
{
    private const int CHAR_BIT = 8;
    public static int HammingWeight(int n)
    {
        int res = 0;
        while (n != 0)
        {
            res += n & 1;
            n = n >> 1;
        }
        return res;
    }

    public static int FastBitCounting1(uint n)
    {
        const uint c1 = 0x55555555u;
        const uint c2 = 0x33333333u;
        const uint c3 = 0x0F0F0F0Fu;
        const uint c4 = 0x00FF00FFu;
        const uint c5 = 0X0000FFFFu;

        n = (n & c1) + ((n >>> 1) & (n & c1));
        n = (n & c2) + ((n >>> 2) & (n & c2));
        n = (n & c3) + ((n >>> 2) & (n & c3));
        n = (n & c4) + ((n >>> 4) & (n & c4));
        n = (n & c5) + ((n >>> 4) & (n & c5));

        return (int)n;
    }

    public static int HammingDistance(string x, string y)
    {
        if (x.Length != y.Length)
        {
            throw new ArgumentException();
        }

        if (x == y)
        {
            return 0;
        }

        int d = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != y[i])
            {
                d++;
            }
        }

        return d;
    }

    public static uint Abs(int v)
    {
        int mask = v >> (sizeof(int) * CHAR_BIT - 1);
        return (uint)((v + mask) ^ mask);
    }

    public static bool IsPowerOf2(int v)
    {
        return (v & (v - 1)) == 0;
    }
}
