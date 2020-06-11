using System.Collections.Generic;

namespace PrimeNumbersConsole
{
    public interface IGridTable
    {
        IList<GridTableModel> GetGridTable(int number);
    }
}