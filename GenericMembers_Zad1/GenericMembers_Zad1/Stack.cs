using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMembers_Zad1
{
    internal class Stack
    {
        List<int> list = new List<int>();

        public void Push(int value)
        {
            list.Add(value);
        }

        public int Pop() 
        {
            if (list.Count == 0)
                throw new Exception();

            var result = list[list.Count - 1];

            list.RemoveAt(list.Count - 1);

            return result;
        }

        public int Peek()
        {
            if (list.Count == 0)
                throw new Exception();


            return list[list.Count - 1];
        }
    }
}
