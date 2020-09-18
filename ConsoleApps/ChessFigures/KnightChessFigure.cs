using System;

namespace ChessFigures
{
    internal class KnightChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var deltaX = Math.Abs(targetPos.Item1 - selfPos.Item1);
            var deltaY = Math.Abs(targetPos.Item2 - selfPos.Item2);

            return deltaX == 1 && deltaY == 2 || deltaY == 1 && deltaX == 2;
        }
    }
}