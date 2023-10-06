using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Shape3D
{
    internal class Cylinder : Shape3D
    {
        private double radius;
        private double height;

        public Cylinder(double _radius, double _height)
        {
            this.radius = _radius;
            this.height = _height;
        }
        public double GetArea()
        {
            return ((2 * Math.PI * radius * height) + (2 * Math.PI * (radius*radius)));
        }
        public double GetVolume()
        {
            return (Math.PI * (radius * radius) * height);
        }
        public override string ToString()
        {
            return "Cylinder" + Environment.NewLine + "Radius: " + radius
                + Environment.NewLine + "Height: " + height + Environment.NewLine
                + "Area = " + GetArea() + Environment.NewLine + 
                "Volume = " + GetVolume();
        }
    }
}
