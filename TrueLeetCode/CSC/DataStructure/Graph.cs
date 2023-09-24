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
        if (!_edges.Any(x => x.From == from && x.To == to))
        {
            _edges.Add(new Edge<T>(from, to));
        }
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

    public void DepthTraversal(Vertex<T> start)
    {
        var startEdge = _edges.FirstOrDefault(x => x.From == start);
        if (startEdge == null)
        {
            return;
        }

        var visited = new HashSet<Vertex<T>>();
        var queue = new Queue<Edge<T>>();
        queue.Enqueue(startEdge);
        while (queue.Any())
        {
            var item = queue.Dequeue();
            Console.WriteLine(item);
            visited.Add(item.From);

            var edges = GetEdges(item.From);

            foreach (var edge in edges)
            {
                if (!visited.Contains(edge.From))
                {
                    queue.Enqueue(edge);
                }
            }
        }
    }

    private List<Vertex<T>> GetAdjacentVertexList(Vertex<T> vertex)
    {

    }
}

public class Vertex<T>
{
    public Vertex(T value, int number)
    {
        Value = value;
        Number = number;
    }

    public int Number { get; }
    public T Value { get; }

    public override string ToString()
    {
        return $"{Number}:{Value}";
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

    public override string ToString()
    {
        return From.ToString() + "->" + To.ToString();
    }
}


public class Int32Graph : Graph<int> { }