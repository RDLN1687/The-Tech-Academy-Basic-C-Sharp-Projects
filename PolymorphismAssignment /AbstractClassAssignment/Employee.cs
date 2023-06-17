using System;
namespace AbstractClassAssignment
{
    public class Employee: Person, IQuittable //inhertting from persons class and interface IQuittable//
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);

        }


        public void Quit() //implementing the interface//
        {
            throw new NotImplementedException();
        }
    }
}
