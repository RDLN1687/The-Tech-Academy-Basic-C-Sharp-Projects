using System;
namespace MethodAndObjectAssignment
{
    public class Person //setting 2 properties//
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name is " + this.FirstName + " " + this.LastName);
        }
    }
}

