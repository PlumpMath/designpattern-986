using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.ProxyPattern
{
    /// <summary>
    /// This class requests data from a given url
    /// </summary>
    public class UrlRequest: IUrlRequest
    {
        /// <summary>
        /// Gets the content from the given url
        /// </summary>
        /// <param name="url">The url</param>
        /// <returns>The content of the given url as a string</returns>
        public string GetUrlContent(string url)
        {
            return GetUrlContent(url, null, null);
        }

        /// <summary>
        /// Gets the content from the given url. 
        /// Passes the given username and password as network credentials to access the url.
        /// </summary>
        /// <param name="url">The url</param>
        /// <param name="username">The username to access protected url</param>
        /// <param name="password">The password to access protected url</param>
        /// <returns>The content of the given url as a string</returns>
        public string GetUrlContent(string url, string username, string password)
        {
            var webRequest = WebRequest.Create(url);

            if (username != null && password != null)
            {
                webRequest.Credentials = new NetworkCredential(username, password);
            }

            WebResponse webResponse = webRequest.GetResponse();

            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            return sr.ReadToEnd();
        }
    }
}
