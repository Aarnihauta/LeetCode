using System.Reflection.Emit;

namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/sum-of-two-integers
public class L371
{
    public int TwoSum(int a, int b)
    {
        DynamicMethod method = new DynamicMethod("leetcode_371", typeof(int), new Type[] { typeof(int), typeof(int) });
        var generator = method.GetILGenerator();
        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Ldarg_1);
        generator.Emit(OpCodes.Add);
        generator.Emit(OpCodes.Ret);

        return (int)method.Invoke(null, new object[] { a, b });
    }
}
