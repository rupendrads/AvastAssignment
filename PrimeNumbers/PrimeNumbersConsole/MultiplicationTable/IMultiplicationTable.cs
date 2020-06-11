using System.Collections.Generic;

namespace PrimeNumbersConsole
{
    public interface IMultiplicationTable
    {
        IList<int> GetTable(int number, int multiplicationCount);
    }
}