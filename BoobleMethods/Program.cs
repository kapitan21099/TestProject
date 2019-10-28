using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoobleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array");
            int size;
            String x = Console.ReadLine();
            while (!Int32.TryParse(x, out size))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a valid number, try again.");
                Console.ForegroundColor = ConsoleColor.White;
                x = Console.ReadLine();
            }            
            Console.WriteLine("\nSource array");
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            PrintMass(array);
            int f = array.Length - 1;
            int buffer;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < f; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        buffer = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = buffer;
                    }
                }
                f--;
            }
            Console.WriteLine();
            Console.WriteLine("\nSorted array");
            PrintMass(array);          
            Console.ReadLine();
        }
        public static void PrintMass(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
