using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RedsBlacks : Program
    {
        public int RedsBlacksBet(int Funds)
        {
        Bet:
            Console.WriteLine("Reds or Blacks?");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "reds")
            {
                goto Amount;
            }
            if (UserInput == "blacks")
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

            RandomColor r = new RandomColor();
            string Hit = r.RandomColorGenerator();

            if (UserInput == "reds")
            {
                if (Hit == "0" || Hit == "00")
                {
                    Console.WriteLine($"We landed on {Hit}. Reroll.");
                    goto Bet;
                }
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Color[i] == Hit)
                    {
                        Console.WriteLine($"We landed on {Hit}!");
                        if (Hit == "Red")
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
            if (UserInput == "blacks")
            {
                if (Hit == "0" || Hit == "00")
                {
                    Console.WriteLine($"We landed on {Hit}. Reroll.");
                    goto Bet;
                }
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Color[i] == Hit)
                    {
                        Console.WriteLine($"We landed on {Hit}!");
                        if (Hit == "Red")
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
