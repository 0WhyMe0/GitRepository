using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4_OOP
{
    internal class ShapeDisplay : IShape
    {
        private Shape _shape;

        public ShapeDisplay(Shape shape)
        {
            _shape = shape;
        }

        public void Display()
        {
            Console.WriteLine($"Площа фігури {_shape.CalculateArea}");
        }
    }
}
