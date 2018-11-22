using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxFlowTest
{
    public class TestGenerator
    {
        public static Random rnd = new Random();

        public static int[,] Test(int n, int count, out int s)
        {
            s = 0;
            int[,] output = new int[n, n];

            #region Генерация норм матрицы с выводом
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i < n / 2 && j > n / 2)
                    {
                        output[i, j] = rnd.Next(1, 4);

                        s += output[i, j];
                    }
                    else
                        output[i, j] = 0;
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i < n / 2 && j <= n / 2 && j > i)
                        output[i, j] = rnd.Next(s, s + 3);

                    if (i >= n / 2 && j >= n / 2 && j > i)
                        output[i, j] = rnd.Next(s, s + 3);
                }

            FileStream f = new FileStream("Normal matrix " + count + ".txt", FileMode.OpenOrCreate);
            f.Close();
            f = new FileStream("Mixed matrix " + count + ".txt", FileMode.OpenOrCreate);
            f.Close();
            f = new FileStream("Properties " + count + ".txt", FileMode.OpenOrCreate);
            f.Close();


            StreamWriter sw = new StreamWriter("Normal matrix " + count + ".txt");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (j < n - 1) sw.Write(output[i, j] + " ");
                    else sw.Write(output[i, j]);
                sw.WriteLine();
            }
            sw.Close();

            #endregion

            #region Перемешивание строк с выводом
            for (int i = 0; i < n - 1; i++)
            {
                int newline = rnd.Next(0, n - 2);
                for (int j = 1; j < n; j++)
                {
                    int tmp = output[newline, j];
                    output[newline, j] = output[i, j];
                    output[i, j] = tmp;
                }
            }

            StreamWriter sw1 = new StreamWriter("Mixed matrix " + count + ".txt");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (j < n - 1) sw1.Write(output[i, j] + " ");
                    else sw1.Write(output[i, j]);
                sw1.WriteLine();
            }
            sw1.Close();

            #endregion

            #region Вывод данных
            StreamWriter sw2 = new StreamWriter("Properties " + count + ".txt");
            sw2.Write(n);
            sw2.WriteLine();
            sw2.Write(s);
            sw2.Close();
            #endregion

            return output;
        }
    }
}
