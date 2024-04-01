namespace _1._Two_Sum;

abstract class Solution
{
    static void Main()
    {
        var (nums, target) = GetInitialData();
        var results = TwoSum(nums, target);
        OutputResult(results);
        
    }

    private static void OutputResult(int[] results)
    {
        foreach (var num in results)
        {
            Console.WriteLine(num);
        }
    }

    private static int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }

    private static (int[], int) GetInitialData()
    {
        var nums = new[] { 3,2,4 };
        return (nums, 6);
    }
}