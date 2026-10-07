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
    public void ReorderList(ListNode head) {
     
     if(head == null || head.next == null){
        return;
     }
       ListNode slow = head;
       ListNode fast = head; 

       while(fast != null && fast.next != null){
        slow= slow.next;
        fast= fast.next.next;
       }
       ListNode second = slow.next;
       slow.next = null;

       ListNode prev = null;
       while(second != null){
        ListNode next = second.next;
        second.next = prev;
        prev=second;
        second = next;
       }
       second = prev;

        ListNode first = head;

        while (second != null)
        {
            ListNode firstNext = first.next;
            ListNode secondNext = second.next;

            first.next = second;
            second.next = firstNext;

            first = firstNext;
            second = secondNext;
        }
    }
}
