using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Girls:IStudent
    {
        public string Name { get;}
        public Girls(string name)
        {
            Name = name;
        }
        public int Old { get; }
        public Girls(int old)
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

