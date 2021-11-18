using System;
using System.Collections.Generic;
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

namespace Wpf1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Box_Click(object sender, RoutedEventArgs e)
        {
            ch1.Clear();
            ch.Clear();
            c1.Clear();
            
        }

        private void Box2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Box1_Click(object sender, RoutedEventArgs e)
        {
            int q = Convert.ToInt32(ch1.Text);
            int n = Convert.ToInt32(ch.Text);
            int y = Convert.ToInt32(c1.Text);

            if (checkBox1.IsChecked == true)
            {
                int d = (((q * n * y) / 100) * 2);
                checkB1.Text = Convert.ToString(d);

            }
            if (checkBox1.IsChecked == false)
            {
                int d = ((q * n * y) / 100);
                checkB1.Text = Convert.ToString(d);

            }
        }
    }
}
