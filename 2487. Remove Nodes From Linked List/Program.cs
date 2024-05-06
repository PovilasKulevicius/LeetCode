namespace _2487._Remove_Nodes_From_Linked_List;

public class ListNode { 
    public int val;
    public ListNode? next;     
    public ListNode(int val=0, ListNode? next=null) { 
        this.val = val; 
        this.next = next; 
    }
 }

abstract class Solution
{
    static void Main()
    {
        var nodes = GetInitialNumbers();
        var results = RemoveNodes(nodes);
        OutputResult(results);
        
    }

    public static ListNode RemoveNodes(ListNode? head)
    {
        var current = new ListNode();
        var start = current;
        
        while (head.next != null)
        {
            if (head.next != null && 
                head.next.val < head.val)
            {
                current = new ListNode(head.val, null);
                current = current.next;
            } 
            else if (head.next == null)
            {
                
            }
            
            head = head.next;
        }

        return start;
    }
    
    private static void OutputResult(ListNode result)
    {
        while (result.next != null)
        {
            Console.Write(result.val);
        }
    }

    private static ListNode GetInitialNumbers()
    {
        var list = new int[]{5,2,13,3,8};
        var currentNode = new ListNode();
        var start = currentNode;
        ListNode nextNode;
        
        foreach (var member in list)
        {
            nextNode = new ListNode();
            currentNode.val = member;
            currentNode.next = nextNode;
            currentNode = nextNode;
        }
        
        return start;
    }
}