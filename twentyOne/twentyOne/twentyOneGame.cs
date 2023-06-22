﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace twentyOne
{
    public class twentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(Card,1,1 );
            Console.WriteLine("Place your bet!");

            foreach (Player player in players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.bet(bet);
                if (!successfullyBet)
                {
                    return;
                }

                Bets[player] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }

                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer had BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }

            foreach (Player player in players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                        Console.WriteLine("{0} ", card.ToString());
                }
                Console.WriteLine("\n\n Hit or Stay>");
                string answer = Console.ReadLine().ToLower();
                if (answer == "Stay")
                {
                    player.Stay = true;
                    break;
                }
                else if (answer == "hit")
                {
                    Dealer.Deal(player.Hand);
                }
                bool busted = TwentyOneRules.IsBusted(player.Hand);
                if (busted)
                {
                    Dealer.Balance += Bets[player];
                    Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}", player.Name, Bets[player], player.Balance);
                    Console.WriteLine("Do you want to play again?");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yeah")
                    {
                        player.isActivelyPlaying = true;
                        return;
                    }
                    else
                    {
                        player.isActivelyPlaying = false;
                        return;
                    }
                }
            }


            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                {
                    if (Dealer.Stay)
                    {
                        Console.WriteLine("Dealer is Staying");
                    }
                    if (Dealer.isBusted)
                    {
                        Console.WriteLine("Dealer Busted!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Console.WriteLine("{0} WON {1}!!", entry.Key.Name, entry.Value);
                            players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                            Dealer.Balance -= entry.Value;
                        }

                        return;
                    }
                    foreach (Player player in players)
                    {
                        bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                        if (playerWon == null)
                        {
                            Console.WriteLine("Push! No one wins!");
                            player.Balance += Bets[player];
                        }
                        else if (playerWon == true)
                        {
                            Console.WriteLine("{0} Won {1}! ", player.Name, Bets[player]);
                            player.Balance += (Bets[player] * 2);
                            Dealer.Balance -= Bets[player];
                        }
                        else
                        {
                            Console.WriteLine("Dealer wins {0}!", Bets[player]);
                            Dealer.Balance += Bets[player];
                        }

                        Console.WriteLine("Play Again?");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                    }
                    
                }
            }
        }
            

    public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
