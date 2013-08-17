using System.Collections.Generic;

namespace SudokuSolver.Solver
{
    public class CellGroupingCollection
    {
        public CellGroupingCollection()
        {
            CellGroupings = new List<CellGrouping>();
        }

        public IList<CellGrouping> CellGroupings { get; private set; }
    }
}