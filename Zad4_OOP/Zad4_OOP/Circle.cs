using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4_OOP
{
    public class Circle : Shape
    {
        public double radius {  get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
