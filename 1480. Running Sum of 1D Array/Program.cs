namespace _1480._Running_Sum_of_1D_Array;

abstract class Solution
{
    static void Main()
    {
        var numbers = GetInitialNumbers();
        var results = CalculateRunningSum(numbers);
        OutputResult(results);
    }

    private static void OutputResult(List<int> results)
    {
        for (var i = 0; i < results.Count; i++)
        {
            Console.Write(results[i]);
            if (i != results.Count - 1)
            {
                Console.Write(", ");
            }
        }
    }

    private static List<int> CalculateRunningSum(int[] numbers)
    {
        var results = new List<int>();
        results.Add(numbers[0]);
        
        for (var i = 1; i < numbers.Length; i++)
            results.Add(results[i - 1] + numbers[i]);

        return results;
    }

    private static int[] GetInitialNumbers()
    {
        Console.WriteLine("Enter numbers separated only with comma:");
        var numberStrings = Console.ReadLine()?.Split(',');
        if (numberStrings == null)
            throw new ArgumentException("No input");

        var numbers = Array.ConvertAll(numberStrings, int.Parse);
        return numbers;
    }
}