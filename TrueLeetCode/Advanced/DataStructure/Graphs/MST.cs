namespace TrueLeetCode.Advanced.DataStructure.Graphs;
public class MST
{
    public List<Graph<T>> GetShortestPath<T>(Graph<T> source, Vertex<T> from, Vertex<T> to)
    {
        return null;
    }


    public Graph<T> Kruskal<T>(Graph<T> source)
    {
        Graph<T> result = new Graph<T>();

        var edges = source._edges.OrderBy(x => x.Weight);
        var vertexes = source._vertexes.ToList();
        var trees = new Dictionary<Vertex<T>, HashSet<Vertex<T>>>();

        foreach (var vertex in vertexes)
        {
            trees.Add(vertex, new HashSet<Vertex<T>> { vertex });
        }

        foreach (var edge in edges)
        {
            var from = trees[edge.From];
            var to = trees[edge.To];

            if (from != to)
            {
                result.AddEdge(edge);

                foreach (var v in to)
                {
                    from.Add(v);
                    trees[v] = from;
                }
            }
        }

        return result;
    }

    public Graph<T> Prims<T>(Graph<T> source)
    {
        return null;
    }
}
