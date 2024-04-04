using System.Diagnostics;

namespace _1614._Maximum_Nesting_Depth_of_the_Parentheses;

abstract class Solution
{
    static void Main()
    {
        var s = GetInitialData();
        var results = MaxDepth(s);
        OutputResult(results);
        
    }

    private static int MaxDepth(string s)
    {
        if (!s.Contains('('))
            return 0;

        var depth = 0;
        var maxDepth = 0;
        
        foreach (var character in s)
        {
            switch (character)
            {
                case '(':
                    depth++;
                    break;
                case ')':
                    depth--;
                    break;
            }

            if (depth > maxDepth)
                maxDepth = depth;
        }

        return maxDepth;
    }

    private static string GetInitialData()
    {
        return "(1+(2*3)+((8)/4))+1";
    }
    
    private static void OutputResult(int result)
    {
        Console.WriteLine(result);
    }
}