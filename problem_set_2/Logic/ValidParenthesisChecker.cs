using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_set_2.Logic;

internal static class ValidParenthesisChecker
{
    private static readonly Dictionary<char, char> ParenthesesPairsByClosingChar = new Dictionary<char, char>()
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };

    private static readonly char[] AllowedValues = ['(', ')', '{', '}', '[', ']'];

    internal static bool IsParenthesisValidOrder(string parenthesis)
    {
        bool result = false;
        bool loopResult = true;
        StringBuilder remainingOpeningParentheses = new StringBuilder();
        foreach (char c in parenthesis)
        {
            //Escape if string contains not allowed characters
            if (Array.IndexOf(AllowedValues, c) < 0)
            {
                loopResult = false;
                break;
            }

            //Check if current character is closing character
            if (ParenthesesPairsByClosingChar.ContainsKey(c))
            {
                //Return false for no opening parenthesis
                if (remainingOpeningParentheses.Length <= 0)
                {
                    loopResult = false;
                    break;
                }

                //Get proper opening parenthesis
                char correctOpenParenthesis = ParenthesesPairsByClosingChar[c];
                //Get open parenthesis currently
                char currentOpenParenthesis = remainingOpeningParentheses[remainingOpeningParentheses.Length - 1];
                if (correctOpenParenthesis.Equals(currentOpenParenthesis))
                {
                    remainingOpeningParentheses.Remove(remainingOpeningParentheses.Length - 1, 1);
                }
                else
                {
                    loopResult = false;
                }
            }
            else
            {
                //Opening character, just append to `remainingOpeningParentheses` variable
                remainingOpeningParentheses.Append(c);
            }
        }
        //Check for unfinished processing
        if (remainingOpeningParentheses.Length > 0)
        {
            loopResult = false;
        }
        result = loopResult;
        return result;
    }
}