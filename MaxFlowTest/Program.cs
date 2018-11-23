using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxFlowTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (int i = 2; i < 50; i++)
                TestGenerator.Test(i, count++, out int max);
        }
    }
}
