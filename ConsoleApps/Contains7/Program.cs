using System;

namespace Contains7
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
            
            var b = false;
            while (a != 0)
            {
                var d = a % 10;
                if (d == 7)
                {
                    b = true;
                    break;
                }
                
                a /= 10;
            }
            
            Console.WriteLine(b);
        }
    }
}