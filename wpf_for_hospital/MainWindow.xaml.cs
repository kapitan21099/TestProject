using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_for_hospital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // 1.txt content this text = "COME 7\nWORRY 1\nWORRY 4\nCOME - 2\nWORRY 5\nWORRY_COUNT\nCOME 3\nWORRY 3\nWORRY_COUNT";
            string input = File.ReadAllText(@"C:\Users\Kaptan\Desktop\1.txt");
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
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }
                else if (element.StartsWith("WORRYCOUNT"))
                {
                    lable_2.Content=$"{lable_2.Content}\n{(_buffer = list.Count(x => x))}";
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lable_1.Content= File.ReadAllText(@"C:\Users\Kaptan\Desktop\1.txt");
        }
    }
}
