using System;
using System.IO;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Please enter a number: ");
        string input = Console.ReadLine();

        // Log the number to a text file
        string fileName = "number_log.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(input);
            writer.WriteLine(DateTime.Now);
        }

        Console.WriteLine("Number logged successfully!");

        // Read and print the contents of the text file
        Console.WriteLine("Contents of the log file:");
        using (StreamReader reader = new StreamReader(fileName))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
