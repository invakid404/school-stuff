using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    static internal class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var y);

            var x = Math.Round(y);
            // x = Math.Floor(y + 0.5);
            Console.WriteLine(x);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}
