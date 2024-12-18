// See https://aka.ms/new-console-template for more information
using problem_set_3.Logic;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
Stopwatch sw = new();
sw.Start();

int[] set = [10, 9, 2, 8, 3, 7, 101, 18];

var result = IntegerSequenceLogic.LongestIncreasingSequenceCount(set);
sw.Stop();
Console.WriteLine($"result: {result}, {sw.ElapsedMilliseconds}ms");
