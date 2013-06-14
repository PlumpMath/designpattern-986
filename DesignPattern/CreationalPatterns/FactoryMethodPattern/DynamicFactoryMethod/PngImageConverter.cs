using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod
{
    /// <summary>
    /// Converter implementation for Png images.
    /// Decides based on the PNG header sequence if the image is supported.
    /// </summary>
    public class PngImageConverter : IImageConverter
    {
        private readonly byte[] HeaderSequence = { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };
        private Stream stream;

        /// <summary>
        /// Constructor taking the input stream containing byte sequence of the image.
        /// </summary>
        /// <param name="stream">The input stream</param>
        public PngImageConverter(Stream stream)
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
        /// in order to figure out if the stream contains a PNG image
        /// </summary>
        /// <returns>True, if stream contains header sequence for PNG image</returns>
        public bool IsSupportedFormat()
        {
            SetStreamToBeginning();

            // Create array with length of Png header
            byte[] currentHeader = new byte[HeaderSequence.Length];
            stream.Read(currentHeader, 0, currentHeader.Length);
            
            SetStreamToBeginning();

            return HeaderSequence.SequenceEqual<byte>(currentHeader);
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
