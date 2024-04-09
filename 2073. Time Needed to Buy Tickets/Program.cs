namespace _2073._Time_Needed_to_Buy_Tickets;

abstract class Solution
{
    static void Main()
    {
        var (tickets, k) = GetInitialNumbers();
        var results = TimeRequiredToBuy(tickets, k);
        OutputResult(results);
        
    }

    private static void OutputResult(int result)
    {
        Console.Write(result);
    }

    private static int TimeRequiredToBuy(int[] tickets, int k)
    {
        var ticketsList = new List<int>(tickets);
        var timeToBuy = 0;
        var ticketsToBuy = ticketsList[k];
        var currentBuyer = 0;
        while (ticketsToBuy != 0)
        {
            if (currentBuyer == ticketsList.Count)
            {
                currentBuyer = 0;
            }
            
            if (ticketsList[currentBuyer] > 0)
            {
                ticketsList[currentBuyer]--;
                timeToBuy++;
            }

            if (currentBuyer == k)
            {
                ticketsToBuy--;
            }

            currentBuyer++;
        }

        return timeToBuy;
    }

    private static (int[], int) GetInitialNumbers()
    {
        var tickets = new[] {2,3,2};
        var k = 2;
        
        return (tickets, k);
    }
}