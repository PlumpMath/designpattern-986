using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    /// <summary>
    /// BubbleSortStrategy is one of the available strategies.
    /// This class implement the sorting algorithm "Bubble Sort" 
    /// which has an average time complexity of O(n²) 
    /// </summary>
    /// <typeparam name="T">Type of the data objects which has to be comparable</typeparam>
    public class BubbleSortStrategy<T> : ISortStrategy<T> where T : IComparable
    {
        /// <summary>
        /// Sort method implementing simple Bubble Sort.
        /// Operates and modifies the order of the given data structure.
        /// </summary>
        /// <param name="data">The list of data</param>
        public void Sort(IList<T> data)
        {
            for (int left = 0; left < data.Count; left++)
            {
                for (int right = left + 1; right < data.Count; right++)
                {
                    // Check if left element is bigger than the right element
                    // Uses the IComparable interface
                    // Result > 0, left is bigger than right
                    // Result < 0, right is bigger than left
                    // Result == 0, left equals right
                    if (data[left].CompareTo(data[right]) > 0)
                    {
                        // Swaps the left and right element
                        var temp = data[left];
                        data[left] = data[right];
                        data[right] = temp;
                    }
                }
            }
        }
    }
}
