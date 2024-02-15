namespace TrueLeetCode.DataStructure.List;
public class CollectionOperators
{
    public IEnumerable<T> Diff<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        foreach (var item in first)
        {
            if (!second.Contains(item))
            {
                yield return item;
            }
        }
    }

    public IEnumerable<T> Concat<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        foreach (var item in first)
        {
            yield return item;
        }

        foreach (var item in second)
        {
            yield return item;
        }
    }

    public IEnumerable<T> Intersection<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        foreach (var item in first)
        {
            if (second.Contains(item))
            {
                yield return item;
            }
        }
    }
}
