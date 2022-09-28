using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini
{
    internal class Cook
    {
        public Cook(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Dishes> Orders { get; set; } = new List<Dishes>();
    }
}
