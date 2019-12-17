using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

namespace Deleter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private object file;

        public MainWindow()
        {
            InitializeComponent();
            label1.Content = "bla bla";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Created();
        }
        async public void Created()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                int number = rnd.Next(0, 100);
                string path = $@"C:\Users\Kaptan\Desktop\folder\{number}.txt";
                if (File.Exists(path)==false)
                {
                    File.Create(path);
                    label1.Content = $" Number {i}";
                    await Task.Delay(200);
                }
            }
        }
        async public void Deleted()
         {
            for (int i = 0; i < 100; i++)
            {
                string path = $@"C:\Users\Kaptan\Desktop\folder\{i}.txt";
                File.Delete(path);
                label1.Content = $" Number {i}";
                await Task.Delay(50);
            }
         }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Deleted();
        }
    }
}
