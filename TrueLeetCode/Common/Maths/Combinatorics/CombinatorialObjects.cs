namespace TrueLeetCode.Common.Maths.Combinatorics;
public class CombinatorialObjects
{
    public static ulong Factorial(int n)
    {
        ulong current = 1;
        for (ulong i = 2; i < (ulong)n; i++)
        {
            current *= i;
        }
        return current;
    }

    public static int[] GetNext(int[] arr)
    {
        int i = arr.Length - 1;
        for (; i > 0; i--)
        {
            if (arr[i] > arr[i - 1])
            {
                i--;
                break;
            }
        }

        int j = arr.Length - 1;
        for (; j > 0; j--)
        {
            if (arr[j] > arr[i])
            {
                break;
            }
        }

        Swap(ref arr[i], ref arr[j]);

        Array.Sort(arr, i + 1, arr.Length - i - 1);

        return arr;
    }

    private static void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
}
