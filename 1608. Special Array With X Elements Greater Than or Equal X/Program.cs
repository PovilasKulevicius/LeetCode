namespace _1608._Special_Array_With_X_Elements_Greater_Than_or_Equal_X;

abstract class Solution
{
    static void Main()
    {
        var s = GetInitialData();
        var results = SpecialArray(s);
        OutputResult(results);
        
    }

    static int SpecialArray(int[] nums) 
    {
        var greater = new Dictionary<int, int>();

        for (var i = 1; i <= nums.Length; i++)
        {
            greater.Add(i, 0);
            foreach (var num in nums)
            {
                if (num >= i)
                {
                    greater[i]++;
                }
            }
        }

        for (var i = 1; i <= greater.Count; i++)
        {
            if (i == greater[i])
            {
                return i;
            }
        }
        
        return -1;
    }

    private static int[] GetInitialData()
    {
        return new []{0,4,3,0,4};
    }
    
    private static void OutputResult(int result)
    {
        Console.WriteLine(result);
    }
}