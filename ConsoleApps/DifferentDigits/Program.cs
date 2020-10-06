using System;

namespace DifferentDigits
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
            }

            a = Math.Abs(a);

            var b = true;
            var digits = new bool[10];
            while (a != 0)
            {
                var d = a % 10;
                if (digits[d])
                {
                    b = false;
                    break;
                }

                digits[d] = true;
                a /= 10;
            }
            
            Console.WriteLine(b);
        }
    }
}