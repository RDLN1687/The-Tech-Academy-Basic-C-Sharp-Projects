using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace twentyOne
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start with your name. ");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you bring in today? ");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0} would you like to play the Game of 21 now? ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new twentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance >0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Please feel free to look around the casino, Bye for now!");
            Console.ReadLine();

            
        }
    }
}
