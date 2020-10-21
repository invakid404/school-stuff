using System;

namespace Pow2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n = 1D;
            for (var i = 0; i < 50; i++)
            {
                Console.WriteLine(n);
                n *= 2;
            }
        }
    }
}
