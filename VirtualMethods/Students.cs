using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    abstract class Students
    {
        public virtual string Name { get; set; }
        protected Students(string name)
        {
            Name = name;
        }        
        public virtual void Stud()
        { Console.WriteLine("Hello"); }
    }
}
