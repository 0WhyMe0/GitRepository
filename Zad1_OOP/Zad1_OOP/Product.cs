using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_OOP
{
    class Product
    {
        string name { get; set; }
        int price { get; set; }
        int number { get; set; }

        public Product(string name, int price, int number)
        {
            this.name = name;
            this.price = price;
            this.number = number;

            Console.WriteLine($"Вартість товару {price * number}"); 
        }
    }
}
