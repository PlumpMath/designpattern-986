using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    [TestClass]
    public class DynamicFactoryMethodTest
    {
        [TestMethod]
        public void FactoryMethod_Should_ReturnGifConverter()
        {
            // Arrange, Act
            var result = GetImageConverterForResource("TSTune.DesignPattern.UnitTests.TestResources.TestImage.gif");
            // Assert
            Assert.IsInstanceOfType(result, typeof(GifImageConverter));
        }

        [TestMethod]
        public void FactoryMethod_Should_ReturnPngConverter()
        {
            // Arrange, Act
            var result = GetImageConverterForResource("TSTune.DesignPattern.UnitTests.TestResources.TestImage.png");
            // Assert
            Assert.IsInstanceOfType(result, typeof(PngImageConverter));
        }

        private static IImageConverter GetImageConverterForResource(string resourceName)
        {
            Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            return ImageConverterFactory.GetImageConverter(imageStream);
        }
    }
}
