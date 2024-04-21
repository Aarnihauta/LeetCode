namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/implement-trie-prefix-tree/

public class Trie
{
    private TrieNode _root = new TrieNode();
    public Trie()
    {

    }

    public void Insert(string word)
    {
        _root.Add(word, word);
    }

    public bool Search(string word)
    {
        var set = new HashSet<string>();
        _root.GetByPrefix(word, set);
        return set.Contains(word);
    }

    public bool StartsWith(string prefix)
    {
        var set = new HashSet<string>();
        _root.GetByPrefix(prefix, set);
        return set.Count > 0;
    }
}

public class TrieNode
{
    private string _word;
    private Dictionary<char, TrieNode> _children = new Dictionary<char, TrieNode>();

    public void Add(string path, string word)
    {
        if(path != null)
        {
            Add(path, 0, word);
        }
    }

    public void GetByPrefix(string prefix, HashSet<string> result)
    {
        GetByPrefix(prefix, 0, result);
    }

    private void GetByPrefix(string prefix, int index, HashSet<string> result)
    {
        if(_word != null)
        {
            result.Add(_word);
        }

        if(index >= prefix.Length)
        {
            foreach(var node in _children.Values)
            {
                node.GetByPrefix(prefix, index, result);
            }
        }
        else
        {
            var c = prefix[index];
            if(_children.ContainsKey(c))
            {
                _children[c].GetByPrefix(prefix, index + 1, result);
            }
        }
    }

    private void Add(string path, int index, string word)
    {
        if (index == path.Length)
        {
            _word = word;
            return;
        }

        var c = path[index];
        if (!_children.ContainsKey(c))
        {
            _children.Add(c, new TrieNode());
        }
        _children[c].Add(path, index + 1, word);
    }
}
