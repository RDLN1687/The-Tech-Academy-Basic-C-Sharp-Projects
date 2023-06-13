using System;

namespace MainMethodAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //instantiate the Mathmethod Classs//
            MathMethod math1 = new MathMethod();

            Console.WriteLine("Let us learn about Main Method");
            Console.WriteLine("Input an integer");
            //calling each method//
            Console.WriteLine(MathMethod.MathOps(65));
            Console.ReadLine();
            Console.WriteLine(MathMethod.MathOps(45.6m));
            Console.ReadLine();
            Console.WriteLine(MathMethod.MathOps("34"));
            Console.ReadLine();
            
        }
    }
}
