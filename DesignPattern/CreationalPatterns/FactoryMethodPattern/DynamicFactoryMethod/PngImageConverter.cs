using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod
{
    public class PngImageConverter : IImageConverter
    {
        private readonly byte[] HeaderSequence = { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };
        private Stream stream;

        public PngImageConverter(Stream stream)
        {
            this.stream = stream;
        }
        public Stream ConvertImage()
        {
            throw new NotImplementedException();
        }

        public bool IsSupportedFormat()
        {
            SetStreamToBeginning();

            // Create array with length of Png header
            byte[] currentHeader = new byte[HeaderSequence.Length];
            stream.Read(currentHeader, 0, currentHeader.Length);
            
            SetStreamToBeginning();

            return HeaderSequence.SequenceEqual<byte>(currentHeader);
        }

        private void SetStreamToBeginning()
        {
            stream.Position = 0;
        }
    }
}
