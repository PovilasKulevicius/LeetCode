namespace _287._Find_the_Duplicate_Number;

abstract class Solution
{
    static void Main()
    {
        var input = GetInput();
        var results = FindDuplicate2(input);
        OutputResult(results);
        
    }

    private static void OutputResult(int num)
    {
        Console.WriteLine(num);
    }

    private static int FindDuplicate1(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i != j)
                {
                    return nums[i];
                }
            }
        }

        throw new Exception("No numbers found!");
    }
    
    private static int FindDuplicate2(int[] nums)
    {
        var sortedNumbers = nums.Order().ToList();
        for (var i = 0; i < sortedNumbers.Count; i++)
        {
            if (sortedNumbers[i] == sortedNumbers[i+1])
            {
                return sortedNumbers[i];
            }
        }

        return 0;
    }
    
    private static int[] GetInput()
    {
        return new[] { 1, 3, 4, 2, 2 };
    }
}