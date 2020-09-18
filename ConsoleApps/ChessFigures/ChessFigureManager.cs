using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessFigures
{
    class ChessFigureManager
    {
        private static readonly ChessFigureManager instance = new ChessFigureManager();

        private Dictionary<string, ChessFigure> figureInstances = new Dictionary<string, ChessFigure>();

        static ChessFigureManager()
        {
        }

        private ChessFigureManager()
        {
            this.figureInstances.Add("king", new KingChessFigure());
            this.figureInstances.Add("rook", new RookChessFigure());
            this.figureInstances.Add("knight", new KnightChessFigure());
            this.figureInstances.Add("queen", new QueenChessFigure());
        }

        public ChessFigure GetFigure(string name)
        {
            return this.figureInstances[name];
        }

        public static ChessFigureManager Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
