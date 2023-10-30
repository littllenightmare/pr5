using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    class Pair
    {
        /// <summary>
        /// Свойства (авто) А и Б
        /// </summary>
        public int A { get; set; }
        public int B { get; set; }
        /// <summary>
        /// Конструктор пар
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        public Pair(int a, int b)
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
            first = A * B; second = next.A * next.B;
        }
        /// <summary>
        /// Метод для вычитания 2 пар
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <returns>строку с ответом</returns>
        public string subtraction(Pair next)
        {
            int a = A - next.A;
            int b = B - next.B;
            string sub = $"{a} {b}";
            return sub;
        }
        /// <summary>
        /// Перегруженный метод для вычитания 3 пар
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <param name="third">третья пара</param>
        /// <returns>строку с ответом</returns>
        public string subtraction(Pair next, Pair third)
        {
            int a = A - next.A - third.A;
            int b = B - next.B - third.B;
            string sub = $"{a},{b}";
            return sub;
        }
        /// <summary>
        /// Перегруженный бинарный оператор тру
        /// </summary>
        /// <param name="one">пара</param>
        /// <returns>тру, если числа в паре одинаковые; фолс, если числа разные</returns>
        public static bool operator true(Pair one)
        {
            if (one.B == one.A) return true;
            else return false;
        }
        /// <summary>
        /// Перегруженный бинарный оператор фолс
        /// </summary>
        /// <param name="one">пара</param>
        /// <returns>фолс, если числа в паре разные</returns>
        public static bool operator false(Pair one)
        {
            return one.A == one.B;
        }
        /// <summary>
        /// Перегруженный бинарный оператор вычитания
        /// </summary>
        /// <param name="one">первая пара</param>
        /// <param name="next">вторая пара</param>
        /// <returns>результат вычислений по формуле</returns>
        public static string operator -(Pair one, Pair next)
        {
            int a, b;
            a = one.A - next.A;
            b = one.B - next.B;
            Pair result = new Pair(a, b);
            return $"{a},{b}";
        }
    }
    class Rational : Pair
    {

        /// <summary>
        /// Конструктор пар
        /// </summary>
        /// <param name="a">первое число пары</param>
        /// <param name="b">второе число пары</param>
        public Rational(int a, int b) : base(a, b)
        {

        }
        /// <summary>
        /// Метод суммирования пар
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <returns>пару, являющуюся суммой</returns>
        public Rational summary(Rational next)
        {
            int a = A * next.B;
            int b = B * next.A;
            int sum = a + b;
            Rational summa = new Rational(sum, B * next.B);
            return summa;
        }
        /// <summary>
        /// Метод деления пар
        /// </summary>
        /// <param name="next">вторая пара</param>
        /// <returns>пару, являющуюся результатом деления</returns>
        public Rational division (Rational next)
        { 
            Rational sub = new Rational(A*next.B, B * next.A);
            return sub;
        }
  /// <summary>
  /// Метод вычитания пар
  /// </summary>
  /// <param name="next">вторая пара</param>
  /// <returns>пару, являющуюся результатом вычитания</returns>
        public Rational subtraction(Rational next)
        {
            Rational sub = new Rational(A * next.B - B * next.A, B * next.B);
            return sub;
        }
    }
}
     
