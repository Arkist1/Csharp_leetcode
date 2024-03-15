/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        return [];
    }
}


class Case {
    public ListNode input1 {get; set;}
    public ListNode input2 {get; set;}
    public List<int> output {get; set;}
}

class Program
{
    static void Main(string[] args) {
        Solution obj = new Solution();

        List<Case> cases = new List<Case> {
            new Case {input1=[1,2,4], input2=[1,3,4], output=[1,1,2,3,4,4]}, 
            new Case {input1=[], input2=[], output=[]}, 
            new Case {input1=[], input2=[0], output=[0]}}; 

        foreach(Case i in cases)
        {
            Console.WriteLine("Case: {0} {1}", i.input1, i.input2);
            Console.WriteLine("Expected: {0}", i.output);
            Console.WriteLine("Function: {0}", obj.MergeTwoLists(i.input1, i.input2));
        }
    }
}