using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// Adapter which simplifies and abstracts the legacy implementation of an high resolution timer.
    /// It makes sure that the legacy component can be easily replaced at any time 
    /// and that the details do not spread across the whole system.
    /// Additionally, it simplifies the interface of the adapted component.
    /// </summary>
    public class HighResolutionTimerAdapter : IHighResolutionTimerAdapter
    {
        /// <summary>
        /// The wrapped legacy class
        /// </summary>
        private LegacyHighResolutionTimerNativeMethods _legacyHighResolutionTimer;
        private Int64 _startValue;

        /// <summary>
        /// Constructor
        /// </summary>
        public HighResolutionTimerAdapter()
        {
            _legacyHighResolutionTimer = new LegacyHighResolutionTimerNativeMethods();
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        public void Start()
        {
            // Store the current timer value when the measuring starts
            _startValue = _legacyHighResolutionTimer.Value;
        }

        /// <summary>
        /// Stops the timer and returns the elapsed time in milliseconds.
        /// </summary>
        /// <returns>The elapsed time in milliseconds</returns>
        public Int64 Stop()
        {
            // Get the current timer value when the measuring is stopped
            Int64 stopValue = _legacyHighResolutionTimer.Value;
            
            // Get time elapsed in milliseconds
            return (stopValue - _startValue)  * 1000 / _legacyHighResolutionTimer.Frequency;
        }
    }
}
