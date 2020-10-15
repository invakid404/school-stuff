using System;

namespace Years
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int years;
            while (!int.TryParse(Console.ReadLine(), out years))
            {
            }

            var days = years * 365;
            var hours = days * 24;
            var minutes = hours * 60;
            
            Console.WriteLine($@"Days: {days}, hours: {hours}, minutes: {minutes}");
        }
    }
}