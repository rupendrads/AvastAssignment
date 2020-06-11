using System.Collections.Generic;

namespace PrimeNumbersConsole
{
    public interface IPrimeNumbers
    {
        IList<int> GetPrimeNumbers(int number);
    }
}