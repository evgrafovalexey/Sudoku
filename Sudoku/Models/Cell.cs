namespace Sudoku.Models
{
    /// <summary>
    /// Ячейка для хранения сведений об индексе, значении, номере группы, позиции
    /// </summary>
    public class Cell
    {
        public int Index { get; private set; }

        public int Value { get; set; }

        public int GroupNumber { get; private set; }

        public Position Position { get; private set; }

        // конструктор ячеек
        public Cell(int index, int value, int groupNumber, Position position)
        {
            Index = index;
            Value = value;
            GroupNumber = groupNumber;
            Position = position;
        }
    }
}