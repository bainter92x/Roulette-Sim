using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Corner : Program
    {
        public int CornerBet(int Funds)
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
        Bet:
            Console.WriteLine("Pick a number to see the possible corners.");
            string Pick = Console.ReadLine().ToLower();

            if (Pick == "1")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"1 Corner of {i}, {i + 1}, {i + 3}, and {i + 4}.");

                RandomNumber r = new RandomNumber();
                int Hit = r.RandomNumberGenerator();

                Console.WriteLine($"We landed on {Hit}!");
                if (Hit == 0 || Hit == 00)
                {
                    Console.WriteLine("Reroll.");
                    goto Bet;
                }
                if (Hit == i || Hit == i + 1 || Hit == i + 3 || Hit == i + 4)
                {
                    Console.WriteLine("You won!");
                    Funds = Funds + Amount * 8;
                    return Funds;
                }
                else if (Hit != i || Hit != i + 1 || Hit != i + 3 || Hit != i + 4)
                {
                    Console.WriteLine("You lost...");
                    Funds = Funds - Amount;
                    return Funds;
                }
            }
            if (Pick == "2")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"2 Corners. Press 1 for {i}, {i + 1}, {i + 3}, and {i + 4}." +
                    $"Press 2 for {i - 1}, {i}, {i + 2}, and {i + 3}.");

                string CornerPick = Console.ReadLine();

                if (CornerPick == "1")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i || Hit == i + 1 || Hit == i + 3 || Hit == i + 4)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "2")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 1 || Hit == i || Hit == i + 2 || Hit == i + 3)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                else
                {
                    Console.WriteLine("You won't win that way!");
                    goto Bet;
                }
            }
            if (Pick == "3")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"1 Corner of {i - 1}, {i}, {i + 2}, and {i + 3}.");

                RandomNumber r = new RandomNumber();
                int Hit = r.RandomNumberGenerator();

                Console.WriteLine($"We landed on {Hit}!");
                if (Hit == 0 || Hit == 00)
                {
                    Console.WriteLine("Reroll.");
                    goto Bet;
                }
                if (Hit == i - 1 || Hit == i || Hit == i + 2 || Hit == i + 3)
                {
                    Console.WriteLine("You won!");
                    Funds = Funds + Amount * 8;
                    return Funds;
                }
                else
                {
                    Console.WriteLine("You lost...");
                    Funds = Funds - Amount;
                    return Funds;
                }
            }
            if (Pick == "34")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"1 Corner of {i - 3}, {i - 2}, {i}, and {i + 1}.");

                RandomNumber r = new RandomNumber();
                int Hit = r.RandomNumberGenerator();

                Console.WriteLine($"We landed on {Hit}!");
                if (Hit == 0 || Hit == 00)
                {
                    Console.WriteLine("Reroll.");
                    goto Bet;
                }
                if (Hit == i - 3 || Hit == i - 2 || Hit == i || Hit == i + 1)
                {
                    Console.WriteLine("You won!");
                    Funds = Funds + Amount * 8;
                    return Funds;
                }
                else
                {
                    Console.WriteLine("You lost...");
                    Funds = Funds - Amount;
                    return Funds;
                }
            }
            if (Pick == "35")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"2 Corners. Press 1 for {i - 3}, {i - 2}, {i}, and {i + 1}." +
                    $"Press 2 for {i - 4}, {i - 3}, {i - 1}, and {i}.");

                string CornerPick = Console.ReadLine();

                if (CornerPick == "1")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 3 || Hit == i - 2 || Hit == i || Hit == i + 1)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "2")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 4 || Hit == i - 3 || Hit == i - 1 || Hit == i)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                else
                {
                    Console.WriteLine("You won't win that way!");
                    goto Bet;
                }
            }
            if (Pick == "36")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"1 Corner of {i - 4}, {i - 3}, {i - 1}, and {i}.");

                RandomNumber r = new RandomNumber();
                int Hit = r.RandomNumberGenerator();

                Console.WriteLine($"We landed on {Hit}!");
                if (Hit == 0 || Hit == 00)
                {
                    Console.WriteLine("Reroll.");
                    goto Bet;
                }
                if (Hit == i - 4 || Hit == i - 3 || Hit == i - 1 || Hit == i)
                {
                    Console.WriteLine("You won!");
                    Funds = Funds + Amount * 8;
                    return Funds;
                }
                else
                {
                    Console.WriteLine("You lost...");
                    Funds = Funds - Amount;
                    return Funds;
                }
            }
            if (Pick == "4" || Pick == "7" || Pick == "10" || Pick == " 13" || Pick == "16" || Pick == "19" || Pick == "22" || Pick == "25"
                || Pick == "28" || Pick == "31")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"2 Corners. Press 1 for {i}, {i + 1}, {i + 3}, and {i + 4}." +
                    $"Press 2 for {i - 3}, {i - 2}, {i}, and {i + 1}.");

                string CornerPick = Console.ReadLine();

                if (CornerPick == "1")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i || Hit == i + 1 || Hit == i + 3 || Hit == i + 4)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "2")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 3 || Hit == i - 2 || Hit == i || Hit == i + 1)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                else
                {
                    Console.WriteLine("You won't win that way!");
                    goto Bet;
                }
            }
            if (Pick == "5" || Pick == "8" || Pick == "11" || Pick == " 14" || Pick == "17" || Pick == "20" || Pick == "23" || Pick == "26"
                || Pick == "29" || Pick == "32")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"4 Corners. Press 1 for {i}, {i + 1}, {i + 3}, and {i + 4}." +
                    $"Press 2 for {i - 1}, {i}, {i + 2}, and {i + 3}. Press 3 for {i - 3}, {i - 2}, {i}, and {i + 1}." +
                    $"Press 4 for {i - 4}, {i - 3}, {i - 1}, and {i}.");

                string CornerPick = Console.ReadLine();

                if (CornerPick == "1")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i || Hit == i + 1 || Hit == i + 3 || Hit == i + 4)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "2")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 1 || Hit == i || Hit == i + 2 || Hit == i + 3)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "3")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 3 || Hit == i - 2 || Hit == i || Hit == i + 1)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "4")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 4 || Hit == i - 3 || Hit == i - 1 || Hit == i)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                else
                {
                    Console.WriteLine("You won't win that way!");
                    goto Bet;
                }
            }
            if (Pick == "6" || Pick == "9" || Pick == "12" || Pick == " 15" || Pick == "18" || Pick == "21" || Pick == "24" || Pick == "27"
                || Pick == "30" || Pick == "33")
            {
                int i = int.Parse(Pick);
                Console.WriteLine($"2 Corners. Press 1 for {i - 1}, {i}, {i + 2}, and {i + 3}." +
                    $"Press 2 for {i - 4}, {i - 3}, {i - 1}, and {i}.");

                string CornerPick = Console.ReadLine();

                if (CornerPick == "1")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 1 || Hit == i || Hit == i + 2 || Hit == i + 3)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                if (CornerPick == "2")
                {
                    RandomNumber r = new RandomNumber();
                    int Hit = r.RandomNumberGenerator();

                    Console.WriteLine($"We landed on {Hit}!");
                    if (Hit == 0 || Hit == 00)
                    {
                        Console.WriteLine("Reroll.");
                        goto Bet;
                    }
                    if (Hit == i - 4 || Hit == i - 3 || Hit == i - 1 || Hit == i)
                    {
                        Console.WriteLine("You won!");
                        Funds = Funds + Amount * 8;
                        return Funds;
                    }
                    else
                    {
                        Console.WriteLine("You lost...");
                        Funds = Funds - Amount;
                        return Funds;
                    }
                }
                else
                {
                    Console.WriteLine("You won't win that way!");
                    goto Bet;
                }
            }
            else
            {
                Console.WriteLine("You won't win that way!");
                goto Bet;
            }
        }
    }
}
