using System;
namespace TSTune.DesignPattern.StructuralPatterns.AdapterPattern
{
    public interface IHighResolutionTimerAdapter
    {
        void Start();
        long Stop();
    }
}
