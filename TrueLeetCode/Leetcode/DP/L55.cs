namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/jump-game/description/
public class L55
{
    //Конец массива равен true, поскольку это означает, что мы подошли к решению.
    //Работая в обратном направлении по массиву, мы хотим проверить, может ли наше текущее число привести нас к ближайшему true
    //Если ближайшим значением true является start, то все решение доступно для перехода.
    public bool CanJump(int[] nums)
    {
        int res = nums.Length - 1;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (i + nums[i] >= res)
            {
                res = i;
            }
        }

        return res == 0;
    }
}
