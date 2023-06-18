using System;
namespace OperatorAssignment
{
    public class Employee
    {
        public int Id {get; set;}//properties//
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator == (Employee emp1, Employee emp2) //overloading the operator//
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (emp1 is null || emp2 is null)
                return false;

            return emp1.Id == emp2.Id;
                 
        }

        public static bool operator != (Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
