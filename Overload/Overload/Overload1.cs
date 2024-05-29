using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload2
{
     class Overload1
    {
        public double CalculateAngle (double side1, double side2, int angle)
        {
            double angleInRadians = angle * Math.PI / 180;
            return 0.5 * side1 * side2 * Math.Sin(angle);
        }

    }
}
