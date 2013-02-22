using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSTune.DesignPattern.StructuralPatterns.ProxyPattern
{
    public interface IUrlRequest
    {
        string GetUrlContent(string url);
        string GetUrlContent(string url, string username, string password);
    }
}
