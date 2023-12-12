using System.Diagnostics.CodeAnalysis;

namespace TrueLeetCode.Advanced.DataStructure.Graphs;
public class Graph<T>
{
    internal ICollection<Edge<T>> _edges;
    internal ICollection<Vertex<T>> _vertexes;

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

    public void AddEdge(Vertex<T> from, Vertex<T> to, int weight = 1, bool undirect = false)
    {
        if (!_edges.Any(x => x.From == from && x.To == to))
        {
            _edges.Add(new Edge<T>(from, to, weight));

            if (undirect)
            {
                if (!_edges.Any(x => x.From == to && x.To == from))
                {
                    _edges.Add(new Edge<T>(to, from, weight));
                }
            }
        }
    }

    public void AddEdge(Edge<T> edge)
    {
        if (!_vertexes.Contains(edge.From))
        {
            _vertexes.Add(edge.From);
        }
        if (!_vertexes.Contains(edge.To))
        {
            _vertexes.Add(edge.To);
        }
        AddEdge(edge.From, edge.To, edge.Weight);
    }

    public void RemoveVertex(Vertex<T> vertex)
    {
        var edges = _edges.ToList();
        foreach (var item in edges)
        {
            if (item.From == vertex || item.To == vertex)
            {
                _edges.Remove(item);
            }
        }
        _vertexes.Remove(vertex);
    }

    public void RemoveEdge(Edge<T> edge)
    {
        _edges.Remove(edge);
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

    public void BreadthTraversal(Vertex<T> start)
    {
        var visited = new HashSet<Vertex<T>>();
        var queue = new Queue<Vertex<T>>();

        queue.Enqueue(start);

        while (queue.Any())
        {
            var vertex = queue.Dequeue();
            Console.WriteLine(vertex);
            visited.Add(vertex);

            var edges = _edges.Where(x => x.From == vertex);

            foreach (var edge in edges)
            {
                if (!visited.Contains(edge.To))
                {
                    queue.Enqueue(edge.To);
                }
            }
        }
    }

    public void DepthTraversal(Vertex<T> start)
    {
        var visited = new HashSet<Vertex<T>>();
        var stack = new Stack<Vertex<T>>();

        stack.Push(start);

        while (stack.Any())
        {
            var vertex = stack.Pop();
            Console.WriteLine(vertex);
            visited.Add(vertex);

            var edges = _edges.Where(x => x.From == vertex);

            foreach (var edge in edges)
            {
                if (!visited.Contains(edge.To))
                {
                    stack.Push(edge.To);
                }
            }
        }
    }

    internal Vertex<T> GetNextMinimumVertex(Vertex<T> vertex, params Vertex<T>[] ignore)
    {
        return _edges.Where(x => x.From == vertex && !ignore.Contains(x.From)).OrderByDescending(x => x.Weight).FirstOrDefault()?.From;
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

    public override int GetHashCode()
    {
        return Number.GetHashCode() ^ Value.GetHashCode();
    }
}

public class Edge<T> : IEqualityComparer<Edge<T>>
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

    public bool Equals(Edge<T>? x, Edge<T>? y)
    {
        if (ReferenceEquals(x, y))
        {
            return true;
        }

        return x.To == y.To && x.From == y.From && x.Weight == y.Weight;
    }

    public int GetHashCode([DisallowNull] Edge<T> obj)
    {
        return obj.GetHashCode();
    }

    public override string ToString()
    {
        return From.ToString() + "->" + To.ToString();
    }
}