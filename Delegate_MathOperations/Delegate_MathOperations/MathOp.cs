using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_MathOperations
{
    internal class MathOp
    {
        public delegate void MathOperation(int result);

        public MathOperation mathOperation {  get; set; }

        public void Added(int a, int b)
        {
            int result = a + b;

            mathOperation(result);          
        }

        public void UnAdded(int a, int b)
        {
            int result = a - b;

            mathOperation(result);
        }

        public void Division(int a, int b)
        {
            int result = a / b;

            mathOperation(result);
        }

        public void Multiplication(int a, int b)
        {
            int result = (a * b);

            mathOperation(result);
        }
    }
}
