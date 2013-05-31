using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.StrategyPattern
{
    public interface ISortStrategy<T> where T : IComparable
    {
        void Sort(IList<T> data);
    }
}
