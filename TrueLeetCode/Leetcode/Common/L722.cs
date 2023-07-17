namespace TrueLeetCode.Leetcode.Common;

//https://leetcode.com/problems/remove-comments/
public class L722
{
    public IList<string> RemoveComments(string[] source)
    {
        List<string> result = new List<string>();
        bool waitClosingComment = false;
        foreach (string line in source)
        {
            string content = string.Empty;

            if (waitClosingComment)
            {
                int start = line.IndexOf("*/");
                if (start == -1)
                {
                    continue;
                }
                if (start + 2 < line.Length)
                {
                    content = line[(start + 2)..];
                }
                waitClosingComment = false;
            }
            else
            {
                int start = line.IndexOf("/*");
                if (start != -1)
                {
                    int end = line.IndexOf(@"*/");
                    if (end != -1)
                    {
                        if (end + 2 == line.Length)
                        {
                            end += 2;
                        }
                        content = line.Remove(start, end);
                        waitClosingComment = false;
                    }
                    else if (start > 0)
                    {
                        content = line[0..start];
                        waitClosingComment = true;
                    }
                    else
                    {
                        waitClosingComment = true;
                    }
                }
                else if ((start = line.IndexOf(@"//")) != -1)
                {
                    if (start > 0)
                    {
                        content = line[0..start];
                    }
                }
                else
                {
                    content = line;
                }
            }

            if (!string.IsNullOrEmpty(content))
            {
                result.Add(content);
            }
        }

        return result;
    }
}
