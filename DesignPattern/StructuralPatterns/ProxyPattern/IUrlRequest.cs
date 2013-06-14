using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSTune.DesignPattern.StructuralPatterns.ProxyPattern
{
    /// <summary>
    /// This is the basic interface of the proxy pattern.
    /// Both implementations, the original class and the proxy class, use the exact same interface.
    /// Therefore, they are easily interchangable.
    /// 
    /// This interface defines how url requests can be issued.
    /// </summary>
    public interface IUrlRequest
    {
        /// <summary>
        /// Gets the content from the given url
        /// </summary>
        /// <param name="url">The url</param>
        /// <returns>The content of the given url as a string</returns>
        string GetUrlContent(string url);

        /// <summary>
        /// Gets the content from the given url. 
        /// Passes the given username and password as network credentials to access the url.
        /// </summary>
        /// <param name="url">The url</param>
        /// <param name="username">The username to access protected url</param>
        /// <param name="password">The password to access protected url</param>
        /// <returns>The content of the given url as a string</returns>
        string GetUrlContent(string url, string username, string password);
    }
}
