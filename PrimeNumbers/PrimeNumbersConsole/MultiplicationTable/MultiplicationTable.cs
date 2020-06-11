using System.Collections.Generic;

namespace PrimeNumbersConsole
{
    public class MultiplicationTable : IMultiplicationTable
    {
        public IList<int> GetTable(int number, int multiplicationCount)
        {
            IList<int> table= new List<int>();

            for(int i = 1; i <= multiplicationCount; i++)
            {
                table.Add(number * i);
            }

            return table;
        }
    }
}