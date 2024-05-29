using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_OOP
{
    internal class Vehicle
    {
        public int speed {  get; set; }
        public string marka {  get; set; }

        public Vehicle(string marka, int speed)
        {
            this.marka = marka; 
            this.speed = speed;
        }
    }
}
