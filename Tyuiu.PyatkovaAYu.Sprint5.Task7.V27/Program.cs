using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Tyuiu.PyatkovaAYu.Sprint5.Task7.V27.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task7.V27
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
            Console.WriteLine("* Задание #7                                                                             *");
            Console.WriteLine("* Вариант #27                                                                            *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                                     *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Дан файл 'InPutDataFileTask7V27.txt' в котором есть набор символьных данных.           *");
            Console.WriteLine("* Удалить все пробелы, идущие подряд больше одного.                                      *");
            Console.WriteLine("* Полученный результат сохранить в файл 'OutPutDataFileTask7V27.txt'.                    *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V27.txt";

            string outputfilePath = "C:\\DataSprint5\\OutPutDataFileTask7V27.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            try
            {
                string text = File.ReadAllText(path);

                string regex = Regex.Replace(text, @"\s+", " ");

                File.WriteAllText(outputfilePath, regex);
                Console.WriteLine("Запись в файл произошла успешно");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка:" + ex.ToString());
            }

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Находится в файле:                                                                     *");
            Console.WriteLine(outputfilePath);
            Console.ReadKey();
        }
    }
}
