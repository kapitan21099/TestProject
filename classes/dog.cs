using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Dog : Animal
    {
        
        public Dogtype Dogtype { get; set; }

        public Dog(Dogtype dogtype)
        {
            Dogtype = dogtype;
        }

        public override void Step()
        {
            Console.WriteLine("Dog is step");
        }
    }
   
}
