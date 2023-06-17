using System;
namespace AbstractClassAssignment
{
    public abstract class Person
    {
           //two properties//
            public string firstName { get; set; }
            public string lastName { get; set; }

        public abstract void SayName();
            
    }
}
