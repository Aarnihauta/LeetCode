namespace TrueLeetCode.Emax;
public class Euclid
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            a %= b;
            MathExt.Swap(ref a, ref b);
        }

        return a;
    }

    public static int LeastCommonMultiple(int a, int b)
    {
        return a / GreatestCommonDivisor(a, b) * b;
    }
}
