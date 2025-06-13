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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> l = [];
        var newHead = new ListNode(0, head);
        var cur = newHead;
        while(cur != null){
            l.Add(cur);
            cur = cur.next;
        } 
        var node = l[(l.Count - n) - 1];
        node.next = node.next.next;
        return newHead.next;
    }
}