namespace GameOfLife.Model
{
    public class Game
    {
        private Grid grid;

        public Game(Grid grid)
        {
            this.grid = grid;
        }

        public string DisplayGrid()
        {
            return grid.CreateView().ToString();
        }

        public void Tick()
        {
            grid = grid.NextGeneration();
        }
    }
}
