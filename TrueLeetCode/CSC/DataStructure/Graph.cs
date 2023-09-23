namespace TrueLeetCode.CSC.DataStructure;
public class Graph<T>
{
    private ICollection<Edge<T>> _edges;
    private ICollection<Vertex<T>> _vertexes;

    public int VertexCount => _vertexes.Count;
    public int EdgeCount => _edges.Count;

    public Graph()
    {
        _edges = new List<Edge<T>>();
        _vertexes = new List<Vertex<T>>();
    }
    public void AddVertex(Vertex<T> vertex)
    {
        _vertexes.Add(vertex);
    }
    public void AddEdge(Vertex<T> from, Vertex<T> to)
    {
        _edges.Add(new Edge<T>(from, to));
    }

    public int[,] GetMatrix()
    {
        var matrix = new int[_vertexes.Count, _vertexes.Count];

        foreach (var edge in _edges)
        {
            var row = edge.From.Number - 1;
            var col = edge.To.Number - 1;

            matrix[row, col] = edge.Weight;
        }

        return matrix;
    }

    public List<Vertex<T>> GetVertexList(Vertex<T> vertex)
    {
        var result = new List<Vertex<T>>();

        foreach (var edge in _edges)
        {
            if (edge.To == vertex)
            {
                result.Add(edge.To);
            }
        }

        return result;
    }
}

public class Vertex<T>
{
    public int Number { get; }
    public T Value { get; }
    internal bool Visited { get; set; }

    public Vertex(T value, int number)
    {
        Value = value;
        Number = number;
    }
}

public class Edge<T>
{
    public Edge(Vertex<T> from, Vertex<T> to, int weight = 1)
    {
        From = from;
        To = to;
        Weight = weight;
    }

    public Vertex<T> From { get; }
    public Vertex<T> To { get; }
    public int Weight { get; }
}