using System.Collections.Generic;

namespace PrimeNumbersConsole
{
    public class GridTable: IGridTable
    {    
        private readonly IPrimeNumbers _primeNumbers;
        private readonly IMultiplicationTable _multiplicationTable;

        public GridTable(IPrimeNumbers primeNumbers, IMultiplicationTable multiplicationTable)
        {
            _primeNumbers = primeNumbers;            
            _multiplicationTable = multiplicationTable;
        }

        public IList<GridTableModel> GetGridTable(int number)
        {
            IList<GridTableModel> grid = new List<GridTableModel>();

            IList<int> primes = _primeNumbers.GetPrimeNumbers(number);

            foreach(int i in primes)
            {
                grid.Add(new GridTableModel {
                            number = i,
                            tableNumbers = _multiplicationTable.GetTable(i, number)
                        }                    
                    );
            }

            return grid;
        }
    }
}