using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_set_3.Logic;

internal static class IntegerSequenceLogic
{
    internal static int LongestIncreasingSequenceCount(int[] numbers)
    {
        int result = 0;
        List<List<int>> data = new();

        foreach (int number in numbers)
        {
            if(data.Any())
            {
                foreach (var item in data)
                {
                    
                }
            }
            else
            {
            }
        }

        return result;
    }

    internal static int LongestIncreasingSequenceCountV2(int[] numbers)
    {
        int result = 0;
        int[][] data = new int[numbers.Length][];

        for (int i = 0; i < numbers.Length; i++)
        {
            data[i][0] = numbers[i];



        }

        return result;
    }
}