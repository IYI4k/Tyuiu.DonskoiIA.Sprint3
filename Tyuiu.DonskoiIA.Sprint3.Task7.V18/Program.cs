using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint3.Task7.V18.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя числовой           *");
            Console.WriteLine("* промежуток, находит значения функции при целых x и выводит полученный   *");
            Console.WriteLine("* массив на экран                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                               2x-3                                      *");
            Console.WriteLine("*                           ------------ + 5                              *");
            Console.WriteLine("*                            cos(x) + x                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x1;

            Console.WriteLine("Введите начальное число:");
            x1 = Convert.ToInt32(Console.ReadLine());

            int x2;

            Console.WriteLine("Введите конечное число:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            foreach (double i in ds.GetMassFunction(x1, x2))
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}