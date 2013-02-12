using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    public class HtmlNewsBuilder : INewsBuilder
    {
        private const string HtmlSkeleton = @"<!DOCTYPE html>
<html>
<body>
{0}
</body>
</html>";

        private string _headLine;
        private string _text;
        private string _author;

        public void BuildHeadLine(string headLine)
        {
            _headLine = string.Format("<h1>{0}</h1>", headLine);
        }

        public void BuildText(string text)
        {
            _text = string.Format("<p>{0}</p>", text);
        }

        public void BuildAuthor()
        {
            _author = "<br />Thomas Schmitt";
        }

        public string GetNews()
        {
            return string.Format(HtmlSkeleton, _headLine + _text + _author);
        }
    }
}
