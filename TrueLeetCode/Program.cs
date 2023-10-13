
using TrueLeetCode.CSC.DataStructure;

var g = new Graph<int>();

var v1 = new Vertex<int>(1, 1);
var v2 = new Vertex<int>(2, 2);
var v3 = new Vertex<int>(3, 3);
var v4 = new Vertex<int>(4, 4);
var v5 = new Vertex<int>(5, 5);
var v6 = new Vertex<int>(6, 6);
var v7 = new Vertex<int>(7, 7);

g.AddVertex(v1);
g.AddVertex(v2);
g.AddVertex(v3);
g.AddVertex(v4);
g.AddVertex(v5);
g.AddVertex(v6);
g.AddVertex(v7);

g.AddEdge(v1, v2, 28);
g.AddEdge(v1, v6, 10);
g.AddEdge(v2, v3, 16);
g.AddEdge(v2, v7, 14);
g.AddEdge(v3, v4, 12);
g.AddEdge(v4, v7, 18);
g.AddEdge(v4, v5, 22);
g.AddEdge(v5, v7, 24);
g.AddEdge(v5, v6, 25);

g.GetMST();