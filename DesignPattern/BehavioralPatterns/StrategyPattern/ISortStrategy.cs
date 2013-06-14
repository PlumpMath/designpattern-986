using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    /// <summary>
    /// Core Interface of the Strategy pattern. 
    /// Describes the contract each strategy has to follow in order to be inter-exchangeable.
    /// In this case the ISortStrategy interface has a single method sort which takes a list of data.
    /// </summary>
    /// <typeparam name="T">Type of the data</typeparam>
    public interface ISortStrategy<T> where T : IComparable
    {
        /// <summary>
        /// Sort method defining the contract of the strategy
        /// </summary>
        /// <param name="data">List of generic data</param>
        void Sort(IList<T> data);
    }
}
