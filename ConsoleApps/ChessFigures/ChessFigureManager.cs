using System.Collections.Generic;

namespace ChessFigures
{
    internal class ChessFigureManager
    {
        private readonly Dictionary<string, ChessFigure> _figureInstances = new Dictionary<string, ChessFigure>();

        static ChessFigureManager()
        {
        }

        private ChessFigureManager()
        {
            _figureInstances.Add("king", new KingChessFigure());
            _figureInstances.Add("rook", new RookChessFigure());
            _figureInstances.Add("knight", new KnightChessFigure());
            _figureInstances.Add("bishop", new BishopChessFigure());
            _figureInstances.Add("queen", new QueenChessFigure());
        }

        public static ChessFigureManager Instance { get; } = new ChessFigureManager();

        public ChessFigure GetFigure(string name)
        {
            return _figureInstances[name];
        }
    }
}