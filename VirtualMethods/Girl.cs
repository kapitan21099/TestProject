using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Girl:Students
    {
        public  Girl(string name)
        {
            Name = name;
        }

        public override string Name { get; set; }
    }
}
