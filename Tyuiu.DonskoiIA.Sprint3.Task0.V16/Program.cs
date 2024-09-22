using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя значения: x, k, n. *");
            Console.WriteLine("* Затем она должна посчитать значение формулы и вывести результат на      *");
            Console.WriteLine("* экран.                                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                              n   x                                      *");
            Console.WriteLine("*                              П (---)^3                                  *");
            Console.WriteLine("*                              k   k                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            int k;

            Console.WriteLine("Введите значение k:");
            k = Convert.ToInt32(Console.ReadLine());

            int n;

            Console.WriteLine("Введите значение n:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(x, k, n));

            Console.ReadLine();
        }
    }
}