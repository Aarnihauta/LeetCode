namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/permutations-ii/
public class L47
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        List<IList<int>> list = new List<IList<int>>();
        Array.Sort(nums);
        Backtrack(list, nums);
        return list;
    }

    private void Backtrack(List<IList<int>> result, int[] array)
    {
        if (result.Any(x => x.SequenceEqual(array)))
        {
            return;
        }
        int[] temp = new int[array.Length];
        array.CopyTo(temp, 0);

        result.Add(temp);
        int i = array.Length - 1;

        for (; i > 0; i--)
        {
            if (array[i] > array[i - 1])
            {
                i--;
                break;
            }
        }

        int j = array.Length - 1;

        for (; j > 0; j--)
        {
            if (array[j] > array[i])
            {
                break;
            }
        }

        Swap(ref array[i], ref array[j]);
        Array.Sort(array, i + 1, array.Length - i - 1);
        Backtrack(result, array);
    }

    private static void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
}
