namespace TrueLeetCode.Leetcode.Strings;
public class L2011
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int result = 0;

        foreach (var op in operations)
        {
            if (op.Contains("++"))
            {
                result++;
            }
            else if (op.Contains("--"))
            {
                result--;
            }
        }

        return result;
    }
}
