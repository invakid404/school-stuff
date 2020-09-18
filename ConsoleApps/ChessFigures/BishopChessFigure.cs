using System;

namespace ChessFigures
{
    internal class BishopChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var deltaX = Math.Abs(targetPos.Item1 - selfPos.Item1);
            var deltaY = Math.Abs(targetPos.Item2 - selfPos.Item2);

            return deltaX == deltaY;
        }
    }
}