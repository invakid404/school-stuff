using System;

namespace FahrenheitToCelsius
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double fahrenheitT;
            while (!double.TryParse(Console.ReadLine(), out fahrenheitT))
            {
            }

            var celsiusT = (fahrenheitT - 32) * 5 / 9;
            Console.WriteLine($@"Temperature in Celsius: {celsiusT:0.##}");
        }
    }
}