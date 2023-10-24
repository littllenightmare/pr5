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
        int first = 0; int second = 0; int third = 0; int a = 0; int b=0;
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

        public void enterClick(object sender, RoutedEventArgs e)
        {  
            
            if (Int32.TryParse(entertb.Text, out int val) == true)
            {
                if (first == 0)
                {
                    if (a == 0)
                    {
                        a = Convert.ToInt32(entertb.Text);
                    }
                    else
                    {
                        b = Convert.ToInt32(entertb.Text);
                        Pair firstpair = new Pair(a, b);
                        first = 1;
                        fptb.Text = Convert.ToString(firstpair.A) + " " + Convert.ToString(firstpair.B);
                        a = 0; b = 0;
                    }
                }
                else if (second == 0)
                {
                    if(a == 0)
                    {
                        a = Convert.ToInt32(entertb.Text);
                    }
                    else
                    {
                        b = Convert.ToInt32(entertb.Text);
                        Pair secondpair = new Pair(a,b);
                        second = 1;
                        sptb.Text= Convert.ToString(secondpair.A) + " " + Convert.ToString (secondpair.B);
                        a = 0; b = 0;
                    }
                }
                else if(third == 0)
                {
                    if(a==0)
                    {
                        a = Convert.ToInt32(entertb.Text);
                    }
                    else
                    {
                        b = Convert.ToInt32(entertb.Text);
                        Pair thirdpair = new Pair(a, b);
                        third = 1;
                        tptb.Text=Convert.ToString(thirdpair.A) + " " + Convert.ToString(thirdpair.B);
                        a = 0; b = 0;
                    }
                }
                entertb.Text = "";
            }
        }

        private void delClick(object sender, RoutedEventArgs e)
        {
            fptb.Text = "";
            sptb.Text = "";
            tptb.Text = "";
        }

        private void rasClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
