using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessFigures
{
    abstract class ChessFigure
    {
        public abstract bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos);
    }
}
