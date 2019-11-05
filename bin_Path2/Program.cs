using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin_Path2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in decimal type");
            int x = Convert.ToInt32(Console.ReadLine());
            string res = "";
            while(x!=0)
            {
                int f = x % 2;
                x /= 2;
                res = String.Concat(f,res);
            }
            Console.ForegroundColor = ConsoleColor.Green;// різні конвертації кольорів шрифтів,фону, з типу в тип роблю щоб запам"ятати синтаксис
            Console.Write("Your number in binary tipe = ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
