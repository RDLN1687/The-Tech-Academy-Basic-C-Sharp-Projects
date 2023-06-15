using System;

namespace MethodAndObjectAssignment
{
    class MainClass
    {
        
       
        public static void Main(string[] args)
        {
            Employee NewEmployee = new Employee() { FirstName = "Pam", LastName = "Arthur" };//Super Class method//
            NewEmployee.SayName();
            Console.ReadLine();
        }
    }
}
