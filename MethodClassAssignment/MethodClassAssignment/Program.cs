using System;

namespace MethodClassAssignment
{
    class MainClass
    {


        static void Main(string[] args)
        {
            Mathoperation math = new Mathoperation

            {
               Console.WriteLine("Input a number for addition");
               int add1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Input a number for addition");
               int add2 = Convert.ToInt32(Console.ReadLine());
               int result = Mathoperation.Addition(add1, add2); //Calling method//
               Console.WriteLine("The answer is " + result); 
               Console.ReadLine();
        }
    }
}