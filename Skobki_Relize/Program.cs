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
            string str = "10+12+()(95-13)+10()";
            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == ')')
                    a -= 1;
                if (c == '(')
                    a += 1;
                if (a < 0)
                {
                    break;
                }
            }
            if (a==0)
                Console.WriteLine("True");
            else Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
