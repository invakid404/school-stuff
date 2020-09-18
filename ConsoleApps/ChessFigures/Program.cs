using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureName = Console.ReadLine().ToLower();
            var figure = ChessFigureManager.Instance.GetFigure(figureName);

            var figureX = int.Parse(Console.ReadLine());
            var figureY = int.Parse(Console.ReadLine());

            var figurePos = Tuple.Create(figureX, figureY);

            var targetX = int.Parse(Console.ReadLine());
            var targetY = int.Parse(Console.ReadLine());

            var targetPos = Tuple.Create(targetX, targetY);

            var deltaX = targetX - figureX;
            var deltaY = targetY - figureY;

            Console.WriteLine(figure.Attacks(figurePos, targetPos));

            Console.ReadKey();
        }
    }
}
