using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stefanini
{
    internal class Ingredients
    {
        public Ingredients(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
