namespace TrueLeetCode.Ozon256;
internal class C_TreeRoot
{
    public int GetTreeRoot(int[] arr)
    {
        if (arr[^1] != 0)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[^1] = 0;
        }

        List<List<int>> list = new List<List<int>>();

        for (int i = 1; i < arr.Length; i++)
        {
            int val = arr[i - 1];
            int nodesCount = arr[i];

            var data = new List<int>
            {
                val
            };
            list.Add(data);
            if (nodesCount > 0)
            {
                int j = i + 1;
                i += nodesCount + 1;
                while (nodesCount > 0)
                {
                    data.Add(arr[j]);
                    j++;
                    nodesCount--;
                }
            }
            else
            {
                i++;
            }
        }

        var dictionary = new Dictionary<int, int>();
        foreach (var items in list)
        {
            foreach (var item in items)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 1);
                }
                else
                {
                    dictionary[item]++;
                }
            }
        }

        return dictionary.FirstOrDefault(x => x.Value == 1).Key;
    }
}
