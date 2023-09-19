namespace TrueLeetCode.Leetcode.BitManipulations;

//https://leetcode.com/problems/sum-of-all-subset-xor-totals/
public class L1863
{
    public int SubsetXORSum(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var items = Enumerable
            .Range(1, 1 << nums.Length - 1)
            .Select(i => nums.Where((item, idx) => (1 << idx & i) != 0).ToArray())
            .ToArray();

        int res = 0;

        for (int i = 0; i < items.Length; i++)
        {
            int xor = 0;
            for (int j = 0; j < items[i].Length; j++)
            {
                xor ^= items[i][j];
            }
            res += xor;
        }
        return res;
    }
}
