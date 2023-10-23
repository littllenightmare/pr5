using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    class Pair
    {
        int a, b, c, d, e, f;
        public int[] firstpair { get; set; }
        public int[] secondpair { get; set; }
        public int[] thirdpair { get; set; }

        public Pair (int a, int b)
        {
           
        }
        /// <summary>
        /// Функция для сравнения чисел в паре
        /// </summary>
        /// <param name="A">первое число первой пары</param>
        /// <param name="B">второе число первой пары</param>
        /// <param name="C">первое число второй пары</param>
        /// <param name="D">второе число второй пары</param>
        /// <returns>строка с указанием равенства или неравенства</returns>
        public string equals(int A, int B, int C, int D)
        {
            string first, second;
            if (A == B) first = "равна"; else first = "не равна";
            if (C == D) second = "равна"; else second = "не равна";
            string info = "Первая пара " + first + ", вторая пара " + second;
            return info;
        }
        /// <summary>
        /// Функция для умножения чисел в паре
        /// </summary>
        /// <param name="a">первое число первой пары</param>
        /// <param name="b">второе число первой пары</param>
        /// <param name="c">первое число второй пары</param>
        /// <param name="d">второе число второй пары</param>
        /// <param name="first">умножение первой пары</param>
        /// <param name="second">умножение второй пары</param>
        public void multiply(int a, int b, int c, int d, out int first, out int second)
        {
           first = a*b; second = d*c;
        }
    }
}
