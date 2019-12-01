using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "COME 7\nWORRY 1\nWORRY 4\nCOME - 2\nWORRY 5\nWORRY_COUNT\nCOME 3\nWORRY 3\nWORRY_COUNT";
            String pattern = @"\n";
            String[] elements = System.Text.RegularExpressions.Regex.Split(input, pattern);
            var _worryCount = 0;
            var _worry = 0;
            var _come = 0;
            var _quiet = 0;
            List<int> list = new List<int>();
            foreach (var element in elements)
            {
                if (element.StartsWith("WORRY "))
                {
                    _worry = Convert.ToInt32(element.Remove(0, 5).Replace(" ", ""));
                    if (_worry <= _come)
                    {
                        if (list.Count != 0)
                        {
                            foreach (var i in list)
                            {
                                if (i == _worry)
                                {
                                    Console.WriteLine("This person reapite");
                                }
                                else
                                {
                                    _worryCount++;
                                    //  list.Add(_worry);
                                }
                            }
                        }
                        else
                        {
                            _worryCount++;
                            list.Add(_worry);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else if (element.StartsWith("COME "))
                {
                    _come += Convert.ToInt32(element.Remove(0, 4).Replace(" ", ""));
                }
                else if (element.StartsWith("WORRY_COUNT"))
                {
                    Console.WriteLine(_worryCount);
                }
                else if (element.StartsWith("QUIET"))
                {
                    _quiet = Convert.ToInt32(element.Remove(0, 5).Replace(" ", ""));
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This person do not worry");
                    }
                    else
                    {
                        foreach (var i in list)
                        {
                            if (i == _quiet)
                            {
                                // list.Remove(_quiet);
                                _worryCount--;
                            }
                        }
                    }
                    //  _worryCount--;
                }
            }
            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine($"Worry-{_worryCount} Count in stack-{_come}");
            Console.ReadLine();

        }
    }
}
