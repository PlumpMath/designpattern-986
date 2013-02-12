using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern
{
    public class GifImageConverter : IImageConverter
    {
        private readonly string[] GifHeaders = { "GIF87a", "GIF89a" };
        private Stream stream;

        public GifImageConverter(Stream stream)
        {
            this.stream = stream;
        }

        public Stream ConvertImage()
        {
            throw new NotImplementedException();
        }

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

        private void SetStreamToBeginning()
        {
            stream.Position = 0;
        }
    }
}
