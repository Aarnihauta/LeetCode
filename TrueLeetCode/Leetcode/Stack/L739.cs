namespace TrueLeetCode.Leetcode.Stack;
public class L739
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++)
        {
            for(int j = i + 1, k = 1; j < temperatures.Length; j++, k++)
            {
                if (temperatures[i] < temperatures[j])
                {
                    result[i] = k;
                    break;
                }
            }
        }

        return result;
    }
}
