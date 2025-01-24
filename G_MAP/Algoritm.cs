using System;
using System.Collections.Generic;
using System.Linq;

namespace G_MAP
{
    public class Algoritm
    {
        public static List<int> path { get; set; } = new List<int>(); // Initialize path list

        public static List<Edge> Kruskal(int[,] graph)
        {
            int numPorts = graph.GetLength(0);

            List<Edge> edges = new List<Edge>();

            // Add all edges to the list
            for (int i = 0; i < numPorts; i++)
            {
                for (int j = i + 1; j < numPorts; j++)
                {
                    if (graph[i, j] != Form3.INF)
                    {
                        edges.Add(new Edge(i, j, graph[i, j]));
                    }
                }
            }

            // Sort edges by weight in ascending order
            edges = edges.OrderBy(edge => edge.Weight).ToList();

            List<Edge> minimumSpanningTree = new List<Edge>();
            int[] parent = new int[numPorts];

            // Initialize each node's parent to itself
            for (int i = 0; i < numPorts; i++)
            {
                parent[i] = i;
            }

            foreach (Edge edge in edges)
            {
                int rootStart = FindRoot(parent, edge.Start);
                int rootEnd = FindRoot(parent, edge.End);

                // Check if adding this edge will form a cycle
                if (rootStart != rootEnd)
                {
                    minimumSpanningTree.Add(edge);
                    Union(parent, rootStart, rootEnd);
                }
            }

            return minimumSpanningTree;
        }

        private static int FindRoot(int[] parent, int node)
        {
            if (parent[node] != node)
            {
                parent[node] = FindRoot(parent, parent[node]);
            }

            return parent[node];
        }

        private static void Union(int[] parent, int root1, int root2)
        {
            parent[root2] = root1;
        }
    }

    public class Edge
    {
        public int Start { get; }
        public int End { get; }
        public int Weight { get; }

        public Edge(int start, int end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }
    }

    /// <summary>
    /// ///////////////////////////////////////*********************DIJISKTRA ALGORITHM********************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    /// </summary>

    class Algoritm2
    {
        public const int INF = int.MaxValue;
        public static int dis;
        public static int[] parent;
        public static List<int> path;

        public static String Dijkstra(int[,] graph, int source, int destination)
        {
            int numLocat = graph.GetLength(0);
            path = new List<int>();
            int[] distance = new int[numLocat];
            bool[] visited = new bool[numLocat];
            parent = new int[numLocat];

            for (int i = 0; i < numLocat; i++)
            {
                distance[i] = INF;    // Set initial distances to infinity
                visited[i] = false;   // Mark all slot as not visited
            }

            distance[source] = 0;   

            for (int count = 0; count < numLocat - 1; count++)
            {
                int u = MinDistance(distance, visited);
                visited[u] = true;  // Mark the selected slot as visited

                for (int v = 0; v < numLocat; v++)
                {
                    if (!visited[v] && graph[u, v] != INF && distance[u] != INF &&
                        distance[u] + graph[u, v] < distance[v])
                    {
                        
                        if (GetNoOfroute(v) <= 7)
                        {
                            distance[v] = distance[u] + graph[u, v];
                            parent[v] = u;
                        }
                    }
                }
            }

            PrintPath(parent, destination, source);
            dis = distance[destination];
            return $"{distance[destination]} km";
        }

        public static int MinDistance(int[] distance, bool[] visited)
        {
            int min = INF, minIndex = -1;

            for (int v = 0; v < distance.Length; v++)
            {
                if (!visited[v] && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        //private static void PrintPath(int[] parent, int j, int source)
        //{
        //    if (j == source)
        //    {
        //        path.Add(source);
        //        return;
        //    }

        //    PrintPath(parent, parent[j], source);
        //    path.Add(j); 
        //}

        private static void PrintPath(int[] parent, int j, int source)
        {
            path.Clear(); // Clear the path list before populating it again
            path.Add(j); // Add the current slot

            while (j != source)
            {
                j = parent[j];
                path.Add(j); 
            }

            path.Reverse(); // Reverse the path to get the correct order
        }

            public static int GetNoOfroute(int port)
        {
            return new Random().Next(10);
        }


        public int[,] graph = {
          { 0, 98, INF, INF, INF, 144, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF},
          { 98, 0, 120, INF, INF, INF, 100, INF, INF, INF, INF, INF, INF, INF, INF, INF},
          { INF, 120, 0, 75, INF, INF, INF, 45, INF, INF, INF, INF, INF, INF, INF, INF},
          { INF, INF, 75, 0, 110, INF, INF, INF, 95, INF, INF, INF, INF, INF, INF, INF},
          { INF, INF, INF, 110, 0, INF, INF, INF, INF, 165, INF, INF, INF, INF, INF, INF},
          { 144, INF, INF, INF, INF, 0, 220, INF, INF, INF, 180, INF, INF, INF, INF, INF},
          { INF, 100, INF, INF, INF, 220, 0, 170, INF, INF, INF, 100, INF, INF, INF, INF},
          { INF, INF, 45, INF, INF, INF, 170, 0, 15, INF, INF, INF, 60, INF, INF, INF},
          { INF, INF, INF, 95, INF, INF, INF, 15, 0, 115, INF, INF, INF, 35, INF, INF},
          { INF, INF, INF, INF, 165, INF, INF, INF, 115, 0, INF, INF, INF, INF, 100, INF},
          { INF, INF, INF, INF, INF, 180, INF, INF, INF, INF, 0, 125, INF, INF, INF, 72},
          { INF, INF, INF, INF, INF, INF, 100, INF, INF, INF, 125, 0, 80, INF, INF, 137},
          { INF, INF, INF, INF, INF, INF, INF, 60, INF, INF, INF, 80, 0, 75, INF, 152},
          { INF, INF, INF, INF, INF, INF, INF, INF, 35, INF, INF, INF, 75, 0, 35, 94},
          { INF, INF, INF, INF, INF, INF, INF, INF, INF, 100, INF, INF, INF,35, 0, 83},
          { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, 72, 137, 152, 94, 83, 0}};

    }


    }

