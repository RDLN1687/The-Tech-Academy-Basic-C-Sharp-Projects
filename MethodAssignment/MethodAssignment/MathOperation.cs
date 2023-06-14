using System;
namespace MethodAssignment
{
    public class MathOperation
    {
        public static int MathOperation1(int A, int B = 3)
        {
            int result = A+B;
            return result;
        }

        internal static int Mathoperation1(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}
