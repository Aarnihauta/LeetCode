namespace TrueLeetCode.Leetcode.Queue;

//https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
public class L1464
{
    public int MaxProduct(int[] nums)
    {
        var queue = new PriorityQueue<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], -nums[i]);
        }

        int v1 = queue.Dequeue();
        int v2 = queue.Dequeue();

        return (v1 - 1) * (v2 - 1);
    }
}
