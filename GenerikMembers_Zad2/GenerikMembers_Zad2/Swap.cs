using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikMembers_Zad2
{
    internal class Swap<T>
    {
        public void Swip(T str1, T str2) 
        {
            T temp = str1;
            str1 = str2;
            str2 = temp;

            Console.WriteLine($"Str1 = {str1}, Str2 = {str2}!");
        }
    }
}
