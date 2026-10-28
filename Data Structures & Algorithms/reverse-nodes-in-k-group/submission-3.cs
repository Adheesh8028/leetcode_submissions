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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null || k<= 1){
            return head;
        }

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode groupPrev = dummy;
       while(true){
        ListNode kth = groupPrev;
        for(int i = 0; i < k; i++){
            kth = kth.next;
           if(kth == null){
            return dummy.next;
           }
        }
        ListNode groupNext = kth.next;

        ListNode prev = groupNext;
        ListNode curr = groupPrev.next;

        while(curr != groupNext){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        ListNode tempNode = groupPrev.next;
        groupPrev.next = kth;
        groupPrev = tempNode;
       }
        
    }
}
