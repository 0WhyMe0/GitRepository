using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMembers_Zad3
{
    internal class LinkedList<T>
    {
        List<T> list = new List<T>();

        public void AddOne(T item)
        {
            list.Add(item);
        }

        public void AddLast(T value)
        {
            var last = list[list.Count - 1];
            last = value;
        }

        public void RemoveFirst()
        {
            var one = list[0];
            list.RemoveAt(0);
        }

        public void Print()
        {
           foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
