using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class RandomColor : Program
    {
        public string RandomColorGenerator()
        {
            Random number = new Random();
            int index = number.Next(0, 37);
            string value = Color[index];
            return value;
        }
    }
}
