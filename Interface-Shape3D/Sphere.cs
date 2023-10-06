using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Shape3D
{
    internal class Sphere: Shape3D
    {
        private double radius;
        public Sphere(double _radius)
        {
            this.radius = _radius;
        }
        public double GetArea()
        {
            return (4 * Math.PI * radius * radius);
        }
        public double GetVolume()
        {
            return ((4*Math.PI * radius * radius * radius) / 3);
        }
        public override string ToString()
        {
            return "Sphere" + Environment.NewLine + "Radius: " + radius + 
                Environment.NewLine + "Area = " + GetArea() + Environment.NewLine + 
                "Volume = " + GetVolume();
        }
    }
}
