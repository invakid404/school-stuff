using System;

namespace ChessFigures
{
    internal class RookChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var deltaX = targetPos.Item1 - selfPos.Item1;
            var deltaY = targetPos.Item2 - selfPos.Item2;

            return deltaX == 0 || deltaY == 0;
        }
    }
}