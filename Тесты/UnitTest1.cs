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
            int count = 2;
            string filename = place+"\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int count = 3;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int count = 4;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int count = 5;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int count = 6;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int count = 7;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int count = 8;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int count = 9;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod9()
        {
            int count = 10;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int count = 11;
            string filename = place + "\\Mixed Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }
    }
}
