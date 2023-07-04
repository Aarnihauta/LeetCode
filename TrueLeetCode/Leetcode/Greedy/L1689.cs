namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
public class L1689
{
    public int MinPartitions(string s)
    {
        return s.Max() - '0';
    }
}
