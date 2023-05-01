using System.Text;

//https://leetcode.com/problems/decode-the-message/
public class L2325
{
    public string DecodeMessage(string key, string message)
    {
        var result = new StringBuilder();
        var alphabet = new Dictionary<char, char>();
       
        var currentLetter = 'a';
        foreach(var c in key)
        {
            if(char.IsLetter(c) && !alphabet.ContainsKey(c))
            {
                alphabet[c] = currentLetter;
                currentLetter = (char)(currentLetter + 1);
            }
            
        }

        foreach(var c in message)
        {
            if(char.IsLetter(c))
            {
                result.Append(alphabet[c]);
            }
            else
            {
                result.Append(' ');
            }
        }

        return result.ToString();
    }
}