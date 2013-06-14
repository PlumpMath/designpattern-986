using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod
{
    /// <summary>
    /// Converter implementation for Gif images.
    /// Decides based on the GIF headers "GIF87a" or "GIF89a" if the image is supported.
    /// </summary>
    public class GifImageConverter : IImageConverter
    {
        private readonly string[] GifHeaders = { "GIF87a", "GIF89a" };
        private Stream stream;

        /// <summary>
        /// Constructor taking the input stream containing byte sequence of the image.
        /// </summary>
        /// <param name="stream">The input stream</param>
        public GifImageConverter(Stream stream)
        {
            this.stream = stream;
        }

        /// <summary>
        /// Converters the image (could be any kind of conversion)
        /// This method is not implemented in this example
        /// </summary>
        /// <returns>The converted image</returns>
        public Stream ConvertImage()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method reads the first bytes of the stream 
        /// in order to figure out if the stream contains a Gif image
        /// </summary>
        /// <returns>True, if stream contains header sequence for Gif image</returns>
        public bool IsSupportedFormat()
        {
            bool result = false;

            SetStreamToBeginning();
            
            // Create array with maximum length of the possible gif headers and fill it
            byte[] currentHeader = new byte[GifHeaders.Max(item => item.Length)];
            stream.Read(currentHeader, 0, currentHeader.Length);
            
            foreach (var gifHeader in GifHeaders)
            {
                // Compare the defined gif headers with given input stream
                byte[] header = Encoding.ASCII.GetBytes(gifHeader);
                result = result | header.SequenceEqual<byte>(currentHeader.Take(header.Length));
            }

            SetStreamToBeginning();

            return result;
        }

        /// <summary>
        /// Helper method resetting the stream to the first byte
        /// </summary>
        private void SetStreamToBeginning()
        {
            stream.Position = 0;
        }
    }
}
