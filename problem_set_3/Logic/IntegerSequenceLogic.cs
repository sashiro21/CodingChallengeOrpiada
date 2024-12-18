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
        List<List<int>> startingSequence = new();
        bool start = true;

        foreach (int number in numbers)
        {
            //Dont compare yet
            if (start)
            {
                start = false;
                List<int> sequenceStart = [number];
                startingSequence.Add(sequenceStart);
                continue;
            }
            List<List<int>> generatedSequences = new();
            foreach (var item in startingSequence)
            {
                var lastItem = item.LastOrDefault();
                if (number > lastItem)
                {
                    List<int> generatedSeq = new(item) { number };
                    generatedSequences.Add(generatedSeq);
                }
            }
            startingSequence.AddRange(generatedSequences);
            List<int> sequence = [number];
            startingSequence.Add(sequence);
        }
        foreach (var sequence in startingSequence)
        {
            if (sequence.Count > result)
                result = sequence.Count;
        }
        return result;
    }
}