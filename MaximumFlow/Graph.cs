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
        private Stack<int> stackPath;

        private int[,] graph;               // Исходный граф
        private int[,] residualCapacity;    // Остаточная сеть
        private int[,] changes;             // Матрица изменений (debug)
        private int[,] maxFlow;             // Максимальный поток

        public Graph()
        {
            stackPath = new Stack<int>();
        }

        public Graph(string filePath)
        {
            stackPath = new Stack<int>();
            ReadFromFile(filePath);
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

            Print(); // Печать оригинального графа

            PrintResidual(); // debug

            while (i < n)
            {
                // Если существует ребро с вершиной S, запускаем поиск в глубину
                if (graph[start, i] > 0)
                {
                    var dfs = DFS(start);

                    // Если проходимость 0 - переход к следующей вершине
                    if (dfs == 0)
                        ++i;

                    PrintResidual(); // debug
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

            Print(); // Печать максимального потока

            //Console.ReadLine();
        }

        /// <summary>
        /// Поиск в глубину
        /// </summary>
        /// <param name="start"></param>
        /// <param name="minFlow"></param>
        /// <param name="prev"></param>
        /// <returns></returns>
        private int DFS(int start, int minFlow = int.MaxValue, int prev = -1)
        {
            // Если вершина S - очищаем стек
            if (start == 0)
                stackPath.Clear();

            // Если предыдущего элемента нет, то делаем его текущим
            if (prev == -1)
                prev = start;

            // Если вершина T - возвращаем минимальную проходимость
            if (start == n - 1)
                return minFlow;

            // Поиск выходящих рёбер
            for (int i = 0; i < n; ++i)
            {
                if (i == prev)
                    continue;
                
                if (residualCapacity[start, i] > 0)
                {
                    // Пропускаем, если в данную вершину уже заходили
                    if (stackPath.Contains(i))
                        continue;
                    
                    // Добавляем вершину в стек
                    stackPath.Push(i);

                    // Запускаем следующий поиск в глубину от текущей вершины
                    var dfs = DFS(i, Math.Min(minFlow, residualCapacity[start, i]), start);

                    // Если проходимость 0, ищем следующее ребро
                    if (dfs == 0)
                        continue;

                    // Корректируем минимальную проходимость и остаточную сеть
                    minFlow = Math.Min(minFlow, dfs);
                    
                    residualCapacity[start, i] -= minFlow;
                    residualCapacity[i, start] -= minFlow;
                    maxFlow[start, i] += minFlow;

                    return minFlow;
                }
            }

            // Поиск входящих рёбер
            for (int i = 0; i < n; ++i)
            {
                if (i == prev)
                    continue;

                // Если есть обратный путь и заданное ребро не полностью загружено
                if (residualCapacity[start, i] < 0 && residualCapacity[i, start] > 0)
                {
                    // Запускаем следующий поиск в глубину от текущей вершины
                    var dfs = DFS(i, Math.Min(minFlow, -residualCapacity[start, i]), start);

                    // Если проходимость 0, ищем следующее ребро
                    if (dfs == 0)
                        continue;

                    // Корректируем минимальную проходимость и остаточную сеть
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
