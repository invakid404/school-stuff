using System;

namespace FactorialZeros
{
    static internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }

            var res = 0;
            while (n > 0)
            {
                n /= 5;
                res += n;
            }

            Console.WriteLine(res);
        }
    }
}
