using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "Jane", LastName = "Smith" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 5, FirstName = "Sarah", LastName = "Williams" },
            new Employee { Id = 6, FirstName = "Alex", LastName = "Brown" },
            new Employee { Id = 7, FirstName = "David", LastName = "Jones" },
            new Employee { Id = 8, FirstName = "Joe", LastName = "Davis" },
            new Employee { Id = 9, FirstName = "Emily", LastName = "Taylor" },
            new Employee { Id = 10, FirstName = "Michael", LastName = "Clark" }
        };

            List<Employee> joes = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            Console.WriteLine("Employees with the first name 'Joe':");
            foreach (Employee joeEmployee in joes)
            {
                Console.WriteLine($"Id: {joeEmployee.Id}, Name: {joeEmployee.FirstName} {joeEmployee.LastName}");
            }

            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.ReadLine();         
        }
    }
}
