using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.ProxyPattern
{
    public class UrlRequest: IUrlRequest
    {
        public string GetUrlContent(string url)
        {
            return GetUrlContent(url, null, null);
        }

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
