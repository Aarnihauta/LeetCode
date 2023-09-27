//using TrueLeetCode.CSC.DataStructure;

//var g = new Int32Graph();

//var v0 = new Vertex<int>(0, 0);
//var v1 = new Vertex<int>(1, 1);
//var v2 = new Vertex<int>(2, 2);
//var v3 = new Vertex<int>(3, 3);
//var v4 = new Vertex<int>(4, 4);
//var v5 = new Vertex<int>(5, 5);

//g.AddVertex(v0);
//g.AddVertex(v1);
//g.AddVertex(v2);
//g.AddVertex(v3);
//g.AddVertex(v4);
//g.AddVertex(v5);

//g.AddEdge(v4, v1);
//g.AddEdge(v4, v2);
//g.AddEdge(v4, v3);
//g.AddEdge(v4, v5);

//g.BreadthTraversal(v4);
//Console.WriteLine();
//g.DepthTraversal(v4);


using TrueLeetCode.Leetcode.Graphs;

var l = new L997();

l.FindJudge(3, new int[][]
{
    new int[] {1,2},
    new int[] {2,3},
});