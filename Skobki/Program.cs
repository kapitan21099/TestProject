using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Skobki
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInt;
            int size = 0;
            sInt = Console.ReadLine();
            //Console.WriteLine(sInt);
            char[] simv0lMass = sInt.ToCharArray();
            string finishString = "";
            for (int i = 0; i < simv0lMass.Length; i++)
            {
                if (simv0lMass[i] == '(' || simv0lMass[i] == ')')
                {
                    finishString += simv0lMass[i];
                    size++;
                }
            }
            Console.WriteLine(finishString + "  " + finishString.Length);
            string sminus = "()";
            string resultString = finishString.Replace(sminus, "");
            for (int i = 0; i < finishString.Length; i++)
            {
                resultString = resultString.Replace(sminus, "");
            }
            if (resultString.Length != 0)
            {
                Console.WriteLine("Skobki postavleny ne pravil'no");
            }
            Console.WriteLine(resultString + "  " + resultString.Length);
            Console.ReadLine();
        }
    }
}
