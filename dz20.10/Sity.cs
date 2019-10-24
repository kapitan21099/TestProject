using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz20._10
{
    class Sity : Country
    {

        public int Population { get; set; }
        public Sity(string name,int population):base(name)
        {
            Population = population;
        }
        public override void PopCountr(string name, int population)
        {
            Console.WriteLine(name+" "+ population);
        }

    }
}
