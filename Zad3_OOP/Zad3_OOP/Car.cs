using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_OOP
{
    internal class Car : Vehicle 
    {
        string kolor {  get; set; }

        public Car(string marka, int speed,string kolor) : base(marka, speed)
        {
            this.kolor = kolor;
            Console.WriteLine(marka, speed, kolor);
        }
    }
}
