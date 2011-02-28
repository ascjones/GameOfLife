using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Model
{
    public class Grid
    {
        private readonly int width;
        private readonly int height;
        private readonly IEnumerable<Tuple<int, int>> liveCells;

        public Grid(int width, int height, IEnumerable<Tuple<int, int>> liveCells)
        {
            this.width = width;
            this.height = height;
            this.liveCells = liveCells.ToList();
        }

        public Grid NextGeneration()
        {
            var survivingCells =
                from liveCell in liveCells
                let noOfNeighbours = NeighbourCount(liveCell)
                where noOfNeighbours == 2 || noOfNeighbours == 3
                select liveCell;

            var resurrectedCells =
                from x in Enumerable.Range(0, width)
                from y in Enumerable.Range(0, height)
                let cell = new Tuple<int, int>(x, y)
                where
                    liveCells.Contains(cell) == false &&
                    NeighbourCount(cell) == 3
                select cell;

            var nextGenCells = survivingCells.Concat(resurrectedCells);

            return new Grid(width, height, nextGenCells);
        }

        private int NeighbourCount(Tuple<int, int> theCell)
        {
            var neighbours =
                from cell in liveCells
                where
                    cell != theCell &&
                    Math.Abs(theCell.Item1 - cell.Item1) <= 1 &&
                    Math.Abs(theCell.Item2 - cell.Item2) <= 1
                select cell;
            return neighbours.Count();
        }

        public GridView CreateView()
        {
            return new GridView(width, height, liveCells);
        }
    }
}
