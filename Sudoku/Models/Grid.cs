using Sudoku.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Models
{
    // сетка для игры
    public class Grid
    {
        // кол-во строк
        public int TotalRows { get; private set; }
        // кол-во столбцов
        public int TotalColumns { get; private set; }
        // размерность сетки
        public int GridSize { get; private set; }
        // размер подсети
        public int SubGridSize { get; private set; }
        // кол-во ячек
        public int TotalCells { get => TotalRows * TotalColumns; }
        // список ячеек
        public List<Cell> Cells { get; set; }
        // экземпляр решателя
        public Solver Solver { get; }

        // конструктор сетки
        public Grid(int totalRows, int totalColumns)
        {
            TotalRows = totalRows;
            TotalColumns = totalColumns;
            GridSize = Convert.ToInt16(Math.Sqrt(totalRows * totalColumns));
            SubGridSize = Convert.ToInt16(Math.Sqrt(totalRows));
            Cells = new List<Cell>(TotalCells);
            Solver = new Solver(this);
            InitializeCells();
        }

        // проверка сетки на заполненность
        public bool IsGridFilled() => Cells.FirstOrDefault(cell => cell.Value == -1) == null;

        // проверка сетки на пустоту
        public bool IsGridEmpty() => Cells.FirstOrDefault(cell => cell.Value != -1) == null;

        // сброс значений дл -1
        public void Clear() => Cells.ForEach(cell => SetCellValue(-1, cell.Index));

        // получение ячейки
        public Cell GetCell(int cellIndex) => Cells[cellIndex];

        // задание значение ячейки
        public void SetCellValue(int cellIndex, int value) => Cells[cellIndex].Value = value;

        // инициализация ячейки
        private void InitializeCells()
        {
            for (var x = 0; x < TotalRows; x++)
            {
                for (var y = 0; y < TotalColumns; y++)
                {
                    var groupDivider = Convert.ToInt32(Math.Sqrt(TotalRows));
                    Cells.Add(new Cell(
                        index: x * TotalRows + y,
                        value: -1,
                        groupNumber: (x / groupDivider) + groupDivider * (y / groupDivider) + 1,
                        position: new Position(row: x + 1, column: y + 1)
                    ));
                }
            }
        }
    }
}