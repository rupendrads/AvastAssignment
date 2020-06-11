using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbersConsole;
using Moq;
using System.Collections.Generic;

namespace PrimeNumbers.Tests
{
    [TestClass]
    public class PrimeNumbersUnitTests
    {
        int number = 3;
        Mock<IPrimeNumber> mock;

        public PrimeNumbersUnitTests()
        {
            Setup();
        }
        private void Setup()
        {            
            mock = new Mock<IPrimeNumber>();
            mock.Setup(p => p.IsPrime(1)).Returns(false);
            mock.Setup(p => p.IsPrime(2)).Returns(true);
            mock.Setup(p => p.IsPrime(3)).Returns(true);
            mock.Setup(p => p.IsPrime(4)).Returns(false);
            mock.Setup(p => p.IsPrime(5)).Returns(true);
        }

        [TestMethod]
        public void GetPrimeNumbers_Should_Returns_Correct_PrimeNumbers_Count()
        {
            // Arrange                                          
            IPrimeNumbers primeNumbers = new PrimeNumbersConsole.PrimeNumbers(mock.Object);

            // Act
            IList<int> result = primeNumbers.GetPrimeNumbers(number);

            // Assert
            Assert.IsTrue(result.Count == number);            
        }

        [TestMethod]
        public void GetPrimeNumbers_Should_Returns_Correct_PrimeNumbers()
        {
            // Arrange      
            int[] resultArray = new int[10];
            IPrimeNumbers primeNumbers = new PrimeNumbersConsole.PrimeNumbers(mock.Object);

            // Act
            IList<int> result = primeNumbers.GetPrimeNumbers(number);
            result.CopyTo(resultArray, 0);

            // Assert
            Assert.AreEqual(2, resultArray[0]);
            Assert.AreEqual(3, resultArray[1]);
            Assert.AreEqual(5, resultArray[2]);
        }        
    }
}