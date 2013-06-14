using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.PrototypePattern
{
    /// <summary>
    /// The IClonable prototype interface
    /// </summary>
    public interface ICloneable
    {
        /// <summary>
        /// Clones the current instance
        /// </summary>
        /// <returns>Cloned instance</returns>
        object Clone();
    }
}
