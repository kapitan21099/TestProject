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
            Console.WriteLine("Vvedite kolichestvo elementov v sluchainom massive");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIshodniy massiv");
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            int f = array.Length - 1;
            int buffer;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < f; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        buffer = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = buffer;
                    }
                }
                f--;
            }
            Console.WriteLine();
            Console.WriteLine("\nOtsortirovanniy massiv");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
