﻿namespace TrueLeetCode.Common.Math.Combinatorics;
public static class Combination
{
    public static List<List<T>> Find<T>(List<T> n, int r, bool withRepetition = false)
    {
        var result = new List<List<T>>();

        Recurse(n, r, 0, new List<T>(), new HashSet<int>(), result, withRepetition);

        return result;
    }

    private static void Recurse<T>(List<T> n, int r, int k, List<T> prefix, HashSet<int> visited, List<List<T>> result, bool withRepetition)
    {
        if (prefix.Count == r)
        {
            result.Add(new List<T>(prefix));
            return;
        }

        for (int i = k; i < n.Count; i++)
        {
            if(visited.Contains(i) && !withRepetition)
            {
                continue;
            }

            prefix.Add(n[i]);
            visited.Add(i);

            Recurse(n, r, i + 1, prefix, visited, result, withRepetition);

            prefix.RemoveAt(prefix.Count - 1);
            visited.Remove(i);
        }
    }
}
