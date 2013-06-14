using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.BuilderPattern
{
    /// <summary>
    /// This is the news builder interface which allows to split 
    /// the creation of a news article into different methods.
    /// </summary>
    public interface INewsBuilder
    {
        /// <summary>
        /// Creates a head line for the news article
        /// </summary>
        /// <param name="headLine">Head line text</param>
        void BuildHeadLine(string headLine);

        /// <summary>
        /// Creates the text for the news article
        /// </summary>
        /// <param name="text">The text to display in the article</param>
        void BuildText(string text);

        /// <summary>
        /// Defines the author of the news article
        /// </summary>
        void BuildAuthor();

        /// <summary>
        /// Returns the news article
        /// </summary>
        /// <returns>News article as a simple text</returns>
        string GetNews();
    }
}
