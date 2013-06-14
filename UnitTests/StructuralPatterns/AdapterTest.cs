using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.AdapterPattern;

namespace TSTune.DesignPattern.UnitTests.StructuralPatterns
{
    /// <summary>
    /// Test class for the Adapter Pattern
    /// </summary>
    [TestClass]
    public class AdapterTest
    {
        /// <summary>
        /// Starts the legacy high resolution timer by using the adapter 
        /// and measures the time it takes to calculate a fibonacci number.
        /// </summary>
        [TestMethod]
        public void Timer_ShouldReturn_ElapsedTimeInMilliseconds()
        {
            // Arrange 
            IHighResolutionTimerAdapter highResolutionTimerAdapter = new HighResolutionTimerAdapter();
            
            // Act
            highResolutionTimerAdapter.Start();
            Fibonacci(30);
            var result = highResolutionTimerAdapter.Stop();

            // Assert
            Assert.IsTrue(result >= 0);
        }

        private static int Fibonacci(int a)
        {
            if (a == 1 || a == 2) return 1;
            else return Fibonacci(a - 1) + Fibonacci(a - 2);
        }
    }
}
