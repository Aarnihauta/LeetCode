namespace TrueLeetCode.Leetcode.HashTable;
public class L217
{
    public bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}
