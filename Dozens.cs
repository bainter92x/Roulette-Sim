using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Dozens : Program
    {
        public int DozensBet(int Funds)
        {
        Bet:
            Console.WriteLine("First Dozen, Second Dozen, or Third Dozen?");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "first dozen")
            {
                goto Amount;
            }
            if (UserInput == "second dozen")
            {
                goto Amount;
            }
            if (UserInput == "third dozen")
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

            if (UserInput == "first dozen")
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
                            || Hit == 9 || Hit == 10 || Hit == 11 || Hit == 12)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 2;
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
            if (UserInput == "second dozen")
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
                        if (Hit == 13 || Hit == 14 || Hit == 15 || Hit == 16 || Hit == 17 || Hit == 18 || Hit == 19 || Hit == 20
                            || Hit == 21 || Hit == 22 || Hit == 23 || Hit == 24)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 2;
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
            if (UserInput == "third dozen")
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
                        if (Hit == 25 || Hit == 26 || Hit == 27 || Hit == 28 || Hit == 29 || Hit == 30 || Hit == 31 || Hit == 32
                            || Hit == 33 || Hit == 34 || Hit == 35 || Hit == 36)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 2;
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
