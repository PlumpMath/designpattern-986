using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSTune.DesignPattern.CreationalPatterns.PrototypePattern
{
    /// <summary>
    /// ICloneable represents here the prototype
    /// </summary>
    public class Coordinate: ICloneable
    {
        /// <summary>
        /// Gets or sets the X coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Contructor taking x and y coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Clone method which represents the prototype
        /// </summary>
        /// <returns>A new instance of this type with the same data</returns>
        public object Clone()
        {
            // MemberwiseClone clones the object using memory copy
            // The constructur is not invoked
            return this.MemberwiseClone();
        }
    }
}
