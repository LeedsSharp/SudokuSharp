using System;

namespace SudokuSharp.ViewModels
{
    public class BoardViewModel
    {
        public BoardViewModel()
        {
            Cells = new CellViewModel[9][];
            for (var x = 0; x < 9; x++)
            {
                Cells[x] = new CellViewModel[9];
                for (var y = 0; y < 9; y++)
                {
                    Cells[x][y] = new CellViewModel() {Number = 2};
                }
            }
        }

        public  CellViewModel[][] Cells { get; private set;}

        public void SetCell(int x, int y, int value)
        {
            if( !(InRange(x, 0, 8) && InRange(y, 0, 8) && InRange(value, 1, 9)) )
                throw new ArgumentException(string.Format("Error Setting cell[{0}][{1}] to {2}.", x, y, value));

            Cells[x][y].Number = value;
        }

        public void Clear()
        {
            for (var x = 0; x < 9; x++)
            {
                for (var y = 0; y < 9; y++)
                {
                    Cells[x][y].Number = null;
                }
            }
        }

        private static bool InRange(int value, int lowBound, int highBound)
        {
            return (value >= lowBound && value <= highBound);
        }

        public void NewPuzzle(int?[,] puzzleData)
        {
            var xLength = puzzleData.GetLength(0);
            var yLength = puzzleData.GetLength(1);
            if(xLength != 9 || yLength != 9) throw new ArgumentException("Puzzle data needs to be 9x9 array");

            for (var x = 0; x < 9; x++)
            {
                for (var y = 0; y < 9; y++)
                {
                    Cells[x][y].Number = puzzleData[x,y];
                }
            }
        }
    }
}