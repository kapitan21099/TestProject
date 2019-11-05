using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1111112;
            int number1 = 128;
            int numStr;
            int j = 0;
            int[] mass1 = new int[number1];
            string[] mass2 = new string[number];
            for (int i = 0; i < 1111112; i++)
            {
                mass2[i] = Convert.ToString(i);
                if (mass2[i].Contains('2') || mass2[i].Contains('3') || mass2[i].Contains('4') || mass2[i].Contains('5') || mass2[i].Contains('6') || mass2[i].Contains('7') || mass2[i].Contains('8') || mass2[i].Contains('9'))
                { int f = 5; }
                else
                {
                    mass1[j] = Convert.ToInt32(mass2[i]);
                    j++;
                }
            }
            Console.WriteLine("Enter number in decimal type from 0 to 127");
            numStr = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYour number in binary tipe  "+mass1[numStr]);
            Console.ReadLine(); 
        }
    }
}
