using System;
namespace TSTune.DesignPattern.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// Simplified interface for the adapter which just allows to start and stop timers.
    /// Other implementation details are hidden from the caller.
    /// </summary>
    public interface IHighResolutionTimerAdapter
    {
        /// <summary>
        /// Starts the timer
        /// </summary>
        void Start();

        /// <summary>
        /// Stops the timer and returns the elapsed time in milliseconds
        /// </summary>
        /// <returns>The elapsed time in milliseconds</returns>
        long Stop();
    }
}
