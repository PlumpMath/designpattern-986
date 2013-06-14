using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.ProxyPattern
{
    /// <summary>
    /// This class implements the exact same interface than the proxied class which makes the actual url call.
    /// Therefore, this calls can be used instead of the UrlRequest class without actually modifing the code base.
    /// 
    /// In this example the ProfilerUrlRequest class starts and stops a time watch to log the execution times for each method call.
    /// </summary>
    public class ProfilerUrlRequest : IUrlRequest
    {
        private UrlRequest _urlRequest = new UrlRequest();

        /// <summary>
        /// Starts the timer and forwards the call to the underlying UrlRequest instance.
        /// The timer result is written on the console.
        /// </summary>
        /// <param name="url">The url</param>
        /// <returns>The content of the given url as a string</returns>
        public string GetUrlContent(string url)
        {
            string result = null;
            using (var consoleStopwatch = new OutputStopwatch("Method 'string GetUrlContent(string url)', Duration (ms): {0}"))
            {
                result = _urlRequest.GetUrlContent(url);
            }
            return result;
        }

        /// <summary>
        /// Starts the timer and forwards the call to the underlying UrlRequest instance.
        /// The timer result is written on the console.
        /// </summary>
        /// <param name="url">The url</param>
        /// <param name="username">The username to access protected url</param>
        /// <param name="password">The password to access protected url</param>
        /// <returns>The content of the given url as a string</returns>
        public string GetUrlContent(string url, string username, string password)
        {
            string result = null;
            using (var consoleStopwatch = new OutputStopwatch("Method 'string GetUrlContent(string url, string username, string password)', Duration (ms): {0}"))
            {
                result =  _urlRequest.GetUrlContent(url, username, password);
            }
            return result;
        }

        /// <summary>
        /// Private class for the stop watch. Implements IDisposable to use it in using blocks.
        /// </summary>
        private class OutputStopwatch : IDisposable
        {
            private Stopwatch _stopwatch = new Stopwatch();
            private string _outputFormat;

            /// <summary>
            /// Constructor for the stop watch
            /// </summary>
            /// <param name="outputFormat">Output Format String</param>
            public OutputStopwatch(string outputFormat)
            {
                _outputFormat = outputFormat;
                _stopwatch.Start();
            }

            /// <summary>
            /// Makes the classes usable in using-Brackets. As soon as it looses the scope the watch is stopped
            /// and the result is printed on the console output.
            /// </summary>
            public void Dispose()
            {
                _stopwatch.Stop();
                Console.WriteLine(_outputFormat, _stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
