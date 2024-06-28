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

namespace lab2
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

        private void geom_Click(object sender, RoutedEventArgs e)
        {
            Exponential exp = new Exponential(int.Parse(number.Text), int.Parse(iter.Text));
            int text = int.Parse(iter.Text);
            res.Text = exp.GetElement(text).ToString();
        }

        private void arf_Click(object sender, RoutedEventArgs e)
        {
            Linear lin = new Linear(int.Parse(number.Text), int.Parse(iter.Text));
            int text = int.Parse(iter.Text);
            res.Text = lin.GetElement(text).ToString();
        }
    }
}
