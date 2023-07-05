namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/top-k-frequent-elements/
public class L347
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return nums.GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
