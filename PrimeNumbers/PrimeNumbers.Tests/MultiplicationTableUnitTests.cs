using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbersConsole;
using Moq;
using System.Collections.Generic;

namespace PrimeNumbers.Tests
{
    [TestClass]
    public class MultiplicationTableUnitTests
    {
        [TestMethod]
        public void GetTable_Should_Returns_Correct_Count()
        {
            // Arrange                                          
            IMultiplicationTable table = new MultiplicationTable();

            // Act
            IList<int> result = table.GetTable(3, 7);

            // Assert
            Assert.AreEqual(7, result.Count);
        }

        [TestMethod]
        public void GetTable_Should_Returns_Correct_Numbers()
        {
            // Arrange                
            int[] resultArray = new int[10];                          
            IMultiplicationTable table = new MultiplicationTable();

            // Act
            IList<int> result = table.GetTable(3, 5);
            result.CopyTo(resultArray, 0);

            // Assert
            Assert.AreEqual(3, resultArray[0]);
            Assert.AreEqual(6, resultArray[1]);
            Assert.AreEqual(9, resultArray[2]);
            Assert.AreEqual(12, resultArray[3]);
            Assert.AreEqual(15, resultArray[4]);
        }
    }
}