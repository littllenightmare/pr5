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
        int first = 0; int second = 0; int third = 0; int a = 0; int b=0;//для будущего введения чисел
        public MainWindow()
        {
            InitializeComponent();
        }

        private void infoclick(object sender, RoutedEventArgs e)//инфокнопка
        {
            MessageBox.Show("Практическая 5 Кульковой А.\r\nСоздать базовый класс Pair (пара целых чисел). Создать необходимые методы и свойства.\r\n Определить методы с операциями проверки на равенство и перемножения полей.\r\n Реализовать операцию вычитания пар по формуле (а, b) - (с, d) = (а - c, b - d).\r\n Создать перегруженный метод для вычитания трех пар чисел.");
        }

        private void exClick(object sender, RoutedEventArgs e)//кнопка выхода
        {
            this.Close();
        }

        public void enterClick(object sender, RoutedEventArgs e)//кнопка вводы числа
        {  
            
            if (Int32.TryParse(entertb.Text, out int val)& Convert.ToInt32(val)!=0 == true)//проверка на то, что в текстбоксе; если числа и первый текстбокс не заполнен, вписываем туда и в первую пару значения
            {
                if (first == 0)
                {
                    if (a == 0)
                    {
                        a = Convert.ToInt32(entertb.Text);
                    }
                    else//дальше если первое число уже появилось, вписываем во второе; обнуляем а и б, закрываем доступ к первому
                    {
                        b = Convert.ToInt32(entertb.Text);
                        Pair firstpair = new Pair(a, b);
                        first = 1;
                        fptb.Text = Convert.ToString(firstpair.A) + " " + Convert.ToString(firstpair.B);
                        a = 0; b = 0;
                    }
                }
                else if (second == 0)//иначе если второй не заполнен, заполняем его
                {
                    if(a == 0)
                    {
                        a = Convert.ToInt32(entertb.Text);
                    }
                    else//и второе число тоже заполняем
                    {
                        b = Convert.ToInt32(entertb.Text);
                        Pair secondpair = new Pair(a,b);
                        second = 1;
                        sptb.Text= Convert.ToString(secondpair.A) + " " + Convert.ToString (secondpair.B);
                        a = 0; b = 0;
                    }
                }
                else if(third == 0)//иначе если пользователь начал заполнять третий, позволяем
                {
                    if(a==0)
                    {
                        a = Convert.ToInt32(entertb.Text);
                    }
                    else//и второе число третьей пары
                    {
                        b = Convert.ToInt32(entertb.Text);
                        Pair thirdpair = new Pair(a, b);
                        third = 1;
                        tptb.Text=Convert.ToString(thirdpair.A) + " " + Convert.ToString(thirdpair.B);
                        a = 0; b = 0;
                    }
                }
                entertb.Text = "";//каждый раз после введения числа стираем его
            }
        }

        private void delClick(object sender, RoutedEventArgs e)//кнопка очистки, очищает текстбоксы, ответы и значения
        {
            fptb.Text = "";
            sptb.Text = "";
            tptb.Text = "";
            stb.Text = "";
            mtb.Text = "";
            first = 0; second = 0; third = 0;
        }

        private void rasClick(object sender, RoutedEventArgs e)//кнопка расчёта, смотрим на введённые значения, добавляем в строковый массив вместе с разделителем
        {
            string userInput1 = fptb.Text;
            string userInput2 = sptb.Text;
            string userInput3 = tptb.Text;
            string[] firsty = userInput1.Split(' ');
            string[] secondy = userInput2.Split(' ');
            string[] thirdy = userInput3.Split(' ');
            if (firsty.Length == 2 & secondy.Length == 2)//если в строковых массивах превой и второй пары по 2 значения, заполняем числа в строковые массивы, добавляем их в пару
            {
                int a, b, c, d, ma, mb;
                a = Convert.ToInt32(firsty[0]); 
                b = Convert.ToInt32(firsty[1]);
                c = Convert.ToInt32(secondy[0]);
                d = Convert.ToInt32(secondy[1]);
                Pair firstpair = new Pair(a, b);
                Pair secondpair = new Pair(c, d);

                MessageBox.Show( firstpair.equal(secondpair));//вызываем метод для сравнения чисел в паре, добавляем в месседжбокс
                firstpair.multiply(secondpair, out ma, out mb);//вызываем метод для умножения чисел в паре
                mtb.Text = (ma + " " + mb);//добавляем результат в текстбокс
                stb.Text = firstpair.subtraction(secondpair);//вызываем метод вычитания
                if (thirdy.Length == 2)//если есть третья пара, добавляем её и вызываем перегруженый метод для вычитания 3 пар
                {
                    int g, f;
                    g = Convert.ToInt32(thirdy[0]);
                    f = Convert.ToInt32(thirdy[1]);
                    Pair thirdpair = new Pair(g, f);
                   stb.Text = firstpair.subtraction(secondpair, thirdpair);
                }

            }

        }

        private void secondpr_Click(object sender, RoutedEventArgs e)
        {
            string userInput1 = fptb.Text;
            string userInput2 = sptb.Text;
            string[] firsty = userInput1.Split(' ');
            string[] secondy = userInput2.Split(' ');
            if (firsty.Length == 2 & secondy.Length == 2)//если в строковых массивах превой и второй пары по 2 значения, заполняем числа в строковые массивы, добавляем их в пару
            {
                int a, b, c, d;
                a = Convert.ToInt32(firsty[0]);
                b = Convert.ToInt32(firsty[1]);
                c = Convert.ToInt32(secondy[0]);
                d = Convert.ToInt32(secondy[1]);
                Pair firstpair = new Pair(a, b);
                Pair secondpair = new Pair(c, d);

                if (firstpair)
                {
                    bool tru = true;
                    if(tru == true)  MessageBox.Show("Первая пара равна");
                }
                else MessageBox.Show("Первая пара не равна");
                if (secondpair)
                {
                    bool tru = true;
                    if (tru == true) MessageBox.Show("Вторая пара равна");
                }
                else MessageBox.Show("Вторая пара не равна");
                stb.Text = Convert.ToString((firstpair - secondpair));
            }
        }
    }
}
