namespace TrueLeetCode.Emax;
public class Pow
{
    public static double BinPow(double a, int n)
    {
        if (a == 0)
        {
            return 1;
        }

        if (n < 0)
        {
            a = 1 / a;
            n = -n;
        }

        double result = 1;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                result *= a;
            }

            a *= a;
            n /= 2;
        }
        return result;
    }
}
