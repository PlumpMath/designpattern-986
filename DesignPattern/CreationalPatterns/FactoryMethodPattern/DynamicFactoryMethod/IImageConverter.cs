using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod
{
    /// <summary>
    /// Interface which represents the basic functionality of an image converter
    /// </summary>
    public interface IImageConverter
    {
        /// <summary>
        /// Converters the image (could be any kind of conversion)
        /// </summary>
        /// <returns>The converted image</returns>
        Stream ConvertImage();

        /// <summary>
        /// Indicates if the given stream contains a image in the supported file format
        /// </summary>
        /// <returns>true, if converter supports the image format</returns>
        bool IsSupportedFormat();
    }
}
