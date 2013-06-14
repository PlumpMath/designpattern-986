using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    /// <summary>
    /// The Sort Strategy Selector chooses the right sort strategy based on the given input data.
    /// If the input list contains less than 10 elements the selector picks the simpler Bubble sort
    /// in order to avoid Quick Sort's extra overhead from the recursive function calls.
    /// If the list has 10 or more elements Quick Sort is used.
    /// </summary>
    /// <typeparam name="T">Type of the data to sort</typeparam>
    public class SortStrategySelector<T> where T: IComparable
    {
        private IList<T> _data;

        /// <summary>
        /// Gets or sets the sort strategy. 
        /// It is possible to override the selection made based on the size of the data.
        /// </summary>
        public ISortStrategy<T> SortStrategy { get; set; }

        /// <summary>
        /// The constructor takes the input data and selects the proper sort strategy
        /// </summary>
        /// <param name="data">The list of data</param>
        public SortStrategySelector(IList<T> data)
        {
            _data = data;
            if (data.Count < 10)
            {
                SortStrategy = new BubbleSortStrategy<T>();
            }
            else
            {
                SortStrategy = new QuickSortStrategy<T>();
            }
        }

        /// <summary>
        /// This method sorts the passed list of data using a proper sort strategy
        /// </summary>
        /// <returns>Sorted list of data</returns>
        public IList<T> Sort()
        {
            SortStrategy.Sort(_data);
            return _data;
        }
    }
}
