namespace _2958._Length_of_Longest_Subarray_With_at_Most_K_Frequency;

abstract class Solution
{
    static void Main()
    {
        var (nums, k) = GetInitialNumbers();
        var results = MaxSubarrayLength(nums, k);
        OutputResult(results);
        
    }

    private static void OutputResult(int result)
    {
        Console.Write(result);
    }

    // TODO this solution works when the subarray doesnt need to be contiguous. Change it to work with contiguous array
    private static int  MaxSubarrayLength(int[] nums, int k)
    {
        var frequencies = new Dictionary<int, int>();
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (frequencies.ContainsKey(nums[i])) 
                continue;
            
            var frequency = 0;

            for (var j = 0; j < nums.Length && frequency < k; j++)
            {
                if (nums[j] == nums[i])
                {
                    frequency++;
                }
            }

            frequencies.Add(nums[i], frequency);
        }

        return frequencies.Sum(x => x.Value);
    }

    private static (int[], int) GetInitialNumbers()
    {
        var nums = new[] {1,4,4,3 };
        var k = 1;
        
        return (nums, k);
    }
}