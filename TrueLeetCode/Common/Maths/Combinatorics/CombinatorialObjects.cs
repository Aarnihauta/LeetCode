namespace TrueLeetCode.Common.Maths.Combinatorics;
public class CombinatorialObjects
{
    public static int[] CreateBitVector(int n, int numOfBitvector)
    {
        var result = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (numOfBitvector >= Math.Pow(2, n - i))
            {
                result[i] = 1;
            }
            else
            {
                result[i] = 0;
            }
        }

        return result;
    }

    public static List<List<int>> GetPermutation(List<int> data, bool withRepeat)
    {
        var result = new List<List<int>>();

        Backtrack(data, new List<int>(), new HashSet<int>(), result);
        return result;

        void Backtrack(List<int> data, List<int> curr, HashSet<int> visited, List<List<int>> result)
        {
            if (curr.Count == data.Count)
            {
                result.Add(new List<int>(curr));
                return;
            }
            for (int i = 0; i < data.Count; i++)
            {
                if(visited.Contains(i) && withRepeat)
                {
                    continue;
                }

                visited.Add(i);
                curr.Add(data[i]);
                
                Backtrack(data, curr, visited, result);

                curr.RemoveAt(curr.Count - 1);
                visited.Remove(i);
            }
        }
    }
}
