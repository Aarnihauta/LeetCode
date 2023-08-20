namespace TrueLeetCode.Emax;
public class Eratosthenes
{
    public static IList<int> Sieve(int n)
    {
        var numbers = new List<int>();
        for (var i = 2; i < n + 1; i++)
        {
            numbers.Add(i);
        }

        for (var i = 0; i < numbers.Count; i++)
        {
            for (var j = 2; j < n; j++)
            {
                numbers.Remove(numbers[i] * j);
            }
        }

        return numbers;
    }
}