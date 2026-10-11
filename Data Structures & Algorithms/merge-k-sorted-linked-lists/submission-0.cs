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

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        
        var pq = new PriorityQueue<ListNode, int>();

        foreach(ListNode node in lists){
            if(node != null){
                pq.Enqueue(node,node.val);
            }
        }
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while(pq.Count > 0){
            ListNode smallest = pq.Dequeue();
            current.next = smallest;
            current = current.next;

            if(smallest.next !=  null){
                pq.Enqueue(smallest.next, smallest.next.val);
            }
        }
        current.next = null;
        return dummy.next;
    }
}
