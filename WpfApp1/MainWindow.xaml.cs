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

namespace WpfApp1
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

        private void check_Click(object sender, RoutedEventArgs e)
        {
            Core core = new Core();
            if (core.TestOfTriangle(Convert.ToDouble(firstInput.Text), Convert.ToDouble(secondInput.Text), Convert.ToDouble(thirdInput.Text)))
            {
                canThreangelBeOutput.Content = "Треугольник существует";
            }
            else canThreangelBeOutput.Content = "Неверный ввод или треугольник не существует";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            firstInput.Text = "";
            secondInput.Text = "";
            thirdInput.Text = "";
            canThreangelBeOutput.Content = "Введите длину сторон треугольника";
        }
    }
}
