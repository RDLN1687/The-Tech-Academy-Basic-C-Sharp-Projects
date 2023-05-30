using System;
using System.Collections.Generic;



    class program
    {
        public static void Main(string[] args)
        {
        //array of strings//
        string[] cities = { "Edmonton", "Toronto", "Vancouver", "montreal", "Calgary", "Leduc", "St.Albert", "Beaumont" };
        Console.WriteLine("Choose a city");
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        bool validString = false;

        while(!validString)
        {
            try
            {
                Console.WriteLine("You fav city is " + cities[stringSelect]);
                validString = true;
            }
            //add a message to display is the user selected soemthing that is not on the list//
            catch
            {
                Console.WriteLine("sorry there is not city with that name");
                stringSelect = Convert.ToInt32(Console.ReadLine());
            }
        }
        }
    }

