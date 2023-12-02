namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/teemo-attacking/description/
public class L495
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if(duration == 0)
        {
            return 0;
        }
        int totalSeconds = 0;

        for (int i = 1; i < timeSeries.Length; i++)
        {
            int v = timeSeries[i] - timeSeries[i -1];
            if (v == 1)
            {
                totalSeconds += 1;
            }
            else if (v < duration)
            {
                totalSeconds += v;
            }
            else
            {
                totalSeconds += duration;
            }
        }

        return totalSeconds += duration;
    }
}
