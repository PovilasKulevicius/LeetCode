using Microsoft.VisualBasic;

namespace _412._Fizz_Buzz;

abstract class Solution
{
    static void Main()
    {
        var input = GetInput();
        var results = PlayFizzBuzz(input);
        OutputResult(results);
        
    }

    private static void OutputResult(string[] results)
    {
        var i = 0;
        foreach (var result in results)
        {
            Console.Write(result);
            
            if (i != results.Length - 1)
                Console.Write(", ");
            
            i++;
        }
    }

    private static string[] PlayFizzBuzz(int input)
    {
        var result = new string[input];
        for (var i = 1; i <= input; i++)
        {
            var outputIndex = i - 1;
            
            if (i % 3 == 0 && (i % 5 == 0))
                result[outputIndex] = "FizzBuzz";
            else if (i % 3 == 0)
                result[outputIndex] = "Fizz";
            else if (i % 5 == 0)
                result[outputIndex] = "Buzz";
            else
                result[outputIndex] = i.ToString();
        }

        return result;
    }

    private static int GetInput()
    {
        return 15;
    }
}