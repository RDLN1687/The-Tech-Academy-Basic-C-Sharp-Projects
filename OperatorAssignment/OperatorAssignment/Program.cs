using System;

namespace OperatorAssignment
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() //instantiate first object//
            {
                Id = 1,
                FirstName = "Pam",
                LastName = "Arthur"
            };

            Employee emp2 = new Employee() //instantiate second object//
            {
                Id = 2,
                FirstName = "John",
                LastName = "Whisley"

            };

            Console.WriteLine("Comparing emp1 with emp2 = "); //comparing both the objects//
                Console.WriteLine(emp1 == emp2);
           

        }
    }
}