namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/binary-watch/
public class L401
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        List<string> list = new List<string>();

        foreach (var h in Enumerable.Range(0, 12))
        {
            foreach (var m in Enumerable.Range(0, 60))
            {
                if(int.PopCount(h << 6 | m) == turnedOn)
                {
                    list.Add($"{h}:{m:d2}");
                }
            }
        }

        return list;
    }
}
