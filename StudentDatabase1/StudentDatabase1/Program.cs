using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase1
{
    public class Student //properties of a student//
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main (string[] args)
        {
            using (var context = new StudentDbContext())
            {
                context.Database.CreateIfNotExists();

                var student = new Student { FirstName = "Pam", LastName = "Whiley" };
                context.Students. Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");//Adding a student//
            }
            Console.ReadLine();
        }
    }
}
