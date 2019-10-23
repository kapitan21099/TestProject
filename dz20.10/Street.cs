using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz20._10
{
    class Street : Sity
    {
        public int Length { get; set; }
        public Street(string name,int population, int length ) : base(name,population)
        {
            Length = length;
        }
    }
}
