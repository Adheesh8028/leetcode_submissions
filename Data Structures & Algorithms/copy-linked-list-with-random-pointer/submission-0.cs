/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        
        if(head == null){
            return null;
        }
        Dictionary<Node, Node> map = new Dictionary<Node,Node>();
        Node current = head;

        while(current != null){
            map[current] = new Node(current.val);
            current = current.next;
        }
        current = head;
        while(current != null){
            map[current].next = current.next == null ? null : map[current.next];
            map[current].random = current.random == null ? null :  map[current.random];

            current = current.next;
        }
        return map[head];
    }
}
