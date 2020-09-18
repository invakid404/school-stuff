using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessFigures
{
    class KingChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var deltaX = targetPos.Item1 - selfPos.Item1;
            var deltaY = targetPos.Item2 - selfPos.Item2;

            return (-1 <= deltaX && deltaX <= 1) && (-1 <= deltaY && deltaY <= 1);
        }
    }
}
