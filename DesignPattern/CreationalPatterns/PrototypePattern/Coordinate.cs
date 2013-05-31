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
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public object Clone()
        {
            // MemberwiseClone clones the object using memory copy
            // The constructur is not invoked
            return this.MemberwiseClone();
        }
    }
}
