using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    /// <summary>
    /// The Sort Strategy Selector chooses the right sort strategy based on the given input data
    /// </summary>
    /// <typeparam name="T">Type of the data to sort</typeparam>
    public class SortStrategySelector<T> where T: IComparable
    {
        private IList<T> _data;
        public ISortStrategy<T> SortStrategy { get; set; }

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

        public IList<T> Sort()
        {
            SortStrategy.Sort(_data);
            return _data;
        }
    }
}
