using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.BehavioralPatterns.StrategyPattern;

namespace TSTune.DesignPattern.UnitTests.BehavioralPatterns
{
    /// <summary>
    /// Unit test for the strategy pattern
    /// </summary>
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void SmallArray_ShouldBeSortedWith_Bubblesort()
        {
            // Arrange
            int[] data = { 5, 3, 7, 6 };

            // Act
            var sortStrategySelector = new SortStrategySelector<int>(data);
            var result = sortStrategySelector.Sort();

            // Assert
            Assert.IsInstanceOfType(sortStrategySelector.SortStrategy, typeof(BubbleSortStrategy<int>));
            CollectionAssert.AreEqual(new[] { 3, 5, 6, 7 }, data);
        }

        [TestMethod]
        public void BigArray_ShouldBeSortedWith_Quicksort()
        {
            // Arrange
            int[] data = { 5, 3, 50, 100, 7, 4, 6, 12, 2, 120, 114 };

            // Act
            var sortStrategySelector = new SortStrategySelector<int>(data);
            var result = sortStrategySelector.Sort();

            // Assert
            Assert.IsInstanceOfType(sortStrategySelector.SortStrategy, typeof(QuickSortStrategy<int>));
            CollectionAssert.AreEqual(new[] { 2, 3, 4, 5, 6, 7, 12, 50, 100, 114, 120 }, data);

        }
    }
}
