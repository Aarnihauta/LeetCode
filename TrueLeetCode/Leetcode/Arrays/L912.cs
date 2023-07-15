namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/sort-an-array/
public class L912
{
    public int[] SortArray(int[] nums)
    {
        var queue = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], nums[i]);
        }

        var result = new int[nums.Length];

        int j = 0;
        while (queue.Count > 0)
        {
            result[j] = queue.Dequeue();
            j++;
        }

        return result;
    }
}
