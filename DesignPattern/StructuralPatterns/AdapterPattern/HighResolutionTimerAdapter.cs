using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// Timer which returns the CPU
    /// </summary>
    public class HighResolutionTimerAdapter : IHighResolutionTimerAdapter
    {
        private LegacyHighResolutionTimer _legacyHighResolutionTimer;
        private Int64 _startValue;

        public HighResolutionTimerAdapter()
        {
            _legacyHighResolutionTimer = new LegacyHighResolutionTimer();
        }

        public void Start()
        {
            // Store the current timer value when the measuring starts
            _startValue = _legacyHighResolutionTimer.Value;
        }

        public Int64 Stop()
        {
            // Get the current timer value when the measuring is stopped
            Int64 stopValue = _legacyHighResolutionTimer.Value;
            
            // Get time elapsed in milliseconds
            return (stopValue - _startValue)  * 1000 / _legacyHighResolutionTimer.Frequency;
        }
    }
}
