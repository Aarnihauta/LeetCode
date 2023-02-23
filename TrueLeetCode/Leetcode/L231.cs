using System.Reflection.Emit;

namespace TrueLeetCode.Leetcode;
public class L231
{
    //https://leetcode.com/problems/power-of-two/
    public static bool IsPowerOfTwo(int n)
    {
        DynamicMethod method = new DynamicMethod("leetcode_231", typeof(bool), new Type[] { typeof(int) });
        
        var generator = method.GetILGenerator();
                                                        //#description                                              #stack history

        var start = generator.DefineLabel();
        generator.Emit(OpCodes.Ldarg_0);                //load 'n' at index 0 onto the stack                        n
        generator.Emit(OpCodes.Brtrue, start);          //if n != 0 go to 'start'                                   
        generator.Emit(OpCodes.Ldc_I4_0);               //push 0 value onto the stack (int32)                       0, n
        generator.Emit(OpCodes.Ret);                    //return 0 (false)

        generator.MarkLabel(start);
        generator.Emit(OpCodes.Ldarg_0);                //load 'n' at index 0 onto the stack                        n
        generator.Emit(OpCodes.Ldarg_0);                //load 'n' at index 0 onto the stack                        n, n
        generator.Emit(OpCodes.Ldc_I4_1);               //load '1' int value onto the stack (0 index)               1, n, n
        generator.Emit(OpCodes.Sub);                    //n - 1, result pushed onto the stack (0 index)             x = n - 1, n
        generator.Emit(OpCodes.And);                    //bitwise AND of two values and pushes onto the stack       y = x & n
        generator.Emit(OpCodes.Ldc_I4_0);               //push 0 value onto the stack (int32)                       0, y
        generator.Emit(OpCodes.Ceq);                    //compares two values and pushed 0 or 1 onto the stack      c = 0 == y
        generator.Emit(OpCodes.Ret);                    //return 'c'


        return (bool)method.Invoke(null, new object[] { n });
    }
}