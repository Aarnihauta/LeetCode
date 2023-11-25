namespace TrueLeetCode.CSC.Collection;
public class CollectionOperators
{
    //A\B := {x ∈ M | (x ∈ A)∧(x ∉ B)}
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

    //A∪B = {x ∈ M | (x ∈ A)∨(x ∈ B)}
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

    //A∩B := {x ∈ M | (x ∈ A)∧(x ∈ B)}
    public IEnumerable<T> Intersection<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        foreach (var item in first)
        {
            if(second.Contains(item))
            {
                yield return item;
            }
        }
    }
}
