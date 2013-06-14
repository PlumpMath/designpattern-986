using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    /// <summary>
    /// One implementation of the news builder.
    /// Creates a rss representation of the news article.
    /// </summary>
    public class RssNewsBuilder: INewsBuilder
    {
        private const string RssSkeletonHeader = @"<?xml version=""1.0"" encoding=""utf-8""?>
<rss version=""2.0"">
    <channel>
        <title>TSTune's - IT Talk</title>
        <link>http://tstune.blogspot.com</link>
        <language>en-US</language>
        <copyright>Thomas Schmitt</copyright>
        <item>
";

        private const string RssSkeletonFooter = @"
        </item>
</channel>
</rss>
";

        private StringBuilder _rssFeed = new StringBuilder(RssSkeletonHeader);

        /// <summary>
        /// Creates a RSS head line using title tags
        /// </summary>
        /// <param name="headLine">The head line</param>
        public void BuildHeadLine(string headLine)
        {
            _rssFeed.AppendFormat("<title>{0}</title>", headLine);
        }

        /// <summary>
        /// Creates the content of the news article using the description tags
        /// </summary>
        /// <param name="text">The news content</param>
        public void BuildText(string text)
        {
            _rssFeed.AppendFormat("<description>{0}</description>", text);
        }

        /// <summary>
        /// Creates author tags
        /// </summary>
        public void BuildAuthor()
        {
            _rssFeed.Append("<author>Thomas Schmitt</author>");
        }

        /// <summary>
        /// Returns the RSS xml as a string
        /// </summary>
        /// <returns>RSS xml</returns>
        public string GetNews()
        {
            _rssFeed.Append(RssSkeletonFooter);

            return _rssFeed.ToString();
        }
    }
}
