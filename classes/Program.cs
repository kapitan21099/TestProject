using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Birds(50);
            Animal animal2 = new Dog(Dogtype.HomeDog);
            Animal animal3 = new Fish();
            animal1.Step();
            animal2.Step();
            animal3.Step();
            Console.Read();

        }


    }
}
