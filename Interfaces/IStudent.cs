using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IStudent
    { 
        string Name { get; }
        int Old { get; }
        void GetInfo(int old);
        string Info(string name);
    }
}
