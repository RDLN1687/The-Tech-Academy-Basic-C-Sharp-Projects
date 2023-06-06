using System;

    class program
    {

        static void Main(string[] args)


        {
            try
        {
            Console.WriteLine("Please select a number between 1-10");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please select another number between 1-10");
            int Y = Convert.ToInt32(Console.ReadLine());

            //divide those two numbers which were inputted//
            int Z = X / Y;
            Console.WriteLine(Z);
            Console.ReadLine();
        }
        //try and catch method//
            catch(FormatException)
                {
                Console.WriteLine("Please enter a valid number");
                }
            catch(DivideByZeroException)
                {
                Console.WriteLine("You cannot divide by zero");
                }
        }

  

}
