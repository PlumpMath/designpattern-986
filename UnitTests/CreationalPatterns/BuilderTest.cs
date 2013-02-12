using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.CreationalPatterns.BuilderPattern;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void Builder_Should_ReturnHtmlPage()
        {
            // Arrange
            INewsBuilder builder = new HtmlNewsBuilder();
            var newsDirector = new NewsDirector();
            
            // Act
            var result = newsDirector.Construct(builder,
                "TSTune Design Pattern released",
                "Visit the blog http://tstune.blogspot.com for more details about the Design Pattern examples.");

            // Assert
            Assert.IsTrue(result.StartsWith("<!DOCTYPE"));
        }

        [TestMethod]
        public void Builder_Should_ReturnRssFeed()
        {
            // Arrange
            INewsBuilder builder = new RssNewsBuilder();
            var newsDirector = new NewsDirector();

            // Act
            var result = newsDirector.Construct(builder,
                "TSTune Design Pattern released",
                "Visit the blog http://tstune.blogspot.com for more details about the Design Pattern examples.");

            // Assert
            Assert.IsTrue(result.Contains("<rss"));
        }
    }
}
