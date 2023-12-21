namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/subsets/
public class L78
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();

        Recursive(nums.ToList(), 0, new List<int>(), new HashSet<int>(), result);

        return result;
    }

    private void Recursive(List<int> input, int k, List<int> prefix, HashSet<int> visitedIndices, List<IList<int>> result)
    {
        result.Add(new List<int>(prefix));

        for (int i = k; i < input.Count; i++)
        {
            if (visitedIndices.Contains(i))
            {
                continue;
            }
            prefix.Add(input[i]);
            visitedIndices.Add(i);

            Recursive(input, i + 1, prefix, visitedIndices, result);

            prefix.RemoveAt(prefix.Count - 1);
            visitedIndices.Remove(i);
        }
    }
}
