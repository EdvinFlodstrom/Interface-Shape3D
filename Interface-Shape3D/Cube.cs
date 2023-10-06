using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Shape3D
{
    internal class Cube:Shape3D
    {
        private double length;

        public Cube(double _length)
        {
            this.length = _length;
        }
        public double GetArea()
        {
            return (6 * (length * length));
        }
        public double GetVolume()
        {
            return (length * length * length);
        }
        public override string ToString()
        {
            return "Cube" + Environment.NewLine + "Length of side: " + length 
                + Environment.NewLine + "Area = " + GetArea() + Environment.NewLine + 
                "Volume = " + GetVolume();
        }
    }
}
