namespace _442._Find_All_Duplicates_in_an_Array;

abstract class Solution
{
    static void Main()
    {
        var input = GetInput();
        var results = FindDuplicates3(input);
        OutputResult(results);
    }

    private static void OutputResult(IList<int> nums)
    {
        foreach (var num in nums)
        {
            Console.WriteLine(num);   
        }
    }
    
    private static IList<int> FindDuplicates(int[] nums)
    {
        var results = new List<int>();
        var sortedNumbers = nums.Order().ToList();
        for (var i = 0; i < sortedNumbers.Count - 1; i++)
        {
            if (sortedNumbers[i] == sortedNumbers[i+1])
            {
                results.Add(sortedNumbers[i]);
            }
        }

        return results;
    }
    
    private static IList<int> FindDuplicates2(int[] nums)
    {
        var sortedNumbers = nums.Order().ToList();
        return sortedNumbers.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).ToList();
    }
    
    private static IList<int> FindDuplicates3(int[] nums)
    {
        var array = new int[nums.Length + 1];
        var result = new List<int>();
        foreach (var num in nums)
        {
            array[num] += 1;
            if (array[num] > 1)
            {
                result.Add(num);
            }
        }

        return result;
    }
    
    private static int[] GetInput()
    {
        return new[] { 1, 3, 4, 2, 2 };
    }
}