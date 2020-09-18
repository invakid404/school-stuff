using System;

namespace ChessFigures
{
    internal static class Program
    {
        private static void Main()
        {
            var figureName = Console.ReadLine()?.ToLower();
            var figure = ChessFigureManager.Instance.GetFigure(figureName);

            var figurePos = ReadTuple();
            var targetPos = ReadTuple();
            
            Console.WriteLine(figure.Attacks(figurePos, targetPos));
        }

        private static int ReadInt()
        {
            var str = Console.ReadLine();
            return int.Parse(str ?? "0");
        }

        private static Tuple<int, int> ReadTuple()
        {
            return Tuple.Create(ReadInt(), ReadInt());
        }
    }
}