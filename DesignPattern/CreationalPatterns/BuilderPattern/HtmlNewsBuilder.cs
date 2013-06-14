using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    /// <summary>
    /// One implementation of the news builder.
    /// Creates a html representation of the news article.
    /// </summary>
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

        /// <summary>
        /// Creates the news headline using h1-tags
        /// </summary>
        /// <param name="headLine">The head line</param>
        public void BuildHeadLine(string headLine)
        {
            _headLine = string.Format("<h1>{0}</h1>", headLine);
        }

        /// <summary>
        /// Creates the news text using p-tags (paragraphs)
        /// </summary>
        /// <param name="text">The news content</param>
        public void BuildText(string text)
        {
            _text = string.Format("<p>{0}</p>", text);
        }

        /// <summary>
        /// Adds the author at the end of the article
        /// </summary>
        public void BuildAuthor()
        {
            _author = "<br />Thomas Schmitt";
        }

        /// <summary>
        /// Returns the html snipped as a simple string
        /// </summary>
        /// <returns>Html snipped</returns>
        public string GetNews()
        {
            return string.Format(HtmlSkeleton, _headLine + _text + _author);
        }
    }
}
