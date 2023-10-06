using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Shape3D
{
    internal class Database
    {
        private List<Shape3D> objects = new List<Shape3D>();

        public void Print()
        {
            foreach (Shape3D item in objects)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
        public void AddShape(Shape3D _shape)
        {
            objects.Add(_shape);
        }
    }
}
