using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint5.Task1.V4.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = cos(x) / (x + 1) - cos(x) * 1,3 + 3*x               *");
            Console.WriteLine("* (произвести табулирование) F(x) на заданном диапозоне [-5;5] с шагом 1. *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            StringBuilder table = new StringBuilder();
            table.AppendLine(" x | F(x)");
            string result = "";
            for (double x = -5; x <= 5; x += 1)
            {
                if (x != -1)
                {
                    double fx = (Math.Cos(x) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x;
                    fx = Math.Round(fx, 2);
                    table.AppendLine($"{x} | {fx}");
                    result += " x = " + x.ToString() + " fx = " + fx.ToString() + "\n";

                }
                else
                {
                    double fx = 0;
                    table.AppendLine($"{x} | {fx}");
                    result += " x = " + x.ToString() + " fx = " + fx.ToString() + "\n";
                }
            }

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine(table.ToString());
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
