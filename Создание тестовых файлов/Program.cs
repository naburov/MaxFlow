﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Создание_тестовых_файлов
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 50; i++)
                MaxFlowTest.TestGenerator.Test(i, count++, out int s);
        }
    }
}
