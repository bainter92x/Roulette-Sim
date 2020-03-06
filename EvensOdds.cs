using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class EvensOdds : Program
    {
        public int EvensOddsBet(int Funds)
        {
        Bet:
            Console.WriteLine("Evens or Odds?");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "evens")
            {
                goto Amount;
            }
            if (UserInput == "odds")
            {
                goto Amount;
            }
            else
            {
                Console.WriteLine("You won't win that way!");
                goto Bet;
            }

        Amount:
            Console.WriteLine("How much do you want to bet?");
            if (int.TryParse(Console.ReadLine(), out int Amount))
            {
                if (Amount > Funds)
                {
                    Console.WriteLine("You don't have enough money.");
                    goto Amount;
                }
            }
            else
            {
                Console.WriteLine("We don't accept that kind of currency here.");
                goto Amount;
            }

            RandomNumber r = new RandomNumber();
            int Hit = r.RandomNumberGenerator();

            if (UserInput == "evens")
            {
                if (Hit == 0 || Hit == 00)
                {
                    Console.WriteLine($"We landed on {Hit}. Reroll.");
                    goto Bet;
                }
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Number[i] == Hit)
                    {
                        Console.WriteLine($"We landed on {Hit}!");
                        if (Hit % 2 == 0)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount;
                            return Funds;
                        }
                        else
                        {
                            Console.WriteLine("You lost...");
                            Funds = Funds - Amount;
                            return Funds;
                        }
                    }
                }
            }
            if (UserInput == "odds")
            {
                if (Hit == 0 || Hit == 00)
                {
                    Console.WriteLine($"We landed on {Hit}. Reroll.");
                    goto Bet;
                }
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Number[i] == Hit)
                    {
                        Console.WriteLine($"We landed on {Hit}!");
                        if (Hit % 2 != 0)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount;
                            return Funds;
                        }
                        else
                        {
                            Console.WriteLine("You lost...");
                            Funds = Funds - Amount;
                            return Funds;
                        }
                    }
                }
            }
            return Funds;
        }
    }
}
