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

namespace pr5
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

        private void infoclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая 5 Кульковой А.\r\nСоздать базовый класс Pair (пара целых чисел). Создать необходимые методы и свойства.\r\n Определить методы с операциями проверки на равенство и перемножения полей.\r\n Реализовать операцию вычитания пар по формуле (а, b) - (с, d) = (а - c, b - d).\r\n Создать перегруженный метод для вычитания трех пар чисел.");
        }

        private void exClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
