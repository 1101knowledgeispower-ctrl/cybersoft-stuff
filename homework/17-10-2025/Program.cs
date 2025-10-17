using System.Text;
using System.Text.RegularExpressions;

Func<string> findLongestWord = () =>
{
    string input = Console.ReadLine() ?? string.Empty;
    string[] words = input.Trim().Split(' ');
    int maxLength = 0;
    string result = "";
    foreach (string word in words)
    {
        if (word.Length > maxLength)
        {
            result = word;
            maxLength = word.Length;
        }
    }
    return result;
};

Console.WriteLine($"Longest word is {findLongestWord()}");


Func<string> removeSpecialCharacter = () =>
{
    string input = Console.ReadLine() ?? String.Empty;
    return Regex.Replace(input, @"[^a-zA-Z0-9\s]", "");
};


Console.WriteLine($"Word after removing special character: {removeSpecialCharacter()}");



Func<string> ReturnLongestStringWithNumber = () =>
{
    string input = Console.ReadLine() ?? string.Empty;
    input = input.Trim();

    int currentLength = 0;
    string result = string.Empty;
    StringBuilder sb = new StringBuilder();
    bool containsNumber = false;

    foreach (char c in input)
    {
        if (c != ' ')
        {
            sb.Append(c);
            if (char.IsNumber(c))
                containsNumber = true;
        }
        else
        {
            if (sb.Length > 0)
            {
                if (containsNumber && sb.Length > currentLength)
                {
                    result = sb.ToString();
                    currentLength = sb.Length;
                }
                sb.Clear();
                containsNumber = false;
            }
        }
    }

    if (sb.Length > 0)
    {
        if (containsNumber && sb.Length > currentLength)
        {
            result = sb.ToString();
        }
    }
    return result;
};

Console.WriteLine($"Output: {ReturnLongestStringWithNumber()}");
