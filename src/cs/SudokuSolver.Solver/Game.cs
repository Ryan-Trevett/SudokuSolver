using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Solver
{
    public class Game
    {
        public Game()
        {
            Board = new Board();
            Groupings = new List<CellGroupingCollection>();
        }

        public Board Board { get; private set; }

        public IList<CellGroupingCollection> Groupings { get; private set; }

        public CellGroupingCollection RowGroupings { get; private set; }

        public CellGroupingCollection ColumnGroupings { get; private set; }

        public CellGroupingCollection RegionGroupings { get; private set; }
    }
}
