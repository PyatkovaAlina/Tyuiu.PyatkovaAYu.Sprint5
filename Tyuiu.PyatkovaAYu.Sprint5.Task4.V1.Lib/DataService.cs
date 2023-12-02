using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            double number = Convert.ToDouble(strX);
            double res = ((1 / (Math.Cos(number) + number)) - 4.12 * number);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
