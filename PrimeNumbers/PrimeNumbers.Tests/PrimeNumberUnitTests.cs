using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbersConsole;
using Moq;

namespace PrimeNumbers.Tests
{
    [TestClass]
    public class PrimeNumberUnitTests
    {        
        [TestMethod]
        public void IsPrimeNumber_Should_Return_False_If_Number_Is_NOT_Prime()
        {
            // Arrange
            int number = 4;
            IPrimeNumber primeNumber = new PrimeNumberSimple();

            // Act
            bool isPrimeNo = primeNumber.IsPrime(number);

            // Assert
            Assert.IsFalse(isPrimeNo);
        }

        [TestMethod]
        public void IsPrimeNumber_Should_Return_True_If_Number_Is_Prime()
        {
            // Arrange
            int number = 5;            
            IPrimeNumber primeNumber = new PrimeNumberSimple();

            // Act
            bool isPrimeNo = primeNumber.IsPrime(number);

            // Assert
            Assert.IsTrue(isPrimeNo);
        }
    }
}
