using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.ProxyPattern;

namespace TSTune.DesignPattern.UnitTests.StructuralPatterns
{
    [TestClass]
    public class ProxyTest
    {
        [TestMethod]
        public void UrlRequestCall_ShouldBe_Profiled()
        {
            // Arrange
            var originalConsoleOut = Console.Out;
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                try
                {
                    IUrlRequest profilerUrlRequest = new ProfilerUrlRequest();

                    // Act
                    var content = profilerUrlRequest.GetUrlContent("http://www.google.de");
                    writer.Flush();
                    var consoleOutput = writer.GetStringBuilder().ToString();

                    // Assert
                    Assert.IsNotNull(content);
                    Assert.IsNotNull(consoleOutput);
                    Assert.IsTrue(consoleOutput.StartsWith("Method 'string GetUrlContent(string url)', Duration (ms):"));
                }
                finally
                {
                    Console.SetOut(originalConsoleOut);
                }
            }
        }
    }
}