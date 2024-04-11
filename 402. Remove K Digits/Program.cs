namespace _2073._Time_Needed_to_Buy_Tickets;

abstract class Solution
{
    static void Main()
    {
        var (tickets, k) = GetInitialNumbers();
        var results = RemoveKdigits(tickets, k);
        OutputResult(results);
        
    }

    private static string RemoveKdigits(string num, int k)
    {
        if (k != 1)
        {
            num = RemoveKdigits(num, k - 1);
        }

        var lowestNumber = int.Parse(num);
        
        for (var i = 0; i < num.Length; i++)
        {
            var numWithRemovedInteger = num.Remove(i, 1);
            var parsedNum = numWithRemovedInteger == "" ? 0 : int.Parse(numWithRemovedInteger);

            if (parsedNum < lowestNumber)
            {
                lowestNumber = parsedNum;
            }
        }

        return lowestNumber.ToString();
    }

    private static void OutputResult(string result)
    {
        Console.Write(result);
    }
    
    private static (string, int) GetInitialNumbers()
    {
        return ("10", 2);
    }
}