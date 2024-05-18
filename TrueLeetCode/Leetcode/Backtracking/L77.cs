namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/combinations/
public class L77
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var source = Enumerable.Range(1, n).ToArray();
        var list = new List<IList<int>>();
        var current = new List<int>();

        Backtrack(list, current, source, 0, k);

        return list;
    }

    private void Backtrack(IList<IList<int>> list, List<int> current, int[] source, int idx, int k)
    {
        if (current.Count == k)
        {
            list.Add(new List<int>(current));
            return;
        }
        for (int i = idx; i < source.Length; i++)
        {
            current.Add(source[i]);
            Backtrack(list, current, source, i + 1, k);
            current.RemoveAt(current.Count - 1);
        }
    }
}
