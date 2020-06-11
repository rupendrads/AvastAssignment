namespace PrimeNumbersConsole
{
    public class PrimeNumberSimple : IPrimeNumber
    {
        public bool IsPrime(int number)
        {
            bool isPrime = true;
            
            if(number == 1)
            {
                isPrime = false;
                return isPrime;
            }

            for(int i = 2; i < number -1; i++)
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}