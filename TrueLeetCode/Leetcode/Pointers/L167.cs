namespace TrueLeetCode.Leetcode.Pointers;

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
public class L167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int val = target - numbers[i];
            int searchIndex = BinarySearch(numbers, val, i);

            if (searchIndex > 0)
            {
                return new int[] { i + 1, searchIndex + 1 };
            }
        }
        return new int[2];
    }

    private int BinarySearch(int[] numbers, int target, int skipIndex)
    {
        int start = 0;
        int end = numbers.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if(target == numbers[mid])
            {
                if(mid == skipIndex)
                {
                    if (mid - 1 >= 0 && numbers[mid - 1] == target)
                    {
                        return mid - 1;
                    }
                    else if (mid + 1 < numbers.Length && numbers[mid + 1] == target)
                    {
                        return mid + 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return mid;
                }
            }
            else
            {
                if(target < numbers[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
        }
        return -1;
    }
}
