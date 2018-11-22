using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MaximumFlow;


namespace Тесты
{
    [TestClass]
    public class UnitTest1
    {
        
        string place = "D:\\Учёба\\2 курс\\Алгоритмы и структуры данных\\Максимальный поток\\Создание тестовых файлов\\bin\\Debug";
        static int count = 2;

        private static int Test(string filename)
        {
            var graph = new Graph(filename);
            graph.GetMaxFlow(out int l);
            return l;
        }

        private static int GetAnswer(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            sr.ReadLine();
            return int.Parse(sr.ReadLine());
        }
        [TestMethod]
        public void TestMethod1()
        {
            string filename = place+"\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }
    }
}
