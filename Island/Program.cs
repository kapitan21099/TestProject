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
            Console.WriteLine("Enter the number of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[,] array = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rand.Next(0, 2);
                    if (array[i, j] == 1)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;
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
            for (int i = 1; i < row - 1; i++)
            {
                if (array[i, 0] == 1 && array[i - 1, 0] == 0 && array[i + 1, 0] == 0 && array[i - 1, 1] == 0 && array[i, 1] == 0 && array[i + 1, 1] == 0)
                {
                    result++;
                }
            }
            for (int i = 1; i < row - 1; i++)
            {
                if (array[i, col-1] == 1 && array[i - 1, col - 1] == 0 && array[i + 1, col - 1] == 0 && array[i - 1, col - 2] == 0 && array[i, col - 2] == 0 && array[i + 1, col - 2] == 0)
                {
                    result++;
                }
            }
            for (int j = 1; j < col - 1; j++)
            {
                if (array[0, j] == 1 && array[0, j-1] == 0 && array[0, j+1] == 0 && array[1, j-1] == 0 && array[1, j] == 0 && array[1, j+1] == 0)
                {
                    result++;
                }
            }
            for (int j = 1; j < col - 1; j++)
            {
                if (array[row-1, j] == 1 && array[row-1, j-1] == 0 && array[row-1, j+1] == 0 && array[row-2, j-1] == 0 && array[row-2, j] == 0 && array[row-2, j+1] == 0)
                {
                    result++;
                }
            }
            if (array[0, 0] == 1 && array[1, 0] == 0 && array[0, 1] == 0 && array[1, 1] == 0)
                result++;
            if (array[row-1, 0] == 1 && array[row-2, 0] == 0 && array[row-2, 1] == 0 && array[row-1, 1] == 0)
                result++;
            if (array[0, col-1] == 1 && array[0, col-2] == 0 && array[1, col-2] == 0 && array[1, col-1] == 0)
                result++;
            if (array[row-1, col-1] == 1 && array[row-2, col-1] == 0 && array[row-1, col-2] == 0 && array[row-2, col-2] == 0)
                result++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Number island is " + result);
            Console.ReadLine();
        }
    }
}
