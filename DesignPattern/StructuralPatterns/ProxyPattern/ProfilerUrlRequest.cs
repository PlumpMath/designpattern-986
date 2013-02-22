using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.ProxyPattern
{
    public class ProfilerUrlRequest : IUrlRequest
    {
        private UrlRequest _urlRequest = new UrlRequest();

        public string GetUrlContent(string url)
        {
            string result = null;
            using (var consoleStopwatch = new OutputStopwatch("Method 'string GetUrlContent(string url)', Duration (ms): {0}"))
            {
                result = _urlRequest.GetUrlContent(url);
            }
            return result;
        }

        public string GetUrlContent(string url, string username, string password)
        {
            string result = null;
            using (var consoleStopwatch = new OutputStopwatch("Method 'string GetUrlContent(string url, string username, string password)', Duration (ms): {0}"))
            {
                result =  _urlRequest.GetUrlContent(url, username, password);
            }
            return result;
        }

        private class OutputStopwatch : IDisposable
        {
            private Stopwatch _stopwatch = new Stopwatch();
            private string _outputFormat;

            public OutputStopwatch(string outputFormat)
            {
                _outputFormat = outputFormat;
                _stopwatch.Start();
            }

            public void Dispose()
            {
                _stopwatch.Stop();
                Console.WriteLine(_outputFormat, _stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
