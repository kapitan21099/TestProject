using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Fish : Animal
    {
        public int Deep { get; set; }
        public override void Step()
        {
            Console.WriteLine("Fish is swim");
        }
    }
}
