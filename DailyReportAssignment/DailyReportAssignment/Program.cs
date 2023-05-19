using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College" + "\n" + "Student Daily Report" );
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");//converting str to int//
            int pgNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer true or false");//converting str to bool//
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");//converting str to int//
            int study = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
