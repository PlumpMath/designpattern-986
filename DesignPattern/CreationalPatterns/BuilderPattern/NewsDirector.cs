using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    /// <summary>
    /// The news director uses the NewsBuilder to create a news article.
    /// The steps to create a news article are split into three methods + one method for retrieving the news.
    /// </summary>
    public class NewsDirector
    {
        /// <summary>
        /// Creates the news article
        /// </summary>
        /// <param name="builder">The news builder implementation, e.g. Rss or Html builder</param>
        /// <param name="headLine">The head line</param>
        /// <param name="text">The text of the news</param>
        /// <returns>The complete news article as a simple text</returns>
        public string Construct(INewsBuilder builder, string headLine, string text)
        {
            builder.BuildHeadLine(headLine);
            builder.BuildText(text);
            builder.BuildAuthor();
            return builder.GetNews();
        }
    }
}
