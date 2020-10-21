using System;

namespace Evens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 2; i <= 20; i += 2)
            {
                Console.Write($@"{i} ");
            }
            Console.WriteLine();
        }
    }
}
