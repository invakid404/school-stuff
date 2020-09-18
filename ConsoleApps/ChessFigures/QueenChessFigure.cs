using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessFigures
{
    class QueenChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var deltaX = targetPos.Item1 - selfPos.Item1;
            var deltaY = targetPos.Item2 - selfPos.Item2;

            if (deltaX == 0 || deltaY == 0)
            {
                return true;
            }

            return Math.Abs(deltaX) == Math.Abs(deltaY);
        }
    }
}
