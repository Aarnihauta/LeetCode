namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/find-duplicate-file-in-system
public class L609
{
    public IList<IList<string>> FindDuplicate(string[] paths)
    {
        List<IList<string>> result = new List<IList<string>>();
        var fileDataBuilder = new FileDataBuilder(paths);

        var data = fileDataBuilder.GetFilesData()
            .GroupBy(x => x.Content)
            .Select(x => x.Select(x => x.FullPath))
            .Where(x => x.Count() > 1);

        foreach (var item in data)
        {
            result.Add(item.ToList());
        }

        return result;
    }
}

internal class FileData
{
    public FileData(string relativePath, string fileName, string content)
    {
        RelativePath = relativePath;
        FileName = fileName;
        Content = content;
    }

    public string FullPath => GetPath();
    public string RelativePath { get; }
    public string FileName { get; set; }
    public string Content { get; set; }

    private string GetPath()
    {
        return Path.Combine(RelativePath, FileName);
    }

    public override bool Equals(object? obj)
    {
        var o = obj as FileData;
        return o?.Content == Content;
    }
}

internal class FileDataBuilder
{
    private readonly string[] _paths;

    public FileDataBuilder(string[] paths)
    {
        _paths = paths;
    }

    public IEnumerable<FileData> GetFilesData()
    {
        string relativePath = "/";
        foreach (var path in _paths)
        {
            string[] pathContent = path.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string extention = Path.GetExtension(pathContent[0]);
            if (pathContent[0].Contains('/') || string.IsNullOrEmpty(extention))
            {
                relativePath = pathContent[0];
            }
            else
            {
                relativePath = "/";
            }

            for (int i = 1; i < pathContent.Length; i++)
            {
                int openParenthesisIndex = pathContent[i].IndexOf('(');
                string fileName = pathContent[i][0..openParenthesisIndex];
                string content = pathContent[i][(openParenthesisIndex + 1)..(pathContent[i].Length - 1)];

                yield return new FileData(relativePath, fileName, content);
            }
        }
    }
}