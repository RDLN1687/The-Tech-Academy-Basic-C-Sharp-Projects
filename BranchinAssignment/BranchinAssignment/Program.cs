using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchinAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int PkgWeight = 50;//Pacakge weight limit//
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please let us know the weight of the package");
            int Weight = Convert.ToInt32(Console.ReadLine());//converting int to string//
            string result = Weight > PkgWeight ? " Package is too heavy to be shipped via Package Express. Have a good day!" : "Please let us know the width of the package?";//ternary statement//
            Console.WriteLine(result);
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please let us know the height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please let us know the length?");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimension = width + height + length; // adding all the dimensions//
            Console.WriteLine("The total dimension is " + dimension);
            string totalDimension = dimension > 50 ? "Package is too big to be shipped via Package Express" : "Your estimate total for shipping this pacakge is .";
            Console.WriteLine(totalDimension);
            int fullDimension = (width * height * length) * Weight / 100; //calculating the cost//
            Console.WriteLine(fullDimension);
            Console.ReadLine();
        }
    }
}
