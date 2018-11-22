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
            var graph = new MaximumFlow.Graph(filename);
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
            string filename = place+"\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int count = 3;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int count = 4;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int count = 5;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int count = 6;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int count = 7;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int count = 8;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int count = 9;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod9()
        {
            int count = 10;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int count = 11;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int count = 12;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod12()
        {
            int count = 13;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod13()
        {
            int count = 14;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod14()
        {
            int count = 15;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod15()
        {
            int count = 16;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod16()
        {
            int count = 17;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }


        [TestMethod]
        public void TestMethod17()
        {
            int count = 18;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod18()
        {
            int count = 19;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod19()
        {
            int count = 20;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod20()
        {
            int count = 21;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod21()
        {
            int count = 22;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod22()
        {
            int count = 23;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod23()
        {
            int count = 24;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod24()
        {
            int count = 25;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod25()
        {
            int count = 26;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod26()
        {
            int count = 27;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod27()
        {
            int count = 28;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }


        [TestMethod]
        public void TestMethod28()
        {
            int count = 29;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod29()
        {
            int count = 30;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod30()
        {
            int count = 31;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod31()
        {
            int count = 32;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod32()
        {
            int count = 33;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod33()
        {
            int count = 34;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod34()
        {
            int count = 35;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }
        [TestMethod]
        public void TestMethod35()
        {
            int count = 36;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod36()
        {
            int count = 37;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }


        [TestMethod]
        public void TestMethod37()
        {
            int count = 38;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod38()
        {
            int count = 39;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod39()
        {
            int count = 40;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod41()
        {
            int count = 42;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod43()
        {
            int count = 44;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod44()
        {
            int count = 45;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod46()
        {
            int count = 47;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod47()
        {
            int count = 48;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod48()
        {
            int count = 49;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }

        [TestMethod]
        public void TestMethod49()
        {
            int count = 50;
            string filename = place + "\\Normal Matrix" + String.Format(" {0}.txt", count);
            string filenameAns = place + "\\Properties" + String.Format(" {0}.txt", count++);
            int l = Test(filename);
            int a = GetAnswer(filenameAns);
            Assert.AreEqual(l, a);
        }


    }
}
