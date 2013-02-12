using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
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

        public void BuildHeadLine(string headLine)
        {
            _rssFeed.AppendFormat("<title>{0}</title>", headLine);
        }

        public void BuildText(string text)
        {
            _rssFeed.AppendFormat("<description>{0}</description>", text);
        }

        public void BuildAuthor()
        {
            _rssFeed.Append("<author>Thomas Schmitt</author>");
        }

        public string GetNews()
        {
            _rssFeed.Append(RssSkeletonFooter);

            return _rssFeed.ToString();
        }
    }
}
