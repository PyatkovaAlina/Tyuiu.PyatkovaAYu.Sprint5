using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        static bool? IsPrime(double OldNumber)
        {
            if (OldNumber % 1 != 0)
            { return null; }
            int number = (int)OldNumber;
            if (number < 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            int tpm = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= tpm; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double number = double.Parse(line);
                    bool? Prime = IsPrime(number);
                    if (Prime.HasValue)
                    {
                        if (Prime == true)
                        {
                            res += number;
                        }
                    }
                }
            }
            return res;
        }
    }
}
