using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint5.Task4.V1.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                              *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                                *");
            Console.WriteLine("* Задание #5                                                                             *");
            Console.WriteLine("* Вариант #1                                                                             *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                                     *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Дан файл 'InPutDataFileTask4V1.txt' в котором есть вещественное значение.              *");
            Console.WriteLine("* Прочитать значение из файла и подставить его вместо Х в формуле  y=1/(cos(x)+x)-4.12x  *");
            Console.WriteLine("* Вычислить значение по формуле и вернуть полученный результат на консоль.               *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine("******************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
