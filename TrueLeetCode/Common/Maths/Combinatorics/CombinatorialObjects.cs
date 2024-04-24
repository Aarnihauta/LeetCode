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

    public static List<List<int>> GetPermutation(List<int> data, bool withRepeat = false)
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
                if (visited.Contains(i) && !withRepeat)
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

    public static List<int> GetNextPermutation(int k, int n)
    {
        bool[] was = new bool[k];
        List<int> result = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int f = Factorial(n - i);
            int alreadyWas = k / f;
            k %= f;
            int currentFree = 0;

            for (int j = 0; j < n; j++)
            {
                if (was[j] == false)
                {
                    currentFree++;
                    if (currentFree == alreadyWas + 1)
                    {
                        result.Add(j + 1);
                        was[j] = true;
                    }
                }
            }
        }

        return result;
    }

    public static int Factorial(int n)
    {
        int current = 1;
        for (int i = 2; i < n; i++)
        {
            current *= i;
        }
        return current;
    }
}
