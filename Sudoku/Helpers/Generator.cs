using Sudoku.Constants;
using Sudoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Helpers
{
    /// <summary>
    /// Класс Generator используется для генерации сетки судоку.
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Экземпляр сетки.
        /// </summary>
        readonly Grid grid;
        /// <summary>
        /// Режим
        /// </summary>
        private readonly string mode;
        /// <summary>
        /// Экземпляр решателя.
        /// </summary>
        private readonly Solver solver;
        /// <summary>
        /// Случайный объект для использования при создании случайных чисел.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Generator Constructor
        /// </summary>
        /// <param name="gridInstance">The grid instance.</param>
        public Generator(Grid gridInstance, string gridMode)
        {
            grid = gridInstance ?? new Grid(4, 4);
            mode = gridMode;
            solver = new Solver(grid);
        }

        /// <summary>
        /// Генерирует сетку .
        /// </summary>
        /// <returns><c>true</c> if the sudoku grid is generated; otherwise, <c>false</c>.</returns>
        public bool Generate()
        {
            solver.Solve();
            GenerateGrid();

            return true;
        }

        /// <summary>
        /// Создание сетки с несколькими пустыми ячейками
        /// </summary>
        private void GenerateGrid()
        {
            var cellValueIndexes = (mode, grid.GridSize) switch
            {
                (FormConstants.Hard, 9) => GenerateRandomIndexes(random.Next(16, 24)),
                (FormConstants.Medium, 9) => GenerateRandomIndexes(random.Next(24, 31)),
                (FormConstants.Easy, 9) => GenerateRandomIndexes(random.Next(31, 39)),
                (FormConstants.Hard, 4) => GenerateRandomIndexes(random.Next(1, 4)),
                (FormConstants.Medium, 4) => GenerateRandomIndexes(random.Next(4, 7)),
                _ => GenerateRandomIndexes(random.Next(5, 9))
            };

            grid.Cells.ForEach(cell => cell.Value = !cellValueIndexes.Contains(cell.Index) ? -1 : cell.Value);
        }

        /// <summary>
        /// Генерация случ значений, содержащихся в ячейках сетки
        /// </summary>
        /// <param name="requiredNumbers"></param>
        /// <returns></returns>
        private List<int> GenerateRandomIndexes(int requiredNumbers)
        {
            return Enumerable.Range(0, requiredNumbers).Select(x => random.Next(0, grid.TotalCells)).ToList();
        }
    }
}