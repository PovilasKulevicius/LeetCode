namespace _2962._Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times;

abstract class Solution
{
    static void Main()
    {
        var (nums, k) = GetInitialNumbers();
        var results = CountSubarrays(nums, k);
        OutputResult(results);
        
    }

    private static void OutputResult(long result)
    {
        Console.Write(result);
    }

    private static long CountSubarrays(int[] nums, int k)
    {
       var frequencies = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (frequencies.ContainsKey(nums[i]))
                continue;
            
            var frequency = 0;

            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                    frequency++;
            }

            frequencies.Add(nums[i], frequency);
        }

        var mostFrequentNumber = frequencies.First(x => x.Value == frequencies.Values.Max()).Key;

        var goodSubarrays = 0;
        var lastNumberOfAppereances = 0;
        var elementReached = 0;
        
        for (var i = 0; i < nums.Length;)
        {
            var numberOfAppereances = 0;
            
            for (var j = i; j < nums.Length; j++)
            {
                elementReached = j + 1;
                if (nums[j] == mostFrequentNumber)
                {
                    numberOfAppereances++;
                }
                
                if (numberOfAppereances >= k && numberOfAppereances > lastNumberOfAppereances)
                {
                    lastNumberOfAppereances = numberOfAppereances;
                    break;
                }
            }

            if (numberOfAppereances >= k)
            {
                goodSubarrays++;
            }

            if (elementReached == nums.Length)
            {
                i++;
                lastNumberOfAppereances = 0;
            }
        }
        
        return goodSubarrays;
    }

    private static (int[], int) GetInitialNumbers()
    {
        // TODO find bug
        // This should return 224 according to leet code
        var nums = new[] {61,23,38,23,56,40,82,56,82,82,82,70,8,69,8,7,19,14,58,42,82,10,82,78,15,82};
        var k = 2;
        
        return (nums, k);
    }
}