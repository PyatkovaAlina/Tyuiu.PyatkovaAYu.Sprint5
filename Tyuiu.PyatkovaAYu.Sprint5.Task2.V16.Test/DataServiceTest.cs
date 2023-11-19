using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PyatkovaAYu.Sprint5.Task2.V16.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint5.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string filePath = @"C:\Users\Professional\source\repos\Tyuiu.PyatkovaAYu.Sprint5\Tyuiu.PyatkovaAYu.Sprint5.Task2.V16\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
