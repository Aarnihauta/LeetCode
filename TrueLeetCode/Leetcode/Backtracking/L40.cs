namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/combination-sum-ii
public class L40
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> current = new List<int>();
        Array.Sort(candidates);

        Backtrack(candidates, target, 0, current, result);

        return result;
    }
    public void Backtrack(int[] candidates, int target, int idx, IList<int> current, IList<IList<int>> result)
    {
        if (target < 0)
        {
            return;
        }
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }
        for (int i = idx; i < candidates.Length; i++)
        {
            if (i > idx && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            current.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
