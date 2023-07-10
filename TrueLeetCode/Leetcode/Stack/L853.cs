namespace TrueLeetCode.Leetcode.Stack;

//https://leetcode.com/problems/car-fleet/
public class L853
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        Array.Sort(position, speed);
        int fleets = 0;
        double slowestCarTime = 0;

        for (int i = position.Length - 1; i >= 0; i--)
        {
            var currentCarTime = (double)(target - position[i]) / speed[i];
            if (slowestCarTime < currentCarTime)
            {
                fleets++;
                slowestCarTime = currentCarTime;
            }
        }
        return fleets;
    }
}
