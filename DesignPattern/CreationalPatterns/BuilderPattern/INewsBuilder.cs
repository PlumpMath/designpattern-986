using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    public interface INewsBuilder
    {
        void BuildHeadLine(string headLine);
        void BuildText(string text);
        void BuildAuthor();
        string GetNews();
    }
}
