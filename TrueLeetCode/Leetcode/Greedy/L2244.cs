namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/
public class L2244
{
    public int MinimumRounds(int[] tasks)
    {
        var map = new Dictionary<int, int>();
        int result = 0;
        foreach (var item in tasks)
        {
            if(map.ContainsKey(item))
            {
                map[item]++;
            }
            else
            {
                map.Add(item, 1);
            }
        }

        foreach(var item in map)
        {
            int c = 0;
            Recursive(item.Value, ref c);
            
            if (c == -1)
            {
                return -1;
            }
            
            result += c;
        }

        return result;
    }

    private void Recursive(int n, ref int c)
    {
        if (n == 0)
        {
            return;
        }
        if (n - 3 != 1 && n - 3 >= 0)
        {
            c += 1;
            Recursive(n - 3, ref c);
        }
        else if (n - 2 != 1 && n - 2 >= 0)
        {
            c += 1;
            Recursive(n - 2, ref c);
        }
        else
        {
            c = -1;
        }
    }
}
