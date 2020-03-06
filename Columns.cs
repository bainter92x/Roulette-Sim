using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Columns : Program
    {
        public int ColumnsBet(int Funds)
        {
        Bet:
            Console.WriteLine("First Column, Second Column, or Third Column?");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "first column")
            {
                goto Amount;
            }
            if (UserInput == "second column")
            {
                goto Amount;
            }
            if (UserInput == "third column")
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

            if (UserInput == "first column")
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
                        if (Hit == 1 || Hit == 4 || Hit == 7 || Hit == 10 || Hit == 13 || Hit == 16 || Hit == 19 || Hit == 22
                            || Hit == 25 || Hit == 28 || Hit == 31 || Hit == 34)
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
            if (UserInput == "second column")
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
                        if (Hit == 2 || Hit == 5 || Hit == 8 || Hit == 11 || Hit == 14 || Hit == 17 || Hit == 20 || Hit == 23
                            || Hit == 26 || Hit == 29 || Hit == 32 || Hit == 35)
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
            if (UserInput == "third column")
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
                        if (Hit == 3 || Hit == 6 || Hit == 9 || Hit == 12 || Hit == 15 || Hit == 18 || Hit == 21 || Hit == 24
                            || Hit == 27 || Hit == 30 || Hit == 33 || Hit == 36)
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
