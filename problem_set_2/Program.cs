// See https://aka.ms/new-console-template for more information
using problem_set_2.Logic;

Console.WriteLine("Hello, World!");

string testData = "{{{}}}()[]()";

bool result = ValidParenthesisChecker.IsParenthesisValidOrder(testData);
Console.WriteLine($"input data: {testData}");
Console.WriteLine($"result: {result}");