using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skobki_Relize
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "10+12+)(95-13)+10()";
            char[] strChar = str.ToCharArray();
            int a = 0;
            foreach (char c in strChar)
            {
                if (c == ')')
                    a -= 1;
                if (c == '(')
                    a += 1;
                if (a < 0)
                    Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
