using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
     class Animal
    {
        public int Wes { get; set; }

      /*  public Animal(int wes)
        {
            Wes = wes;
        }*/

        public virtual void  Step()
        {
            Console.WriteLine(Wes);
        }
    }


}
