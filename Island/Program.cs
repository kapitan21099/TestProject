using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Island
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int col = 10; //Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rand.Next(0, 2);

                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int result = 0;
            for (int i = 1; i < row - 1; i++)
            {
                for (int j = 1; j < col - 1; j++)
                {
                    if (array[i, j] == 1 && array[i - 1, j - 1] == 0 && array[i, j - 1] == 0 && array[i + 1, j - 1] == 0 && array[i - 1, j] == 0 && array[i + 1, j] == 0 && array[i - 1, j + 1] == 0 && array[i, j + 1] == 0 && array[i + 1, j + 1] == 0)
                    {
                        result++;
                    }

                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
