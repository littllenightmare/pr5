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
        /// <summary>
        /// Свойства (авто) А и Б
        /// </summary>
        public int A { get; set; } public int B { get; set; }
        /// <summary>
        /// Конструктор пар
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        public Pair (int a, int b)
        {
            A = a; B = b;
        }
        /// <summary>
        /// Метод сравнения равенства первого числа пары и второго
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <returns>строку с информацией</returns>
        public string equal(Pair next)
        {
            string first, second;
            if (A == B) first = "равна"; else first = "не равна";
            if (next.A == next.B) second = "равна"; else second = "не равна";
            string info = "Первая пара " + first + ", вторая пара " + second;
            return info;
        }
        /// <summary>
        /// Метод для умножения чисел в паре
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <param name="first">умноженное число первой пары</param>
        /// <param name="second">умноженное число второй пары</param>
        public void multiply(Pair next, out int first, out int second)
        {
           first = A*B; second = next.A*next.B;
        }
        /// <summary>
        /// Метод для вычитания 2 пар
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <returns>строку с ответом</returns>
        public string subtraction (Pair next)
        {
            int a = A - next.A;
            int b = B - next.B;
            string sub = $"{a},{b}";
            return sub;
        }
        /// <summary>
        /// Перегруженный метод для вычитания 3 пар
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <param name="third">третья пара</param>
        /// <returns>строку с ответом</returns>
        public string subtracion (Pair next, Pair third)
        {
            int a = A - next.A - third.A;
            int b = B - next.B - third.B;
            string sub = $"{a},{b}";
            return sub;
        }
    }
}
