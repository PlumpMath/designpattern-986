using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern
{
    public interface IImageConverter
    {
        /// <summary>
        /// Converters the image
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
