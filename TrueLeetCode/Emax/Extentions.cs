﻿namespace TrueLeetCode.Emax;
public static class MathExt
{
    public static bool IsPrime(this int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Swap(ref int a, ref int b)
    {
        var c = a;
        a = b; 
        b = c;
    }
}
