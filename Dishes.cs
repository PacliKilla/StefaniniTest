using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini
{
    internal class Dishes
    {

        public Dishes(string name, string description, int cookingTime)
        {
            Name = name;
            Description = description;
            CookingTime = cookingTime;

        }
        public Dishes(string name, string description, int cookingTime, params Ingredients[] components) : this(name, description, cookingTime)
        {
            Components = new List<Ingredients>(components);
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public List<Ingredients> Components { get; set; }
        public int CookingTime { get; set; }

    }
}
