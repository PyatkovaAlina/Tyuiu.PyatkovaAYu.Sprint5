using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint5.Task6.V15.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task6.V15
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
            Console.WriteLine("* Задание #6                                                                             *");
            Console.WriteLine("* Вариант #17                                                                            *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                                     *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Дан файл 'InPutDataFileTask6V15.txt' в котором есть набор символьных данных.           *");
            Console.WriteLine("* Найти количество русских слов в заданной строке.                                       *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V15.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine("******************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество русских слов в файле = " + res);
            Console.ReadKey();
        }
    }
}
