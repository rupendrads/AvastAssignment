using System.Collections.Generic;

namespace PrimeNumbersConsole
{
    public class PrimeNumbers: IPrimeNumbers
    {
        private readonly IPrimeNumber _primeNumber;

        public PrimeNumbers(IPrimeNumber primeNumber)
        {            
            _primeNumber = primeNumber;
        }

        public IList<int> GetPrimeNumbers(int number)
        {
            bool isPrime;
            IList<int> primeNumbers = new List<int>();

            int i = 1;
            while(number > 0)
            {
                isPrime = _primeNumber.IsPrime(i);
                if(isPrime)
                {
                    primeNumbers.Add(i);
                    number--;                    
                }
                i++;
            }

            return primeNumbers;
        }
    }
}