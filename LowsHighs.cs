using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class LowsHighs : Program
    {
        public int LowsHighsBet(int Funds)
        {
        Bet:
            Console.WriteLine("Lows or Highs?");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "lows")
            {
                goto Amount;
            }
            if (UserInput == "highs")
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

            if (UserInput == "lows")
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
                        if (Hit == 1 || Hit == 2 || Hit == 3 || Hit == 4 || Hit == 5 || Hit == 6 || Hit == 7 || Hit == 8
                            || Hit == 9 || Hit == 10 || Hit == 11 || Hit == 12 || Hit == 13 || Hit == 14 || Hit == 15
                            || Hit == 16 || Hit == 17 || Hit == 18)
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
            if (UserInput == "highs")
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
                        if (Hit == 1 || Hit == 2 || Hit == 3 || Hit == 4 || Hit == 5 || Hit == 6 || Hit == 7 || Hit == 8
                            || Hit == 9 || Hit == 10 || Hit == 11 || Hit == 12 || Hit == 13 || Hit == 14 || Hit == 15
                            || Hit == 16 || Hit == 17 || Hit == 18)
                        {
                            Console.WriteLine("You lost...");
                            Funds = Funds - Amount;
                            return Funds;
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount;
                            return Funds;
                        }
                    }
                }
            }
            return Funds;
        }
    }
}
