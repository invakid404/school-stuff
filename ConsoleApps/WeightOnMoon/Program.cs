using System;

namespace WeightOnMoon
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
            }
            
            Console.WriteLine($@"Weight on moon: {weight * 0.17:0.##} kg");
        }
    }
}