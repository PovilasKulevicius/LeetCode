namespace _58._Length_of_Last_Word;

abstract class Solution
{
    static void Main()
    {
        var words = GetInitialData();
        var results = LengthOfLastWord(words);
        OutputResult(results);
        
    }

    private static void OutputResult(int result)
    {
        Console.Write(result);
    }

    private static int LengthOfLastWord(string s)
    {
        var seperatedWords = s.Split(' ');
        var lastWord = seperatedWords.Last(x => x != "");
        return lastWord.Length;
    }

    private static string GetInitialData()
    {
        return "   fly me   to   the moon  ";
    }
}