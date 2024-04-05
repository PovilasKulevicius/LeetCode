using System.Text;

namespace _1544._Make_The_String_Great;

abstract class Solution
{
    static void Main()
    {
        var s = GetInitialData();
        var results = MakeGood(s);
        OutputResult(results);
        
    }

    private static string MakeGood(string s)
    {
        for (var i = 1; i < s.Length; i++)
        {
            var previous = s[i - 1];
            var current = s[i];
            
            var wasLastCharacterLowerCase = char.IsLower(previous);
            
            if (char.ToLower(previous) == char.ToLower(current) && char.IsLower(current) != wasLastCharacterLowerCase)
            {
                s = s.Substring(0, i-1) + s.Substring(i + 1, s.Length - i - 1);
                i = 0;
            }
        }
        
        return s;
    }

    private static string GetInitialData()
    {
        return "jeSsEJ";
    }
    
    private static void OutputResult(string result)
    {
        Console.WriteLine(result);
    }
}