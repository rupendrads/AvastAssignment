using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumbersConsole;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.Tests
{
    [TestClass]
    public class GridTableUnitTests
    {
        Mock<PrimeNumbersConsole.IPrimeNumbers> mock = new Mock<PrimeNumbersConsole.IPrimeNumbers>();
        Mock<IMultiplicationTable> mockTable = new Mock<IMultiplicationTable>();

        public GridTableUnitTests()
        {
            Setup();
        }

        private void Setup()
        {
            mock.Setup(p => p.GetPrimeNumbers(2)).Returns(new List<int>() { 2, 3 });

            mockTable.Setup(p => p.GetTable(2, 2)).Returns(new List<int>() { 2, 4 });            
            mockTable.Setup(p => p.GetTable(3, 2)).Returns(new List<int>() { 3, 6 });            
        }

        [TestMethod]
        public void GetGridTable_Should_Returns_Grid_List()
        {        
            // Arragne
            IGridTable gridTable = new GridTable(mock.Object, mockTable.Object);

            // Act
            var gridTableList = gridTable.GetGridTable(2);

            // Assert
            Assert.IsNotNull(gridTableList);            
        }

        [TestMethod]
        public void GetGridTable_Should_Returns_Correct_PrimeNumbers_Count()
        {        
            // Arragne
            IGridTable gridTable = new GridTable(mock.Object, mockTable.Object);

            // Act
            var gridTableList = gridTable.GetGridTable(2);

            // Assert
            Assert.AreEqual(2, gridTableList.Count);
        }

        [TestMethod]
        public void GetGridTable_Should_Returns_Correct_Multiplication_Table_Length()
        {        
            // Arragne
            IGridTable gridTable = new GridTable(mock.Object, mockTable.Object);

            // Act
            var gridTableList = gridTable.GetGridTable(2);
            var model = gridTableList.Single(g => g.number == 2);

            // Assert
            Assert.IsNotNull(model);
            Assert.IsNotNull(model.tableNumbers);
        }
    }
}