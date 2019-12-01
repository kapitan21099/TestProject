using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            List<int> dic = new List<int>(n);
            List<int> resDic = new List<int>();
            for(int i=0;i<n;i++)
            {
                dic.Add(Convert.ToInt32(Console.ReadLine()));
            }            
            Console.WriteLine();
            var _count = 0;
            foreach (var num in dic)
            {
                if (num > dic.Sum() / n)
                {
                    _count++;
                    resDic.Add(dic.IndexOf(num));
                }
            }
            Console.WriteLine(_count);
            foreach (var x in resDic)
            {
                Console.Write(x+" ");
            }
            Console.ReadLine();
        }
    }
}
