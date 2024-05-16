namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/combination-sum/
public class L39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Array.Sort(candidates);
        Backtrack(candidates, target, 0, new List<int>(), result);

        return result;
    }

    private void Backtrack(int[] candidates, int target, int idx, List<int> temp, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(temp.ToList());
            return;
        }
     
        while (idx < candidates.Length)
        {
            if (candidates[idx] > target)
            {
                break;
            }
            temp.Add(candidates[idx]);
            Backtrack(candidates, target - candidates[idx], idx, temp, result);
            temp.RemoveAt(temp.Count - 1);

            idx++;
        }
    }
}
