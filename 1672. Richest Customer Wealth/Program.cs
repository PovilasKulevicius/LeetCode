namespace _1672._Richest_Customer_Wealth;

abstract class Solution
{
    static void Main()
    {
        var numbers = GetInitialNumbers();
        var results = CalculateWealthOfRichestPerson(numbers);
        OutputResult(results);
    }

    private static void OutputResult(int result)
    {
        Console.Write(result);
    }

    private static int CalculateWealthOfRichestPerson(int[,] numbers)
    {
        var richest = 0;
        var currentWealth = 0;

        for (var i = 0; i < numbers.GetLength(0); i++)
        {
            for (var j = 0; j < numbers.GetLength(1); j++)
                currentWealth += numbers[i, j];

            if (currentWealth > richest)
                richest = currentWealth;

            currentWealth = 0;
        }

        return richest;
    }

    private static int[,] GetInitialNumbers()
    {
        return new [,]
        {
            {7,1,3},
            {2,8,7},
            {1,9,5}
        };
    }
}