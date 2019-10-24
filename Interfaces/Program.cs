using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent student1 = new Boys("Max");
            IStudent student2 = new Girls("Maria");
            Console.WriteLine(student1.Info("Fix"));
            Console.WriteLine(student2.Info("Fax"));
            Console.WriteLine(student1.Name);
            student1.GetInfo(25656);
            Console.WriteLine(student2.Name);
            student2.GetInfo(333);
            Console.ReadLine();

        }
    }
}
