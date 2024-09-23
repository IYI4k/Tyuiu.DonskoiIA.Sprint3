using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint3.Task2.V11.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя значения: x, i, n. *");
            Console.WriteLine("* Затем она должна посчитать значение формулы и вывести результат на      *");
            Console.WriteLine("* экран. Требуется использовать конструкцию do-while.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                              n     1                                    *");
            Console.WriteLine("*                              E (-------)^i                              *");
            Console.WriteLine("*                              i   3+x^i                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            int i;

            Console.WriteLine("Введите значение i:");
            i = Convert.ToInt32(Console.ReadLine());

            int n;

            Console.WriteLine("Введите значение n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(x, i, n));

            Console.ReadLine();
        }
    }
}