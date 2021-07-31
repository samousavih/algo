using System;

namespace all_pair_shortest_path
{
    class Program
    {
        static void Main(string[] args)
        {
            int INF = 99999, V = 4;
            /* Let us create the following
           weighted graph
              10
        (0)------->(3)
        |         /|\
        5 |         |
        |         | 1
        \|/         |
        (1)------->(2)
             3             */
            int[,] graph = { {0, 5, INF, 10},
                        {INF, 0, 3, INF},
                        {INF, INF, 0, 1},
                        {INF, INF, INF, 0}
                        };

            

            // Print the solution
            var result = allPairShortestPath(V,graph);
            for (var i = 0; i < V; i++)
            {
                for (var j = 0; j < V; j++)
                {
                    Console.WriteLine($"[{i},{j}]={result[i, j]}");
                }

            }
        }

        static int[,] allPairShortestPath(int nodes,int [,] graph)
        {
            var sp = new int[nodes, nodes];
            for(var i = 0; i < nodes; i++)
            {
                for(var j = 0; j< nodes; j++)
                {
                    sp[i, j] = graph[i,j];
                }
                
            }
            
            for(var i =0; i < nodes;i++)
            {
                for(var j = 0; j < nodes; j++)
                {
                    var min = int.MaxValue;
                    for (var k = 0; k < nodes; k++)
                    {
                        min = Math.Min(sp[i, k] + sp[k, j], min);
                    }
                    sp[i, j] = min;
                }
            }
            return sp;
        }
    }
}
