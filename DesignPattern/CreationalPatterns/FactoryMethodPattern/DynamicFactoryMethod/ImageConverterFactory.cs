using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod
{
    /// <summary>
    /// This class holds the static Factory Method. 
    /// This method decides at runtime which converter implementation to take based on the given input stream.
    /// If the stream contains header information for a PNG file the PngImageConverter is returned.
    /// If the stream contains header information for a GIF file the GifImageConverter is returned.
    /// Both implement the same interface which makes it transparent to the called which implementation is used.
    /// </summary>
    public class ImageConverterFactory
    {
        /// <summary>
        /// The actual factory method which returns the correct implementation of the image converter
        /// based on the first bytes in the input stream.
        /// </summary>
        /// <param name="stream">The input stream</param>
        /// <returns>Interface abstracting the different implementations of the image converter</returns>
        public static IImageConverter GetImageConverter(Stream stream)
        {
            IImageConverter result = null;

            var pngImageConverter = new PngImageConverter(stream);
            if (pngImageConverter.IsSupportedFormat())
            {
                result = pngImageConverter;
            }

            var gifImageConverter = new GifImageConverter(stream);
            if (gifImageConverter.IsSupportedFormat())
            {
                result = gifImageConverter;
            }

            return result;
        }
    }
}
