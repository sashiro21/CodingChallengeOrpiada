// See https://aka.ms/new-console-template for more information


using problem_set_1.Logic;
using System.Text;

Console.WriteLine("Hello, World!");

string[] words = ["bat", "tab", "cat"];

if(words.Length <= 1)
{
    Console.WriteLine($"No palindrome pairs found...");
    return;
}

var palindromeIndex = PalindromeChecker.ProcessListForPalindromes(words.ToList());

if (palindromeIndex.Any())
{
    StringBuilder sb = new StringBuilder();
    sb.Append('[');
    for (int i = 0; i < palindromeIndex.Count; i++)
    {
        var (idx1, idx2) = palindromeIndex[i];
        sb.Append($"[{idx1} {idx2}]");

        if (i != palindromeIndex.Count - 1)
        {
            sb.Append(' ');
        }
    }
    sb.Append(']');
    Console.WriteLine($"Result: {sb.ToString()}");
}
else
{
    Console.WriteLine($"No palindrome pairs found...");
}

