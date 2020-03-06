using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Split : Program
    {
        public int SplitBet(int Funds)
        {
            Program p = new Program();

        Bet:
            Console.WriteLine("Pick your first number.");
            string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
            Bet2:
                Console.WriteLine("Pick 2 or 4.");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "2")
                {
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
                            if (Hit == 1 || Hit == 2)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "4")
                {
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
                            if (Hit == 1 || Hit == 4)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                else
                {
                    Console.WriteLine("You can only pick 2 or 4 to pair with 1.");
                    goto Bet2;
                }
            }
            if (UserInput == "2")
            {
            Bet2:
                Console.WriteLine("Pick 1, 3, or 5.");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "1")
                {
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
                            if (Hit == 2 || Hit == 1)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "3")
                {
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
                            if (Hit == 2 || Hit == 3)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "5")
                {
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
                            if (Hit == 2 || Hit == 5)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                else
                {
                    Console.WriteLine("You can only pick 1, 3, or 5 to pair with 2.");
                    goto Bet2;
                }
            }
            if (UserInput == "3")
            {
            Bet2:
                Console.WriteLine("Pick 2 or 6.");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "2")
                {
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
                            if (Hit == 3 || Hit == 2)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "6")
                {
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
                            if (Hit == 3 || Hit == 6)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                else
                {
                    Console.WriteLine("You can only pick 2 or 6 to pair with 3.");
                    goto Bet2;
                }
            }
            if (UserInput == "4" || UserInput == "7" || UserInput == "10" || UserInput == "13" || UserInput == "16" || UserInput == "19"
                || UserInput == "22" || UserInput == "25" || UserInput == "28" || UserInput == "31")
            {
                int.TryParse(UserInput, out int Input);
            Bet2:
                Console.WriteLine($"Pick {Input + 1}, {Input - 3}, or {Input + 3}.");
                string UserInput2 = Console.ReadLine();

                if (int.TryParse(UserInput2, out int Input2))
                {
                    if (Input2 == Input + 1)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input - 3)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input + 3)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                }
                else
                {
                    Console.WriteLine($"You can only pick {Input + 1}, {Input - 3}, or {Input + 3} to pair with {Input}.");
                    goto Bet2;
                }
            }
            if (UserInput == "5" || UserInput == "8" || UserInput == "11" || UserInput == "14" || UserInput == "17" || UserInput == "20"
                || UserInput == "23" || UserInput == "26" || UserInput == "29" || UserInput == "32")
            {
                int.TryParse(UserInput, out int Input);
            Bet2:
                Console.WriteLine($"Pick {Input - 1}, {Input - 3}, {Input + 3}, or {Input + 1}.");
                string UserInput2 = Console.ReadLine();

                if (int.TryParse(UserInput2, out int Input2))
                {
                    if (Input2 == Input - 1)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input - 3)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input + 3)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input + 1)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                }
                else
                {
                    Console.WriteLine($"You can only pick {Input - 1}, {Input - 3}, {Input + 3}, or {Input + 1} to pair with {Input}.");
                    goto Bet2;
                }
            }
            if (UserInput == "6" || UserInput == "9" || UserInput == "12" || UserInput == "15" || UserInput == "18" || UserInput == "21"
                || UserInput == "24" || UserInput == "27" || UserInput == "30" || UserInput == "33")
            {
                int.TryParse(UserInput, out int Input);
            Bet2:
                Console.WriteLine($"Pick {Input - 1}, {Input - 3}, or {Input + 3}.");
                string UserInput2 = Console.ReadLine();

                if (int.TryParse(UserInput2, out int Input2))
                {
                    if (Input2 == Input - 1)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input - 3)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                    if (Input2 == Input + 3)
                    {
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
                                if (Hit == Input || Hit == Input2)
                                {
                                    Console.WriteLine("You won!");
                                    Funds = Funds + Amount * 17;
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
                }
                else
                {
                    Console.WriteLine($"You can only pick {Input - 1}, {Input - 3}, or {Input + 3} to pair with {Input}.");
                    goto Bet2;
                }
            }
            if (UserInput == "34")
            {
            Bet2:
                Console.WriteLine("Pick 35 or 31.");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "35")
                {
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
                            if (Hit == 34 || Hit == 35)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "31")
                {
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
                            if (Hit == 34 || Hit == 31)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                else
                {
                    Console.WriteLine("You can only pick 35 or 31 to pair with 34.");
                    goto Bet2;
                }
            }
            if (UserInput == "35")
            {
            Bet2:
                Console.WriteLine("Pick 32, 34, or 36.");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "32")
                {
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
                            if (Hit == 32 || Hit == 35)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "34")
                {
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
                            if (Hit == 34 || Hit == 35)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "36")
                {
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
                            if (Hit == 35 || Hit == 36)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                else
                {
                    Console.WriteLine("You can only pick 32, 34, or 36 to pair with 35.");
                    goto Bet2;
                }
            }
            if (UserInput == "36")
            {
            Bet2:
                Console.WriteLine("Pick 33 or 35.");
                string UserInput2 = Console.ReadLine();

                if (UserInput2 == "33")
                {
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
                            if (Hit == 33 || Hit == 36)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                if (UserInput2 == "35")
                {
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
                            if (Hit == 35 || Hit == 36)
                            {
                                Console.WriteLine("You won!");
                                Funds = Funds + Amount * 17;
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
                else
                {
                    Console.WriteLine("You can only pick 33 or 35 to pair with 36.");
                    goto Bet2;
                }
            }
            else
            {
                Console.WriteLine("You won't win that way!");
                goto Bet;
            }
            return Funds;
        }
    }
}
