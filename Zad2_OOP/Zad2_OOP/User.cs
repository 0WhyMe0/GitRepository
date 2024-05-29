using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_OOP
{
    internal class User
    {
        string name {  get; set; }
        string lastName {  get; set; }
        string email { get; set; }

        internal string Name(string name)
        {
            return name;
        }
    }
}
