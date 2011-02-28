using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife.Model
{
    public class GridView
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public IEnumerable<Tuple<int, int>> LiveCells { get; set; }

        public GridView(int length, int height, IEnumerable<Tuple<int, int>> liveCells)
        {
            Width = length;
            Height = height;
            LiveCells = liveCells;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    int xCoord = x;
                    int yCoord = y;
                    sb.Append(LiveCells.Any(cell => cell.Item1 == xCoord && cell.Item2 == yCoord) ? "*" : " ");
                }
                if (y < Height)
                    sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
