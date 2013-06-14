using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    /// <summary>
    /// QuickSortStrategy is one of the available strategies.
    /// This class implement the sorting algorithm "Quick Sort" 
    /// which has an average time complexity of O(n logn) 
    /// </summary>
    /// <typeparam name="T">Type of the data objects which has to be comparable</typeparam>
    public class QuickSortStrategy<T> : ISortStrategy<T> where T : IComparable
    {
        /// <summary>
        /// Sort method which fulfils the ISortStrategy interface and implements Quick Sort algorithm.
        /// Operates and modifies the order of the given data structure.
        /// </summary>
        /// <param name="data"></param>
        public void Sort(IList<T> data)
        {
            Sort(data, 0, data.Count - 1);
        }

        /// <summary>
        /// Private helper method for the Quick Sort implementation. 
        /// Used in recursive calls defining the left and right boundary of the list.
        /// </summary>
        /// <param name="data">List of data</param>
        /// <param name="left">Left boundary for sorting</param>
        /// <param name="right">Right boundary for sorting</param>
        private void Sort(IList<T> data, int left, int right)
        {
            // Store left and right start as well as the middle element (pivot)
            var i = left;
            var j = right;
            var pivotElement = data[(left + right) / 2];
            
            while (i <= j)
            {
                while (data[j].CompareTo(pivotElement) > 0)
                {
                    j--;
                }
                while (data[i].CompareTo(pivotElement) < 0)
                {
                    i++;
                }
                if (i <= j)
                {
                    // Swaps the elements
                    var tmp = data[i];
                    data[i] = data[j];
                    data[j] = tmp;
                    j--;
                    i++;
                }
            }
            if (left < j)
            {
                Sort(data, left, j);
            }
            if (i < right)
            {
                Sort(data, i, right);
            }
        }
    }
}
