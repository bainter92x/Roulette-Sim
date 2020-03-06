using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

    public class Program
    {
        public int[] Number = { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
        17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        public string[] Color = { "0", "00", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black",
        "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black",
        "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red" };
        static void Main(string[] args)
        {
            int Funds = 500;

            do
            {
            Start:
                Console.WriteLine($"You have ${Funds}.");

                Console.WriteLine("Place your bet!");

                Console.WriteLine("[1 for Numbers]-[2 for Evens/Odds]-[3 for Reds/Blacks]-[4 for Lows/Highs]-[5 for Dozens]\n" +
                    "[6 for Columns]-[7 for Street]-[8 for 6 Numbers]-[9 for Split]-[10 for Corner]-[0 to Quit]");
                string UserInput = Console.ReadLine();

                if (UserInput == "1")
                {
                    Console.WriteLine("The payout is 35:1.");
                    Numbers n = new Numbers();
                    Funds = n.NumbersBet(Funds);
                }
                if (UserInput == "2")
                {
                    Console.WriteLine("The payout is 1:1.");
                    EvensOdds e = new EvensOdds();
                    Funds = e.EvensOddsBet(Funds);
                }
                if (UserInput == "3")
                {
                    Console.WriteLine("The payout is 1:1.");
                    RedsBlacks r = new RedsBlacks();
                    Funds = r.RedsBlacksBet(Funds);
                }
                if (UserInput == "4")
                {
                    Console.WriteLine("The payout is 1:1.");
                    LowsHighs l = new LowsHighs();
                    Funds = l.LowsHighsBet(Funds);
                }
                if (UserInput == "5")
                {
                    Console.WriteLine("The payout is 2:1.");
                    Dozens d = new Dozens();
                    Funds = d.DozensBet(Funds);
                }
                if (UserInput == "6")
                {
                    Console.WriteLine("The payout is 2:1.");
                    Columns c = new Columns();
                    Funds = c.ColumnsBet(Funds);
                }
                if (UserInput == "7")
                {
                    Console.WriteLine("The payout is 11:1.");
                    Street s = new Street();
                    Funds = s.StreetBet(Funds);
                }
                if (UserInput == "8")
                {
                    Console.WriteLine("The payout is 5:1.");
                    SixNumbers s = new SixNumbers();
                    Funds = s.SixNumbersBet(Funds);
                }
                if (UserInput == "9")
                {
                    Console.WriteLine("The payout is 17:1.");
                    Split s = new Split();
                    Funds = s.SplitBet(Funds);
                }
                if (UserInput == "10")
                {
                    Console.WriteLine("The payout is 8:1.");
                    Corner c = new Corner();
                    Funds = c.CornerBet(Funds);
                }
                if (UserInput == "0")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
                else
                {
                    if (Funds == 0)
                    {
                        Console.WriteLine("No money!? You don't have to go home, but you can't stay here...");
                        Environment.Exit(0);
                    }
                    goto Start;
                }
            }
            while (Funds >= 1);
        }
    }
}