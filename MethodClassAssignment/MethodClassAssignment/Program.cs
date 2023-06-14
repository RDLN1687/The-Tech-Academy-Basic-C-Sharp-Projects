using System;

namespace MethodClassAssignment
{
    class MainClass
    {
        Mathoperation math = new Mathoperation();
        
        static void Main(string[] args)

        {
            Console.WriteLine("Input a number for addition");//int1//
            int add1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a number for addition");//int2//
            int add2 = Convert.ToInt32(Console.ReadLine());
            int result = Mathoperation.Addition(add1, add2); //Calling method//
            Console.WriteLine("The answer is " + result);
            Console.ReadLine();
        }

    }
        }
  