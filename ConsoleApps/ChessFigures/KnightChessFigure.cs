using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessFigures
{
    class KnightChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var deltaX = Math.Abs(targetPos.Item1 - selfPos.Item1);
            var deltaY = Math.Abs(targetPos.Item2 - selfPos.Item2);

            if (deltaX > deltaY)
            {
                var tmp = deltaX;
                deltaX = deltaY;
                deltaY = tmp;
            }

            return deltaX == 1 && deltaY == 2;
        }
    }
}
