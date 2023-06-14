using System;

namespace MethodAssignment
{
    class MainClass
    {
        public static void Main(string[] args)

        {

            MathOperation mathop = new MathOperation();
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Either enter a second number or press enter");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = MathOperation.Mathoperation1(num1, num2);
                Console.WriteLine(num1 + " + " + num2 + " = " + results);
            }

            catch
            {
                int result = MathOperation.MathOperation1(num1);
                Console.WriteLine(num1 + " + Default 3 = " + result);
            }

            Console.ReadLine();
        }
    }
}
