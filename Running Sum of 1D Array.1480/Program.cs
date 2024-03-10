// See https://aka.ms/new-console-template for more information

internal class LeetCode
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated only with comma:");
        var numberStrings = Console.ReadLine()?.Split(',');
        if (numberStrings == null)
        {
            throw new ArgumentException("No input");
        }

        var numbers = Array.ConvertAll(numberStrings, int.Parse);

        var results = new List<int>();
        for (var i = 0; i < numbers.Length; i++)
        {
            if (results.Count == 0)
            {
                results.Add(numbers[i]);
            }
            else
            {
                results.Add(results[i - 1] + numbers[i]);
            }
        }

        for (var i = 0; i < results.Count; i++)
        {
            Console.Write(results[i]);
            if (i != results.Count - 1)
            {
                Console.Write(", ");
            }
        }
    }
}