using System;

namespace ChessFigures
{
    internal class QueenChessFigure : ChessFigure
    {
        public override bool Attacks(Tuple<int, int> selfPos, Tuple<int, int> targetPos)
        {
            var manager = ChessFigureManager.Instance;

            return manager.GetFigure("rook").Attacks(selfPos, targetPos) ||
                   manager.GetFigure("bishop").Attacks(selfPos, targetPos);
        }
    }
}