using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint5.Task2.V16.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 2, -4, -8 },
                                          { 3, -7, -2 },
                                          { 3, 8, 6 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                 *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл                        *");
            Console.WriteLine("* Задание #2                                                                                *");
            Console.WriteLine("* Вариант #16                                                                               *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                                        *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                  *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.                         *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.                      *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                          *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("Массив: ");

            int size = 3;
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{i}; {j} = ");
                    arr[i, j] = int.Parse(Console.ReadLine());

                }

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i, j] > 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            StringBuilder table = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                table.AppendLine();
                for (int j = 0; j < size; j++)
                {
                    table.Append(arr[i, j] + " ");
                }

            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
               
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           
            Console.WriteLine(table.ToString());
            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
