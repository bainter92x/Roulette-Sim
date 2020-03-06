using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class SixNumbers : Program
    {
        public int SixNumbersBet(int Funds)
        {
        Bet:
            Console.WriteLine("Pick 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, or 34 Streets for your first street.");
            string UserInput = Console.ReadLine().ToLower();

            if (UserInput == "1" || UserInput == "4" || UserInput == "7" || UserInput == "10" || UserInput == "13" || UserInput == "16"
                || UserInput == "19" || UserInput == "22" || UserInput == "25" || UserInput == "28" || UserInput == "31" || UserInput == "34")
            {
                goto Bet2;
            }
            else
            {
                Console.WriteLine("You won't win that way!");
                goto Bet;
            }

        Bet2:
            Console.WriteLine("Pick your second.");
            string UserInput2 = Console.ReadLine().ToLower();

            if (UserInput == "1")
            {
                if (UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "4")
            {
                if (UserInput2 == "1" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "7")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "10")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "13")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "16")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" 
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "19")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    ||  UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "22")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" ||  UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "25")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "28" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "28")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "31"
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "31")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" 
                    || UserInput2 == "34")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
            }
            if (UserInput == "34")
            {
                if (UserInput2 == "1" || UserInput2 == "4" || UserInput2 == "7" || UserInput2 == "10" || UserInput2 == "13" || UserInput2 == "16"
                    || UserInput2 == "19" || UserInput2 == "22" || UserInput2 == "25" || UserInput2 == "28" || UserInput2 == "31")
                {
                    goto Amount;
                }
                else
                {
                    Console.WriteLine("You won't win thay way!");
                    goto Bet2;
                }
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

            if (UserInput == "1" || UserInput2 == "1")
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
                        if (Hit == 1 || Hit == 2 || Hit == 3)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "4" || UserInput2 == "4")
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
                        if (Hit == 4 || Hit == 5 || Hit == 6)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "7" || UserInput2 == "7")
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
                        if (Hit == 7 || Hit == 8 || Hit == 9)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "10" || UserInput2 == "10")
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
                        if (Hit == 10 || Hit == 11 || Hit == 12)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "13" || UserInput2 == "13")
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
                        if (Hit == 13 || Hit == 14 || Hit == 15)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "16" || UserInput2 == "16")
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
                        if (Hit == 16 || Hit == 17 || Hit == 18)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "19" || UserInput2 == "19")
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
                        if (Hit == 19 || Hit == 22 || Hit == 25)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "22" || UserInput2 == "22")
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
                        if (Hit == 22 || Hit == 23 || Hit == 24)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "25" || UserInput2 == "25")
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
                        if (Hit == 25 || Hit == 26 || Hit == 27)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "28" || UserInput2 == "28")
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
                        if (Hit == 28 || Hit == 29 || Hit == 30)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "31" || UserInput2 == "31")
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
                        if (Hit == 31 || Hit == 32 || Hit == 33)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
            if (UserInput == "34" || UserInput2 == "34")
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
                        if (Hit == 34 || Hit == 35 || Hit == 36)
                        {
                            Console.WriteLine("You won!");
                            Funds = Funds + Amount * 5;
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
