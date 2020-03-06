using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class RandomNumber : Program
    {
        public int RandomNumberGenerator()
        {
            Random number = new Random();
            int index = number.Next(0, 37);
            int value = Number[index];
            return value;
        }
    }
}
