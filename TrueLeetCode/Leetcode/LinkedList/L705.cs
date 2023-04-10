namespace TrueLeetCode.Leetcode.LinkedList;

//https://leetcode.com/problems/design-hashset
public class MyHashSet
{
    private int[] _buckets;
    private int _freeCount;
    private Entry[] _entries;
    public MyHashSet()
    {
        _freeCount = 1;
        _buckets = new int[1];
        _entries = new Entry[1];
    }

    public void Add(int key)
    {
        var entries = _entries;
        int hashCode = key.GetHashCode();
        ref var bucket = ref GetBucketRef(hashCode);
        int i = bucket - 1;

        while (i >= 0)
        {
            ref var entry = ref entries[i];

            if (entry.HashCode == hashCode)
            {
                return;
            }
            i = entry.Next;
        }

        int index;

        if (_freeCount > 0)
        {
            _freeCount--;
            index = _buckets.Length - 1 - _freeCount;
        }
        else
        {
            int count = _buckets.Length;

            if (count == entries.Length)
            {
                Resize(_buckets.Length + 4);
                bucket = ref GetBucketRef(hashCode);
                entries = _entries;
            }
            index = count;
        }

        ref Entry data = ref entries[index];
        data.HashCode = hashCode;
        data.Next = bucket - 1;
        data.Value = key;
        bucket = index + 1;
    }

    public void Remove(int key)
    {
        var entries = _entries;
        int hashCode = key.GetHashCode();
        ref var bucket = ref GetBucketRef(hashCode);
        int i = bucket - 1;
        int last = -1;

        while (i >= 0)
        {
            ref Entry entry = ref entries[i];

            if (entry.HashCode == hashCode)
            {
                if (last < 0)
                {
                    bucket = entry.Next + 1;
                }
                else
                {
                    entries[last].Next = entry.Next;
                }
                _freeCount++;
                return;
            }

            last = i;
            i = entry.Next;
        }
    }

    public bool Contains(int key)
    {
        return true;
    }

    private void Resize(int newSize)
    {
        var newEntries = new Entry[newSize];
        Array.Copy(_entries, newEntries, _entries.Length);
        _entries = newEntries;

        var newBuckets = new int[newSize];
        Array.Copy(_buckets, newBuckets, _buckets.Length);
        _buckets = newBuckets;
    }

    private ref int GetBucketRef(int hashCode)
    {
        return ref _buckets[(uint)hashCode % ((uint)_buckets.Length + 1)];
    }

    private struct Entry
    {
        public int HashCode;
        public int Next;
        public int Value { get; set; }
    }
}