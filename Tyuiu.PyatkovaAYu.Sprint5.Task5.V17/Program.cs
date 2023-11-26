using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint5.Task5.V17.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                              *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                         *");
            Console.WriteLine("* Задание #5                                                                             *");
            Console.WriteLine("* Вариант #17                                                                            *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                                     *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Дан файл 'InPutDataFileTask5V17.txt' в котором есть набор значений.                    *");
            Console.WriteLine("* Найти сумму всех простых целых чисел в файле. Полученный результат вывести на консоль. *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine("******************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Сумма элементов файла = " + res);
            Console.ReadKey();
        }
    }
}
