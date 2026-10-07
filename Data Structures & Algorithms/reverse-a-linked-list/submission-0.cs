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
    public ListNode ReverseList(ListNode head) {
       ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode next = current.next; // Save next node
            current.next = prev;          // Reverse the pointer
            prev = current;               // Move prev forward
            current = next;               // Move current forward
        }

        return prev; 
    }
}
