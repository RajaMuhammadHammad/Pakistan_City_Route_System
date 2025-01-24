using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace G_MAP
{
    public partial class Form3 : Form
    {
        public const int INF = int.MaxValue;
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

        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        public int startNode;
        public int endNode;
        public List<string> StringPath;

        public void GeneratePortPath(List<int> path)
        {
            StringPath = new List<string>();

            // Add all cities to StringPath
            StringPath.Add("Karachi");
            StringPath.Add("Lahore");
            StringPath.Add("Peshawar");
            StringPath.Add("Faisalabad");
            StringPath.Add("Hyderabad");
            StringPath.Add("Islamabad");
            StringPath.Add("Rawalpindi");
            StringPath.Add("Quetta");
            StringPath.Add("Larkana");
            StringPath.Add("Gilgit-Baltistan");
            StringPath.Add("Sahiwal");
            StringPath.Add("Bahawalpur");
            StringPath.Add("Gujrat");
            StringPath.Add("Hub-Balochistan");
            StringPath.Add("Mardan");
            StringPath.Add("Gawadar");

            // Use a HashSet to keep track of visited nodes
            HashSet<int> visitedNodes = new HashSet<int>();

            foreach (int i in path)
            {
                // Check if the node is not already visited
                if (!visitedNodes.Contains(i))
                {
                    // Mark the node as visited
                    visitedNodes.Add(i);
                }
            }
        }


        private void btnMapLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            if (Start.SelectedItem == null || End.SelectedItem == null)
            {
                MessageBox.Show("Please fill all entries");
                return;
            }

            if (Start.SelectedIndex == 0 || End.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid start and end nodes");
                return;
            }

            startNode = Start.SelectedIndex;
            endNode = End.SelectedIndex;

            // Use Kruskal's algorithm to find the minimum spanning tree
            List<Edge> minimumSpanningTree = Algoritm.Kruskal(graph);

            // Extract the path from the minimumSpanningTree
            List<int> path = minimumSpanningTree.Select(edge => edge.Start).ToList();

            // Add the endNode to the path
            path.Add(endNode);

            // Call GeneratePortPath to populate StringPath
            GeneratePortPath(path);

            // Display the route in RouteTxt
            RouteTxt.Text = string.Join(" -> ", StringPath);

            // Calculate and display the distance in DistanceTxt
            int distance = minimumSpanningTree.Sum(edge => edge.Weight);
            DistanceTxt.Text = distance.ToString();

            // Display the edges of the minimum spanning tree (optional)
            string edgesText = string.Join(Environment.NewLine, minimumSpanningTree.Select(edge => $"{edge.Start} - {edge.End}"));
            MessageBox.Show($"Minimum Spanning Tree Edges:\n{edgesText}\n\nTotal Cost: {distance}");
            // Inside GenBtn_Click method after generating the path and before showing the map form

            Algoritm.path = path; // Pass the calculated route to Form4


            btnMapLoad.Enabled = true;
        }



        private void RouteTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void End_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    








        public static String Dijkstra(int[,] graph, int source, int destination)
        {
            int numLocat = graph.GetLength(0);

            int[] distance = new int[numLocat];
            bool[] visited = new bool[numLocat];
            int[] parent = new int[numLocat];

            for (int i = 0; i < numLocat; i++)
            {
                distance[i] = INF;    // Set initial distances to infinity
                visited[i] = false;   // Mark all ports as not visited
            }

            distance[source] = 0;   // Set the distance from the source port to itself as 0

            for (int count = 0; count < numLocat - 1; count++)
            {
                int u = MinDistance(distance, visited);
                visited[u] = true;  // Mark the selected slot as visited

                for (int v = 0; v < numLocat; v++)
                {
                    if (!visited[v] && graph[u, v] != INF && distance[u] != INF &&
                        distance[u] + graph[u, v] < distance[v])
                    {
                        // Check if the number of ships at port v is less than or equal to 7
                        if (GetNoodroute(v) <= 7)
                        {
                            distance[v] = distance[u] + graph[u, v];
                            parent[v] = u;
                        }
                    }
                }
            }

            PrintPath(parent, destination, source);
            return $"{ distance[destination]}";
        }
        private static int MinDistance(int[] distance, bool[] visited)
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

        private static String PrintPath(int[] parent, int j, int source)
        {
            if (j == source)
            {
                return $"{source} "; // Print the source port

            }

            PrintPath(parent, parent[j], source);
            return $"{j} "; // Print the current port
        }

        private static int GetNoodroute(int port)
        {
            // Replace this with your own logic to get the number of ships at the given port
            // For now, returning a default value
            return new Random().Next(10);
        }

        

        public void GeneratePath(List<int> path)
        {
            StringPath = new List<string>();
            foreach (int i in path)
            {
                if (i == 0)
                {
                    StringPath.Add("Karachi");
                }
                else if (i == 1)
                {
                    StringPath.Add("Lahore");
                }
                else if (i == 2)
                {
                    StringPath.Add("Peshawar");
                }
                else if (i == 3)
                {
                    StringPath.Add("Faisalabad");
                }
                else if (i == 4)
                {
                    StringPath.Add("Hyderabad");
                }
                else if (i == 5)
                {
                    StringPath.Add("Islamabad");
                }
                else if (i == 6)
                {
                    StringPath.Add("Rawalpindi");
                }
                else if (i == 7)
                {
                    StringPath.Add("Quetta");
                }
                else if (i == 8)
                {
                    StringPath.Add("Larkana");
                }
                else if (i == 9)
                {
                    StringPath.Add("Gilgit Baltistan");
                }
                else if (i == 10)
                {
                    StringPath.Add("Sahiwal");
                }
                else if (i == 11)
                {
                    StringPath.Add("Bahawalpur");
                }
                else if (i == 12)
                {
                    StringPath.Add("Gujrat");
                }
                else if (i == 13)
                {
                    StringPath.Add("Hub");
                }
                else if (i == 14)
                {
                    StringPath.Add("Mardan");
                }
                else
                {
                    StringPath.Add("Gwadar");
                }
            }
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Start.SelectedItem == null || End.SelectedItem == null)
            {
                MessageBox.Show("Please fill all entries");
            }
            else if (Start.SelectedIndex == 0)
            {
                startNode = 0;
            }
            else if (Start.SelectedIndex == 1)
            {
                startNode = 1;
            }
            else if (Start.SelectedIndex == 2)
            {
                startNode = 2;
            }
            else if (Start.SelectedIndex == 3)
            {
                startNode = 3;
            }
            else if (Start.SelectedIndex == 4)
            {
                startNode = 4;
            }
            else if (Start.SelectedIndex == 5)
            {
                startNode = 5;
            }
            else if (Start.SelectedIndex == 6)
            {
                startNode = 6;
            }
            else if (Start.SelectedIndex == 7)
            {
                startNode = 7;
            }
            else if (Start.SelectedIndex == 8)
            {
                startNode = 8;
            }
            else if (Start.SelectedIndex == 9)
            {
                startNode = 9;
            }
            else if (Start.SelectedIndex == 10)
            {
                startNode = 10;
            }
            else if (Start.SelectedIndex == 11)
            {
                startNode = 11;
            }
            else if (Start.SelectedIndex == 12)
            {
                startNode = 12;
            }
            else if (Start.SelectedIndex == 13)
            {
                startNode = 13;
            }
            else if (Start.SelectedIndex == 14)
            {
                startNode = 14;
            }
            else if (Start.SelectedIndex == 15)
            {
                startNode = 15;
            }
            else
            {

            }

            if (End.SelectedIndex == 0)
            {
                endNode = 0;
            }
            else if (End.SelectedIndex == 1)
            {
                endNode = 1;
            }
            else if (End.SelectedIndex == 2)
            {
                endNode = 2;
            }
            else if (End.SelectedIndex == 3)
            {
                endNode = 3;
            }
            else if (End.SelectedIndex == 4)
            {
                endNode = 4;
            }
            else if (End.SelectedIndex == 5)
            {
                endNode = 5;
            }
            else if (End.SelectedIndex == 6)
            {
                endNode = 6;
            }
            else if (End.SelectedIndex == 7)
            {
                endNode = 7;
            }
            else if (End.SelectedIndex == 8)
            {
                endNode = 8;
            }
            else if (End.SelectedIndex == 9)
            {
                endNode = 9;
            }
            else if (End.SelectedIndex == 10)
            {
                endNode = 10;
            }
            else if (End.SelectedIndex == 11)
            {
                endNode = 11;
            }
            else if (End.SelectedIndex == 12)
            {
                endNode = 12;
            }
            else if (End.SelectedIndex == 13)
            {
                endNode = 13;
            }
            else if (End.SelectedIndex == 14)
            {
                endNode = 14;
            }
            else if (End.SelectedIndex == 15)
            {
                endNode = 15;
            }
            else
            {

            }
         //   string shortestDistance = Dijkstra(graph, sourceNode, destinationNode);


            Algoritm2 a = new Algoritm2();
            DistanceTxt.Text = Algoritm2.Dijkstra(graph, startNode, endNode);
            GeneratePath(Algoritm2.path);
            RouteTxt.Text = string.Join(" --> ", StringPath);
            btnMapLoad.Enabled = true;
     


        }
        private void btnMapLoad2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}



