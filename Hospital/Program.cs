using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common_Helpers;

using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "COME 7\nWORRY 1\nWORRY 4\nCOME - 2\nWORRY 5\nWORRY_COUNT\nCOME 3\nWORRY 3\nWORRY_COUNT";
            String pattern = @"\n";
            String[] elements = Regex.Split(input, pattern);
            var _buffer = 0;
            List<bool> list = new List<bool>();
            foreach (var element in elements)
            {
                if (element.StartsWith("WORRY "))
                {
                    _buffer = Convert.ToInt32(element.Remove(0, 5).Replace(" ", ""));
                    if (_buffer <= list.Count)
                    {
                        if (list.Count != 0 && list[_buffer - 1] != true)
                        {
                            list[_buffer - 1] = true;
                        }
                        else
                        {
                            Console.WriteLine("This person reapite");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. List is clear");
                    }
                }
                else if (element.StartsWith("COME "))
                {
                    _buffer = Convert.ToInt32(element.Remove(0, 4).Replace(" ", ""));
                    if (_buffer > 0)
                    {
                        for (int i = 0; i < _buffer; i++)
                        {
                            list.Add(false);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Math.Abs(_buffer); i++)
                        {
                            list.RemoveLast();
                        }
                    }
                }
                else if (element.StartsWith("WORRY_COUNT"))
                {
                    Console.WriteLine(_buffer = list.Count(x => x));
                }
                else if (element.StartsWith("QUIET"))
                {
                    _buffer = Convert.ToInt32(element.Remove(0, 5).Replace(" ", ""));
                    if (list[_buffer] == true)
                    {
                        list[_buffer] = false;
                    }
                    else
                    {
                        Console.WriteLine("This person do not worry");
                    }
                }
            }
            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }
            Console.ReadLine();
        }
    }
}
