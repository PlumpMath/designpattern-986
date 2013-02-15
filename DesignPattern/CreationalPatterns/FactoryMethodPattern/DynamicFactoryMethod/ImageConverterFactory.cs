using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod
{
    public class ImageConverterFactory
    {
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
