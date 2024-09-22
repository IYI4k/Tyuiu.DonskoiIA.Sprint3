using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint3.Task1.V11.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя значения: a, k, n. *");
            Console.WriteLine("* Затем она должна посчитать значение формулы и вывести результат на      *");
            Console.WriteLine("* экран. Требуется использовать цикл for.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                              n                                          *");
            Console.WriteLine("*                              П (a^k + 0.5)                              *");
            Console.WriteLine("*                              k                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a;

            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());

            int k;

            Console.WriteLine("Введите значение k:");
            k = Convert.ToInt32(Console.ReadLine());

            int n;

            Console.WriteLine("Введите значение n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(a, k, n));

            Console.ReadLine();
        }
    }
}