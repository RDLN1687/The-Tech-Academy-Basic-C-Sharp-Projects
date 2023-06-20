using System;


    class MainClass
    {

        public enum DayofWeekEnum //Assigning value//

        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }


        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week:");
                string userInput = Console.ReadLine();

            DayOfWeek currentDay; //// Parse user input and assign the value to the enum variable//
            if (Enum.TryParse(userInput, true, out currentDay))
                {
                    Console.WriteLine("You entered: " + currentDay);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        }
    
