using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    public class NewsDirector
    {
        public string Construct(INewsBuilder builder, string headLine, string text)
        {
            builder.BuildHeadLine(headLine);
            builder.BuildText(text);
            builder.BuildAuthor();
            return builder.GetNews();
        }
    }
}
