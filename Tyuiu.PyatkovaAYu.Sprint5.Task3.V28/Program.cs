using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint5.Task3.V28.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                           *");
            Console.WriteLine("* Задание #3                                                                    *");
            Console.WriteLine("* Вариант #28                                                                   *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                            *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дано выражение y = -0.25 * (x^3 - 3x^2 + 4) вычислить его значение при x = 3, *");
            Console.WriteLine("* Результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль. *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            Console.WriteLine("Значение выражения = -1");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
