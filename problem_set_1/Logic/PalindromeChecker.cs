using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_set_1.Logic;

internal static class PalindromeChecker
{
    internal static bool CheckPalindrome(string word)
    {
        bool result = false;
        if (string.IsNullOrEmpty(word))
        {
            return result;
        }
        var wordForProcess = word.Trim();
        var left = 0;
        var right = word.Length - 1;

        var loopResult = true;
        while (left < right)
        {
            var leftChar = word[left];
            var rightChar = word[right];

            if (!char.IsLetter(leftChar) || !char.IsLetter(rightChar))
            {
                result = false;
                return result;
            }

            if (leftChar != rightChar)
            {
                loopResult = false;
            }
            left++;
            right--;
        }
        result = loopResult;
        return result;
    }

    internal static List<(int idx1, int idx2)> ProcessListForPalindromes(List<string> words)
    {
        List<(int idx1, int idx2)> result = new();
        if (!words.Any())
        {
            return result;

        }
        var count = words.Count;
        string[] wordsAsArray = words.ToArray();

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                if (i == j) continue;
                StringBuilder sb = new StringBuilder();
                sb.Append(wordsAsArray[i] + wordsAsArray[j]);
                var isPalindrome = CheckPalindrome(sb.ToString());

                if (isPalindrome)
                {
                    result.Add((i, j));
                }
            }
        }
        return result;
    }
}