namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/boats-to-save-people
public class L881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int total = 0;
        int l = 0;
        int r = people.Length - 1;
        while(l <= r)
        {
            if (people[l] + people[r] <= limit)
            {
                l++;
            }

            r--;
            total++;
        }

        return total;
    }
}
