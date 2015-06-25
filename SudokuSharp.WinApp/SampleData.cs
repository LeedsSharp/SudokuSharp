using System.Collections.Generic;


// ReSharper disable ExpressionIsAlwaysNull

namespace SudokuSharp.WinApp
{
    internal static class SampleData
    {
        static SampleData()
        {
            int? _ = null;
            StarterPuzzles = new List<int?[,]>
            {
                new int?[9, 9]
                {
                    
                    {_, _, 2, _, _, _, 8, _, _},
                    {1, _, _, 2, _, _, _, 4, _},
                    {3, _, 6, 8, _, _, 7, 2, _},
                    {_, _, 5, 3, _, _, _, _, 8},
                    {_, 2, _, _, _, _, _, 9, _},
                    {6, _, _, _, _, 1, 5, _, _},
                    {_, 5, 7, _, _, 3, 2, _, 1},
                    {_, 1, _, _, _, 7, _, _, 6},
                    {_, _, 3, _, _, _, 4, _, _}
                },
                new int?[9, 9]
                {
                    {_, _, _, _, _, _, 9, 8, _},
                    {_, 6, _, _, _, _, 3, _, 5},
                    {7, _, _, 3, _, 1, 6, _, _},
                    {8, _, _, _, 9, 7, _, 3, _},
                    {_, _, _, _, 8, _, _, _, _},
                    {_, 5, _, 6, 1, _, _, _, 8},
                    {_, _, 3, 5, _, 9, _, _, 6},
                    {5, _, 1, _, _, _, _, 2, _},
                    {_, 4, 9, _, _, _, _, _, _}
                }
            };


        }

        public static List<int?[,]> StarterPuzzles;
    }
}