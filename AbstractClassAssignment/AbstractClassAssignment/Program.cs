using System;

namespace AbstractClassAssignment
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Employee Lynn = new Employee() { firstName = "Sample", lastName = "Student"}; //instantiate an employee object//
            Lynn.SayName();
            Console.ReadLine();
        }
    }
}
