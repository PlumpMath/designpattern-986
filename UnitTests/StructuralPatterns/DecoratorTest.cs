using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.DecoratorPattern;

namespace TSTune.DesignPattern.UnitTests.StructuralPatterns
{
    [TestClass]
    public class DecoratorTest
    {
        private bool _throttledLimitReached = false;

        [TestMethod]
        public void ThrottleLimit_ShouldBe_Reached()
        {
            // Arrange 
            // Five bytes per minute
            var maximumNumberOfBytes = 5;
            var withinTimespan = new TimeSpan(0, 0, 1);
            var message = "Hello World";

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(message));

            // Act
            var result = new byte[100];
            var throttledReadStream = new ThrottledReadStream(memoryStream, false, maximumNumberOfBytes, withinTimespan);
            throttledReadStream.ThrottledMaximumReached += TrottledReadStream_ThrottledMaximumReached;
            var readBytes = throttledReadStream.Read(result, 0, 10);

            // Assert
            Assert.IsTrue(_throttledLimitReached);
        }

        private void TrottledReadStream_ThrottledMaximumReached(object sender, bool e)
        {
            _throttledLimitReached = true;
        }
    }
}
