using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.CreationalPatterns.SingletonPattern;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    /// <summary>
    /// Test class for the Singleton Pattern
    /// </summary>
    [TestClass]
    public class SingletonTest
    {
        /// <summary>
        /// Uses the singleton and validates that the counter always increments on the same single instance
        /// </summary>
        [TestMethod]
        public void Singleton_Should_IncrementOnSameInstance()
        {
            // Arrange
            IncrementalCounterSingleton.Instance.Reset();
            int count = 100;

            // Act
            for (int i = 0; i < 100; i++)
            {
                IncrementalCounterSingleton.Instance.Increment();
            }

            // Assert
            Assert.AreEqual(count, IncrementalCounterSingleton.Instance.GetCurrentValue());
        }

        /// <summary>
        /// Starts multiple threads and validates that the Singleton Implementation is thread safe
        /// </summary>
        [TestMethod]
        public void Singleton_ShouldBe_ThreadSafe()
        {
            // Arrange
            IncrementalCounterSingleton.Instance.Reset();
            int threads = 100;

            // Act
            // Start defined number of threads which all increment the singleton counter
            var taskList = new List<Task<long>>();
            for (int i = 0; i < threads; i++)
            {
                taskList.Add(Task<long>.Factory.StartNew(a => IncrementalCounterSingleton.Instance.Increment(), i));
            }

            Task.WaitAll(taskList.ToArray(), 1000);

            // Assert
            // Check wheater the counter has the expected value (increment by 1 per thread)
            Assert.AreEqual(threads, IncrementalCounterSingleton.Instance.GetCurrentValue());
            // Go through the whole result array of the tasks, every number from 1 to 1000 should be exactly once in there
            for (int i = 0; i < threads; i++)
            {
                var resultToSearch = i + 1;
                var task = taskList.Single(item => item.Result == resultToSearch);
                Assert.AreEqual(resultToSearch, task.Result);
            }
        }
    }
}
