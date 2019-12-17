using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz20._10
{
    class Program
    {
        static void Main(string[] args)
        {
           // Country country1 = new Country("Ukraine");
            Country country2 = new Sity("Russia", 150000);
            Street country3 = new Street("Turkey", 125565, 9985);
            country2.PopCountr(country2.Name,100);
           // Console.Read();
            
        }
    }
}
