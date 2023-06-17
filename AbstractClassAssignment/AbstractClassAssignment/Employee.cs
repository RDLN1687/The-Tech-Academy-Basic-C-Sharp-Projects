using System;
namespace AbstractClassAssignment
{
    public class Employee: Person //inhertting from persons class//
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);

        }

    }
}
