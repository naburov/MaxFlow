using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph("input.txt");
            graph.GetMaxFlow(out int Length);
        }
    }
}
