namespace TrueLeetCode.Leetcode.Pointers;

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
public class L167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;
        while (l <= r)
        {
            int left = numbers[l];
            int right = numbers[r];

            if (left + right > target)
            {
                r--;
            }
            else if (left + right < target)
            {
                l++;
            }
            else
            {
                return new int[] { l + 1, r + 1 };
            }
        }

        return null;
    }
}
