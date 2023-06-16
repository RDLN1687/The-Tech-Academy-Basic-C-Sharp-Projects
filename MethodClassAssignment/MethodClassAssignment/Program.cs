using System;

namespace MethodClassAssignment
{
    class MainClass
    {
        
        public static void Main(string[] args)
            
        {
            MathOperation MathOp = new MathOperation();

            Console.WriteLine("Input a number for addition");//int1//
            int add1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a number for addition");//int2//
            int add2 = Convert.ToInt32(Console.ReadLine());
            MathOp.Addition(add1, add2); //Calling method//
        }

    }
}
