using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint3.Task5.V1.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя два числовых       *");
            Console.WriteLine("* отрезка и параметр, после чего вычисляет данную формулу и выводит ответ *");
            Console.WriteLine("* на экран                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                       a b      1                                        *");
            Console.WriteLine("*                       E E ------------                                  *");
            Console.WriteLine("*                       i j  cos(j) + x                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите x:");
            x = Convert.ToInt32(Console.ReadLine());

            int i;

            Console.WriteLine("Введите i:");
            i = Convert.ToInt32(Console.ReadLine());

            int j;

            Console.WriteLine("Введите j:");
            j = Convert.ToInt32(Console.ReadLine());

            int a;

            Console.WriteLine("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());

            int b;

            Console.WriteLine("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, i, j, a, b));

            Console.ReadLine();
        }
    }
}