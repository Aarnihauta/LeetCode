namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/path-crossing/
public class L1496
{
    public bool IsPathCrossing(string path)
    {
        var visited = new HashSet<(int X, int Y)>
        {
            (0, 0)
        };

        var current = visited.First();
        bool cross = false;
        foreach (var item in path)
        {
            if (item == 'N')
            {
                current.Y++;
            }
            else if (item == 'S')
            {
                current.Y--;
            }
            else if (item == 'W')
            {
                current.X--;
            }
            else
            {
                current.X++;
            }

            if (!visited.Add(current))
            {
                cross = true;
                break;
            }
        }

        return cross;
    }
}
