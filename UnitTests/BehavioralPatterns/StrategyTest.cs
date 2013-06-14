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
    /// Test class for the Strategy Pattern
    /// </summary>
    [TestClass]
    public class StrategyTest
    {
        /// <summary>
        /// The SortStrategySelector chooses the right sort strategy based on the size of the input list.
        /// In this case an array of just 4 elements is passed and the simple bubble sort should be selected in this case.
        /// </summary>
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

        /// <summary>
        /// The SortStrategySelector chooses the right sort strategy based on the size of the input list.
        /// In this case an array with more than 10 elements is passed and the quick sort should be selected in this case.
        /// </summary>
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
