using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint3.Task3.V24.Lib;

namespace Tyuiu.DonskoiIA.Sprint3.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя строку, заменяемый *");
            Console.WriteLine("* символ и на какой символ его надо заменить. Затем выводит новую строку  *");
            Console.WriteLine("* на экран. Требуется использовать foreach                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str;

            Console.WriteLine("Введите строку:");
            str = Console.ReadLine();

            char kogo;

            Console.WriteLine("Введите заменяемый символ:");
            kogo = Convert.ToChar(Console.ReadLine());

            char kem;

            Console.WriteLine("Введите на какой символ его надо поменять:");
            kem = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ReplaceCharInString(str, kogo, kem));

            Console.ReadLine();
        }
    }
}