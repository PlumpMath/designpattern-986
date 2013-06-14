using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    /// <summary>
    /// Test class for the Factory Method Pattern
    /// </summary>
    [TestClass]
    public class DynamicFactoryMethodTest
    {
        /// <summary>
        /// Loads a gif image from the resources and calls the ImageConverterFactory 
        /// to validate that the gif image is recognized and the correct converter class is returned
        /// </summary>
        [TestMethod]
        public void FactoryMethod_Should_ReturnGifConverter()
        {
            // Arrange, Act
            var result = GetImageConverterForResource("TSTune.DesignPattern.UnitTests.TestResources.TestImage.gif");
            // Assert
            Assert.IsInstanceOfType(result, typeof(GifImageConverter));
        }

        /// <summary>
        /// Loads a png image from the resources and calls the ImageConverterFactory 
        /// to validate that the gif image is recognized and the correct converter class is returned
        /// </summary>
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
