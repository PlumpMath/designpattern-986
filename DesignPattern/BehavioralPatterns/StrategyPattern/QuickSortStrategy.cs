using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    public class QuickSortStrategy<T> : ISortStrategy<T> where T : IComparable
    {
        public void Sort(IList<T> data)
        {
            Sort(data, 0, data.Count - 1);
        }

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
