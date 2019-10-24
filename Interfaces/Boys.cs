using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Boys:IStudent
    {
        public string Name { get; set;}
        public Boys(string name)
        {
            Name = name;
        }
        public int Old { get; set; }
        public Boys(int old)
        {
            Old = old;
        }
        public void GetInfo(int old)
        {            
            Console.WriteLine(old);
        }

        public string Info(string name)
        {
            return name;
        }
    }
}
