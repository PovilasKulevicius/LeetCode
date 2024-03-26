using System.Collections.Immutable;

namespace _41._First_Missing_Positive;

abstract class Solution
{
    static void Main()
    {
        var input = GetInput();
        var results = FirstMissingPositive(input);
        OutputResult(results);
    }

    private static int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);
        var result = 0;
        foreach (var num in nums)
        {
            if (num == result + 1)
            {
                result += 1;
            }
            else if (num > 0 && num != result)
            {
                return result + 1;   
            }
        }

        return result + 1;
    }
    
    private static void OutputResult(int num)
    {
        Console.WriteLine(num);
    }

    private static int[] GetInput()
    {
        return new[] { 1, 2, 0 };
    }
}