using System;

namespace ChessFigures
{
    internal abstract class ChessFigure
    {
        public abstract bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos);
    }
}