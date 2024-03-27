namespace _713._Subarray_Product_Less_Than_K;

abstract class Solution
{
    static void Main()
    {
        var (nums, k) = GetInitialNumbers();
        var results = NumSubarrayProductLessThanK(nums, k);
        OutputResult(results);
    }

    private static int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1) 
            return 0;
        
        var result = 0;
        var product = 1;
        var left = 0;
        
        for (var right = 0; right < nums.Length; right++) {
            product *= nums[right];
            
            while (product >= k && left <= right) {
                product /= nums[left];
                left++;
            }

            result += right - left + 1;
        }

        return result;
    }
    
    private static void OutputResult(int result)
    {
        Console.WriteLine(result);
    }

    private static (int[], int) GetInitialNumbers()
    {
        var nums = new[] { 10, 5, 2, 6 };
        var k = 100;
        
        return (nums, k);
    }
}