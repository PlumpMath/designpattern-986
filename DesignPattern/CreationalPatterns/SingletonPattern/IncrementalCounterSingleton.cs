using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.SingletonPattern
{
    /// <summary>
    /// Counter implemented using the Singleton Pattern
    /// Singleton Pattern: It can only exist one instance of a class
    /// </summary>
    public class IncrementalCounterSingleton
    {
        /// <summary>
        /// Private Constructor to avoid normal class initialization
        /// </summary>
        private IncrementalCounterSingleton()
        {
        }

        private static object _lockObject = new object();
        private static volatile IncrementalCounterSingleton _instance = null;
        private long _counter = 0;

        /// <summary>
        /// Returns the current value of the counter
        /// </summary>
        /// <returns>Current counter value</returns>
        public long GetCurrentValue()
        {
            return _counter;
        }

        /// <summary>
        /// Resets the counter
        /// </summary>
        public void Reset()
        {
            Interlocked.Exchange(ref _counter, 0);
        }

        /// <summary>
        /// Increments the counter thread-safe and returns the next value
        /// </summary>
        /// <returns>The next value</returns>
        public long Increment()
        {
            // Increments a specified variable and stores the result, as an atomic operation.
            Interlocked.Increment(ref _counter);
            return _counter;
        }

        /// <summary>
        /// Returns a single instance of the IncrementalCounterSingleton class
        /// </summary>
        public static IncrementalCounterSingleton Instance
        {
            get
            {
                // Attention: The lazy initialization is usually not thread-safe
                // Here the Double-Checked Locking Pattern is used to avoid multiple initialization and thread-safety
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new IncrementalCounterSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
