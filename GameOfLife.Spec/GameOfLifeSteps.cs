using System;
using System.Collections.Generic;
using GameOfLife.Model;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GameOfLife.Spec
{
    [Binding]
    public class GameOfLifeSteps
    {
        private Game game;

        [Given(@"a game of life grid")]
        public void GivenAGameOfLifeBoard(Table grid)
        {
            var seedGrid = CreateGridFromTable(grid);
            game = new Game(seedGrid);
        }

        [When(@"the next generation")]
        public void WhenTheNextGeneration()
        {
            game.Tick();
        }

        [Then(@"the grid should be")]
        public void TheGridShouldBe(Table grid)
        {
            var expectedGrid = CreateGridFromTable(grid);
            var expected = expectedGrid.CreateView().ToString();
            var actual = game.DisplayGrid();

            Console.WriteLine("Expected grid:");
            Console.WriteLine(expected);

            Console.WriteLine("Actual grid:");
            Console.WriteLine(actual);

            Assert.That(actual, Is.EqualTo(expected));
        }

        private static Grid CreateGridFromTable(Table grid)
        {
            int xDim = grid.Rows[0].Count;
            int yDim = grid.RowCount;
            var liveCells = new List<Tuple<int, int>>();

            for (int y = 0; y < grid.Rows.Count; y++)
            {
                for (int x = 0; x < grid.Rows[y].Count; x++)
                {
                    string cell = grid.Rows[y][x];
                    if (cell.Contains("*"))
                    {
                        liveCells.Add(new Tuple<int, int>(x, y));
                    }
                }
            }
            return new Grid(xDim, yDim, liveCells);
        }
    }
}