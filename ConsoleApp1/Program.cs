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
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> dic = new List<int>(n);
            List<int> resDic = new List<int>();
            string line = Console.ReadLine();
            string[] arr1 = line.Split(' ');
            foreach (var item in arr1)
            {
              dic.Add(Convert.ToInt32(item));
            }
            int roundSumm=dic.Sum()/dic.Count;

            var count = 0;
            foreach (var num in dic)
            {
                if (num > roundSumm)
                {
                    count++;
                    resDic.Add(dic.IndexOf(num));
                }
            }
            Console.WriteLine(count);
            foreach (var x in resDic)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}
