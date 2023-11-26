using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string text = File.ReadAllText(path);
                    char[] sep = new char[] { ' ', '.', ',', ':', ';', '!', '?', '\r', '\n', '\t' };
                    string[] words = text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        bool russian = true;
                        foreach (char c in word)
                        {
                            if (!(c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == 'ё' || c == 'Ё'))
                            {
                                russian = false;
                                break;
                            }
                        }
                        if (russian)
                        {
                            count++;
                        }
                    }                    
                }
            }
            return count;
        }
    }
}
