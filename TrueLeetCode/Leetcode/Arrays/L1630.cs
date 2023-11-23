namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/arithmetic-subarrays
public class L1630
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        bool[] result = new bool[l.Length];
        int k = 0;
        for (int i = 0; i < l.Length; i++)
        {
            int p1 = l[i];
            int p2 = r[i];
            int[] range = nums[p1..(p2 + 1)];
            Array.Sort(range);
            bool isArithmetic = true;
            int prev = range[1] - range[0];

            for (int j = 2; j < range.Length; j++)
            {
                if ((range[j] - range[j - 1]) != prev)
                {
                    isArithmetic = false;
                    break;
                }
            }
            result[k] = isArithmetic;
            k++;
        }

        return result;
    }
}
