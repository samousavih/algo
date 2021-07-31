using System;
using System.Collections.Generic;

namespace bfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);

            Console.Write("Following is Depth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.DFS(2);
        }
    }

    class Graph
    {

        // No. of vertices    
        private int _V;

        //Adjacency Lists
        LinkedList<int>[] _adj;

        public Graph(int V)
        {
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        // Function to add an edge into the graph
        public void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);

        }
        public void BFS(int s)
        {
            var visited = new Dictionary<int, bool>();
            var q = new Queue<int>();

            q.Enqueue(s);
            while(q.Count > 0)
            {
                var currentNode = q.Dequeue();
                foreach(var v in _adj[currentNode])
                {
                    if(!visited.ContainsKey(v))
                    {
                        q.Enqueue(v);
                    }
                }
                if (!visited.ContainsKey(currentNode))
                {
                    visited.Add(currentNode, true);
                    Console.WriteLine(currentNode);
                }
                
            }
        }

        public void DFS(int s)
        {
            var visited = new Dictionary<int, bool>();
            var q = new Stack<int>();

            q.Push(s);
            while (q.Count > 0)
            {
                var currentNode = q.Pop();
                foreach (var v in _adj[currentNode])
                {
                    if (!visited.ContainsKey(v))
                    {
                        q.Push(v);
                    }
                }
                if (!visited.ContainsKey(currentNode))
                {
                    visited.Add(currentNode, true);
                    Console.WriteLine(currentNode);
                }

            }
        }

    }
}
