using System.Reflection.Emit;

namespace TrueLeetCode.Leetcode;
public class L231
{
    //https://leetcode.com/problems/power-of-two/
    public static bool IsPowerOfTwo(int n)
    {
        var mathAbs = typeof(Math).GetMethod("Abs", new Type[] { typeof(int) });

        DynamicMethod method = new DynamicMethod("leetcode_231", typeof(bool), new Type[] { typeof(int) });
        var generator = method.GetILGenerator();

        var start = generator.DefineLabel();

        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Ldc_I4_1);
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


    public static int MathAbs(int n)
    {
        DynamicMethod method = new DynamicMethod("leetcode_231", typeof(int), new Type[] { typeof(int) });
        var generator = method.GetILGenerator();

        var mathAbs = typeof(Math).GetMethod("Abs", new Type[] { typeof(int) });

        generator.Emit(OpCodes.Ldarg_0);
        generator.Emit(OpCodes.Call, mathAbs);
        generator.Emit(OpCodes.Ret);

        return (int)method.Invoke(null, new object[] { n });
    }
}