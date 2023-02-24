using System.Reflection.Emit;

namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/power-of-two/
public class L231
{
    public static bool IsPowerOfTwo(int n)
    {
        DynamicMethod method = new DynamicMethod("leetcode_231", typeof(bool), new Type[] { typeof(int) });
        var generator = method.GetILGenerator();

        var start = generator.DefineLabel();

        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Ldc_I4_0);
        generator.Emit(OpCodes.Ble_S, start);

        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Ldc_I4_1);
        generator.Emit(OpCodes.Sub);
        generator.Emit(OpCodes.And);
        generator.Emit(OpCodes.Ldc_I4_0);
        generator.Emit(OpCodes.Ceq);
        generator.Emit(OpCodes.Ret);

        generator.MarkLabel(start);
        generator.Emit(OpCodes.Ldc_I4_0);
        generator.Emit(OpCodes.Ret);

        return (bool)method.Invoke(null, new object[] { n });
    }
}