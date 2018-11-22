using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace MaximumFlow
{
    public class Graph
    {
        private int n;
        private Stack<int> path = new Stack<int>();

        private int[,] graph;
        private int[,] residualCapacity;
        private int[,] changes;
        private int[,] maxFlow;

        public Graph() { }

        public Graph(string path)
        {
            ReadFromFile(path);
        }

        public void ReadFromFile(string path)
        {
            var sr = new StreamReader(path);

            var args = sr.ReadLine().Split();

            n = args.Length;

            graph = new int[n, n];

            for (int i = 0; i < n; i++)
                graph[0, i] = int.Parse(args[i]);

            for (int i = 1; i < n; ++i)
            {
                args = sr.ReadLine().Split();

                for (int j = 0; j < n; ++j)
                    graph[i, j] = int.Parse(args[j]);
            }

            residualCapacity = new int[n, n];
            Array.Copy(graph, residualCapacity, n * n);

            changes = new int[n, n];
            Array.Copy(graph, changes, n * n);

            maxFlow = new int[n, n];
        }

        public void GetMaxFlow(out int maxFlowLength, int start = 0)
        {
            int i = 0;
            int n = graph.GetLength(0);

            Print();
            PrintResidual();

            while (i < n)
            {
                if (graph[start, i] > 0)
                {
                    if (DFS(start) == 0)
                        ++i;

                    PrintResidual();
                }
                else
                    ++i;
            }

            graph = maxFlow;

            maxFlowLength = 0;

            for (int j = 0; j < n; ++j)
            {
                maxFlowLength += graph[0, j];
            }

            Console.WriteLine("---------------------------------------------\n");
            Console.WriteLine($"Length of max flow = {maxFlowLength}\n");

            Print();

            //Console.ReadLine();
        }

        private int DFS(int start, int minFlow = int.MaxValue, int prev = -1)
        {
            if (start == 0)
                path.Clear();

            if (prev == -1)
                prev = start;

            if (start == n - 1)
                return minFlow;

            for (int i = 0; i < n; ++i)
            {
                if (i == prev)
                    continue;

                if (residualCapacity[start, i] > 0)
                {
                    if (path.Contains(i))
                        continue;
                    
                    path.Push(i);

                    var dfs = DFS(i, Math.Min(minFlow, residualCapacity[start, i]), start);

                    if (dfs == 0)
                        continue;

                    minFlow = Math.Min(minFlow, dfs);

                    residualCapacity[start, i] -= minFlow;
                    residualCapacity[i, start] -= minFlow;
                    maxFlow[start, i] += minFlow;

                    return minFlow;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                if (i == prev)
                    continue;

                if (residualCapacity[i, start] > 0 && residualCapacity[start, i] < 0)
                {
                    var dfs = DFS(i, Math.Min(minFlow, -residualCapacity[start, i]), start);

                    if (dfs == 0)
                        continue;

                    minFlow = Math.Min(minFlow, dfs);

                    residualCapacity[start, i] += minFlow;
                    residualCapacity[i, start] += minFlow;

                    return minFlow;
                }
            }

            return 0;
        }

        private void Print()
        {
            Console.WriteLine("Оригинальный граф:");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                    Console.Write($"{graph[i, j],2} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private void PrintResidual()
        {
            bool hasChanges = false;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (changes[i, j] != residualCapacity[i, j])
                    {
                        hasChanges = true;
                        break;
                    }
                }

                if (hasChanges)
                    break;
            }

            if (!hasChanges)
                return;

            Console.WriteLine("Остаточная сеть:");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (changes[i, j] != residualCapacity[i, j])
                    {
                        if (residualCapacity[i, j] >= 0)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write($"{residualCapacity[i, j],2} ");

                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                        Console.Write($"{residualCapacity[i, j],2} ");
                }

                Console.WriteLine();
            }

            Array.Copy(residualCapacity, changes, graph.Length);

            Console.WriteLine();
        }
    }
}
