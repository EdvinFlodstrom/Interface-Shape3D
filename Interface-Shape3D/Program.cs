using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Shape3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database databas = new Database();

            Sphere sphere1 = new Sphere(4.0);
            Cylinder cylinder1 = new Cylinder(4.0, 6.0);
            Cube cube1 = new Cube(3.0);

            databas.AddShape(sphere1);
            databas.AddShape(cylinder1);
            databas.AddShape(cube1);

            databas.Print();



            Console.ReadLine();
        }
    }
}
