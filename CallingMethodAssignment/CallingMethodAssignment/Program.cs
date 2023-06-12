using System;

namespace CallingMethodAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let us do some basic math");
            Console.WriteLine("Input some number for multiplication");
            int Mul = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is " + Math.Multiply(Mul));//calling method//
            Console.ReadLine();
            Console.WriteLine("Input a number for addition");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is " + Math.Addition(add)); //Calling method//
            Console.ReadLine();
            Console.WriteLine("Enter any even number");
            int Div = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The anwer is " + Math.Division(Div));//Calling method//
            Console.ReadLine();
        }

       
    }
}
