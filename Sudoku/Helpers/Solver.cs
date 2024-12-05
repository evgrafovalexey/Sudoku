using Sudoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Helpers
{
    /// <summary>
    /// Solver Class для решения игры 
    /// </summary>
    public class Solver
    {
        /// <summary>
        /// Экземпляр сетки.
        /// </summary>
        readonly Grid grid;
        /// <summary>
        /// Индексы ячеек, исключающие возможность обратного отслеживания
        /// </summary>
        private readonly List<int> filledCells = new List<int>();
        /// <summary>
        /// Индексы ячеек с недопустимыми значениями, используемыми в процессе обратного отслеживания
        /// </summary>
        private List<List<int>> blackListCells;
        /// <summary>
        /// Случайный объект, используемый для создания случайных чисел
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Solver Constructor
        /// </summary>
        /// <param name="gridInstance">The grid instance.</param>
        public Solver(Grid gridInstance)
        {
            grid = gridInstance ?? new Grid(4, 4);
            InitializeBlackList();
        }

        /// <summary>
        /// решает игры
        /// </summary>
        /// <returns><c>true</c> if the sudoku gird is solved; otherwise, <c>false</c>.</returns>
        public bool Solve()
        {
            // Возвращает значение false, если текущая таблица недействительна
            if (!ValidateGrid()) return false;

            // Инициализируйте заполненные ячейки, чтобы сохранить те, которые будут использоваться при обратном отслеживании
            IntializeFilledCells();

            // Очистите черный список
            ClearBlackList();

            int currentCellIndex = 0;

            // выполнение итерации по всем ячейкам
            while (currentCellIndex < grid.TotalCells)
            {
                // если текущий индекс ячейки уже сохранен в заполненных ячейках, передайте его
                if (filledCells.Contains(currentCellIndex))
                {
                    ++currentCellIndex;
                    continue;
                }

                // очистка чс индексов после текущего индекса
                ClearBlackList(cleaningStartIndex: currentCellIndex + 1);

                Cell currentCell = grid.GetCell(cellIndex: currentCellIndex);

                int foundNumber = GetValidNumberForTheCell(currentCellIndex);

                
                if (foundNumber == 0)
                    currentCellIndex = BackTrackTo(currentCellIndex);
                else
                {
                  
                    grid.SetCellValue(currentCell.Index, foundNumber);
                    ++currentCellIndex;
                }
            }

            return true;
        }

        /// <summary>
        /// проверка сетки на действительность
        /// </summary>
        /// <param name="ignoreEmptyCells">игнорирование пустых ячеек</param>
        /// <returns><c>true</c> if the grid is valid; otherwise, <c>false</c>.</returns>
        public bool ValidateGrid(bool ignoreEmptyCells = false) =>
            grid.Cells.Where(cell => cell.Value != -1)
            .FirstOrDefault(cell => cell.Value != -1 && !IsValidValueForTheCell(cell.Value, cell)) == null;

        /// <summary>
        /// проверка значения ячейки
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="cell">The cell.</param>
        /// <returns><c>true</c> if the value is valid for the cell; otherwise, <c>false</c>.</returns>
        public bool IsValidValueForTheCell(int value, Cell cell)
        {
            var matchedCell = grid.Cells
                .Where(cellItem => cellItem.Index != cell.Index && (cellItem.GroupNumber == cell.GroupNumber
                || cellItem.Position.Row == cell.Position.Row || cellItem.Position.Column == cell.Position.Column))
                .FirstOrDefault(prop => prop.Value == value);

            return matchedCell == null;
        }

        /// <summary>
        /// инициализация заполненных ячеек, для сохранения
        /// </summary>
        private void IntializeFilledCells()
        {
            filledCells.Clear();
            filledCells.AddRange(grid.Cells.FindAll(cell => cell.Value != -1).Select(cell => cell.Index));
        }

        /// <summary>
        /// инициализация чс
        /// </summary>
        private void InitializeBlackList()
        {
            blackListCells = new List<List<int>>(grid.TotalCells);
            for (int index = 0; index < blackListCells.Capacity; index++)
                blackListCells.Add(new List<int>());
        }

        /// <summary>
        /// операция обратного отслеживания
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>BackTrack To Index.</returns>
        private int BackTrackTo(int index)
        {
            // проход мимо защищенных ячеек
            while (filledCells.Contains(--index)) ;
             Cell backTrackedCell = grid.GetCell(index);
            AddToBlacklist(backTrackedCell.Value, cellIndex: index);

            // сброс значения ячейки
            backTrackedCell.Value = -1;

            // сброс чс со след ячейки
            ClearBlackList(cleaningStartIndex: index + 1);

            return index;
        }

        /// <summary>
        /// Возвращает действительное число для указанного индекса ячейки
        /// </summary>
        /// <param name="cellIndex">The cell index.</param>
        /// <returns>Valid Number for the cell index.</returns>
        private int GetValidNumberForTheCell(int cellIndex)
        {
            int foundNumber = 0;
            var possibleNumbers = Enumerable.Range(1, grid.GridSize).ToList();
            var validNumbers = possibleNumbers.Where(val => !blackListCells[cellIndex].Contains(val)).ToArray();

            if (validNumbers.Length > 0)
            {
                int choosenIndex = random.Next(validNumbers.Length);
                foundNumber = validNumbers[choosenIndex];
            }

            do
            {
                Cell currentCell = grid.GetCell(cellIndex);
             
                if (foundNumber != 0 && !grid.Solver.IsValidValueForTheCell(foundNumber, currentCell))
                    AddToBlacklist(foundNumber, cellIndex);
                else
                    break;

                // Get a valid (random) value from valid numbers.
                foundNumber = GetValidNumberForTheCell(cellIndex: cellIndex);
            } while (foundNumber != 0);

            return foundNumber;
        }

        /// <summary>
        /// Добавление значения в указанный индекс чс
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="cellIndex">The cell index.</param>
        private void AddToBlacklist(int value, int cellIndex) => blackListCells[cellIndex].Add(value);

        /// <summary>
        /// очистка чс
        /// </summary>
        /// <param name="cleaningStartIndex">очистка остальной части</param>
        private void ClearBlackList(int cleaningStartIndex = 0)
        {
            for (int index = cleaningStartIndex; index < blackListCells.Count; index++)
                blackListCells[index].Clear();
        }
    }
}