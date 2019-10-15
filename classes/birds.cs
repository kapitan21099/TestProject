using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Birds : Animal
    {
        public int MaxFly { get; set; }
        public  Birds(int maxFly)
        {
            MaxFly = maxFly;
        }

        public override void Step()
        {
            Console.WriteLine(wes " - " maxFly);
        }
    }
}
