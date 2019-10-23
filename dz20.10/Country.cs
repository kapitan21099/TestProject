using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz20._10
{
    abstract class Country
    {  
        public string Name{get;set; }
        public Country(string name)
        {
            Name = name;
        }
        public abstract void PopCountr(string name, int population);
    }
}
