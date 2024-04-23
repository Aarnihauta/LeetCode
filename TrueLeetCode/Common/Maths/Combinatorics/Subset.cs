namespace TrueLeetCode.Common.Maths.Combinatorics;
public static class Subset
{
    public static List<List<T>> Find<T>(List<T> input)
    {
        var result = new List<List<T>>();

        Recurse(input, 0, new List<T>(), new HashSet<int>(), result);

        return result;
    }

    private static void Recurse<T>(List<T> input, int k, List<T> prefix, HashSet<int> prefixIndices, List<List<T>> result)
    {
        result.Add(new List<T>(prefix));

        for (int i = k; i < input.Count; i++)
        {
            if(prefixIndices.Contains(i))
            {
                continue;
            }

            prefix.Add(input[i]);
            prefixIndices.Add(i);

            Recurse(input, i + 1, prefix, prefixIndices, result);

            prefix.RemoveAt(prefix.Count - 1);
            prefixIndices.Remove(i);
        }
    }
}