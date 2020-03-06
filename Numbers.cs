using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Numbers : Program
    {
        public int NumbersBet(int Funds)
        {
        Bet:
            Console.WriteLine("What number do you want to bet on?");
            if (int.TryParse(Console.ReadLine(), out int Bet))
            {
                for (int i = 0; i < Number.Length; i++)
                {
                    if (Number[i] == Bet)
                    {
                        goto Amount;
                    }
                }
                if (Bet > 36 || Bet < 1)
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

            Console.WriteLine($"We landed on {Hit}!");
            if (Hit == 0 || Hit == 00)
            {
                Console.WriteLine("Reroll.");
                goto Bet;
            }
            if (Hit == Bet)
            {
                Console.WriteLine("You won!");
                Funds = Funds + Amount * 35;
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
