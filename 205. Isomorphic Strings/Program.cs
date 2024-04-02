namespace _205._Isomorphic_Strings;

abstract class Solution
{
    static void Main()
    {
        var (s, t) = GetInitialData();
        var results = IsIsomorphic(s, t);
        OutputResult(results);
        
    }

    private static void OutputResult(bool result)
    {
        Console.WriteLine(result);
    }

    private static  bool IsIsomorphic(string s, string t)
    {
        if (s.Distinct().Count() != t.Distinct().Count())
            return false;

        var matchedLetters = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (matchedLetters.ContainsKey(s[i]))
            {
                if (matchedLetters[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                matchedLetters.Add(s[i], t[i]);
            }
        }

        return true;
    }

    private static (string, string) GetInitialData()
    {
        return ("egg", "ada");
    }
}